Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class ModuleFlyoutPanel
        Inherits TutorialControl

        Private optionsCore As FlyoutModuleOptions

        Public Sub New()
            optionsCore = New FlyoutModuleOptions()
            InitializeComponent()
            TutorialInfo.TutorialName = "FlyoutPanel Tutorial"
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitControls()
            UpdateControls()
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            HideToolWindowCore()
        End Sub

        Private Sub InitControls()
            For Each anchorType As PopupToolWindowAnchor In [Enum].GetValues(GetType(PopupToolWindowAnchor))
                cbAnchorTypes.Properties.Items.Add(anchorType)
            Next

            cbAnchorTypes.EditValue = Options.Anchor
            For Each animationType As PopupToolWindowAnimation In [Enum].GetValues(GetType(PopupToolWindowAnimation))
                cbAnimationTypes.Properties.Items.Add(animationType)
            Next

            cbAnimationTypes.EditValue = Options.AnimationType
            ceCloseOnOuterClick.Checked = Options.CloseOnOuterClick
            spinEditXCoord.Value = Options.XCoord
            spinEditYCoord.Value = Options.YCoord
        End Sub

        '<cbAnchorTypes>
        Private Sub OnAnchorTypeSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Options.Anchor = CType(edit.EditValue, PopupToolWindowAnchor)
            If Options.Anchor = PopupToolWindowAnchor.Center OrElse Options.Anchor = PopupToolWindowAnchor.Manual Then cbAnimationTypes.EditValue = PopupToolWindowAnimation.Fade
            UpdateControls()
        End Sub

        '</cbAnchorTypes>
        '<cbAnimationTypes>
        Private Sub OnAnimationTypesSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Options.AnimationType = CType(edit.EditValue, PopupToolWindowAnimation)
        End Sub

        '</cbAnimationTypes>
        '<ceCloseOnOuterClick>
        Private Sub OnCloseOnOuterClickCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = CType(sender, CheckEdit)
            Options.CloseOnOuterClick = edit.Checked
            If panelCore IsNot Nothing Then panelCore.Options.CloseOnOuterClick = Options.CloseOnOuterClick
        End Sub

        '</ceCloseOnOuterClick>
        '<spinEditXCoord>
        Private Sub OnCoordEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As SpinEdit = CType(sender, SpinEdit)
            Options.XCoord = CInt(edit.Value)
        End Sub

        '</spinEditXCoord>
        '<spinEditYCoord>
        Private Sub OnYCoordEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As SpinEdit = CType(sender, SpinEdit)
            Options.YCoord = CInt(edit.Value)
        End Sub

        '</spinEditYCoord>
        '<horzFlyoutPanel>
        Private Sub OnFlyoutPanelHidden(ByVal sender As Object, ByVal e As FlyoutPanelEventArgs)
            Dim panel As FlyoutPanel = CType(sender, FlyoutPanel)
            If panelCore Is Nothing OrElse Not ReferenceEquals(panel, panelCore) Then Return
            panelCore = Nothing
            UpdateControls()
        End Sub

        '</horzFlyoutPanel>
        '<btnShowToolWindow>
        Private Sub OnShowToolWindowClick(ByVal sender As Object, ByVal e As EventArgs)
            ShowToolWindowCore()
        End Sub

        '</btnShowToolWindow>
        '<btnHideToolWindow>
        Private Sub OnHideToolWindowClick(ByVal sender As Object, ByVal e As EventArgs)
            HideToolWindowCore()
        End Sub

        '</btnHideToolWindow>
        Private panelCore As FlyoutPanel = Nothing

        Private Sub ShowToolWindowCore()
            Dim panel As FlyoutPanel = SelectPanel()
            panel.Options.AnchorType = optionsCore.Anchor
            panel.Options.AnimationType = optionsCore.AnimationType
            panel.Options.CloseOnOuterClick = optionsCore.CloseOnOuterClick
            panel.Options.Location = Options.ManualPoint
            panel.ShowPopup()
            panelCore = panel
            UpdateControls()
        End Sub

        Private Sub HideToolWindowCore()
            If panelCore Is Nothing Then Return
            panelCore.HidePopup()
            panelCore = Nothing
            UpdateControls()
        End Sub

        Private Function SelectPanel() As FlyoutPanel
            If Options.Anchor = PopupToolWindowAnchor.Left OrElse Options.Anchor = PopupToolWindowAnchor.Right Then Return vertFlyoutPanel
            Return horzFlyoutPanel
        End Function

        Private Sub UpdateControls()
            btnShowToolWindow.Enabled = panelCore Is Nothing
            btnHideToolWindow.Enabled = Not btnShowToolWindow.Enabled
            lblYCoord.Enabled = Options.Anchor = PopupToolWindowAnchor.Manual
            lblXCoord.Enabled = lblYCoord.Enabled
            spinEditYCoord.Enabled = lblXCoord.Enabled
            spinEditXCoord.Enabled = spinEditYCoord.Enabled
        End Sub

        Public ReadOnly Property Options As FlyoutModuleOptions
            Get
                Return optionsCore
            End Get
        End Property
    End Class

    Public Class FlyoutModuleOptions

        Public Sub New()
            Anchor = PopupToolWindowAnchor.Top
            AnimationType = PopupToolWindowAnimation.Slide
            CloseOnOuterClick = False
            YCoord = 0
            XCoord = YCoord
        End Sub

        Public Property Anchor As PopupToolWindowAnchor

        Public Property AnimationType As PopupToolWindowAnimation

        Public Property CloseOnOuterClick As Boolean

        Public Property XCoord As Integer

        Public Property YCoord As Integer

        Public ReadOnly Property ManualPoint As Point
            Get
                Return New Point(XCoord, YCoord)
            End Get
        End Property
    End Class
End Namespace
