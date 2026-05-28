Namespace DevExpress.XtraSpreadsheet.Demos

    Partial Class TopTradingPartnersModule

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
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition6 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition7 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition8 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition9 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition10 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.chkAsiaRegion = New DevExpress.XtraEditors.CheckEdit()
            Me.chkBalance = New DevExpress.XtraEditors.CheckEdit()
            Me.chkExports = New DevExpress.XtraEditors.CheckEdit()
            Me.chkImports = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.chkAsiaRegion.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkBalance.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkExports.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkImports.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spreadsheetControl1.Options.Print.PrintContent = DevExpress.XtraSpreadsheet.SpreadsheetPrintContent.ActiveSheets
            Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Options.View.Charts.TextAntialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Size = New System.Drawing.Size(569, 192)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 41)
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.AccessibleName = "Search Item"
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(697, 150)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.AllowResize = False
            Me.sidePanel1.Controls.Add(Me.layoutControl1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(569, 191)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(128, 192)
            Me.sidePanel1.TabIndex = 56
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' chkAsiaRegion
            ' 
            Me.chkAsiaRegion.EditValue = True
            Me.chkAsiaRegion.Location = New System.Drawing.Point(12, 84)
            Me.chkAsiaRegion.Name = "chkAsiaRegion"
            Me.chkAsiaRegion.Properties.AutoWidth = True
            Me.chkAsiaRegion.Properties.Caption = "Asia Region"
            Me.chkAsiaRegion.Size = New System.Drawing.Size(79, 20)
            Me.chkAsiaRegion.StyleController = Me.layoutControl1
            Me.chkAsiaRegion.TabIndex = 4
            AddHandler Me.chkAsiaRegion.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkBalance
            ' 
            Me.chkBalance.EditValue = True
            Me.chkBalance.Location = New System.Drawing.Point(12, 60)
            Me.chkBalance.Name = "chkBalance"
            Me.chkBalance.Properties.AutoWidth = True
            Me.chkBalance.Properties.Caption = "Balance"
            Me.chkBalance.Size = New System.Drawing.Size(60, 20)
            Me.chkBalance.StyleController = Me.layoutControl1
            Me.chkBalance.TabIndex = 3
            AddHandler Me.chkBalance.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkExports
            ' 
            Me.chkExports.EditValue = True
            Me.chkExports.Location = New System.Drawing.Point(12, 36)
            Me.chkExports.Name = "chkExports"
            Me.chkExports.Properties.AutoWidth = True
            Me.chkExports.Properties.Caption = "Exports"
            Me.chkExports.Size = New System.Drawing.Size(60, 20)
            Me.chkExports.StyleController = Me.layoutControl1
            Me.chkExports.TabIndex = 2
            AddHandler Me.chkExports.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' chkImports
            ' 
            Me.chkImports.EditValue = True
            Me.chkImports.Location = New System.Drawing.Point(12, 12)
            Me.chkImports.Name = "chkImports"
            Me.chkImports.Properties.AutoWidth = True
            Me.chkImports.Properties.Caption = "Imports"
            Me.chkImports.Size = New System.Drawing.Size(60, 20)
            Me.chkImports.StyleController = Me.layoutControl1
            Me.chkImports.TabIndex = 1
            AddHandler Me.chkImports.CheckedChanged, New System.EventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.chkAsiaRegion)
            Me.layoutControl1.Controls.Add(Me.chkBalance)
            Me.layoutControl1.Controls.Add(Me.chkExports)
            Me.layoutControl1.Controls.Add(Me.chkImports)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(1, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(127, 192)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.Root.Name = "Root"
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition2.Width = 107R
            Me.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition2})
            rowDefinition6.Height = 24R
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition7.Height = 24R
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition8.Height = 24R
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition9.Height = 24R
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition10.Height = 76R
            rowDefinition10.SizeType = System.Windows.Forms.SizeType.AutoSize
            Me.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition6, rowDefinition7, rowDefinition8, rowDefinition9, rowDefinition10})
            Me.Root.Size = New System.Drawing.Size(127, 192)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.chkImports
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(107, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chkExports
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem2.Size = New System.Drawing.Size(107, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chkBalance
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem3.Size = New System.Drawing.Size(107, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.chkAsiaRegion
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3
            Me.layoutControlItem4.Size = New System.Drawing.Size(107, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' TopTradingPartnersModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "TopTradingPartnersModule"
            Me.Size = New System.Drawing.Size(697, 410)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.Controls.SetChildIndex(Me.spreadsheetControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.chkAsiaRegion.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkBalance.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkExports.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkImports.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Protected chkAsiaRegion As DevExpress.XtraEditors.CheckEdit

        Protected chkBalance As DevExpress.XtraEditors.CheckEdit

        Protected chkExports As DevExpress.XtraEditors.CheckEdit

        Protected chkImports As DevExpress.XtraEditors.CheckEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
