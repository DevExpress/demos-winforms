Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class TreeListMultiEditors
        Inherits TutorialControl

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Protected Overrides ReadOnly Property BarName As String
            Get
                Return "MultiEditors"
            End Get
        End Property

        Protected Overrides ReadOnly Property Manager As BarManager
            Get
                Return barManager1
            End Get
        End Property

        Protected Overrides Sub InitBarInfo()
            BarInfos.Add(New BarInfo("Show Buttons", New ItemClickEventHandler(AddressOf ShowButtonsClick), imageCollection1.Images(0), True, False, False))
            BarInfos.Add(New BarInfo("Tree View", New ItemClickEventHandler(AddressOf TreeViewClick), imageCollection1.Images(1), True, True, False))
            BarInfos.Add(New BarInfo("Show Root", New ItemClickEventHandler(AddressOf ShowRootClick), imageCollection1.Images(2), True, True, False))
            BarInfos.Add(New BarInfo("Can Resize Nodes", New ItemClickEventHandler(AddressOf ResizeClick), imageCollection1.Images(3), True, True, False))
        End Sub

        Public Sub New()
            InitializeComponent()
            InitData()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"MultiEditors"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "MultiEditors"
            End Get
        End Property

        Private Sub ShowButtonsClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            treeList1.ShowButtonMode = If(GetBarItemPushed(0), ShowButtonModeEnum.ShowAlways, ShowButtonModeEnum.ShowForFocusedCell)
        End Sub

        Private Sub TreeViewClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            treeList1.ParentFieldName = If(GetBarItemPushed(1), "ParentID", "~")
            treeList1.ClearSorting()
            treeList1.DataSource = Nothing
            InitData()
        End Sub

        Private Sub ShowRootClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            treeList1.OptionsView.ShowRoot = GetBarItemPushed(2)
        End Sub

        Private Sub ResizeClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            treeList1.OptionsBehavior.ResizeNodes = GetBarItemPushed(3)
            treeList1.SetDefaultRowHeight()
        End Sub

        '<treeList1>
        Private Sub InitData()
            Dim records As Record() = New Record(10) {}
            records(0) = New Record("Product Name", "Chai", "Teatime Chocolate Biscuits", "Ipoh Coffee", 0)
            records(1) = New Record("Category", 1, 2, 1, 1)
            records(2) = New Record("Supplier", "Exotic Liquids", "Specialty Biscuits, Ltd.", "Leka Trading", 2)
            records(3) = New Record("Quantity Per Unit", "10 boxes x 20 bags", "10 boxes x 12 pieces", "16 - 500 g tins", 3, 0)
            records(4) = New Record("Unit Price", 18.00, 9.20, 46.00, 4, 0)
            records(5) = New Record("Units in Stock", 39, 25, 17, 5, 0)
            records(6) = New Record("Discontinued", True, False, True, 6, 0)
            records(7) = New Record("Last Order", New DateTime(2010, 12, 14), New DateTime(2010, 7, 20), New DateTime(2010, 1, 7), 7)
            records(8) = New Record("Relevance", 70, 90, 50, 8)
            records(9) = New Record("Contact Name", "Shelley Burke", "Robb Merchant", "Sven Petersen", 9, 2)
            records(10) = New Record("Phone", "(100) 555-4822", "(111) 555-1222", "(120) 555-1154", 10, 2)
            treeList1.DataSource = records
            treeList1.ExpandAll()
        End Sub

        Private Sub treeList1_GetCustomNodeCellEdit(ByVal sender As Object, ByVal e As GetCustomNodeCellEditEventArgs)
            If Not Equals(e.Column.FieldName, "Category") Then
                Dim obj As Object = e.Node.GetValue(0)
                If obj IsNot Nothing Then
                    Select Case obj.ToString()
                        Case "Category"
                            e.RepositoryItem = repositoryImageComboBox1
                        Case "Supplier"
                            e.RepositoryItem = repositoryItemComboBox1
                        Case "Unit Price"
                            e.RepositoryItem = repositoryItemCalcEdit1
                        Case "Units in Stock"
                            e.RepositoryItem = repositoryItemSpinEdit1
                        Case "Discontinued"
                            e.RepositoryItem = repositoryItemCheckEdit1
                        Case "Last Order"
                            e.RepositoryItem = repositoryItemDateEdit1
                        Case "Relevance"
                            e.RepositoryItem = repositoryItemProgressBar1
                        Case "Phone"
                            e.RepositoryItem = repositoryItemTextEdit1
                    End Select
                End If
            End If
        End Sub

        '</treeList1>
        Private ReadOnly Property IsAlphaBlending As Boolean
            Get
                Return GetBarItemPushed(4)
            End Get
        End Property

        Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As CustomDrawNodeCellEventArgs)
            If e.Column.AbsoluteIndex = 0 OrElse e.Node Is treeList1.FocusedNode Then Return
            If e.Node.ParentNode IsNot Nothing AndAlso e.Node.ParentNode.Id = 2 Then
                e.Appearance.BackColor = Color.FromArgb(If(IsAlphaBlending, 150, 255), 166, 227, 251)
                e.Appearance.ForeColor = Color.Black
            End If

            If(e.Node.Id = 4 OrElse e.Node.Id = 5) AndAlso e.Column.AbsoluteIndex <> 0 Then e.Appearance.TextOptions.HAlignment = HorzAlignment.Far
        End Sub

        '<treeList1>
        ' 
        ' ~Process key strokes within the in-place ProgressBar editor:
        ' 
        Private Sub repositoryItemProgressBar1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Dim i As Integer = 0
            If treeList1.ActiveEditor Is Nothing Then Return
            If e.KeyCode = Keys.Add Then
                i = CInt(treeList1.ActiveEditor.EditValue)
                If i < 100 Then treeList1.ActiveEditor.EditValue = i + 1
            End If

            If e.KeyCode = Keys.Subtract Then
                i = CInt(treeList1.ActiveEditor.EditValue)
                If i > 0 Then treeList1.ActiveEditor.EditValue = i - 1
            End If
        End Sub
    '</treeList1>
    End Class
End Namespace
