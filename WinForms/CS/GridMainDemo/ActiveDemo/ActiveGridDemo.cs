using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Card.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils.Drawing;
using System.Windows.Forms;

namespace DevExpress.ActiveDemos {
	public class ActiveGridDemo: ActiveDemo {
		GridControl fgridControl;
		public ActiveGridDemo(GridControl fgridControl) {
			this.fgridControl = fgridControl;
		}
		public GridControl GridControl { get { return this.fgridControl; } }
		public BaseView ActiveView { get { return GridControl.DefaultView; } } //TODO
		public GridView ActiveGridView {
			get {
				if((ActiveView != null) && (ActiveView is GridView))
					return ActiveView as GridView;
				else return null;
			}
		}
		public BandedGridView ActiveBandedGridView {
			get {
				if((ActiveView != null) && (ActiveView is BandedGridView))
					return ActiveView as BandedGridView;
				else return null;
			}
		}
		public GridViewInfo ActiveGridViewInfo {
			get {
				if(ActiveGridView != null) {
					return GetGridViewInfo(ActiveGridView);
				} else return null;
			}
		}
		public BandedGridViewInfo ActiveBandedGridViewInfo {
			get {
				if(ActiveBandedGridView != null) {
					PropertyInfo propertyInfo = typeof(BandedGridView).GetProperty("ViewInfo");
					if(propertyInfo != null)
						return propertyInfo.GetValue(ActiveGridView, null) as BandedGridViewInfo;
					else return null;
				} else return null;
			}
		}
		public void SelectCellByMouse(GridColumn column, int row) {
			if(Actions.Canceled || (column == null) || (column.VisibleIndex  < 0)) return;
			if(column.View is GridView) {
				GridView gridView = column.View as GridView;
				gridView.MakeColumnVisible(column);
				GridViewInfo viewInfo = GetGridViewInfo(gridView);
				GridCellInfo cell = viewInfo.GetGridCellInfo(row, column);
				if(cell != null) {
					Rectangle r = cell.Bounds;
					Actions.MouseClick(fgridControl, new Point(r.Left + r.Width / 2, r.Top + r.Height / 2));
				}
			}
		}
		public void SelectCellByKeyBoard(GridColumn column, int row) {
			if(Actions.Canceled || (column == null) || (column.VisibleIndex  < 0)) return;
			if(column.View is GridView) {
				GridView gridView = column.View as GridView;
				if(gridView.FocusedColumn == null)
					SelectCellByMouse(column, row);
				else {
					while(gridView.FocusedColumn != column) {
						if(Actions.Canceled) return;
						if(gridView.FocusedColumn.VisibleIndex < column.VisibleIndex)
							Actions.SendString(GridControl, "[Right]");
						else Actions.SendString(GridControl, "[Left]");
					}
					if((row > -1) && (row < gridView.RowCount)) {
						while(GetFocusedRow(gridView) != row) {
							if(Actions.Canceled) return;
							if(GetFocusedRow(gridView) > row)
								Actions.SendString(GridControl, "[Up]");
							else Actions.SendString(GridControl, "[Down]");
						}
					}
				}
			}
		}
		public void ClickGridColumn(GridColumn column) {
			if(Actions.Canceled || (column == null) || (column.VisibleIndex  < 0)) return;
			if(column.View is GridView) 
				Actions.MouseClick(this.GridControl, GetColumnLocationAtCenter(column)); 
		}
		public void GroupByColumn(GridColumn column) {
			GroupByColumn(column, column.View.SortInfo.GroupCount);
		}
		public void GroupByColumn(GridColumn column, int groupIndex) {
			if(Actions.Canceled || (column == null) || (column.VisibleIndex  < 0)) return;
			if(column.View is GridView) {
				GridView gridView = column.View as GridView;
				gridView.OptionsView.ShowGroupPanel = true;
				gridView.MakeColumnVisible(column);
				GridViewInfo viewInfo = GetGridViewInfo(gridView);
				if(groupIndex < 0) 
					groupIndex = 0;
				if(groupIndex >= gridView.SortInfo.GroupCount) 
					groupIndex = gridView.SortInfo.GroupCount;
				Rectangle r = viewInfo.ViewRects.GroupPanel;
				Point pt;
				if(groupIndex == 0)
					pt = new Point(r.Left + 2, r.Top + 2);
				else {
					r = viewInfo.GroupPanel.Rows[groupIndex - 1].Bounds;
					//r = viewInfo.GroupPanel.Rows[groupIndex - 1].CaptionInfo.CaptionRect;
					pt = new Point(r.Left + groupIndex * 100, r.Bottom - 5); //TODO
				}
				Actions.MouseDown(this.fgridControl, GetColumnLocationAtCenter(column));
				Actions.MoveMousePointTo(this.fgridControl, pt);
				Actions.MouseUp(this.fgridControl, pt);
			}
		}
		public void ClickMasterRecordIcon(GridView view, int row) {
			if(Actions.Canceled) return;
			GridViewInfo viewInfo = GetGridViewInfo(view);
			if(viewInfo == null) return;
			if(row < viewInfo.RowsInfo.Count) {
				GridDataRowInfo rowInfo = viewInfo.RowsInfo[row] as GridDataRowInfo;
				if(rowInfo != null && rowInfo.IsMasterRow) {
					Rectangle r = Rectangle.Empty;
					foreach(GridCellInfo cellInfo in rowInfo.Cells)
						if(! cellInfo.CellButtonRect.IsEmpty) {
							r = cellInfo.CellButtonRect;
							break;
						}
					ActiveActions.Delay(1000);
					if(! r.IsEmpty) 
						Actions.MouseClick(fgridControl, new Point(r.Left + r.Width / 2, r.Top + r.Height / 2));
				}
			}
		}
		public void ColumnResize(GridColumn column, int delta) {
			if(column != null && column.View is GridView) 
				ColumnResize(column, column.View as GridView, delta);
		}
		public void ColumnResize(GridColumn column, GridView view, int delta) {
			if(Actions.Canceled || (view == null) || (column == null) || (column.VisibleIndex  < 0)) return;
			GridViewInfo viewInfo = GetGridViewInfo(view);
			if(viewInfo == null) return;
			Rectangle r = GetGridColumnInfo(view, column).Bounds;
			Point pt = new Point(r.Right, r.Top + r.Height / 2);
			Actions.MouseDown(this.fgridControl, pt);
			pt.X += delta;
			Actions.MoveMousePointTo(this.fgridControl, pt);
			Actions.MouseUp(this.fgridControl, pt);
		}
		public void ColumnBestFit(GridColumn column) {
			ColumnBestFit(column, string.Empty);
		}
		public void ColumnBestFit(GridColumn column, string message) {
			if(column != null && column.View is GridView) 
				ColumnBestFit(column, column.View as GridView, message);
		}
		public void ColumnBestFit(GridColumn column, GridView view) {
			ColumnBestFit(column, view, string.Empty);
		}
		public void ColumnBestFit(GridColumn column, GridView view, string message) {
			if(Actions.Canceled || (view == null) || (column == null) || (column.VisibleIndex  < 0)) return;
			GridViewInfo viewInfo = GetGridViewInfo(view);
			if(viewInfo == null) return;
			Rectangle r = GetGridColumnInfo(view, column).Bounds;
			Point pt = new Point(r.Right, r.Top + r.Height / 2);
			Actions.MoveMousePointTo(fgridControl, pt);
			if(message != string.Empty)
				ShowMessage(message);
			else ActiveActions.Delay(300);
			Actions.MouseDblClick(fgridControl, pt);
		}
		public void ViewZoom(GridView view) {
			ViewZoom(view, string.Empty);
		}
		public void ViewZoom(GridView view, string message) {
			if(Actions.Canceled) return;
			GridViewInfo viewInfo = GetGridViewInfo(view);
			if(viewInfo == null) return;
			for(int i = 0; i < viewInfo.ColumnsInfo.Count; i ++)
				if(viewInfo.ColumnsInfo[i].Type == GridColumnInfoType.Indicator) {
					Point pt = GetPointAtCenter(viewInfo.ColumnsInfo[i].Bounds);
					Actions.MoveMousePointTo(fgridControl, pt);
					if(message != string.Empty)
						ShowMessage(message);
					Actions.MouseClick(fgridControl, pt);
					break;
				}
		}
		public void ExpandCollapseRow(GridView view, int groupRow) {
			if(Actions.Canceled) return;
			GridViewInfo viewInfo = GetGridViewInfo(view);
			int groupRowCount = 0;
			if(viewInfo == null) return;
			for(int i = 0; i < viewInfo.RowsInfo.Count; i ++) {
				if(viewInfo.RowsInfo[i].IsGroupRow) {
					if(groupRowCount == groupRow) {
						Actions.MouseClick(fgridControl, GetPointAtCenter(((GridGroupRowInfo)viewInfo.RowsInfo[i]).ButtonBounds));
						break;
					}
					groupRowCount ++;
				}
			}
		}
		public Rectangle GetGroupPanelRectangle(GridView view) {
			if(Actions.Canceled) return Rectangle.Empty;
			GridViewInfo viewInfo = GetGridViewInfo(view);
			return viewInfo.ViewRects.GroupPanel;
		}
		public void ClickControlNavigatorButton(NavigatorButtonType buttonType) {
			if(Actions.Canceled) return;
			NavigatorButton button = GridControl.EmbeddedNavigator.Buttons.ButtonByButtonType(buttonType);
			if(button == null) return;
			NavigatorButtonsViewInfo viewInfo = GetGridNavigatorButtonsViewInfo();
			if(viewInfo == null) return;
			NavigatorButtonViewInfo buttonViewInfo = viewInfo.GetButtonViewInfo(button);
			if((buttonViewInfo == null) || (buttonViewInfo.Bounds.IsEmpty)) return;
			Point pt = GridControl.PointToScreen(GridControl.EmbeddedNavigator.Location);
			pt.X += buttonViewInfo.Bounds.X + buttonViewInfo.Bounds.Width / 2;
			pt.Y += buttonViewInfo.Bounds.Y + buttonViewInfo.Bounds.Height / 2;
			Actions.MouseClick(pt);
			ActiveActions.Delay(300);
		}
		Point GetColumnLocationAtCenter(GridColumn column) {
			GridView gridView = column.View as GridView;
			gridView.MakeColumnVisible(column);
			GridViewInfo viewInfo = GetGridViewInfo(gridView);
			return GetPointAtCenter(viewInfo.ColumnsInfo[column].Bounds);
		}
        public static GridViewInfo GetGridViewInfo(GridView gridView) {
            if(gridView == null) return null;
            GridViewInfo res = gridView.GetViewInfo() as GridViewInfo;
            if(res == null) return null;
            if(!res.IsReady) gridView.LayoutChanged();
            return res;
        }
        int GetFocusedRow(GridView gridView) {
			return (int) gridView.FocusedRowHandle;
		}
		GridColumnInfoArgs GetGridColumnInfo(GridColumn column) {
			return GetGridColumnInfo(column.View as GridView, column);
		}
		GridColumnInfoArgs GetGridColumnInfo(GridView view, GridColumn column) {
			if(column.View != view)
				foreach(GridColumn col in view.Columns)
					if(col.Name == column.Name) {
						column = col;
						break;
					}
			GridViewInfo viewInfo = GetGridViewInfo(view);
			return viewInfo.ColumnsInfo[column];
		}
		NavigatorButtonsViewInfo GetGridNavigatorButtonsViewInfo() {
			PropertyInfo propertyInfo = GridControl.EmbeddedNavigator.Buttons.GetType().GetProperty("ViewInfo", BindingFlags.Instance | BindingFlags.GetProperty | BindingFlags.NonPublic, null, typeof(NavigatorButtonsViewInfo), new Type[0], null);
			if(propertyInfo != null)
				return propertyInfo.GetValue(GridControl.EmbeddedNavigator.Buttons, null) as NavigatorButtonsViewInfo;
			else return null;
		}
		//---------------------------------------------------------------
		public void ClickGridColumnAtFilterButton(GridColumn column) {
			ClickGridColumnAtElement(column, typeof(GridFilterButtonInfoArgs));
		}
		public void ClickGridColumnAtElement(GridColumn column, Type type) {
			if(Actions.Canceled || (column == null) || (column.VisibleIndex  < 0)) return;
			if(column.View is GridView) {
				Point p = GetColumnLocationAtElement(column, type);
				if(p != Point.Empty)
					Actions.MouseClick(this.GridControl, p); 
			} 
		}
		Point GetColumnLocationAtElement(GridColumn column, Type type) {
			GridView gridView = column.View as GridView;
			gridView.MakeColumnVisible(column);
			GridViewInfo viewInfo = GetGridViewInfo(gridView);
			ObjectInfoArgs args = null;
			foreach(DrawElementInfo info in  viewInfo.ColumnsInfo[column].InnerElements) {
				if(info.ElementInfo.GetType().Equals(type)) {
					args = info.ElementInfo;
					break;
				}
			}
			if(args != null) return GetPointAtCenter(args.Bounds);
			return Point.Empty;
		}
	}
}
