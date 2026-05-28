Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports System.ComponentModel

Namespace DevExpress.HTML.Demos

    Public Partial Class Lab
        Inherits TutorialControl

        Private ReadOnly htmlStartText As String = String.Empty

        Private ReadOnly cssStartText As String = String.Empty

        Public Sub New()
            InitializeComponent()
            htmlCodeViewer.Template = htmlContentControl.HtmlTemplate.Template
            cssCodeViewer.Styles = htmlContentControl.HtmlTemplate.Styles
            htmlStartText = htmlCodeViewer.Template
            cssStartText = cssCodeViewer.Styles
            htmlCodeViewer.ReadOnly = False
            cssCodeViewer.ReadOnly = False
            htmlCodeViewer.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            cssCodeViewer.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            AddHandler htmlCodeViewer.CodeChanged, AddressOf OnHtmlCodeViewerCodeChanged
            AddHandler cssCodeViewer.CodeChanged, AddressOf OnCssCodeViewerCodeChanged
            htmlContentControl.IsTemplateEditing = True
            AddHandler htmlContentControl.MouseMove, AddressOf HtmlContentControl_MouseMove
            AddHandler htmlContentControl.MouseLeave, AddressOf HtmlContentControl_MouseLeave
            AddHandler htmlContentControl.MouseDoubleClick, AddressOf HtmlContentControl_MouseDoubleClick
            AddHandler htmlContentControl.PaintEx, AddressOf HtmlContentControl_PaintEx
            htmlCodeViewer.AllowCodeFolding = DefaultBoolean.True
            htmlCodeViewer.ShowIndentGuides = DefaultBoolean.True
            htmlCodeViewer.ShowLineNumbers = DefaultBoolean.True
            cssCodeViewer.AllowCodeFolding = DefaultBoolean.True
            cssCodeViewer.ShowIndentGuides = DefaultBoolean.True
            cssCodeViewer.ShowLineNumbers = DefaultBoolean.True
            delayTimer.Interval = 100
            AddHandler delayTimer.Tick, AddressOf delayTimer_Tick
        End Sub

        Public Sub FocusHtml()
            htmlCodeViewer.Focus()
        End Sub

        Private htmlChanged As Boolean = False

        Private cssChanged As Boolean = False

        Private Sub delayTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            delayTimer.Stop()
            If htmlChanged Then htmlContentControl.HtmlTemplate.Template = htmlCodeViewer.Template
            If cssChanged Then
                htmlContentControl.HtmlTemplate.Styles = cssCodeViewer.Styles
                customParser.Parse(cssCodeViewer.Styles)
                cssCodeViewer.SetErrors(customParser.Exceptions)
            End If

            htmlChanged = False
            cssChanged = False
        End Sub

        Private customParser As CssParser = New CssParser()

        Private Sub RestartUpdateDelay()
            delayTimer.Stop()
            delayTimer.Start()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Template As String
            Get
                Return htmlCodeViewer.Template
            End Get

            Set(ByVal value As String)
                htmlCodeViewer.Template = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Styles As String
            Get
                Return cssCodeViewer.Styles
            End Get

            Set(ByVal value As String)
                cssCodeViewer.Styles = value
            End Set
        End Property

        Private Sub OnCssCodeViewerCodeChanged(ByVal sender As Object, ByVal e As EventArgs)
            cssChanged = True
            RestartUpdateDelay()
            Dim classes = cssCodeViewer.GetClasses()
            htmlCodeViewer.SetAvailableStyles(classes.Keys)
        End Sub

        Private Sub OnHtmlCodeViewerCodeChanged(ByVal sender As Object, ByVal e As EventArgs)
            htmlChanged = True
            RestartUpdateDelay()
        End Sub

        Private Sub HtmlContentControl_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitInfo = htmlContentControl.CalcHitInfo(e.Location)
            If hitInfo IsNot Nothing AndAlso hitInfo.Element IsNot Nothing Then htmlCodeViewer.NavigateToPosition(hitInfo.Element.PositionInCode)
        End Sub

        Private Sub HtmlContentControl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hotInfo = htmlContentControl.CalcHitInfo(e.Location)
            If String.Equals(hotInfo.Element?.Id, "container") Then hotInfo = Nothing
            Me.HotInfo = hotInfo
        End Sub

        Private Sub HtmlContentControl_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            HotInfo = Nothing
        End Sub

        Private hotInfoField As DxHtmlHitInfo

        Private Property HotInfo As DxHtmlHitInfo
            Get
                Return hotInfoField
            End Get

            Set(ByVal value As DxHtmlHitInfo)
                If hotInfoField Is value Then Return
                hotInfoField = value
                OnHotInfoChanged()
            End Set
        End Property

        Private Sub OnHotInfoChanged()
            If HotInfo IsNot Nothing AndAlso HotInfo.Element IsNot Nothing Then
                htmlContentControl.Invalidate()
                htmlCodeViewer.SetHotTrackPosition(HotInfo.Element.PositionInCode)
            Else
                htmlCodeViewer.SetHotTrackPosition(-1)
            End If
        End Sub

        Private Sub HtmlContentControl_PaintEx(ByVal sender As Object, ByVal e As XtraGrid.PaintExEventArgs)
            If HotInfo IsNot Nothing AndAlso HotInfo.Element IsNot Nothing Then
                If HotInfo.IsContainer Then
                    For n As Integer = 0 To HotInfo.ContainerElementBounds.Length - 1
                        Call SelectionPainter.Default.Draw(e.Cache, LookAndFeel, HotInfo.ContainerElementBounds(n))
                    Next
                Else
                    Call SelectionPainter.Default.Draw(e.Cache, LookAndFeel, HotInfo.Bounds)
                End If
            End If
        End Sub

        Private Sub resetButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            htmlCodeViewer.Template = htmlStartText
            cssCodeViewer.Styles = cssStartText
        End Sub
    End Class

    Friend Class CustomHtmlControl
        Inherits HtmlContentControl

        Private exception As Exception

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            If DrawException(e) Then Return
            Try
                MyBase.OnPaint(e)
            Catch ex As Exception
                exception = ex
                DrawException(e)
            End Try
        End Sub

        Private Function DrawException(ByVal e As PaintEventArgs) As Boolean
            If exception Is Nothing Then Return False
            e.Graphics.Clear(Color.White)
            Using pen As Pen = New Pen(Brushes.Red, 2)
                Dim clientRectangle As Rectangle = Me.ClientRectangle
                Dim rectangle As Rectangle = clientRectangle
                rectangle.X += 1
                rectangle.Y += 1
                rectangle.Width -= 1
                rectangle.Height -= 1
                e.Graphics.DrawRectangle(pen, New Rectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height))
                e.Graphics.DrawLine(pen, New Point(clientRectangle.Left, clientRectangle.Top), New Point(clientRectangle.Right, clientRectangle.Bottom))
                e.Graphics.DrawLine(pen, New Point(clientRectangle.Left, clientRectangle.Bottom), New Point(clientRectangle.Right, clientRectangle.Top))
            End Using

            e.Graphics.DrawString(exception.ToString(), Font, Brushes.Black, 0, 0)
            Return True
        End Function
    End Class
End Namespace
