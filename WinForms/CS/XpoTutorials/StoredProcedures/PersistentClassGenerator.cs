using System;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using System.Data.SqlClient;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata.Helpers;
using System.Collections.Generic;
using System.Text;

namespace DevExpress.Xpo.Demos.Generator
{
    internal enum PersistentClassGeneratorKeywords {
        Null,
        Return,
        OperatorEnd,
        New,
        TypeOf
    }
    internal abstract class PersistentClassGenerator {
        Dictionary<string, int> reservedWords;
        protected Dictionary<string, int> ReservedWords { get { return reservedWords; } }
        protected abstract string[] ReservedWordsArray { get; }

        public PersistentClassGenerator() {
            reservedWords = new Dictionary<string, int>(ReservedWordsArray.Length);
            for(int i = 0; i < ReservedWordsArray.Length; i++)
                reservedWords.Add(ReservedWordsArray[i], 0);
        }

        public static string TableGetCaption(string name) {
            int endIndex = name.IndexOf('<');
            if(endIndex < 0) {
                return name;
            }
            return name.Substring(0, endIndex - 1);
        }

        public static string TableGetName(string name) {
            int startIndex = name.IndexOf('<');
            int endIndex = name.IndexOf('>');
            if(startIndex < 0) {
                return name;
            }
            return name.Substring(startIndex + 1, (endIndex - startIndex) - 1);
        }

        public static string SprocGetName(string name) {
            int endIndex = name.IndexOf('<');
            if(endIndex < 0) {
                return name;
            }
            return name.Substring(0, endIndex - 1);
        }


