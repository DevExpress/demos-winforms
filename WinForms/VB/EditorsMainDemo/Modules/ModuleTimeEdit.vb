Imports System
Imports System.ComponentModel
Imports System.Drawing
' <radioGroupHourFormat>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Tutorials

' </radioGroupHourFormat>
Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleTimeEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleTimeEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "timeedit"
            End Get
        End Property

        Private Sub ModuleTimeEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(timeEditSample)
            timeEditSample.Time = New DateTime(2005, 01, 07, 22, 54, 32)
            SetTimeFormat()
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        ' <comboBoxTimeFormat>
        ' <radioGroupHourFormat> <teMask>
        Private Sub SetTimeFormat()
            Dim timeFormats As String() = New String() {"hh:mm:ss tt", "hh:mm tt", "hh tt", "HH:mm:ss", "HH:mm", "HH"}
            Dim index As Integer = comboBoxTimeFormat.SelectedIndex + radioGroupHourFormat.SelectedIndex * 3
            timeEditSample.Properties.Mask.EditMask = timeFormats(index)
            teMask.Text = timeEditSample.Properties.Mask.EditMask
        End Sub

        ' </comboBoxTimeFormat> </teMask>
        Private Sub radioGroupHourFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetTimeFormat()
        End Sub

        ' </radioGroupHourFormat>
        ' <comboBoxTimeFormat>
        Private Sub comboBoxTimeFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetTimeFormat()
        End Sub

        ' </comboBoxTimeFormat>
        ' <comboBoxTimeEditStyle>
        Private Sub comboBoxTimeEditStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxTimeEditStyle.SelectedIndex = 0 Then
                timeEditSample.Properties.TimeEditStyle = TimeEditStyle.SpinButtons
            Else
                timeEditSample.Properties.TimeEditStyle = TimeEditStyle.TouchUI
            End If
        End Sub
    ' </comboBoxTimeEditStyle>
    End Class
End Namespace
