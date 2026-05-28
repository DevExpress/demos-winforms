namespace DevExpress.VideoRent.Helpers {
    using System;
    using System.IO;
    using DevExpress.Utils;
    using DevExpress.Xpo.Metadata;

    public class MemoryStreamValueConverter : ValueConverter {
        public sealed override Type StorageType {
            get { return typeof(byte[]); }
        }
        public override object ConvertToStorageType(object value) {
            if(value == null)
                return null;
            try {
                return Utils.SafeBinaryFormatter.Serialize(value);
            }
            catch { return null; }
        }
        public override object ConvertFromStorageType(object value) {
            byte[] bytes = value as byte[];
            if(bytes == null)
                return null;
            BindToTypePolicy.QueryNonTrustedTypeValidation += OnQueryNonTrustedTypeValidation;
            try {
                return Utils.SafeBinaryFormatter.Deserialize(bytes);
            }
            finally { BindToTypePolicy.QueryNonTrustedTypeValidation -= OnQueryNonTrustedTypeValidation; }
        }
        // We allow storing\restoring layouts (MemoryStreams) for UI controls
        static void OnQueryNonTrustedTypeValidation(object sender, BindToTypePolicy.QueryNonTrustedTypeValidationEventArgs e) {
            if(e.TypeName == typeof(MemoryStream).FullName)
                e.TrustThisType();
        }
    }
}
