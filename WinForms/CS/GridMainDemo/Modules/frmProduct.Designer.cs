namespace DevExpress.XtraGrid.Demos {
    partial class frmProduct {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceDiscontinued = new DevExpress.XtraEditors.CheckEdit();
            this.teQuantityPerUnit = new DevExpress.XtraEditors.TextEdit();
            this.seUnitPrice = new DevExpress.XtraEditors.SpinEdit();
            this.icbCategory = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.teProductName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciOK = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUnitPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciQuantityPerUnit = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDiscontinued = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceDiscontinued.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQuantityPerUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuantityPerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDiscontinued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ceDiscontinued);
            this.layoutControl1.Controls.Add(this.teQuantityPerUnit);
            this.layoutControl1.Controls.Add(this.seUnitPrice);
            this.layoutControl1.Controls.Add(this.icbCategory);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.teProductName);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // ceDiscontinued
            // 
            this.ceDiscontinued.AllowDrop = true;
            resources.ApplyResources(this.ceDiscontinued, "ceDiscontinued");
            this.ceDiscontinued.Name = "ceDiscontinued";
            this.ceDiscontinued.Properties.Caption = resources.GetString("ceDiscontinued.Properties.Caption");
            this.ceDiscontinued.StyleController = this.layoutControl1;
            // 
            // teQuantityPerUnit
            // 
            resources.ApplyResources(this.teQuantityPerUnit, "teQuantityPerUnit");
            this.teQuantityPerUnit.Name = "teQuantityPerUnit";
            this.teQuantityPerUnit.StyleController = this.layoutControl1;
            // 
            // seUnitPrice
            // 
            resources.ApplyResources(this.seUnitPrice, "seUnitPrice");
            this.seUnitPrice.Name = "seUnitPrice";
            this.seUnitPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seUnitPrice.Properties.Mask.EditMask = resources.GetString("seUnitPrice.Properties.Mask.EditMask");
            this.seUnitPrice.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("seUnitPrice.Properties.Mask.UseMaskAsDisplayFormat")));
            this.seUnitPrice.StyleController = this.layoutControl1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Please enter an amount greater than 0";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            conditionValidationRule3.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dxValidationProvider1.SetValidationRule(this.seUnitPrice, conditionValidationRule3);
            // 
            // icbCategory
            // 
            resources.ApplyResources(this.icbCategory, "icbCategory");
            this.icbCategory.Name = "icbCategory";
            this.icbCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.icbCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("icbCategory.Properties.Buttons"))))});
            this.icbCategory.Properties.DropDownRows = 10;
            this.icbCategory.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items"), ((object)(resources.GetObject("icbCategory.Properties.Items1"))), ((int)(resources.GetObject("icbCategory.Properties.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items3"), ((object)(resources.GetObject("icbCategory.Properties.Items4"))), ((int)(resources.GetObject("icbCategory.Properties.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items6"), ((object)(resources.GetObject("icbCategory.Properties.Items7"))), ((int)(resources.GetObject("icbCategory.Properties.Items8")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items9"), ((object)(resources.GetObject("icbCategory.Properties.Items10"))), ((int)(resources.GetObject("icbCategory.Properties.Items11")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items12"), ((object)(resources.GetObject("icbCategory.Properties.Items13"))), ((int)(resources.GetObject("icbCategory.Properties.Items14")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items15"), ((object)(resources.GetObject("icbCategory.Properties.Items16"))), ((int)(resources.GetObject("icbCategory.Properties.Items17")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items18"), ((object)(resources.GetObject("icbCategory.Properties.Items19"))), ((int)(resources.GetObject("icbCategory.Properties.Items20")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbCategory.Properties.Items21"), ((object)(resources.GetObject("icbCategory.Properties.Items22"))), ((int)(resources.GetObject("icbCategory.Properties.Items23"))))});
            this.icbCategory.Properties.SmallImages = this.svgImageCollection1;
            this.icbCategory.StyleController = this.layoutControl1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.StyleController = this.layoutControl1;
            // 
            // teProductName
            // 
            resources.ApplyResources(this.teProductName, "teProductName");
            this.teProductName.Name = "teProductName";
            this.teProductName.StyleController = this.layoutControl1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value cannot be empty";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.teProductName, conditionValidationRule1);
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.StyleController = this.layoutControl1;
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciProductName,
            this.emptySpaceItem1,
            this.lciOK,
            this.lciCancel,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.lciCategory,
            this.lciUnitPrice,
            this.lciQuantityPerUnit,
            this.lciDiscontinued});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(297, 192);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciProductName
            // 
            this.lciProductName.Control = this.teProductName;
            resources.ApplyResources(this.lciProductName, "lciProductName");
            this.lciProductName.Location = new System.Drawing.Point(0, 0);
            this.lciProductName.Name = "lciProductName";
            this.lciProductName.Size = new System.Drawing.Size(297, 24);
            this.lciProductName.TextSize = new System.Drawing.Size(90, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            resources.ApplyResources(this.emptySpaceItem1, "emptySpaceItem1");
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(297, 46);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciOK
            // 
            this.lciOK.Control = this.simpleButton1;
            resources.ApplyResources(this.lciOK, "lciOK");
            this.lciOK.Location = new System.Drawing.Point(111, 166);
            this.lciOK.MaxSize = new System.Drawing.Size(88, 26);
            this.lciOK.MinSize = new System.Drawing.Size(88, 26);
            this.lciOK.Name = "lciOK";
            this.lciOK.Size = new System.Drawing.Size(88, 26);
            this.lciOK.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciOK.TextSize = new System.Drawing.Size(0, 0);
            this.lciOK.TextVisible = false;
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.simpleButton2;
            resources.ApplyResources(this.lciCancel, "lciCancel");
            this.lciCancel.Location = new System.Drawing.Point(205, 166);
            this.lciCancel.MaxSize = new System.Drawing.Size(92, 26);
            this.lciCancel.MinSize = new System.Drawing.Size(92, 26);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.Size = new System.Drawing.Size(92, 26);
            this.lciCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            resources.ApplyResources(this.emptySpaceItem2, "emptySpaceItem2");
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 166);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(111, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            resources.ApplyResources(this.emptySpaceItem3, "emptySpaceItem3");
            this.emptySpaceItem3.Location = new System.Drawing.Point(199, 166);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(6, 0);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(6, 10);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(6, 26);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciCategory
            // 
            this.lciCategory.Control = this.icbCategory;
            resources.ApplyResources(this.lciCategory, "lciCategory");
            this.lciCategory.Location = new System.Drawing.Point(0, 24);
            this.lciCategory.Name = "lciCategory";
            this.lciCategory.Size = new System.Drawing.Size(297, 24);
            this.lciCategory.TextSize = new System.Drawing.Size(90, 13);
            // 
            // lciUnitPrice
            // 
            this.lciUnitPrice.Control = this.seUnitPrice;
            resources.ApplyResources(this.lciUnitPrice, "lciUnitPrice");
            this.lciUnitPrice.Location = new System.Drawing.Point(0, 48);
            this.lciUnitPrice.Name = "lciUnitPrice";
            this.lciUnitPrice.Size = new System.Drawing.Size(297, 24);
            this.lciUnitPrice.TextSize = new System.Drawing.Size(90, 13);
            // 
            // lciQuantityPerUnit
            // 
            this.lciQuantityPerUnit.Control = this.teQuantityPerUnit;
            resources.ApplyResources(this.lciQuantityPerUnit, "lciQuantityPerUnit");
            this.lciQuantityPerUnit.Location = new System.Drawing.Point(0, 72);
            this.lciQuantityPerUnit.Name = "lciQuantityPerUnit";
            this.lciQuantityPerUnit.Size = new System.Drawing.Size(297, 24);
            this.lciQuantityPerUnit.TextSize = new System.Drawing.Size(90, 13);
            // 
            // lciDiscontinued
            // 
            this.lciDiscontinued.Control = this.ceDiscontinued;
            resources.ApplyResources(this.lciDiscontinued, "lciDiscontinued");
            this.lciDiscontinued.Location = new System.Drawing.Point(0, 96);
            this.lciDiscontinued.Name = "lciDiscontinued";
            this.lciDiscontinued.Size = new System.Drawing.Size(297, 24);
            this.lciDiscontinued.TextSize = new System.Drawing.Size(90, 13);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("Beverages", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Beverages"))));
            this.svgImageCollection1.Add("condiments", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.condiments"))));
            this.svgImageCollection1.Add("confections", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.confections"))));
            this.svgImageCollection1.Add("DairyProduct", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.DairyProduct"))));
            this.svgImageCollection1.Add("grains_cereals", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.grains_cereals"))));
            this.svgImageCollection1.Add("MeatPoultry", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.MeatPoultry"))));
            this.svgImageCollection1.Add("produce", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.produce"))));
            this.svgImageCollection1.Add("Seafood", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Seafood"))));
            // 
            // frmProduct
            // 
            this.AcceptButton = this.simpleButton1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton2;
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduct";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduct_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceDiscontinued.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQuantityPerUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuantityPerUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDiscontinued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit teProductName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem lciProductName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciOK;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.CheckEdit ceDiscontinued;
        private DevExpress.XtraEditors.TextEdit teQuantityPerUnit;
        private DevExpress.XtraEditors.SpinEdit seUnitPrice;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbCategory;
        private DevExpress.XtraLayout.LayoutControlItem lciCategory;
        private DevExpress.XtraLayout.LayoutControlItem lciUnitPrice;
        private DevExpress.XtraLayout.LayoutControlItem lciQuantityPerUnit;
        private DevExpress.XtraLayout.LayoutControlItem lciDiscontinued;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
