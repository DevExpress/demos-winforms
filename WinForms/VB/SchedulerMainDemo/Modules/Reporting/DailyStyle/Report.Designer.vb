Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.DailyStyle

    Partial Class Report

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
            Dim timeOfDayInterval1 As DevExpress.XtraScheduler.TimeOfDayInterval = New DevExpress.XtraScheduler.TimeOfDayInterval()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
            Me.dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
            Me.horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
            Me.horizontalDateHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders()
            Me.reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
            Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
            Me.dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
            CType((Me.reportDayView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.calendarControl1, Me.timeIntervalInfo1, Me.horizontalDateHeaders1, Me.horizontalResourceHeaders1, Me.dayViewTimeCells1, Me.dayViewTimeRuler1})
            Me.Detail.Height = 942
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.Location = New System.Drawing.Point(275, 0)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.Size = New System.Drawing.Size(350, 142)
            Me.calendarControl1.TimeCells = Me.dayViewTimeCells1
            Me.calendarControl1.View = Me.reportDayView1
            ' 
            ' dayViewTimeCells1
            ' 
            Me.dayViewTimeCells1.HorizontalHeaders = Me.horizontalResourceHeaders1
            Me.dayViewTimeCells1.Location = New System.Drawing.Point(54, 198)
            Me.dayViewTimeCells1.Name = "dayViewTimeCells1"
            Me.dayViewTimeCells1.Size = New System.Drawing.Size(595, 688)
            Me.dayViewTimeCells1.View = Me.reportDayView1
            timeOfDayInterval1.[End] = System.TimeSpan.Parse("18:00:00")
            timeOfDayInterval1.Start = System.TimeSpan.Parse("09:00:00")
            Me.dayViewTimeCells1.VisibleTime = timeOfDayInterval1
            ' 
            ' horizontalResourceHeaders1
            ' 
            Me.horizontalResourceHeaders1.HorizontalHeaders = Me.horizontalDateHeaders1
            Me.horizontalResourceHeaders1.Location = New System.Drawing.Point(54, 173)
            Me.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
            Me.horizontalResourceHeaders1.Size = New System.Drawing.Size(595, 25)
            Me.horizontalResourceHeaders1.View = Me.reportDayView1
            ' 
            ' horizontalDateHeaders1
            ' 
            Me.horizontalDateHeaders1.Location = New System.Drawing.Point(54, 148)
            Me.horizontalDateHeaders1.Name = "horizontalDateHeaders1"
            Me.horizontalDateHeaders1.Size = New System.Drawing.Size(595, 25)
            Me.horizontalDateHeaders1.View = Me.reportDayView1
            ' 
            ' timeIntervalInfo1
            ' 
            Me.timeIntervalInfo1.Location = New System.Drawing.Point(8, 0)
            Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
            Me.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns
            Me.timeIntervalInfo1.Size = New System.Drawing.Size(242, 133)
            Me.timeIntervalInfo1.TimeCells = Me.dayViewTimeCells1
            ' 
            ' dayViewTimeRuler1
            ' 
            Me.dayViewTimeRuler1.Corners.Top = 50
            Me.dayViewTimeRuler1.Location = New System.Drawing.Point(4, 148)
            Me.dayViewTimeRuler1.Name = "dayViewTimeRuler1"
            Me.dayViewTimeRuler1.Size = New System.Drawing.Size(50, 738)
            Me.dayViewTimeRuler1.TimeCells = Me.dayViewTimeCells1
            Me.dayViewTimeRuler1.View = Me.reportDayView1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Name = "Report"
            Me.PageHeight = 1100
            Me.PageWidth = 850
            Me.Version = "9.2"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportDayView1})
            CType((Me.reportDayView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private horizontalDateHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders

        Private reportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView

        Private horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders

        Private dayViewTimeCells1 As DevExpress.XtraScheduler.Reporting.DayViewTimeCells

        Private dayViewTimeRuler1 As DevExpress.XtraScheduler.Reporting.DayViewTimeRuler

        Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl

        Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
    End Class
End Namespace
