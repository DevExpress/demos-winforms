Imports DevExpress.Internal
Imports DevExpress.XtraPrinting

Namespace DevExpress.ProductsDemo.Win.Modules
    Partial Public Class SpreadsheetModule
        Inherits BaseModule
        Private Const FileName As String = "LoanCalculator.xlsx"
        Public Sub New()
            InitializeComponent()
            Dim filePath As String = DataDirectoryHelper.GetDataFile(FileName)
            If String.IsNullOrEmpty(filePath) Then
                Return
            End If
            Me.spreadsheetControl1.LoadDocument(filePath)
        End Sub
        Protected Overrides Property AutoMergeRibbon() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.AutoMergeRibbon = value
            End Set
        End Property
        Public Overrides ReadOnly Property PrintableComponent() As IPrintable
            Get
                Return spreadsheetControl1
            End Get
        End Property
        Public Overrides ReadOnly Property ExportComponent() As IPrintable
            Get
                Return spreadsheetControl1
            End Get
        End Property
        Public Overrides ReadOnly Property AllowRtfTitle() As Boolean
            Get
                Return False
            End Get
        End Property
        Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
            MyBase.ShowModule(firstShow)
            MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByName(homeRibbonPage1.Name)
        End Sub
    End Class
End Namespace
