namespace DevExpress.XtraDiagram.Demos {
    partial class FloorPlanModule {
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
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            this.SuspendLayout();
            // 
            // containerControl
            // 
            this.containerControl.Size = new System.Drawing.Size(794, 441);
            // 
            // diagramControl
            // 
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[0]);
            this.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.None;
            this.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl.OptionsView.ScrollMargin = new System.Windows.Forms.Padding(150);
            this.diagramControl.OptionsView.ShowGrid = false;
            this.diagramControl.OptionsView.ShowPageBreaks = false;
            this.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Compact;
            this.diagramControl.Size = new System.Drawing.Size(694, 267);
            // 
            // FloorPlanModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FloorPlanModule";
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
