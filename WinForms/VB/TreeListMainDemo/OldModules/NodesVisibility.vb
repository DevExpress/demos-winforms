Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Internal
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class NodesVisibility
        Inherits TutorialControl

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitData()
            InitListBox()
            treeList1.Columns("Check").VisibleIndex = -1
            treeList1.BestFitColumns()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"NodesVisibility"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "NodesVisibility"
            End Get
        End Property

        Private Sub InitData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("Departments.xml")
            If Not Equals(DBFileName, "") Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                treeList1.DataSource = dataSet.Tables(0).DefaultView
                treeList1.PopulateColumns()
                treeList1.ExpandAll()
            End If
        End Sub

        '<treeList1>
        Private Sub InitListBox()
            Dim lastNode As TreeListNode = treeList1.Nodes(0).Nodes(2).Nodes(1).LastNode
            listBoxControl1.Items.Add(lastNode.GetDisplayText(0))
            lastNode.Visible = False
        End Sub

        Private Sub treeList1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Clicks <> 2 Then Return
            Dim hi As TreeListHitInfo = treeList1.CalcHitInfo(New Point(e.X, e.Y))
            Dim node As TreeListNode = hi.Node
            If node IsNot Nothing Then
                listBoxControl1.Items.Add(node.GetDisplayText(0))
                node.Visible = False
            End If
        End Sub

        '</treeList1>
        '<listBoxControl1>
        Private Sub listBoxControl1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim selectedValue As String = CStr(listBoxControl1.SelectedValue)
            If Equals(selectedValue, Nothing) Then Return
            Dim node As TreeListNode = treeList1.FindNodeByFieldValue(treeList1.Columns(0).FieldName, selectedValue)
            If node.ParentNode IsNot Nothing AndAlso Not node.ParentNode.Visible Then
                XtraMessageBox.Show(Me, "Please make the node's parent visible before")
                Return
            End If

            node.Visible = True
            listBoxControl1.Items.Remove(selectedValue)
        End Sub

        Private Sub listBoxControl1_DrawItem(ByVal sender As Object, ByVal e As ListBoxDrawItemEventArgs)
            Dim _item As String = TryCast(e.Item, String)
            Dim _node As TreeListNode = treeList1.FindNodeByFieldValue(treeList1.Columns(0).FieldName, _item)
            If _node.ParentNode IsNot Nothing AndAlso Not _node.ParentNode.Visible Then e.Appearance.ForeColor = Color.Gray
        End Sub
    '</listBoxControl1>
    End Class
End Namespace
