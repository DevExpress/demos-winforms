Imports DevExpress.DevAV.Reports
Imports DevExpress.Mvvm
Imports System.ComponentModel
Imports System.IO

Namespace DevExpress.DevAV.ViewModels

    Public Class OrderQuickReportsViewModel
        Implements IDocumentContent, ISupportParameter

        Private _DocumentOwnerProp As IDocumentOwner

        Private Property Parameter As Object Implements ISupportParameter.Parameter
            Get
                Return New Object() {Format, Order}
            End Get

            Set(ByVal value As Object)
                Format = CType(CType(value, Object())(0), ReportFormat)
                Order = CType(CType(value, Object())(1), Order)
                LoadDocument(Order)
            End Set
        End Property

        Protected Property DocumentOwnerProp As IDocumentOwner
            Get
                Return _DocumentOwnerProp
            End Get

            Private Set(ByVal value As IDocumentOwner)
                _DocumentOwnerProp = value
            End Set
        End Property

        Public Sub Close()
            If DocumentOwnerProp IsNot Nothing Then DocumentOwnerProp.Close(Me)
        End Sub

        Public Sub LoadDocument(ByVal order As Order)
            Dim exportStream = New MemoryStream()
            Dim report = ReportFactory.SalesInvoice(order, True, False, False, False)
            Select Case Format
                Case ReportFormat.Pdf
                    report.ExportToPdf(exportStream)
                Case ReportFormat.Xls
                    report.ExportToXls(exportStream)
                Case ReportFormat.Doc
                    report.ExportToDocx(exportStream, New XtraPrinting.DocxExportOptions() With {.TableLayout = True, .ExportMode = XtraPrinting.DocxExportMode.SingleFilePageByPage})
            End Select

            DocumentStream = exportStream
            DocumentStream.Seek(0, SeekOrigin.Begin)
        End Sub

        Public Overridable Property DocumentStream As Stream

        Public Property Format As ReportFormat?

        Public Property Order As Order

#Region "IDocumentContent"
        Private Sub OnClose(ByVal e As CancelEventArgs) Implements IDocumentContent.OnClose
            DocumentStream.Dispose()
        End Sub

        Private Sub OnDestroy() Implements IDocumentContent.OnDestroy
        End Sub

        Private Property DocumentOwner As IDocumentOwner Implements IDocumentContent.DocumentOwner
            Get
                Return DocumentOwnerProp
            End Get

            Set(ByVal value As IDocumentOwner)
                DocumentOwnerProp = value
            End Set
        End Property

        Private ReadOnly Property Title As Object Implements IDocumentContent.Title
            Get
                Return String.Format("Invoice# {0}", Order.InvoiceNumber)
            End Get
        End Property
#End Region
    End Class

    Public Enum ReportFormat
        Pdf
        Xls
        Doc
    End Enum
End Namespace
