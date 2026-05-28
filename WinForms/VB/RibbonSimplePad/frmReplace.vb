Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad

    Public Partial Class frmReplace
        Inherits XtraEditors.XtraForm

        Private rtb As RichTextBox

        Public ReadOnly Property RichText As RichTextBox
            Get
                Return rtb
            End Get
        End Property

        Public Sub New(ByVal r As RichTextBox, ByVal rec As Rectangle)
            rtb = r
            InitializeComponent()
            txtFind.Text = rtb.SelectedText
            Location = New Point(rec.X + (rec.Width - Width) \ 2, rec.Y + (rec.Height - Height) \ 2)
            txtFind_TextChanged(Nothing, Nothing)
        End Sub

        Protected ReadOnly Property FindsOptions As RichTextBoxFinds
            Get
                Dim rtf As RichTextBoxFinds = New RichTextBoxFinds()
                If chWholeword.Checked Then rtf = rtf Or RichTextBoxFinds.WholeWord
                If chCase.Checked Then rtf = rtf Or RichTextBoxFinds.MatchCase
                Return rtf
            End Get
        End Property

        Protected Sub MessageNotFound(ByVal p As Integer)
            If p = -1 Then XtraEditors.XtraMessageBox.Show("The search text is not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Protected Function Find() As Integer
            Return rtb.Find(txtFind.Text, rtb.SelectionStart + rtb.SelectionLength, rtb.MaxLength, FindsOptions)
        End Function

        Protected Function FindForReplace() As Integer
            Return rtb.Find(txtFind.Text, rtb.SelectionStart, rtb.MaxLength, FindsOptions)
        End Function

        Private Sub btnFindNext_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageNotFound(Find())
        End Sub

        Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            btnFindNext.Enabled = Not Equals(txtFind.Text, "")
            btnReplace.Enabled = btnFindNext.Enabled
            btnReplaceAll.Enabled = btnFindNext.Enabled
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Owner.Focus()
            Close()
        End Sub

        Private Sub btnReplace_Click(ByVal sender As Object, ByVal e As EventArgs)
            If FindForReplace() <> -1 Then
                rtb.SelectedText = txtReplace.Text
            Else
                MessageNotFound(-1)
            End If
        End Sub

        Private Sub btnReplaceAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim r As Integer = -1
            Dim p As Integer = 0
            rtb.SelectionStart = 0
            rtb.SelectionLength = 0
            While p <> -1
                p = Find()
                If p <> -1 Then
                    r += 1
                    rtb.SelectedText = txtReplace.Text
                End If
            End While

            MessageNotFound(r)
        End Sub
    End Class
End Namespace
