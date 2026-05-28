Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList

Namespace DevExpress.XtraGantt.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Private Shared Function GetTreeListByControl(ByVal control As Control) As TreeList
            If control Is Nothing Then Return Nothing
            For Each cntl As Control In control.Controls
                If TypeOf cntl Is TreeList Then Return CType(cntl, TreeList)
            Next

            Return Nothing
        End Function

        Public Shared Sub CloseCustomizationForm(ByVal control As Control)
            Dim treeList As TreeList = GetTreeListByControl(control)
            If treeList IsNot Nothing Then treeList.DestroyCustomization()
        End Sub

        '
        Public Shared Overloads Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal manager As GanttRibbonMenuManager)
            If Instance IsNot Nothing AndAlso Instance.CurrentModuleBase IsNot Nothing Then
                Dim tControl = TryCast(Instance.CurrentModuleBase.TModule, TutorialControl)
                If tControl IsNot Nothing AndAlso tControl.IsActiveDemo Then Return
            End If

            Dim item As ModuleInfo = GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorialControl As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                    oldTutorialControl = Instance.CurrentModuleBase.TModule
                End If

                CloseCustomizationForm(oldTutorialControl)
                Dim ctc As CodeTutorialControlBase = TryCast(item.TModule, CodeTutorialControlBase)
                If ctc IsNot Nothing Then ctc.SelectExampleByName(item.CodeExampleName)
                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                Dim tc As TutorialControl = TryCast(item.TModule, TutorialControl)
                If tc IsNot Nothing Then
                    manager.AllowExport(If(tc.AllowPrintOptions, tc.MainControl, Nothing))
                    manager.AllowShowCriticalPath(If(tc.AllowShowCriticalPath, tc.MainControl, Nothing))
                    manager.RefreshViewMenu(tc.MainControl)
                Else
                    manager.RefreshViewMenu(Nothing)
                End If

                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                If oldTutorialControl IsNot Nothing Then oldTutorialControl.Visible = False
                Call RaiseModuleChanged()
            Finally
                Cursor.Current = currentCursor
            End Try
        End Sub
    End Class
End Namespace
