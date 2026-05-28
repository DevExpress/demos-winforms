Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text.RegularExpressions
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Services

Namespace DevExpress.XtraRichEdit.Demos

    Public Class SyntaxHighlightService
        Implements ISyntaxHighlightService

        Private ReadOnly _editor As RichEditControl

        Private ReadOnly _keywords As Regex

        Private ReadOnly _quotedString As Regex = New Regex("""[^""\\]*(?:\\.[^""\\]*)*""")

        Private ReadOnly _commentedString As Regex = New Regex("(/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/)|(//.*)")

        Public Sub New(ByVal editor As RichEditControl)
            _editor = editor
            Dim keywords As String() = {"break", "boolean", "case", "catch", "class", "const", "continue", "default", "delete", "do", "else", "enum", "export", "extends", "false", "finally", "for", "function", "if", "import", "in", "new", "null", "return", "super", "switch", "this", "throw", "true", "try", "typeof", "var", "void", "while", "with", "module", "protected", "implements", "interface", "package", "private", "public", "static", "any", "number", "string", "symbol", "abstract", "as", "constructor", "from", "get", "is", "namespace", "of", "set", "type", "let"}
            _keywords = New Regex("\b(" & String.Join("|", keywords.[Select](Function(w) Regex.Escape(w))) & ")\b")
        End Sub

        Public Sub Execute()
            Dim tokens As List(Of SyntaxHighlightToken) = New List(Of SyntaxHighlightToken)()
            Dim ranges As DocumentRange() = _editor.Document.FindAll(_commentedString)
            For Each range As DocumentRange In ranges
                tokens.Add(CreateToken(range.Start.ToInt(), range.End.ToInt(), Color.Green))
                CheckTokens(tokens)
            Next

            ranges = _editor.Document.FindAll(_quotedString)
            For Each range As DocumentRange In ranges
                TryUpdateTokens(tokens, range, Function(r) CreateToken(r.Start.ToInt(), r.End.ToInt(), Color.Brown))
            Next

            ranges = _editor.Document.FindAll(_keywords)
            For Each range As DocumentRange In ranges
                TryUpdateTokens(tokens, range, Function(r) CreateToken(r.Start.ToInt(), r.End.ToInt(), Color.Blue))
            Next

            tokens.Sort(Function(token1, token2) token1.Start.CompareTo(token2.Start))
            tokens = CombineWithPlainTextTokens(tokens)
            'CheckTokens(tokens);
            _editor.Document.ApplySyntaxHighlight(tokens)
        End Sub

        Private Sub TryUpdateTokens(ByVal tokens As List(Of SyntaxHighlightToken), ByVal range As DocumentRange, ByVal factory As Func(Of DocumentRange, SyntaxHighlightToken))
            Dim startTokenIndex As Integer = FindTokenIndex(range.Start.ToInt(), tokens)
            Dim endTokenIndex As Integer = FindTokenIndex(range.End.ToInt(), tokens)
            If startTokenIndex >= 0 Then Return
            If endTokenIndex >= 0 Then Return
            If startTokenIndex <> endTokenIndex Then tokens.RemoveRange(Not startTokenIndex, Not endTokenIndex - Not startTokenIndex)
            tokens.Insert(Not startTokenIndex, factory.Invoke(range))
        'CheckTokens(tokens);
        End Sub

        <System.Diagnostics.Conditional("DEBUG")>
        Private Sub CheckTokens(ByVal tokens As List(Of SyntaxHighlightToken))
            Dim count As Integer = tokens.Count
            If count > 0 Then System.Diagnostics.Debug.Assert(tokens(0).End >= tokens(0).Start)
            For i As Integer = 1 To count - 1
                System.Diagnostics.Debug.Assert(tokens(i).End >= tokens(i).Start)
                System.Diagnostics.Debug.Assert(tokens(i).Start >= tokens(i - 1).End)
            Next
        End Sub

        Private Function CombineWithPlainTextTokens(ByVal tokens As List(Of SyntaxHighlightToken)) As List(Of SyntaxHighlightToken)
            Dim result As List(Of SyntaxHighlightToken) = New List(Of SyntaxHighlightToken)(tokens.Count * 2 + 1)
            Dim documentStart As Integer = _editor.Document.Range.Start.ToInt()
            Dim documentEnd As Integer = _editor.Document.Range.End.ToInt()
            If tokens.Count = 0 Then
                result.Add(CreateToken(documentStart, documentEnd, Color.Black))
            Else
                Dim firstToken As SyntaxHighlightToken = tokens(0)
                If documentStart < firstToken.Start Then result.Add(CreateToken(documentStart, firstToken.Start, Color.Black))
                result.Add(firstToken)
                For i As Integer = 1 To tokens.Count - 1
                    Dim token As SyntaxHighlightToken = tokens(i)
                    Dim prevToken As SyntaxHighlightToken = tokens(i - 1)
                    If prevToken.End <> token.Start Then result.Add(CreateToken(prevToken.End, token.Start, Color.Black))
                    result.Add(token)
                Next

                Dim lastToken As SyntaxHighlightToken = tokens(tokens.Count - 1)
                If documentEnd > lastToken.End Then result.Add(CreateToken(lastToken.End, documentEnd, Color.Black))
            End If

            Return result
        End Function

        Private Function CreateToken(ByVal start As Integer, ByVal [end] As Integer, ByVal foreColor As Color) As SyntaxHighlightToken
            Dim properties As SyntaxHighlightProperties = New SyntaxHighlightProperties()
            properties.ForeColor = foreColor
            Return New SyntaxHighlightToken(start, [end] - start, properties)
        End Function

        Private Function FindTokenIndex(ByVal position As Integer, ByVal tokens As List(Of SyntaxHighlightToken)) As Integer
            Dim startTokenIndex As Integer = BinarySearch(tokens, 0, tokens.Count, position)
            If startTokenIndex >= 0 Then Return startTokenIndex
            Dim tokenIndex As Integer = Not startTokenIndex
            tokenIndex -= 1
            If tokenIndex < 0 Then Return startTokenIndex
            If tokens(tokenIndex).Start <= position AndAlso position <= tokens(tokenIndex).End Then Return tokenIndex
            Return startTokenIndex
        End Function

        Private Shared Function BinarySearch(ByVal list As List(Of SyntaxHighlightToken), ByVal index As Integer, ByVal length As Integer, ByVal position As Integer) As Integer
            Dim i As Integer = index
            Dim num As Integer = index + length - 1
            While i <= num
                Dim pos As Integer = i + (num - i >> 1)
                Dim result As Integer = Math.Sign(list(pos).Start - position)
                If result = 0 Then Return pos
                If result < 0 Then
                    i = pos + 1
                Else
                    num = pos - 1
                End If
            End While

            Return Not i
        End Function

        Private Sub ForceExecute() Implements ISyntaxHighlightService.ForceExecute
            Execute()
        End Sub

        Private Sub ISyntaxHighlightService_Execute() Implements ISyntaxHighlightService.Execute
            Execute()
        End Sub
    End Class
End Namespace
