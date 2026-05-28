Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays

    Partial Class DayReport

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
            Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
            Me.dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
            Me.reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
            Me.horizontalDateHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders()
            Me.dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
            CType((Me.reportDayView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.dayViewTimeRuler1, Me.horizontalDateHeaders1, Me.dayViewTimeCells1, Me.calendarControl1, Me.timeIntervalInfo1})
            Me.Detail.HeightF = 827F
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
            Me.calendarControl1.TimeCells = Me.dayViewTimeCells1
            Me.calendarControl1.View = Me.reportDayView1
            ' 
            ' timeIntervalInfo1
            ' 
            Me.timeIntervalInfo1.FormatType = DevExpress.XtraScheduler.Reporting.TimeIntervalFormatType.Weekly
            Me.timeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 8F)
            Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
            Me.timeIntervalInfo1.SizeF = New System.Drawing.SizeF(267F, 125F)
            Me.timeIntervalInfo1.TimeCells = Me.dayViewTimeCells1
            ' 
            ' dayViewTimeCells1
            ' 
            Me.dayViewTimeCells1.HorizontalHeaders = Me.horizontalDateHeaders1
            Me.dayViewTimeCells1.LocationFloat = New DevExpress.Utils.PointFloat(59.99997F, 190.6251F)
            Me.dayViewTimeCells1.Name = "dayViewTimeCells1"
            Me.dayViewTimeCells1.ShowWorkTimeOnly = True
            Me.dayViewTimeCells1.SizeF = New System.Drawing.SizeF(580F, 626.3749F)
            Me.dayViewTimeCells1.View = Me.reportDayView1
            ' 
            ' reportDayView1
            ' 
            Me.reportDayView1.VisibleDayCount = 5
            ' 
            ' horizontalDateHeaders1
            ' 
            Me.horizontalDateHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(59.99997F, 164.6251F)
            Me.horizontalDateHeaders1.Name = "horizontalDateHeaders1"
            Me.horizontalDateHeaders1.SizeF = New System.Drawing.SizeF(579.9999F, 26F)
            Me.horizontalDateHeaders1.View = Me.reportDayView1
            ' 
            ' dayViewTimeRuler1
            ' 
            Me.dayViewTimeRuler1.Corners.Top = 25
            Me.dayViewTimeRuler1.LocationFloat = New DevExpress.Utils.PointFloat(9.999974F, 164.625F)
            Me.dayViewTimeRuler1.Name = "dayViewTimeRuler1"
            Me.dayViewTimeRuler1.SizeF = New System.Drawing.SizeF(50F, 652.3749F)
            Me.dayViewTimeRuler1.TimeCells = Me.dayViewTimeCells1
            Me.dayViewTimeRuler1.View = Me.reportDayView1
            ' 
            ' DayReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Version = "10.2"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportDayView1})
            CType((Me.reportDayView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl

        Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo

        Private dayViewTimeRuler1 As DevExpress.XtraScheduler.Reporting.DayViewTimeRuler

        Private dayViewTimeCells1 As DevExpress.XtraScheduler.Reporting.DayViewTimeCells

        Private horizontalDateHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders

        Private reportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView
    End Class
End Namespace
