using System.Collections.Generic;
using System.Linq;
using DevExpress.DXperience.Demos;
using DevExpress.WindowsMailClient.Win.Data;
using DevExpress.WindowsMailClient.Win.Model;

namespace DevExpress.WindowsMailClient.Win.ViewModels {
    public class MailViewModel {
        public void SaveMessageToDrafts(string text, string subjects, object toEditValue, object fromEditValue) {
            Message currentMessage = new Message();
            currentMessage.MailType = MailType.Draft;
            SetMessageData(currentMessage, text, subjects, toEditValue, fromEditValue);
            MailClientDataModel.Messages.Add(currentMessage);
        }
        void SetMessageData(Message currentMessage, string text, string subject, object toEditValue, object fromEditValue) {
            currentMessage.Date = TutorialConstants.Now;
            currentMessage.Text = text;
            currentMessage.SetPlainText(ObjectHelper.GetPlainTextFromMHT(text));
            string subj = subject;
            if(string.IsNullOrEmpty(subject) || subject == " Subject:") {
                subj = "Subject";
            }
            currentMessage.Subject = subj;
            currentMessage.MailType = MailType.Draft;
            IList<object> toContacts = toEditValue as IList<object>;
            if(toContacts != null && toContacts.Count == 1)
                currentMessage.Email = toContacts.First().ToString();
            IList<object> fromContacts = fromEditValue as IList<object>;
            if(fromContacts != null && fromContacts.Count == 1)
                currentMessage.From = fromContacts.First().ToString();
            else currentMessage.From = Utils.Utils.MessageFrom;
        }
    }
}
