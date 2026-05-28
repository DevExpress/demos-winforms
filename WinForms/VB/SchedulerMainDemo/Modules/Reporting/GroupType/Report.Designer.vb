Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.GroupType

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
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
            Me.horizontalWeek1 = New DevExpress.XtraScheduler.Reporting.HorizontalWeek()
            Me.reportWeekView1 = New DevExpress.XtraScheduler.Reporting.ReportWeekView()
            Me.resourceInfo1 = New DevExpress.XtraScheduler.Reporting.ResourceInfo()
            Me.dayOfWeekHeaders1 = New DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders()
            CType((Me.reportWeekView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine1, Me.timeIntervalInfo1, Me.resourceInfo1, Me.dayOfWeekHeaders1, Me.horizontalWeek1})
            Me.Detail.Height = 350
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.LineWidth = 2
            Me.xrLine1.Location = New System.Drawing.Point(0, 42)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.Size = New System.Drawing.Size(608, 8)
            Me.xrLine1.StylePriority.UseBorderWidth = False
            ' 
            ' timeIntervalInfo1
            ' 
            Me.timeIntervalInfo1.Location = New System.Drawing.Point(0, 67)
            Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
            Me.timeIntervalInfo1.Size = New System.Drawing.Size(308, 58)
            Me.timeIntervalInfo1.TimeCells = Me.horizontalWeek1
            ' 
            ' horizontalWeek1
            ' 
            Me.horizontalWeek1.Location = New System.Drawing.Point(3, 182)
            Me.horizontalWeek1.Name = "horizontalWeek1"
            Me.horizontalWeek1.ShowMoreItems = False
            Me.horizontalWeek1.Size = New System.Drawing.Size(645, 167)
            Me.horizontalWeek1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
            Me.horizontalWeek1.View = Me.reportWeekView1
            ' 
            ' reportWeekView1
            ' 
            Me.reportWeekView1.VisibleWeekCount = 4
            ' 
            ' resourceInfo1
            ' 
            Me.resourceInfo1.AutoScaleFont = False
            Me.resourceInfo1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 24F)
            Me.resourceInfo1.Location = New System.Drawing.Point(0, 0)
            Me.resourceInfo1.Name = "resourceInfo1"
            Me.resourceInfo1.Size = New System.Drawing.Size(600, 33)
            Me.resourceInfo1.TimeCells = Me.horizontalWeek1
            AddHandler Me.resourceInfo1.CustomizeText, New DevExpress.XtraScheduler.Reporting.TextCustomizingEventHandler(AddressOf Me.resourceInfo1_CustomizeText)
            ' 
            ' dayOfWeekHeaders1
            '             
            Me.dayOfWeekHeaders1.Location = New System.Drawing.Point(3, 157)
            Me.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1"
            Me.dayOfWeekHeaders1.Size = New System.Drawing.Size(645, 25)
            Me.dayOfWeekHeaders1.TimeCells = Me.horizontalWeek1
            Me.dayOfWeekHeaders1.View = Me.reportWeekView1
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

        Private reportWeekView1 As DevExpress.XtraScheduler.Reporting.ReportWeekView

        Private resourceInfo1 As DevExpress.XtraScheduler.Reporting.ResourceInfo

        Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo

        Private xrLine1 As DevExpress.XtraReports.UI.XRLine
    End Class
End Namespace
