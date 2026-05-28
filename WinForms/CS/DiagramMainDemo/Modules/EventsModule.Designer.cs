namespace DevExpress.XtraDiagram.Demos {
    partial class EventsModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.eventsLogTab = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.eventsLogBorder = new DevExpress.XtraEditors.PanelControl();
            this.eventsLogPanel = new DevExpress.XtraEditors.XtraScrollableControl();
            this.eventsLog = new DevExpress.XtraEditors.LabelControl();
            this.clearLogButtonPanel = new DevExpress.XtraEditors.PanelControl();
            this.containerControl2 = new System.Windows.Forms.ContainerControl();
            this.clearLogButton = new DevExpress.XtraEditors.SimpleButton();
            this.trackEventsTab = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.trackedEvents = new DevExpress.XtraDiagram.Demos.EvensTreeList();
            this.colTitle = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsParameter = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsChecked = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.diagramEventNodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            this.eventsLogTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsLogBorder)).BeginInit();
            this.eventsLogBorder.SuspendLayout();
            this.eventsLogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearLogButtonPanel)).BeginInit();
            this.clearLogButtonPanel.SuspendLayout();
            this.containerControl2.SuspendLayout();
            this.trackEventsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackedEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramEventNodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // containerControl
            // 
            this.containerControl.Size = new System.Drawing.Size(1094, 472);
            this.containerControl.Controls.SetChildIndex(this.diagramControl, 0);
            // 
            // diagramControl
            // 
            this.diagramControl.Location = new System.Drawing.Point(62, 150);
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[0]);
            this.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed;
            this.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Compact;
            this.diagramControl.Size = new System.Drawing.Size(1032, 295);
            // 
            // eventsLogTab
            // 
            this.eventsLogTab.Caption = "Events Log";
            this.eventsLogTab.Controls.Add(this.eventsLogBorder);
            this.eventsLogTab.Controls.Add(this.clearLogButtonPanel);
            this.eventsLogTab.Name = "eventsLogTab";
            this.eventsLogTab.Padding = new System.Windows.Forms.Padding(12);
            this.eventsLogTab.Size = new System.Drawing.Size(249, 441);
            // 
            // eventsLogBorder
            // 
            this.eventsLogBorder.Controls.Add(this.eventsLogPanel);
            this.eventsLogBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsLogBorder.Location = new System.Drawing.Point(12, 12);
            this.eventsLogBorder.Name = "eventsLogBorder";
            this.eventsLogBorder.Size = new System.Drawing.Size(225, 382);
            this.eventsLogBorder.TabIndex = 1;
            // 
            // eventsLogPanel
            // 
            this.eventsLogPanel.Controls.Add(this.eventsLog);
            this.eventsLogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsLogPanel.Location = new System.Drawing.Point(2, 2);
            this.eventsLogPanel.Name = "eventsLogPanel";
            this.eventsLogPanel.Size = new System.Drawing.Size(221, 378);
            this.eventsLogPanel.TabIndex = 1;
            // 
            // eventsLog
            // 
            this.eventsLog.AllowHtmlString = true;
            this.eventsLog.Appearance.Options.UseTextOptions = true;
            this.eventsLog.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.eventsLog.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.eventsLog.Location = new System.Drawing.Point(0, 0);
            this.eventsLog.Name = "eventsLog";
            this.eventsLog.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.eventsLog.Size = new System.Drawing.Size(6, 0);
            this.eventsLog.TabIndex = 0;
            this.eventsLog.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.OnEventsLogHyperlinkClick);
            this.eventsLog.MouseLeave += new System.EventHandler(this.OnEventsLogMouseLeave);
            this.eventsLog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnEventsLogMouseMove);
            // 
            // clearLogButtonPanel
            // 
            this.clearLogButtonPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clearLogButtonPanel.Controls.Add(this.containerControl2);
            this.clearLogButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clearLogButtonPanel.Location = new System.Drawing.Point(12, 394);
            this.clearLogButtonPanel.Name = "clearLogButtonPanel";
            this.clearLogButtonPanel.Size = new System.Drawing.Size(225, 35);
            this.clearLogButtonPanel.TabIndex = 1;
            // 
            // containerControl2
            // 
            this.containerControl2.Controls.Add(this.clearLogButton);
            this.containerControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.containerControl2.Location = new System.Drawing.Point(0, 0);
            this.containerControl2.Name = "containerControl2";
            this.containerControl2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.containerControl2.Size = new System.Drawing.Size(225, 32);
            this.containerControl2.TabIndex = 0;
            // 
            // clearLogButton
            // 
            this.clearLogButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearLogButton.Location = new System.Drawing.Point(0, 10);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(225, 22);
            this.clearLogButton.TabIndex = 0;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.Click += new System.EventHandler(this.OnClearLogButtonClick);
            // 
            // trackEventsTab
            // 
            this.trackEventsTab.Caption = "Track Events";
            this.trackEventsTab.Controls.Add(this.trackedEvents);
            this.trackEventsTab.Name = "trackEventsTab";
            this.trackEventsTab.Size = new System.Drawing.Size(249, 441);
            // 
            // trackedEvents
            // 
            this.trackedEvents.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.trackedEvents.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTitle,
            this.colIsParameter,
            this.colIsChecked,
            this.colParent});
            this.trackedEvents.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackedEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackedEvents.EnableDynamicLoading = false;
            this.trackedEvents.Location = new System.Drawing.Point(0, 0);
            this.trackedEvents.Name = "trackedEvents";
            this.trackedEvents.OptionsBehavior.AllowBoundCheckBoxesInVirtualMode = true;
            this.trackedEvents.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.trackedEvents.OptionsBehavior.Editable = false;
            this.trackedEvents.OptionsBehavior.ReadOnly = true;
            this.trackedEvents.OptionsFind.AlwaysVisible = true;
            this.trackedEvents.OptionsFind.FindMode = DevExpress.XtraTreeList.FindMode.Always;
            this.trackedEvents.OptionsFind.ShowClearButton = false;
            this.trackedEvents.OptionsFind.ShowFindButton = false;
            this.trackedEvents.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.trackedEvents.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.trackedEvents.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check;
            this.trackedEvents.OptionsView.ShowColumns = false;
            this.trackedEvents.OptionsView.ShowHorzLines = false;
            this.trackedEvents.OptionsView.ShowIndicator = false;
            this.trackedEvents.OptionsView.ShowVertLines = false;
            this.trackedEvents.Size = new System.Drawing.Size(249, 441);
            this.trackedEvents.TabIndex = 0;
            this.trackedEvents.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.OnTrackedEventsNodeCellStyle);
            this.trackedEvents.VirtualTreeGetChildNodes += new DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(this.OnTrackedEventsVirtualTreeGetChildNodes);
            this.trackedEvents.VirtualTreeGetCellValue += new DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(this.OnTrackedEventsVirtualTreeGetCellValue);
            this.trackedEvents.VirtualTreeSetCellValue += new DevExpress.XtraTreeList.VirtualTreeSetCellValueEventHandler(this.OnTrackedEventsVirtualTreeSetCellValue);
            this.trackedEvents.Click += new System.EventHandler(this.OnTrackedEventsClick);
            this.trackedEvents.MouseLeave += new System.EventHandler(this.OnTrackedEventsMouseLeave);
            this.trackedEvents.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnTrackedEventsMouseMove);
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsColumn.ReadOnly = true;
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            // 
            // colIsParameter
            // 
            this.colIsParameter.FieldName = "IsParameter";
            this.colIsParameter.Name = "colIsParameter";
            this.colIsParameter.OptionsColumn.ReadOnly = true;
            // 
            // colIsChecked
            // 
            this.colIsChecked.FieldName = "IsChecked";
            this.colIsChecked.Name = "colIsChecked";
            // 
            // colParent
            // 
            this.colParent.Caption = "colParent";
            this.colParent.FieldName = "Parent";
            this.colParent.Name = "colParent";
            // 
            // diagramEventNodeBindingSource
            // 
            this.diagramEventNodeBindingSource.DataSource = typeof(DevExpress.XtraDiagram.Demos.DiagramEventNode);
            // 
            // EventsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "EventsModule";
            this.OptionsSidePanelWidth = 277;
            this.OptionsTabPanePages.Add(this.eventsLogTab);
            this.OptionsTabPanePages.Add(this.trackEventsTab);
            this.Size = new System.Drawing.Size(1094, 472);
            this.containerControl.ResumeLayout(false);
            this.containerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            this.eventsLogTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventsLogBorder)).EndInit();
            this.eventsLogBorder.ResumeLayout(false);
            this.eventsLogPanel.ResumeLayout(false);
            this.eventsLogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearLogButtonPanel)).EndInit();
            this.clearLogButtonPanel.ResumeLayout(false);
            this.containerControl2.ResumeLayout(false);
            this.trackEventsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackedEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramEventNodeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Navigation.TabNavigationPage eventsLogTab;
        private XtraBars.Navigation.TabNavigationPage trackEventsTab;
        private XtraEditors.LabelControl eventsLog;
        private XtraEditors.PanelControl clearLogButtonPanel;
        private XtraEditors.SimpleButton clearLogButton;
        private EvensTreeList trackedEvents;
        private XtraTreeList.Columns.TreeListColumn colTitle;
        private XtraTreeList.Columns.TreeListColumn colIsParameter;
        private XtraTreeList.Columns.TreeListColumn colIsChecked;
        private System.Windows.Forms.BindingSource diagramEventNodeBindingSource;
        private XtraTreeList.Columns.TreeListColumn colParent;
        private XtraEditors.XtraScrollableControl eventsLogPanel;
        private XtraEditors.PanelControl eventsLogBorder;
        private System.Windows.Forms.ContainerControl containerControl2;
    }
}
