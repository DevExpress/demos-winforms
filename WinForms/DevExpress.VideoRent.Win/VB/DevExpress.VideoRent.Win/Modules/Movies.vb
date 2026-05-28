Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.VideoRent.Win.Forms
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Xpo
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Localization

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Movies
		Inherits GridExportTutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub
		Protected Overrides Sub RefreshGridDataSource()
			Dim current As VideoRentBaseObject = CurrentEditObject
			gridControl1.DataSource = New XPCollection(Of Movie)(Session, Nothing, New DevExpress.Xpo.SortProperty("[Title]", DevExpress.Xpo.DB.SortingDirection.Ascending))
			WinHelper.GridViewFocusObject(MainView, current)
            InitScreens()
		End Sub
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			RefreshGridDataSource()
		End Sub
		Protected Overrides ReadOnly Property CurrentView() As ColumnView
			Get
				Return TryCast(gridControl1.MainView, ColumnView)
			End Get
		End Property
		Public Overrides ReadOnly Property EditObjectName() As String
			Get
				Return ConstStrings.Movie
			End Get
		End Property
		Public Overrides ReadOnly Property EditObjectsName() As String
			Get
				Return ConstStrings.Movies
			End Get
		End Property
		Protected Overrides ReadOnly Property MainView() As ColumnView
			Get
				Return advBandedGridView1
			End Get
		End Property
		Protected Overrides ReadOnly Property AlternateView() As ColumnView
			Get
				Return layoutView1
			End Get
		End Property
		Protected Overrides ReadOnly Property MainDockManager() As DockManager
			Get
				Return dockManager1
			End Get
		End Property
		Protected Overrides ReadOnly Property CurrentEditObject() As VideoRentBaseObject
			Get
				Return CurrentMovie
			End Get
		End Property
		Protected Overrides ReadOnly Property Landscape() As Boolean
			Get
				Return Object.Equals(CurrentView, MainView)
			End Get
		End Property
		Private ReadOnly Property CurrentMovie() As Movie
			Get
				If Object.Equals(CurrentView, Nothing) Then
					Return Nothing
				End If
				If CurrentView.FocusedRowHandle < 0 Then
					Return Nothing
				End If
				Return TryCast(CurrentView.GetRow(CurrentView.FocusedRowHandle), Movie)
			End Get
		End Property
		Protected Overrides Function AllowEdit(ByVal info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo) As Boolean
			Return IsButtonColumn(info.Column)
		End Function
		Private Sub gridControl1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridControl1.KeyDown
			If e.KeyCode = Keys.Enter Then
				EditMovie()
			End If
		End Sub
		Protected Overrides Sub InitData()
			MyBase.InitData()
			riccbGenre.SetFlags(GetType(MovieGenre))
			colLanguage.ColumnEdit = EditorHelper.CreateLanguageLookUpEdit(Session, gridControl1.RepositoryItems, True)
			colRating.ColumnEdit = EditorHelper.CreateRatingImageComboBox(gridControl1.RepositoryItems)
			ucScreens1.InitParent(dpScreens)
			InitScreens()
			Dim TempGridViewImageTextToolTipController As GridViewImageTextToolTipController = New GridViewImageTextToolTipController(advBandedGridView1, "PhotoExist", "Info", True, 120)
		End Sub
		Protected Overrides Sub CloseDetailForm(ByVal result As DialogResult, ByVal currentObject As Object)
			MyBase.CloseDetailForm(result, currentObject)
			If result <> DialogResult.Cancel Then
				RefreshData()
			End If
		End Sub
		Protected Overrides Sub CloseDetailFormAndReload(ByVal result As DialogResult, ByVal currentObject As Object)
			MyBase.CloseDetailFormAndReload(result, currentObject)
            If Object.Equals(result, DialogResult.Cancel) Then
                Return
            End If
			RefreshData()
			WinHelper.GridViewFocusObject(CurrentView, TryCast(currentObject, VideoRentBaseObject))
		End Sub
		Private Sub EditMovie()
			If (Not IsDetailExist(CurrentMovie.Oid)) Then
				ShowModuleDialog(New MovieDetail(Me.FindForm(), Session, CurrentMovie, MenuManager, AddressOf CloseDetailForm))
			End If
		End Sub
		Private Sub AddMovie()
			If (Not IsDetailExist(Guid.Empty)) Then
				ShowModuleDialog(New MovieDetail(Me.FindForm(), Session, Nothing, MenuManager, AddressOf CloseDetailFormAndReload))
			End If
		End Sub
		Public Overrides Sub Add()
			MyBase.Add()
			AddMovie()
		End Sub
		Public Overrides Sub Edit()
			MyBase.Edit()
			EditMovie()
		End Sub
		Protected Friend Overrides Function Delete() As Boolean
			Dim ret As Boolean = MyBase.Delete()
			InitScreens()
			Return ret
		End Function
        Private fdownRowHandle As Integer = -1
        Private fhotRowHandle As Integer = -1
        Private Property DownRowHandle() As Integer
            Get
                Return fdownRowHandle
            End Get
            Set(ByVal value As Integer)
                If fdownRowHandle = value Then
                    Return
                End If
                MainView.Invalidate()
                fdownRowHandle = value
            End Set
        End Property
        Private Property HotRowHandle() As Integer
            Get
                Return fhotRowHandle
            End Get
            Set(ByVal value As Integer)
                If fhotRowHandle = value Then
                    Return
                End If
                MainView.Invalidate()
                fhotRowHandle = value
            End Set
        End Property
		Private Function IsButtonColumn(ByVal column As GridColumn) As Boolean
			If Object.Equals(column, Nothing) Then
				Return False
			End If
			Return "WebSite".Equals(column.FieldName)
		End Function
		Private Sub advBandedGridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawCell
			If IsButtonColumn(e.Column) Then
				If e.DisplayText <> String.Empty Then
					Dim rect As Rectangle = e.Bounds
					e.Appearance.ForeColor = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default, SystemColors.ControlText)
					e.Appearance.BackColor = SystemColors.Control
					Dim obj As New StyleObjectInfoArgs(e.Cache, rect, e.Appearance)
                    If Object.Equals(DownRowHandle, e.RowHandle) Then
                        obj.State = ObjectState.Pressed
                    End If
					If rect.Contains(gridControl1.PointToClient(New Point(MousePosition.X, MousePosition.Y))) AndAlso (Not Object.Equals(obj.State, ObjectState.Pressed)) Then
						obj.State = ObjectState.Hot
					End If
					UserLookAndFeel.Default.Painter.Button.DrawObject(obj)
					rect.Inflate(-4, 0)
					UserLookAndFeel.Default.Painter.Button.DrawCaption(obj, ConstStrings.LookupDetails, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), rect, e.Appearance.GetStringFormat())
					e.Handled = True
				End If
			End If
		End Sub
		Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridControl1.MouseDown
			Dim info As BandedGridHitInfo = advBandedGridView1.CalcHitInfo(New Point(e.X, e.Y))
			If info.InRow AndAlso IsButtonColumn(info.Column) Then
				DownRowHandle = info.RowHandle
			Else
				DownRowHandle = -1
			End If
		End Sub
		Private Sub gridControl1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridControl1.MouseUp
			If DownRowHandle <> -1 AndAlso Object.Equals(DownRowHandle, HotRowHandle) Then
				LinkButtonClick(TryCast(MainView.GetRow(DownRowHandle), Movie))
			End If
			DownRowHandle = -1
		End Sub
		Private Sub gridControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridControl1.MouseMove
			Dim info As BandedGridHitInfo = advBandedGridView1.CalcHitInfo(New Point(e.X, e.Y))
			If info.InRow AndAlso IsButtonColumn(info.Column) Then
				HotRowHandle = info.RowHandle
			Else
				HotRowHandle = -1
			End If
		End Sub
		Private Sub LinkButtonClick(ByVal movie As Movie)
			ObjectHelper.ShowWebSite(movie.WebSite)
		End Sub
		Protected Overrides Sub DoFocusedRowChanged()
			MyBase.DoFocusedRowChanged()
			InitScreens()
		End Sub
		Private Sub InitScreens()
			If Object.Equals(CurrentMovie, Nothing) OrElse CurrentView.FocusedRowHandle < 0 Then
				ucScreens1.InitData(Nothing, Nothing, FindForm())
			Else
				ucScreens1.InitData(CurrentMovie.Pictures, CurrentMovie, FindForm())
			End If
		End Sub
		Protected Overrides Sub LoadFormLayout()
			MyBase.LoadFormLayout()
			InitScreens()
		End Sub
		Private Function GetCardFilterValue(ByVal filter As String) As String
			Dim start As Integer = filter.IndexOf("%")
            If Start = -1 Then
                Return String.Empty
            End If
            Dim [end] As Integer = filter.IndexOf("%", Start + 1)
            If [end] = -1 Then
                Return String.Empty
            End If
            Return filter.Substring(Start + 1, [end] - Start - 1)
        End Function
        Protected Friend Overrides Sub ViewStylesPopup(ByVal sender As Object)
            MyBase.ViewStylesPopup(sender)
            ParentFormMain.MainViewButton.Caption = ConstStrings.Grid
            ParentFormMain.AlternateViewButton.Caption = ConstStrings.Cards
        End Sub
        Protected Friend Overrides Sub DoViewChange(ByVal mainView As Boolean)
            Dim currentObject As VideoRentBaseObject = CurrentMovie
            If mainView Then
                gridControl1.MainView = Me.MainView
            Else
                gridControl1.MainView = AlternateView
            End If
            WinHelper.GridViewFocusObject(CurrentView, currentObject)
        End Sub
        Protected Friend Overrides Sub ShowMovieCategories()
            Using form As New frmMovieCategoriesList(Me.FindForm(), Session, Me.MenuManager)
                ObjectHelper.SetFormContainerSize(form, (CType(FindForm(), frmMain)).ChildContainer)
                ObjectHelper.ShowFormDialog(form, Me.FindForm())
            End Using
        End Sub
        Private Function GetCurrentKey(ByVal row As Object) As DevExpress.VideoRent.Movie
            Return TryCast(row, DevExpress.VideoRent.Movie)
        End Function
        Private Sub advBandedGridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs) Handles advBandedGridView1.CustomUnboundColumnData
            Dim key As DevExpress.VideoRent.Movie = GetCurrentKey(e.Row)
            If e.Column Is colInfo AndAlso e.IsGetData AndAlso (Not Object.Equals(key, Nothing)) Then
                e.Value = key.GetMovieInfoHtml()
            End If
        End Sub

        Private Sub advBandedGridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles advBandedGridView1.PopupMenuShowing
            ObjectHelper.RemoveCustomizationItemsFromColumnMenu(e)
        End Sub
    End Class
End Namespace
