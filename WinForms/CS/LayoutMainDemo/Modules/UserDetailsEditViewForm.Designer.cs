using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraLayout.Utils;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors;
namespace DevExpress.XtraLayout.Demos {
    public partial class UserDetailsEditViewForm : TutorialControl {
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit11;
        private LayoutControlItem layoutControlItem6;
        private LayoutControlItem layoutControlItem15;
        private LayoutControlItem layoutControlItem7;
        private LayoutControlItem layoutControlItem9;
        private LayoutControlItem layoutControlItem10;
        private LayoutControlItem layoutControlItem18;
        private LayoutControlItem layoutControlItem11;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlItem layoutControlItem3;
        private LayoutControlItem layoutControlItem16;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private LayoutControlItem layoutControlItem20;
        private LayoutControlItem layoutControlItem19;
        private EmptySpaceItem emptySpaceItem1;
        private EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private LayoutControlItem layoutControlItem12;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPostalCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRegion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCity = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // xpCollection1
            // 
            this.xpCollection1.DisplayableProperties = "Address;BirthDate;City;Country;EmployeeID;Extension;FirstName;HireDate;HomePhone;" +
    "LastName;Notes;PostalCode;Region;ReportsTo;Title;TitleOfCourtesy";
            this.xpCollection1.ObjectType = typeof(DevExpress.XtraLayout.Demos.DBObjects.Employees);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.memoEdit1);
            this.dataLayoutControl1.Controls.Add(this.dataNavigator1);
            this.dataLayoutControl1.Controls.Add(this.simpleButton2);
            this.dataLayoutControl1.Controls.Add(this.labelControl1);
            this.dataLayoutControl1.Controls.Add(this.textEdit2);
            this.dataLayoutControl1.Controls.Add(this.dateEdit1);
            this.dataLayoutControl1.Controls.Add(this.textEdit3);
            this.dataLayoutControl1.Controls.Add(this.textEdit4);
            this.dataLayoutControl1.Controls.Add(this.spinEdit1);
            this.dataLayoutControl1.Controls.Add(this.textEdit5);
            this.dataLayoutControl1.Controls.Add(this.textEdit6);
            this.dataLayoutControl1.Controls.Add(this.dateEdit2);
            this.dataLayoutControl1.Controls.Add(this.hyperLinkEdit1);
            this.dataLayoutControl1.Controls.Add(this.textEdit7);
            this.dataLayoutControl1.Controls.Add(this.textEdit9);
            this.dataLayoutControl1.Controls.Add(this.textEdit10);
            this.dataLayoutControl1.Controls.Add(this.spinEdit2);
            this.dataLayoutControl1.Controls.Add(this.textEdit11);
            this.dataLayoutControl1.DataSource = this.xpCollection1;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem15});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-1198, 206, 450, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(560, 534);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            this.dataLayoutControl1.CurrentRecordChanged += new System.EventHandler(this.dataLayoutControl1_CurrentRecordChanged);
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "Notes", true));
            this.memoEdit1.Location = new System.Drawing.Point(5, 220);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(550, 238);
            this.memoEdit1.StyleController = this.dataLayoutControl1;
            this.memoEdit1.TabIndex = 25;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.DataSource = this.xpCollection1;
            this.dataNavigator1.Location = new System.Drawing.Point(5, 507);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(220, 18);
            this.dataNavigator1.StyleController = this.dataLayoutControl1;
            this.dataNavigator1.TabIndex = 24;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(472, 507);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(83, 22);
            this.simpleButton2.StyleController = this.dataLayoutControl1;
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "Edit Data";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(550, 23);
            this.labelControl1.StyleController = this.dataLayoutControl1;
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "User details";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "Address", true));
            this.textEdit2.Location = new System.Drawing.Point(74, 148);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(481, 20);
            this.textEdit2.StyleController = this.dataLayoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "BirthDate", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(353, 64);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(202, 20);
            this.dateEdit1.StyleController = this.dataLayoutControl1;
            this.dateEdit1.TabIndex = 6;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "City", true));
            this.textEdit3.Location = new System.Drawing.Point(74, 120);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(202, 20);
            this.textEdit3.StyleController = this.dataLayoutControl1;
            this.textEdit3.TabIndex = 7;
            // 
            // textEdit4
            // 
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "Country", true));
            this.textEdit4.Location = new System.Drawing.Point(74, 92);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(202, 20);
            this.textEdit4.StyleController = this.dataLayoutControl1;
            this.textEdit4.TabIndex = 8;
            // 
            // spinEdit1
            // 
            this.spinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "EmployeeID", true));
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(0, 0);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Size = new System.Drawing.Size(0, 20);
            this.spinEdit1.StyleController = this.dataLayoutControl1;
            this.spinEdit1.TabIndex = 9;
            // 
            // textEdit5
            // 
            this.textEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "Extension", true));
            this.textEdit5.Location = new System.Drawing.Point(353, 176);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(202, 20);
            this.textEdit5.StyleController = this.dataLayoutControl1;
            this.textEdit5.TabIndex = 10;
            // 
            // textEdit6
            // 
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "FirstName", true));
            this.textEdit6.Location = new System.Drawing.Point(239, 36);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(88, 20);
            this.textEdit6.StyleController = this.dataLayoutControl1;
            this.textEdit6.TabIndex = 11;
            // 
            // dateEdit2
            // 
            this.dateEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "HireDate", true));
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(74, 64);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(202, 20);
            this.dateEdit2.StyleController = this.dataLayoutControl1;
            this.dateEdit2.TabIndex = 12;
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "HomePhone", true));
            this.hyperLinkEdit1.Location = new System.Drawing.Point(74, 176);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Size = new System.Drawing.Size(202, 20);
            this.hyperLinkEdit1.StyleController = this.dataLayoutControl1;
            this.hyperLinkEdit1.TabIndex = 13;
            // 
            // textEdit7
            // 
            this.textEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "LastName", true));
            this.textEdit7.Location = new System.Drawing.Point(404, 36);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(151, 20);
            this.textEdit7.StyleController = this.dataLayoutControl1;
            this.textEdit7.TabIndex = 14;
            // 
            // textEdit9
            // 
            this.textEdit9.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "PostalCode", true));
            this.textEdit9.Location = new System.Drawing.Point(353, 120);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Size = new System.Drawing.Size(202, 20);
            this.textEdit9.StyleController = this.dataLayoutControl1;
            this.textEdit9.TabIndex = 16;
            // 
            // textEdit10
            // 
            this.textEdit10.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "Region", true));
            this.textEdit10.Location = new System.Drawing.Point(353, 92);
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Size = new System.Drawing.Size(202, 20);
            this.textEdit10.StyleController = this.dataLayoutControl1;
            this.textEdit10.TabIndex = 17;
            // 
            // spinEdit2
            // 
            this.spinEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "ReportsTo", true));
            this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(0, 0);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit2.Size = new System.Drawing.Size(0, 20);
            this.spinEdit2.StyleController = this.dataLayoutControl1;
            this.spinEdit2.TabIndex = 18;
            // 
            // textEdit11
            // 
            this.textEdit11.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpCollection1, "Title", true));
            this.textEdit11.Location = new System.Drawing.Point(74, 36);
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Size = new System.Drawing.Size(88, 20);
            this.textEdit11.StyleController = this.dataLayoutControl1;
            this.textEdit11.TabIndex = 19;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.spinEdit1;
            this.layoutControlItem6.CustomizationFormText = "EmployeeID";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "ItemForEmployeeID";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem6.Text = "EmployeeID";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(43, 16);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.spinEdit2;
            this.layoutControlItem15.CustomizationFormText = "ReportsTo";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem15.Name = "ItemForReportsTo";
            this.layoutControlItem15.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem15.Text = "ReportsTo";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(43, 16);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem18,
            this.layoutControlItem11,
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.layoutControlItem16,
            this.layoutControlItem20,
            this.layoutControlItem19,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem12,
            this.ItemForPostalCode,
            this.ItemForCountry,
            this.ItemForRegion,
            this.ItemForCity,
            this.ItemForAddress});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(560, 534);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEdit5;
            this.layoutControlItem7.CustomizationFormText = "Extension";
            this.layoutControlItem7.Location = new System.Drawing.Point(279, 171);
            this.layoutControlItem7.Name = "ItemForExtension";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem7.Size = new System.Drawing.Size(279, 28);
            this.layoutControlItem7.Text = "Extension";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.labelControl1;
            this.layoutControlItem18.CustomizationFormText = "layoutControlItem18";
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem18.Size = new System.Drawing.Size(558, 31);
            this.layoutControlItem18.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.textEdit7;
            this.layoutControlItem11.CustomizationFormText = "LastName";
            this.layoutControlItem11.Location = new System.Drawing.Point(330, 31);
            this.layoutControlItem11.Name = "ItemForLastName";
            this.layoutControlItem11.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem11.Size = new System.Drawing.Size(228, 28);
            this.layoutControlItem11.Text = "LastName";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textEdit6;
            this.layoutControlItem8.CustomizationFormText = "FirstName";
            this.layoutControlItem8.Location = new System.Drawing.Point(165, 31);
            this.layoutControlItem8.Name = "ItemForFirstName";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem8.Size = new System.Drawing.Size(165, 28);
            this.layoutControlItem8.Text = "FirstName";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateEdit1;
            this.layoutControlItem3.CustomizationFormText = "BirthDate";
            this.layoutControlItem3.Location = new System.Drawing.Point(279, 59);
            this.layoutControlItem3.Name = "ItemForBirthDate";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(279, 28);
            this.layoutControlItem3.Text = "BirthDate";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.textEdit11;
            this.layoutControlItem16.CustomizationFormText = "Title";
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem16.Name = "ItemForTitle";
            this.layoutControlItem16.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem16.Size = new System.Drawing.Size(165, 28);
            this.layoutControlItem16.Text = "Title";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.simpleButton2;
            this.layoutControlItem20.CustomizationFormText = "layoutControlItem20";
            this.layoutControlItem20.Location = new System.Drawing.Point(467, 502);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem20.Size = new System.Drawing.Size(91, 30);
            this.layoutControlItem20.TextVisible = false;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.dataNavigator1;
            this.layoutControlItem19.CustomizationFormText = "layoutControlItem19";
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 502);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem19.Size = new System.Drawing.Size(228, 30);
            this.layoutControlItem19.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(228, 502);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.emptySpaceItem1.Size = new System.Drawing.Size(239, 30);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 461);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.emptySpaceItem2.Size = new System.Drawing.Size(558, 41);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.dateEdit2;
            this.layoutControlItem9.CustomizationFormText = "HireDate";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 59);
            this.layoutControlItem9.Name = "ItemForHireDate";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem9.Size = new System.Drawing.Size(279, 28);
            this.layoutControlItem9.Text = "HireDate";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.hyperLinkEdit1;
            this.layoutControlItem10.CustomizationFormText = "HomePhone";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 171);
            this.layoutControlItem10.Name = "ItemForHomePhone";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem10.Size = new System.Drawing.Size(279, 28);
            this.layoutControlItem10.Text = "HomePhone";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.memoEdit1;
            this.layoutControlItem12.CustomizationFormText = "Notes";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 199);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem12.Size = new System.Drawing.Size(558, 262);
            this.layoutControlItem12.Text = "Notes";
            this.layoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(57, 13);
            // 
            // ItemForPostalCode
            // 
            this.ItemForPostalCode.Control = this.textEdit9;
            this.ItemForPostalCode.CustomizationFormText = "PostalCode";
            this.ItemForPostalCode.Location = new System.Drawing.Point(279, 115);
            this.ItemForPostalCode.Name = "ItemForPostalCode";
            this.ItemForPostalCode.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.ItemForPostalCode.Size = new System.Drawing.Size(279, 28);
            this.ItemForPostalCode.Text = "PostalCode";
            this.ItemForPostalCode.TextSize = new System.Drawing.Size(57, 13);
            // 
            // ItemForCountry
            // 
            this.ItemForCountry.Control = this.textEdit4;
            this.ItemForCountry.CustomizationFormText = "Country";
            this.ItemForCountry.Location = new System.Drawing.Point(0, 87);
            this.ItemForCountry.Name = "ItemForCountry";
            this.ItemForCountry.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.ItemForCountry.Size = new System.Drawing.Size(279, 28);
            this.ItemForCountry.Text = "Country";
            this.ItemForCountry.TextSize = new System.Drawing.Size(57, 13);
            // 
            // ItemForRegion
            // 
            this.ItemForRegion.Control = this.textEdit10;
            this.ItemForRegion.CustomizationFormText = "Region";
            this.ItemForRegion.Location = new System.Drawing.Point(279, 87);
            this.ItemForRegion.Name = "ItemForRegion";
            this.ItemForRegion.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.ItemForRegion.Size = new System.Drawing.Size(279, 28);
            this.ItemForRegion.Text = "Region";
            this.ItemForRegion.TextSize = new System.Drawing.Size(57, 13);
            // 
            // ItemForCity
            // 
            this.ItemForCity.Control = this.textEdit3;
            this.ItemForCity.CustomizationFormText = "City";
            this.ItemForCity.Location = new System.Drawing.Point(0, 115);
            this.ItemForCity.Name = "ItemForCity";
            this.ItemForCity.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.ItemForCity.Size = new System.Drawing.Size(279, 28);
            this.ItemForCity.Text = "City";
            this.ItemForCity.TextSize = new System.Drawing.Size(57, 13);
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.Control = this.textEdit2;
            this.ItemForAddress.CustomizationFormText = "Address";
            this.ItemForAddress.Location = new System.Drawing.Point(0, 143);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.ItemForAddress.Size = new System.Drawing.Size(558, 28);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextSize = new System.Drawing.Size(57, 13);
            // 
            // UserDetailsEditViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "UserDetailsEditViewForm";
            this.Size = new System.Drawing.Size(560, 534);
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPostalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            this.ResumeLayout(false);

        }

        private LayoutControlItem ItemForPostalCode;
        private LayoutControlItem ItemForCountry;
        private LayoutControlItem ItemForRegion;
        private LayoutControlItem ItemForCity;
        private LayoutControlItem ItemForAddress;
        private IContainer components;
    }
}
