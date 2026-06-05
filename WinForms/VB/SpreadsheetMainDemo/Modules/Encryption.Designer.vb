Namespace DevExpress.XtraSpreadsheet.Demos

    Partial Class EncryptionModule

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
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition3 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition4 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition5 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition6 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.chbOpenResultingFile = New DevExpress.XtraEditors.CheckEdit()
            Me.passwordLabel = New DevExpress.XtraEditors.LabelControl()
            Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
            Me.passwordEdit = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.typeEdit = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.typeLabel = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.chbOpenResultingFile.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.passwordEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.typeEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.MinimumSize = New System.Drawing.Size(200, 150)
            Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spreadsheetControl1.Options.Print.PrintContent = DevExpress.XtraSpreadsheet.SpreadsheetPrintContent.ActiveSheets
            Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Options.View.Charts.TextAntialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
            Me.spreadsheetControl1.Size = New System.Drawing.Size(655, 334)
            AddHandler Me.spreadsheetControl1.DocumentLoaded, New System.EventHandler(AddressOf Me.Spreadsheet_DocumentLoaded)
            AddHandler Me.spreadsheetControl1.EmptyDocumentCreated, New System.EventHandler(AddressOf Me.Spreadsheet_NewDocumentCreated)
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
            Me.ribbonControl1.Size = New System.Drawing.Size(858, 150)
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitterControl1.Location = New System.Drawing.Point(853, 25)
            Me.splitterControl1.MinExtra = 250
            Me.splitterControl1.MinSize = 150
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(10, 527)
            Me.splitterControl1.TabIndex = 7
            Me.splitterControl1.TabStop = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.AllowResize = False
            Me.sidePanel1.Controls.Add(Me.layoutControl1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(655, 191)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(203, 334)
            Me.sidePanel1.TabIndex = 9
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' chbOpenResultingFile
            ' 
            Me.chbOpenResultingFile.EditValue = True
            Me.chbOpenResultingFile.Location = New System.Drawing.Point(12, 116)
            Me.chbOpenResultingFile.Name = "chbOpenResultingFile"
            Me.chbOpenResultingFile.Properties.Caption = "Open resulting file"
            Me.chbOpenResultingFile.Size = New System.Drawing.Size(178, 20)
            Me.chbOpenResultingFile.StyleController = Me.layoutControl1
            Me.chbOpenResultingFile.TabIndex = 11
            ' 
            ' passwordLabel
            ' 
            Me.passwordLabel.Location = New System.Drawing.Point(12, 15)
            Me.passwordLabel.Name = "passwordLabel"
            Me.passwordLabel.Size = New System.Drawing.Size(50, 13)
            Me.passwordLabel.StyleController = Me.layoutControl1
            Me.passwordLabel.TabIndex = 12
            Me.passwordLabel.Text = "&Password:"
            ' 
            ' btnExport
            ' 
            Me.btnExport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.btnExport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.btnExport.ImageOptions.SvgImage = Global.DevExpress.XtraSpreadsheet.Demos.Properties.Resources.Save
            Me.btnExport.Location = New System.Drawing.Point(12, 66)
            Me.btnExport.Name = "btnExport"
            Me.btnExport.Size = New System.Drawing.Size(178, 36)
            Me.btnExport.StyleController = Me.layoutControl1
            Me.btnExport.TabIndex = 10
            Me.btnExport.Text = "Encrypt and Save..."
            AddHandler Me.btnExport.Click, New System.EventHandler(AddressOf Me.BtnExport_Click)
            ' 
            ' passwordEdit
            ' 
            Me.passwordEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.passwordEdit.Location = New System.Drawing.Point(71, 12)
            Me.passwordEdit.Name = "passwordEdit"
            Me.passwordEdit.Properties.MaxLength = 255
            Me.passwordEdit.Size = New System.Drawing.Size(119, 20)
            Me.passwordEdit.StyleController = Me.layoutControl1
            Me.passwordEdit.TabIndex = 14
            AddHandler Me.passwordEdit.TextChanged, New System.EventHandler(AddressOf Me.PasswordEdit_TextChanged)
            ' 
            ' typeEdit
            ' 
            Me.typeEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.typeEdit.Location = New System.Drawing.Point(71, 39)
            Me.typeEdit.Name = "typeEdit"
            Me.typeEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.typeEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.typeEdit.Size = New System.Drawing.Size(119, 20)
            Me.typeEdit.StyleController = Me.layoutControl1
            Me.typeEdit.TabIndex = 15
            AddHandler Me.typeEdit.TextChanged, New System.EventHandler(AddressOf Me.TypeEdit_TextChanged)
            ' 
            ' typeLabel
            ' 
            Me.typeLabel.Location = New System.Drawing.Point(12, 42)
            Me.typeLabel.Name = "typeLabel"
            Me.typeLabel.Size = New System.Drawing.Size(28, 13)
            Me.typeLabel.StyleController = Me.layoutControl1
            Me.typeLabel.TabIndex = 13
            Me.typeLabel.Text = "Type:"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.chbOpenResultingFile)
            Me.layoutControl1.Controls.Add(Me.typeEdit)
            Me.layoutControl1.Controls.Add(Me.passwordEdit)
            Me.layoutControl1.Controls.Add(Me.typeLabel)
            Me.layoutControl1.Controls.Add(Me.passwordLabel)
            Me.layoutControl1.Controls.Add(Me.btnExport)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(1, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(202, 334)
            Me.layoutControl1.TabIndex = 16
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.Root.Name = "Root"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition1.Width = 54R
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition2.Width = 73R
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition3.Width = 100R
            Me.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1, columnDefinition2, columnDefinition3})
            rowDefinition1.Height = 24R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition2.Height = 3R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute
            rowDefinition3.Height = 24R
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition4.Height = 43R
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition5.Height = 34R
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition6.Height = 100R
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Percent
            Me.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1, rowDefinition2, rowDefinition3, rowDefinition4, rowDefinition5, rowDefinition6})
            Me.Root.Size = New System.Drawing.Size(202, 334)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.btnExport
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 51)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 3
            Me.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 3
            Me.layoutControlItem1.Size = New System.Drawing.Size(182, 43)
            Me.layoutControlItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 0)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem2.Control = Me.passwordLabel
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(54, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem3.Control = Me.passwordEdit
            Me.layoutControlItem3.Location = New System.Drawing.Point(54, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 2
            Me.layoutControlItem3.Size = New System.Drawing.Size(128, 24)
            Me.layoutControlItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem4.Control = Me.typeLabel
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 27)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem4.Size = New System.Drawing.Size(54, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControlItem5.Control = Me.typeEdit
            Me.layoutControlItem5.Location = New System.Drawing.Point(54, 27)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 2
            Me.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem5.Size = New System.Drawing.Size(128, 24)
            Me.layoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 0, 0, 0)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.chbOpenResultingFile
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 94)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 3
            Me.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 4
            Me.layoutControlItem6.Size = New System.Drawing.Size(182, 34)
            Me.layoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' EncryptionModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "EncryptionModule"
            Me.Size = New System.Drawing.Size(858, 552)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.Controls.SetChildIndex(Me.spreadsheetControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.chbOpenResultingFile.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.passwordEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.typeEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private chbOpenResultingFile As DevExpress.XtraEditors.CheckEdit

        Private passwordLabel As DevExpress.XtraEditors.LabelControl

        Private btnExport As DevExpress.XtraEditors.SimpleButton

        Private passwordEdit As DevExpress.XtraEditors.ComboBoxEdit

        Private typeEdit As DevExpress.XtraEditors.ComboBoxEdit

        Private typeLabel As DevExpress.XtraEditors.LabelControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
