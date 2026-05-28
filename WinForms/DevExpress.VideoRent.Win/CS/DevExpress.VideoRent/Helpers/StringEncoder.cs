namespace DevExpress.VideoRent.Helpers {
    public abstract class StringEncoder {
        public static string CalcHash(string s) {
            return MD5StringEncoder.CalcHash(s);
        }
    }
}
