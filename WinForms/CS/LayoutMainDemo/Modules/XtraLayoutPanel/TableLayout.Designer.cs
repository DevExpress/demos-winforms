namespace DevExpress.XtraLayout.Demos {
    partial class TableLayout {
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
            this.ceShowGrid = new DevExpress.XtraEditors.CheckEdit();
            this.liShowGrid = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liPropertyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgToolbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liResetLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowGrid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.ceShowGrid);
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(880, 335, 650, 400);
            this.layoutControl.Controls.SetChildIndex(this.ceShowGrid, 0);
            // 
            // liPropertyGrid
            // 
            this.liPropertyGrid.Size = new System.Drawing.Size(249, 303);
            // 
            // lcgOptions
            // 
            this.lcgOptions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.liShowGrid});
            this.lcgOptions.Location = new System.Drawing.Point(0, 194);
            this.lcgOptions.Size = new System.Drawing.Size(249, 392);
            // 
            // lcgToolbox
            // 
            this.lcgToolbox.Size = new System.Drawing.Size(249, 194);
            // 
            // liResetLayout
            // 
            this.liResetLayout.Location = new System.Drawing.Point(0, 334);
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 360);
            this.emptySpaceItem.Size = new System.Drawing.Size(249, 10);
            // 
            // ceShowGrid
            // 
            this.ceShowGrid.Location = new System.Drawing.Point(12, 519);
            this.ceShowGrid.Name = "ceShowGrid";
            this.ceShowGrid.Properties.Caption = "Show Grid";
            this.ceShowGrid.Size = new System.Drawing.Size(225, 20);
            this.ceShowGrid.StyleController = this.layoutControl;
            this.ceShowGrid.TabIndex = 6;
            this.ceShowGrid.CheckedChanged += new System.EventHandler(this.OnShowGridCheckedChanged);
            // 
            // liShowGrid
            // 
            this.liShowGrid.Control = this.ceShowGrid;
            this.liShowGrid.Location = new System.Drawing.Point(0, 303);
            this.liShowGrid.Name = "liShowGrid";
            this.liShowGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 0, 11);
            this.liShowGrid.Size = new System.Drawing.Size(249, 31);
            this.liShowGrid.TextVisible = false;
            // 
            // TableLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TableLayout";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liPropertyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgToolbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liResetLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowGrid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liShowGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.CheckEdit ceShowGrid;
        private LayoutControlItem liShowGrid;
    }
}
