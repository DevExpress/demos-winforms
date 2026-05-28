Imports DevExpress.DevAV
Imports DevExpress.DXperience.Demos
Imports DevExpress.HTML.Demos.Helpers
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports System
Imports System.Collections.Generic
Imports System.Drawing

Namespace DevExpress.HTML.Demos

    Public Partial Class SchedulerControlModule
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            schedulerControl1.Start = TutorialConstants.Today
            Dim schedulerData As SchedulerData = New SchedulerData()
            schedulerData.AttachToScheduler(schedulerControl1)
            LoadImages(schedulerData.Employees)
            schedulerTemplateCodeViewer1.Fill(schedulerControl1)
            schedulerControl1.GroupType = SchedulerGroupType.Resource
        End Sub

        Private Sub LoadImages(ByVal employees As Dictionary(Of String, Employee))
            Dim imageCollection As SvgImageCollection = New SvgImageCollection()
            imageCollection.ImageSize = New Size(32, 32)
            imageCollection.Add("location", Global.DevExpress.HTML.Demos.Properties.Resources.customerquicklocations)
            imageCollection.Add("meeting", Global.DevExpress.HTML.Demos.Properties.Resources.meeting)
            schedulerControl1.HtmlImages = imageCollection
        End Sub

        Private Sub schedulerControl1_AppointmentHtmlElementMouseClick(ByVal sender As Object, ByVal e As AppointmentHtmlElementMouseEventArgs)
            If e.Element.ClassName.Contains("btn") Then
                If e.Appointment.CustomFields("Employee") IsNot Nothing Then Call XtraMessageBox.Show(e.Appointment.CustomFields("Employee").ToString(), "Employee info")
            End If
        End Sub
    End Class
End Namespace
