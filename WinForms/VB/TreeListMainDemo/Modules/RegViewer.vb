Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Microsoft.Win32

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class TreeListRegViewer
        Inherits TutorialControl

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Protected Overrides ReadOnly Property BarName As String
            Get
                Return "RegViewer"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\RegViewer"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "RegViewer"
            End Get
        End Property

        Private computerItem As ComputerRegistryItem = New ComputerRegistryItem()

        Private source As BindingList(Of RegistryItemBase)

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            '<treeList1>
            source = New BindingList(Of RegistryItemBase)() From {computerItem}
            treeList1.DataSource = source
            treeList1.ChildListFieldName = "Items"
            treeList1.ForceInitialize()
            treeList1.Nodes(0).Expand()
            treeList1.Nodes(0).Nodes(0).Expand()
            '</treeList1>
            treeList1.FocusedNode = treeList1.Nodes(0).Nodes(0)
            AddHandler treeList1.GetSelectImage, AddressOf treeList1_GetSelectImage
            AddHandler treeList2.GetSelectImage, AddressOf treeList2_GetSelectImage
        End Sub

        '<treeList1>
        Private Sub treeList1_BeforeExpand(ByVal sender As Object, ByVal e As BeforeExpandEventArgs)
            If e.Node.ParentNode Is Nothing Then Return
            Dim registryItem = CType(treeList1.GetRow(e.Node.Id), RegistryItemBase)
            Dim rootItem As RootRegistryItem = CType(computerItem.Items(registryItem.RootIndex), RootRegistryItem)
            registryItem.LoadItems(rootItem.Key)
        End Sub

        '</treeList1>
        '<treeList2>
        Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs)
            Dim registryItem = CType(treeList1.GetRow(e.Node.Id), RegistryItemBase)
            textEdit1.Text = registryItem.Path
            If e.Node.ParentNode Is Nothing Then Return
            Dim rootItem As RootRegistryItem = CType(computerItem.Items(registryItem.RootIndex), RootRegistryItem)
            registryItem.LoadObjects(rootItem.Key)
            treeList2.DataSource = CType(treeList1.GetRow(e.Node.Id), RegistryItemBase).Objects
        End Sub

        '</treeList2>
        Private Sub treeList1_GetSelectImage(ByVal sender As Object, ByVal e As GetSelectImageEventArgs)
            If e.Node.ParentNode Is Nothing Then
                e.NodeImageIndex = 0
            Else
                e.NodeImageIndex = 1
            End If
        End Sub

        Private Sub treeList2_GetSelectImage(ByVal sender As Object, ByVal e As GetSelectImageEventArgs)
            If treeList2.IsAutoFilterNode(e.Node) Then Return
            Dim registryValue = CType(treeList2.GetRow(e.Node.Id), RegistryValue)
            Select Case registryValue.Kind
                Case RegistryValueKind.Binary, RegistryValueKind.DWord, RegistryValueKind.QWord
                    e.NodeImageIndex = 4
                Case Else
                    e.NodeImageIndex = 3
            End Select
        End Sub
    End Class

    Public Class ComputerRegistryItem
        Inherits RegistryItemBase

        Public Sub New()
            MyBase.New("Computer", String.Empty, -1)
            LoadItems(Nothing)
            LoadObjects(Nothing)
        End Sub

        Protected Overrides Sub LoadObjectsCore(ByVal root As RegistryKey)
        End Sub

        Protected Overrides Sub LoadItemsCore(ByVal root As RegistryKey)
            Dim rootItems As BindingList(Of RegistryItemBase) = New BindingList(Of RegistryItemBase)()
            rootItems.Add(New RootRegistryItem(Registry.ClassesRoot, Name, 0))
            rootItems.Add(New RootRegistryItem(Registry.CurrentUser, Name, 1))
            rootItems.Add(New RootRegistryItem(Registry.LocalMachine, Name, 2))
            rootItems.Add(New RootRegistryItem(Registry.Users, Name, 3))
            rootItems.Add(New RootRegistryItem(Registry.CurrentConfig, Name, 4))
            Items = rootItems
        End Sub

        Protected Overrides Function CreateRegistryItem(ByVal name As String) As RegistryItemBase
            Return Nothing
        End Function
    End Class

    Public Class RootRegistryItem
        Inherits RegistryItemBase

        Private keyCore As RegistryKey

        Public Sub New(ByVal key As RegistryKey, ByVal path As String, ByVal rootIndex As Integer)
            MyBase.New(key.Name, path, rootIndex)
            keyCore = key
            EnableLazyLoading(key.SubKeyCount > 0)
        End Sub

        Public ReadOnly Property Key As RegistryKey
            Get
                Return keyCore
            End Get
        End Property

        Protected Overrides Sub LoadItemsCore(ByVal root As RegistryKey)
            GenerateItems(root, root.GetSubKeyNames())
        End Sub

        Protected Overrides Sub LoadObjectsCore(ByVal root As RegistryKey)
            Dim names = root.GetValueNames()
            GenerateObjects(root, names)
        End Sub

        Protected Overrides Function CreateRegistryItem(ByVal name As String) As RegistryItemBase
            Return New RegistryItem(name, Path, String.Empty, RootIndex)
        End Function
    End Class

    Public Class RegistryItem
        Inherits RegistryItemBase

        Friend Sub New(ByVal name As String, ByVal rootIndex As Integer)
            MyBase.New(name, String.Empty, rootIndex)
        End Sub

        Public Sub New(ByVal name As String, ByVal path As String, ByVal subPath As String, ByVal rootIndex As Integer)
            MyBase.New(name, path, rootIndex)
            SubKeyPath = If(String.IsNullOrEmpty(subPath), name, subPath & "\" & name)
        End Sub

        Private SubKeyPath As String

        Protected Overrides Sub LoadItemsCore(ByVal root As RegistryKey)
            Using key = OpenSubKey(root, SubKeyPath)
                GenerateItems(root, If(key IsNot Nothing, key.GetSubKeyNames(), Nothing))
            End Using
        End Sub

        Protected Overrides Sub LoadObjectsCore(ByVal root As RegistryKey)
            Using key = OpenSubKey(root, SubKeyPath)
                Dim names = If(key IsNot Nothing, key.GetValueNames(), Nothing)
                GenerateObjects(key, names)
            End Using
        End Sub

        Protected Overrides Function CreateRegistryItem(ByVal name As String) As RegistryItemBase
            Return New RegistryItem(name, Path, SubKeyPath, RootIndex)
        End Function

        Protected Overrides Sub CheckLazyLoading(ByVal root As RegistryKey)
            Using subKey = OpenSubKey(root, SubKeyPath)
                EnableLazyLoading(subKey IsNot Nothing AndAlso subKey.SubKeyCount > 0)
            End Using
        End Sub
    End Class

    '<treeList1>
    Public MustInherit Class RegistryItemBase
        Implements INotifyPropertyChanged

        Private Shared defaultItems As BindingList(Of RegistryItemBase) = New BindingList(Of RegistryItemBase)() From {New RegistryItem("Empty", -1)}

        Private itemsCore As BindingList(Of RegistryItemBase)

        Private objectsCore As List(Of RegistryValue)

        Private Event propetyChangedCore As PropertyChangedEventHandler

        Friend Shared Function OpenSubKey(ByVal key As RegistryKey, ByVal subKeyPath As String) As RegistryKey
            Try
                Return key.OpenSubKey(subKeyPath)
            Catch
                Return Nothing
            End Try
        End Function

        Public Sub New(ByVal name As String, ByVal path As String, ByVal rootIndex As Integer)
            Me.Name = name
            Me.Path = If(String.IsNullOrEmpty(path), name, path & "\" & name)
            Me.RootIndex = rootIndex
        End Sub

        Public ReadOnly RootIndex As Integer

        Public Property Name As String

        Public ReadOnly Path As String

        Private isLoaded As Boolean = False

        Private Custom Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
            AddHandler(ByVal value As PropertyChangedEventHandler)
                AddHandler propetyChangedCore, value
            End AddHandler

            RemoveHandler(ByVal value As PropertyChangedEventHandler)
                RemoveHandler propetyChangedCore, value
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
                RaiseEvent propetyChangedCore(sender, e)
            End RaiseEvent
        End Event

        Public Property Items As BindingList(Of RegistryItemBase)
            Get
                Return itemsCore
            End Get

            Friend Set(ByVal value As BindingList(Of RegistryItemBase))
                itemsCore = value
                OnPropertyChanged("Items")
            End Set
        End Property

        '</treeList1>
        Protected Sub OnPropertyChanged(ByVal name As String)
            If propetyChangedCoreEvent Is Nothing Then Return
            RaiseEvent propetyChangedCore(Me, New PropertyChangedEventArgs(name))
        End Sub

        Public Sub LoadItems(ByVal root As RegistryKey)
            If isLoaded Then Return
            LoadItemsCore(root)
            isLoaded = True
        End Sub

        Protected Overridable Sub LoadItemsCore(ByVal root As RegistryKey)
        End Sub

        Protected Sub GenerateItems(ByVal root As RegistryKey, ByVal names As String())
            If names Is Nothing OrElse names.Length = 0 Then
                Items = Nothing
            Else
                Dim itemList As BindingList(Of RegistryItemBase) = New BindingList(Of RegistryItemBase)()
                For n As Integer = 0 To names.Length - 1
                    Dim rItem = CreateRegistryItem(names(n))
                    rItem.CheckLazyLoading(root)
                    itemList.Add(rItem)
                Next

                Items = itemList
            End If
        End Sub

        Protected Overridable Sub CheckLazyLoading(ByVal root As RegistryKey)
        End Sub

        Friend Sub EnableLazyLoading(ByVal value As Boolean)
            If value Then
                itemsCore = defaultItems
            Else
                isLoaded = True
            End If
        End Sub

        Protected MustOverride Function CreateRegistryItem(ByVal name As String) As RegistryItemBase

        Public ReadOnly Property Objects As List(Of RegistryValue)
            Get
                Return objectsCore
            End Get
        End Property

        Public Sub LoadObjects(ByVal root As RegistryKey)
            If objectsCore Is Nothing Then
                objectsCore = New List(Of RegistryValue)(10)
                LoadObjectsCore(root)
            End If
        End Sub

        Protected Overridable Sub LoadObjectsCore(ByVal root As RegistryKey)
        End Sub

        Protected Sub GenerateObjects(ByVal key As RegistryKey, ByVal names As String())
            If names Is Nothing OrElse names.Length = 0 Then
                objectsCore.Add(New RegistryValue())
                Return
            Else
                If Not String.IsNullOrEmpty(names(0)) Then objectsCore.Add(New RegistryValue())
                For Each currentName As String In names
                    Dim kind = key.GetValueKind(currentName)
                    Dim value = key.GetValue(currentName)
                    objectsCore.Add(New RegistryValue(currentName, value, kind))
                Next
            End If
        End Sub
    End Class

    Public Class RegistryValue

        Private _Name As String, _Type As String, _Data As Object

        Private Shared RegistryValueType As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) From {{CInt(RegistryValueKind.String), "REG_SZ"}, {CInt(RegistryValueKind.ExpandString), "REG_EXPAND_SZ"}, {CInt(RegistryValueKind.MultiString), "REG_MULTI_SZ"}, {CInt(RegistryValueKind.QWord), "REG_QWORD"}, {CInt(RegistryValueKind.DWord), "REG_DWORD"}, {CInt(RegistryValueKind.Binary), "REG_BINARY"}, {CInt(RegistryValueKind.None), "REG_NONE"}, {CInt(RegistryValueKind.Unknown), "REG_UNKNOWN"}}

        Private kindCore As RegistryValueKind

        Public Sub New()
            Name = "(Default)"
            Data = "(value not set)"
            Kind = RegistryValueKind.String
        End Sub

        Public Sub New(ByVal name As String, ByVal data As Object, ByVal kind As RegistryValueKind)
            Me.Name = If(String.IsNullOrEmpty(name), "(Default)", name)
            Me.Data = If(data Is Nothing, "(value not set)", data)
            Me.Kind = kind
        End Sub

        Public Property Name As String
            Get
                Return _Name
            End Get

            Private Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Public Property Type As String
            Get
                Return _Type
            End Get

            Private Set(ByVal value As String)
                _Type = value
            End Set
        End Property

        Public Property Kind As RegistryValueKind
            Get
                Return kindCore
            End Get

            Set(ByVal value As RegistryValueKind)
                If kindCore = value Then Return
                kindCore = value
                Type = RegistryValueType(CInt(value))
            End Set
        End Property

        Public Property Data As Object
            Get
                Return _Data
            End Get

            Private Set(ByVal value As Object)
                _Data = value
            End Set
        End Property
    End Class
End Namespace
