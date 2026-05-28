Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class NavigationModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            Dim ribbonControl As RibbonControl = richEditControl.CreateRibbon(RichEditToolbarType.File Or RichEditToolbarType.Home Or RichEditToolbarType.Insert Or RichEditToolbarType.References)
            Controls.Add(ribbonControl)
            ribbonControl.SelectedPage = ribbonControl.Pages("References")
            LoadDocument("Navigation.docx")
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property
    End Class
End Namespace
