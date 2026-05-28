namespace DevExpress.XtraGrid.Demos {
    partial class LookUpInstantFeedbackUI {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpInstantFeedbackUI));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colHasAttachment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xpAsyncServerModeSource1 = new DevExpress.Xpo.XPInstantFeedbackSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pnlControl = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.searchLookUpEdit1 = new DevExpress.XtraGrid.Demos.SearchLookUpEditWithGlyph();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbShowSQLConnection = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.icbAnimation = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciWaitAnimationOptions = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbAnimation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWaitAnimationOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // colHasAttachment
            // 
            resources.ApplyResources(this.colHasAttachment, "colHasAttachment");
            this.colHasAttachment.FieldName = "HasAttachment";
            this.colHasAttachment.ImageOptions.ImageIndex = ((int)(resources.GetObject("colHasAttachment.ImageOptions.ImageIndex")));
            this.colHasAttachment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("colHasAttachment.ImageOptions.SvgImage")));
            this.colHasAttachment.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.colHasAttachment.Name = "colHasAttachment";
            // 
            // xpAsyncServerModeSource1
            // 
            this.xpAsyncServerModeSource1.ObjectType = typeof(DevExpress.XtraGrid.Demos.ServerSideGridTest);
            this.xpAsyncServerModeSource1.ResolveSession += new System.EventHandler<DevExpress.Xpo.ResolveSessionEventArgs>(this.xpAsyncServerModeSource1_ResolveSession);
            this.xpAsyncServerModeSource1.DismissSession += new System.EventHandler<DevExpress.Xpo.ResolveSessionEventArgs>(this.xpAsyncServerModeSource1_DismissSession);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.pnlControl);
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.sbShowSQLConnection);
            this.layoutControl1.Controls.Add(this.panelControl1);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // pnlControl
            // 
            this.pnlControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.pnlControl, "pnlControl");
            this.pnlControl.Name = "pnlControl";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.dataNavigator1);
            this.groupControl1.Controls.Add(this.searchLookUpEdit1);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            resources.ApplyResources(this.dataNavigator1, "dataNavigator1");
            this.dataNavigator1.Name = "dataNavigator1";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.AllowDrop = true;
            resources.ApplyResources(this.searchLookUpEdit1, "searchLookUpEdit1");
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("searchLookUpEdit1.Properties.Buttons"))))});
            this.searchLookUpEdit1.Properties.DataSource = this.xpAsyncServerModeSource1;
            this.searchLookUpEdit1.Properties.DisplayMember = "Subject";
            this.searchLookUpEdit1.Properties.PopupFormSize = new System.Drawing.Size(700, 0);
            this.searchLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.searchLookUpEdit1.Properties.ValueMember = "Oid";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colSubject,
            this.colFrom,
            this.colSent,
            this.colSize,
            this.colHasAttachment});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colHasAttachment;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.gridLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridLookUpEdit1View.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridLookUpEdit1View.GroupSummary"))), resources.GetString("gridLookUpEdit1View.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridLookUpEdit1View.GroupSummary2"))), resources.GetString("gridLookUpEdit1View.GroupSummary3"))});
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowFooter = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colOid
            // 
            resources.ApplyResources(this.colOid, "colOid");
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colOid.Summary"))))});
            // 
            // colSubject
            // 
            resources.ApplyResources(this.colSubject, "colSubject");
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colSubject.Summary"))), resources.GetString("colSubject.Summary1"), resources.GetString("colSubject.Summary2"))});
            // 
            // colFrom
            // 
            resources.ApplyResources(this.colFrom, "colFrom");
            this.colFrom.FieldName = "From";
            this.colFrom.Name = "colFrom";
            // 
            // colSent
            // 
            resources.ApplyResources(this.colSent, "colSent");
            this.colSent.FieldName = "Sent";
            this.colSent.Name = "colSent";
            // 
            // colSize
            // 
            resources.ApplyResources(this.colSize, "colSize");
            this.colSize.DisplayFormat.FormatString = "{0:n0} KB";
            this.colSize.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            // 
            // sbShowSQLConnection
            // 
            resources.ApplyResources(this.sbShowSQLConnection, "sbShowSQLConnection");
            this.sbShowSQLConnection.Name = "sbShowSQLConnection";
            this.sbShowSQLConnection.StyleController = this.layoutControl1;
            this.sbShowSQLConnection.Click += new System.EventHandler(this.sbShowSQLConnection_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.icbAnimation);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // icbAnimation
            // 
            resources.ApplyResources(this.icbAnimation, "icbAnimation");
            this.icbAnimation.Name = "icbAnimation";
            this.icbAnimation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("icbAnimation.Properties.Buttons"))))});
            this.icbAnimation.SelectedIndexChanged += new System.EventHandler(this.icbAnimation_SelectedIndexChanged);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sbShowSQLConnection;
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 436);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem5.Size = new System.Drawing.Size(119, 33);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciWaitAnimationOptions,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(935, 577);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciWaitAnimationOptions
            // 
            this.lciWaitAnimationOptions.Control = this.panelControl1;
            resources.ApplyResources(this.lciWaitAnimationOptions, "lciWaitAnimationOptions");
            this.lciWaitAnimationOptions.Location = new System.Drawing.Point(0, 0);
            this.lciWaitAnimationOptions.MaxSize = new System.Drawing.Size(0, 42);
            this.lciWaitAnimationOptions.MinSize = new System.Drawing.Size(100, 42);
            this.lciWaitAnimationOptions.Name = "lciWaitAnimationOptions";
            this.lciWaitAnimationOptions.Size = new System.Drawing.Size(342, 42);
            this.lciWaitAnimationOptions.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciWaitAnimationOptions.TextSize = new System.Drawing.Size(0, 0);
            this.lciWaitAnimationOptions.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            resources.ApplyResources(this.emptySpaceItem2, "emptySpaceItem2");
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 269);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(605, 308);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pnlControl;
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.Location = new System.Drawing.Point(605, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(330, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(330, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(330, 577);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            resources.ApplyResources(this.emptySpaceItem1, "emptySpaceItem1");
            this.emptySpaceItem1.Location = new System.Drawing.Point(342, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(263, 269);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            resources.ApplyResources(this.emptySpaceItem3, "emptySpaceItem3");
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 42);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(342, 10);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(342, 217);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(342, 217);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(342, 217);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // LookUpInstantFeedbackUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "LookUpInstantFeedbackUI";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbAnimation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWaitAnimationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sbShowSQLConnection;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Xpo.XPInstantFeedbackSource xpAsyncServerModeSource1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem lciWaitAnimationOptions;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbAnimation;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private SearchLookUpEditWithGlyph searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colSent;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colHasAttachment;
        private DevExpress.XtraEditors.PanelControl pnlControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}

