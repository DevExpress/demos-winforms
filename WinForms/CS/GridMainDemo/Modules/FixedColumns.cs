using System;
using System.Data;
using DevExpress.XtraGrid.Views.Grid; 
using DevExpress.XtraGrid.Columns; 
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for FixedColumns.
	/// </summary>
	public partial class FixedColumns : TutorialControl {
		public FixedColumns() {
			//
			// Required for Windows Form Designer support
			//
			CreateWaitDialog();
			InitializeComponent();
            InitNWindData();
			InitEditing();
            InitColumns();
            InitFixedStyle();
            InitGridFixedColumnHighlightMode();
            gridView1.OptionsPrint.PrintFixedColumnsOnEveryPage = true; //TODO
			colCountry.Fixed = FixedStyle.MiddleLeft;
			colAddress.Fixed = FixedStyle.MiddleLeft;
            icbFixedColumnHighlightMode.EditValue = CurrentGridView.OptionsView.FixedColumnHighlightMode;
            UpdateFixedLineWidth();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "FixedColumns" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "FixedColumns"; }
        }

        #region Init
		public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView1; } }
		private GridView CurrentGridView { get { return gridView1; }}
        protected override DataSet InitNWindXMLData(string dataFileName) {
            DataSet dataSet = new DataSet();
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            dataSet.ReadXml(dataFileName);
            gridControl2.DataSource = dataSet.Tables["Customers"];
            return dataSet;
        }
		private void InitEditing() {
			numFixedLineWidth1.Value = CurrentGridView.FixedLineWidth;
		}
		private void FixedColumns_Load(object sender, System.EventArgs e) {
			gridControl2.ForceInitialize();
			CurrentGridView.ExpandAllGroups();
            
            //<gridControl2>
            /*
            ~The following properties are specified at design-time and listed here for demonstration purposes
            
            colCompanyName.Fixed = FixedStyle.Left;
            */
            //</gridControl2>
		}
        void InitColumns() {
            icbColumn.Properties.SmallImages = gridView1.Images;
            icbColumn.Properties.Sorted = true;
            foreach(GridColumn col in gridView1.Columns) {
                if(col.Visible)
                    icbColumn.Properties.Items.Add(new ImageComboBoxItem(col.GetTextCaption(), col, col.ImageIndex));
            }
            icbColumn.EditValue = colCompanyName;
        }

        void InitFixedStyle() {
            foreach(FixedStyle style in Enum.GetValues(typeof(FixedStyle)))
                icbFixedStyle.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FixedStyle>.GetTitle(style), style, -1));
        }
        void InitGridFixedColumnHighlightMode() {
            foreach(GridFixedColumnHighlightMode mode in Enum.GetValues(typeof(GridFixedColumnHighlightMode)))
                if(mode != GridFixedColumnHighlightMode.Default)
                    icbFixedColumnHighlightMode.Properties.Items.Add(new ImageComboBoxItem(mode.ToString(), mode, -1));
        }
        #endregion
        #region Editing
        //<numFixedLineWidth1>
        private void numFixedLineWidth1_ValueChanged(object sender, System.EventArgs e) {
			CurrentGridView.FixedLineWidth = (int)numFixedLineWidth1.Value;
		}
        //</numFixedLineWidth1>
		#endregion	
		#region Grid events
		private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e) {
			if(e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Column) {
				DevExpress.XtraGrid.Menu.GridViewColumnMenu menu = e.Menu as DevExpress.XtraGrid.Menu.GridViewColumnMenu;
				if(menu.Column != null) {
                    menu.Items.Clear();
                    menu.Items.Add(CreateCheckItem(Properties.Resources.NotFixed, menu.Column, FixedStyle.None, svgImageCollection1["NotFixed"]));
					menu.Items.Add(CreateCheckItem(Properties.Resources.FixedLeft, menu.Column, FixedStyle.Left, svgImageCollection1["FixedLeft"]));
					menu.Items.Add(CreateCheckItem(Properties.Resources.FixedRight, menu.Column, FixedStyle.Right, svgImageCollection1["FixedRight"]));
                    menu.Items.Add(CreateCheckItem(Properties.Resources.MiddleLeft, menu.Column, FixedStyle.MiddleLeft, svgImageCollection1["FixedLeft"]));
                }
			}
		}
		#endregion
		#region New column menu
		DXMenuCheckItem CreateCheckItem(string caption, GridColumn column, FixedStyle style, SvgImage image) {
			DXMenuCheckItem item = new DXMenuCheckItem(caption, column.Fixed == style, null, new EventHandler(OnFixedClick));
            item.ImageOptions.SvgImage = image;
            item.ImageOptions.SvgImageSize = svgImageCollection1.ImageSize;
            item.Tag = new MenuInfo(column, style);
			return item;
		}
		void OnFixedClick(object sender, EventArgs e) {
			DXMenuItem item = sender as DXMenuItem;
			MenuInfo info = item.Tag as MenuInfo;
			if(info == null) return;
			info.Column.Fixed = info.Style;
            UpdateColumnFixed();
            UpdateFixedLineWidth();
        }
		class MenuInfo {
			public MenuInfo(GridColumn column, FixedStyle style) {
				Column = column;
				this.Style = style;
			}
            public FixedStyle Style;
			public GridColumn Column;
        }
		#endregion

        
        private void icbColumn_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateColumnFixed();
        }

        void UpdateColumnFixed() {
            GridColumn col = icbColumn.EditValue as GridColumn;
            if(col == null) return;
            icbFixedStyle.EditValue = col.Fixed;
        }
        //<icbFixedStyle>
        private void icbFixedStyle_SelectedIndexChanged(object sender, EventArgs e) {
            GridColumn col = icbColumn.EditValue as GridColumn;
            if(col == null) return;
            col.Fixed = (FixedStyle)icbFixedStyle.EditValue;
        }
        //</icbFixedStyle>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion

        private void icbFixedColumnHighlightMode_SelectedIndexChanged(object sender, EventArgs e) {
            ImageComboBoxEdit edit = sender as ImageComboBoxEdit;
            if(edit == null) return;
            CurrentGridView.OptionsView.FixedColumnHighlightMode = (GridFixedColumnHighlightMode)edit.EditValue;
            UpdateFixedLineWidth();
        }

        void UpdateFixedLineWidth() {
            lciFixedLineWidth.Enabled = CurrentGridView.OptionsView.FixedColumnHighlightMode == GridFixedColumnHighlightMode.Line && !IsMiddleFixedExist;
            icbFixedColumnHighlightMode.Enabled = !IsMiddleFixedExist;
            sbMiddleColumns.Text = MiddleColumnCaption;
        }

        string MiddleColumnCaption {
            get {
                return string.Concat(IsMiddleFixedExist ? "Clear" : "Apply", " 'Fixed Left (Dynamic)' Style");
            }
        }
        bool IsMiddleFixedExist {
            get {
                foreach(GridColumn col in CurrentGridView.Columns)
                    if(col.Fixed == FixedStyle.MiddleLeft) return true;
                return false;
            }
        }

        private void sbMiddleColumns_Click(object sender, EventArgs e) {
            if(IsMiddleFixedExist) {
                foreach(GridColumn col in CurrentGridView.Columns)
                    if(col.Fixed == FixedStyle.MiddleLeft) col.Fixed = FixedStyle.None;
            }
            else {
                colCountry.Fixed = FixedStyle.MiddleLeft;
                colAddress.Fixed = FixedStyle.MiddleLeft;
            }
            UpdateFixedLineWidth();
        }
    }
}
