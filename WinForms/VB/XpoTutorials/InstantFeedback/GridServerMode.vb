Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo
Imports DevExpress.Utils

Namespace DevExpress.Xpo.Demos
	Partial Public Class GridServerMode
		Inherits TutorialControl
		Private writer As New LogWriter()
		Public Sub New()
			 If ServerModeStrings.SQLConnectionString = String.Empty Then
				ShowConnectionWizard()
			 End If
			Try
				Dim store As IDataStore = XpoDefault.GetConnectionProvider(ServerModeStrings.SQLConnectionString, AutoCreateOption.DatabaseAndSchema)
				store = New WaitCursorWrapper(store)
				store = New DataStoreLogger(store, writer)
				XpoDefault.DataLayer = New SimpleDataLayer(store)
			Catch
				XtraMessageBox.Show(ServerModeStrings.failedConnection, ServerModeStrings.failedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
				ServerModeStrings.SQLConnectionString = ""
			End Try
			InitializeComponent()
			xpInstantFeedbackSource1.DefaultSorting = "Sent desc"
			colOid.AllowSummaryMenu = False
			colHasAttachment.AllowSummaryMenu = False
			colOid.OptionsColumn.AllowGroup = DefaultBoolean.False
			colSize.OptionsColumn.AllowGroup = DefaultBoolean.False
			writer.Enabled = ceTracing.Checked
			writer.Console = xtraConsole1
		End Sub

		Private Sub ShowConnectionWizard()
			ShowConnectionWizard(String.Empty)
		End Sub
		Private Sub ShowConnectionWizard(ByVal demoString As String)
			Dim frm As frmSQLConnector = If(demoString = String.Empty, New frmSQLConnector(), New frmSQLConnector(demoString))
			frm.ShowDialog()
			ServerModeStrings.SQLConnectionString = frm.GetDataBaseConnectionString()
		End Sub

		Private Sub ceTracing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceTracing.CheckedChanged
			writer.Enabled = ceTracing.Checked
		End Sub

		Private Sub sbClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbClear.Click
			xtraConsole1.ClearText()
		End Sub

		Private Sub sbShowSQLConnection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbShowSQLConnection.Click
			ShowConnectionWizard("Return")
			'xpInstantFeedbackSource1.Reload();
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			unitOfWork1.CommitChanges()
			'xpInstantFeedbackSource1.Reload();
		End Sub
	End Class
End Namespace
