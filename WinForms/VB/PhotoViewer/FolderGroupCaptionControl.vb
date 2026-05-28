Imports System
Imports System.ComponentModel
Imports System.IO

Namespace PhotoViewer

    Public Partial Class FolderGroupCaptionControl
        Inherits PhotoGroupCaptionControlBase

        Public Sub New()
            InitializeComponent()
        End Sub

        Private folderData As PathData

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property Folder As PathData
            Get
                Return folderData
            End Get

            Set(ByVal value As PathData)
                If Folder Is value Then Return
                folderData = value
                OnFolderChanged()
            End Set
        End Property

        Protected Overridable Sub OnFolderChanged()
            nameLabel.Text = Folder.Name
            dataLabel.Text = Directory.GetCreationTime(Folder.Path).ToShortDateString()
        End Sub

        Protected Overrides Sub OnGroupIconClick(ByVal sender As Object, ByVal e As EventArgs)
            DevExpress.Data.Utils.SafeProcess.Start(Folder.Path, String.Empty)
        End Sub

        Protected Overrides Sub OnRemoveButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            If MainForm IsNot Nothing Then MainForm.RemoveFolder(Folder)
        End Sub
    End Class
End Namespace
