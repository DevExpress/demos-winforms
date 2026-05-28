Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraPrinting
Imports System.Collections.Generic
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.VideoRent.Reports

Namespace DevExpress.VideoRent.Win.ModulesReports
	Partial Public Class ReportModuleBase
		Inherits DevExpress.VideoRent.Win.TutorialControl
		Private report As ReportBase
		Private fileName As String = String.Empty
		Private showDesignerAfterPrint As Boolean = False

		Public Sub New()
			InitializeComponent()
			report = CreateReport()
			printControl.PrintingSystem = report.PrintingSystem
			fileName = GetReportPath(report, "repx")
			SetCommandsVisibility(report)
			AddHandler report.AfterPrint, AddressOf report_AfterPrint
		End Sub
		Protected Overridable Sub SetCommandsVisibility(ByVal report As ReportBase)
			report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, CommandVisibility.None)
			report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Open, CommandVisibility.None)
			report.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Save, CommandVisibility.None)
		End Sub
		Protected Overrides Sub DoHide()
			MyBase.DoHide()
			report.PrintingSystem.ExecCommand(PrintingSystemCommand.StopPageBuilding)
			If Not(TypeOf ModulesInfo.Instance.CurrentModuleBase.TModule Is ReportModuleBase) Then
				ParentFormMain.HidePreviewPage()
			End If
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			ParentFormMain.ShowPreviewPage()
            report.Session = Session

            If printControl IsNot Nothing AndAlso printControl.DockManager IsNot Nothing Then
                Dim navigationDockPanel As DevExpress.XtraBars.Docking.DockPanel = printControl.DockManager.Panels(New System.Guid("6b2e64eb-afd0-4676-bc3d-eca7e99946aa"))
                If navigationDockPanel IsNot Nothing Then
                    navigationDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
                End If
            End If

			ParentFormMain.PrintRibbonController.PrintControl = printControl
			If report.Pages.Count = 0 Then
				report.CreateDocument(True)
			End If
		End Sub
		Private Sub OnDesignerButtonClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			If ModulesInfo.Instance.CurrentModuleBase.TModule IsNot Me Then
				Return
			End If
			If report.PrintingSystem.Document.IsCreating Then
				showDesignerAfterPrint = True
				report.PrintingSystem.ExecCommand(PrintingSystemCommand.StopPageBuilding)
			Else
				ShowReportDesigner()
			End If
		End Sub
		Private Sub report_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
			report.PrintingSystem.Document.CanChangePageSettings = False
			If showDesignerAfterPrint Then
				showDesignerAfterPrint = False
				ShowReportDesigner()
			End If
		End Sub
		Private Sub ShowReportDesigner()
			Cursor.Current = Cursors.WaitCursor
			Dim saveFileName As String = GetReportPath(report, "sav")
			report.SaveLayout(saveFileName)
			Using newReport As XtraReport = XtraReport.FromFile(saveFileName, True)
				CType(newReport, ReportBase).Session = Me.Session
                Dim designForm As New RibbonReportDesigner.MainForm()
				designForm.AllowFormGlass = Me.ParentFormMain.AllowFormGlass
				designForm.Ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
				designForm.OpenReport(newReport)
				designForm.ActiveXRDesignPanel.FileName = fileName
				Cursor.Current = Cursors.Default
				ShowDesignerForm(designForm, Me.FindForm())
				Cursor.Current = Cursors.WaitCursor
				If designForm.ActiveXRDesignPanel.FileName <> fileName AndAlso File.Exists(designForm.ActiveXRDesignPanel.FileName) Then
					File.Copy(designForm.ActiveXRDesignPanel.FileName, fileName, True)
				End If
				designForm.Dispose()
			End Using
			If File.Exists(fileName) Then
				report.LoadLayout(fileName)
				File.Delete(fileName)
				Cursor.Current = Cursors.Default
				report.CreateDocument(True)
			End If
			File.Delete(saveFileName)
			Cursor.Current = Cursors.Default
		End Sub
		Private Shared Function GetReportPath(ByVal report As XtraReport, ByVal ext As String) As String
			Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
			Dim repName As String = report.Name
			If repName.Length = 0 Then
				repName = report.GetType().Name
			End If
			Dim dirName As String = Path.GetDirectoryName(asm.Location)
			Return Path.Combine(dirName, String.Format("{0}.{1}", repName, ext))
		End Function
		Private Sub ShowDesignerForm(ByVal designForm As Form, ByVal parentForm As Form)
			designForm.MinimumSize = parentForm.MinimumSize
			If parentForm.WindowState = FormWindowState.Normal Then
				designForm.Bounds = parentForm.Bounds
			End If
			designForm.WindowState = parentForm.WindowState
			parentForm.Visible = False
			designForm.ShowDialog()
			parentForm.Visible = True
		End Sub
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			report.CreateDocument(True)
		End Sub
		Protected Overrides Sub DoParentChanged()
			MyBase.DoParentChanged()
			ParentFormMain.SubscribeOnDesignerButtonClick(AddressOf OnDesignerButtonClick)
		End Sub
		Protected Overridable Function CreateReport() As ReportBase
			Return New ReportBase()
		End Function
	End Class
End Namespace
