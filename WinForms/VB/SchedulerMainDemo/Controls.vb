Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraScheduler.Demos

    Public Class TutorialControl
        Inherits TutorialControlBase
        Implements IDXMenuManager

        Private menu As LookAndFeelMenu = Nothing

        Private fMenuManager As IDXMenuManager

        Public Sub New()
        End Sub

        Public Overridable ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return Nothing
            End Get
        End Property

        Public Overrides Property AutoMergeRibbon As Boolean
            Get
                Return True
            End Get

            Set(ByVal value As Boolean)
            End Set
        End Property

        Public Property DemoMainMenu As LookAndFeelMenu
            Get
                Return menu
            End Get

            Set(ByVal value As LookAndFeelMenu)
                If menu Is value Then Return
                menu = value
            End Set
        End Property

        Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point) Implements IDXMenuManager.ShowPopupMenu
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, fMenuManager, control, pos)
        End Sub

        Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
            Return Me
        End Function

        Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager
        End Sub

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

        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As XtraBars.BarManager)
            Dim scheduler As SchedulerControl = TryCast(ctrl, SchedulerControl)
            If scheduler IsNot Nothing Then scheduler.MenuManager = manager
            Dim be As XtraEditors.BaseEdit = TryCast(ctrl, XtraEditors.BaseEdit)
            If be IsNot Nothing Then be.MenuManager = manager
        End Sub

        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, True, ExportFormats.None, False)
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            MergeRibbon()
        End Sub

        Private Sub MergeRibbon()
            If ParentFormMain Is Nothing Then Return
            Dim parentRibbon As RibbonControl = ParentFormMain.Ribbon
            Dim page As RibbonPage = parentRibbon.MergedPages("File")
            Dim group As RibbonPageGroup = ParentFormMain.ReservGroup1.Page.Groups("rpgAbout")
            If page IsNot Nothing AndAlso group IsNot Nothing AndAlso page.Groups.GetGroupByName("rpgAbout") Is Nothing Then
                page.Groups.Add(CType(group.Clone(), RibbonPageGroup))
            End If
        End Sub

#Region "Print and Export"
        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            If PrintingSchedulerControl Is Nothing Then Return
            Dim printer As ComponentPrinter = New ComponentPrinter(PrintingSchedulerControl)
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
            If PrintingSchedulerControl IsNot Nothing Then PrintingSchedulerControl.ShowPrintPreview()
        End Sub

        Protected Overrides Sub Print()
            If PrintingSchedulerControl IsNot Nothing Then PrintingSchedulerControl.Print()
        End Sub
#End Region
    End Class
End Namespace
