Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace DevExpress.XtraTreeList.Demos.Options

    Public Partial Class ucBandOptions
        Inherits ucDefault

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub InitDataCore()
            '<layoutControl.lgView>
            ceShowBands.Checked = If(TreeList.OptionsView.ShowBandsMode = DefaultBoolean.False, False, True)
            ceAllowBandColumnsMultiRow.Checked = TreeList.OptionsView.AllowBandColumnsMultiRow
            '</layoutControl.lgView>
            '<layoutControl.lgCustomization>
            ceAllowBandMoving.Checked = TreeList.OptionsCustomization.AllowBandMoving
            ceAllowBandResizing.Checked = TreeList.OptionsCustomization.AllowBandResizing
            ceAllowChangeBandParent.Checked = TreeList.OptionsCustomization.AllowChangeBandParent
            ceAllowChangeColumnParent.Checked = TreeList.OptionsCustomization.AllowChangeColumnParent
            ceAllowColumnMoving.Checked = TreeList.OptionsCustomization.AllowColumnMoving
            ceAllowColumnResizing.Checked = TreeList.OptionsCustomization.AllowColumnResizing
            icbCustomizationFormKind.DataBindings.Add("EditValue", TreeList.OptionsCustomization, "UseAdvancedCustomizationForm", False, DataSourceUpdateMode.OnPropertyChanged)
            ceShowBandsInCustomizationForm.Checked = TreeList.OptionsCustomization.ShowBandsInCustomizationForm
            ceCustomizationFormSearchBoxVisible.Checked = TreeList.OptionsCustomization.CustomizationFormSearchBoxVisible
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
            RecreateCustomizationForm()
        End Sub

        Private Sub ceCustomizationFormSearchBoxVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsCustomization.CustomizationFormSearchBoxVisible = ceCustomizationFormSearchBoxVisible.Checked
            RecreateCustomizationForm()
        End Sub

        Private Sub icbCustomizationFormKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            UpdateClassicCustomizationFormOptionsEnabled()
            RecreateCustomizationForm()
        End Sub

        Private Sub RecreateCustomizationForm()
            If TreeList.CustomizationForm IsNot Nothing AndAlso TreeList.CustomizationForm.Visible Then
                TreeList.DestroyCustomization()
                TreeList.ColumnsCustomization()
            End If
        End Sub

        Private Sub UpdateClassicCustomizationFormOptionsEnabled()
            Dim enabled As Boolean = TreeList.OptionsCustomization.UseAdvancedCustomizationForm <> DefaultBoolean.True
            ceShowBandsInCustomizationForm.Enabled = enabled
            ceCustomizationFormSearchBoxVisible.Enabled = enabled
        End Sub

        Private Sub ceShowBands_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsView.ShowBandsMode = If(ceShowBands.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private Sub ceAllowBandColumnsMultiRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsView.AllowBandColumnsMultiRow = ceAllowBandColumnsMultiRow.Checked
        End Sub
    End Class
End Namespace
