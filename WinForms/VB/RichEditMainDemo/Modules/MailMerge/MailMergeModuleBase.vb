Imports System
Imports System.Collections.Generic
Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit.Demos.Forms
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Linq

Namespace DevExpress.XtraRichEdit.Demos.Modules.MailMerge

    Public Class MailMergeModuleBase
        Inherits TutorialControl

        Protected Overridable ReadOnly Property TopLevelRecordSelector As GridView

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            FillDataSourceCore()
        End Sub

        Private Sub FillDataSourceCore()
            Dim path As String = DemoUtils.GetRelativePath("nwind.mdb")
            If path.Length <= 0 Then Return
            Using connection As OleDbConnection = New OleDbConnection()
                DemoUtils.SetConnectionString(connection, path)
                FillDataSource(connection)
            End Using
        End Sub

        Protected Overridable Sub FillDataSource(ByVal connection As OleDbConnection)
        End Sub

        Public Sub MergeToNewDocumentClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            Try
                Using form As MergeDatabaseRecordsForm = New MergeDatabaseRecordsForm()
                    If form.ShowDialog(Me) = DialogResult.OK Then
                        Dim options As MailMergeOptions = RichEdit.CreateMailMergeOptions()
                        UpdateMailMergeOptions(form.MergeRecords, options)
                        If form.MergeDestination = MergeDestination.NewTab Then
                            MailMergeToNewControl(options)
                        Else
                            MailMergeToNewFile(options)
                        End If
                    End If
                End Using
            Catch ex As Exception
                XtraMessageBox.Show($"Mail Merge failed:{Environment.NewLine} {ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Protected Sub UpdateMailMergeOptions(ByVal recordsMode As MergeRecords, ByVal options As MailMergeOptions)
            If recordsMode = MergeRecords.Selected AndAlso TopLevelRecordSelector IsNot Nothing Then
                Dim selectedRowIndexes As Integer() = TopLevelRecordSelector.GetSelectedRows()
                Dim selectedRows As List(Of Object) = selectedRowIndexes.[Select](New Func(Of Integer, Object)(AddressOf TopLevelRecordSelector.GetRow)).ToList()
                options.DataSource = selectedRows
            End If

            options.MergeMode = MergeMode.NewSection
        End Sub

        Private Sub MailMergeToNewControl(ByVal options As MailMergeOptions)
            Using form As MergeResultingDocumentForm = New MergeResultingDocumentForm()
                RichEdit.Document.MailMerge(options, form.Document)
                form.ShowDialog(Me)
            End Using
        End Sub

        Private Sub MailMergeToNewFile(ByVal options As MailMergeOptions)
            Using saveFileDialog As SaveFileDialog = New SaveFileDialog()
                saveFileDialog.Filter = "Word 2007 Document (*.docx)|*.docx"
                saveFileDialog.RestoreDirectory = True
                saveFileDialog.CheckFileExists = False
                saveFileDialog.CheckPathExists = True
                saveFileDialog.OverwritePrompt = True
                saveFileDialog.DereferenceLinks = True
                saveFileDialog.ValidateNames = True
                If saveFileDialog.ShowDialog(Me) <> DialogResult.OK Then Return
                Dim fileName As String = saveFileDialog.FileName
                RichEdit.Document.MailMerge(options, fileName, DocumentFormat.OpenXml)
                If XtraMessageBox.Show("Do you want to open this file?", "Mail Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Data.Utils.SafeProcess.Start(fileName)
            End Using
        End Sub
    End Class
End Namespace
