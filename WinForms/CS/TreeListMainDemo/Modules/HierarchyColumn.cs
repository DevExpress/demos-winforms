using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Demos;
using DevExpress.Utils;
using DevExpress.XtraEditors.Annotations;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Painter;

namespace DevExpress.XtraTreeList.Demos {
    public partial class HierarchyColumn : TutorialControl {
        enum NodeMenuItemID {
            Indent = 6, Outdent = 7
        }
        public override TreeList MainControl {
            get { return treeList1; }
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "TreeListMainDemo\\Modules\\HierarchyColumn", "TreeListMainDemo\\Options\\ucScrollAnnotationsOptions" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "HierarchyColumn"; }
        }
        public HierarchyColumn() {
            InitializeComponent();
            treeList1.DataSource = TaskGenerator.Default.GenerateSource(400);
            treeList1.ExpandAll();
            repositoryItemPriorityComboBox.AddImages(svgImageCollection);
            repositoryItemDescriptionComboBox.Items.Add("", true, 3);
            repositoryItemCompletedComboBox.Items.Add("", true, 2);
            treeList1.MouseDown += OnMouseDown;
            treeList1.NodeCellStyle += OnNodeCellStyle;
            treeList1.ScrollAnnotationsStyle += OnScrollAnnotationsStyle;
            treeList1.PopupMenuShowing += OnPopupMenuShowing;
            ucScrollAnnotationsOptions.InitData(treeList1);
            treeList1.ClearSelection();
            treeList1.ApplyFindFilter("QA");
        }
        void OnScrollAnnotationsStyle(object sender, TreeListScrollAnnotationsStyleEventArgs e) {
            var styleColor = ucScrollAnnotationsOptions.GetColor(e.Kind);
            if(!styleColor.IsEmpty)
                e.Color = styleColor;
        }
        void OnPopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.Menu is DevExpress.XtraTreeList.Menu.TreeListNodeMenu) {
                AddItem(e.Menu, NodeMenuItemID.Indent, treeList1.CanIndentNodes(treeList1.Selection));
                AddItem(e.Menu, NodeMenuItemID.Outdent, treeList1.CanOutdentNodes(treeList1.Selection));
                e.Allow = true;
            }
        }
        void AddItem(TreeListMenu menu, NodeMenuItemID id, bool enabled) {
            DevExpress.Utils.Menu.DXMenuItem _item = new Utils.Menu.DXMenuItem(id.ToString());
            _item.Tag = id;
            _item.ImageOptions.SvgImage = svgImageCollection[(int)id];
            _item.Enabled = enabled;
            _item.Click += OnMenuItemClick;
            menu.Items.Add(_item);
        }
        void OnMenuItemClick(object sender, System.EventArgs e) {
            var _item = sender as DevExpress.Utils.Menu.DXMenuItem;
            if((NodeMenuItemID)_item.Tag == NodeMenuItemID.Indent)
                treeList1.IndentNodes(treeList1.Selection, false);
            if((NodeMenuItemID)_item.Tag == NodeMenuItemID.Outdent)
                treeList1.OutdentNodes(treeList1.Selection, false);
        }
        void OnNodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e) {
            EmployeeTask task = treeList1.GetRow(e.Node.Id) as EmployeeTask;
            if(task == null || !task.IsCompleted)
                return;
            e.Appearance.FontStyleDelta = (FontStyle.Italic | FontStyle.Strikeout);
        }
        void OnMouseDown(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left)
                return;
            var hitInfo = treeList1.CalcHitInfo(e.Location);
            if(hitInfo.InRowCell && hitInfo.Column == descriptionColumn) {
                EmployeeTask task = treeList1.GetRow(hitInfo.Node.Id) as EmployeeTask;
                if(task != null && task.HasDescription)
                    ToolTipController.DefaultController.ShowHint(task.Description, ToolTipLocation.RightCenter);
            }
        }
        Utils.Design.ISvgPaletteProvider GetPalette() {
            return Utils.Svg.SvgPaletteHelper.GetSvgPalette(treeList1.LookAndFeel, Utils.Drawing.ObjectState.Normal);
        }
        // Addding bookmark items
        //<treeList1>
        readonly HashSet<int> bookmarks = new HashSet<int>() { 5, 17, 74 };
        void OnCustomScrollAnnotation(object sender, TreeListCustomScrollAnnotationsEventArgs e) {
            TreeListNode[] rowHandles = bookmarks.Select(x => treeList1.FindNodeByID(x)).ToArray();
            e.SetAnnotations(DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue, rowHandles);
        }
        void OnCustomDrawRowIndicator(object sender, CustomDrawNodeIndicatorEventArgs e) {
            if(e.Node == null || treeList1.IsAutoFilterNode(e.Node))
                return;
            if(e.Info.ImageIndex == TreeListPainter.ErrorInNodeIndicatorImageIndex ||
            e.Info.ImageIndex == TreeListPainter.ErrorInFocusedNodeIndicatorImageIndex) {
                // suppress error indicator
                e.Info.ImageIndex = -1;
            }
            if(!ucScrollAnnotationsOptions.BookmarksEnabled || !bookmarks.Contains(e.Node.Id))
                return;
            e.DefaultDraw();
            var bookmarkImage = svgImageCollection.GetImage("bookmark", GetPalette(), ScaleDPI.ScaleSize(new Size(8, 8)));
            var imageBounds = PlacementHelper.Arrange(bookmarkImage.Size, e.Bounds, ContentAlignment.MiddleLeft);
            e.Cache.DrawImageUnscaled(bookmarkImage, imageBounds);
            e.Handled = true;
        }
        // Bookmark items navigation
        void OnKeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == (Keys.F2 | Keys.Control) || e.KeyData == (Keys.B | Keys.Control))
                e.Handled = ToggleBookmark(treeList1.FocusedNode);
            // navigating via shortcuts
            if(e.KeyData == Keys.F2)
                e.Handled = treeList1.MoveToNextScrollAnnotation(ScrollAnnotationKind.Custom);
            if(e.KeyData == (Keys.F2 | Keys.Shift))
                e.Handled = treeList1.MoveToPrevScrollAnnotation(ScrollAnnotationKind.Custom);
        }
        bool ToggleBookmark(TreeListNode node) {
            int dataIndex = node != null ? node.Id : -1;
            if(dataIndex < 0)
                return false;
            if(!bookmarks.Remove(dataIndex))
                bookmarks.Add(dataIndex);
            treeList1.RefreshScrollAnnotations(ScrollAnnotationKind.Custom);
            treeList1.InvalidateNode(node);
            return true;
        }
        //</treeList1>
        #region Export
        public override bool AllowPrintOptions {
            get { return true; }
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }
        #endregion Export
    }
}
