using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    public partial class SplitPresentation : TutorialControl {
        Brush interestBrush = Brushes.Green, principalBrush = Brushes.LightGreen, interestForeBrush = Brushes.White, principalForeBrush = Brushes.Black;
        Pen paymentPen = Pens.Green;
        PaymentTypeSum customSum;
        string interestString = Properties.Resources.Interest, principalString = Properties.Resources.Principal;
        Font cellFont = new Font(AppearanceObject.DefaultFont, FontStyle.Regular);
        double monthlyPayment = 0;
        public SplitPresentation() {
            InitializeComponent();
            LoanPayment.InitInterestRateData(editInterestRate);
            LoanPayment.InitTermOfLoan(editTermOfLoan);
            LoanPayment.InitStartMonth(editStart);
            editLoanAmount.Value = 250000;
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "SplitPresentation" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "SplitPresentation"; }
        }
        DateTime StartMonth { get { return (DateTime)editStart.EditValue; } }
        double LoanAmount { get { return Convert.ToDouble(editLoanAmount.EditValue); } }
        double InterestRate { get { return Convert.ToDouble(editInterestRate.EditValue) / 1200; } }
        double Months { get { return (int)editTermOfLoan.EditValue * 12; } }
        //<sbCalc>
        void Calc() {
            List<LoanPayment> data = LoanPayment.Calculate(LoanAmount, InterestRate, Months, StartMonth, out monthlyPayment);
            gridControl1.DataSource = data;
            lcInfo.Text = string.Format("<size=+4>{1}<br><size=+4>{0:c}", monthlyPayment, Properties.Resources.YourMonthlyPayment);
            ((GridView)gridSplitContainer1.SplitChildGrid.MainView).TopRowIndex = data.Count;
        }
        //</sbCalc>
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            gridControl1.ForceInitialize();
            gridControl2.ForceInitialize();
            gridSplitContainer1.ShowSplitView();
            gridSplitContainer2.ShowSplitView();
            Calc();
            InitHomesData();
        }
        void InitHomesData() {
            gridControl2.DataSource = Home.Homes;
            gridSplitContainer2.SplitChildGrid.HandleCreated += new EventHandler(SplitChildGrid_HandleCreated);
        }
        void SplitChildGrid_HandleCreated(object sender, EventArgs e) {
            gridSplitContainer2.HideSplitView();
            gridSplitContainer2.ShowSplitView();
            ((GridView)gridSplitContainer2.SplitChildGrid.MainView).LeftCoord = 415;
        }
        //<sbCalc>
        private void sbCalc_Click(object sender, EventArgs e) {
            Calc();
        }
        //</sbCalc>
        #region Horizontal split grid events
        string GetCellFormat(double value) {
            if(value < 1) return "{0:c2}";
            return "{0:c0}";
        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            GridView view = sender as GridView;
            LoanPayment payment = view.GetRow(e.RowHandle) as LoanPayment;
            if(payment == null) return;
            if(e.Column.FieldName == gcMonth.FieldName) {
                e.DisplayText = payment.MonthString;
            }
            if(e.Column.FieldName == gcPayment.FieldName) {
                Rectangle r = e.Bounds;
                r.Inflate(-2, -2);
                int interestWidth = (int)(r.Width * payment.Interest / payment.MonthlyPayment);
                int principalWidth = (int)(r.Width * payment.Principal / payment.MonthlyPayment);
                Rectangle interestRect = new Rectangle(r.X, r.Y, interestWidth, r.Height);
                Rectangle principalRect = new Rectangle(r.X + interestWidth, r.Y, principalWidth, r.Height);
                e.Cache.FillRectangle(interestBrush, interestRect);
                e.Cache.FillRectangle(principalBrush, principalRect);
                using(StringFormat sf = new StringFormat()) {
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    DrawPaymentLine(e.Cache, payment.Interest, interestRect, principalRect, interestForeBrush, principalForeBrush, sf);
                    sf.Alignment = StringAlignment.Far;
                    DrawPaymentLine(e.Cache, payment.Principal, principalRect, interestRect, principalForeBrush, interestForeBrush, sf);
                }
                e.Cache.DrawRectangle(paymentPen, new Rectangle(interestRect.X, interestRect.Y - 1, (interestRect.Width + principalRect.Width), interestRect.Height + 1));
                e.Handled = true;
            }
        }
        void DrawPaymentLine(DevExpress.Utils.Drawing.GraphicsCache cache, double value, Rectangle rect1, Rectangle rect2, Brush brush1, Brush brush2, StringFormat sf) {
            rect1.Inflate(-2, 0); rect2.Inflate(-2, 0);
            string _text = string.Format(GetCellFormat(value), value);
            Size textSize = cache.CalcTextSize(_text, cellFont, sf, 0).ToSize();
            if(textSize.Width < rect1.Width) {
                Rectangle destRect = CheckTextBounds(rect1, textSize);
                cache.DrawString(_text, cellFont, brush1, destRect, sf);
            }
            else {
                Rectangle destRect = CheckTextBounds(rect2, textSize);
                cache.DrawString(_text, cellFont, brush2, destRect, sf);
            }
        }
        Rectangle CheckTextBounds(Rectangle rect, Size textSize) {
            if(textSize.Height <= rect.Height)
                return rect;
            return new Rectangle(rect.X, rect.Y - (textSize.Height + 1 - rect.Height) / 2, rect.Width, textSize.Height);
        }

        private void gridView1_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e) {
            if(e.Column != null && e.Column.FieldName == gcPayment.FieldName) {
                int indent = 5;
                e.Info.Caption = string.Empty;
                e.Painter.DrawObject(e.Info);
                int rectHeight = e.Info.Bounds.Height - indent * 2;
                int rectWidth = (int)(rectHeight * 1.3);
                Rectangle interestRect = new Rectangle(
                    e.Bounds.X + e.Appearance.CalcTextSizeInt(e.Cache, interestString, e.Info.Bounds.Width).Width + indent * 2, e.Info.Bounds.Y + (e.Info.Bounds.Height - rectHeight) / 2 - 1, rectWidth, rectHeight);
                Rectangle principalRect = new Rectangle(
                    e.Bounds.X + e.Bounds.Width - indent * 2 - e.Appearance.CalcTextSizeInt(e.Cache, principalString, e.Info.Bounds.Width).Width - rectWidth, e.Info.Bounds.Y + (e.Info.Bounds.Height - rectHeight) / 2 - 1, rectWidth, rectHeight);
                Rectangle r = e.Info.Bounds;
                r.Inflate(-indent, 0);
                r.Height -= 1;
                using(StringFormat sf = new StringFormat()) {
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Appearance.DrawString(e.Cache, interestString, r, sf);
                    sf.Alignment = StringAlignment.Far;
                    e.Appearance.DrawString(e.Cache, principalString, r, sf);
                }
                e.Cache.FillRectangle(interestBrush, interestRect);
                e.Cache.FillRectangle(principalBrush, principalRect);
                e.Cache.DrawRectangle(paymentPen, interestRect);
                e.Cache.DrawRectangle(paymentPen, principalRect);
                e.Handled = true;
            }
        }
        private void gridView1_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e) {
            if(e.Column.FieldName == gcPayment.FieldName) {
                int indent = 5;
                e.Info.DisplayText = string.Empty;
                e.Painter.DrawObject(e.Info);
                Rectangle r = e.Info.Bounds;
                r.Inflate(-indent, 0);
                using(StringFormat sf = new StringFormat()) {
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Appearance.DrawString(e.Cache, string.Format("{0:c2}", customSum.InterestSum), r, sf);
                    sf.Alignment = StringAlignment.Far;
                    e.Appearance.DrawString(e.Cache, string.Format("{0:c2}", customSum.PrincipalSum), r, sf);
                }
                e.Handled = true;
            }
        }
        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e) {
            if(!object.ReferenceEquals(sender, gridView1)) return;
            if(e.SummaryProcess == CustomSummaryProcess.Start) {
                customSum = new PaymentTypeSum();
            }
            if(e.SummaryProcess == CustomSummaryProcess.Calculate) {
                LoanPayment payment = gridView1.GetRow(e.RowHandle) as LoanPayment;
                if(payment != null && e.IsTotalSummary)
                    customSum.AddToSum(payment.Interest, payment.Principal);
            }
            if(e.SummaryProcess == CustomSummaryProcess.Finalize)
                if(e.IsTotalSummary)
                    e.TotalValue = customSum;
        }
        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            GridViewFooterMenu menu = e.Menu as GridViewFooterMenu;
            if(menu != null && menu.Column != null)
                e.Allow = menu.Column.SummaryItem.SummaryType != SummaryItemType.Custom;
        }
        #endregion
        //<sbSplit>
        private void sbSplit_Click(object sender, EventArgs e) {
            gridSplitContainer2.ShowSplitView();
        }
        //</sbSplit>
        //<sbRemoveSplit>
        private void sbRemoveSplit_Click(object sender, EventArgs e) {
            gridSplitContainer2.HideSplitView();
        }
        //</sbRemoveSplit>
        void UpdateButtons() {
            sbSplit.Enabled = !gridSplitContainer2.IsSplitViewVisible;
            sbRemoveSplit.Enabled = gridSplitContainer2.IsSplitViewVisible;
        }

        private void gridSplitContainer2_SplitViewShown(object sender, EventArgs e) {
            UpdateButtons();
        }

        private void gridSplitContainer2_SplitViewHidden(object sender, EventArgs e) {
            UpdateButtons();
        }

        private void gridView1_ShowFilterPopupCheckedListBox(object sender, FilterPopupCheckedListBoxEventArgs e) {
            if(e.Column.FieldName == gcMonth.FieldName) {
                foreach(CheckedListBoxItem item in e.CheckedComboBox.Items)
                    item.Description = LoanPayment.GetMonthString(Convert.ToInt32(((DevExpress.XtraGrid.Views.Grid.FilterItem)item.Value).Value), gridControl1.DataSource as List<LoanPayment>);
            }
        }
    }
}
