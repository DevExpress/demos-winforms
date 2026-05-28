using System;
using System.Data;
using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos {
    public partial class FixedBands : TutorialControl {
        public FixedBands() {
            InitializeComponent();
            gridControl1.ForceInitialize();
            gridControl2.ForceInitialize();
            FillDataSetWithData();
            InitEditing();
            InitBands();
            InitFixedStyle();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "FixedBands" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "FixedBands"; }
        }
        public override BaseView ExportView {
            get {
                if(xtraTabControl1.SelectedTabPageIndex == 0)
                    return bandedGridView1;
                return bandedGridView2;
            }
        }
        void FillDataSetWithData() {
            const int YearsCount = 9;
            const int ModelCount = 20;
            string[] ModuleNames = new string[] {
                 "Chrysler", "Dodge", "Plymouth", "Ford", "Mercury",
                    "Buick", "Cadillac", "Chevrolet", "Oldsmobile", "Pontiac",
                    "Saturn", "Toyota Cavalier", "EV1", "Mazda", "BMW",
                    "Honda", "Mitsubishi", "Nissan", "Subaru","Toyota"};
            int[,] CarProductionData = new int[,] { {
                 132155, 84189,   75104,   120864,  55852,  41814,  45800,  49532,  86432}, {
                 285186, 258680,  330007,  313281,  303831, 236880, 239497, 279121, 321319}, {
                 145254, 169717,  172509,  119659,  190607, 164260, 136874, 124977, 52748}, {
                 996614, 1118788, 1329567, 1106175, 939905, 996300, 960420, 943098, 964880}, {
                 432321, 470985,  464539,  351663,  371702, 400808, 351482, 318321, 288466}, {
                 401788, 433977,  526446,  388949,  325411, 288322, 223764, 229007, 195857}, {
                 208798, 207337,  220692,  177937,  163872, 174709, 167530, 142838, 173306}, {
                 664253, 721183,  657402,  605347,  529933, 709334, 517030, 668193, 541080}, {
                 377049, 405496,  487333,  417432,  292801, 296579, 263887, 282608, 246217}, {
                 615182, 502841,  653874,  622519,  579364, 657030, 519354, 597615, 611748}, {
                 193656, 280406,  277192,  324835,  312461, 253285, 263933, 267002, 286984}, {
                 0,      0,       0,       1949,    10964,  11499,  4645,   9837,   1144}, {
                 0,      0,       0,       0,       0,      0,      0,      329,    0}, {
                 183648, 201746,  265527,  162281,  124196, 105580, 155515, 177330, 116151}, {
                 0,      0,       0,       12166,   53120,  63668,  54115,  48150,  40420}, {
                 496834, 393621,  473790,  552359,  695859, 664968, 707314, 709096, 712122}, {
                 148733, 129336,  186472,  237403,  195842, 170293, 170100, 154661, 210053}, {
                 170758, 283968,  317610,  321226,  282898, 302273, 236775, 182360, 163058}, {
                 53838,  48036,   48949,   87610,   88903,  107018, 104630, 93458,  114998}, {
                 370956, 343831,  433744,  566859,  595104, 599394, 562283, 548336, 582986}};
            for(int i = 0; i < ModelCount; i++) {
                DataRow newRow = this.dataTable.NewRow();
                newRow[this.dcMaker] = ModuleNames[i];
                for(int year = 0; year < YearsCount; year++) {
                    newRow[year + 1] = CarProductionData[i, year];
                }
                this.dataTable.Rows.Add(newRow);
            }
#pragma warning disable DX0024
            gcTotal.Expression = "Year1992+Year1993+Year1994+Year1995+Year1996+Year1997+Year1998+Year1999+Year2000";
#pragma warning restore DX0024
            InitCustomersPaymentData(dsContacts1);
        }
        void InitEditing() {
            foreach(GroupFooterShowMode mode in Enum.GetValues(typeof(GroupFooterShowMode)))
                cbShowMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<GroupFooterShowMode>.GetTitle(mode), mode, -1));
            cbShowMode.EditValue = bandedGridView2.OptionsView.GroupFooterShowMode;
            numFixedLineWidth.Value = bandedGridView2.FixedLineWidth;
        }
        void InitFixedStyle() {
            foreach(FixedStyle style in Enum.GetValues(typeof(FixedStyle)))
                icbFixedStyle.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FixedStyle>.GetTitle(style), style, -1));
        }
        void InitBands() {
            icbBand.Properties.SmallImages = bandedGridView1.Images;
            icbBand.Properties.Sorted = true;
            foreach(GridBand band in bandedGridView1.Bands) {
                if(band.Visible)
                    icbBand.Properties.Items.Add(new ImageComboBoxItem(band.GetTextCaption(), band, band.ImageIndex));
            }
            icbBand.EditValue = gbManufacture;
        }
        void FixedBands_Load(object sender, System.EventArgs e) {
            gridControl2.ForceInitialize();
            bandedGridView2.ExpandAllGroups();
            //<gridControl1>
            /* 
            ~The following properties are specified at design-time and listed here for demonstration purposes
            
            gridBand1.Fixed = Columns.FixedStyle.Left;
            gridBand2.Fixed = Columns.FixedStyle.None;
            gridBand3.Fixed = Columns.FixedStyle.Right;
            */
            //</gridControl1>
        }
        //<numFixedLineWidth>
        void numFixedLineWidth_ValueChanged(object sender, EventArgs e) {
            bandedGridView2.FixedLineWidth = (int)numFixedLineWidth.Value;
        }
        //</numFixedLineWidth>
        //<cbShowMode>
        void cbShowMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(cbShowMode.SelectedItem != null)
                bandedGridView2.OptionsView.GroupFooterShowMode = (GroupFooterShowMode)cbShowMode.EditValue;
        }
        //</cbShowMode>
        void bandedGridView2_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e) {
            if(e.Column.FieldName.IndexOf("Row") != -1)
                e.Appearance.Font = new Font("Arial", 8, FontStyle.Bold);
        }
        void icbBand_SelectedIndexChanged(object sender, EventArgs e) {
            GridBand band = icbBand.EditValue as GridBand;
            if(band == null)
                return;
            icbFixedStyle.EditValue = band.Fixed;
            icbFixedStyle.Enabled = band != gbYear;
        }
        //<icbFixedStyle>
        void icbFixedStyle_SelectedIndexChanged(object sender, EventArgs e) {
            GridBand band = icbBand.EditValue as GridBand;
            if(band == null)
                return;
            band.Fixed = (FixedStyle)icbFixedStyle.EditValue;
        }
        //</icbFixedStyle>
    }
}
