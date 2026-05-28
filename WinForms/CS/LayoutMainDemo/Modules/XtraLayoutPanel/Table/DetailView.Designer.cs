namespace DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel {
    partial class DetailView {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailView));
            this.tablePanel = new DevExpress.Utils.Layout.TablePanel();
            this.deHireDate = new DevExpress.XtraEditors.DateEdit();
            this.deBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.teReportTo = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelHireDate = new DevExpress.XtraEditors.LabelControl();
            this.labelBirthDate = new DevExpress.XtraEditors.LabelControl();
            this.labelReportTo = new DevExpress.XtraEditors.LabelControl();
            this.labelLastName = new DevExpress.XtraEditors.LabelControl();
            this.labelFirstName = new DevExpress.XtraEditors.LabelControl();
            this.imageList = new DevExpress.Utils.SvgImageCollection(this.components);
            this.stackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel)).BeginInit();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deHireDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deHireDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teReportTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).BeginInit();
            this.stackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel.Controls.Add(this.deHireDate);
            this.tablePanel.Controls.Add(this.deBirthDate);
            this.tablePanel.Controls.Add(this.teReportTo);
            this.tablePanel.Controls.Add(this.teLastName);
            this.tablePanel.Controls.Add(this.teFirstName);
            this.tablePanel.Controls.Add(this.labelHireDate);
            this.tablePanel.Controls.Add(this.labelBirthDate);
            this.tablePanel.Controls.Add(this.labelReportTo);
            this.tablePanel.Controls.Add(this.labelLastName);
            this.tablePanel.Controls.Add(this.labelFirstName);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 0);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 18F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 38F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 38F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 38F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 38F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 38F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 38F)});
            this.tablePanel.ShowGrid = DevExpress.Utils.DefaultBoolean.True;
            this.tablePanel.Size = new System.Drawing.Size(720, 320);
            this.tablePanel.TabIndex = 0;
            this.tablePanel.UseSkinIndents = true;
            this.tablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTablePanelPaint);
            this.tablePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnTablePanelMouseClick);
            this.tablePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnTablePanelMouseDown);
            this.tablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnTablePanelMouseMove);
            this.tablePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTablePanelMouseUp);
            // 
            // deHireDate
            // 
            this.tablePanel.SetColumn(this.deHireDate, 1);
            this.deHireDate.EditValue = null;
            this.deHireDate.Location = new System.Drawing.Point(72, 126);
            this.deHireDate.Name = "deHireDate";
            this.deHireDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deHireDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel.SetRow(this.deHireDate, 5);
            this.deHireDate.Size = new System.Drawing.Size(635, 20);
            this.deHireDate.TabIndex = 9;
            // 
            // deBirthDate
            // 
            this.tablePanel.SetColumn(this.deBirthDate, 1);
            this.deBirthDate.EditValue = null;
            this.deBirthDate.Location = new System.Drawing.Point(72, 102);
            this.deBirthDate.Name = "deBirthDate";
            this.deBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel.SetRow(this.deBirthDate, 4);
            this.deBirthDate.Size = new System.Drawing.Size(635, 20);
            this.deBirthDate.TabIndex = 7;
            // 
            // teReportTo
            // 
            this.tablePanel.SetColumn(this.teReportTo, 1);
            this.teReportTo.EditValue = "Sales Representative";
            this.teReportTo.Location = new System.Drawing.Point(72, 78);
            this.teReportTo.Name = "teReportTo";
            this.tablePanel.SetRow(this.teReportTo, 3);
            this.teReportTo.Size = new System.Drawing.Size(635, 20);
            this.teReportTo.TabIndex = 5;
            // 
            // teLastName
            // 
            this.tablePanel.SetColumn(this.teLastName, 1);
            this.teLastName.EditValue = "Davolio";
            this.teLastName.Location = new System.Drawing.Point(72, 54);
            this.teLastName.Name = "teLastName";
            this.tablePanel.SetRow(this.teLastName, 2);
            this.teLastName.Size = new System.Drawing.Size(635, 20);
            this.teLastName.TabIndex = 3;
            // 
            // teFirstName
            // 
            this.tablePanel.SetColumn(this.teFirstName, 1);
            this.teFirstName.EditValue = "Nancy";
            this.teFirstName.Location = new System.Drawing.Point(72, 30);
            this.teFirstName.Name = "teFirstName";
            this.tablePanel.SetRow(this.teFirstName, 1);
            this.teFirstName.Size = new System.Drawing.Size(635, 20);
            this.teFirstName.TabIndex = 1;
            // 
            // labelHireDate
            // 
            this.tablePanel.SetColumn(this.labelHireDate, 0);
            this.labelHireDate.Location = new System.Drawing.Point(13, 129);
            this.labelHireDate.Name = "labelHireDate";
            this.tablePanel.SetRow(this.labelHireDate, 5);
            this.labelHireDate.Size = new System.Drawing.Size(49, 13);
            this.labelHireDate.TabIndex = 8;
            this.labelHireDate.Text = "Hire Date:";
            // 
            // labelBirthDate
            // 
            this.tablePanel.SetColumn(this.labelBirthDate, 0);
            this.labelBirthDate.Location = new System.Drawing.Point(13, 105);
            this.labelBirthDate.Name = "labelBirthDate";
            this.tablePanel.SetRow(this.labelBirthDate, 4);
            this.labelBirthDate.Size = new System.Drawing.Size(52, 13);
            this.labelBirthDate.TabIndex = 6;
            this.labelBirthDate.Text = "Birth Date:";
            // 
            // labelReportTo
            // 
            this.tablePanel.SetColumn(this.labelReportTo, 0);
            this.labelReportTo.Location = new System.Drawing.Point(13, 81);
            this.labelReportTo.Name = "labelReportTo";
            this.tablePanel.SetRow(this.labelReportTo, 3);
            this.labelReportTo.Size = new System.Drawing.Size(52, 13);
            this.labelReportTo.TabIndex = 4;
            this.labelReportTo.Text = "Report To:";
            // 
            // labelLastName
            // 
            this.tablePanel.SetColumn(this.labelLastName, 0);
            this.labelLastName.Location = new System.Drawing.Point(13, 57);
            this.labelLastName.Name = "labelLastName";
            this.tablePanel.SetRow(this.labelLastName, 2);
            this.labelLastName.Size = new System.Drawing.Size(54, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.tablePanel.SetColumn(this.labelFirstName, 0);
            this.labelFirstName.Location = new System.Drawing.Point(13, 33);
            this.labelFirstName.Name = "labelFirstName";
            this.tablePanel.SetRow(this.labelFirstName, 1);
            this.labelFirstName.Size = new System.Drawing.Size(55, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // imageList
            // 
            this.imageList.Add("Actions_AddColumn", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("imageList.Actions_AddColumn"))));
            this.imageList.Add("Actions_AddColumn_Hot", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("imageList.Actions_AddColumn_Hot"))));
            this.imageList.Add("Actions_AddRow", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("imageList.Actions_AddRow"))));
            this.imageList.Add("Actions_AddRow_Hot", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("imageList.Actions_AddRow_Hot"))));
            // 
            // stackPanel
            // 
            this.stackPanel.Controls.Add(this.btnCancel);
            this.stackPanel.Controls.Add(this.btnOk);
            this.stackPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.stackPanel.Location = new System.Drawing.Point(0, 320);
            this.stackPanel.Name = "stackPanel";
            this.stackPanel.Size = new System.Drawing.Size(720, 48);
            this.stackPanel.TabIndex = 11;
            this.stackPanel.UseSkinIndents = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(632, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(553, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            // 
            // DetailView
            // 
            this.ClientSize = new System.Drawing.Size(720, 368);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.stackPanel);
            this.Name = "DetailView";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deHireDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deHireDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teReportTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).EndInit();
            this.stackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel;
        private XtraEditors.LabelControl labelHireDate;
        private XtraEditors.LabelControl labelBirthDate;
        private XtraEditors.LabelControl labelReportTo;
        private XtraEditors.LabelControl labelLastName;
        private XtraEditors.LabelControl labelFirstName;
        private XtraEditors.DateEdit deHireDate;
        private XtraEditors.DateEdit deBirthDate;
        private XtraEditors.TextEdit teReportTo;
        private XtraEditors.TextEdit teLastName;
        private XtraEditors.TextEdit teFirstName;
        private DevExpress.Utils.SvgImageCollection imageList;
        private DevExpress.Utils.Layout.StackPanel stackPanel;
        private XtraEditors.SimpleButton btnCancel;
        private XtraEditors.SimpleButton btnOk;
    }
}
