Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Data.Filtering
Imports System.Globalization

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class Filtering
        Inherits TutorialControl

        Private initialized As Boolean

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            initialized = True
            ApplyFilter()
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        '<dateEdit1>
        '<dateEdit2>
        Private Sub dateEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If initialized Then ApplyFilter()
        End Sub

        Private Sub ApplyFilter()
            Dim str1 As String = GetCriteria(dateEdit1.DateTime, True), str2 As String = GetCriteria(dateEdit2.DateTime, False)
            If Not String.IsNullOrEmpty(str1) AndAlso Not String.IsNullOrEmpty(str2) Then
                pivotGridControl1.ActiveFilterCriteria = CriteriaOperator.Parse(str1 & " And " & str2)
            Else
                pivotGridControl1.ActiveFilterCriteria = CriteriaOperator.Parse(str1 & str2)
            End If
        End Sub

        Private Function GetCriteria(ByVal [date] As Date, ByVal isGreater As Boolean) As String
            If [date].Ticks = 0 Then Return ""
            Return String.Format("{0} {1} #{2}#", fieldOrderDate.FilterColumnName, If(isGreater, ">=", "<="), Convert.ToString([date], CultureInfo.InvariantCulture))
        End Function
    '</dateEdit2>
    '</dateEdit1>
    End Class
End Namespace
