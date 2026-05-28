namespace DevExpress.VideoRent.Helpers {
    using System.IO;
    using System.Text;
    using DevExpress.Utils;

    public class MD5StringEncoder {
        public static string CalcHash(string data) {
            try {
                using(MemoryStream stream = new MemoryStream()) {
                    using(BinaryWriter bWriter = new BinaryWriter(stream, Encoding.UTF8)) {
                        bWriter.Write(data);
                        stream.Seek(0, SeekOrigin.Begin);
                        // For demo only! Use strong crypto algorithm in real application.
                        byte[] digest = HashCodeHelper.Persistent.CreateRH5Digest(stream.ToArray());
                        char[] chars = new char[digest.Length];
                        for(int i = 0; i < digest.Length; i++)
                            chars[i] += (char)digest[i];
                        return new string(chars);
                    }
                }
            }
            catch { return "N/A"; }
        }
    }
}
