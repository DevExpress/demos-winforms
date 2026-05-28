using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo.DB;

namespace DevExpress.Xpo.Demos {
    public class DataStoreCounter : IDataStore {
        static int selectCounterValue;
        public static int SelectCounterValue {
            get { return selectCounterValue; }
        }
        public static void ClearCounter() {
            selectCounterValue = 0;
        }
        readonly IDataStore dataStore;
        public DataStoreCounter(IDataStore dataStore) {
            this.dataStore = dataStore;
        }

        #region IDataStore Members

        public AutoCreateOption AutoCreateOption {
            get { return dataStore.AutoCreateOption; }
        }

        public ModificationResult ModifyData(params ModificationStatement[] dmlStatements) {
            return dataStore.ModifyData(dmlStatements);
        }

        public SelectedData SelectData(params SelectStatement[] selects) {
            selectCounterValue++;
            return dataStore.SelectData(selects);
        }

        public UpdateSchemaResult UpdateSchema(bool dontCreateIfFirstTableNotExist, params DBTable[] tables) {
            return dataStore.UpdateSchema(dontCreateIfFirstTableNotExist, tables);
        }

        #endregion
    }
}
