namespace DevExpress.XtraEditors.Demos {
    partial class ModuleTokenEdit {
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
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMovieTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRelease = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colCountries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rightPanel = new DevExpress.XtraEditors.SidePanel();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tokenEditProducers = new DevExpress.XtraEditors.TokenEdit();
            this.tokenEditGenres = new DevExpress.XtraEditors.TokenEdit();
            this.tokenEditCountries = new DevExpress.XtraEditors.TokenEdit();
            this.ClearFilter = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.topPanel = new DevExpress.XtraEditors.SidePanel();
            this.filterPanel = new DevExpress.XtraEditors.FilterPanelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEditProducers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEditGenres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEditCountries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(DevExpress.XtraEditors.Demos.Data.MoviesData.Movie);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.movieBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 40);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.gridControl.Size = new System.Drawing.Size(603, 512);
            this.gridControl.TabIndex = 14;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMovieTitle,
            this.colRelease,
            this.colCountries,
            this.colProducers,
            this.colGenres});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView.OptionsEditForm.EditFormColumnCount = 7;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.EditFormPrepared += new DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventHandler(this.gridView_EditFormPrepared);
            this.gridView.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView_CustomRowCellEditForEditing);
            this.gridView.ColumnFilterChanged += new System.EventHandler(this.GridView_ColumnFilterChanged);
            // 
            // colMovieTitle
            // 
            this.colMovieTitle.Caption = "Movie";
            this.colMovieTitle.FieldName = "MovieTitle";
            this.colMovieTitle.Name = "colMovieTitle";
            this.colMovieTitle.OptionsEditForm.ColumnSpan = 7;
            this.colMovieTitle.OptionsEditForm.UseEditorColRowSpan = false;
            this.colMovieTitle.OptionsFilter.AllowFilter = false;
            this.colMovieTitle.Visible = true;
            this.colMovieTitle.VisibleIndex = 0;
            // 
            // colRelease
            // 
            this.colRelease.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colRelease.FieldName = "Release";
            this.colRelease.Name = "colRelease";
            this.colRelease.OptionsEditForm.UseEditorColRowSpan = false;
            this.colRelease.OptionsEditForm.VisibleIndex = 4;
            this.colRelease.OptionsFilter.AllowFilter = false;
            this.colRelease.Visible = true;
            this.colRelease.VisibleIndex = 1;
            this.colRelease.Width = 25;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "\\d\\d\\d\\d";
            this.repositoryItemSpinEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colCountries
            // 
            this.colCountries.FieldName = "Countries";
            this.colCountries.Name = "colCountries";
            this.colCountries.OptionsEditForm.ColumnSpan = 6;
            this.colCountries.OptionsEditForm.UseEditorColRowSpan = false;
            this.colCountries.OptionsEditForm.VisibleIndex = 3;
            this.colCountries.OptionsFilter.AllowFilter = false;
            this.colCountries.Visible = true;
            this.colCountries.VisibleIndex = 3;
            this.colCountries.Width = 45;
            // 
            // colProducers
            // 
            this.colProducers.FieldName = "Producers";
            this.colProducers.Name = "colProducers";
            this.colProducers.OptionsEditForm.ColumnSpan = 7;
            this.colProducers.OptionsEditForm.StartNewRow = true;
            this.colProducers.OptionsEditForm.UseEditorColRowSpan = false;
            this.colProducers.OptionsEditForm.VisibleIndex = 1;
            this.colProducers.OptionsFilter.AllowFilter = false;
            this.colProducers.Visible = true;
            this.colProducers.VisibleIndex = 2;
            // 
            // colGenres
            // 
            this.colGenres.FieldName = "Genres";
            this.colGenres.Name = "colGenres";
            this.colGenres.OptionsEditForm.ColumnSpan = 7;
            this.colGenres.OptionsEditForm.UseEditorColRowSpan = false;
            this.colGenres.OptionsEditForm.VisibleIndex = 2;
            this.colGenres.OptionsFilter.AllowFilter = false;
            this.colGenres.Visible = true;
            this.colGenres.VisibleIndex = 4;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.navigationPane1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(603, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(320, 552);
            this.rightPanel.TabIndex = 13;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(1, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(319, 552);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(319, 552);
            this.navigationPane1.TabIndex = 9;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Filter";
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(319, 519);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.tokenEditProducers);
            this.layoutControl1.Controls.Add(this.tokenEditGenres);
            this.layoutControl1.Controls.Add(this.tokenEditCountries);
            this.layoutControl1.Controls.Add(this.ClearFilter);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1284, 203, 450, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(319, 519);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tokenEditProducers
            // 
            this.tokenEditProducers.Location = new System.Drawing.Point(12, 128);
            this.tokenEditProducers.Name = "tokenEditProducers";
            this.tokenEditProducers.Properties.NullText = "Type here";
            this.tokenEditProducers.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenEditProducers.Size = new System.Drawing.Size(295, 20);
            this.tokenEditProducers.StyleController = this.layoutControl1;
            this.tokenEditProducers.TabIndex = 6;
            this.tokenEditProducers.EditValueChanged += new System.EventHandler(this.tokenEditProducers_EditValueChanged);
            // 
            // tokenEditGenres
            // 
            this.tokenEditGenres.Location = new System.Drawing.Point(12, 78);
            this.tokenEditGenres.Name = "tokenEditGenres";
            this.tokenEditGenres.Properties.EditValueType = DevExpress.XtraEditors.TokenEditValueType.Enum;
            this.tokenEditGenres.Properties.NullText = "Type here";
            this.tokenEditGenres.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenEditGenres.Size = new System.Drawing.Size(295, 20);
            this.tokenEditGenres.StyleController = this.layoutControl1;
            this.tokenEditGenres.TabIndex = 5;
            this.tokenEditGenres.EditValueChanged += new System.EventHandler(this.tokenEditGenres_EditValueChanged);
            // 
            // tokenEditCountries
            // 
            this.tokenEditCountries.Location = new System.Drawing.Point(12, 28);
            this.tokenEditCountries.Name = "tokenEditCountries";
            this.tokenEditCountries.Properties.NullText = "Type here";
            this.tokenEditCountries.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenEditCountries.Size = new System.Drawing.Size(295, 20);
            this.tokenEditCountries.StyleController = this.layoutControl1;
            this.tokenEditCountries.TabIndex = 4;
            this.tokenEditCountries.EditValueChanged += new System.EventHandler(this.tokenEditCountries_EditValueChanged);
            // 
            // ClearFilter
            // 
            this.ClearFilter.Location = new System.Drawing.Point(209, 485);
            this.ClearFilter.Name = "ClearFilter";
            this.ClearFilter.Size = new System.Drawing.Size(98, 22);
            this.ClearFilter.StyleController = this.layoutControl1;
            this.ClearFilter.TabIndex = 7;
            this.ClearFilter.Text = "Clear";
            this.ClearFilter.Click += new System.EventHandler(this.ClearFilter_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(319, 519);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(319, 519);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Visibility";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tokenEditCountries;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(299, 40);
            this.layoutControlItem2.Text = "Countries";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tokenEditGenres;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(299, 40);
            this.layoutControlItem3.Text = "Genres";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tokenEditProducers;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(299, 40);
            this.layoutControlItem4.Text = "Producers";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ClearFilter;
            this.layoutControlItem1.Location = new System.Drawing.Point(197, 473);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(102, 26);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 140);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(299, 333);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 473);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(197, 26);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 40);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(299, 10);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 90);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(299, 10);
            // 
            // topPanel
            // 
            this.topPanel.AllowResize = false;
            this.topPanel.AllowSnap = false;
            this.topPanel.Controls.Add(this.filterPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.topPanel.Size = new System.Drawing.Size(603, 40);
            this.topPanel.TabIndex = 15;
            this.topPanel.Visible = false;
            // 
            // filterPanel
            // 
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPanel.Location = new System.Drawing.Point(12, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(579, 39);
            this.filterPanel.TabIndex = 0;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 135);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(299, 419);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 267);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(299, 327);
            // 
            // ModuleTokenEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Name = "ModuleTokenEdit";
            this.Size = new System.Drawing.Size(923, 552);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tokenEditProducers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEditGenres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEditCountries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource movieBindingSource;
        private XtraGrid.GridControl gridControl;
        private XtraGrid.Views.Grid.GridView gridView;
        private XtraGrid.Columns.GridColumn colMovieTitle;
        private XtraGrid.Columns.GridColumn colRelease;
        private XtraGrid.Columns.GridColumn colGenres;
        private XtraGrid.Columns.GridColumn colProducers;
        private XtraGrid.Columns.GridColumn colCountries;
        private SidePanel rightPanel;
        private SidePanel topPanel;
        private FilterPanelControl filterPanel;
        private Utils.Behaviors.BehaviorManager behaviorManager1;
        private XtraLayout.EmptySpaceItem emptySpaceItem6;
        private Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private XtraBars.Navigation.TabPane navigationPane1;
        private XtraBars.Navigation.TabNavigationPage navigationPage1;
        private XtraLayout.LayoutControl layoutControl1;
        private TokenEdit tokenEditProducers;
        private TokenEdit tokenEditGenres;
        private TokenEdit tokenEditCountries;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private SimpleButton ClearFilter;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem4;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem5;
        private XtraLayout.EmptySpaceItem emptySpaceItem7;
    }
}
