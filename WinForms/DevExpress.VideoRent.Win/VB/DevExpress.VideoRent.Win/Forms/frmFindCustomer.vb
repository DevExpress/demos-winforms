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
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmFindCustomer
		Inherits XtraForm
		Private layoutManager As FormLayoutManager
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal layoutManager As FormLayoutManager, ByVal manager As IDXMenuManager, ByVal session As Session, ByVal showClear As Boolean)
			Me.New()
			gridControl1.MenuManager = manager
			Me.layoutManager = layoutManager
			xcCustomers.Session = session
			sbClear.Visible = False 'showClear;
		End Sub
		Private ReadOnly Property CurrentCustomer() As Customer
			Get
				If gridView1.FocusedRowHandle < 0 Then
					Return Nothing
				End If
				Return TryCast(gridView1.GetRow(gridView1.FocusedRowHandle), Customer)
			End Get
		End Property
		Private Sub sbOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbOK.Click
			layoutManager.CurrentCustomer = CurrentCustomer
		End Sub
		Private Sub sbClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbClear.Click
			layoutManager.CurrentCustomer = Nothing
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			InitEditors()
			gridControl1.ForceInitialize()
			LoadFormLayout()
			If (Not Object.Equals(layoutManager.CurrentCustomer, Nothing)) Then
				WinHelper.GridViewFocusObject(gridView1, layoutManager.CurrentCustomer)
			Else
				gridView1.FocusedRowHandle = GridControl.AutoFilterRowHandle
			End If
			ChangedFocusedRow()
		End Sub
		Private Sub InitEditors()
			colGender.ColumnEdit = EditorHelper.CreateGenderImageComboBox(gridControl1.RepositoryItems)
			colCustomerId.ColumnEdit = EditorHelper.CreateCardNumberTextEdit(gridControl1.RepositoryItems)
		End Sub
		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
			SaveFormLayout()
		End Sub

		Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
			If e.FocusedRowHandle = GridControl.AutoFilterRowHandle Then
				gridView1.FocusedColumn = colCustomerId
			ElseIf e.FocusedRowHandle >= 0 Then
				gridView1.FocusedColumn = Nothing
			End If
			ChangedFocusedRow()
		End Sub
		Private Sub gridView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.ColumnFilterChanged
			ChangedFocusedRow()
		End Sub
		Private Sub ChangedFocusedRow()
			sbOK.Enabled = Not Object.Equals(CurrentCustomer, Nothing)
			ucCustomerInfo1.Init(CurrentCustomer, ConstStrings.AutoFilterRowHint)
		End Sub

		Private Sub gridControl1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridControl1.MouseDoubleClick
			Dim info As GridHitInfo = gridView1.CalcHitInfo(New Point(e.X, e.Y))
			If (Not Object.Equals(CurrentCustomer, Nothing)) AndAlso info.InRow Then
				layoutManager.CurrentCustomer = CurrentCustomer
				DialogResult = System.Windows.Forms.DialogResult.OK
			End If
		End Sub
		Protected Overridable Sub LoadFormLayout()
			layoutManager.RestoreFormLayout(New FormLayoutInfo(Nothing, Nothing, lcMain, gridView1, Nothing))
		End Sub
		Protected Overridable Sub SaveFormLayout()
			layoutManager.SaveFormLayout(New FormLayoutInfo(Nothing, Nothing, lcMain, gridView1, Nothing))
		End Sub
	End Class
End Namespace
