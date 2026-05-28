Imports DevExpress.Utils

Namespace DevExpress.DevAV.Modules

    Partial Class EmployeeView

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
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition4 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition5 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan2 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan3 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan4 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement9 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tableColumnDefinition4 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition5 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition6 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition7 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableRowDefinition6 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition7 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition8 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition9 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan5 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan6 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan7 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan8 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tileViewItemElement10 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement11 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement12 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement13 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement14 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement15 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement16 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement17 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim windowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim windowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim windowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim windowsUIButtonImageOptions4 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.DevAV.Modules.EmployeeView))
            Me.tileViewColumn5 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.tileViewColumn6 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumn7 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumn8 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumn3 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumn2 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumn1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumn4 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.navigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
            Me.navigationPageTasks = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.roundedSkinPanelTasks = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.gcTasks = New DevExpress.XtraGrid.GridControl()
            Me.tvTasks = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.tileViewColumn9 = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.gvTasks = New DevExpress.DevAV.TaskPreviewGridView()
            Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.navigationPageEvaluations = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.roundedSkinPanelEvaluations = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.gcEvaluations = New DevExpress.XtraGrid.GridControl()
            Me.tvEvaluations = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.gvEvaluations = New DevExpress.DevAV.TaskPreviewGridView()
            Me.colCreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.officeTabFilter = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
            Me.buttonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.buttonImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.images = New DevExpress.Utils.MappedSvgImageCollection(Me.components)
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForPhoto = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.sliName = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.sliTitle = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pictureEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType((Me.navigationFrame1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationFrame1.SuspendLayout()
            Me.navigationPageTasks.SuspendLayout()
            CType((Me.roundedSkinPanelTasks), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanelTasks.SuspendLayout()
            CType((Me.gcTasks), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tvTasks), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gvTasks), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPageEvaluations.SuspendLayout()
            CType((Me.roundedSkinPanelEvaluations), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanelEvaluations.SuspendLayout()
            CType((Me.gcEvaluations), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tvEvaluations), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gvEvaluations), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.officeTabFilter), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.buttonImages), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.images), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForPhoto), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.sliName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.sliTitle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.tileViewColumn5.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
            Me.tileViewColumn5.AppearanceCell.Options.UseFont = True
            Me.tileViewColumn5.Caption = "DueDate"
            Me.tileViewColumn5.ColumnEdit = Me.repositoryItemDateEdit1
            Me.tileViewColumn5.FieldName = "DueDate"
            Me.tileViewColumn5.Name = "tileViewColumn5"
            Me.tileViewColumn5.OptionsColumn.AllowEdit = False
            Me.tileViewColumn5.OptionsColumn.AllowFocus = False
            Me.tileViewColumn5.Visible = True
            Me.tileViewColumn5.VisibleIndex = 0
            Me.tileViewColumn5.Width = 116
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd MMM yyyy"
            Me.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            Me.tileViewColumn6.Caption = "Subject"
            Me.tileViewColumn6.FieldName = "Subject"
            Me.tileViewColumn6.Name = "tileViewColumn6"
            Me.tileViewColumn6.OptionsColumn.AllowEdit = False
            Me.tileViewColumn6.OptionsColumn.AllowFocus = False
            Me.tileViewColumn6.Visible = True
            Me.tileViewColumn6.VisibleIndex = 1
            Me.tileViewColumn6.Width = 221
            Me.tileViewColumn7.Caption = "Description"
            Me.tileViewColumn7.FieldName = "Description"
            Me.tileViewColumn7.Name = "tileViewColumn7"
            Me.tileViewColumn7.OptionsColumn.AllowEdit = False
            Me.tileViewColumn7.OptionsColumn.AllowFocus = False
            Me.tileViewColumn7.OptionsColumn.ShowInCustomizationForm = False
            Me.tileViewColumn7.OptionsFilter.AllowFilter = False
            Me.tileViewColumn7.Visible = True
            Me.tileViewColumn7.VisibleIndex = 2
            Me.tileViewColumn7.Width = 504
            Me.tileViewColumn8.Caption = "Completion"
            Me.tileViewColumn8.FieldName = "Completion"
            Me.tileViewColumn8.Name = "tileViewColumn8"
            Me.tileViewColumn8.Visible = True
            Me.tileViewColumn8.VisibleIndex = 3
            Me.tileViewColumn3.Caption = "MANAGER"
            Me.tileViewColumn3.FieldName = "CreatedBy"
            Me.tileViewColumn3.Name = "tileViewColumn3"
            Me.tileViewColumn3.OptionsColumn.AllowEdit = False
            Me.tileViewColumn3.OptionsColumn.AllowFocus = False
            Me.tileViewColumn3.Visible = True
            Me.tileViewColumn3.VisibleIndex = 2
            Me.tileViewColumn3.Width = 228
            Me.tileViewColumn2.Caption = "SUBJECT"
            Me.tileViewColumn2.FieldName = "Subject"
            Me.tileViewColumn2.Name = "tileViewColumn2"
            Me.tileViewColumn2.OptionsColumn.AllowEdit = False
            Me.tileViewColumn2.OptionsColumn.AllowFocus = False
            Me.tileViewColumn2.Visible = True
            Me.tileViewColumn2.VisibleIndex = 1
            Me.tileViewColumn2.Width = 238
            Me.tileViewColumn1.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
            Me.tileViewColumn1.AppearanceCell.Options.UseFont = True
            Me.tileViewColumn1.Caption = "CREATED ON"
            Me.tileViewColumn1.FieldName = "CreatedOn"
            Me.tileViewColumn1.Name = "tileViewColumn1"
            Me.tileViewColumn1.OptionsColumn.AllowEdit = False
            Me.tileViewColumn1.OptionsColumn.AllowFocus = False
            Me.tileViewColumn1.Visible = True
            Me.tileViewColumn1.VisibleIndex = 0
            Me.tileViewColumn1.Width = 90
            Me.tileViewColumn4.Caption = "DETAILS"
            Me.tileViewColumn4.FieldName = "Details"
            Me.tileViewColumn4.Name = "tileViewColumn4"
            Me.tileViewColumn4.Visible = True
            Me.tileViewColumn4.VisibleIndex = 3
            Me.pictureEdit.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Photo", True))
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
            Me.pictureEdit.TabIndex = 0
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Employee)
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.navigationFrame1)
            Me.moduleLayout.Controls.Add(Me.officeTabFilter)
            Me.moduleLayout.Controls.Add(Me.buttonPanel)
            Me.moduleLayout.Controls.Add(Me.pictureEdit)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2584, -30, 650, 685)
            Me.moduleLayout.Root = Me.layoutControlGroup1
            Me.moduleLayout.Size = New System.Drawing.Size(550, 593)
            Me.moduleLayout.TabIndex = 1
            Me.moduleLayout.Text = "modueLayout"
            Me.navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.[False]
            Me.navigationFrame1.Controls.Add(Me.navigationPageTasks)
            Me.navigationFrame1.Controls.Add(Me.navigationPageEvaluations)
            Me.navigationFrame1.Location = New System.Drawing.Point(16, 209)
            Me.navigationFrame1.Name = "navigationFrame1"
            Me.navigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPageEvaluations, Me.navigationPageTasks})
            Me.navigationFrame1.SelectedPage = Me.navigationPageTasks
            Me.navigationFrame1.Size = New System.Drawing.Size(518, 368)
            Me.navigationFrame1.TabIndex = 0
            Me.navigationFrame1.Text = "navigationFrame1"
            Me.navigationPageTasks.Caption = "TASKS"
            Me.navigationPageTasks.Controls.Add(Me.roundedSkinPanelTasks)
            Me.navigationPageTasks.Name = "navigationPageTasks"
            Me.navigationPageTasks.Size = New System.Drawing.Size(518, 368)
            Me.roundedSkinPanelTasks.Controls.Add(Me.gcTasks)
            Me.roundedSkinPanelTasks.Dock = System.Windows.Forms.DockStyle.Fill
            Me.roundedSkinPanelTasks.Location = New System.Drawing.Point(0, 0)
            Me.roundedSkinPanelTasks.Name = "roundedSkinPanelTasks"
            Me.roundedSkinPanelTasks.Size = New System.Drawing.Size(345, 245)
            Me.roundedSkinPanelTasks.TabIndex = 0
            Me.roundedSkinPanelTasks.Text = "roundedSkinPanel2"
            Me.roundedSkinPanelTasks.UseDefaultPadding = DevExpress.Utils.DefaultBoolean.[False]
            Me.gcTasks.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gcTasks.Location = New System.Drawing.Point(1, 1)
            Me.gcTasks.MainView = Me.tvTasks
            Me.gcTasks.MinimumSize = New System.Drawing.Size(32, 32)
            Me.gcTasks.Name = "gcTasks"
            Me.gcTasks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1})
            Me.gcTasks.ShowOnlyPredefinedDetails = True
            Me.gcTasks.Size = New System.Drawing.Size(343, 243)
            Me.gcTasks.TabIndex = 5
            Me.gcTasks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tvTasks, Me.gvTasks})
            Me.tvTasks.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.tvTasks.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tileViewColumn5, Me.tileViewColumn6, Me.tileViewColumn7, Me.tileViewColumn8, Me.tileViewColumn9})
            Me.tvTasks.GridControl = Me.gcTasks
            Me.tvTasks.Name = "tvTasks"
            Me.tvTasks.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None
            Me.tvTasks.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(18, 12, 18, 16)
            Me.tvTasks.OptionsTiles.ItemSize = New System.Drawing.Size(400, 138)
            Me.tvTasks.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.tvTasks.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.tvTasks.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.tvTasks.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
            tableColumnDefinition1.Length.Value = 260R
            tableColumnDefinition2.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition2.Length.Value = 75R
            tableColumnDefinition3.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition3.Length.Value = 28R
            Me.tvTasks.TileColumns.Add(tableColumnDefinition1)
            Me.tvTasks.TileColumns.Add(tableColumnDefinition2)
            Me.tvTasks.TileColumns.Add(tableColumnDefinition3)
            tableRowDefinition1.Length.Value = 16R
            tableRowDefinition2.Length.Value = 14R
            tableRowDefinition3.Length.Value = 53R
            tableRowDefinition3.PaddingTop = 5
            tableRowDefinition4.Length.Value = 17R
            tableRowDefinition5.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableRowDefinition5.Length.Value = 6R
            Me.tvTasks.TileRows.Add(tableRowDefinition1)
            Me.tvTasks.TileRows.Add(tableRowDefinition2)
            Me.tvTasks.TileRows.Add(tableRowDefinition3)
            Me.tvTasks.TileRows.Add(tableRowDefinition4)
            Me.tvTasks.TileRows.Add(tableRowDefinition5)
            tableSpan1.ColumnIndex = 2
            tableSpan1.RowSpan = 2
            tableSpan2.RowSpan = 2
            tableSpan3.ColumnSpan = 3
            tableSpan3.RowIndex = 4
            tableSpan4.ColumnIndex = 1
            tableSpan4.ColumnSpan = 2
            tableSpan4.RowIndex = 2
            tableSpan4.RowSpan = 2
            Me.tvTasks.TileSpans.Add(tableSpan1)
            Me.tvTasks.TileSpans.Add(tableSpan2)
            Me.tvTasks.TileSpans.Add(tableSpan3)
            Me.tvTasks.TileSpans.Add(tableSpan4)
            tileViewItemElement1.ColumnIndex = 2
            tileViewItemElement1.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.MediumPriority
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
            tileViewItemElement1.Name = "PriorityImage"
            tileViewItemElement1.Text = ""
            tileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement2.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
            tileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
            tileViewItemElement2.Appearance.Normal.Options.UseFont = True
            tileViewItemElement2.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement2.ColumnIndex = 1
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement2.Text = "DUE DATE"
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
            tileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement3.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
            tileViewItemElement3.Appearance.Normal.Options.UseFont = True
            tileViewItemElement3.Column = Me.tileViewColumn5
            tileViewItemElement3.ColumnIndex = 1
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement3.RowIndex = 1
            tileViewItemElement3.Text = "tileViewColumn5"
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
            tileViewItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement4.Appearance.Normal.Options.UseFont = True
            tileViewItemElement4.Column = Me.tileViewColumn6
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement4.Text = "tileViewColumn6"
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement5.Column = Me.tileViewColumn7
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement5.RowIndex = 2
            tileViewItemElement5.Text = "tileViewColumn7"
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            tileViewItemElement6.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Left
            tileViewItemElement6.AnchorElementIndex = 8
            tileViewItemElement6.AnchorIndent = 1
            tileViewItemElement6.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement6.Appearance.Normal.ForeColor = System.Drawing.Color.RoyalBlue
            tileViewItemElement6.Appearance.Normal.Options.UseFont = True
            tileViewItemElement6.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement6.Column = Me.tileViewColumn8
            tileViewItemElement6.ColumnIndex = 1
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement6.RowIndex = 3
            tileViewItemElement6.Text = "tileViewColumn8"
            tileViewItemElement7.Appearance.Normal.BackColor = System.Drawing.Color.LightGray
            tileViewItemElement7.Appearance.Normal.Options.UseBackColor = True
            tileViewItemElement7.Height = 6
            tileViewItemElement7.Name = "ProgressBack"
            tileViewItemElement7.RowIndex = 4
            tileViewItemElement7.Text = "ProgressBack"
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement7.TextVisible = False
            tileViewItemElement7.Width = 100
            tileViewItemElement8.Appearance.Normal.BackColor = System.Drawing.Color.RoyalBlue
            tileViewItemElement8.Appearance.Normal.Options.UseBackColor = True
            tileViewItemElement8.Height = 6
            tileViewItemElement8.Name = "ProgressFront"
            tileViewItemElement8.RowIndex = 4
            tileViewItemElement8.Text = "ProgressFront"
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement8.TextVisible = False
            tileViewItemElement8.Width = 50
            tileViewItemElement9.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement9.Appearance.Normal.ForeColor = System.Drawing.Color.RoyalBlue
            tileViewItemElement9.Appearance.Normal.Options.UseFont = True
            tileViewItemElement9.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement9.ColumnIndex = 1
            tileViewItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement9.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement9.RowIndex = 3
            tileViewItemElement9.Text = "%"
            tileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
            Me.tvTasks.TileTemplate.Add(tileViewItemElement1)
            Me.tvTasks.TileTemplate.Add(tileViewItemElement2)
            Me.tvTasks.TileTemplate.Add(tileViewItemElement3)
            Me.tvTasks.TileTemplate.Add(tileViewItemElement4)
            Me.tvTasks.TileTemplate.Add(tileViewItemElement5)
            Me.tvTasks.TileTemplate.Add(tileViewItemElement6)
            Me.tvTasks.TileTemplate.Add(tileViewItemElement7)
            Me.tvTasks.TileTemplate.Add(tileViewItemElement8)
            Me.tvTasks.TileTemplate.Add(tileViewItemElement9)
            Me.tileViewColumn9.Caption = "Priority"
            Me.tileViewColumn9.FieldName = "Priority"
            Me.tileViewColumn9.Name = "tileViewColumn9"
            Me.tileViewColumn9.Visible = True
            Me.tileViewColumn9.VisibleIndex = 4
            Me.gvTasks.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDueDate, Me.colSubject, Me.colDescription})
            Me.gvTasks.GridControl = Me.gcTasks
            Me.gvTasks.Name = "gvTasks"
            Me.gvTasks.PreviewFieldName = "Description"
            Me.gvTasks.PreviewIndent = 0
            Me.colDueDate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
            Me.colDueDate.AppearanceCell.Options.UseFont = True
            Me.colDueDate.Caption = "DUE DATE"
            Me.colDueDate.FieldName = "DueDate"
            Me.colDueDate.Name = "colDueDate"
            Me.colDueDate.OptionsColumn.AllowEdit = False
            Me.colDueDate.OptionsColumn.AllowFocus = False
            Me.colDueDate.Visible = True
            Me.colDueDate.VisibleIndex = 0
            Me.colDueDate.Width = 116
            Me.colSubject.Caption = "SUBJECT"
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.OptionsColumn.AllowEdit = False
            Me.colSubject.OptionsColumn.AllowFocus = False
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 1
            Me.colSubject.Width = 221
            Me.colDescription.Caption = "DESCRIPTION"
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.OptionsColumn.AllowEdit = False
            Me.colDescription.OptionsColumn.AllowFocus = False
            Me.colDescription.OptionsColumn.ShowInCustomizationForm = False
            Me.colDescription.OptionsFilter.AllowFilter = False
            Me.colDescription.Width = 504
            Me.navigationPageEvaluations.Caption = "EVALUATIONS"
            Me.navigationPageEvaluations.Controls.Add(Me.roundedSkinPanelEvaluations)
            Me.navigationPageEvaluations.Name = "navigationPageEvaluations"
            Me.navigationPageEvaluations.Size = New System.Drawing.Size(518, 368)
            Me.roundedSkinPanelEvaluations.Controls.Add(Me.gcEvaluations)
            Me.roundedSkinPanelEvaluations.Dock = System.Windows.Forms.DockStyle.Fill
            Me.roundedSkinPanelEvaluations.Location = New System.Drawing.Point(0, 0)
            Me.roundedSkinPanelEvaluations.Name = "roundedSkinPanelEvaluations"
            Me.roundedSkinPanelEvaluations.Size = New System.Drawing.Size(518, 368)
            Me.roundedSkinPanelEvaluations.TabIndex = 11
            Me.roundedSkinPanelEvaluations.Text = "roundedSkinPanel1"
            Me.roundedSkinPanelEvaluations.UseDefaultPadding = DevExpress.Utils.DefaultBoolean.[False]
            Me.gcEvaluations.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gcEvaluations.Location = New System.Drawing.Point(1, 1)
            Me.gcEvaluations.MainView = Me.tvEvaluations
            Me.gcEvaluations.MinimumSize = New System.Drawing.Size(32, 32)
            Me.gcEvaluations.Name = "gcEvaluations"
            Me.gcEvaluations.Size = New System.Drawing.Size(516, 366)
            Me.gcEvaluations.TabIndex = 9
            Me.gcEvaluations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tvEvaluations, Me.gvEvaluations})
            Me.tvEvaluations.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.tvEvaluations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tileViewColumn1, Me.tileViewColumn2, Me.tileViewColumn3, Me.tileViewColumn4})
            Me.tvEvaluations.GridControl = Me.gcEvaluations
            Me.tvEvaluations.Name = "tvEvaluations"
            Me.tvEvaluations.OptionsBehavior.AllowSmoothScrolling = True
            Me.tvEvaluations.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None
            Me.tvEvaluations.OptionsTiles.IndentBetweenItems = 1
            Me.tvEvaluations.OptionsTiles.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never
            Me.tvEvaluations.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(20, 12, 0, 12)
            Me.tvEvaluations.OptionsTiles.ItemSize = New System.Drawing.Size(600, 130)
            Me.tvEvaluations.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.tvEvaluations.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.tvEvaluations.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.tvEvaluations.OptionsTiles.ShowGroupText = False
            tableColumnDefinition4.Length.Value = 251R
            tableColumnDefinition5.Length.Value = 157R
            tableColumnDefinition5.PaddingRight = 20
            tableColumnDefinition6.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition6.Length.Value = 80R
            tableColumnDefinition6.PaddingRight = 10
            tableColumnDefinition7.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition7.Length.Value = 80R
            tableColumnDefinition7.PaddingLeft = 10
            Me.tvEvaluations.TileColumns.Add(tableColumnDefinition4)
            Me.tvEvaluations.TileColumns.Add(tableColumnDefinition5)
            Me.tvEvaluations.TileColumns.Add(tableColumnDefinition6)
            Me.tvEvaluations.TileColumns.Add(tableColumnDefinition7)
            tableRowDefinition6.Length.Value = 13R
            tableRowDefinition7.Length.Value = 18R
            tableRowDefinition8.Length.Value = 62R
            tableRowDefinition8.PaddingBottom = 8
            tableRowDefinition8.PaddingTop = 6
            tableRowDefinition9.Length.Value = 15R
            Me.tvEvaluations.TileRows.Add(tableRowDefinition6)
            Me.tvEvaluations.TileRows.Add(tableRowDefinition7)
            Me.tvEvaluations.TileRows.Add(tableRowDefinition8)
            Me.tvEvaluations.TileRows.Add(tableRowDefinition9)
            tableSpan5.RowSpan = 2
            tableSpan6.ColumnIndex = 2
            tableSpan6.RowSpan = 4
            tableSpan7.ColumnSpan = 2
            tableSpan7.RowIndex = 2
            tableSpan8.ColumnIndex = 3
            tableSpan8.RowSpan = 4
            Me.tvEvaluations.TileSpans.Add(tableSpan5)
            Me.tvEvaluations.TileSpans.Add(tableSpan6)
            Me.tvEvaluations.TileSpans.Add(tableSpan7)
            Me.tvEvaluations.TileSpans.Add(tableSpan8)
            tileViewItemElement10.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement10.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
            tileViewItemElement10.Appearance.Normal.Options.UseFont = True
            tileViewItemElement10.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement10.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement10.Column = Me.tileViewColumn3
            tileViewItemElement10.ColumnIndex = 1
            tileViewItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement10.RowIndex = 1
            tileViewItemElement10.Text = "tileViewColumn3"
            tileViewItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
            tileViewItemElement11.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold)
            tileViewItemElement11.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
            tileViewItemElement11.Appearance.Normal.Options.UseFont = True
            tileViewItemElement11.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement11.ColumnIndex = 1
            tileViewItemElement11.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement11.Text = "MANAGER"
            tileViewItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
            tileViewItemElement12.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((224)))))), (CInt(((CByte((224)))))))
            tileViewItemElement12.Appearance.Normal.Options.UseBackColor = True
            tileViewItemElement12.ColumnIndex = 2
            tileViewItemElement12.Height = 110
            tileViewItemElement12.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement12.RowIndex = 1
            tileViewItemElement12.Text = ""
            tileViewItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement12.Width = 1
            tileViewItemElement13.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement13.Appearance.Normal.Options.UseFont = True
            tileViewItemElement13.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement13.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement13.Column = Me.tileViewColumn2
            tileViewItemElement13.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement13.Text = "tileViewColumn2"
            tileViewItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement14.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement14.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
            tileViewItemElement14.Appearance.Normal.ForeColor = System.Drawing.Color.RoyalBlue
            tileViewItemElement14.Appearance.Normal.Options.UseFont = True
            tileViewItemElement14.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement14.Column = Me.tileViewColumn1
            tileViewItemElement14.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement14.RowIndex = 3
            tileViewItemElement14.Text = "tileViewColumn1"
            tileViewItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
            tileViewItemElement15.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement15.Appearance.Normal.Options.UseFont = True
            tileViewItemElement15.Column = Me.tileViewColumn4
            tileViewItemElement15.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement15.RowIndex = 2
            tileViewItemElement15.Text = "tileViewColumn4"
            tileViewItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            tileViewItemElement16.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold)
            tileViewItemElement16.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
            tileViewItemElement16.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
            tileViewItemElement16.Appearance.Normal.Options.UseFont = True
            tileViewItemElement16.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement16.ColumnIndex = 2
            tileViewItemElement16.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_about_16
            tileViewItemElement16.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
            tileViewItemElement16.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
            tileViewItemElement16.Name = "RaiseImage"
            tileViewItemElement16.RowIndex = 2
            tileViewItemElement16.Text = "RAISE"
            tileViewItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement17.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold)
            tileViewItemElement17.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
            tileViewItemElement17.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
            tileViewItemElement17.Appearance.Normal.Options.UseFont = True
            tileViewItemElement17.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement17.ColumnIndex = 3
            tileViewItemElement17.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_about_16
            tileViewItemElement17.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement17.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
            tileViewItemElement17.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            tileViewItemElement17.Name = "BonusImage"
            tileViewItemElement17.RowIndex = 2
            tileViewItemElement17.Text = "BONUS"
            tileViewItemElement17.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.tvEvaluations.TileTemplate.Add(tileViewItemElement10)
            Me.tvEvaluations.TileTemplate.Add(tileViewItemElement11)
            Me.tvEvaluations.TileTemplate.Add(tileViewItemElement12)
            Me.tvEvaluations.TileTemplate.Add(tileViewItemElement13)
            Me.tvEvaluations.TileTemplate.Add(tileViewItemElement14)
            Me.tvEvaluations.TileTemplate.Add(tileViewItemElement15)
            Me.tvEvaluations.TileTemplate.Add(tileViewItemElement16)
            Me.tvEvaluations.TileTemplate.Add(tileViewItemElement17)
            Me.gvEvaluations.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCreatedOn, Me.colSubject1, Me.colCreatedBy})
            Me.gvEvaluations.GridControl = Me.gcEvaluations
            Me.gvEvaluations.Name = "gvEvaluations"
            Me.gvEvaluations.PreviewFieldName = "Details"
            Me.gvEvaluations.PreviewIndent = 0
            Me.colCreatedOn.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
            Me.colCreatedOn.AppearanceCell.Options.UseFont = True
            Me.colCreatedOn.Caption = "CREATED ON"
            Me.colCreatedOn.FieldName = "CreatedOn"
            Me.colCreatedOn.Name = "colCreatedOn"
            Me.colCreatedOn.OptionsColumn.AllowEdit = False
            Me.colCreatedOn.OptionsColumn.AllowFocus = False
            Me.colCreatedOn.Visible = True
            Me.colCreatedOn.VisibleIndex = 0
            Me.colCreatedOn.Width = 90
            Me.colSubject1.Caption = "SUBJECT"
            Me.colSubject1.FieldName = "Subject"
            Me.colSubject1.Name = "colSubject1"
            Me.colSubject1.OptionsColumn.AllowEdit = False
            Me.colSubject1.OptionsColumn.AllowFocus = False
            Me.colSubject1.Visible = True
            Me.colSubject1.VisibleIndex = 1
            Me.colSubject1.Width = 238
            Me.colCreatedBy.Caption = "MANAGER"
            Me.colCreatedBy.FieldName = "CreatedBy"
            Me.colCreatedBy.Name = "colCreatedBy"
            Me.colCreatedBy.OptionsColumn.AllowEdit = False
            Me.colCreatedBy.OptionsColumn.AllowFocus = False
            Me.colCreatedBy.Visible = True
            Me.colCreatedBy.VisibleIndex = 2
            Me.colCreatedBy.Width = 228
            Me.officeTabFilter.AnimateItemPressing = False
            Me.officeTabFilter.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 10.25F)
            Me.officeTabFilter.AppearanceItem.Normal.Options.UseFont = True
            Me.officeTabFilter.AutoSize = False
            Me.officeTabFilter.AutoSizeInLayoutControl = True
            Me.officeTabFilter.BackColor = System.Drawing.Color.Transparent
            Me.officeTabFilter.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden
            Me.officeTabFilter.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.officeTabFilter.ItemPadding = New System.Windows.Forms.Padding(12, 8, 0, 4)
            Me.officeTabFilter.Location = New System.Drawing.Point(16, 164)
            Me.officeTabFilter.Name = "officeTabFilter"
            Me.officeTabFilter.NavigationClient = Me.navigationFrame1
            Me.officeTabFilter.Size = New System.Drawing.Size(518, 39)
            Me.officeTabFilter.TabIndex = 10
            Me.officeTabFilter.ViewMode = DevExpress.XtraBars.Navigation.OfficeNavigationBarViewMode.Tab
            Me.buttonPanel.ButtonBackgroundImages = Me.buttonImages
            windowsUIButtonImageOptions1.ImageIndex = 0
            windowsUIButtonImageOptions2.ImageIndex = 1
            windowsUIButtonImageOptions3.ImageIndex = 2
            windowsUIButtonImageOptions4.ImageIndex = 3
            Me.buttonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("", True, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("", True, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("", True, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("", True, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
            Me.buttonPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.buttonPanel.Images = Me.images
            Me.buttonPanel.Location = New System.Drawing.Point(158, 106)
            Me.buttonPanel.MinimumSize = New System.Drawing.Size(0, 30)
            Me.buttonPanel.Name = "buttonPanel"
            Me.buttonPanel.Size = New System.Drawing.Size(360, 30)
            Me.buttonPanel.TabIndex = 4
            Me.buttonPanel.Text = "windowsUIButtonPanel1"
            Me.buttonImages.ImageSize = New System.Drawing.Size(28, 28)
            Me.buttonImages.Add("WindowsUIButtonGlyph_0", CType((resources.GetObject("buttonImages.WindowsUIButtonGlyph_0")), DevExpress.Utils.Svg.SvgImage))
            Me.buttonImages.Add("WindowsUIButtonGlyph_1", CType((resources.GetObject("buttonImages.WindowsUIButtonGlyph_1")), DevExpress.Utils.Svg.SvgImage))
            Me.buttonImages.Add("WindowsUIButtonGlyph_2", CType((resources.GetObject("buttonImages.WindowsUIButtonGlyph_2")), DevExpress.Utils.Svg.SvgImage))
            Me.images.Add("glyph_message", "image://svgimages/outlook inspired/glyph_message.svg")
            Me.images.Add("glyph_phone", "image://svgimages/outlook inspired/glyph_phone.svg")
            Me.images.Add("electronics_video", "image://svgimages/icon builder/electronics_video.svg")
            Me.images.Add("glyph_mail", "image://svgimages/outlook inspired/glyph_mail.svg")
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(550, 593)
            Me.layoutControlGroup1.TextVisible = False
            Me.layoutControlItem1.Control = Me.officeTabFilter
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 148)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(524, 45)
            Me.layoutControlItem1.TextVisible = False
            Me.ItemForPhoto.Control = Me.pictureEdit
            Me.ItemForPhoto.CustomizationFormText = "ItemForPhoto"
            Me.ItemForPhoto.Location = New System.Drawing.Point(0, 0)
            Me.ItemForPhoto.Name = "ItemForPhoto"
            Me.ItemForPhoto.Size = New System.Drawing.Size(126, 148)
            Me.ItemForPhoto.TextVisible = False
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.sliName, Me.sliTitle, Me.layoutControlItem2, Me.emptySpaceItem3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(126, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(398, 148)
            Me.sliName.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.sliName.AppearanceItemCaption.Options.UseFont = True
            Me.sliName.CustomizationFormText = "Name"
            Me.sliName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "FullNameBindable", True))
            Me.sliName.Location = New System.Drawing.Point(0, 0)
            Me.sliName.Name = "sliName"
            Me.sliName.Size = New System.Drawing.Size(366, 43)
            Me.sliName.Text = "Name"
            Me.sliName.TextSize = New System.Drawing.Size(71, 37)
            Me.sliTitle.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.sliTitle.AppearanceItemCaption.Options.UseFont = True
            Me.sliTitle.CustomizationFormText = "Title"
            Me.sliTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Title", True))
            Me.sliTitle.Location = New System.Drawing.Point(0, 43)
            Me.sliTitle.Name = "sliTitle"
            Me.sliTitle.Size = New System.Drawing.Size(366, 31)
            Me.sliTitle.Text = "Title"
            Me.sliTitle.TextSize = New System.Drawing.Size(71, 25)
            Me.layoutControlItem2.Control = Me.buttonPanel
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 74)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(1, 32)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(366, 32)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextVisible = False
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 106)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(366, 10)
            Me.layoutControlItem3.Control = Me.navigationFrame1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 193)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(524, 374)
            Me.layoutControlItem3.TextVisible = False
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.ItemForPhoto})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(524, 148)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "EmployeeView"
            Me.Size = New System.Drawing.Size(550, 593)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pictureEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType((Me.navigationFrame1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationFrame1.ResumeLayout(False)
            Me.navigationPageTasks.ResumeLayout(False)
            CType((Me.roundedSkinPanelTasks), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanelTasks.ResumeLayout(False)
            CType((Me.gcTasks), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tvTasks), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gvTasks), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPageEvaluations.ResumeLayout(False)
            CType((Me.roundedSkinPanelEvaluations), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanelEvaluations.ResumeLayout(False)
            CType((Me.gcEvaluations), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tvEvaluations), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gvEvaluations), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.officeTabFilter), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.buttonImages), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.images), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForPhoto), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.sliName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.sliTitle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pictureEdit As DevExpress.XtraEditors.PictureEdit

        Private bindingSource As System.Windows.Forms.BindingSource

        Private moduleLayout As DevExpress.XtraLayout.LayoutControl

        Private buttonPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private gcTasks As DevExpress.XtraGrid.GridControl

        Private colDueDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colSubject As DevExpress.XtraGrid.Columns.GridColumn

        Private gvTasks As DevExpress.DevAV.TaskPreviewGridView

        Private gcEvaluations As DevExpress.XtraGrid.GridControl

        Private colCreatedOn As DevExpress.XtraGrid.Columns.GridColumn

        Private colSubject1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn

        Private gvEvaluations As DevExpress.DevAV.TaskPreviewGridView

        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn

        Private tvEvaluations As DevExpress.XtraGrid.Views.Tile.TileView

        Private tileViewColumn1 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumn2 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumn3 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumn4 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tvTasks As DevExpress.XtraGrid.Views.Tile.TileView

        Private tileViewColumn5 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumn6 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumn7 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumn8 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

        Private tileViewColumn9 As DevExpress.XtraGrid.Columns.TileViewColumn

        Private officeTabFilter As DevExpress.XtraBars.Navigation.OfficeNavigationBar

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private buttonImages As DevExpress.Utils.SvgImageCollection

        Private images As DevExpress.Utils.MappedSvgImageCollection

        Private roundedSkinPanelTasks As DevExpress.XtraEditors.RoundedSkinPanel

        Private roundedSkinPanelEvaluations As DevExpress.XtraEditors.RoundedSkinPanel

        Private ItemForPhoto As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private sliName As DevExpress.XtraLayout.SimpleLabelItem

        Private sliTitle As DevExpress.XtraLayout.SimpleLabelItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private navigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame

        Private navigationPageTasks As DevExpress.XtraBars.Navigation.NavigationPage

        Private navigationPageEvaluations As DevExpress.XtraBars.Navigation.NavigationPage

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
