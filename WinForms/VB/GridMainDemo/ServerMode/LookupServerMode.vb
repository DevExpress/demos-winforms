Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class LookUpServerMode
        Inherits TutorialControl

        '<groupControl1>
        Private writer As LogWriter = New LogWriter()

        '</groupControl1>
        Public Sub New()
            If Equals(ServerModeStrings.SQLConnectionString, String.Empty) Then ShowConnectionWizard()
            Try
                '<groupControl1>
                Dim store As IDataStore = XpoDefault.GetConnectionProvider(ServerModeStrings.SQLConnectionString, AutoCreateOption.DatabaseAndSchema)
                '<skip>
                store = New WaitCursorWrapper(store)
                '</skip>
                store = New DataStoreLogger(store, writer)
                XpoDefault.DataLayer = New SimpleDataLayer(store)
                '</groupControl1>
                CreateMainData()
            Catch
                XtraMessageBox.Show(SQLConnectionHelper.FailedConnection, SQLConnectionHelper.FailedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ServerModeStrings.SQLConnectionString = ""
            End Try

            InitializeComponent()
            colOid.AllowSummaryMenu = False
            colHasAttachment.AllowSummaryMenu = False
            colOid.OptionsColumn.AllowGroup = DefaultBoolean.False
            colSize.OptionsColumn.AllowGroup = DefaultBoolean.False
            writer.Enabled = ceTracing.Checked
            '<groupControl1>
            writer.Console = xtraConsole1
            '</groupControl1>
            repositoryItemComboBox1.Items.AddRange(OutlookData.users)
        End Sub

        Private Sub DemoCode()
            '<gridControl1>
            ' Note: the following properties are set at design time and listed here only for demonstration purposes.
            ' Assign a data source to the in-place GridLookUpEdit's DataSource property:
            repositoryItemGridLookUpEdit1.DataSource = xpServerCollectionSource1
            ' Specify the field whose values are displayed in the edit box:
            repositoryItemGridLookUpEdit1.DisplayMember = "Subject"
        '</gridControl1>
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"LookupServerMode"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "LookupServerMode"
            End Get
        End Property

        Private Sub CreateMainData()
            Using uow As UnitOfWork = New UnitOfWork()
                If uow.FindObject(Of ServerSideLookUpTest)(Nothing) Is Nothing Then
                    Dim rnd = Data.Utils.NonCryptographicRandom.Default
                    Dim issues As XPCollection(Of ServerSideGridTest) = New XPCollection(Of ServerSideGridTest)(uow)
                    issues.TopReturnedObjects = 1999
                    While issues.Count < 1000
                        issues.Add(OutlookData.CreateNewObject(uow))
                    End While

                    For i As Integer = 0 To 7 - 1
                        Dim percent As Integer = 0
                        If i = 2 Then percent = 50
                        If i = 5 Then percent = 100
                        Dim obj As ServerSideLookUpTest = New ServerSideLookUpTest(uow)
                        obj.AssignTo = OutlookData.GetFrom()
                        obj.DueDate = OutlookData.GetDueDate()
                        obj.Issue = issues(rnd.Next(issues.Count))
                        obj.PercentComplete = percent
                    Next
                End If

                uow.CommitChanges()
            End Using
        End Sub

        Private Sub ShowConnectionWizard()
            Dim frm As frmSQLConnector = New frmSQLConnector()
            frm.ShowDialog()
            ServerModeStrings.SQLConnectionString = frm.GetDataBaseConnectionString()
        End Sub

        Private Sub ceTracing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            writer.Enabled = ceTracing.Checked
        End Sub

        Private Sub sbClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            xtraConsole1.ClearText()
        End Sub

        Private Sub gridView1_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As Views.Grid.CustomRowCellEditEventArgs)
            If e.Column Is colPercentComplete Then e.RepositoryItem = repositoryItemSpinEdit1
        End Sub

        Private criteriaParseScope As IDisposable

        Protected Overrides Sub DoShow()
            criteriaParseScope = session1.CreateParseCriteriaSessionScope()
            MyBase.DoShow()
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            DisposeHelper.Dispose(criteriaParseScope)
        End Sub
    End Class
End Namespace
