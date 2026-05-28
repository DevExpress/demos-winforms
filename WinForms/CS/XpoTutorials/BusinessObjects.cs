using System;
using DevExpress.Xpo;

namespace DevExpress.Xpo.Demos
{
	public class BusinessObject	: XPObject {
		public BusinessObject()	{}
        public BusinessObject(Session session) : base(session)	{}
        public BusinessObject(Session session, string fText, bool fChecked, float fCurrency) : base(session) {
            this.fText = fText;
            this.fChecked = fChecked;
            this.fCurrency = fCurrency;
        }

        private string fText;
        private bool fChecked;
        private float fCurrency;

        public string Text {
            get { return fText; }
            set {
                // The old value of the Text property.
                string oldValue = Text;
                if(oldValue == value)
                    return;
                fText = value;
                // Keep track of every change made to the Text property.
                OnChanged(nameof(Text), oldValue, value);
            }
        }
        public bool Checked {
            get { return fChecked; }
            set {
                bool oldValue = Checked;
                if(oldValue == value)
                    return;
                fChecked = value;
                OnChanged(nameof(Checked), oldValue, value);
            }
        }
        public float Currency {
            get { return fCurrency; }
            set {
                float oldValue = Currency;
                if(oldValue == value)
                    return;
                fCurrency = value;
                OnChanged(nameof(Currency), oldValue, value);
            }
        }
	}
}
