using System;
using System.IO;
using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV.Common.DataModel.EntityFramework;
using DevExpress.DXperience.Demos;

#if !NET
#endif
namespace DevExpress.DevAV.DevAVDbDataModel1 {
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {
#if NET
        public static string GetDatabaseFilePath() {
            var filePath = Internal.DataDirectoryHelper.GetFile("devav.sqlite3", Internal.DataDirectoryHelper.DataFolderName);
            try {
                var attributes = File.GetAttributes(filePath);
                if(attributes.HasFlag(FileAttributes.ReadOnly)) {
                    File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
                }
            }
            catch { }
            return filePath;
        }
#endif
        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IDevAVDbUnitOfWork> GetUnitOfWorkFactory() {
            Func<DevAVDb> contextFactory =
#if NET
                () => new DevAVDb(string.Format("Data Source={0}", GetDatabaseFilePath()), MainFormHelper.TakeScreens);
#else
                () => new DevAVDb(MainFormHelper.TakeScreens);
#endif
            return new DbUnitOfWorkFactory<IDevAVDbUnitOfWork>(() => new DevAVDbUnitOfWork(contextFactory));
        }
    }
}
