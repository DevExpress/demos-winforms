Namespace PhotoViewer

    Partial Class ImageCollectionViewer

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Dim galleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            CType((Me.galleryControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.galleryControl1.SuspendLayout()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' galleryControl1
            ' 
            Me.galleryControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
            Me.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
            ' 
            ' 
            ' 
            Me.galleryControl1.Gallery.AutoFitColumns = False
            Me.galleryControl1.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.None
            Me.galleryControl1.Gallery.ColumnCount = 1
            Me.galleryControl1.Gallery.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.galleryControl1.Gallery.FirstItemVertAlignment = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAlignment.Center
            galleryItemGroup1.Caption = "Group1"
            Me.galleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            Me.galleryControl1.Gallery.ImageSize = New System.Drawing.Size(50, 50)
            Me.galleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomOutside
            Me.galleryControl1.Gallery.LastItemVertAlignment = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAlignment.Center
            Me.galleryControl1.Gallery.Orientation = System.Windows.Forms.Orientation.Horizontal
            Me.galleryControl1.Gallery.ScrollMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryScrollMode.Smooth
            Me.galleryControl1.Gallery.ShowGroupCaption = False
            Me.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
            AddHandler Me.galleryControl1.Gallery.EndScroll, New System.EventHandler(AddressOf Me.galleryControl1_Gallery_EndScroll)
            AddHandler Me.galleryControl1.Gallery.ItemCheckedChanged, New DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(AddressOf Me.galleryControl1_Gallery_ItemCheckedChanged)
            Me.galleryControl1.Location = New System.Drawing.Point(0, 0)
            Me.galleryControl1.Name = "galleryControl1"
            Me.galleryControl1.Size = New System.Drawing.Size(899, 91)
            Me.galleryControl1.TabIndex = 0
            Me.galleryControl1.Text = "galleryControl1"
            ' 
            ' galleryControlClient1
            ' 
            Me.galleryControlClient1.GalleryControl = Me.galleryControl1
            Me.galleryControlClient1.Location = New System.Drawing.Point(1, 1)
            Me.galleryControlClient1.Size = New System.Drawing.Size(897, 89)
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Form = Me
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.dockPanel2})
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            Me.dockPanel1.ID = New System.Guid("8388944d-b625-4ad1-a842-9ec8e9162c48")
            Me.dockPanel1.Location = New System.Drawing.Point(2, 481)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Options.ShowCloseButton = False
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 121)
            Me.dockPanel1.Size = New System.Drawing.Size(905, 121)
            Me.dockPanel1.Text = "Collection"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Controls.Add(Me.galleryControl1)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 27)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(899, 91)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel2.ID = New System.Guid("4cef1247-ed86-4f03-b4f4-38a36c8cf705")
            Me.dockPanel2.Location = New System.Drawing.Point(2, 2)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.Options.ShowCloseButton = False
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(295, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(295, 479)
            Me.dockPanel2.Text = "Filter params"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(288, 450)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureEdit1.Location = New System.Drawing.Point(297, 2)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.AllowFocused = False
            Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pictureEdit1.Properties.Padding = New System.Windows.Forms.Padding(12)
            Me.pictureEdit1.Properties.ShowScrollBars = True
            Me.pictureEdit1.Size = New System.Drawing.Size(610, 479)
            Me.pictureEdit1.TabIndex = 1
            AddHandler Me.pictureEdit1.LoadCompleted, New System.EventHandler(AddressOf Me.pictureEdit1_LoadCompleted)
            ' 
            ' ImageCollectionViewer
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pictureEdit1)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.dockPanel1)
            Me.Name = "ImageCollectionViewer"
            Me.Padding = New System.Windows.Forms.Padding(2)
            Me.Size = New System.Drawing.Size(909, 604)
            CType((Me.galleryControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.galleryControl1.ResumeLayout(False)
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl

        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    End Class
End Namespace
