namespace DevExpress.XtraTreeList.Demos {
    partial class Bands {
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand3 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand4 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListBand5 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.navigationPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.optionsPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.ucBandOptions1 = new DevExpress.XtraTreeList.Demos.Options.ucBandOptions();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).BeginInit();
            this.navigationPane.SuspendLayout();
            this.optionsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Bands.AddRange(new DevExpress.XtraTreeList.Columns.TreeListBand[] {
            this.treeListBand1,
            this.treeListBand2,
            this.treeListBand5});
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn9,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsBehavior.AutoNodeHeight = false;
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsCustomization.AllowChangeBandParent = true;
            this.treeList1.OptionsCustomization.AllowChangeColumnParent = true;
            this.treeList1.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.treeList1.OptionsCustomization.CustomizationFormSnapMode = ((DevExpress.Utils.Controls.SnapMode)((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm)));
            this.treeList1.OptionsView.AllowBandColumnsMultiRow = true;
            this.treeList1.OptionsView.AllowHtmlDrawHeaders = true;
            this.treeList1.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList1.OptionsView.EnableAppearanceOddRow = true;
            this.treeList1.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.Size = new System.Drawing.Size(546, 432);
            this.treeList1.TabIndex = 16;
            // 
            // treeListBand1
            // 
            this.treeListBand1.Caption = "<b>Main</b>";
            this.treeListBand1.Columns.Add(this.treeListColumn1);
            this.treeListBand1.Columns.Add(this.treeListColumn2);
            this.treeListBand1.Name = "treeListBand1";
            this.treeListBand1.Width = 178;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 90;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Type of object";
            this.treeListColumn2.FieldName = "TypeOfObject";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.RowIndex = 1;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 88;
            // 
            // treeListBand2
            // 
            this.treeListBand2.Bands.AddRange(new DevExpress.XtraTreeList.Columns.TreeListBand[] {
            this.treeListBand3,
            this.treeListBand4});
            this.treeListBand2.Caption = "<b>Details </b>";
            this.treeListBand2.Name = "treeListBand2";
            this.treeListBand2.Width = 536;
            // 
            // treeListBand3
            // 
            this.treeListBand3.Caption = "Absolute Values";
            this.treeListBand3.Columns.Add(this.treeListColumn3);
            this.treeListBand3.Columns.Add(this.treeListColumn4);
            this.treeListBand3.Columns.Add(this.treeListColumn9);
            this.treeListBand3.Name = "treeListBand3";
            this.treeListBand3.Width = 256;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Mean radius";
            this.treeListColumn3.FieldName = "MeanRadiusInKM";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 107;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Volume ";
            this.treeListColumn4.FieldName = "Volume10pow9KM3";
            this.treeListColumn4.Format.FormatString = "f";
            this.treeListColumn4.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            this.treeListColumn4.Width = 88;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "Mass";
            this.treeListColumn9.FieldName = "Mass10pow21kg";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.RowIndex = 1;
            this.treeListColumn9.Visible = true;
            this.treeListColumn9.VisibleIndex = 4;
            this.treeListColumn9.Width = 61;
            // 
            // treeListBand4
            // 
            this.treeListBand4.Caption = "Related To Earth Values";
            this.treeListBand4.Columns.Add(this.treeListColumn5);
            this.treeListBand4.Columns.Add(this.treeListColumn6);
            this.treeListBand4.Columns.Add(this.treeListColumn7);
            this.treeListBand4.Name = "treeListBand4";
            this.treeListBand4.Width = 280;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Mean radius";
            this.treeListColumn5.FieldName = "MeanRadiusByEarth";
            this.treeListColumn5.Format.FormatString = "f";
            this.treeListColumn5.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 5;
            this.treeListColumn5.Width = 102;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Volume ";
            this.treeListColumn6.FieldName = "VolumeRByEarth";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 6;
            this.treeListColumn6.Width = 104;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Mass";
            this.treeListColumn7.FieldName = "MassByEarth";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.RowIndex = 1;
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 7;
            this.treeListColumn7.Width = 74;
            // 
            // treeListBand5
            // 
            this.treeListBand5.Caption = "<b>Picture</b>";
            this.treeListBand5.Columns.Add(this.treeListColumn8);
            this.treeListBand5.MinWidth = 68;
            this.treeListBand5.Name = "treeListBand5";
            this.treeListBand5.OptionsBand.FixedWidth = true;
            this.treeListBand5.Width = 68;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "Icon";
            this.treeListColumn8.FieldName = "ImageData";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.OptionsColumn.FixedWidth = true;
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 8;
            this.treeListColumn8.Width = 68;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.navigationPane);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(546, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(237, 432);
            this.sidePanel1.TabIndex = 17;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // navigationPane
            // 
            this.navigationPane.Controls.Add(this.optionsPage);
            this.navigationPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane.Location = new System.Drawing.Point(1, 0);
            this.navigationPane.Name = "navigationPane";
            this.navigationPane.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.navigationPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.optionsPage});
            this.navigationPane.RegularSize = new System.Drawing.Size(236, 432);
            this.navigationPane.SelectedPage = this.optionsPage;
            this.navigationPane.Size = new System.Drawing.Size(236, 432);
            this.navigationPane.TabIndex = 11;
            this.navigationPane.Text = "navigationPane";
            // 
            // optionsPage
            // 
            this.optionsPage.Caption = "Options";
            this.optionsPage.Controls.Add(this.ucBandOptions1);
            this.optionsPage.Name = "optionsPage";
            this.optionsPage.Size = new System.Drawing.Size(236, 399);
            // 
            // ucBandOptions1
            // 
            this.ucBandOptions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBandOptions1.Location = new System.Drawing.Point(0, 0);
            this.ucBandOptions1.Name = "ucBandOptions1";
            this.ucBandOptions1.Size = new System.Drawing.Size(236, 399);
            this.ucBandOptions1.TabIndex = 0;
            // 
            // Bands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "Bands";
            this.Size = new System.Drawing.Size(783, 432);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).EndInit();
            this.navigationPane.ResumeLayout(false);
            this.optionsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeList treeList1;
        private Columns.TreeListColumn treeListColumn1;
        private Columns.TreeListColumn treeListColumn2;
        private Columns.TreeListColumn treeListColumn3;
        private Columns.TreeListColumn treeListColumn4;
        private Columns.TreeListColumn treeListColumn5;
        private Columns.TreeListColumn treeListColumn6;
        private Columns.TreeListColumn treeListColumn7;
        private Columns.TreeListColumn treeListColumn8;
        private Columns.TreeListColumn treeListColumn9;
        private Columns.TreeListBand treeListBand1;
        private Columns.TreeListBand treeListBand2;
        private Columns.TreeListBand treeListBand3;
        private Columns.TreeListBand treeListBand4;
        private Columns.TreeListBand treeListBand5;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane navigationPane;
        private XtraBars.Navigation.TabNavigationPage optionsPage;
        private Options.ucBandOptions ucBandOptions1;
    }
}
