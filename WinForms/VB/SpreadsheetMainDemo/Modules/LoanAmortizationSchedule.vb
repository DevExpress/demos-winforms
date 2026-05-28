Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class LoanAmortizationScheduleModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Private workbook As IWorkbook

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            InitializeDocument()
            AddHandler spreadsheetControl1.CellValueChanged, AddressOf SpreadsheetControl1_CellValueChanged
            AddHandler rgPaymentType.SelectedIndexChanged, AddressOf PaymentType_SelectedIndexChanged
        End Sub

        Private ReadOnly Property Sheet As Worksheet
            Get
                Return workbook.Worksheets(0)
            End Get
        End Property

        Private ReadOnly Property AnnuityPayments As Boolean
            Get
                Return rgPaymentType.SelectedIndex <> 1
            End Get
        End Property

        Private Property StartDateOfLoan As Date
            Get
                Return Sheet("E8").Value.DateTimeValue
            End Get

            Set(ByVal value As Date)
                Sheet("E8").Value = value
            End Set
        End Property

        Private ReadOnly Property ActualNumberOfPayments As Integer
            Get
                Return CInt(Math.Round(Sheet("I6").Value.NumericValue))
            End Get
        End Property

        Private ReadOnly Property ScheduledNumberOfPayments As Integer
            Get
                Return CInt(Math.Round(Sheet("I5").Value.NumericValue))
            End Get
        End Property

        Private ReadOnly Property ActualLastRow As String
            Get
                Return(11 + ActualNumberOfPayments).ToString()
            End Get
        End Property

        Private ReadOnly Property ScheduledLastRow As String
            Get
                Return(11 + ScheduledNumberOfPayments).ToString()
            End Get
        End Property

        Private ReadOnly Property IsTemplateLoaded As Boolean
            Get
                If String.IsNullOrEmpty(spreadsheetControl1.Options.Save.CurrentFileName) Then Return False
                Return spreadsheetControl1.Options.Save.CurrentFileName.Contains("LoanAmortizationSchedule")
            End Get
        End Property

        Private Sub InitializeDocument()
            workbook = spreadsheetControl1.Document
            workbook.LoadDocument(DemoUtils.GetRelativePath("LoanAmortizationSchedule_template.xltx"))
            StartDateOfLoan = Date.Now
            GenerateDocument()
            workbook.History.Clear()
        End Sub

        Private Sub SpreadsheetControl1_CellValueChanged(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs)
            If IsTemplateLoaded AndAlso e.ColumnIndex = 4 AndAlso e.RowIndex >= 3 AndAlso e.RowIndex <= 8 AndAlso e.Action <> CellValueChangedAction.UndoRedo Then GenerateDocument()
        End Sub

        Private Sub PaymentType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsTemplateLoaded Then GenerateDocument()
        End Sub

