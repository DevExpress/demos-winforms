using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraLayout;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Edit Form", "EditForm.cs")]
    public static class EditForm {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(5);
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }

        #region EditForm

        #region CustomEditFormTemplate
        [CodeExampleNestedClass("")]
        public class CustomEditForm : EditFormUserControl {
            private LayoutControl CustomEditFormLayoutControl;
            private TextEdit IDTextEdit;
            private LayoutControlGroup RootGroup;
            private LayoutControlItem IDitem;
            private GridLookUpEdit NameGridLookUpEdit;
            private GridView NameGridLookUpEditView;
            private SpinEdit LengthSpinEdit;
            private TextEdit NoteTextEdit;
            private CheckEdit MarkCheckEdit;
            private DateEdit RecordDateDateEdit;
            private LayoutControlGroup IDGroup;
            private TabbedControlGroup AnotherGroup;
            private LayoutControlGroup RecordDateGroup;
            private LayoutControlItem RecordDateItem;
            private LayoutControlItem MarkItem;
            private EmptySpaceItem RecordDateGroupEmptySpaceItem;
            private LayoutControlGroup NoteGroup;
            private LayoutControlItem NoteItem;
            private LayoutControlItem LengthItem;
            private EmptySpaceItem NoteGroupEmptySpaceItem;
            private LayoutControlItem NameItem;

            public CustomEditForm() {
                InitializeComponent();
                NameGridLookUpEdit.Properties.DataSource = SampleData.GetData(10);
            }

            private void InitializeComponent() {
                this.CustomEditFormLayoutControl = new DevExpress.XtraLayout.LayoutControl();
                this.LengthSpinEdit = new DevExpress.XtraEditors.SpinEdit();
                this.NoteTextEdit = new DevExpress.XtraEditors.TextEdit();
                this.MarkCheckEdit = new DevExpress.XtraEditors.CheckEdit();
                this.RecordDateDateEdit = new DevExpress.XtraEditors.DateEdit();
                this.NameGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
                this.NameGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
                this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
                this.RootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
                this.IDGroup = new DevExpress.XtraLayout.LayoutControlGroup();
                this.IDitem = new DevExpress.XtraLayout.LayoutControlItem();
                this.NameItem = new DevExpress.XtraLayout.LayoutControlItem();
                this.AnotherGroup = new DevExpress.XtraLayout.TabbedControlGroup();
                this.NoteGroup = new DevExpress.XtraLayout.LayoutControlGroup();
                this.NoteItem = new DevExpress.XtraLayout.LayoutControlItem();
                this.LengthItem = new DevExpress.XtraLayout.LayoutControlItem();
                this.NoteGroupEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
                this.RecordDateGroup = new DevExpress.XtraLayout.LayoutControlGroup();
                this.RecordDateItem = new DevExpress.XtraLayout.LayoutControlItem();
                this.MarkItem = new DevExpress.XtraLayout.LayoutControlItem();
                this.RecordDateGroupEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
                ((System.ComponentModel.ISupportInitialize)(this.CustomEditFormLayoutControl)).BeginInit();
                this.CustomEditFormLayoutControl.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.LengthSpinEdit.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.NoteTextEdit.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.MarkCheckEdit.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.RecordDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.RecordDateDateEdit.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.NameGridLookUpEdit.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.NameGridLookUpEditView)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.RootGroup)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.IDGroup)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.IDitem)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.NameItem)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.AnotherGroup)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.NoteGroup)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.NoteItem)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.LengthItem)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.NoteGroupEmptySpaceItem)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.RecordDateGroup)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.RecordDateItem)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.MarkItem)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.RecordDateGroupEmptySpaceItem)).BeginInit();
                this.SuspendLayout();
                // 
                // CustomEditFormLayoutControl
                // 
                this.SetBoundPropertyName(this.CustomEditFormLayoutControl, "");
                this.CustomEditFormLayoutControl.Controls.Add(this.LengthSpinEdit);
                this.CustomEditFormLayoutControl.Controls.Add(this.NoteTextEdit);
                this.CustomEditFormLayoutControl.Controls.Add(this.MarkCheckEdit);
                this.CustomEditFormLayoutControl.Controls.Add(this.RecordDateDateEdit);
                this.CustomEditFormLayoutControl.Controls.Add(this.NameGridLookUpEdit);
                this.CustomEditFormLayoutControl.Controls.Add(this.IDTextEdit);
                this.CustomEditFormLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
                this.CustomEditFormLayoutControl.Location = new System.Drawing.Point(0, 0);
                this.CustomEditFormLayoutControl.Name = "CustomEditFormLayoutControl";
                this.CustomEditFormLayoutControl.Root = this.RootGroup;
                this.CustomEditFormLayoutControl.Size = new System.Drawing.Size(373, 207);
                this.CustomEditFormLayoutControl.TabIndex = 1;
                this.CustomEditFormLayoutControl.Text = "CustomEditFormLayoutControl";
                // 
                // DoubleSpinEdit
                // 
                this.SetBoundFieldName(this.LengthSpinEdit, "Length");
                this.SetBoundPropertyName(this.LengthSpinEdit, "EditValue");
                this.LengthSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
                this.LengthSpinEdit.Location = new System.Drawing.Point(62, 150);
                this.LengthSpinEdit.Name = string.Format("{0}SpinEdit", "Length");
                this.LengthSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                this.LengthSpinEdit.Size = new System.Drawing.Size(297, 20);
                this.LengthSpinEdit.StyleController = this.CustomEditFormLayoutControl;
                this.LengthSpinEdit.TabIndex = 9;
                // 
                // TextTextEdit
                // 
                this.SetBoundFieldName(this.NoteTextEdit, "Notes");
                this.SetBoundPropertyName(this.NoteTextEdit, "EditValue");
                this.NoteTextEdit.Location = new System.Drawing.Point(62, 126);
                this.NoteTextEdit.Name = string.Format("{0}TextEdit", "Notes");
                this.NoteTextEdit.Size = new System.Drawing.Size(297, 20);
                this.NoteTextEdit.StyleController = this.CustomEditFormLayoutControl;
                this.NoteTextEdit.TabIndex = 8;
                // 
                // BoolCheckEdit
                // 
                this.SetBoundFieldName(this.MarkCheckEdit, "Mark");
                this.SetBoundPropertyName(this.MarkCheckEdit, "EditValue");
                this.MarkCheckEdit.Location = new System.Drawing.Point(62, 150);
                this.MarkCheckEdit.Name = string.Format("{0}CheckEdit", "Mark");
                this.MarkCheckEdit.Properties.Caption = "";
                this.MarkCheckEdit.Size = new System.Drawing.Size(297, 19);
                this.MarkCheckEdit.StyleController = this.CustomEditFormLayoutControl;
                this.MarkCheckEdit.TabIndex = 7;
                // 
                // DateTimeDateEdit
                // 
                this.SetBoundFieldName(this.RecordDateDateEdit, "RecordDate");
                this.SetBoundPropertyName(this.RecordDateDateEdit, "EditValue");
                this.RecordDateDateEdit.EditValue = null;
                this.RecordDateDateEdit.Location = new System.Drawing.Point(62, 126);
                this.RecordDateDateEdit.Name = string.Format("{0}DateEdit", "RecordDate");
                this.RecordDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                this.RecordDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                this.RecordDateDateEdit.Size = new System.Drawing.Size(297, 20);
                this.RecordDateDateEdit.StyleController = this.CustomEditFormLayoutControl;
                this.RecordDateDateEdit.TabIndex = 6;
                // 
                // NameGridLookUpEdit
                // 
                this.SetBoundFieldName(this.NameGridLookUpEdit, "Name");
                this.SetBoundPropertyName(this.NameGridLookUpEdit, "EditValue");
                this.NameGridLookUpEdit.Location = new System.Drawing.Point(62, 56);
                this.NameGridLookUpEdit.Name = string.Format("{0}GridLookUpEdit", "Name");
                this.NameGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                this.NameGridLookUpEdit.Properties.DisplayMember = "Name";
                this.NameGridLookUpEdit.Properties.ValueMember = "Name";
                this.NameGridLookUpEdit.Properties.View = this.NameGridLookUpEditView;
                this.NameGridLookUpEdit.Size = new System.Drawing.Size(297, 20);
                this.NameGridLookUpEdit.StyleController = this.CustomEditFormLayoutControl;
                this.NameGridLookUpEdit.TabIndex = 5;
                // 
                // gridLookUpEdit1View
                // 
                this.NameGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
                this.NameGridLookUpEditView.Name = string.Format("{0}GridLookUpEditView", "Name");
                this.NameGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
                this.NameGridLookUpEditView.OptionsView.ShowGroupPanel = false;
                // 
                // IDTextEdit
                // 
                this.SetBoundFieldName(this.IDTextEdit, "ID");
                this.SetBoundPropertyName(this.IDTextEdit, "EditValue");
                this.IDTextEdit.Location = new System.Drawing.Point(62, 32);
                this.IDTextEdit.Name = string.Format("{0}TextEdit", "ID");
                this.IDTextEdit.Size = new System.Drawing.Size(297, 20);
                this.IDTextEdit.StyleController = this.CustomEditFormLayoutControl;
                this.IDTextEdit.TabIndex = 4;
                // 
                // RootGroup
                // 
                this.RootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
                this.RootGroup.GroupBordersVisible = false;
                this.RootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.IDGroup,
            this.AnotherGroup});
                this.RootGroup.Location = new System.Drawing.Point(0, 0);
                this.RootGroup.Name = "RootGroup";
                this.RootGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
                this.RootGroup.Size = new System.Drawing.Size(373, 207);
                this.RootGroup.TextVisible = false;
                // 
                // IDGroup
                // 
                this.IDGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.IDitem,
            this.NameItem});
                this.IDGroup.Location = new System.Drawing.Point(0, 0);
                this.IDGroup.Name = string.Format("{0}Group", "ID");
                this.IDGroup.Size = new System.Drawing.Size(373, 90);
                this.IDGroup.Text = string.Format("{0} Group", "ID");
                // 
                // IDitem
                // 
                this.IDitem.Control = this.IDTextEdit;
                this.IDitem.Location = new System.Drawing.Point(0, 0);
                this.IDitem.Name = string.Format("{0}item", "ID");
                this.IDitem.Size = new System.Drawing.Size(349, 24);
                this.IDitem.Text = "ID";
                this.IDitem.TextSize = new System.Drawing.Size(45, 13);
                // 
                // NameItem
                // 
                this.NameItem.Control = this.NameGridLookUpEdit;
                this.NameItem.Location = new System.Drawing.Point(0, 24);
                this.NameItem.Name = string.Format("{0}Item", "Name");
                this.NameItem.Size = new System.Drawing.Size(349, 24);
                this.NameItem.Text = "Name";
                this.NameItem.TextSize = new System.Drawing.Size(45, 13);
                // 
                // AnotherGroup
                // 
                this.AnotherGroup.Location = new System.Drawing.Point(0, 90);
                this.AnotherGroup.Name = "AnotherGroup";
                this.AnotherGroup.SelectedTabPage = this.RecordDateGroup;
                this.AnotherGroup.SelectedTabPageIndex = 0;
                this.AnotherGroup.Size = new System.Drawing.Size(373, 117);
                this.AnotherGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.RecordDateGroup,
            this.NoteGroup});
                this.AnotherGroup.Text = "Another Group";
                // 
                // TextGroup
                // 
                this.NoteGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.NoteItem,
            this.LengthItem,
            this.NoteGroupEmptySpaceItem});
                this.NoteGroup.Location = new System.Drawing.Point(0, 0);
                this.NoteGroup.Name = string.Format("{0}Group", "Notes");
                this.NoteGroup.Size = new System.Drawing.Size(349, 71);
                this.NoteGroup.Text = string.Format("{0} Group", "Notes");
                // 
                // TextItem
                // 
                this.NoteItem.Control = this.NoteTextEdit;
                this.NoteItem.Location = new System.Drawing.Point(0, 0);
                this.NoteItem.Name = string.Format("{0}Item", "Notes");
                this.NoteItem.Size = new System.Drawing.Size(349, 24);
                this.NoteItem.Text = "Notes";
                this.NoteItem.TextSize = new System.Drawing.Size(45, 13);
                // 
                // DoubleItem
                // 
                this.LengthItem.Control = this.LengthSpinEdit;
                this.LengthItem.Location = new System.Drawing.Point(0, 24);
                this.LengthItem.Name = string.Format("{0}Item", "Length");
                this.LengthItem.Size = new System.Drawing.Size(349, 24);
                this.LengthItem.Text = "Length";
                this.LengthItem.TextSize = new System.Drawing.Size(45, 13);
                // 
                // TextGroupEmptySpaceItem
                // 
                this.NoteGroupEmptySpaceItem.AllowHotTrack = false;
                this.NoteGroupEmptySpaceItem.Location = new System.Drawing.Point(0, 48);
                this.NoteGroupEmptySpaceItem.Name = string.Format("{0}GroupEmptySpaceItem", "Notes");
                this.NoteGroupEmptySpaceItem.Size = new System.Drawing.Size(349, 11);
                this.NoteGroupEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
                // 
                // DateTimeGroup
                // 
                this.RecordDateGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.RecordDateItem,
            this.MarkItem,
            this.RecordDateGroupEmptySpaceItem});
                this.RecordDateGroup.Location = new System.Drawing.Point(0, 0);
                this.RecordDateGroup.Name = string.Format("{0}Group", "RecordDate");
                this.RecordDateGroup.Size = new System.Drawing.Size(349, 71);
                this.RecordDateGroup.Text = string.Format("{0} Group", "RecordDate");
                // 
                // DateTimeItem
                // 
                this.RecordDateItem.Control = this.RecordDateDateEdit;
                this.RecordDateItem.Location = new System.Drawing.Point(0, 0);
                this.RecordDateItem.Name = string.Format("{0}Item", "RecordDate");
                this.RecordDateItem.Size = new System.Drawing.Size(349, 24);
                this.RecordDateItem.Text = "RecordDate";
                this.RecordDateItem.TextSize = new System.Drawing.Size(45, 13);
                // 
                // BoolItem
                // 
                this.MarkItem.Control = this.MarkCheckEdit;
                this.MarkItem.Location = new System.Drawing.Point(0, 24);
                this.MarkItem.Name = string.Format("{0}Item", "Mark");
                this.MarkItem.Size = new System.Drawing.Size(349, 23);
                this.MarkItem.Text = "Mark";
                this.MarkItem.TextSize = new System.Drawing.Size(45, 13);
                // 
                // DateTimeGroupEmptySpaceItem
                // 
                this.RecordDateGroupEmptySpaceItem.AllowHotTrack = false;
                this.RecordDateGroupEmptySpaceItem.Location = new System.Drawing.Point(0, 47);
                this.RecordDateGroupEmptySpaceItem.Name = string.Format("{0}GroupEmptySpaceItem", "RecordDate");
                this.RecordDateGroupEmptySpaceItem.Size = new System.Drawing.Size(349, 12);
                this.RecordDateGroupEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
                // 
                // CustomEditForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.Controls.Add(this.CustomEditFormLayoutControl);
                this.Name = "CustomEditForm";
                this.Size = new System.Drawing.Size(373, 207);
                ((System.ComponentModel.ISupportInitialize)(this.CustomEditFormLayoutControl)).EndInit();
                this.CustomEditFormLayoutControl.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.LengthSpinEdit.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.NoteTextEdit.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.MarkCheckEdit.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.RecordDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.RecordDateDateEdit.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.NameGridLookUpEdit.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.NameGridLookUpEditView)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.RootGroup)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.IDGroup)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.IDitem)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.NameItem)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.AnotherGroup)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.NoteGroup)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.NoteItem)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.LengthItem)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.NoteGroupEmptySpaceItem)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.RecordDateGroup)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.RecordDateItem)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.MarkItem)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.RecordDateGroupEmptySpaceItem)).EndInit();
                this.ResumeLayout(false);
            }
        }
        #endregion
        
        [CodeExampleCase("Modal or Inline Edit Form"), SampleDataSourceFile]        
        public static void EditFormEditingMode(GridControl gridControl, GridView gridView) {
            gridView.OptionsBehavior.EditingMode = GridEditingMode.EditForm;
            // Available modes:
            // Default - Provides the same functionality as the Inplace value.  
            // EditForm - Row data is edited in a separate modal Edit Form.  
            // EditFormInplace - Row data is edited in an in-line Edit Form that appears immediately below the selected row.  
            // EditFormInplaceHideCurrentRow - Row data is edited in an in-line Edit Form while the selected row is hidden.  
            // Inplace - Row data is edited in-place, in row cells.  
        }
        [CodeExampleCase("Custom Edit Form", new Type[] {typeof(CustomEditForm) }), SampleDataSourceFile]
        public static void CustomEditFormLayout(GridControl gridControl, GridView gridView) {
            gridView.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace;

            //Assign an instance of CustomEditForm to the GridOptionsEditForm.CustomEditFormLayout property
            //to use the CustomEditForm as an EditForm within the grid
            gridView.OptionsEditForm.CustomEditFormLayout = new CustomEditForm();

            //A special note: If there is no enough space to embed(EditFormInplace, EditFormInplaceHideCurrentRow)
            //   a custom EditForm into the GridView, the custom EditForm is shown as a separate window
        }
        [CodeExampleCase("Access an editor within the Edit Form"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("EditFormPrepared")]
        public static void AccessEditFormEditor(GridControl gridControl, GridView gridView) {            
            gridView.OptionsBehavior.EditingMode = GridEditingMode.EditForm;
            DateEdit dateEdit = null;

            // This event occurs when the EditForm is about to be displayed and allows accessing its editors
            gridView.EditFormPrepared += (s, e) => {
                // The e.BindableControls collection contains a list of editors located onto the EditForm
                foreach (Control item in e.BindableControls) {
                    dateEdit = item as DateEdit;
                    if (dateEdit != null) {
                        // Focus the DateEdit editor
                        gridControl.BeginInvoke(new MethodInvoker(() => { dateEdit.Focus(); }));
                        return;
                    }
                }
            };
        }
        [CodeExampleCase("Prevent the Edit Form from showing"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("EditFormShowing")]
        public static void PreventShowingEditForm(GridControl gridControl, GridView gridView) {            
            gridView.OptionsBehavior.EditingMode = GridEditingMode.EditForm;

            //This event occurs when the Edit Form is about to be displayed.
            //  Set the Allow parameter to false to prevent the Edit Form from being displayed. 
           gridView.EditFormShowing += (s, e) => {
                if (e.RowHandle % 2 == 0)
                    e.Allow = false;
            };
        }
        #endregion
    }
}
