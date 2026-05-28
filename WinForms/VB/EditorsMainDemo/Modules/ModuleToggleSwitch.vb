Imports DevExpress.Utils
Imports System.Drawing
Imports System

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleToggleSwitch
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            toggleSwitch.AutoSizeInLayoutControl = True
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleToggleSwitch"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "toggleSwitch"
            End Get
        End Property

        '<tsTextOn>
        Private Sub OnTextChanging(ByVal sender As Object, ByVal e As XtraEditors.Controls.ChangingEventArgs)
            Dim value As String = TryCast(e.NewValue, String)
            If Not Equals(value, Nothing) AndAlso value.Length > 10 Then
                e.Cancel = True
                Return
            End If

            OnToggleSwitchTextChanging()
            Try
                toggleSwitch.Properties.OnText = e.NewValue.ToString()
            Finally
                OnToggleSwitchTextChanged()
            End Try
        End Sub

        '</tsTextOn>
        '<tsTextOff>
        Private Sub OffTextChanging(ByVal sender As Object, ByVal e As XtraEditors.Controls.ChangingEventArgs)
            Dim value As String = TryCast(e.NewValue, String)
            If Not Equals(value, Nothing) AndAlso value.Length > 10 Then
                e.Cancel = True
                Return
            End If

            OnToggleSwitchTextChanging()
            Try
                toggleSwitch.Properties.OffText = e.NewValue.ToString()
            Finally
                OnToggleSwitchTextChanged()
            End Try
        End Sub

        '</tsTextOff>
        '<btnToggleState>
        Private Sub btnToggleState_Click(ByVal sender As Object, ByVal e As EventArgs)
            toggleSwitch.IsOn = Not toggleSwitch.IsOn
        End Sub

        '</btnToggleState>
        '<tsAllowHTMLString>
        Private Sub tsAllowHTMLString_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            toggleSwitch.Properties.AllowHtmlDraw = If(tsAllowHTMLString.Checked, DefaultBoolean.True, DefaultBoolean.False)
            SetToggleSwitchText()
        End Sub

        '</tsAllowHTMLString>
        '<tsAllowMnemonics>
        Private toggleSwitchOnText As String = "<Color=Blue><b>{0}{1}</b>"

        Private toggleSwitchOffText As String = "<Color=Red><b>{0}{1}</b>"

        Private Sub SetToggleSwitchText()
            Dim prefix As String = If(tsAllowMnemonics.Checked, "&", String.Empty)
            If tsAllowHTMLString.Checked Then
                toggleSwitch.Properties.OnText = String.Format(toggleSwitchOnText, New Object() {prefix, tsTextOn.Text})
                toggleSwitch.Properties.OffText = String.Format(toggleSwitchOffText, New Object() {prefix, tsTextOff.Text})
            Else
                toggleSwitch.Properties.OnText = String.Format(Utils.Text.StringPainter.Default.RemoveFormat(toggleSwitchOnText), New Object() {prefix, tsTextOn.Text})
                toggleSwitch.Properties.OffText = String.Format(Utils.Text.StringPainter.Default.RemoveFormat(toggleSwitchOffText), New Object() {prefix, tsTextOff.Text})
            End If
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Private Sub tsAllowMnemonics_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetToggleSwitchText()
        End Sub

        Protected Sub OnToggleSwitchTextChanging()
            layoutControl1.BeginUpdate()
        End Sub

        Protected Sub OnToggleSwitchTextChanged()
            CalcContentCore()
            layoutControl1.EndUpdate()
        End Sub

        '</tsAllowMnemonics>
        Private Sub tsResize(ByVal sender As Object, ByVal e As EventArgs)
            SetToggleSwitchText()
        End Sub

        '<comboAlign>
        Private Sub comboAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim alignments As HorzAlignment() = New HorzAlignment() {HorzAlignment.Near, HorzAlignment.Center, HorzAlignment.Far}
            Dim selectedIndex As Integer = comboAlign.SelectedIndex
            toggleSwitch.Properties.GlyphAlignment = alignments(selectedIndex)
            toggleSwitch.Properties.Appearance.TextOptions.HAlignment = alignments(selectedIndex)
        End Sub

        '</comboAlign>
        '<tsAllowThumbAnimation>
        Private Sub tsAllowThumbAnimation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            toggleSwitch.Properties.AllowThumbAnimation = tsAllowThumbAnimation.Checked
        End Sub
    '</tsAllowThumbAnimation>
    End Class
End Namespace
