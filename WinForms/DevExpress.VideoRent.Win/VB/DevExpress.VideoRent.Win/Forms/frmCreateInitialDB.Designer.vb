Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmCreateInitialDB
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
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
			Me.lcMain = New DevExpress.XtraLayout.LayoutControl()
			Me.notePanel = New DevExpress.Utils.Frames.NotePanel8_1()
			Me.teDatabaseSQL = New DevExpress.XtraEditors.TextEdit()
			Me.tePassword = New DevExpress.XtraEditors.TextEdit()
			Me.teLogin = New DevExpress.XtraEditors.TextEdit()
			Me.teDatabase = New DevExpress.XtraEditors.TextEdit()
			Me.teServer = New DevExpress.XtraEditors.TextEdit()
			Me.sbCreate = New DevExpress.XtraEditors.SimpleButton()
			Me.vbwRentsHistory = New DevExpress.VideoRent.Win.VisualBackgroundWorker()
			Me.ceGenerateRentsHistory = New DevExpress.XtraEditors.CheckEdit()
			Me.vbwCreatingDb = New DevExpress.VideoRent.Win.VisualBackgroundWorker()
			Me.rgSqlConnect = New DevExpress.XtraEditors.RadioGroup()
			Me.rgType = New DevExpress.XtraEditors.RadioGroup()
			Me.lciGenerateRentsHistory = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciRentsHistory = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciType = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciCreatingDB = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.lciCreate = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.lcgAccess = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciDatabase = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.lcgSQL = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.lciServer = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciDatabaseSQL = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciSqlConnect = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciLogin = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciPassword = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
			Me.emptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.lcMain.SuspendLayout()
			CType(Me.teDatabaseSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vbwRentsHistory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceGenerateRentsHistory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vbwCreatingDb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rgSqlConnect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rgType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciGenerateRentsHistory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciRentsHistory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCreatingDB, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciCreate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgAccess, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgSQL, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciServer, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciDatabaseSQL, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciSqlConnect, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciLogin, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciPassword, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lcMain
			' 
            Me.lcMain.AllowCustomization = False
			Me.lcMain.AutoScroll = False
			Me.lcMain.Controls.Add(Me.notePanel)
			Me.lcMain.Controls.Add(Me.teDatabaseSQL)
			Me.lcMain.Controls.Add(Me.tePassword)
			Me.lcMain.Controls.Add(Me.teLogin)
			Me.lcMain.Controls.Add(Me.teDatabase)
			Me.lcMain.Controls.Add(Me.teServer)
			Me.lcMain.Controls.Add(Me.sbCreate)
			Me.lcMain.Controls.Add(Me.vbwRentsHistory)
			Me.lcMain.Controls.Add(Me.ceGenerateRentsHistory)
			Me.lcMain.Controls.Add(Me.vbwCreatingDb)
			Me.lcMain.Controls.Add(Me.rgSqlConnect)
			Me.lcMain.Controls.Add(Me.rgType)
			Me.lcMain.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lcMain.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciGenerateRentsHistory})
			Me.lcMain.Location = New System.Drawing.Point(0, 0)
			Me.lcMain.Name = "lcMain"
			Me.lcMain.Root = Me.lcgMain
			Me.lcMain.Size = New System.Drawing.Size(416, 448)
			Me.lcMain.TabIndex = 1
			Me.lcMain.Text = "layoutControl1"
			' 
			' notePanel
			' 
			Me.notePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			Me.notePanel.Location = New System.Drawing.Point(12, 12)
			Me.notePanel.MaxRows = 10
			Me.notePanel.Name = "notePanel"
			Me.notePanel.Size = New System.Drawing.Size(392, 50)
			Me.notePanel.TabIndex = 17
			Me.notePanel.TabStop = False
			' 
			' teDatabaseSQL
			' 
			Me.teDatabaseSQL.Location = New System.Drawing.Point(279, 184)
			Me.teDatabaseSQL.Name = "teDatabaseSQL"
			Me.teDatabaseSQL.Size = New System.Drawing.Size(125, 20)
			Me.teDatabaseSQL.StyleController = Me.lcMain
			Me.teDatabaseSQL.TabIndex = 16
			' 
			' tePassword
			' 
			Me.tePassword.Location = New System.Drawing.Point(279, 295)
			Me.tePassword.Name = "tePassword"
			Me.tePassword.Size = New System.Drawing.Size(125, 20)
			Me.tePassword.StyleController = Me.lcMain
			Me.tePassword.TabIndex = 15
			' 
			' teLogin
			' 
			Me.teLogin.Location = New System.Drawing.Point(279, 271)
			Me.teLogin.Name = "teLogin"
			Me.teLogin.Size = New System.Drawing.Size(125, 20)
			Me.teLogin.StyleController = Me.lcMain
			Me.teLogin.TabIndex = 14
			' 
			' teDatabase
			' 
			Me.teDatabase.Location = New System.Drawing.Point(115, 160)
			Me.teDatabase.Name = "teDatabase"
			Me.teDatabase.Size = New System.Drawing.Size(57, 20)
			Me.teDatabase.StyleController = Me.lcMain
			Me.teDatabase.TabIndex = 9
			' 
			' teServer
			' 
            Me.teServer.EditValue = ".\SQLExpress"
			Me.teServer.Enabled = False
			Me.teServer.Location = New System.Drawing.Point(279, 160)
			Me.teServer.Name = "teServer"
			Me.teServer.Size = New System.Drawing.Size(125, 20)
			Me.teServer.StyleController = Me.lcMain
			Me.teServer.TabIndex = 8
			' 
			' sbCreate
			' 
			Me.sbCreate.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.sbCreate.Appearance.Options.UseFont = True
			Me.sbCreate.Location = New System.Drawing.Point(205, 414)
			Me.sbCreate.Name = "sbCreate"
			Me.sbCreate.Size = New System.Drawing.Size(199, 22)
			Me.sbCreate.StyleController = Me.lcMain
			Me.sbCreate.TabIndex = 12
			Me.sbCreate.Text = "Create"
