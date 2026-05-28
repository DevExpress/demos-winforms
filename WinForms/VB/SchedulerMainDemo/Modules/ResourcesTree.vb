Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb
Imports DevExpress.XtraTreeList

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class ResourcesTreeModule
        Inherits TutorialControl

        Private _lastSplitContainerControlSplitterPosition As Integer

        Public Sub New()
            InitializeComponent()
            LastSplitContainerControlSplitterPosition = 180
            resourcesTree1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.ShowAlways
        End Sub

        Private Sub ResourcesTreeModule_Load(ByVal sender As Object, ByVal e As EventArgs)
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

        Public ReadOnly Property ActiveTimeLineBasedView As TimelineView
            Get
                If schedulerControl1.ActiveViewType.Equals(SchedulerViewType.Gantt) Then Return schedulerControl1.GanttView
                Return schedulerControl1.TimelineView
            End Get
        End Property

#End Region
#Region "FillData"
        Private Sub FillData()
            Dim connectionString As String = DemoUtils.GetFileRelativePath("Tasks.mdb")
            If connectionString.Length <= 0 Then Return
            DemoUtils.SetConnectionString(tasksTableAdapter.Connection, connectionString)
            'DemoUtils.SetConnectionString(taskDependenciesTableAdapter.Connection, connectionString);
            DemoUtils.SetConnectionString(resourcesTableAdapter.Connection, connectionString)
            tasksTableAdapter.Fill(tasksDataSet.Tasks)
            'taskDependenciesTableAdapter.Fill(this.tasksDataSet.TaskDependencies);
            resourcesTableAdapter.Fill(tasksDataSet.Resources)
            AddHandler tasksTableAdapter.Adapter.RowUpdated, New OleDbRowUpdatedEventHandler(AddressOf tasksTableAdapter_RowUpdated)
            'this.taskDependenciesTableAdapter.Adapter.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(taskDependenciesTableAdapter_RowUpdated);
            AddHandler resourcesTableAdapter.Adapter.RowUpdated, New OleDbRowUpdatedEventHandler(AddressOf resourcesTableAdapter_RowUpdated)
            schedulerControl1.Start = New DateTime(2016, 11, 10)
        End Sub

#End Region
#Region "UpdateControls"
        Private Sub UnsubscribeEvents()
            RemoveHandler chkAutoHeightCells.CheckedChanged, New EventHandler(AddressOf chkAutoHeightCells_CheckedChanged)
            RemoveHandler chkShowResourceHeaders.CheckedChanged, New EventHandler(AddressOf chkShowResourceHeaders_CheckedChanged)
            RemoveHandler splitContainerControl1.SplitterPositionChanged, New EventHandler(AddressOf splitContainerControl1_SplitterPositionChanged)
            RemoveHandler chkAutoFilterRow.CheckedChanged, New EventHandler(AddressOf chkAutoFilterRow_CheckedChanged)
            RemoveHandler chkFilterPanel.CheckedChanged, New EventHandler(AddressOf chkFilterPanel_CheckedChanged)
            UnsubscribeSpinEditEvents()
        End Sub

        Private Sub SubscribeEvents()
            AddHandler chkAutoHeightCells.CheckedChanged, New EventHandler(AddressOf chkAutoHeightCells_CheckedChanged)
            AddHandler chkShowResourceHeaders.CheckedChanged, New EventHandler(AddressOf chkShowResourceHeaders_CheckedChanged)
            AddHandler splitContainerControl1.SplitterPositionChanged, New EventHandler(AddressOf splitContainerControl1_SplitterPositionChanged)
            AddHandler chkAutoFilterRow.CheckedChanged, New EventHandler(AddressOf chkAutoFilterRow_CheckedChanged)
            AddHandler chkFilterPanel.CheckedChanged, New EventHandler(AddressOf chkFilterPanel_CheckedChanged)
            SubscribeSpinEditEvents()
        End Sub

        Private Sub SubscribeSpinEditEvents()
            AddHandler spinResourcesPerPage.EditValueChanged, New EventHandler(AddressOf spinResourcesPerPage_EditValueChanged)
        End Sub

        Private Sub UnsubscribeSpinEditEvents()
            AddHandler spinResourcesPerPage.EditValueChanged, New EventHandler(AddressOf spinResourcesPerPage_EditValueChanged)
        End Sub

        Private Sub chkFilterPanel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            resourcesTree1.OptionsView.ShowFilterPanelMode = If(chkFilterPanel.Checked, ShowFilterPanelMode.ShowAlways, ShowFilterPanelMode.Never)
        End Sub

        Private Sub chkAutoFilterRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            resourcesTree1.OptionsView.ShowAutoFilterRow = chkAutoFilterRow.Checked
        End Sub

        Private Sub UpdateControls()
            UnsubscribeEvents()
            Try
                chkShowResourceHeaders.Checked = ActiveTimeLineBasedView.ShowResourceHeaders
                chkAutoHeightCells.Checked = ActiveTimeLineBasedView.CellsAutoHeightOptions.Enabled
                chkAutoFilterRow.Checked = resourcesTree1.OptionsView.ShowAutoFilterRow
                chkFilterPanel.Checked = resourcesTree1.OptionsView.ShowFilterPanelMode <> ShowFilterPanelMode.Never
                UpdateSpinEdit()
                LastSplitContainerControlSplitterPosition = splitContainerControl1.SplitterPosition
            Finally
                SubscribeEvents()
            End Try
        End Sub

        Private Sub UpdateSpinEdit()
            spinResourcesPerPage.EditValue = schedulerControl1.ActiveView.ResourcesPerPage
        End Sub

