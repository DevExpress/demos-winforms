namespace DevExpress.WindowsMailClient.Win.Modules {
    partial class MailPresenter {
        /// <summary> 
        /// Required designer variable.
        /// </summary>

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.Animation.Transition transition2 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.FadeTransition fadeTransition2 = new DevExpress.Utils.Animation.FadeTransition();
            this.pePhoto = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.richEdit = new DevExpress.XtraRichEdit.RichEditControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutPictureItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelDate = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.labelSubject = new DevExpress.XtraLayout.SimpleLabelItem();
            this.labelFrom = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager(this.components);
            this.mailStatusPanel1 = new DevExpress.WindowsMailClient.Win.Modules.MailStatusPanel();
            this.statusPanelItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pePhoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPictureItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelItem)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.pePhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.pePhoto.Location = new System.Drawing.Point(32, 91);
            this.pePhoto.Name = "pePhoto";
            this.pePhoto.Properties.AllowFocused = false;
            this.pePhoto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pePhoto.Properties.Appearance.Options.UseBackColor = true;
            this.pePhoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePhoto.Properties.NullText = " ";
            this.pePhoto.Properties.OptionsMask.MaskLayoutMode = DevExpress.XtraEditors.Controls.PictureEditMaskLayoutMode.Stretch;
            this.pePhoto.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.pePhoto.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pePhoto.Size = new System.Drawing.Size(70, 83);
            this.pePhoto.StyleController = this.layoutControl1;
            this.pePhoto.TabIndex = 5;
            
            
            
            this.layoutControl1.Controls.Add(this.mailStatusPanel1);
            this.layoutControl1.Controls.Add(this.richEdit);
            this.layoutControl1.Controls.Add(this.pePhoto);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(593, 194, 754, 470);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(332, 474);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            
            
            
            this.richEdit.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEdit.Appearance.Text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richEdit.Appearance.Text.Options.UseFont = true;
            this.richEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richEdit.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEdit.Location = new System.Drawing.Point(12, 237);
            this.richEdit.Name = "richEdit";
            this.richEdit.Options.VerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.richEdit.ReadOnly = true;
            this.richEdit.Size = new System.Drawing.Size(308, 225);
            this.richEdit.TabIndex = 7;
            this.richEdit.Views.SimpleView.AdjustColorsToSkins = true;
            
            
            
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutPictureItem,
            this.labelDate,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.labelSubject,
            this.labelFrom,
            this.emptySpaceItem1,
            this.statusPanelItem});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
            this.layoutControlGroup1.Size = new System.Drawing.Size(332, 474);
            this.layoutControlGroup1.TextVisible = false;
            
            
            
            this.layoutPictureItem.Control = this.pePhoto;
            this.layoutPictureItem.Location = new System.Drawing.Point(0, 65);
            this.layoutPictureItem.MaxSize = new System.Drawing.Size(108, 110);
            this.layoutPictureItem.MinSize = new System.Drawing.Size(108, 110);
            this.layoutPictureItem.Name = "layoutPictureItem";
            this.layoutPictureItem.Padding = new DevExpress.XtraLayout.Utils.Padding(16, 10, 10, 5);
            this.layoutPictureItem.Size = new System.Drawing.Size(108, 110);
            this.layoutPictureItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutPictureItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutPictureItem.TextSize = new System.Drawing.Size(0, 0);
            this.layoutPictureItem.TextVisible = false;
            
            
            
            this.labelDate.AllowHotTrack = false;
            this.labelDate.Enabled = false;
            this.labelDate.Location = new System.Drawing.Point(108, 115);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(204, 17);
            this.labelDate.Text = " ";
            this.labelDate.TextSize = new System.Drawing.Size(3, 13);
            
            
            
            this.layoutControlItem2.Control = this.richEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 225);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(312, 229);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            
            
            
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 217);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 8);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 8);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(312, 8);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            
            
            
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(108, 65);
            this.emptySpaceItem3.MaxSize = new System.Drawing.Size(0, 25);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(10, 25);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(204, 25);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            
            
            
            this.labelSubject.AllowHotTrack = false;
            this.labelSubject.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.AppearanceItemCaption.Options.UseFont = true;
            this.labelSubject.AppearanceItemCaption.Options.UseTextOptions = true;
            this.labelSubject.AppearanceItemCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.labelSubject.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelSubject.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelSubject.CustomizationFormText = "labelSubject";
            this.labelSubject.Location = new System.Drawing.Point(0, 0);
            this.labelSubject.MaxSize = new System.Drawing.Size(0, 65);
            this.labelSubject.MinSize = new System.Drawing.Size(1, 65);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 12, 2, 2);
            this.labelSubject.Size = new System.Drawing.Size(312, 65);
            this.labelSubject.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.labelSubject.Text = " ";
            this.labelSubject.TextSize = new System.Drawing.Size(0, 30);
            
            
            
            this.labelFrom.AllowHotTrack = false;
            this.labelFrom.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.AppearanceItemCaption.Options.UseFont = true;
            this.labelFrom.CustomizationFormText = "labelFrom";
            this.labelFrom.Location = new System.Drawing.Point(108, 90);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(204, 25);
            this.labelFrom.Text = " ";
            this.labelFrom.TextSize = new System.Drawing.Size(4, 21);
            
            
            
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(108, 132);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(204, 43);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            
            
            
            this.transitionManager1.FrameCount = 300;
            this.transitionManager1.ShowWaitingIndicator = false;
            transition2.BarWaitingIndicatorProperties.Caption = "";
            transition2.BarWaitingIndicatorProperties.Description = "";
            transition2.Control = this;
            transition2.EasingMode = DevExpress.Data.Utils.EasingMode.EaseOut;
            transition2.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition2.LineWaitingIndicatorProperties.Caption = "";
            transition2.LineWaitingIndicatorProperties.Description = "";
            transition2.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition2.RingWaitingIndicatorProperties.Caption = "";
            transition2.RingWaitingIndicatorProperties.Description = "";
            transition2.TransitionType = fadeTransition2;
            transition2.WaitingIndicatorProperties.Caption = "";
            transition2.WaitingIndicatorProperties.Description = "";
            this.transitionManager1.Transitions.Add(transition2);
            
            
            
            this.mailStatusPanel1.Location = new System.Drawing.Point(27, 190);
            this.mailStatusPanel1.Name = "mailStatusPanel1";
            this.mailStatusPanel1.Size = new System.Drawing.Size(283, 35);
            this.mailStatusPanel1.TabIndex = 8;
            this.mailStatusPanel1.Text = "mailStatusPanel1";
            
            
            
            this.statusPanelItem.Control = this.mailStatusPanel1;
            this.statusPanelItem.Location = new System.Drawing.Point(0, 175);
            this.statusPanelItem.MaxSize = new System.Drawing.Size(0, 42);
            this.statusPanelItem.MinSize = new System.Drawing.Size(1, 42);
            this.statusPanelItem.Name = "statusPanelItem";
            this.statusPanelItem.Padding = new DevExpress.XtraLayout.Utils.Padding(17, 12, 5, 2);
            this.statusPanelItem.Size = new System.Drawing.Size(312, 42);
            this.statusPanelItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.statusPanelItem.TextSize = new System.Drawing.Size(0, 0);
            this.statusPanelItem.TextVisible = false;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "MailPresenter";
            this.Size = new System.Drawing.Size(332, 474);
            ((System.ComponentModel.ISupportInitialize)(this.pePhoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutPictureItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPanelItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pePhoto;
        private DevExpress.XtraRichEdit.RichEditControl richEdit;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutPictureItem;
        private DevExpress.XtraLayout.SimpleLabelItem labelSubject;
        private DevExpress.XtraLayout.SimpleLabelItem labelDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.SimpleLabelItem labelFrom;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
        private System.ComponentModel.IContainer components;
        private MailStatusPanel mailStatusPanel1;
        private DevExpress.XtraLayout.LayoutControlItem statusPanelItem;
    }
}
