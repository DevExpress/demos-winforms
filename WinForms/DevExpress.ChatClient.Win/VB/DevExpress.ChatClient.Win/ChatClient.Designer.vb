Namespace DevExpress.ChatClient

    Partial Class Messenger

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
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.userInfoPopup = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
            Me.contactInfoPopup = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
            Me.sidePanelContacts = New DevExpress.XtraEditors.SidePanel()
            Me.contactsView = New DevExpress.ChatClient.Views.ContactsView()
            Me.messagesView = New DevExpress.ChatClient.Views.MessagesView()
            Me.toolbarFormControl1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormControl()
            Me.toolbarFormManager1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.darkThemeBBI = New DevExpress.XtraBars.BarButtonItem()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.userInfoPopup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.contactInfoPopup), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelContacts.SuspendLayout()
            CType((Me.toolbarFormControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.toolbarFormManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.ChatClient.ViewModels.MessengerViewModel)
            Me.userInfoPopup.ContainerControl = Me
            Me.userInfoPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            Me.userInfoPopup.ViewModelType = GetType(DevExpress.ChatClient.ViewModels.UserViewModel)
            AddHandler Me.userInfoPopup.ViewModelSet, New DevExpress.Utils.MVVM.ViewModelSetEventHandler(AddressOf Me.userInfoPopup_ViewModelSet)
            Me.contactInfoPopup.ContainerControl = Me
            Me.contactInfoPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            Me.contactInfoPopup.ViewModelType = GetType(DevExpress.ChatClient.ViewModels.ContactViewModel)
            AddHandler Me.contactInfoPopup.ViewModelSet, New DevExpress.Utils.MVVM.ViewModelSetEventHandler(AddressOf Me.contactInfoPopup_ViewModelSet)
            Me.sidePanelContacts.Controls.Add(Me.contactsView)
            Me.sidePanelContacts.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanelContacts.Location = New System.Drawing.Point(0, 31)
            Me.sidePanelContacts.Margin = New System.Windows.Forms.Padding(0)
            Me.sidePanelContacts.MinimumSize = New System.Drawing.Size(200, 0)
            Me.sidePanelContacts.Name = "sidePanelContacts"
            Me.sidePanelContacts.OverlayResizeZoneThickness = 4
            Me.sidePanelContacts.Size = New System.Drawing.Size(271, 569)
            Me.sidePanelContacts.TabIndex = 0
            Me.contactsView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.contactsView.Location = New System.Drawing.Point(0, 0)
            Me.contactsView.Margin = New System.Windows.Forms.Padding(0)
            Me.contactsView.Name = "contactsView"
            Me.contactsView.Size = New System.Drawing.Size(270, 569)
            Me.contactsView.TabIndex = 0
            Me.messagesView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.messagesView.Location = New System.Drawing.Point(271, 31)
            Me.messagesView.Margin = New System.Windows.Forms.Padding(0)
            Me.messagesView.Name = "messagesView"
            Me.messagesView.Size = New System.Drawing.Size(529, 569)
            Me.messagesView.TabIndex = 1
            Me.toolbarFormControl1.Location = New System.Drawing.Point(0, 0)
            Me.toolbarFormControl1.Manager = Me.toolbarFormManager1
            Me.toolbarFormControl1.Name = "toolbarFormControl1"
            Me.toolbarFormControl1.Size = New System.Drawing.Size(800, 31)
            Me.toolbarFormControl1.TabIndex = 2
            Me.toolbarFormControl1.TabStop = False
            Me.toolbarFormControl1.TitleItemLinks.Add(Me.darkThemeBBI)
            Me.toolbarFormControl1.ToolbarForm = Me
            Me.toolbarFormManager1.DockControls.Add(Me.barDockControlTop)
            Me.toolbarFormManager1.DockControls.Add(Me.barDockControlBottom)
            Me.toolbarFormManager1.DockControls.Add(Me.barDockControlLeft)
            Me.toolbarFormManager1.DockControls.Add(Me.barDockControlRight)
            Me.toolbarFormManager1.Form = Me
            Me.toolbarFormManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.darkThemeBBI})
            Me.toolbarFormManager1.MaxItemId = 1
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 31)
            Me.barDockControlTop.Manager = Me.toolbarFormManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(800, 0)
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 600)
            Me.barDockControlBottom.Manager = Me.toolbarFormManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(800, 0)
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
            Me.barDockControlLeft.Manager = Me.toolbarFormManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 569)
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(800, 31)
            Me.barDockControlRight.Manager = Me.toolbarFormManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 569)
            Me.darkThemeBBI.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.darkThemeBBI.Caption = "Dark Theme"
            Me.darkThemeBBI.Id = 0
            Me.darkThemeBBI.Name = "darkThemeBBI"
            AddHandler Me.darkThemeBBI.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnDarkThemeClick)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(800, 600)
            Me.Controls.Add(Me.messagesView)
            Me.Controls.Add(Me.sidePanelContacts)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Controls.Add(Me.toolbarFormControl1)
            Me.MinimumSize = New System.Drawing.Size(800, 600)
            Me.Name = "ClientForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "{Title}"
            Me.ToolbarFormControl = Me.toolbarFormControl1
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.userInfoPopup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.contactInfoPopup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelContacts.ResumeLayout(False)
            CType((Me.toolbarFormControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toolbarFormManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext

        Private userInfoPopup As DevExpress.XtraEditors.HtmlContentPopup

        Private contactInfoPopup As DevExpress.XtraEditors.HtmlContentPopup

        Private sidePanelContacts As DevExpress.XtraEditors.SidePanel

        Private contactsView As DevExpress.ChatClient.Views.ContactsView

        Private messagesView As DevExpress.ChatClient.Views.MessagesView

        Private toolbarFormControl1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormControl

        Private toolbarFormManager1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private darkThemeBBI As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace
