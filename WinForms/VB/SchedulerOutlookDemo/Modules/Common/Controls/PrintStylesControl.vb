Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class PrintStylesControl
        Inherits UserControl

        Private action As Action(Of ReportType)

        Private buttons As List(Of CheckButton)

        Public Sub New()
            InitializeComponent()
            buttons = New List(Of CheckButton)()
            RegisterButton(btnCalendarDetailsStyle, ReportType.CalendarDetailsStyle)
            RegisterButton(btnCalendarDetailsStyle, ReportType.CalendarDetailsStyle)
            RegisterButton(btnDailyStyle, ReportType.DailyStyle)
            RegisterButton(btnMonthlyCalendarStyle, ReportType.MonthlyCalendarStyle)
            RegisterButton(btnWeeklyAgendaStyle, ReportType.WeeklyAgendaStyle)
            RegisterButton(btnWeeklyCalendarStyle, ReportType.WeeklyCalendarStyle)
            RegisterButton(btnTriFoldStyle, ReportType.TriFoldStyle)
        End Sub

        Public Sub New(ByVal action As Action(Of ReportType), ByVal type As ReportType)
            Me.New()
            For Each button In buttons
                If CType(button.Tag, ReportType) = type Then
                    button.Checked = True
                    Exit For
                End If
            Next

            Me.action = action
        End Sub

        Private Sub RegisterButton(ByVal button As CheckButton, ByVal type As ReportType)
            buttons.Add(button)
            button.Tag = type
            AddHandler button.CheckedChanged, AddressOf OnButtonCheckedChanged
        End Sub

        Private Sub OnButtonCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim button As CheckButton = CType(sender, CheckButton)
            If Not button.Checked Then Return
            If action Is Nothing Then Return
            action(CType(button.Tag, ReportType))
        End Sub
    End Class

    Public Enum ReportType
        CalendarDetailsStyle
        DailyStyle
        MonthlyCalendarStyle
        WeeklyAgendaStyle
        WeeklyCalendarStyle
        TriFoldStyle
    End Enum
End Namespace
