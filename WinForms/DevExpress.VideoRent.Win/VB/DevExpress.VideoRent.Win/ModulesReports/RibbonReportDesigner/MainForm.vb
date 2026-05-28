Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Helpers

Namespace RibbonReportDesigner
	Partial Public Class MainForm
		Inherits RibbonForm
		Public Sub New()
            InitializeComponent()
		End Sub
		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
			Close()
		End Sub
		Public Sub OpenReport(ByVal newReport As DevExpress.XtraReports.UI.XtraReport)
			reportDesigner1.OpenReport(newReport)
		End Sub
		Public Sub CreateNewReport()
			reportDesigner1.CreateNewReport()
		End Sub
		Public ReadOnly Property ActiveXRDesignPanel() As XRDesignPanel
			Get
				Return reportDesigner1.ActiveDesignPanel
			End Get
		End Property
	End Class
End Namespace
