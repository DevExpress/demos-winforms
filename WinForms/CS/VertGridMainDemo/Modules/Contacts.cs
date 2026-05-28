using DevExpress.DXperience.Demos;
using System;
using System.Collections;

namespace DevExpress.XtraVerticalGrid.Demos {
	public class Contacts : ArrayList {
		public Contacts() {
            this.Add(new Contact(1, "John", "Doe", "Doe Enterprises", "123 Home Lane", "Homesville", "CA", "74561", "(555)956-15-47", true, DateTime.Parse("12/02/2001", System.Globalization.CultureInfo.InvariantCulture), "Programmer", 1, "Enjoys horseback riding and paints.", "M", "VS", 199.99, TutorialConstants.Now, 0, 4));
            this.Add(new Contact(2, "Karen", "Holmes", "Holmes World", "933 Heart St. Suite ", "Chicago", "IL", "55561", "(555)342-25-74", false, DateTime.Parse("11/11/2002", System.Globalization.CultureInfo.InvariantCulture), "Doctor", 2, "Has five children. Loves to travel.", "F", "AM", 78.25, TutorialConstants.Now, 1, 4));
            this.Add(new Contact(3, "Frank", "Frankson", "Frankson Media", "349 Graphic Design L", "Newman", "OK", "12458", "(555)155-05-02", true, DateTime.Parse("01/01/2002", System.Globalization.CultureInfo.InvariantCulture), "Retired", 0, "Retired. Enjoys travel and bungee jumping.", "M", "VS", 1299, TutorialConstants.Now, 0, 9));
            this.Add(new Contact(4, "Leticia", "Ford", "Ford Consulting", "93900 Carter Lane", "Cartersville", "GA", "19564", "(555)776-15-66", true, DateTime.Parse("10/07/2002", System.Globalization.CultureInfo.InvariantCulture), "Engineer", 1, "none", "F", "MS", 354.12, TutorialConstants.Now, 2, 3));
            this.Add(new Contact(5, "Henry", "McAllister", "McAllister Systems", "436 1st Ave.", "Cleveland", "OH", "99523", "(555)941-24-32", false, DateTime.Parse("09/08/2002", System.Globalization.CultureInfo.InvariantCulture), "Programmer", 0, "Enjoys fishing, skiing, and skydiving.", "M", "CS", 9.99, TutorialConstants.Now, 3, 1));
            this.Add(new Contact(6, "Roger", "Michelson", "Michelson Systems", "3920 Michelson Dr.", "Bridgeford", "CT", "74123", "(555)954-51-88", true, DateTime.Parse("06/04/2001", System.Globalization.CultureInfo.InvariantCulture), "Special agent", 2, "Archery, windsurfing and food.", "M", "VS", 520, TutorialConstants.Now, 4, 2));
		}
	}
	public class Products : ArrayList {
		public Products() {
			this.Add(new Product(0, "XtraGrid", "The first and most comprehensive 100% native grid control suite for Visual Studio .NET!"));
			this.Add(new Product(1, "XtraEditors", "Like the XtraGrid, the XtraEditors Library is the first comprehensive suite of individual field editors - written from groud-up using the C# programming language."));
			this.Add(new Product(2, "XtraBars", "The XtraBars is our 100% native .NET component library which fully emulates the menu/toolbar and sidebar navigation systems introduced in MS Office(c) XP and the .NET IDE."));
			this.Add(new Product(3, "XtraTreeList", "The XtraTreeList Suite is our 100% native .NET component library which allows you to break passed the traditional limits of treeview controls and represent information - be it in bound or unbound mode - to your end users in an intuitive TreeList metaphor."));
			this.Add(new Product(4, "XtraPrinting", "The XtraPrinting Library is the perfect support library for those using the XtraGrid and XtraTreeList Suite."));
			this.Add(new Product(5, "XtraNavBar", "Bring the User Interface of Windows XP - MS Office - and Visual Studio .NET to your applications with the most advanced navigation bar available for .NET."));
			this.Add(new Product(6, "ASPxGrid", "An ultra-advanced Outlook(c) style WebForms Grid control engineered specifically for ASP.NET."));
		}
	}
	public class Contact {
		private int clientIDCore;
		private string firstNameCore;
		private string lastNameCore;
		private string companyNameCore;
		private string addressCore; 
		private string cityCore;
		private string stateCore;
		private string zipCodeCore;
		private string phoneCore;
		private bool customerCore;
		private DateTime dateOpenCore;
		private string occupationCore;
		private int riskLevelCore;
		private string interestCore;
		private string genderCore;
		private string paymentTypeCore;
		private double paymentAmountCore;
		private DateTime paymentDateCore;
		private int productIDCore;
		private int copiesCore;
 
