Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight

    Partial Class TimelineReport

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
            Me.timelineCells = New DevExpress.XtraScheduler.Reporting.TimelineCells()
            Me.timelineScaleHeaders1 = New DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders()
            Me.reportTimelineView1 = New DevExpress.XtraScheduler.Reporting.ReportTimelineView()
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
            Me.formatTimeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo()
            CType((Me.reportTimelineView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.verticalResourceHeaders1, Me.timelineCells, Me.calendarControl1, Me.timelineScaleHeaders1, Me.formatTimeIntervalInfo1})
            Me.Detail.HeightF = 316F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' verticalResourceHeaders1
            ' 
            Me.verticalResourceHeaders1.Corners.Top = 25
            Me.verticalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(2.000046F, 157F)
            Me.verticalResourceHeaders1.Name = "verticalResourceHeaders1"
            Me.verticalResourceHeaders1.SizeF = New System.Drawing.SizeF(25F, 134.2917F)
            Me.verticalResourceHeaders1.TimeCells = Me.timelineCells
            Me.verticalResourceHeaders1.View = Me.reportTimelineView1
            ' 
            ' timelineCells
            ' 
            Me.timelineCells.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never
            Me.timelineCells.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never
            Me.timelineCells.HorizontalHeaders = Me.timelineScaleHeaders1
            Me.timelineCells.LocationFloat = New DevExpress.Utils.PointFloat(27F, 182F)
            Me.timelineCells.Name = "timelineCells"
            Me.timelineCells.SizeF = New System.Drawing.SizeF(620F, 110F)
            Me.timelineCells.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
            Me.timelineCells.View = Me.reportTimelineView1
            ' 
            ' timelineScaleHeaders1
            ' 
            Me.timelineScaleHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(27.00005F, 157F)
            Me.timelineScaleHeaders1.Name = "timelineScaleHeaders1"
            Me.timelineScaleHeaders1.SizeF = New System.Drawing.SizeF(620F, 25F)
            Me.timelineScaleHeaders1.View = Me.reportTimelineView1
            ' 
            ' reportTimelineView1
            ' 
            timeScaleYear1.Enabled = False
            timeScaleQuarter1.Enabled = False
            timeScaleMonth1.Enabled = False
            timeScaleWeek1.DisplayFormat = "MM/dd/yyyy"
            timeScaleWeek1.Enabled = False
            timeScaleHour1.Enabled = False
            timeScaleFixedInterval1.Enabled = False
            Me.reportTimelineView1.Scales.Add(timeScaleYear1)
            Me.reportTimelineView1.Scales.Add(timeScaleQuarter1)
            Me.reportTimelineView1.Scales.Add(timeScaleMonth1)
            Me.reportTimelineView1.Scales.Add(timeScaleWeek1)
            Me.reportTimelineView1.Scales.Add(timeScaleDay1)
            Me.reportTimelineView1.Scales.Add(timeScaleHour1)
            Me.reportTimelineView1.Scales.Add(timeScaleFixedInterval1)
            Me.reportTimelineView1.VisibleIntervalCount = 7
            Me.reportTimelineView1.VisibleResourceCount = 0
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.LocationFloat = New DevExpress.Utils.PointFloat(292F, 0F)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.SizeF = New System.Drawing.SizeF(350F, 142F)
            Me.calendarControl1.TimeCells = Me.timelineCells
            Me.calendarControl1.View = Me.reportTimelineView1
            ' 
            ' formatTimeIntervalInfo1
            ' 
            Me.formatTimeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.formatTimeIntervalInfo1.Name = "formatTimeIntervalInfo1"
            Me.formatTimeIntervalInfo1.SizeF = New System.Drawing.SizeF(283F, 142F)
            Me.formatTimeIntervalInfo1.TimeCells = Me.timelineCells
            ' 
            ' TimelineReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Version = "12.1"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportTimelineView1})
            CType((Me.reportTimelineView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private timelineScaleHeaders1 As DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders

        Private timelineCells As DevExpress.XtraScheduler.Reporting.TimelineCells

        Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl

        Private verticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders

        Private reportTimelineView1 As DevExpress.XtraScheduler.Reporting.ReportTimelineView

        Private formatTimeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo
    End Class
End Namespace
