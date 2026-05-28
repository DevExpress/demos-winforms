Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class DocumentManagerTabbedDocumentsFreeLayout
        Inherits TabbedViewTutorialControl

#Region "Windows Form Designer generated code"
        Private documentManager1 As XtraBars.Docking2010.DocumentManager

        Private tabbedView1 As Tabbed.TabbedView

        Private components As System.ComponentModel.IContainer

        Private documentGroup1 As Tabbed.DocumentGroup

        Private document1 As Tabbed.Document

        Private document2 As Tabbed.Document

        Private document3 As Tabbed.Document

        Private documentGroup2 As Tabbed.DocumentGroup

        Private document4 As Tabbed.Document

        Private document5 As Tabbed.Document

        Private documentGroup4 As Tabbed.DocumentGroup

        Private documentGroup5 As Tabbed.DocumentGroup

        Private documentGroup7 As Tabbed.DocumentGroup

        Private barAndDockingController1 As XtraBars.BarAndDockingController

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim dockingContainer1 As Tabbed.DockingContainer = New Tabbed.DockingContainer()
            Dim dockingContainer2 As Tabbed.DockingContainer = New Tabbed.DockingContainer()
            Dim dockingContainer3 As Tabbed.DockingContainer = New Tabbed.DockingContainer()
            Dim dockingContainer4 As Tabbed.DockingContainer = New Tabbed.DockingContainer()
            Dim dockingContainer5 As Tabbed.DockingContainer = New Tabbed.DockingContainer()
            Dim dockingContainer6 As Tabbed.DockingContainer = New Tabbed.DockingContainer()
            Dim dockingContainer7 As Tabbed.DockingContainer = New Tabbed.DockingContainer()
            documentGroup4 = New Tabbed.DocumentGroup(components)
            document4 = New Tabbed.Document(components)
            documentGroup5 = New Tabbed.DocumentGroup(components)
            document5 = New Tabbed.Document(components)
            documentGroup7 = New Tabbed.DocumentGroup(components)
            document3 = New Tabbed.Document(components)
            documentGroup1 = New Tabbed.DocumentGroup(components)
            document1 = New Tabbed.Document(components)
            documentGroup2 = New Tabbed.DocumentGroup(components)
            document2 = New Tabbed.Document(components)
            tabbedView1 = New Tabbed.TabbedView(components)
            barAndDockingController1 = New XtraBars.BarAndDockingController(components)
            documentManager1 = New XtraBars.Docking2010.DocumentManager(components)
            CType(documentGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(documentGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(documentGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(documentGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(document2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentGroup4
            ' 
            documentGroup4.Items.AddRange(New Tabbed.Document() {document4})
            ' 
            ' document4
            ' 
            document4.Caption = "Clock"
            document4.ControlName = "Clock"
            document4.ControlTypeName = "DevExpress.ApplicationUI.Demos.Clock"
            ' 
            ' documentGroup5
            ' 
            documentGroup5.Items.AddRange(New Tabbed.Document() {document5})
            ' 
            ' document5
            ' 
            document5.Caption = "Calendar"
            document5.ControlName = "Calendar"
            document5.ControlTypeName = "DevExpress.ApplicationUI.Demos.Calendar"
            ' 
            ' documentGroup7
            ' 
            documentGroup7.Items.AddRange(New Tabbed.Document() {document3})
            ' 
            ' document3
            ' 
            document3.Caption = "Sales"
            document3.ControlName = "Sales"
            document3.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCategorySales"
            ' 
            ' documentGroup1
            ' 
            documentGroup1.Items.AddRange(New Tabbed.Document() {document1})
            ' 
            ' document1
            ' 
            document1.Caption = "Products"
            document1.ControlName = "document1"
            document1.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucProductsGrid"
            ' 
            ' documentGroup2
            ' 
            documentGroup2.Items.AddRange(New Tabbed.Document() {document2})
            ' 
            ' document2
            ' 
            document2.Caption = "Locations"
            document2.ControlName = "ChoropletMapItem"
            document2.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChoroplethMapItem"
            ' 
            ' tabbedView1
            ' 
            tabbedView1.DocumentGroups.AddRange(New Tabbed.DocumentGroup() {documentGroup1, documentGroup2, documentGroup4, documentGroup5, documentGroup7})
            tabbedView1.Documents.AddRange(New BaseDocument() {document1, document2, document3, document4, document5})
            tabbedView1.EnableFreeLayoutMode = Utils.DefaultBoolean.True
            dockingContainer1.Length.UnitValue = 0.62267099719482488R
            dockingContainer2.Element = documentGroup4
            dockingContainer2.Length.UnitValue = 0.4821805394648605R
            dockingContainer3.Element = documentGroup5
            dockingContainer3.Length.UnitValue = 1.3723427353315503R
            dockingContainer4.Element = documentGroup7
            dockingContainer4.Length.UnitValue = 1.1454767252035896R
            dockingContainer1.Nodes.AddRange(New Tabbed.DockingContainer() {dockingContainer2, dockingContainer3, dockingContainer4})
            dockingContainer1.Orientation = Orientation.Vertical
            dockingContainer5.Length.UnitValue = 1.7054427658400548R
            dockingContainer6.Element = documentGroup1
            dockingContainer6.Length.UnitValue = 1.2481231810106879R
            dockingContainer7.Element = documentGroup2
            dockingContainer7.Length.UnitValue = 0.7518768189893118R
            dockingContainer5.Nodes.AddRange(New Tabbed.DockingContainer() {dockingContainer6, dockingContainer7})
            dockingContainer5.Orientation = Orientation.Vertical
            tabbedView1.RootContainer.Nodes.AddRange(New Tabbed.DockingContainer() {dockingContainer1, dockingContainer5})
            ' 
            ' documentManager1
            ' 
            documentManager1.BarAndDockingController = barAndDockingController1
            documentManager1.ContainerControl = Me
            documentManager1.View = tabbedView1
            documentManager1.ViewCollection.AddRange(New BaseView() {tabbedView1})
            ' 
            ' DocumentManagerTabbedDocumentsFreeLayout
            ' 
            Name = "DocumentManagerTabbedDocumentsFreeLayout"
            Size = New System.Drawing.Size(869, 624)
            CType(documentGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(documentGroup5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(documentGroup7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(documentGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(document2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Public Sub New()
            InitializeComponent()
            AddHandler documentManager1.View.QueryControl, AddressOf OnQueryControl
        End Sub

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 300
            End Get
        End Property

        Private Sub OnQueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs)
            Dim typeName As String = e.Document.ControlTypeName
            If Not String.IsNullOrEmpty(typeName) Then
                Dim controlType = Data.Internal.SafeTypeResolver.GetKnownType(GetType(Program).Assembly, typeName)
                e.Control = TryCast(Activator.CreateInstance(controlType), Control)
            Else
                e.Control = New Control()
            End If
        End Sub
    End Class
End Namespace
