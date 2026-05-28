Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleTimeEdit

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
            Me.teMask = New DevExpress.XtraEditors.TextEdit()
            Me.timeEditSample = New DevExpress.XtraEditors.TimeEdit()
            Me.comboBoxTimeFormat = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxTimeEditStyle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.radioGroupHourFormat = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.teMask.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.timeEditSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxTimeFormat.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxTimeEditStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupHourFormat.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.teMask)
            Me.layoutControl1.Controls.Add(Me.timeEditSample)
            Me.layoutControl1.Controls.Add(Me.comboBoxTimeFormat)
            Me.layoutControl1.Controls.Add(Me.comboBoxTimeEditStyle)
            Me.layoutControl1.Controls.Add(Me.radioGroupHourFormat)
            Me.layoutControl1.Location = New System.Drawing.Point(37, 46)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(949, 204, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(541, 178)
            Me.layoutControl1.TabIndex = 3
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' teMask
            ' 
            Me.teMask.EditValue = ""
            Me.teMask.Location = New System.Drawing.Point(365, 151)
            Me.teMask.Name = "teMask"
            Me.teMask.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.teMask.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
            Me.teMask.Properties.Appearance.Options.UseBackColor = True
            Me.teMask.Properties.Appearance.Options.UseForeColor = True
            Me.teMask.Properties.[ReadOnly] = True
            Me.teMask.Size = New System.Drawing.Size(151, 20)
            Me.teMask.StyleController = Me.layoutControl1
            Me.teMask.TabIndex = 5
            ' 
            ' timeEditSample
            ' 
            Me.timeEditSample.EditValue = New System.DateTime(2005, 5, 25, 0, 0, 0, 0)
            Me.timeEditSample.Location = New System.Drawing.Point(32, 102)
            Me.timeEditSample.Name = "timeEditSample"
            Me.timeEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.timeEditSample.Properties.Mask.EditMask = "hh:mm:ss tt"
            Me.timeEditSample.Size = New System.Drawing.Size(176, 20)
            Me.timeEditSample.StyleController = Me.layoutControl1
            Me.timeEditSample.TabIndex = 0
            ' 
            ' comboBoxTimeFormat
            ' 
            Me.comboBoxTimeFormat.EditValue = "HourMinSec"
            Me.comboBoxTimeFormat.Location = New System.Drawing.Point(365, 123)
            Me.comboBoxTimeFormat.Name = "comboBoxTimeFormat"
            Me.comboBoxTimeFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxTimeFormat.Properties.Items.AddRange(New Object() {"HourMinSec", "HourMin", "Hour"})
            Me.comboBoxTimeFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxTimeFormat.Size = New System.Drawing.Size(151, 20)
            Me.comboBoxTimeFormat.StyleController = Me.layoutControl1
            Me.comboBoxTimeFormat.TabIndex = 2
            AddHandler Me.comboBoxTimeFormat.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxTimeFormat_SelectedIndexChanged)
            ' 
            ' comboBoxTimeEditStyle
            ' 
            Me.comboBoxTimeEditStyle.EditValue = "SpinButtons"
            Me.comboBoxTimeEditStyle.Location = New System.Drawing.Point(365, 53)
            Me.comboBoxTimeEditStyle.Name = "comboBoxTimeEditStyle"
            Me.comboBoxTimeEditStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxTimeEditStyle.Properties.Items.AddRange(New Object() {"SpinButtons", "TouchUI"})
            Me.comboBoxTimeEditStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxTimeEditStyle.Size = New System.Drawing.Size(151, 20)
            Me.comboBoxTimeEditStyle.StyleController = Me.layoutControl1
            Me.comboBoxTimeEditStyle.TabIndex = 0
            AddHandler Me.comboBoxTimeEditStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxTimeEditStyle_SelectedIndexChanged)
            ' 
            ' radioGroupHourFormat
            ' 
            Me.radioGroupHourFormat.EditValue = "12"
            Me.radioGroupHourFormat.Location = New System.Drawing.Point(365, 81)
            Me.radioGroupHourFormat.Name = "radioGroupHourFormat"
            Me.radioGroupHourFormat.Properties.Columns = 2
            Me.radioGroupHourFormat.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("12", "12"), New DevExpress.XtraEditors.Controls.RadioGroupItem("24", "24")})
            Me.radioGroupHourFormat.Size = New System.Drawing.Size(151, 34)
            Me.radioGroupHourFormat.StyleController = Me.layoutControl1
            Me.radioGroupHourFormat.TabIndex = 1
            AddHandler Me.radioGroupHourFormat.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupHourFormat_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(548, 204)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.emptySpaceItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(248, 184)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.timeEditSample
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(1, 1)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(180, 122)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 122)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(180, 1)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(180, 1)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.emptySpaceItem1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(248, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(280, 184)
            Me.layoutControlGroup3.Text = "Edit value representation"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.comboBoxTimeEditStyle
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(240, 26)
            Me.layoutControlItem2.Text = "Time edit style:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(73, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.radioGroupHourFormat
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(240, 42)
            Me.layoutControlItem3.Text = "Hour format:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(73, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.comboBoxTimeFormat
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 68)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(240, 28)
            Me.layoutControlItem4.Text = "Time format:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(73, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.teMask
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem5.Size = New System.Drawing.Size(240, 26)
            Me.layoutControlItem5.Text = "Edit mask:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(73, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 122)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(240, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(240, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ModuleTimeEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleTimeEdit"
            Me.Size = New System.Drawing.Size(842, 547)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleTimeEdit_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.teMask.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.timeEditSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxTimeFormat.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxTimeEditStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupHourFormat.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private timeEditSample As DevExpress.XtraEditors.TimeEdit

        Private comboBoxTimeFormat As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxTimeEditStyle As DevExpress.XtraEditors.ComboBoxEdit

        Private radioGroupHourFormat As DevExpress.XtraEditors.RadioGroup

        Private teMask As DevExpress.XtraEditors.TextEdit

        Private components As System.ComponentModel.Container = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
