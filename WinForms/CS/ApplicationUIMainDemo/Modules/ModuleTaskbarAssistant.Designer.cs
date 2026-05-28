namespace DevExpress.ApplicationUI.Demos {
    partial class ModuleTaskbarAssistant {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            
            if(disposing ) {
				if(components != null) {
                	components.Dispose();
				}
				if(TaskbarAssistantInstance != null) {
					TaskbarAssistantInstance.JumpListCustomCategories.Clear();
            		TaskbarAssistantInstance.JumpListTasksCategory.Clear();
            		TaskbarAssistantInstance.Refresh();
				}
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel5 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel6 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel7 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel8 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel9 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel10 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel11 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleTaskbarAssistant));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRemoveThumbnailButton = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddThumbnailButton = new DevExpress.XtraEditors.SimpleButton();
            this.trackBarProgressValue = new DevExpress.XtraEditors.TrackBarControl();
            this.cbProgressMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.imgOverlayIcons = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.imgCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnRemoveItemFromTasks = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddItemToTasks = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnRemoveCustomCategory = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCustomCategory = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgressValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgressValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProgressMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOverlayIcons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnRemoveThumbnailButton);
            this.groupControl1.Controls.Add(this.btnAddThumbnailButton);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(325, 79);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thumbnail Buttons";
            // 
            // btnRemoveThumbnailButton
            // 
            this.btnRemoveThumbnailButton.Enabled = false;
            this.btnRemoveThumbnailButton.Location = new System.Drawing.Point(163, 35);
            this.btnRemoveThumbnailButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveThumbnailButton.Name = "btnRemoveThumbnailButton";
            this.btnRemoveThumbnailButton.Size = new System.Drawing.Size(149, 27);
            this.btnRemoveThumbnailButton.TabIndex = 0;
            this.btnRemoveThumbnailButton.Text = "Remove Thumbnail Button";
            this.btnRemoveThumbnailButton.Click += new System.EventHandler(this.OnRemoveThumbnailButtonClick);
            // 
            // btnAddThumbnailButton
            // 
            this.btnAddThumbnailButton.Enabled = false;
            this.btnAddThumbnailButton.Location = new System.Drawing.Point(10, 35);
            this.btnAddThumbnailButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddThumbnailButton.Name = "btnAddThumbnailButton";
            this.btnAddThumbnailButton.Size = new System.Drawing.Size(149, 27);
            this.btnAddThumbnailButton.TabIndex = 0;
            this.btnAddThumbnailButton.Text = "Add Thumbnail Button";
            this.btnAddThumbnailButton.Click += new System.EventHandler(this.OnAddThumbnailButtonClick);
            // 
            // trackBarProgressValue
            // 
            this.trackBarProgressValue.EditValue = null;
            this.trackBarProgressValue.Location = new System.Drawing.Point(168, 23);
            this.trackBarProgressValue.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarProgressValue.Name = "trackBarProgressValue";
            this.trackBarProgressValue.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarProgressValue.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "0";
            trackBarLabel2.Label = "10";
            trackBarLabel2.Value = 10;
            trackBarLabel3.Label = "20";
            trackBarLabel3.Value = 20;
            trackBarLabel4.Label = "30";
            trackBarLabel4.Value = 30;
            trackBarLabel5.Label = "40";
            trackBarLabel5.Value = 40;
            trackBarLabel6.Label = "50";
            trackBarLabel6.Value = 50;
            trackBarLabel7.Label = "60";
            trackBarLabel7.Value = 60;
            trackBarLabel8.Label = "70";
            trackBarLabel8.Value = 70;
            trackBarLabel9.Label = "80";
            trackBarLabel9.Value = 80;
            trackBarLabel10.Label = "90";
            trackBarLabel10.Value = 90;
            trackBarLabel11.Label = "100";
            trackBarLabel11.Value = 100;
            this.trackBarProgressValue.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3,
            trackBarLabel4,
            trackBarLabel5,
            trackBarLabel6,
            trackBarLabel7,
            trackBarLabel8,
            trackBarLabel9,
            trackBarLabel10,
            trackBarLabel11});
            this.trackBarProgressValue.Properties.Maximum = 100;
            this.trackBarProgressValue.Properties.ShowLabels = true;
            this.trackBarProgressValue.Size = new System.Drawing.Size(334, 72);
            this.trackBarProgressValue.TabIndex = 1;
            this.trackBarProgressValue.EditValueChanged += new System.EventHandler(this.OnCurrentProgressValueTrackBarEditValueChanged);
            // 
            // cbProgressMode
            // 
            this.cbProgressMode.Location = new System.Drawing.Point(10, 35);
            this.cbProgressMode.Margin = new System.Windows.Forms.Padding(2);
            this.cbProgressMode.Name = "cbProgressMode";
            this.cbProgressMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProgressMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbProgressMode.Size = new System.Drawing.Size(149, 20);
            this.cbProgressMode.TabIndex = 0;
            this.cbProgressMode.SelectedValueChanged += new System.EventHandler(this.OnProgressModeComboBoxEditSelectedValueChanged);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.trackBarProgressValue);
            this.groupControl3.Controls.Add(this.cbProgressMode);
            this.groupControl3.Location = new System.Drawing.Point(12, 103);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(522, 102);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Progress";
            // 
            // imgOverlayIcons
            // 
            this.imgOverlayIcons.Location = new System.Drawing.Point(5, 37);
            this.imgOverlayIcons.Name = "imgOverlayIcons";
            this.imgOverlayIcons.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgOverlayIcons.Properties.SmallImages = this.imgCollection;
            this.imgOverlayIcons.Size = new System.Drawing.Size(160, 20);
            this.imgOverlayIcons.TabIndex = 0;
            this.imgOverlayIcons.SelectedValueChanged += new System.EventHandler(this.OnOverlayIconsComboBoxSelectedValueChanged);
            // 
            // imgCollection
            // 
            this.imgCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCollection.ImageStream")));
            this.imgCollection.Images.SetKeyName(0, "Apply_16x16.png");
            this.imgCollection.Images.SetKeyName(1, "Add_16x16.png");
            this.imgCollection.Images.SetKeyName(2, "Refresh2_16x16.png");
            this.imgCollection.Images.SetKeyName(3, "SelectAll_16x16.png");
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.imgOverlayIcons);
            this.groupControl4.Location = new System.Drawing.Point(349, 12);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(185, 79);
            this.groupControl4.TabIndex = 7;
            this.groupControl4.Text = "Overlay Image";
            // 
            // btnRemoveItemFromTasks
            // 
            this.btnRemoveItemFromTasks.Location = new System.Drawing.Point(218, 33);
            this.btnRemoveItemFromTasks.Name = "btnRemoveItemFromTasks";
            this.btnRemoveItemFromTasks.Size = new System.Drawing.Size(202, 27);
            this.btnRemoveItemFromTasks.TabIndex = 0;
            this.btnRemoveItemFromTasks.Text = "Remove Item from Tasks Category";
            this.btnRemoveItemFromTasks.Click += new System.EventHandler(this.OnRemoveItemFromTasksButtonClick);
            // 
            // btnAddItemToTasks
            // 
            this.btnAddItemToTasks.Location = new System.Drawing.Point(10, 33);
            this.btnAddItemToTasks.Name = "btnAddItemToTasks";
            this.btnAddItemToTasks.Size = new System.Drawing.Size(202, 27);
            this.btnAddItemToTasks.TabIndex = 0;
            this.btnAddItemToTasks.Text = "Add Item to Tasks Category";
            this.btnAddItemToTasks.Click += new System.EventHandler(this.OnAddItemToTasksButtonClick);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.btnAddItemToTasks);
            this.groupControl5.Controls.Add(this.btnRemoveItemFromTasks);
            this.groupControl5.Location = new System.Drawing.Point(12, 217);
            this.groupControl5.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(522, 79);
            this.groupControl5.TabIndex = 8;
            this.groupControl5.Text = "Tasks Category";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnRemoveCustomCategory);
            this.groupControl2.Controls.Add(this.btnAddCustomCategory);
            this.groupControl2.Location = new System.Drawing.Point(12, 308);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(522, 79);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Custom Categories";
            // 
            // btnRemoveCustomCategory
            // 
            this.btnRemoveCustomCategory.Location = new System.Drawing.Point(218, 34);
            this.btnRemoveCustomCategory.Name = "btnRemoveCustomCategory";
            this.btnRemoveCustomCategory.Size = new System.Drawing.Size(202, 27);
            this.btnRemoveCustomCategory.TabIndex = 1;
            this.btnRemoveCustomCategory.Text = "Remove Custom Category";
            this.btnRemoveCustomCategory.Click += new System.EventHandler(this.OnRemoveCustomCategoryButtonClick);
            // 
            // btnAddCustomCategory
            // 
            this.btnAddCustomCategory.Location = new System.Drawing.Point(10, 34);
            this.btnAddCustomCategory.Name = "btnAddCustomCategory";
            this.btnAddCustomCategory.Size = new System.Drawing.Size(202, 27);
            this.btnAddCustomCategory.TabIndex = 0;
            this.btnAddCustomCategory.Text = "Add Custom Category";
            this.btnAddCustomCategory.Click += new System.EventHandler(this.OnAddCustomCategoryButtonClick);
            // 
            // ModuleTaskbarAssistant
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModuleTaskbarAssistant";
            this.Size = new System.Drawing.Size(588, 438);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgressValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgressValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProgressMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOverlayIcons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddThumbnailButton;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TrackBarControl trackBarProgressValue;
        private DevExpress.XtraEditors.ComboBoxEdit cbProgressMode;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnRemoveThumbnailButton;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgOverlayIcons;
        private Utils.ImageCollection imgCollection;
        private DevExpress.XtraEditors.SimpleButton btnRemoveItemFromTasks;
        private DevExpress.XtraEditors.SimpleButton btnAddItemToTasks;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnRemoveCustomCategory;
        private DevExpress.XtraEditors.SimpleButton btnAddCustomCategory;
    }
}
