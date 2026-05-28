Namespace DevExpress.ProductsDemo.Win.Controls
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
			Me.backstageViewLabel1 = New DevExpress.ProductsDemo.Win.BackstageViewLabel()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			CType(Me.exportGallery, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.exportGallery.SuspendLayout()
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
			Me.splitContainer1.Panel1.Controls.Add(Me.exportGallery)
			Me.splitContainer1.Panel1.Controls.Add(Me.backstageViewLabel1)
			resources.ApplyResources(Me.splitContainer1.Panel1, "splitContainer1.Panel1")
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.labelControl4)
			' 
			' exportGallery
			' 
			Me.exportGallery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.exportGallery.Controls.Add(Me.galleryControlClient1)
			resources.ApplyResources(Me.exportGallery, "exportGallery")
			' 
			' 
			' 
			Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.exportGallery.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
			Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
			Me.exportGallery.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
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
			galleryItem1.ImageOptions.SvgImage = My.Resources.Action_Export_ToPDF
			galleryItem1.Tag = "PDF"
			resources.ApplyResources(galleryItem2, "galleryItem2")
			galleryItem2.ImageOptions.SvgImage = My.Resources.Action_Export_ToHTML
			galleryItem2.Tag = "HTML"
			resources.ApplyResources(galleryItem3, "galleryItem3")
			galleryItem3.ImageOptions.SvgImage = My.Resources.Action_Export_ToMHT
			galleryItem3.Tag = "MHT"
			resources.ApplyResources(galleryItem4, "galleryItem4")
			galleryItem4.ImageOptions.SvgImage = My.Resources.Action_Export_ToRTF
			galleryItem4.Tag = "RTF"
			resources.ApplyResources(galleryItem5, "galleryItem5")
			galleryItem5.ImageOptions.SvgImage = My.Resources.Action_Export_ToXls
			galleryItem5.Tag = "XLS"
			resources.ApplyResources(galleryItem6, "galleryItem6")
			galleryItem6.ImageOptions.SvgImage = My.Resources.Action_Export_ToXLSX
			galleryItem6.Tag = "XLSX"
			resources.ApplyResources(galleryItem7, "galleryItem7")
			galleryItem7.ImageOptions.SvgImage = My.Resources.Action_Export_ToCSV
			galleryItem7.Tag = "CSV"
			resources.ApplyResources(galleryItem8, "galleryItem8")
			galleryItem8.ImageOptions.SvgImage = My.Resources.Action_Export_ToText
			galleryItem8.Tag = "Text"
			resources.ApplyResources(galleryItem9, "galleryItem9")
			galleryItem9.ImageOptions.SvgImage = My.Resources.Action_Export_ToImage
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
            Me.galleryControlClient1.GalleryControl = Me.exportGallery
			resources.ApplyResources(Me.galleryControlClient1, "galleryControlClient1")
			' 
			' backstageViewLabel1
			' 
			Me.backstageViewLabel1.Appearance.Font = (CType(resources.GetObject("backstageViewLabel1.Appearance.Font"), System.Drawing.Font))
			Me.backstageViewLabel1.Appearance.Options.UseFont = True
			resources.ApplyResources(Me.backstageViewLabel1, "backstageViewLabel1")
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
			CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.ResumeLayout(False)
			CType(Me.exportGallery, System.ComponentModel.ISupportInitialize).EndInit()
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
