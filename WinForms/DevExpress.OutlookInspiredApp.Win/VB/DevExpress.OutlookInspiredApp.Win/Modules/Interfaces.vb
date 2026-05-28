Imports System
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.DevAV.Modules

    Public Interface IRibbonModule

        ReadOnly Property Ribbon As RibbonControl

    End Interface

    Public Interface ISupportViewModel

        ReadOnly Property ViewModel As Object

        Sub ParentViewModelAttached()

    End Interface

    Public Interface ISupportFiltersVisibilityChangedEvent

        Event FiltersVisibilityChanged As EventHandler

        Sub RaiseFiltersVisibilityChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Interface
End Namespace
