Namespace DevExpress.XtraBars.Demos.BrowserDemo

    Partial Class ctrlFavorites

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraBars.Demos.BrowserDemo.ctrlFavorites))
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.iAdd = New DevExpress.XtraBars.BarButtonItem()
            Me.iEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.iDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
            Me.listBox1 = New DevExpress.XtraEditors.ListBoxControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.listBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager1.DockControls.Add(Me.barDockControl1)
            Me.barManager1.DockControls.Add(Me.barDockControl2)
            Me.barManager1.DockControls.Add(Me.barDockControl3)
            Me.barManager1.DockControls.Add(Me.barDockControl4)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.imageCollection1
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.iAdd, Me.iEdit, Me.iDelete, Me.iOpen})
            Me.barManager1.MaxItemId = 4
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Edit"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(43, 86)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.iEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpen, True)})
            Me.bar1.Text = "Edit"
            ' 
            ' iAdd
            ' 
            Me.iAdd.Caption = "&Add"
            Me.iAdd.Hint = "Add Favorite"
            Me.iAdd.Id = 0
            Me.iAdd.ImageOptions.ImageIndex = 0
            Me.iAdd.Name = "iAdd"
            AddHandler Me.iAdd.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iAdd_ItemClick)
            ' 
            ' iEdit
            ' 
            Me.iEdit.Caption = "&Edit"
            Me.iEdit.Hint = "Edit Favorite"
            Me.iEdit.Id = 1
            Me.iEdit.ImageOptions.ImageIndex = 1
            Me.iEdit.Name = "iEdit"
            AddHandler Me.iEdit.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iEdit_ItemClick)
            ' 
            ' iDelete
            ' 
            Me.iDelete.Caption = "&Delete"
            Me.iDelete.Hint = "Delete Favorite"
            Me.iDelete.Id = 2
            Me.iDelete.ImageOptions.ImageIndex = 2
            Me.iDelete.Name = "iDelete"
            AddHandler Me.iDelete.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iDelete_ItemClick)
            ' 
            ' iOpen
            ' 
            Me.iOpen.Caption = "&Open"
            Me.iOpen.Hint = "Open Favorite"
            Me.iOpen.Id = 3
            Me.iOpen.ImageOptions.ImageIndex = 3
            Me.iOpen.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
            Me.iOpen.Name = "iOpen"
            AddHandler Me.iOpen.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iOpen_ItemClick)
            ' 
            ' barDockControl1
            ' 
            Me.barDockControl1.CausesValidation = False
            Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControl1.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl1.Manager = Me.barManager1
            Me.barDockControl1.Size = New System.Drawing.Size(196, 24)
            ' 
            ' barDockControl2
            ' 
            Me.barDockControl2.CausesValidation = False
            Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControl2.Location = New System.Drawing.Point(0, 248)
            Me.barDockControl2.Manager = Me.barManager1
            Me.barDockControl2.Size = New System.Drawing.Size(196, 0)
            ' 
            ' barDockControl3
            ' 
            Me.barDockControl3.CausesValidation = False
            Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControl3.Location = New System.Drawing.Point(0, 24)
            Me.barDockControl3.Manager = Me.barManager1
            Me.barDockControl3.Size = New System.Drawing.Size(0, 224)
            ' 
            ' barDockControl4
            ' 
            Me.barDockControl4.CausesValidation = False
            Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControl4.Location = New System.Drawing.Point(196, 24)
            Me.barDockControl4.Manager = Me.barManager1
            Me.barDockControl4.Size = New System.Drawing.Size(0, 224)
            ' 
            ' listBox1
            ' 
            Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBox1.ItemHeight = 15
            Me.listBox1.Location = New System.Drawing.Point(0, 24)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(196, 224)
            Me.listBox1.TabIndex = 4
            AddHandler Me.listBox1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.listBox1_SelectedIndexChanged)
            AddHandler Me.listBox1.DoubleClick, New System.EventHandler(AddressOf Me.listBox1_DoubleClick)
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "insert_16x16.png")
            Me.imageCollection1.Images.SetKeyName(1, "edit_16x16.png")
            Me.imageCollection1.Images.SetKeyName(2, "deletelist2_16x16.png")
            Me.imageCollection1.Images.SetKeyName(3, "article_16x16.png")
            ' 
            ' ctrlFavorites
            ' 
            Me.Controls.Add(Me.listBox1)
            Me.Controls.Add(Me.barDockControl3)
            Me.Controls.Add(Me.barDockControl4)
            Me.Controls.Add(Me.barDockControl2)
            Me.Controls.Add(Me.barDockControl1)
            Me.Name = "ctrlFavorites"
            Me.Size = New System.Drawing.Size(196, 248)
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.listBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Friend barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControl1 As DevExpress.XtraBars.BarDockControl

        Private barDockControl2 As DevExpress.XtraBars.BarDockControl

        Private barDockControl3 As DevExpress.XtraBars.BarDockControl

        Private barDockControl4 As DevExpress.XtraBars.BarDockControl

        Private iAdd As DevExpress.XtraBars.BarButtonItem

        Private iEdit As DevExpress.XtraBars.BarButtonItem

        Private iDelete As DevExpress.XtraBars.BarButtonItem

        Private listBox1 As DevExpress.XtraEditors.ListBoxControl

        Private iOpen As DevExpress.XtraBars.BarButtonItem

        Private bar1 As DevExpress.XtraBars.Bar

        Private components As System.ComponentModel.IContainer

        Private imageCollection1 As DevExpress.Utils.ImageCollection
    End Class
End Namespace
