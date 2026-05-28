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

namespace DevExpress.Xpo.Demos {
	/// <summary>
	/// Summary description for ViewForm.
	/// </summary>
	public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm {
		public XtraForm1() {
			InitializeComponent();
		}

		public string Show(string source, string connectionString, bool useWindowsXPTheme, LookAndFeelStyle style, string skinName, bool allowFormSkins) {
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
			XPClassInfo[] classes = Session.DefaultSession.Dictionary.CollectClassInfos(res.CompiledAssembly);
			foreach(XPClassInfo ci in classes) {
				comboBoxEdit1.Properties.Items.Add(ci);
			}
			try {
				ShowDialog();
			} catch(Exception e) {
				return e.Message;
			}
			return null;
		}

		private void comboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
			XPCollection collection = new XPCollection(Session.DefaultSession, (XPClassInfo)comboBoxEdit1.SelectedItem);
			collection.TopReturnedObjects = Convert.ToInt32(seTopReturnedObjects.Value);
			gridControl1.DataSource = null;
			gridControl1.MainView.PopulateColumns();
			try {
				gridControl1.DataSource = collection;
			} catch(SchemaCorrectionNeededException ex) {
				XtraMessageBox.Show(ex.Message);
			}
		}
	}
}

