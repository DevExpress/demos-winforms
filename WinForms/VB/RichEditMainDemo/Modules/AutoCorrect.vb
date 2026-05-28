Imports System.Globalization
Imports DevExpress.Office.NumberConverters
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraRichEdit.Services

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class AutoCorrectModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            SpellCheckerHelper.AddDictionaries(sharedDictionaryStorage1)
            Dim ribbonControl As RibbonControl = richEditControl.CreateRibbon(RichEditToolbarType.File Or RichEditToolbarType.Home)
            Controls.Add(ribbonControl)
            LoadDocument("AutoCorrect.docx")
            richEditControl.Options.AutoCorrect.CorrectTwoInitialCapitals = True
            richEditControl.Options.AutoCorrect.UseSpellCheckerSuggestions = True
            Dim service As IAutoCorrectService = richEditControl.GetService(Of IAutoCorrectService)()
            If service IsNot Nothing Then
                Dim replaceTable As AutoCorrectReplaceInfoCollection = New AutoCorrectReplaceInfoCollection()
                replaceTable.Add("(C)", "©")
                replaceTable.Add(New AutoCorrectReplaceInfo(":)", ResourceImageHelperCore.CreateBitmapFromResources("DevExpress.XtraRichEdit.Demos.smile.png", [GetType]().Assembly)))
                replaceTable.Add("pctus", "Please do not hesitate to contact us again in case of any further questions.")
                replaceTable.Add("wnwd", "well-nourished, well-developed")
                service.SetReplaceTable(replaceTable)
            End If
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Private Sub richEditControl_AutoCorrect(ByVal sender As Object, ByVal e As AutoCorrectEventArgs)
            Dim info As AutoCorrectInfo = e.AutoCorrectInfo
            e.AutoCorrectInfo = Nothing
            If info.Text.Length <= 0 OrElse Not info.Text.Contains("%") Then Return
            Dim characterPosition As Integer = info.Text.IndexOf("%")
            Dim decrementCount As Integer = info.Text.Length - characterPosition - 1
            For i As Integer = 0 To decrementCount - 1
                info.DecrementEndPosition()
            Next

            While True
                If Not info.DecrementStartPosition() Then Return
                If IsSeparator(info.Text(0)) Then Return
                If info.Text(0) = "%"c Then
                    Dim replaceString As String = CalculateFunction(info.Text)
                    If Not String.IsNullOrEmpty(replaceString) Then
                        info.ReplaceWith = replaceString
                        e.AutoCorrectInfo = info
                    End If

                    Return
                End If
            End While
        End Sub

        Private Function CalculateFunction(ByVal name As String) As String
            name = name.ToLower()
            If name.Length > 2 AndAlso name(0) = "%"c AndAlso name.EndsWith("%") Then
                Dim value As Integer
                If Integer.TryParse(name.Substring(1, name.Length - 2), value) Then
                    Dim converter As OrdinalBasedNumberConverter = OrdinalBasedNumberConverter.CreateConverter(NumberingFormat.CardinalText, LanguageId.English)
                    Return converter.ConvertNumber(value)
                End If
            End If

            Select Case name
                Case "%date%"
                    Return Date.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern)
                Case "%time%"
                    Return Date.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern)
                Case "%bye%"
                    Return "Yours sincerely," & Microsoft.VisualBasic.Constants.vbCrLf & "David B. Smith"
                Case Else
                    Return String.Empty
            End Select
        End Function

        Private Function IsSeparator(ByVal ch As Char) As Boolean
            Return ch <> "%"c AndAlso (ch = Microsoft.VisualBasic.Strings.ChrW(13) OrElse ch = Microsoft.VisualBasic.Strings.ChrW(10) OrElse Char.IsPunctuation(ch) OrElse Char.IsSeparator(ch) OrElse Char.IsWhiteSpace(ch))
        End Function
    End Class
End Namespace
