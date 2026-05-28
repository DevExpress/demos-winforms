Imports System

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class BusinessObjectBinding
        Inherits TutorialControl

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Private treeList1 As TreeList

        Private propertyGridControl1 As XtraVerticalGrid.PropertyGridControl

        Private treeListColumn1 As Columns.TreeListColumn

        Private treeListColumn3 As Columns.TreeListColumn

        Private treeListColumn4 As Columns.TreeListColumn

        Private treeListColumn5 As Columns.TreeListColumn

        Private repositoryItemDateEdit1 As XtraEditors.Repository.RepositoryItemDateEdit

        Private repositoryItemDateEdit2 As XtraEditors.Repository.RepositoryItemDateEdit

        Private repositoryItemImageComboBox1 As XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemProgressBar1 As XtraEditors.Repository.RepositoryItemProgressBar

        Private components As System.ComponentModel.IContainer

        Private repositoryItemCheckEdit1 As XtraEditors.Repository.RepositoryItemCheckEdit

        Private repositoryItemDateEdit3 As XtraEditors.Repository.RepositoryItemDateEdit

        Private imageCollection1 As Utils.ImageCollection

        Private imageCollection2 As Utils.ImageCollection

        Private splitContainerControl1 As XtraEditors.SplitContainerControl

        Public Sub New()
            InitializeComponent()
            InitEditors()
            InitData()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"BusinessObjectBinding", "BusinessObject"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "BusinessObjectBinding"
            End Get
        End Property

        Private Sub InitEditors()
            repositoryItemImageComboBox1.Items.AddEnum(GetType(Priority))
            repositoryItemImageComboBox1.Items(0).ImageIndex = 0
            repositoryItemImageComboBox1.Items(1).ImageIndex = 1
            repositoryItemImageComboBox1.Items(2).ImageIndex = 2
        End Sub

        '<treeList1>
        Private Sub InitData()
            Dim projects As Projects = New Projects()
            projects.Add(New Project("Project: Betaron", "", New DateTime(2011, 05, 01), New DateTime(2011, 09, 20), Priority.Normal, False))
            projects.Add(New Project("Project: Stanton", "", New DateTime(2011, 03, 04), New DateTime(2011, 05, 01), Priority.Normal, False))
            projects(0).Projects.Add(New Project("Planning", "", New DateTime(2011, 05, 12), New DateTime(2011, 06, 15), Priority.Normal, False))
            projects(0).Projects.Add(New Project("Design", "", New DateTime(2011, 07, 16), New DateTime(2011, 09, 20), Priority.Normal, False))
            projects(0).Projects.Add(New Project("Development", "", New DateTime(2011, 07, 16), New DateTime(2011, 08, 20), Priority.Normal, False))
            projects(0).Projects.Add(New Project("Testing and Delivery", "", New DateTime(2011, 08, 12), New DateTime(2011, 10, 17), Priority.Normal, False))
            projects(0).Projects(0).Projects.Add(New Project("Market research", "", New DateTime(2011, 05, 01), New DateTime(2011, 05, 13), Priority.Normal, True))
            projects(0).Projects(0).Projects.Add(New Project("Making specification", "", New DateTime(2011, 05, 14), New DateTime(2011, 06, 04), Priority.Low, True))
            projects(0).Projects(0).Projects.Add(New Project("Documentation", "", New DateTime(2011, 06, 05), New DateTime(2011, 06, 15), Priority.Normal, True))
            projects(0).Projects(1).Projects.Add(New Project("Design of a web pages", "", New DateTime(2011, 07, 16), New DateTime(2011, 07, 28), Priority.Low, True))
            projects(0).Projects(1).Projects.Add(New Project("Pages layout", "", New DateTime(2011, 08, 01), New DateTime(2011, 09, 20), Priority.Normal, True))
            projects(0).Projects(2).Projects.Add(New Project("Design", "", New DateTime(2011, 07, 16), New DateTime(2011, 07, 28), Priority.Low, True))
            projects(0).Projects(2).Projects.Add(New Project("Coding", "", New DateTime(2011, 08, 01), New DateTime(2011, 09, 20), Priority.Normal, True))
            projects(0).Projects(3).Projects.Add(New Project("Testing", "", New DateTime(2011, 08, 12), New DateTime(2011, 08, 28), Priority.Low, True))
            projects(0).Projects(3).Projects.Add(New Project("Content", "", New DateTime(2011, 09, 1), New DateTime(2011, 09, 24), Priority.Normal, True))
            projects(1).Projects.Add(New Project("Planning", "", New DateTime(2012, 03, 01), New DateTime(2012, 04, 15), Priority.Normal, True))
            projects(1).Projects.Add(New Project("Design", "", New DateTime(2012, 04, 12), New DateTime(2012, 05, 12), Priority.Low, True))
            projects(1).Projects.Add(New Project("Development", "", New DateTime(2012, 05, 16), New DateTime(2012, 05, 23), Priority.Low, True))
            projects(1).Projects.Add(New Project("Testing and Delivery", "", New DateTime(2012, 06, 16), New DateTime(2012, 06, 25), Priority.Low, True))
            projects(1).Projects(0).Projects.Add(New Project("Market research", "", New DateTime(2012, 05, 01), New DateTime(2012, 05, 13), Priority.Normal, True))
            projects(1).Projects(0).Projects.Add(New Project("Making specification", "", New DateTime(2012, 05, 14), New DateTime(2012, 06, 04), Priority.Low, True))
            projects(1).Projects(0).Projects.Add(New Project("Documentation", "", New DateTime(2012, 06, 05), New DateTime(2012, 06, 15), Priority.Normal, True))
            projects(1).Projects(1).Projects.Add(New Project("Design of a web pages", "", New DateTime(2012, 07, 16), New DateTime(2012, 07, 28), Priority.Low, True))
            projects(1).Projects(1).Projects.Add(New Project("Pages layout", "", New DateTime(2012, 08, 01), New DateTime(2012, 09, 20), Priority.Normal, True))
            projects(1).Projects(2).Projects.Add(New Project("Design", "", New DateTime(2012, 07, 16), New DateTime(2012, 07, 28), Priority.Low, True))
            projects(1).Projects(2).Projects.Add(New Project("Coding", "", New DateTime(2012, 08, 01), New DateTime(2012, 09, 20), Priority.Normal, True))
            projects(1).Projects(3).Projects.Add(New Project("Testing", "", New DateTime(2012, 08, 12), New DateTime(2012, 08, 28), Priority.Low, True))
            projects(1).Projects(3).Projects.Add(New Project("Content", "", New DateTime(2012, 09, 1), New DateTime(2012, 09, 24), Priority.Normal, True))
            treeList1.DataSource = projects
        End Sub

        '</treeList1>
        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusinessObjectBinding))
            splitContainerControl1 = New XtraEditors.SplitContainerControl()
            treeList1 = New TreeList()
            treeListColumn1 = New Columns.TreeListColumn()
            treeListColumn3 = New Columns.TreeListColumn()
            repositoryItemDateEdit1 = New XtraEditors.Repository.RepositoryItemDateEdit()
            treeListColumn4 = New Columns.TreeListColumn()
            repositoryItemDateEdit2 = New XtraEditors.Repository.RepositoryItemDateEdit()
            treeListColumn5 = New Columns.TreeListColumn()
            repositoryItemImageComboBox1 = New XtraEditors.Repository.RepositoryItemImageComboBox()
            imageCollection2 = New Utils.ImageCollection(components)
            repositoryItemProgressBar1 = New XtraEditors.Repository.RepositoryItemProgressBar()
            imageCollection1 = New Utils.ImageCollection(components)
            propertyGridControl1 = New XtraVerticalGrid.PropertyGridControl()
            repositoryItemCheckEdit1 = New XtraEditors.Repository.RepositoryItemCheckEdit()
            repositoryItemDateEdit3 = New XtraEditors.Repository.RepositoryItemDateEdit()
            CType(splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            splitContainerControl1.Panel1.SuspendLayout()
            CType(splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            splitContainerControl1.Panel2.SuspendLayout()
            splitContainerControl1.SuspendLayout()
            CType(treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' splitContainerControl1
            ' 
            splitContainerControl1.Dock = Windows.Forms.DockStyle.Fill
            splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            splitContainerControl1.Name = "splitContainerControl1"
            ' 
            ' splitContainerControl1.Panel1
            ' 
            splitContainerControl1.Panel1.Controls.Add(treeList1)
            splitContainerControl1.Panel1.Text = "Panel1"
            ' 
            ' splitContainerControl1.Panel2
            ' 
            splitContainerControl1.Panel2.Controls.Add(propertyGridControl1)
            splitContainerControl1.Panel2.Text = "Panel2"
            splitContainerControl1.Size = New System.Drawing.Size(792, 406)
            splitContainerControl1.SplitterPosition = 560
            splitContainerControl1.TabIndex = 0
            splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' treeList1
            ' 
            treeList1.Columns.AddRange(New Columns.TreeListColumn() {treeListColumn1, treeListColumn3, treeListColumn4, treeListColumn5})
            treeList1.Dock = Windows.Forms.DockStyle.Fill
            treeList1.Location = New System.Drawing.Point(0, 0)
            treeList1.Name = "treeList1"
            treeList1.RepositoryItems.AddRange(New XtraEditors.Repository.RepositoryItem() {repositoryItemDateEdit1, repositoryItemDateEdit2, repositoryItemImageComboBox1, repositoryItemProgressBar1})
            treeList1.Size = New System.Drawing.Size(560, 406)
            treeList1.StateImageList = imageCollection1
            treeList1.TabIndex = 0
            AddHandler treeList1.GetStateImage, New GetStateImageEventHandler(AddressOf treeList1_GetStateImage)
            AddHandler treeList1.AfterExpand, New NodeEventHandler(AddressOf treeList1_AfterExpand)
            AddHandler treeList1.FocusedNodeChanged, New FocusedNodeChangedEventHandler(AddressOf treeList1_FocusedNodeChanged)
            AddHandler treeList1.CellValueChanged, New CellValueChangedEventHandler(AddressOf treeList1_CellValueChanged)
            ' 
            ' treeListColumn1
            ' 
            treeListColumn1.Caption = "Name"
            treeListColumn1.FieldName = "Name"
            treeListColumn1.MinWidth = 33
            treeListColumn1.Name = "treeListColumn1"
            treeListColumn1.Visible = True
            treeListColumn1.VisibleIndex = 0
            ' 
            ' treeListColumn3
            ' 
            treeListColumn3.Caption = "StartDate"
            treeListColumn3.ColumnEdit = repositoryItemDateEdit1
            treeListColumn3.FieldName = "StartDate"
            treeListColumn3.Name = "treeListColumn3"
            treeListColumn3.Visible = True
            treeListColumn3.VisibleIndex = 1
            ' 
            ' repositoryItemDateEdit1
            ' 
            repositoryItemDateEdit1.AutoHeight = False
            repositoryItemDateEdit1.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            ' 
            ' treeListColumn4
            ' 
            treeListColumn4.Caption = "EndDate"
            treeListColumn4.ColumnEdit = repositoryItemDateEdit2
            treeListColumn4.FieldName = "EndDate"
            treeListColumn4.Name = "treeListColumn4"
            treeListColumn4.Visible = True
            treeListColumn4.VisibleIndex = 2
            ' 
            ' repositoryItemDateEdit2
            ' 
            repositoryItemDateEdit2.AutoHeight = False
            repositoryItemDateEdit2.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            repositoryItemDateEdit2.Name = "repositoryItemDateEdit2"
            ' 
            ' treeListColumn5
            ' 
            treeListColumn5.Caption = "Priority"
            treeListColumn5.ColumnEdit = repositoryItemImageComboBox1
            treeListColumn5.FieldName = "Priority"
            treeListColumn5.Name = "treeListColumn5"
            treeListColumn5.Visible = True
            treeListColumn5.VisibleIndex = 3
            ' 
            ' repositoryItemImageComboBox1
            ' 
            repositoryItemImageComboBox1.AllowFocused = False
            repositoryItemImageComboBox1.AutoHeight = False
            repositoryItemImageComboBox1.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            repositoryItemImageComboBox1.SmallImages = imageCollection2
            ' 
            ' imageCollection2
            ' 
            imageCollection2.ImageStream = CType(resources.GetObject("imageCollection2.ImageStream"), Utils.ImageCollectionStreamer)
            imageCollection2.Images.SetKeyName(0, "Normal1.png")
            imageCollection2.Images.SetKeyName(1, "Low1.png")
            imageCollection2.Images.SetKeyName(2, "High1.png")
            ' 
            ' repositoryItemProgressBar1
            ' 
            repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            ' 
            ' imageCollection1
            ' 
            imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), Utils.ImageCollectionStreamer)
            imageCollection1.Images.SetKeyName(0, "Object_Project.png")
            imageCollection1.Images.SetKeyName(1, "Object_Task.png")
            ' 
            ' propertyGridControl1
            ' 
            propertyGridControl1.DefaultEditors.AddRange(New XtraVerticalGrid.Rows.DefaultEditor() {New XtraVerticalGrid.Rows.DefaultEditor(GetType(Boolean), repositoryItemCheckEdit1), New XtraVerticalGrid.Rows.DefaultEditor(GetType(Date), repositoryItemDateEdit3)})
            propertyGridControl1.Dock = Windows.Forms.DockStyle.Fill
            propertyGridControl1.Location = New System.Drawing.Point(0, 0)
            propertyGridControl1.Name = "propertyGridControl1"
            propertyGridControl1.OptionsBehavior.PropertySort = XtraVerticalGrid.PropertySort.NoSort
            propertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = Utils.DefaultBoolean.True
            propertyGridControl1.OptionsView.ShowRootCategories = False
            propertyGridControl1.RepositoryItems.AddRange(New XtraEditors.Repository.RepositoryItem() {repositoryItemCheckEdit1, repositoryItemDateEdit3})
            propertyGridControl1.Size = New System.Drawing.Size(222, 406)
            propertyGridControl1.TabIndex = 0
            ' 
            ' repositoryItemCheckEdit1
            ' 
            repositoryItemCheckEdit1.AutoHeight = False
            repositoryItemCheckEdit1.Caption = "Check"
            repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
            ' 
            ' repositoryItemDateEdit3
            ' 
            repositoryItemDateEdit3.AutoHeight = False
            repositoryItemDateEdit3.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New XtraEditors.Controls.EditorButton()})
            repositoryItemDateEdit3.Name = "repositoryItemDateEdit3"
            ' 
            ' BusinessObjectBinding
            ' 
            Me.Controls.Add(splitContainerControl1)
            Name = "BusinessObjectBinding"
            Size = New System.Drawing.Size(792, 406)
            AddHandler Load, New EventHandler(AddressOf businessObjectBinding_Load)
            CType(splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
            splitContainerControl1.Panel1.ResumeLayout(False)
            CType(splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
            splitContainerControl1.Panel2.ResumeLayout(False)
            CType(splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            splitContainerControl1.ResumeLayout(False)
            CType(treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        '<propertyGridControl1>
        Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs)
            propertyGridControl1.SelectedObject = treeList1.GetDataRecordByNode(e.Node)
        End Sub

        '</propertyGridControl1>
        Private Sub businessObjectBinding_Load(ByVal sender As Object, ByVal e As EventArgs)
            treeList1.ForceInitialize()
            treeList1.ExpandAll()
            treeList1.FocusedNode = treeList1.Nodes.FirstNode
            treeList1.BestFitColumns()
        End Sub

        Private Sub treeList1_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs)
            propertyGridControl1.Refresh()
        End Sub

        Private Sub treeList1_AfterExpand(ByVal sender As Object, ByVal e As NodeEventArgs)
            treeList1.BestFitColumns()
        End Sub

        Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As GetStateImageEventArgs)
            Dim project As Project = CType(treeList1.GetDataRecordByNode(e.Node), Project)
            If project Is Nothing Then Return
            e.NodeImageIndex = If(project.IsTask, 1, 0)
        End Sub
    End Class
End Namespace
