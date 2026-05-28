namespace DevExpress.XtraEditors.Demos {
    partial class ModuleToolTipController {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(_timerControl != null) {
                    _timerControl.Dispose();
                    _timerControl = null;
                }
                if(_clockLabelControl != null) {
                    _clockLabelControl.Dispose();
                    _clockLabelControl = null;
                }
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleToolTipController));

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.toolTipControllerContentProperties1 = new EditorsTutorials.Modules.ToolTipControllerContentProperties();
            this.pceToolTipLocation = new DevExpress.XtraEditors.PopupContainerEdit();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.toolTipLocationControl = new EditorsTutorials.Modules.ToolTipLocationControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceShowShadow = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowBeak = new DevExpress.XtraEditors.CheckEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.ceRounded = new DevExpress.XtraEditors.CheckEdit();
            this.seAutoPopDelay = new DevExpress.XtraEditors.SpinEdit();
            this.seRoundRadius = new DevExpress.XtraEditors.SpinEdit();
            this.seInitialDelay = new DevExpress.XtraEditors.SpinEdit();
            this.lbSample = new System.Windows.Forms.Label();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.propertyGrid1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.propertyGrid2 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.toolTipControllerContentProperties2 = new EditorsTutorials.Modules.ToolTipControllerContentProperties();
            this.lbSampleManual = new System.Windows.Forms.Label();
            this.lbStyleSample = new System.Windows.Forms.Label();
            this.icbType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.chAllowHTML = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.checkEditShowBeak = new DevExpress.XtraEditors.CheckEdit();
            this.flyoutLabel = new DevExpress.XtraEditors.LabelControl();
            this.flyoutToolTipController = new DevExpress.Utils.ToolTipController(this.components);
            this.radioGroupExamples = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup11 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup12 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup13 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup14 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.toolTipStyleController = new DevExpress.Utils.ToolTipController(this.components);
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.pceToolTipLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowShadow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowBeak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRounded.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAutoPopDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seRoundRadius.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seInitialDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chAllowHTML.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowBeak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupExamples.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.tabNavigationPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTipControllerContentProperties1
            // 
            this.toolTipControllerContentProperties1.Location = new System.Drawing.Point(24, 156);
            this.toolTipControllerContentProperties1.Name = "toolTipControllerContentProperties1";
            this.toolTipControllerContentProperties1.Size = new System.Drawing.Size(306, 216);
            this.toolTipControllerContentProperties1.TabIndex = 0;
            // 
            // pceToolTipLocation
            // 
            this.pceToolTipLocation.EditValue = "";
            this.pceToolTipLocation.Location = new System.Drawing.Point(570, 571);
            this.pceToolTipLocation.Name = "pceToolTipLocation";
            this.pceToolTipLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pceToolTipLocation.Properties.PopupControl = this.popupContainerControl1;
            this.pceToolTipLocation.Properties.ShowPopupCloseButton = false;
            this.pceToolTipLocation.Size = new System.Drawing.Size(542, 20);
            this.pceToolTipLocation.StyleController = this.layoutControl1;
            this.pceToolTipLocation.TabIndex = 16;
            this.pceToolTipLocation.QueryDisplayText += new DevExpress.XtraEditors.Controls.QueryDisplayTextEventHandler(this.pceToolTipLocation_QueryDisplayText);
            this.pceToolTipLocation.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.pceToolTipLocation_QueryPopUp);
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Controls.Add(this.toolTipLocationControl);
            this.popupContainerControl1.Location = new System.Drawing.Point(1280, 21);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(228, 156);
            this.popupContainerControl1.TabIndex = 5;
            // 
            // toolTipLocationControl
            // 
            this.toolTipLocationControl.Controller = this.toolTipController1;
            this.toolTipLocationControl.Location = new System.Drawing.Point(0, 0);
            this.toolTipLocationControl.Name = "toolTipLocationControl";
            this.toolTipLocationControl.Size = new System.Drawing.Size(152, 104);
            this.toolTipLocationControl.TabIndex = 0;
            this.toolTipLocationControl.ToolTipLocationChanged += new System.EventHandler(this.toolTipLocationControl_ToolTipLocationChanged);
            // 
            // toolTipController1
            // 
            this.toolTipController1.Rounded = true;
            this.toolTipController1.ShowBeak = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceShowShadow);
            this.layoutControl1.Controls.Add(this.ceShowBeak);
            this.layoutControl1.Controls.Add(this.label7);
            this.layoutControl1.Controls.Add(this.ceRounded);
            this.layoutControl1.Controls.Add(this.seAutoPopDelay);
            this.layoutControl1.Controls.Add(this.pceToolTipLocation);
            this.layoutControl1.Controls.Add(this.seRoundRadius);
            this.layoutControl1.Controls.Add(this.toolTipControllerContentProperties1);
            this.layoutControl1.Controls.Add(this.seInitialDelay);
            this.layoutControl1.Controls.Add(this.lbSample);
            this.layoutControl1.Controls.Add(this.xtraTabControl2);
            this.layoutControl1.Location = new System.Drawing.Point(42, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1136, 744);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceShowShadow
            // 
            this.ceShowShadow.EditValue = null;
            this.ceShowShadow.Location = new System.Drawing.Point(352, 665);
            this.ceShowShadow.Name = "ceShowShadow";
            this.ceShowShadow.Properties.Caption = "Show shadow";
            this.ceShowShadow.Size = new System.Drawing.Size(214, 20);
            this.ceShowShadow.StyleController = this.layoutControl1;
            this.ceShowShadow.TabIndex = 14;
            this.ceShowShadow.CheckedChanged += new System.EventHandler(this.ceShowShadow_CheckedChanged);
            // 
            // ceShowBeak
            // 
            this.ceShowBeak.EditValue = null;
            this.ceShowBeak.Location = new System.Drawing.Point(352, 571);
            this.ceShowBeak.Name = "ceShowBeak";
            this.ceShowBeak.Properties.Caption = "Show beak";
            this.ceShowBeak.Size = new System.Drawing.Size(214, 20);
            this.ceShowBeak.StyleController = this.layoutControl1;
            this.ceShowBeak.TabIndex = 13;
            this.ceShowBeak.CheckedChanged += new System.EventHandler(this.ceShowBeak_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(570, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.StyleController = this.layoutControl1;
            this.label7.TabIndex = 15;
            this.label7.Text = "ToolTip location:";
            // 
            // ceRounded
            // 
            this.ceRounded.EditValue = null;
            this.ceRounded.Location = new System.Drawing.Point(352, 475);
            this.ceRounded.Name = "ceRounded";
            this.ceRounded.Properties.Caption = "Rounded";
            this.ceRounded.Size = new System.Drawing.Size(214, 20);
            this.ceRounded.StyleController = this.layoutControl1;
            this.ceRounded.TabIndex = 12;
            this.ceRounded.CheckedChanged += new System.EventHandler(this.ceRounded_CheckedChanged);
            // 
            // seAutoPopDelay
            // 
            this.seAutoPopDelay.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seAutoPopDelay.Location = new System.Drawing.Point(110, 475);
            this.seAutoPopDelay.Name = "seAutoPopDelay";
            this.seAutoPopDelay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seAutoPopDelay.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seAutoPopDelay.Properties.IsFloatValue = false;
            this.seAutoPopDelay.Properties.Mask.EditMask = "N00";
            this.seAutoPopDelay.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.seAutoPopDelay.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seAutoPopDelay.Size = new System.Drawing.Size(238, 20);
            this.seAutoPopDelay.StyleController = this.layoutControl1;
            this.seAutoPopDelay.TabIndex = 9;
            this.seAutoPopDelay.EditValueChanged += new System.EventHandler(this.seAutoPopDelay_EditValueChanged);
            // 
            // seRoundRadius
            // 
            this.seRoundRadius.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seRoundRadius.Location = new System.Drawing.Point(110, 665);
            this.seRoundRadius.Name = "seRoundRadius";
            this.seRoundRadius.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seRoundRadius.Properties.IsFloatValue = false;
            this.seRoundRadius.Properties.Mask.EditMask = "N00";
            this.seRoundRadius.Properties.MaxValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.seRoundRadius.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seRoundRadius.Size = new System.Drawing.Size(238, 20);
            this.seRoundRadius.StyleController = this.layoutControl1;
            this.seRoundRadius.TabIndex = 11;
            this.seRoundRadius.EditValueChanged += new System.EventHandler(this.seRoundRadius_EditValueChanged);
            // 
            // seInitialDelay
            // 
            this.seInitialDelay.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seInitialDelay.Location = new System.Drawing.Point(110, 571);
            this.seInitialDelay.Name = "seInitialDelay";
            this.seInitialDelay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seInitialDelay.Properties.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.seInitialDelay.Properties.IsFloatValue = false;
            this.seInitialDelay.Properties.Mask.EditMask = "N00";
            this.seInitialDelay.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seInitialDelay.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seInitialDelay.Size = new System.Drawing.Size(238, 20);
            this.seInitialDelay.StyleController = this.layoutControl1;
            this.seInitialDelay.TabIndex = 10;
            this.seInitialDelay.EditValueChanged += new System.EventHandler(this.seInitialDelay_EditValueChanged);
            // 
            // lbSample
            // 
            this.lbSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSample.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbSample.Location = new System.Drawing.Point(448, 45);
            this.lbSample.Name = "lbSample";
            this.lbSample.Size = new System.Drawing.Size(240, 44);
            this.lbSample.TabIndex = 0;
            this.lbSample.Text = "Hover the mouse cursor over this box to automatically display a tooltip.";
            this.lbSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(374, 123);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl2.Size = new System.Drawing.Size(750, 261);
            this.xtraTabControl2.TabIndex = 4;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.propertyGrid1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.xtraTabPage2.Size = new System.Drawing.Size(748, 236);
            this.xtraTabPage2.Text = "Appearance";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(4, 4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            this.propertyGrid1.Size = new System.Drawing.Size(740, 228);
            this.propertyGrid1.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.propertyGrid2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.xtraTabPage3.Size = new System.Drawing.Size(748, 236);
            this.xtraTabPage3.Text = "AppearanceTitle";
            // 
            // propertyGrid2
            // 
            this.propertyGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid2.Location = new System.Drawing.Point(4, 4);
            this.propertyGrid2.Name = "propertyGrid2";
            this.propertyGrid2.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            this.propertyGrid2.Size = new System.Drawing.Size(740, 228);
            this.propertyGrid2.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1136, 744);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1116, 111);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.layoutControlGroup2.Text = "Sample";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lbSample;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(244, 48);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(244, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1092, 48);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.TrimClientAreaToControl = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.xtraTabControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(347, 111);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(320, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(769, 265);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 111);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(347, 265);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 15, 2, 2);
            this.layoutControlGroup3.Text = "Content";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.toolTipControllerContentProperties1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(310, 220);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(310, 220);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(310, 220);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem6});
            this.layoutControlGroup4.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 376);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 30D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 20D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 50D;
            this.layoutControlGroup4.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 34D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 33D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition3.Height = 33D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup4.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.layoutControlGroup4.Size = new System.Drawing.Size(1116, 348);
            this.layoutControlGroup4.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 20, 2);
            this.layoutControlGroup4.Text = "Options";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.pceToolTipLocation;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem4.Location = new System.Drawing.Point(546, 97);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(546, 94);
            this.layoutControlItem4.TextVisible = false;
            this.layoutControlItem4.TrimClientAreaToControl = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.label7;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem5.Location = new System.Drawing.Point(546, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(546, 97);
            this.layoutControlItem5.TextVisible = false;
            this.layoutControlItem5.TrimClientAreaToControl = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.seInitialDelay;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 97);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem7.Size = new System.Drawing.Size(328, 94);
            this.layoutControlItem7.Text = "Initial delay:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(74, 13);
            this.layoutControlItem7.TrimClientAreaToControl = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.seRoundRadius;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 191);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem8.Size = new System.Drawing.Size(328, 94);
            this.layoutControlItem8.Text = "Round radius:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(74, 13);
            this.layoutControlItem8.TrimClientAreaToControl = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.ceRounded;
            this.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem9.Location = new System.Drawing.Point(328, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem9.Size = new System.Drawing.Size(218, 97);
            this.layoutControlItem9.TextVisible = false;
            this.layoutControlItem9.TrimClientAreaToControl = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.ceShowBeak;
            this.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem10.Location = new System.Drawing.Point(328, 97);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem10.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem10.Size = new System.Drawing.Size(218, 94);
            this.layoutControlItem10.TextVisible = false;
            this.layoutControlItem10.TrimClientAreaToControl = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.ceShowShadow;
            this.layoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem11.Location = new System.Drawing.Point(328, 191);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem11.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem11.Size = new System.Drawing.Size(218, 94);
            this.layoutControlItem11.TextVisible = false;
            this.layoutControlItem11.TrimClientAreaToControl = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.seAutoPopDelay;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(328, 97);
            this.layoutControlItem6.Text = "AutoPop delay:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(74, 13);
            this.layoutControlItem6.TrimClientAreaToControl = false;
            // 
            // toolTipControllerContentProperties2
            // 
            this.toolTipControllerContentProperties2.Location = new System.Drawing.Point(24, 156);
            this.toolTipControllerContentProperties2.Name = "toolTipControllerContentProperties2";
            this.toolTipControllerContentProperties2.Size = new System.Drawing.Size(306, 216);
            this.toolTipControllerContentProperties2.TabIndex = 0;
            // 
            // lbSampleManual
            // 
            this.lbSampleManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSampleManual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbSampleManual.Location = new System.Drawing.Point(143, 45);
            this.lbSampleManual.Name = "lbSampleManual";
            this.lbSampleManual.Size = new System.Drawing.Size(240, 44);
            this.lbSampleManual.TabIndex = 0;
            this.lbSampleManual.Text = "Click this box to manually activate a tooltip.";
            this.lbSampleManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSampleManual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbSampleManual_MouseDown);
            // 
            // lbStyleSample
            // 
            this.lbStyleSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStyleSample.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbStyleSample.Location = new System.Drawing.Point(169, 45);
            this.lbStyleSample.Name = "lbStyleSample";
            this.lbStyleSample.Size = new System.Drawing.Size(240, 44);
            this.lbStyleSample.TabIndex = 0;
            this.lbStyleSample.Text = "Hover the mouse cursor over this box to automatically display a tooltip.";
            this.lbStyleSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icbType
            // 
            this.icbType.Location = new System.Drawing.Point(97, 157);
            this.icbType.Name = "icbType";
            this.icbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbType.Size = new System.Drawing.Size(457, 20);
            this.icbType.StyleController = this.layoutControl2;
            this.icbType.TabIndex = 14;
            this.icbType.SelectedIndexChanged += new System.EventHandler(this.icbType_SelectedIndexChanged);
            // 
            // layoutControl2
            // 
            this.layoutControl2.AllowCustomization = false;
            this.layoutControl2.Controls.Add(this.chAllowHTML);
            this.layoutControl2.Controls.Add(this.icbType);
            this.layoutControl2.Controls.Add(this.lbStyleSample);
            this.layoutControl2.Location = new System.Drawing.Point(52, 46);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl2.Root = this.layoutControlGroup5;
            this.layoutControl2.Size = new System.Drawing.Size(578, 534);
            this.layoutControl2.TabIndex = 5;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // chAllowHTML
            // 
            this.chAllowHTML.EditValue = true;
            this.chAllowHTML.Location = new System.Drawing.Point(24, 185);
            this.chAllowHTML.Name = "chAllowHTML";
            this.chAllowHTML.Properties.Caption = "Allow HTML text";
            this.chAllowHTML.Size = new System.Drawing.Size(530, 20);
            this.chAllowHTML.StyleController = this.layoutControl2;
            this.chAllowHTML.TabIndex = 13;
            this.chAllowHTML.CheckedChanged += new System.EventHandler(this.chAllowHTML_CheckedChanged);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup5.GroupBordersVisible = false;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6,
            this.layoutControlGroup7});
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(578, 534);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem13,
            this.layoutControlItem14});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 112);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(558, 402);
            this.layoutControlGroup6.Text = "Properties";
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.icbType;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            this.layoutControlItem13.Size = new System.Drawing.Size(534, 26);
            this.layoutControlItem13.Text = "Tooltip type:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.chAllowHTML;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem14.Size = new System.Drawing.Size(534, 331);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem12,
            this.emptySpaceItem1});
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup7.Name = "layoutControlGroup7";
            this.layoutControlGroup7.Size = new System.Drawing.Size(558, 112);
            this.layoutControlGroup7.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.layoutControlGroup7.Text = "Sample";
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.lbStyleSample;
            this.layoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(244, 48);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(244, 48);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(534, 48);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextVisible = false;
            this.layoutControlItem12.TrimClientAreaToControl = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(350, 1);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(534, 1);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // layoutControl4
            // 
            this.layoutControl4.AllowCustomization = false;
            this.layoutControl4.Controls.Add(this.checkEditShowBeak);
            this.layoutControl4.Controls.Add(this.flyoutLabel);
            this.layoutControl4.Controls.Add(this.radioGroupExamples);
            this.layoutControl4.Location = new System.Drawing.Point(52, 45);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl4.Root = this.layoutControlGroup11;
            this.layoutControl4.Size = new System.Drawing.Size(578, 534);
            this.layoutControl4.TabIndex = 6;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // checkEditShowBeak
            // 
            this.checkEditShowBeak.EditValue = true;
            this.checkEditShowBeak.Location = new System.Drawing.Point(24, 159);
            this.checkEditShowBeak.Name = "checkEditShowBeak";
            this.checkEditShowBeak.Properties.Caption = "Show beak";
            this.checkEditShowBeak.Size = new System.Drawing.Size(530, 20);
            this.checkEditShowBeak.StyleController = this.layoutControl4;
            this.checkEditShowBeak.TabIndex = 13;
            this.checkEditShowBeak.CheckedChanged += new System.EventHandler(this.OnShowBeakChanged);
            // 
            // flyoutLabel
            // 
            this.flyoutLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.flyoutLabel.Appearance.Options.UseFont = true;
            this.flyoutLabel.Appearance.Options.UseTextOptions = true;
            this.flyoutLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.flyoutLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.flyoutLabel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.flyoutLabel.Location = new System.Drawing.Point(169, 45);
            this.flyoutLabel.Name = "flyoutLabel";
            this.flyoutLabel.Size = new System.Drawing.Size(240, 44);
            this.flyoutLabel.StyleController = this.layoutControl4;
            this.flyoutLabel.TabIndex = 0;
            this.flyoutLabel.Text = "Hover the mouse cursor over this box to automatically display a tooltip.";
            this.flyoutLabel.ToolTipController = this.flyoutToolTipController;
            // 
            // flyoutToolTipController
            // 
            this.flyoutToolTipController.CloseOnClick = DevExpress.Utils.DefaultBoolean.False;
            this.flyoutToolTipController.KeepWhileHovered = true;
            this.flyoutToolTipController.ShowBeak = true;
            this.flyoutToolTipController.ToolTipType = DevExpress.Utils.ToolTipType.Flyout;
            this.flyoutToolTipController.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.OnGetActiveObjectInfo);
            // 
            // radioGroupExamples
            // 
            this.radioGroupExamples.EditValue = 0;
            this.radioGroupExamples.Location = new System.Drawing.Point(24, 228);
            this.radioGroupExamples.Name = "radioGroupExamples";
            this.radioGroupExamples.Properties.Columns = 1;
            this.radioGroupExamples.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Dynamic contents"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Interactive contents")});
            this.radioGroupExamples.Size = new System.Drawing.Size(530, 282);
            this.radioGroupExamples.StyleController = this.layoutControl4;
            this.radioGroupExamples.TabIndex = 14;
            // 
            // layoutControlGroup11
            // 
            this.layoutControlGroup11.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup11.GroupBordersVisible = false;
            this.layoutControlGroup11.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup12,
            this.layoutControlGroup13,
            this.layoutControlGroup14});
            this.layoutControlGroup11.Name = "layoutControlGroup5";
            this.layoutControlGroup11.Size = new System.Drawing.Size(578, 534);
            this.layoutControlGroup11.TextVisible = false;
            // 
            // layoutControlGroup12
            // 
            this.layoutControlGroup12.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem18});
            this.layoutControlGroup12.Location = new System.Drawing.Point(0, 112);
            this.layoutControlGroup12.Name = "layoutControlGroup6";
            this.layoutControlGroup12.Size = new System.Drawing.Size(558, 71);
            this.layoutControlGroup12.Text = "Properties";
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.checkEditShowBeak;
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2);
            this.layoutControlItem18.Size = new System.Drawing.Size(534, 26);
            this.layoutControlItem18.TextVisible = false;
            // 
            // layoutControlGroup13
            // 
            this.layoutControlGroup13.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem19,
            this.emptySpaceItem2});
            this.layoutControlGroup13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup13.Name = "layoutControlGroup7";
            this.layoutControlGroup13.Size = new System.Drawing.Size(558, 112);
            this.layoutControlGroup13.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.layoutControlGroup13.Text = "Sample";
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.flyoutLabel;
            this.layoutControlItem19.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem19.MaxSize = new System.Drawing.Size(244, 48);
            this.layoutControlItem19.MinSize = new System.Drawing.Size(244, 48);
            this.layoutControlItem19.Name = "layoutControlItem12";
            this.layoutControlItem19.Size = new System.Drawing.Size(534, 48);
            this.layoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem19.TextVisible = false;
            this.layoutControlItem19.TrimClientAreaToControl = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 1);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(350, 1);
            this.emptySpaceItem2.Name = "emptySpaceItem1";
            this.emptySpaceItem2.Size = new System.Drawing.Size(534, 1);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // layoutControlGroup14
            // 
            this.layoutControlGroup14.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem17});
            this.layoutControlGroup14.Location = new System.Drawing.Point(0, 183);
            this.layoutControlGroup14.Name = "layoutControlGroup14";
            this.layoutControlGroup14.Size = new System.Drawing.Size(558, 331);
            this.layoutControlGroup14.Text = "Examples";
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.radioGroupExamples;
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(534, 286);
            this.layoutControlItem17.TextVisible = false;
            // 
            // layoutControl3
            // 
            this.layoutControl3.AllowCustomization = false;
            this.layoutControl3.Controls.Add(this.toolTipControllerContentProperties2);
            this.layoutControl3.Controls.Add(this.lbSampleManual);
            this.layoutControl3.Location = new System.Drawing.Point(25, 12);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl3.Root = this.layoutControlGroup8;
            this.layoutControl3.Size = new System.Drawing.Size(527, 599);
            this.layoutControl3.TabIndex = 3;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup8.GroupBordersVisible = false;
            this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup9,
            this.layoutControlGroup10});
            this.layoutControlGroup8.Name = "layoutControlGroup8";
            this.layoutControlGroup8.Size = new System.Drawing.Size(527, 599);
            this.layoutControlGroup8.TextVisible = false;
            // 
            // layoutControlGroup9
            // 
            this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem15});
            this.layoutControlGroup9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup9.Name = "layoutControlGroup9";
            this.layoutControlGroup9.Size = new System.Drawing.Size(507, 111);
            this.layoutControlGroup9.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20);
            this.layoutControlGroup9.Text = "Sample";
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.lbSampleManual;
            this.layoutControlItem15.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem15.MaxSize = new System.Drawing.Size(244, 48);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(244, 48);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(483, 48);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.TextVisible = false;
            this.layoutControlItem15.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup10
            // 
            this.layoutControlGroup10.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem16});
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 111);
            this.layoutControlGroup10.Name = "layoutControlGroup10";
            this.layoutControlGroup10.Size = new System.Drawing.Size(507, 468);
            this.layoutControlGroup10.Text = "Content";
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.toolTipControllerContentProperties2;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem16.MaxSize = new System.Drawing.Size(310, 220);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(310, 220);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(483, 423);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.TextVisible = false;
            // 
            // toolTipStyleController
            // 
            this.toolTipStyleController.AllowHtmlText = true;
            this.toolTipStyleController.AutoPopDelay = 8000;
            this.toolTipStyleController.Rounded = true;
            this.toolTipStyleController.ShowBeak = true;
            this.toolTipStyleController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("task", "image://svgimages/outlook inspired/task.svg");
            this.svgImageCollection1.Add("shipmentawaiting", "image://svgimages/outlook inspired/shipmentawaiting.svg");
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4});
            this.tabPane1.RegularSize = new System.Drawing.Size(875, 599);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(875, 599);
            this.tabPane1.TabIndex = 6;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Flyout tooltip";
            this.tabNavigationPage1.Controls.Add(this.layoutControl4);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(875, 566);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Auto-popup tooltip";
            this.tabNavigationPage2.Controls.Add(this.layoutControl1);
            this.tabNavigationPage2.Controls.Add(this.popupContainerControl1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(829, 554);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "ShowHint method";
            this.tabNavigationPage3.Controls.Add(this.layoutControl3);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(829, 554);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Tooltip Types and Styles";
            this.tabNavigationPage4.Controls.Add(this.layoutControl2);
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(829, 554);
            // 
            // ModuleToolTipController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "ModuleToolTipController";
            this.Size = new System.Drawing.Size(875, 599);
            this.Load += new System.EventHandler(this.ModuleToolTipController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pceToolTipLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceShowShadow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowBeak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRounded.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAutoPopDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seRoundRadius.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seInitialDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chAllowHTML.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowBeak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupExamples.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.Label lbSample;
        private DevExpress.XtraEditors.SpinEdit seAutoPopDelay;
        private DevExpress.XtraEditors.SpinEdit seInitialDelay;
        private DevExpress.XtraEditors.SpinEdit seRoundRadius;
        private DevExpress.XtraEditors.CheckEdit ceRounded;
        private DevExpress.XtraEditors.CheckEdit ceShowBeak;
        private DevExpress.XtraEditors.CheckEdit ceShowShadow;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.PopupContainerEdit pceToolTipLocation;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private EditorsTutorials.Modules.ToolTipLocationControl toolTipLocationControl;
        private XtraVerticalGrid.PropertyGridControl propertyGrid1;
        private XtraVerticalGrid.PropertyGridControl propertyGrid2;
        private EditorsTutorials.Modules.ToolTipControllerContentProperties toolTipControllerContentProperties1;
        private System.Windows.Forms.Label lbSampleManual;
        private EditorsTutorials.Modules.ToolTipControllerContentProperties toolTipControllerContentProperties2;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbType;
        private DevExpress.XtraEditors.CheckEdit chAllowHTML;
        private System.Windows.Forms.Label lbStyleSample;
        private DevExpress.Utils.ToolTipController toolTipStyleController;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraLayout.LayoutControlItem layoutControlItem10;
        private XtraLayout.LayoutControlItem layoutControlItem11;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControl layoutControl2;
        private XtraLayout.LayoutControlGroup layoutControlGroup5;
        private XtraLayout.LayoutControlGroup layoutControlGroup6;
        private XtraLayout.LayoutControlItem layoutControlItem13;
        private XtraLayout.LayoutControlItem layoutControlItem14;
        private XtraLayout.LayoutControlGroup layoutControlGroup7;
        private XtraLayout.LayoutControlItem layoutControlItem12;
        private XtraLayout.LayoutControl layoutControl3;
        private XtraLayout.LayoutControlGroup layoutControlGroup8;
        private XtraLayout.LayoutControlGroup layoutControlGroup9;
        private XtraLayout.LayoutControlItem layoutControlItem15;
        private XtraLayout.LayoutControlGroup layoutControlGroup10;
        private XtraLayout.LayoutControlItem layoutControlItem16;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraLayout.LayoutControl layoutControl4;
        private CheckEdit checkEditShowBeak;
        private LabelControl flyoutLabel;
        private XtraLayout.LayoutControlGroup layoutControlGroup11;
        private XtraLayout.LayoutControlGroup layoutControlGroup12;
        private XtraLayout.LayoutControlGroup layoutControlGroup13;
        private XtraLayout.LayoutControlItem layoutControlItem19;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private RadioGroup radioGroupExamples;
        private XtraLayout.LayoutControlItem layoutControlItem18;
        private XtraLayout.LayoutControlGroup layoutControlGroup14;
        private XtraLayout.LayoutControlItem layoutControlItem17;
        private Utils.ToolTipController flyoutToolTipController;
        private Utils.Behaviors.BehaviorManager behaviorManager1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
    }
}
