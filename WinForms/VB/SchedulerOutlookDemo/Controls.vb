Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports System.Linq
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace DevExpress.XtraScheduler.Demos

    Public Class TutorialControl
        Inherits TutorialControlBase
        Implements IDXMenuManager

        Private menu As LookAndFeelMenu = Nothing

        Private fMenuManager As IDXMenuManager

        Private Property GlobalOptionIgnoreList As HashSet(Of String)

        Public Sub New()
            GlobalOptionIgnoreList = New HashSet(Of String)(GetGlobalOptionIgnoreList())
        End Sub

        Public Overridable ReadOnly Property Scheduler As SchedulerControl
            Get
                Return Nothing
            End Get
        End Property

        Public Overridable ReadOnly Property CommonRibbonPanel As CommonRibbon
            Get
                Return Nothing
            End Get
        End Property

        <DefaultValue(True)>
        Public Overrides Property AutoMergeRibbon As Boolean
            Get
                Return True
            End Get

            Set(ByVal value As Boolean)
            End Set
        End Property

        Protected Overridable Function GetGlobalOptionIgnoreList() As IEnumerable(Of String)
            Return New List(Of String)()
        End Function

        Public Overridable Function CanApplyGlobalOption(ByVal propertyName As String) As Boolean
            If GlobalOptionIgnoreList.Contains(propertyName) Then Return False
            Return True
        End Function

        Protected Overridable ReadOnly Property OptionsPane As Control
            Get
                Return Nothing
            End Get
        End Property

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property DemoMainMenu As LookAndFeelMenu
            Get
                Return menu
            End Get

            Set(ByVal value As LookAndFeelMenu)
                If menu Is value Then Return
                menu = value
            End Set
        End Property

        Private ReadOnly Property OutlookParentForm As OutlookForm
            Get
                Return TryCast(FindForm(), OutlookForm)
            End Get
        End Property

        Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point) Implements IDXMenuManager.ShowPopupMenu
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, fMenuManager, control, pos)
        End Sub

        Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
            Return Me
        End Function

        Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager
        End Sub

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property MenuManager As IDXMenuManager
            Get
                Return fMenuManager
            End Get

            Set(ByVal value As IDXMenuManager)
                fMenuManager = value
            End Set
        End Property

        Public Overridable ReadOnly Property ShowOptions As Boolean
            Get
                Return False
            End Get
        End Property 'TODO

        Public Overridable Sub ResetOptions()
        End Sub

        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim schedulerControl As SchedulerControl = TryCast(ctrl, SchedulerControl)
            If schedulerControl IsNot Nothing Then schedulerControl.MenuManager = manager
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then be.MenuManager = manager
        End Sub

        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, True, ExportFormats.None, False)
        End Sub

        Public Sub SetModulesSubMenu(ByVal buttonItem As BarButtonItem)
            If OutlookParentForm IsNot Nothing Then OutlookParentForm.SetModulesPopupMenu(buttonItem)
        End Sub

        Public Overridable Sub UpdateOptionsPaneVisibility(ByVal isVisible As Boolean)
            If OptionsPane Is Nothing Then Return
            OptionsPane.Visible = isVisible
        End Sub

        Friend Overridable Sub UpdateOptionsFromControl()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Scheduler IsNot Nothing Then AddHandler Scheduler.EditAppointmentFormShowing, AddressOf OnSchedulerControlEditAppointmentFormShowing
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            MergeRibbon()
        End Sub

        Private Sub MergeRibbon()
            If OutlookParentForm Is Nothing Then Return
            Dim parentRibbon As RibbonControl = OutlookParentForm.Ribbon
            Dim state As String = TryCast(parentRibbon.Tag, String)
            If String.IsNullOrEmpty(state) Then
                parentRibbon.Tag = "initialized"
                Dim page As RibbonPage = parentRibbon.MergedPages.Union(parentRibbon.Pages).Where(Function(x) Equals(x.Text, CommonRibbon.DefaultPageName)).FirstOrDefault()
                If page Is Nothing Then Return
                parentRibbon.SelectPage(page)
            End If
        End Sub

        Private Sub OnSchedulerControlEditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs)
            Dim schedulerControl As SchedulerControl = CType(sender, SchedulerControl)
            Dim form As OutlookAppointmentForm = New OutlookAppointmentForm(schedulerControl, e.Appointment, e.OpenRecurrenceForm)
            Try
                e.DialogResult = form.ShowDialog()
                e.Handled = True
            Finally
                form.Dispose()
            End Try
        End Sub

#Region "Print and Export"
        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If Scheduler Is Nothing Then Return
            Dim printer As ComponentPrinter = New ComponentPrinter(Scheduler)
            Dim oldCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If Equals(ext, "pdf") Then printer.Export(ExportTarget.Pdf, filename)
            If Equals(ext, "html") Then printer.Export(ExportTarget.Html, filename)
            If Equals(ext, "mht") Then printer.Export(ExportTarget.Mht, filename)
            If Equals(ext, "img") Then printer.Export(ExportTarget.Image, filename)
            Cursor.Current = oldCursor
        End Sub

        Protected Overrides Sub ExportToPDF()
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf")
        End Sub

        Protected Overrides Sub ExportToHTML()
            ExportTo("html", "HTML document (*.html)|*.html")
        End Sub

        Protected Overrides Sub ExportToImage()
            ExportTo("img", "BMP image (*.bmp)|*.bmp|EMF image (*.emf)|*.emf|WMF image (*.wmf)|*.wmf|GIF image (*.gif)|*.gif|JPEG image (*.jpg)|*.jpg|PNG image (*.png)|*.png|TIFF image (*.tiff)|*.tiff")
        End Sub

        Protected Overrides Sub PrintPreview()
            If Scheduler IsNot Nothing Then Scheduler.ShowPrintPreview()
        End Sub

        Protected Overrides Sub Print()
            If Scheduler IsNot Nothing Then Scheduler.Print()
        End Sub
#End Region
    End Class
End Namespace
