using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using System.Drawing;
using DevExpress.Data.Filtering;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Custom painting", "CustomPainting.cs")]
    public static class CustomPainting {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(5);
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }

        #region CustomPainting
        [CodeExampleCase("CustomDrawCell"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawCell")]
        public static void CustomDrawCell(GridControl gridControl, GridView gridView) {
            // Handle this event to paint cells manually
            gridView.CustomDrawCell += (s, e) => {
                if(e.Column.VisibleIndex != 2) return;
                e.Cache.FillRectangle(Color.Salmon, e.Bounds);
                e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds);
                e.Handled = true;
            };
        }

        [CodeExampleCase("CustomDrawColumnHeader"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawColumnHeader")]
        public static void CustomDrawColumnHeader(GridControl gridControl, GridView gridView) {
            // Handle this event to paint columns headers manually
            gridView.CustomDrawColumnHeader += (s, e) => {
                if(e.Column == null || e.Column.FieldName != "Name")
                    return;
                // Fill column headers with the specified colors.
                e.Cache.FillRectangle(Color.Coral, e.Bounds);
                e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect);
                // Draw the filter and sort buttons.
                foreach(DrawElementInfo info in e.Info.InnerElements) {
                    if(!info.Visible) continue;
                    ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo);
                }
                e.Handled = true;
            };
        }
        [CodeExampleCase("CustomDrawFooter"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawFooter", "CustomDrawCell")]
        public static void CustomDrawFooter(GridControl gridControl, GridView gridView) {
            gridView.OptionsView.ShowFooter = true;
            gridView.FooterPanelHeight = 70;

            Color highPriority = Color.Green;
            Color normalPriority = Color.Orange;
            Color lowPriority = Color.Red;
            int markWidth = 16;

            // Handle this event to paint the footer panel manually
            gridView.CustomDrawFooter += (s, e) => {
                int offset = 5;
                e.DefaultDraw();
                Color color = highPriority;
                Rectangle markRectangle;
                string priorityText = " - High level";
                for(int i = 0; i < 3; i++) {
                    if(i == 1) {
                        color = normalPriority;
                        priorityText = " - Normal level";
                    }
                    else if(i == 2) {
                        color = lowPriority;
                        priorityText = " - Low level";
                    }
                    markRectangle = new Rectangle(e.Bounds.X + offset, e.Bounds.Y + offset + (markWidth + offset) * i, markWidth, markWidth);
                    e.Cache.FillEllipse(markRectangle.X, markRectangle.Y, markRectangle.Width, markRectangle.Height, color);
                    e.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
                    e.Appearance.Options.UseTextOptions = true;
                    e.Appearance.DrawString(e.Cache, priorityText, new Rectangle(markRectangle.Right + offset, markRectangle.Y, e.Bounds.Width, markRectangle.Height));
                }
            };

            gridView.CustomDrawCell += (s, e) => {
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
                e.Appearance.Options.UseTextOptions = true;
                e.DefaultDraw();
                if(e.Column.FieldName == "ID") {
                    Color color;
                    int cellValue = Convert.ToInt32(e.CellValue);
                    if(cellValue < 3)
                        color = highPriority;
                    else if(cellValue > 2 && cellValue < 5)
                        color = normalPriority;
                    else
                        color = lowPriority;
                    e.Cache.FillEllipse(e.Bounds.X + 1, e.Bounds.Y + 1, markWidth, markWidth, color);
                }
            };
        }
        [CodeExampleCase("CustomDrawFooterCell"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawFooterCell")]
        public static void CustomDrawFooterCell(GridControl gridControl, GridView gridView) {
            gridView.OptionsView.ShowFooter = true;
            gridView.FooterPanelHeight = 70;
            gridView.Columns["ID"].SummaryItem.SummaryType = SummaryItemType.Average;

            // Handle this event to paint footer cells manually
            gridView.CustomDrawFooterCell += (s, e) => {
                e.Bounds.Inflate(-5, -5);
                e.Appearance.ForeColor = Color.Teal;
                e.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
                e.Appearance.FontSizeDelta = 7;
                e.DefaultDraw();
                e.Cache.DrawRectangle(e.Cache.GetPen(Color.DarkOliveGreen, 5), e.Bounds);
                e.Handled = true;
            };
        }
        [CodeExampleCase("CustomDrawEmptyForeground"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawEmptyForeground")]
        public static void CustomDrawEmptyForeground(GridControl gridControl, GridView gridView) {
            string searchName = string.Empty;
            gridView.ActiveFilterCriteria = new BinaryOperator("Name", searchName);

            // Initialize variables used to paint View's empty space in a custom manner
            Font noMatchesFoundTextFont = new Font("Tahoma", 10);
            Font trySearchingAgainTextFont = new Font("Tahoma", 15, FontStyle.Underline);
            Font trySearchingAgainTextFontBold = new Font(trySearchingAgainTextFont, FontStyle.Underline | FontStyle.Bold);
            SolidBrush linkBrush = new SolidBrush(DevExpress.Skins.EditorsSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel).Colors["HyperLinkTextColor"]);
            string noMatchesFoundText = "No matches found";
            string trySearchingAgainText = "Try searching again";
            Rectangle noMatchesFoundBounds = Rectangle.Empty;
            Rectangle trySearchingAgainBounds = Rectangle.Empty;
            bool trySearchingAgainBoundsContainCursor = false;
            int offset = 10;

            //Handle this event to paint View's empty space in a custom manner
            gridView.CustomDrawEmptyForeground += (s, e) => {
                e.DefaultDraw();
                e.Appearance.Options.UseFont = true;
                e.Appearance.Font = noMatchesFoundTextFont;
                //Draw the noMatchesFoundText string
                Size size = e.Appearance.CalcTextSize(e.Cache, noMatchesFoundText, e.Bounds.Width).ToSize();
                int x = (e.Bounds.Width - size.Width) / 2;
                int y = e.Bounds.Y + offset;
                noMatchesFoundBounds = new Rectangle(new Point(x, y), size);
                e.Appearance.DrawString(e.Cache, noMatchesFoundText, noMatchesFoundBounds);
                //Draw the trySearchingAgain link
                e.Appearance.Font = trySearchingAgainBoundsContainCursor ? trySearchingAgainTextFontBold : trySearchingAgainTextFont;
                size = e.Appearance.CalcTextSize(e.Cache, trySearchingAgainText, e.Bounds.Width).ToSize();
                x = noMatchesFoundBounds.X - (size.Width - noMatchesFoundBounds.Width) / 2;
                y = noMatchesFoundBounds.Bottom + offset;
                size.Width += offset;
                trySearchingAgainBounds = new Rectangle(new Point(x, y), size);
                e.Appearance.DrawString(e.Cache, trySearchingAgainText, trySearchingAgainBounds, linkBrush);
            };

            gridView.MouseMove += (s, e) => {
                trySearchingAgainBoundsContainCursor = trySearchingAgainBounds.Contains(e.Location);
                gridControl.Cursor = trySearchingAgainBoundsContainCursor ? Cursors.Hand : Cursors.Default;
                gridView.InvalidateRect(trySearchingAgainBounds);
            };

            gridView.MouseDown += (s, e) => {
                if(trySearchingAgainBoundsContainCursor) {
                    searchName = XtraInputBox.Show(string.Format("Enter {0}", "Name"), string.Format("Enter {0} dialog", "Name"), searchName);
                    gridView.ActiveFilterCriteria = new BinaryOperator("Name", searchName);
                }
            };
        }
        [CodeExampleCase("CustomDrawFilterPanel"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawFilterPanel", "FilterCriteriaDisplayStyle")]
        public static void CustomDrawFilterPanel(GridControl gridControl, GridView gridView) {
            gridView.ActiveFilterString = string.Format("[{0}] > 2", "ID");
            gridView.OptionsView.FilterCriteriaDisplayStyle = FilterCriteriaDisplayStyle.Text;
            // Handle this event to paint the filter panel manually
            gridView.CustomDrawFilterPanel += (s, e) => {
                GridView view = s as GridView;
                GridFilterPanelInfoArgs info = e.Info as GridFilterPanelInfoArgs;
                e.Cache.FillRectangle(Color.BlanchedAlmond, e.Bounds);
                e.Appearance.ForeColor = Color.DimGray;
                e.Appearance.DrawString(e.Cache, info.DisplayText, info.TextBounds);
                SkinGridFilterPanelPainter painter = e.Painter as SkinGridFilterPanelPainter;
                info.ActiveButtonInfo.CheckState = view.ActiveFilterEnabled ? CheckState.Checked : CheckState.Unchecked;
                ObjectPainter.DrawObject(e.Cache, painter.CheckPainter, info.ActiveButtonInfo);
                ObjectPainter.DrawObject(e.Cache, painter.ButtonPainter, info.CustomizeButtonInfo);
                ObjectPainter.DrawObject(e.Cache, painter.ButtonPainter, info.CloseButtonInfo);
                e.Handled = true;
            };
        }
        [CodeExampleCase("CustomDrawGroupPanel"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawGroupPanel")]
        public static void CustomDrawGroupPanel(GridControl gridControl, GridView gridView) {
            gridView.OptionsFind.FindPanelLocation = GridFindPanelLocation.Panel;
            // Handle this event to paint GroupPanel in a custom manner
            gridView.CustomDrawGroupPanel += (s, e) => {
                e.DefaultDraw();
                string text = "DevExpress";
                Size textSize = e.Appearance.CalcTextSizeInt(e.Cache, text, e.Bounds.Width);
                Rectangle rect = new Rectangle(e.Bounds.Right - textSize.Width, e.Bounds.Y, textSize.Width, e.Bounds.Height - 1);
                e.Cache.FillRectangle(Color.Maroon, rect);
                e.Appearance.DrawString(e.Cache, text, rect);
                e.Handled = true;
            };
        }
        [CodeExampleCase("CustomDrawGroupRow"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawGroupRow")]
        public static void CustomDrawGroupRow(GridControl gridControl, GridView gridView) {
            gridView.Columns["ID"].Group();

            // Handle this event to paint group rows manually
            gridView.CustomDrawGroupRow += (s, e) => {
                if(e.RowHandle % 2 == 0) {
                    e.Appearance.BackColor = Color.BlanchedAlmond;
                    e.Appearance.ForeColor = Color.DimGray; ;
                }
            };
        }
        [CodeExampleCase("CustomDrawGroupRowCell"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawGroupRowCell")]
        public static void CustomDrawGroupRowCell(GridControl gridControl, GridView gridView) {
            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
            // group summaries
            GridGroupSummaryItem item = new GridGroupSummaryItem() {
                FieldName = "Length",
                SummaryType = SummaryItemType.Sum,
                ShowInGroupColumnFooter = gridView.Columns["Length"]
            };
            gridView.GroupSummary.Add(item);

            item = new GridGroupSummaryItem() {
                FieldName = "Mark",
                SummaryType = SummaryItemType.Count,
                ShowInGroupColumnFooter = gridView.Columns["Mark"]
            };
            gridView.GroupSummary.Add(item);
            gridView.Columns["ID"].Group();

            // Handle this event to paint group row cells manually
            gridView.CustomDrawGroupRowCell += (s, e) => {
                e.Appearance.BackColor = Color.BlanchedAlmond;
                e.Appearance.FillRectangle(e.Cache, e.Bounds);
                e.Appearance.ForeColor = Color.DimGray;
                e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds);
                e.Handled = true;
            };
        }

        [CodeExampleCase("CustomDrawRowIndicator"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawRowIndicator")]
        public static void CustomDrawRowIndicator(GridControl gridControl, GridView gridView) {
            gridView.IndicatorWidth = 50;
            // Handle this event to paint RowIndicator manually
            gridView.CustomDrawRowIndicator += (s, e) => {
                if(!e.Info.IsRowIndicator) return;
                GridView view = s as GridView;
                e.Handled = true;

                e.Appearance.BackColor = view.FocusedRowHandle == e.RowHandle ? Color.Chocolate : Color.MediumSpringGreen;
                e.Appearance.FillRectangle(e.Cache, new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 4, e.Bounds.Y - 4));
                if(e.Info.ImageIndex < 0) return;
                ImageCollection ic = e.Info.ImageCollection as ImageCollection;
                Image indicator = ic.Images[e.Info.ImageIndex];
                e.Cache.DrawImage(indicator, new Rectangle(e.Bounds.X + 20, e.Bounds.Y + 6, indicator.Width, indicator.Height));
            };
        }
        [CodeExampleCase("CustomDrawRowPreview  "), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawRowPreview")]
        public static void CustomDrawRowPreview(GridControl gridControl, GridView gridView) {
            gridView.Columns["Notes"].Visible = false;
            gridView.PreviewFieldName = "Notes";
            gridView.PreviewLineCount = 2;
            gridView.OptionsView.ShowPreview = true;

            // Handle this event to paint Preview row manually
            gridView.CustomDrawRowPreview += (s, e) => {
                if(e.RowHandle == 2) {
                    GridView view = s as GridView;
                    int dx = 5;
                    // A rectangle for displaying text.
                    Rectangle r = e.Bounds;
                    r.X += e.Bounds.Height + dx * 2;
                    r.Width -= (e.Bounds.Height + dx * 3);
                    e.Cache.FillRectangle(Color.Coral, new Rectangle(e.Bounds.X + dx, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height));
                    e.Appearance.ForeColor = Color.Green;
                    e.Appearance.DrawString(e.Cache, view.GetRowPreviewDisplayText(e.RowHandle), r);
                    e.Handled = true;
                }
            };
        }
        #endregion
    }
}
