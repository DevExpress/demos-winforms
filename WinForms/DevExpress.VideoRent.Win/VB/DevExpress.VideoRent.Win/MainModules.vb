Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPrinting
Imports DevExpress.VideoRent.Win.Forms
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraLayout
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.VideoRent.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports System.Drawing.Imaging
Imports DevExpress.XtraCharts.Printing
Imports DevExpress.Data
Imports DevExpress.XtraPrinting.Links
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports

Namespace DevExpress.VideoRent.Win
	Public Class TutorialControl
		Inherits TutorialControlBase
        Private fsession As UnitOfWork = Nothing
        Public Sub New()
        End Sub
        Public Sub SetParent(ByVal parent As Form)
            If Me.ParentFormMain Is parent Then
                Return
            End If
            Me.ParentFormMain = TryCast(parent, frmMain)
            If (Not Object.Equals(parent, Nothing)) Then
                AddMenuManager(Me.ParentFormMain.MenuManager)
                Me.RibbonMenuController.AddPageForControl(Me)
            End If
            DoParentChanged()
        End Sub
        Protected Overridable Sub DoParentChanged()
            RefreshGridDataSource()
        End Sub
        Protected Overridable Sub RefreshGridDataSource()
        End Sub
        Public Sub SetSession(ByVal session As UnitOfWork)
            If Object.Equals(Me.fsession, Nothing) Then
                Me.fsession = session
                InitData()
            End If
        End Sub
        Public ReadOnly Property Session() As UnitOfWork
            Get
                Return fsession
            End Get
        End Property
        Protected Overridable Sub InitData()
            If (Not Object.Equals(MainView, Nothing)) Then
                AddHandler MainView.FocusedRowChanged, AddressOf MainView_FocusedRowChanged
                AddHandler MainView.ColumnFilterChanged, AddressOf MainView_ColumnFilterChanged
                AddHandler MainView.GridControl.MouseDoubleClick, AddressOf GridControl_MouseDoubleClick
                AddHandler MainView.GridControl.KeyDown, AddressOf GridControl_KeyDown
            End If
            If (Not Object.Equals(AlternateView, Nothing)) Then
                AddHandler AlternateView.FocusedRowChanged, AddressOf MainView_FocusedRowChanged
                AddHandler AlternateView.ColumnFilterChanged, AddressOf MainView_ColumnFilterChanged
            End If
        End Sub
        Private Sub GridControl_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If MainView.OptionsBehavior.Editable = False AndAlso (Not Object.Equals(CurrentEditObject, Nothing)) AndAlso Object.Equals(e.KeyCode, Keys.Enter) Then
                DoEdit()
            End If
        End Sub
        Private Sub DoEdit()
            Cursor.Current = Cursors.WaitCursor
            Edit()
            Cursor.Current = Cursors.Default
        End Sub
        Private Sub GridControl_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim gv As GridView = TryCast((CType(sender, GridControl)).MainView, GridView)
            If (Not Object.Equals(gv, Nothing)) Then
                Dim info As GridHitInfo = gv.CalcHitInfo(New Point(e.X, e.Y))
                If Object.Equals(CurrentEditObject, Nothing) OrElse (Not info.InRow) OrElse AllowEdit(info) Then
                    Return
                End If
                DoEdit()
            Else
                Dim cv As ColumnView = TryCast((CType(sender, GridControl)).MainView, ColumnView)
                If (Not Object.Equals(cv, Nothing)) Then
                    If Object.Equals(CurrentEditObject, Nothing) Then
                        Return
                    End If
                    DoEdit()
                End If
            End If
        End Sub
        Protected Overridable Function AllowEdit(ByVal info As GridHitInfo) As Boolean
            Return False
        End Function
        Private Sub MainView_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs)
            DoFocusedRowChanged()
        End Sub
        Private Sub MainView_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs)
            DoFocusedRowChanged()
        End Sub
        Protected Overridable Sub DoFocusedRowChanged()
            SetCurrentObject(CurrentEditObject)
        End Sub
        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As IDXMenuManager)
            Dim grid As GridControl = TryCast(ctrl, GridControl)
            If (Not Object.Equals(grid, Nothing)) Then
                grid.MenuManager = manager
            End If
            Dim layout As LayoutControl = TryCast(ctrl, LayoutControl)
            If (Not Object.Equals(layout, Nothing)) Then
                layout.MenuManager = manager
            End If
            Dim pGrid As PivotGridControl = TryCast(ctrl, PivotGridControl)
            If (Not Object.Equals(pGrid, Nothing)) Then
                pGrid.MenuManager = manager
            End If
            Dim scheduler As XtraScheduler.SchedulerControl = TryCast(ctrl, XtraScheduler.SchedulerControl)
            If (Not Object.Equals(scheduler, Nothing)) Then
                scheduler.MenuManager = manager
            End If
        End Sub
        Protected Overrides Sub UpdateMenu()
            MyBase.UpdateMenu()
            If (Not Object.Equals(RibbonMenuController, Nothing)) Then
                RibbonMenuController.UpdateMenu()
            End If
        End Sub
        Protected Overrides Sub CreateDetailRibbon()
            MyBase.CreateDetailRibbon()
            If (Not Object.Equals(RibbonMenuController, Nothing)) Then
                RibbonMenuController.CreateDetailRibbon()
            End If
        End Sub
        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            RibbonMenuController.CurrentControl = Me
            SetCurrentObject(CurrentEditObject)
            RibbonMenuController.CalcCloseAllDetails()
            LoadFormLayout()
            If (Not Object.Equals(CurrentView, Nothing)) Then
                CurrentView.GridControl.ForceInitialize()
                CurrentView.Focus()
            End If
            AllowExport()
            EnableSimpleActions()
        End Sub
        Private Sub EnableSimpleActions()
            'add other actions
            If Object.Equals(CurrentEditObject, Nothing) Then
                ParentFormMain.RibbonMenuController.CalcDetailFormItemsEnabling(False, False, False)
            End If
            ParentFormMain.RotateLayoutButton.Enabled = AllowRotateLayout
            ParentFormMain.FlipLayoutButton.Enabled = AllowFlipLayout
        End Sub
        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            If Object.Equals(Session, Nothing) Then
                Return
            End If
            SessionHelper.CommitSession(Session, New ExceptionsProcesser(Me.FindForm()))
            SaveFormLayout()
        End Sub
        Friend Sub ForceHide()
            DoHide()
        End Sub
        Private Sub SetCurrentObject(ByVal obj As Object)
            If Object.Equals(CurrentView, Nothing) OrElse Object.Equals(ParentFormMain, Nothing) Then
                Return
            End If
            RibbonMenuController.CalcDetailFormItemsEnabling((Not Object.Equals(obj, Nothing)), CurrentView.FocusedRowHandle = 0, CurrentView.FocusedRowHandle = (CType(CurrentView, IDataControllerVisualClient)).VisibleRowCount - 1)
            RibbonMenuController.CalcCustomerItemsEnabling((Not Object.Equals(obj, Nothing)))
        End Sub
        Protected Overrides Sub LoadFormLayout()
            If Object.Equals(LayoutManager, Nothing) OrElse (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                Return
            End If
            LayoutManager.RestoreFormLayout(New FormLayoutInfo(Me.Name, Nothing, MainLayoutControl, MainView, AlternateView, MainDockManager, Nothing))
        End Sub
        Protected Overrides Sub SaveFormLayout()
            If Object.Equals(LayoutManager, Nothing) OrElse (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                Return
            End If
            LayoutManager.SaveFormLayout(New FormLayoutInfo(Me.Name, Nothing, MainLayoutControl, MainView, AlternateView, MainDockManager, Nothing))
        End Sub
        Protected Friend Overridable Sub ShowTutorial()
        End Sub
#Region "Editing"
        Public Overridable Sub Add()
        End Sub
        Public Overridable Sub Edit()
        End Sub
        Protected Friend Overridable Function Delete() As Boolean
            If Object.Equals(CurrentEditObject, Nothing) Then
                Return False
            End If
            If IsDetailExist(CurrentEditObject.Oid) Then
                Return False
            End If
            If XtraMessageBox.Show(Me.FindForm(), String.Format(ConstStrings.DeleteRecord, EditObjectName), ConstStrings.Question, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Dim ret As Boolean = ObjectHelper.SafeDelete(Me.FindForm(), CurrentEditObject, True)
                Return ret
            End If
            Return False
        End Function
        Public Overridable Sub EditOptions()
        End Sub
        Protected Friend Overridable Sub [Next]()
            CurrentView.FocusedRowHandle += 1
        End Sub
        Protected Friend Overridable Sub Prev()
            CurrentView.FocusedRowHandle -= 1
        End Sub
        Friend Sub SetCurrentCustomer()
            Dim customer As Customer
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                customer = TryCast(ActiveDetailControl.editObject, Customer)
            Else
                customer = TryCast(CurrentEditObject, Customer)
            End If
            If Object.Equals(customer, Nothing) Then
                Return
            End If
            LayoutManager.CurrentCustomer = LayoutManager.GetCustomer(customer)
        End Sub
        Protected Friend Overridable Sub RentMovie()
        End Sub
        Protected Friend Overridable Sub ReturnMovie()
        End Sub
        Protected Friend Overridable Sub CheckActiveItems()
        End Sub
        Friend Sub LoadPicture()
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                ActiveDetailControl.LoadPicture()
            End If
        End Sub
        Friend Sub ClearPicture()
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                ActiveDetailControl.ClearPicture()
            End If
        End Sub
        Friend Sub AddPicture()
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                ActiveDetailControl.AddPicture()
            End If
        End Sub
        Friend Sub DeletePicture()
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                ActiveDetailControl.DeletePicture()
            End If
        End Sub
        Friend Sub MovieAddItem()
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                ActiveDetailControl.MovieAddItem()
            End If
        End Sub
        Friend Sub MovieManageItems()
            If (Not Object.Equals(ActiveDetailControl, Nothing)) Then
                ActiveDetailControl.MovieManageItems()
            End If
        End Sub
        Protected Friend Overridable Sub ViewStylesPopup(ByVal sender As Object)
            ParentFormMain.MainViewButton.Down = CurrentView Is MainView
            ParentFormMain.AlternateViewButton.Down = CurrentView Is AlternateView
        End Sub
        Protected Friend Overridable Sub ShowMovieCategories()
        End Sub
        Protected Friend Overridable Sub DoViewChange(ByVal mainView As Boolean)
        End Sub
        Friend Overridable Sub RefreshData()
            Cursor.Current = Cursors.WaitCursor
            If (Not Object.Equals(Session, Nothing)) Then
                fsession = New UnitOfWork(Session.DataLayer)
            End If
        End Sub
        Friend Sub RotateLayout()
            If (Not AllowRotateLayout) OrElse Object.Equals(MainLayoutControl, Nothing) Then
                Return
            End If
            MainLayoutControl.Root.RotateLayout()
        End Sub
        Friend Sub FlipLayout()
            If (Not AllowFlipLayout) OrElse Object.Equals(MainLayoutControl, Nothing) Then
                Return
            End If
            MainLayoutControl.Root.FlipLayout()
        End Sub
#End Region
		#Region "Properties"
		Public Overridable ReadOnly Property EditObjectName() As String
			Get
				Return String.Empty
			End Get
		End Property
		Public Overridable ReadOnly Property EditObjectsName() As String
			Get
				Return String.Empty
			End Get
		End Property
		Protected Overridable ReadOnly Property CurrentView() As ColumnView
			Get
				Return MainView
			End Get
		End Property
		Protected Overridable ReadOnly Property MainView() As ColumnView
			Get
				Return Nothing
			End Get
		End Property
		Protected Overridable ReadOnly Property AlternateView() As ColumnView
			Get
				Return Nothing
			End Get
		End Property
		Protected Overridable ReadOnly Property MainDockManager() As DockManager
			Get
				Return Nothing
			End Get
		End Property
		Protected Overridable ReadOnly Property MainLayoutControl() As LayoutControl
			Get
				Return Nothing
			End Get
		End Property
		Protected Overridable ReadOnly Property CurrentEditObject() As VideoRentBaseObject
			Get
				Return Nothing
			End Get
		End Property
		Protected Friend Overridable ReadOnly Property ChartViewType() As ViewType
			Get
				Return ViewType.Bar
			End Get
		End Property
		Protected Overridable ReadOnly Property AllowRotateLayout() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overridable ReadOnly Property AllowFlipLayout() As Boolean
			Get
				Return False
			End Get
		End Property
		#End Region
		#Region "Print and Export"
		Protected Overridable Sub AllowExport()
			EnabledPrintExportActions(False)
		End Sub
		Friend Sub EnabledPrintExportActions(ByVal allow As Boolean)
			EnabledPrintExportActions(allow, allow, allow, allow, allow, allow, allow, allow, allow, allow)
		End Sub
		Friend Sub EnabledPrintExportActions(ByVal allowPrintPreview As Boolean, ByVal allowExportToPDF As Boolean, ByVal allowExportToXML As Boolean, ByVal allowExportToHTML As Boolean, ByVal allowExportToMHT As Boolean, ByVal allowExportToXLS As Boolean, ByVal allowExportToRTF As Boolean, ByVal allowExportToImage As Boolean, ByVal allowExportToText As Boolean, ByVal allowExportToXLSX As Boolean)
			ParentFormMain.ExportToPDFButton.Enabled = allowExportToPDF
			ParentFormMain.ExportToXMLButton.Enabled = allowExportToXML
			ParentFormMain.ExportToHTMLButton.Enabled = allowExportToHTML
			ParentFormMain.ExportToMHTButton.Enabled = allowExportToMHT
			ParentFormMain.ExportToXLSButton.Enabled = allowExportToXLS
			ParentFormMain.ExportToXLSXButton.Enabled = allowExportToXLSX
			ParentFormMain.ExportToRTFButton.Enabled = allowExportToRTF
			ParentFormMain.ExportToImageButton.Enabled = allowExportToImage
			ParentFormMain.ExportToTextButton.Enabled = allowExportToText
			ParentFormMain.PrintPreviewButton.Enabled = allowPrintPreview
			ParentFormMain.ExportButton.Enabled = allowExportToPDF OrElse allowExportToXML OrElse allowExportToHTML OrElse allowExportToMHT OrElse allowExportToXLS OrElse allowExportToRTF OrElse allowExportToImage OrElse allowExportToText OrElse allowExportToXLSX
		End Sub
		Protected Friend Overridable Sub PrintPreview()
		End Sub
		Protected Sub ShowRibbonPreviewDialog(ByVal link As LinkBase)
			InitPrintTool(New LinkPrintTool(link))
		End Sub
		Protected Sub ShowRibbonPreviewDialog(ByVal report As IReport)
			InitPrintTool(New ReportPrintTool(report))
		End Sub
		Protected Overridable Sub InitPrintTool(ByVal tool As PrintTool)
			tool.PreviewRibbonForm.AllowFormGlass = Me.ParentFormMain.AllowFormGlass
			tool.PreviewRibbonForm.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
			tool.PreviewRibbonForm.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
			tool.PreviewRibbonForm.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
			tool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)
		End Sub
		Protected Friend Overridable Sub ExportToPDF()
		End Sub
		Protected Friend Overridable Sub ExportToXML()
		End Sub
		Protected Friend Overridable Sub ExportToHTML()
		End Sub
		Protected Friend Overridable Sub ExportToMHT()
		End Sub
		Protected Friend Overridable Sub ExportToXLS()
		End Sub
		Protected Friend Overridable Sub ExportToXLSX()
		End Sub
		Protected Friend Overridable Sub ExportToRTF()
		End Sub
		Protected Friend Overridable Sub ExportToImage()
		End Sub
		Protected Friend Overridable Sub ExportToText()
		End Sub
		#End Region
	End Class
	Public Class GridExportTutorialControl
		Inherits TutorialControl
		Private printingSystem As PrintingSystem = Nothing
		Private ReadOnly Property Printing() As PrintingSystem
			Get
				If Object.Equals(printingSystem, Nothing) Then
					printingSystem = New PrintingSystem()
				End If
				Return printingSystem
			End Get
		End Property
        Protected Overridable ReadOnly Property ExportView() As BaseView
            Get
                Return MainView
            End Get
        End Property
		Protected Overridable ReadOnly Property Landscape() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides Sub AllowExport()
			EnabledPrintExportActions(True, True, False, True, True, True, True, False, True, True)
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			MyBase.Dispose(disposing)
			If disposing AndAlso (Not Object.Equals(printingSystem, Nothing)) Then
				printingSystem.Dispose()
			End If
		End Sub
		Protected Friend Overrides Sub PrintPreview()
			If (Not Object.Equals(ExportView, Nothing)) Then
				Dim printableLink As New PrintableComponentLink()
				printableLink.Component = ExportView.GridControl
				printableLink.Landscape = Landscape
				printableLink.CreateDocument(Printing)
				ShowRibbonPreviewDialog(printableLink)
			End If
		End Sub
		Private Sub ExportTo(ByVal ext As String, ByVal filter As String)
			Dim fileName As String = ObjectHelper.GetFileName(String.Format("*.{0}", ext), filter)
			If (Not String.IsNullOrEmpty(fileName)) Then
				Try
					ExportToCore(fileName, ext)
					ObjectHelper.OpenExportedFile(fileName)
				Catch
					EndExport()
					ObjectHelper.ShowExportErrorMessage()
				End Try
			End If
		End Sub
		Private Sub ExportToCore(ByVal filename As String, ByVal ext As String)
			If Object.Equals(ExportView, Nothing) Then
				Return
			End If
			StartExport()
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			If ext = "rtf" Then
                ExportView.ExportToRtf(filename)
            End If
			If ext = "pdf" Then
				ExportView.ExportToPdf(filename)
			End If
			If ext = "mht" Then
				ExportView.ExportToMht(filename)
			End If
			If ext = "html" Then
				ExportView.ExportToHtml(filename)
			End If
			If ext = "txt" Then
				ExportView.ExportToText(filename)
			End If
			If ext = "xls" Then
				ExportView.ExportToXls(filename)
			End If
			If ext = "xlsx" Then
				ExportView.ExportToXlsx(filename)
			End If
			Cursor.Current = currentCursor
			EndExport()
		End Sub
		Protected Overridable Sub StartExport()
        End Sub
		Protected Overridable Sub EndExport()
		End Sub
		Protected Friend Overrides Sub ExportToPDF()
            ExportTo("pdf", ConstStrings.PDFOpenFileFilter)
        End Sub
		Protected Friend Overrides Sub ExportToHTML()
			ExportTo("html", ConstStrings.HTMLOpenFileFilter)
		End Sub
		Protected Friend Overrides Sub ExportToMHT()
			ExportTo("mht", ConstStrings.MHTOpenFileFilter)
		End Sub
		Protected Friend Overrides Sub ExportToXLS()
			ExportTo("xls", ConstStrings.XLSOpenFileFilter)
		End Sub
		Protected Friend Overrides Sub ExportToXLSX()
			ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx")
		End Sub
		Protected Friend Overrides Sub ExportToRTF()
			ExportTo("rtf", "RTF document (*.rtf)|*.rtf")
		End Sub
		Protected Friend Overrides Sub ExportToText()
			ExportTo("txt", "Text document (*.txt)|*.txt")
		End Sub
	End Class
	Public Class ChartExportTutorialControl
		Inherits TutorialControl
		Private printingSystem As New PrintingSystem()

		Protected Overridable ReadOnly Property ShouldTransponsePivotOnPrint() As Boolean
			Get
				Return False
			End Get
		End Property

		Protected Overrides Sub AllowExport()
			EnabledPrintExportActions(True, True, False, True, True, True, False, True, False, True)
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			MyBase.Dispose(disposing)
			If disposing Then
				printingSystem.Dispose()
			End If
		End Sub
		Private ReadOnly Property MainPivotGrid() As PivotGridControl
			Get
				If Object.Equals(MainLayoutControl, Nothing) Then
					Return Nothing
				End If
				For Each ctrl As Control In MainLayoutControl.Controls
					If TypeOf ctrl Is PivotGridControl Then
						Return TryCast(ctrl, PivotGridControl)
					End If
				Next ctrl
				Return Nothing
			End Get
		End Property
		Private Sub TransposePivotGrid(ByVal pivotGrid As PivotGridControl)
			pivotGrid.BeginUpdate()
			For Each field As PivotGridField In pivotGrid.Fields
				If field.Area = PivotArea.ColumnArea Then
					field.Area = PivotArea.RowArea
				ElseIf field.Area = PivotArea.RowArea Then
					field.Area = PivotArea.ColumnArea
				End If
			Next field
			pivotGrid.OptionsChartDataSource.ProvideDataByColumns = Not pivotGrid.OptionsChartDataSource.ProvideDataByColumns
			pivotGrid.EndUpdate()
			pivotGrid.BestFit()
		End Sub
		Private Function CreatePrintableLink(ByVal printable As IPrintable) As PrintableComponentLink
			Dim chart As ChartControl = TryCast(printable, ChartControl)
			If (Not Object.Equals(chart, Nothing)) Then
				chart.OptionsPrint.SizeMode = PrintSizeMode.Stretch
			End If
			Dim printableLink As New PrintableComponentLink()
			printableLink.Component = printable
			Return printableLink
		End Function
		Private Function GetPrintableLink() As CompositeLink
			Dim link As New CompositeLink(printingSystem)
			Dim mainChart As ChartControl = Me.MainChart
			Dim alternateChart As ChartControl = Me.AlternateChart
			Dim pivotGrid As PivotGridControl = MainPivotGrid
			If (Not Object.Equals(mainChart, Nothing)) Then
				link.Links.Add(CreatePrintableLink(mainChart))
			End If
			If (Not Object.Equals(alternateChart, Nothing)) Then
				link.Links.Add(CreatePrintableLink(alternateChart))
			End If
			If (Not Object.Equals(pivotGrid, Nothing)) Then
				If ShouldTransponsePivotOnPrint Then
					TransposePivotGrid(pivotGrid)
				End If
				link.Links.Add(CreatePrintableLink(pivotGrid))
			End If
			link.Landscape = True
			link.CreateDocument()
			If (Not Object.Equals(pivotGrid, Nothing)) AndAlso ShouldTransponsePivotOnPrint Then
				TransposePivotGrid(pivotGrid)
			End If
			Return link
		End Function
		Protected Friend Overrides Sub PrintPreview()
			ShowRibbonPreviewDialog(GetPrintableLink())
		End Sub
		Protected Friend Overrides Sub ExportToPDF()
			Dim fileName As String = ObjectHelper.GetFileName("*.pdf", ConstStrings.PDFOpenFileFilter)
			If (Not String.IsNullOrEmpty(fileName)) Then
				Try
					GetPrintableLink().PrintingSystem.ExportToPdf(fileName)
					ObjectHelper.OpenExportedFile(fileName)
				Catch
					ObjectHelper.ShowExportErrorMessage()
				End Try
			End If
		End Sub
		Protected Friend Overrides Sub ExportToHTML()
			Dim fileName As String = ObjectHelper.GetFileName("*.html", ConstStrings.HTMLOpenFileFilter)
			If (Not String.IsNullOrEmpty(fileName)) Then
				Try
					GetPrintableLink().PrintingSystem.ExportToHtml(fileName)
					ObjectHelper.OpenExportedFile(fileName)
				Catch
					ObjectHelper.ShowExportErrorMessage()
				End Try
			End If
		End Sub
		Protected Friend Overrides Sub ExportToMHT()
			Dim fileName As String = ObjectHelper.GetFileName("*.mht", ConstStrings.MHTOpenFileFilter)
			If (Not String.IsNullOrEmpty(fileName)) Then
				Try
					GetPrintableLink().PrintingSystem.ExportToMht(fileName)
					ObjectHelper.OpenExportedFile(fileName)
				Catch
					ObjectHelper.ShowExportErrorMessage()
				End Try
			End If
		End Sub
		Protected Friend Overrides Sub ExportToXLS()
			Dim fileName As String = ObjectHelper.GetFileName("*.xls", ConstStrings.XLSOpenFileFilter)
			If (Not String.IsNullOrEmpty(fileName)) Then
				Try
					GetPrintableLink().PrintingSystem.ExportToXls(fileName)
					ObjectHelper.OpenExportedFile(fileName)
				Catch
					ObjectHelper.ShowExportErrorMessage()
				End Try
			End If
		End Sub
		Protected Friend Overrides Sub ExportToXLSX()
			Dim fileName As String = ObjectHelper.GetFileName("*.xlsx", "XLSX document (*.xlsx)|*.xlsx")
			If (Not String.IsNullOrEmpty(fileName)) Then
				Try
					GetPrintableLink().PrintingSystem.ExportToXlsx(fileName)
					ObjectHelper.OpenExportedFile(fileName)
				Catch
					ObjectHelper.ShowExportErrorMessage()
				End Try
			End If
		End Sub
		Protected Friend Overrides Sub ExportToImage()
			Dim fileName As String = ObjectHelper.GetFileName("*.png", ConstStrings.PNGOpenFileFilter)
			If (Not String.IsNullOrEmpty(fileName)) Then
				Try
					GetPrintableLink().PrintingSystem.ExportToImage(fileName, New ImageExportOptions(Drawing.DXImageFormat.Png))
					ObjectHelper.OpenExportedFile(fileName)
				Catch
					ObjectHelper.ShowExportErrorMessage()
				End Try
			End If
		End Sub
	End Class
End Namespace
