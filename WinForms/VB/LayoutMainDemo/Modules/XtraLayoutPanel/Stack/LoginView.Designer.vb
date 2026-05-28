Namespace DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel

    Partial Class LoginView

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
            Me.stackPanelField = New DevExpress.Utils.Layout.StackPanel()
            Me.labelCaption = New DevExpress.XtraEditors.LabelControl()
            Me.labelLogin = New DevExpress.XtraEditors.LabelControl()
            Me.teLogin = New DevExpress.XtraEditors.TextEdit()
            Me.labelPassword = New DevExpress.XtraEditors.LabelControl()
            Me.tePassword = New DevExpress.XtraEditors.TextEdit()
            Me.linkLostPassword = New DevExpress.XtraEditors.HyperlinkLabelControl()
            Me.buttonStackPanel = New DevExpress.Utils.Layout.StackPanel()
            Me.btnSignIn = New DevExpress.XtraEditors.SimpleButton()
            Me.btnLogIn = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.stackPanelField), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.stackPanelField.SuspendLayout()
            CType((Me.teLogin.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tePassword.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.buttonStackPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonStackPanel.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' stackPanel
            ' 
            Me.stackPanelField.Controls.Add(Me.labelCaption)
            Me.stackPanelField.Controls.Add(Me.labelLogin)
            Me.stackPanelField.Controls.Add(Me.teLogin)
            Me.stackPanelField.Controls.Add(Me.labelPassword)
            Me.stackPanelField.Controls.Add(Me.tePassword)
            Me.stackPanelField.Controls.Add(Me.linkLostPassword)
            Me.stackPanelField.Controls.Add(Me.buttonStackPanel)
            Me.stackPanelField.Dock = System.Windows.Forms.DockStyle.Fill
            Me.stackPanelField.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown
            Me.stackPanelField.Location = New System.Drawing.Point(0, 0)
            Me.stackPanelField.Name = "stackPanel"
            Me.stackPanelField.Size = New System.Drawing.Size(363, 369)
            Me.stackPanelField.TabIndex = 0
            Me.stackPanelField.UseSkinIndents = True
            ' 
            ' labelCaption
            ' 
            Me.labelCaption.Appearance.FontSizeDelta = 8
            Me.labelCaption.Appearance.Options.UseFont = True
            Me.labelCaption.Location = New System.Drawing.Point(155, 12)
            Me.labelCaption.Name = "labelCaption"
            Me.labelCaption.Size = New System.Drawing.Size(52, 27)
            Me.labelCaption.TabIndex = 0
            Me.labelCaption.Text = "Login"
            ' 
            ' labelLogin
            ' 
            Me.labelLogin.Appearance.FontSizeDelta = 2
            Me.labelLogin.Appearance.Options.UseFont = True
            Me.labelLogin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelLogin.Location = New System.Drawing.Point(74, 43)
            Me.labelLogin.Name = "labelLogin"
            Me.labelLogin.Size = New System.Drawing.Size(214, 17)
            Me.labelLogin.TabIndex = 1
            Me.labelLogin.Text = "Login"
            ' 
            ' teLogin
            ' 
            Me.teLogin.Location = New System.Drawing.Point(74, 64)
            Me.teLogin.Name = "teLogin"
            Me.teLogin.Properties.Appearance.FontSizeDelta = 4
            Me.teLogin.Properties.Appearance.Options.UseFont = True
            Me.teLogin.Properties.UseSystemPasswordChar = True
            Me.teLogin.Size = New System.Drawing.Size(214, 26)
            Me.teLogin.TabIndex = 2
            ' 
            ' labelPassword
            ' 
            Me.labelPassword.Appearance.FontSizeDelta = 2
            Me.labelPassword.Appearance.Options.UseFont = True
            Me.labelPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelPassword.Location = New System.Drawing.Point(74, 94)
            Me.labelPassword.Name = "labelPassword"
            Me.labelPassword.Size = New System.Drawing.Size(214, 17)
            Me.labelPassword.TabIndex = 3
            Me.labelPassword.Text = "Password"
            ' 
            ' tePassword
            ' 
            Me.tePassword.Location = New System.Drawing.Point(74, 115)
            Me.tePassword.Name = "tePassword"
            Me.tePassword.Properties.Appearance.FontSizeDelta = 4
            Me.tePassword.Properties.Appearance.Options.UseFont = True
            Me.tePassword.Properties.UseSystemPasswordChar = True
            Me.tePassword.Size = New System.Drawing.Size(214, 26)
            Me.tePassword.TabIndex = 4
            ' 
            ' linkLostPassword
            ' 
            Me.linkLostPassword.Appearance.FontSizeDelta = 1
            Me.linkLostPassword.Appearance.Options.UseFont = True
            Me.linkLostPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.linkLostPassword.Location = New System.Drawing.Point(74, 145)
            Me.linkLostPassword.Name = "linkLostPassword"
            Me.linkLostPassword.Size = New System.Drawing.Size(214, 14)
            Me.linkLostPassword.TabIndex = 5
            Me.linkLostPassword.Text = "Lost your Password?"
            ' 
            ' buttonStackPanel
            ' 
            Me.buttonStackPanel.Controls.Add(Me.btnSignIn)
            Me.buttonStackPanel.Controls.Add(Me.btnLogIn)
            Me.buttonStackPanel.Location = New System.Drawing.Point(61, 163)
            Me.buttonStackPanel.Name = "buttonStackPanel"
            Me.buttonStackPanel.Size = New System.Drawing.Size(240, 49)
            Me.buttonStackPanel.TabIndex = 6
            Me.buttonStackPanel.UseSkinIndents = True
            ' 
            ' btnSignIn
            ' 
            Me.btnSignIn.Location = New System.Drawing.Point(13, 11)
            Me.btnSignIn.Name = "btnSignIn"
            Me.btnSignIn.Size = New System.Drawing.Size(105, 26)
            Me.buttonStackPanel.SetStretched(Me.btnSignIn, True)
            Me.btnSignIn.TabIndex = 0
            Me.btnSignIn.Text = "Sign In"
            ' 
            ' btnLogIn
            ' 
            Me.btnLogIn.Location = New System.Drawing.Point(122, 11)
            Me.btnLogIn.Name = "btnLogIn"
            Me.btnLogIn.Size = New System.Drawing.Size(105, 26)
            Me.buttonStackPanel.SetStretched(Me.btnLogIn, True)
            Me.btnLogIn.TabIndex = 1
            Me.btnLogIn.Text = "Log In"
            ' 
            ' LoginView
            ' 
            Me.ClientSize = New System.Drawing.Size(363, 369)
            Me.Controls.Add(Me.stackPanelField)
            Me.Name = "LoginView"
            CType((Me.stackPanelField), System.ComponentModel.ISupportInitialize).EndInit()
            Me.stackPanelField.ResumeLayout(False)
            Me.stackPanelField.PerformLayout()
            CType((Me.teLogin.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tePassword.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.buttonStackPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonStackPanel.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private stackPanelField As DevExpress.Utils.Layout.StackPanel

        Private labelCaption As DevExpress.XtraEditors.LabelControl

        Private teLogin As DevExpress.XtraEditors.TextEdit

        Private tePassword As DevExpress.XtraEditors.TextEdit

        Private linkLostPassword As DevExpress.XtraEditors.HyperlinkLabelControl

        Private labelLogin As DevExpress.XtraEditors.LabelControl

        Private labelPassword As DevExpress.XtraEditors.LabelControl

        Private btnSignIn As DevExpress.XtraEditors.SimpleButton

        Private buttonStackPanel As DevExpress.Utils.Layout.StackPanel

        Private btnLogIn As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
