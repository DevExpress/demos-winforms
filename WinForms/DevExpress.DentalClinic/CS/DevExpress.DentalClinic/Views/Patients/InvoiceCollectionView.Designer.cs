using System.Drawing;
using DevExpress.LookAndFeel;

namespace DevExpress.DentalClinic.View {
    partial class InvoiceCollectionView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.gcInvoices = new DevExpress.DentalClinic.View.GroupedGridControl();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvInvoices = new DevExpress.DentalClinic.View.GroupedGridView();
            this.colInvoiceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcedure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colBill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 35;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
            this.colStatus.Width = 123;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.DentalClinic.ViewModel.InvoiceCollectionViewModel);
            // 
            // gcInvoices
            // 
            this.gcInvoices.DataSource = this.invoicesBindingSource;
            this.gcInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInvoices.Location = new System.Drawing.Point(0, 0);
            this.gcInvoices.MainView = this.gvInvoices;
            this.gcInvoices.Name = "gcInvoices";
            this.gcInvoices.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHypertextLabel1,
            this.repositoryItemImageComboBox1,
            this.repositoryItemTextEdit1});
            this.gcInvoices.Size = new System.Drawing.Size(1082, 635);
            this.gcInvoices.TabIndex = 0;
            this.gcInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoices});
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataSource = typeof(DevExpress.DentalClinic.ViewModel.InvoiceInfo);
            // 
            // gvInvoices
            // 
            this.gvInvoices.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.gvInvoices.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvInvoices.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvInvoices.ColumnPanelRowHeight = 30;
            this.gvInvoices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceId,
            this.colDate,
            this.colDoctor,
            this.colProcedure,
            this.colTotal,
            this.colDiscount,
            this.colBill,
            this.colStatus});
            this.gvInvoices.DetailHeight = 434;
            this.gvInvoices.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvInvoices.GridControl = this.gcInvoices;
            this.gvInvoices.GroupCount = 1;
            this.gvInvoices.Name = "gvInvoices";
            this.gvInvoices.OptionsBehavior.Editable = false;
            this.gvInvoices.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvInvoices.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvInvoices.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvInvoices.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gvInvoices.OptionsSelection.UseIndicatorForSelection = false;
            this.gvInvoices.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gvInvoices.OptionsView.ShowGroupPanel = false;
            this.gvInvoices.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvInvoices.OptionsView.ShowIndicator = false;
            this.gvInvoices.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvInvoices.RowHeight = 36;
            this.gvInvoices.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colInvoiceId, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colInvoiceId
            // 
            this.colInvoiceId.Caption = "№";
            this.colInvoiceId.FieldName = "InvoiceId";
            this.colInvoiceId.MinWidth = 35;
            this.colInvoiceId.Name = "colInvoiceId";
            this.colInvoiceId.Visible = true;
            this.colInvoiceId.VisibleIndex = 0;
            this.colInvoiceId.Width = 131;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 35;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 100;
            // 
            // colDoctor
            // 
            this.colDoctor.Caption = "Doctor";
            this.colDoctor.FieldName = "Doctor";
            this.colDoctor.MinWidth = 35;
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.Visible = true;
            this.colDoctor.VisibleIndex = 1;
            this.colDoctor.Width = 128;
            // 
            // colProcedure
            // 
            this.colProcedure.Caption = "Procedure";
            this.colProcedure.FieldName = "Procedure";
            this.colProcedure.MinWidth = 35;
            this.colProcedure.Name = "colProcedure";
            this.colProcedure.Visible = true;
            this.colProcedure.VisibleIndex = 2;
            this.colProcedure.Width = 390;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "c";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.MinWidth = 35;
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            this.colTotal.Width = 108;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "Discount";
            this.colDiscount.ColumnEdit = this.repositoryItemTextEdit1;
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.MinWidth = 35;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 4;
            this.colDiscount.Width = 108;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "P";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colBill
            // 
            this.colBill.Caption = "Bill";
            this.colBill.DisplayFormat.FormatString = "c";
            this.colBill.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBill.FieldName = "Bill";
            this.colBill.MinWidth = 35;
            this.colBill.Name = "colBill";
            this.colBill.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colBill.Visible = true;
            this.colBill.VisibleIndex = 5;
            this.colBill.Width = 108;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gcInvoices;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gcInvoices);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1082, 635);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // InvoiceCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.gridSplitContainer1);
            this.Name = "InvoiceCollectionView";
            this.Size = new System.Drawing.Size(1082, 635);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.MVVM.MVVMContext mvvmContext;
        private GroupedGridControl gcInvoices;
        private GroupedGridView gvInvoices;
        private XtraGrid.GridSplitContainer gridSplitContainer1;
        private XtraGrid.Columns.GridColumn colInvoiceId;
        private XtraGrid.Columns.GridColumn colDate;
        private XtraGrid.Columns.GridColumn colDoctor;
        private XtraGrid.Columns.GridColumn colProcedure;
        private XtraGrid.Columns.GridColumn colTotal;
        private XtraGrid.Columns.GridColumn colDiscount;
        private XtraGrid.Columns.GridColumn colBill;
        private XtraGrid.Columns.GridColumn colStatus;
        private XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