        public void Check(TextWriter log, IDataStoreSchemaExplorer prov,
            Dictionary<string, bool> tablesMask, TableColumnsCheckContainer tables) {
            Hashtable list = new Hashtable();
            foreach(KeyValuePair<string, bool> tableMask in tablesMask) {
                if(!tableMask.Value) {
                    continue;
                }
                string tableName = tableMask.Key;
                DBTable table = prov.GetStorageTables(TableGetName(tableName))[0];
                switch(tableName) {
                    case "XPObjectType":
                    case "XPWeakReference":
                    case "EventHandlerLink":
                    case "XPDeletedObject": {
                            continue;
                        }
                }
                Columns columns = tables.GetTableColumns(table.Name);
                if((table.PrimaryKey == null) || (table.PrimaryKey.Columns.Count != 1) ||
                    !columns.ContainsKey(table.PrimaryKey.Columns[0]) ||
                    !columns[table.PrimaryKey.Columns[0]].Selected) {
                    log.WriteLine(tableName + " no single column pk");
                }
            }
            foreach(string key in list.Keys) {
                DBTable table = (DBTable)list[key];
                Columns columns = tables.GetTableColumns(table.Name);
                foreach(DBColumn column in table.Columns) {
                    if(((IsLockingField(column.Name, column.ColumnType) || IsGCRecordField(column.Name, column.ColumnType)) || IsObjectTypeField(column.Name, column.ColumnType)) || !columns[column.Name].Selected) {
                        continue;
                    }
                    if(column.ColumnType == DBColumnType.Unknown)
                        log.WriteLine(table.Name + " - " + column.Name + " not mapped");
                }
            }
        }
        public void Check(TextWriter log, IDataStoreSchemaExplorerSp prov, Dictionary<string, bool> sprocMasks, SProcsResultSetCheckContainer sprocedures) {
            ConnectionProviderSql provider = prov as ConnectionProviderSql;
            Dictionary<string, DBStoredProcedure> list = new Dictionary<string, DBStoredProcedure>();
            DBStoredProcedure[] sprocList = prov.GetStoredProcedures();
            if(sprocList == null || sprocList.Length == 0) return;
            for(int i = 0; i < sprocList.Length; i++) {
                list.Add(sprocList[i].Name, sprocList[i]);
            }
            foreach(KeyValuePair<string, bool> sprocMask in sprocMasks) {
                if(sprocMask.Value) continue;
                list.Remove(sprocMask.Key);
            }
            Dictionary<string, LoadDataMemberOrderItem[]> loadProcOrderDict = new Dictionary<string, LoadDataMemberOrderItem[]>();
            foreach(string key in list.Keys) {
                DBStoredProcedure sproc = list[key];
                if(sproc.ResultSets.Count != 1) continue;
                string className = GetClassName(TableGetCaption(key));
                ResultSetColumns columns = sprocedures.GetResultSetColumns(sproc.Name);
                int columnsCount = sproc.ResultSets[0].Columns.Count;
                for(int c = 0; c < columnsCount; c++) {
                    DBNameTypePair column = sproc.ResultSets[0].Columns[c];
                    if(((IsLockingField(column.Name, column.Type) || IsGCRecordField(column.Name, column.Type)) || IsObjectTypeField(column.Name, column.Type)) || !columns[c].Selected)
                        continue;
                    if(column.Type == DBColumnType.Unknown) {
                        log.WriteLine(sproc.Name + " - " + column.Name + " not mapped");
                        continue;
                    }
                    string type = GetLanguageType(column.Type);
                    if(String.IsNullOrEmpty(type)) {
                        log.WriteLine(sproc.Name + " - " + column.Name + " not mapped");
                        continue;
                    }
                }
            }
        }
        public static bool CheckTable(IDataStoreSchemaExplorer prov, string tableName, out string message) {
            DBTable table = prov.GetStorageTables(TableGetName(tableName))[0];
            switch(tableName) {
                case "XPObjectType":
                case "XPWeakReference":
                case "EventHandlerLink":
                case "XPDeletedObject":
                    message = "Internal XPO table";
                    return false;
            }
            if(table.PrimaryKey == null) {
                message = "Table has no primary key";
                return false;
            }
            if(table.PrimaryKey.Columns.Count > 1) {
                message = "Generator doesn't support composite (multi-column) keys";
                return false;
            }
            message = string.Empty;
            return true;
        }
        public void Generate(TextWriter w, TextWriter log, IDataStoreSchemaExplorer prov, Dictionary<string, bool> tablesMask, TableColumnsCheckContainer tables, string dbName) {
            Generate(w, log, prov, tablesMask, tables, null, null, dbName);
        }
        public void Generate(TextWriter w, TextWriter log, IDataStoreSchemaExplorer prov, Dictionary<string, bool> tablesMask, TableColumnsCheckContainer tables, Dictionary<string, bool> sprocMasks, SProcsResultSetCheckContainer sprocedures, string dbName) {
            Generate(w, log, prov, tablesMask, tables, sprocMasks, sprocedures, dbName, false);
        }
        public void Generate(TextWriter w, TextWriter log, IDataStoreSchemaExplorer prov, Dictionary<string, bool> tablesMask, TableColumnsCheckContainer tables, string dbName, bool storedProcedures) {
            Generate(w, log, prov, tablesMask, tables, null, null, dbName);
        }
        public void Generate(TextWriter w, TextWriter log, IDataStoreSchemaExplorer prov, Dictionary<string, bool> tablesMask, TableColumnsCheckContainer tables, Dictionary<string, bool> sprocMasks, SProcsResultSetCheckContainer sprocedures, string dbName, bool storedProcedures) {
            ConnectionProviderSql provider = prov as ConnectionProviderSql;
            Hashtable list = new Hashtable();
            List<string> dropList = null;
            if(storedProcedures) {
                dropList = new List<string>();
                w.WriteLine("/*");
                w.WriteLine(provider.GenerateStoredProceduresInfoOnce());
            }
            foreach(KeyValuePair<string, bool> tableMask in tablesMask) {
                if(!tableMask.Value) { continue; }
                string tableName = tableMask.Key;
                DBTable table = prov.GetStorageTables(TableGetName(tableName))[0];
                switch(tableName) {
                    case "XPObjectType":
                    case "XPWeakReference":
                    case "EventHandlerLink":
                    case "XPDeletedObject":
                        continue;
                }
                Columns columns = tables.GetTableColumns(table.Name);
                if((table.PrimaryKey != null) && (table.PrimaryKey.Columns.Count == 1) && columns[table.PrimaryKey.Columns[0]].Selected) {
                    list.Add(tableName, table);
                    if(storedProcedures) {
                        string dropLines;
                        w.WriteLine(provider.GenerateStoredProcedures(table, out dropLines));
                        if(!string.IsNullOrEmpty(dropLines)) dropList.Add(dropLines);
                    }
                } else {
                    log.WriteLine(tableName + " no single column pk");
                }
            }
            if(storedProcedures) {
                w.WriteLine("*/");
                w.WriteLine();
                w.WriteLine("/*");
                if(dropList.Count > 0) {
                    for(int i = 0; i < dropList.Count; i++) {
                        w.WriteLine(dropList[i]);
                    }
                    w.WriteLine();
                }
                w.WriteLine("*/");
                w.WriteLine();
            }
            WriteUsing(w);
            //WriteConnectionComment(w);
            StartNamespace(w, !String.IsNullOrEmpty(dbName) ? dbName : "DBObjects");
            foreach(string key in list.Keys) {
                DBTable table = (DBTable)list[key];
                w.WriteLine();
                string className = GetClassName(TableGetCaption(key)),
                    baseClassName;
                if(className != table.Name) WriteClassPersistentTag(w, table.Name);
                if(storedProcedures) { WriteClassPersistentTag(w, table.Name + "_xpoView"); }
                if(!HasLockingField(list, table)) {
                    if(HasGCRecordField(table)) {
                        TurnoffOptimisticLocking(w);
                        baseClassName = "XPCustomObject";
                    } else baseClassName = "XPLiteObject";
                } else {
                    if(HasGCRecordField(table)) baseClassName = "XPCustomObject";
                    else baseClassName = "XPBaseObject";
                }
                DeclareClass(w, className, baseClassName);
                Columns columns = tables.GetTableColumns(table.Name);
                foreach(DBColumn column in table.Columns) {
                    if(((IsLockingField(column.Name, column.ColumnType) || IsGCRecordField(column.Name, column.ColumnType)) || IsObjectTypeField(column.Name, column.ColumnType)) || !columns[column.Name].Selected)
                        continue;
                    string type = GetLanguageType(column.ColumnType);
                    if(String.IsNullOrEmpty(type)) {
                        log.WriteLine(table.Name + " - " + column.Name + " not mapped");
                        continue;
                    }
                    foreach(DBForeignKey fk in table.ForeignKeys) {
                        if(fk.Columns[0] == column.Name) {
                            foreach(DictionaryEntry s in list)
                                if(fk.PrimaryKeyTable == TableGetName((string)s.Key) &&
                                    (key != (string)s.Key || column.Name != table.PrimaryKey.Columns[0]) &&
                                    (((DBTable)s.Value).PrimaryKey.Columns[0] == fk.PrimaryKeyTableKeyColumns[0])) {
                                    type = GetClassName(TableGetCaption((string)s.Key));
                                    break;
                                }
                        }
                    }
                    string propertyName = TableGetCaption(columns[column.Name].Name);
                    if(propertyName.IndexOf(" ") >= 0) propertyName = propertyName.Replace(" ", "");
                    if(propertyName == className) propertyName += "_";
                    while(!IsPropertyNameReserved(propertyName))
                        propertyName = "_" + propertyName;
                    propertyName = ValidatePropertyName(propertyName);
                    string fieldName = "f" + propertyName;
                    DeclareField(w, type, fieldName);
                    if(column.Name == table.PrimaryKey.Columns[0]) {
                        if(column.IsIdentity || (column.ColumnType == DBColumnType.Guid))
                            WriteIdentityKey(w);
                        else
                            WriteKey(w);
                        if(storedProcedures && column.IsIdentity && prov is MSSqlConnectionProvider) {
                            WritePersistentProperty(w, ConnectionProviderSql.IdentityColumnMagicName);
                        }
                    }
                    if(column.ColumnType == DBColumnType.String && column.Size != SizeAttribute.DefaultStringMappingFieldSize)
                        WritePropertySize(w, column.Size);
                    if(propertyName != column.Name)
                        WritePersistentProperty(w, column.Name);
                    DeclareProperty(w, type, propertyName, fieldName, column.Name);
                }
                WriteClassConstructors(w, className);
                CloseClass(w);
            }

            IDataStoreSchemaExplorerSp spProv = prov as IDataStoreSchemaExplorerSp;
            if(spProv != null && sprocMasks != null && sprocMasks.Count > 0 && sprocedures != null) {
                GenerateSP(w, log, spProv, sprocMasks, sprocedures, dbName);
            }

            w.WriteLine();
            CloseNamespace(w);
        }

