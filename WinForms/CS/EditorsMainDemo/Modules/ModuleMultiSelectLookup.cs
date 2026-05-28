using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Demos.Modules.Overview;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleMultiSelectLookup : TutorialControl {
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ModuleMultiSelectLookup" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "multiselectlookup"; }
        }
        public ModuleMultiSelectLookup() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            assistantsBindingSource.DataSource = EmployeeReviews.GetAssistants();
            var employee = EmployeeReviews.GetReviewedEmployee();
            employeeBindingSource.DataSource = employee;
            reviewsBindingSource.DataSource = employee.Reviews;
            AssistantsLookup.Focus();
            OnEditValueChanged(AssistantsLookup, e);
        }
        void OnEditValueChanged(object sender, EventArgs e) {
            var assistants = ((LookUpEditBase)sender).EditValue as HashSet<int>;
            if(assistants == null || assistants.Count == 0)
                validationHint1.Properties.State = Utils.VisualEffects.ValidationHintState.Invalid;
            else validationHint1.Properties.State = null;
            // update corresponding grid row
            gridView1.RefreshRow(gridView1.GetRowHandle(reviewsBindingSource.Position));
        }
#pragma warning disable IDE0051 // Remove unused private members
        // <AssistantsLookup>
        void SetupAssistantsLookup() {
            AssistantsLookup.Properties.DataSource = EmployeeReviews.GetAssistants();
            AssistantsLookup.Properties.EditValueType = LookUpEditValueType.ValueList;
            AssistantsLookup.Properties.EnableEditValueCollectionEditing = DefaultBoolean.True;
            AssistantsLookup.Properties.ValueMember = "ID";
            AssistantsLookup.Properties.DisplayMember = "FullName";
            AssistantsLookup.Properties.NullValuePrompt = "Add assistants...";
            AssistantsLookup.Properties.SearchMode = SearchMode.AutoSearch;
        }
        // </AssistantsLookup>

        // <gridControl1>
        void SetupAssistantsLookupForGridColumn() {
            colAssistants.Caption = "Assistants";
            colAssistants.ColumnEdit = repositoryItemAssistantsLookUp;
            colAssistants.FieldName = "AssistantIDs";
            //
            repositoryItemAssistantsLookUp.DataSource = EmployeeReviews.GetAssistants();
            repositoryItemAssistantsLookUp.EditValueType = LookUpEditValueType.ValueList;
            repositoryItemAssistantsLookUp.EnableEditValueCollectionEditing = DefaultBoolean.True;
            repositoryItemAssistantsLookUp.ValueMember = "ID";
            repositoryItemAssistantsLookUp.DisplayMember = "FullName";
            repositoryItemAssistantsLookUp.SearchMode = SearchMode.AutoSearch;
        }
        // </gridControl1>
#pragma warning restore IDE0051 // Remove unused private members
        protected override void CalcContentCore() {
            if(tablePanel1 != null)
                tablePanel1.Height = dataLayoutControl1.Root.MinSize.Height + dataLayoutControl1.Margin.Vertical;
            CalcTablePanelBounds(tablePanel1);
        }
    }
}
