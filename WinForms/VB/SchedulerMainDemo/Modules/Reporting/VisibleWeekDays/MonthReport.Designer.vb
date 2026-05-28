Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays

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
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
            Me.horizontalWeek1 = New DevExpress.XtraScheduler.Reporting.HorizontalWeek()
            Me.reportWeekView1 = New DevExpress.XtraScheduler.Reporting.ReportWeekView()
            Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
            Me.dayOfWeekHeaders1 = New DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders()
            CType((Me.reportWeekView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.calendarControl1, Me.timeIntervalInfo1, Me.dayOfWeekHeaders1, Me.horizontalWeek1})
            Me.Detail.HeightF = 340.67F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' calendarControl1
            ' 
            Me.calendarControl1.LocationFloat = New DevExpress.Utils.PointFloat(283F, 0F)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.SizeF = New System.Drawing.SizeF(358F, 133F)
            Me.calendarControl1.TimeCells = Me.horizontalWeek1
            Me.calendarControl1.View = Me.reportWeekView1
            ' 
            ' horizontalWeek1
            ' 
            Me.horizontalWeek1.LocationFloat = New DevExpress.Utils.PointFloat(3F, 166F)
            Me.horizontalWeek1.Name = "horizontalWeek1"
            Me.horizontalWeek1.SizeF = New System.Drawing.SizeF(645F, 174.67F)
            Me.horizontalWeek1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
            Me.horizontalWeek1.View = Me.reportWeekView1
            ' 
            ' reportWeekView1
            ' 
            Me.reportWeekView1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.None
            Me.reportWeekView1.VisibleWeekCount = 4
            ' 
            ' timeIntervalInfo1
            ' 
            Me.timeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 8F)
            Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
            Me.timeIntervalInfo1.SizeF = New System.Drawing.SizeF(267F, 125F)
            Me.timeIntervalInfo1.TimeCells = Me.horizontalWeek1
            ' 
            ' dayOfWeekHeaders1
            ' 
            Me.dayOfWeekHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(3F, 141F)
            Me.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1"
            Me.dayOfWeekHeaders1.SizeF = New System.Drawing.SizeF(645F, 25F)
            Me.dayOfWeekHeaders1.TimeCells = Me.horizontalWeek1
            Me.dayOfWeekHeaders1.View = Me.reportWeekView1
            ' 
            ' MonthReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Version = "10.2"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportWeekView1})
            CType((Me.reportWeekView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private dayOfWeekHeaders1 As DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders

        Private horizontalWeek1 As DevExpress.XtraScheduler.Reporting.HorizontalWeek

        Private reportWeekView1 As DevExpress.XtraScheduler.Reporting.ReportWeekView

        Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl

        Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
    End Class
End Namespace
