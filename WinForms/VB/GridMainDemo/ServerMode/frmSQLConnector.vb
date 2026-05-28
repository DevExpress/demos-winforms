Imports System
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Xml
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.Utils
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class frmSQLConnector
        Inherits XtraForm

        Private defaultDB As String = "ServerModeGridProjects"

        Private serverParameters As String = "SQLParameters.xml"

        Public Sub New()
            Me.New(Properties.Resources.StartDemo)
        End Sub

        Public Sub New(ByVal demoString As String)
            InitializeComponent()
            npMain.Text = Properties.Resources.DescriptionSQLConnection
            cbDatabase.Text = defaultDB
            sbAddRecords.Text += demoString
            sbGenerateDB.Text += demoString
            sbExit.Text += demoString
            teServer.Text = DbEngineDetector.GetSqlServerInstanceName()
            ShowParameters()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            ClientSize = New Size(ClientSize.Width, npMain.Height + MinHeight + Padding.Vertical)
        End Sub

        Private Sub ShowParameters()
            If Not IO.File.Exists(serverParameters) Then Return
            sbExit.Enabled = True
            Try
                Dim doc As XmlDocument = SafeXml.CreateDocument(serverParameters)
                If Equals(doc.DocumentElement.Name, "Parameters") Then
                    Dim prm As String() = doc.DocumentElement.InnerText.Split(New Char() {";"c})
                    teServer.Text = prm(0)
                    radioGroup1.SelectedIndex = Convert.ToInt32(prm(1))
                    teLogin.Text = prm(2)
                    tePassword.Text = prm(3)
                End If
            Catch
            End Try

            CheckRecords()
        End Sub

        Private ReadOnly Property MinHeight As Integer
            Get
                Return layoutControl1.Root.MinSize.Height
            End Get
        End Property

        Private Sub CheckRecords()
            Dim num As Integer = CalcRecordCount(GetDataBaseConnectionString())
            If num > 0 Then
                sbAddRecords.Enabled = True
                lbRecords.Text = String.Format(ServerModeStrings.recordCount, num)
            End If
        End Sub

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim disable As Boolean = radioGroup1.SelectedIndex = 0
            DisableSQLServerAuthentication(disable)
        End Sub

        Private Sub DisableSQLServerAuthentication(ByVal disable As Boolean)
            teLogin.Enabled = Not disable
            tePassword.Enabled = Not disable
        End Sub

        Public ReadOnly Property ConnectionStringParameters As String
            Get
                Return String.Format("{0};{1};{2};{3}", teServer.Text, radioGroup1.SelectedIndex, teLogin.Text, tePassword.Text)
            End Get
        End Property

        Private Function GetServerConnectionString() As String
            Dim connectionString As String = String.Format("data source={0};integrated security=SSPI", teServer.Text)
            If radioGroup1.SelectedIndex = 1 Then connectionString = String.Format("data source={0};user id={1};password={2}", teServer.Text, teLogin.Text, tePassword.Text)
            Return connectionString
        End Function

        Public Function GetDataBaseConnectionString() As String
            If DialogResult = DialogResult.Cancel Then Return String.Empty
            Dim connectionString As String = GetServerConnectionString()
            Return connectionString & ";initial catalog=" & cbDatabase.Text
        End Function

        Public Shared Function CalcRecordCount(ByVal serverConnectionString As String) As Integer
            Try
                Using session As Session = New Session()
                    session.AutoCreateOption = AutoCreateOption.None
                    session.ConnectionString = serverConnectionString
                    Return Convert.ToInt32(session.Evaluate(Of ServerSideGridTest)(New AggregateOperand(CType(Nothing, String), CType(Nothing, String), Aggregate.Count, CType(Nothing, CriteriaOperator)), Nothing))
                End Using
            Catch
                Return 0
            End Try
        End Function

        Private Sub AddTableNames()
            Using connection As SqlConnection = SQLConnectionHelper.GetConnection(GetServerConnectionString())
                If connection Is Nothing Then Return
                Using command As SqlCommand = New SqlCommand("select name from master..sysdatabases", connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        cbDatabase.Properties.Items.Clear()
                        While reader.Read()
                            Dim _name As String = reader.GetString(0)
                            If "master;model;tempdb;msdb;pubs".IndexOf(_name) < 0 Then cbDatabase.Properties.Items.Add(_name)
                        End While
                    End Using
                End Using
            End Using
        End Sub

        Private Sub cbDatabase_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs)
            AddTableNames()
        End Sub

        Private Sub cbDatabase_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            sbGenerateDB.Enabled = Equals(cbDatabase.Text, defaultDB)
        End Sub

        Private Sub teServer_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            cbDatabase.Text = defaultDB
            cbDatabase.Properties.Items.Clear()
        End Sub

        Private Sub sbGenerateDB_Click(ByVal sender As Object, ByVal e As EventArgs)
            GenerateRecords(True)
        End Sub

        Private Sub sbAddRecords_Click(ByVal sender As Object, ByVal e As EventArgs)
            GenerateRecords(False)
        End Sub

        Private Sub GenerateRecords(ByVal clearRecords As Boolean)
            If Not SQLConnectionHelper.IsConnectionCorrect(GetServerConnectionString()) Then Return
            Dim cur As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim store As IDataStore = XpoDefault.GetConnectionProvider(GetDataBaseConnectionString(), AutoCreateOption.DatabaseAndSchema)
                XpoDefault.DataLayer = New SimpleDataLayer(store)
                Text = ServerModeStrings.dataAdding
                Using uow As UnitOfWork = New UnitOfWork()
                    If clearRecords Then
                        Try
                            uow.ClearDatabase()
                        Catch
                        End Try
                    End If

                    Dim [step] As Integer = CInt(seRecordCount.Value / 100)
                    For i As Decimal = 0 To seRecordCount.Value - 1
                        OutlookData.CreateNewObject(uow)
                        If i Mod [step] = 0 Then
                            uow.CommitChanges()
                            progressBarControl1.Position = CInt(i * 100 / seRecordCount.Value)
                            Call Application.DoEvents()
                            Refresh()
                            Cursor.Current = Cursors.WaitCursor
                        End If
                    Next

                    uow.CommitChanges()
                End Using

                DialogResult = DialogResult.OK
                CloseForm()
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, SQLConnectionHelper.FailedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cursor.Current = cur
            End Try
        End Sub

        Private Sub sbExit_Click(ByVal sender As Object, ByVal e As EventArgs)
            DialogResult = DialogResult.No
            CloseForm()
        End Sub

        Private Sub CloseForm()
            If Not SQLConnectionHelper.IsConnectionCorrect(GetServerConnectionString()) Then Return
            Try
                Using tw As XmlTextWriter = New XmlTextWriter(serverParameters, System.Text.Encoding.UTF8)
                    tw.WriteElementString("Parameters", ConnectionStringParameters)
                End Using
            Catch
            End Try

            Close()
        End Sub
    End Class
End Namespace
