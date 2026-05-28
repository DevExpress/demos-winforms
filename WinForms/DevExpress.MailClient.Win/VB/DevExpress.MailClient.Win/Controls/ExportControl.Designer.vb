Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class ExportControl
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ExportControl))
            Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem4 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem5 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem6 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem7 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem8 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem9 As New DevExpress.XtraBars.Ribbon.GalleryItem()
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.exportGallery = New DevExpress.XtraBars.Ribbon.GalleryControl()
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            Me.backstageViewLabel1 = New DevExpress.MailClient.Win.Controls.BackstageViewLabel()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            DirectCast(Me.exportGallery, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.exportGallery.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' splitContainer1
            ' 
            resources.ApplyResources(Me.splitContainer1, "splitContainer1")
            Me.splitContainer1.BackColor = System.Drawing.Color.Transparent
            Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
            Me.splitContainer1.Name = "splitContainer1"
            ' 
            ' splitContainer1.Panel1
            ' 
            resources.ApplyResources(Me.splitContainer1.Panel1, "splitContainer1.Panel1")
            Me.splitContainer1.Panel1.Controls.Add(Me.exportGallery)
            Me.splitContainer1.Panel1.Controls.Add(Me.backstageViewLabel1)
            ' 
            ' splitContainer1.Panel2
            ' 
            resources.ApplyResources(Me.splitContainer1.Panel2, "splitContainer1.Panel2")
            Me.splitContainer1.Panel2.Controls.Add(Me.labelControl4)
            ' 
            ' exportGallery
            ' 
            resources.ApplyResources(Me.exportGallery, "exportGallery")
            Me.exportGallery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.exportGallery.Controls.Add(Me.galleryControlClient1)
            Me.exportGallery.DesignGalleryGroupIndex = 0
            Me.exportGallery.DesignGalleryItemIndex = 0
            ' 
            ' 
            ' 
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontSizeDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontSizeDelta"), Integer))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontStyleDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.FontStyleDelta"), System.Drawing.FontStyle))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.GradientMode = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.Image = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.Image"), System.Drawing.Image))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.FontSizeDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.FontSizeDelta"), Integer))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.FontStyleDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.FontStyleDelta"), System.Drawing.FontStyle))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.GradientMode = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.Image = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.Image"), System.Drawing.Image))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontSizeDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontSizeDelta"), Integer))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontStyleDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.FontStyleDelta"), System.Drawing.FontStyle))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.GradientMode = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.Image = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.Image"), System.Drawing.Image))
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.FontSizeDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.FontSizeDelta"), Integer))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.FontStyleDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.FontStyleDelta" & ""), System.Drawing.FontStyle))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.GradientMode = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Image = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Image"), System.Drawing.Image))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.FontSizeDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.FontSizeDelta"), Integer))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.FontStyleDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.FontStyleDelta"), System.Drawing.FontStyle))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.GradientMode = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.Image = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.Image"), System.Drawing.Image))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.FontSizeDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.FontSizeDelta"), Integer))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.FontStyleDelta = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.FontStyleDelta" & ""), System.Drawing.FontStyle))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.GradientMode = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Image = (DirectCast(resources.GetObject("exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Image"), System.Drawing.Image))
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
            Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.exportGallery.Gallery.AutoFitColumns = False
            Me.exportGallery.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.None
            Me.exportGallery.Gallery.BackColor = System.Drawing.Color.Transparent
            Me.exportGallery.Gallery.CheckDrawMode = DevExpress.XtraBars.Ribbon.Gallery.CheckDrawMode.OnlyImage
            Me.exportGallery.Gallery.ColumnCount = 1
            Me.exportGallery.Gallery.FixedImageSize = False
            resources.ApplyResources(galleryItemGroup1, "galleryItemGroup1")
            resources.ApplyResources(galleryItem1, "galleryItem1")
            galleryItem1.Image = My.Resources.ExportToPDF_32x32
            galleryItem1.Tag = "PDF"
            resources.ApplyResources(galleryItem2, "galleryItem2")
            galleryItem2.Image = My.Resources.ExportToHTML_32x32
            galleryItem2.Tag = "HTML"
            resources.ApplyResources(galleryItem3, "galleryItem3")
            galleryItem3.Image = My.Resources.ExportToMHT_32x32
            galleryItem3.Tag = "MHT"
            resources.ApplyResources(galleryItem4, "galleryItem4")
            galleryItem4.Image = My.Resources.ExportToRTF_32x32
            galleryItem4.Tag = "RTF"
            resources.ApplyResources(galleryItem5, "galleryItem5")
            galleryItem5.Image = My.Resources.ExportToXLS_32x32
            galleryItem5.Tag = "XLS"
            resources.ApplyResources(galleryItem6, "galleryItem6")
            galleryItem6.Image = My.Resources.ExportToXLSX_32x32
            galleryItem6.Tag = "XLSX"
            resources.ApplyResources(galleryItem7, "galleryItem7")
            galleryItem7.Image = My.Resources.ExportToCSV_32x32
            galleryItem7.Tag = "CSV"
            resources.ApplyResources(galleryItem8, "galleryItem8")
            galleryItem8.Image = My.Resources.ExportToText_32x32
            galleryItem8.Tag = "Text"
            resources.ApplyResources(galleryItem9, "galleryItem9")
            galleryItem9.Image = My.Resources.ExportToImage_32x32
            galleryItem9.Tag = "Image"
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6, galleryItem7, galleryItem8, galleryItem9})
            Me.exportGallery.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
            Me.exportGallery.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.exportGallery.Gallery.ShowGroupCaption = False
            Me.exportGallery.Gallery.ShowItemText = True
            Me.exportGallery.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.exportGallery.Gallery.StretchItems = True
            Me.exportGallery.Name = "exportGallery"
            ' 
            ' galleryControlClient1
            ' 
            resources.ApplyResources(Me.galleryControlClient1, "galleryControlClient1")
            Me.galleryControlClient1.GalleryControl = Me.exportGallery
            ' 
            ' backstageViewLabel1
            ' 
            resources.ApplyResources(Me.backstageViewLabel1, "backstageViewLabel1")
            Me.backstageViewLabel1.AppearanceDisabled.Image = (DirectCast(resources.GetObject("backstageViewLabel1.Appearance.DisabledImage"), System.Drawing.Image))
            Me.backstageViewLabel1.Appearance.Font = (DirectCast(resources.GetObject("backstageViewLabel1.Appearance.Font"), System.Drawing.Font))
            Me.backstageViewLabel1.Appearance.FontSizeDelta = (DirectCast(resources.GetObject("backstageViewLabel1.Appearance.FontSizeDelta"), Integer))
            Me.backstageViewLabel1.Appearance.FontStyleDelta = (DirectCast(resources.GetObject("backstageViewLabel1.Appearance.FontStyleDelta"), System.Drawing.FontStyle))
            Me.backstageViewLabel1.Appearance.GradientMode = (DirectCast(resources.GetObject("backstageViewLabel1.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.backstageViewLabel1.AppearanceHovered.Image = (DirectCast(resources.GetObject("backstageViewLabel1.Appearance.HoverImage"), System.Drawing.Image))
            Me.backstageViewLabel1.Appearance.Image = (DirectCast(resources.GetObject("backstageViewLabel1.Appearance.Image"), System.Drawing.Image))
            Me.backstageViewLabel1.AppearancePressed.Image = (DirectCast(resources.GetObject("backstageViewLabel1.Appearance.PressedImage"), System.Drawing.Image))
            Me.backstageViewLabel1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            Me.backstageViewLabel1.LineVisible = True
            Me.backstageViewLabel1.LookAndFeel.UseDefaultLookAndFeel = False
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
            ' saveFileDialog1
            ' 
            resources.ApplyResources(Me.saveFileDialog1, "saveFileDialog1")
            ' 
            ' ExportControl
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainer1)
            Me.Name = "ExportControl"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            DirectCast(Me.exportGallery, System.ComponentModel.ISupportInitialize).EndInit()
            Me.exportGallery.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private splitContainer1 As System.Windows.Forms.SplitContainer
        Private backstageViewLabel1 As BackstageViewLabel
        Private WithEvents exportGallery As DevExpress.XtraBars.Ribbon.GalleryControl
        Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
        Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Private labelControl4 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
