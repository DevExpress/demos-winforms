Imports System
Imports System.Drawing
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.Data
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Menu

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for CustomDataSummaries.
    ''' </summary>
    Public Partial Class CustomDataSummaries
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            InitNWindData()
            gridControl2.RefreshDataSource()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        '<gridControl2>
        ' 
        ' ~Note: the following code is generated at design time and listed here only for demonstration purposes.
        ' ~Create two group summaries (Custom and Count):
        ' gridView2.GroupSummary.AddRange(new GridSummaryItem[] {
        ' new GridGroupSummaryItem(SummaryItemType.Custom, "Freight", null, "(Order Count [WHERE Freight &gt;= 100 = {0}])"),
        ' new GridGroupSummaryItem(SummaryItemType.Count, "OrderID", null, "(Total Order Count = {0})")});
        ' 
        ' ~Create a Custom total summary:
        ' colFreight.Summary.AddRange(new GridSummaryItem[] {
        ' new GridColumnSummaryItem(SummaryItemType.Custom, "Freight", "Custom SUM={0:c}")});
        ' 
        '</gridControl2>
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"CustomDataSummaries"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "CustomDataSummaries"
            End Get
        End Property

        Private totalCount As Integer

        Private totalSum As Decimal

        Private footerApp As AppearanceDefault = New AppearanceDefault(Color.Red, Color.Empty, New Font(AppearanceObject.DefaultFont, FontStyle.Bold))

#Region "Init"
        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return gridView2
            End Get
        End Property

        Private ReadOnly Property CustomGridView As GridView
            Get
                Return gridView2
            End Get
        End Property

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Dim ds As DataSet = New DataSet()
            SetWaitDialogCaption(Properties.Resources.LoadingTables)
            ds.ReadXml(dataFileName)
            gridControl2.DataSource = ds.Tables("Orders")
            repositoryItemLookUpEdit2.DataSource = ds.Tables("Customers")
            repositoryItemLookUpEdit3.DisplayMember = "Name"
            repositoryItemLookUpEdit3.DataSource = ds.Tables("Employees")
            Return ds
        End Function

        Private Sub CustomDataSummaries_Load(ByVal sender As Object, ByVal e As EventArgs)
            UpdateCaptions(numCustom.Value)
        End Sub

#End Region
#Region "Custom summaries"
        '<gridControl2>
        Private Sub InitStartValue()
            totalCount = 0
            totalSum = 0
        End Sub

        Private Sub gridView2_CustomSummaryCalculate(ByVal sender As Object, ByVal e As CustomSummaryEventArgs)
            If e.SummaryProcess = CustomSummaryProcess.Start Then
                InitStartValue()
            End If

            If e.SummaryProcess = CustomSummaryProcess.Calculate Then
                If e.FieldValue IsNot Nothing AndAlso e.FieldValue IsNot DBNull.Value Then
                    If CDec(e.FieldValue) >= numCustom.Value Then
                        If e.IsGroupSummary Then totalCount += 1
                        If e.IsTotalSummary Then totalSum += CDec(e.FieldValue)
                    End If
                End If

                If e.IsGroupSummary Then e.TotalValue = totalCount
                If e.IsTotalSummary Then e.TotalValue = totalSum
            End If
        End Sub

        '</gridControl2>
        '<numCustom>
        Private Sub numCustom_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            CustomGridView.UpdateSummary()
            '<skip>
            UpdateCaptions(numCustom.Value)
        '</skip>
        End Sub

        '</numCustom>
        Private Sub UpdateCaptions(ByVal d As Decimal)
            CustomGridView.GroupSummary(0).DisplayFormat = String.Format(Properties.Resources.CustomOrderCountCaption, d) & " = {0})"
            gridView2.FormatConditions(0).Value1 = d
        End Sub

#End Region
#Region "Custom summaries appearance"
        Private Sub gridView2_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            Dim menu As GridViewFooterMenu = TryCast(e.Menu, GridViewFooterMenu)
            If menu IsNot Nothing AndAlso menu.Column IsNot Nothing Then
                If Equals(menu.Column.FieldName, "Freight") Then
                    For Each item As DXMenuItem In menu.Items
                        item.Enabled = False
                    Next
                End If
            End If
        End Sub

        Private Sub gridView2_CustomDrawFooterCell(ByVal sender As Object, ByVal e As FooterCellCustomDrawEventArgs)
            If Equals(e.Column.FieldName, "Freight") Then AppearanceHelper.Apply(e.Appearance, footerApp)
        End Sub

#End Region
#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace
