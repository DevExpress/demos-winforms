namespace PhotoViewer {
    partial class DateFilter {
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
            DevExpress.XtraEditors.Controls.DateRange dateRange1 = new DevExpress.XtraEditors.Controls.DateRange();
            DevExpress.XtraEditors.Controls.DateRange dateRange2 = new DevExpress.XtraEditors.Controls.DateRange();
            this.separator = new DevExpress.XtraEditors.LabelControl();
            this.calendarStartDate = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.allowFilterCheck = new DevExpress.XtraEditors.CheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.calendarStartDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowFilterCheck.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // separator
            // 
            this.separator.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.LineVisible = true;
            this.separator.Location = new System.Drawing.Point(0, 0);
            this.separator.Name = "separator";
            this.separator.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.separator.Size = new System.Drawing.Size(448, 13);
            this.separator.TabIndex = 5;
            // 
            // startDate
            // 
            this.calendarStartDate.AutoSize = false;
            this.calendarStartDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.calendarStartDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.calendarStartDate.DateTime = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.calendarStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarStartDate.EditValue = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.calendarStartDate.Location = new System.Drawing.Point(0, 0);
            this.calendarStartDate.Name = "startDate";
            dateRange1.EndDate = new System.DateTime(2025, 7, 24, 0, 0, 0, 0);
            dateRange1.StartDate = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            dateRange2.EndDate = new System.DateTime(2025, 7, 24, 0, 0, 0, 0);
            dateRange2.StartDate = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.calendarStartDate.SelectedRanges.Add(dateRange1);
            this.calendarStartDate.SelectedRanges.Add(dateRange2);
            this.calendarStartDate.SelectionMode = DevExpress.XtraEditors.Repository.CalendarSelectionMode.Multiple;
            this.calendarStartDate.Size = new System.Drawing.Size(448, 262);
            this.calendarStartDate.TabIndex = 3;
            this.calendarStartDate.SelectionChanged += new System.EventHandler(this.startDate_SelectionChanged);
            // 
            // allowFilterCheck
            // 
            this.allowFilterCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.allowFilterCheck.Location = new System.Drawing.Point(11, 17);
            this.allowFilterCheck.Name = "allowFilterCheck";
            this.allowFilterCheck.Properties.Caption = "Apply Filter";
            this.allowFilterCheck.Size = new System.Drawing.Size(75, 19);
            this.allowFilterCheck.TabIndex = 6;
            this.allowFilterCheck.CheckedChanged += new System.EventHandler(this.allowFilterCheck_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.allowFilterCheck);
            this.panel1.Controls.Add(this.separator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 46);
            this.panel1.TabIndex = 7;
            // 
            // DateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calendarStartDate);
            this.Controls.Add(this.panel1);
            this.Name = "DateFilter";
            this.Size = new System.Drawing.Size(448, 308);
            ((System.ComponentModel.ISupportInitialize)(this.calendarStartDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowFilterCheck.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl separator;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarStartDate;
        private DevExpress.XtraEditors.CheckEdit allowFilterCheck;
        private System.Windows.Forms.Panel panel1;
    }
}
