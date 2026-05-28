Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.AnchorVertical

    Public Partial Class Report
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.AnchorName
            DisplayName = ReportNames.Anchor
        End Sub
    End Class

    Public Class ReportWeb
        Inherits Report

        Private LandscapeParameter As DevExpress.XtraReports.Parameters.Parameter

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Overloads Sub InitializeComponent()
            LandscapeParameter = New DevExpress.XtraReports.Parameters.Parameter()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' LandscapeParameter
            ' 
            LandscapeParameter.Description = "Landscape"
            LandscapeParameter.Name = "LandscapeParameter"
            LandscapeParameter.Type = GetType(Boolean)
            LandscapeParameter.ValueInfo = "False"
            ' 
            ' Report
            ' 
            Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {LandscapeParameter})
            ExpressionBindings.AddRange(New ExpressionBinding() {New ExpressionBinding("BeforePrint", "Landscape", "[Parameters.LandscapeParameter]")})
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
