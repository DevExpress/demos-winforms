using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Mask;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Mask.Design;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleMaskBox : TutorialControl {
        static ModuleMaskBox() {
            // <DateRangeMaskManager>
            DateRangeMaskManager.Register();
            // </DateRangeMaskManager>
            RegisterSpecificCaseMaskManagerPreview();
        }
        public ModuleMaskBox() {
            InitializeComponent();
            if(!DesignMode) {
                tabPane.Pages.BeginUpdate();
                foreach(var info in GetMaskManagers()) {
                    var maskTypePageControl = new MaskTypePage(info.Item1, info.Item2);
                    var page = tabPane.AddPage(maskTypePageControl);
                    page.Caption = MaskManager.GetName(null, info.Item1);
                }
                tabPane.Pages.EndUpdate();
                settingsPanel.ViewModel = AdvancedSettingsEditorViewModelSimple.Create(GetMaskSettings(tabPane.SelectedPage));
            }
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ModuleMaskBox" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "maskbox"; }
        }
        protected override bool AllowCenterControls {
            get { return false; }
        }
        protected AdvancedSettingsEditorViewModelSimple SettingsViewModel {
            get { return (AdvancedSettingsEditorViewModelSimple)settingsPanel.ViewModel; }
        }
        MaskSettings GetMaskSettings(TabNavigationPage tabPage) {
            if(tabPage == null || tabPage.Controls.Count == 0)
                return null;
            var page = tabPage.Controls[0] as MaskTypePage;
            return (page != null) ? page.MaskSettings : null;
        }
        void OnSelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            if(e.Page == null || settingsPanel.ViewModel == null)
                return;
            SettingsViewModel.SetMaskSettings(GetMaskSettings(e.Page as TabNavigationPage));
        }
        IEnumerable<Tuple<Type, object>> GetMaskManagers() {
            yield return new Tuple<Type, object>(typeof(NumericMaskManager), 12345.67890m);
            yield return new Tuple<Type, object>(typeof(DateTimeMaskManager), DateTime.Now);
            yield return new Tuple<Type, object>(typeof(DateTimeOffsetMaskManager), DateTimeOffset.Now);
            yield return new Tuple<Type, object>(typeof(DevExpress.Data.Mask.TimeSpanMaskManager), new TimeSpan(12, 23, 34, 45, 789));
            yield return new Tuple<Type, object>(typeof(SimpleMaskManager), null);
            yield return new Tuple<Type, object>(typeof(RegularMaskManager), null);
            yield return new Tuple<Type, object>(typeof(RegExpMaskManager), null);
            yield return new Tuple<Type, object>(typeof(DateRangeMaskManager), new DateRange { From = DateTime.Now.AddDays(-5), To = DateTime.Now.AddDays(5) });
            yield return new Tuple<Type, object>(typeof(SpecificCaseMaskManager), "Lorem ipsum sit amet");
        }
        protected override void DoShow() {
            if(Parent != null)
                Parent.Padding = Padding.Empty;
            base.DoShow();
        }
        #region Show Code
        void ConfigureNumericMaskManager(TextEdit textEdit) {
            // <NumericMaskManager>
            var numericSettings = textEdit.Properties.MaskSettings.Configure<MaskSettings.Numeric>();
            numericSettings.MaskExpression = "c2";
            numericSettings.AutoHideDecimalSeparator = true;
            numericSettings.HideInsignificantZeros = true;
            numericSettings.ValueAfterDelete = NumericMaskManager.ValueAfterDelete.Null;
            numericSettings.ValueType = typeof(decimal);
            // </NumericMaskManager>
        }
        void ConfigureDateTimeMaskManager(TextEdit textEdit) {
            // <DateTimeMaskManager>
            var dateTimeSettings = textEdit.Properties.MaskSettings.Configure<MaskSettings.DateTime>();
            dateTimeSettings.MaskExpression = "g";
            dateTimeSettings.SpinWithCarry = true;
            dateTimeSettings.UseAdvancingCaret = true;
            // </DateTimeMaskManager>
        }
        void ConfigureDateTimeOffsetMaskManager(TextEdit textEdit) {
            // <DateTimeOffsetMaskManager>
            var dateTimeOffsetSettings = textEdit.Properties.MaskSettings.Configure<MaskSettings.DateTimeOffset>();
            dateTimeOffsetSettings.MaskExpression = "c";
            dateTimeOffsetSettings.SpinWithCarry = true;
            dateTimeOffsetSettings.UseAdvancingCaret = true;
            // </DateTimeOffsetMaskManager>
        }
        void ConfigureTimeSpanMaskManager(TextEdit textEdit) {
            // <TimeSpanMaskManager>
            var timeSpanSettings = textEdit.Properties.MaskSettings.Configure<MaskSettings.TimeSpan>();
            timeSpanSettings.MaskExpression = "t";
            timeSpanSettings.InputMode = TimeSpanMaskInputMode.NotRestrictedLargestUnit;
            timeSpanSettings.AllowNegativeValues = false;
            timeSpanSettings.EnableMnemonics = true;
            timeSpanSettings.HideInsignificantPartsOnly = true;
            timeSpanSettings.DefaultPart = TimeSpanMaskPart.Days;
            timeSpanSettings.ResetPartsOnSelectAllInput = true;
            timeSpanSettings.SpinWithCarry = true;
            timeSpanSettings.UseAdvancingCaret = true;
            // </TimeSpanMaskManager>
        }
        void ConfigureSimpleMaskManager(TextEdit textEdit) {
            // <SimpleMaskManager>
            var simpleSettings = textEdit.Properties.MaskSettings.Configure<MaskSettings.Simple>();
            simpleSettings.MaskExpression = "(000)000-00-00";
            simpleSettings.Placeholder = '_';
            simpleSettings.IgnoreBlank = true;
            simpleSettings.SaveLiterals = false;
            // </SimpleMaskManager>
        }
        void ConfigureRegularMaskManager(TextEdit textEdit) {
            // <RegularMaskManager>
            var regularSettings = textEdit.Properties.MaskSettings.Configure<MaskSettings.Regular>();
            regularSettings.MaskExpression = @"[0-9A-Z]{10}";
            regularSettings.Placeholder = '_';
            regularSettings.IgnoreBlank = true;
            regularSettings.SaveLiterals = false;
            // </RegularMaskManager>
        }
        void ConfigureRegExpMaskManager(TextEdit textEdit) {
            // <RegExpMaskManager>
            var regularSettings = textEdit.Properties.MaskSettings.Configure<MaskSettings.RegExp>();
            regularSettings.MaskExpression = @"\d+(\R.\d{0,2})?";
            regularSettings.Placeholder = '_';
            regularSettings.ShowPlaceholders = false;
            regularSettings.IsAutoComplete = true;
            // </RegExpMaskManager>
        }
        void ConfigureDateRangeMaskManager(TextEdit textEdit) {
            // <DateRangeMaskManager>
            var dateRangeSettings = textEdit.Properties.MaskSettings.Configure<CustomMaskSettings.DateRange>();
            dateRangeSettings.MaskExpression = "d";
            // </DateRangeMaskManager>
        }
        void ConfigureSpecificCaseMaskManager(TextEdit textEdit) {
            // <SpecificCaseMaskManager>
            var titleCaseSettings = textEdit.Properties.MaskSettings.Configure<CustomMaskSettings.SpecificCase>();
            titleCaseSettings.Case = SpecificCaseMaskManager.Case.Title;
            // </SpecificCaseMaskManager>
        }
        #endregion Show Code
        // <DateRangeMaskManager>
        public abstract partial class CustomMaskSettings : MaskSettings.User {
            public class DateRange : MaskSettingsWithCulture {
                protected override Type GetMaskManagerType() {
                    return typeof(DateRangeMaskManager);
                }
            }
        }
        // </DateRangeMaskManager>
        // <SpecificCaseMaskManager>
        public partial class CustomMaskSettings {
            public class SpecificCase : MaskSettingsWithCulture {
                protected override Type GetMaskManagerType() {
                    return typeof(SpecificCaseMaskManager);
                }
                public SpecificCaseMaskManager.Case Case {
                    get { return GetValue("case", SpecificCaseMaskManager.Case.Title); }
                    set { SetValue("case", value); }
                }
            }
        }
        // </SpecificCaseMaskManager>
        static void RegisterSpecificCaseMaskManagerPreview() {
            MaskManager.RegisterMaskManagerType(typeof(SpecificCaseMaskManager));
            MaskManager.RegisterMaskManagerInfo(typeof(SpecificCaseMaskManager), null, description: "Custom mask with a specific text input processing");
            MaskManager.RegisterMaskManagerInfo(typeof(SpecificCaseMaskManager),
                standardMaskSpecifiers: new MaskManager.ManagerInfo.StandardMaskSpecifier[] {
                    new MaskManager.ManagerInfo.StandardMaskSpecifier(null, "Custom text input processing", string.Empty, "Lorem ipsum sit amet"),
                },
                customPlaceholders: null, helpLink: null, standardHelpLink: null, customHelpLink: null, advancedSettingsLink: null);
        }
    }
    // <DateRangeMaskManager>
    public struct DateRange {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public override string ToString() {
            if(!From.HasValue && !To.HasValue)
                return "(Empty)";
            if(!From.HasValue)
                return To.Value.ToShortDateString();
            if(!To.HasValue)
                return From.Value.ToShortDateString();
            return From.Value.ToShortDateString() + DateRangeMaskManager.Separator + To.Value.ToShortDateString();
        }
    }
    [MaskManager.Compatible(typeof(DateTimeMaskManager))]
    public class DateRangeMaskManager : MaskManager {
        public static void Register() {
            RegisterMaskManagerType(typeof(DateRangeMaskManager));
            RegisterMaskManagerInfo(typeof(DateRangeMaskManager), null, description: "Mask to enter date ranges");
            RegisterMaskManagerInfo(typeof(DateRangeMaskManager),
                standardMaskSpecifiers: new ManagerInfo.StandardMaskSpecifier[] {
                    new ManagerInfo.StandardMaskSpecifier(null, "Short date format", "d", DateTime.Now.ToShortDateString() + Separator + DateTime.Now.AddDays(5).ToShortDateString()),
                    new ManagerInfo.StandardMaskSpecifier(null, "Month/day format", "m", DateTime.Now.ToString("m") + Separator + DateTime.Now.AddDays(35).ToString("m"))
                },
                customPlaceholders: null, helpLink: null, standardHelpLink: null, customHelpLink: null, advancedSettingsLink: null);
        }
        [Parameters("EditorsMainDemo, DevExpress.XtraEditors.Demos.DateRangeMaskManager", "Date Ranges (Custom Mask)")]
        public DateRangeMaskManager(
            [Parameter("mask", "Mask Expression")]
            string mask,
            [Parameter("cultureInfo")]
            [Parameter("culture", typeof(CultureInfoConverter), "Culture (name)", Visibility = ParameterVisibility.Advanced)]
            CultureInfo cultureInfo) {
            this.NestedManagers = InitializeNestedManagers(mask, cultureInfo);
        }
        // </DateRangeMaskManager>
        MaskManager[] InitializeNestedManagers(string mask, CultureInfo cultureInfo) {
            var nestedManagers = new MaskManager[] {
                    new DateTimeMaskManager(mask, true, cultureInfo, true, true),
                    new DateTimeMaskManager(mask, true, cultureInfo, true, true)
                };
            foreach(MaskManager nested in nestedManagers) {
                nested.EditTextChanging += Nested_EditTextChanging;
                nested.EditTextChanged += Nested_EditTextChanged;
                nested.LocalEditAction += Nested_LocalEditAction;
            }
            return nestedManagers;
        }
        void Nested_LocalEditAction(object sender, CancelEventArgs e) {
            e.Cancel = !RaiseModifyWithoutEditValueChange();
        }
        void Nested_EditTextChanging(object sender, MaskChangingEventArgs e) {
            e.Cancel = !RaiseEditTextChanging(e.NewValue);
        }
        void Nested_EditTextChanged(object sender, EventArgs e) {
            RaiseEditTextChanged();
        }
        public const string Separator = " - ";
        protected readonly MaskManager[] NestedManagers;
        protected int Index;
        protected MaskManager ActiveManager {
            get { return NestedManagers[Index]; }
        }
        public override string DisplayText {
            get { return string.Join(Separator, NestedManagers.Select(m => m.DisplayText)); }
        }
        protected int ActiveDisplayOffset {
            get { return Enumerable.Range(0, Index).Sum(i => NestedManagers[i].DisplayText.Length + Separator.Length); }
        }
        public override int DisplayCursorPosition {
            get { return ActiveDisplayOffset + ActiveManager.DisplayCursorPosition; }
        }
        public override int DisplaySelectionAnchor {
            get { return ActiveDisplayOffset + ActiveManager.DisplaySelectionAnchor; }
        }
        public override bool CanUndo {
            get { return ActiveManager.CanUndo; }
        }
        public override bool Backspace() {
            return ActiveManager.Backspace();
        }
        public override bool CursorEnd(bool forceSelection) {
            if(Index == NestedManagers.Length - 1 && ActiveManager.DisplaySelectionLength == ActiveManager.DisplayText.Length)
                return false;
            ActiveManager.FlushPendingEditActions();
            Index = NestedManagers.Length - 1;
            ActiveManager.SelectAll();
            return true;
        }
        public override bool CursorHome(bool forceSelection) {
            if(Index == 0 && ActiveManager.DisplaySelectionLength == ActiveManager.DisplayText.Length)
                return false;
            ActiveManager.FlushPendingEditActions();
            Index = NestedManagers.Length - 1;
            ActiveManager.SelectAll();
            return true;
        }
        public override bool CursorMoveNear(bool forceSelection, bool isNeededKeyCheck) {
            if(ActiveManager.DisplaySelectionLength != ActiveManager.DisplayText.Length) {
                bool nr = ActiveManager.CursorLeft(forceSelection, isNeededKeyCheck);
                if(nr || forceSelection)
                    return nr;
            }
            if(Index == 0)
                return false;
            if(isNeededKeyCheck)
                return true;
            ActiveManager.FlushPendingEditActions();
            --Index;
            ActiveManager.SelectAll();
            return true;
        }
        public override bool CursorMoveFar(bool forceSelection, bool isNeededKeyCheck) {
            if(ActiveManager.DisplaySelectionLength != ActiveManager.DisplayText.Length) {
                bool nr = ActiveManager.CursorRight(forceSelection, isNeededKeyCheck);
                if(nr || forceSelection)
                    return nr;
            }
            if(Index == NestedManagers.Length - 1)
                return false;
            if(isNeededKeyCheck)
                return true;
            ActiveManager.FlushPendingEditActions();
            ++Index;
            ActiveManager.SelectAll();
            return true;
        }
        public override bool CursorToDisplayPosition(int newPosition, bool forceSelection) {
            int runningoffset = 0, i = 0;
            do {
                runningoffset += NestedManagers[i].DisplayText.Length + Separator.Length;
                ++i;
            } while(newPosition >= runningoffset - Separator.Length / 2);
            int toEditorIndex = i - 1;
            if(toEditorIndex == Index)
                return ActiveManager.CursorToDisplayPosition(newPosition - ActiveDisplayOffset, forceSelection);
            if(forceSelection) {
                return false;
            }
            else {
                ActiveManager.FlushPendingEditActions();
                Index = toEditorIndex;
                ActiveManager.CursorToDisplayPosition(newPosition - ActiveDisplayOffset, forceSelection);
                return true;
            }
        }
        public override bool Delete() {
            return ActiveManager.Delete();
        }
        public override string GetCurrentEditText() {
            throw new NotImplementedException();
        }
        public override object GetCurrentEditValue() {
            return new DateRange {
                From = (DateTime?)NestedManagers[0].GetCurrentEditValue(),
                To = (DateTime?)NestedManagers[1].GetCurrentEditValue()
            };
        }
        public override bool Insert(string insertion) {
            return ActiveManager.Insert(insertion);
        }
        public override void SelectAll() {
            ActiveManager.SelectAll();
        }
        public override void SetInitialEditText(string initialEditText) {
            throw new NotImplementedException();
        }
        public override void SetInitialEditValue(object initialEditValue) {
            if(!(initialEditValue is DateRange)) {
                foreach(var m in NestedManagers)
                    m.SetInitialEditValue(null);
            }
            else {
                var range = (DateRange)initialEditValue;
                NestedManagers[0].SetInitialEditValue(range.From);
                NestedManagers[0].SelectAll();
                NestedManagers[1].SetInitialEditValue(range.To);
                NestedManagers[1].SelectAll();
            }
            Index = 0;
        }
        public override bool FlushPendingEditActions() {
            bool result = false;
            for(int i = 0; i < NestedManagers.Length; ++i)
                result |= NestedManagers[i].FlushPendingEditActions();
            return result;
        }
        public override bool SpinDown() {
            return ActiveManager.SpinDown();
        }
        public override bool SpinUp() {
            return ActiveManager.SpinUp();
        }
        public override bool Undo() {
            return ActiveManager.Undo();
        }
    }
    // <SpecificCaseMaskManager>
    public class SpecificCaseMaskManager : CustomTextMaskManager {
        public enum Case { Title, Upper, Lower }
        readonly Case @case;
        [Parameters("EditorsMainDemo, DevExpress.XtraEditors.Demos.SpecificCaseMaskManager", "Specific Case (Custom Mask)")]
        public SpecificCaseMaskManager(
            [Parameter("case", "Specific Case")]
            Case @case = Case.Title,
            [Parameter("tag", "Tag", Visibility = ParameterVisibility.Hidden)]
            object tag = null) : base(tag) {
            this.@case = @case;
        }
        protected override void ProcessCustomTextMaskInput(CustomTextMaskInputArgs ea) {
            if(ea.IsCanceled)
                return;
            var textInfo = CultureInfo.InvariantCulture.TextInfo;
            switch(@case) {
                case Case.Title:
                    ea.SetResult(textInfo.ToTitleCase(ea.ResultEditText), ea.ResultCursorPosition, ea.ResultSelectionAnchor);
                    break;
                case Case.Upper:
                    ea.SetResult(textInfo.ToUpper(ea.ResultEditText), ea.ResultCursorPosition, ea.ResultSelectionAnchor);
                    break;
                case Case.Lower:
                    ea.SetResult(textInfo.ToLower(ea.ResultEditText), ea.ResultCursorPosition, ea.ResultSelectionAnchor);
                    break;
            }
        }
    }
    // </SpecificCaseMaskManager>
    //
    #region Infrastructural Code
    public partial class MaskTypePage : MaskSettingsForm.PropertyEditorBase {
        readonly RepositoryItemTextEdit settingsSource = new RepositoryItemTextEdit();
        internal MaskTypePage(Type maskManagerType, object editValue) {
            settingsSource.MaskSettings.MaskManagerType = maskManagerType;
            settingsSource.UseMaskAsDisplayFormat = true;
            InitializeComponent(maskManagerType, editValue);
            ScrollBarBase.ApplyFluent(scrollableContainer);
            EnsureAutoScaleMode();
        }
        void EnsureAutoScaleMode() {
            if(Utils.DPI.DpiAwarenessHelper.Default.IsPerMonitor())
                this.AutoScaleMode = AutoScaleMode.Inherit;//PM2
        }
        public MaskSettings MaskSettings {
            get { return settingsSource.MaskSettings; }
        }
        #region Component Designer generated code
        void InitializeComponent(System.Type maskManagerType, object editValue) {
            this.rootPanel = new DevExpress.Utils.Layout.TablePanel();
            this.masksPreview = new DevExpress.XtraEditors.Mask.Design.MasksPreview();
            this.scrollableContainer = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.rootPanel)).BeginInit();
            this.rootPanel.SuspendLayout();
            this.scrollableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.AutoSize = true;
            this.rootPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 400F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.rootPanel.Controls.Add(this.masksPreview);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.rootPanel.Size = new System.Drawing.Size(600, 600);
            this.rootPanel.TabIndex = 0;
            // 
            // masksPreview
            // 
            this.masksPreview.AutoSize = true;
            this.rootPanel.SetColumn(this.masksPreview, 1);
            this.masksPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masksPreview.Location = new System.Drawing.Point(100, 0);
            this.masksPreview.Margin = new Padding(0, 40, 0, 40);
            this.masksPreview.Name = maskManagerType.Name;
            this.rootPanel.SetRow(this.masksPreview, 0);
            this.masksPreview.ViewModel = DevExpress.XtraEditors.Mask.Design.MasksPreviewViewModel.Create(maskManagerType, editValue, settingsSource);
            // 
            // scrollableContainer
            // 
            this.scrollableContainer.Controls.Add(this.rootPanel);
            this.scrollableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableContainer.Location = new System.Drawing.Point(0, 0);
            this.scrollableContainer.Margin = new System.Windows.Forms.Padding(0);
            this.scrollableContainer.Name = "scrollableContainer";
            this.scrollableContainer.Size = new System.Drawing.Size(600, 600);
            // 
            // MaskTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scrollableContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MaskTypePage";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.rootPanel)).EndInit();
            this.rootPanel.ResumeLayout(false);
            this.rootPanel.PerformLayout();
            this.scrollableContainer.ResumeLayout(false);
            this.scrollableContainer.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private DevExpress.Utils.Layout.TablePanel rootPanel;
        private DevExpress.XtraEditors.Mask.Design.MasksPreview masksPreview;
        private DevExpress.XtraEditors.XtraScrollableControl scrollableContainer;
    }
    #endregion Infrastructural Code
}
