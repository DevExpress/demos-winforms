using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.DXperience.Demos.CodeDemo.Helpers;
using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TableLayout;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;
using DevExpress.XtraTreeList;

namespace DevExpress.HTML.Demos.CodeExamples {
    [CodeExampleClass("ListBox control", "CustomDraw.cs")]
    public static class CustomDraw_ListBoxControl {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var panel = new PanelControl();
            panel.Padding = new Padding(64);
            panel.Dock = DockStyle.Fill;
            panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panel.Parent = sampleHost;

            var resetButton = new SimpleButton();
            resetButton.Text = "Remove ListBox items";
            resetButton.Dock = DockStyle.Bottom;
            resetButton.Visible = false;
            resetButton.Parent = panel;

            var listControl = new ListBoxControl();
            listControl.Dock = DockStyle.Fill;
            listControl.Parent = panel;

            resetButton.Click += (s, e) => {
                listControl.Items.Clear();
            };
            listControl.Items.ListChanged += (s, e) => {
                resetButton.Visible = listControl.ItemCount > 0;
            };

            return new object[] { listControl };
        }

        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }

        [CodeExampleCase("The CustomDrawEmptyForeground event")]
        [HtmlFile("CustomDraw.ListBoxEmptyForeground"), CssFile("CustomDraw.ListBoxEmptyForeground"), CodeExampleUnderlineTokens("CustomDrawEmptyForeground")]
        public static void CustomDrawEmptyForeground(ListBoxControl listControl) {
            // local painting context which contains html tree state
            DxHtmlPainterContext ctx = new DxHtmlPainterContext();
            // handle html-template painting
            HtmlTemplate htmlTemplate = new HtmlTemplate(Loader.Load("ListBoxEmptyForeground.html"), Loader.Load("ListBoxEmptyForeground.css"));
            listControl.CustomDrawEmptyForeground += (s, e) => {
                e.DrawHtml(htmlTemplate, ctx);
            };
            // handle UI feedback (hover/cursor)
            listControl.MouseMove += (s, e) => {
                if(listControl.ItemCount == 0) {
                    ctx.OnMouseMove(e);
                    listControl.Cursor = ctx.GetCursor(e.Location);
                    listControl.Invalidate();
                }
                else listControl.Cursor = Cursors.Default;
            };
            // handle Click within the btnAdd element
            var items = Enumerable.Range(1, 10)
                .Select(n => string.Format("Item #{0:d2}", n))
                .ToArray();
            listControl.MouseDown += (s, e) => {
                if(listControl.ItemCount == 0 && e.Button == MouseButtons.Left) {
                    var clickInfo = ctx.CalcHitInfo(e.Location);
                    if(clickInfo != null && clickInfo.HasId("btnAdd"))
                        listControl.Items.AddRange(items);
                }
            };
        }
    }

    [CodeExampleClass("Grid control", "CustomDraw.cs")]
    public static class CustomDraw_GridControl {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(6);
            return new object[] { gridControl };
        }

        [CodeExampleCase("The CustomDrawRowPreview event")]
        [HtmlFile("CustomDraw.GridViewRowPreview"), CssFile("CustomDraw.GridViewRowPreview"), SampleDataCS]
        [CodeExampleUnderlineTokens("CustomDrawRowPreview")]
        public static void CustomDrawRowPreview(GridControl gridControl) {
            // configure GridView
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridView.Columns["Notes"].Visible = false;
            gridView.OptionsView.ShowPreview = true;
            gridView.PreviewLineCount = 2;

            // local painting context which contains html tree state
            DxHtmlPainterContext ctx = new DxHtmlPainterContext();
            // handle html-template painting
            HtmlTemplate htmlTemplate = new HtmlTemplate(Loader.Load("GridViewRowPreview.html"), Loader.Load("GridViewRowPreview.css"));
            gridView.CustomDrawRowPreview += (s, e) => {
                int index = (s as GridView).GetDataSourceRowIndex(e.RowHandle);
                e.DrawHtml(htmlTemplate, ctx, (args) => args.InteractivityKey = index);
                e.Handled = true;
            };
            // handle UI feedback (hover/cursor)
            gridView.MouseMove += (s, e) => {
                GridView view = s as GridView;
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
                if(hitInfo.RowHandle >= 0) {
                    int index = view.GetDataSourceRowIndex(hitInfo.RowHandle);
                    ctx.OnMouseMove(e, index);
                    view.GridControl.Cursor = ctx.GetCursor(e.Location, index);
                    view.InvalidateRow(hitInfo.RowHandle);
                }
            };
            // handle Click within the link element
            gridView.MouseDown += (s, e) => {
                GridView view = s as GridView;
                GridHitInfo rowHitInfo = view.CalcHitInfo(e.Location);
                if(rowHitInfo.RowHandle >= 0) {
                    int index = view.GetDataSourceRowIndex(rowHitInfo.RowHandle);
                    DxHtmlHitInfo htmlHitInfo = ctx.CalcHitInfo(e.Location, index);
                    if(htmlHitInfo != null && htmlHitInfo.HasClassName("link")) {
                        string name = (string)view.GetRowCellValue(rowHitInfo.RowHandle, "Name");
                        ctx.OnMouseLeave(e, index);
                        XtraMessageBox.Show("Getting information about " + name + "...");
                    }
                }
            };
        }

        [CodeExampleCase("The TileView's CustomDrawTile event")]
        [HtmlFile("CustomDraw.TileViewItem"), CssFile("CustomDraw.TileViewItem"), SampleDataCS]
        [CodeExampleUnderlineTokens("CustomDrawTile")]
        public static void CustomDrawTile(GridControl gridControl) {
            // create TileView
            TileView tileView = new TileView();
            gridControl.MainView = tileView;            

            // local painting context which contains html tree state
            DxHtmlPainterContext ctx = new DxHtmlPainterContext();
            // handle html-template painting
            HtmlTemplate htmlTemplate = new HtmlTemplate(Loader.Load("TileViewItem.html"), Loader.Load("TileViewItem.css"));
            tileView.CustomDrawTile += (s, e) => {
                SampleData obj = tileView.GetRow(e.RowHandle) as SampleData;
                if(obj.Mark) {
                    if(e.DrawingProcess == TileViewItemCustomDrawProcess.DrawTile) {
                        e.DrawBackground();                        
                        e.DrawHtml(htmlTemplate, ctx, (args) => args.InteractivityKey = obj.ID);
                        e.DrawBorder();
                        e.Handled = true;
                    }
                }                
            };
            // handle UI feedback (hover/cursor)
            tileView.MouseMove += (s, e) => {
                TileView view = s as TileView;
                TileViewHitInfo hitInfo = view.CalcHitInfo(e.Location);
                if(hitInfo.RowHandle >= 0) {
                    SampleData obj = tileView.GetRow(hitInfo.RowHandle) as SampleData;
                    if(obj.Mark) {
                        ctx.OnMouseMove(e, obj.ID);
                        view.GridControl.Cursor = ctx.GetCursor(e.Location, obj.ID);
                        view.InvalidateRect(hitInfo.ItemInfo.Bounds);
                    }
                    else
                        view.GridControl.Cursor = Cursors.Default;
                }
            };
            // handle Click within the link element
            tileView.MouseDown += (s, e) => {
                TileView view = s as TileView;
                TileViewHitInfo hitInfo = view.CalcHitInfo(e.Location);
                if(hitInfo.RowHandle >= 0) {
                    SampleData obj = tileView.GetRow(hitInfo.RowHandle) as SampleData;
                    if(obj.Mark) {
                        DxHtmlHitInfo htmlHitInfo = ctx.CalcHitInfo(e.Location, obj.ID);
                        if(htmlHitInfo != null && htmlHitInfo.HasClassName("show-action")) {
                            obj.Mark = false;
                            ctx.OnMouseLeave(e, obj.ID);
                            view.InvalidateRect(hitInfo.ItemInfo.Bounds);
                        }
                        (e as DXMouseEventArgs).Handled = true;
                    }
                }
            };

            // configure TileTemplate
            tileView.OptionsTiles.RowCount = 2;
            tileView.OptionsTiles.ItemSize = new System.Drawing.Size(180, 100);
            var tileElementName = new TileViewItemElement() { Column = tileView.Columns["Name"] };
            var tileElementDesc = new TileViewItemElement() { Column = tileView.Columns["Notes"] };
            tileView.TileTemplate.Add(tileElementName);
            tileView.TileTemplate.Add(tileElementDesc);
            tileElementName.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
            tileElementDesc.AnchorElement = tileElementName;
            tileElementDesc.AnchorIndent = 5;
            tileElementDesc.MaxLineCount = 5;
        }
    }

    [CodeExampleClass("TreeList control", "CustomDraw.cs")]
    public static class CustomDraw_TreeList {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var treeList = new DevExpress.XtraTreeList.TreeList();
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.LoadData();
            treeList.ExpandToLevel(0);
            return new object[] { treeList };
        }

        [CodeExampleCase("The CustomDrawRowPreview event")]
        [HtmlFile("CustomDraw.TreeListRowPreview"), CssFile("CustomDraw.TreeListRowPreview"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("CustomDrawNodePreview")]
        public static void CustomDrawRowPreview(TreeList treeList) {
            // configure Preview section
            treeList.Columns["Notes"].Visible = false;
            treeList.OptionsView.ShowPreview = true;
            treeList.PreviewFieldName = "Notes";
            treeList.PreviewLineCount = 2;

            // local painting context which contains html tree state
            DxHtmlPainterContext ctx = new DxHtmlPainterContext();
            // handle html-template painting
            HtmlTemplate htmlTemplate = new HtmlTemplate(Loader.Load("TreeListRowPreview.html"), Loader.Load("TreeListRowPreview.css"));
            treeList.CustomDrawNodePreview += (s, e) => {
                e.DrawHtml(htmlTemplate, ctx, (args) => args.InteractivityKey = e.Node.Id);
                e.Handled = true;
            };
            // handle UI feedback (hover/cursor)
            treeList.MouseMove += (s, e) => {
                TreeList control = s as TreeList;
                TreeListHitInfo hitInfo = control.CalcHitInfo(e.Location);
                if(hitInfo.Node != null) {
                    ctx.OnMouseMove(e, hitInfo.Node.Id);
                    control.Cursor = ctx.GetCursor(e.Location, hitInfo.Node.Id);
                    control.InvalidateRowPreview(hitInfo.Node);
                }
            };
            // handle Click within the link element
            treeList.MouseDown += (s, e) => {
                TreeList control = s as TreeList;
                TreeListHitInfo hitInfo = control.CalcHitInfo(e.Location);
                if(hitInfo.Node != null) {
                    DxHtmlHitInfo htmlHitInfo = ctx.CalcHitInfo(e.Location, hitInfo.Node.Id);
                    if(htmlHitInfo != null && htmlHitInfo.HasClassName("link")) {
                        string name = (string)control.GetRowCellValue(hitInfo.Node, "Name");
                        ctx.OnMouseLeave(e, hitInfo.Node.Id);
                        XtraMessageBox.Show("Getting information about " + name + "...");
                    }
                }
            };
        }
    }
}
