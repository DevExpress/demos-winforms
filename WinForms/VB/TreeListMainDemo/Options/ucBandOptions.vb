Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.XtraTreeList.Demos.Options

    Public Partial Class ucBandOptions
        Inherits ucDefault

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub InitDataCore()
            '<layoutControl.lgView>
            ceShowBands.Checked = If(TreeList.OptionsView.ShowBandsMode = Utils.DefaultBoolean.False, False, True)
            ceAllowBandColumnsMultiRow.Checked = TreeList.OptionsView.AllowBandColumnsMultiRow
            '</layoutControl.lgView>
            '<layoutControl.lgCustomization>
            ceAllowBandMoving.Checked = TreeList.OptionsCustomization.AllowBandMoving
            ceAllowBandResizing.Checked = TreeList.OptionsCustomization.AllowBandResizing
            ceAllowChangeBandParent.Checked = TreeList.OptionsCustomization.AllowChangeBandParent
            ceAllowChangeColumnParent.Checked = TreeList.OptionsCustomization.AllowChangeColumnParent
            ceShowBandsInCustomizationForm.Checked = TreeList.OptionsCustomization.ShowBandsInCustomizationForm
            ceCustomizationFormSearchBoxVisible.Checked = TreeList.OptionsCustomization.CustomizationFormSearchBoxVisible
            ceAllowColumnMoving.Checked = TreeList.OptionsCustomization.AllowColumnMoving
            ceAllowColumnResizing.Checked = TreeList.OptionsCustomization.AllowColumnResizing
        '</layoutControl.lgCustomization>
        End Sub

        Private Sub ceAllowBandMoving_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsCustomization.AllowBandMoving = ceAllowBandMoving.Checked
        End Sub

        Private Sub ceAllowBandResizing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsCustomization.AllowBandResizing = ceAllowBandResizing.Checked
        End Sub

        Private Sub ceAllowChangeBandParent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsCustomization.AllowChangeBandParent = ceAllowChangeBandParent.Checked
        End Sub

        Private Sub ceAllowChangeColumnParent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsCustomization.AllowChangeColumnParent = ceAllowChangeColumnParent.Checked
        End Sub

        Private Sub ceAllowColumnMoving_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsCustomization.AllowColumnMoving = ceAllowColumnMoving.Checked
        End Sub

        Private Sub ceAllowColumnResizing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsCustomization.AllowColumnResizing = ceAllowColumnResizing.Checked
        End Sub

        Private Sub ceShowBandsInCustomizationForm_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsCustomization.ShowBandsInCustomizationForm = ceShowBandsInCustomizationForm.Checked
            If TreeList.CustomizationForm IsNot Nothing AndAlso TreeList.CustomizationForm.Visible Then
                TreeList.DestroyCustomization()
                TreeList.ColumnsCustomization()
            End If
        End Sub

        Private Sub ceCustomizationFormSearchBoxVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsCustomization.CustomizationFormSearchBoxVisible = ceCustomizationFormSearchBoxVisible.Checked
            If TreeList.CustomizationForm IsNot Nothing AndAlso TreeList.CustomizationForm.Visible Then
                TreeList.DestroyCustomization()
                TreeList.ColumnsCustomization()
            End If
        End Sub

        Private Sub ceShowBands_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsView.ShowBandsMode = If(ceShowBands.Checked, Utils.DefaultBoolean.True, Utils.DefaultBoolean.False)
        End Sub

        Private Sub ceAllowBandColumnsMultiRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsView.AllowBandColumnsMultiRow = ceAllowBandColumnsMultiRow.Checked
        End Sub
    End Class
End Namespace
