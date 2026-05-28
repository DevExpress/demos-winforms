Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid.Rows

Namespace DevExpress.HTML.Demos

    Public Partial Class PreviewSuperTip
        Inherits PreviewCore

        Public Sub New()
            InitializeComponent()
            TemplateViewer.Init(Preview, htmlTemplateCollection1)
        End Sub

        Protected Overrides Function CreateContentProperties() As PreviewCoreContentProperties
            Return New PreviewSuperTipProperties()
        End Function

        Protected Overrides Function GetToolTipControlInfo() As ToolTipControlInfo
            Dim info = New ToolTipControlInfo()
            info.Object = HashCodeHelper.CalculateGeneric(Controller.HtmlTemplate.Template, Controller.HtmlTemplate.Styles)
            info.SuperTip = HintControl.SuperTip
            Return info
        End Function

        Protected Overrides Function CreateToolTipControllerPreview() As ToolTipController
            Dim controller = New SuperToolTipControllerPreview(HintControl)
            controller.HtmlImages = HtmlImages
            ControllerProperties.Initialize(controller, ToolTipType.SuperTip)
            Return controller
        End Function

        Protected Overrides Sub InitContent(ByVal tag As Object)
            If Equals(tag, htmlSimple.Tag) Then
                HintControl.SuperTip = SuperTipTemplate1
                ControllerProperties.SetVisibleProperties(True, True, False, True, True)
            ElseIf Equals(tag, templateStandardSuperTip.Tag) Then
                HintControl.SuperTip = SuperTipTemplate3
                ControllerProperties.SetVisibleProperties(True, True, False, True, True)
            End If

            MyBase.InitContent(tag)
        End Sub

        Private supertipSimple As SuperToolTip

        Private ReadOnly Property SuperTipTemplate1 As SuperToolTip
            Get
                If supertipSimple Is Nothing Then
                    supertipSimple = New SuperToolTip()
                    Dim title As ToolTipTitleItem = New ToolTipTitleItem()
                    title.Text = "SuperTip"
                    title.Appearance.TextOptions.VAlignment = VertAlignment.Center
                    title.ImageOptions.SvgImage = HtmlImages("logo")
                    title.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
                    supertipSimple.Items.Add(title)
                    supertipSimple.Items.AddSeparator()
                    supertipSimple.Items.Add("This is a custom template for Super Tooltips")
                End If

                Return supertipSimple
            End Get
        End Property

        Private supertipStandard As SuperToolTip

        Private ReadOnly Property SuperTipTemplate3 As SuperToolTip
            Get
                If supertipStandard Is Nothing Then
                    supertipStandard = New SuperToolTip()
                    Dim title As ToolTipTitleItem = New ToolTipTitleItem()
                    title.Text = "Standard SuperTip"
                    title.ImageOptions.SvgImage = HtmlImages("logo")
                    title.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
                    supertipStandard.Items.Add(title)
                    supertipStandard.Items.AddSeparator()
                    supertipStandard.Items.Add("Painted as Standard SuperTip")
                End If

                Return supertipStandard
            End Get
        End Property
    End Class

    Friend Class SuperToolTipControllerPreview
        Inherits ToolTipControllerHtmlServiceProvider.ToolTipControllerPreview

        Private _active As BaseControl

        Public Sub New(ByVal active As BaseControl)
            MyBase.New(active)
            _active = active
        End Sub

        Protected Overrides Function GetCurrentSuperToolTip() As SuperToolTip
            Return _active.SuperTip
        End Function
    End Class

    Friend Class PreviewSuperTipProperties
        Inherits PreviewCoreContentProperties

        Public Sub New()
            Properties.Rows.Add(SuperTipProperty)
        End Sub

        Private ReadOnly Property SuperTipProperty As PGridButtonEditorRow
            Get
                Dim row As PGridButtonEditorRow = New PGridButtonEditorRow()
                row.Properties.Caption = "SuperTip Items: "
                row.Properties.FieldName = "SuperTip"
                Return row
            End Get
        End Property
    End Class
End Namespace
