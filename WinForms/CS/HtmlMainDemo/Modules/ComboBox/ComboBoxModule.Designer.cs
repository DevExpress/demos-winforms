namespace DevExpress.HTML.Demos {
    partial class ComboBoxModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBoxModule));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.comboBoxTemplateViewer1 = new DevExpress.HTML.Demos.ComboBoxTemplateViewer();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.comboBoxTemplateViewer1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(410, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(642, 494);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // comboBoxTemplateViewer1
            // 
            this.comboBoxTemplateViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTemplateViewer1.Location = new System.Drawing.Point(1, 0);
            this.comboBoxTemplateViewer1.Name = "comboBoxTemplateViewer1";
            this.comboBoxTemplateViewer1.Size = new System.Drawing.Size(641, 494);
            this.comboBoxTemplateViewer1.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 300F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.tablePanel1.Controls.Add(this.groupControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 200F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F)});
            this.tablePanel1.Size = new System.Drawing.Size(410, 494);
            this.tablePanel1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.tablePanel1.SetColumn(this.groupControl1, 1);
            this.groupControl1.Controls.Add(this.comboBoxEdit1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(58, 77);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 15);
            this.tablePanel1.SetRow(this.groupControl1, 1);
            this.groupControl1.Size = new System.Drawing.Size(294, 194);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Sample";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEdit1.Location = new System.Drawing.Point(12, 93);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.DropDownItemHeight = 72;
            this.comboBoxEdit1.Properties.DropDownRows = 5;
            this.comboBoxEdit1.Properties.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.htmlTemplate1});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(270, 20);
            this.comboBoxEdit1.TabIndex = 0;
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            this.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles");
            this.htmlTemplate1.Tag = "Item Template";
            this.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template");
            // 
            // ComboBoxModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "ComboBoxModule";
            this.Size = new System.Drawing.Size(1052, 494);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.SidePanel sidePanel1;
        private ComboBoxTemplateViewer comboBoxTemplateViewer1;
        private Utils.Layout.TablePanel tablePanel1;
        private XtraEditors.GroupControl groupControl1;
        private XtraEditors.ComboBoxEdit comboBoxEdit1;
        private Utils.Html.HtmlTemplate htmlTemplate1;
    }
}
