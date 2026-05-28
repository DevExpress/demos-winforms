using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.XtraDialogs.FileExplorerExtensions;

namespace DevExpress.XtraDialogs.Demos {
    public partial class CustomDialogLayout : TutorialControl {
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { WhatsThisXMLFileName }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "CustomDialogLayout"; }
        }
        readonly GridControlExtension listView;
        readonly BreadCrumbExtension breadCrumb;
        readonly PreviewPanelExtension preview;

        public CustomDialogLayout() {
            InitializeComponent();
            string initialPath = Path.GetDirectoryName(DataDirectoryHelper.GetDataFile("DemoText.txt"));
            btnOpenFile.Appearance.Options.UseBackColor = true;
            if(!fileExplorerAssistant.IsDesignMode) {
                preview = fileExplorerAssistant.Attach(panelControl);
                //<gridControl>
                listView = fileExplorerAssistant.Attach(gridControl);
                listView.FocusedLinkChanged += OnListViewFocusedLinkChanged;
                listView.SelectionChanged += OnListViewSelectionChanged;
                listView.CurrentItemChanged += OnListViewCurrentItemChanged;
                //</gridControl>
                listView.AllowGoBackChanged += OnUpdateNavigationButtons;
                listView.AllowGoForwardChanged += OnUpdateNavigationButtons;
                listView.AllowGoUpChanged += OnUpdateNavigationButtons;
                //<currentPathEdit>
                breadCrumb = fileExplorerAssistant.Attach(currentPathEdit, x => {
                    x.CurrentItemChanged += OnCurrentPathEditCurrentItemChanged;
                });
                //</currentPathEdit>
                //<treeList>
#pragma warning disable DX0019
                fileExplorerAssistant.Attach(treeList, x => {
                    x.RootNodes.Add(new EnvironmentSpecialFolderNode(Environment.SpecialFolder.MyComputer));
                    x.CurrentItemChanged += OnTreeCurrentItemChanged;
                });
#pragma warning restore DX0019
                //</treeList>
                listView.SetCurrentPath(initialPath);
                btnOpenFile.Enabled = false;
            }
        }
        void OnUpdateNavigationButtons(object sender, EventArgs e) {
            btnUp.Enabled = listView.CanGoUp;
            btnBack.Enabled = listView.CanGoBack;
            btnForward.Enabled = listView.CanGoForward;
        }
        //<gridControl>
        void OnListViewSelectionChanged(object sender, SelectionChangedEventArgs e) {
            var previewItem = e.Selection.Count > 0 ? e.Selection.Last() : null;
            preview.SetCurrentItem(previewItem);
        }
        void OnListViewFocusedLinkChanged(object sender, FocusedLinkChangedEventArgs e) {
            if(e.FocusedLink != null && e.FocusedLink.Extension == ".txt") {
                fileNameEdit.Tag = e.FocusedLink.FullPath;
                fileNameEdit.Text = e.FocusedLink.Identifier;
                btnOpenFile.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            }
            else {
                fileNameEdit.Tag = null;
                fileNameEdit.Text = null;
                btnOpenFile.Appearance.Reset();
            }
            btnOpenFile.Enabled = fileNameEdit.Tag is string;
        }
        void OnListViewCurrentItemChanged(object sender, CurrentItemChangedEventArgs e) {
            breadCrumb.SetCurrentItem(e.CurrentItem);
        }
        //</gridControl>
        //<treeList>
        void OnTreeCurrentItemChanged(object sender, CurrentItemChangedEventArgs e) {
            listView.SetCurrentItem(e.CurrentItem);
        }
        //</treeList>
        //<currentPathEdit>
        void OnCurrentPathEditCurrentItemChanged(object sender, CurrentItemChangedEventArgs e) {
            listView.SetCurrentItem(e.CurrentItem);
        }
        //</currentPathEdit>
        void btnBack_Click(object sender, EventArgs e) {
            listView.GoBack();
        }
        void btnForward_Click(object sender, EventArgs e) {
            listView.GoForward();
        }
        void btnUp_Click(object sender, EventArgs e) {
            listView.GoUp();
        }
        void btnOpenFile_Click(object sender, EventArgs e) {
            var path = (string)fileNameEdit.Tag;
            if(System.IO.File.Exists(path))
                DevExpress.Data.Utils.SafeProcess.Open(path);
        }
    }
}
