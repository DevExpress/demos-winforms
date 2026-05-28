Imports System
Imports System.ComponentModel
Imports System.Drawing
' <comboSpinStyle> <checkEditAdditionalButtons>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Tutorials
Imports DevExpress.XtraBars.Navigation

' </comboSpinStyle> </checkEditAdditionalButtons>
Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleSpinEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If tabPane1 IsNot Nothing Then AddHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleSpinEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "spinedit"
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

        Private Sub ModuleSpinEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(spinEditSample1)
            ControlUtils.CenterControlInParent(spinEditSample2)
            InitValues()
        End Sub

        Private Sub InitValues()
            updateValues = True
            checkEditFloatValue.Checked = spinEditSample1.Properties.IsFloatValue
            spinEditButtonPos.Value = spinEditSample1.Properties.SpinButtonIndex
            comboSpinStyle.EditValue = spinEditSample1.Properties.SpinStyle.ToString()
            comboFiringMode.EditValue = spinEditSample2.Properties.EditValueChangedFiringMode.ToString()
            checkEditValidate.Checked = spinEditSample2.Properties.ValidateOnEnterKey
            updateValues = False
        End Sub

        ' <comboSpinStyle>
        Private Sub comboSpinStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            Dim styles As SpinStyles() = New SpinStyles() {SpinStyles.Vertical, SpinStyles.Horizontal}
            spinEditSample1.Properties.SpinStyle = styles(comboSpinStyle.SelectedIndex)
        End Sub

        ' </comboSpinStyle>
        ' <checkEditAdditionalButtons>
        Private Sub checkEditAdditionalButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            spinEditButtonPos.Enabled = checkEditAdditionalButtons.Checked
            Dim buttons As EditorButtonCollection = spinEditSample1.Properties.Buttons
            If checkEditAdditionalButtons.Checked Then
                buttons.Add(CreateButton(False, "1"))
                buttons.Add(CreateButton(True, "2"))
                buttons.Add(CreateButton(True, "3"))
            Else
                While buttons.Count > 1
                    buttons.RemoveAt(buttons.Count - 1)
                End While

                spinEditSample1.Properties.SpinButtonIndex = 0
                spinEditButtonPos.Value = 0
            End If
        End Sub

        Private Function CreateButton(ByVal isLeft As Boolean, ByVal caption As String) As EditorButton
            Dim button As EditorButton = New EditorButton(ButtonPredefines.Glyph)
            button.Caption = caption
            button.IsLeft = isLeft
            Return button
        End Function

        ' </checkEditAdditionalButtons>
        ' <spinEditButtonPos>
        Private Sub spinEditButtonPos_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            spinEditSample1.Properties.SpinButtonIndex = CInt(spinEditButtonPos.Value)
        End Sub

        ' </spinEditButtonPos>
        ' <comboMaxMin>
        Private Sub comboMaxMin_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim minValues As Decimal() = New Decimal() {-1000, 10, 0}
            Dim maxValues As Decimal() = New Decimal() {1000, 99, 12.5D}
            Dim index As Integer = comboMaxMin.SelectedIndex
            spinEditSample1.Properties.MinValue = minValues(index)
            spinEditSample1.Properties.MaxValue = maxValues(index)
        End Sub

        ' </comboMaxMin>
        ' <comboIncrementValue>
        Private Sub comboIncrementValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim increments As Decimal() = New Decimal() {10, 1, 0.5D, 0.1D}
            Dim index As Integer = comboIncrementValue.SelectedIndex
            spinEditSample1.Properties.Increment = increments(index)
        End Sub

        ' </comboIncrementValue>
        ' <checkEditFloatValue>
        Private Sub checkEditFloatValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            spinEditSample1.Properties.IsFloatValue = checkEditFloatValue.Checked
        End Sub

        ' </checkEditFloatValue>
        ' <comboFiringMode>
        Private Sub comboFiringMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            Dim mode As EditValueChangedFiringMode() = New EditValueChangedFiringMode() {EditValueChangedFiringMode.Buffered, EditValueChangedFiringMode.Default}
            Dim index As Integer = comboFiringMode.SelectedIndex
            spinEditSample2.Properties.EditValueChangedFiringMode = mode(index)
        End Sub

        ' </comboFiringMode>
        ' <checkEditValidate>
        Private Sub checkEditValidate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            spinEditSample2.Properties.ValidateOnEnterKey = checkEditValidate.Checked
        End Sub

        ' </checkEditValidate>
        ' <spinEditSample2>
        Private Sub spinEditSample2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            meFiringEvents.Text = String.Format("EditValueChanged: {0}", spinEditSample2.EditValue)
        End Sub

        ' </spinEditSample2>
        ' <checkEditValidate>
        Private Sub spinEditSample2_Validated(ByVal sender As Object, ByVal e As EventArgs)
            meFiringEvents.Text = String.Format("Validated: {0}", spinEditSample2.EditValue)
        End Sub
    ' </checkEditValidate>
    End Class
End Namespace
