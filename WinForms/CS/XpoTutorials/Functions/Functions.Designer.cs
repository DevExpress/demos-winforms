namespace DevExpress.Xpo.Demos {
    partial class Functions {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gclGetYearGroup = new DevExpress.XtraGrid.GridControl();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHomePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitleOfCourtesy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBirthYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpGetYear = new DevExpress.XtraTab.XtraTabPage();
            this.xtpMathematic = new DevExpress.XtraTab.XtraTabPage();
            this.gclMathematic = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtpText = new DevExpress.XtraTab.XtraTabPage();
            this.gclStrings = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtpCustom = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gclCustomInMemory = new DevExpress.XtraGrid.GridControl();
            this.gvlCustomInMemory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gclCustomQuery = new DevExpress.XtraGrid.GridControl();
            this.gvlCustomQuery = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gclGetYearGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpGetYear.SuspendLayout();
            this.xtpMathematic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclMathematic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtpText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclStrings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtpCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclCustomInMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlCustomInMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclCustomQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlCustomQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gclGetYearGroup
            // 
            this.gclGetYearGroup.DataSource = this.xpCollection1;
            this.gclGetYearGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclGetYearGroup.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gclGetYearGroup.Location = new System.Drawing.Point(0, 0);
            this.gclGetYearGroup.MainView = this.gridView1;
            this.gclGetYearGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gclGetYearGroup.Name = "gclGetYearGroup";
            this.gclGetYearGroup.Size = new System.Drawing.Size(1015, 679);
            this.gclGetYearGroup.TabIndex = 7;
            this.gclGetYearGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(DevExpress.Xpo.Demos.Functions.Employees);
            this.xpCollection1.Session = this.session1;
            // 
            // session1
            // 
            this.session1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.session1.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colBirthDate,
            this.colHomePhone,
            this.colNotes,
            this.colTitle,
            this.colTitleOfCourtesy,
            this.gcBirthYear});
            this.gridView1.GridControl = this.gclGetYearGroup;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcBirthYear, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 3;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 0;
            // 
            // colHomePhone
            // 
            this.colHomePhone.FieldName = "HomePhone";
            this.colHomePhone.Name = "colHomePhone";
            this.colHomePhone.Visible = true;
            this.colHomePhone.VisibleIndex = 2;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 4;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 5;
            // 
            // colTitleOfCourtesy
            // 
            this.colTitleOfCourtesy.FieldName = "TitleOfCourtesy";
            this.colTitleOfCourtesy.Name = "colTitleOfCourtesy";
            this.colTitleOfCourtesy.Visible = true;
            this.colTitleOfCourtesy.VisibleIndex = 6;
            // 
            // gcBirthYear
            // 
            this.gcBirthYear.Caption = "BirthYear";
            this.gcBirthYear.FieldName = "BirthYear";
            this.gcBirthYear.Name = "gcBirthYear";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtpGetYear;
            this.xtraTabControl1.Size = new System.Drawing.Size(1045, 685);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpGetYear,
            this.xtpMathematic,
            this.xtpText,
            this.xtpCustom});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xtpGetYear
            // 
            this.xtpGetYear.Controls.Add(this.gclGetYearGroup);
            this.xtpGetYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtpGetYear.Name = "xtpGetYear";
            this.xtpGetYear.Size = new System.Drawing.Size(1015, 679);
            this.xtpGetYear.Text = "Datetime";
            // 
            // xtpMathematic
            // 
            this.xtpMathematic.Controls.Add(this.gclMathematic);
            this.xtpMathematic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtpMathematic.Name = "xtpMathematic";
            this.xtpMathematic.Size = new System.Drawing.Size(1015, 679);
            this.xtpMathematic.Text = "Mathematic";
            // 
            // gclMathematic
            // 
            this.gclMathematic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclMathematic.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gclMathematic.Location = new System.Drawing.Point(0, 0);
            this.gclMathematic.MainView = this.gridView2;
            this.gclMathematic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gclMathematic.Name = "gclMathematic";
            this.gclMathematic.Size = new System.Drawing.Size(1015, 679);
            this.gclMathematic.TabIndex = 0;
            this.gclMathematic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gclMathematic;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            // 
            // xtpText
            // 
            this.xtpText.Controls.Add(this.gclStrings);
            this.xtpText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtpText.Name = "xtpText";
            this.xtpText.Size = new System.Drawing.Size(1015, 679);
            this.xtpText.Text = "String";
            // 
            // gclStrings
            // 
            this.gclStrings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclStrings.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gclStrings.Location = new System.Drawing.Point(0, 0);
            this.gclStrings.MainView = this.gridView3;
            this.gclStrings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gclStrings.Name = "gclStrings";
            this.gclStrings.Size = new System.Drawing.Size(1015, 679);
            this.gclStrings.TabIndex = 0;
            this.gclStrings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gclStrings;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsBehavior.ReadOnly = true;
            // 
            // xtpCustom
            // 
            this.xtpCustom.Controls.Add(this.splitContainerControl1);
            this.xtpCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtpCustom.Name = "xtpCustom";
            this.xtpCustom.Size = new System.Drawing.Size(1015, 679);
            this.xtpCustom.Text = "Custom Functions Everywhere*";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gclCustomInMemory);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gclCustomQuery);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1015, 679);
            this.splitContainerControl1.SplitterPosition = 336;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            this.splitContainerControl1.Resize += new System.EventHandler(this.splitContainerControl1_Resize);
            // 
            // gclCustomInMemory
            // 
            this.gclCustomInMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclCustomInMemory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gclCustomInMemory.Location = new System.Drawing.Point(0, 43);
            this.gclCustomInMemory.MainView = this.gvlCustomInMemory;
            this.gclCustomInMemory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gclCustomInMemory.Name = "gclCustomInMemory";
            this.gclCustomInMemory.Size = new System.Drawing.Size(450, 636);
            this.gclCustomInMemory.TabIndex = 1;
            this.gclCustomInMemory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlCustomInMemory});
            // 
            // gvlCustomInMemory
            // 
            this.gvlCustomInMemory.GridControl = this.gclCustomInMemory;
            this.gvlCustomInMemory.Name = "gvlCustomInMemory";
            this.gvlCustomInMemory.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvlCustomInMemory.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvlCustomInMemory.OptionsBehavior.Editable = false;
            this.gvlCustomInMemory.OptionsBehavior.ReadOnly = true;
            this.gvlCustomInMemory.OptionsView.ShowGroupPanel = false;
            this.gvlCustomInMemory.TopRowChanged += new System.EventHandler(this.gridView4_TopRowChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(450, 43);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(21, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(152, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "In Memory Evaluation";
            // 
            // gclCustomQuery
            // 
            this.gclCustomQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclCustomQuery.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gclCustomQuery.Location = new System.Drawing.Point(0, 43);
            this.gclCustomQuery.MainView = this.gvlCustomQuery;
            this.gclCustomQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gclCustomQuery.Name = "gclCustomQuery";
            this.gclCustomQuery.Size = new System.Drawing.Size(560, 636);
            this.gclCustomQuery.TabIndex = 2;
            this.gclCustomQuery.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlCustomQuery});
            // 
            // gvlCustomQuery
            // 
            this.gvlCustomQuery.GridControl = this.gclCustomQuery;
            this.gvlCustomQuery.Name = "gvlCustomQuery";
            this.gvlCustomQuery.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvlCustomQuery.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvlCustomQuery.OptionsBehavior.Editable = false;
            this.gvlCustomQuery.OptionsBehavior.ReadOnly = true;
            this.gvlCustomQuery.OptionsView.ShowGroupPanel = false;
            this.gvlCustomQuery.TopRowChanged += new System.EventHandler(this.gridView5_TopRowChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(560, 43);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(32, 13);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Database Query";
            // 
            // Functions
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Functions";
            this.Size = new System.Drawing.Size(1045, 685);
            ((System.ComponentModel.ISupportInitialize)(this.gclGetYearGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtpGetYear.ResumeLayout(false);
            this.xtpMathematic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclMathematic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtpText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclStrings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtpCustom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclCustomInMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlCustomInMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclCustomQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlCustomQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gclGetYearGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private XPCollection xpCollection1;
        private Session session1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colHomePhone;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colTitleOfCourtesy;
        private DevExpress.XtraGrid.Columns.GridColumn gcBirthYear;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtpGetYear;
        private DevExpress.XtraTab.XtraTabPage xtpMathematic;
        private DevExpress.XtraGrid.GridControl gclMathematic;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtpText;
        private DevExpress.XtraGrid.GridControl gclStrings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabPage xtpCustom;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gclCustomInMemory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlCustomInMemory;
        private DevExpress.XtraGrid.GridControl gclCustomQuery;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlCustomQuery;
    }
}
