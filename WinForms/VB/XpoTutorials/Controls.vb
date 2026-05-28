Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.DXperience.Demos
Imports System.Collections.Generic

Namespace DevExpress.Xpo.Demos
	Public Class TutorialControl
		Inherits TutorialControlBase
		Private privateSetNewWhatsThisPadding As Boolean
        Public Overridable Shadows Property SetNewWhatsThisPadding() As Boolean
            Get
                Return privateSetNewWhatsThisPadding
            End Get
            Set(ByVal value As Boolean)
                privateSetNewWhatsThisPadding = value
            End Set
        End Property
        Private whatThis As WhatsThis

        Public Sub New()
            MyBase.New()
            SetNewWhatsThisPadding = False
        End Sub

        Public Overridable Sub ReloadData()
        End Sub

        Public Sub SaveChanges(ByVal uow As UnitOfWork)
            uow.CommitChanges()
        End Sub

        Public Sub ShowWhatsThis()
            whatThis.ClickWhatsThis()
        End Sub

        Public Sub SetUpWhatsThis()
            whatThis = New WhatsThis(CType(Me.ParentFormMain, frmMain), Name)
        End Sub

        Public Sub DisableWhatsThis()
            If Not whatThis Is Nothing Then
                whatThis.DisableWhatsThis()
            End If
        End Sub
#Region "Create Data"
        ' Adds records to the 'Customer' and 'Order' tables.
        Public Sub CreateCustomers()
            Dim cm As New Customer()
            cm.Name = "Charlotte Cooper"
            cm.Age = 21
            Dim order As New OrderObject()
            order.ProductName = "Chai"
            order.OrderDate = New DateTime(2006, 5, 17)
            cm.Orders.Add(order)
            order = New OrderObject()
            order.ProductName = "Konbu"
            order.OrderDate = New DateTime(2006, 8, 23)
            cm.Orders.Add(order)
            cm.Save()

            cm = New Customer()
            cm.Name = "Bob Martin"
            cm.Age = 37
            order = New OrderObject()
            order.ProductName = "Queso Cabrales"
            order.OrderDate = New DateTime(2006, 2, 9)
            cm.Orders.Add(order)
            cm.Save()

            cm = New Customer()
            cm.Name = "Yoshi Nagase"
            cm.Age = 42
            order = New OrderObject()
            order.ProductName = "Longlife Tofu"
            order.OrderDate = New DateTime(2005, 4, 9)
            cm.Orders.Add(order)
            order = New OrderObject()
            order.ProductName = "Ikura"
            order.OrderDate = New DateTime(2005, 3, 24)
            cm.Orders.Add(order)
            cm.Save()

            cm = New Customer()
            cm.Name = "Peter Wilson"
            cm.Age = 29
            order = New OrderObject()
            order.ProductName = "Scottish Longbreads"
            order.OrderDate = New DateTime(2006, 9, 23)
            cm.Orders.Add(order)
            order = New OrderObject()
            order.ProductName = "Teatime Chocolate Biscuits"
            order.OrderDate = New DateTime(2006, 7, 3)
            cm.Orders.Add(order)
            cm.Save()

            cm = New Customer()
            cm.Name = "Shelley Burke"
            cm.Age = 30
            order = New OrderObject()
            order.ProductName = "Louisiana Hot Spiced Okra"
            order.OrderDate = New DateTime(2006, 3, 18)
            cm.Orders.Add(order)
            order = New OrderObject()
            order.ProductName = "Chef Anton's Cajun Seasoning"
            order.OrderDate = New DateTime(2006, 10, 7)
            cm.Orders.Add(order)
            cm.Save()

            cm = New Customer()
            cm.Name = "Cheryl Saylor"
            cm.Age = 38
            order = New OrderObject()
            order.ProductName = "Laughing Lumberjack Lager"
            order.OrderDate = New DateTime(2006, 11, 14)
            cm.Orders.Add(order)
            cm.Save()

            cm = New Customer()
            cm.Name = "Jean-Guy Lauzon"
            cm.Age = 24
            order = New OrderObject()
            order.ProductName = "Chai"
            order.OrderDate = New DateTime(2006, 8, 15)
            cm.Orders.Add(order)
            cm.Save()
        End Sub


        ' Adds records to the 'Project' table.
        Public Sub CreateProjects(ByVal uow As UnitOfWork)
            Dim prj1 As New Project(uow, "Enterprise Accounting System", "Web Edition: Data Entry Page", "Steve Lee", New DateTime(2003, 12, 4), ProjectStatus.Postponed, ProjectType.Request)
            Dim prj2 As New Project(uow, "Enterprise Accounting System", "Transaction History", "Mike Roller", New DateTime(2004, 7, 27), ProjectStatus.Fixed, ProjectType.Bug)
            Dim prj3 As New Project(uow, "Small-Business Accounting System", "Installer", "Bert Parkins", New DateTime(2004, 5, 12), ProjectStatus.New, ProjectType.Bug)
            Dim prj4 As New Project(uow, "Small-Business Accounting System", "Help File Duplicates", "Carl Lucas", New DateTime(2004, 7, 15), ProjectStatus.New, ProjectType.Request)
            Dim prj5 As New Project(uow, "Small-Business Accounting System", "Help File Integration", "Andrew Miler", New DateTime(2004, 7, 19), ProjectStatus.New, ProjectType.Request)
            Dim prj6 As New Project(uow, "Home-Office Accounting System", "Reports", "Tom Hamlett", New DateTime(2004, 3, 14), ProjectStatus.New, ProjectType.Request)
            Dim prj7 As New Project(uow, "Home-Office Accounting System", "History", "Mike Roller", New DateTime(2004, 2, 28), ProjectStatus.New, ProjectType.Bug)
            uow.CommitChanges()
        End Sub

        ' Adds records to the 'ImmediateDeletionProject' table.
        Public Sub CreateImmediateDeletionProjects(ByVal uow As UnitOfWork)
            Dim prj1 As New ImmediateDeletionProject(uow, "Web Edition: Data Entry Page", "Steve Lee", New DateTime(2003, 12, 4))
            Dim prj2 As New ImmediateDeletionProject(uow, "Transaction History", "Mike Roller", New DateTime(2004, 7, 27))
            Dim prj3 As New ImmediateDeletionProject(uow, "Installer", "Bert Parkins", New DateTime(2004, 5, 12))
            Dim prj4 As New ImmediateDeletionProject(uow, "Help File Duplicates", "Carl Lucas", New DateTime(2004, 7, 15))
            Dim prj5 As New ImmediateDeletionProject(uow, "Help File Integration", "Andrew Miler", New DateTime(2004, 7, 19))
            Dim prj6 As New ImmediateDeletionProject(uow, "Reports", "Tom Hamlett", New DateTime(2004, 3, 14))
            Dim prj7 As New ImmediateDeletionProject(uow, "History", "Mike Roller", New DateTime(2004, 2, 28))
            uow.CommitChanges()
        End Sub

        ' Adds records to the 'BusinessObject' table.
        Public Sub CreateBusinessObjects(ByVal uow As UnitOfWork, ByVal count As Integer)
            Dim obj As BusinessObject = Nothing
            Dim rnd As New Random(10)
            For i As Integer = 0 To count - 1
                obj = New BusinessObject(uow, "Record " & i.ToString(), i Mod 3 = 0, rnd.Next(100))
            Next i
            uow.CommitChanges()
        End Sub
#End Region
    End Class
End Namespace

