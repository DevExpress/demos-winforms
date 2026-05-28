Imports System
Imports System.Windows.Forms
Imports System.Xml
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Add and remove nodes", "AddRemoveNodes.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AppendNode", "DeleteNode", "DeleteSelectedNodes", "FocusedNode")>
    Public Module AddRemoveNodes

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
            'SimpleButton button = new SimpleButton();
            'button.Dock = DockStyle.Top;
            'button.Parent = sampleHost;
            'button.Height = button.CalcBestSize().Height;
            AddHandler treeList.Load, Sub(s, e)
                treeList.ExpandAll()
                treeList.Columns(CStr(("Name"))).BestFit()
            End Sub
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Appending new nodes"), Examples.SpaceObjectCS>
        Public Sub AppendingNodes(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            Dim appendNodeButton As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Dock = System.Windows.Forms.DockStyle.Top, .Parent = treeList.Parent, .Text = "Append node"}
            ' UI Binding
            AddHandler appendNodeButton.Click, Sub(sender, e)
                ' Appending a new Node
                Dim spaceObject As DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.[New]()
                spaceObject.ID = treeList.AllNodesCount
                spaceObject.ParentID = If((treeList.FocusedNode IsNot Nothing), treeList.FocusedNode.Id, -1)
                Dim newNode As DevExpress.XtraTreeList.Nodes.TreeListNode = treeList.AppendNode(nodeData:=New Object() {spaceObject.ID, spaceObject.ParentID, spaceObject.Name, spaceObject.Notes, spaceObject.MeanRadiusInKM, spaceObject.MeanRadiusByEarth, spaceObject.TypeOfObject, spaceObject.Mark, spaceObject.RecordDate}, parentNode:=treeList.FocusedNode)
                ' Using the newly added node
                treeList.FocusedNode = newNode
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Removing a focused node when Ctrl+Delete is pressed")>
        Public Sub RemovingNode(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            Dim deleteButton As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Dock = System.Windows.Forms.DockStyle.Top, .Parent = treeList.Parent, .Text = "Delete focused node"}
            ' Delete node action with confirmation
            Dim deleteNodeWithConfirmation As System.Action(Of DevExpress.XtraTreeList.Nodes.TreeListNode) = Sub(node)
                If node Is Nothing Then Return
                Dim msg As String = String.Format("The node {0} is about to be deleted. Do you want to proceed?", node("Name"))
                If DevExpress.XtraEditors.XtraMessageBox.Show(msg, "Deleting node", System.Windows.Forms.MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    ' Delete Node
                    treeList.DeleteNode(node)
                ' or you can use the TreeListNode.Remove() method
                ' node.Remove();
                End If
            End Sub
            ' UI Bindings
            AddHandler treeList.KeyDown, Sub(sender, e)
                If e.KeyCode = System.Windows.Forms.Keys.Delete AndAlso e.Modifiers = System.Windows.Forms.Keys.Control Then deleteNodeWithConfirmation(treeList.FocusedNode)
            End Sub
            AddHandler deleteButton.Click, Sub(sender, e) deleteNodeWithConfirmation(treeList.FocusedNode)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Removing selected nodes")>
        Public Sub RemovingSelectedNodes(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            Dim deleteButton As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Dock = System.Windows.Forms.DockStyle.Top, .Parent = treeList.Parent, .Text = "Delete selected nodes"}
            ' Enable multi-selection
            treeList.OptionsSelection.MultiSelect = True
            treeList.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.RowSelect
            ' UI Binding
            AddHandler deleteButton.Click, Sub(sender, e)
                Dim count As Integer = treeList.Selection.Count
                If count = 0 Then Return
                Dim msg As String = String.Format("{0} nodes is about to be deleted. Do you want to proceed?", count)
                If DevExpress.XtraEditors.XtraMessageBox.Show(msg, "Deleting node", System.Windows.Forms.MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    ' Delete selected nodes
                    treeList.DeleteSelectedNodes()
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Use New Item Row to add nodes")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("NewItemRowPosition")>
        Public Sub UseNewItemRowToAddNodes(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.OptionsBehavior.Editable = True
            ' Display a New Item Row to add nodes to the TreeList.
            treeList.OptionsView.NewItemRowPosition = DevExpress.XtraTreeList.TreeListNewItemRowPosition.Top ' Available modes: Top, Bottom, None
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Use node menu to add nodes")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowAddNodeItems")>
        Public Sub UseNodeMenuToAddRows(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.OptionsBehavior.Editable = True
            ' Enable Add Node items in the node menu.
            treeList.OptionsMenu.ShowAddNodeItems = DevExpress.Utils.DefaultBoolean.[True]
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Init newly added nodes in a custom manner")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("InitNewRow")>
        Public Sub UseNewItemRowToAddRows(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.OptionsBehavior.Editable = True
            treeList.OptionsView.NewItemRowPosition = DevExpress.XtraTreeList.TreeListNewItemRowPosition.Top
            ' Handle the InitNewRow event to initialize newly added nodes. To initialize row cells use the SetValue method.
            AddHandler treeList.InitNewRow, Sub(sender, e) e.SetValue("RecordDate", System.DateTime.Now)
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Working with nodes", "AddRemoveNodes.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Nodes", "AddNodes", "ExpandAll", "BestFitColumns")>
    Public Module WorkingWithNodes

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Loading nodes from XML", New System.Type() {GetType(Examples.WorkingWithNodes.FamilyXML)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Environment", "XmlDocument", "XmlNode", "SafeXml")>
        Public Sub LoadingNodesFromXML(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            Dim xmlRoot = Examples.WorkingWithNodes.FamilyXML.Document.DocumentElement
            ' Initialize the TreeView control.
            treeList.OptionsView.AutoWidth = False
            treeList.Columns.AddVisible("Member")
            treeList.Columns.AddVisible(CStr(("name"))).Caption = "Name"
            Dim treeRoot As DevExpress.XtraTreeList.Nodes.TreeListNode = treeList.Nodes.Add(xmlRoot.Name)
            ' Use the TreeListNodeExtension.AddNode extension method
            treeRoot.AddNodes(xmlRoot, contentField:="name")
            ' Expand all nodes
            treeList.ExpandAll()
            ' Best fit the displayed data
            treeList.BestFitColumns()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public NotInheritable Class FamilyXML

            Private Shared XML As String = "<?xml version=""1.0""?>" & "<family name=""Smiths"">" & "<grandfather name=""Bob"">" & "<father name=""Donald"">" & "<brother name=""Mike"">" & "<niece>Ann</niece>" & "<niece>Mary</niece>" & "</brother>" & "<me name=""Alex"">" & "<son>John</son>" & "<son>Adam</son>" & "</me>" & "<sister>Lise</sister>" & "</father>" & "<uncle name=""Sam"">" & "<cousinsister name=""Eva"">" & "<secondcousin>Amy</secondcousin>" & "</cousinsister>" & "<cousinbrother>Julian</cousinbrother>" & "</uncle>" & "</grandfather>" & "</family>"

            Private Shared documenCore As System.Xml.XmlDocument

            Public Shared ReadOnly Property Document As XmlDocument
                Get
                    If Examples.WorkingWithNodes.FamilyXML.documenCore Is Nothing Then Examples.WorkingWithNodes.FamilyXML.documenCore = DevExpress.Utils.SafeXml.CreateDocument(Examples.WorkingWithNodes.FamilyXML.XML)
                    Return Examples.WorkingWithNodes.FamilyXML.documenCore
                End Get
            End Property
        End Class
    End Module
End Namespace
