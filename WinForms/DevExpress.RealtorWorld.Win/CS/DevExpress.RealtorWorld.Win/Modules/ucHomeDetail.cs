using System;
using System.ComponentModel;
using System.Drawing;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucHomeDetail : BaseModule {
        const int photoSizePercent = 90;
        public ucHomeDetail() {
            InitializeComponent();
        }
        public override bool AllowWaitDialog { get { return false; } }
        bool fullLayout = true;
        internal void InitData(Home home) {
            if(home == null) return;
            FullLayout = true;
            pnlData.Width = home.Photo.Width * photoSizePercent / 100 + 10;
            imageSlider.Height = home.Photo.Height * photoSizePercent / 100;
            lcFeatures.Text = string.Format("<size=+7>{0}<size=-5><br><b>{1}</b> bedrooms, <b>{2}</b> bathrooms<br>" +
            "<b>{3}</b> house size, <b>{4}</b> lot size<br><size=+1>Built in {5}<br><size=+9>{6}<br><size=-10>{7}<br><br><u>Agent:",
                home.Address, home.Beds, home.Baths, home.HouseSizeString, home.LotSize, home.YearBuilt, home.PriceString, home.Features);
            lcMain.FocusHelper.FocusElement(lciHome, false);
            Agent agent = DataHelper.GetAgentByHome(home);
            if(agent != null) {
                peAgent.Image = agent.Photo;
                peAgent.Tag = agent;
                lcAgent.Text = string.Format("<Size=+7>{0} {1}<br><Size=-4>{2}<br><Size=-1>{3}", agent.FirstName, agent.LastName, agent.Phone, agent.Email);
            }
            imageSlider.Images.Clear();
            peLayout.Image = home.Plan;
            foreach(Image img in DataHelper.GetPhotos(home))
                imageSlider.Images.Add(img);
            imageSlider.Refresh(); //TODO
        }
        [DefaultValue(true)]
        public bool FullLayout {
            get { return fullLayout; }
            set {
                if(fullLayout == value) return;
                fullLayout = value;
                pnlData.Visible = fullLayout;
            }
        }
        void peLayout_DoubleClick(object sender, EventArgs e) {
            FullLayout = !FullLayout;
        }
        void peAgent_DoubleClick(object sender, EventArgs e) {
            Agent currentAgent = peAgent.Tag as Agent;
            if(currentAgent != null) {
                IMainForm main = this.FindForm() as IMainForm;
                if(main != null) main.ShowAgent(currentAgent);
            }
        }
        void ucHomeDetail_VisibleChanged(object sender, EventArgs e) {
            lcMain.FocusHelper.FocusElement(lciHome, false);
        }
    }
}
