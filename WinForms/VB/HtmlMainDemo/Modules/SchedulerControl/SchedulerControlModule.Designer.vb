Namespace DevExpress.HTML.Demos

    Partial Class SchedulerControlModule

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.SchedulerControlModule))
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.schedulerTemplateCodeViewer1 = New DevExpress.HTML.Demos.SchedulerTemplateCodeViewer()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Appearance.Appointment.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.schedulerControl1.Appearance.Appointment.Options.UseFont = True
            Me.schedulerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl1.DataStorage = Me.schedulerDataStorage1
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentFlyout = False
            Me.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentForm = DevExpress.XtraScheduler.AllowDisplayAppointmentForm.Never
            Me.schedulerControl1.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.schedulerControl1.OptionsView.ResourceHeaders.ResourceHeaderHtmlTemplate.Styles = resources.GetString("schedulerControl1.OptionsView.ResourceHeaders.ResourceHeaderHtmlTemplate.Styles")
            Me.schedulerControl1.OptionsView.ResourceHeaders.ResourceHeaderHtmlTemplate.Tag = "Resource header template"
            Me.schedulerControl1.OptionsView.ResourceHeaders.ResourceHeaderHtmlTemplate.Template = "<div class=""root"">" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<img class=""image"" src='meeting' />" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""resourceHe" & "ader"">${Caption}</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbTab & "<div class=""description"">Meetings for workgroup</div>" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "</div>"
            Me.schedulerControl1.Size = New System.Drawing.Size(581, 432)
            Me.schedulerControl1.Start = New System.DateTime(2021, 10, 4, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.AgendaView.Enabled = False
            Me.schedulerControl1.Views.DayView.AppointmentDisplayOptions.StatusDisplayType = DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never
            Me.schedulerControl1.Views.DayView.HtmlTemplates.Appointment.Styles = resources.GetString("schedulerControl1.Views.DayView.HtmlTemplates.Appointment.Styles")
            Me.schedulerControl1.Views.DayView.HtmlTemplates.Appointment.Tag = "Appointment Template"
            Me.schedulerControl1.Views.DayView.HtmlTemplates.Appointment.Template = resources.GetString("schedulerControl1.Views.DayView.HtmlTemplates.Appointment.Template")
            Me.schedulerControl1.Views.DayView.ShowWorkTimeOnly = True
            Me.schedulerControl1.Views.DayView.TimeIndicatorDisplayOptions.Visibility = DevExpress.XtraScheduler.TimeIndicatorVisibility.Never
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.DayView.WorkTime = New DevExpress.XtraScheduler.WorkTimeInterval(System.TimeSpan.Parse("08:00:00"), System.TimeSpan.Parse("18:00:00"))
            Me.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl1.Views.GanttView.Enabled = False
            Me.schedulerControl1.Views.MonthView.Enabled = False
            Me.schedulerControl1.Views.TimelineView.Enabled = False
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl1.Views.YearView.UseOptimizedScrolling = False
            AddHandler Me.schedulerControl1.AppointmentHtmlElementMouseClick, New DevExpress.XtraScheduler.AppointmentHtmlElementMouseClickHandler(AddressOf Me.schedulerControl1_AppointmentHtmlElementMouseClick)
            ' 
            ' schedulerDataStorage1
            ' 
            ' 
            ' 
            ' 
            Me.schedulerDataStorage1.AppointmentDependencies.AutoReload = False
            ' 
            ' 
            ' 
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window)
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((194)))))), (CInt(((CByte((190))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb((CInt(((CByte((168)))))), (CInt(((CByte((213)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb((CInt(((CByte((193)))))), (CInt(((CByte((244)))))), (CInt(((CByte((156))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb((CInt(((CByte((243)))))), (CInt(((CByte((228)))))), (CInt(((CByte((199))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb((CInt(((CByte((244)))))), (CInt(((CByte((206)))))), (CInt(((CByte((147))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb((CInt(((CByte((199)))))), (CInt(((CByte((244)))))), (CInt(((CByte((255))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb((CInt(((CByte((207)))))), (CInt(((CByte((219)))))), (CInt(((CByte((152))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((207)))))), (CInt(((CByte((233))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb((CInt(((CByte((141)))))), (CInt(((CByte((233)))))), (CInt(((CByte((223))))))))
            Me.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((247)))))), (CInt(((CByte((165))))))))
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.schedulerTemplateCodeViewer1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(581, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(400, 432)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' schedulerTemplateCodeViewer1
            ' 
            Me.schedulerTemplateCodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerTemplateCodeViewer1.Location = New System.Drawing.Point(1, 0)
            Me.schedulerTemplateCodeViewer1.Margin = New System.Windows.Forms.Padding(6)
            Me.schedulerTemplateCodeViewer1.Name = "schedulerTemplateCodeViewer1"
            Me.schedulerTemplateCodeViewer1.Size = New System.Drawing.Size(399, 432)
            Me.schedulerTemplateCodeViewer1.TabIndex = 1
            ' 
            ' SchedulerControlModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "SchedulerControlModule"
            Me.Size = New System.Drawing.Size(981, 432)
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerDataStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage

        Private schedulerTemplateCodeViewer1 As DevExpress.HTML.Demos.SchedulerTemplateCodeViewer

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace
