Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.Xpo.Demos
    Partial Public Class UnitsOfWork
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub UnitsOfWork_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitEditors()
            ' If the 'Project' table is empty, adds new records and reloads the xpProjects collection.
            If xpProjects.Count = 0 Then
                CreateProjects(unitOfWork1)
                xpProjects.Reload()
            End If
        End Sub

#Region "Editors Initialization"
        Private Sub InitEditors()
            Me.repositoryItemImageComboBox1.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fixed", ProjectStatus.Fixed, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("New", ProjectStatus.New, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Postponed", ProjectStatus.Postponed, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rejected", ProjectStatus.Rejected, 3)})
            Me.repositoryItemImageComboBox2.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bug", ProjectType.Bug, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Request", ProjectType.Request, 1)})
            Me.imageComboBoxEdit1.Properties.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fixed", ProjectStatus.Fixed, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("New", ProjectStatus.New, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Postponed", ProjectStatus.Postponed, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rejected", ProjectStatus.Rejected, 3)})
            Me.imageComboBoxEdit1.SelectedIndex = 0
        End Sub
#End Region

        '<simpleButton1>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
            If gridView1.SelectedRowsCount = 0 Then
                Return
            End If

            Dim status As ProjectStatus = CType((CType(imageComboBoxEdit1.SelectedItem, ImageComboBoxItem)).Value, ProjectStatus)

            Dim i As Integer = 0
            Do While i < gridView1.SelectedRowsCount
                CType(xpProjects(gridView1.GetDataSourceRowIndex(gridView1.GetSelectedRows()(i))), Project).Status = status
                i += 1
            Loop

            unitOfWork1.CommitChanges()
        End Sub
        '</simpleButton1>

        Public Overrides Sub ReloadData()
            xpProjects.Reload()
        End Sub
    End Class
End Namespace
