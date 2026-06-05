Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Demos.Modules.CustomDraw
Imports Color = System.Drawing.Color

Namespace DevExpress.XtraRichEdit.Demos

    Public Class CustomDrawPagePainter
        Inherits PagePainter

        Public Property LayoutElementHighlights As List(Of CustomDrawHighlightInfo)

        Public Property LayoutRowHighlights As List(Of CustomDrawHighlightInfo)

        Const OutlineHighlightThicknessLayoutUnits As Integer = 2

        Private Shared ReadOnly defaultHighlightColor As Color = Color.Yellow

        Private Shared ReadOnly defaultHighlightType As CustomDrawHighlightType = CustomDrawHighlightType.Fill

        Private Shared ReadOnly defaultRowHighlightColor As Color = Color.Blue

        Private Shared ReadOnly defaultRowHighlightType As CustomDrawHighlightType = CustomDrawHighlightType.Outline

        Private ReadOnly _richEditControl As RichEditControl

        Public Sub New(ByVal richEdit As RichEditControl)
            _richEditControl = richEdit
        End Sub

        Public Sub New(ByVal richEdit As RichEditControl, ByVal rangesForHighlight As List(Of FixedRange), ByVal rangeForRowHighlight As FixedRange)
            Me.New(richEdit)
            LayoutElementHighlights = rangesForHighlight.[Select](Function(r) New CustomDrawHighlightInfo(r, defaultHighlightType, defaultHighlightColor)).ToList()
            LayoutRowHighlights = New List(Of CustomDrawHighlightInfo)()
            If rangeForRowHighlight IsNot Nothing Then LayoutRowHighlights.Add(New CustomDrawHighlightInfo(rangeForRowHighlight, defaultRowHighlightType, defaultRowHighlightColor))
        End Sub

        Private Property IsHighlightingAllowed As Boolean

        Public Overrides Sub DrawPageArea(ByVal pageArea As LayoutPageArea)
            IsHighlightingAllowed = True
            MyBase.DrawPageArea(pageArea)
            IsHighlightingAllowed = False
        End Sub

        Public Overrides Sub DrawRow(ByVal row As LayoutRow)
            If IsHighlightingAllowed AndAlso LayoutRowHighlights IsNot Nothing Then
                Dim highlightBounds = row.Bounds
                Dim parentLayoutCell As LayoutTableCell = TryCast(row.Parent, LayoutTableCell)
                If parentLayoutCell IsNot Nothing Then
                    highlightBounds.X = parentLayoutCell.Bounds.X
                    highlightBounds.Width = parentLayoutCell.Bounds.Width
                End If

                For Each rowHighlight In LayoutRowHighlights.Where(Function(rh) row.Range.Intersect(rh.HighlightRange))
                    DrawHighlight(rowHighlight.HighlightColor, highlightBounds, rowHighlight.HighlightType)
                Next
            End If

            MyBase.DrawRow(row)
        End Sub

        Public Overrides Sub DrawPlainTextBox(ByVal plainTextBox As PlainTextBox)
            HighlightElement(plainTextBox)
            MyBase.DrawPlainTextBox(plainTextBox)
        End Sub

        Public Overrides Sub DrawPageNumberBox(ByVal pageNumberBox As PlainTextBox)
            HighlightElement(pageNumberBox)
            MyBase.DrawPageNumberBox(pageNumberBox)
        End Sub

        Public Overrides Sub DrawSpaceBox(ByVal spaceBox As PlainTextBox)
            HighlightElement(spaceBox)
            MyBase.DrawSpaceBox(spaceBox)
        End Sub

        Private Sub HighlightElement(ByVal element As PlainTextBox)
            If Not IsHighlightingAllowed Then Return
            If LayoutElementHighlights Is Nothing Then Return
            For Each elementHighlight In LayoutElementHighlights.Where(Function(eh) element.Range.Intersect(eh.HighlightRange))
                Dim highlightRange = elementHighlight.HighlightRange
                If highlightRange.Equals(element.Range) Then
                    DrawHighlight(elementHighlight.HighlightColor, element.Bounds, elementHighlight.HighlightType)
                Else
                    Dim characterBoxes As CharacterBoxCollection = _richEditControl.DocumentLayout.Split(element)
                    Dim firstBox As CharacterBox = characterBoxes(0)
                    Dim lastBox As CharacterBox = characterBoxes(characterBoxes.Count - 1)
                    For Each box As CharacterBox In characterBoxes
                        If box.Range.Start = highlightRange.Start Then firstBox = box
                        If box.Range.Start + box.Range.Length = highlightRange.Start + highlightRange.Length Then lastBox = box
                    Next

                    Dim charactersBoundingBox = Rectangle.FromLTRB(firstBox.Bounds.X, firstBox.Bounds.Y, lastBox.Bounds.Right, lastBox.Bounds.Bottom)
                    DrawHighlight(elementHighlight.HighlightColor, charactersBoundingBox, elementHighlight.HighlightType)
                End If
            Next
        End Sub

        Private Sub DrawHighlight(ByVal highlightColor As Color, ByVal bounds As Rectangle, ByVal highlightType As CustomDrawHighlightType)
            Select Case highlightType
                Case CustomDrawHighlightType.Fill
                    Dim brush = New RichEditBrush(highlightColor)
                    Canvas.FillRectangle(brush, bounds)
                Case CustomDrawHighlightType.Outline
                    Dim pen = New RichEditPen(highlightColor, Canvas.ConvertToDrawingLayoutUnits(OutlineHighlightThicknessLayoutUnits, _richEditControl.LayoutUnit))
                    Canvas.DrawRectangle(pen, bounds)
                Case Else
                    Return
            End Select
        End Sub
    End Class
End Namespace
