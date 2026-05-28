Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.XtraTreeList.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Overloads Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal manager As TreeListRibbonMenuManager)
            Dim _item As ModuleInfo = GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Dim ctcb As CodeTutorialControlBase = TryCast(_item.TModule, CodeTutorialControlBase)
                If ctcb IsNot Nothing Then ctcb.SelectExampleByName(_item.CodeExampleName)
                Dim tutorial As TutorialControlBase = TryCast(_item.TModule, TutorialControlBase)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = _item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                Dim tc As TutorialControl = TryCast(_item.TModule, TutorialControl)
                CloseCustomizationForm(oldTutorial)
                UpdateOptions(tutorial)
                If tc IsNot Nothing Then
                    manager.AllowExport(If(tc.AllowPrintOptions, tc.MainControl, Nothing))
                    manager.RefreshOptionsMenu(tc)
                Else
                    manager.AllowExport(Nothing)
                    manager.RefreshOptionsMenu(Nothing)
                End If

                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                _item.WasShown = True
                If oldTutorial IsNot Nothing Then oldTutorial.Visible = False
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub

        Private Shared Function GetTreeList(ByVal control As Control) As TreeList
            If control Is Nothing Then Return Nothing
            For Each TreeList As TreeList In control.Controls.OfType(Of TreeList)()
                Return TreeList
            Next

            'due latest changes within demos - need to do it recursive
            Return CheckControl(control, True)
        End Function

        Private Shared Function CheckControl(ByVal cntl As Control, ByVal checkChildren As Boolean) As TreeList
            If TypeOf cntl Is TreeList Then Return CType(cntl, TreeList)
            If Not checkChildren Then Return Nothing
            For Each c As Control In cntl.Controls
                Dim res = CheckControl(c, checkChildren)
                If res IsNot Nothing Then Return res
            Next

            Return Nothing
        End Function

        Private Shared Sub CloseCustomizationForm(ByVal control As Control)
            If control Is Nothing Then Return
            For Each ctrl As Control In control.Controls
                CloseCustomizationForm(ctrl)
            Next

            Dim treeList As TreeList = GetTreeList(control)
            If treeList Is Nothing Then Return
            treeList.DestroyCustomization()
        End Sub

        Private Shared Sub UpdateOptions(ByVal control As Control)
            If control Is Nothing Then Return
            For Each ctrl As Control In control.Controls
                UpdateOptions(ctrl)
            Next

            Dim treeList As TreeList = GetTreeList(control)
            If treeList Is Nothing Then Return
            treeList.OptionsCustomization.UseAdvancedCustomizationForm = Utils.DefaultBoolean.True
        End Sub
    End Class
End Namespace
