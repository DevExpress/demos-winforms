Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.VideoRent.Reports
Namespace DevExpress.VideoRent.Win.ModulesReports
	Partial Public Class TheMostProfitableGenresList
		Inherits ReportModuleBase
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Function CreateReport() As ReportBase
			Return New TheMostProfitableGenresListReport()
		End Function
	End Class
End Namespace
