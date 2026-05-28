namespace DevExpress.XtraScheduler.Demos {
    partial class ExportControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportControl));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnExportViaReporting = new DevExpress.XtraEditors.DropDownButton();
            this.btnExportViaiCalendar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.buttonLabelItem = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLabelItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnExportViaReporting);
            this.layoutControl1.Controls.Add(this.btnExportViaiCalendar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(803, 232, 744, 540);
            this.layoutControl1.OptionsView.ControlDefaultMaxSizeCalcMode = DevExpress.XtraLayout.ControlMaxSizeCalcMode.UseControlMaximumSizeIfNotZero;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(307, 595);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnExportViaReporting
            // 
            this.btnExportViaReporting.Appearance.Options.UseTextOptions = true;
            this.btnExportViaReporting.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnExportViaReporting.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg";
            this.btnExportViaReporting.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExportViaReporting.ImageOptions.SvgImage = global::DevExpress.XtraScheduler.Demos.Properties.Resources.Export;
            this.btnExportViaReporting.Location = new System.Drawing.Point(40, 184);
            this.btnExportViaReporting.MaximumSize = new System.Drawing.Size(75, 75);
            this.btnExportViaReporting.MinimumSize = new System.Drawing.Size(75, 75);
            this.btnExportViaReporting.Name = "btnExportViaReporting";
            this.btnExportViaReporting.Size = new System.Drawing.Size(75, 75);
            this.btnExportViaReporting.StyleController = this.layoutControl1;
            this.btnExportViaReporting.TabIndex = 5;
            this.btnExportViaReporting.Click += new System.EventHandler(this.btnExportViaReporting_Click);
            // 
            // btnExportViaiCalendar
            // 
            this.btnExportViaiCalendar.Appearance.Options.UseTextOptions = true;
            this.btnExportViaiCalendar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnExportViaiCalendar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportViaiCalendar.ImageOptions.Image")));
            this.btnExportViaiCalendar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExportViaiCalendar.Location = new System.Drawing.Point(40, 89);
            this.btnExportViaiCalendar.MaximumSize = new System.Drawing.Size(75, 75);
            this.btnExportViaiCalendar.MinimumSize = new System.Drawing.Size(75, 75);
            this.btnExportViaiCalendar.Name = "btnExportViaiCalendar";
            this.btnExportViaiCalendar.Size = new System.Drawing.Size(75, 75);
            this.btnExportViaiCalendar.StyleController = this.layoutControl1;
            this.btnExportViaiCalendar.TabIndex = 4;
            this.btnExportViaiCalendar.Text = "Export To iCalendar";
            this.btnExportViaiCalendar.Click += new System.EventHandler(this.OnBtnExportViaiCalendarClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.buttonLabelItem,
            this.layoutControlItem1,
            this.buttonLabelItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 0, 0, 40);
            this.layoutControlGroup1.Size = new System.Drawing.Size(307, 595);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.MinSize = new System.Drawing.Size(1, 89);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 24);
            this.simpleLabelItem1.Size = new System.Drawing.Size(250, 89);
            this.simpleLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleLabelItem1.Text = "Export";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(224, 65);
            // 
            // buttonLabelItem
            // 
            this.buttonLabelItem.AllowHtmlStringInCaption = true;
            this.buttonLabelItem.AppearanceItemCaption.Options.UseTextOptions = true;
            this.buttonLabelItem.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.buttonLabelItem.CustomizationFormText = "Export appointments to an iCalendar (.ics) file.";
            this.buttonLabelItem.Location = new System.Drawing.Point(75, 89);
            this.buttonLabelItem.MinSize = new System.Drawing.Size(1, 13);
            this.buttonLabelItem.Name = "buttonLabelItem";
            this.buttonLabelItem.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 0);
            this.buttonLabelItem.Size = new System.Drawing.Size(175, 75);
            this.buttonLabelItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonLabelItem.StartNewLine = true;
            this.buttonLabelItem.Text = "Export appointments to an iCalendar (.ics) file.";
            this.buttonLabelItem.TextSize = new System.Drawing.Size(224, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnExportViaiCalendar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 89);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(75, 75);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(75, 75);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(75, 75);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextVisible = false;
            // 
            // buttonLabelItem1
            // 
            this.buttonLabelItem1.AllowHtmlStringInCaption = true;
            this.buttonLabelItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.buttonLabelItem1.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.buttonLabelItem1.CustomizationFormText = "Specify how you want<br>the report to be printed";
            this.buttonLabelItem1.Location = new System.Drawing.Point(75, 184);
            this.buttonLabelItem1.MinSize = new System.Drawing.Size(1, 13);
            this.buttonLabelItem1.Name = "buttonLabelItem1";
            this.buttonLabelItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 0);
            this.buttonLabelItem1.Size = new System.Drawing.Size(175, 75);
            this.buttonLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonLabelItem1.StartNewLine = true;
            this.buttonLabelItem1.Text = "The DevExpress Reporting<br>platform allows you to<br>export any report to<br>PDF" +
    ", XLS, RTF and multiple<br>image file formats.";
            this.buttonLabelItem1.TextSize = new System.Drawing.Size(224, 65);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 259);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(250, 296);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnExportViaReporting;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(75, 75);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(250, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(17, 555);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 164);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(250, 20);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(250, 20);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(250, 20);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // ExportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ExportControl";
            this.Size = new System.Drawing.Size(307, 595);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLabelItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraEditors.SimpleButton btnExportViaiCalendar;
        private XtraLayout.SimpleLabelItem simpleLabelItem1;
        private XtraLayout.SimpleLabelItem buttonLabelItem;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraEditors.DropDownButton btnExportViaReporting;
        private XtraLayout.SimpleLabelItem buttonLabelItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
