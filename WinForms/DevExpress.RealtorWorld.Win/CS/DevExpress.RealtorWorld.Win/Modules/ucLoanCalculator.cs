using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Menu;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucLoanCalculator : BaseModule {
        Series InterestSeries { get { return chartControl1.Series[interestString]; } }
        Series PrincipalSeries { get { return chartControl1.Series[principalString]; } }
        public override string ModuleCaption { get { return "Loan Calculator"; } }
        Brush interestBrush, principalBrush, interestForeBrush = Brushes.White, principalForeBrush = Brushes.Black;
        Pen paymentPen;
        string interestString = "Interest", principalString = "Principal";
        Font cellFont = new Font(AppearanceObject.DefaultFont, FontStyle.Regular);
        double monthlyPayment = 0;
        public ucLoanCalculator() {
            InitializeComponent();
            LoanPayment.InitInterestRateData(editInterestRate);
            LoanPayment.InitTermOfLoan(editTermOfLoan);
            LoanPayment.InitStartMonth(editStart);
            editLoanAmount.Value = 250000;
            lciInfo.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, lciCalc.Height);
        }
        internal override void HideModule() {
            base.HideModule();
            gridView1.HideCustomization();
        }
        DateTime StartMonth { get { return (DateTime)editStart.EditValue; } }
        double LoanAmount { get { return Convert.ToDouble(editLoanAmount.EditValue); } }
        double InterestRate { get { return Convert.ToDouble(editInterestRate.EditValue) / 1200; } }
        double Months { get { return (int)editTermOfLoan.EditValue * 12; } }
        void Calc() {
            List<LoanPayment> data = LoanPayment.Calculate(LoanAmount, InterestRate, Months, StartMonth, out monthlyPayment);
            gridControl1.DataSource = data;
            lcInfo.Text = string.Format("<size=+3>Your Monthly Payment<br><size=+4>{0:c}", monthlyPayment);
            BeginInvoke(new MethodInvoker(delegate { gcBalance.BestFit(); }));
            InterestSeries.DataSource = data;
            InterestSeries.DateTimeSummaryOptions.SummaryFunction = "SUM([Interest])";
            PrincipalSeries.DataSource = data;
            PrincipalSeries.DateTimeSummaryOptions.SummaryFunction = "SUM([Principal])";
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            gridControl1.ForceInitialize();
            Calc();
        }
        void sbCalc_Click(object sender, EventArgs e) {
            Calc();
        }
        void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            LoanPayment payment = gridView1.GetRow(e.RowHandle) as LoanPayment;
            if(payment == null) return;
            if(e.Column == gcMonth) {
                e.DisplayText = payment.MonthString;
            }
            if(e.Column == gcPayment) {
                Rectangle r = e.Bounds;
                r.Inflate(-3, -3);
                int interestWidth = (int)(r.Width * payment.Interest / payment.MonthlyPayment);
                int principalWidth = (int)(r.Width * payment.Principal / payment.MonthlyPayment);
                Rectangle interestRect = new Rectangle(r.X, r.Y, interestWidth, r.Height);
                Rectangle principalRect = new Rectangle(r.X + interestWidth, r.Y, principalWidth, r.Height);
                e.Cache.FillRectangle(interestBrush, interestRect);
                e.Cache.FillRectangle(principalBrush, principalRect);
                using(StringFormat sf = new StringFormat()) {
                    sf.LineAlignment = StringAlignment.Center;
                    //
                    sf.Alignment = StringAlignment.Near;
                    string interest = string.Format(GetCellFormat(payment.Interest), payment.Interest);
                    if(e.Cache.CalcTextSize(interest, cellFont, sf, 0).Width < interestRect.Width)
                        e.Cache.DrawString(interest, cellFont, interestForeBrush, interestRect, sf);
                    else
                        e.Cache.DrawString(interest, cellFont, principalForeBrush, principalRect, sf);
                    //
                    sf.Alignment = StringAlignment.Far;
                    string principal = string.Format(GetCellFormat(payment.Principal), payment.Principal);
                    if(e.Cache.CalcTextSize(principal, cellFont, sf, 0).Width < principalRect.Width)
                        e.Cache.DrawString(principal, cellFont, principalForeBrush, principalRect, sf);
                    else
                        e.Cache.DrawString(principal, cellFont, interestForeBrush, interestRect, sf);
                }
                e.Cache.DrawRectangle(paymentPen, new Rectangle(interestRect.X, interestRect.Y - 1, (interestRect.Width + principalRect.Width), interestRect.Height + 1));
                e.Handled = true;
            }
        }
        string GetCellFormat(double value) {
            return (value < 1) ? "{0:c2}" : "{0:c0}";
        }
        void gridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e) {
            if(e.Column == gcPayment) {
                int indent = 5;
                e.Info.Caption = string.Empty;
                e.Painter.DrawObject(e.Info);
                int rectHeight = e.Info.Bounds.Height - indent * 2;
                int rectWidth = (int)(rectHeight * 1.3);
                Rectangle interestRect = new Rectangle(
                    e.Bounds.X + e.Appearance.CalcTextSizeInt(e.Cache, interestString, e.Info.Bounds.Width).Width + indent * 2, e.Info.Bounds.Y + Convert.ToInt32((e.Info.Bounds.Height - rectHeight) / 2) - 1, rectWidth, rectHeight);
                Rectangle principalRect = new Rectangle(
                    e.Bounds.X + e.Bounds.Width - indent * 2 - e.Appearance.CalcTextSizeInt(e.Cache, principalString, e.Info.Bounds.Width).Width - rectWidth, e.Info.Bounds.Y + Convert.ToInt32((e.Info.Bounds.Height - rectHeight) / 2) - 1, rectWidth, rectHeight);
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
        void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e) {
            if(e.Column == gcPayment) {
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
        PaymentTypeSum customSum;
        void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e) {
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
        void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e) {
            GridViewFooterMenu menu = e.Menu as GridViewFooterMenu;
            if(menu != null && menu.Column != null) {
                if(menu.Column.SummaryItem.SummaryType == SummaryItemType.Custom)
                    e.Menu.Items.Clear();
            }
        }
        void chartControl1_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            if(e.Series == InterestSeries) {
                if(interestBrush == null) interestBrush = new SolidBrush(e.SeriesDrawOptions.ActualColor2);
                if(paymentPen == null) paymentPen = new Pen(interestBrush);
            }
            else if(e.Series == PrincipalSeries)
                if(principalBrush == null) principalBrush = new SolidBrush(e.SeriesDrawOptions.Color);
        }
        void gridView1_FilterPopupExcelData(object sender, XtraGrid.Views.Grid.FilterPopupExcelDataEventArgs e) {
            if(e.Column == gcMonth) {
                for(int i = 0; i < e.Values.Length; i++)
                    e.DisplayTexts[i] = LoanPayment.GetMonthString((int)e.Values[i], gridControl1.DataSource as List<LoanPayment>);
            }
        }
    }
}
