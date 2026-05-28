Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos

    Public Partial Class ProgressForm
        Inherits XtraEditors.XtraForm

        Public Sub New(ByVal parent As Form)
            InitializeComponent()
            If parent IsNot Nothing Then
                Left = parent.Left + CInt((parent.Width - Width) \ 2)
                Top = parent.Top + CInt((parent.Height - Height) \ 2)
            End If

            Height = progressBarControl1.Height + progressBarControl1.Top * 2 + 4
        End Sub

        Public Sub SetProgressValue(ByVal position As Integer)
            progressBarControl1.Position = position
            Update()
        End Sub
    End Class
End Namespace
