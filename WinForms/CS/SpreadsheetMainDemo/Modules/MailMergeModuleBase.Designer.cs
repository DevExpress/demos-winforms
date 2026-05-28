using System.Globalization;
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraBars.Docking;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class MailMergeModuleBase : SpreadSheetTutorialControlBase {
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailMergeModuleBase));
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem47 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem48 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem49 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem50 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem51 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem52 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem53 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem54 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem55 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem56 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem57 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem58 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem59 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem60 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem61 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem62 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem63 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem64 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem70 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem71 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem72 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem73 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem74 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem75 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem76 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem77 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem78 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem79 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem80 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem81 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem82 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem83 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem84 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem85 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem86 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem87 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem88 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem89 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem90 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem91 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem92 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem93 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem94 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem95 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem96 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem97 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem98 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem99 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem100 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem101 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem102 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem103 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem104 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem105 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem106 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem107 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem108 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem109 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem110 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem111 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem112 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem113 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem114 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem115 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem116 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem117 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem118 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem119 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem120 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem121 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem122 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem123 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem124 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem125 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem126 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem127 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem128 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem129 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem130 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem131 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem132 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem133 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem134 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem135 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem136 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem137 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem138 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem139 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem140 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem141 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem142 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem143 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem144 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem145 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem146 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem147 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem148 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem149 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem150 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem151 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem152 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem153 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem154 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem155 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem156 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem157 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem158 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem159 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem160 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem161 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem162 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem163 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem164 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem165 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem166 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem167 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem168 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem169 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem170 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem171 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem172 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem173 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem174 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem177 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem178 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem179 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem180 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem181 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem182 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem183 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem184 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem185 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem186 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem187 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem188 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem189 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem190 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem191 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem192 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem193 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem194 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem195 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem196 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem197 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem198 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem199 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup47 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem200 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem201 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup48 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem202 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem203 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem204 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem205 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup49 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem206 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem207 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem208 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem209 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem210 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem211 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem212 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem213 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem214 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem215 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem216 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem217 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup50 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem218 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem219 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem220 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem221 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem222 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem223 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem224 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup51 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem225 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem226 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem227 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem228 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem229 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup52 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem230 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem231 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem232 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup53 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem233 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem234 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem235 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem236 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem237 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup54 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem238 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem239 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem240 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup55 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem241 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem242 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem243 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem244 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup56 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem245 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem246 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem247 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem248 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup57 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem249 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem250 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem251 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem252 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup58 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem253 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem254 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem255 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem256 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup59 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem257 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem258 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem259 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem260 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem261 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem262 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup60 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem263 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup61 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem264 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem265 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup62 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem266 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem267 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup63 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem268 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem269 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup64 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem270 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem271 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem272 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem273 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem274 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem275 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem276 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem277 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem278 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem279 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem280 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem281 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem282 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem283 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem284 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem285 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem286 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem287 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup70 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem288 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem289 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem290 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup71 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem291 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem292 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem293 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem294 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem295 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup72 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem296 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem297 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup73 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem298 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem299 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem300 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem301 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup74 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem302 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem303 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem304 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup75 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem305 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem306 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem307 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem308 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem309 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem310 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem311 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem312 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem313 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup76 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem314 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem315 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem316 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem317 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem318 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem319 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem320 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem321 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem322 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup77 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem323 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem324 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem325 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem326 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup78 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem327 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem328 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem329 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem330 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup79 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem331 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem332 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem333 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup80 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem334 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem335 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup81 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem336 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem337 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup82 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem340 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem341 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem342 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem343 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem344 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem345 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem346 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup83 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem347 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem348 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem349 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem350 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem351 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem352 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem353 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem354 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem355 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem356 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem357 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup84 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem358 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem359 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem360 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem361 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem362 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup85 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem363 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem364 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup86 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem365 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem366 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem367 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem368 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup87 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem369 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem370 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem371 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem372 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem373 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem374 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup88 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem375 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem376 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem377 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem378 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem379 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem380 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem9 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem10 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem11 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem12 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem13 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem14 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup89 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem381 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem382 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem383 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem384 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem385 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem386 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem387 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem388 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem389 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem390 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem391 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem392 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup90 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem393 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem394 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem395 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem396 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem397 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem398 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem399 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup91 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem400 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem401 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem402 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem403 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem404 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup92 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem405 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem406 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem407 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup93 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem408 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem409 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem410 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem411 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem412 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup94 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem413 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem414 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem415 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup95 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem416 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem417 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem418 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem419 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup96 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem420 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem421 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem422 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem423 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup97 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem424 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem425 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem426 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem427 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup98 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem428 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem429 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem430 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem431 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup99 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem432 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem433 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem434 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem435 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem436 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem437 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup100 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem438 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup101 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem439 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem440 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup102 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem441 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem442 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup103 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem443 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem444 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup104 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem445 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem446 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem447 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup105 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem448 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem449 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem450 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup106 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem451 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem452 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem453 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup107 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem454 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem455 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem456 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup108 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem457 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem458 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem459 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup109 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem460 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem461 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem462 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup110 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem463 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem464 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem465 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup111 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem466 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem467 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem468 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem469 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem470 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup112 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem471 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem472 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup113 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem473 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem474 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem475 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem476 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup114 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem477 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem478 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem479 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup115 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem480 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem481 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem482 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem483 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem484 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem485 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem486 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem487 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem488 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup116 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem489 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem490 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem491 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem492 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem493 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem494 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem495 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem496 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem497 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup117 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem498 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem499 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem500 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem501 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup118 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem502 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem503 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem504 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem505 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup119 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem506 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem507 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem508 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup120 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem509 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem510 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup121 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem511 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem512 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup122 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem515 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem516 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem517 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem518 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem519 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem520 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem521 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup123 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem522 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem523 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem524 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem525 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem526 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem527 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem528 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem529 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem530 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem531 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem532 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup124 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem533 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem534 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem535 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem536 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem537 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup125 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem538 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem539 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup126 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem540 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem541 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem542 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem543 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup127 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem544 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem545 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem546 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem547 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem548 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem549 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup128 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem550 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem551 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem552 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem553 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem554 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem555 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem15 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem16 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem17 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem18 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem19 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem20 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem21 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem22 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem23 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem24 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem25 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem26 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem27 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem28 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup129 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem556 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem557 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem558 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem559 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem560 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem561 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem562 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem563 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem564 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem565 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem566 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem567 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup130 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem568 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem569 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem570 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem571 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem572 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem573 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem574 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup131 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem575 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem576 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem577 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem578 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem579 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup132 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem580 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem581 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem582 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup133 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem583 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem584 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem585 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem586 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem587 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup134 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem588 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem589 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem590 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup135 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem591 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem592 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem593 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem594 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup136 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem595 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem596 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem597 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem598 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup137 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem599 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem600 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem601 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem602 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup138 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem603 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem604 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem605 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem606 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup139 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem607 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem608 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem609 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem610 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem611 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem612 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup140 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem613 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup141 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem614 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem615 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup142 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem616 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem617 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup143 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem618 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem619 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup144 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem620 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem621 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem622 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup145 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem623 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem624 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem625 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup146 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem626 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem627 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem628 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup147 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem629 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem630 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem631 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup148 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem632 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem633 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem634 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup149 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem635 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem636 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem637 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup150 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem638 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem639 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem640 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup151 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem641 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem642 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem643 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem644 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem645 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup152 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem646 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem647 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup153 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem648 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem649 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup154 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem650 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem651 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem652 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup155 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem653 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem654 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem655 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup156 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem656 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem657 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup157 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem658 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem659 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup158 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem662 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem663 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem664 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem665 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem666 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem667 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem668 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup159 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem669 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem670 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem671 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem672 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem673 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem674 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem675 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem676 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem677 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem678 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem679 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup160 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem680 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem681 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem682 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem683 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem684 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem685 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem686 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem687 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem688 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup161 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem689 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem690 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem691 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem692 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem693 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem694 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem695 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem696 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem697 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup162 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem698 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem699 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem700 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem701 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup163 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem702 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem703 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem704 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem705 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup164 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem706 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem707 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem708 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem709 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem710 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup165 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem711 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem712 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup spreadsheetCommandGalleryItemGroup166 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem713 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem714 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem715 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem spreadsheetCommandGalleryItem716 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.commandBarGalleryDropDown50 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.spreadsheetCommandBarButtonItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeFontNameItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.changeFontSizeItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem();
            this.repositoryItemSpreadsheetFontSizeEdit1 = new DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit();
            this.spreadsheetCommandBarButtonItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarCheckItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarSubItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.changeBorderLineColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem();
            this.changeBorderLineStyleItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem();
            this.commandBarGalleryDropDown73 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeCellFillColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem();
            this.changeFontColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem();
            this.barButtonGroup5 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarCheckItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.barButtonGroup6 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarCheckItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.barButtonGroup7 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarButtonItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup8 = new DevExpress.XtraBars.BarButtonGroup();
            this.changeNumberFormatItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem();
            this.repositoryItemPopupGalleryEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit();
            this.barButtonGroup9 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarSubItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barButtonGroup10 = new DevExpress.XtraBars.BarButtonGroup();
            this.spreadsheetCommandBarButtonItem44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarSubItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem47 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem48 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem49 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem50 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem51 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem52 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem53 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem54 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem55 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem56 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem57 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem58 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown74 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown75 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown76 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonItem59 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem60 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem61 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem62 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.galleryFormatAsTableItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem();
            this.commandBarGalleryDropDown77 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.galleryChangeStyleItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem();
            this.spreadsheetCommandBarSubItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem63 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem64 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem70 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem71 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem72 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem73 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem74 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem75 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem76 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem77 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem78 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem79 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem80 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem81 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem82 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem83 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem84 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem85 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem86 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem87 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem88 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem89 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.changeSheetTabColorItem1 = new DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem();
            this.spreadsheetCommandBarButtonItem90 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem91 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem92 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem93 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem94 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem95 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem96 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem97 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem98 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem99 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem100 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem101 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem102 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem103 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem104 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem105 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem106 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem107 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem108 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem109 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem110 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem111 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem112 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem113 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem114 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem115 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem116 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem117 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem118 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem119 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem120 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown78 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown79 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown80 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown81 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown82 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown83 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown84 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown85 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem12 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown86 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonItem121 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem122 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem123 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.pageSetupPaperKindItem1 = new DevExpress.XtraSpreadsheet.UI.PageSetupPaperKindItem();
            this.spreadsheetCommandBarSubItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem124 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem125 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem126 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem127 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem128 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem129 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem130 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem131 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.functionsFinancialItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsFinancialItem();
            this.functionsLogicalItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsLogicalItem();
            this.functionsTextItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsTextItem();
            this.functionsDateAndTimeItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsDateAndTimeItem();
            this.functionsLookupAndReferenceItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsLookupAndReferenceItem();
            this.functionsMathAndTrigonometryItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsMathAndTrigonometryItem();
            this.spreadsheetCommandBarSubItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.functionsStatisticalItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsStatisticalItem();
            this.functionsEngineeringItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsEngineeringItem();
            this.functionsInformationItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsInformationItem();
            this.functionsCompatibilityItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsCompatibilityItem();
            this.functionsWebItem1 = new DevExpress.XtraSpreadsheet.UI.FunctionsWebItem();
            this.spreadsheetCommandBarButtonItem132 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem133 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.definedNameListItem1 = new DevExpress.XtraSpreadsheet.UI.DefinedNameListItem();
            this.spreadsheetCommandBarButtonItem134 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem135 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem136 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem25 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem137 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem138 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem139 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem26 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem140 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem141 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem142 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem143 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem144 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem145 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem146 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem147 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem148 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem149 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem150 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem151 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem152 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem153 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem154 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem155 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem156 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem157 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem158 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem159 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem160 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem161 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem162 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem163 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem164 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem165 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.galleryChartLayoutItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChartLayoutItem();
            this.galleryChartStyleItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryChartStyleItem();
            this.spreadsheetCommandBarButtonItem166 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem13 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown87 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem14 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown88 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarSubItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem15 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown89 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem16 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown90 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem17 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown91 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarSubItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonGalleryDropDownItem18 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown92 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem19 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown93 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem20 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown94 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem21 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown95 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem22 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown96 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem23 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown97 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetCommandBarButtonGalleryDropDownItem24 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem();
            this.commandBarGalleryDropDown98 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.renameTableItemCaption1 = new DevExpress.XtraSpreadsheet.UI.RenameTableItemCaption();
            this.renameTableItem1 = new DevExpress.XtraSpreadsheet.UI.RenameTableItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.spreadsheetCommandBarCheckItem27 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem28 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem29 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem30 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem31 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.galleryTableStylesItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryTableStylesItem();
            this.spreadsheetCommandBarButtonItem167 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem168 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem169 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem170 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem171 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem172 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem173 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem32 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem174 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem175 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem176 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem33 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem177 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem178 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem179 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem180 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem181 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem182 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem183 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem184 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem185 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem186 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem34 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem35 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem36 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem187 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem188 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem189 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem190 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem191 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem192 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem193 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem194 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem195 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem196 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem197 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem198 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem199 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem200 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem37 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem38 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem39 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.galleryPivotStylesItem1 = new DevExpress.XtraSpreadsheet.UI.GalleryPivotStylesItem();
            this.spreadsheetCommandBarButtonItem201 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem40 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem202 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem203 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem204 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem205 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem206 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem41 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarSubItem42 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarCheckItem44 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarCheckItem45 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem207 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem208 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem209 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarSubItem43 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem();
            this.spreadsheetCommandBarButtonItem210 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem211 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem212 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem213 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem214 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem215 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem216 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem217 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarCheckItem46 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem();
            this.spreadsheetCommandBarButtonItem218 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.endModeInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.EndModeInfoStaticItem();
            this.averageInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.AverageInfoStaticItem();
            this.countInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.CountInfoStaticItem();
            this.numericalCountInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.NumericalCountInfoStaticItem();
            this.minInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.MinInfoStaticItem();
            this.maxInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.MaxInfoStaticItem();
            this.sumInfoStaticItem1 = new DevExpress.XtraSpreadsheet.UI.SumInfoStaticItem();
            this.zoomEditItem1 = new DevExpress.XtraSpreadsheet.UI.ZoomEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.showZoomButtonItem1 = new DevExpress.XtraSpreadsheet.UI.ShowZoomButtonItem();
            this.progressBarItem1 = new DevExpress.XtraSpreadsheet.UI.ProgressBarItem();
            this.chartToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.ChartToolsRibbonPageCategory();
            this.chartsDesignRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignRibbonPage();
            this.chartsDesignTypeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignTypeRibbonPageGroup();
            this.chartsDesignDataRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignDataRibbonPageGroup();
            this.chartsDesignLayoutsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignLayoutsRibbonPageGroup();
            this.chartsDesignStylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignStylesRibbonPageGroup();
            this.chartsDesignLocationRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsDesignLocationRibbonPageGroup();
            this.chartsLayoutRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutRibbonPage();
            this.chartsLayoutAxesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutAxesRibbonPageGroup();
            this.chartsLayoutLabelsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutLabelsRibbonPageGroup();
            this.chartsLayoutAnalysisRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsLayoutAnalysisRibbonPageGroup();
            this.chartsFormatRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ChartsFormatRibbonPage();
            this.chartsFormatArrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsFormatArrangeRibbonPageGroup();
            this.tableToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageCategory();
            this.tableToolsDesignRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.TableToolsDesignRibbonPage();
            this.tablePropertiesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TablePropertiesRibbonPageGroup();
            this.tableToolsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageGroup();
            this.tableStyleOptionsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TableStyleOptionsRibbonPageGroup();
            this.tableStylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TableStylesRibbonPageGroup();
            this.drawingToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.DrawingToolsRibbonPageCategory();
            this.drawingFormatRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.DrawingFormatRibbonPage();
            this.drawingFormatArrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.DrawingFormatArrangeRibbonPageGroup();
            this.pictureToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.PictureToolsRibbonPageCategory();
            this.pictureFormatRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PictureFormatRibbonPage();
            this.pictureFormatArrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PictureFormatArrangeRibbonPageGroup();
            this.pivotTableToolsRibbonPageCategory1 = new DevExpress.XtraSpreadsheet.UI.PivotTableToolsRibbonPageCategory();
            this.pivotTableAnalyzeRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeRibbonPage();
            this.pivotTableAnalyzePivotTableRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzePivotTableRibbonPageGroup();
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeActiveFieldRibbonPageGroup();
            this.pivotTableAnalyzeGroupRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeGroupRibbonPageGroup();
            this.pivotTableAnalyzeDataRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeDataRibbonPageGroup();
            this.pivotTableAnalyzeActionsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeActionsRibbonPageGroup();
            this.pivotTableAnalyzeCalculationsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeCalculationsRibbonPageGroup();
            this.pivotTableAnalyzeShowRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeShowRibbonPageGroup();
            this.pivotTableDesignRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PivotTableDesignRibbonPage();
            this.pivotTableDesignLayoutRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableDesignLayoutRibbonPageGroup();
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableDesignPivotTableStyleOptionsRibbonPageGroup();
            this.pivotTableDesignPivotTableStylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PivotTableDesignPivotTableStylesRibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup();
            this.infoRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.HomeRibbonPage();
            this.clipboardRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup();
            this.fontRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup();
            this.alignmentRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup();
            this.numberRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup();
            this.stylesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup();
            this.cellsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup();
            this.editingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup();
            this.insertRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.InsertRibbonPage();
            this.tablesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.TablesRibbonPageGroup();
            this.illustrationsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.IllustrationsRibbonPageGroup();
            this.chartsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChartsRibbonPageGroup();
            this.linksRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.LinksRibbonPageGroup();
            this.symbolsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.SymbolsRibbonPageGroup();
            this.pageLayoutRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.PageLayoutRibbonPage();
            this.pageSetupRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupRibbonPageGroup();
            this.pageSetupShowRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupShowRibbonPageGroup();
            this.pageSetupPrintRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.PageSetupPrintRibbonPageGroup();
            this.arrangeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ArrangeRibbonPageGroup();
            this.formulasRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.FormulasRibbonPage();
            this.functionLibraryRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FunctionLibraryRibbonPageGroup();
            this.formulaDefinedNamesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaDefinedNamesRibbonPageGroup();
            this.formulaAuditingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaAuditingRibbonPageGroup();
            this.formulaCalculationRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.FormulaCalculationRibbonPageGroup();
            this.dataRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.DataRibbonPage();
            this.sortAndFilterRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.SortAndFilterRibbonPageGroup();
            this.dataToolsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.DataToolsRibbonPageGroup();
            this.outlineRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.OutlineRibbonPageGroup();
            this.reviewRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ReviewRibbonPage();
            this.commentsRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CommentsRibbonPageGroup();
            this.changesRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ChangesRibbonPageGroup();
            this.viewRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.ViewRibbonPage();
            this.showRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ShowRibbonPageGroup();
            this.zoomRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.ZoomRibbonPageGroup();
            this.windowRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.WindowRibbonPageGroup();
            this.mailMergeRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.MailMergeRibbonPage();
            this.mailMergeDataRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeDataRibbonPageGroup();
            this.mailMergeModeRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeModeRibbonPageGroup();
            this.mailMergeExtendedRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeExtendedRibbonPageGroup();
            this.mailMergeGroupingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeGroupingRibbonPageGroup();
            this.mailMergeFilteringRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeFilteringRibbonPageGroup();
            this.mailMergeBindingRibbonPageGroup2 = new DevExpress.XtraSpreadsheet.UI.MailMergeBindingRibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.commandBarGalleryDropDown49 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown51 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown52 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown53 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown54 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown55 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown56 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown57 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown58 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown59 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown60 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown61 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown62 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown63 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown64 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown65 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown66 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown67 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown68 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown69 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown70 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown71 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown72 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown26 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown25 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown27 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown28 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown29 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown30 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown31 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown32 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown33 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown34 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown35 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown36 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown37 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown38 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown39 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown40 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown41 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown42 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown43 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown44 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown45 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown46 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown47 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown48 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown2 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown1 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown3 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown4 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown5 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown6 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown7 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown8 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown9 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown10 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown11 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown12 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown13 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown14 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown15 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown16 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown17 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown18 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown19 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown20 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown21 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown22 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown23 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.commandBarGalleryDropDown24 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(this.components);
            this.spreadsheetDockManager1 = new DevExpress.XtraSpreadsheet.SpreadsheetDockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.fieldListDockPanel1 = new DevExpress.XtraSpreadsheet.FieldListDockPanel();
            this.fieldListDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.mailMergeParametersDockPanel = new DevExpress.XtraSpreadsheet.MailMergeParametersDockPanel();
            this.mailMergeParametersDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.filteringDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.checkEdit0 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.mailMergeBindingRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.MailMergeBindingRibbonPageGroup();
            this.spreadsheetFormulaBar1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpreadsheetFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown94)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetDockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.fieldListDockPanel1.SuspendLayout();
            this.mailMergeParametersDockPanel.SuspendLayout();
            this.filteringDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit0.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // commandBarGalleryDropDown50
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown50.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup1.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup";
            spreadsheetCommandGalleryItem1.Caption = "Blue Data Bar (Gradient)";
            spreadsheetCommandGalleryItem1.CommandName = "ConditionalFormattingDataBarGradientBlue";
            spreadsheetCommandGalleryItem1.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem1.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            spreadsheetCommandGalleryItem2.Caption = "Green Data Bar (Gradient)";
            spreadsheetCommandGalleryItem2.CommandName = "ConditionalFormattingDataBarGradientGreen";
            spreadsheetCommandGalleryItem2.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem2.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            spreadsheetCommandGalleryItem3.Caption = "Red Data Bar (Gradient)";
            spreadsheetCommandGalleryItem3.CommandName = "ConditionalFormattingDataBarGradientRed";
            spreadsheetCommandGalleryItem3.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem3.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            spreadsheetCommandGalleryItem4.Caption = "Orange Data Bar (Gradient)";
            spreadsheetCommandGalleryItem4.CommandName = "ConditionalFormattingDataBarGradientOrange";
            spreadsheetCommandGalleryItem4.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem4.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            spreadsheetCommandGalleryItem5.Caption = "Light Blue Data Bar (Gradient)";
            spreadsheetCommandGalleryItem5.CommandName = "ConditionalFormattingDataBarGradientLightBlue";
            spreadsheetCommandGalleryItem5.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem5.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            spreadsheetCommandGalleryItem6.Caption = "Purple Data Bar (Gradient)";
            spreadsheetCommandGalleryItem6.CommandName = "ConditionalFormattingDataBarGradientPurple";
            spreadsheetCommandGalleryItem6.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem6.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            spreadsheetCommandGalleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem1,
            spreadsheetCommandGalleryItem2,
            spreadsheetCommandGalleryItem3,
            spreadsheetCommandGalleryItem4,
            spreadsheetCommandGalleryItem5,
            spreadsheetCommandGalleryItem6});
            spreadsheetCommandGalleryItemGroup2.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup";
            spreadsheetCommandGalleryItem7.Caption = "Blue Data Bar (Solid)";
            spreadsheetCommandGalleryItem7.CommandName = "ConditionalFormattingDataBarSolidBlue";
            spreadsheetCommandGalleryItem7.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem7.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            spreadsheetCommandGalleryItem8.Caption = "Green Data Bar (Solid)";
            spreadsheetCommandGalleryItem8.CommandName = "ConditionalFormattingDataBarSolidGreen";
            spreadsheetCommandGalleryItem8.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem8.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            spreadsheetCommandGalleryItem9.Caption = "Red Data Bar (Solid)";
            spreadsheetCommandGalleryItem9.CommandName = "ConditionalFormattingDataBarSolidRed";
            spreadsheetCommandGalleryItem9.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem9.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            spreadsheetCommandGalleryItem10.Caption = "Orange Data Bar (Solid)";
            spreadsheetCommandGalleryItem10.CommandName = "ConditionalFormattingDataBarSolidOrange";
            spreadsheetCommandGalleryItem10.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem10.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image9")));
            spreadsheetCommandGalleryItem11.Caption = "Light Blue Data Bar (Solid)";
            spreadsheetCommandGalleryItem11.CommandName = "ConditionalFormattingDataBarSolidLightBlue";
            spreadsheetCommandGalleryItem11.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem11.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image10")));
            spreadsheetCommandGalleryItem12.Caption = "Purple Data Bar (Solid)";
            spreadsheetCommandGalleryItem12.CommandName = "ConditionalFormattingDataBarSolidPurple";
            spreadsheetCommandGalleryItem12.Description = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem12.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" +
    "lue in the cell. A longer bar represents a higher value.";
            spreadsheetCommandGalleryItem12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image11")));
            spreadsheetCommandGalleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem7,
            spreadsheetCommandGalleryItem8,
            spreadsheetCommandGalleryItem9,
            spreadsheetCommandGalleryItem10,
            spreadsheetCommandGalleryItem11,
            spreadsheetCommandGalleryItem12});
            this.commandBarGalleryDropDown50.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup1,
            spreadsheetCommandGalleryItemGroup2});
            this.commandBarGalleryDropDown50.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown50.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown50.Manager = null;
            this.commandBarGalleryDropDown50.Name = "commandBarGalleryDropDown50";
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 184);
            this.spreadsheetControl1.MenuManager = this.ribbonControl1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(862, 221);
            this.spreadsheetControl1.TabIndex = 4;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.spreadsheetCommandBarButtonItem1,
            this.spreadsheetCommandBarButtonItem2,
            this.spreadsheetCommandBarButtonItem3,
            this.spreadsheetCommandBarButtonItem4,
            this.spreadsheetCommandBarButtonItem5,
            this.spreadsheetCommandBarButtonItem6,
            this.spreadsheetCommandBarButtonItem7,
            this.spreadsheetCommandBarButtonItem8,
            this.spreadsheetCommandBarButtonItem9,
            this.spreadsheetCommandBarButtonItem10,
            this.spreadsheetCommandBarButtonItem11,
            this.spreadsheetCommandBarButtonItem12,
            this.spreadsheetCommandBarButtonItem13,
            this.spreadsheetCommandBarButtonItem14,
            this.spreadsheetCommandBarButtonItem15,
            this.barButtonGroup1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.spreadsheetCommandBarButtonItem16,
            this.spreadsheetCommandBarButtonItem17,
            this.barButtonGroup2,
            this.spreadsheetCommandBarCheckItem1,
            this.spreadsheetCommandBarCheckItem2,
            this.spreadsheetCommandBarCheckItem3,
            this.spreadsheetCommandBarCheckItem4,
            this.barButtonGroup3,
            this.spreadsheetCommandBarSubItem1,
            this.spreadsheetCommandBarButtonItem18,
            this.spreadsheetCommandBarButtonItem19,
            this.spreadsheetCommandBarButtonItem20,
            this.spreadsheetCommandBarButtonItem21,
            this.spreadsheetCommandBarButtonItem22,
            this.spreadsheetCommandBarButtonItem23,
            this.spreadsheetCommandBarButtonItem24,
            this.spreadsheetCommandBarButtonItem25,
            this.spreadsheetCommandBarButtonItem26,
            this.spreadsheetCommandBarButtonItem27,
            this.spreadsheetCommandBarButtonItem28,
            this.spreadsheetCommandBarButtonItem29,
            this.spreadsheetCommandBarButtonItem30,
            this.changeBorderLineColorItem1,
            this.changeBorderLineStyleItem1,
            this.barButtonGroup4,
            this.changeCellFillColorItem1,
            this.changeFontColorItem1,
            this.barButtonGroup5,
            this.spreadsheetCommandBarCheckItem5,
            this.spreadsheetCommandBarCheckItem6,
            this.spreadsheetCommandBarCheckItem7,
            this.barButtonGroup6,
            this.spreadsheetCommandBarCheckItem8,
            this.spreadsheetCommandBarCheckItem9,
            this.spreadsheetCommandBarCheckItem10,
            this.barButtonGroup7,
            this.spreadsheetCommandBarButtonItem31,
            this.spreadsheetCommandBarButtonItem32,
            this.spreadsheetCommandBarCheckItem11,
            this.spreadsheetCommandBarSubItem2,
            this.spreadsheetCommandBarCheckItem12,
            this.spreadsheetCommandBarButtonItem33,
            this.spreadsheetCommandBarButtonItem34,
            this.spreadsheetCommandBarButtonItem35,
            this.barButtonGroup8,
            this.changeNumberFormatItem1,
            this.barButtonGroup9,
            this.spreadsheetCommandBarSubItem3,
            this.spreadsheetCommandBarButtonItem36,
            this.spreadsheetCommandBarButtonItem37,
            this.spreadsheetCommandBarButtonItem38,
            this.spreadsheetCommandBarButtonItem39,
            this.spreadsheetCommandBarButtonItem40,
            this.spreadsheetCommandBarButtonItem41,
            this.spreadsheetCommandBarButtonItem42,
            this.spreadsheetCommandBarButtonItem43,
            this.barButtonGroup10,
            this.spreadsheetCommandBarButtonItem44,
            this.spreadsheetCommandBarButtonItem45,
            this.spreadsheetCommandBarSubItem7,
            this.spreadsheetCommandBarButtonItem46,
            this.spreadsheetCommandBarButtonItem47,
            this.spreadsheetCommandBarButtonItem48,
            this.spreadsheetCommandBarButtonItem49,
            this.spreadsheetCommandBarButtonItem50,
            this.spreadsheetCommandBarButtonItem51,
            this.spreadsheetCommandBarButtonItem52,
            this.spreadsheetCommandBarSubItem4,
            this.spreadsheetCommandBarButtonItem53,
            this.spreadsheetCommandBarButtonItem54,
            this.spreadsheetCommandBarButtonItem55,
            this.spreadsheetCommandBarButtonItem56,
            this.spreadsheetCommandBarButtonItem57,
            this.spreadsheetCommandBarButtonItem58,
            this.spreadsheetCommandBarSubItem5,
            this.spreadsheetCommandBarButtonGalleryDropDownItem1,
            this.spreadsheetCommandBarButtonGalleryDropDownItem2,
            this.spreadsheetCommandBarButtonGalleryDropDownItem3,
            this.spreadsheetCommandBarButtonItem59,
            this.spreadsheetCommandBarButtonItem60,
            this.spreadsheetCommandBarButtonItem61,
            this.spreadsheetCommandBarSubItem6,
            this.spreadsheetCommandBarButtonItem62,
            this.galleryFormatAsTableItem1,
            this.galleryChangeStyleItem1,
            this.spreadsheetCommandBarSubItem8,
            this.spreadsheetCommandBarButtonItem63,
            this.spreadsheetCommandBarButtonItem64,
            this.spreadsheetCommandBarButtonItem65,
            this.spreadsheetCommandBarButtonItem66,
            this.spreadsheetCommandBarButtonItem67,
            this.spreadsheetCommandBarButtonItem68,
            this.spreadsheetCommandBarButtonItem69,
            this.spreadsheetCommandBarButtonItem70,
            this.spreadsheetCommandBarSubItem9,
            this.spreadsheetCommandBarButtonItem71,
            this.spreadsheetCommandBarButtonItem72,
            this.spreadsheetCommandBarButtonItem73,
            this.spreadsheetCommandBarButtonItem74,
            this.spreadsheetCommandBarButtonItem75,
            this.spreadsheetCommandBarButtonItem76,
            this.spreadsheetCommandBarSubItem11,
            this.spreadsheetCommandBarButtonItem77,
            this.spreadsheetCommandBarButtonItem78,
            this.spreadsheetCommandBarButtonItem79,
            this.spreadsheetCommandBarButtonItem80,
            this.spreadsheetCommandBarButtonItem81,
            this.spreadsheetCommandBarButtonItem82,
            this.spreadsheetCommandBarButtonItem83,
            this.spreadsheetCommandBarButtonItem84,
            this.spreadsheetCommandBarButtonItem85,
            this.spreadsheetCommandBarButtonItem86,
            this.spreadsheetCommandBarButtonItem87,
            this.spreadsheetCommandBarSubItem10,
            this.spreadsheetCommandBarButtonItem88,
            this.spreadsheetCommandBarButtonItem89,
            this.changeSheetTabColorItem1,
            this.spreadsheetCommandBarButtonItem90,
            this.spreadsheetCommandBarCheckItem13,
            this.spreadsheetCommandBarButtonItem91,
            this.spreadsheetCommandBarSubItem12,
            this.spreadsheetCommandBarButtonItem92,
            this.spreadsheetCommandBarButtonItem93,
            this.spreadsheetCommandBarButtonItem94,
            this.spreadsheetCommandBarButtonItem95,
            this.spreadsheetCommandBarButtonItem96,
            this.spreadsheetCommandBarSubItem13,
            this.spreadsheetCommandBarButtonItem97,
            this.spreadsheetCommandBarButtonItem98,
            this.spreadsheetCommandBarButtonItem99,
            this.spreadsheetCommandBarButtonItem100,
            this.spreadsheetCommandBarSubItem14,
            this.spreadsheetCommandBarButtonItem101,
            this.spreadsheetCommandBarButtonItem102,
            this.spreadsheetCommandBarButtonItem103,
            this.spreadsheetCommandBarButtonItem104,
            this.spreadsheetCommandBarButtonItem105,
            this.spreadsheetCommandBarButtonItem106,
            this.spreadsheetCommandBarSubItem15,
            this.spreadsheetCommandBarButtonItem107,
            this.spreadsheetCommandBarButtonItem108,
            this.spreadsheetCommandBarCheckItem14,
            this.spreadsheetCommandBarButtonItem109,
            this.spreadsheetCommandBarButtonItem110,
            this.spreadsheetCommandBarSubItem16,
            this.spreadsheetCommandBarButtonItem111,
            this.spreadsheetCommandBarButtonItem112,
            this.spreadsheetCommandBarButtonItem113,
            this.spreadsheetCommandBarButtonItem114,
            this.spreadsheetCommandBarButtonItem115,
            this.spreadsheetCommandBarButtonItem116,
            this.spreadsheetCommandBarButtonItem117,
            this.spreadsheetCommandBarButtonItem118,
            this.spreadsheetCommandBarButtonItem119,
            this.spreadsheetCommandBarButtonItem120,
            this.spreadsheetCommandBarButtonGalleryDropDownItem4,
            this.spreadsheetCommandBarButtonGalleryDropDownItem5,
            this.spreadsheetCommandBarButtonGalleryDropDownItem6,
            this.spreadsheetCommandBarButtonGalleryDropDownItem7,
            this.spreadsheetCommandBarButtonGalleryDropDownItem8,
            this.spreadsheetCommandBarButtonGalleryDropDownItem9,
            this.spreadsheetCommandBarButtonGalleryDropDownItem10,
            this.spreadsheetCommandBarButtonGalleryDropDownItem11,
            this.spreadsheetCommandBarButtonGalleryDropDownItem12,
            this.spreadsheetCommandBarButtonItem121,
            this.spreadsheetCommandBarButtonItem122,
            this.spreadsheetCommandBarSubItem17,
            this.spreadsheetCommandBarCheckItem15,
            this.spreadsheetCommandBarCheckItem16,
            this.spreadsheetCommandBarCheckItem17,
            this.spreadsheetCommandBarButtonItem123,
            this.spreadsheetCommandBarSubItem18,
            this.spreadsheetCommandBarCheckItem18,
            this.spreadsheetCommandBarCheckItem19,
            this.pageSetupPaperKindItem1,
            this.spreadsheetCommandBarSubItem19,
            this.spreadsheetCommandBarButtonItem124,
            this.spreadsheetCommandBarButtonItem125,
            this.spreadsheetCommandBarButtonItem126,
            this.spreadsheetCommandBarButtonItem127,
            this.spreadsheetCommandBarCheckItem20,
            this.spreadsheetCommandBarCheckItem21,
            this.spreadsheetCommandBarCheckItem22,
            this.spreadsheetCommandBarCheckItem23,
            this.spreadsheetCommandBarSubItem20,
            this.spreadsheetCommandBarButtonItem128,
            this.spreadsheetCommandBarButtonItem129,
            this.spreadsheetCommandBarSubItem21,
            this.spreadsheetCommandBarButtonItem130,
            this.spreadsheetCommandBarButtonItem131,
            this.spreadsheetCommandBarSubItem22,
            this.functionsFinancialItem1,
            this.functionsLogicalItem1,
            this.functionsTextItem1,
            this.functionsDateAndTimeItem1,
            this.functionsLookupAndReferenceItem1,
            this.functionsMathAndTrigonometryItem1,
            this.spreadsheetCommandBarSubItem23,
            this.functionsStatisticalItem1,
            this.functionsEngineeringItem1,
            this.functionsInformationItem1,
            this.functionsCompatibilityItem1,
            this.functionsWebItem1,
            this.spreadsheetCommandBarButtonItem132,
            this.spreadsheetCommandBarButtonItem133,
            this.definedNameListItem1,
            this.spreadsheetCommandBarButtonItem134,
            this.spreadsheetCommandBarCheckItem24,
            this.spreadsheetCommandBarSubItem24,
            this.spreadsheetCommandBarCheckItem25,
            this.spreadsheetCommandBarCheckItem26,
            this.spreadsheetCommandBarButtonItem135,
            this.spreadsheetCommandBarButtonItem136,
            this.spreadsheetCommandBarSubItem25,
            this.spreadsheetCommandBarButtonItem137,
            this.spreadsheetCommandBarButtonItem138,
            this.spreadsheetCommandBarButtonItem139,
            this.spreadsheetCommandBarSubItem26,
            this.spreadsheetCommandBarButtonItem140,
            this.spreadsheetCommandBarButtonItem141,
            this.spreadsheetCommandBarSubItem27,
            this.spreadsheetCommandBarButtonItem142,
            this.spreadsheetCommandBarButtonItem143,
            this.spreadsheetCommandBarButtonItem144,
            this.spreadsheetCommandBarButtonItem145,
            this.spreadsheetCommandBarButtonItem146,
            this.spreadsheetCommandBarButtonItem147,
            this.spreadsheetCommandBarButtonItem148,
            this.spreadsheetCommandBarButtonItem149,
            this.spreadsheetCommandBarButtonItem150,
            this.spreadsheetCommandBarButtonItem151,
            this.spreadsheetCommandBarButtonItem152,
            this.spreadsheetCommandBarButtonItem153,
            this.spreadsheetCommandBarButtonItem154,
            this.spreadsheetCommandBarButtonItem155,
            this.spreadsheetCommandBarButtonItem156,
            this.spreadsheetCommandBarButtonItem157,
            this.spreadsheetCommandBarButtonItem158,
            this.spreadsheetCommandBarSubItem28,
            this.spreadsheetCommandBarButtonItem159,
            this.spreadsheetCommandBarButtonItem160,
            this.spreadsheetCommandBarButtonItem161,
            this.spreadsheetCommandBarButtonItem162,
            this.spreadsheetCommandBarButtonItem163,
            this.spreadsheetCommandBarButtonItem164,
            this.spreadsheetCommandBarButtonItem165,
            this.galleryChartLayoutItem1,
            this.galleryChartStyleItem1,
            this.spreadsheetCommandBarButtonItem166,
            this.spreadsheetCommandBarSubItem29,
            this.spreadsheetCommandBarButtonGalleryDropDownItem13,
            this.spreadsheetCommandBarButtonGalleryDropDownItem14,
            this.spreadsheetCommandBarSubItem30,
            this.spreadsheetCommandBarButtonGalleryDropDownItem15,
            this.spreadsheetCommandBarButtonGalleryDropDownItem16,
            this.spreadsheetCommandBarButtonGalleryDropDownItem17,
            this.spreadsheetCommandBarSubItem31,
            this.spreadsheetCommandBarButtonGalleryDropDownItem18,
            this.spreadsheetCommandBarButtonGalleryDropDownItem19,
            this.spreadsheetCommandBarButtonGalleryDropDownItem20,
            this.spreadsheetCommandBarButtonGalleryDropDownItem21,
            this.spreadsheetCommandBarButtonGalleryDropDownItem22,
            this.spreadsheetCommandBarButtonGalleryDropDownItem23,
            this.spreadsheetCommandBarButtonGalleryDropDownItem24,
            this.renameTableItemCaption1,
            this.renameTableItem1,
            this.spreadsheetCommandBarCheckItem27,
            this.spreadsheetCommandBarCheckItem28,
            this.spreadsheetCommandBarCheckItem29,
            this.spreadsheetCommandBarCheckItem30,
            this.spreadsheetCommandBarCheckItem31,
            this.spreadsheetCommandBarCheckItem32,
            this.spreadsheetCommandBarCheckItem33,
            this.galleryTableStylesItem1,
            this.spreadsheetCommandBarButtonItem167,
            this.spreadsheetCommandBarButtonItem168,
            this.spreadsheetCommandBarButtonItem169,
            this.spreadsheetCommandBarButtonItem170,
            this.spreadsheetCommandBarButtonItem171,
            this.spreadsheetCommandBarButtonItem172,
            this.spreadsheetCommandBarButtonItem173,
            this.spreadsheetCommandBarSubItem32,
            this.spreadsheetCommandBarButtonItem174,
            this.spreadsheetCommandBarButtonItem175,
            this.spreadsheetCommandBarButtonItem176,
            this.spreadsheetCommandBarSubItem33,
            this.spreadsheetCommandBarButtonItem177,
            this.spreadsheetCommandBarButtonItem178,
            this.spreadsheetCommandBarSubItem34,
            this.spreadsheetCommandBarButtonItem179,
            this.spreadsheetCommandBarButtonItem180,
            this.spreadsheetCommandBarButtonItem181,
            this.spreadsheetCommandBarButtonItem182,
            this.spreadsheetCommandBarSubItem35,
            this.spreadsheetCommandBarButtonItem183,
            this.spreadsheetCommandBarButtonItem184,
            this.spreadsheetCommandBarButtonItem185,
            this.spreadsheetCommandBarButtonItem186,
            this.spreadsheetCommandBarCheckItem34,
            this.spreadsheetCommandBarCheckItem35,
            this.spreadsheetCommandBarCheckItem36,
            this.spreadsheetCommandBarSubItem36,
            this.spreadsheetCommandBarButtonItem187,
            this.spreadsheetCommandBarButtonItem188,
            this.spreadsheetCommandBarButtonItem189,
            this.spreadsheetCommandBarSubItem37,
            this.spreadsheetCommandBarButtonItem190,
            this.spreadsheetCommandBarButtonItem191,
            this.spreadsheetCommandBarButtonItem192,
            this.spreadsheetCommandBarButtonItem193,
            this.spreadsheetCommandBarSubItem38,
            this.spreadsheetCommandBarButtonItem194,
            this.spreadsheetCommandBarButtonItem195,
            this.spreadsheetCommandBarButtonItem196,
            this.spreadsheetCommandBarButtonItem197,
            this.spreadsheetCommandBarButtonItem198,
            this.spreadsheetCommandBarSubItem39,
            this.spreadsheetCommandBarButtonItem199,
            this.spreadsheetCommandBarButtonItem200,
            this.spreadsheetCommandBarCheckItem37,
            this.spreadsheetCommandBarCheckItem38,
            this.spreadsheetCommandBarCheckItem39,
            this.spreadsheetCommandBarCheckItem40,
            this.galleryPivotStylesItem1,
            this.spreadsheetCommandBarButtonItem201,
            this.spreadsheetCommandBarSubItem40,
            this.spreadsheetCommandBarButtonItem202,
            this.spreadsheetCommandBarButtonItem203,
            this.spreadsheetCommandBarSubItem41,
            this.spreadsheetCommandBarButtonItem204,
            this.spreadsheetCommandBarButtonItem205,
            this.spreadsheetCommandBarButtonItem206,
            this.spreadsheetCommandBarCheckItem41,
            this.spreadsheetCommandBarCheckItem42,
            this.spreadsheetCommandBarCheckItem43,
            this.spreadsheetCommandBarSubItem42,
            this.spreadsheetCommandBarCheckItem44,
            this.spreadsheetCommandBarCheckItem45,
            this.spreadsheetCommandBarButtonItem207,
            this.spreadsheetCommandBarButtonItem208,
            this.spreadsheetCommandBarButtonItem209,
            this.spreadsheetCommandBarSubItem43,
            this.spreadsheetCommandBarButtonItem210,
            this.spreadsheetCommandBarButtonItem211,
            this.spreadsheetCommandBarButtonItem212,
            this.spreadsheetCommandBarButtonItem213,
            this.spreadsheetCommandBarButtonItem214,
            this.spreadsheetCommandBarButtonItem215,
            this.spreadsheetCommandBarButtonItem216,
            this.spreadsheetCommandBarButtonItem217,
            this.spreadsheetCommandBarCheckItem46,
            this.spreadsheetCommandBarButtonItem218,
            this.endModeInfoStaticItem1,
            this.averageInfoStaticItem1,
            this.countInfoStaticItem1,
            this.numericalCountInfoStaticItem1,
            this.minInfoStaticItem1,
            this.maxInfoStaticItem1,
            this.sumInfoStaticItem1,
            this.zoomEditItem1,
            this.showZoomButtonItem1,
            this.progressBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 381;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.chartToolsRibbonPageCategory1,
            this.tableToolsRibbonPageCategory1,
            this.drawingToolsRibbonPageCategory1,
            this.pictureToolsRibbonPageCategory1,
            this.pivotTableToolsRibbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.homeRibbonPage1,
            this.insertRibbonPage1,
            this.pageLayoutRibbonPage1,
            this.formulasRibbonPage1,
            this.dataRibbonPage1,
            this.reviewRibbonPage1,
            this.viewRibbonPage1,
            this.mailMergeRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemFontEdit1,
            this.repositoryItemSpreadsheetFontSizeEdit1,
            this.repositoryItemPopupGalleryEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemZoomTrackBar1});
            this.ribbonControl1.Size = new System.Drawing.Size(1062, 150);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // spreadsheetCommandBarButtonItem1
            // 
            this.spreadsheetCommandBarButtonItem1.CommandName = "FileNew";
            this.spreadsheetCommandBarButtonItem1.Id = 1;
            this.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1";
            // 
            // spreadsheetCommandBarButtonItem2
            // 
            this.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen";
            this.spreadsheetCommandBarButtonItem2.Id = 2;
            this.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2";
            // 
            // spreadsheetCommandBarButtonItem3
            // 
            this.spreadsheetCommandBarButtonItem3.CommandName = "FileSave";
            this.spreadsheetCommandBarButtonItem3.Id = 3;
            this.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3";
            // 
            // spreadsheetCommandBarButtonItem4
            // 
            this.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs";
            this.spreadsheetCommandBarButtonItem4.Id = 4;
            this.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4";
            // 
            // spreadsheetCommandBarButtonItem5
            // 
            this.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint";
            this.spreadsheetCommandBarButtonItem5.Id = 5;
            this.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5";
            // 
            // spreadsheetCommandBarButtonItem6
            // 
            this.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint";
            this.spreadsheetCommandBarButtonItem6.Id = 6;
            this.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6";
            // 
            // spreadsheetCommandBarButtonItem7
            // 
            this.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview";
            this.spreadsheetCommandBarButtonItem7.Id = 7;
            this.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7";
            // 
            // spreadsheetCommandBarButtonItem8
            // 
            this.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo";
            this.spreadsheetCommandBarButtonItem8.Id = 8;
            this.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8";
            // 
            // spreadsheetCommandBarButtonItem9
            // 
            this.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo";
            this.spreadsheetCommandBarButtonItem9.Id = 9;
            this.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9";
            // 
            // spreadsheetCommandBarButtonItem10
            // 
            this.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt";
            this.spreadsheetCommandBarButtonItem10.Id = 10;
            this.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10";
            // 
            // spreadsheetCommandBarButtonItem11
            // 
            this.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties";
            this.spreadsheetCommandBarButtonItem11.Id = 11;
            this.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11";
            // 
            // spreadsheetCommandBarButtonItem12
            // 
            this.spreadsheetCommandBarButtonItem12.CommandName = "PasteSelection";
            this.spreadsheetCommandBarButtonItem12.Id = 22;
            this.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12";
            this.spreadsheetCommandBarButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem13
            // 
            this.spreadsheetCommandBarButtonItem13.CommandName = "CutSelection";
            this.spreadsheetCommandBarButtonItem13.Id = 23;
            this.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13";
            this.spreadsheetCommandBarButtonItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem14
            // 
            this.spreadsheetCommandBarButtonItem14.CommandName = "CopySelection";
            this.spreadsheetCommandBarButtonItem14.Id = 24;
            this.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14";
            this.spreadsheetCommandBarButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem15
            // 
            this.spreadsheetCommandBarButtonItem15.CommandName = "ShowPasteSpecialForm";
            this.spreadsheetCommandBarButtonItem15.Id = 25;
            this.spreadsheetCommandBarButtonItem15.Name = "spreadsheetCommandBarButtonItem15";
            this.spreadsheetCommandBarButtonItem15.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Id = 12;
            this.barButtonGroup1.ItemLinks.Add(this.changeFontNameItem1);
            this.barButtonGroup1.ItemLinks.Add(this.changeFontSizeItem1);
            this.barButtonGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem16);
            this.barButtonGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem17);
            this.barButtonGroup1.Name = "barButtonGroup1";
            this.barButtonGroup1.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
            // 
            // changeFontNameItem1
            // 
            this.changeFontNameItem1.Edit = this.repositoryItemFontEdit1;
            this.changeFontNameItem1.Id = 26;
            this.changeFontNameItem1.Name = "changeFontNameItem1";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // changeFontSizeItem1
            // 
            this.changeFontSizeItem1.Edit = this.repositoryItemSpreadsheetFontSizeEdit1;
            this.changeFontSizeItem1.Id = 27;
            this.changeFontSizeItem1.Name = "changeFontSizeItem1";
            // 
            // repositoryItemSpreadsheetFontSizeEdit1
            // 
            this.repositoryItemSpreadsheetFontSizeEdit1.AutoHeight = false;
            this.repositoryItemSpreadsheetFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpreadsheetFontSizeEdit1.Control = this.spreadsheetControl1;
            this.repositoryItemSpreadsheetFontSizeEdit1.Name = "repositoryItemSpreadsheetFontSizeEdit1";
            // 
            // spreadsheetCommandBarButtonItem16
            // 
            this.spreadsheetCommandBarButtonItem16.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
            this.spreadsheetCommandBarButtonItem16.CommandName = "FormatIncreaseFontSize";
            this.spreadsheetCommandBarButtonItem16.Id = 28;
            this.spreadsheetCommandBarButtonItem16.Name = "spreadsheetCommandBarButtonItem16";
            this.spreadsheetCommandBarButtonItem16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem17
            // 
            this.spreadsheetCommandBarButtonItem17.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}";
            this.spreadsheetCommandBarButtonItem17.CommandName = "FormatDecreaseFontSize";
            this.spreadsheetCommandBarButtonItem17.Id = 29;
            this.spreadsheetCommandBarButtonItem17.Name = "spreadsheetCommandBarButtonItem17";
            this.spreadsheetCommandBarButtonItem17.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Id = 13;
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem1);
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem2);
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem3);
            this.barButtonGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem4);
            this.barButtonGroup2.Name = "barButtonGroup2";
            this.barButtonGroup2.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            // 
            // spreadsheetCommandBarCheckItem1
            // 
            this.spreadsheetCommandBarCheckItem1.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem1.CommandName = "FormatFontBold";
            this.spreadsheetCommandBarCheckItem1.Id = 30;
            this.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1";
            this.spreadsheetCommandBarCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem2
            // 
            this.spreadsheetCommandBarCheckItem2.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem2.CommandName = "FormatFontItalic";
            this.spreadsheetCommandBarCheckItem2.Id = 31;
            this.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2";
            this.spreadsheetCommandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem3
            // 
            this.spreadsheetCommandBarCheckItem3.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem3.CommandName = "FormatFontUnderline";
            this.spreadsheetCommandBarCheckItem3.Id = 32;
            this.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3";
            this.spreadsheetCommandBarCheckItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem4
            // 
            this.spreadsheetCommandBarCheckItem4.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}";
            this.spreadsheetCommandBarCheckItem4.CommandName = "FormatFontStrikeout";
            this.spreadsheetCommandBarCheckItem4.Id = 33;
            this.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4";
            this.spreadsheetCommandBarCheckItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup3
            // 
            this.barButtonGroup3.Id = 14;
            this.barButtonGroup3.ItemLinks.Add(this.spreadsheetCommandBarSubItem1);
            this.barButtonGroup3.Name = "barButtonGroup3";
            this.barButtonGroup3.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}";
            // 
            // spreadsheetCommandBarSubItem1
            // 
            this.spreadsheetCommandBarSubItem1.ButtonGroupTag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}";
            this.spreadsheetCommandBarSubItem1.CommandName = "FormatBordersCommandGroup";
            this.spreadsheetCommandBarSubItem1.Id = 34;
            this.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem19),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem20),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem21),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem22),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem23),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem24),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem25),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem26),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem27),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem28),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem29),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem30),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeBorderLineColorItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeBorderLineStyleItem1)});
            this.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1";
            this.spreadsheetCommandBarSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem18
            // 
            this.spreadsheetCommandBarButtonItem18.CommandName = "FormatBottomBorder";
            this.spreadsheetCommandBarButtonItem18.Id = 35;
            this.spreadsheetCommandBarButtonItem18.Name = "spreadsheetCommandBarButtonItem18";
            // 
            // spreadsheetCommandBarButtonItem19
            // 
            this.spreadsheetCommandBarButtonItem19.CommandName = "FormatTopBorder";
            this.spreadsheetCommandBarButtonItem19.Id = 36;
            this.spreadsheetCommandBarButtonItem19.Name = "spreadsheetCommandBarButtonItem19";
            // 
            // spreadsheetCommandBarButtonItem20
            // 
            this.spreadsheetCommandBarButtonItem20.CommandName = "FormatLeftBorder";
            this.spreadsheetCommandBarButtonItem20.Id = 37;
            this.spreadsheetCommandBarButtonItem20.Name = "spreadsheetCommandBarButtonItem20";
            // 
            // spreadsheetCommandBarButtonItem21
            // 
            this.spreadsheetCommandBarButtonItem21.CommandName = "FormatRightBorder";
            this.spreadsheetCommandBarButtonItem21.Id = 38;
            this.spreadsheetCommandBarButtonItem21.Name = "spreadsheetCommandBarButtonItem21";
            // 
            // spreadsheetCommandBarButtonItem22
            // 
            this.spreadsheetCommandBarButtonItem22.CommandName = "FormatNoBorders";
            this.spreadsheetCommandBarButtonItem22.Id = 39;
            this.spreadsheetCommandBarButtonItem22.Name = "spreadsheetCommandBarButtonItem22";
            // 
            // spreadsheetCommandBarButtonItem23
            // 
            this.spreadsheetCommandBarButtonItem23.CommandName = "FormatAllBorders";
            this.spreadsheetCommandBarButtonItem23.Id = 40;
            this.spreadsheetCommandBarButtonItem23.Name = "spreadsheetCommandBarButtonItem23";
            // 
            // spreadsheetCommandBarButtonItem24
            // 
            this.spreadsheetCommandBarButtonItem24.CommandName = "FormatOutsideBorders";
            this.spreadsheetCommandBarButtonItem24.Id = 41;
            this.spreadsheetCommandBarButtonItem24.Name = "spreadsheetCommandBarButtonItem24";
            // 
            // spreadsheetCommandBarButtonItem25
            // 
            this.spreadsheetCommandBarButtonItem25.CommandName = "FormatThickBorder";
            this.spreadsheetCommandBarButtonItem25.Id = 42;
            this.spreadsheetCommandBarButtonItem25.Name = "spreadsheetCommandBarButtonItem25";
            // 
            // spreadsheetCommandBarButtonItem26
            // 
            this.spreadsheetCommandBarButtonItem26.CommandName = "FormatBottomDoubleBorder";
            this.spreadsheetCommandBarButtonItem26.Id = 43;
            this.spreadsheetCommandBarButtonItem26.Name = "spreadsheetCommandBarButtonItem26";
            // 
            // spreadsheetCommandBarButtonItem27
            // 
            this.spreadsheetCommandBarButtonItem27.CommandName = "FormatBottomThickBorder";
            this.spreadsheetCommandBarButtonItem27.Id = 44;
            this.spreadsheetCommandBarButtonItem27.Name = "spreadsheetCommandBarButtonItem27";
            // 
            // spreadsheetCommandBarButtonItem28
            // 
            this.spreadsheetCommandBarButtonItem28.CommandName = "FormatTopAndBottomBorder";
            this.spreadsheetCommandBarButtonItem28.Id = 45;
            this.spreadsheetCommandBarButtonItem28.Name = "spreadsheetCommandBarButtonItem28";
            // 
            // spreadsheetCommandBarButtonItem29
            // 
            this.spreadsheetCommandBarButtonItem29.CommandName = "FormatTopAndThickBottomBorder";
            this.spreadsheetCommandBarButtonItem29.Id = 46;
            this.spreadsheetCommandBarButtonItem29.Name = "spreadsheetCommandBarButtonItem29";
            // 
            // spreadsheetCommandBarButtonItem30
            // 
            this.spreadsheetCommandBarButtonItem30.CommandName = "FormatTopAndDoubleBottomBorder";
            this.spreadsheetCommandBarButtonItem30.Id = 47;
            this.spreadsheetCommandBarButtonItem30.Name = "spreadsheetCommandBarButtonItem30";
            // 
            // changeBorderLineColorItem1
            // 
            this.changeBorderLineColorItem1.ActAsDropDown = true;
            this.changeBorderLineColorItem1.Id = 48;
            this.changeBorderLineColorItem1.Name = "changeBorderLineColorItem1";
            // 
            // changeBorderLineStyleItem1
            // 
            this.changeBorderLineStyleItem1.DropDownControl = this.commandBarGalleryDropDown73;
            this.changeBorderLineStyleItem1.Id = 49;
            this.changeBorderLineStyleItem1.Name = "changeBorderLineStyleItem1";
            // 
            // commandBarGalleryDropDown73
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown73.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown73.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown73.Gallery.DrawImageBackground = false;
            this.commandBarGalleryDropDown73.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.commandBarGalleryDropDown73.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown73.Gallery.ItemSize = new System.Drawing.Size(136, 26);
            this.commandBarGalleryDropDown73.Gallery.RowCount = 14;
            this.commandBarGalleryDropDown73.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown73.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown73.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown73.Name = "commandBarGalleryDropDown73";
            this.commandBarGalleryDropDown73.Ribbon = this.ribbonControl1;
            // 
            // barButtonGroup4
            // 
            this.barButtonGroup4.Id = 15;
            this.barButtonGroup4.ItemLinks.Add(this.changeCellFillColorItem1);
            this.barButtonGroup4.ItemLinks.Add(this.changeFontColorItem1);
            this.barButtonGroup4.Name = "barButtonGroup4";
            this.barButtonGroup4.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}";
            // 
            // changeCellFillColorItem1
            // 
            this.changeCellFillColorItem1.Id = 50;
            this.changeCellFillColorItem1.Name = "changeCellFillColorItem1";
            // 
            // changeFontColorItem1
            // 
            this.changeFontColorItem1.Id = 51;
            this.changeFontColorItem1.Name = "changeFontColorItem1";
            // 
            // barButtonGroup5
            // 
            this.barButtonGroup5.Id = 16;
            this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem5);
            this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem6);
            this.barButtonGroup5.ItemLinks.Add(this.spreadsheetCommandBarCheckItem7);
            this.barButtonGroup5.Name = "barButtonGroup5";
            this.barButtonGroup5.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            // 
            // spreadsheetCommandBarCheckItem5
            // 
            this.spreadsheetCommandBarCheckItem5.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            this.spreadsheetCommandBarCheckItem5.CommandName = "FormatAlignmentTop";
            this.spreadsheetCommandBarCheckItem5.Id = 52;
            this.spreadsheetCommandBarCheckItem5.Name = "spreadsheetCommandBarCheckItem5";
            this.spreadsheetCommandBarCheckItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem6
            // 
            this.spreadsheetCommandBarCheckItem6.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            this.spreadsheetCommandBarCheckItem6.CommandName = "FormatAlignmentMiddle";
            this.spreadsheetCommandBarCheckItem6.Id = 53;
            this.spreadsheetCommandBarCheckItem6.Name = "spreadsheetCommandBarCheckItem6";
            this.spreadsheetCommandBarCheckItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem7
            // 
            this.spreadsheetCommandBarCheckItem7.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}";
            this.spreadsheetCommandBarCheckItem7.CommandName = "FormatAlignmentBottom";
            this.spreadsheetCommandBarCheckItem7.Id = 54;
            this.spreadsheetCommandBarCheckItem7.Name = "spreadsheetCommandBarCheckItem7";
            this.spreadsheetCommandBarCheckItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup6
            // 
            this.barButtonGroup6.Id = 17;
            this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem8);
            this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem9);
            this.barButtonGroup6.ItemLinks.Add(this.spreadsheetCommandBarCheckItem10);
            this.barButtonGroup6.Name = "barButtonGroup6";
            this.barButtonGroup6.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            // 
            // spreadsheetCommandBarCheckItem8
            // 
            this.spreadsheetCommandBarCheckItem8.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            this.spreadsheetCommandBarCheckItem8.CommandName = "FormatAlignmentLeft";
            this.spreadsheetCommandBarCheckItem8.Id = 55;
            this.spreadsheetCommandBarCheckItem8.Name = "spreadsheetCommandBarCheckItem8";
            this.spreadsheetCommandBarCheckItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem9
            // 
            this.spreadsheetCommandBarCheckItem9.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            this.spreadsheetCommandBarCheckItem9.CommandName = "FormatAlignmentCenter";
            this.spreadsheetCommandBarCheckItem9.Id = 56;
            this.spreadsheetCommandBarCheckItem9.Name = "spreadsheetCommandBarCheckItem9";
            this.spreadsheetCommandBarCheckItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem10
            // 
            this.spreadsheetCommandBarCheckItem10.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}";
            this.spreadsheetCommandBarCheckItem10.CommandName = "FormatAlignmentRight";
            this.spreadsheetCommandBarCheckItem10.Id = 57;
            this.spreadsheetCommandBarCheckItem10.Name = "spreadsheetCommandBarCheckItem10";
            this.spreadsheetCommandBarCheckItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup7
            // 
            this.barButtonGroup7.Id = 18;
            this.barButtonGroup7.ItemLinks.Add(this.spreadsheetCommandBarButtonItem31);
            this.barButtonGroup7.ItemLinks.Add(this.spreadsheetCommandBarButtonItem32);
            this.barButtonGroup7.Name = "barButtonGroup7";
            this.barButtonGroup7.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
            // 
            // spreadsheetCommandBarButtonItem31
            // 
            this.spreadsheetCommandBarButtonItem31.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
            this.spreadsheetCommandBarButtonItem31.CommandName = "FormatDecreaseIndent";
            this.spreadsheetCommandBarButtonItem31.Id = 58;
            this.spreadsheetCommandBarButtonItem31.Name = "spreadsheetCommandBarButtonItem31";
            this.spreadsheetCommandBarButtonItem31.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem32
            // 
            this.spreadsheetCommandBarButtonItem32.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}";
            this.spreadsheetCommandBarButtonItem32.CommandName = "FormatIncreaseIndent";
            this.spreadsheetCommandBarButtonItem32.Id = 59;
            this.spreadsheetCommandBarButtonItem32.Name = "spreadsheetCommandBarButtonItem32";
            this.spreadsheetCommandBarButtonItem32.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarCheckItem11
            // 
            this.spreadsheetCommandBarCheckItem11.CommandName = "FormatWrapText";
            this.spreadsheetCommandBarCheckItem11.Id = 60;
            this.spreadsheetCommandBarCheckItem11.Name = "spreadsheetCommandBarCheckItem11";
            this.spreadsheetCommandBarCheckItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarSubItem2
            // 
            this.spreadsheetCommandBarSubItem2.CommandName = "EditingMergeCellsCommandGroup";
            this.spreadsheetCommandBarSubItem2.Id = 61;
            this.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem33),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem34),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem35)});
            this.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2";
            this.spreadsheetCommandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem12
            // 
            this.spreadsheetCommandBarCheckItem12.CommandName = "EditingMergeAndCenterCells";
            this.spreadsheetCommandBarCheckItem12.Id = 62;
            this.spreadsheetCommandBarCheckItem12.Name = "spreadsheetCommandBarCheckItem12";
            // 
            // spreadsheetCommandBarButtonItem33
            // 
            this.spreadsheetCommandBarButtonItem33.CommandName = "EditingMergeCellsAcross";
            this.spreadsheetCommandBarButtonItem33.Id = 63;
            this.spreadsheetCommandBarButtonItem33.Name = "spreadsheetCommandBarButtonItem33";
            // 
            // spreadsheetCommandBarButtonItem34
            // 
            this.spreadsheetCommandBarButtonItem34.CommandName = "EditingMergeCells";
            this.spreadsheetCommandBarButtonItem34.Id = 64;
            this.spreadsheetCommandBarButtonItem34.Name = "spreadsheetCommandBarButtonItem34";
            // 
            // spreadsheetCommandBarButtonItem35
            // 
            this.spreadsheetCommandBarButtonItem35.CommandName = "EditingUnmergeCells";
            this.spreadsheetCommandBarButtonItem35.Id = 65;
            this.spreadsheetCommandBarButtonItem35.Name = "spreadsheetCommandBarButtonItem35";
            // 
            // barButtonGroup8
            // 
            this.barButtonGroup8.Id = 19;
            this.barButtonGroup8.ItemLinks.Add(this.changeNumberFormatItem1);
            this.barButtonGroup8.Name = "barButtonGroup8";
            this.barButtonGroup8.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
            // 
            // changeNumberFormatItem1
            // 
            this.changeNumberFormatItem1.Edit = this.repositoryItemPopupGalleryEdit1;
            this.changeNumberFormatItem1.Id = 66;
            this.changeNumberFormatItem1.Name = "changeNumberFormatItem1";
            // 
            // repositoryItemPopupGalleryEdit1
            // 
            this.repositoryItemPopupGalleryEdit1.AutoHeight = false;
            this.repositoryItemPopupGalleryEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.repositoryItemPopupGalleryEdit1.Gallery.AllowFilter = false;
            this.repositoryItemPopupGalleryEdit1.Gallery.AutoFitColumns = false;
            this.repositoryItemPopupGalleryEdit1.Gallery.ColumnCount = 1;
            this.repositoryItemPopupGalleryEdit1.Gallery.FixedImageSize = false;
            spreadsheetCommandGalleryItem13.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem13.CaptionAsValue = true;
            spreadsheetCommandGalleryItem13.Checked = true;
            spreadsheetCommandGalleryItem13.CommandName = "FormatNumberGeneral";
            spreadsheetCommandGalleryItem13.IsEmptyHint = true;
            spreadsheetCommandGalleryItem14.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem14.CaptionAsValue = true;
            spreadsheetCommandGalleryItem14.CommandName = "FormatNumberDecimal";
            spreadsheetCommandGalleryItem14.IsEmptyHint = true;
            spreadsheetCommandGalleryItem15.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem15.CaptionAsValue = true;
            spreadsheetCommandGalleryItem15.CommandName = "FormatNumberAccountingCurrency";
            spreadsheetCommandGalleryItem15.IsEmptyHint = true;
            spreadsheetCommandGalleryItem16.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem16.CaptionAsValue = true;
            spreadsheetCommandGalleryItem16.CommandName = "FormatNumberAccountingRegular";
            spreadsheetCommandGalleryItem16.IsEmptyHint = true;
            spreadsheetCommandGalleryItem17.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem17.CaptionAsValue = true;
            spreadsheetCommandGalleryItem17.CommandName = "FormatNumberShortDate";
            spreadsheetCommandGalleryItem17.IsEmptyHint = true;
            spreadsheetCommandGalleryItem18.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem18.CaptionAsValue = true;
            spreadsheetCommandGalleryItem18.CommandName = "FormatNumberLongDate";
            spreadsheetCommandGalleryItem18.IsEmptyHint = true;
            spreadsheetCommandGalleryItem19.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem19.CaptionAsValue = true;
            spreadsheetCommandGalleryItem19.CommandName = "FormatNumberTime";
            spreadsheetCommandGalleryItem19.IsEmptyHint = true;
            spreadsheetCommandGalleryItem20.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem20.CaptionAsValue = true;
            spreadsheetCommandGalleryItem20.CommandName = "FormatNumberPercentage";
            spreadsheetCommandGalleryItem20.IsEmptyHint = true;
            spreadsheetCommandGalleryItem21.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem21.CaptionAsValue = true;
            spreadsheetCommandGalleryItem21.CommandName = "FormatNumberFraction";
            spreadsheetCommandGalleryItem21.IsEmptyHint = true;
            spreadsheetCommandGalleryItem22.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem22.CaptionAsValue = true;
            spreadsheetCommandGalleryItem22.CommandName = "FormatNumberScientific";
            spreadsheetCommandGalleryItem22.IsEmptyHint = true;
            spreadsheetCommandGalleryItem23.AlwaysUpdateDescription = true;
            spreadsheetCommandGalleryItem23.CaptionAsValue = true;
            spreadsheetCommandGalleryItem23.CommandName = "FormatNumberText";
            spreadsheetCommandGalleryItem23.IsEmptyHint = true;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem13,
            spreadsheetCommandGalleryItem14,
            spreadsheetCommandGalleryItem15,
            spreadsheetCommandGalleryItem16,
            spreadsheetCommandGalleryItem17,
            spreadsheetCommandGalleryItem18,
            spreadsheetCommandGalleryItem19,
            spreadsheetCommandGalleryItem20,
            spreadsheetCommandGalleryItem21,
            spreadsheetCommandGalleryItem22,
            spreadsheetCommandGalleryItem23});
            this.repositoryItemPopupGalleryEdit1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.repositoryItemPopupGalleryEdit1.Gallery.RowCount = 11;
            this.repositoryItemPopupGalleryEdit1.Gallery.ShowGroupCaption = false;
            this.repositoryItemPopupGalleryEdit1.Gallery.ShowItemText = true;
            this.repositoryItemPopupGalleryEdit1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide;
            this.repositoryItemPopupGalleryEdit1.Gallery.StretchItems = true;
            this.repositoryItemPopupGalleryEdit1.Name = "repositoryItemPopupGalleryEdit1";
            this.repositoryItemPopupGalleryEdit1.ShowButtons = false;
            this.repositoryItemPopupGalleryEdit1.ShowPopupCloseButton = false;
            this.repositoryItemPopupGalleryEdit1.ShowSizeGrip = false;
            // 
            // barButtonGroup9
            // 
            this.barButtonGroup9.Id = 20;
            this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarSubItem3);
            this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarButtonItem42);
            this.barButtonGroup9.ItemLinks.Add(this.spreadsheetCommandBarButtonItem43);
            this.barButtonGroup9.Name = "barButtonGroup9";
            this.barButtonGroup9.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            // 
            // spreadsheetCommandBarSubItem3
            // 
            this.spreadsheetCommandBarSubItem3.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            this.spreadsheetCommandBarSubItem3.CommandName = "FormatNumberAccountingCommandGroup";
            this.spreadsheetCommandBarSubItem3.Id = 67;
            this.spreadsheetCommandBarSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem36),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem37),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem38),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem39),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem40),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem41)});
            this.spreadsheetCommandBarSubItem3.Name = "spreadsheetCommandBarSubItem3";
            this.spreadsheetCommandBarSubItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem36
            // 
            this.spreadsheetCommandBarButtonItem36.CommandName = "FormatNumberAccountingDefault";
            this.spreadsheetCommandBarButtonItem36.Id = 68;
            this.spreadsheetCommandBarButtonItem36.Name = "spreadsheetCommandBarButtonItem36";
            // 
            // spreadsheetCommandBarButtonItem37
            // 
            this.spreadsheetCommandBarButtonItem37.CommandName = "FormatNumberAccountingUS";
            this.spreadsheetCommandBarButtonItem37.Id = 69;
            this.spreadsheetCommandBarButtonItem37.Name = "spreadsheetCommandBarButtonItem37";
            // 
            // spreadsheetCommandBarButtonItem38
            // 
            this.spreadsheetCommandBarButtonItem38.CommandName = "FormatNumberAccountingUK";
            this.spreadsheetCommandBarButtonItem38.Id = 70;
            this.spreadsheetCommandBarButtonItem38.Name = "spreadsheetCommandBarButtonItem38";
            // 
            // spreadsheetCommandBarButtonItem39
            // 
            this.spreadsheetCommandBarButtonItem39.CommandName = "FormatNumberAccountingEuro";
            this.spreadsheetCommandBarButtonItem39.Id = 71;
            this.spreadsheetCommandBarButtonItem39.Name = "spreadsheetCommandBarButtonItem39";
            // 
            // spreadsheetCommandBarButtonItem40
            // 
            this.spreadsheetCommandBarButtonItem40.CommandName = "FormatNumberAccountingPRC";
            this.spreadsheetCommandBarButtonItem40.Id = 72;
            this.spreadsheetCommandBarButtonItem40.Name = "spreadsheetCommandBarButtonItem40";
            // 
            // spreadsheetCommandBarButtonItem41
            // 
            this.spreadsheetCommandBarButtonItem41.CommandName = "FormatNumberAccountingSwiss";
            this.spreadsheetCommandBarButtonItem41.Id = 73;
            this.spreadsheetCommandBarButtonItem41.Name = "spreadsheetCommandBarButtonItem41";
            // 
            // spreadsheetCommandBarButtonItem42
            // 
            this.spreadsheetCommandBarButtonItem42.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            this.spreadsheetCommandBarButtonItem42.CommandName = "FormatNumberPercent";
            this.spreadsheetCommandBarButtonItem42.Id = 74;
            this.spreadsheetCommandBarButtonItem42.Name = "spreadsheetCommandBarButtonItem42";
            this.spreadsheetCommandBarButtonItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem43
            // 
            this.spreadsheetCommandBarButtonItem43.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}";
            this.spreadsheetCommandBarButtonItem43.CommandName = "FormatNumberAccounting";
            this.spreadsheetCommandBarButtonItem43.Id = 75;
            this.spreadsheetCommandBarButtonItem43.Name = "spreadsheetCommandBarButtonItem43";
            this.spreadsheetCommandBarButtonItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup10
            // 
            this.barButtonGroup10.Id = 21;
            this.barButtonGroup10.ItemLinks.Add(this.spreadsheetCommandBarButtonItem44);
            this.barButtonGroup10.ItemLinks.Add(this.spreadsheetCommandBarButtonItem45);
            this.barButtonGroup10.Name = "barButtonGroup10";
            this.barButtonGroup10.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
            // 
            // spreadsheetCommandBarButtonItem44
            // 
            this.spreadsheetCommandBarButtonItem44.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
            this.spreadsheetCommandBarButtonItem44.CommandName = "FormatNumberIncreaseDecimal";
            this.spreadsheetCommandBarButtonItem44.Id = 76;
            this.spreadsheetCommandBarButtonItem44.Name = "spreadsheetCommandBarButtonItem44";
            this.spreadsheetCommandBarButtonItem44.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarButtonItem45
            // 
            this.spreadsheetCommandBarButtonItem45.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}";
            this.spreadsheetCommandBarButtonItem45.CommandName = "FormatNumberDecreaseDecimal";
            this.spreadsheetCommandBarButtonItem45.Id = 77;
            this.spreadsheetCommandBarButtonItem45.Name = "spreadsheetCommandBarButtonItem45";
            this.spreadsheetCommandBarButtonItem45.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // spreadsheetCommandBarSubItem7
            // 
            this.spreadsheetCommandBarSubItem7.CommandName = "ConditionalFormattingCommandGroup";
            this.spreadsheetCommandBarSubItem7.Id = 78;
            this.spreadsheetCommandBarSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem59),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem62)});
            this.spreadsheetCommandBarSubItem7.Name = "spreadsheetCommandBarSubItem7";
            // 
            // spreadsheetCommandBarSubItem4
            // 
            this.spreadsheetCommandBarSubItem4.CommandName = "ConditionalFormattingHighlightCellsRuleCommandGroup";
            this.spreadsheetCommandBarSubItem4.Id = 86;
            this.spreadsheetCommandBarSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem46),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem47),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem48),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem49),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem50),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem51),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem52)});
            this.spreadsheetCommandBarSubItem4.Name = "spreadsheetCommandBarSubItem4";
            // 
            // spreadsheetCommandBarButtonItem46
            // 
            this.spreadsheetCommandBarButtonItem46.CommandName = "ConditionalFormattingGreaterThanRuleCommand";
            this.spreadsheetCommandBarButtonItem46.Id = 79;
            this.spreadsheetCommandBarButtonItem46.Name = "spreadsheetCommandBarButtonItem46";
            this.spreadsheetCommandBarButtonItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem47
            // 
            this.spreadsheetCommandBarButtonItem47.CommandName = "ConditionalFormattingLessThanRuleCommand";
            this.spreadsheetCommandBarButtonItem47.Id = 80;
            this.spreadsheetCommandBarButtonItem47.Name = "spreadsheetCommandBarButtonItem47";
            this.spreadsheetCommandBarButtonItem47.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem48
            // 
            this.spreadsheetCommandBarButtonItem48.CommandName = "ConditionalFormattingBetweenRuleCommand";
            this.spreadsheetCommandBarButtonItem48.Id = 81;
            this.spreadsheetCommandBarButtonItem48.Name = "spreadsheetCommandBarButtonItem48";
            this.spreadsheetCommandBarButtonItem48.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem49
            // 
            this.spreadsheetCommandBarButtonItem49.CommandName = "ConditionalFormattingEqualToRuleCommand";
            this.spreadsheetCommandBarButtonItem49.Id = 82;
            this.spreadsheetCommandBarButtonItem49.Name = "spreadsheetCommandBarButtonItem49";
            this.spreadsheetCommandBarButtonItem49.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem50
            // 
            this.spreadsheetCommandBarButtonItem50.CommandName = "ConditionalFormattingTextContainsRuleCommand";
            this.spreadsheetCommandBarButtonItem50.Id = 83;
            this.spreadsheetCommandBarButtonItem50.Name = "spreadsheetCommandBarButtonItem50";
            this.spreadsheetCommandBarButtonItem50.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem51
            // 
            this.spreadsheetCommandBarButtonItem51.CommandName = "ConditionalFormattingDateOccurringRuleCommand";
            this.spreadsheetCommandBarButtonItem51.Id = 84;
            this.spreadsheetCommandBarButtonItem51.Name = "spreadsheetCommandBarButtonItem51";
            this.spreadsheetCommandBarButtonItem51.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem52
            // 
            this.spreadsheetCommandBarButtonItem52.CommandName = "ConditionalFormattingDuplicateValuesRuleCommand";
            this.spreadsheetCommandBarButtonItem52.Id = 85;
            this.spreadsheetCommandBarButtonItem52.Name = "spreadsheetCommandBarButtonItem52";
            this.spreadsheetCommandBarButtonItem52.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem5
            // 
            this.spreadsheetCommandBarSubItem5.CommandName = "ConditionalFormattingTopBottomRuleCommandGroup";
            this.spreadsheetCommandBarSubItem5.Id = 93;
            this.spreadsheetCommandBarSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem53),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem54),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem55),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem56),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem57),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem58)});
            this.spreadsheetCommandBarSubItem5.Name = "spreadsheetCommandBarSubItem5";
            // 
            // spreadsheetCommandBarButtonItem53
            // 
            this.spreadsheetCommandBarButtonItem53.CommandName = "ConditionalFormattingTop10RuleCommand";
            this.spreadsheetCommandBarButtonItem53.Id = 87;
            this.spreadsheetCommandBarButtonItem53.Name = "spreadsheetCommandBarButtonItem53";
            this.spreadsheetCommandBarButtonItem53.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem54
            // 
            this.spreadsheetCommandBarButtonItem54.CommandName = "ConditionalFormattingTop10PercentRuleCommand";
            this.spreadsheetCommandBarButtonItem54.Id = 88;
            this.spreadsheetCommandBarButtonItem54.Name = "spreadsheetCommandBarButtonItem54";
            this.spreadsheetCommandBarButtonItem54.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem55
            // 
            this.spreadsheetCommandBarButtonItem55.CommandName = "ConditionalFormattingBottom10RuleCommand";
            this.spreadsheetCommandBarButtonItem55.Id = 89;
            this.spreadsheetCommandBarButtonItem55.Name = "spreadsheetCommandBarButtonItem55";
            this.spreadsheetCommandBarButtonItem55.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem56
            // 
            this.spreadsheetCommandBarButtonItem56.CommandName = "ConditionalFormattingBottom10PercentRuleCommand";
            this.spreadsheetCommandBarButtonItem56.Id = 90;
            this.spreadsheetCommandBarButtonItem56.Name = "spreadsheetCommandBarButtonItem56";
            this.spreadsheetCommandBarButtonItem56.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem57
            // 
            this.spreadsheetCommandBarButtonItem57.CommandName = "ConditionalFormattingAboveAverageRuleCommand";
            this.spreadsheetCommandBarButtonItem57.Id = 91;
            this.spreadsheetCommandBarButtonItem57.Name = "spreadsheetCommandBarButtonItem57";
            this.spreadsheetCommandBarButtonItem57.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem58
            // 
            this.spreadsheetCommandBarButtonItem58.CommandName = "ConditionalFormattingBelowAverageRuleCommand";
            this.spreadsheetCommandBarButtonItem58.Id = 92;
            this.spreadsheetCommandBarButtonItem58.Name = "spreadsheetCommandBarButtonItem58";
            this.spreadsheetCommandBarButtonItem58.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem1
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.CommandName = "ConditionalFormattingDataBarsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.DropDownControl = this.commandBarGalleryDropDown74;
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.Id = 94;
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.Name = "spreadsheetCommandBarButtonGalleryDropDownItem1";
            this.spreadsheetCommandBarButtonGalleryDropDownItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarGalleryDropDown74
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown74.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup3.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup";
            spreadsheetCommandGalleryItem24.CommandName = "ConditionalFormattingDataBarGradientBlue";
            spreadsheetCommandGalleryItem25.CommandName = "ConditionalFormattingDataBarGradientGreen";
            spreadsheetCommandGalleryItem26.CommandName = "ConditionalFormattingDataBarGradientRed";
            spreadsheetCommandGalleryItem27.CommandName = "ConditionalFormattingDataBarGradientOrange";
            spreadsheetCommandGalleryItem28.CommandName = "ConditionalFormattingDataBarGradientLightBlue";
            spreadsheetCommandGalleryItem29.CommandName = "ConditionalFormattingDataBarGradientPurple";
            spreadsheetCommandGalleryItemGroup3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem24,
            spreadsheetCommandGalleryItem25,
            spreadsheetCommandGalleryItem26,
            spreadsheetCommandGalleryItem27,
            spreadsheetCommandGalleryItem28,
            spreadsheetCommandGalleryItem29});
            spreadsheetCommandGalleryItemGroup4.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup";
            spreadsheetCommandGalleryItem30.CommandName = "ConditionalFormattingDataBarSolidBlue";
            spreadsheetCommandGalleryItem31.CommandName = "ConditionalFormattingDataBarSolidGreen";
            spreadsheetCommandGalleryItem32.CommandName = "ConditionalFormattingDataBarSolidRed";
            spreadsheetCommandGalleryItem33.CommandName = "ConditionalFormattingDataBarSolidOrange";
            spreadsheetCommandGalleryItem34.CommandName = "ConditionalFormattingDataBarSolidLightBlue";
            spreadsheetCommandGalleryItem35.CommandName = "ConditionalFormattingDataBarSolidPurple";
            spreadsheetCommandGalleryItemGroup4.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem30,
            spreadsheetCommandGalleryItem31,
            spreadsheetCommandGalleryItem32,
            spreadsheetCommandGalleryItem33,
            spreadsheetCommandGalleryItem34,
            spreadsheetCommandGalleryItem35});
            this.commandBarGalleryDropDown74.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup3,
            spreadsheetCommandGalleryItemGroup4});
            this.commandBarGalleryDropDown74.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown74.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown74.Name = "commandBarGalleryDropDown74";
            this.commandBarGalleryDropDown74.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem2
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.DropDownControl = this.commandBarGalleryDropDown75;
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.Id = 95;
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.Name = "spreadsheetCommandBarButtonGalleryDropDownItem2";
            this.spreadsheetCommandBarButtonGalleryDropDownItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarGalleryDropDown75
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown75.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup5.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            spreadsheetCommandGalleryItem36.CommandName = "ConditionalFormattingColorScaleGreenYellowRed";
            spreadsheetCommandGalleryItem37.CommandName = "ConditionalFormattingColorScaleRedYellowGreen";
            spreadsheetCommandGalleryItem38.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed";
            spreadsheetCommandGalleryItem39.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen";
            spreadsheetCommandGalleryItem40.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed";
            spreadsheetCommandGalleryItem41.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue";
            spreadsheetCommandGalleryItem42.CommandName = "ConditionalFormattingColorScaleWhiteRed";
            spreadsheetCommandGalleryItem43.CommandName = "ConditionalFormattingColorScaleRedWhite";
            spreadsheetCommandGalleryItem44.CommandName = "ConditionalFormattingColorScaleGreenWhite";
            spreadsheetCommandGalleryItem45.CommandName = "ConditionalFormattingColorScaleWhiteGreen";
            spreadsheetCommandGalleryItem46.CommandName = "ConditionalFormattingColorScaleGreenYellow";
            spreadsheetCommandGalleryItem47.CommandName = "ConditionalFormattingColorScaleYellowGreen";
            spreadsheetCommandGalleryItemGroup5.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem36,
            spreadsheetCommandGalleryItem37,
            spreadsheetCommandGalleryItem38,
            spreadsheetCommandGalleryItem39,
            spreadsheetCommandGalleryItem40,
            spreadsheetCommandGalleryItem41,
            spreadsheetCommandGalleryItem42,
            spreadsheetCommandGalleryItem43,
            spreadsheetCommandGalleryItem44,
            spreadsheetCommandGalleryItem45,
            spreadsheetCommandGalleryItem46,
            spreadsheetCommandGalleryItem47});
            this.commandBarGalleryDropDown75.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup5});
            this.commandBarGalleryDropDown75.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown75.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown75.Name = "commandBarGalleryDropDown75";
            this.commandBarGalleryDropDown75.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem3
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.CommandName = "ConditionalFormattingIconSetsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.DropDownControl = this.commandBarGalleryDropDown76;
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.Id = 96;
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.Name = "spreadsheetCommandBarButtonGalleryDropDownItem3";
            this.spreadsheetCommandBarButtonGalleryDropDownItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // commandBarGalleryDropDown76
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown76.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup6.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup";
            spreadsheetCommandGalleryItem48.CommandName = "ConditionalFormattingIconSetArrows3Colored";
            spreadsheetCommandGalleryItem49.CommandName = "ConditionalFormattingIconSetArrows3Grayed";
            spreadsheetCommandGalleryItem50.CommandName = "ConditionalFormattingIconSetArrows4Colored";
            spreadsheetCommandGalleryItem51.CommandName = "ConditionalFormattingIconSetArrows4Grayed";
            spreadsheetCommandGalleryItem52.CommandName = "ConditionalFormattingIconSetArrows5Colored";
            spreadsheetCommandGalleryItem53.CommandName = "ConditionalFormattingIconSetArrows5Grayed";
            spreadsheetCommandGalleryItem54.CommandName = "ConditionalFormattingIconSetTriangles3";
            spreadsheetCommandGalleryItemGroup6.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem48,
            spreadsheetCommandGalleryItem49,
            spreadsheetCommandGalleryItem50,
            spreadsheetCommandGalleryItem51,
            spreadsheetCommandGalleryItem52,
            spreadsheetCommandGalleryItem53,
            spreadsheetCommandGalleryItem54});
            spreadsheetCommandGalleryItemGroup7.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup";
            spreadsheetCommandGalleryItem55.CommandName = "ConditionalFormattingIconSetTrafficLights3";
            spreadsheetCommandGalleryItem56.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed";
            spreadsheetCommandGalleryItem57.CommandName = "ConditionalFormattingIconSetTrafficLights4";
            spreadsheetCommandGalleryItem58.CommandName = "ConditionalFormattingIconSetSigns3";
            spreadsheetCommandGalleryItem59.CommandName = "ConditionalFormattingIconSetRedToBlack";
            spreadsheetCommandGalleryItemGroup7.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem55,
            spreadsheetCommandGalleryItem56,
            spreadsheetCommandGalleryItem57,
            spreadsheetCommandGalleryItem58,
            spreadsheetCommandGalleryItem59});
            spreadsheetCommandGalleryItemGroup8.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup";
            spreadsheetCommandGalleryItem60.CommandName = "ConditionalFormattingIconSetSymbols3Circled";
            spreadsheetCommandGalleryItem61.CommandName = "ConditionalFormattingIconSetSymbols3";
            spreadsheetCommandGalleryItem62.CommandName = "ConditionalFormattingIconSetFlags3";
            spreadsheetCommandGalleryItemGroup8.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem60,
            spreadsheetCommandGalleryItem61,
            spreadsheetCommandGalleryItem62});
            spreadsheetCommandGalleryItemGroup9.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup";
            spreadsheetCommandGalleryItem63.CommandName = "ConditionalFormattingIconSetStars3";
            spreadsheetCommandGalleryItem64.CommandName = "ConditionalFormattingIconSetRatings4";
            spreadsheetCommandGalleryItem65.CommandName = "ConditionalFormattingIconSetRatings5";
            spreadsheetCommandGalleryItem66.CommandName = "ConditionalFormattingIconSetQuarters5";
            spreadsheetCommandGalleryItem67.CommandName = "ConditionalFormattingIconSetBoxes5";
            spreadsheetCommandGalleryItemGroup9.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem63,
            spreadsheetCommandGalleryItem64,
            spreadsheetCommandGalleryItem65,
            spreadsheetCommandGalleryItem66,
            spreadsheetCommandGalleryItem67});
            this.commandBarGalleryDropDown76.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup6,
            spreadsheetCommandGalleryItemGroup7,
            spreadsheetCommandGalleryItemGroup8,
            spreadsheetCommandGalleryItemGroup9});
            this.commandBarGalleryDropDown76.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown76.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown76.Name = "commandBarGalleryDropDown76";
            this.commandBarGalleryDropDown76.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonItem59
            // 
            this.spreadsheetCommandBarButtonItem59.CommandName = "NewConditionalFormattingRule";
            this.spreadsheetCommandBarButtonItem59.Id = 97;
            this.spreadsheetCommandBarButtonItem59.Name = "spreadsheetCommandBarButtonItem59";
            // 
            // spreadsheetCommandBarSubItem6
            // 
            this.spreadsheetCommandBarSubItem6.CommandName = "ConditionalFormattingRemoveCommandGroup";
            this.spreadsheetCommandBarSubItem6.Id = 100;
            this.spreadsheetCommandBarSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem60),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem61)});
            this.spreadsheetCommandBarSubItem6.Name = "spreadsheetCommandBarSubItem6";
            // 
            // spreadsheetCommandBarButtonItem60
            // 
            this.spreadsheetCommandBarButtonItem60.CommandName = "ConditionalFormattingRemoveFromSheet";
            this.spreadsheetCommandBarButtonItem60.Id = 98;
            this.spreadsheetCommandBarButtonItem60.Name = "spreadsheetCommandBarButtonItem60";
            // 
            // spreadsheetCommandBarButtonItem61
            // 
            this.spreadsheetCommandBarButtonItem61.CommandName = "ConditionalFormattingRemove";
            this.spreadsheetCommandBarButtonItem61.Id = 99;
            this.spreadsheetCommandBarButtonItem61.Name = "spreadsheetCommandBarButtonItem61";
            // 
            // spreadsheetCommandBarButtonItem62
            // 
            this.spreadsheetCommandBarButtonItem62.CommandName = "ConditionalFormattingRulesManager";
            this.spreadsheetCommandBarButtonItem62.Id = 101;
            this.spreadsheetCommandBarButtonItem62.Name = "spreadsheetCommandBarButtonItem62";
            // 
            // galleryFormatAsTableItem1
            // 
            this.galleryFormatAsTableItem1.DropDownControl = this.commandBarGalleryDropDown77;
            this.galleryFormatAsTableItem1.Id = 102;
            this.galleryFormatAsTableItem1.Name = "galleryFormatAsTableItem1";
            // 
            // commandBarGalleryDropDown77
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown77.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown77.Gallery.ColumnCount = 7;
            this.commandBarGalleryDropDown77.Gallery.DrawImageBackground = false;
            this.commandBarGalleryDropDown77.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown77.Gallery.ItemSize = new System.Drawing.Size(73, 58);
            this.commandBarGalleryDropDown77.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown77.Name = "commandBarGalleryDropDown77";
            this.commandBarGalleryDropDown77.Ribbon = this.ribbonControl1;
            // 
            // galleryChangeStyleItem1
            // 
            // 
            // 
            // 
            this.galleryChangeStyleItem1.Gallery.DrawImageBackground = false;
            this.galleryChangeStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChangeStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.galleryChangeStyleItem1.Gallery.ItemSize = new System.Drawing.Size(106, 28);
            this.galleryChangeStyleItem1.Gallery.RowCount = 9;
            this.galleryChangeStyleItem1.Gallery.ShowItemText = true;
            this.galleryChangeStyleItem1.Id = 103;
            this.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1";
            // 
            // spreadsheetCommandBarSubItem8
            // 
            this.spreadsheetCommandBarSubItem8.CommandName = "InsertCellsCommandGroup";
            this.spreadsheetCommandBarSubItem8.Id = 104;
            this.spreadsheetCommandBarSubItem8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem63),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem64),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem65),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem66),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem67),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem68),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem69),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem70)});
            this.spreadsheetCommandBarSubItem8.Name = "spreadsheetCommandBarSubItem8";
            // 
            // spreadsheetCommandBarButtonItem63
            // 
            this.spreadsheetCommandBarButtonItem63.CommandName = "InsertCells";
            this.spreadsheetCommandBarButtonItem63.Id = 105;
            this.spreadsheetCommandBarButtonItem63.Name = "spreadsheetCommandBarButtonItem63";
            // 
            // spreadsheetCommandBarButtonItem64
            // 
            this.spreadsheetCommandBarButtonItem64.CommandName = "InsertSheetRows";
            this.spreadsheetCommandBarButtonItem64.Id = 106;
            this.spreadsheetCommandBarButtonItem64.Name = "spreadsheetCommandBarButtonItem64";
            // 
            // spreadsheetCommandBarButtonItem65
            // 
            this.spreadsheetCommandBarButtonItem65.CommandName = "InsertSheetColumns";
            this.spreadsheetCommandBarButtonItem65.Id = 107;
            this.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65";
            // 
            // spreadsheetCommandBarButtonItem66
            // 
            this.spreadsheetCommandBarButtonItem66.CommandName = "InsertTableRowsAbove";
            this.spreadsheetCommandBarButtonItem66.Id = 108;
            this.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66";
            // 
            // spreadsheetCommandBarButtonItem67
            // 
            this.spreadsheetCommandBarButtonItem67.CommandName = "InsertTableRowBelow";
            this.spreadsheetCommandBarButtonItem67.Id = 109;
            this.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67";
            // 
            // spreadsheetCommandBarButtonItem68
            // 
            this.spreadsheetCommandBarButtonItem68.CommandName = "InsertTableColumnsToTheLeft";
            this.spreadsheetCommandBarButtonItem68.Id = 110;
            this.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68";
            // 
            // spreadsheetCommandBarButtonItem69
            // 
            this.spreadsheetCommandBarButtonItem69.CommandName = "InsertTableColumnToTheRight";
            this.spreadsheetCommandBarButtonItem69.Id = 111;
            this.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69";
            // 
            // spreadsheetCommandBarButtonItem70
            // 
            this.spreadsheetCommandBarButtonItem70.CommandName = "InsertSheet";
            this.spreadsheetCommandBarButtonItem70.Id = 112;
            this.spreadsheetCommandBarButtonItem70.Name = "spreadsheetCommandBarButtonItem70";
            // 
            // spreadsheetCommandBarSubItem9
            // 
            this.spreadsheetCommandBarSubItem9.CommandName = "RemoveCellsCommandGroup";
            this.spreadsheetCommandBarSubItem9.Id = 113;
            this.spreadsheetCommandBarSubItem9.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem71),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem72),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem73),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem74),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem75),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem76)});
            this.spreadsheetCommandBarSubItem9.Name = "spreadsheetCommandBarSubItem9";
            // 
            // spreadsheetCommandBarButtonItem71
            // 
            this.spreadsheetCommandBarButtonItem71.CommandName = "RemoveCells";
            this.spreadsheetCommandBarButtonItem71.Id = 114;
            this.spreadsheetCommandBarButtonItem71.Name = "spreadsheetCommandBarButtonItem71";
            // 
            // spreadsheetCommandBarButtonItem72
            // 
            this.spreadsheetCommandBarButtonItem72.CommandName = "RemoveSheetRows";
            this.spreadsheetCommandBarButtonItem72.Id = 115;
            this.spreadsheetCommandBarButtonItem72.Name = "spreadsheetCommandBarButtonItem72";
            // 
            // spreadsheetCommandBarButtonItem73
            // 
            this.spreadsheetCommandBarButtonItem73.CommandName = "RemoveSheetColumns";
            this.spreadsheetCommandBarButtonItem73.Id = 116;
            this.spreadsheetCommandBarButtonItem73.Name = "spreadsheetCommandBarButtonItem73";
            // 
            // spreadsheetCommandBarButtonItem74
            // 
            this.spreadsheetCommandBarButtonItem74.CommandName = "RemoveTableRows";
            this.spreadsheetCommandBarButtonItem74.Id = 117;
            this.spreadsheetCommandBarButtonItem74.Name = "spreadsheetCommandBarButtonItem74";
            // 
            // spreadsheetCommandBarButtonItem75
            // 
            this.spreadsheetCommandBarButtonItem75.CommandName = "RemoveTableColumns";
            this.spreadsheetCommandBarButtonItem75.Id = 118;
            this.spreadsheetCommandBarButtonItem75.Name = "spreadsheetCommandBarButtonItem75";
            // 
            // spreadsheetCommandBarButtonItem76
            // 
            this.spreadsheetCommandBarButtonItem76.CommandName = "RemoveSheet";
            this.spreadsheetCommandBarButtonItem76.Id = 119;
            this.spreadsheetCommandBarButtonItem76.Name = "spreadsheetCommandBarButtonItem76";
            // 
            // spreadsheetCommandBarSubItem11
            // 
            this.spreadsheetCommandBarSubItem11.CommandName = "FormatCommandGroup";
            this.spreadsheetCommandBarSubItem11.Id = 120;
            this.spreadsheetCommandBarSubItem11.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem77),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem78),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem79),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem80),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem81),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarSubItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem88),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem89),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeSheetTabColorItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem90),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem91)});
            this.spreadsheetCommandBarSubItem11.Name = "spreadsheetCommandBarSubItem11";
            // 
            // spreadsheetCommandBarButtonItem77
            // 
            this.spreadsheetCommandBarButtonItem77.CommandName = "FormatRowHeight";
            this.spreadsheetCommandBarButtonItem77.Id = 121;
            this.spreadsheetCommandBarButtonItem77.Name = "spreadsheetCommandBarButtonItem77";
            // 
            // spreadsheetCommandBarButtonItem78
            // 
            this.spreadsheetCommandBarButtonItem78.CommandName = "FormatAutoFitRowHeight";
            this.spreadsheetCommandBarButtonItem78.Id = 122;
            this.spreadsheetCommandBarButtonItem78.Name = "spreadsheetCommandBarButtonItem78";
            // 
            // spreadsheetCommandBarButtonItem79
            // 
            this.spreadsheetCommandBarButtonItem79.CommandName = "FormatColumnWidth";
            this.spreadsheetCommandBarButtonItem79.Id = 123;
            this.spreadsheetCommandBarButtonItem79.Name = "spreadsheetCommandBarButtonItem79";
            // 
            // spreadsheetCommandBarButtonItem80
            // 
            this.spreadsheetCommandBarButtonItem80.CommandName = "FormatAutoFitColumnWidth";
            this.spreadsheetCommandBarButtonItem80.Id = 124;
            this.spreadsheetCommandBarButtonItem80.Name = "spreadsheetCommandBarButtonItem80";
            // 
            // spreadsheetCommandBarButtonItem81
            // 
            this.spreadsheetCommandBarButtonItem81.CommandName = "FormatDefaultColumnWidth";
            this.spreadsheetCommandBarButtonItem81.Id = 125;
            this.spreadsheetCommandBarButtonItem81.Name = "spreadsheetCommandBarButtonItem81";
            // 
            // spreadsheetCommandBarSubItem10
            // 
            this.spreadsheetCommandBarSubItem10.CommandName = "HideAndUnhideCommandGroup";
            this.spreadsheetCommandBarSubItem10.Id = 132;
            this.spreadsheetCommandBarSubItem10.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem82),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem83),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem84),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem85),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem86),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem87)});
            this.spreadsheetCommandBarSubItem10.Name = "spreadsheetCommandBarSubItem10";
            // 
            // spreadsheetCommandBarButtonItem82
            // 
            this.spreadsheetCommandBarButtonItem82.CommandName = "HideRows";
            this.spreadsheetCommandBarButtonItem82.Id = 126;
            this.spreadsheetCommandBarButtonItem82.Name = "spreadsheetCommandBarButtonItem82";
            // 
            // spreadsheetCommandBarButtonItem83
            // 
            this.spreadsheetCommandBarButtonItem83.CommandName = "HideColumns";
            this.spreadsheetCommandBarButtonItem83.Id = 127;
            this.spreadsheetCommandBarButtonItem83.Name = "spreadsheetCommandBarButtonItem83";
            // 
            // spreadsheetCommandBarButtonItem84
            // 
            this.spreadsheetCommandBarButtonItem84.CommandName = "HideSheet";
            this.spreadsheetCommandBarButtonItem84.Id = 128;
            this.spreadsheetCommandBarButtonItem84.Name = "spreadsheetCommandBarButtonItem84";
            // 
            // spreadsheetCommandBarButtonItem85
            // 
            this.spreadsheetCommandBarButtonItem85.CommandName = "UnhideRows";
            this.spreadsheetCommandBarButtonItem85.Id = 129;
            this.spreadsheetCommandBarButtonItem85.Name = "spreadsheetCommandBarButtonItem85";
            // 
            // spreadsheetCommandBarButtonItem86
            // 
            this.spreadsheetCommandBarButtonItem86.CommandName = "UnhideColumns";
            this.spreadsheetCommandBarButtonItem86.Id = 130;
            this.spreadsheetCommandBarButtonItem86.Name = "spreadsheetCommandBarButtonItem86";
            // 
            // spreadsheetCommandBarButtonItem87
            // 
            this.spreadsheetCommandBarButtonItem87.CommandName = "UnhideSheet";
            this.spreadsheetCommandBarButtonItem87.Id = 131;
            this.spreadsheetCommandBarButtonItem87.Name = "spreadsheetCommandBarButtonItem87";
            // 
            // spreadsheetCommandBarButtonItem88
            // 
            this.spreadsheetCommandBarButtonItem88.CommandName = "RenameSheet";
            this.spreadsheetCommandBarButtonItem88.Id = 133;
            this.spreadsheetCommandBarButtonItem88.Name = "spreadsheetCommandBarButtonItem88";
            // 
            // spreadsheetCommandBarButtonItem89
            // 
            this.spreadsheetCommandBarButtonItem89.CommandName = "MoveOrCopySheet";
            this.spreadsheetCommandBarButtonItem89.Id = 134;
            this.spreadsheetCommandBarButtonItem89.Name = "spreadsheetCommandBarButtonItem89";
            // 
            // changeSheetTabColorItem1
            // 
            this.changeSheetTabColorItem1.ActAsDropDown = true;
            this.changeSheetTabColorItem1.Id = 135;
            this.changeSheetTabColorItem1.Name = "changeSheetTabColorItem1";
            // 
            // spreadsheetCommandBarButtonItem90
            // 
            this.spreadsheetCommandBarButtonItem90.CommandName = "ReviewProtectSheet";
            this.spreadsheetCommandBarButtonItem90.Id = 136;
            this.spreadsheetCommandBarButtonItem90.Name = "spreadsheetCommandBarButtonItem90";
            // 
            // spreadsheetCommandBarCheckItem13
            // 
            this.spreadsheetCommandBarCheckItem13.CommandName = "FormatCellLocked";
            this.spreadsheetCommandBarCheckItem13.Id = 137;
            this.spreadsheetCommandBarCheckItem13.Name = "spreadsheetCommandBarCheckItem13";
            // 
            // spreadsheetCommandBarButtonItem91
            // 
            this.spreadsheetCommandBarButtonItem91.CommandName = "FormatCellsContextMenuItem";
            this.spreadsheetCommandBarButtonItem91.Id = 138;
            this.spreadsheetCommandBarButtonItem91.Name = "spreadsheetCommandBarButtonItem91";
            // 
            // spreadsheetCommandBarSubItem12
            // 
            this.spreadsheetCommandBarSubItem12.CommandName = "EditingAutoSumCommandGroup";
            this.spreadsheetCommandBarSubItem12.Id = 139;
            this.spreadsheetCommandBarSubItem12.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem92),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem93),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem94),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem95),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem96)});
            this.spreadsheetCommandBarSubItem12.Name = "spreadsheetCommandBarSubItem12";
            this.spreadsheetCommandBarSubItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem92
            // 
            this.spreadsheetCommandBarButtonItem92.CommandName = "FunctionsInsertSum";
            this.spreadsheetCommandBarButtonItem92.Id = 140;
            this.spreadsheetCommandBarButtonItem92.Name = "spreadsheetCommandBarButtonItem92";
            // 
            // spreadsheetCommandBarButtonItem93
            // 
            this.spreadsheetCommandBarButtonItem93.CommandName = "FunctionsInsertAverage";
            this.spreadsheetCommandBarButtonItem93.Id = 141;
            this.spreadsheetCommandBarButtonItem93.Name = "spreadsheetCommandBarButtonItem93";
            // 
            // spreadsheetCommandBarButtonItem94
            // 
            this.spreadsheetCommandBarButtonItem94.CommandName = "FunctionsInsertCountNumbers";
            this.spreadsheetCommandBarButtonItem94.Id = 142;
            this.spreadsheetCommandBarButtonItem94.Name = "spreadsheetCommandBarButtonItem94";
            // 
            // spreadsheetCommandBarButtonItem95
            // 
            this.spreadsheetCommandBarButtonItem95.CommandName = "FunctionsInsertMax";
            this.spreadsheetCommandBarButtonItem95.Id = 143;
            this.spreadsheetCommandBarButtonItem95.Name = "spreadsheetCommandBarButtonItem95";
            // 
            // spreadsheetCommandBarButtonItem96
            // 
            this.spreadsheetCommandBarButtonItem96.CommandName = "FunctionsInsertMin";
            this.spreadsheetCommandBarButtonItem96.Id = 144;
            this.spreadsheetCommandBarButtonItem96.Name = "spreadsheetCommandBarButtonItem96";
            // 
            // spreadsheetCommandBarSubItem13
            // 
            this.spreadsheetCommandBarSubItem13.CommandName = "EditingFillCommandGroup";
            this.spreadsheetCommandBarSubItem13.Id = 145;
            this.spreadsheetCommandBarSubItem13.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem97),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem98),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem99),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem100)});
            this.spreadsheetCommandBarSubItem13.Name = "spreadsheetCommandBarSubItem13";
            this.spreadsheetCommandBarSubItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem97
            // 
            this.spreadsheetCommandBarButtonItem97.CommandName = "EditingFillDown";
            this.spreadsheetCommandBarButtonItem97.Id = 146;
            this.spreadsheetCommandBarButtonItem97.Name = "spreadsheetCommandBarButtonItem97";
            // 
            // spreadsheetCommandBarButtonItem98
            // 
            this.spreadsheetCommandBarButtonItem98.CommandName = "EditingFillRight";
            this.spreadsheetCommandBarButtonItem98.Id = 147;
            this.spreadsheetCommandBarButtonItem98.Name = "spreadsheetCommandBarButtonItem98";
            // 
            // spreadsheetCommandBarButtonItem99
            // 
            this.spreadsheetCommandBarButtonItem99.CommandName = "EditingFillUp";
            this.spreadsheetCommandBarButtonItem99.Id = 148;
            this.spreadsheetCommandBarButtonItem99.Name = "spreadsheetCommandBarButtonItem99";
            // 
            // spreadsheetCommandBarButtonItem100
            // 
            this.spreadsheetCommandBarButtonItem100.CommandName = "EditingFillLeft";
            this.spreadsheetCommandBarButtonItem100.Id = 149;
            this.spreadsheetCommandBarButtonItem100.Name = "spreadsheetCommandBarButtonItem100";
            // 
            // spreadsheetCommandBarSubItem14
            // 
            this.spreadsheetCommandBarSubItem14.CommandName = "FormatClearCommandGroup";
            this.spreadsheetCommandBarSubItem14.Id = 150;
            this.spreadsheetCommandBarSubItem14.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem101),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem102),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem103),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem104),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem105),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem106)});
            this.spreadsheetCommandBarSubItem14.Name = "spreadsheetCommandBarSubItem14";
            this.spreadsheetCommandBarSubItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem101
            // 
            this.spreadsheetCommandBarButtonItem101.CommandName = "FormatClearAll";
            this.spreadsheetCommandBarButtonItem101.Id = 151;
            this.spreadsheetCommandBarButtonItem101.Name = "spreadsheetCommandBarButtonItem101";
            // 
            // spreadsheetCommandBarButtonItem102
            // 
            this.spreadsheetCommandBarButtonItem102.CommandName = "FormatClearFormats";
            this.spreadsheetCommandBarButtonItem102.Id = 152;
            this.spreadsheetCommandBarButtonItem102.Name = "spreadsheetCommandBarButtonItem102";
            // 
            // spreadsheetCommandBarButtonItem103
            // 
            this.spreadsheetCommandBarButtonItem103.CommandName = "FormatClearContents";
            this.spreadsheetCommandBarButtonItem103.Id = 153;
            this.spreadsheetCommandBarButtonItem103.Name = "spreadsheetCommandBarButtonItem103";
            // 
            // spreadsheetCommandBarButtonItem104
            // 
            this.spreadsheetCommandBarButtonItem104.CommandName = "FormatClearComments";
            this.spreadsheetCommandBarButtonItem104.Id = 154;
            this.spreadsheetCommandBarButtonItem104.Name = "spreadsheetCommandBarButtonItem104";
            // 
            // spreadsheetCommandBarButtonItem105
            // 
            this.spreadsheetCommandBarButtonItem105.CommandName = "FormatClearHyperlinks";
            this.spreadsheetCommandBarButtonItem105.Id = 155;
            this.spreadsheetCommandBarButtonItem105.Name = "spreadsheetCommandBarButtonItem105";
            // 
            // spreadsheetCommandBarButtonItem106
            // 
            this.spreadsheetCommandBarButtonItem106.CommandName = "FormatRemoveHyperlinks";
            this.spreadsheetCommandBarButtonItem106.Id = 156;
            this.spreadsheetCommandBarButtonItem106.Name = "spreadsheetCommandBarButtonItem106";
            // 
            // spreadsheetCommandBarSubItem15
            // 
            this.spreadsheetCommandBarSubItem15.CommandName = "EditingSortAndFilterCommandGroup";
            this.spreadsheetCommandBarSubItem15.Id = 157;
            this.spreadsheetCommandBarSubItem15.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem107),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem108),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem14),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem109),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem110)});
            this.spreadsheetCommandBarSubItem15.Name = "spreadsheetCommandBarSubItem15";
            // 
            // spreadsheetCommandBarButtonItem107
            // 
            this.spreadsheetCommandBarButtonItem107.CommandName = "DataSortAscending";
            this.spreadsheetCommandBarButtonItem107.Id = 158;
            this.spreadsheetCommandBarButtonItem107.Name = "spreadsheetCommandBarButtonItem107";
            // 
            // spreadsheetCommandBarButtonItem108
            // 
            this.spreadsheetCommandBarButtonItem108.CommandName = "DataSortDescending";
            this.spreadsheetCommandBarButtonItem108.Id = 159;
            this.spreadsheetCommandBarButtonItem108.Name = "spreadsheetCommandBarButtonItem108";
            // 
            // spreadsheetCommandBarCheckItem14
            // 
            this.spreadsheetCommandBarCheckItem14.CommandName = "DataFilterToggle";
            this.spreadsheetCommandBarCheckItem14.Id = 160;
            this.spreadsheetCommandBarCheckItem14.Name = "spreadsheetCommandBarCheckItem14";
            // 
            // spreadsheetCommandBarButtonItem109
            // 
            this.spreadsheetCommandBarButtonItem109.CommandName = "DataFilterClear";
            this.spreadsheetCommandBarButtonItem109.Id = 161;
            this.spreadsheetCommandBarButtonItem109.Name = "spreadsheetCommandBarButtonItem109";
            // 
            // spreadsheetCommandBarButtonItem110
            // 
            this.spreadsheetCommandBarButtonItem110.CommandName = "DataFilterReApply";
            this.spreadsheetCommandBarButtonItem110.Id = 162;
            this.spreadsheetCommandBarButtonItem110.Name = "spreadsheetCommandBarButtonItem110";
            // 
            // spreadsheetCommandBarSubItem16
            // 
            this.spreadsheetCommandBarSubItem16.CommandName = "EditingFindAndSelectCommandGroup";
            this.spreadsheetCommandBarSubItem16.Id = 163;
            this.spreadsheetCommandBarSubItem16.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem111),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem112),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem113),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem114),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem115),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem116),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem117)});
            this.spreadsheetCommandBarSubItem16.Name = "spreadsheetCommandBarSubItem16";
            // 
            // spreadsheetCommandBarButtonItem111
            // 
            this.spreadsheetCommandBarButtonItem111.CommandName = "EditingFind";
            this.spreadsheetCommandBarButtonItem111.Id = 164;
            this.spreadsheetCommandBarButtonItem111.Name = "spreadsheetCommandBarButtonItem111";
            // 
            // spreadsheetCommandBarButtonItem112
            // 
            this.spreadsheetCommandBarButtonItem112.CommandName = "EditingReplace";
            this.spreadsheetCommandBarButtonItem112.Id = 165;
            this.spreadsheetCommandBarButtonItem112.Name = "spreadsheetCommandBarButtonItem112";
            // 
            // spreadsheetCommandBarButtonItem113
            // 
            this.spreadsheetCommandBarButtonItem113.CommandName = "EditingSelectFormulas";
            this.spreadsheetCommandBarButtonItem113.Id = 166;
            this.spreadsheetCommandBarButtonItem113.Name = "spreadsheetCommandBarButtonItem113";
            // 
            // spreadsheetCommandBarButtonItem114
            // 
            this.spreadsheetCommandBarButtonItem114.CommandName = "EditingSelectComments";
            this.spreadsheetCommandBarButtonItem114.Id = 167;
            this.spreadsheetCommandBarButtonItem114.Name = "spreadsheetCommandBarButtonItem114";
            // 
            // spreadsheetCommandBarButtonItem115
            // 
            this.spreadsheetCommandBarButtonItem115.CommandName = "EditingSelectConditionalFormatting";
            this.spreadsheetCommandBarButtonItem115.Id = 168;
            this.spreadsheetCommandBarButtonItem115.Name = "spreadsheetCommandBarButtonItem115";
            // 
            // spreadsheetCommandBarButtonItem116
            // 
            this.spreadsheetCommandBarButtonItem116.CommandName = "EditingSelectConstants";
            this.spreadsheetCommandBarButtonItem116.Id = 169;
            this.spreadsheetCommandBarButtonItem116.Name = "spreadsheetCommandBarButtonItem116";
            // 
            // spreadsheetCommandBarButtonItem117
            // 
            this.spreadsheetCommandBarButtonItem117.CommandName = "EditingSelectDataValidation";
            this.spreadsheetCommandBarButtonItem117.Id = 170;
            this.spreadsheetCommandBarButtonItem117.Name = "spreadsheetCommandBarButtonItem117";
            // 
            // spreadsheetCommandBarButtonItem118
            // 
            this.spreadsheetCommandBarButtonItem118.CommandName = "InsertPivotTable";
            this.spreadsheetCommandBarButtonItem118.Id = 171;
            this.spreadsheetCommandBarButtonItem118.Name = "spreadsheetCommandBarButtonItem118";
            // 
            // spreadsheetCommandBarButtonItem119
            // 
            this.spreadsheetCommandBarButtonItem119.CommandName = "InsertTable";
            this.spreadsheetCommandBarButtonItem119.Id = 172;
            this.spreadsheetCommandBarButtonItem119.Name = "spreadsheetCommandBarButtonItem119";
            // 
            // spreadsheetCommandBarButtonItem120
            // 
            this.spreadsheetCommandBarButtonItem120.CommandName = "InsertPicture";
            this.spreadsheetCommandBarButtonItem120.Id = 173;
            this.spreadsheetCommandBarButtonItem120.Name = "spreadsheetCommandBarButtonItem120";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem4
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.CommandName = "InsertChartColumnCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.DropDownControl = this.commandBarGalleryDropDown78;
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.Id = 174;
            this.spreadsheetCommandBarButtonGalleryDropDownItem4.Name = "spreadsheetCommandBarButtonGalleryDropDownItem4";
            // 
            // commandBarGalleryDropDown78
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown78.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup10.CommandName = "InsertChartColumn2DCommandGroup";
            spreadsheetCommandGalleryItem68.CommandName = "InsertChartColumnClustered2D";
            spreadsheetCommandGalleryItem69.CommandName = "InsertChartColumnStacked2D";
            spreadsheetCommandGalleryItem70.CommandName = "InsertChartColumnPercentStacked2D";
            spreadsheetCommandGalleryItemGroup10.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem68,
            spreadsheetCommandGalleryItem69,
            spreadsheetCommandGalleryItem70});
            spreadsheetCommandGalleryItemGroup11.CommandName = "InsertChartColumn3DCommandGroup";
            spreadsheetCommandGalleryItem71.CommandName = "InsertChartColumnClustered3D";
            spreadsheetCommandGalleryItem72.CommandName = "InsertChartColumnStacked3D";
            spreadsheetCommandGalleryItem73.CommandName = "InsertChartColumnPercentStacked3D";
            spreadsheetCommandGalleryItem74.CommandName = "InsertChartColumn3D";
            spreadsheetCommandGalleryItemGroup11.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem71,
            spreadsheetCommandGalleryItem72,
            spreadsheetCommandGalleryItem73,
            spreadsheetCommandGalleryItem74});
            spreadsheetCommandGalleryItemGroup12.CommandName = "InsertChartCylinderCommandGroup";
            spreadsheetCommandGalleryItem75.CommandName = "InsertChartCylinderClustered";
            spreadsheetCommandGalleryItem76.CommandName = "InsertChartCylinderStacked";
            spreadsheetCommandGalleryItem77.CommandName = "InsertChartCylinderPercentStacked";
            spreadsheetCommandGalleryItem78.CommandName = "InsertChartCylinder";
            spreadsheetCommandGalleryItemGroup12.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem75,
            spreadsheetCommandGalleryItem76,
            spreadsheetCommandGalleryItem77,
            spreadsheetCommandGalleryItem78});
            spreadsheetCommandGalleryItemGroup13.CommandName = "InsertChartConeCommandGroup";
            spreadsheetCommandGalleryItem79.CommandName = "InsertChartConeClustered";
            spreadsheetCommandGalleryItem80.CommandName = "InsertChartConeStacked";
            spreadsheetCommandGalleryItem81.CommandName = "InsertChartConePercentStacked";
            spreadsheetCommandGalleryItem82.CommandName = "InsertChartCone";
            spreadsheetCommandGalleryItemGroup13.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem79,
            spreadsheetCommandGalleryItem80,
            spreadsheetCommandGalleryItem81,
            spreadsheetCommandGalleryItem82});
            spreadsheetCommandGalleryItemGroup14.CommandName = "InsertChartPyramidCommandGroup";
            spreadsheetCommandGalleryItem83.CommandName = "InsertChartPyramidClustered";
            spreadsheetCommandGalleryItem84.CommandName = "InsertChartPyramidStacked";
            spreadsheetCommandGalleryItem85.CommandName = "InsertChartPyramidPercentStacked";
            spreadsheetCommandGalleryItem86.CommandName = "InsertChartPyramid";
            spreadsheetCommandGalleryItemGroup14.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem83,
            spreadsheetCommandGalleryItem84,
            spreadsheetCommandGalleryItem85,
            spreadsheetCommandGalleryItem86});
            this.commandBarGalleryDropDown78.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup10,
            spreadsheetCommandGalleryItemGroup11,
            spreadsheetCommandGalleryItemGroup12,
            spreadsheetCommandGalleryItemGroup13,
            spreadsheetCommandGalleryItemGroup14});
            this.commandBarGalleryDropDown78.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown78.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown78.Name = "commandBarGalleryDropDown78";
            this.commandBarGalleryDropDown78.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem5
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.CommandName = "InsertChartLineCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.DropDownControl = this.commandBarGalleryDropDown79;
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.Id = 175;
            this.spreadsheetCommandBarButtonGalleryDropDownItem5.Name = "spreadsheetCommandBarButtonGalleryDropDownItem5";
            // 
            // commandBarGalleryDropDown79
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown79.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup15.CommandName = "InsertChartLine2DCommandGroup";
            spreadsheetCommandGalleryItem87.CommandName = "InsertChartLine";
            spreadsheetCommandGalleryItem88.CommandName = "InsertChartStackedLine";
            spreadsheetCommandGalleryItem89.CommandName = "InsertChartPercentStackedLine";
            spreadsheetCommandGalleryItem90.CommandName = "InsertChartLineWithMarkers";
            spreadsheetCommandGalleryItem91.CommandName = "InsertChartStackedLineWithMarkers";
            spreadsheetCommandGalleryItem92.CommandName = "InsertChartPercentStackedLineWithMarkers";
            spreadsheetCommandGalleryItemGroup15.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem87,
            spreadsheetCommandGalleryItem88,
            spreadsheetCommandGalleryItem89,
            spreadsheetCommandGalleryItem90,
            spreadsheetCommandGalleryItem91,
            spreadsheetCommandGalleryItem92});
            spreadsheetCommandGalleryItemGroup16.CommandName = "InsertChartLine3DCommandGroup";
            spreadsheetCommandGalleryItem93.CommandName = "InsertChartLine3D";
            spreadsheetCommandGalleryItemGroup16.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem93});
            this.commandBarGalleryDropDown79.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup15,
            spreadsheetCommandGalleryItemGroup16});
            this.commandBarGalleryDropDown79.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown79.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown79.Name = "commandBarGalleryDropDown79";
            this.commandBarGalleryDropDown79.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem6
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.CommandName = "InsertChartPieCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.DropDownControl = this.commandBarGalleryDropDown80;
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.Id = 176;
            this.spreadsheetCommandBarButtonGalleryDropDownItem6.Name = "spreadsheetCommandBarButtonGalleryDropDownItem6";
            // 
            // commandBarGalleryDropDown80
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown80.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup17.CommandName = "InsertChartPie2DCommandGroup";
            spreadsheetCommandGalleryItem94.CommandName = "InsertChartPie2D";
            spreadsheetCommandGalleryItem95.CommandName = "InsertChartPieExploded2D";
            spreadsheetCommandGalleryItemGroup17.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem94,
            spreadsheetCommandGalleryItem95});
            spreadsheetCommandGalleryItemGroup18.CommandName = "InsertChartPie3DCommandGroup";
            spreadsheetCommandGalleryItem96.CommandName = "InsertChartPie3D";
            spreadsheetCommandGalleryItem97.CommandName = "InsertChartPieExploded3D";
            spreadsheetCommandGalleryItemGroup18.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem96,
            spreadsheetCommandGalleryItem97});
            spreadsheetCommandGalleryItemGroup19.CommandName = "InsertChartDoughnut2DCommandGroup";
            spreadsheetCommandGalleryItem98.CommandName = "InsertChartDoughnut2D";
            spreadsheetCommandGalleryItem99.CommandName = "InsertChartDoughnutExploded2D";
            spreadsheetCommandGalleryItemGroup19.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem98,
            spreadsheetCommandGalleryItem99});
            this.commandBarGalleryDropDown80.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup17,
            spreadsheetCommandGalleryItemGroup18,
            spreadsheetCommandGalleryItemGroup19});
            this.commandBarGalleryDropDown80.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown80.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown80.Name = "commandBarGalleryDropDown80";
            this.commandBarGalleryDropDown80.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem7
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.CommandName = "InsertChartBarCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.DropDownControl = this.commandBarGalleryDropDown81;
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.Id = 177;
            this.spreadsheetCommandBarButtonGalleryDropDownItem7.Name = "spreadsheetCommandBarButtonGalleryDropDownItem7";
            // 
            // commandBarGalleryDropDown81
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown81.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup20.CommandName = "InsertChartBar2DCommandGroup";
            spreadsheetCommandGalleryItem100.CommandName = "InsertChartBarClustered2D";
            spreadsheetCommandGalleryItem101.CommandName = "InsertChartBarStacked2D";
            spreadsheetCommandGalleryItem102.CommandName = "InsertChartBarPercentStacked2D";
            spreadsheetCommandGalleryItemGroup20.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem100,
            spreadsheetCommandGalleryItem101,
            spreadsheetCommandGalleryItem102});
            spreadsheetCommandGalleryItemGroup21.CommandName = "InsertChartBar3DCommandGroup";
            spreadsheetCommandGalleryItem103.CommandName = "InsertChartBarClustered3D";
            spreadsheetCommandGalleryItem104.CommandName = "InsertChartBarStacked3D";
            spreadsheetCommandGalleryItem105.CommandName = "InsertChartBarPercentStacked3D";
            spreadsheetCommandGalleryItemGroup21.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem103,
            spreadsheetCommandGalleryItem104,
            spreadsheetCommandGalleryItem105});
            spreadsheetCommandGalleryItemGroup22.CommandName = "InsertChartHorizontalCylinderCommandGroup";
            spreadsheetCommandGalleryItem106.CommandName = "InsertChartHorizontalCylinderClustered";
            spreadsheetCommandGalleryItem107.CommandName = "InsertChartHorizontalCylinderStacked";
            spreadsheetCommandGalleryItem108.CommandName = "InsertChartHorizontalCylinderPercentStacked";
            spreadsheetCommandGalleryItemGroup22.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem106,
            spreadsheetCommandGalleryItem107,
            spreadsheetCommandGalleryItem108});
            spreadsheetCommandGalleryItemGroup23.CommandName = "InsertChartHorizontalConeCommandGroup";
            spreadsheetCommandGalleryItem109.CommandName = "InsertChartHorizontalConeClustered";
            spreadsheetCommandGalleryItem110.CommandName = "InsertChartHorizontalConeStacked";
            spreadsheetCommandGalleryItem111.CommandName = "InsertChartHorizontalConePercentStacked";
            spreadsheetCommandGalleryItemGroup23.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem109,
            spreadsheetCommandGalleryItem110,
            spreadsheetCommandGalleryItem111});
            spreadsheetCommandGalleryItemGroup24.CommandName = "InsertChartHorizontalPyramidCommandGroup";
            spreadsheetCommandGalleryItem112.CommandName = "InsertChartHorizontalPyramidClustered";
            spreadsheetCommandGalleryItem113.CommandName = "InsertChartHorizontalPyramidStacked";
            spreadsheetCommandGalleryItem114.CommandName = "InsertChartHorizontalPyramidPercentStacked";
            spreadsheetCommandGalleryItemGroup24.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem112,
            spreadsheetCommandGalleryItem113,
            spreadsheetCommandGalleryItem114});
            this.commandBarGalleryDropDown81.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup20,
            spreadsheetCommandGalleryItemGroup21,
            spreadsheetCommandGalleryItemGroup22,
            spreadsheetCommandGalleryItemGroup23,
            spreadsheetCommandGalleryItemGroup24});
            this.commandBarGalleryDropDown81.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown81.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown81.Name = "commandBarGalleryDropDown81";
            this.commandBarGalleryDropDown81.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem8
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.CommandName = "InsertChartAreaCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.DropDownControl = this.commandBarGalleryDropDown82;
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.Id = 178;
            this.spreadsheetCommandBarButtonGalleryDropDownItem8.Name = "spreadsheetCommandBarButtonGalleryDropDownItem8";
            // 
            // commandBarGalleryDropDown82
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown82.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup25.CommandName = "InsertChartArea2DCommandGroup";
            spreadsheetCommandGalleryItem115.CommandName = "InsertChartArea";
            spreadsheetCommandGalleryItem116.CommandName = "InsertChartStackedArea";
            spreadsheetCommandGalleryItem117.CommandName = "InsertChartPercentStackedArea";
            spreadsheetCommandGalleryItemGroup25.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem115,
            spreadsheetCommandGalleryItem116,
            spreadsheetCommandGalleryItem117});
            spreadsheetCommandGalleryItemGroup26.CommandName = "InsertChartArea3DCommandGroup";
            spreadsheetCommandGalleryItem118.CommandName = "InsertChartArea3D";
            spreadsheetCommandGalleryItem119.CommandName = "InsertChartStackedArea3D";
            spreadsheetCommandGalleryItem120.CommandName = "InsertChartPercentStackedArea3D";
            spreadsheetCommandGalleryItemGroup26.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem118,
            spreadsheetCommandGalleryItem119,
            spreadsheetCommandGalleryItem120});
            this.commandBarGalleryDropDown82.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup25,
            spreadsheetCommandGalleryItemGroup26});
            this.commandBarGalleryDropDown82.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown82.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown82.Name = "commandBarGalleryDropDown82";
            this.commandBarGalleryDropDown82.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem9
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.CommandName = "InsertChartScatterCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.DropDownControl = this.commandBarGalleryDropDown83;
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.Id = 179;
            this.spreadsheetCommandBarButtonGalleryDropDownItem9.Name = "spreadsheetCommandBarButtonGalleryDropDownItem9";
            // 
            // commandBarGalleryDropDown83
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown83.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup27.CommandName = "InsertChartScatterCommandGroup";
            spreadsheetCommandGalleryItem121.CommandName = "InsertChartScatterMarkers";
            spreadsheetCommandGalleryItem122.CommandName = "InsertChartScatterSmoothLinesAndMarkers";
            spreadsheetCommandGalleryItem123.CommandName = "InsertChartScatterSmoothLines";
            spreadsheetCommandGalleryItem124.CommandName = "InsertChartScatterLinesAndMarkers";
            spreadsheetCommandGalleryItem125.CommandName = "InsertChartScatterLines";
            spreadsheetCommandGalleryItemGroup27.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem121,
            spreadsheetCommandGalleryItem122,
            spreadsheetCommandGalleryItem123,
            spreadsheetCommandGalleryItem124,
            spreadsheetCommandGalleryItem125});
            spreadsheetCommandGalleryItemGroup28.CommandName = "InsertChartBubbleCommandGroup";
            spreadsheetCommandGalleryItem126.CommandName = "InsertChartBubble";
            spreadsheetCommandGalleryItem127.CommandName = "InsertChartBubble3D";
            spreadsheetCommandGalleryItemGroup28.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem126,
            spreadsheetCommandGalleryItem127});
            this.commandBarGalleryDropDown83.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup27,
            spreadsheetCommandGalleryItemGroup28});
            this.commandBarGalleryDropDown83.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown83.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown83.Name = "commandBarGalleryDropDown83";
            this.commandBarGalleryDropDown83.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem10
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.CommandName = "InsertChartStatisticCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.DropDownControl = this.commandBarGalleryDropDown84;
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.Id = 180;
            this.spreadsheetCommandBarButtonGalleryDropDownItem10.Name = "spreadsheetCommandBarButtonGalleryDropDownItem10";
            // 
            // commandBarGalleryDropDown84
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown84.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup29.CommandName = "InsertChartHistogramCommandGroup";
            spreadsheetCommandGalleryItem128.CommandName = "InsertChartHistogram";
            spreadsheetCommandGalleryItem129.CommandName = "InsertChartPareto";
            spreadsheetCommandGalleryItemGroup29.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem128,
            spreadsheetCommandGalleryItem129});
            spreadsheetCommandGalleryItemGroup30.CommandName = "InsertChartBoxAndWhiskerCommandGroup";
            spreadsheetCommandGalleryItem130.CommandName = "InsertChartBoxAndWhisker";
            spreadsheetCommandGalleryItemGroup30.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem130});
            this.commandBarGalleryDropDown84.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup29,
            spreadsheetCommandGalleryItemGroup30});
            this.commandBarGalleryDropDown84.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown84.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown84.Name = "commandBarGalleryDropDown84";
            this.commandBarGalleryDropDown84.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem11
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.CommandName = "InsertChartHierarchyCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.DropDownControl = this.commandBarGalleryDropDown85;
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.Id = 181;
            this.spreadsheetCommandBarButtonGalleryDropDownItem11.Name = "spreadsheetCommandBarButtonGalleryDropDownItem11";
            // 
            // commandBarGalleryDropDown85
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown85.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup31.CommandName = "InsertChartTreemapCommandGroup";
            spreadsheetCommandGalleryItem131.CommandName = "InsertChartTreemap";
            spreadsheetCommandGalleryItemGroup31.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem131});
            spreadsheetCommandGalleryItemGroup32.CommandName = "InsertChartSunburstCommandGroup";
            spreadsheetCommandGalleryItem132.CommandName = "InsertChartSunburst";
            spreadsheetCommandGalleryItemGroup32.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem132});
            this.commandBarGalleryDropDown85.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup31,
            spreadsheetCommandGalleryItemGroup32});
            this.commandBarGalleryDropDown85.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown85.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown85.Name = "commandBarGalleryDropDown85";
            this.commandBarGalleryDropDown85.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem12
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.CommandName = "InsertChartOtherCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.DropDownControl = this.commandBarGalleryDropDown86;
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.Id = 182;
            this.spreadsheetCommandBarButtonGalleryDropDownItem12.Name = "spreadsheetCommandBarButtonGalleryDropDownItem12";
            // 
            // commandBarGalleryDropDown86
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown86.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup33.CommandName = "InsertChartWaterfallCommandGroup";
            spreadsheetCommandGalleryItem133.CommandName = "InsertChartWaterfall";
            spreadsheetCommandGalleryItemGroup33.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem133});
            spreadsheetCommandGalleryItemGroup34.CommandName = "InsertChartFunnelCommandGroup";
            spreadsheetCommandGalleryItem134.CommandName = "InsertChartFunnel";
            spreadsheetCommandGalleryItemGroup34.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem134});
            spreadsheetCommandGalleryItemGroup35.CommandName = "InsertChartStockCommandGroup";
            spreadsheetCommandGalleryItem135.CommandName = "InsertChartStockHighLowClose";
            spreadsheetCommandGalleryItem136.CommandName = "InsertChartStockOpenHighLowClose";
            spreadsheetCommandGalleryItem137.CommandName = "InsertChartStockVolumeHighLowClose";
            spreadsheetCommandGalleryItem138.CommandName = "InsertChartStockVolumeOpenHighLowClose";
            spreadsheetCommandGalleryItemGroup35.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem135,
            spreadsheetCommandGalleryItem136,
            spreadsheetCommandGalleryItem137,
            spreadsheetCommandGalleryItem138});
            spreadsheetCommandGalleryItemGroup36.CommandName = "InsertChartRadarCommandGroup";
            spreadsheetCommandGalleryItem139.CommandName = "InsertChartRadar";
            spreadsheetCommandGalleryItem140.CommandName = "InsertChartRadarWithMarkers";
            spreadsheetCommandGalleryItem141.CommandName = "InsertChartRadarFilled";
            spreadsheetCommandGalleryItemGroup36.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem139,
            spreadsheetCommandGalleryItem140,
            spreadsheetCommandGalleryItem141});
            this.commandBarGalleryDropDown86.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup33,
            spreadsheetCommandGalleryItemGroup34,
            spreadsheetCommandGalleryItemGroup35,
            spreadsheetCommandGalleryItemGroup36});
            this.commandBarGalleryDropDown86.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown86.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown86.Name = "commandBarGalleryDropDown86";
            this.commandBarGalleryDropDown86.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonItem121
            // 
            this.spreadsheetCommandBarButtonItem121.CommandName = "InsertHyperlink";
            this.spreadsheetCommandBarButtonItem121.Id = 183;
            this.spreadsheetCommandBarButtonItem121.Name = "spreadsheetCommandBarButtonItem121";
            // 
            // spreadsheetCommandBarButtonItem122
            // 
            this.spreadsheetCommandBarButtonItem122.CommandName = "InsertSymbol";
            this.spreadsheetCommandBarButtonItem122.Id = 184;
            this.spreadsheetCommandBarButtonItem122.Name = "spreadsheetCommandBarButtonItem122";
            // 
            // spreadsheetCommandBarSubItem17
            // 
            this.spreadsheetCommandBarSubItem17.CommandName = "PageSetupMarginsCommandGroup";
            this.spreadsheetCommandBarSubItem17.Id = 185;
            this.spreadsheetCommandBarSubItem17.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem15),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem16),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem17),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem123)});
            this.spreadsheetCommandBarSubItem17.Name = "spreadsheetCommandBarSubItem17";
            // 
            // spreadsheetCommandBarCheckItem15
            // 
            this.spreadsheetCommandBarCheckItem15.CaptionDependOnUnits = true;
            this.spreadsheetCommandBarCheckItem15.CommandName = "PageSetupMarginsNormal";
            this.spreadsheetCommandBarCheckItem15.Id = 186;
            this.spreadsheetCommandBarCheckItem15.Name = "spreadsheetCommandBarCheckItem15";
            // 
            // spreadsheetCommandBarCheckItem16
            // 
            this.spreadsheetCommandBarCheckItem16.CaptionDependOnUnits = true;
            this.spreadsheetCommandBarCheckItem16.CommandName = "PageSetupMarginsWide";
            this.spreadsheetCommandBarCheckItem16.Id = 187;
            this.spreadsheetCommandBarCheckItem16.Name = "spreadsheetCommandBarCheckItem16";
            // 
            // spreadsheetCommandBarCheckItem17
            // 
            this.spreadsheetCommandBarCheckItem17.CaptionDependOnUnits = true;
            this.spreadsheetCommandBarCheckItem17.CommandName = "PageSetupMarginsNarrow";
            this.spreadsheetCommandBarCheckItem17.Id = 188;
            this.spreadsheetCommandBarCheckItem17.Name = "spreadsheetCommandBarCheckItem17";
            // 
            // spreadsheetCommandBarButtonItem123
            // 
            this.spreadsheetCommandBarButtonItem123.CommandName = "PageSetupCustomMargins";
            this.spreadsheetCommandBarButtonItem123.Id = 189;
            this.spreadsheetCommandBarButtonItem123.Name = "spreadsheetCommandBarButtonItem123";
            // 
            // spreadsheetCommandBarSubItem18
            // 
            this.spreadsheetCommandBarSubItem18.CommandName = "PageSetupOrientationCommandGroup";
            this.spreadsheetCommandBarSubItem18.Id = 190;
            this.spreadsheetCommandBarSubItem18.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem19)});
            this.spreadsheetCommandBarSubItem18.Name = "spreadsheetCommandBarSubItem18";
            // 
            // spreadsheetCommandBarCheckItem18
            // 
            this.spreadsheetCommandBarCheckItem18.CommandName = "PageSetupOrientationPortrait";
            this.spreadsheetCommandBarCheckItem18.Id = 191;
            this.spreadsheetCommandBarCheckItem18.Name = "spreadsheetCommandBarCheckItem18";
            // 
            // spreadsheetCommandBarCheckItem19
            // 
            this.spreadsheetCommandBarCheckItem19.CommandName = "PageSetupOrientationLandscape";
            this.spreadsheetCommandBarCheckItem19.Id = 192;
            this.spreadsheetCommandBarCheckItem19.Name = "spreadsheetCommandBarCheckItem19";
            // 
            // pageSetupPaperKindItem1
            // 
            this.pageSetupPaperKindItem1.Id = 193;
            this.pageSetupPaperKindItem1.Name = "pageSetupPaperKindItem1";
            // 
            // spreadsheetCommandBarSubItem19
            // 
            this.spreadsheetCommandBarSubItem19.CommandName = "PageSetupPrintAreaCommandGroup";
            this.spreadsheetCommandBarSubItem19.Id = 194;
            this.spreadsheetCommandBarSubItem19.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem124),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem125),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem126)});
            this.spreadsheetCommandBarSubItem19.Name = "spreadsheetCommandBarSubItem19";
            // 
            // spreadsheetCommandBarButtonItem124
            // 
            this.spreadsheetCommandBarButtonItem124.CommandName = "PageSetupSetPrintArea";
            this.spreadsheetCommandBarButtonItem124.Id = 195;
            this.spreadsheetCommandBarButtonItem124.Name = "spreadsheetCommandBarButtonItem124";
            // 
            // spreadsheetCommandBarButtonItem125
            // 
            this.spreadsheetCommandBarButtonItem125.CommandName = "PageSetupClearPrintArea";
            this.spreadsheetCommandBarButtonItem125.Id = 196;
            this.spreadsheetCommandBarButtonItem125.Name = "spreadsheetCommandBarButtonItem125";
            // 
            // spreadsheetCommandBarButtonItem126
            // 
            this.spreadsheetCommandBarButtonItem126.CommandName = "PageSetupAddPrintArea";
            this.spreadsheetCommandBarButtonItem126.Id = 197;
            this.spreadsheetCommandBarButtonItem126.Name = "spreadsheetCommandBarButtonItem126";
            // 
            // spreadsheetCommandBarButtonItem127
            // 
            this.spreadsheetCommandBarButtonItem127.CommandName = "PageSetupPrintTitles";
            this.spreadsheetCommandBarButtonItem127.Id = 198;
            this.spreadsheetCommandBarButtonItem127.Name = "spreadsheetCommandBarButtonItem127";
            // 
            // spreadsheetCommandBarCheckItem20
            // 
            this.spreadsheetCommandBarCheckItem20.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem20.CommandName = "ViewShowGridlines";
            this.spreadsheetCommandBarCheckItem20.Id = 199;
            this.spreadsheetCommandBarCheckItem20.Name = "spreadsheetCommandBarCheckItem20";
            // 
            // spreadsheetCommandBarCheckItem21
            // 
            this.spreadsheetCommandBarCheckItem21.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem21.CommandName = "ViewShowHeadings";
            this.spreadsheetCommandBarCheckItem21.Id = 200;
            this.spreadsheetCommandBarCheckItem21.Name = "spreadsheetCommandBarCheckItem21";
            // 
            // spreadsheetCommandBarCheckItem22
            // 
            this.spreadsheetCommandBarCheckItem22.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem22.CommandName = "PageSetupPrintGridlines";
            this.spreadsheetCommandBarCheckItem22.Id = 201;
            this.spreadsheetCommandBarCheckItem22.Name = "spreadsheetCommandBarCheckItem22";
            // 
            // spreadsheetCommandBarCheckItem23
            // 
            this.spreadsheetCommandBarCheckItem23.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem23.CommandName = "PageSetupPrintHeadings";
            this.spreadsheetCommandBarCheckItem23.Id = 202;
            this.spreadsheetCommandBarCheckItem23.Name = "spreadsheetCommandBarCheckItem23";
            // 
            // spreadsheetCommandBarSubItem20
            // 
            this.spreadsheetCommandBarSubItem20.CommandName = "ArrangeBringForwardCommandGroup";
            this.spreadsheetCommandBarSubItem20.Id = 203;
            this.spreadsheetCommandBarSubItem20.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem128),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem129)});
            this.spreadsheetCommandBarSubItem20.Name = "spreadsheetCommandBarSubItem20";
            // 
            // spreadsheetCommandBarButtonItem128
            // 
            this.spreadsheetCommandBarButtonItem128.CommandName = "ArrangeBringForward";
            this.spreadsheetCommandBarButtonItem128.Id = 204;
            this.spreadsheetCommandBarButtonItem128.Name = "spreadsheetCommandBarButtonItem128";
            // 
            // spreadsheetCommandBarButtonItem129
            // 
            this.spreadsheetCommandBarButtonItem129.CommandName = "ArrangeBringToFront";
            this.spreadsheetCommandBarButtonItem129.Id = 205;
            this.spreadsheetCommandBarButtonItem129.Name = "spreadsheetCommandBarButtonItem129";
            // 
            // spreadsheetCommandBarSubItem21
            // 
            this.spreadsheetCommandBarSubItem21.CommandName = "ArrangeSendBackwardCommandGroup";
            this.spreadsheetCommandBarSubItem21.Id = 206;
            this.spreadsheetCommandBarSubItem21.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem130),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem131)});
            this.spreadsheetCommandBarSubItem21.Name = "spreadsheetCommandBarSubItem21";
            // 
            // spreadsheetCommandBarButtonItem130
            // 
            this.spreadsheetCommandBarButtonItem130.CommandName = "ArrangeSendBackward";
            this.spreadsheetCommandBarButtonItem130.Id = 207;
            this.spreadsheetCommandBarButtonItem130.Name = "spreadsheetCommandBarButtonItem130";
            // 
            // spreadsheetCommandBarButtonItem131
            // 
            this.spreadsheetCommandBarButtonItem131.CommandName = "ArrangeSendToBack";
            this.spreadsheetCommandBarButtonItem131.Id = 208;
            this.spreadsheetCommandBarButtonItem131.Name = "spreadsheetCommandBarButtonItem131";
            // 
            // spreadsheetCommandBarSubItem22
            // 
            this.spreadsheetCommandBarSubItem22.CommandName = "FunctionsAutoSumCommandGroup";
            this.spreadsheetCommandBarSubItem22.Id = 209;
            this.spreadsheetCommandBarSubItem22.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem92),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem93),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem94),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem95),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem96)});
            this.spreadsheetCommandBarSubItem22.Name = "spreadsheetCommandBarSubItem22";
            // 
            // functionsFinancialItem1
            // 
            this.functionsFinancialItem1.Id = 210;
            this.functionsFinancialItem1.Name = "functionsFinancialItem1";
            // 
            // functionsLogicalItem1
            // 
            this.functionsLogicalItem1.Id = 211;
            this.functionsLogicalItem1.Name = "functionsLogicalItem1";
            // 
            // functionsTextItem1
            // 
            this.functionsTextItem1.Id = 212;
            this.functionsTextItem1.Name = "functionsTextItem1";
            // 
            // functionsDateAndTimeItem1
            // 
            this.functionsDateAndTimeItem1.Id = 213;
            this.functionsDateAndTimeItem1.Name = "functionsDateAndTimeItem1";
            // 
            // functionsLookupAndReferenceItem1
            // 
            this.functionsLookupAndReferenceItem1.Id = 214;
            this.functionsLookupAndReferenceItem1.Name = "functionsLookupAndReferenceItem1";
            // 
            // functionsMathAndTrigonometryItem1
            // 
            this.functionsMathAndTrigonometryItem1.Id = 215;
            this.functionsMathAndTrigonometryItem1.Name = "functionsMathAndTrigonometryItem1";
            // 
            // spreadsheetCommandBarSubItem23
            // 
            this.spreadsheetCommandBarSubItem23.CommandName = "FunctionsMoreCommandGroup";
            this.spreadsheetCommandBarSubItem23.Id = 216;
            this.spreadsheetCommandBarSubItem23.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.functionsStatisticalItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.functionsEngineeringItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.functionsInformationItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.functionsCompatibilityItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.functionsWebItem1)});
            this.spreadsheetCommandBarSubItem23.Name = "spreadsheetCommandBarSubItem23";
            // 
            // functionsStatisticalItem1
            // 
            this.functionsStatisticalItem1.Id = 217;
            this.functionsStatisticalItem1.Name = "functionsStatisticalItem1";
            // 
            // functionsEngineeringItem1
            // 
            this.functionsEngineeringItem1.Id = 218;
            this.functionsEngineeringItem1.Name = "functionsEngineeringItem1";
            // 
            // functionsInformationItem1
            // 
            this.functionsInformationItem1.Id = 219;
            this.functionsInformationItem1.Name = "functionsInformationItem1";
            // 
            // functionsCompatibilityItem1
            // 
            this.functionsCompatibilityItem1.Id = 220;
            this.functionsCompatibilityItem1.Name = "functionsCompatibilityItem1";
            // 
            // functionsWebItem1
            // 
            this.functionsWebItem1.Id = 221;
            this.functionsWebItem1.Name = "functionsWebItem1";
            // 
            // spreadsheetCommandBarButtonItem132
            // 
            this.spreadsheetCommandBarButtonItem132.CommandName = "FormulasShowNameManager";
            this.spreadsheetCommandBarButtonItem132.Id = 222;
            this.spreadsheetCommandBarButtonItem132.Name = "spreadsheetCommandBarButtonItem132";
            // 
            // spreadsheetCommandBarButtonItem133
            // 
            this.spreadsheetCommandBarButtonItem133.CommandName = "FormulasDefineNameCommand";
            this.spreadsheetCommandBarButtonItem133.Id = 223;
            this.spreadsheetCommandBarButtonItem133.Name = "spreadsheetCommandBarButtonItem133";
            this.spreadsheetCommandBarButtonItem133.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // definedNameListItem1
            // 
            this.definedNameListItem1.Id = 224;
            this.definedNameListItem1.Name = "definedNameListItem1";
            this.definedNameListItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem134
            // 
            this.spreadsheetCommandBarButtonItem134.CommandName = "FormulasCreateDefinedNamesFromSelection";
            this.spreadsheetCommandBarButtonItem134.Id = 225;
            this.spreadsheetCommandBarButtonItem134.Name = "spreadsheetCommandBarButtonItem134";
            this.spreadsheetCommandBarButtonItem134.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem24
            // 
            this.spreadsheetCommandBarCheckItem24.CommandName = "ViewShowFormulas";
            this.spreadsheetCommandBarCheckItem24.Id = 226;
            this.spreadsheetCommandBarCheckItem24.Name = "spreadsheetCommandBarCheckItem24";
            // 
            // spreadsheetCommandBarSubItem24
            // 
            this.spreadsheetCommandBarSubItem24.CommandName = "FormulasCalculationOptionsCommandGroup";
            this.spreadsheetCommandBarSubItem24.Id = 227;
            this.spreadsheetCommandBarSubItem24.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem25),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem26)});
            this.spreadsheetCommandBarSubItem24.Name = "spreadsheetCommandBarSubItem24";
            // 
            // spreadsheetCommandBarCheckItem25
            // 
            this.spreadsheetCommandBarCheckItem25.CommandName = "FormulasCalculationModeAutomatic";
            this.spreadsheetCommandBarCheckItem25.Id = 228;
            this.spreadsheetCommandBarCheckItem25.Name = "spreadsheetCommandBarCheckItem25";
            // 
            // spreadsheetCommandBarCheckItem26
            // 
            this.spreadsheetCommandBarCheckItem26.CommandName = "FormulasCalculationModeManual";
            this.spreadsheetCommandBarCheckItem26.Id = 229;
            this.spreadsheetCommandBarCheckItem26.Name = "spreadsheetCommandBarCheckItem26";
            // 
            // spreadsheetCommandBarButtonItem135
            // 
            this.spreadsheetCommandBarButtonItem135.CommandName = "FormulasCalculateNow";
            this.spreadsheetCommandBarButtonItem135.Id = 230;
            this.spreadsheetCommandBarButtonItem135.Name = "spreadsheetCommandBarButtonItem135";
            this.spreadsheetCommandBarButtonItem135.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem136
            // 
            this.spreadsheetCommandBarButtonItem136.CommandName = "FormulasCalculateSheet";
            this.spreadsheetCommandBarButtonItem136.Id = 231;
            this.spreadsheetCommandBarButtonItem136.Name = "spreadsheetCommandBarButtonItem136";
            this.spreadsheetCommandBarButtonItem136.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarSubItem25
            // 
            this.spreadsheetCommandBarSubItem25.CommandName = "DataToolsDataValidationCommandGroup";
            this.spreadsheetCommandBarSubItem25.Id = 232;
            this.spreadsheetCommandBarSubItem25.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem137),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem138),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem139)});
            this.spreadsheetCommandBarSubItem25.Name = "spreadsheetCommandBarSubItem25";
            // 
            // spreadsheetCommandBarButtonItem137
            // 
            this.spreadsheetCommandBarButtonItem137.CommandName = "DataToolsDataValidation";
            this.spreadsheetCommandBarButtonItem137.Id = 233;
            this.spreadsheetCommandBarButtonItem137.Name = "spreadsheetCommandBarButtonItem137";
            // 
            // spreadsheetCommandBarButtonItem138
            // 
            this.spreadsheetCommandBarButtonItem138.CommandName = "DataToolsCircleInvalidData";
            this.spreadsheetCommandBarButtonItem138.Id = 234;
            this.spreadsheetCommandBarButtonItem138.Name = "spreadsheetCommandBarButtonItem138";
            // 
            // spreadsheetCommandBarButtonItem139
            // 
            this.spreadsheetCommandBarButtonItem139.CommandName = "DataToolsClearValidationCircles";
            this.spreadsheetCommandBarButtonItem139.Id = 235;
            this.spreadsheetCommandBarButtonItem139.Name = "spreadsheetCommandBarButtonItem139";
            // 
            // spreadsheetCommandBarSubItem26
            // 
            this.spreadsheetCommandBarSubItem26.CommandName = "OutlineGroupCommandGroup";
            this.spreadsheetCommandBarSubItem26.Id = 236;
            this.spreadsheetCommandBarSubItem26.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem140),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem141)});
            this.spreadsheetCommandBarSubItem26.Name = "spreadsheetCommandBarSubItem26";
            this.spreadsheetCommandBarSubItem26.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem140
            // 
            this.spreadsheetCommandBarButtonItem140.CommandName = "GroupOutline";
            this.spreadsheetCommandBarButtonItem140.Id = 237;
            this.spreadsheetCommandBarButtonItem140.Name = "spreadsheetCommandBarButtonItem140";
            // 
            // spreadsheetCommandBarButtonItem141
            // 
            this.spreadsheetCommandBarButtonItem141.CommandName = "AutoOutline";
            this.spreadsheetCommandBarButtonItem141.Id = 238;
            this.spreadsheetCommandBarButtonItem141.Name = "spreadsheetCommandBarButtonItem141";
            // 
            // spreadsheetCommandBarSubItem27
            // 
            this.spreadsheetCommandBarSubItem27.CommandName = "OutlineUngroupCommandGroup";
            this.spreadsheetCommandBarSubItem27.Id = 239;
            this.spreadsheetCommandBarSubItem27.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem142),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem143)});
            this.spreadsheetCommandBarSubItem27.Name = "spreadsheetCommandBarSubItem27";
            this.spreadsheetCommandBarSubItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem142
            // 
            this.spreadsheetCommandBarButtonItem142.CommandName = "UngroupOutline";
            this.spreadsheetCommandBarButtonItem142.Id = 240;
            this.spreadsheetCommandBarButtonItem142.Name = "spreadsheetCommandBarButtonItem142";
            // 
            // spreadsheetCommandBarButtonItem143
            // 
            this.spreadsheetCommandBarButtonItem143.CommandName = "ClearOutline";
            this.spreadsheetCommandBarButtonItem143.Id = 241;
            this.spreadsheetCommandBarButtonItem143.Name = "spreadsheetCommandBarButtonItem143";
            // 
            // spreadsheetCommandBarButtonItem144
            // 
            this.spreadsheetCommandBarButtonItem144.CommandName = "Subtotal";
            this.spreadsheetCommandBarButtonItem144.Id = 242;
            this.spreadsheetCommandBarButtonItem144.Name = "spreadsheetCommandBarButtonItem144";
            this.spreadsheetCommandBarButtonItem144.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem145
            // 
            this.spreadsheetCommandBarButtonItem145.CommandName = "ShowDetail";
            this.spreadsheetCommandBarButtonItem145.Id = 243;
            this.spreadsheetCommandBarButtonItem145.Name = "spreadsheetCommandBarButtonItem145";
            this.spreadsheetCommandBarButtonItem145.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem146
            // 
            this.spreadsheetCommandBarButtonItem146.CommandName = "HideDetail";
            this.spreadsheetCommandBarButtonItem146.Id = 244;
            this.spreadsheetCommandBarButtonItem146.Name = "spreadsheetCommandBarButtonItem146";
            this.spreadsheetCommandBarButtonItem146.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem147
            // 
            this.spreadsheetCommandBarButtonItem147.CommandName = "ReviewInsertComment";
            this.spreadsheetCommandBarButtonItem147.Id = 245;
            this.spreadsheetCommandBarButtonItem147.Name = "spreadsheetCommandBarButtonItem147";
            // 
            // spreadsheetCommandBarButtonItem148
            // 
            this.spreadsheetCommandBarButtonItem148.CommandName = "ReviewEditComment";
            this.spreadsheetCommandBarButtonItem148.Id = 246;
            this.spreadsheetCommandBarButtonItem148.Name = "spreadsheetCommandBarButtonItem148";
            // 
            // spreadsheetCommandBarButtonItem149
            // 
            this.spreadsheetCommandBarButtonItem149.CommandName = "ReviewDeleteComment";
            this.spreadsheetCommandBarButtonItem149.Id = 247;
            this.spreadsheetCommandBarButtonItem149.Name = "spreadsheetCommandBarButtonItem149";
            // 
            // spreadsheetCommandBarButtonItem150
            // 
            this.spreadsheetCommandBarButtonItem150.CommandName = "ReviewShowHideComment";
            this.spreadsheetCommandBarButtonItem150.Id = 248;
            this.spreadsheetCommandBarButtonItem150.Name = "spreadsheetCommandBarButtonItem150";
            this.spreadsheetCommandBarButtonItem150.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem151
            // 
            this.spreadsheetCommandBarButtonItem151.CommandName = "ReviewUnprotectSheet";
            this.spreadsheetCommandBarButtonItem151.Id = 249;
            this.spreadsheetCommandBarButtonItem151.Name = "spreadsheetCommandBarButtonItem151";
            // 
            // spreadsheetCommandBarButtonItem152
            // 
            this.spreadsheetCommandBarButtonItem152.CommandName = "ReviewProtectWorkbook";
            this.spreadsheetCommandBarButtonItem152.Id = 250;
            this.spreadsheetCommandBarButtonItem152.Name = "spreadsheetCommandBarButtonItem152";
            // 
            // spreadsheetCommandBarButtonItem153
            // 
            this.spreadsheetCommandBarButtonItem153.CommandName = "ReviewUnprotectWorkbook";
            this.spreadsheetCommandBarButtonItem153.Id = 251;
            this.spreadsheetCommandBarButtonItem153.Name = "spreadsheetCommandBarButtonItem153";
            // 
            // spreadsheetCommandBarButtonItem154
            // 
            this.spreadsheetCommandBarButtonItem154.CommandName = "ReviewShowProtectedRangeManager";
            this.spreadsheetCommandBarButtonItem154.Id = 252;
            this.spreadsheetCommandBarButtonItem154.Name = "spreadsheetCommandBarButtonItem154";
            // 
            // spreadsheetCommandBarButtonItem155
            // 
            this.spreadsheetCommandBarButtonItem155.CommandName = "ViewZoom";
            this.spreadsheetCommandBarButtonItem155.Id = 253;
            this.spreadsheetCommandBarButtonItem155.Name = "spreadsheetCommandBarButtonItem155";
            // 
            // spreadsheetCommandBarButtonItem156
            // 
            this.spreadsheetCommandBarButtonItem156.CommandName = "ViewZoomOut";
            this.spreadsheetCommandBarButtonItem156.Id = 254;
            this.spreadsheetCommandBarButtonItem156.Name = "spreadsheetCommandBarButtonItem156";
            // 
            // spreadsheetCommandBarButtonItem157
            // 
            this.spreadsheetCommandBarButtonItem157.CommandName = "ViewZoomIn";
            this.spreadsheetCommandBarButtonItem157.Id = 255;
            this.spreadsheetCommandBarButtonItem157.Name = "spreadsheetCommandBarButtonItem157";
            // 
            // spreadsheetCommandBarButtonItem158
            // 
            this.spreadsheetCommandBarButtonItem158.CommandName = "ViewZoom100Percent";
            this.spreadsheetCommandBarButtonItem158.Id = 256;
            this.spreadsheetCommandBarButtonItem158.Name = "spreadsheetCommandBarButtonItem158";
            // 
            // spreadsheetCommandBarSubItem28
            // 
            this.spreadsheetCommandBarSubItem28.CommandName = "ViewFreezePanesCommandGroup";
            this.spreadsheetCommandBarSubItem28.Id = 257;
            this.spreadsheetCommandBarSubItem28.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem159),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem160),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem161),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem162)});
            this.spreadsheetCommandBarSubItem28.Name = "spreadsheetCommandBarSubItem28";
            // 
            // spreadsheetCommandBarButtonItem159
            // 
            this.spreadsheetCommandBarButtonItem159.CommandName = "ViewFreezePanes";
            this.spreadsheetCommandBarButtonItem159.Id = 258;
            this.spreadsheetCommandBarButtonItem159.Name = "spreadsheetCommandBarButtonItem159";
            // 
            // spreadsheetCommandBarButtonItem160
            // 
            this.spreadsheetCommandBarButtonItem160.CommandName = "ViewUnfreezePanes";
            this.spreadsheetCommandBarButtonItem160.Id = 259;
            this.spreadsheetCommandBarButtonItem160.Name = "spreadsheetCommandBarButtonItem160";
            // 
            // spreadsheetCommandBarButtonItem161
            // 
            this.spreadsheetCommandBarButtonItem161.CommandName = "ViewFreezeTopRow";
            this.spreadsheetCommandBarButtonItem161.Id = 260;
            this.spreadsheetCommandBarButtonItem161.Name = "spreadsheetCommandBarButtonItem161";
            // 
            // spreadsheetCommandBarButtonItem162
            // 
            this.spreadsheetCommandBarButtonItem162.CommandName = "ViewFreezeFirstColumn";
            this.spreadsheetCommandBarButtonItem162.Id = 261;
            this.spreadsheetCommandBarButtonItem162.Name = "spreadsheetCommandBarButtonItem162";
            // 
            // spreadsheetCommandBarButtonItem163
            // 
            this.spreadsheetCommandBarButtonItem163.CommandName = "ChartChangeType";
            this.spreadsheetCommandBarButtonItem163.Id = 262;
            this.spreadsheetCommandBarButtonItem163.Name = "spreadsheetCommandBarButtonItem163";
            // 
            // spreadsheetCommandBarButtonItem164
            // 
            this.spreadsheetCommandBarButtonItem164.CommandName = "ChartSwitchRowColumn";
            this.spreadsheetCommandBarButtonItem164.Id = 263;
            this.spreadsheetCommandBarButtonItem164.Name = "spreadsheetCommandBarButtonItem164";
            // 
            // spreadsheetCommandBarButtonItem165
            // 
            this.spreadsheetCommandBarButtonItem165.CommandName = "ChartSelectData";
            this.spreadsheetCommandBarButtonItem165.Id = 264;
            this.spreadsheetCommandBarButtonItem165.Name = "spreadsheetCommandBarButtonItem165";
            // 
            // galleryChartLayoutItem1
            // 
            // 
            // 
            // 
            this.galleryChartLayoutItem1.Gallery.ColumnCount = 6;
            this.galleryChartLayoutItem1.Gallery.DrawImageBackground = false;
            this.galleryChartLayoutItem1.Gallery.ImageSize = new System.Drawing.Size(48, 48);
            this.galleryChartLayoutItem1.Gallery.RowCount = 2;
            this.galleryChartLayoutItem1.Id = 265;
            this.galleryChartLayoutItem1.Name = "galleryChartLayoutItem1";
            // 
            // galleryChartStyleItem1
            // 
            // 
            // 
            // 
            this.galleryChartStyleItem1.Gallery.ColumnCount = 8;
            this.galleryChartStyleItem1.Gallery.DrawImageBackground = false;
            this.galleryChartStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryChartStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.galleryChartStyleItem1.Gallery.ItemSize = new System.Drawing.Size(93, 56);
            this.galleryChartStyleItem1.Gallery.MinimumColumnCount = 4;
            this.galleryChartStyleItem1.Gallery.RowCount = 6;
            this.galleryChartStyleItem1.Id = 266;
            this.galleryChartStyleItem1.Name = "galleryChartStyleItem1";
            // 
            // spreadsheetCommandBarButtonItem166
            // 
            this.spreadsheetCommandBarButtonItem166.CommandName = "MoveChart";
            this.spreadsheetCommandBarButtonItem166.Id = 267;
            this.spreadsheetCommandBarButtonItem166.Name = "spreadsheetCommandBarButtonItem166";
            // 
            // spreadsheetCommandBarSubItem29
            // 
            this.spreadsheetCommandBarSubItem29.CommandName = "ChartAxesCommandGroup";
            this.spreadsheetCommandBarSubItem29.Id = 268;
            this.spreadsheetCommandBarSubItem29.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem14)});
            this.spreadsheetCommandBarSubItem29.Name = "spreadsheetCommandBarSubItem29";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem13
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.DropDownControl = this.commandBarGalleryDropDown87;
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.Id = 269;
            this.spreadsheetCommandBarButtonGalleryDropDownItem13.Name = "spreadsheetCommandBarButtonGalleryDropDownItem13";
            // 
            // commandBarGalleryDropDown87
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown87.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown87.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup37.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            spreadsheetCommandGalleryItem142.CommandName = "ChartHidePrimaryHorizontalAxis";
            spreadsheetCommandGalleryItem143.CommandName = "ChartPrimaryHorizontalAxisLeftToRight";
            spreadsheetCommandGalleryItem144.CommandName = "ChartPrimaryHorizontalAxisHideLabels";
            spreadsheetCommandGalleryItem145.CommandName = "ChartPrimaryHorizontalAxisRightToLeft";
            spreadsheetCommandGalleryItem146.CommandName = "ChartPrimaryHorizontalAxisDefault";
            spreadsheetCommandGalleryItem147.CommandName = "ChartPrimaryHorizontalAxisScaleThousands";
            spreadsheetCommandGalleryItem148.CommandName = "ChartPrimaryHorizontalAxisScaleMillions";
            spreadsheetCommandGalleryItem149.CommandName = "ChartPrimaryHorizontalAxisScaleBillions";
            spreadsheetCommandGalleryItem150.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm";
            spreadsheetCommandGalleryItemGroup37.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem142,
            spreadsheetCommandGalleryItem143,
            spreadsheetCommandGalleryItem144,
            spreadsheetCommandGalleryItem145,
            spreadsheetCommandGalleryItem146,
            spreadsheetCommandGalleryItem147,
            spreadsheetCommandGalleryItem148,
            spreadsheetCommandGalleryItem149,
            spreadsheetCommandGalleryItem150});
            this.commandBarGalleryDropDown87.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup37});
            this.commandBarGalleryDropDown87.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown87.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown87.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown87.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown87.Name = "commandBarGalleryDropDown87";
            this.commandBarGalleryDropDown87.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem14
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.DropDownControl = this.commandBarGalleryDropDown88;
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.Id = 270;
            this.spreadsheetCommandBarButtonGalleryDropDownItem14.Name = "spreadsheetCommandBarButtonGalleryDropDownItem14";
            // 
            // commandBarGalleryDropDown88
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown88.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown88.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup38.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            spreadsheetCommandGalleryItem151.CommandName = "ChartHidePrimaryVerticalAxis";
            spreadsheetCommandGalleryItem152.CommandName = "ChartPrimaryVerticalAxisLeftToRight";
            spreadsheetCommandGalleryItem153.CommandName = "ChartPrimaryVerticalAxisHideLabels";
            spreadsheetCommandGalleryItem154.CommandName = "ChartPrimaryVerticalAxisRightToLeft";
            spreadsheetCommandGalleryItem155.CommandName = "ChartPrimaryVerticalAxisDefault";
            spreadsheetCommandGalleryItem156.CommandName = "ChartPrimaryVerticalAxisScaleThousands";
            spreadsheetCommandGalleryItem157.CommandName = "ChartPrimaryVerticalAxisScaleMillions";
            spreadsheetCommandGalleryItem158.CommandName = "ChartPrimaryVerticalAxisScaleBillions";
            spreadsheetCommandGalleryItem159.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm";
            spreadsheetCommandGalleryItemGroup38.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem151,
            spreadsheetCommandGalleryItem152,
            spreadsheetCommandGalleryItem153,
            spreadsheetCommandGalleryItem154,
            spreadsheetCommandGalleryItem155,
            spreadsheetCommandGalleryItem156,
            spreadsheetCommandGalleryItem157,
            spreadsheetCommandGalleryItem158,
            spreadsheetCommandGalleryItem159});
            this.commandBarGalleryDropDown88.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup38});
            this.commandBarGalleryDropDown88.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown88.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown88.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown88.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown88.Name = "commandBarGalleryDropDown88";
            this.commandBarGalleryDropDown88.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarSubItem30
            // 
            this.spreadsheetCommandBarSubItem30.CommandName = "ChartGridlinesCommandGroup";
            this.spreadsheetCommandBarSubItem30.Id = 271;
            this.spreadsheetCommandBarSubItem30.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem15),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem16)});
            this.spreadsheetCommandBarSubItem30.Name = "spreadsheetCommandBarSubItem30";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem15
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.DropDownControl = this.commandBarGalleryDropDown89;
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.Id = 272;
            this.spreadsheetCommandBarButtonGalleryDropDownItem15.Name = "spreadsheetCommandBarButtonGalleryDropDownItem15";
            // 
            // commandBarGalleryDropDown89
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown89.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown89.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup39.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem160.CommandName = "ChartPrimaryHorizontalGridlinesNone";
            spreadsheetCommandGalleryItem161.CommandName = "ChartPrimaryHorizontalGridlinesMajor";
            spreadsheetCommandGalleryItem162.CommandName = "ChartPrimaryHorizontalGridlinesMinor";
            spreadsheetCommandGalleryItem163.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItemGroup39.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem160,
            spreadsheetCommandGalleryItem161,
            spreadsheetCommandGalleryItem162,
            spreadsheetCommandGalleryItem163});
            this.commandBarGalleryDropDown89.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup39});
            this.commandBarGalleryDropDown89.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown89.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown89.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown89.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown89.Name = "commandBarGalleryDropDown89";
            this.commandBarGalleryDropDown89.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem16
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.DropDownControl = this.commandBarGalleryDropDown90;
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.Id = 273;
            this.spreadsheetCommandBarButtonGalleryDropDownItem16.Name = "spreadsheetCommandBarButtonGalleryDropDownItem16";
            // 
            // commandBarGalleryDropDown90
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown90.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown90.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup40.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem164.CommandName = "ChartPrimaryVerticalGridlinesNone";
            spreadsheetCommandGalleryItem165.CommandName = "ChartPrimaryVerticalGridlinesMajor";
            spreadsheetCommandGalleryItem166.CommandName = "ChartPrimaryVerticalGridlinesMinor";
            spreadsheetCommandGalleryItem167.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItemGroup40.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem164,
            spreadsheetCommandGalleryItem165,
            spreadsheetCommandGalleryItem166,
            spreadsheetCommandGalleryItem167});
            this.commandBarGalleryDropDown90.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup40});
            this.commandBarGalleryDropDown90.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown90.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown90.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown90.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown90.Name = "commandBarGalleryDropDown90";
            this.commandBarGalleryDropDown90.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem17
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.CommandName = "ChartTitleCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.DropDownControl = this.commandBarGalleryDropDown91;
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.Id = 274;
            this.spreadsheetCommandBarButtonGalleryDropDownItem17.Name = "spreadsheetCommandBarButtonGalleryDropDownItem17";
            // 
            // commandBarGalleryDropDown91
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown91.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown91.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup41.CommandName = "ChartTitleCommandGroup";
            spreadsheetCommandGalleryItem168.CommandName = "ChartTitleNone";
            spreadsheetCommandGalleryItem169.CommandName = "ChartTitleCenteredOverlay";
            spreadsheetCommandGalleryItem170.CommandName = "ChartTitleAbove";
            spreadsheetCommandGalleryItemGroup41.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem168,
            spreadsheetCommandGalleryItem169,
            spreadsheetCommandGalleryItem170});
            this.commandBarGalleryDropDown91.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup41});
            this.commandBarGalleryDropDown91.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown91.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown91.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown91.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown91.Name = "commandBarGalleryDropDown91";
            this.commandBarGalleryDropDown91.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarSubItem31
            // 
            this.spreadsheetCommandBarSubItem31.CommandName = "ChartAxisTitlesCommandGroup";
            this.spreadsheetCommandBarSubItem31.Id = 275;
            this.spreadsheetCommandBarSubItem31.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonGalleryDropDownItem19)});
            this.spreadsheetCommandBarSubItem31.Name = "spreadsheetCommandBarSubItem31";
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem18
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.DropDownControl = this.commandBarGalleryDropDown92;
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.Id = 276;
            this.spreadsheetCommandBarButtonGalleryDropDownItem18.Name = "spreadsheetCommandBarButtonGalleryDropDownItem18";
            // 
            // commandBarGalleryDropDown92
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown92.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown92.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup42.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem171.CommandName = "ChartPrimaryHorizontalAxisTitleNone";
            spreadsheetCommandGalleryItem172.CommandName = "ChartPrimaryHorizontalAxisTitleBelow";
            spreadsheetCommandGalleryItemGroup42.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem171,
            spreadsheetCommandGalleryItem172});
            this.commandBarGalleryDropDown92.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup42});
            this.commandBarGalleryDropDown92.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown92.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown92.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown92.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown92.Name = "commandBarGalleryDropDown92";
            this.commandBarGalleryDropDown92.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem19
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.DropDownControl = this.commandBarGalleryDropDown93;
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.Id = 277;
            this.spreadsheetCommandBarButtonGalleryDropDownItem19.Name = "spreadsheetCommandBarButtonGalleryDropDownItem19";
            // 
            // commandBarGalleryDropDown93
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown93.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown93.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup43.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem173.CommandName = "ChartPrimaryVerticalAxisTitleNone";
            spreadsheetCommandGalleryItem174.CommandName = "ChartPrimaryVerticalAxisTitleRotated";
            spreadsheetCommandGalleryItemGroup43.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem173,
            spreadsheetCommandGalleryItem174});
            this.commandBarGalleryDropDown93.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup43});
            this.commandBarGalleryDropDown93.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown93.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown93.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown93.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown93.Name = "commandBarGalleryDropDown93";
            this.commandBarGalleryDropDown93.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem20
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.CommandName = "ChartLegendCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.DropDownControl = this.commandBarGalleryDropDown94;
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.Id = 278;
            this.spreadsheetCommandBarButtonGalleryDropDownItem20.Name = "spreadsheetCommandBarButtonGalleryDropDownItem20";
            // 
            // commandBarGalleryDropDown94
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown94.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown94.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup44.CommandName = "ChartLegendCommandGroup";
            spreadsheetCommandGalleryItem177.CommandName = "ChartLegendNone";
            spreadsheetCommandGalleryItem178.CommandName = "ChartLegendAtRight";
            spreadsheetCommandGalleryItem179.CommandName = "ChartLegendAtTop";
            spreadsheetCommandGalleryItem180.CommandName = "ChartLegendAtLeft";
            spreadsheetCommandGalleryItem181.CommandName = "ChartLegendAtBottom";
            spreadsheetCommandGalleryItem182.CommandName = "ChartLegendOverlayAtRight";
            spreadsheetCommandGalleryItem183.CommandName = "ChartLegendOverlayAtLeft";
            spreadsheetCommandGalleryItemGroup44.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem177,
            spreadsheetCommandGalleryItem178,
            spreadsheetCommandGalleryItem179,
            spreadsheetCommandGalleryItem180,
            spreadsheetCommandGalleryItem181,
            spreadsheetCommandGalleryItem182,
            spreadsheetCommandGalleryItem183});
            this.commandBarGalleryDropDown94.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup44});
            this.commandBarGalleryDropDown94.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown94.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown94.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown94.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown94.Name = "commandBarGalleryDropDown94";
            this.commandBarGalleryDropDown94.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem21
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.CommandName = "ChartDataLabelsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.DropDownControl = this.commandBarGalleryDropDown95;
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.Id = 279;
            this.spreadsheetCommandBarButtonGalleryDropDownItem21.Name = "spreadsheetCommandBarButtonGalleryDropDownItem21";
            // 
            // commandBarGalleryDropDown95
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown95.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown95.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup45.CommandName = "ChartDataLabelsCommandGroup";
            spreadsheetCommandGalleryItem184.CommandName = "ChartDataLabelsNone";
            spreadsheetCommandGalleryItem185.CommandName = "ChartDataLabelsDefault";
            spreadsheetCommandGalleryItem186.CommandName = "ChartDataLabelsCenter";
            spreadsheetCommandGalleryItem187.CommandName = "ChartDataLabelsInsideEnd";
            spreadsheetCommandGalleryItem188.CommandName = "ChartDataLabelsInsideBase";
            spreadsheetCommandGalleryItem189.CommandName = "ChartDataLabelsOutsideEnd";
            spreadsheetCommandGalleryItem190.CommandName = "ChartDataLabelsBestFit";
            spreadsheetCommandGalleryItem191.CommandName = "ChartDataLabelsLeft";
            spreadsheetCommandGalleryItem192.CommandName = "ChartDataLabelsRight";
            spreadsheetCommandGalleryItem193.CommandName = "ChartDataLabelsAbove";
            spreadsheetCommandGalleryItem194.CommandName = "ChartDataLabelsBelow";
            spreadsheetCommandGalleryItemGroup45.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem184,
            spreadsheetCommandGalleryItem185,
            spreadsheetCommandGalleryItem186,
            spreadsheetCommandGalleryItem187,
            spreadsheetCommandGalleryItem188,
            spreadsheetCommandGalleryItem189,
            spreadsheetCommandGalleryItem190,
            spreadsheetCommandGalleryItem191,
            spreadsheetCommandGalleryItem192,
            spreadsheetCommandGalleryItem193,
            spreadsheetCommandGalleryItem194});
            this.commandBarGalleryDropDown95.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup45});
            this.commandBarGalleryDropDown95.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown95.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown95.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown95.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown95.Name = "commandBarGalleryDropDown95";
            this.commandBarGalleryDropDown95.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem22
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.CommandName = "ChartLinesCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.DropDownControl = this.commandBarGalleryDropDown96;
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.Id = 280;
            this.spreadsheetCommandBarButtonGalleryDropDownItem22.Name = "spreadsheetCommandBarButtonGalleryDropDownItem22";
            // 
            // commandBarGalleryDropDown96
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown96.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown96.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup46.CommandName = "ChartLinesCommandGroup";
            spreadsheetCommandGalleryItem195.CommandName = "ChartLinesNone";
            spreadsheetCommandGalleryItem196.CommandName = "ChartShowDropLines";
            spreadsheetCommandGalleryItem197.CommandName = "ChartShowHighLowLines";
            spreadsheetCommandGalleryItem198.CommandName = "ChartShowDropLinesAndHighLowLines";
            spreadsheetCommandGalleryItem199.CommandName = "ChartShowSeriesLines";
            spreadsheetCommandGalleryItemGroup46.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem195,
            spreadsheetCommandGalleryItem196,
            spreadsheetCommandGalleryItem197,
            spreadsheetCommandGalleryItem198,
            spreadsheetCommandGalleryItem199});
            this.commandBarGalleryDropDown96.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup46});
            this.commandBarGalleryDropDown96.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown96.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown96.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown96.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown96.Name = "commandBarGalleryDropDown96";
            this.commandBarGalleryDropDown96.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem23
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem23.CommandName = "ChartUpDownBarsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem23.DropDownControl = this.commandBarGalleryDropDown97;
            this.spreadsheetCommandBarButtonGalleryDropDownItem23.Id = 281;
            this.spreadsheetCommandBarButtonGalleryDropDownItem23.Name = "spreadsheetCommandBarButtonGalleryDropDownItem23";
            // 
            // commandBarGalleryDropDown97
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown97.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown97.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup47.CommandName = "ChartUpDownBarsCommandGroup";
            spreadsheetCommandGalleryItem200.CommandName = "ChartHideUpDownBars";
            spreadsheetCommandGalleryItem201.CommandName = "ChartShowUpDownBars";
            spreadsheetCommandGalleryItemGroup47.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem200,
            spreadsheetCommandGalleryItem201});
            this.commandBarGalleryDropDown97.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup47});
            this.commandBarGalleryDropDown97.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown97.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown97.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown97.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown97.Name = "commandBarGalleryDropDown97";
            this.commandBarGalleryDropDown97.Ribbon = this.ribbonControl1;
            // 
            // spreadsheetCommandBarButtonGalleryDropDownItem24
            // 
            this.spreadsheetCommandBarButtonGalleryDropDownItem24.CommandName = "ChartErrorBarsCommandGroup";
            this.spreadsheetCommandBarButtonGalleryDropDownItem24.DropDownControl = this.commandBarGalleryDropDown98;
            this.spreadsheetCommandBarButtonGalleryDropDownItem24.Id = 282;
            this.spreadsheetCommandBarButtonGalleryDropDownItem24.Name = "spreadsheetCommandBarButtonGalleryDropDownItem24";
            // 
            // commandBarGalleryDropDown98
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown98.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown98.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical;
            spreadsheetCommandGalleryItemGroup48.CommandName = "ChartErrorBarsCommandGroup";
            spreadsheetCommandGalleryItem202.CommandName = "ChartErrorBarsNone";
            spreadsheetCommandGalleryItem203.CommandName = "ChartErrorBarsStandardError";
            spreadsheetCommandGalleryItem204.CommandName = "ChartErrorBarsPercentage";
            spreadsheetCommandGalleryItem205.CommandName = "ChartErrorBarsStandardDeviation";
            spreadsheetCommandGalleryItemGroup48.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem202,
            spreadsheetCommandGalleryItem203,
            spreadsheetCommandGalleryItem204,
            spreadsheetCommandGalleryItem205});
            this.commandBarGalleryDropDown98.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup48});
            this.commandBarGalleryDropDown98.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown98.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown98.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown98.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown98.Name = "commandBarGalleryDropDown98";
            this.commandBarGalleryDropDown98.Ribbon = this.ribbonControl1;
            // 
            // renameTableItemCaption1
            // 
            this.renameTableItemCaption1.Id = 283;
            this.renameTableItemCaption1.Name = "renameTableItemCaption1";
            // 
            // renameTableItem1
            // 
            this.renameTableItem1.Edit = this.repositoryItemTextEdit1;
            this.renameTableItem1.Id = 284;
            this.renameTableItem1.Name = "renameTableItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // spreadsheetCommandBarCheckItem27
            // 
            this.spreadsheetCommandBarCheckItem27.CommandName = "TableToolsConvertToRange";
            this.spreadsheetCommandBarCheckItem27.Id = 285;
            this.spreadsheetCommandBarCheckItem27.Name = "spreadsheetCommandBarCheckItem27";
            this.spreadsheetCommandBarCheckItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem28
            // 
            this.spreadsheetCommandBarCheckItem28.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem28.CommandName = "TableToolsToggleHeaderRow";
            this.spreadsheetCommandBarCheckItem28.Id = 286;
            this.spreadsheetCommandBarCheckItem28.Name = "spreadsheetCommandBarCheckItem28";
            // 
            // spreadsheetCommandBarCheckItem29
            // 
            this.spreadsheetCommandBarCheckItem29.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem29.CommandName = "TableToolsToggleTotalRow";
            this.spreadsheetCommandBarCheckItem29.Id = 287;
            this.spreadsheetCommandBarCheckItem29.Name = "spreadsheetCommandBarCheckItem29";
            // 
            // spreadsheetCommandBarCheckItem30
            // 
            this.spreadsheetCommandBarCheckItem30.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem30.CommandName = "TableToolsToggleBandedColumns";
            this.spreadsheetCommandBarCheckItem30.Id = 288;
            this.spreadsheetCommandBarCheckItem30.Name = "spreadsheetCommandBarCheckItem30";
            // 
            // spreadsheetCommandBarCheckItem31
            // 
            this.spreadsheetCommandBarCheckItem31.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem31.CommandName = "TableToolsToggleFirstColumn";
            this.spreadsheetCommandBarCheckItem31.Id = 289;
            this.spreadsheetCommandBarCheckItem31.Name = "spreadsheetCommandBarCheckItem31";
            // 
            // spreadsheetCommandBarCheckItem32
            // 
            this.spreadsheetCommandBarCheckItem32.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem32.CommandName = "TableToolsToggleLastColumn";
            this.spreadsheetCommandBarCheckItem32.Id = 290;
            this.spreadsheetCommandBarCheckItem32.Name = "spreadsheetCommandBarCheckItem32";
            // 
            // spreadsheetCommandBarCheckItem33
            // 
            this.spreadsheetCommandBarCheckItem33.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem33.CommandName = "TableToolsToggleBandedRows";
            this.spreadsheetCommandBarCheckItem33.Id = 291;
            this.spreadsheetCommandBarCheckItem33.Name = "spreadsheetCommandBarCheckItem33";
            // 
            // galleryTableStylesItem1
            // 
            // 
            // 
            // 
            this.galleryTableStylesItem1.Gallery.ColumnCount = 7;
            this.galleryTableStylesItem1.Gallery.DrawImageBackground = false;
            this.galleryTableStylesItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryTableStylesItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.galleryTableStylesItem1.Gallery.ItemSize = new System.Drawing.Size(73, 58);
            this.galleryTableStylesItem1.Gallery.RowCount = 10;
            this.galleryTableStylesItem1.Id = 292;
            this.galleryTableStylesItem1.Name = "galleryTableStylesItem1";
            // 
            // spreadsheetCommandBarButtonItem167
            // 
            this.spreadsheetCommandBarButtonItem167.CommandName = "OptionsPivotTable";
            this.spreadsheetCommandBarButtonItem167.Id = 293;
            this.spreadsheetCommandBarButtonItem167.Name = "spreadsheetCommandBarButtonItem167";
            // 
            // spreadsheetCommandBarButtonItem168
            // 
            this.spreadsheetCommandBarButtonItem168.CommandName = "SelectFieldTypePivotTable";
            this.spreadsheetCommandBarButtonItem168.Id = 294;
            this.spreadsheetCommandBarButtonItem168.Name = "spreadsheetCommandBarButtonItem168";
            // 
            // spreadsheetCommandBarButtonItem169
            // 
            this.spreadsheetCommandBarButtonItem169.CommandName = "PivotTableExpandField";
            this.spreadsheetCommandBarButtonItem169.Id = 295;
            this.spreadsheetCommandBarButtonItem169.Name = "spreadsheetCommandBarButtonItem169";
            this.spreadsheetCommandBarButtonItem169.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem170
            // 
            this.spreadsheetCommandBarButtonItem170.CommandName = "PivotTableCollapseField";
            this.spreadsheetCommandBarButtonItem170.Id = 296;
            this.spreadsheetCommandBarButtonItem170.Name = "spreadsheetCommandBarButtonItem170";
            this.spreadsheetCommandBarButtonItem170.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem171
            // 
            this.spreadsheetCommandBarButtonItem171.CommandName = "PivotTableGroupSelection";
            this.spreadsheetCommandBarButtonItem171.Id = 297;
            this.spreadsheetCommandBarButtonItem171.Name = "spreadsheetCommandBarButtonItem171";
            this.spreadsheetCommandBarButtonItem171.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem172
            // 
            this.spreadsheetCommandBarButtonItem172.CommandName = "PivotTableUngroup";
            this.spreadsheetCommandBarButtonItem172.Id = 298;
            this.spreadsheetCommandBarButtonItem172.Name = "spreadsheetCommandBarButtonItem172";
            this.spreadsheetCommandBarButtonItem172.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem173
            // 
            this.spreadsheetCommandBarButtonItem173.CommandName = "PivotTableGroupField";
            this.spreadsheetCommandBarButtonItem173.Id = 299;
            this.spreadsheetCommandBarButtonItem173.Name = "spreadsheetCommandBarButtonItem173";
            this.spreadsheetCommandBarButtonItem173.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarSubItem32
            // 
            this.spreadsheetCommandBarSubItem32.CommandName = "PivotTableDataRefreshGroup";
            this.spreadsheetCommandBarSubItem32.Id = 300;
            this.spreadsheetCommandBarSubItem32.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem174),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem175)});
            this.spreadsheetCommandBarSubItem32.Name = "spreadsheetCommandBarSubItem32";
            // 
            // spreadsheetCommandBarButtonItem174
            // 
            this.spreadsheetCommandBarButtonItem174.CommandName = "RefreshPivotTable";
            this.spreadsheetCommandBarButtonItem174.Id = 301;
            this.spreadsheetCommandBarButtonItem174.Name = "spreadsheetCommandBarButtonItem174";
            // 
            // spreadsheetCommandBarButtonItem175
            // 
            this.spreadsheetCommandBarButtonItem175.CommandName = "RefreshAllPivotTable";
            this.spreadsheetCommandBarButtonItem175.Id = 302;
            this.spreadsheetCommandBarButtonItem175.Name = "spreadsheetCommandBarButtonItem175";
            // 
            // spreadsheetCommandBarButtonItem176
            // 
            this.spreadsheetCommandBarButtonItem176.CommandName = "ChangeDataSourcePivotTable";
            this.spreadsheetCommandBarButtonItem176.Id = 303;
            this.spreadsheetCommandBarButtonItem176.Name = "spreadsheetCommandBarButtonItem176";
            // 
            // spreadsheetCommandBarSubItem33
            // 
            this.spreadsheetCommandBarSubItem33.CommandName = "PivotTableActionsClearGroup";
            this.spreadsheetCommandBarSubItem33.Id = 304;
            this.spreadsheetCommandBarSubItem33.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem177),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem178)});
            this.spreadsheetCommandBarSubItem33.Name = "spreadsheetCommandBarSubItem33";
            // 
            // spreadsheetCommandBarButtonItem177
            // 
            this.spreadsheetCommandBarButtonItem177.CommandName = "ClearAllPivotTable";
            this.spreadsheetCommandBarButtonItem177.Id = 305;
            this.spreadsheetCommandBarButtonItem177.Name = "spreadsheetCommandBarButtonItem177";
            // 
            // spreadsheetCommandBarButtonItem178
            // 
            this.spreadsheetCommandBarButtonItem178.CommandName = "ClearFiltersPivotTable";
            this.spreadsheetCommandBarButtonItem178.Id = 306;
            this.spreadsheetCommandBarButtonItem178.Name = "spreadsheetCommandBarButtonItem178";
            // 
            // spreadsheetCommandBarSubItem34
            // 
            this.spreadsheetCommandBarSubItem34.CommandName = "PivotTableActionsSelectGroup";
            this.spreadsheetCommandBarSubItem34.Id = 307;
            this.spreadsheetCommandBarSubItem34.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem179),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem180),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem181)});
            this.spreadsheetCommandBarSubItem34.Name = "spreadsheetCommandBarSubItem34";
            // 
            // spreadsheetCommandBarButtonItem179
            // 
            this.spreadsheetCommandBarButtonItem179.CommandName = "SelectValuesPivotTable";
            this.spreadsheetCommandBarButtonItem179.Id = 308;
            this.spreadsheetCommandBarButtonItem179.Name = "spreadsheetCommandBarButtonItem179";
            // 
            // spreadsheetCommandBarButtonItem180
            // 
            this.spreadsheetCommandBarButtonItem180.CommandName = "SelectLabelsPivotTable";
            this.spreadsheetCommandBarButtonItem180.Id = 309;
            this.spreadsheetCommandBarButtonItem180.Name = "spreadsheetCommandBarButtonItem180";
            // 
            // spreadsheetCommandBarButtonItem181
            // 
            this.spreadsheetCommandBarButtonItem181.CommandName = "SelectEntirePivotTable";
            this.spreadsheetCommandBarButtonItem181.Id = 310;
            this.spreadsheetCommandBarButtonItem181.Name = "spreadsheetCommandBarButtonItem181";
            // 
            // spreadsheetCommandBarButtonItem182
            // 
            this.spreadsheetCommandBarButtonItem182.CommandName = "MovePivotTable";
            this.spreadsheetCommandBarButtonItem182.Id = 311;
            this.spreadsheetCommandBarButtonItem182.Name = "spreadsheetCommandBarButtonItem182";
            // 
            // spreadsheetCommandBarSubItem35
            // 
            this.spreadsheetCommandBarSubItem35.CommandName = "PivotTableCalculationFieldsItemsSetsGroup";
            this.spreadsheetCommandBarSubItem35.Id = 312;
            this.spreadsheetCommandBarSubItem35.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem183),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem184),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem185),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem186)});
            this.spreadsheetCommandBarSubItem35.Name = "spreadsheetCommandBarSubItem35";
            // 
            // spreadsheetCommandBarButtonItem183
            // 
            this.spreadsheetCommandBarButtonItem183.CommandName = "PivotTableCalculatedField";
            this.spreadsheetCommandBarButtonItem183.Id = 313;
            this.spreadsheetCommandBarButtonItem183.Name = "spreadsheetCommandBarButtonItem183";
            // 
            // spreadsheetCommandBarButtonItem184
            // 
            this.spreadsheetCommandBarButtonItem184.CommandName = "PivotTableCalculatedItem";
            this.spreadsheetCommandBarButtonItem184.Id = 314;
            this.spreadsheetCommandBarButtonItem184.Name = "spreadsheetCommandBarButtonItem184";
            // 
            // spreadsheetCommandBarButtonItem185
            // 
            this.spreadsheetCommandBarButtonItem185.CommandName = "PivotTableCalculatedItemSolveOrder";
            this.spreadsheetCommandBarButtonItem185.Id = 315;
            this.spreadsheetCommandBarButtonItem185.Name = "spreadsheetCommandBarButtonItem185";
            // 
            // spreadsheetCommandBarButtonItem186
            // 
            this.spreadsheetCommandBarButtonItem186.CommandName = "PivotTableListFormulas";
            this.spreadsheetCommandBarButtonItem186.Id = 316;
            this.spreadsheetCommandBarButtonItem186.Name = "spreadsheetCommandBarButtonItem186";
            // 
            // spreadsheetCommandBarCheckItem34
            // 
            this.spreadsheetCommandBarCheckItem34.CommandName = "FieldListPanelPivotTable";
            this.spreadsheetCommandBarCheckItem34.Id = 317;
            this.spreadsheetCommandBarCheckItem34.Name = "spreadsheetCommandBarCheckItem34";
            // 
            // spreadsheetCommandBarCheckItem35
            // 
            this.spreadsheetCommandBarCheckItem35.CommandName = "ShowPivotTableExpandCollapseButtons";
            this.spreadsheetCommandBarCheckItem35.Id = 318;
            this.spreadsheetCommandBarCheckItem35.Name = "spreadsheetCommandBarCheckItem35";
            // 
            // spreadsheetCommandBarCheckItem36
            // 
            this.spreadsheetCommandBarCheckItem36.CommandName = "ShowPivotTableFieldHeaders";
            this.spreadsheetCommandBarCheckItem36.Id = 319;
            this.spreadsheetCommandBarCheckItem36.Name = "spreadsheetCommandBarCheckItem36";
            // 
            // spreadsheetCommandBarSubItem36
            // 
            this.spreadsheetCommandBarSubItem36.CommandName = "PivotTableLayoutSubtotalsGroup";
            this.spreadsheetCommandBarSubItem36.Id = 320;
            this.spreadsheetCommandBarSubItem36.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem187),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem188),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem189)});
            this.spreadsheetCommandBarSubItem36.Name = "spreadsheetCommandBarSubItem36";
            // 
            // spreadsheetCommandBarButtonItem187
            // 
            this.spreadsheetCommandBarButtonItem187.CommandName = "PivotTableDoNotShowSubtotals";
            this.spreadsheetCommandBarButtonItem187.Id = 321;
            this.spreadsheetCommandBarButtonItem187.Name = "spreadsheetCommandBarButtonItem187";
            this.spreadsheetCommandBarButtonItem187.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem188
            // 
            this.spreadsheetCommandBarButtonItem188.CommandName = "PivotTableShowAllSubtotalsAtBottom";
            this.spreadsheetCommandBarButtonItem188.Id = 322;
            this.spreadsheetCommandBarButtonItem188.Name = "spreadsheetCommandBarButtonItem188";
            this.spreadsheetCommandBarButtonItem188.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem189
            // 
            this.spreadsheetCommandBarButtonItem189.CommandName = "PivotTableShowAllSubtotalsAtTop";
            this.spreadsheetCommandBarButtonItem189.Id = 323;
            this.spreadsheetCommandBarButtonItem189.Name = "spreadsheetCommandBarButtonItem189";
            this.spreadsheetCommandBarButtonItem189.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem37
            // 
            this.spreadsheetCommandBarSubItem37.CommandName = "PivotTableLayoutGrandTotalsGroup";
            this.spreadsheetCommandBarSubItem37.Id = 324;
            this.spreadsheetCommandBarSubItem37.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem190),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem191),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem192),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem193)});
            this.spreadsheetCommandBarSubItem37.Name = "spreadsheetCommandBarSubItem37";
            // 
            // spreadsheetCommandBarButtonItem190
            // 
            this.spreadsheetCommandBarButtonItem190.CommandName = "PivotTableGrandTotalsOffRowsColumns";
            this.spreadsheetCommandBarButtonItem190.Id = 325;
            this.spreadsheetCommandBarButtonItem190.Name = "spreadsheetCommandBarButtonItem190";
            this.spreadsheetCommandBarButtonItem190.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem191
            // 
            this.spreadsheetCommandBarButtonItem191.CommandName = "PivotTableGrandTotalsOnRowsColumns";
            this.spreadsheetCommandBarButtonItem191.Id = 326;
            this.spreadsheetCommandBarButtonItem191.Name = "spreadsheetCommandBarButtonItem191";
            this.spreadsheetCommandBarButtonItem191.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem192
            // 
            this.spreadsheetCommandBarButtonItem192.CommandName = "PivotTableGrandTotalsOnRowsOnly";
            this.spreadsheetCommandBarButtonItem192.Id = 327;
            this.spreadsheetCommandBarButtonItem192.Name = "spreadsheetCommandBarButtonItem192";
            this.spreadsheetCommandBarButtonItem192.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem193
            // 
            this.spreadsheetCommandBarButtonItem193.CommandName = "PivotTableGrandTotalsOnColumnsOnly";
            this.spreadsheetCommandBarButtonItem193.Id = 328;
            this.spreadsheetCommandBarButtonItem193.Name = "spreadsheetCommandBarButtonItem193";
            this.spreadsheetCommandBarButtonItem193.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem38
            // 
            this.spreadsheetCommandBarSubItem38.CommandName = "PivotTableLayoutReportLayoutGroup";
            this.spreadsheetCommandBarSubItem38.Id = 329;
            this.spreadsheetCommandBarSubItem38.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem194),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem195),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem196),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem197),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem198)});
            this.spreadsheetCommandBarSubItem38.Name = "spreadsheetCommandBarSubItem38";
            // 
            // spreadsheetCommandBarButtonItem194
            // 
            this.spreadsheetCommandBarButtonItem194.CommandName = "PivotTableShowCompactForm";
            this.spreadsheetCommandBarButtonItem194.Id = 330;
            this.spreadsheetCommandBarButtonItem194.Name = "spreadsheetCommandBarButtonItem194";
            this.spreadsheetCommandBarButtonItem194.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem195
            // 
            this.spreadsheetCommandBarButtonItem195.CommandName = "PivotTableShowOutlineForm";
            this.spreadsheetCommandBarButtonItem195.Id = 331;
            this.spreadsheetCommandBarButtonItem195.Name = "spreadsheetCommandBarButtonItem195";
            this.spreadsheetCommandBarButtonItem195.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem196
            // 
            this.spreadsheetCommandBarButtonItem196.CommandName = "PivotTableShowTabularForm";
            this.spreadsheetCommandBarButtonItem196.Id = 332;
            this.spreadsheetCommandBarButtonItem196.Name = "spreadsheetCommandBarButtonItem196";
            this.spreadsheetCommandBarButtonItem196.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem197
            // 
            this.spreadsheetCommandBarButtonItem197.CommandName = "PivotTableRepeatAllItemLabels";
            this.spreadsheetCommandBarButtonItem197.Id = 333;
            this.spreadsheetCommandBarButtonItem197.Name = "spreadsheetCommandBarButtonItem197";
            this.spreadsheetCommandBarButtonItem197.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem198
            // 
            this.spreadsheetCommandBarButtonItem198.CommandName = "PivotTableDoNotRepeatItemLabels";
            this.spreadsheetCommandBarButtonItem198.Id = 334;
            this.spreadsheetCommandBarButtonItem198.Name = "spreadsheetCommandBarButtonItem198";
            this.spreadsheetCommandBarButtonItem198.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem39
            // 
            this.spreadsheetCommandBarSubItem39.CommandName = "PivotTableLayoutBlankRowsGroup";
            this.spreadsheetCommandBarSubItem39.Id = 335;
            this.spreadsheetCommandBarSubItem39.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem199),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem200)});
            this.spreadsheetCommandBarSubItem39.Name = "spreadsheetCommandBarSubItem39";
            // 
            // spreadsheetCommandBarButtonItem199
            // 
            this.spreadsheetCommandBarButtonItem199.CommandName = "PivotTableInsertBlankLineEachItem";
            this.spreadsheetCommandBarButtonItem199.Id = 336;
            this.spreadsheetCommandBarButtonItem199.Name = "spreadsheetCommandBarButtonItem199";
            this.spreadsheetCommandBarButtonItem199.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem200
            // 
            this.spreadsheetCommandBarButtonItem200.CommandName = "PivotTableRemoveBlankLineEachItem";
            this.spreadsheetCommandBarButtonItem200.Id = 337;
            this.spreadsheetCommandBarButtonItem200.Name = "spreadsheetCommandBarButtonItem200";
            this.spreadsheetCommandBarButtonItem200.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarCheckItem37
            // 
            this.spreadsheetCommandBarCheckItem37.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem37.CommandName = "PivotTableToggleRowHeaders";
            this.spreadsheetCommandBarCheckItem37.Id = 338;
            this.spreadsheetCommandBarCheckItem37.Name = "spreadsheetCommandBarCheckItem37";
            // 
            // spreadsheetCommandBarCheckItem38
            // 
            this.spreadsheetCommandBarCheckItem38.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem38.CommandName = "PivotTableToggleColumnHeaders";
            this.spreadsheetCommandBarCheckItem38.Id = 339;
            this.spreadsheetCommandBarCheckItem38.Name = "spreadsheetCommandBarCheckItem38";
            // 
            // spreadsheetCommandBarCheckItem39
            // 
            this.spreadsheetCommandBarCheckItem39.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem39.CommandName = "PivotTableToggleBandedRows";
            this.spreadsheetCommandBarCheckItem39.Id = 340;
            this.spreadsheetCommandBarCheckItem39.Name = "spreadsheetCommandBarCheckItem39";
            // 
            // spreadsheetCommandBarCheckItem40
            // 
            this.spreadsheetCommandBarCheckItem40.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.spreadsheetCommandBarCheckItem40.CommandName = "PivotTableToggleBandedColumns";
            this.spreadsheetCommandBarCheckItem40.Id = 341;
            this.spreadsheetCommandBarCheckItem40.Name = "spreadsheetCommandBarCheckItem40";
            // 
            // galleryPivotStylesItem1
            // 
            // 
            // 
            // 
            this.galleryPivotStylesItem1.Gallery.ColumnCount = 7;
            this.galleryPivotStylesItem1.Gallery.DrawImageBackground = false;
            this.galleryPivotStylesItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.galleryPivotStylesItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.galleryPivotStylesItem1.Gallery.ItemSize = new System.Drawing.Size(73, 61);
            this.galleryPivotStylesItem1.Gallery.RowCount = 10;
            this.galleryPivotStylesItem1.Id = 342;
            this.galleryPivotStylesItem1.Name = "galleryPivotStylesItem1";
            // 
            // spreadsheetCommandBarButtonItem201
            // 
            this.spreadsheetCommandBarButtonItem201.CommandName = "MailMergeAddDataSource";
            this.spreadsheetCommandBarButtonItem201.Id = 343;
            this.spreadsheetCommandBarButtonItem201.Name = "spreadsheetCommandBarButtonItem201";
            this.spreadsheetCommandBarButtonItem201.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem40
            // 
            this.spreadsheetCommandBarSubItem40.CommandName = "MailMergeManageRelationsCommandGroup";
            this.spreadsheetCommandBarSubItem40.Id = 344;
            this.spreadsheetCommandBarSubItem40.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem202),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem203)});
            this.spreadsheetCommandBarSubItem40.Name = "spreadsheetCommandBarSubItem40";
            this.spreadsheetCommandBarSubItem40.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem202
            // 
            this.spreadsheetCommandBarButtonItem202.CommandName = "MailMergeManageQueriesCommand";
            this.spreadsheetCommandBarButtonItem202.Id = 345;
            this.spreadsheetCommandBarButtonItem202.Name = "spreadsheetCommandBarButtonItem202";
            // 
            // spreadsheetCommandBarButtonItem203
            // 
            this.spreadsheetCommandBarButtonItem203.CommandName = "MailMergeManageRelationsCommand";
            this.spreadsheetCommandBarButtonItem203.Id = 346;
            this.spreadsheetCommandBarButtonItem203.Name = "spreadsheetCommandBarButtonItem203";
            // 
            // spreadsheetCommandBarSubItem41
            // 
            this.spreadsheetCommandBarSubItem41.CommandName = "MailMergeManageDataSourceCommandGroup";
            this.spreadsheetCommandBarSubItem41.Id = 347;
            this.spreadsheetCommandBarSubItem41.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem204),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem205),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem206)});
            this.spreadsheetCommandBarSubItem41.Name = "spreadsheetCommandBarSubItem41";
            this.spreadsheetCommandBarSubItem41.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem204
            // 
            this.spreadsheetCommandBarButtonItem204.CommandName = "MailMergeSelectDataSource";
            this.spreadsheetCommandBarButtonItem204.Id = 348;
            this.spreadsheetCommandBarButtonItem204.Name = "spreadsheetCommandBarButtonItem204";
            // 
            // spreadsheetCommandBarButtonItem205
            // 
            this.spreadsheetCommandBarButtonItem205.CommandName = "MailMergeSelectDataMember";
            this.spreadsheetCommandBarButtonItem205.Id = 349;
            this.spreadsheetCommandBarButtonItem205.Name = "spreadsheetCommandBarButtonItem205";
            // 
            // spreadsheetCommandBarButtonItem206
            // 
            this.spreadsheetCommandBarButtonItem206.CommandName = "MailMergeManageDataSourcesCommand";
            this.spreadsheetCommandBarButtonItem206.Id = 350;
            this.spreadsheetCommandBarButtonItem206.Name = "spreadsheetCommandBarButtonItem206";
            // 
            // spreadsheetCommandBarCheckItem41
            // 
            this.spreadsheetCommandBarCheckItem41.CommandName = "MailMergeDocumentsMode";
            this.spreadsheetCommandBarCheckItem41.Id = 351;
            this.spreadsheetCommandBarCheckItem41.Name = "spreadsheetCommandBarCheckItem41";
            this.spreadsheetCommandBarCheckItem41.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem42
            // 
            this.spreadsheetCommandBarCheckItem42.CommandName = "MailMergeOneDocumentMode";
            this.spreadsheetCommandBarCheckItem42.Id = 352;
            this.spreadsheetCommandBarCheckItem42.Name = "spreadsheetCommandBarCheckItem42";
            this.spreadsheetCommandBarCheckItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarCheckItem43
            // 
            this.spreadsheetCommandBarCheckItem43.CommandName = "MailMergeOneSheetMode";
            this.spreadsheetCommandBarCheckItem43.Id = 353;
            this.spreadsheetCommandBarCheckItem43.Name = "spreadsheetCommandBarCheckItem43";
            this.spreadsheetCommandBarCheckItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarSubItem42
            // 
            this.spreadsheetCommandBarSubItem42.CommandName = "MailMergeOrientationCommandGroup";
            this.spreadsheetCommandBarSubItem42.Id = 354;
            this.spreadsheetCommandBarSubItem42.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem44),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarCheckItem45)});
            this.spreadsheetCommandBarSubItem42.Name = "spreadsheetCommandBarSubItem42";
            this.spreadsheetCommandBarSubItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarCheckItem44
            // 
            this.spreadsheetCommandBarCheckItem44.CommandName = "MailMergeHorizontalMode";
            this.spreadsheetCommandBarCheckItem44.Id = 355;
            this.spreadsheetCommandBarCheckItem44.Name = "spreadsheetCommandBarCheckItem44";
            // 
            // spreadsheetCommandBarCheckItem45
            // 
            this.spreadsheetCommandBarCheckItem45.CommandName = "MailMergeVerticalMode";
            this.spreadsheetCommandBarCheckItem45.Id = 356;
            this.spreadsheetCommandBarCheckItem45.Name = "spreadsheetCommandBarCheckItem45";
            // 
            // spreadsheetCommandBarButtonItem207
            // 
            this.spreadsheetCommandBarButtonItem207.CommandName = "MailMergeSetHeaderRange";
            this.spreadsheetCommandBarButtonItem207.Id = 357;
            this.spreadsheetCommandBarButtonItem207.Name = "spreadsheetCommandBarButtonItem207";
            this.spreadsheetCommandBarButtonItem207.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem208
            // 
            this.spreadsheetCommandBarButtonItem208.CommandName = "MailMergeSetFooterRange";
            this.spreadsheetCommandBarButtonItem208.Id = 358;
            this.spreadsheetCommandBarButtonItem208.Name = "spreadsheetCommandBarButtonItem208";
            this.spreadsheetCommandBarButtonItem208.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem209
            // 
            this.spreadsheetCommandBarButtonItem209.CommandName = "MailMergeSetDetailRange";
            this.spreadsheetCommandBarButtonItem209.Id = 359;
            this.spreadsheetCommandBarButtonItem209.Name = "spreadsheetCommandBarButtonItem209";
            this.spreadsheetCommandBarButtonItem209.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarSubItem43
            // 
            this.spreadsheetCommandBarSubItem43.CommandName = "EditingMailMergeMasterDetailCommandGroup";
            this.spreadsheetCommandBarSubItem43.Id = 360;
            this.spreadsheetCommandBarSubItem43.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem210),
            new DevExpress.XtraBars.LinkPersistInfo(this.spreadsheetCommandBarButtonItem211)});
            this.spreadsheetCommandBarSubItem43.Name = "spreadsheetCommandBarSubItem43";
            this.spreadsheetCommandBarSubItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem210
            // 
            this.spreadsheetCommandBarButtonItem210.CommandName = "MailMergeSetDetailLevel";
            this.spreadsheetCommandBarButtonItem210.Id = 361;
            this.spreadsheetCommandBarButtonItem210.Name = "spreadsheetCommandBarButtonItem210";
            // 
            // spreadsheetCommandBarButtonItem211
            // 
            this.spreadsheetCommandBarButtonItem211.CommandName = "MailMergeSetDetailDataMember";
            this.spreadsheetCommandBarButtonItem211.Id = 362;
            this.spreadsheetCommandBarButtonItem211.Name = "spreadsheetCommandBarButtonItem211";
            // 
            // spreadsheetCommandBarButtonItem212
            // 
            this.spreadsheetCommandBarButtonItem212.CommandName = "MailMergeResetRange";
            this.spreadsheetCommandBarButtonItem212.Id = 363;
            this.spreadsheetCommandBarButtonItem212.Name = "spreadsheetCommandBarButtonItem212";
            this.spreadsheetCommandBarButtonItem212.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem213
            // 
            this.spreadsheetCommandBarButtonItem213.CommandName = "MailMergeSetGroup";
            this.spreadsheetCommandBarButtonItem213.Id = 364;
            this.spreadsheetCommandBarButtonItem213.Name = "spreadsheetCommandBarButtonItem213";
            this.spreadsheetCommandBarButtonItem213.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem214
            // 
            this.spreadsheetCommandBarButtonItem214.CommandName = "MailMergeSetGroupHeader";
            this.spreadsheetCommandBarButtonItem214.Id = 365;
            this.spreadsheetCommandBarButtonItem214.Name = "spreadsheetCommandBarButtonItem214";
            this.spreadsheetCommandBarButtonItem214.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem215
            // 
            this.spreadsheetCommandBarButtonItem215.CommandName = "MailMergeSetGroupFooter";
            this.spreadsheetCommandBarButtonItem215.Id = 366;
            this.spreadsheetCommandBarButtonItem215.Name = "spreadsheetCommandBarButtonItem215";
            this.spreadsheetCommandBarButtonItem215.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // spreadsheetCommandBarButtonItem216
            // 
            this.spreadsheetCommandBarButtonItem216.CommandName = "MailMergeSetFilter";
            this.spreadsheetCommandBarButtonItem216.Id = 367;
            this.spreadsheetCommandBarButtonItem216.Name = "spreadsheetCommandBarButtonItem216";
            this.spreadsheetCommandBarButtonItem216.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem217
            // 
            this.spreadsheetCommandBarButtonItem217.CommandName = "MailMergeResetFilter";
            this.spreadsheetCommandBarButtonItem217.Id = 368;
            this.spreadsheetCommandBarButtonItem217.Name = "spreadsheetCommandBarButtonItem217";
            this.spreadsheetCommandBarButtonItem217.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarCheckItem46
            // 
            this.spreadsheetCommandBarCheckItem46.CommandName = "MailMergeShowRanges";
            this.spreadsheetCommandBarCheckItem46.Id = 369;
            this.spreadsheetCommandBarCheckItem46.Name = "spreadsheetCommandBarCheckItem46";
            this.spreadsheetCommandBarCheckItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // spreadsheetCommandBarButtonItem218
            // 
            this.spreadsheetCommandBarButtonItem218.CommandName = "MailMergePreview";
            this.spreadsheetCommandBarButtonItem218.Id = 370;
            this.spreadsheetCommandBarButtonItem218.Name = "spreadsheetCommandBarButtonItem218";
            this.spreadsheetCommandBarButtonItem218.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // endModeInfoStaticItem1
            // 
            this.endModeInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.endModeInfoStaticItem1.Id = 371;
            this.endModeInfoStaticItem1.Name = "endModeInfoStaticItem1";
            // 
            // averageInfoStaticItem1
            // 
            this.averageInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.averageInfoStaticItem1.Id = 372;
            this.averageInfoStaticItem1.Name = "averageInfoStaticItem1";
            toolTipItem1.Text = "Average of selected cells";
            superToolTip1.Items.Add(toolTipItem1);
            this.averageInfoStaticItem1.SuperTip = superToolTip1;
            this.averageInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // countInfoStaticItem1
            // 
            this.countInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.countInfoStaticItem1.Id = 373;
            this.countInfoStaticItem1.Name = "countInfoStaticItem1";
            toolTipItem2.Text = "Number of selected cells that contain data";
            superToolTip2.Items.Add(toolTipItem2);
            this.countInfoStaticItem1.SuperTip = superToolTip2;
            this.countInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // numericalCountInfoStaticItem1
            // 
            this.numericalCountInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.numericalCountInfoStaticItem1.Id = 374;
            this.numericalCountInfoStaticItem1.Name = "numericalCountInfoStaticItem1";
            toolTipItem3.Text = "Number of selected cells that contain numerical data";
            superToolTip3.Items.Add(toolTipItem3);
            this.numericalCountInfoStaticItem1.SuperTip = superToolTip3;
            this.numericalCountInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // minInfoStaticItem1
            // 
            this.minInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.minInfoStaticItem1.Id = 375;
            this.minInfoStaticItem1.Name = "minInfoStaticItem1";
            toolTipItem4.Text = "Minimum value in selection";
            superToolTip4.Items.Add(toolTipItem4);
            this.minInfoStaticItem1.SuperTip = superToolTip4;
            this.minInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // maxInfoStaticItem1
            // 
            this.maxInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.maxInfoStaticItem1.Id = 376;
            this.maxInfoStaticItem1.Name = "maxInfoStaticItem1";
            toolTipItem5.Text = "Maximum value in selection";
            superToolTip5.Items.Add(toolTipItem5);
            this.maxInfoStaticItem1.SuperTip = superToolTip5;
            this.maxInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // sumInfoStaticItem1
            // 
            this.sumInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.sumInfoStaticItem1.Id = 377;
            this.sumInfoStaticItem1.Name = "sumInfoStaticItem1";
            toolTipItem6.Text = "Sum of selected cells";
            superToolTip6.Items.Add(toolTipItem6);
            this.sumInfoStaticItem1.SuperTip = superToolTip6;
            this.sumInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // zoomEditItem1
            // 
            this.zoomEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.zoomEditItem1.Edit = this.repositoryItemZoomTrackBar1;
            this.zoomEditItem1.Id = 378;
            this.zoomEditItem1.Name = "zoomEditItem1";
            toolTipItem7.Text = "Zoom";
            superToolTip7.Items.Add(toolTipItem7);
            this.zoomEditItem1.SuperTip = superToolTip7;
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.AllowUseMiddleValue = true;
            this.repositoryItemZoomTrackBar1.LargeChange = 10;
            this.repositoryItemZoomTrackBar1.Maximum = 400;
            this.repositoryItemZoomTrackBar1.Middle = 100;
            this.repositoryItemZoomTrackBar1.Minimum = 10;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.SmallChange = 10;
            this.repositoryItemZoomTrackBar1.SnapToMiddle = 5;
            // 
            // showZoomButtonItem1
            // 
            this.showZoomButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.showZoomButtonItem1.Id = 379;
            this.showZoomButtonItem1.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.showZoomButtonItem1.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.showZoomButtonItem1.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.showZoomButtonItem1.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.showZoomButtonItem1.Name = "showZoomButtonItem1";
            this.showZoomButtonItem1.SmallWithTextWidth = 45;
            toolTipItem8.Text = "Zoom level. Click to open the Zoom dialog box.";
            superToolTip8.Items.Add(toolTipItem8);
            this.showZoomButtonItem1.SuperTip = superToolTip8;
            // 
            // progressBarItem1
            // 
            this.progressBarItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.progressBarItem1.Control = this.spreadsheetControl1;
            this.progressBarItem1.Edit = this.repositoryItemProgressBar1;
            this.progressBarItem1.EditWidth = 150;
            this.progressBarItem1.Id = 380;
            this.progressBarItem1.Name = "progressBarItem1";
            this.progressBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // chartToolsRibbonPageCategory1
            // 
            this.chartToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.chartToolsRibbonPageCategory1.Name = "chartToolsRibbonPageCategory1";
            this.chartToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.chartsDesignRibbonPage1,
            this.chartsLayoutRibbonPage1,
            this.chartsFormatRibbonPage1});
            this.chartToolsRibbonPageCategory1.Visible = false;
            // 
            // chartsDesignRibbonPage1
            // 
            this.chartsDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.chartsDesignTypeRibbonPageGroup1,
            this.chartsDesignDataRibbonPageGroup1,
            this.chartsDesignLayoutsRibbonPageGroup1,
            this.chartsDesignStylesRibbonPageGroup1,
            this.chartsDesignLocationRibbonPageGroup1});
            this.chartsDesignRibbonPage1.Name = "chartsDesignRibbonPage1";
            this.chartsDesignRibbonPage1.Visible = false;
            // 
            // chartsDesignTypeRibbonPageGroup1
            // 
            this.chartsDesignTypeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.chartsDesignTypeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem163);
            this.chartsDesignTypeRibbonPageGroup1.Name = "chartsDesignTypeRibbonPageGroup1";
            // 
            // chartsDesignDataRibbonPageGroup1
            // 
            this.chartsDesignDataRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem164);
            this.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem165);
            this.chartsDesignDataRibbonPageGroup1.Name = "chartsDesignDataRibbonPageGroup1";
            // 
            // chartsDesignLayoutsRibbonPageGroup1
            // 
            this.chartsDesignLayoutsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.chartsDesignLayoutsRibbonPageGroup1.ItemLinks.Add(this.galleryChartLayoutItem1);
            this.chartsDesignLayoutsRibbonPageGroup1.Name = "chartsDesignLayoutsRibbonPageGroup1";
            // 
            // chartsDesignStylesRibbonPageGroup1
            // 
            this.chartsDesignStylesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.chartsDesignStylesRibbonPageGroup1.ItemLinks.Add(this.galleryChartStyleItem1);
            this.chartsDesignStylesRibbonPageGroup1.Name = "chartsDesignStylesRibbonPageGroup1";
            // 
            // chartsDesignLocationRibbonPageGroup1
            // 
            this.chartsDesignLocationRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.chartsDesignLocationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem166);
            this.chartsDesignLocationRibbonPageGroup1.Name = "chartsDesignLocationRibbonPageGroup1";
            // 
            // chartsLayoutRibbonPage1
            // 
            this.chartsLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.chartsLayoutAxesRibbonPageGroup1,
            this.chartsLayoutLabelsRibbonPageGroup1,
            this.chartsLayoutAnalysisRibbonPageGroup1});
            this.chartsLayoutRibbonPage1.Name = "chartsLayoutRibbonPage1";
            this.chartsLayoutRibbonPage1.Visible = false;
            // 
            // chartsLayoutAxesRibbonPageGroup1
            // 
            this.chartsLayoutAxesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem29);
            this.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem30);
            this.chartsLayoutAxesRibbonPageGroup1.Name = "chartsLayoutAxesRibbonPageGroup1";
            // 
            // chartsLayoutLabelsRibbonPageGroup1
            // 
            this.chartsLayoutLabelsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem17);
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem31);
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem20);
            this.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem21);
            this.chartsLayoutLabelsRibbonPageGroup1.Name = "chartsLayoutLabelsRibbonPageGroup1";
            // 
            // chartsLayoutAnalysisRibbonPageGroup1
            // 
            this.chartsLayoutAnalysisRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem22);
            this.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem23);
            this.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem24);
            this.chartsLayoutAnalysisRibbonPageGroup1.Name = "chartsLayoutAnalysisRibbonPageGroup1";
            // 
            // chartsFormatRibbonPage1
            // 
            this.chartsFormatRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.chartsFormatArrangeRibbonPageGroup1});
            this.chartsFormatRibbonPage1.Name = "chartsFormatRibbonPage1";
            this.chartsFormatRibbonPage1.Visible = false;
            // 
            // chartsFormatArrangeRibbonPageGroup1
            // 
            this.chartsFormatArrangeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.chartsFormatArrangeRibbonPageGroup1.Name = "chartsFormatArrangeRibbonPageGroup1";
            // 
            // tableToolsRibbonPageCategory1
            // 
            this.tableToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1";
            this.tableToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tableToolsDesignRibbonPage1});
            this.tableToolsRibbonPageCategory1.Visible = false;
            // 
            // tableToolsDesignRibbonPage1
            // 
            this.tableToolsDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tablePropertiesRibbonPageGroup1,
            this.tableToolsRibbonPageGroup1,
            this.tableStyleOptionsRibbonPageGroup1,
            this.tableStylesRibbonPageGroup1});
            this.tableToolsDesignRibbonPage1.Name = "tableToolsDesignRibbonPage1";
            this.tableToolsDesignRibbonPage1.Visible = false;
            // 
            // tablePropertiesRibbonPageGroup1
            // 
            this.tablePropertiesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.tablePropertiesRibbonPageGroup1.ItemLinks.Add(this.renameTableItemCaption1);
            this.tablePropertiesRibbonPageGroup1.ItemLinks.Add(this.renameTableItem1);
            this.tablePropertiesRibbonPageGroup1.Name = "tablePropertiesRibbonPageGroup1";
            // 
            // tableToolsRibbonPageGroup1
            // 
            this.tableToolsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.tableToolsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem27);
            this.tableToolsRibbonPageGroup1.Name = "tableToolsRibbonPageGroup1";
            // 
            // tableStyleOptionsRibbonPageGroup1
            // 
            this.tableStyleOptionsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem28);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem29);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem30);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem31);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem32);
            this.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem33);
            this.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1";
            // 
            // tableStylesRibbonPageGroup1
            // 
            this.tableStylesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.tableStylesRibbonPageGroup1.ItemLinks.Add(this.galleryTableStylesItem1);
            this.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1";
            // 
            // drawingToolsRibbonPageCategory1
            // 
            this.drawingToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.drawingToolsRibbonPageCategory1.Name = "drawingToolsRibbonPageCategory1";
            this.drawingToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.drawingFormatRibbonPage1});
            this.drawingToolsRibbonPageCategory1.Visible = false;
            // 
            // drawingFormatRibbonPage1
            // 
            this.drawingFormatRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.drawingFormatArrangeRibbonPageGroup1});
            this.drawingFormatRibbonPage1.Name = "drawingFormatRibbonPage1";
            this.drawingFormatRibbonPage1.Visible = false;
            // 
            // drawingFormatArrangeRibbonPageGroup1
            // 
            this.drawingFormatArrangeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.drawingFormatArrangeRibbonPageGroup1.Name = "drawingFormatArrangeRibbonPageGroup1";
            // 
            // pictureToolsRibbonPageCategory1
            // 
            this.pictureToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.pictureToolsRibbonPageCategory1.Name = "pictureToolsRibbonPageCategory1";
            this.pictureToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pictureFormatRibbonPage1});
            this.pictureToolsRibbonPageCategory1.Visible = false;
            // 
            // pictureFormatRibbonPage1
            // 
            this.pictureFormatRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pictureFormatArrangeRibbonPageGroup1});
            this.pictureFormatRibbonPage1.Name = "pictureFormatRibbonPage1";
            this.pictureFormatRibbonPage1.Visible = false;
            // 
            // pictureFormatArrangeRibbonPageGroup1
            // 
            this.pictureFormatArrangeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.pictureFormatArrangeRibbonPageGroup1.Name = "pictureFormatArrangeRibbonPageGroup1";
            // 
            // pivotTableToolsRibbonPageCategory1
            // 
            this.pivotTableToolsRibbonPageCategory1.Control = this.spreadsheetControl1;
            this.pivotTableToolsRibbonPageCategory1.Name = "pivotTableToolsRibbonPageCategory1";
            this.pivotTableToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pivotTableAnalyzeRibbonPage1,
            this.pivotTableDesignRibbonPage1});
            this.pivotTableToolsRibbonPageCategory1.Visible = false;
            // 
            // pivotTableAnalyzeRibbonPage1
            // 
            this.pivotTableAnalyzeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pivotTableAnalyzePivotTableRibbonPageGroup1,
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1,
            this.pivotTableAnalyzeGroupRibbonPageGroup1,
            this.pivotTableAnalyzeDataRibbonPageGroup1,
            this.pivotTableAnalyzeActionsRibbonPageGroup1,
            this.pivotTableAnalyzeCalculationsRibbonPageGroup1,
            this.pivotTableAnalyzeShowRibbonPageGroup1});
            this.pivotTableAnalyzeRibbonPage1.Name = "pivotTableAnalyzeRibbonPage1";
            this.pivotTableAnalyzeRibbonPage1.Visible = false;
            // 
            // pivotTableAnalyzePivotTableRibbonPageGroup1
            // 
            this.pivotTableAnalyzePivotTableRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pivotTableAnalyzePivotTableRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem167);
            this.pivotTableAnalyzePivotTableRibbonPageGroup1.Name = "pivotTableAnalyzePivotTableRibbonPageGroup1";
            // 
            // pivotTableAnalyzeActiveFieldRibbonPageGroup1
            // 
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem168);
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem169);
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem170);
            this.pivotTableAnalyzeActiveFieldRibbonPageGroup1.Name = "pivotTableAnalyzeActiveFieldRibbonPageGroup1";
            // 
            // pivotTableAnalyzeGroupRibbonPageGroup1
            // 
            this.pivotTableAnalyzeGroupRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem171);
            this.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem172);
            this.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem173);
            this.pivotTableAnalyzeGroupRibbonPageGroup1.Name = "pivotTableAnalyzeGroupRibbonPageGroup1";
            // 
            // pivotTableAnalyzeDataRibbonPageGroup1
            // 
            this.pivotTableAnalyzeDataRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pivotTableAnalyzeDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem32);
            this.pivotTableAnalyzeDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem176);
            this.pivotTableAnalyzeDataRibbonPageGroup1.Name = "pivotTableAnalyzeDataRibbonPageGroup1";
            // 
            // pivotTableAnalyzeActionsRibbonPageGroup1
            // 
            this.pivotTableAnalyzeActionsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem33);
            this.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem34);
            this.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem182);
            this.pivotTableAnalyzeActionsRibbonPageGroup1.Name = "pivotTableAnalyzeActionsRibbonPageGroup1";
            // 
            // pivotTableAnalyzeCalculationsRibbonPageGroup1
            // 
            this.pivotTableAnalyzeCalculationsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pivotTableAnalyzeCalculationsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem35);
            this.pivotTableAnalyzeCalculationsRibbonPageGroup1.Name = "pivotTableAnalyzeCalculationsRibbonPageGroup1";
            // 
            // pivotTableAnalyzeShowRibbonPageGroup1
            // 
            this.pivotTableAnalyzeShowRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem34);
            this.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem35);
            this.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem36);
            this.pivotTableAnalyzeShowRibbonPageGroup1.Name = "pivotTableAnalyzeShowRibbonPageGroup1";
            // 
            // pivotTableDesignRibbonPage1
            // 
            this.pivotTableDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pivotTableDesignLayoutRibbonPageGroup1,
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1,
            this.pivotTableDesignPivotTableStylesRibbonPageGroup1});
            this.pivotTableDesignRibbonPage1.Name = "pivotTableDesignRibbonPage1";
            this.pivotTableDesignRibbonPage1.Visible = false;
            // 
            // pivotTableDesignLayoutRibbonPageGroup1
            // 
            this.pivotTableDesignLayoutRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem36);
            this.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem37);
            this.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem38);
            this.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem39);
            this.pivotTableDesignLayoutRibbonPageGroup1.Name = "pivotTableDesignLayoutRibbonPageGroup1";
            // 
            // pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1
            // 
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem37);
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem38);
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem39);
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem40);
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.Name = "pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1";
            // 
            // pivotTableDesignPivotTableStylesRibbonPageGroup1
            // 
            this.pivotTableDesignPivotTableStylesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pivotTableDesignPivotTableStylesRibbonPageGroup1.ItemLinks.Add(this.galleryPivotStylesItem1);
            this.pivotTableDesignPivotTableStylesRibbonPageGroup1.Name = "pivotTableDesignPivotTableStylesRibbonPageGroup1";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.infoRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem2);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem3);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem4);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem5);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem6);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem7);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem8);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem9);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // infoRibbonPageGroup1
            // 
            this.infoRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.infoRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem10);
            this.infoRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem11);
            this.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1";
            // 
            // homeRibbonPage1
            // 
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.clipboardRibbonPageGroup1,
            this.fontRibbonPageGroup1,
            this.alignmentRibbonPageGroup1,
            this.numberRibbonPageGroup1,
            this.stylesRibbonPageGroup1,
            this.cellsRibbonPageGroup1,
            this.editingRibbonPageGroup1});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable;
            reduceOperation1.GroupName = "stylesRibbonPageGroup1";
            reduceOperation1.ItemLinkIndex = 2;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
            this.homeRibbonPage1.ReduceOperations.Add(reduceOperation1);
            // 
            // clipboardRibbonPageGroup1
            // 
            this.clipboardRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem12);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem13);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem14);
            this.clipboardRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem15);
            this.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1";
            // 
            // fontRibbonPageGroup1
            // 
            this.fontRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup2);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup3);
            this.fontRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup4);
            this.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1";
            // 
            // alignmentRibbonPageGroup1
            // 
            this.alignmentRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup5);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup6);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup7);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem11);
            this.alignmentRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem2);
            this.alignmentRibbonPageGroup1.Name = "alignmentRibbonPageGroup1";
            // 
            // numberRibbonPageGroup1
            // 
            this.numberRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup8);
            this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup9);
            this.numberRibbonPageGroup1.ItemLinks.Add(this.barButtonGroup10);
            this.numberRibbonPageGroup1.Name = "numberRibbonPageGroup1";
            // 
            // stylesRibbonPageGroup1
            // 
            this.stylesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.stylesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem7);
            this.stylesRibbonPageGroup1.ItemLinks.Add(this.galleryFormatAsTableItem1);
            this.stylesRibbonPageGroup1.ItemLinks.Add(this.galleryChangeStyleItem1);
            this.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1";
            // 
            // cellsRibbonPageGroup1
            // 
            this.cellsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem8);
            this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem9);
            this.cellsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem11);
            this.cellsRibbonPageGroup1.Name = "cellsRibbonPageGroup1";
            // 
            // editingRibbonPageGroup1
            // 
            this.editingRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem12);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem13);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem14);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem15);
            this.editingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem16);
            this.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1";
            // 
            // insertRibbonPage1
            // 
            this.insertRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tablesRibbonPageGroup1,
            this.illustrationsRibbonPageGroup1,
            this.chartsRibbonPageGroup1,
            this.linksRibbonPageGroup1,
            this.symbolsRibbonPageGroup1});
            this.insertRibbonPage1.Name = "insertRibbonPage1";
            // 
            // tablesRibbonPageGroup1
            // 
            this.tablesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.tablesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem118);
            this.tablesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem119);
            this.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1";
            // 
            // illustrationsRibbonPageGroup1
            // 
            this.illustrationsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem120);
            this.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1";
            // 
            // chartsRibbonPageGroup1
            // 
            this.chartsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem4);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem5);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem6);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem7);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem8);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem9);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem10);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem11);
            this.chartsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem12);
            this.chartsRibbonPageGroup1.Name = "chartsRibbonPageGroup1";
            // 
            // linksRibbonPageGroup1
            // 
            this.linksRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.linksRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem121);
            this.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1";
            // 
            // symbolsRibbonPageGroup1
            // 
            this.symbolsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.symbolsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem122);
            this.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1";
            // 
            // pageLayoutRibbonPage1
            // 
            this.pageLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageSetupRibbonPageGroup1,
            this.pageSetupShowRibbonPageGroup1,
            this.pageSetupPrintRibbonPageGroup1,
            this.arrangeRibbonPageGroup1});
            this.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1";
            // 
            // pageSetupRibbonPageGroup1
            // 
            this.pageSetupRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem17);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem18);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.pageSetupPaperKindItem1);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem19);
            this.pageSetupRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem127);
            this.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1";
            // 
            // pageSetupShowRibbonPageGroup1
            // 
            this.pageSetupShowRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.pageSetupShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem20);
            this.pageSetupShowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem21);
            this.pageSetupShowRibbonPageGroup1.Name = "pageSetupShowRibbonPageGroup1";
            // 
            // pageSetupPrintRibbonPageGroup1
            // 
            this.pageSetupPrintRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem22);
            this.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem23);
            this.pageSetupPrintRibbonPageGroup1.Name = "pageSetupPrintRibbonPageGroup1";
            // 
            // arrangeRibbonPageGroup1
            // 
            this.arrangeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem20);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem21);
            this.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1";
            // 
            // formulasRibbonPage1
            // 
            this.formulasRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.functionLibraryRibbonPageGroup1,
            this.formulaDefinedNamesRibbonPageGroup1,
            this.formulaAuditingRibbonPageGroup1,
            this.formulaCalculationRibbonPageGroup1});
            this.formulasRibbonPage1.Name = "formulasRibbonPage1";
            // 
            // functionLibraryRibbonPageGroup1
            // 
            this.functionLibraryRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem22);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsFinancialItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsLogicalItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsTextItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsDateAndTimeItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsLookupAndReferenceItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.functionsMathAndTrigonometryItem1);
            this.functionLibraryRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem23);
            this.functionLibraryRibbonPageGroup1.Name = "functionLibraryRibbonPageGroup1";
            // 
            // formulaDefinedNamesRibbonPageGroup1
            // 
            this.formulaDefinedNamesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem132);
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem133);
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.definedNameListItem1);
            this.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem134);
            this.formulaDefinedNamesRibbonPageGroup1.Name = "formulaDefinedNamesRibbonPageGroup1";
            // 
            // formulaAuditingRibbonPageGroup1
            // 
            this.formulaAuditingRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.formulaAuditingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem24);
            this.formulaAuditingRibbonPageGroup1.Name = "formulaAuditingRibbonPageGroup1";
            // 
            // formulaCalculationRibbonPageGroup1
            // 
            this.formulaCalculationRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem24);
            this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem135);
            this.formulaCalculationRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem136);
            this.formulaCalculationRibbonPageGroup1.Name = "formulaCalculationRibbonPageGroup1";
            // 
            // dataRibbonPage1
            // 
            this.dataRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.sortAndFilterRibbonPageGroup1,
            this.dataToolsRibbonPageGroup1,
            this.outlineRibbonPageGroup1});
            this.dataRibbonPage1.Name = "dataRibbonPage1";
            // 
            // sortAndFilterRibbonPageGroup1
            // 
            this.sortAndFilterRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem107);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem108);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem14);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem109);
            this.sortAndFilterRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem110);
            this.sortAndFilterRibbonPageGroup1.Name = "sortAndFilterRibbonPageGroup1";
            // 
            // dataToolsRibbonPageGroup1
            // 
            this.dataToolsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.dataToolsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem25);
            this.dataToolsRibbonPageGroup1.Name = "dataToolsRibbonPageGroup1";
            // 
            // outlineRibbonPageGroup1
            // 
            this.outlineRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem26);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem27);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem144);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem145);
            this.outlineRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem146);
            this.outlineRibbonPageGroup1.Name = "outlineRibbonPageGroup1";
            // 
            // reviewRibbonPage1
            // 
            this.reviewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commentsRibbonPageGroup1,
            this.changesRibbonPageGroup1});
            this.reviewRibbonPage1.Name = "reviewRibbonPage1";
            // 
            // commentsRibbonPageGroup1
            // 
            this.commentsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem147);
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem148);
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem149);
            this.commentsRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem150);
            this.commentsRibbonPageGroup1.Name = "commentsRibbonPageGroup1";
            // 
            // changesRibbonPageGroup1
            // 
            this.changesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem90);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem151);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem152);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem153);
            this.changesRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem154);
            this.changesRibbonPageGroup1.Name = "changesRibbonPageGroup1";
            // 
            // viewRibbonPage1
            // 
            this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.showRibbonPageGroup1,
            this.zoomRibbonPageGroup1,
            this.windowRibbonPageGroup1});
            this.viewRibbonPage1.Name = "viewRibbonPage1";
            // 
            // showRibbonPageGroup1
            // 
            this.showRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.showRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem20);
            this.showRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem21);
            this.showRibbonPageGroup1.Name = "showRibbonPageGroup1";
            // 
            // zoomRibbonPageGroup1
            // 
            this.zoomRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem155);
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem156);
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem157);
            this.zoomRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem158);
            this.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1";
            // 
            // windowRibbonPageGroup1
            // 
            this.windowRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.windowRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem28);
            this.windowRibbonPageGroup1.Name = "windowRibbonPageGroup1";
            // 
            // mailMergeRibbonPage1
            // 
            this.mailMergeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mailMergeDataRibbonPageGroup1,
            this.mailMergeModeRibbonPageGroup1,
            this.mailMergeExtendedRibbonPageGroup1,
            this.mailMergeGroupingRibbonPageGroup1,
            this.mailMergeFilteringRibbonPageGroup1,
            this.mailMergeBindingRibbonPageGroup2});
            this.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1";
            // 
            // mailMergeDataRibbonPageGroup1
            // 
            this.mailMergeDataRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mailMergeDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem201);
            this.mailMergeDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem40);
            this.mailMergeDataRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem41);
            this.mailMergeDataRibbonPageGroup1.Name = "mailMergeDataRibbonPageGroup1";
            // 
            // mailMergeModeRibbonPageGroup1
            // 
            this.mailMergeModeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mailMergeModeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem41);
            this.mailMergeModeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem42);
            this.mailMergeModeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarCheckItem43);
            this.mailMergeModeRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem42);
            this.mailMergeModeRibbonPageGroup1.Name = "mailMergeModeRibbonPageGroup1";
            // 
            // mailMergeExtendedRibbonPageGroup1
            // 
            this.mailMergeExtendedRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem207);
            this.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem208);
            this.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem209);
            this.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarSubItem43);
            this.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem212);
            this.mailMergeExtendedRibbonPageGroup1.Name = "mailMergeExtendedRibbonPageGroup1";
            // 
            // mailMergeGroupingRibbonPageGroup1
            // 
            this.mailMergeGroupingRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem213);
            this.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem214);
            this.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem215);
            this.mailMergeGroupingRibbonPageGroup1.Name = "mailMergeGroupingRibbonPageGroup1";
            // 
            // mailMergeFilteringRibbonPageGroup1
            // 
            this.mailMergeFilteringRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mailMergeFilteringRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem216);
            this.mailMergeFilteringRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem217);
            this.mailMergeFilteringRibbonPageGroup1.Name = "mailMergeFilteringRibbonPageGroup1";
            // 
            // mailMergeBindingRibbonPageGroup2
            // 
            this.mailMergeBindingRibbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mailMergeBindingRibbonPageGroup2.ItemLinks.Add(this.spreadsheetCommandBarCheckItem46);
            this.mailMergeBindingRibbonPageGroup2.ItemLinks.Add(this.spreadsheetCommandBarButtonItem218);
            this.mailMergeBindingRibbonPageGroup2.Name = "mailMergeBindingRibbonPageGroup2";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.progressBarItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.endModeInfoStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.averageInfoStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.countInfoStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.numericalCountInfoStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.minInfoStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.maxInfoStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.sumInfoStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.zoomEditItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.showZoomButtonItem1);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 405);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1062, 27);
            // 
            // commandBarGalleryDropDown49
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown49.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown49.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown49.Gallery.DrawImageBackground = false;
            this.commandBarGalleryDropDown49.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.commandBarGalleryDropDown49.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown49.Gallery.ItemSize = new System.Drawing.Size(136, 26);
            this.commandBarGalleryDropDown49.Gallery.RowCount = 14;
            this.commandBarGalleryDropDown49.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown49.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown49.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown49.Manager = null;
            this.commandBarGalleryDropDown49.Name = "commandBarGalleryDropDown49";
            // 
            // commandBarGalleryDropDown51
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown51.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup49.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            spreadsheetCommandGalleryItem206.Caption = "Green - Yellow - Red Color Scale";
            spreadsheetCommandGalleryItem206.CommandName = "ConditionalFormattingColorScaleGreenYellowRed";
            spreadsheetCommandGalleryItem206.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem206.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem206.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image12")));
            spreadsheetCommandGalleryItem207.Caption = "Red - Yellow - Green Color Scale";
            spreadsheetCommandGalleryItem207.CommandName = "ConditionalFormattingColorScaleRedYellowGreen";
            spreadsheetCommandGalleryItem207.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem207.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem207.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image13")));
            spreadsheetCommandGalleryItem208.Caption = "Green - White - Red Color Scale";
            spreadsheetCommandGalleryItem208.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed";
            spreadsheetCommandGalleryItem208.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem208.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem208.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image14")));
            spreadsheetCommandGalleryItem209.Caption = "Red - White - Green Color Scale";
            spreadsheetCommandGalleryItem209.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen";
            spreadsheetCommandGalleryItem209.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem209.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem209.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image15")));
            spreadsheetCommandGalleryItem210.Caption = "Blue - White - Red Color Scale";
            spreadsheetCommandGalleryItem210.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed";
            spreadsheetCommandGalleryItem210.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem210.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem210.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image16")));
            spreadsheetCommandGalleryItem211.Caption = "Red - White - Blue Color Scale";
            spreadsheetCommandGalleryItem211.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue";
            spreadsheetCommandGalleryItem211.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem211.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem211.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image17")));
            spreadsheetCommandGalleryItem212.Caption = "White - Red Color Scale";
            spreadsheetCommandGalleryItem212.CommandName = "ConditionalFormattingColorScaleWhiteRed";
            spreadsheetCommandGalleryItem212.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem212.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem212.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image18")));
            spreadsheetCommandGalleryItem213.Caption = "Red - White Color Scale";
            spreadsheetCommandGalleryItem213.CommandName = "ConditionalFormattingColorScaleRedWhite";
            spreadsheetCommandGalleryItem213.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem213.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem213.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image19")));
            spreadsheetCommandGalleryItem214.Caption = "Green - White Color Scale";
            spreadsheetCommandGalleryItem214.CommandName = "ConditionalFormattingColorScaleGreenWhite";
            spreadsheetCommandGalleryItem214.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem214.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem214.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image20")));
            spreadsheetCommandGalleryItem215.Caption = "White - Green Color Scale";
            spreadsheetCommandGalleryItem215.CommandName = "ConditionalFormattingColorScaleWhiteGreen";
            spreadsheetCommandGalleryItem215.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem215.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem215.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image21")));
            spreadsheetCommandGalleryItem216.Caption = "Green - Yellow Color Scale";
            spreadsheetCommandGalleryItem216.CommandName = "ConditionalFormattingColorScaleGreenYellow";
            spreadsheetCommandGalleryItem216.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem216.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem216.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image22")));
            spreadsheetCommandGalleryItem217.Caption = "Yellow - Green Color Scale";
            spreadsheetCommandGalleryItem217.CommandName = "ConditionalFormattingColorScaleYellowGreen";
            spreadsheetCommandGalleryItem217.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem217.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" +
    "r represents the value in the cell.";
            spreadsheetCommandGalleryItem217.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image23")));
            spreadsheetCommandGalleryItemGroup49.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem206,
            spreadsheetCommandGalleryItem207,
            spreadsheetCommandGalleryItem208,
            spreadsheetCommandGalleryItem209,
            spreadsheetCommandGalleryItem210,
            spreadsheetCommandGalleryItem211,
            spreadsheetCommandGalleryItem212,
            spreadsheetCommandGalleryItem213,
            spreadsheetCommandGalleryItem214,
            spreadsheetCommandGalleryItem215,
            spreadsheetCommandGalleryItem216,
            spreadsheetCommandGalleryItem217});
            this.commandBarGalleryDropDown51.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup49});
            this.commandBarGalleryDropDown51.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown51.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown51.Manager = null;
            this.commandBarGalleryDropDown51.Name = "commandBarGalleryDropDown51";
            // 
            // commandBarGalleryDropDown52
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown52.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup50.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup";
            spreadsheetCommandGalleryItem218.Caption = "3 Arrows (Colored)";
            spreadsheetCommandGalleryItem218.CommandName = "ConditionalFormattingIconSetArrows3Colored";
            spreadsheetCommandGalleryItem218.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem218.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem218.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image24")));
            spreadsheetCommandGalleryItem219.Caption = "3 Arrows (Gray)";
            spreadsheetCommandGalleryItem219.CommandName = "ConditionalFormattingIconSetArrows3Grayed";
            spreadsheetCommandGalleryItem219.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem219.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem219.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image25")));
            spreadsheetCommandGalleryItem220.Caption = "4 Arrows (Colored)";
            spreadsheetCommandGalleryItem220.CommandName = "ConditionalFormattingIconSetArrows4Colored";
            spreadsheetCommandGalleryItem220.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem220.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem220.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image26")));
            spreadsheetCommandGalleryItem221.Caption = "4 Arrows (Gray)";
            spreadsheetCommandGalleryItem221.CommandName = "ConditionalFormattingIconSetArrows4Grayed";
            spreadsheetCommandGalleryItem221.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem221.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem221.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image27")));
            spreadsheetCommandGalleryItem222.Caption = "5 Arrows (Colored)";
            spreadsheetCommandGalleryItem222.CommandName = "ConditionalFormattingIconSetArrows5Colored";
            spreadsheetCommandGalleryItem222.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem222.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem222.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image28")));
            spreadsheetCommandGalleryItem223.Caption = "5 Arrows (Gray)";
            spreadsheetCommandGalleryItem223.CommandName = "ConditionalFormattingIconSetArrows5Grayed";
            spreadsheetCommandGalleryItem223.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem223.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem223.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image29")));
            spreadsheetCommandGalleryItem224.Caption = "3 Triangles";
            spreadsheetCommandGalleryItem224.CommandName = "ConditionalFormattingIconSetTriangles3";
            spreadsheetCommandGalleryItem224.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem224.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem224.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image30")));
            spreadsheetCommandGalleryItemGroup50.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem218,
            spreadsheetCommandGalleryItem219,
            spreadsheetCommandGalleryItem220,
            spreadsheetCommandGalleryItem221,
            spreadsheetCommandGalleryItem222,
            spreadsheetCommandGalleryItem223,
            spreadsheetCommandGalleryItem224});
            spreadsheetCommandGalleryItemGroup51.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup";
            spreadsheetCommandGalleryItem225.Caption = "3 Traffic Lights (Unrimmed)";
            spreadsheetCommandGalleryItem225.CommandName = "ConditionalFormattingIconSetTrafficLights3";
            spreadsheetCommandGalleryItem225.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem225.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem225.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image31")));
            spreadsheetCommandGalleryItem226.Caption = "3 Traffic Lights (Rimmed)";
            spreadsheetCommandGalleryItem226.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed";
            spreadsheetCommandGalleryItem226.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem226.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem226.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image32")));
            spreadsheetCommandGalleryItem227.Caption = "4 Traffic Lights";
            spreadsheetCommandGalleryItem227.CommandName = "ConditionalFormattingIconSetTrafficLights4";
            spreadsheetCommandGalleryItem227.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem227.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem227.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image33")));
            spreadsheetCommandGalleryItem228.Caption = "3 Signs";
            spreadsheetCommandGalleryItem228.CommandName = "ConditionalFormattingIconSetSigns3";
            spreadsheetCommandGalleryItem228.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem228.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem228.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image34")));
            spreadsheetCommandGalleryItem229.Caption = "Red To Black";
            spreadsheetCommandGalleryItem229.CommandName = "ConditionalFormattingIconSetRedToBlack";
            spreadsheetCommandGalleryItem229.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem229.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem229.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image35")));
            spreadsheetCommandGalleryItemGroup51.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem225,
            spreadsheetCommandGalleryItem226,
            spreadsheetCommandGalleryItem227,
            spreadsheetCommandGalleryItem228,
            spreadsheetCommandGalleryItem229});
            spreadsheetCommandGalleryItemGroup52.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup";
            spreadsheetCommandGalleryItem230.Caption = "3 Symbols (Circled)";
            spreadsheetCommandGalleryItem230.CommandName = "ConditionalFormattingIconSetSymbols3Circled";
            spreadsheetCommandGalleryItem230.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem230.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem230.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image36")));
            spreadsheetCommandGalleryItem231.Caption = "3 Symbols (Uncircled)";
            spreadsheetCommandGalleryItem231.CommandName = "ConditionalFormattingIconSetSymbols3";
            spreadsheetCommandGalleryItem231.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem231.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem231.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image37")));
            spreadsheetCommandGalleryItem232.Caption = "3 Flags";
            spreadsheetCommandGalleryItem232.CommandName = "ConditionalFormattingIconSetFlags3";
            spreadsheetCommandGalleryItem232.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem232.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem232.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image38")));
            spreadsheetCommandGalleryItemGroup52.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem230,
            spreadsheetCommandGalleryItem231,
            spreadsheetCommandGalleryItem232});
            spreadsheetCommandGalleryItemGroup53.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup";
            spreadsheetCommandGalleryItem233.Caption = "3 Stars";
            spreadsheetCommandGalleryItem233.CommandName = "ConditionalFormattingIconSetStars3";
            spreadsheetCommandGalleryItem233.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem233.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem233.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image39")));
            spreadsheetCommandGalleryItem234.Caption = "4 Ratings";
            spreadsheetCommandGalleryItem234.CommandName = "ConditionalFormattingIconSetRatings4";
            spreadsheetCommandGalleryItem234.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem234.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem234.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image40")));
            spreadsheetCommandGalleryItem235.Caption = "5 Ratings";
            spreadsheetCommandGalleryItem235.CommandName = "ConditionalFormattingIconSetRatings5";
            spreadsheetCommandGalleryItem235.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem235.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem235.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image41")));
            spreadsheetCommandGalleryItem236.Caption = "5 Quarters";
            spreadsheetCommandGalleryItem236.CommandName = "ConditionalFormattingIconSetQuarters5";
            spreadsheetCommandGalleryItem236.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem236.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem236.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image42")));
            spreadsheetCommandGalleryItem237.Caption = "5 Boxes";
            spreadsheetCommandGalleryItem237.CommandName = "ConditionalFormattingIconSetBoxes5";
            spreadsheetCommandGalleryItem237.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem237.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" +
    "e in the cell.";
            spreadsheetCommandGalleryItem237.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image43")));
            spreadsheetCommandGalleryItemGroup53.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem233,
            spreadsheetCommandGalleryItem234,
            spreadsheetCommandGalleryItem235,
            spreadsheetCommandGalleryItem236,
            spreadsheetCommandGalleryItem237});
            this.commandBarGalleryDropDown52.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup50,
            spreadsheetCommandGalleryItemGroup51,
            spreadsheetCommandGalleryItemGroup52,
            spreadsheetCommandGalleryItemGroup53});
            this.commandBarGalleryDropDown52.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown52.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown52.Manager = null;
            this.commandBarGalleryDropDown52.Name = "commandBarGalleryDropDown52";
            // 
            // commandBarGalleryDropDown53
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown53.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown53.Gallery.ColumnCount = 7;
            this.commandBarGalleryDropDown53.Gallery.DrawImageBackground = false;
            this.commandBarGalleryDropDown53.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown53.Gallery.ItemSize = new System.Drawing.Size(73, 58);
            this.commandBarGalleryDropDown53.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown53.Manager = null;
            this.commandBarGalleryDropDown53.Name = "commandBarGalleryDropDown53";
            // 
            // commandBarGalleryDropDown54
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown54.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup54.CommandName = "InsertChartColumn2DCommandGroup";
            spreadsheetCommandGalleryItem238.Caption = "Clustered Column";
            spreadsheetCommandGalleryItem238.CommandName = "InsertChartColumnClustered2D";
            spreadsheetCommandGalleryItem238.Description = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.";
            spreadsheetCommandGalleryItem238.Hint = "Compare values across categories by using vertical rectangles.\r\n\r\nUse it when the" +
    " order of categories is not important or for displaying item counts such as a hi" +
    "stogram.";
            spreadsheetCommandGalleryItem238.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image44")));
            spreadsheetCommandGalleryItem239.Caption = "Stacked Column";
            spreadsheetCommandGalleryItem239.CommandName = "InsertChartColumnStacked2D";
            spreadsheetCommandGalleryItem239.Description = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".";
            spreadsheetCommandGalleryItem239.Hint = "Compare the contribution of each value to a total across categories by using vert" +
    "ical rectangles.\r\n\r\nUse it to emphasize the total across series for one category" +
    ".";
            spreadsheetCommandGalleryItem239.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image45")));
            spreadsheetCommandGalleryItem240.Caption = "100% Stacked Column";
            spreadsheetCommandGalleryItem240.CommandName = "InsertChartColumnPercentStacked2D";
            spreadsheetCommandGalleryItem240.Description = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse is to emphasize the proportion of each data " +
    "series.";
            spreadsheetCommandGalleryItem240.Hint = "Compare the percentage that each value contributes to a total across categories b" +
    "y using vertical rectangles.\r\n\r\nUse is to emphasize the proportion of each data " +
    "series.";
            spreadsheetCommandGalleryItem240.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image46")));
            spreadsheetCommandGalleryItemGroup54.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem238,
            spreadsheetCommandGalleryItem239,
            spreadsheetCommandGalleryItem240});
            spreadsheetCommandGalleryItemGroup55.CommandName = "InsertChartColumn3DCommandGroup";
            spreadsheetCommandGalleryItem241.Caption = "3-D Clustered Column";
            spreadsheetCommandGalleryItem241.CommandName = "InsertChartColumnClustered3D";
            spreadsheetCommandGalleryItem241.Description = "Compare values across categories and display clustered columns in 3-D format.";
            spreadsheetCommandGalleryItem241.Hint = "Compare values across categories and display clustered columns in 3-D format.";
            spreadsheetCommandGalleryItem241.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image47")));
            spreadsheetCommandGalleryItem242.Caption = "Stacked Column in 3-D";
            spreadsheetCommandGalleryItem242.CommandName = "InsertChartColumnStacked3D";
            spreadsheetCommandGalleryItem242.Description = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            spreadsheetCommandGalleryItem242.Hint = "Compare the contribution of each value to a total across categories and display s" +
    "tacked columns in 3-D format.";
            spreadsheetCommandGalleryItem242.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image48")));
            spreadsheetCommandGalleryItem243.Caption = "100% Stacked Column in 3-D";
            spreadsheetCommandGalleryItem243.CommandName = "InsertChartColumnPercentStacked3D";
            spreadsheetCommandGalleryItem243.Description = "Compare the percentage that each value contributes to a total across categories a" +
    "nd display 100% stacked columns in 3-D format.";
            spreadsheetCommandGalleryItem243.Hint = "Compare the percentage that each value contributes to a total across categories a" +
    "nd display 100% stacked columns in 3-D format.";
            spreadsheetCommandGalleryItem243.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image49")));
            spreadsheetCommandGalleryItem244.Caption = "3-D Column";
            spreadsheetCommandGalleryItem244.CommandName = "InsertChartColumn3D";
            spreadsheetCommandGalleryItem244.Description = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.";
            spreadsheetCommandGalleryItem244.Hint = "Compare values across categories and across series on three axes.\r\n\r\nUse it when " +
    "the categories and series are equally important.";
            spreadsheetCommandGalleryItem244.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image50")));
            spreadsheetCommandGalleryItemGroup55.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem241,
            spreadsheetCommandGalleryItem242,
            spreadsheetCommandGalleryItem243,
            spreadsheetCommandGalleryItem244});
            spreadsheetCommandGalleryItemGroup56.CommandName = "InsertChartCylinderCommandGroup";
            spreadsheetCommandGalleryItem245.Caption = "Clustered Cylinder";
            spreadsheetCommandGalleryItem245.CommandName = "InsertChartCylinderClustered";
            spreadsheetCommandGalleryItem245.Description = "Compare values across categories.";
            spreadsheetCommandGalleryItem245.Hint = "Compare values across categories.";
            spreadsheetCommandGalleryItem245.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image51")));
            spreadsheetCommandGalleryItem246.Caption = "Stacked Cylinder";
            spreadsheetCommandGalleryItem246.CommandName = "InsertChartCylinderStacked";
            spreadsheetCommandGalleryItem246.Description = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem246.Hint = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem246.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image52")));
            spreadsheetCommandGalleryItem247.Caption = "100% Stacked Cylinder";
            spreadsheetCommandGalleryItem247.CommandName = "InsertChartCylinderPercentStacked";
            spreadsheetCommandGalleryItem247.Description = "Compare the percentage that each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem247.Hint = "Compare the percentage that each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem247.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image53")));
            spreadsheetCommandGalleryItem248.Caption = "3-D Cylinder";
            spreadsheetCommandGalleryItem248.CommandName = "InsertChartCylinder";
            spreadsheetCommandGalleryItem248.Description = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            spreadsheetCommandGalleryItem248.Hint = "Compare values across categories and across series and display a cylinder chart o" +
    "n three axes.";
            spreadsheetCommandGalleryItem248.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image54")));
            spreadsheetCommandGalleryItemGroup56.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem245,
            spreadsheetCommandGalleryItem246,
            spreadsheetCommandGalleryItem247,
            spreadsheetCommandGalleryItem248});
            spreadsheetCommandGalleryItemGroup57.CommandName = "InsertChartConeCommandGroup";
            spreadsheetCommandGalleryItem249.Caption = "Clustered Cone";
            spreadsheetCommandGalleryItem249.CommandName = "InsertChartConeClustered";
            spreadsheetCommandGalleryItem249.Description = "Compare values across categories.";
            spreadsheetCommandGalleryItem249.Hint = "Compare values across categories.";
            spreadsheetCommandGalleryItem249.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image55")));
            spreadsheetCommandGalleryItem250.Caption = "Stacked Cone";
            spreadsheetCommandGalleryItem250.CommandName = "InsertChartConeStacked";
            spreadsheetCommandGalleryItem250.Description = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem250.Hint = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem250.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image56")));
            spreadsheetCommandGalleryItem251.Caption = "100% Stacked Cone";
            spreadsheetCommandGalleryItem251.CommandName = "InsertChartConePercentStacked";
            spreadsheetCommandGalleryItem251.Description = "Compare the percentage that each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem251.Hint = "Compare the percentage that each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem251.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image57")));
            spreadsheetCommandGalleryItem252.Caption = "3-D Cone";
            spreadsheetCommandGalleryItem252.CommandName = "InsertChartCone";
            spreadsheetCommandGalleryItem252.Description = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            spreadsheetCommandGalleryItem252.Hint = "Compare values across categories and across series and display a cone chart on th" +
    "ree axes.";
            spreadsheetCommandGalleryItem252.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image58")));
            spreadsheetCommandGalleryItemGroup57.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem249,
            spreadsheetCommandGalleryItem250,
            spreadsheetCommandGalleryItem251,
            spreadsheetCommandGalleryItem252});
            spreadsheetCommandGalleryItemGroup58.CommandName = "InsertChartPyramidCommandGroup";
            spreadsheetCommandGalleryItem253.Caption = "Clustered Pyramid";
            spreadsheetCommandGalleryItem253.CommandName = "InsertChartPyramidClustered";
            spreadsheetCommandGalleryItem253.Description = "Compare values across categories.";
            spreadsheetCommandGalleryItem253.Hint = "Compare values across categories.";
            spreadsheetCommandGalleryItem253.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image59")));
            spreadsheetCommandGalleryItem254.Caption = "Stacked Pyramid";
            spreadsheetCommandGalleryItem254.CommandName = "InsertChartPyramidStacked";
            spreadsheetCommandGalleryItem254.Description = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem254.Hint = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem254.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image60")));
            spreadsheetCommandGalleryItem255.Caption = "100% Stacked Pyramid";
            spreadsheetCommandGalleryItem255.CommandName = "InsertChartPyramidPercentStacked";
            spreadsheetCommandGalleryItem255.Description = "Compare the percentage that each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem255.Hint = "Compare the percentage that each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem255.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image61")));
            spreadsheetCommandGalleryItem256.Caption = "3-D Pyramid";
            spreadsheetCommandGalleryItem256.CommandName = "InsertChartPyramid";
            spreadsheetCommandGalleryItem256.Description = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            spreadsheetCommandGalleryItem256.Hint = "Compare values across categories and across series and display a pyramid chart on" +
    " three axes.";
            spreadsheetCommandGalleryItem256.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image62")));
            spreadsheetCommandGalleryItemGroup58.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem253,
            spreadsheetCommandGalleryItem254,
            spreadsheetCommandGalleryItem255,
            spreadsheetCommandGalleryItem256});
            this.commandBarGalleryDropDown54.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup54,
            spreadsheetCommandGalleryItemGroup55,
            spreadsheetCommandGalleryItemGroup56,
            spreadsheetCommandGalleryItemGroup57,
            spreadsheetCommandGalleryItemGroup58});
            this.commandBarGalleryDropDown54.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown54.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown54.Manager = null;
            this.commandBarGalleryDropDown54.Name = "commandBarGalleryDropDown54";
            // 
            // commandBarGalleryDropDown55
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown55.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup59.CommandName = "InsertChartLine2DCommandGroup";
            spreadsheetCommandGalleryItem257.Caption = "Line";
            spreadsheetCommandGalleryItem257.CommandName = "InsertChartLine";
            spreadsheetCommandGalleryItem257.Description = "Display trend over time (dates, years) or ordered categories.\r\n\r\nUseful when ther" +
    "e are many data points and the order is important.";
            spreadsheetCommandGalleryItem257.Hint = "Display trend over time (dates, years) or ordered categories.\r\n\r\nUseful when ther" +
    "e are many data points and the order is important.";
            spreadsheetCommandGalleryItem257.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image63")));
            spreadsheetCommandGalleryItem258.Caption = "Stacked Line";
            spreadsheetCommandGalleryItem258.CommandName = "InsertChartStackedLine";
            spreadsheetCommandGalleryItem258.Description = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.\r\n\r\nConsider using a stacked area chart instead.";
            spreadsheetCommandGalleryItem258.Hint = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.\r\n\r\nConsider using a stacked area chart instead.";
            spreadsheetCommandGalleryItem258.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image64")));
            spreadsheetCommandGalleryItem259.Caption = "100% Stacked line";
            spreadsheetCommandGalleryItem259.CommandName = "InsertChartPercentStackedLine";
            spreadsheetCommandGalleryItem259.Description = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.\r\n\r\nConsider using 100% stacked area chart instead.";
            spreadsheetCommandGalleryItem259.Hint = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.\r\n\r\nConsider using 100% stacked area chart instead.";
            spreadsheetCommandGalleryItem259.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image65")));
            spreadsheetCommandGalleryItem260.Caption = "Line with Markers";
            spreadsheetCommandGalleryItem260.CommandName = "InsertChartLineWithMarkers";
            spreadsheetCommandGalleryItem260.Description = "Display trend over time (dates, years) or ordered categories.\r\n\r\nUseful when ther" +
    "e are only a few data points.";
            spreadsheetCommandGalleryItem260.Hint = "Display trend over time (dates, years) or ordered categories.\r\n\r\nUseful when ther" +
    "e are only a few data points.";
            spreadsheetCommandGalleryItem260.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image66")));
            spreadsheetCommandGalleryItem261.Caption = "Stacked Line with Markers";
            spreadsheetCommandGalleryItem261.CommandName = "InsertChartStackedLineWithMarkers";
            spreadsheetCommandGalleryItem261.Description = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.\r\n\r\nConsider using a stacked area chart instead.";
            spreadsheetCommandGalleryItem261.Hint = "Display the trend of the contribution of each value over time or ordered categori" +
    "es.\r\n\r\nConsider using a stacked area chart instead.";
            spreadsheetCommandGalleryItem261.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image67")));
            spreadsheetCommandGalleryItem262.Caption = "100% Stacked Line with Markers";
            spreadsheetCommandGalleryItem262.CommandName = "InsertChartPercentStackedLineWithMarkers";
            spreadsheetCommandGalleryItem262.Description = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.\r\n\r\nConsider using 100% stacked area chart instead.";
            spreadsheetCommandGalleryItem262.Hint = "Display the trend of the percentage each value contributes over time or ordered c" +
    "ategories.\r\n\r\nConsider using 100% stacked area chart instead.";
            spreadsheetCommandGalleryItem262.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image68")));
            spreadsheetCommandGalleryItemGroup59.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem257,
            spreadsheetCommandGalleryItem258,
            spreadsheetCommandGalleryItem259,
            spreadsheetCommandGalleryItem260,
            spreadsheetCommandGalleryItem261,
            spreadsheetCommandGalleryItem262});
            spreadsheetCommandGalleryItemGroup60.CommandName = "InsertChartLine3DCommandGroup";
            spreadsheetCommandGalleryItem263.Caption = "3-D Line";
            spreadsheetCommandGalleryItem263.CommandName = "InsertChartLine3D";
            spreadsheetCommandGalleryItem263.Description = "Display each row or column of data as a 3-D ribbon on three axes.";
            spreadsheetCommandGalleryItem263.Hint = "Display each row or column of data as a 3-D ribbon on three axes.";
            spreadsheetCommandGalleryItem263.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image69")));
            spreadsheetCommandGalleryItemGroup60.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem263});
            this.commandBarGalleryDropDown55.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup59,
            spreadsheetCommandGalleryItemGroup60});
            this.commandBarGalleryDropDown55.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown55.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown55.Manager = null;
            this.commandBarGalleryDropDown55.Name = "commandBarGalleryDropDown55";
            // 
            // commandBarGalleryDropDown56
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown56.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup61.CommandName = "InsertChartPie2DCommandGroup";
            spreadsheetCommandGalleryItem264.Caption = "Pie";
            spreadsheetCommandGalleryItem264.CommandName = "InsertChartPie2D";
            spreadsheetCommandGalleryItem264.Description = "Display the contribution of each value to a total.\r\n\r\nUse it when the values can " +
    "be added together or when you have only one data series and all values are posit" +
    "ive.";
            spreadsheetCommandGalleryItem264.Hint = "Display the contribution of each value to a total.\r\n\r\nUse it when the values can " +
    "be added together or when you have only one data series and all values are posit" +
    "ive.";
            spreadsheetCommandGalleryItem264.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image70")));
            spreadsheetCommandGalleryItem265.Caption = "Exploded Pie";
            spreadsheetCommandGalleryItem265.CommandName = "InsertChartPieExploded2D";
            spreadsheetCommandGalleryItem265.Description = "Display the contribution of each value to a total while emphasizing individual va" +
    "lues.\r\n\r\nConsider using a pie chart, and explode individual values instead.";
            spreadsheetCommandGalleryItem265.Hint = "Display the contribution of each value to a total while emphasizing individual va" +
    "lues.\r\n\r\nConsider using a pie chart, and explode individual values instead.";
            spreadsheetCommandGalleryItem265.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image71")));
            spreadsheetCommandGalleryItemGroup61.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem264,
            spreadsheetCommandGalleryItem265});
            spreadsheetCommandGalleryItemGroup62.CommandName = "InsertChartPie3DCommandGroup";
            spreadsheetCommandGalleryItem266.Caption = "Pie in 3-D";
            spreadsheetCommandGalleryItem266.CommandName = "InsertChartPie3D";
            spreadsheetCommandGalleryItem266.Description = "Display the contribution of each value to a total.";
            spreadsheetCommandGalleryItem266.Hint = "Display the contribution of each value to a total.";
            spreadsheetCommandGalleryItem266.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image72")));
            spreadsheetCommandGalleryItem267.Caption = "Exploded pie in 3-D";
            spreadsheetCommandGalleryItem267.CommandName = "InsertChartPieExploded3D";
            spreadsheetCommandGalleryItem267.Description = "Display the contribution of each value to a total while emphasizing individual va" +
    "lues.\r\n\r\nConsider using a 3-D pie chart, and explode individual values instead.";
            spreadsheetCommandGalleryItem267.Hint = "Display the contribution of each value to a total while emphasizing individual va" +
    "lues.\r\n\r\nConsider using a 3-D pie chart, and explode individual values instead.";
            spreadsheetCommandGalleryItem267.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image73")));
            spreadsheetCommandGalleryItemGroup62.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem266,
            spreadsheetCommandGalleryItem267});
            spreadsheetCommandGalleryItemGroup63.CommandName = "InsertChartDoughnut2DCommandGroup";
            spreadsheetCommandGalleryItem268.Caption = "Doughnut";
            spreadsheetCommandGalleryItem268.CommandName = "InsertChartDoughnut2D";
            spreadsheetCommandGalleryItem268.Description = "Display the contribution of each value to a total like a pie chart, but it can co" +
    "ntain multiple series.";
            spreadsheetCommandGalleryItem268.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" +
    "ntain multiple series.";
            spreadsheetCommandGalleryItem268.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image74")));
            spreadsheetCommandGalleryItem269.Caption = "Exploded Doughnut";
            spreadsheetCommandGalleryItem269.CommandName = "InsertChartDoughnutExploded2D";
            spreadsheetCommandGalleryItem269.Description = "Display the contribution of each value to a total while emphasizing individual va" +
    "lues like an exploded pie chart, but it can contain multiple series.";
            spreadsheetCommandGalleryItem269.Hint = "Display the contribution of each value to a total while emphasizing individual va" +
    "lues like an exploded pie chart, but it can contain multiple series.";
            spreadsheetCommandGalleryItem269.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image75")));
            spreadsheetCommandGalleryItemGroup63.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem268,
            spreadsheetCommandGalleryItem269});
            this.commandBarGalleryDropDown56.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup61,
            spreadsheetCommandGalleryItemGroup62,
            spreadsheetCommandGalleryItemGroup63});
            this.commandBarGalleryDropDown56.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown56.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown56.Manager = null;
            this.commandBarGalleryDropDown56.Name = "commandBarGalleryDropDown56";
            // 
            // commandBarGalleryDropDown57
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown57.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup64.CommandName = "InsertChartBar2DCommandGroup";
            spreadsheetCommandGalleryItem270.Caption = "Clustered Bar";
            spreadsheetCommandGalleryItem270.CommandName = "InsertChartBarClustered2D";
            spreadsheetCommandGalleryItem270.Description = "Compare values across categories using horizontal rectangles.\r\n\r\nUse it when the " +
    "values on the chart represent durations or when the category text is very long.";
            spreadsheetCommandGalleryItem270.Hint = "Compare values across categories using horizontal rectangles.\r\n\r\nUse it when the " +
    "values on the chart represent durations or when the category text is very long.";
            spreadsheetCommandGalleryItem270.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image76")));
            spreadsheetCommandGalleryItem271.Caption = "Stacked Bar";
            spreadsheetCommandGalleryItem271.CommandName = "InsertChartBarStacked2D";
            spreadsheetCommandGalleryItem271.Description = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.\r\n\r\nUse it when the values on the chart represent durations or" +
    " when the category text is very long.";
            spreadsheetCommandGalleryItem271.Hint = "Compare the contribution of each value to a total across categories by using hori" +
    "zontal rectangles.\r\n\r\nUse it when the values on the chart represent durations or" +
    " when the category text is very long.";
            spreadsheetCommandGalleryItem271.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image77")));
            spreadsheetCommandGalleryItem272.Caption = "100% Stacked Bar";
            spreadsheetCommandGalleryItem272.CommandName = "InsertChartBarPercentStacked2D";
            spreadsheetCommandGalleryItem272.Description = resources.GetString("spreadsheetCommandGalleryItem272.Description");
            spreadsheetCommandGalleryItem272.Hint = resources.GetString("spreadsheetCommandGalleryItem272.Hint");
            spreadsheetCommandGalleryItem272.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image78")));
            spreadsheetCommandGalleryItemGroup64.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem270,
            spreadsheetCommandGalleryItem271,
            spreadsheetCommandGalleryItem272});
            spreadsheetCommandGalleryItemGroup65.CommandName = "InsertChartBar3DCommandGroup";
            spreadsheetCommandGalleryItem273.Caption = "Clustered Bar in 3-D";
            spreadsheetCommandGalleryItem273.CommandName = "InsertChartBarClustered3D";
            spreadsheetCommandGalleryItem273.Description = "Compare values across categories and display clustered bars in 3-D format.";
            spreadsheetCommandGalleryItem273.Hint = "Compare values across categories and display clustered bars in 3-D format.";
            spreadsheetCommandGalleryItem273.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image79")));
            spreadsheetCommandGalleryItem274.Caption = "Stacked Bar in 3-D";
            spreadsheetCommandGalleryItem274.CommandName = "InsertChartBarStacked3D";
            spreadsheetCommandGalleryItem274.Description = "Compare the contribution of each value to a total across categories and display s" +
    "tacked bars in 3-D format.";
            spreadsheetCommandGalleryItem274.Hint = "Compare the contribution of each value to a total across categories and display s" +
    "tacked bars in 3-D format.";
            spreadsheetCommandGalleryItem274.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image80")));
            spreadsheetCommandGalleryItem275.Caption = "100% Stacked Bar in 3-D";
            spreadsheetCommandGalleryItem275.CommandName = "InsertChartBarPercentStacked3D";
            spreadsheetCommandGalleryItem275.Description = "Compare the percentange each value contributes to a total across categories and d" +
    "isplay 100% stacked bars in 3-D format.";
            spreadsheetCommandGalleryItem275.Hint = "Compare the percentange each value contributes to a total across categories and d" +
    "isplay 100% stacked bars in 3-D format.";
            spreadsheetCommandGalleryItem275.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image81")));
            spreadsheetCommandGalleryItemGroup65.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem273,
            spreadsheetCommandGalleryItem274,
            spreadsheetCommandGalleryItem275});
            spreadsheetCommandGalleryItemGroup66.CommandName = "InsertChartHorizontalCylinderCommandGroup";
            spreadsheetCommandGalleryItem276.Caption = "Clustered Horizontal Cylinder";
            spreadsheetCommandGalleryItem276.CommandName = "InsertChartHorizontalCylinderClustered";
            spreadsheetCommandGalleryItem276.Description = "Compare values across categories.";
            spreadsheetCommandGalleryItem276.Hint = "Compare values across categories.";
            spreadsheetCommandGalleryItem276.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image82")));
            spreadsheetCommandGalleryItem277.Caption = "Stacked Horizontal Cylinder";
            spreadsheetCommandGalleryItem277.CommandName = "InsertChartHorizontalCylinderStacked";
            spreadsheetCommandGalleryItem277.Description = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem277.Hint = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem277.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image83")));
            spreadsheetCommandGalleryItem278.Caption = "100% Stacked Horizontal Cylinder";
            spreadsheetCommandGalleryItem278.CommandName = "InsertChartHorizontalCylinderPercentStacked";
            spreadsheetCommandGalleryItem278.Description = "Compare the percentange each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem278.Hint = "Compare the percentange each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem278.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image84")));
            spreadsheetCommandGalleryItemGroup66.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem276,
            spreadsheetCommandGalleryItem277,
            spreadsheetCommandGalleryItem278});
            spreadsheetCommandGalleryItemGroup67.CommandName = "InsertChartHorizontalConeCommandGroup";
            spreadsheetCommandGalleryItem279.Caption = "Clustered Horizontal Cone";
            spreadsheetCommandGalleryItem279.CommandName = "InsertChartHorizontalConeClustered";
            spreadsheetCommandGalleryItem279.Description = "Compare values across categories.";
            spreadsheetCommandGalleryItem279.Hint = "Compare values across categories.";
            spreadsheetCommandGalleryItem279.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image85")));
            spreadsheetCommandGalleryItem280.Caption = "Stacked Horizontal Cone";
            spreadsheetCommandGalleryItem280.CommandName = "InsertChartHorizontalConeStacked";
            spreadsheetCommandGalleryItem280.Description = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem280.Hint = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem280.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image86")));
            spreadsheetCommandGalleryItem281.Caption = "100% Stacked Horizontal Cone";
            spreadsheetCommandGalleryItem281.CommandName = "InsertChartHorizontalConePercentStacked";
            spreadsheetCommandGalleryItem281.Description = "Compare the percentange each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem281.Hint = "Compare the percentange each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem281.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image87")));
            spreadsheetCommandGalleryItemGroup67.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem279,
            spreadsheetCommandGalleryItem280,
            spreadsheetCommandGalleryItem281});
            spreadsheetCommandGalleryItemGroup68.CommandName = "InsertChartHorizontalPyramidCommandGroup";
            spreadsheetCommandGalleryItem282.Caption = "Clustered Horizontal Pyramid";
            spreadsheetCommandGalleryItem282.CommandName = "InsertChartHorizontalPyramidClustered";
            spreadsheetCommandGalleryItem282.Description = "Compare values across categories.";
            spreadsheetCommandGalleryItem282.Hint = "Compare values across categories.";
            spreadsheetCommandGalleryItem282.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image88")));
            spreadsheetCommandGalleryItem283.Caption = "Stacked Horizontal Pyramid";
            spreadsheetCommandGalleryItem283.CommandName = "InsertChartHorizontalPyramidStacked";
            spreadsheetCommandGalleryItem283.Description = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem283.Hint = "Compare the contribution of each value to a total across categories.";
            spreadsheetCommandGalleryItem283.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image89")));
            spreadsheetCommandGalleryItem284.Caption = "100% Stacked Horizontal Pyramid";
            spreadsheetCommandGalleryItem284.CommandName = "InsertChartHorizontalPyramidPercentStacked";
            spreadsheetCommandGalleryItem284.Description = "Compare the percentange each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem284.Hint = "Compare the percentange each value contributes to a total across categories.";
            spreadsheetCommandGalleryItem284.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image90")));
            spreadsheetCommandGalleryItemGroup68.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem282,
            spreadsheetCommandGalleryItem283,
            spreadsheetCommandGalleryItem284});
            this.commandBarGalleryDropDown57.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup64,
            spreadsheetCommandGalleryItemGroup65,
            spreadsheetCommandGalleryItemGroup66,
            spreadsheetCommandGalleryItemGroup67,
            spreadsheetCommandGalleryItemGroup68});
            this.commandBarGalleryDropDown57.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown57.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown57.Manager = null;
            this.commandBarGalleryDropDown57.Name = "commandBarGalleryDropDown57";
            // 
            // commandBarGalleryDropDown58
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown58.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup69.CommandName = "InsertChartArea2DCommandGroup";
            spreadsheetCommandGalleryItem285.Caption = "Area";
            spreadsheetCommandGalleryItem285.CommandName = "InsertChartArea";
            spreadsheetCommandGalleryItem285.Description = "Display the trend of values over time or categories.";
            spreadsheetCommandGalleryItem285.Hint = "Display the trend of values over time or categories.";
            spreadsheetCommandGalleryItem285.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image91")));
            spreadsheetCommandGalleryItem286.Caption = "Stacked Area";
            spreadsheetCommandGalleryItem286.CommandName = "InsertChartStackedArea";
            spreadsheetCommandGalleryItem286.Description = "Display the trend of the contribution of each value over time or categories.\r\n\r\nU" +
    "se it to emphasize the trend in the total across series for one category.";
            spreadsheetCommandGalleryItem286.Hint = "Display the trend of the contribution of each value over time or categories.\r\n\r\nU" +
    "se it to emphasize the trend in the total across series for one category.";
            spreadsheetCommandGalleryItem286.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image92")));
            spreadsheetCommandGalleryItem287.Caption = "100% Stacked Area";
            spreadsheetCommandGalleryItem287.CommandName = "InsertChartPercentStackedArea";
            spreadsheetCommandGalleryItem287.Description = "Display the trend of the percentage each value contibutes over time or categories" +
    ".\r\n\r\nUse it to emphasize the trend in the proportion of each series.";
            spreadsheetCommandGalleryItem287.Hint = "Display the trend of the percentage each value contibutes over time or categories" +
    ".\r\n\r\nUse it to emphasize the trend in the proportion of each series.";
            spreadsheetCommandGalleryItem287.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image93")));
            spreadsheetCommandGalleryItemGroup69.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem285,
            spreadsheetCommandGalleryItem286,
            spreadsheetCommandGalleryItem287});
            spreadsheetCommandGalleryItemGroup70.CommandName = "InsertChartArea3DCommandGroup";
            spreadsheetCommandGalleryItem288.Caption = "3-D Area";
            spreadsheetCommandGalleryItem288.CommandName = "InsertChartArea3D";
            spreadsheetCommandGalleryItem288.Description = "Display the trend of values over time or categories using areas on three axes.";
            spreadsheetCommandGalleryItem288.Hint = "Display the trend of values over time or categories using areas on three axes.";
            spreadsheetCommandGalleryItem288.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image94")));
            spreadsheetCommandGalleryItem289.Caption = "Stacked Area in 3-D";
            spreadsheetCommandGalleryItem289.CommandName = "InsertChartStackedArea3D";
            spreadsheetCommandGalleryItem289.Description = "Display the trend of the contribution of each value over time or categories by us" +
    "ing stacked areas in a 3-D format.";
            spreadsheetCommandGalleryItem289.Hint = "Display the trend of the contribution of each value over time or categories by us" +
    "ing stacked areas in a 3-D format.";
            spreadsheetCommandGalleryItem289.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image95")));
            spreadsheetCommandGalleryItem290.Caption = "100% Stacked Area in 3-D";
            spreadsheetCommandGalleryItem290.CommandName = "InsertChartPercentStackedArea3D";
            spreadsheetCommandGalleryItem290.Description = "Display the trend of the percentage each value contributes over time or categorie" +
    "s by using 100% stacked areas in 3-D format.";
            spreadsheetCommandGalleryItem290.Hint = "Display the trend of the percentage each value contributes over time or categorie" +
    "s by using 100% stacked areas in 3-D format.";
            spreadsheetCommandGalleryItem290.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image96")));
            spreadsheetCommandGalleryItemGroup70.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem288,
            spreadsheetCommandGalleryItem289,
            spreadsheetCommandGalleryItem290});
            this.commandBarGalleryDropDown58.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup69,
            spreadsheetCommandGalleryItemGroup70});
            this.commandBarGalleryDropDown58.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown58.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown58.Manager = null;
            this.commandBarGalleryDropDown58.Name = "commandBarGalleryDropDown58";
            // 
            // commandBarGalleryDropDown59
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown59.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup71.CommandName = "InsertChartScatterCommandGroup";
            spreadsheetCommandGalleryItem291.Caption = "Scatter with only Markers";
            spreadsheetCommandGalleryItem291.CommandName = "InsertChartScatterMarkers";
            spreadsheetCommandGalleryItem291.Description = "Compare pairs of values.\r\n\r\nUse is when the values are not in X-axis order or whe" +
    "n they represent separate measurements.";
            spreadsheetCommandGalleryItem291.Hint = "Compare pairs of values.\r\n\r\nUse is when the values are not in X-axis order or whe" +
    "n they represent separate measurements.";
            spreadsheetCommandGalleryItem291.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image97")));
            spreadsheetCommandGalleryItem292.Caption = "Scatter with Smooth Lines and Markers";
            spreadsheetCommandGalleryItem292.CommandName = "InsertChartScatterSmoothLinesAndMarkers";
            spreadsheetCommandGalleryItem292.Description = "Compare pairs of values.\r\n\r\nUse is when there are a few data points in X-axis ord" +
    "er and the data represents a function.";
            spreadsheetCommandGalleryItem292.Hint = "Compare pairs of values.\r\n\r\nUse is when there are a few data points in X-axis ord" +
    "er and the data represents a function.";
            spreadsheetCommandGalleryItem292.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image98")));
            spreadsheetCommandGalleryItem293.Caption = "Scatter with Smooth Lines";
            spreadsheetCommandGalleryItem293.CommandName = "InsertChartScatterSmoothLines";
            spreadsheetCommandGalleryItem293.Description = "Compare pairs of values.\r\n\r\nUse is when there are many data points in X-axis orde" +
    "r and the data represents a function.";
            spreadsheetCommandGalleryItem293.Hint = "Compare pairs of values.\r\n\r\nUse is when there are many data points in X-axis orde" +
    "r and the data represents a function.";
            spreadsheetCommandGalleryItem293.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image99")));
            spreadsheetCommandGalleryItem294.Caption = "Scatter with Straight Lines and Markers";
            spreadsheetCommandGalleryItem294.CommandName = "InsertChartScatterLinesAndMarkers";
            spreadsheetCommandGalleryItem294.Description = "Compare pairs of values.\r\n\r\nUse is when there are a few data points in X-axis ord" +
    "er and the data represents separate samples.";
            spreadsheetCommandGalleryItem294.Hint = "Compare pairs of values.\r\n\r\nUse is when there are a few data points in X-axis ord" +
    "er and the data represents separate samples.";
            spreadsheetCommandGalleryItem294.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image100")));
            spreadsheetCommandGalleryItem295.Caption = "Scatter with Straight Lines";
            spreadsheetCommandGalleryItem295.CommandName = "InsertChartScatterLines";
            spreadsheetCommandGalleryItem295.Description = "Compare pairs of values.\r\n\r\nUse is when there are many data points in X-axis orde" +
    "r and the data represents separate samples.";
            spreadsheetCommandGalleryItem295.Hint = "Compare pairs of values.\r\n\r\nUse is when there are many data points in X-axis orde" +
    "r and the data represents separate samples.";
            spreadsheetCommandGalleryItem295.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image101")));
            spreadsheetCommandGalleryItemGroup71.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem291,
            spreadsheetCommandGalleryItem292,
            spreadsheetCommandGalleryItem293,
            spreadsheetCommandGalleryItem294,
            spreadsheetCommandGalleryItem295});
            spreadsheetCommandGalleryItemGroup72.CommandName = "InsertChartBubbleCommandGroup";
            spreadsheetCommandGalleryItem296.Caption = "Bubble";
            spreadsheetCommandGalleryItem296.CommandName = "InsertChartBubble";
            spreadsheetCommandGalleryItem296.Description = "Resembles a scatter chart, but compares sets of three values instead of two. The " +
    "third value determines the size of the bubble marker.";
            spreadsheetCommandGalleryItem296.Hint = "Resembles a scatter chart, but compares sets of three values instead of two. The " +
    "third value determines the size of the bubble marker.";
            spreadsheetCommandGalleryItem296.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image102")));
            spreadsheetCommandGalleryItem297.Caption = "Bubble with a 3-D effect";
            spreadsheetCommandGalleryItem297.CommandName = "InsertChartBubble3D";
            spreadsheetCommandGalleryItem297.Description = "Resembles a scatter chart, but compares sets of three values instead of two. The " +
    "third value determines the size of the bubble marker, which is displayed with a " +
    "3-D effect.";
            spreadsheetCommandGalleryItem297.Hint = "Resembles a scatter chart, but compares sets of three values instead of two. The " +
    "third value determines the size of the bubble marker, which is displayed with a " +
    "3-D effect.";
            spreadsheetCommandGalleryItem297.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image103")));
            spreadsheetCommandGalleryItemGroup72.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem296,
            spreadsheetCommandGalleryItem297});
            this.commandBarGalleryDropDown59.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup71,
            spreadsheetCommandGalleryItemGroup72});
            this.commandBarGalleryDropDown59.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown59.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown59.Manager = null;
            this.commandBarGalleryDropDown59.Name = "commandBarGalleryDropDown59";
            // 
            // commandBarGalleryDropDown60
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown60.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup73.CommandName = "InsertChartStockCommandGroup";
            spreadsheetCommandGalleryItem298.Caption = "High-Low-Close";
            spreadsheetCommandGalleryItem298.CommandName = "InsertChartStockHighLowClose";
            spreadsheetCommandGalleryItem298.Description = "Requires three series of values in order High, Low and Close.";
            spreadsheetCommandGalleryItem298.Hint = "Requires three series of values in order High, Low and Close.";
            spreadsheetCommandGalleryItem298.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image104")));
            spreadsheetCommandGalleryItem299.Caption = "Open-High-Low-Close";
            spreadsheetCommandGalleryItem299.CommandName = "InsertChartStockOpenHighLowClose";
            spreadsheetCommandGalleryItem299.Description = "Requires four series of values in order Open, High, Low and Close.";
            spreadsheetCommandGalleryItem299.Hint = "Requires four series of values in order Open, High, Low and Close.";
            spreadsheetCommandGalleryItem299.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image105")));
            spreadsheetCommandGalleryItem300.Caption = "Volume-High-Low-Close";
            spreadsheetCommandGalleryItem300.CommandName = "InsertChartStockVolumeHighLowClose";
            spreadsheetCommandGalleryItem300.Description = "Requires four series of values in order Volume, High, Low and Close.";
            spreadsheetCommandGalleryItem300.Hint = "Requires four series of values in order Volume, High, Low and Close.";
            spreadsheetCommandGalleryItem300.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image106")));
            spreadsheetCommandGalleryItem301.Caption = "Volume-Open-High-Low-Close";
            spreadsheetCommandGalleryItem301.CommandName = "InsertChartStockVolumeOpenHighLowClose";
            spreadsheetCommandGalleryItem301.Description = "Requires five series of values in order Volume, Open, High, Low and Close.";
            spreadsheetCommandGalleryItem301.Hint = "Requires five series of values in order Volume, Open, High, Low and Close.";
            spreadsheetCommandGalleryItem301.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image107")));
            spreadsheetCommandGalleryItemGroup73.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem298,
            spreadsheetCommandGalleryItem299,
            spreadsheetCommandGalleryItem300,
            spreadsheetCommandGalleryItem301});
            spreadsheetCommandGalleryItemGroup74.CommandName = "InsertChartRadarCommandGroup";
            spreadsheetCommandGalleryItem302.Caption = "Radar";
            spreadsheetCommandGalleryItem302.CommandName = "InsertChartRadar";
            spreadsheetCommandGalleryItem302.Description = "Display values relative to a center point.\r\n\r\nUse it when the categories are not " +
    "directly comparable.";
            spreadsheetCommandGalleryItem302.Hint = "Display values relative to a center point.\r\n\r\nUse it when the categories are not " +
    "directly comparable.";
            spreadsheetCommandGalleryItem302.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image108")));
            spreadsheetCommandGalleryItem303.Caption = "Radar with Markers";
            spreadsheetCommandGalleryItem303.CommandName = "InsertChartRadarWithMarkers";
            spreadsheetCommandGalleryItem303.Description = "Display values relative to a center point.\r\n\r\nUse it when the categories are not " +
    "directly comparable.";
            spreadsheetCommandGalleryItem303.Hint = "Display values relative to a center point.\r\n\r\nUse it when the categories are not " +
    "directly comparable.";
            spreadsheetCommandGalleryItem303.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image109")));
            spreadsheetCommandGalleryItem304.Caption = "Filled Radar";
            spreadsheetCommandGalleryItem304.CommandName = "InsertChartRadarFilled";
            spreadsheetCommandGalleryItem304.Description = "Display values relative to a center point.\r\n\r\nUse it when the categories are not " +
    "directly comparable and there is only one series.";
            spreadsheetCommandGalleryItem304.Hint = "Display values relative to a center point.\r\n\r\nUse it when the categories are not " +
    "directly comparable and there is only one series.";
            spreadsheetCommandGalleryItem304.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image110")));
            spreadsheetCommandGalleryItemGroup74.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem302,
            spreadsheetCommandGalleryItem303,
            spreadsheetCommandGalleryItem304});
            this.commandBarGalleryDropDown60.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup73,
            spreadsheetCommandGalleryItemGroup74});
            this.commandBarGalleryDropDown60.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown60.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown60.Manager = null;
            this.commandBarGalleryDropDown60.Name = "commandBarGalleryDropDown60";
            // 
            // commandBarGalleryDropDown61
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown61.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown61.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup75.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            spreadsheetCommandGalleryItem305.Caption = "None";
            spreadsheetCommandGalleryItem305.CommandName = "ChartHidePrimaryHorizontalAxis";
            spreadsheetCommandGalleryItem305.Description = "Do not display axis.";
            spreadsheetCommandGalleryItem305.Hint = "Do not display axis.";
            spreadsheetCommandGalleryItem305.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image111")));
            spreadsheetCommandGalleryItem306.Caption = "Show Left to Right Axis";
            spreadsheetCommandGalleryItem306.CommandName = "ChartPrimaryHorizontalAxisLeftToRight";
            spreadsheetCommandGalleryItem306.Description = "Display Axis Left to Right with Labels";
            spreadsheetCommandGalleryItem306.Hint = "Display Axis Left to Right with Labels";
            spreadsheetCommandGalleryItem306.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image112")));
            spreadsheetCommandGalleryItem307.Caption = "Show Axis without Labeling";
            spreadsheetCommandGalleryItem307.CommandName = "ChartPrimaryHorizontalAxisHideLabels";
            spreadsheetCommandGalleryItem307.Description = "Display Axis without labels or tick marks";
            spreadsheetCommandGalleryItem307.Hint = "Display Axis without labels or tick marks";
            spreadsheetCommandGalleryItem307.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image113")));
            spreadsheetCommandGalleryItem308.Caption = "Show Right to Left Axis";
            spreadsheetCommandGalleryItem308.CommandName = "ChartPrimaryHorizontalAxisRightToLeft";
            spreadsheetCommandGalleryItem308.Description = "Display Axis Right to Left with Labels";
            spreadsheetCommandGalleryItem308.Hint = "Display Axis Right to Left with Labels";
            spreadsheetCommandGalleryItem308.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image114")));
            spreadsheetCommandGalleryItem309.Caption = "Show Default Axis";
            spreadsheetCommandGalleryItem309.CommandName = "ChartPrimaryHorizontalAxisDefault";
            spreadsheetCommandGalleryItem309.Description = "Display Axis with default order and labels";
            spreadsheetCommandGalleryItem309.Hint = "Display Axis with default order and labels";
            spreadsheetCommandGalleryItem309.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image115")));
            spreadsheetCommandGalleryItem310.Caption = "Show Axis in Thousands";
            spreadsheetCommandGalleryItem310.CommandName = "ChartPrimaryHorizontalAxisScaleThousands";
            spreadsheetCommandGalleryItem310.Description = "Display Axis with numbers represented in Thousands";
            spreadsheetCommandGalleryItem310.Hint = "Display Axis with numbers represented in Thousands";
            spreadsheetCommandGalleryItem310.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image116")));
            spreadsheetCommandGalleryItem311.Caption = "Show Axis in Millions";
            spreadsheetCommandGalleryItem311.CommandName = "ChartPrimaryHorizontalAxisScaleMillions";
            spreadsheetCommandGalleryItem311.Description = "Display Axis with numbers represented in Millions";
            spreadsheetCommandGalleryItem311.Hint = "Display Axis with numbers represented in Millions";
            spreadsheetCommandGalleryItem311.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image117")));
            spreadsheetCommandGalleryItem312.Caption = "Show Axis in Billions";
            spreadsheetCommandGalleryItem312.CommandName = "ChartPrimaryHorizontalAxisScaleBillions";
            spreadsheetCommandGalleryItem312.Description = "Display Axis with numbers represented in Billions";
            spreadsheetCommandGalleryItem312.Hint = "Display Axis with numbers represented in Billions";
            spreadsheetCommandGalleryItem312.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image118")));
            spreadsheetCommandGalleryItem313.Caption = "Show Axis in Log Scale";
            spreadsheetCommandGalleryItem313.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm";
            spreadsheetCommandGalleryItem313.Description = "Display Axis using a log 10 base scale";
            spreadsheetCommandGalleryItem313.Hint = "Display Axis using a log 10 base scale";
            spreadsheetCommandGalleryItem313.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image119")));
            spreadsheetCommandGalleryItemGroup75.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem305,
            spreadsheetCommandGalleryItem306,
            spreadsheetCommandGalleryItem307,
            spreadsheetCommandGalleryItem308,
            spreadsheetCommandGalleryItem309,
            spreadsheetCommandGalleryItem310,
            spreadsheetCommandGalleryItem311,
            spreadsheetCommandGalleryItem312,
            spreadsheetCommandGalleryItem313});
            this.commandBarGalleryDropDown61.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup75});
            this.commandBarGalleryDropDown61.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown61.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown61.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown61.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown61.Manager = null;
            this.commandBarGalleryDropDown61.Name = "commandBarGalleryDropDown61";
            // 
            // commandBarGalleryDropDown62
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown62.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown62.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup76.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            spreadsheetCommandGalleryItem314.Caption = "None";
            spreadsheetCommandGalleryItem314.CommandName = "ChartHidePrimaryVerticalAxis";
            spreadsheetCommandGalleryItem314.Description = "Do not display axis.";
            spreadsheetCommandGalleryItem314.Hint = "Do not display axis.";
            spreadsheetCommandGalleryItem314.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image120")));
            spreadsheetCommandGalleryItem315.Caption = "Show Left to Right Axis";
            spreadsheetCommandGalleryItem315.CommandName = "ChartPrimaryVerticalAxisLeftToRight";
            spreadsheetCommandGalleryItem315.Description = "Display Axis Left to Right with Labels";
            spreadsheetCommandGalleryItem315.Hint = "Display Axis Left to Right with Labels";
            spreadsheetCommandGalleryItem315.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image121")));
            spreadsheetCommandGalleryItem316.Caption = "Show Axis without Labeling";
            spreadsheetCommandGalleryItem316.CommandName = "ChartPrimaryVerticalAxisHideLabels";
            spreadsheetCommandGalleryItem316.Description = "Display Axis without labels or tick marks";
            spreadsheetCommandGalleryItem316.Hint = "Display Axis without labels or tick marks";
            spreadsheetCommandGalleryItem316.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image122")));
            spreadsheetCommandGalleryItem317.Caption = "Show Right to Left Axis";
            spreadsheetCommandGalleryItem317.CommandName = "ChartPrimaryVerticalAxisRightToLeft";
            spreadsheetCommandGalleryItem317.Description = "Display Axis Right to Left with Labels";
            spreadsheetCommandGalleryItem317.Hint = "Display Axis Right to Left with Labels";
            spreadsheetCommandGalleryItem317.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image123")));
            spreadsheetCommandGalleryItem318.Caption = "Show Default Axis";
            spreadsheetCommandGalleryItem318.CommandName = "ChartPrimaryVerticalAxisDefault";
            spreadsheetCommandGalleryItem318.Description = "Display Axis with default order and labels";
            spreadsheetCommandGalleryItem318.Hint = "Display Axis with default order and labels";
            spreadsheetCommandGalleryItem318.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image124")));
            spreadsheetCommandGalleryItem319.Caption = "Show Axis in Thousands";
            spreadsheetCommandGalleryItem319.CommandName = "ChartPrimaryVerticalAxisScaleThousands";
            spreadsheetCommandGalleryItem319.Description = "Display Axis with numbers represented in Thousands";
            spreadsheetCommandGalleryItem319.Hint = "Display Axis with numbers represented in Thousands";
            spreadsheetCommandGalleryItem319.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image125")));
            spreadsheetCommandGalleryItem320.Caption = "Show Axis in Millions";
            spreadsheetCommandGalleryItem320.CommandName = "ChartPrimaryVerticalAxisScaleMillions";
            spreadsheetCommandGalleryItem320.Description = "Display Axis with numbers represented in Millions";
            spreadsheetCommandGalleryItem320.Hint = "Display Axis with numbers represented in Millions";
            spreadsheetCommandGalleryItem320.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image126")));
            spreadsheetCommandGalleryItem321.Caption = "Show Axis in Billions";
            spreadsheetCommandGalleryItem321.CommandName = "ChartPrimaryVerticalAxisScaleBillions";
            spreadsheetCommandGalleryItem321.Description = "Display Axis with numbers represented in Billions";
            spreadsheetCommandGalleryItem321.Hint = "Display Axis with numbers represented in Billions";
            spreadsheetCommandGalleryItem321.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image127")));
            spreadsheetCommandGalleryItem322.Caption = "Show Axis in Log Scale";
            spreadsheetCommandGalleryItem322.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm";
            spreadsheetCommandGalleryItem322.Description = "Display Axis using a log 10 base scale";
            spreadsheetCommandGalleryItem322.Hint = "Display Axis using a log 10 base scale";
            spreadsheetCommandGalleryItem322.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image128")));
            spreadsheetCommandGalleryItemGroup76.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem314,
            spreadsheetCommandGalleryItem315,
            spreadsheetCommandGalleryItem316,
            spreadsheetCommandGalleryItem317,
            spreadsheetCommandGalleryItem318,
            spreadsheetCommandGalleryItem319,
            spreadsheetCommandGalleryItem320,
            spreadsheetCommandGalleryItem321,
            spreadsheetCommandGalleryItem322});
            this.commandBarGalleryDropDown62.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup76});
            this.commandBarGalleryDropDown62.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown62.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown62.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown62.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown62.Manager = null;
            this.commandBarGalleryDropDown62.Name = "commandBarGalleryDropDown62";
            // 
            // commandBarGalleryDropDown63
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown63.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown63.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup77.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem323.Caption = "None";
            spreadsheetCommandGalleryItem323.CommandName = "ChartPrimaryHorizontalGridlinesNone";
            spreadsheetCommandGalleryItem323.Description = "Do not display Horizontal Gridlines";
            spreadsheetCommandGalleryItem323.Hint = "Do not display Horizontal Gridlines";
            spreadsheetCommandGalleryItem323.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image129")));
            spreadsheetCommandGalleryItem324.Caption = "Major Gridlines";
            spreadsheetCommandGalleryItem324.CommandName = "ChartPrimaryHorizontalGridlinesMajor";
            spreadsheetCommandGalleryItem324.Description = "Display Horizontal Gridlines for Major units";
            spreadsheetCommandGalleryItem324.Hint = "Display Horizontal Gridlines for Major units";
            spreadsheetCommandGalleryItem324.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image130")));
            spreadsheetCommandGalleryItem325.Caption = "Minor Gridlines";
            spreadsheetCommandGalleryItem325.CommandName = "ChartPrimaryHorizontalGridlinesMinor";
            spreadsheetCommandGalleryItem325.Description = "Display Horizontal Gridlines for Minor units";
            spreadsheetCommandGalleryItem325.Hint = "Display Horizontal Gridlines for Minor units";
            spreadsheetCommandGalleryItem325.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image131")));
            spreadsheetCommandGalleryItem326.Caption = "Major & Minor Gridlines";
            spreadsheetCommandGalleryItem326.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItem326.Description = "Display Horizontal Gridlines for Major and Minor units";
            spreadsheetCommandGalleryItem326.Hint = "Display Horizontal Gridlines for Major and Minor units";
            spreadsheetCommandGalleryItem326.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image132")));
            spreadsheetCommandGalleryItemGroup77.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem323,
            spreadsheetCommandGalleryItem324,
            spreadsheetCommandGalleryItem325,
            spreadsheetCommandGalleryItem326});
            this.commandBarGalleryDropDown63.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup77});
            this.commandBarGalleryDropDown63.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown63.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown63.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown63.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown63.Manager = null;
            this.commandBarGalleryDropDown63.Name = "commandBarGalleryDropDown63";
            // 
            // commandBarGalleryDropDown64
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown64.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown64.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup78.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem327.Caption = "None";
            spreadsheetCommandGalleryItem327.CommandName = "ChartPrimaryVerticalGridlinesNone";
            spreadsheetCommandGalleryItem327.Description = "Do not display Vertical Gridlines";
            spreadsheetCommandGalleryItem327.Hint = "Do not display Vertical Gridlines";
            spreadsheetCommandGalleryItem327.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image133")));
            spreadsheetCommandGalleryItem328.Caption = "Major Gridlines";
            spreadsheetCommandGalleryItem328.CommandName = "ChartPrimaryVerticalGridlinesMajor";
            spreadsheetCommandGalleryItem328.Description = "Display Vertical Gridlines for Major units";
            spreadsheetCommandGalleryItem328.Hint = "Display Vertical Gridlines for Major units";
            spreadsheetCommandGalleryItem328.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image134")));
            spreadsheetCommandGalleryItem329.Caption = "Minor Gridlines";
            spreadsheetCommandGalleryItem329.CommandName = "ChartPrimaryVerticalGridlinesMinor";
            spreadsheetCommandGalleryItem329.Description = "Display Vertical Gridlines for Minor units";
            spreadsheetCommandGalleryItem329.Hint = "Display Vertical Gridlines for Minor units";
            spreadsheetCommandGalleryItem329.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image135")));
            spreadsheetCommandGalleryItem330.Caption = "Major & Minor Gridlines";
            spreadsheetCommandGalleryItem330.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItem330.Description = "Display Vertical Gridlines for Major and Minor units";
            spreadsheetCommandGalleryItem330.Hint = "Display Vertical Gridlines for Major and Minor units";
            spreadsheetCommandGalleryItem330.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image136")));
            spreadsheetCommandGalleryItemGroup78.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem327,
            spreadsheetCommandGalleryItem328,
            spreadsheetCommandGalleryItem329,
            spreadsheetCommandGalleryItem330});
            this.commandBarGalleryDropDown64.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup78});
            this.commandBarGalleryDropDown64.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown64.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown64.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown64.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown64.Manager = null;
            this.commandBarGalleryDropDown64.Name = "commandBarGalleryDropDown64";
            // 
            // commandBarGalleryDropDown65
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown65.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown65.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup79.CommandName = "ChartTitleCommandGroup";
            spreadsheetCommandGalleryItem331.Caption = "None";
            spreadsheetCommandGalleryItem331.CommandName = "ChartTitleNone";
            spreadsheetCommandGalleryItem331.Description = "Do not display a chart Title";
            spreadsheetCommandGalleryItem331.Hint = "Do not display a chart Title";
            spreadsheetCommandGalleryItem331.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image137")));
            spreadsheetCommandGalleryItem332.Caption = "Centered Overlay Title";
            spreadsheetCommandGalleryItem332.CommandName = "ChartTitleCenteredOverlay";
            spreadsheetCommandGalleryItem332.Description = "Overlay centered Title on chart without resizing chart";
            spreadsheetCommandGalleryItem332.Hint = "Overlay centered Title on chart without resizing chart";
            spreadsheetCommandGalleryItem332.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image138")));
            spreadsheetCommandGalleryItem333.Caption = "Above Chart";
            spreadsheetCommandGalleryItem333.CommandName = "ChartTitleAbove";
            spreadsheetCommandGalleryItem333.Description = "Display Title at top of chart area and resize chart";
            spreadsheetCommandGalleryItem333.Hint = "Display Title at top of chart area and resize chart";
            spreadsheetCommandGalleryItem333.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image139")));
            spreadsheetCommandGalleryItemGroup79.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem331,
            spreadsheetCommandGalleryItem332,
            spreadsheetCommandGalleryItem333});
            this.commandBarGalleryDropDown65.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup79});
            this.commandBarGalleryDropDown65.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown65.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown65.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown65.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown65.Manager = null;
            this.commandBarGalleryDropDown65.Name = "commandBarGalleryDropDown65";
            // 
            // commandBarGalleryDropDown66
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown66.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown66.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup80.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem334.Caption = "None";
            spreadsheetCommandGalleryItem334.CommandName = "ChartPrimaryHorizontalAxisTitleNone";
            spreadsheetCommandGalleryItem334.Description = "Do not display an Axis Title";
            spreadsheetCommandGalleryItem334.Hint = "Do not display an Axis Title";
            spreadsheetCommandGalleryItem334.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image140")));
            spreadsheetCommandGalleryItem335.Caption = "Title Below Axis";
            spreadsheetCommandGalleryItem335.CommandName = "ChartPrimaryHorizontalAxisTitleBelow";
            spreadsheetCommandGalleryItem335.Description = "Display Title below Horizontal Axis and resize chart";
            spreadsheetCommandGalleryItem335.Hint = "Display Title below Horizontal Axis and resize chart";
            spreadsheetCommandGalleryItem335.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image141")));
            spreadsheetCommandGalleryItemGroup80.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem334,
            spreadsheetCommandGalleryItem335});
            this.commandBarGalleryDropDown66.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup80});
            this.commandBarGalleryDropDown66.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown66.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown66.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown66.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown66.Manager = null;
            this.commandBarGalleryDropDown66.Name = "commandBarGalleryDropDown66";
            // 
            // commandBarGalleryDropDown67
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown67.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown67.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup81.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem336.Caption = "None";
            spreadsheetCommandGalleryItem336.CommandName = "ChartPrimaryVerticalAxisTitleNone";
            spreadsheetCommandGalleryItem336.Description = "Do not display an Axis Title";
            spreadsheetCommandGalleryItem336.Hint = "Do not display an Axis Title";
            spreadsheetCommandGalleryItem336.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image142")));
            spreadsheetCommandGalleryItem337.Caption = "Rotated Title";
            spreadsheetCommandGalleryItem337.CommandName = "ChartPrimaryVerticalAxisTitleRotated";
            spreadsheetCommandGalleryItem337.Description = "Display Rotated Axis Title and resize chart";
            spreadsheetCommandGalleryItem337.Hint = "Display Rotated Axis Title and resize chart";
            spreadsheetCommandGalleryItem337.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image143")));
            spreadsheetCommandGalleryItemGroup81.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem336,
            spreadsheetCommandGalleryItem337});
            this.commandBarGalleryDropDown67.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup81});
            this.commandBarGalleryDropDown67.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown67.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown67.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown67.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown67.Manager = null;
            this.commandBarGalleryDropDown67.Name = "commandBarGalleryDropDown67";
            // 
            // commandBarGalleryDropDown68
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown68.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown68.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup82.CommandName = "ChartLegendCommandGroup";
            spreadsheetCommandGalleryItem340.Caption = "None";
            spreadsheetCommandGalleryItem340.CommandName = "ChartLegendNone";
            spreadsheetCommandGalleryItem340.Description = "Turn off Legend";
            spreadsheetCommandGalleryItem340.Hint = "Turn off Legend";
            spreadsheetCommandGalleryItem340.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image146")));
            spreadsheetCommandGalleryItem341.Caption = "Show Legend at Right";
            spreadsheetCommandGalleryItem341.CommandName = "ChartLegendAtRight";
            spreadsheetCommandGalleryItem341.Description = "Show Legend and align right";
            spreadsheetCommandGalleryItem341.Hint = "Show Legend and align right";
            spreadsheetCommandGalleryItem341.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image147")));
            spreadsheetCommandGalleryItem342.Caption = "Show Legend at Top";
            spreadsheetCommandGalleryItem342.CommandName = "ChartLegendAtTop";
            spreadsheetCommandGalleryItem342.Description = "Show Legend and align top";
            spreadsheetCommandGalleryItem342.Hint = "Show Legend and align top";
            spreadsheetCommandGalleryItem342.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image148")));
            spreadsheetCommandGalleryItem343.Caption = "Show Legend at Left";
            spreadsheetCommandGalleryItem343.CommandName = "ChartLegendAtLeft";
            spreadsheetCommandGalleryItem343.Description = "Show Legend and align left";
            spreadsheetCommandGalleryItem343.Hint = "Show Legend and align left";
            spreadsheetCommandGalleryItem343.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image149")));
            spreadsheetCommandGalleryItem344.Caption = "Show Legend at Bottom";
            spreadsheetCommandGalleryItem344.CommandName = "ChartLegendAtBottom";
            spreadsheetCommandGalleryItem344.Description = "Show Legend and align bottom";
            spreadsheetCommandGalleryItem344.Hint = "Show Legend and align bottom";
            spreadsheetCommandGalleryItem344.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image150")));
            spreadsheetCommandGalleryItem345.Caption = "Overlay Legend at Right";
            spreadsheetCommandGalleryItem345.CommandName = "ChartLegendOverlayAtRight";
            spreadsheetCommandGalleryItem345.Description = "Show Legend at right of the chart without resizing";
            spreadsheetCommandGalleryItem345.Hint = "Show Legend at right of the chart without resizing";
            spreadsheetCommandGalleryItem345.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image151")));
            spreadsheetCommandGalleryItem346.Caption = "Overlay Legend at Left";
            spreadsheetCommandGalleryItem346.CommandName = "ChartLegendOverlayAtLeft";
            spreadsheetCommandGalleryItem346.Description = "Show Legend at left of the chart without resizing";
            spreadsheetCommandGalleryItem346.Hint = "Show Legend at left of the chart without resizing";
            spreadsheetCommandGalleryItem346.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image152")));
            spreadsheetCommandGalleryItemGroup82.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem340,
            spreadsheetCommandGalleryItem341,
            spreadsheetCommandGalleryItem342,
            spreadsheetCommandGalleryItem343,
            spreadsheetCommandGalleryItem344,
            spreadsheetCommandGalleryItem345,
            spreadsheetCommandGalleryItem346});
            this.commandBarGalleryDropDown68.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup82});
            this.commandBarGalleryDropDown68.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown68.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown68.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown68.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown68.Manager = null;
            this.commandBarGalleryDropDown68.Name = "commandBarGalleryDropDown68";
            // 
            // commandBarGalleryDropDown69
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown69.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown69.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup83.CommandName = "ChartDataLabelsCommandGroup";
            spreadsheetCommandGalleryItem347.Caption = "None";
            spreadsheetCommandGalleryItem347.CommandName = "ChartDataLabelsNone";
            spreadsheetCommandGalleryItem347.Description = "Turn off Data Labels for selection";
            spreadsheetCommandGalleryItem347.Hint = "Turn off Data Labels for selection";
            spreadsheetCommandGalleryItem347.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image153")));
            spreadsheetCommandGalleryItem348.Caption = "Show";
            spreadsheetCommandGalleryItem348.CommandName = "ChartDataLabelsDefault";
            spreadsheetCommandGalleryItem348.Description = "Turn on Data Labels for selection";
            spreadsheetCommandGalleryItem348.Hint = "Turn on Data Labels for selection";
            spreadsheetCommandGalleryItem348.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image154")));
            spreadsheetCommandGalleryItem349.Caption = "Center";
            spreadsheetCommandGalleryItem349.CommandName = "ChartDataLabelsCenter";
            spreadsheetCommandGalleryItem349.Description = "Display Data Labels and position centered on the data point(s)";
            spreadsheetCommandGalleryItem349.Hint = "Display Data Labels and position centered on the data point(s)";
            spreadsheetCommandGalleryItem349.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image155")));
            spreadsheetCommandGalleryItem350.Caption = "Inside End";
            spreadsheetCommandGalleryItem350.CommandName = "ChartDataLabelsInsideEnd";
            spreadsheetCommandGalleryItem350.Description = "Display Data Labels and position inside the end of data point(s)";
            spreadsheetCommandGalleryItem350.Hint = "Display Data Labels and position inside the end of data point(s)";
            spreadsheetCommandGalleryItem350.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image156")));
            spreadsheetCommandGalleryItem351.Caption = "Inside Base";
            spreadsheetCommandGalleryItem351.CommandName = "ChartDataLabelsInsideBase";
            spreadsheetCommandGalleryItem351.Description = "Display Data Labels and position inside the base of data point(s)";
            spreadsheetCommandGalleryItem351.Hint = "Display Data Labels and position inside the base of data point(s)";
            spreadsheetCommandGalleryItem351.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image157")));
            spreadsheetCommandGalleryItem352.Caption = "Outside End";
            spreadsheetCommandGalleryItem352.CommandName = "ChartDataLabelsOutsideEnd";
            spreadsheetCommandGalleryItem352.Description = "Display Data Labels and position outside the end of data point(s)";
            spreadsheetCommandGalleryItem352.Hint = "Display Data Labels and position outside the end of data point(s)";
            spreadsheetCommandGalleryItem352.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image158")));
            spreadsheetCommandGalleryItem353.Caption = "Best Fit";
            spreadsheetCommandGalleryItem353.CommandName = "ChartDataLabelsBestFit";
            spreadsheetCommandGalleryItem353.Description = "Display Data Labels and position with Best Fit";
            spreadsheetCommandGalleryItem353.Hint = "Display Data Labels and position with Best Fit";
            spreadsheetCommandGalleryItem353.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image159")));
            spreadsheetCommandGalleryItem354.Caption = "Left";
            spreadsheetCommandGalleryItem354.CommandName = "ChartDataLabelsLeft";
            spreadsheetCommandGalleryItem354.Description = "Display Data Labels and position left of the data point(s)";
            spreadsheetCommandGalleryItem354.Hint = "Display Data Labels and position left of the data point(s)";
            spreadsheetCommandGalleryItem354.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image160")));
            spreadsheetCommandGalleryItem355.Caption = "Right";
            spreadsheetCommandGalleryItem355.CommandName = "ChartDataLabelsRight";
            spreadsheetCommandGalleryItem355.Description = "Display Data Labels and position right of the data point(s)";
            spreadsheetCommandGalleryItem355.Hint = "Display Data Labels and position right of the data point(s)";
            spreadsheetCommandGalleryItem355.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image161")));
            spreadsheetCommandGalleryItem356.Caption = "Above";
            spreadsheetCommandGalleryItem356.CommandName = "ChartDataLabelsAbove";
            spreadsheetCommandGalleryItem356.Description = "Display Data Labels and position above data point(s)";
            spreadsheetCommandGalleryItem356.Hint = "Display Data Labels and position above data point(s)";
            spreadsheetCommandGalleryItem356.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image162")));
            spreadsheetCommandGalleryItem357.Caption = "Below";
            spreadsheetCommandGalleryItem357.CommandName = "ChartDataLabelsBelow";
            spreadsheetCommandGalleryItem357.Description = "Display Data Labels and position below data point(s)";
            spreadsheetCommandGalleryItem357.Hint = "Display Data Labels and position below data point(s)";
            spreadsheetCommandGalleryItem357.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image163")));
            spreadsheetCommandGalleryItemGroup83.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem347,
            spreadsheetCommandGalleryItem348,
            spreadsheetCommandGalleryItem349,
            spreadsheetCommandGalleryItem350,
            spreadsheetCommandGalleryItem351,
            spreadsheetCommandGalleryItem352,
            spreadsheetCommandGalleryItem353,
            spreadsheetCommandGalleryItem354,
            spreadsheetCommandGalleryItem355,
            spreadsheetCommandGalleryItem356,
            spreadsheetCommandGalleryItem357});
            this.commandBarGalleryDropDown69.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup83});
            this.commandBarGalleryDropDown69.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown69.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown69.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown69.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown69.Manager = null;
            this.commandBarGalleryDropDown69.Name = "commandBarGalleryDropDown69";
            // 
            // commandBarGalleryDropDown70
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown70.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown70.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup84.CommandName = "ChartLinesCommandGroup";
            spreadsheetCommandGalleryItem358.Caption = "None";
            spreadsheetCommandGalleryItem358.CommandName = "ChartLinesNone";
            spreadsheetCommandGalleryItem358.Description = "Do not show Drop Lines, High-Low Lines or Series Lines";
            spreadsheetCommandGalleryItem358.Hint = "Do not show Drop Lines, High-Low Lines or Series Lines";
            spreadsheetCommandGalleryItem358.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image164")));
            spreadsheetCommandGalleryItem359.Caption = "Drop Lines";
            spreadsheetCommandGalleryItem359.CommandName = "ChartShowDropLines";
            spreadsheetCommandGalleryItem359.Description = "Show Drop Lines on an Area or Line Chart";
            spreadsheetCommandGalleryItem359.Hint = "Show Drop Lines on an Area or Line Chart";
            spreadsheetCommandGalleryItem359.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image165")));
            spreadsheetCommandGalleryItem360.Caption = "High-Low Lines";
            spreadsheetCommandGalleryItem360.CommandName = "ChartShowHighLowLines";
            spreadsheetCommandGalleryItem360.Description = "Show High-Low Lines on a 2D Line Chart";
            spreadsheetCommandGalleryItem360.Hint = "Show High-Low Lines on a 2D Line Chart";
            spreadsheetCommandGalleryItem360.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image166")));
            spreadsheetCommandGalleryItem361.Caption = "Drop and High-Low Lines";
            spreadsheetCommandGalleryItem361.CommandName = "ChartShowDropLinesAndHighLowLines";
            spreadsheetCommandGalleryItem361.Description = "Show Drop Lines and High-Low Lines on a 2D Line Chart";
            spreadsheetCommandGalleryItem361.Hint = "Show Drop Lines and High-Low Lines on a 2D Line Chart";
            spreadsheetCommandGalleryItem361.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image167")));
            spreadsheetCommandGalleryItem362.Caption = "Series Lines";
            spreadsheetCommandGalleryItem362.CommandName = "ChartShowSeriesLines";
            spreadsheetCommandGalleryItem362.Description = "Show Series Lines on a 2D stacked Bar/Column Pie or Pie or Bar of Pie Chart";
            spreadsheetCommandGalleryItem362.Hint = "Show Series Lines on a 2D stacked Bar/Column Pie or Pie or Bar of Pie Chart";
            spreadsheetCommandGalleryItem362.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image168")));
            spreadsheetCommandGalleryItemGroup84.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem358,
            spreadsheetCommandGalleryItem359,
            spreadsheetCommandGalleryItem360,
            spreadsheetCommandGalleryItem361,
            spreadsheetCommandGalleryItem362});
            this.commandBarGalleryDropDown70.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup84});
            this.commandBarGalleryDropDown70.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown70.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown70.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown70.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown70.Manager = null;
            this.commandBarGalleryDropDown70.Name = "commandBarGalleryDropDown70";
            // 
            // commandBarGalleryDropDown71
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown71.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown71.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup85.CommandName = "ChartUpDownBarsCommandGroup";
            spreadsheetCommandGalleryItem363.Caption = "None";
            spreadsheetCommandGalleryItem363.CommandName = "ChartHideUpDownBars";
            spreadsheetCommandGalleryItem363.Description = "Do not show Up/Down Bars";
            spreadsheetCommandGalleryItem363.Hint = "Do not show Up/Down Bars";
            spreadsheetCommandGalleryItem363.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image169")));
            spreadsheetCommandGalleryItem364.Caption = "Up/Down Bars";
            spreadsheetCommandGalleryItem364.CommandName = "ChartShowUpDownBars";
            spreadsheetCommandGalleryItem364.Description = "Show Up/Down Bars on a Line Chart";
            spreadsheetCommandGalleryItem364.Hint = "Show Up/Down Bars on a Line Chart";
            spreadsheetCommandGalleryItem364.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image170")));
            spreadsheetCommandGalleryItemGroup85.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem363,
            spreadsheetCommandGalleryItem364});
            this.commandBarGalleryDropDown71.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup85});
            this.commandBarGalleryDropDown71.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown71.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown71.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown71.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown71.Manager = null;
            this.commandBarGalleryDropDown71.Name = "commandBarGalleryDropDown71";
            // 
            // commandBarGalleryDropDown72
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown72.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown72.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup86.CommandName = "ChartErrorBarsCommandGroup";
            spreadsheetCommandGalleryItem365.Caption = "None";
            spreadsheetCommandGalleryItem365.CommandName = "ChartErrorBarsNone";
            spreadsheetCommandGalleryItem365.Description = "Removes the Error Bars for the selected series or all Error Bars if none are sele" +
    "cted";
            spreadsheetCommandGalleryItem365.Hint = "Removes the Error Bars for the selected series or all Error Bars if none are sele" +
    "cted";
            spreadsheetCommandGalleryItem365.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image171")));
            spreadsheetCommandGalleryItem366.Caption = "Error Bars with Standard Error";
            spreadsheetCommandGalleryItem366.CommandName = "ChartErrorBarsStandardError";
            spreadsheetCommandGalleryItem366.Description = "Displays Error Bars for the selected chart series using Standard Error";
            spreadsheetCommandGalleryItem366.Hint = "Displays Error Bars for the selected chart series using Standard Error";
            spreadsheetCommandGalleryItem366.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image172")));
            spreadsheetCommandGalleryItem367.Caption = "Error Bars with Percentage";
            spreadsheetCommandGalleryItem367.CommandName = "ChartErrorBarsPercentage";
            spreadsheetCommandGalleryItem367.Description = "Displays Error Bars for the selected chart series with 5% value";
            spreadsheetCommandGalleryItem367.Hint = "Displays Error Bars for the selected chart series with 5% value";
            spreadsheetCommandGalleryItem367.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image173")));
            spreadsheetCommandGalleryItem368.Caption = "Error Bars with Standard Deviation";
            spreadsheetCommandGalleryItem368.CommandName = "ChartErrorBarsStandardDeviation";
            spreadsheetCommandGalleryItem368.Description = "Displays Error Bars for the selected chart series with 1 standard deviation";
            spreadsheetCommandGalleryItem368.Hint = "Displays Error Bars for the selected chart series with 1 standard deviation";
            spreadsheetCommandGalleryItem368.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image174")));
            spreadsheetCommandGalleryItemGroup86.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem365,
            spreadsheetCommandGalleryItem366,
            spreadsheetCommandGalleryItem367,
            spreadsheetCommandGalleryItem368});
            this.commandBarGalleryDropDown72.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup86});
            this.commandBarGalleryDropDown72.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown72.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown72.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown72.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown72.Manager = null;
            this.commandBarGalleryDropDown72.Name = "commandBarGalleryDropDown72";
            // 
            // commandBarGalleryDropDown26
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown26.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup87.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup";
            spreadsheetCommandGalleryItem369.CommandName = "ConditionalFormattingDataBarGradientBlue";
            spreadsheetCommandGalleryItem369.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image175")));
            spreadsheetCommandGalleryItem370.CommandName = "ConditionalFormattingDataBarGradientGreen";
            spreadsheetCommandGalleryItem370.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image176")));
            spreadsheetCommandGalleryItem371.CommandName = "ConditionalFormattingDataBarGradientRed";
            spreadsheetCommandGalleryItem371.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image177")));
            spreadsheetCommandGalleryItem372.CommandName = "ConditionalFormattingDataBarGradientOrange";
            spreadsheetCommandGalleryItem372.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image178")));
            spreadsheetCommandGalleryItem373.CommandName = "ConditionalFormattingDataBarGradientLightBlue";
            spreadsheetCommandGalleryItem373.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image179")));
            spreadsheetCommandGalleryItem374.CommandName = "ConditionalFormattingDataBarGradientPurple";
            spreadsheetCommandGalleryItem374.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image180")));
            spreadsheetCommandGalleryItemGroup87.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem369,
            spreadsheetCommandGalleryItem370,
            spreadsheetCommandGalleryItem371,
            spreadsheetCommandGalleryItem372,
            spreadsheetCommandGalleryItem373,
            spreadsheetCommandGalleryItem374});
            spreadsheetCommandGalleryItemGroup88.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup";
            spreadsheetCommandGalleryItem375.CommandName = "ConditionalFormattingDataBarSolidBlue";
            spreadsheetCommandGalleryItem375.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image181")));
            spreadsheetCommandGalleryItem376.CommandName = "ConditionalFormattingDataBarSolidGreen";
            spreadsheetCommandGalleryItem376.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image182")));
            spreadsheetCommandGalleryItem377.CommandName = "ConditionalFormattingDataBarSolidRed";
            spreadsheetCommandGalleryItem377.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image183")));
            spreadsheetCommandGalleryItem378.CommandName = "ConditionalFormattingDataBarSolidOrange";
            spreadsheetCommandGalleryItem378.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image184")));
            spreadsheetCommandGalleryItem379.CommandName = "ConditionalFormattingDataBarSolidLightBlue";
            spreadsheetCommandGalleryItem379.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image185")));
            spreadsheetCommandGalleryItem380.CommandName = "ConditionalFormattingDataBarSolidPurple";
            spreadsheetCommandGalleryItem380.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image186")));
            spreadsheetCommandGalleryItemGroup88.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem375,
            spreadsheetCommandGalleryItem376,
            spreadsheetCommandGalleryItem377,
            spreadsheetCommandGalleryItem378,
            spreadsheetCommandGalleryItem379,
            spreadsheetCommandGalleryItem380});
            this.commandBarGalleryDropDown26.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup87,
            spreadsheetCommandGalleryItemGroup88});
            this.commandBarGalleryDropDown26.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown26.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown26.Manager = null;
            this.commandBarGalleryDropDown26.Name = "commandBarGalleryDropDown26";
            // 
            // commandBarGalleryDropDown25
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown25.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown25.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown25.Gallery.DrawImageBackground = false;
            galleryItem1.Tag = DevExpress.Export.Xl.XlBorderLineStyle.None;
            galleryItem2.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thin;
            galleryItem3.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Hair;
            galleryItem4.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dotted;
            galleryItem5.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dashed;
            galleryItem6.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDot;
            galleryItem7.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDotDot;
            galleryItem8.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Double;
            galleryItem9.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Medium;
            galleryItem10.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashed;
            galleryItem11.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDot;
            galleryItem12.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDotDot;
            galleryItem13.Tag = DevExpress.Export.Xl.XlBorderLineStyle.SlantDashDot;
            galleryItem14.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thick;
            galleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6,
            galleryItem7,
            galleryItem8,
            galleryItem9,
            galleryItem10,
            galleryItem11,
            galleryItem12,
            galleryItem13,
            galleryItem14});
            this.commandBarGalleryDropDown25.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.commandBarGalleryDropDown25.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.commandBarGalleryDropDown25.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown25.Gallery.ItemSize = new System.Drawing.Size(136, 26);
            this.commandBarGalleryDropDown25.Gallery.RowCount = 14;
            this.commandBarGalleryDropDown25.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown25.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown25.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown25.Manager = null;
            this.commandBarGalleryDropDown25.Name = "commandBarGalleryDropDown25";
            // 
            // commandBarGalleryDropDown27
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown27.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup89.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            spreadsheetCommandGalleryItem381.CommandName = "ConditionalFormattingColorScaleGreenYellowRed";
            spreadsheetCommandGalleryItem381.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image187")));
            spreadsheetCommandGalleryItem382.CommandName = "ConditionalFormattingColorScaleRedYellowGreen";
            spreadsheetCommandGalleryItem382.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image188")));
            spreadsheetCommandGalleryItem383.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed";
            spreadsheetCommandGalleryItem383.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image189")));
            spreadsheetCommandGalleryItem384.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen";
            spreadsheetCommandGalleryItem384.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image190")));
            spreadsheetCommandGalleryItem385.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed";
            spreadsheetCommandGalleryItem385.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image191")));
            spreadsheetCommandGalleryItem386.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue";
            spreadsheetCommandGalleryItem386.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image192")));
            spreadsheetCommandGalleryItem387.CommandName = "ConditionalFormattingColorScaleWhiteRed";
            spreadsheetCommandGalleryItem387.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image193")));
            spreadsheetCommandGalleryItem388.CommandName = "ConditionalFormattingColorScaleRedWhite";
            spreadsheetCommandGalleryItem388.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image194")));
            spreadsheetCommandGalleryItem389.CommandName = "ConditionalFormattingColorScaleGreenWhite";
            spreadsheetCommandGalleryItem389.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image195")));
            spreadsheetCommandGalleryItem390.CommandName = "ConditionalFormattingColorScaleWhiteGreen";
            spreadsheetCommandGalleryItem390.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image196")));
            spreadsheetCommandGalleryItem391.CommandName = "ConditionalFormattingColorScaleGreenYellow";
            spreadsheetCommandGalleryItem391.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image197")));
            spreadsheetCommandGalleryItem392.CommandName = "ConditionalFormattingColorScaleYellowGreen";
            spreadsheetCommandGalleryItem392.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image198")));
            spreadsheetCommandGalleryItemGroup89.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem381,
            spreadsheetCommandGalleryItem382,
            spreadsheetCommandGalleryItem383,
            spreadsheetCommandGalleryItem384,
            spreadsheetCommandGalleryItem385,
            spreadsheetCommandGalleryItem386,
            spreadsheetCommandGalleryItem387,
            spreadsheetCommandGalleryItem388,
            spreadsheetCommandGalleryItem389,
            spreadsheetCommandGalleryItem390,
            spreadsheetCommandGalleryItem391,
            spreadsheetCommandGalleryItem392});
            this.commandBarGalleryDropDown27.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup89});
            this.commandBarGalleryDropDown27.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown27.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown27.Manager = null;
            this.commandBarGalleryDropDown27.Name = "commandBarGalleryDropDown27";
            // 
            // commandBarGalleryDropDown28
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown28.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup90.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup";
            spreadsheetCommandGalleryItem393.CommandName = "ConditionalFormattingIconSetArrows3Colored";
            spreadsheetCommandGalleryItem393.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image199")));
            spreadsheetCommandGalleryItem394.CommandName = "ConditionalFormattingIconSetArrows3Grayed";
            spreadsheetCommandGalleryItem394.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image200")));
            spreadsheetCommandGalleryItem395.CommandName = "ConditionalFormattingIconSetArrows4Colored";
            spreadsheetCommandGalleryItem395.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image201")));
            spreadsheetCommandGalleryItem396.CommandName = "ConditionalFormattingIconSetArrows4Grayed";
            spreadsheetCommandGalleryItem396.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image202")));
            spreadsheetCommandGalleryItem397.CommandName = "ConditionalFormattingIconSetArrows5Colored";
            spreadsheetCommandGalleryItem397.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image203")));
            spreadsheetCommandGalleryItem398.CommandName = "ConditionalFormattingIconSetArrows5Grayed";
            spreadsheetCommandGalleryItem398.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image204")));
            spreadsheetCommandGalleryItem399.CommandName = "ConditionalFormattingIconSetTriangles3";
            spreadsheetCommandGalleryItem399.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image205")));
            spreadsheetCommandGalleryItemGroup90.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem393,
            spreadsheetCommandGalleryItem394,
            spreadsheetCommandGalleryItem395,
            spreadsheetCommandGalleryItem396,
            spreadsheetCommandGalleryItem397,
            spreadsheetCommandGalleryItem398,
            spreadsheetCommandGalleryItem399});
            spreadsheetCommandGalleryItemGroup91.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup";
            spreadsheetCommandGalleryItem400.CommandName = "ConditionalFormattingIconSetTrafficLights3";
            spreadsheetCommandGalleryItem400.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image206")));
            spreadsheetCommandGalleryItem401.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed";
            spreadsheetCommandGalleryItem401.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image207")));
            spreadsheetCommandGalleryItem402.CommandName = "ConditionalFormattingIconSetTrafficLights4";
            spreadsheetCommandGalleryItem402.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image208")));
            spreadsheetCommandGalleryItem403.CommandName = "ConditionalFormattingIconSetSigns3";
            spreadsheetCommandGalleryItem403.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image209")));
            spreadsheetCommandGalleryItem404.CommandName = "ConditionalFormattingIconSetRedToBlack";
            spreadsheetCommandGalleryItem404.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image210")));
            spreadsheetCommandGalleryItemGroup91.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem400,
            spreadsheetCommandGalleryItem401,
            spreadsheetCommandGalleryItem402,
            spreadsheetCommandGalleryItem403,
            spreadsheetCommandGalleryItem404});
            spreadsheetCommandGalleryItemGroup92.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup";
            spreadsheetCommandGalleryItem405.CommandName = "ConditionalFormattingIconSetSymbols3Circled";
            spreadsheetCommandGalleryItem405.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image211")));
            spreadsheetCommandGalleryItem406.CommandName = "ConditionalFormattingIconSetSymbols3";
            spreadsheetCommandGalleryItem406.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image212")));
            spreadsheetCommandGalleryItem407.CommandName = "ConditionalFormattingIconSetFlags3";
            spreadsheetCommandGalleryItem407.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image213")));
            spreadsheetCommandGalleryItemGroup92.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem405,
            spreadsheetCommandGalleryItem406,
            spreadsheetCommandGalleryItem407});
            spreadsheetCommandGalleryItemGroup93.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup";
            spreadsheetCommandGalleryItem408.CommandName = "ConditionalFormattingIconSetStars3";
            spreadsheetCommandGalleryItem408.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image214")));
            spreadsheetCommandGalleryItem409.CommandName = "ConditionalFormattingIconSetRatings4";
            spreadsheetCommandGalleryItem409.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image215")));
            spreadsheetCommandGalleryItem410.CommandName = "ConditionalFormattingIconSetRatings5";
            spreadsheetCommandGalleryItem410.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image216")));
            spreadsheetCommandGalleryItem411.CommandName = "ConditionalFormattingIconSetQuarters5";
            spreadsheetCommandGalleryItem411.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image217")));
            spreadsheetCommandGalleryItem412.CommandName = "ConditionalFormattingIconSetBoxes5";
            spreadsheetCommandGalleryItem412.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image218")));
            spreadsheetCommandGalleryItemGroup93.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem408,
            spreadsheetCommandGalleryItem409,
            spreadsheetCommandGalleryItem410,
            spreadsheetCommandGalleryItem411,
            spreadsheetCommandGalleryItem412});
            this.commandBarGalleryDropDown28.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup90,
            spreadsheetCommandGalleryItemGroup91,
            spreadsheetCommandGalleryItemGroup92,
            spreadsheetCommandGalleryItemGroup93});
            this.commandBarGalleryDropDown28.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown28.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown28.Manager = null;
            this.commandBarGalleryDropDown28.Name = "commandBarGalleryDropDown28";
            // 
            // commandBarGalleryDropDown29
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown29.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown29.Gallery.ColumnCount = 7;
            this.commandBarGalleryDropDown29.Gallery.DrawImageBackground = false;
            this.commandBarGalleryDropDown29.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown29.Gallery.ItemSize = new System.Drawing.Size(73, 58);
            this.commandBarGalleryDropDown29.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown29.Manager = null;
            this.commandBarGalleryDropDown29.Name = "commandBarGalleryDropDown29";
            // 
            // commandBarGalleryDropDown30
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown30.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup94.CommandName = "InsertChartColumn2DCommandGroup";
            spreadsheetCommandGalleryItem413.CommandName = "InsertChartColumnClustered2D";
            spreadsheetCommandGalleryItem413.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image219")));
            spreadsheetCommandGalleryItem414.CommandName = "InsertChartColumnStacked2D";
            spreadsheetCommandGalleryItem414.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image220")));
            spreadsheetCommandGalleryItem415.CommandName = "InsertChartColumnPercentStacked2D";
            spreadsheetCommandGalleryItem415.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image221")));
            spreadsheetCommandGalleryItemGroup94.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem413,
            spreadsheetCommandGalleryItem414,
            spreadsheetCommandGalleryItem415});
            spreadsheetCommandGalleryItemGroup95.CommandName = "InsertChartColumn3DCommandGroup";
            spreadsheetCommandGalleryItem416.CommandName = "InsertChartColumnClustered3D";
            spreadsheetCommandGalleryItem416.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image222")));
            spreadsheetCommandGalleryItem417.CommandName = "InsertChartColumnStacked3D";
            spreadsheetCommandGalleryItem417.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image223")));
            spreadsheetCommandGalleryItem418.CommandName = "InsertChartColumnPercentStacked3D";
            spreadsheetCommandGalleryItem418.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image224")));
            spreadsheetCommandGalleryItem419.CommandName = "InsertChartColumn3D";
            spreadsheetCommandGalleryItem419.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image225")));
            spreadsheetCommandGalleryItemGroup95.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem416,
            spreadsheetCommandGalleryItem417,
            spreadsheetCommandGalleryItem418,
            spreadsheetCommandGalleryItem419});
            spreadsheetCommandGalleryItemGroup96.CommandName = "InsertChartCylinderCommandGroup";
            spreadsheetCommandGalleryItem420.CommandName = "InsertChartCylinderClustered";
            spreadsheetCommandGalleryItem420.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image226")));
            spreadsheetCommandGalleryItem421.CommandName = "InsertChartCylinderStacked";
            spreadsheetCommandGalleryItem421.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image227")));
            spreadsheetCommandGalleryItem422.CommandName = "InsertChartCylinderPercentStacked";
            spreadsheetCommandGalleryItem422.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image228")));
            spreadsheetCommandGalleryItem423.CommandName = "InsertChartCylinder";
            spreadsheetCommandGalleryItem423.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image229")));
            spreadsheetCommandGalleryItemGroup96.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem420,
            spreadsheetCommandGalleryItem421,
            spreadsheetCommandGalleryItem422,
            spreadsheetCommandGalleryItem423});
            spreadsheetCommandGalleryItemGroup97.CommandName = "InsertChartConeCommandGroup";
            spreadsheetCommandGalleryItem424.CommandName = "InsertChartConeClustered";
            spreadsheetCommandGalleryItem424.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image230")));
            spreadsheetCommandGalleryItem425.CommandName = "InsertChartConeStacked";
            spreadsheetCommandGalleryItem425.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image231")));
            spreadsheetCommandGalleryItem426.CommandName = "InsertChartConePercentStacked";
            spreadsheetCommandGalleryItem426.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image232")));
            spreadsheetCommandGalleryItem427.CommandName = "InsertChartCone";
            spreadsheetCommandGalleryItem427.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image233")));
            spreadsheetCommandGalleryItemGroup97.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem424,
            spreadsheetCommandGalleryItem425,
            spreadsheetCommandGalleryItem426,
            spreadsheetCommandGalleryItem427});
            spreadsheetCommandGalleryItemGroup98.CommandName = "InsertChartPyramidCommandGroup";
            spreadsheetCommandGalleryItem428.CommandName = "InsertChartPyramidClustered";
            spreadsheetCommandGalleryItem428.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image234")));
            spreadsheetCommandGalleryItem429.CommandName = "InsertChartPyramidStacked";
            spreadsheetCommandGalleryItem429.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image235")));
            spreadsheetCommandGalleryItem430.CommandName = "InsertChartPyramidPercentStacked";
            spreadsheetCommandGalleryItem430.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image236")));
            spreadsheetCommandGalleryItem431.CommandName = "InsertChartPyramid";
            spreadsheetCommandGalleryItem431.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image237")));
            spreadsheetCommandGalleryItemGroup98.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem428,
            spreadsheetCommandGalleryItem429,
            spreadsheetCommandGalleryItem430,
            spreadsheetCommandGalleryItem431});
            this.commandBarGalleryDropDown30.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup94,
            spreadsheetCommandGalleryItemGroup95,
            spreadsheetCommandGalleryItemGroup96,
            spreadsheetCommandGalleryItemGroup97,
            spreadsheetCommandGalleryItemGroup98});
            this.commandBarGalleryDropDown30.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown30.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown30.Manager = null;
            this.commandBarGalleryDropDown30.Name = "commandBarGalleryDropDown30";
            // 
            // commandBarGalleryDropDown31
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown31.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup99.CommandName = "InsertChartLine2DCommandGroup";
            spreadsheetCommandGalleryItem432.CommandName = "InsertChartLine";
            spreadsheetCommandGalleryItem432.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image238")));
            spreadsheetCommandGalleryItem433.CommandName = "InsertChartStackedLine";
            spreadsheetCommandGalleryItem433.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image239")));
            spreadsheetCommandGalleryItem434.CommandName = "InsertChartPercentStackedLine";
            spreadsheetCommandGalleryItem434.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image240")));
            spreadsheetCommandGalleryItem435.CommandName = "InsertChartLineWithMarkers";
            spreadsheetCommandGalleryItem435.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image241")));
            spreadsheetCommandGalleryItem436.CommandName = "InsertChartStackedLineWithMarkers";
            spreadsheetCommandGalleryItem436.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image242")));
            spreadsheetCommandGalleryItem437.CommandName = "InsertChartPercentStackedLineWithMarkers";
            spreadsheetCommandGalleryItem437.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image243")));
            spreadsheetCommandGalleryItemGroup99.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem432,
            spreadsheetCommandGalleryItem433,
            spreadsheetCommandGalleryItem434,
            spreadsheetCommandGalleryItem435,
            spreadsheetCommandGalleryItem436,
            spreadsheetCommandGalleryItem437});
            spreadsheetCommandGalleryItemGroup100.CommandName = "InsertChartLine3DCommandGroup";
            spreadsheetCommandGalleryItem438.CommandName = "InsertChartLine3D";
            spreadsheetCommandGalleryItem438.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image244")));
            spreadsheetCommandGalleryItemGroup100.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem438});
            this.commandBarGalleryDropDown31.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup99,
            spreadsheetCommandGalleryItemGroup100});
            this.commandBarGalleryDropDown31.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown31.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown31.Manager = null;
            this.commandBarGalleryDropDown31.Name = "commandBarGalleryDropDown31";
            // 
            // commandBarGalleryDropDown32
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown32.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup101.CommandName = "InsertChartPie2DCommandGroup";
            spreadsheetCommandGalleryItem439.CommandName = "InsertChartPie2D";
            spreadsheetCommandGalleryItem439.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image245")));
            spreadsheetCommandGalleryItem440.CommandName = "InsertChartPieExploded2D";
            spreadsheetCommandGalleryItem440.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image246")));
            spreadsheetCommandGalleryItemGroup101.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem439,
            spreadsheetCommandGalleryItem440});
            spreadsheetCommandGalleryItemGroup102.CommandName = "InsertChartPie3DCommandGroup";
            spreadsheetCommandGalleryItem441.CommandName = "InsertChartPie3D";
            spreadsheetCommandGalleryItem441.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image247")));
            spreadsheetCommandGalleryItem442.CommandName = "InsertChartPieExploded3D";
            spreadsheetCommandGalleryItem442.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image248")));
            spreadsheetCommandGalleryItemGroup102.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem441,
            spreadsheetCommandGalleryItem442});
            spreadsheetCommandGalleryItemGroup103.CommandName = "InsertChartDoughnut2DCommandGroup";
            spreadsheetCommandGalleryItem443.CommandName = "InsertChartDoughnut2D";
            spreadsheetCommandGalleryItem443.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image249")));
            spreadsheetCommandGalleryItem444.CommandName = "InsertChartDoughnutExploded2D";
            spreadsheetCommandGalleryItem444.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image250")));
            spreadsheetCommandGalleryItemGroup103.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem443,
            spreadsheetCommandGalleryItem444});
            this.commandBarGalleryDropDown32.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup101,
            spreadsheetCommandGalleryItemGroup102,
            spreadsheetCommandGalleryItemGroup103});
            this.commandBarGalleryDropDown32.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown32.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown32.Manager = null;
            this.commandBarGalleryDropDown32.Name = "commandBarGalleryDropDown32";
            // 
            // commandBarGalleryDropDown33
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown33.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup104.CommandName = "InsertChartBar2DCommandGroup";
            spreadsheetCommandGalleryItem445.CommandName = "InsertChartBarClustered2D";
            spreadsheetCommandGalleryItem445.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image251")));
            spreadsheetCommandGalleryItem446.CommandName = "InsertChartBarStacked2D";
            spreadsheetCommandGalleryItem446.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image252")));
            spreadsheetCommandGalleryItem447.CommandName = "InsertChartBarPercentStacked2D";
            spreadsheetCommandGalleryItem447.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image253")));
            spreadsheetCommandGalleryItemGroup104.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem445,
            spreadsheetCommandGalleryItem446,
            spreadsheetCommandGalleryItem447});
            spreadsheetCommandGalleryItemGroup105.CommandName = "InsertChartBar3DCommandGroup";
            spreadsheetCommandGalleryItem448.CommandName = "InsertChartBarClustered3D";
            spreadsheetCommandGalleryItem448.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image254")));
            spreadsheetCommandGalleryItem449.CommandName = "InsertChartBarStacked3D";
            spreadsheetCommandGalleryItem449.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image255")));
            spreadsheetCommandGalleryItem450.CommandName = "InsertChartBarPercentStacked3D";
            spreadsheetCommandGalleryItem450.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image256")));
            spreadsheetCommandGalleryItemGroup105.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem448,
            spreadsheetCommandGalleryItem449,
            spreadsheetCommandGalleryItem450});
            spreadsheetCommandGalleryItemGroup106.CommandName = "InsertChartHorizontalCylinderCommandGroup";
            spreadsheetCommandGalleryItem451.CommandName = "InsertChartHorizontalCylinderClustered";
            spreadsheetCommandGalleryItem451.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image257")));
            spreadsheetCommandGalleryItem452.CommandName = "InsertChartHorizontalCylinderStacked";
            spreadsheetCommandGalleryItem452.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image258")));
            spreadsheetCommandGalleryItem453.CommandName = "InsertChartHorizontalCylinderPercentStacked";
            spreadsheetCommandGalleryItem453.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image259")));
            spreadsheetCommandGalleryItemGroup106.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem451,
            spreadsheetCommandGalleryItem452,
            spreadsheetCommandGalleryItem453});
            spreadsheetCommandGalleryItemGroup107.CommandName = "InsertChartHorizontalConeCommandGroup";
            spreadsheetCommandGalleryItem454.CommandName = "InsertChartHorizontalConeClustered";
            spreadsheetCommandGalleryItem454.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image260")));
            spreadsheetCommandGalleryItem455.CommandName = "InsertChartHorizontalConeStacked";
            spreadsheetCommandGalleryItem455.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image261")));
            spreadsheetCommandGalleryItem456.CommandName = "InsertChartHorizontalConePercentStacked";
            spreadsheetCommandGalleryItem456.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image262")));
            spreadsheetCommandGalleryItemGroup107.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem454,
            spreadsheetCommandGalleryItem455,
            spreadsheetCommandGalleryItem456});
            spreadsheetCommandGalleryItemGroup108.CommandName = "InsertChartHorizontalPyramidCommandGroup";
            spreadsheetCommandGalleryItem457.CommandName = "InsertChartHorizontalPyramidClustered";
            spreadsheetCommandGalleryItem457.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image263")));
            spreadsheetCommandGalleryItem458.CommandName = "InsertChartHorizontalPyramidStacked";
            spreadsheetCommandGalleryItem458.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image264")));
            spreadsheetCommandGalleryItem459.CommandName = "InsertChartHorizontalPyramidPercentStacked";
            spreadsheetCommandGalleryItem459.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image265")));
            spreadsheetCommandGalleryItemGroup108.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem457,
            spreadsheetCommandGalleryItem458,
            spreadsheetCommandGalleryItem459});
            this.commandBarGalleryDropDown33.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup104,
            spreadsheetCommandGalleryItemGroup105,
            spreadsheetCommandGalleryItemGroup106,
            spreadsheetCommandGalleryItemGroup107,
            spreadsheetCommandGalleryItemGroup108});
            this.commandBarGalleryDropDown33.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown33.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown33.Manager = null;
            this.commandBarGalleryDropDown33.Name = "commandBarGalleryDropDown33";
            // 
            // commandBarGalleryDropDown34
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown34.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup109.CommandName = "InsertChartArea2DCommandGroup";
            spreadsheetCommandGalleryItem460.CommandName = "InsertChartArea";
            spreadsheetCommandGalleryItem460.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image266")));
            spreadsheetCommandGalleryItem461.CommandName = "InsertChartStackedArea";
            spreadsheetCommandGalleryItem461.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image267")));
            spreadsheetCommandGalleryItem462.CommandName = "InsertChartPercentStackedArea";
            spreadsheetCommandGalleryItem462.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image268")));
            spreadsheetCommandGalleryItemGroup109.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem460,
            spreadsheetCommandGalleryItem461,
            spreadsheetCommandGalleryItem462});
            spreadsheetCommandGalleryItemGroup110.CommandName = "InsertChartArea3DCommandGroup";
            spreadsheetCommandGalleryItem463.CommandName = "InsertChartArea3D";
            spreadsheetCommandGalleryItem463.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image269")));
            spreadsheetCommandGalleryItem464.CommandName = "InsertChartStackedArea3D";
            spreadsheetCommandGalleryItem464.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image270")));
            spreadsheetCommandGalleryItem465.CommandName = "InsertChartPercentStackedArea3D";
            spreadsheetCommandGalleryItem465.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image271")));
            spreadsheetCommandGalleryItemGroup110.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem463,
            spreadsheetCommandGalleryItem464,
            spreadsheetCommandGalleryItem465});
            this.commandBarGalleryDropDown34.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup109,
            spreadsheetCommandGalleryItemGroup110});
            this.commandBarGalleryDropDown34.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown34.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown34.Manager = null;
            this.commandBarGalleryDropDown34.Name = "commandBarGalleryDropDown34";
            // 
            // commandBarGalleryDropDown35
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown35.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup111.CommandName = "InsertChartScatterCommandGroup";
            spreadsheetCommandGalleryItem466.CommandName = "InsertChartScatterMarkers";
            spreadsheetCommandGalleryItem466.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image272")));
            spreadsheetCommandGalleryItem467.CommandName = "InsertChartScatterSmoothLinesAndMarkers";
            spreadsheetCommandGalleryItem467.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image273")));
            spreadsheetCommandGalleryItem468.CommandName = "InsertChartScatterSmoothLines";
            spreadsheetCommandGalleryItem468.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image274")));
            spreadsheetCommandGalleryItem469.CommandName = "InsertChartScatterLinesAndMarkers";
            spreadsheetCommandGalleryItem469.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image275")));
            spreadsheetCommandGalleryItem470.CommandName = "InsertChartScatterLines";
            spreadsheetCommandGalleryItem470.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image276")));
            spreadsheetCommandGalleryItemGroup111.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem466,
            spreadsheetCommandGalleryItem467,
            spreadsheetCommandGalleryItem468,
            spreadsheetCommandGalleryItem469,
            spreadsheetCommandGalleryItem470});
            spreadsheetCommandGalleryItemGroup112.CommandName = "InsertChartBubbleCommandGroup";
            spreadsheetCommandGalleryItem471.CommandName = "InsertChartBubble";
            spreadsheetCommandGalleryItem471.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image277")));
            spreadsheetCommandGalleryItem472.CommandName = "InsertChartBubble3D";
            spreadsheetCommandGalleryItem472.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image278")));
            spreadsheetCommandGalleryItemGroup112.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem471,
            spreadsheetCommandGalleryItem472});
            this.commandBarGalleryDropDown35.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup111,
            spreadsheetCommandGalleryItemGroup112});
            this.commandBarGalleryDropDown35.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown35.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown35.Manager = null;
            this.commandBarGalleryDropDown35.Name = "commandBarGalleryDropDown35";
            // 
            // commandBarGalleryDropDown36
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown36.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup113.CommandName = "InsertChartStockCommandGroup";
            spreadsheetCommandGalleryItem473.CommandName = "InsertChartStockHighLowClose";
            spreadsheetCommandGalleryItem473.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image279")));
            spreadsheetCommandGalleryItem474.CommandName = "InsertChartStockOpenHighLowClose";
            spreadsheetCommandGalleryItem474.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image280")));
            spreadsheetCommandGalleryItem475.CommandName = "InsertChartStockVolumeHighLowClose";
            spreadsheetCommandGalleryItem475.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image281")));
            spreadsheetCommandGalleryItem476.CommandName = "InsertChartStockVolumeOpenHighLowClose";
            spreadsheetCommandGalleryItem476.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image282")));
            spreadsheetCommandGalleryItemGroup113.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem473,
            spreadsheetCommandGalleryItem474,
            spreadsheetCommandGalleryItem475,
            spreadsheetCommandGalleryItem476});
            spreadsheetCommandGalleryItemGroup114.CommandName = "InsertChartRadarCommandGroup";
            spreadsheetCommandGalleryItem477.CommandName = "InsertChartRadar";
            spreadsheetCommandGalleryItem477.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image283")));
            spreadsheetCommandGalleryItem478.CommandName = "InsertChartRadarWithMarkers";
            spreadsheetCommandGalleryItem478.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image284")));
            spreadsheetCommandGalleryItem479.CommandName = "InsertChartRadarFilled";
            spreadsheetCommandGalleryItem479.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image285")));
            spreadsheetCommandGalleryItemGroup114.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem477,
            spreadsheetCommandGalleryItem478,
            spreadsheetCommandGalleryItem479});
            this.commandBarGalleryDropDown36.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup113,
            spreadsheetCommandGalleryItemGroup114});
            this.commandBarGalleryDropDown36.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown36.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown36.Manager = null;
            this.commandBarGalleryDropDown36.Name = "commandBarGalleryDropDown36";
            // 
            // commandBarGalleryDropDown37
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown37.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown37.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup115.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            spreadsheetCommandGalleryItem480.CommandName = "ChartHidePrimaryHorizontalAxis";
            spreadsheetCommandGalleryItem480.Enabled = false;
            spreadsheetCommandGalleryItem480.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image286")));
            spreadsheetCommandGalleryItem481.CommandName = "ChartPrimaryHorizontalAxisLeftToRight";
            spreadsheetCommandGalleryItem481.Enabled = false;
            spreadsheetCommandGalleryItem481.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image287")));
            spreadsheetCommandGalleryItem482.CommandName = "ChartPrimaryHorizontalAxisHideLabels";
            spreadsheetCommandGalleryItem482.Enabled = false;
            spreadsheetCommandGalleryItem482.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image288")));
            spreadsheetCommandGalleryItem483.CommandName = "ChartPrimaryHorizontalAxisRightToLeft";
            spreadsheetCommandGalleryItem483.Enabled = false;
            spreadsheetCommandGalleryItem483.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image289")));
            spreadsheetCommandGalleryItem484.CommandName = "ChartPrimaryHorizontalAxisDefault";
            spreadsheetCommandGalleryItem484.Enabled = false;
            spreadsheetCommandGalleryItem484.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image290")));
            spreadsheetCommandGalleryItem485.CommandName = "ChartPrimaryHorizontalAxisScaleThousands";
            spreadsheetCommandGalleryItem485.Enabled = false;
            spreadsheetCommandGalleryItem485.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image291")));
            spreadsheetCommandGalleryItem486.CommandName = "ChartPrimaryHorizontalAxisScaleMillions";
            spreadsheetCommandGalleryItem486.Enabled = false;
            spreadsheetCommandGalleryItem486.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image292")));
            spreadsheetCommandGalleryItem487.CommandName = "ChartPrimaryHorizontalAxisScaleBillions";
            spreadsheetCommandGalleryItem487.Enabled = false;
            spreadsheetCommandGalleryItem487.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image293")));
            spreadsheetCommandGalleryItem488.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm";
            spreadsheetCommandGalleryItem488.Enabled = false;
            spreadsheetCommandGalleryItem488.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image294")));
            spreadsheetCommandGalleryItemGroup115.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem480,
            spreadsheetCommandGalleryItem481,
            spreadsheetCommandGalleryItem482,
            spreadsheetCommandGalleryItem483,
            spreadsheetCommandGalleryItem484,
            spreadsheetCommandGalleryItem485,
            spreadsheetCommandGalleryItem486,
            spreadsheetCommandGalleryItem487,
            spreadsheetCommandGalleryItem488});
            this.commandBarGalleryDropDown37.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup115});
            this.commandBarGalleryDropDown37.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown37.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown37.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown37.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown37.Manager = null;
            this.commandBarGalleryDropDown37.Name = "commandBarGalleryDropDown37";
            // 
            // commandBarGalleryDropDown38
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown38.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown38.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup116.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            spreadsheetCommandGalleryItem489.CommandName = "ChartHidePrimaryVerticalAxis";
            spreadsheetCommandGalleryItem489.Enabled = false;
            spreadsheetCommandGalleryItem489.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image295")));
            spreadsheetCommandGalleryItem490.CommandName = "ChartPrimaryVerticalAxisLeftToRight";
            spreadsheetCommandGalleryItem490.Enabled = false;
            spreadsheetCommandGalleryItem490.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image296")));
            spreadsheetCommandGalleryItem491.CommandName = "ChartPrimaryVerticalAxisHideLabels";
            spreadsheetCommandGalleryItem491.Enabled = false;
            spreadsheetCommandGalleryItem491.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image297")));
            spreadsheetCommandGalleryItem492.CommandName = "ChartPrimaryVerticalAxisRightToLeft";
            spreadsheetCommandGalleryItem492.Enabled = false;
            spreadsheetCommandGalleryItem492.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image298")));
            spreadsheetCommandGalleryItem493.CommandName = "ChartPrimaryVerticalAxisDefault";
            spreadsheetCommandGalleryItem493.Enabled = false;
            spreadsheetCommandGalleryItem493.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image299")));
            spreadsheetCommandGalleryItem494.CommandName = "ChartPrimaryVerticalAxisScaleThousands";
            spreadsheetCommandGalleryItem494.Enabled = false;
            spreadsheetCommandGalleryItem494.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image300")));
            spreadsheetCommandGalleryItem495.CommandName = "ChartPrimaryVerticalAxisScaleMillions";
            spreadsheetCommandGalleryItem495.Enabled = false;
            spreadsheetCommandGalleryItem495.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image301")));
            spreadsheetCommandGalleryItem496.CommandName = "ChartPrimaryVerticalAxisScaleBillions";
            spreadsheetCommandGalleryItem496.Enabled = false;
            spreadsheetCommandGalleryItem496.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image302")));
            spreadsheetCommandGalleryItem497.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm";
            spreadsheetCommandGalleryItem497.Enabled = false;
            spreadsheetCommandGalleryItem497.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image303")));
            spreadsheetCommandGalleryItemGroup116.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem489,
            spreadsheetCommandGalleryItem490,
            spreadsheetCommandGalleryItem491,
            spreadsheetCommandGalleryItem492,
            spreadsheetCommandGalleryItem493,
            spreadsheetCommandGalleryItem494,
            spreadsheetCommandGalleryItem495,
            spreadsheetCommandGalleryItem496,
            spreadsheetCommandGalleryItem497});
            this.commandBarGalleryDropDown38.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup116});
            this.commandBarGalleryDropDown38.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown38.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown38.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown38.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown38.Manager = null;
            this.commandBarGalleryDropDown38.Name = "commandBarGalleryDropDown38";
            // 
            // commandBarGalleryDropDown39
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown39.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown39.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup117.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem498.CommandName = "ChartPrimaryHorizontalGridlinesNone";
            spreadsheetCommandGalleryItem498.Enabled = false;
            spreadsheetCommandGalleryItem498.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image304")));
            spreadsheetCommandGalleryItem499.CommandName = "ChartPrimaryHorizontalGridlinesMajor";
            spreadsheetCommandGalleryItem499.Enabled = false;
            spreadsheetCommandGalleryItem499.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image305")));
            spreadsheetCommandGalleryItem500.CommandName = "ChartPrimaryHorizontalGridlinesMinor";
            spreadsheetCommandGalleryItem500.Enabled = false;
            spreadsheetCommandGalleryItem500.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image306")));
            spreadsheetCommandGalleryItem501.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItem501.Enabled = false;
            spreadsheetCommandGalleryItem501.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image307")));
            spreadsheetCommandGalleryItemGroup117.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem498,
            spreadsheetCommandGalleryItem499,
            spreadsheetCommandGalleryItem500,
            spreadsheetCommandGalleryItem501});
            this.commandBarGalleryDropDown39.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup117});
            this.commandBarGalleryDropDown39.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown39.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown39.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown39.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown39.Manager = null;
            this.commandBarGalleryDropDown39.Name = "commandBarGalleryDropDown39";
            // 
            // commandBarGalleryDropDown40
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown40.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown40.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup118.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem502.CommandName = "ChartPrimaryVerticalGridlinesNone";
            spreadsheetCommandGalleryItem502.Enabled = false;
            spreadsheetCommandGalleryItem502.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image308")));
            spreadsheetCommandGalleryItem503.CommandName = "ChartPrimaryVerticalGridlinesMajor";
            spreadsheetCommandGalleryItem503.Enabled = false;
            spreadsheetCommandGalleryItem503.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image309")));
            spreadsheetCommandGalleryItem504.CommandName = "ChartPrimaryVerticalGridlinesMinor";
            spreadsheetCommandGalleryItem504.Enabled = false;
            spreadsheetCommandGalleryItem504.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image310")));
            spreadsheetCommandGalleryItem505.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItem505.Enabled = false;
            spreadsheetCommandGalleryItem505.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image311")));
            spreadsheetCommandGalleryItemGroup118.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem502,
            spreadsheetCommandGalleryItem503,
            spreadsheetCommandGalleryItem504,
            spreadsheetCommandGalleryItem505});
            this.commandBarGalleryDropDown40.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup118});
            this.commandBarGalleryDropDown40.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown40.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown40.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown40.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown40.Manager = null;
            this.commandBarGalleryDropDown40.Name = "commandBarGalleryDropDown40";
            // 
            // commandBarGalleryDropDown41
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown41.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown41.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup119.CommandName = "ChartTitleCommandGroup";
            spreadsheetCommandGalleryItem506.CommandName = "ChartTitleNone";
            spreadsheetCommandGalleryItem506.Enabled = false;
            spreadsheetCommandGalleryItem506.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image312")));
            spreadsheetCommandGalleryItem507.CommandName = "ChartTitleCenteredOverlay";
            spreadsheetCommandGalleryItem507.Enabled = false;
            spreadsheetCommandGalleryItem507.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image313")));
            spreadsheetCommandGalleryItem508.CommandName = "ChartTitleAbove";
            spreadsheetCommandGalleryItem508.Enabled = false;
            spreadsheetCommandGalleryItem508.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image314")));
            spreadsheetCommandGalleryItemGroup119.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem506,
            spreadsheetCommandGalleryItem507,
            spreadsheetCommandGalleryItem508});
            this.commandBarGalleryDropDown41.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup119});
            this.commandBarGalleryDropDown41.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown41.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown41.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown41.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown41.Manager = null;
            this.commandBarGalleryDropDown41.Name = "commandBarGalleryDropDown41";
            // 
            // commandBarGalleryDropDown42
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown42.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown42.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup120.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem509.CommandName = "ChartPrimaryHorizontalAxisTitleNone";
            spreadsheetCommandGalleryItem509.Enabled = false;
            spreadsheetCommandGalleryItem509.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image315")));
            spreadsheetCommandGalleryItem510.CommandName = "ChartPrimaryHorizontalAxisTitleBelow";
            spreadsheetCommandGalleryItem510.Enabled = false;
            spreadsheetCommandGalleryItem510.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image316")));
            spreadsheetCommandGalleryItemGroup120.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem509,
            spreadsheetCommandGalleryItem510});
            this.commandBarGalleryDropDown42.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup120});
            this.commandBarGalleryDropDown42.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown42.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown42.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown42.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown42.Manager = null;
            this.commandBarGalleryDropDown42.Name = "commandBarGalleryDropDown42";
            // 
            // commandBarGalleryDropDown43
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown43.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown43.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup121.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem511.CommandName = "ChartPrimaryVerticalAxisTitleNone";
            spreadsheetCommandGalleryItem511.Enabled = false;
            spreadsheetCommandGalleryItem511.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image317")));
            spreadsheetCommandGalleryItem512.CommandName = "ChartPrimaryVerticalAxisTitleRotated";
            spreadsheetCommandGalleryItem512.Enabled = false;
            spreadsheetCommandGalleryItem512.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image318")));
            spreadsheetCommandGalleryItemGroup121.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem511,
            spreadsheetCommandGalleryItem512});
            this.commandBarGalleryDropDown43.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup121});
            this.commandBarGalleryDropDown43.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown43.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown43.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown43.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown43.Manager = null;
            this.commandBarGalleryDropDown43.Name = "commandBarGalleryDropDown43";
            // 
            // commandBarGalleryDropDown44
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown44.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown44.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup122.CommandName = "ChartLegendCommandGroup";
            spreadsheetCommandGalleryItem515.CommandName = "ChartLegendNone";
            spreadsheetCommandGalleryItem515.Enabled = false;
            spreadsheetCommandGalleryItem515.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image321")));
            spreadsheetCommandGalleryItem516.CommandName = "ChartLegendAtRight";
            spreadsheetCommandGalleryItem516.Enabled = false;
            spreadsheetCommandGalleryItem516.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image322")));
            spreadsheetCommandGalleryItem517.CommandName = "ChartLegendAtTop";
            spreadsheetCommandGalleryItem517.Enabled = false;
            spreadsheetCommandGalleryItem517.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image323")));
            spreadsheetCommandGalleryItem518.CommandName = "ChartLegendAtLeft";
            spreadsheetCommandGalleryItem518.Enabled = false;
            spreadsheetCommandGalleryItem518.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image324")));
            spreadsheetCommandGalleryItem519.CommandName = "ChartLegendAtBottom";
            spreadsheetCommandGalleryItem519.Enabled = false;
            spreadsheetCommandGalleryItem519.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image325")));
            spreadsheetCommandGalleryItem520.CommandName = "ChartLegendOverlayAtRight";
            spreadsheetCommandGalleryItem520.Enabled = false;
            spreadsheetCommandGalleryItem520.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image326")));
            spreadsheetCommandGalleryItem521.CommandName = "ChartLegendOverlayAtLeft";
            spreadsheetCommandGalleryItem521.Enabled = false;
            spreadsheetCommandGalleryItem521.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image327")));
            spreadsheetCommandGalleryItemGroup122.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem515,
            spreadsheetCommandGalleryItem516,
            spreadsheetCommandGalleryItem517,
            spreadsheetCommandGalleryItem518,
            spreadsheetCommandGalleryItem519,
            spreadsheetCommandGalleryItem520,
            spreadsheetCommandGalleryItem521});
            this.commandBarGalleryDropDown44.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup122});
            this.commandBarGalleryDropDown44.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown44.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown44.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown44.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown44.Manager = null;
            this.commandBarGalleryDropDown44.Name = "commandBarGalleryDropDown44";
            // 
            // commandBarGalleryDropDown45
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown45.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown45.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup123.CommandName = "ChartDataLabelsCommandGroup";
            spreadsheetCommandGalleryItem522.CommandName = "ChartDataLabelsNone";
            spreadsheetCommandGalleryItem522.Enabled = false;
            spreadsheetCommandGalleryItem522.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image328")));
            spreadsheetCommandGalleryItem523.CommandName = "ChartDataLabelsDefault";
            spreadsheetCommandGalleryItem523.Enabled = false;
            spreadsheetCommandGalleryItem523.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image329")));
            spreadsheetCommandGalleryItem524.CommandName = "ChartDataLabelsCenter";
            spreadsheetCommandGalleryItem524.Enabled = false;
            spreadsheetCommandGalleryItem524.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image330")));
            spreadsheetCommandGalleryItem525.CommandName = "ChartDataLabelsInsideEnd";
            spreadsheetCommandGalleryItem525.Enabled = false;
            spreadsheetCommandGalleryItem525.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image331")));
            spreadsheetCommandGalleryItem526.CommandName = "ChartDataLabelsInsideBase";
            spreadsheetCommandGalleryItem526.Enabled = false;
            spreadsheetCommandGalleryItem526.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image332")));
            spreadsheetCommandGalleryItem527.CommandName = "ChartDataLabelsOutsideEnd";
            spreadsheetCommandGalleryItem527.Enabled = false;
            spreadsheetCommandGalleryItem527.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image333")));
            spreadsheetCommandGalleryItem528.CommandName = "ChartDataLabelsBestFit";
            spreadsheetCommandGalleryItem528.Enabled = false;
            spreadsheetCommandGalleryItem528.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image334")));
            spreadsheetCommandGalleryItem529.CommandName = "ChartDataLabelsLeft";
            spreadsheetCommandGalleryItem529.Enabled = false;
            spreadsheetCommandGalleryItem529.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image335")));
            spreadsheetCommandGalleryItem530.CommandName = "ChartDataLabelsRight";
            spreadsheetCommandGalleryItem530.Enabled = false;
            spreadsheetCommandGalleryItem530.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image336")));
            spreadsheetCommandGalleryItem531.CommandName = "ChartDataLabelsAbove";
            spreadsheetCommandGalleryItem531.Enabled = false;
            spreadsheetCommandGalleryItem531.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image337")));
            spreadsheetCommandGalleryItem532.CommandName = "ChartDataLabelsBelow";
            spreadsheetCommandGalleryItem532.Enabled = false;
            spreadsheetCommandGalleryItem532.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image338")));
            spreadsheetCommandGalleryItemGroup123.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem522,
            spreadsheetCommandGalleryItem523,
            spreadsheetCommandGalleryItem524,
            spreadsheetCommandGalleryItem525,
            spreadsheetCommandGalleryItem526,
            spreadsheetCommandGalleryItem527,
            spreadsheetCommandGalleryItem528,
            spreadsheetCommandGalleryItem529,
            spreadsheetCommandGalleryItem530,
            spreadsheetCommandGalleryItem531,
            spreadsheetCommandGalleryItem532});
            this.commandBarGalleryDropDown45.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup123});
            this.commandBarGalleryDropDown45.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown45.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown45.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown45.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown45.Manager = null;
            this.commandBarGalleryDropDown45.Name = "commandBarGalleryDropDown45";
            // 
            // commandBarGalleryDropDown46
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown46.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown46.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup124.CommandName = "ChartLinesCommandGroup";
            spreadsheetCommandGalleryItem533.CommandName = "ChartLinesNone";
            spreadsheetCommandGalleryItem533.Enabled = false;
            spreadsheetCommandGalleryItem533.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image339")));
            spreadsheetCommandGalleryItem534.CommandName = "ChartShowDropLines";
            spreadsheetCommandGalleryItem534.Enabled = false;
            spreadsheetCommandGalleryItem534.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image340")));
            spreadsheetCommandGalleryItem535.CommandName = "ChartShowHighLowLines";
            spreadsheetCommandGalleryItem535.Enabled = false;
            spreadsheetCommandGalleryItem535.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image341")));
            spreadsheetCommandGalleryItem536.CommandName = "ChartShowDropLinesAndHighLowLines";
            spreadsheetCommandGalleryItem536.Enabled = false;
            spreadsheetCommandGalleryItem536.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image342")));
            spreadsheetCommandGalleryItem537.CommandName = "ChartShowSeriesLines";
            spreadsheetCommandGalleryItem537.Enabled = false;
            spreadsheetCommandGalleryItem537.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image343")));
            spreadsheetCommandGalleryItemGroup124.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem533,
            spreadsheetCommandGalleryItem534,
            spreadsheetCommandGalleryItem535,
            spreadsheetCommandGalleryItem536,
            spreadsheetCommandGalleryItem537});
            this.commandBarGalleryDropDown46.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup124});
            this.commandBarGalleryDropDown46.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown46.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown46.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown46.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown46.Manager = null;
            this.commandBarGalleryDropDown46.Name = "commandBarGalleryDropDown46";
            // 
            // commandBarGalleryDropDown47
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown47.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown47.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup125.CommandName = "ChartUpDownBarsCommandGroup";
            spreadsheetCommandGalleryItem538.CommandName = "ChartHideUpDownBars";
            spreadsheetCommandGalleryItem538.Enabled = false;
            spreadsheetCommandGalleryItem538.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image344")));
            spreadsheetCommandGalleryItem539.CommandName = "ChartShowUpDownBars";
            spreadsheetCommandGalleryItem539.Enabled = false;
            spreadsheetCommandGalleryItem539.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image345")));
            spreadsheetCommandGalleryItemGroup125.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem538,
            spreadsheetCommandGalleryItem539});
            this.commandBarGalleryDropDown47.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup125});
            this.commandBarGalleryDropDown47.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown47.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown47.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown47.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown47.Manager = null;
            this.commandBarGalleryDropDown47.Name = "commandBarGalleryDropDown47";
            // 
            // commandBarGalleryDropDown48
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown48.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown48.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup126.CommandName = "ChartErrorBarsCommandGroup";
            spreadsheetCommandGalleryItem540.CommandName = "ChartErrorBarsNone";
            spreadsheetCommandGalleryItem540.Enabled = false;
            spreadsheetCommandGalleryItem540.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image346")));
            spreadsheetCommandGalleryItem541.CommandName = "ChartErrorBarsStandardError";
            spreadsheetCommandGalleryItem541.Enabled = false;
            spreadsheetCommandGalleryItem541.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image347")));
            spreadsheetCommandGalleryItem542.CommandName = "ChartErrorBarsPercentage";
            spreadsheetCommandGalleryItem542.Enabled = false;
            spreadsheetCommandGalleryItem542.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image348")));
            spreadsheetCommandGalleryItem543.CommandName = "ChartErrorBarsStandardDeviation";
            spreadsheetCommandGalleryItem543.Enabled = false;
            spreadsheetCommandGalleryItem543.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image349")));
            spreadsheetCommandGalleryItemGroup126.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem540,
            spreadsheetCommandGalleryItem541,
            spreadsheetCommandGalleryItem542,
            spreadsheetCommandGalleryItem543});
            this.commandBarGalleryDropDown48.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup126});
            this.commandBarGalleryDropDown48.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown48.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown48.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown48.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown48.Manager = null;
            this.commandBarGalleryDropDown48.Name = "commandBarGalleryDropDown48";
            // 
            // commandBarGalleryDropDown2
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown2.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup127.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup";
            spreadsheetCommandGalleryItem544.CommandName = "ConditionalFormattingDataBarGradientBlue";
            spreadsheetCommandGalleryItem544.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image350")));
            spreadsheetCommandGalleryItem545.CommandName = "ConditionalFormattingDataBarGradientGreen";
            spreadsheetCommandGalleryItem545.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image351")));
            spreadsheetCommandGalleryItem546.CommandName = "ConditionalFormattingDataBarGradientRed";
            spreadsheetCommandGalleryItem546.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image352")));
            spreadsheetCommandGalleryItem547.CommandName = "ConditionalFormattingDataBarGradientOrange";
            spreadsheetCommandGalleryItem547.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image353")));
            spreadsheetCommandGalleryItem548.CommandName = "ConditionalFormattingDataBarGradientLightBlue";
            spreadsheetCommandGalleryItem548.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image354")));
            spreadsheetCommandGalleryItem549.CommandName = "ConditionalFormattingDataBarGradientPurple";
            spreadsheetCommandGalleryItem549.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image355")));
            spreadsheetCommandGalleryItemGroup127.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem544,
            spreadsheetCommandGalleryItem545,
            spreadsheetCommandGalleryItem546,
            spreadsheetCommandGalleryItem547,
            spreadsheetCommandGalleryItem548,
            spreadsheetCommandGalleryItem549});
            spreadsheetCommandGalleryItemGroup128.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup";
            spreadsheetCommandGalleryItem550.CommandName = "ConditionalFormattingDataBarSolidBlue";
            spreadsheetCommandGalleryItem550.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image356")));
            spreadsheetCommandGalleryItem551.CommandName = "ConditionalFormattingDataBarSolidGreen";
            spreadsheetCommandGalleryItem551.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image357")));
            spreadsheetCommandGalleryItem552.CommandName = "ConditionalFormattingDataBarSolidRed";
            spreadsheetCommandGalleryItem552.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image358")));
            spreadsheetCommandGalleryItem553.CommandName = "ConditionalFormattingDataBarSolidOrange";
            spreadsheetCommandGalleryItem553.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image359")));
            spreadsheetCommandGalleryItem554.CommandName = "ConditionalFormattingDataBarSolidLightBlue";
            spreadsheetCommandGalleryItem554.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image360")));
            spreadsheetCommandGalleryItem555.CommandName = "ConditionalFormattingDataBarSolidPurple";
            spreadsheetCommandGalleryItem555.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image361")));
            spreadsheetCommandGalleryItemGroup128.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem550,
            spreadsheetCommandGalleryItem551,
            spreadsheetCommandGalleryItem552,
            spreadsheetCommandGalleryItem553,
            spreadsheetCommandGalleryItem554,
            spreadsheetCommandGalleryItem555});
            this.commandBarGalleryDropDown2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup127,
            spreadsheetCommandGalleryItemGroup128});
            this.commandBarGalleryDropDown2.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown2.Manager = null;
            this.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2";
            // 
            // commandBarGalleryDropDown1
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown1.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown1.Gallery.ColumnCount = 1;
            this.commandBarGalleryDropDown1.Gallery.DrawImageBackground = false;
            galleryItem15.Tag = DevExpress.Export.Xl.XlBorderLineStyle.None;
            galleryItem16.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thin;
            galleryItem17.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Hair;
            galleryItem18.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dotted;
            galleryItem19.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dashed;
            galleryItem20.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDot;
            galleryItem21.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDotDot;
            galleryItem22.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Double;
            galleryItem23.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Medium;
            galleryItem24.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashed;
            galleryItem25.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDot;
            galleryItem26.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDotDot;
            galleryItem27.Tag = DevExpress.Export.Xl.XlBorderLineStyle.SlantDashDot;
            galleryItem28.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thick;
            galleryItemGroup3.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem15,
            galleryItem16,
            galleryItem17,
            galleryItem18,
            galleryItem19,
            galleryItem20,
            galleryItem21,
            galleryItem22,
            galleryItem23,
            galleryItem24,
            galleryItem25,
            galleryItem26,
            galleryItem27,
            galleryItem28});
            this.commandBarGalleryDropDown1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup3});
            this.commandBarGalleryDropDown1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            this.commandBarGalleryDropDown1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown1.Gallery.ItemSize = new System.Drawing.Size(136, 26);
            this.commandBarGalleryDropDown1.Gallery.RowCount = 14;
            this.commandBarGalleryDropDown1.Gallery.ShowGroupCaption = false;
            this.commandBarGalleryDropDown1.Gallery.ShowItemText = true;
            this.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown1.Manager = null;
            this.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1";
            // 
            // commandBarGalleryDropDown3
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown3.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup129.CommandName = "ConditionalFormattingColorScalesCommandGroup";
            spreadsheetCommandGalleryItem556.CommandName = "ConditionalFormattingColorScaleGreenYellowRed";
            spreadsheetCommandGalleryItem556.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image362")));
            spreadsheetCommandGalleryItem557.CommandName = "ConditionalFormattingColorScaleRedYellowGreen";
            spreadsheetCommandGalleryItem557.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image363")));
            spreadsheetCommandGalleryItem558.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed";
            spreadsheetCommandGalleryItem558.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image364")));
            spreadsheetCommandGalleryItem559.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen";
            spreadsheetCommandGalleryItem559.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image365")));
            spreadsheetCommandGalleryItem560.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed";
            spreadsheetCommandGalleryItem560.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image366")));
            spreadsheetCommandGalleryItem561.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue";
            spreadsheetCommandGalleryItem561.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image367")));
            spreadsheetCommandGalleryItem562.CommandName = "ConditionalFormattingColorScaleWhiteRed";
            spreadsheetCommandGalleryItem562.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image368")));
            spreadsheetCommandGalleryItem563.CommandName = "ConditionalFormattingColorScaleRedWhite";
            spreadsheetCommandGalleryItem563.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image369")));
            spreadsheetCommandGalleryItem564.CommandName = "ConditionalFormattingColorScaleGreenWhite";
            spreadsheetCommandGalleryItem564.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image370")));
            spreadsheetCommandGalleryItem565.CommandName = "ConditionalFormattingColorScaleWhiteGreen";
            spreadsheetCommandGalleryItem565.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image371")));
            spreadsheetCommandGalleryItem566.CommandName = "ConditionalFormattingColorScaleGreenYellow";
            spreadsheetCommandGalleryItem566.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image372")));
            spreadsheetCommandGalleryItem567.CommandName = "ConditionalFormattingColorScaleYellowGreen";
            spreadsheetCommandGalleryItem567.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image373")));
            spreadsheetCommandGalleryItemGroup129.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem556,
            spreadsheetCommandGalleryItem557,
            spreadsheetCommandGalleryItem558,
            spreadsheetCommandGalleryItem559,
            spreadsheetCommandGalleryItem560,
            spreadsheetCommandGalleryItem561,
            spreadsheetCommandGalleryItem562,
            spreadsheetCommandGalleryItem563,
            spreadsheetCommandGalleryItem564,
            spreadsheetCommandGalleryItem565,
            spreadsheetCommandGalleryItem566,
            spreadsheetCommandGalleryItem567});
            this.commandBarGalleryDropDown3.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup129});
            this.commandBarGalleryDropDown3.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown3.Manager = null;
            this.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3";
            // 
            // commandBarGalleryDropDown4
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown4.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup130.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup";
            spreadsheetCommandGalleryItem568.CommandName = "ConditionalFormattingIconSetArrows3Colored";
            spreadsheetCommandGalleryItem568.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image374")));
            spreadsheetCommandGalleryItem569.CommandName = "ConditionalFormattingIconSetArrows3Grayed";
            spreadsheetCommandGalleryItem569.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image375")));
            spreadsheetCommandGalleryItem570.CommandName = "ConditionalFormattingIconSetArrows4Colored";
            spreadsheetCommandGalleryItem570.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image376")));
            spreadsheetCommandGalleryItem571.CommandName = "ConditionalFormattingIconSetArrows4Grayed";
            spreadsheetCommandGalleryItem571.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image377")));
            spreadsheetCommandGalleryItem572.CommandName = "ConditionalFormattingIconSetArrows5Colored";
            spreadsheetCommandGalleryItem572.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image378")));
            spreadsheetCommandGalleryItem573.CommandName = "ConditionalFormattingIconSetArrows5Grayed";
            spreadsheetCommandGalleryItem573.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image379")));
            spreadsheetCommandGalleryItem574.CommandName = "ConditionalFormattingIconSetTriangles3";
            spreadsheetCommandGalleryItem574.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image380")));
            spreadsheetCommandGalleryItemGroup130.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem568,
            spreadsheetCommandGalleryItem569,
            spreadsheetCommandGalleryItem570,
            spreadsheetCommandGalleryItem571,
            spreadsheetCommandGalleryItem572,
            spreadsheetCommandGalleryItem573,
            spreadsheetCommandGalleryItem574});
            spreadsheetCommandGalleryItemGroup131.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup";
            spreadsheetCommandGalleryItem575.CommandName = "ConditionalFormattingIconSetTrafficLights3";
            spreadsheetCommandGalleryItem575.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image381")));
            spreadsheetCommandGalleryItem576.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed";
            spreadsheetCommandGalleryItem576.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image382")));
            spreadsheetCommandGalleryItem577.CommandName = "ConditionalFormattingIconSetTrafficLights4";
            spreadsheetCommandGalleryItem577.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image383")));
            spreadsheetCommandGalleryItem578.CommandName = "ConditionalFormattingIconSetSigns3";
            spreadsheetCommandGalleryItem578.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image384")));
            spreadsheetCommandGalleryItem579.CommandName = "ConditionalFormattingIconSetRedToBlack";
            spreadsheetCommandGalleryItem579.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image385")));
            spreadsheetCommandGalleryItemGroup131.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem575,
            spreadsheetCommandGalleryItem576,
            spreadsheetCommandGalleryItem577,
            spreadsheetCommandGalleryItem578,
            spreadsheetCommandGalleryItem579});
            spreadsheetCommandGalleryItemGroup132.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup";
            spreadsheetCommandGalleryItem580.CommandName = "ConditionalFormattingIconSetSymbols3Circled";
            spreadsheetCommandGalleryItem580.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image386")));
            spreadsheetCommandGalleryItem581.CommandName = "ConditionalFormattingIconSetSymbols3";
            spreadsheetCommandGalleryItem581.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image387")));
            spreadsheetCommandGalleryItem582.CommandName = "ConditionalFormattingIconSetFlags3";
            spreadsheetCommandGalleryItem582.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image388")));
            spreadsheetCommandGalleryItemGroup132.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem580,
            spreadsheetCommandGalleryItem581,
            spreadsheetCommandGalleryItem582});
            spreadsheetCommandGalleryItemGroup133.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup";
            spreadsheetCommandGalleryItem583.CommandName = "ConditionalFormattingIconSetStars3";
            spreadsheetCommandGalleryItem583.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image389")));
            spreadsheetCommandGalleryItem584.CommandName = "ConditionalFormattingIconSetRatings4";
            spreadsheetCommandGalleryItem584.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image390")));
            spreadsheetCommandGalleryItem585.CommandName = "ConditionalFormattingIconSetRatings5";
            spreadsheetCommandGalleryItem585.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image391")));
            spreadsheetCommandGalleryItem586.CommandName = "ConditionalFormattingIconSetQuarters5";
            spreadsheetCommandGalleryItem586.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image392")));
            spreadsheetCommandGalleryItem587.CommandName = "ConditionalFormattingIconSetBoxes5";
            spreadsheetCommandGalleryItem587.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image393")));
            spreadsheetCommandGalleryItemGroup133.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem583,
            spreadsheetCommandGalleryItem584,
            spreadsheetCommandGalleryItem585,
            spreadsheetCommandGalleryItem586,
            spreadsheetCommandGalleryItem587});
            this.commandBarGalleryDropDown4.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup130,
            spreadsheetCommandGalleryItemGroup131,
            spreadsheetCommandGalleryItemGroup132,
            spreadsheetCommandGalleryItemGroup133});
            this.commandBarGalleryDropDown4.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown4.Manager = null;
            this.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4";
            // 
            // commandBarGalleryDropDown5
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown5.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown5.Gallery.ColumnCount = 7;
            this.commandBarGalleryDropDown5.Gallery.DrawImageBackground = false;
            this.commandBarGalleryDropDown5.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None;
            this.commandBarGalleryDropDown5.Gallery.ItemSize = new System.Drawing.Size(73, 58);
            this.commandBarGalleryDropDown5.Gallery.RowCount = 10;
            this.commandBarGalleryDropDown5.Manager = null;
            this.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5";
            // 
            // commandBarGalleryDropDown6
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown6.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup134.CommandName = "InsertChartColumn2DCommandGroup";
            spreadsheetCommandGalleryItem588.CommandName = "InsertChartColumnClustered2D";
            spreadsheetCommandGalleryItem588.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image394")));
            spreadsheetCommandGalleryItem589.CommandName = "InsertChartColumnStacked2D";
            spreadsheetCommandGalleryItem589.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image395")));
            spreadsheetCommandGalleryItem590.CommandName = "InsertChartColumnPercentStacked2D";
            spreadsheetCommandGalleryItem590.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image396")));
            spreadsheetCommandGalleryItemGroup134.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem588,
            spreadsheetCommandGalleryItem589,
            spreadsheetCommandGalleryItem590});
            spreadsheetCommandGalleryItemGroup135.CommandName = "InsertChartColumn3DCommandGroup";
            spreadsheetCommandGalleryItem591.CommandName = "InsertChartColumnClustered3D";
            spreadsheetCommandGalleryItem591.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image397")));
            spreadsheetCommandGalleryItem592.CommandName = "InsertChartColumnStacked3D";
            spreadsheetCommandGalleryItem592.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image398")));
            spreadsheetCommandGalleryItem593.CommandName = "InsertChartColumnPercentStacked3D";
            spreadsheetCommandGalleryItem593.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image399")));
            spreadsheetCommandGalleryItem594.CommandName = "InsertChartColumn3D";
            spreadsheetCommandGalleryItem594.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image400")));
            spreadsheetCommandGalleryItemGroup135.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem591,
            spreadsheetCommandGalleryItem592,
            spreadsheetCommandGalleryItem593,
            spreadsheetCommandGalleryItem594});
            spreadsheetCommandGalleryItemGroup136.CommandName = "InsertChartCylinderCommandGroup";
            spreadsheetCommandGalleryItem595.CommandName = "InsertChartCylinderClustered";
            spreadsheetCommandGalleryItem595.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image401")));
            spreadsheetCommandGalleryItem596.CommandName = "InsertChartCylinderStacked";
            spreadsheetCommandGalleryItem596.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image402")));
            spreadsheetCommandGalleryItem597.CommandName = "InsertChartCylinderPercentStacked";
            spreadsheetCommandGalleryItem597.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image403")));
            spreadsheetCommandGalleryItem598.CommandName = "InsertChartCylinder";
            spreadsheetCommandGalleryItem598.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image404")));
            spreadsheetCommandGalleryItemGroup136.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem595,
            spreadsheetCommandGalleryItem596,
            spreadsheetCommandGalleryItem597,
            spreadsheetCommandGalleryItem598});
            spreadsheetCommandGalleryItemGroup137.CommandName = "InsertChartConeCommandGroup";
            spreadsheetCommandGalleryItem599.CommandName = "InsertChartConeClustered";
            spreadsheetCommandGalleryItem599.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image405")));
            spreadsheetCommandGalleryItem600.CommandName = "InsertChartConeStacked";
            spreadsheetCommandGalleryItem600.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image406")));
            spreadsheetCommandGalleryItem601.CommandName = "InsertChartConePercentStacked";
            spreadsheetCommandGalleryItem601.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image407")));
            spreadsheetCommandGalleryItem602.CommandName = "InsertChartCone";
            spreadsheetCommandGalleryItem602.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image408")));
            spreadsheetCommandGalleryItemGroup137.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem599,
            spreadsheetCommandGalleryItem600,
            spreadsheetCommandGalleryItem601,
            spreadsheetCommandGalleryItem602});
            spreadsheetCommandGalleryItemGroup138.CommandName = "InsertChartPyramidCommandGroup";
            spreadsheetCommandGalleryItem603.CommandName = "InsertChartPyramidClustered";
            spreadsheetCommandGalleryItem603.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image409")));
            spreadsheetCommandGalleryItem604.CommandName = "InsertChartPyramidStacked";
            spreadsheetCommandGalleryItem604.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image410")));
            spreadsheetCommandGalleryItem605.CommandName = "InsertChartPyramidPercentStacked";
            spreadsheetCommandGalleryItem605.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image411")));
            spreadsheetCommandGalleryItem606.CommandName = "InsertChartPyramid";
            spreadsheetCommandGalleryItem606.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image412")));
            spreadsheetCommandGalleryItemGroup138.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem603,
            spreadsheetCommandGalleryItem604,
            spreadsheetCommandGalleryItem605,
            spreadsheetCommandGalleryItem606});
            this.commandBarGalleryDropDown6.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup134,
            spreadsheetCommandGalleryItemGroup135,
            spreadsheetCommandGalleryItemGroup136,
            spreadsheetCommandGalleryItemGroup137,
            spreadsheetCommandGalleryItemGroup138});
            this.commandBarGalleryDropDown6.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown6.Manager = null;
            this.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6";
            // 
            // commandBarGalleryDropDown7
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown7.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup139.CommandName = "InsertChartLine2DCommandGroup";
            spreadsheetCommandGalleryItem607.CommandName = "InsertChartLine";
            spreadsheetCommandGalleryItem607.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image413")));
            spreadsheetCommandGalleryItem608.CommandName = "InsertChartStackedLine";
            spreadsheetCommandGalleryItem608.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image414")));
            spreadsheetCommandGalleryItem609.CommandName = "InsertChartPercentStackedLine";
            spreadsheetCommandGalleryItem609.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image415")));
            spreadsheetCommandGalleryItem610.CommandName = "InsertChartLineWithMarkers";
            spreadsheetCommandGalleryItem610.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image416")));
            spreadsheetCommandGalleryItem611.CommandName = "InsertChartStackedLineWithMarkers";
            spreadsheetCommandGalleryItem611.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image417")));
            spreadsheetCommandGalleryItem612.CommandName = "InsertChartPercentStackedLineWithMarkers";
            spreadsheetCommandGalleryItem612.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image418")));
            spreadsheetCommandGalleryItemGroup139.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem607,
            spreadsheetCommandGalleryItem608,
            spreadsheetCommandGalleryItem609,
            spreadsheetCommandGalleryItem610,
            spreadsheetCommandGalleryItem611,
            spreadsheetCommandGalleryItem612});
            spreadsheetCommandGalleryItemGroup140.CommandName = "InsertChartLine3DCommandGroup";
            spreadsheetCommandGalleryItem613.CommandName = "InsertChartLine3D";
            spreadsheetCommandGalleryItem613.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image419")));
            spreadsheetCommandGalleryItemGroup140.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem613});
            this.commandBarGalleryDropDown7.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup139,
            spreadsheetCommandGalleryItemGroup140});
            this.commandBarGalleryDropDown7.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown7.Manager = null;
            this.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7";
            // 
            // commandBarGalleryDropDown8
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown8.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup141.CommandName = "InsertChartPie2DCommandGroup";
            spreadsheetCommandGalleryItem614.CommandName = "InsertChartPie2D";
            spreadsheetCommandGalleryItem614.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image420")));
            spreadsheetCommandGalleryItem615.CommandName = "InsertChartPieExploded2D";
            spreadsheetCommandGalleryItem615.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image421")));
            spreadsheetCommandGalleryItemGroup141.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem614,
            spreadsheetCommandGalleryItem615});
            spreadsheetCommandGalleryItemGroup142.CommandName = "InsertChartPie3DCommandGroup";
            spreadsheetCommandGalleryItem616.CommandName = "InsertChartPie3D";
            spreadsheetCommandGalleryItem616.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image422")));
            spreadsheetCommandGalleryItem617.CommandName = "InsertChartPieExploded3D";
            spreadsheetCommandGalleryItem617.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image423")));
            spreadsheetCommandGalleryItemGroup142.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem616,
            spreadsheetCommandGalleryItem617});
            spreadsheetCommandGalleryItemGroup143.CommandName = "InsertChartDoughnut2DCommandGroup";
            spreadsheetCommandGalleryItem618.CommandName = "InsertChartDoughnut2D";
            spreadsheetCommandGalleryItem618.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image424")));
            spreadsheetCommandGalleryItem619.CommandName = "InsertChartDoughnutExploded2D";
            spreadsheetCommandGalleryItem619.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image425")));
            spreadsheetCommandGalleryItemGroup143.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem618,
            spreadsheetCommandGalleryItem619});
            this.commandBarGalleryDropDown8.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup141,
            spreadsheetCommandGalleryItemGroup142,
            spreadsheetCommandGalleryItemGroup143});
            this.commandBarGalleryDropDown8.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown8.Manager = null;
            this.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8";
            // 
            // commandBarGalleryDropDown9
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown9.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup144.CommandName = "InsertChartBar2DCommandGroup";
            spreadsheetCommandGalleryItem620.CommandName = "InsertChartBarClustered2D";
            spreadsheetCommandGalleryItem620.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image426")));
            spreadsheetCommandGalleryItem621.CommandName = "InsertChartBarStacked2D";
            spreadsheetCommandGalleryItem621.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image427")));
            spreadsheetCommandGalleryItem622.CommandName = "InsertChartBarPercentStacked2D";
            spreadsheetCommandGalleryItem622.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image428")));
            spreadsheetCommandGalleryItemGroup144.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem620,
            spreadsheetCommandGalleryItem621,
            spreadsheetCommandGalleryItem622});
            spreadsheetCommandGalleryItemGroup145.CommandName = "InsertChartBar3DCommandGroup";
            spreadsheetCommandGalleryItem623.CommandName = "InsertChartBarClustered3D";
            spreadsheetCommandGalleryItem623.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image429")));
            spreadsheetCommandGalleryItem624.CommandName = "InsertChartBarStacked3D";
            spreadsheetCommandGalleryItem624.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image430")));
            spreadsheetCommandGalleryItem625.CommandName = "InsertChartBarPercentStacked3D";
            spreadsheetCommandGalleryItem625.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image431")));
            spreadsheetCommandGalleryItemGroup145.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem623,
            spreadsheetCommandGalleryItem624,
            spreadsheetCommandGalleryItem625});
            spreadsheetCommandGalleryItemGroup146.CommandName = "InsertChartHorizontalCylinderCommandGroup";
            spreadsheetCommandGalleryItem626.CommandName = "InsertChartHorizontalCylinderClustered";
            spreadsheetCommandGalleryItem626.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image432")));
            spreadsheetCommandGalleryItem627.CommandName = "InsertChartHorizontalCylinderStacked";
            spreadsheetCommandGalleryItem627.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image433")));
            spreadsheetCommandGalleryItem628.CommandName = "InsertChartHorizontalCylinderPercentStacked";
            spreadsheetCommandGalleryItem628.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image434")));
            spreadsheetCommandGalleryItemGroup146.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem626,
            spreadsheetCommandGalleryItem627,
            spreadsheetCommandGalleryItem628});
            spreadsheetCommandGalleryItemGroup147.CommandName = "InsertChartHorizontalConeCommandGroup";
            spreadsheetCommandGalleryItem629.CommandName = "InsertChartHorizontalConeClustered";
            spreadsheetCommandGalleryItem629.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image435")));
            spreadsheetCommandGalleryItem630.CommandName = "InsertChartHorizontalConeStacked";
            spreadsheetCommandGalleryItem630.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image436")));
            spreadsheetCommandGalleryItem631.CommandName = "InsertChartHorizontalConePercentStacked";
            spreadsheetCommandGalleryItem631.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image437")));
            spreadsheetCommandGalleryItemGroup147.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem629,
            spreadsheetCommandGalleryItem630,
            spreadsheetCommandGalleryItem631});
            spreadsheetCommandGalleryItemGroup148.CommandName = "InsertChartHorizontalPyramidCommandGroup";
            spreadsheetCommandGalleryItem632.CommandName = "InsertChartHorizontalPyramidClustered";
            spreadsheetCommandGalleryItem632.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image438")));
            spreadsheetCommandGalleryItem633.CommandName = "InsertChartHorizontalPyramidStacked";
            spreadsheetCommandGalleryItem633.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image439")));
            spreadsheetCommandGalleryItem634.CommandName = "InsertChartHorizontalPyramidPercentStacked";
            spreadsheetCommandGalleryItem634.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image440")));
            spreadsheetCommandGalleryItemGroup148.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem632,
            spreadsheetCommandGalleryItem633,
            spreadsheetCommandGalleryItem634});
            this.commandBarGalleryDropDown9.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup144,
            spreadsheetCommandGalleryItemGroup145,
            spreadsheetCommandGalleryItemGroup146,
            spreadsheetCommandGalleryItemGroup147,
            spreadsheetCommandGalleryItemGroup148});
            this.commandBarGalleryDropDown9.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown9.Manager = null;
            this.commandBarGalleryDropDown9.Name = "commandBarGalleryDropDown9";
            // 
            // commandBarGalleryDropDown10
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown10.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup149.CommandName = "InsertChartArea2DCommandGroup";
            spreadsheetCommandGalleryItem635.CommandName = "InsertChartArea";
            spreadsheetCommandGalleryItem635.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image441")));
            spreadsheetCommandGalleryItem636.CommandName = "InsertChartStackedArea";
            spreadsheetCommandGalleryItem636.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image442")));
            spreadsheetCommandGalleryItem637.CommandName = "InsertChartPercentStackedArea";
            spreadsheetCommandGalleryItem637.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image443")));
            spreadsheetCommandGalleryItemGroup149.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem635,
            spreadsheetCommandGalleryItem636,
            spreadsheetCommandGalleryItem637});
            spreadsheetCommandGalleryItemGroup150.CommandName = "InsertChartArea3DCommandGroup";
            spreadsheetCommandGalleryItem638.CommandName = "InsertChartArea3D";
            spreadsheetCommandGalleryItem638.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image444")));
            spreadsheetCommandGalleryItem639.CommandName = "InsertChartStackedArea3D";
            spreadsheetCommandGalleryItem639.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image445")));
            spreadsheetCommandGalleryItem640.CommandName = "InsertChartPercentStackedArea3D";
            spreadsheetCommandGalleryItem640.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image446")));
            spreadsheetCommandGalleryItemGroup150.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem638,
            spreadsheetCommandGalleryItem639,
            spreadsheetCommandGalleryItem640});
            this.commandBarGalleryDropDown10.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup149,
            spreadsheetCommandGalleryItemGroup150});
            this.commandBarGalleryDropDown10.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown10.Manager = null;
            this.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10";
            // 
            // commandBarGalleryDropDown11
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown11.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup151.CommandName = "InsertChartScatterCommandGroup";
            spreadsheetCommandGalleryItem641.CommandName = "InsertChartScatterMarkers";
            spreadsheetCommandGalleryItem641.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image447")));
            spreadsheetCommandGalleryItem642.CommandName = "InsertChartScatterSmoothLinesAndMarkers";
            spreadsheetCommandGalleryItem642.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image448")));
            spreadsheetCommandGalleryItem643.CommandName = "InsertChartScatterSmoothLines";
            spreadsheetCommandGalleryItem643.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image449")));
            spreadsheetCommandGalleryItem644.CommandName = "InsertChartScatterLinesAndMarkers";
            spreadsheetCommandGalleryItem644.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image450")));
            spreadsheetCommandGalleryItem645.CommandName = "InsertChartScatterLines";
            spreadsheetCommandGalleryItem645.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image451")));
            spreadsheetCommandGalleryItemGroup151.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem641,
            spreadsheetCommandGalleryItem642,
            spreadsheetCommandGalleryItem643,
            spreadsheetCommandGalleryItem644,
            spreadsheetCommandGalleryItem645});
            spreadsheetCommandGalleryItemGroup152.CommandName = "InsertChartBubbleCommandGroup";
            spreadsheetCommandGalleryItem646.CommandName = "InsertChartBubble";
            spreadsheetCommandGalleryItem646.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image452")));
            spreadsheetCommandGalleryItem647.CommandName = "InsertChartBubble3D";
            spreadsheetCommandGalleryItem647.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image453")));
            spreadsheetCommandGalleryItemGroup152.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem646,
            spreadsheetCommandGalleryItem647});
            this.commandBarGalleryDropDown11.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup151,
            spreadsheetCommandGalleryItemGroup152});
            this.commandBarGalleryDropDown11.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown11.Manager = null;
            this.commandBarGalleryDropDown11.Name = "commandBarGalleryDropDown11";
            // 
            // commandBarGalleryDropDown12
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown12.Gallery.AllowFilter = false;
            spreadsheetCommandGalleryItemGroup153.CommandName = "InsertChartStockCommandGroup";
            spreadsheetCommandGalleryItem648.CommandName = "InsertChartStockHighLowClose";
            spreadsheetCommandGalleryItem648.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image454")));
            spreadsheetCommandGalleryItem649.CommandName = "InsertChartStockOpenHighLowClose";
            spreadsheetCommandGalleryItem649.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image455")));
            spreadsheetCommandGalleryItemGroup153.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem648,
            spreadsheetCommandGalleryItem649});
            spreadsheetCommandGalleryItemGroup154.CommandName = "InsertChartRadarCommandGroup";
            spreadsheetCommandGalleryItem650.CommandName = "InsertChartRadar";
            spreadsheetCommandGalleryItem650.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image456")));
            spreadsheetCommandGalleryItem651.CommandName = "InsertChartRadarWithMarkers";
            spreadsheetCommandGalleryItem651.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image457")));
            spreadsheetCommandGalleryItem652.CommandName = "InsertChartRadarFilled";
            spreadsheetCommandGalleryItem652.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image458")));
            spreadsheetCommandGalleryItemGroup154.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem650,
            spreadsheetCommandGalleryItem651,
            spreadsheetCommandGalleryItem652});
            this.commandBarGalleryDropDown12.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup153,
            spreadsheetCommandGalleryItemGroup154});
            this.commandBarGalleryDropDown12.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown12.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown12.Manager = null;
            this.commandBarGalleryDropDown12.Name = "commandBarGalleryDropDown12";
            // 
            // commandBarGalleryDropDown13
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown13.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown13.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup155.CommandName = "ChartTitleCommandGroup";
            spreadsheetCommandGalleryItem653.CommandName = "ChartTitleNone";
            spreadsheetCommandGalleryItem653.Enabled = false;
            spreadsheetCommandGalleryItem653.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image459")));
            spreadsheetCommandGalleryItem654.CommandName = "ChartTitleCenteredOverlay";
            spreadsheetCommandGalleryItem654.Enabled = false;
            spreadsheetCommandGalleryItem654.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image460")));
            spreadsheetCommandGalleryItem655.CommandName = "ChartTitleAbove";
            spreadsheetCommandGalleryItem655.Enabled = false;
            spreadsheetCommandGalleryItem655.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image461")));
            spreadsheetCommandGalleryItemGroup155.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem653,
            spreadsheetCommandGalleryItem654,
            spreadsheetCommandGalleryItem655});
            this.commandBarGalleryDropDown13.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup155});
            this.commandBarGalleryDropDown13.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown13.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown13.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown13.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown13.Manager = null;
            this.commandBarGalleryDropDown13.Name = "commandBarGalleryDropDown13";
            // 
            // commandBarGalleryDropDown14
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown14.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown14.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup156.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem656.CommandName = "ChartPrimaryHorizontalAxisTitleNone";
            spreadsheetCommandGalleryItem656.Enabled = false;
            spreadsheetCommandGalleryItem656.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image462")));
            spreadsheetCommandGalleryItem657.CommandName = "ChartPrimaryHorizontalAxisTitleBelow";
            spreadsheetCommandGalleryItem657.Enabled = false;
            spreadsheetCommandGalleryItem657.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image463")));
            spreadsheetCommandGalleryItemGroup156.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem656,
            spreadsheetCommandGalleryItem657});
            this.commandBarGalleryDropDown14.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup156});
            this.commandBarGalleryDropDown14.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown14.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown14.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown14.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown14.Manager = null;
            this.commandBarGalleryDropDown14.Name = "commandBarGalleryDropDown14";
            // 
            // commandBarGalleryDropDown15
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown15.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown15.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup157.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup";
            spreadsheetCommandGalleryItem658.CommandName = "ChartPrimaryVerticalAxisTitleNone";
            spreadsheetCommandGalleryItem658.Enabled = false;
            spreadsheetCommandGalleryItem658.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image464")));
            spreadsheetCommandGalleryItem659.CommandName = "ChartPrimaryVerticalAxisTitleRotated";
            spreadsheetCommandGalleryItem659.Enabled = false;
            spreadsheetCommandGalleryItem659.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image465")));
            spreadsheetCommandGalleryItemGroup157.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem658,
            spreadsheetCommandGalleryItem659});
            this.commandBarGalleryDropDown15.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup157});
            this.commandBarGalleryDropDown15.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown15.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown15.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown15.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown15.Manager = null;
            this.commandBarGalleryDropDown15.Name = "commandBarGalleryDropDown15";
            // 
            // commandBarGalleryDropDown16
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown16.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown16.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup158.CommandName = "ChartLegendCommandGroup";
            spreadsheetCommandGalleryItem662.CommandName = "ChartLegendNone";
            spreadsheetCommandGalleryItem662.Enabled = false;
            spreadsheetCommandGalleryItem662.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image468")));
            spreadsheetCommandGalleryItem663.CommandName = "ChartLegendAtRight";
            spreadsheetCommandGalleryItem663.Enabled = false;
            spreadsheetCommandGalleryItem663.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image469")));
            spreadsheetCommandGalleryItem664.CommandName = "ChartLegendAtTop";
            spreadsheetCommandGalleryItem664.Enabled = false;
            spreadsheetCommandGalleryItem664.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image470")));
            spreadsheetCommandGalleryItem665.CommandName = "ChartLegendAtLeft";
            spreadsheetCommandGalleryItem665.Enabled = false;
            spreadsheetCommandGalleryItem665.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image471")));
            spreadsheetCommandGalleryItem666.CommandName = "ChartLegendAtBottom";
            spreadsheetCommandGalleryItem666.Enabled = false;
            spreadsheetCommandGalleryItem666.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image472")));
            spreadsheetCommandGalleryItem667.CommandName = "ChartLegendOverlayAtRight";
            spreadsheetCommandGalleryItem667.Enabled = false;
            spreadsheetCommandGalleryItem667.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image473")));
            spreadsheetCommandGalleryItem668.CommandName = "ChartLegendOverlayAtLeft";
            spreadsheetCommandGalleryItem668.Enabled = false;
            spreadsheetCommandGalleryItem668.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image474")));
            spreadsheetCommandGalleryItemGroup158.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem662,
            spreadsheetCommandGalleryItem663,
            spreadsheetCommandGalleryItem664,
            spreadsheetCommandGalleryItem665,
            spreadsheetCommandGalleryItem666,
            spreadsheetCommandGalleryItem667,
            spreadsheetCommandGalleryItem668});
            this.commandBarGalleryDropDown16.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup158});
            this.commandBarGalleryDropDown16.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown16.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown16.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown16.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown16.Manager = null;
            this.commandBarGalleryDropDown16.Name = "commandBarGalleryDropDown16";
            // 
            // commandBarGalleryDropDown17
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown17.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown17.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup159.CommandName = "ChartDataLabelsCommandGroup";
            spreadsheetCommandGalleryItem669.CommandName = "ChartDataLabelsNone";
            spreadsheetCommandGalleryItem669.Enabled = false;
            spreadsheetCommandGalleryItem669.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image475")));
            spreadsheetCommandGalleryItem670.CommandName = "ChartDataLabelsDefault";
            spreadsheetCommandGalleryItem670.Enabled = false;
            spreadsheetCommandGalleryItem670.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image476")));
            spreadsheetCommandGalleryItem671.CommandName = "ChartDataLabelsCenter";
            spreadsheetCommandGalleryItem671.Enabled = false;
            spreadsheetCommandGalleryItem671.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image477")));
            spreadsheetCommandGalleryItem672.CommandName = "ChartDataLabelsInsideEnd";
            spreadsheetCommandGalleryItem672.Enabled = false;
            spreadsheetCommandGalleryItem672.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image478")));
            spreadsheetCommandGalleryItem673.CommandName = "ChartDataLabelsInsideBase";
            spreadsheetCommandGalleryItem673.Enabled = false;
            spreadsheetCommandGalleryItem673.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image479")));
            spreadsheetCommandGalleryItem674.CommandName = "ChartDataLabelsOutsideEnd";
            spreadsheetCommandGalleryItem674.Enabled = false;
            spreadsheetCommandGalleryItem674.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image480")));
            spreadsheetCommandGalleryItem675.CommandName = "ChartDataLabelsBestFit";
            spreadsheetCommandGalleryItem675.Enabled = false;
            spreadsheetCommandGalleryItem675.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image481")));
            spreadsheetCommandGalleryItem676.CommandName = "ChartDataLabelsLeft";
            spreadsheetCommandGalleryItem676.Enabled = false;
            spreadsheetCommandGalleryItem676.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image482")));
            spreadsheetCommandGalleryItem677.CommandName = "ChartDataLabelsRight";
            spreadsheetCommandGalleryItem677.Enabled = false;
            spreadsheetCommandGalleryItem677.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image483")));
            spreadsheetCommandGalleryItem678.CommandName = "ChartDataLabelsAbove";
            spreadsheetCommandGalleryItem678.Enabled = false;
            spreadsheetCommandGalleryItem678.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image484")));
            spreadsheetCommandGalleryItem679.CommandName = "ChartDataLabelsBelow";
            spreadsheetCommandGalleryItem679.Enabled = false;
            spreadsheetCommandGalleryItem679.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image485")));
            spreadsheetCommandGalleryItemGroup159.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem669,
            spreadsheetCommandGalleryItem670,
            spreadsheetCommandGalleryItem671,
            spreadsheetCommandGalleryItem672,
            spreadsheetCommandGalleryItem673,
            spreadsheetCommandGalleryItem674,
            spreadsheetCommandGalleryItem675,
            spreadsheetCommandGalleryItem676,
            spreadsheetCommandGalleryItem677,
            spreadsheetCommandGalleryItem678,
            spreadsheetCommandGalleryItem679});
            this.commandBarGalleryDropDown17.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup159});
            this.commandBarGalleryDropDown17.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown17.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown17.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown17.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown17.Manager = null;
            this.commandBarGalleryDropDown17.Name = "commandBarGalleryDropDown17";
            // 
            // commandBarGalleryDropDown18
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown18.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown18.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup160.CommandName = "ChartPrimaryHorizontalAxisCommandGroup";
            spreadsheetCommandGalleryItem680.CommandName = "ChartHidePrimaryHorizontalAxis";
            spreadsheetCommandGalleryItem680.Enabled = false;
            spreadsheetCommandGalleryItem680.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image486")));
            spreadsheetCommandGalleryItem681.CommandName = "ChartPrimaryHorizontalAxisLeftToRight";
            spreadsheetCommandGalleryItem681.Enabled = false;
            spreadsheetCommandGalleryItem681.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image487")));
            spreadsheetCommandGalleryItem682.CommandName = "ChartPrimaryHorizontalAxisHideLabels";
            spreadsheetCommandGalleryItem682.Enabled = false;
            spreadsheetCommandGalleryItem682.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image488")));
            spreadsheetCommandGalleryItem683.CommandName = "ChartPrimaryHorizontalAxisRightToLeft";
            spreadsheetCommandGalleryItem683.Enabled = false;
            spreadsheetCommandGalleryItem683.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image489")));
            spreadsheetCommandGalleryItem684.CommandName = "ChartPrimaryHorizontalAxisDefault";
            spreadsheetCommandGalleryItem684.Enabled = false;
            spreadsheetCommandGalleryItem684.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image490")));
            spreadsheetCommandGalleryItem685.CommandName = "ChartPrimaryHorizontalAxisScaleThousands";
            spreadsheetCommandGalleryItem685.Enabled = false;
            spreadsheetCommandGalleryItem685.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image491")));
            spreadsheetCommandGalleryItem686.CommandName = "ChartPrimaryHorizontalAxisScaleMillions";
            spreadsheetCommandGalleryItem686.Enabled = false;
            spreadsheetCommandGalleryItem686.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image492")));
            spreadsheetCommandGalleryItem687.CommandName = "ChartPrimaryHorizontalAxisScaleBillions";
            spreadsheetCommandGalleryItem687.Enabled = false;
            spreadsheetCommandGalleryItem687.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image493")));
            spreadsheetCommandGalleryItem688.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm";
            spreadsheetCommandGalleryItem688.Enabled = false;
            spreadsheetCommandGalleryItem688.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image494")));
            spreadsheetCommandGalleryItemGroup160.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem680,
            spreadsheetCommandGalleryItem681,
            spreadsheetCommandGalleryItem682,
            spreadsheetCommandGalleryItem683,
            spreadsheetCommandGalleryItem684,
            spreadsheetCommandGalleryItem685,
            spreadsheetCommandGalleryItem686,
            spreadsheetCommandGalleryItem687,
            spreadsheetCommandGalleryItem688});
            this.commandBarGalleryDropDown18.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup160});
            this.commandBarGalleryDropDown18.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown18.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown18.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown18.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown18.Manager = null;
            this.commandBarGalleryDropDown18.Name = "commandBarGalleryDropDown18";
            // 
            // commandBarGalleryDropDown19
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown19.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown19.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup161.CommandName = "ChartPrimaryVerticalAxisCommandGroup";
            spreadsheetCommandGalleryItem689.CommandName = "ChartHidePrimaryVerticalAxis";
            spreadsheetCommandGalleryItem689.Enabled = false;
            spreadsheetCommandGalleryItem689.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image495")));
            spreadsheetCommandGalleryItem690.CommandName = "ChartPrimaryVerticalAxisLeftToRight";
            spreadsheetCommandGalleryItem690.Enabled = false;
            spreadsheetCommandGalleryItem690.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image496")));
            spreadsheetCommandGalleryItem691.CommandName = "ChartPrimaryVerticalAxisHideLabels";
            spreadsheetCommandGalleryItem691.Enabled = false;
            spreadsheetCommandGalleryItem691.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image497")));
            spreadsheetCommandGalleryItem692.CommandName = "ChartPrimaryVerticalAxisRightToLeft";
            spreadsheetCommandGalleryItem692.Enabled = false;
            spreadsheetCommandGalleryItem692.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image498")));
            spreadsheetCommandGalleryItem693.CommandName = "ChartPrimaryVerticalAxisDefault";
            spreadsheetCommandGalleryItem693.Enabled = false;
            spreadsheetCommandGalleryItem693.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image499")));
            spreadsheetCommandGalleryItem694.CommandName = "ChartPrimaryVerticalAxisScaleThousands";
            spreadsheetCommandGalleryItem694.Enabled = false;
            spreadsheetCommandGalleryItem694.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image500")));
            spreadsheetCommandGalleryItem695.CommandName = "ChartPrimaryVerticalAxisScaleMillions";
            spreadsheetCommandGalleryItem695.Enabled = false;
            spreadsheetCommandGalleryItem695.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image501")));
            spreadsheetCommandGalleryItem696.CommandName = "ChartPrimaryVerticalAxisScaleBillions";
            spreadsheetCommandGalleryItem696.Enabled = false;
            spreadsheetCommandGalleryItem696.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image502")));
            spreadsheetCommandGalleryItem697.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm";
            spreadsheetCommandGalleryItem697.Enabled = false;
            spreadsheetCommandGalleryItem697.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image503")));
            spreadsheetCommandGalleryItemGroup161.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem689,
            spreadsheetCommandGalleryItem690,
            spreadsheetCommandGalleryItem691,
            spreadsheetCommandGalleryItem692,
            spreadsheetCommandGalleryItem693,
            spreadsheetCommandGalleryItem694,
            spreadsheetCommandGalleryItem695,
            spreadsheetCommandGalleryItem696,
            spreadsheetCommandGalleryItem697});
            this.commandBarGalleryDropDown19.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup161});
            this.commandBarGalleryDropDown19.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown19.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown19.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown19.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown19.Manager = null;
            this.commandBarGalleryDropDown19.Name = "commandBarGalleryDropDown19";
            // 
            // commandBarGalleryDropDown20
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown20.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown20.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup162.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem698.CommandName = "ChartPrimaryHorizontalGridlinesNone";
            spreadsheetCommandGalleryItem698.Enabled = false;
            spreadsheetCommandGalleryItem698.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image504")));
            spreadsheetCommandGalleryItem699.CommandName = "ChartPrimaryHorizontalGridlinesMajor";
            spreadsheetCommandGalleryItem699.Enabled = false;
            spreadsheetCommandGalleryItem699.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image505")));
            spreadsheetCommandGalleryItem700.CommandName = "ChartPrimaryHorizontalGridlinesMinor";
            spreadsheetCommandGalleryItem700.Enabled = false;
            spreadsheetCommandGalleryItem700.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image506")));
            spreadsheetCommandGalleryItem701.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItem701.Enabled = false;
            spreadsheetCommandGalleryItem701.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image507")));
            spreadsheetCommandGalleryItemGroup162.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem698,
            spreadsheetCommandGalleryItem699,
            spreadsheetCommandGalleryItem700,
            spreadsheetCommandGalleryItem701});
            this.commandBarGalleryDropDown20.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup162});
            this.commandBarGalleryDropDown20.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown20.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown20.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown20.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown20.Manager = null;
            this.commandBarGalleryDropDown20.Name = "commandBarGalleryDropDown20";
            // 
            // commandBarGalleryDropDown21
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown21.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown21.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup163.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup";
            spreadsheetCommandGalleryItem702.CommandName = "ChartPrimaryVerticalGridlinesNone";
            spreadsheetCommandGalleryItem702.Enabled = false;
            spreadsheetCommandGalleryItem702.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image508")));
            spreadsheetCommandGalleryItem703.CommandName = "ChartPrimaryVerticalGridlinesMajor";
            spreadsheetCommandGalleryItem703.Enabled = false;
            spreadsheetCommandGalleryItem703.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image509")));
            spreadsheetCommandGalleryItem704.CommandName = "ChartPrimaryVerticalGridlinesMinor";
            spreadsheetCommandGalleryItem704.Enabled = false;
            spreadsheetCommandGalleryItem704.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image510")));
            spreadsheetCommandGalleryItem705.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor";
            spreadsheetCommandGalleryItem705.Enabled = false;
            spreadsheetCommandGalleryItem705.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image511")));
            spreadsheetCommandGalleryItemGroup163.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem702,
            spreadsheetCommandGalleryItem703,
            spreadsheetCommandGalleryItem704,
            spreadsheetCommandGalleryItem705});
            this.commandBarGalleryDropDown21.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup163});
            this.commandBarGalleryDropDown21.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown21.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown21.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown21.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown21.Manager = null;
            this.commandBarGalleryDropDown21.Name = "commandBarGalleryDropDown21";
            // 
            // commandBarGalleryDropDown22
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown22.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown22.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup164.CommandName = "ChartLinesCommandGroup";
            spreadsheetCommandGalleryItem706.CommandName = "ChartLinesNone";
            spreadsheetCommandGalleryItem706.Enabled = false;
            spreadsheetCommandGalleryItem706.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image512")));
            spreadsheetCommandGalleryItem707.CommandName = "ChartShowDropLines";
            spreadsheetCommandGalleryItem707.Enabled = false;
            spreadsheetCommandGalleryItem707.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image513")));
            spreadsheetCommandGalleryItem708.CommandName = "ChartShowHighLowLines";
            spreadsheetCommandGalleryItem708.Enabled = false;
            spreadsheetCommandGalleryItem708.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image514")));
            spreadsheetCommandGalleryItem709.CommandName = "ChartShowDropLinesAndHighLowLines";
            spreadsheetCommandGalleryItem709.Enabled = false;
            spreadsheetCommandGalleryItem709.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image515")));
            spreadsheetCommandGalleryItem710.CommandName = "ChartShowSeriesLines";
            spreadsheetCommandGalleryItem710.Enabled = false;
            spreadsheetCommandGalleryItem710.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image516")));
            spreadsheetCommandGalleryItemGroup164.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem706,
            spreadsheetCommandGalleryItem707,
            spreadsheetCommandGalleryItem708,
            spreadsheetCommandGalleryItem709,
            spreadsheetCommandGalleryItem710});
            this.commandBarGalleryDropDown22.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup164});
            this.commandBarGalleryDropDown22.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown22.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown22.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown22.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown22.Manager = null;
            this.commandBarGalleryDropDown22.Name = "commandBarGalleryDropDown22";
            // 
            // commandBarGalleryDropDown23
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown23.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown23.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup165.CommandName = "ChartUpDownBarsCommandGroup";
            spreadsheetCommandGalleryItem711.CommandName = "ChartHideUpDownBars";
            spreadsheetCommandGalleryItem711.Enabled = false;
            spreadsheetCommandGalleryItem711.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image517")));
            spreadsheetCommandGalleryItem712.CommandName = "ChartShowUpDownBars";
            spreadsheetCommandGalleryItem712.Enabled = false;
            spreadsheetCommandGalleryItem712.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image518")));
            spreadsheetCommandGalleryItemGroup165.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem711,
            spreadsheetCommandGalleryItem712});
            this.commandBarGalleryDropDown23.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup165});
            this.commandBarGalleryDropDown23.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown23.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown23.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown23.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown23.Manager = null;
            this.commandBarGalleryDropDown23.Name = "commandBarGalleryDropDown23";
            // 
            // commandBarGalleryDropDown24
            // 
            // 
            // 
            // 
            this.commandBarGalleryDropDown24.Gallery.AllowFilter = false;
            this.commandBarGalleryDropDown24.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            spreadsheetCommandGalleryItemGroup166.CommandName = "ChartErrorBarsCommandGroup";
            spreadsheetCommandGalleryItem713.CommandName = "ChartErrorBarsNone";
            spreadsheetCommandGalleryItem713.Enabled = false;
            spreadsheetCommandGalleryItem713.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image519")));
            spreadsheetCommandGalleryItem714.CommandName = "ChartErrorBarsStandardError";
            spreadsheetCommandGalleryItem714.Enabled = false;
            spreadsheetCommandGalleryItem714.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image520")));
            spreadsheetCommandGalleryItem715.CommandName = "ChartErrorBarsPercentage";
            spreadsheetCommandGalleryItem715.Enabled = false;
            spreadsheetCommandGalleryItem715.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image521")));
            spreadsheetCommandGalleryItem716.CommandName = "ChartErrorBarsStandardDeviation";
            spreadsheetCommandGalleryItem716.Enabled = false;
            spreadsheetCommandGalleryItem716.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image522")));
            spreadsheetCommandGalleryItemGroup166.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            spreadsheetCommandGalleryItem713,
            spreadsheetCommandGalleryItem714,
            spreadsheetCommandGalleryItem715,
            spreadsheetCommandGalleryItem716});
            this.commandBarGalleryDropDown24.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            spreadsheetCommandGalleryItemGroup166});
            this.commandBarGalleryDropDown24.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.commandBarGalleryDropDown24.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft;
            this.commandBarGalleryDropDown24.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
            this.commandBarGalleryDropDown24.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto;
            this.commandBarGalleryDropDown24.Manager = null;
            this.commandBarGalleryDropDown24.Name = "commandBarGalleryDropDown24";
            // 
            // spreadsheetDockManager1
            // 
            this.spreadsheetDockManager1.Form = this;
            this.spreadsheetDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.spreadsheetDockManager1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.fieldListDockPanel1);
            this.panelContainer1.Controls.Add(this.mailMergeParametersDockPanel);
            this.panelContainer1.Controls.Add(this.filteringDockPanel);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.ID = new System.Guid("a9a40f94-dc0f-4f90-b029-4282846c5053");
            this.panelContainer1.Location = new System.Drawing.Point(862, 150);
            this.panelContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.Size = new System.Drawing.Size(200, 255);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // fieldListDockPanel1
            // 
            this.fieldListDockPanel1.Controls.Add(this.fieldListDockPanel1_Container);
            this.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.fieldListDockPanel1.ID = new System.Guid("6b098cf1-bd50-44c1-a93a-38b0a4bce017");
            this.fieldListDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.fieldListDockPanel1.Name = "fieldListDockPanel1";
            this.fieldListDockPanel1.OriginalSize = new System.Drawing.Size(200, 87);
            this.fieldListDockPanel1.Size = new System.Drawing.Size(200, 85);
            this.fieldListDockPanel1.SpreadsheetControl = this.spreadsheetControl1;
            // 
            // fieldListDockPanel1_Container
            // 
            this.fieldListDockPanel1_Container.Location = new System.Drawing.Point(4, 26);
            this.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            this.fieldListDockPanel1_Container.Size = new System.Drawing.Size(193, 55);
            this.fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // mailMergeParametersDockPanel
            // 
            this.mailMergeParametersDockPanel.Controls.Add(this.mailMergeParametersDockPanel1_Container);
            this.mailMergeParametersDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.mailMergeParametersDockPanel.ID = new System.Guid("09c84a14-2284-4751-b3f0-df4853bb164f");
            this.mailMergeParametersDockPanel.Location = new System.Drawing.Point(0, 85);
            this.mailMergeParametersDockPanel.Name = "mailMergeParametersDockPanel";
            this.mailMergeParametersDockPanel.OriginalSize = new System.Drawing.Size(200, 87);
            this.mailMergeParametersDockPanel.Size = new System.Drawing.Size(200, 85);
            this.mailMergeParametersDockPanel.SpreadsheetControl = this.spreadsheetControl1;
            // 
            // mailMergeParametersDockPanel1_Container
            // 
            this.mailMergeParametersDockPanel1_Container.Location = new System.Drawing.Point(4, 26);
            this.mailMergeParametersDockPanel1_Container.Name = "mailMergeParametersDockPanel1_Container";
            this.mailMergeParametersDockPanel1_Container.Size = new System.Drawing.Size(193, 55);
            this.mailMergeParametersDockPanel1_Container.TabIndex = 0;
            // 
            // filteringDockPanel
            // 
            this.filteringDockPanel.Controls.Add(this.dockPanel1_Container);
            this.filteringDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.filteringDockPanel.ID = new System.Guid("3fa0b467-3f8b-40ff-9387-ffbd4a309a03");
            this.filteringDockPanel.Location = new System.Drawing.Point(0, 170);
            this.filteringDockPanel.Name = "filteringDockPanel";
            this.filteringDockPanel.Options.ShowAutoHideButton = false;
            this.filteringDockPanel.Options.ShowCloseButton = false;
            this.filteringDockPanel.Options.ShowMaximizeButton = false;
            this.filteringDockPanel.OriginalSize = new System.Drawing.Size(200, 88);
            this.filteringDockPanel.Size = new System.Drawing.Size(200, 85);
            this.filteringDockPanel.Text = "Filter Templates";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.checkEdit0);
            this.dockPanel1_Container.Controls.Add(this.checkEdit1);
            this.dockPanel1_Container.Controls.Add(this.checkEdit2);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 56);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // checkEdit0
            // 
            this.checkEdit0.EditValue = true;
            this.checkEdit0.Location = new System.Drawing.Point(3, 3);
            this.checkEdit0.Name = "checkEdit0";
            this.checkEdit0.Properties.Caption = "Sales Manager";
            this.checkEdit0.Size = new System.Drawing.Size(174, 20);
            this.checkEdit0.TabIndex = 7;
            this.checkEdit0.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(3, 28);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Inside Sales Coordinator";
            this.checkEdit1.Size = new System.Drawing.Size(174, 20);
            this.checkEdit1.TabIndex = 8;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // checkEdit2
            // 
            this.checkEdit2.EditValue = true;
            this.checkEdit2.Location = new System.Drawing.Point(3, 53);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Sales Representative";
            this.checkEdit2.Size = new System.Drawing.Size(174, 20);
            this.checkEdit2.TabIndex = 9;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit_CheckedChanged);
            // 
            // mailMergeBindingRibbonPageGroup1
            // 
            this.mailMergeBindingRibbonPageGroup1.Name = "mailMergeBindingRibbonPageGroup1";
            this.mailMergeBindingRibbonPageGroup1.Text = "";
            // 
            // spreadsheetFormulaBar1
            // 
            this.spreadsheetFormulaBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spreadsheetFormulaBar1.Location = new System.Drawing.Point(0, 150);
            this.spreadsheetFormulaBar1.MinimumSize = new System.Drawing.Size(0, 24);
            this.spreadsheetFormulaBar1.Name = "spreadsheetFormulaBar1";
            this.spreadsheetFormulaBar1.Size = new System.Drawing.Size(862, 24);
            this.spreadsheetFormulaBar1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetFormulaBar1.TabIndex = 6;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 174);
            this.splitterControl1.MinSize = 20;
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(862, 10);
            this.splitterControl1.TabIndex = 5;
            this.splitterControl1.TabStop = false;
            // 
            // spreadsheetBarController1
            // 
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem15);
            this.spreadsheetBarController1.BarItems.Add(this.changeFontNameItem1);
            this.spreadsheetBarController1.BarItems.Add(this.changeFontSizeItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem18);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem19);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem22);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem23);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem24);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem25);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem26);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem27);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem28);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem29);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem30);
            this.spreadsheetBarController1.BarItems.Add(this.changeBorderLineColorItem1);
            this.spreadsheetBarController1.BarItems.Add(this.changeBorderLineStyleItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem1);
            this.spreadsheetBarController1.BarItems.Add(this.changeCellFillColorItem1);
            this.spreadsheetBarController1.BarItems.Add(this.changeFontColorItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem31);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem32);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem33);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem34);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem35);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem2);
            this.spreadsheetBarController1.BarItems.Add(this.changeNumberFormatItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem36);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem37);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem38);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem39);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem40);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem41);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem42);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem43);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem44);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem45);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem46);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem47);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem48);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem49);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem50);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem51);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem52);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem53);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem54);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem55);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem56);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem57);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem58);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem59);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem60);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem61);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem62);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem7);
            this.spreadsheetBarController1.BarItems.Add(this.galleryFormatAsTableItem1);
            this.spreadsheetBarController1.BarItems.Add(this.galleryChangeStyleItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem63);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem64);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem65);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem66);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem67);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem68);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem69);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem70);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem71);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem72);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem73);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem74);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem75);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem76);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem77);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem78);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem79);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem80);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem81);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem82);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem83);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem84);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem85);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem86);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem87);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem88);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem89);
            this.spreadsheetBarController1.BarItems.Add(this.changeSheetTabColorItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem90);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem91);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem92);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem93);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem94);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem95);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem96);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem97);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem98);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem99);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem100);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem101);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem102);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem103);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem104);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem105);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem106);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem107);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem108);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem109);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem110);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem15);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem111);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem112);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem113);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem114);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem115);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem116);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem117);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem118);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem119);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem120);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem11);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem12);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem121);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem122);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem15);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem123);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem18);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem19);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem18);
            this.spreadsheetBarController1.BarItems.Add(this.pageSetupPaperKindItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem124);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem125);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem126);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem19);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem127);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem22);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem23);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem128);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem129);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem130);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem131);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem22);
            this.spreadsheetBarController1.BarItems.Add(this.functionsFinancialItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsLogicalItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsTextItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsDateAndTimeItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsLookupAndReferenceItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsMathAndTrigonometryItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsStatisticalItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsEngineeringItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsInformationItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsCompatibilityItem1);
            this.spreadsheetBarController1.BarItems.Add(this.functionsWebItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem23);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem132);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem133);
            this.spreadsheetBarController1.BarItems.Add(this.definedNameListItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem134);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem24);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem25);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem26);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem24);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem135);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem136);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem137);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem138);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem139);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem25);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem140);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem141);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem26);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem142);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem143);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem27);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem144);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem145);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem146);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem147);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem148);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem149);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem150);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem151);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem152);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem153);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem154);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem155);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem156);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem157);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem158);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem159);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem160);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem161);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem162);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem28);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem163);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem164);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem165);
            this.spreadsheetBarController1.BarItems.Add(this.galleryChartLayoutItem1);
            this.spreadsheetBarController1.BarItems.Add(this.galleryChartStyleItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem166);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem13);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem14);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem29);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem15);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem16);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem30);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem17);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem18);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem19);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem31);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem20);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem21);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem22);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem23);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonGalleryDropDownItem24);
            this.spreadsheetBarController1.BarItems.Add(this.renameTableItemCaption1);
            this.spreadsheetBarController1.BarItems.Add(this.renameTableItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem27);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem28);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem29);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem30);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem31);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem32);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem33);
            this.spreadsheetBarController1.BarItems.Add(this.galleryTableStylesItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem167);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem168);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem169);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem170);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem171);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem172);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem173);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem174);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem175);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem32);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem176);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem177);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem178);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem33);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem179);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem180);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem181);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem34);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem182);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem183);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem184);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem185);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem186);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem35);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem34);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem35);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem36);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem187);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem188);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem189);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem36);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem190);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem191);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem192);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem193);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem37);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem194);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem195);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem196);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem197);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem198);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem38);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem199);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem200);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem39);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem37);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem38);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem39);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem40);
            this.spreadsheetBarController1.BarItems.Add(this.galleryPivotStylesItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem201);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem202);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem203);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem40);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem204);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem205);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem206);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem41);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem41);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem42);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem43);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem44);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem45);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem42);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem207);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem208);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem209);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem210);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem211);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarSubItem43);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem212);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem213);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem214);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem215);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem216);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem217);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarCheckItem46);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem218);
            this.spreadsheetBarController1.BarItems.Add(this.endModeInfoStaticItem1);
            this.spreadsheetBarController1.BarItems.Add(this.averageInfoStaticItem1);
            this.spreadsheetBarController1.BarItems.Add(this.countInfoStaticItem1);
            this.spreadsheetBarController1.BarItems.Add(this.numericalCountInfoStaticItem1);
            this.spreadsheetBarController1.BarItems.Add(this.minInfoStaticItem1);
            this.spreadsheetBarController1.BarItems.Add(this.maxInfoStaticItem1);
            this.spreadsheetBarController1.BarItems.Add(this.sumInfoStaticItem1);
            this.spreadsheetBarController1.BarItems.Add(this.zoomEditItem1);
            this.spreadsheetBarController1.BarItems.Add(this.showZoomButtonItem1);
            this.spreadsheetBarController1.BarItems.Add(this.progressBarItem1);
            this.spreadsheetBarController1.Control = this.spreadsheetControl1;
            // 
            // MailMergeModuleBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.spreadsheetFormulaBar1);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Name = "MailMergeModuleBase";
            this.Size = new System.Drawing.Size(1062, 432);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpreadsheetFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown94)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarGalleryDropDown24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetDockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.fieldListDockPanel1.ResumeLayout(false);
            this.mailMergeParametersDockPanel.ResumeLayout(false);
            this.filteringDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit0.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.ComponentModel.IContainer components;
        private SpreadsheetDockManager spreadsheetDockManager1;
        private FieldListDockPanel fieldListDockPanel1;
        private XtraBars.Docking.ControlContainer fieldListDockPanel1_Container;
        private DockPanel panelContainer1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown2;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown3;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown4;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown5;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown6;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown7;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown8;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown9;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown10;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown11;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown12;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown13;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown14;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown15;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown16;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown17;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown18;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown19;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown20;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown21;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown22;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown23;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown24;			
        private MailMergeParametersDockPanel mailMergeParametersDockPanel;
        private ControlContainer mailMergeParametersDockPanel1_Container;
        private DockPanel filteringDockPanel;
        private ControlContainer dockPanel1_Container;
        private CheckEdit checkEdit0;
        private CheckEdit checkEdit1;
        private CheckEdit checkEdit2;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown25;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown26;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown27;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown28;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown29;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown30;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown31;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown32;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown33;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown34;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown35;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown36;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown37;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown38;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown39;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown40;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown41;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown42;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown43;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown44;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown45;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown46;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown47;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown48;
        private UI.MailMergeBindingRibbonPageGroup mailMergeBindingRibbonPageGroup1;
        private SpreadsheetControl spreadsheetControl1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown49;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown50;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown51;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown52;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown53;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown54;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown55;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown56;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown57;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown58;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown59;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown60;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown61;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown62;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown63;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown64;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown65;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown66;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown67;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown68;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown69;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown70;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown71;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown72;
        private SplitterControl splitterControl1;
        private SpreadsheetFormulaBar spreadsheetFormulaBar1;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem2;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem3;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem4;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem5;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem6;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem7;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem8;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem9;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem10;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem11;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem12;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem13;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem14;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem15;
        private XtraBars.BarButtonGroup barButtonGroup1;
        private UI.ChangeFontNameItem changeFontNameItem1;
        private XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private UI.ChangeFontSizeItem changeFontSizeItem1;
        private Design.RepositoryItemSpreadsheetFontSizeEdit repositoryItemSpreadsheetFontSizeEdit1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem16;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem17;
        private XtraBars.BarButtonGroup barButtonGroup2;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem1;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem2;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem3;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem4;
        private XtraBars.BarButtonGroup barButtonGroup3;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem18;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem19;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem20;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem21;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem22;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem23;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem24;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem25;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem26;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem27;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem28;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem29;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem30;
        private UI.ChangeBorderLineColorItem changeBorderLineColorItem1;
        private UI.ChangeBorderLineStyleItem changeBorderLineStyleItem1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown73;
        private XtraBars.BarButtonGroup barButtonGroup4;
        private UI.ChangeCellFillColorItem changeCellFillColorItem1;
        private UI.ChangeFontColorItem changeFontColorItem1;
        private XtraBars.BarButtonGroup barButtonGroup5;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem5;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem6;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem7;
        private XtraBars.BarButtonGroup barButtonGroup6;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem8;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem9;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem10;
        private XtraBars.BarButtonGroup barButtonGroup7;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem31;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem32;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem11;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem2;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem12;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem33;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem34;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem35;
        private XtraBars.BarButtonGroup barButtonGroup8;
        private UI.ChangeNumberFormatItem changeNumberFormatItem1;
        private XtraEditors.Repository.RepositoryItemPopupGalleryEdit repositoryItemPopupGalleryEdit1;
        private XtraBars.BarButtonGroup barButtonGroup9;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem3;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem36;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem37;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem38;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem39;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem40;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem41;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem42;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem43;
        private XtraBars.BarButtonGroup barButtonGroup10;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem44;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem45;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem7;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem4;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem46;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem47;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem48;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem49;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem50;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem51;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem52;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem5;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem53;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem54;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem55;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem56;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem57;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem58;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown74;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem2;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown75;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem3;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown76;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem59;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem6;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem60;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem61;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem62;
        private UI.GalleryFormatAsTableItem galleryFormatAsTableItem1;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown77;
        private UI.GalleryChangeStyleItem galleryChangeStyleItem1;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem8;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem63;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem64;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem65;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem66;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem67;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem68;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem69;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem70;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem9;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem71;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem72;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem73;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem74;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem75;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem76;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem11;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem77;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem78;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem79;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem80;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem81;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem10;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem82;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem83;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem84;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem85;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem86;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem87;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem88;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem89;
        private UI.ChangeSheetTabColorItem changeSheetTabColorItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem90;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem13;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem91;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem12;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem92;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem93;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem94;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem95;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem96;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem13;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem97;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem98;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem99;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem100;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem14;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem101;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem102;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem103;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem104;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem105;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem106;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem15;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem107;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem108;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem14;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem109;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem110;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem16;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem111;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem112;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem113;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem114;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem115;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem116;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem117;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem118;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem119;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem120;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem4;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown78;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem5;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown79;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem6;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown80;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem7;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown81;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem8;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown82;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem9;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown83;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem10;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown84;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem11;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown85;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem12;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown86;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem121;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem122;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem17;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem15;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem16;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem17;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem123;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem18;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem18;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem19;
        private UI.PageSetupPaperKindItem pageSetupPaperKindItem1;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem19;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem124;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem125;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem126;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem127;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem20;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem21;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem22;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem23;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem20;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem128;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem129;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem21;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem130;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem131;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem22;
        private UI.FunctionsFinancialItem functionsFinancialItem1;
        private UI.FunctionsLogicalItem functionsLogicalItem1;
        private UI.FunctionsTextItem functionsTextItem1;
        private UI.FunctionsDateAndTimeItem functionsDateAndTimeItem1;
        private UI.FunctionsLookupAndReferenceItem functionsLookupAndReferenceItem1;
        private UI.FunctionsMathAndTrigonometryItem functionsMathAndTrigonometryItem1;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem23;
        private UI.FunctionsStatisticalItem functionsStatisticalItem1;
        private UI.FunctionsEngineeringItem functionsEngineeringItem1;
        private UI.FunctionsInformationItem functionsInformationItem1;
        private UI.FunctionsCompatibilityItem functionsCompatibilityItem1;
        private UI.FunctionsWebItem functionsWebItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem132;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem133;
        private UI.DefinedNameListItem definedNameListItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem134;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem24;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem24;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem25;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem26;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem135;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem136;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem25;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem137;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem138;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem139;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem26;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem140;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem141;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem27;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem142;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem143;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem144;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem145;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem146;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem147;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem148;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem149;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem150;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem151;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem152;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem153;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem154;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem155;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem156;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem157;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem158;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem28;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem159;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem160;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem161;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem162;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem163;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem164;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem165;
        private UI.GalleryChartLayoutItem galleryChartLayoutItem1;
        private UI.GalleryChartStyleItem galleryChartStyleItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem166;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem29;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem13;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown87;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem14;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown88;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem30;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem15;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown89;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem16;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown90;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem17;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown91;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem31;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem18;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown92;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem19;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown93;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem20;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown94;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem21;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown95;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem22;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown96;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem23;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown97;
        private UI.SpreadsheetCommandBarButtonGalleryDropDownItem spreadsheetCommandBarButtonGalleryDropDownItem24;
        private XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown98;
        private UI.RenameTableItemCaption renameTableItemCaption1;
        private UI.RenameTableItem renameTableItem1;
        private XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem27;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem28;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem29;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem30;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem31;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem32;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem33;
        private UI.GalleryTableStylesItem galleryTableStylesItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem167;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem168;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem169;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem170;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem171;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem172;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem173;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem32;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem174;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem175;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem176;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem33;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem177;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem178;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem34;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem179;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem180;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem181;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem182;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem35;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem183;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem184;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem185;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem186;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem34;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem35;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem36;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem36;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem187;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem188;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem189;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem37;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem190;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem191;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem192;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem193;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem38;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem194;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem195;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem196;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem197;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem198;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem39;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem199;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem200;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem37;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem38;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem39;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem40;
        private UI.GalleryPivotStylesItem galleryPivotStylesItem1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem201;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem40;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem202;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem203;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem41;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem204;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem205;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem206;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem41;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem42;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem43;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem42;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem44;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem45;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem207;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem208;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem209;
        private UI.SpreadsheetCommandBarSubItem spreadsheetCommandBarSubItem43;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem210;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem211;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem212;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem213;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem214;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem215;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem216;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem217;
        private UI.SpreadsheetCommandBarCheckItem spreadsheetCommandBarCheckItem46;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem218;
        private UI.EndModeInfoStaticItem endModeInfoStaticItem1;
        private UI.AverageInfoStaticItem averageInfoStaticItem1;
        private UI.CountInfoStaticItem countInfoStaticItem1;
        private UI.NumericalCountInfoStaticItem numericalCountInfoStaticItem1;
        private UI.MinInfoStaticItem minInfoStaticItem1;
        private UI.MaxInfoStaticItem maxInfoStaticItem1;
        private UI.SumInfoStaticItem sumInfoStaticItem1;
        private UI.ZoomEditItem zoomEditItem1;
        private XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private UI.ShowZoomButtonItem showZoomButtonItem1;
        private UI.ChartToolsRibbonPageCategory chartToolsRibbonPageCategory1;
        private UI.ChartsDesignRibbonPage chartsDesignRibbonPage1;
        private UI.ChartsDesignTypeRibbonPageGroup chartsDesignTypeRibbonPageGroup1;
        private UI.ChartsDesignDataRibbonPageGroup chartsDesignDataRibbonPageGroup1;
        private UI.ChartsDesignLayoutsRibbonPageGroup chartsDesignLayoutsRibbonPageGroup1;
        private UI.ChartsDesignStylesRibbonPageGroup chartsDesignStylesRibbonPageGroup1;
        private UI.ChartsDesignLocationRibbonPageGroup chartsDesignLocationRibbonPageGroup1;
        private UI.ChartsLayoutRibbonPage chartsLayoutRibbonPage1;
        private UI.ChartsLayoutAxesRibbonPageGroup chartsLayoutAxesRibbonPageGroup1;
        private UI.ChartsLayoutLabelsRibbonPageGroup chartsLayoutLabelsRibbonPageGroup1;
        private UI.ChartsLayoutAnalysisRibbonPageGroup chartsLayoutAnalysisRibbonPageGroup1;
        private UI.ChartsFormatRibbonPage chartsFormatRibbonPage1;
        private UI.ChartsFormatArrangeRibbonPageGroup chartsFormatArrangeRibbonPageGroup1;
        private UI.TableToolsRibbonPageCategory tableToolsRibbonPageCategory1;
        private UI.TableToolsDesignRibbonPage tableToolsDesignRibbonPage1;
        private UI.TablePropertiesRibbonPageGroup tablePropertiesRibbonPageGroup1;
        private UI.TableToolsRibbonPageGroup tableToolsRibbonPageGroup1;
        private UI.TableStyleOptionsRibbonPageGroup tableStyleOptionsRibbonPageGroup1;
        private UI.TableStylesRibbonPageGroup tableStylesRibbonPageGroup1;
        private UI.DrawingToolsRibbonPageCategory drawingToolsRibbonPageCategory1;
        private UI.DrawingFormatRibbonPage drawingFormatRibbonPage1;
        private UI.DrawingFormatArrangeRibbonPageGroup drawingFormatArrangeRibbonPageGroup1;
        private UI.PictureToolsRibbonPageCategory pictureToolsRibbonPageCategory1;
        private UI.PictureFormatRibbonPage pictureFormatRibbonPage1;
        private UI.PictureFormatArrangeRibbonPageGroup pictureFormatArrangeRibbonPageGroup1;
        private UI.PivotTableToolsRibbonPageCategory pivotTableToolsRibbonPageCategory1;
        private UI.PivotTableAnalyzeRibbonPage pivotTableAnalyzeRibbonPage1;
        private UI.PivotTableAnalyzePivotTableRibbonPageGroup pivotTableAnalyzePivotTableRibbonPageGroup1;
        private UI.PivotTableAnalyzeActiveFieldRibbonPageGroup pivotTableAnalyzeActiveFieldRibbonPageGroup1;
        private UI.PivotTableAnalyzeGroupRibbonPageGroup pivotTableAnalyzeGroupRibbonPageGroup1;
        private UI.PivotTableAnalyzeDataRibbonPageGroup pivotTableAnalyzeDataRibbonPageGroup1;
        private UI.PivotTableAnalyzeActionsRibbonPageGroup pivotTableAnalyzeActionsRibbonPageGroup1;
        private UI.PivotTableAnalyzeCalculationsRibbonPageGroup pivotTableAnalyzeCalculationsRibbonPageGroup1;
        private UI.PivotTableAnalyzeShowRibbonPageGroup pivotTableAnalyzeShowRibbonPageGroup1;
        private UI.PivotTableDesignRibbonPage pivotTableDesignRibbonPage1;
        private UI.PivotTableDesignLayoutRibbonPageGroup pivotTableDesignLayoutRibbonPageGroup1;
        private UI.PivotTableDesignPivotTableStyleOptionsRibbonPageGroup pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1;
        private UI.PivotTableDesignPivotTableStylesRibbonPageGroup pivotTableDesignPivotTableStylesRibbonPageGroup1;
        private UI.FileRibbonPage fileRibbonPage1;
        private UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private UI.InfoRibbonPageGroup infoRibbonPageGroup1;
        private UI.HomeRibbonPage homeRibbonPage1;
        private UI.ClipboardRibbonPageGroup clipboardRibbonPageGroup1;
        private UI.FontRibbonPageGroup fontRibbonPageGroup1;
        private UI.AlignmentRibbonPageGroup alignmentRibbonPageGroup1;
        private UI.NumberRibbonPageGroup numberRibbonPageGroup1;
        private UI.StylesRibbonPageGroup stylesRibbonPageGroup1;
        private UI.CellsRibbonPageGroup cellsRibbonPageGroup1;
        private UI.EditingRibbonPageGroup editingRibbonPageGroup1;
        private UI.InsertRibbonPage insertRibbonPage1;
        private UI.TablesRibbonPageGroup tablesRibbonPageGroup1;
        private UI.IllustrationsRibbonPageGroup illustrationsRibbonPageGroup1;
        private UI.ChartsRibbonPageGroup chartsRibbonPageGroup1;
        private UI.LinksRibbonPageGroup linksRibbonPageGroup1;
        private UI.SymbolsRibbonPageGroup symbolsRibbonPageGroup1;
        private UI.PageLayoutRibbonPage pageLayoutRibbonPage1;
        private UI.PageSetupRibbonPageGroup pageSetupRibbonPageGroup1;
        private UI.PageSetupShowRibbonPageGroup pageSetupShowRibbonPageGroup1;
        private UI.PageSetupPrintRibbonPageGroup pageSetupPrintRibbonPageGroup1;
        private UI.ArrangeRibbonPageGroup arrangeRibbonPageGroup1;
        private UI.FormulasRibbonPage formulasRibbonPage1;
        private UI.FunctionLibraryRibbonPageGroup functionLibraryRibbonPageGroup1;
        private UI.FormulaDefinedNamesRibbonPageGroup formulaDefinedNamesRibbonPageGroup1;
        private UI.FormulaAuditingRibbonPageGroup formulaAuditingRibbonPageGroup1;
        private UI.FormulaCalculationRibbonPageGroup formulaCalculationRibbonPageGroup1;
        private UI.DataRibbonPage dataRibbonPage1;
        private UI.SortAndFilterRibbonPageGroup sortAndFilterRibbonPageGroup1;
        private UI.DataToolsRibbonPageGroup dataToolsRibbonPageGroup1;
        private UI.OutlineRibbonPageGroup outlineRibbonPageGroup1;
        private UI.ReviewRibbonPage reviewRibbonPage1;
        private UI.CommentsRibbonPageGroup commentsRibbonPageGroup1;
        private UI.ChangesRibbonPageGroup changesRibbonPageGroup1;
        private UI.ViewRibbonPage viewRibbonPage1;
        private UI.ShowRibbonPageGroup showRibbonPageGroup1;
        private UI.ZoomRibbonPageGroup zoomRibbonPageGroup1;
        private UI.WindowRibbonPageGroup windowRibbonPageGroup1;
        private UI.MailMergeRibbonPage mailMergeRibbonPage1;
        private UI.MailMergeDataRibbonPageGroup mailMergeDataRibbonPageGroup1;
        private UI.MailMergeModeRibbonPageGroup mailMergeModeRibbonPageGroup1;
        private UI.MailMergeExtendedRibbonPageGroup mailMergeExtendedRibbonPageGroup1;
        private UI.MailMergeGroupingRibbonPageGroup mailMergeGroupingRibbonPageGroup1;
        private UI.MailMergeFilteringRibbonPageGroup mailMergeFilteringRibbonPageGroup1;
        private UI.MailMergeBindingRibbonPageGroup mailMergeBindingRibbonPageGroup2;
        private UI.SpreadsheetBarController spreadsheetBarController1;
        private UI.ProgressBarItem progressBarItem1;
        private XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
    }
}
