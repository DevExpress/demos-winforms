using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;

namespace DevExpress.XtraScheduler.Demos {
    public partial class ResourceHeadersModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public ResourceHeadersModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
        protected override int TakeScreenDelay => 300;
        protected SchedulerResourceHeaderOptions ResourceHeaderOptions { get { return schedulerControl.OptionsView.ResourceHeaders; } }

        private void GroupByResourceModule_Load(object sender, System.EventArgs e) {
            InitControlValues();
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
            UpdateResources();
            UpdateControls();
        }
        void InitControlValues() {
            cbHeaderHeight.EditValue = ResourceHeaderOptions.Height;
            cbImageSize.EditValue = ResourceHeaderOptions.ImageSize;
            cbImageAlign.EditValue = ResourceHeaderOptions.ImageAlign;
            cbImageSizeMode.EditValue = ResourceHeaderOptions.ImageSizeMode;
            chkRotateCaption.Checked = ResourceHeaderOptions.RotateCaption;
            chkWordWrap.Checked = schedulerControl.Appearance.HeaderCaption.TextOptions.WordWrap == WordWrap.Wrap;
        }
        void UpdateResources() {
            foreach (Resource res in schedulerStorage.Resources.Items) {
                string imageName = String.Format("CarsData.Images.{0}.jpg", res.Id);
                Image image = ResourceImageHelper.CreateImageFromResources(DemoUtils.FindResourceName(imageName), System.Reflection.Assembly.GetExecutingAssembly());
                res.SetImage(image);
            }
        }
        private void chkWordWrap_CheckedChanged(object sender, System.EventArgs e) {
            WordWrap wrap = chkWordWrap.Checked ? WordWrap.Wrap : WordWrap.Default;
            schedulerControl.Appearance.HeaderCaption.TextOptions.WordWrap = wrap;
        }
        private void cbImageSize_SelectedIndexChanged(object sender, System.EventArgs e) {
            ResourceHeaderOptions.ImageSize = (Size)cbImageSize.EditValue;
        }

        private void cbHeaderHeight_EditValueChanged(object sender, System.EventArgs e) {
            string stringValue = cbHeaderHeight.EditValue as string;
            if (stringValue != null)
                return;
            ResourceHeaderOptions.Height = Convert.ToInt32(cbHeaderHeight.EditValue);
        }

        private void schedulerControl_ActiveViewChanged(object sender, System.EventArgs e) {
            UpdateControls();
        }
        private void chkRotateCaption_CheckedChanged(object sender, System.EventArgs e) {
            ResourceHeaderOptions.RotateCaption = chkRotateCaption.Checked;
        }
        private void cbImageAlign_SelectedIndexChanged(object sender, System.EventArgs e) {
            ResourceHeaderOptions.ImageAlign = (HeaderImageAlign)cbImageAlign.EditValue;
        }
        void UpdateControls() {
            SchedulerViewBase view = schedulerControl.ActiveView;
            SchedulerGroupType groupType = schedulerControl.GroupType;
            chkRotateCaption.Enabled = (view is WeekView && groupType.Equals(SchedulerGroupType.Date)) ||
                (view is TimelineView && !groupType.Equals(SchedulerGroupType.None));
        }
        private void cbImageSizeMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            ResourceHeaderOptions.ImageSizeMode = (HeaderImageSizeMode)cbImageSizeMode.EditValue;
        }
        private void schedulerControl_DoubleClick(object sender, System.EventArgs e) {
            Point pt = schedulerControl.PointToClient(Control.MousePosition);
            SchedulerHitInfo hitInfo = schedulerControl.ActiveView.ViewInfo.CalcHitInfo(pt, true);
            if (hitInfo.HitTest == SchedulerHitTest.ResourceHeader) {
                Image customImage = LoadCustomResourceImage();
                if (customImage != null) {
                    ResourceHeader header = (ResourceHeader)hitInfo.ViewInfo;
                    header.Resource.SetImage(customImage);
                    schedulerControl.ActiveView.LayoutChanged();
                }
            }
        }

        Image LoadCustomResourceImage() {
            Image image = null;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select image file";
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK) {
                image = LoadImageFromFile(dlg.FileName);
            }
            return image;
        }

        Image LoadImageFromFile(string fileName) {
            Image image = null;
            try {
                image = Image.FromFile(fileName);
            }
            catch (Exception e) {
                XtraMessageBox.Show("Can't load image from file - " + e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return image;
        }

        private void schedulerControl_GroupTypeChanged(object sender, EventArgs e) {
            UpdateControls();
        }
    }
}

