using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;
using System.Drawing.Drawing2D;
using DevExpress.XtraEditors.TableLayout;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("TileView Custom painting", "TileViewCustomPainting.cs")]
    public static class TileViewCustomPainting {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            var tileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            tileView.OptionsTiles.ItemSize = new Size(144, 144);
            tileView.OptionsTiles.RowCount = 2;
            tileView.OptionsTiles.ItemPadding = new Padding(16);
            tileView.OptionsTiles.AllowItemHover = true;
            gridControl.MainView = tileView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(6);

            tileView.TileRows.Add(new TableRowDefinition());
            tileView.TileRows.Add(new TableRowDefinition());
            tileView.TileRows[0].AutoHeight = true;
            tileView.TileRows[0].PaddingBottom = 8;
            var tileElementName = new TileViewItemElement();
            var tileElementDesc = new TileViewItemElement();
            tileView.TileTemplate.Add(tileElementName);
            tileView.TileTemplate.Add(tileElementDesc);
            tileElementName.Column = tileView.Columns["Name"];
            tileElementName.TextAlignment = TileItemContentAlignment.MiddleLeft;
            tileElementName.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
            tileElementDesc.Column = tileView.Columns["Notes"];
            tileElementDesc.TextAlignment = TileItemContentAlignment.TopLeft;
            tileElementDesc.RowIndex = 1;

            return new object[] { gridControl, tileView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }

        #region CustomPainting
        [CodeExampleCase("CustomDrawTile"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawTile")]
        public static void CustomDrawTile(GridControl gridControl, DevExpress.XtraGrid.Views.Tile.TileView tileView) {
            Func<Rectangle, int, GraphicsPath> RoundedRect = (bounds, radius) => {
                int diameter = radius * 2;
                Size size = new Size(diameter, diameter);
                Rectangle arc = new Rectangle(bounds.Location, size);
                GraphicsPath path = new GraphicsPath();
                path.AddArc(arc, 180, 90);
                arc.X = bounds.Right - diameter;
                path.AddArc(arc, 270, 90);
                arc.Y = bounds.Bottom - diameter;
                path.AddArc(arc, 0, 90);
                arc.X = bounds.Left;
                path.AddArc(arc, 90, 90);
                path.CloseFigure();
                return path;
            };

            // Handle the CustomDrawTile event to paint tiles manually. The following code draws tiles with rounded corners:
            const int tileCornerRadius = 16;
            const int selectionCornerRadius = 18;
            tileView.CustomDrawTile += (s, e) => {
                if(e.DrawingProcess == TileViewItemCustomDrawProcess.DrawTile) {                    
                    if(e.ShouldDrawBackground) {
                        e.Cache.FillRectangle(e.TileViewEmptySpaceBackColor, e.Bounds);
                        var r = e.Bounds;
                        r.Inflate(-2, -2);
                        e.Cache.FillPath(e.Appearance.GetBackBrush(e.Cache), RoundedRect(r, tileCornerRadius));
                    }
                    if(e.ShouldDrawContent) {
                        e.DrawContent();
                    }
                    if(e.ShouldDrawHoveredOverlay) {
                        e.DrawHoveredOverlay();
                    }
                    if(e.ShouldDrawDisabledOverlay) {
                        e.DrawDisabledOverlay();
                    }
                    if(e.ShouldDrawBorder) {
                        e.Cache.SmoothingMode = SmoothingMode.HighQuality;
                        var r = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 3, e.Bounds.Height - 3);
                        e.Cache.DrawPath(e.Appearance.GetBorderPen(e.Cache), RoundedRect(r, tileCornerRadius));
                        e.Cache.SmoothingMode = SmoothingMode.Default;
                    }
                    if(e.ShouldDrawCheckMark) {
                        e.DrawCheckMark();
                    }
                    e.Cache.SmoothingMode = SmoothingMode.Default;
                }
                else if(e.DrawingProcess == TileViewItemCustomDrawProcess.DrawSelection) {
                    e.Cache.SmoothingMode = SmoothingMode.HighQuality;
                    var r = e.DefaultSelectionBounds;
                    r.Inflate(-1, -1);
                    e.Cache.DrawPath(new Pen(e.DefaultSelectionColor, e.DefaultSelectionWidth), RoundedRect(r, selectionCornerRadius));
                    e.Cache.SmoothingMode = SmoothingMode.Default;
                }
                else
                    e.DefaultDraw();
                e.Handled = true;
            };
        }
        #endregion
    }
}