		public Contact(int clientID, string firstName, string lastName, string companyName,
			string address, string city, string state, string zipCode, string phone,
			bool customer, DateTime dateOpen, string occupation, int riskLevel, string interest, 
			string gender, string paymentType, double paymentAmount, DateTime paymentDate, int productID, int copies) {
			this.clientIDCore = clientID;
			this.firstNameCore = firstName;
			this.lastNameCore = lastName;
			this.companyNameCore = companyName;
			this.addressCore = address; 
			this.cityCore = city;
			this.stateCore = state;
			this.zipCodeCore = zipCode;
			this.phoneCore = phone;
			this.customerCore = customer;
			this.dateOpenCore = dateOpen;
			this.occupationCore = occupation;
			this.riskLevelCore = riskLevel;
			this.interestCore = interest;
			this.genderCore = gender;
			this.paymentTypeCore = paymentType;
			this.paymentAmountCore = paymentAmount;
			this.paymentDateCore = paymentDate;
			this.productIDCore = productID;
			this.copiesCore = copies;
		}

		public int ClientID {
			get { return clientIDCore; }
		}
		public string FirstName {
			get { return firstNameCore; }
			set { firstNameCore = value; }
		}
		public string LastName {
			get { return lastNameCore; }
			set { lastNameCore = value; }
		}
		public string CompanyName {
			get { return companyNameCore; }
			set { companyNameCore = value; }
		}
		public string Address {
			get { return addressCore; }
			set { addressCore = value; }
		} 
		public string City {
			get { return cityCore; }
			set { cityCore = value; }
		}
		public string State {
			get { return stateCore; }
			set { stateCore = value; }
		}
		public string ZipCode {
			get { return zipCodeCore; }
			set { zipCodeCore = value; }
		}
		public string Phone {
			get { return phoneCore; }
			set { phoneCore = value; }
		}
		public bool Customer {
			get { return customerCore; }
			set { customerCore = value; }
		}
		public DateTime DateOpen {
			get { return dateOpenCore; }
			set { dateOpenCore = value; }
		}
		public string Occupation {
			get { return occupationCore; }
			set { occupationCore = value; }
		}
		public int RiskLevel {
			get { return riskLevelCore; }
			set { riskLevelCore = value; }
		}
		public string Interest {
			get { return interestCore; }
			set { interestCore = value; }
		}
		public string Gender {
			get { return genderCore; }
			set { genderCore = value; }
		}
		public string PaymentType {
			get { return paymentTypeCore; }
			set { paymentTypeCore = value; }
		}
		public double PaymentAmount {
			get { return paymentAmountCore; }
			set { paymentAmountCore = value; }
		}
		public DateTime PaymentDate {
			get { return paymentDateCore; }
			set { paymentDateCore = value; }
		}
		public int ProductID {
			get { return productIDCore; }
			set { productIDCore = value; }
		}
		public int Copies {
			get { return copiesCore; }
			set { copiesCore = value; }
		}
	}
	public class Product {
		private int idCore;
		private string nameCore;
		private string descriptionCore;
		public Product(int id, string name, string description) {
			this.idCore = id;
			this.nameCore = name;
			this.descriptionCore = description;
		}
		public int ID {
			get { return idCore; }
		}
		public string Name {
			get { return nameCore; }
		}
		public string Description {
			get { return descriptionCore; }
		}
	}
}
