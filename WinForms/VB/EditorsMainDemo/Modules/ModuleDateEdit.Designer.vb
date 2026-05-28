Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleDateEdit

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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceSynchronizing = New DevExpress.XtraEditors.CheckEdit()
            Me.icbEditMask = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbShowVistaClock = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceShowWeekNumbers = New DevExpress.XtraEditors.CheckEdit()
            Me.dateEditSample = New DevExpress.XtraEditors.DateEdit()
            Me.ceShowToday = New DevExpress.XtraEditors.CheckEdit()
            Me.icbVistaDisplayMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceShowClear = New DevExpress.XtraEditors.CheckEdit()
            Me.icbWeekNumberRule = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbAllowNullInput = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceSynchronizing.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbEditMask.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbShowVistaClock.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowWeekNumbers.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEditSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEditSample.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowToday.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbVistaDisplayMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowClear.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbWeekNumberRule.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbAllowNullInput.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceSynchronizing)
            Me.layoutControl1.Controls.Add(Me.icbEditMask)
            Me.layoutControl1.Controls.Add(Me.icbShowVistaClock)
            Me.layoutControl1.Controls.Add(Me.ceShowWeekNumbers)
            Me.layoutControl1.Controls.Add(Me.dateEditSample)
            Me.layoutControl1.Controls.Add(Me.ceShowToday)
            Me.layoutControl1.Controls.Add(Me.icbVistaDisplayMode)
            Me.layoutControl1.Controls.Add(Me.ceShowClear)
            Me.layoutControl1.Controls.Add(Me.icbWeekNumberRule)
            Me.layoutControl1.Controls.Add(Me.icbAllowNullInput)
            Me.layoutControl1.Location = New System.Drawing.Point(46, 45)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(962, 178, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(538, 408)
            Me.layoutControl1.TabIndex = 4
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceSynchronizing
            ' 
            Me.ceSynchronizing.EditValue = True
            Me.ceSynchronizing.Location = New System.Drawing.Point(280, 352)
            Me.ceSynchronizing.Name = "ceSynchronizing"
            Me.ceSynchronizing.Properties.Caption = "Synchronize edit mask with display format"
            Me.ceSynchronizing.Size = New System.Drawing.Size(226, 20)
            Me.ceSynchronizing.StyleController = Me.layoutControl1
            Me.ceSynchronizing.TabIndex = 1
            AddHandler Me.ceSynchronizing.CheckedChanged, New System.EventHandler(AddressOf Me.ceSynchronizing_CheckedChanged)
            ' 
            ' icbEditMask
            ' 
            Me.icbEditMask.EditValue = "imageComboBoxEdit1"
            Me.icbEditMask.Location = New System.Drawing.Point(399, 324)
            Me.icbEditMask.Name = "icbEditMask"
            Me.icbEditMask.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbEditMask.Size = New System.Drawing.Size(107, 20)
            Me.icbEditMask.StyleController = Me.layoutControl1
            Me.icbEditMask.TabIndex = 0
            AddHandler Me.icbEditMask.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbEditMask_SelectedIndexChanged)
            ' 
            ' icbShowVistaClock
            ' 
            Me.icbShowVistaClock.EditValue = "imageComboBoxEdit1"
            Me.icbShowVistaClock.Location = New System.Drawing.Point(399, 81)
            Me.icbShowVistaClock.Name = "icbShowVistaClock"
            Me.icbShowVistaClock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowVistaClock.Size = New System.Drawing.Size(107, 20)
            Me.icbShowVistaClock.StyleController = Me.layoutControl1
            Me.icbShowVistaClock.TabIndex = 18
            AddHandler Me.icbShowVistaClock.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbShowVistaClock_SelectedIndexChanged)
            ' 
            ' ceShowWeekNumbers
            ' 
            Me.ceShowWeekNumbers.Location = New System.Drawing.Point(280, 221)
            Me.ceShowWeekNumbers.Name = "ceShowWeekNumbers"
            Me.ceShowWeekNumbers.Properties.Caption = "Show week numbers"
            Me.ceShowWeekNumbers.Size = New System.Drawing.Size(226, 20)
            Me.ceShowWeekNumbers.StyleController = Me.layoutControl1
            Me.ceShowWeekNumbers.TabIndex = 5
            AddHandler Me.ceShowWeekNumbers.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowWeekNumbers_CheckedChanged)
            ' 
            ' dateEditSample
            ' 
            Me.dateEditSample.EditValue = New System.DateTime(2005, 5, 30, 0, 0, 0, 0)
            Me.dateEditSample.Location = New System.Drawing.Point(32, 204)
            Me.dateEditSample.Name = "dateEditSample"
            Me.dateEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEditSample.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEditSample.Size = New System.Drawing.Size(176, 20)
            Me.dateEditSample.StyleController = Me.layoutControl1
            Me.dateEditSample.TabIndex = 0
            ' 
            ' ceShowToday
            ' 
            Me.ceShowToday.Location = New System.Drawing.Point(280, 193)
            Me.ceShowToday.Name = "ceShowToday"
            Me.ceShowToday.Properties.Caption = "Show Today button"
            Me.ceShowToday.Size = New System.Drawing.Size(226, 20)
            Me.ceShowToday.StyleController = Me.layoutControl1
            Me.ceShowToday.TabIndex = 4
            AddHandler Me.ceShowToday.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowToday_CheckedChanged)
            ' 
            ' icbVistaDisplayMode
            ' 
            Me.icbVistaDisplayMode.EditValue = "imageComboBoxEdit1"
            Me.icbVistaDisplayMode.Location = New System.Drawing.Point(399, 53)
            Me.icbVistaDisplayMode.Name = "icbVistaDisplayMode"
            Me.icbVistaDisplayMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbVistaDisplayMode.Size = New System.Drawing.Size(107, 20)
            Me.icbVistaDisplayMode.StyleController = Me.layoutControl1
            Me.icbVistaDisplayMode.TabIndex = 0
            AddHandler Me.icbVistaDisplayMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbVistaDisplayMode_SelectedIndexChanged)
            ' 
            ' ceShowClear
            ' 
            Me.ceShowClear.Location = New System.Drawing.Point(280, 165)
            Me.ceShowClear.Name = "ceShowClear"
            Me.ceShowClear.Properties.Caption = "Show Clear button"
            Me.ceShowClear.Size = New System.Drawing.Size(226, 20)
            Me.ceShowClear.StyleController = Me.layoutControl1
            Me.ceShowClear.TabIndex = 3
            AddHandler Me.ceShowClear.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowClear_CheckedChanged)
            ' 
            ' icbWeekNumberRule
            ' 
            Me.icbWeekNumberRule.EditValue = "imageComboBoxEdit1"
            Me.icbWeekNumberRule.Location = New System.Drawing.Point(399, 137)
            Me.icbWeekNumberRule.Name = "icbWeekNumberRule"
            Me.icbWeekNumberRule.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbWeekNumberRule.Size = New System.Drawing.Size(107, 20)
            Me.icbWeekNumberRule.StyleController = Me.layoutControl1
            Me.icbWeekNumberRule.TabIndex = 2
            AddHandler Me.icbWeekNumberRule.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbWeekNumberRule_SelectedIndexChanged)
            ' 
            ' icbAllowNullInput
            ' 
            Me.icbAllowNullInput.EditValue = "imageComboBoxEdit1"
            Me.icbAllowNullInput.Location = New System.Drawing.Point(399, 109)
            Me.icbAllowNullInput.Name = "icbAllowNullInput"
            Me.icbAllowNullInput.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbAllowNullInput.Size = New System.Drawing.Size(107, 20)
            Me.icbAllowNullInput.StyleController = Me.layoutControl1
            Me.icbAllowNullInput.TabIndex = 1
            AddHandler Me.icbAllowNullInput.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbAllowNullInput_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(538, 408)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(248, 388)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.dateEditSample
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(180, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(180, 327)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(248, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(270, 271)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbVistaDisplayMode
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(230, 26)
            Me.layoutControlItem2.Text = "Calendar View:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(107, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbShowVistaClock
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(230, 28)
            Me.layoutControlItem3.Text = "Calendar Time Editing:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(107, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.icbAllowNullInput
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(230, 28)
            Me.layoutControlItem4.Text = "Allow Null Input:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(107, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.icbWeekNumberRule
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(230, 28)
            Me.layoutControlItem5.Text = "Week number rule:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(107, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ceShowClear
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 110)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(230, 28)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.ceShowToday
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 138)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem7.Size = New System.Drawing.Size(230, 28)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.ceShowWeekNumbers
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 166)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem8.Size = New System.Drawing.Size(230, 26)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem9, Me.layoutControlItem10, Me.emptySpaceItem1})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(248, 271)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(270, 117)
            Me.layoutControlGroup4.Text = "Mask"
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.icbEditMask
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem9.Size = New System.Drawing.Size(230, 26)
            Me.layoutControlItem9.Text = "Edit mask:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(107, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.ceSynchronizing
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem10.Size = New System.Drawing.Size(230, 26)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 52)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(230, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(230, 4)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ModuleDateEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleDateEdit"
            Me.Size = New System.Drawing.Size(965, 616)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleDateEdit_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceSynchronizing.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbEditMask.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbShowVistaClock.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowWeekNumbers.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEditSample.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEditSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowToday.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbVistaDisplayMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowClear.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbWeekNumberRule.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbAllowNullInput.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dateEditSample As DevExpress.XtraEditors.DateEdit

        Private icbAllowNullInput As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbWeekNumberRule As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceShowClear As DevExpress.XtraEditors.CheckEdit

        Private ceShowToday As DevExpress.XtraEditors.CheckEdit

        Private ceShowWeekNumbers As DevExpress.XtraEditors.CheckEdit

        Private icbEditMask As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceSynchronizing As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private icbVistaDisplayMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbShowVistaClock As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
