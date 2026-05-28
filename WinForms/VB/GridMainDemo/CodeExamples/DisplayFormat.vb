Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Display format", "DisplayFormat.cs")>
    Public Module DisplayFormat

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(6)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Display format"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Specify column cell display format"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DisplayFormat", "FormatType", "FormatString")>
        Public Sub ColumnDisplayFormat(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("RecordDate"))).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            gridView.Columns(CStr(("RecordDate"))).DisplayFormat.FormatString = "D"
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize cell display text"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomColumnDisplayText", "DisplayText")>
        Public Sub CustomCellDisplayText(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Custom Cell Display Text            
            AddHandler gridView.CustomColumnDisplayText, Sub(sender, e)
                If Equals(e.Column.FieldName, "Length") Then
                    Dim val As Double = CDbl(e.Value)
                    If val > 20 Then e.DisplayText = String.Empty
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize Filter Panel’s text"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomFilterDisplayText", "Value")>
        Public Sub CustomFilterDisplayText(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.ActiveFilterString = String.Format("[{0}] = 2 Or [{0}] >= 4", "ID")
            ' Handle the event to customize the display text representing the current filter within the filter panel.
            AddHandler gridView.CustomFilterDisplayText, Sub(sender, e)
                Dim go As DevExpress.Data.Filtering.GroupOperator = TryCast(e.Value, DevExpress.Data.Filtering.GroupOperator)
                Dim displayText As String = String.Empty
                If DevExpress.Data.Filtering.CriteriaOperator.Equals(go, Nothing) Then
                    Dim bo As DevExpress.Data.Filtering.BinaryOperator = TryCast(e.Value, DevExpress.Data.Filtering.BinaryOperator)
                    If Not DevExpress.Data.Filtering.CriteriaOperator.Equals(bo, Nothing) Then
                        Dim op As DevExpress.Data.Filtering.OperandProperty = TryCast(bo.LeftOperand, DevExpress.Data.Filtering.OperandProperty)
                        Dim ov As DevExpress.Data.Filtering.OperandValue = TryCast(bo.RightOperand, DevExpress.Data.Filtering.OperandValue)
                        displayText = String.Format("{0} {1} {2}", op.PropertyName, bo.OperatorType, ov.Value)
                    End If
                Else
                    For Each bo As DevExpress.Data.Filtering.BinaryOperator In go.Operands
                        Dim op As DevExpress.Data.Filtering.OperandProperty = TryCast(bo.LeftOperand, DevExpress.Data.Filtering.OperandProperty)
                        Dim ov As DevExpress.Data.Filtering.OperandValue = TryCast(bo.RightOperand, DevExpress.Data.Filtering.OperandValue)
                        displayText += String.Format("{0} {1} {2} ; ", op.PropertyName, bo.OperatorType, ov.Value)
                    Next
                End If

                If Not Equals(displayText, String.Empty) Then
                    'To specify the filter display text, assign the required string
                    '  (or any object whose ToString() method returns the required string)
                    '   to the Value parameter and set the Handled parameter to true.
                    e.Handled = True
                    e.Value = displayText
                End If
            End Sub
        End Sub
#End Region
    End Module
End Namespace
