Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGantt.Base.Scheduling
Imports DevExpress.XtraGantt.Exceptions
Imports DevExpress.XtraGantt.Options
Imports DevExpress.XtraGantt.Scheduling

Namespace DevExpress.XtraGantt.Demos

    Public Partial Class SoftwareDevelopment
        Inherits TutorialControl

        Private constraintStrings As String()

        Private toolTipVisible As Boolean = False

        Private lockUpdate As Boolean = False

        Public Sub New()
            InitializeComponent()
            InitConstraintStrings()
            Init()
            ' <ganttControl1>
            ganttControl1.TreeListMappings.ParentFieldName = "ParentUID"
            ganttControl1.TreeListMappings.KeyFieldName = "UID"
            ganttControl1.ChartMappings.TextFieldName = "Resources"
            ganttControl1.ChartMappings.InteractionTooltipTextFieldName = "Name"
            ganttControl1.ChartMappings.DurationFieldName = "Duration"
            LoadDataSource()
            ganttControl1.ExpandAll()
            ganttControl1.Exceptions.AddRange(CreateExceptionRules())
        ' </ganttControl1>
        End Sub

        Private Sub InitConstraintStrings()
            constraintStrings = New String(7) {}
            constraintStrings(0) = "As soon as possible"
            constraintStrings(1) = "As late as possible"
            constraintStrings(2) = "Start no earlier than"
            constraintStrings(3) = "Start no later than"
            constraintStrings(4) = "Finish no earlier than"
            constraintStrings(5) = "Finish no later than"
            constraintStrings(6) = "Must start on"
            constraintStrings(7) = "Must finish on"
        End Sub

        Public Overrides ReadOnly Property AllowShowCriticalPath As Boolean
            Get
                Return True
            End Get
        End Property

        Private Sub LoadDataSource()
            Using stream = LoadXml("SoftwareDevelopmentPlan.xml")
                Dim tasks As IList(Of TaskDataItem) = LoadModel(stream)
                If tasks IsNot Nothing AndAlso tasks.Count > 0 Then
                    TryUpdateDates(tasks)
                    ganttControl1.DataSource = tasks
                    ganttControl1.ScheduleFromStartDate(tasks(0).StartDate)
                End If
            End Using
        End Sub

        Private Sub Init()
            icbSchedulingMode.Properties.Items.Add(New ImageComboBoxItem("Default", ScheduleMode.Default, -1))
            icbSchedulingMode.Properties.Items.Add(New ImageComboBoxItem("AutoScheduled", ScheduleMode.Auto, -1))
            icbSchedulingMode.Properties.Items.Add(New ImageComboBoxItem("ManuallyScheduled", ScheduleMode.Manual, -1))
            icbSchedulingMode.EditValue = ganttControl1.OptionsBehavior.ScheduleMode
            icbTooltipLocation.Properties.Items.Add(New ImageComboBoxItem("Default", InteractionTooltipLocation.Default, -1))
            icbTooltipLocation.Properties.Items.Add(New ImageComboBoxItem("TopLeft", InteractionTooltipLocation.TopLeft, -1))
            icbTooltipLocation.Properties.Items.Add(New ImageComboBoxItem("TopRight", InteractionTooltipLocation.TopRight, -1))
            icbTooltipLocation.Properties.Items.Add(New ImageComboBoxItem("BottomLeft", InteractionTooltipLocation.BottomLeft, -1))
            icbTooltipLocation.Properties.Items.Add(New ImageComboBoxItem("BottomRight", InteractionTooltipLocation.BottomRight, -1))
            icbTooltipLocation.Properties.Items.Add(New ImageComboBoxItem("None", InteractionTooltipLocation.None, -1))
            icbTooltipLocation.EditValue = ganttControl1.OptionsView.InteractionTooltipLocation
            ceAllowModifyTasks.Checked = ganttControl1.OptionsCustomization.AllowModifyTasks <> DefaultBoolean.False
            ceAllowModifyDependencies.Checked = ganttControl1.OptionsCustomization.AllowModifyDependencies <> DefaultBoolean.False
            ceAllowModifyProgress.Checked = ganttControl1.OptionsCustomization.AllowModifyProgress <> DefaultBoolean.False
            ganttControl1.OptionsView.CriticalPathHighlightMode = CriticalPathHighlightMode.Single
            ganttControl1.OptionsTimeline.TimelinePosition = TimelinePosition.Bottom
            cpeCriticalPathTasks.Color = DXSkinColors.FillColors.Danger
            cpeCriticalPathDependencies.Color = DXSkinColors.FillColors.Danger
        End Sub

        Private Sub cpeCriticalPathTasks_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.Appearance.CriticalPathTask.BackColor = cpeCriticalPathTasks.Color
            ganttControl1.AppearancePrint.CriticalPathTask.BackColor = cpeCriticalPathTasks.Color
        End Sub

        Private Sub cpeCriticalPathDependencies_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.Appearance.CriticalPathDependency.BackColor = cpeCriticalPathDependencies.Color
            ganttControl1.AppearancePrint.CriticalPathDependency.BackColor = cpeCriticalPathDependencies.Color
        End Sub

        Private Function CreateExceptionRules() As ExceptionRule()
            Dim NewYearDay As YearlyExceptionRule = New YearlyExceptionRule() With {.DayOfMonth = 1, .Month = Month.January}
            Dim MartinLutherDay As YearlyDayOfWeekExceptionRule = New YearlyDayOfWeekExceptionRule() With {.DayOfWeek = DayOfWeek.Monday, .Month = Month.January, .WeekOfMonth = WeekOfMonth.Third}
            Dim PresidentDay As YearlyDayOfWeekExceptionRule = New YearlyDayOfWeekExceptionRule() With {.DayOfWeek = DayOfWeek.Monday, .Month = Month.February, .WeekOfMonth = WeekOfMonth.Third}
            Dim MemorialDay As YearlyDayOfWeekExceptionRule = New YearlyDayOfWeekExceptionRule() With {.DayOfWeek = DayOfWeek.Monday, .Month = Month.May, .WeekOfMonth = WeekOfMonth.Last}
            Dim IndependenceDay As YearlyExceptionRule = New YearlyExceptionRule() With {.DayOfMonth = 4, .Month = Month.July}
            Dim LaborDay As YearlyDayOfWeekExceptionRule = New YearlyDayOfWeekExceptionRule() With {.DayOfWeek = DayOfWeek.Monday, .Month = Month.September, .WeekOfMonth = WeekOfMonth.First}
            Dim ColumbusDay As YearlyDayOfWeekExceptionRule = New YearlyDayOfWeekExceptionRule() With {.DayOfWeek = DayOfWeek.Monday, .Month = Month.October, .WeekOfMonth = WeekOfMonth.Second}
            Dim VeteransDay As YearlyExceptionRule = New YearlyExceptionRule() With {.DayOfMonth = 11, .Month = Month.November}
            Dim ThanksgivingDay As YearlyDayOfWeekExceptionRule = New YearlyDayOfWeekExceptionRule() With {.DayOfWeek = DayOfWeek.Thursday, .Month = Month.November, .WeekOfMonth = WeekOfMonth.Forth}
            Dim ChristmasDay As YearlyExceptionRule = New YearlyExceptionRule() With {.DayOfMonth = 25, .Month = Month.December}
            Return New ExceptionRule() {NewYearDay, MartinLutherDay, PresidentDay, MemorialDay, IndependenceDay, LaborDay, ColumbusDay, VeteransDay, ThanksgivingDay, ChristmasDay}
        End Function

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"SoftwareDevelopment"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "softwareDevelopment"
            End Get
        End Property

        Public Overrides ReadOnly Property MainControl As GanttControl
            Get
                Return ganttControl1
            End Get
        End Property

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

        Private Sub icbSchedulingMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsBehavior.ScheduleMode = CType(icbSchedulingMode.EditValue, ScheduleMode)
        End Sub

        Private Sub icbTooltipLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsView.InteractionTooltipLocation = CType(icbTooltipLocation.EditValue, InteractionTooltipLocation)
        End Sub

        Private Sub ceAllowModifyTasks_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsCustomization.AllowModifyTasks = If(ceAllowModifyTasks.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private Sub ceAllowModifyDependencies_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsCustomization.AllowModifyDependencies = If(ceAllowModifyDependencies.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private Sub ceAllowModifyProgress_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsCustomization.AllowModifyProgress = If(ceAllowModifyProgress.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private Sub constraintTypeComboBox_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ganttControl1.FocusedNode Is Nothing OrElse lockUpdate Then Return
            ganttControl1.FocusedNode(ganttControl1.ChartMappings.ConstraintTypeFieldName) = constraintTypeComboBox.SelectedIndex
        End Sub

        Private Sub constraintDateEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ganttControl1.FocusedNode Is Nothing OrElse lockUpdate Then Return
            ganttControl1.FocusedNode(ganttControl1.ChartMappings.ConstraintDateFieldName) = constraintDateEdit.DateTime
        End Sub

        Private Sub ganttControl1_FocusedNodeChanged(ByVal sender As Object, ByVal e As XtraTreeList.FocusedNodeChangedEventArgs)
            If e.Node Is Nothing Then Return
            lockUpdate = True
            constraintTypeComboBox.SelectedIndex = CInt(e.Node(ganttControl1.ChartMappings.ConstraintTypeFieldName))
            constraintDateEdit.EditValue = CType(e.Node(ganttControl1.ChartMappings.ConstraintDateFieldName), Date?)
            lockUpdate = False
        End Sub

        Private Sub ganttControl1_MouseMove(ByVal sender As Object, ByVal e As Windows.Forms.MouseEventArgs)
            Dim hitInfo = ganttControl1.CalcHitInfo(e.Location)
            If hitInfo.TreeListHitTest IsNot Nothing AndAlso hitInfo.TreeListHitTest.Column Is constraintTypeColumn AndAlso hitInfo.TreeListHitTest.InRowCell Then
                Dim node = hitInfo.TreeListHitTest.Node
                Dim index As Integer = CInt(node(ganttControl1.ChartMappings.ConstraintTypeFieldName))
                If index > 0 Then
                    Dim toolTipText As String = constraintStrings(index)
                    Dim [date] = CType(node(ganttControl1.ChartMappings.ConstraintDateFieldName), Date?)
                    If [date] IsNot Nothing Then toolTipText += " " & [date].Value.Day & "/" & [date].Value.Month & "/" & [date].Value.Year
                    If Not toolTipVisible Then
                        toolTipController1.ShowHint(toolTipText, ganttControl1.PointToScreen(e.Location))
                        toolTipVisible = True
                    End If

                    Return
                End If
            End If

            toolTipVisible = False
            toolTipController1.HideHint()
        End Sub

        Private Sub ganttControl1_CellValueChanged(ByVal sender As Object, ByVal e As XtraTreeList.CellValueChangedEventArgs)
            lockUpdate = True
            If e.Column Is constraintTypeColumn Then constraintTypeComboBox.SelectedIndex = CInt(e.Node(ganttControl1.ChartMappings.ConstraintTypeFieldName))
            If e.Column Is constraintDateColumn Then constraintDateEdit.EditValue = CType(e.Node(ganttControl1.ChartMappings.ConstraintDateFieldName), Date?)
            lockUpdate = False
        End Sub
    End Class
End Namespace
