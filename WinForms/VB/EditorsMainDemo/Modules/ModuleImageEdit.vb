Imports System
Imports System.ComponentModel
Imports System.Drawing
' <icbSizeMode>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleImageEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleImageEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "imageedit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleImageEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(imageEditSample)
            InitComboBoxes()
            InitValues()
        End Sub

        Private Sub InitComboBoxes()
            ' <icbSizeMode>
            icbSizeMode.Properties.Items.AddEnum(GetType(PictureSizeMode))
        ' </icbSizeMode>
        End Sub

        Private Sub InitValues()
            updateValues = True
            icbSizeMode.EditValue = imageEditSample.Properties.SizeMode
            ceIcon.Checked = imageEditSample.Properties.ShowIcon
            ceMenu.Checked = imageEditSample.Properties.ShowMenu
            cePopupSizeable.Checked = imageEditSample.Properties.PopupSizeable
            ceCustomIcons.Enabled = imageEditSample.Properties.ShowIcon
            updateValues = False
        End Sub

        ' <icbSizeMode>
        Private Sub icbSizeMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageEditSample.Properties.SizeMode = CType(icbSizeMode.EditValue, PictureSizeMode)
        End Sub

        ' </icbSizeMode>
        ' <ceIcon>
        Private Sub ceIcon_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageEditSample.Properties.ShowIcon = ceIcon.Checked
            ' <ceCustomIcons>
            ceCustomIcons.Enabled = imageEditSample.Properties.ShowIcon
        ' </ceCustomIcons>
        End Sub

        ' </ceIcon>
        ' <ceMenu>
        Private Sub ceMenu_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageEditSample.Properties.ShowMenu = ceMenu.Checked
        End Sub

        ' </ceMenu>
        ' <cePopupSizeable>
        Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageEditSample.Properties.PopupSizeable = cePopupSizeable.Checked
        End Sub

        ' </cePopupSizeable>
        ' <ceCustomIcons>
        Private Sub ceCustomIcons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            imageEditSample.Properties.Images = If(ceCustomIcons.Checked, svgImageCollection1, Nothing)
        End Sub
    ' </ceCustomIcons>
    End Class
End Namespace
