using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Taskbar;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.DXperience.Demos;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ModuleTaskbarAssistant : TutorialControl {
        TaskbarAssistant taskbarAssistantInctanceCore;
        public ModuleTaskbarAssistant() {
            InitializeComponent();
            TutorialInfo.TutorialName = "TaskbarAssistant Tutorial";
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            CreateTaskbarAssistant();
            InitControls();
            UpdateControls(false);
            CreateThumbnailButtons();
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            UpdateCenteredControls(this);
        }
        void CreateThumbnailButtons() {
            for(int i = 0; i < TaskbarAssistant.MaxThumbnailButtonsCount; i++) {
                ThumbnailButton thumbButton = CreateThumbnailButton();
                TaskbarAssistantInstance.ThumbnailButtons.Add(thumbButton);
            }
        }
        void CreateTaskbarAssistant() {
            this.taskbarAssistantInctanceCore = new TaskbarAssistant();
            TaskbarAssistantInstance.ParentControl = ParentForm;
        }
        void InitControls() {
            var progressModes = Enum.GetValues(typeof(TaskbarButtonProgressMode));
            foreach(TaskbarButtonProgressMode progressMode in progressModes) {
                cbProgressMode.Properties.Items.Add(progressMode);
            }
            if(cbProgressMode.Properties.Items.Count > 0) {
                cbProgressMode.SelectedIndex = 0;
            }
            imgOverlayIcons.Properties.Items.Add(new ImageComboBoxNoneItem());
            for(int i = 0; i < imgCollection.Images.Count; i++) {
                string description = imgCollection.Images.Keys[i];
                imgOverlayIcons.Properties.Items.Add(new ImageComboBoxItem(description, i));
            }
            if(imgOverlayIcons.Properties.Items.Count > 0) {
                imgOverlayIcons.SelectedIndex = 0;
            }
        }
        // <btnAddThumbnailButton>
        void OnAddThumbnailButtonClick(object sender, EventArgs e) {
            foreach(ThumbnailButton button in TaskbarAssistantInstance.ThumbnailButtons) {
                if(!button.Visible) {
                    button.Visible = true;
                    break;
                }
            }
            TaskbarAssistantInstance.Refresh();
            UpdateControls();
        }
        // </btnAddThumbnailButton>
        // <btnRemoveThumbnailButton>
        void OnRemoveThumbnailButtonClick(object sender, EventArgs e) {
            for(int i = TaskbarAssistantInstance.ThumbnailButtons.Count - 1; i >= 0; i--) {
                ThumbnailButton thumbButton = TaskbarAssistantInstance.ThumbnailButtons[i];
                if(thumbButton.Visible) {
                    thumbButton.Visible = false;
                    break;
                }
            }
            TaskbarAssistantInstance.Refresh();
            UpdateControls();
        }
        // </btnRemoveThumbnailButton>
        // <cbProgressMode>
        void OnProgressModeComboBoxEditSelectedValueChanged(object sender, EventArgs e) {
            ComboBoxEdit cb = (ComboBoxEdit)sender;
            taskbarAssistantInctanceCore.ProgressMode = (TaskbarButtonProgressMode)cb.EditValue;
        }
        // </cbProgressMode>
        // <trackBarProgressValue>
        void OnCurrentProgressValueTrackBarEditValueChanged(object sender, EventArgs e) {
            TrackBarControl trackBar = (TrackBarControl)sender;
            taskbarAssistantInctanceCore.ProgressCurrentValue = trackBar.Value;
        }
        // </trackBarProgressValue>
        // <imgOverlayIcons>
        void OnOverlayIconsComboBoxSelectedValueChanged(object sender, EventArgs e) {
            ImageComboBoxItem item = (ImageComboBoxItem)((ImageComboBoxEdit)sender).SelectedItem;
            Image img = item is ImageComboBoxNoneItem ? null : imgCollection.Images[item.ImageIndex];
            taskbarAssistantInctanceCore.OverlayIcon = (Bitmap)img;
        }
        // </imgOverlayIcons>
        // <btnAddItemToTasks>
        void OnAddItemToTasksButtonClick(object sender, EventArgs e) {
            string itemCaption = string.Format("Task #{0}", (taskbarAssistantInctanceCore.JumpListTasksCategory.Count + 1).ToString());
            JumpListItemTask taskItem = new JumpListItemTask(itemCaption);
            taskItem.Click += OnJumpListClick;
            taskbarAssistantInctanceCore.JumpListTasksCategory.Add(taskItem);
            taskbarAssistantInctanceCore.Refresh();
            UpdateControls();
        }
        void OnJumpListClick(object sender, EventArgs e) {
            XtraMessageBox.Show("Click");
        }
        // </btnAddItemToTasks>
        // <btnRemoveItemFromTasks>
        void OnRemoveItemFromTasksButtonClick(object sender, EventArgs e) {
            int itemsCount = taskbarAssistantInctanceCore.JumpListTasksCategory.Count;
            if(itemsCount == 0)
                return;
            taskbarAssistantInctanceCore.JumpListTasksCategory.RemoveAt(itemsCount - 1);
            taskbarAssistantInctanceCore.Refresh();
            UpdateControls();
        }
        // </btnRemoveItemFromTasks>
        // <btnAddCustomCategory>
        void OnAddCustomCategoryButtonClick(object sender, EventArgs e) {
            string categoryName = string.Format("Custom Category #{0}", (TaskbarAssistantInstance.JumpListCustomCategories.Count + 1).ToString());
            JumpListCategory customCategory = new JumpListCategory(categoryName);
            for(int i = 0; i < 2; i++) {
                string itemCaption = string.Format("Task #{0}", (i + 1).ToString());
                JumpListItemTask item = new JumpListItemTask(itemCaption);
                item.Click += OnJumpListClick;
                customCategory.JumpItems.Add(item);
            }
            TaskbarAssistantInstance.JumpListCustomCategories.Add(customCategory);
            TaskbarAssistantInstance.Refresh();
            UpdateControls();
        }
        // </btnAddCustomCategory>
        // <btnRemoveCustomCategory>
        void OnRemoveCustomCategoryButtonClick(object sender, EventArgs e) {
            int categoriesCount = TaskbarAssistantInstance.JumpListCustomCategories.Count;
            if(categoriesCount == 0)
                return;
            TaskbarAssistantInstance.JumpListCustomCategories.RemoveAt(categoriesCount - 1);
            TaskbarAssistantInstance.Refresh();
            UpdateControls();
        }
        // </btnRemoveCustomCategory>
        ThumbnailButton CreateThumbnailButton() {
            ThumbnailButton res = new ThumbnailButton();
            if(imgCollection.Images.Count > 0) {
                res.Image = (Bitmap)imgCollection.Images[TutorialConstants.Random.Next(0, imgCollection.Images.Count)];
            }
            res.Click += (s, ee) => {
                int thumbButtonPos = TaskbarAssistantInstance.ThumbnailButtons.IndexOf(ee.ThumbButton) + 1;
                XtraMessageBox.Show(ParentForm, string.Format("ThumbnailButton # {0} clicked", thumbButtonPos.ToString()), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            res.Visible = false;
            return res;
        }
        void UpdateControls(bool blinkTaskbarItem = true) {
            btnAddThumbnailButton.Enabled = CalcVisibleThumbnailButtonsCount() < TaskbarAssistant.MaxThumbnailButtonsCount;
            btnRemoveThumbnailButton.Enabled = CalcVisibleThumbnailButtonsCount() > 0;
            btnRemoveCustomCategory.Enabled = TaskbarAssistantInstance.JumpListCustomCategories.Count > 0;
            btnRemoveItemFromTasks.Enabled = TaskbarAssistantInstance.JumpListTasksCategory.Count > 0;
            if(blinkTaskbarItem)
                NativeMethods.FlashWindowEx(ParentFormMain.Handle, NativeMethods.FLASHW.FLASHW_TRAY, 7, 250);
        }
        int CalcVisibleThumbnailButtonsCount() {
            int count = 0;
            foreach(var thumbButton in TaskbarAssistantInstance.ThumbnailButtons) {
                if(thumbButton.Visible)
                    count++;
            }
            return count;
        }
        TaskbarAssistant TaskbarAssistantInstance { get { return taskbarAssistantInctanceCore; } }
        protected override bool? AllowBorderRounding { get { return true; } }
    }

    internal class ImageComboBoxNoneItem : ImageComboBoxItem {
        public ImageComboBoxNoneItem() {
            this.ImageIndex = -1;
            this.Description = "(none)";
        }
    }
}
