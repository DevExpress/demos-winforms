Namespace DevExpress.MailClient.Win
    Partial Public Class ucMailTree
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ucMailTree))
            Me.treeList1 = New DevExpress.MailClient.Win.MyTreeList()
            Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.colType = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colFolder = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colImageIndex = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colData = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.icFolders = New DevExpress.Utils.ImageCollection(Me.components)
            DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icFolders, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.AllowDrop = True
            Me.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colName, Me.colType, Me.colFolder, Me.colImageIndex, Me.colData})
            Me.treeList1.DataSource = Nothing
            resources.ApplyResources(Me.treeList1, "treeList1")
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsView.ShowColumns = False
            Me.treeList1.OptionsView.ShowHorzLines = False
            Me.treeList1.OptionsView.ShowIndentAsRowStyle = True
            Me.treeList1.OptionsView.ShowIndicator = False
            Me.treeList1.OptionsView.ShowVertLines = False
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemButtonEdit1, Me.repositoryItemTextEdit1})
            Me.treeList1.SelectImageList = Me.icFolders
            ' 
            ' colName
            ' 
            resources.ApplyResources(Me.colName, "colName")
            Me.colName.ColumnEdit = Me.repositoryItemButtonEdit1
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.OptionsColumn.AllowFocus = False
            ' 
            ' repositoryItemButtonEdit1
            ' 
            Me.repositoryItemButtonEdit1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
            resources.ApplyResources(Me.repositoryItemButtonEdit1, "repositoryItemButtonEdit1")
            Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
            Me.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' colType
            ' 
            Me.colType.Name = "colType"
            ' 
            ' colFolder
            ' 
            Me.colFolder.Name = "colFolder"
            ' 
            ' colImageIndex
            ' 
            Me.colImageIndex.FieldName = "ImageIndex"
            Me.colImageIndex.Name = "colImageIndex"
            ' 
            ' colData
            ' 
            Me.colData.FieldName = "colData"
            Me.colData.Name = "colData"
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' icFolders
            ' 
            Me.icFolders.ImageStream = (DirectCast(resources.GetObject("icFolders.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icFolders.Images.SetKeyName(0, "Inbox_16x16.png")
            Me.icFolders.Images.SetKeyName(1, "SentItems_16x16.png")
            Me.icFolders.Images.SetKeyName(2, "DeletedItems_16x16.png")
            Me.icFolders.Images.SetKeyName(3, "Drafts_16x16.png")
            Me.icFolders.Images.SetKeyName(4, "Customer.png")
            Me.icFolders.Images.SetKeyName(5, "Announcements.png")
            Me.icFolders.InsertGalleryImage("namemanager_16x16.png", "images/spreadsheet/namemanager_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/spreadsheet/namemanager_16x16.png"), 6)
            Me.icFolders.Images.SetKeyName(6, "namemanager_16x16.png")
            Me.icFolders.InsertGalleryImage("feeds_16x16.png", "images/mail/feeds_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/feeds_16x16.png"), 7)
            Me.icFolders.Images.SetKeyName(7, "feeds_16x16.png")
            Me.icFolders.InsertGalleryImage("bosale_16x16.png", "images/business%20objects/bosale_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/bosale_16x16.png"), 8)
            Me.icFolders.Images.SetKeyName(8, "bosale_16x16.png")
            Me.icFolders.InsertGalleryImage("properties_16x16.png", "images/setup/properties_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/setup/properties_16x16.png"), 9)
            Me.icFolders.Images.SetKeyName(9, "properties_16x16.png")
            ' 
            ' ucMailTree
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Name = "ucMailTree"
            DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icFolders, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents treeList1 As MyTreeList
        Private colName As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private colType As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private colFolder As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private colImageIndex As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private icFolders As DevExpress.Utils.ImageCollection
        Private colData As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Private repositoryItemTextEdit1 As XtraEditors.Repository.RepositoryItemTextEdit
    End Class
End Namespace
