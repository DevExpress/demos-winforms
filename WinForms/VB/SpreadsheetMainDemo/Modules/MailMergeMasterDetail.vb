Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Demos.Modules.MailMergeDataSets
Imports DevExpress.XtraSpreadsheet.Demos.Modules.MailMergeDataSets.MasterDetailDataSetTableAdapters

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class MailMergeMasterDetailModule
        Inherits MailMergeModuleBase

        Protected Overrides Sub LoadTemplate(ByVal spreadsheetControl As SpreadsheetControl)
            spreadsheetControl.Document.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\MasterDetailTemplate.xlsx"))
        End Sub

        Protected Overrides Sub LoadData(ByVal book As IWorkbook)
            Dim dataSet As MasterDetailDataSet = New MasterDetailDataSet()
            Dim adapter As SuppliersTableAdapter = New SuppliersTableAdapter()
            adapter.Fill(dataSet.Suppliers)
            Dim orderDetailsAdapter As OrderDetailsTableAdapter = New OrderDetailsTableAdapter()
            orderDetailsAdapter.Fill(dataSet.OrderDetails)
            Dim productsAdapter As ProductsTableAdapter = New ProductsTableAdapter()
            productsAdapter.Fill(dataSet.Products)
            book.MailMergeDataSource = dataSet
            book.MailMergeDataMember = "Suppliers"
        End Sub

        Protected Overrides ReadOnly Property ShowHideCommentsItem As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property ShowFilterPanel As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
