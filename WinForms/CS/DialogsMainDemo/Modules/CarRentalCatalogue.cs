using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.Dialogs.Core.View;
using DevExpress.Dialogs.Core.ViewModel;
using DevExpress.Internal;
using DevExpress.XtraDialogs.Demos.Helpers.Data;
using DevExpress.XtraDialogs.FileExplorerExtensions;

namespace DevExpress.XtraDialogs.Demos {
    public partial class CarRentalCatalogue : TutorialControl {
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { WhatsThisXMLFileName }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "CarRentalCatalogue"; }
        }
        readonly GridControlExtension listViewExtension;
        readonly TreeListExtension treeExtension;
        readonly List<VehiclesData.Model> models;
        readonly string dbFileName;
        public CarRentalCatalogue() {
            InitializeComponent();
            models = GetModels(out dbFileName);
            InitializeEditors();
            if(!fileExplorerAssistant.IsDesignMode) {
                //<grid>
                listViewExtension = fileExplorerAssistant.Attach(grid, x => {
                    x.ViewMode = ViewMode.LargeIcon;
                    x.FilterString = "Car files (*.car)|*.car";
                    x.ItemsType = DataSourceItemsType.All;
                    x.QueryLinkImage += OnQueryListViewImage;
                    x.FocusedLinkChanged += OnListViewFocusedLinkChanged;
                    x.CustomLinkFilter += OnListViewCustomLinkFilter;
                });
                //</grid>
                //<catalogueTree>
                treeExtension = fileExplorerAssistant.Attach(catalogueTree, x => {
                    x.IconSize = new Size(32, 32);
                    CreateVirtualHierarchy(models, x.RootNodes);
                    CreateDataFolderHierarchy(models, dbFileName, x.RootNodes);
                    x.CurrentItemChanged += OnTreeCurrentItemChanged;
                });
                catalogueTree.CustomColumnDisplayText += OnTreeCustomColumnDisplayText;
                //</catalogueTree>
                modelBindingSource.DataSource = models.First();
            }
            LicenseInfo.SetToolTipController(this, grid);
        }
        //<catalogueTree>
        void OnTreeCustomColumnDisplayText(object sender, XtraTreeList.CustomColumnDisplayTextEventArgs e) {
            if(e.Node != null && e.Node.ParentNode == null && string.Equals("Cars", e.Value as string))
                e.DisplayText = GetCarsFolderPath(dbFileName);
        }
        //</catalogueTree>
        void InitializeEditors() {
            CategoryImageComboBoxEdit.Properties.AddEnum(typeof(VehiclesData.Category), true);
            TransmissionTypeComboBoxEdit.Properties.AddEnum(typeof(VehiclesData.TransmissionType), true);
        }
        //<grid>
        void OnQueryListViewImage(object sender, QueryLinkImageEventArgs e) {
            var model = e.Link.Tag as VehiclesData.Model;
            if(model == null) {
                var trademark = e.Link.Tag as VehiclesData.Trademark;
                if(trademark != null)
                    e.Image = trademark.GetLogo(e.ImageSize);
            }
            else e.Image = model.GetImage(e.ImageSize);
        }
        //</grid>
        void OnTreeCurrentItemChanged(object sender, CurrentItemChangedEventArgs e) {
            listViewExtension.SetCurrentItem(e.CurrentItem);
        }
        //<grid>
        void OnListViewFocusedLinkChanged(object sender, FocusedLinkChangedEventArgs e) {
            var item = e.FocusedLink?.Item ?? listViewExtension.CurrentItem;
            if(item != null) {
                var model = item.Tag as VehiclesData.Model;
                if(model == null) {
                    var trademark = item.Tag as VehiclesData.Trademark;
                    if(trademark != null) {
                        VirtualFolderNode node = null;
                        if(trademarkNodes.TryGetValue(trademark.Name, out node)) {
                            var child = node.Nodes[0] as VirtualItemNode;
                            if(child != null) model = child.Tag as VehiclesData.Model;
                        }
                    }
                    var category = item.Tag as VehiclesData.BodyStyle;
                    if(category != null) {
                        VirtualFolderNode node = null;
                        if(stylesNodes.TryGetValue(category.Name, out node)) {
                            var child = node.Nodes[0] as VirtualItemNode;
                            if(child != null) model = child.Tag as VehiclesData.Model;
                        }
                    }
                    if(model == null && !string.IsNullOrEmpty(item.Name)) {
                        int id;
                        if(item.Name.EndsWith(".car")) {
                            if(int.TryParse(ReadCarIdFormFile(e.FocusedLink.FullPath), out id))
                                model = models.Find(x => x.ID == id);
                        }
                        else {
                            if(System.IO.Directory.Exists(item.FullPath)) {
                                var firstCarFile = System.IO.Directory.GetFiles(item.FullPath, "*.car").FirstOrDefault();
                                if(!string.IsNullOrEmpty(firstCarFile)) {
                                    if(int.TryParse(ReadCarIdFormFile(firstCarFile), out id))
                                        model = models.Find(x => x.ID == id);
                                }
                            }
                        }
                    }
                }
                modelBindingSource.DataSource = (object)model ?? typeof(VehiclesData.Model);
            }
            else modelBindingSource.DataSource = typeof(VehiclesData.Model);
        }
        void OnListViewCustomLinkFilter(object sender, Dialogs.Core.CustomLinkFilterEventArgs e) {
            if(e.Link.Tag is VehiclesData.Model) {
                e.Visible = true;
                e.Handled = true;
            }
        }
        //</grid>
        static List<VehiclesData.Model> GetModels(out string dbFileName) {
            dbFileName = DevAVDataDirectoryHelper.GetFile("Vehicles.xml");
            return VehiclesData.InitXMLDataCore(dbFileName);
        }
        readonly Dictionary<string, VirtualFolderNode> trademarkNodes = new Dictionary<string, VirtualFolderNode>();
        readonly Dictionary<string, VirtualFolderNode> stylesNodes = new Dictionary<string, VirtualFolderNode>();
        void CreateVirtualHierarchy(List<VehiclesData.Model> models, NodesCollection nodes) {
            var fromDataBaseNode = new VirtualFolderNode(@"(DevAVDb)\Vehicles (SQL Server)");
            fromDataBaseNode.AutoExpand = false;
            fromDataBaseNode.ImageOptions.SvgImage = Properties.Resources.database;
            var fromWebAPINode = new VirtualFolderNode(@"https:\\api.devav.com\getVehicles (Web API)");
            fromWebAPINode.AutoExpand = true;
            fromWebAPINode.ImageOptions.SvgImage = Properties.Resources.network;
            foreach(var model in models) {
                VirtualFolderNode trademarkNode = null;
                if(!trademarkNodes.TryGetValue(model.TrademarkName, out trademarkNode)) {
                    trademarkNode = new VirtualFolderNode(model.TrademarkName);
                    trademarkNode.ImageOptions.SvgImage = Properties.Resources.folder;
                    trademarkNode.TypeName = "Trademark";
                    trademarkNode.Tag = model.Trademarks[model.Trademark - 1];
                    fromDataBaseNode.Nodes.Add(trademarkNode);
                    trademarkNodes.Add(model.TrademarkName, trademarkNode);
                }
                VirtualFolderNode styleNode = null;
                if(!stylesNodes.TryGetValue(model.BodyStyleName, out styleNode)) {
                    styleNode = new VirtualFolderNode(model.BodyStyleName);
                    styleNode.ImageOptions.SvgImage = Properties.Resources.folder;
                    styleNode.TypeName = "Category";
                    styleNode.Tag = model.BodyStyles[model.BodyStyle - 1];
                    fromWebAPINode.Nodes.Add(styleNode);
                    stylesNodes.Add(model.BodyStyleName, styleNode);
                }
                var carNode = new VirtualItemNode(model.Name + ".car");
                carNode.ImageOptions.SvgImage = Properties.Resources.car;
                carNode.TypeName = "Car";
                carNode.Tag = model;
                trademarkNode.Nodes.Add(carNode);
                styleNode.Nodes.Add(carNode);
            }
            nodes.Add(fromDataBaseNode);
            nodes.Add(fromWebAPINode);
        }
        static void CreateDataFolderHierarchy(List<VehiclesData.Model> models, string dbFileName, NodesCollection nodes) {
            var carsFolder = new PathNode(GetCarsFolderPath(dbFileName));
            carsFolder.Tag = models.Find(x => x.ID == 11);
            nodes.Add(carsFolder);
        }
        static string GetCarsFolderPath(string dbFileName) {
            return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(dbFileName), "Cars");
        }
        readonly static char[] genericWhitespaces = new char[] { ' ', '\t', '\r', '\n' };
        static string ReadCarIdFormFile(string path) {
            string carContent = System.IO.File.ReadAllText(path);
            int idEnd = carContent.IndexOfAny(genericWhitespaces);
            return idEnd > 0 ? carContent.Substring(0, idEnd) : carContent;
        }
        protected override int TakeScreenDelay => 1000;
    }
}
