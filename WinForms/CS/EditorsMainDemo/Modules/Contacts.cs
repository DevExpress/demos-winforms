using System;
using System.Collections;
using System.Drawing;

namespace DevExpress.XtraEditors.Demos {
	public class ContactList : System.Collections.CollectionBase {
		public static ContactList GetContacts() {
			ContactList cl = new ContactList();
			cl.Add(Contact.ReadContact1());
			cl.Add(Contact.ReadContact2());
			cl.Add(Contact.ReadContact3());
			cl.Add(Contact.ReadContact4());
			cl.Add(Contact.ReadContact5());
			return cl;
		}

		public Contact this[int index] {
			get {return (Contact)(List[index]);}
			set {List[index] = value;}
		}
        
		public int Add(Contact value) {
			return List.Add(value);
		}
        
		public void Insert(int index, Contact value) {
			List.Insert(index, value);
		}
        
		public int IndexOf(Contact value) {
			return List.IndexOf(value);
		}
        
		public bool Contains(Contact value) {
			return List.Contains(value);
		}
        
		public void Remove(Contact value) {
			List.Remove(value);
		}
        
		public void CopyTo(Contact[] array, int index) {
			List.CopyTo(array, index);
		}
	}

	public class Contact {
		private string fID;
		private string fName;
		private DateTime fPurchaseDate;
		private double fPaymentAmount; 

		internal Contact(string ID): base() {
			this.fID = ID;    
		}
		public string ID { 
			get  {return fID;}
		}
		public string Name { 
			get  {return fName;}
			set {fName = value;}
		}
		public DateTime PurchaseDate { 
			get  {return fPurchaseDate;}
			set {fPurchaseDate = value;}
		}
		public double PaymentAmount { 
			get  {return fPaymentAmount;}
			set {fPaymentAmount = value;}
		}
		
		internal static Contact ReadContact1() {
			Contact c = new Contact("1");
			c.Name = "John Doe";
			c.PurchaseDate = Parse("5/3/2013");
			c.PaymentAmount = 330.99;
			return c;
		}

		internal static Contact ReadContact2() {
			Contact c = new Contact("2");
			c.Name = "Sam Hill";
			c.PurchaseDate = Parse("5/7/2014");
			c.PaymentAmount = 100.0;
			return c;
		}

		internal static Contact ReadContact3() {
			Contact c = new Contact("3");
			c.Name = "Karen Holmes";
			c.PurchaseDate = Parse("7/11/2014");
			c.PaymentAmount = 230.50;
			return c;
		}

		internal static Contact ReadContact4() {
			Contact c = new Contact("4");
			c.Name = "Bobbie Valentine";
            c.PurchaseDate = Parse("6/1/2013");
			c.PaymentAmount = 550.1;
			return c;
		}

		internal static Contact ReadContact5() {
			Contact c = new Contact("5");
			c.Name = "Frank Frankson";
			c.PurchaseDate = Parse("2/2/2012");
			c.PaymentAmount = 50.0;
			return c;
		}
        static DateTime Parse(string dateTime) {            
            return DateTime.Parse(dateTime, System.Globalization.CultureInfo.InvariantCulture);
        }
	}
	// <lookUpEdit3>
	public class Record {
		private string fCountry;
		
		public Record(string fCountry) {
			this.fCountry = fCountry;
		}

		public string Country {
			get { return fCountry; }
			set { fCountry = value; }
		}
	}
	// </lookUpEdit3>
}
