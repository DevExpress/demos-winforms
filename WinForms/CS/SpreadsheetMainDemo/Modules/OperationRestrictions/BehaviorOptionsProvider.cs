using System;
using System.ComponentModel;
using DevExpress.XtraSpreadsheet;

namespace DevExpress.Spreadsheet.Demos {
    public class BehaviorOptionsProvider {
        readonly SpreadsheetBehaviorOptions options;
        readonly SpreadsheetBehaviorClipboardOptionsProvider clipboardOptionsProvider;
        readonly SpreadsheetBehaviorCommonOptionsProvider commonOptionsProvider;
        readonly SpreadsheetBehaviorZoomOptionsProvider zoomOptionsProvider;
        readonly SpreadsheetBehaviorMiscellaneousOptionsProvider miscellaneousOptionsProvider;

        public BehaviorOptionsProvider(SpreadsheetBehaviorOptions options) {
            this.options = options;
            clipboardOptionsProvider = new SpreadsheetBehaviorClipboardOptionsProvider(options);
            commonOptionsProvider = new SpreadsheetBehaviorCommonOptionsProvider(options);
            zoomOptionsProvider = new SpreadsheetBehaviorZoomOptionsProvider(options);
            miscellaneousOptionsProvider = new SpreadsheetBehaviorMiscellaneousOptionsProvider(options);
        }

        public SpreadsheetBehaviorClipboardOptionsProvider Clipboard { get { return clipboardOptionsProvider; } }
        public SpreadsheetBehaviorCommonOptionsProvider Common { get { return commonOptionsProvider; } }
        public SpreadsheetBehaviorZoomOptionsProvider Zoom { get { return zoomOptionsProvider; } }
        public SpreadsheetWorksheetBehaviorOptions Worksheet { get { return options.Worksheet; } }
        public SpreadsheetCommentBehaviorOptions Comment { get { return options.Comment; } }
        public SpreadsheetColumnBehaviorOptions Column { get { return options.Column; } }
        public SpreadsheetGroupBehaviorOptions Group { get { return options.Group; } }
        public SpreadsheetRowBehaviorOptions Row { get { return options.Row; } }
        public SpreadsheetSelectionOptions Selection { get { return options.Selection; } }
        public SpreadsheetDrawingBehaviorOptions Drawing { get { return options.Drawing; } }
        public SpreadsheetBehaviorMiscellaneousOptionsProvider Miscellaneous { get { return miscellaneousOptionsProvider; } }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SpreadsheetBehaviorClipboardOptionsProvider {
        readonly SpreadsheetBehaviorOptions options;

        public SpreadsheetBehaviorClipboardOptionsProvider(SpreadsheetBehaviorOptions options) {
            this.options = options;
        }

        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability Cut { get { return options.Cut; } set { options.Cut = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability Copy { get { return options.Copy; } set { options.Copy = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability Paste { get { return options.Paste; } set { options.Paste = value; } }

        public override string ToString() {
            return String.Empty;
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SpreadsheetBehaviorCommonOptionsProvider {
        readonly SpreadsheetBehaviorOptions options;

        public SpreadsheetBehaviorCommonOptionsProvider(SpreadsheetBehaviorOptions options) {
            this.options = options;
        }

        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability Open { get { return options.Open; } set { options.Open = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability Save { get { return options.Save; } set { options.Save = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability SaveAs { get { return options.SaveAs; } set { options.SaveAs = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability Print { get { return options.Print; } set { options.Print = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability CreateNew { get { return options.CreateNew; } set { options.CreateNew = value; } }

        public override string ToString() {
            return String.Empty;
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SpreadsheetBehaviorZoomOptionsProvider {
        public const float MinZoomFactorDefault = 0.5f;
        public const float MaxZoomFactorDefault = 3;
        readonly SpreadsheetBehaviorOptions options;

        public SpreadsheetBehaviorZoomOptionsProvider(SpreadsheetBehaviorOptions options) {
            this.options = options;
        }

        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability Zoom { get { return options.Zooming; } set { options.Zooming = value; } }
        [DefaultValue(MinZoomFactorDefault)]
        public float MinZoomFactor { get { return options.MinZoomFactor; } set { options.MinZoomFactor = value; } }
        [DefaultValue(MaxZoomFactorDefault)]
        public float MaxZoomFactor { get { return options.MaxZoomFactor; } set { options.MaxZoomFactor = value; } }

        public override string ToString() {
            return String.Empty;
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SpreadsheetBehaviorMiscellaneousOptionsProvider {
        readonly SpreadsheetBehaviorOptions options;

        public SpreadsheetBehaviorMiscellaneousOptionsProvider(SpreadsheetBehaviorOptions options) {
            this.options = options;
        }

        [DefaultValue(CellEditorCommitMode.Auto)]
        public CellEditorCommitMode CellEditorCommitMode { get { return options.CellEditor.CommitMode; } set { options.CellEditor.CommitMode = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability FreezePanes { get { return options.FreezePanes; } set { options.FreezePanes = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability ShowPopupMenu { get { return options.ShowPopupMenu; } set { options.ShowPopupMenu = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability Touch { get { return options.Touch; } set { options.Touch = value; } }
        [DefaultValue(FunctionNameCulture.Auto)]
        public FunctionNameCulture FunctionNameCulture { get { return options.FunctionNameCulture; } set { options.FunctionNameCulture = value; } }
        [DefaultValue(true)]
        public bool FillHandleEnabled { get { return options.FillHandle.Enabled; } set { options.FillHandle.Enabled = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability Drag { get { return options.Drag; } set { options.Drag = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability Drop { get { return options.Drop; } set { options.Drop = value; } }
        [DefaultValue(DocumentCapability.Default)]
        public DocumentCapability MoveRange { get { return options.MoveRange; } set { options.MoveRange = value; } }

        public override string ToString() {
            return String.Empty;
        }
    }
}
