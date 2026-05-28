using DevExpress.Utils;
using DevExpress.WindowsMailClient.Win.Controls;
using DevExpress.WindowsMailClient.Win.ViewModels;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace DevExpress.WindowsMailClient.Win
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.flyoutPanelNotifications = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl4 = new DevExpress.Utils.FlyoutPanelControl();
            this.accordionControl2 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer3 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.notificationsHeader = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.flyoutPanelFocuedInboxSettings = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl3 = new DevExpress.Utils.FlyoutPanelControl();
            this.accordionControl1 = new DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl();
            this.accordionContentContainer2 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.showFocusedOtherFilterToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.focusedInboxAccordionTitle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.flyoutPanelAccounts = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl2 = new DevExpress.Utils.FlyoutPanelControl();
            this.accordionAccounts = new DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl();
            this.aceManageAccountsTitle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementAccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.linkInboxedElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.addAccountElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.flyoutPanelSettings = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.accordionSettings = new DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.manageAccountsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.personalizationElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.automaticRepliesElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.focusedInboxElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.messageListElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.readingPaneElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.signatureElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.notificationsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.emailSecurityElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.wnElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.oulookAndiOSElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.helpElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.trustCenterElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.feedbackElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aboutElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.flyoutPanelFolders = new DevExpress.WindowsMailClient.Win.Controls.VerticalTopFlyoutPanel();
            this.accordionFolders = new DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.outboxElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.inboxElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.archiveElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.archive1Element = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.clutterElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.convHistoryElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.deletedItemsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.draftsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.junkEmailElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sentItemsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.elementMail = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementNewMail = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementAccounts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementFolders = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.foldersDrafts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.foldersSentItems = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.foldersMore = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementCalendar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementNewEvent = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementPeople = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.fluentDesignFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelNotifications)).BeginInit();
            this.flyoutPanelNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl4)).BeginInit();
            this.flyoutPanelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).BeginInit();
            this.accordionControl2.SuspendLayout();
            this.accordionContentContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelFocuedInboxSettings)).BeginInit();
            this.flyoutPanelFocuedInboxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl3)).BeginInit();
            this.flyoutPanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.accordionControl1.SuspendLayout();
            this.accordionContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showFocusedOtherFilterToggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelAccounts)).BeginInit();
            this.flyoutPanelAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).BeginInit();
            this.flyoutPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelSettings)).BeginInit();
            this.flyoutPanelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelFolders)).BeginInit();
            this.flyoutPanelFolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            this.accordionControl.SuspendLayout();
            this.accordionContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.fluentDesignFormContainer.Controls.Add(this.flyoutPanelNotifications);
            this.fluentDesignFormContainer.Controls.Add(this.flyoutPanelFocuedInboxSettings);
            this.fluentDesignFormContainer.Controls.Add(this.flyoutPanelAccounts);
            this.fluentDesignFormContainer.Controls.Add(this.flyoutPanelSettings);
            this.fluentDesignFormContainer.Controls.Add(this.flyoutPanelFolders);
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(341, 31);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(1131, 739);
            this.fluentDesignFormContainer.TabIndex = 0;
            
            
            
            this.flyoutPanelNotifications.Controls.Add(this.flyoutPanelControl4);
            this.flyoutPanelNotifications.Location = new System.Drawing.Point(249, 368);
            this.flyoutPanelNotifications.Name = "flyoutPanelNotifications";
            this.flyoutPanelNotifications.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanelNotifications.OwnerControl = this.fluentDesignFormContainer;
            this.flyoutPanelNotifications.Size = new System.Drawing.Size(290, 151);
            this.flyoutPanelNotifications.TabIndex = 4;
            
            
            
            this.flyoutPanelControl4.Controls.Add(this.accordionControl2);
            this.flyoutPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl4.FlyoutPanel = this.flyoutPanelNotifications;
            this.flyoutPanelControl4.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl4.Name = "flyoutPanelControl4";
            this.flyoutPanelControl4.Size = new System.Drawing.Size(290, 151);
            this.flyoutPanelControl4.TabIndex = 0;
            
            
            
            this.accordionControl2.Appearance.Group.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl2.Appearance.Group.Disabled.Options.UseFont = true;
            this.accordionControl2.Appearance.Group.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl2.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl2.Appearance.Group.Normal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl2.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl2.Appearance.Group.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl2.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionControl2.Appearance.Item.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl2.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordionControl2.Appearance.Item.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl2.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl2.Appearance.Item.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl2.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl2.Appearance.Item.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl2.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl2.Controls.Add(this.accordionContentContainer3);
            this.accordionControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.notificationsHeader});
            this.accordionControl2.ExpandGroupOnHeaderClick = false;
            this.accordionControl2.ExpandItemOnHeaderClick = false;
            this.accordionControl2.Location = new System.Drawing.Point(2, 2);
            this.accordionControl2.Name = "accordionControl2";
            this.accordionControl2.ShowGroupExpandButtons = false;
            this.accordionControl2.ShowItemExpandButtons = false;
            this.accordionControl2.Size = new System.Drawing.Size(286, 147);
            this.accordionControl2.TabIndex = 0;
            this.accordionControl2.Text = "accordionControl2";
            
            
            
            this.accordionContentContainer3.Controls.Add(this.toggleSwitch1);
            this.accordionContentContainer3.Name = "accordionContentContainer3";
            this.accordionContentContainer3.Padding = new System.Windows.Forms.Padding(10, 10, 20, 20);
            this.accordionContentContainer3.Size = new System.Drawing.Size(269, 54);
            this.accordionContentContainer3.TabIndex = 1;
            
            
            
            this.toggleSwitch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleSwitch1.Location = new System.Drawing.Point(10, 10);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.AllowFocused = false;
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(239, 24);
            this.toggleSwitch1.TabIndex = 0;
            
            
            
            this.notificationsHeader.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.notificationsHeader.Appearance.Disabled.Options.UseFont = true;
            this.notificationsHeader.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.notificationsHeader.Appearance.Hovered.Options.UseFont = true;
            this.notificationsHeader.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.notificationsHeader.Appearance.Normal.Options.UseFont = true;
            this.notificationsHeader.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.notificationsHeader.Appearance.Pressed.Options.UseFont = true;
            this.notificationsHeader.ContentContainer = this.accordionContentContainer3;
            this.notificationsHeader.Expanded = true;
            this.notificationsHeader.Name = "notificationsHeader";
            this.notificationsHeader.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.notificationsHeader.Text = "Show notifications";
            
            
            
            this.flyoutPanelFocuedInboxSettings.Controls.Add(this.flyoutPanelControl3);
            this.flyoutPanelFocuedInboxSettings.Location = new System.Drawing.Point(247, 198);
            this.flyoutPanelFocuedInboxSettings.Margin = new System.Windows.Forms.Padding(2);
            this.flyoutPanelFocuedInboxSettings.Name = "flyoutPanelFocuedInboxSettings";
            this.flyoutPanelFocuedInboxSettings.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanelFocuedInboxSettings.OptionsButtonPanel.ButtonPanelHeight = 21;
            this.flyoutPanelFocuedInboxSettings.OwnerControl = this.fluentDesignFormContainer;
            this.flyoutPanelFocuedInboxSettings.Size = new System.Drawing.Size(290, 129);
            this.flyoutPanelFocuedInboxSettings.TabIndex = 3;
            
            
            
            this.flyoutPanelControl3.Controls.Add(this.accordionControl1);
            this.flyoutPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl3.FlyoutPanel = null;
            this.flyoutPanelControl3.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl3.Name = "flyoutPanelControl3";
            this.flyoutPanelControl3.Size = new System.Drawing.Size(290, 129);
            this.flyoutPanelControl3.TabIndex = 0;
            
            
            
            this.accordionControl1.Appearance.Group.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl1.Appearance.Group.Disabled.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl1.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl1.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl1.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl1.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl1.ContentTopIndent = 0;
            this.accordionControl1.Controls.Add(this.accordionContentContainer2);
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.focusedInboxAccordionTitle});
            this.accordionControl1.ExpandGroupOnHeaderClick = false;
            this.accordionControl1.ExpandItemOnHeaderClick = false;
            this.accordionControl1.Location = new System.Drawing.Point(2, 2);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ShowGroupExpandButtons = false;
            this.accordionControl1.ShowItemExpandButtons = false;
            this.accordionControl1.Size = new System.Drawing.Size(286, 125);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            
            
            
            this.accordionContentContainer2.Controls.Add(this.showFocusedOtherFilterToggle);
            this.accordionContentContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.accordionContentContainer2.Name = "accordionContentContainer2";
            this.accordionContentContainer2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.accordionContentContainer2.Size = new System.Drawing.Size(269, 44);
            this.accordionContentContainer2.TabIndex = 1;
            
            
            
            this.showFocusedOtherFilterToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showFocusedOtherFilterToggle.Location = new System.Drawing.Point(20, 10);
            this.showFocusedOtherFilterToggle.Margin = new System.Windows.Forms.Padding(2);
            this.showFocusedOtherFilterToggle.Name = "showFocusedOtherFilterToggle";
            this.showFocusedOtherFilterToggle.Properties.AllowFocused = false;
            this.showFocusedOtherFilterToggle.Properties.OffText = "Off";
            this.showFocusedOtherFilterToggle.Properties.OnText = "On";
            this.showFocusedOtherFilterToggle.Size = new System.Drawing.Size(229, 24);
            this.showFocusedOtherFilterToggle.TabIndex = 0;
            
            
            
            this.focusedInboxAccordionTitle.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.focusedInboxAccordionTitle.Appearance.Disabled.Options.UseFont = true;
            this.focusedInboxAccordionTitle.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.focusedInboxAccordionTitle.Appearance.Hovered.Options.UseFont = true;
            this.focusedInboxAccordionTitle.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.focusedInboxAccordionTitle.Appearance.Normal.Options.UseFont = true;
            this.focusedInboxAccordionTitle.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.focusedInboxAccordionTitle.Appearance.Pressed.Options.UseFont = true;
            this.focusedInboxAccordionTitle.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement8});
            this.focusedInboxAccordionTitle.Expanded = true;
            this.focusedInboxAccordionTitle.Name = "focusedInboxAccordionTitle";
            this.focusedInboxAccordionTitle.Text = "Focused Inbox";
            
            
            
            this.accordionControlElement8.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControlElement8.Appearance.Disabled.Options.UseFont = true;
            this.accordionControlElement8.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControlElement8.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement8.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControlElement8.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement8.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControlElement8.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement8.ContentContainer = this.accordionContentContainer2;
            this.accordionControlElement8.Expanded = true;
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Sort messsages into Focused and Other";
            
            
            
            this.flyoutPanelAccounts.Controls.Add(this.flyoutPanelControl2);
            this.flyoutPanelAccounts.Location = new System.Drawing.Point(245, 34);
            this.flyoutPanelAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.flyoutPanelAccounts.Name = "flyoutPanelAccounts";
            this.flyoutPanelAccounts.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanelAccounts.OptionsButtonPanel.ButtonPanelHeight = 21;
            this.flyoutPanelAccounts.OwnerControl = this.fluentDesignFormContainer;
            this.flyoutPanelAccounts.Size = new System.Drawing.Size(290, 151);
            this.flyoutPanelAccounts.TabIndex = 2;
            
            
            
            this.flyoutPanelControl2.Controls.Add(this.accordionAccounts);
            this.flyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl2.FlyoutPanel = null;
            this.flyoutPanelControl2.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl2.Name = "flyoutPanelControl2";
            this.flyoutPanelControl2.Size = new System.Drawing.Size(290, 151);
            this.flyoutPanelControl2.TabIndex = 0;
            
            
            
            this.accordionAccounts.Appearance.Group.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionAccounts.Appearance.Group.Disabled.Options.UseFont = true;
            this.accordionAccounts.Appearance.Group.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionAccounts.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionAccounts.Appearance.Group.Normal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionAccounts.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionAccounts.Appearance.Group.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionAccounts.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionAccounts.Appearance.Item.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionAccounts.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordionAccounts.Appearance.Item.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionAccounts.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionAccounts.Appearance.Item.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionAccounts.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionAccounts.Appearance.Item.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionAccounts.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionAccounts.ContentTopIndent = 0;
            this.accordionAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionAccounts.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceManageAccountsTitle});
            this.accordionAccounts.ExpandGroupOnHeaderClick = false;
            this.accordionAccounts.ExpandItemOnHeaderClick = false;
            this.accordionAccounts.Location = new System.Drawing.Point(2, 2);
            this.accordionAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.accordionAccounts.Name = "accordionAccounts";
            this.accordionAccounts.ShowGroupExpandButtons = false;
            this.accordionAccounts.ShowItemExpandButtons = false;
            this.accordionAccounts.Size = new System.Drawing.Size(286, 147);
            this.accordionAccounts.TabIndex = 0;
            this.accordionAccounts.Text = "accordionAccounts";
            
            
            
            this.aceManageAccountsTitle.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.elementAccount,
            this.linkInboxedElement,
            this.addAccountElement});
            this.aceManageAccountsTitle.Expanded = true;
            this.aceManageAccountsTitle.Name = "aceManageAccountsTitle";
            this.aceManageAccountsTitle.Text = "Manage accounts";
            
            
            
            this.elementAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementAccount.ImageOptions.SvgImage")));
            this.elementAccount.Name = "elementAccount";
            this.elementAccount.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elementAccount.Text = "maildemo@dx-mail.com";
            
            
            
            this.linkInboxedElement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("linkInboxedElement.ImageOptions.SvgImage")));
            this.linkInboxedElement.Name = "linkInboxedElement";
            this.linkInboxedElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.linkInboxedElement.Text = "Link inboxes";
            
            
            
            this.addAccountElement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("addAccountElement.ImageOptions.SvgImage")));
            this.addAccountElement.Name = "addAccountElement";
            this.addAccountElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.addAccountElement.Text = "Add account";
            
            
            
            this.flyoutPanelSettings.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanelSettings.Location = new System.Drawing.Point(613, 34);
            this.flyoutPanelSettings.Margin = new System.Windows.Forms.Padding(2);
            this.flyoutPanelSettings.Name = "flyoutPanelSettings";
            this.flyoutPanelSettings.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanelSettings.OptionsButtonPanel.ButtonPanelHeight = 21;
            this.flyoutPanelSettings.OwnerControl = this.fluentDesignFormContainer;
            this.flyoutPanelSettings.Size = new System.Drawing.Size(290, 151);
            this.flyoutPanelSettings.TabIndex = 1;
            
            
            
            this.flyoutPanelControl1.Controls.Add(this.accordionSettings);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = null;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(290, 151);
            this.flyoutPanelControl1.TabIndex = 0;
            
            
            
            this.accordionSettings.Appearance.Group.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionSettings.Appearance.Group.Disabled.Options.UseFont = true;
            this.accordionSettings.Appearance.Group.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionSettings.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionSettings.Appearance.Group.Normal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionSettings.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionSettings.Appearance.Group.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionSettings.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionSettings.Appearance.Item.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionSettings.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordionSettings.Appearance.Item.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionSettings.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionSettings.Appearance.Item.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionSettings.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionSettings.Appearance.Item.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionSettings.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionSettings.ContentTopIndent = 0;
            this.accordionSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionSettings.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement13});
            this.accordionSettings.ExpandGroupOnHeaderClick = false;
            this.accordionSettings.Location = new System.Drawing.Point(2, 2);
            this.accordionSettings.Margin = new System.Windows.Forms.Padding(2);
            this.accordionSettings.Name = "accordionSettings";
            this.accordionSettings.ShowGroupExpandButtons = false;
            this.accordionSettings.Size = new System.Drawing.Size(286, 147);
            this.accordionSettings.TabIndex = 0;
            this.accordionSettings.Text = "accordionControl2";
            
            
            
            this.accordionControlElement13.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.manageAccountsElement,
            this.personalizationElement,
            this.automaticRepliesElement,
            this.focusedInboxElement,
            this.messageListElement,
            this.readingPaneElement,
            this.signatureElement,
            this.notificationsElement,
            this.emailSecurityElement,
            this.wnElement,
            this.oulookAndiOSElement,
            this.helpElement,
            this.trustCenterElement,
            this.feedbackElement,
            this.aboutElement});
            this.accordionControlElement13.Expanded = true;
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Text = "Settings";
            
            
            
            this.manageAccountsElement.Name = "manageAccountsElement";
            this.manageAccountsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.manageAccountsElement.Text = "Manage accounts";
            
            
            
            this.personalizationElement.Name = "personalizationElement";
            this.personalizationElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.personalizationElement.Text = "Personalization";
            
            
            
            this.automaticRepliesElement.Name = "automaticRepliesElement";
            this.automaticRepliesElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.automaticRepliesElement.Text = "Automatic replies";
            this.automaticRepliesElement.Visible = false;
            
            
            
            this.focusedInboxElement.Name = "focusedInboxElement";
            this.focusedInboxElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.focusedInboxElement.Text = "Focused Inbox";
            
            
            
            this.messageListElement.Name = "messageListElement";
            this.messageListElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.messageListElement.Text = "Message list";
            this.messageListElement.Visible = false;
            
            
            
            this.readingPaneElement.Name = "readingPaneElement";
            this.readingPaneElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.readingPaneElement.Text = "Reading pane";
            this.readingPaneElement.Visible = false;
            
            
            
            this.signatureElement.Name = "signatureElement";
            this.signatureElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.signatureElement.Text = "Signature";
            
            
            
            this.notificationsElement.Name = "notificationsElement";
            this.notificationsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.notificationsElement.Text = "Notifications";
            this.notificationsElement.Visible = false;
            
            
            
            this.emailSecurityElement.Name = "emailSecurityElement";
            this.emailSecurityElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.emailSecurityElement.Text = "Email security";
            this.emailSecurityElement.Visible = false;
            
            
            
            this.wnElement.Name = "wnElement";
            this.wnElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.wnElement.Text = "What\'s new";
            
            
            
            this.oulookAndiOSElement.Name = "oulookAndiOSElement";
            this.oulookAndiOSElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.oulookAndiOSElement.Text = "Outlook for Android and iOS";
            this.oulookAndiOSElement.Visible = false;
            
            
            
            this.helpElement.Name = "helpElement";
            this.helpElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.helpElement.Text = "Help";
            
            
            
            this.trustCenterElement.Name = "trustCenterElement";
            this.trustCenterElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.trustCenterElement.Text = "Trust Center";
            this.trustCenterElement.Visible = false;
            
            
            
            this.feedbackElement.Name = "feedbackElement";
            this.feedbackElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.feedbackElement.Text = "Feedback";
            
            
            
            this.aboutElement.Name = "aboutElement";
            this.aboutElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aboutElement.Text = "About";
            this.aboutElement.Visible = false;
            
            
            
            this.flyoutPanelFolders.Controls.Add(this.accordionFolders);
            this.flyoutPanelFolders.Location = new System.Drawing.Point(611, 199);
            this.flyoutPanelFolders.Margin = new System.Windows.Forms.Padding(2);
            this.flyoutPanelFolders.Name = "flyoutPanelFolders";
            this.flyoutPanelFolders.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Left;
            this.flyoutPanelFolders.OptionsButtonPanel.ButtonPanelHeight = 21;
            this.flyoutPanelFolders.OwnerControl = this.fluentDesignFormContainer;
            this.flyoutPanelFolders.ParentForm = this;
            this.flyoutPanelFolders.Size = new System.Drawing.Size(290, 127);
            this.flyoutPanelFolders.TabIndex = 0;
            
            
            
            this.accordionFolders.AllowItemSelection = true;
            this.accordionFolders.Appearance.Group.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionFolders.Appearance.Group.Disabled.Options.UseFont = true;
            this.accordionFolders.Appearance.Group.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionFolders.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionFolders.Appearance.Group.Normal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionFolders.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionFolders.Appearance.Group.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionFolders.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionFolders.Appearance.Item.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionFolders.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordionFolders.Appearance.Item.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionFolders.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionFolders.Appearance.Item.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionFolders.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionFolders.Appearance.Item.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionFolders.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionFolders.ContentTopIndent = 30;
            this.accordionFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionFolders.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2});
            this.accordionFolders.ExpandGroupOnHeaderClick = false;
            this.accordionFolders.Location = new System.Drawing.Point(0, 0);
            this.accordionFolders.Margin = new System.Windows.Forms.Padding(0);
            this.accordionFolders.Name = "accordionFolders";
            this.accordionFolders.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.accordionFolders.ShowGroupExpandButtons = false;
            this.accordionFolders.Size = new System.Drawing.Size(290, 127);
            this.accordionFolders.TabIndex = 0;
            this.accordionFolders.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            
            
            
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.outboxElement,
            this.inboxElement,
            this.archiveElement,
            this.archive1Element,
            this.clutterElement,
            this.convHistoryElement,
            this.deletedItemsElement,
            this.draftsElement,
            this.junkEmailElement,
            this.sentItemsElement});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "All Folders";
            
            
            
            this.outboxElement.Name = "outboxElement";
            this.outboxElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.outboxElement.Tag = 6;
            this.outboxElement.Text = "Outbox";
            
            
            
            this.inboxElement.Name = "inboxElement";
            this.inboxElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.inboxElement.Tag = 7;
            this.inboxElement.Text = "Inbox";
            
            
            
            this.archiveElement.Name = "archiveElement";
            this.archiveElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.archiveElement.Tag = 8;
            this.archiveElement.Text = "Archive";
            
            
            
            this.archive1Element.Name = "archive1Element";
            this.archive1Element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.archive1Element.Tag = 9;
            this.archive1Element.Text = "Archive 1";
            
            
            
            this.clutterElement.Name = "clutterElement";
            this.clutterElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.clutterElement.Tag = 10;
            this.clutterElement.Text = "Clutter";
            
            
            
            this.convHistoryElement.Name = "convHistoryElement";
            this.convHistoryElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.convHistoryElement.Text = "Conversation history";
            this.convHistoryElement.Visible = false;
            
            
            
            this.deletedItemsElement.Name = "deletedItemsElement";
            this.deletedItemsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.deletedItemsElement.Tag = 11;
            this.deletedItemsElement.Text = "Deleted Items";
            
            
            
            this.draftsElement.Name = "draftsElement";
            this.draftsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.draftsElement.Tag = 4;
            this.draftsElement.Text = "Drafts";
            
            
            
            this.junkEmailElement.Name = "junkEmailElement";
            this.junkEmailElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.junkEmailElement.Text = "Junk Email";
            this.junkEmailElement.Visible = false;
            
            
            
            this.sentItemsElement.Name = "sentItemsElement";
            this.sentItemsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sentItemsElement.Tag = 5;
            this.sentItemsElement.Text = "Sent Items";
            
            
            
            this.accordionControl.AllowItemSelection = true;
            this.accordionControl.Appearance.AccordionControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl.Appearance.Group.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl.Appearance.Group.Disabled.Options.UseFont = true;
            this.accordionControl.Appearance.Group.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl.Appearance.Group.Hovered.Options.UseFont = true;
            this.accordionControl.Appearance.Group.Normal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl.Appearance.Group.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accordionControl.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionControl.Appearance.Hint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl.Appearance.Hint.Options.UseFont = true;
            this.accordionControl.Appearance.Item.Disabled.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordionControl.Appearance.Item.Hovered.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl.Appearance.Item.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl.Appearance.Item.Pressed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.accordionControl.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl.Controls.Add(this.accordionContentContainer1);
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.elementMail,
            this.elementCalendar,
            this.elementPeople,
            this.elementSettings});
            this.accordionControl.ExpandGroupOnHeaderClick = false;
            this.accordionControl.ExpandItemOnHeaderClick = false;
            this.accordionControl.Location = new System.Drawing.Point(0, 31);
            this.accordionControl.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.OptionsMinimizing.NormalWidth = 341;
            this.accordionControl.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl.ShowGroupExpandButtons = false;
            this.accordionControl.ShowItemExpandButtons = false;
            this.accordionControl.ShowToolTips = false;
            this.accordionControl.Size = new System.Drawing.Size(341, 739);
            this.accordionControl.TabIndex = 1;
            this.accordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl.CustomDrawElement += new DevExpress.XtraBars.Navigation.CustomDrawElementEventHandler(this.accordionControl_CustomDrawElement);
            
            
            
            this.accordionContentContainer1.Controls.Add(this.calendarControl1);
            this.accordionContentContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionContentContainer1.Name = "accordionContentContainer1";
            this.accordionContentContainer1.Size = new System.Drawing.Size(324, 349);
            this.accordionContentContainer1.TabIndex = 3;
            
            
            
            this.calendarControl1.AutoSize = false;
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.DateTime = new System.DateTime(2018, 6, 10, 0, 0, 0, 0);
            this.calendarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarControl1.EditValue = new System.DateTime(2018, 6, 10, 0, 0, 0, 0);
            this.calendarControl1.Location = new System.Drawing.Point(0, 0);
            this.calendarControl1.Margin = new System.Windows.Forms.Padding(2);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.calendarControl1.Size = new System.Drawing.Size(324, 349);
            this.calendarControl1.TabIndex = 0;
            
            
            
            this.elementMail.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.elementNewMail,
            this.elementAccounts,
            this.elementFolders});
            this.elementMail.Expanded = true;
            this.elementMail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementMail.ImageOptions.SvgImage")));
            this.elementMail.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.elementMail.Name = "elementMail";
            this.elementMail.Tag = 3;
            this.elementMail.Text = "Element1";
            
            
            
            this.elementNewMail.Height = -1;
            this.elementNewMail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementNewMail.ImageOptions.SvgImage")));
            this.elementNewMail.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.elementNewMail.Name = "elementNewMail";
            this.elementNewMail.Tag = 1;
            this.elementNewMail.Text = "New mail";
            
            
            
            this.elementAccounts.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6});
            this.elementAccounts.Expanded = true;
            this.elementAccounts.Height = -1;
            this.elementAccounts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementAccounts.ImageOptions.SvgImage")));
            this.elementAccounts.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.elementAccounts.Name = "elementAccounts";
            this.elementAccounts.Tag = 2;
            this.elementAccounts.Text = "Accounts";
            
            
            
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Tag = "Account";
            this.accordionControlElement6.Text = "maildemo@dx-mail.com";
            
            
            
            this.elementFolders.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.foldersDrafts,
            this.foldersSentItems,
            this.foldersMore});
            this.elementFolders.Expanded = true;
            this.elementFolders.Height = -1;
            this.elementFolders.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementFolders.ImageOptions.SvgImage")));
            this.elementFolders.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.elementFolders.Name = "elementFolders";
            this.elementFolders.Tag = 3;
            this.elementFolders.Text = "Folders";
            
            
            
            this.foldersDrafts.Name = "foldersDrafts";
            this.foldersDrafts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.foldersDrafts.Tag = 4;
            this.foldersDrafts.Text = "Drafts";
            
            
            
            this.foldersSentItems.Name = "foldersSentItems";
            this.foldersSentItems.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.foldersSentItems.Tag = 5;
            this.foldersSentItems.Text = "Sent Items";
            
            
            
            this.foldersMore.Name = "foldersMore";
            this.foldersMore.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.foldersMore.Tag = 33;
            this.foldersMore.Text = "More";
            
            
            
            this.elementCalendar.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.elementNewEvent,
            this.accordionControlElement1,
            this.accordionControlElement3});
            this.elementCalendar.Expanded = true;
            this.elementCalendar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementCalendar.ImageOptions.SvgImage")));
            this.elementCalendar.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.elementCalendar.Name = "elementCalendar";
            this.elementCalendar.Tag = 15;
            this.elementCalendar.Text = "Calendar";
            
            
            
            this.elementNewEvent.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement7});
            this.elementNewEvent.Expanded = true;
            this.elementNewEvent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementNewEvent.ImageOptions.SvgImage")));
            this.elementNewEvent.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.elementNewEvent.Name = "elementNewEvent";
            this.elementNewEvent.Text = "New event";
            
            
            
            this.accordionControlElement7.ContentContainer = this.accordionContentContainer1;
            this.accordionControlElement7.Expanded = true;
            this.accordionControlElement7.HeaderVisible = false;
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            
            
            
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement4});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "DevExpress";
            
            
            
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Calendar";
            
            
            
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement5});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Microsoft Account";
            this.accordionControlElement3.Visible = false;
            
            
            
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Calendar";
            
            
            
            this.elementPeople.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementPeople.ImageOptions.SvgImage")));
            this.elementPeople.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.elementPeople.Name = "elementPeople";
            this.elementPeople.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elementPeople.Text = "People";
            
            
            
            this.elementSettings.ControlFooterAlignment = DevExpress.XtraBars.Navigation.AccordionItemFooterAlignment.Far;
            this.elementSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("elementSettings.ImageOptions.SvgImage")));
            this.elementSettings.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.elementSettings.Name = "elementSettings";
            this.elementSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elementSettings.Text = "Settings";
            
            
            
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1472, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            
            
            
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.WindowsMailClient.Win.ViewModels.MainViewModel);
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 766);
            this.ControlContainer = this.fluentDesignFormContainer;
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.accordionControl);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.fluentDesignFormContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelNotifications)).EndInit();
            this.flyoutPanelNotifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl4)).EndInit();
            this.flyoutPanelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).EndInit();
            this.accordionControl2.ResumeLayout(false);
            this.accordionContentContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelFocuedInboxSettings)).EndInit();
            this.flyoutPanelFocuedInboxSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl3)).EndInit();
            this.flyoutPanelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.accordionControl1.ResumeLayout(false);
            this.accordionContentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showFocusedOtherFilterToggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelAccounts)).EndInit();
            this.flyoutPanelAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).EndInit();
            this.flyoutPanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelSettings)).EndInit();
            this.flyoutPanelSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelFolders)).EndInit();
            this.flyoutPanelFolders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            this.accordionControl.ResumeLayout(false);
            this.accordionContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementNewMail;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementAccounts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementFolders;
        private DevExpress.XtraBars.Navigation.AccordionControlElement foldersDrafts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement foldersSentItems;
        private DevExpress.XtraBars.Navigation.AccordionControlElement foldersMore;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementMail;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementCalendar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementPeople;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement outboxElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement inboxElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement archiveElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement archive1Element;
        private DevExpress.XtraBars.Navigation.AccordionControlElement clutterElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement convHistoryElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement deletedItemsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement draftsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement junkEmailElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sentItemsElement;
        private DevExpress.Utils.FlyoutPanel flyoutPanelSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
        private DevExpress.XtraBars.Navigation.AccordionControlElement manageAccountsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement personalizationElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement automaticRepliesElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement focusedInboxElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement messageListElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement readingPaneElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement signatureElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement notificationsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement emailSecurityElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement wnElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement oulookAndiOSElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement helpElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement trustCenterElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement feedbackElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aboutElement;
        private DevExpress.Utils.FlyoutPanel flyoutPanelAccounts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceManageAccountsTitle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement linkInboxedElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement addAccountElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementNewEvent;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementAccount;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private DevExpress.Utils.FlyoutPanel flyoutPanelFocuedInboxSettings;
        private MailClientPanelAccordionControl accordionControl1;
        private XtraBars.Navigation.AccordionControlElement focusedInboxAccordionTitle;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer2;
        private ToggleSwitch showFocusedOtherFilterToggle;
        private XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private XtraBars.Navigation.AccordionControl accordionControl2;
        private XtraBars.Navigation.AccordionControlElement notificationsHeader;
        private XtraBars.Navigation.AccordionContentContainer accordionContentContainer3;
        private ToggleSwitch toggleSwitch1;
        private DevExpress.Utils.FlyoutPanel flyoutPanelNotifications;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl4;
        private VerticalTopFlyoutPanel flyoutPanelFolders;
        private MailClientPanelAccordionControl accordionFolders;
        private MailClientPanelAccordionControl accordionSettings;
        private MailClientPanelAccordionControl accordionAccounts;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl3;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl2;
    }
}
