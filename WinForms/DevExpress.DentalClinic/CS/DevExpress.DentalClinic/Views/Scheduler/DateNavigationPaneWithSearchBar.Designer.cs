namespace DevExpress.DentalClinic.View
{
    partial class DateNavigationPaneWithSearchBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.beSearch = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.beSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // beSearch
            // 
            this.beSearch.Location = new System.Drawing.Point(263, 8);
            this.beSearch.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.beSearch.MinimumSize = new System.Drawing.Size(370, 0);
            this.beSearch.Name = "beSearch";
            this.beSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.beSearch.Size = new System.Drawing.Size(370, 24);
            this.beSearch.TabIndex = 3;
            // 
            // DateNavigationPaneWithSearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.beSearch);
            this.Name = "DateNavigationPaneWithSearchBar";
            this.Size = new System.Drawing.Size(693, 43);
            this.Controls.SetChildIndex(this.beSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.beSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.ButtonEdit beSearch;
    }
}
