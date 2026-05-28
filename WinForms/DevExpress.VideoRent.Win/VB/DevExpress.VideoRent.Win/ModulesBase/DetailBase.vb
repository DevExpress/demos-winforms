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
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid
Imports DevExpress.VideoRent.Win.Controls
Imports DevExpress.VideoRent.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class DetailBase
		Inherits XtraUserControl
		Implements IFormWithLayoutManager
		Protected Friend editObject As VideoRentBaseObject
		Private externalSession As UnitOfWork
        Private fsession As UnitOfWork
        Private _parent As Form
        Private fdirty As Boolean = False
        Private fcreateNewObject As Boolean = False
        Private closeForm As CloseDetailForm = Nothing
        Private freturnResult As DialogResult = DialogResult.Cancel
        Private page As RibbonPage = Nothing
        Private fid As Guid '= Guid.Empty
        Private freadOnly As Boolean = False
        Public ReadOnly Property ActiveRibbonPage() As RibbonPage
            Get
                Return page
            End Get
        End Property
        Public Sub CreateActiveRibbonPage(ByVal page As RibbonPage)
            Me.page = TryCast(page.Clone(), RibbonPage)
            UpdateActiveRibbonPageCaption()
            ActiveRibbonPage.Tag = Me
            page.Ribbon.Pages.Add(ActiveRibbonPage)
            page.Category.Pages.Add(ActiveRibbonPage)
            For Each group As RibbonPageGroup In ActiveRibbonPage.Groups
                For Each link As BarButtonItemLink In group.ItemLinks
                    If link.Item.Caption = ParentFormMain.HomeButton.Caption AndAlso (Not Object.Equals(HomeButtonCaption, String.Empty)) Then
                        If link.Item.Hint <> String.Empty Then
                            link.UserDefine = BarLinkUserDefines.Caption
                            link.UserCaption = HomeButtonCaption
                        End If
                    End If
                Next link
            Next group
        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
                components.Dispose()
                If (Not Object.Equals(ActiveRibbonPage, Nothing)) Then
                    ActiveRibbonPage.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Public Property [ReadOnly]() As Boolean
            Get
                Return freadOnly
            End Get
            Set(ByVal value As Boolean)
                freadOnly = value
                UpdateReadOnlyData()
            End Set
        End Property
        Public ReadOnly Property ParentFormMain() As frmMain
            Get
                Return TryCast(_parent, frmMain)
            End Get
        End Property
        Public ReadOnly Property ID() As Guid
            Get
                Return fid
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal editObject As VideoRentBaseObject, ByVal manager As IDXMenuManager, ByVal closeForm As CloseDetailForm)
            Me.New()
            Me._parent = parent
            Me.externalSession = session
            Me.editObject = editObject
            lcMain.MenuManager = manager
            Me.closeForm = closeForm
        End Sub
        Protected Overridable Sub SetEditObject(ByVal session As UnitOfWork, ByVal editObject As VideoRentBaseObject)
            Me.externalSession = session
            If Object.Equals(session, Nothing) Then
                Me.fsession = Nothing
            Else
                Me.fsession = New UnitOfWork(session.DataLayer)
            End If
            If Object.Equals(session, Nothing) AndAlso Object.Equals(editObject, Nothing) Then
                Return
            End If
            Try
                If (Not Object.Equals(editObject, Nothing)) Then
                    Me.editObject = SessionHelper.GetObject(editObject, Me.Session)
                Else
                    Me.editObject = CreateNewObject()
                End If
            Catch e1 As ObjectDisposedException
                Me.editObject = Nothing
            End Try
            If Object.Equals(Me.editObject, Nothing) Then
                ShowCloseDialog = False
                Close()
                Return
            End If
            If (Not Object.Equals(editObject, Nothing)) Then
                Me.fid = editObject.Oid
            End If
            InitData()
        End Sub
        Protected Overridable Sub UpdateReadOnlyData()
            If (Not Object.Equals(page, Nothing)) Then
                For Each group As RibbonPageGroup In page.Groups
                    UpdateItemLinks(group, [ReadOnly])
                    group.Visible = Not IsEmpty(group)
                Next group
            End If
            SetDefaultOptions()
            If [ReadOnly] Then
                For Each item As Control In lcMain.Controls
                    Dim be As BaseEdit = TryCast(item, BaseEdit)
                    If (Not Object.Equals(be, Nothing)) Then
                        be.Properties.ReadOnly = True
                    End If
                Next item
                ActiveRibbonPage.Text = String.Format(ConstStrings.ReadOnlyCaption, ActiveRibbonPage.Text)
            End If
        End Sub
        Private Shared Function IsEmpty(ByVal group As RibbonPageGroup) As Boolean
            For Each link As BarButtonItemLink In group.ItemLinks
                If link.Visible Then
                    Return False
                End If
            Next link
            Return True
        End Function
        Private Shared Sub UpdateItemLinks(ByVal group As RibbonPageGroup, ByVal [ReadOnly] As Boolean)
            For Each link As BarButtonItemLink In group.ItemLinks
                If "ReadOnly".Equals(link.Item.Tag) Then
                    link.Visible = Not [ReadOnly]
                End If
            Next link
        End Sub
        Public ReadOnly Property LayoutManager() As FormLayoutManager Implements IFormWithLayoutManager.LayoutManager
            Get
                If TypeOf _parent Is IFormWithLayoutManager Then
                    Return (CType(_parent, IFormWithLayoutManager)).LayoutManager
                End If
                Return Nothing
            End Get
        End Property
        Public ReadOnly Property Session() As UnitOfWork
            Get
                Return fsession
            End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            SetEditObject(externalSession, editObject)
            InitValidation()
            If (Not Object.Equals(_parent, Nothing)) Then
                Me.Location = New Point(CInt(Fix(_parent.Left + (_parent.Width - Me.Width) / 2)), CInt(Fix(_parent.Top + (_parent.Height - Me.Height) / 2)))
            End If
            LoadFormLayout()
            SetDefaultOptions()
            For Each item As Control In lcMain.Controls
                AddControl(item)
            Next item
        End Sub
        Protected Sub AddControl(ByVal item As Control)
            Dim edit As BaseEdit = TryCast(item, BaseEdit)
            If (Not Object.Equals(edit, Nothing)) Then
                edit.MenuManager = lcMain.MenuManager
                AddHandler edit.EditValueChanged, AddressOf edit_EditValueChanged
            End If
            Dim userControl As IEditsContainer = TryCast(item, IEditsContainer)
            If (Not Object.Equals(userControl, Nothing)) Then
                AddHandler userControl.EditValueChanged, AddressOf edit_EditValueChanged
            End If
            Dim grid As GridControl = TryCast(item, GridControl)
            If (Not Object.Equals(grid, Nothing)) Then
                grid.MenuManager = lcMain.MenuManager
            End If
        End Sub
        Private Sub SetDefaultOptions()
            If Object.Equals(LayoutManager, Nothing) Then
                Return
            End If
            For Each item As Control In lcMain.Controls
                Dim editBar As ucGridEditBar = TryCast(item, ucGridEditBar)
                If (Not Object.Equals(editBar, Nothing)) Then
                    editBar.SetAllowEditing(LayoutManager.Properties.CurrentProperty.DefaultEditGridViewInDetailForms AndAlso (Not [ReadOnly]))
                    If [ReadOnly] Then
                        editBar.DasabledButtons()
                    End If
                End If
            Next item
        End Sub
        Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dirty = True
        End Sub
        Private fshowCloseDialog As Boolean = True
        Public Property ShowCloseDialog() As Boolean
            Get
                Return fshowCloseDialog
            End Get
            Set(ByVal value As Boolean)
                fshowCloseDialog = value
            End Set
        End Property
        Public ReadOnly Property ValidationProvider() As DXValidationProvider
            Get
                Return dxValidationProvider
            End Get
        End Property
        Protected Overridable Sub CloseCancelForm()
        End Sub
        Protected Overridable Function CreateNewObject() As VideoRentBaseObject
            fcreateNewObject = True
            Return Nothing
        End Function
        Protected Overridable Sub InitValidation()
        End Sub
        Protected Overridable Sub InitData()
        End Sub
        Protected Overridable Sub SaveData()
            Cursor.Current = Cursors.WaitCursor
        End Sub
        Protected Sub CommitSession()
            Dim oldSession As UnitOfWork = Session
            SessionHelper.CommitSession(oldSession, New ExceptionsProcesser(Me.FindForm()))
            SetEditObject(externalSession, editObject)
            oldSession.Dispose()
        End Sub
        Protected Overridable ReadOnly Property HasObjectToSave() As Boolean
            Get
                If fcreateNewObject Then
                    Return Session.GetObjectsToSave().Count > (1)
                Else
                    Return Session.GetObjectsToSave().Count > (0)
                End If
            End Get
        End Property
        Public Overridable Property Dirty() As Boolean
            Get
                Return fdirty OrElse ((Not Object.Equals(Session, Nothing)) AndAlso (HasObjectToSave OrElse Session.GetObjectsToDelete().Count > 0))
            End Get
            Set(ByVal value As Boolean)
                fdirty = value
                UpdateActiveRibbonPageCaption()
            End Set
        End Property
        Public Sub UpdateActiveRibbonPageCaption()
            If Object.Equals(ActiveRibbonPage, Nothing) Then
                Return
            End If
            If Dirty Then
                ActiveRibbonPage.Text = String.Format("{0}{1}", PageCaption, "*")
            Else
                ActiveRibbonPage.Text = String.Format("{0}{1}", PageCaption, String.Empty)
            End If
        End Sub
        Protected Overridable Sub LoadFormLayout()
            If Object.Equals(LayoutManager, Nothing) Then
                Return
            End If
            LayoutManager.RestoreFormLayout(New FormLayoutInfo(Me.GetType().Name, lcMain))
        End Sub
        Protected Overridable Sub SaveFormLayout()
            If Object.Equals(LayoutManager, Nothing) Then
                Return
            End If
            LayoutManager.SaveFormLayout(New FormLayoutInfo(Me.GetType().Name, lcMain))
        End Sub
        Protected Overridable ReadOnly Property HomeButtonCaption() As String
            Get
                Return String.Empty
            End Get
        End Property
