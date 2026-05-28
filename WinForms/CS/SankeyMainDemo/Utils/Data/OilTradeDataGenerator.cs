using System.Collections.Generic;

namespace DevExpress.XtraSankey.Demos {
    public class OilTradeDataGenerator {
        public static List<Export> GetData() {
            return new List<Export>() {
                new Export("Canada", "United States", 189.7),

                new Export("United States", "Canada", 24.2),
                new Export("United States", "Europe", 45.8),
                new Export("United States", "India", 9.1),

                new Export("South and Central America", "India", 18.7),

                new Export("Europe", "United States", 6.3),

                new Export("Iraq", "Europe", 55.4),
                new Export("Iraq", "United States", 16.5),
                new Export("Iraq", "India", 49.2),
                new Export("Iraq", "Asia Pacific", 18.9),

                new Export("Saudi Arabia", "Canada", 5.1),
                new Export("Saudi Arabia", "United States", 24.9),
                new Export("Saudi Arabia", "Europe", 39.9),
                new Export("Saudi Arabia", "Middle East", 13.2),
                new Export("Saudi Arabia", "India", 42.6),
                new Export("Saudi Arabia", "Japan", 52.6),
                new Export("Saudi Arabia", "Asia Pacific", 78.5),

                new Export("United Arab Emirates", "India", 19.6),
                new Export("United Arab Emirates", "Japan", 42.9),
                new Export("United Arab Emirates", "Asia Pacific", 39.4),

                new Export(/**/"Middle East", "India", 10.8),
                new Export(/**/"Middle East", "Japan", 19.3),
                new Export(/**/"Middle East", "Asia Pacific", 23.5),

                new Export("North Africa", "Europe", 59.1),
                new Export("North Africa", "India", 5.6),
                new Export("North Africa", "Asia Pacific", 5.1),

                new Export("West Africa", "United States", 14.1),
                new Export("West Africa", "Europe", 65.1),
                new Export("West Africa", "India", 30.2),
                new Export("West Africa", "Asia Pacific", 10.0),
            };
        }
    }
}
