Imports System
' <icbHeaderClickMode>
' <icbSearchMode>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

' </icbSearchMode>
' </icbHeaderClickMode>
Namespace DevExpress.XtraEditors.Demos

    Public Partial Class LookUpProperties
        Inherits XtraUserControl

        Private lookUpProperties As RepositoryItemLookUpEdit

        Private updateValues As Boolean = False

        Public Sub New()
            InitializeComponent()
            InitComboBoxes()
        End Sub

        Public Sub InitLookUp(ByVal lookUp As LookUpEdit)
            lookUpProperties = lookUp.Properties
            updateValues = True
            seColumnIndex.Properties.MaxValue = lookUpProperties.Columns.Count - 1
            seColumnIndex.Enabled = seColumnIndex.Properties.MaxValue > 0
            lbDisplay.Text = lookUpProperties.DisplayMember
            lbValue.Text = lookUpProperties.ValueMember
            seColumnIndex.Value = lookUpProperties.AutoSearchColumnIndex
            icbSearchMode.EditValue = lookUpProperties.SearchMode
            icbHeaderClickMode.EditValue = lookUpProperties.HeaderClickMode
            ceCaseSensitiveSearch.Checked = lookUpProperties.CaseSensitiveSearch
            seItemHeight.Value = lookUpProperties.DropDownItemHeight
            teNullText.Text = lookUpProperties.NullText
            ceHotTrack.Checked = lookUpProperties.HotTrackItems
            ceShowFooter.Checked = lookUpProperties.ShowFooter
            ceShowHeader.Checked = lookUpProperties.ShowHeader
            ceShowLines.Checked = lookUpProperties.ShowLines
            updateValues = False
        End Sub

        Private Sub InitComboBoxes()
            ' <icbHeaderClickMode>
            icbHeaderClickMode.Properties.Items.AddEnum(GetType(HeaderClickMode))
            ' </icbHeaderClickMode>
            ' <icbSearchMode>
            icbSearchMode.Properties.Items.AddEnum(GetType(SearchMode))
            ' </icbSearchMode>
            icbSearchMode.Properties.Items.RemoveAt(icbSearchMode.Properties.Items.Count - 1) ' Hide SearchMode.AutoSuggest
        End Sub

        ' <seColumnIndex>
        Private Sub seColumnIndex_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            lookUpProperties.AutoSearchColumnIndex = Convert.ToInt32(seColumnIndex.Value)
        End Sub

        ' </seColumnIndex>
        ' <icbHeaderClickMode>
        Private Sub icbHeaderClickMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            lookUpProperties.HeaderClickMode = CType(icbHeaderClickMode.EditValue, HeaderClickMode)
        End Sub

        ' </icbHeaderClickMode>
        ' <icbSearchMode>
        Private Sub icbSearchMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            lookUpProperties.SearchMode = CType(icbSearchMode.EditValue, SearchMode)
        End Sub

        ' </icbSearchMode>
        ' <ceCaseSensitiveSearch>
        Private Sub ceCaseSensitiveSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            lookUpProperties.CaseSensitiveSearch = ceCaseSensitiveSearch.Checked
        End Sub

        ' </ceCaseSensitiveSearch>
        ' <seItemHeight>
        Private Sub seItemHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            lookUpProperties.DropDownItemHeight = Convert.ToInt32(seItemHeight.Value)
        End Sub

        ' </seItemHeight>
        ' <teNullText>
        Private Sub teNullText_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            lookUpProperties.NullText = teNullText.Text
        End Sub

        ' </teNullText>
        ' <ceHotTrack>
        Private Sub ceHotTrack_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            lookUpProperties.HotTrackItems = ceHotTrack.Checked
        End Sub

        ' </ceHotTrack>
        ' <ceShowFooter>
        Private Sub ceShowFooter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            lookUpProperties.ShowFooter = ceShowFooter.Checked
        End Sub

        ' </ceShowFooter>
        ' <ceShowHeader>
        Private Sub ceShowHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            lookUpProperties.ShowHeader = ceShowHeader.Checked
        End Sub

        ' </ceShowHeader>
        ' <ceShowLines>
        Private Sub ceShowLines_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            lookUpProperties.ShowLines = ceShowLines.Checked
        End Sub
    ' </ceShowLines>
    End Class
End Namespace
