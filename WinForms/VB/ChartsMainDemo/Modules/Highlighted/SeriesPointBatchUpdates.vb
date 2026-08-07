Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class SeriesPointBatchUpdatesDemo
        Inherits ChartDemoModule

        Const SamplingFrequency As Integer = 22050 'Hz

        Const DefaultFrameLength As Integer = 2048

        Const sixteenBitSampleMaxVale As Double = Short.MaxValue

        Const MinDb As Double = -500R

        Private frameStartIndex As Integer = 0

        Private frameEndIndex As Integer = DefaultFrameLength - 1

        Private ReadOnly timer As Timer = New Timer()

        Private ReadOnly averageChannelNormalized As Double()

        Private ReadOnly realSpectrum As Double()

        Private ReadOnly imaginarySpectrum As Double()

        Private ReadOnly zeroSpectrum As Double()

        Private last As Date

        Private ReadOnly Property LeftChannelPoints As SeriesPointCollection
            Get
                Return CType(chart.Series(0).DataAdapter, SeriesPointCollectionDataAdapter).Points
            End Get
        End Property

        Private ReadOnly Property RightChannelPoints As SeriesPointCollection
            Get
                Return CType(chart.Series(1).DataAdapter, SeriesPointCollectionDataAdapter).Points
            End Get
        End Property

        Private ReadOnly Property FrequencySpectrumPoints As SeriesPointCollection
            Get
                Return CType(chart.Series(2).DataAdapter, SeriesPointCollectionDataAdapter).Points
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Friend Overrides ReadOnly Property ExportedObject As Object
            Get
                Return Nothing
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartDesignerEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Using stream As Stream = AssemblyHelper.GetEmbeddedResourceStream(GetType(CsvReader).Assembly, "sound.bin", False)
                Call Debug.Assert(stream.Length < Integer.MaxValue)
                Dim streamLength As Integer = CInt(stream.Length)
                Dim buffer As Byte() = New Byte(streamLength - 1) {}
#If NET
                stream.ReadExactly(buffer);
#Else
                stream.Read(buffer, 0, streamLength)
#End If
                Dim halfStreamLength As Integer = CInt(stream.Length / 2) 'Avoid VB issues
                Dim sampleBuffer As Short() = New Short(halfStreamLength - 1) {}
                System.Buffer.BlockCopy(buffer, 0, sampleBuffer, 0, streamLength) 'do not delete System - avoid VB issues
                Dim halfBufferLength As Integer = sampleBuffer.Length \ 2 'Avoid VB issues
                Dim leftChannelPoints As SeriesPoint() = New SeriesPoint(halfBufferLength - 1) {}
                Dim rightChannelPoints As SeriesPoint() = New SeriesPoint(halfBufferLength - 1) {}
                averageChannelNormalized = New Double(halfBufferLength - 1) {}
                Dim i As Integer = 1, k As Integer = 0
                While i < sampleBuffer.Length
                    Dim seconds As Double =(i \ 2) * (1.0 / SamplingFrequency)
                    Dim normalizedValueOfLeftChannel As Double = sampleBuffer(i) / sixteenBitSampleMaxVale
                    Dim normalizedValueOfRightChannel As Double = sampleBuffer(i - 1) / sixteenBitSampleMaxVale
                    leftChannelPoints(k) = New SeriesPoint(TimeSpan.FromSeconds(seconds), normalizedValueOfLeftChannel)
                    rightChannelPoints(k) = New SeriesPoint(TimeSpan.FromSeconds(seconds), normalizedValueOfRightChannel)
                    averageChannelNormalized(k) =(normalizedValueOfLeftChannel + normalizedValueOfRightChannel) / 2R
                    i += 2
                    k += 1
                End While

                Me.LeftChannelPoints.AddRange(leftChannelPoints)
                Me.RightChannelPoints.AddRange(rightChannelPoints)
                realSpectrum = New Double(2047) {}
                imaginarySpectrum = New Double(2047) {}
                zeroSpectrum = New Double(2047) {}
            End Using

            Dim halfOfFrame As Integer = DefaultFrameLength \ 2
            Dim frequencyStep As Double = SamplingFrequency / 2R / halfOfFrame
            Dim frequencyPoints As SeriesPoint() = New SeriesPoint(halfOfFrame - 1) {}
            For i As Integer = 0 To halfOfFrame - 1
                frequencyPoints(i) = New SeriesPoint(frequencyStep * i, 0)
            Next

            FrequencySpectrumPoints.AddRange(frequencyPoints)
            timer.Interval = 10
            AddHandler timer.Tick, AddressOf Timer_Tick
            timer.Start()
            last = Date.Now
        End Sub

        Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim current As Date = Date.Now
            Dim span As Double = If(MainFormHelper.TakeScreens, 0, (current - last).TotalSeconds)
            last = current
            MoveFrameAndStrip(CInt(span * SamplingFrequency))
            RecalculateFrequencySpectrum()
        End Sub

        Private Sub MoveFrameAndStrip(ByVal offset As Integer)
            Dim newEndIndex As Integer = frameEndIndex + offset
            If newEndIndex < averageChannelNormalized.Length Then
                frameStartIndex += offset
                frameEndIndex = newEndIndex
            Else
                frameStartIndex = 0
                frameEndIndex = DefaultFrameLength
            End If

            Dim currentFrameStrip As Strip = CType(chart.Diagram, SwiftPlotDiagram).AxisX.Strips(0) 'test
            currentFrameStrip.MinLimit.AxisValue = TimeSpan.MinValue
            currentFrameStrip.MaxLimit.AxisValue = TimeSpan.MaxValue 'avoiding errors on frame jumping to begin
            currentFrameStrip.MinLimit.AxisValue = TimeSpan.FromSeconds(1R / SamplingFrequency * frameStartIndex)
            currentFrameStrip.MaxLimit.AxisValue = TimeSpan.FromSeconds(1R / SamplingFrequency * frameEndIndex)
        End Sub

        Private Sub RecalculateFrequencySpectrum()
            Array.Copy(averageChannelNormalized, frameStartIndex, realSpectrum, 0, DefaultFrameLength)
            Array.Copy(zeroSpectrum, 0, imaginarySpectrum, 0, DefaultFrameLength)
            Transform(realSpectrum, imaginarySpectrum)
            Dim newPoints As SeriesPoint() = New SeriesPoint(1023) {}
            For i As Integer = 0 To DefaultFrameLength \ 2 - 1
                Dim magnitude As Double = Math.Sqrt(realSpectrum(i) * realSpectrum(i) + imaginarySpectrum(i) * imaginarySpectrum(i))
                Dim magnitudeDB As Double = If(magnitude <> 0, 20R * Math.Log10(magnitude), MinDb)
                newPoints(i) = New SeriesPoint(FrequencySpectrumPoints(i).Argument, magnitudeDB)
            Next

            FrequencySpectrumPoints.Clear()
            FrequencySpectrumPoints.AddRange(newPoints)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then components.Dispose()
                If timer IsNot Nothing Then
                    timer.Stop()
                    timer.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
