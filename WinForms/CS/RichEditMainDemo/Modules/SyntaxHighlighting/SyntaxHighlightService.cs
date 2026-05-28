using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;

namespace DevExpress.XtraRichEdit.Demos {
    public class SyntaxHighlightService : ISyntaxHighlightService {
        readonly RichEditControl _editor;
        readonly Regex _keywords;
        readonly Regex _quotedString = new Regex(@"""[^""\\]*(?:\\.[^""\\]*)*""");
        readonly Regex _commentedString = new Regex(@"(/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/)|(//.*)");

        public SyntaxHighlightService(RichEditControl editor) {
            _editor = editor;
            string[] keywords = { "break", "boolean", "case", "catch", "class", "const", "continue", "default", "delete", "do", "else", "enum", "export", "extends", "false", "finally", "for", "function", "if", "import", "in", "new", "null", "return", "super", "switch", "this", "throw", "true", "try", "typeof", "var", "void", "while", "with", "module", "protected", "implements", "interface", "package", "private", "public", "static", "any", "number", "string", "symbol", "abstract", "as", "constructor", "from", "get", "is", "namespace", "of", "set", "type", "let" };
            _keywords = new Regex(@"\b(" + string.Join("|", keywords.Select(w => Regex.Escape(w))) + @")\b");
        }

        public void Execute() {
            List<SyntaxHighlightToken> tokens = new List<SyntaxHighlightToken>();

            DocumentRange[] ranges = _editor.Document.FindAll(_commentedString);
            foreach(DocumentRange range in ranges) {
                tokens.Add(CreateToken(range.Start.ToInt(), range.End.ToInt(), Color.Green));
                CheckTokens(tokens);
            }

            ranges = _editor.Document.FindAll(_quotedString);
            foreach(DocumentRange range in ranges)
                TryUpdateTokens(tokens, range, (r) => CreateToken(r.Start.ToInt(), r.End.ToInt(), Color.Brown));

            ranges = _editor.Document.FindAll(_keywords);
            foreach(DocumentRange range in ranges)
                TryUpdateTokens(tokens, range, (r) => CreateToken(r.Start.ToInt(), r.End.ToInt(), Color.Blue));

            tokens.Sort((token1, token2) => { return token1.Start.CompareTo(token2.Start); });
            tokens = CombineWithPlainTextTokens(tokens);
            //CheckTokens(tokens);
            _editor.Document.ApplySyntaxHighlight(tokens);
        }
        void TryUpdateTokens(List<SyntaxHighlightToken> tokens, DocumentRange range, Func<DocumentRange, SyntaxHighlightToken> factory) {
            int startTokenIndex = FindTokenIndex(range.Start.ToInt(), tokens);
            int endTokenIndex = FindTokenIndex(range.End.ToInt(), tokens);
            if(startTokenIndex >= 0)
                return;
            if(endTokenIndex >= 0)
                return;
            if(startTokenIndex != endTokenIndex)
                tokens.RemoveRange(~startTokenIndex, ~endTokenIndex - ~startTokenIndex);

            tokens.Insert(~startTokenIndex, factory.Invoke(range));

            //CheckTokens(tokens);
        }
        [System.Diagnostics.Conditional("DEBUG")]
        void CheckTokens(List<SyntaxHighlightToken> tokens) {
            int count = tokens.Count;
            if(count > 0)
                System.Diagnostics.Debug.Assert(tokens[0].End >= tokens[0].Start);

            for(int i = 1; i < count; i++) {
                System.Diagnostics.Debug.Assert(tokens[i].End >= tokens[i].Start);
                System.Diagnostics.Debug.Assert(tokens[i].Start >= tokens[i - 1].End);
            }
        }
        List<SyntaxHighlightToken> CombineWithPlainTextTokens(List<SyntaxHighlightToken> tokens) {
            List<SyntaxHighlightToken> result = new List<SyntaxHighlightToken>(tokens.Count * 2 + 1);
            int documentStart = _editor.Document.Range.Start.ToInt();
            int documentEnd = _editor.Document.Range.End.ToInt();
            if(tokens.Count == 0)
                result.Add(CreateToken(documentStart, documentEnd, Color.Black));
            else {
                SyntaxHighlightToken firstToken = tokens[0];
                if(documentStart < firstToken.Start)
                    result.Add(CreateToken(documentStart, firstToken.Start, Color.Black));
                result.Add(firstToken);
                for(int i = 1; i < tokens.Count; i++) {
                    SyntaxHighlightToken token = tokens[i];
                    SyntaxHighlightToken prevToken = tokens[i - 1];
                    if(prevToken.End != token.Start)
                        result.Add(CreateToken(prevToken.End, token.Start, Color.Black));
                    result.Add(token);
                }
                SyntaxHighlightToken lastToken = tokens[tokens.Count - 1];
                if(documentEnd > lastToken.End)
                    result.Add(CreateToken(lastToken.End, documentEnd, Color.Black));
            }
            return result;
        }
        SyntaxHighlightToken CreateToken(int start, int end, Color foreColor) {
            SyntaxHighlightProperties properties = new SyntaxHighlightProperties();
            properties.ForeColor = foreColor;
            return new SyntaxHighlightToken(start, end - start, properties);
        }
        int FindTokenIndex(int position, List<SyntaxHighlightToken> tokens) {
            int startTokenIndex = BinarySearch(tokens, 0, tokens.Count, position);
            if(startTokenIndex >= 0)
                return startTokenIndex;

            int tokenIndex = ~startTokenIndex;
            tokenIndex--;
            if(tokenIndex < 0)
                return startTokenIndex;

            if(tokens[tokenIndex].Start <= position && position <= tokens[tokenIndex].End)
                return tokenIndex;

            return startTokenIndex;
        }
        static int BinarySearch(List<SyntaxHighlightToken> list, int index, int length, int position) {
            int i = index;
            int num = index + length - 1;
            while(i <= num) {
                int pos = i + (num - i >> 1);
                int result = Math.Sign(list[pos].Start - position);
                if(result == 0)
                    return pos;
                if(result < 0)
                    i = pos + 1;
                else
                    num = pos - 1;
            }
            return ~i;
        }
        void ISyntaxHighlightService.ForceExecute() {
            Execute();
        }
        void ISyntaxHighlightService.Execute() {
            Execute();
        }
    }
}
