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
Imports DevExpress.VideoRent.Helpers

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmAddBase
		Inherits XtraForm
		Implements IFormWithLayoutManager
		Protected editObject As VideoRentBaseObject
        Private fsession As UnitOfWork
        Private _parent As Form
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal editObject As VideoRentBaseObject, ByVal manager As IDXMenuManager)
            Me.New()
            Me.fsession = session
            Me.editObject = editObject
            Me._parent = parent
            lcMain.MenuManager = manager
        End Sub
        Public ReadOnly Property Session() As UnitOfWork
            Get
                Return fsession
            End Get
        End Property
		Public ReadOnly Property LayoutManager() As FormLayoutManager Implements IFormWithLayoutManager.LayoutManager
			Get
				If TypeOf _parent Is IFormWithLayoutManager Then
					Return (CType(_parent, IFormWithLayoutManager)).LayoutManager
				End If
				Return Nothing
			End Get
		End Property
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If Object.Equals(_parent, Nothing) Then
				Return
			End If
			InitData()
			InitValidation()
            Me.Location = New Point(CInt(Fix(_parent.Left + (_parent.Width - Me.Width) / 2)), CInt(Fix(_parent.Top + (_parent.Height - Me.Height) / 2)))
			LoadFormLayout()
			For Each item As Control In lcMain.Controls
				Dim edit As BaseEdit = TryCast(item, BaseEdit)
				If (Not Object.Equals(edit, Nothing)) Then
					edit.MenuManager = lcMain.MenuManager
				End If
			Next item
		End Sub
		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
			If DialogResult = System.Windows.Forms.DialogResult.OK Then
				If Object.Equals(editObject, Nothing) Then
					CreateNewObject()
				End If
				SaveData()
			Else
				CloseCancelForm()
			End If
			SaveFormLayout()
		End Sub
		Private Sub sbSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbSave.Click
			If ValidationProvider.Validate() Then
				DialogResult = System.Windows.Forms.DialogResult.OK
				Close()
			End If
		End Sub
		Protected Overridable Sub CloseCancelForm()
		End Sub
		Public ReadOnly Property ValidationProvider() As DXValidationProvider
			Get
				Return dxValidationProvider
			End Get
		End Property
		Protected Overridable Sub CreateNewObject()
		End Sub
		Protected Overridable Sub InitData()
		End Sub
		Protected Overridable Sub InitValidation()
		End Sub
		Protected Overridable Sub SaveData()
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
	End Class
End Namespace
