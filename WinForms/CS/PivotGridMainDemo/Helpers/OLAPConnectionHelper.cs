using DevExpress.Utils;
using DevExpress.XtraPivotGrid.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Helpers {
    public enum ConnectionErrorType { ServerName, CatalogName, CubeName }
    public interface IOLAPConnectionInfo {
        bool IsError { get; }
    }
    public class OLAPConnectionInfoError : IOLAPConnectionInfo {
        public ConnectionErrorType Type { get; private set; }
        public string Message { get; private set; }
        public bool IsError { get { return true; } }

        public OLAPConnectionInfoError(string message, ConnectionErrorType type) {
            Message = message;
            Type = type;
        }
    }
    public class OLAPConnectionStringInfo : IOLAPConnectionInfo {
        public string ConnectionString { get; private set; }
        public bool IsError { get { return false; } }
        public OLAPConnectionStringInfo(string connectionString) {
            ConnectionString = connectionString;
        }
    }
    public class OLAPStringListConnectionInfo : IOLAPConnectionInfo {
        public string[] StringList { get; private set; }
        public bool IsError { get { return false; } }
        public OLAPStringListConnectionInfo(string[] stringList) {
            StringList = stringList;
        }
    }

    public class OLAPConnectionHelper {
        OLAPMetaGetter metaGetter = new OLAPMetaGetter();

        public IOLAPConnectionInfo GetOlapConnectionInfo(string serverName, string catalogName, string cubeName) {
            if(string.IsNullOrEmpty(serverName))
                return ServerError("Please specify the server.");

            metaGetter.ConnectionString = "Provider=msolap;Data Source=" + serverName;
            if(!metaGetter.Connected)
                return ServerError("Couldn't connect to the server. Please check that it is correct.");

            if(!String.IsNullOrEmpty(catalogName))
                metaGetter.ConnectionString += ";Initial Catalog=" + catalogName;
            else
                return CatalogError("Please specify the database name.");
            if(!metaGetter.Connected)
                return CatalogError("Couldn't connect to the \"" + catalogName + "\" database. Please check that it is correct.");

            List<string> cubes = metaGetter.GetCubes(catalogName);
            if(cubes != null) {
                if(string.IsNullOrEmpty(cubeName))
                    return CubeError("Please specify the cube name.");
                if(!cubes.Contains(cubeName))
                    return CubeError("Couldn't connect to the \"" + cubeName + "\" cube. Please check that it is correct.");
            }
            string connectionString = "Provider=msolap;Data Source=" + serverName +
                    ";Initial Catalog=" + catalogName +
                    ";Cube Name=" + cubeName;
            return new OLAPConnectionStringInfo(connectionString);
        }
        public IOLAPConnectionInfo GetCubeList(string serverName, string catalogName) {
            if(!String.IsNullOrEmpty(serverName)) {
                metaGetter.ConnectionString = "Provider=msolap;Data Source=" + serverName;
                if(!metaGetter.Connected)
                    return ServerError("Couldn't connect to the server.");

                if(!String.IsNullOrEmpty(catalogName))
                    metaGetter.ConnectionString += ";Initial Catalog=" + catalogName;

                if(!metaGetter.Connected)
                    return CatalogError("Couldn't connect to the \"" + catalogName + "\" database.");
                List<string> cubes = metaGetter.GetCubes(catalogName);
                if(cubes != null) {
                    if(cubes.Count == 0)
                        return CubeError("There are no cubes in the \"" + catalogName + "\" database.");
                    return new OLAPStringListConnectionInfo(cubes.ToArray());
                }
            }
            return null;
        }
        public IOLAPConnectionInfo GetCatalogList(string serverName) {
            if(!String.IsNullOrEmpty(serverName)) {
                metaGetter.ConnectionString = "Provider=msolap;Data Source=" + serverName;
                if(!metaGetter.Connected)
                    return ServerError("Couldn't connect to the server.");
                List<string> catalogs = metaGetter.GetCatalogs();
                if(catalogs != null) {
                    return new OLAPStringListConnectionInfo(catalogs.ToArray());
                }
            }
            return null;
        }
        static IOLAPConnectionInfo ServerError(string message) {
            return new OLAPConnectionInfoError(message, ConnectionErrorType.ServerName);
        }
        static IOLAPConnectionInfo CatalogError(string message) {
            return new OLAPConnectionInfoError(message, ConnectionErrorType.CatalogName);
        }
        static IOLAPConnectionInfo CubeError(string message) {
            return new OLAPConnectionInfoError(message, ConnectionErrorType.CubeName);
        }
    }
}
