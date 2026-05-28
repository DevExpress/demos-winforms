Namespace DevExpress.XtraRichEdit.Demos.Forms

    Partial Class DocumentStatisticsForm

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
            Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
            Me.lblParagraphsCount = New DevExpress.XtraEditors.LabelControl()
            Me.lblWithSpacesCharactersCount = New DevExpress.XtraEditors.LabelControl()
            Me.lblNoSpacesCharactersCount = New DevExpress.XtraEditors.LabelControl()
            Me.lblWordsCount = New DevExpress.XtraEditors.LabelControl()
            Me.chkIncludeTextboxes = New DevExpress.XtraEditors.CheckEdit()
            Me.lblParagraphs = New DevExpress.XtraEditors.LabelControl()
            Me.lblWithSpacesCharacters = New DevExpress.XtraEditors.LabelControl()
            Me.lblNoSpacesCharacters = New DevExpress.XtraEditors.LabelControl()
            Me.lblWords = New DevExpress.XtraEditors.LabelControl()
            Me.lblCaption = New DevExpress.XtraEditors.LabelControl()
            CType((Me.chkIncludeTextboxes.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' btnClose
            ' 
            Me.btnClose.Location = New System.Drawing.Point(164, 141)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(75, 23)
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "Close"
            AddHandler Me.btnClose.Click, New System.EventHandler(AddressOf Me.OnCloseClick)
            ' 
            ' lblParagraphsCount
            ' 
            Me.lblParagraphsCount.Location = New System.Drawing.Point(217, 92)
            Me.lblParagraphsCount.Name = "lblParagraphsCount"
            Me.lblParagraphsCount.Size = New System.Drawing.Size(0, 13)
            Me.lblParagraphsCount.TabIndex = 17
            ' 
            ' lblWithSpacesCharactersCount
            ' 
            Me.lblWithSpacesCharactersCount.Location = New System.Drawing.Point(217, 72)
            Me.lblWithSpacesCharactersCount.Name = "lblWithSpacesCharactersCount"
            Me.lblWithSpacesCharactersCount.Size = New System.Drawing.Size(0, 13)
            Me.lblWithSpacesCharactersCount.TabIndex = 16
            ' 
            ' lblNoSpacesCharactersCount
            ' 
            Me.lblNoSpacesCharactersCount.Location = New System.Drawing.Point(217, 52)
            Me.lblNoSpacesCharactersCount.Name = "lblNoSpacesCharactersCount"
            Me.lblNoSpacesCharactersCount.Size = New System.Drawing.Size(0, 13)
            Me.lblNoSpacesCharactersCount.TabIndex = 15
            ' 
            ' lblWordsCount
            ' 
            Me.lblWordsCount.Location = New System.Drawing.Point(217, 32)
            Me.lblWordsCount.Name = "lblWordsCount"
            Me.lblWordsCount.Size = New System.Drawing.Size(0, 13)
            Me.lblWordsCount.TabIndex = 14
            ' 
            ' chkIncludeTextboxes
            ' 
            Me.chkIncludeTextboxes.Location = New System.Drawing.Point(24, 111)
            Me.chkIncludeTextboxes.Name = "chkIncludeTextboxes"
            Me.chkIncludeTextboxes.Properties.Caption = "Include textboxes"
            Me.chkIncludeTextboxes.Size = New System.Drawing.Size(111, 20)
            Me.chkIncludeTextboxes.TabIndex = 13
            AddHandler Me.chkIncludeTextboxes.CheckedChanged, New System.EventHandler(AddressOf Me.OnIncludeTextboxesCheckedChanged)
            ' 
            ' lblParagraphs
            ' 
            Me.lblParagraphs.Location = New System.Drawing.Point(24, 92)
            Me.lblParagraphs.Name = "lblParagraphs"
            Me.lblParagraphs.Size = New System.Drawing.Size(55, 13)
            Me.lblParagraphs.TabIndex = 12
            Me.lblParagraphs.Text = "Paragraphs"
            ' 
            ' lblWithSpacesCharacters
            ' 
            Me.lblWithSpacesCharacters.Location = New System.Drawing.Point(24, 72)
            Me.lblWithSpacesCharacters.Name = "lblWithSpacesCharacters"
            Me.lblWithSpacesCharacters.Size = New System.Drawing.Size(120, 13)
            Me.lblWithSpacesCharacters.TabIndex = 11
            Me.lblWithSpacesCharacters.Text = "Characters (with spaces)"
            ' 
            ' lblNoSpacesCharacters
            ' 
            Me.lblNoSpacesCharacters.Location = New System.Drawing.Point(24, 52)
            Me.lblNoSpacesCharacters.Name = "lblNoSpacesCharacters"
            Me.lblNoSpacesCharacters.Size = New System.Drawing.Size(112, 13)
            Me.lblNoSpacesCharacters.TabIndex = 10
            Me.lblNoSpacesCharacters.Text = "Characters (no spaces)"
            ' 
            ' lblWords
            ' 
            Me.lblWords.Location = New System.Drawing.Point(24, 32)
            Me.lblWords.Name = "lblWords"
            Me.lblWords.Size = New System.Drawing.Size(31, 13)
            Me.lblWords.TabIndex = 9
            Me.lblWords.Text = "Words"
            ' 
            ' lblCaption
            ' 
            Me.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblCaption.LineVisible = True
            Me.lblCaption.Location = New System.Drawing.Point(12, 12)
            Me.lblCaption.Name = "lblCaption"
            Me.lblCaption.Size = New System.Drawing.Size(227, 13)
            Me.lblCaption.TabIndex = 18
            Me.lblCaption.Text = "Statistics"
            ' 
            ' DocumentStatisticsForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(251, 176)
            Me.Controls.Add(Me.lblCaption)
            Me.Controls.Add(Me.lblParagraphsCount)
            Me.Controls.Add(Me.lblWithSpacesCharactersCount)
            Me.Controls.Add(Me.lblNoSpacesCharactersCount)
            Me.Controls.Add(Me.lblWordsCount)
            Me.Controls.Add(Me.chkIncludeTextboxes)
            Me.Controls.Add(Me.lblParagraphs)
            Me.Controls.Add(Me.lblWithSpacesCharacters)
            Me.Controls.Add(Me.lblNoSpacesCharacters)
            Me.Controls.Add(Me.lblWords)
            Me.Controls.Add(Me.btnClose)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.IconOptions.ShowIcon = False
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "DocumentStatisticsForm"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Document Statistics"
            CType((Me.chkIncludeTextboxes.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private btnClose As DevExpress.XtraEditors.SimpleButton

        Private lblParagraphsCount As DevExpress.XtraEditors.LabelControl

        Private lblWithSpacesCharactersCount As DevExpress.XtraEditors.LabelControl

        Private lblNoSpacesCharactersCount As DevExpress.XtraEditors.LabelControl

        Private lblWordsCount As DevExpress.XtraEditors.LabelControl

        Private chkIncludeTextboxes As DevExpress.XtraEditors.CheckEdit

        Private lblParagraphs As DevExpress.XtraEditors.LabelControl

        Private lblWithSpacesCharacters As DevExpress.XtraEditors.LabelControl

        Private lblNoSpacesCharacters As DevExpress.XtraEditors.LabelControl

        Private lblWords As DevExpress.XtraEditors.LabelControl

        Private lblCaption As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
