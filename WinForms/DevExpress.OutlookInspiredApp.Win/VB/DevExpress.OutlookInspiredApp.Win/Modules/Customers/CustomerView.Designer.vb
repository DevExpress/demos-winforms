Namespace DevExpress.DevAV.Modules

    Partial Class CustomerView

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
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.moduleLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.roundedSkinPanelGrid = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSourceCustomerStores = New System.Windows.Forms.BindingSource(Me.components)
            Me.winExplorerView = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.colAddressLines = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCrestSmallImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCrestLargeImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCrestCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.HomeOfficeTextLabel = New DevExpress.XtraEditors.LabelControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForLogo = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForHomeOffice = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sliName = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForGrid = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType((Me.roundedSkinPanelGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanelGrid.SuspendLayout()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSourceCustomerStores), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.winExplorerView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pictureEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForLogo), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForHomeOffice), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.sliName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Customer)
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.roundedSkinPanelGrid)
            Me.moduleLayout.Controls.Add(Me.pictureEdit)
            Me.moduleLayout.Controls.Add(Me.HomeOfficeTextLabel)
            Me.moduleLayout.DataSource = Me.bindingSource
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2382, -174, 650, 400)
            Me.moduleLayout.Root = Me.Root
            Me.moduleLayout.Size = New System.Drawing.Size(376, 423)
            Me.moduleLayout.TabIndex = 0
            Me.roundedSkinPanelGrid.Controls.Add(Me.gridControl)
            Me.roundedSkinPanelGrid.Location = New System.Drawing.Point(16, 154)
            Me.roundedSkinPanelGrid.Name = "roundedSkinPanelGrid"
            Me.roundedSkinPanelGrid.Size = New System.Drawing.Size(344, 253)
            Me.roundedSkinPanelGrid.TabIndex = 8
            Me.roundedSkinPanelGrid.Text = "roundedSkinPanel1"
            Me.roundedSkinPanelGrid.UseDefaultPadding = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridControl.DataSource = Me.bindingSourceCustomerStores
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(1, 1)
            Me.gridControl.MainView = Me.winExplorerView
            Me.gridControl.MinimumSize = New System.Drawing.Size(32, 32)
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(342, 251)
            Me.gridControl.TabIndex = 7
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView})
            Me.bindingSourceCustomerStores.DataSource = GetType(DevExpress.DevAV.CustomerStore)
            Me.winExplorerView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAddressLines, Me.colCrestSmallImage, Me.colCustomerName, Me.colCrestLargeImage, Me.colCrestCity})
            Me.winExplorerView.ColumnSet.DescriptionColumn = Me.colAddressLines
            Me.winExplorerView.ColumnSet.ExtraLargeImageColumn = Me.colCrestLargeImage
            Me.winExplorerView.ColumnSet.LargeImageColumn = Me.colCrestLargeImage
            Me.winExplorerView.ColumnSet.MediumImageColumn = Me.colCrestSmallImage
            Me.winExplorerView.ColumnSet.SmallImageColumn = Me.colCrestSmallImage
            Me.winExplorerView.ColumnSet.TextColumn = Me.colCrestCity
            Me.winExplorerView.GridControl = Me.gridControl
            Me.winExplorerView.Name = "winExplorerView"
            Me.winExplorerView.OptionsBehavior.Editable = False
            Me.winExplorerView.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Large
            Me.winExplorerView.OptionsViewStyles.Large.ImageSize = New System.Drawing.Size(110, 110)
            Me.winExplorerView.OptionsViewStyles.Large.ShowDescription = DevExpress.Utils.DefaultBoolean.[True]
            Me.winExplorerView.OptionsViewStyles.Medium.ImageSize = New System.Drawing.Size(80, 80)
            Me.colAddressLines.FieldName = "AddressLines"
            Me.colAddressLines.Name = "colAddressLines"
            Me.colAddressLines.Visible = True
            Me.colAddressLines.VisibleIndex = 0
            Me.colCrestSmallImage.FieldName = "CrestSmallImage"
            Me.colCrestSmallImage.Name = "colCrestSmallImage"
            Me.colCrestSmallImage.Visible = True
            Me.colCrestSmallImage.VisibleIndex = 1
            Me.colCustomerName.FieldName = "CustomerName"
            Me.colCustomerName.Name = "colCustomerName"
            Me.colCustomerName.Visible = True
            Me.colCustomerName.VisibleIndex = 1
            Me.colCrestLargeImage.FieldName = "CrestLargeImage"
            Me.colCrestLargeImage.Name = "colCrestLargeImage"
            Me.colCrestLargeImage.Visible = True
            Me.colCrestLargeImage.VisibleIndex = 0
            Me.colCrestCity.FieldName = "CrestCity"
            Me.colCrestCity.Name = "colCrestCity"
            Me.colCrestCity.Visible = True
            Me.colCrestCity.VisibleIndex = 0
            Me.pictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Logo", True))
            Me.pictureEdit.Location = New System.Drawing.Point(16, 16)
            Me.pictureEdit.MaximumSize = New System.Drawing.Size(120, 120)
            Me.pictureEdit.MinimumSize = New System.Drawing.Size(120, 120)
            Me.pictureEdit.Name = "pictureEdit"
            Me.pictureEdit.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.[True]
            Me.pictureEdit.Properties.AllowFocused = False
            Me.pictureEdit.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.pictureEdit.Properties.[ReadOnly] = True
            Me.pictureEdit.Properties.ShowMenu = False
            Me.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.pictureEdit.Size = New System.Drawing.Size(120, 120)
            Me.pictureEdit.StyleController = Me.moduleLayout
            Me.pictureEdit.TabIndex = 1
            Me.HomeOfficeTextLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25F)
            Me.HomeOfficeTextLabel.Appearance.Options.UseFont = True
            Me.HomeOfficeTextLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.HomeOfficeTextLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "HomeOffice", True))
            Me.HomeOfficeTextLabel.Location = New System.Drawing.Point(158, 94)
            Me.HomeOfficeTextLabel.Name = "HomeOfficeTextLabel"
            Me.HomeOfficeTextLabel.Size = New System.Drawing.Size(186, 1)
            Me.HomeOfficeTextLabel.StyleController = Me.moduleLayout
            Me.HomeOfficeTextLabel.TabIndex = 5
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1, Me.ItemForGrid})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(376, 423)
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "autoGeneratedGroup0"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForLogo, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup1.Size = New System.Drawing.Size(350, 126)
            Me.ItemForLogo.Control = Me.pictureEdit
            Me.ItemForLogo.CustomizationFormText = "ItemForLogo"
            Me.ItemForLogo.Location = New System.Drawing.Point(0, 0)
            Me.ItemForLogo.Name = "ItemForLogo"
            Me.ItemForLogo.Size = New System.Drawing.Size(126, 126)
            Me.ItemForLogo.TextVisible = False
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForHomeOffice, Me.sliName, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(126, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(224, 126)
            Me.ItemForHomeOffice.Control = Me.HomeOfficeTextLabel
            Me.ItemForHomeOffice.CustomizationFormText = "Home Office"
            Me.ItemForHomeOffice.Location = New System.Drawing.Point(0, 43)
            Me.ItemForHomeOffice.Name = "ItemForHomeOffice"
            Me.ItemForHomeOffice.Size = New System.Drawing.Size(192, 26)
            Me.ItemForHomeOffice.Text = "HOME OFFICE"
            Me.ItemForHomeOffice.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForHomeOffice.TextSize = New System.Drawing.Size(71, 13)
            Me.sliName.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.sliName.AppearanceItemCaption.Options.UseFont = True
            Me.sliName.CustomizationFormText = "Name"
            Me.sliName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Name", True))
            Me.sliName.Location = New System.Drawing.Point(0, 0)
            Me.sliName.Name = "sliName"
            Me.sliName.Size = New System.Drawing.Size(192, 43)
            Me.sliName.Text = "Name"
            Me.sliName.TextSize = New System.Drawing.Size(71, 37)
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 69)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(192, 25)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForGrid.Control = Me.roundedSkinPanelGrid
            Me.ItemForGrid.Location = New System.Drawing.Point(0, 126)
            Me.ItemForGrid.Name = "ItemForGrid"
            Me.ItemForGrid.Size = New System.Drawing.Size(350, 271)
            Me.ItemForGrid.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 0)
            Me.ItemForGrid.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "CustomerView"
            Me.Size = New System.Drawing.Size(376, 423)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType((Me.roundedSkinPanelGrid), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanelGrid.ResumeLayout(False)
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSourceCustomerStores), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.winExplorerView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pictureEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForLogo), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForHomeOffice), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.sliName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForGrid), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private bindingSource As System.Windows.Forms.BindingSource

        Private moduleLayout As DevExpress.XtraDataLayout.DataLayoutControl

        Private HomeOfficeTextLabel As DevExpress.XtraEditors.LabelControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private ItemForHomeOffice As DevExpress.XtraLayout.LayoutControlItem

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private winExplorerView As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private pictureEdit As DevExpress.XtraEditors.PictureEdit

        Private ItemForLogo As DevExpress.XtraLayout.LayoutControlItem

        Private sliName As DevExpress.XtraLayout.SimpleLabelItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private bindingSourceCustomerStores As System.Windows.Forms.BindingSource

        Private colAddressLines As DevExpress.XtraGrid.Columns.GridColumn

        Private colCrestSmallImage As DevExpress.XtraGrid.Columns.GridColumn

        Private colCustomerName As DevExpress.XtraGrid.Columns.GridColumn

        Private colCrestLargeImage As DevExpress.XtraGrid.Columns.GridColumn

        Private colCrestCity As DevExpress.XtraGrid.Columns.GridColumn

        Private roundedSkinPanelGrid As DevExpress.XtraEditors.RoundedSkinPanel

        Private ItemForGrid As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
