Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls

    Public Partial Class ShippingControl
        Inherits AccordionHtmlContainerBase
        Implements IHtmlContentControlProvider

        Public Sub New()
            InitializeComponent()
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

        Private Function CalcBestSize(ByVal width As Integer) As Size Implements IHtmlContentControlProvider.CalcBestSize
            Return CType(htmlContentControl1, IHtmlContentControlInternal).CalcBestSize(width)
        End Function

        Private Shared ReadOnly saveButtonClickField As Object = New Object()

        Public Custom Event SaveButtonClick As EventHandler
            AddHandler(ByVal value As EventHandler)
                Events.AddHandler(saveButtonClickField, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                Events.RemoveHandler(saveButtonClickField, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event

        Protected Overridable Sub RaiseSaveButtonClick()
            Dim handler As EventHandler = CType(Events(saveButtonClickField), EventHandler)
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Private Sub OnHtmlElementClick(ByVal sender As Object, ByVal e As Utils.Html.DxHtmlElementMouseEventArgs)
            If e.HasId("nextbutton") Then
                RaiseNextButtonClick()
            End If

            If e.HasId("savebutton") Then
                RaiseSaveButtonClick()
            End If
        End Sub
    End Class
End Namespace
