Imports System.Drawing
Imports DevExpress.XtraRichEdit.API.Native

Namespace DevExpress.XtraRichEdit.Demos.Modules.CustomDraw

    Public Enum CustomDrawHighlightType
        Fill
        Outline
    End Enum

    Public Class CustomDrawHighlightInfo

        Public ReadOnly Property HighlightRange As FixedRange

        Public ReadOnly Property HighlightType As CustomDrawHighlightType

        Public ReadOnly Property HighlightColor As Color

        Public Sub New(ByVal highlightedRange As FixedRange, ByVal highlightType As CustomDrawHighlightType, ByVal highlightColor As Color)
            HighlightRange = highlightedRange
            Me.HighlightType = highlightType
            Me.HighlightColor = highlightColor
        End Sub
    End Class
End Namespace
