Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleMemoExEdit

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleMemoExEdit))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceCustomIcons = New DevExpress.XtraEditors.CheckEdit()
            Me.ceWordWrap = New DevExpress.XtraEditors.CheckEdit()
            Me.ceIcon = New DevExpress.XtraEditors.CheckEdit()
            Me.cePopupSizeable = New DevExpress.XtraEditors.CheckEdit()
            Me.memoExEditSample = New DevExpress.XtraEditors.MemoExEdit()
            Me.icbScrollBars = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceAutoHideScrollBars = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciMemoExEditSample = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciIcbScrollBars = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCeWordWrap = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCeIcon = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCePopupSizeable = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCeCustomIcons = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciCeAutoHideScrollBars = New DevExpress.XtraLayout.LayoutControlItem()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceCustomIcons.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceWordWrap.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceIcon.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cePopupSizeable.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.memoExEditSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbScrollBars.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAutoHideScrollBars.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciMemoExEditSample), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciIcbScrollBars), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCeWordWrap), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCeIcon), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCePopupSizeable), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCeCustomIcons), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCeAutoHideScrollBars), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceCustomIcons)
            Me.layoutControl1.Controls.Add(Me.ceWordWrap)
            Me.layoutControl1.Controls.Add(Me.ceIcon)
            Me.layoutControl1.Controls.Add(Me.cePopupSizeable)
            Me.layoutControl1.Controls.Add(Me.memoExEditSample)
            Me.layoutControl1.Controls.Add(Me.icbScrollBars)
            Me.layoutControl1.Controls.Add(Me.ceAutoHideScrollBars)
            Me.layoutControl1.Location = New System.Drawing.Point(41, 49)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(986, 45, 737, 684)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(589, 275)
            Me.layoutControl1.TabIndex = 4
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceCustomIcons
            ' 
            Me.ceCustomIcons.Location = New System.Drawing.Point(333, 165)
            Me.ceCustomIcons.Name = "ceCustomIcons"
            Me.ceCustomIcons.Properties.Caption = "Use custom icons"
            Me.ceCustomIcons.Size = New System.Drawing.Size(224, 20)
            Me.ceCustomIcons.StyleController = Me.layoutControl1
            Me.ceCustomIcons.TabIndex = 6
            AddHandler Me.ceCustomIcons.CheckedChanged, New System.EventHandler(AddressOf Me.ceCustomIcons_CheckedChanged)
            ' 
            ' ceWordWrap
            ' 
            Me.ceWordWrap.Location = New System.Drawing.Point(333, 81)
            Me.ceWordWrap.Name = "ceWordWrap"
            Me.ceWordWrap.Properties.Caption = "Word wrap"
            Me.ceWordWrap.Size = New System.Drawing.Size(224, 20)
            Me.ceWordWrap.StyleController = Me.layoutControl1
            Me.ceWordWrap.TabIndex = 1
            AddHandler Me.ceWordWrap.CheckedChanged, New System.EventHandler(AddressOf Me.ceWordWrap_CheckedChanged)
            ' 
            ' ceIcon
            ' 
            Me.ceIcon.Location = New System.Drawing.Point(333, 109)
            Me.ceIcon.Name = "ceIcon"
            Me.ceIcon.Properties.Caption = "Show icon"
            Me.ceIcon.Size = New System.Drawing.Size(224, 20)
            Me.ceIcon.StyleController = Me.layoutControl1
            Me.ceIcon.TabIndex = 4
            AddHandler Me.ceIcon.CheckedChanged, New System.EventHandler(AddressOf Me.ceIcon_CheckedChanged)
            ' 
            ' cePopupSizeable
            ' 
            Me.cePopupSizeable.Location = New System.Drawing.Point(333, 137)
            Me.cePopupSizeable.Name = "cePopupSizeable"
            Me.cePopupSizeable.Properties.Caption = "Popup sizeable"
            Me.cePopupSizeable.Size = New System.Drawing.Size(224, 20)
            Me.cePopupSizeable.StyleController = Me.layoutControl1
            Me.cePopupSizeable.TabIndex = 5
            AddHandler Me.cePopupSizeable.CheckedChanged, New System.EventHandler(AddressOf Me.cePopupSizeable_CheckedChanged)
            ' 
            ' memoExEditSample
            ' 
            Me.memoExEditSample.Location = New System.Drawing.Point(32, 138)
            Me.memoExEditSample.Name = "memoExEditSample"
            Me.memoExEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.memoExEditSample.Size = New System.Drawing.Size(229, 20)
            Me.memoExEditSample.StyleController = Me.layoutControl1
            Me.memoExEditSample.TabIndex = 0
            ' 
            ' icbScrollBars
            ' 
            Me.icbScrollBars.EditValue = "imageComboBoxEdit1"
            Me.icbScrollBars.Location = New System.Drawing.Point(398, 53)
            Me.icbScrollBars.Name = "icbScrollBars"
            Me.icbScrollBars.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbScrollBars.Size = New System.Drawing.Size(159, 20)
            Me.icbScrollBars.StyleController = Me.layoutControl1
            Me.icbScrollBars.TabIndex = 0
            AddHandler Me.icbScrollBars.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbScrollBars_SelectedIndexChanged)
            ' 
            ' ceAutoHideScrollBars
            ' 
            Me.ceAutoHideScrollBars.Location = New System.Drawing.Point(333, 193)
            Me.ceAutoHideScrollBars.Name = "ceAutoHideScrollBars"
            Me.ceAutoHideScrollBars.Properties.Caption = "Auto Hide ScrollBars"
            Me.ceAutoHideScrollBars.Size = New System.Drawing.Size(224, 20)
            Me.ceAutoHideScrollBars.StyleController = Me.layoutControl1
            Me.ceAutoHideScrollBars.TabIndex = 7
            AddHandler Me.ceAutoHideScrollBars.CheckedChanged, New System.EventHandler(AddressOf Me.ceAutoHideScrollBars_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(589, 275)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciMemoExEditSample})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(301, 255)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' lciMemoExEditSample
            ' 
            Me.lciMemoExEditSample.Control = Me.memoExEditSample
            Me.lciMemoExEditSample.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.lciMemoExEditSample.FillControlToClientArea = False
            Me.lciMemoExEditSample.Location = New System.Drawing.Point(0, 0)
            Me.lciMemoExEditSample.MinSize = New System.Drawing.Size(190, 24)
            Me.lciMemoExEditSample.Name = "lciMemoExEditSample"
            Me.lciMemoExEditSample.Size = New System.Drawing.Size(233, 194)
            Me.lciMemoExEditSample.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciMemoExEditSample.TextVisible = False
            Me.lciMemoExEditSample.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciIcbScrollBars, Me.lciCeWordWrap, Me.lciCeIcon, Me.lciCePopupSizeable, Me.lciCeCustomIcons, Me.emptySpaceItem1, Me.lciCeAutoHideScrollBars})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(301, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(268, 255)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' lciIcbScrollBars
            ' 
            Me.lciIcbScrollBars.Control = Me.icbScrollBars
            Me.lciIcbScrollBars.Location = New System.Drawing.Point(0, 0)
            Me.lciIcbScrollBars.Name = "lciIcbScrollBars"
            Me.lciIcbScrollBars.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.lciIcbScrollBars.Size = New System.Drawing.Size(228, 26)
            Me.lciIcbScrollBars.Text = "Scroll bars:"
            Me.lciIcbScrollBars.TextSize = New System.Drawing.Size(53, 13)
            ' 
            ' lciCeWordWrap
            ' 
            Me.lciCeWordWrap.Control = Me.ceWordWrap
            Me.lciCeWordWrap.Location = New System.Drawing.Point(0, 26)
            Me.lciCeWordWrap.Name = "lciCeWordWrap"
            Me.lciCeWordWrap.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.lciCeWordWrap.Size = New System.Drawing.Size(228, 28)
            Me.lciCeWordWrap.TextVisible = False
            ' 
            ' lciCeIcon
            ' 
            Me.lciCeIcon.Control = Me.ceIcon
            Me.lciCeIcon.Location = New System.Drawing.Point(0, 54)
            Me.lciCeIcon.Name = "lciCeIcon"
            Me.lciCeIcon.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.lciCeIcon.Size = New System.Drawing.Size(228, 28)
            Me.lciCeIcon.TextVisible = False
            ' 
            ' lciCePopupSizeable
            ' 
            Me.lciCePopupSizeable.Control = Me.cePopupSizeable
            Me.lciCePopupSizeable.Location = New System.Drawing.Point(0, 82)
            Me.lciCePopupSizeable.Name = "lciCePopupSizeable"
            Me.lciCePopupSizeable.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.lciCePopupSizeable.Size = New System.Drawing.Size(228, 28)
            Me.lciCePopupSizeable.TextVisible = False
            ' 
            ' lciCeCustomIcons
            ' 
            Me.lciCeCustomIcons.Control = Me.ceCustomIcons
            Me.lciCeCustomIcons.Location = New System.Drawing.Point(0, 110)
            Me.lciCeCustomIcons.Name = "lciCeCustomIcons"
            Me.lciCeCustomIcons.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.lciCeCustomIcons.Size = New System.Drawing.Size(228, 28)
            Me.lciCeCustomIcons.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 166)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(190, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(228, 28)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' lciCeAutoHideScrollBars
            ' 
            Me.lciCeAutoHideScrollBars.Control = Me.ceAutoHideScrollBars
            Me.lciCeAutoHideScrollBars.Location = New System.Drawing.Point(0, 138)
            Me.lciCeAutoHideScrollBars.Name = "lciCeAutoHideScrollBars"
            Me.lciCeAutoHideScrollBars.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.lciCeAutoHideScrollBars.Size = New System.Drawing.Size(228, 28)
            Me.lciCeAutoHideScrollBars.TextVisible = False
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "listbox_16x16.png")
            Me.imageCollection1.Images.SetKeyName(1, "new_16x16.png")
            ' 
            ' ModuleMemoExEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleMemoExEdit"
            Me.Size = New System.Drawing.Size(755, 480)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleMemoExEdit_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceCustomIcons.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceWordWrap.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceIcon.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cePopupSizeable.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.memoExEditSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbScrollBars.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAutoHideScrollBars.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciMemoExEditSample), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciIcbScrollBars), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCeWordWrap), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCeIcon), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCePopupSizeable), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCeCustomIcons), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCeAutoHideScrollBars), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private memoExEditSample As DevExpress.XtraEditors.MemoExEdit

        Private ceCustomIcons As DevExpress.XtraEditors.CheckEdit

        Private ceIcon As DevExpress.XtraEditors.CheckEdit

        Private icbScrollBars As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cePopupSizeable As DevExpress.XtraEditors.CheckEdit

        Private ceWordWrap As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private lciMemoExEditSample As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private lciIcbScrollBars As DevExpress.XtraLayout.LayoutControlItem

        Private lciCeWordWrap As DevExpress.XtraLayout.LayoutControlItem

        Private lciCeIcon As DevExpress.XtraLayout.LayoutControlItem

        Private lciCePopupSizeable As DevExpress.XtraLayout.LayoutControlItem

        Private lciCeCustomIcons As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private ceAutoHideScrollBars As DevExpress.XtraEditors.CheckEdit

        Private lciCeAutoHideScrollBars As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
