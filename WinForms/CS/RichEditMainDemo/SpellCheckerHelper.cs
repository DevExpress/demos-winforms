using System.Globalization;
using DevExpress.XtraSpellChecker;

namespace DevExpress.XtraRichEdit.Demos {
    public class SpellCheckerHelper {
        public static void AddDictionaries(SharedDictionaryStorage storage) {
            if(storage.Dictionaries.Count == 0)
                AddDictionaries(storage.Dictionaries);
        }
        public static void AddDictionaries(DictionaryCollection dictionaries) {
            SpellCheckerISpellDictionary dictionary = new SpellCheckerISpellDictionary(
                            DemoUtils.GetRelativePath("american.xlg"),
                            DemoUtils.GetRelativePath("english.aff"),
                            CultureInfo.GetCultureInfo("en-US")
                            );
            dictionary.CaseSensitive = true;
            dictionaries.Add(dictionary);
            SpellCheckerCustomDictionary customDictionary = new SpellCheckerCustomDictionary(
                            DemoUtils.GetRelativePath("CustomEnglish.dic"),
                            CultureInfo.GetCultureInfo("en-US"));
            dictionaries.Add(customDictionary);
        }
    }
}
