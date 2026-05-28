using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils.Helpers;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleBreadCrumbEdit : TutorialControl {
        string currentPath;
        RepositoryItemBreadCrumbEdit properties;
        public ModuleBreadCrumbEdit() {
            InitializeComponent();
            this.properties = BreadCrumb.Properties;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleBreadCrumbEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "breadCrumbEdit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitValues();
        }
        void InitValues() {
            BreadCrumb.Path = this.currentPath = DevExpress.Data.Utils.SafeEnvironment.Desktop;
            foreach(DriveInfo driveInfo in FileSystemHelper.GetFixedDrives()) {
                BreadCrumb.Properties.History.Add(new BreadCrumbHistoryItem(driveInfo.RootDirectory.ToString()));
            }
            this.cbeMode.Properties.Items.AddEnum(typeof(BreadCrumbMode));
            this.cbeMode.EditValue = this.properties.BreadCrumbMode;
            this.seDropDownRowCount.Value = this.properties.NodeDropDownRowCount;
            this.ceShowRootGlyph.Checked = this.properties.ShowRootGlyph;
            if(this.cbeImages.Properties.Items.Count > 0) this.cbeImages.SelectedIndex = 0;
        }
        // <breadCrumbEdit>
        void OnBreadCrumbPathChanged(object sender, BreadCrumbPathChangedEventArgs e) {
            this.currentPath = this.pathLabel.Text = e.Path;
            AddEventEntry("PathChanged", e.Path);
            UpdateControls();
        }
        void OnBreadCrumbNewNodeAdding(object sender, BreadCrumbNewNodeAddingEventArgs e) {
            AddEventEntry("NewNodeAdding", e.Node);
            e.Node.PopulateOnDemand = true;
        }
        void OnBreadCrumbQueryChildNodes(object sender, BreadCrumbQueryChildNodesEventArgs e) {
            AddEventEntry("QueryChildNodes", e.Node);
            if(e.Node.Caption == "Root") {
                InitBreadCrumbRootNode(e.Node);
                return;
            }
            if(e.Node.Caption == "Computer") {
                InitBreadCrumbComputerNode(e.Node);
                return;
            }
            string dir = e.Node.Path;
            if(!FileSystemHelper.IsDirExists(dir))
                return;
            string[] subDirs = FileSystemHelper.GetSubFolders(dir);
            for(int i = 0; i < subDirs.Length; i++) {
                e.Node.ChildNodes.Add(CreateNode(subDirs[i]));
            }
        }
        void OnBreadCrumbValidatePath(object sender, BreadCrumbValidatePathEventArgs e) {
            AddEventEntry("ValidatePath", e.Path);
            if(!FileSystemHelper.IsDirExists(e.Path)) {
                e.ValidationResult = BreadCrumbValidatePathResult.Cancel;
                return;
            }
            e.ValidationResult = BreadCrumbValidatePathResult.CreateNodes;
        }
        void OnBreadCrumbRootGlyphClick(object sender, EventArgs e) {
            AddEventEntry("RootGlyphClick", sender);
            BreadCrumb.Properties.BreadCrumbMode = BreadCrumbMode.Edit;
            BreadCrumb.SelectAll();
        }
        void OnBreadCrumbNodeClick(object sender, BreadCrumbNodeClickEventArgs e) {
            AddEventEntry("NodeClick", e.Node);
        }
        void OnBreadCrumbShowUserActionMenu(object sender, BreadCrumbShowUserActionMenuEventArgs e) {
            AddEventEntry("ShowUserActionMenu", sender);
        }
        void OnBreadCrumbShownNodeDropdown(object sender, BreadCrumbShownNodeDropDownEventArgs e) {
            AddEventEntry("ShownNodeDropdown", e.Node);
        }
        void OnBreadCrumbHiddenNodeDropDown(object sender, BreadCrumbHiddenNodeDropDownEventArgs e) {
            AddEventEntry("HiddenNodeDropDown", e.Node);
        }
        void OnBreadCrumbPathRejected(object sender, BreadCrumbPathRejectedEventArgs e) {
            AddEventEntry("PathRejected", e.Path);
        }
        void OnBreadCrumbSelectedNodeChanged(object sender, BreadCrumbSelectedNodeChangedEventArgs e) {
            AddEventEntry("SelectedNodeChanged", e.NewNode);
            this.selNodeValueLabel.Text = e.NewNode != null ? e.NewNode.ToString() : "(none)";
        }
        void OnBreadCrumbSelectorClientEmptySpaceClick(object sender, MouseEventArgs e) {
            AddEventEntry("SelectorClientEmptySpaceClick", e.Location);
        }
        void InitBreadCrumbRootNode(BreadCrumbNode node) {
            node.ChildNodes.Add(new BreadCrumbNode("Desktop", DevExpress.Data.Utils.SafeEnvironment.Desktop));
            node.ChildNodes.Add(new BreadCrumbNode("Documents", DevExpress.Data.Utils.SafeEnvironment.Recent));
            node.ChildNodes.Add(new BreadCrumbNode("Music", DevExpress.Data.Utils.SafeEnvironment.MyMusic));
            node.ChildNodes.Add(new BreadCrumbNode("Pictures", DevExpress.Data.Utils.SafeEnvironment.MyPictures));
            node.ChildNodes.Add(new BreadCrumbNode("Video", DevExpress.Data.Utils.SafeEnvironment.MyVideos));
            node.ChildNodes.Add(new BreadCrumbNode("Program Files", DevExpress.Data.Utils.SafeEnvironment.ProgramFiles));
            node.ChildNodes.Add(new BreadCrumbNode("Windows", DevExpress.Data.Utils.SafeEnvironment.Windows));
        }
        void InitBreadCrumbComputerNode(BreadCrumbNode node) {
            foreach(DriveInfo driveInfo in FileSystemHelper.GetFixedDrives()) {
                node.ChildNodes.Add(new BreadCrumbNode(driveInfo.Name, driveInfo.RootDirectory));
            }
        }
        BreadCrumbNode CreateNode(string path) {
            string folderName = FileSystemHelper.GetDirName(path);
            return new BreadCrumbNode(folderName, folderName, true);
        }
        // </breadCrumbEdit>
        // <btnClearEventLog>
        void OnClearEventLogClick(object sender, EventArgs e) {
            this.eventsLog.Text = string.Empty;
        }
        // </btnClearEventLog>
        // <cbeMode>
        void OnBreadCrumbModeChanged(object sender, EventArgs e) {
            if(properties == null) return;
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.properties.BreadCrumbMode = (BreadCrumbMode)comboBox.EditValue;
        }
        // </cbeMode>
        // <seDropDownRowCount>
        void OnBreadCrumbDropDownRowCountChanged(object sender, EventArgs e) {
            if(properties == null) return;
            SpinEdit spinEdit = (SpinEdit)sender;
            this.properties.NodeDropDownRowCount = (int)spinEdit.Value;
        }
        // </seDropDownRowCount>
        // <ceShowRootGlyph>
        void OnShowRootGlyphCheckedChanged(object sender, EventArgs e) {
            if(properties == null) return;
            CheckEdit checkEdit = (CheckEdit)sender;
            this.properties.ShowRootGlyph = checkEdit.Checked;
        }
        // </ceShowRootGlyph>
        // <cbeImages>
        void OnBreadCrumbSelectedIndexChanged(object sender, EventArgs e) {
            if(properties == null) return;
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            this.properties.RootImageIndex = this.properties.ImageIndex = comboBox.SelectedIndex;
        }
        // </cbeImages>
        // <btnGoUp>
        void OnGoUpClick(object sender, EventArgs e) {
            BreadCrumb.GoUp();
        }
        // </btnGoUp>
        // <btnGoBack>
        void OnGoBackClick(object sender, EventArgs e) {
            BreadCrumb.GoBack();
        }
        // </btnGoBack>
        // <btnGoForward>
        void OnGoForwardClick(object sender, EventArgs e) {
            BreadCrumb.GoForward();
        }
        // </btnGoForward>

        void AddEventEntry(string entry, object obj) {
            string val = string.Empty;
            if(obj != null) {
                val = (obj is BreadCrumbEdit) ? typeof(BreadCrumbEdit).Name : obj.ToString();
            }
            else {
                val = "(null)";
            }
            this.eventsLog.Text = string.Format("{0}: {1}{2}", entry, val, Environment.NewLine) + eventsLog.Text;
        }
        void UpdateControls() {
            this.btnGoBack.Enabled = BreadCrumb.CanGoBack;
            this.btnGoForward.Enabled = BreadCrumb.CanGoForward;
            this.btnGoUp.Enabled = BreadCrumb.CanGoUp;
        }
        BreadCrumbEdit BreadCrumb { get { return breadCrumbEdit; } }
    }
}
