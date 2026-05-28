Imports System
Imports System.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleColorPickEdit
        Inherits TutorialControl

        Private updateValues As Boolean = False

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleColorPickEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "coloredit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private Sub ModuleColorEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            Tutorials.ControlUtils.CenterControlInParent(colorEditSample)
            InitComboBoxes()
            InitValues()
            InitMagnifierBehavior()
        End Sub

        Private Sub InitMagnifierBehavior()
            behaviorManager1.Attach(Of Behaviors.MagnifierBehavior)(colorEditSample, Sub(s) s.Properties.ShowPixelGrid = True)
        End Sub

        Private Sub InitComboBoxes()
            ' <icbColorDialogType>
            icbColorDialogType.Properties.Items.AddEnum(GetType(ColorDialogType))
            ' </icbColorDialogType>
            ' <icbColorText>
            icbColorText.Properties.Items.AddEnum(GetType(ColorText))
            ' </icbColorText>
            ' <icbColorAlignment>
            icbColorAlignment.Properties.Items.AddEnum(GetType(HorzAlignment))
            ' </icbColorAlignment>
            ' <icbShowTabs>
            icbShowTabs.Properties.Items.AddEnum(GetType(ShowTabs))
            ' </icbShowTabs>
            ' <icbShowArrows>
            icbShowArrows.Properties.Items.AddEnum(GetType(ShowArrows))
            ' </icbShowArrows>
            ' <icbTooltipMode>
            icbTooltipMode.Properties.Items.AddEnum(GetType(ColorTooltipFormat))
        ' </icbTooltipMode>
        End Sub

        Private Sub InitValues()
            updateValues = True
            icbColorAlignment.EditValue = colorEditSample.Properties.ColorAlignment
            icbColorText.EditValue = colorEditSample.Properties.ColorText
            icbColorDialogType.EditValue = colorEditSample.Properties.ColorDialogType
            ceShowColorDialog.Checked = colorEditSample.Properties.ShowColorDialog
            ceAsInteger.Checked = colorEditSample.Properties.StoreColorAsInteger
            icbShowTabs.EditValue = colorEditSample.Properties.ColorDialogOptions.ShowTabs
            icbShowArrows.EditValue = colorEditSample.Properties.ColorDialogOptions.ShowArrows
            icbTooltipMode.EditValue = colorEditSample.Properties.TooltipFormat
            ceShowMakeWebSafeBtn.Checked = colorEditSample.Properties.ColorDialogOptions.ShowMakeWebSafeButton
            ceShowPreview.Checked = colorEditSample.Properties.ColorDialogOptions.ShowPreview
            ceAllowTransparency.Checked = colorEditSample.Properties.ColorDialogOptions.AllowTransparency
            ceShowCustomTab.Checked = colorEditSample.Properties.ShowCustomColors
            ceShowWebTab.Checked = colorEditSample.Properties.ShowWebColors
            ceShowSystemTab.Checked = colorEditSample.Properties.ShowSystemColors
            ceShowWebSafeTab.Checked = colorEditSample.Properties.ShowWebSafeColors
            ceShowAutomaticButton.Checked = colorEditSample.Properties.ShowAutomaticButton
            ceShowMoreColorsButton.Checked = colorEditSample.Properties.ShowMoreColorsButton
            updateValues = False
        End Sub

        ' <icbColorAlignment>
        Private Sub icbColorAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            colorEditSample.Properties.ColorAlignment = CType(icbColorAlignment.EditValue, HorzAlignment)
        End Sub

        ' </icbColorAlignment>
        ' <icbColorText>
        Private Sub icbColorText_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            colorEditSample.Properties.ColorText = CType(icbColorText.EditValue, ColorText)
        End Sub

        ' </icbColorText>
        ' <icbColorDialogType>
        Private Sub icbColorDialogType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            colorEditSample.Properties.ColorDialogType = CType(icbColorDialogType.EditValue, ColorDialogType)
        End Sub

        ' </icbColorDialogType>
        ' <ceShowColorDialog>
        Private Sub ceShowColorDialog_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            colorEditSample.Properties.ShowColorDialog = ceShowColorDialog.Checked
        End Sub

        ' </ceShowColorDialog>
        ' <ceAsInteger>
        Private Sub ceIsInteger_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            colorEditSample.Properties.StoreColorAsInteger = ceAsInteger.Checked
        End Sub

        ' </ceAsInteger>
        ' <icbShowTabs>
        Private Sub icbShowTabs_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ColorDialogOptions.ShowTabs = CType(icbShowTabs.EditValue, ShowTabs)
        End Sub

        ' </icbShowTabs>
        ' <icbShowArrows>
        Private Sub icbShowArrows_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ColorDialogOptions.ShowArrows = CType(icbShowArrows.EditValue, ShowArrows)
        End Sub

        ' </icbShowArrows>
        ' <icbTooltipMode>
        Private Sub icbTooltipMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.TooltipFormat = CType(icbTooltipMode.EditValue, ColorTooltipFormat)
        End Sub

        ' </icbTooltipMode>
        ' <ceShowMakeWebSafeBtn>
        Private Sub ceShowMakeWebSafeBtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ColorDialogOptions.ShowMakeWebSafeButton = ceShowMakeWebSafeBtn.Checked
        End Sub

        ' </ceShowMakeWebSafeBtn>
        ' <ceShowPreview>
        Private Sub ceShowPreview_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ColorDialogOptions.ShowPreview = ceShowPreview.Checked
        End Sub

        ' </ceShowPreview>
        ' <ceAllowTransparency>
        Private Sub ceAllowTransparency_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ColorDialogOptions.AllowTransparency = ceAllowTransparency.Checked
        End Sub

        ' </ceAllowTransparency>
        Private Sub SetButtonEnabled(ByVal enabled As Boolean)
            seAdd.Enabled = enabled
            seClear.Enabled = Not enabled
        End Sub

        ' <ceShowCustom>
        Private Sub ceShowCustom_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ShowCustomColors = ceShowCustomTab.Checked
        End Sub

        ' </ceShowCustom>
        ' <ceShowWeb>
        Private Sub ceShowWebSafe_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ShowWebSafeColors = ceShowWebSafeTab.Checked
        End Sub

        ' </ceShowWeb>
        ' <ceShowSystem>
        Private Sub ceShowSystem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ShowSystemColors = ceShowSystemTab.Checked
        End Sub

        ' </ceShowSystem>
        ' <ceShowWebColors>
        Private Sub ceShowWebColors_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ShowWebColors = ceShowWebTab.Checked
        End Sub

        ' </ceShowWebColors>
        ' <ceShowMoreColorsButton>
        Private Sub ceShowMoreColorsButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ShowMoreColorsButton = ceShowMoreColorsButton.Checked
        End Sub

        ' </ceShowMoreColorsButton>
        ' <ceShowAutomaticButton>
        Private Sub ceShowAutomaticButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            colorEditSample.Properties.ShowAutomaticButton = ceShowAutomaticButton.Checked
        End Sub

        ' </ceShowAutomaticButton>
        ' <seAdd>
        Private Sub seAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            For Each color As Color In GetColorArray()
                colorEditSample.Properties.RecentColors.InsertColor(color)
            Next

            SetButtonEnabled(False)
        End Sub

        ' </seAdd>
        ' <seClear>
        Private Sub seClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            colorEditSample.Properties.RecentColors.Clear()
            SetButtonEnabled(True)
        End Sub

        ' </seClear>
        Const recentColorCount As Integer = 10

        Private Function GetColorArray() As Color()
            Dim rnd = TutorialConstants.Random
            Dim ret As Color() = New Color(9) {}
            For i As Integer = 0 To ret.Length - 1
                ret.SetValue((Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))), i)
            Next

            Return ret
        End Function
    End Class
End Namespace
