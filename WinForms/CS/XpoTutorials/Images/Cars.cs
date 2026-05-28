using System;
using System.Drawing;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace DevExpress.Xpo.Demos
{
    [Persistent("Model")]
    public class Cars : XPLiteObject {
        int fID;
        [Key]
        public int ID {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        Trademark fTrademark;
        [Persistent("TrademarkID")]
        public Trademark Trademark {
            get { return fTrademark; }
            set { SetPropertyValue(nameof(Trademark), ref fTrademark, value); }
        }
        [PersistentAlias("Trademark.Name")]
        public string TrademarkName {
            get {
                return (string)EvaluateAlias(nameof(TrademarkName));
            }
        }
        string fModel;
        [Size(SizeAttribute.Unlimited)]
        [Persistent("Name")]
        public string Model {
            get { return fModel; }
            set { SetPropertyValue<string>(nameof(Model), ref fModel, value); }
        }
        System.Drawing.Image fPicture;
        [Size(SizeAttribute.Unlimited)]
        [ValueConverter(typeof(DevExpress.Xpo.Metadata.ImageValueConverter))]
        [Persistent("Photo")]
        public System.Drawing.Image Picture {
            get { return fPicture; }
            set { SetPropertyValue<System.Drawing.Image>(nameof(Picture), ref fPicture, value); }
        }
        decimal fPrice;
        public decimal Price {
            get { return fPrice; }
            set { SetPropertyValue<decimal>(nameof(Price), ref fPrice, value); }
        }
        bool fIsInStock;
        [Persistent("InStock")]
        public bool IsInStock {
            get { return fIsInStock; }
            set { SetPropertyValue<bool>(nameof(IsInStock), ref fIsInStock, value); }
        }
        public Cars(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class Trademark : XPLiteObject {
        int fID;
        string fName;
        [Key]
        public int ID {
            get { return fID; }
            set { SetPropertyValue(nameof(ID), ref fID, value); }
        }
        public string Name {
            get { return fName; }
            set { SetPropertyValue(nameof(Name), ref fName, value); }
        }
        public Trademark(Session session) : base(session) { }
    }
}
