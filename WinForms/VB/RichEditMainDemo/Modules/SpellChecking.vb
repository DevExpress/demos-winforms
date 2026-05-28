Imports DevExpress.XtraBars
Imports DevExpress.XtraSpellChecker

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class SpellCheckingModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            ribbonControl1.SelectedPage = ribbonControl1.Pages("Review")
            LoadDocument("SpellChecker.rtf")
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Private Sub barCheckItem1_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            spellChecker1.SpellCheckMode = If(TryCast(sender, BarCheckItem).Checked, SpellCheckMode.AsYouType, SpellCheckMode.OnDemand)
        End Sub
    End Class
End Namespace
