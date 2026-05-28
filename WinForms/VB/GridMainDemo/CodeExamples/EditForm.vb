Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.XtraLayout
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Edit Form", "EditForm.cs")>
    Public Module EditForm

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(5)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "EditForm"
#Region "CustomEditFormTemplate"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public Class CustomEditForm
            Inherits DevExpress.XtraGrid.Views.Grid.EditFormUserControl

            Private CustomEditFormLayoutControl As DevExpress.XtraLayout.LayoutControl

            Private IDTextEdit As DevExpress.XtraEditors.TextEdit

            Private RootGroup As DevExpress.XtraLayout.LayoutControlGroup

            Private IDitem As DevExpress.XtraLayout.LayoutControlItem

            Private NameGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit

            Private NameGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView

            Private LengthSpinEdit As DevExpress.XtraEditors.SpinEdit

            Private NoteTextEdit As DevExpress.XtraEditors.TextEdit

            Private MarkCheckEdit As DevExpress.XtraEditors.CheckEdit

            Private RecordDateDateEdit As DevExpress.XtraEditors.DateEdit

            Private IDGroup As DevExpress.XtraLayout.LayoutControlGroup

            Private AnotherGroup As DevExpress.XtraLayout.TabbedControlGroup

            Private RecordDateGroup As DevExpress.XtraLayout.LayoutControlGroup

            Private RecordDateItem As DevExpress.XtraLayout.LayoutControlItem

            Private MarkItem As DevExpress.XtraLayout.LayoutControlItem

            Private RecordDateGroupEmptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

            Private NoteGroup As DevExpress.XtraLayout.LayoutControlGroup

            Private NoteItem As DevExpress.XtraLayout.LayoutControlItem

            Private LengthItem As DevExpress.XtraLayout.LayoutControlItem

            Private NoteGroupEmptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

            Private NameItem As DevExpress.XtraLayout.LayoutControlItem

            Public Sub New()
                Me.InitializeComponent()
                Me.NameGridLookUpEdit.Properties.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            End Sub

            Private Sub InitializeComponent()
                Me.CustomEditFormLayoutControl = New DevExpress.XtraLayout.LayoutControl()
                Me.LengthSpinEdit = New DevExpress.XtraEditors.SpinEdit()
                Me.NoteTextEdit = New DevExpress.XtraEditors.TextEdit()
                Me.MarkCheckEdit = New DevExpress.XtraEditors.CheckEdit()
                Me.RecordDateDateEdit = New DevExpress.XtraEditors.DateEdit()
                Me.NameGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
                Me.NameGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
                Me.IDTextEdit = New DevExpress.XtraEditors.TextEdit()
                Me.RootGroup = New DevExpress.XtraLayout.LayoutControlGroup()
                Me.IDGroup = New DevExpress.XtraLayout.LayoutControlGroup()
                Me.IDitem = New DevExpress.XtraLayout.LayoutControlItem()
                Me.NameItem = New DevExpress.XtraLayout.LayoutControlItem()
                Me.AnotherGroup = New DevExpress.XtraLayout.TabbedControlGroup()
                Me.NoteGroup = New DevExpress.XtraLayout.LayoutControlGroup()
                Me.NoteItem = New DevExpress.XtraLayout.LayoutControlItem()
                Me.LengthItem = New DevExpress.XtraLayout.LayoutControlItem()
                Me.NoteGroupEmptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
                Me.RecordDateGroup = New DevExpress.XtraLayout.LayoutControlGroup()
                Me.RecordDateItem = New DevExpress.XtraLayout.LayoutControlItem()
                Me.MarkItem = New DevExpress.XtraLayout.LayoutControlItem()
                Me.RecordDateGroupEmptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
                CType((Me.CustomEditFormLayoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.CustomEditFormLayoutControl.SuspendLayout()
                CType((Me.LengthSpinEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.NoteTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.MarkCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.RecordDateDateEdit.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.RecordDateDateEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.NameGridLookUpEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.NameGridLookUpEditView), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.IDTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.RootGroup), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.IDGroup), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.IDitem), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.NameItem), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.AnotherGroup), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.NoteGroup), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.NoteItem), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.LengthItem), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.NoteGroupEmptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.RecordDateGroup), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.RecordDateItem), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.MarkItem), System.ComponentModel.ISupportInitialize).BeginInit()
                CType((Me.RecordDateGroupEmptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()
                ' 
                ' CustomEditFormLayoutControl
                ' 
                Me.SetBoundPropertyName(Me.CustomEditFormLayoutControl, "")
                Me.CustomEditFormLayoutControl.Controls.Add(Me.LengthSpinEdit)
                Me.CustomEditFormLayoutControl.Controls.Add(Me.NoteTextEdit)
                Me.CustomEditFormLayoutControl.Controls.Add(Me.MarkCheckEdit)
                Me.CustomEditFormLayoutControl.Controls.Add(Me.RecordDateDateEdit)
                Me.CustomEditFormLayoutControl.Controls.Add(Me.NameGridLookUpEdit)
                Me.CustomEditFormLayoutControl.Controls.Add(Me.IDTextEdit)
                Me.CustomEditFormLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
                Me.CustomEditFormLayoutControl.Location = New System.Drawing.Point(0, 0)
                Me.CustomEditFormLayoutControl.Name = "CustomEditFormLayoutControl"
                Me.CustomEditFormLayoutControl.Root = Me.RootGroup
                Me.CustomEditFormLayoutControl.Size = New System.Drawing.Size(373, 207)
                Me.CustomEditFormLayoutControl.TabIndex = 1
                Me.CustomEditFormLayoutControl.Text = "CustomEditFormLayoutControl"
                ' 
                ' DoubleSpinEdit
                ' 
                Me.SetBoundFieldName(Me.LengthSpinEdit, "Length")
                Me.SetBoundPropertyName(Me.LengthSpinEdit, "EditValue")
                Me.LengthSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
                Me.LengthSpinEdit.Location = New System.Drawing.Point(62, 150)
                Me.LengthSpinEdit.Name = String.Format("{0}SpinEdit", "Length")
                Me.LengthSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
                Me.LengthSpinEdit.Size = New System.Drawing.Size(297, 20)
                Me.LengthSpinEdit.StyleController = Me.CustomEditFormLayoutControl
                Me.LengthSpinEdit.TabIndex = 9
                ' 
                ' TextTextEdit
                ' 
                Me.SetBoundFieldName(Me.NoteTextEdit, "Notes")
                Me.SetBoundPropertyName(Me.NoteTextEdit, "EditValue")
                Me.NoteTextEdit.Location = New System.Drawing.Point(62, 126)
                Me.NoteTextEdit.Name = String.Format("{0}TextEdit", "Notes")
                Me.NoteTextEdit.Size = New System.Drawing.Size(297, 20)
                Me.NoteTextEdit.StyleController = Me.CustomEditFormLayoutControl
                Me.NoteTextEdit.TabIndex = 8
                ' 
                ' BoolCheckEdit
                ' 
                Me.SetBoundFieldName(Me.MarkCheckEdit, "Mark")
                Me.SetBoundPropertyName(Me.MarkCheckEdit, "EditValue")
                Me.MarkCheckEdit.Location = New System.Drawing.Point(62, 150)
                Me.MarkCheckEdit.Name = String.Format("{0}CheckEdit", "Mark")
                Me.MarkCheckEdit.Properties.Caption = ""
                Me.MarkCheckEdit.Size = New System.Drawing.Size(297, 19)
                Me.MarkCheckEdit.StyleController = Me.CustomEditFormLayoutControl
                Me.MarkCheckEdit.TabIndex = 7
                ' 
                ' DateTimeDateEdit
                ' 
                Me.SetBoundFieldName(Me.RecordDateDateEdit, "RecordDate")
                Me.SetBoundPropertyName(Me.RecordDateDateEdit, "EditValue")
                Me.RecordDateDateEdit.EditValue = Nothing
                Me.RecordDateDateEdit.Location = New System.Drawing.Point(62, 126)
                Me.RecordDateDateEdit.Name = String.Format("{0}DateEdit", "RecordDate")
                Me.RecordDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
                Me.RecordDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
                Me.RecordDateDateEdit.Size = New System.Drawing.Size(297, 20)
                Me.RecordDateDateEdit.StyleController = Me.CustomEditFormLayoutControl
                Me.RecordDateDateEdit.TabIndex = 6
                ' 
                ' NameGridLookUpEdit
                ' 
                Me.SetBoundFieldName(Me.NameGridLookUpEdit, "Name")
                Me.SetBoundPropertyName(Me.NameGridLookUpEdit, "EditValue")
                Me.NameGridLookUpEdit.Location = New System.Drawing.Point(62, 56)
                Me.NameGridLookUpEdit.Name = String.Format("{0}GridLookUpEdit", "Name")
                Me.NameGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
                Me.NameGridLookUpEdit.Properties.DisplayMember = "Name"
                Me.NameGridLookUpEdit.Properties.ValueMember = "Name"
                Me.NameGridLookUpEdit.Properties.View = Me.NameGridLookUpEditView
                Me.NameGridLookUpEdit.Size = New System.Drawing.Size(297, 20)
                Me.NameGridLookUpEdit.StyleController = Me.CustomEditFormLayoutControl
                Me.NameGridLookUpEdit.TabIndex = 5
                ' 
                ' gridLookUpEdit1View
                ' 
                Me.NameGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
                Me.NameGridLookUpEditView.Name = String.Format("{0}GridLookUpEditView", "Name")
                Me.NameGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
                Me.NameGridLookUpEditView.OptionsView.ShowGroupPanel = False
                ' 
                ' IDTextEdit
                ' 
                Me.SetBoundFieldName(Me.IDTextEdit, "ID")
                Me.SetBoundPropertyName(Me.IDTextEdit, "EditValue")
                Me.IDTextEdit.Location = New System.Drawing.Point(62, 32)
                Me.IDTextEdit.Name = String.Format("{0}TextEdit", "ID")
                Me.IDTextEdit.Size = New System.Drawing.Size(297, 20)
                Me.IDTextEdit.StyleController = Me.CustomEditFormLayoutControl
                Me.IDTextEdit.TabIndex = 4
                ' 
                ' RootGroup
                ' 
                Me.RootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
                Me.RootGroup.GroupBordersVisible = False
                Me.RootGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.IDGroup, Me.AnotherGroup})
                Me.RootGroup.Location = New System.Drawing.Point(0, 0)
                Me.RootGroup.Name = "RootGroup"
                Me.RootGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
                Me.RootGroup.Size = New System.Drawing.Size(373, 207)
                Me.RootGroup.TextVisible = False
                ' 
                ' IDGroup
                ' 
                Me.IDGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.IDitem, Me.NameItem})
                Me.IDGroup.Location = New System.Drawing.Point(0, 0)
                Me.IDGroup.Name = String.Format("{0}Group", "ID")
                Me.IDGroup.Size = New System.Drawing.Size(373, 90)
                Me.IDGroup.Text = String.Format("{0} Group", "ID")
                ' 
                ' IDitem
                ' 
                Me.IDitem.Control = Me.IDTextEdit
                Me.IDitem.Location = New System.Drawing.Point(0, 0)
                Me.IDitem.Name = String.Format("{0}item", "ID")
                Me.IDitem.Size = New System.Drawing.Size(349, 24)
                Me.IDitem.Text = "ID"
                Me.IDitem.TextSize = New System.Drawing.Size(45, 13)
                ' 
                ' NameItem
                ' 
                Me.NameItem.Control = Me.NameGridLookUpEdit
                Me.NameItem.Location = New System.Drawing.Point(0, 24)
                Me.NameItem.Name = String.Format("{0}Item", "Name")
                Me.NameItem.Size = New System.Drawing.Size(349, 24)
                Me.NameItem.Text = "Name"
                Me.NameItem.TextSize = New System.Drawing.Size(45, 13)
                ' 
                ' AnotherGroup
                ' 
                Me.AnotherGroup.Location = New System.Drawing.Point(0, 90)
                Me.AnotherGroup.Name = "AnotherGroup"
                Me.AnotherGroup.SelectedTabPage = Me.RecordDateGroup
                Me.AnotherGroup.SelectedTabPageIndex = 0
                Me.AnotherGroup.Size = New System.Drawing.Size(373, 117)
                Me.AnotherGroup.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.RecordDateGroup, Me.NoteGroup})
                Me.AnotherGroup.Text = "Another Group"
                ' 
                ' TextGroup
                ' 
                Me.NoteGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.NoteItem, Me.LengthItem, Me.NoteGroupEmptySpaceItem})
                Me.NoteGroup.Location = New System.Drawing.Point(0, 0)
                Me.NoteGroup.Name = String.Format("{0}Group", "Notes")
                Me.NoteGroup.Size = New System.Drawing.Size(349, 71)
                Me.NoteGroup.Text = String.Format("{0} Group", "Notes")
                ' 
                ' TextItem
                ' 
                Me.NoteItem.Control = Me.NoteTextEdit
                Me.NoteItem.Location = New System.Drawing.Point(0, 0)
                Me.NoteItem.Name = String.Format("{0}Item", "Notes")
                Me.NoteItem.Size = New System.Drawing.Size(349, 24)
                Me.NoteItem.Text = "Notes"
                Me.NoteItem.TextSize = New System.Drawing.Size(45, 13)
                ' 
                ' DoubleItem
                ' 
                Me.LengthItem.Control = Me.LengthSpinEdit
                Me.LengthItem.Location = New System.Drawing.Point(0, 24)
                Me.LengthItem.Name = String.Format("{0}Item", "Length")
                Me.LengthItem.Size = New System.Drawing.Size(349, 24)
                Me.LengthItem.Text = "Length"
                Me.LengthItem.TextSize = New System.Drawing.Size(45, 13)
                ' 
                ' TextGroupEmptySpaceItem
                ' 
                Me.NoteGroupEmptySpaceItem.AllowHotTrack = False
                Me.NoteGroupEmptySpaceItem.Location = New System.Drawing.Point(0, 48)
                Me.NoteGroupEmptySpaceItem.Name = String.Format("{0}GroupEmptySpaceItem", "Notes")
                Me.NoteGroupEmptySpaceItem.Size = New System.Drawing.Size(349, 11)
                Me.NoteGroupEmptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
                ' 
                ' DateTimeGroup
                ' 
                Me.RecordDateGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.RecordDateItem, Me.MarkItem, Me.RecordDateGroupEmptySpaceItem})
                Me.RecordDateGroup.Location = New System.Drawing.Point(0, 0)
                Me.RecordDateGroup.Name = String.Format("{0}Group", "RecordDate")
                Me.RecordDateGroup.Size = New System.Drawing.Size(349, 71)
                Me.RecordDateGroup.Text = String.Format("{0} Group", "RecordDate")
                ' 
                ' DateTimeItem
                ' 
                Me.RecordDateItem.Control = Me.RecordDateDateEdit
                Me.RecordDateItem.Location = New System.Drawing.Point(0, 0)
                Me.RecordDateItem.Name = String.Format("{0}Item", "RecordDate")
                Me.RecordDateItem.Size = New System.Drawing.Size(349, 24)
                Me.RecordDateItem.Text = "RecordDate"
                Me.RecordDateItem.TextSize = New System.Drawing.Size(45, 13)
                ' 
                ' BoolItem
                ' 
                Me.MarkItem.Control = Me.MarkCheckEdit
                Me.MarkItem.Location = New System.Drawing.Point(0, 24)
                Me.MarkItem.Name = String.Format("{0}Item", "Mark")
                Me.MarkItem.Size = New System.Drawing.Size(349, 23)
                Me.MarkItem.Text = "Mark"
                Me.MarkItem.TextSize = New System.Drawing.Size(45, 13)
                ' 
                ' DateTimeGroupEmptySpaceItem
                ' 
                Me.RecordDateGroupEmptySpaceItem.AllowHotTrack = False
                Me.RecordDateGroupEmptySpaceItem.Location = New System.Drawing.Point(0, 47)
                Me.RecordDateGroupEmptySpaceItem.Name = String.Format("{0}GroupEmptySpaceItem", "RecordDate")
                Me.RecordDateGroupEmptySpaceItem.Size = New System.Drawing.Size(349, 12)
                Me.RecordDateGroupEmptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
                ' 
                ' CustomEditForm
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
                Me.Controls.Add(Me.CustomEditFormLayoutControl)
                Me.Name = "CustomEditForm"
                Me.Size = New System.Drawing.Size(373, 207)
                CType((Me.CustomEditFormLayoutControl), System.ComponentModel.ISupportInitialize).EndInit()
                Me.CustomEditFormLayoutControl.ResumeLayout(False)
                CType((Me.LengthSpinEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.NoteTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.MarkCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.RecordDateDateEdit.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.RecordDateDateEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.NameGridLookUpEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.NameGridLookUpEditView), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.IDTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.RootGroup), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.IDGroup), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.IDitem), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.NameItem), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.AnotherGroup), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.NoteGroup), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.NoteItem), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.LengthItem), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.NoteGroupEmptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.RecordDateGroup), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.RecordDateItem), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.MarkItem), System.ComponentModel.ISupportInitialize).EndInit()
                CType((Me.RecordDateGroupEmptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
                Me.ResumeLayout(False)
            End Sub
        End Class

#End Region
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Modal or Inline Edit Form"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        Public Sub EditFormEditingMode(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        ' Available modes:
        ' Default - Provides the same functionality as the Inplace value.  
        ' EditForm - Row data is edited in a separate modal Edit Form.  
        ' EditFormInplace - Row data is edited in an in-line Edit Form that appears immediately below the selected row.  
        ' EditFormInplaceHideCurrentRow - Row data is edited in an in-line Edit Form while the selected row is hidden.  
        ' Inplace - Row data is edited in-place, in row cells.  
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom Edit Form", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.EditForm.CustomEditForm)}), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        Public Sub CustomEditFormLayout(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
            'Assign an instance of CustomEditForm to the GridOptionsEditForm.CustomEditFormLayout property
            'to use the CustomEditForm as an EditForm within the grid
            gridView.OptionsEditForm.CustomEditFormLayout = New DevExpress.XtraGrid.Demos.CodeExamples.EditForm.CustomEditForm()
        'A special note: If there is no enough space to embed(EditFormInplace, EditFormInplaceHideCurrentRow)
        '   a custom EditForm into the GridView, the custom EditForm is shown as a separate window
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Access an editor within the Edit Form"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("EditFormPrepared")>
        Public Sub AccessEditFormEditor(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
            Dim dateEdit As DevExpress.XtraEditors.DateEdit = Nothing
            ' This event occurs when the EditForm is about to be displayed and allows accessing its editors
            AddHandler gridView.EditFormPrepared, Sub(s, e)
                ' The e.BindableControls collection contains a list of editors located onto the EditForm
                For Each item As System.Windows.Forms.Control In e.BindableControls
                    dateEdit = TryCast(item, DevExpress.XtraEditors.DateEdit)
                    If dateEdit IsNot Nothing Then
                        ' Focus the DateEdit editor
                        gridControl.BeginInvoke(New System.Windows.Forms.MethodInvoker(Sub() dateEdit.Focus()))
                        Return
                    End If
                Next
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent the Edit Form from showing"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("EditFormShowing")>
        Public Sub PreventShowingEditForm(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
            'This event occurs when the Edit Form is about to be displayed.
            '  Set the Allow parameter to false to prevent the Edit Form from being displayed. 
            AddHandler gridView.EditFormShowing, Sub(s, e)
                If e.RowHandle Mod 2 = 0 Then e.Allow = False
            End Sub
        End Sub
#End Region
    End Module
End Namespace
