Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo

Namespace DevExpress.Xpo.Demos
    Partial Public Class DeletingPersistentObjects
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DeletingPersistentObjects_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitEditors()
            ' If the 'Project' table is empty, adds new records and reloads the xpProjects collection.
            If xpProjects.Count = 0 Then
                CreateProjects(unitOfWork1)
                xpProjects.Reload()
            End If
            ' If the 'ImmediateDeletionProject' table is empty, adds new records and reloads the xpImmediateDeletionProjects collection.
            If xpImmediateDeletionProjects.Count = 0 Then
                CreateImmediateDeletionProjects(unitOfWork2)
                xpImmediateDeletionProjects.Reload()
            End If
            UpdateImmediateDeleteButtonState()
        End Sub

#Region "Editors Initialization"
        Private Sub InitEditors()
            Me.repositoryItemImageComboBox1.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fixed", ProjectStatus.Fixed, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("New", ProjectStatus.New, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Postponed", ProjectStatus.Postponed, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rejected", ProjectStatus.Rejected, 3)})
            Me.repositoryItemImageComboBox2.Items.AddRange(New Object() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bug", ProjectType.Bug, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Request", ProjectType.Request, 1)})
            gridControl1.ForceInitialize()
            gridControl2.ForceInitialize()
        End Sub
#End Region

        '<sbDeleteSelected>
        Private Sub sbDeleteSelected_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbDeleteSelected.Click
            Dim itemIndex As Integer = gridView1.GetDataSourceRowIndex(gridView1.FocusedRowHandle)
            If itemIndex < 0 Then
                Return
            End If
            unitOfWork1.Delete(xpProjects(itemIndex))
            unitOfWork1.CommitChanges()
            UpdateButtonState(gridView1.FocusedRowHandle)
        End Sub
        '</sbDeleteSelected>

        '<gridControl1>
        Private Sub gridView1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView1.RowStyle
            If e.RowHandle < 0 Then
                Return
            End If
            Dim itemIndex As Integer = gridView1.GetDataSourceRowIndex(e.RowHandle)
            If itemIndex < 0 Then
                Return
            End If
            Dim obj As Project = TryCast(xpProjects(itemIndex), Project)
            If Not obj Is Nothing AndAlso obj.IsDeleted Then
                e.Appearance.BackColor = Color.LightGray
                e.Appearance.ForeColor = Color.Gray
            End If
        End Sub

        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
            UpdateButtonState(e.FocusedRowHandle)
        End Sub

        Private Sub UpdateButtonState(ByVal rowHandle As Integer)
            Dim itemIndex As Integer = gridView1.GetDataSourceRowIndex(rowHandle)
            If itemIndex < 0 Then
                Return
            End If
            Dim obj As Project = TryCast(xpProjects(itemIndex), Project)
            sbRestore.Enabled = obj.IsDeleted
            sbDeleteSelected.Enabled = Not obj.IsDeleted
        End Sub
        '</gridControl1>

        '<sbRestore>
        Private Sub sbRestore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbRestore.Click
            RestorePersistentObject(gridView1.FocusedRowHandle, unitOfWork1)
            UpdateButtonState(gridView1.FocusedRowHandle)
        End Sub

        Private Sub RestorePersistentObject(ByVal rowHandle As Integer, ByVal uow As UnitOfWork)
            Dim itemIndex As Integer = gridView1.GetDataSourceRowIndex(rowHandle)
            If itemIndex < 0 Then
                Return
            End If
            Dim obj As Project = TryCast(xpProjects(itemIndex), Project)
            obj.SetMemberValue("GCRecord", Nothing)
            uow.CommitChanges()
        End Sub
        '</sbRestore>

        '<sbImmediateDelete>
        Private Sub sbImmediateDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbImmediateDelete.Click
            DeleteFocusedRecord(gridView2.FocusedRowHandle)
            UpdateImmediateDeleteButtonState()
        End Sub

        Private Sub DeleteFocusedRecord(ByVal rowHandle As Integer)
            If gridView2.RowCount = 0 Then
                Return
            End If
            Dim itemIndex As Integer = gridView2.GetDataSourceRowIndex(rowHandle)
            If itemIndex < 0 Then
                Return
            End If
            Dim obj As ImmediateDeletionProject = TryCast(xpImmediateDeletionProjects(itemIndex), ImmediateDeletionProject)
            obj.Delete()
            unitOfWork2.CommitChanges()
        End Sub
        '</sbImmediateDelete>

        Private Sub UpdateImmediateDeleteButtonState()
            If gridView2.RowCount > 0 Then
                sbImmediateDelete.Enabled = True
            Else
                sbImmediateDelete.Enabled = False
            End If
        End Sub

        '<sbAddNew>
        Private Sub sbAddNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAddNew.Click
            CreateNewImmediateDeletionProject()
            UpdateImmediateDeleteButtonState()
        End Sub

        Private Sub CreateNewImmediateDeletionProject()
            Dim prj As ImmediateDeletionProject = New ImmediateDeletionProject(unitOfWork2, "Test", "John Doe", DateTime.Today)
            prj.Save()
            xpImmediateDeletionProjects.Add(prj)
        End Sub
        '</sbAddNew>

        Public Overrides Sub ReloadData()
            xpProjects.Reload()
        End Sub
    End Class
End Namespace
