using System.ComponentModel;
using System.Drawing;

namespace DevExpress.XtraTreeList.Demos {
    public partial class ChecksAndRadios : DevExpress.XtraTreeList.Demos.TutorialControl {
        public ChecksAndRadios() {
            InitializeComponent();
            InitTreeList();
            ucCheckBoxOptions1.InitData(MainControl);
        }
        protected override bool FluentScrollBars {
            get { return true; }
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "TreeListMainDemo\\Modules\\ChecksAndRadios", "TreeListMainDemo\\Options\\ucCheckBoxOptions" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "ChecksAndRadios"; }
        }
        //<treeList>
        void InitTreeList() {
            layoutControl.UseLocalBindingContext = true;
            treeList.Appearance.Row.BackColor = Color.Transparent;
            treeList.Appearance.Empty.BackColor = Color.Transparent;
            treeList.BackColor = Color.Transparent;
            treeList.CheckBoxFieldName = "Checked";
            treeList.TreeViewFieldName = "Name";
            treeList.OptionsView.FocusRectStyle = DrawFocusRectStyle.None;
            treeList.OptionsBehavior.Editable = false;
            treeList.OptionsBehavior.ReadOnly = true;
            treeList.OptionsBehavior.AllowRecursiveNodeChecking = true;
            treeList.NodeCellStyle += OnNodeCellStyle;
            treeList.BeforeFocusNode += OnBeforeFocusNode;
            var dataSource = GenerateDataSource();
            treeList.DataSource = dataSource;
            treeList.ForceInitialize();
            ucCheckBoxOptions1.DataSource = dataSource;
            treeList.Nodes[0].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Check;
            treeList.Nodes[1].Nodes[0].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
            treeList.Nodes[1].Nodes[1].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
            treeList.Nodes[1].Nodes[2].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
            treeList.Nodes[2].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
            treeList.Nodes[3].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
            treeList.ExpandAll();
        }
        //</treeList>
        void OnBeforeFocusNode(object sender, BeforeFocusNodeEventArgs e) {
            e.CanFocus = false;
        }
        void OnNodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e) {
            if(e.Node.Level == 0) {
                e.Appearance.FontSizeDelta += 1;
                e.Appearance.FontStyleDelta = FontStyle.Bold;
            }
            if(e.Node.Level == 1 && e.Node.Nodes.Count > 0)
                e.Appearance.FontStyleDelta = FontStyle.Bold;
        }
        public override TreeList MainControl {
            get { return treeList; }
        }
        BindingList<Option> GenerateDataSource() {
            BindingList<Option> _options = new BindingList<Option>();
            _options.Add(new Option() { ParentID = 0, ID = 1, Name = "Install components", Checked = true });
            _options.Add(new Option() { ParentID = 1, ID = 2, Name = ".NET Framework 4.5", Checked = true });
            _options.Add(new Option() { ParentID = 1, ID = 3, Name = "SQL Server 2016", Checked = true });
            _options.Add(new Option() { ParentID = 1, ID = 4, Name = "Demos", Checked = true });
            _options.Add(new Option() { ParentID = 1, ID = 5, Name = "Tutorials", Checked = true });
            _options.Add(new Option() { ParentID = 1, ID = 6, Name = "Help Viewer", Checked = true });
            _options.Add(new Option() { ParentID = 0, ID = 7, Name = "Settings", Checked = true });
            _options.Add(new Option() { ParentID = 7, ID = 8, Name = "Language", Checked = true });
            _options.Add(new Option() { ParentID = 8, ID = 9, Name = "German" });
            _options.Add(new Option() { ParentID = 8, ID = 10, Name = "English(United Kingdom)" });
            _options.Add(new Option() { ParentID = 8, ID = 11, Name = "English(United States)", Checked = true });
            _options.Add(new Option() { ParentID = 8, ID = 12, Name = "Spanish(Spain)" });
            _options.Add(new Option() { ParentID = 8, ID = 13, Name = "Spanish(United States)" });
            _options.Add(new Option() { ParentID = 8, ID = 14, Name = "Spanish(Mexico)" });
            _options.Add(new Option() { ParentID = 8, ID = 15, Name = "French(France)" });
            _options.Add(new Option() { ParentID = 8, ID = 16, Name = "French(Canada)" });
            _options.Add(new Option() { ParentID = 8, ID = 17, Name = "Italian" });
            _options.Add(new Option() { ParentID = 8, ID = 18, Name = "Japanese" });
            _options.Add(new Option() { ParentID = 8, ID = 19, Name = "Russian" });
            _options.Add(new Option() { ParentID = 7, ID = 20, Name = "Default theme", Checked = true });
            _options.Add(new Option() { ParentID = 20, ID = 21, Name = "White", Checked = true });
            _options.Add(new Option() { ParentID = 20, ID = 22, Name = "Dark" });
            _options.Add(new Option() { ParentID = 20, ID = 23, Name = "Light" });
            _options.Add(new Option() { ParentID = 7, ID = 24, Name = "Architecture", Checked = true });
            _options.Add(new Option() { ParentID = 24, ID = 25, Name = "x86" });
            _options.Add(new Option() { ParentID = 24, ID = 26, Name = "x64", Checked = true });
            _options.Add(new Option() { ParentID = 0, ID = 27, Name = "Check for updates", Checked = true });
            _options.Add(new Option() { ParentID = 27, ID = 28, Name = "Once per week", Checked = true });
            _options.Add(new Option() { ParentID = 27, ID = 29, Name = "Once per month" });
            _options.Add(new Option() { ParentID = 27, ID = 30, Name = "Once per 3 months" });
            _options.Add(new Option() { ParentID = 0, ID = 31, Name = "Join the Customer Experience Improvement Programm", Checked = true });
            _options.Add(new Option() { ParentID = 31, ID = 32, Name = "Yes(Recommended)", Checked = true });
            _options.Add(new Option() { ParentID = 31, ID = 33, Name = "No" });
            return _options;
        }
    }
    class Option : INotifyPropertyChanged {
        public int ParentID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        bool? checkedCore = false;
        public bool? Checked {
            get { return checkedCore; }
            set {
                if(checkedCore == value)
                    return;
                checkedCore = value;
                if(PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Checked"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
