Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Class DemosInfo
        Inherits DevExpress.DXperience.Demos.ModulesInfo

        Const MaxMruCount As Integer = 3

        Private Shared ReadOnly DefaultPadding As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(8)

        Private Shared ReadOnly mruList As System.Collections.Generic.List(Of DevExpress.XtraSpreadsheet.Demos.DemoMruItem) = New System.Collections.Generic.List(Of DevExpress.XtraSpreadsheet.Demos.DemoMruItem)()

        Public Shared Sub DoShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal manager As DevExpress.XtraSpreadsheet.Demos.SpreadsheetRibbonMenuManager)
            Dim item As DevExpress.DXperience.Demos.ModuleInfo = DevExpress.XtraSpreadsheet.Demos.DemosInfo.GetItem(name)
            Dim currentCursor As System.Windows.Forms.Cursor = System.Windows.Forms.Cursor.Current
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Try
                Dim tutorial As DevExpress.XtraSpreadsheet.Demos.SpreadSheetTutorialControlBase = TryCast(item.TModule, DevExpress.XtraSpreadsheet.Demos.SpreadSheetTutorialControlBase)
                groupControl.Padding = If(tutorial.ShowWithPaddings, DevExpress.XtraSpreadsheet.Demos.DemosInfo.DefaultPadding, System.Windows.Forms.Padding.Empty)
                Dim oldModule As DevExpress.DXperience.Demos.ModuleInfo = Nothing
                Dim oldTutorial As System.Windows.Forms.Control = Nothing
                If DevExpress.DXperience.Demos.ModulesInfo.Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(DevExpress.DXperience.Demos.ModulesInfo.Instance.CurrentModuleBase.Name, name) Then Return
                    oldModule = DevExpress.DXperience.Demos.ModulesInfo.Instance.CurrentModuleBase
                    oldTutorial = DevExpress.DXperience.Demos.ModulesInfo.Instance.CurrentModuleBase.TModule
                End If

                tutorial.Bounds = groupControl.DisplayRectangle
                DevExpress.DXperience.Demos.ModulesInfo.Instance.CurrentModuleBase = item
                tutorial.Visible = False
                groupControl.Controls.Add(tutorial)
                tutorial.Dock = System.Windows.Forms.DockStyle.Fill
                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                Call DevExpress.XtraSpreadsheet.Demos.DemosInfo.AddToMru(item, tutorial)
                If oldTutorial IsNot Nothing Then
                    oldTutorial.Visible = False
                    groupControl.Controls.Remove(oldTutorial)
                End If

                Call DevExpress.XtraSpreadsheet.Demos.DemosInfo.PurgeMru()
            Finally
                System.Windows.Forms.Cursor.Current = currentCursor
            End Try

            Call DevExpress.DXperience.Demos.ModulesInfo.RaiseModuleChanged()
        End Sub

        Private Shared Sub AddToMru(ByVal [module] As DevExpress.DXperience.Demos.ModuleInfo, ByVal tutorial As System.Windows.Forms.Control)
            For i As Integer = 0 To DevExpress.XtraSpreadsheet.Demos.DemosInfo.mruList.Count - 1
                Dim item As DevExpress.XtraSpreadsheet.Demos.DemoMruItem = DevExpress.XtraSpreadsheet.Demos.DemosInfo.mruList(i)
                If Object.ReferenceEquals(item.[Module], [module]) Then
                    If i > 0 Then
                        Call DevExpress.XtraSpreadsheet.Demos.DemosInfo.mruList.RemoveAt(i)
                        Call DevExpress.XtraSpreadsheet.Demos.DemosInfo.mruList.Insert(0, item)
                    End If

                    Return
                End If
            Next

            Call DevExpress.XtraSpreadsheet.Demos.DemosInfo.mruList.Insert(0, New DevExpress.XtraSpreadsheet.Demos.DemoMruItem() With {.[Module] = [module], .TutorialControl = tutorial})
        End Sub

        Private Shared Sub PurgeMru()
            While DevExpress.XtraSpreadsheet.Demos.DemosInfo.mruList.Count > DevExpress.XtraSpreadsheet.Demos.DemosInfo.MaxMruCount
                Dim item As DevExpress.XtraSpreadsheet.Demos.DemoMruItem = DevExpress.XtraSpreadsheet.Demos.DemosInfo.mruList(DevExpress.XtraSpreadsheet.Demos.DemosInfo.mruList.Count - 1)
                item.TutorialControl.Dispose()
                item.[Module].ResetModule()
                Call DevExpress.XtraSpreadsheet.Demos.DemosInfo.mruList.RemoveAt(DevExpress.XtraSpreadsheet.Demos.DemosInfo.mruList.Count - 1)
            End While
        End Sub
    End Class
End Namespace
