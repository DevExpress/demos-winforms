using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraEditors.DXErrorProvider;

namespace DevExpress.MailClient.Win.Forms {
    public partial class frmFeed : XtraForm {
        DialogRole role = DialogRole.New;
        NavBarControl navBar;
        List<string> uniqueNames;
        public frmFeed() {
            InitializeComponent();
        }
        void InitValidation() {
            UniqueNameValidationRule rule = new UniqueNameValidationRule(uniqueNames);
            rule.ErrorType = ErrorType.Critical;
            rule.ErrorText = Properties.Resources.RuleUniqueNamesWarning; 
            dxValidationProvider1.SetValidationRule(teCaption, rule);
            dxValidationProvider1.SetValidationRule(cbeGroup, ValidationRulesHelper.RuleIsNotBlank);
            dxValidationProvider1.SetValidationRule(heLink, ValidationRulesHelper.RuleIsNotBlank);
            cbeGroup.EditValueChanged += new EventHandler(edit_EditValueChanged);
            teCaption.EditValueChanged += new EventHandler(edit_EditValueChanged);
            heLink.EditValueChanged += new EventHandler(edit_EditValueChanged);
        }
        void edit_EditValueChanged(object sender, EventArgs e) {
            sbOK.Enabled = !string.IsNullOrEmpty(heLink.Text);
        }
        public NavBarItem CurrentItem { get { return navBar.SelectedLink.Item; } }
        NavBarGroup CurrentGroup { get { return navBar.SelectedLink.Group; } }
        public frmFeed(DialogRole role, NavBarControl navBar) {
            InitializeComponent();
            this.role = role;
            this.navBar = navBar;
            cbeGroup.Properties.Items.AddRange(NavBarHelper.GetGroupNames(navBar));
            sbOK.Text = role == DialogRole.New ? Properties.Resources.Add : Properties.Resources.OK;
            Text = (role == DialogRole.New ? Properties.Resources.NewFeedDescription : Properties.Resources.EditFeedDescription).Replace(".", string.Empty);
            uniqueNames = NavBarHelper.GetItemNames(navBar);
            uniqueNames.Add(string.Empty);
            if(role == DialogRole.New) {
                teCaption.Text = NavBarHelper.GetUniqueItemName(Properties.Resources.TempFeedName, navBar);
                cbeGroup.Text = Properties.Resources.TempGroupName;
                sbOK.Enabled = false;
            } else {
                uniqueNames.Remove(CurrentItem.Caption);
                teCaption.Text = CurrentItem.Caption;
                cbeGroup.Text = CurrentGroup.Caption;
                heLink.Text = string.Format("{0}", CurrentItem.Tag);
            }
            InitValidation();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if(DialogResult == DialogResult.OK) {
                if(role == DialogRole.New) {
                    navBar.BeginUpdate();
                    NavBarGroup group = NavBarHelper.GetGroupByName(cbeGroup.Text, navBar);
                    NavBarItem item = new NavBarItem(teCaption.Text);
                    NavBarItemLink link = group.ItemLinks.Add(item);
                    group.Expanded = true;
                    item.Tag = ObjectHelper.GetCorrectUrl(heLink.Text);
                    navBar.SelectedLink = link;
                    navBar.EndUpdate();
                } else {
                    CurrentItem.Caption = teCaption.Text;
                    CurrentItem.Tag = ObjectHelper.GetCorrectUrl(heLink.Text);
                    if(CurrentGroup.Caption != cbeGroup.Text) {
                        navBar.BeginUpdate();
                        NavBarGroup group = NavBarHelper.GetGroupByName(cbeGroup.Text, navBar);
                        group.Expanded = true;
                        NavBarItemLink link = group.ItemLinks.Add(CurrentItem);
                        CurrentGroup.ItemLinks.Remove(navBar.SelectedLink);
                        navBar.SelectedLink = link;
                        NavBarHelper.DeleteEmptyGroup(navBar);
                        navBar.EndUpdate();
                    }
                }
            }
        }
    }
}
