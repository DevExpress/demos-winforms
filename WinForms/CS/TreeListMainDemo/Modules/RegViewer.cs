using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Win32;

namespace DevExpress.XtraTreeList.Demos {
#pragma warning disable CA1416 // Validate platform compatibility
#pragma warning disable DX0020
    public partial class TreeListRegViewer : TutorialControl {
        public override TreeList MainControl {
            get { return treeList1; }
        }
        protected override string BarName { get { return "RegViewer"; } }
        public TreeListRegViewer() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "TreeListMainDemo\\Modules\\RegViewer" }; } }
        protected override string WhatsThisXMLFileName { get { return "RegViewer"; } }
        ComputerRegistryItem computerItem = new ComputerRegistryItem();
        BindingList<RegistryItemBase> source;

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            //<treeList1>
            source = new BindingList<RegistryItemBase>() { computerItem };
            treeList1.DataSource = source;
            treeList1.ChildListFieldName = "Items";
            treeList1.ForceInitialize();
            treeList1.Nodes[0].Expand();
            treeList1.Nodes[0].Nodes[0].Expand();
            //</treeList1>
            treeList1.FocusedNode = treeList1.Nodes[0].Nodes[0];
            treeList1.GetSelectImage += treeList1_GetSelectImage;
            treeList2.GetSelectImage += treeList2_GetSelectImage;
        }

        //<treeList1>
        void treeList1_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e) {
            if(e.Node.ParentNode == null)
                return;
            var registryItem = (RegistryItemBase)treeList1.GetRow(e.Node.Id);
            RootRegistryItem rootItem = (RootRegistryItem)computerItem.Items[registryItem.RootIndex];
            registryItem.LoadItems(rootItem.Key);
        }
        //</treeList1>

        //<treeList2>
        void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e) {
            var registryItem = (RegistryItemBase)treeList1.GetRow(e.Node.Id);
            textEdit1.Text = registryItem.Path;
            if(e.Node.ParentNode == null)
                return;
            RootRegistryItem rootItem = (RootRegistryItem)computerItem.Items[registryItem.RootIndex];
            registryItem.LoadObjects(rootItem.Key);
            treeList2.DataSource = ((RegistryItemBase)treeList1.GetRow(e.Node.Id)).Objects;
        }
        //</treeList2>

        void treeList1_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e) {
            if(e.Node.ParentNode == null)
                e.NodeImageIndex = 0;
            else
                e.NodeImageIndex = 1;
        }
        void treeList2_GetSelectImage(object sender, DevExpress.XtraTreeList.GetSelectImageEventArgs e) {
            if(treeList2.IsAutoFilterNode(e.Node))
                return;
            var registryValue = (RegistryValue)treeList2.GetRow(e.Node.Id);
            switch(registryValue.Kind) {
                case RegistryValueKind.Binary:
                case RegistryValueKind.DWord:
                case RegistryValueKind.QWord:
                    e.NodeImageIndex = 4;
                    break;
                default:
                    e.NodeImageIndex = 3;
                    break;
            }
        }
    }
    public class ComputerRegistryItem : RegistryItemBase {
        public ComputerRegistryItem() : base("Computer", string.Empty, -1) {
            LoadItems(null);
            LoadObjects(null);
        }
        protected override void LoadObjectsCore(RegistryKey root) { }
        protected override void LoadItemsCore(RegistryKey root) {
            BindingList<RegistryItemBase> rootItems = new BindingList<RegistryItemBase>();
            rootItems.Add(new RootRegistryItem(Registry.ClassesRoot, Name, 0));
            rootItems.Add(new RootRegistryItem(Registry.CurrentUser, Name, 1));
            rootItems.Add(new RootRegistryItem(Registry.LocalMachine, Name, 2));
            rootItems.Add(new RootRegistryItem(Registry.Users, Name, 3));
            rootItems.Add(new RootRegistryItem(Registry.CurrentConfig, Name, 4));
            Items = rootItems;
        }
        protected override RegistryItemBase CreateRegistryItem(string name) {
            return null;
        }
    }
    public class RootRegistryItem : RegistryItemBase {
        RegistryKey keyCore;
        public RootRegistryItem(RegistryKey key, string path, int rootIndex) : base(key.Name, path, rootIndex) {
            this.keyCore = key;
            EnableLazyLoading(key.SubKeyCount > 0);
        }
        public RegistryKey Key {
            get { return keyCore; }
        }
        protected override void LoadItemsCore(RegistryKey root) {
            GenerateItems(root, root.GetSubKeyNames());
        }
        protected override void LoadObjectsCore(RegistryKey root) {
            var names = root.GetValueNames();
            GenerateObjects(root, names);
        }
        protected override RegistryItemBase CreateRegistryItem(string name) {
            return new RegistryItem(name, Path, string.Empty, RootIndex);
        }
    }
    public class RegistryItem : RegistryItemBase {
        internal RegistryItem(string name, int rootIndex) : base(name, string.Empty, rootIndex) { }
        public RegistryItem(string name, string path, string subPath, int rootIndex) : base(name, path, rootIndex) {
            SubKeyPath = string.IsNullOrEmpty(subPath) ? name : subPath + @"\" + name;
        }
        string SubKeyPath;
        protected override void LoadItemsCore(RegistryKey root) {
            using(var key = RegistryItemBase.OpenSubKey(root, SubKeyPath))
                GenerateItems(root, key != null ? key.GetSubKeyNames() : null);
        }
        protected override void LoadObjectsCore(RegistryKey root) {
            using(var key = RegistryItemBase.OpenSubKey(root, SubKeyPath)) {
                var names = key != null ? key.GetValueNames() : null;
                GenerateObjects(key, names);
            }
        }
        protected override RegistryItemBase CreateRegistryItem(string name) {
            return new RegistryItem(name, Path, SubKeyPath, RootIndex);
        }
        protected override void CheckLazyLoading(RegistryKey root) {
            using(var subKey = RegistryItemBase.OpenSubKey(root, SubKeyPath))
                EnableLazyLoading(subKey != null && subKey.SubKeyCount > 0);
        }
    }

    //<treeList1>
    public abstract class RegistryItemBase : INotifyPropertyChanged {
        static BindingList<RegistryItemBase> defaultItems = new BindingList<RegistryItemBase>() { new RegistryItem("Empty", -1) };
        BindingList<RegistryItemBase> itemsCore;
        List<RegistryValue> objectsCore;
        event PropertyChangedEventHandler propetyChangedCore;
        internal static RegistryKey OpenSubKey(RegistryKey key, string subKeyPath) {
            try { return key.OpenSubKey(subKeyPath); }
            catch { return null; }
        }
        public RegistryItemBase(string name, string path, int rootIndex) {
            Name = name;
            Path = string.IsNullOrEmpty(path) ? name : path + @"\" + name;
            RootIndex = rootIndex;
        }
        public readonly int RootIndex;
        public string Name {
            get;
            set;
        }
        public readonly string Path;
        bool isLoaded = false;
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged {
            add { propetyChangedCore += value; }
            remove { propetyChangedCore -= value; }
        }
        
        public BindingList<RegistryItemBase> Items {
            get { return itemsCore; }
            internal set {
                itemsCore = value;
                OnPropertyChanged("Items");
            }
        }
        //</treeList1>

        protected void OnPropertyChanged(string name) {
            if (propetyChangedCore == null)
                return;
            propetyChangedCore(this, new PropertyChangedEventArgs(name));
        }

        public void LoadItems(RegistryKey root) {
            if(isLoaded)
                return;
            LoadItemsCore(root);
            isLoaded = true;
        }
        protected virtual void LoadItemsCore(RegistryKey root) { }
        protected void GenerateItems(RegistryKey root, string[] names) {
            if(names == null || names.Length == 0)
                Items = null;
            else {
                BindingList<RegistryItemBase> itemList = new BindingList<RegistryItemBase>();
                for(int n = 0; n < names.Length; n++) {
                    var rItem = CreateRegistryItem(names[n]);
                    rItem.CheckLazyLoading(root);
                    itemList.Add(rItem);
                }
                Items = itemList;
            }
        }
        protected virtual void CheckLazyLoading(RegistryKey root) { }
        internal void EnableLazyLoading(bool value) {
            if(value)
                itemsCore = defaultItems;
            else
                isLoaded = true;
        }
        protected abstract RegistryItemBase CreateRegistryItem(string name);
        public List<RegistryValue> Objects {
            get { return objectsCore; }
        }
        public void LoadObjects(RegistryKey root) {
            if(objectsCore == null) {
                objectsCore = new List<RegistryValue>(10);
                LoadObjectsCore(root);
            }
        }
        protected virtual void LoadObjectsCore(RegistryKey root) { }
        protected void GenerateObjects(RegistryKey key, string[] names) {
            if(names == null || names.Length == 0) {
                objectsCore.Add(new RegistryValue());
                return;
            }
            else {
                if(!string.IsNullOrEmpty(names[0]))
                    objectsCore.Add(new RegistryValue());
                foreach(string currentName in names) {
                    var kind = key.GetValueKind(currentName);
                    var value = key.GetValue(currentName);
                    objectsCore.Add(new RegistryValue(currentName, value, kind));
                }
            }
        }
    }
    public class RegistryValue {
        static Dictionary<int, string> RegistryValueType = new Dictionary<int, string> {
            { (int)RegistryValueKind.String, "REG_SZ" },
            { (int)RegistryValueKind.ExpandString, "REG_EXPAND_SZ" },
            { (int)RegistryValueKind.MultiString, "REG_MULTI_SZ" },
            { (int)RegistryValueKind.QWord, "REG_QWORD" },

            { (int)RegistryValueKind.DWord, "REG_DWORD" },

            { (int)RegistryValueKind.Binary, "REG_BINARY" },
            { (int)RegistryValueKind.None, "REG_NONE" },
            { (int)RegistryValueKind.Unknown, "REG_UNKNOWN" }
        };
        RegistryValueKind kindCore;
        public RegistryValue() {
            Name = "(Default)";
            Data = "(value not set)";
            Kind = RegistryValueKind.String;
        }
        public RegistryValue(string name, object data, RegistryValueKind kind) {
            Name = string.IsNullOrEmpty(name) ? "(Default)" : name;
            Data = data == null ? "(value not set)" : data;
            Kind = kind;
        }
        public string Name {
            get;
            private set;
        }
        public string Type {
            get;
            private set;
        }
        public RegistryValueKind Kind {
            get { return kindCore; }
            set {
                if(kindCore == value)
                    return;
                kindCore = value;
                Type = RegistryValueType[(int)value];
            }
        }
        public object Data {
            get;
            private set;
        }
    }
#pragma warning restore DX0020
#pragma warning restore CA1416 // Validate platform compatibility
}
