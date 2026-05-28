Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports System.Reflection
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid
Imports DevExpress.Utils.Design
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Controls
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Skins
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraPrinting

Namespace DevExpress.MailClient.Win
    Public Class ModulesNavigator
        Private ribbon As RibbonControl
        Private panel As PanelControl
        Public Sub New(ByVal ribbon As RibbonControl, ByVal panel As PanelControl)
            Me.ribbon = ribbon
            Me.panel = panel
        End Sub
        Public Sub ChangeGroup(ByVal group As NavBarGroup, ByVal moduleData As Object)
            Dim allowSetVisiblePage As Boolean = True
            Dim groupObject As NavBarGroupTagObject = TryCast(group.Tag, NavBarGroupTagObject)
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
                    SplashScreenManager.ShowForm(ribbon.FindForm(), GetType(DevExpress.MailClient.Win.Forms.wfMain), False, True)
                End If
                Dim constructorInfoObj As ConstructorInfo = groupObject.ModuleType.GetConstructor(Type.EmptyTypes)
                If constructorInfoObj IsNot Nothing Then
                    groupObject.Module = TryCast(constructorInfoObj.Invoke(Nothing), BaseModule)
                    groupObject.Module.InitModule(ribbon, moduleData)
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
                    Dim currentModule_Field As BaseModule = TryCast(panel.Controls(0), BaseModule)
                    If currentModule_Field IsNot Nothing Then
                        currentModule_Field.HideModule()
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
    Public Class FindControlManager
        Implements IDisposable

        Private ribbon As RibbonControl
        Private fControl As FindControl
        Public Sub New(ByVal ribbon As RibbonControl, ByVal control As FindControl)
            Me.ribbon = ribbon
            Me.fControl = control
            AddFindControlEvents()
        End Sub
        Private Sub AddFindControlEvents()
            AddHandler fControl.FindButton.GotFocus, AddressOf FindControl_GotFocus
            AddHandler fControl.FindEdit.GotFocus, AddressOf FindControl_GotFocus
            AddHandler fControl.ClearButton.GotFocus, AddressOf FindControl_GotFocus
            AddHandler fControl.FindButton.Leave, AddressOf FindControl_Leave
            AddHandler fControl.FindEdit.Leave, AddressOf FindControl_Leave
            AddHandler fControl.ClearButton.Leave, AddressOf FindControl_Leave
            fControl.FindButton.Image = My.Resources.Search
            fControl.ClearButton.Image = My.Resources.Delete_16x16
            fControl.FindButton.TabStop = False
            fControl.ClearButton.TabStop = False
            fControl.CalcButtonsBestFit()
        End Sub
        Private Sub FindControl_Leave(ByVal sender As Object, ByVal e As EventArgs)
            fControl.BeginInvoke(New MethodInvoker(AddressOf UpdateSearchTools))
        End Sub
        Private Sub FindControl_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
            UpdateSearchTools()
        End Sub
        Private Sub UpdateSearchTools()
            If fControl.FindButton.Focused OrElse fControl.FindEdit.ContainsFocus OrElse fControl.ClearButton.Focused Then
                ribbon.PageCategories(TagResources.SearchTools).Visible = True
                ribbon.SelectedPage = ribbon.PageCategories(TagResources.SearchTools).Pages(0)
            Else
                ribbon.PageCategories(TagResources.SearchTools).Visible = False
                ribbon.SelectedPage = ribbon.DefaultPageCategory.Pages(0)
            End If
        End Sub

#Region "IDisposable Members"
        Public Sub Dispose() Implements IDisposable.Dispose
            RemoveHandler fControl.FindButton.GotFocus, AddressOf FindControl_GotFocus
            RemoveHandler fControl.FindEdit.GotFocus, AddressOf FindControl_GotFocus
            RemoveHandler fControl.ClearButton.GotFocus, AddressOf FindControl_GotFocus
            RemoveHandler fControl.FindButton.Leave, AddressOf FindControl_Leave
            RemoveHandler fControl.FindEdit.Leave, AddressOf FindControl_Leave
            RemoveHandler fControl.ClearButton.Leave, AddressOf FindControl_Leave
        End Sub
