using System;
using DevExpress.DXperience.Demos;

namespace DevExpress.Xpo.Demos {
    public class TutorialControl : TutorialControlBase {
        public new virtual bool SetNewWhatsThisPadding { get; set; }
        //
        WhatsThis whatThis;
        public TutorialControl()
            : base() {
            SetNewWhatsThisPadding = false;
        }
        public virtual void ReloadData() { }
        public void SaveChanges(UnitOfWork uow) {
            uow.CommitChanges();
        }
        public void ShowWhatsThis() {
            if(whatThis != null) whatThis.ClickWhatsThis();
        }
        public void SetUpWhatsThis() {
            whatThis = new WhatsThis((frmMain)this.ParentFormMain, Name);
        }
        public void DisableWhatsThis() {
            if(whatThis != null) whatThis.DisableWhatsThis();
        }
        #region Create Data
        // Adds records to the 'Customer' and 'Order' tables.
        public void CreateCustomers() {
            Customer cm = new Customer();
            cm.Name = "Charlotte Cooper";
            cm.Age = 21;
            Order order = new Order();
            order.ProductName = "Chai";
            order.OrderDate = new DateTime(2006, 5, 17);
            cm.Orders.Add(order);
            order = new Order();
            order.ProductName = "Konbu";
            order.OrderDate = new DateTime(2006, 8, 23);
            cm.Orders.Add(order);
            cm.Save();

            cm = new Customer();
            cm.Name = "Bob Martin";
            cm.Age = 37;
            order = new Order();
            order.ProductName = "Queso Cabrales";
            order.OrderDate = new DateTime(2006, 2, 9);
            cm.Orders.Add(order);
            cm.Save();

            cm = new Customer();
            cm.Name = "Yoshi Nagase";
            cm.Age = 42;
            order = new Order();
            order.ProductName = "Longlife Tofu";
            order.OrderDate = new DateTime(2005, 4, 9);
            cm.Orders.Add(order);
            order = new Order();
            order.ProductName = "Ikura";
            order.OrderDate = new DateTime(2005, 3, 24);
            cm.Orders.Add(order);
            cm.Save();

            cm = new Customer();
            cm.Name = "Peter Wilson";
            cm.Age = 29;
            order = new Order();
            order.ProductName = "Scottish Longbreads";
            order.OrderDate = new DateTime(2006, 9, 23);
            cm.Orders.Add(order);
            order = new Order();
            order.ProductName = "Teatime Chocolate Biscuits";
            order.OrderDate = new DateTime(2006, 7, 3);
            cm.Orders.Add(order);
            cm.Save();

            cm = new Customer();
            cm.Name = "Shelley Burke";
            cm.Age = 30;
            order = new Order();
            order.ProductName = "Louisiana Hot Spiced Okra";
            order.OrderDate = new DateTime(2006, 3, 18);
            cm.Orders.Add(order);
            order = new Order();
            order.ProductName = "Chef Anton's Cajun Seasoning";
            order.OrderDate = new DateTime(2006, 10, 7);
            cm.Orders.Add(order);
            cm.Save();

            cm = new Customer();
            cm.Name = "Cheryl Saylor";
            cm.Age = 38;
            order = new Order();
            order.ProductName = "Laughing Lumberjack Lager";
            order.OrderDate = new DateTime(2006, 11, 14);
            cm.Orders.Add(order);
            cm.Save();

            cm = new Customer();
            cm.Name = "Jean-Guy Lauzon";
            cm.Age = 24;
            order = new Order();
            order.ProductName = "Chai";
            order.OrderDate = new DateTime(2006, 8, 15);
            cm.Orders.Add(order);
            cm.Save();
        }
        // Adds records to the 'Project' table.
        public void CreateProjects(UnitOfWork uow) {
            Project prj1 = new Project(uow, "Enterprise Accounting System", "Web Edition: Data Entry Page", "Steve Lee", new DateTime(2003, 12, 4), ProjectStatus.Postponed, ProjectType.Request);
            Project prj2 = new Project(uow, "Enterprise Accounting System", "Transaction History", "Mike Roller", new DateTime(2004, 7, 27), ProjectStatus.Fixed, ProjectType.Bug);
            Project prj3 = new Project(uow, "Small-Business Accounting System", "Installer", "Bert Parkins", new DateTime(2004, 5, 12), ProjectStatus.New, ProjectType.Bug);
            Project prj4 = new Project(uow, "Small-Business Accounting System", "Help File Duplicates", "Carl Lucas", new DateTime(2004, 7, 15), ProjectStatus.New, ProjectType.Request);
            Project prj5 = new Project(uow, "Small-Business Accounting System", "Help File Integration", "Andrew Miler", new DateTime(2004, 7, 19), ProjectStatus.New, ProjectType.Request);
            Project prj6 = new Project(uow, "Home-Office Accounting System", "Reports", "Tom Hamlett", new DateTime(2004, 3, 14), ProjectStatus.New, ProjectType.Request);
            Project prj7 = new Project(uow, "Home-Office Accounting System", "History", "Mike Roller", new DateTime(2004, 2, 28), ProjectStatus.New, ProjectType.Bug);
            uow.CommitChanges();
        }
        // Adds records to the 'ImmediateDeletionProject' table.
        public void CreateImmediateDeletionProjects(UnitOfWork uow) {
            ImmediateDeletionProject prj1 = new ImmediateDeletionProject(uow, "Web Edition: Data Entry Page", "Steve Lee", new DateTime(2003, 12, 4));
            ImmediateDeletionProject prj2 = new ImmediateDeletionProject(uow, "Transaction History", "Mike Roller", new DateTime(2004, 7, 27));
            ImmediateDeletionProject prj3 = new ImmediateDeletionProject(uow, "Installer", "Bert Parkins", new DateTime(2004, 5, 12));
            ImmediateDeletionProject prj4 = new ImmediateDeletionProject(uow, "Help File Duplicates", "Carl Lucas", new DateTime(2004, 7, 15));
            ImmediateDeletionProject prj5 = new ImmediateDeletionProject(uow, "Help File Integration", "Andrew Miler", new DateTime(2004, 7, 19));
            ImmediateDeletionProject prj6 = new ImmediateDeletionProject(uow, "Reports", "Tom Hamlett", new DateTime(2004, 3, 14));
            ImmediateDeletionProject prj7 = new ImmediateDeletionProject(uow, "History", "Mike Roller", new DateTime(2004, 2, 28));
            uow.CommitChanges();
        }
        // Adds records to the 'BusinessObject' table.
        public void CreateBusinessObjects(UnitOfWork uow, int count) {
            BusinessObject obj = null;
            Data.Utils.NonCryptographicRandom rnd = new Data.Utils.NonCryptographicRandom(10);
            for(int i = 0; i < count; i++)
                obj = new BusinessObject(uow, "Record " + i.ToString(), i % 3 == 0, rnd.Next(100));
            uow.CommitChanges();
        }
        #endregion        
    }
}
