Imports System

Namespace DevExpress.XtraTreeList.Demos.Options

    Public Partial Class ucFilterOptions
        Inherits ucDefault

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub InitDataCore()
            ceAllowFilter.Checked = TreeList.OptionsCustomization.AllowFilter
            ceAutoFilterRow.Checked = TreeList.OptionsView.ShowAutoFilterRow
            ceFilterEditor.Checked = TreeList.OptionsFilter.AllowFilterEditor
            ceFilterList.Checked = TreeList.OptionsFilter.AllowMRUFilterList
            ceShowAllValuesInFilterPopup.Checked = TreeList.OptionsFilter.ShowAllValuesInFilterPopup
            cbFilterMode.Properties.Items.AddEnum(GetType(FilterMode))
            cbFilterMode.EditValue = TreeList.OptionsFilter.FilterMode
            ieShowFilterPanelMode.Properties.Items.AddEnum(GetType(ShowFilterPanelMode))
            ieShowFilterPanelMode.EditValue = TreeList.OptionsView.ShowFilterPanelMode
            InitEnabled()
        End Sub

        Private isLoaded As Boolean

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            isLoaded = True
        End Sub

        Private Sub InitEnabled()
            ceShowAllValuesInFilterPopup.Enabled = ceAllowFilter.Checked
            cbFilterMode.Enabled = ceShowAllValuesInFilterPopup.Enabled
            ieShowFilterPanelMode.Enabled = cbFilterMode.Enabled
            ceAutoFilterRow.Enabled = ieShowFilterPanelMode.Enabled
            ceFilterList.Enabled = ceAutoFilterRow.Enabled
            ceFilterEditor.Enabled = ceFilterList.Enabled
            ceColumnFilterList.Enabled = ceFilterEditor.Enabled
        End Sub

        '<ceAllowFilter>
        Private Sub ceAllowFilter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TreeList.OptionsCustomization.AllowFilter = ceAllowFilter.Checked
            If isLoaded Then
                Dim allow As Boolean = TreeList.OptionsCustomization.AllowFilter
                If Not allow Then
                    TreeList.HideFindPanel()
                Else
                    If TreeList.OptionsFind.AllowFindPanel Then TreeList.ShowFindPanel()
                End If

                TreeList.OptionsView.ShowAutoFilterRow = If(allow, ceAutoFilterRow.Checked, False)
                InitEnabled()
            End If
        End Sub

        '</ceAllowFilter>
        '<ceFilterEditor>
        Private Sub ceFilterEditor_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsFilter.AllowFilterEditor = ceFilterEditor.Checked
        End Sub

        '</ceFilterEditor>
        '<ceFilterList>
        Private Sub ceFilterList_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsFilter.AllowMRUFilterList = ceFilterList.Checked
        End Sub

        '</ceFilterList>
        '<ceAutoFilterRow>
        Private Sub ceAutoFilterRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsView.ShowAutoFilterRow = ceAutoFilterRow.Checked
        End Sub

        '<cbFilterMode>
        Private Sub cbFilterMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsFilter.FilterMode = CType(cbFilterMode.EditValue, FilterMode)
        End Sub

        '</cbFilterMode>       
        Private Sub ceShowAllValuesInFilterPopup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsFilter.ShowAllValuesInFilterPopup = ceShowAllValuesInFilterPopup.Checked
        End Sub

        Private Sub ieShowFilterPanelMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsView.ShowFilterPanelMode = CType(ieShowFilterPanelMode.SelectedIndex, ShowFilterPanelMode)
        End Sub

        '<ceColumnFilterList>
        Private Sub ceColumnFilterList_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TreeList.OptionsFilter.AllowColumnMRUFilterList = ceColumnFilterList.Checked
        End Sub
    '</ceColumnFilterList>
    End Class
End Namespace
