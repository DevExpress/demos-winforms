Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.TimelineStyle

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
            Dim timeScaleYear1 As DevExpress.XtraScheduler.TimeScaleYear = New DevExpress.XtraScheduler.TimeScaleYear()
            Dim timeScaleQuarter1 As DevExpress.XtraScheduler.TimeScaleQuarter = New DevExpress.XtraScheduler.TimeScaleQuarter()
            Dim timeScaleMonth1 As DevExpress.XtraScheduler.TimeScaleMonth = New DevExpress.XtraScheduler.TimeScaleMonth()
            Dim timeScaleWeek1 As DevExpress.XtraScheduler.TimeScaleWeek = New DevExpress.XtraScheduler.TimeScaleWeek()
            Dim timeScaleDay1 As DevExpress.XtraScheduler.TimeScaleDay = New DevExpress.XtraScheduler.TimeScaleDay()
            Dim timeScaleHour1 As DevExpress.XtraScheduler.TimeScaleHour = New DevExpress.XtraScheduler.TimeScaleHour()
            Dim timeScaleFixedInterval1 As DevExpress.XtraScheduler.TimeScaleFixedInterval = New DevExpress.XtraScheduler.TimeScaleFixedInterval()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.verticalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders()
            Me.timelineCells1 = New DevExpress.XtraScheduler.Reporting.TimelineCells()
            Me.timelineScaleHeaders1 = New DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders()
            Me.reportTimelineView1 = New DevExpress.XtraScheduler.Reporting.ReportTimelineView()
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
            Me.formatTimeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo()
            CType((Me.reportTimelineView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.verticalResourceHeaders1, Me.timelineCells1, Me.calendarControl1, Me.timelineScaleHeaders1, Me.formatTimeIntervalInfo1})
            Me.Detail.Height = 846
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' verticalResourceHeaders1
            ' 
            Me.verticalResourceHeaders1.Corners.Top = 42
            Me.verticalResourceHeaders1.Location = New System.Drawing.Point(2, 157)
            Me.verticalResourceHeaders1.Name = "verticalResourceHeaders1"
            Me.verticalResourceHeaders1.Size = New System.Drawing.Size(25, 675)
            Me.verticalResourceHeaders1.TimeCells = Me.timelineCells1
            Me.verticalResourceHeaders1.View = Me.reportTimelineView1
            ' 
            ' timelineCells1
            ' 
            Me.timelineCells1.HorizontalHeaders = Me.timelineScaleHeaders1
            Me.timelineCells1.Location = New System.Drawing.Point(27, 199)
            Me.timelineCells1.Name = "timelineCells1"
            Me.timelineCells1.Size = New System.Drawing.Size(620, 633)
            Me.timelineCells1.View = Me.reportTimelineView1
            ' 
            ' timelineScaleHeaders1
            ' 
            Me.timelineScaleHeaders1.Location = New System.Drawing.Point(27, 157)
            Me.timelineScaleHeaders1.Name = "timelineScaleHeaders1"
            Me.timelineScaleHeaders1.Size = New System.Drawing.Size(620, 42)
            Me.timelineScaleHeaders1.View = Me.reportTimelineView1
            ' 
            ' reportTimelineView1
            ' 
            timeScaleQuarter1.Enabled = False
            timeScaleWeek1.Enabled = False
            timeScaleDay1.Enabled = False
            timeScaleHour1.Enabled = False
            timeScaleFixedInterval1.Enabled = False
            Me.reportTimelineView1.Scales.Add(timeScaleYear1)
            Me.reportTimelineView1.Scales.Add(timeScaleQuarter1)
            Me.reportTimelineView1.Scales.Add(timeScaleMonth1)
            Me.reportTimelineView1.Scales.Add(timeScaleWeek1)
            Me.reportTimelineView1.Scales.Add(timeScaleDay1)
            Me.reportTimelineView1.Scales.Add(timeScaleHour1)
            Me.reportTimelineView1.Scales.Add(timeScaleFixedInterval1)
            Me.reportTimelineView1.VisibleIntervalCount = 5
            Me.reportTimelineView1.VisibleResourceCount = 2
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.Location = New System.Drawing.Point(292, 0)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.Size = New System.Drawing.Size(350, 142)
            Me.calendarControl1.TimeCells = Me.timelineCells1
            Me.calendarControl1.View = Me.reportTimelineView1
            ' 
            ' formatTimeIntervalInfo1
            ' 
            Me.formatTimeIntervalInfo1.Location = New System.Drawing.Point(0, 0)
            Me.formatTimeIntervalInfo1.Name = "formatTimeIntervalInfo1"
            Me.formatTimeIntervalInfo1.Size = New System.Drawing.Size(283, 142)
            Me.formatTimeIntervalInfo1.TimeCells = Me.timelineCells1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Version = "9.2"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportTimelineView1})
            CType((Me.reportTimelineView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private timelineScaleHeaders1 As DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders

        Private timelineCells1 As DevExpress.XtraScheduler.Reporting.TimelineCells

        Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl

        Private verticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders

        Private reportTimelineView1 As DevExpress.XtraScheduler.Reporting.ReportTimelineView

        Private formatTimeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo
    End Class
End Namespace
