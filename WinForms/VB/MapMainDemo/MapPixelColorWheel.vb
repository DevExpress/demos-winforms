Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ColorWheel

Namespace DevExpress.XtraMap.Demos

    Public Class ColorPickerForm
        Inherits XtraForm

        Private ReadOnly components As System.ComponentModel.IContainer = Nothing

        Private colorWheel1 As PixelMapColorWheelControl

        Private buttonOk As SimpleButton

        Private buttonCancel As SimpleButton

        Public Event ColorChanged As ColorChangedEventHandler

        Public ReadOnly Property ColorWheel As ColorWheelControl
            Get
                Return colorWheel1
            End Get
        End Property

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Public Sub New(ByVal pointDensity As Integer)
            InitializeComponent()
            colorWheel1.Prepare(pointDensity)
        End Sub

        Private Sub InitializeComponent()
            buttonOk = New SimpleButton()
            buttonCancel = New SimpleButton()
            colorWheel1 = New PixelMapColorWheelControl()
            SuspendLayout()
            ' 
            ' buttonOk
            ' 
            buttonOk.Location = New System.Drawing.Point(40, 235)
            buttonOk.Name = "buttonOk"
            buttonOk.Size = New System.Drawing.Size(60, 20)
            buttonOk.TabIndex = 1
            buttonOk.Text = "OK"
            AddHandler buttonOk.Click, New EventHandler(AddressOf ButtonOk_Click)
            ' 
            ' buttonCancel
            ' 
            buttonCancel.Location = New System.Drawing.Point(140, 235)
            buttonCancel.Name = "buttonCancel"
            buttonCancel.Size = New System.Drawing.Size(60, 20)
            buttonCancel.TabIndex = 2
            buttonCancel.Text = "Cancel"
            AddHandler buttonCancel.Click, New EventHandler(AddressOf ButtonCancel_Click)
            ' 
            ' colorWheel1
            ' 
            colorWheel1.BackColor = System.Drawing.Color.Transparent
            colorWheel1.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            colorWheel1.Color = System.Drawing.Color.FromArgb(255, 255, 255)
            colorWheel1.Location = New System.Drawing.Point(20, 20)
            colorWheel1.Name = "colorWheel1"
            colorWheel1.Size = New System.Drawing.Size(195, 195)
            colorWheel1.TabIndex = 0
            colorWheel1.Text = "button1"
            AddHandler colorWheel1.ColorChanged, New EventHandler(AddressOf OnColorChanged)
            ' 
            ' ColorWheelForm
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            AutoScaleMode = AutoScaleMode.Dpi
            ClientSize = New System.Drawing.Size(240, 270)
            Controls.Add(colorWheel1)
            Controls.Add(buttonOk)
            Controls.Add(buttonCancel)
            FormBorderStyle = FormBorderStyle.FixedToolWindow
            Name = "ColorWheelForm"
            Text = "Pixel Map Color Wheel"
            ResumeLayout(False)
        End Sub

        Private Sub ButtonCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        Private Sub ButtonOk_Click(ByVal sender As Object, ByVal e As EventArgs)
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub OnColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent ColorChanged(Me, New ColorChangedEventArgs(colorWheel1.Color))
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Public Delegate Sub ColorChangedEventHandler(ByVal sender As Object, ByVal args As ColorChangedEventArgs)

        Public Class ColorChangedEventArgs
            Inherits EventArgs

            Private ReadOnly colorField As Color

            Public ReadOnly Property Color As Color
                Get
                    Return colorField
                End Get
            End Property

            Public Sub New(ByVal color As Color)
                colorField = color
            End Sub
        End Class
    End Class

    Public Class PixelMapColorWheelControl
        Inherits ColorWheelControl

        Const intervalKoef As Double = 2.3

        Private supressRaiseColorChanged As Boolean

        Private timer As Timer

        Private ReadOnly _colorChanged As EventHandler = Nothing

        Public Shadows Custom Event ColorChanged As EventHandler
            AddHandler(ByVal value As EventHandler)
                Events.AddHandler(_colorChanged, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                Events.RemoveHandler(_colorChanged, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event

        Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            supressRaiseColorChanged = False
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            MyBase.OnMouseMove(e)
            supressRaiseColorChanged = True
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            timer.Start()
            MyBase.OnMouseDown(e)
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            supressRaiseColorChanged = False
            timer.Stop()
            MyBase.OnMouseUp(e)
        End Sub

        Protected Overrides Sub RaiseOnColorChanged()
            If Not supressRaiseColorChanged Then
                Dim handler As EventHandler = TryCast(Events(_colorChanged), EventHandler)
                If handler IsNot Nothing Then
                    handler(Me, EventArgs.Empty)
                End If
            End If
        End Sub

        Public Sub Prepare(ByVal pointsDensity As Integer)
            timer = New Timer() With {.Interval = CInt(pointsDensity * intervalKoef)}
            AddHandler timer.Tick, AddressOf Timer_Tick
        End Sub
    End Class
End Namespace
