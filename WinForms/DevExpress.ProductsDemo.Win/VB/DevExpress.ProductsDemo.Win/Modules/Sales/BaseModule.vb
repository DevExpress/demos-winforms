Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors

Namespace DevExpress.SalesDemo.Win.Modules
	Public Class BaseModule
		Inherits XtraUserControl
		Implements ISupportNavigation

		Public Overridable Sub Init(ByVal menuManager As BarManager)
		End Sub
		#Region "ISupportNavigation Members"
		Public Overridable Sub OnNavigatedFrom(ByVal args As INavigationArgs) Implements ISupportNavigation.OnNavigatedFrom
		End Sub
		Public Overridable Sub OnNavigatedTo(ByVal args As INavigationArgs) Implements ISupportNavigation.OnNavigatedTo
		End Sub
		#End Region
	End Class
End Namespace
