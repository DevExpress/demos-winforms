using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Text;
using Microsoft.CSharp;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.Xpo.DB.Exceptions;
using DevExpress.Data.Filtering;
using System.Reflection;
using System.Collections.Generic;
using DevExpress.Data;

namespace DevExpress.Xpo.Demos {
	/// <summary>
	/// Summary description for ViewForm.
	/// </summary>
	public partial class XtraFormSP : DevExpress.XtraEditors.XtraForm {
		public XtraFormSP() {
			InitializeComponent();
		}

		public string Show(string source, string connectionString, string staticHelperClassName, bool useWindowsXPTheme, LookAndFeelStyle style, string skinName, bool allowFormSkins) {
			UserLookAndFeel.Default.UseWindowsXPTheme = useWindowsXPTheme;
			UserLookAndFeel.Default.Style = style;
			UserLookAndFeel.Default.SkinName = skinName;
			if(allowFormSkins)
				DevExpress.Skins.SkinManager.EnableFormSkins();
			Session.DefaultSession.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;
			Session.DefaultSession.ConnectionString = connectionString;
			CSharpCodeProvider prov = new CSharpCodeProvider();
			CompilerParameters param = new CompilerParameters();
			param.GenerateInMemory = true;
			param.ReferencedAssemblies.Add("System.dll");
			param.ReferencedAssemblies.Add("System.Xml.dll");
			param.ReferencedAssemblies.Add(typeof(XPObject).Assembly.CodeBase.Substring(8));
            param.ReferencedAssemblies.Add(typeof(CriteriaOperator).Assembly.CodeBase.Substring(8));
			CompilerResults res = prov.CompileAssemblyFromSource(param, source);
			if(res.Errors.HasErrors) {
				StringBuilder errors = new StringBuilder();
				foreach(CompilerError e in res.Errors) {
					errors.Append(e.ToString());
					errors.Append("\r\n");
				}
				return errors.ToString(); ;
			}
            Type helperType;
            if(string.IsNullOrEmpty(staticHelperClassName) || (helperType = res.CompiledAssembly.GetType(staticHelperClassName)) == null) {
                return "There are no stored procedures.";
            }
			foreach(MethodInfo mi in helperType.GetMethods(BindingFlags.Public | BindingFlags.Static)) {
                if(mi.Name.StartsWith("Exec") && mi.Name.EndsWith("IntoDataView") && mi.ReturnType == typeof(XPDataView)) {
                    comboBoxEdit1.Properties.Items.Add(new SPDemoMethodInfo(mi));
                }
			}
			try {
				ShowDialog();
			} catch(Exception e) {
				return e.Message;
			}
			return null;
		}

        class SPDemoMethodInfo {
            string name;
            MethodInfo mi;
            public MethodInfo Mi {
                get { return mi; }
            }
            public string Name {
                get { return name; }
            }
            public SPDemoMethodInfo(MethodInfo mi) {
                this.mi = mi;
                string name = mi.Name;
                if(name.StartsWith("Exec")) name = name.Substring(4);
                if(name.EndsWith("IntoDataView")) name = name.Substring(0, name.Length - 12);
                this.name = name;
            }
            public override string ToString() {
                return name;
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
            SPDemoMethodInfo mi = (SPDemoMethodInfo)comboBoxEdit1.SelectedItem;
            if(mi == null) return;
            vGridControl1.Rows.Clear();
            foreach(ParameterInfo pi in mi.Mi.GetParameters()) {
                if(pi.ParameterType == typeof(Session)) continue;
                DevExpress.XtraVerticalGrid.Rows.EditorRow row = new DevExpress.XtraVerticalGrid.Rows.EditorRow(pi.Name);
                row.Name = pi.Name;
                row.Properties.Caption = pi.Name;                
                switch(Type.GetTypeCode(pi.ParameterType)) {
                    case TypeCode.Boolean:
                        row.Properties.UnboundType = UnboundColumnType.Boolean;
                        break;
                    case TypeCode.Byte:
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.SByte:
                    case TypeCode.UInt16:
                    case TypeCode.UInt32:
                    case TypeCode.UInt64:
                        row.Properties.UnboundType = UnboundColumnType.Integer;
                        break;
                    case TypeCode.String:
                        row.Properties.UnboundType = UnboundColumnType.String;
                        break;
                    case TypeCode.Decimal:
                    case TypeCode.Double:
                    case TypeCode.Single:
                        row.Properties.UnboundType = UnboundColumnType.Decimal;
                        break;
                    case TypeCode.DateTime:
                        row.Properties.UnboundType = UnboundColumnType.DateTime;
                        break;
                    default:
                        row.Properties.UnboundType = UnboundColumnType.Object;
                        break;
                }
                vGridControl1.Rows.Add(row);
            }
            simpleButton1.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            SPDemoMethodInfo mi = (SPDemoMethodInfo)comboBoxEdit1.SelectedItem;
            if(mi == null) return;
            List<object> parameters = new List<object>();
            foreach(ParameterInfo pi in mi.Mi.GetParameters()){
                if(pi.ParameterType == typeof(Session)) {
                    parameters.Add(Session.DefaultSession);
                    continue;
                }
                DevExpress.XtraVerticalGrid.Rows.BaseRow row = vGridControl1.Rows.GetRowByFieldName(pi.Name);
                parameters.Add(Convert.ChangeType(row.Properties.Value, pi.ParameterType));
            }
            gridControl1.DataSource = null;
            gridControl1.MainView.PopulateColumns();
            try {
                XPDataView dataView = (XPDataView)mi.Mi.Invoke(null, parameters.ToArray());
                gridControl1.DataSource = dataView;
            } catch(SchemaCorrectionNeededException ex) {
                XtraMessageBox.Show(ex.Message);
            }
        }
	}
}

