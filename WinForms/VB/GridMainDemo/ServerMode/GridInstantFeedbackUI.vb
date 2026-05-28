Imports System
Imports System.ComponentModel
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

    Public Partial Class GridInstantFeedbackUI
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
            '<gridControl1>
            ' 
            ' ~Note: the following property is set at design time and listed here only for demonstration purposes.
            ' ~Assign a data source to the grid via the DataSource property:
            ' 
            ' gridControl1.DataSource = xpAsyncServerModeSource1;
            ' 
            ' ~Sort rows by the Sent column in descending order 
            ' 
            xpAsyncServerModeSource1.DefaultSorting = "Sent desc"
            '</gridControl1>
            colOid.AllowSummaryMenu = False
            colExpression.AllowSummaryMenu = False
            colHasAttachment.AllowSummaryMenu = False
            colOid.OptionsColumn.AllowGroup = DefaultBoolean.False
            colSize.OptionsColumn.AllowGroup = DefaultBoolean.False
            InitEditors()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"GridInstantFeedbackUI"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "GridInstantFeedbackUI"
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            OnStyleChanged()
        End Sub

        Private Sub InitEditors()
            For Each mode As WaitAnimationOptions In [Enum].GetValues(GetType(WaitAnimationOptions))
                icbAnimation.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of WaitAnimationOptions).GetTitle(mode), mode, -1))
            Next

            icbAnimation.EditValue = gridView1.OptionsView.WaitAnimationOptions
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
            gridView1.OptionsView.WaitAnimationOptions = CType(icbAnimation.EditValue, WaitAnimationOptions)
        End Sub

        '</icbAnimation>
        Private Sub gridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDisplayTextEventArgs)
            If e.Column Is colExpression Then
                Dim value As Integer = 0
                If Integer.TryParse(String.Format("{0}", e.Value), value) Then e.DisplayText = String.Format("{0}:{1:00}", value \ 60, value Mod 60)
            End If
        End Sub
    End Class
End Namespace
