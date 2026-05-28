Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace DevExpress.HTML.Demos

    Public Partial Class PreviewCore
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            HtmlImages.Add("logo", DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages("logo"))
            htmlContentControl1.ToolTipController = Controller
            HintControl.ToolTipController = htmlContentControl1.ToolTipController
            InitializeProperties()
            SubscribeEvents()
        End Sub

        Protected Overrides Sub OnFirstLoad()
            MyBase.OnFirstLoad()
            If Not DesignMode Then CenterParent(hostToolTipField, Preview)
        End Sub

        Private previewField As HtmlToolTipWindowBase

        Protected ReadOnly Property Preview As HtmlToolTipWindowBase
            Get
                Return If(previewField, Function()
                    previewField = New HtmlToolTipWindowBase(Controller)
                    Return previewField
                End Function())
            End Get
        End Property

        Private controllerField As ToolTipController

        Protected ReadOnly Property Controller As ToolTipController
            Get
                Return If(controllerField, Function()
                    controllerField = CreateToolTipControllerPreview()
                    Return controllerField
                End Function())
            End Get
        End Property

        Protected ReadOnly Property HtmlImages As SvgImageCollection
            Get
                Return htmlImageCollection
            End Get
        End Property

        Protected ReadOnly Property TemplateViewer As ToolTipTemplateViewer
            Get
                Return templateViewerField
            End Get
        End Property

        Protected ReadOnly Property HostToolTip As XtraUserControl
            Get
                Return hostToolTipField
            End Get
        End Property

        Protected ReadOnly Property HintControl As LabelControl
            Get
                Return labelControl1
            End Get
        End Property

        Private contentPropertiesField As PreviewCoreContentProperties

        Protected ReadOnly Property ContentProperties As PreviewCoreContentProperties
            Get
                If contentPropertiesField Is Nothing Then
                    contentPropertiesField = CreateContentProperties()
                    contentPropertiesField.Dock = DockStyle.Fill
                    contentPropertiesField.Properties.SelectedObject = HintControl
                    AddHandler contentPropertiesField.Properties.CellValueChanged, Sub() RefreshPreview()
                End If

                Return contentPropertiesField
            End Get
        End Property

        Protected ReadOnly Property ControllerProperties As PreviewCoreControllerProperties
            Get
                Return previewCoreProperties1
            End Get
        End Property

        Protected Overridable Function CreateContentProperties() As PreviewCoreContentProperties
            Return New PreviewCoreContentProperties()
        End Function

        Protected Overridable Function CreateToolTipControllerPreview() As ToolTipController
            Return New ToolTipController()
        End Function

        Protected Overridable Sub InitContent(ByVal tag As Object)
            ContentProperties.Properties.InvalidateData()
            ControllerProperties.UpdateValues()
        End Sub

        Protected Overridable Function GetToolTipControlInfo() As ToolTipControlInfo
            Return Nothing
        End Function

        Private Sub OnControllerGetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs)
            If Equals(htmlContentControl1, e.SelectedControl) Then e.Info = GetToolTipControlInfo()
        End Sub

        Private Sub InitializeProperties()
            propertiesPanel.Controls.Add(ContentProperties)
            propertiesPanel.SetColumn(ContentProperties, 0)
            propertiesPanel.SetRow(ContentProperties, 0)
        End Sub

        Private Sub SubscribeEvents()
            AddHandler TemplateViewer.ActiveTemplateChanged, AddressOf OnActiveTemplateChanged
            AddHandler Preview.HtmlTemplate.PropertyChanged, AddressOf OnHtmlTemplatePropertyChanged
            AddHandler ControllerProperties.PropertyChanged, Sub() RefreshPreview()
            AddHandler Controller.GetActiveObjectInfo, AddressOf OnControllerGetActiveObjectInfo
        End Sub

        Private Sub OnActiveTemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            InitContent(TemplateViewer.ActiveTemplate.Tag)
            RefreshPreview()
        End Sub

        Private Sub OnHtmlTemplatePropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
            Controller.HtmlTemplate.Assign(TemplateViewer.ActiveTemplate)
        End Sub

        Private Sub RefreshPreview()
            Preview.HtmlTemplate.Assign(TemplateViewer.ActiveTemplate)
            UpdateViewBounds(HostToolTip, Preview)
            Preview.Invalidate()
        End Sub
    End Class
End Namespace
