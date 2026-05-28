namespace DevExpress.DentalClinic.Model {
    using DevExpress.Xpo;

    public class Address : XPObject {
        public Address(Session uow) 
            : base(uow) { 
        }
        //
        string streetCore;
        public string Street {
            get { return streetCore; }
            set { SetPropertyValue(nameof(Street), ref streetCore, value); }
        }
        string stateCore;
        public string State {
            get { return stateCore; }
            set { SetPropertyValue(nameof(State), ref stateCore, value); }
        }
        string cityCore;
        public string City {
            get { return cityCore; }
            set { SetPropertyValue(nameof(City), ref cityCore, value); }
        }
        string zipCodeCore;
        public string ZipCode {
            get { return zipCodeCore; }
            set { SetPropertyValue(nameof(ZipCode), ref zipCodeCore, value); }
        }
    }
}
