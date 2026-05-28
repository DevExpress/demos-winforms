Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraLayout.Demos.VehiclesDataSet

Namespace DevExpress.XtraLayout.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Overloads Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal manager As RibbonMenuManager)
            Dim item As ModuleInfo = DemosInfo.GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Dim ctc As CodeTutorialControlBase = TryCast(item.TModule, CodeTutorialControlBase)
                If ctc IsNot Nothing Then ctc.SelectExampleByName(item.CodeExampleName)
                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                Dim tc As TutorialControl = TryCast(tutorial, TutorialControl)
                If tc IsNot Nothing Then
                    manager.AllowExport(tc.ExportControl)
                Else
                    manager.AllowExport(Nothing)
                End If

                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                If oldTutorial IsNot Nothing Then oldTutorial.Visible = False
            Catch
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub

        Public NotInheritable Class LicenseInfo

            Public Shared Sub SetToolTipController(ByVal [module] As TutorialControl, ByVal grid As GridControl)
                grid.ToolTipController = [module].LicenseToolTipController
                AddHandler [module].LicenseToolTipController.OnLicenseChanged, Sub(s, e) e.Info = GetLicenseInfo(e.Row)
                [module].LicenseToolTipController.UpdateMaskOptions(grid)
            End Sub

            Private Shared Function GetLicenseInfo(ByVal obj As Object) As String
                Dim dRow = TryCast(obj, DataRowView)
                If dRow IsNot Nothing Then
                    Dim row As ModelRow = TryCast(dRow.Row, ModelRow)
                    If row IsNot Nothing Then Return $"{row.License_Name}|{row.Author}|{row.Source}|{row.Edits}"
                End If

                Return Nothing
            End Function
        End Class
    End Class
End Namespace
