Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports System.Diagnostics
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class LookUpInstantFeedbackUI
        Inherits TutorialControl

        Private writer As LogWriter = New LogWriter()

        Public Sub New()
            If Equals(ServerModeStrings.SQLConnectionString, String.Empty) Then ShowConnectionWizard()
            Try
                Dim store As IDataStore = XpoDefault.GetConnectionProvider(ServerModeStrings.SQLConnectionString, AutoCreateOption.DatabaseAndSchema)
                store = New WaitCursorWrapper(store)
                store = New DataStoreLogger(store, writer)
                XpoDefault.DataLayer = New SimpleDataLayer(store)
            Catch
                XtraMessageBox.Show(SQLConnectionHelper.FailedConnection, SQLConnectionHelper.FailedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ServerModeStrings.SQLConnectionString = ""
            End Try

            InitializeComponent()
            '<searchLookUpEdit1>
            ' 
            ' ~Note: the following property is set at design time and listed here only for demonstration purposes.
            ' ~Assign a data source to the grid via the DataSource property:
            ' 
            ' searchLookUpEdit1.Properties.DataSource = xpAsyncServerModeSource1;
            ' 
            '</searchLookUpEdit1>
            colOid.AllowSummaryMenu = False
            colHasAttachment.AllowSummaryMenu = False
            colOid.OptionsColumn.AllowGroup = DefaultBoolean.False
            colSize.OptionsColumn.AllowGroup = DefaultBoolean.False
            InitEditors()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"LookUpInstantFeedbackUI", "SearchLookUpProperties"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "LookUpInstantFeedbackUI"
            End Get
        End Property

        Private loaded As Boolean = False

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If loaded Then Return
            loaded = True
            Dim lp As SearchLookUpProperties = New SearchLookUpProperties(searchLookUpEdit1, False)
            lp.Dock = DockStyle.Right
            lp.Parent = pnlControl
            '<dataNavigator1>
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("Id", GetType(Integer))
            For i As Integer = 1 To 100 - 1
                tbl.Rows.Add(i * 3)
            Next

            searchLookUpEdit1.DataBindings.Add(New Binding("EditValue", tbl, "ID"))
            dataNavigator1.DataSource = tbl
            '</dataNavigator1>
            CreateTimer()
        End Sub

        Protected Overrides Sub OnTick()
            If ModulesInfo.CurrentModule Is Me Then searchLookUpEdit1.ShowPopup()
        End Sub

        Private Sub InitEditors()
            For Each mode As WaitAnimationOptions In [Enum].GetValues(GetType(WaitAnimationOptions))
                icbAnimation.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of WaitAnimationOptions).GetTitle(mode), mode, -1))
            Next

            icbAnimation.EditValue = gridLookUpEdit1View.OptionsView.WaitAnimationOptions
        End Sub

        Private Sub ShowConnectionWizard()
            ShowConnectionWizard(String.Empty)
        End Sub

        Private Sub ShowConnectionWizard(ByVal demoString As String)
            Dim frm As frmSQLConnector = If(Equals(demoString, String.Empty), New frmSQLConnector(), New frmSQLConnector(demoString))
            frm.ShowDialog()
            ServerModeStrings.SQLConnectionString = frm.GetDataBaseConnectionString()
        End Sub

        Private Sub sbShowSQLConnection_Click(ByVal sender As Object, ByVal e As EventArgs)
            ShowConnectionWizard("Return")
        End Sub

        Private Sub xpAsyncServerModeSource1_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs)
            Try
                Dim session As Session = New Session()
                session.ConnectionString = ServerModeStrings.SQLConnectionString
                session.Connect()
                e.Session = session
                e.Tag = session
            Catch
                e.Session = New Session(New SimpleDataLayer(New InMemoryDataStore()))
                e.Tag = Nothing
            End Try
        End Sub

        Private Sub xpAsyncServerModeSource1_DismissSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs)
            Dim session As IDisposable = TryCast(e.Tag, IDisposable)
            If session IsNot Nothing Then session.Dispose()
        End Sub

        '<icbAnimation>
        Private Sub icbAnimation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridLookUpEdit1View.OptionsView.WaitAnimationOptions = CType(icbAnimation.EditValue, WaitAnimationOptions)
        End Sub
    '</icbAnimation>
    End Class
End Namespace
