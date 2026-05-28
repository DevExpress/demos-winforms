Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class ChecksAndRadios
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitTreeList()
            ucCheckBoxOptions1.InitData(MainControl)
        End Sub

        Protected Overrides ReadOnly Property FluentScrollBars As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\ChecksAndRadios", "TreeListMainDemo\Options\ucCheckBoxOptions"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ChecksAndRadios"
            End Get
        End Property

        '<treeList>
        Private Sub InitTreeList()
            layoutControl.UseLocalBindingContext = True
            treeList.Appearance.Row.BackColor = Color.Transparent
            treeList.Appearance.Empty.BackColor = Color.Transparent
            treeList.BackColor = Color.Transparent
            treeList.CheckBoxFieldName = "Checked"
            treeList.TreeViewFieldName = "Name"
            treeList.OptionsView.FocusRectStyle = DrawFocusRectStyle.None
            treeList.OptionsBehavior.Editable = False
            treeList.OptionsBehavior.ReadOnly = True
            treeList.OptionsBehavior.AllowRecursiveNodeChecking = True
            AddHandler treeList.NodeCellStyle, AddressOf OnNodeCellStyle
            AddHandler treeList.BeforeFocusNode, AddressOf OnBeforeFocusNode
            Dim dataSource = GenerateDataSource()
            treeList.DataSource = dataSource
            treeList.ForceInitialize()
            ucCheckBoxOptions1.DataSource = dataSource
            treeList.Nodes(0).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Check
            treeList.Nodes(1).Nodes(0).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
            treeList.Nodes(1).Nodes(1).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
            treeList.Nodes(1).Nodes(2).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
            treeList.Nodes(2).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
            treeList.Nodes(3).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
            treeList.ExpandAll()
        End Sub

        '</treeList>
        Private Sub OnBeforeFocusNode(ByVal sender As Object, ByVal e As BeforeFocusNodeEventArgs)
            e.CanFocus = False
        End Sub

        Private Sub OnNodeCellStyle(ByVal sender As Object, ByVal e As GetCustomNodeCellStyleEventArgs)
            If e.Node.Level = 0 Then
                e.Appearance.FontSizeDelta += 1
                e.Appearance.FontStyleDelta = FontStyle.Bold
            End If

            If e.Node.Level = 1 AndAlso e.Node.Nodes.Count > 0 Then e.Appearance.FontStyleDelta = FontStyle.Bold
        End Sub

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList
            End Get
        End Property

        Private Function GenerateDataSource() As BindingList(Of [Option])
            Dim _options As BindingList(Of [Option]) = New BindingList(Of [Option])()
            _options.Add(New [Option]() With {.ParentID = 0, .ID = 1, .Name = "Install components", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 1, .ID = 2, .Name = ".NET Framework 4.5", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 1, .ID = 3, .Name = "SQL Server 2016", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 1, .ID = 4, .Name = "Demos", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 1, .ID = 5, .Name = "Tutorials", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 1, .ID = 6, .Name = "Help Viewer", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 0, .ID = 7, .Name = "Settings", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 7, .ID = 8, .Name = "Language", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 9, .Name = "German"})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 10, .Name = "English(United Kingdom)"})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 11, .Name = "English(United States)", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 12, .Name = "Spanish(Spain)"})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 13, .Name = "Spanish(United States)"})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 14, .Name = "Spanish(Mexico)"})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 15, .Name = "French(France)"})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 16, .Name = "French(Canada)"})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 17, .Name = "Italian"})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 18, .Name = "Japanese"})
            _options.Add(New [Option]() With {.ParentID = 8, .ID = 19, .Name = "Russian"})
            _options.Add(New [Option]() With {.ParentID = 7, .ID = 20, .Name = "Default theme", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 20, .ID = 21, .Name = "White", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 20, .ID = 22, .Name = "Dark"})
            _options.Add(New [Option]() With {.ParentID = 20, .ID = 23, .Name = "Light"})
            _options.Add(New [Option]() With {.ParentID = 7, .ID = 24, .Name = "Architecture", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 24, .ID = 25, .Name = "x86"})
            _options.Add(New [Option]() With {.ParentID = 24, .ID = 26, .Name = "x64", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 0, .ID = 27, .Name = "Check for updates", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 27, .ID = 28, .Name = "Once per week", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 27, .ID = 29, .Name = "Once per month"})
            _options.Add(New [Option]() With {.ParentID = 27, .ID = 30, .Name = "Once per 3 months"})
            _options.Add(New [Option]() With {.ParentID = 0, .ID = 31, .Name = "Join the Customer Experience Improvement Programm", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 31, .ID = 32, .Name = "Yes(Recommended)", .Checked = True})
            _options.Add(New [Option]() With {.ParentID = 31, .ID = 33, .Name = "No"})
            Return _options
        End Function
    End Class

    Friend Class [Option]
        Implements INotifyPropertyChanged

        Public Property ParentID As Integer

        Public Property ID As Integer

        Public Property Name As String

        Private checkedCore As Boolean? = False

        Public Property Checked As Boolean?
            Get
                Return checkedCore
            End Get

            Set(ByVal value As Boolean?)
                If checkedCore = value Then Return
                checkedCore = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Checked"))
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    End Class
End Namespace
