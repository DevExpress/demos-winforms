Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos

    Partial Class frmSQLConnector

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.frmSQLConnector))
            Me.npMain = New DevExpress.DXperience.Demos.DescriptionLabel()
            Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sbExit = New DevExpress.XtraEditors.SimpleButton()
            Me.sbAddRecords = New DevExpress.XtraEditors.SimpleButton()
            Me.lbRecords = New DevExpress.XtraEditors.LabelControl()
            Me.seRecordCount = New DevExpress.XtraEditors.SpinEdit()
            Me.sbGenerateDB = New DevExpress.XtraEditors.SimpleButton()
            Me.teServer = New DevExpress.XtraEditors.TextEdit()
            Me.cbDatabase = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.tePassword = New DevExpress.XtraEditors.TextEdit()
            Me.teLogin = New DevExpress.XtraEditors.TextEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.pnlMain = New DevExpress.XtraEditors.PanelControl()
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.seRecordCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teServer.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbDatabase.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tePassword.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teLogin.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pnlMain), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlMain.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' npMain
            ' 
            resources.ApplyResources(Me.npMain, "npMain")
            Me.npMain.Name = "npMain"
            ' 
            ' progressBarControl1
            ' 
            resources.ApplyResources(Me.progressBarControl1, "progressBarControl1")
            Me.progressBarControl1.Name = "progressBarControl1"
            Me.progressBarControl1.Properties.Maximum = 99
            Me.progressBarControl1.StyleController = Me.layoutControl1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.progressBarControl1)
            Me.layoutControl1.Controls.Add(Me.sbExit)
            Me.layoutControl1.Controls.Add(Me.sbAddRecords)
            Me.layoutControl1.Controls.Add(Me.lbRecords)
            Me.layoutControl1.Controls.Add(Me.seRecordCount)
            Me.layoutControl1.Controls.Add(Me.sbGenerateDB)
            Me.layoutControl1.Controls.Add(Me.teServer)
            Me.layoutControl1.Controls.Add(Me.cbDatabase)
            Me.layoutControl1.Controls.Add(Me.radioGroup1)
            Me.layoutControl1.Controls.Add(Me.tePassword)
            Me.layoutControl1.Controls.Add(Me.teLogin)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            ' 
            ' sbExit
            ' 
            resources.ApplyResources(Me.sbExit, "sbExit")
            Me.sbExit.Name = "sbExit"
            Me.sbExit.StyleController = Me.layoutControl1
            AddHandler Me.sbExit.Click, New System.EventHandler(AddressOf Me.sbExit_Click)
            ' 
            ' sbAddRecords
            ' 
            resources.ApplyResources(Me.sbAddRecords, "sbAddRecords")
            Me.sbAddRecords.Name = "sbAddRecords"
            Me.sbAddRecords.StyleController = Me.layoutControl1
            AddHandler Me.sbAddRecords.Click, New System.EventHandler(AddressOf Me.sbAddRecords_Click)
            ' 
            ' lbRecords
            ' 
            Me.lbRecords.Appearance.Font = CType((resources.GetObject("lbRecords.Appearance.Font")), System.Drawing.Font)
            Me.lbRecords.Appearance.ForeColor = System.Drawing.Color.Red
            Me.lbRecords.Appearance.Options.UseFont = True
            Me.lbRecords.Appearance.Options.UseForeColor = True
            Me.lbRecords.Appearance.Options.UseTextOptions = True
            Me.lbRecords.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            resources.ApplyResources(Me.lbRecords, "lbRecords")
            Me.lbRecords.Name = "lbRecords"
            Me.lbRecords.StyleController = Me.layoutControl1
            ' 
            ' seRecordCount
            ' 
            resources.ApplyResources(Me.seRecordCount, "seRecordCount")
            Me.seRecordCount.Name = "seRecordCount"
            Me.seRecordCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seRecordCount.Properties.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seRecordCount.Properties.IsFloatValue = False
            Me.seRecordCount.Properties.Mask.EditMask = resources.GetString("seRecordCount.Properties.Mask.EditMask")
            Me.seRecordCount.Properties.Mask.UseMaskAsDisplayFormat =(CBool((resources.GetObject("seRecordCount.Properties.Mask.UseMaskAsDisplayFormat"))))
            Me.seRecordCount.Properties.MaxValue = New Decimal(New Integer() {999999, 0, 0, 0})
            Me.seRecordCount.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seRecordCount.StyleController = Me.layoutControl1
            ' 
            ' sbGenerateDB
            ' 
            resources.ApplyResources(Me.sbGenerateDB, "sbGenerateDB")
            Me.sbGenerateDB.Name = "sbGenerateDB"
            Me.sbGenerateDB.StyleController = Me.layoutControl1
            AddHandler Me.sbGenerateDB.Click, New System.EventHandler(AddressOf Me.sbGenerateDB_Click)
            ' 
            ' teServer
            ' 
            resources.ApplyResources(Me.teServer, "teServer")
            Me.teServer.Name = "teServer"
            Me.teServer.StyleController = Me.layoutControl1
            AddHandler Me.teServer.EditValueChanged, New System.EventHandler(AddressOf Me.teServer_EditValueChanged)
            ' 
            ' cbDatabase
            ' 
            resources.ApplyResources(Me.cbDatabase, "cbDatabase")
            Me.cbDatabase.Name = "cbDatabase"
            Me.cbDatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("cbDatabase.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.cbDatabase.Properties.[ReadOnly] = True
            Me.cbDatabase.StyleController = Me.layoutControl1
            AddHandler Me.cbDatabase.QueryPopUp, New System.ComponentModel.CancelEventHandler(AddressOf Me.cbDatabase_QueryPopUp)
            AddHandler Me.cbDatabase.EditValueChanged, New System.EventHandler(AddressOf Me.cbDatabase_EditValueChanged)
            ' 
            ' radioGroup1
            ' 
            resources.ApplyResources(Me.radioGroup1, "radioGroup1")
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Columns = 1
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem((CObj((resources.GetObject("radioGroup1.Properties.Items")))), resources.GetString("radioGroup1.Properties.Items1")), New DevExpress.XtraEditors.Controls.RadioGroupItem((CObj((resources.GetObject("radioGroup1.Properties.Items2")))), resources.GetString("radioGroup1.Properties.Items3"))})
            Me.radioGroup1.StyleController = Me.layoutControl1
            AddHandler Me.radioGroup1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroup1_SelectedIndexChanged)
            ' 
            ' tePassword
            ' 
            resources.ApplyResources(Me.tePassword, "tePassword")
            Me.tePassword.Name = "tePassword"
            Me.tePassword.Properties.PasswordChar = "*"c
            Me.tePassword.StyleController = Me.layoutControl1
            ' 
            ' teLogin
            ' 
            resources.ApplyResources(Me.teLogin, "teLogin")
            Me.teLogin.Name = "teLogin"
            Me.teLogin.StyleController = Me.layoutControl1
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9, Me.emptySpaceItem2, Me.layoutControlItem10, Me.emptySpaceItem4, Me.layoutControlItem11, Me.emptySpaceItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(495, 404)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.teServer
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(228, 24)
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(72, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbDatabase
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(228, 24)
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(72, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.radioGroup1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(228, 88)
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(72, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.teLogin
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 136)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(228, 24)
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(72, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.tePassword
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 160)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(228, 24)
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(72, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.lbRecords
            Me.layoutControlItem6.Location = New System.Drawing.Point(238, 0)
            Me.layoutControlItem6.MinSize = New System.Drawing.Size(23, 25)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 8)
            Me.layoutControlItem6.Size = New System.Drawing.Size(237, 48)
            Me.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.seRecordCount
            Me.layoutControlItem7.Location = New System.Drawing.Point(238, 48)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(237, 40)
            resources.ApplyResources(Me.layoutControlItem7, "layoutControlItem7")
            Me.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(72, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.sbGenerateDB
            Me.layoutControlItem8.Location = New System.Drawing.Point(238, 88)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(237, 26)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.sbAddRecords
            Me.layoutControlItem9.Location = New System.Drawing.Point(238, 114)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(237, 26)
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(238, 140)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(237, 20)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.sbExit
            Me.layoutControlItem10.Location = New System.Drawing.Point(238, 160)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(237, 24)
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.AllowHotTrack = False
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 184)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(475, 186)
            Me.emptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.progressBarControl1
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 370)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(475, 14)
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(228, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(10, 184)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' pnlMain
            ' 
            Me.pnlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlMain.Controls.Add(Me.layoutControl1)
            resources.ApplyResources(Me.pnlMain, "pnlMain")
            Me.pnlMain.Name = "pnlMain"
            ' 
            ' frmSQLConnector
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.npMain)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "frmSQLConnector"
            Me.ShowInTaskbar = False
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.seRecordCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teServer.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbDatabase.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tePassword.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teLogin.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pnlMain), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlMain.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private npMain As DevExpress.DXperience.Demos.DescriptionLabel

        Private pnlMain As DevExpress.XtraEditors.PanelControl

        Private sbGenerateDB As DevExpress.XtraEditors.SimpleButton

        Private tePassword As DevExpress.XtraEditors.TextEdit

        Private teLogin As DevExpress.XtraEditors.TextEdit

        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup

        Private teServer As DevExpress.XtraEditors.TextEdit

        Private cbDatabase As DevExpress.XtraEditors.ComboBoxEdit

        Private seRecordCount As DevExpress.XtraEditors.SpinEdit

        Private sbExit As DevExpress.XtraEditors.SimpleButton

        Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl

        Private sbAddRecords As DevExpress.XtraEditors.SimpleButton

        Private lbRecords As DevExpress.XtraEditors.LabelControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
