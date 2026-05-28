using System.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.Tutorials;
using DevExpress.Xpo.Demos.Properties;

namespace DevExpress.Xpo.Demos {
    public partial class About : ucAboutPage {
        protected override string ProductText { get { return "eXpressPersistentObjects represents a powerful bridge between the object world and the world of relational databases. It gives developers the freedom to build true business objects without having to deal with the tedious complexities of mapping them onto database tables. eXpressPersistentObjects for .NET completely abstracts the database layer from the developer, leaving him or her fully in the object-oriented realm. With XPO, you can build applications that are compatible with multiple database systems (currently we support MS Access, MS SQL Server, MS SQL Server CE, MS SQL Azure, MySQL, Oracle, PostgreSql, Firebird, PervasiveSQL, VistaDB, SQL Anywhere, Advantage, DB2, SQLite and Sybase) without making ANY changes to your code.";  } }
        protected override Image ProductImage { get { return Resources.Xpo_LargeIcon; } }
        protected override Image ProductImageLight { get { return Resources.Xpo_LargeIcon; } }
        protected override ProductKind ProductKind { get { return ProductKind.XPO; } }
        public override bool AllowCopyDxDemoLink { get { return false; } }
        public About() {
			InitializeComponent();
		}
	}
}
