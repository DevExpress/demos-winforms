using System;
using System.Windows.Forms;
using DevExpress.Dialogs.Core.Items;
using DevExpress.XtraDialogs.FileExplorerExtensions;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraDialogs.Demos {
    public partial class TwoPanelFileBrowser : TutorialControl {
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { WhatsThisXMLFileName }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "TwoPanelFileBrowser"; }
        }
        public TwoPanelFileBrowser() {
            InitializeComponent();
            if(!fileExplorerAssistant.IsDesignMode) {
                //<currentPathEdit>
                var breadCrumb = fileExplorerAssistant.Attach(currentPathEdit, x => {
                    x.CurrentPath = @"c:\";
                    x.CurrentItemChanged += OnBreadCrumbCurrentItemChanged;
                });
                //</currentPathEdit>
                //<leftGrid>
                var left = fileExplorerAssistant.Attach(leftGrid, x => {
                    x.CurrentPath = @"c:\";
                });
                //</leftGrid>
                //<rightGrid>
                var right = fileExplorerAssistant.Attach(rightGrid, x => {
                    x.CurrentPath = @"c:\";
                });
                activeExtension = left;
                //</rightGrid>

                // Setup dependencies between controls and extensions
                SetupPanel(left, breadCrumb, right);
                SetupPanel(right, breadCrumb, left);
                SetupSearchBox(leftGrid);
            }
        }
        int lockCurrentItemChange = 0;
        void OnBreadCrumbCurrentItemChanged(object sender, CurrentItemChangedEventArgs e) {
            if(lockCurrentItemChange != 0) 
                return;
            lockCurrentItemChange++;
            if(activeExtension != null)
                activeExtension.SetCurrentItem(e.CurrentItem);
            lockCurrentItemChange--;
        }
        GridControlExtension activeExtension;
        void SetupPanel(GridControlExtension source, BreadCrumbExtension breadCrumb, GridControlExtension target) {
            SetupGridView(source, breadCrumb, target);
            source.FocusedLinkChanged += (s, e) => {
                UpdateButtons();
                UpdateActionButtons();
            };
            source.CurrentItemChanged += (s, e) => {
                lockCurrentItemChange++;
                breadCrumb.SetCurrentItem(e.CurrentItem);
                lockCurrentItemChange--;
            };
        }
        void SetupSearchBox(GridControl gridControl) {
            searchBox.QueryIsSearchColumn += (s, e) => {
                e.IsSearchColumn = (e.FieldName == "Name");
            };
            searchBox.PreviewKeyDown += (s, e) => {
                if(e.KeyCode == Keys.Tab)
                    activeExtension.Control.MainView.Focus();
            };
            searchBox.Client = gridControl;
        }
        void SetupGridView(GridControlExtension source, BreadCrumbExtension breadCrumb, GridControlExtension target) {
            var gridView = ((GridView)source.Control.MainView);
            source.SelectionChanged += (s, e) => {
                UpdateActionButtons();
            };
            gridView.GotFocus += (s, e) => {
                activeExtension = source;
                lockCurrentItemChange++;
                breadCrumb.SetCurrentItem(source.CurrentItem);
                lockCurrentItemChange--;
                searchBox.Client = source.Control;
                UpdateButtons();
                UpdateActionButtons();
            };
            //<leftGrid>
            gridView.KeyDown += (s, e) => {
                switch(e.KeyCode) {
                    case Keys.Tab:
                        ToggleActivePanel();
                        break;
                    case Keys.F3:
                        source.DoDefaultAction();
                        break;
                    case Keys.F4:
                        source.Rename();
                        break;
                    case Keys.F5:
                        source.CopySelection(target.CurrentItem);
                        break;
                    case Keys.F6:
                        source.MoveSelection(target.CurrentItem);
                        break;
                    case Keys.F7:
                        source.CreateNewFolder();
                        break;
                    case Keys.Delete:
                    case Keys.F8:
                        source.DeleteSelection();
                        break;
                }
            };
            //<rightGrid>
        }
        void ToggleActivePanel() {
            if(leftGrid.ContainsFocus)
                rightGrid.Focus();
            else
                leftGrid.Focus();
        }
        void OnBack(object sender, EventArgs e) {
            activeExtension.GoBack();
        }
        void OnForward(object sender, EventArgs e) {
            activeExtension.GoForward();
        }
        void OnUp(object sender, EventArgs e) {
            activeExtension.GoUp();
        }
        void OnOpen(object sender, EventArgs e) {
            activeExtension.DoDefaultAction();
        }
        void OnRename(object sender, EventArgs e) {
            activeExtension.Rename();
        }
        void OnCopy(object sender, EventArgs e) {
            activeExtension.CopySelection(GetTarget());
        }
        void OnMove(object sender, EventArgs e) {
            activeExtension.MoveSelection(GetTarget());
        }
        void OnNewFolder(object sender, EventArgs e) {
            activeExtension.CreateNewFolder();
        }
        void OnDelete(object sender, EventArgs e) {
            activeExtension.DeleteSelection();
        }
        ShellItem GetTarget() {
            var left = fileExplorerAssistant.Extensions[leftGrid] as GridControlExtension;
            if(!ReferenceEquals(activeExtension, left))
                return left.CurrentItem;
            return (fileExplorerAssistant.Extensions[rightGrid] as GridControlExtension).CurrentItem;
        }
        //<sidePanelTop>
        void UpdateButtons() {
            btnUp.Enabled = activeExtension.CanGoUp;
            btnBack.Enabled = activeExtension.CanGoBack;
            btnForward.Enabled = activeExtension.CanGoForward;
        }
        //</sidePanelTop>
        //</sidePanelBottom>
        void UpdateActionButtons() {
            btnRename.Enabled = activeExtension.CanRename;
            btnCopy.Enabled = activeExtension.CanCopySelection;
            btnMove.Enabled = activeExtension.CanMoveSelection;
            btnNewFolder.Enabled = activeExtension.CanCreateNewFolder;
            btnDelete.Enabled = activeExtension.CanDeleteSelection;
        }
        //</sidePanelBottom>
    }
}
