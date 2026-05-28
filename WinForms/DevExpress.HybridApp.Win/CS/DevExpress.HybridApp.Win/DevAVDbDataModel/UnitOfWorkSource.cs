using System;
using System.Linq;
using System.Data;
using System.IO;
using System.Linq.Expressions;
using System.Collections.Generic;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV.Common.DataModel.EntityFramework;
using DevExpress.DevAV;
using DevExpress.Mvvm;
using System.Collections;
using System.ComponentModel;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Async.Helpers;
#if !NET
using System.Data.Entity;
#endif
namespace DevExpress.DevAV.DevAVDbDataModel1
{
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource
    {
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
        public static IUnitOfWorkFactory<IDevAVDbUnitOfWork> GetUnitOfWorkFactory()
        {
            Func<DevAVDb> contextFactory =
#if NET
                () => new DevAVDb(string.Format("Data Source={0}", GetDatabaseFilePath()));
#else
                () => new DevAVDb();
#endif
            return new DbUnitOfWorkFactory<IDevAVDbUnitOfWork>(() => new DevAVDbUnitOfWork(contextFactory));
        }
    }
}
