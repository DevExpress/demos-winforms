Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleCalendar
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitComboBoxes()
            InitValues()
            InitCellDataProvider()
            If tabPane1 IsNot Nothing Then AddHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleCalendar"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "calendar"
            End Get
        End Property

        Private Sub OnSelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            CalcContentCore()
        End Sub

        Protected Overrides Sub UnsubscribeOnEvents()
            MyBase.UnsubscribeOnEvents()
            If tabPane1 IsNot Nothing Then RemoveHandler tabPane1.SelectedPageChanged, AddressOf OnSelectedPageChanged
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            If layoutControl1 Is Nothing OrElse Not layoutControl1.IsHandleCreated Then Return
            layoutControl1.Size = GetLayoutControlSize()
            CalcModuleContent()
        End Sub

        Private Sub InitCellDataProvider()
            calendarControl2.CellStyleProvider = New MyCellStyleProvider()
        End Sub

        Protected Overrides ReadOnly Property AllowCenterControls As Boolean
            Get
                Return False
            End Get
        End Property

        Private Sub InitComboBoxes()
            icbVistaDisplayMode.Properties.Items.AddEnum(GetType(CalendarView))
            AddHandler icbVistaDisplayMode.SelectedIndexChanged, AddressOf cbVistaDisplayMode_SelectedIndexChanged
            icbShowVistaClock.Properties.Items.AddEnum(GetType(DefaultBoolean))
            icbWeekNumberRule.Properties.Items.AddEnum(GetType(WeekNumberRule))
            icbShowInactiveDays.Properties.Items.AddEnum(GetType(CalendarInactiveDaysVisibility))
            icbFirstDayOfWeek.Properties.Items.AddEnum(GetType(DayOfWeek))
            icbRowCount.Properties.Items.Add(New ImageComboBoxItem("Auto", 0))
            icbRowCount.Properties.Items.Add(New ImageComboBoxItem("1", 1))
            icbRowCount.Properties.Items.Add(New ImageComboBoxItem("2", 2))
            icbRowCount.Properties.Items.Add(New ImageComboBoxItem("3", 3))
            icbColumnCount.Properties.Items.Add(New ImageComboBoxItem("Auto", 0))
            icbColumnCount.Properties.Items.Add(New ImageComboBoxItem("1", 1))
            icbColumnCount.Properties.Items.Add(New ImageComboBoxItem("2", 2))
            icbColumnCount.Properties.Items.Add(New ImageComboBoxItem("3", 3))
            ceShowMonthName.Enabled = False
        End Sub

        Private Sub cbVistaDisplayMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            calendarControl1.AllowAnimatedContentChange = False
            calendarControl1.View = DateEditCalendarViewType.MonthInfo
            calendarControl1.AllowAnimatedContentChange = True
        End Sub

        Private updateValues As Boolean

        Private Sub InitValues()
            updateValues = True
            calendarControl1.DateTime = TutorialConstants.Now
            icbVistaDisplayMode.EditValue = calendarControl1.CalendarView
            icbShowVistaClock.EditValue = calendarControl1.CalendarTimeEditing
            icbWeekNumberRule.EditValue = calendarControl1.WeekNumberRule
            icbShowInactiveDays.EditValue = calendarControl1.InactiveDaysVisibility
            ceShowClear.Checked = calendarControl1.ShowClearButton
            ceShowToday.Checked = calendarControl1.ShowTodayButton
            ceShowWeekNumbers.Checked = calendarControl1.ShowWeekNumbers
            ceShowHeader.Checked = calendarControl1.ShowHeader
            ceShowFooter.Checked = calendarControl1.ShowFooter
            ceShowWeekNumbers.Checked = calendarControl1.ShowWeekNumbers
            icbFirstDayOfWeek.EditValue = calendarControl1.FirstDayOfWeek
            icbRowCount.SelectedIndex = 1
            icbColumnCount.SelectedIndex = 1
            updateValues = False
        End Sub

        Private Sub ceShowHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            calendarControl1.ShowHeader = ceShowHeader.Checked
        End Sub

        Private Sub ceShowFooter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            calendarControl1.ShowFooter = ceShowFooter.Checked
        End Sub

        Private Sub ceShowMonthName_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            calendarControl1.ShowMonthHeaders = ceShowMonthName.Checked
        End Sub

        Private Sub ceShowClear_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            calendarControl1.ShowClearButton = ceShowClear.Checked
        End Sub

        Private Sub ceShowToday_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            calendarControl1.ShowTodayButton = ceShowToday.Checked
        End Sub

        Private Sub ceShowWeekNumbers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            calendarControl1.ShowWeekNumbers = ceShowWeekNumbers.Checked
        End Sub

        Private Sub icbVistaDisplayMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            Dim view As CalendarView = CType(CType(icbVistaDisplayMode.SelectedItem, ImageComboBoxItem).Value, CalendarView)
            calendarControl1.CalendarView = view
            If view = CalendarView.Classic OrElse view = CalendarView.ClassicNew OrElse view = CalendarView.Vista Then
                ceShowToday.Enabled = True
                ceShowClear.Enabled = True
            Else
                ceShowToday.Enabled = False
                ceShowClear.Enabled = False
            End If
        End Sub

        Private Sub icbShowVistaClock_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value As DefaultBoolean = CType(CType(icbShowVistaClock.SelectedItem, ImageComboBoxItem).Value, DefaultBoolean)
            calendarControl1.CalendarTimeEditing = value
        End Sub

        Private Sub icbWeekNumberRule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value As WeekNumberRule = CType(CType(icbWeekNumberRule.SelectedItem, ImageComboBoxItem).Value, WeekNumberRule)
            calendarControl1.WeekNumberRule = value
        End Sub

        Private Sub icbFirstDayOfWeek_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value As DayOfWeek = CType(CType(icbFirstDayOfWeek.SelectedItem, ImageComboBoxItem).Value, DayOfWeek)
            calendarControl1.FirstDayOfWeek = value
        End Sub

        Private Sub icbShowInactiveDays_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value As CalendarInactiveDaysVisibility = CType(CType(icbShowInactiveDays.SelectedItem, ImageComboBoxItem).Value, CalendarInactiveDaysVisibility)
            calendarControl1.InactiveDaysVisibility = value
        End Sub

        Protected Sub UpdateInactiveDaysVisibility()
            If calendarControl1.RowCount > 1 OrElse calendarControl1.ColumnCount > 1 Then icbShowInactiveDays.EditValue = CalendarInactiveDaysVisibility.FirstLast
        End Sub

        Private Sub icbRowCount_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value As Integer = icbRowCount.SelectedIndex
            calendarControl1.RowCount = value
            ceShowMonthName.Enabled = calendarControl1.RowCount * calendarControl1.ColumnCount > 1
            UpdateInactiveDaysVisibility()
            UpdateCalendarControlSizingMode()
        End Sub

        Private Sub UpdateCalendarControlSizingMode()
            If calendarControl1.ColumnCount = 0 OrElse calendarControl1.RowCount = 0 Then
                MakeCalendarControlSizeable()
            Else
                MakeCalendarControlAutoSize()
            End If
        End Sub

        Protected Function GetCalendarClientRect() As Rectangle
            Dim _padding As Integer = ScaleDPI.ScaleHorizontal(32)
            Return New Rectangle(tabNavigationPage1.ClientRectangle.X + _padding, tabNavigationPage1.ClientRectangle.Y + _padding, tabNavigationPage1.ClientRectangle.Width - GetLayoutControlSize().Width - _padding * 3, tabNavigationPage1.ClientRectangle.Height - _padding * 2)
        End Function

        Private Sub MakeCalendarControlAutoSize()
            calendarControl1.AutoSize = True
            calendarControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Left
            Dim rect As Rectangle = GetCalendarClientRect()
            calendarControl1.Location = New Point(rect.X + (rect.Width - calendarControl1.Width) \ 2, rect.Y + (rect.Height - calendarControl1.Height) \ 2)
        End Sub

        Private Sub MakeCalendarControlSizeable()
            calendarControl1.AutoSize = False
            calendarControl1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            Dim rect As Rectangle = GetCalendarClientRect()
            calendarControl1.Bounds = rect
        End Sub

        Private Sub icbColumnCount_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim value As Integer = icbColumnCount.SelectedIndex
            calendarControl1.ColumnCount = value
            ceShowMonthName.Enabled = calendarControl1.RowCount * calendarControl1.ColumnCount > 1
            UpdateInactiveDaysVisibility()
            UpdateCalendarControlSizingMode()
        End Sub

        Private ReadOnly Property Indent As Integer
            Get
                Return ScaleDPI.ScaleHorizontal(16)
            End Get
        End Property

        Private Sub xtraTabPage1_Resize(ByVal sender As Object, ByVal e As EventArgs)
            CalcModuleContent()
        End Sub

        Protected Sub CalcModuleContent()
            If layoutControl1 Is Nothing OrElse Not layoutControl1.IsHandleCreated Then Return
            Dim layoutControlBestSize As Size = GetLayoutControlSize()
            layoutControl1.Location = New Point(tabNavigationPage1.ClientRectangle.Width - layoutControlBestSize.Width - Indent, tabNavigationPage1.ClientRectangle.Y + Math.Max(Indent, (tabNavigationPage1.ClientRectangle.Height - layoutControlBestSize.Height) \ 2))
            UpdateCalendarControlSizingMode()
        End Sub

        Protected Function GetLayoutControlSize() As Size
            Dim _size As Size = layoutControl1.GetPreferredSize(Size.Empty)
            Return New Size(Math.Min(_size.Width, tabNavigationPage1.ClientRectangle.Width - 2 * Indent), Math.Min(_size.Height, tabNavigationPage1.ClientRectangle.Height - 2 * Indent))
        End Function

        Private Sub calendarControl1_Resize(ByVal sender As Object, ByVal e As EventArgs)
            UpdateCalendarControlSizingMode()
        End Sub

        Private Sub calendarControl2_ContextButtonCustomize(ByVal sender As Object, ByVal e As CalendarContextButtonCustomizeEventArgs)
            Dim provider As MyCellStyleProvider = CType(calendarControl2.CellStyleProvider, MyCellStyleProvider)
            Dim data As MyCustomCellData = provider.GetCell(e.Cell.Date)
            If data Is Nothing OrElse String.IsNullOrEmpty(data.InfoText) Then
                e.Item.Visibility = ContextItemVisibility.Hidden
                Return
            End If

            e.Item.AllowGlyphSkinning = DefaultBoolean.True
            e.Item.Tag = data
            e.Item.ImageOptions.SvgImage = data.SvgGlyph
        End Sub

        Private Sub calendarControl2_ContextButtonClick(ByVal sender As Object, ByVal e As ContextItemClickEventArgs)
            Dim data As MyCustomCellData = CType(e.Item.Tag, MyCustomCellData)
            If data Is Nothing Then Return
            memoEdit1.Text = data.InfoText
            flyoutPanel1.ShowBeakForm(New Point(e.ScreenBounds.X + e.ScreenBounds.Width \ 2, e.ScreenBounds.Top - 5))
        End Sub

        Private Sub calendarControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            listBoxControl1.BeginUpdate()
            Try
                listBoxControl1.Items.Clear()
                For Each range As XtraEditors.Controls.DateRange In calendarControl1.SelectedRanges
                    listBoxControl1.Items.Add(range.StartDate.ToShortDateString() & " - " & range.EndDate.ToShortDateString())
                Next
            Finally
                listBoxControl1.EndUpdate()
            End Try
        End Sub
    End Class

    Public Enum CellDataType
        Undefined
        Work
        Family
        [Event]
    End Enum

    Public Class MyCustomCellData

        Public Property [Date] As Date

        Public Property SvgGlyph As SvgImage

        Public Property InfoText As String

        Public Property CellType As CellDataType

        Public Property Description As String

        Public Property SpecialDate As Boolean
    End Class

    Public Class MyCellStyleProvider
        Implements ICalendarCellStyleProvider

        Private cellsCore As List(Of MyCustomCellData)

        Protected ReadOnly Property Cells As List(Of MyCustomCellData)
            Get
                If cellsCore Is Nothing Then cellsCore = CreateCells()
                Return cellsCore
            End Get
        End Property

        Protected Overridable Function CreateCells() As List(Of MyCustomCellData)
            Dim res As List(Of MyCustomCellData) = New List(Of MyCustomCellData)()
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 1), .CellType = CellDataType.Work, .InfoText = "Mexico City. Talks with Pure Products Inc.", .SvgGlyph = Properties.Resources.Flight})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 2), .CellType = CellDataType.Work})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 4), .SpecialDate = True, .Description = "INDEPENDENCE DAY"})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 6), .CellType = CellDataType.Family, .InfoText = "New York Knicks vs Orlando Magic", .SvgGlyph = Properties.Resources.Game})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 13), .CellType = CellDataType.Family})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 10), .CellType = CellDataType.Work, .InfoText = "Call Susanne Guper, New warehouse issues", .SvgGlyph = Properties.Resources.Meeting})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 16), .Description = "JOHN" & Microsoft.VisualBasic.Constants.vbLf & "BIRTHDAY", .SpecialDate = True})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 21), .CellType = CellDataType.Event})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 22), .Description = "MARY" & Microsoft.VisualBasic.Constants.vbLf & "BIRTHDAY", .SpecialDate = True})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 29), .CellType = CellDataType.Event})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 17), .CellType = CellDataType.Event, .InfoText = "Flatiron Club", .SvgGlyph = Properties.Resources.Party})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 30), .CellType = CellDataType.Family, .InfoText = "Slow Food Farmers' Market", .SvgGlyph = Properties.Resources.Shopping})
            res.Add(New MyCustomCellData() With {.[Date] = New DateTime(2015, 7, 31), .CellType = CellDataType.Family})
            Return res
        End Function

        Public Function GetCell(ByVal [date] As Date) As MyCustomCellData
            Return Cells.FirstOrDefault(Function(c) c.Date.Date = [date].Date)
        End Function

        Private Sub UpdateAppearance(ByVal cell As CalendarCellStyle) Implements ICalendarCellStyleProvider.UpdateAppearance
            Dim cellInfo As MyCustomCellData = GetCell(cell.Date)
            If cellInfo Is Nothing Then Return
            cell.Description = cellInfo.Description
            If Not Equals(cell.Description, Nothing) Then
                cell.DescriptionAppearance = CType(cell.Appearance.Clone(), AppearanceObject)
                cell.DescriptionAppearance.Font = New Font(cell.Appearance.Font.FontFamily, 7.0F, FontStyle.Bold)
                cell.DescriptionAppearance.TextOptions.WordWrap = WordWrap.Wrap
            End If

            If cell.State = Utils.Drawing.ObjectState.Normal Then
                cell.Appearance.BackColor = GetCellColor(cellInfo, cell)
                cell.Appearance.ForeColor = CheckForeColor(cell.Appearance.ForeColor, cell.Appearance.BackColor)
            End If

            If cellInfo.SpecialDate Then cell.Appearance.Font = New Font(cell.Appearance.Font.FontFamily, 20.0F, FontStyle.Bold)
        End Sub

        Private Function CheckForeColor(ByVal foreColor As Color, ByVal backColor As Color) As Color
            If backColor.A = 0 OrElse foreColor.A = 0 Then Return foreColor
            If foreColor.R * 0.299 + foreColor.G * 0.587 + foreColor.B * 0.114 > 128 Then Return Color.Black
            Return foreColor
        End Function

        Protected Overridable Function GetCellColor(ByVal cellData As MyCustomCellData, ByVal cellStyle As CalendarCellStyle) As Color
            Select Case cellData.CellType
                Case CellDataType.Event
                    Return SchedulerSkins.GetSkin(cellStyle.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor02", Color.FromArgb(255, 209, 240, 253))
                Case CellDataType.Family
                    Return SchedulerSkins.GetSkin(cellStyle.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor03", Color.FromArgb(255, 229, 253, 177))
                Case CellDataType.Work
                    Return SchedulerSkins.GetSkin(cellStyle.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor04", Color.FromArgb(255, 255, 228, 239))
            End Select

            Return Color.Empty
        End Function
    End Class
End Namespace
