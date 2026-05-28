Imports System
Imports DataFiltering = DevExpress.Data.Filtering
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTreeList.Columns
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace DevExpress.XtraTreeList.Demos.Options

    Public Partial Class ucFindOptions
        Inherits ucDefault

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub InitDataCore()
            '<layoutControl.customizationLayoutGroup>
            ceAllowFindPanel.Checked = TreeList.OptionsFind.AllowFindPanel
            BindTo(ceHighlightFindResults, "Checked", TreeList.OptionsFind, "HighlightFindResults")
            BindTo(ceShowCloseButton, "Checked", TreeList.OptionsFind, "ShowCloseButton")
            BindTo(ceShowClearButton, "Checked", TreeList.OptionsFind, "ShowClearButton")
            BindTo(ceShowFindButton, "Checked", TreeList.OptionsFind, "ShowFindButton")
            BindTo(ceShowSearchNavButtons, "Checked", TreeList.OptionsFind, "ShowSearchNavButtons")
            ceExpandNodesOnSearch.Checked = TreeList.OptionsFind.ExpandNodesOnSearch <> DefaultBoolean.False
            '</layoutControl.customizationLayoutGroup>
            '<layoutControl.lgBehavior>
            InitImageComboBox(Of DataFiltering.FilterCondition)(imgFilterCondition, TreeList.OptionsFind.Condition)
            BindTo(imgFilterCondition, "EditValue", TreeList.OptionsFind, "Condition")
            InitImageComboBox(Of DataFiltering.FindPanelParserKind)(imgParserKind, TreeList.OptionsFind.ParserKind)
            BindTo(imgParserKind, "EditValue", TreeList.OptionsFind, "ParserKind")
            InitImageComboBox(Of XtraEditors.FindPanelBehavior)(imgBehavior, TreeList.OptionsFind.Behavior)
            '</layoutControl.lgBehavior>
            '<layoutControl.actionLayoutGroup>
            ceAlwaysVisible.Checked = TreeList.OptionsFind.AlwaysVisible
            BindTo(ceClearFindPanelOnClose, "Checked", TreeList.OptionsFind, "ClearFindOnClose")
            InitImageComboBox(Of FindMode)(cbFindMode, TreeList.OptionsFind.FindMode)
            BindTo(cbFindMode, "EditValue", TreeList.OptionsFind, "FindMode")
            '</layoutControl.actionLayoutGroup>
            InitFindFilterColumns(TreeList.Columns)
            InitValues()
            UpdateFindPanelButtons()
        End Sub

        Private Sub BindTo(ByVal source As Control, ByVal propertyName As String, ByVal target As Object, ByVal member As String)
            source.DataBindings.Add(propertyName, target, member, False, DataSourceUpdateMode.OnPropertyChanged)
        End Sub

        Private Sub InitImageComboBox(Of TEnum)(ByVal comboBox As XtraEditors.ImageComboBoxEdit, ByVal value As Object)
            comboBox.EditValue = value
            comboBox.Properties.AddEnum(Of TEnum)()
        End Sub

        Private Sub InitFindFilterColumns(ByVal findFilterColumns As TreeListColumnCollection)
            cbFindFilterColumns.Properties.Items.Add(New ImageComboBoxItem("*", "*"))
            For i As Integer = 0 To findFilterColumns.Count - 1
                Dim captions As String = findFilterColumns(i).GetCaption()
                Dim fieldNames As String = findFilterColumns(i).FieldName
                For j As Integer = i To findFilterColumns.Count - 1
                    If j <> i Then
                        captions += String.Format(";{0}", findFilterColumns(j).GetCaption())
                        fieldNames += String.Format(";{0}", findFilterColumns(j).FieldName)
                    End If

                    cbFindFilterColumns.Properties.Items.Add(New ImageComboBoxItem(captions, fieldNames))
                Next
            Next

            cbFindFilterColumns.EditValue = TreeList.OptionsFind.FindFilterColumns
        End Sub

        '<layoutControl.customizationLayoutGroup>
        Private Sub ceAllowFindPanel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsFind.AllowFindPanel = ceAllowFindPanel.Checked
            InitValues()
        End Sub

        Private Sub ceExpandNodesOnSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TreeList.OptionsFind.ExpandNodesOnSearch = If(ceExpandNodesOnSearch.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</layoutControl.customizationLayoutGroup>
        Private Sub InitValues()
            ceAlwaysVisible.Enabled = TreeList.OptionsFind.AllowFindPanel
            If Not TreeList.OptionsFind.AllowFindPanel Then
                ceAlwaysVisible.Checked = False
                TreeList.HideFindPanel()
            Else
                TreeList.ShowFindPanel()
            End If

            ceShowCloseButton.Enabled = Not TreeList.OptionsFind.AlwaysVisible
        End Sub

        '<layoutControl.actionLayoutGroup>
        Private Sub ceAlwaysVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsFind.AlwaysVisible = ceAlwaysVisible.Checked
            InitValues()
        End Sub

        Private Sub seFindDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsFind.FindDelay = Convert.ToInt32(seFindDelay.Value)
        End Sub

        Private Sub cbFindFilterColumns_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsFind.FindFilterColumns = String.Format("{0}", cbFindFilterColumns.EditValue)
            Dim findText As String = TreeList.FindFilterText
            TreeList.ApplyFindFilter(String.Empty)
            TreeList.ApplyFindFilter(findText)
        End Sub

        '</layoutControl.actionLayoutGroup>
        '<layoutControl.lgBehavior>
        Private Sub imgBehavior_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsInitializing OrElse TreeList Is Nothing Then Return
            TreeList.OptionsFind.Behavior = CType(imgBehavior.EditValue, XtraEditors.FindPanelBehavior)
            UpdateFindPanelButtons()
        End Sub

        '</layoutControl.lgBehavior>
        Private Sub UpdateFindPanelButtons()
            ceShowClearButton.Enabled = TreeList.OptionsFind.Behavior <> XtraEditors.FindPanelBehavior.Search
            ceShowFindButton.Enabled = ceShowClearButton.Enabled
            ceShowSearchNavButtons.Enabled = TreeList.OptionsFind.Behavior = XtraEditors.FindPanelBehavior.Search
        End Sub
    End Class
End Namespace
