Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.MultiColumn

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
            Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
            Me.horizontalWeek1 = New DevExpress.XtraScheduler.Reporting.HorizontalWeek()
            Me.reportWeekView1 = New DevExpress.XtraScheduler.Reporting.ReportWeekView()
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
            Me.dayOfWeekHeaders1 = New DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders()
            Me.verticalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders()
            CType((Me.reportWeekView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.timeIntervalInfo1, Me.calendarControl1, Me.dayOfWeekHeaders1, Me.verticalResourceHeaders1, Me.horizontalWeek1})
            Me.Detail.Height = 851
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' timeIntervalInfo1
            ' 
            Me.timeIntervalInfo1.Location = New System.Drawing.Point(33, 0)
            Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
            Me.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns
            Me.timeIntervalInfo1.PrintInColumn = DevExpress.XtraScheduler.Reporting.PrintInColumnMode.Odd
            Me.timeIntervalInfo1.Size = New System.Drawing.Size(242, 133)
            Me.timeIntervalInfo1.TimeCells = Me.horizontalWeek1
            ' 
            ' horizontalWeek1
            ' 
            Me.horizontalWeek1.CompressWeekend = False
            Me.horizontalWeek1.Location = New System.Drawing.Point(27, 181)
            Me.horizontalWeek1.Name = "horizontalWeek1"
            Me.horizontalWeek1.Size = New System.Drawing.Size(620, 668)
            Me.horizontalWeek1.View = Me.reportWeekView1
            ' 
            ' reportWeekView1
            ' 
            Me.reportWeekView1.VisibleResourceCount = 2
            Me.reportWeekView1.VisibleWeekCount = 2
            Me.reportWeekView1.VisibleWeekDayColumnCount = 2
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.Location = New System.Drawing.Point(292, 0)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.PrintInColumn = DevExpress.XtraScheduler.Reporting.PrintInColumnMode.Even
            Me.calendarControl1.Size = New System.Drawing.Size(350, 150)
            Me.calendarControl1.TimeCells = Me.horizontalWeek1
            Me.calendarControl1.View = Me.reportWeekView1
            ' 
            ' dayOfWeekHeaders1
            '             
            Me.dayOfWeekHeaders1.Location = New System.Drawing.Point(27, 156)
            Me.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1"
            Me.dayOfWeekHeaders1.Size = New System.Drawing.Size(620, 25)
            Me.dayOfWeekHeaders1.TimeCells = Me.horizontalWeek1
            Me.dayOfWeekHeaders1.View = Me.reportWeekView1
            ' 
            ' verticalResourceHeaders1
            '             
            Me.verticalResourceHeaders1.Corners.Top = 25
            Me.verticalResourceHeaders1.Location = New System.Drawing.Point(2, 156)
            Me.verticalResourceHeaders1.Name = "verticalResourceHeaders1"
            Me.verticalResourceHeaders1.Size = New System.Drawing.Size(25, 692)
            Me.verticalResourceHeaders1.TimeCells = Me.horizontalWeek1
            Me.verticalResourceHeaders1.View = Me.reportWeekView1
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Version = "9.2"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportWeekView1})
            CType((Me.reportWeekView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private dayOfWeekHeaders1 As DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders

        Private horizontalWeek1 As DevExpress.XtraScheduler.Reporting.HorizontalWeek

        Private verticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders

        Private reportWeekView1 As DevExpress.XtraScheduler.Reporting.ReportWeekView

        Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo

        Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
    End Class
End Namespace
