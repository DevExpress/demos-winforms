Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraPdfViewer.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Sub DoShowModule(ByVal name As String, ByVal groupControl As XtraEditors.GroupControl, ByVal menuManager As RibbonMenuManager)
            Dim item As ModuleInfo = GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Dim viewer As ViewerModule = TryCast(item.TModule, ViewerModule)
                viewer.Bounds = groupControl.DisplayRectangle
                Instance.CurrentModuleBase = item
                viewer.Visible = False
                groupControl.Controls.Add(viewer)
                viewer.Dock = DockStyle.Fill
                viewer.RibbonMenuManager = menuManager
                viewer.TutorialName = name
                viewer.Visible = True
                item.WasShown = True
                If oldTutorial IsNot Nothing Then
                    oldTutorial.Visible = False
                End If
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub
    End Class

    Public Module DemoHelpers

        Public Function GetDocumentStream() As Stream
            Dim assembly As Assembly = Assembly.GetExecutingAssembly()
            Dim stream As Stream = assembly.GetManifestResourceStream("Demo.pdf")
            If stream Is Nothing Then Return assembly.GetManifestResourceStream("DevExpress.XtraPdfViewer.Demos.Data.Demo.pdf")
            Return stream
        End Function
    End Module
End Namespace
