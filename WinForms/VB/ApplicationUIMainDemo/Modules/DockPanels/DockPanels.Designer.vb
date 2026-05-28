Namespace DevExpress.ApplicationUI.Demos

    Partial Class DockPanels

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.DockPanels))
            Dim superToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim superToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim superToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim superToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim superToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim superToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim superToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim superToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim superToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim superToolTip10 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim superToolTip11 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem11 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Me.containerImageCollection = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.dockImageCollection = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.toolbarPanel = New DevExpress.XtraEditors.SidePanel()
            Me.buttonsLabel = New DevExpress.XtraEditors.LabelControl()
            Me.sbAddPanel = New DevExpress.XtraEditors.SimpleButton()
            Me.sbAddPanel1 = New DevExpress.XtraEditors.SimpleButton()
            Me.sbAddPanel2 = New DevExpress.XtraEditors.SimpleButton()
            Me.cbLayoutType4 = New DevExpress.XtraEditors.CheckButton()
            Me.cbLayoutType3 = New DevExpress.XtraEditors.CheckButton()
            Me.cbLayoutType2 = New DevExpress.XtraEditors.CheckButton()
            Me.cbLayoutType1 = New DevExpress.XtraEditors.CheckButton()
            Me.cbLayoutType = New DevExpress.XtraEditors.CheckButton()
            Me.sbAddPanel5 = New DevExpress.XtraEditors.SimpleButton()
            Me.sbAddPanel3 = New DevExpress.XtraEditors.SimpleButton()
            Me.sbAddPanel4 = New DevExpress.XtraEditors.SimpleButton()
            Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
            Me.contentPanel = New DevExpress.XtraEditors.PanelControl()
            Me.layoutLabel = New DevExpress.XtraEditors.LabelControl()
            CType((Me.containerImageCollection), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockImageCollection), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.toolbarPanel.SuspendLayout()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainPanel.SuspendLayout()
            CType((Me.contentPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' containerImageCollection
            ' 
            Me.containerImageCollection.Add("SimpleDockPanel", CType((resources.GetObject("containerImageCollection.SimpleDockPanel")), DevExpress.Utils.Svg.SvgImage))
            Me.containerImageCollection.Add("CenterPanel", CType((resources.GetObject("containerImageCollection.CenterPanel")), DevExpress.Utils.Svg.SvgImage))
            Me.containerImageCollection.Add("TabContainer", CType((resources.GetObject("containerImageCollection.TabContainer")), DevExpress.Utils.Svg.SvgImage))
            Me.containerImageCollection.Add("HorizontalContainer", CType((resources.GetObject("containerImageCollection.HorizontalContainer")), DevExpress.Utils.Svg.SvgImage))
            Me.containerImageCollection.Add("VerticalContainer", CType((resources.GetObject("containerImageCollection.VerticalContainer")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' dockImageCollection
            ' 
            Me.dockImageCollection.Add("Left", CType((resources.GetObject("dockImageCollection.Left")), DevExpress.Utils.Svg.SvgImage))
            Me.dockImageCollection.Add("Top", CType((resources.GetObject("dockImageCollection.Top")), DevExpress.Utils.Svg.SvgImage))
            Me.dockImageCollection.Add("Center", CType((resources.GetObject("dockImageCollection.Center")), DevExpress.Utils.Svg.SvgImage))
            Me.dockImageCollection.Add("Float", CType((resources.GetObject("dockImageCollection.Float")), DevExpress.Utils.Svg.SvgImage))
            Me.dockImageCollection.Add("Bottom", CType((resources.GetObject("dockImageCollection.Bottom")), DevExpress.Utils.Svg.SvgImage))
            Me.dockImageCollection.Add("Right", CType((resources.GetObject("dockImageCollection.Right")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' toolbarPanel
            ' 
            Me.toolbarPanel.AllowResize = False
            Me.toolbarPanel.Controls.Add(Me.buttonsLabel)
            Me.toolbarPanel.Controls.Add(Me.sbAddPanel)
            Me.toolbarPanel.Controls.Add(Me.sbAddPanel1)
            Me.toolbarPanel.Controls.Add(Me.sbAddPanel2)
            Me.toolbarPanel.Controls.Add(Me.cbLayoutType4)
            Me.toolbarPanel.Controls.Add(Me.cbLayoutType3)
            Me.toolbarPanel.Controls.Add(Me.cbLayoutType2)
            Me.toolbarPanel.Controls.Add(Me.cbLayoutType1)
            Me.toolbarPanel.Controls.Add(Me.cbLayoutType)
            Me.toolbarPanel.Controls.Add(Me.sbAddPanel5)
            Me.toolbarPanel.Controls.Add(Me.sbAddPanel3)
            Me.toolbarPanel.Controls.Add(Me.sbAddPanel4)
            Me.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.toolbarPanel.Location = New System.Drawing.Point(0, 0)
            Me.toolbarPanel.Name = "toolbarPanel"
            Me.toolbarPanel.Size = New System.Drawing.Size(656, 31)
            Me.toolbarPanel.TabIndex = 0
            ' 
            ' buttonsLabel
            ' 
            Me.buttonsLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.buttonsLabel.Dock = System.Windows.Forms.DockStyle.Right
            Me.buttonsLabel.Location = New System.Drawing.Point(407, 0)
            Me.buttonsLabel.Name = "buttonsLabel"
            Me.buttonsLabel.Size = New System.Drawing.Size(69, 30)
            Me.buttonsLabel.TabIndex = 10
            Me.buttonsLabel.Text = "Add Panel To"
            ' 
            ' sbAddPanel
            ' 
            Me.sbAddPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.sbAddPanel.ImageOptions.ImageIndex = 0
            Me.sbAddPanel.ImageOptions.ImageList = Me.dockImageCollection
            Me.sbAddPanel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.sbAddPanel.Location = New System.Drawing.Point(476, 0)
            Me.sbAddPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.sbAddPanel.Name = "sbAddPanel"
            Me.sbAddPanel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.sbAddPanel.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem1.Text = "Add Panel at Left"
            superToolTip1.Items.Add(toolTipTitleItem1)
            Me.sbAddPanel.SuperTip = superToolTip1
            Me.sbAddPanel.TabIndex = 9
            Me.sbAddPanel.Tag = DevExpress.XtraBars.Docking.DockingStyle.Left
            AddHandler Me.sbAddPanel.Click, New System.EventHandler(AddressOf Me.OnAddPanelButtonClick)
            ' 
            ' sbAddPanel1
            ' 
            Me.sbAddPanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sbAddPanel1.ImageOptions.ImageIndex = 1
            Me.sbAddPanel1.ImageOptions.ImageList = Me.dockImageCollection
            Me.sbAddPanel1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.sbAddPanel1.Location = New System.Drawing.Point(506, 0)
            Me.sbAddPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.sbAddPanel1.Name = "sbAddPanel1"
            Me.sbAddPanel1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.sbAddPanel1.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem2.Text = "Add Panel at Top"
            superToolTip2.Items.Add(toolTipTitleItem2)
            Me.sbAddPanel1.SuperTip = superToolTip2
            Me.sbAddPanel1.TabIndex = 8
            Me.sbAddPanel1.Tag = DevExpress.XtraBars.Docking.DockingStyle.Top
            AddHandler Me.sbAddPanel1.Click, New System.EventHandler(AddressOf Me.OnAddPanelButtonClick)
            ' 
            ' sbAddPanel2
            ' 
            Me.sbAddPanel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.sbAddPanel2.ImageOptions.ImageIndex = 2
            Me.sbAddPanel2.ImageOptions.ImageList = Me.dockImageCollection
            Me.sbAddPanel2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.sbAddPanel2.Location = New System.Drawing.Point(536, 0)
            Me.sbAddPanel2.Margin = New System.Windows.Forms.Padding(0)
            Me.sbAddPanel2.Name = "sbAddPanel2"
            Me.sbAddPanel2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.sbAddPanel2.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem3.Text = "Add Panel at Center"
            superToolTip3.Items.Add(toolTipTitleItem3)
            Me.sbAddPanel2.SuperTip = superToolTip3
            Me.sbAddPanel2.TabIndex = 7
            Me.sbAddPanel2.Tag = DevExpress.XtraBars.Docking.DockingStyle.Fill
            AddHandler Me.sbAddPanel2.Click, New System.EventHandler(AddressOf Me.OnAddPanelButtonClick)
            ' 
            ' cbLayoutType4
            ' 
            Me.cbLayoutType4.Dock = System.Windows.Forms.DockStyle.Left
            Me.cbLayoutType4.GroupIndex = 0
            Me.cbLayoutType4.ImageOptions.ImageIndex = 4
            Me.cbLayoutType4.ImageOptions.ImageList = Me.containerImageCollection
            Me.cbLayoutType4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.cbLayoutType4.Location = New System.Drawing.Point(120, 0)
            Me.cbLayoutType4.Margin = New System.Windows.Forms.Padding(0)
            Me.cbLayoutType4.Name = "cbLayoutType4"
            Me.cbLayoutType4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.cbLayoutType4.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.cbLayoutType4.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem4.Text = "Vertical Container"
            superToolTip4.Items.Add(toolTipTitleItem4)
            Me.cbLayoutType4.SuperTip = superToolTip4
            Me.cbLayoutType4.TabIndex = 4
            Me.cbLayoutType4.TabStop = False
            Me.cbLayoutType4.Tag = 4
            AddHandler Me.cbLayoutType4.CheckedChanged, New System.EventHandler(AddressOf Me.OnLayoutSelectionChanged)
            ' 
            ' cbLayoutType3
            ' 
            Me.cbLayoutType3.Dock = System.Windows.Forms.DockStyle.Left
            Me.cbLayoutType3.GroupIndex = 0
            Me.cbLayoutType3.ImageOptions.ImageIndex = 3
            Me.cbLayoutType3.ImageOptions.ImageList = Me.containerImageCollection
            Me.cbLayoutType3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.cbLayoutType3.Location = New System.Drawing.Point(90, 0)
            Me.cbLayoutType3.Margin = New System.Windows.Forms.Padding(0)
            Me.cbLayoutType3.Name = "cbLayoutType3"
            Me.cbLayoutType3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.cbLayoutType3.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.cbLayoutType3.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem5.Text = "Horizontal Container"
            superToolTip5.Items.Add(toolTipTitleItem5)
            Me.cbLayoutType3.SuperTip = superToolTip5
            Me.cbLayoutType3.TabIndex = 3
            Me.cbLayoutType3.TabStop = False
            Me.cbLayoutType3.Tag = 3
            AddHandler Me.cbLayoutType3.CheckedChanged, New System.EventHandler(AddressOf Me.OnLayoutSelectionChanged)
            ' 
            ' cbLayoutType2
            ' 
            Me.cbLayoutType2.Dock = System.Windows.Forms.DockStyle.Left
            Me.cbLayoutType2.GroupIndex = 0
            Me.cbLayoutType2.ImageOptions.ImageIndex = 2
            Me.cbLayoutType2.ImageOptions.ImageList = Me.containerImageCollection
            Me.cbLayoutType2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.cbLayoutType2.Location = New System.Drawing.Point(60, 0)
            Me.cbLayoutType2.Margin = New System.Windows.Forms.Padding(0)
            Me.cbLayoutType2.Name = "cbLayoutType2"
            Me.cbLayoutType2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.cbLayoutType2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.cbLayoutType2.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem6.Text = "Tab Container"
            superToolTip6.Items.Add(toolTipTitleItem6)
            Me.cbLayoutType2.SuperTip = superToolTip6
            Me.cbLayoutType2.TabIndex = 1
            Me.cbLayoutType2.TabStop = False
            Me.cbLayoutType2.Tag = 2
            AddHandler Me.cbLayoutType2.CheckedChanged, New System.EventHandler(AddressOf Me.OnLayoutSelectionChanged)
            ' 
            ' cbLayoutType1
            ' 
            Me.cbLayoutType1.Checked = True
            Me.cbLayoutType1.Dock = System.Windows.Forms.DockStyle.Left
            Me.cbLayoutType1.GroupIndex = 0
            Me.cbLayoutType1.ImageOptions.ImageIndex = 1
            Me.cbLayoutType1.ImageOptions.ImageList = Me.containerImageCollection
            Me.cbLayoutType1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.cbLayoutType1.Location = New System.Drawing.Point(30, 0)
            Me.cbLayoutType1.Margin = New System.Windows.Forms.Padding(0)
            Me.cbLayoutType1.Name = "cbLayoutType1"
            Me.cbLayoutType1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.cbLayoutType1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.cbLayoutType1.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem7.Text = "Central Container"
            superToolTip7.Items.Add(toolTipTitleItem7)
            Me.cbLayoutType1.SuperTip = superToolTip7
            Me.cbLayoutType1.TabIndex = 2
            Me.cbLayoutType1.Tag = 1
            AddHandler Me.cbLayoutType1.CheckedChanged, New System.EventHandler(AddressOf Me.OnLayoutSelectionChanged)
            ' 
            ' cbLayoutType
            ' 
            Me.cbLayoutType.Dock = System.Windows.Forms.DockStyle.Left
            Me.cbLayoutType.GroupIndex = 0
            Me.cbLayoutType.ImageOptions.ImageIndex = 0
            Me.cbLayoutType.ImageOptions.ImageList = Me.containerImageCollection
            Me.cbLayoutType.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.cbLayoutType.Location = New System.Drawing.Point(0, 0)
            Me.cbLayoutType.Margin = New System.Windows.Forms.Padding(0)
            Me.cbLayoutType.Name = "cbLayoutType"
            Me.cbLayoutType.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.cbLayoutType.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.cbLayoutType.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem8.Text = "Simple Panel"
            superToolTip8.Items.Add(toolTipTitleItem8)
            Me.cbLayoutType.SuperTip = superToolTip8
            Me.cbLayoutType.TabIndex = 0
            Me.cbLayoutType.TabStop = False
            Me.cbLayoutType.Tag = 0
            AddHandler Me.cbLayoutType.CheckedChanged, New System.EventHandler(AddressOf Me.OnLayoutSelectionChanged)
            ' 
            ' sbAddPanel5
            ' 
            Me.sbAddPanel5.Dock = System.Windows.Forms.DockStyle.Right
            Me.sbAddPanel5.ImageOptions.ImageIndex = 3
            Me.sbAddPanel5.ImageOptions.ImageList = Me.dockImageCollection
            Me.sbAddPanel5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.sbAddPanel5.Location = New System.Drawing.Point(566, 0)
            Me.sbAddPanel5.Margin = New System.Windows.Forms.Padding(0)
            Me.sbAddPanel5.Name = "sbAddPanel5"
            Me.sbAddPanel5.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.sbAddPanel5.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem9.Text = "Add Float Panel"
            superToolTip9.Items.Add(toolTipTitleItem9)
            Me.sbAddPanel5.SuperTip = superToolTip9
            Me.sbAddPanel5.TabIndex = 11
            Me.sbAddPanel5.Tag = DevExpress.XtraBars.Docking.DockingStyle.Float
            AddHandler Me.sbAddPanel5.Click, New System.EventHandler(AddressOf Me.OnAddPanelButtonClick)
            ' 
            ' sbAddPanel3
            ' 
            Me.sbAddPanel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.sbAddPanel3.ImageOptions.ImageIndex = 5
            Me.sbAddPanel3.ImageOptions.ImageList = Me.dockImageCollection
            Me.sbAddPanel3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.sbAddPanel3.Location = New System.Drawing.Point(596, 0)
            Me.sbAddPanel3.Margin = New System.Windows.Forms.Padding(0)
            Me.sbAddPanel3.Name = "sbAddPanel3"
            Me.sbAddPanel3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.sbAddPanel3.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem10.Text = "Add Panel at Right"
            superToolTip10.Items.Add(toolTipTitleItem10)
            Me.sbAddPanel3.SuperTip = superToolTip10
            Me.sbAddPanel3.TabIndex = 6
            Me.sbAddPanel3.Tag = DevExpress.XtraBars.Docking.DockingStyle.Right
            AddHandler Me.sbAddPanel3.Click, New System.EventHandler(AddressOf Me.OnAddPanelButtonClick)
            ' 
            ' sbAddPanel4
            ' 
            Me.sbAddPanel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.sbAddPanel4.ImageOptions.ImageIndex = 4
            Me.sbAddPanel4.ImageOptions.ImageList = Me.dockImageCollection
            Me.sbAddPanel4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.sbAddPanel4.Location = New System.Drawing.Point(626, 0)
            Me.sbAddPanel4.Margin = New System.Windows.Forms.Padding(0)
            Me.sbAddPanel4.Name = "sbAddPanel4"
            Me.sbAddPanel4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.sbAddPanel4.Size = New System.Drawing.Size(30, 30)
            toolTipTitleItem11.Text = "Add Panel at Bottom"
            superToolTip11.Items.Add(toolTipTitleItem11)
            Me.sbAddPanel4.SuperTip = superToolTip11
            Me.sbAddPanel4.TabIndex = 5
            Me.sbAddPanel4.Tag = DevExpress.XtraBars.Docking.DockingStyle.Bottom
            AddHandler Me.sbAddPanel4.Click, New System.EventHandler(AddressOf Me.OnAddPanelButtonClick)
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mainPanel.Controls.Add(Me.contentPanel)
            Me.mainPanel.Controls.Add(Me.layoutLabel)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 31)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(656, 325)
            Me.mainPanel.TabIndex = 1
            ' 
            ' contentPanel
            ' 
            Me.contentPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.contentPanel.Location = New System.Drawing.Point(0, 27)
            Me.contentPanel.Name = "contentPanel"
            Me.contentPanel.Padding = New System.Windows.Forms.Padding(25, 5, 25, 20)
            Me.contentPanel.Size = New System.Drawing.Size(656, 298)
            Me.contentPanel.TabIndex = 1
            ' 
            ' layoutLabel
            ' 
            Me.layoutLabel.Appearance.FontSizeDelta = 2
            Me.layoutLabel.Appearance.Options.UseFont = True
            Me.layoutLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.layoutLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.layoutLabel.Location = New System.Drawing.Point(0, 0)
            Me.layoutLabel.Name = "layoutLabel"
            Me.layoutLabel.Padding = New System.Windows.Forms.Padding(25, 5, 5, 5)
            Me.layoutLabel.Size = New System.Drawing.Size(656, 27)
            Me.layoutLabel.TabIndex = 0
            Me.layoutLabel.Text = "labelControl1"
            ' 
            ' DockPanels
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Controls.Add(Me.toolbarPanel)
            Me.Name = "DockPanels"
            Me.Size = New System.Drawing.Size(656, 356)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OnDockPanelsLoad)
            CType((Me.containerImageCollection), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockImageCollection), System.ComponentModel.ISupportInitialize).EndInit()
            Me.toolbarPanel.ResumeLayout(False)
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainPanel.ResumeLayout(False)
            CType((Me.contentPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private containerImageCollection As DevExpress.Utils.SvgImageCollection

        Private toolbarPanel As DevExpress.XtraEditors.SidePanel

        Private mainPanel As DevExpress.XtraEditors.PanelControl

        Private contentPanel As DevExpress.XtraEditors.PanelControl

        Private layoutLabel As DevExpress.XtraEditors.LabelControl

        Private cbLayoutType As DevExpress.XtraEditors.CheckButton

        Private dockImageCollection As DevExpress.Utils.SvgImageCollection

        Private sbAddPanel1 As DevExpress.XtraEditors.SimpleButton

        Private sbAddPanel2 As DevExpress.XtraEditors.SimpleButton

        Private sbAddPanel3 As DevExpress.XtraEditors.SimpleButton

        Private sbAddPanel4 As DevExpress.XtraEditors.SimpleButton

        Private sbAddPanel As DevExpress.XtraEditors.SimpleButton

        Private cbLayoutType4 As DevExpress.XtraEditors.CheckButton

        Private cbLayoutType3 As DevExpress.XtraEditors.CheckButton

        Private cbLayoutType1 As DevExpress.XtraEditors.CheckButton

        Private cbLayoutType2 As DevExpress.XtraEditors.CheckButton

        Private buttonsLabel As DevExpress.XtraEditors.LabelControl

        Private sbAddPanel5 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
