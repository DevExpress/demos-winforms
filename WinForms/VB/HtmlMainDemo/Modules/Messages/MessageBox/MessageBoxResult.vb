Imports DevExpress.XtraEditors
Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.HTML.Demos

    Public Partial Class MessageBoxResult
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub Output(ByVal val As Object)
            memoEdit1.Text += val.ToString() & Environment.NewLine
            memoEdit1.SelectionStart = Integer.MaxValue
            memoEdit1.ScrollToCaret()
        End Sub
    End Class
End Namespace
