Imports System
Imports System.ComponentModel
Imports System.Drawing
' <icbScrollBars>
Imports DevExpress.XtraEditors.Controls
' </icbScrollBars>
Imports System.Windows.Forms
Imports DevExpress.Tutorials
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleMemoEdit
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitializeDefaultColors()
            AddHandler tabPane1.SizeChanged, AddressOf OnGeneralUserControlSizeChanged
            AddHandler tabPane1.SelectedPageChanged, AddressOf SelectedPageChanged
        End Sub

        Private Sub OnGeneralUserControlSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            CalcContentCore()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
        End Sub

        Private Sub SelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            sidePanel1.Visible = e.Page.Caption.Contains("Highlight")
            CalcContentCore()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleMemoEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "memoedit"
            End Get
        End Property

        Private updateValues As Boolean = False

        Private Sub ModuleMemoEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlUtils.CenterControlInParent(memoEditSample)
            commentColorPickEdit.Color = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText
            numberColorPickEdit.Color = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning
            stringColorPickEdit.Color = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information
            keywordColorPickEdit.Color = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question
            memoEditSample.Text = "MemoEdit is a multi-line text editor. In addition to the advanced text input features derived from the TextEdit control, it offers numerous options for multi-line text management.

- Optional ENTER and TAB key processing.
- Customizable visibility for vertical and horizontal scrollbars.
- Optional text word-wrapping.
- Specifying height in text lines (if used within a container control such as the XtraGrid, XtraTreeList, and XtraVerticalGrid)."
            memoEdit1.Text = "-- Create a database
DROP DATABASE IF EXISTS myDataBase;
CREATE DATABASE myDataBase;
USE myDataBase;

-- Create a table
DROP TABLE IF EXISTS fruits;
CREATE TABLE fruits (id INTEGER NOT NULL PRIMARY KEY, name VARCHAR(20), cnt INTEGER);
INSERT INTO fruits (name, cnt) VALUES ('orange', 1500);
INSERT INTO fruits (name, cnt) VALUES ('apple', 2000);
INSERT INTO fruits (name, cnt) VALUES ('pineapple', 500);

-- Select
SELECT * FROM fruits;

-- Update
UPDATE fruits SET cnt = 400 WHERE id = 2;
SELECT * FROM fruits;

