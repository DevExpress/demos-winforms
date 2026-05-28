Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class HelpControl
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HelpControl))
            Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            Me.backstageViewLabel1 = New DevExpress.MailClient.Win.Controls.BackstageViewLabel()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            DirectCast(Me.galleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.galleryControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' splitContainer1
            ' 
            Me.splitContainer1.BackColor = System.Drawing.Color.Transparent
            resources.ApplyResources(Me.splitContainer1, "splitContainer1")
            Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
            Me.splitContainer1.Name = "splitContainer1"
            ' 
            ' splitContainer1.Panel1
            ' 
            Me.splitContainer1.Panel1.Controls.Add(Me.galleryControl1)
            Me.splitContainer1.Panel1.Controls.Add(Me.backstageViewLabel1)
            resources.ApplyResources(Me.splitContainer1.Panel1, "splitContainer1.Panel1")
            ' 
            ' splitContainer1.Panel2
            ' 
            Me.splitContainer1.Panel2.Controls.Add(Me.labelControl4)
            ' 
            ' galleryControl1
            ' 
            Me.galleryControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
            Me.galleryControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.galleryControl1.DesignGalleryGroupIndex = 0
            Me.galleryControl1.DesignGalleryItemIndex = 0
            resources.ApplyResources(Me.galleryControl1, "galleryControl1")
            ' 
            ' 
            ' 
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
            Me.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.galleryControl1.Gallery.AutoFitColumns = False
            Me.galleryControl1.Gallery.BackColor = System.Drawing.Color.Transparent
            Me.galleryControl1.Gallery.ColumnCount = 1
            Me.galleryControl1.Gallery.DistanceItemImageToText = 20
            Me.galleryControl1.Gallery.DrawImageBackground = False
            Me.galleryControl1.Gallery.FixedImageSize = False
            resources.ApplyResources(galleryItemGroup1, "galleryItemGroup1")
            resources.ApplyResources(galleryItem1, "galleryItem1")
            galleryItem1.ImageOptions.Image = My.Resources.Online_Help
            galleryItem1.Tag = "LinkHelp"
            resources.ApplyResources(galleryItem2, "galleryItem2")
            galleryItem2.ImageOptions.Image = My.Resources.Code_Central
            galleryItem2.Tag = "LinkGetStarted"
            resources.ApplyResources(galleryItem3, "galleryItem3")
            galleryItem3.ImageOptions.Image = My.Resources.Contact_Us
            galleryItem3.Tag = "LinkGetSupport"
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3})
            Me.galleryControl1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
            Me.galleryControl1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.galleryControl1.Gallery.ShowGroupCaption = False
            Me.galleryControl1.Gallery.ShowItemText = True
            Me.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
            Me.galleryControl1.Name = "galleryControl1"
            ' 
            ' galleryControlClient1
            ' 
            Me.galleryControlClient1.GalleryControl = Me.galleryControl1
            resources.ApplyResources(Me.galleryControlClient1, "galleryControlClient1")
            ' 
            ' backstageViewLabel1
            ' 
            Me.backstageViewLabel1.Appearance.Font = (DirectCast(resources.GetObject("backstageViewLabel1.Appearance.Font"), System.Drawing.Font))
            Me.backstageViewLabel1.Appearance.Options.UseFont = True
            resources.ApplyResources(Me.backstageViewLabel1, "backstageViewLabel1")
            Me.backstageViewLabel1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.backstageViewLabel1.LineVisible = True
            Me.backstageViewLabel1.Name = "backstageViewLabel1"
            Me.backstageViewLabel1.ShowLineShadow = False
            ' 
            ' labelControl4
            ' 
            resources.ApplyResources(Me.labelControl4, "labelControl4")
            Me.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical
            Me.labelControl4.LineVisible = True
            Me.labelControl4.Name = "labelControl4"
            ' 
            ' HelpControl
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainer1)
            Me.Name = "HelpControl"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            DirectCast(Me.galleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.galleryControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private splitContainer1 As System.Windows.Forms.SplitContainer
        Private backstageViewLabel1 As BackstageViewLabel
        Private WithEvents galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl
        Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
        Private labelControl4 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
