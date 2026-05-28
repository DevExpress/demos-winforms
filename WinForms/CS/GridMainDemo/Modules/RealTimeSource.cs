using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Collections;
using System.Diagnostics;
using DevExpress.Data;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using System.ComponentModel;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace DevExpress.XtraGrid.Demos {
    public partial class RealTimeSourceDemo : TutorialControl {
        ChangeThread chtr;
        Thread tr;
        //<gridControl1>
        RealTimeSource realTimeSource;
        //</gridControl1>
        System.Windows.Forms.Timer chartingTimer;

        bool isHide = true;
        public RealTimeSourceDemo() {
            InitializeComponent();
            this.Disposed += RealTimeSourceDemo_Disposed;
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "RealTimeSource" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "RealTimeSource"; }
        }

        void RealTimeSourceDemo_Disposed(object sender, EventArgs e) {
            DoHide();
        }
        protected override void DoShow() {
            base.DoShow();
            isHide = false;
            chtr = new ChangeThread(SynchronizationContext.Current);
            trackBar1.Value = 16;
            PatchInterval();
            realTimeSource = new RealTimeSource() { DataSource = chtr.List };
            gridControl1.DataSource = realTimeSource;
            chartControl1.Series["UPSDiagram"].Points.Clear();
            chartControl1.Series["UPSDiagram"].Label.TextPattern = "{V:n0}";
            chartingTimer = new System.Windows.Forms.Timer() { Interval = 100 };
            chartingTimer.Tick += DoCharting;
            chartingTimer.Start();
            tr = new Thread(chtr.Do) { IsBackground = true };
            tr.Start();
        }

        protected override void DoHide() {
            isHide = true;
            if(chartingTimer != null) {
                chartingTimer.Dispose();
                chartingTimer = null;
            }
            if(chtr != null) {
                chtr.Stop();
                if(tr != null) {
                    tr.Join();
                    tr = null;
                }
                chtr = null;
            }
			gridControl1.DataSource = null;
			if(realTimeSource != null) {
                realTimeSource.Dispose();
                realTimeSource = null;
            }
            base.DoHide();
        }
        readonly Stopwatch chartingWatchPacer = Stopwatch.StartNew();
        readonly Stopwatch chartingTimeAxis = Stopwatch.StartNew();
        void DoCharting(object sender, EventArgs e) {
            if(isHide || chtr == null)
                return;
            var updateMilliseconds = TimeSpan.TicksPerSecond / 10 >= Volatile.Read(ref chtr.InterEventDelay) ? 500 : 1000;
            if(chartingWatchPacer.ElapsedMilliseconds < updateMilliseconds)
                return;
            var rate = this.chtr.GetRate();
            if(!rate.HasValue)
                return;
            chartingWatchPacer.Restart();
            while(chartControl1.Series["UPSDiagram"].Points.Count >= 20) {
                chartControl1.Series["UPSDiagram"].Points.RemoveAt(0);
            }
            chartControl1.Series["UPSDiagram"].Points.Add(new SeriesPoint(chartingTimeAxis.Elapsed.TotalSeconds, rate.Value));
        }
        private void trackBar1_Scroll(object sender, EventArgs e) {
            PatchInterval();
        }
        void PatchInterval() {
            if(chtr == null)
                return;
            int pos = this.trackBar1.Properties.Maximum - this.trackBar1.Value - 1;
            Volatile.Write(ref this.chtr.InterEventDelay, pos < 0 ? 0 : (int)(10 * Math.Pow(1.5, pos)));
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e) {
            double val = Convert.ToDouble(gridView1.GetRowCellValue(e.RowHandle, "ChgPercent"));
            if(val < 0)
                e.Appearance.ForeColor = DXSkinColors.ForeColors.Critical;
        }
    }
}
