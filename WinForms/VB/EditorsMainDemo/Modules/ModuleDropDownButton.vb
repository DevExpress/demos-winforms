Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Tutorials
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleDropDownButton
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleDropDownButton"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "dropdownbutton"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModulePictureEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(sampleDropDownButton)
            InitCombo()
            InitValues()
        End Sub

        Private Sub InitCombo()
            '<icbImageLocation>
            icbImageLocation.Properties.Items.AddEnum(GetType(ImageLocation))
            '</icbImageLocation>
            '<icbImage>
            Dim index As Integer = 0
            For Each keyName In svgImageCollection1.Keys
                icbImage.Properties.Items.Add(New ImageComboBoxItem(keyName, index, index))
                index += 1
            Next
        '</icbImage>
        End Sub

        Private Sub InitValues()
            updateValues = True
            icbImageLocation.EditValue = sampleDropDownButton.ImageLocation
            icbImage.EditValue = sampleDropDownButton.ImageIndex
            icbDropDownStyle.Properties.Items.AddEnum(GetType(DropDownArrowStyle))
            icbDropDownStyle.EditValue = DropDownArrowStyle.Default
            icbDropDownControl.EditValue = 0
            updateValues = False
        End Sub

        '<icbImageLocation>
        Private Sub icbImageLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If updateValues Then Return
            '</skip>
            sampleDropDownButton.ImageLocation = CType(icbImageLocation.EditValue, ImageLocation)
        End Sub

        '</icbImageLocation>
        '<icbImage>
        Private Sub icbImage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If updateValues Then Return
            '</skip>
            sampleDropDownButton.ImageIndex = CInt(icbImage.EditValue)
        End Sub

        '</icbImage>
        '<icbDropDownControl>
        Private Sub icbDropDownControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If updateValues Then Return
            '</skip>
            If icbDropDownControl.EditValue.Equals(0) Then
                sampleDropDownButton.DropDownControl = popupMenu1
            Else
                sampleDropDownButton.DropDownControl = popupControlContainer1
            End If
        End Sub

        '</icbDropDownControl>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            dateEdit1.DateTime = TutorialConstants.Now
            timeEdit1.Time = dateEdit1.DateTime
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            dateEdit1.EditValue = Nothing
            timeEdit1.EditValue = Nothing
        End Sub

        '<meFiringEvents>
        Private Sub sampleDropDownButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            ShowEvent("Click", sender)
        End Sub

        Private Sub sampleDropDownButton_ShowDropDownControl(ByVal sender As Object, ByVal e As ShowDropDownControlEventArgs)
            ShowEvent("ShowDropDownControl", e.DropDownControl)
        End Sub

        Private Sub ShowEvent(ByVal eventString As String, ByVal obj As Object)
            meFiringEvents.Text = String.Format("{0}: {1}" & Microsoft.VisualBasic.Constants.vbCrLf, eventString, obj) & meFiringEvents.Text
        End Sub

        '</meFiringEvents>
        Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs)
            meFiringEvents.Text = String.Empty
        End Sub

        Private Sub icbDropDownStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            sampleDropDownButton.DropDownArrowStyle = CType(icbDropDownStyle.EditValue, DropDownArrowStyle)
        End Sub
    End Class
End Namespace
