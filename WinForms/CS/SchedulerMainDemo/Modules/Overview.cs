using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Drawing;
#if !NET
using System.Data.Entity;
#endif

namespace DevExpress.XtraScheduler.Demos {
    public partial class OverviewModule : TutorialControl {
        GridHitInfo downHitInfo;
        MedicScheduleContext dataContext;
        SizeF scaleFactor;
        Dictionary<object, HospitalDepartment> hospitalDepartments = new Dictionary<object, HospitalDepartment>();

        public OverviewModule() {
            InitializeComponent();

            this.schedulerControl1.BeginUpdate();
            this.schedulerControl1.Start = MedicScheduleDataHelper.BaseDate;
            MedicScheduleDataHelper.CreateLabels(this.schedulerDataStorage1);
            MedicScheduleDataHelper.CreateStatuses(this.schedulerDataStorage1);
            this.dataContext = new MedicScheduleContext();
            this.dataContext.LoadData();
            InitializeMappings();
            this.schedulerDataStorage1.Resources.DataSource = this.dataContext.Medics.Local.ToBindingList();
            this.schedulerDataStorage1.Appointments.DataSource = this.dataContext.MedicalAppointments.Local.ToBindingList();
            this.schedulerControl1.OptionsView.ResourceHeaders.Height = 130 + (int)(45 * this.scaleFactor.Height);
            InitializePatinetGrid();
            InitializeGalleryControl();
            this.gridView1.Columns["Name"].SortOrder = ColumnSortOrder.Ascending;

            this.schedulerDataStorage1.AppointmentsChanged += schedulerStorage1_AppointmentsChanged;
            this.schedulerDataStorage1.AppointmentsInserted += schedulerStorage1_AppointmentsChanged;
            this.schedulerDataStorage1.AppointmentsDeleted += schedulerStorage1_AppointmentsChanged;
            this.schedulerControl1.CustomDrawResourceHeader += schedulerControl1_CustomDrawResourceHeader;
            this.schedulerControl1.InitAppointmentDisplayText += schedulerControl1_InitAppointmentDisplayText;
            this.schedulerControl1.CustomizeAppointmentFlyout += schedulerControl1_CustomizeAppointmentFlyout;
            this.schedulerControl1.AllowAppointmentConflicts += schedulerControl1_AllowAppointmentConflicts;
            this.schedulerControl1.AppointmentDrop += schedulerControl1_AppointmentDrop;

            this.galleryControl1.Gallery.ItemCheckedChanged += Gallery_ItemCheckedChanged;
            this.Resize += OverviewModule_Resize;
            UpdateSize();
            this.schedulerControl1.EndUpdate();
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);
            this.scaleFactor = factor;
        }
        void InitializeMappings() {
            AppointmentMappingInfo appointmentMapping = this.schedulerDataStorage1.Appointments.Mappings;
            appointmentMapping.AllDay = "AllDay";
            appointmentMapping.Description = "Note";
            appointmentMapping.Subject = "";
            appointmentMapping.Start = "StartTime";
            appointmentMapping.End = "EndTime";
            appointmentMapping.Label = "IssueId";
            appointmentMapping.Location = "Location";
            appointmentMapping.RecurrenceInfo = "RecurrenceInfo";
            appointmentMapping.ReminderInfo = "ReminderInfo";
            appointmentMapping.ResourceId = "MedicId";
            appointmentMapping.Status = "PaymentStatusId";
            appointmentMapping.Type = "EventType";

            AppointmentCustomFieldMapping customFieldMapping = new AppointmentCustomFieldMapping();
            customFieldMapping.Name = "Patient";
            customFieldMapping.ValueType = FieldValueType.Object;
            customFieldMapping.Member = "Patient";
            this.schedulerDataStorage1.Appointments.CustomFieldMappings.Add(customFieldMapping);

            ResourceMappingInfo resourceMapping = this.schedulerDataStorage1.Resources.Mappings;
            resourceMapping.Id = "Id";
            resourceMapping.Caption = "Name";
            resourceMapping.Image = "PhotoBytes";
        }

