using System;
using System.Reflection;

namespace DevExpress.WindowsMailClient.Win.Services {
    public interface IModuleActivator {
        object CreateModule(string moduleTypeName);
        object CreateModule(string moduleTypeName, object viewModel);
    }
    sealed class ModuleActivator : IModuleActivator {
        Assembly moduleAssembly;
        string rootNamespace;
        public ModuleActivator(Assembly moduleAssembly, string rootNamespace) {
            this.moduleAssembly = moduleAssembly;
            this.rootNamespace = rootNamespace;
        }
        public object CreateModule(string moduleTypeName) {
            Type moduleType = DevExpress.Data.Internal.SafeTypeResolver.GetKnownType(moduleAssembly, rootNamespace + '.' + moduleTypeName);
            return Activator.CreateInstance(moduleType);
        }
        public object CreateModule(string moduleTypeName, object viewModel) {
            Type moduleType = DevExpress.Data.Internal.SafeTypeResolver.GetKnownType(moduleAssembly, rootNamespace + '.' + moduleTypeName);
            return Activator.CreateInstance(moduleType, new object[] { viewModel });
        }
    }
}
