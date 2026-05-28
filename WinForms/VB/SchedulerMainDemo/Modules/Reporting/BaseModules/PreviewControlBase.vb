Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraScheduler.Demos.Reporting

    ''' <summary>
    ''' Summary description for ModuleControl.
    ''' </summary>
    ''' 
    Public Class ReportPreviewControlBase
        Inherits TutorialControl
        Implements IDemoSchedulerReport

        Private _baseDate As Date

        Public Class DesignForm
            Inherits XRDesignFormEx

            Protected Overrides Sub SaveLayout()
            End Sub

            Protected Overrides Sub RestoreLayout()
            End Sub
        End Class

#Region "Fields"
        Private components As System.ComponentModel.IContainer

        Private _preventUpdate As Boolean

        Protected fPrintBarManager As PrintBarManager

        Protected printControl As PrintControl

        Protected fSchedulerStorage As SchedulerStorage

        Protected fStoragePrintAdapter As SchedulerStoragePrintAdapter

#End Region
        Public Sub New()
            InitializeComponent()
            fPrintBarManager = CreatePrintBarManager(printControl)
            _baseDate = GetStartDate()
            FillReportSourceData()
            InitAdapterTimeInterval()
            CreateReports()
        End Sub

#Region "Properties"
        Protected Property PreventUpdate As Boolean
            Get
                Return _preventUpdate
            End Get

            Set(ByVal value As Boolean)
                _preventUpdate = value
            End Set
        End Property

        Public ReadOnly Property StoragePrintAdapter As SchedulerStoragePrintAdapter
            Get
                Return fStoragePrintAdapter
            End Get
        End Property

        Public ReadOnly Property SchedulerStorage As SchedulerStorage
            Get
                Return fSchedulerStorage
            End Get
        End Property

        Public ReadOnly Property BaseDate As Date
            Get
                Return _baseDate
            End Get
        End Property

#End Region
#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        ''' 
        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreviewControlBase))
            printControl = New PrintControl()
            fStoragePrintAdapter = New SchedulerStoragePrintAdapter()
            fSchedulerStorage = New SchedulerStorage(components)
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            printControl.Dock = DockStyle.Fill
            printControl.IsMetric = False
            printControl.Location = New System.Drawing.Point(0, 0)
            printControl.Name = "printControl"
            printControl.Size = New System.Drawing.Size(455, 396)
            printControl.TabIndex = 1
            printControl.TabStop = False
            AddHandler printControl.VisibleChanged, New EventHandler(AddressOf printControl_VisibleChanged)
            ' 
            ' fStoragePrintAdapter
            ' 
            fStoragePrintAdapter.SchedulerStorage = fSchedulerStorage
            fStoragePrintAdapter.TimeInterval.Duration = TimeSpan.Parse("1.00:00:00")
            fStoragePrintAdapter.TimeInterval.Start = New DateTime(2016, 5, 6, 0, 0, 0, 0)
            AddHandler fStoragePrintAdapter.ValidateAppointments, New AppointmentsValidationEventHandler(AddressOf fStoragePrintAdapter_ValidateAppointments)
            ' 
            ' ReportPreviewControlBase
            ' 
            Me.Controls.Add(printControl)
            Name = "ReportPreviewControlBase"
            Size = New System.Drawing.Size(700, 396)
            CType(fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private Sub InitializePrintingSystem(ByVal printingSystem As PrintingSystemBase)
            printingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, XtraPrinting.CommandVisibility.None)
        End Sub

        Protected Overridable Sub InitAdapterTimeInterval()
            StoragePrintAdapter.TimeInterval = New TimeInterval(BaseDate, TimeSpan.FromDays(60))
        End Sub

        Protected Overridable Sub FillReportSourceData()
            FillStorageData(SchedulerStorage, BaseDate)
        End Sub

        Protected Overridable Sub UpdateReportProperties(ByVal otherReport As XtraSchedulerReport)
            otherReport.PrintColorSchema = DemoUtils.ReportPrintColorSchema
            otherReport.SchedulerAdapter = StoragePrintAdapter
        End Sub

        Protected Function CreatePrintBarManager(ByVal pc As PrintControl) As PrintBarManager
            Dim printBarManager As PrintBarManager = New PrintBarManager()
            printBarManager.Form = printControl
            printBarManager.Initialize(pc)
            printBarManager.MainMenu.Visible = False
            printBarManager.AllowCustomization = False
            Return printBarManager
        End Function

        Protected Sub ShowDesignerForm(ByVal designForm As Form, ByVal parentForm As Form)
            designForm.MinimumSize = parentForm.MinimumSize
            If parentForm.WindowState = FormWindowState.Normal Then designForm.Bounds = parentForm.Bounds
            designForm.WindowState = parentForm.WindowState
            parentForm.Visible = False
            designForm.ShowDialog()
            parentForm.Visible = True
        End Sub

        Private Sub printControl_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Visible AndAlso Not _preventUpdate Then
                UpdateActiveReport()
            End If
        End Sub

        Private Sub UpdatePrintingSystemDocument(ByVal report As XtraSchedulerReport)
            If report Is Nothing OrElse report.PrintingSystem.Document.IsCreating = True Then Return
            Invalidate()
            Update()
            InitializePrintingSystem(report.PrintingSystem)
            printControl.PrintingSystem = report.PrintingSystem
            report.CreateDocument(True)
        End Sub

#Region "IDemoSchedulerReport Members"
        Public Sub UpdateActiveReport() Implements IDemoSchedulerReport.UpdateActiveReport
            Dim localReport As XtraSchedulerReport = GetActiveReport()
            If localReport Is Nothing Then Return
            UpdateReportProperties(localReport)
            UpdatePrintingSystemDocument(localReport)
        End Sub

#End Region
        Protected Overridable Sub CreateReports()
        End Sub

        Protected Overridable Function GetActiveReport() As XtraSchedulerReport
            Return Nothing
        End Function

        Private Sub fStoragePrintAdapter_ValidateAppointments(ByVal sender As Object, ByVal e As AppointmentsValidationEventArgs)
            DoValidateAppointments(e)
        End Sub

        Protected Overridable Sub DoValidateAppointments(ByVal e As AppointmentsValidationEventArgs)
        End Sub
    End Class
End Namespace
