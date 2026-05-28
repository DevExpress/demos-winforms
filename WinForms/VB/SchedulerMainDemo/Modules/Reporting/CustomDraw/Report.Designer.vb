Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.CustomDraw

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
            Me.dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
            Me.dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
            Me.horizontalDateHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders()
            Me.horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
            Me.reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
            CType((Me.reportDayView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.dayViewTimeRuler1, Me.horizontalResourceHeaders1, Me.horizontalDateHeaders1, Me.dayViewTimeCells1})
            Me.Detail.Height = 86
            Me.Detail.Name = "Detail"
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.StylePriority.UsePadding = False
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' dayViewTimeRuler1
            ' 
            Me.dayViewTimeRuler1.Corners.Top = 48
            Me.dayViewTimeRuler1.Location = New System.Drawing.Point(0, 0)
            Me.dayViewTimeRuler1.Name = "dayViewTimeRuler1"
            Me.dayViewTimeRuler1.Size = New System.Drawing.Size(50, 83)
            Me.dayViewTimeRuler1.TimeCells = Me.dayViewTimeCells1
            Me.dayViewTimeRuler1.View = Me.reportDayView1
            AddHandler Me.dayViewTimeRuler1.CustomDrawDayViewTimeRuler, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.dayViewTimeRuler1_CustomDrawDayViewTimeRuler)
            ' 
            ' dayViewTimeCells1
            ' 
            Me.dayViewTimeCells1.HorizontalHeaders = Me.horizontalDateHeaders1
            Me.dayViewTimeCells1.Location = New System.Drawing.Point(50, 50)
            Me.dayViewTimeCells1.Name = "dayViewTimeCells1"
            Me.dayViewTimeCells1.Size = New System.Drawing.Size(592, 33)
            Me.dayViewTimeCells1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
            Me.dayViewTimeCells1.View = Me.reportDayView1
            timeOfDayInterval1.[End] = System.TimeSpan.Parse("18:00:00")
            timeOfDayInterval1.Start = System.TimeSpan.Parse("09:00:00")
            Me.dayViewTimeCells1.VisibleTime = timeOfDayInterval1
            AddHandler Me.dayViewTimeCells1.CustomDrawAppointment, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.dayViewTimeCells1_CustomDrawAppointment)
            AddHandler Me.dayViewTimeCells1.CustomDrawTimeCell, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.dayViewTimeCells1_CustomDrawTimeCell)
            AddHandler Me.dayViewTimeCells1.CustomDrawAppointmentBackground, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.dayViewTimeCells1_CustomDrawAppointmentBackground)
            AddHandler Me.dayViewTimeCells1.CustomDrawDayViewAllDayArea, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.dayViewTimeCells1_CustomDrawDayViewAllDayArea)
            ' 
            ' horizontalDateHeaders1
            ' 
            Me.horizontalDateHeaders1.HorizontalHeaders = Me.horizontalResourceHeaders1
            Me.horizontalDateHeaders1.Location = New System.Drawing.Point(50, 25)
            Me.horizontalDateHeaders1.Name = "horizontalDateHeaders1"
            Me.horizontalDateHeaders1.Size = New System.Drawing.Size(592, 25)
            Me.horizontalDateHeaders1.View = Me.reportDayView1
            AddHandler Me.horizontalDateHeaders1.CustomDrawDayHeader, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.horizontalDateHeaders1_CustomDrawDayHeader)
            ' 
            ' horizontalResourceHeaders1
            ' 
            Me.horizontalResourceHeaders1.Location = New System.Drawing.Point(50, 0)
            Me.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
            Me.horizontalResourceHeaders1.Size = New System.Drawing.Size(592, 25)
            Me.horizontalResourceHeaders1.View = Me.reportDayView1
            AddHandler Me.horizontalResourceHeaders1.CustomDrawResourceHeader, New DevExpress.XtraScheduler.CustomDrawObjectEventHandler(AddressOf Me.horizontalResourceHeaders1_CustomDrawResourceHeader)
            ' 
            ' reportDayView1
            ' 
            Me.reportDayView1.VisibleDayCount = 2
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

        Private horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders

        Private horizontalDateHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders
    End Class
End Namespace
