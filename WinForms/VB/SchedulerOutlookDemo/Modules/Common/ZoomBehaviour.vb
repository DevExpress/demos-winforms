Imports System
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraScheduler.Demos

    Public Module ZoomBehaviour

        Private Property TrackBarItem As BarEditItem

        Private Property Scheduler As SchedulerControl

        Private ReadOnly Property TrackBarRepositoryItem As RepositoryItemZoomTrackBar
            Get
                Return If(TrackBarItem IsNot Nothing, TryCast(TrackBarItem.Edit, RepositoryItemZoomTrackBar), Nothing)
            End Get
        End Property

        Public Sub RegisterZoomTracker(ByVal trackBarItem As BarEditItem)
            ZoomBehaviour.TrackBarItem = trackBarItem
            AddHandler ZoomBehaviour.TrackBarItem.EditValueChanged, AddressOf OnTrackBarItemEditValueChanged
        End Sub

        Public Sub Attach(ByVal scheduler As SchedulerControl)
            ZoomBehaviour.Scheduler = scheduler
            AddHandler scheduler.ActiveViewChanged, AddressOf OnSchedulerActiveViewChanged
            AddHandler scheduler.DayView.PropertyChanged, AddressOf OvViewPropertyChanged
            AddHandler scheduler.WorkWeekView.PropertyChanged, AddressOf OvViewPropertyChanged
            AddHandler scheduler.FullWeekView.PropertyChanged, AddressOf OvViewPropertyChanged
            Call UpdateTrackBar()
        End Sub

        Public Sub Detach(ByVal scheduler As SchedulerControl)
            RemoveHandler scheduler.ActiveViewChanged, AddressOf OnSchedulerActiveViewChanged
            RemoveHandler scheduler.DayView.PropertyChanged, AddressOf OvViewPropertyChanged
            RemoveHandler scheduler.WorkWeekView.PropertyChanged, AddressOf OvViewPropertyChanged
            RemoveHandler scheduler.FullWeekView.PropertyChanged, AddressOf OvViewPropertyChanged
            ZoomBehaviour.Scheduler = Nothing
            Call UpdateTrackBar()
        End Sub

        Private Sub OvViewPropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
            If Equals(e.PropertyName, "TimeScale") Then Call UpdateTrackBar()
        End Sub

        Private Sub OnTrackBarItemEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Call UpdateControl()
        End Sub

        Private Sub OnSchedulerActiveViewChanged(ByVal sender As Object, ByVal e As EventArgs)
            Call UpdateTrackBar()
        End Sub

        Private Sub UpdateControl()
            If Scheduler Is Nothing Then Return
            If TrackBarItem.EditValue Is Nothing Then Return
            Dim dayView As DayView = TryCast(Scheduler.ActiveView, DayView)
            If dayView IsNot Nothing Then dayView.TimeScale = dayView.TimeSlots(CInt(TrackBarItem.EditValue)).Value
            Dim timelineView As TimelineView = TryCast(Scheduler.ActiveView, TimelineView)
            If timelineView IsNot Nothing Then timelineView.GetBaseTimeScale().Width = CInt(TrackBarItem.EditValue)
        End Sub

        Private Sub UpdateTrackBar()
            If TrackBarItem Is Nothing OrElse TrackBarRepositoryItem Is Nothing Then Return
            If Scheduler Is Nothing Then
                TrackBarItem.Enabled = False
                TrackBarRepositoryItem.Maximum = 0
                TrackBarItem.EditValue = Nothing
                Return
            End If

            Dim dayView As DayView = TryCast(Scheduler.ActiveView, DayView)
            If dayView IsNot Nothing Then
                TrackBarRepositoryItem.Minimum = 0
                TrackBarRepositoryItem.Middle = 1
                TrackBarRepositoryItem.Maximum = dayView.TimeSlots.Count - 1
                TrackBarItem.EditValue = GetTimeSlotIndex(dayView.TimeSlots, dayView.TimeScale)
            End If

            Dim timelineView As TimelineView = TryCast(Scheduler.ActiveView, TimelineView)
            If timelineView IsNot Nothing Then
                TrackBarRepositoryItem.Maximum = 100
                TrackBarRepositoryItem.Minimum = 40
                TrackBarItem.EditValue = timelineView.GetBaseTimeScale().Width
            End If

            TrackBarItem.Enabled = timelineView IsNot Nothing OrElse dayView IsNot Nothing
        End Sub

        Private Function GetTimeSlotIndex(ByVal timeSlots As TimeSlotCollection, ByVal scale As TimeSpan) As Integer
            For i As Integer = 0 To timeSlots.Count - 1
                If timeSlots(i).Value = scale Then Return i
            Next

            Return -1
        End Function
    End Module
End Namespace
