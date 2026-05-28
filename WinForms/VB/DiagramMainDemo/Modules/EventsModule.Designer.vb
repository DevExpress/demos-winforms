Namespace DevExpress.XtraDiagram.Demos

    Partial Class EventsModule

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
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.eventsLogTab = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.eventsLogBorder = New DevExpress.XtraEditors.PanelControl()
            Me.eventsLogPanel = New DevExpress.XtraEditors.XtraScrollableControl()
            Me.eventsLog = New DevExpress.XtraEditors.LabelControl()
            Me.clearLogButtonPanel = New DevExpress.XtraEditors.PanelControl()
            Me.containerControl2 = New System.Windows.Forms.ContainerControl()
            Me.clearLogButton = New DevExpress.XtraEditors.SimpleButton()
            Me.trackEventsTab = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.trackedEvents = New DevExpress.XtraDiagram.Demos.EvensTreeList()
            Me.colTitle = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colIsParameter = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colIsChecked = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colParent = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.diagramEventNodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.containerControl.SuspendLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.eventsLogTab.SuspendLayout()
            CType((Me.eventsLogBorder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.eventsLogBorder.SuspendLayout()
            Me.eventsLogPanel.SuspendLayout()
            CType((Me.clearLogButtonPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.clearLogButtonPanel.SuspendLayout()
            Me.containerControl2.SuspendLayout()
            Me.trackEventsTab.SuspendLayout()
            CType((Me.trackedEvents), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.diagramEventNodeBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(1094, 472)
            Me.containerControl.Controls.SetChildIndex(Me.diagramControl, 0)
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.Location = New System.Drawing.Point(62, 150)
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String(-1) {})
            Me.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Compact
            Me.diagramControl.Size = New System.Drawing.Size(1032, 295)
            ' 
            ' eventsLogTab
            ' 
            Me.eventsLogTab.Caption = "Events Log"
            Me.eventsLogTab.Controls.Add(Me.eventsLogBorder)
            Me.eventsLogTab.Controls.Add(Me.clearLogButtonPanel)
            Me.eventsLogTab.Name = "eventsLogTab"
            Me.eventsLogTab.Padding = New System.Windows.Forms.Padding(12)
            Me.eventsLogTab.Size = New System.Drawing.Size(249, 441)
            ' 
            ' eventsLogBorder
            ' 
            Me.eventsLogBorder.Controls.Add(Me.eventsLogPanel)
            Me.eventsLogBorder.Dock = System.Windows.Forms.DockStyle.Fill
            Me.eventsLogBorder.Location = New System.Drawing.Point(12, 12)
            Me.eventsLogBorder.Name = "eventsLogBorder"
            Me.eventsLogBorder.Size = New System.Drawing.Size(225, 382)
            Me.eventsLogBorder.TabIndex = 1
            ' 
            ' eventsLogPanel
            ' 
            Me.eventsLogPanel.Controls.Add(Me.eventsLog)
            Me.eventsLogPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.eventsLogPanel.Location = New System.Drawing.Point(2, 2)
            Me.eventsLogPanel.Name = "eventsLogPanel"
            Me.eventsLogPanel.Size = New System.Drawing.Size(221, 378)
            Me.eventsLogPanel.TabIndex = 1
            ' 
            ' eventsLog
            ' 
            Me.eventsLog.AllowHtmlString = True
            Me.eventsLog.Appearance.Options.UseTextOptions = True
            Me.eventsLog.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.eventsLog.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.eventsLog.Location = New System.Drawing.Point(0, 0)
            Me.eventsLog.Name = "eventsLog"
            Me.eventsLog.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.eventsLog.Size = New System.Drawing.Size(6, 0)
            Me.eventsLog.TabIndex = 0
            AddHandler Me.eventsLog.HyperlinkClick, New DevExpress.Utils.HyperlinkClickEventHandler(AddressOf Me.OnEventsLogHyperlinkClick)
            AddHandler Me.eventsLog.MouseLeave, New System.EventHandler(AddressOf Me.OnEventsLogMouseLeave)
            AddHandler Me.eventsLog.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnEventsLogMouseMove)
            ' 
            ' clearLogButtonPanel
            ' 
            Me.clearLogButtonPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.clearLogButtonPanel.Controls.Add(Me.containerControl2)
            Me.clearLogButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.clearLogButtonPanel.Location = New System.Drawing.Point(12, 394)
            Me.clearLogButtonPanel.Name = "clearLogButtonPanel"
            Me.clearLogButtonPanel.Size = New System.Drawing.Size(225, 35)
            Me.clearLogButtonPanel.TabIndex = 1
            ' 
            ' containerControl2
            ' 
            Me.containerControl2.Controls.Add(Me.clearLogButton)
            Me.containerControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.containerControl2.Location = New System.Drawing.Point(0, 0)
            Me.containerControl2.Name = "containerControl2"
            Me.containerControl2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.containerControl2.Size = New System.Drawing.Size(225, 32)
            Me.containerControl2.TabIndex = 0
            ' 
            ' clearLogButton
            ' 
            Me.clearLogButton.Dock = System.Windows.Forms.DockStyle.Fill
            Me.clearLogButton.Location = New System.Drawing.Point(0, 10)
            Me.clearLogButton.Name = "clearLogButton"
            Me.clearLogButton.Size = New System.Drawing.Size(225, 22)
            Me.clearLogButton.TabIndex = 0
            Me.clearLogButton.Text = "Clear Log"
            AddHandler Me.clearLogButton.Click, New System.EventHandler(AddressOf Me.OnClearLogButtonClick)
            ' 
            ' trackEventsTab
            ' 
            Me.trackEventsTab.Caption = "Track Events"
            Me.trackEventsTab.Controls.Add(Me.trackedEvents)
            Me.trackEventsTab.Name = "trackEventsTab"
            Me.trackEventsTab.Size = New System.Drawing.Size(249, 441)
            ' 
            ' trackedEvents
            ' 
            Me.trackedEvents.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.trackedEvents.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colTitle, Me.colIsParameter, Me.colIsChecked, Me.colParent})
            Me.trackedEvents.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.trackedEvents.Dock = System.Windows.Forms.DockStyle.Fill
            Me.trackedEvents.EnableDynamicLoading = False
            Me.trackedEvents.Location = New System.Drawing.Point(0, 0)
            Me.trackedEvents.Name = "trackedEvents"
            Me.trackedEvents.OptionsBehavior.AllowBoundCheckBoxesInVirtualMode = True
            Me.trackedEvents.OptionsBehavior.AllowRecursiveNodeChecking = True
            Me.trackedEvents.OptionsBehavior.Editable = False
            Me.trackedEvents.OptionsBehavior.[ReadOnly] = True
            Me.trackedEvents.OptionsFind.AlwaysVisible = True
            Me.trackedEvents.OptionsFind.FindMode = DevExpress.XtraTreeList.FindMode.Always
            Me.trackedEvents.OptionsFind.ShowClearButton = False
            Me.trackedEvents.OptionsFind.ShowFindButton = False
            Me.trackedEvents.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.trackedEvents.OptionsSelection.EnableAppearanceFocusedRow = False
            Me.trackedEvents.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check
            Me.trackedEvents.OptionsView.ShowColumns = False
            Me.trackedEvents.OptionsView.ShowHorzLines = False
            Me.trackedEvents.OptionsView.ShowIndicator = False
            Me.trackedEvents.OptionsView.ShowVertLines = False
            Me.trackedEvents.Size = New System.Drawing.Size(249, 441)
            Me.trackedEvents.TabIndex = 0
            AddHandler Me.trackedEvents.NodeCellStyle, New DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(AddressOf Me.OnTrackedEventsNodeCellStyle)
            AddHandler Me.trackedEvents.VirtualTreeGetChildNodes, New DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(AddressOf Me.OnTrackedEventsVirtualTreeGetChildNodes)
            AddHandler Me.trackedEvents.VirtualTreeGetCellValue, New DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(AddressOf Me.OnTrackedEventsVirtualTreeGetCellValue)
            AddHandler Me.trackedEvents.VirtualTreeSetCellValue, New DevExpress.XtraTreeList.VirtualTreeSetCellValueEventHandler(AddressOf Me.OnTrackedEventsVirtualTreeSetCellValue)
            AddHandler Me.trackedEvents.Click, New System.EventHandler(AddressOf Me.OnTrackedEventsClick)
            AddHandler Me.trackedEvents.MouseLeave, New System.EventHandler(AddressOf Me.OnTrackedEventsMouseLeave)
            AddHandler Me.trackedEvents.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnTrackedEventsMouseMove)
            ' 
            ' colTitle
            ' 
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            Me.colTitle.OptionsColumn.[ReadOnly] = True
            Me.colTitle.Visible = True
            Me.colTitle.VisibleIndex = 0
            ' 
            ' colIsParameter
            ' 
            Me.colIsParameter.FieldName = "IsParameter"
            Me.colIsParameter.Name = "colIsParameter"
            Me.colIsParameter.OptionsColumn.[ReadOnly] = True
            ' 
            ' colIsChecked
            ' 
            Me.colIsChecked.FieldName = "IsChecked"
            Me.colIsChecked.Name = "colIsChecked"
            ' 
            ' colParent
            ' 
            Me.colParent.Caption = "colParent"
            Me.colParent.FieldName = "Parent"
            Me.colParent.Name = "colParent"
            ' 
            ' diagramEventNodeBindingSource
            ' 
            Me.diagramEventNodeBindingSource.DataSource = GetType(DevExpress.XtraDiagram.Demos.DiagramEventNode)
            ' 
            ' EventsModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "EventsModule"
            Me.OptionsSidePanelWidth = 277
            Me.OptionsTabPanePages.Add(Me.eventsLogTab)
            Me.OptionsTabPanePages.Add(Me.trackEventsTab)
            Me.Size = New System.Drawing.Size(1094, 472)
            Me.containerControl.ResumeLayout(False)
            Me.containerControl.PerformLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.eventsLogTab.ResumeLayout(False)
            CType((Me.eventsLogBorder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.eventsLogBorder.ResumeLayout(False)
            Me.eventsLogPanel.ResumeLayout(False)
            Me.eventsLogPanel.PerformLayout()
            CType((Me.clearLogButtonPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.clearLogButtonPanel.ResumeLayout(False)
            Me.containerControl2.ResumeLayout(False)
            Me.trackEventsTab.ResumeLayout(False)
            CType((Me.trackedEvents), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.diagramEventNodeBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private eventsLogTab As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private trackEventsTab As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private eventsLog As DevExpress.XtraEditors.LabelControl

        Private clearLogButtonPanel As DevExpress.XtraEditors.PanelControl

        Private clearLogButton As DevExpress.XtraEditors.SimpleButton

        Private trackedEvents As DevExpress.XtraDiagram.Demos.EvensTreeList

        Private colTitle As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colIsParameter As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colIsChecked As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private diagramEventNodeBindingSource As System.Windows.Forms.BindingSource

        Private colParent As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private eventsLogPanel As DevExpress.XtraEditors.XtraScrollableControl

        Private eventsLogBorder As DevExpress.XtraEditors.PanelControl

        Private containerControl2 As System.Windows.Forms.ContainerControl
    End Class
End Namespace
