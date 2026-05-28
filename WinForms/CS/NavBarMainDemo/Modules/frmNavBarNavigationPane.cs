using System;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraNavBar.Demos {
    /// <summary>
    /// Summary description for frmNavBarNavigationPane.
    /// </summary>
    public partial class frmNavBarNavigationPane : TutorialControl {
        public frmNavBarNavigationPane() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            navBarItem1.Tag = MailFilter.Inbox;
            navBarItem2.Tag = MailFilter.Outbox;
            navBarItem3.Tag = MailFilter.Sent;
            navBarItem4.Tag = MailFilter.Deleted;
            navBarItem5.Tag = MailFilter.Draft;
            outlookStyle1.MailFilter = DevExpress.XtraNavBar.Demos.MailFilter.Draft;
            treeList1.FocusedNodeChanged += TreeList1_FocusedNodeChanged;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        void TreeList1_FocusedNodeChanged(object sender, XtraTreeList.FocusedNodeChangedEventArgs e) {
            string action = e.Node.GetDisplayText(nameColumn);
            if("InboxOutboxDraftsSent ItemsDeleted Items".IndexOf(action) >= 0) {
                int selectedIndex = 0;
                NavBarGroup group = navBarGroup2;
                for(int i = 0; i < group.ItemLinks.Count; i++)
                    if(group.ItemLinks[i].Item.Caption == action) {
                        selectedIndex = i;
                        break;
                    }
                group.SelectedLinkIndex = selectedIndex;
                navBarItem_LinkClicked(navBarControl1, new NavBarLinkEventArgs(group.ItemLinks[selectedIndex]));
                action = "Mail";
            }
            for(int i = 0; i < navBarControl1.Groups.Count; i++)
                if(navBarControl1.Groups[i].Caption == action) {
                    ActiveGroupChanged(action, navBarControl1.Groups[i].LargeImageIndex);
                    ShowPanel(action);
                    break;
                }
        }

        void frmNavBarNavigationPane_Load(object sender, System.EventArgs e) {
            richTextBox1.LoadFile(ResourceImageHelper.FindStream("NavBarMainDemo.Modules.Description.rtf", System.Reflection.Assembly.GetExecutingAssembly()), RichTextBoxStreamType.RichText);
            InitControls();
            InitData();
        }
        void InitData() {
            gridControl1.DataSource = OutlookData.CreateTaskTable();
            gridControl2.DataSource = OutlookData.CreateNotesTable();
            gridControl3.DataSource = OutlookData.CreateJournalTable();
        }

        void InitControls() {
            int selectedIndex = 0;
            NavBarGroup activeGroup = navBarGroup2;
            navBarControl1.ActiveGroup = activeGroup;
            //litter1.LocationChanged += new EventHandler(splitter1_LocationChanged);
            activeGroup.SelectedLinkIndex = selectedIndex;
            navBarControl1_ActiveGroupChanged(navBarControl1, new NavBarGroupEventArgs(activeGroup));
            navBarItem_LinkClicked(navBarControl1, new NavBarLinkEventArgs(activeGroup.ItemLinks[selectedIndex]));
            navBarControl1.OptionsNavPane.AllowOptionsMenuItem = true;
        }
        void splitter1_LocationChanged(object sender, EventArgs e) {
            CheckNavPaneState();
        }
        bool isProcessingLayout = false;
        protected void CheckNavPaneState() {
            if(navBarControl1.OptionsNavPane.IsAnimationInProgress) return;
            if(!isProcessingLayout) {
                try {
                    if(navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Expanded) {
                        if(navBarControl1.Width < navBarControl1.OptionsNavPane.ExpandedWidth) {
                            isProcessingLayout = true;
                            navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed;
                            return;
                        }
                    }
                    if(navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Collapsed) {
                        if(navBarControl1.Width > navBarControl1.CalcCollapsedPaneWidth()) {
                            isProcessingLayout = true;
                            navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded;
                            return;
                        }
                    }
                }
                finally {
                    isProcessingLayout = false;
                }
            }
        }
        void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e) {
            var group = e.Group;
            if(group == null)
                return;
            ActiveGroupChanged(group.Caption, group.LargeImageIndex);
            if(group.Caption == "Folder List") {
                treeList1.FocusedNode = treeList1.Nodes[0];
                treeList1.ExpandAll();
            }
        }

        void ActiveGroupChanged(string caption, int index) {
            label1.Text = caption;
            pictureEdit1.SvgImage = svgImageCollection2[index];
            ShowPanel(caption);
        }

        void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            if(e.Link.Item.Tag != null)
                outlookStyle1.MailFilter = (MailFilter)e.Link.Item.Tag;
        }

        void ShowPanel(string caption) {
            foreach(Control c in pnlMain.Controls)
                if((c is Panel || c is XtraPanel) && c.Tag != null) {
                    c.Dock = DockStyle.Fill;
                    c.Visible = c.Tag.ToString() == caption;
                }
        }

        void button1_Click(object sender, System.EventArgs e) {
            if(textBox1.Text != "" || textBox2.Text != "")
                listBox1.Items.Add(textBox1.Text.Trim() + " " + textBox2.Text.Trim());
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            Data.Utils.SafeProcess.Start("www.devexpress.com");
        }

        void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e) {
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            row["Image"] = 0;
            row["Check"] = false;
            row["Date"] = TutorialConstants.Today;
        }
    }
}