'			Me.sbCreate.Click += New System.EventHandler(Me.sbCreate_Click);
			' 
			' vbwRentsHistory
			' 
			Me.vbwRentsHistory.Location = New System.Drawing.Point(138, 380)
			Me.vbwRentsHistory.Name = "vbwRentsHistory"
			Me.vbwRentsHistory.Properties.ShowTitle = True
			Me.vbwRentsHistory.Size = New System.Drawing.Size(266, 20)
			Me.vbwRentsHistory.StyleController = Me.lcMain
			Me.vbwRentsHistory.TabIndex = 0
			' 
			' ceGenerateRentsHistory
			' 
			Me.ceGenerateRentsHistory.EditValue = True
			Me.ceGenerateRentsHistory.Enabled = False
			Me.ceGenerateRentsHistory.Location = New System.Drawing.Point(12, 264)
			Me.ceGenerateRentsHistory.Name = "ceGenerateRentsHistory"
			Me.ceGenerateRentsHistory.Properties.Caption = "Generate rents history"
			Me.ceGenerateRentsHistory.Size = New System.Drawing.Size(420, 18)
			Me.ceGenerateRentsHistory.StyleController = Me.lcMain
			Me.ceGenerateRentsHistory.TabIndex = 13
'			Me.ceGenerateRentsHistory.CheckedChanged += New System.EventHandler(Me.ceGenerateRentsHistory_CheckedChanged);
			' 
			' vbwCreatingDb
			' 
			Me.vbwCreatingDb.Location = New System.Drawing.Point(138, 356)
			Me.vbwCreatingDb.Name = "vbwCreatingDb"
			Me.vbwCreatingDb.Properties.ShowTitle = True
			Me.vbwCreatingDb.Size = New System.Drawing.Size(266, 20)
			Me.vbwCreatingDb.StyleController = Me.lcMain
			Me.vbwCreatingDb.TabIndex = 7
			' 
			' rgSqlConnect
			' 
			Me.rgSqlConnect.Location = New System.Drawing.Point(200, 208)
			Me.rgSqlConnect.Name = "rgSqlConnect"
			Me.rgSqlConnect.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Windows authentication"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "SQL server authentication")})
			Me.rgSqlConnect.Size = New System.Drawing.Size(204, 59)
			Me.rgSqlConnect.StyleController = Me.lcMain
			Me.rgSqlConnect.TabIndex = 6
