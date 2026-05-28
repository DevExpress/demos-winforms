Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class CustomCellValue
        Inherits TutorialControl

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
        End Sub

        Private Sub CustomCellValue_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.DataSource = GetNWindData("CustomerReports")
        End Sub

        '<pivotGridControl1>
        Private Sub pivotGridControl1_CustomCellValue(ByVal sender As Object, ByVal e As PivotCellValueEventArgs)
            If e.RowValueType = PivotGridValueType.Total Then
                e.Value = Nothing
                Dim index As Integer = e.RowIndex - 1
                While index >= 0 AndAlso e.Value Is Nothing
                    If Not Equals(pivotGridControl1.GetFieldValueType(False, index), PivotGridValueType.Value) Then Exit While
                    e.Value = e.GetCellValue(e.ColumnIndex, index)
                    index -= 1
                End While
            End If
        End Sub

        Private Sub pivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
            If e.Field Is fieldOrderYear AndAlso e.ValueType = PivotGridValueType.Total Then
                e.DisplayText = "Last Quarter Amount"
            End If
        End Sub
    '</pivotGridControl1>
    End Class
End Namespace
