namespace PhotoViewer {
    partial class SimpleFilterParams {
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
            this.applyFilterButton = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleFilterParamsConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.applyButtonItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleFilterParamsConvertedLayout)).BeginInit();
            this.SimpleFilterParamsConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyFilterButton.Location = new System.Drawing.Point(132, 208);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(76, 24);
            this.applyFilterButton.StyleController = this.SimpleFilterParamsConvertedLayout;
            this.applyFilterButton.TabIndex = 1;
            this.applyFilterButton.Text = "Apply";
            // 
            // SimpleFilterParamsConvertedLayout
            // 
            this.SimpleFilterParamsConvertedLayout.Controls.Add(this.applyFilterButton);
            this.SimpleFilterParamsConvertedLayout.Controls.Add(this.pictureEdit1);
            this.SimpleFilterParamsConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleFilterParamsConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.SimpleFilterParamsConvertedLayout.Name = "SimpleFilterParamsConvertedLayout";
            this.SimpleFilterParamsConvertedLayout.Root = this.layoutControlGroup1;
            this.SimpleFilterParamsConvertedLayout.Size = new System.Drawing.Size(341, 308);
            this.SimpleFilterParamsConvertedLayout.TabIndex = 5;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(28, 28);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(285, 146);
            this.pictureEdit1.StyleController = this.SimpleFilterParamsConvertedLayout;
            this.pictureEdit1.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.applyButtonItem,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(26, 26, 26, 26);
            this.layoutControlGroup1.Size = new System.Drawing.Size(341, 308);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.pictureEdit1;
            this.layoutControlItem3.CustomizationFormText = "pictureEdit1item";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 150);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(24, 24);
            this.layoutControlItem3.Name = "pictureEdit1item";
            this.layoutControlItem3.Size = new System.Drawing.Size(289, 150);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextVisible = false;
            // 
            // applyButtonItem
            // 
            this.applyButtonItem.Control = this.applyFilterButton;
            this.applyButtonItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.applyButtonItem.CustomizationFormText = "applyButtonItem";
            this.applyButtonItem.Location = new System.Drawing.Point(0, 150);
            this.applyButtonItem.MaxSize = new System.Drawing.Size(80, 58);
            this.applyButtonItem.MinSize = new System.Drawing.Size(42, 58);
            this.applyButtonItem.Name = "applyButtonItem";
            this.applyButtonItem.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 32, 2);
            this.applyButtonItem.Size = new System.Drawing.Size(289, 58);
            this.applyButtonItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.applyButtonItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 208);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(289, 48);
            // 
            // SimpleFilterParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SimpleFilterParamsConvertedLayout);
            this.Name = "SimpleFilterParams";
            this.Size = new System.Drawing.Size(341, 308);
            ((System.ComponentModel.ISupportInitialize)(this.SimpleFilterParamsConvertedLayout)).EndInit();
            this.SimpleFilterParamsConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applyButtonItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.SimpleButton applyFilterButton;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        protected DevExpress.XtraLayout.LayoutControl SimpleFilterParamsConvertedLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        protected DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        protected DevExpress.XtraLayout.LayoutControlItem applyButtonItem;

    }
}
