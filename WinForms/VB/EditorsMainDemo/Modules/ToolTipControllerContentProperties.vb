Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Namespace EditorsTutorials.Modules

    Public Partial Class ToolTipControllerContentProperties
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private controller As ToolTipController = Nothing

        Private control As Control = Nothing

        Private isManual As Boolean = False

        Public Sub Init(ByVal controller As ToolTipController, ByVal control As Control, ByVal toolTipText As String, ByVal titleText As String, ByVal isManual As Boolean)
            Me.isManual = isManual
            Me.controller = controller
            Me.control = control
            InitComboBoxes()
            meToolTipText.Text = toolTipText
            teTitleText.Text = titleText
            If isManual Then
                icbIconSize.EditValue = ToolTipIconSize.Large
            Else
                icbIconSize.EditValue = controller.IconSize
            End If

            controller.ImageList = svgImageCollection1
        End Sub

        Private Sub InitComboBoxes()
            icbIconType.Properties.Items.AddEnum(GetType(ToolTipIconType))
            icbIconType.SelectedIndex = If(isManual, icbIconType.Properties.Items.Count - 1, 3)
            icbIconSize.Properties.Items.AddEnum(GetType(ToolTipIconSize))
        End Sub

        Private Sub meToolTipText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If isManual OrElse controller Is Nothing Then Return
            controller.SetToolTip(control, meToolTipText.Text)
        End Sub

        Private Sub teTitleText_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If isManual OrElse controller Is Nothing Then Return
            controller.SetTitle(control, teTitleText.Text)
        End Sub

        Private Sub icbIconType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If isManual OrElse controller Is Nothing Then Return
            controller.SetToolTipIconType(control, CType(icbIconType.EditValue, ToolTipIconType))
        End Sub

        Private Sub icbIconSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If isManual OrElse controller Is Nothing Then Return
            controller.IconSize = CType(icbIconSize.EditValue, ToolTipIconSize)
        End Sub

        Private Sub icbCustomImage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If isManual OrElse controller Is Nothing Then Return
            controller.ImageIndex = icbCustomImage.SelectedIndex - 1
        End Sub

        Public Function CreateShowArgs() As ToolTipControllerShowEventArgs
            Dim args As ToolTipControllerShowEventArgs = controller.CreateShowArgs()
            args.ToolTip = meToolTipText.Text
            args.Title = teTitleText.Text
            args.IconType = CType(icbIconType.EditValue, ToolTipIconType)
            args.IconSize = CType(icbIconSize.EditValue, ToolTipIconSize)
            args.ImageIndex = icbCustomImage.SelectedIndex - 1
            Return args
        End Function
    End Class
End Namespace
