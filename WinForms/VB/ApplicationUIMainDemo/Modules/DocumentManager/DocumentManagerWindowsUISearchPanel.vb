Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class DocumentManagerWindowsUISearchPanel
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            Dim ucDocumentManagerWindowsUI As ucDocumentManagerWindowsUISearchPanel = New ucDocumentManagerWindowsUISearchPanel()
            ucDocumentManagerWindowsUI.Dock = DockStyle.Fill
            panelControl1.Controls.Add(ucDocumentManagerWindowsUI)
        End Sub
    End Class
End Namespace
