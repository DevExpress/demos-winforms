Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid.Demos.Helpers
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class frmSQLConnector
        Inherits XtraForm

        Private oldCursor As Cursor

        Public Sub New()
            Me.New("Start Demo")
        End Sub

        Public Sub New(ByVal demoString As String)
            InitializeComponent()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", GetType(frmSQLConnector).Assembly)
            ShowInTaskbar = False
            Owner = ActiveForm
            StartPosition = FormStartPosition.CenterParent
            Me.DemoString = demoString
            sbGenerateDB.Text += Me.DemoString
            Call ServerParameters.LoadParameters()
            lblDBName.Text = ServerParameters.DBName
            teServer.Text = ServerParameters.Server
            radioGroup1.SelectedIndex = If(ServerParameters.UseWindowsAuthentication, 0, 1)
            teLogin.Text = ServerParameters.Login
            tePassword.Text = ServerParameters.Password
            AddHandler teLogin.TextChanged, Sub(s, e) ServerParameters.Login = teLogin.Text
            AddHandler tePassword.TextChanged, Sub(s, e) ServerParameters.Password = tePassword.Text
            AddHandler teServer.TextChanged, Sub(s, e) ServerParameters.Server = teServer.Text
            AddHandler radioGroup1.SelectedIndexChanged, Sub(s, e) ServerParameters.UseWindowsAuthentication = radioGroup1.SelectedIndex = 0
            AddHandler FormClosed, Sub(s, e)
                If DatabaseHelper.IsGenerating Then Call DatabaseHelper.CancelDatabaseGenerationAsync()
                Call ServerParameters.SaveParameters()
                Cursor.Current = oldCursor
            End Sub
        End Sub

        Protected Property DemoString As String

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            tePassword.Enabled = radioGroup1.SelectedIndex <> 0
            teLogin.Enabled = tePassword.Enabled
        End Sub

        Private Sub sbExit_Click(ByVal sender As Object, ByVal e As EventArgs)
            DialogResult = If(DatabaseHelper.IsGenerating, DialogResult.OK, DialogResult.No)
            Close()
        End Sub

        Private Sub sbGenerateDB_Click(ByVal sender As Object, ByVal e As EventArgs)
            GenerateRecords()
        End Sub

        Private Sub DisableControls()
            sbGenerateDB.Enabled = False
            sbTestConfiguration.Enabled = False
            radioGroup1.Enabled = False
            teLogin.Enabled = False
            tePassword.Enabled = False
            teServer.Enabled = False
            seRecordCount.Enabled = False
        End Sub

        Private Sub WriteServerParameters()
            ServerParameters.Server = teServer.Text
            ServerParameters.UseWindowsAuthentication = radioGroup1.SelectedIndex = 0
            ServerParameters.Login = teLogin.Text
            ServerParameters.Password = tePassword.Text
        End Sub

        Private Sub GenerateRecords()
            WriteServerParameters()
            oldCursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            If Not DatabaseHelper.CreateDataLayer() Then
                Cursor.Current = oldCursor
                XtraMessageBox.Show("Failed to connect to the server.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Text = "Generating records..."
            progressBarControl1.Position = 0
            progressBarControl1.Properties.Maximum = CInt(seRecordCount.Value)
            DisableControls()
            Call DatabaseHelper.GenerateDatabaseAsync(CInt(seRecordCount.Value), New UpdateProgressCallback(AddressOf UpdateProgress), New DatabaseGeneratedCallback(AddressOf OnDatabaseGenerated))
        End Sub

        Private Sub UpdateProgress(ByVal rowsGenerated As Integer)
            progressBarControl1.Position = rowsGenerated
            sbExit.Text = String.Format("{0} rows is enough. {1}", rowsGenerated, DemoString)
        End Sub

        Private Sub OnDatabaseGenerated()
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub sbTestConfiguration_Click(ByVal sender As Object, ByVal e As EventArgs)
            lbRecords.Text = String.Empty
            Dim recordsCount As Integer = DatabaseHelper.CalculateRecordCount()
            If recordsCount <> -1 Then
                lbRecords.Text = String.Format("Current record count = {0}", recordsCount)
            Else
                XtraMessageBox.Show(String.Format("Unable to connect to the database. Make sure that connection parameters are correct or use the '{0}' button to generate a sample database.", sbGenerateDB.Text), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub
    End Class
End Namespace
