namespace DevExpress.XtraRichEdit.Demos {
	partial class CommentsModule {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.bottomDockArea = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.richEditCommentControl1 = new DevExpress.XtraRichEdit.RichEditCommentControl();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEditControl
            // 
            this.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl.Location = new System.Drawing.Point(0, 0);
            this.richEditControl.Name = "richEditControl";
            this.richEditControl.Size = new System.Drawing.Size(740, 464);
            this.richEditControl.TabIndex = 10;
            // 
            // bottomDockArea
            // 
            this.bottomDockArea.AutoSize = true;
            this.bottomDockArea.CausesValidation = false;
            this.bottomDockArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomDockArea.Location = new System.Drawing.Point(2, 245);
            this.bottomDockArea.Manager = null;
            this.bottomDockArea.Name = "bottomDockArea";
            this.bottomDockArea.Size = new System.Drawing.Size(841, 0);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = null;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.Control = this.richEditControl;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("0fd6bee2-437d-4493-89fe-a4e8dc81360b");
            this.dockPanel1.Location = new System.Drawing.Point(740, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(290, 200);
            this.dockPanel1.Size = new System.Drawing.Size(290, 464);
            this.dockPanel1.Text = "Main document comments";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.richEditCommentControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(283, 435);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // richEditCommentControl1
            // 
            this.richEditCommentControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditCommentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditCommentControl1.Location = new System.Drawing.Point(0, 0);
            this.richEditCommentControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richEditCommentControl1.Name = "richEditCommentControl1";
            this.richEditCommentControl1.ReadOnly = false;
            this.richEditCommentControl1.RichEditControl = this.richEditControl;
            this.richEditCommentControl1.Size = new System.Drawing.Size(283, 435);
            this.richEditCommentControl1.TabIndex = 0;
            // 
            // CommentsModule
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richEditControl);
            this.Controls.Add(this.dockPanel1);
            this.Name = "CommentsModule";
            this.Size = new System.Drawing.Size(1030, 464);
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private DevExpress.XtraBars.StandaloneBarDockControl bottomDockArea;
        private RichEditControl richEditControl;
        private XtraBars.BarEditItem barEditItem1;
        private UI.RichEditBarController richEditBarController1;
        private XtraBars.Docking.DockManager dockManager1;
        private XtraBars.Docking.DockPanel dockPanel1;
        private XtraBars.Docking.ControlContainer dockPanel1_Container;
        private RichEditCommentControl richEditCommentControl1;
    }
}
