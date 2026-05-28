Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS
Imports DevExpress.XtraEditors.TableLayout
Imports DevExpress.XtraGrid.Views.Tile

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Conditional formatting", "ConditionalFormatting.cs")>
    Public Module ConditionalFormatting

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            Dim tileView = New DevExpress.XtraGrid.Views.Tile.TileView()
            tileView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            tileView.OptionsTiles.ColumnCount = 1
            tileView.OptionsTiles.ItemSize = New System.Drawing.Size(350, 150)
            tileView.AnimateArrival = False
            Dim row1 = New DevExpress.XtraEditors.TableLayout.TableRowDefinition() With {.AutoHeight = True, .PaddingBottom = 6}
            Dim row2 = New DevExpress.XtraEditors.TableLayout.TableRowDefinition() With {.AutoHeight = True, .PaddingBottom = 6}
            Dim row3 = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            row3.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            row3.Length.Value = 30R
            tileView.TileRows.Add(row1)
            tileView.TileRows.Add(row2)
            tileView.TileRows.Add(row3)
            Dim column1 = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim column2 = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            column2.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            column2.Length.Value = 35R
            tileView.TileColumns.Add(column1)
            tileView.TileColumns.Add(column2)
            tileView.TileSpans.Add(New DevExpress.XtraEditors.TableLayout.TableSpan() With {.ColumnSpan = 2, .RowIndex = 1})
            tileView.TileSpans.Add(New DevExpress.XtraEditors.TableLayout.TableSpan() With {.ColumnSpan = 2, .RowIndex = 2})
            Dim colTask As DevExpress.XtraGrid.Columns.TileViewColumn = New DevExpress.XtraGrid.Columns.TileViewColumn() With {.FieldName = "Name", .Visible = True}
            Dim colEmployee As DevExpress.XtraGrid.Columns.TileViewColumn = New DevExpress.XtraGrid.Columns.TileViewColumn() With {.FieldName = "Employee", .Visible = True}
            Dim colDueDate As DevExpress.XtraGrid.Columns.TileViewColumn = New DevExpress.XtraGrid.Columns.TileViewColumn() With {.FieldName = "DueDate", .Visible = True}
            Dim colPriority As DevExpress.XtraGrid.Columns.TileViewColumn = New DevExpress.XtraGrid.Columns.TileViewColumn() With {.FieldName = "Priority", .Visible = True}
            Dim colDescription As DevExpress.XtraGrid.Columns.TileViewColumn = New DevExpress.XtraGrid.Columns.TileViewColumn() With {.FieldName = "Description", .Visible = True}
            Dim colStatus As DevExpress.XtraGrid.Columns.TileViewColumn = New DevExpress.XtraGrid.Columns.TileViewColumn() With {.FieldName = "Status", .Visible = True}
            colStatus.DisplayFormat.FormatString = "{0}%"
            colStatus.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            tileView.Columns.AddRange({colTask, colEmployee, colDueDate, colPriority, colDescription, colStatus})
            Dim elTask As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            elTask.Appearance.Normal.FontSizeDelta = 2
            elTask.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
            elTask.Appearance.Normal.Options.UseFont = True
            elTask.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            elTask.Column = colTask
            Dim elPriorityFlag As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            elPriorityFlag.Column = colPriority
            elPriorityFlag.ColumnIndex = 1
            elPriorityFlag.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
            elPriorityFlag.TextVisible = False
            Dim elDescription As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            elDescription.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            elDescription.Column = colDescription
            elDescription.MaxLineCount = 3
            elDescription.RowIndex = 1
            Dim elStatus As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            elStatus.Appearance.Normal.FontSizeDelta = 4
            elStatus.Column = colStatus
            elStatus.RowIndex = 2
            elStatus.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
            Dim elDueDateLabel As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            elDueDateLabel.RowIndex = 2
            elDueDateLabel.Text = "Due Date:"
            elDueDateLabel.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
            Dim elDueDate As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            elDueDate.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right
            elDueDate.AnchorElementIndex = 4
            elDueDate.AnchorIndent = 3
            elDueDate.Column = colDueDate
            elDueDate.RowIndex = 2
            Dim elEmployeeLabel As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            elEmployeeLabel.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Top
            elEmployeeLabel.AnchorElementIndex = 4
            elEmployeeLabel.AnchorIndent = 0
            elEmployeeLabel.RowIndex = 2
            elEmployeeLabel.Text = "Employee:"
            Dim elEmployee As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            elEmployee.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right
            elEmployee.AnchorElementIndex = 6
            elEmployee.AnchorIndent = 3
            elEmployee.Column = colEmployee
            elEmployee.RowIndex = 2
            elEmployee.Text = "colEmployee"
            tileView.TileTemplate.Add(elTask)
            tileView.TileTemplate.Add(elPriorityFlag)
            tileView.TileTemplate.Add(elDescription)
            tileView.TileTemplate.Add(elStatus)
            tileView.TileTemplate.Add(elDueDateLabel)
            tileView.TileTemplate.Add(elDueDate)
            tileView.TileTemplate.Add(elEmployeeLabel)
            tileView.TileTemplate.Add(elEmployee)
            Return New Object() {gridControl, gridView, tileView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Conditional formatting"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Apply conditional formatting"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        Public Sub AddColumnsManually(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal tileView As DevExpress.XtraGrid.Views.Tile.TileView)
            Dim colMark As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Mark")
            Dim markRule As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            markRule.Condition = DevExpress.XtraEditors.FormatCondition.Expression
            markRule.Expression = String.Format("[{0}] == false", "Mark")
            markRule.Appearance.BackColor = System.Drawing.Color.LightGreen
            gridView.FormatRules.Add(colMark, markRule)
            Dim colLength As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Length")
            Dim colName As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Name")
            Dim typeOfObjectRule As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim colorScaleRule As DevExpress.XtraEditors.FormatConditionRule2ColorScale = New DevExpress.XtraEditors.FormatConditionRule2ColorScale()
            typeOfObjectRule.Column = colLength
            typeOfObjectRule.ColumnApplyTo = colName
            colorScaleRule.PredefinedName = "White, Red"
            typeOfObjectRule.Rule = colorScaleRule
            gridView.FormatRules.Add(typeOfObjectRule)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Apply conditional formatting (TileView)")>
        Public Sub ConditionalFormattingTileView(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal tileView As DevExpress.XtraGrid.Views.Tile.TileView)
            gridControl.MainView = tileView
            gridControl.DataSource = DevExpress.Demos.TaskGenerator.[Default].GenerateSource(200)
            Dim flagsIconSet As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            flagsIconSet.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number
            flagsIconSet.Icons.Add(New DevExpress.XtraEditors.FormatConditionIconSetIcon() With {.PredefinedName = "Flags3_1.png", .Value = -1, .ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual})
            flagsIconSet.Icons.Add(New DevExpress.XtraEditors.FormatConditionIconSetIcon() With {.PredefinedName = "Flags3_2.png", .Value = 0, .ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual})
            flagsIconSet.Icons.Add(New DevExpress.XtraEditors.FormatConditionIconSetIcon() With {.PredefinedName = "Flags3_3.png", .Value = 1, .ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual})
            tileView.FormatRules.Add(tileView.Columns("Priority"), New DevExpress.XtraEditors.FormatConditionRuleIconSet() With {.IconSet = flagsIconSet})
            Dim overdueRowRule As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            overdueRowRule.Condition = DevExpress.XtraEditors.FormatCondition.Expression
            overdueRowRule.Expression = "[DueDate] < Today() And [Status] < 100"
            overdueRowRule.PredefinedName = "Red Fill"
            Dim columnDueDate As DevExpress.XtraGrid.Columns.TileViewColumn = TryCast(tileView.Columns("DueDate"), DevExpress.XtraGrid.Columns.TileViewColumn)
            Dim overdueRowFormatRule As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            overdueRowFormatRule.ApplyToRow = True
            overdueRowFormatRule.Column = columnDueDate
            overdueRowFormatRule.Rule = overdueRowRule
            tileView.FormatRules.Add(overdueRowFormatRule)
            Dim overdueTextRule As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            overdueTextRule.Assign(overdueRowRule)
            overdueTextRule.PredefinedName = "Red Bold Text"
            tileView.FormatRules.Add(columnDueDate, overdueTextRule)
            Dim completedRowRule As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            completedRowRule.Condition = DevExpress.XtraEditors.FormatCondition.Equal
            completedRowRule.Value1 = 100
            completedRowRule.PredefinedName = "Green Fill"
            Dim colStatus As DevExpress.XtraGrid.Columns.TileViewColumn = TryCast(tileView.Columns("Status"), DevExpress.XtraGrid.Columns.TileViewColumn)
            Dim completedRowFormatRule As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            completedRowFormatRule.Column = colStatus
            completedRowFormatRule.Rule = completedRowRule
            completedRowFormatRule.ApplyToRow = True
            tileView.FormatRules.Add(completedRowFormatRule)
            Dim completedTextRule As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            completedTextRule.Assign(completedRowRule)
            completedTextRule.PredefinedName = Nothing
            completedTextRule.Appearance.FontSizeDelta = 2
            completedTextRule.Appearance.FontStyleDelta = System.Drawing.FontStyle.Strikeout Or System.Drawing.FontStyle.Bold
            Dim colName As DevExpress.XtraGrid.Columns.TileViewColumn = TryCast(tileView.Columns("Name"), DevExpress.XtraGrid.Columns.TileViewColumn)
            Dim completedTextFormatRule As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            completedTextFormatRule.Column = colStatus
            completedTextFormatRule.ColumnApplyTo = colName
            completedTextFormatRule.Rule = completedTextRule
            tileView.FormatRules.Add(completedTextFormatRule)
        End Sub
#End Region
    End Module
End Namespace
