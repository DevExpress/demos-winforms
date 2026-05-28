Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.DXperience.Demos
Imports DevExpress.Data.Filtering

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class ucFindOptions
        Inherits XtraUserControl

        Private view As GridView = Nothing

        Private ReadOnly customButtonName As String = "customButton"

        Public Sub New()
            InitializeComponent()
            InitEditors()
        End Sub

        Private updateValues As Boolean = False

        Public Sub InitData(ByVal view As GridView, ByVal findFilterColumns As List(Of ImageComboBoxItem))
            Me.view = view
            cbFindFilterColumns.Properties.Items.AddRange(findFilterColumns)
            updateValues = True
            icbFindPanelBehavior.EditValue = view.OptionsFind.Behavior
            ceAllowFindFilter.Checked = view.OptionsFind.AllowFindPanel
            ceAllowMRUItems.Checked = view.OptionsFind.AllowMruItems
            ceAlwaysVisible.Checked = view.OptionsFind.AlwaysVisible
            ceClearFind.Checked = view.OptionsFind.ClearFindOnClose
            ceHighlightFindResults.Checked = view.OptionsFind.HighlightFindResults
            ceShowCloseButton.Checked = view.OptionsFind.ShowCloseButton
            seFindDelay.Value = view.OptionsFind.FindDelay
            cbFindFilterColumns.EditValue = view.OptionsFind.FindFilterColumns
            icbFindMode.EditValue = view.OptionsFind.FindMode
            ceShowClearButton.Checked = view.OptionsFind.ShowClearButton
            ceShowFindButton.Checked = view.OptionsFind.ShowFindButton
            ceShowNavButtons.Checked = view.OptionsFind.ShowSearchNavButtons
            ceSearchInPreview.Checked = view.OptionsFind.SearchInPreview
            icbParserKind.EditValue = view.OptionsFind.ParserKind
            icbFilterCondition.EditValue = view.OptionsFind.Condition
            updateValues = False
            InitValues()
        End Sub

        Private Sub InitEditors()
            For Each mode As FindMode In [Enum].GetValues(GetType(FindMode))
                icbFindMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FindMode).GetTitle(mode), mode, -1))
            Next

            For Each b As FindPanelBehavior In [Enum].GetValues(GetType(FindPanelBehavior))
                icbFindPanelBehavior.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FindPanelBehavior).GetTitle(b), b, -1))
            Next

            For Each kind As FindPanelParserKind In [Enum].GetValues(GetType(FindPanelParserKind))
                icbParserKind.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FindPanelParserKind).GetTitle(kind), kind, -1))
            Next

            For Each condition As FilterCondition In [Enum].GetValues(GetType(FilterCondition))
                icbFilterCondition.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FilterCondition).GetTitle(condition), condition, -1))
            Next
        End Sub

        Public ReadOnly Property MinHeight As Integer
            Get
                Return layoutControl1.Root.MinSize.Height
            End Get
        End Property

        Private Sub InitValues()
            Dim isSearchMode As Boolean = view.OptionsFind.Behavior = FindPanelBehavior.Search
            ceAlwaysVisible.Enabled = view.OptionsFind.AllowFindPanel
            If Not view.OptionsFind.AllowFindPanel Then
                ceAlwaysVisible.Checked = False
                view.HideFindPanel()
            Else
                view.ShowFindPanel()
            End If

            ceShowCloseButton.Enabled = Not view.OptionsFind.AlwaysVisible
            ceShowClearButton.Enabled = Not isSearchMode
            ceShowFindButton.Enabled = Not isSearchMode
            ceShowNavButtons.Enabled = isSearchMode
        End Sub

        '<ceAllowFindFilter>
        Private Sub ceAllowFindFilter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.AllowFindPanel = edit.Checked
            InitValues()
        End Sub

        '</ceAllowFindFilter>
        '<ceAlwaysVisible>
        Private Sub ceAlwaysVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.AlwaysVisible = edit.Checked
            InitValues()
        End Sub

        '</ceAlwaysVisible>
        '<ceClearFind>
        Private Sub ceClearFind_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.ClearFindOnClose = edit.Checked
        End Sub

        '</ceClearFind>
        '<ceHighlightFindResults>
        Private Sub ceHighlightFindResults_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.HighlightFindResults = edit.Checked
        End Sub

        '</ceHighlightFindResults>
        '<ceShowCloseButton>
        Private Sub ceShowCloseButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.ShowCloseButton = edit.Checked
        End Sub

        '</ceShowCloseButton>
        '<seFindDelay>
        Private Sub seFindDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As SpinEdit = TryCast(sender, SpinEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.FindDelay = Convert.ToInt32(edit.Value)
        End Sub

        '</seFindDelay>
        '<cbFindFilterColumns>
        Private Sub cbFindFilterColumns_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As BaseEdit = TryCast(sender, BaseEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.FindFilterColumns = String.Format("{0}", edit.EditValue)
            RefreshFindFilter()
        End Sub

        Private Sub RefreshFindFilter()
            Dim findText As String = view.FindFilterText
            view.ApplyFindFilter(String.Empty)
            view.ApplyFindFilter(findText)
        End Sub

        '</cbFindFilterColumns>
        '<icbFindMode>
        Private Sub icbFindMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As BaseEdit = TryCast(sender, BaseEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.FindMode = CType(edit.EditValue, FindMode)
        End Sub

        '</icbFindMode>
        '<ceShowClearButton>
        Private Sub ceShowClearButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.ShowClearButton = edit.Checked
        End Sub

        '</ceShowClearButton>
        '<ceShowFindButton>
        Private Sub ceShowFindButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.ShowFindButton = edit.Checked
        End Sub

        '</ceShowFindButton>
        '<ceShowNavButtons>
        Private Sub ceShowNavButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.ShowSearchNavButtons = edit.Checked
        End Sub

        '</ceShowNavButtons>
        '<ceSearchInPreview>
        Private Sub ceSearchInPreview_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsView.ShowPreview = edit.Checked
            view.OptionsFind.SearchInPreview = edit.Checked
        End Sub

        '</ceSearchInPreview>
        '<icbFindPanelBehavior>
        Private Sub icbFindPanelBehavior_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As BaseEdit = TryCast(sender, BaseEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.Behavior = CType(edit.EditValue, FindPanelBehavior)
            InitValues()
        End Sub

        '</icbFindPanelBehavior>
        '<icbParserKind>
        Private Sub icbParserKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As BaseEdit = TryCast(sender, BaseEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.ParserKind = CType(edit.EditValue, FindPanelParserKind)
            RefreshFindFilter()
        End Sub

        '</icbParserKind>
        '<icbFilterCondition>
        Private Sub icbFilterCondition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As BaseEdit = TryCast(sender, BaseEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.Condition = CType(edit.EditValue, FilterCondition)
            RefreshFindFilter()
        End Sub

        '</icbFilterCondition>
        '<ceAllowMRUItems>
        Private Sub ceAllowMRUItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            If updateValues OrElse view Is Nothing OrElse edit Is Nothing Then Return
            view.OptionsFind.AllowMruItems = edit.Checked
        End Sub

        '</ceAllowMRUItems>
        '<ceShowCustomButton>
        Private showCustomButton As CheckButton = Nothing

        Private Sub ceShowCustomButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim customButton As CheckEdit = TryCast(sender, CheckEdit)
            If customButton.Checked Then
                showCustomButton = view.FindPanelItems.AddCheckButton(customButtonName, Nothing, view.OptionsFind.Behavior <> FindPanelBehavior.Search, Sub(button, args)
                    Dim checkButton As CheckButton = TryCast(button, CheckButton)
                    view.OptionsFind.Behavior = If(checkButton.Checked, FindPanelBehavior.Filter, FindPanelBehavior.Search)
                    checkButton.ToolTip = "Find Panel Mode"
                    icbFindPanelBehavior.EditValue = view.OptionsFind.Behavior
                End Sub)
                showCustomButton.ImageOptions.ImageUri.Uri = "Filter;Size16x16;Svg"
            Else
                showCustomButton = Nothing
                view.FindPanelItems.RemoveItem(customButtonName)
            End If

            icbFindPanelBehavior.Enabled = showCustomButton Is Nothing
        End Sub
    '</ceShowCustomButton>
    End Class
End Namespace
