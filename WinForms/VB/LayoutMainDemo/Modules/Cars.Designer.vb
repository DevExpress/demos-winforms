Namespace DevExpress.XtraLayout.Demos

    Partial Class Cars

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
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
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraLayout.Demos.Cars))
            Me.colLogo = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colName1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.layoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.modelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.vehiclesDataSet1 = New DevExpress.XtraLayout.Demos.VehiclesDataSet()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
            Me.calcEdit1 = New DevExpress.XtraEditors.CalcEdit()
            Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
            Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
            Me.textEdit4 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
            Me.spinEdit3 = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEdit4 = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.textEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.trademarkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.textEdit1View = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colID = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colSite = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.categoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.imageComboBoxEdit1View = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colID1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPicture = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.checkEdit2 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.modelBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.vehiclesDataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateEdit1.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.calcEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.hyperLinkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trademarkBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.categoryBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageComboBoxEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabbedControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colLogo
            ' 
            Me.colLogo.FieldName = "Logo"
            Me.colLogo.Name = "colLogo"
            Me.colLogo.Visible = True
            Me.colLogo.VisibleIndex = 3
            ' 
            ' colName1
            ' 
            Me.colName1.FieldName = "Name"
            Me.colName1.Name = "colName1"
            Me.colName1.Visible = True
            Me.colName1.VisibleIndex = 1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControl1.Controls.Add(Me.dataNavigator1)
            Me.layoutControl1.Controls.Add(Me.memoEdit1)
            Me.layoutControl1.Controls.Add(Me.pictureEdit1)
            Me.layoutControl1.Controls.Add(Me.dateEdit1)
            Me.layoutControl1.Controls.Add(Me.calcEdit1)
            Me.layoutControl1.Controls.Add(Me.textEdit2)
            Me.layoutControl1.Controls.Add(Me.hyperLinkEdit1)
            Me.layoutControl1.Controls.Add(Me.spinEdit1)
            Me.layoutControl1.Controls.Add(Me.textEdit4)
            Me.layoutControl1.Controls.Add(Me.textEdit3)
            Me.layoutControl1.Controls.Add(Me.spinEdit3)
            Me.layoutControl1.Controls.Add(Me.spinEdit4)
            Me.layoutControl1.Controls.Add(Me.spinEdit2)
            Me.layoutControl1.Controls.Add(Me.checkEdit1)
            Me.layoutControl1.Controls.Add(Me.textEdit1)
            Me.layoutControl1.Controls.Add(Me.imageComboBoxEdit1)
            Me.layoutControl1.Controls.Add(Me.checkEdit2)
            Me.layoutControl1.DataSource = Me.modelBindingSource
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Images = Me.svgImageCollection1
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-1411, 122, 650, 400)
            Me.layoutControl1.OptionsSerialization.RestoreGroupPadding = True
            Me.layoutControl1.OptionsSerialization.RestoreGroupSpacing = True
            Me.layoutControl1.OptionsSerialization.RestoreRootGroupPadding = True
            Me.layoutControl1.OptionsSerialization.RestoreRootGroupSpacing = True
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(666, 530)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' dataNavigator1
            ' 
            Me.dataNavigator1.Buttons.Append.Visible = False
            Me.dataNavigator1.DataSource = Me.modelBindingSource
            Me.dataNavigator1.Location = New System.Drawing.Point(7, 504)
            Me.dataNavigator1.Name = "dataNavigator1"
            Me.dataNavigator1.Size = New System.Drawing.Size(239, 19)
            Me.dataNavigator1.StyleController = Me.layoutControl1
            Me.dataNavigator1.TabIndex = 19
            Me.dataNavigator1.Text = "dataNavigator1"
            Me.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
            ' 
            ' modelBindingSource
            ' 
            Me.modelBindingSource.DataMember = "Model"
            Me.modelBindingSource.DataSource = Me.vehiclesDataSet1
            Me.modelBindingSource.Sort = ""
            ' 
            ' vehiclesDataSet1
            ' 
            Me.vehiclesDataSet1.DataSetName = "VehiclesDataSet"
            Me.vehiclesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Description", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.memoEdit1.EditValue = "memoEdit1"
            Me.memoEdit1.Location = New System.Drawing.Point(7, 217)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(652, 283)
            Me.memoEdit1.StyleController = Me.layoutControl1
            Me.memoEdit1.TabIndex = 12
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pictureEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Photo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.pictureEdit1.Location = New System.Drawing.Point(383, 43)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.[True]
            Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.pictureEdit1.Size = New System.Drawing.Size(266, 144)
            Me.pictureEdit1.StyleController = Me.layoutControl1
            Me.pictureEdit1.TabIndex = 3
            ' 
            ' dateEdit1
            ' 
            Me.dateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Delivery Date", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.dateEdit1.EditValue = New System.DateTime((CLng((0))))
            Me.dateEdit1.Location = New System.Drawing.Point(304, 115)
            Me.dateEdit1.Name = "dateEdit1"
            Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dateEdit1.Size = New System.Drawing.Size(75, 20)
            Me.dateEdit1.StyleController = Me.layoutControl1
            Me.dateEdit1.TabIndex = 9
            ' 
            ' calcEdit1
            ' 
            Me.calcEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Price", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.calcEdit1.Location = New System.Drawing.Point(121, 115)
            Me.calcEdit1.Name = "calcEdit1"
            Me.calcEdit1.Properties.AppearanceDisabled.Options.UseTextOptions = True
            Me.calcEdit1.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.calcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.calcEdit1.Properties.Mask.EditMask = "c"
            Me.calcEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.calcEdit1.Size = New System.Drawing.Size(75, 20)
            Me.calcEdit1.StyleController = Me.layoutControl1
            Me.calcEdit1.TabIndex = 7
            ' 
            ' textEdit2
            ' 
            Me.textEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Name", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.textEdit2.EditValue = "textEdit2"
            Me.textEdit2.Location = New System.Drawing.Point(121, 67)
            Me.textEdit2.Name = "textEdit2"
            Me.textEdit2.Size = New System.Drawing.Size(258, 20)
            Me.textEdit2.StyleController = Me.layoutControl1
            Me.textEdit2.TabIndex = 4
            ' 
            ' hyperLinkEdit1
            ' 
            Me.hyperLinkEdit1.EditValue = "hyperLinkEdit1"
            Me.hyperLinkEdit1.Location = New System.Drawing.Point(200, 91)
            Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
            Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.hyperLinkEdit1.Size = New System.Drawing.Size(179, 18)
            Me.hyperLinkEdit1.StyleController = Me.layoutControl1
            Me.hyperLinkEdit1.TabIndex = 6
            ' 
            ' spinEdit1
            ' 
            Me.spinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Cylinders", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(440, 67)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.IsFloatValue = False
            Me.spinEdit1.Properties.Mask.EditMask = "N00"
            Me.spinEdit1.Size = New System.Drawing.Size(209, 20)
            Me.spinEdit1.StyleController = Me.layoutControl1
            Me.spinEdit1.TabIndex = 14
            ' 
            ' textEdit4
            ' 
            Me.textEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Modification", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.textEdit4.EditValue = "textEdit4"
            Me.textEdit4.Location = New System.Drawing.Point(121, 43)
            Me.textEdit4.Name = "textEdit4"
            Me.textEdit4.Properties.DisplayFormat.FormatString = "#.## Liters"
            Me.textEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.textEdit4.Size = New System.Drawing.Size(528, 20)
            Me.textEdit4.StyleController = Me.layoutControl1
            Me.textEdit4.TabIndex = 15
            ' 
            ' textEdit3
            ' 
            Me.textEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Horsepower", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.textEdit3.EditValue = "textEdit3"
            Me.textEdit3.Location = New System.Drawing.Point(121, 67)
            Me.textEdit3.Name = "textEdit3"
            Me.textEdit3.Size = New System.Drawing.Size(211, 20)
            Me.textEdit3.StyleController = Me.layoutControl1
            Me.textEdit3.TabIndex = 13
            ' 
            ' spinEdit3
            ' 
            Me.spinEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "MPG City", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinEdit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit3.Location = New System.Drawing.Point(121, 91)
            Me.spinEdit3.Name = "spinEdit3"
            Me.spinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit3.Properties.IsFloatValue = False
            Me.spinEdit3.Properties.Mask.EditMask = "N00"
            Me.spinEdit3.Size = New System.Drawing.Size(211, 20)
            Me.spinEdit3.StyleController = Me.layoutControl1
            Me.spinEdit3.TabIndex = 16
            ' 
            ' spinEdit4
            ' 
            Me.spinEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Doors", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinEdit4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit4.Location = New System.Drawing.Point(121, 115)
            Me.spinEdit4.Name = "spinEdit4"
            Me.spinEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit4.Properties.IsFloatValue = False
            Me.spinEdit4.Properties.Mask.EditMask = "N00"
            Me.spinEdit4.Size = New System.Drawing.Size(211, 20)
            Me.spinEdit4.StyleController = Me.layoutControl1
            Me.spinEdit4.TabIndex = 17
            ' 
            ' spinEdit2
            ' 
            Me.spinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "MPG Highway", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit2.Location = New System.Drawing.Point(440, 91)
            Me.spinEdit2.Name = "spinEdit2"
            Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit2.Properties.IsFloatValue = False
            Me.spinEdit2.Properties.Mask.EditMask = "N00"
            Me.spinEdit2.Size = New System.Drawing.Size(209, 20)
            Me.spinEdit2.StyleController = Me.layoutControl1
            Me.spinEdit2.TabIndex = 1
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "InStock", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.checkEdit1.EditValue = Nothing
            Me.checkEdit1.Location = New System.Drawing.Point(17, 139)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
            Me.checkEdit1.Properties.Caption = "In stock?"
            Me.checkEdit1.Size = New System.Drawing.Size(179, 20)
            Me.checkEdit1.StyleController = Me.layoutControl1
            Me.checkEdit1.TabIndex = 10
            Me.checkEdit1.TabStop = False
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "TrademarkID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.textEdit1.Location = New System.Drawing.Point(121, 43)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.textEdit1.Properties.DataSource = Me.trademarkBindingSource
            Me.textEdit1.Properties.DisplayMember = "Name"
            Me.textEdit1.Properties.NullText = ""
            Me.textEdit1.Properties.PopupView = Me.textEdit1View
            Me.textEdit1.Properties.ValueMember = "ID"
            Me.textEdit1.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.TileView
            Me.textEdit1.Size = New System.Drawing.Size(258, 20)
            Me.textEdit1.StyleController = Me.layoutControl1
            Me.textEdit1.TabIndex = 2
            ' 
            ' trademarkBindingSource
            ' 
            Me.trademarkBindingSource.DataMember = "Trademark"
            Me.trademarkBindingSource.DataSource = Me.vehiclesDataSet1
            Me.trademarkBindingSource.Sort = ""
            ' 
            ' textEdit1View
            ' 
            Me.textEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colName, Me.colSite, Me.colLogo, Me.colDescription})
            Me.textEdit1View.Name = "textEdit1View"
            Me.textEdit1View.OptionsBehavior.AllowSmoothScrolling = True
            Me.textEdit1View.OptionsTiles.AllowPressAnimation = False
            Me.textEdit1View.OptionsTiles.IndentBetweenGroups = 0
            Me.textEdit1View.OptionsTiles.IndentBetweenItems = 0
            Me.textEdit1View.OptionsTiles.ItemSize = New System.Drawing.Size(248, 55)
            Me.textEdit1View.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.textEdit1View.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.textEdit1View.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.textEdit1View.OptionsTiles.RowCount = 0
            Me.textEdit1View.TileRows.Add(tableRowDefinition1)
            tileViewItemElement1.Column = Me.colLogo
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement1.Text = "colLogo"
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.textEdit1View.TileTemplate.Add(tileViewItemElement1)
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 1
            ' 
            ' colSite
            ' 
            Me.colSite.FieldName = "Site"
            Me.colSite.Name = "colSite"
            Me.colSite.Visible = True
            Me.colSite.VisibleIndex = 2
            ' 
            ' colDescription
            ' 
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 4
            ' 
            ' imageComboBoxEdit1
            ' 
            Me.imageComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "CategoryID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.imageComboBoxEdit1.Location = New System.Drawing.Point(121, 91)
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit1.Properties.DataSource = Me.categoryBindingSource
            Me.imageComboBoxEdit1.Properties.DisplayMember = "Name"
            Me.imageComboBoxEdit1.Properties.NullText = ""
            Me.imageComboBoxEdit1.Properties.PopupSizeable = False
            Me.imageComboBoxEdit1.Properties.PopupView = Me.imageComboBoxEdit1View
            Me.imageComboBoxEdit1.Properties.ValueMember = "ID"
            Me.imageComboBoxEdit1.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.TileView
            Me.imageComboBoxEdit1.Size = New System.Drawing.Size(75, 20)
            Me.imageComboBoxEdit1.StyleController = Me.layoutControl1
            Me.imageComboBoxEdit1.TabIndex = 5
            ' 
            ' categoryBindingSource
            ' 
            Me.categoryBindingSource.DataMember = "Category"
            Me.categoryBindingSource.DataSource = Me.vehiclesDataSet1
            Me.categoryBindingSource.Sort = ""
            ' 
            ' imageComboBoxEdit1View
            ' 
            Me.imageComboBoxEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colName1, Me.colPicture})
            Me.imageComboBoxEdit1View.Name = "imageComboBoxEdit1View"
            Me.imageComboBoxEdit1View.OptionsBehavior.AllowSmoothScrolling = True
            Me.imageComboBoxEdit1View.OptionsTiles.AllowPressAnimation = False
            Me.imageComboBoxEdit1View.OptionsTiles.IndentBetweenGroups = 0
            Me.imageComboBoxEdit1View.OptionsTiles.IndentBetweenItems = 0
            Me.imageComboBoxEdit1View.OptionsTiles.ItemSize = New System.Drawing.Size(248, 55)
            Me.imageComboBoxEdit1View.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.imageComboBoxEdit1View.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.imageComboBoxEdit1View.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.imageComboBoxEdit1View.OptionsTiles.RowCount = 0
            Me.imageComboBoxEdit1View.TileRows.Add(tableRowDefinition2)
            tileViewItemElement2.Column = Me.colName1
            tileViewItemElement2.Text = "colName1"
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.imageComboBoxEdit1View.TileTemplate.Add(tileViewItemElement2)
            ' 
            ' colID1
            ' 
            Me.colID1.FieldName = "ID"
            Me.colID1.Name = "colID1"
            Me.colID1.Visible = True
            Me.colID1.VisibleIndex = 0
            ' 
            ' colPicture
            ' 
            Me.colPicture.FieldName = "Picture"
            Me.colPicture.Name = "colPicture"
            Me.colPicture.Visible = True
            Me.colPicture.VisibleIndex = 2
            ' 
            ' checkEdit2
            ' 
            Me.checkEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.modelBindingSource, "Transmission Type", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.checkEdit2.Location = New System.Drawing.Point(440, 115)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Appearance.Options.UseTextOptions = True
            Me.checkEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.checkEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.checkEdit2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Automatic", 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Manual", 2, -1)})
            Me.checkEdit2.Size = New System.Drawing.Size(209, 20)
            Me.checkEdit2.StyleController = Me.layoutControl1
            Me.checkEdit2.TabIndex = 18
            Me.checkEdit2.TabStop = False
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Person", CType((resources.GetObject("svgImageCollection1.Person")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("House", CType((resources.GetObject("svgImageCollection1.House")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Notes", CType((resources.GetObject("svgImageCollection1.Notes")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("OrderDetails", CType((resources.GetObject("svgImageCollection1.OrderDetails")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Settings", CType((resources.GetObject("svgImageCollection1.Settings")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Categories", CType((resources.GetObject("svgImageCollection1.Categories")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Product", CType((resources.GetObject("svgImageCollection1.Product")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("OrderDetails", CType((resources.GetObject("svgImageCollection1.OrderDetails1")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' Root
            ' 
            Me.Root.CustomizationFormText = "Main"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem10, Me.tabbedControlGroup1, Me.layoutControlItem17, Me.emptySpaceItem1})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.Root.Size = New System.Drawing.Size(666, 530)
            Me.Root.Text = "Main"
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.memoEdit1
            Me.layoutControlItem10.CustomizationFormText = "&Description: "
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 194)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(656, 303)
            Me.layoutControlItem10.Text = "&Description: "
            Me.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' tabbedControlGroup1
            ' 
            Me.tabbedControlGroup1.CustomizationFormText = "TabbedGroup"
            Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
            Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup1
            Me.tabbedControlGroup1.Size = New System.Drawing.Size(656, 194)
            Me.tabbedControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1, Me.layoutControlGroup2})
            Me.tabbedControlGroup1.Text = "TabbedGroup"
            Me.tabbedControlGroup1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CaptionImageOptions.ImageIndex = 3
            Me.layoutControlGroup1.CustomizationFormText = "Details"
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem8, Me.layoutControlItem6, Me.layoutControlItem4, Me.layoutControlItem3, Me.layoutControlItem5, Me.layoutControlItem9})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(636, 148)
            Me.layoutControlGroup1.Text = "Details"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.textEdit1
            Me.layoutControlItem1.CustomizationFormText = "&Manufacturer:   "
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(366, 24)
            Me.layoutControlItem1.Text = "&Manufacturer:   "
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.pictureEdit1
            Me.layoutControlItem2.CustomizationFormText = "Picture"
            Me.layoutControlItem2.Location = New System.Drawing.Point(366, 0)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(270, 148)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(270, 148)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(270, 148)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.Text = "Picture"
            Me.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.dateEdit1
            Me.layoutControlItem8.CustomizationFormText = "Delivery Date:"
            Me.layoutControlItem8.Location = New System.Drawing.Point(183, 72)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(183, 76)
            Me.layoutControlItem8.Text = "Delivery Date:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.calcEdit1
            Me.layoutControlItem6.CustomizationFormText = "Price:"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(183, 24)
            Me.layoutControlItem6.Text = "Price:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.imageComboBoxEdit1
            Me.layoutControlItem4.CustomizationFormText = "Category: "
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(183, 24)
            Me.layoutControlItem4.Text = "Category: "
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.textEdit2
            Me.layoutControlItem3.CustomizationFormText = "Model:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(366, 24)
            Me.layoutControlItem3.Text = "Model:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.hyperLinkEdit1
            Me.layoutControlItem5.CustomizationFormText = "Hyperlink:"
            Me.layoutControlItem5.Location = New System.Drawing.Point(183, 48)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(183, 24)
            Me.layoutControlItem5.Text = "Hyperlink:"
            Me.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.layoutControlItem5.TextToControlDistance = 0
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.checkEdit1
            Me.layoutControlItem9.CustomizationFormText = "In stock?"
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(183, 52)
            Me.layoutControlItem9.Text = "In stock?"
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CaptionImageOptions.ImageIndex = 4
            Me.layoutControlGroup2.CustomizationFormText = "&Performance Attributes"
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem11, Me.layoutControlItem16, Me.layoutControlItem13, Me.layoutControlItem12, Me.layoutControlItem7, Me.layoutControlItem14, Me.layoutControlItem15})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(636, 148)
            Me.layoutControlGroup2.Text = "&Performance Attributes"
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.spinEdit1
            Me.layoutControlItem11.CustomizationFormText = "Cyl:"
            Me.layoutControlItem11.Location = New System.Drawing.Point(319, 24)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(317, 24)
            Me.layoutControlItem11.Text = "Cyl:"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.Control = Me.checkEdit2
            Me.layoutControlItem16.CustomizationFormText = "Automatic Transmission"
            Me.layoutControlItem16.Location = New System.Drawing.Point(319, 72)
            Me.layoutControlItem16.Name = "layoutControlItem16"
            Me.layoutControlItem16.Size = New System.Drawing.Size(317, 76)
            Me.layoutControlItem16.Text = "Transmission Type:"
            Me.layoutControlItem16.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.Control = Me.spinEdit2
            Me.layoutControlItem13.CustomizationFormText = "MPG Highway:"
            Me.layoutControlItem13.Location = New System.Drawing.Point(319, 48)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Size = New System.Drawing.Size(317, 24)
            Me.layoutControlItem13.Text = "MPG Highway:"
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.textEdit4
            Me.layoutControlItem12.CustomizationFormText = "Capacity:"
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(636, 24)
            Me.layoutControlItem12.Text = "Capacity:"
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.textEdit3
            Me.layoutControlItem7.CustomizationFormText = "HP:"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(319, 24)
            Me.layoutControlItem7.Text = "HP:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.Control = Me.spinEdit3
            Me.layoutControlItem14.CustomizationFormText = "MPG City:"
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Size = New System.Drawing.Size(319, 24)
            Me.layoutControlItem14.Text = "MPG City:"
            Me.layoutControlItem14.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem15
            ' 
            Me.layoutControlItem15.Control = Me.spinEdit4
            Me.layoutControlItem15.CustomizationFormText = "# of Gears:"
            Me.layoutControlItem15.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem15.Name = "layoutControlItem15"
            Me.layoutControlItem15.Size = New System.Drawing.Size(319, 76)
            Me.layoutControlItem15.Text = "# of Gears:"
            Me.layoutControlItem15.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem17
            ' 
            Me.layoutControlItem17.Control = Me.dataNavigator1
            Me.layoutControlItem17.CustomizationFormText = "DataNavigator"
            Me.layoutControlItem17.Location = New System.Drawing.Point(0, 497)
            Me.layoutControlItem17.Name = "layoutControlItem17"
            Me.layoutControlItem17.OptionsPrint.AllowPrint = False
            Me.layoutControlItem17.Size = New System.Drawing.Size(243, 23)
            Me.layoutControlItem17.Text = "DataNavigator"
            Me.layoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.layoutControlItem17.TextToControlDistance = 0
            Me.layoutControlItem17.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(243, 497)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(413, 23)
            ' 
            ' Cars
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Cars"
            Me.Size = New System.Drawing.Size(916, 530)
            Me.Controls.SetChildIndex(Me.layoutControl1, 0)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.modelBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.vehiclesDataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit1.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.calcEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.hyperLinkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trademarkBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.categoryBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageComboBoxEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabbedControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private textEdit2 As DevExpress.XtraEditors.TextEdit

        Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private calcEdit1 As DevExpress.XtraEditors.CalcEdit

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private dateEdit1 As DevExpress.XtraEditors.DateEdit

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private textEdit3 As DevExpress.XtraEditors.TextEdit

        Private spinEdit1 As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private textEdit4 As DevExpress.XtraEditors.TextEdit

        Private spinEdit2 As DevExpress.XtraEditors.SpinEdit

        Private spinEdit3 As DevExpress.XtraEditors.SpinEdit

        Private spinEdit4 As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem

        Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator

        Private layoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private components As System.ComponentModel.IContainer = Nothing

        Private vehiclesDataSet1 As DevExpress.XtraLayout.Demos.VehiclesDataSet

        Private trademarkBindingSource As System.Windows.Forms.BindingSource

        Private textEdit1 As DevExpress.XtraEditors.GridLookUpEdit

        Private textEdit1View As DevExpress.XtraGrid.Views.Tile.TileView

        Private colID As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colName As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colSite As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colLogo As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colDescription As DevExpress.XtraGrid.Columns.TileViewColumn

        Private imageComboBoxEdit1 As DevExpress.XtraEditors.GridLookUpEdit

        Private categoryBindingSource As System.Windows.Forms.BindingSource

        Private imageComboBoxEdit1View As DevExpress.XtraGrid.Views.Tile.TileView

        Private colID1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colName1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPicture As DevExpress.XtraGrid.Columns.TileViewColumn

        Private checkEdit2 As DevExpress.XtraEditors.ImageComboBoxEdit

        Private modelBindingSource As System.Windows.Forms.BindingSource

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
