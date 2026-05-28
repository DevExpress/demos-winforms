Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Globalization
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraCharts
Imports DevExpress.XtraLayout

Namespace DevExpress.VideoRent.Win.ModulesStatistics
	Partial Public Class RevenueSplitStatistics
		Inherits ChartExportTutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private receipts As XPCollection(Of Receipt)
		Protected Overrides ReadOnly Property MainChart() As ChartControl
			Get
				Return chart
			End Get
		End Property
		Protected Overrides ReadOnly Property MainLayoutControl() As LayoutControl
			Get
				Return layoutControl1
			End Get
		End Property
		Protected Overrides ReadOnly Property ShouldTransponsePivotOnPrint() As Boolean
			Get
				Return True
			End Get
		End Property
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			receipts.Reload()
		End Sub
		Protected Overrides Sub InitData()
			MyBase.InitData()
			receipts = New XPCollection(Of Receipt)(Session, New BinaryOperator("Date", DateHelper.GetStartDateForMonths(-11), BinaryOperatorType.GreaterOrEqual))
			pivotGrid.DataSource = receipts
		End Sub

		Private Sub pivotGrid_CustomGroupInterval(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomGroupIntervalEventArgs) Handles pivotGrid.CustomGroupInterval
            If Object.Equals(e.Field, fieldMonth) AndAlso ((Not Object.Equals(e.Value, Nothing))) Then
                Dim valueAsDate As DateTime = CDate(e.Value)
                e.GroupValue = New DateTime(valueAsDate.Year, valueAsDate.Month, 1)
            End If
        End Sub

        Private Sub pivotGrid_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles pivotGrid.FieldValueDisplayText
            If Object.Equals(e.Field, fieldMonth) AndAlso ((Not Object.Equals(e.Value, Nothing))) Then
                Dim valueAsDate As DateTime = CDate(e.Value)
                e.DisplayText = valueAsDate.ToString("MMM yyyy")
            End If
            If Object.Equals(e.Field, fieldReceiptType) Then
                Dim valueAsReceiptType As ReceiptType = CType(e.Value, ReceiptType)
                e.DisplayText = EditorHelper.GetReceiptTypeString(valueAsReceiptType)
            End If
        End Sub
	End Class
End Namespace
