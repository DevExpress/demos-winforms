Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Helpers
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors
Imports DevExpress.XtraDialogs
Imports DevExpress.Utils.CommonDialogs

Namespace DevExpress.XtraDialogs.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("How to use the FolderBrowser dialog", "DialogAPIExamples.cs")>
    Public Module FolderBrowser

        Sub New()
            If DevExpress.XtraGrid.GridControl.AutoFilterRowHandle < 0 Then DevExpress.XtraEditors.Base.XtraCommonDialog.ForceInitialize()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim button As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton()
            button.Text = "Show dialog"
            button.Dock = System.Windows.Forms.DockStyle.Top
            button.Parent = sampleHost
            Dim edit As DevExpress.XtraEditors.TextEdit = New DevExpress.XtraEditors.TextEdit()
            edit.Dock = System.Windows.Forms.DockStyle.Top
            edit.Parent = sampleHost
            Return New Object() {button, edit}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        ' do cleanup 
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Using the FolderBrowserDialog (Standard)")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowDialog")>
        Public Sub StandardDialog(ByVal button As DevExpress.XtraEditors.SimpleButton, ByVal edit As DevExpress.XtraEditors.TextEdit)
            AddHandler button.Click, Sub(s, e)
                Using dialog = New System.Windows.Forms.FolderBrowserDialog()
                    dialog.SelectedPath = "C:\"
                    If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then edit.Text = dialog.SelectedPath
                End Using
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Using the XtraFolderBrowserDialog")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowDialog")>
        Public Sub SkinnableDialog(ByVal button As DevExpress.XtraEditors.SimpleButton, ByVal edit As DevExpress.XtraEditors.TextEdit)
            AddHandler button.Click, Sub(s, e)
                Using dialog = New DevExpress.XtraEditors.XtraFolderBrowserDialog()
                    dialog.SelectedPath = "C:\"
                    If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then edit.Text = dialog.SelectedPath
                End Using
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Using the XtraFolderBrowserDialog (Wide)")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowDialog", "DialogStyle")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("FolderBrowserDialogStyle")>
        Public Sub SkinnableWideDialog(ByVal button As DevExpress.XtraEditors.SimpleButton, ByVal edit As DevExpress.XtraEditors.TextEdit)
            AddHandler button.Click, Sub(s, e)
                Using dialog = New DevExpress.XtraEditors.XtraFolderBrowserDialog()
                    dialog.DialogStyle = DevExpress.Utils.CommonDialogs.FolderBrowserDialogStyle.Wide
                    dialog.SelectedPath = "C:\"
                    If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then edit.Text = dialog.SelectedPath
                End Using
            End Sub
        End Sub
    End Module
End Namespace
