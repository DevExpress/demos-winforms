using DevExpress.Skins;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DevExpress.XtraBars.Demos.BrowserDemo  {
    public class BrowserNavigationControl : XtraUserControl {
        private BarManager barManager1;
        private System.ComponentModel.IContainer components;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private Bar bar1;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem4;
        private BarEditItem barEditItem1;
        private XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private BarButtonItem barButtonItem5;
        private BarAndDockingController barAndDockingController1;
        private BarButtonItem barButtonItem1;
        private BarButtonItem twButton;
        private BarButtonItem ytButton;
        private BarButtonItem fbButton;
        private BarDockControl barDockControlRight;
    
        public BrowserNavigationControl()
            : base() {
                InitializeComponent();
                Dock = System.Windows.Forms.DockStyle.Top;
                SearchItem.EditorPadding = new System.Windows.Forms.Padding(SearchItemLeftPadding, 0, SearchItemRightPadding, 0);
        }

        public RepositoryItemSearchControl SearchPanel { get { return this.repositoryItemSearchControl1; } }
        public BarEditItem SearchItem { get { return this.barEditItem1; } }
        public BarManager Manager { get { return this.barManager1; } }
        public BarButtonItem BackButton { get { return this.barButtonItem3; } }
        public BarButtonItem ForwardButton { get { return this.barButtonItem4; } }
        public BarButtonItem RefreshButton { get { return this.barButtonItem5; } }

        static readonly int SearchItemLeftPadding = 8;
        static readonly int SearchItemRightPadding = 5;
        protected override void SetBoundsCore(int x, int y, int width, int height, System.Windows.Forms.BoundsSpecified specified) {
            height = Padding.Vertical + barDockControlTop.Height;
            base.SetBoundsCore(x, y, width, height, specified);
        }
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserNavigationControl));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.twButton = new DevExpress.XtraBars.BarButtonItem();
            this.ytButton = new DevExpress.XtraBars.BarButtonItem();
            this.fbButton = new DevExpress.XtraBars.BarButtonItem();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControlTop = new EmptyBarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem3,
            this.barButtonItem4,
            this.barEditItem1,
            this.barButtonItem5,
            this.barButtonItem1,
            this.twButton,
            this.ytButton,
            this.fbButton});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 11;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.twButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.ytButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.fbButton)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Back";
            this.barButtonItem3.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.barButtonItem3.Enabled = false;
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.Size = new System.Drawing.Size(30, 0);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Forward";
            this.barButtonItem4.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.barButtonItem4.Enabled = false;
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.Size = new System.Drawing.Size(30, 0);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Refresh";
            this.barButtonItem5.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.Size = new System.Drawing.Size(30, 0);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Home";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Size = new System.Drawing.Size(30, 0);
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.homeButton_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.AutoFillWidth = true;
            this.barEditItem1.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Center;
            this.barEditItem1.Edit = this.repositoryItemSearchControl1;
            this.barEditItem1.EditHeight = 30;
            this.barEditItem1.EditWidth = 70;
            this.barEditItem1.Id = 4;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemSearchControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.repositoryItemSearchControl1.Appearance.Options.UseFont = true;
            this.repositoryItemSearchControl1.Appearance.Options.UseForeColor = true;
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            this.repositoryItemSearchControl1.NullValuePrompt = "Enter a web address";
            this.repositoryItemSearchControl1.ShowClearButton = false;
            // 
            // twButton
            // 
            this.twButton.Caption = "Twitter";
            this.twButton.Id = 8;
            this.twButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("twButton.ImageOptions.SvgImage")));
            this.twButton.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.twButton.Name = "twButton";
            this.twButton.Size = new System.Drawing.Size(30, 0);
            this.twButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.twButton_ItemClick);
            // 
            // ytButton
            // 
            this.ytButton.Caption = "Youtube";
            this.ytButton.Id = 9;
            this.ytButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ytButton.ImageOptions.SvgImage")));
            this.ytButton.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.ytButton.Name = "ytButton";
            this.ytButton.Size = new System.Drawing.Size(30, 0);
            this.ytButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ytButton_ItemClick);
            // 
            // fbButton
            // 
            this.fbButton.Caption = "Facebook";
            this.fbButton.Id = 10;
            this.fbButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fbButton.ImageOptions.SvgImage")));
            this.fbButton.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.fbButton.Name = "fbButton";
            this.fbButton.Size = new System.Drawing.Size(30, 0);
            this.fbButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.fbButton_ItemClick);
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesBar.BarItemHorzIndent = 0;
            this.barAndDockingController1.PropertiesDocking.ViewStyle = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(9, 9);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(469, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(9, 139);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(469, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(9, 39);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 100);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(478, 39);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 100);
            // 
            // BrowserNavigationControl
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BrowserNavigationControl";
            this.Padding = new System.Windows.Forms.Padding(9, 9, 12, 11);
            this.Size = new System.Drawing.Size(490, 150);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void twButton_ItemClick(object sender, ItemClickEventArgs e) {
            var ownerForm = FindForm() as frmMain;
            if(ownerForm != null) ownerForm.Navigate("www.twitter.com/DevExpress");
        }

        private void ytButton_ItemClick(object sender, ItemClickEventArgs e) {
            var ownerForm = FindForm() as frmMain;
            if(ownerForm != null) ownerForm.Navigate("www.youtube.com/user/DeveloperExpress?ab_channel=DevExpress");
        }

        private void fbButton_ItemClick(object sender, ItemClickEventArgs e) {
            var ownerForm = FindForm() as frmMain;
            if(ownerForm != null) ownerForm.Navigate("www.facebook.com/DevExpress");
        }

        private void homeButton_ItemClick(object sender, ItemClickEventArgs e) {
            var ownerForm = FindForm() as frmMain;
            if(ownerForm != null) ownerForm.InitHomePage();
        }
    }
    public class EmptyBarDockControl : BarDockControl {
        public EmptyBarDockControl() {
            SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
        }
        public override Color BackColor {
            get { return Color.Transparent; }
        }
        protected override CustomViewInfo CreateViewInfo() {
            return new MyDockControlSkinViewInfo(Manager, Manager.GetController().PaintStyle.DrawParameters, this);
        }
        class MyDockControlSkinViewInfo : DockControlSkinViewInfo {
            public MyDockControlSkinViewInfo(BarManager manager, BarDrawParameters parameters, CustomControl barControl) : base(manager, parameters, barControl) { }
            public override bool IsDrawForeground { get { return false; } }
        }
    }
}
