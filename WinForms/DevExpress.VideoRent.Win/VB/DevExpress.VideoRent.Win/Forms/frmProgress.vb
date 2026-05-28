Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Alerter

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmProgress
		Inherits StickLookAndFeelForm
		Private _parent As Form
		Private Const requiredCount As Integer = 200
		Private Const requiredDataCount As Integer = 20
		Private requiredUpdateCount As Integer = 0
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal parent As Form)
			Me._parent = parent
			InitializeComponent()
		End Sub
		Private Sub Locate()
			If (Not Object.Equals(_parent, Nothing)) Then
                Me.Location = New Point(CInt(Fix(_parent.Bounds.X + (_parent.Width - Me.Width) / 2)), CInt(Fix(_parent.Bounds.Y + (_parent.Height - Me.Height) / 2)))
			End If
		End Sub
		Public Sub ShowProgress(ByVal count As Integer)
			Locate()
			progressBarControl1.Position = 0
			progressBarControl1.Properties.Maximum = count
			requiredUpdateCount = count \ 55
			If requiredUpdateCount = 0 Then
				requiredUpdateCount = 1
			End If
			If count > requiredCount Then
				Me.Show()
			End If
			FormInvalidate()
		End Sub
		Public Sub ShowProgress(ByVal recordCount As Integer, ByVal caption As String)
			Locate()
			progressBarControl1.Position = 0
			progressBarControl1.Properties.Maximum = 100
			requiredUpdateCount = 1
			labelControl1.Text = caption
			If recordCount > requiredDataCount Then
				Me.Show()
			End If
			FormInvalidate()
		End Sub
		Private Sub FormInvalidate()
			Me.UpdateRegion()
			labelControl1.Refresh()
			Me.Refresh()
		End Sub
		Public Sub Progress(ByVal index As Integer)
			If Me.Visible AndAlso index Mod requiredUpdateCount = 0 Then
				progressBarControl1.Position = index
				progressBarControl1.Refresh()
			End If
		End Sub
		Public Sub HideProgress()
			progressBarControl1.Position = progressBarControl1.Properties.Maximum
			progressBarControl1.Refresh()
			Me.Hide()
		End Sub
	End Class
End Namespace
