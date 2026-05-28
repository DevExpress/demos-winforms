Namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls

    Partial Class ShippingControl

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.Modules.AccordionControl.Controls.ShippingControl))
            Me.htmlContentControl1 = New DevExpress.XtraEditors.HtmlContentControl()
            Me.cityEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.stateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.codeEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.phoneEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.addressEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.addressEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cityEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stateEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.codeEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.phoneEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.addressEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.addressEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.htmlContentControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cityEdit, Me.stateEdit, Me.codeEdit, Me.phoneEdit, Me.addressEdit1, Me.addressEdit2})
            Me.htmlContentControl1.Size = New System.Drawing.Size(570, 296)
            Me.htmlContentControl1.TabIndex = 0
            ' 
            ' cityEdit
            ' 
            Me.cityEdit.AutoHeight = False
            Me.cityEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.cityEdit.Name = "cityEdit"
            Me.cityEdit.NullValuePrompt = "City"
            Me.cityEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' stateEdit
            ' 
            Me.stateEdit.AutoHeight = False
            Me.stateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.stateEdit.Name = "stateEdit"
            Me.stateEdit.NullValuePrompt = "State"
            Me.stateEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' codeEdit
            ' 
            Me.codeEdit.AutoHeight = False
            Me.codeEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.codeEdit.Name = "codeEdit"
            Me.codeEdit.NullValuePrompt = "Postal Code"
            Me.codeEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' phoneEdit
            ' 
            Me.phoneEdit.AutoHeight = False
            Me.phoneEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.phoneEdit.Name = "phoneEdit"
            Me.phoneEdit.NullValuePrompt = "Phone"
            Me.phoneEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' addressEdit1
            ' 
            Me.addressEdit1.AutoHeight = False
            Me.addressEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.addressEdit1.Name = "addressEdit1"
            Me.addressEdit1.NullValuePrompt = "Address 1"
            Me.addressEdit1.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' addressEdit2
            ' 
            Me.addressEdit2.AutoHeight = False
            Me.addressEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.addressEdit2.Name = "addressEdit2"
            Me.addressEdit2.NullValuePrompt = "Address 2"
            Me.addressEdit2.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' ShippingControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.htmlContentControl1)
            Me.Name = "ShippingControl"
            Me.Size = New System.Drawing.Size(570, 296)
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cityEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stateEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.codeEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.phoneEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.addressEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.addressEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private htmlContentControl1 As DevExpress.XtraEditors.HtmlContentControl

        Private cityEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private stateEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private codeEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private phoneEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private addressEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private addressEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    End Class
End Namespace
