Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.MailClient.Win
Imports DevExpress.Utils
Imports DevExpress.Utils.Design
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.ProductsDemo.Win
	Public Class ModulesNavigator
		Private ribbon As RibbonControl
		Private panel As PanelControl
		Private currentModuleName As String = String.Empty
		Public Sub New(ByVal ribbon As RibbonControl, ByVal panel As PanelControl)
			Me.ribbon = ribbon
			Me.panel = panel
		End Sub
		Public Sub ChangeSelectedItem(ByVal link As NavBarItemLink, ByVal moduleData As Object)
			Dim allowSetVisiblePage As Boolean = True
			Dim groupObject As NavBarGroupTagObject = TryCast(link.Item.Tag, NavBarGroupTagObject)
			If groupObject Is Nothing Then
				Return
			End If
			Dim deferredPagesToShow As New List(Of RibbonPage)()
			For Each page As RibbonPage In ribbon.Pages
				If Not String.IsNullOrEmpty(String.Format("{0}", page.Tag)) Then
					Dim isPageVisible As Boolean = groupObject.Name.Equals(page.Tag)
					If isPageVisible <> page.Visible AndAlso isPageVisible Then
						deferredPagesToShow.Add(page)
					Else
						page.Visible = isPageVisible
					End If
				End If
				If page.Visible AndAlso allowSetVisiblePage Then
					'page.Text = "Home";
					ribbon.SelectedPage = page
					allowSetVisiblePage = False
				End If
			Next page
			Dim firstShow As Boolean = groupObject.Module Is Nothing
			If firstShow Then
				If SplashScreenManager.Default Is Nothing Then
					SplashScreenManager.ShowForm(ribbon.FindForm(), GetType(DevExpress.ProductsDemo.Win.Forms.wfMain), False, True)
				End If
				Dim constructorInfoObj As ConstructorInfo = groupObject.ModuleType.GetConstructor(Type.EmptyTypes)
				If constructorInfoObj IsNot Nothing Then
					Try
						groupObject.Module = TryCast(constructorInfoObj.Invoke(Nothing), BaseModule)
						groupObject.Module.InitModule(ribbon, moduleData)
						currentModuleName = link.Caption
					Catch e As Exception
						Dim entryAsm = System.Reflection.Assembly.GetEntryAssembly()
						Dim msg As String = String.Format("Error on Showing Module: {0}" & vbCrLf & "PrevModule: {1}" & vbCrLf & "StartUp: {2}", link.Caption, currentModuleName, (If(entryAsm IsNot Nothing, entryAsm.Location, String.Empty)))
						Throw New ApplicationException(msg, e)
					End Try
				End If
				If SplashScreenManager.Default IsNot Nothing Then
					Dim frm As Form = TryCast(moduleData, Form)
					If frm IsNot Nothing Then
						If SplashScreenManager.FormInPendingState Then
							SplashScreenManager.CloseForm()
						Else
							SplashScreenManager.CloseForm(False, 500, frm)
						End If
					Else
						SplashScreenManager.CloseForm()
					End If
				End If
			End If
			ribbon.ColorScheme = groupObject.RibbonScheme
			For Each page As RibbonPage In deferredPagesToShow
				page.Visible = True
			Next page
			For Each page As RibbonPage In ribbon.Pages
				If page.Visible Then
					ribbon.SelectedPage = page
					Exit For
				End If
			Next page

			If groupObject.Module IsNot Nothing Then
				If panel.Controls.Count > 0 Then
'INSTANT VB NOTE: The variable currentModule was renamed since Visual Basic does not handle local variables named the same as class members well:
					Dim currentModule_Renamed As BaseModule = TryCast(panel.Controls(0), BaseModule)
					If currentModule_Renamed IsNot Nothing Then
						currentModule_Renamed.HideModule()
					End If
				End If
				panel.Controls.Clear()
				panel.Controls.Add(groupObject.Module)
				groupObject.Module.Dock = DockStyle.Fill
				groupObject.Module.ShowModule(firstShow)
			End If
		End Sub
		Public ReadOnly Property CurrentModule() As BaseModule
			Get
				If panel.Controls.Count = 0 Then
					Return Nothing
				End If
				Return TryCast(panel.Controls(0), BaseModule)
			End Get
		End Property
	End Class
	Public Class BaseControl
		Inherits XtraUserControl

		Public Sub New()
			If Not DesignTimeTools.IsDesignMode Then
				AddHandler LookAndFeel.ActiveLookAndFeel.StyleChanged, AddressOf ActiveLookAndFeel_StyleChanged
			End If
			AddHandler Me.VisibleChanged, AddressOf BaseControl_VisibleChanged
		End Sub
		Private Sub BaseControl_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.Visible Then
				ShowControlFirstTime()
				RemoveHandler Me.VisibleChanged, AddressOf BaseControl_VisibleChanged
			End If
		End Sub
		Friend Overridable Sub ShowControlFirstTime()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If Not DesignTimeTools.IsDesignMode Then
				LookAndFeelStyleChanged()
			End If
		End Sub
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso Not DesignTimeTools.IsDesignMode Then
				RemoveHandler LookAndFeel.ActiveLookAndFeel.StyleChanged, AddressOf ActiveLookAndFeel_StyleChanged
			End If
			MyBase.Dispose(disposing)
		End Sub
		Private Sub ActiveLookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			LookAndFeelStyleChanged()
		End Sub
		Protected Overridable Sub LookAndFeelStyleChanged()
		End Sub
	End Class
	Public Class BaseModule
		Inherits BaseControl

