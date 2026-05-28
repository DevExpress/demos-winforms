Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleStepProgressBar

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleStepProgressBar))
            Me.itemPaymentDetails = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.itemShippingOptions = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.itemConfirmation = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.itemPersonalInfo = New DevExpress.XtraEditors.StepProgressBarItem()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.tbcSelectStep = New DevExpress.XtraEditors.TrackBarControl()
            Me.tableLayoutPanelSample = New System.Windows.Forms.TableLayoutPanel()
            Me.stepProgressBarSample = New DevExpress.XtraEditors.StepProgressBar()
            Me.ceDrawConnectors = New DevExpress.XtraEditors.CheckEdit()
            Me.icbOrientation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceInversedProgressDirection = New DevExpress.XtraEditors.CheckEdit()
            Me.ceFillIndicators = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowStepIcons = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowIndicatorIcons = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowAnimation = New DevExpress.XtraEditors.CheckEdit()
            Me.ceDrawShadows = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowUserInteraction = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lcgSample = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciSample = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcgSelectStep = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciSelectStep = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcgProps = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciOrientation = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciInversedProgressDirection = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciDrawConnectors = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciFillIndicators = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciShowStepIcons = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciShowIndicatorIcons = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciAllowAnimation = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciDrawShadows = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciAllowUserInteraction = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dateTimeChartRangeControlClient1 = New DevExpress.XtraEditors.DateTimeChartRangeControlClient()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.tbcSelectStep), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbcSelectStep.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanelSample.SuspendLayout()
            CType((Me.stepProgressBarSample), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceDrawConnectors.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbOrientation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceInversedProgressDirection.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceFillIndicators.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowStepIcons.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowIndicatorIcons.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowAnimation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceDrawShadows.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowUserInteraction.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgSample), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciSample), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgSelectStep), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciSelectStep), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgProps), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciOrientation), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciInversedProgressDirection), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciDrawConnectors), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciFillIndicators), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciShowStepIcons), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciShowIndicatorIcons), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciAllowAnimation), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciDrawShadows), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciAllowUserInteraction), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateTimeChartRangeControlClient1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' itemPaymentDetails
            ' 
            Me.itemPaymentDetails.ContentBlock1.ActiveStateImageOptions.SvgImage = CType((resources.GetObject("itemPaymentDetails.ContentBlock1.ActiveStateImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.itemPaymentDetails.ContentBlock1.InactiveStateImageOptions.SvgImage = CType((resources.GetObject("itemPaymentDetails.ContentBlock1.InactiveStateImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.itemPaymentDetails.ContentBlock2.Caption = "Payment Details"
            Me.itemPaymentDetails.ContentBlock2.Description = "Credit card or PayPal"
            Me.itemPaymentDetails.Name = "itemPaymentDetails"
            ' 
            ' itemShippingOptions
            ' 
            Me.itemShippingOptions.ContentBlock1.ActiveStateImageOptions.SvgImage = CType((resources.GetObject("itemShippingOptions.ContentBlock1.ActiveStateImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.itemShippingOptions.ContentBlock1.InactiveStateImageOptions.SvgImage = CType((resources.GetObject("itemShippingOptions.ContentBlock1.InactiveStateImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.itemShippingOptions.ContentBlock2.Caption = "Shipping Options"
            Me.itemShippingOptions.ContentBlock2.Description = "Shipping method and address"
            Me.itemShippingOptions.Name = "itemShippingOptions"
            Me.itemShippingOptions.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
            ' 
            ' itemConfirmation
            ' 
            Me.itemConfirmation.ContentBlock1.ActiveStateImageOptions.SvgImage = CType((resources.GetObject("itemConfirmation.ContentBlock1.ActiveStateImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.itemConfirmation.ContentBlock1.InactiveStateImageOptions.SvgImage = CType((resources.GetObject("itemConfirmation.ContentBlock1.InactiveStateImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.itemConfirmation.ContentBlock2.Caption = "Confirmation"
            Me.itemConfirmation.ContentBlock2.Description = "Confirm and pay"
            Me.itemConfirmation.Name = "itemConfirmation"
            ' 
            ' itemPersonalInfo
            ' 
            Me.itemPersonalInfo.ContentBlock1.ActiveStateImageOptions.SvgImage = CType((resources.GetObject("itemPersonalInfo.ContentBlock1.ActiveStateImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.itemPersonalInfo.ContentBlock1.InactiveStateImageOptions.SvgImage = CType((resources.GetObject("itemPersonalInfo.ContentBlock1.InactiveStateImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.itemPersonalInfo.ContentBlock2.Caption = "Personal Info"
            Me.itemPersonalInfo.ContentBlock2.Description = "Your name and email"
            Me.itemPersonalInfo.Name = "itemPersonalInfo"
            Me.itemPersonalInfo.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.tbcSelectStep)
            Me.layoutControl1.Controls.Add(Me.tableLayoutPanelSample)
            Me.layoutControl1.Controls.Add(Me.ceDrawConnectors)
            Me.layoutControl1.Controls.Add(Me.icbOrientation)
            Me.layoutControl1.Controls.Add(Me.ceInversedProgressDirection)
            Me.layoutControl1.Controls.Add(Me.ceFillIndicators)
            Me.layoutControl1.Controls.Add(Me.ceShowStepIcons)
            Me.layoutControl1.Controls.Add(Me.ceShowIndicatorIcons)
            Me.layoutControl1.Controls.Add(Me.ceAllowAnimation)
            Me.layoutControl1.Controls.Add(Me.ceDrawShadows)
            Me.layoutControl1.Controls.Add(Me.ceAllowUserInteraction)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1181, 351, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(961, 608)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' tbcSelectStep
            ' 
            Me.tbcSelectStep.Location = New System.Drawing.Point(709, 45)
            Me.tbcSelectStep.Name = "tbcSelectStep"
            Me.tbcSelectStep.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.tbcSelectStep.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.tbcSelectStep.Properties.LargeChange = 4
            Me.tbcSelectStep.Properties.Maximum = 3
            Me.tbcSelectStep.Properties.Minimum = -1
            Me.tbcSelectStep.Properties.TickStyle = System.Windows.Forms.TickStyle.Both
            Me.tbcSelectStep.Size = New System.Drawing.Size(228, 45)
            Me.tbcSelectStep.StyleController = Me.layoutControl1
            Me.tbcSelectStep.TabIndex = 1
            Me.tbcSelectStep.Value = 0
            AddHandler Me.tbcSelectStep.EditValueChanged, New System.EventHandler(AddressOf Me.tbcSelectStep_EditValueChanged)
            ' 
            ' tableLayoutPanelSample
            ' 
            Me.tableLayoutPanelSample.ColumnCount = 1
            Me.tableLayoutPanelSample.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Me.tableLayoutPanelSample.Controls.Add(Me.stepProgressBarSample, 0, 0)
            Me.tableLayoutPanelSample.Location = New System.Drawing.Point(24, 45)
            Me.tableLayoutPanelSample.Name = "tableLayoutPanelSample"
            Me.tableLayoutPanelSample.RowCount = 1
            Me.tableLayoutPanelSample.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Me.tableLayoutPanelSample.Size = New System.Drawing.Size(657, 539)
            Me.tableLayoutPanelSample.TabIndex = 18
            ' 
            ' stepProgressBarSample
            ' 
            Me.stepProgressBarSample.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
            Me.stepProgressBarSample.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
            Me.stepProgressBarSample.AllowUserInteraction = DevExpress.Utils.DefaultBoolean.[True]
            Me.stepProgressBarSample.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.stepProgressBarSample.DistanceBetweenContentBlockElements = 2
            Me.stepProgressBarSample.Dock = System.Windows.Forms.DockStyle.Fill
            Me.stepProgressBarSample.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage = CType((resources.GetObject("stepProgressBarSample.ItemOptions.Indicator.ActiveStateImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.stepProgressBarSample.ItemOptions.Indicator.ActiveStateImageOptions.SvgImageSize = New System.Drawing.Size(14, 14)
            Me.stepProgressBarSample.ItemOptions.Indicator.InactiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline
            Me.stepProgressBarSample.ItemOptions.Indicator.Width = 24
            Me.stepProgressBarSample.Items.Add(Me.itemPersonalInfo)
            Me.stepProgressBarSample.Items.Add(Me.itemShippingOptions)
            Me.stepProgressBarSample.Items.Add(Me.itemPaymentDetails)
            Me.stepProgressBarSample.Items.Add(Me.itemConfirmation)
            Me.stepProgressBarSample.Location = New System.Drawing.Point(3, 3)
            Me.stepProgressBarSample.Name = "stepProgressBarSample"
            Me.stepProgressBarSample.SelectedItemIndex = 1
            Me.stepProgressBarSample.ShadowDrawMode = DevExpress.XtraEditors.StepProgressBarShadowDrawMode.ActiveElements
            Me.stepProgressBarSample.Size = New System.Drawing.Size(651, 533)
            Me.stepProgressBarSample.TabIndex = 0
            AddHandler Me.stepProgressBarSample.ItemClick, New System.EventHandler(Of DevExpress.XtraEditors.StepProgressBarItemClickEventArgs)(AddressOf Me.stepProgressBarSample_ItemClick)
            ' 
            ' ceDrawConnectors
            ' 
            Me.ceDrawConnectors.Location = New System.Drawing.Point(709, 187)
            Me.ceDrawConnectors.Name = "ceDrawConnectors"
            Me.ceDrawConnectors.Properties.Caption = "Draw connectors"
            Me.ceDrawConnectors.Size = New System.Drawing.Size(228, 20)
            Me.ceDrawConnectors.StyleController = Me.layoutControl1
            Me.ceDrawConnectors.TabIndex = 9
            AddHandler Me.ceDrawConnectors.CheckedChanged, New System.EventHandler(AddressOf Me.ceDrawConnectors_CheckedChanged)
            ' 
            ' icbOrientation
            ' 
            Me.icbOrientation.Location = New System.Drawing.Point(782, 139)
            Me.icbOrientation.Name = "icbOrientation"
            Me.icbOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbOrientation.Size = New System.Drawing.Size(155, 20)
            Me.icbOrientation.StyleController = Me.layoutControl1
            Me.icbOrientation.TabIndex = 6
            AddHandler Me.icbOrientation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbOrientation_SelectedIndexChanged)
            ' 
            ' ceInversedProgressDirection
            ' 
            Me.ceInversedProgressDirection.Location = New System.Drawing.Point(709, 163)
            Me.ceInversedProgressDirection.Name = "ceInversedProgressDirection"
            Me.ceInversedProgressDirection.Properties.Caption = "Inversed progress direction"
            Me.ceInversedProgressDirection.Size = New System.Drawing.Size(228, 20)
            Me.ceInversedProgressDirection.StyleController = Me.layoutControl1
            Me.ceInversedProgressDirection.TabIndex = 8
            AddHandler Me.ceInversedProgressDirection.CheckedChanged, New System.EventHandler(AddressOf Me.ceInversedProgressDirection_CheckedChanged)
            ' 
            ' ceFillIndicators
            ' 
            Me.ceFillIndicators.Location = New System.Drawing.Point(709, 235)
            Me.ceFillIndicators.Name = "ceFillIndicators"
            Me.ceFillIndicators.Properties.Caption = "Fill indicators"
            Me.ceFillIndicators.Size = New System.Drawing.Size(228, 20)
            Me.ceFillIndicators.StyleController = Me.layoutControl1
            Me.ceFillIndicators.TabIndex = 12
            AddHandler Me.ceFillIndicators.CheckedChanged, New System.EventHandler(AddressOf Me.ceFillIndicators_CheckedChanged)
            ' 
            ' ceShowStepIcons
            ' 
            Me.ceShowStepIcons.EditValue = True
            Me.ceShowStepIcons.Location = New System.Drawing.Point(709, 259)
            Me.ceShowStepIcons.Name = "ceShowStepIcons"
            Me.ceShowStepIcons.Properties.Caption = "Show step icons"
            Me.ceShowStepIcons.Size = New System.Drawing.Size(228, 20)
            Me.ceShowStepIcons.StyleController = Me.layoutControl1
            Me.ceShowStepIcons.TabIndex = 15
            AddHandler Me.ceShowStepIcons.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowStepIcons_CheckedChanged)
            ' 
            ' ceShowIndicatorIcons
            ' 
            Me.ceShowIndicatorIcons.EditValue = True
            Me.ceShowIndicatorIcons.Location = New System.Drawing.Point(709, 283)
            Me.ceShowIndicatorIcons.Name = "ceShowIndicatorIcons"
            Me.ceShowIndicatorIcons.Properties.Caption = "Show indicator icons"
            Me.ceShowIndicatorIcons.Size = New System.Drawing.Size(228, 20)
            Me.ceShowIndicatorIcons.StyleController = Me.layoutControl1
            Me.ceShowIndicatorIcons.TabIndex = 16
            AddHandler Me.ceShowIndicatorIcons.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowIndicatorIcons_CheckedChanged)
            ' 
            ' ceAllowAnimation
            ' 
            Me.ceAllowAnimation.Location = New System.Drawing.Point(709, 307)
            Me.ceAllowAnimation.Name = "ceAllowAnimation"
            Me.ceAllowAnimation.Properties.Caption = "Allow animation"
            Me.ceAllowAnimation.Size = New System.Drawing.Size(228, 20)
            Me.ceAllowAnimation.StyleController = Me.layoutControl1
            Me.ceAllowAnimation.TabIndex = 17
            AddHandler Me.ceAllowAnimation.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowAnimation_CheckedChanged)
            ' 
            ' ceDrawShadows
            ' 
            Me.ceDrawShadows.EditValue = True
            Me.ceDrawShadows.Location = New System.Drawing.Point(709, 211)
            Me.ceDrawShadows.Name = "ceDrawShadows"
            Me.ceDrawShadows.Properties.Caption = "Draw shadows"
            Me.ceDrawShadows.Size = New System.Drawing.Size(228, 20)
            Me.ceDrawShadows.StyleController = Me.layoutControl1
            Me.ceDrawShadows.TabIndex = 19
            AddHandler Me.ceDrawShadows.CheckedChanged, New System.EventHandler(AddressOf Me.ceDrawShadows_CheckedChanged)
            ' 
            ' ceAllowUserInteraction
            ' 
            Me.ceAllowUserInteraction.EditValue = True
            Me.ceAllowUserInteraction.Location = New System.Drawing.Point(709, 331)
            Me.ceAllowUserInteraction.Name = "ceAllowUserInteraction"
            Me.ceAllowUserInteraction.Properties.Caption = "Allow interactive step selection"
            Me.ceAllowUserInteraction.Size = New System.Drawing.Size(228, 20)
            Me.ceAllowUserInteraction.StyleController = Me.layoutControl1
            Me.ceAllowUserInteraction.TabIndex = 21
            AddHandler Me.ceAllowUserInteraction.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowUserInteraction_CheckedChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcgSample, Me.lcgSelectStep, Me.lcgProps})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(961, 608)
            Me.Root.TextVisible = False
            ' 
            ' lcgSample
            ' 
            Me.lcgSample.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciSample})
            Me.lcgSample.Location = New System.Drawing.Point(0, 0)
            Me.lcgSample.Name = "lcgSample"
            Me.lcgSample.Size = New System.Drawing.Size(685, 588)
            Me.lcgSample.Text = "Sample"
            ' 
            ' lciSample
            ' 
            Me.lciSample.Control = Me.tableLayoutPanelSample
            Me.lciSample.Location = New System.Drawing.Point(0, 0)
            Me.lciSample.Name = "lciSample"
            Me.lciSample.Size = New System.Drawing.Size(661, 543)
            Me.lciSample.TextVisible = False
            ' 
            ' lcgSelectStep
            ' 
            Me.lcgSelectStep.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciSelectStep})
            Me.lcgSelectStep.Location = New System.Drawing.Point(685, 0)
            Me.lcgSelectStep.Name = "lcgSelectStep"
            Me.lcgSelectStep.Size = New System.Drawing.Size(256, 94)
            Me.lcgSelectStep.Text = "Select a Step"
            ' 
            ' lciSelectStep
            ' 
            Me.lciSelectStep.Control = Me.tbcSelectStep
            Me.lciSelectStep.Location = New System.Drawing.Point(0, 0)
            Me.lciSelectStep.Name = "lciSelectStep"
            Me.lciSelectStep.Size = New System.Drawing.Size(232, 49)
            Me.lciSelectStep.TextVisible = False
            ' 
            ' lcgProps
            ' 
            Me.lcgProps.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciOrientation, Me.lciInversedProgressDirection, Me.lciDrawConnectors, Me.lciFillIndicators, Me.lciShowStepIcons, Me.lciShowIndicatorIcons, Me.lciAllowAnimation, Me.emptySpaceItem2, Me.lciDrawShadows, Me.lciAllowUserInteraction})
            Me.lcgProps.Location = New System.Drawing.Point(685, 94)
            Me.lcgProps.Name = "lcgProps"
            Me.lcgProps.Size = New System.Drawing.Size(256, 494)
            Me.lcgProps.Text = "Properties"
            ' 
            ' lciOrientation
            ' 
            Me.lciOrientation.Control = Me.icbOrientation
            Me.lciOrientation.Location = New System.Drawing.Point(0, 0)
            Me.lciOrientation.Name = "lciOrientation"
            Me.lciOrientation.Size = New System.Drawing.Size(232, 24)
            Me.lciOrientation.Text = "Orientation: "
            Me.lciOrientation.TextSize = New System.Drawing.Size(61, 13)
            ' 
            ' lciInversedProgressDirection
            ' 
            Me.lciInversedProgressDirection.Control = Me.ceInversedProgressDirection
            Me.lciInversedProgressDirection.Location = New System.Drawing.Point(0, 24)
            Me.lciInversedProgressDirection.Name = "lciInversedProgressDirection"
            Me.lciInversedProgressDirection.Size = New System.Drawing.Size(232, 24)
            Me.lciInversedProgressDirection.TextVisible = False
            ' 
            ' lciDrawConnectors
            ' 
            Me.lciDrawConnectors.Control = Me.ceDrawConnectors
            Me.lciDrawConnectors.Location = New System.Drawing.Point(0, 48)
            Me.lciDrawConnectors.Name = "lciDrawConnectors"
            Me.lciDrawConnectors.Size = New System.Drawing.Size(232, 24)
            Me.lciDrawConnectors.TextVisible = False
            ' 
            ' lciFillIndicators
            ' 
            Me.lciFillIndicators.Control = Me.ceFillIndicators
            Me.lciFillIndicators.Location = New System.Drawing.Point(0, 96)
            Me.lciFillIndicators.Name = "lciFillIndicators"
            Me.lciFillIndicators.Size = New System.Drawing.Size(232, 24)
            Me.lciFillIndicators.TextVisible = False
            ' 
            ' lciShowStepIcons
            ' 
            Me.lciShowStepIcons.Control = Me.ceShowStepIcons
            Me.lciShowStepIcons.Location = New System.Drawing.Point(0, 120)
            Me.lciShowStepIcons.Name = "lciShowStepIcons"
            Me.lciShowStepIcons.Size = New System.Drawing.Size(232, 24)
            Me.lciShowStepIcons.TextVisible = False
            ' 
            ' lciShowIndicatorIcons
            ' 
            Me.lciShowIndicatorIcons.Control = Me.ceShowIndicatorIcons
            Me.lciShowIndicatorIcons.Location = New System.Drawing.Point(0, 144)
            Me.lciShowIndicatorIcons.Name = "lciShowIndicatorIcons"
            Me.lciShowIndicatorIcons.Size = New System.Drawing.Size(232, 24)
            Me.lciShowIndicatorIcons.TextVisible = False
            ' 
            ' lciAllowAnimation
            ' 
            Me.lciAllowAnimation.Control = Me.ceAllowAnimation
            Me.lciAllowAnimation.Location = New System.Drawing.Point(0, 168)
            Me.lciAllowAnimation.Name = "lciAllowAnimation"
            Me.lciAllowAnimation.Size = New System.Drawing.Size(232, 24)
            Me.lciAllowAnimation.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 216)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(232, 0)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(232, 10)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(232, 233)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' lciDrawShadows
            ' 
            Me.lciDrawShadows.Control = Me.ceDrawShadows
            Me.lciDrawShadows.Location = New System.Drawing.Point(0, 72)
            Me.lciDrawShadows.Name = "lciDrawShadows"
            Me.lciDrawShadows.Size = New System.Drawing.Size(232, 24)
            Me.lciDrawShadows.TextVisible = False
            ' 
            ' lciAllowUserInteraction
            ' 
            Me.lciAllowUserInteraction.Control = Me.ceAllowUserInteraction
            Me.lciAllowUserInteraction.Location = New System.Drawing.Point(0, 192)
            Me.lciAllowUserInteraction.Name = "lciAllowUserInteraction"
            Me.lciAllowUserInteraction.Size = New System.Drawing.Size(232, 24)
            Me.lciAllowUserInteraction.TextVisible = False
            ' 
            ' ModuleStepProgressBar
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleStepProgressBar"
            Me.Size = New System.Drawing.Size(961, 608)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleStepProgressBar_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.tbcSelectStep.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbcSelectStep), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanelSample.ResumeLayout(False)
            CType((Me.stepProgressBarSample), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceDrawConnectors.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbOrientation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceInversedProgressDirection.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceFillIndicators.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowStepIcons.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowIndicatorIcons.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowAnimation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceDrawShadows.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowUserInteraction.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgSample), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciSample), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgSelectStep), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciSelectStep), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgProps), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciOrientation), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciInversedProgressDirection), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciDrawConnectors), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciFillIndicators), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciShowStepIcons), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciShowIndicatorIcons), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciAllowAnimation), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciDrawShadows), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciAllowUserInteraction), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateTimeChartRangeControlClient1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private itemPaymentDetails As DevExpress.XtraEditors.StepProgressBarItem

        Private itemShippingOptions As DevExpress.XtraEditors.StepProgressBarItem

        Private itemConfirmation As DevExpress.XtraEditors.StepProgressBarItem

        Private itemPersonalInfo As DevExpress.XtraEditors.StepProgressBarItem

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private stepProgressBarSample As DevExpress.XtraEditors.StepProgressBar

        Private ceDrawConnectors As DevExpress.XtraEditors.CheckEdit

        Private icbOrientation As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceInversedProgressDirection As DevExpress.XtraEditors.CheckEdit

        Private ceFillIndicators As DevExpress.XtraEditors.CheckEdit

        Private ceShowStepIcons As DevExpress.XtraEditors.CheckEdit

        Private ceShowIndicatorIcons As DevExpress.XtraEditors.CheckEdit

        Private ceAllowAnimation As DevExpress.XtraEditors.CheckEdit

        Private ceDrawShadows As DevExpress.XtraEditors.CheckEdit

        Private ceAllowUserInteraction As DevExpress.XtraEditors.CheckEdit

        Private lcgSample As DevExpress.XtraLayout.LayoutControlGroup

        Private lcgProps As DevExpress.XtraLayout.LayoutControlGroup

        Private lciOrientation As DevExpress.XtraLayout.LayoutControlItem

        Private lciInversedProgressDirection As DevExpress.XtraLayout.LayoutControlItem

        Private lciDrawConnectors As DevExpress.XtraLayout.LayoutControlItem

        Private lciFillIndicators As DevExpress.XtraLayout.LayoutControlItem

        Private lciShowStepIcons As DevExpress.XtraLayout.LayoutControlItem

        Private lciShowIndicatorIcons As DevExpress.XtraLayout.LayoutControlItem

        Private lciAllowAnimation As DevExpress.XtraLayout.LayoutControlItem

        Private lciDrawShadows As DevExpress.XtraLayout.LayoutControlItem

        Private lciAllowUserInteraction As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private lcgSelectStep As DevExpress.XtraLayout.LayoutControlGroup

        Private tableLayoutPanelSample As System.Windows.Forms.TableLayoutPanel

        Private lciSample As DevExpress.XtraLayout.LayoutControlItem

        Private tbcSelectStep As DevExpress.XtraEditors.TrackBarControl

        Private lciSelectStep As DevExpress.XtraLayout.LayoutControlItem

        Private dateTimeChartRangeControlClient1 As DevExpress.XtraEditors.DateTimeChartRangeControlClient
    End Class
End Namespace
