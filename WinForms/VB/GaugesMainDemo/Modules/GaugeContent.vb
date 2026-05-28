Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Base

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class GaugeContent
        Inherits XtraUserControl

        Private stateCore As ObjectState

        Private colorCore As Color

        Public Sub New()
            InitializeComponent()
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            InitGauge()
            stateCore = ObjectState.Normal
            colorCore = Color.Empty
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            RemoveHandler arcScaleComponent1.Animating, AddressOf OnAnimating
            RemoveHandler gaugeControl.MouseEnter, AddressOf OnMouseEnter
            RemoveHandler gaugeControl.MouseLeave, AddressOf OnMouseLeave
            RemoveHandler gaugeControl.GotFocus, AddressOf OnGotFocus
            RemoveHandler gaugeControl.LostFocus, AddressOf OnLostFocus
            timer.Stop()
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitGauge()
            arcScaleComponent1.EasingFunction = New CubicEase()
            arcScaleComponent1.EasingMode = EasingMode.EaseOut
            arcScaleComponent1.EnableAnimation = True
            AddHandler arcScaleComponent1.Animating, AddressOf OnAnimating
            AddHandler gaugeControl.MouseLeave, AddressOf OnMouseLeave
            AddHandler gaugeControl.GotFocus, AddressOf OnGotFocus
            AddHandler gaugeControl.LostFocus, AddressOf OnLostFocus
            AddHandler gaugeControl.MouseEnter, AddressOf OnMouseEnter
        End Sub

        Private Sub UpdateState()
            Invalidate()
            Update()
        End Sub

        Private Overloads Sub OnLostFocus(ByVal sender As Object, ByVal e As EventArgs)
            Selected = False
            UpdateState()
        End Sub

        Public ReadOnly Property Gauge As GaugeControl
            Get
                Return gaugeControl
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Caption As String
            Get
                Return labelControl1.Text
            End Get

            Set(ByVal value As String)
                labelControl1.Text = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Color As Color
            Get
                Return gaugeControl.ColorScheme.Color
            End Get

            Set(ByVal value As Color)
                If Not colorCore.IsEmpty AndAlso colorCore <> gaugeControl.ColorScheme.Color Then Return
                colorCore = value
                gaugeControl.ColorScheme.Color = colorCore
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Image As Image
            Get
                Return imageIndicatorComponent.Image
            End Get

            Set(ByVal value As Image)
                imageIndicatorComponent.Image = value
            End Set
        End Property

        Private Overloads Sub OnGotFocus(ByVal sender As Object, ByVal e As EventArgs)
            Selected = True
            UpdateState()
        End Sub

        Private Overloads Sub OnMouseEnter(ByVal sender As Object, ByVal e As EventArgs)
            Hot = True
            UpdateState()
        End Sub

        Private Overloads Sub OnMouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            Hot = False
            UpdateState()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overridable Property Hot As Boolean
            Get
                Return GetState(ObjectState.Hot)
            End Get

            Set(ByVal value As Boolean)
                SetState(ObjectState.Hot, value)
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overridable Property Selected As Boolean
            Get
                Return GetState(ObjectState.Selected)
            End Get

            Set(ByVal value As Boolean)
                SetState(ObjectState.Selected, value)
                Dim gaugesDashboard = GetParent(Parent)
                If Selected AndAlso gaugesDashboard IsNot Nothing Then gaugesDashboard.UpdateColor(Color)
            End Set
        End Property

        Private Function GetParent(ByVal parent As Control) As GaugesDashboard
            If parent Is Nothing Then Return Nothing
            If TypeOf parent Is GaugesDashboard Then Return TryCast(parent, GaugesDashboard)
            Return GetParent(parent.Parent)
        End Function

        Private Sub SetState(ByVal state As ObjectState, ByVal value As Boolean)
            If value Then
                stateCore = stateCore Or state
            Else
                stateCore = stateCore And Not state
            End If
        End Sub

        Private Function GetState(ByVal state As ObjectState) As Boolean
            Return(stateCore And state) <> 0
        End Function

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            DrawBackground(e)
        End Sub

        Private Sub DrawBackground(ByVal e As PaintEventArgs)
            Dim rect As Rectangle = ClientRectangle
            rect.Height -= Padding.Vertical
            rect.X += Padding.Left
            rect.Y += Padding.Top - 10
            rect.Width -= Padding.Horizontal
            Dim skin As Skin = CommonSkins.GetSkin(LookAndFeel)
            Dim elementInfo As SkinElementInfo = New SkinElementInfo(skin(CommonSkins.SkinLayoutItemBackground), rect)
            If Selected Then elementInfo.ImageIndex = 2
            If Hot Then elementInfo.ImageIndex = 1
            Using cache As GraphicsCache = New GraphicsCache(e.Graphics, ScaleDPI)
                Call ObjectPainter.DrawObject(cache, SkinElementPainter.Default, elementInfo)
            End Using
        End Sub

#Region "Animation"
        Private Sub OnAnimating(ByVal sender As Object, ByVal e As EventArgs)
            Dim ea As ValueChangedEventArgs = TryCast(e, ValueChangedEventArgs)
            If ea IsNot Nothing Then labelComponent1.Text = ea.Value.ToString("F0")
        End Sub

        Private animationLockCounterCore As Integer = 0

        Private timer As Timer

        Private ReadOnly Property IsAnimationLocked As Boolean
            Get
                Return animationLockCounterCore > 0
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            timer = New Timer()
            timer.Interval = Data.Utils.NonCryptographicRandom.Default.Next(2000, 2400)
            AddHandler timer.Tick, New EventHandler(AddressOf OnTimerTick)
            timer.Start()
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If Not timer.Enabled Then Return
            If IsAnimationLocked Then Return
            LockAnimation()
            DoAnimation(gaugeControl)
            UnlockAnimation()
        End Sub

        Private Sub UnlockAnimation()
            animationLockCounterCore -= 1
        End Sub

        Private Sub LockAnimation()
            animationLockCounterCore += 1
        End Sub

        Private Sub DoAnimation(ByVal gauge As GaugeControl)
            For Each gb As IGauge In gauge.Gauges
                Dim cGauge As ICircularGauge = TryCast(gb, ICircularGauge)
                If cGauge IsNot Nothing Then
                    For Each _scale As IScale In cGauge.Scales
                        _scale.Value = AnimateScaleValue(_scale)
                    Next
                End If
            Next
        End Sub

        Private Function AnimateScaleValue(ByVal scale As IScale) As Single
            Return Data.Utils.NonCryptographicRandom.System.Next(0, 100)
        End Function
#End Region
    End Class
End Namespace
