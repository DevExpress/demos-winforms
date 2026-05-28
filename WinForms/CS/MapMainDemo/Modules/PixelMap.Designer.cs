using DevExpress.XtraBars.Ribbon;
using System;
using System.Drawing;

namespace DevExpress.XtraMap.Demos {
    partial class PixelMap {
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
            DevExpress.XtraMap.GeoMapCoordinateSystem geoMapCoordinateSystem1 = new DevExpress.XtraMap.GeoMapCoordinateSystem();
            DevExpress.XtraMap.EPSG4326Projection epsG4326Projection1 = new DevExpress.XtraMap.EPSG4326Projection();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixelMap));
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.vectorItemsLayer2 = new DevExpress.XtraMap.VectorItemsLayer();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.rpgPointsComplexity = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem4 = new DevExpress.XtraBars.BarCheckItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barListItem2 = new DevExpress.XtraBars.BarListItem();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barCheckItem5 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem6 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem7 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem8 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem9 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem10 = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem2,
            this.barCheckItem5,
            this.barCheckItem6,
            this.barCheckItem7,
            this.barCheckItem8,
            this.barCheckItem9,
            this.barCheckItem10});
            this.ribbonControl1.MaxItemId = 14;
            // 
            // rpOptions
            // 
            this.rpOptions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.rpgPointsComplexity,
            this.ribbonPageGroup2});
            // 
            // mapControl1
            // 
            this.mapControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(5D, 0D);
            geoMapCoordinateSystem1.Projection = epsG4326Projection1;
            this.mapControl1.CoordinateSystem = geoMapCoordinateSystem1;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer2);
            this.mapControl1.Location = new System.Drawing.Point(0, 141);
            this.mapControl1.MinZoomLevel = 1.5D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(500, 359);
            this.mapControl1.TabIndex = 1;
            this.mapControl1.ZoomLevel = 1.5D;
            this.vectorItemsLayer1.Data = this.mapItemStorage1;
            this.vectorItemsLayer1.EnableHighlighting = false;
            this.vectorItemsLayer1.EnableSelection = false;
            this.vectorItemsLayer1.ItemStyle.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(211)))), ((int)(((byte)(236)))));
            this.vectorItemsLayer1.ItemStyle.Stroke = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(211)))), ((int)(((byte)(236)))));
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = null;
            this.barEditItem1.EditHeight = 60;
            this.barEditItem1.EditValue = 32;
            this.barEditItem1.EditWidth = 120;
            this.barEditItem1.Id = -1;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // rpgPointsComplexity
            // 
            this.rpgPointsComplexity.ItemLinks.Add(this.barCheckItem1);
            this.rpgPointsComplexity.ItemLinks.Add(this.barCheckItem2);
            this.rpgPointsComplexity.ItemLinks.Add(this.barCheckItem3);
            this.rpgPointsComplexity.ItemLinks.Add(this.barCheckItem4);
            this.rpgPointsComplexity.Name = "rpgPointsComplexity";
            this.rpgPointsComplexity.Text = "Points Complexity";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "3";
            this.barCheckItem1.GroupIndex = 1;
            this.barCheckItem1.Id = 7;
            this.barCheckItem1.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.f3;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.Tag = 3;
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPointsComplexityChanged);
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.BindableChecked = true;
            this.barCheckItem2.Caption = "4";
            this.barCheckItem2.Checked = true;
            this.barCheckItem2.GroupIndex = 1;
            this.barCheckItem2.Id = 8;
            this.barCheckItem2.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.f4;
            this.barCheckItem2.Name = "barCheckItem2";
            this.barCheckItem2.Tag = 4;
            this.barCheckItem2.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPointsComplexityChanged);
            // 
            // barCheckItem3
            // 
            this.barCheckItem3.Caption = "6";
            this.barCheckItem3.GroupIndex = 1;
            this.barCheckItem3.Id = 9;
            this.barCheckItem3.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.f6;
            this.barCheckItem3.Name = "barCheckItem3";
            this.barCheckItem3.Tag = 6;
            this.barCheckItem3.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPointsComplexityChanged);
            // 
            // barCheckItem4
            // 
            this.barCheckItem4.Caption = "8";
            this.barCheckItem4.GroupIndex = 1;
            this.barCheckItem4.Id = 10;
            this.barCheckItem4.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.f8;
            this.barCheckItem4.Name = "barCheckItem4";
            this.barCheckItem4.Tag = 8;
            this.barCheckItem4.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPointsComplexityChanged);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Edit = null;
            this.barEditItem2.EditHeight = 60;
            this.barEditItem2.EditValue = 4;
            this.barEditItem2.EditWidth = 120;
            this.barEditItem2.Id = 11;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Edit = this.repositoryItemColorPickEdit1;
            this.barEditItem3.EditHeight = 20;
            this.barEditItem3.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.barEditItem3.EditWidth = 120;
            this.barEditItem3.Id = 2;
            this.barEditItem3.ItemAppearance.Hovered.Options.UseBorderColor = true;
            this.barEditItem3.ItemInMenuAppearance.Hovered.Options.UseBorderColor = true;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemColorPickEdit1
            // 
            this.repositoryItemColorPickEdit1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.repositoryItemColorPickEdit1.Appearance.Options.UseBackColor = true;
            this.repositoryItemColorPickEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemColorPickEdit1.AutomaticColor = System.Drawing.Color.Black;
            this.repositoryItemColorPickEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barListItem1
            // 
            this.barListItem1.Id = 4;
            this.barListItem1.Name = "barListItem1";
            // 
            // barListItem2
            // 
            this.barListItem2.Id = 5;
            this.barListItem2.Name = "barListItem2";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Edit = this.repositoryItemComboBox1;
            this.barEditItem4.EditValue = 32;
            this.barEditItem4.EditWidth = 100;
            this.barEditItem4.Id = 9;
            this.barEditItem4.ItemAppearance.Pressed.Options.UseBorderColor = true;
            this.barEditItem4.Name = "barEditItem4";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Id = 7;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Shapes color";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.LargeWidth = 90;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Shapes Color";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Color;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShapesColorItemClick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barCheckItem5);
            this.ribbonPageGroup3.ItemLinks.Add(this.barCheckItem6);
            this.ribbonPageGroup3.ItemLinks.Add(this.barCheckItem7);
            this.ribbonPageGroup3.ItemLinks.Add(this.barCheckItem8);
            this.ribbonPageGroup3.ItemLinks.Add(this.barCheckItem9);
            this.ribbonPageGroup3.ItemLinks.Add(this.barCheckItem10);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Point Density";
            // 
            // barCheckItem5
            // 
            this.barCheckItem5.Caption = " 24";
            this.barCheckItem5.GroupIndex = 2;
            this.barCheckItem5.Id = 8;
            this.barCheckItem5.ItemAppearance.Normal.Options.UseBorderColor = true;
            this.barCheckItem5.Name = "barCheckItem5";
            this.barCheckItem5.Tag = 24;
            this.barCheckItem5.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPointDensityChanged);
            // 
            // barCheckItem6
            // 
            this.barCheckItem6.Caption = " 92 ";
            this.barCheckItem6.GroupIndex = 2;
            this.barCheckItem6.Id = 9;
            this.barCheckItem6.Name = "barCheckItem6";
            this.barCheckItem6.Tag = 92;
            this.barCheckItem6.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPointDensityChanged);
            // 
            // barCheckItem7
            // 
            this.barCheckItem7.Caption = "192";
            this.barCheckItem7.GroupIndex = 2;
            this.barCheckItem7.Id = 10;
            this.barCheckItem7.Name = "barCheckItem7";
            this.barCheckItem7.Tag = 192;
            this.barCheckItem7.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPointDensityChanged);
            // 
            // barCheckItem8
            // 
            this.barCheckItem8.BindableChecked = true;
            this.barCheckItem8.Caption = " 56 ";
            this.barCheckItem8.Checked = true;
            this.barCheckItem8.GroupIndex = 2;
            this.barCheckItem8.Id = 11;
            this.barCheckItem8.Name = "barCheckItem8";
            this.barCheckItem8.Tag = 56;
            this.barCheckItem8.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPointDensityChanged);
            // 
            // barCheckItem9
            // 
            this.barCheckItem9.Caption = "128";
            this.barCheckItem9.GroupIndex = 2;
            this.barCheckItem9.Id = 12;
            this.barCheckItem9.Name = "barCheckItem9";
            this.barCheckItem9.Tag = 128;
            this.barCheckItem9.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPointDensityChanged);
            // 
            // barCheckItem10
            // 
            this.barCheckItem10.Caption = "256";
            this.barCheckItem10.GroupIndex = 2;
            this.barCheckItem10.Id = 13;
            this.barCheckItem10.Name = "barCheckItem10";
            this.barCheckItem10.Tag = 256;
            this.barCheckItem10.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPointDensityChanged);
            // 
            // PixelMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mapControl1);
            this.Name = "PixelMap";
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private XtraBars.Ribbon.RibbonPageGroup rpgPointsComplexity;
        private XtraBars.BarEditItem barEditItem1;
        private XtraBars.BarEditItem barEditItem2;
        private XtraBars.BarEditItem barEditItem3;
        private XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit1;
        private MapControl mapControl1;
        private XtraBars.BarCheckItem barCheckItem1;
        private XtraBars.BarCheckItem barCheckItem2;
        private XtraBars.BarCheckItem barCheckItem3;
        private XtraBars.BarCheckItem barCheckItem4;
        private XtraBars.BarEditItem barEditItem4;
        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private XtraBars.BarButtonItem barButtonItem1;
        private XtraBars.BarListItem barListItem1;
        private XtraBars.BarListItem barListItem2;
        private XtraBars.BarStaticItem barStaticItem1;
        private XtraBars.BarStaticItem barStaticItem2;
        private XtraBars.BarButtonItem barButtonItem2;
        private RibbonPageGroup ribbonPageGroup2;
        private VectorItemsLayer vectorItemsLayer1;
        private MapItemStorage mapItemStorage1;
        private VectorItemsLayer vectorItemsLayer2;
        private XtraBars.BarCheckItem barCheckItem5;
        private XtraBars.BarCheckItem barCheckItem6;
        private XtraBars.BarCheckItem barCheckItem7;
        private XtraBars.BarCheckItem barCheckItem8;
        private XtraBars.BarCheckItem barCheckItem9;
        private XtraBars.BarCheckItem barCheckItem10;
        private RibbonPageGroup ribbonPageGroup3;
    }
}
