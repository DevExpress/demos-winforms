Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGantt.Options
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraGantt.Demos

    Partial Class StartupPlan

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
            Me.taskNameColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.startDateColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.finishDateColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.resourcesColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.baselineStartColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.baselineFinishColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceAllowSplitTasks = New DevExpress.XtraEditors.CheckEdit()
            Me.meLog = New DevExpress.XtraRichEdit.RichEditControl()
            Me.btnClearLog = New DevExpress.XtraEditors.SimpleButton()
            Me.ceEnableTracing = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowBaseLines = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lcgOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcgTracing = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.ganttControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceAllowSplitTasks.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceEnableTracing.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowBaseLines.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgTracing), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' ganttControl1
            ' 
            Me.ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.ganttControl1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.taskNameColumn, Me.startDateColumn, Me.finishDateColumn, Me.resourcesColumn, Me.baselineStartColumn, Me.baselineFinishColumn})
            Me.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ganttControl1.Location = New System.Drawing.Point(0, 0)
            Me.ganttControl1.Name = "ganttControl1"
            Me.ganttControl1.OptionsBehavior.ScheduleMode = DevExpress.XtraGantt.Options.ScheduleMode.Auto
            Me.ganttControl1.OptionsCustomization.AllowModifyDependencies = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsCustomization.AllowModifyTasks = DevExpress.Utils.DefaultBoolean.[True]
            Me.ganttControl1.OptionsPrint.ShowPrintExportProgress = True
            Me.ganttControl1.Size = New System.Drawing.Size(608, 464)
            Me.ganttControl1.SplitterPosition = 400
            Me.ganttControl1.TabIndex = 0
            ' 
            ' taskNameColumn
            ' 
            Me.taskNameColumn.Caption = "Task Name"
            Me.taskNameColumn.FieldName = "Name"
            Me.taskNameColumn.MinWidth = 50
            Me.taskNameColumn.Name = "taskNameColumn"
            Me.taskNameColumn.Visible = True
            Me.taskNameColumn.VisibleIndex = 0
            Me.taskNameColumn.Width = 55
            ' 
            ' startDateColumn
            ' 
            Me.startDateColumn.Caption = "Start Date"
            Me.startDateColumn.FieldName = "StartDate"
            Me.startDateColumn.MinWidth = 30
            Me.startDateColumn.Name = "startDateColumn"
            Me.startDateColumn.Visible = True
            Me.startDateColumn.VisibleIndex = 1
            Me.startDateColumn.Width = 35
            ' 
            ' finishDateColumn
            ' 
            Me.finishDateColumn.Caption = "Finish Date"
            Me.finishDateColumn.FieldName = "FinishDate"
            Me.finishDateColumn.MinWidth = 30
            Me.finishDateColumn.Name = "finishDateColumn"
            Me.finishDateColumn.Visible = True
            Me.finishDateColumn.VisibleIndex = 2
            Me.finishDateColumn.Width = 50
            ' 
            ' resourcesColumn
            ' 
            Me.resourcesColumn.Caption = "Resources"
            Me.resourcesColumn.FieldName = "Resources"
            Me.resourcesColumn.MinWidth = 30
            Me.resourcesColumn.Name = "resourcesColumn"
            Me.resourcesColumn.Visible = True
            Me.resourcesColumn.VisibleIndex = 3
            Me.resourcesColumn.Width = 60
            ' 
            ' baselineStartColumn
            ' 
            Me.baselineStartColumn.Caption = "Baseline Start"
            Me.baselineStartColumn.FieldName = "BaselineStartDate"
            Me.baselineStartColumn.Name = "baselineStartColumn"
            ' 
            ' baselineFinishColumn
            ' 
            Me.baselineFinishColumn.Caption = "Baseline Finish"
            Me.baselineFinishColumn.FieldName = "BaselineFinishDate"
            Me.baselineFinishColumn.Name = "baselineFinishColumn"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceAllowSplitTasks)
            Me.layoutControl1.Controls.Add(Me.meLog)
            Me.layoutControl1.Controls.Add(Me.btnClearLog)
            Me.layoutControl1.Controls.Add(Me.ceEnableTracing)
            Me.layoutControl1.Controls.Add(Me.ceShowBaseLines)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(790, 185, 876, 498)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(278, 431)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceAllowSplitTasks
            ' 
            Me.ceAllowSplitTasks.Location = New System.Drawing.Point(12, 58)
            Me.ceAllowSplitTasks.Name = "ceAllowSplitTasks"
            Me.ceAllowSplitTasks.Properties.Caption = "Allow Split Tasks"
            Me.ceAllowSplitTasks.Size = New System.Drawing.Size(254, 20)
            Me.ceAllowSplitTasks.StyleController = Me.layoutControl1
            Me.ceAllowSplitTasks.TabIndex = 9
            AddHandler Me.ceAllowSplitTasks.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowSplitTasks_CheckedChanged)
            ' 
            ' meLog
            ' 
            Me.meLog.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            Me.meLog.Appearance.Text.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.meLog.Appearance.Text.Options.UseFont = True
            Me.meLog.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            Me.meLog.Location = New System.Drawing.Point(12, 148)
            Me.meLog.Name = "meLog"
            Me.meLog.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.meLog.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.meLog.[ReadOnly] = True
            Me.meLog.ShowCaretInReadOnly = False
            Me.meLog.Size = New System.Drawing.Size(254, 245)
            Me.meLog.TabIndex = 8
            ' 
            ' btnClearLog
            ' 
            Me.btnClearLog.Location = New System.Drawing.Point(12, 397)
            Me.btnClearLog.Name = "btnClearLog"
            Me.btnClearLog.Size = New System.Drawing.Size(254, 22)
            Me.btnClearLog.StyleController = Me.layoutControl1
            Me.btnClearLog.TabIndex = 7
            Me.btnClearLog.Text = "Clear Log"
            AddHandler Me.btnClearLog.Click, New System.EventHandler(AddressOf Me.btnClearLog_Click)
            ' 
            ' ceEnableTracing
            ' 
            Me.ceEnableTracing.EditValue = True
            Me.ceEnableTracing.Location = New System.Drawing.Point(12, 124)
            Me.ceEnableTracing.Name = "ceEnableTracing"
            Me.ceEnableTracing.Properties.Caption = "Enable Tracing"
            Me.ceEnableTracing.Size = New System.Drawing.Size(254, 20)
            Me.ceEnableTracing.StyleController = Me.layoutControl1
            Me.ceEnableTracing.TabIndex = 6
            AddHandler Me.ceEnableTracing.CheckedChanged, New System.EventHandler(AddressOf Me.ceEnableTracing_CheckedChanged)
            ' 
            ' ceShowBaseLines
            ' 
            Me.ceShowBaseLines.Location = New System.Drawing.Point(12, 34)
            Me.ceShowBaseLines.Name = "ceShowBaseLines"
            Me.ceShowBaseLines.Properties.Caption = "Show BaseLines"
            Me.ceShowBaseLines.Size = New System.Drawing.Size(254, 20)
            Me.ceShowBaseLines.StyleController = Me.layoutControl1
            Me.ceShowBaseLines.TabIndex = 4
            AddHandler Me.ceShowBaseLines.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowBaseLines_CheckedChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lcgOptions, Me.lcgTracing})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(278, 431)
            Me.Root.TextVisible = False
            ' 
            ' lcgOptions
            ' 
            Me.lcgOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem5})
            Me.lcgOptions.Location = New System.Drawing.Point(0, 0)
            Me.lcgOptions.Name = "lcgOptions"
            Me.lcgOptions.Size = New System.Drawing.Size(278, 90)
            Me.lcgOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgOptions.Text = "Options"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceShowBaseLines
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(258, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceAllowSplitTasks
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(258, 24)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' lcgTracing
            ' 
            Me.lcgTracing.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgTracing.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.lcgTracing.Location = New System.Drawing.Point(0, 90)
            Me.lcgTracing.Name = "lcgTracing"
            Me.lcgTracing.Size = New System.Drawing.Size(278, 341)
            Me.lcgTracing.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgTracing.Text = "Tracing"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceEnableTracing
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(258, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.btnClearLog
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 273)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(258, 26)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.meLog
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(258, 249)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(608, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(279, 464)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(278, 464)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(278, 464)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(278, 431)
            ' 
            ' StartupPlan
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ganttControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "StartupPlan"
            Me.Size = New System.Drawing.Size(887, 464)
            CType((Me.ganttControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceAllowSplitTasks.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceEnableTracing.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowBaseLines.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgTracing), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private ganttControl1 As DevExpress.XtraGantt.GanttControl

        Private taskNameColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private startDateColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private finishDateColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private resourcesColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private baselineStartColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private baselineFinishColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private ceShowBaseLines As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private lcgOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private lcgTracing As DevExpress.XtraLayout.LayoutControlGroup

        Private btnClearLog As DevExpress.XtraEditors.SimpleButton

        Private ceEnableTracing As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private meLog As DevExpress.XtraRichEdit.RichEditControl

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private ceAllowSplitTasks As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    End Class
End Namespace
