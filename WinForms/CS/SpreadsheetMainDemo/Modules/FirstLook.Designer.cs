namespace DevExpress.XtraSpreadsheet.Demos {
    partial class FirstLookModule {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstLookModule));
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Options.Behavior.MaxZoomFactor = 4F;
            this.spreadsheetControl1.Options.Behavior.MinZoomFactor = 0.1F;
            this.spreadsheetControl1.Options.Behavior.UseSkinColors = false;
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Size = new System.Drawing.Size(784, 221);
            // 
            // FirstLookModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FirstLookModule";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
