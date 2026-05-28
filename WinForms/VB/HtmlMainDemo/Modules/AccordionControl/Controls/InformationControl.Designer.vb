Namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls

    Partial Class InformationControl

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.Modules.AccordionControl.Controls.InformationControl))
            Me.htmlContentControl1 = New DevExpress.XtraEditors.HtmlContentControl()
            Me.firstNameEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.lastNameEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.birthdayEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.emailEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.firstNameEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lastNameEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.birthdayEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emailEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' htmlContentControl1
            ' 
            Me.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles")
            Me.htmlContentControl1.HtmlTemplate.Template = resources.GetString("htmlContentControl1.HtmlTemplate.Template")
            Me.htmlContentControl1.Location = New System.Drawing.Point(0, 0)
            Me.htmlContentControl1.Name = "htmlContentControl1"
            Me.htmlContentControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.firstNameEdit, Me.lastNameEdit, Me.birthdayEdit, Me.emailEdit})
            Me.htmlContentControl1.Size = New System.Drawing.Size(354, 182)
            Me.htmlContentControl1.TabIndex = 0
            ' 
            ' firstNameEdit
            ' 
            Me.firstNameEdit.AutoHeight = False
            Me.firstNameEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.firstNameEdit.Name = "firstNameEdit"
            Me.firstNameEdit.NullValuePrompt = "First Name"
            Me.firstNameEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' lastNameEdit
            ' 
            Me.lastNameEdit.AutoHeight = False
            Me.lastNameEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.lastNameEdit.Name = "lastNameEdit"
            Me.lastNameEdit.NullValuePrompt = "Last Name"
            Me.lastNameEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' birthdayEdit
            ' 
            Me.birthdayEdit.AutoHeight = False
            Me.birthdayEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.birthdayEdit.Name = "birthdayEdit"
            Me.birthdayEdit.NullValuePrompt = "Date of Birth"
            Me.birthdayEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' emailEdit
            ' 
            Me.emailEdit.AutoHeight = False
            Me.emailEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.emailEdit.Name = "emailEdit"
            Me.emailEdit.NullValuePrompt = "Email"
            Me.emailEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' InformationControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.htmlContentControl1)
            Me.Name = "InformationControl"
            Me.Size = New System.Drawing.Size(354, 182)
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.firstNameEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lastNameEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.birthdayEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emailEdit), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private htmlContentControl1 As DevExpress.XtraEditors.HtmlContentControl

        Private firstNameEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private lastNameEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private birthdayEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private emailEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    End Class
End Namespace
