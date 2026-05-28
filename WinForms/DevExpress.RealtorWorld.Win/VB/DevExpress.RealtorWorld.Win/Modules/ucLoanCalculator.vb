Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Menu

Namespace DevExpress.RealtorWorld.Win

    Public Partial Class ucLoanCalculator
        Inherits BaseModule

        Private ReadOnly Property InterestSeries As Series
            Get
                Return chartControl1.Series(interestString)
            End Get
        End Property

        Private ReadOnly Property PrincipalSeries As Series
            Get
                Return chartControl1.Series(principalString)
            End Get
        End Property

        Public Overrides ReadOnly Property ModuleCaption As String
            Get
                Return "Loan Calculator"
            End Get
        End Property

        Private interestBrush, principalBrush As Brush, interestForeBrush As Brush = Brushes.White, principalForeBrush As Brush = Brushes.Black

        Private paymentPen As Pen

        Private interestString As String = "Interest", principalString As String = "Principal"

        Private cellFont As Font = New Font(AppearanceObject.DefaultFont, FontStyle.Regular)

        Private monthlyPayment As Double = 0

        Public Sub New()
            InitializeComponent()
            LoanPayment.InitInterestRateData(editInterestRate)
            LoanPayment.InitTermOfLoan(editTermOfLoan)
            LoanPayment.InitStartMonth(editStart)
            editLoanAmount.Value = 250000
            lciInfo.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, lciCalc.Height)
        End Sub

        Friend Overrides Sub HideModule()
            MyBase.HideModule()
            gridView1.HideCustomization()
        End Sub

        Private ReadOnly Property StartMonth As Date
            Get
                Return CDate(editStart.EditValue)
            End Get
        End Property

        Private ReadOnly Property LoanAmount As Double
            Get
                Return Convert.ToDouble(editLoanAmount.EditValue)
            End Get
        End Property

        Private ReadOnly Property InterestRate As Double
            Get
                Return Convert.ToDouble(editInterestRate.EditValue) / 1200
            End Get
        End Property

        Private ReadOnly Property Months As Double
            Get
                Return CInt(editTermOfLoan.EditValue) * 12
            End Get
        End Property

        Private Sub Calc()
            Dim data As List(Of LoanPayment) = LoanPayment.Calculate(LoanAmount, InterestRate, Months, StartMonth, monthlyPayment)
            gridControl1.DataSource = data
            lcInfo.Text = String.Format("<size=+3>Your Monthly Payment<br><size=+4>{0:c}", monthlyPayment)
            BeginInvoke(New MethodInvoker(Sub() gcBalance.BestFit()))
            InterestSeries.DataSource = data
            InterestSeries.DateTimeSummaryOptions.SummaryFunction = "SUM([Interest])"
            PrincipalSeries.DataSource = data
            PrincipalSeries.DateTimeSummaryOptions.SummaryFunction = "SUM([Principal])"
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            gridControl1.ForceInitialize()
            Calc()
        End Sub

        Private Sub sbCalc_Click(ByVal sender As Object, ByVal e As EventArgs)
            Calc()
        End Sub

        Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
            Dim payment As LoanPayment = TryCast(gridView1.GetRow(e.RowHandle), LoanPayment)
            If payment Is Nothing Then Return
            If e.Column Is gcMonth Then
                e.DisplayText = payment.MonthString
            End If

            If e.Column Is gcPayment Then
                Dim r As Rectangle = e.Bounds
                r.Inflate(-3, -3)
                Dim interestWidth As Integer = CInt(r.Width * payment.Interest / payment.MonthlyPayment)
                Dim principalWidth As Integer = CInt(r.Width * payment.Principal / payment.MonthlyPayment)
                Dim interestRect As Rectangle = New Rectangle(r.X, r.Y, interestWidth, r.Height)
                Dim principalRect As Rectangle = New Rectangle(r.X + interestWidth, r.Y, principalWidth, r.Height)
                e.Cache.FillRectangle(interestBrush, interestRect)
                e.Cache.FillRectangle(principalBrush, principalRect)
                Using sf As StringFormat = New StringFormat()
                    sf.LineAlignment = StringAlignment.Center
                    '
                    sf.Alignment = StringAlignment.Near
                    Dim interest As String = String.Format(GetCellFormat(payment.Interest), payment.Interest)
                    If e.Cache.CalcTextSize(interest, cellFont, sf, 0).Width < interestRect.Width Then
                        e.Cache.DrawString(interest, cellFont, interestForeBrush, interestRect, sf)
                    Else
                        e.Cache.DrawString(interest, cellFont, principalForeBrush, principalRect, sf)
                    End If

                    '
                    sf.Alignment = StringAlignment.Far
                    Dim principal As String = String.Format(GetCellFormat(payment.Principal), payment.Principal)
                    If e.Cache.CalcTextSize(principal, cellFont, sf, 0).Width < principalRect.Width Then
                        e.Cache.DrawString(principal, cellFont, principalForeBrush, principalRect, sf)
                    Else
                        e.Cache.DrawString(principal, cellFont, interestForeBrush, interestRect, sf)
                    End If
                End Using

                e.Cache.DrawRectangle(paymentPen, New Rectangle(interestRect.X, interestRect.Y - 1, interestRect.Width + principalRect.Width, interestRect.Height + 1))
                e.Handled = True
            End If
        End Sub

        Private Function GetCellFormat(ByVal value As Double) As String
            Return If(value < 1, "{0:c2}", "{0:c0}")
        End Function

        Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs)
            If e.Column Is gcPayment Then
                Dim indent As Integer = 5
                e.Info.Caption = String.Empty
                e.Painter.DrawObject(e.Info)
                Dim rectHeight As Integer = e.Info.Bounds.Height - indent * 2
                Dim rectWidth As Integer = CInt(rectHeight * 1.3)
                Dim interestRect As Rectangle = New Rectangle(e.Bounds.X + e.Appearance.CalcTextSizeInt(e.Cache, interestString, e.Info.Bounds.Width).Width + indent * 2, e.Info.Bounds.Y + Convert.ToInt32((e.Info.Bounds.Height - rectHeight) \ 2) - 1, rectWidth, rectHeight)
                Dim principalRect As Rectangle = New Rectangle(e.Bounds.X + e.Bounds.Width - indent * 2 - e.Appearance.CalcTextSizeInt(e.Cache, principalString, e.Info.Bounds.Width).Width - rectWidth, e.Info.Bounds.Y + Convert.ToInt32((e.Info.Bounds.Height - rectHeight) \ 2) - 1, rectWidth, rectHeight)
                Dim r As Rectangle = e.Info.Bounds
                r.Inflate(-indent, 0)
                r.Height -= 1
                Using sf As StringFormat = New StringFormat()
                    sf.Alignment = StringAlignment.Near
                    sf.LineAlignment = StringAlignment.Center
                    e.Appearance.DrawString(e.Cache, interestString, r, sf)
                    sf.Alignment = StringAlignment.Far
                    e.Appearance.DrawString(e.Cache, principalString, r, sf)
                End Using

                e.Cache.FillRectangle(interestBrush, interestRect)
                e.Cache.FillRectangle(principalBrush, principalRect)
                e.Cache.DrawRectangle(paymentPen, interestRect)
                e.Cache.DrawRectangle(paymentPen, principalRect)
                e.Handled = True
            End If
        End Sub

        Private Sub gridView1_CustomDrawFooterCell(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs)
            If e.Column Is gcPayment Then
                Dim indent As Integer = 5
                e.Info.DisplayText = String.Empty
                e.Painter.DrawObject(e.Info)
                Dim r As Rectangle = e.Info.Bounds
                r.Inflate(-indent, 0)
                Using sf As StringFormat = New StringFormat()
                    sf.Alignment = StringAlignment.Near
                    sf.LineAlignment = StringAlignment.Center
                    e.Appearance.DrawString(e.Cache, String.Format("{0:c2}", customSum.InterestSum), r, sf)
                    sf.Alignment = StringAlignment.Far
                    e.Appearance.DrawString(e.Cache, String.Format("{0:c2}", customSum.PrincipalSum), r, sf)
                End Using

                e.Handled = True
            End If
        End Sub

        Private customSum As PaymentTypeSum

        Private Sub gridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As CustomSummaryEventArgs)
            If e.SummaryProcess = CustomSummaryProcess.Start Then
                customSum = New PaymentTypeSum()
            End If

            If e.SummaryProcess = CustomSummaryProcess.Calculate Then
                Dim payment As LoanPayment = TryCast(gridView1.GetRow(e.RowHandle), LoanPayment)
                If payment IsNot Nothing AndAlso e.IsTotalSummary Then customSum.AddToSum(payment.Interest, payment.Principal)
            End If

            If e.SummaryProcess = CustomSummaryProcess.Finalize Then
                If e.IsTotalSummary Then e.TotalValue = customSum
            End If
        End Sub

        Private Sub gridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
            Dim menu As GridViewFooterMenu = TryCast(e.Menu, GridViewFooterMenu)
            If menu IsNot Nothing AndAlso menu.Column IsNot Nothing Then
                If menu.Column.SummaryItem.SummaryType = SummaryItemType.Custom Then e.Menu.Items.Clear()
            End If
        End Sub

        Private Sub chartControl1_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs)
            If e.Series Is InterestSeries Then
                If interestBrush Is Nothing Then interestBrush = New SolidBrush(e.SeriesDrawOptions.ActualColor2)
                If paymentPen Is Nothing Then paymentPen = New Pen(interestBrush)
            ElseIf e.Series Is PrincipalSeries Then
                If principalBrush Is Nothing Then principalBrush = New SolidBrush(e.SeriesDrawOptions.Color)
            End If
        End Sub

        Private Sub gridView1_FilterPopupExcelData(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.FilterPopupExcelDataEventArgs)
            If e.Column Is gcMonth Then
                For i As Integer = 0 To e.Values.Length - 1
                    e.DisplayTexts(i) = LoanPayment.GetMonthString(CInt(e.Values(i)), TryCast(gridControl1.DataSource, List(Of LoanPayment)))
                Next
            End If
        End Sub
    End Class
End Namespace
