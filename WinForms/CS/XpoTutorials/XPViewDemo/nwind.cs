using System;
using DevExpress.Xpo;
namespace DevExpress.Xpo.Demos.Tutorials {
	[OptimisticLocking(false)]
	public class Shippers : XPBaseObject {
		public string CompanyName;
		public string Phone;
		[Key]
		public int ShipperID;
        public Shippers(Session session)
            : base(session) {
        }
	}

	[OptimisticLocking(false)]
	public class Suppliers : XPBaseObject {
		public string Address;
		public string City;
		public string CompanyName;
		public string ContactName;
		public string ContactTitle;
		public string Country;
		public string Fax;
		public string HomePage;
		public string Phone;
		public string PostalCode;
		public string Region;
		[Association("Product_Supplier", typeof(Products))]
		public XPCollection Products {
			get {
				return GetCollection(nameof(Products));
			}
		}
		[Key]
		public int SupplierID;
        public Suppliers(Session session)
            : base(session) {
        }
	}

	public struct OrderDetailsKey {
		[Association("Order_OrderDetail")]
		[Persistent("OrderID")]
		public Orders OrderID;
		[Persistent("ProductID")]
		public Products ProductID;
	}
	
	[OptimisticLocking(false)]
	[Persistent("Order Details")]
	public class OrderDetails : XPBaseObject {
        public OrderDetails(Session session)
            : base(session) {
        }
		public System.Single Discount;
		[Key, Persistent]
		public OrderDetailsKey Key;
		public short Quantity;
		public decimal UnitPrice;
	}

	[OptimisticLocking(false)]
	public class Employees : XPBaseObject {
		public string Address;
		public DateTime BirthDate;
		public string City;
		public string Country;
		[Key]
		public int EmployeeID;
		public string Extension;
		public string FirstName;
		public DateTime HireDate;
		public string HomePhone;
		public string LastName;
		public string Notes;
		public byte[] Photo;
		public string PostalCode;
		public string Region;
		public int ReportsTo;
		public string Title;
		public string TitleOfCourtesy;
        public Employees(Session session)
            : base(session) {
        }
	}

	[OptimisticLocking(false)]
	public class Orders : XPBaseObject {
		public Customers CustomerID;
		public Employees EmployeeID;
		public decimal Freight;
		public DateTime OrderDate;
		[Key]
		public int OrderID;
		public DateTime RequiredDate;
		public string ShipAddress;
		public string ShipCity;
		public string ShipCountry;
		public string ShipName;
		public DateTime ShippedDate;
		public string ShipPostalCode;
		public string ShipRegion;
		public Shippers ShipVia;
		[Association("Order_OrderDetail", typeof(OrderDetails))]
		public XPCollection OrderDetails {
			get {
				return GetCollection(nameof(OrderDetails));
			}
		}
        public Orders(Session session)
            : base(session) {
        }
	}

	[OptimisticLocking(false)]
	public class Categories : XPBaseObject {
		[Key]
		public int CategoryID;
		public string CategoryName;
		public string Description;
		public byte[] Picture;
        public Categories(Session session)
            : base(session) {
        }
	}

	[OptimisticLocking(false)]
	public class Products : XPBaseObject {
		public Categories CategoryID;
		public bool Discontinued;
		public string EAN13;
		[Key]
		public int ProductID;
		public string ProductName;
		public string QuantityPerUnit;
		public short ReorderLevel;
		[Association("Product_Supplier")]
		public Suppliers SupplierID;
		public decimal UnitPrice;
		public short UnitsInStock;
		public short UnitsOnOrder;
        public Products(Session session)
            : base(session) {
        }
	}

	[OptimisticLocking(false)]
	public class Customers : XPBaseObject {
		public string Address;
		public string City;
		public string CompanyName;
		public string ContactName;
		public string ContactTitle;
		public string Country;
		[Key]
		public string CustomerID;
		public string Fax;
		public string Phone;
		public string PostalCode;
		public string Region;
        public Customers(Session session)
            : base(session) {
        }
	}
}
