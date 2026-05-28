Imports DevExpress.Utils.Design
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Utils
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraNavBar.Demos

    Public Partial Class Office365MailViewer
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            statusPanelItem.Visibility = LayoutVisibility.Never
            If Not DesignTimeTools.IsDesignMode Then
                AddHandler LookAndFeel.ActiveLookAndFeel.StyleChanged, AddressOf OnLookAndFeelStyleChanged
                timer = CreateTimer()
            End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Not DesignTimeTools.IsDesignMode Then UpdateChildControlsAppearances()
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not DesignTimeTools.IsDesignMode Then RemoveHandler LookAndFeel.ActiveLookAndFeel.StyleChanged, AddressOf OnLookAndFeelStyleChanged
                If timer IsNot Nothing Then
                    timer.Stop()
                    timer.Dispose()
                    timer = Nothing
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub OnLookAndFeelStyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateChildControlsAppearances()
        End Sub

        Protected Sub UpdateChildControlsAppearances()
            richEdit.Appearance.Text.ForeColor = ForeColor
            richEdit.Document.SetPageBackground(BackColor)
            mailStatusPanel1.SetColors(BackColor, ForeColor)
        End Sub

        Private message As Message

        Private timer As Timer

        Private Function CreateTimer() As Timer
            Dim tmr As Timer = New Timer()
            tmr.Interval = 100
            AddHandler tmr.Tick, AddressOf OnTimerTick
            Return tmr
        End Function

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            timer.Stop()
            ShowMessageCore()
        End Sub

        Protected Friend Overridable Sub ShowMessage(ByVal message As Message)
            If Me.message Is message Then Return
            Me.message = message
            If timer IsNot Nothing Then
                timer.Stop()
                timer.Start()
            End If
        End Sub

        Private Sub ShowMessageCore()
            If message Is Nothing Then Return
            Try
                layoutControl1.BeginUpdate()
                labelSubject.Text = message.Subject
                labelFrom.Text = message.From
                labelDate.Text = message.Date.ToString()
                Dim isHighPriority As Boolean = message.Priority = 2
                statusPanelItem.Visibility = If(isHighPriority, LayoutVisibility.Always, LayoutVisibility.Never)
                Dim photo As Image = DataHelper.GetPhotoByEmail(message.Email)
                layoutPictureItem.Spacing = New XtraLayout.Utils.Padding(If(photo Is Nothing, 12, 0))
                If photo Is Nothing Then
                    pePhoto.Image = CreateSenderImage(message.From, pePhoto.Size, pePhoto.LookAndFeel.ActiveLookAndFeel)
                Else
                    pePhoto.Image = photo
                End If

                richEdit.MhtText = message.Text
                UpdateChildControlsAppearances()
            Finally
                layoutControl1.EndUpdate()
            End Try
        End Sub
    End Class

    Public Class MailStatusPanel
        Inherits Control

        Public Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            label = New LabelControl()
            label.Text = Message
            label.BackColor = Color.Transparent
            label.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25F)
            Controls.Add(label)
            OnLayoutChanged()
        End Sub

        Private label As LabelControl

        Private horzPadding As Integer = 20

        Private panelSize As Integer = 5

        Protected Overrides Sub ScaleControl(ByVal factor As SizeF, ByVal specified As BoundsSpecified)
            MyBase.ScaleControl(factor, specified)
            panelSize = CInt(factor.Width * panelSize)
            horzPadding = CInt(factor.Width * horzPadding)
            OnLayoutChanged()
        End Sub

        Const Message As String = "This message was sent with high importance."

        Private _backColor As Color = Color.Empty

        Private _foreColor As Color = Color.Black

        Private _lineColor As Color = Color.Empty

        Public Sub SetColors(ByVal backColor As Color, ByVal foreColor As Color)
            _backColor = MixColors(backColor, foreColor, 0.9)
            label.ForeColor = MixColors(backColor, foreColor, 0.25)
            _lineColor = MixColors(backColor, foreColor, 0.65)
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            OnLayoutChanged()
            Invalidate()
        End Sub

        Private Sub OnLayoutChanged()
            label.Location = New Point(horzPadding, (Height - label.Height) \ 2)
        End Sub

        Protected Function MixColors(ByVal backColor As Color, ByVal foreColor As Color, ByVal value As Double) As Color
            Dim r As Integer = CInt(value * backColor.R + foreColor.R * (1.0 - value))
            Dim g As Integer = CInt(value * backColor.G + foreColor.G * (1.0 - value))
            Dim b As Integer = CInt(value * backColor.B + foreColor.B * (1.0 - value))
            Return Color.FromArgb(r, g, b)
        End Function

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            Using cache As GraphicsCache = New GraphicsCache(e)
                e.Graphics.Clear(_backColor)
                cache.FillRectangle(_lineColor, New Rectangle(0, 0, panelSize, Height))
            End Using
        End Sub
    End Class
End Namespace
