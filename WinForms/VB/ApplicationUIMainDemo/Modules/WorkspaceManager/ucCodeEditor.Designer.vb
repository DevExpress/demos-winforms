Namespace DevExpress.ApplicationUI.Demos

    Partial Class ucCodeEditor

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
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.EnableToolTips = True
            Me.richEditControl1.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.Comments.ShowAllAuthors = True
            Me.richEditControl1.Options.Comments.Visibility = DevExpress.XtraRichEdit.RichEditCommentVisibility.Auto
            Me.richEditControl1.Options.CopyPaste.MaintainDocumentSectionSettings = False
            Me.richEditControl1.Options.Fields.UseCurrentCultureDateTimeFormat = False
            Me.richEditControl1.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl1.Options.MailMerge.KeepLastParagraph = False
            Me.richEditControl1.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl1.Size = New System.Drawing.Size(820, 491)
            Me.richEditControl1.TabIndex = 0
            ' 
            ' ucCodeEditor
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.richEditControl1)
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "ucCodeEditor"
            Me.Size = New System.Drawing.Size(820, 491)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
    End Class
End Namespace
