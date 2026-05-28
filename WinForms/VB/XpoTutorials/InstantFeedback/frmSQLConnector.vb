Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo
Imports System.Xml
Imports DevExpress.Data.Filtering
Imports DevExpress.Internal

Namespace DevExpress.Xpo.Demos
	Partial Public Class frmSQLConnector
		Inherits XtraForm
		Private defaultDB As String = "ServerModeGridProjects"
		Private serverParameters As String = "SQLParameters.xml"
		Public Sub New()
			Me.New("Start Demo")
		End Sub
		Public Sub New(ByVal demoString As String)
			InitializeComponent()
			npMain.Text = ServerModeStrings.descriptionSQLConnection
			cbDatabase.Text = defaultDB
			sbAddRecords.Text += demoString
			sbGenerateDB.Text += demoString
            sbExit.Text += demoString
            teServer.Text = DbEngineDetector.GetSqlServerInstanceName()
			ShowParameters()
		End Sub

		Private Sub ShowParameters()
			If (Not System.IO.File.Exists(serverParameters)) Then
				Return
			End If
			sbExit.Enabled = True
			Dim doc As New XmlDocument()
			Try
				doc.Load(serverParameters)
			Catch
			End Try
			If doc.DocumentElement.Name = "Parameters" Then
				Dim prm() As String = doc.DocumentElement.InnerText.Split(New Char() {";"c})
				teServer.Text = prm(0)
				radioGroup1.SelectedIndex = Convert.ToInt32(prm(1))
				teLogin.Text = prm(2)
				tePassword.Text = prm(3)
			End If
			CheckRecords()
		End Sub

		Private Sub CheckRecords()
			Dim num As Integer = CalcRecordCount(GetDataBaseConnectionString())
			If num > 0 Then
				sbAddRecords.Enabled = True
				lbRecords.Text = String.Format(ServerModeStrings.recordCount, num)
			End If
		End Sub

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			Dim disable As Boolean = radioGroup1.SelectedIndex = 0
			DisableSQLServerAuthentication(disable)
		End Sub

		Private Sub DisableSQLServerAuthentication(ByVal disable As Boolean)
			teLogin.Enabled = Not disable
			tePassword.Enabled = Not disable
		End Sub
		Public ReadOnly Property ConnectionStringParameters() As String
			Get
				Return String.Format("{0};{1};{2};{3}", teServer.Text, radioGroup1.SelectedIndex, teLogin.Text, tePassword.Text)
			End Get
		End Property
		Private Function GetServerConnectionString() As String
			Dim connectionString As String = String.Format("data source={0};integrated security=SSPI", teServer.Text)
			If radioGroup1.SelectedIndex = 1 Then
				connectionString = String.Format("data source={0};user id={1};password={2}", teServer.Text, teLogin.Text, tePassword.Text)
			End If
			Return connectionString
		End Function

		Public Function GetDataBaseConnectionString() As String
			If DialogResult = System.Windows.Forms.DialogResult.Cancel Then
				Return String.Empty
			End If
			Dim connectionString As String = GetServerConnectionString()
			Return connectionString & ";initial catalog=" & cbDatabase.Text
		End Function

		Public Shared Function CalcRecordCount(ByVal serverConnectionString As String) As Integer
			Try
			   Using session As New Session()
				   session.AutoCreateOption = AutoCreateOption.None
				   session.ConnectionString = serverConnectionString
				   Return CInt(Fix(session.Evaluate(Of ServerSideGridTest)(New AggregateOperand(Nothing, Nothing, Aggregate.Count, Nothing), Nothing)))
			   End Using
			Catch
				Return 0
			End Try
		End Function

		Private Sub AddTableNames()
			Using connection As New SqlConnection(GetServerConnectionString())
				Try
					connection.Open()
				Catch
					XtraMessageBox.Show(ServerModeStrings.failedConnection, ServerModeStrings.failedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End Try
				Using command As New SqlCommand("select name from master..sysdatabases", connection)
					Using reader As SqlDataReader = command.ExecuteReader()
						cbDatabase.Properties.Items.Clear()
						Do While reader.Read()
							Dim name As String = reader.GetString(0)
							If "master;model;tempdb;msdb;pubs".IndexOf(name) < 0 Then
								cbDatabase.Properties.Items.Add(name)
							End If
						Loop
					End Using
				End Using
			End Using
		End Sub

		Private Sub cbDatabase_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs) Handles cbDatabase.QueryPopUp
			AddTableNames()
		End Sub

		Private Sub cbDatabase_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDatabase.EditValueChanged
			sbGenerateDB.Enabled = cbDatabase.Text = defaultDB
		End Sub

		Private Sub teServer_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles teServer.EditValueChanged
			cbDatabase.Text = defaultDB
			cbDatabase.Properties.Items.Clear()
		End Sub

		Public Shared Function CorrectConnection(ByVal serverConnectionString As String) As Boolean
			Dim cur As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Using connection As New SqlConnection(serverConnectionString)
				Try
					connection.Open()
					connection.Close()
				Catch
					XtraMessageBox.Show(ServerModeStrings.failedConnection, ServerModeStrings.failedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return False

				Finally
					Cursor.Current = cur
				End Try
			End Using
			Return True
		End Function

		Private Sub sbGenerateDB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbGenerateDB.Click
			GenerateRecords(True)
		End Sub

		Private Sub sbAddRecords_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbAddRecords.Click
			GenerateRecords(False)
		End Sub

		Private Sub GenerateRecords(ByVal clearRecords As Boolean)
			If (Not CorrectConnection(GetServerConnectionString())) Then
				Return
			End If
			Dim cur As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Dim store As IDataStore = XpoDefault.GetConnectionProvider(GetDataBaseConnectionString(), AutoCreateOption.DatabaseAndSchema)
			XpoDefault.DataLayer = New SimpleDataLayer(store)
			Text = ServerModeStrings.dataAdding
			Using uow As New UnitOfWork()
				If clearRecords Then
					Try
						uow.ClearDatabase()
					Catch
					End Try
				End If
				Dim [step] As Integer = CInt(Fix(seRecordCount.Value / 100))
                For i As Integer = 0 To CInt(seRecordCount.Value) - 1
                    OutlookData.CreateNewObject(uow)
                    If i Mod [step] = 0 Then
                        uow.CommitChanges()
                        progressBarControl1.Position = CInt(Fix(i * 100 / seRecordCount.Value))
                        Application.DoEvents()
                        Me.Refresh()
                        Cursor.Current = Cursors.WaitCursor
                    End If
                Next i
				uow.CommitChanges()
			End Using
			Cursor.Current = cur
			DialogResult = System.Windows.Forms.DialogResult.OK
			CloseForm()
		End Sub

		Private Sub sbExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbExit.Click
			DialogResult = System.Windows.Forms.DialogResult.No
			CloseForm()
		End Sub

		Private Sub CloseForm()
			If (Not CorrectConnection(GetServerConnectionString())) Then
				Return
			End If
			Try
				Using tw As New XmlTextWriter(serverParameters, System.Text.Encoding.UTF8)
					tw.WriteElementString("Parameters", ConnectionStringParameters)
				End Using
			Catch
			End Try
			Me.Close()
		End Sub

		Private Sub frmSQLConnector_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
		End Sub
	End Class
End Namespace
