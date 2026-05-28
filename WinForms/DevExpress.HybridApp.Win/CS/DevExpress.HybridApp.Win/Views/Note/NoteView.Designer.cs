namespace DevExpress.DevAV.Views
{
    partial class NoteView
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
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.noteBindingSource = new System.Windows.Forms.BindingSource();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.assignedToLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.memoEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            this.dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedToLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.dataLayoutControl.AllowCustomization = false;
            this.dataLayoutControl.Controls.Add(this.cancelSimpleButton);
            this.dataLayoutControl.Controls.Add(this.saveSimpleButton);
            this.dataLayoutControl.Controls.Add(this.memoEdit1);
            this.dataLayoutControl.Controls.Add(this.dateEdit1);
            this.dataLayoutControl.Controls.Add(this.assignedToLookUpEdit);
            this.dataLayoutControl.Controls.Add(this.memoEdit2);
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl.Location = new System.Drawing.Point(32, 0);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1003, 194, 650, 760);
            this.dataLayoutControl.OptionsView.UseParentAutoScaleFactor = true;
            this.dataLayoutControl.Root = this.layoutControlGroup1;
            this.dataLayoutControl.Size = new System.Drawing.Size(758, 426);
            this.dataLayoutControl.TabIndex = 1;
            this.dataLayoutControl.Text = "layoutControl1";
            
            
            
            this.cancelSimpleButton.AutoWidthInLayoutControl = true;
            this.cancelSimpleButton.Location = new System.Drawing.Point(636, 362);
            this.cancelSimpleButton.MinimumSize = new System.Drawing.Size(120, 0);
            this.cancelSimpleButton.Name = "cancelSimpleButton";
            this.cancelSimpleButton.Size = new System.Drawing.Size(120, 42);
            this.cancelSimpleButton.StyleController = this.dataLayoutControl;
            this.cancelSimpleButton.TabIndex = 22;
            this.cancelSimpleButton.Text = "Cancel";
            
            
            
            this.saveSimpleButton.AutoWidthInLayoutControl = true;
            this.saveSimpleButton.Location = new System.Drawing.Point(500, 362);
            this.saveSimpleButton.MinimumSize = new System.Drawing.Size(120, 0);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(120, 42);
            this.saveSimpleButton.StyleController = this.dataLayoutControl;
            this.saveSimpleButton.TabIndex = 21;
            this.saveSimpleButton.Text = "Save";
            
            
            
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.noteBindingSource, "Details", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.memoEdit1.Location = new System.Drawing.Point(108, 134);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.NullValuePrompt = "Enter Details";
            this.memoEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.memoEdit1.Size = new System.Drawing.Size(648, 200);
            this.memoEdit1.StyleController = this.dataLayoutControl;
            this.memoEdit1.TabIndex = 11;
            
            
            
            this.noteBindingSource.DataSource = typeof(DevExpress.DevAV.Evaluation);
            
            
            
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.noteBindingSource, "CreatedOn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(108, 42);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Size = new System.Drawing.Size(289, 42);
            this.dateEdit1.StyleController = this.dataLayoutControl;
            this.dateEdit1.TabIndex = 7;
            
            
            
            this.assignedToLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.noteBindingSource, "EmployeeId", true));
            this.assignedToLookUpEdit.Location = new System.Drawing.Point(577, 42);
            this.assignedToLookUpEdit.Name = "assignedToLookUpEdit";
            this.assignedToLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assignedToLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullNameBindable", "FullName")});
            this.assignedToLookUpEdit.Properties.DisplayMember = "FullNameBindable";
            this.assignedToLookUpEdit.Properties.NullText = "";
            this.assignedToLookUpEdit.Properties.NullValuePrompt = "None";
            this.assignedToLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.assignedToLookUpEdit.Properties.ShowHeader = false;
            this.assignedToLookUpEdit.Properties.ValueMember = "Id";
            this.assignedToLookUpEdit.Size = new System.Drawing.Size(179, 42);
            this.assignedToLookUpEdit.StyleController = this.dataLayoutControl;
            this.assignedToLookUpEdit.TabIndex = 5;
            
            
            
            this.memoEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.noteBindingSource, "Subject", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.memoEdit2.Location = new System.Drawing.Point(108, 88);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Properties.NullValuePrompt = "Enter Subject";
            this.memoEdit2.Properties.NullValuePromptShowForEmptyValue = true;
            this.memoEdit2.Size = new System.Drawing.Size(648, 42);
            this.memoEdit2.StyleController = this.dataLayoutControl;
            this.memoEdit2.TabIndex = 12;
            
            
            
            this.layoutControlGroup1.AppearanceItemCaption.FontSizeDelta = -1;
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.emptySpaceItem3,
            this.layoutControlItem10,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem7,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 25;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 40, 20);
            this.layoutControlGroup1.Size = new System.Drawing.Size(758, 426);
            this.layoutControlGroup1.TextVisible = false;
            
            
            
            this.layoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem9.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem9.Control = this.memoEdit1;
            this.layoutControlItem9.CustomizationFormText = "DESCRIPTION";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(758, 204);
            this.layoutControlItem9.Text = "DETAILS";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(81, 17);
            
            
            
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 320);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(498, 46);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            
            
            
            this.layoutControlItem10.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.layoutControlItem10.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem10.Control = this.memoEdit2;
            this.layoutControlItem10.CustomizationFormText = "SUBJECT";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(758, 46);
            this.layoutControlItem10.Text = "SUBJECT";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(81, 17);
            
            
            
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.assignedToLookUpEdit;
            this.layoutControlItem2.CustomizationFormText = "ASSIGNED TO";
            this.layoutControlItem2.Location = new System.Drawing.Point(469, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(289, 46);
            this.layoutControlItem2.Text = "ASSIGNED TO";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 17);
            
            
            
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.dateEdit1;
            this.layoutControlItem5.CustomizationFormText = "START DATE";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(399, 46);
            this.layoutControlItem5.Text = "START DATE";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(81, 17);
            
            
            
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 296);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 24);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(758, 24);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            
            
            
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.CustomizationFormText = "emptySpaceItem7";
            this.emptySpaceItem7.Location = new System.Drawing.Point(399, 0);
            this.emptySpaceItem7.MaxSize = new System.Drawing.Size(70, 0);
            this.emptySpaceItem7.MinSize = new System.Drawing.Size(70, 24);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(70, 46);
            this.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            
            
            
            this.layoutControlItem1.Control = this.saveSimpleButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(498, 320);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsPrint.AllowPrint = false;
            this.layoutControlItem1.Size = new System.Drawing.Size(124, 46);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            
            
            
            this.layoutControlItem3.Control = this.cancelSimpleButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(634, 320);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsPrint.AllowPrint = false;
            this.layoutControlItem3.Size = new System.Drawing.Size(124, 46);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            
            
            
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.DevAV.ViewModels.EvaluationViewModel);
            
            
            
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(622, 320);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(12, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(12, 10);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(12, 46);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl);
            this.Name = "NoteView";
            this.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.Size = new System.Drawing.Size(822, 426);
            this.MinimumSize = new System.Drawing.Size(822, 426);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            this.dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedToLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private XtraEditors.MemoEdit memoEdit1;
        private XtraEditors.DateEdit dateEdit1;
        private XtraEditors.LookUpEdit assignedToLookUpEdit;
        private XtraEditors.TextEdit memoEdit2;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private XtraLayout.LayoutControlItem layoutControlItem10;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem7;
        private Utils.MVVM.MVVMContext mvvmContext;
        private XtraEditors.SimpleButton cancelSimpleButton;
        private XtraEditors.SimpleButton saveSimpleButton;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
