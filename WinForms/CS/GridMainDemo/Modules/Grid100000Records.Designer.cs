namespace DevExpress.XtraGrid.Demos {
    partial class Grid100000Records {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grid100000Records));
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty1 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty2 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty3 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty4 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty5 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty6 = new DevExpress.Data.UnboundSourceProperty();
            this.colclnCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.unboundSource = new DevExpress.Data.UnboundSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclnWord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclnBool = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclnText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.ceCustom = new DevExpress.XtraEditors.CheckEdit();
            this.ceRecord3 = new DevExpress.XtraEditors.CheckEdit();
            this.ceRecord2 = new DevExpress.XtraEditors.CheckEdit();
            this.ceRecord1 = new DevExpress.XtraEditors.CheckEdit();
            this.seCustomRecordsCount = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRecord3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRecord2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRecord1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCustomRecordsCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // colclnCurrency
            // 
            resources.ApplyResources(this.colclnCurrency, "colclnCurrency");
            this.colclnCurrency.ColumnEdit = this.repositoryItemTextEdit1;
            this.colclnCurrency.FieldName = "Currency";
            this.colclnCurrency.Name = "colclnCurrency";
            this.colclnCurrency.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colclnCurrency.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemTextEdit1
            // 
            resources.ApplyResources(this.repositoryItemTextEdit1, "repositoryItemTextEdit1");
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "c";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "c";
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.unboundSource;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // unboundSource
            // 
            unboundSourceProperty1.DisplayName = null;
            unboundSourceProperty1.Name = "Id";
            unboundSourceProperty1.PropertyType = typeof(int);
            unboundSourceProperty2.DisplayName = null;
            unboundSourceProperty2.Name = "Word";
            unboundSourceProperty2.PropertyType = typeof(string);
            unboundSourceProperty3.DisplayName = null;
            unboundSourceProperty3.Name = "Text";
            unboundSourceProperty3.PropertyType = typeof(string);
            unboundSourceProperty4.DisplayName = null;
            unboundSourceProperty4.Name = "Date";
            unboundSourceProperty4.PropertyType = typeof(System.DateTime);
            unboundSourceProperty5.DisplayName = null;
            unboundSourceProperty5.Name = "Currency";
            unboundSourceProperty5.PropertyType = typeof(decimal);
            unboundSourceProperty6.DisplayName = null;
            unboundSourceProperty6.Name = "Bool";
            unboundSourceProperty6.PropertyType = typeof(bool);
            this.unboundSource.Properties.Add(unboundSourceProperty1);
            this.unboundSource.Properties.Add(unboundSourceProperty2);
            this.unboundSource.Properties.Add(unboundSourceProperty3);
            this.unboundSource.Properties.Add(unboundSourceProperty4);
            this.unboundSource.Properties.Add(unboundSourceProperty5);
            this.unboundSource.Properties.Add(unboundSourceProperty6);
            this.unboundSource.ValueNeeded += new System.EventHandler<DevExpress.Data.UnboundSourceValueNeededEventArgs>(this.unboundSource_ValueNeeded);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colclnId,
            this.colclnDate,
            this.colclnWord,
            this.colclnBool,
            this.colclnText,
            this.colclnCurrency});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3"))});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsView.BestFitMaxRowCount = 20;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colclnId
            // 
            resources.ApplyResources(this.colclnId, "colclnId");
            this.colclnId.FieldName = "Id";
            this.colclnId.Name = "colclnId";
            this.colclnId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colclnId.OptionsColumn.ReadOnly = true;
            this.colclnId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colclnId.Summary"))), resources.GetString("colclnId.Summary1"), resources.GetString("colclnId.Summary2"))});
            // 
            // colclnDate
            // 
            resources.ApplyResources(this.colclnDate, "colclnDate");
            this.colclnDate.FieldName = "Date";
            this.colclnDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Date;
            this.colclnDate.Name = "colclnDate";
            this.colclnDate.OptionsColumn.ReadOnly = true;
            // 
            // colclnWord
            // 
            resources.ApplyResources(this.colclnWord, "colclnWord");
            this.colclnWord.FieldName = "Word";
            this.colclnWord.Name = "colclnWord";
            this.colclnWord.OptionsColumn.ReadOnly = true;
            // 
            // colclnBool
            // 
            resources.ApplyResources(this.colclnBool, "colclnBool");
            this.colclnBool.FieldName = "Bool";
            this.colclnBool.Name = "colclnBool";
            this.colclnBool.OptionsColumn.ReadOnly = true;
            // 
            // colclnText
            // 
            resources.ApplyResources(this.colclnText, "colclnText");
            this.colclnText.FieldName = "Text";
            this.colclnText.Name = "colclnText";
            this.colclnText.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colclnText.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colclnText.OptionsColumn.ReadOnly = true;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.navigationPane1);
            resources.ApplyResources(this.sidePanel1, "sidePanel1");
            this.sidePanel1.Name = "sidePanel1";
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            resources.ApplyResources(this.navigationPane1, "navigationPane1");
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(249, 464);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            // 
            // navigationPage1
            // 
            resources.ApplyResources(this.navigationPage1, "navigationPage1");
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.Name = "navigationPage1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.sbGenerate);
            this.layoutControl1.Controls.Add(this.ceCustom);
            this.layoutControl1.Controls.Add(this.ceRecord3);
            this.layoutControl1.Controls.Add(this.ceRecord2);
            this.layoutControl1.Controls.Add(this.ceRecord1);
            this.layoutControl1.Controls.Add(this.seCustomRecordsCount);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(880, 335, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // sbGenerate
            // 
            resources.ApplyResources(this.sbGenerate, "sbGenerate");
            this.sbGenerate.Name = "sbGenerate";
            this.sbGenerate.StyleController = this.layoutControl1;
            this.sbGenerate.Click += new System.EventHandler(this.sbGenerate_Click);
            // 
            // ceCustom
            // 
            resources.ApplyResources(this.ceCustom, "ceCustom");
            this.ceCustom.Name = "ceCustom";
            this.ceCustom.Properties.Caption = resources.GetString("ceCustom.Properties.Caption");
            this.ceCustom.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.ceCustom.Properties.RadioGroupIndex = 0;
            this.ceCustom.StyleController = this.layoutControl1;
            this.ceCustom.TabStop = false;
            this.ceCustom.CheckedChanged += new System.EventHandler(this.ceRecord_CheckedChanged);
            // 
            // ceRecord3
            // 
            resources.ApplyResources(this.ceRecord3, "ceRecord3");
            this.ceRecord3.Name = "ceRecord3";
            this.ceRecord3.Properties.Caption = resources.GetString("ceRecord3.Properties.Caption");
            this.ceRecord3.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.ceRecord3.Properties.RadioGroupIndex = 0;
            this.ceRecord3.StyleController = this.layoutControl1;
            this.ceRecord3.TabStop = false;
            this.ceRecord3.CheckedChanged += new System.EventHandler(this.ceRecord_CheckedChanged);
            // 
            // ceRecord2
            // 
            resources.ApplyResources(this.ceRecord2, "ceRecord2");
            this.ceRecord2.Name = "ceRecord2";
            this.ceRecord2.Properties.Caption = resources.GetString("ceRecord2.Properties.Caption");
            this.ceRecord2.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.ceRecord2.Properties.RadioGroupIndex = 0;
            this.ceRecord2.StyleController = this.layoutControl1;
            this.ceRecord2.TabStop = false;
            this.ceRecord2.CheckedChanged += new System.EventHandler(this.ceRecord_CheckedChanged);
            // 
            // ceRecord1
            // 
            resources.ApplyResources(this.ceRecord1, "ceRecord1");
            this.ceRecord1.Name = "ceRecord1";
            this.ceRecord1.Properties.Caption = resources.GetString("ceRecord1.Properties.Caption");
            this.ceRecord1.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.ceRecord1.Properties.RadioGroupIndex = 0;
            this.ceRecord1.StyleController = this.layoutControl1;
            this.ceRecord1.CheckedChanged += new System.EventHandler(this.ceRecord_CheckedChanged);
            // 
            // seCustomRecordsCount
            // 
            resources.ApplyResources(this.seCustomRecordsCount, "seCustomRecordsCount");
            this.seCustomRecordsCount.Name = "seCustomRecordsCount";
            this.seCustomRecordsCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("seCustomRecordsCount.Properties.Buttons"))))});
            this.seCustomRecordsCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seCustomRecordsCount.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seCustomRecordsCount.Properties.IsFloatValue = false;
            this.seCustomRecordsCount.Properties.Mask.EditMask = resources.GetString("seCustomRecordsCount.Properties.Mask.EditMask");
            this.seCustomRecordsCount.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("seCustomRecordsCount.Properties.Mask.UseMaskAsDisplayFormat")));
            this.seCustomRecordsCount.Properties.MaxValue = new decimal(new int[] {
            7000000,
            0,
            0,
            0});
            this.seCustomRecordsCount.StyleController = this.layoutControl1;
            this.seCustomRecordsCount.EditValueChanged += new System.EventHandler(this.seCustomRecordsCount_EditValueChanged);
            this.seCustomRecordsCount.Enter += new System.EventHandler(this.seCustomRecordsCount_Enter);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(249, 431);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 122);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(239, 309);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ceRecord1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ceRecord2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceRecord3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceCustom;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.seCustomRecordsCount;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(160, 26);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sbGenerate;
            this.layoutControlItem6.Location = new System.Drawing.Point(160, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 10, 2, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(79, 26);
            this.layoutControlItem6.TextVisible = false;
            // 
            // Grid100000Records
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "Grid100000Records";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceCustom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRecord3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRecord2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRecord1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCustomRecordsCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colclnId;
        private DevExpress.XtraGrid.Columns.GridColumn colclnWord;
        private DevExpress.XtraGrid.Columns.GridColumn colclnText;
        private DevExpress.XtraGrid.Columns.GridColumn colclnDate;
        private DevExpress.XtraGrid.Columns.GridColumn colclnCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colclnBool;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.Data.UnboundSource unboundSource;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane navigationPane1;
        private XtraBars.Navigation.TabNavigationPage navigationPage1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraEditors.CheckEdit ceCustom;
        private XtraEditors.CheckEdit ceRecord3;
        private XtraEditors.CheckEdit ceRecord2;
        private XtraEditors.CheckEdit ceRecord1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraEditors.SpinEdit seCustomRecordsCount;
        private XtraEditors.SimpleButton sbGenerate;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
