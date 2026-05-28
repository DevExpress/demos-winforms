
namespace DevExpress.ChatClient {
    partial class Messenger {
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
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.userInfoPopup = new DevExpress.XtraEditors.HtmlContentPopup(this.components);
            this.contactInfoPopup = new DevExpress.XtraEditors.HtmlContentPopup(this.components);
            this.sidePanelContacts = new DevExpress.XtraEditors.SidePanel();
            this.contactsView = new DevExpress.ChatClient.Views.ContactsView();
            this.messagesView = new DevExpress.ChatClient.Views.MessagesView();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.darkThemeBBI = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoPopup)).BeginInit();
            this.sidePanelContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.ChatClient.ViewModels.MessengerViewModel);
            
            
            
            this.userInfoPopup.ContainerControl = this;
            this.userInfoPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.userInfoPopup.ViewModelType = typeof(DevExpress.ChatClient.ViewModels.UserViewModel);
            this.userInfoPopup.ViewModelSet += new DevExpress.Utils.MVVM.ViewModelSetEventHandler(this.userInfoPopup_ViewModelSet);
            
            
            
            this.contactInfoPopup.ContainerControl = this;
            this.contactInfoPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.contactInfoPopup.ViewModelType = typeof(DevExpress.ChatClient.ViewModels.ContactViewModel);
            this.contactInfoPopup.ViewModelSet += new DevExpress.Utils.MVVM.ViewModelSetEventHandler(this.contactInfoPopup_ViewModelSet);
            
            
            
            this.sidePanelContacts.Controls.Add(this.contactsView);
            this.sidePanelContacts.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanelContacts.Location = new System.Drawing.Point(0, 31);
            this.sidePanelContacts.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanelContacts.MinimumSize = new System.Drawing.Size(200, 0);
            this.sidePanelContacts.Name = "sidePanelContacts";
            this.sidePanelContacts.OverlayResizeZoneThickness = 4;
            this.sidePanelContacts.Size = new System.Drawing.Size(271, 569);
            this.sidePanelContacts.TabIndex = 0;
            
            
            
            this.contactsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactsView.Location = new System.Drawing.Point(0, 0);
            this.contactsView.Margin = new System.Windows.Forms.Padding(0);
            this.contactsView.Name = "contactsView";
            this.contactsView.Size = new System.Drawing.Size(270, 569);
            this.contactsView.TabIndex = 0;
            
            
            
            this.messagesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesView.Location = new System.Drawing.Point(271, 31);
            this.messagesView.Margin = new System.Windows.Forms.Padding(0);
            this.messagesView.Name = "messagesView";
            this.messagesView.Size = new System.Drawing.Size(529, 569);
            this.messagesView.TabIndex = 1;
            
            
            
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(800, 31);
            this.toolbarFormControl1.TabIndex = 2;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.TitleItemLinks.Add(this.darkThemeBBI);
            this.toolbarFormControl1.ToolbarForm = this;
            
            
            
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            this.toolbarFormManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.darkThemeBBI});
            this.toolbarFormManager1.MaxItemId = 1;
            
            
            
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            
            
            
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 600);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            
            
            
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 569);
            
            
            
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 31);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 569);
            
            
            
            this.darkThemeBBI.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.darkThemeBBI.Caption = "Dark Theme";
            this.darkThemeBBI.Id = 0;
            this.darkThemeBBI.Name = "darkThemeBBI";
            this.darkThemeBBI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnDarkThemeClick);
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.messagesView);
            this.Controls.Add(this.sidePanelContacts);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{Title}";
            this.ToolbarFormControl = this.toolbarFormControl1;
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoPopup)).EndInit();
            this.sidePanelContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraEditors.HtmlContentPopup userInfoPopup;
        private DevExpress.XtraEditors.HtmlContentPopup contactInfoPopup;
        private DevExpress.XtraEditors.SidePanel sidePanelContacts;
        private Views.ContactsView contactsView;
        private Views.MessagesView messagesView;
        private XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.BarButtonItem darkThemeBBI;
    }
}
