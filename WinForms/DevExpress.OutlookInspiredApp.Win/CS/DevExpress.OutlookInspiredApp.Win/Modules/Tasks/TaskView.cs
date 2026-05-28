namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Utils.Svg;
    using DevExpress.XtraBars.Docking2010;
    using DevExpress.XtraGrid.Views.Tile;
    using DevExpress.XtraLayout.Utils;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class TaskView : BaseModuleControl {
        SvgImage svgYes;
        SvgImage svgNo;
        IDictionary<EmployeeTaskPriority, SvgImage> priorityImages;
        public TaskView()
            : base(typeof(SynchronizedTaskViewModel)) {
            InitializeComponent();
            gvTasks.SetViewFontSize(2, 1);
            gvEvaluations.SetViewFontSize(2, 1);
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            officeTabFilter.SelectedItemChanged += OfficeTabFilter_SelectedItemChanged;
            tvEvaluations.ItemCustomize += tvEvaluations_ItemCustomize;
            tvTasks.ItemCustomize += tvTasks_ItemCustomize;
            gcTasks.SizeChanged += (s, e) => {
                if (gcTasks.MainView == tvTasks)
                    tvTasks.RefreshData();
            };

            var asm = typeof(MainForm).Assembly;
            svgYes = SvgImage.FromResources("DevExpress.DevAV.Resources.EvaluationYes.svg", asm);
            svgNo = SvgImage.FromResources("DevExpress.DevAV.Resources.EvaluationNo.svg", asm);
            priorityImages = SVGHelper.CreateTaskPriorityImages(LookAndFeel, "DevExpress.DevAV.Resources.Tasks.");
        }

        void OfficeTabFilter_SelectedItemChanged(object sender, XtraBars.Navigation.NavigationBarItemEventArgs e) {
            bool showTasks = e.Item == navigationItemTasks;
            lciTasks.Visibility = showTasks ? LayoutVisibility.Always : LayoutVisibility.Never;
            lciEvaluations.Visibility = !showTasks ? LayoutVisibility.Always : LayoutVisibility.Never;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
        }
        protected override void OnDisposing() {
            tvTasks.ItemCustomize -= tvTasks_ItemCustomize;
            tvEvaluations.ItemCustomize -= tvEvaluations_ItemCustomize;
            base.OnDisposing();
        }
        public TaskViewModel ViewModel {
            get { return GetViewModel<TaskViewModel>(); }
        }
        void ViewModel_EntityChanged(object sender, System.EventArgs e) {
            QueueUIUpdate();
        }
        protected override void OnDelayedUIUpdate() {
            UpdateUI(ViewModel.Entity);
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            UpdateUI(ViewModel.Entity);
        }
        SizeF scaleFactor;
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);
            this.scaleFactor = factor;
        }
        WindowsUIButton ContactButton(int index) {
            return (WindowsUIButton)buttonPanel.Buttons[index];
        }
        void UpdateUI(EmployeeTask employee) {
            if (employee != null) {
                if (!object.Equals(bindingSource.DataSource, employee))
                    bindingSource.DataSource = employee.AssignedEmployee;
                else {
                    bindingSource.ResetBindings(false);
                }
                tvTasks.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
                tvEvaluations.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
                gcTasks.DataSource = employee.AssignedEmployee.AssignedTasks;
                gcEvaluations.DataSource = employee.AssignedEmployee.Evaluations;
            }
            else {
                gcTasks.DataSource = null;
                gcEvaluations.DataSource = null;
            }
            modueLayout.Visible = (employee != null);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsHorizontalLayout {
            get { return !colDescription.Visible; }
            set {
                gvEvaluations.OptionsView.ShowPreview = value;
                gvTasks.OptionsView.ShowPreview = value;
                colDescription.Visible = !value;
            }
        }
        void tvEvaluations_ItemCustomize(object sender, XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e) {
            string details = tvEvaluations.GetRowCellValue(e.RowHandle, "Details") as string;
            var raiseImg = e.Item.GetElementByName("RaiseImage");
            var bonusImg = e.Item.GetElementByName("BonusImage");
            bool hasRaise = false;
            bool hasBonus = false;
            if (!string.IsNullOrEmpty(details)) {
                details = details.ToLower().Replace(" ", string.Empty);
                hasRaise = details.Contains("raise:yes");
                hasBonus = details.Contains("bonus:yes");
            }
            raiseImg.ImageOptions.SvgImage = hasRaise ? svgYes : svgNo;
            bonusImg.ImageOptions.SvgImage = hasBonus ? svgYes : svgNo;
        }
        void tvTasks_ItemCustomize(object sender, XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e) {
            var view = sender as TileView;
            var progressBack = e.Item.GetElementByName("ProgressBack");
            var progressFront = e.Item.GetElementByName("ProgressFront");
            var priorityElement = e.Item.GetElementByName("PriorityImage");
            var rowPriority = (EmployeeTaskPriority)view.GetRowCellValue(e.RowHandle, view.Columns["Priority"]);
            int completion = (int)view.GetRowCellValue(e.RowHandle, view.Columns["Completion"]);

            priorityElement.ImageOptions.SvgImage = priorityImages[rowPriority];
            progressBack.Width = (int)(view.GetViewInfo().GetItemSize().Width / (float)scaleFactor.Width) - view.OptionsTiles.ItemPadding.Horizontal;
            progressFront.Width = (int)(progressBack.Width * (completion / 100.0f));
        }
    }
}
