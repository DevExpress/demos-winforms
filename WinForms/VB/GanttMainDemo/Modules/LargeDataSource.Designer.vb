Imports DevExpress.Utils.Layout
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGantt.Demos

    Partial Class LargeDataSource

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
            Me.uidColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.nameColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.startColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.duractionColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.predecessorColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.parentUIDColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.tablePanel2 = New DevExpress.Utils.Layout.TablePanel()
            Me.btngenerate = New DevExpress.XtraEditors.SimpleButton()
            Me.customTasksCount = New DevExpress.XtraEditors.SpinEdit()
            Me.ceCustom = New DevExpress.XtraEditors.CheckEdit()
            Me.ceValue3 = New DevExpress.XtraEditors.CheckEdit()
            Me.ceValue2 = New DevExpress.XtraEditors.CheckEdit()
            Me.ceValue1 = New DevExpress.XtraEditors.CheckEdit()
            CType((Me.ganttControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.tablePanel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel2.SuspendLayout()
            CType((Me.customTasksCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCustom.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceValue3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceValue2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceValue1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ganttControl1
            ' 
            Me.ganttControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.ganttControl1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.uidColumn, Me.nameColumn, Me.startColumn, Me.duractionColumn, Me.predecessorColumn, Me.parentUIDColumn})
            Me.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ganttControl1.Location = New System.Drawing.Point(0, 0)
            Me.ganttControl1.Name = "ganttControl1"
            Me.ganttControl1.OptionsBehavior.Editable = False
            Me.ganttControl1.OptionsBehavior.[ReadOnly] = True
            Me.ganttControl1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.ganttControl1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
            Me.ganttControl1.OptionsView.InteractionTooltipLocation = DevExpress.XtraGantt.InteractionTooltipLocation.None
            Me.ganttControl1.OptionsView.ShowIndentAsRowStyle = True
            Me.ganttControl1.OptionsView.ShowSummaryFooter = True
            Me.ganttControl1.Size = New System.Drawing.Size(728, 491)
            Me.ganttControl1.TabIndex = 0
            Me.ganttControl1.TreeListMappings.HierarchyColumn = Me.nameColumn
            ' 
            ' uidColumn
            ' 
            Me.uidColumn.Caption = "ID"
            Me.uidColumn.FieldName = "UID"
            Me.uidColumn.Name = "uidColumn"
            ' 
            ' nameColumn
            ' 
            Me.nameColumn.AllNodesSummary = True
            Me.nameColumn.Caption = "Name"
            Me.nameColumn.FieldName = "Name"
            Me.nameColumn.Name = "nameColumn"
            Me.nameColumn.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count
            Me.nameColumn.SummaryFooterStrFormat = "Tasks Count: {0}"
            Me.nameColumn.Visible = True
            Me.nameColumn.VisibleIndex = 0
            ' 
            ' startColumn
            ' 
            Me.startColumn.Caption = "Start"
            Me.startColumn.FieldName = "Start"
            Me.startColumn.MaxWidth = 90
            Me.startColumn.Name = "startColumn"
            ' 
            ' duractionColumn
            ' 
            Me.duractionColumn.Caption = "Duration"
            Me.duractionColumn.FieldName = "Duration"
            Me.duractionColumn.MaxWidth = 90
            Me.duractionColumn.Name = "duractionColumn"
            ' 
            ' predecessorColumn
            ' 
            Me.predecessorColumn.Caption = "Predecessors"
            Me.predecessorColumn.FieldName = "Predecessors"
            Me.predecessorColumn.Name = "predecessorColumn"
            ' 
            ' parentUIDColumn
            ' 
            Me.parentUIDColumn.Caption = "ParentUID"
            Me.parentUIDColumn.FieldName = "ParentUID"
            Me.parentUIDColumn.Name = "parentUIDColumn"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(728, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(210, 491)
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
            Me.tabPane1.RegularSize = New System.Drawing.Size(209, 491)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(209, 491)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Tasks"
            Me.tabNavigationPage1.Controls.Add(Me.tablePanel1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(209, 458)
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)})
            Me.tablePanel1.Controls.Add(Me.tablePanel2)
            Me.tablePanel1.Controls.Add(Me.ceCustom)
            Me.tablePanel1.Controls.Add(Me.ceValue3)
            Me.tablePanel1.Controls.Add(Me.ceValue2)
            Me.tablePanel1.Controls.Add(Me.ceValue1)
            Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Padding = New System.Windows.Forms.Padding(16)
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 31F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)})
            Me.tablePanel1.Size = New System.Drawing.Size(209, 458)
            Me.tablePanel1.TabIndex = 0
            ' 
            ' tablePanel2
            ' 
            Me.tablePanel2.AutoSize = True
            Me.tablePanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.tablePanel1.SetColumn(Me.tablePanel2, 0)
            Me.tablePanel2.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37.96F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 22.04F)})
            Me.tablePanel2.Controls.Add(Me.btngenerate)
            Me.tablePanel2.Controls.Add(Me.customTasksCount)
            Me.tablePanel2.Location = New System.Drawing.Point(19, 123)
            Me.tablePanel2.Name = "tablePanel2"
            Me.tablePanel1.SetRow(Me.tablePanel2, 4)
            Me.tablePanel2.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 4F)})
            Me.tablePanel2.Size = New System.Drawing.Size(171, 30)
            Me.tablePanel2.TabIndex = 4
            ' 
            ' btngenerate
            ' 
            Me.tablePanel2.SetColumn(Me.btngenerate, 1)
            Me.btngenerate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btngenerate.Location = New System.Drawing.Point(111, 3)
            Me.btngenerate.Name = "btngenerate"
            Me.tablePanel2.SetRow(Me.btngenerate, 0)
            Me.btngenerate.Size = New System.Drawing.Size(57, 20)
            Me.btngenerate.TabIndex = 1
            Me.btngenerate.Text = "Generate"
            AddHandler Me.btngenerate.Click, New System.EventHandler(AddressOf Me.btngenerate_Click)
            ' 
            ' customTasksCount
            ' 
            Me.tablePanel2.SetColumn(Me.customTasksCount, 0)
            Me.customTasksCount.EditValue = New Decimal(New Integer() {1500000, 0, 0, 0})
            Me.customTasksCount.Location = New System.Drawing.Point(3, 3)
            Me.customTasksCount.Name = "customTasksCount"
            Me.customTasksCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.customTasksCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.customTasksCount.Properties.MaxValue = New Decimal(New Integer() {1500000, 0, 0, 0})
            Me.tablePanel2.SetRow(Me.customTasksCount, 0)
            Me.customTasksCount.Size = New System.Drawing.Size(102, 20)
            Me.customTasksCount.TabIndex = 0
            AddHandler Me.customTasksCount.Enter, New System.EventHandler(AddressOf Me.seCustomRecordsCount_Enter)
            ' 
            ' ceCustom
            ' 
            Me.tablePanel1.SetColumn(Me.ceCustom, 0)
            Me.ceCustom.Location = New System.Drawing.Point(19, 97)
            Me.ceCustom.Name = "ceCustom"
            Me.ceCustom.Properties.Caption = "Enter tasks count"
            Me.ceCustom.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ceCustom.Properties.RadioGroupIndex = 0
            Me.tablePanel1.SetRow(Me.ceCustom, 3)
            Me.ceCustom.Size = New System.Drawing.Size(171, 20)
            Me.ceCustom.TabIndex = 3
            Me.ceCustom.TabStop = False
            AddHandler Me.ceCustom.CheckedChanged, New System.EventHandler(AddressOf Me.ceTask_CheckedChanged)
            ' 
            ' ceValue3
            ' 
            Me.tablePanel1.SetColumn(Me.ceValue3, 0)
            Me.ceValue3.Location = New System.Drawing.Point(19, 71)
            Me.ceValue3.Name = "ceValue3"
            Me.ceValue3.Properties.Caption = "1M"
            Me.ceValue3.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ceValue3.Properties.RadioGroupIndex = 0
            Me.tablePanel1.SetRow(Me.ceValue3, 2)
            Me.ceValue3.Size = New System.Drawing.Size(171, 20)
            Me.ceValue3.TabIndex = 2
            Me.ceValue3.TabStop = False
            AddHandler Me.ceValue3.CheckedChanged, New System.EventHandler(AddressOf Me.ceTask_CheckedChanged)
            ' 
            ' ceValue2
            ' 
            Me.tablePanel1.SetColumn(Me.ceValue2, 0)
            Me.ceValue2.Location = New System.Drawing.Point(19, 45)
            Me.ceValue2.Name = "ceValue2"
            Me.ceValue2.Properties.Caption = "500K"
            Me.ceValue2.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ceValue2.Properties.RadioGroupIndex = 0
            Me.tablePanel1.SetRow(Me.ceValue2, 1)
            Me.ceValue2.Size = New System.Drawing.Size(171, 20)
            Me.ceValue2.TabIndex = 1
            Me.ceValue2.TabStop = False
            AddHandler Me.ceValue2.CheckedChanged, New System.EventHandler(AddressOf Me.ceTask_CheckedChanged)
            ' 
            ' ceValue1
            ' 
            Me.tablePanel1.SetColumn(Me.ceValue1, 0)
            Me.ceValue1.EditValue = True
            Me.ceValue1.Location = New System.Drawing.Point(19, 19)
            Me.ceValue1.Name = "ceValue1"
            Me.ceValue1.Properties.Caption = "100K"
            Me.ceValue1.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio
            Me.ceValue1.Properties.RadioGroupIndex = 0
            Me.tablePanel1.SetRow(Me.ceValue1, 0)
            Me.ceValue1.Size = New System.Drawing.Size(171, 20)
            Me.ceValue1.TabIndex = 0
            AddHandler Me.ceValue1.CheckedChanged, New System.EventHandler(AddressOf Me.ceTask_CheckedChanged)
            ' 
            ' LargeDataSource
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ganttControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "LargeDataSource"
            Me.Size = New System.Drawing.Size(938, 491)
            CType((Me.ganttControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            Me.tablePanel1.PerformLayout()
            CType((Me.tablePanel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel2.ResumeLayout(False)
            CType((Me.customTasksCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCustom.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceValue3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceValue2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceValue1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private ganttControl1 As DevExpress.XtraGantt.GanttControl

        Private nameColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private startColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private duractionColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private predecessorColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private uidColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private parentUIDColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private ceValue1 As DevExpress.XtraEditors.CheckEdit

        Private tablePanel2 As DevExpress.Utils.Layout.TablePanel

        Private customTasksCount As DevExpress.XtraEditors.SpinEdit

        Private ceCustom As DevExpress.XtraEditors.CheckEdit

        Private ceValue3 As DevExpress.XtraEditors.CheckEdit

        Private ceValue2 As DevExpress.XtraEditors.CheckEdit

        Private btngenerate As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
