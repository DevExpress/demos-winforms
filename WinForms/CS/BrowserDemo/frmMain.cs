using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.BrowserDemo {
    public partial class frmMain : TabForm {
        public frmMain()
            : this(true) { }
        public frmMain(bool hasPage) {
            InitializeComponent();
            Initialize(hasPage);
        }
        protected void Initialize(bool shouldCreateWebBrowser) {
            this.shouldInitHomePage = shouldCreateWebBrowser;
            if(shouldCreateWebBrowser) {
                CreatePageWebBrowser(TabFormControl.SelectedPage);
                SubscribeOnPageEvents();
            }
            else {
                TabFormControl.Pages.Clear();
                TabFormControl.SelectedPage = null;
            }
            TabFormControl.SelectedPageChanged += OnSelectedPageChanged;
            TabFormControl.SelectedPageChanging += OnSelectedPageChanging;
            TabFormControl.PageCreated += OnPageCreated;
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("BrowserDemo.AppIcon.ico", typeof(frmMain).Assembly);
            barManager1.ForceLinkCreate();
            barManager1.GetController().Changed += new EventHandler(ChangedController);
            InitSkins();
            this.Focus();
        }
        void OnPageCreated(object sender, PageCreatedEventArgs e) {
            if(HidePageCaption) e.Page.Text = string.Empty;
            CreatePageWebBrowser(e.Page);
        }
        void CreatePageWebBrowser(TabFormPage page) {
            TabFormWebBrowser browser = new TabFormWebBrowser(page);
            page.ContentContainer.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browser.ScriptErrorsSuppressed = true;
            page.ContentContainer.Controls.Add(new BrowserNavigationControl());
        }
        void OnSelectedPageChanging(object sender, TabFormSelectedPageChangingEventArgs e) {
            UnsubscribeOnPageEvents();
        }
        void OnSelectedPageChanged(object sender, TabFormSelectedPageChangedEventArgs e) {
            SubscribeOnPageEvents();
            if(NavigationPanel == null) return;
            if(WebBrowser == null || WebBrowser.Url == null)
                NavigationPanel.SearchItem.EditValue = string.Empty;
            else NavigationPanel.SearchItem.EditValue = WebBrowser.Url.AbsoluteUri;
            CheckButtons();
        }
        void CheckButtons() {
            NavigationPanel.ForwardButton.Enabled = WebBrowser.CanGoForward;
            NavigationPanel.BackButton.Enabled = WebBrowser.CanGoBack;
        }
        void SubscribeOnPageEvents() {
            if(WebBrowser != null) {
                WebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
                WebBrowser.CanGoBackChanged += new EventHandler(OnWebBrowserCanGoBackChanged);
                WebBrowser.CanGoForwardChanged += new EventHandler(OnWebBrowserCanGoForwardChanged);
                NavigationPanel.SearchPanel.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.repositoryItemComboBox1_CloseUp);
                NavigationPanel.SearchPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemComboBox1_KeyDown);
                NavigationPanel.SearchPanel.Validating += new System.ComponentModel.CancelEventHandler(this.repositoryItemComboBox1_Validating);
                NavigationPanel.BackButton.ItemClick += OnBackButtonItemClick;
                NavigationPanel.ForwardButton.ItemClick += OnForwardButtonItemClick;
                NavigationPanel.RefreshButton.ItemClick += OnRefreshButtonItemClick;
            }
        }
        void UnsubscribeOnPageEvents() {
            if(WebBrowser != null) {
                WebBrowser.Navigated -= new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
                WebBrowser.CanGoBackChanged -= new EventHandler(OnWebBrowserCanGoBackChanged);
                WebBrowser.CanGoForwardChanged -= new EventHandler(OnWebBrowserCanGoForwardChanged);
                NavigationPanel.SearchPanel.CloseUp -= new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.repositoryItemComboBox1_CloseUp);
                NavigationPanel.SearchPanel.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.repositoryItemComboBox1_KeyDown);
                NavigationPanel.SearchPanel.Validating -= new System.ComponentModel.CancelEventHandler(this.repositoryItemComboBox1_Validating);
                NavigationPanel.BackButton.ItemClick -= OnBackButtonItemClick;
                NavigationPanel.ForwardButton.ItemClick -= OnForwardButtonItemClick;
                NavigationPanel.RefreshButton.ItemClick -= OnRefreshButtonItemClick;
            }
        }
        public WebBrowser WebBrowser {
            get {
                if(TabFormControl.SelectedPage == null)
                    return null;
                foreach(Control ctrl in TabFormControl.SelectedPage.ContentContainer.Controls) {
                    if(ctrl is WebBrowser) return ctrl as WebBrowser;
                }
                return null;
            }
        }
        public BrowserNavigationControl NavigationPanel {
            get {
                if(TabFormControl.SelectedPage == null)
                    return null;
                foreach(Control ctrl in TabFormControl.SelectedPage.ContentContainer.Controls) {
                    if(ctrl is BrowserNavigationControl) return ctrl as BrowserNavigationControl;
                }
                return null;
            }
        }
        bool skinProcessing = false;
        string currentAddress = "";
        #region Skins
        void InitSkins() {
            barManager1.ForceInitialize();
        }
        void ChangedController(object sender, EventArgs e) {
            if(skinProcessing)
                return;
            string paintStyleName = barManager1.GetController().PaintStyleName;
            if("DefaultSkin".IndexOf(paintStyleName) >= 0)
                DevExpress.Skins.SkinManager.EnableFormSkins();
            else DevExpress.Skins.SkinManager.DisableFormSkins();
            skinProcessing = true;
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            skinProcessing = false;
        }
        #endregion
        void AddNewItem(string s) {
            if(NavigationPanel == null)
                return;
            if(s != "") {
                bool isAdded = false;
                for(int i = 0; i < NavigationPanel.SearchPanel.Items.Count; i++)
                    if(NavigationPanel.SearchPanel.Items[i].ToString() == s) {
                        isAdded = true;
                        break;
                    }
                if(!isAdded)
                    NavigationPanel.SearchPanel.Items.Add(s);
            }
        }
        protected internal void GoToItem(string address) {
            if(address == null) return;
            if(currentAddress != address) {
                NavigationPanel.SearchItem.EditValue = address;
                try {
                    if(WebBrowser != null && !WebBrowser.IsBusy) WebBrowser.Navigate(address);
                }
                catch { }
            }
        }
        string Address {
            get {
                if(barManager1.ActiveEditor != null && barManager1.ActiveEditor.EditValue != null)
                    return barManager1.ActiveEditor.EditValue.ToString();
                return null;
            }
        }
        void repositoryItemComboBox1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e) {
            GoToItem(Address);
        }
        void repositoryItemComboBox1_KeyDown(object sender, KeyEventArgs e) {
            DevExpress.XtraEditors.ComboBoxEdit edit = sender as DevExpress.XtraEditors.ComboBoxEdit;
            if(e.KeyData == Keys.Escape) {
                e.Handled = true;
                edit.SelectAll();
            }
            if(e.KeyData == Keys.Enter && !edit.IsPopupOpen) {
                NavigationPanel.Manager.ActiveEditItemLink.PostEditor();
                edit.SelectAll();
                e.Handled = true;
                GoToItem(NavigationPanel.SearchItem.EditValue.ToString());
            }
        }
        void repositoryItemComboBox1_Validating(object sender, CancelEventArgs e) {
            GoToItem(Address);
        }
        string blankString = "about:blank";
        void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e) {
            if(!object.Equals(sender, WebBrowser))
                return;
            string documentUri = WebBrowser.Url.AbsoluteUri;
            string eventUri = e.Url.AbsoluteUri;
            if(eventUri == blankString)
                return;
            if(documentUri != eventUri)
                return;
            if(barManager1.ActiveEditor != null)
                barManager1.ActiveEditItemLink.CloseEditor();
            if(CorrectAddress(eventUri)) {
                NavigationPanel.SearchItem.EditValue = eventUri;
                currentAddress = eventUri;
                AddNewItem(eventUri);
            }
        }
        void OnWebBrowserCanGoForwardChanged(object sender, EventArgs e) {
            NavigationPanel.ForwardButton.Enabled = WebBrowser.CanGoForward;
        }
        void OnWebBrowserCanGoBackChanged(object sender, EventArgs e) {
            NavigationPanel.BackButton.Enabled = WebBrowser.CanGoBack;
        }
        bool CorrectAddress(string name) {
            return !name.StartsWith("javascript:", StringComparison.OrdinalIgnoreCase);
        }
        void OnRefreshButtonItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(WebBrowser == null || WebBrowser.Url == null) return;
            WebBrowser.Navigate(WebBrowser.Url.AbsoluteUri);
        }
        void OnBackButtonItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                if(WebBrowser != null) WebBrowser.GoBack();
            }
            catch { }
        }
        void OnForwardButtonItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                if(WebBrowser != null) WebBrowser.GoForward();
            }
            catch { }
        }
        bool shouldInitHomePage = true;
        protected internal void InitHomePage() {
            GoToItem("www.devexpress.com/Subscriptions/Universal.xml");
        }
        void frmMain_Load(object sender, System.EventArgs e) {
            if(this.shouldInitHomePage)
                BeginInvoke(new MethodInvoker(InitHomePage));
        }
        bool HidePageCaption { get; set; }
        protected internal void Navigate(string address) {
            HidePageCaption = true;
            try {
                this.tabFormControl1.AddNewPage();
            }
            finally { HidePageCaption = false; }
            GoToItem(address);
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e) {
            e.Form = new frmMain(false);
            OpenFormCount++;
        }
        static int OpenFormCount = 1;
    }
}
