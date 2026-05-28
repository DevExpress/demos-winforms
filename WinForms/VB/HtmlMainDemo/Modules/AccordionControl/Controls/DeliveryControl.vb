Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls

    Public Partial Class DeliveryControl
        Inherits AccordionHtmlContainerBase
        Implements IHtmlContentControlProvider

        Public Sub New()
            InitializeComponent()
            AddHandler htmlContentControl1.ElementMouseDown, AddressOf OnHtmlElementMouseDown
            AddHandler htmlContentControl1.ElementMouseClick, AddressOf OnHtmlElementClick
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Protected Friend Property DataSource As Object
            Get
                Return htmlContentControl1.DataContext
            End Get

            Set(ByVal value As Object)
                htmlContentControl1.DataContext = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Protected Friend Property HtmlImages As Object
            Get
                Return htmlContentControl1.HtmlImages
            End Get

            Set(ByVal value As Object)
                htmlContentControl1.HtmlImages = value
            End Set
        End Property

        Private Function CalcBestSize(ByVal width As Integer) As Size Implements IHtmlContentControlProvider.CalcBestSize
            Return CType(htmlContentControl1, IHtmlContentControlInternal).CalcBestSize(width)
        End Function

        Private Sub OnHtmlElementMouseDown(ByVal sender As Object, ByVal e As Utils.Html.DxHtmlElementMouseEventArgs)
            Dim dataSource = TryCast(Me.DataSource, AccordionDataObject)
            If dataSource Is Nothing Then Return
            For Each deliveryType In dataSource.DeliveryTypes
                If Equals(e.ElementId, deliveryType.Id) OrElse e.ParentHasId(deliveryType.Id) Then
                    dataSource.SelectedDelivery = deliveryType
                    htmlContentControl1.RefreshDataContext()
                    Return
                End If
            Next
        End Sub

        Private Sub OnHtmlElementClick(ByVal sender As Object, ByVal e As Utils.Html.DxHtmlElementMouseEventArgs)
            If e.HasId("nextbutton") Then RaiseNextButtonClick()
        End Sub
    End Class
End Namespace
