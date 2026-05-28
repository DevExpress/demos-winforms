Imports System
Imports System.ComponentModel
Imports System.Drawing
' <icbShowDropDown>
' <popupContainerEditSample>
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms
Imports System.Globalization
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModulePopupContainerEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            splitContainerControl1.Panel1.DockPadding.All = 4
            splitContainerControl1.Panel2.DockPadding.All = 4
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModulePopupContainerEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "popupcontaineredit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        ' <popupContainerEditSample>
        Private Property CurrentFont As Font
            Get
                Return lbSample.Font
            End Get

            Set(ByVal value As Font)
                lbSample.Font = value
            End Set
        End Property

        ' </popupContainerEditSample>
        Private ReadOnly Property CurrentFontCaption As String
            Get
                Return String.Format("{0}, {1}, {2}", CurrentFont.Name, CurrentFont.Size.ToString(CultureInfo.InvariantCulture), CurrentFont.Style)
            End Get
        End Property

        ' <popupContainerEditSample>
        Private ReadOnly Property CurrentFontStyle As String
            Get
                Return CurrentFont.Style.ToString()
            End Get
        End Property

        ' </popupContainerEditSample>
        Private Sub ModulePopupContainerEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(popupContainerEditSample)
            Tutorials.TutorialHelper.InitFont(ilbFont, ScaleDPI)
            SetFontCaption()
            InitComboBoxes()
            InitValues()
        End Sub

        Private Sub InitComboBoxes()
            ' <icbShowDropDown>
            icbShowDropDown.Properties.Items.AddEnum(GetType(ShowDropDown))
        ' </icbShowDropDown>
        End Sub

        Private Sub InitValues()
            updateValues = True
            ceCloseOnOuterMouseClick.Checked = popupContainerEditSample.Properties.CloseOnOuterMouseClick
            icbShowDropDown.EditValue = popupContainerEditSample.Properties.ShowDropDown
            cePopupSizeable.Checked = popupContainerEditSample.Properties.PopupSizeable
            ceShowPopupCloseButton.Checked = popupContainerEditSample.Properties.ShowPopupCloseButton
            ceShowPopupShadow.Checked = popupContainerEditSample.Properties.ShowPopupShadow
            updateValues = False
        End Sub

        Private Sub SetFontCaption()
            popupContainerEditSample.EditValue = CurrentFontCaption
        End Sub

        ' <popupContainerEditSample>
        Private Sub popupContainerEditSample_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            ilbFont.SelectedValue = CurrentFont.Name
            seSize.Value = Convert.ToDecimal(CurrentFont.Size)
            For Each item As CheckedListBoxItem In clbStyle.Items
                item.CheckState = If((CurrentFontStyle.IndexOf(item.Value.ToString()) > -1), CheckState.Checked, CheckState.Unchecked)
            Next
        End Sub

        ' </popupContainerEditSample>
        ' <popupContainerEditSample>
        Private Function GetFontStyleByValues(ByVal clb As CheckedListBoxControl) As FontStyle
            Dim ret As FontStyle = New FontStyle()
            If clb.GetItemChecked(0) Then ret = ret Or FontStyle.Bold
            If clb.GetItemChecked(1) Then ret = ret Or FontStyle.Italic
            If clb.GetItemChecked(2) Then ret = ret Or FontStyle.Strikeout
            If clb.GetItemChecked(3) Then ret = ret Or FontStyle.Underline
            Return ret
        End Function

        Private Sub popupContainerEditSample_QueryResultValue(ByVal sender As Object, ByVal e As XtraEditors.Controls.QueryResultValueEventArgs)
            CurrentFont = New Font(ilbFont.SelectedValue.ToString(), Convert.ToSingle(seSize.Value), GetFontStyleByValues(clbStyle))
            e.Value = CurrentFontCaption
        End Sub

        ' </popupContainerEditSample>
        Private Sub ClosePopup()
            If popupContainerControlSample.OwnerEdit IsNot Nothing Then popupContainerControlSample.OwnerEdit.ClosePopup()
        End Sub

        Private Sub ilbFont_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            ClosePopup()
        End Sub

        Private Sub popupFont_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                popupContainerControlSample.FindForm().Validate()
                ClosePopup()
            End If
        End Sub

        ' <ceCloseOnOuterMouseClick>
        Private Sub ceCloseOnOuterMouseClick_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            popupContainerEditSample.Properties.CloseOnOuterMouseClick = ceCloseOnOuterMouseClick.Checked
        End Sub

        ' </ceCloseOnOuterMouseClick>
        ' <icbShowDropDown>
        Private Sub icbShowDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            popupContainerEditSample.Properties.ShowDropDown = CType(icbShowDropDown.EditValue, ShowDropDown)
        End Sub

        ' </icbShowDropDown>
        ' <cePopupSizeable>
        Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            popupContainerEditSample.Properties.PopupSizeable = cePopupSizeable.Checked
        End Sub

        ' </cePopupSizeable>
        ' <ceShowPopupCloseButton>
        Private Sub ceShowPopupCloseButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            popupContainerEditSample.Properties.ShowPopupCloseButton = ceShowPopupCloseButton.Checked
        End Sub

        ' </ceShowPopupCloseButton>
        ' <ceShowPopupShadow>
        Private Sub ceShowPopupShadow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            popupContainerEditSample.Properties.ShowPopupShadow = ceShowPopupShadow.Checked
        End Sub
    ' </ceShowPopupShadow>
    End Class
End Namespace
