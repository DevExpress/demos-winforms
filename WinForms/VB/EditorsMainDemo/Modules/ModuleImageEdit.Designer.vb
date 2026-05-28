Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleImageEdit

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleImageEdit))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceCustomIcons = New DevExpress.XtraEditors.CheckEdit()
            Me.ceMenu = New DevExpress.XtraEditors.CheckEdit()
            Me.cePopupSizeable = New DevExpress.XtraEditors.CheckEdit()
            Me.imageEditSample = New DevExpress.XtraEditors.ImageEdit()
            Me.ceIcon = New DevExpress.XtraEditors.CheckEdit()
            Me.icbSizeMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceCustomIcons.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceMenu.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cePopupSizeable.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageEditSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceIcon.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbSizeMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceCustomIcons)
            Me.layoutControl1.Controls.Add(Me.ceMenu)
            Me.layoutControl1.Controls.Add(Me.cePopupSizeable)
            Me.layoutControl1.Controls.Add(Me.imageEditSample)
            Me.layoutControl1.Controls.Add(Me.ceIcon)
            Me.layoutControl1.Controls.Add(Me.icbSizeMode)
            Me.layoutControl1.Location = New System.Drawing.Point(20, 17)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1153, 273, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(506, 200)
            Me.layoutControl1.TabIndex = 3
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceCustomIcons
            ' 
            Me.ceCustomIcons.Location = New System.Drawing.Point(290, 165)
            Me.ceCustomIcons.Name = "ceCustomIcons"
            Me.ceCustomIcons.Properties.Caption = "Use custom icons"
            Me.ceCustomIcons.Size = New System.Drawing.Size(186, 20)
            Me.ceCustomIcons.StyleController = Me.layoutControl1
            Me.ceCustomIcons.TabIndex = 31
            AddHandler Me.ceCustomIcons.CheckedChanged, New System.EventHandler(AddressOf Me.ceCustomIcons_CheckedChanged)
            ' 
            ' ceMenu
            ' 
            Me.ceMenu.Location = New System.Drawing.Point(290, 109)
            Me.ceMenu.Name = "ceMenu"
            Me.ceMenu.Properties.Caption = "Show menu"
            Me.ceMenu.Size = New System.Drawing.Size(186, 20)
            Me.ceMenu.StyleController = Me.layoutControl1
            Me.ceMenu.TabIndex = 29
            AddHandler Me.ceMenu.CheckedChanged, New System.EventHandler(AddressOf Me.ceMenu_CheckedChanged)
            ' 
            ' cePopupSizeable
            ' 
            Me.cePopupSizeable.Location = New System.Drawing.Point(290, 137)
            Me.cePopupSizeable.Name = "cePopupSizeable"
            Me.cePopupSizeable.Properties.Caption = "Popup sizeable"
            Me.cePopupSizeable.Size = New System.Drawing.Size(186, 20)
            Me.cePopupSizeable.StyleController = Me.layoutControl1
            Me.cePopupSizeable.TabIndex = 30
            AddHandler Me.cePopupSizeable.CheckedChanged, New System.EventHandler(AddressOf Me.cePopupSizeable_CheckedChanged)
            ' 
            ' imageEditSample
            ' 
            Me.imageEditSample.EditValue =(CObj((resources.GetObject("imageEditSample.EditValue"))))
            Me.imageEditSample.Location = New System.Drawing.Point(32, 110)
            Me.imageEditSample.Name = "imageEditSample"
            Me.imageEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageEditSample.Properties.PopupFormSize = New System.Drawing.Size(470, 240)
            Me.imageEditSample.Size = New System.Drawing.Size(186, 20)
            Me.imageEditSample.StyleController = Me.layoutControl1
            Me.imageEditSample.TabIndex = 0
            ' 
            ' ceIcon
            ' 
            Me.ceIcon.Location = New System.Drawing.Point(290, 81)
            Me.ceIcon.Name = "ceIcon"
            Me.ceIcon.Properties.Caption = "Show icon"
            Me.ceIcon.Size = New System.Drawing.Size(186, 20)
            Me.ceIcon.StyleController = Me.layoutControl1
            Me.ceIcon.TabIndex = 28
            AddHandler Me.ceIcon.CheckedChanged, New System.EventHandler(AddressOf Me.ceIcon_CheckedChanged)
            ' 
            ' icbSizeMode
            ' 
            Me.icbSizeMode.EditValue = "imageComboBoxEdit1"
            Me.icbSizeMode.Location = New System.Drawing.Point(354, 53)
            Me.icbSizeMode.Name = "icbSizeMode"
            Me.icbSizeMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbSizeMode.Size = New System.Drawing.Size(122, 20)
            Me.icbSizeMode.StyleController = Me.layoutControl1
            Me.icbSizeMode.TabIndex = 27
            AddHandler Me.icbSizeMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbSizeMode_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(508, 220)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(258, 200)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.imageEditSample
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(190, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(190, 139)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.emptySpaceItem1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(258, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(230, 200)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbSizeMode
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(190, 26)
            Me.layoutControlItem2.Text = "Size mode:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(52, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceIcon
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(190, 28)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceMenu
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(190, 28)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.cePopupSizeable
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(190, 28)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ceCustomIcons
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 110)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(190, 28)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 138)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(190, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(190, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("gaugestylehalfcircular", "image://svgimages/reports/gaugestylehalfcircular.svg")
            Me.svgImageCollection1.Add("glyph_message", "image://svgimages/outlook inspired/glyph_message.svg")
            ' 
            ' ModuleImageEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleImageEdit"
            Me.Size = New System.Drawing.Size(702, 404)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleImageEdit_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceCustomIcons.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceMenu.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cePopupSizeable.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageEditSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceIcon.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbSizeMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private imageEditSample As DevExpress.XtraEditors.ImageEdit

        Private icbSizeMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceIcon As DevExpress.XtraEditors.CheckEdit

        Private ceMenu As DevExpress.XtraEditors.CheckEdit

        Private ceCustomIcons As DevExpress.XtraEditors.CheckEdit

        Private cePopupSizeable As DevExpress.XtraEditors.CheckEdit

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

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
