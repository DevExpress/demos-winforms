Namespace DevExpress.ApplicationUI.Demos.VisualEffects

    Partial Class ModuleValidationHints

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.VisualEffects.ModuleValidationHints))
            Me.dataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.checkButton = New DevExpress.XtraEditors.SimpleButton()
            Me.teName = New DevExpress.XtraEditors.TextEdit()
            Me.customerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.teUserName = New DevExpress.XtraEditors.TextEdit()
            Me.tePassword = New DevExpress.XtraEditors.TextEdit()
            Me.teAge = New DevExpress.XtraEditors.TextEdit()
            Me.teEMail = New DevExpress.XtraEditors.TextEdit()
            Me.tePhone = New DevExpress.XtraEditors.TextEdit()
            Me.teAddress = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForUserName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForPassword = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAge = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForEMail = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForPhone = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAddress = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItemBottom = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItemRigth = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForCheckButton = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.adornerUIManager = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
            Me.vhName = New DevExpress.Utils.VisualEffects.ValidationHint()
            Me.vhUserName = New DevExpress.Utils.VisualEffects.ValidationHint()
            Me.vhPassword = New DevExpress.Utils.VisualEffects.ValidationHint()
            Me.vhAge = New DevExpress.Utils.VisualEffects.ValidationHint()
            Me.vhEMail = New DevExpress.Utils.VisualEffects.ValidationHint()
            Me.vhPhone = New DevExpress.Utils.VisualEffects.ValidationHint()
            Me.vhAddress = New DevExpress.Utils.VisualEffects.ValidationHint()
            CType((Me.dataLayoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl.SuspendLayout()
            CType((Me.teName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.customerBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teUserName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tePassword.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teAge.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teEMail.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tePhone.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teAddress.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForUserName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForPassword), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForAge), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForEMail), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForPhone), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForAddress), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItemBottom), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItemRigth), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForCheckButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.adornerUIManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataLayoutControl
            ' 
            Me.dataLayoutControl.Controls.Add(Me.checkButton)
            Me.dataLayoutControl.Controls.Add(Me.teName)
            Me.dataLayoutControl.Controls.Add(Me.teUserName)
            Me.dataLayoutControl.Controls.Add(Me.tePassword)
            Me.dataLayoutControl.Controls.Add(Me.teAge)
            Me.dataLayoutControl.Controls.Add(Me.teEMail)
            Me.dataLayoutControl.Controls.Add(Me.tePhone)
            Me.dataLayoutControl.Controls.Add(Me.teAddress)
            Me.dataLayoutControl.DataSource = Me.customerBindingSource
            Me.dataLayoutControl.Location = New System.Drawing.Point(190, 49)
            Me.dataLayoutControl.Name = "dataLayoutControl"
            Me.dataLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1152, 249, 450, 350)
            Me.dataLayoutControl.OptionsView.UseParentAutoScaleFactor = True
            Me.dataLayoutControl.Root = Me.layoutControlGroup1
            Me.dataLayoutControl.Size = New System.Drawing.Size(597, 289)
            Me.dataLayoutControl.TabIndex = 8
            Me.dataLayoutControl.Text = "dataLayoutControl"
            ' 
            ' checkButton
            ' 
            Me.checkButton.Location = New System.Drawing.Point(188, 248)
            Me.checkButton.Name = "checkButton"
            Me.checkButton.Size = New System.Drawing.Size(56, 29)
            Me.checkButton.StyleController = Me.dataLayoutControl
            Me.checkButton.TabIndex = 9
            Me.checkButton.Text = "Check"
            AddHandler Me.checkButton.Click, New System.EventHandler(AddressOf Me.OnCheckButtonClick)
            ' 
            ' teName
            ' 
            Me.teName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customerBindingSource, "Name", True))
            Me.teName.Location = New System.Drawing.Point(80, 15)
            Me.teName.Name = "teName"
            Me.teName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.teName.Size = New System.Drawing.Size(161, 20)
            Me.teName.StyleController = Me.dataLayoutControl
            Me.teName.TabIndex = 4
            AddHandler Me.teName.InvalidValue, New DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(AddressOf Me.OnInvalidValue)
            ' 
            ' customerBindingSource
            ' 
            Me.customerBindingSource.DataSource = GetType(DevExpress.ApplicationUI.Demos.VisualEffects.Customer)
            ' 
            ' teUserName
            ' 
            Me.teUserName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customerBindingSource, "UserName", True))
            Me.teUserName.Location = New System.Drawing.Point(80, 45)
            Me.teUserName.Name = "teUserName"
            Me.teUserName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.teUserName.Size = New System.Drawing.Size(161, 20)
            Me.teUserName.StyleController = Me.dataLayoutControl
            Me.teUserName.TabIndex = 5
            AddHandler Me.teUserName.InvalidValue, New DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(AddressOf Me.OnInvalidValue)
            ' 
            ' tePassword
            ' 
            Me.tePassword.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customerBindingSource, "Password", True))
            Me.tePassword.Location = New System.Drawing.Point(80, 75)
            Me.tePassword.Name = "tePassword"
            Me.tePassword.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.tePassword.Properties.UseSystemPasswordChar = True
            Me.tePassword.Size = New System.Drawing.Size(161, 20)
            Me.tePassword.StyleController = Me.dataLayoutControl
            Me.tePassword.TabIndex = 6
            AddHandler Me.tePassword.InvalidValue, New DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(AddressOf Me.OnInvalidValue)
            ' 
            ' teAge
            ' 
            Me.teAge.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customerBindingSource, "Age", True))
            Me.teAge.Location = New System.Drawing.Point(80, 105)
            Me.teAge.Name = "teAge"
            Me.teAge.Properties.Appearance.Options.UseTextOptions = True
            Me.teAge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.teAge.Properties.Mask.EditMask = "[0-9]{1,3}"
            Me.teAge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            Me.teAge.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.teAge.Size = New System.Drawing.Size(161, 20)
            Me.teAge.StyleController = Me.dataLayoutControl
            Me.teAge.TabIndex = 7
            AddHandler Me.teAge.InvalidValue, New DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(AddressOf Me.OnInvalidValue)
            ' 
            ' teEMail
            ' 
            Me.teEMail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customerBindingSource, "EMail", True))
            Me.teEMail.Location = New System.Drawing.Point(80, 135)
            Me.teEMail.Name = "teEMail"
            Me.teEMail.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.teEMail.Properties.Mask.EditMask = "(\w|[\.\-])+@(\w|[\-]+\.)*(\w|[\-]){2,63}\.[a-zA-Z]{2,4}"
            Me.teEMail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            Me.teEMail.Size = New System.Drawing.Size(161, 20)
            Me.teEMail.StyleController = Me.dataLayoutControl
            Me.teEMail.TabIndex = 8
            AddHandler Me.teEMail.InvalidValue, New DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(AddressOf Me.OnInvalidValue)
            ' 
            ' tePhone
            ' 
            Me.tePhone.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customerBindingSource, "Phone", True))
            Me.tePhone.Location = New System.Drawing.Point(80, 165)
            Me.tePhone.Name = "tePhone"
            Me.tePhone.Properties.Mask.EditMask = "+0(999) 000-0000"
            Me.tePhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
            Me.tePhone.Size = New System.Drawing.Size(161, 20)
            Me.tePhone.StyleController = Me.dataLayoutControl
            Me.tePhone.TabIndex = 9
            AddHandler Me.tePhone.InvalidValue, New DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(AddressOf Me.OnInvalidValue)
            ' 
            ' teAddress
            ' 
            Me.teAddress.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.customerBindingSource, "Address", True))
            Me.teAddress.Location = New System.Drawing.Point(80, 195)
            Me.teAddress.Name = "teAddress"
            Me.teAddress.Size = New System.Drawing.Size(161, 20)
            Me.teAddress.StyleController = Me.dataLayoutControl
            Me.teAddress.TabIndex = 10
            AddHandler Me.teAddress.InvalidValue, New DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(AddressOf Me.OnInvalidValue)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 10
            Me.layoutControlGroup1.Size = New System.Drawing.Size(597, 289)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForName, Me.ItemForUserName, Me.ItemForPassword, Me.ItemForAge, Me.ItemForEMail, Me.ItemForPhone, Me.ItemForAddress, Me.emptySpaceItemBottom, Me.emptySpaceItemRigth, Me.ItemForCheckButton, Me.emptySpaceItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(577, 269)
            ' 
            ' ItemForName
            ' 
            Me.ItemForName.Control = Me.teName
            Me.ItemForName.Location = New System.Drawing.Point(0, 0)
            Me.ItemForName.MaxSize = New System.Drawing.Size(236, 30)
            Me.ItemForName.MinSize = New System.Drawing.Size(236, 30)
            Me.ItemForName.Name = "ItemForName"
            Me.ItemForName.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForName.Size = New System.Drawing.Size(236, 30)
            Me.ItemForName.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForName.Text = "Name:"
            Me.ItemForName.TextSize = New System.Drawing.Size(55, 13)
            ' 
            ' ItemForUserName
            ' 
            Me.ItemForUserName.Control = Me.teUserName
            Me.ItemForUserName.Location = New System.Drawing.Point(0, 30)
            Me.ItemForUserName.MaxSize = New System.Drawing.Size(236, 30)
            Me.ItemForUserName.MinSize = New System.Drawing.Size(236, 30)
            Me.ItemForUserName.Name = "ItemForUserName"
            Me.ItemForUserName.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForUserName.Size = New System.Drawing.Size(236, 30)
            Me.ItemForUserName.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForUserName.Text = "User name:"
            Me.ItemForUserName.TextSize = New System.Drawing.Size(55, 13)
            ' 
            ' ItemForPassword
            ' 
            Me.ItemForPassword.Control = Me.tePassword
            Me.ItemForPassword.Location = New System.Drawing.Point(0, 60)
            Me.ItemForPassword.MaxSize = New System.Drawing.Size(236, 30)
            Me.ItemForPassword.MinSize = New System.Drawing.Size(236, 30)
            Me.ItemForPassword.Name = "ItemForPassword"
            Me.ItemForPassword.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForPassword.Size = New System.Drawing.Size(236, 30)
            Me.ItemForPassword.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForPassword.Text = "Password:"
            Me.ItemForPassword.TextSize = New System.Drawing.Size(55, 13)
            ' 
            ' ItemForAge
            ' 
            Me.ItemForAge.Control = Me.teAge
            Me.ItemForAge.Location = New System.Drawing.Point(0, 90)
            Me.ItemForAge.MaxSize = New System.Drawing.Size(236, 30)
            Me.ItemForAge.MinSize = New System.Drawing.Size(236, 30)
            Me.ItemForAge.Name = "ItemForAge"
            Me.ItemForAge.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForAge.Size = New System.Drawing.Size(236, 30)
            Me.ItemForAge.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForAge.Text = "Age:"
            Me.ItemForAge.TextSize = New System.Drawing.Size(55, 13)
            ' 
            ' ItemForEMail
            ' 
            Me.ItemForEMail.Control = Me.teEMail
            Me.ItemForEMail.Location = New System.Drawing.Point(0, 120)
            Me.ItemForEMail.MaxSize = New System.Drawing.Size(236, 30)
            Me.ItemForEMail.MinSize = New System.Drawing.Size(236, 30)
            Me.ItemForEMail.Name = "ItemForEMail"
            Me.ItemForEMail.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForEMail.Size = New System.Drawing.Size(236, 30)
            Me.ItemForEMail.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForEMail.Text = "E-mail:"
            Me.ItemForEMail.TextSize = New System.Drawing.Size(55, 13)
            ' 
            ' ItemForPhone
            ' 
            Me.ItemForPhone.Control = Me.tePhone
            Me.ItemForPhone.Location = New System.Drawing.Point(0, 150)
            Me.ItemForPhone.MaxSize = New System.Drawing.Size(236, 30)
            Me.ItemForPhone.MinSize = New System.Drawing.Size(236, 30)
            Me.ItemForPhone.Name = "ItemForPhone"
            Me.ItemForPhone.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForPhone.Size = New System.Drawing.Size(236, 30)
            Me.ItemForPhone.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForPhone.Text = "Phone:"
            Me.ItemForPhone.TextSize = New System.Drawing.Size(55, 13)
            ' 
            ' ItemForAddress
            ' 
            Me.ItemForAddress.Control = Me.teAddress
            Me.ItemForAddress.Location = New System.Drawing.Point(0, 180)
            Me.ItemForAddress.MaxSize = New System.Drawing.Size(236, 30)
            Me.ItemForAddress.MinSize = New System.Drawing.Size(236, 30)
            Me.ItemForAddress.Name = "ItemForAddress"
            Me.ItemForAddress.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForAddress.Size = New System.Drawing.Size(236, 30)
            Me.ItemForAddress.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForAddress.Text = "Address:"
            Me.ItemForAddress.TextSize = New System.Drawing.Size(55, 13)
            ' 
            ' emptySpaceItemBottom
            ' 
            Me.emptySpaceItemBottom.Location = New System.Drawing.Point(0, 210)
            Me.emptySpaceItemBottom.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItemBottom.Name = "emptySpaceItemBottom"
            Me.emptySpaceItemBottom.Size = New System.Drawing.Size(236, 26)
            Me.emptySpaceItemBottom.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' emptySpaceItemRigth
            ' 
            Me.emptySpaceItemRigth.Location = New System.Drawing.Point(236, 0)
            Me.emptySpaceItemRigth.Name = "emptySpaceItemRigth"
            Me.emptySpaceItemRigth.Size = New System.Drawing.Size(341, 269)
            ' 
            ' ItemForCheckButton
            ' 
            Me.ItemForCheckButton.Control = Me.checkButton
            Me.ItemForCheckButton.Location = New System.Drawing.Point(176, 236)
            Me.ItemForCheckButton.MinSize = New System.Drawing.Size(42, 26)
            Me.ItemForCheckButton.Name = "ItemForCheckButton"
            Me.ItemForCheckButton.Size = New System.Drawing.Size(60, 33)
            Me.ItemForCheckButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForCheckButton.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 236)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(176, 33)
            ' 
            ' adornerUIManager
            ' 
            Me.adornerUIManager.Elements.Add(Me.vhName)
            Me.adornerUIManager.Elements.Add(Me.vhUserName)
            Me.adornerUIManager.Elements.Add(Me.vhPassword)
            Me.adornerUIManager.Elements.Add(Me.vhAge)
            Me.adornerUIManager.Elements.Add(Me.vhEMail)
            Me.adornerUIManager.Elements.Add(Me.vhPhone)
            Me.adornerUIManager.Elements.Add(Me.vhAddress)
            Me.adornerUIManager.Owner = Me
            Me.adornerUIManager.ValidationHintAppearances.IndeterminateState.Font = New System.Drawing.Font("Tahoma", 10F)
            Me.adornerUIManager.ValidationHintAppearances.IndeterminateState.Options.UseFont = True
            Me.adornerUIManager.ValidationHintAppearances.InvalidState.Font = New System.Drawing.Font("Tahoma", 10F)
            Me.adornerUIManager.ValidationHintAppearances.InvalidState.Options.UseFont = True
            Me.adornerUIManager.ValidationHintAppearances.ValidState.Font = New System.Drawing.Font("Tahoma", 10F)
            Me.adornerUIManager.ValidationHintAppearances.ValidState.Options.UseFont = True
            Me.adornerUIManager.ValidationHintProperties.InvalidState.SvgImage = CType((resources.GetObject("adornerUIManager.ValidationHintProperties.InvalidState.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.adornerUIManager.ValidationHintProperties.InvalidState.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.adornerUIManager.ValidationHintProperties.ValidState.SvgImage = CType((resources.GetObject("adornerUIManager.ValidationHintProperties.ValidState.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.adornerUIManager.ValidationHintProperties.ValidState.SvgImageSize = New System.Drawing.Size(16, 16)
            ' 
            ' vhName
            ' 
            Me.vhName.Properties.IndeterminateState.ImageOptions.SvgImage = CType((resources.GetObject("vhName.Properties.IndeterminateState.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.vhName.Properties.IndeterminateState.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.vhName.Properties.IndeterminateState.Text = "Required!"
            Me.vhName.TargetElement = Me.teName
            ' 
            ' vhUserName
            ' 
            Me.vhUserName.Properties.IndeterminateState.ImageOptions.SvgImage = CType((resources.GetObject("vhUserName.Properties.IndeterminateState.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.vhUserName.Properties.IndeterminateState.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.vhUserName.Properties.IndeterminateState.Text = "Required!"
            Me.vhUserName.TargetElement = Me.teUserName
            ' 
            ' vhPassword
            ' 
            Me.vhPassword.Properties.IndeterminateState.ImageOptions.SvgImage = CType((resources.GetObject("vhPassword.Properties.IndeterminateState.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.vhPassword.Properties.IndeterminateState.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.vhPassword.Properties.IndeterminateState.Text = "Required!"
            Me.vhPassword.TargetElement = Me.tePassword
            ' 
            ' vhAge
            ' 
            Me.vhAge.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Indeterminate
            Me.vhAge.TargetElement = Me.teAge
            ' 
            ' vhEMail
            ' 
            Me.vhEMail.Properties.IndeterminateState.ImageOptions.SvgImage = CType((resources.GetObject("vhEMail.Properties.IndeterminateState.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.vhEMail.Properties.IndeterminateState.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.vhEMail.Properties.IndeterminateState.Text = "Required!"
            Me.vhEMail.TargetElement = Me.teEMail
            ' 
            ' vhPhone
            ' 
            Me.vhPhone.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Indeterminate
            Me.vhPhone.TargetElement = Me.tePhone
            ' 
            ' vhAddress
            ' 
            Me.vhAddress.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Indeterminate
            Me.vhAddress.TargetElement = Me.teAddress
            ' 
            ' ModuleValidationHints
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 10F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dataLayoutControl)
            Me.Name = "ModuleValidationHints"
            Me.Padding = New System.Windows.Forms.Padding(6, 0, 0, 6)
            Me.Size = New System.Drawing.Size(716, 403)
            CType((Me.dataLayoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl.ResumeLayout(False)
            CType((Me.teName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.customerBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teUserName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tePassword.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teAge.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teEMail.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tePhone.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teAddress.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForUserName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForPassword), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForAge), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForEMail), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForPhone), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForAddress), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItemBottom), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItemRigth), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForCheckButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.adornerUIManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private teName As DevExpress.XtraEditors.TextEdit

        Private customerBindingSource As System.Windows.Forms.BindingSource

        Private teUserName As DevExpress.XtraEditors.TextEdit

        Private tePassword As DevExpress.XtraEditors.TextEdit

        Private teAge As DevExpress.XtraEditors.TextEdit

        Private teEMail As DevExpress.XtraEditors.TextEdit

        Private tePhone As DevExpress.XtraEditors.TextEdit

        Private teAddress As DevExpress.XtraEditors.TextEdit

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private ItemForName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForUserName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForPassword As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForAge As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForEMail As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForPhone As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForAddress As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItemBottom As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItemRigth As DevExpress.XtraLayout.EmptySpaceItem

        Private adornerUIManager As DevExpress.Utils.VisualEffects.AdornerUIManager

        Private vhName As DevExpress.Utils.VisualEffects.ValidationHint

        Private vhUserName As DevExpress.Utils.VisualEffects.ValidationHint

        Private vhPassword As DevExpress.Utils.VisualEffects.ValidationHint

        Private vhAge As DevExpress.Utils.VisualEffects.ValidationHint

        Private vhEMail As DevExpress.Utils.VisualEffects.ValidationHint

        Private vhPhone As DevExpress.Utils.VisualEffects.ValidationHint

        Private vhAddress As DevExpress.Utils.VisualEffects.ValidationHint

        Private checkButton As DevExpress.XtraEditors.SimpleButton

        Private ItemForCheckButton As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
