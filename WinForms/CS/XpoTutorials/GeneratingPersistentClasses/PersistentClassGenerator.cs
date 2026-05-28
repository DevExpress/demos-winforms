using System;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using System.Data.SqlClient;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata.Helpers;

namespace DevExpress.Xpo.Demos
{
	public class PersistentClassGenerator
	{
		public PersistentClassGenerator() {}

        public static void Generate(TextWriter w, TextWriter log, ConnectionProviderSql prov, params string[] tables) {
            Hashtable list = new Hashtable();
            if(tables.Length == 0)
                tables = prov.GetStorageTablesList(false);
            foreach(string name in tables) {
                DBTable table = new DBTable(name);
                prov.GetTableSchema(table, false, true);
                if(table.PrimaryKey == null) {
                    foreach(DBColumn column in table.Columns)
                        if(column.Name.ToLower() == "id") {
                            StringCollection columns = new StringCollection();
                            columns.Add(column.Name);
                            table.PrimaryKey = new DBPrimaryKey(table.Name, columns);
                            break;
                        }
                }
                if(name == "XPObjectType" || name == "XPWeakReference" || name == "EventHandlerLink" || name == "XPDeletedObject")
                    continue;
                if(table.PrimaryKey != null && table.PrimaryKey.Columns.Count == 1)
                    list.Add(name, table);
                else {
                    log.WriteLine(name + " no single column pk");
                }
            }
            w.WriteLine("using System;");
            w.WriteLine("using DevExpress.Xpo;");
            w.WriteLine("namespace " + (prov.Connection.Database != null ? prov.Connection.Database : "DBObjects") + " {");
            foreach(DBTable table in list.Values) {
                w.WriteLine();
                string className = GetClassName(table.Name);
                if(className != table.Name)
                    w.WriteLine("\t[Persistent(\"" + table.Name + "\")]");
                string s;
                if(!HasLockingField(list, table)) {
                    if(HasGCRecordField(table)) {
                        w.WriteLine("\t[OptimisticLocking(false)]");
                        s = "XPCustomObject";
                    } else
                        s = "XPLiteObject";
                } else {
                    if(HasGCRecordField(table)) {
                        s = "XPCustomObject";
                    } else
                        s = "XPBaseObject";
                }
                w.WriteLine("\tpublic class " + className + " : " + s + " {");
                foreach(DBColumn column in table.Columns) {
                    if(IsLockingField(column) || IsGCRecordField(column) || IsObjectTypeField(column))
                        continue;
                    string type;
                    switch(column.ColumnType) {
                        case DBColumnType.Int32: type = "int"; break;
                        case DBColumnType.String: type = "string"; break;
                        case DBColumnType.Int16: type = "short"; break;
                        case DBColumnType.Boolean: type = "bool"; break;
                        case DBColumnType.Decimal: type = "decimal"; break;
                        case DBColumnType.DateTime: type = "DateTime"; break;
                        case DBColumnType.ByteArray: type = "byte[]"; break;
                        case DBColumnType.Byte: type = "byte"; break;
                        case DBColumnType.Char: type = "char"; break;
                        case DBColumnType.Guid: type = "Guid"; break;
                        case DBColumnType.Single: type = "float"; break;
						case DBColumnType.Double: type = "double"; break;
                        case DBColumnType.Int64: type = "long"; break;
                        case DBColumnType.SByte: type = "sbyte"; break;
                        case DBColumnType.UInt16: type = "ushort"; break;
                        case DBColumnType.UInt32: type = "uint"; break;
                        case DBColumnType.UInt64: type = "ulong"; break;
                        default: {
                            log.WriteLine(table.Name + " - " + column.Name + " not mapped");
                            continue;
                        }
                    }
                    bool objectRef = false;
                    foreach(DBForeignKey fk in table.ForeignKeys) {
                        if(fk.Columns[0] == column.Name) {
                            if(list.Contains(fk.PrimaryKeyTable)) {
                                type = GetClassName(fk.PrimaryKeyTable);
                                objectRef = true;
                            }
                        }
                    }
                    string columnName = column.Name;
                    if(columnName.IndexOf(" ") >= 0)
                        columnName = columnName.Replace(" ", "");
                    if(columnName == className)
                        columnName = columnName + "_";
                    w.WriteLine("\t\t" + type + " f" + columnName + ";");
                    if(column.Name == table.PrimaryKey.Columns[0]) {
                        if(column.IsIdentity || column.ColumnType == DBColumnType.Guid)
                            w.WriteLine("\t\t[Key(true)]");
                        else
                            w.WriteLine("\t\t[Key]");
                    }
                    if(columnName != column.Name)
                        w.WriteLine("\t\t[Persistent(\"" + column.Name + "\")]");
                    w.WriteLine("\t\tpublic " + type + " " + columnName + " {");
                    w.WriteLine("\t\t\tget { return f" + columnName + "; }");
                    if(objectRef) {
                        w.WriteLine("\t\t\tset {");
                        w.WriteLine("\t\t\t\t" + type + " oldValue = f" + columnName + ";");
                        w.WriteLine("\t\t\t\tif(oldValue == value) return;");
                        w.WriteLine("\t\t\t\tf" + columnName + " = value;");
                        w.WriteLine("\t\t\t\tOnChanged(\"" + columnName + "\", oldValue, value);");
                        w.WriteLine("\t\t\t}");
                    } else
                        w.WriteLine("\t\t\tset { SetPropertyValue(\"" + columnName + "\", ref f" + columnName + ", value); }");
                    w.WriteLine("\t\t}");
                }
                w.WriteLine("\t\tpublic " + className + "(Session session) : base(session) { }");
                w.WriteLine("\t\tpublic " + className + "() : base(Session.DefaultSession) { }");
                w.WriteLine("\t\tpublic override void AfterConstruction() { base.AfterConstruction(); }");
                w.WriteLine("\t}");
            }
            w.WriteLine("}");
        }

        static string GetClassName(string tableName) {
            if(tableName.IndexOf(' ') >= 0 || tableName.IndexOf('.') >= 0) {
                tableName = tableName.Replace(" ", "").Replace(".", "_");
            }
            return tableName;
        }

        private static bool HasGCRecordField(DBTable table) {
            foreach(DBColumn col in table.Columns)
                if(IsGCRecordField(col))
                    return true;
            return false;
        }
        static bool IsGCRecordField(DBColumn col) {
            return col.ColumnType == DBColumnType.Int32 && col.Name == GCRecordField.StaticName;
        }
        static bool HasLockingField(Hashtable list, DBTable table) {
            foreach(DBColumn col in table.Columns)
                if(IsLockingField(col)) {
                    return true;
                }
            return false;
        }
        static bool IsLockingField(DBColumn col) {
            return col.ColumnType == DBColumnType.Int32 && col.Name == OptimisticLockingAttribute.DefaultFieldName;
        }
        static bool HasObjectTypeField(DBTable table) {
            foreach(DBColumn col in table.Columns)
                if(IsObjectTypeField(col))
                    return true;
            return false;
        }
        static bool IsObjectTypeField(DBColumn col) {
            return col.ColumnType == DBColumnType.Int32 && col.Name == XPObjectType.ObjectTypePropertyName;
        }
	}
}
