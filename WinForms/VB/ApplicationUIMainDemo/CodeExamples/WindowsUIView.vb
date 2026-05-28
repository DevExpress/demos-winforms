Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Utils.Base
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("WindowsUIView", "WindowsUIView.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("WindowsUIView", "TileItemElement", "Tile", "TileContainer", "TileItemContentAlignment", "ISupportInitialize", "Flyout", "FlyoutAction", "MessageBoxButtons", "DocumentContent", "Document", "PageGroup", "TabbedGroup", "HeaderStyle", "Page", "AttachedAction", "NavigationCommand", "ActionType", "ActionEdge", "Color", "SolidBrush", "Pen", "StringFormat", "Font", "StringAlignment", "ControlStyles", "PaintEventArgs", "StringTrimming", "StringFormatFlags", "Panel", "INavigationArgs", "IDictionaryEnumerator", "AnchorStyles", "IDocumentActionsArgs", "DocumentAction", "ISupportNavigation", "IPropertiesProvider", "DocumentManager", "XtraUserControl", "DockStyle", "ISupportDocumentActions")>
    Public Module WindowsUIViewInterface

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
            If documentManager IsNot Nothing Then documentManager.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create WindowsUIView")>
        Public Sub CreateWindowsUIView(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile()
            Dim element As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement() With {.Text = "Tile", .TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter}
            tile.Elements.Add(element)
            view.Tiles.Add(tile)
            Dim container As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer()
            container.Items.Add(tile)
            view.ContentContainers.Add(container)
            view.ActivateContainer(container)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Using QueryStartupContentContainer event", New System.Type() {GetType(Examples.WindowsUIViewInterface.DocumentContent)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("BeginInit", "EndInit", "ForceInitialize")>
        Public Sub UseQueryStartupContentContainer(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView()
            TryCast(view, System.ComponentModel.ISupportInitialize).BeginInit()
            Dim flyoutView As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout()
            flyoutView.Action = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() With {.Caption = "Login form"}
            flyoutView.FlyoutButtons = System.Windows.Forms.MessageBoxButtons.OK
            documentManager.View = view
            documentManager.ContainerControl = ownerControl
            flyoutView.Document = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Login User Control", .Size = New System.Drawing.Size(300, 130)}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile()
            Dim element As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement() With {.Text = "Tile", .TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter}
            tile.Elements.Add(element)
            view.Tiles.Add(tile)
            Dim tileContainer As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer()
            tileContainer.Items.Add(tile)
            tileContainer.Parent = flyoutView
            view.ContentContainers.Add(tileContainer)
            AddHandler view.QueryStartupContentContainer, Sub(sender, e) e.ContentContainer = flyoutView
            AddHandler view.FlyoutHidden, Sub(sender, e) view.ActivateContainer(tileContainer)
            TryCast(view, System.ComponentModel.ISupportInitialize).EndInit()
            documentManager.ForceInitialize()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create Tile automatically", New System.Type() {GetType(Examples.WindowsUIViewInterface.DocumentContent)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ActivateContainer")>
        Public Sub CreateSimpleTileWithDocument(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim tileContainer As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer()
            view.ContentContainers.Add(tileContainer)
            Dim document = view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document1"})
            'Tile created after adding document
            Dim tile = view.Tiles(document)
            Dim element As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement() With {.Text = "Document1", .TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter}
            tile.Elements.Add(element)
            view.ActivateContainer(tileContainer)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create PageGroup", New System.Type() {GetType(Examples.WindowsUIViewInterface.DocumentContent)})>
        Public Sub CreatePageGroup(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim container As DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup()
            view.ContentContainers.Add(container)
            Dim document1 = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim document2 = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            container.Items.Add(document1)
            container.Items.Add(document2)
            view.ActivateContainer(container)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create TabbedGroup(Tabs)", New System.Type() {GetType(Examples.WindowsUIViewInterface.DocumentContent)})>
        Public Sub CreateTabbedGroupTabHeaderStyle(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim container As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup()
            view.ContentContainers.Add(container)
            Dim document1 = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim document2 = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document2"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim document3 = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document3"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim document4 = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document4"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim document5 = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document5"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            container.Items.Add(document1)
            container.Items.Add(document2)
            container.Items.Add(document3)
            container.Items.Add(document4)
            container.Items.Add(document5)
            view.ActivateContainer(container)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create TabbedGroup(Tiles)", New System.Type() {GetType(Examples.WindowsUIViewInterface.DocumentContent)})>
        Public Sub CreateTabbedGroupTileHeaderStyle(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim container As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup()
            container.Properties.HeaderStyle = DevExpress.XtraBars.Docking2010.Views.WindowsUI.HeaderStyle.Tile
            container.Properties.TileSize = 80
            container.Properties.TileColumnCount = 1
            view.ContentContainers.Add(container)
            Dim item1 = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Item1"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim item2 = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Item2"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim item3 = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Item3"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            container.Items.Add(item1)
            container.Items.Add(item2)
            container.Items.Add(item3)
            view.ActivateContainer(container)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Simple Navigation", New System.Type() {GetType(Examples.WindowsUIViewInterface.DocumentContent), GetType(Examples.WindowsUIViewInterface.WindowsUIViewInitializer)})>
        Public Sub SimpleNavigation(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view = Examples.WindowsUIViewInterface.WindowsUIViewInitializer.Init(documentManager, ownerControl)
            Dim document = TryCast(view.Documents(0), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile()
            Dim element As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement() With {.Text = "Click here", .TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter}
            tile.Elements.Add(element)
            view.Tiles.Add(tile)
            Dim container As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer()
            Dim page As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page() With {.Caption = "Custom page"}
            page.Parent = container
            page.Document = document
            container.Items.Add(tile)
            tile.ActivationTarget = page
            view.ContentContainers.Add(container)
            view.ContentContainers.Add(page)
            view.ActivateContainer(container)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Using ISupportNavigation interface", New System.Type() {GetType(Examples.WindowsUIViewInterface.UserControl1), GetType(Examples.WindowsUIViewInterface.DocumentContent), GetType(Examples.WindowsUIViewInterface.WindowsUIViewInitializer)})>
        Public Sub UsingNavigation(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view = Examples.WindowsUIViewInterface.WindowsUIViewInitializer.Init(documentManager, ownerControl)
            Dim document = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.UserControl1()), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile()
            tile.Tag = "Custom Filter"
            Dim element As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement() With {.Text = "Click here", .TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter}
            tile.Elements.Add(element)
            view.Tiles.Add(tile)
            Dim container As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer() With {.Name = "Main container"}
            Dim page As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page() With {.Caption = "Custom page"}
            page.Parent = container
            page.Document = document
            container.Items.Add(tile)
            tile.ActivationTarget = page
            view.ContentContainers.Add(container)
            view.ContentContainers.Add(page)
            view.ActivateContainer(container)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Using attached action", New System.Type() {GetType(Examples.WindowsUIViewInterface.WindowsUIViewInitializer), GetType(Examples.WindowsUIViewInterface.DocumentContent), GetType(Examples.WindowsUIViewInterface.NavigationCommand), GetType(Examples.WindowsUIViewInterface.UserControl2)})>
        Public Sub AttachedActions(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view = Examples.WindowsUIViewInterface.WindowsUIViewInitializer.Init(documentManager, ownerControl)
            Dim mainPage As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page() With {.Caption = "Main Page"}
            Dim targetPage As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page() With {.Caption = "Target Page"}
            Dim control As Examples.WindowsUIViewInterface.UserControl2 = New Examples.WindowsUIViewInterface.UserControl2()
            AddHandler control.NavigateButton.Click, Sub(sender, e) Call DevExpress.XtraBars.Docking2010.Views.WindowsUI.AttachedAction.Execute(control.NavigateButton)
            Dim navigateAction As DevExpress.XtraBars.Docking2010.Views.WindowsUI.AttachedAction = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.AttachedAction() With {.Target = targetPage, .Command = New Examples.WindowsUIViewInterface.NavigationCommand(view)}
            Call DevExpress.XtraBars.Docking2010.Views.WindowsUI.AttachedAction.Attach(control.NavigateButton, navigateAction)
            Dim navigateDocument = TryCast(view.AddDocument(control), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            mainPage.Document = navigateDocument
            Dim targetDocument = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Target document"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            targetPage.Document = targetDocument
            view.ContentContainers.Add(mainPage)
            view.ContentContainers.Add(targetPage)
            targetPage.Parent = mainPage
            view.ActivateContainer(mainPage)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom document action", New System.Type() {GetType(Examples.WindowsUIViewInterface.ActionUserControl), GetType(Examples.WindowsUIViewInterface.DocumentContent)})>
        Public Sub CustomDocumentAction(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView()
            view.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.[False]
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            AddHandler view.QueryDocumentActions, Sub(sender, e) e.DocumentActions.Add(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.DocumentAction(Nothing) With {.Caption = "Document Action 1"})
            Dim document = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.ActionUserControl() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim page As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page() With {.Caption = "Page"}
            page.Document = document
            page.Properties.ShowContextActionBarOnActivating = DevExpress.Utils.DefaultBoolean.[True]
            view.ContentContainers.Add(page)
            view.ActivateContainer(page)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom container action", New System.Type() {GetType(Examples.WindowsUIViewInterface.DocumentContent)})>
        Public Sub CustomContainerAction(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView()
            view.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.[False]
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document = TryCast(view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document1"}), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim page As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Page() With {.Caption = "Page"}
            page.Actions.Add(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.DelegateAction(Function()(True), Sub()
            End Sub) With {.Caption = "Container action", .Type = DevExpress.XtraBars.Docking2010.Views.WindowsUI.ActionType.Context, .Edge = DevExpress.XtraBars.Docking2010.Views.WindowsUI.ActionEdge.Left})
            page.Document = document
            page.Properties.ShowContextActionBarOnActivating = DevExpress.Utils.DefaultBoolean.[True]
            view.ContentContainers.Add(page)
            view.ActivateContainer(page)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Flyout with action", New System.Type() {GetType(Examples.WindowsUIViewInterface.WindowsUIViewInitializer), GetType(Examples.WindowsUIViewInterface.DocumentContent)})>
        Public Sub Flyout(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view = Examples.WindowsUIViewInterface.WindowsUIViewInitializer.Init(documentManager, ownerControl)
            Dim document = TryCast(view.Documents(0), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim flyoutView As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout() With {.Caption = "Custom page"}
            flyoutView.Action = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() With {.Caption = "Flyout Action Caption", .Description = "Flyout Action Description"}
            flyoutView.FlyoutButtons = System.Windows.Forms.MessageBoxButtons.OK
            view.ContentContainers.Add(flyoutView)
            view.ActivateContainer(flyoutView)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Flyout with UserControl", New System.Type() {GetType(Examples.WindowsUIViewInterface.WindowsUIViewInitializer), GetType(Examples.WindowsUIViewInterface.DocumentContent)})>
        Public Sub FlyoutWithControl(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim view = Examples.WindowsUIViewInterface.WindowsUIViewInitializer.Init(documentManager, ownerControl)
            Dim document = TryCast(view.Documents(0), DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
            Dim flyoutView As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout()
            flyoutView.Action = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() With {.Caption = "Flyout Action Caption"}
            flyoutView.FlyoutButtons = System.Windows.Forms.MessageBoxButtons.OK
            'add document with user control to flyout
            flyoutView.Document = document
            view.ContentContainers.Add(flyoutView)
            view.ActivateContainer(flyoutView)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class DocumentContent
            Inherits System.Windows.Forms.Panel

            Private Shared currentColor As Integer

            Private Shared forecolors As System.Drawing.Color() = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Green}

            Private sb As System.Drawing.SolidBrush

            Private pen As System.Drawing.Pen

            Private sf As System.Drawing.StringFormat

            Private Shared _font As System.Drawing.Font = New System.Drawing.Font("Segoe UI", 24F)

            Private Property TextColor As Color

            Public Sub New()
                Me.sf = New System.Drawing.StringFormat() With {.Alignment = System.Drawing.StringAlignment.Center, .LineAlignment = System.Drawing.StringAlignment.Center, .Trimming = System.Drawing.StringTrimming.EllipsisCharacter, .FormatFlags = System.Drawing.StringFormatFlags.NoWrap}
                Me.DoubleBuffered = True
                Me.TextColor = Examples.WindowsUIViewInterface.DocumentContent.forecolors((System.Math.Min(System.Threading.Interlocked.Increment(Examples.WindowsUIViewInterface.DocumentContent.currentColor), Examples.WindowsUIViewInterface.DocumentContent.currentColor - 1)) Mod Examples.WindowsUIViewInterface.DocumentContent.forecolors.Length)
                Me.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint Or System.Windows.Forms.ControlStyles.UserPaint, True)
                Me.SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw Or System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, True)
            End Sub

            Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
                If Me.sb Is Nothing Then Me.sb = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(100, Me.TextColor))
                If Me.pen Is Nothing Then Me.pen = New System.Drawing.Pen(System.Drawing.Color.FromArgb(200, 221, 223, 223))
                e.Graphics.FillRectangle(Me.sb, Me.ClientRectangle)
                e.Graphics.DrawString(Me.Text, Examples.WindowsUIViewInterface.DocumentContent._font, Me.sb, Me.ClientRectangle, Me.sf)
            End Sub
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class UserControl1
            Inherits Examples.WindowsUIViewInterface.DocumentContent
            Implements DevExpress.XtraBars.Docking2010.Views.WindowsUI.ISupportNavigation, DevExpress.Utils.Base.IPropertiesProvider

#Region "ISupportNavigation Members"
            Public Sub OnNavigatedFrom(ByVal args As DevExpress.XtraBars.Docking2010.Views.WindowsUI.INavigationArgs) Implements Global.DevExpress.XtraBars.Docking2010.Views.WindowsUI.ISupportNavigation.OnNavigatedFrom
            End Sub

            Public Sub OnNavigatedTo(ByVal args As DevExpress.XtraBars.Docking2010.Views.WindowsUI.INavigationArgs) Implements Global.DevExpress.XtraBars.Docking2010.Views.WindowsUI.ISupportNavigation.OnNavigatedTo
                DevExpress.XtraEditors.XtraMessageBox.Show("Navigated from " & args.Source.Name & ". Tile tag = " & args.Tag.ToString())
            End Sub

#End Region
#Region "IPropertiesProvider Members"
            Public Function GetProperties() As System.Collections.IDictionaryEnumerator Implements Global.DevExpress.Utils.Base.IPropertiesProvider.GetProperties
                Return Nothing
            End Function
#End Region
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class NavigationCommand
            Implements DevExpress.XtraBars.Docking2010.Views.WindowsUI.ICommand(Of DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer)

            Private viewCore As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView

            Public Sub New(ByVal view As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView)
                Me.viewCore = view
            End Sub

            Public Function CanExecute(ByVal parameter As DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer) As Boolean Implements Global.DevExpress.XtraBars.Docking2010.Views.WindowsUI.ICommand(Of Global.DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer).CanExecute
                Return True
            End Function

            Public Sub Execute(ByVal parameter As DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer) Implements Global.DevExpress.XtraBars.Docking2010.Views.WindowsUI.ICommand(Of Global.DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer).Execute
                Me.viewCore.ActivateContainer(parameter)
            End Sub

            Public Custom Event CanExecuteChanged As EventHandler Implements Global.DevExpress.XtraBars.Docking2010.Views.WindowsUI.ICommand(Of Global.DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer).CanExecuteChanged
                AddHandler(ByVal value As EventHandler)
                End AddHandler

                RemoveHandler(ByVal value As EventHandler)
                End RemoveHandler

                RaiseEvent(ByVal sender As System.Object, ByVal e As Global.System.EventArgs)
                End RaiseEvent
            End Event
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class UserControl2
            Inherits Examples.WindowsUIViewInterface.DocumentContent

            Public Sub New()
                Me.Size = New System.Drawing.Size(300, 130)
                Me.NavigateButton = New DevExpress.XtraEditors.SimpleButton() With {.Text = "Navigate to container", .Size = New System.Drawing.Size(175, 30), .Location = New System.Drawing.Point(10, 10), .Dock = System.Windows.Forms.DockStyle.Top, .Parent = Me, .Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Top}
                AddHandler Me.NavigateButton.Click, Sub(sender, e) Call DevExpress.XtraBars.Docking2010.Views.WindowsUI.AttachedAction.Execute(Me.NavigateButton)
            End Sub

            <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
            Public Property NavigateButton As SimpleButton
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class ActionUserControl
            Inherits Examples.WindowsUIViewInterface.DocumentContent
            Implements DevExpress.XtraBars.Docking2010.Views.WindowsUI.ISupportDocumentActions

#Region "ISupportDocumentActions Members"
            Public Sub OnQueryDocumentActions(ByVal args As DevExpress.XtraBars.Docking2010.Views.WindowsUI.IDocumentActionsArgs) Implements Global.DevExpress.XtraBars.Docking2010.Views.WindowsUI.ISupportDocumentActions.OnQueryDocumentActions
                args.DocumentActions.Add(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.DocumentAction(AddressOf Examples.WindowsUIViewInterface.ActionUserControl.CanExecuteDocumentAction, AddressOf Examples.WindowsUIViewInterface.ActionUserControl.ExecuteDocumentAction) With {.Caption = "Document Action 2"})
            End Sub

            Public Shared Function CanExecuteDocumentAction(ByVal document As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document) As Boolean
                Return True
            End Function

            Public Shared Sub ExecuteDocumentAction(ByVal document As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document)
                DevExpress.XtraEditors.XtraMessageBox.Show("Custom action executed")
            End Sub
#End Region
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public NotInheritable Class WindowsUIViewInitializer

            Public Shared Function Init(ByVal documentManager As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl) As WindowsUIView
                Dim view As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView()
                view.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.[False]
                documentManager.View = view
                documentManager.ViewCollection.Add(view)
                documentManager.ContainerControl = ownerControl
                view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document1", .Size = New System.Drawing.Size(300, 150)})
                view.AddDocument(New Examples.WindowsUIViewInterface.DocumentContent() With {.Text = "Document2"})
                Return view
            End Function
        End Class
    End Module
End Namespace