'			Me.rgSqlConnect.EditValueChanged += New System.EventHandler(Me.rgSqlConnect_EditValueChanged);
			' 
			' rgType
			' 
			Me.rgType.Location = New System.Drawing.Point(12, 93)
			Me.rgType.Name = "rgType"
			Me.rgType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.VideoRent.DbFormat.Mdb, "Microsoft Access (.mdb)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.VideoRent.DbFormat.Sql, "SQL Server")})
			Me.rgType.Size = New System.Drawing.Size(392, 63)
			Me.rgType.StyleController = Me.lcMain
			Me.rgType.TabIndex = 5
'			Me.rgType.EditValueChanged += New System.EventHandler(Me.rgType_EditValueChanged);
			' 
			' lciGenerateRentsHistory
			' 
			Me.lciGenerateRentsHistory.Control = Me.ceGenerateRentsHistory
			Me.lciGenerateRentsHistory.CustomizationFormText = "lciGenerateRentsHistory"
			Me.lciGenerateRentsHistory.Location = New System.Drawing.Point(0, 252)
			Me.lciGenerateRentsHistory.Name = "lciGenerateRentsHistory"
			Me.lciGenerateRentsHistory.Size = New System.Drawing.Size(424, 22)
			Me.lciGenerateRentsHistory.Text = "lciGenerateRentsHistory"
			Me.lciGenerateRentsHistory.TextSize = New System.Drawing.Size(0, 0)
			Me.lciGenerateRentsHistory.TextToControlDistance = 0
			Me.lciGenerateRentsHistory.TextVisible = False
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "lcgMain"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciRentsHistory, Me.lciType, Me.lciCreatingDB, Me.emptySpaceItem1, Me.lciCreate, Me.emptySpaceItem3, Me.lcgAccess, Me.lcgSQL, Me.emptySpaceItem2, Me.layoutControlItem1, Me.emptySpaceItem7, Me.simpleSeparator1, Me.emptySpaceItem8})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Size = New System.Drawing.Size(416, 448)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "Root"
			Me.lcgMain.TextVisible = False
			' 
			' lciRentsHistory
			' 
			Me.lciRentsHistory.Control = Me.vbwRentsHistory
			Me.lciRentsHistory.CustomizationFormText = "lciRentsHistory"
			Me.lciRentsHistory.Location = New System.Drawing.Point(0, 368)
			Me.lciRentsHistory.MaxSize = New System.Drawing.Size(0, 24)
			Me.lciRentsHistory.MinSize = New System.Drawing.Size(180, 24)
			Me.lciRentsHistory.Name = "lciRentsHistory"
			Me.lciRentsHistory.Size = New System.Drawing.Size(396, 24)
			Me.lciRentsHistory.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciRentsHistory.Text = "Generating data:"
			Me.lciRentsHistory.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
			Me.lciRentsHistory.TextSize = New System.Drawing.Size(121, 13)
			Me.lciRentsHistory.TextToControlDistance = 5
			' 
			' lciType
			' 
			Me.lciType.Control = Me.rgType
			Me.lciType.CustomizationFormText = "lciType"
			Me.lciType.Location = New System.Drawing.Point(0, 65)
			Me.lciType.MaxSize = New System.Drawing.Size(0, 83)
			Me.lciType.MinSize = New System.Drawing.Size(79, 83)
			Me.lciType.Name = "lciType"
			Me.lciType.Size = New System.Drawing.Size(396, 83)
			Me.lciType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciType.Text = "Database type:"
			Me.lciType.TextLocation = DevExpress.Utils.Locations.Top
			Me.lciType.TextSize = New System.Drawing.Size(75, 13)
			' 
			' lciCreatingDB
			' 
			Me.lciCreatingDB.Control = Me.vbwCreatingDb
			Me.lciCreatingDB.CustomizationFormText = "lciCreateDB"
			Me.lciCreatingDB.Location = New System.Drawing.Point(0, 344)
			Me.lciCreatingDB.MaxSize = New System.Drawing.Size(0, 24)
			Me.lciCreatingDB.MinSize = New System.Drawing.Size(180, 24)
			Me.lciCreatingDB.Name = "lciCreatingDB"
			Me.lciCreatingDB.Size = New System.Drawing.Size(396, 24)
			Me.lciCreatingDB.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciCreatingDB.Text = "Creating database:"
			Me.lciCreatingDB.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
			Me.lciCreatingDB.TextSize = New System.Drawing.Size(121, 13)
			Me.lciCreatingDB.TextToControlDistance = 5
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 402)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(193, 26)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' lciCreate
			' 
			Me.lciCreate.Control = Me.sbCreate
			Me.lciCreate.CustomizationFormText = "lciCreate"
			Me.lciCreate.Location = New System.Drawing.Point(193, 402)
			Me.lciCreate.Name = "lciCreate"
			Me.lciCreate.Size = New System.Drawing.Size(203, 26)
			Me.lciCreate.Text = "lciCreate"
			Me.lciCreate.TextSize = New System.Drawing.Size(0, 0)
			Me.lciCreate.TextToControlDistance = 0
			Me.lciCreate.TextVisible = False
			' 
			' emptySpaceItem3
			' 
			Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
			Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 392)
			Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(0, 10)
			Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 10)
			Me.emptySpaceItem3.Name = "emptySpaceItem3"
			Me.emptySpaceItem3.Size = New System.Drawing.Size(396, 10)
			Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem3.Text = "emptySpaceItem3"
			Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
			' 
			' lcgAccess
			' 
			Me.lcgAccess.CustomizationFormText = "lcgAccess"
			Me.lcgAccess.GroupBordersVisible = False
			Me.lcgAccess.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciDatabase, Me.emptySpaceItem5})
			Me.lcgAccess.Location = New System.Drawing.Point(0, 148)
			Me.lcgAccess.Name = "lcgAccess"
			Me.lcgAccess.Size = New System.Drawing.Size(164, 159)
			Me.lcgAccess.Text = "lcgAccess"
			' 
			' lciDatabase
			' 
			Me.lciDatabase.Control = Me.teDatabase
			Me.lciDatabase.CustomizationFormText = "Database:"
			Me.lciDatabase.Location = New System.Drawing.Point(24, 0)
			Me.lciDatabase.Name = "lciDatabase"
			Me.lciDatabase.Size = New System.Drawing.Size(140, 159)
			Me.lciDatabase.Text = "Database:"
			Me.lciDatabase.TextSize = New System.Drawing.Size(75, 13)
			' 
			' emptySpaceItem5
			' 
			Me.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5"
			Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 0)
			Me.emptySpaceItem5.MaxSize = New System.Drawing.Size(24, 0)
			Me.emptySpaceItem5.MinSize = New System.Drawing.Size(24, 10)
			Me.emptySpaceItem5.Name = "emptySpaceItem5"
			Me.emptySpaceItem5.Size = New System.Drawing.Size(24, 159)
			Me.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem5.Text = "emptySpaceItem5"
			Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
			' 
			' lcgSQL
			' 
			Me.lcgSQL.CustomizationFormText = "lcgSQL"
			Me.lcgSQL.GroupBordersVisible = False
			Me.lcgSQL.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciServer, Me.lciDatabaseSQL, Me.lciSqlConnect, Me.lciLogin, Me.lciPassword, Me.emptySpaceItem6})
			Me.lcgSQL.Location = New System.Drawing.Point(164, 148)
			Me.lcgSQL.Name = "lcgSQL"
			Me.lcgSQL.Size = New System.Drawing.Size(232, 159)
			Me.lcgSQL.Text = "lcgSQL"
			' 
			' lciServer
			' 
			Me.lciServer.Control = Me.teServer
			Me.lciServer.CustomizationFormText = "SQL Server:"
			Me.lciServer.Location = New System.Drawing.Point(24, 0)
			Me.lciServer.Name = "lciServer"
			Me.lciServer.Size = New System.Drawing.Size(208, 24)
			Me.lciServer.Text = "SQL Server:"
			Me.lciServer.TextSize = New System.Drawing.Size(75, 13)
			' 
			' lciDatabaseSQL
			' 
			Me.lciDatabaseSQL.Control = Me.teDatabaseSQL
			Me.lciDatabaseSQL.CustomizationFormText = "Database:"
			Me.lciDatabaseSQL.Location = New System.Drawing.Point(24, 24)
			Me.lciDatabaseSQL.Name = "lciDatabaseSQL"
			Me.lciDatabaseSQL.Size = New System.Drawing.Size(208, 24)
			Me.lciDatabaseSQL.Text = "Database:"
			Me.lciDatabaseSQL.TextSize = New System.Drawing.Size(75, 13)
			' 
			' lciSqlConnect
			' 
			Me.lciSqlConnect.Control = Me.rgSqlConnect
			Me.lciSqlConnect.CustomizationFormText = "layoutControlItem1"
			Me.lciSqlConnect.Location = New System.Drawing.Point(24, 48)
			Me.lciSqlConnect.MaxSize = New System.Drawing.Size(0, 63)
			Me.lciSqlConnect.MinSize = New System.Drawing.Size(54, 63)
			Me.lciSqlConnect.Name = "lciSqlConnect"
			Me.lciSqlConnect.Size = New System.Drawing.Size(208, 63)
			Me.lciSqlConnect.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.lciSqlConnect.Text = "lciSqlConnect"
			Me.lciSqlConnect.TextSize = New System.Drawing.Size(0, 0)
			Me.lciSqlConnect.TextToControlDistance = 0
			Me.lciSqlConnect.TextVisible = False
			' 
			' lciLogin
			' 
			Me.lciLogin.Control = Me.teLogin
			Me.lciLogin.CustomizationFormText = "layoutControlItem2"
			Me.lciLogin.Location = New System.Drawing.Point(24, 111)
			Me.lciLogin.Name = "lciLogin"
			Me.lciLogin.Size = New System.Drawing.Size(208, 24)
			Me.lciLogin.Text = "Login:"
			Me.lciLogin.TextSize = New System.Drawing.Size(75, 13)
			' 
			' lciPassword
			' 
			Me.lciPassword.Control = Me.tePassword
			Me.lciPassword.CustomizationFormText = "layoutControlItem4"
			Me.lciPassword.Location = New System.Drawing.Point(24, 135)
			Me.lciPassword.Name = "lciPassword"
			Me.lciPassword.Size = New System.Drawing.Size(208, 24)
			Me.lciPassword.Text = "Password:"
			Me.lciPassword.TextSize = New System.Drawing.Size(75, 13)
			' 
			' emptySpaceItem6
			' 
			Me.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6"
			Me.emptySpaceItem6.Location = New System.Drawing.Point(0, 0)
			Me.emptySpaceItem6.MaxSize = New System.Drawing.Size(24, 0)
			Me.emptySpaceItem6.MinSize = New System.Drawing.Size(24, 10)
			Me.emptySpaceItem6.Name = "emptySpaceItem6"
			Me.emptySpaceItem6.Size = New System.Drawing.Size(24, 159)
			Me.emptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem6.Text = "emptySpaceItem6"
			Me.emptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
			' 
			' emptySpaceItem2
			' 
			Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
			Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 307)
			Me.emptySpaceItem2.Name = "emptySpaceItem2"
			Me.emptySpaceItem2.Size = New System.Drawing.Size(396, 19)
			Me.emptySpaceItem2.Text = "emptySpaceItem2"
			Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.notePanel
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(396, 54)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' emptySpaceItem7
			' 
			Me.emptySpaceItem7.CustomizationFormText = "emptySpaceItem7"
			Me.emptySpaceItem7.Location = New System.Drawing.Point(0, 54)
			Me.emptySpaceItem7.MaxSize = New System.Drawing.Size(0, 11)
			Me.emptySpaceItem7.MinSize = New System.Drawing.Size(10, 11)
			Me.emptySpaceItem7.Name = "emptySpaceItem7"
			Me.emptySpaceItem7.Size = New System.Drawing.Size(396, 11)
			Me.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.emptySpaceItem7.Text = "emptySpaceItem7"
			Me.emptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
			' 
			' simpleSeparator1
			' 
			Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
			Me.simpleSeparator1.Location = New System.Drawing.Point(0, 326)
			Me.simpleSeparator1.Name = "simpleSeparator1"
			Me.simpleSeparator1.Size = New System.Drawing.Size(396, 2)
			Me.simpleSeparator1.Text = "simpleSeparator1"
			' 
			' emptySpaceItem8
			' 
			Me.emptySpaceItem8.CustomizationFormText = "emptySpaceItem8"
			Me.emptySpaceItem8.Location = New System.Drawing.Point(0, 328)
			Me.emptySpaceItem8.Name = "emptySpaceItem8"
			Me.emptySpaceItem8.Size = New System.Drawing.Size(396, 16)
			Me.emptySpaceItem8.Text = "emptySpaceItem8"
			Me.emptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.teLogin
			Me.layoutControlItem3.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 219)
			Me.layoutControlItem3.Name = "layoutControlItem2"
			Me.layoutControlItem3.Size = New System.Drawing.Size(424, 24)
			Me.layoutControlItem3.Text = "layoutControlItem2"
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(93, 13)
			Me.layoutControlItem3.TextToControlDistance = 5
			' 
			' frmCreateInitialDB
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(416, 448)
			Me.Controls.Add(Me.lcMain)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.Name = "frmCreateInitialDB"
			Me.Text = "Create Database"
			CType(Me.lcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.lcMain.ResumeLayout(False)
			CType(Me.teDatabaseSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vbwRentsHistory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceGenerateRentsHistory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vbwCreatingDb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rgSqlConnect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rgType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciGenerateRentsHistory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciRentsHistory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCreatingDB, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciCreate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgAccess, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDatabase, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgSQL, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciServer, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciDatabaseSQL, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciSqlConnect, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciLogin, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciPassword, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private vbwRentsHistory As VisualBackgroundWorker
		Private lcMain As DevExpress.XtraLayout.LayoutControl
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
		Private lciRentsHistory As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents rgType As DevExpress.XtraEditors.RadioGroup
		Private lciType As DevExpress.XtraLayout.LayoutControlItem
		Private vbwCreatingDb As VisualBackgroundWorker
		Private lciCreatingDB As DevExpress.XtraLayout.LayoutControlItem
		Private teDatabase As DevExpress.XtraEditors.TextEdit
		Private teServer As DevExpress.XtraEditors.TextEdit
		Private WithEvents sbCreate As DevExpress.XtraEditors.SimpleButton
		Private lciCreate As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private WithEvents ceGenerateRentsHistory As DevExpress.XtraEditors.CheckEdit
		Private lciGenerateRentsHistory As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents rgSqlConnect As DevExpress.XtraEditors.RadioGroup
		Private tePassword As DevExpress.XtraEditors.TextEdit
		Private teLogin As DevExpress.XtraEditors.TextEdit
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private teDatabaseSQL As DevExpress.XtraEditors.TextEdit
		Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
		Private lcgAccess As DevExpress.XtraLayout.LayoutControlGroup
		Private lciDatabase As DevExpress.XtraLayout.LayoutControlItem
		Private lcgSQL As DevExpress.XtraLayout.LayoutControlGroup
		Private lciServer As DevExpress.XtraLayout.LayoutControlItem
		Private lciDatabaseSQL As DevExpress.XtraLayout.LayoutControlItem
		Private lciSqlConnect As DevExpress.XtraLayout.LayoutControlItem
		Private lciLogin As DevExpress.XtraLayout.LayoutControlItem
		Private lciPassword As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
		Private emptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
		Private notePanel As DevExpress.Utils.Frames.NotePanel8_1
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
		Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
		Private emptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
	End Class
End Namespace
