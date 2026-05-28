Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class OLAP

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
            Me.components = New System.ComponentModel.Container()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.sbConnect = New DevExpress.XtraEditors.SimpleButton()
            Me.beServer = New DevExpress.XtraEditors.ButtonEdit()
            Me.cbeDatabase = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbeCube = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciServer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciDataBase = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciCube = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.panelError = New DevExpress.XtraEditors.PanelControl()
            Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.beServer.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbeDatabase.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbeCube.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciServer), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciDataBase), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciCube), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainPanel.SuspendLayout()
            CType((Me.panelError), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelError.SuspendLayout()
            CType((Me.hyperLinkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.radioGroup1)
            Me.layoutControl1.Controls.Add(Me.sbConnect)
            Me.layoutControl1.Controls.Add(Me.beServer)
            Me.layoutControl1.Controls.Add(Me.cbeDatabase)
            Me.layoutControl1.Controls.Add(Me.cbeCube)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1086, 439, 650, 397)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 441)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.AutoSizeInLayoutControl = True
            Me.radioGroup1.Location = New System.Drawing.Point(11, 11)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroup1.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroup1.Properties.Columns = 1
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Demo Data"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Analysis Server")})
            Me.radioGroup1.Size = New System.Drawing.Size(177, 56)
            Me.radioGroup1.StyleController = Me.layoutControl1
            Me.radioGroup1.TabIndex = 0
            AddHandler Me.radioGroup1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroup1_SelectedIndexChanged)
            ' 
            ' sbConnect
            ' 
            Me.sbConnect.Location = New System.Drawing.Point(11, 191)
            Me.sbConnect.Name = "sbConnect"
            Me.sbConnect.Size = New System.Drawing.Size(177, 22)
            Me.sbConnect.StyleController = Me.layoutControl1
            Me.sbConnect.TabIndex = 8
            Me.sbConnect.Text = "Connect"
            Me.sbConnect.Visible = False
            AddHandler Me.sbConnect.Click, New System.EventHandler(AddressOf Me.sbConnect_Click)
            ' 
            ' beServer
            ' 
            Me.beServer.Location = New System.Drawing.Point(11, 87)
            Me.beServer.Name = "beServer"
            Me.beServer.Size = New System.Drawing.Size(177, 20)
            Me.beServer.StyleController = Me.layoutControl1
            Me.beServer.TabIndex = 5
            ' 
            ' cbeDatabase
            ' 
            Me.cbeDatabase.Location = New System.Drawing.Point(11, 127)
            Me.cbeDatabase.Name = "cbeDatabase"
            Me.cbeDatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeDatabase.Size = New System.Drawing.Size(177, 20)
            Me.cbeDatabase.StyleController = Me.layoutControl1
            Me.cbeDatabase.TabIndex = 6
            AddHandler Me.cbeDatabase.QueryPopUp, New System.ComponentModel.CancelEventHandler(AddressOf Me.cbeDatabase_QueryPopUp)
            ' 
            ' cbeCube
            ' 
            Me.cbeCube.Location = New System.Drawing.Point(11, 167)
            Me.cbeCube.Name = "cbeCube"
            Me.cbeCube.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeCube.Size = New System.Drawing.Size(177, 20)
            Me.cbeCube.StyleController = Me.layoutControl1
            Me.cbeCube.TabIndex = 7
            AddHandler Me.cbeCube.QueryPopUp, New System.ComponentModel.CancelEventHandler(AddressOf Me.cbeCube_QueryPopUp)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 441)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 206)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(181, 217)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.lciServer, Me.lciDataBase, Me.lciCube, Me.layoutControlItem6})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(181, 206)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.radioGroup1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(181, 60)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' lciServer
            ' 
            Me.lciServer.Control = Me.beServer
            Me.lciServer.Location = New System.Drawing.Point(0, 60)
            Me.lciServer.Name = "lceServer"
            Me.lciServer.Size = New System.Drawing.Size(181, 40)
            Me.lciServer.Text = "Server"
            Me.lciServer.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciServer.TextSize = New System.Drawing.Size(46, 13)
            Me.lciServer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' lciDataBase
            ' 
            Me.lciDataBase.Control = Me.cbeDatabase
            Me.lciDataBase.Location = New System.Drawing.Point(0, 100)
            Me.lciDataBase.Name = "lciDataBase"
            Me.lciDataBase.Size = New System.Drawing.Size(181, 40)
            Me.lciDataBase.Text = "Database"
            Me.lciDataBase.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciDataBase.TextSize = New System.Drawing.Size(46, 13)
            Me.lciDataBase.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' lciCube
            ' 
            Me.lciCube.Control = Me.cbeCube
            Me.lciCube.Location = New System.Drawing.Point(0, 140)
            Me.lciCube.Name = "lciCube"
            Me.lciCube.Size = New System.Drawing.Size(181, 40)
            Me.lciCube.Text = "Cube"
            Me.lciCube.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciCube.TextSize = New System.Drawing.Size(46, 13)
            Me.lciCube.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.sbConnect
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 180)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(181, 26)
            Me.layoutControlItem6.Text = "Connect"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            Me.layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Location = New System.Drawing.Point(255, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsBehavior.UseAsyncMode = True
            Me.pivotGridControl.OptionsCustomization.AllowFilterInCustomizationForm = True
            Me.pivotGridControl.OptionsCustomization.AllowSortInCustomizationForm = True
            Me.pivotGridControl.OptionsCustomization.CustomizationFormSearchBoxVisible = True
            Me.pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
            Me.pivotGridControl.OptionsDataField.RowHeaderWidth = 75
            Me.pivotGridControl.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
            Me.pivotGridControl.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree
            Me.pivotGridControl.OptionsView.RowTreeOffset = 16
            Me.pivotGridControl.OptionsView.RowTreeWidth = 75
            Me.pivotGridControl.OptionsView.ShowColumnHeaders = False
            Me.pivotGridControl.OptionsView.ShowDataHeaders = False
            Me.pivotGridControl.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl.OptionsView.ShowRowHeaders = False
            Me.pivotGridControl.OptionsView.ShowTotalsForSingleValues = True
            Me.pivotGridControl.Size = New System.Drawing.Size(235, 427)
            Me.pivotGridControl.TabIndex = 2
            AddHandler Me.pivotGridControl.ShowingCustomizationForm, New DevExpress.XtraPivotGrid.CustomizationFormShowingEventHandler(AddressOf Me.pivotGridControl_ShowingCustomizationForm)
            AddHandler Me.pivotGridControl.PopupMenuShowing, New DevExpress.XtraPivotGrid.PopupMenuShowingEventHandler(AddressOf Me.pivotGridControl_PopupMenuShowing)
            AddHandler Me.pivotGridControl.FieldValueNotExpanded, New DevExpress.XtraPivotGrid.PivotFieldValueEventHandler(AddressOf Me.pivotGridControl_FieldValueNotExpanded)
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mainPanel.Controls.Add(Me.pivotGridControl)
            Me.mainPanel.Controls.Add(Me.sidePanel2)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 43)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(490, 427)
            Me.mainPanel.TabIndex = 7
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.AllowSnap = False
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanel2.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel2.Margin = New System.Windows.Forms.Padding(2)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(255, 427)
            Me.sidePanel2.TabIndex = 0
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' panelError
            ' 
            Me.panelError.Controls.Add(Me.hyperLinkEdit1)
            Me.panelError.Controls.Add(Me.labelControl1)
            Me.panelError.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelError.Location = New System.Drawing.Point(0, 0)
            Me.panelError.Name = "panelError"
            Me.panelError.Size = New System.Drawing.Size(490, 43)
            Me.panelError.TabIndex = 15
            ' 
            ' hyperLinkEdit1
            ' 
            Me.hyperLinkEdit1.EditValue = "https://docs.microsoft.com/en-gb/analysis-services/instances/data-providers-used-for-analysis-services-connections?view=sql-server-2017"
            Me.hyperLinkEdit1.Location = New System.Drawing.Point(280, 19)
            Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
            Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.hyperLinkEdit1.Properties.Caption = "Analysis Services client libraries"
            Me.hyperLinkEdit1.Size = New System.Drawing.Size(250, 18)
            Me.hyperLinkEdit1.TabIndex = 1
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.Appearance.Options.UseForeColor = True
            Me.labelControl1.AutoEllipsis = True
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Location = New System.Drawing.Point(12, 7)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(463, 28)
            Me.labelControl1.TabIndex = 0
            Me.labelControl1.Text = "To run this demo, you should have data providers used for Analysis Services conne" & "ctions installed on your system." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "You can find a list of supported providers her" & "e:"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(490, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 470)
            Me.sidePanel1.TabIndex = 3
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 470)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 470)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 441)
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.Rounded = True
            Me.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.LeftCenter
            ' 
            ' OLAP
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Controls.Add(Me.panelError)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "OLAP"
            Me.Size = New System.Drawing.Size(690, 470)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OLAP_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.beServer.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbeDatabase.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbeCube.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciServer), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciDataBase), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciCube), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainPanel.ResumeLayout(False)
            CType((Me.panelError), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelError.ResumeLayout(False)
            CType((Me.hyperLinkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private mainPanel As DevExpress.XtraEditors.PanelControl

        Private panelError As DevExpress.XtraEditors.PanelControl

        Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup

        Private sbConnect As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private lciServer As DevExpress.XtraLayout.LayoutControlItem

        Private lciDataBase As DevExpress.XtraLayout.LayoutControlItem

        Private lciCube As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private beServer As DevExpress.XtraEditors.ButtonEdit

        Private cbeDatabase As DevExpress.XtraEditors.ComboBoxEdit

        Private cbeCube As DevExpress.XtraEditors.ComboBoxEdit

        Private toolTipController1 As DevExpress.Utils.ToolTipController
    End Class
End Namespace
