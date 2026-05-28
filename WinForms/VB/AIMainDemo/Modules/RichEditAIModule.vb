Imports System.Reflection
Imports DevExpress.XtraRichEdit
Imports System.IO
Imports DevExpress.DXperience.Demos

Namespace DevExpress.AI.Demos

    Public Partial Class RichEditAIModule
        Inherits AITutorialControl

        Public Sub New()
            AutoMergeRibbon = True
            InitializeComponent()
            If Not DemoHelper.IsTesting Then
                Using documentStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.AI.Demos.Data.FirstLook.docx")
                    If documentStream Is Nothing Then Throw New FileNotFoundException("Embedded document resource not found.")
                    richEditControl1.LoadDocument(documentStream, DocumentFormat.OpenXml)
                End Using
            Else
                richEditControl1.Options.VerticalScrollbar.Visibility = RichEditScrollbarVisibility.Hidden
            End If

            UpdatePaddings()
        End Sub

        Protected Overrides Sub UpdatePaddings()
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub
    End Class
End Namespace
