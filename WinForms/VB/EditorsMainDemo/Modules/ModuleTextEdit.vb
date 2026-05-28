Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
' <comboNumericFormat>
' <comboDateFormat>
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Navigation

' </comboDateFormat>
' </comboNumericFormat>
Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleTextEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If tabPane1 IsNot Nothing Then AddHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleTextEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "textEdit"
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
            CalcLayoutControlBounds(layoutControl2)
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        ' <checkEditHideSelection>
        Private Sub checkEditHideSelection_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            textEditSample.Properties.HideSelection = checkEditHideSelection.Checked
        End Sub

        ' </checkEditHideSelection>
        ' <comboBoxSelectCase>
        Private Sub comboBoxSelectCase_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            Dim caseStyles As CharacterCasing() = New CharacterCasing() {CharacterCasing.Normal, CharacterCasing.Upper, CharacterCasing.Lower}
            Dim selectedIndex As Integer = comboBoxSelectCase.SelectedIndex
            textEditSample.Properties.CharacterCasing = caseStyles(selectedIndex)
        End Sub

        ' </comboBoxSelectCase>
        ' <comboBoxPasswordChar>
        Private Sub comboBoxPasswordChar_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            Dim passwordChars As Char() = New Char() {Char.MinValue, "*"c, "#"c}
            Dim selectedIndex As Integer = comboBoxPasswordChar.SelectedIndex
            textEditSample.Properties.PasswordChar = passwordChars(selectedIndex)
        End Sub

        ' </comboBoxPasswordChar>
        ' <comboNumericFormat>
        Private Sub comboNumericFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateNumericTextEditFormat()
        End Sub

        ' </comboNumericFormat>
        ' <spinEditDecimalPlaces>
        Private Sub spinEditDecimalPlaces_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateNumericTextEditFormat()
        End Sub

        ' <comboNumericFormat>
        Private Sub UpdateNumericTextEditFormat()
            Dim formatSpecifiers As String() = New String() {String.Empty, "c", "f", "e", "p", "X"}
            Dim selectedFormat As Integer = comboNumericFormat.SelectedIndex
            If selectedFormat = 0 Then
                textEditNumeric.Properties.DisplayFormat.FormatType = FormatType.None
                textEditNumeric.Properties.DisplayFormat.FormatString = String.Empty
                Return
            End If

            Dim formatString As String = formatSpecifiers(selectedFormat) & spinEditDecimalPlaces.EditValue.ToString()
            textEditNumeric.Properties.DisplayFormat.FormatType = FormatType.Numeric
            textEditNumeric.Properties.DisplayFormat.FormatString = formatString
        End Sub

        ' </spinEditDecimalPlaces>
        ' </comboNumericFormat>
        ' <comboNumericEditValue>
        Private Sub comboNumericEditValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim values As Double() = New Double() {0.5, 1, 123.45, -12.34, 100}
            Dim valueIndex As Integer = comboNumericEditValue.SelectedIndex
            If Math.Floor(values(valueIndex)) - values(valueIndex) = 0 Then
                textEditNumeric.EditValue = Convert.ToInt32(values(valueIndex))
            Else
                textEditNumeric.EditValue = values(valueIndex)
            End If
        End Sub

        ' </comboNumericEditValue>
        ' <dateEdit>
        Private Sub dateEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            textEditDate.EditValue = dateEdit.EditValue
        End Sub

        ' </dateEdit>
        ' <comboDateFormat>
        Private Sub comboDateFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim formatStrings As String() = New String() {"", "d", "D", "t", "T", "f", "g", "s"}
            Dim stringIndex As Integer = comboDateFormat.SelectedIndex
            If Equals(formatStrings(stringIndex), "") Then
                textEditDate.Properties.DisplayFormat.FormatType = FormatType.None
                textEditDate.Properties.DisplayFormat.FormatString = String.Empty
                Return
            End If

            textEditDate.Properties.DisplayFormat.FormatType = FormatType.DateTime
            textEditDate.Properties.DisplayFormat.FormatString = formatStrings(stringIndex)
        End Sub

        ' </comboDateFormat>
        Private Sub ModuleTextEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            textEditDate.EditValue = New DateTime(2005, 3, 30, 14, 54, 32)
            dateEdit.EditValue = textEditDate.EditValue
            Tutorials.ControlUtils.CenterControlInParent(textEditNumeric)
            Tutorials.ControlUtils.CenterControlInParent(textEditDate)
            Tutorials.ControlUtils.CenterControlInParent(textEditSample)
            InitValues()
        End Sub

        Private Sub InitValues()
            updateValues = True
            checkEditHideSelection.Checked = textEditSample.Properties.HideSelection
            comboBoxSelectCase.EditValue = textEditSample.Properties.CharacterCasing.ToString()
            comboBoxPasswordChar.EditValue = textEditSample.Properties.PasswordChar
            updateValues = False
        End Sub

        ' <buttonsSelection>
        Private Sub buttonsSelection_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            If Equals(e.Button.Caption, "All") Then textEditSample.SelectAll()
            If Equals(e.Button.Caption, "Random") Then SetRandomSelection()
            If Equals(e.Button.Caption, "Clear") Then textEditSample.SelectionLength = 0
        End Sub

        Private Sub SetRandomSelection()
            Dim rnd = TutorialConstants.Random
            Dim pos1 As Integer = rnd.Next(textEditSample.Text.Length)
            Dim pos2 As Integer = rnd.Next(textEditSample.Text.Length)
            textEditSample.Select(Math.Min(pos1, pos2), Math.Abs(pos1 - pos2))
        End Sub
    ' </buttonsSelection>
    End Class
End Namespace
