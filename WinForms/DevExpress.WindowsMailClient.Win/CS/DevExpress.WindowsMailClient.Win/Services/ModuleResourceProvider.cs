using DevExpress.WindowsMailClient.Win.Modules;

namespace DevExpress.WindowsMailClient.Win.Services {
    public interface IModuleResourceProvider {
        string GetCaption(ModuleType moduleType);
        string GetModuleImageUri(ModuleType moduleType, bool smallImage = false);
    }
    public class ModuleResourceProvider : IModuleResourceProvider {
        public string GetCaption(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.Unknown: return null;
                case ModuleType.Accounts: return "Accounts";
                case ModuleType.MailViewer: return "Folders";
                case ModuleType.MailModule: return "NewMail";
                default: return moduleType.ToString();
            }
        }
        public string GetModuleImageUri(ModuleType moduleType, bool smallImage = false) {
            return null;
        }
    }
}
