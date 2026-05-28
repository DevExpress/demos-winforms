using System;
using DevExpress.WindowsMailClient.Win.Modules;

namespace DevExpress.WindowsMailClient.Win.Services {
    public interface IModuleTypesResolver {
        string GetName(ModuleType moduleType);
        string GetTypeName(ModuleType moduleType);
        System.Guid GetId(ModuleType moduleType);
        ModuleType GetMainModuleType(ModuleType type);
        ModuleType GetAccordionModuleType(ModuleType type);
    }
    class ModuleTypesResolver : IModuleTypesResolver {
        public string GetName(ModuleType moduleType) {
            if(moduleType == ModuleType.Unknown)
                return null;
            return moduleType.ToString();
        }
        public string GetTypeName(ModuleType moduleType) {
            if(moduleType == ModuleType.Unknown)
                return null;
            return moduleType.ToString();
        }
        public Guid GetId(ModuleType moduleType) {
            switch(moduleType) {
                case ModuleType.MailModule: return new Guid("d4f3a688-3785-41f3-8b62-97dafdbb33f1");
                case ModuleType.Accounts: return new Guid("d4f3a688-3785-41f3-8b62-97dafdbb33f2");
                case ModuleType.MailViewer: return new Guid("d4f3a688-3785-41f3-8b62-97dafdbb33f3");
                default: return Guid.Empty;
            }
        }
        public ModuleType GetMainModuleType(ModuleType type) {
            return type;
        }
        public ModuleType GetAccordionModuleType(ModuleType type) {
            return type;
        }
    }
}
