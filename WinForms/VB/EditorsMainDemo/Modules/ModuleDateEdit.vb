Imports System
Imports System.ComponentModel
Imports System.Drawing
' <icbAllowNullInput>
' <icbWeekNumberRule>
' <icbEditMask>
Imports DevExpress.XtraEditors.Controls
' </icbEditMask>
' </icbWeekNumberRule>
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleDateEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleDateEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "dateedit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private updateValues As Boolean = False

        Private Sub ModuleDateEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            Tutorials.ControlUtils.CenterControlInParent(dateEditSample)
            InitComboBoxes()
            InitValues()
        End Sub

        Private Sub InitComboBoxes()
            ' <icbAllowNullInput>
            icbAllowNullInput.Properties.Items.AddEnum(GetType(DefaultBoolean))
            icbVistaDisplayMode.Properties.Items.AddEnum(GetType(CalendarView))
            icbShowVistaClock.Properties.Items.AddEnum(GetType(DefaultBoolean))
            ' </icbAllowNullInput>
            ' <icbWeekNumberRule>
            icbWeekNumberRule.Properties.Items.AddEnum(GetType(WeekNumberRule))
            ' </icbWeekNumberRule>
            ' <icbEditMask>
            Dim dateFormats As String(,) = New String(,) {{"d", "Short Date"}, {"D", "Long Date"}, {"m", "Month & Day"}, {"y", "Year & Month"}}
            For i As Integer = 0 To dateFormats.Length \ 2 - 1
                icbEditMask.Properties.Items.Add(New ImageComboBoxItem(dateFormats(i, 1), dateFormats(i, 0), -1))
            Next
        ' </icbEditMask>
        End Sub

        Private Sub InitValues()
            updateValues = True
            dateEditSample.DateTime = TutorialConstants.Now.AddDays(-2)
            icbVistaDisplayMode.EditValue = dateEditSample.Properties.CalendarView
            icbShowVistaClock.EditValue = dateEditSample.Properties.VistaEditTime
            icbAllowNullInput.EditValue = dateEditSample.Properties.AllowNullInput
            icbWeekNumberRule.EditValue = dateEditSample.Properties.WeekNumberRule
            ceShowClear.Checked = dateEditSample.Properties.ShowClear
            ceShowToday.Checked = dateEditSample.Properties.ShowToday
            ceShowWeekNumbers.Checked = dateEditSample.Properties.ShowWeekNumbers
            ceShowClear.Enabled = dateEditSample.Properties.AllowNullInput <> DefaultBoolean.False
            icbEditMask.EditValue = dateEditSample.Properties.EditMask
            UpdateVistaStyle()
            updateValues = False
            EnableClock()
        End Sub

        ' <icbAllowNullInput>
        Private Sub icbAllowNullInput_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            dateEditSample.Properties.AllowNullInput = CType(icbAllowNullInput.EditValue, DefaultBoolean)
            ' <ceShowClear>
            ceShowClear.Enabled = dateEditSample.Properties.AllowNullInput <> DefaultBoolean.False
        ' </ceShowClear>
        End Sub

        ' </icbAllowNullInput>
        ' <icbWeekNumberRule>
        Private Sub icbWeekNumberRule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            dateEditSample.Properties.WeekNumberRule = CType(icbWeekNumberRule.EditValue, WeekNumberRule)
        End Sub

        ' </icbWeekNumberRule>
        ' <ceShowClear>
        Private Sub ceShowClear_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            dateEditSample.Properties.ShowClear = ceShowClear.Checked
        End Sub

        ' </ceShowClear>
        ' <ceShowToday>
        Private Sub ceShowToday_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            dateEditSample.Properties.ShowToday = ceShowToday.Checked
        End Sub

        ' </ceShowToday>
        ' <ceShowWeekNumbers>
        Private Sub ceShowWeekNumbers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            dateEditSample.Properties.ShowWeekNumbers = ceShowWeekNumbers.Checked
        End Sub

        ' </ceShowWeekNumbers>
        ' <icbEditMask>
        Private Sub icbEditMask_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetMask()
        End Sub

        ' </icbEditMask>
        ' <ceSynchronizing>
        Private Sub ceSynchronizing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetMask()
        End Sub

        ' <icbEditMask>
        Private Sub SetMask()
            dateEditSample.Properties.EditMask = icbEditMask.EditValue.ToString()
            dateEditSample.Properties.DisplayFormat.FormatString =(If(ceSynchronizing.Checked, dateEditSample.Properties.EditMask, "d"))
        End Sub

        ' </icbEditMask>
        ' </ceSynchronizing>
        '<icbVistaDisplayMode>
        Private Sub icbVistaDisplayMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            dateEditSample.Properties.CalendarView = CType(icbVistaDisplayMode.EditValue, CalendarView)
            EnableClock()
            UpdateVistaStyle()
        End Sub

        '</icbVistaDisplayMode>
        Private Sub EnableClock()
            Dim enableTime As Boolean = dateEditSample.Properties.VistaDisplayMode = DefaultBoolean.True OrElse (NativeVista.IsVista AndAlso dateEditSample.Properties.VistaDisplayMode = DefaultBoolean.Default) OrElse dateEditSample.Properties.CalendarView = CalendarView.TouchUI
            icbShowVistaClock.Enabled = enableTime
        End Sub

        '<icbShowVistaClock>
        Private Sub icbShowVistaClock_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            dateEditSample.Properties.VistaEditTime = CType(icbShowVistaClock.EditValue, DefaultBoolean)
        End Sub

        '</icbShowVistaClock>
        Private Function IsVistaDisplayMode(ByVal edit As DateEdit) As Boolean
            If edit.Properties.VistaDisplayMode = DefaultBoolean.False Then Return False
            If edit.Properties.VistaDisplayMode = DefaultBoolean.True Then Return True
            Return NativeVista.IsVista
        End Function

        Private Sub UpdateVistaStyle()
            If dateEditSample.Properties.CalendarView = CalendarView.TouchUI Then
                ceShowWeekNumbers.Enabled = False
                ceShowToday.Enabled = ceShowWeekNumbers.Enabled
                ceShowClear.Enabled = ceShowToday.Enabled
            Else
                ceShowToday.Enabled = Not IsVistaDisplayMode(dateEditSample)
                ceShowWeekNumbers.Enabled = True
                ceShowClear.Enabled = ceShowWeekNumbers.Enabled
            End If
        End Sub
    End Class
End Namespace
