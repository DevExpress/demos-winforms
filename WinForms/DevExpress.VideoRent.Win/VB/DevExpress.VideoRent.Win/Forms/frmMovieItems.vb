Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports DevExpress.Xpo

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmMovieItems
		Inherits XtraForm
		Private movie As Movie
		Private manager As IDXMenuManager
		Private session As UnitOfWork
		Private allSelectedItemsAllowDelete As Boolean = True

		Public Sub New(ByVal session As UnitOfWork, ByVal movie As Movie, ByVal manager As IDXMenuManager)
			MyBase.New()
			InitializeComponent()
			bbiAdd.Glyph = ElementHelper.BarImages.Images(1)
			bbiDelete.Glyph = ElementHelper.BarImages.Images(2)
			Me.session = session
			Me.movie = movie
			Me.manager = manager
			InitItemsGrid()
			InitData()
		End Sub
		Private Sub InitItemsGrid()
			colFormat.ColumnEdit = EditorHelper.CreateMovieItemFormatImageComboBox(gcMovieItems.RepositoryItems)
			colStatus.ColumnEdit = EditorHelper.CreateMovieItemStatusImageComboBox(gcMovieItems.RepositoryItems)
			colLocation.ColumnEdit = EditorHelper.CreateLocationComboBox(gcMovieItems.RepositoryItems)
			colSellingPrice.ColumnEdit = EditorHelper.CreateMovieItemPriceSpinEdit(movie.Session, gcMovieItems.RepositoryItems)
		End Sub
		Private Sub InitData()
			gcMovieItems.DataSource = movie.Items
			ucMovieInfo1.Init(movie)
		End Sub
		Private Sub bbiAddItems_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd.ItemClick
			Using form As New frmMovieAddItems(Me, session, movie, manager)
				form.ShowDialog()
				If form.DialogResult = System.Windows.Forms.DialogResult.OK Then
					If (Not Object.Equals(form.MovieItems, Nothing)) AndAlso form.MovieItems.Count <> 0 Then
						movie.Items.AddRange(form.MovieItems)
					End If
				End If
			End Using
		End Sub
		Private Sub gvMovieItems_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvMovieItems.CellValueChanging
			If e.Column Is colAvailableForSell Then
				gvMovieItems.HideEditor()
				Dim item As MovieItem = TryCast(gvMovieItems.GetRow(e.RowHandle), MovieItem)
				item.AvailableForSell = CBool(e.Value)
				gvMovieItems.UpdateCurrentRow()
			ElseIf e.Column Is colSellingPrice Then
				Dim item As MovieItem = TryCast(gvMovieItems.GetRow(e.RowHandle), MovieItem)
				Try
					item.SellingPrice = Convert.ToDecimal(e.Value)
				Catch
				End Try
			End If
		End Sub
		Private Function GetSelectedItems(ByVal unselectNotAllowDelete As Boolean) As List(Of MovieItem)
			Dim items As New List(Of MovieItem)()
			Dim [select]() As Integer = gvMovieItems.GetSelectedRows()
			For Each rowHandle As Integer In [select]
				If rowHandle < 0 Then
					gvMovieItems.UnselectRow(rowHandle)
					Continue For
				End If
				Dim item As MovieItem = CType(gvMovieItems.GetRow(rowHandle), MovieItem)
				If unselectNotAllowDelete AndAlso (Not item.AllowDelete) Then
					gvMovieItems.UnselectRow(rowHandle)
					Continue For
				End If
				items.Add(item)
			Next rowHandle
			Return items
		End Function
		Private Sub bbiDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDelete.ItemClick
			If (Not allSelectedItemsAllowDelete) AndAlso XtraMessageBox.Show(Me.FindForm(), ConstStrings.NotAllItemsCanBeDeleted, ConstStrings.Question, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then
					Return
			End If
			GetSelectedItems(True)
			gvMovieItems.DeleteSelectedRows()
		End Sub

		Private Sub gvMovieItems_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvMovieItems.CustomDrawCell
			If e.Column Is colMovieItemId AndAlso 0.Equals(e.CellValue) Then
				e.DisplayText = ConstStrings.NewRecordsIDString
			End If
			If e.Column Is colStatus AndAlso MovieItemStatus.Active.Equals(e.CellValue) Then
				e.Appearance.Font = ElementHelper.FontBold
			End If
		End Sub

		Private Sub gvMovieItems_EndGrouping(ByVal sender As Object, ByVal e As EventArgs) Handles gvMovieItems.EndGrouping
			gvMovieItems.ExpandAllGroups()
		End Sub

		Private Sub gvMovieItems_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gvMovieItems.PopupMenuShowing
			If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Summary AndAlso e.HitInfo.Column Is colMovieItemId Then
				e.Menu = Nothing
			End If
		End Sub
		Private Sub gvMovieItems_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles gvMovieItems.SelectionChanged
			Dim items As List(Of MovieItem) = GetSelectedItems(False)
			allSelectedItemsAllowDelete = True
			If items.Count = 1 Then
				bbiDelete.Enabled = items(0).AllowDelete
				Return
			End If
			Dim someItemsAllowDelete As Boolean = False
			For Each item As MovieItem In items
				If (Not item.AllowDelete) Then
					allSelectedItemsAllowDelete = False
					If someItemsAllowDelete Then
						Exit For
					End If
				Else
					someItemsAllowDelete = True
					If (Not allSelectedItemsAllowDelete) Then
						Exit For
					End If
				End If
			Next item
			bbiDelete.Enabled = someItemsAllowDelete
		End Sub

		Private Sub gvMovieItems_ShowingEditor(ByVal sender As Object, ByVal e As CancelEventArgs) Handles gvMovieItems.ShowingEditor
			Dim item As MovieItem = TryCast(gvMovieItems.GetRow(gvMovieItems.FocusedRowHandle), MovieItem)
			If (Not Object.Equals(item, Nothing)) AndAlso Object.Equals(item.Status, MovieItemStatus.Active) Then
				Return
			End If
			e.Cancel = True
		End Sub
	End Class
End Namespace
