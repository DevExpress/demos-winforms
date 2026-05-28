Namespace DevExpress.XtraNavBar.Demos

    Partial Class AddItemLinks

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraNavBar.Demos.AddItemLinks))
            Me.button1 = New DevExpress.XtraEditors.SimpleButton()
            Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.button2 = New DevExpress.XtraEditors.SimpleButton()
            Me.label3 = New DevExpress.XtraEditors.LabelControl()
            Me.button3 = New DevExpress.XtraEditors.SimpleButton()
            Me.button4 = New DevExpress.XtraEditors.SimpleButton()
            Me.button5 = New DevExpress.XtraEditors.SimpleButton()
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.contentPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contentPanel1.SuspendLayout()
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' contentPanel1
            ' 
            Me.contentPanel1.Controls.Add(Me.panelControl1)
            Me.contentPanel1.Controls.Add(Me.navBarControl1)
            Me.contentPanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.contentPanel1.Padding = New System.Windows.Forms.Padding(3)
            Me.contentPanel1.Size = New System.Drawing.Size(527, 352)
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(23, 3)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(248, 28)
            Me.button1.TabIndex = 10
            Me.button1.Text = "Add New ItemLink to the Active Group"
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' navBarControl1
            ' 
            Me.navBarControl1.ActiveGroup = Me.navBarGroup1
            Me.navBarControl1.Appearance.ItemDisabled.Options.UseTextOptions = True
            Me.navBarControl1.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.navBarControl1.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.navBarControl1.Appearance.ItemHotTracked.Options.UseTextOptions = True
            Me.navBarControl1.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.navBarControl1.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.navBarControl1.Appearance.ItemPressed.Options.UseTextOptions = True
            Me.navBarControl1.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.navBarControl1.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.navBarControl1.ContentButtonHint = Nothing
            Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navBarGroup1, Me.navBarGroup2})
            Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navBarItem1})
            Me.navBarControl1.LargeImages = Me.imageCollection1
            Me.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInGroup
            Me.navBarControl1.Location = New System.Drawing.Point(4, 5)
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = 172
            Me.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
            Me.navBarControl1.Size = New System.Drawing.Size(172, 343)
            Me.navBarControl1.SmallImages = Me.imageCollection2
            Me.navBarControl1.StoreDefaultPaintStyleName = True
            Me.navBarControl1.TabIndex = 8
            Me.navBarControl1.Text = "navBarControl1"
            AddHandler Me.navBarControl1.SelectedLinkChanged, New DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventHandler(AddressOf Me.navBarControl1_SelectedLinkChanged)
            AddHandler Me.navBarControl1.ActiveGroupChanged, New DevExpress.XtraNavBar.NavBarGroupEventHandler(AddressOf Me.navBarControl1_ActiveGroupChanged)
            ' 
            ' navBarGroup1
            ' 
            Me.navBarGroup1.Caption = "Small Links"
            Me.navBarGroup1.Expanded = True
            Me.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small
            Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
            Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1)})
            Me.navBarGroup1.Name = "navBarGroup1"
            Me.navBarGroup1.SelectedLinkIndex = 0
            ' 
            ' navBarItem1
            ' 
            Me.navBarItem1.Caption = "Home"
            Me.navBarItem1.ImageOptions.LargeImageIndex = 0
            Me.navBarItem1.ImageOptions.SmallImageIndex = 0
            Me.navBarItem1.Name = "navBarItem1"
            ' 
            ' navBarGroup2
            ' 
            Me.navBarGroup2.Caption = "Large Links"
            Me.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small
            Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
            Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1)})
            Me.navBarGroup2.Name = "navBarGroup2"
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            ' 
            ' imageCollection2
            ' 
            Me.imageCollection2.ImageStream = CType((resources.GetObject("imageCollection2.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            ' 
            ' button2
            ' 
            Me.button2.Location = New System.Drawing.Point(23, 37)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(248, 28)
            Me.button2.TabIndex = 11
            Me.button2.Text = "Delete Selected ItemLink from the Active Group"
            AddHandler Me.button2.Click, New System.EventHandler(AddressOf Me.button2_Click)
            ' 
            ' label3
            ' 
            Me.label3.Location = New System.Drawing.Point(110, 188)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(83, 13)
            Me.label3.TabIndex = 12
            Me.label3.Text = "New Item Image:"
            ' 
            ' button3
            ' 
            Me.button3.Location = New System.Drawing.Point(23, 72)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(248, 28)
            Me.button3.TabIndex = 12
            Me.button3.Text = "Delete Item for the Selected Link"
            AddHandler Me.button3.Click, New System.EventHandler(AddressOf Me.button3_Click)
            ' 
            ' button4
            ' 
            Me.button4.Location = New System.Drawing.Point(23, 106)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(248, 28)
            Me.button4.TabIndex = 13
            Me.button4.Text = "Add New SeparatorItem to the Active Group"
            AddHandler Me.button4.Click, New System.EventHandler(AddressOf Me.button4_Click)
            ' 
            ' button5
            ' 
            Me.button5.Appearance.Options.UseTextOptions = True
            Me.button5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.button5.Location = New System.Drawing.Point(23, 141)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(248, 28)
            Me.button5.TabIndex = 14
            Me.button5.Text = "Delete Last Separator from the Active Group"
            AddHandler Me.button5.Click, New System.EventHandler(AddressOf Me.button5_Click)
            ' 
            ' imageComboBoxEdit1
            ' 
            Me.imageComboBoxEdit1.Location = New System.Drawing.Point(191, 186)
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.imageComboBoxEdit1.Size = New System.Drawing.Size(80, 20)
            Me.imageComboBoxEdit1.TabIndex = 13
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.button1)
            Me.panelControl1.Controls.Add(Me.imageComboBoxEdit1)
            Me.panelControl1.Controls.Add(Me.button5)
            Me.panelControl1.Controls.Add(Me.button4)
            Me.panelControl1.Controls.Add(Me.button3)
            Me.panelControl1.Controls.Add(Me.button2)
            Me.panelControl1.Controls.Add(Me.label3)
            Me.panelControl1.Location = New System.Drawing.Point(238, 5)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(286, 343)
            Me.panelControl1.TabIndex = 15
            ' 
            ' AddItemLinks
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "AddItemLinks"
            Me.Size = New System.Drawing.Size(527, 352)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.AddItemLinks_Load)
            CType((Me.contentPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.contentPanel1.ResumeLayout(False)
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private button1 As DevExpress.XtraEditors.SimpleButton

        Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl

        Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup

        Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup

        Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem

        Private button2 As DevExpress.XtraEditors.SimpleButton

        Private label3 As DevExpress.XtraEditors.LabelControl

        Private button3 As DevExpress.XtraEditors.SimpleButton

        Private button4 As DevExpress.XtraEditors.SimpleButton

        Private button5 As DevExpress.XtraEditors.SimpleButton

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private imageCollection2 As DevExpress.Utils.ImageCollection

        Private imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private components As System.ComponentModel.IContainer

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
