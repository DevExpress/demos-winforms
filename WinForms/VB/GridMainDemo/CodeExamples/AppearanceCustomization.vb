Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Appearance customization", "AppearanceCustomization.cs")>
    Public Module AppearanceCustomization

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            gridView.PopulateColumns()
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Appearance customization"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Appearance of column cells"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AppearanceCell")>
        Public Sub AppearanceOfColumnCells(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim colID As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("ID")
            colID.AppearanceCell.BackColor2 = System.Drawing.Color.DarkGreen
            colID.AppearanceCell.BackColor = System.Drawing.Color.LightGreen
            colID.AppearanceCell.ForeColor = System.Drawing.Color.White
            Dim colName As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Name")
            colName.AppearanceCell.BackColor = System.Drawing.Color.Brown
            colName.AppearanceCell.ForeColor = System.Drawing.Color.Yellow
            Dim colRecordDate As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("RecordDate")
            colRecordDate.AppearanceCell.ForeColor = System.Drawing.Color.Red
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Appearance of column cells (dynamically)"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RowCellStyle", "Appearance")>
        Public Sub AppearanceOfColumnCellsDynamically(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            'Changing the appearance settings of column cells dynamically
            AddHandler gridView.RowCellStyle, Sub(sender, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                Dim _mark As Boolean = CBool(view.GetRowCellValue(e.RowHandle, "Mark"))
                If Equals(e.Column.FieldName, "Name") Then
                    e.Appearance.BackColor = If(_mark, System.Drawing.Color.LightGreen, System.Drawing.Color.LightSalmon)
                    e.Appearance.TextOptions.HAlignment = If(_mark, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.HorzAlignment.Near)
                End If

                If Equals(e.Column.FieldName, "Length") Then
                    Dim _length As Double = CDbl(e.CellValue)
                    If _length > 25 Then e.Appearance.ForeColor = System.Drawing.Color.Red
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Appearance of rows (dynamically)"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RowStyle", "Appearance", "HighPriority")>
        Public Sub AppearanceOfRowsDynamically(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim colName As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Name")
            colName.AppearanceCell.BackColor = System.Drawing.Color.Salmon
            colName.AppearanceCell.Options.UseBackColor = True
            gridView.OptionsBehavior.Editable = False
            Dim foreColor As System.Drawing.Color = System.Drawing.Color.LightCoral
            Dim backColor As System.Drawing.Color = System.Drawing.Color.LightGreen
            'Changing the appearance settings of row cells dynamically
            AddHandler gridView.RowStyle, Sub(sender, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                'Change selected rows' fore and back colors
                If view.IsRowSelected(e.RowHandle) Then
                    e.Appearance.ForeColor = foreColor
                    e.Appearance.BackColor = backColor
                    ' This property controls whether settings provided by the RowStyle event have a higher priority 
                    e.HighPriority = True
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Active editor’s background color"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShownEditor", "ActiveEditor")>
        Public Sub ActiveEditorBackColor(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' ShownEditor event is designed to perform specific actions after a cell editor has been invoked.
            AddHandler gridView.ShownEditor, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                ' The editor can be accessed using the ActiveEditor property.
                gridView.ActiveEditor.BackColor = System.Drawing.Color.DodgerBlue
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Appearance of group levels"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GroupLevelStyle", "LevelAppearance")>
        Public Sub AppearanceOfGroupLevels(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("ID"))).Group()
            gridView.Columns(CStr(("Mark"))).Group()
            gridView.ExpandAllGroups()
            AddHandler gridView.GroupLevelStyle, Sub(s, e)
                If e.Level = 0 Then
                    e.LevelAppearance.ForeColor = System.Drawing.Color.WhiteSmoke
                    e.LevelAppearance.BackColor = System.Drawing.Color.Salmon
                Else
                    e.LevelAppearance.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50)
                    e.LevelAppearance.BackColor = System.Drawing.Color.LightSalmon
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Cell content alignment"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RowCellDefaultAlignment", "HorzAlignment")>
        Public Sub CellContentAlignment(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            AddHandler gridView.RowCellDefaultAlignment, Sub(s, e)
                Dim alignment As DevExpress.Utils.HorzAlignment = DevExpress.Utils.HorzAlignment.[Default]
                Select Case e.RowHandle Mod 3
                    Case 0
                        alignment = DevExpress.Utils.HorzAlignment.Center
                    Case 1
                        alignment = DevExpress.Utils.HorzAlignment.Far
                    Case 2
                        alignment = DevExpress.Utils.HorzAlignment.Near
                End Select

                e.HorzAlignment = alignment
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prioritize cell selection appearances"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RowCellStyle", "IsCellSelected")>
        Public Sub CellSelectionPriority(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsSelection.MultiSelect = True
            gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
            Dim colName As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Name")
            colName.AppearanceCell.BackColor = System.Drawing.Color.Salmon
            colName.AppearanceCell.Options.UseBackColor = True
            AddHandler gridView.RowCellStyle, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                If view.IsCellSelected(e.RowHandle, e.Column) Then e.Appearance.BackColor = view.PaintAppearance.SelectedRow.BackColor
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Disable focused cell highlight"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("EnableAppearanceFocusedCell")>
        Public Sub DisableFocusedCellAppearance(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsBehavior.Editable = False
            ' Prevent the focused cell from being highlighted.
            gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prioritize conditional formatting appearances"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RowCellStyle", "FormatConditionRuleValue", "IsRowSelected", "GridFormatRule", "FormatConditionRuleAppearanceBase")>
        Public Sub ConditionalFormattingPriority(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim lengthRuleCondition As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            lengthRuleCondition.Condition = DevExpress.XtraEditors.FormatCondition.GreaterOrEqual
            lengthRuleCondition.Value1 = 25
            lengthRuleCondition.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen
            lengthRuleCondition.Appearance.Options.UseBackColor = True
            Dim lengthRule As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule() With {.Column = gridView.Columns("Length"), .Rule = lengthRuleCondition}
            gridView.FormatRules.Add(lengthRule)
            AddHandler gridView.RowCellStyle, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                If view.IsRowSelected(e.RowHandle) AndAlso Equals(e.Column.FieldName, "Length") AndAlso lengthRule.IsFit(e.CellValue, view.GetDataSourceRowIndex(e.RowHandle)) Then
                    Dim ruleAppearance As DevExpress.Utils.AppearanceObject = TryCast(lengthRule.Rule, DevExpress.XtraEditors.FormatConditionRuleAppearanceBase).Appearance
                    e.Appearance.BackColor = ruleAppearance.BackColor
                End If
            End Sub
        End Sub
#End Region
    End Module
End Namespace
