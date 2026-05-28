using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Menu;
using DevExpress.XtraDiagram;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraReports.Design;
using DevExpress.XtraVerticalGrid.Native;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraVerticalGrid.ViewInfo;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class PropertyGrid : TutorialControl {
        public PropertyGrid() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\VertGridMainDemo\\Modules\\PropertyGrid.cs";
        }
        protected override void OnFirstLoad() {
            base.OnFirstLoad();
            SetupModernView();
            DiagramControl.SelectItem(diagramShape6);
            DiagramControl.FitToDrawing();
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            if(DiagramControl != null)
                DiagramControl.FitToDrawing();
        }
        protected PropertyGridControl Grid {
            get { return propertyGridControl1; }
        }
        protected DiagramControl DiagramControl {
            get { return diagramControl1; }
        }
        protected void OnDiagramControlSelectionChanged(object sender, DiagramSelectionChangedEventArgs e) {
            Grid.SelectedObjects = DiagramControl.SelectedItems.ToArray();
            Grid.RetrieveFields();
        }
        protected virtual void SetupModernView() {
            Grid.BeginUpdate();
            Grid.ActiveViewType = PropertyGridView.Office;
            Grid.OptionsFind.Location = FindPanelLocation.TabPanel;
            Grid.OptionsFind.Visibility = FindPanelVisibility.Always;
            Grid.RecordWidth = 140;
            InitializeOfficeEditors();
            Grid.EndUpdate();
        }
        protected virtual void SetupClassicView() {
            Grid.BeginUpdate();
            Grid.ActiveViewType = PropertyGridView.Classic;
            Grid.OptionsFind.Location = FindPanelLocation.Default;
            Grid.OptionsFind.Visibility = FindPanelVisibility.Default;
            Grid.RecordWidth = 100;
            Grid.HideFindPanel();
            InitializeClassicEditors();
            Grid.EndUpdate();
        }
        protected void OnPropertyGridPopupMenuShowing(object sender, Events.PopupMenuShowingEventArgs e) {
            ChangeViewItem.Caption = Grid.IsClassic ? "Use Office view" : "Use Classic view";
            e.Menu.Items.Add(ChangeViewItem);
        }
        protected void OnPropertyGridCustomRowCreated(object sender, Events.CustomRowCreatedEventArgs e) {
            if(e.Row.Properties.FieldName == "Angle") SetupRowAngle(e.Row as PGridNumericEditorRow);
            if(e.Row.Properties.FieldName == "Appearance.BorderSize") SetupRowBorderSize(e.Row as PGridNumericEditorRow);
            if(e.Row.Properties.FieldName == "Appearance.Font.Size") SetupRowFontSize(e.Row as PGridNumericEditorRow);
            if(e.Row.Properties.FieldName == "Size.Width") SetupRowSize(e.Row as PGridNumericEditorRow);
            if(e.Row.Properties.FieldName == "Size.Height") SetupRowSize(e.Row as PGridNumericEditorRow);
            if(e.Row.Properties.FieldName == "MinSize.Width") SetupRowMinSize(e.Row as PGridNumericEditorRow);
            if(e.Row.Properties.FieldName == "MinSize.Height") SetupRowMinSize(e.Row as PGridNumericEditorRow);
            //if(e.Row.Properties.FieldName == "Appearance.TextOptions.VAlignment") {
            //    e.Row = new PGridVertAlignmentEditorRow();
            //    e.Handled = true;
            //}
        }
        protected void SetupRowAngle(PGridNumericEditorRow row) {
            row.MinValue = -180;
            row.MaxValue = 180;
            row.ShowTrackBar = true;
        }
        protected void SetupRowBorderSize(PGridNumericEditorRow row) {
            row.MinValue = 0;
            row.MaxValue = 30;
            row.ShowTrackBar = true;
        }
        protected void SetupRowFontSize(PGridNumericEditorRow row) {
            row.MinValue = 6;
            row.MaxValue = 72;
            row.ShowTrackBar = true;
        }
        protected void SetupRowSize(PGridNumericEditorRow row) {
            row.MinValue = 20;
            row.MaxValue = 500;
            row.ShowTrackBar = true;
        }
        protected void SetupRowMinSize(PGridNumericEditorRow row) {
            row.MinValue = 5;
            row.MaxValue = 50;
            row.ShowTrackBar = true;
        }
        
        protected void InitializeClassicEditors() {
            Grid.DefaultEditors.Clear();
            Grid.DefaultEditors.Add(new DefaultEditor(typeof(Color), ClassicColorPickEdit));
            Grid.DefaultEditors.Add(new DefaultEditor(typeof(bool), ClassicBooleanEditor));
        }
        protected void InitializeOfficeEditors() {
            Grid.DefaultEditors.Clear();
            Grid.DefaultEditors.Add(new DefaultEditor(typeof(Color), OfficeColorPickEdit));

            // Register custom editor 
            Grid.OfficeRowStore.UserStore[typeof(Font)] = new CreateRowEditor(CreateFontEditor);
            //Grid.OfficeRowStore.UserStore[typeof(HorzAlignment)] = new CreateRowEditor(CreateHorzAlignmentRow);
        }

        protected virtual PGridCustomEditorRow CreateFontEditor() {
            return new PGridFontEditorRow();
        }
        protected virtual PGridCustomEditorRow CreateHorzAlignmentRow() {
            return new PGridHorzAlignmentEditorRow();
        }

        PGRepositoryItemColorPickEdit officeColorPickEditCore;
        protected PGRepositoryItemColorPickEdit OfficeColorPickEdit {
            get { return officeColorPickEditCore ?? (officeColorPickEditCore = new PGRepositoryItemColorPickEdit()); }
        }

        RepositoryItemColorPickEdit classicColorPickEditCore;
        protected RepositoryItemColorPickEdit ClassicColorPickEdit {
            get { return classicColorPickEditCore ?? (classicColorPickEditCore = new RepositoryItemColorPickEdit()); }
        }

        RepositoryItemCheckEdit classicBooleanEditorCore;
        RepositoryItemCheckEdit ClassicBooleanEditor {
            get { return classicBooleanEditorCore ?? (classicBooleanEditorCore = new RepositoryItemCheckEdit()); }
        }

        DXMenuItem changeViewItemCore;
        protected DXMenuItem ChangeViewItem {
            get {
                if(changeViewItemCore == null)
                    changeViewItemCore = CreateChangeViewItem();
                return changeViewItemCore;
            }
        }
        protected virtual DXMenuItem CreateChangeViewItem() {
            DXMenuItem item = new DXMenuItem();
            item.BeginGroup = true;
            item.Click += delegate {
                if(Grid.IsClassic)
                    SetupModernView();
                else
                    SetupClassicView();
                Grid.RetrieveFields();
            };
            return item;
        }
        void OnPropertyGridInvalidValueException(object sender, InvalidValueExceptionEventArgs e) {
            if(e.Exception.GetType() == typeof(EditorValueException) && e.ErrorText.Contains("DefaultBoolean")) {
                Grid.HideEditor();
                e.ExceptionMode = ExceptionMode.Ignore;
            }
        }
    }

    class PGridVertAlignmentEditorRow : PGridContainerEditorRow {
        protected override PGridCustomEditorRowViewInfo CreateViewInfoCore() {
            return new PGridVertAlignmentEditorRowViewInfo(this);
        }
        public override object GetEditValue(RepositoryItemStoreElement element) {
            object value = Grid.GetCellValue(this, 0);
            if(value == null) return null;
            VertAlignment alignment = (VertAlignment)value;
            if(alignment == VertAlignment.Default)
                alignment = VertAlignment.Center;
            return alignment;
        }
    }
    class PGridHorzAlignmentEditorRow : PGridContainerEditorRow {
        protected override PGridCustomEditorRowViewInfo CreateViewInfoCore() {
            return new PGridHorzAlignmentEditorRowViewInfo(this);
        }
        public override object GetEditValue(RepositoryItemStoreElement element) {
            object value = Grid.GetCellValue(this, 0);
            if(value == null) return null;
            HorzAlignment alignment = (HorzAlignment)value;
            if(alignment == HorzAlignment.Default)
                alignment = HorzAlignment.Center;
            return alignment;
        }
    }

    class PGridAlignmentEditorRowViewInfoCore : PGridContainerEditorRowViewInfo {
        public PGridAlignmentEditorRowViewInfoCore(BaseRow row) : base(row) { }
        protected override int Indent {
            get { return ScaleUtils.ScaleValue(1); }
        }
        int checkButtonSizeCore = -1;
        protected virtual int CheckButtonSize {
            get {
                if(checkButtonSizeCore < 0)
                    checkButtonSizeCore = Row.Grid.ViewInfo.GetTextMinHeight();
                return checkButtonSizeCore;
            }
        }
        protected virtual RepositoryItemCheckButton GetCheckButton(string name, int group) {
            RepositoryItemCheckButton button = new RepositoryItemCheckButton();
            button.BorderStyle = BorderStyles.NoBorder;
            button.CheckBoxOptions.Style = CheckBoxStyle.Custom;
            button.ImageOptions.SvgImageSize = new Size(16, 16);
            button.ImageOptions.SvgImageContent = ResourceImageHelper.CreateSvgImageFromResources("Images.OfficeView.TextAlignmentRow." + name + ".svg", typeof(PGridVertAlignmentEditorRowViewInfo));
            button.RadioGroupIndex = group;
            button.Tag = name;
            return button;
        }
        protected override Rectangle CalcRepositoryItemBounds(RepositoryItemStoreElement element, Rectangle content) {
            int x = content.Right - (Indent + CheckButtonSize) * element.Bounds.X;
            int y = content.Y + (element.Bounds.Y * (CheckButtonSize + Indent));
            int width = element.Bounds.Width < 0 ? content.Width : element.Bounds.Width;
            int height = element.Bounds.Height < 0 ? CalcEditorHeight(element.Item) : element.Bounds.Height;
            return new Rectangle(x, y, width, height);
        }
    }
    class PGridVertAlignmentEditorRowViewInfo : PGridAlignmentEditorRowViewInfoCore {
        public PGridVertAlignmentEditorRowViewInfo() : this(null) { }
        public PGridVertAlignmentEditorRowViewInfo(BaseRow row) : base(row) { }
        protected override RepositoryItemContainer CreateContainer() {
            return new TextVertAlignmentRepositoryItemContainer();
        }
        protected override void PopulateContainer(RepositoryItemContainer container) {
            container.Store.CreateElement(GetCheckButton("VertAlignTop", 1), new Rectangle(1, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Top");
            container.Store.CreateElement(GetCheckButton("VertAlignMiddle", 1), new Rectangle(2, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Center");
            container.Store.CreateElement(GetCheckButton("VertAlignBottom", 1), new Rectangle(3, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Bottom");
        }
    }
    class PGridHorzAlignmentEditorRowViewInfo : PGridAlignmentEditorRowViewInfoCore {
        public PGridHorzAlignmentEditorRowViewInfo() : this(null) { }
        public PGridHorzAlignmentEditorRowViewInfo(BaseRow row) : base(row) { }
        protected override RepositoryItemContainer CreateContainer() {
            return new TextHorzAlignmentRepositoryItemContainer();
        }
        protected override void PopulateContainer(RepositoryItemContainer container) {
            container.Store.CreateElement(GetCheckButton("JustifyLeft", 2), new Rectangle(1, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Left");
            container.Store.CreateElement(GetCheckButton("JustifyCenter", 2), new Rectangle(2, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Center");
            container.Store.CreateElement(GetCheckButton("JustifyRight", 2), new Rectangle(3, 0, CheckButtonSize, CheckButtonSize), Row.Properties.FieldName, "Right");
        }
    }
        
    class TextVertAlignmentRepositoryItemContainer : RepositoryItemContainer {
        protected override object GetEditValue() {
            PGridVertAlignmentEditorRowViewInfo rvi = (PGridVertAlignmentEditorRowViewInfo)Tag;
            object value = rvi.Row.Grid.GetCellValue(rvi.Row, rvi.Row.Grid.FocusedRecord);
            if(((VertAlignment)value) == VertAlignment.Default)
                value = VertAlignment.Center;
            return value;
        }
    }
    class TextHorzAlignmentRepositoryItemContainer : RepositoryItemContainer {
        protected override object GetEditValue() {
            PGridHorzAlignmentEditorRowViewInfo rvi = (PGridHorzAlignmentEditorRowViewInfo)Tag;
            object value = rvi.Row.Grid.GetCellValue(rvi.Row, rvi.Row.Grid.FocusedRecord);
            if(((HorzAlignment)value) == HorzAlignment.Default)
                value = HorzAlignment.Center;
            return value;
        }
    }
}

