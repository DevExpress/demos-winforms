Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.VideoRent.Resources
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Frames

Namespace DevExpress.VideoRent.Win
	Partial Public Class frmAbout
		Inherits XtraForm
		Private blnMoving As Boolean = False
		Private MouseDownX, MouseDownY As Integer
		Private Shared fontName As String = "Segoe UI"
		Private labelInfo As New LabelInfo()
		Private Shared color1 As Color = Color.FromArgb(210, 196, 196), color2 As Color = Color.FromArgb(143, 133, 127)
		Private Shared versionAppearance As New AppearanceDefault(color1, Color.Empty, HorzAlignment.Near, VertAlignment.Top, New Font(fontName, 9.25f)), descriptionAppearance As New AppearanceDefault(color1, Color.Empty, HorzAlignment.Near, VertAlignment.Top, New Font(fontName, 7.75f)), copyrightAppearance As New AppearanceDefault(color2, Color.Empty, HorzAlignment.Center, VertAlignment.Top, New Font(fontName, 7.75f))
		Private Shared versionBounds As New Rectangle(210, 94, 260, 20), descriptionBounds As New Rectangle(210, 124, 270, 100), copyrightBounds As New Rectangle(20, 280, 485, 20)
		Public Sub New()
			InitializeComponent()
            Dim bgImage As Image = ResourceImageHelper.CreateImageFromResources("About.png", GetType(ImagesHelper).Assembly)
			Me.BackgroundImage = bgImage
			Me.Size = bgImage.Size
			CreateLinks()
		End Sub
		Private Sub CreateLinks()
			labelInfo.Font = New Font(fontName, 8.75f)
			labelInfo.BackColor = Color.Transparent
			labelInfo.Bounds = New Rectangle(55, 260, 430, 20)
			labelInfo.Parent = Me
			AddHandler labelInfo.ItemClick, AddressOf OnLabelClick
			labelInfo.Texts.Add(ConstStrings.AboutFormLink1, color1, True)
			labelInfo.Texts.Add(ConstStrings.AboutFormSeparator, color2)
			labelInfo.Texts.Add(ConstStrings.AboutFormLink2, color1, True)
			labelInfo.Texts.Add(ConstStrings.AboutFormSeparator, color2)
			labelInfo.Texts.Add(ConstStrings.AboutFormLink3, color1, True)
		End Sub
		Private Sub OnLabelClick(ByVal sender As Object, ByVal e As LabelInfoItemClickEventArgs)
			Dim name As String = GetProcessName(e)
			If (Not Object.Equals(name, Nothing)) Then
				ObjectHelper.ShowWebSite(name)
			End If
		End Sub
		Private Function GetProcessName(ByVal e As LabelInfoItemClickEventArgs) As String
			If e.InfoText.Text.Equals(ConstStrings.AboutFormLink1) Then
				Return ConstStrings.DXLink
			End If

			If e.InfoText.Text.Equals(ConstStrings.AboutFormLink2) Then
				Return ConstStrings.TrialsLink
			End If
			If e.InfoText.Text.Equals(ConstStrings.AboutFormLink3) Then
				Return ConstStrings.PurchaseLink
			End If
			Return Nothing
		End Function
		Public Shared Sub ShowAbout(ByVal parent As Form)
			Dim about As New frmAbout()
			about.Opacity = 0
			Dim tmr As New Timer()
			tmr.Tag = about
			tmr.Interval = 20
			AddHandler tmr.Tick, AddressOf tmr_Tick
            tmr.Start()
			about.ShowDialog(parent)
			about.Dispose()
		End Sub

		Private Shared Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Dim tmr As Timer = TryCast(sender, Timer)
			Dim frm As Form = TryCast(tmr.Tag, Form)
			If Object.Equals(frm, Nothing) Then
				tmr.Stop()
				Return
			End If
			Try
				frm.Opacity += 0.07
				If frm.Opacity >= 0.99 Then
					tmr.Tag = Nothing
				End If
			Catch
			End Try
		End Sub

		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			If e.KeyData = Keys.Escape Then
				e.Handled = True
				Close()
			End If
			MyBase.OnKeyDown(e)
		End Sub
		Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			If e.Y < 250 Then
				Close()
			Else
				If e.Button = MouseButtons.Left Then
					blnMoving = True
					MouseDownX = e.X
					MouseDownY = e.Y
				End If
			End If
		End Sub
		Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			If blnMoving Then
				Me.Location = New Point(Me.Location.X + (e.X - MouseDownX), Me.Location.Y + (e.Y - MouseDownY))
			End If
		End Sub
		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			If e.Button = MouseButtons.Left Then
				blnMoving = False
			End If
		End Sub
		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			Using cache As New GraphicsCache(e)
				cache.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
				DrawVersion(cache)
				DrawDescription(cache)
				DrawCopyright(cache)
			End Using
		End Sub
		Private Sub DrawVersion(ByVal cache As GraphicsCache)
			Dim app As New AppearanceObject(versionAppearance)
			app.DrawString(cache, ConstStrings.AboutFormVersion, versionBounds)
		End Sub
		Private Sub DrawDescription(ByVal cache As GraphicsCache)
			Dim app As New AppearanceObject(descriptionAppearance)
			app.TextOptions.WordWrap = WordWrap.Wrap
			app.DrawString(cache, ConstStrings.AboutFormDescription, descriptionBounds)
		End Sub
		Private Sub DrawCopyright(ByVal cache As GraphicsCache)
			Dim app As New AppearanceObject(copyrightAppearance)
			app.DrawString(cache, ConstStrings.AboutFormCopyright, copyrightBounds)
		End Sub
	End Class
End Namespace
