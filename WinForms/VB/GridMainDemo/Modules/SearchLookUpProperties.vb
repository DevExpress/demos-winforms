Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class SearchLookUpProperties
        Inherits XtraUserControl

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Public Sub New(ByVal lookUp As SearchLookUpEdit)
            Me.New(lookUp, True)
        End Sub

        Public Sub New(ByVal lookUp As SearchLookUpEdit, ByVal showAddNewButton As Boolean)
            InitializeComponent()
            InitComboBoxes()
            InitLookUp(lookUp)
            ceShowAddNewButton.Enabled = showAddNewButton
        End Sub

        Private lookUpProperties As RepositoryItemSearchLookUpEdit

        Private updateValues As Boolean = False

        Public Sub InitLookUp(ByVal lookUp As SearchLookUpEdit)
            If lookUp Is Nothing Then Return
            lookUpProperties = lookUp.Properties
            updateValues = True
            lbDisplay.Text = lookUpProperties.DisplayMember
            lbValue.Text = lookUpProperties.ValueMember
            icbTextEditStyle.EditValue = lookUpProperties.TextEditStyle
            icbFilterMode.EditValue = lookUpProperties.PopupFilterMode
            icbFindMode.EditValue = lookUpProperties.PopupFindMode
            cePopupSizeable.Checked = lookUpProperties.PopupSizeable
            ceShowPopupFooter.Checked = lookUpProperties.ShowFooter
            ceShowAddNewButton.Checked = lookUpProperties.ShowAddNewButton
            ceShowClearButton.Checked = lookUpProperties.ShowClearButton
            ceShowAutoFilterRow.Checked = View.OptionsView.ShowAutoFilterRow
            ceShowColumnHeaders.Checked = View.OptionsView.ShowColumnHeaders
            ceShowIndicator.Checked = View.OptionsView.ShowIndicator
            ceShowHorzLines.Checked = View.OptionsView.ShowHorizontalLines <> DefaultBoolean.False
            ceShowVerticalLines.Checked = View.OptionsView.ShowVerticalLines <> DefaultBoolean.False
            ceEnableAppearanceEvenRow.Checked = View.OptionsView.EnableAppearanceEvenRow
            ceEnableAppearanceOddRow.Checked = View.OptionsView.EnableAppearanceOddRow
            EnableProperties()
            updateValues = False
        End Sub

        Private ReadOnly Property View As GridView
            Get
                Dim viewCore As GridView = TryCast(lookUpProperties.View, GridView)
                Return viewCore
            End Get
        End Property

        Private Sub InitComboBoxes()
            For Each style As TextEditStyles In [Enum].GetValues(GetType(TextEditStyles))
                If style <> TextEditStyles.Standard Then icbTextEditStyle.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of TextEditStyles).GetTitle(style), style, -1))
            Next

            For Each mode As PopupFilterMode In [Enum].GetValues(GetType(PopupFilterMode))
                icbFilterMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of PopupFilterMode).GetTitle(mode), mode, -1))
            Next

            For Each mode As FindMode In [Enum].GetValues(GetType(FindMode))
                icbFindMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FindMode).GetTitle(mode), mode, -1))
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
            View.OptionsView.ShowAutoFilterRow = ceShowAutoFilterRow.Checked
        End Sub

        '</ceShowAutoFilterRow>
        '<ceShowColumnHeaders>
        Private Sub ceShowColumnHeaders_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            View.OptionsView.ShowColumnHeaders = ceShowColumnHeaders.Checked
        End Sub

        '</ceShowColumnHeaders>
        '<ceShowIndicator>
        Private Sub ceShowIndicator_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            View.OptionsView.ShowIndicator = ceShowIndicator.Checked
        End Sub

        '</ceShowIndicator>
        '<ceShowHorzLines>
        Private Sub ceShowHorzLines_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            View.OptionsView.ShowHorizontalLines = If(ceShowHorzLines.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</ceShowHorzLines>
        '<ceShowVerticalLines>
        Private Sub ceShowVerticalLines_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            View.OptionsView.ShowVerticalLines = If(ceShowVerticalLines.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</ceShowVerticalLines>
        '<ceEnableAppearanceEvenRow>
        Private Sub ceEnableAppearanceEvenRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            View.OptionsView.EnableAppearanceEvenRow = ceEnableAppearanceEvenRow.Checked
        End Sub

        '</ceEnableAppearanceEvenRow>
        '<ceEnableAppearanceOddRow>
        Private Sub ceEnableAppearanceOddRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            View.OptionsView.EnableAppearanceOddRow = ceEnableAppearanceOddRow.Checked
        End Sub

        '</ceEnableAppearanceOddRow>
        '<ceShowAddNewButton>
        Private Sub ceShowAddNewButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.ShowAddNewButton = ceShowAddNewButton.Checked
        End Sub

        '</ceShowAddNewButton>
        '<ceShowClearButton>
        Private Sub ceShowClearButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.ShowClearButton = ceShowClearButton.Checked
        End Sub

        '</ceShowClearButton>
        '<icbFilterMode>
        Private Sub icbFilterMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.PopupFilterMode = CType(icbFilterMode.EditValue, PopupFilterMode)
        End Sub

        '</icbFilterMode>
        '<icbFindMode>
        Private Sub icbFindMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            lookUpProperties.PopupFindMode = CType(icbFindMode.EditValue, FindMode)
        End Sub
    '</icbFindMode>
    End Class
End Namespace
