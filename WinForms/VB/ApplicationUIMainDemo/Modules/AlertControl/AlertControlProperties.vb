Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraBars

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class AlertControlProperties
        Inherits XtraUserControl

        Private aControl As AlertControl

        Private menu As PopupMenu

        Public Event AllowHtmlTextChanged As EventHandler

        Private _initValues As Boolean = False

        Public Sub New()
            InitializeComponent()
            InitProperties()
        End Sub

        Private Sub InitProperties()
            icbControlBoxPosition.Properties.Items.AddEnum(GetType(AlertFormControlBoxPosition))
            icbFormDisplaySpeed.Properties.Items.AddEnum(GetType(AlertFormDisplaySpeed))
            icbFormLocation.Properties.Items.AddEnum(GetType(AlertFormLocation))
            icbShowAnimationType.Properties.Items.AddEnum(GetType(AlertFormShowingEffect))
            icbHideAnimationType.Properties.Items.AddEnum(GetType(AlertFormShowingEffect))
        End Sub

        Public Sub InitValues(ByVal control As AlertControl)
            _initValues = True
            aControl = control
            menu = control.PopupMenu
            seAutoFormDelay.EditValue = aControl.AutoFormDelay
            icbControlBoxPosition.EditValue = aControl.ControlBoxPosition
            icbFormDisplaySpeed.EditValue = aControl.FormDisplaySpeed
            icbFormLocation.EditValue = aControl.FormLocation
            icbShowAnimationType.EditValue = aControl.ShowAnimationType
            icbHideAnimationType.EditValue = aControl.HideAnimationType
            ceAllowHtmlText.Checked = aControl.AllowHtmlText
            ceShowCloseButton.Checked = aControl.ShowCloseButton
            ceShowPinButton.Checked = aControl.ShowPinButton
            ceShowTooltips.Checked = aControl.ShowToolTips
            ceShowPopupMenu.Checked = menu IsNot Nothing
            ceAutoHeight.Checked = aControl.AutoHeight
            seFormMaxCount.Value = aControl.FormMaxCount
            For Each btn As AlertButton In aControl.Buttons
                ccbeButtons.Properties.Items.Add(btn.Name, btn.Name, If(btn.Visible, CheckState.Checked, CheckState.Unchecked), True)
            Next

            _initValues = False
            RaiseAllowHtmlTextChanged()
        End Sub

        '<seAutoFormDelay>
        Private Sub seAutoFormDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues OrElse aControl Is Nothing Then Return
            aControl.AutoFormDelay = Convert.ToInt32(seAutoFormDelay.Value)
        End Sub

        '</seAutoFormDelay>
        '<icbControlBoxPosition>
        Private Sub icbControlBoxPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.ControlBoxPosition = CType(icbControlBoxPosition.EditValue, AlertFormControlBoxPosition)
        End Sub

        '</icbControlBoxPosition>
        '<icbFormDisplaySpeed>
        Private Sub icbFormDisplaySpeed_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.FormDisplaySpeed = CType(icbFormDisplaySpeed.EditValue, AlertFormDisplaySpeed)
        End Sub

        '</icbFormDisplaySpeed>
        '<icbFormLocation>
        Private Sub icbFormLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.FormLocation = CType(icbFormLocation.EditValue, AlertFormLocation)
        End Sub

        '</icbFormLocation>
        '<ceAllowHtmlText>
        Private Sub ceAllowHtmlText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.AllowHtmlText = ceAllowHtmlText.Checked
            RaiseAllowHtmlTextChanged()
        End Sub

        '</ceAllowHtmlText>
        Private Sub RaiseAllowHtmlTextChanged()
            RaiseEvent AllowHtmlTextChanged(Me, EventArgs.Empty)
        End Sub

        '<ceShowCloseButton>
        Private Sub ceShowCloseButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.ShowCloseButton = ceShowCloseButton.Checked
        End Sub

        '</ceShowCloseButton>
        '<ceShowPinButton>
        Private Sub ceShowPinButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.ShowPinButton = ceShowPinButton.Checked
        End Sub

        '</ceShowPinButton>
        '<ceShowPopupMenu>
        Private Sub ceShowPopupMenu_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            If ceShowPopupMenu.Checked Then
                aControl.PopupMenu = menu
            Else
                aControl.PopupMenu = Nothing
            End If
        End Sub

        '</ceShowPopupMenu>
        '<ceShowTooltips>
        Private Sub ceShowTooltips_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.ShowToolTips = ceShowTooltips.Checked
        End Sub

        '</ceShowTooltips>
        '<ccbeButtons>
        Private Sub ccbeButtons_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues OrElse aControl Is Nothing Then Return
            For Each btn As AlertButton In aControl.Buttons
                btn.Visible = ccbeButtons.Text.IndexOf(btn.Name) >= 0
            Next
        End Sub

        '</ccbeButtons>
        Private Sub ceAutoHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.AutoHeight = ceAutoHeight.Checked
        End Sub

        Private Sub seFormMaxCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.FormMaxCount = CInt(seFormMaxCount.Value)
        End Sub

        Public ReadOnly Property AutoCloseFormOnClick As Boolean
            Get
                Return ceAutoClose.Checked
            End Get
        End Property

        Private Sub icbHideAnimationType_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.HideAnimationType = CType(icbHideAnimationType.EditValue, AlertFormShowingEffect)
        End Sub

        Private Sub icbShowAnimationType_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            aControl.ShowAnimationType = CType(icbShowAnimationType.EditValue, AlertFormShowingEffect)
        End Sub
    End Class
End Namespace
