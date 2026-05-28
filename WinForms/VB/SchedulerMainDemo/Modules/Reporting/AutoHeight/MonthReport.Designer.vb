Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight

    Partial Class MonthReport

        Private Detail As DevExpress.XtraReports.UI.DetailBand

        'private dsCustomers dsCustomers1;
        'private DevExpress.XtraScheduler.Reporting.Demos.MultiColumnReport.dsCustomersTableAdapters.CustomersTableAdapter customersTableAdapter1;
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
            Me.reportMonthView1 = New DevExpress.XtraScheduler.Reporting.ReportMonthView()
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
            Me.horizontalWeek = New DevExpress.XtraScheduler.Reporting.HorizontalWeek()
            Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
            CType((Me.reportMonthView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.horizontalResourceHeaders1, Me.calendarControl1, Me.timeIntervalInfo1, Me.horizontalWeek})
            Me.Detail.HeightF = 313F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' horizontalResourceHeaders1
            ' 
            Me.horizontalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 147F)
            Me.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
            Me.horizontalResourceHeaders1.SizeF = New System.Drawing.SizeF(648F, 26F)
            Me.horizontalResourceHeaders1.View = Me.reportMonthView1
            ' 
            ' reportMonthView1
            ' 
            Me.reportMonthView1.VisibleWeekCount = 2
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.LocationFloat = New DevExpress.Utils.PointFloat(292F, 0F)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.SizeF = New System.Drawing.SizeF(350F, 142F)
            Me.calendarControl1.TimeCells = Me.horizontalWeek
            Me.calendarControl1.View = Me.reportMonthView1
            ' 
            ' horizontalWeek
            ' 
            Me.horizontalWeek.HorizontalHeaders = Me.horizontalResourceHeaders1
            Me.horizontalWeek.LocationFloat = New DevExpress.Utils.PointFloat(0F, 173F)
            Me.horizontalWeek.Name = "horizontalWeek"
            Me.horizontalWeek.SizeF = New System.Drawing.SizeF(648F, 140F)
            Me.horizontalWeek.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
            Me.horizontalWeek.View = Me.reportMonthView1
            ' 
            ' timeIntervalInfo1
            ' 
            Me.timeIntervalInfo1.FormatType = DevExpress.XtraScheduler.Reporting.TimeIntervalFormatType.Monthly
            Me.timeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(9.000015F, 0F)
            Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
            Me.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns
            Me.timeIntervalInfo1.SizeF = New System.Drawing.SizeF(283F, 117F)
            Me.timeIntervalInfo1.TimeCells = Me.horizontalWeek
            ' 
            ' MonthReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Version = "17.2"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportMonthView1})
            CType((Me.reportMonthView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private reportMonthView1 As DevExpress.XtraScheduler.Reporting.ReportMonthView

        Private horizontalWeek As DevExpress.XtraScheduler.Reporting.HorizontalWeek

        Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl

        Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo

        Private horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders
    End Class
End Namespace
