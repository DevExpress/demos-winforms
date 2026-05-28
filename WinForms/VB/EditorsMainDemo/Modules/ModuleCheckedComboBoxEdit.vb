Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleCheckedComboBoxEdit
        Inherits TutorialControl

        ' <checkedComboBoxEdit1>
        <FlagsAttribute>
        Friend Enum Colors
            None = 0
            Red = 1
            Green = 2
            Blue = 4
            Yellow = 8
            Black = 16
        End Enum

        ' </checkedComboBoxEdit1>
        ' <checkedComboBoxEdit2>
        <Flags>
        Friend Enum Platforms
            Win98 = 16
            Win2000 = 32
            WinNT = 64
            WinXP = 128
            Vista = 256
            <Description("Windows 7")>
            Win7 = 512
            <Description("Windows 8")>
            Win8 = 1024
        End Enum

        ' </checkedComboBoxEdit2>
        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleCheckedComboBoxEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "checkedcomboboxEdit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleCheckedComboBoxEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(checkedComboBoxEditSample)
            InitComboBoxes()
            InitValues()
        End Sub

        Private Sub InitComboBoxes()
            Dim editValues As String() = New String() {"Circle", "Rectangle", "Ellipse", "Triangle", "Square"}
            For Each value As String In editValues
                checkedComboBoxEditSample.Properties.Items.Add(value, CheckState.Unchecked, True)
            Next

            ' <icbHighlightedItemStyle>
            icbHighlightedItemStyle.Properties.Items.AddEnum(GetType(HighlightStyle))
        ' </icbHighlightedItemStyle>
        End Sub

        Private Sub InitValues()
            updateValues = True
            icbHighlightedItemStyle.EditValue = checkedComboBoxEditSample.Properties.HighlightedItemStyle
            cmbSeparatorChar.EditValue = checkedComboBoxEditSample.Properties.SeparatorChar
            ceSelectAllItem.EditValue = checkedComboBoxEditSample.Properties.SelectAllItemVisible
            teSelectAllItemCaption.EditValue = checkedComboBoxEditSample.Properties.SelectAllItemCaption
            ceShowButtons.Checked = checkedComboBoxEditSample.Properties.ShowButtons
            ceIncrementalSearch.Checked = checkedComboBoxEditSample.Properties.IncrementalSearch
            ceAllowMultiSelect.Checked = checkedComboBoxEditSample.Properties.AllowMultiSelect
            checkedComboBoxEditSample.SetEditValue("Circle, Ellipse")
            updateValues = False
            ' <checkedComboBoxEdit1>
            checkedComboBoxEdit1.Properties.SetFlags(GetType(Colors))
            checkedComboBoxEdit1.SetEditValue(Colors.Red Or Colors.Blue Or Colors.Yellow)
            ' </checkedComboBoxEdit1>
            ' <checkedComboBoxEdit2>
            checkedComboBoxEdit2.Properties.SetFlags(GetType(Platforms))
            checkedComboBoxEdit2.SetEditValue(Platforms.WinXP Or Platforms.Win98)
        ' </checkedComboBoxEdit2>
        End Sub

        ' <icbHighlightedItemStyle>
        Private Sub icbHighlightedItemStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            checkedComboBoxEditSample.Properties.HighlightedItemStyle = CType(icbHighlightedItemStyle.EditValue, HighlightStyle)
        End Sub

        ' </icbHighlightedItemStyle>
        ' <cmbSeparatorChar>
        Private Sub cmbSeparatorChar_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            checkedComboBoxEditSample.Properties.SeparatorChar = Convert.ToChar(cmbSeparatorChar.EditValue)
        End Sub

        ' </cmbSeparatorChar>
        ' <ceSelectAllItem>
        Private Sub ceSelectAllItem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            checkedComboBoxEditSample.Properties.SelectAllItemVisible = ceSelectAllItem.Checked
        End Sub

        ' </ceSelectAllItem>
        Private Sub checkedComboBoxEditSample_CustomDisplayText(ByVal sender As Object, ByVal e As CustomDisplayTextEventArgs)
            If Equals(e.DisplayText, String.Empty) Then e.DisplayText = "Nothing"
        End Sub

        ' <teSelectAllItemCaption>
        Private Sub teSelectAllItemCaption_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            checkedComboBoxEditSample.Properties.SelectAllItemCaption = teSelectAllItemCaption.Text
        End Sub

        ' </teSelectAllItemCaption>
        Private Sub ceShowButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            ' </skip>
            checkedComboBoxEditSample.Properties.ShowButtons = ceShowButtons.Checked
        End Sub

        ' <ceIncrementalSearch>
        Private Sub ceIncrementalSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            checkedComboBoxEditSample.Properties.IncrementalSearch = ceIncrementalSearch.Checked
        End Sub

        ' </ceIncrementalSearch>
        ' <ceAllowMultiSelect>
        Private Sub ceAllowMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            checkedComboBoxEditSample.Properties.AllowMultiSelect = ceAllowMultiSelect.Checked
        End Sub
    ' </ceAllowMultiSelect>
    End Class
End Namespace
