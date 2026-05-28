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

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmDetailBase
		Inherits XtraForm
		Implements IFormWithLayoutManager
		Private _parent As Form
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal parent As Form)
			InitializeComponent()
			Me._parent = parent
		End Sub
		Public Overridable ReadOnly Property LayoutManager() As FormLayoutManager Implements IFormWithLayoutManager.LayoutManager
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
            Me.Location = New Point(CInt(Fix(_parent.Left + (_parent.Width - Me.Width) / 2)), CInt(Fix(_parent.Top + (_parent.Height - Me.Height) / 2)))
			LoadFormLayout()
		End Sub
		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
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

		Private Sub sbOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbOK.Click
			SaveData()
		End Sub

		Protected Overridable Sub SaveData()
		End Sub
	End Class
End Namespace