        static string staticHelperClassName;
        public static string StaticHelperClassName {
            get {
                return staticHelperClassName;
            }
        }
        void GenerateSP(TextWriter w, TextWriter log, IDataStoreSchemaExplorerSp prov, Dictionary<string, bool> sprocMasks, SProcsResultSetCheckContainer sprocedures, string dbName) {
            ConnectionProviderSql provider = prov as ConnectionProviderSql;
            Dictionary<string, DBStoredProcedure> list = new Dictionary<string, DBStoredProcedure>();
            DBStoredProcedure[] sprocList = prov.GetStoredProcedures();
            if(sprocList == null || sprocList.Length == 0) return;
            for(int i = 0; i < sprocList.Length; i++) {
                list[sprocList[i].Name] = sprocList[i];
            }
            foreach(KeyValuePair<string, bool> sprocMask in sprocMasks) {
                if(sprocMask.Value) continue;
                list.Remove(sprocMask.Key);
            }
            Dictionary<string, bool> existsClassNameDict = new Dictionary<string, bool>(StringComparer.InvariantCultureIgnoreCase);
            Dictionary<string, string> classNameDict = new Dictionary<string, string>();
            Dictionary<string, LoadDataMemberOrderItem[]> loadProcOrderDict = new Dictionary<string, LoadDataMemberOrderItem[]>();
            foreach(string key in list.Keys) {
                DBStoredProcedure sproc = list[key];
                string realClassName = GetClassName(TableGetCaption(key));
                string className = CheckClassName(existsClassNameDict, classNameDict, realClassName);
                if(sproc.ResultSets.Count != 1) continue;
                List<LoadDataMemberOrderItem> memberOrderList = null;
                w.WriteLine();
                WriteClassNonPersistentTag(w);
                string baseClassName = "PersistentBase";
                DeclareClass(w, className, baseClassName);
                ResultSetColumns columns = sprocedures.GetResultSetColumns(sproc.Name);
                int indexInResultSet = 0;
                int columnsCount = sproc.ResultSets[0].Columns.Count;
                for(int c = 0; c < columnsCount; c++) {
                    DBNameTypePair column = sproc.ResultSets[0].Columns[c];
                    if(((IsLockingField(column.Name, column.Type) || IsGCRecordField(column.Name, column.Type)) || IsObjectTypeField(column.Name, column.Type)) || !columns[c].Selected)
                        continue;
                    string type = GetLanguageType(column.Type);
                    if(String.IsNullOrEmpty(type)) {
                        log.WriteLine(sproc.Name + " - " + column.Name + " not mapped");
                        continue;
                    }
                    string propertyName = SprocGetName(columns[c].Name);
                    propertyName = TitleCase(propertyName.Replace(" ", "").Replace("@", ""));
                    if(propertyName == className) propertyName += "_";
                    while(!IsPropertyNameReserved(propertyName))
                        propertyName = "_" + propertyName;
                    propertyName = ValidatePropertyName(propertyName);
                    string fieldName = "f" + propertyName;
                    DeclareField(w, type, fieldName);
                    DeclareProperty(w, type, propertyName, fieldName, column.Name);
                    if(memberOrderList == null) {
                        memberOrderList = new List<LoadDataMemberOrderItem>();
                    }
                    memberOrderList.Add(new LoadDataMemberOrderItem(indexInResultSet++, propertyName));
                }
                if(memberOrderList != null && memberOrderList.Count > 0) {
                    if(memberOrderList.Count == sproc.ResultSets[0].Columns.Count)
                        loadProcOrderDict.Add(className, null);
                    else
                        loadProcOrderDict.Add(className, memberOrderList.ToArray());
                }
                WriteClassConstructors(w, className);
                CloseClass(w);
            }
            string classHelperName = GetClassName(TitleCase(dbName) + "SprocHelper");
            staticHelperClassName = (!String.IsNullOrEmpty(dbName) ? dbName : "DBObjects") + "." + classHelperName;
            DeclareStaticClass(w, classHelperName);
            foreach(string key in list.Keys) {
                DBStoredProcedure sproc = list[key];
                w.WriteLine();
                string className = classNameDict[GetClassName(TableGetCaption(key))];
                string methodArgsWithSession = GetArgument("session", "Session");
                string methodArgs = string.Empty;
                string[] argNames = null;
                if(sproc.Arguments.Count > 0) {
                    methodArgs = GetMethodArguments(sproc.Arguments, out argNames);
                    if(!string.IsNullOrEmpty(methodArgs)) {
                        methodArgsWithSession = methodArgsWithSession + ", " + methodArgs;
                    }
                } else {
                    argNames = new string[0];
                }
                DeclareSprocToSelectedData(w, key, className, methodArgsWithSession, argNames);
                if(sproc.ResultSets.Count != 1) continue;
                LoadDataMemberOrderItem[] memberOrder;
                if(!loadProcOrderDict.TryGetValue(className, out memberOrder)) continue;
                string orderArrayName = null;
                if(memberOrder != null) {
                    w.WriteLine();
                    orderArrayName = DeclareOrderArray(w, className, memberOrder);
                }
                w.WriteLine();
                DeclareSprocToObjectsGeneric(w, key, className, methodArgsWithSession, argNames, memberOrder, orderArrayName);
                w.WriteLine();
                DeclareSprocToDataViewCreate(w, key, className, methodArgsWithSession, argNames, memberOrder, orderArrayName);
                DeclareSprocToDataView(w, key, className, methodArgsWithSession, argNames, memberOrder, orderArrayName);
            }
            CloseStaticClass(w);
            w.WriteLine();
        }

