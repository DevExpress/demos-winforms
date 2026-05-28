Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraEditors

Namespace DevExpress.DevAV.Modules.Helpers

    Public Module FilterPaneHelper

        Public Sub SetupFiltersPane(ByVal parentViewModel As MainViewModel, ByVal viewModel As Object, ByVal filterPaneType As ModuleType, ByVal collapsedFilterPaneType As ModuleType, ByVal navigationPanel As RoundedSkinPanel, ByVal defaultNavigationSize As Size, ByVal filtersVisibilityChangedCore As Action(Of Object, EventArgs))
            Dim filterPane As Control = parentViewModel.GetNavigationModule(filterPaneType)
            Dim collapsedFilterPane As Control = parentViewModel.GetNavigationModule(collapsedFilterPaneType)
            EnsureModuleViewModel(filterPane, viewModel)
            EnsureModuleViewModel(collapsedFilterPane, viewModel)
            filterPane.Dock = DockStyle.Fill
            collapsedFilterPane.Dock = DockStyle.Left
            collapsedFilterPane.Visible = False
            navigationPanel.Size = defaultNavigationSize
            navigationPanel.Controls.Add(filterPane)
            navigationPanel.Controls.Add(collapsedFilterPane)
            filtersVisibilityChangedCore?.Invoke(navigationPanel, EventArgs.Empty)
        End Sub

        Public Sub SwitchFiltersVisibility(ByVal mainViewModel As MainViewModel, ByVal navigationPanel As RoundedSkinPanel, ByVal defaultPaneSize As Size, ByVal defaultCollapsedPaneSize As Size)
            If DXperience.Demos.MainFormHelper.TakeScreens Then
                navigationPanel.Visible = False
                Return
            End If

            Select Case mainViewModel.FiltersVisibility
                Case CollectionViewFiltersVisibility.Visible
                    navigationPanel.Visible = True
                    navigationPanel.Size = defaultPaneSize
                    navigationPanel.Controls(0).Visible = True
                    navigationPanel.Controls(1).Visible = False
                Case CollectionViewFiltersVisibility.Minimized
                    navigationPanel.Visible = True
                    navigationPanel.Size = defaultCollapsedPaneSize
                    navigationPanel.Controls(0).Visible = False
                    navigationPanel.Controls(1).Visible = True
                Case CollectionViewFiltersVisibility.Hidden
                    navigationPanel.Visible = False
            End Select
        End Sub
    End Module
End Namespace
