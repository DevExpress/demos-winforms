Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Internal

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class MultiSelect
        Inherits TutorialControl

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ucMultiSelectOptions1.InitData(MainControl)
            InitData()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\MultiSelect", "TreeListMainDemo\Options\ucMultiSelectOptions"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "MultiSelect"
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitSelection()
        End Sub

        '<treeList>
        Private Sub InitSelection()
            If treeList.Nodes.Count = 0 Then Return
            treeList.SelectCells(treeList.Nodes(0).Nodes(0).Nodes(3), treeList.VisibleColumns(1), treeList.Nodes(0).Nodes(3), treeList.VisibleColumns(3))
            treeList.SelectCells(treeList.Nodes(0).Nodes(0).Nodes(3), treeList.VisibleColumns(6), treeList.Nodes(0).Nodes(3), treeList.VisibleColumns(6))
        End Sub

        '</treeList>
        Private Sub InitData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("EmployeesGroups.xml")
            If Not Equals(DBFileName, "") Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                treeList.DataSource = dataSet.Tables(0).DefaultView
                treeList.ExpandAll()
                treeList.BestFitColumns()
            End If
        End Sub

        Private currentGroupName As String

        Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As GetStateImageEventArgs)
            If treeList.IsAutoFilterNode(e.Node) Then Return
            Dim groupNames As String() = New String() {"Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales"}
            currentGroupName = CStr(e.Node.GetValue("GroupName"))
            e.NodeImageIndex = Array.FindIndex(groupNames, New Predicate(Of String)(AddressOf IsCurrentGroupName))
        End Sub

        Private Function IsCurrentGroupName(ByVal groupName As String) As Boolean
            If Not Equals(currentGroupName, Nothing) Then Return currentGroupName.Contains(groupName)
            Return False
        End Function
    End Class
End Namespace
