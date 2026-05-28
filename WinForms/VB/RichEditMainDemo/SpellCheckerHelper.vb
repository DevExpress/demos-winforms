Imports System.Globalization
Imports DevExpress.XtraSpellChecker

Namespace DevExpress.XtraRichEdit.Demos

    Public Class SpellCheckerHelper

        Public Shared Sub AddDictionaries(ByVal storage As SharedDictionaryStorage)
            If storage.Dictionaries.Count = 0 Then AddDictionaries(storage.Dictionaries)
        End Sub

        Public Shared Sub AddDictionaries(ByVal dictionaries As DictionaryCollection)
            Dim dictionary As SpellCheckerISpellDictionary = New SpellCheckerISpellDictionary(DemoUtils.GetRelativePath("american.xlg"), DemoUtils.GetRelativePath("english.aff"), CultureInfo.GetCultureInfo("en-US"))
            dictionary.CaseSensitive = True
            dictionaries.Add(dictionary)
            Dim customDictionary As SpellCheckerCustomDictionary = New SpellCheckerCustomDictionary(DemoUtils.GetRelativePath("CustomEnglish.dic"), CultureInfo.GetCultureInfo("en-US"))
            dictionaries.Add(customDictionary)
        End Sub
    End Class
End Namespace
