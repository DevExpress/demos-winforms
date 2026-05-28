Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls

    Public Partial Class HtmlButtonPanel
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            AddHandler htmlContentControl1.ElementMouseClick, AddressOf OnElementMouseClick
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Protected Friend Property HtmlImages As Object
            Get
                Return htmlContentControl1.HtmlImages
            End Get

            Set(ByVal value As Object)
                htmlContentControl1.HtmlImages = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Protected Friend Property DataSource As Object
            Get
                Return htmlContentControl1.DataContext
            End Get

            Set(ByVal value As Object)
                htmlContentControl1.DataContext = value
            End Set
        End Property

        Private Sub OnElementMouseClick(ByVal sender As Object, ByVal e As Utils.Html.DxHtmlElementMouseEventArgs)
            Dim dataSource = TryCast(Me.DataSource, AccordionDataObject)
            If dataSource Is Nothing Then Return
            For Each paymentType In dataSource.PaymentTypes
                If e.HasId(paymentType.Id) Then
                    dataSource.SelectedPaymentType = paymentType
                    htmlContentControl1.RefreshDataContext()
                    Return
                End If
            Next
        End Sub
    End Class
End Namespace
