Imports DevExpress.DXperience.Demos

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class DocumentManagerNoDocumentsMode
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            richEditControl1.Text = DemosInfo.GetLoremIpsumText(0)
        End Sub
    End Class
End Namespace