        void InitializeGalleryControl() {
            ResourceCollection resources = schedulerDataStorage1.Resources.Items;
            GalleryItemGroupCollection groups = this.galleryControlClient1.Gallery.Groups;
            foreach (Resource resource in resources) {
                Medic medic = resource.GetRow(this.schedulerDataStorage1) as Medic;
                if (medic == null)
                    continue;
                GalleryItemGroup group = groups.FirstOrDefault((g) => Object.Equals(g.Tag, medic.DepartmentId));
                if (group == null) {
                    group = CreateGalleryItemGroup(medic.DepartmentId);
                    groups.Add(group);
                }
                Image image = PictureMaskHelper.CreateCircleMaskImage(resource.GetImage(), 50);
                GalleryItem item = new GalleryItem(image, medic.Name, medic.Phone);
                item.Value = medic.Id;
                item.Checked = group.Caption == "Therapy";
                resource.Visible = item.Checked;
                group.Items.Add(item);
            }
        }
        HospitalDepartment GetHospitalDepartment(object id) {
            HospitalDepartment department = null;
            if (!hospitalDepartments.TryGetValue(id, out department)) {
                department = this.dataContext.HospitalDepartments.Find(id) ?? new HospitalDepartment();
                hospitalDepartments.Add(department.Id, department);
            }
            return department;
        }
        GalleryItemGroup CreateGalleryItemGroup(object id) {
            GalleryItemGroup group = new GalleryItemGroup();
            HospitalDepartment department = GetHospitalDepartment(id);
            group.Caption = department.Name;
            group.Tag = department.Id;
            return group;
        }

        void InitializePatinetGrid() {
            this.gridControl1.DataSource = this.dataContext.Patients.ToList();
        }

