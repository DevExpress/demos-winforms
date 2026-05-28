Imports DevExpress.Dialogs.Core.Items
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports DevExpress.XtraDialogs.Demos.Helpers.Data.VehiclesData

Namespace DevExpress.XtraDialogs.Demos

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

    Public Module LicenseInfo

        Public Sub SetToolTipController(ByVal [module] As TutorialControl, ByVal grid As GridControl)
            grid.ToolTipController = [module].LicenseToolTipController
            AddHandler [module].LicenseToolTipController.OnLicenseChanged, Sub(s, e) e.Info = GetLicenseInfo(e.Row)
        End Sub

        Private Function GetLicenseInfo(ByVal obj As Object) As String
            Dim item = TryCast(obj, ShellItemLink)
            If item IsNot Nothing Then
                Dim model = TryCast(item.Tag, Model)
                If model IsNot Nothing Then Return model.LicenseInfo
            End If

            Return Nothing
        End Function
    End Module
End Namespace
