Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class CommentsModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            Dim ribbonControl As RibbonControl = richEditControl.CreateRibbon(RichEditToolbarType.File Or RichEditToolbarType.Home Or RichEditToolbarType.Review)
            Controls.Add(ribbonControl)
            ribbonControl.SelectedPage = ribbonControl.Pages("Review")
            LoadDocument("Comments.docx")
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property
    End Class
End Namespace
