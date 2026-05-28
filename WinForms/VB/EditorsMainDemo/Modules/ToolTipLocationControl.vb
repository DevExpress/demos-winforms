Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.LookAndFeel.Helpers
Imports DevExpress.XtraEditors

Namespace EditorsTutorials.Modules

    Public Class ToolTipLocationControl
        Inherits XtraUserControl

        Private components As System.ComponentModel.Container = Nothing

        Private fController As ToolTipController = Nothing

        Public Event ToolTipLocationChanged As EventHandler

        Public Sub New()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
            TabStop = True
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property Controller As ToolTipController
            Get
                Return fController
            End Get

            Set(ByVal value As ToolTipController)
                fController = value
                Info.CalcLocation()
            End Set
        End Property

        Private fInfo As ToolTipLocationControlViewInfo

        Public ReadOnly Property Info As ToolTipLocationControlViewInfo
            Get
                If fInfo Is Nothing Then fInfo = New ToolTipLocationControlViewInfo(Me)
                Return fInfo
            End Get
        End Property

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Info.Draw(New GraphicsCache(e), LookAndFeel)
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            Info.CalcBounds()
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            MyBase.OnMouseMove(e)
            Info.CalcHotTrack(e)
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            Info.HotTrackIndex = -1
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseDown(e)
            Info.CalcPressed(e)
        End Sub

        Public Sub RaiseToolTipLocationChanged(ByVal location As ToolTipLocation)
            If Controller Is Nothing Then Return
            Controller.ToolTipLocation = location
            RaiseEvent ToolTipLocationChanged(Me, EventArgs.Empty)
        End Sub

        Public ReadOnly Property ToolTipLocationName As String
            Get
                If Controller Is Nothing Then Return "<none>"
                Return Controller.ToolTipLocation.ToString()
            End Get
        End Property

        Public Class ToolTipLocationControlViewInfo

            Private control As ToolTipLocationControl

            Private args As ArrayList = New ArrayList()

            Private fHotTrackIndex As Integer = -1

            Private locations As ToolTipLocation() = New ToolTipLocation() {ToolTipLocation.TopLeft, ToolTipLocation.TopCenter, ToolTipLocation.TopRight, ToolTipLocation.LeftTop, ToolTipLocation.LeftCenter, ToolTipLocation.LeftBottom, ToolTipLocation.RightTop, ToolTipLocation.RightCenter, ToolTipLocation.RightBottom, ToolTipLocation.BottomLeft, ToolTipLocation.BottomCenter, ToolTipLocation.BottomRight}

            Public Sub New(ByVal control As ToolTipLocationControl)
                Me.control = control
                For i As Integer = 0 To 12 - 1
                    args.Add(New StyleObjectInfoArgs())
                Next

                CalcBounds()
                CalcLocation()
            End Sub

            Private Function ObjectInfoByID(ByVal index As Integer) As StyleObjectInfoArgs
                Return TryCast(args(index), StyleObjectInfoArgs)
            End Function

            Public Sub Draw(ByVal cache As GraphicsCache, ByVal lookAndFeel As UserLookAndFeel)
                For i As Integer = 0 To args.Count - 1
                    ObjectInfoByID(i).Cache = cache
                    lookAndFeel.Painter.Button.DrawObject(ObjectInfoByID(i))
                Next
            End Sub

            Private dx As Integer = 8

            Private ReadOnly Property ElementWidht As Integer
                Get
                    Return(control.Width - dx * 2) \ 3
                End Get
            End Property

            Private ReadOnly Property ElementHeight As Integer
                Get
                    Return control.Height \ 5
                End Get
            End Property

            Public Sub CalcBounds()
                For i As Integer = 0 To 3 - 1
                    ObjectInfoByID(i).Bounds = New Rectangle(dx + ElementWidht * i, 0, ElementWidht, ElementHeight)
                    ObjectInfoByID(3 + i).Bounds = New Rectangle(0, ElementHeight * (i + 1), ElementWidht, ElementHeight)
                    ObjectInfoByID(6 + i).Bounds = New Rectangle(dx * 2 + ElementWidht * 2, ElementHeight * (i + 1), ElementWidht, ElementHeight)
                    ObjectInfoByID(9 + i).Bounds = New Rectangle(dx + ElementWidht * i, ElementHeight * 4, ElementWidht, ElementHeight)
                Next

                control.Refresh()
            End Sub

            Private ReadOnly Property LocationIndex As Integer
                Get
                    If control Is Nothing OrElse control.Controller Is Nothing Then Return -1
                    For i As Integer = 0 To locations.Length - 1
                        If control.Controller.ToolTipLocation.Equals(locations(i)) Then Return i
                    Next

                    Return -1
                End Get
            End Property

            Public Sub CalcLocation()
                Dim index As Integer = LocationIndex
                For i As Integer = 0 To args.Count - 1
                    ObjectInfoByID(i).State = If(index = i, ObjectState.Pressed, ObjectState.Normal)
                Next

                If HotTrackIndex > -1 AndAlso HotTrackIndex <> index Then ObjectInfoByID(HotTrackIndex).State = ObjectState.Hot
                If control Is Nothing OrElse control.Controller Is Nothing Then
                    For i As Integer = 0 To args.Count - 1
                        ObjectInfoByID(i).State = ObjectState.Disabled
                    Next
                End If

                control.Refresh()
            End Sub

            Public Property HotTrackIndex As Integer
                Get
                    Return fHotTrackIndex
                End Get

                Set(ByVal value As Integer)
                    If fHotTrackIndex = value Then Return
                    fHotTrackIndex = value
                    CalcLocation()
                End Set
            End Property

            Private Function IndexByPoint(ByVal p As Point) As Integer
                For i As Integer = 0 To args.Count - 1
                    If ObjectInfoByID(i).Bounds.Contains(p) Then Return i
                Next

                Return -1
            End Function

            Public Sub CalcHotTrack(ByVal e As MouseEventArgs)
                Dim p As Point = New Point(e.X, e.Y)
                HotTrackIndex = IndexByPoint(p)
            End Sub

            Public Sub CalcPressed(ByVal e As MouseEventArgs)
                Dim p As Point = New Point(e.X, e.Y)
                Dim i As Integer = IndexByPoint(p)
                If i > -1 Then
                    control.RaiseToolTipLocationChanged(locations(i))
                    CalcLocation()
                End If
            End Sub
        End Class

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            ' 
            ' ToolTipLocationControl
            ' 
            Name = "ToolTipLocationControl"
            Me.ResumeLayout(False)
        End Sub
    End Class
End Namespace
