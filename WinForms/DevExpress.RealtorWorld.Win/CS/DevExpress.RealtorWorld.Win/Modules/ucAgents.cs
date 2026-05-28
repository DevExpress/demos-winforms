using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Utils.Menu;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucAgents : BaseModule {
        Series NorthEastSeries { get { return ccAgent.Series[0]; } }
        Series MidWestSeries { get { return ccAgent.Series[1]; } }
        Series SouthSeries { get { return ccAgent.Series[2]; } }
        Series WestSeries { get { return ccAgent.Series[3]; } }
        VisualRange VisualRangeX { get { return ((XYDiagram)ccAgent.Diagram).AxisX.VisualRange; } }
        WholeRange WholeRangeX { get { return ((XYDiagram)ccAgent.Diagram).AxisX.WholeRange; } }
        AxisX AxisX { get { return ((XYDiagram)ccAgent.Diagram).AxisX; } }
        public override string ModuleCaption { get { return "Agents"; } }

        public ucAgents() {
            InitializeComponent();
            pnlList.ItemSize = 137;
            int width = pnlList.ItemSize * 2;
            ((ITileControl)pnlList).Properties.LargeItemWidth = width;
            pnlList.Width = width + pnlList.Padding.Horizontal + SystemInformation.VerticalScrollBarWidth + 2;
        }
        internal override void HideModule() {
            base.HideModule();
            gridView1.HideCustomization();
        }
        void pnlList_ItemClick(object sender, TileItemEventArgs e) {
            InitData((Agent)e.Item.Tag);
        }
        void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e) {
            Home currentHome = gridView1.GetFocusedRow() as Home;
            if (currentHome != null && gridView1.CalcHitInfo(e.Location).InRow) {
                IMainForm main = this.FindForm() as IMainForm;
                if (main != null) main.ShowHome(currentHome);
            }
        }
        internal override void InitModule(IDXMenuManager manager, object data) {
            base.InitModule(manager, data);
            TileGroup group = new TileGroup();
            foreach (Agent agent in DataHelper.Agents) {
                TileItem item = new TileItem();
                item.ItemSize = TileItemSize.Wide;
                item.Appearance.BackColor = Color.FromArgb(102, 102, 102);
                item.AppearanceSelected.BackColor = CommonSkins.GetSkin(LookAndFeel.ActiveLookAndFeel).Colors["Highlight"];
                item.BackgroundImageScaleMode = TileItemImageScaleMode.NoScale;
                item.BackgroundImageAlignment = TileItemContentAlignment.MiddleRight;
                item.BackgroundImage = DataHelper.GetScaleImage(agent.Photo, 65);
                item.Text = string.Format("<size=+3>{0} {1}<size=-2><br>{2}", agent.FirstName, agent.LastName, agent.Phone);
                //item.Text3 = string.Format("{0}", agent.Email);
                item.Tag = agent;
                group.Items.Add(item);
            }
            pnlList.Groups.Add(group);
        }
        internal override void ShowModule(object item) {
            base.ShowModule(item);
            InitData((Agent)item);
            DataHelper.SetTileSelectedItem(item, pnlList);
        }
        void InitData(Agent agent) {
            if (agent == null) return;
            gridControl1.DataSource = DataHelper.GetHomesByAgent(agent);
            gridControl1.Focus();
            var random = new DevExpress.Data.Utils.NonCryptographicRandom(agent.ID);
            int year = DateTime.Now.Year;
            ccAgent.BeginInit();
            try {
                NorthEastSeries.Points.Clear();
                MidWestSeries.Points.Clear();
                SouthSeries.Points.Clear();
                WestSeries.Points.Clear();
                for (int i = 0; i < 10; i++) {
                    DateTime date = new DateTime(year - i, 1, 1);
                    NorthEastSeries.Points.Add(new SeriesPoint(date, random.Next(5)));
                    MidWestSeries.Points.Add(new SeriesPoint(date, random.Next(10)));
                    SouthSeries.Points.Add(new SeriesPoint(date, random.Next(20)));
                    WestSeries.Points.Add(new SeriesPoint(date, random.Next(15)));
                }
            }
            finally {
                ccAgent.EndInit();
            }
            ((ImageAnnotation)ccAgent.Annotations[0]).Image.Image = agent.Photo;
            ccAgent.Titles[0].Text = string.Format("Houses Sold by {0} {1}", agent.FirstName, agent.LastName);
            object min = AxisX.GetScaleValueFromInternal(WholeRangeX.MaxValueInternal - 3);
            VisualRangeX.SetMinMaxValues(min, WholeRangeX.MaxValue);
        }
    }
}
