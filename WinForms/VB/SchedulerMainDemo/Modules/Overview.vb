Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Drawing
#If Not NET
Imports System.Data.Entity

#End If
Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class OverviewModule
        Inherits TutorialControl

        Private downHitInfo As GridHitInfo

        Private dataContext As MedicScheduleContext

        Private scaleFactor As SizeF

        Private hospitalDepartments As Dictionary(Of Object, HospitalDepartment) = New Dictionary(Of Object, HospitalDepartment)()

        Public Sub New()
            InitializeComponent()
            schedulerControl1.BeginUpdate()
            schedulerControl1.Start = BaseDate
            CreateLabels(schedulerDataStorage1)
            CreateStatuses(schedulerDataStorage1)
            dataContext = New MedicScheduleContext()
            dataContext.LoadData()
            InitializeMappings()
            schedulerDataStorage1.Resources.DataSource = dataContext.Medics.Local.ToBindingList()
            schedulerDataStorage1.Appointments.DataSource = dataContext.MedicalAppointments.Local.ToBindingList()
            schedulerControl1.OptionsView.ResourceHeaders.Height = 130 + CInt(45 * scaleFactor.Height)
            InitializePatinetGrid()
            InitializeGalleryControl()
            gridView1.Columns("Name").SortOrder = ColumnSortOrder.Ascending
            AddHandler schedulerDataStorage1.AppointmentsChanged, AddressOf schedulerStorage1_AppointmentsChanged
            AddHandler schedulerDataStorage1.AppointmentsInserted, AddressOf schedulerStorage1_AppointmentsChanged
            AddHandler schedulerDataStorage1.AppointmentsDeleted, AddressOf schedulerStorage1_AppointmentsChanged
            AddHandler schedulerControl1.CustomDrawResourceHeader, AddressOf schedulerControl1_CustomDrawResourceHeader
            AddHandler schedulerControl1.InitAppointmentDisplayText, AddressOf schedulerControl1_InitAppointmentDisplayText
            AddHandler schedulerControl1.CustomizeAppointmentFlyout, AddressOf schedulerControl1_CustomizeAppointmentFlyout
            AddHandler schedulerControl1.AllowAppointmentConflicts, AddressOf schedulerControl1_AllowAppointmentConflicts
            AddHandler schedulerControl1.AppointmentDrop, AddressOf schedulerControl1_AppointmentDrop
            AddHandler galleryControl1.Gallery.ItemCheckedChanged, AddressOf Gallery_ItemCheckedChanged
            AddHandler Resize, AddressOf OverviewModule_Resize
            UpdateSize()
            schedulerControl1.EndUpdate()
        End Sub

        Protected Overrides Sub ScaleControl(ByVal factor As SizeF, ByVal specified As BoundsSpecified)
            MyBase.ScaleControl(factor, specified)
            scaleFactor = factor
        End Sub

        Private Sub InitializeMappings()
            Dim appointmentMapping As AppointmentMappingInfo = schedulerDataStorage1.Appointments.Mappings
            appointmentMapping.AllDay = "AllDay"
            appointmentMapping.Description = "Note"
            appointmentMapping.Subject = ""
            appointmentMapping.Start = "StartTime"
            appointmentMapping.End = "EndTime"
            appointmentMapping.Label = "IssueId"
            appointmentMapping.Location = "Location"
            appointmentMapping.RecurrenceInfo = "RecurrenceInfo"
            appointmentMapping.ReminderInfo = "ReminderInfo"
            appointmentMapping.ResourceId = "MedicId"
            appointmentMapping.Status = "PaymentStatusId"
            appointmentMapping.Type = "EventType"
            Dim customFieldMapping As AppointmentCustomFieldMapping = New AppointmentCustomFieldMapping()
            customFieldMapping.Name = "Patient"
            customFieldMapping.ValueType = FieldValueType.Object
            customFieldMapping.Member = "Patient"
            schedulerDataStorage1.Appointments.CustomFieldMappings.Add(customFieldMapping)
            Dim resourceMapping As ResourceMappingInfo = schedulerDataStorage1.Resources.Mappings
            resourceMapping.Id = "Id"
            resourceMapping.Caption = "Name"
            resourceMapping.Image = "PhotoBytes"
        End Sub

        Private Sub InitializeGalleryControl()
            Dim resources As ResourceCollection = schedulerDataStorage1.Resources.Items
            Dim groups As GalleryItemGroupCollection = galleryControlClient1.Gallery.Groups
            For Each resource As Resource In resources
                Dim medic As Medic = TryCast(resource.GetRow(schedulerDataStorage1), Medic)
                If medic Is Nothing Then Continue For
                Dim group As GalleryItemGroup = groups.FirstOrDefault(Function(g) Equals(g.Tag, medic.DepartmentId))
                If group Is Nothing Then
                    group = CreateGalleryItemGroup(medic.DepartmentId)
                    groups.Add(group)
                End If

                Dim image As Image = PictureMaskHelper.CreateCircleMaskImage(resource.GetImage(), 50)
                Dim item As GalleryItem = New GalleryItem(image, medic.Name, medic.Phone)
                item.Value = medic.Id
                item.Checked = Equals(group.Caption, "Therapy")
                resource.Visible = item.Checked
                group.Items.Add(item)
            Next
        End Sub

        Private Function GetHospitalDepartment(ByVal id As Object) As HospitalDepartment
            Dim department As HospitalDepartment = Nothing
            If Not hospitalDepartments.TryGetValue(id, department) Then
                department = If(dataContext.HospitalDepartments.Find(id), New HospitalDepartment())
                hospitalDepartments.Add(department.Id, department)
            End If

            Return department
        End Function

        Private Function CreateGalleryItemGroup(ByVal id As Object) As GalleryItemGroup
            Dim group As GalleryItemGroup = New GalleryItemGroup()
            Dim department As HospitalDepartment = GetHospitalDepartment(id)
            group.Caption = department.Name
            group.Tag = department.Id
            Return group
        End Function

        Private Sub InitializePatinetGrid()
            gridControl1.DataSource = dataContext.Patients.ToList()
        End Sub

        Private Sub Gallery_ItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            Dim resources As ResourceDataStorage = schedulerDataStorage1.Resources
            Dim item As GalleryItem = e.Item
            Dim resource As Resource = resources.GetResourceById(item.Value)
            resource.Visible = item.Checked
        End Sub

        Private Sub schedulerControl1_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            Dim cache As GraphicsCache = e.Cache
            Dim header As ResourceHeader = CType(e.ObjectInfo, ResourceHeader)
            Dim imageBounds As Rectangle = header.ImageBounds
            Dim headerBounds As Rectangle = header.Bounds
            imageBounds.Y = headerBounds.Y + 10
            header.ImageBounds = imageBounds
            Dim textBounds As Rectangle = New Rectangle(headerBounds.X, headerBounds.Bottom - CInt(scaleFactor.Height * 40), headerBounds.Width, CInt(scaleFactor.Height * 15))
            header.TextBounds = textBounds
            e.DrawDefault()
            cache.DrawRectangle(cache.GetPen(Color.FromArgb(70, Color.Black)), Rectangle.Intersect(header.ImageBounds, header.ContentBounds))
            e.Handled = True
            Dim medic As Medic = TryCast(header.Resource.GetRow(schedulerDataStorage1), Medic)
            If medic Is Nothing Then Return
            Dim textOptions As TextOptions = New TextOptions(HorzAlignment.Center, VertAlignment.Center, WordWrap.NoWrap, Trimming.EllipsisCharacter)
            Dim additionalCaptionBounds As Rectangle = New Rectangle(textBounds.X, textBounds.Bottom, textBounds.Width, textBounds.Height)
            cache.DrawString(GetHospitalDepartment(medic.DepartmentId).Name, header.CaptionAppearance.Font, Color.FromArgb(150, header.CaptionAppearance.ForeColor), additionalCaptionBounds, textOptions.GetStringFormat())
        End Sub

        Private Sub OverviewModule_Resize(ByVal sender As Object, ByVal e As EventArgs)
            UpdateSize()
        End Sub

        Private Sub UpdateSize()
            splitContainerControl1.SplitterPosition = splitContainerControl1.Right - CInt(270 * scaleFactor.Width)
            accordionContentContainer1.Height = dateNavigator1.Height
            Dim containerHeight As Integer = splitContainerControl1.Height - accordionContentContainer1.Bottom - CInt(64 * scaleFactor.Height)
            containerHeight = containerHeight \ 2
            accordionContentContainer2.Height = containerHeight
            accordionContentContainer3.Height = containerHeight
        End Sub

        Private Sub schedulerControl1_AllowAppointmentConflicts(ByVal sender As Object, ByVal e As AppointmentConflictEventArgs)
            e.Conflicts.Clear()
            FillConflictedAppointmentsCollection(e.Conflicts, e.Interval, schedulerDataStorage1.Appointments.Items, e.AppointmentClone)
        End Sub

        Private Sub FillConflictedAppointmentsCollection(ByVal conflicts As AppointmentBaseCollection, ByVal interval As TimeInterval, ByVal collection As AppointmentBaseCollection, ByVal currentAppointment As Appointment)
            Dim appointmentCount As Integer = collection.Count
            Dim currentPatient As Patient = CType(currentAppointment.CustomFields("Patient"), Patient)
            For i As Integer = 0 To appointmentCount - 1
                Dim appointment As Appointment = collection(i)
                If appointment Is currentAppointment Then Continue For
                Dim appointmentTimeInterval As TimeInterval = New TimeInterval(appointment.Start, appointment.End)
                If appointmentTimeInterval.IntersectsWith(interval) And Not(appointment.Start = interval.End OrElse appointment.End = interval.Start) Then
                    If appointment.ResourceId.Equals(currentAppointment.ResourceId) Then
                        conflicts.Add(appointment)
                    Else
                        Dim toCheckPatient As Patient = CType(appointment.CustomFields("Patient"), Patient)
                        If toCheckPatient IsNot Nothing AndAlso toCheckPatient.Equals(currentPatient) Then conflicts.Add(appointment)
                    End If
                End If

                If appointment.Type.Equals(AppointmentType.Pattern) Then FillConflictedAppointmentsCollection(conflicts, interval, appointment.GetExceptions(), currentAppointment)
            Next
        End Sub

        Private Sub schedulerStorage1_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            dataContext.SaveChanges()
        End Sub

        Private Sub schedulerControl1_InitAppointmentDisplayText(ByVal sender As Object, ByVal e As AppointmentDisplayTextEventArgs)
            Dim toCheckPatient As Patient = CType(e.Appointment.CustomFields("Patient"), Patient)
            e.Text = If(toCheckPatient Is Nothing, String.Empty, toCheckPatient.Name)
        End Sub

        Private Sub schedulerControl1_CustomizeAppointmentFlyout(ByVal sender As Object, ByVal e As CustomizeAppointmentFlyoutEventArgs)
            Dim toCheckPatient As Patient = CType(e.Appointment.CustomFields("Patient"), Patient)
            e.Subject = If(toCheckPatient Is Nothing, String.Empty, toCheckPatient.Name)
            e.SubjectAppearance.Font = New Font(e.SubjectAppearance.Font, FontStyle.Regular)
            e.SubjectAppearance.Options.UseFont = True
        End Sub

        Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
                Dim dragSize As Size = SystemInformation.DragSize
                Dim dragRect As Rectangle = New Rectangle(New Point(downHitInfo.HitPoint.X - CInt(dragSize.Width \ 2), downHitInfo.HitPoint.Y - CInt(dragSize.Height \ 2)), dragSize)
                If Not dragRect.Contains(New Point(e.X, e.Y)) Then
                    view.GridControl.DoDragDrop(GetDragData(view), DragDropEffects.All)
                    downHitInfo = Nothing
                End If
            End If
        End Sub

        Private Function GetDragData(ByVal view As GridView) As SchedulerDragData
            Dim selection As Integer() = view.GetSelectedRows()
            If selection Is Nothing Then Return Nothing
            Dim appointments As AppointmentBaseCollection = New AppointmentBaseCollection()
            Dim count As Integer = selection.Length
            For i As Integer = 0 To count - 1
                Dim rowIndex As Integer = selection(i)
                Dim apt As Appointment = schedulerDataStorage1.CreateAppointment(AppointmentType.Normal)
                apt.CustomFields("Patient") = view.GetRow(rowIndex)
                appointments.Add(apt)
            Next

            Return New SchedulerDragData(appointments, 0)
        End Function

        Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            downHitInfo = Nothing
            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ModifierKeys <> Keys.None Then Return
            If e.Button = MouseButtons.Left AndAlso hitInfo.InRow AndAlso hitInfo.HitTest <> GridHitTest.RowIndicator Then downHitInfo = hitInfo
        End Sub

        Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs)
            Dim scheduler As SchedulerControl = CType(sender, SchedulerControl)
            Dim form As Modules.MedicalAppointmentForm = New Modules.MedicalAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
            form.SetMenuManager(schedulerControl1.MenuManager)
            form.SetDataContext(dataContext)
            Try
                e.DialogResult = form.ShowDialog()
                e.Handled = True
            Finally
                form.Dispose()
            End Try
        End Sub

        Private Sub schedulerControl1_AppointmentDrop(ByVal sender As Object, ByVal e As AppointmentDragEventArgs)
            Dim createEventMsg As String = "Creating an event at {0} on {1}."
            Dim moveEventMsg As String = "Moving the event from {0} on {1} to {2} {3} on {4}."
            Dim sourceAppointment As Appointment = e.SourceAppointment
            Dim editedAppointment As Appointment = e.EditedAppointment
            Dim intervalComparer As AppointmentTimeIntervalComparer = New AppointmentTimeIntervalComparer()
            If intervalComparer.Compare(sourceAppointment, editedAppointment) = 0 AndAlso sourceAppointment.ResourceId Is editedAppointment.ResourceId Then
                e.Allow = True
                Return
            End If

            Dim srcStart As Date = sourceAppointment.Start
            Dim newStart As Date = editedAppointment.Start
            Dim isNewAppointment As Boolean = srcStart = Date.MinValue
            Dim resourceName As String = String.Empty
            If sourceAppointment.ResourceId IsNot editedAppointment.ResourceId Then resourceName = e.HitResource.Caption
            Dim msg As String = If(isNewAppointment, String.Format(createEventMsg, newStart.ToShortTimeString(), newStart.ToShortDateString()), String.Format(moveEventMsg, srcStart.ToShortTimeString(), srcStart.ToShortDateString(), resourceName, newStart.ToShortTimeString(), newStart.ToShortDateString()))
            If XtraMessageBox.Show(msg & Microsoft.VisualBasic.Constants.vbCrLf & "Proceed?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Allow = False
            ElseIf isNewAppointment Then
                schedulerControl1.SelectedAppointments.Clear()
                schedulerControl1.SelectedAppointments.Add(e.EditedAppointment)
            End If
        End Sub
    End Class
End Namespace
