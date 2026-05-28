using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Demos.Modules.CustomDraw;
using Color = System.Drawing.Color;

namespace DevExpress.XtraRichEdit.Demos {
    public class CustomDrawPagePainter : PagePainter {
        public List<CustomDrawHighlightInfo> LayoutElementHighlights { get; set; }
        public List<CustomDrawHighlightInfo> LayoutRowHighlights { get; set; }

        const int OutlineHighlightThicknessLayoutUnits = 2;
        static readonly Color defaultHighlightColor = Color.Yellow;
        static readonly CustomDrawHighlightType defaultHighlightType = CustomDrawHighlightType.Fill;
        static readonly Color defaultRowHighlightColor = Color.Blue;
        static readonly CustomDrawHighlightType defaultRowHighlightType = CustomDrawHighlightType.Outline;
        readonly RichEditControl _richEditControl;

        public CustomDrawPagePainter(RichEditControl richEdit) {
            _richEditControl = richEdit;
        }
        public CustomDrawPagePainter(RichEditControl richEdit, List<FixedRange> rangesForHighlight, FixedRange rangeForRowHighlight)
            : this(richEdit) {
            LayoutElementHighlights = rangesForHighlight.Select(r => new CustomDrawHighlightInfo(r, defaultHighlightType, defaultHighlightColor)).ToList();
            LayoutRowHighlights = new List<CustomDrawHighlightInfo>();
            if(rangeForRowHighlight != null)
                LayoutRowHighlights.Add(new CustomDrawHighlightInfo(rangeForRowHighlight, defaultRowHighlightType, defaultRowHighlightColor));
        }

        bool IsHighlightingAllowed { get; set; }

        public override void DrawPageArea(LayoutPageArea pageArea) {
            IsHighlightingAllowed = true;
            base.DrawPageArea(pageArea);
            IsHighlightingAllowed = false;
        }
        public override void DrawRow(LayoutRow row) { 
            if(IsHighlightingAllowed && LayoutRowHighlights != null) {
                var highlightBounds = row.Bounds;
                if(row.Parent is LayoutTableCell parentLayoutCell) {
                    highlightBounds.X = parentLayoutCell.Bounds.X;
                    highlightBounds.Width = parentLayoutCell.Bounds.Width;
                }
                foreach(var rowHighlight in LayoutRowHighlights.Where(rh => row.Range.Intersect(rh.HighlightRange))) {
                    DrawHighlight(rowHighlight.HighlightColor, highlightBounds, rowHighlight.HighlightType);
                }
            }
            base.DrawRow(row);
        }
        public override void DrawPlainTextBox(PlainTextBox plainTextBox) {
            HighlightElement(plainTextBox);
            base.DrawPlainTextBox(plainTextBox);
        }
        public override void DrawPageNumberBox(PlainTextBox pageNumberBox) {
            HighlightElement(pageNumberBox);
            base.DrawPageNumberBox(pageNumberBox);
        }
        public override void DrawSpaceBox(PlainTextBox spaceBox) {
            HighlightElement(spaceBox);
            base.DrawSpaceBox(spaceBox);
        }
        void HighlightElement(PlainTextBox element) {
            if(!IsHighlightingAllowed)
                return;
            if(LayoutElementHighlights is null)
                return;

            foreach(var elementHighlight in LayoutElementHighlights.Where(eh => element.Range.Intersect(eh.HighlightRange))) {
                var highlightRange = elementHighlight.HighlightRange;
                if(highlightRange.Equals(element.Range)) {
                    DrawHighlight(elementHighlight.HighlightColor, element.Bounds, elementHighlight.HighlightType);
                } else {
                    CharacterBoxCollection characterBoxes = _richEditControl.DocumentLayout.Split(element);
                    CharacterBox firstBox = characterBoxes[0];
                    CharacterBox lastBox = characterBoxes[characterBoxes.Count - 1];
                    foreach(CharacterBox box in characterBoxes) {
                        if(box.Range.Start == highlightRange.Start)
                            firstBox = box;
                        if(box.Range.Start + box.Range.Length == highlightRange.Start + highlightRange.Length)
                            lastBox = box;
                    }
                    var charactersBoundingBox = Rectangle.FromLTRB(firstBox.Bounds.X, firstBox.Bounds.Y, lastBox.Bounds.Right, lastBox.Bounds.Bottom);
                    DrawHighlight(elementHighlight.HighlightColor, charactersBoundingBox, elementHighlight.HighlightType);
                }
            }
        }
        void DrawHighlight(Color highlightColor, Rectangle bounds, CustomDrawHighlightType highlightType) {
            switch(highlightType) {
                case CustomDrawHighlightType.Fill:
                    var brush = new RichEditBrush(highlightColor);
                    Canvas.FillRectangle(brush, bounds);
                    break;
                case CustomDrawHighlightType.Outline:
                    var pen = new RichEditPen(highlightColor, Canvas.ConvertToDrawingLayoutUnits(OutlineHighlightThicknessLayoutUnits, _richEditControl.LayoutUnit));
                    Canvas.DrawRectangle(pen, bounds);
                    break;
                default:
                    return;
            }
        }
    }
}
