using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.AI.Demos.Modules.SemanticSearch;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.WinForms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.Extensions.VectorData;

namespace DevExpress.AI.Demos {
    public partial class SemanticSearchModule : AITutorialControl {
        public class VectorStoreRecord {
            [VectorStoreKey]
            public string Key { get; set; }

            [VectorStoreVector(1536, DistanceFunction = DistanceFunction.CosineDistance)]
            public string Vector { get; set; }
        }

        public const string VectorCollectionName = "Movies";

        public SemanticSearchModule() {
            InitializeComponent();
            SemanticSearchDataHelper.Load();
            gridControl1.DataSource = SemanticSearchDataHelper.Movies;
            gridLookUpEdit.Properties.DataSource = SemanticSearchDataHelper.Movies;
            searchLookUpEdit.Properties.DataSource = SemanticSearchDataHelper.Movies;
            if(!DemoHelper.IsTesting) {
                XtraSplashScreen.SplashScreenManager.ShowForm(typeof(SemanticSearchWaitForm));
                Task.Factory.StartNew(InitializeVectorStore, CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.FromCurrentSynchronizationContext());
            }
            UpdateAppearance();
            UpdatePaddings();
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateAppearance();
        }
        protected override void UpdatePaddings() {
            base.UpdatePaddings();
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }

        protected override void DoHide() {
            base.DoHide();
            XtraSplashScreen.SplashScreenManager.CloseForm(false);
            behaviorManager1.GetBehavior<SemanticSearchBehavior>(advBandedGridView).CloseOverlayForm();
            behaviorManager1.GetBehavior<SemanticSearchBehavior>(gridLookUpEditView).CloseOverlayForm();
            behaviorManager1.GetBehavior<SemanticSearchBehavior>(searchLookUpEditView).CloseOverlayForm();
        }

        void UpdateAppearance() {
            advBandedGridView.Appearance.RowSeparator.BackColor = advBandedGridView.PaintAppearance.HorzLine.GetBackColor();
        }

        private async Task InitializeVectorStore() {
            var container = AIExtensionsContainerDesktop.Default;
            try {
                var collection = container.GetVectorCollection<string, VectorStoreRecord>(VectorCollectionName);
                if(await collection.CollectionExistsAsync())
                    return;
                var records = SemanticSearchDataHelper.Movies.Select((m, index) => new VectorStoreRecord {
                    Key = m.Id.ToString(),
                    Vector = $"\"{m.Title}\" is a {m.Genre.ToLower()} film directed by {m.Directors}. {m.Plot}"
                });
                await collection.EnsureCollectionExistsAsync();
                await collection.UpsertAsync(records);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                XtraSplashScreen.SplashScreenManager.CloseForm(false);
            }
        }

        private void tbThreshold_EditValueChanged(object sender, EventArgs e) {
            var threshold = (double)tbThreshold.Value / 100;
            ChangeScoreThreshold(advBandedGridView, threshold);
            ChangeScoreThreshold(gridLookUpEditView, threshold);
            ChangeScoreThreshold(searchLookUpEditView, threshold);
        }

        private void rgSearchBehavior_SelectedIndexChanged(object sender, EventArgs e) {
            var behavior = rgSearchBehavior.SelectedIndex == 0
                ? DevExpress.XtraEditors.FindPanelBehavior.Filter
                : DevExpress.XtraEditors.FindPanelBehavior.Search;
            advBandedGridView.OptionsFind.Behavior = behavior;
        }

        void ChangeScoreThreshold(GridView gridView, double threshold) {
            var behavior = behaviorManager1.GetBehavior<SemanticSearchBehavior>(gridView);
            behavior.Properties.ScoreThreshold = threshold;
            gridView.RefreshData();
        }

        private void tabPane2_SelectedPageChanged(object sender, XtraBars.Navigation.SelectedPageChangedEventArgs e) {
            if(e.Page == lookupsNavigationPage) {
                rgSearchBehavior.SelectedIndex = 0;
                rgSearchBehavior.Enabled = false;
            }
            else
                rgSearchBehavior.Enabled = true;
        }
    }
}
