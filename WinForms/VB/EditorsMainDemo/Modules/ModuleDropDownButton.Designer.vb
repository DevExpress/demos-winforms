Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleDropDownButton

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleDropDownButton))
            Me.icbDropDownStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sampleDropDownButton = New DevExpress.XtraEditors.DropDownButton()
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.svgImageCollection2 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.icbImageLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
            Me.icbImage = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbDropDownControl = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.meFiringEvents = New DevExpress.XtraEditors.MemoEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.timeEdit1 = New DevExpress.XtraEditors.TimeEdit()
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            CType((Me.icbDropDownStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbImageLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbImage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbDropDownControl.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.meFiringEvents.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupControlContainer1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            CType((Me.timeEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit1.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' icbDropDownStyle
            ' 
            Me.icbDropDownStyle.Location = New System.Drawing.Point(425, 137)
            Me.icbDropDownStyle.Name = "icbDropDownStyle"
            Me.icbDropDownStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbDropDownStyle.Size = New System.Drawing.Size(181, 20)
            Me.icbDropDownStyle.StyleController = Me.layoutControl1
            Me.icbDropDownStyle.TabIndex = 6
            AddHandler Me.icbDropDownStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbDropDownStyle_SelectedIndexChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.icbDropDownStyle)
            Me.layoutControl1.Controls.Add(Me.sampleDropDownButton)
            Me.layoutControl1.Controls.Add(Me.icbImageLocation)
            Me.layoutControl1.Controls.Add(Me.simpleButton3)
            Me.layoutControl1.Controls.Add(Me.icbImage)
            Me.layoutControl1.Controls.Add(Me.icbDropDownControl)
            Me.layoutControl1.Controls.Add(Me.meFiringEvents)
            Me.layoutControl1.Location = New System.Drawing.Point(41, 41)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(653, 410)
            Me.layoutControl1.TabIndex = 11
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' sampleDropDownButton
            ' 
            Me.sampleDropDownButton.DropDownControl = Me.popupMenu1
            Me.sampleDropDownButton.ImageOptions.ImageIndex = 0
            Me.sampleDropDownButton.ImageOptions.ImageList = Me.svgImageCollection1
            Me.sampleDropDownButton.Location = New System.Drawing.Point(32, 210)
            Me.sampleDropDownButton.MinimumSize = New System.Drawing.Size(0, 35)
            Me.sampleDropDownButton.Name = "sampleDropDownButton"
            Me.sampleDropDownButton.Size = New System.Drawing.Size(196, 35)
            Me.sampleDropDownButton.StyleController = Me.layoutControl1
            Me.sampleDropDownButton.TabIndex = 0
            Me.sampleDropDownButton.Text = "DropDown Button"
            AddHandler Me.sampleDropDownButton.ShowDropDownControl, New DevExpress.XtraEditors.ShowDropDownControlEventHandler(AddressOf Me.sampleDropDownButton_ShowDropDownControl)
            AddHandler Me.sampleDropDownButton.Click, New System.EventHandler(AddressOf Me.sampleDropDownButton_Click)
            ' 
            ' popupMenu1
            ' 
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5)})
            Me.popupMenu1.Manager = Me.barManager1
            Me.popupMenu1.Name = "popupMenu1"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Copy"
            Me.barButtonItem1.Id = 0
            Me.barButtonItem1.ImageOptions.ImageIndex = 0
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Paste"
            Me.barButtonItem2.Id = 1
            Me.barButtonItem2.ImageOptions.ImageIndex = 1
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "Delete"
            Me.barButtonItem3.Id = 2
            Me.barButtonItem3.ImageOptions.ImageIndex = 2
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barButtonItem4
            ' 
            Me.barButtonItem4.Caption = "Open"
            Me.barButtonItem4.Id = 3
            Me.barButtonItem4.ImageOptions.ImageIndex = 3
            Me.barButtonItem4.Name = "barButtonItem4"
            ' 
            ' barButtonItem5
            ' 
            Me.barButtonItem5.Caption = "Save"
            Me.barButtonItem5.Id = 4
            Me.barButtonItem5.ImageOptions.ImageIndex = 4
            Me.barButtonItem5.Name = "barButtonItem5"
            ' 
            ' barManager1
            ' 
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.svgImageCollection2
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5})
            Me.barManager1.MaxItemId = 5
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(908, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 528)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(908, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 528)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(908, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 528)
            ' 
            ' svgImageCollection2
            ' 
            Me.svgImageCollection2.Add("Copy", CType((resources.GetObject("svgImageCollection2.Copy")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection2.Add("Paste", CType((resources.GetObject("svgImageCollection2.Paste")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection2.Add("Delete", CType((resources.GetObject("svgImageCollection2.Delete")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection2.Add("Open", CType((resources.GetObject("svgImageCollection2.Open")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection2.Add("Save", CType((resources.GetObject("svgImageCollection2.Save")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Address", CType((resources.GetObject("svgImageCollection1.Address")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Contact", CType((resources.GetObject("svgImageCollection1.Contact")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Contract", CType((resources.GetObject("svgImageCollection1.Contract")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Customer", CType((resources.GetObject("svgImageCollection1.Customer")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Employeer", CType((resources.GetObject("svgImageCollection1.Employeer")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Report", CType((resources.GetObject("svgImageCollection1.Report")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("User", CType((resources.GetObject("svgImageCollection1.User")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' icbImageLocation
            ' 
            Me.icbImageLocation.Location = New System.Drawing.Point(425, 109)
            Me.icbImageLocation.Name = "icbImageLocation"
            Me.icbImageLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbImageLocation.Properties.DropDownRows = 12
            Me.icbImageLocation.Size = New System.Drawing.Size(181, 20)
            Me.icbImageLocation.StyleController = Me.layoutControl1
            Me.icbImageLocation.TabIndex = 6
            AddHandler Me.icbImageLocation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbImageLocation_SelectedIndexChanged)
            ' 
            ' simpleButton3
            ' 
            Me.simpleButton3.Location = New System.Drawing.Point(510, 380)
            Me.simpleButton3.Name = "simpleButton3"
            Me.simpleButton3.Size = New System.Drawing.Size(96, 22)
            Me.simpleButton3.StyleController = Me.layoutControl1
            Me.simpleButton3.TabIndex = 8
            Me.simpleButton3.Text = "Clear log"
            AddHandler Me.simpleButton3.Click, New System.EventHandler(AddressOf Me.simpleButton3_Click)
            ' 
            ' icbImage
            ' 
            Me.icbImage.Location = New System.Drawing.Point(425, 81)
            Me.icbImage.Name = "icbImage"
            Me.icbImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbImage.Properties.SmallImages = Me.svgImageCollection1
            Me.icbImage.Size = New System.Drawing.Size(181, 20)
            Me.icbImage.StyleController = Me.layoutControl1
            Me.icbImage.TabIndex = 4
            AddHandler Me.icbImage.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbImage_SelectedIndexChanged)
            ' 
            ' icbDropDownControl
            ' 
            Me.icbDropDownControl.Location = New System.Drawing.Point(425, 53)
            Me.icbDropDownControl.Name = "icbDropDownControl"
            Me.icbDropDownControl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbDropDownControl.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Popup Menu", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Popup Control Container", 1, -1)})
            Me.icbDropDownControl.Size = New System.Drawing.Size(181, 20)
            Me.icbDropDownControl.StyleController = Me.layoutControl1
            Me.icbDropDownControl.TabIndex = 2
            AddHandler Me.icbDropDownControl.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbDropDownControl_SelectedIndexChanged)
            ' 
            ' meFiringEvents
            ' 
            Me.meFiringEvents.EditValue = ""
            Me.meFiringEvents.Location = New System.Drawing.Point(300, 240)
            Me.meFiringEvents.Name = "meFiringEvents"
            Me.meFiringEvents.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.meFiringEvents.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
            Me.meFiringEvents.Properties.Appearance.Options.UseBackColor = True
            Me.meFiringEvents.Properties.Appearance.Options.UseForeColor = True
            Me.meFiringEvents.Properties.[ReadOnly] = True
            Me.meFiringEvents.Size = New System.Drawing.Size(306, 130)
            Me.meFiringEvents.StyleController = Me.layoutControl1
            Me.meFiringEvents.TabIndex = 0
            Me.meFiringEvents.TabStop = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(638, 434)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CaptionImageOptions.SvgImage = CType((resources.GetObject("layoutControlGroup2.CaptionImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.layoutControlGroup2.CaptionImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(268, 187)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(350, 227)
            Me.layoutControlGroup2.Text = "Event log"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.meFiringEvents
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(310, 140)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(310, 140)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(310, 140)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 6)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.simpleButton3
            Me.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 140)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(100, 26)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(55, 26)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(310, 26)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(268, 414)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup3.Text = "Sample"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.sampleDropDownButton
            Me.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem3.FillControlToClientArea = False
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(200, 40)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(200, 353)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.TextVisible = False
            Me.layoutControlItem3.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(268, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(350, 187)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup4.Text = "Options"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.icbDropDownControl
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(310, 26)
            Me.layoutControlItem4.Text = "DropDown Control:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.icbImage
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(310, 28)
            Me.layoutControlItem5.Text = "Image:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.icbImageLocation
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(310, 28)
            Me.layoutControlItem6.Text = "Image Location:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.icbDropDownStyle
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem7.Size = New System.Drawing.Size(310, 26)
            Me.layoutControlItem7.Text = "DropDown Arrow Style:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' popupControlContainer1
            ' 
            Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer1.Controls.Add(Me.simpleButton2)
            Me.popupControlContainer1.Controls.Add(Me.simpleButton1)
            Me.popupControlContainer1.Controls.Add(Me.timeEdit1)
            Me.popupControlContainer1.Controls.Add(Me.dateEdit1)
            Me.popupControlContainer1.Controls.Add(Me.labelControl5)
            Me.popupControlContainer1.Controls.Add(Me.labelControl4)
            Me.popupControlContainer1.Location = New System.Drawing.Point(951, 12)
            Me.popupControlContainer1.Manager = Me.barManager1
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Size = New System.Drawing.Size(220, 135)
            Me.popupControlContainer1.TabIndex = 8
            Me.popupControlContainer1.Visible = False
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Location = New System.Drawing.Point(142, 94)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(64, 24)
            Me.simpleButton2.TabIndex = 7
            Me.simpleButton2.Text = "Clear"
            AddHandler Me.simpleButton2.Click, New System.EventHandler(AddressOf Me.simpleButton2_Click)
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(76, 94)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(60, 24)
            Me.simpleButton1.TabIndex = 6
            Me.simpleButton1.Text = "Now"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' timeEdit1
            ' 
            Me.timeEdit1.EditValue = New System.DateTime(2009, 6, 22, 0, 0, 0, 0)
            Me.timeEdit1.Location = New System.Drawing.Point(76, 47)
            Me.timeEdit1.MenuManager = Me.barManager1
            Me.timeEdit1.Name = "timeEdit1"
            Me.timeEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.timeEdit1.Size = New System.Drawing.Size(130, 20)
            Me.timeEdit1.TabIndex = 5
            ' 
            ' dateEdit1
            ' 
            Me.dateEdit1.EditValue = Nothing
            Me.dateEdit1.Location = New System.Drawing.Point(76, 17)
            Me.dateEdit1.MenuManager = Me.barManager1
            Me.dateEdit1.Name = "dateEdit1"
            Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEdit1.Size = New System.Drawing.Size(130, 20)
            Me.dateEdit1.TabIndex = 4
            ' 
            ' labelControl5
            ' 
            Me.labelControl5.Location = New System.Drawing.Point(17, 50)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Size = New System.Drawing.Size(26, 13)
            Me.labelControl5.TabIndex = 3
            Me.labelControl5.Text = "Time:"
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.Location = New System.Drawing.Point(17, 20)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(27, 13)
            Me.labelControl4.TabIndex = 2
            Me.labelControl4.Text = "Date:"
            ' 
            ' ModuleDropDownButton
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ModuleDropDownButton"
            Me.Size = New System.Drawing.Size(908, 528)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModulePictureEdit_Load)
            CType((Me.icbDropDownStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbImageLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbImage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbDropDownControl.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.meFiringEvents.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupControlContainer1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            Me.popupControlContainer1.PerformLayout()
            CType((Me.timeEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit1.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private sampleDropDownButton As DevExpress.XtraEditors.DropDownButton

        Private icbImageLocation As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbImage As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbDropDownControl As DevExpress.XtraEditors.ImageComboBoxEdit

        Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private popupMenu1 As DevExpress.XtraBars.PopupMenu

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem

        Private simpleButton2 As DevExpress.XtraEditors.SimpleButton

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private timeEdit1 As DevExpress.XtraEditors.TimeEdit

        Private dateEdit1 As DevExpress.XtraEditors.DateEdit

        Private labelControl5 As DevExpress.XtraEditors.LabelControl

        Private labelControl4 As DevExpress.XtraEditors.LabelControl

        Private meFiringEvents As DevExpress.XtraEditors.MemoEdit

        Private simpleButton3 As DevExpress.XtraEditors.SimpleButton

        Private icbDropDownStyle As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private svgImageCollection2 As DevExpress.Utils.SvgImageCollection

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
