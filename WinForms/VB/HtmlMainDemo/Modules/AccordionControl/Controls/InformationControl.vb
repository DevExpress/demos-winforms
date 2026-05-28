Imports DevExpress.XtraEditors
Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls

    Public Partial Class InformationControl
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

        Private Sub OnHtmlElementClick(ByVal sender As Object, ByVal e As Utils.Html.DxHtmlElementMouseEventArgs)
            If e.HasId("nextbutton") Then RaiseNextButtonClick()
        End Sub
    End Class

    Public Class AccordionHtmlContainerBase
        Inherits XtraUserControl

        Private Shared ReadOnly nextButtonClickField As Object = New Object()

        Public Custom Event NextButtonClick As EventHandler
            AddHandler(ByVal value As EventHandler)
                Events.AddHandler(nextButtonClickField, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                Events.RemoveHandler(nextButtonClickField, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event

        Protected Overridable Sub RaiseNextButtonClick()
            Dim handler As EventHandler = CType(Events(nextButtonClickField), EventHandler)
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub
    End Class
End Namespace
