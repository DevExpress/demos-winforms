Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.VideoRent.Reports
Namespace DevExpress.VideoRent.Win.ModulesReports
	Partial Public Class FilmInfoCard
		Inherits ReportModuleBase
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Function CreateReport() As ReportBase
			Return New FilmInfoCardReport()
		End Function
	End Class
End Namespace