'INSTANT VB NOTE: The field partName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Protected partName_Renamed As String = String.Empty

		Public Sub New()
		End Sub

		Friend ReadOnly Property OwnerForm() As frmMain
			Get
				Return TryCast(Me.FindForm(), frmMain)
			End Get
		End Property
		Protected ReadOnly Property MainRibbon() As RibbonControl
			Get
				Return OwnerForm.Ribbon
			End Get
		End Property

		Friend Overridable Sub ShowModule(ByVal firstShow As Boolean)
			If OwnerForm Is Nothing Then
				Return
			End If
			If AutoMergeRibbon AndAlso ChildRibbon IsNot Nothing Then
				OwnerForm.Ribbon.MergeRibbon(ChildRibbon)
					Dim page As RibbonPage = OwnerForm.Ribbon.Pages.GetPageByText("VIEW")
					If page IsNot Nothing Then
						OwnerForm.Ribbon.MergedPages.Remove(page)
						OwnerForm.Ribbon.MergedPages.Insert(OwnerForm.Ribbon.MergedPages.Count, page)
					End If
				If ChildRibbonStatusBar IsNot Nothing Then
					OwnerForm.RibbonStatusBar.MergeStatusBar(ChildRibbonStatusBar)
					OwnerForm.ShowInfo(False)
				End If
			End If
			OwnerForm.SaveAsMenuItem.Enabled = SaveAsEnable
			OwnerForm.SaveAttachmentMenuItem.Enabled = SaveAttachmentEnable
			ShowReminder()
			ShowInfo()
			OwnerForm.ZoomManager.ZoomFactor = CInt(Math.Truncate(ZoomFactor * 100))
			SetZoomCaption()
			OwnerForm.EnableZoomControl(AllowZoomControl)
			OwnerForm.OnModuleShown(Me)
		End Sub
		Friend Overridable Sub FocusObject(ByVal obj As Object)
		End Sub
		Protected Overridable Sub ShowReminder()
			If OwnerForm IsNot Nothing Then
				OwnerForm.ShowReminder(Nothing)
			End If
		End Sub
		Friend Sub ShowInfo()
			If OwnerForm Is Nothing Then
				Return
			End If
			If Grid Is Nothing Then
                OwnerForm.ShowInfo(-1)
                Return
			End If
			Dim list As ICollection = TryCast(Grid.DataSource, ICollection)
			If list Is Nothing Then
                OwnerForm.ShowInfo(-1)
            Else
				OwnerForm.ShowInfo(list.Count)
			End If
		End Sub
		Friend Overridable Sub HideModule()
			If AutoMergeRibbon AndAlso OwnerForm IsNot Nothing Then
				If OwnerForm.Ribbon.MergedRibbon Is ChildRibbon Then
					Dim page As RibbonPage = OwnerForm.Ribbon.MergedPages.GetPageByText("VIEW")
					If page IsNot Nothing Then
						OwnerForm.Ribbon.Pages.Add(page)
					End If
					OwnerForm.Ribbon.UnMergeRibbon()
				End If
				OwnerForm.RibbonStatusBar.UnMergeStatusBar()
				OwnerForm.ShowInfo(True)
			End If
		End Sub
		Friend Overridable Sub InitModule(ByVal manager As IDXMenuManager, ByVal data As Object)
			SetMenuManager(Me.Controls, manager)
			If Grid IsNot Nothing AndAlso TypeOf Grid.MainView Is ColumnView Then
				AddHandler CType(Grid.MainView, ColumnView).ColumnFilterChanged, AddressOf BaseModule_ColumnFilterChanged
			End If
			CapitalizeChildRibbonPages()
		End Sub
		Private Sub CapitalizeChildRibbonPages()
			If ChildRibbon Is Nothing Then
				Return
			End If
			For Each page As RibbonPage In ChildRibbon.Pages
				page.Text = page.Text.ToUpper()
			Next page
			For Each category As RibbonPageCategory In ChildRibbon.PageCategories
				For Each page As RibbonPage In category.Pages
					page.Text = page.Text.ToUpper()
				Next page
			Next category
		End Sub
		Friend Sub ShowInfo(ByVal view As ColumnView)
			If OwnerForm Is Nothing Then
				Return
			End If
			ShowReminder()
			OwnerForm.ShowInfo(view.DataRowCount)
		End Sub
		Private Sub BaseModule_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs)
			ShowInfo(TryCast(sender, ColumnView))
		End Sub
		Private Sub SetMenuManager(ByVal controlCollection As ControlCollection, ByVal manager As IDXMenuManager)
			For Each ctrl As Control In controlCollection
