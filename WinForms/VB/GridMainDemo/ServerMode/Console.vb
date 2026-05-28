Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports System.IO

Namespace DevExpress.XtraGrid.Demos

    Friend Class XConsole
        Inherits XtraScrollableControl

        Public Sub New()
            Appearance.Options.UseBackColor = True
            Enabled = True
        End Sub

        <DefaultValue(True)>
        Public Overloads Property Enabled As Boolean
            Get
                Return MyBase.Enabled
            End Get

            Set(ByVal value As Boolean)
                MyBase.Enabled = value
                If MyBase.Enabled Then
                    Appearance.BackColor = Color.White
                Else
                    Appearance.BackColor = Color.Gray
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
            paintWin.Console = Me
            lines.Add(String.Empty)
            Appearance.ForeColor = Color.Black
        End Sub

        Private Sub InitializeComponent()
            xtraScrollableControl1 = New XConsole()
            paintWin = New PaintWindow()
            xtraScrollableControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' xtraScrollableControl1
            ' 
            xtraScrollableControl1.Controls.Add(paintWin)
            xtraScrollableControl1.Dock = DockStyle.Fill
            xtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
            xtraScrollableControl1.Name = "xtraScrollableControl1"
            xtraScrollableControl1.Size = New System.Drawing.Size(438, 367)
            xtraScrollableControl1.TabIndex = 0
            ' 
            ' paintWin
            ' 
            paintWin.Location = New System.Drawing.Point(3, 3)
            paintWin.Name = "paintWin"
            paintWin.Size = New System.Drawing.Size(30, 25)
            paintWin.TabIndex = 0
            ' 
            ' XtraConsole
            ' 
            Me.Controls.Add(xtraScrollableControl1)
            Name = "XtraConsole"
            Size = New System.Drawing.Size(438, 367)
            xtraScrollableControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        <DefaultValue(True)>
        Public Overloads Property Enabled As Boolean
            Get
                Return MyBase.Enabled
            End Get

            Set(ByVal value As Boolean)
                MyBase.Enabled = value
                xtraScrollableControl1.Enabled = value
                Refresh()
            End Set
        End Property

        Private lines As List(Of String) = New List(Of String)()

        Private Function CalcStringWidth(ByVal str As String) As Integer
            Dim ginfo As GraphicsInfo = New GraphicsInfo()
            ginfo.AddGraphics(Nothing, ScaleDPI)
            Dim textSize As SizeF = New AppearanceObject(Appearance, DefaultAppearance).CalcTextSize(ginfo.Cache, str, Integer.MaxValue)
            ginfo.ReleaseGraphics()
            Return CInt(Math.Ceiling(textSize.Width))
        End Function

        Private Function GetTextHeight() As Integer
            Dim ginfo As GraphicsInfo = New GraphicsInfo()
            ginfo.AddGraphics(Nothing, ScaleDPI)
            Dim textHeight As Integer = New AppearanceObject(Appearance, DefaultAppearance).CalcDefaultTextSize(ginfo.Cache).Height
            ginfo.ReleaseGraphics()
            Return textHeight
        End Function

        Protected Friend Sub DoPaint(ByVal e As PaintEventArgs)
            Using cache As GraphicsCache = New GraphicsCache(e, ScaleDPI)
                Dim ao As AppearanceObject = New FrozenAppearance(Appearance, DefaultAppearance)
                Dim textHeight = ao.CalcDefaultTextSize(cache).Height
                Dim startLine As Integer = e.ClipRectangle.Top \ textHeight
                If startLine >= lines.Count Then Return
                Dim endLine As Integer = e.ClipRectangle.Bottom \ textHeight + 1
                Dim i As Integer = startLine
                While i < lines.Count AndAlso i <= endLine
                    ao.DrawString(cache, lines(i), New Rectangle(0, i * textHeight, paintWin.Width, textHeight))
                    Threading.Interlocked.Increment(i)
                End While
            End Using
        End Sub

        Private buffer As String = String.Empty

        Private ReadOnly SyncRoot As Object = New Object()

        Private Sub WriteBuffer(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsHandleCreated OrElse IsDisposed Then Return
            Dim str As String
            SyncLock SyncRoot
                str = buffer
                If Equals(str, Nothing) OrElse str.Length = 0 Then Return
                buffer = String.Empty
            End SyncLock

            str = str.Replace(Microsoft.VisualBasic.Constants.vbCrLf, Microsoft.VisualBasic.Constants.vbLf)
            str = str.Replace(Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbCr, Microsoft.VisualBasic.Constants.vbLf)
            str = str.Replace(Microsoft.VisualBasic.Strings.ChrW(13), Microsoft.VisualBasic.Strings.ChrW(10))
            Dim nonFirst As Boolean = False
            Dim linesAdded As Boolean = False
            For Each line As String In str.Split(Microsoft.VisualBasic.Strings.ChrW(10))
                If nonFirst Then
                    lines.Add(String.Empty)
                    linesAdded = True
                Else
                    nonFirst = True
                End If

                Dim pos As Integer = lines.Count - 1
                Dim newValue As String = lines(pos) & line
                lines(pos) = newValue
                Dim _width As Integer = CalcStringWidth(newValue)
                If _width >= paintWin.Width Then paintWin.Width = _width + 1
            Next

            If linesAdded Then
                paintWin.Height = lines.Count * GetTextHeight()
                If AutoScrollToEnd AndAlso paintWin.Height > xtraScrollableControl1.ClientRectangle.Height Then
                    xtraScrollableControl1.AutoScrollPosition = New Point(0, 2 + paintWin.Height - xtraScrollableControl1.ClientRectangle.Height)
                End If
            End If

            paintWin.Invalidate()
        End Sub

        Public AutoScrollToEnd As Boolean = True

        Private Class PaintWindow
            Inherits Control

            Public Console As XtraConsole

            Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
                If Console IsNot Nothing Then Console.DoPaint(e)
            End Sub
        End Class

        Public Sub Write(ByVal chunk As String)
            SyncLock SyncRoot
                buffer += chunk
            End SyncLock

            If IsHandleCreated AndAlso Not IsDisposed Then
                BeginInvoke(New EventHandler(AddressOf WriteBuffer), Me, EventArgs.Empty)
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
            Refresh()
        End Sub
    End Class

    Public Class LogWriter
        Inherits TextWriter

        Private enabledCore As Boolean = True

        Public Console As XtraConsole

        Public Sub New()
        End Sub

        Public Sub New(ByVal console As XtraConsole)
            Me.New()
            Me.Console = console
        End Sub

        Private enc As Encoding = New UnicodeEncoding(False, False)

        Public Overrides ReadOnly Property Encoding As Encoding
            Get
                Return enc
            End Get
        End Property

        Public Overrides Sub Write(ByVal value As String)
            If Console IsNot Nothing AndAlso Enabled Then
                Console.Write(value)
            End If
        End Sub

        Public Overrides Sub Write(ByVal ch As Char)
            Write(ch.ToString())
        End Sub

        Public Property Enabled As Boolean
            Get
                Return enabledCore
            End Get

            Set(ByVal value As Boolean)
                enabledCore = value
                If Console IsNot Nothing Then Console.Enabled = enabledCore
            End Set
        End Property
    End Class
End Namespace
