Imports DevExpress.Internal
Imports DevExpress.XtraEditors

Namespace DevExpress.ProductsDemo.Win.Modules
    Partial Public Class PdfViewerModule
        Inherits BaseModule
        Private Const fileName As String = "Demo.pdf"
        Protected Overrides Property AutoMergeRibbon() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.AutoMergeRibbon = value
            End Set
        End Property
        Public Sub New()
            InitializeComponent()
            pdfViewer.DocumentCreator = "PDF Viewer Demo"
            pdfViewer.DocumentProducer = "Developer Express Inc., " & AssemblyInfo.Version
            pdfViewer.CreateRibbon()
        End Sub
        Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
            MyBase.ShowModule(firstShow)
            If firstShow Then
                Dim path As String = DataDirectoryHelper.GetDataFile(fileName)
                If Not String.IsNullOrEmpty(path) Then
                    Try
                        pdfViewer.LoadDocument(path)
                    Catch
                        XtraMessageBox.Show("The demo data has been corrupted.", "Error")
                    End Try
                End If
            End If
            MainRibbon.SelectedPage = MainRibbon.MergedPages(0)
        End Sub
        Friend Overrides Sub HideModule()
            MyBase.HideModule()
            If pdfViewer IsNot Nothing Then
                pdfViewer.HideFindDialog(True)
            End If
        End Sub
    End Class
End Namespace
