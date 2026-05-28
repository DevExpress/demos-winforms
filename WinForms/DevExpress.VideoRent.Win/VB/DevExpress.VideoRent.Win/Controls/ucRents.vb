Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucRents
		Inherits XtraUserControl
		Private session As Session
		Private movie As Movie
		Public Sub New()
			MyBase.New()
			InitializeComponent()
		End Sub
		Public Sub InitData(ByVal session As Session, ByVal movie As Movie)
			Me.session = session
			Me.movie = movie
			InitRentsGrid()
			AddHandler ucGridSwitcherBar.ChangeState, AddressOf SwitchRentsGrid
			ucGridSwitcherBar.Checked = True
		End Sub
		Private Sub InitRentsGrid()
			colCustomer.ColumnEdit = EditorHelper.CreateCustomerGridLookUpEdit(session, gcRents.RepositoryItems)
			gcRents.DataSource = movie.Rents
		End Sub
		Private Sub SwitchRentsGrid(ByVal sender As Object, ByVal e As ucBarOneCheckedButton.ChangeStateEventArgs)
			If e.Checked Then
				gvRents.ActiveFilter.Add(colActive, New ColumnFilterInfo(colActive, True))
			Else
				gvRents.ActiveFilter.Remove(colActive)
			End If
			colActive.Visible = Not e.Checked
		End Sub
	End Class
End Namespace
