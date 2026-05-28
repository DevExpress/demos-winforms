Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports System.IO

Namespace DevExpress.Xpo.Demos
	Friend Class XConsole
		Inherits XtraScrollableControl
		Public Sub New()
			Me.Appearance.Options.UseBackColor = True
			Me.Enabled = True
		End Sub
		Public Shadows Property Enabled() As Boolean
			Get
				Return MyBase.Enabled
			End Get
			Set(ByVal value As Boolean)
				MyBase.Enabled = value
				If MyBase.Enabled Then
					Me.Appearance.BackColor = Color.White
				Else
					Me.Appearance.BackColor = Color.Gray
				End If
			End Set
		End Property
	End Class
	Public Class XtraConsole
		Inherits XtraUserControl
		Private paintWin As PaintWindow
		Private xtraScrollableControl1 As XConsole

		Public Sub New()
			InitializeComponent()
			Me.paintWin.Console = Me
			lines.Add(String.Empty)
			Me.Appearance.ForeColor = Color.Black
		End Sub

		Private Sub InitializeComponent()
			Me.xtraScrollableControl1 = New XConsole()
			Me.paintWin = New PaintWindow()
			Me.xtraScrollableControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' xtraScrollableControl1
			' 

			Me.xtraScrollableControl1.Controls.Add(Me.paintWin)
			Me.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
			Me.xtraScrollableControl1.Size = New System.Drawing.Size(438, 367)
			Me.xtraScrollableControl1.TabIndex = 0
			' 
			' paintWin
			' 
			Me.paintWin.Location = New System.Drawing.Point(3, 3)
			Me.paintWin.Name = "paintWin"
			Me.paintWin.Size = New System.Drawing.Size(30, 25)
			Me.paintWin.TabIndex = 0
			' 
			' XtraConsole
			' 
			Me.Controls.Add(Me.xtraScrollableControl1)
			Me.Name = "XtraConsole"
			Me.Size = New System.Drawing.Size(438, 367)
			Me.xtraScrollableControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		Public Shadows Property Enabled() As Boolean
			Get
				Return MyBase.Enabled
			End Get
			Set(ByVal value As Boolean)
				MyBase.Enabled = value
				xtraScrollableControl1.Enabled = value
				Me.Refresh()
			End Set
		End Property
		Private lines As New List(Of String)()
		Private Function CalcStringWidth(ByVal str As String) As Integer
			Dim ginfo As New GraphicsInfo()
			ginfo.AddGraphics(Nothing)
			Dim textSize As SizeF = New AppearanceObject(Appearance, DefaultAppearance).CalcTextSize(ginfo.Cache, str, Integer.MaxValue)
			ginfo.ReleaseGraphics()
			Return CInt(Fix(Math.Ceiling(textSize.Width)))
		End Function
		Protected Friend Sub DoPaint(ByVal e As PaintEventArgs)
			Dim startLine As Integer = e.ClipRectangle.Top \ Me.Font.Height
			If startLine >= lines.Count Then
				Return
			End If
			Dim endLine As Integer = e.ClipRectangle.Bottom \ Me.Font.Height + 1
			Using cache As New GraphicsCache(e)
				Dim ao As New AppearanceObject(Appearance, DefaultAppearance)
				Dim i As Integer = startLine
				Do While i < lines.Count AndAlso i <= endLine
					ao.DrawString(cache, lines(i), New Rectangle(0, i * ao.Font.Height, paintWin.Width, ao.Font.Height))
					i += 1
				Loop
			End Using
		End Sub
		Private buffer As String = String.Empty
		Private ReadOnly SyncRoot As Object = New Object()
		Private Sub WriteBuffer(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.IsHandleCreated) OrElse Me.IsDisposed Then
				Return
			End If
			Dim str As String
			SyncLock SyncRoot
				str = buffer
				If str Is Nothing OrElse str.Length = 0 Then
					Return
				End If
				buffer = String.Empty
			End SyncLock
			str = str.Replace(Constants.vbCrLf, Constants.vbLf)
			str = str.Replace(Constants.vbLf + Constants.vbCr, Constants.vbLf)
			str = str.Replace(ControlChars.Cr, ControlChars.Lf)
			Dim nonFirst As Boolean = False
			Dim linesAdded As Boolean = False
			For Each line As String In str.Split(ControlChars.Lf)
				If nonFirst Then
					lines.Add(String.Empty)
					linesAdded = True
				Else
					nonFirst = True
				End If
				Dim pos As Integer = lines.Count - 1
				Dim newValue As String = lines(pos) & line
				lines(pos) = newValue
				Dim width As Integer = CalcStringWidth(newValue)
				If width >= paintWin.Width Then
					paintWin.Width = width + 1
				End If
			Next line
			If linesAdded Then
				Me.paintWin.Height = lines.Count * Me.Font.Height
				If AutoScrollToEnd AndAlso paintWin.Height > Me.xtraScrollableControl1.ClientRectangle.Height Then
					Me.xtraScrollableControl1.AutoScrollPosition = New Point(0, 2 + paintWin.Height - Me.xtraScrollableControl1.ClientRectangle.Height)
				End If
			End If
			Me.paintWin.Invalidate()
		End Sub
		Public AutoScrollToEnd As Boolean = True
		Private Class PaintWindow
			Inherits Control
			Public Console As XtraConsole
			Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
				If Console IsNot Nothing Then
					Console.DoPaint(e)
				End If
			End Sub
		End Class
		Public Sub Write(ByVal chunk As String)
			SyncLock SyncRoot
				Me.buffer &= chunk
			End SyncLock
			If Me.IsHandleCreated AndAlso (Not Me.IsDisposed) Then
				Me.BeginInvoke(New EventHandler(AddressOf WriteBuffer), Me, EventArgs.Empty)
			End If
		End Sub

		Friend Sub ClearText()
			'lock(SyncRoot){
			buffer = String.Empty
			'}
			lines.Clear()
			lines.Add(String.Empty)
			paintWin.Width = 0
			paintWin.Height = 0
			Me.Refresh()
		End Sub
	End Class
	Public Class LogWriter
		Inherits TextWriter
        Private _enabled As Boolean = True
        Public Console As XtraConsole
        Public Sub New()
        End Sub
        Public Sub New(ByVal console As XtraConsole)
            Me.New()
            Me.Console = console
        End Sub
        Private enc As Encoding = New UnicodeEncoding(False, False)
        Public Overrides ReadOnly Property Encoding() As Encoding
            Get
                Return enc
            End Get
        End Property
        Public Overloads Overrides Sub Write(ByVal value As String)
            If Console IsNot Nothing AndAlso Enabled Then
                Console.Write(value)
            End If
        End Sub
        Public Overloads Overrides Sub Write(ByVal ch As Char)
            Write(ch.ToString())
        End Sub
        Public Property Enabled() As Boolean
            Get
                Return _enabled
            End Get
            Set(ByVal value As Boolean)
                _enabled = value
                If Console IsNot Nothing Then
                    Console.Enabled = _enabled
                End If
            End Set
        End Property
	End Class
End Namespace
