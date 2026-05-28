Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.WindowsMailClient.Win.Data
Imports DevExpress.WindowsMailClient.Win.Model

Namespace DevExpress.WindowsMailClient.Win.ViewModels

    Public Class MailViewModel

        Public Sub SaveMessageToDrafts(ByVal text As String, ByVal subjects As String, ByVal toEditValue As Object, ByVal fromEditValue As Object)
            Dim currentMessage As Message = New Message()
            currentMessage.MailType = MailType.Draft
            SetMessageData(currentMessage, text, subjects, toEditValue, fromEditValue)
            MailClientDataModel.Messages.Add(currentMessage)
        End Sub

        Private Sub SetMessageData(ByVal currentMessage As Message, ByVal text As String, ByVal subject As String, ByVal toEditValue As Object, ByVal fromEditValue As Object)
            currentMessage.Date = Date.Now
            currentMessage.Text = text
            currentMessage.SetPlainText(ObjectHelper.GetPlainTextFromMHT(text))
            Dim subj As String = subject
            If String.IsNullOrEmpty(subject) OrElse Equals(subject, " Subject:") Then
                subj = "Subject"
            End If

            currentMessage.Subject = subj
            currentMessage.MailType = MailType.Draft
            Dim toContacts As IList(Of Object) = TryCast(toEditValue, IList(Of Object))
            If toContacts IsNot Nothing AndAlso toContacts.Count = 1 Then currentMessage.Email = Enumerable.First(toContacts).ToString()
            Dim fromContacts As IList(Of Object) = TryCast(fromEditValue, IList(Of Object))
            If fromContacts IsNot Nothing AndAlso fromContacts.Count = 1 Then
                currentMessage.From = Enumerable.First(fromContacts).ToString()
            Else
                currentMessage.From = Utils.MessageFrom
            End If
        End Sub
    End Class
End Namespace
