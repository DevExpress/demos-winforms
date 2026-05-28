Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Unbound Columns", "UnboundColumns.cs")>
    Public Module UnboundColumns

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim vGridControl As DevExpress.XtraVerticalGrid.VGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
            vGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            vGridControl.Parent = sampleHost
            vGridControl.RowHeaderWidth = DevExpress.Utils.ScaleUtils.ScaleValue(120)
            vGridControl.RecordWidth = DevExpress.Utils.ScaleUtils.ScaleValue(140)
            vGridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            Return New Object() {vGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraVerticalGrid.VGridControl).Dispose()
        End Sub

#Region "Unbound Columns"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Unbound editable column"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddField", "CustomUnboundColumnData", "UnboundDataType")>
        Public Sub CreatingUnboundColumnWithEditing(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' Creating an unbound column that supports editing
            vGridControl.Rows.Add(New DevExpress.XtraVerticalGrid.Rows.EditorRow("CustomData"))
            Dim unboundRowProps = vGridControl.Rows(CStr(("CustomData"))).Properties
            unboundRowProps.Caption = "CustomData"
            unboundRowProps.UnboundDataType = GetType(String)
            ' Handling the CustomUnboundColumnData event
            Dim unboundData As System.Collections.Generic.Dictionary(Of Integer, String) = New System.Collections.Generic.Dictionary(Of Integer, String)()
            unboundData(1) = "Can live up to 20 years!"
            AddHandler vGridControl.CustomUnboundData, Sub(sender, e)
                If Equals(e.RowProperties.FieldName, "CustomData") Then
                    If e.IsGetData Then
                        Dim data As String = Nothing
                        If unboundData.TryGetValue(e.ListSourceRowIndex, data) Then e.Value = data
                    End If

                    If e.IsSetData AndAlso e.Value IsNot Nothing Then unboundData(e.ListSourceRowIndex) = e.Value.ToString()
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Provide data using an expression"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddField", "UnboundExpression")>
        Public Sub CreatingUnboundColumnByUsingUnboundExpression(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' Creating an readonly unbound column by using an unbound expression
            vGridControl.Rows.Add(New DevExpress.XtraVerticalGrid.Rows.EditorRow("Unbound"))
            Dim unboundRowProps = vGridControl.Rows(CStr(("Unbound"))).Properties
            unboundRowProps.AllowEdit = False
            unboundRowProps.UnboundDataType = GetType(Integer)
            unboundRowProps.UnboundExpression = "Round([Length])"
        End Sub
#End Region
    End Module
End Namespace
