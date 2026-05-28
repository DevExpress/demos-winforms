Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleTransitionManager

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
            Dim galleryItem1 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim transition1 As DevExpress.Utils.Animation.Transition = New DevExpress.Utils.Animation.Transition()
            Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.reviewImages = New DevExpress.XtraEditors.GroupControl()
            Me.galleryControl = New DevExpress.XtraBars.Ribbon.GalleryControl()
            Me.galleryControlClient = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            Me.transitionParameters = New DevExpress.XtraEditors.GroupControl()
            Me.ceBackground = New DevExpress.XtraEditors.ColorEdit()
            Me.seFrameInterval = New DevExpress.XtraEditors.SpinEdit()
            Me.seFrameCount = New DevExpress.XtraEditors.SpinEdit()
            Me.seStripeCount = New DevExpress.XtraEditors.SpinEdit()
            Me.checkUnCover = New DevExpress.XtraEditors.CheckEdit()
            Me.checkInward = New DevExpress.XtraEditors.CheckEdit()
            Me.checkVertical = New DevExpress.XtraEditors.CheckEdit()
            Me.lbBackground = New DevExpress.XtraEditors.LabelControl()
            Me.lbStripeCount = New DevExpress.XtraEditors.LabelControl()
            Me.lbFrameCount = New DevExpress.XtraEditors.LabelControl()
            Me.lbFrameInterval = New DevExpress.XtraEditors.LabelControl()
            Me.cbEffectOptions = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.lbEffectOptions = New DevExpress.XtraEditors.LabelControl()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.lbEasingFunction = New DevExpress.XtraEditors.LabelControl()
            Me.cbTransitionType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cbEasingMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cbEasingFunction = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.lbTransitionType = New DevExpress.XtraEditors.LabelControl()
            Me.lbEasingMode = New DevExpress.XtraEditors.LabelControl()
            Me.cbShowWaitIndicator = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.lbShowWaitIndicator = New DevExpress.XtraEditors.LabelControl()
            Me.transitionManager = New DevExpress.Utils.Animation.TransitionManager(Me.components)
            CType((Me.pictureEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType((Me.reviewImages), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.reviewImages.SuspendLayout()
            CType((Me.galleryControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.galleryControl.SuspendLayout()
            CType((Me.transitionParameters), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.transitionParameters.SuspendLayout()
            CType((Me.ceBackground.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seFrameInterval.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seFrameCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seStripeCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkUnCover.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkInward.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkVertical.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbEffectOptions.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.cbTransitionType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbEasingMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbEasingFunction.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbShowWaitIndicator.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pictureEdit
            ' 
            Me.pictureEdit.Location = New System.Drawing.Point(148, 43)
            Me.pictureEdit.Name = "pictureEdit"
            Me.pictureEdit.Size = New System.Drawing.Size(325, 325)
            Me.pictureEdit.TabIndex = 0
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
            Me.xtraTabControl1.Size = New System.Drawing.Size(843, 436)
            Me.xtraTabControl1.TabIndex = 14
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            Me.xtraTabControl1.TabStop = False
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.reviewImages)
            Me.xtraTabPage1.Controls.Add(Me.transitionParameters)
            Me.xtraTabPage1.Controls.Add(Me.groupControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(841, 434)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' reviewImages
            ' 
            Me.reviewImages.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.reviewImages.Appearance.Options.UseBackColor = True
            Me.reviewImages.Controls.Add(Me.pictureEdit)
            Me.reviewImages.Controls.Add(Me.galleryControl)
            Me.reviewImages.Location = New System.Drawing.Point(17, 15)
            Me.reviewImages.Name = "reviewImages"
            Me.reviewImages.Size = New System.Drawing.Size(493, 396)
            Me.reviewImages.TabIndex = 23
            Me.reviewImages.Text = "Review Images"
            ' 
            ' galleryControl
            ' 
            Me.galleryControl.Controls.Add(Me.galleryControlClient)
            ' 
            ' 
            ' 
            Me.galleryControl.Gallery.AllowMarqueeSelection = True
            galleryItemGroup1.Caption = "Group1"
            galleryItem1.Caption = "Item1"
            galleryItem1.ImageOptions.Image = Global.DevExpress.XtraEditors.Demos.Properties.Resources.product1
            galleryItem2.Caption = "Item2"
            galleryItem2.ImageOptions.Image = Global.DevExpress.XtraEditors.Demos.Properties.Resources.product2
            galleryItem3.Caption = "Item3"
            galleryItem3.ImageOptions.Image = Global.DevExpress.XtraEditors.Demos.Properties.Resources.product3
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem1, galleryItem2, galleryItem3})
            Me.galleryControl.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            Me.galleryControl.Gallery.ImageSize = New System.Drawing.Size(100, 90)
            Me.galleryControl.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.galleryControl.Gallery.ItemSize = New System.Drawing.Size(100, 90)
            Me.galleryControl.Gallery.ShowGroupCaption = False
            Me.galleryControl.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
            AddHandler Me.galleryControl.Gallery.ItemCheckedChanged, New DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(AddressOf Me.galleryControlGallery_ItemCheckedChanged)
            Me.galleryControl.Location = New System.Drawing.Point(18, 43)
            Me.galleryControl.Name = "galleryControl"
            Me.galleryControl.Size = New System.Drawing.Size(120, 325)
            Me.galleryControl.TabIndex = 0
            Me.galleryControl.Text = "galleryControl1"
            ' 
            ' galleryControlClient
            ' 
            Me.galleryControlClient.GalleryControl = Me.galleryControl
            Me.galleryControlClient.Location = New System.Drawing.Point(2, 2)
            Me.galleryControlClient.Size = New System.Drawing.Size(116, 321)
            ' 
            ' transitionParameters
            ' 
            Me.transitionParameters.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.transitionParameters.Appearance.Options.UseBackColor = True
            Me.transitionParameters.Controls.Add(Me.ceBackground)
            Me.transitionParameters.Controls.Add(Me.seFrameInterval)
            Me.transitionParameters.Controls.Add(Me.seFrameCount)
            Me.transitionParameters.Controls.Add(Me.seStripeCount)
            Me.transitionParameters.Controls.Add(Me.checkUnCover)
            Me.transitionParameters.Controls.Add(Me.checkInward)
            Me.transitionParameters.Controls.Add(Me.checkVertical)
            Me.transitionParameters.Controls.Add(Me.lbBackground)
            Me.transitionParameters.Controls.Add(Me.lbStripeCount)
            Me.transitionParameters.Controls.Add(Me.lbFrameCount)
            Me.transitionParameters.Controls.Add(Me.lbFrameInterval)
            Me.transitionParameters.Controls.Add(Me.cbEffectOptions)
            Me.transitionParameters.Controls.Add(Me.lbEffectOptions)
            Me.transitionParameters.Location = New System.Drawing.Point(529, 190)
            Me.transitionParameters.Name = "transitionParameters"
            Me.transitionParameters.Size = New System.Drawing.Size(285, 221)
            Me.transitionParameters.TabIndex = 23
            Me.transitionParameters.Text = "Transition parameters"
            ' 
            ' ceBackground
            ' 
            Me.ceBackground.EditValue = System.Drawing.Color.Empty
            Me.ceBackground.Location = New System.Drawing.Point(123, 121)
            Me.ceBackground.Name = "ceBackground"
            Me.ceBackground.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ceBackground.Size = New System.Drawing.Size(140, 20)
            Me.ceBackground.TabIndex = 36
            AddHandler Me.ceBackground.EditValueChanged, New System.EventHandler(AddressOf Me.ceBackground_EditValueChanged)
            ' 
            ' seFrameInterval
            ' 
            Me.seFrameInterval.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seFrameInterval.Location = New System.Drawing.Point(123, 34)
            Me.seFrameInterval.Name = "seFrameInterval"
            Me.seFrameInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seFrameInterval.Properties.IsFloatValue = False
            Me.seFrameInterval.Properties.Mask.EditMask = "N00"
            Me.seFrameInterval.Properties.MaxValue = New Decimal(New Integer() {1000000000, 0, 0, 0})
            Me.seFrameInterval.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seFrameInterval.Size = New System.Drawing.Size(140, 20)
            Me.seFrameInterval.TabIndex = 35
            AddHandler Me.seFrameInterval.ValueChanged, New System.EventHandler(AddressOf Me.seFrameInterval_ValueChanged)
            ' 
            ' seFrameCount
            ' 
            Me.seFrameCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seFrameCount.Location = New System.Drawing.Point(123, 63)
            Me.seFrameCount.Name = "seFrameCount"
            Me.seFrameCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seFrameCount.Properties.IsFloatValue = False
            Me.seFrameCount.Properties.Mask.EditMask = "N00"
            Me.seFrameCount.Properties.MaxValue = New Decimal(New Integer() {1000000000, 0, 0, 0})
            Me.seFrameCount.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seFrameCount.Size = New System.Drawing.Size(140, 20)
            Me.seFrameCount.TabIndex = 34
            AddHandler Me.seFrameCount.ValueChanged, New System.EventHandler(AddressOf Me.seFrameCount_ValueChanged)
            ' 
            ' seStripeCount
            ' 
            Me.seStripeCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seStripeCount.Location = New System.Drawing.Point(123, 151)
            Me.seStripeCount.Name = "seStripeCount"
            Me.seStripeCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seStripeCount.Properties.IsFloatValue = False
            Me.seStripeCount.Properties.Mask.EditMask = "N00"
            Me.seStripeCount.Properties.MaxValue = New Decimal(New Integer() {1000000000, 0, 0, 0})
            Me.seStripeCount.Size = New System.Drawing.Size(140, 20)
            Me.seStripeCount.TabIndex = 33
            AddHandler Me.seStripeCount.ValueChanged, New System.EventHandler(AddressOf Me.seStripeCount_ValueChanged)
            ' 
            ' checkUnCover
            ' 
            Me.checkUnCover.Location = New System.Drawing.Point(188, 184)
            Me.checkUnCover.Name = "checkUnCover"
            Me.checkUnCover.Properties.Caption = "Uncover"
            Me.checkUnCover.Size = New System.Drawing.Size(75, 20)
            Me.checkUnCover.TabIndex = 32
            AddHandler Me.checkUnCover.CheckedChanged, New System.EventHandler(AddressOf Me.checkUnCover_CheckedChanged)
            ' 
            ' checkInward
            ' 
            Me.checkInward.Location = New System.Drawing.Point(101, 184)
            Me.checkInward.Name = "checkInward"
            Me.checkInward.Properties.Caption = "Inward"
            Me.checkInward.Size = New System.Drawing.Size(75, 20)
            Me.checkInward.TabIndex = 31
            AddHandler Me.checkInward.CheckedChanged, New System.EventHandler(AddressOf Me.checkInward_CheckedChanged)
            ' 
            ' checkVertical
            ' 
            Me.checkVertical.Location = New System.Drawing.Point(20, 184)
            Me.checkVertical.Name = "checkVertical"
            Me.checkVertical.Properties.Caption = "Vertical"
            Me.checkVertical.Size = New System.Drawing.Size(75, 20)
            Me.checkVertical.TabIndex = 30
            AddHandler Me.checkVertical.CheckedChanged, New System.EventHandler(AddressOf Me.checkVertical_CheckedChanged)
            ' 
            ' lbBackground
            ' 
            Me.lbBackground.Location = New System.Drawing.Point(22, 124)
            Me.lbBackground.Name = "lbBackground"
            Me.lbBackground.Size = New System.Drawing.Size(60, 13)
            Me.lbBackground.TabIndex = 24
            Me.lbBackground.Text = "Background:"
            ' 
            ' lbStripeCount
            ' 
            Me.lbStripeCount.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.lbStripeCount.Appearance.Options.UseBackColor = True
            Me.lbStripeCount.Location = New System.Drawing.Point(22, 154)
            Me.lbStripeCount.Name = "lbStripeCount"
            Me.lbStripeCount.Size = New System.Drawing.Size(62, 13)
            Me.lbStripeCount.TabIndex = 22
            Me.lbStripeCount.Text = "Stripe count:"
            ' 
            ' lbFrameCount
            ' 
            Me.lbFrameCount.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.lbFrameCount.Appearance.Options.UseBackColor = True
            Me.lbFrameCount.Location = New System.Drawing.Point(22, 66)
            Me.lbFrameCount.Name = "lbFrameCount"
            Me.lbFrameCount.Size = New System.Drawing.Size(64, 13)
            Me.lbFrameCount.TabIndex = 21
            Me.lbFrameCount.Text = "Frame count:"
            ' 
            ' lbFrameInterval
            ' 
            Me.lbFrameInterval.Location = New System.Drawing.Point(22, 37)
            Me.lbFrameInterval.Name = "lbFrameInterval"
            Me.lbFrameInterval.Size = New System.Drawing.Size(73, 13)
            Me.lbFrameInterval.TabIndex = 16
            Me.lbFrameInterval.Text = "Frame interval:"
            ' 
            ' cbEffectOptions
            ' 
            Me.cbEffectOptions.EditValue = ""
            Me.cbEffectOptions.Location = New System.Drawing.Point(123, 92)
            Me.cbEffectOptions.Name = "cbEffectOptions"
            Me.cbEffectOptions.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbEffectOptions.Size = New System.Drawing.Size(140, 20)
            Me.cbEffectOptions.TabIndex = 15
            AddHandler Me.cbEffectOptions.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbEffectOptions_SelectedIndexChanged)
            ' 
            ' lbEffectOptions
            ' 
            Me.lbEffectOptions.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.lbEffectOptions.Appearance.Options.UseBackColor = True
            Me.lbEffectOptions.Location = New System.Drawing.Point(22, 95)
            Me.lbEffectOptions.Name = "lbEffectOptions"
            Me.lbEffectOptions.Size = New System.Drawing.Size(71, 13)
            Me.lbEffectOptions.TabIndex = 14
            Me.lbEffectOptions.Text = "Effect options:"
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl1.Appearance.Options.UseBackColor = True
            Me.groupControl1.Controls.Add(Me.lbEasingFunction)
            Me.groupControl1.Controls.Add(Me.cbTransitionType)
            Me.groupControl1.Controls.Add(Me.cbEasingMode)
            Me.groupControl1.Controls.Add(Me.cbEasingFunction)
            Me.groupControl1.Controls.Add(Me.lbTransitionType)
            Me.groupControl1.Controls.Add(Me.lbEasingMode)
            Me.groupControl1.Controls.Add(Me.cbShowWaitIndicator)
            Me.groupControl1.Controls.Add(Me.lbShowWaitIndicator)
            Me.groupControl1.Location = New System.Drawing.Point(529, 15)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(285, 158)
            Me.groupControl1.TabIndex = 3
            Me.groupControl1.Text = "Transition properties"
            ' 
            ' lbEasingFunction
            ' 
            Me.lbEasingFunction.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.lbEasingFunction.Appearance.Options.UseBackColor = True
            Me.lbEasingFunction.Location = New System.Drawing.Point(22, 67)
            Me.lbEasingFunction.Name = "lbEasingFunction"
            Me.lbEasingFunction.Size = New System.Drawing.Size(77, 13)
            Me.lbEasingFunction.TabIndex = 13
            Me.lbEasingFunction.Text = "Easing function:"
            ' 
            ' cbTransitionType
            ' 
            Me.cbTransitionType.EditValue = ""
            Me.cbTransitionType.Location = New System.Drawing.Point(123, 121)
            Me.cbTransitionType.Name = "cbTransitionType"
            Me.cbTransitionType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTransitionType.Size = New System.Drawing.Size(140, 20)
            Me.cbTransitionType.TabIndex = 12
            AddHandler Me.cbTransitionType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbTransitionType_SelectedIndexChanged)
            ' 
            ' cbEasingMode
            ' 
            Me.cbEasingMode.EditValue = ""
            Me.cbEasingMode.Location = New System.Drawing.Point(123, 35)
            Me.cbEasingMode.Name = "cbEasingMode"
            Me.cbEasingMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbEasingMode.Size = New System.Drawing.Size(140, 20)
            Me.cbEasingMode.TabIndex = 10
            AddHandler Me.cbEasingMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbEasingMode_SelectedIndexChanged)
            ' 
            ' cbEasingFunction
            ' 
            Me.cbEasingFunction.EditValue = ""
            Me.cbEasingFunction.Location = New System.Drawing.Point(123, 64)
            Me.cbEasingFunction.Name = "cbEasingFunction"
            Me.cbEasingFunction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbEasingFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbEasingFunction.Size = New System.Drawing.Size(140, 20)
            Me.cbEasingFunction.TabIndex = 9
            ' 
            ' lbTransitionType
            ' 
            Me.lbTransitionType.Location = New System.Drawing.Point(22, 124)
            Me.lbTransitionType.Name = "lbTransitionType"
            Me.lbTransitionType.Size = New System.Drawing.Size(76, 13)
            Me.lbTransitionType.TabIndex = 7
            Me.lbTransitionType.Text = "Transition type:"
            ' 
            ' lbEasingMode
            ' 
            Me.lbEasingMode.Location = New System.Drawing.Point(22, 38)
            Me.lbEasingMode.Name = "lbEasingMode"
            Me.lbEasingMode.Size = New System.Drawing.Size(64, 13)
            Me.lbEasingMode.TabIndex = 6
            Me.lbEasingMode.Text = "Easing mode:"
            ' 
            ' cbShowWaitIndicator
            ' 
            Me.cbShowWaitIndicator.EditValue = ""
            Me.cbShowWaitIndicator.Location = New System.Drawing.Point(123, 93)
            Me.cbShowWaitIndicator.Name = "cbShowWaitIndicator"
            Me.cbShowWaitIndicator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbShowWaitIndicator.Size = New System.Drawing.Size(140, 20)
            Me.cbShowWaitIndicator.TabIndex = 2
            AddHandler Me.cbShowWaitIndicator.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbShowWaitIndicator_SelectedIndexChanged)
            ' 
            ' lbShowWaitIndicator
            ' 
            Me.lbShowWaitIndicator.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.lbShowWaitIndicator.Appearance.Options.UseBackColor = True
            Me.lbShowWaitIndicator.Location = New System.Drawing.Point(22, 96)
            Me.lbShowWaitIndicator.Name = "lbShowWaitIndicator"
            Me.lbShowWaitIndicator.Size = New System.Drawing.Size(97, 13)
            Me.lbShowWaitIndicator.TabIndex = 1
            Me.lbShowWaitIndicator.Text = "Show wait indicator:"
            ' 
            ' transitionManager
            ' 
            transition1.Control = Me.pictureEdit
            Me.transitionManager.Transitions.Add(transition1)
            ' 
            ' ModuleTransitionManager
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleTransitionManager"
            Me.Size = New System.Drawing.Size(843, 436)
            CType((Me.pictureEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType((Me.reviewImages), System.ComponentModel.ISupportInitialize).EndInit()
            Me.reviewImages.ResumeLayout(False)
            CType((Me.galleryControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.galleryControl.ResumeLayout(False)
            CType((Me.transitionParameters), System.ComponentModel.ISupportInitialize).EndInit()
            Me.transitionParameters.ResumeLayout(False)
            Me.transitionParameters.PerformLayout()
            CType((Me.ceBackground.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seFrameInterval.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seFrameCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seStripeCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkUnCover.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkInward.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkVertical.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbEffectOptions.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType((Me.cbTransitionType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbEasingMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbEasingFunction.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbShowWaitIndicator.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private transitionManager As DevExpress.Utils.Animation.TransitionManager

        Private galleryControl As DevExpress.XtraBars.Ribbon.GalleryControl

        Private galleryControlClient As DevExpress.XtraBars.Ribbon.GalleryControlClient

        Private pictureEdit As DevExpress.XtraEditors.PictureEdit

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private lbTransitionType As DevExpress.XtraEditors.LabelControl

        Private lbEasingMode As DevExpress.XtraEditors.LabelControl

        Private cbShowWaitIndicator As DevExpress.XtraEditors.ImageComboBoxEdit

        Private lbShowWaitIndicator As DevExpress.XtraEditors.LabelControl

        Private lbEasingFunction As DevExpress.XtraEditors.LabelControl

        Private cbTransitionType As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cbEasingMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cbEasingFunction As DevExpress.XtraEditors.ComboBoxEdit

        Private lbEffectOptions As DevExpress.XtraEditors.LabelControl

        Private cbEffectOptions As DevExpress.XtraEditors.ImageComboBoxEdit

        Private lbFrameInterval As DevExpress.XtraEditors.LabelControl

        Private lbFrameCount As DevExpress.XtraEditors.LabelControl

        Private lbStripeCount As DevExpress.XtraEditors.LabelControl

        Private lbBackground As DevExpress.XtraEditors.LabelControl

        Private checkVertical As DevExpress.XtraEditors.CheckEdit

        Private checkInward As DevExpress.XtraEditors.CheckEdit

        Private transitionParameters As DevExpress.XtraEditors.GroupControl

        Private reviewImages As DevExpress.XtraEditors.GroupControl

        Private ceBackground As DevExpress.XtraEditors.ColorEdit

        Private seFrameInterval As DevExpress.XtraEditors.SpinEdit

        Private seFrameCount As DevExpress.XtraEditors.SpinEdit

        Private seStripeCount As DevExpress.XtraEditors.SpinEdit

        Private checkUnCover As DevExpress.XtraEditors.CheckEdit

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    End Class
End Namespace
