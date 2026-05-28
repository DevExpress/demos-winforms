Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class frmReminders
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Public ReadOnly Property CurrentTask() As Task
            Get
                Return TryCast(gridView1.GetRow(gridView1.FocusedRowHandle), Task)
            End Get
        End Property
        Friend Sub InitData(ByVal list As List(Of Task))
            gridControl1.DataSource = list
            Text = String.Format("{0} Reminder{1}", list.Count,If(list.Count > 1, "s", String.Empty))
        End Sub

        Private Sub gridView1_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs) Handles gridView1.FocusedRowObjectChanged
            lbSubject.Text = String.Format("<image=#BO_Task><size=+2> <b>{0}", CurrentTask.Subject)
            lbDueDate.Text = String.Format("Due: {0:ddd, MMMM dd, yyyy}", CurrentTask.DueDate)
        End Sub

        Private Sub gridView1_RowCellClick(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView1.RowCellClick
            If CurrentTask Is Nothing Then
                Return
            End If
            If e.Button = MouseButtons.Left AndAlso e.RowHandle >= 0 AndAlso e.Clicks = 2 Then
                OkClick()
            End If
        End Sub
        Private Sub OkClick()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Close()
        End Sub
        Private Sub gridView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView1.KeyDown
            If e.KeyData = Keys.Enter Then
                OkClick()
            End If
        End Sub
    End Class
End Namespace
