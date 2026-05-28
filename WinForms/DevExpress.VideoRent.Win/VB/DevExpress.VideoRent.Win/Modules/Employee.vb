Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.VideoRent.Helpers

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Employee
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			xpCollection1.Reload()
		End Sub
		Protected Overrides Sub InitData()
			MyBase.InitData()
			gridControl1.DataSource = xpCollection1

		End Sub
		Private Sub xpCollection1_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpCollection1.ResolveSession
			e.Session = Session
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			SessionHelper.CommitSession(Session, New ExceptionsProcesser(Me.FindForm()))
		End Sub
	End Class
End Namespace
