Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraPrinting
Imports DevExpress.VideoRent.Reports

Namespace DevExpress.VideoRent.Win.ModulesReports
    Partial Public Class TopNFilms
        Inherits ReportModuleBase
        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Function CreateReport() As ReportBase
            Return New TopNFilmsReport()
        End Function
        Protected Overrides Sub SetCommandsVisibility(ByVal report As ReportBase)
            MyBase.SetCommandsVisibility(report)
            HideUnsupportedExportCommands(report)
            HideUnsupportedSendCommands(report)
        End Sub
        Private Shared Sub HideUnsupportedExportCommands(ByVal report As ReportBase)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportMht, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportHtm, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportCsv, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportXls, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportRtf, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportDocx, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportTxt, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportXlsx, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ExportXps, CommandVisibility.None)
        End Sub
        Private Shared Sub HideUnsupportedSendCommands(ByVal report As ReportBase)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendMht, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendCsv, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendXls, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendRtf, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendDocx, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendTxt, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendXlsx, CommandVisibility.None)
            report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.SendXps, CommandVisibility.None)
        End Sub
    End Class
End Namespace
