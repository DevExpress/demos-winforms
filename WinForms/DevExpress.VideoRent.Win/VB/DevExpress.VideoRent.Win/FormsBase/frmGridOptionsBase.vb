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
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmGridOptionsBase
		Inherits XtraForm
        Private fview As GridView
        Private _parent As Form
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal parent As Form, ByVal caption As String, ByVal view As GridView)
            Me.New()
            Me.fview = view
            Me._parent = parent
            Text = caption

        End Sub
        Public ReadOnly Property View() As GridView
            Get
                Return fview
            End Get
        End Property
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If Object.Equals(_parent, Nothing) Then
				Return
			End If
			InitOptions()
            Me.Location = New Point(CInt(Fix(_parent.Left + (_parent.Width - Me.Width) / 2)), CInt(Fix(_parent.Top + (_parent.Height - Me.Height) / 2)))
		End Sub
		Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
			MyBase.OnClosing(e)
			If DialogResult = System.Windows.Forms.DialogResult.OK Then
				SetOptions()
			End If
		End Sub

		Protected Overridable Sub InitOptions()
		End Sub
		Protected Overridable Sub SetOptions()
		End Sub
	End Class
End Namespace
