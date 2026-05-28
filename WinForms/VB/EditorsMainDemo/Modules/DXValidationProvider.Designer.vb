Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleDXValidationProvider

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
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.manualValidate = New DevExpress.XtraEditors.CheckEdit()
            Me.icbIconAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.autoValidateCheck = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.notEqualsComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.btnValidate = New DevExpress.XtraEditors.SimpleButton()
            Me.compareTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.notEmptyTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.customTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.containsTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.rangeTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.dxValidationProvider1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.manualValidate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbIconAlignment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.autoValidateCheck.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.notEqualsComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.compareTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.notEmptyTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.customTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.containsTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rangeTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.manualValidate)
            Me.layoutControl1.Controls.Add(Me.icbIconAlignment)
            Me.layoutControl1.Controls.Add(Me.autoValidateCheck)
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Controls.Add(Me.notEqualsComboBoxEdit)
            Me.layoutControl1.Controls.Add(Me.btnValidate)
            Me.layoutControl1.Controls.Add(Me.compareTextEdit)
            Me.layoutControl1.Controls.Add(Me.notEmptyTextEdit)
            Me.layoutControl1.Controls.Add(Me.customTextEdit)
            Me.layoutControl1.Controls.Add(Me.containsTextEdit)
            Me.layoutControl1.Controls.Add(Me.rangeTextEdit)
            Me.layoutControl1.Location = New System.Drawing.Point(24, 41)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1219, 335, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(768, 235)
            Me.layoutControl1.TabIndex = 7
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' manualValidate
            ' 
            Me.manualValidate.Location = New System.Drawing.Point(619, 45)
            Me.manualValidate.Name = "manualValidate"
            Me.manualValidate.Properties.Caption = "manual"
            Me.manualValidate.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.manualValidate.Properties.RadioGroupIndex = 1
            Me.manualValidate.Size = New System.Drawing.Size(108, 20)
            Me.manualValidate.StyleController = Me.layoutControl1
            Me.manualValidate.TabIndex = 1
            Me.manualValidate.TabStop = False
            AddHandler Me.manualValidate.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' icbIconAlignment
            ' 
            Me.icbIconAlignment.Location = New System.Drawing.Point(582, 123)
            Me.icbIconAlignment.Name = "icbIconAlignment"
            Me.icbIconAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbIconAlignment.Size = New System.Drawing.Size(145, 20)
            Me.icbIconAlignment.StyleController = Me.layoutControl1
            Me.icbIconAlignment.TabIndex = 2
            AddHandler Me.icbIconAlignment.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbIconAlignment_SelectedIndexChanged)
            ' 
            ' autoValidateCheck
            ' 
            Me.autoValidateCheck.Location = New System.Drawing.Point(619, 70)
            Me.autoValidateCheck.Name = "autoValidateCheck"
            Me.autoValidateCheck.Properties.Caption = "auto"
            Me.autoValidateCheck.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.autoValidateCheck.Properties.RadioGroupIndex = 1
            Me.autoValidateCheck.Size = New System.Drawing.Size(108, 20)
            Me.autoValidateCheck.StyleController = Me.layoutControl1
            Me.autoValidateCheck.TabIndex = 1
            Me.autoValidateCheck.TabStop = False
            AddHandler Me.autoValidateCheck.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(507, 49)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(79, 13)
            Me.labelControl1.StyleController = Me.layoutControl1
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "Validation Mode:"
            ' 
            ' notEqualsComboBoxEdit
            ' 
            Me.notEqualsComboBoxEdit.Location = New System.Drawing.Point(12, 180)
            Me.notEqualsComboBoxEdit.Name = "notEqualsComboBoxEdit"
            Me.notEqualsComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.notEqualsComboBoxEdit.Properties.Items.AddRange(New Object() {"Project 1", "Project 2", "Project 3"})
            Me.notEqualsComboBoxEdit.Size = New System.Drawing.Size(167, 20)
            Me.notEqualsComboBoxEdit.StyleController = Me.layoutControl1
            Me.notEqualsComboBoxEdit.TabIndex = 4
            ' 
            ' btnValidate
            ' 
            Me.btnValidate.Location = New System.Drawing.Point(525, 189)
            Me.btnValidate.Name = "btnValidate"
            Me.btnValidate.Size = New System.Drawing.Size(184, 22)
            Me.btnValidate.StyleController = Me.layoutControl1
            Me.btnValidate.TabIndex = 0
            Me.btnValidate.Text = "Validate"
            AddHandler Me.btnValidate.Click, New System.EventHandler(AddressOf Me.btnValidate_Click)
            ' 
            ' compareTextEdit
            ' 
            Me.compareTextEdit.Location = New System.Drawing.Point(12, 140)
            Me.compareTextEdit.Name = "compareTextEdit"
            Me.compareTextEdit.Size = New System.Drawing.Size(167, 20)
            Me.compareTextEdit.StyleController = Me.layoutControl1
            Me.compareTextEdit.TabIndex = 5
            ' 
            ' notEmptyTextEdit
            ' 
            Me.notEmptyTextEdit.Location = New System.Drawing.Point(12, 20)
            Me.notEmptyTextEdit.Name = "notEmptyTextEdit"
            Me.notEmptyTextEdit.Size = New System.Drawing.Size(167, 20)
            Me.notEmptyTextEdit.StyleController = Me.layoutControl1
            Me.notEmptyTextEdit.TabIndex = 1
            ' 
            ' customTextEdit
            ' 
            Me.customTextEdit.Location = New System.Drawing.Point(12, 220)
            Me.customTextEdit.Name = "customTextEdit"
            Me.customTextEdit.Size = New System.Drawing.Size(167, 20)
            Me.customTextEdit.StyleController = Me.layoutControl1
            Me.customTextEdit.TabIndex = 6
            ' 
            ' containsTextEdit
            ' 
            Me.containsTextEdit.Location = New System.Drawing.Point(12, 100)
            Me.containsTextEdit.Name = "containsTextEdit"
            Me.containsTextEdit.Size = New System.Drawing.Size(167, 20)
            Me.containsTextEdit.StyleController = Me.layoutControl1
            Me.containsTextEdit.TabIndex = 3
            ' 
            ' rangeTextEdit
            ' 
            Me.rangeTextEdit.Location = New System.Drawing.Point(12, 60)
            Me.rangeTextEdit.Name = "rangeTextEdit"
            Me.rangeTextEdit.Properties.Mask.EditMask = "d"
            Me.rangeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.rangeTextEdit.Size = New System.Drawing.Size(167, 20)
            Me.rangeTextEdit.StyleController = Me.layoutControl1
            Me.rangeTextEdit.TabIndex = 2
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlGroup2, Me.layoutControlItem5, Me.layoutControlItem4, Me.layoutControlItem6, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(751, 253)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem1.Control = Me.notEmptyTextEdit
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10)
            Me.layoutControlItem1.Size = New System.Drawing.Size(455, 40)
            Me.layoutControlItem1.Text = "Not empty"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(272, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.layoutControlItem2.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem2.Control = Me.rangeTextEdit
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10)
            Me.layoutControlItem2.Size = New System.Drawing.Size(455, 40)
            Me.layoutControlItem2.Text = "1 - 100"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(272, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.layoutControlItem3.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem3.Control = Me.containsTextEdit
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10)
            Me.layoutControlItem3.Size = New System.Drawing.Size(455, 40)
            Me.layoutControlItem3.Text = "Contains '@'"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Right
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(272, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7, Me.layoutControlGroup3, Me.emptySpaceItem2, Me.layoutControlItem11, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(455, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(276, 233)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(30, 2, 2, 2)
            Me.layoutControlGroup2.Text = "Validation"
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.btnValidate
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 144)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 20)
            Me.layoutControlItem7.Size = New System.Drawing.Size(224, 44)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10})
            Me.layoutControlGroup3.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition1.Width = 50R
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition2.Width = 50R
            Me.layoutControlGroup3.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1, columnDefinition2})
            rowDefinition1.Height = 50R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition2.Height = 50R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent
            Me.layoutControlGroup3.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1, rowDefinition2})
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(224, 51)
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.labelControl1
            Me.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.layoutControlItem8.FillControlToClientArea = False
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem8.MaxSize = New System.Drawing.Size(0, 17)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(83, 17)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(112, 25)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.TextVisible = False
            Me.layoutControlItem8.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.autoValidateCheck
            Me.layoutControlItem9.Location = New System.Drawing.Point(112, 25)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem9.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem9.Size = New System.Drawing.Size(112, 26)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.manualValidate
            Me.layoutControlItem10.Location = New System.Drawing.Point(112, 0)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem10.Size = New System.Drawing.Size(112, 25)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 51)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(224, 27)
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.icbIconAlignment
            Me.layoutControlItem11.FillControlToClientArea = False
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 78)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(224, 24)
            Me.layoutControlItem11.Text = "Icon Alignment:"
            Me.layoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(75, 13)
            Me.layoutControlItem11.TextToControlDistance = 0
            Me.layoutControlItem11.TrimClientAreaToControl = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 102)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(200, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(224, 42)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.layoutControlItem5.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem5.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.layoutControlItem5.Control = Me.compareTextEdit
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10)
            Me.layoutControlItem5.Size = New System.Drawing.Size(455, 40)
            Me.layoutControlItem5.Text = "Equals to the first editor's value (case sensitive)"
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Right
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(272, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.layoutControlItem4.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem4.Control = Me.notEqualsComboBoxEdit
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 160)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10)
            Me.layoutControlItem4.Size = New System.Drawing.Size(455, 40)
            Me.layoutControlItem4.Text = "Not Equals '(select)'"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Right
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(272, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.layoutControlItem6.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem6.Control = Me.customTextEdit
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 200)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItem6.Size = New System.Drawing.Size(455, 32)
            Me.layoutControlItem6.Text = "Dr./Mr./Mrs./Miss/Ms. + (Person name)"
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Right
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(272, 13)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 232)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(415, 1)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(455, 1)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ModuleDXValidationProvider
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleDXValidationProvider"
            Me.Size = New System.Drawing.Size(882, 565)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleDXValidationProvider_Load)
            CType((Me.dxValidationProvider1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.manualValidate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbIconAlignment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.autoValidateCheck.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.notEqualsComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.compareTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.notEmptyTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.customTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.containsTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rangeTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider

        Private manualValidate As DevExpress.XtraEditors.CheckEdit

        Private autoValidateCheck As DevExpress.XtraEditors.CheckEdit

        Private btnValidate As DevExpress.XtraEditors.SimpleButton

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private notEmptyTextEdit As DevExpress.XtraEditors.TextEdit

        Private rangeTextEdit As DevExpress.XtraEditors.TextEdit

        Private compareTextEdit As DevExpress.XtraEditors.TextEdit

        Private containsTextEdit As DevExpress.XtraEditors.TextEdit

        Private customTextEdit As DevExpress.XtraEditors.TextEdit

        Private notEqualsComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit

        Private icbIconAlignment As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
