Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
    Partial Public Class DeletingPersistentObjects
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeletingPersistentObjects))
            Me.xpProjects = New DevExpress.Xpo.XPCollection()
            Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork()
            Me.iProjectStatus = New System.Windows.Forms.ImageList(Me.components)
            Me.iProjectType = New System.Windows.Forms.ImageList(Me.components)
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProjectName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOwner = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colProjectType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.sbDeleteSelected = New DevExpress.XtraEditors.SimpleButton()
            Me.sbRestore = New DevExpress.XtraEditors.SimpleButton()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.xpImmediateDeletionProjects = New DevExpress.Xpo.XPCollection()
            Me.unitOfWork2 = New DevExpress.Xpo.UnitOfWork()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProjectName1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOwner1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreatedDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.sbAddNew = New DevExpress.XtraEditors.SimpleButton()
            Me.sbImmediateDelete = New DevExpress.XtraEditors.SimpleButton()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.xpProjects, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.xtraTabPage2.SuspendLayout()
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpImmediateDeletionProjects, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.unitOfWork2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' xpProjects
            ' 
            Me.xpProjects.ObjectType = GetType(DevExpress.Xpo.Demos.Project)
            Me.xpProjects.SelectDeleted = True
            Me.xpProjects.Session = Me.unitOfWork1
            ' 
            ' iProjectStatus
            ' 
            Me.iProjectStatus.ImageStream = (CType(resources.GetObject("iProjectStatus.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.iProjectStatus.TransparentColor = System.Drawing.Color.Magenta
            Me.iProjectStatus.Images.SetKeyName(0, "")
            Me.iProjectStatus.Images.SetKeyName(1, "")
            Me.iProjectStatus.Images.SetKeyName(2, "")
            Me.iProjectStatus.Images.SetKeyName(3, "")
            ' 
            ' iProjectType
            ' 
            Me.iProjectType.ImageStream = (CType(resources.GetObject("iProjectType.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.iProjectType.TransparentColor = System.Drawing.Color.Magenta
            Me.iProjectType.Images.SetKeyName(0, "")
            Me.iProjectType.Images.SetKeyName(1, "")
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
            Me.xtraTabControl1.Location = New System.Drawing.Point(4, 4)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(765, 424)
            Me.xtraTabControl1.TabIndex = 2
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2})
            Me.xtraTabControl1.Text = "xtraTabControl1"
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.gridControl1)
            Me.xtraTabPage1.Controls.Add(Me.panelControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(735, 415)
            Me.xtraTabPage1.Text = "Deferred Deletion"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.xpProjects
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Location = New System.Drawing.Point(0, 40)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.Size = New System.Drawing.Size(735, 375)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colProjectName, Me.colName, Me.colOwner, Me.colCreatedDate, Me.colStatus, Me.colProjectType})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            '			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged);
            '			Me.gridView1.RowStyle += New DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(Me.gridView1_RowStyle);
            ' 
            ' colOid
            ' 
            Me.colOid.Caption = "Oid"
            Me.colOid.FieldName = "Oid"
            Me.colOid.Name = "colOid"
            Me.colOid.Visible = True
            Me.colOid.VisibleIndex = 0
            ' 
            ' colProjectName
            ' 
            Me.colProjectName.Caption = "Project Name"
            Me.colProjectName.FieldName = "ProjectName"
            Me.colProjectName.Name = "colProjectName"
            Me.colProjectName.Visible = True
            Me.colProjectName.VisibleIndex = 1
            ' 
            ' colName
            ' 
            Me.colName.Caption = "Name"
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 2
            ' 
            ' colOwner
            ' 
            Me.colOwner.Caption = "Owner"
            Me.colOwner.FieldName = "Owner"
            Me.colOwner.Name = "colOwner"
            Me.colOwner.Visible = True
            Me.colOwner.VisibleIndex = 3
            ' 
            ' colCreatedDate
            ' 
            Me.colCreatedDate.Caption = "Created Date"
            Me.colCreatedDate.FieldName = "CreatedDate"
            Me.colCreatedDate.Name = "colCreatedDate"
            Me.colCreatedDate.Visible = True
            Me.colCreatedDate.VisibleIndex = 4
            ' 
            ' colStatus
            ' 
            Me.colStatus.Caption = "Status"
            Me.colStatus.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colStatus.FieldName = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 5
            ' 
            ' repositoryItemImageComboBox1
            ' 
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.iProjectStatus
            ' 
            ' colProjectType
            ' 
            Me.colProjectType.Caption = "Project Type"
            Me.colProjectType.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.colProjectType.FieldName = "ProjectType"
            Me.colProjectType.Name = "colProjectType"
            Me.colProjectType.Visible = True
            Me.colProjectType.VisibleIndex = 6
            ' 
            ' repositoryItemImageComboBox2
            ' 
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.iProjectType
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.sbDeleteSelected)
            Me.panelControl1.Controls.Add(Me.sbRestore)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(735, 40)
            Me.panelControl1.TabIndex = 2
            Me.panelControl1.Text = "panelControl1"
            ' 
            ' sbDeleteSelected
            ' 
            Me.sbDeleteSelected.Location = New System.Drawing.Point(8, 8)
            Me.sbDeleteSelected.Name = "sbDeleteSelected"
            Me.sbDeleteSelected.Size = New System.Drawing.Size(112, 23)
            Me.sbDeleteSelected.TabIndex = 3
            Me.sbDeleteSelected.Text = "Delete Record"
            '			Me.sbDeleteSelected.Click += New System.EventHandler(Me.sbDeleteSelected_Click);
            ' 
            ' sbRestore
            ' 
            Me.sbRestore.Enabled = False
            Me.sbRestore.Location = New System.Drawing.Point(128, 8)
            Me.sbRestore.Name = "sbRestore"
            Me.sbRestore.Size = New System.Drawing.Size(80, 23)
            Me.sbRestore.TabIndex = 2
            Me.sbRestore.Text = "Restore"
            '			Me.sbRestore.Click += New System.EventHandler(Me.sbRestore_Click);
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Controls.Add(Me.gridControl2)
            Me.xtraTabPage2.Controls.Add(Me.panelControl2)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Size = New System.Drawing.Size(735, 415)
            Me.xtraTabPage2.Text = "Immediate Deletion"
            ' 
            ' gridControl2
            ' 
            Me.gridControl2.DataSource = Me.xpImmediateDeletionProjects
            Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl2.EmbeddedNavigator.Buttons.Remove.Visible = False
            Me.gridControl2.EmbeddedNavigator.Name = ""
            Me.gridControl2.Location = New System.Drawing.Point(0, 40)
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox3, Me.repositoryItemImageComboBox4})
            Me.gridControl2.ShowOnlyPredefinedDetails = True
            Me.gridControl2.Size = New System.Drawing.Size(735, 375)
            Me.gridControl2.TabIndex = 1
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            ' 
            ' xpImmediateDeletionProjects
            ' 
            Me.xpImmediateDeletionProjects.ObjectType = GetType(DevExpress.Xpo.Demos.ImmediateDeletionProject)
            Me.xpImmediateDeletionProjects.Session = Me.unitOfWork2
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProjectName1, Me.colOwner1, Me.colCreatedDate1})
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsView.ShowGroupPanel = False
            ' 
            ' colProjectName1
            ' 
            Me.colProjectName1.Caption = "Project Name"
            Me.colProjectName1.FieldName = "ProjectName"
            Me.colProjectName1.Name = "colProjectName1"
            Me.colProjectName1.Visible = True
            Me.colProjectName1.VisibleIndex = 0
            ' 
            ' colOwner1
            ' 
            Me.colOwner1.Caption = "Owner"
            Me.colOwner1.FieldName = "Owner"
            Me.colOwner1.Name = "colOwner1"
            Me.colOwner1.Visible = True
            Me.colOwner1.VisibleIndex = 1
            ' 
            ' colCreatedDate1
            ' 
            Me.colCreatedDate1.Caption = "Created Date"
            Me.colCreatedDate1.FieldName = "CreatedDate"
            Me.colCreatedDate1.Name = "colCreatedDate1"
            Me.colCreatedDate1.Visible = True
            Me.colCreatedDate1.VisibleIndex = 2
            ' 
            ' repositoryItemImageComboBox3
            ' 
            Me.repositoryItemImageComboBox3.AutoHeight = False
            Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            Me.repositoryItemImageComboBox3.SmallImages = Me.iProjectStatus
            ' 
            ' repositoryItemImageComboBox4
            ' 
            Me.repositoryItemImageComboBox4.AutoHeight = False
            Me.repositoryItemImageComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
            Me.repositoryItemImageComboBox4.SmallImages = Me.iProjectType
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.sbAddNew)
            Me.panelControl2.Controls.Add(Me.sbImmediateDelete)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 0)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(735, 40)
            Me.panelControl2.TabIndex = 2
            Me.panelControl2.Text = "panelControl2"
            ' 
            ' sbAddNew
            ' 
            Me.sbAddNew.Location = New System.Drawing.Point(120, 8)
            Me.sbAddNew.Name = "sbAddNew"
            Me.sbAddNew.Size = New System.Drawing.Size(104, 23)
            Me.sbAddNew.TabIndex = 1
            Me.sbAddNew.Text = "Add New Record"
            '			Me.sbAddNew.Click += New System.EventHandler(Me.sbAddNew_Click);
            ' 
            ' sbImmediateDelete
            ' 
            Me.sbImmediateDelete.Location = New System.Drawing.Point(8, 8)
            Me.sbImmediateDelete.Name = "sbImmediateDelete"
            Me.sbImmediateDelete.Size = New System.Drawing.Size(104, 23)
            Me.sbImmediateDelete.TabIndex = 0
            Me.sbImmediateDelete.Text = "Delete"
            '			Me.sbImmediateDelete.Click += New System.EventHandler(Me.sbImmediateDelete_Click);
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "Oid"
            Me.gridColumn1.FieldName = "Oid"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "Project Name"
            Me.gridColumn2.FieldName = "ProjectName"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.Caption = "Owner"
            Me.gridColumn3.FieldName = "Owner"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            ' 
            ' gridColumn4
            ' 
            Me.gridColumn4.Caption = "Created Date"
            Me.gridColumn4.FieldName = "CreatedDate"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            ' 
            ' colProductName
            ' 
            Me.colProductName.Caption = "Produc tName"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.Caption = "Order Date"
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 1
            ' 
            ' DeletingPersistentObjects
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "DeletingPersistentObjects"
            Me.Size = New System.Drawing.Size(773, 432)
            '			Me.Load += New System.EventHandler(Me.DeletingPersistentObjects_Load);
            CType(Me.xpProjects, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.xtraTabPage2.ResumeLayout(False)
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpImmediateDeletionProjects, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.unitOfWork2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private xpProjects As DevExpress.Xpo.XPCollection
        Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
        Private iProjectStatus As System.Windows.Forms.ImageList
        Private iProjectType As System.Windows.Forms.ImageList
        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colOid As DevExpress.XtraGrid.Columns.GridColumn
        Private colProjectName As DevExpress.XtraGrid.Columns.GridColumn
        Private colOwner As DevExpress.XtraGrid.Columns.GridColumn
        Private colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private colProjectType As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private gridControl2 As DevExpress.XtraGrid.GridControl
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
        Private xpImmediateDeletionProjects As DevExpress.Xpo.XPCollection
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents sbDeleteSelected As DevExpress.XtraEditors.SimpleButton
        Private WithEvents sbRestore As DevExpress.XtraEditors.SimpleButton
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents sbImmediateDelete As DevExpress.XtraEditors.SimpleButton
        Private unitOfWork2 As DevExpress.Xpo.UnitOfWork
        Private colProjectName1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colOwner1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colCreatedDate1 As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents sbAddNew As DevExpress.XtraEditors.SimpleButton
        Private colName As DevExpress.XtraGrid.Columns.GridColumn
        Private components As System.ComponentModel.IContainer

    End Class
End Namespace
