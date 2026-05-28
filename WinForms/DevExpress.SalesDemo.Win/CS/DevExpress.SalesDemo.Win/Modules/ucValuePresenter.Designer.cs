namespace DevExpress.SalesDemo.Win.Modules {
    partial class ucValuePresenter {
        
        
        
        private System.ComponentModel.IContainer components = null;

        
        
        
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        
        
        
        
        private void InitializeComponent() {
            this.labelLine = new System.Windows.Forms.Label();
            this.ucValuePresenterlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.labelValue = new DevExpress.XtraEditors.LabelControl();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLabelLine = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLabelTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLabelValue = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ucValuePresenterlayoutControl1ConvertedLayout)).BeginInit();
            this.ucValuePresenterlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelValue)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.labelLine.BackColor = System.Drawing.Color.Silver;
            this.labelLine.Location = new System.Drawing.Point(2, 2);
            this.labelLine.Margin = new System.Windows.Forms.Padding(0);
            this.labelLine.MaximumSize = new System.Drawing.Size(1, 0);
            this.labelLine.MinimumSize = new System.Drawing.Size(1, 0);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(1, 47);
            this.labelLine.TabIndex = 2;
            
            
            
            this.ucValuePresenterlayoutControl1ConvertedLayout.AllowCustomization = false;
            this.ucValuePresenterlayoutControl1ConvertedLayout.Controls.Add(this.labelValue);
            this.ucValuePresenterlayoutControl1ConvertedLayout.Controls.Add(this.labelTitle);
            this.ucValuePresenterlayoutControl1ConvertedLayout.Controls.Add(this.labelLine);
            this.ucValuePresenterlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucValuePresenterlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ucValuePresenterlayoutControl1ConvertedLayout.Name = "ucValuePresenterlayoutControl1ConvertedLayout";
            this.ucValuePresenterlayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-1075, 215, 650, 400);
            this.ucValuePresenterlayoutControl1ConvertedLayout.OptionsView.AutoSizeInLayoutControl = DevExpress.XtraLayout.AutoSizeModes.ResizeToMinSize;
            this.ucValuePresenterlayoutControl1ConvertedLayout.OptionsView.UseParentAutoScaleFactor = true;
            this.ucValuePresenterlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.ucValuePresenterlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(161, 51);
            this.ucValuePresenterlayoutControl1ConvertedLayout.TabIndex = 5;
            
            
            
            this.labelValue.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelValue.Appearance.Options.UseFont = true;
            this.labelValue.Location = new System.Drawing.Point(9, 19);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(119, 28);
            this.labelValue.StyleController = this.ucValuePresenterlayoutControl1ConvertedLayout;
            this.labelValue.TabIndex = 5;
            this.labelValue.Text = "labelControl1";
            
            
            
            this.labelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelTitle.Appearance.Options.UseFont = true;
            this.labelTitle.Appearance.Options.UseForeColor = true;
            this.labelTitle.Location = new System.Drawing.Point(9, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(70, 13);
            this.labelTitle.StyleController = this.ucValuePresenterlayoutControl1ConvertedLayout;
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "labelControl1";
            
            
            
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLabelLine,
            this.lciLabelTitle,
            this.lciLabelValue});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(161, 51);
            this.layoutControlGroup1.TextVisible = false;
            
            
            
            this.lciLabelLine.Control = this.labelLine;
            this.lciLabelLine.Location = new System.Drawing.Point(0, 0);
            this.lciLabelLine.Name = "lciLabelLine";
            this.lciLabelLine.OptionsTableLayoutItem.RowSpan = 2;
            this.lciLabelLine.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 4, 2, 2);
            this.lciLabelLine.Size = new System.Drawing.Size(7, 51);
            this.lciLabelLine.TextSize = new System.Drawing.Size(0, 0);
            this.lciLabelLine.TextVisible = false;
            
            
            
            this.lciLabelTitle.Control = this.labelTitle;
            this.lciLabelTitle.Location = new System.Drawing.Point(7, 0);
            this.lciLabelTitle.Name = "lciLabelTitle";
            this.lciLabelTitle.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lciLabelTitle.Size = new System.Drawing.Size(154, 17);
            this.lciLabelTitle.TextSize = new System.Drawing.Size(0, 0);
            this.lciLabelTitle.TextVisible = false;
            
            
            
            this.lciLabelValue.Control = this.labelValue;
            this.lciLabelValue.Location = new System.Drawing.Point(7, 17);
            this.lciLabelValue.Name = "lciLabelValue";
            this.lciLabelValue.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lciLabelValue.OptionsTableLayoutItem.RowIndex = 1;
            this.lciLabelValue.Size = new System.Drawing.Size(154, 34);
            this.lciLabelValue.TextSize = new System.Drawing.Size(0, 0);
            this.lciLabelValue.TextVisible = false;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucValuePresenterlayoutControl1ConvertedLayout);
            this.Name = "ucValuePresenter";
            this.Size = new System.Drawing.Size(161, 51);
            ((System.ComponentModel.ISupportInitialize)(this.ucValuePresenterlayoutControl1ConvertedLayout)).EndInit();
            this.ucValuePresenterlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelLine;
        private XtraLayout.LayoutControl ucValuePresenterlayoutControl1ConvertedLayout;
        private XtraEditors.LabelControl labelTitle;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraEditors.LabelControl labelValue;
        private XtraLayout.LayoutControlItem lciLabelLine;
        private XtraLayout.LayoutControlItem lciLabelTitle;
        private XtraLayout.LayoutControlItem lciLabelValue;
    }
}