        static string CheckClassName(Dictionary<string, bool> existsClassNameDict, Dictionary<string, string> classNameDict, string realClassName) {
            string className = realClassName;
            int additionalSuffixCounter = 0;
            while(existsClassNameDict.ContainsKey(className)) {
                className = string.Format("{0}_{D:2}", realClassName, additionalSuffixCounter++);
            }
            existsClassNameDict[className] = true;
            classNameDict[realClassName] = className;
            return className;
        }

        void DeclareSprocToSelectedData(TextWriter w, string key, string className, string methodArgs, string[] argNames) {
            string methodResultType = "DevExpress.Xpo.DB.SelectedData";
            string body = string.Format("{0} session.ExecuteSproc(\"{1}\"{2}){3}",
                GetLanguageKeyword(PersistentClassGeneratorKeywords.Return),
                key,
                GetAdditionalArgsString(argNames),
                GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            DeclareStaticFunction(w, "Exec" + className, methodArgs, methodResultType, new string[] { body });
        }

        static string GetAdditionalArgsString(string[] argNames) {
            return argNames == null || argNames.Length == 0 ? string.Empty : ", " + string.Join(", ", argNames);
        }

        void DeclareSprocToObjects(TextWriter w, string key, string className, string methodArgs, string[] argNames, LoadDataMemberOrderItem[] memberOrder, string orderArrayName) {
            string methodResultType = "System.Collections.ICollection";
            string body;
            if(memberOrder == null) {
                body = string.Format("{0} session.GetObjectsFromSproc(session.GetClassInfo({1}({2})), \"{3}\"{4}){5}",
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.Return),
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.TypeOf),
                    className,
                    key,
                    GetAdditionalArgsString(argNames),
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            } else {
                body = string.Format("{0} session.GetObjectsFromSproc(session.GetClassInfo({1}({2})), {3}, \"{4}\"{5}){6}",
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.Return),
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.TypeOf),
                    className,
                    orderArrayName,
                    key,
                    GetAdditionalArgsString(argNames),
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            }
            DeclareStaticFunction(w, "Exec" + className + "IntoObjects", methodArgs, methodResultType, new string[] { body });
        }
        void DeclareSprocToObjectsGeneric(TextWriter w, string key, string className, string methodArgs, string[] argNames, LoadDataMemberOrderItem[] memberOrder, string orderArrayName) {
            string methodResultType = "System.Collections.Generic.ICollection" + GetGeneric(className);
            string body;
            if(memberOrder == null) {
                body = string.Format("{0} session.GetObjectsFromSproc{1}(\"{2}\"{3}){4}",
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.Return),
                    GetGeneric(className),
                    key,
                    GetAdditionalArgsString(argNames),
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            } else {
                body = string.Format("{0} session.GetObjectsFromSproc{1}({2}, \"{3}\"{4}){5}",
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.Return),
                    GetGeneric(className),
                    orderArrayName,
                    key,
                    GetAdditionalArgsString(argNames),
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            }
            DeclareStaticFunction(w, "Exec" + className + "IntoObjects", methodArgs, methodResultType, new string[] { body });
        }
        void DeclareSprocToDataViewCreate(TextWriter w, string key, string className, string methodArgs, string[] argNames, LoadDataMemberOrderItem[] memberOrder, string orderArrayName) {
            string methodResultType = "XPDataView";
            string[] body = new string[2];
            string sprocDataName = "sprocData";
            body[0] = string.Format("{0} = session.ExecuteSproc(\"{1}\"{2}){3}",
                GetVariableDeclaration("DevExpress.Xpo.DB.SelectedData", sprocDataName),
                key,
                GetAdditionalArgsString(argNames),
                GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            if(memberOrder == null) {
                body[1] = string.Format("{0} {1} XPDataView(session.Dictionary, session.GetClassInfo({2}({3})), {4}){5}",
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.Return),
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.New),
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.TypeOf),
                    className,
                    sprocDataName,
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            } else {
                body[1] = string.Format("{0} {1} XPDataView(session.Dictionary, session.GetClassInfo({2}({3})), {4}, {5}){6}",
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.Return),
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.New),
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.TypeOf),
                    className,
                    orderArrayName,
                    sprocDataName,
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            }
            DeclareStaticFunction(w, "Exec" + className + "IntoDataView", methodArgs, methodResultType, body);
        }
        void DeclareSprocToDataView(TextWriter w, string key, string className, string methodArgs, string[] argNames, LoadDataMemberOrderItem[] memberOrder, string orderArrayName) {
            string methodResultType = string.Empty;
            string[] body = new string[3];
            string sprocDataName = "sprocData";
            body[0] = string.Format("{0} = session.ExecuteSproc(\"{1}\"{2}){3}",
                GetVariableDeclaration("DevExpress.Xpo.DB.SelectedData", sprocDataName),
                key,
                GetAdditionalArgsString(argNames),
                GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            if(memberOrder == null) {
                body[1] = string.Format("dataView.PopulateProperties(session.GetClassInfo({0}({1}))){2}",
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.TypeOf),
                    className,
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
                body[2] = string.Format("dataView.LoadData({0}){1}",
                    sprocDataName,
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            } else {
                body[1] = string.Format("dataView.PopulatePropertiesOrdered(session.GetClassInfo({0}({1})), {2}){3}",
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.TypeOf),
                    className,
                    orderArrayName,
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
                body[2] = string.Format("dataView.LoadOrderedData({0}, {1}){2}",
                    orderArrayName,
                    sprocDataName,
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.OperatorEnd));
            }
            DeclareStaticFunction(w, "Exec" + className + "IntoDataView",
                GetArgument("dataView", "XPDataView") + (string.IsNullOrEmpty(methodArgs) ? string.Empty : ", " + methodArgs),
                methodResultType, body);
        }

        string DeclareOrderArray(TextWriter w, string className, LoadDataMemberOrderItem[] memberOrder) {
            string[] elements = new string[memberOrder.Length];
            for(int i = 0; i < memberOrder.Length; i++) {
                elements[i] = string.Format("{0} LoadDataMemberOrderItem({1}, \"{2}\")",
                    GetLanguageKeyword(PersistentClassGeneratorKeywords.New),
                    memberOrder[i].IndexInResultSet,
                    memberOrder[i].ClassMemberName);
            }
            string arrayName = className + "OrderArray";
            DeclarePrivatStaticArray(w, arrayName, "LoadDataMemberOrderItem", elements);
            return arrayName;
        }

        string GetMethodArguments(List<DBStoredProcedureArgument> sprocArgs, out string[] argNames) {
            Dictionary<string, bool> argNamesDict = IsCaseSensitive ? new Dictionary<string, bool>() : new Dictionary<string, bool>(StringComparer.InvariantCultureIgnoreCase);
            List<string> args = new List<string>(sprocArgs.Count);
            List<string> argNamesList = new List<string>(sprocArgs.Count);
            for(int i = 0; i < sprocArgs.Count; i++) {
                if(sprocArgs[i].Direction == DBStoredProcedureArgumentDirection.Out) continue;
                string name = sprocArgs[i].Name.Replace("@", "").Replace(" ", "");
                while(argNamesDict.ContainsKey(name) || !IsPropertyNameReserved(name)) { name = "_" + name; }
                string argType = GetLanguageType(sprocArgs[i].Type);
                args.Add(GetArgument(name, argType));
                string argName = string.Equals(argType, "bool") ? string.Format("(OperandValue){0}", name) : name;
                argNamesList.Add(argName);
            }
            argNames = argNamesList.ToArray();
            return string.Join(", ", args.ToArray());
        }

        protected abstract void WriteUsing(TextWriter w);
        protected abstract void WriteConnectionComment(TextWriter w, string connectionString);
        protected abstract void StartNamespace(TextWriter w, string name);
        protected abstract void CloseNamespace(TextWriter w);

        protected abstract void TurnoffOptimisticLocking(TextWriter w);
        protected abstract void WriteClassPersistentTag(TextWriter w, string name);
        protected abstract void WriteClassNonPersistentTag(TextWriter w);
        protected abstract void DeclareClass(TextWriter w, string className, string baseClassName);
        protected abstract void CloseClass(TextWriter w);
        protected abstract void DeclareStaticClass(TextWriter w, string className);
        protected abstract void CloseStaticClass(TextWriter w);
        protected abstract void WriteClassConstructors(TextWriter w, string className);

        protected abstract void DeclareStaticFunction(TextWriter w, string functionName, string arguments, string resultType, string[] body);
        protected abstract void DeclarePrivatStaticArray(TextWriter w, string arrayName, string arrayType, string[] elements);
        protected abstract string GetVariableDeclaration(string className, string variableName);
        protected abstract string GetLanguageKeyword(PersistentClassGeneratorKeywords keyword);
        protected abstract string GetLanguageType(DBColumnType columnType);
        protected abstract string GetArgument(string name, string type);
        protected abstract string GetGeneric(string className);
        protected abstract void DeclareField(TextWriter w, string type, string columnName);
        protected abstract void WriteKey(TextWriter w);
        protected abstract void WriteIdentityKey(TextWriter w);
        protected abstract void WritePersistentProperty(TextWriter w, string columnName);
        protected abstract void WritePropertySize(TextWriter w, int size);
        protected abstract bool IsCaseSensitive { get; }
        protected abstract bool IsPropertyNameReserved(string propertyName);
        protected virtual string ValidatePropertyName(string propertyName) {
            StringBuilder res = new StringBuilder(propertyName.Length);
            for(int i = 0; i < propertyName.Length; i++) {
                if(IsValidChar(propertyName[i], i == 0))
                    res.Append(propertyName[i]);
                else
                    res.Append('_');
            }
            return res.ToString();
        }
        protected bool IsValidChar(char p, bool isFirst) {
            return (Char.IsDigit(p) && !isFirst) || Char.IsLetter(p);
        }
        protected abstract void DeclareProperty(TextWriter w, string type, string propertyName,
            string fieldName, string columnName);

        string GetClassName(string tableName) {
            if((tableName.IndexOf(' ') >= 0) || (tableName.IndexOf('.') >= 0)) {
                tableName = tableName.Replace(" ", "").Replace(".", "_");
            }
            return tableName;
        }
        string TitleCase(string input) {
            if(string.IsNullOrEmpty(input)) return string.Empty;
            return char.ToUpperInvariant(input[0]) + input.Substring(1, input.Length - 1);
        }
        bool HasGCRecordField(DBTable table) {
            foreach(DBColumn col in table.Columns) {
                if(IsGCRecordField(col.Name, col.ColumnType)) {
                    return true;
                }
            }
            return false;
        }
        bool HasLockingField(Hashtable list, DBTable table) {
            foreach(DBColumn col in table.Columns) {
                if(IsLockingField(col.Name, col.ColumnType)) {
                    return true;
                }
            }
            return false;
        }
        bool HasObjectTypeField(DBTable table) {
            foreach(DBColumn col in table.Columns) {
                if(IsObjectTypeField(col.Name, col.ColumnType)) {
                    return true;
                }
            }
            return false;
        }
        bool IsGCRecordField(string columnName, DBColumnType columnType) {
            return ((columnType == DBColumnType.Int32) && (columnName == GCRecordField.StaticName));
        }
        bool IsLockingField(string columnName, DBColumnType columnType) {
            return ((columnType == DBColumnType.Int32) && (columnName == "OptimisticLockField"));
        }
        bool IsObjectTypeField(string columnName, DBColumnType columnType) {
            return ((columnType == DBColumnType.Int32) && (columnName == "ObjectType"));
        }
    }

    internal class CSharpPersistentClassGenerator : PersistentClassGenerator {
        string[] reservedWordsArray = new string[]{ "abstract", "event", "new", "struct",
				"as", "explicit", "null", "switch", "base", "extern", "object",
				"this", "bool", "false", "operator", "throw", "break", "finally",
				"out", "true", "byte", "fixed", "override", "try", "case",
				"float", "params", "typeof", "catch", "for", "private", "uint",
				"char", "foreach", "protected", "ulong", "checked", "goto",
				"public", "unchecked", "class", "if", "readonly", "unsafe",
				"const", "implicit", "ref", "ushort", "continue", "in",
				"return", "using", "decimal", "int", "sbyte", "virtual",
				"default", "interface", "sealed", "volatile", "delegate",
				"internal", "short", "void", "do", "is", "sizeof", "while",
				"double", "lock", "stackalloc", "else", "long", "static",
				"enum", "namespace", "string", "get", "partial", "set",
				"value", "where", "yield" };
        protected override string[] ReservedWordsArray { get { return reservedWordsArray; } }

        protected override void WriteUsing(TextWriter w) {
            w.WriteLine("using System;");
            w.WriteLine("using DevExpress.Xpo;");
            w.WriteLine("using DevExpress.Data.Filtering;");
        }
        protected override void StartNamespace(TextWriter w, string name) {
            w.WriteLine("namespace " + name + " {");
        }
        protected override void WriteConnectionComment(TextWriter w, string connectionString) {
            throw new Exception("The method or operation is not implemented.");
        }
        protected override void CloseNamespace(TextWriter w) {
            w.WriteLine("}");
        }

        protected override void TurnoffOptimisticLocking(TextWriter w) {
            w.WriteLine("\t[OptimisticLocking(false)]");
        }
        protected override void WriteClassPersistentTag(TextWriter w, string name) {
            w.WriteLine("\t[Persistent(\"" + name + "\")]");
        }
        protected override void WriteClassNonPersistentTag(TextWriter w) {
            w.WriteLine("\t[NonPersistent]");
        }
        protected override void DeclareClass(TextWriter w, string className, string baseClassName) {
            w.WriteLine("\tpublic class " + className + " : " + baseClassName + " {");
        }
        protected override void CloseClass(TextWriter w) {
            w.WriteLine("\t}");
        }
        protected override void DeclareStaticClass(TextWriter w, string className) {
            w.WriteLine("\tpublic static class " + className + " {");
        }
        protected override void CloseStaticClass(TextWriter w) {
            w.WriteLine("\t}");
        }
        protected override void WriteClassConstructors(TextWriter w, string className) {
            w.WriteLine("\t\tpublic " + className + "(Session session) : base(session) { }");
            w.WriteLine("\t\tpublic " + className + "() : base(Session.DefaultSession) { }");
            w.WriteLine("\t\tpublic override void AfterConstruction() { base.AfterConstruction(); }");
        }

        protected override string GetLanguageType(DBColumnType columnType) {
            switch(columnType) {
                case DBColumnType.Boolean:
                    return "bool";
                case DBColumnType.Byte:
                    return "byte";
                case DBColumnType.SByte:
                    return "sbyte";
                case DBColumnType.Char:
                    return "char";
                case DBColumnType.Decimal:
                    return "decimal";
                case DBColumnType.Single:
                    return "float";
                case DBColumnType.Double:
                    return "double";
                case DBColumnType.Int32:
                    return "int";
                case DBColumnType.UInt32:
                    return "uint";
                case DBColumnType.Int16:
                    return "short";
                case DBColumnType.UInt16:
                    return "ushort";
                case DBColumnType.Int64:
                    return "long";
                case DBColumnType.UInt64:
                    return "ulong";
                case DBColumnType.String:
                    return "string";
                case DBColumnType.DateTime:
                    return "DateTime";
                case DBColumnType.Guid:
                    return "Guid";
                case DBColumnType.ByteArray:
                    return "byte[]";
                default:
                    return "";
            }
        }

        protected override void DeclarePrivatStaticArray(TextWriter w, string arrayName, string arrayType, string[] elements) {
            w.WriteLine("\t\tstatic " + arrayType + "[] " + arrayName + " = {" + string.Join(", ", elements) + "};");
        }

        protected override bool IsCaseSensitive {
            get { return true; }
        }
        protected override string GetArgument(string name, string type) {
            return type + " " + name;
        }
        protected override void DeclareStaticFunction(TextWriter w, string functionName, string arguments, string resultType, string[] body) {
            w.WriteLine("\t\tpublic static " + (string.IsNullOrEmpty(resultType) ? "void" : resultType) + " " + functionName + "(" + arguments + "){");
            for(int i = 0; i < body.Length; i++) {
                w.WriteLine("\t\t\t" + body[i]);
            }
            w.WriteLine("\t\t}");
        }
        protected override void DeclareField(TextWriter w, string type, string columnName) {
            w.WriteLine("\t\t" + type + " " + columnName + ";");
        }
        protected override void WriteKey(TextWriter w) {
            w.WriteLine("\t\t[Key]");
        }
        protected override void WriteIdentityKey(TextWriter w) {
            w.WriteLine("\t\t[Key(true)]");
        }
        protected override void WritePropertySize(TextWriter w, int size) {
            w.WriteLine("\t\t[Size(" + (size <= 0 ? "SizeAttribute.Unlimited" : size.ToString()) + ")]");
        }
        protected override void WritePersistentProperty(TextWriter w, string columnName) {
            w.WriteLine("\t\t[Persistent(\"" + columnName + "\")]");
        }
        protected override bool IsPropertyNameReserved(string propertyName) {
            return !ReservedWords.ContainsKey(propertyName);
        }
        protected override void DeclareProperty(TextWriter w, string type, string propertyName,
                                                                string fieldName, string columnName) {
            w.WriteLine("\t\tpublic " + type + " " + propertyName + " {");
            w.WriteLine("\t\t\tget { return " + fieldName + "; }");
            w.WriteLine("\t\t\tset { SetPropertyValue<" + type + ">(\"" + propertyName + "\", ref " + fieldName + ", value); }");
            w.WriteLine("\t\t}");
        }

        protected override string GetVariableDeclaration(string className, string variableName) {
            return string.Format("{0} {1}", className, variableName);
        }

        protected override string GetGeneric(string className) {
            return "<" + className + ">";
        }

        protected override string GetLanguageKeyword(PersistentClassGeneratorKeywords keyword) {
            switch(keyword) {
                case PersistentClassGeneratorKeywords.Null:
                    return "null";
                case PersistentClassGeneratorKeywords.Return:
                    return "return";
                case PersistentClassGeneratorKeywords.New:
                    return "new";
                case PersistentClassGeneratorKeywords.TypeOf:
                    return "typeof";
                case PersistentClassGeneratorKeywords.OperatorEnd:
                    return ";";
                default:
                    return string.Empty;
            }
        }
    }



    internal class Column {
        private string name = null;
        private bool selected = true;

        public Column(string name, bool selected) {
            this.name = name;
            this.selected = selected;
        }

        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }

        public bool Selected {
            get {
                return this.selected;
            }
            set {
                this.selected = value;
            }
        }
    }

    internal class Columns : Dictionary<string, Column> { }

    internal class Table {
        private Columns columns;
        private string name;

        public Table(string name, Columns columns) {
            this.name = name;
            this.columns = columns;
        }

        public Columns Columns {
            get {
                return this.columns;
            }
            set {
                this.columns = value;
            }
        }

        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
    }

    internal class Tables : Dictionary<string, Table> {
    }

    internal class TableColumnsCheckContainer {
        IDataStoreSchemaExplorer connectionProvider;
        Tables tables = new Tables();

        public Columns GetTableColumns(string tableName) {
            return this.tables[tableName].Columns;
        }

        public string[] GetTableList() {
            string[] result = new string[this.tables.Count];
            int i = 0;
            foreach(KeyValuePair<string, Table> table in this.tables) {
                result[i] = table.Key;
                i++;
            }
            return result;
        }

        public void SetTableColumns(string tableName, Columns columns) {
            this.tables[tableName].Columns = columns;
        }

        public void SetUp(IDataStoreSchemaExplorer connectionProvider) {
            this.connectionProvider = connectionProvider;
            this.tables.Clear();
            string[] tableList = this.ConnectionProvider.GetStorageTablesList(false);
            DBTable[] tables = this.ConnectionProvider.GetStorageTables(tableList);
            for(int i = 0; i < tableList.Length; i++) {
                Columns columns = new Columns();
                foreach(DBColumn column in tables[i].Columns) {
                    columns.Add(column.Name, new Column(column.Name, true));
                }
                this.tables.Add(tableList[i], new Table(tableList[i], columns));
            }
        }

        private IDataStoreSchemaExplorer ConnectionProvider {
            get {
                return this.connectionProvider;
            }
        }
    }
    internal class ResultSetColumn : Column {
        DBColumnType columnType;

        public ResultSetColumn(string name, DBColumnType columnType, bool selected)
            : base(name, selected) {
            this.columnType = columnType;
        }
        public ResultSetColumn(DBNameTypePair nameTypePair, bool selected)
            : this(nameTypePair.Name, nameTypePair.Type, selected) {
        }
        public DBColumnType ColumnType {
            get { return columnType; }
            set { columnType = value; }
        }
    }
    internal class ResultSetColumns : List<ResultSetColumn> { }
    internal class StoredProcedure {
        private ResultSetColumns resultSetColumns = new ResultSetColumns();
        private string name;

        public StoredProcedure(string name, ResultSetColumns resultSetColumns) {
            this.name = name;
            this.resultSetColumns = resultSetColumns;
        }

        public ResultSetColumns ResultSetColumns {
            get {
                return this.resultSetColumns;
            }
            set {
                this.resultSetColumns = value;
            }
        }

        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
    }
    internal class StoredProcedures : Dictionary<string, StoredProcedure> { }
    internal class SProcsResultSetCheckContainer {
        IDataStoreSchemaExplorerSp connectionProvider;
        StoredProcedures storedProcedures = new StoredProcedures();

        public ResultSetColumns GetResultSetColumns(string sprocName) {
            return storedProcedures[sprocName].ResultSetColumns;
        }

        public string[] GetSProcList() {
            string[] result = new string[this.storedProcedures.Count];
            int i = 0;
            foreach(KeyValuePair<string, StoredProcedure> sproc in this.storedProcedures) {
                result[i] = sproc.Key;
                i++;
            }
            return result;
        }
        public void SetSprocResultSet(string sprocName, ResultSetColumns resultSetColumns) {
            this.storedProcedures[sprocName].ResultSetColumns = resultSetColumns;
        }
        string CreateColumnName(string type, int columnNumber) {
            return string.Format("{0}_column_{1}", type, columnNumber);
        }
        public void SetUp(IDataStoreSchemaExplorerSp connectionProvider) {
            this.connectionProvider = connectionProvider;
            this.storedProcedures.Clear();
            DBStoredProcedure[] sprocs = this.ConnectionProvider.GetStoredProcedures();
            for(int i = 0; i < sprocs.Length; i++) {
                ResultSetColumns columns = new ResultSetColumns();
                if(sprocs[i].ResultSets.Count == 1) {
                    for(int columnCounter = 0; columnCounter < sprocs[i].ResultSets[0].Columns.Count; columnCounter++) {
                        string columnName = sprocs[i].ResultSets[0].Columns[columnCounter].Name;
                        if(string.IsNullOrEmpty(columnName)) {
                            columnName = CreateColumnName(sprocs[i].ResultSets[0].Columns[columnCounter].Type.ToString(), columnCounter);
                        }
                        columns.Add(new ResultSetColumn(columnName, sprocs[i].ResultSets[0].Columns[columnCounter].Type, true));
                    }
                }
                storedProcedures[sprocs[i].Name] = new StoredProcedure(sprocs[i].Name, columns);
            }
        }

        private IDataStoreSchemaExplorerSp ConnectionProvider {
            get {
                return this.connectionProvider;
            }
        }
    }
}
