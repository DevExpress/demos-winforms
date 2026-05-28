Namespace DevExpress.RealtorWorld.Win

    Partial Class ucHomeDetail

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
            Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
            Me.lcFeatures = New DevExpress.XtraEditors.LabelControl()
            Me.peAgent = New DevExpress.XtraEditors.PictureEdit()
            Me.lcAgent = New DevExpress.XtraEditors.LabelControl()
            Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciHome = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.imageSlider = New DevExpress.XtraEditors.Controls.ImageSlider()
            Me.pnlData = New DevExpress.XtraEditors.PanelControl()
            Me.pnlLayout = New DevExpress.XtraEditors.PanelControl()
            Me.pnlSeparator = New DevExpress.XtraEditors.PanelControl()
            Me.peLayout = New DevExpress.XtraEditors.PictureEdit()
            CType((Me.lcMain), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcMain.SuspendLayout()
            CType((Me.peAgent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgMain), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciHome), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageSlider), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pnlData), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlData.SuspendLayout()
            CType((Me.pnlLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlLayout.SuspendLayout()
            CType((Me.pnlSeparator), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.peLayout.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lcMain
            ' 
            Me.lcMain.AllowCustomization = False
            Me.lcMain.Controls.Add(Me.lcFeatures)
            Me.lcMain.Controls.Add(Me.peAgent)
            Me.lcMain.Controls.Add(Me.lcAgent)
            Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcMain.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lcMain.Location = New System.Drawing.Point(2, 2)
            Me.lcMain.Name = "lcMain"
            Me.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(671, 353, 450, 350)
            Me.lcMain.Root = Me.lcgMain
            Me.lcMain.Size = New System.Drawing.Size(606, 404)
            Me.lcMain.TabIndex = 0
            Me.lcMain.Text = "layoutControl1"
            ' 
            ' lcFeatures
            ' 
            Me.lcFeatures.AllowHtmlString = True
            Me.lcFeatures.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.lcFeatures.Location = New System.Drawing.Point(4, 4)
            Me.lcFeatures.Name = "lcFeatures"
            Me.lcFeatures.Size = New System.Drawing.Size(598, 1)
            Me.lcFeatures.StyleController = Me.lcMain
            Me.lcFeatures.TabIndex = 17
            ' 
            ' peAgent
            ' 
            Me.peAgent.Cursor = System.Windows.Forms.Cursors.Hand
            Me.peAgent.Location = New System.Drawing.Point(395, 11)
            Me.peAgent.Name = "peAgent"
            Me.peAgent.Properties.AllowFocused = False
            Me.peAgent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.peAgent.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.peAgent.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.peAgent.Properties.ShowMenu = False
            Me.peAgent.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.peAgent.Size = New System.Drawing.Size(209, 196)
            Me.peAgent.StyleController = Me.lcMain
            Me.peAgent.TabIndex = 18
            AddHandler Me.peAgent.DoubleClick, New System.EventHandler(AddressOf Me.peAgent_DoubleClick)
            ' 
            ' lcAgent
            ' 
            Me.lcAgent.AllowHtmlString = True
            Me.lcAgent.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.lcAgent.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.lcAgent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lcAgent.Location = New System.Drawing.Point(2, 11)
            Me.lcAgent.Name = "lcAgent"
            Me.lcAgent.Size = New System.Drawing.Size(389, 391)
            Me.lcAgent.StyleController = Me.lcMain
            Me.lcAgent.TabIndex = 19
            AddHandler Me.lcAgent.DoubleClick, New System.EventHandler(AddressOf Me.peAgent_DoubleClick)
            ' 
            ' lcgMain
            ' 
            Me.lcgMain.CustomizationFormText = "layoutControlGroup1"
            Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.lcgMain.GroupBordersVisible = False
            Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciHome, Me.layoutControlItem3, Me.layoutControlItem1})
            Me.lcgMain.Location = New System.Drawing.Point(0, 0)
            Me.lcgMain.Name = "lcgMain"
            Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgMain.Size = New System.Drawing.Size(606, 404)
            Me.lcgMain.Text = "lcgMain"
            Me.lcgMain.TextVisible = False
            ' 
            ' lciHome
            ' 
            Me.lciHome.Control = Me.lcFeatures
            Me.lciHome.CustomizationFormText = "layoutControlItem2"
            Me.lciHome.Location = New System.Drawing.Point(0, 0)
            Me.lciHome.Name = "lciHome"
            Me.lciHome.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.lciHome.Size = New System.Drawing.Size(606, 9)
            Me.lciHome.Text = "Features:"
            Me.lciHome.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciHome.TextSize = New System.Drawing.Size(0, 0)
            Me.lciHome.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.lcAgent
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 9)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(4, 4)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(393, 395)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.peAgent
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(393, 9)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(213, 200)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(213, 200)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(213, 395)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' imageSlider
            ' 
            Me.imageSlider.CurrentImageIndex = -1
            Me.imageSlider.Dock = System.Windows.Forms.DockStyle.Top
            Me.imageSlider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
            Me.imageSlider.Location = New System.Drawing.Point(0, 0)
            Me.imageSlider.Name = "imageSlider"
            Me.imageSlider.Size = New System.Drawing.Size(610, 400)
            Me.imageSlider.TabIndex = 16
            Me.imageSlider.UseDisabledStatePainter = True
            ' 
            ' pnlData
            ' 
            Me.pnlData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlData.Controls.Add(Me.pnlLayout)
            Me.pnlData.Controls.Add(Me.pnlSeparator)
            Me.pnlData.Controls.Add(Me.imageSlider)
            Me.pnlData.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlData.Location = New System.Drawing.Point(10, 0)
            Me.pnlData.Name = "pnlData"
            Me.pnlData.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.pnlData.Size = New System.Drawing.Size(620, 818)
            Me.pnlData.TabIndex = 19
            ' 
            ' pnlLayout
            ' 
            Me.pnlLayout.Controls.Add(Me.lcMain)
            Me.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlLayout.Location = New System.Drawing.Point(0, 410)
            Me.pnlLayout.Name = "pnlLayout"
            Me.pnlLayout.Size = New System.Drawing.Size(610, 408)
            Me.pnlLayout.TabIndex = 18
            ' 
            ' pnlSeparator
            ' 
            Me.pnlSeparator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSeparator.Location = New System.Drawing.Point(0, 400)
            Me.pnlSeparator.Name = "pnlSeparator"
            Me.pnlSeparator.Size = New System.Drawing.Size(610, 10)
            Me.pnlSeparator.TabIndex = 17
            ' 
            ' peLayout
            ' 
            Me.peLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.peLayout.Location = New System.Drawing.Point(630, 0)
            Me.peLayout.Name = "peLayout"
            Me.peLayout.Properties.AllowFocused = False
            Me.peLayout.Properties.EnableLODImages = True
            Me.peLayout.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.[True]
            Me.peLayout.Properties.ShowMenu = False
            Me.peLayout.Properties.ShowScrollBars = True
            Me.peLayout.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel
            Me.peLayout.Size = New System.Drawing.Size(387, 818)
            Me.peLayout.TabIndex = 18
            AddHandler Me.peLayout.DoubleClick, New System.EventHandler(AddressOf Me.peLayout_DoubleClick)
            ' 
            ' ucHomeDetail
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.peLayout)
            Me.Controls.Add(Me.pnlData)
            Me.Name = "ucHomeDetail"
            Me.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.Size = New System.Drawing.Size(1017, 818)
            AddHandler Me.VisibleChanged, New System.EventHandler(AddressOf Me.ucHomeDetail_VisibleChanged)
            CType((Me.lcMain), System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcMain.ResumeLayout(False)
            CType((Me.peAgent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgMain), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciHome), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageSlider), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pnlData), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlData.ResumeLayout(False)
            CType((Me.pnlLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlLayout.ResumeLayout(False)
            CType((Me.pnlSeparator), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.peLayout.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private lcMain As DevExpress.XtraLayout.LayoutControl

        Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup

        Private imageSlider As DevExpress.XtraEditors.Controls.ImageSlider

        Private lcFeatures As DevExpress.XtraEditors.LabelControl

        Private lciHome As DevExpress.XtraLayout.LayoutControlItem

        Private peLayout As DevExpress.XtraEditors.PictureEdit

        Private pnlData As DevExpress.XtraEditors.PanelControl

        Private pnlSeparator As DevExpress.XtraEditors.PanelControl

        Private lcAgent As DevExpress.XtraEditors.LabelControl

        Private peAgent As DevExpress.XtraEditors.PictureEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private pnlLayout As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
