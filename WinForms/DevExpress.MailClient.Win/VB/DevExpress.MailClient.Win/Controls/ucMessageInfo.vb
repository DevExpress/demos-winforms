Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports System.Collections

Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class ucMessageInfo
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            If RightToLeft = System.Windows.Forms.RightToLeft.Yes Then
                tabbedControlGroup1.TextLocation = Utils.Locations.Right
            End If
        End Sub
        Public Sub Init(ByVal message As Message, ByVal menuManager As IDXMenuManager)
            gridControl1.MenuManager = menuManager
            lcName.Text = message.From
            pictureEdit1.Image = DataHelper.GetPhotoByEmail(message.Email)
            If pictureEdit1.Image Is Nothing Then
                pictureEdit1.Image = My.Resources.Unknown_user
            End If
            gridControl1.DataSource = GetMailByContactData(message)
            lcgContact.Text = My.Resources.Contact
            lcgMail.Text = String.Format("{0} ({1})", My.Resources.Mail, gridView1.DataRowCount)
        End Sub
        Private Function GetMailByContactData(ByVal messageMain As Message) As Object
            Dim ret As IEnumerable = From message In DataHelper.Messages
                                     Where message.From = messageMain.From AndAlso message.MailType = MailType.Inbox
                                     Select message
            Return ret.Cast(Of Message)().ToList()
        End Function
    End Class
End Namespace
