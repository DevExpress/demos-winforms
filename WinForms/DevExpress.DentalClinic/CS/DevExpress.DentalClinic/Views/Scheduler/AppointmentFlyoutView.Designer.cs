namespace DevExpress.DentalClinic.Views.Scheduler {
    partial class AppointmentFlyoutView {
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.xpBindingSource1 = new DevExpress.Xpo.XPBindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PhotoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPhotoPictureEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.xpBindingSource11 = new DevExpress.Xpo.XPBindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPhotoPictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AutoScroll = false;
            this.dataLayoutControl1.AutoSize = true;
            this.dataLayoutControl1.Controls.Add(this.labelControl5);
            this.dataLayoutControl1.Controls.Add(this.labelControl2);
            this.dataLayoutControl1.Controls.Add(this.labelControl4);
            this.dataLayoutControl1.Controls.Add(this.labelControl3);
            this.dataLayoutControl1.Controls.Add(this.labelControl1);
            this.dataLayoutControl1.Controls.Add(this.PhotoPictureEdit);
            this.dataLayoutControl1.DataSource = this.xpBindingSource1;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(851, 187, 758, 822);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(251, 141);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // labelControl5
            // 
            this.labelControl5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpBindingSource1, "EndDate", true));
            this.labelControl5.Location = new System.Drawing.Point(175, 54);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 17);
            this.labelControl5.StyleController = this.dataLayoutControl1;
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "EndDate";
            // 
            // xpBindingSource1
            // 
            this.xpBindingSource1.DisplayableProperties = "This;Oid;Patient!Key;Patient;Doctor!Key;Doctor;Date;ProcedureCollection;Duration;" +
    "AllDayEvent;Status;Comment;EndDate;Description;Patient.FullName";
            this.xpBindingSource1.ObjectType = typeof(DevExpress.DentalClinic.Model.Appointment);
            // 
            // labelControl2
            // 
            this.labelControl2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpBindingSource1, "Date", true));
            this.labelControl2.Location = new System.Drawing.Point(175, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 17);
            this.labelControl2.StyleController = this.dataLayoutControl1;
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "StartDate";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpBindingSource1, "Description", true));
            this.labelControl4.Location = new System.Drawing.Point(140, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 17);
            this.labelControl4.StyleController = this.dataLayoutControl1;
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Description";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpBindingSource1, "Patient.Phone", true));
            this.labelControl3.Location = new System.Drawing.Point(187, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 17);
            this.labelControl3.StyleController = this.dataLayoutControl1;
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Phone";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpBindingSource1, "Patient.FullName", true));
            this.labelControl1.Location = new System.Drawing.Point(12, 112);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 17);
            this.labelControl1.StyleController = this.dataLayoutControl1;
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "FullName";
            // 
            // PhotoPictureEdit
            // 
            this.PhotoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.xpBindingSource1, "Patient.Picture.Image", true));
            this.PhotoPictureEdit.Location = new System.Drawing.Point(12, 12);
            this.PhotoPictureEdit.Name = "PhotoPictureEdit";
            this.PhotoPictureEdit.Properties.AllowFocused = false;
            this.PhotoPictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PhotoPictureEdit.Properties.Appearance.Options.UseBackColor = true;
            this.PhotoPictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PhotoPictureEdit.Properties.NullText = "Add Picture";
            this.PhotoPictureEdit.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.PhotoPictureEdit.Properties.OptionsMask.Offset = new System.Drawing.Point(0, -30);
            this.PhotoPictureEdit.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.PhotoPictureEdit.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.PhotoPictureEdit.Properties.ShowMenu = false;
            this.PhotoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.PhotoPictureEdit.Size = new System.Drawing.Size(116, 96);
            this.PhotoPictureEdit.StyleController = this.dataLayoutControl1;
            this.PhotoPictureEdit.TabIndex = 13;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(251, 141);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem5,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(231, 121);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPhotoPictureEdit,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(120, 121);
            // 
            // lciPhotoPictureEdit
            // 
            this.lciPhotoPictureEdit.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lciPhotoPictureEdit.Control = this.PhotoPictureEdit;
            this.lciPhotoPictureEdit.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lciPhotoPictureEdit.CustomizationFormText = "Photo";
            this.lciPhotoPictureEdit.Location = new System.Drawing.Point(0, 0);
            this.lciPhotoPictureEdit.MinSize = new System.Drawing.Size(120, 100);
            this.lciPhotoPictureEdit.Name = "lciPhotoPictureEdit";
            this.lciPhotoPictureEdit.OptionsTableLayoutItem.RowIndex = 1;
            this.lciPhotoPictureEdit.Size = new System.Drawing.Size(120, 100);
            this.lciPhotoPictureEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPhotoPictureEdit.StartNewLine = true;
            this.lciPhotoPictureEdit.Text = "Photo";
            this.lciPhotoPictureEdit.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciPhotoPictureEdit.TextSize = new System.Drawing.Size(0, 0);
            this.lciPhotoPictureEdit.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem1.Control = this.labelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(17, 21);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(120, 21);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.labelControl4;
            this.layoutControlItem5.Location = new System.Drawing.Point(120, 63);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(111, 58);
            this.layoutControlItem5.Text = "Procedures";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(68, 17);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(221, 42);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 21);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(221, 21);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(10, 21);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem2.Control = this.labelControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(120, 21);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(101, 21);
            this.layoutControlItem2.Text = "Start";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(30, 17);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem3.Control = this.labelControl5;
            this.layoutControlItem3.Location = new System.Drawing.Point(120, 42);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.layoutControlItem3.Size = new System.Drawing.Size(101, 21);
            this.layoutControlItem3.Text = "End";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(30, 17);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem4.Control = this.labelControl3;
            this.layoutControlItem4.CustomizationFormText = "tel. ";
            this.layoutControlItem4.Location = new System.Drawing.Point(120, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(98, 21);
            this.layoutControlItem4.Text = "Phone  ";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(47, 17);
            this.layoutControlItem4.TextToControlDistance = 0;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(218, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(13, 21);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // AppointmentFlyoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "AppointmentFlyoutView";
            this.Size = new System.Drawing.Size(251, 141);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPhotoPictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpBindingSource11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Xpo.XPBindingSource xpBindingSource1;
        private XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraEditors.LabelControl labelControl4;
        private XtraEditors.LabelControl labelControl3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraEditors.PictureEdit PhotoPictureEdit;
        private XtraLayout.LayoutControlItem lciPhotoPictureEdit;
        private Xpo.XPBindingSource xpBindingSource11;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.EmptySpaceItem emptySpaceItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem5;
        private XtraLayout.EmptySpaceItem emptySpaceItem6;
        private XtraEditors.LabelControl labelControl5;
        private XtraEditors.LabelControl labelControl2;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
