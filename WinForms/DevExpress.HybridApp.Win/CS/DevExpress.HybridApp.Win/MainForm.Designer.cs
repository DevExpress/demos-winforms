namespace DevExpress.DevAV
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.tileNavPane = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButtonHome = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonInfo = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonHelp = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonClose = new DevExpress.XtraBars.Navigation.NavButton();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.menuManager = new DevExpress.XtraBars.BarManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuManager)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 40);
            this.tileBar.MaxId = 3;
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(22, 7, 22, 20);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.Size = new System.Drawing.Size(1376, 110);
            this.tileBar.TabIndex = 0;
            this.tileBar.Text = "tileBar";
            this.tileBar.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.tileBar.WideTileWidth = 150;
            
            
            
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 150);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.SelectedPage = null;
            this.navigationFrame.Size = new System.Drawing.Size(1376, 700);
            this.navigationFrame.TabIndex = 2;
            this.navigationFrame.Text = "navigationFrame1";
            this.navigationFrame.TransitionAnimationProperties.FrameInterval = 5000;
            
            
            
            this.tileNavPane.AllowGlyphSkinning = true;
            this.tileNavPane.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tileNavPane.Appearance.Options.UseBackColor = true;
            this.tileNavPane.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(219)))));
            this.tileNavPane.AppearanceHovered.Options.UseBackColor = true;
            this.tileNavPane.AppearanceSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(219)))));
            this.tileNavPane.AppearanceSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tileNavPane.AppearanceSelected.Options.UseBackColor = true;
            this.tileNavPane.AppearanceSelected.Options.UseForeColor = true;
            this.tileNavPane.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane.Buttons.Add(this.navButtonHome);
            this.tileNavPane.Buttons.Add(this.navButtonInfo);
            this.tileNavPane.Buttons.Add(this.navButtonHelp);
            this.tileNavPane.Buttons.Add(this.navButtonClose);
            
            
            
            this.tileNavPane.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane.DefaultCategory.OwnerCollection = null;
            
            
            
            this.tileNavPane.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane.Name = "tileNavPane";
            this.tileNavPane.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane.Size = new System.Drawing.Size(1376, 40);
            this.tileNavPane.TabIndex = 3;
            this.tileNavPane.Text = "tileNavPane1";
            this.tileNavPane.Visible = false;
            
            
            
            this.navButtonHome.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButtonHome.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.navButtonHome.Caption = "";
            this.navButtonHome.Enabled = false;
            this.navButtonHome.Name = "navButtonHome";
            
            
            
            this.navButtonInfo.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButtonInfo.Caption = "";
            this.navButtonInfo.Name = "navButtonInfo";
            
            
            
            this.navButtonHelp.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButtonHelp.Caption = "";
            this.navButtonHelp.Name = "navButtonHelp";
            
            
            
            this.navButtonClose.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButtonClose.Caption = "";
            this.navButtonClose.Name = "navButtonClose";
            
            
            
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.DevAV.ViewModels.DevAVDbViewModel);
            
            
            
            this.menuManager.DockingEnabled = false;
            this.menuManager.Form = this;
            this.menuManager.MaxItemId = 0;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 850);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Controls.Add(this.tileNavPane);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevAV";
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Navigation.TileBar tileBar;
        private XtraBars.Navigation.NavigationFrame navigationFrame;
        private Utils.MVVM.MVVMContext mvvmContext;
        private XtraBars.Navigation.TileNavPane tileNavPane;
        private XtraBars.Navigation.NavButton navButtonHome;
        private XtraBars.Navigation.NavButton navButtonInfo;
        private XtraBars.Navigation.NavButton navButtonHelp;
        private XtraBars.Navigation.NavButton navButtonClose;
        private XtraBars.BarManager menuManager;
    }
}
