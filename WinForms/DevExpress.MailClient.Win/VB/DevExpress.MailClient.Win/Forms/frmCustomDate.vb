Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class frmCustomDate
        Inherits XtraForm

        Private currentTask As Task
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal task As Task)
            InitializeComponent()
            Me.currentTask = task
            If task.StartDate.HasValue Then
                dateEdit1.DateTime = task.StartDate.Value
            End If
            If task.DueDate.HasValue Then
                dateEdit2.DateTime = task.DueDate.Value
            End If
        End Sub
        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            MyBase.OnClosing(e)
            If DialogResult = DialogResult.OK Then
                If dateEdit1.DateTime > Date.MinValue Then
                    currentTask.StartDate = dateEdit1.DateTime
                Else
                    currentTask.StartDate = Nothing
                End If
                If dateEdit2.DateTime > Date.MinValue Then
                    currentTask.DueDate = dateEdit2.DateTime
                Else
                    currentTask.DueDate = Nothing
                End If
            End If
        End Sub
    End Class
End Namespace
