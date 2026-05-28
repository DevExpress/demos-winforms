using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.Tutorials;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGantt.Printing;
using DevExpress.Drawing;
using DevExpress.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraGantt.Demos {
    public partial class MarketResearchSchedule : TutorialControl {
        public MarketResearchSchedule() {
            InitializeComponent();
            // <ganttControl1>
            ganttControl1.TreeListMappings.ParentFieldName = "ParentUID";
            ganttControl1.TreeListMappings.KeyFieldName = "UID";
            ganttControl1.ChartMappings.TextFieldName = "Name";
            ganttControl1.ChartMappings.InteractionTooltipTextFieldName = "Name";
            ganttControl1.ChartMappings.DurationFieldName = "Duration";
            ganttControl1.Load += GanttControl1_Load;
            LoadDataSource();
            Init();
            ganttControl1.ExpandAll();
            //</ganttControl1>
        }

        void GanttControl1_Load(object sender, EventArgs e) {
            deChartStartDate.EditValue = ganttControl1.GetChartActualStartDate();
            deChartFinishDate.EditValue = ganttControl1.GetChartActualFinishDate();
        }

        void Init() {
            cePrintLegend.Checked = ganttControl1.OptionsPrint.PrintLegend == DefaultBoolean.True;
            cePrintPageInfo.Checked = ganttControl1.OptionsPrint.PrintPageInfo == DefaultBoolean.True;
            cePrintAllNodes.Checked = ganttControl1.OptionsPrint.PrintAllNodes;
            tePageCaption.EditValue = DemoLinkHelper.GetModuleDisplayName(this);
            Array pageInfoTypes = Enum.GetValues(typeof(PageInfo));
            foreach(PageInfo value in pageInfoTypes)
                icePageInfoType.Properties.Items.Add(new ImageComboBoxItem(Enum.GetName(typeof(PageInfo), value), value, -1));
            icePageInfoType.EditValue = ganttControl1.OptionsPrint.PageInfoType;
            iceOrientation.Properties.Items.Add(new ImageComboBoxItem(Enum.GetName(typeof(PageOrientation), PageOrientation.Portrait), PageOrientation.Portrait, -1));
            iceOrientation.Properties.Items.Add(new ImageComboBoxItem(Enum.GetName(typeof(PageOrientation), PageOrientation.Landscape), PageOrientation.Landscape, -1));
            iceOrientation.EditValue = PageOrientation.Portrait;
            var values = Enum.GetValues(typeof(DXPaperKind));
            foreach(DXPaperKind value in values)
                icePaperKind.Properties.Items.Add(new ImageComboBoxItem(Enum.GetName(typeof(DXPaperKind), value), value, -1));
            icePaperKind.EditValue = DXPaperKind.Letter;
        }
        public override bool AllowPrintOptions {
            get { return true; }
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }
        public override GanttControl MainControl {
            get { return ganttControl1; }
        }
        protected override void PrintPreview() {
            if(this.MainControl != null) {
                try {
                    using(XtraGanttPrintingSystemBase ps = new XtraGanttPrintingSystemBase()) {
                        using(PrintableComponentLink link = new PrintableComponentLink()) {
                            link.PrintingSystemBase = ps;
                            link.Component = ganttControl1;
                            link.Landscape = (PageOrientation) iceOrientation.EditValue == PageOrientation.Landscape;
                            link.PaperKind = (DXPaperKind) icePaperKind.EditValue;
                            CreateDocument(link);
                            if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                                link.ShowRibbonPreviewDialog(LookAndFeel);
                            else
                                link.ShowPreviewDialog();
                        }
                    }
                }
                catch (Exception ex) {
                    NotificationService.ShowException<XtraGanttPrintingSystemBase>(LookAndFeel, FindForm(), ex);
                }
            }
        }
        ProgressWindow wnd;
        void CreateDocument(PrintableComponentLink link) {
            wnd = new ProgressWindow();
            using(wnd) {
                wnd.SetCaption(PrintingSystemActivity.Preparing);
                wnd.LookAndFeel.Assign(LookAndFeel);
                wnd.ShowCenter(FindForm());
                ProgressReflector reflector = new ProgressReflector();
                reflector.PositionChanged += ProcessReflectorPositionChanged;
                try {
                    link.PrintingSystemBase.ProgressReflector = reflector;
                    link.CreateDocument();
                }
                finally {
                    reflector.PositionChanged -= ProcessReflectorPositionChanged;
                    link.PrintingSystemBase.ResetProgressReflector();
                }
            }
        }

        void ProcessReflectorPositionChanged(object sender, EventArgs e) {
            if(wnd == null) return;
            wnd.SetProgress(((ProgressReflector)sender).Position);
        }
        void LoadDataSource() {
            using(var stream = LoadXml("MarketResearchSchedule.xml")) {
                IList<TaskDataItem> tasks = ProjectXMLLoader.LoadModel(stream);
                if(tasks != null && tasks.Count > 0) {
                    ProjectXMLLoader.TryUpdateDates(tasks);
                    ganttControl1.DataSource = tasks;
                    ganttControl1.ScheduleFromStartDate(tasks[0].StartDate);
                }
            }
        }
        void cePrintLegend_CheckedChanged(object sender, EventArgs e) {
            ganttControl1.OptionsPrint.PrintLegend = cePrintLegend.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }

        void cePrintPageInfo_CheckedChanged(object sender, EventArgs e) {
            ganttControl1.OptionsPrint.PrintPageInfo = cePrintPageInfo.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }

        void icePageInfoType_SelectedIndexChanged(object sender, EventArgs e) {
            ganttControl1.OptionsPrint.PageInfoType = (PageInfo) icePageInfoType.EditValue;
        }

        void deChartStartDate_EditValueChanged(object sender, EventArgs e) {
            ganttControl1.OptionsPrint.ChartStartDate = deChartStartDate.DateTime;
        }

        void deChartFinishDate_EditValueChanged(object sender, EventArgs e) {
            ganttControl1.OptionsPrint.ChartFinishDate = deChartFinishDate.DateTime;
        }

        void cePrintAllNodes_CheckedChanged(object sender, EventArgs e) {
            ganttControl1.OptionsPrint.PrintAllNodes = cePrintAllNodes.Checked;
        }

        void tePageCaption_EditValueChanged(object sender, EventArgs e) {
            ganttControl1.OptionsPrint.PageInfoCaption = tePageCaption.Text;
        }
    }
}
