Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.XtraBars

Namespace DevExpress.XtraNavBar.Demos

    Public Class TutorialsInfo
        Inherits ModulesInfo

        Const languageDir As String = "CS\"

        Private Shared Sub SetBarManager(ByVal ctrl As Control, ByVal manager As BarManager)
            For Each element As Control In ctrl.Controls
                Dim nc As NavBarControl = TryCast(element, NavBarControl)
                If nc IsNot Nothing Then nc.MenuManager = manager
                SetBarManager(element, manager)
            Next
        End Sub

        Public Shared Overloads Function ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal menu As LookAndFeelMenu, ByVal lookAndFeel As LookAndFeel.DefaultLookAndFeel) As Tutorials.ModuleBase
            Dim item As ModuleInfo = GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            group.Parent.SuspendLayout()
            group.SuspendLayout()
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then oldTutorial = Instance.CurrentModuleBase.TModule
                Dim tutorial As TutorialControl = TryCast(item.TModule, TutorialControl)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                Call SetBarManager(tutorial, menu.MainMenu.Manager)
                tutorial.Visible = True
                If oldTutorial IsNot Nothing Then oldTutorial.Visible = False
            Finally
                group.ResumeLayout(True)
                group.Parent.ResumeLayout(True)
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
            Dim [module] As Tutorials.ModuleBase = TryCast(Instance.CurrentModuleBase.TModule, Tutorials.ModuleBase)
            If [module] IsNot Nothing Then
                [module].TutorialInfo.Description = Instance.CurrentModuleBase.Description
                [module].TutorialInfo.TutorialName = Instance.CurrentModuleBase.Name
                [module].TutorialInfo.WhatsThisCodeFile = Instance.CurrentModuleBase.CodeFile
                [module].TutorialInfo.WhatsThisXMLFile = Instance.CurrentModuleBase.XMLFile
                Dim xmlFile As String = DataDirectoryHelper.GetDataFile([module].TutorialInfo.WhatsThisXMLFile)
                Dim codeFile As String = DataDirectoryHelper.GetDataFile([module].TutorialInfo.WhatsThisCodeFile)
                If Equals(xmlFile, "") Then [module].TutorialInfo.WhatsThisXMLFile = languageDir & [module].TutorialInfo.WhatsThisXMLFile
                If Equals(codeFile, "") Then [module].TutorialInfo.WhatsThisCodeFile = languageDir & [module].TutorialInfo.WhatsThisCodeFile
            End If

            Return [module]
        End Function
    End Class
End Namespace
