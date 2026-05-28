Imports System
Imports System.ComponentModel
Imports System.Drawing
' <icbColorAlignment>
Imports DevExpress.Utils
' <icbColorText>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleColorEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleColorEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "coloredit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleColorEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            Tutorials.ControlUtils.CenterControlInParent(colorEditSample)
            InitComboBoxes()
            InitValues()
            InitMagnifierBehavior()
        End Sub

        Private Sub InitMagnifierBehavior()
            behaviorManager1.Attach(Of Behaviors.MagnifierBehavior)(colorEditSample, Sub(s) s.Properties.ShowPixelGrid = True)
        End Sub

        Private Sub InitComboBoxes()
            ' <icbColorDialogType>
            icbColorDialogType.Properties.Items.AddEnum(GetType(ColorDialogType))
            ' </icbColorDialogType>
            ' <icbColorText>
            icbColorText.Properties.Items.AddEnum(GetType(ColorText))
            ' </icbColorText>
            ' <icbColorAlignment>
            icbColorAlignment.Properties.Items.AddEnum(GetType(HorzAlignment))
        ' </icbColorAlignment>
        End Sub

        Private Sub InitValues()
            updateValues = True
            icbColorAlignment.EditValue = colorEditSample.Properties.ColorAlignment
            icbColorText.EditValue = colorEditSample.Properties.ColorText
            icbColorDialogType.EditValue = colorEditSample.Properties.ColorDialogType
            ceShowColorDialog.Checked = colorEditSample.Properties.ShowColorDialog
            ceAsInteger.Checked = colorEditSample.Properties.StoreColorAsInteger
            updateValues = False
        End Sub

        ' <icbColorAlignment>
        Private Sub icbColorAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            colorEditSample.Properties.ColorAlignment = CType(icbColorAlignment.EditValue, HorzAlignment)
        End Sub

        ' </icbColorAlignment>
        ' <icbColorText>
        Private Sub icbColorText_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            colorEditSample.Properties.ColorText = CType(icbColorText.EditValue, ColorText)
        End Sub

        ' </icbColorText>
        ' <icbColorDialogType>
        Private Sub icbColorDialogType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            colorEditSample.Properties.ColorDialogType = CType(icbColorDialogType.EditValue, ColorDialogType)
        End Sub

        ' </icbColorDialogType>
        ' <ceShowColorDialog>
        Private Sub ceShowColorDialog_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            colorEditSample.Properties.ShowColorDialog = ceShowColorDialog.Checked
        End Sub

        ' </ceShowColorDialog>
        ' <ceAsInteger>
        Private Sub ceIsInteger_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            colorEditSample.Properties.StoreColorAsInteger = ceAsInteger.Checked
        End Sub

        ' </ceAsInteger>
        Private Sub SetButtonEnabled(ByVal enabled As Boolean)
            seAdd.Enabled = enabled
            seClear.Enabled = Not enabled
        End Sub

        ' <seAdd>
        ' <seClear>
        Private Function GetColorArray(ByVal empty As Boolean) As Color()
            Dim rnd = TutorialConstants.Random
            Dim ret As Color() = New Color(colorEditSample.Properties.CustomColors.Length - 1) {}
            For i As Integer = 0 To ret.Length - 1
                ret.SetValue((If(empty, Color.Empty, Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)))), i)
            Next

            Return ret
        End Function

        ' </seClear>
        Private Sub seAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            colorEditSample.Properties.CustomColors = GetColorArray(False)
            SetButtonEnabled(False)
        End Sub

        ' </seAdd>
        ' <seClear>
        Private Sub seClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            colorEditSample.Properties.CustomColors = GetColorArray(True)
            SetButtonEnabled(True)
        End Sub
    ' </seClear>
    End Class
End Namespace
