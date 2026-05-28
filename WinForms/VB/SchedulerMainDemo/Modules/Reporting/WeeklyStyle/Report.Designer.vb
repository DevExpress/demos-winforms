Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.WeeklyStyle

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
            Me.fullWeek1 = New DevExpress.XtraScheduler.Reporting.FullWeek()
            Me.horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
            Me.reportWeekView1 = New DevExpress.XtraScheduler.Reporting.ReportWeekView()
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
            Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
            CType((Me.reportWeekView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.fullWeek1, Me.horizontalResourceHeaders1, Me.calendarControl1, Me.timeIntervalInfo1})
            Me.Detail.Height = 846
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' fullWeek1
            ' 
            Me.fullWeek1.AppointmentDisplayOptions.ShowBordersForSameDayAppointments = True
            Me.fullWeek1.HorizontalHeaders = Me.horizontalResourceHeaders1
            Me.fullWeek1.Location = New System.Drawing.Point(4, 200)
            Me.fullWeek1.Name = "fullWeek1"
            Me.fullWeek1.Size = New System.Drawing.Size(642, 633)
            Me.fullWeek1.View = Me.reportWeekView1
            ' 
            ' horizontalResourceHeaders1
            ' 
            Me.horizontalResourceHeaders1.Location = New System.Drawing.Point(4, 175)
            Me.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
            Me.horizontalResourceHeaders1.Size = New System.Drawing.Size(642, 25)
            Me.horizontalResourceHeaders1.View = Me.reportWeekView1
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.Location = New System.Drawing.Point(292, 0)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.Size = New System.Drawing.Size(350, 142)
            Me.calendarControl1.TimeCells = Me.fullWeek1
            Me.calendarControl1.View = Me.reportWeekView1
            ' 
            ' timeIntervalInfo1
            ' 
            Me.timeIntervalInfo1.Location = New System.Drawing.Point(0, 0)
            Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
            Me.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns
            Me.timeIntervalInfo1.Size = New System.Drawing.Size(283, 133)
            Me.timeIntervalInfo1.TimeCells = Me.fullWeek1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Version = "17.2"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportWeekView1})
            CType((Me.reportWeekView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private reportWeekView1 As DevExpress.XtraScheduler.Reporting.ReportWeekView

        Private horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders

        Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl

        Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo

        Private fullWeek1 As DevExpress.XtraScheduler.Reporting.FullWeek
    End Class
End Namespace
