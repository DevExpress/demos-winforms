Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Demos.Modules.CustomDraw
Imports DevExpress.XtraRichEdit.Services

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class CustomDrawModule
        Inherits TutorialControl

        Private ReadOnly _searchResult As List(Of FixedRange) = New List(Of FixedRange)()

        Private _currentItemIndex As Integer = -1

        Public Sub New()
            InitializeComponent()
            ribbonControl1 = richEditControl.CreateRibbon()
            Controls.Add(ribbonControl1)
            LoadDocument("CustomDraw.docx")
            Dim commandFactoryService As IRichEditCommandFactoryService = richEditControl.GetService(Of IRichEditCommandFactoryService)()
            richEditControl.ReplaceService(Of IRichEditCommandFactoryService)(New CustomsRichEditCommandFactoryService(richEditControl, commandFactoryService, searchControl))
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Private ReadOnly Property SearchResult As List(Of FixedRange)
            Get
                Return _searchResult
            End Get
        End Property

        Private Property CurrentItemIndex As Integer
            Get
                Return _currentItemIndex
            End Get

            Set(ByVal value As Integer)
                If value < 0 OrElse value >= SearchResult.Count Then Return
                _currentItemIndex = value
                Dim fixedRange As FixedRange = SearchResult(_currentItemIndex)
                Dim range As DocumentRange = richEditControl.Document.CreateRange(fixedRange.Start, fixedRange.Length)
                richEditControl.Document.ChangeActiveDocument(richEditControl.Document)
                richEditControl.Document.Selection = range
                richEditControl.ScrollToCaret()
                UpdateSearchOptionsUI()
            End Set
        End Property

        Private ReadOnly Property IsSelectionInMainDocument As Boolean
            Get
                Return Not richEditControl.IsSelectionInTextBox AndAlso Not richEditControl.IsSelectionInHeaderOrFooter AndAlso Not richEditControl.IsSelectionInComment
            End Get
        End Property

        Private Sub richEditControl_BeforePagePaint(ByVal sender As Object, ByVal e As BeforePagePaintEventArgs)
            If e.CanvasOwnerType = CanvasOwnerType.Printer OrElse SearchResult.Count = 0 Then Return
            Dim currentItem As FixedRange = SearchResult(CurrentItemIndex)
            Dim visibleSearchResult As List(Of FixedRange) = e.Page.GetVisibleRanges(SearchResult).ToList()
            e.Painter = New CustomDrawPagePainter(richEditControl, visibleSearchResult, currentItem)
        End Sub

        Private Sub richEditControl_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            SearchResult.Clear()
        End Sub

        Private Sub navigationButtonEdit_Properties_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
            CurrentItemIndex += If(e.Button.Kind = ButtonPredefines.Down, 1, -1)
        End Sub

        Private Sub searchTextBox_Properties_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
            If e.Button.Kind = ButtonPredefines.Close Then searchControl.Text = String.Empty
        End Sub

        Private Sub searchTextBox_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            FindText()
        End Sub

        Private Sub searchTextBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyData = Keys.Enter Then FindText()
            If e.KeyData = Keys.Escape Then
                searchControl.Text = String.Empty
                richEditControl.Focus()
            End If
        End Sub

        Private Sub OnSearchOptionsChanged(ByVal sender As Object, ByVal e As EventArgs)
            FindText()
        End Sub

        Private Sub FindText()
            SearchResult.Clear()
            Dim textToSearch As String = searchControl.Text
            If IsSelectionInMainDocument AndAlso Not String.IsNullOrEmpty(textToSearch) Then
                Dim options As SearchOptions = GetSearchOptions()
                Dim ranges As IEnumerable(Of DocumentRange) = RichEdit.Document.FindAll(textToSearch, options).GetAsFrozen()
                For Each range As DocumentRange In ranges
                    SearchResult.Add(New FixedRange(range.Start.ToInt(), range.Length))
                Next
            End If

            CurrentItemIndex = 0
            UpdateSearchOptionsUI()
            richEditControl.Refresh()
        End Sub

        Private Sub UpdateSearchOptionsUI()
            'this.searchResultAndButtonsGroup.Visibility = !String.IsNullOrEmpty(this.searchControl.Text) && SearchResult.Count > 0 ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
            navigationButtonsEdit.ContentVisible = Not String.IsNullOrEmpty(searchControl.Text) AndAlso SearchResult.Count > 0
            For Each button As EditorButton In searchControl.Properties.Buttons
                button.Visible = Not String.IsNullOrEmpty(searchControl.Text)
            Next

            If String.IsNullOrEmpty(searchControl.Text) Then
                searchText.Text = String.Empty
            ElseIf SearchResult.Count = 0 Then
                searchText.Text = "No matches"
            Else
                searchText.Text = String.Format("{0} of {1} matches", CurrentItemIndex + 1, SearchResult.Count)
            End If
        End Sub

        Private Function GetSearchOptions() As SearchOptions
            Dim result As SearchOptions = SearchOptions.None
            If matchCase.Checked Then result = result Or SearchOptions.CaseSensitive
            If findWholeWordsOnly.Checked Then result = result Or SearchOptions.WholeWord
            Return result
        End Function

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            BeginInvoke(New Action(AddressOf FindText))
        End Sub
    End Class
End Namespace
