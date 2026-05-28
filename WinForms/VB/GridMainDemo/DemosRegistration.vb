Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Linq

Namespace DevExpress.XtraGrid.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Private Shared Function GetBaseViewByControl(ByVal control As Control) As BaseView
            If control Is Nothing Then Return Nothing
            For Each grid As GridControl In control.Controls.OfType(Of GridControl)()
                Return grid.MainView
            Next

            'due latest changes within demos - need to do it recursive
            Return CheckControl(control, True)
        End Function

        Private Shared Function CheckControl(ByVal cntl As Control, ByVal checkChildren As Boolean) As BaseView
            If TypeOf cntl Is GridControl Then Return CType(cntl, GridControl).MainView
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

            Dim view As BaseView = GetBaseViewByControl(control)
            If view Is Nothing Then Return
            For Each gv As GridView In view.GridControl.ViewCollection.OfType(Of GridView)()
                gv.DestroyCustomization()
            Next
        End Sub

        Private Shared Sub UpdateOptions(ByVal control As Control)
            If control Is Nothing Then Return
            For Each ctrl As Control In control.Controls
                UpdateOptions(ctrl)
            Next

            Dim view As BaseView = GetBaseViewByControl(control)
            If view Is Nothing Then Return
            Enumerable.ToList(view.GridControl.ViewCollection.OfType(Of GridView)()).ForEach(Sub(v) v.OptionsCustomization.UseAdvancedCustomizationForm = Utils.DefaultBoolean.True)
        End Sub

        Public Shared Overloads Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal manager As GridRibbonMenuManager)
            If Instance.CurrentModuleBase IsNot Nothing Then
                If TypeOf Instance.CurrentModuleBase.TModule Is TutorialControl AndAlso CType(Instance.CurrentModuleBase.TModule, TutorialControl).IsActiveDemo Then Return
            End If

            Dim item As ModuleInfo = GetItem(name)
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
                Dim tc As TutorialControl = TryCast(item.TModule, TutorialControl)
                CloseCustomizationForm(oldTutorial)
                UpdateOptions(tutorial)
                If tc IsNot Nothing Then
                    manager.AllowExport(tc.ExportView)
                    manager.RefreshOptionsMenu(If(tc.ShowViewOptions, GetBaseViewByControl(tutorial), Nothing))
                Else
                    manager.AllowExport(Nothing)
                    manager.RefreshOptionsMenu(Nothing)
                End If

                manager.InitBlendingMenu(Nothing)
                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                If oldTutorial IsNot Nothing Then
                    oldTutorial.Visible = False
                    oldTutorial.Parent = Nothing
                End If
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub
    End Class
End Namespace
