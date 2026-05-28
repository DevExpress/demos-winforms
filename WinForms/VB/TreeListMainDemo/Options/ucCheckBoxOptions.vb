Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.XtraTreeList.Demos.Options

    Public Partial Class ucCheckBoxOptions
        Inherits ucDefault

        Public Sub New()
            InitializeComponent()
            layoutControl.UseLocalBindingContext = True
            AddHandler treeList1.BeforeFocusNode, AddressOf OnBeforeFocusNode
            treeList1.ActiveFilterString = "[Checked] = TRUE"
            treeList1.BackColor = Color.Transparent
            AddHandler treeList1.NodeCellStyle, AddressOf OnNodeCellStyle
        End Sub

        Private Sub OnNodeCellStyle(ByVal sender As Object, ByVal e As GetCustomNodeCellStyleEventArgs)
            If e.Node.Level = 0 Then
                e.Appearance.FontSizeDelta += 1
                e.Appearance.FontStyleDelta = FontStyle.Bold
            End If

            If e.Node.Level = 1 AndAlso e.Node.Nodes.Count > 0 Then e.Appearance.FontStyleDelta = FontStyle.Bold
        End Sub

        Private Sub OnBeforeFocusNode(ByVal sender As Object, ByVal e As BeforeFocusNodeEventArgs)
            e.CanFocus = False
        End Sub

        '<layoutControl.lgOptions>
        Protected Overrides Sub InitDataCore()
            imbShowCheckBoxes.Properties.AddEnum(Of ShowCheckBoxes)()
            imbShowCheckBoxes.SelectedIndex = 0
            AddHandler imbShowCheckBoxes.SelectedIndexChanged, AddressOf OnSelectedIndexChanged
            ceAllowRecursiveNodeChecking.Checked = TreeList.OptionsBehavior.AllowRecursiveNodeChecking
            AddHandler ceAllowRecursiveNodeChecking.CheckedChanged, AddressOf OnCheckedChanged
        End Sub

        Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TreeList.OptionsBehavior.AllowRecursiveNodeChecking = ceAllowRecursiveNodeChecking.Checked
        End Sub

        Private Sub OnSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            TreeList.BeginUpdate()
            Select Case CType(imbShowCheckBoxes.SelectedIndex, ShowCheckBoxes)
                Case ShowCheckBoxes.None
                    TreeList.OptionsView.RootCheckBoxStyle = NodeCheckBoxStyle.Default
                    TreeList.Nodes(0).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default
                    TreeList.Nodes(1).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default
                    TreeList.Nodes(1).Nodes(0).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default
                    TreeList.Nodes(1).Nodes(1).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default
                    TreeList.Nodes(1).Nodes(2).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default
                    TreeList.Nodes(2).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default
                    TreeList.Nodes(3).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default
                Case ShowCheckBoxes.All
                    TreeList.OptionsView.RootCheckBoxStyle = NodeCheckBoxStyle.Check
                    TreeList.Nodes(0).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Check
                    TreeList.Nodes(1).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Check
                    TreeList.Nodes(1).Nodes(0).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
                    TreeList.Nodes(1).Nodes(1).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
                    TreeList.Nodes(1).Nodes(2).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
                    TreeList.Nodes(2).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
                    TreeList.Nodes(3).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
                Case Else
                    TreeList.OptionsView.RootCheckBoxStyle = NodeCheckBoxStyle.Default
                    TreeList.Nodes(0).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Check
                    TreeList.Nodes(1).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default
                    TreeList.Nodes(1).Nodes(0).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
                    TreeList.Nodes(1).Nodes(1).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
                    TreeList.Nodes(1).Nodes(2).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
                    TreeList.Nodes(2).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
                    TreeList.Nodes(3).ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio
            End Select

            TreeList.EndUpdate()
        End Sub

        '</layoutControl.lgOptions>
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            treeList1.ExpandAll()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property DataSource As Object
            Get
                Return treeList1.DataSource
            End Get

            Set(ByVal value As Object)
                treeList1.DataSource = value
            End Set
        End Property
    End Class

    Friend Enum ShowCheckBoxes
        [Default]
        All
        None
    End Enum
End Namespace
