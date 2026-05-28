Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucGridEditBar
		Inherits XtraUserControl
		Implements IXtraResizableControl
		Public Event AddRecord As EventHandler
		Public Event DeleteRecord As EventHandler
		Private view As GridView
		Public Sub New()
			InitializeComponent()
			bbiAdd.Glyph = ElementHelper.BarImages.Images(0)
			bbiDelete.Glyph = ElementHelper.BarImages.Images(2)
			bciAllowEditing.Glyph = ElementHelper.BarImages.Images(5)
		End Sub
		Public Sub Init(ByVal view As GridView)
			Me.view = view
			bciAllowEditing.Checked = view.OptionsBehavior.Editable
			InitButtons()
			SetGridOptions()
			AddHandler view.FocusedRowChanged, AddressOf view_FocusedRowChanged
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			RaiseChanged()
		End Sub
		Public Sub SetAllowEditing(ByVal allow As Boolean)
			bciAllowEditing.Checked = allow
		End Sub
		Private Sub view_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
			InitButtons()
		End Sub
		Private Sub InitButtons()
			bbiAdd.Enabled = bciAllowEditing.Checked
			bbiDelete.Enabled = bciAllowEditing.Checked AndAlso Not Object.Equals(view.GetRow(view.FocusedRowHandle),Nothing)
		End Sub
		Private Sub bciAllowEditing_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bciAllowEditing.CheckedChanged
			InitButtons()
			SetGridOptions()
		End Sub
		Private Sub SetGridOptions()
			view.OptionsBehavior.Editable = bciAllowEditing.Checked
			view.OptionsView.ShowIndicator = bciAllowEditing.Checked
			For Each column As GridColumn In view.Columns
				column.OptionsColumn.AllowFocus = bciAllowEditing.Checked
			Next column
		End Sub
		Private Sub bbiAdd_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd.ItemClick
			If (Not Object.Equals(AddRecordEvent, Nothing)) Then
				RaiseEvent AddRecord(Me, e)
			End If
		End Sub
		Private Sub bbiDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDelete.ItemClick
			If (Not Object.Equals(DeleteRecordEvent, Nothing)) Then
				RaiseEvent DeleteRecord(Me, e)
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

		Friend Sub DasabledButtons()
			bciAllowEditing.Enabled = False
			bbiDelete.Enabled = bciAllowEditing.Enabled
			bbiAdd.Enabled = bbiDelete.Enabled
		End Sub
	End Class
End Namespace
