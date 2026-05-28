Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleColorEdit

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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.seClear = New DevExpress.XtraEditors.SimpleButton()
            Me.ceAsInteger = New DevExpress.XtraEditors.CheckEdit()
            Me.seAdd = New DevExpress.XtraEditors.SimpleButton()
            Me.ceShowColorDialog = New DevExpress.XtraEditors.CheckEdit()
            Me.colorEditSample = New DevExpress.XtraEditors.ColorEdit()
            Me.icbColorText = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbColorAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbColorDialogType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceAsInteger.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowColorDialog.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorEditSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbColorText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbColorAlignment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbColorDialogType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.seClear)
            Me.layoutControl1.Controls.Add(Me.ceAsInteger)
            Me.layoutControl1.Controls.Add(Me.seAdd)
            Me.layoutControl1.Controls.Add(Me.ceShowColorDialog)
            Me.layoutControl1.Controls.Add(Me.colorEditSample)
            Me.layoutControl1.Controls.Add(Me.icbColorText)
            Me.layoutControl1.Controls.Add(Me.icbColorAlignment)
            Me.layoutControl1.Controls.Add(Me.icbColorDialogType)
            Me.layoutControl1.Location = New System.Drawing.Point(33, 27)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1056, 7, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(548, 285)
            Me.layoutControl1.TabIndex = 4
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' seClear
            ' 
            Me.seClear.Enabled = False
            Me.seClear.Location = New System.Drawing.Point(412, 265)
            Me.seClear.Name = "seClear"
            Me.seClear.Size = New System.Drawing.Size(104, 22)
            Me.seClear.StyleController = Me.layoutControl1
            Me.seClear.TabIndex = 1
            Me.seClear.Text = "Clear"
            AddHandler Me.seClear.Click, New System.EventHandler(AddressOf Me.seClear_Click)
            ' 
            ' ceAsInteger
            ' 
            Me.ceAsInteger.Location = New System.Drawing.Point(300, 161)
            Me.ceAsInteger.Name = "ceAsInteger"
            Me.ceAsInteger.Properties.Caption = "Store Color as Integer"
            Me.ceAsInteger.Size = New System.Drawing.Size(216, 20)
            Me.ceAsInteger.StyleController = Me.layoutControl1
            Me.ceAsInteger.TabIndex = 18
            AddHandler Me.ceAsInteger.CheckedChanged, New System.EventHandler(AddressOf Me.ceIsInteger_CheckedChanged)
            ' 
            ' seAdd
            ' 
            Me.seAdd.Location = New System.Drawing.Point(300, 265)
            Me.seAdd.Name = "seAdd"
            Me.seAdd.Size = New System.Drawing.Size(108, 22)
            Me.seAdd.StyleController = Me.layoutControl1
            Me.seAdd.TabIndex = 0
            Me.seAdd.Text = "Create"
            AddHandler Me.seAdd.Click, New System.EventHandler(AddressOf Me.seAdd_Click)
            ' 
            ' ceShowColorDialog
            ' 
            Me.ceShowColorDialog.Location = New System.Drawing.Point(300, 133)
            Me.ceShowColorDialog.Name = "ceShowColorDialog"
            Me.ceShowColorDialog.Properties.Caption = "Show Color Dialog"
            Me.ceShowColorDialog.Size = New System.Drawing.Size(216, 20)
            Me.ceShowColorDialog.StyleController = Me.layoutControl1
            Me.ceShowColorDialog.TabIndex = 17
            AddHandler Me.ceShowColorDialog.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowColorDialog_CheckedChanged)
            ' 
            ' colorEditSample
            ' 
            Me.colorEditSample.EditValue = System.Drawing.Color.FromArgb((CInt(((CByte((192)))))), (CInt(((CByte((192)))))), (CInt(((CByte((255)))))))
            Me.colorEditSample.Location = New System.Drawing.Point(32, 160)
            Me.colorEditSample.Name = "colorEditSample"
            Me.colorEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorEditSample.Properties.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Simple
            Me.colorEditSample.Size = New System.Drawing.Size(196, 20)
            Me.colorEditSample.StyleController = Me.layoutControl1
            Me.colorEditSample.TabIndex = 0
            ' 
            ' icbColorText
            ' 
            Me.icbColorText.EditValue = "imageComboBoxEdit2"
            Me.icbColorText.Location = New System.Drawing.Point(400, 81)
            Me.icbColorText.Name = "icbColorText"
            Me.icbColorText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbColorText.Size = New System.Drawing.Size(116, 20)
            Me.icbColorText.StyleController = Me.layoutControl1
            Me.icbColorText.TabIndex = 16
            AddHandler Me.icbColorText.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbColorText_SelectedIndexChanged)
            ' 
            ' icbColorAlignment
            ' 
            Me.icbColorAlignment.EditValue = "imageComboBoxEdit1"
            Me.icbColorAlignment.Location = New System.Drawing.Point(400, 53)
            Me.icbColorAlignment.Name = "icbColorAlignment"
            Me.icbColorAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbColorAlignment.Size = New System.Drawing.Size(116, 20)
            Me.icbColorAlignment.StyleController = Me.layoutControl1
            Me.icbColorAlignment.TabIndex = 15
            AddHandler Me.icbColorAlignment.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbColorAlignment_SelectedIndexChanged)
            ' 
            ' icbColorDialogType
            ' 
            Me.icbColorDialogType.Location = New System.Drawing.Point(400, 107)
            Me.icbColorDialogType.Name = "icbColorDialogType"
            Me.icbColorDialogType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbColorDialogType.Size = New System.Drawing.Size(116, 20)
            Me.icbColorDialogType.StyleController = Me.layoutControl1
            Me.icbColorDialogType.TabIndex = 19
            AddHandler Me.icbColorDialogType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbColorDialogType_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(548, 319)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(268, 299)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.colorEditSample
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(200, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(200, 238)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.emptySpaceItem1, Me.layoutControlItem8})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(268, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(260, 212)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbColorAlignment
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(220, 26)
            Me.layoutControlItem2.Text = "Color Alignment:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(88, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbColorText
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem3.Text = "Color Text:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(88, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceShowColorDialog
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 78)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceAsInteger
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 106)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem5.Size = New System.Drawing.Size(220, 26)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 132)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(220, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(220, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.icbColorDialogType
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(220, 24)
            Me.layoutControlItem8.Text = "Color Dialog Type:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(88, 13)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem7})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(268, 212)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(260, 87)
            Me.layoutControlGroup4.Text = "Custom Colors"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seAdd
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(112, 26)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.seClear
            Me.layoutControlItem7.Location = New System.Drawing.Point(112, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(108, 26)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' ModuleColorEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleColorEdit"
            Me.Size = New System.Drawing.Size(864, 515)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleColorEdit_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceAsInteger.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowColorDialog.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorEditSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbColorText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbColorAlignment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbColorDialogType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private colorEditSample As DevExpress.XtraEditors.ColorEdit

        Private icbColorAlignment As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbColorText As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceShowColorDialog As DevExpress.XtraEditors.CheckEdit

        Private seAdd As DevExpress.XtraEditors.SimpleButton

        Private seClear As DevExpress.XtraEditors.SimpleButton

        Private ceAsInteger As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private icbColorDialogType As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    End Class
End Namespace
