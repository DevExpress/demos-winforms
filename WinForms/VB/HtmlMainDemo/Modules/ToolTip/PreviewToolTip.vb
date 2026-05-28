Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraVerticalGrid.Rows
Imports System

Namespace DevExpress.HTML.Demos

    Public Partial Class PreviewToolTip
        Inherits PreviewCore

        Public Sub New()
            InitializeComponent()
            TemplateViewer.Init(Preview, htmlTemplateCollection1)
        End Sub

        Protected Overrides Sub OnFirstLoad()
            MyBase.OnFirstLoad()
            ContentProperties.BestFitHeight()
        End Sub

        Protected Overrides Function CreateContentProperties() As PreviewCoreContentProperties
            Return New PreviewToolTipProperties()
        End Function

        Protected Overrides Function GetToolTipControlInfo() As ToolTipControlInfo
            Dim hash As Integer = HashCodeHelper.CalculateGeneric(Controller.HtmlTemplate.Template, Controller.HtmlTemplate.Styles)
            Return New ToolTipControlInfo(hash, HintControl.ToolTip, HintControl.ToolTipTitle, HintControl.ToolTipIconType)
        End Function

        Protected Overrides Function CreateToolTipControllerPreview() As ToolTipController
            Dim controller = New SimpleToolTipControllerPreview(HintControl)
            controller.HtmlImages = HtmlImages
            ControllerProperties.Initialize(controller, ToolTipType.Standard)
            Return controller
        End Function

        Private Overloads ReadOnly Property ContentProperties As PreviewToolTipProperties
            Get
                Return CType(MyBase.ContentProperties, PreviewToolTipProperties)
            End Get
        End Property

        Protected Overrides Sub InitContent(ByVal tag As Object)
            If Equals(tag, templateSimpleToolTip.Tag) Then
                HintControl.ToolTipIconType = ToolTipIconType.None
                HintControl.ToolTipTitle = "Simple ToolTip"
                HintControl.ToolTip = "This is a regular tooltip (hint)"
                Controller.IconSize = ToolTipIconSize.Small
                ControllerProperties.SetVisibleProperties(True, True, False, True, True)
                ContentProperties.SetVisibleProperties(False, True, True)
            ElseIf Equals(tag, templateSimpleToolTipWithButton.Tag) Then
                HintControl.ToolTipIconType = ToolTipIconType.None
                HintControl.ToolTipTitle = "Modern Design Tooltips"
                HintControl.ToolTip = "Our HTML&CSS Templates allow you to create modern-looking" & Microsoft.VisualBasic.Constants.vbCrLf & "hints in a matter of minutes."
                Controller.IconSize = ToolTipIconSize.Large
                ControllerProperties.SetVisibleProperties(True, True, True, True, True)
                ContentProperties.SetVisibleProperties(False, True, True)
            ElseIf Equals(tag, templateStandardToolTip.Tag) Then
                HintControl.ToolTipIconType = ToolTipIconType.Information
                HintControl.ToolTipTitle = "Standard ToolTip"
                HintControl.ToolTip = "Painted as Standard ToolTip"
                Controller.IconSize = ToolTipIconSize.Small
                ControllerProperties.SetVisibleProperties(True, True, True, True, True)
                ContentProperties.SetVisibleProperties(True, True, True)
            End If

            MyBase.InitContent(tag)
        End Sub
    End Class

    Friend Class SimpleToolTipControllerPreview
        Inherits ToolTipControllerHtmlServiceProvider.ToolTipControllerPreview

        Private _active As BaseControl

        Public Sub New(ByVal active As BaseControl)
            MyBase.New(active)
            _active = active
        End Sub

        Protected Overrides ReadOnly Property CurrentToolTipTitle As String
            Get
                Return _active.ToolTipTitle
            End Get
        End Property

        Protected Overrides ReadOnly Property CurrentToolTipText As String
            Get
                Return _active.ToolTip
            End Get
        End Property

        Protected Overrides ReadOnly Property CurrentToolTipIconType As ToolTipIconType
            Get
                Return _active.ToolTipIconType
            End Get
        End Property
    End Class

    Friend Class PreviewToolTipProperties
        Inherits PreviewCoreContentProperties

        Public Sub New()
            Properties.Rows.Add(ToolTipIconProperty)
            Properties.Rows.Add(ToolTipTitleProperty)
            Properties.Rows.Add(ToolTipTextProperty)
        End Sub

        Public Sub SetVisibleProperties(ByVal icon As Boolean, ByVal title As Boolean, ByVal text As Boolean)
            ToolTipIconProperty.Visible = icon
            ToolTipTitleProperty.Visible = title
            ToolTipTextProperty.Visible = text
            BestFitHeight()
        End Sub

        Public Overrides Sub BestFitHeight()
            If ToolTipTextProperty.Grid Is Nothing Then Return
            ToolTipTextProperty.Height = Properties.ViewInfo.GetVisibleRowHeight(ToolTipTitleProperty) * 3
        End Sub

        Private rowIcon As PGridTextEditorRow

        Private ReadOnly Property ToolTipIconProperty As PGridTextEditorRow
            Get
                If rowIcon Is Nothing Then
                    rowIcon = New PGridTextEditorRow()
                    rowIcon.Properties.Caption = "ToolTip Icon: "
                    rowIcon.Properties.FieldName = "ToolTipIconType"
                End If

                Return rowIcon
            End Get
        End Property

        Private rowTitle As PGridTextEditorRow

        Private ReadOnly Property ToolTipTitleProperty As PGridTextEditorRow
            Get
                If rowTitle Is Nothing Then
                    rowTitle = New PGridTextEditorRow()
                    rowTitle.Properties.Caption = "ToolTip Title: "
                    rowTitle.Properties.FieldName = "ToolTipTitle"
                End If

                Return rowTitle
            End Get
        End Property

        Private rowText As PGridTextEditorRow

        Private ReadOnly Property ToolTipTextProperty As PGridTextEditorRow
            Get
                If rowText Is Nothing Then
                    rowText = New PGridTextEditorRow()
                    rowText.Properties.Caption = "ToolTip: "
                    rowText.Properties.FieldName = "ToolTip"
                    Dim repo As RepositoryItemMemoEdit = New RepositoryItemMemoEdit()
                    repo.ScrollBars = Windows.Forms.ScrollBars.None
                    rowText.Properties.RowEdit = repo
                End If

                Return rowText
            End Get
        End Property
    End Class
End Namespace
