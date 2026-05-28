Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleTimeSpanEdit

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
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleTimeSpanEdit))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbEditStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.tseMaxValue = New DevExpress.XtraEditors.TimeSpanEdit()
            Me.tseMinValue = New DevExpress.XtraEditors.TimeSpanEdit()
            Me.cbDisplayFormat = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.teDisplayFormatString = New DevExpress.XtraEditors.TextEdit()
            Me.ceUseAdvancingCaret = New DevExpress.XtraEditors.CheckEdit()
            Me.lbValue = New DevExpress.XtraEditors.LabelControl()
            Me.ceAllowNegativeValue = New DevExpress.XtraEditors.CheckEdit()
            Me.timeSpanEdit1 = New DevExpress.XtraEditors.TimeSpanEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cbEditStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tseMaxValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tseMinValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbDisplayFormat.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teDisplayFormatString.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceUseAdvancingCaret.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowNegativeValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.timeSpanEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.cbEditStyle)
            Me.layoutControl1.Controls.Add(Me.tseMaxValue)
            Me.layoutControl1.Controls.Add(Me.tseMinValue)
            Me.layoutControl1.Controls.Add(Me.cbDisplayFormat)
            Me.layoutControl1.Controls.Add(Me.teDisplayFormatString)
            Me.layoutControl1.Controls.Add(Me.ceUseAdvancingCaret)
            Me.layoutControl1.Controls.Add(Me.lbValue)
            Me.layoutControl1.Controls.Add(Me.ceAllowNegativeValue)
            Me.layoutControl1.Controls.Add(Me.timeSpanEdit1)
            Me.layoutControl1.Location = New System.Drawing.Point(35, 20)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 155, 650, 703)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(644, 471)
            Me.layoutControl1.TabIndex = 9
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cbEditStyle
            ' 
            Me.cbEditStyle.Location = New System.Drawing.Point(442, 151)
            Me.cbEditStyle.Name = "cbEditStyle"
            Me.cbEditStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbEditStyle.Size = New System.Drawing.Size(170, 20)
            Me.cbEditStyle.StyleController = Me.layoutControl1
            Me.cbEditStyle.TabIndex = 31
            ' 
            ' tseMaxValue
            ' 
            Me.tseMaxValue.EditValue = Nothing
            Me.tseMaxValue.Location = New System.Drawing.Point(442, 127)
            Me.tseMaxValue.Name = "tseMaxValue"
            Me.tseMaxValue.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.tseMaxValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.tseMaxValue.Properties.MaskSettings.[Set]("mask", "d.hh:mm:ss.f3")
            Me.tseMaxValue.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.SpinButtons
            Me.tseMaxValue.Size = New System.Drawing.Size(170, 20)
            Me.tseMaxValue.StyleController = Me.layoutControl1
            Me.tseMaxValue.TabIndex = 30
            ' 
            ' tseMinValue
            ' 
            Me.tseMinValue.EditValue = Nothing
            Me.tseMinValue.Location = New System.Drawing.Point(442, 103)
            Me.tseMinValue.Name = "tseMinValue"
            Me.tseMinValue.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.tseMinValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.tseMinValue.Properties.MaskSettings.[Set]("mask", "d.hh:mm:ss.f3")
            Me.tseMinValue.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.SpinButtons
            Me.tseMinValue.Size = New System.Drawing.Size(170, 20)
            Me.tseMinValue.StyleController = Me.layoutControl1
            Me.tseMinValue.TabIndex = 29
            ' 
            ' cbDisplayFormat
            ' 
            Me.cbDisplayFormat.Location = New System.Drawing.Point(442, 175)
            Me.cbDisplayFormat.Name = "cbDisplayFormat"
            Me.cbDisplayFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbDisplayFormat.Size = New System.Drawing.Size(170, 20)
            Me.cbDisplayFormat.StyleController = Me.layoutControl1
            Me.cbDisplayFormat.TabIndex = 6
            ' 
            ' teDisplayFormatString
            ' 
            Me.teDisplayFormatString.EditValue = ""
            Me.teDisplayFormatString.Location = New System.Drawing.Point(442, 199)
            Me.teDisplayFormatString.Name = "teDisplayFormatString"
            Me.teDisplayFormatString.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.teDisplayFormatString.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
            Me.teDisplayFormatString.Properties.Appearance.Options.UseBackColor = True
            Me.teDisplayFormatString.Properties.Appearance.Options.UseForeColor = True
            Me.teDisplayFormatString.Properties.[ReadOnly] = True
            Me.teDisplayFormatString.Size = New System.Drawing.Size(170, 20)
            Me.teDisplayFormatString.StyleController = Me.layoutControl1
            Me.teDisplayFormatString.TabIndex = 5
            ' 
            ' ceUseAdvancingCaret
            ' 
            Me.ceUseAdvancingCaret.Location = New System.Drawing.Point(344, 79)
            Me.ceUseAdvancingCaret.Name = "ceUseAdvancingCaret"
            Me.ceUseAdvancingCaret.Properties.Caption = "Use Advancing Caret"
            Me.ceUseAdvancingCaret.Size = New System.Drawing.Size(268, 20)
            Me.ceUseAdvancingCaret.StyleController = Me.layoutControl1
            Me.ceUseAdvancingCaret.TabIndex = 23
            Me.ceUseAdvancingCaret.Tag = "useAdvancingCaret"
            ' 
            ' lbValue
            ' 
            Me.lbValue.Appearance.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.lbValue.Appearance.Options.UseFont = True
            Me.lbValue.Appearance.Options.UseTextOptions = True
            Me.lbValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbValue.Location = New System.Drawing.Point(32, 168)
            Me.lbValue.Name = "lbValue"
            Me.lbValue.Size = New System.Drawing.Size(240, 96)
            Me.lbValue.StyleController = Me.layoutControl1
            Me.lbValue.TabIndex = 0
            ' 
            ' ceAllowNegativeValue
            ' 
            Me.ceAllowNegativeValue.EditValue = True
            Me.ceAllowNegativeValue.Location = New System.Drawing.Point(344, 53)
            Me.ceAllowNegativeValue.MinimumSize = New System.Drawing.Size(250, 0)
            Me.ceAllowNegativeValue.Name = "ceAllowNegativeValue"
            Me.ceAllowNegativeValue.Properties.Caption = "Allow Negative Value"
            Me.ceAllowNegativeValue.Size = New System.Drawing.Size(268, 20)
            Me.ceAllowNegativeValue.StyleController = Me.layoutControl1
            Me.ceAllowNegativeValue.TabIndex = 19
            Me.ceAllowNegativeValue.Tag = "allowNegativeValue"
            ' 
            ' timeSpanEdit1
            ' 
            Me.timeSpanEdit1.EditValue = System.TimeSpan.Parse("00:00:00")
            Me.timeSpanEdit1.Location = New System.Drawing.Point(32, 54)
            Me.timeSpanEdit1.Name = "timeSpanEdit1"
            Me.timeSpanEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.timeSpanEdit1.Size = New System.Drawing.Size(240, 20)
            Me.timeSpanEdit1.StyleController = Me.layoutControl1
            Me.timeSpanEdit1.TabIndex = 0
            AddHandler Me.timeSpanEdit1.EditValueChanged, New System.EventHandler(AddressOf Me.OnTimeSpanEditEditValueChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.layoutControlGroup1.Name = "Root"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition1.Width = 312R
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition2.Width = 312R
            Me.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1, columnDefinition2})
            rowDefinition1.Height = 115R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition2.Height = 336R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            Me.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1, rowDefinition2})
            Me.layoutControlGroup1.Size = New System.Drawing.Size(644, 471)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(312, 115)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 30)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.timeSpanEdit1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(244, 26)
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem13, Me.layoutControlItem7, Me.layoutControlItem11, Me.layoutControlItem2, Me.layoutControlItem10, Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(312, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlGroup3.OptionsTableLayoutItem.RowSpan = 2
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(312, 451)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceAllowNegativeValue
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(272, 26)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.tseMaxValue
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 74)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(272, 24)
            Me.layoutControlItem13.Text = "Max Value"
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(86, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.ceUseAdvancingCaret
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(272, 24)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.tseMinValue
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 50)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(272, 24)
            Me.layoutControlItem11.Text = "Min Value"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(86, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbDisplayFormat
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 122)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(272, 24)
            Me.layoutControlItem2.Text = "Time Span Format"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(86, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.teDisplayFormatString
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 146)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(272, 244)
            Me.layoutControlItem10.Text = "Edit Mask"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(86, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.cbEditStyle
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 98)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(272, 24)
            Me.layoutControlItem3.Text = "Edit Style"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(86, 13)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.CaptionImageOptions.SvgImage = CType((resources.GetObject("layoutControlGroup4.CaptionImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.layoutControlGroup4.CaptionImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem12})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 115)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(312, 336)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup4.Text = "Value"
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.lbValue
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem12.MaxSize = New System.Drawing.Size(0, 100)
            Me.layoutControlItem12.MinSize = New System.Drawing.Size(230, 100)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem12.Size = New System.Drawing.Size(244, 275)
            Me.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem12.TextVisible = False
            Me.layoutControlItem12.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup5.GroupBordersVisible = False
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20)
            Me.layoutControlGroup5.Size = New System.Drawing.Size(298, 171)
            Me.layoutControlGroup5.TextVisible = False
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup6.GroupBordersVisible = False
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem2})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup6.Name = "Root"
            Me.layoutControlGroup6.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup6.Size = New System.Drawing.Size(300, 110)
            Me.layoutControlGroup6.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(266, 76)
            ' 
            ' ModuleTimeSpanEdit
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleTimeSpanEdit"
            Me.Size = New System.Drawing.Size(957, 601)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OnModuleLoad)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cbEditStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tseMaxValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tseMinValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbDisplayFormat.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teDisplayFormatString.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceUseAdvancingCaret.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowNegativeValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.timeSpanEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private teDisplayFormatString As DevExpress.XtraEditors.TextEdit

        Private lbValue As DevExpress.XtraEditors.LabelControl

        Private ceAllowNegativeValue As DevExpress.XtraEditors.CheckEdit

        Private timeSpanEdit1 As DevExpress.XtraEditors.TimeSpanEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private cbDisplayFormat As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private tseMaxValue As DevExpress.XtraEditors.TimeSpanEdit

        Private tseMinValue As DevExpress.XtraEditors.TimeSpanEdit

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private ceUseAdvancingCaret As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private cbEditStyle As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
