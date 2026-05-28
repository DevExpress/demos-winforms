Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Tutorials
' </ceShowCustomButtons>
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleNavigator
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleNavigator"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "navigator"
            End Get
        End Property

        Private updateValues As Boolean = False

        Private Sub ModuleNavigator_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(dataNavigatorSample)
            InitComboBoxes()
            InitValues()
            InitData()
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private Sub InitComboBoxes()
            ' <icbTextLocations>
            icbTextLocations.Properties.Items.AddEnum(GetType(NavigatorButtonsTextLocation))
        ' </icbTextLocations>
        End Sub

        Private Sub InitValues()
            updateValues = True
            icbTextLocations.EditValue = dataNavigatorSample.TextLocation
            ceEnableAutoRepeat.Checked = dataNavigatorSample.Buttons.EnabledAutoRepeat
            ceShowToolTips.Checked = dataNavigatorSample.ShowToolTips
            ceShowCustomButtons.Checked = True
            ceShowEditingButtons.Checked = True
            ceShowAppendRemove.Checked = True
            ceShowPageButtons.Checked = True
            updateValues = False
        End Sub

        Private Sub InitData()
            Dim products = NWindDataSet.Tables("Products")
            dataNavigatorSample.DataSource = products
            layoutControlGroup1.DataBindings.Add("Text", products, "ProductName")
        End Sub

        ' <icbTextLocations>
        Private Sub icbTextLocations_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            dataNavigatorSample.TextLocation = CType(icbTextLocations.EditValue, NavigatorButtonsTextLocation)
            ' <skip>
            ShowNavigator()
        ' </skip>
        End Sub

        ' </icbTextLocations>
        ' <ceEnableAutoRepeat>
        Private Sub ceEnableAutoRepeat_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            dataNavigatorSample.Buttons.EnabledAutoRepeat = ceEnableAutoRepeat.Checked
        End Sub

        ' </ceEnableAutoRepeat>
        ' <ceShowToolTips>
        Private Sub ceShowToolTips_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            dataNavigatorSample.ShowToolTips = ceShowToolTips.Checked
        End Sub

        ' </ceShowToolTips>
        Private Sub ShowNavigator()
            dataNavigatorSample.Width = 10
            ControlUtils.CenterControlInParent(dataNavigatorSample)
        End Sub

        ' <ceShowCustomButtons>
        Private Sub ceShowCustomButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each button As NavigatorCustomButton In dataNavigatorSample.Buttons.CustomButtons
                button.Visible = ceShowCustomButtons.Checked
            Next

            ShowNavigator()
        End Sub

        ' </ceShowCustomButtons>
        ' <ceShowEditingButtons>
        Private Sub ceShowEditingButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            dataNavigatorSample.Buttons.EndEdit.Visible = ceShowEditingButtons.Checked
            dataNavigatorSample.Buttons.CancelEdit.Visible = dataNavigatorSample.Buttons.EndEdit.Visible
            ShowNavigator()
        End Sub

        ' </ceShowEditingButtons>
        ' <ceShowAppendRemove>
        Private Sub ceShowAppendRemove_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            dataNavigatorSample.Buttons.Remove.Visible = ceShowAppendRemove.Checked
            dataNavigatorSample.Buttons.Append.Visible = dataNavigatorSample.Buttons.Remove.Visible
            ShowNavigator()
        End Sub

        ' </ceShowAppendRemove>
        ' <ceShowPageButtons>
        Private Sub ceShowPageButtons_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            dataNavigatorSample.Buttons.NextPage.Visible = ceShowPageButtons.Checked
            dataNavigatorSample.Buttons.PrevPage.Visible = dataNavigatorSample.Buttons.NextPage.Visible
            ShowNavigator()
        End Sub

        ' </ceShowPageButtons>
        ' <dataNavigatorSample>
        Private Sub dataNavigatorSample_ButtonClick(ByVal sender As Object, ByVal e As NavigatorButtonClickEventArgs)
            ShowEvent("ButtonClick", e.Button)
        End Sub

        Private Sub ShowEvent(ByVal eventString As String, ByVal button As NavigatorButtonBase)
            Dim type As String = button.ButtonType.ToString()
            If Equals(type, "Custom") Then type += " - " & button.Tag.ToString()
            meFiringEvents.Text = String.Format("{0}: {1}" & Microsoft.VisualBasic.Constants.vbCrLf, eventString, type) & meFiringEvents.Text
        End Sub
    ' </dataNavigatorSample>
    End Class
End Namespace
