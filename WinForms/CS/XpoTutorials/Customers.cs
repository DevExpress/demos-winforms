using System;
using DevExpress.Xpo;

namespace DevExpress.Xpo.Demos {

    //<gControl1>
    //<gridControl1>
    public class Customer : XPObject {
        //</gridControl1>
        public Customer() {}
        public Customer(Session session) : base(session) {}

        private string name;
        private int age;

        public string Name {
            get { return name; }
            set {
                // The old value of the Name property.
                string oldValue = Name;
                if(oldValue == value)
                    return;
                name = value;
                // Keep track of every change made to the Name property.
                OnChanged(nameof(Name), oldValue, value);
            }
        }

        public int Age {
            get { return age; }
            set {
                int oldValue = Age;
                if(oldValue == value)
                    return;
                age = value;
                OnChanged(nameof(Age), oldValue, value);
            }
        }
        //</gControl1>

        //<gridControl1>
        [Association("Customer-Orders", typeof(Order)), Aggregated]
        public XPCollection Orders { get { return GetCollection(nameof(Orders)); } }
        //<gControl1>
    }
    //</gControl1>

    public class Order : XPObject {

        [Association("Customer-Orders")]
        public Customer Customer;
        //</gridControl1>

        private string productName;
        private DateTime orderDate;

        public string ProductName {
            get { return productName; }
            set {
                string oldValue = ProductName;
                if(oldValue == value)
                    return;
                productName = value;
                OnChanged(nameof(ProductName), oldValue, value);
            }
        }

        public DateTime OrderDate {
            get { return orderDate; }
            set {
                DateTime oldValue = OrderDate;
                if(oldValue == value)
                    return;
                orderDate = value;
                OnChanged(nameof(OrderDate), oldValue, value);
            }
        }
        //<gridControl1>
    }
    //</gridControl1>
}