'INSTANT VB NOTE: The variable grid was renamed since Visual Basic does not handle local variables named the same as class members well:
				Dim grid_Renamed As GridControl = TryCast(ctrl, GridControl)
				If grid_Renamed IsNot Nothing Then
					grid_Renamed.MenuManager = manager
					Exit For
				End If
				Dim pivot As PivotGridControl = TryCast(ctrl, PivotGridControl)
				If pivot IsNot Nothing Then
					pivot.MenuManager = manager
					Exit For
				End If
				Dim edit As BaseEdit = TryCast(ctrl, BaseEdit)
				If edit IsNot Nothing Then
					edit.MenuManager = manager
					Exit For
				End If
				SetMenuManager(ctrl.Controls, manager)
			Next ctrl
		End Sub
		Private Function FindRibbon(ByVal controls As ControlCollection) As RibbonControl
			Dim res As RibbonControl = TryCast(controls.OfType(Of Control)().FirstOrDefault(Function(x) TypeOf x Is RibbonControl), RibbonControl)
			If res IsNot Nothing Then
				Return res
			End If
			For Each control As Control In controls
				If control.HasChildren Then
					res = FindRibbon(control.Controls)
					If res IsNot Nothing Then
						Return res
					End If
				End If
			Next control
			Return Nothing
		End Function

		Protected Overridable ReadOnly Property AllowZoomControl() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overridable Sub SetZoomCaption()
		End Sub
		Public Overridable Property ZoomFactor() As Single
			Get
				Return 1
			End Get
			Set(ByVal value As Single)
			End Set
		End Property
		Public Overridable ReadOnly Property PrintableComponent() As IPrintable
			Get
				Return Grid
			End Get
		End Property
		Public Overridable ReadOnly Property ExportComponent() As IPrintable
			Get
				Return Grid
			End Get
		End Property
		Public Overridable ReadOnly Property AllowRtfTitle() As Boolean
			Get
				Return True
			End Get
		End Property
		Protected Overridable ReadOnly Property Grid() As GridControl
			Get
				Return Nothing
			End Get
		End Property
		Protected Overridable ReadOnly Property SaveAsEnable() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overridable ReadOnly Property SaveAttachmentEnable() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overridable ReadOnly Property SaveCalendarVisible() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Friend Overridable Sub ButtonClick(ByVal tag As String)
		End Sub
		Protected Friend Overridable Sub SendKeyDown(ByVal e As KeyEventArgs)
		End Sub
		Protected Friend Overridable ReadOnly Property CurrentRichEdit() As RichEditControl
			Get
				Return Nothing
			End Get
		End Property
		Public Overridable ReadOnly Property ModuleName() As String
			Get
				Return Me.GetType().Name
			End Get
		End Property
		Public ReadOnly Property PartName() As String
			Get
				Return partName_Renamed
			End Get
		End Property
        Private privateAutoMergeRibbon As Boolean
        <DefaultValue(False)>
        Protected Overridable Property AutoMergeRibbon() As Boolean
            Get
                Return privateAutoMergeRibbon
            End Get
            Set(ByVal value As Boolean)
                privateAutoMergeRibbon = value
            End Set
        End Property
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)>
		Protected Overridable ReadOnly Property ChildRibbon() As RibbonControl
			Get
				If Not AutoMergeRibbon Then
					Return Nothing
				End If
				Return FindRibbon(Controls)
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)>
		Protected Overridable ReadOnly Property ChildRibbonStatusBar() As RibbonStatusBar
			Get
				If ChildRibbon IsNot Nothing Then
					Return ChildRibbon.StatusBar
				End If
				Return Nothing
			End Get
		End Property
	End Class
	Public Class NavBarGroupTagObject
