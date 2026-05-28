Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleFontEdit

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
            Me.cbFontSize = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.ceShowSymbolPreview = New DevExpress.XtraEditors.CheckEdit()
            Me.fontEditSample = New DevExpress.XtraEditors.FontEdit()
            Me.seRUItemCount = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cbFontSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowSymbolPreview.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.fontEditSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seRUItemCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.cbFontSize)
            Me.layoutControl1.Controls.Add(Me.ceShowSymbolPreview)
            Me.layoutControl1.Controls.Add(Me.fontEditSample)
            Me.layoutControl1.Controls.Add(Me.seRUItemCount)
            Me.layoutControl1.Location = New System.Drawing.Point(36, 36)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1017, 247, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(504, 266)
            Me.layoutControl1.TabIndex = 3
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cbFontSize
            ' 
            Me.cbFontSize.AllowDrop = True
            Me.cbFontSize.Location = New System.Drawing.Point(446, 81)
            Me.cbFontSize.Name = "cbFontSize"
            Me.cbFontSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbFontSize.Properties.DropDownRows = 12
            Me.cbFontSize.Properties.Items.AddRange(New Object() {"7", "8", "9", "10", "12", "14", "16", "20", "25", "30"})
            Me.cbFontSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbFontSize.Size = New System.Drawing.Size(70, 20)
            Me.cbFontSize.StyleController = Me.layoutControl1
            Me.cbFontSize.TabIndex = 1
            AddHandler Me.cbFontSize.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbFontSize_SelectedIndexChanged)
            ' 
            ' ceShowSymbolPreview
            ' 
            Me.ceShowSymbolPreview.Location = New System.Drawing.Point(300, 109)
            Me.ceShowSymbolPreview.Name = "ceShowSymbolPreview"
            Me.ceShowSymbolPreview.Properties.Caption = "Show Symbol Font Preview"
            Me.ceShowSymbolPreview.Size = New System.Drawing.Size(216, 20)
            Me.ceShowSymbolPreview.StyleController = Me.layoutControl1
            Me.ceShowSymbolPreview.TabIndex = 2
            AddHandler Me.ceShowSymbolPreview.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowSymbolPreview_CheckedChanged)
            ' 
            ' fontEditSample
            ' 
            Me.fontEditSample.Location = New System.Drawing.Point(32, 125)
            Me.fontEditSample.Name = "fontEditSample"
            Me.fontEditSample.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.fontEditSample.Properties.AppearanceDropDown.Options.UseFont = True
            Me.fontEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.fontEditSample.Size = New System.Drawing.Size(196, 20)
            Me.fontEditSample.StyleController = Me.layoutControl1
            Me.fontEditSample.TabIndex = 0
            ' 
            ' seRUItemCount
            ' 
            Me.seRUItemCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seRUItemCount.Location = New System.Drawing.Point(446, 53)
            Me.seRUItemCount.Name = "seRUItemCount"
            Me.seRUItemCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seRUItemCount.Properties.IsFloatValue = False
            Me.seRUItemCount.Properties.Mask.EditMask = "N00"
            Me.seRUItemCount.Properties.MaxValue = New Decimal(New Integer() {28, 0, 0, 0})
            Me.seRUItemCount.Size = New System.Drawing.Size(70, 20)
            Me.seRUItemCount.StyleController = Me.layoutControl1
            Me.seRUItemCount.TabIndex = 0
            AddHandler Me.seRUItemCount.EditValueChanged, New System.EventHandler(AddressOf Me.seRUItemCount_EditValueChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(548, 249)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(268, 229)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.fontEditSample
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(200, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(200, 168)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.emptySpaceItem1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(268, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(260, 229)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.AllowHtmlStringInCaption = True
            Me.layoutControlItem2.Control = Me.seRUItemCount
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(220, 26)
            Me.layoutControlItem2.Text = "Recently Used Item <b>Count</b>:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(134, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.AllowHtmlStringInCaption = True
            Me.layoutControlItem3.Control = Me.cbFontSize
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem3.Text = "DropDown Font <b>Size</b>:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(134, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceShowSymbolPreview
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem4.Size = New System.Drawing.Size(220, 26)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 80)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(220, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(220, 88)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ModuleFontEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleFontEdit"
            Me.Size = New System.Drawing.Size(792, 555)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleCalcEdit_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cbFontSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowSymbolPreview.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.fontEditSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seRUItemCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private seRUItemCount As DevExpress.XtraEditors.SpinEdit

        Private ceShowSymbolPreview As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private fontEditSample As DevExpress.XtraEditors.FontEdit

        Private cbFontSize As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
