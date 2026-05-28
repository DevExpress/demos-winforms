Namespace DevExpress.XtraDialogs.Demos

    Partial Class CarRentalCatalogue

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
            Me.fileExplorerAssistant = New DevExpress.XtraDialogs.FileExplorerAssistant(Me.components)
            Me.catalogueTree = New DevExpress.XtraTreeList.TreeList()
            Me.grid = New DevExpress.XtraGrid.GridControl()
            Me.winExplorerView1 = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.carDetailsLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.NameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.modelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ModificationTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.PriceTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.MPGCityTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.MPGHighwayTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.DoorsTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.CylindersTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.HorsepowerTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.TorqueTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.TransmissionSpeedsTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.DescriptionTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.PhotoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.DeliveryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.InStockCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.BodyStyleNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.TrademarkNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.CategoryNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.TransmissionTypeComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.CategoryImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.BodyStyleImageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ItemForCategoryName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForTrademarkName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForBodyStyleName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForBodyStyle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForPhoto = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForModification = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForInStock = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForPrice = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForDoors = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForCylinders = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForTransmissionSpeeds = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForMPGCity = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForCategory = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForHorsepower = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForTorque = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForTransmissionType = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForMPGHighway = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForDeliveryDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.vSeparator = New DevExpress.XtraEditors.SeparatorControl()
            Me.hSeparator = New DevExpress.XtraEditors.SeparatorControl()
            CType((Me.fileExplorerAssistant), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.catalogueTree), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.grid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.winExplorerView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.carDetailsLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.carDetailsLayout.SuspendLayout()
            CType((Me.NameTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.modelBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ModificationTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.PriceTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.MPGCityTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.MPGHighwayTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.DoorsTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.CylindersTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.HorsepowerTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.TorqueTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.TransmissionSpeedsTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.DescriptionTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.PhotoPictureEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.DeliveryDateDateEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.DeliveryDateDateEdit.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.InStockCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.BodyStyleNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.TrademarkNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.CategoryNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.TransmissionTypeComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.CategoryImageComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.BodyStyleImageComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForCategoryName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForTrademarkName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForBodyStyleName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForDescription), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForBodyStyle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForPhoto), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForModification), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForInStock), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForPrice), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForDoors), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForCylinders), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForTransmissionSpeeds), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForMPGCity), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForCategory), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForHorsepower), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForTorque), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForTransmissionType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForMPGHighway), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForDeliveryDate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.vSeparator), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.hSeparator), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' catalogueTree
            ' 
            Me.catalogueTree.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.tablePanel1.SetColumn(Me.catalogueTree, 0)
            Me.catalogueTree.Dock = System.Windows.Forms.DockStyle.Fill
            Me.catalogueTree.Location = New System.Drawing.Point(0, 0)
            Me.catalogueTree.Margin = New System.Windows.Forms.Padding(0)
            Me.catalogueTree.Name = "catalogueTree"
            Me.tablePanel1.SetRow(Me.catalogueTree, 0)
            Me.tablePanel1.SetRowSpan(Me.catalogueTree, 3)
            Me.catalogueTree.Size = New System.Drawing.Size(266, 600)
            Me.catalogueTree.TabIndex = 0
            ' 
            ' grid
            ' 
            Me.tablePanel1.SetColumn(Me.grid, 2)
            Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grid.Location = New System.Drawing.Point(267, 0)
            Me.grid.MainView = Me.winExplorerView1
            Me.grid.Margin = New System.Windows.Forms.Padding(0)
            Me.grid.Name = "grid"
            Me.tablePanel1.SetRow(Me.grid, 0)
            Me.grid.Size = New System.Drawing.Size(533, 278)
            Me.grid.TabIndex = 1
            Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView1})
            ' 
            ' winExplorerView1
            ' 
            Me.winExplorerView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.winExplorerView1.GridControl = Me.grid
            Me.winExplorerView1.Name = "winExplorerView1"
            Me.winExplorerView1.ViewCaptionHeight = 0
            ' 
            ' carDetailsLayout
            ' 
            Me.tablePanel1.SetColumn(Me.carDetailsLayout, 2)
            Me.carDetailsLayout.Controls.Add(Me.NameTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.ModificationTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.PriceTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.MPGCityTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.MPGHighwayTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.DoorsTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.CylindersTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.HorsepowerTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.TorqueTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.TransmissionSpeedsTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.DescriptionTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.PhotoPictureEdit)
            Me.carDetailsLayout.Controls.Add(Me.DeliveryDateDateEdit)
            Me.carDetailsLayout.Controls.Add(Me.InStockCheckEdit)
            Me.carDetailsLayout.Controls.Add(Me.BodyStyleNameTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.TrademarkNameTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.CategoryNameTextEdit)
            Me.carDetailsLayout.Controls.Add(Me.TransmissionTypeComboBoxEdit)
            Me.carDetailsLayout.Controls.Add(Me.CategoryImageComboBoxEdit)
            Me.carDetailsLayout.Controls.Add(Me.BodyStyleImageComboBoxEdit)
            Me.carDetailsLayout.DataSource = Me.modelBindingSource
            Me.carDetailsLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.carDetailsLayout.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCategoryName, Me.ItemForTrademarkName, Me.ItemForBodyStyleName, Me.ItemForDescription, Me.ItemForBodyStyle})
            Me.carDetailsLayout.Location = New System.Drawing.Point(267, 279)
            Me.carDetailsLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.carDetailsLayout.Name = "carDetailsLayout"
            Me.carDetailsLayout.Root = Me.Root
            Me.tablePanel1.SetRow(Me.carDetailsLayout, 2)
            Me.carDetailsLayout.Size = New System.Drawing.Size(533, 321)
            Me.carDetailsLayout.TabIndex = 2
            ' 
            ' NameTextEdit
            ' 
            Me.NameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Name", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.NameTextEdit.Location = New System.Drawing.Point(89, 172)
            Me.NameTextEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.NameTextEdit.Name = "NameTextEdit"
            Me.NameTextEdit.Size = New System.Drawing.Size(194, 20)
            Me.NameTextEdit.StyleController = Me.carDetailsLayout
            Me.NameTextEdit.TabIndex = 4
            ' 
            ' modelBindingSource
            ' 
            Me.modelBindingSource.DataSource = GetType(DevExpress.XtraDialogs.Demos.Helpers.Data.VehiclesData.Model)
            ' 
            ' ModificationTextEdit
            ' 
            Me.ModificationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Modification", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ModificationTextEdit.Location = New System.Drawing.Point(89, 196)
            Me.ModificationTextEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.ModificationTextEdit.Name = "ModificationTextEdit"
            Me.ModificationTextEdit.Size = New System.Drawing.Size(194, 20)
            Me.ModificationTextEdit.StyleController = Me.carDetailsLayout
            Me.ModificationTextEdit.TabIndex = 5
            ' 
            ' PriceTextEdit
            ' 
            Me.PriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Price", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.PriceTextEdit.Location = New System.Drawing.Point(89, 220)
            Me.PriceTextEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.PriceTextEdit.Name = "PriceTextEdit"
            Me.PriceTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.PriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.PriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.PriceTextEdit.Properties.MaskSettings.[Set]("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
            Me.PriceTextEdit.Properties.MaskSettings.[Set]("mask", "c")
            Me.PriceTextEdit.Size = New System.Drawing.Size(194, 20)
            Me.PriceTextEdit.StyleController = Me.carDetailsLayout
            Me.PriceTextEdit.TabIndex = 7
            ' 
            ' MPGCityTextEdit
            ' 
            Me.MPGCityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "MPGCity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.MPGCityTextEdit.Location = New System.Drawing.Point(408, 204)
            Me.MPGCityTextEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.MPGCityTextEdit.Name = "MPGCityTextEdit"
            Me.MPGCityTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.MPGCityTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.MPGCityTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.MPGCityTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.MPGCityTextEdit.Properties.MaskSettings.[Set]("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
            Me.MPGCityTextEdit.Properties.MaskSettings.[Set]("mask", "d")
            Me.MPGCityTextEdit.Size = New System.Drawing.Size(113, 20)
            Me.MPGCityTextEdit.StyleController = Me.carDetailsLayout
            Me.MPGCityTextEdit.TabIndex = 8
            ' 
            ' MPGHighwayTextEdit
            ' 
            Me.MPGHighwayTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "MPGHighway", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.MPGHighwayTextEdit.Location = New System.Drawing.Point(408, 180)
            Me.MPGHighwayTextEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.MPGHighwayTextEdit.Name = "MPGHighwayTextEdit"
            Me.MPGHighwayTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.MPGHighwayTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.MPGHighwayTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.MPGHighwayTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.MPGHighwayTextEdit.Properties.MaskSettings.[Set]("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
            Me.MPGHighwayTextEdit.Properties.MaskSettings.[Set]("mask", "d")
            Me.MPGHighwayTextEdit.Size = New System.Drawing.Size(113, 20)
            Me.MPGHighwayTextEdit.StyleController = Me.carDetailsLayout
            Me.MPGHighwayTextEdit.TabIndex = 9
            ' 
            ' DoorsTextEdit
            ' 
            Me.DoorsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Doors", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.DoorsTextEdit.Location = New System.Drawing.Point(408, 36)
            Me.DoorsTextEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.DoorsTextEdit.Name = "DoorsTextEdit"
            Me.DoorsTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.DoorsTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.DoorsTextEdit.Properties.Mask.EditMask = "N0"
            Me.DoorsTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.DoorsTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.DoorsTextEdit.Size = New System.Drawing.Size(113, 20)
            Me.DoorsTextEdit.StyleController = Me.carDetailsLayout
            Me.DoorsTextEdit.TabIndex = 10
            ' 
            ' CylindersTextEdit
            ' 
            Me.CylindersTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Cylinders", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.CylindersTextEdit.Location = New System.Drawing.Point(408, 60)
            Me.CylindersTextEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.CylindersTextEdit.Name = "CylindersTextEdit"
            Me.CylindersTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.CylindersTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.CylindersTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.CylindersTextEdit.Properties.MaskSettings.[Set]("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
            Me.CylindersTextEdit.Properties.MaskSettings.[Set]("mask", "d")
            Me.CylindersTextEdit.Size = New System.Drawing.Size(113, 20)
            Me.CylindersTextEdit.StyleController = Me.carDetailsLayout
            Me.CylindersTextEdit.TabIndex = 12
            ' 
            ' HorsepowerTextEdit
            ' 
            Me.HorsepowerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Horsepower", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.HorsepowerTextEdit.Location = New System.Drawing.Point(408, 132)
            Me.HorsepowerTextEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.HorsepowerTextEdit.Name = "HorsepowerTextEdit"
            Me.HorsepowerTextEdit.Size = New System.Drawing.Size(113, 20)
            Me.HorsepowerTextEdit.StyleController = Me.carDetailsLayout
            Me.HorsepowerTextEdit.TabIndex = 13
            ' 
            ' TorqueTextEdit
            ' 
            Me.TorqueTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Torque", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.TorqueTextEdit.Location = New System.Drawing.Point(408, 84)
            Me.TorqueTextEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.TorqueTextEdit.Name = "TorqueTextEdit"
            Me.TorqueTextEdit.Size = New System.Drawing.Size(113, 20)
            Me.TorqueTextEdit.StyleController = Me.carDetailsLayout
            Me.TorqueTextEdit.TabIndex = 14
            ' 
            ' TransmissionSpeedsTextEdit
            ' 
            Me.TransmissionSpeedsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "TransmissionSpeeds", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.TransmissionSpeedsTextEdit.Location = New System.Drawing.Point(408, 156)
            Me.TransmissionSpeedsTextEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.TransmissionSpeedsTextEdit.Name = "TransmissionSpeedsTextEdit"
            Me.TransmissionSpeedsTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.TransmissionSpeedsTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.TransmissionSpeedsTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.TransmissionSpeedsTextEdit.Properties.MaskSettings.[Set]("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
            Me.TransmissionSpeedsTextEdit.Properties.MaskSettings.[Set]("mask", "d")
            Me.TransmissionSpeedsTextEdit.Size = New System.Drawing.Size(113, 20)
            Me.TransmissionSpeedsTextEdit.StyleController = Me.carDetailsLayout
            Me.TransmissionSpeedsTextEdit.TabIndex = 15
            ' 
            ' DescriptionTextEdit
            ' 
            Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Description", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.DescriptionTextEdit.Location = New System.Drawing.Point(111, 504)
            Me.DescriptionTextEdit.Margin = New System.Windows.Forms.Padding(2)
            Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
            Me.DescriptionTextEdit.Size = New System.Drawing.Size(146, 20)
            Me.DescriptionTextEdit.StyleController = Me.carDetailsLayout
            Me.DescriptionTextEdit.TabIndex = 17
            ' 
            ' PhotoPictureEdit
            ' 
            Me.PhotoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Photo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.PhotoPictureEdit.Location = New System.Drawing.Point(12, 12)
            Me.PhotoPictureEdit.Margin = New System.Windows.Forms.Padding(2)
            Me.PhotoPictureEdit.Name = "PhotoPictureEdit"
            Me.PhotoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.PhotoPictureEdit.Size = New System.Drawing.Size(271, 156)
            Me.PhotoPictureEdit.StyleController = Me.carDetailsLayout
            Me.PhotoPictureEdit.TabIndex = 18
            ' 
            ' DeliveryDateDateEdit
            ' 
            Me.DeliveryDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "DeliveryDate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.DeliveryDateDateEdit.EditValue = Nothing
            Me.DeliveryDateDateEdit.Location = New System.Drawing.Point(89, 244)
            Me.DeliveryDateDateEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.DeliveryDateDateEdit.Name = "DeliveryDateDateEdit"
            Me.DeliveryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DeliveryDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DeliveryDateDateEdit.Size = New System.Drawing.Size(194, 20)
            Me.DeliveryDateDateEdit.StyleController = Me.carDetailsLayout
            Me.DeliveryDateDateEdit.TabIndex = 19
            ' 
            ' InStockCheckEdit
            ' 
            Me.InStockCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "InStock", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.InStockCheckEdit.Location = New System.Drawing.Point(12, 268)
            Me.InStockCheckEdit.Margin = New System.Windows.Forms.Padding(2)
            Me.InStockCheckEdit.Name = "InStockCheckEdit"
            Me.InStockCheckEdit.Properties.Caption = "In Stock"
            Me.InStockCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.InStockCheckEdit.Size = New System.Drawing.Size(271, 20)
            Me.InStockCheckEdit.StyleController = Me.carDetailsLayout
            Me.InStockCheckEdit.TabIndex = 20
            ' 
            ' BodyStyleNameTextEdit
            ' 
            Me.BodyStyleNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "BodyStyleName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.BodyStyleNameTextEdit.Location = New System.Drawing.Point(111, 548)
            Me.BodyStyleNameTextEdit.Margin = New System.Windows.Forms.Padding(2)
            Me.BodyStyleNameTextEdit.Name = "BodyStyleNameTextEdit"
            Me.BodyStyleNameTextEdit.Properties.[ReadOnly] = True
            Me.BodyStyleNameTextEdit.Size = New System.Drawing.Size(146, 20)
            Me.BodyStyleNameTextEdit.StyleController = Me.carDetailsLayout
            Me.BodyStyleNameTextEdit.TabIndex = 21
            ' 
            ' TrademarkNameTextEdit
            ' 
            Me.TrademarkNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "TrademarkName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.TrademarkNameTextEdit.Location = New System.Drawing.Point(111, 548)
            Me.TrademarkNameTextEdit.Margin = New System.Windows.Forms.Padding(2)
            Me.TrademarkNameTextEdit.Name = "TrademarkNameTextEdit"
            Me.TrademarkNameTextEdit.Properties.[ReadOnly] = True
            Me.TrademarkNameTextEdit.Size = New System.Drawing.Size(146, 20)
            Me.TrademarkNameTextEdit.StyleController = Me.carDetailsLayout
            Me.TrademarkNameTextEdit.TabIndex = 22
            ' 
            ' CategoryNameTextEdit
            ' 
            Me.CategoryNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "CategoryName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.CategoryNameTextEdit.Location = New System.Drawing.Point(111, 548)
            Me.CategoryNameTextEdit.Margin = New System.Windows.Forms.Padding(2)
            Me.CategoryNameTextEdit.Name = "CategoryNameTextEdit"
            Me.CategoryNameTextEdit.Properties.[ReadOnly] = True
            Me.CategoryNameTextEdit.Size = New System.Drawing.Size(146, 20)
            Me.CategoryNameTextEdit.StyleController = Me.carDetailsLayout
            Me.CategoryNameTextEdit.TabIndex = 23
            ' 
            ' TransmissionTypeComboBoxEdit
            ' 
            Me.TransmissionTypeComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "TransmissionType", True))
            Me.TransmissionTypeComboBoxEdit.Location = New System.Drawing.Point(408, 108)
            Me.TransmissionTypeComboBoxEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.TransmissionTypeComboBoxEdit.Name = "TransmissionTypeComboBoxEdit"
            Me.TransmissionTypeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.TransmissionTypeComboBoxEdit.Size = New System.Drawing.Size(113, 20)
            Me.TransmissionTypeComboBoxEdit.StyleController = Me.carDetailsLayout
            Me.TransmissionTypeComboBoxEdit.TabIndex = 24
            ' 
            ' CategoryImageComboBoxEdit
            ' 
            Me.CategoryImageComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Category", True))
            Me.CategoryImageComboBoxEdit.Location = New System.Drawing.Point(408, 12)
            Me.CategoryImageComboBoxEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.CategoryImageComboBoxEdit.Name = "CategoryImageComboBoxEdit"
            Me.CategoryImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.CategoryImageComboBoxEdit.Size = New System.Drawing.Size(113, 20)
            Me.CategoryImageComboBoxEdit.StyleController = Me.carDetailsLayout
            Me.CategoryImageComboBoxEdit.TabIndex = 26
            ' 
            ' BodyStyleImageComboBoxEdit
            ' 
            Me.BodyStyleImageComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "BodyStyle", True))
            Me.BodyStyleImageComboBoxEdit.Location = New System.Drawing.Point(0, 0)
            Me.BodyStyleImageComboBoxEdit.Name = "BodyStyleImageComboBoxEdit"
            Me.BodyStyleImageComboBoxEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.BodyStyleImageComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.BodyStyleImageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.BodyStyleImageComboBoxEdit.Size = New System.Drawing.Size(0, 20)
            Me.BodyStyleImageComboBoxEdit.StyleController = Me.carDetailsLayout
            Me.BodyStyleImageComboBoxEdit.TabIndex = 27
            ' 
            ' ItemForCategoryName
            ' 
            Me.ItemForCategoryName.Control = Me.CategoryNameTextEdit
            Me.ItemForCategoryName.Location = New System.Drawing.Point(0, 542)
            Me.ItemForCategoryName.Name = "ItemForCategoryName"
            Me.ItemForCategoryName.Size = New System.Drawing.Size(253, 22)
            Me.ItemForCategoryName.Text = "Category Name"
            Me.ItemForCategoryName.TextSize = New System.Drawing.Size(97, 12)
            ' 
            ' ItemForTrademarkName
            ' 
            Me.ItemForTrademarkName.Control = Me.TrademarkNameTextEdit
            Me.ItemForTrademarkName.Location = New System.Drawing.Point(0, 542)
            Me.ItemForTrademarkName.Name = "ItemForTrademarkName"
            Me.ItemForTrademarkName.Size = New System.Drawing.Size(253, 22)
            Me.ItemForTrademarkName.Text = "Trademark Name"
            Me.ItemForTrademarkName.TextSize = New System.Drawing.Size(97, 12)
            ' 
            ' ItemForBodyStyleName
            ' 
            Me.ItemForBodyStyleName.Control = Me.BodyStyleNameTextEdit
            Me.ItemForBodyStyleName.Location = New System.Drawing.Point(0, 542)
            Me.ItemForBodyStyleName.Name = "ItemForBodyStyleName"
            Me.ItemForBodyStyleName.Size = New System.Drawing.Size(253, 22)
            Me.ItemForBodyStyleName.Text = "Body Style Name"
            Me.ItemForBodyStyleName.TextSize = New System.Drawing.Size(97, 12)
            ' 
            ' ItemForDescription
            ' 
            Me.ItemForDescription.Control = Me.DescriptionTextEdit
            Me.ItemForDescription.Location = New System.Drawing.Point(0, 498)
            Me.ItemForDescription.Name = "ItemForDescription"
            Me.ItemForDescription.Size = New System.Drawing.Size(253, 22)
            Me.ItemForDescription.Text = "Description"
            Me.ItemForDescription.TextSize = New System.Drawing.Size(97, 12)
            ' 
            ' ItemForBodyStyle
            ' 
            Me.ItemForBodyStyle.Control = Me.BodyStyleImageComboBoxEdit
            Me.ItemForBodyStyle.Location = New System.Drawing.Point(0, 24)
            Me.ItemForBodyStyle.Name = "ItemForBodyStyle"
            Me.ItemForBodyStyle.Size = New System.Drawing.Size(236, 24)
            Me.ItemForBodyStyle.Text = "Body Style"
            Me.ItemForBodyStyle.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(533, 321)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForPhoto, Me.ItemForName, Me.ItemForModification, Me.emptySpaceItem1, Me.ItemForInStock, Me.ItemForPrice, Me.layoutControlGroup2, Me.ItemForDeliveryDate})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(513, 301)
            ' 
            ' ItemForPhoto
            ' 
            Me.ItemForPhoto.Control = Me.PhotoPictureEdit
            Me.ItemForPhoto.Location = New System.Drawing.Point(0, 0)
            Me.ItemForPhoto.MaxSize = New System.Drawing.Size(275, 160)
            Me.ItemForPhoto.MinSize = New System.Drawing.Size(275, 160)
            Me.ItemForPhoto.Name = "ItemForPhoto"
            Me.ItemForPhoto.Size = New System.Drawing.Size(275, 160)
            Me.ItemForPhoto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForPhoto.StartNewLine = True
            Me.ItemForPhoto.Text = "Photo"
            Me.ItemForPhoto.TextVisible = False
            ' 
            ' ItemForName
            ' 
            Me.ItemForName.Control = Me.NameTextEdit
            Me.ItemForName.Location = New System.Drawing.Point(0, 160)
            Me.ItemForName.Name = "ItemForName"
            Me.ItemForName.Size = New System.Drawing.Size(275, 24)
            Me.ItemForName.Text = "Name"
            Me.ItemForName.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' ItemForModification
            ' 
            Me.ItemForModification.Control = Me.ModificationTextEdit
            Me.ItemForModification.Location = New System.Drawing.Point(0, 184)
            Me.ItemForModification.Name = "ItemForModification"
            Me.ItemForModification.Size = New System.Drawing.Size(275, 24)
            Me.ItemForModification.Text = "Modification"
            Me.ItemForModification.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 280)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(275, 21)
            ' 
            ' ItemForInStock
            ' 
            Me.ItemForInStock.Control = Me.InStockCheckEdit
            Me.ItemForInStock.Location = New System.Drawing.Point(0, 256)
            Me.ItemForInStock.Name = "ItemForInStock"
            Me.ItemForInStock.Size = New System.Drawing.Size(275, 24)
            Me.ItemForInStock.Text = "In Stock"
            Me.ItemForInStock.TextVisible = False
            ' 
            ' ItemForPrice
            ' 
            Me.ItemForPrice.Control = Me.PriceTextEdit
            Me.ItemForPrice.Location = New System.Drawing.Point(0, 208)
            Me.ItemForPrice.Name = "ItemForPrice"
            Me.ItemForPrice.Size = New System.Drawing.Size(275, 24)
            Me.ItemForPrice.Text = "Price"
            Me.ItemForPrice.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForDoors, Me.ItemForCylinders, Me.ItemForTransmissionSpeeds, Me.ItemForMPGCity, Me.emptySpaceItem2, Me.ItemForCategory, Me.ItemForHorsepower, Me.ItemForTorque, Me.ItemForTransmissionType, Me.ItemForMPGHighway})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(275, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(238, 301)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' ItemForDoors
            ' 
            Me.ItemForDoors.Control = Me.DoorsTextEdit
            Me.ItemForDoors.Location = New System.Drawing.Point(0, 24)
            Me.ItemForDoors.Name = "ItemForDoors"
            Me.ItemForDoors.Size = New System.Drawing.Size(228, 24)
            Me.ItemForDoors.Text = "Doors"
            Me.ItemForDoors.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForDoors.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' ItemForCylinders
            ' 
            Me.ItemForCylinders.Control = Me.CylindersTextEdit
            Me.ItemForCylinders.Location = New System.Drawing.Point(0, 48)
            Me.ItemForCylinders.Name = "ItemForCylinders"
            Me.ItemForCylinders.Size = New System.Drawing.Size(228, 24)
            Me.ItemForCylinders.Text = "Cylinders"
            Me.ItemForCylinders.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForCylinders.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' ItemForTransmissionSpeeds
            ' 
            Me.ItemForTransmissionSpeeds.Control = Me.TransmissionSpeedsTextEdit
            Me.ItemForTransmissionSpeeds.Location = New System.Drawing.Point(0, 144)
            Me.ItemForTransmissionSpeeds.Name = "ItemForTransmissionSpeeds"
            Me.ItemForTransmissionSpeeds.Size = New System.Drawing.Size(228, 24)
            Me.ItemForTransmissionSpeeds.Text = "Transmission Speeds"
            Me.ItemForTransmissionSpeeds.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForTransmissionSpeeds.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' ItemForMPGCity
            ' 
            Me.ItemForMPGCity.Control = Me.MPGCityTextEdit
            Me.ItemForMPGCity.Location = New System.Drawing.Point(0, 192)
            Me.ItemForMPGCity.Name = "ItemForMPGCity"
            Me.ItemForMPGCity.Size = New System.Drawing.Size(228, 24)
            Me.ItemForMPGCity.Text = "MPG City"
            Me.ItemForMPGCity.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForMPGCity.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 216)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(228, 85)
            ' 
            ' ItemForCategory
            ' 
            Me.ItemForCategory.Control = Me.CategoryImageComboBoxEdit
            Me.ItemForCategory.Location = New System.Drawing.Point(0, 0)
            Me.ItemForCategory.Name = "ItemForCategory"
            Me.ItemForCategory.Size = New System.Drawing.Size(228, 24)
            Me.ItemForCategory.Text = "Category"
            Me.ItemForCategory.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForCategory.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' ItemForHorsepower
            ' 
            Me.ItemForHorsepower.Control = Me.HorsepowerTextEdit
            Me.ItemForHorsepower.Location = New System.Drawing.Point(0, 120)
            Me.ItemForHorsepower.Name = "ItemForHorsepower"
            Me.ItemForHorsepower.Size = New System.Drawing.Size(228, 24)
            Me.ItemForHorsepower.Text = "Horsepower"
            Me.ItemForHorsepower.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForHorsepower.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' ItemForTorque
            ' 
            Me.ItemForTorque.Control = Me.TorqueTextEdit
            Me.ItemForTorque.Location = New System.Drawing.Point(0, 72)
            Me.ItemForTorque.Name = "ItemForTorque"
            Me.ItemForTorque.Size = New System.Drawing.Size(228, 24)
            Me.ItemForTorque.Text = "Torque"
            Me.ItemForTorque.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForTorque.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' ItemForTransmissionType
            ' 
            Me.ItemForTransmissionType.Control = Me.TransmissionTypeComboBoxEdit
            Me.ItemForTransmissionType.Location = New System.Drawing.Point(0, 96)
            Me.ItemForTransmissionType.Name = "ItemForTransmissionType"
            Me.ItemForTransmissionType.Size = New System.Drawing.Size(228, 24)
            Me.ItemForTransmissionType.Text = "Transmission Type"
            Me.ItemForTransmissionType.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForTransmissionType.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' ItemForMPGHighway
            ' 
            Me.ItemForMPGHighway.Control = Me.MPGHighwayTextEdit
            Me.ItemForMPGHighway.Location = New System.Drawing.Point(0, 168)
            Me.ItemForMPGHighway.Name = "ItemForMPGHighway"
            Me.ItemForMPGHighway.Size = New System.Drawing.Size(228, 24)
            Me.ItemForMPGHighway.Text = "MPG Highway"
            Me.ItemForMPGHighway.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForMPGHighway.TextSize = New System.Drawing.Size(99, 13)
            ' 
            ' ItemForDeliveryDate
            ' 
            Me.ItemForDeliveryDate.Control = Me.DeliveryDateDateEdit
            Me.ItemForDeliveryDate.Location = New System.Drawing.Point(0, 232)
            Me.ItemForDeliveryDate.Name = "ItemForDeliveryDate"
            Me.ItemForDeliveryDate.Size = New System.Drawing.Size(275, 24)
            Me.ItemForDeliveryDate.Text = "Delivery Date"
            Me.ItemForDeliveryDate.TextLocation = DevExpress.Utils.Locations.Left
            Me.ItemForDeliveryDate.TextSize = New System.Drawing.Size(65, 13)
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F)})
            Me.tablePanel1.Controls.Add(Me.vSeparator)
            Me.tablePanel1.Controls.Add(Me.hSeparator)
            Me.tablePanel1.Controls.Add(Me.catalogueTree)
            Me.tablePanel1.Controls.Add(Me.carDetailsLayout)
            Me.tablePanel1.Controls.Add(Me.grid)
            Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.39F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.61F)})
            Me.tablePanel1.Size = New System.Drawing.Size(800, 600)
            Me.tablePanel1.TabIndex = 3
            ' 
            ' vSeparator
            ' 
            Me.vSeparator.AutoSizeMode = True
            Me.tablePanel1.SetColumn(Me.vSeparator, 1)
            Me.vSeparator.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vSeparator.LineOrientation = System.Windows.Forms.Orientation.Vertical
            Me.vSeparator.Location = New System.Drawing.Point(266, 0)
            Me.vSeparator.Margin = New System.Windows.Forms.Padding(0)
            Me.vSeparator.Name = "vSeparator"
            Me.vSeparator.Padding = New System.Windows.Forms.Padding(0)
            Me.tablePanel1.SetRow(Me.vSeparator, 0)
            Me.tablePanel1.SetRowSpan(Me.vSeparator, 3)
            Me.vSeparator.Size = New System.Drawing.Size(1, 600)
            Me.vSeparator.TabIndex = 4
            ' 
            ' hSeparator
            ' 
            Me.hSeparator.AutoSizeMode = True
            Me.tablePanel1.SetColumn(Me.hSeparator, 2)
            Me.hSeparator.Dock = System.Windows.Forms.DockStyle.Fill
            Me.hSeparator.Location = New System.Drawing.Point(267, 278)
            Me.hSeparator.Margin = New System.Windows.Forms.Padding(0)
            Me.hSeparator.Name = "hSeparator"
            Me.hSeparator.Padding = New System.Windows.Forms.Padding(0)
            Me.tablePanel1.SetRow(Me.hSeparator, 1)
            Me.hSeparator.Size = New System.Drawing.Size(533, 1)
            Me.hSeparator.TabIndex = 3
            ' 
            ' CarRentalCatalogue
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.tablePanel1)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "CarRentalCatalogue"
            Me.Size = New System.Drawing.Size(800, 600)
            CType((Me.fileExplorerAssistant), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.catalogueTree), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.grid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.winExplorerView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.carDetailsLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.carDetailsLayout.ResumeLayout(False)
            CType((Me.NameTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.modelBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ModificationTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.PriceTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.MPGCityTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.MPGHighwayTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.DoorsTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.CylindersTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.HorsepowerTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.TorqueTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.TransmissionSpeedsTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.DescriptionTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.PhotoPictureEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.DeliveryDateDateEdit.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.DeliveryDateDateEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.InStockCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.BodyStyleNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.TrademarkNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.CategoryNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.TransmissionTypeComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.CategoryImageComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.BodyStyleImageComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForCategoryName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForTrademarkName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForBodyStyleName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForDescription), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForBodyStyle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForPhoto), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForModification), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForInStock), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForPrice), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForDoors), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForCylinders), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForTransmissionSpeeds), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForMPGCity), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForCategory), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForHorsepower), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForTorque), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForTransmissionType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForMPGHighway), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForDeliveryDate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            CType((Me.vSeparator), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.hSeparator), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private fileExplorerAssistant As DevExpress.XtraDialogs.FileExplorerAssistant

        Private catalogueTree As DevExpress.XtraTreeList.TreeList

        Private grid As DevExpress.XtraGrid.GridControl

        Private winExplorerView1 As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView

        Private carDetailsLayout As DevExpress.XtraDataLayout.DataLayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private modelBindingSource As System.Windows.Forms.BindingSource

        Private NameTextEdit As DevExpress.XtraEditors.TextEdit

        Private ModificationTextEdit As DevExpress.XtraEditors.TextEdit

        Private PriceTextEdit As DevExpress.XtraEditors.TextEdit

        Private MPGCityTextEdit As DevExpress.XtraEditors.TextEdit

        Private MPGHighwayTextEdit As DevExpress.XtraEditors.TextEdit

        Private DoorsTextEdit As DevExpress.XtraEditors.TextEdit

        Private CylindersTextEdit As DevExpress.XtraEditors.TextEdit

        Private HorsepowerTextEdit As DevExpress.XtraEditors.TextEdit

        Private TorqueTextEdit As DevExpress.XtraEditors.TextEdit

        Private TransmissionSpeedsTextEdit As DevExpress.XtraEditors.TextEdit

        Private DescriptionTextEdit As DevExpress.XtraEditors.TextEdit

        Private PhotoPictureEdit As DevExpress.XtraEditors.PictureEdit

        Private DeliveryDateDateEdit As DevExpress.XtraEditors.DateEdit

        Private InStockCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private BodyStyleNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private TrademarkNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private CategoryNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private ItemForName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForModification As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForCategory As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForPrice As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForMPGCity As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForMPGHighway As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForDoors As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForBodyStyle As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForCylinders As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForHorsepower As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForTorque As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForTransmissionSpeeds As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForTransmissionType As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForDescription As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForDeliveryDate As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForInStock As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForBodyStyleName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForTrademarkName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForCategoryName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForPhoto As DevExpress.XtraLayout.LayoutControlItem

        Private vSeparator As DevExpress.XtraEditors.SeparatorControl

        Private hSeparator As DevExpress.XtraEditors.SeparatorControl

        Private TransmissionTypeComboBoxEdit As DevExpress.XtraEditors.ImageComboBoxEdit

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private CategoryImageComboBoxEdit As DevExpress.XtraEditors.ImageComboBoxEdit

        Private BodyStyleImageComboBoxEdit As DevExpress.XtraEditors.ImageComboBoxEdit
    End Class
End Namespace
