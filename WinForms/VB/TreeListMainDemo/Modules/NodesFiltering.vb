Imports System
Imports System.Data
Imports DevExpress.Data.Filtering
Imports DevExpress.Internal
Imports DevExpress.XtraTreeList.Nodes

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class NodesFiltering
        Inherits TutorialControl

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property Options As Object
            Get
                Return treeList1.OptionsView
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsName As String
            Get
                Return "View Options"
            End Get
        End Property

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitData()
            treeList1.BeginUpdate()
            treeList1.Columns("JobTitle").AllNodesSummary = True
            treeList1.Columns("JobTitle").SummaryFooter = SummaryItemType.Count
            treeList1.OptionsView.ShowSummaryFooter = True
            treeList1.OptionsFind.Behavior = XtraEditors.FindPanelBehavior.Search
            treeList1.OptionsFind.ParserKind = FindPanelParserKind.Exact
            treeList1.OptionsFind.Condition = FilterCondition.Contains
            treeList1.FindFilterText = "s Ma"
            treeList1.EndUpdate()
            ucFilterOptions1.InitData(MainControl)
            ucFindOptions1.InitData(MainControl)
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\NodesFiltering", "TreeListMainDemo\Options\ucFindOptions"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "NodesFiltering"
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            treeList1.ShowFindPanel()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("EmployeesGroups.xml")
            If Not Equals(DBFileName, "") Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                treeList1.DataSource = dataSet.Tables(0).DefaultView
                treeList1.ExpandAll()
                treeList1.BestFitColumns()
            End If
        End Sub

        Private ReadOnly groups As String() = New String() {"Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales"}

        Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As GetStateImageEventArgs)
            If TypeOf e.Node Is TreeListAutoFilterNode Then Return
            Dim groupName As String = CStr(e.Node.GetValue("GroupName"))
            If Not String.IsNullOrEmpty(groupName) Then e.NodeImageIndex = Array.FindIndex(groups, Function(g) groupName.Contains(g))
        End Sub
    End Class
End Namespace
