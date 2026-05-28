using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Demos.Properties;

namespace DevExpress.XtraLayout.Demos.Modules.TechnoLayout {
    public partial class FacesUserControl : UserControl {
        public FacesUserControl() {
            InitializeComponent();
            InitializeImageCollection();
            SetPicture();
        }
        void InitializeImageCollection() {
            imageCollection1.AddImage(Resources.Striper1_1_, "Striper1_1_");
            imageCollection1.AddImage(Resources.Striper10_1_, "Striper10_1_");
            imageCollection1.AddImage(Resources.Striper12_1_, "Striper12_1_");
            imageCollection1.AddImage(Resources.Striper13_1_, "Striper13_1_");
            imageCollection1.AddImage(Resources.Striper14_1_, "Striper14_1_");
            imageCollection1.AddImage(Resources.Striper15_1_, "Striper15_1_");
            imageCollection1.AddImage(Resources.Striper16_1_, "Striper16_1_");
            imageCollection1.AddImage(Resources.Striper18_1_, "Striper18_1_");
            imageCollection1.AddImage(Resources.Striper19_1_, "Striper19_1_");
            imageCollection1.AddImage(Resources.Striper2_1_, "Striper2_1_");
            imageCollection1.AddImage(Resources.Striper20_1_, "Striper20_1_");
            imageCollection1.AddImage(Resources.Striper21_1_, "Striper21_1_");
            imageCollection1.AddImage(Resources.Striper22_1_, "Striper22_1_");
            imageCollection1.AddImage(Resources.Striper24_1_, "Striper24_1_");
            imageCollection1.AddImage(Resources.Striper25_1_, "Striper25_1_");
            imageCollection1.AddImage(Resources.Striper26_1_, "Striper26_1_");
            imageCollection1.AddImage(Resources.Striper27_1_, "Striper27_1_");
            imageCollection1.AddImage(Resources.Striper28_1_, "Striper28_1_");
            imageCollection1.AddImage(Resources.Striper3_1_, "Striper3_1_");
            imageCollection1.AddImage(Resources.Striper4_1_, "Striper4_1_");
            imageCollection1.AddImage(Resources.Striper6_1_, "Striper6_1_");
            imageCollection1.AddImage(Resources.Striper7_1_, "Striper7_1_");
            imageCollection1.AddImage(Resources.Striper8_1_, "Striper8_1_");
            imageCollection1.AddImage(Resources.Striper9_1_, "Striper9_1_");
            imageCollection1.AddImage(Resources.Striper0_1_, "Striper0_1_");
        }
        void SetPicture() {
            int i = 0;
            foreach(LayoutControlItem lci in lcgFaces.Items) {
                ((PictureEdit)lci.Control).Image = imageCollection1.Images[i];
                i++;
            }
        }
    }
}
