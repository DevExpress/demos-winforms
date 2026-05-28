namespace DevExpress.XtraTreeList.Demos.Options {
    partial class ucScrollAnnotationsOptions {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cpeFocused = new DevExpress.XtraEditors.ColorPickEdit();
            this.stylesSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpeErrors = new DevExpress.XtraEditors.ColorPickEdit();
            this.cpeSearch = new DevExpress.XtraEditors.ColorPickEdit();
            this.ceFocusedEnabled = new DevExpress.XtraEditors.CheckEdit();
            this.ceErrorsEnabled = new DevExpress.XtraEditors.CheckEdit();
            this.ceBookmarksEnabled = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemForSearch = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemForErrors = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemForFocused = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpeFocused.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpeErrors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpeSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFocusedEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceErrorsEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceBookmarksEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemForSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemForErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemForFocused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.cpeFocused);
            this.layoutControl1.Controls.Add(this.cpeErrors);
            this.layoutControl1.Controls.Add(this.cpeSearch);
            this.layoutControl1.Controls.Add(this.ceFocusedEnabled);
            this.layoutControl1.Controls.Add(this.ceErrorsEnabled);
            this.layoutControl1.Controls.Add(this.ceBookmarksEnabled);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1284, 203, 595, 684);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(238, 462);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cpeFocused
            // 
            this.cpeFocused.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stylesSource, "FocusColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cpeFocused.EditValue = System.Drawing.Color.Empty;
            this.cpeFocused.Location = new System.Drawing.Point(8, 177);
            this.cpeFocused.Name = "cpeFocused";
            this.cpeFocused.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.cpeFocused.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cpeFocused.Size = new System.Drawing.Size(222, 20);
            this.cpeFocused.StyleController = this.layoutControl1;
            this.cpeFocused.TabIndex = 8;
            // 
            // stylesSource
            // 
            this.stylesSource.DataSource = typeof(DevExpress.XtraTreeList.Demos.Options.AnnotationsStyle);
            this.stylesSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.OnAnnotationsStyleChanged);
            // 
            // cpeErrors
            // 
            this.cpeErrors.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stylesSource, "ErrorsColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cpeErrors.EditValue = System.Drawing.Color.Empty;
            this.cpeErrors.Location = new System.Drawing.Point(8, 109);
            this.cpeErrors.Name = "cpeErrors";
            this.cpeErrors.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.cpeErrors.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cpeErrors.Size = new System.Drawing.Size(222, 20);
            this.cpeErrors.StyleController = this.layoutControl1;
            this.cpeErrors.TabIndex = 7;
            // 
            // cpeSearch
            // 
            this.cpeSearch.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stylesSource, "SearchResultsColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cpeSearch.EditValue = System.Drawing.Color.Empty;
            this.cpeSearch.Location = new System.Drawing.Point(8, 41);
            this.cpeSearch.Name = "cpeSearch";
            this.cpeSearch.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.cpeSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cpeSearch.Size = new System.Drawing.Size(222, 20);
            this.cpeSearch.StyleController = this.layoutControl1;
            this.cpeSearch.TabIndex = 6;
            // 
            // ceFocusedEnabled
            // 
            this.ceFocusedEnabled.Location = new System.Drawing.Point(8, 156);
            this.ceFocusedEnabled.Name = "ceFocusedEnabled";
            this.ceFocusedEnabled.Properties.Caption = "Enabled";
            this.ceFocusedEnabled.Size = new System.Drawing.Size(222, 19);
            this.ceFocusedEnabled.StyleController = this.layoutControl1;
            this.ceFocusedEnabled.TabIndex = 5;
            this.ceFocusedEnabled.EditValueChanged += new System.EventHandler(this.OnAnnotationsEnabledChanged);
            // 
            // ceErrorsEnabled
            // 
            this.ceErrorsEnabled.EditValue = true;
            this.ceErrorsEnabled.Location = new System.Drawing.Point(8, 88);
            this.ceErrorsEnabled.Name = "ceErrorsEnabled";
            this.ceErrorsEnabled.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ceErrorsEnabled.Properties.Appearance.Options.UseTextOptions = true;
            this.ceErrorsEnabled.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ceErrorsEnabled.Properties.Caption = "Enabled";
            this.ceErrorsEnabled.Size = new System.Drawing.Size(222, 19);
            this.ceErrorsEnabled.StyleController = this.layoutControl1;
            this.ceErrorsEnabled.TabIndex = 3;
            this.ceErrorsEnabled.EditValueChanged += new System.EventHandler(this.OnAnnotationsEnabledChanged);
            // 
            // ceBookmarksEnabled
            // 
            this.ceBookmarksEnabled.EditValue = true;
            this.ceBookmarksEnabled.Location = new System.Drawing.Point(8, 230);
            this.ceBookmarksEnabled.Name = "ceBookmarksEnabled";
            this.ceBookmarksEnabled.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ceBookmarksEnabled.Properties.Appearance.Options.UseTextOptions = true;
            this.ceBookmarksEnabled.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ceBookmarksEnabled.Properties.Caption = "Enabled";
            this.ceBookmarksEnabled.Size = new System.Drawing.Size(222, 19);
            this.ceBookmarksEnabled.StyleController = this.layoutControl1;
            this.ceBookmarksEnabled.TabIndex = 4;
            this.ceBookmarksEnabled.EditValueChanged += new System.EventHandler(this.OnAnnotationsEnabledChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(238, 462);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 256);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(238, 206);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.simpleLabelItem1,
            this.simpleLabelItem2,
            this.simpleLabelItem3,
            this.layoutControlItem4,
            this.layoutControlItemForSearch,
            this.layoutControlItemForErrors,
            this.layoutControlItemForFocused});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(238, 204);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Annotations";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ceErrorsEnabled;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(224, 21);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AllowHtmlStringInCaption = true;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(224, 15);
            this.simpleLabelItem1.Text = "<b>Search Results";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(84, 13);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.AllowHtmlStringInCaption = true;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 37);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(224, 25);
            this.simpleLabelItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.simpleLabelItem2.Text = "<b>Row Errors";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(84, 13);
            // 
            // simpleLabelItem3
            // 
            this.simpleLabelItem3.AllowHotTrack = false;
            this.simpleLabelItem3.AllowHtmlStringInCaption = true;
            this.simpleLabelItem3.Location = new System.Drawing.Point(0, 105);
            this.simpleLabelItem3.Name = "simpleLabelItem3";
            this.simpleLabelItem3.Size = new System.Drawing.Size(224, 25);
            this.simpleLabelItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.simpleLabelItem3.Text = "<b>Focused Row";
            this.simpleLabelItem3.TextSize = new System.Drawing.Size(84, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceFocusedEnabled;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(224, 21);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItemForSearch
            // 
            this.layoutControlItemForSearch.Control = this.cpeSearch;
            this.layoutControlItemForSearch.Location = new System.Drawing.Point(0, 15);
            this.layoutControlItemForSearch.Name = "layoutControlItemForSearch";
            this.layoutControlItemForSearch.Size = new System.Drawing.Size(224, 22);
            this.layoutControlItemForSearch.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemForSearch.TextVisible = false;
            // 
            // layoutControlItemForErrors
            // 
            this.layoutControlItemForErrors.Control = this.cpeErrors;
            this.layoutControlItemForErrors.Location = new System.Drawing.Point(0, 83);
            this.layoutControlItemForErrors.Name = "layoutControlItemForErrors";
            this.layoutControlItemForErrors.Size = new System.Drawing.Size(224, 22);
            this.layoutControlItemForErrors.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemForErrors.TextVisible = false;
            // 
            // layoutControlItemForFocused
            // 
            this.layoutControlItemForFocused.Control = this.cpeFocused;
            this.layoutControlItemForFocused.Enabled = false;
            this.layoutControlItemForFocused.Location = new System.Drawing.Point(0, 151);
            this.layoutControlItemForFocused.Name = "layoutControlItemForFocused";
            this.layoutControlItemForFocused.Size = new System.Drawing.Size(224, 22);
            this.layoutControlItemForFocused.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemForFocused.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 204);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(238, 52);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Text = "Bookmarks";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceBookmarksEnabled;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(224, 21);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // ucScrollAnnotationsOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucScrollAnnotationsOptions";
            this.Size = new System.Drawing.Size(238, 462);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpeFocused.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpeErrors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpeSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceFocusedEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceErrorsEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceBookmarksEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemForSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemForErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemForFocused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.LayoutControl layoutControl1;
        private XtraEditors.ColorPickEdit cpeFocused;
        private XtraEditors.ColorPickEdit cpeErrors;
        private XtraEditors.ColorPickEdit cpeSearch;
        private XtraEditors.CheckEdit ceFocusedEnabled;
        private XtraEditors.CheckEdit ceErrorsEnabled;
        private XtraEditors.CheckEdit ceBookmarksEnabled;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.SimpleLabelItem simpleLabelItem1;
        private XtraLayout.SimpleLabelItem simpleLabelItem2;
        private XtraLayout.SimpleLabelItem simpleLabelItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItemForSearch;
        private XtraLayout.LayoutControlItem layoutControlItemForErrors;
        private XtraLayout.LayoutControlItem layoutControlItemForFocused;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource stylesSource;
    }
}
