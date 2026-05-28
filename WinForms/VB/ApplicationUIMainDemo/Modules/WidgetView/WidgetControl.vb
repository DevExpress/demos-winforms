Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Win.Gauges.State

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class WidgetControl
        Inherits XtraEditors.XtraUserControl

        Private updateTimer As Timer = New Timer()

        Private ReadOnly Shared Positive As SolidBrush = New SolidBrush(Color.FromArgb(70, 158, 165))

        Private ReadOnly Shared Negative As SolidBrush = New SolidBrush(Color.FromArgb(165, 70, 113))

        Public Sub New()
            InitializeComponent()
            If components IsNot Nothing Then components.Add(updateTimer)
            updateTimer.Interval = 1000
            AddHandler updateTimer.Tick, AddressOf OnTimerTick
            updateTimer.Start()
            OnTimerTick(Me, EventArgs.Empty)
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property CompanyNameText As String
            Get
                Return labelControl1.Text
            End Get

            Set(ByVal value As String)
                labelControl1.Text = value
            End Set
        End Property

        Private index As Integer = 0

        Private previousData As StockData

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If IsDisposed Then
                updateTimer.Stop()
                Return
            End If

            Dim data As StockData = GetData(index)
            If index > 0 Then
                Dim d As Decimal = data.ClosePrice - previousData.ClosePrice
                Dim dq As Decimal = d * 100 / data.ClosePrice
                labelControl5.Text = Math.Round(d, 2, MidpointRounding.ToEven).ToString("G29")
                stateIndicatorComponent1.StateIndex = If(previousData.ClosePrice - data.ClosePrice < 0, 0, 1)
                If stateIndicatorComponent1.StateIndex = 0 Then
                    labelControl5.ForeColor = Positive.Color
                    labelControl2.Text = data.ClosePrice.ToString("G29") & "<br><color=70,158,165>" & Math.Round(dq, 2, MidpointRounding.ToEven).ToString("G29") & "%"c
                Else
                    labelControl5.ForeColor = Negative.Color
                    labelControl2.Text = data.ClosePrice.ToString("G29") & "<br><color=165,70,113>" & Math.Round(dq, 2, MidpointRounding.ToEven).ToString("G29") & "%"c
                End If
            End If

            previousData = data
            index += 1
        End Sub

        Private Sub OnCustomDrawElement(ByVal sender As Object, ByVal e As XtraGauges.Core.Primitive.CustomDrawElementEventArgs)
            Dim indicator As StateIndicatorComponent = TryCast(sender, StateIndicatorComponent)
            Dim p1 As Point = Point.Empty
            Dim p2 As Point = Point.Empty
            Dim p3 As Point = Point.Empty
            Dim _height As Integer = CInt(e.Info.BoundBox.Width * Math.Sqrt(3) / 2)
            p1.X = CInt((CInt(e.Info.BoundBox.Width) \ 2))
            p2.X = CInt(e.Info.BoundBox.Left)
            p3.X = CInt(e.Info.BoundBox.Right)
            Dim y As Integer = CInt((CInt(e.Info.BoundBox.Height - _height) \ 2))
            If indicator.StateIndex = 0 Then
                p1.Y = y
                p3.Y = y + _height
                p2.Y = p3.Y
            Else
                p1.Y = y + _height
                p3.Y = y
                p2.Y = p3.Y
            End If

            e.Context.Graphics.FillPolygon(If(indicator.StateIndex = 0, Positive, Negative), New Point() {p1, p2, p3})
            e.Handled = True
        End Sub
    End Class
End Namespace
