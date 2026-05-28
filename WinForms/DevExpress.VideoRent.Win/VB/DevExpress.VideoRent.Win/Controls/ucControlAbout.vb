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
Imports DevExpress.Utils.Frames
Imports DevExpress.Data.Helpers
Imports DevExpress.XtraNavBar

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucControlAbout
		Inherits XtraUserControl
		Implements IXtraResizableControl
		Private Const LinkHeight As Integer = 45
		Private Const PictureIndent As Integer = 0
		Private labelInfo As New LabelInfo()
		Public Sub New()
			InitializeComponent()
			AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			If disposing Then
				RemoveHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
			End If
			MyBase.Dispose(disposing)
		End Sub
		Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateLabelInfoColor()
		End Sub
		Private Sub UpdateLabelInfoColor()
			For Each liText As LabelInfoText In labelInfo.Texts
				liText.Color = WinHelper.GetLinkColor(LookAndFeel)
			Next liText
		End Sub
		Public Sub Init(ByVal name As String, ByVal product As DemoProducts, ByVal image As Image)
			lcName.Text = name
			peAbout.Image = image
			If image IsNot Nothing Then
				peAbout.Height = image.Height
			End If
			RaiseChanged()
			CreateLabels(product)
			UpdateLabelInfoColor()
		End Sub

		Private Sub CreateLabels(ByVal product As DemoProducts)
			labelInfo.BackColor = Color.Transparent
			labelInfo.Bounds = New Rectangle(0, 0, Me.Width, LinkHeight)
			labelInfo.Parent = pnlLinks
			AddHandler labelInfo.ItemClick, AddressOf OnLabelClick
			For Each info As ModuleInfo In DemosInfo.Instance.Collection
				If info.Products.ToString().IndexOf(product.ToString()) >= 0 Then
					If labelInfo.Text.Length > 0 Then
						labelInfo.Texts.Add(ConstStrings.AboutFormSeparator)
					End If
					Dim liText As LabelInfoText = labelInfo.Texts.Add(ElementHelper.GetSingleLineString(info.Name), True)
					liText.Tag = info
				End If
			Next info
		End Sub
		Private Sub OnLabelClick(ByVal sender As Object, ByVal e As LabelInfoItemClickEventArgs)
			Dim form As frmMain = TryCast(Me.FindForm(), frmMain)
			If form Is Nothing Then
			Return
			End If
			For Each group As NavBarGroup In form.NavigationBar.Groups
				For Each link As NavBarItemLink In group.ItemLinks
					If e.InfoText.Tag.Equals(link.Item.Tag) Then
						form.NavigationBar.SelectedLink = link
						form.NavigationBar.GetViewInfo().MakeLinkVisible(link)
						Return
					End If
				Next link
			Next group
		End Sub
		Protected Overrides Sub OnFontChanged(ByVal e As EventArgs)
            MyBase.OnFontChanged(e)
            If (lcName Is Nothing) Then Return
            lcName.Font = New Font(Me.Font.FontFamily, 10)
			labelInfo.Font = New Font(Me.Font.FontFamily, 8.75f)
		End Sub
		#Region "IXtraResizableControl Members"
        Public Event Changed As EventHandler
		Protected Overridable Sub RaiseChanged()
			RaiseEvent Changed(Me, EventArgs.Empty)
		End Sub
        Public ReadOnly Property IsCaptionVisible() As Boolean
            Get
                Return False
			End Get
		End Property
        Public ReadOnly Property MaxSize() As Size
            Get
                Return New Size(ControlWidth, ControlHeight)
            End Get
        End Property
        Public ReadOnly Property MinSize() As Size
            Get
                Return New Size(ControlWidth, ControlHeight)
            End Get
        End Property
		Private ReadOnly Property ControlWidth() As Integer
			Get
				If peAbout.Image Is Nothing Then
					Return 200
				Else
					Return peAbout.Image.Width + PictureIndent * 2
				End If
			End Get
		End Property
		Private ReadOnly Property ControlHeight() As Integer
			Get
				Return lcName.Height + peAbout.Height + LinkHeight
			End Get
		End Property
		#End Region
	End Class
End Namespace
