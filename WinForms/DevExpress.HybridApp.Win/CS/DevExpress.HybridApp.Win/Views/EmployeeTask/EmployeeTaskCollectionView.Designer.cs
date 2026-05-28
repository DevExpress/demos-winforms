namespace DevExpress.DevAV.Views
{
    partial class EmployeeTaskCollectionView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTaskCollectionView));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.employeeTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AssignTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OwnedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Subject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Priority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.priorityImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.DueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Completion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.employeeTaskFilterView = new DevExpress.DevAV.Views.EmployeeTaskFilterView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTaskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.splitContainerControl.Panel1.Controls.Add(this.employeeTaskFilterView);
            this.splitContainerControl.Panel2.Controls.Add(this.gridControl);
            this.splitContainerControl.Panel2.Padding = new System.Windows.Forms.Padding(0, 4, 40, 0);
            
            
            
            
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterWindowedDocumentManagerService(null, false, this, DevExpress.Utils.MVVM.Services.DefaultWindowedDocumentManagerServiceType.FlyoutForm, null)});
            this.mvvmContext.ViewModelType = typeof(DevExpress.DevAV.ViewModels.EmployeeTaskCollectionViewModel);
            
            
            
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.Size = new System.Drawing.Size(1047, 41);
            this.labelControl.Text = "<color=47, 81, 165>TASKS</color>";
            
            
            
            this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("New", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Edit", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)});
            this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 688);
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(1047, 89);
            
            
            
            this.gridControl.DataSource = this.employeeTaskBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl.Location = new System.Drawing.Point(0, 4);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemProgressBar1});
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(729, 643);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            
            
            
            this.employeeTaskBindingSource.DataSource = typeof(DevExpress.DevAV.EmployeeTask);
            
            
            
            this.gridView.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AssignTo,
            this.OwnedBy,
            this.Subject,
            this.Priority,
            this.DueDate,
            this.Completion});
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView.FooterPanelHeight = 60;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowSortAnimation = Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView.OptionsFind.AllowFindPanel = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.RowHeight = 10;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.DueDate, DevExpress.Data.ColumnSortOrder.Descending)});
            
            
            
            this.AssignTo.Caption = "Assign To";
            this.AssignTo.FieldName = "AssignedEmployee.FullName";
            this.AssignTo.Name = "AssignTo";
            this.AssignTo.Visible = true;
            this.AssignTo.VisibleIndex = 0;
            this.AssignTo.Width = 122;
            
            
            
            this.OwnedBy.Caption = "Owned By";
            this.OwnedBy.FieldName = "Owner.FullName";
            this.OwnedBy.Name = "OwnedBy";
            this.OwnedBy.Visible = true;
            this.OwnedBy.VisibleIndex = 1;
            this.OwnedBy.Width = 137;
            
            
            
            this.Subject.FieldName = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.Visible = true;
            this.Subject.VisibleIndex = 2;
            this.Subject.Width = 165;
            
            
            
            this.Priority.ColumnEdit = this.repositoryItemImageComboBox1;
            this.Priority.FieldName = "Priority";
            this.Priority.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.Priority.Name = "Priority";
            this.Priority.OptionsFilter.AllowAutoFilter = false;
            this.Priority.OptionsFilter.AllowFilter = false;
            this.Priority.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.Priority.Visible = true;
            this.Priority.VisibleIndex = 3;
            this.Priority.Width = 54;
            
            
            
            this.repositoryItemImageComboBox1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemImageComboBox1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", DevExpress.DevAV.EmployeeTaskPriority.Low, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", DevExpress.DevAV.EmployeeTaskPriority.Normal, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", DevExpress.DevAV.EmployeeTaskPriority.High, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", DevExpress.DevAV.EmployeeTaskPriority.Urgent, 3)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.PopupSizeable = true;
            this.repositoryItemImageComboBox1.SmallImages = this.priorityImageCollection;
            
            
            
            this.priorityImageCollection.ImageSize = new System.Drawing.Size(24, 24);
            this.priorityImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("priorityImageCollection.ImageStream")));
            this.priorityImageCollection.Images.SetKeyName(0, "LowPriority.png");
            this.priorityImageCollection.Images.SetKeyName(1, "NormalPriority.png");
            this.priorityImageCollection.Images.SetKeyName(2, "MediumPriority.png");
            this.priorityImageCollection.Images.SetKeyName(3, "HighPriority.png");
            
            
            
            this.DueDate.FieldName = "DueDate";
            this.DueDate.Name = "DueDate";
            this.DueDate.Visible = true;
            this.DueDate.VisibleIndex = 4;
            this.DueDate.Width = 88;
            
            
            
            this.Completion.Caption = "% Complete";
            this.Completion.ColumnEdit = this.repositoryItemProgressBar1;
            this.Completion.FieldName = "Completion";
            this.Completion.Name = "Completion";
            this.Completion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Completion", "<color=gray>TOTAL # OF TASKS</color><br><b>{0}</b>")});
            this.Completion.Visible = true;
            this.Completion.VisibleIndex = 5;
            this.Completion.Width = 161;
            
            
            
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ProgressPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.repositoryItemProgressBar1.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.repositoryItemProgressBar1.ShowTitle = true;
            
            
            
            this.employeeTaskFilterView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeTaskFilterView.Location = new System.Drawing.Point(40, 2);
            this.employeeTaskFilterView.Name = "employeeTaskFilterView";
            this.employeeTaskFilterView.Size = new System.Drawing.Size(206, 643);
            this.employeeTaskFilterView.TabIndex = 0;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "EmployeeTaskCollectionView";
            this.Size = new System.Drawing.Size(1047, 777);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTaskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraGrid.GridControl gridControl;
        private XtraGrid.Views.Grid.GridView gridView;
        private XtraGrid.Columns.GridColumn AssignTo;
        private XtraGrid.Columns.GridColumn OwnedBy;
        private XtraGrid.Columns.GridColumn Subject;
        private XtraGrid.Columns.GridColumn Priority;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private XtraGrid.Columns.GridColumn DueDate;
        private XtraGrid.Columns.GridColumn Completion;
        private XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private Utils.ImageCollection priorityImageCollection;
        private EmployeeTaskFilterView employeeTaskFilterView;
        private System.Windows.Forms.BindingSource employeeTaskBindingSource;

    }
}