'INSTANT VB NOTE: The field name was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private name_Renamed As String
'INSTANT VB NOTE: The field moduleType was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private moduleType_Renamed As Type
        Private module_Renamed As BaseModule
        'INSTANT VB NOTE: The field ribbonScheme was renamed since Visual Basic does not allow fields to have the same name as other class members:
        Private ribbonScheme_Renamed As RibbonControlColorScheme = RibbonControlColorScheme.Default
		Public Sub New(ByVal name As String, ByVal moduleType As Type)
			Me.New(name, moduleType, RibbonControlColorScheme.Default)
		End Sub
		Public Sub New(ByVal name As String, ByVal moduleType As Type, ByVal ribbonScheme As RibbonControlColorScheme)
			Me.name_Renamed = name
			Me.moduleType_Renamed = moduleType
			Me.ribbonScheme_Renamed = ribbonScheme
            module_Renamed = Nothing
        End Sub
		Public ReadOnly Property Name() As String
			Get
				Return name_Renamed
			End Get
		End Property
		Public ReadOnly Property ModuleType() As Type
			Get
				Return moduleType_Renamed
			End Get
		End Property
		Public ReadOnly Property RibbonScheme() As RibbonControlColorScheme
			Get
				Return ribbonScheme_Renamed
			End Get
		End Property
        Public Property [Module]() As BaseModule
            Get
                Return module_Renamed
            End Get
            Set(ByVal value As BaseModule)
                module_Renamed = value
            End Set
        End Property
    End Class
	Public Class BackstageViewLabel
		Inherits LabelControl

		Public Sub New()
			Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
			LineVisible = True
			ShowLineShadow = False
		End Sub
	End Class
	Public Class ZoomManager
