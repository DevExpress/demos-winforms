using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;

namespace DevExpress.XtraGrid.Views.Grid {
    public class GridViewWithButtons : GridView {
        private ButtonsPanel buttonsPanel;
        private ButtonsPanelInfo buttonsViewInfo;
        private GridColumn buttonsColumn;
        private ButtonsPanelInfoEventsProvider buttonsEventProvider;
        private bool showButtons = false;
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(buttonsEventProvider != null) {
                    buttonsEventProvider.Dispose();
                }
                buttonsEventProvider = null;
                if(buttonsPanel != null) {
                    buttonsPanel.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        Browsable(false)]
        public ButtonsPanel ButtonsPanel {
            get {
                if(buttonsPanel == null) {
                    buttonsPanel = new ButtonsPanel();
                }
                return buttonsPanel;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        Browsable(false)]
        public GridColumn ButtonsColumn {
            get {
                return buttonsColumn;
            }
            set {
                if(ButtonsColumn == value) {
                    return;
                }
                buttonsColumn = value;
                LayoutChangedSynchronized();
            }
        }
        protected ButtonsPanelInfoEventsProvider ButtonsEventProvider {
            get {
                return buttonsEventProvider;
            }
            set {
                if(ButtonsEventProvider == value) {
                    return;
                }
                if(buttonsEventProvider != null) {
                    buttonsEventProvider.Dispose();
                }
                buttonsEventProvider = value;
            }
        }
        protected ButtonsPanelInfo ButtonsViewInfo {
            get {
                if(buttonsViewInfo == null) {
                    buttonsViewInfo = new ButtonsPanelInfo();
                }
                if(buttonsViewInfo.ButtonsInfo.Count != ButtonsPanel.Buttons.Count) {
                    buttonsViewInfo = ButtonsPanel.Init();
                    if(buttonsEventProvider != null) {
                        buttonsEventProvider.Info = buttonsViewInfo;
                    }
                }
                return buttonsViewInfo;
            }
        }
        protected override void OnGridControlChanged(DevExpress.XtraGrid.GridControl prevControl) {
            base.OnGridControlChanged(prevControl);
            if(GridControl != null) {
                ButtonsEventProvider = new ButtonsPanelInfoEventsProvider(ButtonsViewInfo, GridControl);
            }
        }

        public bool ShowButtons {
            get {
                return showButtons;
            }
            set {
                if(ShowButtons == value) {
                    return;
                }
                showButtons = value;
                LayoutChangedSynchronized();
            }
        }
        protected override void RaiseCustomDrawCell(DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            base.RaiseCustomDrawCell(e);
            if(e.Column != null && e.Column == buttonsColumnInternal && e.RowHandle == FocusedRowHandle) {
                e.DefaultDraw();
                DrawButtonsPanel(e);
            }
        }

        private void DrawButtonsPanel(DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            var cell = e.Cell as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo;
            var bounds = cell.Bounds;
            if(cell.CellValueRect.Width > 0) {
                bounds.X = cell.CellValueRect.Right;
            }
            bounds.Width = cell.Bounds.Right - bounds.X;
            if(bounds.Width > 0) {
                ButtonsPanel.SetContext(GetRow(e.RowHandle));
                ButtonsPanel.Prepare(e.Cache.Graphics, ButtonsViewInfo, bounds);
                if(ButtonsViewInfo.IsReady) {
                    ButtonsViewInfo.Draw(e.Cache);
                }
            }
        }
        protected GridColumn buttonsColumnInternal = null;
        protected bool GetShowButtons() {
            return ShowButtons && ButtonsPanel.Buttons.Count > 0;
        }
        protected override void RefreshVisibleColumnsList() {
            base.RefreshVisibleColumnsList();
            if(GetShowButtons()) {
                var lastColumn = VisibleColumns.Count > 0 ? VisibleColumns[VisibleColumns.Count - 1] : null;
                buttonsColumnInternal = ButtonsColumn == null ? lastColumn : ButtonsColumn;
                if(ScrollInfo.IsOverlapScrollBar && buttonsColumnInternal != null && buttonsColumnInternal == lastColumn) {
                    ButtonsPanel.Padding = new System.Windows.Forms.Padding(0, 0, ScrollInfo.VScrollSize, 0);
                }
                else {
                    ButtonsPanel.Padding = new Padding(0, 0, 4, 0);
                }
                var bounds = ButtonsViewInfo.Bounds;
                if(bounds.IsEmpty) {
                    bounds = ViewRect;
                }
                ButtonsPanel.Prepare(null, ButtonsViewInfo, bounds);
            }
            else {
                buttonsColumn = null;
            }
        }
        protected override System.Windows.Forms.Padding GetRowCellPadding(GridColumn column) {
            if(column != null && column == buttonsColumnInternal) {
                if(buttonsViewInfo.Width > 0) {
                    return new System.Windows.Forms.Padding(0, 0, buttonsViewInfo.Width + 10, 0);
                }
            }
            return base.GetRowCellPadding(column);
        }
    }
}

namespace DevExpress.XtraEditors {
    using System.Linq.Expressions;
    using DevExpress.Data.Filtering.Helpers;
    using DevExpress.XtraEditors.Filtering;
    using DevExpress.XtraEditors.Repository;

