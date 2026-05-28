Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.StyleFormatConditions

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Appearance customization", "AppearanceCustomization.cs")>
    Public Module AppearanceCustomization

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
            AddHandler treeList.Load, Sub(s, e)
                treeList.ExpandAll()
                treeList.Columns(CStr(("Name"))).BestFit()
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
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Changing the row appearances settings")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Appearance", "OptionsView")>
        Public Sub RowAppearance(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.Appearance.Row.ForeColor = System.Drawing.Color.Blue
            ' Contains the appearance settings used to paint odd rows.
            treeList.Appearance.OddRow.BackColor = System.Drawing.Color.LightGreen
            ' Controls whether odd nodes are painted using the appearance settings provided by the TreeList.Appearance.OddRow property.
            treeList.OptionsView.EnableAppearanceOddRow = True
            ' The same for even row
            treeList.Appearance.EvenRow.BackColor = System.Drawing.Color.LightPink
            treeList.OptionsView.EnableAppearanceEvenRow = True
            ' Use this property control whether tree indents are painted using the appearance settings of their corresponding nodes.
            treeList.OptionsView.ShowIndentAsRowStyle = False
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Changing the appearance settings of the specific column cells")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AppearanceCell")>
        Public Sub CellAppearance(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Cell appearance settings customization for Name column
            Dim colName As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("Name")
            colName.AppearanceCell.BackColor = System.Drawing.Color.LightGreen
            colName.AppearanceCell.BackColor2 = System.Drawing.Color.Green
            ' Cell appearance settings customization for Notes column
            Dim colNotes As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("Notes")
            colNotes.AppearanceCell.ForeColor = System.Drawing.Color.Blue
            colNotes.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Underline
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Changing the appearance settings of column cells dynamically")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("NodeCellStyle", "Appearance")>
        Public Sub ChangingCellAppearanceDynamically(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            AddHandler treeList.NodeCellStyle, Sub(sender, e)
                Dim radius As Integer = System.Convert.ToInt32(e.Node.GetValue("MeanRadiusInKM"))
                If Equals(e.Column.FieldName, "Name") Then
                    e.Appearance.BackColor = If(radius < 25000, System.Drawing.Color.LightPink, System.Drawing.Color.LightGreen)
                    e.Appearance.ForeColor = System.Drawing.Color.Blue
                Else
                    e.Appearance.ForeColor = If(radius < 25000, System.Drawing.Color.Red, System.Drawing.Color.Green)
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Changing the background color of an active editor")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShownEditor")>
        Public Sub ChangingColorOfAnActiveEditor(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.OptionsBehavior.Editable = True
            ' The ShownEditor event is designed to perform specific actions after a cell editor has been invoked.
            AddHandler treeList.ShownEditor, Sub(sender, e)
                ' The editor can be accessed using the ActiveEditor property.
                Dim activeEditor = treeList.ActiveEditor
                If TypeOf treeList.FocusedValue Is Integer Then
                    activeEditor.BackColor = If((CInt(treeList.FocusedValue)) < 25000, System.Drawing.Color.LightPink, System.Drawing.Color.LightGreen)
                Else
                    activeEditor.BackColor = System.Drawing.Color.Yellow
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Applying custom styles to nodes at different levels")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("NodeCellStyle", "Appearance")>
        Public Sub ChangingColorOfNodeLevels(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            AddHandler treeList.NodeCellStyle, Sub(sender, e) e.Appearance.BackColor = If((e.Node.Level Mod 2 = 0), System.Drawing.Color.LightBlue, System.Drawing.Color.LightGreen)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prioritize cell selection appearances"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("NodeCellStyle", "IsCellSelected")>
        Public Sub CellSelectionPriority(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.OptionsSelection.MultiSelect = True
            treeList.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect
            Dim colName As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("Name")
            colName.AppearanceCell.BackColor = System.Drawing.Color.Salmon
            colName.AppearanceCell.Options.UseBackColor = True
            AddHandler treeList.NodeCellStyle, Sub(s, e)
                Dim tl As DevExpress.XtraTreeList.TreeList = TryCast(s, DevExpress.XtraTreeList.TreeList)
                If tl.IsCellSelected(e.Node, e.Column) Then e.Appearance.BackColor = tl.ViewInfo.PaintAppearance.SelectedRow.BackColor
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Disable focused cell highlight"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("EnableAppearanceFocusedCell")>
        Public Sub DisableFocusedCellAppearance(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.OptionsBehavior.Editable = False
            ' Prevent the focused cell from being highlighted.
            treeList.OptionsSelection.EnableAppearanceFocusedCell = False
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Appearance of nodes (dynamically)"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("NodeCellStyle", "Appearance")>
        Public Sub AppearanceOfRowsDynamically(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            Dim colName As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("Name")
            colName.AppearanceCell.BackColor = System.Drawing.Color.Salmon
            colName.AppearanceCell.Options.UseBackColor = True
            treeList.OptionsBehavior.Editable = False
            Dim foreColor As System.Drawing.Color = System.Drawing.Color.MediumOrchid
            Dim backColor As System.Drawing.Color = System.Drawing.Color.LightGreen
            'Changing the appearance settings of row cells dynamically
            AddHandler treeList.NodeCellStyle, Sub(s, e)
                Dim tl As DevExpress.XtraTreeList.TreeList = TryCast(s, DevExpress.XtraTreeList.TreeList)
                'Change selected rows' fore and back colors
                Dim mark As Boolean = CBool(e.Node.GetValue(tl.Columns("Mark")))
                If mark Then
                    If tl.FocusedNode Is e.Node Then
                        e.Appearance.BackColor = tl.ViewInfo.PaintAppearance.SelectedRow.BackColor
                    Else
                        e.Appearance.ForeColor = foreColor
                        e.Appearance.BackColor = backColor
                    End If
                End If
            End Sub
        End Sub
    End Module
End Namespace
