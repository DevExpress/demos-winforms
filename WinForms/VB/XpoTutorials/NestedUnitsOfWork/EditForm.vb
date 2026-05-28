Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DevExpress.Xpo.Demos
    Partial Public Class EditForm
        Inherits DevExpress.XtraEditors.XtraForm
        Public Sub New(ByVal dataSource As Project, ByVal formCaption As String, ByVal iProjectType As ImageList, ByVal iStatus As ImageList)
            InitializeComponent()
            Me.dataSource = dataSource
            Me.Text = formCaption
            Me.imageComboBoxEdit1.Properties.SmallImages = iProjectType
            Me.imageComboBoxEdit2.Properties.SmallImages = iStatus
        End Sub

        Private dataSource As Project
#Region "Editors Initialization"
        Private Sub InitEditors()
            Me.imageComboBoxEdit1.Properties.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bug", ProjectType.Bug, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Request", ProjectType.Request, 1)})
            Me.imageComboBoxEdit2.Properties.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fixed", ProjectStatus.Fixed, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("New", ProjectStatus.New, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Postponed", ProjectStatus.Postponed, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rejected", ProjectStatus.Rejected, 3)})
        End Sub
#End Region

        Private Sub EditForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitEditors()
            If Not dataSource.Name Is Nothing Then
                lbName.Text = dataSource.Name
            End If
            teOwner.DataBindings.Add("EditValue", dataSource, "Owner")
            deCreatedDate.DataBindings.Add("EditValue", dataSource, "CreatedDate")
            imageComboBoxEdit1.DataBindings.Add("EditValue", dataSource, "ProjectType")
            imageComboBoxEdit2.DataBindings.Add("EditValue", dataSource, "Status")
        End Sub
    End Class
End Namespace