#End Region
#Region "RowUpdated handlers"
        Private id As Integer = 0

        Private Sub tasksTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
            If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
                id = 0
                Using cmd As OleDbCommand = New OleDbCommand("SELECT @@IDENTITY", tasksTableAdapter.Connection)
                    id = CInt(cmd.ExecuteScalar())
                End Using

                e.Row("Id") = id
            End If
        End Sub

        'int id2 = 0;
        'private void taskDependenciesTableAdapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e) {
        '    if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert) {
        '        id2 = 0;
        '        using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", taskDependenciesTableAdapter.Connection)) {
        '            id2 = (int)cmd.ExecuteScalar();
        '        }
        '        e.Row["Id"] = id2;
        '    }
        '}
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
            schedulerDataStorage1.SetAppointmentId(CType(e.Objects(0), Appointment), id)
        End Sub

        Private Sub CommitTask()
            tasksTableAdapter.Update(tasksDataSet)
            tasksDataSet.AcceptChanges()
        End Sub

#End Region
        '#region Task Dependencies
        'private void schedulerStorage1_AppointmentDependenciesChanged(object sender, PersistentObjectsEventArgs e) {
        '    CommitTaskDependency();
        '}
        'private void schedulerStorage1_AppointmentDependenciesDeleted(object sender, PersistentObjectsEventArgs e) {
        '    CommitTaskDependency();
        '}
        'private void schedulerStorage1_AppointmentDependenciesInserted(object sender, PersistentObjectsEventArgs e) {
        '    CommitTaskDependency();
        '}
        'void CommitTaskDependency() {
        '    taskDependenciesTableAdapter.Update(this.tasksDataSet);
        '    this.tasksDataSet.AcceptChanges();
        '}
        '#endregion
#Region "UI elelents event handles"
        Private Sub chkShowResourceHeaders_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)
            ActiveTimeLineBasedView.ShowResourceHeaders = chkShowResourceHeaders.Checked
        End Sub

        Private Sub chkAutoHeightCells_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)
            ActiveTimeLineBasedView.CellsAutoHeightOptions.Enabled = chkAutoHeightCells.Checked
        End Sub

        Private Sub spinResourcesPerPage_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ActiveTimeLineBasedView.ResourcesPerPage = Convert.ToInt32(spinResourcesPerPage.EditValue)
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
            Dim isTimeLine As Boolean = schedulerControl1.ActiveViewType.Equals(SchedulerViewType.Gantt) OrElse schedulerControl1.ActiveViewType.Equals(SchedulerViewType.Timeline)
            Try
                splitContainerControl1.SplitterPosition = If(isTimeLine, LastSplitContainerControlSplitterPosition, 0)
            Finally
                SubscribeEvents()
            End Try
        End Sub

#End Region
        Private Sub resourcesTree1_LayoutUpdated(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeSpinEditEvents()
            UpdateSpinEdit()
            SubscribeSpinEditEvents()
        End Sub
    End Class
End Namespace
