Namespace DevExpress.WindowsMailClient.Win.Modules

    Partial Class MailPresenter

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim transition2 As DevExpress.Utils.Animation.Transition = New DevExpress.Utils.Animation.Transition()
            Dim fadeTransition2 As DevExpress.Utils.Animation.FadeTransition = New DevExpress.Utils.Animation.FadeTransition()
            Me.pePhoto = New DevExpress.XtraEditors.PictureEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.richEdit = New DevExpress.XtraRichEdit.RichEditControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutPictureItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.labelDate = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.labelSubject = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.labelFrom = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.transitionManager1 = New DevExpress.Utils.Animation.TransitionManager(Me.components)
            Me.mailStatusPanel1 = New DevExpress.WindowsMailClient.Win.Modules.MailStatusPanel()
            Me.statusPanelItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.pePhoto.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutPictureItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelDate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelSubject), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelFrom), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.statusPanelItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.pePhoto.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pePhoto.Location = New System.Drawing.Point(32, 91)
            Me.pePhoto.Name = "pePhoto"
            Me.pePhoto.Properties.AllowFocused = False
            Me.pePhoto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pePhoto.Properties.Appearance.Options.UseBackColor = True
            Me.pePhoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pePhoto.Properties.NullText = " "
            Me.pePhoto.Properties.OptionsMask.MaskLayoutMode = DevExpress.XtraEditors.Controls.PictureEditMaskLayoutMode.Stretch
            Me.pePhoto.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle
            Me.pePhoto.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.pePhoto.Size = New System.Drawing.Size(70, 83)
            Me.pePhoto.StyleController = Me.layoutControl1
            Me.pePhoto.TabIndex = 5
            Me.layoutControl1.Controls.Add(Me.mailStatusPanel1)
            Me.layoutControl1.Controls.Add(Me.richEdit)
            Me.layoutControl1.Controls.Add(Me.pePhoto)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(593, 194, 754, 470)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(332, 474)
            Me.layoutControl1.TabIndex = 9
            Me.layoutControl1.Text = "layoutControl1"
            Me.richEdit.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            Me.richEdit.Appearance.Text.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.richEdit.Appearance.Text.Options.UseFont = True
            Me.richEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEdit.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.richEdit.Location = New System.Drawing.Point(12, 237)
            Me.richEdit.Name = "richEdit"
            Me.richEdit.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden
            Me.richEdit.[ReadOnly] = True
            Me.richEdit.Size = New System.Drawing.Size(308, 225)
            Me.richEdit.TabIndex = 7
            Me.richEdit.Views.SimpleView.AdjustColorsToSkins = True
            Me.layoutControlGroup1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutPictureItem, Me.labelDate, Me.layoutControlItem2, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.labelSubject, Me.labelFrom, Me.emptySpaceItem1, Me.statusPanelItem})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize
            Me.layoutControlGroup1.Size = New System.Drawing.Size(332, 474)
            Me.layoutControlGroup1.TextVisible = False
            Me.layoutPictureItem.Control = Me.pePhoto
            Me.layoutPictureItem.Location = New System.Drawing.Point(0, 65)
            Me.layoutPictureItem.MaxSize = New System.Drawing.Size(108, 110)
            Me.layoutPictureItem.MinSize = New System.Drawing.Size(108, 110)
            Me.layoutPictureItem.Name = "layoutPictureItem"
            Me.layoutPictureItem.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 10, 10, 5)
            Me.layoutPictureItem.Size = New System.Drawing.Size(108, 110)
            Me.layoutPictureItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutPictureItem.Spacing = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutPictureItem.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutPictureItem.TextVisible = False
            Me.labelDate.AllowHotTrack = False
            Me.labelDate.Enabled = False
            Me.labelDate.Location = New System.Drawing.Point(108, 115)
            Me.labelDate.Name = "labelDate"
            Me.labelDate.Size = New System.Drawing.Size(204, 17)
            Me.labelDate.Text = " "
            Me.labelDate.TextSize = New System.Drawing.Size(3, 13)
            Me.layoutControlItem2.Control = Me.richEdit
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 225)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(312, 229)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 217)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 8)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 8)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(312, 8)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(108, 65)
            Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 25)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 25)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(204, 25)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.labelSubject.AllowHotTrack = False
            Me.labelSubject.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelSubject.AppearanceItemCaption.Options.UseFont = True
            Me.labelSubject.AppearanceItemCaption.Options.UseTextOptions = True
            Me.labelSubject.AppearanceItemCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.labelSubject.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.labelSubject.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.labelSubject.CustomizationFormText = "labelSubject"
            Me.labelSubject.Location = New System.Drawing.Point(0, 0)
            Me.labelSubject.MaxSize = New System.Drawing.Size(0, 65)
            Me.labelSubject.MinSize = New System.Drawing.Size(1, 65)
            Me.labelSubject.Name = "labelSubject"
            Me.labelSubject.Padding = New DevExpress.XtraLayout.Utils.Padding(15, 12, 2, 2)
            Me.labelSubject.Size = New System.Drawing.Size(312, 65)
            Me.labelSubject.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.labelSubject.Text = " "
            Me.labelSubject.TextSize = New System.Drawing.Size(0, 30)
            Me.labelFrom.AllowHotTrack = False
            Me.labelFrom.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelFrom.AppearanceItemCaption.Options.UseFont = True
            Me.labelFrom.CustomizationFormText = "labelFrom"
            Me.labelFrom.Location = New System.Drawing.Point(108, 90)
            Me.labelFrom.Name = "labelFrom"
            Me.labelFrom.Size = New System.Drawing.Size(204, 25)
            Me.labelFrom.Text = " "
            Me.labelFrom.TextSize = New System.Drawing.Size(4, 21)
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(108, 132)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(204, 43)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.transitionManager1.FrameCount = 300
            Me.transitionManager1.ShowWaitingIndicator = False
            transition2.BarWaitingIndicatorProperties.Caption = ""
            transition2.BarWaitingIndicatorProperties.Description = ""
            transition2.Control = Me
            transition2.EasingMode = DevExpress.Data.Utils.EasingMode.EaseOut
            transition2.LineWaitingIndicatorProperties.AnimationElementCount = 5
            transition2.LineWaitingIndicatorProperties.Caption = ""
            transition2.LineWaitingIndicatorProperties.Description = ""
            transition2.RingWaitingIndicatorProperties.AnimationElementCount = 5
            transition2.RingWaitingIndicatorProperties.Caption = ""
            transition2.RingWaitingIndicatorProperties.Description = ""
            transition2.TransitionType = fadeTransition2
            transition2.WaitingIndicatorProperties.Caption = ""
            transition2.WaitingIndicatorProperties.Description = ""
            Me.transitionManager1.Transitions.Add(transition2)
            Me.mailStatusPanel1.Location = New System.Drawing.Point(27, 190)
            Me.mailStatusPanel1.Name = "mailStatusPanel1"
            Me.mailStatusPanel1.Size = New System.Drawing.Size(283, 35)
            Me.mailStatusPanel1.TabIndex = 8
            Me.mailStatusPanel1.Text = "mailStatusPanel1"
            Me.statusPanelItem.Control = Me.mailStatusPanel1
            Me.statusPanelItem.Location = New System.Drawing.Point(0, 175)
            Me.statusPanelItem.MaxSize = New System.Drawing.Size(0, 42)
            Me.statusPanelItem.MinSize = New System.Drawing.Size(1, 42)
            Me.statusPanelItem.Name = "statusPanelItem"
            Me.statusPanelItem.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 12, 5, 2)
            Me.statusPanelItem.Size = New System.Drawing.Size(312, 42)
            Me.statusPanelItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.statusPanelItem.TextSize = New System.Drawing.Size(0, 0)
            Me.statusPanelItem.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "MailPresenter"
            Me.Size = New System.Drawing.Size(332, 474)
            CType((Me.pePhoto.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutPictureItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelDate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelSubject), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelFrom), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.statusPanelItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pePhoto As DevExpress.XtraEditors.PictureEdit

        Private richEdit As DevExpress.XtraRichEdit.RichEditControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutPictureItem As DevExpress.XtraLayout.LayoutControlItem

        Private labelSubject As DevExpress.XtraLayout.SimpleLabelItem

        Private labelDate As DevExpress.XtraLayout.SimpleLabelItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private labelFrom As DevExpress.XtraLayout.SimpleLabelItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private transitionManager1 As DevExpress.Utils.Animation.TransitionManager

        Private components As System.ComponentModel.IContainer

        Private mailStatusPanel1 As DevExpress.WindowsMailClient.Win.Modules.MailStatusPanel

        Private statusPanelItem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
