namespace DevExpress.XtraRichEdit.Demos {
    partial class CustomDrawModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.displayForReviewModeComboBox1 = new DevExpress.XtraRichEdit.UI.DisplayForReviewModeComboBox();
            this.repositoryItemBorderLineStyle1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle();
            this.repositoryItemBorderLineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight();
            this.repositoryItemFloatingObjectOutlineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight();
            this.hitTestPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.hitTestPanelLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.searchText = new DevExpress.XtraEditors.LabelControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.findWholeWordsOnly = new DevExpress.XtraEditors.CheckEdit();
            this.matchCase = new DevExpress.XtraEditors.CheckEdit();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchPanelLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchOptionsLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.matchCaseControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchTextBox = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.searchResultAndButtonsGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationButtonsEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayForReviewModeComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineStyle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFloatingObjectOutlineWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitTestPanelControl)).BeginInit();
            this.hitTestPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hitTestPanelLayoutControl)).BeginInit();
            this.hitTestPanelLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findWholeWordsOnly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchCase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPanelLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOptionsLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchCaseControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultAndButtonsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationButtonsEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl
            // 
            this.richEditControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richEditControl.Location = new System.Drawing.Point(0, 0);
            this.richEditControl.Margin = new System.Windows.Forms.Padding(0);
            this.richEditControl.MenuManager = this.ribbonControl1;
            this.richEditControl.Name = "richEditControl";
            this.richEditControl.Size = new System.Drawing.Size(1013, 608);
            this.richEditControl.TabIndex = 13;
            this.richEditControl.ContentChanged += new System.EventHandler(this.richEditControl_ContentChanged);
            this.richEditControl.BeforePagePaint += new DevExpress.XtraRichEdit.BeforePagePaintEventHandler(this.richEditControl_BeforePagePaint);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 270;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemRichEditFontSizeEdit1,
            this.displayForReviewModeComboBox1,
            this.repositoryItemBorderLineStyle1,
            this.repositoryItemBorderLineWeight1,
            this.repositoryItemFloatingObjectOutlineWeight1});
            this.ribbonControl1.Size = new System.Drawing.Size(1296, 50);
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // repositoryItemRichEditFontSizeEdit1
            // 
            this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditFontSizeEdit1.Control = this.richEditControl;
            this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            // 
            // displayForReviewModeComboBox1
            // 
            this.displayForReviewModeComboBox1.AutoHeight = false;
            this.displayForReviewModeComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.displayForReviewModeComboBox1.Name = "displayForReviewModeComboBox1";
            this.displayForReviewModeComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemBorderLineStyle1
            // 
            this.repositoryItemBorderLineStyle1.AutoHeight = false;
            this.repositoryItemBorderLineStyle1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBorderLineStyle1.Control = this.richEditControl;
            this.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1";
            // 
            // repositoryItemBorderLineWeight1
            // 
            this.repositoryItemBorderLineWeight1.AutoHeight = false;
            this.repositoryItemBorderLineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBorderLineWeight1.Control = this.richEditControl;
            this.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1";
            // 
            // repositoryItemFloatingObjectOutlineWeight1
            // 
            this.repositoryItemFloatingObjectOutlineWeight1.AutoHeight = false;
            this.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFloatingObjectOutlineWeight1.Control = this.richEditControl;
            this.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1";
            // 
            // hitTestPanelControl
            // 
            this.hitTestPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hitTestPanelControl.Controls.Add(this.hitTestPanelLayoutControl);
            this.hitTestPanelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.hitTestPanelControl.Location = new System.Drawing.Point(1016, 50);
            this.hitTestPanelControl.Name = "hitTestPanelControl";
            this.hitTestPanelControl.Size = new System.Drawing.Size(280, 558);
            this.hitTestPanelControl.TabIndex = 44;
            // 
            // hitTestPanelLayoutControl
            // 
            this.hitTestPanelLayoutControl.Controls.Add(this.searchText);
            this.hitTestPanelLayoutControl.Controls.Add(this.buttonEdit1);
            this.hitTestPanelLayoutControl.Controls.Add(this.findWholeWordsOnly);
            this.hitTestPanelLayoutControl.Controls.Add(this.matchCase);
            this.hitTestPanelLayoutControl.Controls.Add(this.searchControl);
            this.hitTestPanelLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hitTestPanelLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.hitTestPanelLayoutControl.Name = "hitTestPanelLayoutControl";
            this.hitTestPanelLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(260, 196, 650, 400);
            this.hitTestPanelLayoutControl.Root = this.Root;
            this.hitTestPanelLayoutControl.Size = new System.Drawing.Size(280, 558);
            this.hitTestPanelLayoutControl.TabIndex = 0;
            this.hitTestPanelLayoutControl.Text = "layoutControl1";
            // 
            // searchText
            // 
            this.searchText.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.searchText.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.searchText.Location = new System.Drawing.Point(9, 53);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(114, 13);
            this.searchText.StyleController = this.hitTestPanelLayoutControl;
            this.searchText.TabIndex = 36;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(127, 51);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.AllowFocused = false;
            this.buttonEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.buttonEdit1.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.buttonEdit1.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.buttonEdit1.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.buttonEdit1.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.buttonEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Up),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.buttonEdit1.Properties.ReadOnly = true;
            this.buttonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.buttonEdit1.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.navigationButtonEdit_Properties_ButtonClick);
            this.buttonEdit1.Size = new System.Drawing.Size(145, 18);
            this.buttonEdit1.StyleController = this.hitTestPanelLayoutControl;
            this.buttonEdit1.TabIndex = 35;
            this.buttonEdit1.TabStop = false;
            // 
            // findWholeWordsOnly
            // 
            this.findWholeWordsOnly.Location = new System.Drawing.Point(15, 122);
            this.findWholeWordsOnly.Name = "findWholeWordsOnly";
            this.findWholeWordsOnly.Properties.Caption = "Find Whole Words Only";
            this.findWholeWordsOnly.Size = new System.Drawing.Size(251, 20);
            this.findWholeWordsOnly.StyleController = this.hitTestPanelLayoutControl;
            this.findWholeWordsOnly.TabIndex = 28;
            this.findWholeWordsOnly.CheckedChanged += new System.EventHandler(this.OnSearchOptionsChanged);
            // 
            // matchCase
            // 
            this.matchCase.Location = new System.Drawing.Point(15, 98);
            this.matchCase.Name = "matchCase";
            this.matchCase.Properties.Caption = "Match Case";
            this.matchCase.Size = new System.Drawing.Size(251, 20);
            this.matchCase.StyleController = this.hitTestPanelLayoutControl;
            this.matchCase.TabIndex = 27;
            this.matchCase.CheckedChanged += new System.EventHandler(this.OnSearchOptionsChanged);
            // 
            // searchControl
            // 
            this.searchControl.EditValue = "g";
            this.searchControl.Location = new System.Drawing.Point(9, 27);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton()});
            this.searchControl.Properties.NullValuePrompt = " ";
            this.searchControl.Properties.ShowSearchButton = false;
            this.searchControl.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.searchTextBox_Properties_ButtonClick);
            this.searchControl.Size = new System.Drawing.Size(263, 20);
            this.searchControl.StyleController = this.hitTestPanelLayoutControl;
            this.searchControl.TabIndex = 25;
            this.searchControl.EditValueChanged += new System.EventHandler(this.searchTextBox_EditValueChanged);
            this.searchControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchPanelLayoutControlGroup,
            this.simpleSeparator1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(280, 558);
            this.Root.TextVisible = false;
            // 
            // searchPanelLayoutControlGroup
            // 
            this.searchPanelLayoutControlGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.searchPanelLayoutControlGroup.CustomizationFormText = "Search Panel";
            this.searchPanelLayoutControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.searchPanelLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchOptionsLayoutControlGroup,
            this.searchTextBox,
            this.emptySpaceItem1,
            this.searchResultAndButtonsGroup});
            this.searchPanelLayoutControlGroup.Location = new System.Drawing.Point(1, 0);
            this.searchPanelLayoutControlGroup.Name = "searchPanelLayoutControlGroup";
            this.searchPanelLayoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 3, 5);
            this.searchPanelLayoutControlGroup.Size = new System.Drawing.Size(279, 558);
            this.searchPanelLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.searchPanelLayoutControlGroup.Text = "Search Panel";
            // 
            // searchOptionsLayoutControlGroup
            // 
            this.searchOptionsLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.searchOptionsLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.matchCaseControlItem,
            this.layoutControlItem1});
            this.searchOptionsLayoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.searchOptionsLayoutControlGroup.Location = new System.Drawing.Point(0, 46);
            this.searchOptionsLayoutControlGroup.Name = "searchOptionsLayoutControlGroup";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            this.searchOptionsLayoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            this.searchOptionsLayoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.searchOptionsLayoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 3, 3);
            this.searchOptionsLayoutControlGroup.Size = new System.Drawing.Size(267, 77);
            this.searchOptionsLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.searchOptionsLayoutControlGroup.Text = "Search Options";
            // 
            // matchCaseControlItem
            // 
            this.matchCaseControlItem.Control = this.matchCase;
            this.matchCaseControlItem.Location = new System.Drawing.Point(0, 0);
            this.matchCaseControlItem.Name = "matchCaseControlItem";
            this.matchCaseControlItem.Size = new System.Drawing.Size(255, 24);
            this.matchCaseControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.matchCaseControlItem.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.findWholeWordsOnly;
            this.layoutControlItem1.CustomizationFormText = "findWholeWordsOnly";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(255, 24);
            this.layoutControlItem1.Text = "findWholeWordsOnly";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Control = this.searchControl;
            this.searchTextBox.CustomizationFormText = "searchTextBox";
            this.searchTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(267, 24);
            this.searchTextBox.TextSize = new System.Drawing.Size(0, 0);
            this.searchTextBox.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 123);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(267, 405);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // searchResultAndButtonsGroup
            // 
            this.searchResultAndButtonsGroup.CustomizationFormText = "searchResultAndButtonsGroup";
            this.searchResultAndButtonsGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.searchResultAndButtonsGroup.GroupBordersVisible = false;
            this.searchResultAndButtonsGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.navigationButtonsEdit});
            this.searchResultAndButtonsGroup.Location = new System.Drawing.Point(0, 24);
            this.searchResultAndButtonsGroup.Name = "searchResultAndButtonsGroup";
            this.searchResultAndButtonsGroup.Size = new System.Drawing.Size(267, 22);
            this.searchResultAndButtonsGroup.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem2.Control = this.searchText;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(118, 22);
            this.layoutControlItem2.Text = "searchText";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // navigationButtonsEdit
            // 
            this.navigationButtonsEdit.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.navigationButtonsEdit.Control = this.buttonEdit1;
            this.navigationButtonsEdit.CustomizationFormText = "navigationButtonsEdit";
            this.navigationButtonsEdit.Location = new System.Drawing.Point(118, 0);
            this.navigationButtonsEdit.Name = "navigationButtonsEdit";
            this.navigationButtonsEdit.Size = new System.Drawing.Size(149, 22);
            this.navigationButtonsEdit.TextSize = new System.Drawing.Size(0, 0);
            this.navigationButtonsEdit.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.simpleSeparator1.Size = new System.Drawing.Size(1, 558);
            // 
            // CustomDrawModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hitTestPanelControl);
            this.Controls.Add(this.richEditControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "CustomDrawModule";
            this.Size = new System.Drawing.Size(1296, 608);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayForReviewModeComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineStyle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBorderLineWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFloatingObjectOutlineWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitTestPanelControl)).EndInit();
            this.hitTestPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hitTestPanelLayoutControl)).EndInit();
            this.hitTestPanelLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findWholeWordsOnly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchCase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPanelLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchOptionsLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchCaseControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultAndButtonsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationButtonsEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichEditControl richEditControl;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
        private UI.DisplayForReviewModeComboBox displayForReviewModeComboBox1;
        private XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle repositoryItemBorderLineStyle1;
        private XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight repositoryItemBorderLineWeight1;
        private XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight repositoryItemFloatingObjectOutlineWeight1;
        private XtraEditors.PanelControl hitTestPanelControl;
        private XtraLayout.LayoutControl hitTestPanelLayoutControl;
        private XtraEditors.LabelControl searchText;
        private XtraEditors.ButtonEdit buttonEdit1;
        private XtraEditors.CheckEdit findWholeWordsOnly;
        private XtraEditors.CheckEdit matchCase;
        private XtraEditors.SearchControl searchControl;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlGroup searchPanelLayoutControlGroup;
        private XtraLayout.LayoutControlGroup searchOptionsLayoutControlGroup;
        private XtraLayout.LayoutControlItem matchCaseControlItem;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem searchTextBox;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem navigationButtonsEdit;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlGroup searchResultAndButtonsGroup;
        private XtraLayout.SimpleSeparator simpleSeparator1;
    }
}
