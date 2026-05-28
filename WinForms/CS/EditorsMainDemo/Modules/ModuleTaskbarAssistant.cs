using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Taskbar;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleTaskbarAssistant : TutorialControl  {
        TaskbarAssistant _taskbarAssistantInstance;
        public ModuleTaskbarAssistant() {
            InitializeComponent();
            TutorialInfo.TutorialName = "TaskbarAssistant Tutorial";
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            CreateTaskbarAssistant();
            InitControls();
            UpdateControls();
            CreateThumbnailButtons();
        }
        void CreateThumbnailButtons() {
            for(int i = 0; i < TaskbarAssistant.MaxThumbnailButtonsCount; i++) {
                ThumbnailButton thumbButton = CreateThumbnailButton();
                TaskbarAssistantInstance.ThumbnailButtons.Add(thumbButton);
            }
        }
        void CreateTaskbarAssistant() {
            this._taskbarAssistantInstance = new TaskbarAssistant();
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
            _taskbarAssistantInstance.ProgressMode = (TaskbarButtonProgressMode)cb.EditValue;
        }
        // </cbProgressMode>
        // <trackBarProgressValue>
        void OnCurrentProgressValueTrackBarEditValueChanged(object sender, EventArgs e) {
            TrackBarControl trackBar = (TrackBarControl)sender;
            _taskbarAssistantInstance.ProgressCurrentValue = trackBar.Value;
        }
        // </trackBarProgressValue>
        // <imgOverlayIcons>
        void OnOverlayIconsComboBoxSelectedValueChanged(object sender, EventArgs e) {
            ImageComboBoxItem item = (ImageComboBoxItem)((ImageComboBoxEdit)sender).SelectedItem;
            Image img = item is ImageComboBoxNoneItem ? null : imgCollection.Images[item.ImageIndex];
            _taskbarAssistantInstance.OverlayIcon = (Bitmap)img;
        }
        // </imgOverlayIcons>
        // <btnAddItemToTasks>
        void OnAddItemToTasksButtonClick(object sender, EventArgs e) {
            string itemCaption = string.Format("Task #{0}", (_taskbarAssistantInstance.JumpListTasksCategory.Count + 1).ToString());
            JumpListItemTask taskItem = new JumpListItemTask(itemCaption);
            _taskbarAssistantInstance.JumpListTasksCategory.Add(taskItem);
            _taskbarAssistantInstance.Refresh();
            UpdateControls();
        }
        // </btnAddItemToTasks>
        // <btnRemoveItemFromTasks>
        void OnRemoveItemFromTasksButtonClick(object sender, EventArgs e) {
            int itemsCount = _taskbarAssistantInstance.JumpListTasksCategory.Count;
            if(itemsCount == 0)
                return;
            _taskbarAssistantInstance.JumpListTasksCategory.RemoveAt(itemsCount - 1);
            _taskbarAssistantInstance.Refresh();
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
            var rnd = TutorialConstants.Random;
            if(imgCollection.Images.Count > 0) {
                res.Image = (Bitmap)imgCollection.Images[rnd.Next(0, imgCollection.Images.Count)];
            }
            res.Click += (s, ee) => {
                int thumbButtonPos = TaskbarAssistantInstance.ThumbnailButtons.IndexOf(ee.ThumbButton) + 1;
                XtraMessageBox.Show(ParentForm, string.Format("ThumbnailButton # {0} clicked", thumbButtonPos.ToString()), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            res.Visible = false;
            return res;
        }
        void UpdateControls() {
            btnAddThumbnailButton.Enabled = CalcVisibleThumbnailButtonsCount() < TaskbarAssistant.MaxThumbnailButtonsCount;
            btnRemoveThumbnailButton.Enabled = CalcVisibleThumbnailButtonsCount() > 0;
            btnRemoveCustomCategory.Enabled = TaskbarAssistantInstance.JumpListCustomCategories.Count > 0;
            btnRemoveItemFromTasks.Enabled = TaskbarAssistantInstance.JumpListTasksCategory.Count > 0;
        }
        int CalcVisibleThumbnailButtonsCount() {
            int count = 0;
            foreach(var thumbButton in TaskbarAssistantInstance.ThumbnailButtons) {
                if(thumbButton.Visible) count++;
            }
            return count;
        }
        TaskbarAssistant TaskbarAssistantInstance { get { return _taskbarAssistantInstance; } }
    }

    internal class ImageComboBoxNoneItem : ImageComboBoxItem {
        public ImageComboBoxNoneItem() {
            this.ImageIndex = -1;
            this.Description = "(none)";
        }
    }
}
