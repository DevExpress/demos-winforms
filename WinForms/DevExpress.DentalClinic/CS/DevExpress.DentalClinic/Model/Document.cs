namespace DevExpress.DentalClinic.Model {
    using System;
    using System.ComponentModel;
    using System.IO;
    using DevExpress.Xpo;

    public class Document : XPObject {
        public Document(Session session)
            : base(session) {
        }
        string nameCore;
        public string Name {
            get { return nameCore; }
            set { SetPropertyValue(nameof(Name), ref nameCore, value); }
        }
        DateTime dateCore;
        public DateTime Date {
            get { return dateCore; }
            set { SetPropertyValue(nameof(Date), ref dateCore, value); }
        }
        [Persistent, Delayed, Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public byte[] Content {
            get { return GetDelayedPropertyValue<byte[]>("Content"); }
            set { SetDelayedPropertyValue<byte[]>("Content", value); }
        }
        [Association("Document-Patient")]
        public XPCollection<Patient> PatientCollection {
            get { return GetCollection<Patient>(); }
        }
        public void LoadFromStream(string fileName, Stream stream) {
            Name = fileName;
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            Content = bytes;
        }
        public void SaveToStream(Stream stream) {
            if(string.IsNullOrEmpty(Name))
                throw new InvalidOperationException();
            stream.Write(Content, 0, Content.Length);
            stream.Flush();
        }
    }
}
