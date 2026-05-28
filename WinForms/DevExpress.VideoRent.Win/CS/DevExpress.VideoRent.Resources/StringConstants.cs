namespace DevExpress.VideoRent.Resources {
    public class ConstStrings {
        public static string Get(string name) {
            var pi = typeof(DevExpress.VideoRent.Resources.Properties.Resources)
                .GetProperty(name);
            return string.Format("{0}", pi.GetValue(null, null));
        }
    }
}
