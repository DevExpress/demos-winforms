Imports DevExpress.Utils
Imports DevExpress.WindowsMailClient.Win.Controls
Imports DevExpress.WindowsMailClient.Win.ViewModels
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors

Namespace DevExpress.WindowsMailClient.Win

    Partial Class MainForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.WindowsMailClient.Win.MainForm))
            Me.fluentDesignFormContainer = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
            Me.flyoutPanelNotifications = New DevExpress.Utils.FlyoutPanel()
            Me.flyoutPanelControl4 = New DevExpress.Utils.FlyoutPanelControl()
            Me.accordionControl2 = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionContentContainer3 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.toggleSwitch1 = New DevExpress.XtraEditors.ToggleSwitch()
            Me.notificationsHeader = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.flyoutPanelFocuedInboxSettings = New DevExpress.Utils.FlyoutPanel()
            Me.flyoutPanelControl3 = New DevExpress.Utils.FlyoutPanelControl()
            Me.accordionControl1 = New DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl()
            Me.accordionContentContainer2 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.showFocusedOtherFilterToggle = New DevExpress.XtraEditors.ToggleSwitch()
            Me.focusedInboxAccordionTitle = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement8 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.flyoutPanelAccounts = New DevExpress.Utils.FlyoutPanel()
            Me.flyoutPanelControl2 = New DevExpress.Utils.FlyoutPanelControl()
            Me.accordionAccounts = New DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl()
            Me.aceManageAccountsTitle = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.elementAccount = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.linkInboxedElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.addAccountElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.flyoutPanelSettings = New DevExpress.Utils.FlyoutPanel()
            Me.flyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
            Me.accordionSettings = New DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl()
            Me.accordionControlElement13 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.manageAccountsElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.personalizationElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.automaticRepliesElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.focusedInboxElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.messageListElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.readingPaneElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.signatureElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.notificationsElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.emailSecurityElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.wnElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.oulookAndiOSElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.helpElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.trustCenterElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.feedbackElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.aboutElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.flyoutPanelFolders = New DevExpress.WindowsMailClient.Win.Controls.VerticalTopFlyoutPanel()
            Me.accordionFolders = New DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl()
            Me.accordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.outboxElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.inboxElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.archiveElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.archive1Element = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.clutterElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.convHistoryElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.deletedItemsElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.draftsElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.junkEmailElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.sentItemsElement = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControl = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionContentContainer1 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.calendarControl1 = New DevExpress.XtraEditors.Controls.CalendarControl()
            Me.elementMail = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.elementNewMail = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.elementAccounts = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement6 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.elementFolders = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.foldersDrafts = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.foldersSentItems = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.foldersMore = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.elementCalendar = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.elementNewEvent = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement7 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement5 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.elementPeople = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.elementSettings = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.fluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.fluentDesignFormContainer.SuspendLayout()
            CType((Me.flyoutPanelNotifications), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanelNotifications.SuspendLayout()
            CType((Me.flyoutPanelControl4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanelControl4.SuspendLayout()
            CType((Me.accordionControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionControl2.SuspendLayout()
            Me.accordionContentContainer3.SuspendLayout()
            CType((Me.toggleSwitch1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.flyoutPanelFocuedInboxSettings), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanelFocuedInboxSettings.SuspendLayout()
            CType((Me.flyoutPanelControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanelControl3.SuspendLayout()
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionControl1.SuspendLayout()
            Me.accordionContentContainer2.SuspendLayout()
            CType((Me.showFocusedOtherFilterToggle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.flyoutPanelAccounts), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanelAccounts.SuspendLayout()
            CType((Me.flyoutPanelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanelControl2.SuspendLayout()
            CType((Me.accordionAccounts), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.flyoutPanelSettings), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanelSettings.SuspendLayout()
            CType((Me.flyoutPanelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanelControl1.SuspendLayout()
            CType((Me.accordionSettings), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.flyoutPanelFolders), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanelFolders.SuspendLayout()
            CType((Me.accordionFolders), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.accordionControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionControl.SuspendLayout()
            Me.accordionContentContainer1.SuspendLayout()
            CType((Me.calendarControl1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.fluentDesignFormControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.fluentDesignFormContainer.Controls.Add(Me.flyoutPanelNotifications)
            Me.fluentDesignFormContainer.Controls.Add(Me.flyoutPanelFocuedInboxSettings)
            Me.fluentDesignFormContainer.Controls.Add(Me.flyoutPanelAccounts)
            Me.fluentDesignFormContainer.Controls.Add(Me.flyoutPanelSettings)
            Me.fluentDesignFormContainer.Controls.Add(Me.flyoutPanelFolders)
            Me.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fluentDesignFormContainer.Location = New System.Drawing.Point(341, 31)
            Me.fluentDesignFormContainer.Name = "fluentDesignFormContainer"
            Me.fluentDesignFormContainer.Size = New System.Drawing.Size(1131, 739)
            Me.fluentDesignFormContainer.TabIndex = 0
            Me.flyoutPanelNotifications.Controls.Add(Me.flyoutPanelControl4)
            Me.flyoutPanelNotifications.Location = New System.Drawing.Point(249, 368)
            Me.flyoutPanelNotifications.Name = "flyoutPanelNotifications"
            Me.flyoutPanelNotifications.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right
            Me.flyoutPanelNotifications.OwnerControl = Me.fluentDesignFormContainer
            Me.flyoutPanelNotifications.Size = New System.Drawing.Size(290, 151)
            Me.flyoutPanelNotifications.TabIndex = 4
            Me.flyoutPanelControl4.Controls.Add(Me.accordionControl2)
            Me.flyoutPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flyoutPanelControl4.FlyoutPanel = Me.flyoutPanelNotifications
            Me.flyoutPanelControl4.Location = New System.Drawing.Point(0, 0)
            Me.flyoutPanelControl4.Name = "flyoutPanelControl4"
            Me.flyoutPanelControl4.Size = New System.Drawing.Size(290, 151)
            Me.flyoutPanelControl4.TabIndex = 0
            Me.accordionControl2.Appearance.Group.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl2.Appearance.Group.Disabled.Options.UseFont = True
            Me.accordionControl2.Appearance.Group.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl2.Appearance.Group.Hovered.Options.UseFont = True
            Me.accordionControl2.Appearance.Group.Normal.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl2.Appearance.Group.Normal.Options.UseFont = True
            Me.accordionControl2.Appearance.Group.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl2.Appearance.Group.Pressed.Options.UseFont = True
            Me.accordionControl2.Appearance.Item.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl2.Appearance.Item.Disabled.Options.UseFont = True
            Me.accordionControl2.Appearance.Item.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl2.Appearance.Item.Hovered.Options.UseFont = True
            Me.accordionControl2.Appearance.Item.Normal.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl2.Appearance.Item.Normal.Options.UseFont = True
            Me.accordionControl2.Appearance.Item.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl2.Appearance.Item.Pressed.Options.UseFont = True
            Me.accordionControl2.Controls.Add(Me.accordionContentContainer3)
            Me.accordionControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControl2.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.notificationsHeader})
            Me.accordionControl2.ExpandGroupOnHeaderClick = False
            Me.accordionControl2.ExpandItemOnHeaderClick = False
            Me.accordionControl2.Location = New System.Drawing.Point(2, 2)
            Me.accordionControl2.Name = "accordionControl2"
            Me.accordionControl2.ShowGroupExpandButtons = False
            Me.accordionControl2.ShowItemExpandButtons = False
            Me.accordionControl2.Size = New System.Drawing.Size(286, 147)
            Me.accordionControl2.TabIndex = 0
            Me.accordionControl2.Text = "accordionControl2"
            Me.accordionContentContainer3.Controls.Add(Me.toggleSwitch1)
            Me.accordionContentContainer3.Name = "accordionContentContainer3"
            Me.accordionContentContainer3.Padding = New System.Windows.Forms.Padding(10, 10, 20, 20)
            Me.accordionContentContainer3.Size = New System.Drawing.Size(269, 54)
            Me.accordionContentContainer3.TabIndex = 1
            Me.toggleSwitch1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toggleSwitch1.Location = New System.Drawing.Point(10, 10)
            Me.toggleSwitch1.Name = "toggleSwitch1"
            Me.toggleSwitch1.Properties.AllowFocused = False
            Me.toggleSwitch1.Properties.OffText = "Off"
            Me.toggleSwitch1.Properties.OnText = "On"
            Me.toggleSwitch1.Size = New System.Drawing.Size(239, 24)
            Me.toggleSwitch1.TabIndex = 0
            Me.notificationsHeader.Appearance.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.notificationsHeader.Appearance.Disabled.Options.UseFont = True
            Me.notificationsHeader.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.notificationsHeader.Appearance.Hovered.Options.UseFont = True
            Me.notificationsHeader.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.notificationsHeader.Appearance.Normal.Options.UseFont = True
            Me.notificationsHeader.Appearance.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.notificationsHeader.Appearance.Pressed.Options.UseFont = True
            Me.notificationsHeader.ContentContainer = Me.accordionContentContainer3
            Me.notificationsHeader.Expanded = True
            Me.notificationsHeader.Name = "notificationsHeader"
            Me.notificationsHeader.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.notificationsHeader.Text = "Show notifications"
            Me.flyoutPanelFocuedInboxSettings.Controls.Add(Me.flyoutPanelControl3)
            Me.flyoutPanelFocuedInboxSettings.Location = New System.Drawing.Point(247, 198)
            Me.flyoutPanelFocuedInboxSettings.Margin = New System.Windows.Forms.Padding(2)
            Me.flyoutPanelFocuedInboxSettings.Name = "flyoutPanelFocuedInboxSettings"
            Me.flyoutPanelFocuedInboxSettings.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right
            Me.flyoutPanelFocuedInboxSettings.OptionsButtonPanel.ButtonPanelHeight = 21
            Me.flyoutPanelFocuedInboxSettings.OwnerControl = Me.fluentDesignFormContainer
            Me.flyoutPanelFocuedInboxSettings.Size = New System.Drawing.Size(290, 129)
            Me.flyoutPanelFocuedInboxSettings.TabIndex = 3
            Me.flyoutPanelControl3.Controls.Add(Me.accordionControl1)
            Me.flyoutPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flyoutPanelControl3.FlyoutPanel = Nothing
            Me.flyoutPanelControl3.Location = New System.Drawing.Point(0, 0)
            Me.flyoutPanelControl3.Name = "flyoutPanelControl3"
            Me.flyoutPanelControl3.Size = New System.Drawing.Size(290, 129)
            Me.flyoutPanelControl3.TabIndex = 0
            Me.accordionControl1.Appearance.Group.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl1.Appearance.Group.Disabled.Options.UseFont = True
            Me.accordionControl1.Appearance.Group.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl1.Appearance.Group.Hovered.Options.UseFont = True
            Me.accordionControl1.Appearance.Group.Normal.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl1.Appearance.Group.Normal.Options.UseFont = True
            Me.accordionControl1.Appearance.Group.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl1.Appearance.Group.Pressed.Options.UseFont = True
            Me.accordionControl1.Appearance.Item.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl1.Appearance.Item.Disabled.Options.UseFont = True
            Me.accordionControl1.Appearance.Item.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl1.Appearance.Item.Hovered.Options.UseFont = True
            Me.accordionControl1.Appearance.Item.Normal.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl1.Appearance.Item.Normal.Options.UseFont = True
            Me.accordionControl1.Appearance.Item.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl1.Appearance.Item.Pressed.Options.UseFont = True
            Me.accordionControl1.ContentTopIndent = 0
            Me.accordionControl1.Controls.Add(Me.accordionContentContainer2)
            Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.focusedInboxAccordionTitle})
            Me.accordionControl1.ExpandGroupOnHeaderClick = False
            Me.accordionControl1.ExpandItemOnHeaderClick = False
            Me.accordionControl1.Location = New System.Drawing.Point(2, 2)
            Me.accordionControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionControl1.Name = "accordionControl1"
            Me.accordionControl1.ShowGroupExpandButtons = False
            Me.accordionControl1.ShowItemExpandButtons = False
            Me.accordionControl1.Size = New System.Drawing.Size(286, 125)
            Me.accordionControl1.TabIndex = 0
            Me.accordionControl1.Text = "accordionControl1"
            Me.accordionContentContainer2.Controls.Add(Me.showFocusedOtherFilterToggle)
            Me.accordionContentContainer2.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionContentContainer2.Name = "accordionContentContainer2"
            Me.accordionContentContainer2.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
            Me.accordionContentContainer2.Size = New System.Drawing.Size(269, 44)
            Me.accordionContentContainer2.TabIndex = 1
            Me.showFocusedOtherFilterToggle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.showFocusedOtherFilterToggle.Location = New System.Drawing.Point(20, 10)
            Me.showFocusedOtherFilterToggle.Margin = New System.Windows.Forms.Padding(2)
            Me.showFocusedOtherFilterToggle.Name = "showFocusedOtherFilterToggle"
            Me.showFocusedOtherFilterToggle.Properties.AllowFocused = False
            Me.showFocusedOtherFilterToggle.Properties.OffText = "Off"
            Me.showFocusedOtherFilterToggle.Properties.OnText = "On"
            Me.showFocusedOtherFilterToggle.Size = New System.Drawing.Size(229, 24)
            Me.showFocusedOtherFilterToggle.TabIndex = 0
            Me.focusedInboxAccordionTitle.Appearance.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.focusedInboxAccordionTitle.Appearance.Disabled.Options.UseFont = True
            Me.focusedInboxAccordionTitle.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.focusedInboxAccordionTitle.Appearance.Hovered.Options.UseFont = True
            Me.focusedInboxAccordionTitle.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.focusedInboxAccordionTitle.Appearance.Normal.Options.UseFont = True
            Me.focusedInboxAccordionTitle.Appearance.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.focusedInboxAccordionTitle.Appearance.Pressed.Options.UseFont = True
            Me.focusedInboxAccordionTitle.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement8})
            Me.focusedInboxAccordionTitle.Expanded = True
            Me.focusedInboxAccordionTitle.Name = "focusedInboxAccordionTitle"
            Me.focusedInboxAccordionTitle.Text = "Focused Inbox"
            Me.accordionControlElement8.Appearance.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControlElement8.Appearance.Disabled.Options.UseFont = True
            Me.accordionControlElement8.Appearance.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControlElement8.Appearance.Hovered.Options.UseFont = True
            Me.accordionControlElement8.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControlElement8.Appearance.Normal.Options.UseFont = True
            Me.accordionControlElement8.Appearance.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControlElement8.Appearance.Pressed.Options.UseFont = True
            Me.accordionControlElement8.ContentContainer = Me.accordionContentContainer2
            Me.accordionControlElement8.Expanded = True
            Me.accordionControlElement8.Name = "accordionControlElement8"
            Me.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement8.Text = "Sort messsages into Focused and Other"
            Me.flyoutPanelAccounts.Controls.Add(Me.flyoutPanelControl2)
            Me.flyoutPanelAccounts.Location = New System.Drawing.Point(245, 34)
            Me.flyoutPanelAccounts.Margin = New System.Windows.Forms.Padding(2)
            Me.flyoutPanelAccounts.Name = "flyoutPanelAccounts"
            Me.flyoutPanelAccounts.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right
            Me.flyoutPanelAccounts.OptionsButtonPanel.ButtonPanelHeight = 21
            Me.flyoutPanelAccounts.OwnerControl = Me.fluentDesignFormContainer
            Me.flyoutPanelAccounts.Size = New System.Drawing.Size(290, 151)
            Me.flyoutPanelAccounts.TabIndex = 2
            Me.flyoutPanelControl2.Controls.Add(Me.accordionAccounts)
            Me.flyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flyoutPanelControl2.FlyoutPanel = Nothing
            Me.flyoutPanelControl2.Location = New System.Drawing.Point(0, 0)
            Me.flyoutPanelControl2.Name = "flyoutPanelControl2"
            Me.flyoutPanelControl2.Size = New System.Drawing.Size(290, 151)
            Me.flyoutPanelControl2.TabIndex = 0
            Me.accordionAccounts.Appearance.Group.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionAccounts.Appearance.Group.Disabled.Options.UseFont = True
            Me.accordionAccounts.Appearance.Group.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionAccounts.Appearance.Group.Hovered.Options.UseFont = True
            Me.accordionAccounts.Appearance.Group.Normal.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionAccounts.Appearance.Group.Normal.Options.UseFont = True
            Me.accordionAccounts.Appearance.Group.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionAccounts.Appearance.Group.Pressed.Options.UseFont = True
            Me.accordionAccounts.Appearance.Item.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionAccounts.Appearance.Item.Disabled.Options.UseFont = True
            Me.accordionAccounts.Appearance.Item.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionAccounts.Appearance.Item.Hovered.Options.UseFont = True
            Me.accordionAccounts.Appearance.Item.Normal.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionAccounts.Appearance.Item.Normal.Options.UseFont = True
            Me.accordionAccounts.Appearance.Item.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionAccounts.Appearance.Item.Pressed.Options.UseFont = True
            Me.accordionAccounts.ContentTopIndent = 0
            Me.accordionAccounts.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionAccounts.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.aceManageAccountsTitle})
            Me.accordionAccounts.ExpandGroupOnHeaderClick = False
            Me.accordionAccounts.ExpandItemOnHeaderClick = False
            Me.accordionAccounts.Location = New System.Drawing.Point(2, 2)
            Me.accordionAccounts.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionAccounts.Name = "accordionAccounts"
            Me.accordionAccounts.ShowGroupExpandButtons = False
            Me.accordionAccounts.ShowItemExpandButtons = False
            Me.accordionAccounts.Size = New System.Drawing.Size(286, 147)
            Me.accordionAccounts.TabIndex = 0
            Me.accordionAccounts.Text = "accordionAccounts"
            Me.aceManageAccountsTitle.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.elementAccount, Me.linkInboxedElement, Me.addAccountElement})
            Me.aceManageAccountsTitle.Expanded = True
            Me.aceManageAccountsTitle.Name = "aceManageAccountsTitle"
            Me.aceManageAccountsTitle.Text = "Manage accounts"
            Me.elementAccount.ImageOptions.SvgImage = CType((resources.GetObject("elementAccount.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.elementAccount.Name = "elementAccount"
            Me.elementAccount.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.elementAccount.Text = "maildemo@dx-mail.com"
            Me.linkInboxedElement.ImageOptions.SvgImage = CType((resources.GetObject("linkInboxedElement.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.linkInboxedElement.Name = "linkInboxedElement"
            Me.linkInboxedElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.linkInboxedElement.Text = "Link inboxes"
            Me.addAccountElement.ImageOptions.SvgImage = CType((resources.GetObject("addAccountElement.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.addAccountElement.Name = "addAccountElement"
            Me.addAccountElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.addAccountElement.Text = "Add account"
            Me.flyoutPanelSettings.Controls.Add(Me.flyoutPanelControl1)
            Me.flyoutPanelSettings.Location = New System.Drawing.Point(613, 34)
            Me.flyoutPanelSettings.Margin = New System.Windows.Forms.Padding(2)
            Me.flyoutPanelSettings.Name = "flyoutPanelSettings"
            Me.flyoutPanelSettings.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right
            Me.flyoutPanelSettings.OptionsButtonPanel.ButtonPanelHeight = 21
            Me.flyoutPanelSettings.OwnerControl = Me.fluentDesignFormContainer
            Me.flyoutPanelSettings.Size = New System.Drawing.Size(290, 151)
            Me.flyoutPanelSettings.TabIndex = 1
            Me.flyoutPanelControl1.Controls.Add(Me.accordionSettings)
            Me.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flyoutPanelControl1.FlyoutPanel = Nothing
            Me.flyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
            Me.flyoutPanelControl1.Name = "flyoutPanelControl1"
            Me.flyoutPanelControl1.Size = New System.Drawing.Size(290, 151)
            Me.flyoutPanelControl1.TabIndex = 0
            Me.accordionSettings.Appearance.Group.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionSettings.Appearance.Group.Disabled.Options.UseFont = True
            Me.accordionSettings.Appearance.Group.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionSettings.Appearance.Group.Hovered.Options.UseFont = True
            Me.accordionSettings.Appearance.Group.Normal.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionSettings.Appearance.Group.Normal.Options.UseFont = True
            Me.accordionSettings.Appearance.Group.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionSettings.Appearance.Group.Pressed.Options.UseFont = True
            Me.accordionSettings.Appearance.Item.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionSettings.Appearance.Item.Disabled.Options.UseFont = True
            Me.accordionSettings.Appearance.Item.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionSettings.Appearance.Item.Hovered.Options.UseFont = True
            Me.accordionSettings.Appearance.Item.Normal.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionSettings.Appearance.Item.Normal.Options.UseFont = True
            Me.accordionSettings.Appearance.Item.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionSettings.Appearance.Item.Pressed.Options.UseFont = True
            Me.accordionSettings.ContentTopIndent = 0
            Me.accordionSettings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionSettings.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement13})
            Me.accordionSettings.ExpandGroupOnHeaderClick = False
            Me.accordionSettings.Location = New System.Drawing.Point(2, 2)
            Me.accordionSettings.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionSettings.Name = "accordionSettings"
            Me.accordionSettings.ShowGroupExpandButtons = False
            Me.accordionSettings.Size = New System.Drawing.Size(286, 147)
            Me.accordionSettings.TabIndex = 0
            Me.accordionSettings.Text = "accordionControl2"
            Me.accordionControlElement13.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.manageAccountsElement, Me.personalizationElement, Me.automaticRepliesElement, Me.focusedInboxElement, Me.messageListElement, Me.readingPaneElement, Me.signatureElement, Me.notificationsElement, Me.emailSecurityElement, Me.wnElement, Me.oulookAndiOSElement, Me.helpElement, Me.trustCenterElement, Me.feedbackElement, Me.aboutElement})
            Me.accordionControlElement13.Expanded = True
            Me.accordionControlElement13.Name = "accordionControlElement13"
            Me.accordionControlElement13.Text = "Settings"
            Me.manageAccountsElement.Name = "manageAccountsElement"
            Me.manageAccountsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.manageAccountsElement.Text = "Manage accounts"
            Me.personalizationElement.Name = "personalizationElement"
            Me.personalizationElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.personalizationElement.Text = "Personalization"
            Me.automaticRepliesElement.Name = "automaticRepliesElement"
            Me.automaticRepliesElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.automaticRepliesElement.Text = "Automatic replies"
            Me.automaticRepliesElement.Visible = False
            Me.focusedInboxElement.Name = "focusedInboxElement"
            Me.focusedInboxElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.focusedInboxElement.Text = "Focused Inbox"
            Me.messageListElement.Name = "messageListElement"
            Me.messageListElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.messageListElement.Text = "Message list"
            Me.messageListElement.Visible = False
            Me.readingPaneElement.Name = "readingPaneElement"
            Me.readingPaneElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.readingPaneElement.Text = "Reading pane"
            Me.readingPaneElement.Visible = False
            Me.signatureElement.Name = "signatureElement"
            Me.signatureElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.signatureElement.Text = "Signature"
            Me.notificationsElement.Name = "notificationsElement"
            Me.notificationsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.notificationsElement.Text = "Notifications"
            Me.notificationsElement.Visible = False
            Me.emailSecurityElement.Name = "emailSecurityElement"
            Me.emailSecurityElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.emailSecurityElement.Text = "Email security"
            Me.emailSecurityElement.Visible = False
            Me.wnElement.Name = "wnElement"
            Me.wnElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.wnElement.Text = "What's new"
            Me.oulookAndiOSElement.Name = "oulookAndiOSElement"
            Me.oulookAndiOSElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.oulookAndiOSElement.Text = "Outlook for Android and iOS"
            Me.oulookAndiOSElement.Visible = False
            Me.helpElement.Name = "helpElement"
            Me.helpElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.helpElement.Text = "Help"
            Me.trustCenterElement.Name = "trustCenterElement"
            Me.trustCenterElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.trustCenterElement.Text = "Trust Center"
            Me.trustCenterElement.Visible = False
            Me.feedbackElement.Name = "feedbackElement"
            Me.feedbackElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.feedbackElement.Text = "Feedback"
            Me.aboutElement.Name = "aboutElement"
            Me.aboutElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.aboutElement.Text = "About"
            Me.aboutElement.Visible = False
            Me.flyoutPanelFolders.Controls.Add(Me.accordionFolders)
            Me.flyoutPanelFolders.Location = New System.Drawing.Point(611, 199)
            Me.flyoutPanelFolders.Margin = New System.Windows.Forms.Padding(2)
            Me.flyoutPanelFolders.Name = "flyoutPanelFolders"
            Me.flyoutPanelFolders.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Left
            Me.flyoutPanelFolders.OptionsButtonPanel.ButtonPanelHeight = 21
            Me.flyoutPanelFolders.OwnerControl = Me.fluentDesignFormContainer
            Me.flyoutPanelFolders.ParentForm = Me
            Me.flyoutPanelFolders.Size = New System.Drawing.Size(290, 127)
            Me.flyoutPanelFolders.TabIndex = 0
            Me.accordionFolders.AllowItemSelection = True
            Me.accordionFolders.Appearance.Group.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionFolders.Appearance.Group.Disabled.Options.UseFont = True
            Me.accordionFolders.Appearance.Group.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionFolders.Appearance.Group.Hovered.Options.UseFont = True
            Me.accordionFolders.Appearance.Group.Normal.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionFolders.Appearance.Group.Normal.Options.UseFont = True
            Me.accordionFolders.Appearance.Group.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionFolders.Appearance.Group.Pressed.Options.UseFont = True
            Me.accordionFolders.Appearance.Item.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionFolders.Appearance.Item.Disabled.Options.UseFont = True
            Me.accordionFolders.Appearance.Item.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionFolders.Appearance.Item.Hovered.Options.UseFont = True
            Me.accordionFolders.Appearance.Item.Normal.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionFolders.Appearance.Item.Normal.Options.UseFont = True
            Me.accordionFolders.Appearance.Item.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionFolders.Appearance.Item.Pressed.Options.UseFont = True
            Me.accordionFolders.ContentTopIndent = 30
            Me.accordionFolders.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionFolders.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement2})
            Me.accordionFolders.ExpandGroupOnHeaderClick = False
            Me.accordionFolders.Location = New System.Drawing.Point(0, 0)
            Me.accordionFolders.Margin = New System.Windows.Forms.Padding(0)
            Me.accordionFolders.Name = "accordionFolders"
            Me.accordionFolders.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.[False]
            Me.accordionFolders.ShowGroupExpandButtons = False
            Me.accordionFolders.Size = New System.Drawing.Size(290, 127)
            Me.accordionFolders.TabIndex = 0
            Me.accordionFolders.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
            Me.accordionControlElement2.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.outboxElement, Me.inboxElement, Me.archiveElement, Me.archive1Element, Me.clutterElement, Me.convHistoryElement, Me.deletedItemsElement, Me.draftsElement, Me.junkEmailElement, Me.sentItemsElement})
            Me.accordionControlElement2.Expanded = True
            Me.accordionControlElement2.Name = "accordionControlElement2"
            Me.accordionControlElement2.Text = "All Folders"
            Me.outboxElement.Name = "outboxElement"
            Me.outboxElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.outboxElement.Tag = 6
            Me.outboxElement.Text = "Outbox"
            Me.inboxElement.Name = "inboxElement"
            Me.inboxElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.inboxElement.Tag = 7
            Me.inboxElement.Text = "Inbox"
            Me.archiveElement.Name = "archiveElement"
            Me.archiveElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.archiveElement.Tag = 8
            Me.archiveElement.Text = "Archive"
            Me.archive1Element.Name = "archive1Element"
            Me.archive1Element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.archive1Element.Tag = 9
            Me.archive1Element.Text = "Archive 1"
            Me.clutterElement.Name = "clutterElement"
            Me.clutterElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.clutterElement.Tag = 10
            Me.clutterElement.Text = "Clutter"
            Me.convHistoryElement.Name = "convHistoryElement"
            Me.convHistoryElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.convHistoryElement.Text = "Conversation history"
            Me.convHistoryElement.Visible = False
            Me.deletedItemsElement.Name = "deletedItemsElement"
            Me.deletedItemsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.deletedItemsElement.Tag = 11
            Me.deletedItemsElement.Text = "Deleted Items"
            Me.draftsElement.Name = "draftsElement"
            Me.draftsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.draftsElement.Tag = 4
            Me.draftsElement.Text = "Drafts"
            Me.junkEmailElement.Name = "junkEmailElement"
            Me.junkEmailElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.junkEmailElement.Text = "Junk Email"
            Me.junkEmailElement.Visible = False
            Me.sentItemsElement.Name = "sentItemsElement"
            Me.sentItemsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.sentItemsElement.Tag = 5
            Me.sentItemsElement.Text = "Sent Items"
            Me.accordionControl.AllowItemSelection = True
            Me.accordionControl.Appearance.AccordionControl.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.accordionControl.Appearance.AccordionControl.Options.UseFont = True
            Me.accordionControl.Appearance.Group.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl.Appearance.Group.Disabled.Options.UseFont = True
            Me.accordionControl.Appearance.Group.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl.Appearance.Group.Hovered.Options.UseFont = True
            Me.accordionControl.Appearance.Group.Normal.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl.Appearance.Group.Normal.Options.UseFont = True
            Me.accordionControl.Appearance.Group.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
            Me.accordionControl.Appearance.Group.Pressed.Options.UseFont = True
            Me.accordionControl.Appearance.Hint.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.accordionControl.Appearance.Hint.Options.UseFont = True
            Me.accordionControl.Appearance.Item.Disabled.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl.Appearance.Item.Disabled.Options.UseFont = True
            Me.accordionControl.Appearance.Item.Hovered.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl.Appearance.Item.Hovered.Options.UseFont = True
            Me.accordionControl.Appearance.Item.Normal.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl.Appearance.Item.Normal.Options.UseFont = True
            Me.accordionControl.Appearance.Item.Pressed.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.accordionControl.Appearance.Item.Pressed.Options.UseFont = True
            Me.accordionControl.Controls.Add(Me.accordionContentContainer1)
            Me.accordionControl.Dock = System.Windows.Forms.DockStyle.Left
            Me.accordionControl.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.elementMail, Me.elementCalendar, Me.elementPeople, Me.elementSettings})
            Me.accordionControl.ExpandGroupOnHeaderClick = False
            Me.accordionControl.ExpandItemOnHeaderClick = False
            Me.accordionControl.Location = New System.Drawing.Point(0, 31)
            Me.accordionControl.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionControl.Name = "accordionControl"
            Me.accordionControl.OptionsMinimizing.NormalWidth = 341
            Me.accordionControl.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer
            Me.accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
            Me.accordionControl.ShowGroupExpandButtons = False
            Me.accordionControl.ShowItemExpandButtons = False
            Me.accordionControl.ShowToolTips = False
            Me.accordionControl.Size = New System.Drawing.Size(341, 739)
            Me.accordionControl.TabIndex = 1
            Me.accordionControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
            AddHandler Me.accordionControl.CustomDrawElement, New DevExpress.XtraBars.Navigation.CustomDrawElementEventHandler(AddressOf Me.accordionControl_CustomDrawElement)
            Me.accordionContentContainer1.Controls.Add(Me.calendarControl1)
            Me.accordionContentContainer1.Margin = New System.Windows.Forms.Padding(2)
            Me.accordionContentContainer1.Name = "accordionContentContainer1"
            Me.accordionContentContainer1.Size = New System.Drawing.Size(324, 349)
            Me.accordionContentContainer1.TabIndex = 3
            Me.calendarControl1.AutoSize = False
            Me.calendarControl1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.calendarControl1.DateTime = New System.DateTime(2018, 6, 10, 0, 0, 0, 0)
            Me.calendarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.calendarControl1.EditValue = New System.DateTime(2018, 6, 10, 0, 0, 0, 0)
            Me.calendarControl1.Location = New System.Drawing.Point(0, 0)
            Me.calendarControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.calendarControl1.Size = New System.Drawing.Size(324, 349)
            Me.calendarControl1.TabIndex = 0
            Me.elementMail.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.elementNewMail, Me.elementAccounts, Me.elementFolders})
            Me.elementMail.Expanded = True
            Me.elementMail.ImageOptions.SvgImage = CType((resources.GetObject("elementMail.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.elementMail.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.elementMail.Name = "elementMail"
            Me.elementMail.Tag = 3
            Me.elementMail.Text = "Element1"
            Me.elementNewMail.Height = -1
            Me.elementNewMail.ImageOptions.SvgImage = CType((resources.GetObject("elementNewMail.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.elementNewMail.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.elementNewMail.Name = "elementNewMail"
            Me.elementNewMail.Tag = 1
            Me.elementNewMail.Text = "New mail"
            Me.elementAccounts.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement6})
            Me.elementAccounts.Expanded = True
            Me.elementAccounts.Height = -1
            Me.elementAccounts.ImageOptions.SvgImage = CType((resources.GetObject("elementAccounts.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.elementAccounts.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.elementAccounts.Name = "elementAccounts"
            Me.elementAccounts.Tag = 2
            Me.elementAccounts.Text = "Accounts"
            Me.accordionControlElement6.Name = "accordionControlElement6"
            Me.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement6.Tag = "Account"
            Me.accordionControlElement6.Text = "maildemo@dx-mail.com"
            Me.elementFolders.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.foldersDrafts, Me.foldersSentItems, Me.foldersMore})
            Me.elementFolders.Expanded = True
            Me.elementFolders.Height = -1
            Me.elementFolders.ImageOptions.SvgImage = CType((resources.GetObject("elementFolders.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.elementFolders.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.elementFolders.Name = "elementFolders"
            Me.elementFolders.Tag = 3
            Me.elementFolders.Text = "Folders"
            Me.foldersDrafts.Name = "foldersDrafts"
            Me.foldersDrafts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.foldersDrafts.Tag = 4
            Me.foldersDrafts.Text = "Drafts"
            Me.foldersSentItems.Name = "foldersSentItems"
            Me.foldersSentItems.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.foldersSentItems.Tag = 5
            Me.foldersSentItems.Text = "Sent Items"
            Me.foldersMore.Name = "foldersMore"
            Me.foldersMore.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.foldersMore.Tag = 33
            Me.foldersMore.Text = "More"
            Me.elementCalendar.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.elementNewEvent, Me.accordionControlElement1, Me.accordionControlElement3})
            Me.elementCalendar.Expanded = True
            Me.elementCalendar.ImageOptions.SvgImage = CType((resources.GetObject("elementCalendar.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.elementCalendar.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.elementCalendar.Name = "elementCalendar"
            Me.elementCalendar.Tag = 15
            Me.elementCalendar.Text = "Calendar"
            Me.elementNewEvent.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement7})
            Me.elementNewEvent.Expanded = True
            Me.elementNewEvent.ImageOptions.SvgImage = CType((resources.GetObject("elementNewEvent.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.elementNewEvent.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.elementNewEvent.Name = "elementNewEvent"
            Me.elementNewEvent.Text = "New event"
            Me.accordionControlElement7.ContentContainer = Me.accordionContentContainer1
            Me.accordionControlElement7.Expanded = True
            Me.accordionControlElement7.HeaderVisible = False
            Me.accordionControlElement7.Name = "accordionControlElement7"
            Me.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement4})
            Me.accordionControlElement1.Expanded = True
            Me.accordionControlElement1.Name = "accordionControlElement1"
            Me.accordionControlElement1.Text = "DevExpress"
            Me.accordionControlElement4.Name = "accordionControlElement4"
            Me.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement4.Text = "Calendar"
            Me.accordionControlElement3.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement5})
            Me.accordionControlElement3.Expanded = True
            Me.accordionControlElement3.Name = "accordionControlElement3"
            Me.accordionControlElement3.Text = "Microsoft Account"
            Me.accordionControlElement3.Visible = False
            Me.accordionControlElement5.Name = "accordionControlElement5"
            Me.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement5.Text = "Calendar"
            Me.elementPeople.ImageOptions.SvgImage = CType((resources.GetObject("elementPeople.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.elementPeople.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.elementPeople.Name = "elementPeople"
            Me.elementPeople.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.elementPeople.Text = "People"
            Me.elementSettings.ControlFooterAlignment = DevExpress.XtraBars.Navigation.AccordionItemFooterAlignment.Far
            Me.elementSettings.ImageOptions.SvgImage = CType((resources.GetObject("elementSettings.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.elementSettings.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.elementSettings.Name = "elementSettings"
            Me.elementSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.elementSettings.Text = "Settings"
            Me.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.fluentDesignFormControl1.FluentDesignForm = Me
            Me.fluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
            Me.fluentDesignFormControl1.Name = "fluentDesignFormControl1"
            Me.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fluentDesignFormControl1.Size = New System.Drawing.Size(1472, 31)
            Me.fluentDesignFormControl1.TabIndex = 2
            Me.fluentDesignFormControl1.TabStop = False
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.WindowsMailClient.Win.ViewModels.MainViewModel)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1472, 766)
            Me.ControlContainer = Me.fluentDesignFormContainer
            Me.Controls.Add(Me.fluentDesignFormContainer)
            Me.Controls.Add(Me.accordionControl)
            Me.Controls.Add(Me.fluentDesignFormControl1)
            Me.FluentDesignFormControl = Me.fluentDesignFormControl1
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "MainForm"
            Me.NavigationControl = Me.accordionControl
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Mail"
            Me.TransparencyKey = System.Drawing.Color.FromArgb((CInt(((CByte((250)))))), (CInt(((CByte((250)))))), (CInt(((CByte((255)))))))
            Me.fluentDesignFormContainer.ResumeLayout(False)
            CType((Me.flyoutPanelNotifications), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanelNotifications.ResumeLayout(False)
            CType((Me.flyoutPanelControl4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanelControl4.ResumeLayout(False)
            CType((Me.accordionControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionControl2.ResumeLayout(False)
            Me.accordionContentContainer3.ResumeLayout(False)
            CType((Me.toggleSwitch1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.flyoutPanelFocuedInboxSettings), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanelFocuedInboxSettings.ResumeLayout(False)
            CType((Me.flyoutPanelControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanelControl3.ResumeLayout(False)
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionControl1.ResumeLayout(False)
            Me.accordionContentContainer2.ResumeLayout(False)
            CType((Me.showFocusedOtherFilterToggle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.flyoutPanelAccounts), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanelAccounts.ResumeLayout(False)
            CType((Me.flyoutPanelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanelControl2.ResumeLayout(False)
            CType((Me.accordionAccounts), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.flyoutPanelSettings), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanelSettings.ResumeLayout(False)
            CType((Me.flyoutPanelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanelControl1.ResumeLayout(False)
            CType((Me.accordionSettings), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.flyoutPanelFolders), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanelFolders.ResumeLayout(False)
            CType((Me.accordionFolders), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.accordionControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionControl.ResumeLayout(False)
            Me.accordionContentContainer1.ResumeLayout(False)
            CType((Me.calendarControl1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.fluentDesignFormControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private fluentDesignFormContainer As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer

        Private accordionControl As DevExpress.XtraBars.Navigation.AccordionControl

        Private elementNewMail As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private fluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl

        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext

        Private elementAccounts As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private elementFolders As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private foldersDrafts As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private foldersSentItems As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private foldersMore As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private elementMail As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private elementCalendar As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private elementPeople As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private elementSettings As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private outboxElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private inboxElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private archiveElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private archive1Element As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private clutterElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private convHistoryElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private deletedItemsElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private draftsElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private junkEmailElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private sentItemsElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private flyoutPanelSettings As DevExpress.Utils.FlyoutPanel

        Private accordionControlElement13 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private manageAccountsElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private personalizationElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private automaticRepliesElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private focusedInboxElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private messageListElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private readingPaneElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private signatureElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private notificationsElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private emailSecurityElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private wnElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private oulookAndiOSElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private helpElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private trustCenterElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private feedbackElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private aboutElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private flyoutPanelAccounts As DevExpress.Utils.FlyoutPanel

        Private aceManageAccountsTitle As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private linkInboxedElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private addAccountElement As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private elementNewEvent As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement5 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement6 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private elementAccount As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionContentContainer1 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private accordionControlElement7 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private calendarControl1 As DevExpress.XtraEditors.Controls.CalendarControl

        Private flyoutPanelFocuedInboxSettings As DevExpress.Utils.FlyoutPanel

        Private accordionControl1 As DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl

        Private focusedInboxAccordionTitle As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionContentContainer2 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private showFocusedOtherFilterToggle As DevExpress.XtraEditors.ToggleSwitch

        Private accordionControlElement8 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControl2 As DevExpress.XtraBars.Navigation.AccordionControl

        Private notificationsHeader As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionContentContainer3 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private toggleSwitch1 As DevExpress.XtraEditors.ToggleSwitch

        Private flyoutPanelNotifications As DevExpress.Utils.FlyoutPanel

        Private flyoutPanelControl4 As DevExpress.Utils.FlyoutPanelControl

        Private flyoutPanelFolders As DevExpress.WindowsMailClient.Win.Controls.VerticalTopFlyoutPanel

        Private accordionFolders As DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl

        Private accordionSettings As DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl

        Private accordionAccounts As DevExpress.WindowsMailClient.Win.Controls.MailClientPanelAccordionControl

        Private flyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl

        Private flyoutPanelControl3 As DevExpress.Utils.FlyoutPanelControl

        Private flyoutPanelControl2 As DevExpress.Utils.FlyoutPanelControl
    End Class
End Namespace
