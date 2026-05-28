Imports System
Imports System.Drawing
Imports System.IO
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.Reports
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Pdf
Imports DevExpress.Security

Namespace DevExpress.DevAV.Modules

    Public Partial Class OrderMapView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Private _Presenter As OrderRouteMapPresenter

        Public Sub New()
            MyBase.New(GetType(OrderMapViewModel))
            InitializeComponent()
            Presenter = CreatePresenter()
            BindCommands()
            BindEditors()
            UpdateColors()
            SwapFluentIcons(Me)
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler biPrint.ItemClick, AddressOf OnPrint
            RemoveHandler barExportItem.ItemClick, AddressOf OnExport
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As OrderMapViewModel
            Get
                Return GetViewModel(Of OrderMapViewModel)()
            End Get
        End Property

        Protected Property Presenter As OrderRouteMapPresenter
            Get
                Return _Presenter
            End Get

            Private Set(ByVal value As OrderRouteMapPresenter)
                _Presenter = value
            End Set
        End Property

        Protected Overridable Function CreatePresenter() As OrderRouteMapPresenter
            Return New OrderRouteMapPresenter(mapControl, ViewModel, AddressOf UpdateUI)
        End Function

        Protected Overridable Sub BindCommands()
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
            AddHandler biPrint.ItemClick, AddressOf OnPrint
            AddHandler barExportItem.ItemClick, AddressOf OnExport
        End Sub

        Private Overloads Sub OnPrint(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            Viewer.Print()
        End Sub

        Private Sub OnExport(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            Dim shippingDocument As String = SafePath.AddFileNameSuffix("Shipping_.pdf", ViewModel.Entity.InvoiceNumber)
            Viewer.SaveDocument(shippingDocument)
        End Sub

        Protected Overridable Sub BindEditors()
            bindingSource.DataSource = ViewModel
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateColors()
        End Sub

        Private Sub UpdateColors()
            ItemForInvoice.AppearanceItemCaption.ForeColor = DisabledTextColor
            InvoiceLabel.Appearance.ForeColor = DisabledTextColor
        End Sub

        Private Sub UpdateUI(ByVal order As Order)
            ribbonControl.ApplicationDocumentCaption = order.Customer.Name
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                Using template As Stream = GetShipmentTemplate(order)
                    processor.LoadDocument(template)
                    AddWatermark(processor, GetWatermarkText(order))
                    Using ms As MemoryStream = New MemoryStream()
                        processor.SaveDocument(ms)
                        ms.Seek(0, SeekOrigin.Begin)
                        Viewer.LoadDocument(ms)
                    End Using
                End Using
            End Using
        End Sub

        Private Shared Function GetShipmentTemplate(ByVal order As Order) As Stream
            Dim pdfStream As MemoryStream = New MemoryStream()
            Dim report = ReportFactory.ShippingDetail(order)
            report.ExportToPdf(pdfStream)
            Return pdfStream
        End Function

        Private Shared Function GetWatermarkText(ByVal order As Order) As String
            Select Case order.ShipmentStatus
                Case ShipmentStatus.Received
                    Return "Shipment Received"
                Case ShipmentStatus.Transit
                    Return "Shipment in Transit"
                Case Else
                    Return "Awaiting shipment"
            End Select
        End Function

        Private Shared Sub AddWatermark(ByVal processor As PdfDocumentProcessor, ByVal watermark As String)
            Dim pages = processor.Document.Pages
            For i As Integer = 0 To pages.Count - 1
                Using graphics = processor.CreateGraphics()
                    Using font As Font = New Font("Segoe UI", 48, FontStyle.Regular)
                        Dim pageLayout As RectangleF = New RectangleF(-CSng(pages(i).CropBox.Width) * 0.35F, CSng(pages(i).CropBox.Height) * 0.1F, CSng(pages(i).CropBox.Width) * 1.25F, CSng(pages(i).CropBox.Height))
                        Dim angle = Math.Asin(CDbl(pageLayout.Width) / CDbl(pageLayout.Height)) * 180.0 / Math.PI
                        graphics.TranslateTransform(-pageLayout.X, -pageLayout.Y)
                        graphics.RotateTransform(CSng(angle))
                        Using textBrush As SolidBrush = New SolidBrush(Color.FromArgb(100, Color.Red))
                            graphics.DrawString(watermark, font, textBrush, New PointF(50, 50))
                        End Using
                    End Using

                    graphics.AddToPageForeground(pages(i))
                End Using
            Next
        End Sub

#Region "IRibbonModule"
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
#End Region
    End Class
End Namespace
