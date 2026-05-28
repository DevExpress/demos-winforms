Imports System
Imports System.ComponentModel
Imports System.Drawing
' <icbTextEditStyle>
' <icbShowDropDown>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Text
Imports DevExpress.Tutorials

' </icbShowDropDown>
' </icbTextEditStyle>
Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleComboBoxEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleComboBoxEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "comboboxedit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleComboBoxEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(comboBoxEditSample)
            InitComboBoxes()
            InitValues()
        End Sub

        Private Sub InitComboBoxes()
            ' <icbTextEditStyle>
            icbTextEditStyle.Properties.Items.AddEnum(GetType(TextEditStyles))
            ' </icbTextEditStyle>
            ' <icbShowDropDown>
            icbShowDropDown.Properties.Items.AddEnum(GetType(ShowDropDown))
            ' </icbShowDropDown>
            ' <icbHighlightedItemStyle>
            icbHighlightedItemStyle.Properties.Items.AddEnum(GetType(HighlightStyle))
        ' </icbHighlightedItemStyle>
        End Sub

        Private Sub UpdateComboBoxSampleData()
            comboBoxEditSample.Properties.Items.BeginUpdate()
            Try
                comboBoxEditSample.Properties.Items.Clear()
                For Each country As String In TutorialHelper.Countries
                    Dim _name As String = If(comboBoxEditSample.Properties.TextEditStyle = TextEditStyles.Standard, StringPainter.Default.RemoveFormat(country), country)
                    comboBoxEditSample.Properties.Items.Add(_name)
                Next
            Finally
                comboBoxEditSample.Properties.Items.EndUpdate()
            End Try

            comboBoxEditSample.SelectedIndex = 0
        End Sub

        Private Sub InitValues()
            updateValues = True
            UpdateComboBoxSampleData()
            icbTextEditStyle.EditValue = comboBoxEditSample.Properties.TextEditStyle
            icbShowDropDown.EditValue = comboBoxEditSample.Properties.ShowDropDown
            icbHighlightedItemStyle.EditValue = comboBoxEditSample.Properties.HighlightedItemStyle
            seItemHeight.Value = comboBoxEditSample.Properties.DropDownItemHeight
            seDropDownRows.Value = comboBoxEditSample.Properties.DropDownRows
            ceAutoComplete.Checked = comboBoxEditSample.Properties.AutoComplete
            ceCycleOnDblClick.Checked = comboBoxEditSample.Properties.CycleOnDblClick
            ceHotTrackItems.Checked = comboBoxEditSample.Properties.HotTrackItems
            ceImmediatePopup.Checked = comboBoxEditSample.Properties.ImmediatePopup
            cePopupSizeable.Checked = comboBoxEditSample.Properties.PopupSizeable
            ceCTRLScroll.Checked = comboBoxEditSample.Properties.UseCtrlScroll
            seDropDownRows.Enabled = Not comboBoxEditSample.Properties.PopupSizeable
            ceCycleOnDblClick.Enabled = comboBoxEditSample.Properties.ShowDropDown = ShowDropDown.Never
            updateValues = False
        End Sub

        ' <icbTextEditStyle>
        Private Sub icbTextEditStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.TextEditStyle = CType(icbTextEditStyle.EditValue, TextEditStyles)
            UpdateComboBoxSampleData()
        End Sub

        ' </icbTextEditStyle>
        ' <icbShowDropDown>
        Private Sub icbShowDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.ShowDropDown = CType(icbShowDropDown.EditValue, ShowDropDown)
            ' <ceCycleOnDblClick>
            ceCycleOnDblClick.Enabled = comboBoxEditSample.Properties.ShowDropDown = ShowDropDown.Never
        ' </ceCycleOnDblClick>
        End Sub

        ' </icbShowDropDown>
        ' <seItemHeight>
        Private Sub seItemHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.DropDownItemHeight = Convert.ToInt32(seItemHeight.Value)
        End Sub

        ' </seItemHeight>
        ' <seDropDownRows>
        Private Sub seDropDownRows_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.DropDownRows = Convert.ToInt32(seDropDownRows.Value)
        End Sub

        ' </seDropDownRows>
        ' <ceAutoComplete>
        Private Sub ceAutoComplete_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.AutoComplete = ceAutoComplete.Checked
        End Sub

        ' </ceAutoComplete>
        ' <ceCycleOnDblClick>
        Private Sub ceCycleOnDblClick_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.CycleOnDblClick = ceCycleOnDblClick.Checked
        End Sub

        ' </ceCycleOnDblClick>
        ' <ceHotTrackItems>
        Private Sub ceHotTrackItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.HotTrackItems = ceHotTrackItems.Checked
        End Sub

        ' </ceHotTrackItems>
        ' <ceImmediatePopup>
        Private Sub ceImmediatePopup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.ImmediatePopup = ceImmediatePopup.Checked
        End Sub

        ' </ceImmediatePopup>
        ' <cePopupSizeable>
        Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.PopupSizeable = cePopupSizeable.Checked
            ' <seDropDownRows>
            seDropDownRows.Enabled = Not cePopupSizeable.Checked
        ' </seDropDownRows>
        End Sub

        ' </cePopupSizeable>
        ' <comboBoxEditSample>
        Private Sub ShowEditValue()
            txtSelectedIndexValue.Text = String.Format("{0} / {1}", comboBoxEditSample.SelectedIndex, comboBoxEditSample.EditValue)
        End Sub

        Private Sub comboBoxEditSample_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowEditValue()
        End Sub

        ' </comboBoxEditSample>
        Private Sub comboBoxEditSample_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowEditValue()
        End Sub

        ' <ceCTRLScroll>
        Private Sub ceCTRLScroll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.UseCtrlScroll = ceCTRLScroll.Checked
        End Sub

        ' </ceCTRLScroll>
        ' <icbHighlightedItemStyle>
        Private Sub icbHighlightedItemStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            comboBoxEditSample.Properties.HighlightedItemStyle = CType(icbHighlightedItemStyle.EditValue, HighlightStyle)
        End Sub
    ' </icbHighlightedItemStyle>
    End Class
End Namespace
