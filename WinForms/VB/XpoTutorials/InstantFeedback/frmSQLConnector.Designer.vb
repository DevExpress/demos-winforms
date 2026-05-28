Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos
	Partial Public Class frmSQLConnector
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.npMain = New DevExpress.Utils.Frames.NotePanel()
			Me.pnlButtons = New DevExpress.XtraEditors.PanelControl()
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			Me.sbGenerateDB = New DevExpress.XtraEditors.SimpleButton()
			Me.pnlMain = New DevExpress.XtraEditors.PanelControl()
			Me.lbRecords = New DevExpress.XtraEditors.LabelControl()
			Me.sbAddRecords = New DevExpress.XtraEditors.SimpleButton()
			Me.sbExit = New DevExpress.XtraEditors.SimpleButton()
			Me.seRecordCount = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
			Me.tePassword = New DevExpress.XtraEditors.TextEdit()
			Me.teLogin = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.teServer = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.cbDatabase = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.pnlButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlButtons.SuspendLayout()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlMain.SuspendLayout()
			CType(Me.seRecordCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' npMain
			' 
			Me.npMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			Me.npMain.Dock = System.Windows.Forms.DockStyle.Top
			Me.npMain.ForeColor = System.Drawing.Color.Black
			Me.npMain.Location = New System.Drawing.Point(8, 8)
			Me.npMain.MaxRows = 20
			Me.npMain.Name = "npMain"
			Me.npMain.Size = New System.Drawing.Size(491, 24)
			Me.npMain.TabIndex = 0
			Me.npMain.TabStop = False
			' 
			' pnlButtons
			' 
			Me.pnlButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlButtons.Controls.Add(Me.progressBarControl1)
			Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.pnlButtons.Location = New System.Drawing.Point(8, 378)
			Me.pnlButtons.Name = "pnlButtons"
			Me.pnlButtons.Size = New System.Drawing.Size(491, 10)
			Me.pnlButtons.TabIndex = 1
			' 
			' progressBarControl1
			' 
			Me.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.progressBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Properties.Maximum = 99
			Me.progressBarControl1.Size = New System.Drawing.Size(491, 10)
			Me.progressBarControl1.TabIndex = 0
			' 
			' sbGenerateDB
			' 
			Me.sbGenerateDB.Location = New System.Drawing.Point(291, 106)
			Me.sbGenerateDB.Name = "sbGenerateDB"
			Me.sbGenerateDB.Size = New System.Drawing.Size(188, 25)
			Me.sbGenerateDB.TabIndex = 10
			Me.sbGenerateDB.Text = "Generate Table and "
'			Me.sbGenerateDB.Click += New System.EventHandler(Me.sbGenerateDB_Click);
			' 
			' pnlMain
			' 
			Me.pnlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlMain.Controls.Add(Me.lbRecords)
			Me.pnlMain.Controls.Add(Me.sbAddRecords)
			Me.pnlMain.Controls.Add(Me.sbExit)
			Me.pnlMain.Controls.Add(Me.seRecordCount)
			Me.pnlMain.Controls.Add(Me.labelControl6)
			Me.pnlMain.Controls.Add(Me.sbGenerateDB)
			Me.pnlMain.Controls.Add(Me.tePassword)
			Me.pnlMain.Controls.Add(Me.teLogin)
			Me.pnlMain.Controls.Add(Me.labelControl5)
			Me.pnlMain.Controls.Add(Me.labelControl4)
			Me.pnlMain.Controls.Add(Me.radioGroup1)
			Me.pnlMain.Controls.Add(Me.labelControl3)
			Me.pnlMain.Controls.Add(Me.teServer)
			Me.pnlMain.Controls.Add(Me.labelControl2)
			Me.pnlMain.Controls.Add(Me.cbDatabase)
			Me.pnlMain.Controls.Add(Me.labelControl1)
			Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New System.Drawing.Point(8, 32)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New System.Drawing.Size(491, 346)
			Me.pnlMain.TabIndex = 2
			' 
			' lbRecords
			' 
			Me.lbRecords.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lbRecords.Appearance.ForeColor = System.Drawing.Color.Red
			Me.lbRecords.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbRecords.Location = New System.Drawing.Point(291, 17)
			Me.lbRecords.Name = "lbRecords"
			Me.lbRecords.Size = New System.Drawing.Size(188, 43)
			Me.lbRecords.TabIndex = 23
			' 
			' sbAddRecords
			' 
			Me.sbAddRecords.Enabled = False
			Me.sbAddRecords.Location = New System.Drawing.Point(291, 134)
			Me.sbAddRecords.Name = "sbAddRecords"
			Me.sbAddRecords.Size = New System.Drawing.Size(188, 25)
			Me.sbAddRecords.TabIndex = 11
			Me.sbAddRecords.Text = "Add Records and "
'			Me.sbAddRecords.Click += New System.EventHandler(Me.sbAddRecords_Click);
			' 
			' sbExit
			' 
			Me.sbExit.Enabled = False
			Me.sbExit.Location = New System.Drawing.Point(291, 162)
			Me.sbExit.Name = "sbExit"
			Me.sbExit.Size = New System.Drawing.Size(188, 25)
			Me.sbExit.TabIndex = 12
'			Me.sbExit.Click += New System.EventHandler(Me.sbExit_Click);
			' 
			' seRecordCount
			' 
			Me.seRecordCount.EditValue = New Decimal(New Integer() { 100000, 0, 0, 0})
			Me.seRecordCount.Location = New System.Drawing.Point(365, 80)
			Me.seRecordCount.Name = "seRecordCount"
			Me.seRecordCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seRecordCount.Properties.Increment = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.seRecordCount.Properties.IsFloatValue = False
			Me.seRecordCount.Properties.Mask.EditMask = "n0"
			Me.seRecordCount.Properties.Mask.UseMaskAsDisplayFormat = True
			Me.seRecordCount.Properties.MaxValue = New Decimal(New Integer() { 999999, 0, 0, 0})
			Me.seRecordCount.Properties.MinValue = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.seRecordCount.Size = New System.Drawing.Size(114, 20)
			Me.seRecordCount.TabIndex = 5
			' 
			' labelControl6
			' 
			Me.labelControl6.Location = New System.Drawing.Point(291, 83)
			Me.labelControl6.Name = "labelControl6"
			Me.labelControl6.Size = New System.Drawing.Size(68, 13)
			Me.labelControl6.TabIndex = 22
			Me.labelControl6.Text = "Record count:"
			' 
			' tePassword
			' 
			Me.tePassword.Enabled = False
			Me.tePassword.Location = New System.Drawing.Point(85, 163)
			Me.tePassword.Name = "tePassword"
			Me.tePassword.Properties.PasswordChar = "*"c
			Me.tePassword.Size = New System.Drawing.Size(168, 20)
			Me.tePassword.TabIndex = 4
			' 
			' teLogin
			' 
			Me.teLogin.EditValue = "sa"
			Me.teLogin.Enabled = False
			Me.teLogin.Location = New System.Drawing.Point(85, 139)
			Me.teLogin.Name = "teLogin"
			Me.teLogin.Size = New System.Drawing.Size(168, 20)
			Me.teLogin.TabIndex = 3
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(21, 166)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(50, 13)
			Me.labelControl5.TabIndex = 21
			Me.labelControl5.Text = "Password:"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(21, 142)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(58, 13)
			Me.labelControl4.TabIndex = 20
			Me.labelControl4.Text = "Login name:"
			' 
			' radioGroup1
			' 
			Me.radioGroup1.EditValue = 0
			Me.radioGroup1.Location = New System.Drawing.Point(21, 83)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Columns = 1
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Windows authentication"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "SQL Server authentication")})
			Me.radioGroup1.Size = New System.Drawing.Size(232, 48)
			Me.radioGroup1.TabIndex = 2
'			Me.radioGroup1.SelectedIndexChanged += New System.EventHandler(Me.radioGroup1_SelectedIndexChanged);
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(21, 67)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(72, 13)
			Me.labelControl3.TabIndex = 18
			Me.labelControl3.Text = "Connect using:"
			' 
			' teServer
			' 
			Me.teServer.EditValue = "(local)"
			Me.teServer.Location = New System.Drawing.Point(85, 14)
			Me.teServer.Name = "teServer"
			Me.teServer.Size = New System.Drawing.Size(168, 20)
			Me.teServer.TabIndex = 0
'			Me.teServer.EditValueChanged += New System.EventHandler(Me.teServer_EditValueChanged);
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(21, 17)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(58, 13)
			Me.labelControl2.TabIndex = 16
			Me.labelControl2.Text = "SQL Server:"
			' 
			' cbDatabase
			' 
			Me.cbDatabase.Location = New System.Drawing.Point(85, 40)
			Me.cbDatabase.Name = "cbDatabase"
			Me.cbDatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbDatabase.Properties.ReadOnly = True
			Me.cbDatabase.Size = New System.Drawing.Size(168, 20)
			Me.cbDatabase.TabIndex = 1
'			Me.cbDatabase.EditValueChanged += New System.EventHandler(Me.cbDatabase_EditValueChanged);
'			Me.cbDatabase.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.cbDatabase_QueryPopUp);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(21, 43)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(50, 13)
			Me.labelControl1.TabIndex = 14
			Me.labelControl1.Text = "Database:"
			' 
			' frmSQLConnector
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(507, 396)
			Me.Controls.Add(Me.pnlMain)
			Me.Controls.Add(Me.pnlButtons)
			Me.Controls.Add(Me.npMain)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "frmSQLConnector"
			Me.Padding = New System.Windows.Forms.Padding(8)
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Data Source Configuration"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.frmSQLConnector_FormClosing);
			CType(Me.pnlButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlButtons.ResumeLayout(False)
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlMain.ResumeLayout(False)
			Me.pnlMain.PerformLayout()
			CType(Me.seRecordCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private npMain As DevExpress.Utils.Frames.NotePanel
		Private pnlButtons As DevExpress.XtraEditors.PanelControl
		Private pnlMain As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbGenerateDB As DevExpress.XtraEditors.SimpleButton
		Private tePassword As DevExpress.XtraEditors.TextEdit
		Private teLogin As DevExpress.XtraEditors.TextEdit
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents teServer As DevExpress.XtraEditors.TextEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbDatabase As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private seRecordCount As DevExpress.XtraEditors.SpinEdit
		Private labelControl6 As DevExpress.XtraEditors.LabelControl
		Private WithEvents sbExit As DevExpress.XtraEditors.SimpleButton
		Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
		Private WithEvents sbAddRecords As DevExpress.XtraEditors.SimpleButton
		Private lbRecords As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
