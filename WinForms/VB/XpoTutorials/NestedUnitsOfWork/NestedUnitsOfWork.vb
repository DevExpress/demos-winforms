Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors

Namespace DevExpress.Xpo.Demos
    Partial Public Class NestedUnitsOfWork
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Overrides Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.SetNewWhatsThisPadding() = value
            End Set
        End Property
#Region "Editors Initialization"
        Private Sub InitEditors()
            Me.repositoryItemImageComboBox1.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fixed", ProjectStatus.Fixed, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("New", ProjectStatus.New, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Postponed", ProjectStatus.Postponed, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rejected", ProjectStatus.Rejected, 3)})
            Me.repositoryItemImageComboBox2.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bug", ProjectType.Bug, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Request", ProjectType.Request, 1)})
        End Sub
#End Region
#Region "Creating Data"
        ' Adds records to the 'Project' table.
        Private Overloads Sub CreateProjects()
            Dim prj As Project = New Project(session1, "Enterprise Accounting System", "Web Edition: Data Entry Page", "Steve Lee", New DateTime(2003, 12, 4), ProjectStatus.Postponed, ProjectType.Request)
            prj.Save()
            prj = New Project(session1, "Enterprise Accounting System", "Transaction History", "Mike Roller", New DateTime(2004, 7, 27), ProjectStatus.Fixed, ProjectType.Bug)
            prj.Save()
            prj = New Project(session1, "Small-Business Accounting System", "Installer", "Bert Parkins", New DateTime(2004, 5, 12), ProjectStatus.New, ProjectType.Bug)
            prj.Save()

        End Sub
#End Region

        Private Sub NestedUnitsOfWork_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitEditors()
            ' If the 'Project' table is empty, adds new records and reloads the xpProjects collection.
            If xpProjects.Count = 0 Then
                Me.CreateProjects()
                xpProjects.Reload()
            End If
        End Sub

        '<gridControl1>
        Private Sub gridControl1_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gridControl1.EmbeddedNavigator.ButtonClick
            If e.Button.Tag Is Nothing OrElse e.Button.Tag.ToString() <> "EditRecord" Then
                Return
            End If
            ' Starts the nested unit of work.
            Using nuow As NestedUnitOfWork = xpProjects.Session.BeginNestedUnitOfWork()
                ' Retrieves the persistent object that corresponds to the currently focused grid row.
                Dim currentProject As Project = TryCast(nuow.GetNestedObject(xpProjects(gridView1.FocusedRowHandle)), Project)
                ' Creates the modal form so that an end-user can edit the current project.
                Using editForm As EditForm = New EditForm(currentProject, currentProject.ProjectName, iProjectType, iProjectStatus)
                    ' Shows the modal form. If the modal form's 'Save' button has been pressed, the changes made to the current project are saved to a database and the form is closed.
                    If editForm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        nuow.CommitChanges()
                    End If
                End Using
            End Using
        End Sub
        '</gridControl1>

        Public Overrides Sub ReloadData()
            xpProjects.Reload()
        End Sub

        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
            gridControl1.EmbeddedNavigator.Buttons.CustomButtons(0).Enabled = e.FocusedRowHandle >= 0
        End Sub
    End Class
End Namespace
