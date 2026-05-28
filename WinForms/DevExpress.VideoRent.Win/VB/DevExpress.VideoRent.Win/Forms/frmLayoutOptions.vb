Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmLayoutOptions
		Inherits XtraForm
		Private layoutManager As FormLayoutManager
		Public Sub New()
			InitializeComponent()
		End Sub
		Private ReadOnly Property CurrentProperty() As WinFormProperty
			Get
				Return layoutManager.Properties.CurrentProperty
			End Get
		End Property
		Public Sub New(ByVal layoutManager As FormLayoutManager)
			Me.New()
			Me.layoutManager = layoutManager
			InitData()
		End Sub

		Private Sub InitData()
			ceAllowRestoreFormLayout.Checked = CurrentProperty.AllowRestoreFormLayout
			ceAllowRestoreLayoutControlLayout.Checked = CurrentProperty.AllowRestoreLayoutControlLayout
			ceAllowRestoreGridViewLayout.Checked = CurrentProperty.AllowRestoreGridViewLayout
			ceAllowRestoreDockingLayout.Checked = CurrentProperty.AllowRestoreDockingLayout
			ceDefaultEditGridViewInDetailForms.Checked = CurrentProperty.DefaultEditGridViewInDetailForms
		End Sub

		Private Sub sbClearLayouts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbClearLayouts.Click
			layoutManager.ClearLayouts()
		End Sub

		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
			If Me.DialogResult = System.Windows.Forms.DialogResult.OK Then
				SaveData()
			End If
		End Sub

		Private Sub SaveData()
			CurrentProperty.AllowRestoreFormLayout = ceAllowRestoreFormLayout.Checked
			CurrentProperty.AllowRestoreLayoutControlLayout = ceAllowRestoreLayoutControlLayout.Checked
			CurrentProperty.AllowRestoreGridViewLayout = ceAllowRestoreGridViewLayout.Checked
			CurrentProperty.AllowRestoreDockingLayout = ceAllowRestoreDockingLayout.Checked
			CurrentProperty.DefaultEditGridViewInDetailForms = ceDefaultEditGridViewInDetailForms.Checked
			layoutManager.Properties.Save()
		End Sub
	End Class
End Namespace
