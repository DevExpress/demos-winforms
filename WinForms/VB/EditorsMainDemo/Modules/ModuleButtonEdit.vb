Imports System
Imports System.ComponentModel
Imports System.Drawing
' <comboBoxTextEditStyle>
Imports DevExpress.XtraEditors.Controls
' </comboBoxTextEditStyle>
Imports DevExpress.XtraTab
Imports System.Windows.Forms
Imports DevExpress.Tutorials
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleButtonEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            If tabPane1 IsNot Nothing Then AddHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleButtonEdit", "ButtonProperties"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "buttonedit"
            End Get
        End Property

        Private Sub OnSelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            CalcContentCore()
        End Sub

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
            If tabPane1 IsNot Nothing Then RemoveHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            If xtraTabControlButtons IsNot Nothing AndAlso xtraTabControlButtons.MinimumSize <> Size.Empty Then
                layoutControl2.BeginUpdate()
                layoutControlItem3.Size = xtraTabControlButtons.MinimumSize
                layoutControl2.EndUpdate()
            End If

            CalcLayoutControlBounds(layoutControl2)
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private Sub ModuleButtonEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(buttonEditSample)
            InitValues()
            InitButtonProperties()
        End Sub

        Private updateValues As Boolean = False

        Private editorsNames As String() = New String() {"Text Edit", "Button Edit", "Spin Edit", "Check Edit", "ComboBox Edit", "ImageComboBox Edit", "Date Edit", "Calc Edit", "Color Edit", "MemoEx Edit", "Image Edit", "Memo Edit", "Picture Edit", "ProgressBar Control", "LookUp Edit", "PopupContainer Edit", "Radio Group", "Time Edit", "HyperLink Edit", "MRU Edit"}

        Private Sub InitValues()
            updateValues = True
            comboBoxTextEditStyle.Text = buttonEditSample.Properties.TextEditStyle.ToString()
            SetCustomValue(0, buttonEdit1)
            updateValues = False
        End Sub

        Private Sub InitButtonProperties()
            For Each button As EditorButton In buttonEditSample.Properties.Buttons
                Dim page As XtraTabPage = New XtraTabPage()
                page.Text = String.Format("Button #{0}", buttonEditSample.Properties.Buttons.IndexOf(button) + 1)
                Dim pr As ButtonProperties = New ButtonProperties(button)
                pr.Dock = DockStyle.Fill
                page.Controls.Add(pr)
                xtraTabControlButtons.TabPages.Add(page)
            Next
        End Sub

        ' <comboBoxTextEditStyle>
        Private Sub comboBoxTextEditStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            Dim styles As TextEditStyles() = New TextEditStyles() {TextEditStyles.Standard, TextEditStyles.HideTextEditor, TextEditStyles.DisableTextEditor}
            buttonEditSample.Properties.TextEditStyle = styles(comboBoxTextEditStyle.SelectedIndex)
        End Sub

        ' </comboBoxTextEditStyle>
        ' <buttonEdit1>
        Private Sub ShowEvent(ByVal eventString As String, ByVal button As EditorButton)
            meFiringEvents.Text = String.Format("{0}: {1}" & Microsoft.VisualBasic.Constants.vbCrLf, eventString, button.Tag) & meFiringEvents.Text
        End Sub

        Private Sub buttonEdit_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            ShowEvent("ButtonClick", e.Button)
        End Sub

        ' </buttonEdit1>
        Private Sub buttonEdit_ButtonPressed(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            ShowEvent("ButtonPressed", e.Button)
        End Sub

        ' <buttonEdit1>
        Private Sub buttonEdit1_ButtonPressed(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            buttonEdit_ButtonPressed(sender, e)
            Dim edit As ButtonEdit = TryCast(sender, ButtonEdit)
            Select Case edit.Properties.Buttons.IndexOf(e.Button)
                Case 0
                    SetCustomValue(customIndex - 1, edit)
                Case 1
                    SetCustomValue(customIndex + 1, edit)
            End Select
        End Sub

        Private customIndex As Integer = 0

        Private Sub SetCustomValue(ByVal index As Integer, ByVal edit As ButtonEdit)
            If index < 0 OrElse index > editorsNames.Length - 1 Then Return
            customIndex = index
            edit.EditValue = editorsNames(index)
            edit.Properties.Buttons(0).Enabled = index > 0
            edit.Properties.Buttons(1).Enabled = index < editorsNames.Length - 1
        End Sub

        ' </buttonEdit1>
        Private Sub buttonEdit5_Properties_Click(ByVal sender As Object, ByVal e As EventArgs)
            meFiringEvents.Text = ""
        End Sub

        ' <checkEditAllowButtonsNavigation>
        Private Sub checkEditAllowButtonsNavigation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            buttonEditSample.Properties.AllowButtonNavigation = If(checkEditAllowButtonsNavigation.Checked, Utils.DefaultBoolean.True, Utils.DefaultBoolean.Default)
        End Sub
    ' </checkEditAllowButtonsNavigation>
    End Class
End Namespace
