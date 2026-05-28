namespace DevExpress.DentalClinic.View {
    partial class AnalyticsView {
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
            this.components = new System.ComponentModel.Container();
            this.tabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane
            // 
            this.tabPane.AppearanceButton.Hovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.tabPane.AppearanceButton.Hovered.Options.UseFont = true;
            this.tabPane.AppearanceButton.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.tabPane.AppearanceButton.Normal.Options.UseFont = true;
            this.tabPane.AppearanceButton.Pressed.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.tabPane.AppearanceButton.Pressed.Options.UseFont = true;
            this.tabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane.Location = new System.Drawing.Point(0, 0);
            this.tabPane.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPane.Name = "tabPane";
            this.tabPane.RegularSize = new System.Drawing.Size(1082, 635);
            this.tabPane.SelectedPage = null;
            this.tabPane.Size = new System.Drawing.Size(1082, 635);
            this.tabPane.TabIndex = 0;
            this.tabPane.Text = "tabPane1";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.DentalClinic.ViewModel.AnalyticsViewModel);
            // 
            // AnalyticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tabPane);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AnalyticsView";
            this.Size = new System.Drawing.Size(1082, 635);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Navigation.TabPane tabPane;
        private Utils.MVVM.MVVMContext mvvmContext;
    }
}
