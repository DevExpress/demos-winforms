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
Imports System.Collections
Imports DevExpress.XtraEditors
Imports DevExpress.VideoRent.Win.Controls
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports DevExpress.XtraLayout

Namespace DevExpress.VideoRent.Win.ModulesStatistics
	Partial Public Class TopCustomersStatistics
		Inherits ChartExportTutorialControl
		Private receipts As XPCollection(Of Receipt)
		Private tooltip As CustomerToolTipController

		Protected Friend Overrides ReadOnly Property ChartViewType() As ViewType
			Get
				Return ViewType.Pie3D
			End Get
		End Property
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
		Protected Overrides ReadOnly Property AllowFlipLayout() As Boolean
			Get
				Return True
			End Get
		End Property
		Public Sub New()
			InitializeComponent()
			Me.tooltip = New CustomerToolTipController(pivotGrid)
            AddHandler pivotGrid.LookAndFeel.StyleChanged, AddressOf AnonymousMethod1
			UpdateTopValues()
		End Sub
		
        Private Sub AnonymousMethod1(ByVal sender As Object, ByVal e As EventArgs)
            pivotGrid.BestFit()
        End Sub
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			Me.receipts.Reload()
		End Sub
		Protected Overrides Sub InitData()
			MyBase.InitData()
			Me.receipts = New XPCollection(Of Receipt)(Session)
			UpdatePeriod()
			pivotGrid.DataSource = receipts
			pivotGrid.BestFit()
		End Sub

		Private Sub pivotGrid_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles pivotGrid.FieldValueDisplayText
            If Object.Equals(e.Field, fieldCustomer) Then
                Dim valueAsCustomer As Customer = CType(e.Value, Customer)
                If (Not Object.Equals(valueAsCustomer, Nothing)) Then
                    e.DisplayText = valueAsCustomer.FullName
                Else
                    e.DisplayText = ConstStrings.NullString
                End If
            End If
		End Sub

		Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboPeriod.SelectedIndexChanged
			UpdatePeriod()
		End Sub

		Private Sub UpdatePeriod()
			Select Case comboPeriod.SelectedIndex
				Case 0
					Me.receipts.Filter = New GroupOperator(GroupOperatorType.And, New BinaryOperator(New FunctionOperator(FunctionOperatorType.GetYear, New OperandProperty("Date")), DateTime.Now.Year, BinaryOperatorType.Equal), New BinaryOperator(New FunctionOperator(FunctionOperatorType.GetMonth, New OperandProperty("Date")), DateTime.Now.Month, BinaryOperatorType.Equal))
				Case 1
					Dim dt As DateTime = DateHelper.GetStartDateForMonths(-1)
					Me.receipts.Filter = New GroupOperator(GroupOperatorType.And, New BinaryOperator(New FunctionOperator(FunctionOperatorType.GetYear, New OperandProperty("Date")), dt.Year, BinaryOperatorType.Equal), New BinaryOperator(New FunctionOperator(FunctionOperatorType.GetMonth, New OperandProperty("Date")), dt.Month, BinaryOperatorType.Equal))
				Case 2
					Me.receipts.Filter = New BinaryOperator("Date", DateTime.Now.AddYears(-1), BinaryOperatorType.GreaterOrEqual)
			End Select
			pivotGrid.RefreshData()
		End Sub

		Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinCustomerCount.EditValueChanged
			UpdateTopValues()
		End Sub
		Private Sub UpdateTopValues()
			fieldCustomer.TopValueCount = Convert.ToInt32(spinCustomerCount.EditValue)
		End Sub
		Private Sub pivotGrid_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pivotGrid.MouseMove
			Dim hitInfo As PivotGridHitInfo = pivotGrid.CalcHitInfo(e.Location)
			If MustShowCustomerTooltip(hitInfo) Then
				Dim customer As Customer = CType(hitInfo.ValueInfo.Value, Customer)
				Dim pt As Point = e.Location
				pt.Offset(20, 20)
				Me.tooltip.ShowHint(customer, pt)
			Else
				Me.tooltip.HideHint(True)
			End If
		End Sub
		Private Sub pivotGrid_FieldTooltipShowing(ByVal sender As Object, ByVal e As PivotFieldTooltipShowingEventArgs) Handles pivotGrid.FieldTooltipShowing
			 Dim hitInfo As PivotGridHitInfo = e.HitInfo
			 If MustShowCustomerTooltip(hitInfo) Then
				 e.ShowTooltip = False
			 End If
		End Sub
		Private Function MustShowCustomerTooltip(ByVal hitInfo As PivotGridHitInfo) As Boolean
            Return Object.Equals(hitInfo.HitTest, PivotGridHitTest.Value) AndAlso Object.Equals(hitInfo.ValueInfo.Field, fieldCustomer)
		End Function
	End Class
End Namespace
