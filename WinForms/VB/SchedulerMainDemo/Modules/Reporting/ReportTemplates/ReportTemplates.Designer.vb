Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos.Reporting.ReportTemplates

    Partial Class ReportTemplatesModule

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

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraScheduler.Demos.Reporting.ReportTemplates.ReportTemplatesModule))
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl()
            Me.btnPreview = New DevExpress.XtraEditors.SimpleButton()
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl()
            Me.ControlPrintAdapter1 = New DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerStorage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType((Me.panelSeparatorControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ControlPrintAdapter1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.OptionsBehavior.UseAsyncMode = DevExpress.XtraScheduler.Demos.Program.OptUseAsyncMode
            Me.schedulerControl.OptionsView.EnableAnimation = False
            Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl.Location = New System.Drawing.Point(0, 50)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 331)
            Me.schedulerControl.Start = New System.DateTime(2010, 6, 30, 0, 0, 0, 0)
            Me.schedulerControl.DataStorage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.OptionsView.EnableAnimation = False
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.DayView.TimeScale = System.TimeSpan.Parse("01:00:00")
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.WorkWeekView.TimeScale = System.TimeSpan.Parse("01:00:00")
            ' 
            ' panelControl
            ' 
            Me.panelControl.Controls.Add(Me.btnPreview)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 42)
            Me.panelControl.TabIndex = 2
            ' 
            ' btnPreview
            ' 
            Me.btnPreview.ImageIndex = 2
            Me.btnPreview.Location = New System.Drawing.Point(11, 9)
            Me.btnPreview.Name = "btnPreview"
            Me.btnPreview.Size = New System.Drawing.Size(254, 24)
            Me.btnPreview.TabIndex = 87
            Me.btnPreview.Text = "&Preview a report via the template file..."
            AddHandler Me.btnPreview.Click, New System.EventHandler(AddressOf Me.btnPreview_Click)
            ' 
            ' panelSeparatorControl
            ' 
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 42)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 9
            ' 
            ' ControlPrintAdapter1
            ' 
            Me.ControlPrintAdapter1.SchedulerControl = Me.schedulerControl
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(704, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 381)
            Me.barDockControlBottom.Size = New System.Drawing.Size(704, 23)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 381)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(704, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 381)
            ' 
            ' ReportTemplatesModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ReportTemplatesModule"
            Me.Size = New System.Drawing.Size(704, 404)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ReportTemplates_Load)
            CType((Me.schedulerControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerStorage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            CType((Me.panelSeparatorControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ControlPrintAdapter1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage

        Private panelControl As DevExpress.XtraEditors.PanelControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private panelSeparatorControl As DevExpress.XtraEditors.PanelControl

        Private btnPreview As DevExpress.XtraEditors.SimpleButton

        Private ControlPrintAdapter1 As DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
    End Class
End Namespace
