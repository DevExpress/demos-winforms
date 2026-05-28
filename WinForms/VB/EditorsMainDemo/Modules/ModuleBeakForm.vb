Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.ButtonsPanelControl

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleBeakForm
        Inherits TutorialControl

        Private options As BeakPanelOptions

        Private buttonPanelOptions As FlyoutPanelButtonOptions

        Public Sub New()
            InitializeComponent()
            options = flyoutPanel.OptionsBeakPanel
            buttonPanelOptions = flyoutPanel.OptionsButtonPanel
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleBeakForm"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "beakForm"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitValues()
        End Sub

        Private Sub InitValues()
            backColorEdit.EditValue = options.BackColor
            borderColorEdit.EditValue = options.BorderColor
            ceCloseOnOuterClick.EditValue = options.CloseOnOuterClick
            borderColorEdit.Properties.AutomaticColor = Color.Empty
            backColorEdit.Properties.AutomaticColor = borderColorEdit.Properties.AutomaticColor
            ceShowButtonPanel.EditValue = flyoutPanel.OptionsButtonPanel.ShowButtonPanel
            cbeButtonPanelLocation.Properties.Items.AddEnum(GetType(FlyoutPanelButtonPanelLocation))
            cbeButtonPanelLocation.EditValue = buttonPanelOptions.ButtonPanelLocation
            cbeButtonPanelAlignment.Properties.Items.AddEnum(GetType(ContentAlignment))
            buttonPanelOptions.ButtonPanelContentAlignment = ContentAlignment.TopRight
            cbeButtonPanelAlignment.EditValue = buttonPanelOptions.ButtonPanelContentAlignment
            cbeBeakLocation.Properties.Items.AddEnum(GetType(BeakPanelBeakLocation))
            cbeBeakLocation.EditValue = options.BeakLocation
            UpdateControls()
        End Sub

        ' <previewPanel>
        Private Sub OnPreviewPanelMouseEnter(ByVal sender As Object, ByVal e As EventArgs)
            EnsureShowBeakForm()
        End Sub

        Private Sub EnsureShowBeakForm()
            If flyoutPanel.FlyoutPanelState.IsActive Then Return
            flyoutPanel.ShowBeakForm(GetHotPoint())
        End Sub

        Private Function GetHotPoint() As Point
            Dim pt As Point = New Point(0, previewPanel.Height \ 2)
            Dim edtiValue As BeakPanelBeakLocation = CType(cbeBeakLocation.EditValue, BeakPanelBeakLocation)
            If edtiValue = BeakPanelBeakLocation.Right Then
                Return previewPanel.PointToScreen(pt)
            End If

            If edtiValue = BeakPanelBeakLocation.Left Then
                pt.X += previewPanel.Width
                Return previewPanel.PointToScreen(pt)
            End If

            pt = New Point(previewPanel.Width \ 2, 0)
            If edtiValue = BeakPanelBeakLocation.Top Then
                pt.Y += previewPanel.Height
            End If

            Return previewPanel.PointToScreen(pt)
        End Function

        ' </previewPanel>
        ' <backColorEdit>
        Private Overloads Sub OnBackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim colorEdit As ColorPickEdit = CType(sender, ColorPickEdit)
            options.BackColor = colorEdit.Color
        End Sub

        ' </backColorEdit>
        ' <borderColorEdit>
        Private Sub OnBorderColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim colorEdit As ColorPickEdit = CType(sender, ColorPickEdit)
            options.BorderColor = colorEdit.Color
        End Sub

        ' </borderColorEdit>
        ' <ceCloseOnOuterClick>
        Private Sub OnCloseOnOuterClickFlagChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
            options.CloseOnOuterClick = checkEdit.Checked
        End Sub

        ' </ceCloseOnOuterClick>
        ' <ceShowButtonPanel>
        Private Sub OnShowButtonPanelFlagChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
            flyoutPanel.OptionsButtonPanel.ShowButtonPanel = checkEdit.Checked
            UpdateControls()
        End Sub

        ' </ceShowButtonPanel>
        ' <flyoutPanel>
        Private Sub OnFlyoutPanelButtonClick(ByVal sender As Object, ByVal e As FlyoutPanelButtonClickEventArgs)
            Dim _tag As String = TryCast(e.Button.Tag, String)
            If String.Equals(_tag, "Exit", StringComparison.OrdinalIgnoreCase) Then
                flyoutPanel.HideBeakForm()
            End If
        End Sub

        ' </flyoutPanel>
        ' <cbeButtonPanelLocation>
        Private Sub OnButtonPanelLocationChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            flyoutPanel.OptionsButtonPanel.ButtonPanelLocation = CType(comboBox.EditValue, FlyoutPanelButtonPanelLocation)
            UpdateControls()
        End Sub

        ' </cbeButtonPanelLocation>
        ' <cbeButtonPanelAlignment>
        Private Sub OnButtonPanelAlignmentChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            buttonPanelOptions.ButtonPanelContentAlignment = CType(comboBox.EditValue, ContentAlignment)
        End Sub

        ' </cbeButtonPanelAlignment>
        ' <btnAddButton>
        Private Sub OnAddButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            buttonPanelOptions.Buttons.Insert(0, CreateButton())
            UpdateControls()
        End Sub

        Private Function CreateButton() As ButtonControl
            Dim button = New PeekFormButton()
            button.ToolTip = "Custom Button"
            button.UseCaption = False
            button.ImageOptions.SvgImage = svgImageCollection1(0)
            button.ImageOptions.SvgImageSize = svgImageCollection1.ImageSize
            Return button
        End Function

        ' </btnAddButton>
        ' <btnRemoveButton>
        Private Sub OnRemoveButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim buttons = buttonPanelOptions.Buttons
            If buttons.Count <= 1 Then Return
            buttons.RemoveAt(0)
            UpdateControls()
        End Sub

        ' </btnRemoveButton>
        Private Sub UpdateFlyoutHintLabelLocation()
            Dim loc As Point = flyoutPanelHintLabel.Location
            loc.Y =(flyoutPanel.Height - flyoutPanelHintLabel.Height) \ 2
            flyoutPanelHintLabel.Location = loc
        End Sub

        ' <cbeBeakLocation>
        Private Sub OnBeakLocationChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            options.BeakLocation = CType(comboBox.EditValue, BeakPanelBeakLocation)
        End Sub

        ' </cbeBeakLocation>
        Private Sub UpdateControls()
            btnAddButton.Enabled = buttonPanelOptions.Buttons.Count < 6
            btnRemoveButton.Enabled = buttonPanelOptions.Buttons.Count > 1
            UpdateFlyoutHintLabelLocation()
        End Sub
    End Class
End Namespace