#End Region
    End Class
    Public Class FilterColumnsManager
        Private items As List(Of BarButtonItem)
        Private view As GridView
        Private lockUpdate As Boolean = False
        Public Sub New(ByVal items As List(Of BarButtonItem))
            Me.items = items
            For Each item As BarButtonItem In items
                AddHandler item.DownChanged, AddressOf item_DownChanged
            Next item
        End Sub
        Private Function GetItemByName(ByVal name As String) As BarButtonItem
            For Each item As BarButtonItem In items
                If item.Tag.Equals(name) Then
                    Return item
                End If
            Next item
            Return Nothing
        End Function
        Public Sub SetDefault()
            lockUpdate = True
            For Each item As BarButtonItem In items
                If item.CanDown Then
                    item.Down = False
                End If
            Next item
            GetItemByName(TagResources.SubjectColumn).Down = True
            GetItemByName(TagResources.PersonColumn).Down = True
            lockUpdate = False
            Update()
        End Sub
        Private Sub Update()
            Dim filterColumns As String = String.Empty
            If GetItemByName(TagResources.SubjectColumn).Down Then
                filterColumns &= "Subject;"
            End If
            If GetItemByName(TagResources.PersonColumn).Down Then
                filterColumns &= "From;"
            End If
            If GetItemByName(TagResources.DateColumn).Down Then
                filterColumns &= "Date;"
            End If
            If GetItemByName(TagResources.PriorityColumn).Down Then
                filterColumns &= "Priority;"
            End If
            If GetItemByName(TagResources.AttachmentColumn).Down Then
                filterColumns &= "Attachment;"
            End If
            view.OptionsFind.FindFilterColumns = filterColumns
        End Sub
        Private Sub item_DownChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If lockUpdate Then
                Return
            End If
            Update()
        End Sub
        Public Sub InitGridView(ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            If view IsNot Nothing Then
                Return
            End If
            view = gridView
            SetDefault()
        End Sub
        Friend Sub UpdateColumnsCaption(ByVal [date] As String, ByVal person As String)
            GetItemByName(TagResources.PersonColumn).Caption = person
            GetItemByName(TagResources.DateColumn).Caption = [date]
            GetItemByName(TagResources.DateFilterMenu).Caption = [date]
        End Sub
    End Class
    Public Class PriorityMenu
        Inherits PopupMenu

        Private view As GridView
        Private lowPriority, mediumPriority, highPriority As BarButtonItem
        Public Sub New(ByVal manager As BarManager, ByVal view As GridView, ByVal lowGlyph As Image, ByVal highGlyph As Image)
            MyBase.New(manager)
            Me.view = view
            lowPriority = New BarButtonItem(manager, My.Resources.LowPriority)
            lowPriority.Glyph = lowGlyph
            mediumPriority = New BarButtonItem(manager, My.Resources.MediumPriority)
            highPriority = New BarButtonItem(manager, My.Resources.HighPriority)
            highPriority.Glyph = highGlyph
            ItemLinks.AddRange(New BarItem() {lowPriority, mediumPriority, highPriority})
            AddHandler lowPriority.ItemClick, AddressOf lowPriority_ItemClick
            AddHandler mediumPriority.ItemClick, AddressOf mediumPriority_ItemClick
            AddHandler highPriority.ItemClick, AddressOf highPriority_ItemClick
            lowPriority.ButtonStyle = BarButtonStyle.Check
            mediumPriority.ButtonStyle = BarButtonStyle.Check
            highPriority.ButtonStyle = BarButtonStyle.Check
        End Sub
        Protected Overrides Sub OnBeforePopup(ByVal e As CancelEventArgs)
            MyBase.OnBeforePopup(e)
            Dim priority As Integer = -1
            For Each row As Integer In view.GetSelectedRows()
                If row >= 0 Then
                    Dim message As Message = TryCast(view.GetRow(row), Message)
                    If priority = -1 Then
                        priority = message.Priority
                    End If
                    If priority <> message.Priority Then
                        priority = -1
                        Exit For
                    End If
                End If
            Next row
            lowPriority.Down = priority = 0
            mediumPriority.Down = priority = 1
            highPriority.Down = priority = 2
        End Sub
        Private Sub SetPriority(ByVal value As Integer)
            For Each row As Integer In view.GetSelectedRows()
                If row >= 0 Then
                    CType(view.GetRow(row), Message).Priority = value
                End If
            Next row
            view.LayoutChanged()
            view.MakeRowVisible(view.FocusedRowHandle)
        End Sub
        Private Sub highPriority_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            SetPriority(2)
        End Sub
        Private Sub mediumPriority_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            SetPriority(1)
        End Sub
        Private Sub lowPriority_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            SetPriority(0)
        End Sub
    End Class
    Public Class DateFilterMenu
        Inherits PopupMenu

        Private view As GridView
        Private filterManager As FilterCriteriaManager
        Public Sub New(ByVal manager As BarManager, ByVal view As GridView, ByVal filterManager As FilterCriteriaManager)
            MyBase.New(manager)
            Me.view = view
            Me.filterManager = filterManager
            CreateBarItem(My.Resources.IsToday, "IsOutlookIntervalToday([Date])")
            CreateBarItem(My.Resources.IsYesterday, "IsOutlookIntervalYesterday([Date])")
            CreateBarItem(My.Resources.IsEarlierThisWeek, "IsOutlookIntervalEarlierThisWeek([Date])")
            CreateBarItem(My.Resources.IsLastWeek, "IsOutlookIntervalLastWeek([Date])")
            CreateBarItem(My.Resources.IsEarlierThisMonth, "IsOutlookIntervalEarlierThisMonth([Date])")
            CreateBarItem(My.Resources.IsEarlierThisYear, "IsOutlookIntervalEarlierThisYear([Date])")
        End Sub
        Private Sub CreateBarItem(ByVal caption As String, ByVal filterString As String)
            Dim item As New BarButtonItem(Me.Manager, caption)
            item.Tag = filterString
            item.CloseSubMenuOnClick = False
            ItemLinks.Add(item)
            filterManager.AddBarItem(item, view.Columns("Date"), filterString)
        End Sub
    End Class
    Public Class FilterCriteriaManager
        Private view_Field As GridView
        Private itemList As List(Of FilterCriteriaItem)
        Private clearFilterItem As BarButtonItem
        Public Sub New(ByVal view As GridView)
            Me.view_Field = view
            itemList = New List(Of FilterCriteriaItem)()
            AddHandler view.ColumnFilterChanged, AddressOf view_ColumnFilterChanged
        End Sub
        Public ReadOnly Property View() As GridView
            Get
                Return view_Field
            End Get
        End Property
        Private Sub view_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateFilterInfo()
        End Sub
        Private Sub UpdateFilterInfo()
            For Each item As FilterCriteriaItem In itemList
                item.UpdateDown()
            Next item
            If clearFilterItem IsNot Nothing Then
                clearFilterItem.Enabled = Not view_Field.ActiveFilter.IsEmpty
            End If
        End Sub
        Public Sub AddBarItem(ByVal item As BarButtonItem, ByVal column As GridColumn, ByVal filterCriteria As String)
            itemList.Add(New FilterCriteriaItem(Me, item, column, filterCriteria))
        End Sub
        Public Sub AddClearFilterButton(ByVal item As BarButtonItem)
            clearFilterItem = item
            UpdateFilterInfo()
        End Sub
        Friend Function GetFilterCriteriaByColumn(ByVal column As GridColumn) As String
            Dim ret As String = String.Empty
            For Each item As FilterCriteriaItem In itemList
                If item.Checked AndAlso item.IsColumnEquals(column) Then
                    ret = AddCriteria(ret, item.FilterCriteria)
                End If
            Next item
            Return ret
        End Function

        Private Function AddCriteria(ByVal ret As String, ByVal filterCriteria As String) As String
            If Not String.IsNullOrEmpty(ret) Then
                ret = String.Format("{0} Or {1}", ret, filterCriteria)
            Else
                ret = filterCriteria
            End If
            Return ret
        End Function
    End Class
    Public Class FilterCriteriaItem
        Private item As BarButtonItem
        Private filterCriteria_Field As String
        Private column As GridColumn
        Private owner As FilterCriteriaManager
        Public Sub New(ByVal owner As FilterCriteriaManager, ByVal item As BarButtonItem, ByVal column As GridColumn, ByVal filterCriteria As String)
            Me.item = item
            Me.column = column
            Me.filterCriteria_Field = filterCriteria
            Me.owner = owner
            item.ButtonStyle = BarButtonStyle.Check
            AddHandler item.ItemClick, AddressOf item_ItemClick
        End Sub
        Private ReadOnly Property View() As GridView
            Get
                Return owner.View
            End Get
        End Property
        Public ReadOnly Property Checked() As Boolean
            Get
                Return item.Down
            End Get
        End Property
        Friend ReadOnly Property FilterCriteria() As String
            Get
                Return filterCriteria_Field
            End Get
        End Property
        Friend Function IsColumnEquals(ByVal column As GridColumn) As Boolean
            Return Me.column.Equals(column)
        End Function
        Private Sub item_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            UpdateFilterCriteria(column)
        End Sub
        Private Sub UpdateFilterCriteria(ByVal column As GridColumn)
            Dim filterCriteria_Field As String = owner.GetFilterCriteriaByColumn(column)
            If String.IsNullOrEmpty(filterCriteria_Field) Then
                View.ActiveFilter.Remove(column)
            Else
                View.ActiveFilter.Add(column, New ColumnFilterInfo(filterCriteria_Field))
            End If
        End Sub
        Friend Sub UpdateDown()
            item.Down = View.ActiveFilterString.IndexOf(filterCriteria_Field) >= 0
        End Sub
    End Class
    Public Class BaseControl
        Inherits XtraUserControl

        Public Sub New()
            If Not DesignTimeTools.IsDesignMode Then
                AddHandler LookAndFeel.ActiveLookAndFeel.StyleChanged, AddressOf ActiveLookAndFeel_StyleChanged
            End If
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Not DesignTimeTools.IsDesignMode Then
                LookAndFeelStyleChanged()
            End If
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not DesignTimeTools.IsDesignMode) Then
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
    Public Class NavPanePanel
        Inherits BaseControl

        Private state_Field As NavPaneState = NavPaneState.Collapsed
        Public Property State() As NavPaneState
            Get
                Return state_Field
            End Get
            Set(ByVal value As NavPaneState)
                state_Field = value
                RefreshBackColor()
            End Set
        End Property
        Protected Overrides Sub LookAndFeelStyleChanged()
            MyBase.LookAndFeelStyleChanged()
            RefreshBackColor()
        End Sub
        Public Sub RefreshBackColor()
            Me.BackColor = (New SkinElementInfo(CommonSkins.GetSkin(Me.LookAndFeel)(CommonSkins.SkinTextBorder))).Element.Border.GetBottom()
            Padding = New Padding(BorderByState(state_Field), 1, 1, If(IsOfficeStyle, BorderByState(state_Field), 1))
        End Sub
        Private Shared Function BorderByState(ByVal state As NavPaneState) As Integer
            Return If(state = NavPaneState.Collapsed, 0, 1)
        End Function
        Private ReadOnly Property IsOfficeStyle() As Boolean
            Get
                Return Me.LookAndFeel.ActiveSkinName.IndexOf("Office") > -1
            End Get
        End Property
    End Class
    Public Class BaseModule
        Inherits BaseControl

        Protected partName_Field As String = String.Empty
        Friend ReadOnly Property OwnerForm() As frmMain
            Get
                Return TryCast(Me.FindForm(), frmMain)
            End Get
        End Property
        Public Sub New()
        End Sub
        Friend Overridable Sub ShowModule(ByVal firstShow As Boolean)
            Dim owner As frmMain = OwnerForm
            If owner Is Nothing Then
                Return
            End If
            owner.SaveAsMenuItem.Enabled = SaveAsEnable
            owner.SaveAttachmentMenuItem.Enabled = SaveAttachmentEnable
            owner.SaveCalendar.Visible = SaveCalendarVisible
            owner.EnableLayoutButtons(True)
            ShowReminder()
            ShowInfo()
            owner.ZoomManager.ZoomFactor = CInt((ZoomFactor * 100))
            SetZoomCaption()
            owner.EnableZoomControl(AllowZoomControl)
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
                OwnerForm.ShowInfo(Nothing)
                Return
            End If
            Dim list As ICollection = TryCast(Grid.DataSource, ICollection)
            If list Is Nothing Then
                OwnerForm.ShowInfo(Nothing)
            Else
                OwnerForm.ShowInfo(list.Count)
            End If
        End Sub
        Friend Overridable Sub HideModule()
        End Sub
        Friend Overridable Sub InitModule(ByVal manager As IDXMenuManager, ByVal data As Object)
            SetMenuManager(Me.Controls, manager)
            If Grid IsNot Nothing AndAlso TypeOf Grid.MainView Is ColumnView Then
                AddHandler CType(Grid.MainView, ColumnView).ColumnFilterChanged, AddressOf BaseModule_ColumnFilterChanged
            End If
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
                Dim grid_Field As GridControl = TryCast(ctrl, GridControl)
                If grid_Field IsNot Nothing Then
                    grid_Field.MenuManager = manager
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
        Protected Friend Overridable Sub MessagesDataChanged(ByVal args As DataSourceChangedEventArgs)
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
                Return partName_Field
            End Get
        End Property
    End Class
    Public Class NavBarGroupTagObject
        Private name_Field As String
        Private moduleType_Field As Type
        Private module_Field As BaseModule
        Public Sub New(ByVal name As String, ByVal moduleType As Type)
            Me.name_Field = name
            Me.moduleType_Field = moduleType
            module_Field = Nothing
        End Sub
        Public ReadOnly Property Name() As String
            Get
                Return name_Field
            End Get
        End Property
        Public ReadOnly Property ModuleType() As Type
            Get
                Return moduleType_Field
            End Get
        End Property
        Public Property [Module]() As BaseModule
            Get
                Return module_Field
            End Get
            Set(ByVal value As BaseModule)
                module_Field = value
            End Set
        End Property
    End Class
    Public Class BackstageViewLabel
        Inherits LabelControl

        Public Sub New()
            Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold)
            AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
            LineVisible = True
            ShowLineShadow = False
        End Sub
    End Class
    Public Class ZoomManager
        Private zoomControl_Field As ZoomTrackBarControl
        Private zoomFactor_Field As Integer = 0
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
                Return zoomControl_Field
            End Get
        End Property
        Public Property ZoomFactor() As Integer
            Get
                Return zoomFactor_Field
            End Get
            Set(ByVal value As Integer)
                zoomFactor_Field = value
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
            Me.zoomControl_Field = TryCast(ribbon.Manager.ActiveEditor, ZoomTrackBarControl)
            If ZoomControl IsNot Nothing Then
                AddHandler ZoomControl.ValueChanged, AddressOf OnZoomTackValueChanged
                OnZoomTackValueChanged(ZoomControl, EventArgs.Empty)
            End If
        End Sub
        Private Sub beiZoom_HiddenEditor(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            RemoveHandler ZoomControl.ValueChanged, AddressOf OnZoomTackValueChanged
            Me.zoomControl_Field = Nothing
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
        Private editObject_Field As Object
        Public ReadOnly Property EditObject() As Object
            Get
                Return editObject_Field
            End Get
        End Property
        Public Sub New(ByVal parent As Control)
            Me.parent = parent
            AddHandler parent.Disposed, Sub() Dispose()
            Me.controller = New ToolTipController()
            Me.controller.ToolTipType = ToolTipType.SuperTip
            Me.controller.AllowHtmlText = True
            Me.controller.ReshowDelay = controller.InitialDelay
            Me.controller.AutoPopDelay = 10000
            AddHandler parent.MouseDown, Sub() HideHint(False)
            AddHandler parent.MouseLeave, Sub() HideHint(True)
        End Sub
        Public Sub ShowHint(ByVal editObject As Object, ByVal location As Point)
            If Object.Equals(editObject, Me.editObject_Field) Then
                Return
            End If
            Me.editObject_Field = editObject
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
                Me.editObject_Field = Nothing
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

            Return New Rectangle(r.Left + CInt((r.Width - img.Width * zoomRatio)) \ 2, r.Top + CInt((r.Height - img.Height * zoomRatio)) \ 2, CInt((img.Width * zoomRatio)), CInt((img.Height * zoomRatio)))
        End Function
    End Class
End Namespace