        void Gallery_ItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            ResourceDataStorage resources = schedulerDataStorage1.Resources;
            GalleryItem item = e.Item;
            Resource resource = resources.GetResourceById(item.Value);
            resource.Visible = item.Checked;
        }

        void schedulerControl1_CustomDrawResourceHeader(object sender, CustomDrawObjectEventArgs e) {
            GraphicsCache cache = e.Cache;
            ResourceHeader header = (ResourceHeader)e.ObjectInfo;
            Rectangle imageBounds = header.ImageBounds;
            Rectangle headerBounds = header.Bounds;
            imageBounds.Y = headerBounds.Y + 10;
            header.ImageBounds = imageBounds;
            Rectangle textBounds = new Rectangle(headerBounds.X, headerBounds.Bottom - (int)(this.scaleFactor.Height * 40), headerBounds.Width, (int)(this.scaleFactor.Height * 15));
            header.TextBounds = textBounds;
            e.DrawDefault();
            cache.DrawRectangle(cache.GetPen(Color.FromArgb(70, Color.Black)), Rectangle.Intersect(header.ImageBounds, header.ContentBounds));
            e.Handled = true;
            Medic medic = header.Resource.GetRow(this.schedulerDataStorage1) as Medic;
            if (medic == null)
                return;

            TextOptions textOptions = new TextOptions(HorzAlignment.Center, VertAlignment.Center, WordWrap.NoWrap, Trimming.EllipsisCharacter);
            Rectangle additionalCaptionBounds = new Rectangle(textBounds.X, textBounds.Bottom, textBounds.Width, textBounds.Height);
            cache.DrawString(GetHospitalDepartment(medic.DepartmentId).Name, header.CaptionAppearance.Font, Color.FromArgb(150, header.CaptionAppearance.ForeColor), additionalCaptionBounds, textOptions.GetStringFormat());
        }

        void OverviewModule_Resize(object sender, EventArgs e) {
            UpdateSize();
        }

        void UpdateSize() {
            this.splitContainerControl1.SplitterPosition = this.splitContainerControl1.Right - (int)(270 * this.scaleFactor.Width);
            this.accordionContentContainer1.Height = this.dateNavigator1.Height;
            int containerHeight = this.splitContainerControl1.Height - this.accordionContentContainer1.Bottom - (int)(64 * this.scaleFactor.Height);
            containerHeight = containerHeight / 2;
            this.accordionContentContainer2.Height = containerHeight;
            this.accordionContentContainer3.Height = containerHeight;
        }

        void schedulerControl1_AllowAppointmentConflicts(object sender, AppointmentConflictEventArgs e) {
            e.Conflicts.Clear();
            FillConflictedAppointmentsCollection(e.Conflicts, e.Interval, schedulerDataStorage1.Appointments.Items, e.AppointmentClone);
        }

        void FillConflictedAppointmentsCollection(AppointmentBaseCollection conflicts, TimeInterval interval, AppointmentBaseCollection collection, Appointment currentAppointment) {
            int appointmentCount = collection.Count;
            Patient currentPatient = (Patient)currentAppointment.CustomFields["Patient"];
            for (int i = 0; i < appointmentCount; i++) {
                Appointment appointment = collection[i];
                if (appointment == currentAppointment)
                    continue;
                TimeInterval appointmentTimeInterval = new TimeInterval(appointment.Start, appointment.End);
                if (appointmentTimeInterval.IntersectsWith(interval) & !(appointment.Start == interval.End || appointment.End == interval.Start)) {
                    if (appointment.ResourceId.Equals(currentAppointment.ResourceId))
                        conflicts.Add(appointment);
                    else {
                        Patient toCheckPatient = (Patient)appointment.CustomFields["Patient"];
                        if (toCheckPatient != null && toCheckPatient.Equals(currentPatient))
                            conflicts.Add(appointment);
                    }

                }
                if (appointment.Type.Equals(AppointmentType.Pattern))
                    FillConflictedAppointmentsCollection(conflicts, interval, appointment.GetExceptions(), currentAppointment);
            }
        }

        void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e) {
            this.dataContext.SaveChanges();
        }

        void schedulerControl1_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e) {
            Patient toCheckPatient = (Patient)e.Appointment.CustomFields["Patient"];
            e.Text = toCheckPatient == null ? String.Empty : toCheckPatient.Name;
        }

        void schedulerControl1_CustomizeAppointmentFlyout(object sender, CustomizeAppointmentFlyoutEventArgs e) {
            Patient toCheckPatient = (Patient)e.Appointment.CustomFields["Patient"];
            e.Subject = toCheckPatient == null ? String.Empty : toCheckPatient.Name;
            e.SubjectAppearance.Font = new Font(e.SubjectAppearance.Font, FontStyle.Regular);
            e.SubjectAppearance.Options.UseFont = true;
        }

        void gridView1_MouseMove(object sender, MouseEventArgs e) {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null) {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - (int)(dragSize.Width / 2),
                    downHitInfo.HitPoint.Y - (int)(dragSize.Height / 2)), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y))) {
                    view.GridControl.DoDragDrop(GetDragData(view), DragDropEffects.All);
                    downHitInfo = null;
                }
            }
        }

        SchedulerDragData GetDragData(GridView view) {
            int[] selection = view.GetSelectedRows();
            if (selection == null)
                return null;
            AppointmentBaseCollection appointments = new AppointmentBaseCollection();
            int count = selection.Length;
            for (int i = 0; i < count; i++) {
                int rowIndex = selection[i];
                Appointment apt = schedulerDataStorage1.CreateAppointment(AppointmentType.Normal);
                apt.CustomFields["Patient"] = view.GetRow(rowIndex);
                appointments.Add(apt);
            }

            return new SchedulerDragData(appointments, 0);
        }

        void gridView1_MouseDown(object sender, MouseEventArgs e) {
            GridView view = sender as GridView;
            downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None)
                return;
            if (e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.HitTest != GridHitTest.RowIndicator)
                downHitInfo = hitInfo;
        }

        void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e) {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            Modules.MedicalAppointmentForm form = new Modules.MedicalAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            form.SetMenuManager(this.schedulerControl1.MenuManager);
            form.SetDataContext(this.dataContext);
            try {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            } finally {
                form.Dispose();
            }
        }

        void schedulerControl1_AppointmentDrop(object sender, AppointmentDragEventArgs e) {
            string createEventMsg = "Creating an event at {0} on {1}.";
            string moveEventMsg = "Moving the event from {0} on {1} to {2} {3} on {4}.";

            Appointment sourceAppointment = e.SourceAppointment;
            Appointment editedAppointment = e.EditedAppointment;

            AppointmentTimeIntervalComparer intervalComparer = new AppointmentTimeIntervalComparer();
            if (intervalComparer.Compare(sourceAppointment, editedAppointment) == 0 && sourceAppointment.ResourceId == editedAppointment.ResourceId) {
                e.Allow = true;
                return;
            }

            DateTime srcStart = sourceAppointment.Start;
            DateTime newStart = editedAppointment.Start;
            bool isNewAppointment = srcStart == DateTime.MinValue;

            string resourceName = String.Empty;
            if (sourceAppointment.ResourceId != editedAppointment.ResourceId)
                resourceName = e.HitResource.Caption;

            string msg = isNewAppointment ? String.Format(createEventMsg, newStart.ToShortTimeString(), newStart.ToShortDateString()) :
                String.Format(moveEventMsg, srcStart.ToShortTimeString(), srcStart.ToShortDateString(), resourceName, newStart.ToShortTimeString(), newStart.ToShortDateString());

            if (XtraMessageBox.Show(msg + "\r\nProceed?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                e.Allow = false;
            } else if (isNewAppointment) {
                this.schedulerControl1.SelectedAppointments.Clear();
                this.schedulerControl1.SelectedAppointments.Add(e.EditedAppointment);
            }
        }
    }
}
