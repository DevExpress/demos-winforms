Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGantt.Demos

    Partial Class MarketResearchSchedule

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.ganttControl1 = New DevExpress.XtraGantt.GanttControl()
            Me.ganttColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.ganttColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.ganttColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.tePageCaption = New DevExpress.XtraEditors.TextEdit()
            Me.cePrintAllNodes = New DevExpress.XtraEditors.CheckEdit()
            Me.deChartFinishDate = New DevExpress.XtraEditors.DateEdit()
            Me.deChartStartDate = New DevExpress.XtraEditors.DateEdit()
            Me.icePaperKind = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.iceOrientation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icePageInfoType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.cePrintPageInfo = New DevExpress.XtraEditors.CheckEdit()
            Me.cePrintLegend = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciPrintLegend = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPrintPageInfo = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPageInfoType = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciChartStartDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciChartFinishDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPrintAllNodes = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcePageCaption = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciOrientation = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPaperKind = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.ganttControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.tePageCaption.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cePrintAllNodes.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.deChartFinishDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.deChartFinishDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.deChartStartDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.deChartStartDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icePaperKind.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.iceOrientation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icePageInfoType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cePrintPageInfo.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cePrintLegend.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciPrintLegend), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciPrintPageInfo), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciPageInfoType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciChartStartDate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciChartFinishDate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciPrintAllNodes), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcePageCaption), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciOrientation), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciPaperKind), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' ganttControl1
            ' 
            Me.ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.ganttControl1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.ganttColumn1, Me.ganttColumn2, Me.ganttColumn3})
            Me.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ganttControl1.Location = New System.Drawing.Point(0, 0)
            Me.ganttControl1.Name = "ganttControl1"
            Me.ganttControl1.OptionsPrint.PrintAllNodes = True
            Me.ganttControl1.OptionsPrint.PrintLegend = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsPrint.PrintPageInfo = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsPrint.ShowPrintExportProgress = True
            Me.ganttControl1.Size = New System.Drawing.Size(612, 457)
            Me.ganttControl1.SplitterPosition = 400
            Me.ganttControl1.TabIndex = 1
            ' 
            ' ganttColumn1
            ' 
            Me.ganttColumn1.Caption = "Name"
            Me.ganttColumn1.FieldName = "Name"
            Me.ganttColumn1.Name = "ganttColumn1"
            Me.ganttColumn1.Visible = True
            Me.ganttColumn1.VisibleIndex = 0
            Me.ganttColumn1.Width = 263
            ' 
            ' ganttColumn2
            ' 
            Me.ganttColumn2.Caption = "Start Date"
            Me.ganttColumn2.FieldName = "StartDate"
            Me.ganttColumn2.Name = "ganttColumn2"
            Me.ganttColumn2.Visible = True
            Me.ganttColumn2.VisibleIndex = 1
            Me.ganttColumn2.Width = 66
            ' 
            ' ganttColumn3
            ' 
            Me.ganttColumn3.Caption = "Finish Date"
            Me.ganttColumn3.FieldName = "FinishDate"
            Me.ganttColumn3.Name = "ganttColumn3"
            Me.ganttColumn3.Visible = True
            Me.ganttColumn3.VisibleIndex = 2
            Me.ganttColumn3.Width = 71
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.tePageCaption)
            Me.layoutControl1.Controls.Add(Me.cePrintAllNodes)
            Me.layoutControl1.Controls.Add(Me.deChartFinishDate)
            Me.layoutControl1.Controls.Add(Me.deChartStartDate)
            Me.layoutControl1.Controls.Add(Me.icePaperKind)
            Me.layoutControl1.Controls.Add(Me.iceOrientation)
            Me.layoutControl1.Controls.Add(Me.icePageInfoType)
            Me.layoutControl1.Controls.Add(Me.cePrintPageInfo)
            Me.layoutControl1.Controls.Add(Me.cePrintLegend)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(861, 138, 899, 521)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(207, 424)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' tePageCaption
            ' 
            Me.tePageCaption.Location = New System.Drawing.Point(12, 162)
            Me.tePageCaption.Name = "tePageCaption"
            Me.tePageCaption.Size = New System.Drawing.Size(183, 20)
            Me.tePageCaption.StyleController = Me.layoutControl1
            Me.tePageCaption.TabIndex = 12
            AddHandler Me.tePageCaption.EditValueChanged, New System.EventHandler(AddressOf Me.tePageCaption_EditValueChanged)
            ' 
            ' cePrintAllNodes
            ' 
            Me.cePrintAllNodes.Location = New System.Drawing.Point(12, 34)
            Me.cePrintAllNodes.Name = "cePrintAllNodes"
            Me.cePrintAllNodes.Properties.Caption = "Print All Nodes"
            Me.cePrintAllNodes.Size = New System.Drawing.Size(183, 20)
            Me.cePrintAllNodes.StyleController = Me.layoutControl1
            Me.cePrintAllNodes.TabIndex = 11
            AddHandler Me.cePrintAllNodes.CheckedChanged, New System.EventHandler(AddressOf Me.cePrintAllNodes_CheckedChanged)
            ' 
            ' deChartFinishDate
            ' 
            Me.deChartFinishDate.EditValue = Nothing
            Me.deChartFinishDate.Location = New System.Drawing.Point(12, 242)
            Me.deChartFinishDate.Name = "deChartFinishDate"
            Me.deChartFinishDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.deChartFinishDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.deChartFinishDate.Size = New System.Drawing.Size(183, 20)
            Me.deChartFinishDate.StyleController = Me.layoutControl1
            Me.deChartFinishDate.TabIndex = 10
            AddHandler Me.deChartFinishDate.EditValueChanged, New System.EventHandler(AddressOf Me.deChartFinishDate_EditValueChanged)
            ' 
            ' deChartStartDate
            ' 
            Me.deChartStartDate.EditValue = Nothing
            Me.deChartStartDate.Location = New System.Drawing.Point(12, 202)
            Me.deChartStartDate.Name = "deChartStartDate"
            Me.deChartStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.deChartStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.deChartStartDate.Size = New System.Drawing.Size(183, 20)
            Me.deChartStartDate.StyleController = Me.layoutControl1
            Me.deChartStartDate.TabIndex = 9
            AddHandler Me.deChartStartDate.EditValueChanged, New System.EventHandler(AddressOf Me.deChartStartDate_EditValueChanged)
            ' 
            ' icePaperKind
            ' 
            Me.icePaperKind.Location = New System.Drawing.Point(12, 364)
            Me.icePaperKind.Name = "icePaperKind"
            Me.icePaperKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icePaperKind.Size = New System.Drawing.Size(183, 20)
            Me.icePaperKind.StyleController = Me.layoutControl1
            Me.icePaperKind.TabIndex = 8
            ' 
            ' iceOrientation
            ' 
            Me.iceOrientation.Location = New System.Drawing.Point(12, 324)
            Me.iceOrientation.Name = "iceOrientation"
            Me.iceOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.iceOrientation.Size = New System.Drawing.Size(183, 20)
            Me.iceOrientation.StyleController = Me.layoutControl1
            Me.iceOrientation.TabIndex = 7
            ' 
            ' icePageInfoType
            ' 
            Me.icePageInfoType.Location = New System.Drawing.Point(12, 122)
            Me.icePageInfoType.Name = "icePageInfoType"
            Me.icePageInfoType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icePageInfoType.Size = New System.Drawing.Size(183, 20)
            Me.icePageInfoType.StyleController = Me.layoutControl1
            Me.icePageInfoType.TabIndex = 6
            AddHandler Me.icePageInfoType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icePageInfoType_SelectedIndexChanged)
            ' 
            ' cePrintPageInfo
            ' 
            Me.cePrintPageInfo.Location = New System.Drawing.Point(12, 82)
            Me.cePrintPageInfo.Name = "cePrintPageInfo"
            Me.cePrintPageInfo.Properties.Caption = "Print Page Info"
            Me.cePrintPageInfo.Size = New System.Drawing.Size(183, 20)
            Me.cePrintPageInfo.StyleController = Me.layoutControl1
            Me.cePrintPageInfo.TabIndex = 5
            AddHandler Me.cePrintPageInfo.CheckedChanged, New System.EventHandler(AddressOf Me.cePrintPageInfo_CheckedChanged)
            ' 
            ' cePrintLegend
            ' 
            Me.cePrintLegend.Location = New System.Drawing.Point(12, 58)
            Me.cePrintLegend.Name = "cePrintLegend"
            Me.cePrintLegend.Properties.Caption = "Print Legend"
            Me.cePrintLegend.Size = New System.Drawing.Size(183, 20)
            Me.cePrintLegend.StyleController = Me.layoutControl1
            Me.cePrintLegend.TabIndex = 4
            AddHandler Me.cePrintLegend.CheckedChanged, New System.EventHandler(AddressOf Me.cePrintLegend_CheckedChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup1, Me.layoutControlGroup2})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(207, 424)
            Me.Root.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 396)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(207, 28)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciPrintLegend, Me.lciPrintPageInfo, Me.lciPageInfoType, Me.lciChartStartDate, Me.lciChartFinishDate, Me.lciPrintAllNodes, Me.lcePageCaption})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(207, 274)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Options"
            ' 
            ' lciPrintLegend
            ' 
            Me.lciPrintLegend.Control = Me.cePrintLegend
            Me.lciPrintLegend.CustomizationFormText = "Print Legend"
            Me.lciPrintLegend.Location = New System.Drawing.Point(0, 24)
            Me.lciPrintLegend.Name = "lciPrintLegend"
            Me.lciPrintLegend.Size = New System.Drawing.Size(187, 24)
            Me.lciPrintLegend.TextVisible = False
            ' 
            ' lciPrintPageInfo
            ' 
            Me.lciPrintPageInfo.Control = Me.cePrintPageInfo
            Me.lciPrintPageInfo.CustomizationFormText = "Print Page Info"
            Me.lciPrintPageInfo.Location = New System.Drawing.Point(0, 48)
            Me.lciPrintPageInfo.Name = "lciPrintPageInfo"
            Me.lciPrintPageInfo.Size = New System.Drawing.Size(187, 24)
            Me.lciPrintPageInfo.TextVisible = False
            ' 
            ' lciPageInfoType
            ' 
            Me.lciPageInfoType.Control = Me.icePageInfoType
            Me.lciPageInfoType.Location = New System.Drawing.Point(0, 72)
            Me.lciPageInfoType.Name = "lciPageInfoType"
            Me.lciPageInfoType.Size = New System.Drawing.Size(187, 40)
            Me.lciPageInfoType.Text = "Page Info Type"
            Me.lciPageInfoType.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciPageInfoType.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' lciChartStartDate
            ' 
            Me.lciChartStartDate.Control = Me.deChartStartDate
            Me.lciChartStartDate.Location = New System.Drawing.Point(0, 152)
            Me.lciChartStartDate.Name = "lciChartStartDate"
            Me.lciChartStartDate.Size = New System.Drawing.Size(187, 40)
            Me.lciChartStartDate.Text = "Chart Start Date"
            Me.lciChartStartDate.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciChartStartDate.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' lciChartFinishDate
            ' 
            Me.lciChartFinishDate.Control = Me.deChartFinishDate
            Me.lciChartFinishDate.Location = New System.Drawing.Point(0, 192)
            Me.lciChartFinishDate.Name = "lciChartFinishDate"
            Me.lciChartFinishDate.Size = New System.Drawing.Size(187, 40)
            Me.lciChartFinishDate.Text = "Chart Finish Date"
            Me.lciChartFinishDate.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciChartFinishDate.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' lciPrintAllNodes
            ' 
            Me.lciPrintAllNodes.Control = Me.cePrintAllNodes
            Me.lciPrintAllNodes.Location = New System.Drawing.Point(0, 0)
            Me.lciPrintAllNodes.Name = "lciPrintAllNodes"
            Me.lciPrintAllNodes.Size = New System.Drawing.Size(187, 24)
            Me.lciPrintAllNodes.TextVisible = False
            ' 
            ' lcePageCaption
            ' 
            Me.lcePageCaption.Control = Me.tePageCaption
            Me.lcePageCaption.Location = New System.Drawing.Point(0, 112)
            Me.lcePageCaption.Name = "lcePageCaption"
            Me.lcePageCaption.Size = New System.Drawing.Size(187, 40)
            Me.lcePageCaption.Text = "Page Info Caption"
            Me.lcePageCaption.TextLocation = DevExpress.Utils.Locations.Top
            Me.lcePageCaption.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciOrientation, Me.lciPaperKind})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 274)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(207, 122)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Page Settings"
            ' 
            ' lciOrientation
            ' 
            Me.lciOrientation.Control = Me.iceOrientation
            Me.lciOrientation.Location = New System.Drawing.Point(0, 0)
            Me.lciOrientation.Name = "lciOrientation"
            Me.lciOrientation.Size = New System.Drawing.Size(187, 40)
            Me.lciOrientation.Text = "Orientation"
            Me.lciOrientation.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciOrientation.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' lciPaperKind
            ' 
            Me.lciPaperKind.Control = Me.icePaperKind
            Me.lciPaperKind.Location = New System.Drawing.Point(0, 40)
            Me.lciPaperKind.Name = "lciPaperKind"
            Me.lciPaperKind.Size = New System.Drawing.Size(187, 40)
            Me.lciPaperKind.Text = "Paper Kind"
            Me.lciPaperKind.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciPaperKind.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(612, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(208, 457)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(207, 457)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(207, 457)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Printing"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(207, 424)
            ' 
            ' MarketResearchSchedule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ganttControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "MarketResearchSchedule"
            Me.Size = New System.Drawing.Size(820, 457)
            CType((Me.ganttControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.tePageCaption.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cePrintAllNodes.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.deChartFinishDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.deChartFinishDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.deChartStartDate.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.deChartStartDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icePaperKind.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.iceOrientation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icePageInfoType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cePrintPageInfo.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cePrintLegend.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciPrintLegend), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciPrintPageInfo), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciPageInfoType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciChartStartDate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciChartFinishDate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciPrintAllNodes), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcePageCaption), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciOrientation), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciPaperKind), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private ganttControl1 As DevExpress.XtraGantt.GanttControl

        Private ganttColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private ganttColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private ganttColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private icePageInfoType As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cePrintPageInfo As DevExpress.XtraEditors.CheckEdit

        Private cePrintLegend As DevExpress.XtraEditors.CheckEdit

        Private lciPrintLegend As DevExpress.XtraLayout.LayoutControlItem

        Private lciPrintPageInfo As DevExpress.XtraLayout.LayoutControlItem

        Private lciPageInfoType As DevExpress.XtraLayout.LayoutControlItem

        Private iceOrientation As DevExpress.XtraEditors.ImageComboBoxEdit

        Private lciOrientation As DevExpress.XtraLayout.LayoutControlItem

        Private icePaperKind As DevExpress.XtraEditors.ImageComboBoxEdit

        Private lciPaperKind As DevExpress.XtraLayout.LayoutControlItem

        Private deChartFinishDate As DevExpress.XtraEditors.DateEdit

        Private deChartStartDate As DevExpress.XtraEditors.DateEdit

        Private lciChartStartDate As DevExpress.XtraLayout.LayoutControlItem

        Private lciChartFinishDate As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private cePrintAllNodes As DevExpress.XtraEditors.CheckEdit

        Private lciPrintAllNodes As DevExpress.XtraLayout.LayoutControlItem

        Private tePageCaption As DevExpress.XtraEditors.TextEdit

        Private lcePageCaption As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    End Class
End Namespace
