Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.DateFormatting

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
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
            Me.dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
            Me.horizontalDateHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders()
            Me.reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
            Me.formatTimeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo()
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
            CType((Me.reportDayView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.dayViewTimeRuler1, Me.horizontalDateHeaders1, Me.dayViewTimeCells1, Me.formatTimeIntervalInfo1, Me.calendarControl1})
            Me.Detail.Height = 205
            Me.Detail.Name = "Detail"
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.StylePriority.UsePadding = False
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' dayViewTimeRuler1
            ' 
            Me.dayViewTimeRuler1.Corners.Top = 25
            Me.dayViewTimeRuler1.Location = New System.Drawing.Point(0, 150)
            Me.dayViewTimeRuler1.Name = "dayViewTimeRuler1"
            Me.dayViewTimeRuler1.Size = New System.Drawing.Size(50, 55)
            Me.dayViewTimeRuler1.TimeCells = Me.dayViewTimeCells1
            Me.dayViewTimeRuler1.View = Me.reportDayView1
            ' 
            ' dayViewTimeCells1
            ' 
            Me.dayViewTimeCells1.HorizontalHeaders = Me.horizontalDateHeaders1
            Me.dayViewTimeCells1.Location = New System.Drawing.Point(50, 175)
            Me.dayViewTimeCells1.Name = "dayViewTimeCells1"
            Me.dayViewTimeCells1.Size = New System.Drawing.Size(592, 30)
            Me.dayViewTimeCells1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
            Me.dayViewTimeCells1.View = Me.reportDayView1
            ' 
            ' horizontalDateHeaders1
            ' 
            Me.horizontalDateHeaders1.Location = New System.Drawing.Point(50, 150)
            Me.horizontalDateHeaders1.Name = "horizontalDateHeaders1"
            Me.horizontalDateHeaders1.Size = New System.Drawing.Size(592, 25)
            Me.horizontalDateHeaders1.View = Me.reportDayView1
            ' 
            ' reportDayView1
            ' 
            Me.reportDayView1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.None
            Me.reportDayView1.VisibleDayCount = 2
            ' 
            ' formatTimeIntervalInfo1
            ' 
            Me.formatTimeIntervalInfo1.Location = New System.Drawing.Point(8, 0)
            Me.formatTimeIntervalInfo1.Name = "formatTimeIntervalInfo1"
            Me.formatTimeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns
            Me.formatTimeIntervalInfo1.Size = New System.Drawing.Size(283, 142)
            Me.formatTimeIntervalInfo1.TimeCells = Me.dayViewTimeCells1
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.Location = New System.Drawing.Point(300, 0)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.Size = New System.Drawing.Size(350, 142)
            Me.calendarControl1.TimeCells = Me.dayViewTimeCells1
            Me.calendarControl1.View = Me.reportDayView1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Version = "9.2"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportDayView1})
            CType((Me.reportDayView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private reportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView

        Private dayViewTimeRuler1 As DevExpress.XtraScheduler.Reporting.DayViewTimeRuler

        Private dayViewTimeCells1 As DevExpress.XtraScheduler.Reporting.DayViewTimeCells

        Private horizontalDateHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders

        Private formatTimeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo

        Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
    End Class
End Namespace
