Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports System.Windows.Forms

Namespace DevExpress.AI.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Overloads Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal manager As RibbonMenuManager)
            Dim item As ModuleInfo = GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Dim ctcb As CodeTutorialControlBase = TryCast(item.TModule, CodeTutorialControlBase)
                If ctcb IsNot Nothing Then ctcb.SelectExampleByName(item.CodeExampleName)
                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                If oldTutorial IsNot Nothing Then oldTutorial.Visible = False
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub
    End Class
End Namespace
