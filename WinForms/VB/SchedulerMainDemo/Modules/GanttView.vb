Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class GanttViewModule
        Inherits TutorialControl

        Private _lastSplitContainerControlSplitterPosition As Integer

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub GanttViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitControlValues()
            FillData()
            UpdateControls()
        End Sub

#Region "Properties"
        Private Property LastSplitContainerControlSplitterPosition As Integer
            Get
                Return _lastSplitContainerControlSplitterPosition
            End Get

            Set(ByVal value As Integer)
                _lastSplitContainerControlSplitterPosition = value
            End Set
        End Property

        Private ReadOnly Property GanttAppointmentDisplayOptions As GanttViewAppointmentDisplayOptions
            Get
                Return schedulerControl1.Views.GanttView.AppointmentDisplayOptions
            End Get
        End Property

        Private ReadOnly Property TimeIndicatorDisplayOptions As TimeIndicatorDisplayOptions
            Get
                Return CType(schedulerControl1.GanttView.TimeIndicatorDisplayOptions, TimeIndicatorDisplayOptions)
            End Get
        End Property

#End Region
#Region "FillData"
        Private Sub FillData()
            Dim connectionString As String = DemoUtils.GetFileRelativePath("Tasks.mdb")
            If connectionString.Length <= 0 Then Return
            DemoUtils.SetConnectionString(tasksTableAdapter.Connection, connectionString)
            DemoUtils.SetConnectionString(taskDependenciesTableAdapter.Connection, connectionString)
            DemoUtils.SetConnectionString(resourcesTableAdapter.Connection, connectionString)
            tasksTableAdapter.Fill(tasksDataSet.Tasks)
            taskDependenciesTableAdapter.Fill(tasksDataSet.TaskDependencies)
            resourcesTableAdapter.Fill(tasksDataSet.Resources)
            AddHandler tasksTableAdapter.Adapter.RowUpdated, New OleDbRowUpdatedEventHandler(AddressOf tasksTableAdapter_RowUpdated)
            AddHandler taskDependenciesTableAdapter.Adapter.RowUpdated, New OleDbRowUpdatedEventHandler(AddressOf taskDependenciesTableAdapter_RowUpdated)
            AddHandler resourcesTableAdapter.Adapter.RowUpdated, New OleDbRowUpdatedEventHandler(AddressOf resourcesTableAdapter_RowUpdated)
            schedulerControl1.Start = New DateTime(2016, 11, 10)
        End Sub

#End Region
#Region "InitControlValues"
        Private Sub InitControlValues()
            Dim type As PercentCompleteDisplayType = GanttAppointmentDisplayOptions.PercentCompleteDisplayType
            chkShowBar.Checked = type.Equals(PercentCompleteDisplayType.Both) OrElse type.Equals(PercentCompleteDisplayType.BarProgress)
            chkShowNumber.Checked = type.Equals(PercentCompleteDisplayType.Both) OrElse type.Equals(PercentCompleteDisplayType.Number)
        End Sub

#End Region
#Region "UpdateControls"
        Private Sub UnsubscribeEvents()
            RemoveHandler chkAutoHeightCells.CheckedChanged, New EventHandler(AddressOf chkAutoHeightCells_CheckedChanged)
            RemoveHandler chkShowResourceHeaders.CheckedChanged, New EventHandler(AddressOf chkShowResourceHeaders_CheckedChanged)
            RemoveHandler spinResourcesPerPage.EditValueChanged, New EventHandler(AddressOf spinResourcesPerPage_EditValueChanged)
            RemoveHandler chkShowBar.CheckedChanged, New EventHandler(AddressOf ShowProgressAsChanged)
            RemoveHandler chkShowNumber.CheckedChanged, New EventHandler(AddressOf ShowProgressAsChanged)
            RemoveHandler splitContainerControl1.SplitterPositionChanged, New EventHandler(AddressOf splitContainerControl1_SplitterPositionChanged)
        End Sub

        Private Sub SubscribeEvents()
            AddHandler chkAutoHeightCells.CheckedChanged, New EventHandler(AddressOf chkAutoHeightCells_CheckedChanged)
            AddHandler chkShowResourceHeaders.CheckedChanged, New EventHandler(AddressOf chkShowResourceHeaders_CheckedChanged)
            AddHandler spinResourcesPerPage.EditValueChanged, New EventHandler(AddressOf spinResourcesPerPage_EditValueChanged)
            AddHandler chkShowBar.CheckedChanged, New EventHandler(AddressOf ShowProgressAsChanged)
            AddHandler chkShowNumber.CheckedChanged, New EventHandler(AddressOf ShowProgressAsChanged)
            AddHandler splitContainerControl1.SplitterPositionChanged, New EventHandler(AddressOf splitContainerControl1_SplitterPositionChanged)
        End Sub

        Private Sub UpdateControls()
            UnsubscribeEvents()
            Try
                chkShowResourceHeaders.Checked = schedulerControl1.GanttView.ShowResourceHeaders
                chkAutoHeightCells.Checked = schedulerControl1.GanttView.CellsAutoHeightOptions.Enabled
                spinResourcesPerPage.EditValue = schedulerControl1.Views.GanttView.ResourcesPerPage
                LastSplitContainerControlSplitterPosition = splitContainerControl1.SplitterPosition
                chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment
                cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility
            Finally
                SubscribeEvents()
            End Try
        End Sub

