Imports System
Imports System.ComponentModel
Imports System.Drawing
' <icbAlignment>
' <icbShowDropDown>
' <imageComboBoxEdit1>
Imports DevExpress.XtraEditors.Controls
' </imageComboBoxEdit1>
' </icbShowDropDown>
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleImageComboBoxEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If tabPane1 IsNot Nothing Then AddHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleImageComboBoxEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "imagecomboboxedit"
            End Get
        End Property

        Private Sub OnSelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            CalcContentCore()
        End Sub

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
            If tabPane1 IsNot Nothing Then RemoveHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
            CalcLayoutControlBounds(layoutControl2)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleImageComboBoxEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            Tutorials.ControlUtils.CenterControlInParent(imageComboBoxEditSample)
            InitSamples()
            InitComboBoxes()
            InitValues()
        End Sub

        Private Sub InitSamples()
            imageComboBoxEdit2.Properties.Items.AddEnum(GetType(ButtonPredefines))
        End Sub

        Private Sub InitComboBoxes()
            ' <icbShowDropDown>
            icbShowDropDown.Properties.Items.AddEnum(GetType(ShowDropDown))
            ' </icbShowDropDown>
            ' <icbAlignment>
            icbAlignment.Properties.Items.AddEnum(GetType(HorzAlignment))
            ' </icbAlignment>
            ' <icbHighlightedItemStyle>
            icbHighlightedItemStyle.Properties.Items.AddEnum(GetType(HighlightStyle))
        ' </icbHighlightedItemStyle>
        End Sub

        Private Sub InitValues()
            updateValues = True
            imageComboBoxEditSample.SelectedIndex = 0
            imageComboBoxEdit1.SelectedIndex = 2
            imageComboBoxEdit2.SelectedIndex = 0
            imageComboBoxEdit3.SelectedIndex = 0
            icbShowDropDown.EditValue = imageComboBoxEditSample.Properties.ShowDropDown
            icbHighlightedItemStyle.EditValue = imageComboBoxEditSample.Properties.HighlightedItemStyle
            seDropDownRows.Value = imageComboBoxEditSample.Properties.DropDownRows
            ceAutoComplete.Checked = imageComboBoxEditSample.Properties.AutoComplete
            ceCycleOnDblClick.Checked = imageComboBoxEditSample.Properties.CycleOnDblClick
            ceHotTrackItems.Checked = imageComboBoxEditSample.Properties.HotTrackItems
            ceImmediatePopup.Checked = imageComboBoxEditSample.Properties.ImmediatePopup
            cePopupSizeable.Checked = imageComboBoxEditSample.Properties.PopupSizeable
            ceCTRLScroll.Checked = imageComboBoxEditSample.Properties.UseCtrlScroll
            icbAlignment.EditValue = imageComboBoxEditSample.Properties.GlyphAlignment
            seDropDownRows.Enabled = Not imageComboBoxEditSample.Properties.PopupSizeable
            ceCycleOnDblClick.Enabled = imageComboBoxEditSample.Properties.ShowDropDown = ShowDropDown.Never
            updateValues = False
        End Sub

        ' <icbShowDropDown>
        Private Sub icbShowDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageComboBoxEditSample.Properties.ShowDropDown = CType(icbShowDropDown.EditValue, ShowDropDown)
            ' <ceCycleOnDblClick>
            ceCycleOnDblClick.Enabled = imageComboBoxEditSample.Properties.ShowDropDown = ShowDropDown.Never
        ' </ceCycleOnDblClick>
        End Sub

        ' </icbShowDropDown>
        ' <seDropDownRows>
        Private Sub seDropDownRows_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageComboBoxEditSample.Properties.DropDownRows = Convert.ToInt32(seDropDownRows.Value)
        End Sub

        ' </seDropDownRows>
        ' <ceAutoComplete>
        Private Sub ceAutoComplete_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageComboBoxEditSample.Properties.AutoComplete = ceAutoComplete.Checked
        End Sub

        ' </ceAutoComplete>
        ' <ceCycleOnDblClick>
        Private Sub ceCycleOnDblClick_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageComboBoxEditSample.Properties.CycleOnDblClick = ceCycleOnDblClick.Checked
        End Sub

        ' </ceCycleOnDblClick>
        ' <ceHotTrackItems>
        Private Sub ceHotTrackItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageComboBoxEditSample.Properties.HotTrackItems = ceHotTrackItems.Checked
        End Sub

        ' </ceHotTrackItems>
        ' <ceImmediatePopup>
        Private Sub ceImmediatePopup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageComboBoxEditSample.Properties.ImmediatePopup = ceImmediatePopup.Checked
        End Sub

        ' </ceImmediatePopup>
        ' <cePopupSizeable>
        Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageComboBoxEditSample.Properties.PopupSizeable = cePopupSizeable.Checked
            ' <seDropDownRows>
            seDropDownRows.Enabled = Not cePopupSizeable.Checked
        ' </seDropDownRows>
        End Sub

        ' </cePopupSizeable>
        ' <ceCTRLScroll>
        Private Sub ceCTRLScroll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageComboBoxEditSample.Properties.UseCtrlScroll = ceCTRLScroll.Checked
        End Sub

        ' </ceCTRLScroll>
        ' <icbAlignment>
        Private Sub icbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageComboBoxEditSample.Properties.GlyphAlignment = CType(icbAlignment.EditValue, HorzAlignment)
        End Sub

        ' </icbAlignment>
        ' <ceLargeImages>
        Private Sub ceLargeImages_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            imageComboBoxEditSample.Properties.LargeImages = If(ceLargeImages.Checked, svgImageCollection2, Nothing)
        End Sub

        ' </ceLargeImages>
        ' <imageComboBoxEdit1>
        Private Sub ShowValues(ByVal edit As TextEdit, ByVal comboBox As ImageComboBoxEdit)
            If comboBox Is Nothing Then Return
            Dim item As ImageComboBoxItem = TryCast(comboBox.SelectedItem, ImageComboBoxItem)
            If item IsNot Nothing Then
                edit.Text = String.Format("{0} / {1} / ""{2}""", comboBox.SelectedIndex, item.Value, item.Description)
            Else
                edit.Text = "Item is null"
            End If
        End Sub

        Private Sub imageComboBoxEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowValues(teImageComboBoxEdit1, TryCast(sender, ImageComboBoxEdit))
        End Sub

        ' </imageComboBoxEdit1>
        Private Sub imageComboBoxEdit2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowValues(teImageComboBoxEdit2, TryCast(sender, ImageComboBoxEdit))
        End Sub

        Private Sub imageComboBoxEdit3_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowValues(teImageComboBoxEdit3, TryCast(sender, ImageComboBoxEdit))
        End Sub

        ' <icbHighlightedItemStyle>
        Private Sub icbHighlightedItemStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            imageComboBoxEditSample.Properties.HighlightedItemStyle = CType(icbHighlightedItemStyle.EditValue, HighlightStyle)
        End Sub
    ' </icbHighlightedItemStyle>
    End Class
End Namespace
