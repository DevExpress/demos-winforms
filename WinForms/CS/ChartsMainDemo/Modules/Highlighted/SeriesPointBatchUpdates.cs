using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class SeriesPointBatchUpdatesDemo : ChartDemoModule {
        const int SamplingFrequency = 22050; //Hz
        const int DefaultFrameLength = 2048;
        const double sixteenBitSampleMaxVale = short.MaxValue;
        const double MinDb = -500d;

        int frameStartIndex = 0;
        int frameEndIndex = DefaultFrameLength - 1;
        readonly Timer timer = new Timer();
        readonly double[] averageChannelNormalized;
        readonly double[] realSpectrum;
        readonly double[] imaginarySpectrum;
        readonly double[] zeroSpectrum;
        DateTime last;

        SeriesPointCollection LeftChannelPoints { get { return ((SeriesPointCollectionDataAdapter)chart.Series[0].DataAdapter).Points; } }
        SeriesPointCollection RightChannelPoints { get { return ((SeriesPointCollectionDataAdapter)chart.Series[1].DataAdapter).Points; } }
        SeriesPointCollection FrequencySpectrumPoints { get { return ((SeriesPointCollectionDataAdapter)chart.Series[2].DataAdapter).Points; } }

        internal override ChartControl ChartControl {
            get { return chart; }
        }
        internal override object ExportedObject {
            get { return null; }
        }
        internal override bool ChartDesignerEnabled {
            get { return false; }
        }

        public SeriesPointBatchUpdatesDemo() {
            InitializeComponent();
            using(Stream stream = AssemblyHelper.GetEmbeddedResourceStream(typeof(CsvReader).Assembly, "sound.bin", false)) {
                Debug.Assert(stream.Length < int.MaxValue);
                int streamLength = (int)stream.Length;
                byte[] buffer = new byte[streamLength];
#if NET
                stream.ReadExactly(buffer);
#else
                stream.Read(buffer, 0, streamLength);
#endif
                int halfStreamLength = (int)(stream.Length / 2);                   //Avoid VB issues
                short[] sampleBuffer = new short[halfStreamLength];
                System.Buffer.BlockCopy(buffer, 0, sampleBuffer, 0, streamLength); //do not delete System - avoid VB issues
                int halfBufferLength = sampleBuffer.Length / 2;             //Avoid VB issues
                SeriesPoint[] leftChannelPoints = new SeriesPoint[halfBufferLength];
                SeriesPoint[] rightChannelPoints = new SeriesPoint[halfBufferLength];
                averageChannelNormalized = new double[halfBufferLength];
                for(int i = 1, k = 0; i < sampleBuffer.Length; i += 2, k++) {
                    double seconds = (i / 2) * (1.0 / SamplingFrequency);
                    double normalizedValueOfLeftChannel = sampleBuffer[i] / sixteenBitSampleMaxVale;
                    double normalizedValueOfRightChannel = sampleBuffer[i - 1] / sixteenBitSampleMaxVale;
                    leftChannelPoints[k] = new SeriesPoint(TimeSpan.FromSeconds(seconds), normalizedValueOfLeftChannel);
                    rightChannelPoints[k] = new SeriesPoint(TimeSpan.FromSeconds(seconds), normalizedValueOfRightChannel);
                    averageChannelNormalized[k] = (normalizedValueOfLeftChannel + normalizedValueOfRightChannel) / 2d;
                }
                LeftChannelPoints.AddRange(leftChannelPoints);
                RightChannelPoints.AddRange(rightChannelPoints);
                realSpectrum = new double[DefaultFrameLength];
                imaginarySpectrum = new double[DefaultFrameLength];
                zeroSpectrum = new double[DefaultFrameLength];
            }
            int halfOfFrame = DefaultFrameLength / 2;
            double frequencyStep = SamplingFrequency / 2d / halfOfFrame;
            SeriesPoint[] frequencyPoints = new SeriesPoint[halfOfFrame];
            for(int i = 0; i < halfOfFrame; i++)
                frequencyPoints[i] = new SeriesPoint(frequencyStep * i, 0);
            FrequencySpectrumPoints.AddRange(frequencyPoints);
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
            last = DateTime.Now;
        }

        void Timer_Tick(object sender, EventArgs e) {
            DateTime current = DateTime.Now;
            double span = MainFormHelper.TakeScreens ? 0 : (current - last).TotalSeconds;
            last = current;
            MoveFrameAndStrip((int)(span * SamplingFrequency));
            RecalculateFrequencySpectrum();
        }
        void MoveFrameAndStrip(int offset) {
            int newEndIndex = frameEndIndex + offset;
            if(newEndIndex < averageChannelNormalized.Length) {
                frameStartIndex += offset;
                frameEndIndex = newEndIndex;
            }
            else {
                frameStartIndex = 0;
                frameEndIndex = DefaultFrameLength;
            }
            Strip currentFrameStrip = ((SwiftPlotDiagram)chart.Diagram).AxisX.Strips[0]; //test
            currentFrameStrip.MinLimit.AxisValue = TimeSpan.MinValue;
            currentFrameStrip.MaxLimit.AxisValue = TimeSpan.MaxValue; //avoiding errors on frame jumping to begin
            currentFrameStrip.MinLimit.AxisValue = TimeSpan.FromSeconds(1d / SamplingFrequency * frameStartIndex);
            currentFrameStrip.MaxLimit.AxisValue = TimeSpan.FromSeconds(1d / SamplingFrequency * frameEndIndex);
        }
        void RecalculateFrequencySpectrum() {
            Array.Copy(averageChannelNormalized, frameStartIndex, realSpectrum, 0, DefaultFrameLength);
            Array.Copy(zeroSpectrum, 0, imaginarySpectrum, 0, DefaultFrameLength);
            FastFourierTransformation.Transform(realSpectrum, imaginarySpectrum);
            SeriesPoint[] newPoints = new SeriesPoint[DefaultFrameLength / 2];
            for(int i = 0; i < DefaultFrameLength / 2; i++) {
                double magnitude = Math.Sqrt(realSpectrum[i] * realSpectrum[i] + imaginarySpectrum[i] * imaginarySpectrum[i]);
                double magnitudeDB = magnitude != 0 ? 20d * Math.Log10(magnitude) : MinDb;
                newPoints[i] = new SeriesPoint(FrequencySpectrumPoints[i].Argument, magnitudeDB);
            }
            FrequencySpectrumPoints.Clear();
            FrequencySpectrumPoints.AddRange(newPoints);
        }

        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null)
                    components.Dispose();
                if(timer != null) {
                    timer.Stop();
                    timer.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}
