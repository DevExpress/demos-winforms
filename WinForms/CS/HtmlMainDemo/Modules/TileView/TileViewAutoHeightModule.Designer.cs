namespace DevExpress.HTML.Demos {
    partial class TileViewAutoHeightModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileViewAutoHeightModule));
            this.tileViewTemplateCodeViewer1 = new DevExpress.HTML.Demos.TileViewTemplateCodeViewer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colEmployee = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPriority = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPriorityName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileViewTemplateCodeViewer1
            // 
            this.tileViewTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileViewTemplateCodeViewer1.Location = new System.Drawing.Point(1, 0);
            this.tileViewTemplateCodeViewer1.Name = "tileViewTemplateCodeViewer1";
            this.tileViewTemplateCodeViewer1.Size = new System.Drawing.Size(476, 432);
            this.tileViewTemplateCodeViewer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(452, 432);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ToolTipController = this.toolTipController1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription,
            this.colEmployee,
            this.colStatus,
            this.colDueDate,
            this.colPriority,
            this.colPriorityName});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsBehavior.AllowSmoothScrolling = true;
            this.tileView1.OptionsHtmlTemplate.ItemAutoHeight = true;
            this.tileView1.OptionsTiles.ColumnCount = 1;
            this.tileView1.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None;
            this.tileView1.OptionsTiles.IndentBetweenItems = 4;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(420, 120);
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tileView1.TileHtmlTemplate.Styles = resources.GetString("tileView1.TileHtmlTemplate.Styles");
            this.tileView1.TileHtmlTemplate.Tag = "Tile Template";
            this.tileView1.TileHtmlTemplate.Template = resources.GetString("tileView1.TileHtmlTemplate.Template");
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colEmployee
            // 
            this.colEmployee.Caption = "Employee";
            this.colEmployee.FieldName = "Employee";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "DueDate";
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 4;
            // 
            // colPriority
            // 
            this.colPriority.Caption = "Priority";
            this.colPriority.FieldName = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.Visible = true;
            this.colPriority.VisibleIndex = 5;
            // 
            // colPriorityName
            // 
            this.colPriorityName.Caption = "PriorityName";
            this.colPriorityName.FieldName = "PriorityName";
            this.colPriorityName.Name = "colPriorityName";
            this.colPriorityName.Visible = true;
            this.colPriorityName.VisibleIndex = 6;
            // 
            // toolTipController1
            // 
            this.toolTipController1.HtmlTemplate.Styles = ".tip {\r\n\tbackground-color: @Window;\r\n\tcolor: @WindowText;\r\n\tbox-shadow: 0px 1px 3" +
    "px 0px @Black;\r\n\tpadding: 6px;\r\n\tborder-radius: 6px;\r\n}\r\n.container {\r\n\tpadding:" +
    " 5px;\r\n}";
            this.toolTipController1.HtmlTemplate.Template = "<div class=\"container\">\r\n\t<div class=\"tip\">${ToolTip}</div>\r\n</div>\r\n";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tileViewTemplateCodeViewer1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(452, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(477, 432);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // alertControl1
            // 
            this.alertControl1.AutoFormDelay = 2000;
            this.alertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            this.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopLeft;
            this.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.Reveal;
            this.alertControl1.HtmlTemplate.Styles = resources.GetString("alertControl1.HtmlTemplate.Styles");
            this.alertControl1.HtmlTemplate.Template = "<div class=\"container\">\r\n    <div class=\"shadow\">${Text}</div>\r\n</div>";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("copy", "image://svgimages/edit/copy.svg");
            // 
            // TileViewAutoHeightModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "TileViewAutoHeightModule";
            this.Size = new System.Drawing.Size(929, 432);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TileViewTemplateCodeViewer tileViewTemplateCodeViewer1;
        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Tile.TileView tileView1;
        private XtraGrid.Columns.TileViewColumn colName;
        private XtraGrid.Columns.TileViewColumn colDescription;
        private XtraGrid.Columns.TileViewColumn colEmployee;
        private XtraGrid.Columns.TileViewColumn colStatus;
        private XtraGrid.Columns.TileViewColumn colDueDate;
        private XtraGrid.Columns.TileViewColumn colPriority;
        private XtraEditors.SidePanel sidePanel1;
        private XtraGrid.Columns.TileViewColumn colPriorityName;
        private XtraBars.Alerter.AlertControl alertControl1;
        private Utils.ToolTipController toolTipController1;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
