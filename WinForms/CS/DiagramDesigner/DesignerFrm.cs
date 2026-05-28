using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Diagram.Core;
using DevExpress.DXperience.Demos;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraDiagram.Designer;
using DevExpress.XtraEditors;

namespace DevExpress.XtraDiagram.Demos {
    public partial class DesignerFrm : DiagramDesignerForm {
        public DesignerFrm() {
            InitializeComponent();
            UserSkins.BonusSkins.Register();
            Ribbon.Pages.Last().Groups.Add(rpgAppearance);
            MainFormHelper.RegisterRibbonDefaultBonusSkin();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitializeForm();
            SetupAppearanceGroup();
        }

        protected void InitializeForm() {
            Icon = LoadDefaultIcon();
            WindowState = FormWindowState.Maximized;
            AddSingleShape();
        }

        protected void AddSingleShape() {
            DiagramShape single = new DiagramShape(BasicShapes.Rectangle, 20, 20, 200, 100);
            Diagram.Items.Add(single);
            Diagram.SelectItem(single);
        }
		protected override Icon LoadDefaultIcon() {
            var assembly = typeof(DesignerFrm).Assembly;
            return ResourceImageHelper.CreateIconFromResources(assembly.GetManifestResourceNames().First(x => x.Contains("DemoIcon.ico")), assembly);
        }
        void OnRoundedModeCheckedChanged(object sender, ItemClickEventArgs e) {
            BarCheckItem ci = sender as BarCheckItem;
            WindowsFormsSettings.AllowRoundedWindowCorners = ci.Checked ? DefaultBoolean.True : DefaultBoolean.Default;
        }
        void RpgAppearance_CaptionButtonClick(object sender, RibbonPageGroupEventArgs e) {
            pmAppearance.ShowPopup(MousePosition);
        }
        void SetupAppearanceGroup() {
            SkinHelper.InitSkinPopupMenu(pmAppearance);
            foreach(GalleryItemGroup group in skinDropDownButtonItem1.DropDownGallery.Gallery.Groups)
                group.Visible = NeedCheckGroup(group);
        }
        bool NeedCheckGroup(GalleryItemGroup group) {
            if(!group.HasVisibleItems())
                return false;
            return group.Items.Select(x => (string)x.Tag).All(y => SkinCollectionHelper.IsStandardSkins(y));
        }
    }
}
