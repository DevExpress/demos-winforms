using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for Appearances.
    /// </summary>
    public partial class Appearances : DevExpress.XtraEditors.XtraForm {
        public Appearances(BaseView view, Form parent) {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            Left = parent.Left + (parent.Width - Width) / 2;
            Top = parent.Top + (parent.Height - Height) / 2;
            this.view = view;
            InitAppearanceList(view);
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        BaseView view;

        void InitAppearanceList(BaseView view) {
            lbcAppearances.Items.Clear();
            ColumnViewAppearances app = view.Appearance as ColumnViewAppearances;
            if(app == null) return;
            PropertyDescriptorCollection collection = TypeDescriptor.GetProperties(view.Appearance);
            for(int i = 0; i < collection.Count; i++)
                if(collection[i].PropertyType == typeof(AppearanceObject))
                    lbcAppearances.Items.Add(collection[i].Name);
            lbcAppearances.SelectedIndex = 0;
        }

        private void lbcAppearances_SelectedIndexChanged(object sender, System.EventArgs e) {
            xtraPropertyGrid1.PropertyGrid.SelectedObjects = SelectedObjects;
        }

        AppearanceObject GetAppearanceObjectByName(BaseView view, string name) {
            ColumnViewAppearances app = view.Appearance as ColumnViewAppearances;
            if(app == null) return null;
            else return app.GetAppearance(name);
        }

        object[] SelectedObjects {
            get {
                if(lbcAppearances.SelectedItem == null) return null;
                ArrayList ret = new ArrayList();
                for(int i = 0; i < lbcAppearances.SelectedIndices.Count; i++) {
                    object obj = GetAppearanceObjectByName(view, lbcAppearances.GetItem(lbcAppearances.SelectedIndices[i]).ToString());
                    ret.Add(obj);
                }
                return ret.ToArray();
            }
        }
    }
}
