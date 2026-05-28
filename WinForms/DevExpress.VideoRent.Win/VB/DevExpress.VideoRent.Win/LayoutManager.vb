Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Xpo
Imports System.IO
Imports DevExpress.Data.Filtering
Imports System.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Docking
Imports DevExpress.VideoRent.Win.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraNavBar
Imports DevExpress.VideoRent.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Serializing
Imports DevExpress.Utils

Namespace DevExpress.VideoRent.Win
	Public Class WinFormLayout
		Inherits VideoRentBaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As Session, ByVal name As String)
			Me.New(session)
			Me.Name = name
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			MainView = True
		End Sub
		Public Property Name() As String
			Get
				Return GetPropertyValue(Of String)("Name")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Name", value)
			End Set
		End Property
		<DevExpress.Xpo.ValueConverter(GetType(RectangleValueConverter))> _
		Public Property FormBounds() As Rectangle
			Get
				Return GetPropertyValue(Of Rectangle)("FormBounds")
			End Get
			Set(ByVal value As Rectangle)
				SetPropertyValue(Of Rectangle)("FormBounds", value)
			End Set
		End Property
		Public Property WindowState() As FormWindowState
			Get
				Return GetPropertyValue(Of FormWindowState)("WindowState")
			End Get
			Set(ByVal value As FormWindowState)
				SetPropertyValue(Of FormWindowState)("WindowState", value)
			End Set
		End Property
		<DevExpress.Xpo.ValueConverter(GetType(MemoryStreamValueConverter))> _
		Public Property MainLayoutControlLayout() As MemoryStream
			Get
				Return GetPropertyValue(Of MemoryStream)("MainLayoutControlLayout")
			End Get
			Set(ByVal value As MemoryStream)
				SetPropertyValue(Of MemoryStream)("MainLayoutControlLayout", value)
			End Set
		End Property
		<DevExpress.Xpo.ValueConverter(GetType(MemoryStreamValueConverter))> _
		Public Property MainColumnViewLayout() As MemoryStream
			Get
				Return GetPropertyValue(Of MemoryStream)("MainColumnViewLayout")
			End Get
			Set(ByVal value As MemoryStream)
				SetPropertyValue(Of MemoryStream)("MainColumnViewLayout", value)
			End Set
		End Property
		<DevExpress.Xpo.ValueConverter(GetType(MemoryStreamValueConverter))> _
		Public Property AlternateColumnViewLayout() As MemoryStream
			Get
				Return GetPropertyValue(Of MemoryStream)("AlternateColumnViewLayout")
			End Get
			Set(ByVal value As MemoryStream)
				SetPropertyValue(Of MemoryStream)("AlternateColumnViewLayout", value)
			End Set
		End Property
		<DevExpress.Xpo.ValueConverter(GetType(MemoryStreamValueConverter))> _
		Public Property MainDockingLayout() As MemoryStream
			Get
				Return GetPropertyValue(Of MemoryStream)("MainDockingLayout")
			End Get
			Set(ByVal value As MemoryStream)
				SetPropertyValue(Of MemoryStream)("MainDockingLayout", value)
			End Set
		End Property
		<DevExpress.Xpo.ValueConverter(GetType(MemoryStreamValueConverter))> _
		Public Property QuickAccessToolbar() As MemoryStream
			Get
				Return GetPropertyValue(Of MemoryStream)("QuickAccessToolbar")
			End Get
			Set(ByVal value As MemoryStream)
				SetPropertyValue(Of MemoryStream)("QuickAccessToolbar", value)
			End Set
		End Property
		Public Property MainView() As Boolean
			Get
				Return GetPropertyValue(Of Boolean)("MainView")
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("MainView", value)
			End Set
		End Property
	End Class
	Public Class WinFormProperty
		Inherits VideoRentBaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			AllowRestoreFormLayout = True
			AllowRestoreLayoutControlLayout = True
			AllowRestoreGridViewLayout = True
			AllowRestoreDockingLayout = True
			DefaultEditGridViewInDetailForms = True
			NavPaneState = NavPaneState.Expanded
		End Sub
		Public Property AllowRestoreFormLayout() As Boolean
			Get
				Return GetPropertyValue(Of Boolean)("AllowRestoreFormLayout")
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("AllowRestoreFormLayout", value)
			End Set
		End Property
		Public Property AllowRestoreLayoutControlLayout() As Boolean
			Get
				Return GetPropertyValue(Of Boolean)("AllowRestoreLayoutControlLayout")
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("AllowRestoreLayoutControlLayout", value)
			End Set
		End Property
		Public Property AllowRestoreGridViewLayout() As Boolean
			Get
				Return GetPropertyValue(Of Boolean)("AllowRestoreGridViewLayout")
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("AllowRestoreGridViewLayout", value)
			End Set
		End Property
		Public Property AllowRestoreDockingLayout() As Boolean
			Get
				Return GetPropertyValue(Of Boolean)("AllowRestoreDockingLayout")
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("AllowRestoreDockingLayout", value)
			End Set
		End Property
		Public Property DefaultEditGridViewInDetailForms() As Boolean
			Get
				Return GetPropertyValue(Of Boolean)("DefaultEditGridViewInDetailForms")
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("DefaultEditGridViewInDetailForms", value)
			End Set
		End Property
		Public Property DefaultSkinName() As String
			Get
				Return GetPropertyValue(Of String)("DefaultSkinName")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("DefaultSkinName", value)
			End Set
		End Property
		Public Property ChartPaletteAppearance() As String
			Get
				Return GetPropertyValue(Of String)("ChartPaletteAppearance")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ChartPaletteAppearance", value)
			End Set
		End Property
		<Size(SizeAttribute.Unlimited)> _
		Public Property ImagePath() As String
			Get
				Return GetPropertyValue(Of String)("ImagePath")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ImagePath", value)
			End Set
		End Property
		Public Property CurrentCustomerId() As Guid
			Get
				Return GetPropertyValue(Of Guid)("CurrentCustomerId")
			End Get
			Set(ByVal value As Guid)
				SetPropertyValue(Of Guid)("CurrentCustomerId", value)
			End Set
		End Property
		Public Property NavPaneState() As NavPaneState
			Get
				Return GetPropertyValue(Of NavPaneState)("NavPaneState")
			End Get
			Set(ByVal value As NavPaneState)
				SetPropertyValue(Of NavPaneState)("NavPaneState", value)
			End Set
		End Property
	End Class
	Public Delegate Sub SetCustomerInfoDelegate(ByVal caption As String)
	Public Class FormLayoutInfo
        Private fname As String
        Private fform As Form
        Private flayoutControl As LayoutControl
        Private view As ColumnView
        Private fdockManager As DockManager
        Private alternateView As ColumnView
        Private toolbar As RibbonQuickAccessToolbar
        Public Sub New(ByVal form As Form)
            Me.New(form, Nothing)
        End Sub
        Public Sub New(ByVal form As Form, ByVal layoutControl As LayoutControl, ByVal toolbar As RibbonQuickAccessToolbar)
            Me.New(String.Empty, form, layoutControl, Nothing, Nothing, Nothing, toolbar)
        End Sub
        Public Sub New(ByVal name As String, ByVal view As ColumnView)
            Me.New(name, Nothing, Nothing, view, Nothing)
        End Sub
        Public Sub New(ByVal name As String, ByVal layoutControl As LayoutControl)
            Me.New(name, Nothing, layoutControl, Nothing, Nothing)
        End Sub
        Public Sub New(ByVal name As String, ByVal view As ColumnView, ByVal dockManager As DockManager)
            Me.New(name, Nothing, Nothing, view, dockManager)
        End Sub
        Public Sub New(ByVal form As Form, ByVal layoutControl As LayoutControl)
            Me.New(String.Empty, form, layoutControl, Nothing, Nothing)
        End Sub
        Public Sub New(ByVal name As String, ByVal form As Form, ByVal layoutControl As LayoutControl, ByVal view As ColumnView, ByVal dockManager As DockManager)
            Me.New(name, form, layoutControl, view, Nothing, dockManager, Nothing)
        End Sub
        Public Sub New(ByVal name As String, ByVal form As Form, ByVal layoutControl As LayoutControl, ByVal view As ColumnView, ByVal alternateView As ColumnView, ByVal dockManager As DockManager, ByVal toolbar As RibbonQuickAccessToolbar)
            Me.fname = name
            Me.fform = form
            Me.flayoutControl = layoutControl
            Me.view = view
            Me.alternateView = alternateView
            Me.fdockManager = dockManager
            Me.toolbar = toolbar
        End Sub
        Public ReadOnly Property Name() As String
            Get
                If (Not String.IsNullOrEmpty(fname)) Then
                    Return fname
                End If
                If (Not Object.Equals(fform, Nothing)) Then
                    Return fform.Name
                End If
                Return String.Empty
            End Get
        End Property
        Public ReadOnly Property Form() As Form
            Get
                Return fform
            End Get
        End Property
        Public ReadOnly Property LayoutControl() As LayoutControl
            Get
                Return flayoutControl
            End Get
        End Property
        Public ReadOnly Property ColumnView() As ColumnView
            Get
                Return view
            End Get
        End Property
        Public ReadOnly Property AlternateColumnView() As ColumnView
            Get
                Return alternateView
            End Get
        End Property
        Public ReadOnly Property DockManager() As DockManager
            Get
                Return fdockManager
            End Get
        End Property
        Public ReadOnly Property QuickAccessToolbar() As RibbonQuickAccessToolbar
            Get
                Return toolbar
            End Get
        End Property
        Public ReadOnly Property ShowMainView() As Boolean
            Get
                Return (Not Object.Equals(ColumnView, Nothing)) AndAlso ColumnView.GridControl.MainView Is ColumnView
            End Get
        End Property
    End Class
    Public Interface IFormWithLayoutManager
        ReadOnly Property LayoutManager() As FormLayoutManager
    End Interface
    Public Class FormLayoutManager
        Private fsession As UnitOfWork
        Private dataSession As UnitOfWork
        Private fproperties As WinFormProperties
        Private setCustomerInfo As SetCustomerInfoDelegate
        Private fcurrentCustomer As Customer
        Public Event CurrentCustomerChanged As EventHandler
        Public Sub New(ByVal session As Session, ByVal setInfo As SetCustomerInfoDelegate, ByVal dataSession As UnitOfWork)
            Me.fsession = New UnitOfWork(session.DataLayer)
            fproperties = New WinFormProperties(Me.fsession)
            Me.setCustomerInfo = setInfo
            Me.dataSession = dataSession
            SetCustomerExample()
        End Sub
        Private Sub RaiseCurrentCustomerChanged()
            If (Not Object.Equals(CurrentCustomerChangedEvent, Nothing)) Then
                RaiseEvent CurrentCustomerChanged(CurrentCustomer, EventArgs.Empty)
            End If
        End Sub
        Public Function GetCustomer(ByVal customer As Customer) As Customer
            Return SessionHelper.GetObject(customer, dataSession)
        End Function
        Public Property CurrentCustomer() As Customer
            Get
                Return fcurrentCustomer
            End Get
            Set(ByVal value As Customer)
                If Object.Equals(fcurrentCustomer, value) Then
                    Return
                End If
                fcurrentCustomer = value
                SetCustomerExample()
                If Object.Equals(fcurrentCustomer, Nothing) Then
                    setCustomerInfo(String.Format(ConstStrings.CurrentCustomer, ConstStrings.Nothing))
                Else
                    setCustomerInfo(String.Format(ConstStrings.CurrentCustomer, fcurrentCustomer.FullName))
                End If
                RaiseCurrentCustomerChanged()
            End Set
        End Property
        Public ReadOnly Property CurrentCustomerId() As Guid
            Get
                If Object.Equals(CurrentCustomer, Nothing) Then
                    Return Guid.Empty
                End If
                Return CurrentCustomer.Oid
            End Get
        End Property
        Public ReadOnly Property Session() As UnitOfWork
            Get
                Return fsession
            End Get
        End Property
        Public ReadOnly Property Properties() As WinFormProperties
            Get
                Return fproperties
            End Get
        End Property

        Public Shared Function SaveControlLayout(ByVal control As ISupportXtraSerializer) As MemoryStream
            If Object.Equals(control, Nothing) Then
                Return Nothing
            End If
            Dim stream As MemoryStream = New System.IO.MemoryStream()
            control.SaveLayoutToStream(stream)
            Return stream
        End Function
        Public Shared Sub RestoreControlLayout(ByVal layout As MemoryStream, ByVal control As ISupportXtraSerializer)
            If Object.Equals(layout, Nothing) OrElse Object.Equals(layout, MemoryStream.Null) OrElse Object.Equals(control, Nothing) Then
                Return
            End If
            layout.Seek(0, SeekOrigin.Begin)
            control.RestoreLayoutFromStream(layout)
        End Sub
        Public Sub SaveFormLayout(ByVal info As FormLayoutInfo)
            Dim layout As WinFormLayout = Session.FindObject(Of WinFormLayout)(CriteriaOperator.Parse("Name = ? and CreatedBy = ?", info.Name, VideoRentCurrentUser.GetCurrentUser(Session)))
            If Object.Equals(layout, Nothing) Then
                layout = New WinFormLayout(Session, info.Name)
            End If
            If (Not Object.Equals(info.Form, Nothing)) Then
                layout.WindowState = info.Form.WindowState
                If info.Form.WindowState = FormWindowState.Maximized Then
                    layout.FormBounds = info.Form.RestoreBounds
                Else
                    layout.FormBounds = info.Form.Bounds
                End If
            End If
            layout.MainLayoutControlLayout = SaveControlLayout(info.LayoutControl)
            layout.MainColumnViewLayout = SaveControlLayout(info.ColumnView)
            layout.AlternateColumnViewLayout = SaveControlLayout(info.AlternateColumnView)
            layout.MainDockingLayout = SaveControlLayout(info.DockManager)
            layout.QuickAccessToolbar = SaveControlLayout(info.QuickAccessToolbar)
            layout.MainView = info.ShowMainView
            SessionHelper.CommitSession(Session, New ExceptionsProcesser(Nothing))
        End Sub
        Public Sub RestoreFormLayout(ByVal info As FormLayoutInfo)
            Dim layout As WinFormLayout = Session.FindObject(Of WinFormLayout)(CriteriaOperator.Parse("Name = ? and CreatedBy = ?", info.Name, VideoRentCurrentUser.GetCurrentUser(Session)))
            If Object.Equals(layout, Nothing) Then
                Return
            End If
            If Properties.CurrentProperty.AllowRestoreLayoutControlLayout Then
                RestoreControlLayout(layout.MainLayoutControlLayout, info.LayoutControl)
            End If
            If Properties.CurrentProperty.AllowRestoreGridViewLayout Then
                RestoreControlLayout(layout.MainColumnViewLayout, info.ColumnView)
                RestoreControlLayout(layout.AlternateColumnViewLayout, info.AlternateColumnView)
            End If
            If Properties.CurrentProperty.AllowRestoreDockingLayout Then
                RestoreControlLayout(layout.MainDockingLayout, info.DockManager)
            End If
            RestoreControlLayout(layout.QuickAccessToolbar, info.QuickAccessToolbar)
            If (Not Object.Equals(info.ColumnView, Nothing)) AndAlso ((Not Object.Equals(info.AlternateColumnView, Nothing))) AndAlso (Not layout.MainView) Then
                info.ColumnView.GridControl.MainView = info.AlternateColumnView
            End If
            If (Not layout.FormBounds.IsEmpty) AndAlso ((Not Object.Equals(info.Form, Nothing))) AndAlso Properties.CurrentProperty.AllowRestoreFormLayout Then
                info.Form.Size = layout.FormBounds.Size
                info.Form.Location = ControlUtils.CalcFormLocation(layout.FormBounds.Location, layout.FormBounds.Size)
                info.Form.WindowState = layout.WindowState
            End If
        End Sub

        Friend Sub ClearLayouts()
            Cursor.Current = Cursors.WaitCursor
            Dim xpLayouts As New XPCollection(Of WinFormLayout)(Session, CriteriaOperator.Parse("CreatedBy = ?", VideoRentCurrentUser.GetCurrentUser(Session)))
            For Each layout As WinFormLayout In xpLayouts
                layout.FormBounds = Rectangle.Empty
                layout.MainLayoutControlLayout = Nothing
                layout.MainColumnViewLayout = Nothing
                layout.AlternateColumnViewLayout = Nothing
                layout.MainDockingLayout = Nothing
                layout.MainView = True
            Next layout
            SessionHelper.CommitSession(Session, New ExceptionsProcesser(Nothing))
        End Sub
        Public Sub ShowOpenImageDialog(ByVal imageDelegate As DevExpress.VideoRent.Win.Forms.frmOpenImageDialog.SetImageDelegate, ByVal parent As Form)
            Using form As New frmOpenImageDialog(imageDelegate, Me)
                form.CurrentPath = Properties.ImagePath
                form.ShowDialog(parent)
                Properties.ImagePath = form.CurrentPath
            End Using
        End Sub
        Friend Sub SetDefaultCurrentCustomer(ByVal session As UnitOfWork)
            CurrentCustomer = session.GetObjectByKey(Of Customer)(Properties.CurrentProperty.CurrentCustomerId)
        End Sub
        Private Sub SetCustomerExample()
            If Object.Equals(CurrentCustomer, Nothing) Then
                CurrentCustomer = dataSession.FindObject(Of Customer)(CriteriaOperator.Parse("[FirstName] = 'Essie'"))
            End If
            If Object.Equals(CurrentCustomer, Nothing) Then
                CurrentCustomer = dataSession.FindObject(Of Customer)(CriteriaOperator.Parse(String.Format("[Oid] != {0}", Guid.Empty)))
            End If
        End Sub
        Public Sub ShowFindCustomerForm(ByVal parent As Form, ByVal menuManager As IDXMenuManager)
            ShowFindCustomerForm(parent, menuManager, (Not Object.Equals(CurrentCustomer, Nothing)))
        End Sub
        Public Sub ShowFindCustomerForm(ByVal parent As Form, ByVal menuManager As IDXMenuManager, ByVal showClear As Boolean)
            Cursor.Current = Cursors.WaitCursor
            Using form As New frmFindCustomer(Me, menuManager, dataSession, showClear)
                ObjectHelper.SetFormContainerSize(form, (CType(parent, frmMain)).ChildContainer)
                ObjectHelper.ShowFormDialog(form, parent)
            End Using
        End Sub
        Private Function MoveCustomer(ByVal prev As Boolean) As Boolean
            Dim customers As New XPCollection(Of Customer)(dataSession, Nothing, New SortProperty("CustomerId", DevExpress.Xpo.DB.SortingDirection.Ascending))
            Dim index As Integer = customers.IndexOf(CurrentCustomer)
            If index = -1 Then
                Return False
            End If
            If prev Then
                index -= 1
                index = index
            Else
                index += 1
                index = index
            End If
            If index > customers.Count - 1 Then
                index = 0
            End If
            If index < 0 Then
                index = customers.Count - 1
            End If
            CurrentCustomer = customers(index)
            Return True
        End Function
        Friend Sub NextCustomer()
            MoveCustomer(False)
        End Sub
        Friend Sub PrevCustomer()
            MoveCustomer(True)
        End Sub
        Friend ReadOnly Property AllowPrevCustomer() As Boolean
            Get
                Return New XPCollection(Of Customer)(dataSession).Count > 0
            End Get
        End Property
        Friend ReadOnly Property AllowNextCustomer() As Boolean
            Get
                Return AllowPrevCustomer
            End Get
        End Property
    End Class
    Public Class WinFormProperties
        Private fsession As UnitOfWork
        Public Sub New(ByVal session As UnitOfWork)
            Me.fsession = session
        End Sub
        Public ReadOnly Property Session() As UnitOfWork
            Get
                Return fsession
            End Get
        End Property
        Public ReadOnly Property CurrentProperty() As WinFormProperty
            Get
                Dim wfProperty As WinFormProperty = Session.FindObject(Of WinFormProperty)(CriteriaOperator.Parse("CreatedBy = ?", VideoRentCurrentUser.GetCurrentUser(Session)))
                If Object.Equals(wfProperty, Nothing) Then
                    wfProperty = New WinFormProperty(Session)
                    Save()
                End If
                Return wfProperty
            End Get
        End Property
        Public Sub Save()
            SessionHelper.CommitSession(Session, New ExceptionsProcesser(Nothing))
        End Sub
        Public Sub LoadDefaultSkin()
            If Object.Equals(CurrentProperty.DefaultSkinName, Nothing) Then
                Return
            End If
            Dim lfName() As String = CurrentProperty.DefaultSkinName.Split("@"c)
            If lfName.Length < 2 Then
                Return
            End If
            Select Case lfName(0)
                Case "WindowsXP"
                    UserLookAndFeel.Default.SetWindowsXPStyle()
                Case "Office2003"
                    UserLookAndFeel.Default.SetOffice2003Style()
                Case "Flat"
                    UserLookAndFeel.Default.SetFlatStyle()
                Case "Style3D"
                    UserLookAndFeel.Default.SetStyle3D()
                Case "UltraFlat"
                    UserLookAndFeel.Default.SetUltraFlatStyle()
                Case Else
                    UserLookAndFeel.Default.SetSkinStyle(lfName(1))
            End Select
        End Sub
        Public Sub LoadChartPaletteAppearance(ByVal chartManager As ChartAppearanceManager)
            If Object.Equals(CurrentProperty.ChartPaletteAppearance, Nothing) Then
                CurrentProperty.ChartPaletteAppearance = "Solstice@Default@0"
            End If
            Dim styles() As String = CurrentProperty.ChartPaletteAppearance.Split("@"c)
            If styles.Length < 3 Then
                Return
            End If
            chartManager.AppearanceName = styles(1)
            chartManager.ColorIndex = Convert.ToInt32(styles(2))
            chartManager.PaletteName = styles(0)
            chartManager.UpdateCurrentPalette()
            chartManager.UpdateCurrentAppearance()
        End Sub
        Private Sub SaveDefaultSkin()
            CurrentProperty.DefaultSkinName = String.Format("{0}@{1}", UserLookAndFeel.Default.ActiveStyle, UserLookAndFeel.Default.ActiveSkinName)
        End Sub
        Private Sub SaveChartAppearences(ByVal chartManager As ChartAppearanceManager)
            CurrentProperty.ChartPaletteAppearance = String.Format("{0}@{1}@{2}", chartManager.PaletteName, chartManager.AppearanceName, chartManager.ColorIndex)
        End Sub
        Public Property ImagePath() As String
            Get
                Return CurrentProperty.ImagePath
            End Get
            Set(ByVal value As String)
                If CurrentProperty.ImagePath = value Then
                    Return
                End If
                CurrentProperty.ImagePath = value
                Save()
            End Set
        End Property
        Private Sub SaveCurrentCustomer(ByVal manager As FormLayoutManager)
            If Object.Equals(manager.CurrentCustomer, Nothing) Then
                CurrentProperty.CurrentCustomerId = Guid.Empty
            Else
                CurrentProperty.CurrentCustomerId = manager.CurrentCustomer.Oid
            End If
        End Sub
        Private Sub SaveNavPaneState(ByVal state As NavPaneState)
            CurrentProperty.NavPaneState = state
        End Sub

        Public Sub SaveDefaultProperties(ByVal manager As FormLayoutManager, ByVal state As NavPaneState, ByVal chartManager As ChartAppearanceManager)
            SaveDefaultSkin()
            SaveCurrentCustomer(manager)
            SaveNavPaneState(state)
            SaveChartAppearences(chartManager)
            Save()
        End Sub
    End Class
    Public Enum PeriodType
        All
        Receipt
        KPI
    End Enum
    Public Class PeriodManager
        Private Shared freceiptPeriod, fkpiPeriod As Period

        Public Shared ReadOnly Property ReceiptPeriod() As Period
            Get
                If Object.Equals(freceiptPeriod, Nothing) Then
                    freceiptPeriod = New Period(-12)
                End If
                Return freceiptPeriod
            End Get
        End Property
        Public Shared ReadOnly Property KPIPeriod() As Period
            Get
                If Object.Equals(fkpiPeriod, Nothing) Then
                    fkpiPeriod = New Period(-24)
                End If
                Return fkpiPeriod
            End Get
        End Property
    End Class
    Public Class Period
        Private fstartDate As DateTime
        Private fendDate As DateTime
        Public Sub New(ByVal months As Integer)
            SetStartDate(DateTime.Today.AddMonths(months))
            SetEndDate(DateTime.Now)
        End Sub
        Private Sub SetStartDate(ByVal [date] As DateTime)
            fstartDate = New DateTime([date].Year, [date].Month, [date].Day, 0, 0, 0)
        End Sub
        Private Sub SetEndDate(ByVal [date] As DateTime)
            If [date] < fstartDate Then
                [date] = fstartDate
            End If
            fendDate = New DateTime([date].Year, [date].Month, [date].Day, 23, 59, 59)
        End Sub
        Public Property StartDate() As DateTime
            Get
                Return fstartDate
            End Get
            Set(ByVal value As DateTime)
                SetStartDate(value)
            End Set
        End Property
        Public Property EndDate() As DateTime
            Get
                Return fendDate
            End Get
            Set(ByVal value As DateTime)
                SetEndDate(value)
            End Set
        End Property
    End Class
End Namespace
