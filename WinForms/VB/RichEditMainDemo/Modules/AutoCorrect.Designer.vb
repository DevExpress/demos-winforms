Namespace DevExpress.XtraRichEdit.Demos

    Partial Class AutoCorrectModule

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
            Dim optionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
            Me.sharedDictionaryStorage1 = New DevExpress.XtraSpellChecker.SharedDictionaryStorage(Me.components)
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl.MenuManager = Me
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(691, 429)
            Me.richEditControl.SpellChecker = Me.spellChecker1
            Me.spellChecker1.SetSpellCheckerOptions(Me.richEditControl, optionsSpelling1)
            Me.richEditControl.TabIndex = 3
            AddHandler Me.richEditControl.AutoCorrect, New DevExpress.XtraRichEdit.AutoCorrectEventHandler(AddressOf Me.richEditControl_AutoCorrect)
            ' 
            ' spellChecker1
            ' 
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spellChecker1.ParentContainer = Nothing
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.Control = Me.richEditControl
            ' 
            ' AutoCorrectModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.richEditControl)
            Me.Name = "AutoCorrectModule"
            Me.Size = New System.Drawing.Size(691, 429)
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl

        Private sharedDictionaryStorage1 As DevExpress.XtraSpellChecker.SharedDictionaryStorage

        Private spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
    End Class
End Namespace
