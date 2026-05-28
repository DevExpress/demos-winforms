Imports System
Imports System.ComponentModel
Imports DevExpress.DevAV.Services
Imports DevExpress.DevAV.ViewModels

Namespace DevExpress.DevAV.Modules

    Public Partial Class ProductView
        Inherits BaseModuleControl

        Public Sub New()
            MyBase.New(GetType(SynchronizedProductViewModel))
            InitializeComponent()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            pdfViewer.BackColor = GetControlColor(LookAndFeel)
            AddHandler pdfViewer.ZoomChanged, AddressOf pdfViewer_ZoomChanged
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub

        Protected Overrides Sub OnMVVMContextReleasing()
            RemoveHandler pdfViewer.ZoomChanged, AddressOf pdfViewer_ZoomChanged
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            MyBase.OnDisposing()
        End Sub

        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService(New LoadingService(Me))
        End Sub

        Private Sub pdfViewer_ZoomChanged(ByVal sender As Object, ByVal e As XtraPdfViewer.PdfZoomChangedEventArgs)
            RaiseZoomLevelChanged()
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            pdfViewer.BackColor = GetControlColor(LookAndFeel)
        End Sub

        Public ReadOnly Property ViewModel As ProductViewModel
            Get
                Return GetViewModel(Of ProductViewModel)()
            End Get
        End Property

        Public ReadOnly Property CollectionViewModel As ProductCollectionViewModel
            Get
                Return GetParentViewModel(Of ProductCollectionViewModel)()
            End Get
        End Property

        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As EventArgs)
            QueueUIUpdate()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If ViewModel IsNot Nothing Then UpdateUI(ViewModel.Entity)
        End Sub

        Protected Overrides Sub OnDelayedUIUpdate()
            UpdateUI(ViewModel.Entity)
        End Sub

        Private Sub UpdateUI(ByVal product As Product)
            UpdateDocument(product)
            pdfViewer.Visible = product IsNot Nothing
        End Sub

        Private Sub UpdateDocument(ByVal product As Product)
            If product Is Nothing Then Return
            If product.Brochure Is Nothing Then
                pdfViewer.CloseDocument()
            Else
                LoadDocument(product)
            End If
        End Sub

        Private Sub LoadDocument(ByVal product As Product)
            Dim loadingService = GetService(Of IWaitingService)()
            Using loadingService.Enter(product.Name)
                pdfViewer.LoadDocument(product.Brochure)
                pdfViewer.ZoomMode = XtraPdfViewer.PdfZoomMode.PageLevel
                pdfViewer.ZoomFactor -= pdfViewer.ZoomFactor / 4F
                RaiseZoomLevelChanged()
            End Using
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property ZoomLevel As Integer
            Get
                Return CInt(Math.Ceiling(pdfViewer.ZoomFactor))
            End Get

            Set(ByVal value As Integer)
                If value <> ZoomLevel Then pdfViewer.ZoomFactor = CSng(value)
            End Set
        End Property

        Public Event ZoomLevelChanged As EventHandler

        Private Sub RaiseZoomLevelChanged()
            Dim handler As EventHandler = ZoomLevelChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub
    End Class
End Namespace
