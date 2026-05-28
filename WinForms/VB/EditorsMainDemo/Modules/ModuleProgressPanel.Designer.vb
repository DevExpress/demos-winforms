Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleProgressPanel

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
            Me.spinRingDiameter = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.spinFrameInterval = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxLineElementType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.colorEditElementColor = New DevExpress.XtraEditors.ColorEdit()
            Me.spinLineHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.progressPanelSample = New DevExpress.XtraWaitForm.ProgressPanel()
            Me.spinSpeed = New DevExpress.XtraEditors.SpinEdit()
            Me.spinAcceleration = New DevExpress.XtraEditors.SpinEdit()
            Me.spinFrameCount = New DevExpress.XtraEditors.SpinEdit()
            Me.spinElementCount = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxAnimationType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.spinRingDiameter.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.spinFrameInterval.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxLineElementType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorEditElementColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinLineHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinSpeed.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinAcceleration.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinFrameCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinElementCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxAnimationType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spinRingDiameter
            ' 
            Me.spinRingDiameter.EditValue = New Decimal(New Integer() {40, 0, 0, 0})
            Me.spinRingDiameter.Location = New System.Drawing.Point(598, 409)
            Me.spinRingDiameter.Name = "spinRingDiameter"
            Me.spinRingDiameter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinRingDiameter.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinRingDiameter.Properties.IsFloatValue = False
            Me.spinRingDiameter.Properties.Mask.EditMask = "N00"
            Me.spinRingDiameter.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinRingDiameter.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinRingDiameter.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinRingDiameter.Size = New System.Drawing.Size(98, 20)
            Me.spinRingDiameter.StyleController = Me.layoutControl1
            Me.spinRingDiameter.TabIndex = 6
            AddHandler Me.spinRingDiameter.EditValueChanged, New System.EventHandler(AddressOf Me.spinRingDiameter_EditValueChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.spinRingDiameter)
            Me.layoutControl1.Controls.Add(Me.spinFrameInterval)
            Me.layoutControl1.Controls.Add(Me.comboBoxLineElementType)
            Me.layoutControl1.Controls.Add(Me.colorEditElementColor)
            Me.layoutControl1.Controls.Add(Me.spinLineHeight)
            Me.layoutControl1.Controls.Add(Me.progressPanelSample)
            Me.layoutControl1.Controls.Add(Me.spinSpeed)
            Me.layoutControl1.Controls.Add(Me.spinAcceleration)
            Me.layoutControl1.Controls.Add(Me.spinFrameCount)
            Me.layoutControl1.Controls.Add(Me.spinElementCount)
            Me.layoutControl1.Controls.Add(Me.comboBoxAnimationType)
            Me.layoutControl1.Location = New System.Drawing.Point(30, 55)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1026, 242, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(628, 508)
            Me.layoutControl1.TabIndex = 13
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' spinFrameInterval
            ' 
            Me.spinFrameInterval.EditValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinFrameInterval.Location = New System.Drawing.Point(598, 88)
            Me.spinFrameInterval.Name = "spinFrameInterval"
            Me.spinFrameInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinFrameInterval.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinFrameInterval.Properties.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinFrameInterval.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinFrameInterval.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.spinFrameInterval.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinFrameInterval.Size = New System.Drawing.Size(98, 20)
            Me.spinFrameInterval.StyleController = Me.layoutControl1
            Me.spinFrameInterval.TabIndex = 14
            AddHandler Me.spinFrameInterval.EditValueChanged, New System.EventHandler(AddressOf Me.spinFrameInterval_EditValueChanged)
            ' 
            ' comboBoxLineElementType
            ' 
            Me.comboBoxLineElementType.EditValue = "Circle"
            Me.comboBoxLineElementType.Enabled = False
            Me.comboBoxLineElementType.Location = New System.Drawing.Point(598, 334)
            Me.comboBoxLineElementType.Name = "comboBoxLineElementType"
            Me.comboBoxLineElementType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxLineElementType.Properties.Items.AddRange(New Object() {"Circle", "Rectangle", "Triangle"})
            Me.comboBoxLineElementType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxLineElementType.Size = New System.Drawing.Size(98, 20)
            Me.comboBoxLineElementType.StyleController = Me.layoutControl1
            Me.comboBoxLineElementType.TabIndex = 2
            AddHandler Me.comboBoxLineElementType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxLineElementType_SelectedIndexChanged)
            ' 
            ' colorEditElementColor
            ' 
            Me.colorEditElementColor.EditValue = System.Drawing.Color.Empty
            Me.colorEditElementColor.Location = New System.Drawing.Point(598, 235)
            Me.colorEditElementColor.Name = "colorEditElementColor"
            Me.colorEditElementColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorEditElementColor.Size = New System.Drawing.Size(98, 20)
            Me.colorEditElementColor.StyleController = Me.layoutControl1
            Me.colorEditElementColor.TabIndex = 19
            AddHandler Me.colorEditElementColor.EditValueChanged, New System.EventHandler(AddressOf Me.colorEditElementColor_EditValueChanged)
            ' 
            ' spinLineHeight
            ' 
            Me.spinLineHeight.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinLineHeight.Enabled = False
            Me.spinLineHeight.Location = New System.Drawing.Point(598, 310)
            Me.spinLineHeight.Name = "spinLineHeight"
            Me.spinLineHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinLineHeight.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinLineHeight.Properties.IsFloatValue = False
            Me.spinLineHeight.Properties.Mask.EditMask = "N00"
            Me.spinLineHeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinLineHeight.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinLineHeight.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinLineHeight.Size = New System.Drawing.Size(98, 20)
            Me.spinLineHeight.StyleController = Me.layoutControl1
            Me.spinLineHeight.TabIndex = 6
            AddHandler Me.spinLineHeight.EditValueChanged, New System.EventHandler(AddressOf Me.spinLineHeight_EditValueChanged)
            ' 
            ' progressPanelSample
            ' 
            Me.progressPanelSample.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.progressPanelSample.Appearance.Options.UseBackColor = True
            Me.progressPanelSample.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.progressPanelSample.Location = New System.Drawing.Point(20, 41)
            Me.progressPanelSample.Name = "progressPanelSample"
            Me.progressPanelSample.Size = New System.Drawing.Size(356, 430)
            Me.progressPanelSample.StyleController = Me.layoutControl1
            Me.progressPanelSample.TabIndex = 0
            Me.progressPanelSample.Text = "progressPanel1"
            Me.progressPanelSample.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring
            ' 
            ' spinSpeed
            ' 
            Me.spinSpeed.EditValue = New Decimal(New Integer() {55, 0, 0, 65536})
            Me.spinSpeed.Location = New System.Drawing.Point(598, 211)
            Me.spinSpeed.Name = "spinSpeed"
            Me.spinSpeed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinSpeed.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinSpeed.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.spinSpeed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinSpeed.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinSpeed.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinSpeed.Size = New System.Drawing.Size(98, 20)
            Me.spinSpeed.StyleController = Me.layoutControl1
            Me.spinSpeed.TabIndex = 6
            AddHandler Me.spinSpeed.EditValueChanged, New System.EventHandler(AddressOf Me.spinSpeed_EditValueChanged)
            ' 
            ' spinAcceleration
            ' 
            Me.spinAcceleration.EditValue = New Decimal(New Integer() {70, 0, 0, 65536})
            Me.spinAcceleration.Location = New System.Drawing.Point(598, 187)
            Me.spinAcceleration.Name = "spinAcceleration"
            Me.spinAcceleration.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinAcceleration.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinAcceleration.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.spinAcceleration.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinAcceleration.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinAcceleration.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinAcceleration.Size = New System.Drawing.Size(98, 20)
            Me.spinAcceleration.StyleController = Me.layoutControl1
            Me.spinAcceleration.TabIndex = 5
            AddHandler Me.spinAcceleration.EditValueChanged, New System.EventHandler(AddressOf Me.spinAcceleration_EditValueChanged)
            ' 
            ' spinFrameCount
            ' 
            Me.spinFrameCount.EditValue = New Decimal(New Integer() {38000, 0, 0, 0})
            Me.spinFrameCount.Location = New System.Drawing.Point(598, 64)
            Me.spinFrameCount.Name = "spinFrameCount"
            Me.spinFrameCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinFrameCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinFrameCount.Properties.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinFrameCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinFrameCount.Properties.MaxValue = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.spinFrameCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinFrameCount.Size = New System.Drawing.Size(98, 20)
            Me.spinFrameCount.StyleController = Me.layoutControl1
            Me.spinFrameCount.TabIndex = 12
            AddHandler Me.spinFrameCount.EditValueChanged, New System.EventHandler(AddressOf Me.spinFrameCount_EditValueChanged)
            ' 
            ' spinElementCount
            ' 
            Me.spinElementCount.EditValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinElementCount.Location = New System.Drawing.Point(598, 163)
            Me.spinElementCount.Name = "spinElementCount"
            Me.spinElementCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinElementCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinElementCount.Properties.IsFloatValue = False
            Me.spinElementCount.Properties.Mask.EditMask = "N00"
            Me.spinElementCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinElementCount.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinElementCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinElementCount.Size = New System.Drawing.Size(98, 20)
            Me.spinElementCount.StyleController = Me.layoutControl1
            Me.spinElementCount.TabIndex = 4
            AddHandler Me.spinElementCount.EditValueChanged, New System.EventHandler(AddressOf Me.spinElementCount_EditValueChanged)
            ' 
            ' comboBoxAnimationType
            ' 
            Me.comboBoxAnimationType.EditValue = "Ring"
            Me.comboBoxAnimationType.Location = New System.Drawing.Point(598, 40)
            Me.comboBoxAnimationType.Name = "comboBoxAnimationType"
            Me.comboBoxAnimationType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxAnimationType.Properties.Items.AddRange(New Object() {"Default", "Line", "Ring", "Bar"})
            Me.comboBoxAnimationType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxAnimationType.Size = New System.Drawing.Size(98, 20)
            Me.comboBoxAnimationType.StyleController = Me.layoutControl1
            Me.comboBoxAnimationType.TabIndex = 0
            AddHandler Me.comboBoxAnimationType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxAnimationType_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4, Me.layoutControlGroup5, Me.layoutControlGroup6})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(724, 491)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(412, 479)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.progressPanelSample
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(360, 20)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(360, 434)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(412, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 8, 8)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(300, 123)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 10)
            Me.layoutControlGroup3.Text = "ProgressPanel properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.comboBoxAnimationType
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(260, 24)
            Me.layoutControlItem2.Text = "Wait animation type:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(146, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.spinFrameCount
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(260, 24)
            Me.layoutControlItem3.Text = "Frame count:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(146, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.spinFrameInterval
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(260, 24)
            Me.layoutControlItem4.Text = "Frame interval:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(146, 13)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(412, 123)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 8, 8)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(300, 147)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 10)
            Me.layoutControlGroup4.Text = "Animation Properties"
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.spinElementCount
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(260, 24)
            Me.layoutControlItem5.Text = "Animation element count:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(146, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.spinAcceleration
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(260, 24)
            Me.layoutControlItem6.Text = "Animation acceleration:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(146, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.spinSpeed
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(260, 24)
            Me.layoutControlItem7.Text = "Animation speed:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(146, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.colorEditElementColor
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(260, 24)
            Me.layoutControlItem8.Text = "Animation element color:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(146, 13)
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem9, Me.layoutControlItem10})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(412, 270)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 8, 8)
            Me.layoutControlGroup5.Size = New System.Drawing.Size(300, 99)
            Me.layoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 10)
            Me.layoutControlGroup5.Text = "Line animation properties"
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.spinLineHeight
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(260, 24)
            Me.layoutControlItem9.Text = "Line animation element height:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(146, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.comboBoxLineElementType
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(260, 24)
            Me.layoutControlItem10.Text = "Line animation element type:"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(146, 13)
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem11, Me.emptySpaceItem1})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(412, 369)
            Me.layoutControlGroup6.Name = "layoutControlGroup6"
            Me.layoutControlGroup6.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 8, 8)
            Me.layoutControlGroup6.Size = New System.Drawing.Size(300, 110)
            Me.layoutControlGroup6.Text = "Ring animation properties"
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.spinRingDiameter
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(260, 24)
            Me.layoutControlItem11.Text = "Ring animation diameter:"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(146, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(260, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(260, 43)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ModuleProgressPanel
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleProgressPanel"
            Me.Size = New System.Drawing.Size(879, 690)
            CType((Me.spinRingDiameter.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.spinFrameInterval.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxLineElementType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorEditElementColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinLineHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinSpeed.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinAcceleration.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinFrameCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinElementCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxAnimationType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private spinRingDiameter As DevExpress.XtraEditors.SpinEdit

        Private comboBoxLineElementType As DevExpress.XtraEditors.ComboBoxEdit

        Private spinLineHeight As DevExpress.XtraEditors.SpinEdit

        Private spinSpeed As DevExpress.XtraEditors.SpinEdit

        Private spinAcceleration As DevExpress.XtraEditors.SpinEdit

        Private spinElementCount As DevExpress.XtraEditors.SpinEdit

        Private comboBoxAnimationType As DevExpress.XtraEditors.ComboBoxEdit

        Private progressPanelSample As DevExpress.XtraWaitForm.ProgressPanel

        Private spinFrameInterval As DevExpress.XtraEditors.SpinEdit

        Private spinFrameCount As DevExpress.XtraEditors.SpinEdit

        Private colorEditElementColor As DevExpress.XtraEditors.ColorEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