-- Delete
DELETE FROM fruits WHERE id = 1;
SELECT * FROM fruits;
"
            InitComboBoxes()
            InitValues()
        End Sub

        Protected Overrides Sub CalcContentCore()
            If Not Visible OrElse Not IsHandleCreated Then Return
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Private Sub InitComboBoxes()
            ' <icbScrollBars>
            icbScrollBars.Properties.Items.AddEnum(GetType(ScrollBars))
        ' </icbScrollBars>
        End Sub

        Private Sub InitValues()
            updateValues = True
            icbScrollBars.EditValue = memoEditSample.Properties.ScrollBars
            ceWordWrap.Checked = memoEditSample.Properties.WordWrap
            ceReturn.Checked = memoEditSample.Properties.AcceptsReturn
            ceTab.Checked = memoEditSample.Properties.AcceptsTab
            seMaxLength.Value = memoEditSample.Properties.MaxLength
            updateValues = False
        End Sub

        ' <icbScrollBars>
        Private Sub icbScrollBars_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            memoEditSample.Properties.ScrollBars = CType(icbScrollBars.EditValue, ScrollBars)
        End Sub

        ' </icbScrollBars>
        ' <ceWordWrap>
        Private Sub ceWordWrap_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            memoEditSample.Properties.WordWrap = ceWordWrap.Checked
        End Sub

        ' </ceWordWrap>
        ' <ceReturn>
        Private Sub ceReturn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            memoEditSample.Properties.AcceptsReturn = ceReturn.Checked
        End Sub

        ' </ceReturn>
        ' <ceTab>
        Private Sub ceTab_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            memoEditSample.Properties.AcceptsTab = ceTab.Checked
        End Sub

        ' </ceTab>
        ' <seMaxLength>
        Private Sub seMaxLength_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' <skip>
            If updateValues Then Return
            ' </skip>
            memoEditSample.Properties.MaxLength = Convert.ToInt32(seMaxLength.Value)
        End Sub

        ' </seMaxLength>
        Private Property KeywordColor As Color

        Private Property StringColor As Color

        Private Property CommentColor As Color

        Private Property NumberColor As Color

        Private Sub InitializeDefaultColors()
            KeywordColor = keywordColorPickEdit.Color
            StringColor = stringColorPickEdit.Color
            CommentColor = commentColorPickEdit.Color
            NumberColor = numberColorPickEdit.Color
            memoEdit1.UpdateTextHighlight()
        End Sub

        '<memoEdit1>
        Private Sub OnCustomHighlightText(ByVal sender As Object, ByVal e As TextEditCustomHighlightTextEventArgs)
            HighlightKeyword(e)
            HighlightNumbers(e)
            HighlightStrings(e)
            HighlightComment(e)
        End Sub

        Private Sub HighlightComment(ByVal e As TextEditCustomHighlightTextEventArgs)
            Dim text As String = e.Text
            Dim index As Integer = text.IndexOf("--")
            If index <> -1 Then e.HighlightRange(index, text.Length - index, CommentColor)
        End Sub

        Private Keywords As String = "select;delete;from;insert;into;table;primary;key;varchar;integer;drop;if;exists;create;use;set;values;update;where;database;not;null"

        Private keywordListField As String()

        Private ReadOnly Property KeywordList As String()
            Get
                If keywordListField Is Nothing Then keywordListField = Keywords.Split(";"c)
                Return keywordListField
            End Get
        End Property

        Private Sub HighlightKeyword(ByVal e As TextEditCustomHighlightTextEventArgs)
            For i As Integer = 0 To KeywordList.Length - 1
                e.HighlightWords(KeywordList(i), KeywordColor)
            Next
        End Sub

        Private Shared ReadOnly StringStartChar As Char = "'"c

        Private Sub HighlightStrings(ByVal e As TextEditCustomHighlightTextEventArgs)
            Dim text As String = e.Text
            Dim length As Integer = text.Length
            Dim startTextIndex As Integer = -1
            While startTextIndex < length
                startTextIndex = text.IndexOf(StringStartChar, startTextIndex + 1)
                If startTextIndex = -1 Then Exit While
                Dim endTextIndex As Integer = text.IndexOf(StringStartChar, startTextIndex + 1)
                If endTextIndex = -1 Then endTextIndex = length
                e.HighlightRange(startTextIndex, endTextIndex - startTextIndex + 1, StringColor)
                startTextIndex = endTextIndex
            End While
        End Sub

        Private Sub HighlightNumbers(ByVal e As TextEditCustomHighlightTextEventArgs)
            Dim text As String = e.Text
            Dim length As Integer = text.Length
            Dim startWordIndex As Integer = 0
            For i As Integer = 0 To length - 1
                Dim ch = text(i)
                If Char.IsWhiteSpace(ch) OrElse Char.IsSeparator(ch) OrElse Char.IsPunctuation(ch) Then
                    If startWordIndex <> -1 AndAlso i - startWordIndex > 0 Then e.HighlightRange(startWordIndex, i - startWordIndex, NumberColor)
                    startWordIndex = i + 1
                    Continue For
                End If

                If Not Char.IsNumber(ch) Then startWordIndex = -1
            Next

            If startWordIndex <> -1 Then e.HighlightRange(startWordIndex, length - startWordIndex, NumberColor)
        End Sub

        '</memoEdit1>
        Private Sub OnTextColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            memoEdit1.Properties.Appearance.ForeColor = textColorPickEdit.Color
        End Sub

        Private Sub OnKeywordColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            InitializeDefaultColors()
        End Sub

        Private Sub OnStringColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            InitializeDefaultColors()
        End Sub

        Private Sub OnNumberColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            InitializeDefaultColors()
        End Sub

        Private Sub OnCommentColorChanged(ByVal sender As Object, ByVal e As EventArgs)
            InitializeDefaultColors()
        End Sub
    End Class
End Namespace
