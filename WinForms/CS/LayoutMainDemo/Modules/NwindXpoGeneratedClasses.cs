using System;
using DevExpress.Xpo;
namespace DevExpress.XtraLayout.Demos.DBObjects {

    public class Employees : XPLiteObject {
        string fAddress;
        [Size(60)]
        public string Address {
            get { return fAddress; }
            set { SetPropertyValue<string>("Address", ref fAddress, value); }
        }
        DateTime fBirthDate;
        public DateTime BirthDate {
            get { return fBirthDate; }
            set { SetPropertyValue<DateTime>("BirthDate", ref fBirthDate, value); }
        }
        string fCity;
        [Size(15)]
        public string City {
            get { return fCity; }
            set { SetPropertyValue<string>("City", ref fCity, value); }
        }
        string fCountry;
        [Size(15)]
        public string Country {
            get { return fCountry; }
            set { SetPropertyValue<string>("Country", ref fCountry, value); }
        }
        int fEmployeeID;
        [Key(true)]
        public int EmployeeID {
            get { return fEmployeeID; }
            set { SetPropertyValue<int>("EmployeeID", ref fEmployeeID, value); }
        }
        string fExtension;
        [Size(4)]
        public string Extension {
            get { return fExtension; }
            set { SetPropertyValue<string>("Extension", ref fExtension, value); }
        }
        string fFirstName;
        [Size(10)]
        public string FirstName {
            get { return fFirstName; }
            set { SetPropertyValue<string>("FirstName", ref fFirstName, value); }
        }
        DateTime fHireDate;
        public DateTime HireDate {
            get { return fHireDate; }
            set { SetPropertyValue<DateTime>("HireDate", ref fHireDate, value); }
        }
        string fHomePhone;
        [Size(24)]
        public string HomePhone {
            get { return fHomePhone; }
            set { SetPropertyValue<string>("HomePhone", ref fHomePhone, value); }
        }
        string fLastName;
        [Size(20)]
        public string LastName {
            get { return fLastName; }
            set { SetPropertyValue<string>("LastName", ref fLastName, value); }
        }
        string fNotes;
        [Size(SizeAttribute.Unlimited)]
        public string Notes {
            get { return fNotes; }
            set { SetPropertyValue<string>("Notes", ref fNotes, value); }
        }
        byte[] fPhoto;
        public byte[] Photo {
            get { return fPhoto; }
            set { SetPropertyValue<byte[]>("Photo", ref fPhoto, value); }
        }
        string fPostalCode;
        [Size(10)]
        public string PostalCode {
            get { return fPostalCode; }
            set { SetPropertyValue<string>("PostalCode", ref fPostalCode, value); }
        }
        string fRegion;
        [Size(15)]
        public string Region {
            get { return fRegion; }
            set { SetPropertyValue<string>("Region", ref fRegion, value); }
        }
        int fReportsTo;
        public int ReportsTo {
            get { return fReportsTo; }
            set { SetPropertyValue<int>("ReportsTo", ref fReportsTo, value); }
        }
        string fTitle;
        [Size(30)]
        public string Title {
            get { return fTitle; }
            set { SetPropertyValue<string>("Title", ref fTitle, value); }
        }
        string fTitleOfCourtesy;
        [Size(25)]
        public string TitleOfCourtesy {
            get { return fTitleOfCourtesy; }
            set { SetPropertyValue<string>("TitleOfCourtesy", ref fTitleOfCourtesy, value); }
        }
        public Employees(Session session) : base(session) { }
        public Employees() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class Orders : XPLiteObject {
        Customers fCustomerID;
        [Size(5)]
        public Customers CustomerID {
            get { return fCustomerID; }
            set { SetPropertyValue<Customers>("CustomerID", ref fCustomerID, value); }
        }
        Employees fEmployeeID;
        public Employees EmployeeID {
            get { return fEmployeeID; }
            set { SetPropertyValue<Employees>("EmployeeID", ref fEmployeeID, value); }
        }
        decimal fFreight;
        public decimal Freight {
            get { return fFreight; }
            set { SetPropertyValue<decimal>("Freight", ref fFreight, value); }
        }
        DateTime fOrderDate;
        public DateTime OrderDate {
            get { return fOrderDate; }
            set { SetPropertyValue<DateTime>("OrderDate", ref fOrderDate, value); }
        }
        int fOrderID;
        [Key(true)]
        public int OrderID {
            get { return fOrderID; }
            set { SetPropertyValue<int>("OrderID", ref fOrderID, value); }
        }
        DateTime fRequiredDate;
        public DateTime RequiredDate {
            get { return fRequiredDate; }
            set { SetPropertyValue<DateTime>("RequiredDate", ref fRequiredDate, value); }
        }
        string fShipAddress;
        [Size(60)]
        public string ShipAddress {
            get { return fShipAddress; }
            set { SetPropertyValue<string>("ShipAddress", ref fShipAddress, value); }
        }
        string fShipCity;
        [Size(15)]
        public string ShipCity {
            get { return fShipCity; }
            set { SetPropertyValue<string>("ShipCity", ref fShipCity, value); }
        }
        string fShipCountry;
        [Size(15)]
        public string ShipCountry {
            get { return fShipCountry; }
            set { SetPropertyValue<string>("ShipCountry", ref fShipCountry, value); }
        }
        string fShipName;
        [Size(40)]
        public string ShipName {
            get { return fShipName; }
            set { SetPropertyValue<string>("ShipName", ref fShipName, value); }
        }
        DateTime fShippedDate;
        public DateTime ShippedDate {
            get { return fShippedDate; }
            set { SetPropertyValue<DateTime>("ShippedDate", ref fShippedDate, value); }
        }
        string fShipPostalCode;
        [Size(10)]
        public string ShipPostalCode {
            get { return fShipPostalCode; }
            set { SetPropertyValue<string>("ShipPostalCode", ref fShipPostalCode, value); }
        }
        string fShipRegion;
        [Size(15)]
        public string ShipRegion {
            get { return fShipRegion; }
            set { SetPropertyValue<string>("ShipRegion", ref fShipRegion, value); }
        }
        Shippers fShipVia;
        public Shippers ShipVia {
            get { return fShipVia; }
            set { SetPropertyValue<Shippers>("ShipVia", ref fShipVia, value); }
        }
        public Orders(Session session) : base(session) { }
        public Orders() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class Customers : XPLiteObject {
        string fAddress;
        [Size(60)]
        public string Address {
            get { return fAddress; }
            set { SetPropertyValue<string>("Address", ref fAddress, value); }
        }
        string fCity;
        [Size(15)]
        public string City {
            get { return fCity; }
            set { SetPropertyValue<string>("City", ref fCity, value); }
        }
        string fCompanyName;
        [Size(40)]
        public string CompanyName {
            get { return fCompanyName; }
            set { SetPropertyValue<string>("CompanyName", ref fCompanyName, value); }
        }
        string fContactName;
        [Size(30)]
        public string ContactName {
            get { return fContactName; }
            set { SetPropertyValue<string>("ContactName", ref fContactName, value); }
        }
        string fContactTitle;
        [Size(30)]
        public string ContactTitle {
            get { return fContactTitle; }
            set { SetPropertyValue<string>("ContactTitle", ref fContactTitle, value); }
        }
        string fCountry;
        [Size(15)]
        public string Country {
            get { return fCountry; }
            set { SetPropertyValue<string>("Country", ref fCountry, value); }
        }
        string fCustomerID;
        [Key]
        [Size(5)]
        public string CustomerID {
            get { return fCustomerID; }
            set { SetPropertyValue<string>("CustomerID", ref fCustomerID, value); }
        }
        string fFax;
        [Size(24)]
        public string Fax {
            get { return fFax; }
            set { SetPropertyValue<string>("Fax", ref fFax, value); }
        }
        string fPhone;
        [Size(24)]
        public string Phone {
            get { return fPhone; }
            set { SetPropertyValue<string>("Phone", ref fPhone, value); }
        }
        string fPostalCode;
        [Size(10)]
        public string PostalCode {
            get { return fPostalCode; }
            set { SetPropertyValue<string>("PostalCode", ref fPostalCode, value); }
        }
        string fRegion;
        [Size(15)]
        public string Region {
            get { return fRegion; }
            set { SetPropertyValue<string>("Region", ref fRegion, value); }
        }
        public Customers(Session session) : base(session) { }
        public Customers() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class Categories : XPLiteObject {
        int fCategoryID;
        [Key(true)]
        public int CategoryID {
            get { return fCategoryID; }
            set { SetPropertyValue<int>("CategoryID", ref fCategoryID, value); }
        }
        string fCategoryName;
        [Size(15)]
        public string CategoryName {
            get { return fCategoryName; }
            set { SetPropertyValue<string>("CategoryName", ref fCategoryName, value); }
        }
        string fDescription;
        [Size(SizeAttribute.Unlimited)]
        public string Description {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        byte[] fPicture;
        public byte[] Picture {
            get { return fPicture; }
            set { SetPropertyValue<byte[]>("Picture", ref fPicture, value); }
        }
        public Categories(Session session) : base(session) { }
        public Categories() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class Shippers : XPLiteObject {
        string fCompanyName;
        [Size(40)]
        public string CompanyName {
            get { return fCompanyName; }
            set { SetPropertyValue<string>("CompanyName", ref fCompanyName, value); }
        }
        string fPhone;
        [Size(24)]
        public string Phone {
            get { return fPhone; }
            set { SetPropertyValue<string>("Phone", ref fPhone, value); }
        }
        int fShipperID;
        [Key(true)]
        public int ShipperID {
            get { return fShipperID; }
            set { SetPropertyValue<int>("ShipperID", ref fShipperID, value); }
        }
        public Shippers(Session session) : base(session) { }
        public Shippers() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class Products : XPLiteObject {
        Categories fCategoryID;
        public Categories CategoryID {
            get { return fCategoryID; }
            set { SetPropertyValue<Categories>("CategoryID", ref fCategoryID, value); }
        }
        bool fDiscontinued;
        public bool Discontinued {
            get { return fDiscontinued; }
            set { SetPropertyValue<bool>("Discontinued", ref fDiscontinued, value); }
        }
        string fEAN13;
        [Size(12)]
        public string EAN13 {
            get { return fEAN13; }
            set { SetPropertyValue<string>("EAN13", ref fEAN13, value); }
        }
        int fProductID;
        [Key(true)]
        public int ProductID {
            get { return fProductID; }
            set { SetPropertyValue<int>("ProductID", ref fProductID, value); }
        }
        string fProductName;
        [Size(40)]
        public string ProductName {
            get { return fProductName; }
            set { SetPropertyValue<string>("ProductName", ref fProductName, value); }
        }
        string fQuantityPerUnit;
        [Size(20)]
        public string QuantityPerUnit {
            get { return fQuantityPerUnit; }
            set { SetPropertyValue<string>("QuantityPerUnit", ref fQuantityPerUnit, value); }
        }
        short fReorderLevel;
        public short ReorderLevel {
            get { return fReorderLevel; }
            set { SetPropertyValue<short>("ReorderLevel", ref fReorderLevel, value); }
        }
        Suppliers fSupplierID;
        public Suppliers SupplierID {
            get { return fSupplierID; }
            set { SetPropertyValue<Suppliers>("SupplierID", ref fSupplierID, value); }
        }
        decimal fUnitPrice;
        public decimal UnitPrice {
            get { return fUnitPrice; }
            set { SetPropertyValue<decimal>("UnitPrice", ref fUnitPrice, value); }
        }
        short fUnitsInStock;
        public short UnitsInStock {
            get { return fUnitsInStock; }
            set { SetPropertyValue<short>("UnitsInStock", ref fUnitsInStock, value); }
        }
        short fUnitsOnOrder;
        public short UnitsOnOrder {
            get { return fUnitsOnOrder; }
            set { SetPropertyValue<short>("UnitsOnOrder", ref fUnitsOnOrder, value); }
        }
        public Products(Session session) : base(session) { }
        public Products() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class Suppliers : XPLiteObject {
        string fAddress;
        [Size(60)]
        public string Address {
            get { return fAddress; }
            set { SetPropertyValue<string>("Address", ref fAddress, value); }
        }
        string fCity;
        [Size(15)]
        public string City {
            get { return fCity; }
            set { SetPropertyValue<string>("City", ref fCity, value); }
        }
        string fCompanyName;
        [Size(40)]
        public string CompanyName {
            get { return fCompanyName; }
            set { SetPropertyValue<string>("CompanyName", ref fCompanyName, value); }
        }
        string fContactName;
        [Size(30)]
        public string ContactName {
            get { return fContactName; }
            set { SetPropertyValue<string>("ContactName", ref fContactName, value); }
        }
        string fContactTitle;
        [Size(30)]
        public string ContactTitle {
            get { return fContactTitle; }
            set { SetPropertyValue<string>("ContactTitle", ref fContactTitle, value); }
        }
        string fCountry;
        [Size(15)]
        public string Country {
            get { return fCountry; }
            set { SetPropertyValue<string>("Country", ref fCountry, value); }
        }
        string fFax;
        [Size(24)]
        public string Fax {
            get { return fFax; }
            set { SetPropertyValue<string>("Fax", ref fFax, value); }
        }
        string fHomePage;
        [Size(SizeAttribute.Unlimited)]
        public string HomePage {
            get { return fHomePage; }
            set { SetPropertyValue<string>("HomePage", ref fHomePage, value); }
        }
        string fPhone;
        [Size(24)]
        public string Phone {
            get { return fPhone; }
            set { SetPropertyValue<string>("Phone", ref fPhone, value); }
        }
        string fPostalCode;
        [Size(10)]
        public string PostalCode {
            get { return fPostalCode; }
            set { SetPropertyValue<string>("PostalCode", ref fPostalCode, value); }
        }
        string fRegion;
        [Size(15)]
        public string Region {
            get { return fRegion; }
            set { SetPropertyValue<string>("Region", ref fRegion, value); }
        }
        int fSupplierID;
        [Key(true)]
        public int SupplierID {
            get { return fSupplierID; }
            set { SetPropertyValue<int>("SupplierID", ref fSupplierID, value); }
        }
        public Suppliers(Session session) : base(session) { }
        public Suppliers() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
