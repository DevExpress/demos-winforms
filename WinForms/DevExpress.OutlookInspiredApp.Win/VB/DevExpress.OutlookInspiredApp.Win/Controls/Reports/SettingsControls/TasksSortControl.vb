Imports System
Imports System.Windows.Forms
Imports DevExpress.DevAV.Common.Utils

Namespace DevExpress.DevAV

    Public Partial Class TasksSortControl
        Inherits UserControl

        Private callback As Action(Of Boolean)

        Private defaultValue As Boolean

        Public Sub New()
            InitializeComponent()
            SwapFluentIcons(Me)
        End Sub

        Public Sub New(ByVal callback As Action(Of Boolean), ByVal defaultValue As Boolean)
            Me.New()
            Me.callback = callback
            Me.defaultValue = defaultValue
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If defaultValue Then
                btnDueDate.Checked = True
            Else
                btnStartDate.Checked = True
            End If
        End Sub

        Private Sub btnDueDate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If callback IsNot Nothing Then callback(True)
        End Sub

        Private Sub btnStartDate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If callback IsNot Nothing Then callback(False)
        End Sub
    End Class
End Namespace
