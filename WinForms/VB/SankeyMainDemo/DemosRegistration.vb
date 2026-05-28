Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraSankey.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Sub DoShowModule(ByVal name As String, ByVal group As GroupControl, ByVal manager As RibbonMenuManager)
            Dim item As ModuleInfo = GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Instance.CurrentModuleBase = item
                Dim tutorialBase As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorialBase.Bounds = group.DisplayRectangle
                tutorialBase.Visible = False
                group.Controls.Add(tutorialBase)
                tutorialBase.Dock = DockStyle.Fill
                tutorialBase.RibbonMenuManager = manager
                tutorialBase.TutorialName = name
                tutorialBase.Visible = True
                item.WasShown = True
                If oldTutorial IsNot Nothing Then oldTutorial.Visible = False
                Dim sankeyTutorial As SankeyTutorialControl = TryCast(tutorialBase, SankeyTutorialControl)
                If sankeyTutorial IsNot Nothing Then manager.AllowExport(sankeyTutorial.SankeyDiagramControl)
            Catch
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub
    End Class
End Namespace
