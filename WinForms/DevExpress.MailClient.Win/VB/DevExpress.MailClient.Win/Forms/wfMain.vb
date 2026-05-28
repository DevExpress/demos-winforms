Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraWaitForm

Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class wfMain
        Inherits DemoWaitForm
        Public Sub New()
            InitializeComponent()
            ProgressPanel.Caption = My.Resources.ProgressPanelCaption
            ProgressPanel.Description = My.Resources.ProgressPanelDescription
        End Sub
    End Class
End Namespace
