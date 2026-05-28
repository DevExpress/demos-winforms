Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Internal
Imports DevExpress.Utils
Imports DevExpress.Utils.About
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraDialogs.Demos

    Public Partial Class Overview
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            initialPath = Path.GetDirectoryName(DataDirectoryHelper.GetDataFile(defaultFileName))
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {WhatsThisXMLFileName}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "Overview"
            End Get
        End Property

        Private initialPath As String = String.Empty

        Const defaultFileName As String = "DemoText.txt"

        Private Sub OpenItemClick(ByVal sender As Object, ByVal e As EventArgs)
            '<loadButton>
            Using dialog = New XtraOpenFileDialog()
                dialog.InitialDirectory = initialPath
                dialog.ShowDragDropConfirmation = True
                dialog.AutoUpdateFilterDescription = False
                dialog.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*"
                Dim dialogResult = dialog.ShowDialog()
                If dialogResult = DialogResult.OK Then
                    If Equals(Path.GetExtension(dialog.FileName).ToLower(), ".txt") Then
                        mainModule.LoadDocument(dialog.FileName)
                    Else
                        XtraMessageBox.Show(Me, "Invalid file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End Using
        '</loadButton>
        End Sub

        Private Sub SaveItemClick(ByVal sender As Object, ByVal e As EventArgs)
            '<saveButton>
            Using dialog = New XtraSaveFileDialog()
                dialog.InitialDirectory = initialPath
                dialog.ShowDragDropConfirmation = True
                dialog.Filter = "Text files|*.txt"
                dialog.CreatePrompt = True
                dialog.OverwritePrompt = True
                Dim dialogResult = dialog.ShowDialog()
                If dialogResult = DialogResult.OK Then
                    mainModule.SaveDocument(dialog.FileName)
                End If
            End Using
        '</saveButton>
        End Sub

        Private Sub SetWorkingFolderItemClick(ByVal sender As Object, ByVal e As EventArgs)
            '<workingFolderButton>
            Using dialog As XtraFolderBrowserDialog = New XtraFolderBrowserDialog()
                dialog.DialogStyle = CommonDialogs.FolderBrowserDialogStyle.Wide
                dialog.SelectedPath = initialPath
                If dialog.ShowDialog() = DialogResult.OK Then
                    initialPath = dialog.SelectedPath
                End If
            End Using
        '</workingFolderButton>
        End Sub

        Private Sub MainModule_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            saveButton.Enabled = True
        End Sub
    End Class
End Namespace
