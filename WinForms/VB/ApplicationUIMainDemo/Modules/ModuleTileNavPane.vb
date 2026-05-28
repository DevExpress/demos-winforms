Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class ModuleTileNavPane
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            SelectHomePath()
        End Sub

        Private Sub SelectHomePath()
            tileNavPane.SelectedElement = catMarketing
        End Sub

        Private Sub tileNavPane_TileClick(ByVal sender As Object, ByVal e As NavElementEventArgs)
            Dim item = TryCast(e.Element, TileNavItem)
            If item IsNot Nothing AndAlso item.Category Is catCreateNew Then
                AddToLog("Tile clicked: " & e.Element.Caption)
                tileNavPane.HideDropDownWindow()
            End If
        End Sub

        Private Sub navButtonHome_ElementClick(ByVal sender As Object, ByVal e As NavElementEventArgs)
            AddToLog("Button clicked: Home")
            SelectHomePath()
        End Sub

        Private Sub tileNavPane_SelectedElementChanged(ByVal sender As Object, ByVal e As TileNavElementEventArgs)
            Dim _name As String = If(e.Element Is Nothing, "null", e.Element.Caption)
            AddToLog("Selected element changed: " & _name)
        End Sub

        Private Sub navButtonSettings_ElementClick(ByVal sender As Object, ByVal e As NavElementEventArgs)
            AddToLog("Button clicked: Settings")
        End Sub

        Private Sub navButtonHelp_ElementClick(ByVal sender As Object, ByVal e As NavElementEventArgs)
            AddToLog("Button clicked: Help")
        End Sub

        Private Sub AddToLog(ByVal value As String)
            eventsLog.Text = value & Environment.NewLine & eventsLog.Text
        End Sub

        Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            tileNavPane.HideDropDownWindow()
            If cbDock.SelectedIndex = 0 Then
                tileNavPane.Dock = DockStyle.Top
            Else
                tileNavPane.Dock = DockStyle.Bottom
            End If
        End Sub

        Private Sub ceItemShadow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value = If(ceItemShadow.Checked, DefaultBoolean.True, DefaultBoolean.False)
            tileNavPane.OptionsPrimaryDropDown.ShowItemShadow = value
            tileNavPane.OptionsSecondaryDropDown.ShowItemShadow = value
            tileNavPane.HideDropDownWindow()
        End Sub

        Private Sub ceOuterClick_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value = If(ceOuterClick.Checked, DefaultBoolean.True, DefaultBoolean.False)
            tileNavPane.OptionsPrimaryDropDown.CloseOnOuterClick = value
        End Sub

        Private Sub ceContinueNavigation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            tileNavPane.ContinuousNavigation = ceContinueNavigation.Checked
        End Sub

        Private Sub seDropDownHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            tileNavPane.OptionsPrimaryDropDown.Height = CInt(seDropDownHeight.Value)
            tileNavPane.HideDropDownWindow()
        End Sub

        Private Sub btnClearEventLog_Click(ByVal sender As Object, ByVal e As EventArgs)
            eventsLog.Text = String.Empty
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            If tileNavPane IsNot Nothing Then tileNavPane.HideDropDownWindow()
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            If panelContainer Is Nothing Then Return
            Dim x As Integer = Width \ 2 - panelContainer.Width \ 2
            Dim y As Integer = Height \ 2 - panelContainer.Height \ 2
            panelContainer.Location = New Point(x, y)
        End Sub

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
