using System;
using System.Drawing;
using DevExpress.Spreadsheet;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class LoanAmortizationScheduleModule : SpreadsheetRibbonTutorialControlBase {
        IWorkbook workbook;

        public LoanAmortizationScheduleModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            InitializeDocument();
            spreadsheetControl1.CellValueChanged += SpreadsheetControl1_CellValueChanged;
            rgPaymentType.SelectedIndexChanged += PaymentType_SelectedIndexChanged;
        }

        Worksheet Sheet {
            get {
                return workbook.Worksheets[0];
            }
        }

        bool AnnuityPayments {
            get {
                return rgPaymentType.SelectedIndex != 1;
            }
        }

        DateTime StartDateOfLoan { get { return Sheet["E8"].Value.DateTimeValue; } set { Sheet["E8"].Value = value; } }
        int ActualNumberOfPayments {
            get {
                return (int)Math.Round(Sheet["I6"].Value.NumericValue);
            }
        }

        int ScheduledNumberOfPayments {
            get {
                return (int)Math.Round(Sheet["I5"].Value.NumericValue);
            }
        }

        string ActualLastRow {
            get {
                return (11 + ActualNumberOfPayments).ToString();
            }
        }

        string ScheduledLastRow {
            get {
                return (11 + ScheduledNumberOfPayments).ToString();
            }
        }

        bool IsTemplateLoaded {
            get {
                if(string.IsNullOrEmpty(spreadsheetControl1.Options.Save.CurrentFileName))
                    return false;
                return spreadsheetControl1.Options.Save.CurrentFileName.Contains("LoanAmortizationSchedule");
            }
        }

        void InitializeDocument() {
            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(DemoUtils.GetRelativePath("LoanAmortizationSchedule_template.xltx"));
            StartDateOfLoan = DateTime.Now;
            GenerateDocument();
            workbook.History.Clear();
        }

        void SpreadsheetControl1_CellValueChanged(object sender, SpreadsheetCellEventArgs e) {
            if(IsTemplateLoaded && e.ColumnIndex == 4 && e.RowIndex >= 3 && e.RowIndex <= 8 && e.Action != CellValueChangedAction.UndoRedo)
                GenerateDocument();
        }

        void PaymentType_SelectedIndexChanged(object sender, EventArgs e) {
            if(IsTemplateLoaded)
                GenerateDocument();
        }

        #region Document generation

        void GenerateDocument() {
            workbook.BeginUpdate();
            try {
                Cleanup();
                if(AnnuityPayments)
                    GenerateAnnuityPaymentsContent();
                else
                    GenerateScaledPaymentsContent();
                ApplyFormatting();
                AdjustPrintOptions();
            }
            finally {
                workbook.EndUpdate();
            }
        }

        void Cleanup() {
            CellRange range = Sheet.GetDataRange().Exclude(Sheet["1:11"]);
            if(range != null)
                range.Clear();
            Sheet["I4"].ClearContents();
            Sheet["I6:I8"].ClearContents();
            workbook.DefinedNames.Clear();
        }

        void GenerateAnnuityPaymentsContent() {
            AddDefinedNamesForAnnuityPayments();

            Sheet["I4"].FormulaInvariant = "=PMT(Interest_Rate_Per_Month,Scheduled_Number_Payments,-Loan_Amount)";
            Sheet["I5"].FormulaInvariant = "=Loan_Years*Number_of_Payments_Per_Year";
            Sheet["I6"].FormulaInvariant = "=ROUNDUP(Actual_Number_Payments,0)";
            workbook.Calculate();
            Sheet["I7"].FormulaInvariant = "=SUM(F12:F" + ActualLastRow + ")";
            Sheet["I8"].FormulaInvariant = "=SUM($I$12:$I$" + ActualLastRow + ")";

            if(ScheduledNumberOfPayments == 0)
                return;

            for(int i = 0; i < ActualNumberOfPayments; i++)
                Sheet["B" + (i + 12).ToString()].Value = i + 1;

            Sheet["C12:C" + ActualLastRow].FormulaInvariant = "=DATE(YEAR(Loan_Start),MONTH(Loan_Start)+(B12)*12/Number_of_Payments_Per_Year,DAY(Loan_Start))";
            Sheet["D12"].Formula = "=Loan_Amount";

            if(ScheduledNumberOfPayments > 1)
                Sheet["D13:D" + ActualLastRow].Formula = "=J12";

            Sheet["E12:E" + ActualLastRow].FormulaInvariant = "=IF(D12>0,IF(Scheduled_payment<D12, Scheduled_payment, D12),0)";
            Sheet["F12:F" + ActualLastRow].FormulaInvariant = "=IF(Extra_Payments<>0, IF(Scheduled_payment<D12, G12-E12, 0), 0)";
            Sheet["G12:G" + ActualLastRow].FormulaInvariant = "=H12+I12";
            Sheet["H12:H" + ActualLastRow].FormulaInvariant = "=IF(J12>0,PPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount),D12)";
            Sheet["I12:I" + ActualLastRow].FormulaInvariant = "=IF(D12>0,IPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount),0)";
            Sheet["J12:J" + ActualLastRow].FormulaInvariant = "=IF(D12-PPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount)>0,D12-PPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount),0)";
            Sheet["K12:K" + ActualLastRow].FormulaInvariant = "=SUM($I$12:$I12)";

            workbook.Calculate();
        }

        void AddDefinedNamesForAnnuityPayments() {
            string sheetName = "'" + Sheet.Name + "'";
            char separator = workbook.Options.Culture.TextInfo.ListSeparator[0];

            DefinedNameCollection definedNames = workbook.DefinedNames;
            definedNames.Add("Loan_Amount", sheetName + "!$E$4");
            definedNames.Add("Interest_Rate", sheetName + "!$E$5");
            definedNames.Add("Loan_Years", sheetName + "!$E$6");
            definedNames.Add("Number_of_Payments_Per_Year", sheetName + "!$E$7");
            definedNames.Add("Loan_Start", sheetName + "!$E$8");
            definedNames.Add("Extra_Payments", sheetName + "!$E$9");
            definedNames.Add("Scheduled_payment", sheetName + "!$I$4");
            definedNames.Add("Scheduled_Number_Payments", sheetName + "!$I$5");
            definedNames.Add("Interest_Rate_Per_Month", "=Interest_Rate/Number_of_Payments_Per_Year");
            definedNames.Add("Actual_Number_Payments", "=NPER(Interest_Rate_Per_Month" + separator + " " + sheetName + "!$I$4+Extra_Payments" + separator + " -Loan_Amount)");
        }

        void GenerateScaledPaymentsContent() {
            AddDefinedNamesForScaledPayments();

            Sheet["I4"].FormulaInvariant = "=IF(Values_Entered,Scheduled_Monthly_Payment,\"\")";
            Sheet["I5"].FormulaInvariant = "=IF(Values_Entered,Loan_Years*Number_of_Payments_Per_Year,\"\")";
            Sheet["I6"].FormulaInvariant = "=IF(Values_Entered,Number_of_Payments,\"\")";
            Sheet["I7"].FormulaInvariant = "=IF(Values_Entered,SUMIF(Beg_Bal,\">0\",Extra_Pay),\"\")";
            Sheet["I8"].FormulaInvariant = "=IF(Values_Entered,SUMIF(Beg_Bal,\">0\",Int),\"\")";

            workbook.Calculate();

            if(ScheduledNumberOfPayments == 0)
                return;

            Sheet["B12"].FormulaInvariant = "=1";

            if(ScheduledNumberOfPayments > 1)
                Sheet["B13:B" + ScheduledLastRow].FormulaInvariant = "=IF(NOT(OR(J12=0,J12=\"\")),B12+1,\"\")";

            Sheet["C12:C" + ScheduledLastRow].FormulaInvariant = "=IF(Pay_Num<>\"\",DATE(YEAR(Loan_Start),MONTH(Loan_Start)+(Pay_Num)*12/Number_of_Payments_Per_Year,DAY(Loan_Start)),\"\")";
            Sheet["D12"].FormulaInvariant = "=IF(Values_Entered,Loan_Amount,\"\")";

            if(ScheduledNumberOfPayments > 1)
                Sheet["D13:D" + ScheduledLastRow].FormulaInvariant = "=IF(Pay_Num<>\"\",J12,\"\")";

            Sheet["E12:E" + ScheduledLastRow].FormulaInvariant = "=IF(Pay_Num<>\"\",Scheduled_Monthly_Payment,\"\")";
            Sheet["F12:F" + ScheduledLastRow].FormulaInvariant = "=IF(Pay_Num<>\"\",IF(Sched_Pay+Extra_Payments<Beg_Bal,Extra_Payments,IF(AND(Pay_Num<>\"\",Beg_Bal-Sched_Pay>0),Beg_Bal-Sched_Pay,IF(Pay_Num<>\"\",0,\"\"))),\"\")";
            Sheet["G12:G" + ScheduledLastRow].FormulaInvariant = "=IF(Pay_Num<>\"\",IF(Sched_Pay+Extra_Pay<Beg_Bal,Princ+Int+Extra_Pay,IF(Pay_Num<>\"\",Beg_Bal,\"\")),\"\")";
            Sheet["H12:H" + ScheduledLastRow].FormulaInvariant = "=IF(Pay_Num<>\"\",Scheduled_Monthly_Payment,\"\")";
            Sheet["I12:I" + ScheduledLastRow].FormulaInvariant = "=IF(Pay_Num<>\"\",Beg_Bal*(Interest_Rate/Number_of_Payments_Per_Year),\"\")";
            Sheet["J12:J" + ScheduledLastRow].FormulaInvariant = "=IF(Pay_Num<>\"\",IF(Sched_Pay+Extra_Pay<Beg_Bal,Beg_Bal-Princ,IF(Pay_Num<>\"\",0,\"\")),\"\")";
            Sheet["K12:K" + ScheduledLastRow].FormulaInvariant = "=IF(Pay_Num<>\"\",SUM($I$12:$I12),\"\")";

            workbook.Calculate();
        }

        void AddDefinedNamesForScaledPayments() {
            string sheetName = "'" + Sheet.Name + "'";
            char separator = workbook.Options.Culture.TextInfo.ListSeparator[0];
            DefinedNameCollection definedNames = workbook.DefinedNames;
            definedNames.Add("Values_Entered", "IF(Loan_Amount*Interest_Rate*Loan_Years*Loan_Start>0" + separator + "1" + separator + "0)");
            definedNames.Add("Full_Print", sheetName + "!$A:$K");
            definedNames.Add("Loan_Amount", sheetName + "!$E$4");
            definedNames.Add("Interest_Rate", sheetName + "!$E$5");
            definedNames.Add("Loan_Years", sheetName + "!$E$6");
            definedNames.Add("Number_of_Payments_Per_Year", sheetName + "!$E$7");
            definedNames.Add("Loan_Start", sheetName + "!$E$8");
            definedNames.Add("Extra_Payments", sheetName + "!$E$9");
            definedNames.Add("Scheduled_Monthly_Payment", "Loan_Amount/(Loan_Years*Number_of_Payments_Per_Year)");
            definedNames.Add("Scheduled_Number_Payments", sheetName + "!$I$5");
            definedNames.Add("Real_Number_Payments", sheetName + "!$I$6");
            definedNames.Add("Total_Early_Payments", sheetName + "!$I$7");
            definedNames.Add("Total_Interest", sheetName + "!$I$8");
            definedNames.Add("Beg_Bal", sheetName + "!$D$12:$D$" + ScheduledLastRow);
            definedNames.Add("Cum_Int", sheetName + "!$K$12:$K$" + ScheduledLastRow);
            definedNames.Add("Data", sheetName + "!$B$12:$K$" + ScheduledLastRow);
            definedNames.Add("End_Bal", sheetName + "!$J$12:$J$" + ScheduledLastRow);
            definedNames.Add("Extra_Pay", sheetName + "!$F$12:$F$" + ScheduledLastRow);
            definedNames.Add("Header_Row", "ROW(" + sheetName + "!$17:$17)");
            definedNames.Add("Int", sheetName + "!$I$12:$I$" + ScheduledLastRow);
            definedNames.Add("Last_Row", "IF(Values_Entered" + separator + "Header_Row+Number_of_Payments" + separator + "Header_Row)");
            definedNames.Add("Number_of_Payments", "=MATCH(0.01" + separator + "End_Bal" + separator + "-1)+1");
            definedNames.Add("Pay_Date", sheetName + "!$C$12:$C$" + ScheduledLastRow);
            definedNames.Add("Pay_Num", sheetName + "!$B$12:$B$" + ScheduledLastRow);
            definedNames.Add("Payment_Date", "DATE(YEAR(Loan_Start)" + separator + "MONTH(Loan_Start)+Payment_Number" + separator + "DAY(Loan_Start))");
            definedNames.Add("Princ", sheetName + "!$H$12:$H$" + ScheduledLastRow);
            definedNames.Add("Print_Area_Reset", "OFFSET(Full_Print" + separator + "0" + separator + "0" + separator + "Last_Row)");
            definedNames.Add("Sched_Pay", sheetName + "!$E$12:$E$" + ScheduledLastRow);
            definedNames.Add("Total_Pay", sheetName + "!$G$12:$G$" + ScheduledLastRow);
            definedNames.Add("Total_Payment", "Scheduled_Payment+Extra_Payment");
            definedNames.Add("Payment_Number", "ROW()-Header_Row");
            definedNames.Add("Loan_Not_Paid", "IF(Payment_Number<=Number_of_Payments" + separator + "1" + separator + "0)");
        }

        void ApplyFormatting() {
            CellRange range;
            for(int i = 1; i < ActualNumberOfPayments; i += 2) {
                range = Sheet.Range.FromLTRB(1, 11 + i, 10, 11 + i);
                range.Fill.BackgroundColor = Color.FromArgb(217, 217, 217);
            }

            range = Sheet["B11:K" + ActualLastRow];
            Formatting formatting = range.BeginUpdateFormatting();
            try {
                formatting.Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.Thin;
                formatting.Borders.InsideVerticalBorders.Color = Color.White;
                formatting.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
            }
            finally {
                range.EndUpdateFormatting(formatting);
            }

            Sheet["B12:C" + ActualLastRow].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right;
            Sheet["C11:C" + ActualLastRow].NumberFormat = "m/d/yyyy";
            Sheet["D11:K" + ActualLastRow].NumberFormat = "_(\\$* #,##0.00_);_(\\$ (#,##0.00);_(\\$* \" - \"??_);_(@_)";
        }

        void AdjustPrintOptions() {
            Sheet.SetPrintRange(Sheet.GetDataRange());
            Sheet.PrintOptions.FitToPage = true;
            Sheet.PrintOptions.FitToWidth = 1;
            Sheet.PrintOptions.FitToHeight = 0; // automatic
        }

        #endregion
    }
}
