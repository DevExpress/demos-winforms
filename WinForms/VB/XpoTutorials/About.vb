Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.About
Imports DevExpress.Tutorials

Namespace DevExpress.Xpo.Demos
	Partial Public Class About
		Inherits ucAboutPage
		Protected Overrides ReadOnly Property ProductText() As String
			Get
				Return "eXpressPersistentObjects represents a powerful bridge between the object world and the world of relational databases. It gives developers the freedom to build true business objects without having to deal with the tedious complexities of mapping them onto database tables. eXpressPersistentObjects for .NET completely abstracts the database layer from the developer, leaving him or her fully in the object-oriented realm. With XPO, you can build applications that are compatible with multiple database systems (currently we support MS Access, MS SQL Server, MS SQL Server CE, MS SQL Azure, MySQL, Oracle, PostgreSql, Firebird, PervasiveSQL, VistaDB, SQL Anywhere, Advantage, DB2, SQLite and Sybase) without making ANY changes to your code."
			End Get
		End Property
		Protected Overrides ReadOnly Property ProductImage() As Image
			Get
                Return Resources.Xpo_LargeIcon
            End Get
		End Property
		Protected Overrides ReadOnly Property ProductImageLight() As Image
			Get
                Return Resources.Xpo_LargeIcon
            End Get
		End Property
		Protected Overrides ReadOnly Property ProductKind() As ProductKind
			Get
				Return ProductKind.XPO
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
