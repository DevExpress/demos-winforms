Namespace DevExpress.ChatClient.Views

    Partial Class SignInView

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ChatClient.Views.SignInView))
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.signInView = New DevExpress.XtraEditors.HtmlContentControl()
            Me.pwdEdit = New DevExpress.XtraEditors.TextEdit()
            Me.signInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.signInView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pwdEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.signInBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.ChatClient.ViewModels.SignInViewModel)
            Me.signInView.Controls.Add(Me.pwdEdit)
            Me.signInView.DataContext = Me.signInBindingSource
            Me.signInView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.signInView.Location = New System.Drawing.Point(0, 0)
            Me.signInView.Margin = New System.Windows.Forms.Padding(0)
            Me.signInView.Name = "signInView"
            Me.signInView.Size = New System.Drawing.Size(420, 260)
            Me.signInView.TabIndex = 4
            Me.pwdEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.signInBindingSource, "Password", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.pwdEdit.Location = New System.Drawing.Point(34, 96)
            Me.pwdEdit.Name = "pwdEdit"
            Me.pwdEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pwdEdit.Properties.UseSystemPasswordChar = True
            Me.pwdEdit.Size = New System.Drawing.Size(362, 20)
            Me.pwdEdit.TabIndex = 5
            Me.signInBindingSource.DataSource = GetType(DevExpress.ChatClient.ViewModels.SignInViewModel)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.signInView)
            Me.Name = "LoginView"
            Me.Size = New System.Drawing.Size(480, 320)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.signInView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pwdEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.signInBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext

        Private signInView As DevExpress.XtraEditors.HtmlContentControl

        Private pwdEdit As DevExpress.XtraEditors.TextEdit

        Private signInBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace
