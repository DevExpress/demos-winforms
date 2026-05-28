Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.Reflection
Imports System.IO
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraLayout
Imports DevExpress.VideoRent.Helpers

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmCreateInitialDB
		Inherits XtraForm
		Private dbConnectData As DbConnectData
		Private mdbDatabaseBinding As Binding
		Private sqlDatabaseBinding As Binding
		Private sizer As FormAnimationSizer
		Public Sub New(ByVal dbConnectData As DbConnectData)
			InitializeComponent()
			Me.dbConnectData = dbConnectData
			teServer.DataBindings.Add("Text", dbConnectData, "Server")
			teLogin.DataBindings.Add("Text", dbConnectData, "Login")
			tePassword.DataBindings.Add("Text", dbConnectData, "Password")
			mdbDatabaseBinding = New Binding("Text", dbConnectData, "MdbPath")
			sqlDatabaseBinding = New Binding("Text", dbConnectData, "SqlDbName")
			ceGenerateRentsHistory.DataBindings.Add("Checked", dbConnectData, "GenerateRentsHistory")
			sizer = New FormAnimationSizer(Me)
			rgType.EditValue = dbConnectData.DbFormat
			rgSqlConnect.EditValue = dbConnectData.UseWinAuth
			teDatabase.DataBindings.Add(mdbDatabaseBinding)
			teDatabaseSQL.DataBindings.Add(sqlDatabaseBinding)
			Me.Icon = ElementHelper.AppIcon
			notePanel.Text = ConstStrings.DatabaseCreating
		End Sub
		Public Event Start As EventHandler
		Private Sub rgType_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgType.EditValueChanged
			dbConnectData.DbFormat = CType(rgType.EditValue, DbFormat)
			lcMain.BeginUpdate()
			Try
				If dbConnectData.DbFormat = DbFormat.Mdb Then
					DisbleSqlConnect()
				Else
					EnableSqlConnect()
				End If
			Finally
				lcMain.EndUpdate()
				sizer.SetMinHeight(lcMain.Root.MinSize.Height)
			End Try
		End Sub
		Private Sub EnableSqlConnect()
			lcgSQL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
			lcgAccess.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			teServer.Enabled = True
			rgSqlConnect.Enabled = True
			teDatabaseSQL.Enabled = True
			teDatabase.Enabled = False
			UpdateLoginPassword()
		End Sub
		Private Sub DisbleSqlConnect()
			lcgAccess.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
			lcgSQL.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			teServer.Enabled = False
			rgSqlConnect.Enabled = False
			teLogin.Enabled = False
			tePassword.Enabled = False
			teDatabaseSQL.Enabled = False
			teDatabase.Enabled = True
		End Sub
		Private Sub rgSqlConnect_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgSqlConnect.EditValueChanged
			dbConnectData.UseWinAuth = CBool(rgSqlConnect.EditValue)
			UpdateLoginPassword()
		End Sub
		Private Sub UpdateLoginPassword()
			If dbConnectData.UseWinAuth Then
				teLogin.Enabled = False
				tePassword.Enabled = False
			Else
				teLogin.Enabled = True
				tePassword.Enabled = True
			End If
		End Sub
		Private Sub ceGenerateRentsHistory_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceGenerateRentsHistory.CheckedChanged
			vbwRentsHistory.Enabled = ceGenerateRentsHistory.Checked
		End Sub
		Private Sub sbCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbCreate.Click
            RaiseEvent Start(Me, EventArgs.Empty)
        End Sub
		Public Sub BeginWork()
			Me.Cursor = Cursors.WaitCursor
			sbCreate.Enabled = False
			lcMain.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True
			lcMain.Refresh()
		End Sub
		Public Sub EndWork(ByVal complete As Boolean)
			lcMain.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.False
			sbCreate.Enabled = True
			If (Not complete) Then
				vbwCreatingDb.Position = vbwCreatingDb.Properties.Minimum
				vbwRentsHistory.Position = vbwRentsHistory.Properties.Minimum
			End If
			Me.Cursor = Cursors.Arrow
		End Sub
		Public ReadOnly Property CreateDbWorker() As IBackgroundWorker
			Get
				Return vbwCreatingDb
			End Get
		End Property
		Public ReadOnly Property GenerateRentsHistoryWorker() As IBackgroundWorker
			Get
				Return vbwRentsHistory
			End Get
		End Property
	End Class
    Public Class CreateInitialDbDialog
        Implements ICreateInitialDbDialog
        Private form As frmCreateInitialDB
        Public Sub Show(ByVal dbConnectData As DbConnectData) Implements ICreateInitialDbDialog.Show
            form = New frmCreateInitialDB(dbConnectData)
        End Sub
        Public Sub ShowDialog() Implements ICreateInitialDbDialog.ShowDialog
            form.ShowDialog()
        End Sub
        Public Sub Close() Implements ICreateInitialDbDialog.Close
            form.Close()
            form.Dispose()
        End Sub
        Public ReadOnly Property CreateDbWorker() As IBackgroundWorker Implements ICreateInitialDbDialog.CreateDbWorker
            Get
                Return form.CreateDbWorker
            End Get
        End Property
        Public ReadOnly Property GenerateRentsHistoryWorker() As IBackgroundWorker Implements ICreateInitialDbDialog.GenerateRentsHistoryWorker
            Get
                Return form.GenerateRentsHistoryWorker
            End Get
        End Property
        Public Custom Event Start As EventHandler Implements ICreateInitialDbDialog.Start
            AddHandler(ByVal value As EventHandler)
                AddHandler form.Start, value
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                RemoveHandler form.Start, value
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event
        Public Sub BeginWork() Implements ICreateInitialDbDialog.BeginWork
            form.BeginWork()
        End Sub
        Public Sub EndWork(ByVal complete As Boolean) Implements ICreateInitialDbDialog.EndWork
            form.EndWork(complete)
        End Sub
        Public Sub ShowUnableToOpenMessage(ByVal createNew As Boolean) Implements ICreateInitialDbDialog.ShowUnableToOpenMessage
            If createNew Then
                XtraMessageBox.Show(ConstStrings.UnableCreateDb, ConstStrings.[Error], MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Else
                XtraMessageBox.Show(ConstStrings.UnableOpenDb, ConstStrings.[Error], MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        End Sub
    End Class
End Namespace
