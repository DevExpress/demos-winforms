Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Demos.Modules.MailMergeDataSets
Imports DevExpress.XtraSpreadsheet.Demos.Modules.MailMergeDataSets.FallCatalogDataSetTableAdapters

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class MailMergeFallCatalogModule
        Inherits MailMergeModuleBase

        Protected Overrides Sub LoadTemplate(ByVal spreadsheetControl As SpreadsheetControl)
            spreadsheetControl.Document.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\FallCatalogTemplate.xlsx"))
        End Sub

        Protected Overrides Sub LoadData(ByVal book As IWorkbook)
            Dim dataSet As FallCatalogDataSet = New FallCatalogDataSet()
            Dim orderDetailsAdapter As Order_DetailsTableAdapter = New Order_DetailsTableAdapter()
            orderDetailsAdapter.Fill(dataSet.Order_Details)
            Dim productsAdapter As ProductsTableAdapter = New ProductsTableAdapter()
            productsAdapter.Fill(dataSet.Products)
            book.MailMergeDataSource = dataSet
            book.MailMergeDataMember = "Products"
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