'INSTANT VB NOTE: The field zoomControl was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private zoomControl_Renamed As ZoomTrackBarControl
'INSTANT VB NOTE: The field zoomFactor was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private zoomFactor_Renamed As Integer = 0
		Private zoomValues As New List(Of Integer)() From {100, 115, 130, 150, 200, 250, 300, 350, 400, 500}
		Private ribbon As RibbonControl
		Private beiZoom As BarEditItem
		Private modulesNavigator As ModulesNavigator
		Public Sub New(ByVal ribbon As RibbonControl, ByVal modulesNavigator As ModulesNavigator, ByVal beItem As BarEditItem)
			Me.ribbon = ribbon
			Me.modulesNavigator = modulesNavigator
			Me.beiZoom = beItem
			AddHandler beiZoom.HiddenEditor, AddressOf beiZoom_HiddenEditor
			AddHandler beiZoom.ShownEditor, AddressOf beiZoom_ShownEditor
		End Sub
		Private ReadOnly Property ZoomControl() As ZoomTrackBarControl
			Get
				Return zoomControl_Renamed
			End Get
		End Property
		Public Property ZoomFactor() As Integer
			Get
				Return zoomFactor_Renamed
			End Get
			Set(ByVal value As Integer)
				zoomFactor_Renamed = value
				beiZoom.Caption = String.Format(" {0}%", ZoomFactor)
				Dim index As Integer = zoomValues.IndexOf(ZoomFactor)
				If index = -1 Then
					beiZoom.EditValue = ZoomFactor \ 10
				Else
					beiZoom.EditValue = 10 + index
				End If
				modulesNavigator.CurrentModule.ZoomFactor = CSng(ZoomFactor) / 100
			End Set
		End Property
		Public Sub SetZoomCaption(ByVal caption As String)
			beiZoom.Caption = caption
		End Sub
		Private Sub beiZoom_ShownEditor(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Me.zoomControl_Renamed = TryCast(ribbon.Manager.ActiveEditor, ZoomTrackBarControl)
			If ZoomControl IsNot Nothing Then
				AddHandler ZoomControl.ValueChanged, AddressOf OnZoomTackValueChanged
				OnZoomTackValueChanged(ZoomControl, EventArgs.Empty)
			End If
		End Sub
		Private Sub beiZoom_HiddenEditor(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			RemoveHandler ZoomControl.ValueChanged, AddressOf OnZoomTackValueChanged
			Me.zoomControl_Renamed = Nothing
		End Sub
		Private Sub OnZoomTackValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim val As Integer = ZoomControl.Value * 10
            If ZoomControl.Value > 10 Then
				val = zoomValues(ZoomControl.Value - 10)
			End If
			ZoomFactor = val
		End Sub
	End Class
	Public Class ObjectToolTipController
		Implements IDisposable

		Private controller As ToolTipController
		Private parent As Control
'INSTANT VB NOTE: The field editObject was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private editObject_Renamed As Object
		Public ReadOnly Property EditObject() As Object
			Get
				Return editObject_Renamed
			End Get
		End Property
		Public Sub New(ByVal parent As Control)
			Me.parent = parent
			AddHandler parent.Disposed, Sub()
				Dispose()
			End Sub
			Me.controller = New ToolTipController()
			Me.controller.ToolTipType = ToolTipType.SuperTip
			Me.controller.AllowHtmlText = True
			Me.controller.ReshowDelay = controller.InitialDelay
			Me.controller.AutoPopDelay = 10000
			AddHandler parent.MouseDown, Sub()
				HideHint(False)
			End Sub
			AddHandler parent.MouseLeave, Sub()
				HideHint(True)
			End Sub
		End Sub
		Public Sub ShowHint(ByVal editObject As Object, ByVal location As Point)
			If Object.Equals(editObject, Me.editObject_Renamed) Then
				Return
			End If
			Me.editObject_Renamed = editObject
			Dim info As New ToolTipControlInfo()
			Dim item As New ToolTipItem()
			InitToolTipItem(item)
			item.ImageToTextDistance = 10
			info.Object = Date.Now.Ticks
			info.SuperTip = New SuperToolTip()
			info.SuperTip.Items.Add(item)
			info.ToolTipPosition = Me.parent.PointToScreen(location)
			controller.ShowHint(info)
		End Sub
		Protected Overridable Sub InitToolTipItem(ByVal item As ToolTipItem)
		End Sub
		Public Sub HideHint(ByVal clearCurrentObject As Boolean)
			If clearCurrentObject Then
				Me.editObject_Renamed = Nothing
			End If
			Me.controller.HideHint()
		End Sub
		#Region "IDisposable Members"
		Public Sub Dispose() Implements IDisposable.Dispose
			Me.Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub
		Protected Overridable Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				Me.controller.Dispose()
			End If
		End Sub
		Protected Overrides Sub Finalize()
			Dispose(False)
		End Sub
		#End Region
	End Class
	Public Class ContactToolTipController
		Inherits ObjectToolTipController

		Private Const MaxPhotoWidth As Integer = 120, MaxPhotoHeight As Integer = 120
		Public Sub New(ByVal parent As Control)
			MyBase.New(parent)
		End Sub
		Private ReadOnly Property CurrentContact() As Contact
			Get
				Return TryCast(EditObject, Contact)
			End Get
		End Property
		Protected Overrides Sub InitToolTipItem(ByVal item As ToolTipItem)
			If CurrentContact Is Nothing Then
				Return
			End If
			If CurrentContact.Photo IsNot Nothing Then
				item.Image = ImageCreator.CreateImage(CurrentContact.Photo, MaxPhotoWidth, MaxPhotoHeight)
			End If
			item.Text = CurrentContact.GetContactInfoHtml()
		End Sub
	End Class
	Public Class ImageCreator
		Public Shared Function CreateImage(ByVal srcImage As Image, ByVal maxWidth As Integer, ByVal maxHeight As Integer) As Image
			If srcImage Is Nothing Then
				Return Nothing
			End If
			Dim size As Size = GetPhotoSize(srcImage, maxWidth, maxHeight)
			Dim ret As Image = New Bitmap(size.Width, size.Height)
			Using gr As Graphics = Graphics.FromImage(ret)
				gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
				gr.DrawImage(srcImage, New Rectangle(0, 0, size.Width, size.Height))
			End Using
			Return ret
		End Function
		Private Shared Function GetPhotoSize(ByVal image As Image, ByVal maxWidth As Integer, ByVal maxHeight As Integer) As Size
			Dim width As Integer = Math.Min(maxWidth, image.Width), height As Integer = width * image.Height \ image.Width
			If height > maxHeight Then
				height = maxHeight
				width = height * image.Width \ image.Height
			End If
			Return New Size(width, height)
		End Function
		Public Shared Function GetZoomDestRectangle(ByVal r As Rectangle, ByVal img As Image) As Rectangle
			Dim horzRatio As Single = Math.Min(CSng(r.Width) / img.Width, 1)
			Dim vertRatio As Single = Math.Min(CSng(r.Height) / img.Height, 1)
			Dim zoomRatio As Single = Math.Min(horzRatio, vertRatio)

			Return New Rectangle(r.Left + CInt(Math.Truncate(r.Width - img.Width * zoomRatio)) \ 2, r.Top + CInt(Math.Truncate(r.Height - img.Height * zoomRatio)) \ 2, CInt(Math.Truncate(img.Width * zoomRatio)), CInt(Math.Truncate(img.Height * zoomRatio)))
		End Function
	End Class
End Namespace
