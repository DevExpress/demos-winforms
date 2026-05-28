Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleListBox

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
            Dim simpleContextButton1 As DevExpress.Utils.SimpleContextButton = New DevExpress.Utils.SimpleContextButton()
            Dim itemTemplateBase1 As DevExpress.XtraEditors.TableLayout.ItemTemplateBase = New DevExpress.XtraEditors.TableLayout.ItemTemplateBase()
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim templatedItemElement1 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim templatedItemElement2 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim templatedItemElement3 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim templatedItemElement4 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim templatedItemElement5 As DevExpress.XtraEditors.TableLayout.TemplatedItemElement = New DevExpress.XtraEditors.TableLayout.TemplatedItemElement()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Me.tablePanel2 = New DevExpress.Utils.Layout.TablePanel()
            Me.listBoxControlSample = New DevExpress.XtraEditors.ListBoxControl()
            Me.searchControlSample = New DevExpress.XtraEditors.SearchControl()
            Me.tablePanel3 = New DevExpress.Utils.Layout.TablePanel()
            Me.checkedListBoxControlSample = New DevExpress.XtraEditors.CheckedListBoxControl()
            Me.searchControlCheckedSample = New DevExpress.XtraEditors.SearchControl()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.seInvert = New DevExpress.XtraEditors.SimpleButton()
            Me.ceCustomDraw = New DevExpress.XtraEditors.CheckEdit()
            Me.tablePanel4 = New DevExpress.Utils.Layout.TablePanel()
            Me.searchControlImageSample = New DevExpress.XtraEditors.SearchControl()
            Me.imageListBoxControlSample = New DevExpress.XtraEditors.ImageListBoxControl()
            Me.lbSample = New DevExpress.XtraEditors.LabelControl()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.listBoxTemplated = New DevExpress.XtraEditors.ListBoxControl()
            Me.searchControlTemplates = New DevExpress.XtraEditors.SearchControl()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.properties = New DevExpress.XtraEditors.Demos.ListBoxProperties()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tabNavigationPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tabNavigationPage4 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.tablePanel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel2.SuspendLayout()
            CType((Me.listBoxControlSample), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchControlSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tablePanel3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel3.SuspendLayout()
            CType((Me.checkedListBoxControlSample), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchControlCheckedSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            CType((Me.ceCustomDraw.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tablePanel4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel4.SuspendLayout()
            CType((Me.searchControlImageSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageListBoxControlSample), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.listBoxTemplated), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchControlTemplates.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.tabNavigationPage2.SuspendLayout()
            Me.tabNavigationPage3.SuspendLayout()
            Me.tabNavigationPage4.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' tablePanel2
            ' 
            Me.tablePanel2.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F)})
            Me.tablePanel2.Controls.Add(Me.listBoxControlSample)
            Me.tablePanel2.Controls.Add(Me.searchControlSample)
            Me.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel2.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel2.Name = "tablePanel2"
            Me.tablePanel2.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)})
            Me.tablePanel2.Size = New System.Drawing.Size(380, 513)
            Me.tablePanel2.TabIndex = 8
            ' 
            ' listBoxControlSample
            ' 
            Me.listBoxControlSample.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
            Me.tablePanel2.SetColumn(Me.listBoxControlSample, 0)
            Me.listBoxControlSample.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.listBoxControlSample.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxControlSample.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
            Me.listBoxControlSample.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
            Me.listBoxControlSample.Location = New System.Drawing.Point(3, 29)
            Me.listBoxControlSample.MultiColumn = True
            Me.listBoxControlSample.Name = "listBoxControlSample"
            Me.tablePanel2.SetRow(Me.listBoxControlSample, 1)
            Me.listBoxControlSample.Size = New System.Drawing.Size(374, 481)
            Me.listBoxControlSample.TabIndex = 0
            ' 
            ' searchControlSample
            ' 
            Me.searchControlSample.Client = Me.listBoxControlSample
            Me.tablePanel2.SetColumn(Me.searchControlSample, 0)
            Me.searchControlSample.Dock = System.Windows.Forms.DockStyle.Fill
            Me.searchControlSample.Location = New System.Drawing.Point(3, 3)
            Me.searchControlSample.Name = "searchControlSample"
            Me.searchControlSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.searchControlSample.Properties.Client = Me.listBoxControlSample
            Me.tablePanel2.SetRow(Me.searchControlSample, 0)
            Me.searchControlSample.Size = New System.Drawing.Size(374, 20)
            Me.searchControlSample.TabIndex = 19
            ' 
            ' tablePanel3
            ' 
            Me.tablePanel3.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F)})
            Me.tablePanel3.Controls.Add(Me.checkedListBoxControlSample)
            Me.tablePanel3.Controls.Add(Me.searchControlCheckedSample)
            Me.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel3.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel3.Name = "tablePanel3"
            Me.tablePanel3.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)})
            Me.tablePanel3.Size = New System.Drawing.Size(380, 474)
            Me.tablePanel3.TabIndex = 9
            ' 
            ' checkedListBoxControlSample
            ' 
            Me.tablePanel3.SetColumn(Me.checkedListBoxControlSample, 0)
            Me.checkedListBoxControlSample.Dock = System.Windows.Forms.DockStyle.Fill
            Me.checkedListBoxControlSample.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
            Me.checkedListBoxControlSample.Location = New System.Drawing.Point(3, 29)
            Me.checkedListBoxControlSample.Name = "checkedListBoxControlSample"
            Me.tablePanel3.SetRow(Me.checkedListBoxControlSample, 1)
            Me.checkedListBoxControlSample.Size = New System.Drawing.Size(374, 442)
            Me.checkedListBoxControlSample.TabIndex = 1
            AddHandler Me.checkedListBoxControlSample.DrawItem, New DevExpress.XtraEditors.ListBoxDrawItemEventHandler(AddressOf Me.checkedListBoxControlSample_DrawItem)
            ' 
            ' searchControlCheckedSample
            ' 
            Me.searchControlCheckedSample.Client = Me.checkedListBoxControlSample
            Me.tablePanel3.SetColumn(Me.searchControlCheckedSample, 0)
            Me.searchControlCheckedSample.Dock = System.Windows.Forms.DockStyle.Fill
            Me.searchControlCheckedSample.Location = New System.Drawing.Point(3, 3)
            Me.searchControlCheckedSample.Name = "searchControlCheckedSample"
            Me.searchControlCheckedSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.searchControlCheckedSample.Properties.Client = Me.checkedListBoxControlSample
            Me.tablePanel3.SetRow(Me.searchControlCheckedSample, 0)
            Me.searchControlCheckedSample.Size = New System.Drawing.Size(374, 20)
            Me.searchControlCheckedSample.TabIndex = 0
            ' 
            ' panelControl3
            ' 
            Me.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl3.Appearance.Options.UseBackColor = True
            Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl3.Controls.Add(Me.seInvert)
            Me.panelControl3.Controls.Add(Me.ceCustomDraw)
            Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl3.Location = New System.Drawing.Point(0, 474)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
            Me.panelControl3.Size = New System.Drawing.Size(380, 39)
            Me.panelControl3.TabIndex = 7
            ' 
            ' seInvert
            ' 
            Me.seInvert.Dock = System.Windows.Forms.DockStyle.Right
            Me.seInvert.Location = New System.Drawing.Point(240, 8)
            Me.seInvert.Name = "seInvert"
            Me.seInvert.Size = New System.Drawing.Size(140, 23)
            Me.seInvert.TabIndex = 2
            Me.seInvert.Text = "Invert Checked Items"
            AddHandler Me.seInvert.Click, New System.EventHandler(AddressOf Me.seInvert_Click)
            ' 
            ' ceCustomDraw
            ' 
            Me.ceCustomDraw.EditValue = True
            Me.ceCustomDraw.Location = New System.Drawing.Point(2, 10)
            Me.ceCustomDraw.Name = "ceCustomDraw"
            Me.ceCustomDraw.Properties.Caption = "Custom draw"
            Me.ceCustomDraw.Size = New System.Drawing.Size(96, 20)
            Me.ceCustomDraw.TabIndex = 1
            AddHandler Me.ceCustomDraw.CheckedChanged, New System.EventHandler(AddressOf Me.ceCustomDraw_CheckedChanged)
            ' 
            ' tablePanel4
            ' 
            Me.tablePanel4.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F)})
            Me.tablePanel4.Controls.Add(Me.searchControlImageSample)
            Me.tablePanel4.Controls.Add(Me.imageListBoxControlSample)
            Me.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel4.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel4.Name = "tablePanel4"
            Me.tablePanel4.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)})
            Me.tablePanel4.Size = New System.Drawing.Size(380, 492)
            Me.tablePanel4.TabIndex = 9
            ' 
            ' searchControlImageSample
            ' 
            Me.searchControlImageSample.Client = Me.imageListBoxControlSample
            Me.tablePanel4.SetColumn(Me.searchControlImageSample, 0)
            Me.searchControlImageSample.Dock = System.Windows.Forms.DockStyle.Fill
            Me.searchControlImageSample.Location = New System.Drawing.Point(3, 3)
            Me.searchControlImageSample.Name = "searchControlImageSample"
            Me.searchControlImageSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.searchControlImageSample.Properties.Client = Me.imageListBoxControlSample
            Me.tablePanel4.SetRow(Me.searchControlImageSample, 0)
            Me.searchControlImageSample.Size = New System.Drawing.Size(374, 20)
            Me.searchControlImageSample.TabIndex = 0
            ' 
            ' imageListBoxControlSample
            ' 
            Me.tablePanel4.SetColumn(Me.imageListBoxControlSample, 0)
            Me.imageListBoxControlSample.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.imageListBoxControlSample.Dock = System.Windows.Forms.DockStyle.Fill
            Me.imageListBoxControlSample.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
            Me.imageListBoxControlSample.Location = New System.Drawing.Point(3, 29)
            Me.imageListBoxControlSample.Name = "imageListBoxControlSample"
            Me.tablePanel4.SetRow(Me.imageListBoxControlSample, 1)
            Me.imageListBoxControlSample.Size = New System.Drawing.Size(374, 460)
            Me.imageListBoxControlSample.TabIndex = 1
            ' 
            ' lbSample
            ' 
            Me.lbSample.Appearance.Options.UseTextOptions = True
            Me.lbSample.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbSample.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lbSample.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lbSample.Location = New System.Drawing.Point(0, 492)
            Me.lbSample.Name = "lbSample"
            Me.lbSample.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.lbSample.Size = New System.Drawing.Size(59, 21)
            Me.lbSample.TabIndex = 2
            Me.lbSample.Text = "Font Sample"
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F)})
            Me.tablePanel1.Controls.Add(Me.listBoxTemplated)
            Me.tablePanel1.Controls.Add(Me.searchControlTemplates)
            Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)})
            Me.tablePanel1.Size = New System.Drawing.Size(380, 513)
            Me.tablePanel1.TabIndex = 2
            ' 
            ' listBoxTemplated
            ' 
            Me.tablePanel1.SetColumn(Me.listBoxTemplated, 0)
            Me.listBoxTemplated.ContextButtonOptions.NormalStateOpacity = 0.4F
            simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center
            simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            simpleContextButton1.Id = New System.Guid("74cd286d-bd43-4aa1-98ba-7c5f073ced69")
            simpleContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = Global.DevExpress.XtraEditors.Demos.Properties.Resources.customeremployees
            simpleContextButton1.Name = "SimpleContextButton"
            simpleContextButton1.ToolTip = "Employee Details"
            simpleContextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Hidden
            Me.listBoxTemplated.ContextButtons.Add(simpleContextButton1)
            Me.listBoxTemplated.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.listBoxTemplated.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBoxTemplated.ItemAutoHeight = True
            Me.listBoxTemplated.ItemHeight = 72
            Me.listBoxTemplated.Location = New System.Drawing.Point(3, 29)
            Me.listBoxTemplated.Name = "listBoxTemplated"
            Me.tablePanel1.SetRow(Me.listBoxTemplated, 1)
            Me.listBoxTemplated.Size = New System.Drawing.Size(374, 481)
            Me.listBoxTemplated.TabIndex = 0
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition1.Length.Value = 72R
            tableColumnDefinition2.Length.Value = 246R
            tableColumnDefinition2.PaddingLeft = 6
            itemTemplateBase1.Columns.Add(tableColumnDefinition1)
            itemTemplateBase1.Columns.Add(tableColumnDefinition2)
            templatedItemElement1.FieldName = "Photo"
            templatedItemElement1.ImageOptions.Image = Global.DevExpress.XtraEditors.Demos.Properties.Resources.peMaskedImage
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
            templatedItemElement1.Text = "Photo"
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            templatedItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            templatedItemElement2.Appearance.Normal.Options.UseFont = True
            templatedItemElement2.ColumnIndex = 1
            templatedItemElement2.FieldName = "FirstName"
            templatedItemElement2.Text = "FirstName"
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            templatedItemElement3.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right
            templatedItemElement3.AnchorElementIndex = 1
            templatedItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            templatedItemElement3.Appearance.Normal.Options.UseFont = True
            templatedItemElement3.ColumnIndex = 1
            templatedItemElement3.FieldName = "LastName"
            templatedItemElement3.Text = "LastName"
            templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            templatedItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
            templatedItemElement4.Appearance.Normal.Options.UseForeColor = True
            templatedItemElement4.ColumnIndex = 1
            templatedItemElement4.FieldName = "Title"
            templatedItemElement4.RowIndex = 1
            templatedItemElement4.Text = "Title"
            templatedItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            templatedItemElement5.ColumnIndex = 1
            templatedItemElement5.FieldName = "Notes"
            templatedItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            templatedItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            templatedItemElement5.MaxLineCount = 8
            templatedItemElement5.RowIndex = 2
            templatedItemElement5.Text = "Notes"
            templatedItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
            itemTemplateBase1.Elements.Add(templatedItemElement1)
            itemTemplateBase1.Elements.Add(templatedItemElement2)
            itemTemplateBase1.Elements.Add(templatedItemElement3)
            itemTemplateBase1.Elements.Add(templatedItemElement4)
            itemTemplateBase1.Elements.Add(templatedItemElement5)
            itemTemplateBase1.Name = "template0"
            tableRowDefinition1.Length.Value = 35R
            tableRowDefinition2.Length.Value = 28R
            tableRowDefinition3.AutoHeight = True
            tableRowDefinition3.Length.Value = 40R
            itemTemplateBase1.Rows.Add(tableRowDefinition1)
            itemTemplateBase1.Rows.Add(tableRowDefinition2)
            itemTemplateBase1.Rows.Add(tableRowDefinition3)
            tableSpan1.RowSpan = 3
            itemTemplateBase1.Spans.Add(tableSpan1)
            Me.listBoxTemplated.Templates.Add(itemTemplateBase1)
            ' 
            ' searchControlTemplates
            ' 
            Me.searchControlTemplates.Client = Me.listBoxTemplated
            Me.tablePanel1.SetColumn(Me.searchControlTemplates, 0)
            Me.searchControlTemplates.Dock = System.Windows.Forms.DockStyle.Fill
            Me.searchControlTemplates.Location = New System.Drawing.Point(3, 3)
            Me.searchControlTemplates.Name = "searchControlTemplates"
            Me.searchControlTemplates.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.searchControlTemplates.Properties.Client = Me.listBoxTemplated
            Me.tablePanel1.SetRow(Me.searchControlTemplates, 0)
            Me.searchControlTemplates.Size = New System.Drawing.Size(374, 20)
            Me.searchControlTemplates.TabIndex = 0
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Location = New System.Drawing.Point(380, 0)
            Me.splitterControl1.MinExtra = 350
            Me.splitterControl1.MinSize = 300
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(10, 546)
            Me.splitterControl1.TabIndex = 6
            Me.splitterControl1.TabStop = False
            ' 
            ' properties
            ' 
            Me.properties.Dock = System.Windows.Forms.DockStyle.Fill
            Me.properties.Location = New System.Drawing.Point(390, 0)
            Me.properties.Name = "properties"
            Me.properties.Size = New System.Drawing.Size(402, 546)
            Me.properties.TabIndex = 0
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Controls.Add(Me.tabNavigationPage2)
            Me.tabPane1.Controls.Add(Me.tabNavigationPage3)
            Me.tabPane1.Controls.Add(Me.tabNavigationPage4)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Left
            Me.tabPane1.Location = New System.Drawing.Point(0, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1, Me.tabNavigationPage2, Me.tabNavigationPage3, Me.tabNavigationPage4})
            Me.tabPane1.RegularSize = New System.Drawing.Size(380, 546)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(380, 546)
            Me.tabPane1.TabIndex = 4
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "ListBox Templates"
            Me.tabNavigationPage1.Controls.Add(Me.tablePanel1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(380, 513)
            ' 
            ' tabNavigationPage2
            ' 
            Me.tabNavigationPage2.Caption = "ListBox"
            Me.tabNavigationPage2.Controls.Add(Me.tablePanel2)
            Me.tabNavigationPage2.Name = "tabNavigationPage2"
            Me.tabNavigationPage2.Size = New System.Drawing.Size(380, 513)
            ' 
            ' tabNavigationPage3
            ' 
            Me.tabNavigationPage3.Caption = "CheckedListBox"
            Me.tabNavigationPage3.Controls.Add(Me.tablePanel3)
            Me.tabNavigationPage3.Controls.Add(Me.panelControl3)
            Me.tabNavigationPage3.Name = "tabNavigationPage3"
            Me.tabNavigationPage3.Size = New System.Drawing.Size(380, 513)
            ' 
            ' tabNavigationPage4
            ' 
            Me.tabNavigationPage4.Caption = "ImageListBox"
            Me.tabNavigationPage4.Controls.Add(Me.tablePanel4)
            Me.tabNavigationPage4.Controls.Add(Me.lbSample)
            Me.tabNavigationPage4.Name = "tabNavigationPage4"
            Me.tabNavigationPage4.Size = New System.Drawing.Size(380, 513)
            ' 
            ' ModuleListBox
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.properties)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.tabPane1)
            Me.Name = "ModuleListBox"
            Me.Size = New System.Drawing.Size(792, 546)
            CType((Me.tablePanel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel2.ResumeLayout(False)
            CType((Me.listBoxControlSample), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchControlSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tablePanel3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel3.ResumeLayout(False)
            CType((Me.checkedListBoxControlSample), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchControlCheckedSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            CType((Me.ceCustomDraw.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tablePanel4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel4.ResumeLayout(False)
            CType((Me.searchControlImageSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageListBoxControlSample), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            CType((Me.listBoxTemplated), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchControlTemplates.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.tabNavigationPage2.ResumeLayout(False)
            Me.tabNavigationPage3.ResumeLayout(False)
            Me.tabNavigationPage4.ResumeLayout(False)
            Me.tabNavigationPage4.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private listBoxControlSample As DevExpress.XtraEditors.ListBoxControl

        Private ceCustomDraw As DevExpress.XtraEditors.CheckEdit

        Private panelControl3 As DevExpress.XtraEditors.PanelControl

        Private lbSample As DevExpress.XtraEditors.LabelControl

        Private seInvert As DevExpress.XtraEditors.SimpleButton

        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl

        Private searchControlSample As DevExpress.XtraEditors.SearchControl

        Private listBoxTemplated As DevExpress.XtraEditors.ListBoxControl

        Private searchControlTemplates As DevExpress.XtraEditors.SearchControl

        Private searchControlCheckedSample As DevExpress.XtraEditors.SearchControl

        Private checkedListBoxControlSample As DevExpress.XtraEditors.CheckedListBoxControl

        Private searchControlImageSample As DevExpress.XtraEditors.SearchControl

        Private imageListBoxControlSample As DevExpress.XtraEditors.ImageListBoxControl

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private tablePanel2 As DevExpress.Utils.Layout.TablePanel

        Private tablePanel3 As DevExpress.Utils.Layout.TablePanel

        Private tablePanel4 As DevExpress.Utils.Layout.TablePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabNavigationPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabNavigationPage4 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private properties As DevExpress.XtraEditors.Demos.ListBoxProperties
    End Class
End Namespace
