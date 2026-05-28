using System;
using System.Data;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.FilterEditor;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for FilterControl.
    /// </summary>
    public partial class FilterControl : TutorialControl {
		public FilterControl() {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            // TODO: Add any initialization after the InitForm call
            filterControl1.FilterControl.UseLeftIndent = false;
            filterControl2.UseLeftIndent = false;
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "FilterControl" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "FilterControl"; }
        }
        bool initProperties = false;
		void FilterControl_Load(object sender, System.EventArgs e) {
			filterControl1.MenuManager = gridControl1.MenuManager;
			InitNWindData();
			gridColumnProduct.FilterInfo = new ColumnFilterInfo("[ProductID] between ('Alice Munton', 'Iqura')");
			gridColumnDiscount.FilterInfo = new ColumnFilterInfo("IsBlackFridayDiscount([Discount])");

            InitOptions();
			InitCustomFilterControl();
			gridColumnImplemented.FilterInfo = new ColumnFilterInfo("[Implemented] >= 50");
			gridColumnSuspended.FilterInfo = new ColumnFilterInfo("[Suspended] = False");
			ResetCustomFilter();
            //<filterControl1>
            /*
            ~Note: the following code is set at design-time and is listed here for educational purposes only.
            filterControl1.SourceControl = gridControl1;
            */
            //</filterControl1>
            filterControl1.FilterControl.QueryCustomFunctions += OnQueryCustomFunctions;
            gridView1.QueryCustomFunctions += OnQueryCustomFunctions;
        }
        void InitOptions() {
			initProperties = true;
			ceEmptyValue.Color = filterControl1.AppearanceEmptyValueColor;
			ceFieldName.Color = filterControl1.AppearanceFieldNameColor;
			ceGroupOperator.Color = filterControl1.AppearanceGroupOperatorColor;
			ceOperator.Color = filterControl1.AppearanceOperatorColor;
			ceValue.Color = filterControl1.AppearanceValueColor;
			seLevelIndent.Value = filterControl1.LevelIndent;
			seSeparatorHeight.Value = filterControl1.NodeSeparatorHeight;
			ceGroupCommandsIcon.Checked = filterControl1.ShowGroupCommandsIcon;
			ceOperandTypeIcon.Checked = filterControl1.ShowOperandTypeIcon;
			ceToolTips.Checked = filterControl1.ShowToolTips;
            foreach(FilterEditorViewMode mode in Enum.GetValues(typeof(FilterEditorViewMode)))
                icbViewMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FilterEditorViewMode>.GetTitle(mode), mode, -1));
            icbViewMode.EditValue = filterControl1.ViewMode;
            icbDisplayStyle.Properties.AddEnum<FilterCriteriaDisplayStyle>();
            icbDisplayStyle.EditValue = FilterCriteriaDisplayStyle.Visual;
            gridView1.OptionsFilter.DefaultFilterEditorView = filterControl1.ViewMode;
			initProperties = false;
		}
        string tblGrid = "Order Details";
        string tblLookUp = "Products";
        protected override DataSet InitNWindXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);

            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
            return ds;
        }
        protected override void InitNWindData() {
            base.InitNWindData();
			gridControl2.DataSource = OutlookData.CreateIssueList();
		}

        //<sbApply>
		void sbApply_Click(object sender, System.EventArgs e) {
			filterControl1.ApplyFilter();
		}
        //</sbApply>

        //<ceEmptyValue>
		void ceEmptyValue_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.AppearanceEmptyValueColor = ceEmptyValue.Color;
		}
        //</ceEmptyValue>
        //<ceFieldName>
		void ceFieldName_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.AppearanceFieldNameColor = ceFieldName.Color;
		}
        //</ceFieldName>
        //<ceGroupOperator>
		void ceGroupOperator_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.AppearanceGroupOperatorColor = ceGroupOperator.Color;
		}
        //</ceGroupOperator>
        //<ceOperator>
		void ceOperator_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.AppearanceOperatorColor = ceOperator.Color;
		}
        //</ceOperator>
        //<ceValue>
		void ceValue_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.AppearanceValueColor = ceValue.Color;
		}
        //</ceValue>
        //<seLevelIndent>
		void seLevelIndent_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.LevelIndent = Convert.ToInt32(seLevelIndent.Value);
		}
        //</seLevelIndent>
        //<seSeparatorHeight>
		void seSeparatorHeight_EditValueChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.NodeSeparatorHeight = Convert.ToInt32(seSeparatorHeight.Value);
		}
        //</seSeparatorHeight>
        //<ceGroupCommandsIcon>
		void ceGroupCommandsIcon_CheckedChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.ShowGroupCommandsIcon = ceGroupCommandsIcon.Checked;
		}
        //</ceGroupCommandsIcon>
        //<ceOperandTypeIcon>
		void ceOperandTypeIcon_CheckedChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.ShowOperandTypeIcon = ceOperandTypeIcon.Checked;
		}
        //</ceOperandTypeIcon>
        //<ceToolTips>
		void ceToolTips_CheckedChanged(object sender, System.EventArgs e) {
			if(initProperties) return;
			filterControl1.ShowToolTips = ceToolTips.Checked;
		}
        //</ceToolTips>
		void InitCustomFilterControl() {
			ViewFilterColumnCollection columnCollection = new ViewFilterColumnCollection(gridView2);
			CustomizationFilterColumnCollection(columnCollection);
			filterControl2.SetFilterColumnsCollection(columnCollection, gridControl2.MenuManager);
			filterControl2.SetDefaultColumn(GridCriteriaHelper.GetFilterColumnByGridColumn(filterControl2.FilterColumns, gridColumnImplemented));
			filterControl2.FilterString = gridView2.ActiveFilterString;
		}
        //<sbApplyFilter2>
		void sbApplyFilter2_Click(object sender, System.EventArgs e) {
			gridView2.ActiveFilterString = filterControl2.FilterString; 
		}
        //</sbApplyFilter2>
        //<sbReset>
		void sbReset_Click(object sender, System.EventArgs e) {
			ResetCustomFilter();
		}

		void ResetCustomFilter() {
			filterControl2.FilterString = gridView2.ActiveFilterString;
		}
        //</sbReset>
		void CustomizationFilterColumnCollection(ViewFilterColumnCollection columnCollection) {
			columnCollection.RemoveAt(0);
			GridFilterColumn col = columnCollection["Implemented"] as GridFilterColumn;
			RepositoryItemTrackBar tbItem = new RepositoryItemTrackBar();
			tbItem.Maximum = 100;
			tbItem.TickFrequency = 10;
			col.SetRepositoryItem(tbItem);
			col = columnCollection["Suspended"] as GridFilterColumn;
			RepositoryItemImageComboBox icbItem = new RepositoryItemImageComboBox();
			icbItem.SmallImages = imageCollection1;
			icbItem.Items.Add(new ImageComboBoxItem("Checked", true, 0));
			icbItem.Items.Add(new ImageComboBoxItem("Unchecked", false, 1));
			col.SetRepositoryItem(icbItem);
		}

        //<icbViewMode>
        void icbViewMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(initProperties) return;
            filterControl1.ViewMode = (FilterEditorViewMode)icbViewMode.EditValue;
            gridView1.OptionsFilter.DefaultFilterEditorView = filterControl1.ViewMode;
        }
        //</icbViewMode>
        void tabPane1_SelectedPageChanged(object sender, XtraBars.Navigation.SelectedPageChangedEventArgs e) {
            sidePanel1.Visible = e.Page == tabPage1;
        }
        void OnQueryCustomFunctions(object sender, Data.Filtering.CustomFunctionEventArgs e) {
            if(e.PropertyType == typeof(DateTime) || e.PropertyType == typeof(DateTime?)) {
                e.Add(IsWeekendFunction.FunctionName);
                e.Add(DaysBeforeOrAfterTodayFunction.FunctionName);
            }
            if(e.PropertyName == "Discount")
                e.Add(IsBlackFridayDiscountFunction.FunctionName);
        }

        //<icbDisplayStyle>
        void icbDisplayStyle_SelectedIndexChanged(object sender, EventArgs e) {
            FilterCriteriaDisplayStyle style = (FilterCriteriaDisplayStyle)icbDisplayStyle.EditValue;
            gridView1.OptionsView.FilterCriteriaDisplayStyle = style;
            filterControl1.LayoutChanged();
            lgColors.Visibility = style == FilterCriteriaDisplayStyle.Visual ? LayoutVisibility.Never : LayoutVisibility.Always;
        }
        //</icbDisplayStyle>
    }
}
