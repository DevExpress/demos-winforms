Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010

Namespace DevExpress.XtraEditors.Demos.Modules

    Public Partial Class TimerControl
        Inherits XtraUserControl

        Private _timeValue As TimeSpan

        Private startButton, cancelButton As WindowsUIButton

        Public Sub New()
            InitializeComponent()
            startButton = CType(windowsUIButtonPanelStart.Buttons(0), WindowsUIButton)
            cancelButton = CType(windowsUIButtonPanelCancel.Buttons(0), WindowsUIButton)
            TimeValue = TimeSpan.FromMinutes(1)
        End Sub

        Private Property TimeValue As TimeSpan
            Get
                Return _timeValue
            End Get

            Set(ByVal value As TimeSpan)
                If _timeValue <> value Then
                    _timeValue = value
                    timeLabel.Text = value.ToString("mm\:ss\:ff")
                End If
            End Set
        End Property

        Private Sub Reset()
            timer.Stop()
            timeLabel.Appearance.ForeColor = Color.CornflowerBlue
            TimeValue = TimeSpan.FromMinutes(1)
        End Sub

        Private Sub OnButtonClick(ByVal sender As Object, ByVal e As ButtonEventArgs)
            Dim btn As WindowsUIButton = TryCast(e.Button, WindowsUIButton)
            ToggleButtonState()
            If Equals(btn.Caption, "Start") Then
                timer.Start()
            Else
                Reset()
            End If
        End Sub

        Private Sub ToggleButtonState()
            cancelButton.Enabled = Not cancelButton.Enabled
            startButton.Enabled = Not startButton.Enabled
        End Sub

        Private Sub OnTick(ByVal sender As Object, ByVal e As EventArgs)
            TimeValue = TimeValue.Subtract(TimeSpan.FromMilliseconds(timer.Interval))
            If TimeValue.TotalMilliseconds = 0 Then
                timer.Stop()
                timeLabel.Appearance.ForeColor = Color.Red
            End If
        End Sub
    End Class
End Namespace
