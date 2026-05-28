
using System;
using System.Data.Common;
using System.Globalization;
namespace DevExpress.Demos.SalesDBGenerator {
	public class SqlHelper<T, Command>
		where T : DbConnection
		where Command : DbCommand, new() {
		public object ReadValue(T connection, string selectQuery, params DbParameter[] pars) {
#pragma warning disable DX0024 
			using(var dbCommand = new Command() { Connection = connection }) {
				dbCommand.CommandText = selectQuery;
				dbCommand.CommandTimeout = 1000;
				if(pars != null)
					dbCommand.Parameters.AddRange(pars);
				try {
					return CheckDbNull(dbCommand.ExecuteScalar());
				}
				catch { return null; }
			}
#pragma warning restore DX0024 
		}
		object CheckDbNull(object value) {
			if(value == null || value is DBNull)
				return null;
			return value;
		}
		public string GetString(object value) {
			if(value == null || value is DBNull)
				return string.Empty;
			return value.ToString();
		}
		public DateTime GetDateInv(object value) {
			if(value == null || value is DBNull)
				return DateTime.MinValue;
			return DateTime.ParseExact(value.ToString(), "d/M/yyyy", DateTimeFormatInfo.InvariantInfo);
		}
		public int GetInt(object value) {
			if(value == null || value is DBNull)
				return 0;
			return Convert.ToInt32(value);
		}
		public DateTime GetDate(object value) {
			if(value == null || value is DBNull)
				return DateTime.MinValue;
			if(value is DateTime)
				return (DateTime)value;
			return GetDateInv(value);
		}
		public decimal GetDecimal(object value) {
			if(value == null || value is DBNull)
				return 0;
			return (decimal)Convert.ChangeType(value, typeof(decimal));
		}
		public Guid GetGuid(object value) {
			if(value == null || value is DBNull)
				return Guid.Empty;
			return new Guid(value.ToString());
		}
		public bool GetBool(object value) {
			if(value == null || value is DBNull)
				return false;
			if(value is bool)
				return (bool)value;
			if(value is int)
				return (int)value == 1;
			return false;
		}
	}
}
