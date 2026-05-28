Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils.Menu
Imports DevExpress.VideoRent.Win.Controls
Imports DevExpress.XtraLayout
Imports DevExpress.XtraGrid
Imports System.Collections
Imports DevExpress.Data.Filtering
Imports DevExpress.VideoRent.Helpers

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmMovieCategoriesList
		Inherits XtraForm
		Implements IFormWithLayoutManager
		Private _Parent As Form
		Private session As UnitOfWork
        Private fdirty As Boolean
        Private rowChangeDoOnce As Boolean = False
        Private fcategoryWasChanged As Boolean
        Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal manager As IDXMenuManager)
            MyBase.New()
            InitializeComponent()
            Me._Parent = parent
            Me.session = New UnitOfWork(session.DataLayer)
            Me.lcMain.MenuManager = manager
            InitData()
            LoadFormLayout()
            For Each item As Control In lcMain.Controls
                AddControl(item)
            Next item
            bbiAdd.Glyph = ElementHelper.BarImages.Images(0)
            bbiDelete.Glyph = ElementHelper.BarImages.Images(2)
            ucMovieCategoryDetail.SetLayoutManager(manager)
        End Sub
        Public ReadOnly Property LayoutManager() As FormLayoutManager Implements IFormWithLayoutManager.LayoutManager
            Get
                If TypeOf _Parent Is IFormWithLayoutManager Then
                    Return (CType(_Parent, IFormWithLayoutManager)).LayoutManager
                End If
                Return Nothing
            End Get
        End Property
        Public ReadOnly Property CategoryWasChanged() As Boolean
            Get
                Return fcategoryWasChanged
            End Get
        End Property
        Protected Sub AddControl(ByVal item As Control)
            Dim edit As BaseEdit = TryCast(item, BaseEdit)
            If (Not Object.Equals(edit, Nothing)) Then
                edit.MenuManager = lcMain.MenuManager
                AddHandler edit.EditValueChanged, AddressOf edit_EditValueChanged
            End If
            Dim editsContainer As IEditsContainer = TryCast(item, IEditsContainer)
            If (Not Object.Equals(editsContainer, Nothing)) Then
                AddHandler editsContainer.EditValueChanged, AddressOf edit_EditValueChanged
            End If
            Dim grid As GridControl = TryCast(item, GridControl)
            If (Not Object.Equals(grid, Nothing)) Then
                grid.MenuManager = lcMain.MenuManager
            End If
        End Sub
        Private Sub InitData()
            gcCategories.DataSource = New XPCollection(Of MovieCategory)(session)
            ucMovieCategoryDetail.SetFocus()
            fcategoryWasChanged = False
        End Sub
        Private Sub SaveData()
            SessionHelper.CommitSession(session, Nothing)
            Cursor.Current = Cursors.Default
        End Sub
        Protected Overridable Sub LoadFormLayout()
            If Object.Equals(LayoutManager, Nothing) Then
                Return
            End If
            LayoutManager.RestoreFormLayout(New FormLayoutInfo(Me, lcMain))
        End Sub
        Protected Overridable Sub SaveFormLayout()
            If Object.Equals(LayoutManager, Nothing) Then
                Return
            End If
            LayoutManager.SaveFormLayout(New FormLayoutInfo(Me, lcMain))
        End Sub
        Private ReadOnly Property CurrentCategory() As MovieCategory
            Get
                If gvCategories.FocusedRowHandle < 0 Then
                    Return Nothing
                End If
                Return TryCast(gvCategories.GetRow(gvCategories.FocusedRowHandle), MovieCategory)
            End Get
        End Property
        Private ReadOnly Property Dirty() As Boolean
            Get
                Return fdirty OrElse session.GetObjectsToSave().Count <> 0 OrElse session.GetObjectsToDelete().Count <> 0
            End Get
        End Property
        Private Sub ShowCurrentCategory(ByVal save As Boolean)
            If save Then
                ucMovieCategoryDetail.SaveData()
            End If
            Dim dirtySave As Boolean = fdirty
            ucMovieCategoryDetail.Init(CurrentCategory, AllCategories)
            fdirty = dirtySave
        End Sub
        Private Sub FocusedRowChanged(ByVal rowHandle As Integer)
            If rowChangeDoOnce Then
                rowChangeDoOnce = False
                Return
            End If
            If (Not ucMovieCategoryDetail.ValidateData()) Then
                rowChangeDoOnce = True
                If rowHandle >= 0 Then
                    gvCategories.FocusedRowHandle = rowHandle
                End If
                Return
            End If
            If Object.Equals(CurrentCategory, Nothing) OrElse (Not CurrentCategory.IsDefault) Then
                bbiDelete.Enabled = True
            Else
                bbiDelete.Enabled = False
            End If
            If (Not Object.Equals(CurrentCategory, Nothing)) Then
                ShowCurrentCategory(rowHandle >= 0)
            End If
            fcategoryWasChanged = True
        End Sub
        Private Sub gvCategories_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gvCategories.ColumnFilterChanged
            FocusedRowChanged(-1)
        End Sub
        Private Sub gvCategories_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvCategories.FocusedRowChanged
            If lockUpdate Then
                Return
            End If
            FocusedRowChanged(e.PrevFocusedRowHandle)
        End Sub
        Private ReadOnly Property AllCategories() As XPCollection(Of MovieCategory)
            Get
                Return CType(gcCategories.DataSource, XPCollection(Of MovieCategory))
            End Get
        End Property
        Private lockUpdate As Boolean = False
        Private Sub bbiAdd_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd.ItemClick
            If (Not ucMovieCategoryDetail.ValidateData()) Then
                Return
            End If
            lockUpdate = True
            Dim category As MovieCategory = ucMovieCategoryDetail.CreateNewMovieCategory(session, AllCategories)
            Try
                AllCategories.Add(category)
            Finally
                lockUpdate = False
            End Try
            WinHelper.GridViewFocusObject(gvCategories, category)
            ucMovieCategoryDetail.SetFocus()
        End Sub
        Private Sub bbiDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDelete.ItemClick
            If Object.Equals(CurrentCategory, Nothing) OrElse CurrentCategory.IsDefault Then
                Return
            End If
            gvCategories.HideEditor()
            gvCategories.UpdateCurrentRow()
            If ObjectHelper.SafeDelete(Me.FindForm(), CurrentCategory, False) Then
                FocusedRowChanged(-1)
            End If
        End Sub
        Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            fdirty = True
        End Sub
		Private Sub sbSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbSave.Click
			DialogResult = System.Windows.Forms.DialogResult.OK
			Close()
		End Sub
		Private Sub frmMovieCategoriesList_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			If DialogResult = System.Windows.Forms.DialogResult.OK Then
				If (Not ucMovieCategoryDetail.ValidateData()) Then
					e.Cancel = True
					Return
				End If
				ucMovieCategoryDetail.SaveData()
				Cursor.Current = Cursors.WaitCursor
				SaveData()
			Else
				If Dirty Then
					Dim result As DialogResult = XtraMessageBox.Show(Me, ConstStrings.CloseCancelFormWarning, ConstStrings.Warning, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
					If result = System.Windows.Forms.DialogResult.Cancel Then
						e.Cancel = True
						Return
					End If
					If result = System.Windows.Forms.DialogResult.Yes Then
						DialogResult = System.Windows.Forms.DialogResult.OK
						Close()
						Return
					End If
				End If
			End If
			Me.session.Dispose()
			Me.session = Nothing
			SaveFormLayout()
		End Sub
	End Class
End Namespace
