Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraGrid.Views.Tile

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class LookUpProperties
        Inherits XtraUserControl

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Public Sub New(ByVal lookUp As GridLookUpEdit)
            InitializeComponent()
            InitComboBoxes()
            InitLookUp(lookUp)
        End Sub

        Private lookUpProperties As RepositoryItemGridLookUpEdit

        Private updateValues As Boolean = False

        Public Sub InitLookUp(ByVal lookUp As GridLookUpEdit)
            If lookUp Is Nothing Then Return
            lookUpProperties = lookUp.Properties
            updateValues = True
            lbDisplay.Text = lookUpProperties.DisplayMember
            lbValue.Text = lookUpProperties.ValueMember
            icbTextEditStyle.EditValue = lookUpProperties.TextEditStyle
            ceAutoComplete.Checked = lookUpProperties.AutoComplete
            ceImmediatePopup.Checked = lookUpProperties.ImmediatePopup
            cePopupSizeable.Checked = lookUpProperties.PopupSizeable
            ceShowPopupFooter.Checked = lookUpProperties.ShowFooter
            If GridView Is Nothing Then groupControlGridView.HideToCustomization()
            If TileView Is Nothing Then groupControlTiles.HideToCustomization()
            If GridView IsNot Nothing Then
                ceShowAutoFilterRow.Checked = GridView.OptionsView.ShowAutoFilterRow
                ceShowColumnHeaders.Checked = GridView.OptionsView.ShowColumnHeaders
                ceShowIndicator.Checked = GridView.OptionsView.ShowIndicator
                ceShowHorzLines.Checked = GridView.OptionsView.ShowHorizontalLines <> DefaultBoolean.False
                ceShowVerticalLines.Checked = GridView.OptionsView.ShowVerticalLines <> DefaultBoolean.False
                ceEnableAppearanceEvenRow.Checked = GridView.OptionsView.EnableAppearanceEvenRow
                ceEnableAppearanceOddRow.Checked = GridView.OptionsView.EnableAppearanceOddRow
            End If

            If TileView IsNot Nothing Then
                ceShowSeparators.Checked = TileView.OptionsList.DrawItemSeparators <> DrawItemSeparatorsMode.None
                ceHighlightFocused.Checked = TileView.OptionsTiles.HighlightFocusedTileStyle = HighlightFocusedTileStyle.Default
                ceShowContextButton.Checked = TileView.ContextButtons(0).Visibility <> ContextItemVisibility.Hidden
                ceListLayout.Checked = TileView.OptionsTiles.LayoutMode = TileViewLayoutMode.List
            End If

            EnableProperties()
            updateValues = False
        End Sub

        Private ReadOnly Property TileView As Views.Tile.TileView
            Get
                Dim view As Views.Tile.TileView = TryCast(lookUpProperties.PopupView, Views.Tile.TileView)
                Return view
            End Get
        End Property

        Private ReadOnly Property GridView As GridView
            Get
                Dim view As GridView = TryCast(lookUpProperties.View, GridView)
                Return view
            End Get
        End Property

        Private Sub InitComboBoxes()
            For Each style As TextEditStyles In [Enum].GetValues(GetType(TextEditStyles))
                icbTextEditStyle.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of TextEditStyles).GetTitle(style), style, -1))
            Next
        End Sub

        Private Sub EnableProperties()
            cePopupSizeable.Enabled = lookUpProperties.ShowFooter
        End Sub

        Private Sub LookUpProperties_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        '<icbTextEditStyle>
        Private Sub icbTextEditStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.TextEditStyle = CType(icbTextEditStyle.EditValue, TextEditStyles)
        End Sub

        '</icbTextEditStyle>
        '<ceImmediatePopup>
        Private Sub ceImmediatePopup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.ImmediatePopup = ceImmediatePopup.Checked
        End Sub

        '</ceImmediatePopup>
        '<cePopupSizeable>
        Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.PopupSizeable = cePopupSizeable.Checked
        End Sub

        '</cePopupSizeable>
        '<ceShowPopupFooter>
        Private Sub ceShowPopupFooter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.ShowFooter = ceShowPopupFooter.Checked
            EnableProperties()
        End Sub

        '</ceShowPopupFooter>
        '<ceShowAutoFilterRow>
        Private Sub ceShowAutoFilterRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            GridView.OptionsView.ShowAutoFilterRow = ceShowAutoFilterRow.Checked
        End Sub

        '</ceShowAutoFilterRow>
        '<ceShowColumnHeaders>
        Private Sub ceShowColumnHeaders_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            GridView.OptionsView.ShowColumnHeaders = ceShowColumnHeaders.Checked
        End Sub

        '</ceShowColumnHeaders>
        '<ceShowIndicator>
        Private Sub ceShowIndicator_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            GridView.OptionsView.ShowIndicator = ceShowIndicator.Checked
        End Sub

        '</ceShowIndicator>
        '<ceShowHorzLines>
        Private Sub ceShowHorzLines_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            GridView.OptionsView.ShowHorizontalLines = If(ceShowHorzLines.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</ceShowHorzLines>
        '<ceShowVerticalLines>
        Private Sub ceShowVerticalLines_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            GridView.OptionsView.ShowVerticalLines = If(ceShowVerticalLines.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</ceShowVerticalLines>
        '<ceEnableAppearanceEvenRow>
        Private Sub ceEnableAppearanceEvenRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            GridView.OptionsView.EnableAppearanceEvenRow = ceEnableAppearanceEvenRow.Checked
        End Sub

        '</ceEnableAppearanceEvenRow>
        '<ceEnableAppearanceOddRow>
        Private Sub ceEnableAppearanceOddRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            GridView.OptionsView.EnableAppearanceOddRow = ceEnableAppearanceOddRow.Checked
        End Sub

        '</ceEnableAppearanceOddRow>
        '<ceAutoComplete>
        Private Sub ceAutoComplete_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.AutoComplete = ceAutoComplete.Checked
        End Sub

        '</ceAutoComplete>
        Private Sub ceShowSeparators_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            Dim value = If(ceShowSeparators.Checked, DrawItemSeparatorsMode.All, DrawItemSeparatorsMode.None)
            TileView.OptionsList.DrawItemSeparators = value
        End Sub

        Private Sub ceHighlightFocused_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            Dim value = If(ceHighlightFocused.Checked, HighlightFocusedTileStyle.Default, HighlightFocusedTileStyle.None)
            TileView.OptionsTiles.HighlightFocusedTileStyle = value
        End Sub

        Private Sub ceListLayout_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            TileView.OptionsTiles.LayoutMode = If(ceListLayout.Checked, TileViewLayoutMode.List, TileViewLayoutMode.Default)
        End Sub

        Private Sub ceShowContextButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            TileView.ContextButtons(0).Visibility = If(ceShowContextButton.Checked, ContextItemVisibility.Auto, ContextItemVisibility.Hidden)
        End Sub
    End Class
End Namespace