#Region "IDetailControl Members"
        Public Sub Close()
            BeforeModuleClose()
            If freturnResult <> DialogResult.OK Then
                If fshowCloseDialog AndAlso Dirty Then
                    Dim result As DialogResult = XtraMessageBox.Show(Me, ConstStrings.CloseCancelFormWarning, ConstStrings.Warning, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If result = DialogResult.Cancel Then
                        Return
                    End If
                    If result = DialogResult.Yes Then
                        Save()
                    End If
                Else
                    CloseCancelForm()
                End If
            End If
            If (Not Object.Equals(Session, Nothing)) Then
                Me.editObject = SessionHelper.GetObject(Of VideoRentBaseObject)(Me.editObject, externalSession)
                Me.fsession.Dispose()
                Me.fsession = Nothing
                SaveFormLayout()
                If (Not Object.Equals(editObject, Nothing)) Then
                    editObject.Reload()
                End If
            End If
            Cursor.Current = Cursors.Default
            If (Not Object.Equals(closeForm, Nothing)) Then
                closeForm(freturnResult, editObject)
            End If
            Me.Dispose()
        End Sub

        Protected Overridable Sub BeforeModuleClose()
            For Each ctrl As Control In lcMain.Controls
                Dim grid As GridControl = TryCast(ctrl, GridControl)
                If (Not Object.Equals(grid, Nothing)) Then
                    Dim view As ColumnView = TryCast(grid.MainView, ColumnView)
                    If Object.Equals(view, Nothing) Then
                        Continue For
                    End If
                    view.CloseEditor()
                    view.UpdateCurrentRow()
                End If
            Next ctrl
        End Sub
        Protected Overridable Function ValidateData() As Boolean
            Return ValidationProvider.Validate()
        End Function
        Public Function Save() As Boolean
            BeforeModuleClose()
            If ValidateData() Then
                SaveData()
                Dirty = False
                freturnResult = DialogResult.Yes
                Return True
            End If
            Return False
        End Function
        Public Function SaveAndClose() As Boolean
            If Save() Then
                freturnResult = DialogResult.OK
                Close()
                Return True
            End If
            Return False
        End Function
        Public ReadOnly Property PageCaption() As String
            Get
                Dim maxLength As Integer = 70
                If Text.Length <= maxLength Then
                    Return Text
                End If
                Return String.Format("{0}...", Text.Substring(0, maxLength))
            End Get
        End Property
        Protected Friend Overridable Sub LoadPicture()
        End Sub
        Protected Friend Overridable Sub ClearPicture()
        End Sub
        Protected Friend Overridable Sub AddPicture()
        End Sub
        Protected Friend Overridable Sub DeletePicture()
        End Sub
        Protected Friend Overridable Sub MovieAddItem()
        End Sub
        Protected Friend Overridable Sub MovieManageItems()
        End Sub
#End Region
#If DebugTest Then
		Public Property ReturnResult() As DialogResult
			Get
				Return freturnResult
			End Get
			Set(ByVal value As DialogResult)
				freturnResult = value
			End Set
		End Property
		Public Sub SendOnLoad()
			OnLoad(EventArgs.Empty)
		End Sub
#End If
	End Class
End Namespace
