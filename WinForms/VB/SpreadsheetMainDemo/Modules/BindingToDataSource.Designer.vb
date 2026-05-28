Namespace DevExpress.XtraSpreadsheet.Demos

    Partial Class BindingToDataSourceModule

        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraSpreadsheet.Demos.BindingToDataSourceModule))
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition4 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition3 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition4 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition5 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition6 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition7 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition8 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.lbBindToData = New DevExpress.XtraEditors.LabelControl()
            Me.cbxBindToData = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.edOrderId = New DevExpress.XtraEditors.LookUpEdit()
            Me.chbDiscount = New DevExpress.XtraEditors.CheckEdit()
            Me.lbOrderId = New DevExpress.XtraEditors.LabelControl()
            Me.lbProduct = New DevExpress.XtraEditors.LabelControl()
            Me.btnReset = New DevExpress.XtraEditors.SimpleButton()
            Me.edProductName = New DevExpress.XtraEditors.LookUpEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.cbxBindToData.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edOrderId.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chbDiscount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.edProductName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Options.Behavior.Column.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
            Me.spreadsheetControl1.Options.Behavior.Column.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
            Me.spreadsheetControl1.Options.Behavior.Row.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
            Me.spreadsheetControl1.Options.Behavior.Row.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
            Me.spreadsheetControl1.Options.Behavior.UseSkinColors = False
            Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spreadsheetControl1.Options.Print.PrintContent = DevExpress.XtraSpreadsheet.SpreadsheetPrintContent.ActiveSheets
            Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Options.View.Charts.TextAntialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            resources.ApplyResources(Me.spreadsheetControl1, "spreadsheetControl1")
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            resources.ApplyResources(Me.ribbonControl1, "ribbonControl1")
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.AccessibleName = resources.GetString("ribbonControl1.SearchEditItem.AccessibleName")
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth =(CInt((resources.GetObject("ribbonControl1.SearchEditItem.EditWidth"))))
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.AllowResize = False
            Me.sidePanel1.Controls.Add(Me.layoutControl1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' lbBindToData
            ' 
            resources.ApplyResources(Me.lbBindToData, "lbBindToData")
            Me.lbBindToData.Name = "lbBindToData"
            Me.lbBindToData.StyleController = Me.layoutControl1
            ' 
            ' cbxBindToData
            ' 
            resources.ApplyResources(Me.cbxBindToData, "cbxBindToData")
            Me.cbxBindToData.Name = "cbxBindToData"
            Me.cbxBindToData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("cbxBindToData.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.cbxBindToData.Properties.DropDownRows = 2
            Me.cbxBindToData.Properties.Items.AddRange(New Object() {resources.GetString("cbxBindToData.Properties.Items"), resources.GetString("cbxBindToData.Properties.Items1")})
            Me.cbxBindToData.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbxBindToData.StyleController = Me.layoutControl1
            AddHandler Me.cbxBindToData.SelectedIndexChanged, New System.EventHandler(AddressOf Me.BindToData_SelectedIndexChanged)
            ' 
            ' edOrderId
            ' 
            resources.ApplyResources(Me.edOrderId, "edOrderId")
            Me.edOrderId.MenuManager = Me.ribbonControl1
            Me.edOrderId.Name = "edOrderId"
            Me.edOrderId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.edOrderId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edOrderId.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.edOrderId.Properties.NullText = resources.GetString("edOrderId.Properties.NullText")
            Me.edOrderId.Properties.PopupFormMinSize = New System.Drawing.Size(140, 0)
            Me.edOrderId.Properties.ShowFooter = False
            Me.edOrderId.Properties.ShowHeader = False
            Me.edOrderId.StyleController = Me.layoutControl1
            AddHandler Me.edOrderId.EditValueChanged, New System.EventHandler(AddressOf Me.OrderId_EditValueChanged)
            ' 
            ' chbDiscount
            ' 
            resources.ApplyResources(Me.chbDiscount, "chbDiscount")
            Me.chbDiscount.MenuManager = Me.ribbonControl1
            Me.chbDiscount.Name = "chbDiscount"
            Me.chbDiscount.Properties.Caption = resources.GetString("chbDiscount.Properties.Caption")
            Me.chbDiscount.StyleController = Me.layoutControl1
            AddHandler Me.chbDiscount.CheckedChanged, New System.EventHandler(AddressOf Me.Discount_CheckedChanged)
            ' 
            ' lbOrderId
            ' 
            resources.ApplyResources(Me.lbOrderId, "lbOrderId")
            Me.lbOrderId.Name = "lbOrderId"
            Me.lbOrderId.StyleController = Me.layoutControl1
            ' 
            ' lbProduct
            ' 
            resources.ApplyResources(Me.lbProduct, "lbProduct")
            Me.lbProduct.Name = "lbProduct"
            Me.lbProduct.StyleController = Me.layoutControl1
            ' 
            ' btnReset
            ' 
            resources.ApplyResources(Me.btnReset, "btnReset")
            Me.btnReset.Name = "btnReset"
            Me.btnReset.StyleController = Me.layoutControl1
            AddHandler Me.btnReset.Click, New System.EventHandler(AddressOf Me.Reset_Click)
            ' 
            ' edProductName
            ' 
            resources.ApplyResources(Me.edProductName, "edProductName")
            Me.edProductName.MenuManager = Me.ribbonControl1
            Me.edProductName.Name = "edProductName"
            Me.edProductName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.edProductName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("edProductName.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.edProductName.Properties.NullText = resources.GetString("edProductName.Properties.NullText")
            Me.edProductName.Properties.ShowFooter = False
            Me.edProductName.Properties.ShowHeader = False
            Me.edProductName.StyleController = Me.layoutControl1
            AddHandler Me.edProductName.EditValueChanged, New System.EventHandler(AddressOf Me.ProductName_EditValueChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.cbxBindToData)
            Me.layoutControl1.Controls.Add(Me.lbBindToData)
            Me.layoutControl1.Controls.Add(Me.edProductName)
            Me.layoutControl1.Controls.Add(Me.lbProduct)
            Me.layoutControl1.Controls.Add(Me.chbDiscount)
            Me.layoutControl1.Controls.Add(Me.btnReset)
            Me.layoutControl1.Controls.Add(Me.edOrderId)
            Me.layoutControl1.Controls.Add(Me.lbOrderId)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(864, 104, 791, 596)
            Me.layoutControl1.Root = Me.Root
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8})
            Me.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.Root.Name = "Root"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition1.Width = 68R
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition2.Width = 20R
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute
            columnDefinition3.Width = 25R
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition4.Width = 115R
            Me.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1, columnDefinition2, columnDefinition3, columnDefinition4})
            rowDefinition1.Height = 24R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition2.Height = 3R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute
            rowDefinition3.Height = 24R
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition4.Height = 3R
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute
            rowDefinition5.Height = 26R
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition6.Height = 10R
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute
            rowDefinition7.Height = 24R
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition8.Height = 217R
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.AutoSize
            Me.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1, rowDefinition2, rowDefinition3, rowDefinition4, rowDefinition5, rowDefinition6, rowDefinition7, rowDefinition8})
            Me.Root.Size = New System.Drawing.Size(248, 351)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem1.Control = Me.lbOrderId
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(68, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItem2.Control = Me.edOrderId
            Me.layoutControlItem2.Location = New System.Drawing.Point(88, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 2
            Me.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 2
            Me.layoutControlItem2.Size = New System.Drawing.Size(140, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem3.Control = Me.chbDiscount
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 4
            Me.layoutControlItem3.Size = New System.Drawing.Size(68, 26)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItem4.Control = Me.btnReset
            Me.layoutControlItem4.Location = New System.Drawing.Point(113, 54)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 3
            Me.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 4
            Me.layoutControlItem4.Size = New System.Drawing.Size(115, 26)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem5.Control = Me.lbProduct
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 27)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem5.Size = New System.Drawing.Size(68, 24)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItem6.Control = Me.edProductName
            Me.layoutControlItem6.Location = New System.Drawing.Point(88, 27)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 2
            Me.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 2
            Me.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem6.Size = New System.Drawing.Size(140, 24)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem7.Control = Me.lbBindToData
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 90)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 6
            Me.layoutControlItem7.Size = New System.Drawing.Size(68, 24)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItem8.Control = Me.cbxBindToData
            Me.layoutControlItem8.Location = New System.Drawing.Point(88, 90)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.OptionsTableLayoutItem.ColumnIndex = 2
            Me.layoutControlItem8.OptionsTableLayoutItem.ColumnSpan = 2
            Me.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 6
            Me.layoutControlItem8.Size = New System.Drawing.Size(140, 24)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' BindingToDataSourceModule
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "BindingToDataSourceModule"
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.Controls.SetChildIndex(Me.spreadsheetControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.cbxBindToData.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edOrderId.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chbDiscount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.edProductName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private lbBindToData As DevExpress.XtraEditors.LabelControl

        Private cbxBindToData As DevExpress.XtraEditors.ComboBoxEdit

        Private edOrderId As DevExpress.XtraEditors.LookUpEdit

        Private chbDiscount As DevExpress.XtraEditors.CheckEdit

        Private lbOrderId As DevExpress.XtraEditors.LabelControl

        Private lbProduct As DevExpress.XtraEditors.LabelControl

        Private btnReset As DevExpress.XtraEditors.SimpleButton

        Private edProductName As DevExpress.XtraEditors.LookUpEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
