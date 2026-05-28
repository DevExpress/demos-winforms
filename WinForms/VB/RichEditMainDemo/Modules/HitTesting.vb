Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraRichEdit.API.Layout

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class HitTestingModule
        Inherits TutorialControl

        Private ReadOnly _highlightOptions As Dictionary(Of LayoutType, RichEditPen) = New Dictionary(Of LayoutType, RichEditPen)()

        Public Sub New()
            InitializeComponent()
            LoadDocument("HitTest.docx")
            Dim ribbonControl As RibbonControl = richEditControl.CreateRibbon()
            Controls.Add(ribbonControl)
            cbScope.Properties.Items.AddEnum(Of ScopeType)()
            cbScope.SelectedIndex = 0
            SpecifyHighlightOptions()
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Private Property CurrentPageIndex As Integer

        Private Property HitTestResult As RichEditHitTestResult

        Private ReadOnly Property HighlightOptions As Dictionary(Of LayoutType, RichEditPen)
            Get
                Return _highlightOptions
            End Get
        End Property

        Private Sub RichEditControl_BeforePagePaint(ByVal sender As Object, ByVal e As BeforePagePaintEventArgs)
            If e.CanvasOwnerType = CanvasOwnerType.Control AndAlso e.Page.Index = CurrentPageIndex AndAlso HitTestResult IsNot Nothing Then
                Dim defaultHighlightingPen As RichEditPen = If(highlightOther.Checked, New RichEditPen(otherHigtlightColor.Color, 3), Nothing)
                e.Painter = New HitTestPagePainter(RichEditHitTestResult.Reverse(HitTestResult), HighlightOptions, defaultHighlightingPen)
            End If
        End Sub

        Private Sub HitTest(ByVal point As Point)
            Dim pageLayoutPosition As PageLayoutPosition = RichEdit.ActiveView.GetDocumentLayoutPosition(point)
            If pageLayoutPosition Is Nothing Then
                HitTestResult = Nothing
                Return
            End If

            CurrentPageIndex = pageLayoutPosition.PageIndex
            Dim position As Point = pageLayoutPosition.Position
            Dim page As LayoutPage = RichEdit.DocumentLayout.GetPage(CurrentPageIndex)
            Dim hitTestManager As HitTestManager = New HitTestManager(RichEdit.DocumentLayout)
            Dim searchOption As HitTestSearchOption = If(rgSearchOptions.SelectedIndex = 0, HitTestSearchOption.Exact, HitTestSearchOption.Nearest)
            Select Case CType(cbScope.EditValue, ScopeType)
                Case ScopeType.Page
                    HitTestResult = hitTestManager.HitTest(page, position, searchOption)
                Case ScopeType.MainPageArea
                    HitTestResult = hitTestManager.HitTest(page.PageAreas(0), position, searchOption)
                Case ScopeType.HeaderPageArea
                    If page.Header IsNot Nothing Then HitTestResult = hitTestManager.HitTest(page.Header, position, searchOption)
                Case ScopeType.FooterPageArea
                    If page.Footer IsNot Nothing Then HitTestResult = hitTestManager.HitTest(page.Footer, position, searchOption)
            End Select
        End Sub

        Private Sub OnHighlightOptionsChanged(ByVal sender As Object, ByVal e As EventArgs)
            SpecifyHighlightOptions()
        End Sub

        Private Sub SpecifyHighlightOptions()
            HighlightOptions.Clear()
            HighlightOptions.Add(LayoutType.Page, If(highlightPage.Checked, New RichEditPen(pageHigtlightColor.Color, 3), Nothing))
            HighlightOptions.Add(LayoutType.PageArea, If(highlightPageArea.Checked, New RichEditPen(pageAreaHigtlightColor.Color, 3), Nothing))
            HighlightOptions.Add(LayoutType.Column, If(highlightColumn.Checked, New RichEditPen(columnHigtlightColor.Color, 3), Nothing))
            HighlightOptions.Add(LayoutType.Row, If(highlightRow.Checked, New RichEditPen(rowHigtlightColor.Color, 3), Nothing))
            HighlightOptions.Add(LayoutType.PlainTextBox, If(highlightBox.Checked, New RichEditPen(boxHigtlightColor.Color, 3), Nothing))
            HighlightOptions.Add(LayoutType.CharacterBox, If(highlightCharacterBox.Checked, New RichEditPen(characterBoxHigtlightColor.Color, 3), Nothing))
        End Sub

        Private Sub RichEditControl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            HitTest(e.Location)
            RichEdit.Invalidate()
        End Sub

        Private Sub RichEditControl_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            lbResult.Items.Clear()
            Dim reversedResult As RichEditHitTestResult = RichEditHitTestResult.Reverse(HitTestResult)
            Dim i As Integer = 0
            While reversedResult IsNot Nothing
                Dim item As String = String.Format("{0}- {1}", Concat(" "c, i * 2), reversedResult.LayoutElement.Type)
                lbResult.Items.Add(item)
                reversedResult = reversedResult.Next
                i += 1
            End While
        End Sub

        Private Function Concat(ByVal c As Char, ByVal count As Integer) As String
            Dim builder As StringBuilder = New StringBuilder(count)
            builder.Append(c, count)
            Return builder.ToString()
        End Function
    End Class
End Namespace
