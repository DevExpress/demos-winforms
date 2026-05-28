Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Unbound Columns", "UnboundColumns.cs")>
    Public Module UnboundColumns

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Unbound Columns"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Unbound editable column"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddField", "CustomUnboundColumnData", "UnboundDataType")>
        Public Sub CreatingUnboundColumnWithEditing(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Creating an unbound column that supports editing
            Dim unboundColumn As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns.AddField("CustomData")
            unboundColumn.UnboundDataType = GetType(String)
            unboundColumn.Visible = True
            ' Handling the CustomUnboundColumnData event
            Dim unboundData As System.Collections.Generic.Dictionary(Of Integer, String) = New System.Collections.Generic.Dictionary(Of Integer, String)()
            unboundData(5) = "Can live up to 20 years!"
            AddHandler gridView.CustomUnboundColumnData, Sub(sender, e)
                If Equals(e.Column.FieldName, "CustomData") Then
                    If e.IsGetData Then
                        Dim value As String = Nothing
                        If unboundData.TryGetValue(e.ListSourceRowIndex, value) Then e.Value = value
                    End If

                    If e.IsSetData AndAlso e.Value IsNot Nothing Then unboundData(e.ListSourceRowIndex) = e.Value.ToString()
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Provide data using an expression"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddField", "UnboundExpression")>
        Public Sub CreatingUnboundColumnByUsingUnboundExpression(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Creating an readonly unbound column by using an unbound expression
            Dim unboundColumn As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns.AddField("Unbound")
            unboundColumn.OptionsColumn.AllowEdit = False
            unboundColumn.UnboundDataType = GetType(Integer)
            unboundColumn.UnboundExpression = "Round([Length])"
            unboundColumn.Visible = True
        End Sub
#End Region
    End Module
End Namespace
