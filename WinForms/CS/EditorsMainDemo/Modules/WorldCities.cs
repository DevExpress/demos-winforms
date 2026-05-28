namespace DevExpress.XtraEditors.Demos {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using DevExpress.Tutorials;
    using DevExpress.XtraEditors.Controls;

    public static class WorldCities {
        public static Task<ICollection> QueryAsync(string text, CancellationToken cancellation) {
            var contains = IgnoreCaseComparisonFunctions.GetContains(CultureInfo.CurrentCulture.CompareInfo, CompareOptions.IgnoreCase);
            return Task.Run(new Func<ICollection>(() => {
                var entries = CsvDataHelper.EnsureAllEntries();
                var parts = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if(parts.Length == 0)
                    return entries as ICollection;
                else
                    return entries.Where(e => {
                        // stop task if needed
                        cancellation.ThrowIfCancellationRequested();
                        return parts.All(x => e.Tags.Any(tag => contains(tag, x)));
                    }).ToList();
            }));
        }
        public static string GetHtmlText(object entry) {
            return entry is Entry ? ((Entry)entry).HtmlText : string.Empty;
        }
        //
        public sealed class Entry {
            readonly static char[] csvseparators = new char[] { ';', ',' };
            readonly static char[] trimCharacters = new char[] { ' ', '\t', '"' };
            internal Entry(string csv) {
                // Country, Country_UN, Admin_Name_Unicode, City, City_Unicode
                var parts = csv.Split(csvseparators, StringSplitOptions.None);
                this.Country = parts[0].Trim(trimCharacters);
                this.Country_UN = parts[1].Trim();
                this.Admin_Name_Unicode = parts[2].Trim();
                this.City = parts[3].Trim();
                this.City_Unicode = parts[4].Trim();
                this.Tags = GetTags();
                this.Text = Country + ", " + string.Join(", ", Tags);
                this.HtmlText = Ignore(Country + ", ") + string.Join(", ", Tags);
            }
            public string Country { get; private set; }
            public string City { get; private set; }
            public string City_Unicode { get; private set; }
            public string Admin_Name_Unicode { get; private set; }
            public string Country_UN { get; private set; }
            //
            public string[] Tags { get; private set; }
            public string Text { get; private set; }
            public string HtmlText { get; private set; }
            //
            string[] GetTags() {
                if(City == City_Unicode) {
                    if(City == Admin_Name_Unicode)
                        return new string[] { City };
                    return new string[] { City, Admin_Name_Unicode };
                }
                return new string[] { City, City_Unicode, Admin_Name_Unicode };
            }
            static string Ignore(string text) {
                return "<color=@disabledtext>" + text + "</color>";
            }
        }
        #region CsvDataHelper
        static class CsvDataHelper {
            readonly static string CITIES_CSV_PATH = FilePathUtils.FindFilePath(Path.Combine("Data", "cities.csv"));
            readonly static List<Entry> allEntries = new List<Entry>();
            public static IEnumerable<Entry> EnsureAllEntries() {
                lock(allEntries) {
                    if(allEntries.Count == 0 && File.Exists(CITIES_CSV_PATH)) {
                        var lines = File.ReadLines(CITIES_CSV_PATH).Skip(1);
                        var entries = lines.Select(x => new Entry(x))
                                .OrderBy(e => e.Country)
                                .ThenBy(e => e.City);
                        foreach(Entry entry in entries)
                            allEntries.Add(entry);
                    }
                    return allEntries;
                }
            }
        }
        #endregion CsvDataHelper
    }
}
