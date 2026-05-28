Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraCharts.Designer
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos

    Friend Class DemosInfo
        Inherits ModulesInfo

        Private Shared optionsPanelState As NavigationPaneState = NavigationPaneState.Expanded

        Friend Shared Function DoShowModule(ByVal name As String, ByVal group As GroupControl, ByVal manager As ChartRibbonMenuManager) As ChartDemoModule
            If Instance.CurrentModuleBase IsNot Nothing AndAlso Equals(Instance.CurrentModuleBase.Name, name) Then Return Nothing
            If Instance.CurrentModuleBase IsNot Nothing Then
                Dim oldModuleWithOptions As ChartDemoModuleWithOptions = TryCast(Instance.CurrentModuleBase.TModule, ChartDemoModuleWithOptions)
                If oldModuleWithOptions IsNot Nothing Then optionsPanelState = oldModuleWithOptions.OptionsPanelState
            End If

            Dim newModuleInfo As ModuleInfo = GetItem(name)
            Dim oldModule As ChartDemoModule = TryCast(CurrentModule, ChartDemoModule)
            If oldModule IsNot Nothing Then
                oldModule.Visible = False
                Dim moduleInfo As ModuleInfo = GetItem(oldModule.TutorialName)
                group.Controls.Remove(oldModule)
                moduleInfo.ResetModule()
                Instance.CurrentModuleBase = Nothing
                oldModule.Dispose()
            End If

            Dim newModule As ChartDemoModule = TryCast(newModuleInfo.TModule, ChartDemoModule) 'Module should be created in property getter
            newModule.Bounds = group.DisplayRectangle
            newModule.Visible = False
            newModule.Dock = DockStyle.Fill
            newModule.RibbonMenuManager = manager
            newModule.TutorialName = name
            Dim newModuleWithOptions As ChartDemoModuleWithOptions = TryCast(newModule, ChartDemoModuleWithOptions)
            If newModuleWithOptions IsNot Nothing Then newModuleWithOptions.OptionsPanelState = optionsPanelState
            group.Controls.Add(newModule)
            newModule.Visible = True
            Instance.CurrentModuleBase = newModuleInfo
            manager.AllowExport(newModule.ExportedObject)
            manager.ShowReservGroup1(True)
            newModuleInfo.WasShown = True
            Call RaiseModuleChanged()
            Return newModule
        End Function

        Friend Shared Sub SetPaletteName(ByVal paletteName As String)
            If Instance.CurrentModuleBase IsNot Nothing Then
                Dim chartDemoModule As ChartDemoModule = TryCast(Instance.CurrentModuleBase.TModule, ChartDemoModule)
                If chartDemoModule IsNot Nothing Then
                    chartDemoModule.PaletteName = paletteName
                    Return
                End If
            End If

            Return
        End Sub

        Friend Shared Function RunChartDesigner() As DialogResult
            If Instance.CurrentModuleBase IsNot Nothing Then
                Dim demoModule As ChartDemoModule = TryCast(Instance.CurrentModuleBase.TModule, ChartDemoModule)
                If demoModule IsNot Nothing Then
                    Dim chartDesigner As ChartDesigner = New ChartDesigner(demoModule.ChartControl)
                    Return chartDesigner.ShowDialog()
                End If
            End If

            Return DialogResult.Cancel
        End Function
    End Class
End Namespace
