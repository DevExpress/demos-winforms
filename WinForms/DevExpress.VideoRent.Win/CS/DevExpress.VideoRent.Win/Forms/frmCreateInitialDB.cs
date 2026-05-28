using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Reflection;
using System.IO;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraLayout;
using DevExpress.VideoRent.Helpers;
using DevExpress.VideoRent.Resources;
using DevExpress.Internal;

namespace DevExpress.VideoRent.Win.Forms {
    public partial class frmCreateInitialDB : XtraForm {
        DBConnectData dbConnectData;
        FormAnimationSizer sizer;

        public frmCreateInitialDB(DBConnectData dbConnectData) {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForFrmCreateInitialDB(this);
            sizer = new FormAnimationSizer(this);
            this.dbConnectData = dbConnectData;
            this.Icon = ElementHelper.AppIcon;
            notePanel.Text = ConstStrings.Get("DatabaseCreating");
            ceGenerateRentsHistory.DataBindings.Add("Checked", dbConnectData, "GenerateRentsHistory");
            this.Load += (s, e) => Start(this, EventArgs.Empty);
        }
        public event EventHandler Start;
        void rgType_EditValueChanged(object sender, EventArgs e) {
            lcMain.BeginUpdate();
            lcMain.EndUpdate();
            sizer.SetMinHeight(lcMain.Root.MinSize.Height);
        }
        void ceGenerateRentsHistory_CheckedChanged(object sender, EventArgs e) {
            if(ceGenerateRentsHistory.Visible)
                vbwRentsHistory.Enabled = ceGenerateRentsHistory.Checked;
        }
        public void BeginWork() {
            this.Cursor = Cursors.WaitCursor;
            lcMain.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
            lcMain.Refresh();
        }
        public void EndWork(bool complete) {
            lcMain.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.False;
            if(!complete) {
                vbwCreatingDb.Position = vbwCreatingDb.Properties.Minimum;
                vbwRentsHistory.Position = vbwRentsHistory.Properties.Minimum;
            }
            this.Cursor = Cursors.Arrow;
        }
        public IBackgroundWorker CreateDbWorker { get { return vbwCreatingDb; } }
        public IBackgroundWorker GenerateRentsHistoryWorker { get { return vbwRentsHistory; } }
    }
    public class CreateInitialDbDialog : ICreateInitialDbDialog {
        frmCreateInitialDB form;
        public void Show(DBConnectData dbConnectData) { form = new frmCreateInitialDB(dbConnectData); }
        public void ShowDialog() { form.ShowDialog(); }
        public void Close() {
            form.Close();
            form.Dispose();
        }
        public IBackgroundWorker CreateDbWorker { get { return form.CreateDbWorker; } }
        public IBackgroundWorker GenerateRentsHistoryWorker { get { return form.GenerateRentsHistoryWorker; } }
        public event EventHandler Start {
            add { form.Start += value; }
            remove { form.Start -= value; }
        }
        public void BeginWork() { form.BeginWork(); }
        public void EndWork(bool complete) { form.EndWork(complete); }
        public void ShowUnableToOpenMessage(bool createNew) {
            XtraMessageBox.Show(createNew ? ConstStrings.Get("UnableCreateDBMessage") : ConstStrings.Get("UnableOpenDBMessage"), ConstStrings.Get("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
