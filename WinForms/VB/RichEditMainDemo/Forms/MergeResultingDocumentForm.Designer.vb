Namespace DevExpress.XtraRichEdit.Demos.Forms

    Partial Class MergeResultingDocumentForm

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
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
            Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
            Me.makeTextUpperCaseItem2 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            Me.makeTextLowerCaseItem2 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
            Me.toggleTextCaseItem2 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
            Me.setSingleParagraphSpacingItem2 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
            Me.setSesquialteralParagraphSpacingItem2 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
            Me.setDoubleParagraphSpacingItem2 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
            Me.showLineSpacingFormItem2 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
            Me.addSpacingBeforeParagraphItem2 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
            Me.removeSpacingBeforeParagraphItem2 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
            Me.addSpacingAfterParagraphItem2 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
            Me.removeSpacingAfterParagraphItem2 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(792, 704)
            Me.richEditControl.TabIndex = 0
            Me.richEditControl.Text = "richEditControl"
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextUpperCaseItem2)
            Me.richEditBarController1.BarItems.Add(Me.makeTextLowerCaseItem2)
            Me.richEditBarController1.BarItems.Add(Me.toggleTextCaseItem2)
            Me.richEditBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem2)
            Me.richEditBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem2)
            Me.richEditBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem2)
            Me.richEditBarController1.BarItems.Add(Me.showLineSpacingFormItem2)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem2)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem2)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem2)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem2)
            Me.richEditBarController1.Control = Me.richEditControl
            ' 
            ' showFontFormItem1
            ' 
            Me.showFontFormItem1.Name = "showFontFormItem1"
            ' 
            ' showParagraphFormItem1
            ' 
            Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
            ' 
            ' makeTextUpperCaseItem2
            ' 
            Me.makeTextUpperCaseItem2.Name = "makeTextUpperCaseItem2"
            ' 
            ' makeTextLowerCaseItem2
            ' 
            Me.makeTextLowerCaseItem2.Name = "makeTextLowerCaseItem2"
            ' 
            ' toggleTextCaseItem2
            ' 
            Me.toggleTextCaseItem2.Name = "toggleTextCaseItem2"
            ' 
            ' setSingleParagraphSpacingItem2
            ' 
            Me.setSingleParagraphSpacingItem2.Name = "setSingleParagraphSpacingItem2"
            ' 
            ' setSesquialteralParagraphSpacingItem2
            ' 
            Me.setSesquialteralParagraphSpacingItem2.Name = "setSesquialteralParagraphSpacingItem2"
            ' 
            ' setDoubleParagraphSpacingItem2
            ' 
            Me.setDoubleParagraphSpacingItem2.Name = "setDoubleParagraphSpacingItem2"
            ' 
            ' showLineSpacingFormItem2
            ' 
            Me.showLineSpacingFormItem2.Name = "showLineSpacingFormItem2"
            ' 
            ' addSpacingBeforeParagraphItem2
            ' 
            Me.addSpacingBeforeParagraphItem2.Name = "addSpacingBeforeParagraphItem2"
            ' 
            ' removeSpacingBeforeParagraphItem2
            ' 
            Me.removeSpacingBeforeParagraphItem2.Name = "removeSpacingBeforeParagraphItem2"
            ' 
            ' addSpacingAfterParagraphItem2
            ' 
            Me.addSpacingAfterParagraphItem2.Name = "addSpacingAfterParagraphItem2"
            ' 
            ' removeSpacingAfterParagraphItem2
            ' 
            Me.removeSpacingAfterParagraphItem2.Name = "removeSpacingAfterParagraphItem2"
            ' 
            ' MergeResultingDocumentForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(792, 704)
            Me.Controls.Add(Me.richEditControl)
            Me.IconOptions.ShowIcon = False
            Me.Name = "MergeResultingDocumentForm"
            Me.Text = "Resulting Document"
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem

        Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem

        Private makeTextUpperCaseItem2 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem

        Private makeTextLowerCaseItem2 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem

        Private toggleTextCaseItem2 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem

        Private setSingleParagraphSpacingItem2 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem

        Private setSesquialteralParagraphSpacingItem2 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem

        Private setDoubleParagraphSpacingItem2 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem

        Private showLineSpacingFormItem2 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem

        Private addSpacingBeforeParagraphItem2 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem

        Private removeSpacingBeforeParagraphItem2 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem

        Private addSpacingAfterParagraphItem2 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem

        Private removeSpacingAfterParagraphItem2 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
    End Class
End Namespace
