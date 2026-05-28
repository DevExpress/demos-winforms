Imports System
Imports System.ComponentModel
Imports System.Drawing
' <ceShowCustomButtons>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleCalcEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleCalcEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "calcedit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleCalcEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(calcEditSample)
            InitValues()
        End Sub

        Private Sub InitValues()
            updateValues = True
            sePrecision.Value = calcEditSample.Properties.Precision
            ceShowCloseButton.Checked = calcEditSample.Properties.ShowCloseButton
            ShowCustomButtons(ceShowCustomButtons.Checked)
            updateValues = False
        End Sub

        ' <sePrecision>
        Private Sub sePrecision_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            calcEditSample.Properties.Precision = Convert.ToInt32(sePrecision.Value)
        End Sub

        ' </sePrecision>
        ' <ceShowCloseButton>
        Private Sub ceShowCloseButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            calcEditSample.Properties.ShowCloseButton = ceShowCloseButton.Checked
        End Sub

        ' </ceShowCloseButton>
        ' <calcEditSample>
        Private Sub calcEditSample_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            If e.Button.Tag Is Nothing Then Return
            Select Case e.Button.Tag.ToString()
                Case "involution2"
                    Try
                        calcEditSample.Value *= calcEditSample.Value
                    Catch ex As Exception
                        XtraMessageBox.Show(FindForm(), ex.Message, "Error")
                    End Try

                Case "clear"
                    calcEditSample.Value = 0
            End Select
        End Sub

        ' </calcEditSample>
        ' <ceShowCustomButtons>
        Private Sub ceShowCustomButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ShowCustomButtons(ceShowCustomButtons.Checked)
        End Sub

        Private Sub ShowCustomButtons(ByVal show As Boolean)
            For Each button As EditorButton In calcEditSample.Properties.Buttons
                If button.Tag IsNot Nothing Then button.Visible = show
            Next
        End Sub
    ' </ceShowCustomButtons>
    End Class
End Namespace
