using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace DevExpress.Xpo.Demos {
    public class Worker : XPObject {
        private string _FirstName;
        private string _LastName;
        private int _Age;
        private string _Company;

        public string LastName {
            get { return _LastName; }
            set { SetPropertyValue(nameof(LastName), ref _LastName, value); }
        }
        public string FirstName {
            get { return _FirstName; }
            set { SetPropertyValue(nameof(FirstName), ref _FirstName, value); }
        }
        public int Age {
            get { return _Age; }
            set { SetPropertyValue(nameof(Age), ref _Age, value); }
        }
        public string Company {
            get { return _Company; }
            set { SetPropertyValue(nameof(Company), ref _Company, value); }
        }
        public Worker(Session s, string fName, string lName, int age, string company)
            : base(s) {
            _Age = age;
            _FirstName = fName;
            _LastName = lName;
            _Company = company;
        }
        public Worker(Session session)
            : base(session) {
        }         
    }

    public class Evangelist : Worker {
        private string _Technology;

        public string Technology {
            get { return _Technology; }
            set { SetPropertyValue(nameof(Technology), ref _Technology, value); }
        }
        public Evangelist(Session s, string fName, string lName, int age, string company, string technology)
            : base(s, fName, lName, age, company) {
            _Technology = technology;
        }
        public Evangelist(Session s) : base(s) { }
    }

    public class Manager : Worker {
        private string _Department;
        public string Department {
            get { return _Department; }
            set { SetPropertyValue(nameof(Department), ref _Department, value); }
        }
        public Manager(Session s, string fName, string lName, int age, string company, string department)
            : base(s, fName, lName, age, company) {
            _Department = department;
        }
        public Manager(Session s) : base(s) { }
    }

    public class ProductManager : Manager {
        private string _Product;

        public string Product {
            get { return _Product; }
            set { SetPropertyValue(nameof(Product), ref _Product, value); }
        }
        public ProductManager(Session s, string fName, string lName, int age, string company, string departmen, string product)
            : base(s, fName, lName, age, company, departmen) {
            _Product = product;
        }
        public ProductManager(Session s) : base(s) { }
    }

    public static class ObjectHelper {
        public static IDataLayer CreateDataLayer() {
            IDataLayer dl = new SimpleDataLayer(new InMemoryDataStore(AutoCreateOption.DatabaseAndSchema));
            using(UnitOfWork uow = new UnitOfWork(dl)) {
                new Evangelist(uow, "Maria", "Anders", 41, "Speedy Express", ".NET");
                new Evangelist(uow, "Ana", "Trujillo", 33, "United Package", ".NET");
                new Evangelist(uow, "Antonio", "Moreno", 46, "Federal Shipping", "VCL");
                new Evangelist(uow, "Thomas", "Hardy", 35, "Exotic Liquids", "VCL");
                new Evangelist(uow, "Christina", "Berglund", 45, "New Orleans Cajun Delights", ".NET");
                new Evangelist(uow, "Hanna", "Moos", 51, "United Package", "WPF");
                new Evangelist(uow, "Frédérique", "Citeaux", 59, "Tokyo Traders", ".NET");
                new Evangelist(uow, "Martín", "Sommer", 29, "Specialty Biscuits, Ltd.", "WPF");
                new Evangelist(uow, "Laurence", "Lebihan", 38, "Tokyo Traders", "HTML5 & JS");
                new Evangelist(uow, "Elizabeth", "Lincoln", 40, "Exotic Liquids", "WPF");
                new Evangelist(uow, "Victoria", "Ashworth", 53, "Pavlova, Ltd.", "HTML5 & JS");
                new Evangelist(uow, "Patricio", "Simpson", 37, "Specialty Biscuits, Ltd.", ".NET");

                new Manager(uow, "Nancy", "Davolio", 41, "Exotic Liquids", "Programming");
                new Manager(uow, "Andrew", "Fuller", 33, "United Package", "Testing");
                new Manager(uow, "Janet", "Leverling", 46, "New Orleans Cajun Delights", "Programming");
                new Manager(uow, "Margaret", "Peacock", 35, "Refrescos Americanas LTDA", "Testing");
                new Manager(uow, "Steven", "Buchanan", 45, "Tokyo Traders", "Programming");

                new ProductManager(uow, "Michael", "Suyama", 51, "Pavlova, Ltd.", "Programming", "Super One");
                new ProductManager(uow, "Robert", "King", 59, "Refrescos Americanas LTDA", "Programming", "Super Two");
                new ProductManager(uow, "Laura", "Callahan", 29, "Exotic Liquids", "Marketing", "Super One");
                new ProductManager(uow, "Anne", "Dodsworth", 38, "United Package", "Marketing", "Super Two");

                uow.CommitChanges();
            }
            return dl;
        }
    }
}
