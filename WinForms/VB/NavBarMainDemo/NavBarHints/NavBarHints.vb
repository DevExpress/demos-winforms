Imports System
Imports System.Drawing
Imports System.ComponentModel

Namespace DevExpress.XtraNavBar.Demos

    ''' <summary>
    ''' Summary description for NavBarHints.
    ''' </summary>
    Public Partial Class NavBarHints
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            InitProperties()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private Sub InitProperties()
            ceGroupHint.Checked = navBarControl1.ShowGroupHint
            ceLinkHint.Checked = navBarControl1.ShowLinkHint
            seInterval.Value = navBarControl1.ShowHintInterval
        End Sub

        '<ceCustomHint>
        Private Sub navBarControl1_GetHint(ByVal sender As Object, ByVal e As NavBarGetHintEventArgs)
            If Not ceCustomHint.Checked Then Return
            Dim s As String = "This is a custom hint for the "
            If e.Group IsNot Nothing Then e.Hint = s & e.Group.Caption & " group"
            If e.Link IsNot Nothing Then e.Hint = s & e.Link.Caption & " link"
        End Sub

        '</ceCustomHint>
        '<ceGroupHint>
        Private Sub ceGroupHint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            navBarControl1.ShowGroupHint = ceGroupHint.Checked
        End Sub

        '</ceGroupHint>
        '<ceLinkHint>
        Private Sub ceLinkHint_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            navBarControl1.ShowLinkHint = ceLinkHint.Checked
        End Sub

        '</ceLinkHint>
        '<seInterval>
        Private Sub seInterval_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            navBarControl1.ShowHintInterval = Convert.ToInt32(seInterval.Value)
        End Sub
    '</seInterval>
    End Class
End Namespace
