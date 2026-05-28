namespace DevExpress.DentalClinic.View {
    partial class ProcedureHistoryView {
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.fieldDateYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDateMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDateDay = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDateQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.invoiceInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDuration1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPatientName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldEndDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDoctor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProcedure1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTotal1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldStatus1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldDateYear
            // 
            this.fieldDateYear.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDateYear.AreaIndex = 0;
            this.fieldDateYear.Caption = "Year";
            this.fieldDateYear.FieldName = "Date";
            this.fieldDateYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldDateYear.MinWidth = 100;
            this.fieldDateYear.Name = "fieldDateYear";
            this.fieldDateYear.UnboundFieldName = "pivotGridField1";
            // 
            // fieldDateMonth
            // 
            this.fieldDateMonth.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDateMonth.AreaIndex = 1;
            this.fieldDateMonth.Caption = "Month";
            this.fieldDateMonth.FieldName = "Date";
            this.fieldDateMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldDateMonth.MinWidth = 100;
            this.fieldDateMonth.Name = "fieldDateMonth";
            this.fieldDateMonth.UnboundFieldName = "fieldDateMonth";
            // 
            // fieldDateDay
            // 
            this.fieldDateDay.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDateDay.AreaIndex = 2;
            this.fieldDateDay.Caption = "Day";
            this.fieldDateDay.FieldName = "Date";
            this.fieldDateDay.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay;
            this.fieldDateDay.MinWidth = 80;
            this.fieldDateDay.Name = "fieldDateDay";
            this.fieldDateDay.UnboundFieldName = "fieldDateDay";
            // 
            // fieldDateQuarter
            // 
            this.fieldDateQuarter.AreaIndex = 6;
            this.fieldDateQuarter.Caption = "Quarter";
            this.fieldDateQuarter.FieldName = "Date";
            this.fieldDateQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldDateQuarter.Name = "fieldDateQuarter";
            this.fieldDateQuarter.UnboundFieldName = "pivotGridField1";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl1.DataSource = this.invoiceInfoBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldDate1,
            this.fieldDuration1,
            this.fieldPatientName1,
            this.fieldEndDate1,
            this.fieldDoctor1,
            this.fieldProcedure1,
            this.fieldTotal1,
            this.fieldDiscount1,
            this.fieldStatus1,
            this.fieldDateYear,
            this.fieldDateQuarter,
            this.fieldDateMonth,
            this.fieldDateDay});
            pivotGridGroup1.Fields.Add(this.fieldDateYear);
            pivotGridGroup1.Fields.Add(this.fieldDateMonth);
            pivotGridGroup1.Fields.Add(this.fieldDateDay);
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsBehavior.UseAsyncMode = true;
            this.pivotGridControl1.OptionsView.AllowHtmlDrawFieldValues = true;
            this.pivotGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.pivotGridControl1.Size = new System.Drawing.Size(1050, 850);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // invoiceInfoBindingSource
            // 
            this.invoiceInfoBindingSource.DataSource = typeof(DevExpress.DentalClinic.ViewModel.ExtendedInvoiceInfo);
            // 
            // fieldDate1
            // 
            this.fieldDate1.AreaIndex = 0;
            this.fieldDate1.Caption = "Date";
            this.fieldDate1.FieldName = "Date";
            this.fieldDate1.Name = "fieldDate1";
            // 
            // fieldDuration1
            // 
            this.fieldDuration1.AreaIndex = 1;
            this.fieldDuration1.Caption = "Duration";
            this.fieldDuration1.FieldName = "Duration";
            this.fieldDuration1.Name = "fieldDuration1";
            // 
            // fieldPatientName1
            // 
            this.fieldPatientName1.AreaIndex = 5;
            this.fieldPatientName1.Caption = "Patient Name";
            this.fieldPatientName1.FieldName = "PatientName";
            this.fieldPatientName1.Name = "fieldPatientName1";
            // 
            // fieldEndDate1
            // 
            this.fieldEndDate1.AreaIndex = 2;
            this.fieldEndDate1.Caption = "EndDate";
            this.fieldEndDate1.FieldName = "EndDate";
            this.fieldEndDate1.Name = "fieldEndDate1";
            // 
            // fieldDoctor1
            // 
            this.fieldDoctor1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldDoctor1.AreaIndex = 0;
            this.fieldDoctor1.Caption = "Doctor";
            this.fieldDoctor1.FieldName = "Doctor";
            this.fieldDoctor1.Name = "fieldDoctor1";
            // 
            // fieldProcedure1
            // 
            this.fieldProcedure1.AreaIndex = 3;
            this.fieldProcedure1.Caption = "Procedure";
            this.fieldProcedure1.FieldName = "Procedure";
            this.fieldProcedure1.Name = "fieldProcedure1";
            // 
            // fieldTotal1
            // 
            this.fieldTotal1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldTotal1.AreaIndex = 1;
            this.fieldTotal1.Caption = "Total";
            this.fieldTotal1.FieldName = "Total";
            this.fieldTotal1.Name = "fieldTotal1";
            // 
            // fieldDiscount1
            // 
            this.fieldDiscount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDiscount1.AreaIndex = 0;
            this.fieldDiscount1.Caption = "Discount";
            this.fieldDiscount1.FieldName = "Discount";
            this.fieldDiscount1.Name = "fieldDiscount1";
            // 
            // fieldStatus1
            // 
            this.fieldStatus1.AreaIndex = 4;
            this.fieldStatus1.Caption = "Status";
            this.fieldStatus1.FieldEdit = this.repositoryItemImageComboBox1;
            this.fieldStatus1.FieldName = "Status";
            this.fieldStatus1.Name = "fieldStatus1";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(DevExpress.DentalClinic.ViewModel.ProcedureHistoryViewModel);
            // 
            // ProcedureHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pivotGridControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProcedureHistoryView";
            this.Size = new System.Drawing.Size(1050, 850);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Utils.MVVM.MVVMContext mvvmContext1;
        private System.Windows.Forms.BindingSource invoiceInfoBindingSource;
        private Utils.Behaviors.BehaviorManager behaviorManager1;
        private XtraPivotGrid.PivotGridControl pivotGridControl1;
        private XtraPivotGrid.PivotGridField fieldDuration1;
        private XtraPivotGrid.PivotGridField fieldPatientName1;
        private XtraPivotGrid.PivotGridField fieldEndDate1;
        private XtraPivotGrid.PivotGridField fieldDate1;
        private XtraPivotGrid.PivotGridField fieldDoctor1;
        private XtraPivotGrid.PivotGridField fieldProcedure1;
        private XtraPivotGrid.PivotGridField fieldTotal1;
        private XtraPivotGrid.PivotGridField fieldDiscount1;
        private XtraPivotGrid.PivotGridField fieldStatus1;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private XtraPivotGrid.PivotGridField fieldDateYear;
        private XtraPivotGrid.PivotGridField fieldDateQuarter;
        private XtraPivotGrid.PivotGridField fieldDateMonth;
        private XtraPivotGrid.PivotGridField fieldDateDay;
    }
}
