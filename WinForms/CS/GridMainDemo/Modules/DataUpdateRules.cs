using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DevExpress.Data;
using System.Diagnostics;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    public partial class DataUpdateRules : TutorialControl {
        ChangeThread chtr;
        Thread tr;
        RealTimeSource realTimeSource;
        System.Windows.Forms.Timer chartingTimer;
        bool isHide = true;

        public DataUpdateRules() {
            InitializeComponent();
            this.Disposed += DataUpdateRules_Disposed;
            ceShowConditionalFormattingItem.Checked = gridView1.OptionsMenu.ShowConditionalFormattingItem;
        }
        //protected override string[] WhatsThisCodeFileNames {
        //    get { return new string[] { "DataUpdateRules" }; }
        //}
        //protected override string WhatsThisXMLFileName {
        //    get { return "DataUpdateRules"; }
        //}

        void DataUpdateRules_Disposed(object sender, EventArgs e) {
            DoHide();
        }
        protected override void DoShow() {
            base.DoShow();
            isHide = false;
            chtr = new ChangeThread(SynchronizationContext.Current);
            trackBarControl1.Value = 5;
            PatchInterval();
            realTimeSource = new RealTimeSource() { DataSource = chtr.List };
            gridControl1.DataSource = realTimeSource;
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
        }
        void PatchInterval() {
            if(chtr == null)
                return;
            int pos = 20 + trackBarControl1.Properties.Maximum - trackBarControl1.Value;
            Volatile.Write(ref this.chtr.InterEventDelay, pos < 0 ? 0 : (int)(10 * Math.Pow(1.5, pos)));
        }

        private void trackBarControl1_EditValueChanged(object sender, EventArgs e) {
            PatchInterval();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(edit == null) return;
            gridView1.OptionsMenu.ShowConditionalFormattingItem = edit.Checked;
        }

        private void gridView1_FormatRuleDataUpdateCustomTrigger(object sender, Views.Grid.FormatRuleGridDataUpdateTriggerEventArgs e) {
            if((double)e.NewValue - (double)e.OldValue > 12)
                e.Trigger = true; 
        }
    }
}