#Region "Document generation"
        Private Sub GenerateDocument()
            workbook.BeginUpdate()
            Try
                Cleanup()
                If AnnuityPayments Then
                    GenerateAnnuityPaymentsContent()
                Else
                    GenerateScaledPaymentsContent()
                End If

                ApplyFormatting()
                AdjustPrintOptions()
            Finally
                workbook.EndUpdate()
            End Try
        End Sub

        Private Sub Cleanup()
            Dim range As CellRange = Sheet.GetDataRange().Exclude(Sheet("1:11"))
            If range IsNot Nothing Then range.Clear()
            Sheet("I4").ClearContents()
            Sheet("I6:I8").ClearContents()
            workbook.DefinedNames.Clear()
        End Sub

        Private Sub GenerateAnnuityPaymentsContent()
            AddDefinedNamesForAnnuityPayments()
            Sheet("I4").FormulaInvariant = "=PMT(Interest_Rate_Per_Month,Scheduled_Number_Payments,-Loan_Amount)"
            Sheet("I5").FormulaInvariant = "=Loan_Years*Number_of_Payments_Per_Year"
            Sheet("I6").FormulaInvariant = "=ROUNDUP(Actual_Number_Payments,0)"
            workbook.Calculate()
            Sheet("I7").FormulaInvariant = "=SUM(F12:F" & ActualLastRow & ")"
            Sheet("I8").FormulaInvariant = "=SUM($I$12:$I$" & ActualLastRow & ")"
            If ScheduledNumberOfPayments = 0 Then Return
            For i As Integer = 0 To ActualNumberOfPayments - 1
                Sheet("B" & (i + 12).ToString()).Value = i + 1
            Next

            Sheet("C12:C" & ActualLastRow).FormulaInvariant = "=DATE(YEAR(Loan_Start),MONTH(Loan_Start)+(B12)*12/Number_of_Payments_Per_Year,DAY(Loan_Start))"
            Sheet("D12").Formula = "=Loan_Amount"
            If ScheduledNumberOfPayments > 1 Then Sheet("D13:D" & ActualLastRow).Formula = "=J12"
            Sheet("E12:E" & ActualLastRow).FormulaInvariant = "=IF(D12>0,IF(Scheduled_payment<D12, Scheduled_payment, D12),0)"
            Sheet("F12:F" & ActualLastRow).FormulaInvariant = "=IF(Extra_Payments<>0, IF(Scheduled_payment<D12, G12-E12, 0), 0)"
            Sheet("G12:G" & ActualLastRow).FormulaInvariant = "=H12+I12"
            Sheet("H12:H" & ActualLastRow).FormulaInvariant = "=IF(J12>0,PPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount),D12)"
            Sheet("I12:I" & ActualLastRow).FormulaInvariant = "=IF(D12>0,IPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount),0)"
            Sheet("J12:J" & ActualLastRow).FormulaInvariant = "=IF(D12-PPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount)>0,D12-PPMT(Interest_Rate_Per_Month,B12,Actual_Number_Payments,-Loan_Amount),0)"
            Sheet("K12:K" & ActualLastRow).FormulaInvariant = "=SUM($I$12:$I12)"
            workbook.Calculate()
        End Sub

        Private Sub AddDefinedNamesForAnnuityPayments()
            Dim sheetName As String = "'" & Sheet.Name & "'"
            Dim separator As Char = workbook.Options.Culture.TextInfo.ListSeparator(0)
            Dim definedNames As DefinedNameCollection = workbook.DefinedNames
            definedNames.Add("Loan_Amount", sheetName & "!$E$4")
            definedNames.Add("Interest_Rate", sheetName & "!$E$5")
            definedNames.Add("Loan_Years", sheetName & "!$E$6")
            definedNames.Add("Number_of_Payments_Per_Year", sheetName & "!$E$7")
            definedNames.Add("Loan_Start", sheetName & "!$E$8")
            definedNames.Add("Extra_Payments", sheetName & "!$E$9")
            definedNames.Add("Scheduled_payment", sheetName & "!$I$4")
            definedNames.Add("Scheduled_Number_Payments", sheetName & "!$I$5")
            definedNames.Add("Interest_Rate_Per_Month", "=Interest_Rate/Number_of_Payments_Per_Year")
            definedNames.Add("Actual_Number_Payments", "=NPER(Interest_Rate_Per_Month" & separator & " " & sheetName & "!$I$4+Extra_Payments" & separator & " -Loan_Amount)")
        End Sub

        Private Sub GenerateScaledPaymentsContent()
            AddDefinedNamesForScaledPayments()
            Sheet("I4").FormulaInvariant = "=IF(Values_Entered,Scheduled_Monthly_Payment,"""")"
            Sheet("I5").FormulaInvariant = "=IF(Values_Entered,Loan_Years*Number_of_Payments_Per_Year,"""")"
            Sheet("I6").FormulaInvariant = "=IF(Values_Entered,Number_of_Payments,"""")"
            Sheet("I7").FormulaInvariant = "=IF(Values_Entered,SUMIF(Beg_Bal,"">0"",Extra_Pay),"""")"
            Sheet("I8").FormulaInvariant = "=IF(Values_Entered,SUMIF(Beg_Bal,"">0"",Int),"""")"
            workbook.Calculate()
            If ScheduledNumberOfPayments = 0 Then Return
            Sheet("B12").FormulaInvariant = "=1"
            If ScheduledNumberOfPayments > 1 Then Sheet("B13:B" & ScheduledLastRow).FormulaInvariant = "=IF(NOT(OR(J12=0,J12="""")),B12+1,"""")"
            Sheet("C12:C" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",DATE(YEAR(Loan_Start),MONTH(Loan_Start)+(Pay_Num)*12/Number_of_Payments_Per_Year,DAY(Loan_Start)),"""")"
            Sheet("D12").FormulaInvariant = "=IF(Values_Entered,Loan_Amount,"""")"
            If ScheduledNumberOfPayments > 1 Then Sheet("D13:D" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",J12,"""")"
            Sheet("E12:E" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",Scheduled_Monthly_Payment,"""")"
            Sheet("F12:F" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",IF(Sched_Pay+Extra_Payments<Beg_Bal,Extra_Payments,IF(AND(Pay_Num<>"""",Beg_Bal-Sched_Pay>0),Beg_Bal-Sched_Pay,IF(Pay_Num<>"""",0,""""))),"""")"
            Sheet("G12:G" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",IF(Sched_Pay+Extra_Pay<Beg_Bal,Princ+Int+Extra_Pay,IF(Pay_Num<>"""",Beg_Bal,"""")),"""")"
            Sheet("H12:H" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",Scheduled_Monthly_Payment,"""")"
            Sheet("I12:I" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",Beg_Bal*(Interest_Rate/Number_of_Payments_Per_Year),"""")"
            Sheet("J12:J" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",IF(Sched_Pay+Extra_Pay<Beg_Bal,Beg_Bal-Princ,IF(Pay_Num<>"""",0,"""")),"""")"
            Sheet("K12:K" & ScheduledLastRow).FormulaInvariant = "=IF(Pay_Num<>"""",SUM($I$12:$I12),"""")"
            workbook.Calculate()
        End Sub

        Private Sub AddDefinedNamesForScaledPayments()
            Dim sheetName As String = "'" & Sheet.Name & "'"
            Dim separator As Char = workbook.Options.Culture.TextInfo.ListSeparator(0)
            Dim definedNames As DefinedNameCollection = workbook.DefinedNames
            definedNames.Add("Values_Entered", "IF(Loan_Amount*Interest_Rate*Loan_Years*Loan_Start>0" & separator & "1" & separator & "0)")
            definedNames.Add("Full_Print", sheetName & "!$A:$K")
            definedNames.Add("Loan_Amount", sheetName & "!$E$4")
            definedNames.Add("Interest_Rate", sheetName & "!$E$5")
            definedNames.Add("Loan_Years", sheetName & "!$E$6")
            definedNames.Add("Number_of_Payments_Per_Year", sheetName & "!$E$7")
            definedNames.Add("Loan_Start", sheetName & "!$E$8")
            definedNames.Add("Extra_Payments", sheetName & "!$E$9")
            definedNames.Add("Scheduled_Monthly_Payment", "Loan_Amount/(Loan_Years*Number_of_Payments_Per_Year)")
            definedNames.Add("Scheduled_Number_Payments", sheetName & "!$I$5")
            definedNames.Add("Real_Number_Payments", sheetName & "!$I$6")
            definedNames.Add("Total_Early_Payments", sheetName & "!$I$7")
            definedNames.Add("Total_Interest", sheetName & "!$I$8")
            definedNames.Add("Beg_Bal", sheetName & "!$D$12:$D$" & ScheduledLastRow)
            definedNames.Add("Cum_Int", sheetName & "!$K$12:$K$" & ScheduledLastRow)
            definedNames.Add("Data", sheetName & "!$B$12:$K$" & ScheduledLastRow)
            definedNames.Add("End_Bal", sheetName & "!$J$12:$J$" & ScheduledLastRow)
            definedNames.Add("Extra_Pay", sheetName & "!$F$12:$F$" & ScheduledLastRow)
            definedNames.Add("Header_Row", "ROW(" & sheetName & "!$17:$17)")
            definedNames.Add("Int", sheetName & "!$I$12:$I$" & ScheduledLastRow)
            definedNames.Add("Last_Row", "IF(Values_Entered" & separator & "Header_Row+Number_of_Payments" & separator & "Header_Row)")
            definedNames.Add("Number_of_Payments", "=MATCH(0.01" & separator & "End_Bal" & separator & "-1)+1")
            definedNames.Add("Pay_Date", sheetName & "!$C$12:$C$" & ScheduledLastRow)
            definedNames.Add("Pay_Num", sheetName & "!$B$12:$B$" & ScheduledLastRow)
            definedNames.Add("Payment_Date", "DATE(YEAR(Loan_Start)" & separator & "MONTH(Loan_Start)+Payment_Number" & separator & "DAY(Loan_Start))")
            definedNames.Add("Princ", sheetName & "!$H$12:$H$" & ScheduledLastRow)
            definedNames.Add("Print_Area_Reset", "OFFSET(Full_Print" & separator & "0" & separator & "0" & separator & "Last_Row)")
            definedNames.Add("Sched_Pay", sheetName & "!$E$12:$E$" & ScheduledLastRow)
            definedNames.Add("Total_Pay", sheetName & "!$G$12:$G$" & ScheduledLastRow)
            definedNames.Add("Total_Payment", "Scheduled_Payment+Extra_Payment")
            definedNames.Add("Payment_Number", "ROW()-Header_Row")
            definedNames.Add("Loan_Not_Paid", "IF(Payment_Number<=Number_of_Payments" & separator & "1" & separator & "0)")
        End Sub

        Private Sub ApplyFormatting()
            Dim range As CellRange
            For i As Integer = 1 To ActualNumberOfPayments - 1 Step 2
                range = Sheet.Range.FromLTRB(1, 11 + i, 10, 11 + i)
                range.Fill.BackgroundColor = Color.FromArgb(217, 217, 217)
            Next

            range = Sheet("B11:K" & ActualLastRow)
            Dim formatting As Formatting = range.BeginUpdateFormatting()
            Try
                formatting.Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.Thin
                formatting.Borders.InsideVerticalBorders.Color = Color.White
                formatting.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            Finally
                range.EndUpdateFormatting(formatting)
            End Try

            Sheet("B12:C" & ActualLastRow).Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right
            Sheet("C11:C" & ActualLastRow).NumberFormat = "m/d/yyyy"
            Sheet("D11:K" & ActualLastRow).NumberFormat = "_(\$* #,##0.00_);_(\$ (#,##0.00);_(\$* "" - ""??_);_(@_)"
        End Sub

        Private Sub AdjustPrintOptions()
            Sheet.SetPrintRange(Sheet.GetDataRange())
            Sheet.PrintOptions.FitToPage = True
            Sheet.PrintOptions.FitToWidth = 1
            Sheet.PrintOptions.FitToHeight = 0 ' automatic
        End Sub
#End Region
    End Class
End Namespace
