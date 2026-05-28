using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraNavBar.Demos {
    /// <summary>
    /// Summary description for AddItemLinks.
    /// </summary>
    public partial class AddItemLinks : TutorialControl {
        public AddItemLinks() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            ExistSelectedItemLink();
            ExistSeparatorItemLink();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void ExistSelectedItemLink() {
            button2.Enabled = button3.Enabled = navBarControl1.ActiveGroup.SelectedLink != null;
        }

        private void ExistSeparatorItemLink() {
            bool res = false;
            if(navBarControl1.ActiveGroup != null) {
                for(int i = navBarControl1.ActiveGroup.ItemLinks.Count - 1; i >= 0; i--) {
                    var itemLinks = navBarControl1.ActiveGroup.ItemLinks[i];
                    var separator = itemLinks.Item as DevExpress.XtraNavBar.NavBarSeparatorItem;
                    if(separator == null) continue;

                    res = true;
                    break;
                }
            }

            button5.Enabled = res;
        }

        //<button1>
        int i = 0;

        private void button1_Click(object sender, System.EventArgs e) {
            DevExpress.XtraNavBar.NavBarItem item = navBarControl1.Items.Add();
            item.LargeImageIndex = item.SmallImageIndex = imageComboBoxEdit1.SelectedIndex;
            item.Caption = "Item " + (i++).ToString();
            navBarControl1.ActiveGroup.ItemLinks.Add(item);
            ExistSelectedItemLink();
        }
        //</button1>

        private void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e) {
            ExistSelectedItemLink();
        }

        private void navBarControl1_SelectedLinkChanged(object sender, DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs e) {
            ExistSelectedItemLink();
        }

        //<button2>
        private void button2_Click(object sender, System.EventArgs e) {
            if(navBarControl1.ActiveGroup.SelectedLink != null)
                navBarControl1.ActiveGroup.SelectedLink.Dispose();
            ExistSelectedItemLink();
        }
        //</button2>

        //<button3>
        private void button3_Click(object sender, System.EventArgs e) {
            if(navBarControl1.ActiveGroup.SelectedLink != null)
                navBarControl1.ActiveGroup.SelectedLink.Item.Dispose();
            ExistSelectedItemLink();
        }
        //</button3>

        //<button4>
        private void button4_Click(object sender, System.EventArgs e) {
            DevExpress.XtraNavBar.NavBarItem item = navBarControl1.Items.Add(true);
            navBarControl1.ActiveGroup.ItemLinks.Add(item);
            navBarControl1.ActiveGroup.SelectedLink = null;
            ExistSeparatorItemLink();
        }
        //</button4>

        //<button5>
        private void button5_Click(object sender, System.EventArgs e) {
            if(navBarControl1.ActiveGroup != null) {
                for(int i = navBarControl1.ActiveGroup.ItemLinks.Count - 1; i >= 0; i--) {
                    var itemLinks = navBarControl1.ActiveGroup.ItemLinks[i];
                    var separator = itemLinks.Item as DevExpress.XtraNavBar.NavBarSeparatorItem;
                    if(separator == null) continue;

                    separator.Dispose();
                    break;
                }
            }
            ExistSeparatorItemLink();
        }
        //</button5>

        private void AddItemLinks_Load(object sender, System.EventArgs e) {
            for(int i = 0; i < imageCollection1.Images.Count; i++)
                imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem("", i, i));
            imageComboBoxEdit1.Properties.LargeImages = imageCollection1;
            imageComboBoxEdit1.Properties.SmallImages = imageCollection2;
            imageComboBoxEdit1.SelectedIndex = 1;
        }
    }
}
