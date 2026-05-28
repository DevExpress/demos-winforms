Imports System
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls

    Public Partial Class HtmlCheckBoxControl
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            dataObject = New HtmlCheckBoxSource()
            htmlContentControl1.DataContext = dataObject
            AddHandler htmlContentControl1.ElementMouseDown, AddressOf OnElementClick
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

        Private Sub OnElementClick(ByVal sender As Object, ByVal e As Utils.Html.DxHtmlElementMouseEventArgs)
            dataObject.Checked = Not dataObject.Checked
            RaiseCheckedChanged()
            htmlContentControl1.Invalidate()
        End Sub

        Private Shared ReadOnly checkedChangedField As Object = New Object()

        Public Custom Event CheckedChanged As EventHandler
            AddHandler(ByVal value As EventHandler)
                Events.AddHandler(checkedChangedField, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                Events.RemoveHandler(checkedChangedField, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event

        Protected Overridable Sub RaiseCheckedChanged()
            Dim handler As EventHandler = CType(Events(checkedChangedField), EventHandler)
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Protected Friend ReadOnly Property Checked As Boolean
            Get
                Return dataObject.Checked
            End Get
        End Property

        Private dataObject As HtmlCheckBoxSource

        Private Class HtmlCheckBoxSource

            Public Property Checked As Boolean
        End Class
    End Class
End Namespace
