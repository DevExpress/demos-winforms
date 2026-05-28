using DevExpress.XtraEditors.Designer.Utils;
namespace DevExpress.XtraLayout.Demos {
    partial class TechnoLayout {
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
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.facesUserControl1 = new DevExpress.XtraLayout.Demos.Modules.TechnoLayout.FacesUserControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rgFlowDirection = new DevExpress.XtraEditors.RadioGroup();
            this.cheCustomizationMode = new DevExpress.XtraEditors.CheckEdit();
            this.ztbcSize = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.ztbcSpacing = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgFlowDirection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheCustomizationMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSpacing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl3
            // 
            this.layoutControl3.AutoScroll = false;
            this.layoutControl3.Controls.Add(this.facesUserControl1);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(332, 256, 892, 743);
            this.layoutControl3.OptionsView.AlwaysScrollActiveControlIntoView = false;
            this.layoutControl3.Root = this.lcgMain;
            this.layoutControl3.Size = new System.Drawing.Size(648, 590);
            this.layoutControl3.TabIndex = 2;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // facesUserControl1
            // 
            this.facesUserControl1.Location = new System.Drawing.Point(0, 0);
            this.facesUserControl1.Name = "facesUserControl1";
            this.facesUserControl1.Padding = new System.Windows.Forms.Padding(10);
            this.facesUserControl1.Size = new System.Drawing.Size(648, 590);
            this.facesUserControl1.TabIndex = 26;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "Root";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lcgMain.Name = "Root";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Size = new System.Drawing.Size(648, 590);
            this.lcgMain.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.facesUserControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(648, 590);
            this.layoutControlItem1.TextVisible = false;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(1, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(249, 590);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(249, 590);
            this.navigationPane1.TabIndex = 27;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(249, 557);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.rgFlowDirection);
            this.layoutControl1.Controls.Add(this.cheCustomizationMode);
            this.layoutControl1.Controls.Add(this.ztbcSize);
            this.layoutControl1.Controls.Add(this.ztbcSpacing);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(4214, 1328, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(249, 557);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rgFlowDirection
            // 
            this.rgFlowDirection.AutoSizeInLayoutControl = true;
            this.rgFlowDirection.Location = new System.Drawing.Point(12, 140);
            this.rgFlowDirection.Name = "rgFlowDirection";
            this.rgFlowDirection.Size = new System.Drawing.Size(225, 10);
            this.rgFlowDirection.StyleController = this.layoutControl1;
            this.rgFlowDirection.TabIndex = 26;
            this.rgFlowDirection.SelectedIndexChanged += new System.EventHandler(this.rgFlowDirection_SelectedIndexChanged);
            // 
            // cheCustomizationMode
            // 
            this.cheCustomizationMode.EditValue = true;
            this.cheCustomizationMode.Location = new System.Drawing.Point(12, 34);
            this.cheCustomizationMode.Name = "cheCustomizationMode";
            this.cheCustomizationMode.Properties.Caption = "Customization Mode";
            this.cheCustomizationMode.Size = new System.Drawing.Size(225, 20);
            this.cheCustomizationMode.StyleController = this.layoutControl1;
            this.cheCustomizationMode.TabIndex = 25;
            this.cheCustomizationMode.CheckedChanged += new System.EventHandler(this.cheCustomizationMode_CheckedChanged);
            // 
            // ztbcSize
            // 
            this.ztbcSize.EditValue = 150;
            this.ztbcSize.Location = new System.Drawing.Point(12, 74);
            this.ztbcSize.Name = "ztbcSize";
            this.ztbcSize.Properties.LargeChange = 10;
            this.ztbcSize.Properties.Maximum = 250;
            this.ztbcSize.Properties.Middle = 150;
            this.ztbcSize.Properties.Minimum = 50;
            this.ztbcSize.Properties.SmallChange = 10;
            this.ztbcSize.Size = new System.Drawing.Size(225, 16);
            this.ztbcSize.StyleController = this.layoutControl1;
            this.ztbcSize.TabIndex = 4;
            this.ztbcSize.Value = 150;
            this.ztbcSize.EditValueChanged += new System.EventHandler(this.ztbcSize_EditValueChanged);
            // 
            // ztbcSpacing
            // 
            this.ztbcSpacing.EditValue = 15;
            this.ztbcSpacing.Location = new System.Drawing.Point(12, 107);
            this.ztbcSpacing.Name = "ztbcSpacing";
            this.ztbcSpacing.Properties.Maximum = 30;
            this.ztbcSpacing.Properties.Middle = 15;
            this.ztbcSpacing.Size = new System.Drawing.Size(225, 16);
            this.ztbcSpacing.StyleController = this.layoutControl1;
            this.ztbcSpacing.TabIndex = 5;
            this.ztbcSpacing.Value = 15;
            this.ztbcSpacing.EditValueChanged += new System.EventHandler(this.ztbcSpacing_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(249, 557);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(249, 162);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Layout";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cheCustomizationMode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(229, 24);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ztbcSize;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(229, 33);
            this.layoutControlItem3.Text = "Size:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ztbcSpacing;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 57);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(229, 33);
            this.layoutControlItem4.Text = "Spacing";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.rgFlowDirection;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(229, 30);
            this.layoutControlItem5.Text = "Flow Direction";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(67, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 162);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(249, 395);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.navigationPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(648, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(250, 590);
            this.sidePanel1.TabIndex = 26;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // TechnoLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl3);
            this.Controls.Add(this.sidePanel1);
            this.Name = "TechnoLayout";
            this.Size = new System.Drawing.Size(898, 590);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgFlowDirection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheCustomizationMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSpacing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztbcSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private LayoutControl layoutControl3;
        private LayoutControlGroup lcgMain;
        private XtraEditors.ZoomTrackBarControl ztbcSpacing;
        private XtraEditors.ZoomTrackBarControl ztbcSize;
        private XtraEditors.CheckEdit cheCustomizationMode;
        private Modules.TechnoLayout.FacesUserControl facesUserControl1;
        private LayoutControlItem layoutControlItem1;
        private XtraBars.Navigation.TabPane navigationPane1;
        private XtraBars.Navigation.TabNavigationPage navigationPage1;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem2;
        private LayoutControlItem layoutControlItem3;
        private LayoutControlItem layoutControlItem4;
        private LayoutControlGroup layoutControlGroup2;
        private XtraEditors.SidePanel sidePanel1;
        private EmptySpaceItem emptySpaceItem1;
        private XtraEditors.RadioGroup rgFlowDirection;
        private LayoutControlItem layoutControlItem5;
    }
}
