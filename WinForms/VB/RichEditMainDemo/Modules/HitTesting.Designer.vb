Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraRichEdit.Demos

    Partial Class HitTestingModule

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
            Dim columnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition4 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition8 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition9 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition10 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition11 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition12 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition13 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition14 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.hitTestPanelControl = New DevExpress.XtraEditors.PanelControl()
            Me.hitTestPanelLayoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.navigationPane = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.rgSearchOptions = New DevExpress.XtraEditors.RadioGroup()
            Me.cbScope = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.highlightPage = New DevExpress.XtraEditors.CheckEdit()
            Me.highlightPageArea = New DevExpress.XtraEditors.CheckEdit()
            Me.pageHigtlightColor = New DevExpress.XtraEditors.ColorEdit()
            Me.highlightColumn = New DevExpress.XtraEditors.CheckEdit()
            Me.highlightRow = New DevExpress.XtraEditors.CheckEdit()
            Me.highlightBox = New DevExpress.XtraEditors.CheckEdit()
            Me.highlightCharacterBox = New DevExpress.XtraEditors.CheckEdit()
            Me.highlightOther = New DevExpress.XtraEditors.CheckEdit()
            Me.pageAreaHigtlightColor = New DevExpress.XtraEditors.ColorEdit()
            Me.columnHigtlightColor = New DevExpress.XtraEditors.ColorEdit()
            Me.rowHigtlightColor = New DevExpress.XtraEditors.ColorEdit()
            Me.boxHigtlightColor = New DevExpress.XtraEditors.ColorEdit()
            Me.characterBoxHigtlightColor = New DevExpress.XtraEditors.ColorEdit()
            Me.otherHigtlightColor = New DevExpress.XtraEditors.ColorEdit()
            Me.lbResult = New DevExpress.XtraEditors.ListBoxControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.scopeLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.cbScopeLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.hitAccuracyLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.rgSearchOptionsLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.highlightOptionsLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.highlightPageLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.highlightPageAreaLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.pageHigtlightColorLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.highlightColumnLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.highlightRowLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.highlightBoxLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.highlightCharacterBoxLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.highlightOtherLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.pageAreaHigtlightColorLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.columnHigtlightColorLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.rowHigtlightColorLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.boxHigtlightColorLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.characterBoxHigtlightColorLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.otherHigtlightColorLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.hitTestResultLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lbResultLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.employeesTableAdapter1 = New DevExpress.XtraRichEdit.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.employeesTableAdapter2 = New DevExpress.XtraRichEdit.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.employeesTableAdapter3 = New DevExpress.XtraRichEdit.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.employeesTableAdapter4 = New DevExpress.XtraRichEdit.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.employeesTableAdapter5 = New DevExpress.XtraRichEdit.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter()
            Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
            Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.nwindDataSet1 = New DevExpress.XtraRichEdit.Demos.nwindDataSet()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.hitTestPanelControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hitTestPanelControl.SuspendLayout()
            CType((Me.hitTestPanelLayoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.hitTestPanelLayoutControl.SuspendLayout()
            CType((Me.navigationPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.rgSearchOptions.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbScope.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightPage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightPageArea.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pageHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightColumn.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightRow.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightCharacterBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightOther.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pageAreaHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.columnHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.boxHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.characterBoxHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.otherHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lbResult), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.scopeLayoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbScopeLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.hitAccuracyLayoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rgSearchOptionsLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightOptionsLayoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightPageLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightPageAreaLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pageHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightColumnLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightRowLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightBoxLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightCharacterBoxLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.highlightOtherLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pageAreaHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.columnHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.boxHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.characterBoxHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.otherHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.hitTestResultLayoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lbResultLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nwindDataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.Control = Me.richEditControl
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(883, 613)
            Me.richEditControl.TabIndex = 44
            AddHandler Me.richEditControl.BeforePagePaint, New DevExpress.XtraRichEdit.BeforePagePaintEventHandler(AddressOf Me.RichEditControl_BeforePagePaint)
            AddHandler Me.richEditControl.MouseClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.RichEditControl_MouseClick)
            AddHandler Me.richEditControl.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.RichEditControl_MouseMove)
            ' 
            ' hitTestPanelControl
            ' 
            Me.hitTestPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.hitTestPanelControl.Controls.Add(Me.hitTestPanelLayoutControl)
            Me.hitTestPanelControl.Dock = System.Windows.Forms.DockStyle.Right
            Me.hitTestPanelControl.Location = New System.Drawing.Point(883, 0)
            Me.hitTestPanelControl.Name = "hitTestPanelControl"
            Me.hitTestPanelControl.Size = New System.Drawing.Size(280, 613)
            Me.hitTestPanelControl.TabIndex = 43
            ' 
            ' hitTestPanelLayoutControl
            ' 
            Me.hitTestPanelLayoutControl.Controls.Add(Me.navigationPane)
            Me.hitTestPanelLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.hitTestPanelLayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.hitTestPanelLayoutControl.Name = "hitTestPanelLayoutControl"
            Me.hitTestPanelLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(360, 247, 650, 400)
            Me.hitTestPanelLayoutControl.Root = Me.Root
            Me.hitTestPanelLayoutControl.Size = New System.Drawing.Size(280, 613)
            Me.hitTestPanelLayoutControl.TabIndex = 0
            Me.hitTestPanelLayoutControl.Text = "layoutControl1"
            ' 
            ' navigationPane
            ' 
            Me.navigationPane.Controls.Add(Me.navigationPage1)
            Me.navigationPane.Location = New System.Drawing.Point(0, 0)
            Me.navigationPane.Name = "navigationPane"
            Me.navigationPane.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane.RegularSize = New System.Drawing.Size(280, 613)
            Me.navigationPane.SelectedPage = Me.navigationPage1
            Me.navigationPane.Size = New System.Drawing.Size(280, 613)
            Me.navigationPane.TabIndex = 11
            Me.navigationPane.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Hit Test Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.ImageOptions.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Properties.AppearanceCaption.Options.UseBorderColor = True
            Me.navigationPage1.Size = New System.Drawing.Size(280, 580)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.rgSearchOptions)
            Me.layoutControl1.Controls.Add(Me.cbScope)
            Me.layoutControl1.Controls.Add(Me.highlightPage)
            Me.layoutControl1.Controls.Add(Me.highlightPageArea)
            Me.layoutControl1.Controls.Add(Me.pageHigtlightColor)
            Me.layoutControl1.Controls.Add(Me.highlightColumn)
            Me.layoutControl1.Controls.Add(Me.highlightRow)
            Me.layoutControl1.Controls.Add(Me.highlightBox)
            Me.layoutControl1.Controls.Add(Me.highlightCharacterBox)
            Me.layoutControl1.Controls.Add(Me.highlightOther)
            Me.layoutControl1.Controls.Add(Me.pageAreaHigtlightColor)
            Me.layoutControl1.Controls.Add(Me.columnHigtlightColor)
            Me.layoutControl1.Controls.Add(Me.rowHigtlightColor)
            Me.layoutControl1.Controls.Add(Me.boxHigtlightColor)
            Me.layoutControl1.Controls.Add(Me.characterBoxHigtlightColor)
            Me.layoutControl1.Controls.Add(Me.otherHigtlightColor)
            Me.layoutControl1.Controls.Add(Me.lbResult)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(35, 380, 1017, 646)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(280, 580)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' rgSearchOptions
            ' 
            Me.rgSearchOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.rgSearchOptions.AutoSizeInLayoutControl = True
            Me.rgSearchOptions.Location = New System.Drawing.Point(9, 91)
            Me.rgSearchOptions.Name = "rgSearchOptions"
            Me.rgSearchOptions.Properties.Appearance.BackColor = System.Drawing.Color.White
            Me.rgSearchOptions.Properties.Appearance.Options.UseBackColor = True
            Me.rgSearchOptions.Properties.Columns = 1
            Me.rgSearchOptions.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Exact Hit"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Nearest Hit")})
            Me.rgSearchOptions.Size = New System.Drawing.Size(245, 58)
            Me.rgSearchOptions.StyleController = Me.layoutControl1
            Me.rgSearchOptions.TabIndex = 26
            ' 
            ' cbScope
            ' 
            Me.cbScope.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.cbScope.Location = New System.Drawing.Point(9, 31)
            Me.cbScope.MenuManager = Me
            Me.cbScope.Name = "cbScope"
            Me.cbScope.Properties.Appearance.BackColor = System.Drawing.Color.White
            Me.cbScope.Properties.Appearance.Options.UseBackColor = True
            Me.cbScope.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbScope.Properties.DropDownRows = 4
            Me.cbScope.Size = New System.Drawing.Size(245, 20)
            Me.cbScope.StyleController = Me.layoutControl1
            Me.cbScope.TabIndex = 25
            ' 
            ' highlightPage
            ' 
            Me.highlightPage.EditValue = True
            Me.highlightPage.Location = New System.Drawing.Point(11, 185)
            Me.highlightPage.Name = "highlightPage"
            Me.highlightPage.Properties.Caption = "Page"
            Me.highlightPage.Size = New System.Drawing.Size(118, 20)
            Me.highlightPage.StyleController = Me.layoutControl1
            Me.highlightPage.TabIndex = 24
            ' 
            ' highlightPageArea
            ' 
            Me.highlightPageArea.EditValue = True
            Me.highlightPageArea.Location = New System.Drawing.Point(11, 209)
            Me.highlightPageArea.Name = "highlightPageArea"
            Me.highlightPageArea.Properties.Caption = "PageArea"
            Me.highlightPageArea.Size = New System.Drawing.Size(118, 20)
            Me.highlightPageArea.StyleController = Me.layoutControl1
            Me.highlightPageArea.TabIndex = 29
            ' 
            ' pageHigtlightColor
            ' 
            Me.pageHigtlightColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.pageHigtlightColor.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.pageHigtlightColor.EditValue = System.Drawing.Color.RoyalBlue
            Me.pageHigtlightColor.Location = New System.Drawing.Point(133, 185)
            Me.pageHigtlightColor.Name = "pageHigtlightColor"
            Me.pageHigtlightColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.pageHigtlightColor.Size = New System.Drawing.Size(119, 20)
            Me.pageHigtlightColor.StyleController = Me.layoutControl1
            Me.pageHigtlightColor.TabIndex = 25
            AddHandler Me.pageHigtlightColor.EditValueChanged, AddressOf Me.OnHighlightOptionsChanged
            ' 
            ' highlightColumn
            ' 
            Me.highlightColumn.EditValue = True
            Me.highlightColumn.Location = New System.Drawing.Point(11, 233)
            Me.highlightColumn.Name = "highlightColumn"
            Me.highlightColumn.Properties.Caption = "Column"
            Me.highlightColumn.Size = New System.Drawing.Size(118, 20)
            Me.highlightColumn.StyleController = Me.layoutControl1
            Me.highlightColumn.TabIndex = 29
            ' 
            ' highlightRow
            ' 
            Me.highlightRow.EditValue = True
            Me.highlightRow.Location = New System.Drawing.Point(11, 257)
            Me.highlightRow.Name = "highlightRow"
            Me.highlightRow.Properties.Caption = "Row"
            Me.highlightRow.Size = New System.Drawing.Size(118, 20)
            Me.highlightRow.StyleController = Me.layoutControl1
            Me.highlightRow.TabIndex = 29
            ' 
            ' highlightBox
            ' 
            Me.highlightBox.EditValue = True
            Me.highlightBox.Location = New System.Drawing.Point(11, 281)
            Me.highlightBox.Name = "highlightBox"
            Me.highlightBox.Properties.Caption = "Box"
            Me.highlightBox.Size = New System.Drawing.Size(118, 20)
            Me.highlightBox.StyleController = Me.layoutControl1
            Me.highlightBox.TabIndex = 29
            ' 
            ' highlightCharacterBox
            ' 
            Me.highlightCharacterBox.EditValue = True
            Me.highlightCharacterBox.Location = New System.Drawing.Point(11, 305)
            Me.highlightCharacterBox.Name = "highlightCharacterBox"
            Me.highlightCharacterBox.Properties.Caption = "CharacterBox"
            Me.highlightCharacterBox.Size = New System.Drawing.Size(118, 20)
            Me.highlightCharacterBox.StyleController = Me.layoutControl1
            Me.highlightCharacterBox.TabIndex = 29
            ' 
            ' highlightOther
            ' 
            Me.highlightOther.EditValue = True
            Me.highlightOther.Location = New System.Drawing.Point(11, 329)
            Me.highlightOther.Name = "highlightOther"
            Me.highlightOther.Properties.Caption = "Other elements"
            Me.highlightOther.Size = New System.Drawing.Size(118, 20)
            Me.highlightOther.StyleController = Me.layoutControl1
            Me.highlightOther.TabIndex = 29
            ' 
            ' pageAreaHigtlightColor
            ' 
            Me.pageAreaHigtlightColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.pageAreaHigtlightColor.EditValue = System.Drawing.Color.SlateBlue
            Me.pageAreaHigtlightColor.Location = New System.Drawing.Point(133, 209)
            Me.pageAreaHigtlightColor.Name = "pageAreaHigtlightColor"
            Me.pageAreaHigtlightColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.pageAreaHigtlightColor.Size = New System.Drawing.Size(119, 20)
            Me.pageAreaHigtlightColor.StyleController = Me.layoutControl1
            Me.pageAreaHigtlightColor.TabIndex = 30
            AddHandler Me.pageAreaHigtlightColor.EditValueChanged, AddressOf Me.OnHighlightOptionsChanged
            ' 
            ' columnHigtlightColor
            ' 
            Me.columnHigtlightColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.columnHigtlightColor.EditValue = System.Drawing.Color.Chocolate
            Me.columnHigtlightColor.Location = New System.Drawing.Point(133, 233)
            Me.columnHigtlightColor.Name = "columnHigtlightColor"
            Me.columnHigtlightColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.columnHigtlightColor.Size = New System.Drawing.Size(119, 20)
            Me.columnHigtlightColor.StyleController = Me.layoutControl1
            Me.columnHigtlightColor.TabIndex = 30
            AddHandler Me.columnHigtlightColor.EditValueChanged, AddressOf Me.OnHighlightOptionsChanged
            ' 
            ' rowHigtlightColor
            ' 
            Me.rowHigtlightColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.rowHigtlightColor.EditValue = System.Drawing.Color.Aqua
            Me.rowHigtlightColor.Location = New System.Drawing.Point(133, 257)
            Me.rowHigtlightColor.Name = "rowHigtlightColor"
            Me.rowHigtlightColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.rowHigtlightColor.Size = New System.Drawing.Size(119, 20)
            Me.rowHigtlightColor.StyleController = Me.layoutControl1
            Me.rowHigtlightColor.TabIndex = 30
            AddHandler Me.rowHigtlightColor.EditValueChanged, AddressOf Me.OnHighlightOptionsChanged
            ' 
            ' boxHigtlightColor
            ' 
            Me.boxHigtlightColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.boxHigtlightColor.EditValue = System.Drawing.Color.Magenta
            Me.boxHigtlightColor.Location = New System.Drawing.Point(133, 281)
            Me.boxHigtlightColor.Name = "boxHigtlightColor"
            Me.boxHigtlightColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.boxHigtlightColor.Size = New System.Drawing.Size(119, 20)
            Me.boxHigtlightColor.StyleController = Me.layoutControl1
            Me.boxHigtlightColor.TabIndex = 30
            AddHandler Me.boxHigtlightColor.EditValueChanged, AddressOf Me.OnHighlightOptionsChanged
            ' 
            ' characterBoxHigtlightColor
            ' 
            Me.characterBoxHigtlightColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.characterBoxHigtlightColor.EditValue = System.Drawing.Color.Yellow
            Me.characterBoxHigtlightColor.Location = New System.Drawing.Point(133, 305)
            Me.characterBoxHigtlightColor.Name = "characterBoxHigtlightColor"
            Me.characterBoxHigtlightColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.characterBoxHigtlightColor.Size = New System.Drawing.Size(119, 20)
            Me.characterBoxHigtlightColor.StyleController = Me.layoutControl1
            Me.characterBoxHigtlightColor.TabIndex = 30
            AddHandler Me.characterBoxHigtlightColor.EditValueChanged, AddressOf Me.OnHighlightOptionsChanged
            ' 
            ' otherHigtlightColor
            ' 
            Me.otherHigtlightColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.otherHigtlightColor.EditValue = System.Drawing.Color.ForestGreen
            Me.otherHigtlightColor.Location = New System.Drawing.Point(133, 329)
            Me.otherHigtlightColor.Name = "otherHigtlightColor"
            Me.otherHigtlightColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.otherHigtlightColor.Size = New System.Drawing.Size(119, 20)
            Me.otherHigtlightColor.StyleController = Me.layoutControl1
            Me.otherHigtlightColor.TabIndex = 30
            AddHandler Me.otherHigtlightColor.EditValueChanged, AddressOf Me.OnHighlightOptionsChanged
            ' 
            ' lbResult
            ' 
            Me.lbResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.lbResult.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.lbResult.Location = New System.Drawing.Point(9, 385)
            Me.lbResult.MinimumSize = New System.Drawing.Size(0, 200)
            Me.lbResult.Name = "lbResult"
            Me.lbResult.Size = New System.Drawing.Size(245, 200)
            Me.lbResult.StyleController = Me.layoutControl1
            Me.lbResult.TabIndex = 37
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.scopeLayoutControlGroup, Me.hitAccuracyLayoutControlGroup, Me.highlightOptionsLayoutControlGroup, Me.hitTestResultLayoutControlGroup})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(263, 594)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' scopeLayoutControlGroup
            ' 
            Me.scopeLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.scopeLayoutControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.scopeLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.cbScopeLayoutControlItem})
            Me.scopeLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
            Me.scopeLayoutControlGroup.Name = "scopeLayoutControlGroup"
            Me.scopeLayoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9)
            Me.scopeLayoutControlGroup.Size = New System.Drawing.Size(263, 60)
            Me.scopeLayoutControlGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.scopeLayoutControlGroup.Text = "Scope"
            ' 
            ' cbScopeLayoutControlItem
            ' 
            Me.cbScopeLayoutControlItem.Control = Me.cbScope
            Me.cbScopeLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.cbScopeLayoutControlItem.Name = "cbScopeLayoutControlItem"
            Me.cbScopeLayoutControlItem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.cbScopeLayoutControlItem.Size = New System.Drawing.Size(245, 20)
            Me.cbScopeLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.cbScopeLayoutControlItem.TextVisible = False
            ' 
            ' hitAccuracyLayoutControlGroup
            ' 
            Me.hitAccuracyLayoutControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.hitAccuracyLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.rgSearchOptionsLayoutControlItem})
            Me.hitAccuracyLayoutControlGroup.Location = New System.Drawing.Point(0, 60)
            Me.hitAccuracyLayoutControlGroup.Name = "hitAccuracyLayoutControlGroup"
            Me.hitAccuracyLayoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9)
            Me.hitAccuracyLayoutControlGroup.Size = New System.Drawing.Size(263, 98)
            Me.hitAccuracyLayoutControlGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.hitAccuracyLayoutControlGroup.Text = "Hit Accuracy"
            ' 
            ' rgSearchOptionsLayoutControlItem
            ' 
            Me.rgSearchOptionsLayoutControlItem.Control = Me.rgSearchOptions
            Me.rgSearchOptionsLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.rgSearchOptionsLayoutControlItem.Name = "rgSearchOptionsLayoutControlItem"
            Me.rgSearchOptionsLayoutControlItem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.rgSearchOptionsLayoutControlItem.Size = New System.Drawing.Size(245, 58)
            Me.rgSearchOptionsLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.rgSearchOptionsLayoutControlItem.TextVisible = False
            ' 
            ' highlightOptionsLayoutControlGroup
            ' 
            Me.highlightOptionsLayoutControlGroup.CustomizationFormText = "Highlight Options"
            Me.highlightOptionsLayoutControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.highlightOptionsLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.highlightPageLayoutControlItem, Me.highlightPageAreaLayoutControlItem, Me.pageHigtlightColorLayoutControlItem, Me.highlightColumnLayoutControlItem, Me.highlightRowLayoutControlItem, Me.highlightBoxLayoutControlItem, Me.highlightCharacterBoxLayoutControlItem, Me.highlightOtherLayoutControlItem, Me.pageAreaHigtlightColorLayoutControlItem, Me.columnHigtlightColorLayoutControlItem, Me.rowHigtlightColorLayoutControlItem, Me.boxHigtlightColorLayoutControlItem, Me.characterBoxHigtlightColorLayoutControlItem, Me.otherHigtlightColorLayoutControlItem})
            Me.highlightOptionsLayoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.highlightOptionsLayoutControlGroup.Location = New System.Drawing.Point(0, 158)
            Me.highlightOptionsLayoutControlGroup.Name = "highlightOptionsLayoutControlGroup"
            Me.highlightOptionsLayoutControlGroup.OptionsItemText.TextToControlDistance = 3
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition3.Width = 100R
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition4.Width = 100R
            Me.highlightOptionsLayoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition3, columnDefinition4})
            rowDefinition8.Height = 100R
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition9.Height = 100R
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition10.Height = 100R
            rowDefinition10.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition11.Height = 100R
            rowDefinition11.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition12.Height = 100R
            rowDefinition12.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition13.Height = 100R
            rowDefinition13.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition14.Height = 100R
            rowDefinition14.SizeType = System.Windows.Forms.SizeType.Percent
            Me.highlightOptionsLayoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition8, rowDefinition9, rowDefinition10, rowDefinition11, rowDefinition12, rowDefinition13, rowDefinition14})
            Me.highlightOptionsLayoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 3, 3)
            Me.highlightOptionsLayoutControlGroup.Size = New System.Drawing.Size(263, 196)
            Me.highlightOptionsLayoutControlGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.highlightOptionsLayoutControlGroup.Text = "Highlight Options"
            ' 
            ' highlightPageLayoutControlItem
            ' 
            Me.highlightPageLayoutControlItem.Control = Me.highlightPage
            Me.highlightPageLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.highlightPageLayoutControlItem.CustomizationFormText = "highlightPageLayoutControlItem"
            Me.highlightPageLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.highlightPageLayoutControlItem.Name = "highlightPageLayoutControlItem"
            Me.highlightPageLayoutControlItem.Size = New System.Drawing.Size(122, 24)
            Me.highlightPageLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.highlightPageLayoutControlItem.TextVisible = False
            ' 
            ' highlightPageAreaLayoutControlItem
            ' 
            Me.highlightPageAreaLayoutControlItem.Control = Me.highlightPageArea
            Me.highlightPageAreaLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.highlightPageAreaLayoutControlItem.CustomizationFormText = "highlightPageAreaLayoutControlItem"
            Me.highlightPageAreaLayoutControlItem.Location = New System.Drawing.Point(0, 24)
            Me.highlightPageAreaLayoutControlItem.Name = "highlightPageAreaLayoutControlItem"
            Me.highlightPageAreaLayoutControlItem.OptionsTableLayoutItem.RowIndex = 1
            Me.highlightPageAreaLayoutControlItem.Size = New System.Drawing.Size(122, 24)
            Me.highlightPageAreaLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.highlightPageAreaLayoutControlItem.TextVisible = False
            ' 
            ' pageHigtlightColorLayoutControlItem
            ' 
            Me.pageHigtlightColorLayoutControlItem.Control = Me.pageHigtlightColor
            Me.pageHigtlightColorLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.pageHigtlightColorLayoutControlItem.CustomizationFormText = "pageHigtlightColorLayoutControlItem"
            Me.pageHigtlightColorLayoutControlItem.Location = New System.Drawing.Point(122, 0)
            Me.pageHigtlightColorLayoutControlItem.Name = "pageHigtlightColorLayoutControlItem"
            Me.pageHigtlightColorLayoutControlItem.OptionsTableLayoutItem.ColumnIndex = 1
            Me.pageHigtlightColorLayoutControlItem.Size = New System.Drawing.Size(123, 24)
            Me.pageHigtlightColorLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.pageHigtlightColorLayoutControlItem.TextVisible = False
            ' 
            ' highlightColumnLayoutControlItem
            ' 
            Me.highlightColumnLayoutControlItem.Control = Me.highlightColumn
            Me.highlightColumnLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.highlightColumnLayoutControlItem.CustomizationFormText = "highlightColumnLayoutControlItem"
            Me.highlightColumnLayoutControlItem.Location = New System.Drawing.Point(0, 48)
            Me.highlightColumnLayoutControlItem.Name = "highlightColumnLayoutControlItem"
            Me.highlightColumnLayoutControlItem.OptionsTableLayoutItem.RowIndex = 2
            Me.highlightColumnLayoutControlItem.Size = New System.Drawing.Size(122, 24)
            Me.highlightColumnLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.highlightColumnLayoutControlItem.TextVisible = False
            ' 
            ' highlightRowLayoutControlItem
            ' 
            Me.highlightRowLayoutControlItem.Control = Me.highlightRow
            Me.highlightRowLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.highlightRowLayoutControlItem.CustomizationFormText = "highlightRowLayoutControlItem"
            Me.highlightRowLayoutControlItem.Location = New System.Drawing.Point(0, 72)
            Me.highlightRowLayoutControlItem.Name = "highlightRowLayoutControlItem"
            Me.highlightRowLayoutControlItem.OptionsTableLayoutItem.RowIndex = 3
            Me.highlightRowLayoutControlItem.Size = New System.Drawing.Size(122, 24)
            Me.highlightRowLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.highlightRowLayoutControlItem.TextVisible = False
            ' 
            ' highlightBoxLayoutControlItem
            ' 
            Me.highlightBoxLayoutControlItem.Control = Me.highlightBox
            Me.highlightBoxLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.highlightBoxLayoutControlItem.CustomizationFormText = "highlightBoxLayoutControlItem"
            Me.highlightBoxLayoutControlItem.Location = New System.Drawing.Point(0, 96)
            Me.highlightBoxLayoutControlItem.Name = "highlightBoxLayoutControlItem"
            Me.highlightBoxLayoutControlItem.OptionsTableLayoutItem.RowIndex = 4
            Me.highlightBoxLayoutControlItem.Size = New System.Drawing.Size(122, 24)
            Me.highlightBoxLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.highlightBoxLayoutControlItem.TextVisible = False
            ' 
            ' highlightCharacterBoxLayoutControlItem
            ' 
            Me.highlightCharacterBoxLayoutControlItem.Control = Me.highlightCharacterBox
            Me.highlightCharacterBoxLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.highlightCharacterBoxLayoutControlItem.CustomizationFormText = "highlightCharacterBoxLayoutControlItem"
            Me.highlightCharacterBoxLayoutControlItem.Location = New System.Drawing.Point(0, 120)
            Me.highlightCharacterBoxLayoutControlItem.Name = "highlightCharacterBoxLayoutControlItem"
            Me.highlightCharacterBoxLayoutControlItem.OptionsTableLayoutItem.RowIndex = 5
            Me.highlightCharacterBoxLayoutControlItem.Size = New System.Drawing.Size(122, 24)
            Me.highlightCharacterBoxLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.highlightCharacterBoxLayoutControlItem.TextVisible = False
            ' 
            ' highlightOtherLayoutControlItem
            ' 
            Me.highlightOtherLayoutControlItem.Control = Me.highlightOther
            Me.highlightOtherLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.highlightOtherLayoutControlItem.CustomizationFormText = "highlightOtherLayoutControlItem"
            Me.highlightOtherLayoutControlItem.Location = New System.Drawing.Point(0, 144)
            Me.highlightOtherLayoutControlItem.Name = "highlightOtherLayoutControlItem"
            Me.highlightOtherLayoutControlItem.OptionsTableLayoutItem.RowIndex = 6
            Me.highlightOtherLayoutControlItem.Size = New System.Drawing.Size(122, 24)
            Me.highlightOtherLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.highlightOtherLayoutControlItem.TextVisible = False
            ' 
            ' pageAreaHigtlightColorLayoutControlItem
            ' 
            Me.pageAreaHigtlightColorLayoutControlItem.Control = Me.pageAreaHigtlightColor
            Me.pageAreaHigtlightColorLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.pageAreaHigtlightColorLayoutControlItem.CustomizationFormText = "pageAreaHigtlightColorLayoutControlItem"
            Me.pageAreaHigtlightColorLayoutControlItem.Location = New System.Drawing.Point(122, 24)
            Me.pageAreaHigtlightColorLayoutControlItem.Name = "pageAreaHigtlightColorLayoutControlItem"
            Me.pageAreaHigtlightColorLayoutControlItem.OptionsTableLayoutItem.ColumnIndex = 1
            Me.pageAreaHigtlightColorLayoutControlItem.OptionsTableLayoutItem.RowIndex = 1
            Me.pageAreaHigtlightColorLayoutControlItem.Size = New System.Drawing.Size(123, 24)
            Me.pageAreaHigtlightColorLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.pageAreaHigtlightColorLayoutControlItem.TextVisible = False
            ' 
            ' columnHigtlightColorLayoutControlItem
            ' 
            Me.columnHigtlightColorLayoutControlItem.Control = Me.columnHigtlightColor
            Me.columnHigtlightColorLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.columnHigtlightColorLayoutControlItem.CustomizationFormText = "columnHigtlightColorLayoutControlItem"
            Me.columnHigtlightColorLayoutControlItem.Location = New System.Drawing.Point(122, 48)
            Me.columnHigtlightColorLayoutControlItem.Name = "columnHigtlightColorLayoutControlItem"
            Me.columnHigtlightColorLayoutControlItem.OptionsTableLayoutItem.ColumnIndex = 1
            Me.columnHigtlightColorLayoutControlItem.OptionsTableLayoutItem.RowIndex = 2
            Me.columnHigtlightColorLayoutControlItem.Size = New System.Drawing.Size(123, 24)
            Me.columnHigtlightColorLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.columnHigtlightColorLayoutControlItem.TextVisible = False
            ' 
            ' rowHigtlightColorLayoutControlItem
            ' 
            Me.rowHigtlightColorLayoutControlItem.Control = Me.rowHigtlightColor
            Me.rowHigtlightColorLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.rowHigtlightColorLayoutControlItem.CustomizationFormText = "rowHigtlightColorLayoutControlItem"
            Me.rowHigtlightColorLayoutControlItem.Location = New System.Drawing.Point(122, 72)
            Me.rowHigtlightColorLayoutControlItem.Name = "rowHigtlightColorLayoutControlItem"
            Me.rowHigtlightColorLayoutControlItem.OptionsTableLayoutItem.ColumnIndex = 1
            Me.rowHigtlightColorLayoutControlItem.OptionsTableLayoutItem.RowIndex = 3
            Me.rowHigtlightColorLayoutControlItem.Size = New System.Drawing.Size(123, 24)
            Me.rowHigtlightColorLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.rowHigtlightColorLayoutControlItem.TextVisible = False
            ' 
            ' boxHigtlightColorLayoutControlItem
            ' 
            Me.boxHigtlightColorLayoutControlItem.Control = Me.boxHigtlightColor
            Me.boxHigtlightColorLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.boxHigtlightColorLayoutControlItem.CustomizationFormText = "boxHigtlightColorLayoutControlItem"
            Me.boxHigtlightColorLayoutControlItem.Location = New System.Drawing.Point(122, 96)
            Me.boxHigtlightColorLayoutControlItem.Name = "boxHigtlightColorLayoutControlItem"
            Me.boxHigtlightColorLayoutControlItem.OptionsTableLayoutItem.ColumnIndex = 1
            Me.boxHigtlightColorLayoutControlItem.OptionsTableLayoutItem.RowIndex = 4
            Me.boxHigtlightColorLayoutControlItem.Size = New System.Drawing.Size(123, 24)
            Me.boxHigtlightColorLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.boxHigtlightColorLayoutControlItem.TextVisible = False
            ' 
            ' characterBoxHigtlightColorLayoutControlItem
            ' 
            Me.characterBoxHigtlightColorLayoutControlItem.Control = Me.characterBoxHigtlightColor
            Me.characterBoxHigtlightColorLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.characterBoxHigtlightColorLayoutControlItem.CustomizationFormText = "characterBoxHigtlightColorLayoutControlItem"
            Me.characterBoxHigtlightColorLayoutControlItem.Location = New System.Drawing.Point(122, 120)
            Me.characterBoxHigtlightColorLayoutControlItem.Name = "characterBoxHigtlightColorLayoutControlItem"
            Me.characterBoxHigtlightColorLayoutControlItem.OptionsTableLayoutItem.ColumnIndex = 1
            Me.characterBoxHigtlightColorLayoutControlItem.OptionsTableLayoutItem.RowIndex = 5
            Me.characterBoxHigtlightColorLayoutControlItem.Size = New System.Drawing.Size(123, 24)
            Me.characterBoxHigtlightColorLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.characterBoxHigtlightColorLayoutControlItem.TextVisible = False
            ' 
            ' otherHigtlightColorLayoutControlItem
            ' 
            Me.otherHigtlightColorLayoutControlItem.Control = Me.otherHigtlightColor
            Me.otherHigtlightColorLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.otherHigtlightColorLayoutControlItem.CustomizationFormText = "otherHigtlightColorLayoutControlItem"
            Me.otherHigtlightColorLayoutControlItem.Location = New System.Drawing.Point(122, 144)
            Me.otherHigtlightColorLayoutControlItem.Name = "otherHigtlightColorLayoutControlItem"
            Me.otherHigtlightColorLayoutControlItem.OptionsTableLayoutItem.ColumnIndex = 1
            Me.otherHigtlightColorLayoutControlItem.OptionsTableLayoutItem.RowIndex = 6
            Me.otherHigtlightColorLayoutControlItem.Size = New System.Drawing.Size(123, 24)
            Me.otherHigtlightColorLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.otherHigtlightColorLayoutControlItem.TextVisible = False
            ' 
            ' hitTestResultLayoutControlGroup
            ' 
            Me.hitTestResultLayoutControlGroup.CustomizationFormText = "Hit Test Result"
            Me.hitTestResultLayoutControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.hitTestResultLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lbResultLayoutControlItem})
            Me.hitTestResultLayoutControlGroup.Location = New System.Drawing.Point(0, 354)
            Me.hitTestResultLayoutControlGroup.Name = "hitTestResultLayoutControlGroup"
            Me.hitTestResultLayoutControlGroup.OptionsItemText.TextToControlDistance = 3
            Me.hitTestResultLayoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9)
            Me.hitTestResultLayoutControlGroup.Size = New System.Drawing.Size(263, 240)
            Me.hitTestResultLayoutControlGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.hitTestResultLayoutControlGroup.Text = "Hit Test Result"
            ' 
            ' lbResultLayoutControlItem
            ' 
            Me.lbResultLayoutControlItem.Control = Me.lbResult
            Me.lbResultLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.lbResultLayoutControlItem.CustomizationFormText = "lbResultLayoutControlItem"
            Me.lbResultLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.lbResultLayoutControlItem.Name = "lbResultLayoutControlItem"
            Me.lbResultLayoutControlItem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lbResultLayoutControlItem.Size = New System.Drawing.Size(245, 200)
            Me.lbResultLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.lbResultLayoutControlItem.TextVisible = False
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem12})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(280, 613)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.navigationPane
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem12.Size = New System.Drawing.Size(280, 613)
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' employeesTableAdapter1
            ' 
            Me.employeesTableAdapter1.ClearBeforeFill = True
            ' 
            ' employeesTableAdapter2
            ' 
            Me.employeesTableAdapter2.ClearBeforeFill = True
            ' 
            ' employeesTableAdapter3
            ' 
            Me.employeesTableAdapter3.ClearBeforeFill = True
            ' 
            ' employeesTableAdapter4
            ' 
            Me.employeesTableAdapter4.ClearBeforeFill = True
            ' 
            ' employeesTableAdapter5
            ' 
            Me.employeesTableAdapter5.ClearBeforeFill = True
            ' 
            ' separatorControl1
            ' 
            Me.separatorControl1.AutoSizeMode = True
            Me.separatorControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
            Me.separatorControl1.Location = New System.Drawing.Point(882, 0)
            Me.separatorControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Name = "separatorControl1"
            Me.separatorControl1.Padding = New System.Windows.Forms.Padding(0)
            Me.separatorControl1.Size = New System.Drawing.Size(1, 613)
            Me.separatorControl1.TabIndex = 45
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' HitTestingModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.separatorControl1)
            Me.Controls.Add(Me.richEditControl)
            Me.Controls.Add(Me.hitTestPanelControl)
            Me.Name = "HitTestingModule"
            Me.Size = New System.Drawing.Size(1163, 613)
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.hitTestPanelControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.hitTestPanelControl.ResumeLayout(False)
            CType((Me.hitTestPanelLayoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.hitTestPanelLayoutControl.ResumeLayout(False)
            CType((Me.navigationPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.rgSearchOptions.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbScope.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightPage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightPageArea.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pageHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightColumn.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightRow.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightCharacterBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightOther.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pageAreaHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.columnHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.boxHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.characterBoxHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.otherHigtlightColor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lbResult), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.scopeLayoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbScopeLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.hitAccuracyLayoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rgSearchOptionsLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightOptionsLayoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightPageLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightPageAreaLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pageHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightColumnLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightRowLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightBoxLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightCharacterBoxLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.highlightOtherLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pageAreaHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.columnHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.boxHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.characterBoxHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.otherHigtlightColorLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.hitTestResultLayoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lbResultLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separatorControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nwindDataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private hitTestPanelControl As DevExpress.XtraEditors.PanelControl

        Private hitTestPanelLayoutControl As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private navigationPane As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private employeesTableAdapter1 As DevExpress.XtraRichEdit.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter

        Private employeesTableAdapter2 As DevExpress.XtraRichEdit.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter

        Private employeesTableAdapter3 As DevExpress.XtraRichEdit.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter

        Private employeesTableAdapter4 As DevExpress.XtraRichEdit.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter

        Private separatorControl1 As DevExpress.XtraEditors.SeparatorControl

        Private employeesTableAdapter5 As DevExpress.XtraRichEdit.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter

        Private backgroundWorker1 As System.ComponentModel.BackgroundWorker

        Private cbScope As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cbScopeLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private scopeLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private rgSearchOptions As DevExpress.XtraEditors.RadioGroup

        Private rgSearchOptionsLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private hitAccuracyLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private highlightPage As DevExpress.XtraEditors.CheckEdit

        Private highlightPageArea As DevExpress.XtraEditors.CheckEdit

        Private pageHigtlightColor As DevExpress.XtraEditors.ColorEdit

        Private highlightColumn As DevExpress.XtraEditors.CheckEdit

        Private highlightRow As DevExpress.XtraEditors.CheckEdit

        Private highlightBox As DevExpress.XtraEditors.CheckEdit

        Private highlightCharacterBox As DevExpress.XtraEditors.CheckEdit

        Private highlightOther As DevExpress.XtraEditors.CheckEdit

        Private pageAreaHigtlightColor As DevExpress.XtraEditors.ColorEdit

        Private columnHigtlightColor As DevExpress.XtraEditors.ColorEdit

        Private rowHigtlightColor As DevExpress.XtraEditors.ColorEdit

        Private boxHigtlightColor As DevExpress.XtraEditors.ColorEdit

        Private characterBoxHigtlightColor As DevExpress.XtraEditors.ColorEdit

        Private otherHigtlightColor As DevExpress.XtraEditors.ColorEdit

        Private highlightOptionsLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private highlightPageLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private highlightPageAreaLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private pageHigtlightColorLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private highlightColumnLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private highlightRowLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private highlightBoxLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private highlightCharacterBoxLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private highlightOtherLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private pageAreaHigtlightColorLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private columnHigtlightColorLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private rowHigtlightColorLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private boxHigtlightColorLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private characterBoxHigtlightColorLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private otherHigtlightColorLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private lbResult As DevExpress.XtraEditors.ListBoxControl

        Private hitTestResultLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private lbResultLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private nwindDataSet1 As DevExpress.XtraRichEdit.Demos.nwindDataSet
    End Class
End Namespace
