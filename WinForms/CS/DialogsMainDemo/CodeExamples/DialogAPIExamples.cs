using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Helpers;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using DevExpress.XtraDialogs;
using DevExpress.Utils.CommonDialogs;

namespace DevExpress.XtraDialogs.Demos.CodeExamples {
    [CodeExampleClass("How to use the FolderBrowser dialog", "DialogAPIExamples.cs")]
    public static class FolderBrowser {
        static FolderBrowser() {
            if(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle < 0)
                DevExpress.XtraEditors.Base.XtraCommonDialog.ForceInitialize();
        }
        //
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            SimpleButton button = new SimpleButton();
            button.Text = "Show dialog";
            button.Dock = System.Windows.Forms.DockStyle.Top;
            button.Parent = sampleHost;

            TextEdit edit = new TextEdit();
            edit.Dock = System.Windows.Forms.DockStyle.Top;
            edit.Parent = sampleHost;

            return new object[] { button, edit };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) { 
            /* do cleanup */
        }

        [CodeExampleCase("Using the FolderBrowserDialog (Standard)")]
        [CodeExampleUnderlineTokens("ShowDialog")]
        public static void StandardDialog(SimpleButton button, TextEdit edit) {
            button.Click += (s, e) => {
                using(var dialog = new FolderBrowserDialog()) {
                    dialog.SelectedPath = @"C:\";
                    if(dialog.ShowDialog() == DialogResult.OK)
                        edit.Text = dialog.SelectedPath;
                }
            };
        }
        [CodeExampleCase("Using the XtraFolderBrowserDialog")]
        [CodeExampleUnderlineTokens("ShowDialog")]
        public static void SkinnableDialog(SimpleButton button, TextEdit edit) {
            button.Click += (s, e) => {
                using(var dialog = new XtraFolderBrowserDialog()) {
                    dialog.SelectedPath = @"C:\";
                    if(dialog.ShowDialog() == DialogResult.OK)
                        edit.Text = dialog.SelectedPath;
                }
            };
        }
        [CodeExampleCase("Using the XtraFolderBrowserDialog (Wide)")]
        [CodeExampleUnderlineTokens("ShowDialog", "DialogStyle")]
        [CodeExampleHighlightTokens("FolderBrowserDialogStyle")]
        public static void SkinnableWideDialog(SimpleButton button, TextEdit edit) {
            button.Click += (s, e) => {
                using(var dialog = new XtraFolderBrowserDialog()) {
                    dialog.DialogStyle = FolderBrowserDialogStyle.Wide;
                    dialog.SelectedPath = @"C:\";
                    if(dialog.ShowDialog() == DialogResult.OK) 
                        edit.Text = dialog.SelectedPath;
                }
            };
        }
    }
}
