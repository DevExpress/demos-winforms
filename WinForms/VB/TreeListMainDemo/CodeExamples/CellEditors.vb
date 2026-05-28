Imports System.Linq
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Cell editors", "CellEditors.cs")>
    Public Module CellEditors

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
            AddHandler treeList.Load, Sub(s, e)
                treeList.ExpandAll()
                treeList.Columns(CStr(("Name"))).BestFit()
                treeList.Columns(CStr(("MeanRadiusByEarth"))).BestFit()
                treeList.Columns(CStr(("MeanRadiusByEarth"))).SortOrder = System.Windows.Forms.SortOrder.Ascending
            End Sub
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Assign in-place editors dynamically")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomNodeCellEdit")>
        Public Sub AssignInPalceEditorsDynamically(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Predefined cell editors
            Dim spinEdit As DevExpress.XtraEditors.Repository.RepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Dim calcEdit As DevExpress.XtraEditors.Repository.RepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            treeList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {spinEdit, calcEdit})
            Dim colMeanRadiusInKM As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("MeanRadiusInKM")
            Dim colMark As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("Mark")
            colMeanRadiusInKM.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways
            ' Handle this event to assign editors to individual cells
            AddHandler treeList.CustomNodeCellEdit, Sub(s, e)
                If e.Column Is colMeanRadiusInKM Then
                    Dim markValue As Boolean = CBool(treeList.GetRowCellValue(e.Node, colMark))
                    e.RepositoryItem = If(markValue, spinEdit, calcEdit)
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Override the default in-place editor for certain cells"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ColumnEdit", "CustomNodeCellEdit")>
        Public Sub AssigningEditorsForInplaceEditing(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            Dim sun As DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject = CType(treeList.DataSource, System.Collections.Generic.IEnumerable(Of DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject)).First()
            ' Predefined cell editors
            Dim spinEditForEditing As DevExpress.XtraEditors.Repository.RepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Dim progressEditForDisplaying As DevExpress.XtraEditors.Repository.RepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar() With {.Maximum = sun.MeanRadiusInKM, .ShowTitle = True} ' SUN
            treeList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {spinEditForEditing, progressEditForDisplaying})
            'Assigning an editor to a column
            Dim colMeanRadiusInKM As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("MeanRadiusInKM")
            colMeanRadiusInKM.ColumnEdit = progressEditForDisplaying
            'Assigning an editor for in-place editing
            AddHandler treeList.CustomNodeCellEditForEditing, Sub(sender, e)
                If e.Column Is colMeanRadiusInKM Then e.RepositoryItem = spinEditForEditing
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Edit Form", "CellEditors.cs")>
        Public NotInheritable Class EditForm

            <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
            Public Shared Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
                Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
                treeList.Dock = System.Windows.Forms.DockStyle.Fill
                treeList.Parent = sampleHost
                treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
                AddHandler treeList.Load, Sub(s, e)
                    treeList.ExpandAll()
                    treeList.Columns(CStr(("Name"))).BestFit()
                    treeList.Columns(CStr(("MeanRadiusByEarth"))).BestFit()
                End Sub
                Return New Object() {treeList}
            End Function

            <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
            Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
                For Each control As System.Windows.Forms.Control In sampleHost.Controls
                    control.Dispose()
                Next

                sampleHost.Controls.Clear()
            End Sub

            '
            <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Edit nodes with the default Edit Form")>
            <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("EditingMode")>
            Public Shared Sub NodeEditingByDefaultEditForm(ByVal treeList As DevExpress.XtraTreeList.TreeList)
                ' Switch edit mode
                treeList.OptionsBehavior.EditingMode = DevExpress.XtraTreeList.TreeListEditingMode.EditForm
                treeList.Columns(CStr(("Notes"))).OptionsEditForm.UseEditorColRowSpan = False
                treeList.Columns(CStr(("Notes"))).OptionsEditForm.ColumnSpan = 3
                treeList.Columns(CStr(("Notes"))).OptionsEditForm.RowSpan = 2
            End Sub

            <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Edit nodes with a custom Edit Form")>
            <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("EditingMode", "CustomEditFormLayout")>
            Public Shared Sub NodeEditingByCustomEditForm(ByVal treeList As DevExpress.XtraTreeList.TreeList)
                ' Switch edit mode
                treeList.OptionsBehavior.EditingMode = DevExpress.XtraTreeList.TreeListEditingMode.EditForm
                ' Create a custom EditForm
                Dim control = New DevExpress.XtraTreeList.EditFormUserControl()
                control.Height = treeList.Height \ 2
                ' Add editors
                Dim memoEditNotes As DevExpress.XtraEditors.MemoEdit = New DevExpress.XtraEditors.MemoEdit()
                memoEditNotes.Dock = System.Windows.Forms.DockStyle.Fill
                Dim textEditName As DevExpress.XtraEditors.TextEdit = New DevExpress.XtraEditors.TextEdit()
                textEditName.Dock = System.Windows.Forms.DockStyle.Top
                Dim textEditType As DevExpress.XtraEditors.TextEdit = New DevExpress.XtraEditors.TextEdit()
                textEditType.Dock = System.Windows.Forms.DockStyle.Top
                Dim dateEditDate As DevExpress.XtraEditors.DateEdit = New DevExpress.XtraEditors.DateEdit()
                dateEditDate.Dock = System.Windows.Forms.DockStyle.Bottom
                control.Controls.Add(memoEditNotes)
                control.Controls.Add(dateEditDate)
                control.Controls.Add(textEditType)
                control.Controls.Add(textEditName)
                ' Bind the editors to data source fields
                control.SetBoundFieldName(memoEditNotes, "Notes")
                control.SetBoundFieldName(textEditName, "Name")
                control.SetBoundFieldName(textEditType, "TypeOfObject")
                control.SetBoundFieldName(dateEditDate, "RecordDate")
                ' Assing the Edit Form to the Tree List
                treeList.OptionsEditForm.CustomEditFormLayout = control
            End Sub
        End Class
    End Module
End Namespace
