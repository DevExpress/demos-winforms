Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports DevExpress.ApplicationUI.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("TabbedView via code", "TabbedView.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("TabbedView", "UserControl", "DocumentGroupCollection", "BaseDocument", "DocumentGroup", "Document", "Orientation", "RibbonMdiMergeStyle", "RibbonAndBarsMergeStyle", "Color", "RibbonControl", "RibbonPage", "RibbonPageGroup", "BarButtonItem", "BarItem", "Panel")>
    Public Module TabbedLayout

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim documentManager As DevExpress.XtraBars.Docking2010.DocumentManager = New DevExpress.XtraBars.Docking2010.DocumentManager()
            Dim documentManagerHost As DevExpress.XtraEditors.XtraUserControl = New DevExpress.XtraEditors.XtraUserControl()
            documentManagerHost.Parent = sampleHost
            documentManagerHost.Dock = System.Windows.Forms.DockStyle.Fill
            Return New Object() {documentManager, documentManagerHost}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim documentManager = DevExpress.XtraBars.Docking2010.DocumentManager.FromControl(sampleHost.Controls(0))
            If documentManager IsNot Nothing Then
                documentManager.Dispose()
                documentManager = Nothing
            End If
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create simple TabbedView")>
        Public Sub SimpleTabbedView(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"})
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create TabbedView with free layout")>
        Public Sub TabbedViewFreeLayout(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            view.EnableFreeLayoutMode = DevExpress.Utils.DefaultBoolean.[True]
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim groups As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroupCollection = view.DocumentGroups
            For i As Integer = 1 To 3
                Dim document As DevExpress.XtraBars.Docking2010.Views.BaseDocument = view.AddDocument(New System.Windows.Forms.Control())
                document.Caption = "Document" & i
                Dim documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup()
                view.DocumentGroups.Add(documentGroup)
                view.Controller.Dock(TryCast(document, DevExpress.XtraBars.Docking2010.Views.Tabbed.Document), documentGroup)
            Next

            groups(CInt((2))).DockTo(groups(1), System.Windows.Forms.Orientation.Vertical)
            view.LayoutChanged()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Ribbon merging", New System.Type() {GetType(Examples.TabbedLayout.RibbonInitializer)})>
        Public Sub DocumentRibbonMerging(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            documentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always
            Dim control = New System.Windows.Forms.UserControl() With {.Text = "Document1"}
            Dim mainRibbon = Examples.TabbedLayout.RibbonInitializer.Init(ownerControl, True)
            Dim childRibbon = Examples.TabbedLayout.RibbonInitializer.Init(control, False)
            mainRibbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
            view.AddDocument(control)
            mainRibbon.SelectedPage = mainRibbon.MergedPages(0)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create several vertical DocumentGroup")>
        Public Sub CreateSeveralDocumentVerticalGroup(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Tabbed.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Tabbed.Document)
            Dim newDocumentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup()
            view.DocumentGroups.Add(newDocumentGroup)
            Dim controller = TryCast(view.Controller, DevExpress.XtraBars.Docking2010.Views.Tabbed.ITabbedViewController)
            controller.Dock(document2, newDocumentGroup)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create several horizontal DocumentGroup")>
        Public Sub CreateSeveralDocumentHorizontalGroup(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Tabbed.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Tabbed.Document)
            Dim newDocumentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup()
            view.DocumentGroups.Add(newDocumentGroup)
            view.Orientation = System.Windows.Forms.Orientation.Vertical
            Dim controller = TryCast(view.Controller, DevExpress.XtraBars.Docking2010.Views.Tabbed.ITabbedViewController)
            controller.Dock(document2, newDocumentGroup)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Colored Tabs")>
        Public Sub ColoredTab(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.Tabbed.Document)
            Dim document2 = TryCast(view.AddDocument(New System.Windows.Forms.UserControl() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.Tabbed.Document)
            Dim newDocumentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup()
            view.DocumentGroups.Add(newDocumentGroup)
            Dim controller = TryCast(view.Controller, DevExpress.XtraBars.Docking2010.Views.Tabbed.ITabbedViewController)
            controller.Dock(document2, newDocumentGroup)
            view.AppearancePage.Header.BackColor = System.Drawing.Color.Red
            document1.Appearance.HeaderActive.BackColor = System.Drawing.Color.Green
            document2.Appearance.HeaderActive.BackColor = System.Drawing.Color.Green
            controller.Activate(document1)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom draw tab headers")>
        Public Sub CustomDrawTabHeaders(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            Dim hatchBrush1 As System.Drawing.Drawing2D.HatchBrush = New System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal, System.Drawing.Color.LightGray, System.Drawing.Color.AliceBlue)
            AddHandler view.CustomDrawTabHeader, Sub(s, e)
                e.Cache.FillRectangle(hatchBrush1, e.Bounds)
                e.DefaultDrawText()
                e.DefaultDrawImage()
                e.DefaultDrawButtons()
                e.Handled = True
            End Sub
            Dim hatchBrush2 As System.Drawing.Drawing2D.HatchBrush = New System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.DiagonalCross, System.Drawing.Color.LightGray, System.Drawing.Color.AliceBlue)
            AddHandler view.CustomDrawHeaderButton, Sub(s, e)
                e.Cache.FillRectangle(hatchBrush2, e.Bounds)
                e.DefaultDraw()
                e.Handled = True
            End Sub
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim documentImageUris As String() = {"Home;Size16x16", "Pie;Size16x16", "Up;Size16x16"}
            For i As Integer = 0 To 3 - 1
                Dim labelControl = New DevExpress.XtraEditors.LabelControl()
                labelControl.Text = DevExpress.ApplicationUI.Demos.DemosInfo.GetLoremIpsumText(i)
                labelControl.Padding = New System.Windows.Forms.Padding(16)
                labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
                Dim document = view.AddDocument(labelControl)
                document.ImageOptions.ImageUri = documentImageUris(i)
                document.Caption = String.Format("document{0}", view.Documents.Count)
            Next

            Dim controller = TryCast(view.Controller, DevExpress.XtraBars.Docking2010.Views.Tabbed.ITabbedViewController)
            controller.Activate(view.Documents(0))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public NotInheritable Class RibbonInitializer

            Public Shared Function Init(ByVal control As System.Windows.Forms.Control, ByVal parentRibbon As Boolean) As RibbonControl
                Dim ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
                Dim ribbonPage As DevExpress.XtraBars.Ribbon.RibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
                Dim ribbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
                Dim barButtonItem As DevExpress.XtraBars.BarButtonItem = New DevExpress.XtraBars.BarButtonItem()
                ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {barButtonItem})
                ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {ribbonPage})
                ribbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {ribbonPageGroup})
                ribbonPage.Text = If(parentRibbon, "MainPage", "DocumentPage")
                ribbonPageGroup.ItemLinks.Add(barButtonItem)
                ribbonPageGroup.Text = "Actions"
                If parentRibbon Then
                    barButtonItem.Caption = "Add"
                    barButtonItem.ImageUri.Uri = "Add"
                Else
                    barButtonItem.Caption = "Save"
                    barButtonItem.ImageUri.Uri = "Save"
                End If

                control.Controls.Add(ribbonControl)
                Return ribbonControl
            End Function
        End Class
    End Module
End Namespace
