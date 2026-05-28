Namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls

    Partial Class PaymentControl

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.Modules.AccordionControl.Controls.PaymentControl))
            Me.htmlContentControl1 = New DevExpress.XtraEditors.HtmlContentControl()
            Me.cardNumberEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.cardHolderEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.thruEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.cvcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cardNumberEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cardHolderEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.thruEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cvcEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' htmlContentControl1
            ' 
            Me.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Fill
            ' 
            ' 
            ' 
            Me.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles")
            Me.htmlContentControl1.HtmlTemplate.Template = resources.GetString("htmlContentControl1.HtmlTemplate.Template")
            Me.htmlContentControl1.Location = New System.Drawing.Point(0, 0)
            Me.htmlContentControl1.Name = "htmlContentControl1"
            Me.htmlContentControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cardNumberEdit, Me.cardHolderEdit, Me.thruEdit, Me.cvcEdit})
            Me.htmlContentControl1.Size = New System.Drawing.Size(567, 186)
            Me.htmlContentControl1.TabIndex = 0
            ' 
            ' cardNumberEdit
            ' 
            Me.cardNumberEdit.AutoHeight = False
            Me.cardNumberEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.cardNumberEdit.Name = "cardNumberEdit"
            Me.cardNumberEdit.NullValuePrompt = "Card Number"
            Me.cardNumberEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' cardHolderEdit
            ' 
            Me.cardHolderEdit.AutoHeight = False
            Me.cardHolderEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.cardHolderEdit.Name = "cardHolderEdit"
            Me.cardHolderEdit.NullValuePrompt = "Card Holder"
            Me.cardHolderEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' thruEdit
            ' 
            Me.thruEdit.AutoHeight = False
            Me.thruEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.thruEdit.Name = "thruEdit"
            Me.thruEdit.NullValuePrompt = "Valid Thru"
            Me.thruEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' cvcEdit
            ' 
            Me.cvcEdit.AutoHeight = False
            Me.cvcEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.cvcEdit.Name = "cvcEdit"
            Me.cvcEdit.NullValuePrompt = "CVC"
            Me.cvcEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' PaymentControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.htmlContentControl1)
            Me.Name = "PaymentControl"
            Me.Size = New System.Drawing.Size(567, 186)
            CType((Me.htmlContentControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cardNumberEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cardHolderEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.thruEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cvcEdit), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private htmlContentControl1 As DevExpress.XtraEditors.HtmlContentControl

        Private cardNumberEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private cardHolderEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private thruEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private cvcEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    End Class
End Namespace
