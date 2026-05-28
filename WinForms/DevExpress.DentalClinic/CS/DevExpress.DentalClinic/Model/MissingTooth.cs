namespace DevExpress.DentalClinic.Model {
    using DevExpress.Xpo;

    public class MissingTooth : XPObject {
        public MissingTooth(Session session) 
            : base(session) {
        }
        Patient patientCore;
        [Association]
        public Patient Patient {
            get { return patientCore; }
            set { SetPropertyValue(nameof(Patient), ref patientCore, value); }
        }
        int numberCore;
        public int Number {
            get { return numberCore; }
            set { SetPropertyValue(nameof(Number), ref numberCore, value); }
        }
    }
}
