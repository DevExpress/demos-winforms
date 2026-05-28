Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraNavBar.Demos

    ''' <summary>
    ''' Summary description for NavBarInfo.
    ''' </summary>
    Public Partial Class NavBarInfo
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim btn As SimpleButton = TryCast(sender, SimpleButton)
            Dim frm As XtraForm = New XtraForm()
            Dim mEdit As MemoEdit = New MemoEdit()
            mEdit.Dock = DockStyle.Fill
            mEdit.Text = GetNavBarInfo(navBarControl1)
            mEdit.Select(0, 0)
            frm.Controls.Add(mEdit)
            frm.Location = btn.PointToScreen(New Point(btn.Width \ 2, btn.Height \ 2))
            frm.StartPosition = FormStartPosition.Manual
            frm.FormBorderStyle = FormBorderStyle.SizableToolWindow
            frm.Text = "NavBar Control"
            frm.ShowDialog()
        End Sub

        '<button1>
        Private Function GetNavBarInfo(ByVal nbc As NavBarControl) As String
            Dim s As String = "Items:" & Microsoft.VisualBasic.Constants.vbCrLf
            For i As Integer = 0 To nbc.Items.Count - 1
                s += " Item" & i.ToString() & ": " & nbc.Items(i).Caption & Microsoft.VisualBasic.Constants.vbCrLf
            Next

            s += Microsoft.VisualBasic.Constants.vbCrLf & "Groups:" & Microsoft.VisualBasic.Constants.vbCrLf
            For i As Integer = 0 To nbc.Groups.Count - 1
                s += "  Group" & i.ToString() & ": " & nbc.Groups(i).Caption & Microsoft.VisualBasic.Constants.vbCrLf
                s += "    ItemLinks:" & Microsoft.VisualBasic.Constants.vbCrLf
                For j As Integer = 0 To nbc.Groups(i).ItemLinks.Count - 1
                    s += "      Link" & j.ToString() & ": " & nbc.Groups(i).ItemLinks(j).Caption & Microsoft.VisualBasic.Constants.vbCrLf
                Next
            Next

            Return s
        End Function
    '</button1>
    End Class
End Namespace
