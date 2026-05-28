Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraBars
Imports DevExpress.Utils.Controls

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucBarOneCheckedButton
		Inherits XtraUserControl
		Implements IXtraResizableControl
		Public Class ChangeStateEventArgs
			Inherits EventArgs
			Private isChecked As Boolean
			Public Sub New(ByVal isChecked As Boolean)
				MyBase.New()
				Me.isChecked = isChecked
			End Sub
			Public ReadOnly Property Checked() As Boolean
				Get
					Return isChecked
				End Get
			End Property
		End Class
		Public Delegate Sub ChangeStateEventHandler(ByVal sender As Object, ByVal e As ChangeStateEventArgs)
		Public Event ChangeState As ChangeStateEventHandler
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Property Checked() As Boolean
			Get
				Return bciSwitch.Checked
			End Get
			Set(ByVal value As Boolean)
				bciSwitch.Checked = value
			End Set
		End Property
		Public Property ButtonCaption() As String
			Get
				Return bciSwitch.Caption
			End Get
			Set(ByVal value As String)
				bciSwitch.Caption = value
			End Set
		End Property
		Private Sub bciSwitch_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bciSwitch.CheckedChanged
			If (Not Object.Equals(ChangeStateEvent, Nothing)) Then
				RaiseEvent ChangeState(Me, New ChangeStateEventArgs(Checked))
			End If
		End Sub
		#Region "IXtraResizableControl Members"
        Public Event Changed As EventHandler
		Protected Overridable Sub RaiseChanged()
			If (Not Object.Equals(ChangedEvent, Nothing)) Then
				RaiseEvent Changed(Me, EventArgs.Empty)
			End If
		End Sub
        Public ReadOnly Property IsCaptionVisible() As Boolean
            Get
                Return False
            End Get
        End Property
        Public ReadOnly Property MaxSize() As Size
            Get
                Return New Size(3000, ControlHeight)
            End Get
        End Property
        Public ReadOnly Property MinSize() As Size
            Get
                Return New Size(170, ControlHeight)
            End Get
        End Property
		Private ReadOnly Property ControlHeight() As Integer
			Get
				If Object.Equals(mainBar, Nothing) OrElse mainBar.Size.IsEmpty OrElse mainBar.Size.Height = 0 Then
					Return 25
				End If
				Return mainBar.Size.Height
			End Get
		End Property
		#End Region
	End Class
End Namespace