    class FilterColumnCollectionBuilder<TEntity> {
        FilterColumnCollection filterColumns;
        public FilterColumnCollectionBuilder(FilterColumnCollection filterColumns) {
            this.filterColumns = filterColumns;
        }
        public FilterColumnCollection Build() {
            return filterColumns;
        }
        public FilterColumnCollectionBuilder<TEntity> AddColumn<T>(Expression<Func<TEntity, T>> expression,
            DevExpress.XtraEditors.Repository.RepositoryItem repositoryItem = null,
            FilterColumnClauseClass clauseClass = FilterColumnClauseClass.String, string caption = null) {
            if(repositoryItem == null) {
                if(typeof(T) == typeof(bool) || (typeof(T) == typeof(bool?))) {
                    repositoryItem = EditorHelpers.CreatEdit<RepositoryItemCheckEdit>();
                    clauseClass = FilterColumnClauseClass.Generic;
                }
                if((typeof(T) == typeof(double)) || (typeof(T) == typeof(double?)) || (typeof(T) == typeof(decimal)) || (typeof(T) == typeof(decimal?))) {
                    repositoryItem = EditorHelpers.CreatEdit<RepositoryItemSpinEdit>();
                    clauseClass = FilterColumnClauseClass.Generic;
                }
                if(typeof(T) == typeof(int) || (typeof(T) == typeof(int?))) {
                    var spinEdit = EditorHelpers.CreatEdit<RepositoryItemSpinEdit>();
                    spinEdit.IsFloatValue = false;
                    repositoryItem = spinEdit;
                    clauseClass = FilterColumnClauseClass.Generic;
                }
            }
            filterColumns.Add(CreateColumn(expression, caption, null, repositoryItem, clauseClass));
            return this;
        }
        public FilterColumnCollectionBuilder<TEntity> AddLookupColumn<T>(Expression<Func<TEntity, T>> expression) {
            return AddColumn(expression, EditorHelpers.CreateEnumImageComboBox<T>(), FilterColumnClauseClass.Lookup);
        }
        public FilterColumnCollectionBuilder<TEntity> AddDateTimeColumn<T>(Expression<Func<TEntity, T>> expression) {
            return AddColumn(expression, EditorHelpers.CreatDateEdit(), FilterColumnClauseClass.DateTime);
        }
        UnboundFilterColumn CreateColumn<T>(Expression<Func<TEntity, T>> expression, string caption, string fieldName,
            DevExpress.XtraEditors.Repository.RepositoryItem repositoryItem, FilterColumnClauseClass clauseClass) {
            var member = (expression.Body as MemberExpression).Member;
            if(string.IsNullOrEmpty(fieldName))
                fieldName = GetFieldName<T>(expression);
            if(string.IsNullOrEmpty(caption))
                caption = GetDisplayName(member);
            return CreateColumn<T>(caption, fieldName, repositoryItem, clauseClass);
        }
        UnboundFilterColumn CreateColumn<T>(string caption, string fieldName,
            DevExpress.XtraEditors.Repository.RepositoryItem repositoryItem, FilterColumnClauseClass clauseClass) {
            return new UnboundFilterColumn(caption, fieldName, typeof(T), repositoryItem, clauseClass);
        }
        string GetFieldName<T>(Expression<Func<TEntity, T>> expression) {
            var sb = new System.Text.StringBuilder();
            MemberExpression me = expression.Body as MemberExpression;
            while(me != null) {
                if(sb.Length > 0)
                    sb.Insert(0, ".");
                sb.Insert(0, me.Member.Name);
                me = me.Expression as MemberExpression;
            }
            return sb.ToString();
        }
        string GetDisplayName(System.Reflection.MemberInfo member) {
            string displayName = member.Name;
            if(CheckDisplayNameAttribute<System.ComponentModel.DataAnnotations.DisplayAttribute>(member, a => a.GetName(), ref displayName))
                return displayName;
            if(CheckDisplayNameAttribute<System.ComponentModel.DisplayNameAttribute>(member, a => a.DisplayName, ref displayName))
                return displayName;
            return displayName;
        }
        bool CheckDisplayNameAttribute<TAttribute>(System.Reflection.MemberInfo member, Func<TAttribute, string> accessor, ref string displayName)
            where TAttribute : Attribute {
            var displayAttributes = member.GetCustomAttributes(typeof(TAttribute), true);
            if(displayAttributes.Length > 0) {
                displayName = accessor((TAttribute)displayAttributes[0]);
                return true;
            }
            return false;
        }
    }
    static class FilterControlWithoutLike {
        public static void Apply(FilterControl filterControl) {
            filterControl.PopupMenuShowing += filterControl_PopupMenuShowing;
        }
        static void filterControl_PopupMenuShowing(object sender, XtraEditors.Filtering.PopupMenuShowingEventArgs e) {
            for(int i = e.Menu.Items.Count - 1; i >= 0; i--) {
                if(e.Menu.Items[i].Caption == Localizer.Active.GetLocalizedString(StringId.FilterClauseLike) ||
                    e.Menu.Items[i].Caption == Localizer.Active.GetLocalizedString(StringId.FilterClauseNotLike)) {
                    e.Menu.Items.RemoveAt(i);
                }
            }
        }
    }
    static class EditorHelpers {
        public static RepositoryItemImageComboBox CreateEnumImageComboBox<TEnum>(RepositoryItemImageComboBox edit = null, RepositoryItemCollection collection = null,
            Converter<TEnum, string> displayTextConverter = null) {
            return CreatEdit<RepositoryItemImageComboBox>(edit, collection, (e) => e.Items.AddEnum<TEnum>(displayTextConverter));
        }
        public static RepositoryItemDateEdit CreatDateEdit(RepositoryItemDateEdit edit = null, RepositoryItemCollection collection = null) {
            return CreatEdit<RepositoryItemDateEdit>(edit, collection);
        }
        public static TEdit CreatEdit<TEdit>(TEdit edit = null, RepositoryItemCollection collection = null, Action<TEdit> initialize = null)
            where TEdit : RepositoryItem, new() {
            edit = edit ?? new TEdit();
            if(collection != null) collection.Add(edit);
            if(initialize != null)
                initialize(edit);
            return edit;
        }
    }
}
