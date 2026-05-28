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
Imports DevExpress.VideoRent.Win.Controls
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid
Imports DevExpress.VideoRent.Helpers

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmNewMovieCategory
		Inherits XtraForm
		Private _parent As Form
		Private allCategories As XPCollection(Of MovieCategory)
		Private session As NestedUnitOfWork
        Private fmovieCategory As MovieCategory
        Private menuManager As IDXMenuManager
        Private fdirty As Boolean = False
        Private createNewObject As Boolean = True
        Public Sub New(ByVal parent As Form, ByVal allCategories As XPCollection(Of MovieCategory), ByVal menuManager As IDXMenuManager)
            InitializeComponent()
            Me._parent = parent
            Me.allCategories = allCategories
            Me.session = allCategories.Session.BeginNestedUnitOfWork()
            Me.menuManager = menuManager
            Me.fmovieCategory = CreateNewCategory()
            ucMovieCategoryDetail.SetLayoutManager(menuManager)
            ucMovieCategoryDetail.Init(Me.fmovieCategory, allCategories)
            AddControl(ucMovieCategoryDetail)
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If (Not Object.Equals(_parent, Nothing)) Then
                Me.Location = New Point(CInt(Fix(_parent.Left + (_parent.Width - Me.Width) / 2)), CInt(Fix(_parent.Top + (_parent.Height - Me.Height) / 2)))
            End If
            LoadFormLayout()
        End Sub
        Public ReadOnly Property MovieCategory() As MovieCategory
            Get
                Return fmovieCategory
            End Get
        End Property
        Protected Sub AddControl(ByVal item As Control)
            Dim edit As BaseEdit = TryCast(item, BaseEdit)
            If (Not Object.Equals(edit, Nothing)) Then
                edit.MenuManager = menuManager
                AddHandler edit.EditValueChanged, AddressOf edit_EditValueChanged
            End If
            Dim editsContainer As IEditsContainer = TryCast(item, IEditsContainer)
            If (Not Object.Equals(editsContainer, Nothing)) Then
                AddHandler editsContainer.EditValueChanged, AddressOf edit_EditValueChanged
            End If
            Dim grid As GridControl = TryCast(item, GridControl)
            If (Not Object.Equals(grid, Nothing)) Then
                grid.MenuManager = menuManager
            End If
        End Sub
        Protected Overridable ReadOnly Property HasObjectToSave() As Boolean
            Get
                If createNewObject Then
                    Return session.GetObjectsToSave().Count > (1 + System.Enum.GetValues(GetType(MovieItemFormat)).Length)
                Else
                    Return session.GetObjectsToSave().Count > (0)
                End If
            End Get
        End Property
        Private ReadOnly Property Dirty() As Boolean
            Get
                Return fdirty OrElse ((Not Object.Equals(session, Nothing)) AndAlso (HasObjectToSave OrElse session.GetObjectsToDelete().Count > 0))
            End Get
        End Property
        Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            fdirty = True
        End Sub
        Private Function CreateNewCategory() As MovieCategory
            Return ucMovieCategoryDetail.CreateNewMovieCategory(session, allCategories)
        End Function
        Private Sub frmNewCategory_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If DialogResult = System.Windows.Forms.DialogResult.OK Then
                If (Not ucMovieCategoryDetail.ValidateData()) Then
                    e.Cancel = True
                    Return
                End If
                Cursor.Current = Cursors.WaitCursor
                ucMovieCategoryDetail.SaveData()
                session.CommitChanges()
                Cursor.Current = Cursors.Default

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
                fmovieCategory = Nothing
            End If
            fmovieCategory = SessionHelper.GetObject(Of MovieCategory)(fmovieCategory, session.Parent)
            allCategories.Add(fmovieCategory)
            session.Dispose()
            SaveFormLayout()
        End Sub
		Protected Overridable Sub LoadFormLayout()
			If Object.Equals(LayoutManager, Nothing) Then
				Return
			End If
			LayoutManager.RestoreFormLayout(New FormLayoutInfo(Me, Nothing))
		End Sub
		Protected Overridable Sub SaveFormLayout()
			If Object.Equals(LayoutManager, Nothing) Then
				Return
			End If
			LayoutManager.SaveFormLayout(New FormLayoutInfo(Me, Nothing))
		End Sub
		Public ReadOnly Property LayoutManager() As FormLayoutManager
			Get
				If TypeOf _parent Is IFormWithLayoutManager Then
					Return (CType(_parent, IFormWithLayoutManager)).LayoutManager
				End If
				Return Nothing
			End Get
		End Property
	End Class
End Namespace
