Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.CustomEditor
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class ChartEditor
        Inherits TutorialControl

        Private queryName As String = "SalesByCategory"

        Private ds As DataSet = New DataSet()

        Private ReadOnly Property CurrentGrid As GridControl
            Get
                Return gridControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitNWindData()
            Dim photoEditor As RepositoryItemPictureEdit = New RepositoryItemPictureEdit()
            photoEditor.Caption.Appearance.BackColor = Color.FromArgb(200, Color.White)
            photoEditor.Caption.Appearance.ForeColor = Color.FromArgb(40, 40, 40)
            photoEditor.Caption.Text = "{FirstName} <b>{LastName}</b>"
            gridControl1.RepositoryItems.Add(photoEditor)
            colPhoto.ColumnEdit = photoEditor
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"AnyChartEditor"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ChartEditor"
            End Get
        End Property

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            SetWaitDialogCaption(Properties.Resources.LoadingEmployees)
            ds.ReadXml(dataFileName)
            CurrentGrid.DataSource = ds
            CurrentGrid.DataMember = "Employees"
            Return ds
        End Function

        Private ReadOnly Property ChartSeries As SeriesBase
            Get
                Return chartControl1.Series(0)
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitChartTypeEdit()
            ChartSeries.ArgumentDataMember = "CategoryName"
            ChartSeries.ValueDataMembers.AddRange("Quantity")
            '<gridControl1>
            CreateChartEdit(colChart, chartControl1)
        '</gridControl1>
        End Sub

        '<icbChartType>
        Private Sub InitChartTypeEdit()
            icbChartType.Properties.Items.Add(New RadioGroupItem(GetType(PieSeriesView), "Pie"))
            icbChartType.Properties.Items.Add(New RadioGroupItem(GetType(DoughnutSeriesView), "Doughnut"))
            icbChartType.Properties.Items.Add(New RadioGroupItem(GetType(StackedBarSeriesView), "Bar"))
            icbChartType.Properties.Items.Add(New RadioGroupItem(GetType(LineSeriesView), "Line"))
            icbChartType.Properties.Items.Add(New RadioGroupItem(GetType(FunnelSeriesView), "Funnel"))
            icbChartType.Properties.Items.Add(New RadioGroupItem(GetType(StackedAreaSeriesView), "Area"))
            icbChartType.Properties.Items.Add(New RadioGroupItem(GetType(StackedSplineAreaSeriesView), "Spline Area"))
            icbChartType.EditValue = ChartSeries.View.GetType()
        End Sub

        '</icbChartType>
        '<gridControl1>
        Private Shared Sub CreateChartEdit(ByVal column As GridColumn, ByVal chartControl As ChartControl)
            If column.ColumnEdit IsNot Nothing Then Return
            Dim item As RepositoryItemAnyControl = New RepositoryItemAnyControl()
            item.Control = chartControl
            column.View.GridControl.RepositoryItems.Add(item)
            CType(column.View, GridView).OptionsSelection.EnableAppearanceHideSelection = False
            column.OptionsColumn.AllowEdit = False
            column.OptionsFilter.AllowFilter = False
            column.OptionsColumn.AllowGroup = Utils.DefaultBoolean.False
            column.OptionsColumn.AllowSort = Utils.DefaultBoolean.False
            column.ColumnEdit = item
        End Sub

        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDataEventArgs)
            If e.IsGetData Then e.Value = GetChartData(e.Row)
        End Sub

        Private chartData As Dictionary(Of Integer, List(Of EmployeeSalesByCategoryChartData)) = New Dictionary(Of Integer, List(Of EmployeeSalesByCategoryChartData))()

        Private Function GetChartData(ByVal val As Object) As Object
            Dim row As DataRowView = TryCast(val, DataRowView)
            If row Is Nothing Then Return Nothing
            Dim key As Integer = CInt(row("EmployeeID"))
            If Not chartData.ContainsKey(key) Then chartData.Add(key, GetEmployeeSalesByCategoryChartData(key))
            Return chartData(key)
        End Function

        Private Function GetEmployeeSalesByCategoryChartData(ByVal key As Integer) As List(Of EmployeeSalesByCategoryChartData)
            Dim ret As List(Of EmployeeSalesByCategoryChartData) = New List(Of EmployeeSalesByCategoryChartData)()
            For Each row As DataRow In ds.Tables(queryName).Rows
                If key.Equals(row("EmployeeID")) Then ret.Add(New EmployeeSalesByCategoryChartData() With {.CategoryName = row("CategoryName").ToString(), .Quantity = CDbl(row("SumOfQuantity"))})
            Next

            Return ret
        End Function

        '</gridControl1>
        '<icbChartType>
        Private Sub icbChartType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim viewType As Type = TryCast(icbChartType.EditValue, Type)
            'ChartSeries.View.Dispose();
            ChartSeries.View = TryCast(Activator.CreateInstance(viewType), SeriesViewBase)
            Dim edit As RepositoryItemAnyControl = TryCast(colChart.ColumnEdit, RepositoryItemAnyControl)
            If edit IsNot Nothing Then edit.RefreshControl()
        End Sub

        '</icbChartType>
        '<gridControl1>
        Public Class EmployeeSalesByCategoryChartData

            Public Property CategoryName As String

            Public Property Quantity As Double
        End Class

        '</gridControl1>
        Private Sub advBandedGridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDisplayTextEventArgs)
            If e.Column Is colHireDate OrElse e.Column Is colHomePhone Then e.DisplayText = String.Format("{0}: {1:d}", e.Column.GetCaption(), e.Value)
        End Sub

        Private Sub advBandedGridView1_CustomDrawCell(ByVal sender As Object, ByVal e As Views.Base.RowCellCustomDrawEventArgs)
            If e.Column Is colPhoto Then
                Dim cell = TryCast(e.Cell, ViewInfo.GridCellInfo)
                Dim pic As PictureEditViewInfo = TryCast(cell.ViewInfo, PictureEditViewInfo)
            'if(pic != null) pic.CaptionText = advBandedGridView1.GetRowCellDisplayText(e.RowHandle, colFirstName) + "  " + advBandedGridView1.GetRowCellDisplayText(e.RowHandle, colLastName);
            End If
        End Sub
    End Class
End Namespace
