using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Data.Filtering;

namespace DevExpress.Xpo.Demos {
    public partial class Pagination : TutorialControl {
        public Pagination() {
            InitializeComponent();
            var result = unitOfWork1.Evaluate<BusinessObject>(CriteriaOperator.Parse("Count()"), null);
            if(result != null && (int)result == 0)
                CreateBusinessObjects(unitOfWork1, 100);
        }

        public override bool SetNewWhatsThisPadding { get { return true; } }

        private void Pagination_Load(object sender, System.EventArgs e) {
            UpdateEditors();
        }

        //<simpleButton2>
        private void simpleButton2_Click(object sender, System.EventArgs e) {
            SelectPage(true);
        }
        //</simpleButton2>

        //<simpleButton1>
        private void simpleButton1_Click(object sender, System.EventArgs e) {
            SelectPage(false);
        }

        //<simpleButton2>
        private void SelectPage(bool forward) {
            if(forward) {
                if(xpPageSelector1.CurrentPage == xpPageSelector1.PageCount - 1)
                    return;
                xpPageSelector1.CurrentPage ++;
            }
            else {
                if(xpPageSelector1.CurrentPage == 0)
                    return;
                xpPageSelector1.CurrentPage --;
            }
            UpdateEditors();
        }
        //</simpleButton1>
        //</simpleButton2>

        private void UpdateEditors() {
            simpleButton1.Enabled = !(xpPageSelector1.CurrentPage == 0);
            simpleButton2.Enabled = !(xpPageSelector1.CurrentPage == xpPageSelector1.PageCount - 1);
            lCurrentPage.Text = "Current Page: " + xpPageSelector1.CurrentPage.ToString();
        }

        private void bSave_Click(object sender, System.EventArgs e) {
            SaveChanges(unitOfWork1);
        }
    }
}
