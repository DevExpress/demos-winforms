Namespace DevExpress.ApplicationUI.Demos

    Partial Class AlertInfoProperties

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.AlertInfoProperties))
            Me.icbImage = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.txtHotTrackedText = New DevExpress.XtraEditors.MemoEdit()
            Me.txtText = New DevExpress.XtraEditors.MemoEdit()
            Me.txtCaption = New DevExpress.XtraEditors.TextEdit()
            Me.ceShowAnimatedImage = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.txtHotTrackedTextitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.txtTextitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.txtCaptionitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.icbImageitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceShowAnimatedImageitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
            CType((Me.icbImage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.AlertInfoPropertieslayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.txtHotTrackedText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.txtText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.txtCaption.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowAnimatedImage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.txtHotTrackedTextitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.txtTextitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.txtCaptionitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbImageitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowAnimatedImageitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' icbImage
            ' 
            Me.icbImage.EditValue = 0
            Me.icbImage.Location = New System.Drawing.Point(109, 10)
            Me.icbImage.Name = "icbImage"
            Me.icbImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbImage.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Scheduler", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Note", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Address", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Department", 3, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Products", 4, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("<None>", 5, -1)})
            Me.icbImage.Properties.LargeImages = Me.svgImageCollection1
            Me.icbImage.ShowToolTips = False
            Me.icbImage.Size = New System.Drawing.Size(199, 20)
            Me.icbImage.StyleController = Me.AlertInfoPropertieslayoutControl1ConvertedLayout
            Me.icbImage.TabIndex = 0
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Scheduler", CType((resources.GetObject("svgImageCollection1.Scheduler")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("InsertListBox", CType((resources.GetObject("svgImageCollection1.InsertListBox")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Home", CType((resources.GetObject("svgImageCollection1.Home")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("BO_Department", CType((resources.GetObject("svgImageCollection1.BO_Department")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Products", CType((resources.GetObject("svgImageCollection1.Products")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' AlertInfoPropertieslayoutControl1ConvertedLayout
            ' 
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.txtHotTrackedText)
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.txtText)
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.txtCaption)
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.icbImage)
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.Controls.Add(Me.ceShowAnimatedImage)
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.Name = "AlertInfoPropertieslayoutControl1ConvertedLayout"
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.Size = New System.Drawing.Size(318, 475)
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.TabIndex = 15
            ' 
            ' txtHotTrackedText
            ' 
            Me.txtHotTrackedText.Location = New System.Drawing.Point(109, 275)
            Me.txtHotTrackedText.Name = "txtHotTrackedText"
            Me.txtHotTrackedText.Size = New System.Drawing.Size(199, 167)
            Me.txtHotTrackedText.StyleController = Me.AlertInfoPropertieslayoutControl1ConvertedLayout
            Me.txtHotTrackedText.TabIndex = 4
            AddHandler Me.txtHotTrackedText.EditValueChanged, New System.EventHandler(AddressOf Me.txtSelectedText_EditValueChanged)
            ' 
            ' txtText
            ' 
            Me.txtText.Location = New System.Drawing.Point(109, 94)
            Me.txtText.Name = "txtText"
            Me.txtText.Size = New System.Drawing.Size(199, 171)
            Me.txtText.StyleController = Me.AlertInfoPropertieslayoutControl1ConvertedLayout
            Me.txtText.TabIndex = 3
            AddHandler Me.txtText.EditValueChanged, New System.EventHandler(AddressOf Me.txtText_EditValueChanged)
            ' 
            ' txtCaption
            ' 
            Me.txtCaption.Location = New System.Drawing.Point(109, 64)
            Me.txtCaption.Name = "txtCaption"
            Me.txtCaption.Size = New System.Drawing.Size(199, 20)
            Me.txtCaption.StyleController = Me.AlertInfoPropertieslayoutControl1ConvertedLayout
            Me.txtCaption.TabIndex = 2
            AddHandler Me.txtCaption.EditValueChanged, New System.EventHandler(AddressOf Me.txtCaption_EditValueChanged)
            ' 
            ' ceShowAnimatedImage
            ' 
            Me.ceShowAnimatedImage.Location = New System.Drawing.Point(109, 37)
            Me.ceShowAnimatedImage.Name = "ceShowAnimatedImage"
            Me.ceShowAnimatedImage.Properties.Caption = "Show Animated Image"
            Me.ceShowAnimatedImage.Size = New System.Drawing.Size(197, 20)
            Me.ceShowAnimatedImage.StyleController = Me.AlertInfoPropertieslayoutControl1ConvertedLayout
            Me.ceShowAnimatedImage.TabIndex = 1
            AddHandler Me.ceShowAnimatedImage.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowAnimatedImage_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.txtHotTrackedTextitem, Me.txtTextitem, Me.txtCaptionitem, Me.icbImageitem, Me.ceShowAnimatedImageitem, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(318, 475)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' txtHotTrackedTextitem
            ' 
            Me.txtHotTrackedTextitem.AppearanceItemCaption.Options.UseTextOptions = True
            Me.txtHotTrackedTextitem.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.txtHotTrackedTextitem.Control = Me.txtHotTrackedText
            Me.txtHotTrackedTextitem.Location = New System.Drawing.Point(0, 260)
            Me.txtHotTrackedTextitem.Name = "txtHotTrackedTextitem"
            Me.txtHotTrackedTextitem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0)
            Me.txtHotTrackedTextitem.Size = New System.Drawing.Size(298, 172)
            Me.txtHotTrackedTextitem.Text = "Hot Tracked Text:"
            Me.txtHotTrackedTextitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.txtHotTrackedTextitem.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' txtTextitem
            ' 
            Me.txtTextitem.AppearanceItemCaption.Options.UseTextOptions = True
            Me.txtTextitem.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.txtTextitem.Control = Me.txtText
            Me.txtTextitem.Location = New System.Drawing.Point(0, 79)
            Me.txtTextitem.Name = "txtTextitem"
            Me.txtTextitem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5)
            Me.txtTextitem.Size = New System.Drawing.Size(298, 181)
            Me.txtTextitem.Text = "Text:"
            Me.txtTextitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.txtTextitem.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' txtCaptionitem
            ' 
            Me.txtCaptionitem.Control = Me.txtCaption
            Me.txtCaptionitem.Location = New System.Drawing.Point(0, 49)
            Me.txtCaptionitem.Name = "txtCaptionitem"
            Me.txtCaptionitem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5)
            Me.txtCaptionitem.Size = New System.Drawing.Size(298, 30)
            Me.txtCaptionitem.Text = "Caption:"
            Me.txtCaptionitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.txtCaptionitem.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' icbImageitem
            ' 
            Me.icbImageitem.Control = Me.icbImage
            Me.icbImageitem.Location = New System.Drawing.Point(0, 0)
            Me.icbImageitem.Name = "icbImageitem"
            Me.icbImageitem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5)
            Me.icbImageitem.Size = New System.Drawing.Size(298, 25)
            Me.icbImageitem.Text = "Image:"
            Me.icbImageitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.icbImageitem.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' ceShowAnimatedImageitem
            ' 
            Me.ceShowAnimatedImageitem.Control = Me.ceShowAnimatedImage
            Me.ceShowAnimatedImageitem.Location = New System.Drawing.Point(0, 25)
            Me.ceShowAnimatedImageitem.Name = "ceShowAnimatedImageitem"
            Me.ceShowAnimatedImageitem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 2, 2)
            Me.ceShowAnimatedImageitem.Size = New System.Drawing.Size(298, 24)
            Me.ceShowAnimatedImageitem.Text = " "
            Me.ceShowAnimatedImageitem.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 432)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(298, 23)
            ' 
            ' AlertInfoProperties
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.AlertInfoPropertieslayoutControl1ConvertedLayout)
            Me.Name = "AlertInfoProperties"
            Me.Size = New System.Drawing.Size(318, 475)
            CType((Me.icbImage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.AlertInfoPropertieslayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.AlertInfoPropertieslayoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.txtHotTrackedText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.txtText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.txtCaption.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowAnimatedImage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.txtHotTrackedTextitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.txtTextitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.txtCaptionitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbImageitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowAnimatedImageitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private icbImage As DevExpress.XtraEditors.ImageComboBoxEdit

        Private txtCaption As DevExpress.XtraEditors.TextEdit

        Private txtText As DevExpress.XtraEditors.MemoEdit

        Private txtHotTrackedText As DevExpress.XtraEditors.MemoEdit

        Private ceShowAnimatedImage As DevExpress.XtraEditors.CheckEdit

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection

        Private AlertInfoPropertieslayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private txtHotTrackedTextitem As DevExpress.XtraLayout.LayoutControlItem

        Private txtTextitem As DevExpress.XtraLayout.LayoutControlItem

        Private txtCaptionitem As DevExpress.XtraLayout.LayoutControlItem

        Private icbImageitem As DevExpress.XtraLayout.LayoutControlItem

        Private ceShowAnimatedImageitem As DevExpress.XtraLayout.LayoutControlItem

        Private layoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
