using DevExpress.XtraEditors.Demos.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleTokenEdit : TutorialControl {
        RepositoryItemTokenEdit CountriesTokenEdit;
        RepositoryItemTokenEdit ProducersTokenEdit;
        RepositoryItemTokenEdit GenresTokenEdit;
        const int InitialEditorRowHandle = 17;

        static ModuleTokenEdit() {
            MatchFunction.Register();
        }
        public ModuleTokenEdit() {
            MoviesData.Load();
            InitializeComponent();
            InitControls();
        }
        void InitControls() {
            gridControl.DataSource = MoviesData.Movies;
            InitTokenEditGenres();
            InitTokenEditProducers();
            InitTokenEditCountries();
            InitRepositoryItemTokens();
            filterPanel.SetFilterCriteriaBinding(gridView);
            gridView.FocusedRowHandle = InitialEditorRowHandle;
        }
        int lockFilterSync = 0;
        void GridView_ColumnFilterChanged(object sender, EventArgs e) {
            lockFilterSync++;
            if(colGenres.FilterInfo.Equals(ColumnFilterInfo.Empty))
                tokenEditGenres.EditValue = MoviesData.MovieGenre.None;
            if(colCountries.FilterInfo.Equals(ColumnFilterInfo.Empty))
                tokenEditCountries.EditValue = null;
            if(colProducers.FilterInfo.Equals(ColumnFilterInfo.Empty))
                tokenEditProducers.EditValue = null;
            lockFilterSync--;
        }
        // <tokenEditGenres>
        void InitTokenEditGenres() {
            tokenEditGenres.Properties.Tokens.AddEnum(typeof(MoviesData.MovieGenre));
        }
        // </tokenEditGenres>
        // <tokenEditProducers>
        void InitTokenEditProducers() {
            tokenEditProducers.Properties.BeginUpdate();
            tokenEditProducers.Properties.DataSource = MoviesData.Producers;
            tokenEditProducers.Properties.DisplayMember = "Name";
            tokenEditProducers.Properties.ValueMember = "Id";
            tokenEditProducers.Properties.EndUpdate();
        }
        // </tokenEditProducers>
        // <tokenEditCountries>
        void InitTokenEditCountries() {
            tokenEditCountries.Properties.Tokens.BeginUpdate();
            tokenEditCountries.Properties.Tokens.AddToken("France");
            tokenEditCountries.Properties.Tokens.AddToken("Germany");
            tokenEditCountries.Properties.Tokens.AddToken("Italy");
            tokenEditCountries.Properties.Tokens.AddToken("Japan");
            tokenEditCountries.Properties.Tokens.AddToken("Spain");
            tokenEditCountries.Properties.Tokens.AddToken("UK");
            tokenEditCountries.Properties.Tokens.AddToken("USA");
            tokenEditCountries.Properties.Tokens.EndUpdate();
        }
        // </tokenEditCountries>
        void InitRepositoryItemTokens() {
            CountriesTokenEdit = new RepositoryItemTokenEdit();
            ProducersTokenEdit = new RepositoryItemTokenEdit();
            GenresTokenEdit = new RepositoryItemTokenEdit();

            CountriesTokenEdit.Tokens.AddRange(tokenEditCountries.Properties.Tokens);

            ProducersTokenEdit.DataSource = tokenEditProducers.Properties.DataSource;
            ProducersTokenEdit.DisplayMember = tokenEditProducers.Properties.DisplayMember;
            ProducersTokenEdit.ValueMember = tokenEditProducers.Properties.DisplayMember;

            GenresTokenEdit.Tokens.AddRange(tokenEditGenres.Properties.Tokens);
            GenresTokenEdit.Tokens.AddToken("None");
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            lockFilterSync++;
            tokenEditGenres.EditValue = MoviesData.MovieGenre.Action | MoviesData.MovieGenre.Music | MoviesData.MovieGenre.Musical | MoviesData.MovieGenre.Comedy;
            SetTaggedBy(tokenEditGenres.SelectedItems, colGenres);
            tokenEditCountries.EditValue = "USA, Italy, Spain, France";
            SetTaggedBy(tokenEditCountries.SelectedItems, colCountries);
            lockFilterSync--;
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ModuleTokenEdit" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "tokenEdit"; }
        }
        void tokenEditCountries_EditValueChanged(object sender, EventArgs e) {
            if(lockFilterSync == 0)
                SetTaggedBy(tokenEditCountries.SelectedItems, colCountries);
        }
        void tokenEditGenres_EditValueChanged(object sender, EventArgs e) {
            if(lockFilterSync == 0)
                SetTaggedBy(tokenEditGenres.SelectedItems, colGenres);
        }
        void tokenEditProducers_EditValueChanged(object sender, EventArgs e) {
            if(lockFilterSync == 0)
                SetTaggedBy(tokenEditProducers.SelectedItems, colProducers);
        }
        void SetTaggedBy(TokenEditSelectedItemCollection tokens, GridColumn column) {
            if(!tokens.Any())
                column.ClearFilter();
            else
                column.FilterInfo = new ColumnFilterInfo(MatchFunction.Criteria(column.FieldName, tokens.Select(x => x.Description)));
        }
        protected override void DoShow() {
            if(Parent != null)
                Parent.Padding = Padding.Empty;
            base.DoShow();
        }
        void gridView_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e) {
            if(e.Column == colProducers)
                e.RepositoryItem = ProducersTokenEdit;
            else if(e.Column == colCountries)
                e.RepositoryItem = CountriesTokenEdit;
            else if(e.Column == colGenres)
                e.RepositoryItem = GenresTokenEdit;
        }
        void ClearFilter_Click(object sender, EventArgs e) {
            tokenEditCountries.EditValue = null;
            tokenEditGenres.EditValue = null;
            tokenEditProducers.EditValue = null;
        }
        protected override void DoVisibleChanged(bool visible) {
            base.DoVisibleChanged(visible);
            if(visible) {
                gridControl.ForceInitialize();
                gridControl.BeginInvoke(new Action(() => {
                    gridView.ShowEditForm();
                }));
            }
        }

        private void gridView_EditFormPrepared(object sender, EditFormPreparedEventArgs e) {
            foreach(var edit in e.BindableControls.Cast<BaseEdit>())
                edit.Properties.AutoHeight = true;
        }
    }
}
