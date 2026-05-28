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
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraLayout
Imports DevExpress.VideoRent.Win.Modules
Imports DevExpress.VideoRent.Helpers

Namespace DevExpress.VideoRent.Win.ModulesStatistics
	Partial Public Class CustomerRevenueStatistics
		Inherits ChartExportTutorialControl
		Private currentMonth As Integer
		Private topCustomer As Customer

		Protected Friend Overrides ReadOnly Property UseList() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Friend Overrides ReadOnly Property ChartViewType() As ViewType
			Get
				Return ViewType.Line
			End Get
		End Property
		Protected Overrides ReadOnly Property MainChart() As ChartControl
			Get
				Return chart
			End Get
		End Property
		Public Overrides ReadOnly Property EditObjectName() As String
			Get
				Return ConstStrings.Customer
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
		Protected Overrides ReadOnly Property AllowFlipLayout() As Boolean
			Get
				Return True
			End Get
		End Property
		Public Sub New()
			InitializeComponent()
            AddHandler pivotGrid.LookAndFeel.StyleChanged, AddressOf AnonymousMethod1
		End Sub
		
		Private Sub AnonymousMethod1(ByVal sender As Object, ByVal e As System.EventArgs)
			pivotGrid.BestFit()
		End Sub
		Protected Overrides Sub InitData()
			MyBase.InitData()
			Me.currentMonth = DateTime.Now.Month
			Dim startDate As DateTime = DateTime.Now.AddYears(-1)
			Dim receipts As New XPCollection(Of Receipt)(Session, New BinaryOperator("Date", startDate, BinaryOperatorType.GreaterOrEqual))
			pivotGrid.DataSource = receipts
		End Sub
		Friend Overrides Sub RefreshData()
			Cursor.Current = Cursors.WaitCursor
			ApplyFilter()
		End Sub
		Protected Overrides Sub DoParentChanged()
			MyBase.DoParentChanged()
			AddHandler LayoutManager.CurrentCustomerChanged, AddressOf OnCurrentCustomerChanged
			ApplyFilter()
		End Sub

		Private Sub ApplyFilter()
			Me.topCustomer = Nothing
			Dim topCustomerRevenues As Decimal = 0
			For Each customer As Customer In fieldCustomer.GetUniqueValues()
				Dim customerRevenues As Decimal = Convert.ToDecimal(pivotGrid.GetCellValue(Nothing, New Object() { customer }, fieldRevenue))
				If customerRevenues > topCustomerRevenues Then
					topCustomer = customer
					topCustomerRevenues = customerRevenues
				End If
			Next customer
			Dim customersToShow As New List(Of Customer)()
			customersToShow.Add(Me.topCustomer)
			Dim currentCustomer As Customer = SessionHelper.GetObject(LayoutManager.CurrentCustomer, Session)
            If Not Me.topCustomer.Equals(currentCustomer) Then
                customersToShow.Add(currentCustomer)
            End If
			fieldCustomer.FilterValues.ValuesIncluded = customersToShow.ToArray()
			pivotGrid.BestFit()

			chart.Titles(0).Text = String.Format("{0} {1}", LayoutManager.CurrentCustomer.FullName, ConstStrings.Revenue12Months)
			ucCustomerInfo1.Init(LayoutManager.CurrentCustomer, ConstStrings.FindCustomerHint, ConstStrings.CustomerDetailTooltip)
		End Sub

		Private Sub OnCurrentCustomerChanged(ByVal sender As Object, ByVal e As EventArgs)
			ApplyFilter()
		End Sub

		Private Sub pivotGrid_CustomFieldSort(ByVal sender As Object, ByVal e As PivotGridCustomFieldSortEventArgs) Handles pivotGrid.CustomFieldSort
            If Object.Equals(e.Field, fieldCustomer) Then
                Dim value1 As Integer
                If Object.Equals(e.Value1, Me.topCustomer) Then
                    value1 = 1
                Else
                    value1 = 0
                End If
                Dim value2 As Integer
                If Object.Equals(e.Value2, Me.topCustomer) Then
                    value2 = 1
                Else
                    value2 = 0
                End If
                Dim res As Integer = Comparer(Of Integer).Default.Compare(value1, value2)
                If res <> 0 Then
                    e.Result = res
                    e.Handled = True
                End If
            End If
		End Sub

		Private Sub pivotGrid_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs) Handles pivotGrid.FieldValueDisplayText
            If Object.Equals(e.Field, fieldCustomer) Then
                Dim valueAsCustomer As Customer = CType(e.Value, Customer)
                If (Not Object.Equals(valueAsCustomer, Nothing)) Then
                    e.DisplayText = valueAsCustomer.FullName
                Else
                    e.DisplayText = ConstStrings.NullString
                End If

                If Object.Equals(valueAsCustomer, Me.topCustomer) Then
                    e.DisplayText = String.Format("{0} - {1}", e.DisplayText, ConstStrings.TopCustomer)
                End If
            End If
            If Object.Equals(e.Field, fieldMonth) Then
                Dim valueAsDate As DateTime = CDate(e.Value)
                e.DisplayText = valueAsDate.ToString("MMM yyyy")
            End If
			If Object.Equals(e.Field, Nothing) AndAlso (Not e.IsColumn) Then
				e.DisplayText = ConstStrings.RevenueDifference
			End If
		End Sub

		Private Sub pivotGrid_CustomGroupInterval(ByVal sender As Object, ByVal e As PivotCustomGroupIntervalEventArgs) Handles pivotGrid.CustomGroupInterval
            If Object.Equals(e.Field, fieldMonth) Then
                Dim valueAsDate As DateTime = CDate(e.Value)
                e.GroupValue = New DateTime(valueAsDate.Year, valueAsDate.Month, 1)
            End If
		End Sub

		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			Dim compareSeries As Series = GetTopCustomerSeries()
			If (Not Object.Equals(compareSeries, Nothing)) Then
				Dim view As LineSeriesView = CType(compareSeries.View, LineSeriesView)
				view.LineStyle.DashStyle = DashStyle.Dash
				view.LineMarkerOptions.FillStyle.FillMode = FillMode.Solid
			End If
		End Sub

		Private Function GetTopCustomerSeries() As Series
			If Object.Equals(topCustomer, Nothing) Then
				Return Nothing
			End If
			For Each series As Series In chart.Series
				If series.Name.Contains(topCustomer.FullName) Then
					Return series
				End If
			Next series
			Return Nothing
		End Function

		Private Sub pivotGrid_CustomSummary(ByVal sender As Object, ByVal e As PivotGridCustomSummaryEventArgs) Handles pivotGrid.CustomSummary
			If e.DataField Is fieldRevenue Then
				If Object.Equals(e.RowField, Nothing) Then
					Dim currentSum As Decimal = 0, topSum As Decimal = 0
					Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
					For i As Integer = 0 To ds.RowCount - 1
						Dim val As Decimal = Convert.ToDecimal(ds(i)(fieldRevenue))
                        If Object.ReferenceEquals(ds(i)(fieldCustomer), Me.topCustomer) Then
                            topSum += val
                        Else
                            currentSum += val
                        End If
					Next i
					e.CustomValue = currentSum - topSum
				Else
					e.CustomValue = e.SummaryValue.Summary
				End If
			End If
		End Sub

		Private Sub pivotGrid_CustomDrawCell(ByVal sender As Object, ByVal e As PivotCustomDrawCellEventArgs) Handles pivotGrid.CustomDrawCell
			If Object.Equals(e.RowField, Nothing) Then
				Dim value As Decimal = Convert.ToDecimal(e.Value)
				If value > 0 Then
					e.Appearance.ForeColor = Color.Green
				ElseIf value < 0 Then
					e.Appearance.ForeColor = Color.Red
				End If
			End If
		End Sub

		Private Sub ucCustomerInfo1_DoEdit(ByVal sender As Object, ByVal e As EventArgs) Handles ucCustomerInfo1.DoEdit
			Cursor.Current = Cursors.WaitCursor
			If (Not IsDetailExist(LayoutManager.CurrentCustomer.Oid)) Then
                ShowModuleDialog(New CustomerDetail(Me.FindForm(), Session, LayoutManager.CurrentCustomer, MenuManager, AddressOf CloseDetailForm), True)
			End If
			Cursor.Current = Cursors.Default
		End Sub
		Protected Friend Overrides Sub Prev()
			LayoutManager.PrevCustomer()
			UpdateNavigationButtons()
		End Sub
		Protected Friend Overrides Sub [Next]()
			LayoutManager.NextCustomer()
			UpdateNavigationButtons()
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			UpdateNavigationButtons()
		End Sub
		Private Sub UpdateNavigationButtons()
			If Object.Equals(ParentFormMain, Nothing) OrElse Object.Equals(LayoutManager, Nothing) Then
				Return
			End If
			ParentFormMain.PrevButton.Enabled = LayoutManager.AllowPrevCustomer
			ParentFormMain.NextButton.Enabled = LayoutManager.AllowNextCustomer
		End Sub
	End Class
End Namespace
