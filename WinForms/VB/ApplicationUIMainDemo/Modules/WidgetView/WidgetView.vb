Imports System
Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Widget

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class WidgetView
        Inherits TutorialControlBase

        Private companyFullNames As Dictionary(Of String, String) = New Dictionary(Of String, String)()

        Public Sub New()
            InitializeComponent()
            FillCompaniesInformation()
            AddHandler documentManager.View.QueryControl, AddressOf View_QueryControl
            widgetView1.AllowDocumentStateChangeAnimation = Utils.DefaultBoolean.True
            ScaleElements()
        End Sub

        Private Sub ScaleElements()
            Dim dpiScaleFactor As Single = DpiProvider.Default.DpiScaleFactor
            For Each group As StackGroup In widgetView1.StackGroups
                group.Length.UnitValue *= dpiScaleFactor
            Next

            For Each doc As Document In documentManager.View.Documents
                doc.Height = CInt(Math.Round(doc.Height * dpiScaleFactor)) + If(dpiScaleFactor > 1, 2, 0)
            Next
        End Sub

        Private Sub View_QueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs)
            Dim widget As WidgetControl = New WidgetControl()
            widget.CompanyNameText = companyFullNames(e.Document.Caption)
            e.Control = widget
            TryCast(e.Document, Document).MaximizedControl = New MaximizedWidgetControl()
        End Sub

        Private Sub FillCompaniesInformation()
            companyFullNames.Add("AAPL", "Apple Inc.")
            companyFullNames.Add("YHOO", "Yahoo! Inc.")
            companyFullNames.Add("CSCO", "Cisco Systems Inc.")
            companyFullNames.Add("ADBE", "Adobe Systems Inc.")
            companyFullNames.Add("BAC", "Bank of America Corporation")
            companyFullNames.Add("DELL", "Dell Inc.")
            companyFullNames.Add("NVDA", "NVIDIA Corporation")
            companyFullNames.Add("HPQ", "Hewlett-Packard Company")
        End Sub
    End Class
End Namespace