#End Region
#Region "RowUpdated handlers"
        Private Sub tasksTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
            If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
                Dim id As Integer = 0
                Using cmd As OleDbCommand = New OleDbCommand("SELECT @@IDENTITY", tasksTableAdapter.Connection)
                    id = CInt(cmd.ExecuteScalar())
                End Using

                e.Row("Id") = id
            End If
        End Sub

        Private id2 As Integer = 0

        Private Sub taskDependenciesTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
            If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
                id2 = 0
                Using cmd As OleDbCommand = New OleDbCommand("SELECT @@IDENTITY", taskDependenciesTableAdapter.Connection)
                    id2 = CInt(cmd.ExecuteScalar())
                End Using

                e.Row("Id") = id2
            End If
        End Sub

        Private id3 As Integer = 0

        Private Sub resourcesTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
            If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
                id3 = 0
                Using cmd As OleDbCommand = New OleDbCommand("SELECT @@IDENTITY", resourcesTableAdapter.Connection)
                    id3 = CInt(cmd.ExecuteScalar())
                End Using

                e.Row("Id") = id3
            End If
        End Sub

#End Region
#Region "Appointment"
        Private Sub schedulerStorage1_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            CommitTask()
        End Sub

        Private Sub schedulerStorage1_AppointmentsDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            CommitTask()
        End Sub

        Private Sub schedulerStorage1_AppointmentsInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            CommitTask()
            Dim count As Integer = e.Objects.Count
            For i As Integer = 0 To count - 1
                Dim apt As Appointment = CType(e.Objects(i), Appointment)
                Dim rowView As DataRowView = TryCast(apt.GetRow(schedulerDataStorage1), DataRowView)
                Dim row As DataRow = rowView.Row
                If row Is Nothing Then Continue For
                schedulerDataStorage1.SetAppointmentId(apt, row("Id"))
            Next
        End Sub

        Private Sub CommitTask()
            'try {
            '    DataSet ch = this.tasksDataSet.GetChanges();
            '    TasksDataSet.TasksRow row = tasksDataSet.Tasks[0];
            '    DataTable cht = tasksDataSet.Tasks.GetChanges();
            '} catch {
            '}
            tasksTableAdapter.Update(tasksDataSet)
            tasksDataSet.AcceptChanges()
        End Sub

#End Region
#Region "Task Dependencies"
        Private Sub schedulerStorage1_AppointmentDependenciesChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            CommitTaskDependency()
        End Sub

        Private Sub schedulerStorage1_AppointmentDependenciesDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            CommitTaskDependency()
        End Sub

        Private Sub schedulerStorage1_AppointmentDependenciesInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            CommitTaskDependency()
        End Sub

        Private Sub CommitTaskDependency()
            taskDependenciesTableAdapter.Update(tasksDataSet)
            tasksDataSet.AcceptChanges()
        End Sub

#End Region
#Region "UI elelents event handles"
        Private Sub chkShowResourceHeaders_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)
            schedulerControl1.GanttView.ShowResourceHeaders = chkShowResourceHeaders.Checked
        End Sub

        Private Sub chkAutoHeightCells_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)
            schedulerControl1.GanttView.CellsAutoHeightOptions.Enabled = chkAutoHeightCells.Checked
        End Sub

        Private Sub spinResourcesPerPage_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl1.GanttView.ResourcesPerPage = Convert.ToInt32(spinResourcesPerPage.EditValue)
        End Sub

#Region "ResourcesTree hide/show"
        Private Sub chkShowResourcesTree_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)
        End Sub

        Private Sub splitContainerControl1_SplitterPositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            LastSplitContainerControlSplitterPosition = splitContainerControl1.SplitterPosition
        End Sub

#End Region
        Private Sub schedulerControl1_ActiveViewChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeEvents()
            Dim isGanttView As Boolean = schedulerControl1.ActiveViewType = SchedulerViewType.Gantt
            Try
                splitContainerControl1.SplitterPosition = If(isGanttView, LastSplitContainerControlSplitterPosition, 0)
            Finally
                SubscribeEvents()
            End Try
        End Sub

        Private Sub ShowProgressAsChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetPercentCompleteDisplateType()
        End Sub

#End Region
#Region "SetPercentCompleteDisplateType"
        Private Sub SetPercentCompleteDisplateType()
            GanttAppointmentDisplayOptions.PercentCompleteDisplayType = CalculatePercentCompleteDisplateType()
        End Sub

#End Region
#Region "CalculatePercentCompleteDisplateType"
        Private Function CalculatePercentCompleteDisplateType() As PercentCompleteDisplayType
            Dim isShowBar As Boolean = chkShowBar.Checked
            Dim isShowNumber As Boolean = chkShowNumber.Checked
            If isShowBar AndAlso isShowNumber Then Return PercentCompleteDisplayType.Both
            If isShowBar AndAlso Not isShowNumber Then Return PercentCompleteDisplayType.BarProgress
            If Not isShowBar AndAlso isShowNumber Then Return PercentCompleteDisplayType.Number
            Return PercentCompleteDisplayType.None
        End Function

#End Region
        Private Sub chkShowOverAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked
        End Sub

        Private Sub cbTimeIndicatorVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.EditValue, TimeIndicatorVisibility)
        End Sub
    End Class
End Namespace
