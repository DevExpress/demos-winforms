Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports System.Diagnostics
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class GridServerMode
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
                '</groupControl1>
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
            ' gridControl1.DataSource = xpServerCollectionSource1;
            ' 
            ' ~Sort rows by the Sent column in descending order
            ' 
            xpServerCollectionSource1.DefaultSorting = "Sent desc"
            '</gridControl1>
            colOid.AllowSummaryMenu = False
            colHasAttachment.AllowSummaryMenu = False
            colOid.OptionsColumn.AllowGroup = DefaultBoolean.False
            colSize.OptionsColumn.AllowGroup = DefaultBoolean.False
            writer.Enabled = ceTracing.Checked
            '<groupControl1>
            writer.Console = xtraConsole1
        '</groupControl1>
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"GridServerMode"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "GridServerMode"
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            OnStyleChanged()
        End Sub

        Private Sub ShowConnectionWizard()
            ShowConnectionWizard(String.Empty)
        End Sub

        Private Sub ShowConnectionWizard(ByVal demoString As String)
            Dim frm As frmSQLConnector = If(Equals(demoString, String.Empty), New frmSQLConnector(), New frmSQLConnector(demoString))
            frm.ShowDialog()
            ServerModeStrings.SQLConnectionString = frm.GetDataBaseConnectionString()
        End Sub

        Private Sub ceTracing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            writer.Enabled = ceTracing.Checked
        End Sub

        Private Sub sbClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            xtraConsole1.ClearText()
        End Sub

        Private Sub sbShowSQLConnection_Click(ByVal sender As Object, ByVal e As EventArgs)
            ShowConnectionWizard("Return")
            xpServerCollectionSource1.Reload()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            '<simpleButton1>
            unitOfWork1.CommitChanges()
            xpServerCollectionSource1.Reload()
        '</simpleButton1>
        End Sub
    End Class
End Namespace
