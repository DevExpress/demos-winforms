Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Schedule
Imports DevExpress.Schedule.Serializing
Imports System.Linq
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class HolidaysModule
        Inherits TutorialControl

        Const OutlookHolidaysFileName As String = "OUTLOOK.HOL"

        Const SchedulerHolidaysFileName As String = "holidays.xml"

        Const defaultLocationName As String = "united states"

        Private _allHolidays As HolidayBaseCollection = New HolidayBaseCollection()

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Protected ReadOnly Property AllHolidays As HolidayBaseCollection
            Get
                Return _allHolidays
            End Get
        End Property

        Private Sub HolidaysModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim filePath As String = DemoUtils.GetFileRelativePath(SchedulerHolidaysFileName)
            ImportHolidaysFromXmlFile(filePath)
            UpdateControls()
            Dim defaultLocationIndex As Integer = Math.Max(0, clbLocations.FindStringExact(defaultLocationName))
            If clbLocations.ItemCount >= 0 Then
                clbLocations.SetItemChecked(defaultLocationIndex, True)
                GenerateHolidayAppointments(False)
            End If

            schedulerControl.Start = FindNearHoliday()
            ActiveControl = clbLocations
        End Sub

        Private Sub UpdateControls()
            FillLocationListBox(SelectHolidayLocations(AllHolidays))
            FillHolidaysListBox(New List(Of HolidayListBoxItem)(0))
            UpdateStatusLabel(0, 0)
        End Sub

        Private Function SelectHolidayLocations(ByVal holidays As HolidayBaseCollection) As String()
            Dim locations As List(Of String) = New List(Of String)()
            For Each item As Holiday In holidays
                If Not locations.Contains(item.Location) Then locations.Add(item.Location)
            Next

            Return locations.ToArray()
        End Function

        Private Sub FillLocationListBox(ByVal locations As String())
            clbLocations.Items.BeginUpdate()
            Try
                clbLocations.Items.Clear()
                For i As Integer = 0 To locations.Length - 1
                    clbLocations.Items.Add(locations(i), False)
                Next

                clbLocations.SelectedIndex = 0
            Finally
                clbLocations.Items.EndUpdate()
            End Try
        End Sub

        Private Function CreateListBoxData(ByVal items As HolidayBaseCollection) As List(Of HolidayListBoxItem)
            Dim data As List(Of HolidayListBoxItem) = New List(Of HolidayListBoxItem)()
            For i As Integer = 0 To items.Count - 1
                data.Add(New HolidayListBoxItem(items(i)))
            Next

            Return data
        End Function

        Private Sub FillHolidaysListBox(ByVal data As List(Of HolidayListBoxItem))
            lbHolidays.Items.BeginUpdate()
            Try
                lbHolidays.DataSource = data
                lbHolidays.DisplayMember = "DisplayText"
            Finally
                lbHolidays.Items.EndUpdate()
            End Try
        End Sub

        Private Sub UpdateStatusLabel(ByVal holidayCount As Integer, ByVal locationCount As Integer)
            lblStatus.Text = String.Format("Loaded {0} holiday(s) for {1} location(s)", holidayCount, locationCount)
        End Sub

        Private Sub clbLocations_ItemCheck(ByVal sender As Object, ByVal e As XtraEditors.Controls.ItemCheckEventArgs)
            Dim locations As List(Of String) = GetSelectedLocations()
            Dim holidays As HolidayBaseCollection = GetSelectedHolidays(locations)
            AddHolidaysToScheduler(holidays)
            FillHolidaysListBox(CreateListBoxData(holidays))
            UpdateStatusLabel(holidays.Count, locations.Count)
        End Sub

        Private Function GetSelectedHolidays(ByVal locations As List(Of String)) As HolidayBaseCollection
            Dim result As HolidayBaseCollection = New HolidayBaseCollection()
            If locations.Count = 0 Then Return result
            For Each item As Holiday In AllHolidays
                If locations.Contains(item.Location) Then result.Add(item)
            Next

            Return result
        End Function

        Private Function GetSelectedLocations() As List(Of String)
            Dim result As List(Of String) = New List(Of String)()
            For i As Integer = 0 To clbLocations.Items.Count - 1
                Dim item As CheckedListBoxItem = clbLocations.Items(i)
                If item.CheckState = CheckState.Checked Then result.Add(item.Value.ToString())
            Next

            Return result
        End Function

        Private Sub lbHolidays_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As HolidayListBoxItem = TryCast(lbHolidays.SelectedItem, HolidayListBoxItem)
            If item IsNot Nothing Then
                schedulerControl.GoToDate(item.Holiday.Date)
            End If
        End Sub

        Private Sub AddHolidaysToScheduler(ByVal items As HolidayBaseCollection)
            schedulerControl.BeginUpdate()
            Try
                schedulerControl.WorkDays.Clear()
                schedulerControl.WorkDays.Add(WeekDays.WorkDays)
                schedulerControl.WorkDays.AddRange(items)
            Finally
                schedulerControl.EndUpdate()
            End Try
        End Sub

        Private Sub btnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs)
            GenerateHolidayAppointments(True)
        End Sub

        Private Sub GenerateHolidayAppointments(ByVal showMessage As Boolean)
            If chkClearBeforGenerate.Checked Then schedulerDataStorage.Appointments.Clear()
            Dim apts As AppointmentBaseCollection = HolidaysHelper.GenerateHolidayAppointments(schedulerDataStorage, schedulerControl.WorkDays)
            schedulerDataStorage.Appointments.Items.AddRange(apts)
            If showMessage Then XtraMessageBox.Show(String.Format("{0} appointment(s) were added", apts.Count), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub btnImportFromXml_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "Scheduler holidays files (*.xml)|*.xml|All files (*.*)|*.*"
            dlg.FilterIndex = 1
            dlg.FileName = SchedulerHolidaysFileName
            Dim filePath As String = DemoUtils.GetFileRelativePath(SchedulerHolidaysFileName)
            dlg.InitialDirectory = New FileInfo(filePath).DirectoryName
            dlg.DefaultExt = "*.xml"
            dlg.CheckFileExists = True
            If dlg.ShowDialog() = DialogResult.OK Then
                ImportHolidaysFromXmlFile(dlg.FileName)
                UpdateControls()
            End If
        End Sub

        Private Sub ImportHolidaysFromXmlFile(ByVal path As String)
            If Not File.Exists(path) Then Return
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load(IO.Path.GetFullPath(path))
            _allHolidays = HolidayCollectionXmlPersistenceHelper.ObjectFromXml(doc.OuterXml)
        End Sub

        Private Function FindNearHoliday() As Date
            Dim now As Date = TutorialConstants.Today
            Dim holidays As IEnumerable(Of Holiday) = schedulerControl.WorkDays.OfType(Of Holiday)().Where(Function(hol) hol.Date >= now)
            If holidays.Count() = 0 Then Return now
            Dim minDistance As TimeSpan = holidays.Min(Function(hol)(hol.Date - now).Duration())
            Return Enumerable.First(holidays, Function(hol)(hol.Date - now).Duration() = minDistance).Date
        End Function

        Private Sub btnImportFromOutlook_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "Microsoft Office Outlook Holidays files (*.hol)|*.hol|Text files (*.txt)|*.txt|All files (*.*)|*.*"
            dlg.FilterIndex = 1
            dlg.FileName = OutlookHolidaysFileName
            dlg.DefaultExt = "*.hol"
            dlg.CheckFileExists = True
            If dlg.ShowDialog() = DialogResult.OK Then
                ImportHolidaysFromOutlookFile(dlg.FileName)
                UpdateControls()
            End If
        End Sub

        Private Sub ImportHolidaysFromOutlookFile(ByVal path As String)
            If Not File.Exists(path) Then Return
            Dim loader As OutlookHolidaysLoader = New OutlookHolidaysLoader()
            _allHolidays = loader.FromFile(path)
        End Sub

        Private Sub schedulerControl_LayoutViewInfoCustomizing(ByVal sender As Object, ByVal e As LayoutViewInfoCustomizingEventArgs)
            Dim header As SchedulerHeader = Nothing
            If e.Kind = LayoutElementKind.DateHeader AndAlso schedulerControl.ActiveViewType <> SchedulerViewType.Month Then header = CType(e.ViewInfo, SchedulerHeader)
            If e.Kind = LayoutElementKind.Cell AndAlso schedulerControl.ActiveViewType = SchedulerViewType.Month Then header = CType(e.ViewInfo, SingleWeekCellBase).Header
            If header IsNot Nothing Then
                Dim hol As Holiday = FindHoliday(header.Interval.Start.Date)
                If hol IsNot Nothing Then
                    header.Caption = String.Format("{0} ({1})", hol.DisplayName, hol.Location)
                    header.Appearance.HeaderCaption.ForeColor = Color.Red
                    header.Appearance.AlternateHeaderCaption.ForeColor = Color.Red
                    header.ToolTipText = header.Caption
                    header.ShouldShowToolTip = True
                End If
            End If
        End Sub

        ' This method finds a holiday for the specified date.
        Private Function FindHoliday(ByVal [date] As Date) As Holiday
            For Each item As WorkDay In schedulerControl.WorkDays
                If TypeOf item Is Holiday Then
                    Dim hol As Holiday = CType(item, Holiday)
                    If hol.Date = [date] Then Return hol
                End If
            Next

            Return Nothing
        End Function
    End Class

#Region "HolidayListBoxItem class"
    Public Class HolidayListBoxItem

        Private _holiday As Holiday

        Public Sub New(ByVal holiday As Holiday)
            _holiday = holiday
        End Sub

        Public ReadOnly Property Holiday As Holiday
            Get
                Return _holiday
            End Get
        End Property

        Public ReadOnly Property DisplayText As String
            Get
                Return String.Format("{0} ({1}) {2}", _holiday.DisplayName, _holiday.Location, _holiday.Date.ToShortDateString())
            End Get
        End Property
    End Class
#End Region
End Namespace
