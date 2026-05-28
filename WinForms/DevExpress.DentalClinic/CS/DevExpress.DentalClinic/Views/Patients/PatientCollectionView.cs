using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DevExpress.DentalClinic.View {
    public partial class PatientCollectionView : XtraUserControl {
        public PatientCollectionView() {
            InitializeComponent();
            repositoryItemImageComboBox1.Items.AddEnum(typeof(InvoiceInfoStatus), true);
            if(!mvvmContext1.IsDesignMode) {
                InitializeNavigation();
                InitializeBindings();
            }
        }
        void InitializeNavigation() {
            var msgService = MessageBoxService.CreateXtraMessageBoxService();
            mvvmContext1.RegisterService(msgService);
        }
        void InitializeBindings() {
            var fluentAPI = mvvmContext1.OfType<PatientCollectionViewModel>();
            // DataSource
            fluentAPI.SetBinding(patientsBindingSource, pbs => pbs.DataSource, x => x.Patients);
            fluentAPI.SetBinding(patientsBindingSource, pbs => pbs.Current, x => x.SelectedEntity);
            // Interactions
            fluentAPI.WithEvent<RowClickEventArgs>(gvPatients, "RowClick")
                .EventToCommand(x => x.Edit,
                    args => (args.Clicks == 2) && (args.Button == MouseButtons.Left) && gvPatients.CalcHitInfo(args.Location).HitTest != XtraGrid.Views.Grid.ViewInfo.GridHitTest.CellButton);
            fluentAPI.WithEvent<OpenLinkEventArgs>(repositoryHyperlinkCall, nameof(RepositoryItemHyperLinkEdit.OpenLink))
               .EventToCommand(x => x.Call);
            //fluentAPI.WithEvent<OpenLinkEventArgs>(repositoryHyperLinkNavigateScheduller, nameof(RepositoryItemHyperLinkEdit.OpenLink))
            //   .EventToCommand(x => x.CreateOrEditAppointment, (OpenLinkEventArgs args)=> args.EditValue);
            //Buttons
            fluentAPI.BindCommand(sbAddPatient, x => x.New);
            fluentAPI.BindCommand(sbEditPatient, x => x.Edit);
            fluentAPI.BindCommand(sbRemovePatient, x => x.Remove);
            // Initial Loading
            fluentAPI.WithEvent(this, nameof(Load))
                .EventToCommand(x => x.LoadPatientsAsync);
        }
        void OnGridViewCustomDrawCell(object sender, XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.Column != colStatus)
                return;
            var cellInfo = e.Cell as XtraGrid.Views.Grid.ViewInfo.GridCellInfo;
            var buttonEditViewInfo = cellInfo.ViewInfo as ButtonEditViewInfo;
            buttonEditViewInfo.Clear();
            bool isHot = (cellInfo.State & XtraGrid.Views.Base.GridRowCellState.Hot) != 0;
            buttonEditViewInfo.DetailLevel = isHot ? DetailLevel.Full : DetailLevel.Minimum;
            e.DefaultDraw();
            e.Handled = true;
        }
        void OnRepositoryItemImageComboBoxMouseLeave(object sender, System.EventArgs e) {
            gvPatients.CloseEditor();
        }

        private void gvProcedures_CustomColumnDisplayText(object sender, XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e) {
            if(e.Value == null) {
                if(e.Column.FieldName == nameof(PatientProcedureInfo.VisitTime))
                    e.DisplayText = "Unscheduled";
                if(e.Column.FieldName == nameof(PatientProcedureInfo.DoctorName))
                    e.DisplayText = "Unassigned";
            }
        }
        private void gvPatients_CustomColumnDisplayText(object sender, XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e) {
            if((e.Value == null) && (e.Column.FieldName == nameof(PatientInfo.NextVisit)))
                e.DisplayText = "Unscheduled";
        }

        private void gvProcedures_CellMerge(object sender, CellMergeEventArgs e) {
            if(e.Column.FieldName == nameof(PatientProcedureInfo.DoctorName)) {
                PatientProcedureInfo row1 = (sender as GridView).GetRow(e.RowHandle1) as PatientProcedureInfo;
                PatientProcedureInfo row2 = (sender as GridView).GetRow(e.RowHandle2) as PatientProcedureInfo;
                e.Merge = row1.VisitTime == row2.VisitTime && row1.DoctorName == row2.DoctorName;
                e.Handled = true;
            }
        }

        private void gvProcedures_CustomColumnSort(object sender, XtraGrid.Views.Base.CustomColumnSortEventArgs e) {
            if((e.Column.FieldName == nameof(PatientProcedureInfo.VisitTime))) {
                if(e.Value1 == null && e.Value2 == null) {
                    e.Result = 0;
                    e.Handled = true;
                    return;
                }
                if(e.Value1 == null) {
                    e.Result = e.SortOrder == Data.ColumnSortOrder.Ascending ? -1 : 1;
                    e.Handled = true;
                    return;
                }
                if(e.Value2 == null) {
                    e.Result = e.SortOrder == Data.ColumnSortOrder.Ascending ? 1 : -1;
                    e.Handled = true;
                    return;
                }
            }
        }

        private void gvPatients_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.MenuType == XtraGrid.Views.Grid.GridMenuType.Row && e.HitInfo.InRowCell && (sender as GridView).IsDataRow(e.HitInfo.RowHandle)) {
                var fluentAPI = mvvmContext1.OfType<PatientCollectionViewModel>();
                var newItem = new Utils.Menu.DXMenuItem();
                newItem.Caption = sbAddPatient.Text;
                newItem.ImageOptions.SvgImage = sbAddPatient.ImageOptions.SvgImage;
                fluentAPI.BindCommand(newItem, x => x.New);

                var editItem = new Utils.Menu.DXMenuItem();
                editItem.Caption = sbEditPatient.Text;
                editItem.ImageOptions.SvgImage = sbEditPatient.ImageOptions.SvgImage;
                fluentAPI.BindCommand(editItem, x => x.Edit);

                var deleteItem = new Utils.Menu.DXMenuItem();
                deleteItem.Caption = sbRemovePatient.Text;
                deleteItem.ImageOptions.SvgImage = sbRemovePatient.ImageOptions.SvgImage;
                fluentAPI.BindCommand(deleteItem, x => x.Remove);

                e.Menu.Items.Add(newItem);
                e.Menu.Items.Add(editItem);
                e.Menu.Items.Add(deleteItem);
            }
        }

        private void gvProcedures_MouseDown(object sender, MouseEventArgs e) {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if(hitInfo.InRowCell && hitInfo.Column.FieldName == nameof(PatientProcedureInfo.VisitTime)) {
                DateTime? content = view.GetRowCellValue(hitInfo.RowHandle, hitInfo.Column) as DateTime?;
                BeginInvoke(new MethodInvoker(() => {
                    var fluentAPI = mvvmContext1.OfType<PatientCollectionViewModel>();
                    fluentAPI.ViewModel.CreateOrEditAppointment(content);
                }));

            }
        }
    }
}
