using System;
using System.Drawing;
using System.IO;
using System.Linq;
using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.LookAndFeel;
using DevExpress.Mvvm;
using DevExpress.Utils;
using DevExpress.Utils.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;
using DevExpress.XtraGrid.Views.WinExplorer;
using DevExpress.XtraGrid.Views.WinExplorer.ViewInfo;

namespace DevExpress.DentalClinic.View {
    public partial class PersonalInformationView : XtraUserControl {
        public PersonalInformationView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode) {
                InitializeBindings();
                InitializeEditors();
                Messenger.Default.Register<ReloadDataMessage>(this, OnReloadData);
                InitStepProgressBar();
            }
            UpdateBackColors();
            winExplorerView1.GetThumbnailImage += TileView1_GetThumbnailImage;
            winExplorerView1.OptionsImageLoad.RandomShow = true;
            winExplorerView1.OptionsImageLoad.LoadThumbnailImagesFromDataSource = false;
            winExplorerView1.OptionsImageLoad.AsyncLoad = true;
        }
        void TileView1_GetThumbnailImage(object sender, ThumbnailImageEventArgs e) {
            var fileName = (string)winExplorerView1.GetRowCellValue(e.DataSourceIndex, colName);
            var ext = Path.GetExtension(fileName);
            e.ThumbnailImage = FileSystemHelper.GetFileExtensionImage(ext, IconSizeType.Large, new Size(64, 64));
        }
        void OnWinExplorerViewFocusedRowChanged(object sender, XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            winExplorerView1.RefreshContextButtons();
        }
        void OnWinExplorerViewContextButtonCustomize(object sender, WinExplorerViewContextButtonCustomizeEventArgs e) {
            if(winExplorerView1.FocusedRowHandle == e.RowHandle) {
                e.Item.AppearanceNormal.ForeColor = Color.White;
                e.Item.AppearanceHover.ForeColor = Color.White;
            }
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateBackColors();
        }
        void OnReloadData(ReloadDataMessage message) {
            InitStepProgressBar(true);
        }
        void UpdateBackColors() {
            var skinBackColor = LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.Window);
            stepProgressBar1.Appearance.BackColor = skinBackColor;
            panelControl2.BackColor = skinBackColor;
        }
        void InitializeBindings() {
            var fluentAPI = mvvmContext.OfType<PersonalInformationViewModel>();
            fluentAPI.BindCommand(sbSave, x => x.Save);
            fluentAPI.SetBinding(xpBindingSourcePatient, x => x.DataSource, x => x.Patient);
            fluentAPI.SetBinding(memoEditComplaints, x => x.EditValue, x => x.Patient.Complaints);
            fluentAPI.SetBinding(memoEditNotes, x => x.EditValue, x => x.Patient.Notes);
            fluentAPI.SetBinding(memoEditAllergies, x => x.EditValue, x => x.Patient.Allergies);
            fluentAPI.SetBinding(xpBindingSourceDocuments, x => x.DataSource, x => x.Patient.DocumentCollection);
            fluentAPI.BindCommand(sbPrintPlan, x => x.PrintPlan);

            var btnLoadFile = searchControl1.Properties.Buttons.FirstOrDefault(b => Equals(b.Tag, "loadFile"));
            fluentAPI.BindCommand(btnLoadFile, x => x.LoadDocument);
            fluentAPI.WithEvent<ContextItemClickEventArgs>(winExplorerView1, nameof(winExplorerView1.ContextButtonClick))
                .EventToCommand(x => x.RemoveDocument, args => GetRow<Document>(args));
            fluentAPI.WithEvent<WinExplorerViewItemDoubleClickEventArgs>(winExplorerView1, nameof(winExplorerView1.ItemDoubleClick))
                .EventToCommand(x => x.OpenDocument, args => GetRow<Document>(args.ItemInfo));
            fluentAPI.WithEvent<StepProgressBarItemHyperlinkClickEventArgs>(stepProgressBar1, nameof(stepProgressBar1.ItemHyperlinkClick))
                .EventToCommand(x => x.EditAppointment, ea => (int)ea.Item.Tag);
        }
        void InitializeEditors() {
            var viewModel = mvvmContext.GetViewModel<PersonalInformationViewModel>();
            if(viewModel == null || !viewModel.IsNew) return;
            this.lciFirstNameTextEdit.Text = "First Name <color=@Danger>*</color>";
            this.lciLastNameTextEdit.Text = "Last Name <color=@Danger>*</color>";
            this.lciPhoneTextEdit.Text = "Phone <color=@Danger>*</color>";
            this.lciEmailTextEdit.Text = "Email <color=@Danger>*</color>";
        }
        void InitStepProgressBar(bool reloadData = false) {
            stepProgressBar1.Items.Clear();
            var viewModel = mvvmContext.GetViewModel<PersonalInformationViewModel>();
            if(viewModel == null) return;
            if(reloadData)
                viewModel.Patient.AppointmentCollection.Reload();
            var groups = viewModel.Patient.AppointmentCollection.Where(x => x.Status == AppointmentStatus.Completed || x.Status == AppointmentStatus.Open).OrderBy(x => x.Date).GroupBy(x => x.Date.ToString("MMMM dd yyyy"));
            foreach(var group in groups) {
                StepProgressBarItem spItem = null;
                foreach(var appointment in group) {
                    DateTime startTime = appointment.Date;
                    DateTime endTime = appointment.Date;
                    foreach(var pc in appointment.ProcedureCollection) {
                        spItem = new StepProgressBarItem();
                        startTime = endTime;
                        endTime = endTime.Add(pc.Procedure.Duration);
                        spItem.ContentBlock2.Caption = string.Format("<a href=www.devexpress.com>{0}</a> ", pc.Procedure.Name);
                        spItem.ContentBlock2.Description = string.Format("{0} - {1}", startTime.ToString("t"), endTime.ToString("t"));
                        spItem.State = appointment.Status == AppointmentStatus.Completed ? StepProgressBarItemState.Active : StepProgressBarItemState.Inactive;
                        spItem.Tag = appointment.Oid;
                        stepProgressBar1.Items.Add(spItem);
                    }
                }
                spItem.ContentBlock1.Caption = group.Key;
            }
        }
        T GetRow<T>(ContextItemClickEventArgs args) {
            return (T)winExplorerView1.GetRow((int)args.DataItem);
        }
        T GetRow<T>(WinExplorerItemViewInfo winExplorerItemViewInfo) {
            return (T)winExplorerView1.GetRow(winExplorerItemViewInfo.Row.RowHandle);
        }
    }
}
