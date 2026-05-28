Namespace DevExpress.DevAV.Modules

    Partial Class OrderView

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
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.DevAV.Modules.OrderView))
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.modueLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.editBBI = New DevExpress.XtraBars.BarButtonItem()
            Me.deleteBBI = New DevExpress.XtraBars.BarButtonItem()
            Me.emailBBI = New DevExpress.XtraBars.BarButtonItem()
            Me.printBBI = New DevExpress.XtraBars.BarButtonItem()
            Me.paidBBI = New DevExpress.XtraBars.BarButtonItem()
            Me.refundBBI = New DevExpress.XtraBars.BarButtonItem()
            Me.previousBBI = New DevExpress.XtraBars.BarButtonItem()
            Me.nextBBI = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.companyNameLabelControl = New DevExpress.XtraEditors.LabelControl()
            Me.companyImagePictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.TitleLabel = New DevExpress.XtraEditors.LabelControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForCompanyNameLabelControl = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForTitleLabel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForCompanyImagePictureEdit = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.modueLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.modueLayout.SuspendLayout()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.companyImagePictureEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForCompanyNameLabelControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForTitleLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForCompanyImagePictureEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Order)
            Me.modueLayout.AllowCustomization = False
            Me.modueLayout.Controls.Add(Me.roundedSkinPanel1)
            Me.modueLayout.Controls.Add(Me.companyNameLabelControl)
            Me.modueLayout.Controls.Add(Me.companyImagePictureEdit)
            Me.modueLayout.Controls.Add(Me.TitleLabel)
            Me.modueLayout.DataSource = Me.bindingSource
            Me.modueLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.modueLayout.Location = New System.Drawing.Point(0, 0)
            Me.modueLayout.Name = "modueLayout"
            Me.modueLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2191, 312, 650, 558)
            Me.modueLayout.Root = Me.Root
            Me.modueLayout.Size = New System.Drawing.Size(602, 446)
            Me.modueLayout.TabIndex = 0
            Me.roundedSkinPanel1.Controls.Add(Me.panelControl1)
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(16, 154)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(570, 276)
            Me.roundedSkinPanel1.TabIndex = 1
            Me.roundedSkinPanel1.Text = "roundedSkinPanel1"
            Me.roundedSkinPanel1.UseDefaultPadding = DevExpress.Utils.DefaultBoolean.[False]
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.richEditControl)
            Me.panelControl1.Controls.Add(Me.barDockControlLeft)
            Me.panelControl1.Controls.Add(Me.barDockControlRight)
            Me.panelControl1.Controls.Add(Me.barDockControlBottom)
            Me.panelControl1.Controls.Add(Me.barDockControlTop)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(1, 1)
            Me.panelControl1.MinimumSize = New System.Drawing.Size(400, 32)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(568, 274)
            Me.panelControl1.TabIndex = 35
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl.MenuManager = Me.barManager1
            Me.richEditControl.Modified = True
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl.Options.MailMerge.DataSource = GetType(DevExpress.DevAV.Order)
            Me.richEditControl.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl.[ReadOnly] = True
            Me.richEditControl.Size = New System.Drawing.Size(529, 274)
            Me.richEditControl.TabIndex = 19
            Me.richEditControl.Views.PrintLayoutView.MaxHorizontalPageCount = 1
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me.panelControl1
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.editBBI, Me.deleteBBI, Me.emailBBI, Me.printBBI, Me.paidBBI, Me.refundBBI, Me.previousBBI, Me.nextBBI})
            Me.barManager1.MaxItemId = 8
            Me.bar1.BarName = "Button"
            Me.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Right
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Right
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.editBBI), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteBBI), New DevExpress.XtraBars.LinkPersistInfo(Me.emailBBI), New DevExpress.XtraBars.LinkPersistInfo(Me.printBBI), New DevExpress.XtraBars.LinkPersistInfo(Me.paidBBI), New DevExpress.XtraBars.LinkPersistInfo(Me.refundBBI), New DevExpress.XtraBars.LinkPersistInfo(Me.previousBBI), New DevExpress.XtraBars.LinkPersistInfo(Me.nextBBI)})
            Me.bar1.OptionsBar.AllowQuickCustomization = False
            Me.bar1.OptionsBar.DrawBorder = False
            Me.bar1.OptionsBar.DrawDragBorder = False
            Me.bar1.Text = "Button"
            Me.editBBI.Caption = "Edit Invoice"
            Me.editBBI.Id = 0
            Me.editBBI.ImageOptions.SvgImage = CType((resources.GetObject("editBBI.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.editBBI.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.editBBI.Name = "editBBI"
            Me.deleteBBI.Caption = "Delete Sale Record"
            Me.deleteBBI.Id = 1
            Me.deleteBBI.ImageOptions.SvgImage = CType((resources.GetObject("deleteBBI.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.deleteBBI.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.deleteBBI.Name = "deleteBBI"
            Me.emailBBI.Caption = "Send Invoice via Email"
            Me.emailBBI.Id = 2
            Me.emailBBI.ImageOptions.SvgImage = CType((resources.GetObject("emailBBI.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.emailBBI.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.emailBBI.Name = "emailBBI"
            Me.printBBI.Caption = "Print Invoice"
            Me.printBBI.Id = 3
            Me.printBBI.ImageOptions.SvgImage = CType((resources.GetObject("printBBI.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.printBBI.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.printBBI.Name = "printBBI"
            Me.paidBBI.Caption = "Mark as Paid"
            Me.paidBBI.Id = 4
            Me.paidBBI.ImageOptions.SvgImage = CType((resources.GetObject("paidBBI.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.paidBBI.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.paidBBI.Name = "paidBBI"
            Me.refundBBI.Caption = "Issue Full Refund"
            Me.refundBBI.Id = 5
            Me.refundBBI.ImageOptions.SvgImage = CType((resources.GetObject("refundBBI.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.refundBBI.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.refundBBI.Name = "refundBBI"
            Me.previousBBI.Caption = "Previous Record"
            Me.previousBBI.Id = 6
            Me.previousBBI.ImageOptions.SvgImage = CType((resources.GetObject("previousBBI.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.previousBBI.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.previousBBI.Name = "previousBBI"
            Me.nextBBI.Caption = "Next Record"
            Me.nextBBI.Id = 7
            Me.nextBBI.ImageOptions.SvgImage = CType((resources.GetObject("nextBBI.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.nextBBI.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.nextBBI.Name = "nextBBI"
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(568, 0)
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 274)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(568, 0)
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 274)
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(529, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(39, 274)
            Me.companyNameLabelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.companyNameLabelControl.Appearance.Options.UseFont = True
            Me.companyNameLabelControl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Customer.Name", True))
            Me.companyNameLabelControl.Location = New System.Drawing.Point(158, 32)
            Me.companyNameLabelControl.Name = "companyNameLabelControl"
            Me.companyNameLabelControl.Size = New System.Drawing.Size(50, 32)
            Me.companyNameLabelControl.StyleController = Me.modueLayout
            Me.companyNameLabelControl.TabIndex = 34
            Me.companyNameLabelControl.Text = "Mart"
            Me.companyImagePictureEdit.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.companyImagePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Customer.Image", True))
            Me.companyImagePictureEdit.Location = New System.Drawing.Point(16, 16)
            Me.companyImagePictureEdit.MaximumSize = New System.Drawing.Size(120, 120)
            Me.companyImagePictureEdit.MinimumSize = New System.Drawing.Size(120, 120)
            Me.companyImagePictureEdit.Name = "companyImagePictureEdit"
            Me.companyImagePictureEdit.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.[True]
            Me.companyImagePictureEdit.Properties.AllowFocused = False
            Me.companyImagePictureEdit.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.companyImagePictureEdit.Properties.ShowMenu = False
            Me.companyImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.companyImagePictureEdit.Size = New System.Drawing.Size(120, 120)
            Me.companyImagePictureEdit.StyleController = Me.modueLayout
            Me.companyImagePictureEdit.TabIndex = 33
            Me.TitleLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.TitleLabel.Appearance.Options.UseFont = True
            Me.TitleLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "InvoiceNumber", True))
            Me.TitleLabel.Location = New System.Drawing.Point(233, 95)
            Me.TitleLabel.Margin = New System.Windows.Forms.Padding(2)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(60, 25)
            Me.TitleLabel.StyleController = Me.modueLayout
            Me.TitleLabel.TabIndex = 4
            Me.TitleLabel.Text = "250999"
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlGroup1, Me.ItemForCompanyImagePictureEdit})
            Me.Root.Name = "Root"
            Me.Root.OptionsItemText.TextToControlDistance = 6
            Me.Root.Size = New System.Drawing.Size(602, 446)
            Me.layoutControlItem2.Control = Me.roundedSkinPanel1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 126)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(576, 294)
            Me.layoutControlItem2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 0)
            Me.layoutControlItem2.TextVisible = False
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCompanyNameLabelControl, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.ItemForTitleLabel})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(126, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(450, 126)
            Me.ItemForCompanyNameLabelControl.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 11F)
            Me.ItemForCompanyNameLabelControl.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForCompanyNameLabelControl.Control = Me.companyNameLabelControl
            Me.ItemForCompanyNameLabelControl.Location = New System.Drawing.Point(0, 0)
            Me.ItemForCompanyNameLabelControl.Name = "ItemForCompanyNameLabelControl"
            Me.ItemForCompanyNameLabelControl.Size = New System.Drawing.Size(141, 38)
            Me.ItemForCompanyNameLabelControl.TextVisible = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(141, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(277, 94)
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 38)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(141, 25)
            Me.ItemForTitleLabel.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 11F)
            Me.ItemForTitleLabel.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForTitleLabel.Control = Me.TitleLabel
            Me.ItemForTitleLabel.CustomizationFormText = "Title"
            Me.ItemForTitleLabel.Location = New System.Drawing.Point(0, 63)
            Me.ItemForTitleLabel.Name = "ItemForTitleLabel"
            Me.ItemForTitleLabel.Size = New System.Drawing.Size(141, 31)
            Me.ItemForTitleLabel.Text = "INVOICE #"
            Me.ItemForTitleLabel.TextSize = New System.Drawing.Size(69, 20)
            Me.ItemForCompanyImagePictureEdit.Control = Me.companyImagePictureEdit
            Me.ItemForCompanyImagePictureEdit.Location = New System.Drawing.Point(0, 0)
            Me.ItemForCompanyImagePictureEdit.Name = "ItemForCompanyImagePictureEdit"
            Me.ItemForCompanyImagePictureEdit.Size = New System.Drawing.Size(126, 126)
            Me.ItemForCompanyImagePictureEdit.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.modueLayout)
            Me.Name = "OrderView"
            Me.Size = New System.Drawing.Size(602, 446)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.modueLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.modueLayout.ResumeLayout(False)
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.companyImagePictureEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForCompanyNameLabelControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForTitleLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForCompanyImagePictureEdit), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private bindingSource As System.Windows.Forms.BindingSource

        Private modueLayout As DevExpress.XtraDataLayout.DataLayoutControl

        Private TitleLabel As DevExpress.XtraEditors.LabelControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private companyImagePictureEdit As DevExpress.XtraEditors.PictureEdit

        Private companyNameLabelControl As DevExpress.XtraEditors.LabelControl

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private bar1 As DevExpress.XtraBars.Bar

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private editBBI As DevExpress.XtraBars.BarButtonItem

        Private deleteBBI As DevExpress.XtraBars.BarButtonItem

        Private emailBBI As DevExpress.XtraBars.BarButtonItem

        Private printBBI As DevExpress.XtraBars.BarButtonItem

        Private paidBBI As DevExpress.XtraBars.BarButtonItem

        Private refundBBI As DevExpress.XtraBars.BarButtonItem

        Private previousBBI As DevExpress.XtraBars.BarButtonItem

        Private nextBBI As DevExpress.XtraBars.BarButtonItem

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private ItemForCompanyImagePictureEdit As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private ItemForTitleLabel As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForCompanyNameLabelControl As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
