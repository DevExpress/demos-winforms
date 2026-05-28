Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Controls

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucBarTwoButtons
		Inherits XtraUserControl
		Implements IXtraResizableControl
		Public Event Button0Click As EventHandler
		Public Event Button1Click As EventHandler
		Public Property Button0Caption() As String
			Get
				Return bbiButton0.Caption
			End Get
			Set(ByVal value As String)
				bbiButton0.Caption = value
			End Set
		End Property
		Public Property Button1Caption() As String
			Get
				Return bbiButton1.Caption
			End Get
			Set(ByVal value As String)
				bbiButton1.Caption = value
			End Set
		End Property
		Public Property Button0Glyph() As Image
			Get
				Return bbiButton0.Glyph
			End Get
			Set(ByVal value As Image)
				bbiButton0.Glyph = value
			End Set
		End Property
		Public Property Button1Glyph() As Image
			Get
				Return bbiButton1.Glyph
			End Get
			Set(ByVal value As Image)
				bbiButton1.Glyph = value
			End Set
		End Property
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub bbiButton0_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiButton0.ItemClick
			If (Not Object.Equals(Button0ClickEvent,Nothing)) Then
				RaiseEvent Button0Click(Me, New EventArgs())
			End If
		End Sub
		Private Sub bbiButton1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiButton1.ItemClick
			If (Not Object.Equals(Button1ClickEvent, Nothing)) Then
				RaiseEvent Button1Click(Me, New EventArgs())
			End If
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			RaiseChanged()
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
