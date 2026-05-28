Imports DevExpress.Office.Internal
Imports DevExpress.XtraRichEdit.Import

Namespace DevExpress.XtraRichEdit.Demos

    Public Class SourcesCodeDocumentImporter
        Inherits PlainTextDocumentImporter

        Friend Shared ReadOnly _filter As FileDialogFilter = New FileDialogFilter("Source Files", New String() {"ts"})

        Public Overrides ReadOnly Property Filter As FileDialogFilter
            Get
                Return _filter
            End Get
        End Property

        Public Overrides ReadOnly Property Format As DocumentFormat
            Get
                Return Id
            End Get
        End Property
    End Class
End Namespace
