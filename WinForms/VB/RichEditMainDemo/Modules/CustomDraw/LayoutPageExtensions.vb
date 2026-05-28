Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.API.Native
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.CompilerServices

Namespace DevExpress.XtraRichEdit.Demos.Modules.CustomDraw

    Friend Module LayoutPageExtensions

        <Extension()>
        Public Function GetVisibleRanges(ByVal layoutPage As LayoutPage, ByVal ranges As IEnumerable(Of FixedRange)) As IEnumerable(Of FixedRange)
            If ranges Is Nothing Then Return Nothing
            Return ranges.Where(New System.Func(Of FixedRange, Boolean)(AddressOf layoutPage.IsRangeVisible))
        End Function

        <Extension()>
        Public Function IsRangeVisible(ByVal layoutPage As LayoutPage, ByVal range As FixedRange) As Boolean
            Dim visibleRange As FixedRange = layoutPage.MainContentRange
            Return visibleRange.Contains(range)
        End Function
    End Module
End Namespace
