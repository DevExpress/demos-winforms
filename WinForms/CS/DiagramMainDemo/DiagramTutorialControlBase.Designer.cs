namespace DevExpress.XtraDiagram.Demos {
    partial class DiagramTutorialControlBase {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.optionsPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sidePanel = new DevExpress.XtraEditors.SidePanel();
            this.containerControl = new System.Windows.Forms.ContainerControl();
            this.diagramControl = new DevExpress.XtraDiagram.DiagramControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane
            // 
            this.tabPane.AllowCollapse = DevExpress.Utils.DefaultBoolean.True;
            this.tabPane.AllowResize = false;
            this.tabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane.Location = new System.Drawing.Point(1, 0);
            this.tabPane.Name = "tabPane";
            this.tabPane.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabPane.RegularSize = new System.Drawing.Size(279, 441);
            this.tabPane.SelectedPage = null;
            this.tabPane.Size = new System.Drawing.Size(249, 441);
            this.tabPane.TabIndex = 5;
            // 
            // optionsPage
            // 
            this.optionsPage.AutoScroll = true;
            this.optionsPage.Caption = "Options";
            this.optionsPage.Name = "optionsPage";
            this.optionsPage.Size = new System.Drawing.Size(249, 408);
            // 
            // sidePanel
            // 
            this.sidePanel.AllowResize = false;
            this.sidePanel.Controls.Add(this.tabPane);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(544, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 441);
            this.sidePanel.TabIndex = 1;
            this.sidePanel.Text = "sidePanel";
            // 
            // containerControl
            // 
            this.containerControl.Controls.Add(this.diagramControl);
            this.containerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerControl.Location = new System.Drawing.Point(0, 0);
            this.containerControl.Margin = new System.Windows.Forms.Padding(0);
            this.containerControl.Name = "containerControl";
            this.containerControl.Size = new System.Drawing.Size(544, 441);
            this.containerControl.TabIndex = 6;
            // 
            // diagramControl
            // 
            this.diagramControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.diagramControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl.Location = new System.Drawing.Point(0, 0);
            this.diagramControl.Name = "diagramControl";
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[0]);
            this.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed;
            this.diagramControl.Size = new System.Drawing.Size(544, 441);
            this.diagramControl.TabIndex = 0;
            // 
            // DiagramTutorialControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerControl);
            this.Controls.Add(this.sidePanel);
            this.Name = "DiagramTutorialControlBase";
            this.Size = new System.Drawing.Size(794, 441);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.containerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XtraBars.Navigation.TabPane tabPane;
        private XtraBars.Navigation.TabNavigationPage optionsPage;
        private XtraEditors.SidePanel sidePanel;
        protected System.Windows.Forms.ContainerControl containerControl;
        protected DiagramControl diagramControl;
    }
}
