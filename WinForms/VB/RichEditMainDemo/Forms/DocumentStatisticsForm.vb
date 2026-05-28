Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit.API.Native

Namespace DevExpress.XtraRichEdit.Demos.Forms

    Public Partial Class DocumentStatisticsForm
        Inherits XtraForm

        Private ReadOnly document As SubDocument

        Public Sub New(ByVal document As SubDocument, ByVal includeTextboxes As Boolean)
            InitializeComponent()
            Me.document = document
            chkIncludeTextboxes.Checked = includeTextboxes
            CalculateStatistics()
        End Sub

        Public ReadOnly Property IncludeTextboxes As Boolean
            Get
                Return chkIncludeTextboxes.Checked
            End Get
        End Property

        Private Sub OnIncludeTextboxesCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            CalculateStatistics()
        End Sub

        Private Sub CalculateStatistics()
            Dim iterator As DocumentIterator = New DocumentIterator(document, True)
            Dim visitor As StaticsticsVisitor = New StaticsticsVisitor(IncludeTextboxes)
            While iterator.MoveNext()
                iterator.Current.Accept(visitor)
            End While

            lblNoSpacesCharactersCount.Text = String.Format("{0,5}", visitor.NoSpacesCharacterCount)
            lblWithSpacesCharactersCount.Text = String.Format("{0,5}", visitor.WithSpacesCharacterCount)
            lblWordsCount.Text = String.Format("{0,5}", visitor.WordCount)
            lblParagraphsCount.Text = String.Format("{0,5}", visitor.ParagraphCount)
        End Sub

        Private Sub OnCloseClick(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub
    End Class

    Public Class StaticsticsVisitor
        Inherits DocumentVisitorBase

        Private ReadOnly _buffer As StringBuilder

        Private ReadOnly includeTextboxes As Boolean

        Private _noSpacesCharacterCount As Integer

        Private _withSpacesCharacterCount As Integer

        Private _wordCount As Integer

        Private _paragraphCount As Integer

        Public Sub New(ByVal includeTextboxes As Boolean)
            _buffer = New StringBuilder()
            Me.includeTextboxes = includeTextboxes
        End Sub

        Private ReadOnly Property Buffer As StringBuilder
            Get
                Return _buffer
            End Get
        End Property

        Public ReadOnly Property NoSpacesCharacterCount As Integer
            Get
                Return _noSpacesCharacterCount
            End Get
        End Property

        Public ReadOnly Property WithSpacesCharacterCount As Integer
            Get
                Return _withSpacesCharacterCount
            End Get
        End Property

        Public ReadOnly Property WordCount As Integer
            Get
                Return _wordCount
            End Get
        End Property

        Public ReadOnly Property ParagraphCount As Integer
            Get
                Return _paragraphCount
            End Get
        End Property

        Public Overrides Sub Visit(ByVal text As DocumentText)
            Buffer.Append(text.Text)
        End Sub

        Public Overrides Sub Visit(ByVal textBox As DocumentTextBox)
            If Not includeTextboxes Then Return
            Dim iterator As DocumentIterator = textBox.GetIterator(True)
            Dim visitor As StaticsticsVisitor = New StaticsticsVisitor(False)
            While iterator.MoveNext()
                iterator.Current.Accept(visitor)
            End While

            _noSpacesCharacterCount += visitor.NoSpacesCharacterCount
            _withSpacesCharacterCount += visitor.WithSpacesCharacterCount
            _wordCount += visitor.WordCount
            _paragraphCount += visitor.ParagraphCount
        End Sub

        Public Overrides Sub Visit(ByVal sectionEnd As DocumentSectionEnd)
            FinishParagraph()
        End Sub

        Public Overrides Sub Visit(ByVal paragraphEnd As DocumentParagraphEnd)
            FinishParagraph()
        End Sub

        Private Sub FinishParagraph()
            Dim text As String = Buffer.ToString()
            _noSpacesCharacterCount += text.Count(Function(c) Not Char.IsWhiteSpace(c))
            _withSpacesCharacterCount += text.Length
            _wordCount += text.Split((New Char() {" "c, "."c, "!"c, "?"c}), StringSplitOptions.RemoveEmptyEntries).Length
            If Not String.IsNullOrWhiteSpace(text) Then _paragraphCount += 1
            Buffer.Length = 0
        End Sub
    End Class
End Namespace
