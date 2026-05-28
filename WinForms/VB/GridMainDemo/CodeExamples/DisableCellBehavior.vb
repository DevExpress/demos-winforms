Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils.Behaviors
Imports DevExpress.Utils.Behaviors.Common
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS
Imports System

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Disabled grid cell behavior", "DisableCellBehavior.cs")>
    Public Class DisabledGridCellsBehavior

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Dim behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager = New DevExpress.Utils.Behaviors.BehaviorManager()
            Dim spinEdit As DevExpress.XtraEditors.SpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Dim label As DevExpress.XtraEditors.LabelControl = New DevExpress.XtraEditors.LabelControl()
            label.Dock = System.Windows.Forms.DockStyle.Top
            label.Text = "Disable only rows where Length is greater than:"
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            label.Visible = False
            spinEdit.Visible = False
            spinEdit.Dock = System.Windows.Forms.DockStyle.Top
            gridControl.Tag = behaviorManager
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            gridView.PopulateColumns()
            gridControl.Parent = sampleHost
            spinEdit.Parent = sampleHost
            label.Parent = sampleHost
            Return New Object() {gridControl, gridView, spinEdit, label, behaviorManager}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim grid As DevExpress.XtraGrid.GridControl = TryCast(sampleHost.Controls(0), DevExpress.XtraGrid.GridControl)
            If grid IsNot Nothing Then
                Dim manager = TryCast(grid.Tag, DevExpress.Utils.Behaviors.BehaviorManager)
                grid.Dispose()
                If manager IsNot Nothing Then manager.Dispose()
            End If
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Disable cells that meet a custom condition"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Appearance", "ProcessingCell", "FieldName", "RecordId", "Disabled", "Source")>
        Public Shared Sub DisableCellsUsingACustomCondition(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal spinEdit As DevExpress.XtraEditors.SpinEdit, ByVal label As DevExpress.XtraEditors.LabelControl, ByVal behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager)
            behaviorManager.Attach(Of DevExpress.Utils.Behaviors.Common.DisabledCellBehavior)(gridView, Sub(behavior)
                'Uncomment this line to change the background color for disabled cells.
                'behavior.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
                behavior.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Strikeout
                AddHandler behavior.ProcessingCell, Sub(s, e)
                    If Not Equals(e.FieldName, "Name") Then
                        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(e.Source, DevExpress.XtraGrid.Views.Grid.GridView)
                        e.Disabled = CBool(view.GetListSourceRowCellValue(e.RecordId, "Mark"))
                    End If
                End Sub
            End Sub)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Disable cells in rows that meet the specified criterion"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Expression", "Appearance")>
        Public Shared Sub DisableCellsUsingAnExpression(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal spinEdit As DevExpress.XtraEditors.SpinEdit, ByVal label As DevExpress.XtraEditors.LabelControl, ByVal behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager)
            behaviorManager.Attach(Of DevExpress.Utils.Behaviors.Common.DisabledCellBehavior)(gridView, Sub(behavior)
                'Uncomment this line to change the background color for disabled cells.
                'behavior.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
                behavior.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Strikeout
                behavior.Properties.Expression = "[Mark] == true"
            End Sub)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Enable specific cells in disabled rows based on a custom condition"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Appearance", "Expression", "ProcessingCell", "FieldName", "RecordId", "Disabled", "Source")>
        Public Shared Sub OverrideExpressionResultUsingACustomCondition(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal spinEdit As DevExpress.XtraEditors.SpinEdit, ByVal label As DevExpress.XtraEditors.LabelControl, ByVal behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager)
            spinEdit.Visible = True
            spinEdit.EditValue = 30
            AddHandler spinEdit.EditValueChanged, Sub(o, e) gridView.LayoutChanged()
            label.Visible = True
            behaviorManager.Attach(Of DevExpress.Utils.Behaviors.Common.DisabledCellBehavior)(gridView, Sub(behavior)
                'Uncomment this line to change the background color for disabled cells.
                'behavior.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue;
                behavior.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Strikeout
                behavior.Properties.Expression = "Abs(DateDiffDay([RecordDate], Today())) > 3"
                AddHandler behavior.ProcessingCell, Sub(s, e)
                    'The Name column is never disabled.
                    If Equals(e.FieldName, "Name") Then
                        e.Disabled = False
                        Return
                    End If

                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(e.Source, DevExpress.XtraGrid.Views.Grid.GridView)
                    Dim length As Double = CDbl((view.GetListSourceRowCellValue(e.RecordId, "Length")))
                    Dim evaluationResult As Boolean = e.Disabled
                    e.Disabled = If(length > System.Convert.ToDouble(CDec(spinEdit.EditValue)), evaluationResult, False)
                End Sub
            End Sub)
        End Sub
    End Class
End Namespace
