using DevExpress.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Drawing;

namespace DevExpress.XtraGrid.Demos {
    public static class WorldCities {
        readonly static string CITIES_CSV_PATH = DataDirectoryHelper.GetDataFile("cities.csv");
        readonly static List<Entry> allEntries = new List<Entry>(13000);
        public static IReadOnlyList<Entry> All {
            get {
                if(allEntries.Count == 0 && System.IO.File.Exists(CITIES_CSV_PATH)) {
                    var lines = System.IO.File.ReadLines(CITIES_CSV_PATH).Skip(1);
                    var entries = lines.Select(x => new Entry(x))
                            .OrderBy(e => e.Country)
                            .ThenBy(e => e.City);
                    foreach(Entry entry in entries)
                        allEntries.Add(entry);
                }
                return allEntries;
            }
        }
        public sealed class Entry {
            readonly static char[] csvseparators = new char[] { ';', ',' };
            readonly static char[] trimCharacters = new char[] { ' ', '\t', '"' };
            internal Entry(string csv) {
                // Country, Country_UN, Admin_Name_Unicode, City, City_Unicode
                var parts = csv.Split(csvseparators, StringSplitOptions.None);
                this.Country = parts[0].Trim(trimCharacters);
                this.Country_UN = parts[1].Trim();
                this.Region = parts[2].Trim();
                this.City = parts[3].Trim();
                this.City_Unicode = parts[4].Trim();
                this.Text = Country + ", " + string.Join(", ", GetTags());
                //
                this.Image = GetCountryStubGlyph();
                this.Title = (City == City_Unicode) ? City : City + "(" + City_Unicode + ")";
                this.Subtitle = Country + ", " + Region;
            }
            public string Country { get; private set; }
            public string City { get; private set; }
            [Display(Order = -1)]
            public string City_Unicode { get; private set; }
            public string Region { get; private set; }
            [Display(Order = -1)]
            public string Country_UN { get; private set; }
            [Display(Order = -1)]
            public string Title { get; private set; }
            [Display(Order = -1)]
            public string Subtitle { get; private set; }
            [Display(Order = -1)]
            public string Text { get; private set; }
            public Image Image { get; private set; }
            string[] GetTags() {
                if(City == City_Unicode) {
                    if(City == Region)
                        return new string[] { City };
                    return new string[] { City, Region };
                }
                return new string[] { City, City_Unicode, Region };
            }
            Image GetCountryStubGlyph() {
                return StubCache.GetImage(Country_UN);
            }
        }
        static class StubCache {
            readonly static Dictionary<string, Image> cache = new Dictionary<string, Image>(256);
            public static Image GetImage(string text) {
                Image img = null;
                if(!cache.TryGetValue(text, out img)) {
                    img = CreateGlyph(text);
                    cache.Add(text, img);
                }
                return img;
            }
            readonly static StubGlyphOptions options = new StubGlyphOptions() {
                RandomizeColors = true,
                Type = GlyphBackgroundType.Ellipse,
                LetterCount = GlyphTextSymbolCount.Two,
            };
            static Image CreateGlyph(string text) {
                var glyphSize = Utils.ScaleUtils.ScaleValue(new Size(32, 32));
                var size = Utils.ScaleUtils.ScaleValue(new Size(28, 28));
                var skinProvider = UserLookAndFeel.Default;
                var location = new Point((glyphSize.Width - size.Width) / 2, (glyphSize.Height - size.Height) / 2);
                var img = new Bitmap(glyphSize.Width, glyphSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                using(Graphics g = Graphics.FromImage(img)) {
                    using(GraphicsCache cache = new GraphicsCache(g))
                        GlyphPainter.Default.DrawGlyph(cache, options, text, new Rectangle(location, size), skinProvider, ObjectState.Normal);
                }
                return img;
            }
        }
    }
}
