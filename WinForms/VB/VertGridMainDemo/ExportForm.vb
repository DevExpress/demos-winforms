Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Partial Class ProgressForm
        Inherits XtraEditors.XtraForm

        Public Sub New(ByVal parent As Form)
            InitializeComponent()
            If parent IsNot Nothing Then
                Left = parent.Left + (parent.Width - Width) \ 2
                Top = parent.Top + (parent.Height - Height) \ 2
            End If

            Height = progressBarControl1.Height + progressBarControl1.Top * 2 + 4
        End Sub

        Public Sub SetProgressValue(ByVal position As Integer)
            progressBarControl1.Position = position
            Update()
        End Sub
    End Class
End Namespace
