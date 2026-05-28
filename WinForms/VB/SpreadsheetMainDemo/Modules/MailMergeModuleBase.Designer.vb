Imports System.Globalization
Imports System.IO
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab
Imports DevExpress.XtraBars.Docking

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class MailMergeModuleBase
        Inherits DevExpress.XtraSpreadsheet.Demos.SpreadSheetTutorialControlBase

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim spreadsheetCommandGalleryItemGroup1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraSpreadsheet.Demos.MailMergeModuleBase))
            Dim spreadsheetCommandGalleryItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim galleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim spreadsheetCommandGalleryItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem25 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem26 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem27 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem28 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem29 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem30 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem31 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem32 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem33 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem34 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem35 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem36 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem37 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem38 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem39 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem40 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem41 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem42 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem43 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem44 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem45 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem46 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem47 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem48 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem49 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem50 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem51 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem52 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem53 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem54 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem55 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem56 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem57 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem58 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem59 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem60 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem61 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem62 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem63 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem64 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem65 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem66 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem67 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem68 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem69 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem70 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem71 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem72 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem73 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem74 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem75 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem76 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem77 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem78 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem79 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem80 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem81 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem82 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem83 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem84 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem85 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem86 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem87 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem88 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem89 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem90 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem91 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem92 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem93 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem94 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem95 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem96 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem97 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem98 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem99 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem100 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem101 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem102 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem103 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem104 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem105 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem106 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem107 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem108 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem109 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem110 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem111 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem112 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem113 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem114 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup25 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem115 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem116 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem117 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup26 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem118 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem119 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem120 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup27 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem121 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem122 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem123 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem124 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem125 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup28 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem126 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem127 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup29 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem128 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem129 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup30 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem130 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup31 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem131 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup32 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem132 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup33 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem133 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup34 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem134 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup35 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem135 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem136 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem137 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem138 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup36 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem139 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem140 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem141 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup37 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem142 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem143 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem144 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem145 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem146 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem147 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem148 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem149 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem150 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup38 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem151 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem152 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem153 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem154 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem155 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem156 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem157 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem158 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem159 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup39 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem160 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem161 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem162 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem163 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup40 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem164 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem165 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem166 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem167 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup41 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem168 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem169 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem170 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup42 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem171 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem172 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup43 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem173 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem174 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup44 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem177 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem178 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem179 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem180 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem181 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem182 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem183 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup45 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem184 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem185 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem186 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem187 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem188 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem189 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem190 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem191 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem192 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem193 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem194 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup46 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem195 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem196 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem197 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem198 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem199 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup47 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem200 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem201 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup48 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem202 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem203 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem204 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem205 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim superToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim reduceOperation1 As DevExpress.XtraBars.Ribbon.ReduceOperation = New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Dim spreadsheetCommandGalleryItemGroup49 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem206 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem207 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem208 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem209 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem210 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem211 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem212 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem213 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem214 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem215 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem216 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem217 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup50 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem218 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem219 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem220 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem221 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem222 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem223 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem224 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup51 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem225 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem226 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem227 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem228 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem229 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup52 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem230 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem231 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem232 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup53 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem233 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem234 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem235 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem236 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem237 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup54 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem238 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem239 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem240 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup55 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem241 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem242 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem243 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem244 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup56 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem245 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem246 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem247 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem248 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup57 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem249 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem250 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem251 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem252 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup58 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem253 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem254 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem255 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem256 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup59 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem257 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem258 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem259 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem260 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem261 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem262 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup60 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem263 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup61 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem264 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem265 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup62 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem266 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem267 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup63 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem268 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem269 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup64 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem270 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem271 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem272 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup65 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem273 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem274 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem275 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup66 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem276 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem277 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem278 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup67 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem279 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem280 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem281 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup68 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem282 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem283 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem284 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup69 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem285 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem286 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem287 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup70 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem288 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem289 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem290 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup71 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem291 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem292 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem293 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem294 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem295 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup72 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem296 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem297 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup73 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem298 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem299 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem300 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem301 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup74 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem302 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem303 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem304 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup75 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem305 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem306 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem307 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem308 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem309 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem310 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem311 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem312 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem313 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup76 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem314 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem315 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem316 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem317 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem318 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem319 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem320 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem321 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem322 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup77 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem323 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem324 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem325 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem326 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup78 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem327 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem328 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem329 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem330 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup79 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem331 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem332 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem333 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup80 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem334 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem335 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup81 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem336 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem337 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup82 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem340 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem341 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem342 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem343 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem344 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem345 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem346 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup83 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem347 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem348 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem349 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem350 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem351 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem352 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem353 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem354 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem355 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem356 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem357 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup84 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem358 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem359 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem360 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem361 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem362 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup85 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem363 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem364 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup86 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem365 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem366 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem367 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem368 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup87 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem369 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem370 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem371 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem372 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem373 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem374 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup88 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem375 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem376 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem377 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem378 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem379 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem380 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim galleryItemGroup2 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem1 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem4 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem5 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem6 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem7 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem8 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem9 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem10 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem11 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem12 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem13 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem14 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim spreadsheetCommandGalleryItemGroup89 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem381 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem382 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem383 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem384 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem385 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem386 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem387 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem388 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem389 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem390 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem391 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem392 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup90 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem393 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem394 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem395 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem396 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem397 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem398 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem399 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup91 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem400 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem401 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem402 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem403 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem404 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup92 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem405 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem406 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem407 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup93 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem408 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem409 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem410 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem411 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem412 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup94 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem413 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem414 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem415 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup95 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem416 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem417 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem418 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem419 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup96 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem420 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem421 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem422 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem423 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup97 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem424 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem425 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem426 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem427 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup98 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem428 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem429 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem430 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem431 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup99 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem432 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem433 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem434 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem435 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem436 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem437 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup100 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem438 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup101 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem439 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem440 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup102 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem441 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem442 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup103 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem443 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem444 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup104 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem445 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem446 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem447 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup105 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem448 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem449 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem450 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup106 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem451 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem452 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem453 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup107 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem454 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem455 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem456 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup108 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem457 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem458 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem459 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup109 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem460 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem461 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem462 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup110 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem463 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem464 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem465 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup111 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem466 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem467 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem468 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem469 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem470 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup112 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem471 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem472 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup113 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem473 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem474 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem475 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem476 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup114 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem477 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem478 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem479 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup115 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem480 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem481 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem482 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem483 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem484 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem485 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem486 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem487 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem488 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup116 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem489 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem490 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem491 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem492 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem493 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem494 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem495 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem496 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem497 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup117 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem498 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem499 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem500 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem501 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup118 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem502 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem503 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem504 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem505 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup119 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem506 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem507 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem508 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup120 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem509 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem510 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup121 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem511 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem512 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup122 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem515 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem516 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem517 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem518 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem519 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem520 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem521 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup123 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem522 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem523 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem524 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem525 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem526 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem527 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem528 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem529 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem530 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem531 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem532 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup124 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem533 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem534 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem535 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem536 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem537 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup125 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem538 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem539 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup126 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem540 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem541 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem542 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem543 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup127 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem544 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem545 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem546 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem547 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem548 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem549 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup128 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem550 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem551 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem552 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem553 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem554 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem555 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim galleryItemGroup3 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem15 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem16 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem17 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem18 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem19 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem20 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem21 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem22 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem23 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem24 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem25 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem26 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem27 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem28 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim spreadsheetCommandGalleryItemGroup129 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem556 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem557 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem558 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem559 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem560 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem561 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem562 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem563 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem564 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem565 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem566 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem567 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup130 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem568 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem569 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem570 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem571 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem572 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem573 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem574 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup131 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem575 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem576 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem577 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem578 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem579 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup132 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem580 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem581 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem582 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup133 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem583 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem584 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem585 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem586 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem587 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup134 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem588 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem589 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem590 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup135 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem591 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem592 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem593 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem594 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup136 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem595 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem596 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem597 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem598 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup137 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem599 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem600 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem601 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem602 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup138 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem603 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem604 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem605 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem606 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup139 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem607 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem608 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem609 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem610 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem611 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem612 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup140 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem613 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup141 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem614 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem615 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup142 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem616 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem617 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup143 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem618 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem619 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup144 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem620 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem621 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem622 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup145 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem623 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem624 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem625 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup146 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem626 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem627 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem628 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup147 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem629 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem630 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem631 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup148 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem632 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem633 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem634 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup149 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem635 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem636 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem637 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup150 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem638 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem639 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem640 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup151 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem641 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem642 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem643 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem644 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem645 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup152 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem646 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem647 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup153 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem648 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem649 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup154 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem650 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem651 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem652 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup155 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem653 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem654 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem655 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup156 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem656 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem657 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup157 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem658 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem659 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup158 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem662 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem663 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem664 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem665 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem666 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem667 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem668 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup159 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem669 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem670 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem671 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem672 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem673 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem674 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem675 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem676 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem677 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem678 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem679 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup160 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem680 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem681 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem682 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem683 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem684 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem685 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem686 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem687 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem688 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup161 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem689 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem690 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem691 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem692 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem693 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem694 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem695 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem696 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem697 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup162 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem698 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem699 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem700 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem701 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup163 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem702 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem703 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem704 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem705 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup164 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem706 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem707 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem708 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem709 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem710 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup165 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem711 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem712 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup166 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem713 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem714 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem715 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem716 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.commandBarGalleryDropDown50 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.spreadsheetCommandBarButtonItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontNameItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem()
            Me.repositoryItemSpreadsheetFontSizeEdit1 = New DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit()
            Me.spreadsheetCommandBarButtonItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarCheckItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarSubItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.changeBorderLineColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem()
            Me.changeBorderLineStyleItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem()
            Me.commandBarGalleryDropDown73 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeCellFillColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem()
            Me.changeFontColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem()
            Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarCheckItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarCheckItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarButtonItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarSubItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarCheckItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem35 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup8 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeNumberFormatItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem()
            Me.repositoryItemPopupGalleryEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit()
            Me.barButtonGroup9 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarSubItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem36 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem37 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem38 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem39 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem40 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem41 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem42 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem43 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup10 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarButtonItem44 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem45 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarSubItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem46 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem47 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem48 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem49 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem50 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem51 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem52 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem53 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem54 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem55 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem56 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem57 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem58 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown74 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown75 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown76 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonItem59 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem60 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem61 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem62 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.galleryFormatAsTableItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem()
            Me.commandBarGalleryDropDown77 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.galleryChangeStyleItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem()
            Me.spreadsheetCommandBarSubItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem63 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem64 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem65 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem66 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem67 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem68 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem69 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem70 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem71 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem72 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem73 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem74 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem75 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem76 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem77 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem78 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem79 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem80 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem81 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem82 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem83 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem84 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem85 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem86 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem87 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem88 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem89 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.changeSheetTabColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem()
            Me.spreadsheetCommandBarButtonItem90 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem91 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem92 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem93 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem94 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem95 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem96 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem97 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem98 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem99 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem100 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem101 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem102 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem103 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem104 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem105 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem106 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem107 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem108 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem109 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem110 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem111 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem112 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem113 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem114 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem115 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem116 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem117 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem118 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem119 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem120 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonGalleryDropDownItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown78 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown79 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown80 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown81 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown82 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown83 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown84 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown85 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown86 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonItem121 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem122 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarCheckItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem123 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarCheckItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.pageSetupPaperKindItem1 = New DevExpress.XtraSpreadsheet.UI.PageSetupPaperKindItem()
            Me.spreadsheetCommandBarSubItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem124 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem125 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem126 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem127 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarSubItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem128 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem129 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem130 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem131 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.functionsFinancialItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsFinancialItem()
            Me.functionsLogicalItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsLogicalItem()
            Me.functionsTextItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsTextItem()
            Me.functionsDateAndTimeItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsDateAndTimeItem()
            Me.functionsLookupAndReferenceItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsLookupAndReferenceItem()
            Me.functionsMathAndTrigonometryItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsMathAndTrigonometryItem()
            Me.spreadsheetCommandBarSubItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.functionsStatisticalItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsStatisticalItem()
            Me.functionsEngineeringItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsEngineeringItem()
            Me.functionsInformationItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsInformationItem()
            Me.functionsCompatibilityItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsCompatibilityItem()
            Me.functionsWebItem1 = New DevExpress.XtraSpreadsheet.UI.FunctionsWebItem()
            Me.spreadsheetCommandBarButtonItem132 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem133 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.definedNameListItem1 = New DevExpress.XtraSpreadsheet.UI.DefinedNameListItem()
            Me.spreadsheetCommandBarButtonItem134 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarSubItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarCheckItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem135 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem136 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem137 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem138 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem139 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem140 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem141 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem142 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem143 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem144 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem145 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem146 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem147 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem148 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem149 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem150 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem151 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem152 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem153 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem154 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem155 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem156 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem157 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem158 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem159 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem160 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem161 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem162 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem163 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem164 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem165 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.galleryChartLayoutItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryChartLayoutItem()
            Me.galleryChartStyleItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryChartStyleItem()
            Me.spreadsheetCommandBarButtonItem166 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonGalleryDropDownItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown87 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown88 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarSubItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonGalleryDropDownItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown89 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown90 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown91 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarSubItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonGalleryDropDownItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown92 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown93 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown94 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown95 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown96 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown97 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown98 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.renameTableItemCaption1 = New DevExpress.XtraSpreadsheet.UI.RenameTableItemCaption()
            Me.renameTableItem1 = New DevExpress.XtraSpreadsheet.UI.RenameTableItem()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.spreadsheetCommandBarCheckItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.galleryTableStylesItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryTableStylesItem()
            Me.spreadsheetCommandBarButtonItem167 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem168 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem169 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem170 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem171 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem172 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem173 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem174 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem175 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem176 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem177 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem178 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem179 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem180 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem181 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem182 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem35 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem183 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem184 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem185 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem186 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem35 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem36 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarSubItem36 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem187 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem188 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem189 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem37 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem190 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem191 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem192 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem193 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem38 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem194 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem195 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem196 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem197 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem198 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem39 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem199 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem200 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem37 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem38 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem39 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem40 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.galleryPivotStylesItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryPivotStylesItem()
            Me.spreadsheetCommandBarButtonItem201 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem40 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem202 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem203 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem41 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem204 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem205 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem206 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem41 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem42 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem43 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarSubItem42 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarCheckItem44 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem45 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem207 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem208 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem209 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem43 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem210 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem211 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem212 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem213 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem214 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem215 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem216 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem217 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem46 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem218 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.endModeInfoStaticItem1 = New DevExpress.XtraSpreadsheet.UI.EndModeInfoStaticItem()
            Me.averageInfoStaticItem1 = New DevExpress.XtraSpreadsheet.UI.AverageInfoStaticItem()
            Me.countInfoStaticItem1 = New DevExpress.XtraSpreadsheet.UI.CountInfoStaticItem()
            Me.numericalCountInfoStaticItem1 = New DevExpress.XtraSpreadsheet.UI.NumericalCountInfoStaticItem()
            Me.minInfoStaticItem1 = New DevExpress.XtraSpreadsheet.UI.MinInfoStaticItem()
            Me.maxInfoStaticItem1 = New DevExpress.XtraSpreadsheet.UI.MaxInfoStaticItem()
            Me.sumInfoStaticItem1 = New DevExpress.XtraSpreadsheet.UI.SumInfoStaticItem()
            Me.zoomEditItem1 = New DevExpress.XtraSpreadsheet.UI.ZoomEditItem()
            Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
            Me.showZoomButtonItem1 = New DevExpress.XtraSpreadsheet.UI.ShowZoomButtonItem()
            Me.progressBarItem1 = New DevExpress.XtraSpreadsheet.UI.ProgressBarItem()
            Me.chartToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.ChartToolsRibbonPageCategory()
            Me.chartsDesignRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignRibbonPage()
            Me.chartsDesignTypeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignTypeRibbonPageGroup()
            Me.chartsDesignDataRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignDataRibbonPageGroup()
            Me.chartsDesignLayoutsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignLayoutsRibbonPageGroup()
            Me.chartsDesignStylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignStylesRibbonPageGroup()
            Me.chartsDesignLocationRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsDesignLocationRibbonPageGroup()
            Me.chartsLayoutRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutRibbonPage()
            Me.chartsLayoutAxesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutAxesRibbonPageGroup()
            Me.chartsLayoutLabelsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutLabelsRibbonPageGroup()
            Me.chartsLayoutAnalysisRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsLayoutAnalysisRibbonPageGroup()
            Me.chartsFormatRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ChartsFormatRibbonPage()
            Me.chartsFormatArrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsFormatArrangeRibbonPageGroup()
            Me.tableToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageCategory()
            Me.tableToolsDesignRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.TableToolsDesignRibbonPage()
            Me.tablePropertiesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TablePropertiesRibbonPageGroup()
            Me.tableToolsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageGroup()
            Me.tableStyleOptionsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TableStyleOptionsRibbonPageGroup()
            Me.tableStylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TableStylesRibbonPageGroup()
            Me.drawingToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.DrawingToolsRibbonPageCategory()
            Me.drawingFormatRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.DrawingFormatRibbonPage()
            Me.drawingFormatArrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.DrawingFormatArrangeRibbonPageGroup()
            Me.pictureToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.PictureToolsRibbonPageCategory()
            Me.pictureFormatRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.PictureFormatRibbonPage()
            Me.pictureFormatArrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PictureFormatArrangeRibbonPageGroup()
            Me.pivotTableToolsRibbonPageCategory1 = New DevExpress.XtraSpreadsheet.UI.PivotTableToolsRibbonPageCategory()
            Me.pivotTableAnalyzeRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeRibbonPage()
            Me.pivotTableAnalyzePivotTableRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzePivotTableRibbonPageGroup()
            Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeActiveFieldRibbonPageGroup()
            Me.pivotTableAnalyzeGroupRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeGroupRibbonPageGroup()
            Me.pivotTableAnalyzeDataRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeDataRibbonPageGroup()
            Me.pivotTableAnalyzeActionsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeActionsRibbonPageGroup()
            Me.pivotTableAnalyzeCalculationsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeCalculationsRibbonPageGroup()
            Me.pivotTableAnalyzeShowRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeShowRibbonPageGroup()
            Me.pivotTableDesignRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.PivotTableDesignRibbonPage()
            Me.pivotTableDesignLayoutRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableDesignLayoutRibbonPageGroup()
            Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableDesignPivotTableStyleOptionsRibbonPageGroup()
            Me.pivotTableDesignPivotTableStylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PivotTableDesignPivotTableStylesRibbonPageGroup()
            Me.fileRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup()
            Me.infoRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.HomeRibbonPage()
            Me.clipboardRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup()
            Me.fontRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup()
            Me.alignmentRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup()
            Me.numberRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup()
            Me.stylesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup()
            Me.cellsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup()
            Me.editingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup()
            Me.insertRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.InsertRibbonPage()
            Me.tablesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.TablesRibbonPageGroup()
            Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.IllustrationsRibbonPageGroup()
            Me.chartsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChartsRibbonPageGroup()
            Me.linksRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.LinksRibbonPageGroup()
            Me.symbolsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.SymbolsRibbonPageGroup()
            Me.pageLayoutRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.PageLayoutRibbonPage()
            Me.pageSetupRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PageSetupRibbonPageGroup()
            Me.pageSetupShowRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PageSetupShowRibbonPageGroup()
            Me.pageSetupPrintRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.PageSetupPrintRibbonPageGroup()
            Me.arrangeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ArrangeRibbonPageGroup()
            Me.formulasRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FormulasRibbonPage()
            Me.functionLibraryRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FunctionLibraryRibbonPageGroup()
            Me.formulaDefinedNamesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaDefinedNamesRibbonPageGroup()
            Me.formulaAuditingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaAuditingRibbonPageGroup()
            Me.formulaCalculationRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.FormulaCalculationRibbonPageGroup()
            Me.dataRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.DataRibbonPage()
            Me.sortAndFilterRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.SortAndFilterRibbonPageGroup()
            Me.dataToolsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.DataToolsRibbonPageGroup()
            Me.outlineRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.OutlineRibbonPageGroup()
            Me.reviewRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ReviewRibbonPage()
            Me.commentsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommentsRibbonPageGroup()
            Me.changesRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ChangesRibbonPageGroup()
            Me.viewRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.ViewRibbonPage()
            Me.showRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ShowRibbonPageGroup()
            Me.zoomRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.ZoomRibbonPageGroup()
            Me.windowRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.WindowRibbonPageGroup()
            Me.mailMergeRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.MailMergeRibbonPage()
            Me.mailMergeDataRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeDataRibbonPageGroup()
            Me.mailMergeModeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeModeRibbonPageGroup()
            Me.mailMergeExtendedRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeExtendedRibbonPageGroup()
            Me.mailMergeGroupingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeGroupingRibbonPageGroup()
            Me.mailMergeFilteringRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeFilteringRibbonPageGroup()
            Me.mailMergeBindingRibbonPageGroup2 = New DevExpress.XtraSpreadsheet.UI.MailMergeBindingRibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.commandBarGalleryDropDown49 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown51 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown52 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown53 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown54 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown55 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown56 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown57 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown58 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown59 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown60 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown61 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown62 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown63 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown64 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown65 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown66 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown67 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown68 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown69 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown70 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown71 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown72 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown26 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown25 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown27 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown28 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown29 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown30 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown31 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown32 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown33 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown34 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown35 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown36 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown37 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown38 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown39 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown40 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown41 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown42 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown43 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown44 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown45 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown46 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown47 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown48 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown8 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown9 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown10 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown11 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown12 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown13 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown14 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown15 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown16 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown17 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown18 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown19 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown20 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown21 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown22 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown23 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.commandBarGalleryDropDown24 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetDockManager1 = New DevExpress.XtraSpreadsheet.SpreadsheetDockManager(Me.components)
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.fieldListDockPanel1 = New DevExpress.XtraSpreadsheet.FieldListDockPanel()
            Me.fieldListDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.mailMergeParametersDockPanel = New DevExpress.XtraSpreadsheet.MailMergeParametersDockPanel()
            Me.mailMergeParametersDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.filteringDockPanel = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.checkEdit0 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            Me.mailMergeBindingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeBindingRibbonPageGroup()
            Me.spreadsheetFormulaBar1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.spreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController(Me.components)
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown50), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpreadsheetFontSizeEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown73), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPopupGalleryEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown74), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown75), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown76), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown77), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown78), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown79), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown80), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown81), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown82), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown83), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown84), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown85), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown86), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown87), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown88), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown89), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown90), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown91), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown92), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown93), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown94), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown95), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown96), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown97), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown98), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemZoomTrackBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown49), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown51), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown52), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown53), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown54), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown55), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown56), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown57), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown58), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown59), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown60), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown61), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown62), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown63), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown64), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown65), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown66), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown67), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown68), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown69), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown70), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown71), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown72), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown26), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown25), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown27), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown28), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown29), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown30), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown31), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown32), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown33), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown34), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown35), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown36), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown37), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown38), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown39), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown40), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown41), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown42), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown43), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown44), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown45), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown46), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown47), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown48), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown16), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown17), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown18), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown20), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown21), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown22), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown23), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown24), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spreadsheetDockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer1.SuspendLayout()
            Me.fieldListDockPanel1.SuspendLayout()
            Me.mailMergeParametersDockPanel.SuspendLayout()
            Me.filteringDockPanel.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            CType((Me.checkEdit0.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spreadsheetBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            ' 
            ' commandBarGalleryDropDown50
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown50.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup1.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup"
            spreadsheetCommandGalleryItem1.Caption = "Blue Data Bar (Gradient)"
            spreadsheetCommandGalleryItem1.CommandName = "ConditionalFormattingDataBarGradientBlue"
            spreadsheetCommandGalleryItem1.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem1.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem1.ImageOptions.Image = CType((resources.GetObject("resource.Image")), System.Drawing.Image)
            spreadsheetCommandGalleryItem2.Caption = "Green Data Bar (Gradient)"
            spreadsheetCommandGalleryItem2.CommandName = "ConditionalFormattingDataBarGradientGreen"
            spreadsheetCommandGalleryItem2.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem2.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem2.ImageOptions.Image = CType((resources.GetObject("resource.Image1")), System.Drawing.Image)
            spreadsheetCommandGalleryItem3.Caption = "Red Data Bar (Gradient)"
            spreadsheetCommandGalleryItem3.CommandName = "ConditionalFormattingDataBarGradientRed"
            spreadsheetCommandGalleryItem3.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem3.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem3.ImageOptions.Image = CType((resources.GetObject("resource.Image2")), System.Drawing.Image)
            spreadsheetCommandGalleryItem4.Caption = "Orange Data Bar (Gradient)"
            spreadsheetCommandGalleryItem4.CommandName = "ConditionalFormattingDataBarGradientOrange"
            spreadsheetCommandGalleryItem4.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem4.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem4.ImageOptions.Image = CType((resources.GetObject("resource.Image3")), System.Drawing.Image)
            spreadsheetCommandGalleryItem5.Caption = "Light Blue Data Bar (Gradient)"
            spreadsheetCommandGalleryItem5.CommandName = "ConditionalFormattingDataBarGradientLightBlue"
            spreadsheetCommandGalleryItem5.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem5.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem5.ImageOptions.Image = CType((resources.GetObject("resource.Image4")), System.Drawing.Image)
            spreadsheetCommandGalleryItem6.Caption = "Purple Data Bar (Gradient)"
            spreadsheetCommandGalleryItem6.CommandName = "ConditionalFormattingDataBarGradientPurple"
            spreadsheetCommandGalleryItem6.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem6.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem6.ImageOptions.Image = CType((resources.GetObject("resource.Image5")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem1, spreadsheetCommandGalleryItem2, spreadsheetCommandGalleryItem3, spreadsheetCommandGalleryItem4, spreadsheetCommandGalleryItem5, spreadsheetCommandGalleryItem6})
            spreadsheetCommandGalleryItemGroup2.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup"
            spreadsheetCommandGalleryItem7.Caption = "Blue Data Bar (Solid)"
            spreadsheetCommandGalleryItem7.CommandName = "ConditionalFormattingDataBarSolidBlue"
            spreadsheetCommandGalleryItem7.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem7.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem7.ImageOptions.Image = CType((resources.GetObject("resource.Image6")), System.Drawing.Image)
            spreadsheetCommandGalleryItem8.Caption = "Green Data Bar (Solid)"
            spreadsheetCommandGalleryItem8.CommandName = "ConditionalFormattingDataBarSolidGreen"
            spreadsheetCommandGalleryItem8.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem8.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem8.ImageOptions.Image = CType((resources.GetObject("resource.Image7")), System.Drawing.Image)
            spreadsheetCommandGalleryItem9.Caption = "Red Data Bar (Solid)"
            spreadsheetCommandGalleryItem9.CommandName = "ConditionalFormattingDataBarSolidRed"
            spreadsheetCommandGalleryItem9.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem9.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem9.ImageOptions.Image = CType((resources.GetObject("resource.Image8")), System.Drawing.Image)
            spreadsheetCommandGalleryItem10.Caption = "Orange Data Bar (Solid)"
            spreadsheetCommandGalleryItem10.CommandName = "ConditionalFormattingDataBarSolidOrange"
            spreadsheetCommandGalleryItem10.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem10.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem10.ImageOptions.Image = CType((resources.GetObject("resource.Image9")), System.Drawing.Image)
            spreadsheetCommandGalleryItem11.Caption = "Light Blue Data Bar (Solid)"
            spreadsheetCommandGalleryItem11.CommandName = "ConditionalFormattingDataBarSolidLightBlue"
            spreadsheetCommandGalleryItem11.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem11.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem11.ImageOptions.Image = CType((resources.GetObject("resource.Image10")), System.Drawing.Image)
            spreadsheetCommandGalleryItem12.Caption = "Purple Data Bar (Solid)"
            spreadsheetCommandGalleryItem12.CommandName = "ConditionalFormattingDataBarSolidPurple"
            spreadsheetCommandGalleryItem12.Description = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem12.Hint = "View a colored data bar in the cell. The length of the data bar represents the va" & "lue in the cell. A longer bar represents a higher value."
            spreadsheetCommandGalleryItem12.ImageOptions.Image = CType((resources.GetObject("resource.Image11")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem7, spreadsheetCommandGalleryItem8, spreadsheetCommandGalleryItem9, spreadsheetCommandGalleryItem10, spreadsheetCommandGalleryItem11, spreadsheetCommandGalleryItem12})
            Me.commandBarGalleryDropDown50.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup1, spreadsheetCommandGalleryItemGroup2})
            Me.commandBarGalleryDropDown50.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown50.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown50.Manager = Nothing
            Me.commandBarGalleryDropDown50.Name = "commandBarGalleryDropDown50"
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 184)
            Me.spreadsheetControl1.MenuManager = Me.ribbonControl1
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Size = New System.Drawing.Size(862, 221)
            Me.spreadsheetControl1.TabIndex = 4
            Me.spreadsheetControl1.Text = "spreadsheetControl1"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.spreadsheetCommandBarButtonItem1, Me.spreadsheetCommandBarButtonItem2, Me.spreadsheetCommandBarButtonItem3, Me.spreadsheetCommandBarButtonItem4, Me.spreadsheetCommandBarButtonItem5, Me.spreadsheetCommandBarButtonItem6, Me.spreadsheetCommandBarButtonItem7, Me.spreadsheetCommandBarButtonItem8, Me.spreadsheetCommandBarButtonItem9, Me.spreadsheetCommandBarButtonItem10, Me.spreadsheetCommandBarButtonItem11, Me.spreadsheetCommandBarButtonItem12, Me.spreadsheetCommandBarButtonItem13, Me.spreadsheetCommandBarButtonItem14, Me.spreadsheetCommandBarButtonItem15, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.spreadsheetCommandBarButtonItem16, Me.spreadsheetCommandBarButtonItem17, Me.barButtonGroup2, Me.spreadsheetCommandBarCheckItem1, Me.spreadsheetCommandBarCheckItem2, Me.spreadsheetCommandBarCheckItem3, Me.spreadsheetCommandBarCheckItem4, Me.barButtonGroup3, Me.spreadsheetCommandBarSubItem1, Me.spreadsheetCommandBarButtonItem18, Me.spreadsheetCommandBarButtonItem19, Me.spreadsheetCommandBarButtonItem20, Me.spreadsheetCommandBarButtonItem21, Me.spreadsheetCommandBarButtonItem22, Me.spreadsheetCommandBarButtonItem23, Me.spreadsheetCommandBarButtonItem24, Me.spreadsheetCommandBarButtonItem25, Me.spreadsheetCommandBarButtonItem26, Me.spreadsheetCommandBarButtonItem27, Me.spreadsheetCommandBarButtonItem28, Me.spreadsheetCommandBarButtonItem29, Me.spreadsheetCommandBarButtonItem30, Me.changeBorderLineColorItem1, Me.changeBorderLineStyleItem1, Me.barButtonGroup4, Me.changeCellFillColorItem1, Me.changeFontColorItem1, Me.barButtonGroup5, Me.spreadsheetCommandBarCheckItem5, Me.spreadsheetCommandBarCheckItem6, Me.spreadsheetCommandBarCheckItem7, Me.barButtonGroup6, Me.spreadsheetCommandBarCheckItem8, Me.spreadsheetCommandBarCheckItem9, Me.spreadsheetCommandBarCheckItem10, Me.barButtonGroup7, Me.spreadsheetCommandBarButtonItem31, Me.spreadsheetCommandBarButtonItem32, Me.spreadsheetCommandBarCheckItem11, Me.spreadsheetCommandBarSubItem2, Me.spreadsheetCommandBarCheckItem12, Me.spreadsheetCommandBarButtonItem33, Me.spreadsheetCommandBarButtonItem34, Me.spreadsheetCommandBarButtonItem35, Me.barButtonGroup8, Me.changeNumberFormatItem1, Me.barButtonGroup9, Me.spreadsheetCommandBarSubItem3, Me.spreadsheetCommandBarButtonItem36, Me.spreadsheetCommandBarButtonItem37, Me.spreadsheetCommandBarButtonItem38, Me.spreadsheetCommandBarButtonItem39, Me.spreadsheetCommandBarButtonItem40, Me.spreadsheetCommandBarButtonItem41, Me.spreadsheetCommandBarButtonItem42, Me.spreadsheetCommandBarButtonItem43, Me.barButtonGroup10, Me.spreadsheetCommandBarButtonItem44, Me.spreadsheetCommandBarButtonItem45, Me.spreadsheetCommandBarSubItem7, Me.spreadsheetCommandBarButtonItem46, Me.spreadsheetCommandBarButtonItem47, Me.spreadsheetCommandBarButtonItem48, Me.spreadsheetCommandBarButtonItem49, Me.spreadsheetCommandBarButtonItem50, Me.spreadsheetCommandBarButtonItem51, Me.spreadsheetCommandBarButtonItem52, Me.spreadsheetCommandBarSubItem4, Me.spreadsheetCommandBarButtonItem53, Me.spreadsheetCommandBarButtonItem54, Me.spreadsheetCommandBarButtonItem55, Me.spreadsheetCommandBarButtonItem56, Me.spreadsheetCommandBarButtonItem57, Me.spreadsheetCommandBarButtonItem58, Me.spreadsheetCommandBarSubItem5, Me.spreadsheetCommandBarButtonGalleryDropDownItem1, Me.spreadsheetCommandBarButtonGalleryDropDownItem2, Me.spreadsheetCommandBarButtonGalleryDropDownItem3, Me.spreadsheetCommandBarButtonItem59, Me.spreadsheetCommandBarButtonItem60, Me.spreadsheetCommandBarButtonItem61, Me.spreadsheetCommandBarSubItem6, Me.spreadsheetCommandBarButtonItem62, Me.galleryFormatAsTableItem1, Me.galleryChangeStyleItem1, Me.spreadsheetCommandBarSubItem8, Me.spreadsheetCommandBarButtonItem63, Me.spreadsheetCommandBarButtonItem64, Me.spreadsheetCommandBarButtonItem65, Me.spreadsheetCommandBarButtonItem66, Me.spreadsheetCommandBarButtonItem67, Me.spreadsheetCommandBarButtonItem68, Me.spreadsheetCommandBarButtonItem69, Me.spreadsheetCommandBarButtonItem70, Me.spreadsheetCommandBarSubItem9, Me.spreadsheetCommandBarButtonItem71, Me.spreadsheetCommandBarButtonItem72, Me.spreadsheetCommandBarButtonItem73, Me.spreadsheetCommandBarButtonItem74, Me.spreadsheetCommandBarButtonItem75, Me.spreadsheetCommandBarButtonItem76, Me.spreadsheetCommandBarSubItem11, Me.spreadsheetCommandBarButtonItem77, Me.spreadsheetCommandBarButtonItem78, Me.spreadsheetCommandBarButtonItem79, Me.spreadsheetCommandBarButtonItem80, Me.spreadsheetCommandBarButtonItem81, Me.spreadsheetCommandBarButtonItem82, Me.spreadsheetCommandBarButtonItem83, Me.spreadsheetCommandBarButtonItem84, Me.spreadsheetCommandBarButtonItem85, Me.spreadsheetCommandBarButtonItem86, Me.spreadsheetCommandBarButtonItem87, Me.spreadsheetCommandBarSubItem10, Me.spreadsheetCommandBarButtonItem88, Me.spreadsheetCommandBarButtonItem89, Me.changeSheetTabColorItem1, Me.spreadsheetCommandBarButtonItem90, Me.spreadsheetCommandBarCheckItem13, Me.spreadsheetCommandBarButtonItem91, Me.spreadsheetCommandBarSubItem12, Me.spreadsheetCommandBarButtonItem92, Me.spreadsheetCommandBarButtonItem93, Me.spreadsheetCommandBarButtonItem94, Me.spreadsheetCommandBarButtonItem95, Me.spreadsheetCommandBarButtonItem96, Me.spreadsheetCommandBarSubItem13, Me.spreadsheetCommandBarButtonItem97, Me.spreadsheetCommandBarButtonItem98, Me.spreadsheetCommandBarButtonItem99, Me.spreadsheetCommandBarButtonItem100, Me.spreadsheetCommandBarSubItem14, Me.spreadsheetCommandBarButtonItem101, Me.spreadsheetCommandBarButtonItem102, Me.spreadsheetCommandBarButtonItem103, Me.spreadsheetCommandBarButtonItem104, Me.spreadsheetCommandBarButtonItem105, Me.spreadsheetCommandBarButtonItem106, Me.spreadsheetCommandBarSubItem15, Me.spreadsheetCommandBarButtonItem107, Me.spreadsheetCommandBarButtonItem108, Me.spreadsheetCommandBarCheckItem14, Me.spreadsheetCommandBarButtonItem109, Me.spreadsheetCommandBarButtonItem110, Me.spreadsheetCommandBarSubItem16, Me.spreadsheetCommandBarButtonItem111, Me.spreadsheetCommandBarButtonItem112, Me.spreadsheetCommandBarButtonItem113, Me.spreadsheetCommandBarButtonItem114, Me.spreadsheetCommandBarButtonItem115, Me.spreadsheetCommandBarButtonItem116, Me.spreadsheetCommandBarButtonItem117, Me.spreadsheetCommandBarButtonItem118, Me.spreadsheetCommandBarButtonItem119, Me.spreadsheetCommandBarButtonItem120, Me.spreadsheetCommandBarButtonGalleryDropDownItem4, Me.spreadsheetCommandBarButtonGalleryDropDownItem5, Me.spreadsheetCommandBarButtonGalleryDropDownItem6, Me.spreadsheetCommandBarButtonGalleryDropDownItem7, Me.spreadsheetCommandBarButtonGalleryDropDownItem8, Me.spreadsheetCommandBarButtonGalleryDropDownItem9, Me.spreadsheetCommandBarButtonGalleryDropDownItem10, Me.spreadsheetCommandBarButtonGalleryDropDownItem11, Me.spreadsheetCommandBarButtonGalleryDropDownItem12, Me.spreadsheetCommandBarButtonItem121, Me.spreadsheetCommandBarButtonItem122, Me.spreadsheetCommandBarSubItem17, Me.spreadsheetCommandBarCheckItem15, Me.spreadsheetCommandBarCheckItem16, Me.spreadsheetCommandBarCheckItem17, Me.spreadsheetCommandBarButtonItem123, Me.spreadsheetCommandBarSubItem18, Me.spreadsheetCommandBarCheckItem18, Me.spreadsheetCommandBarCheckItem19, Me.pageSetupPaperKindItem1, Me.spreadsheetCommandBarSubItem19, Me.spreadsheetCommandBarButtonItem124, Me.spreadsheetCommandBarButtonItem125, Me.spreadsheetCommandBarButtonItem126, Me.spreadsheetCommandBarButtonItem127, Me.spreadsheetCommandBarCheckItem20, Me.spreadsheetCommandBarCheckItem21, Me.spreadsheetCommandBarCheckItem22, Me.spreadsheetCommandBarCheckItem23, Me.spreadsheetCommandBarSubItem20, Me.spreadsheetCommandBarButtonItem128, Me.spreadsheetCommandBarButtonItem129, Me.spreadsheetCommandBarSubItem21, Me.spreadsheetCommandBarButtonItem130, Me.spreadsheetCommandBarButtonItem131, Me.spreadsheetCommandBarSubItem22, Me.functionsFinancialItem1, Me.functionsLogicalItem1, Me.functionsTextItem1, Me.functionsDateAndTimeItem1, Me.functionsLookupAndReferenceItem1, Me.functionsMathAndTrigonometryItem1, Me.spreadsheetCommandBarSubItem23, Me.functionsStatisticalItem1, Me.functionsEngineeringItem1, Me.functionsInformationItem1, Me.functionsCompatibilityItem1, Me.functionsWebItem1, Me.spreadsheetCommandBarButtonItem132, Me.spreadsheetCommandBarButtonItem133, Me.definedNameListItem1, Me.spreadsheetCommandBarButtonItem134, Me.spreadsheetCommandBarCheckItem24, Me.spreadsheetCommandBarSubItem24, Me.spreadsheetCommandBarCheckItem25, Me.spreadsheetCommandBarCheckItem26, Me.spreadsheetCommandBarButtonItem135, Me.spreadsheetCommandBarButtonItem136, Me.spreadsheetCommandBarSubItem25, Me.spreadsheetCommandBarButtonItem137, Me.spreadsheetCommandBarButtonItem138, Me.spreadsheetCommandBarButtonItem139, Me.spreadsheetCommandBarSubItem26, Me.spreadsheetCommandBarButtonItem140, Me.spreadsheetCommandBarButtonItem141, Me.spreadsheetCommandBarSubItem27, Me.spreadsheetCommandBarButtonItem142, Me.spreadsheetCommandBarButtonItem143, Me.spreadsheetCommandBarButtonItem144, Me.spreadsheetCommandBarButtonItem145, Me.spreadsheetCommandBarButtonItem146, Me.spreadsheetCommandBarButtonItem147, Me.spreadsheetCommandBarButtonItem148, Me.spreadsheetCommandBarButtonItem149, Me.spreadsheetCommandBarButtonItem150, Me.spreadsheetCommandBarButtonItem151, Me.spreadsheetCommandBarButtonItem152, Me.spreadsheetCommandBarButtonItem153, Me.spreadsheetCommandBarButtonItem154, Me.spreadsheetCommandBarButtonItem155, Me.spreadsheetCommandBarButtonItem156, Me.spreadsheetCommandBarButtonItem157, Me.spreadsheetCommandBarButtonItem158, Me.spreadsheetCommandBarSubItem28, Me.spreadsheetCommandBarButtonItem159, Me.spreadsheetCommandBarButtonItem160, Me.spreadsheetCommandBarButtonItem161, Me.spreadsheetCommandBarButtonItem162, Me.spreadsheetCommandBarButtonItem163, Me.spreadsheetCommandBarButtonItem164, Me.spreadsheetCommandBarButtonItem165, Me.galleryChartLayoutItem1, Me.galleryChartStyleItem1, Me.spreadsheetCommandBarButtonItem166, Me.spreadsheetCommandBarSubItem29, Me.spreadsheetCommandBarButtonGalleryDropDownItem13, Me.spreadsheetCommandBarButtonGalleryDropDownItem14, Me.spreadsheetCommandBarSubItem30, Me.spreadsheetCommandBarButtonGalleryDropDownItem15, Me.spreadsheetCommandBarButtonGalleryDropDownItem16, Me.spreadsheetCommandBarButtonGalleryDropDownItem17, Me.spreadsheetCommandBarSubItem31, Me.spreadsheetCommandBarButtonGalleryDropDownItem18, Me.spreadsheetCommandBarButtonGalleryDropDownItem19, Me.spreadsheetCommandBarButtonGalleryDropDownItem20, Me.spreadsheetCommandBarButtonGalleryDropDownItem21, Me.spreadsheetCommandBarButtonGalleryDropDownItem22, Me.spreadsheetCommandBarButtonGalleryDropDownItem23, Me.spreadsheetCommandBarButtonGalleryDropDownItem24, Me.renameTableItemCaption1, Me.renameTableItem1, Me.spreadsheetCommandBarCheckItem27, Me.spreadsheetCommandBarCheckItem28, Me.spreadsheetCommandBarCheckItem29, Me.spreadsheetCommandBarCheckItem30, Me.spreadsheetCommandBarCheckItem31, Me.spreadsheetCommandBarCheckItem32, Me.spreadsheetCommandBarCheckItem33, Me.galleryTableStylesItem1, Me.spreadsheetCommandBarButtonItem167, Me.spreadsheetCommandBarButtonItem168, Me.spreadsheetCommandBarButtonItem169, Me.spreadsheetCommandBarButtonItem170, Me.spreadsheetCommandBarButtonItem171, Me.spreadsheetCommandBarButtonItem172, Me.spreadsheetCommandBarButtonItem173, Me.spreadsheetCommandBarSubItem32, Me.spreadsheetCommandBarButtonItem174, Me.spreadsheetCommandBarButtonItem175, Me.spreadsheetCommandBarButtonItem176, Me.spreadsheetCommandBarSubItem33, Me.spreadsheetCommandBarButtonItem177, Me.spreadsheetCommandBarButtonItem178, Me.spreadsheetCommandBarSubItem34, Me.spreadsheetCommandBarButtonItem179, Me.spreadsheetCommandBarButtonItem180, Me.spreadsheetCommandBarButtonItem181, Me.spreadsheetCommandBarButtonItem182, Me.spreadsheetCommandBarSubItem35, Me.spreadsheetCommandBarButtonItem183, Me.spreadsheetCommandBarButtonItem184, Me.spreadsheetCommandBarButtonItem185, Me.spreadsheetCommandBarButtonItem186, Me.spreadsheetCommandBarCheckItem34, Me.spreadsheetCommandBarCheckItem35, Me.spreadsheetCommandBarCheckItem36, Me.spreadsheetCommandBarSubItem36, Me.spreadsheetCommandBarButtonItem187, Me.spreadsheetCommandBarButtonItem188, Me.spreadsheetCommandBarButtonItem189, Me.spreadsheetCommandBarSubItem37, Me.spreadsheetCommandBarButtonItem190, Me.spreadsheetCommandBarButtonItem191, Me.spreadsheetCommandBarButtonItem192, Me.spreadsheetCommandBarButtonItem193, Me.spreadsheetCommandBarSubItem38, Me.spreadsheetCommandBarButtonItem194, Me.spreadsheetCommandBarButtonItem195, Me.spreadsheetCommandBarButtonItem196, Me.spreadsheetCommandBarButtonItem197, Me.spreadsheetCommandBarButtonItem198, Me.spreadsheetCommandBarSubItem39, Me.spreadsheetCommandBarButtonItem199, Me.spreadsheetCommandBarButtonItem200, Me.spreadsheetCommandBarCheckItem37, Me.spreadsheetCommandBarCheckItem38, Me.spreadsheetCommandBarCheckItem39, Me.spreadsheetCommandBarCheckItem40, Me.galleryPivotStylesItem1, Me.spreadsheetCommandBarButtonItem201, Me.spreadsheetCommandBarSubItem40, Me.spreadsheetCommandBarButtonItem202, Me.spreadsheetCommandBarButtonItem203, Me.spreadsheetCommandBarSubItem41, Me.spreadsheetCommandBarButtonItem204, Me.spreadsheetCommandBarButtonItem205, Me.spreadsheetCommandBarButtonItem206, Me.spreadsheetCommandBarCheckItem41, Me.spreadsheetCommandBarCheckItem42, Me.spreadsheetCommandBarCheckItem43, Me.spreadsheetCommandBarSubItem42, Me.spreadsheetCommandBarCheckItem44, Me.spreadsheetCommandBarCheckItem45, Me.spreadsheetCommandBarButtonItem207, Me.spreadsheetCommandBarButtonItem208, Me.spreadsheetCommandBarButtonItem209, Me.spreadsheetCommandBarSubItem43, Me.spreadsheetCommandBarButtonItem210, Me.spreadsheetCommandBarButtonItem211, Me.spreadsheetCommandBarButtonItem212, Me.spreadsheetCommandBarButtonItem213, Me.spreadsheetCommandBarButtonItem214, Me.spreadsheetCommandBarButtonItem215, Me.spreadsheetCommandBarButtonItem216, Me.spreadsheetCommandBarButtonItem217, Me.spreadsheetCommandBarCheckItem46, Me.spreadsheetCommandBarButtonItem218, Me.endModeInfoStaticItem1, Me.averageInfoStaticItem1, Me.countInfoStaticItem1, Me.numericalCountInfoStaticItem1, Me.minInfoStaticItem1, Me.maxInfoStaticItem1, Me.sumInfoStaticItem1, Me.zoomEditItem1, Me.showZoomButtonItem1, Me.progressBarItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 381
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.chartToolsRibbonPageCategory1, Me.tableToolsRibbonPageCategory1, Me.drawingToolsRibbonPageCategory1, Me.pictureToolsRibbonPageCategory1, Me.pivotTableToolsRibbonPageCategory1})
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.fileRibbonPage1, Me.homeRibbonPage1, Me.insertRibbonPage1, Me.pageLayoutRibbonPage1, Me.formulasRibbonPage1, Me.dataRibbonPage1, Me.reviewRibbonPage1, Me.viewRibbonPage1, Me.mailMergeRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemFontEdit1, Me.repositoryItemSpreadsheetFontSizeEdit1, Me.repositoryItemPopupGalleryEdit1, Me.repositoryItemTextEdit1, Me.repositoryItemZoomTrackBar1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1062, 150)
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            ' 
            ' spreadsheetCommandBarButtonItem1
            ' 
            Me.spreadsheetCommandBarButtonItem1.CommandName = "FileNew"
            Me.spreadsheetCommandBarButtonItem1.Id = 1
            Me.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1"
            ' 
            ' spreadsheetCommandBarButtonItem2
            ' 
            Me.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen"
            Me.spreadsheetCommandBarButtonItem2.Id = 2
            Me.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2"
            ' 
            ' spreadsheetCommandBarButtonItem3
            ' 
            Me.spreadsheetCommandBarButtonItem3.CommandName = "FileSave"
            Me.spreadsheetCommandBarButtonItem3.Id = 3
            Me.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3"
            ' 
            ' spreadsheetCommandBarButtonItem4
            ' 
            Me.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs"
            Me.spreadsheetCommandBarButtonItem4.Id = 4
            Me.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4"
            ' 
            ' spreadsheetCommandBarButtonItem5
            ' 
            Me.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint"
            Me.spreadsheetCommandBarButtonItem5.Id = 5
            Me.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5"
            ' 
            ' spreadsheetCommandBarButtonItem6
            ' 
            Me.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint"
            Me.spreadsheetCommandBarButtonItem6.Id = 6
            Me.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6"
            ' 
            ' spreadsheetCommandBarButtonItem7
            ' 
            Me.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview"
            Me.spreadsheetCommandBarButtonItem7.Id = 7
            Me.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7"
            ' 
            ' spreadsheetCommandBarButtonItem8
            ' 
            Me.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo"
            Me.spreadsheetCommandBarButtonItem8.Id = 8
            Me.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8"
            ' 
            ' spreadsheetCommandBarButtonItem9
            ' 
            Me.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo"
            Me.spreadsheetCommandBarButtonItem9.Id = 9
            Me.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9"
            ' 
            ' spreadsheetCommandBarButtonItem10
            ' 
            Me.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt"
            Me.spreadsheetCommandBarButtonItem10.Id = 10
            Me.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10"
            ' 
            ' spreadsheetCommandBarButtonItem11
            ' 
            Me.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties"
            Me.spreadsheetCommandBarButtonItem11.Id = 11
            Me.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11"
            ' 
            ' spreadsheetCommandBarButtonItem12
            ' 
            Me.spreadsheetCommandBarButtonItem12.CommandName = "PasteSelection"
            Me.spreadsheetCommandBarButtonItem12.Id = 22
            Me.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12"
            Me.spreadsheetCommandBarButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem13
            ' 
            Me.spreadsheetCommandBarButtonItem13.CommandName = "CutSelection"
            Me.spreadsheetCommandBarButtonItem13.Id = 23
            Me.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13"
            Me.spreadsheetCommandBarButtonItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem14
            ' 
            Me.spreadsheetCommandBarButtonItem14.CommandName = "CopySelection"
            Me.spreadsheetCommandBarButtonItem14.Id = 24
            Me.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14"
            Me.spreadsheetCommandBarButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem15
            ' 
            Me.spreadsheetCommandBarButtonItem15.CommandName = "ShowPasteSpecialForm"
            Me.spreadsheetCommandBarButtonItem15.Id = 25
            Me.spreadsheetCommandBarButtonItem15.Name = "spreadsheetCommandBarButtonItem15"
            Me.spreadsheetCommandBarButtonItem15.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
            ' 
            ' barButtonGroup1
            ' 
            Me.barButtonGroup1.Id = 12
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem16)
            Me.barButtonGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem17)
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
            ' 
            ' changeFontNameItem1
            ' 
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 26
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' changeFontSizeItem1
            ' 
            Me.changeFontSizeItem1.Edit = Me.repositoryItemSpreadsheetFontSizeEdit1
            Me.changeFontSizeItem1.Id = 27
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' repositoryItemSpreadsheetFontSizeEdit1
            ' 
            Me.repositoryItemSpreadsheetFontSizeEdit1.AutoHeight = False
            Me.repositoryItemSpreadsheetFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpreadsheetFontSizeEdit1.Control = Me.spreadsheetControl1
            Me.repositoryItemSpreadsheetFontSizeEdit1.Name = "repositoryItemSpreadsheetFontSizeEdit1"
            ' 
            ' spreadsheetCommandBarButtonItem16
            ' 
            Me.spreadsheetCommandBarButtonItem16.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
            Me.spreadsheetCommandBarButtonItem16.CommandName = "FormatIncreaseFontSize"
            Me.spreadsheetCommandBarButtonItem16.Id = 28
            Me.spreadsheetCommandBarButtonItem16.Name = "spreadsheetCommandBarButtonItem16"
            Me.spreadsheetCommandBarButtonItem16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem17
            ' 
            Me.spreadsheetCommandBarButtonItem17.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
            Me.spreadsheetCommandBarButtonItem17.CommandName = "FormatDecreaseFontSize"
            Me.spreadsheetCommandBarButtonItem17.Id = 29
            Me.spreadsheetCommandBarButtonItem17.Name = "spreadsheetCommandBarButtonItem17"
            Me.spreadsheetCommandBarButtonItem17.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup2
            ' 
            Me.barButtonGroup2.Id = 13
            Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem2)
            Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem3)
            Me.barButtonGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem4)
            Me.barButtonGroup2.Name = "barButtonGroup2"
            Me.barButtonGroup2.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            ' 
            ' spreadsheetCommandBarCheckItem1
            ' 
            Me.spreadsheetCommandBarCheckItem1.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem1.CommandName = "FormatFontBold"
            Me.spreadsheetCommandBarCheckItem1.Id = 30
            Me.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1"
            Me.spreadsheetCommandBarCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem2
            ' 
            Me.spreadsheetCommandBarCheckItem2.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem2.CommandName = "FormatFontItalic"
            Me.spreadsheetCommandBarCheckItem2.Id = 31
            Me.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2"
            Me.spreadsheetCommandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem3
            ' 
            Me.spreadsheetCommandBarCheckItem3.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem3.CommandName = "FormatFontUnderline"
            Me.spreadsheetCommandBarCheckItem3.Id = 32
            Me.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3"
            Me.spreadsheetCommandBarCheckItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem4
            ' 
            Me.spreadsheetCommandBarCheckItem4.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem4.CommandName = "FormatFontStrikeout"
            Me.spreadsheetCommandBarCheckItem4.Id = 33
            Me.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4"
            Me.spreadsheetCommandBarCheckItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup3
            ' 
            Me.barButtonGroup3.Id = 14
            Me.barButtonGroup3.ItemLinks.Add(Me.spreadsheetCommandBarSubItem1)
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
            ' 
            ' spreadsheetCommandBarSubItem1
            ' 
            Me.spreadsheetCommandBarSubItem1.ButtonGroupTag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
            Me.spreadsheetCommandBarSubItem1.CommandName = "FormatBordersCommandGroup"
            Me.spreadsheetCommandBarSubItem1.Id = 34
            Me.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem26), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem27), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem28), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem29), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem30), New DevExpress.XtraBars.LinkPersistInfo(Me.changeBorderLineColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.changeBorderLineStyleItem1)})
            Me.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1"
            Me.spreadsheetCommandBarSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem18
            ' 
            Me.spreadsheetCommandBarButtonItem18.CommandName = "FormatBottomBorder"
            Me.spreadsheetCommandBarButtonItem18.Id = 35
            Me.spreadsheetCommandBarButtonItem18.Name = "spreadsheetCommandBarButtonItem18"
            ' 
            ' spreadsheetCommandBarButtonItem19
            ' 
            Me.spreadsheetCommandBarButtonItem19.CommandName = "FormatTopBorder"
            Me.spreadsheetCommandBarButtonItem19.Id = 36
            Me.spreadsheetCommandBarButtonItem19.Name = "spreadsheetCommandBarButtonItem19"
            ' 
            ' spreadsheetCommandBarButtonItem20
            ' 
            Me.spreadsheetCommandBarButtonItem20.CommandName = "FormatLeftBorder"
            Me.spreadsheetCommandBarButtonItem20.Id = 37
            Me.spreadsheetCommandBarButtonItem20.Name = "spreadsheetCommandBarButtonItem20"
            ' 
            ' spreadsheetCommandBarButtonItem21
            ' 
            Me.spreadsheetCommandBarButtonItem21.CommandName = "FormatRightBorder"
            Me.spreadsheetCommandBarButtonItem21.Id = 38
            Me.spreadsheetCommandBarButtonItem21.Name = "spreadsheetCommandBarButtonItem21"
            ' 
            ' spreadsheetCommandBarButtonItem22
            ' 
            Me.spreadsheetCommandBarButtonItem22.CommandName = "FormatNoBorders"
            Me.spreadsheetCommandBarButtonItem22.Id = 39
            Me.spreadsheetCommandBarButtonItem22.Name = "spreadsheetCommandBarButtonItem22"
            ' 
            ' spreadsheetCommandBarButtonItem23
            ' 
            Me.spreadsheetCommandBarButtonItem23.CommandName = "FormatAllBorders"
            Me.spreadsheetCommandBarButtonItem23.Id = 40
            Me.spreadsheetCommandBarButtonItem23.Name = "spreadsheetCommandBarButtonItem23"
            ' 
            ' spreadsheetCommandBarButtonItem24
            ' 
            Me.spreadsheetCommandBarButtonItem24.CommandName = "FormatOutsideBorders"
            Me.spreadsheetCommandBarButtonItem24.Id = 41
            Me.spreadsheetCommandBarButtonItem24.Name = "spreadsheetCommandBarButtonItem24"
            ' 
            ' spreadsheetCommandBarButtonItem25
            ' 
            Me.spreadsheetCommandBarButtonItem25.CommandName = "FormatThickBorder"
            Me.spreadsheetCommandBarButtonItem25.Id = 42
            Me.spreadsheetCommandBarButtonItem25.Name = "spreadsheetCommandBarButtonItem25"
            ' 
            ' spreadsheetCommandBarButtonItem26
            ' 
            Me.spreadsheetCommandBarButtonItem26.CommandName = "FormatBottomDoubleBorder"
            Me.spreadsheetCommandBarButtonItem26.Id = 43
            Me.spreadsheetCommandBarButtonItem26.Name = "spreadsheetCommandBarButtonItem26"
            ' 
            ' spreadsheetCommandBarButtonItem27
            ' 
            Me.spreadsheetCommandBarButtonItem27.CommandName = "FormatBottomThickBorder"
            Me.spreadsheetCommandBarButtonItem27.Id = 44
            Me.spreadsheetCommandBarButtonItem27.Name = "spreadsheetCommandBarButtonItem27"
            ' 
            ' spreadsheetCommandBarButtonItem28
            ' 
            Me.spreadsheetCommandBarButtonItem28.CommandName = "FormatTopAndBottomBorder"
            Me.spreadsheetCommandBarButtonItem28.Id = 45
            Me.spreadsheetCommandBarButtonItem28.Name = "spreadsheetCommandBarButtonItem28"
            ' 
            ' spreadsheetCommandBarButtonItem29
            ' 
            Me.spreadsheetCommandBarButtonItem29.CommandName = "FormatTopAndThickBottomBorder"
            Me.spreadsheetCommandBarButtonItem29.Id = 46
            Me.spreadsheetCommandBarButtonItem29.Name = "spreadsheetCommandBarButtonItem29"
            ' 
            ' spreadsheetCommandBarButtonItem30
            ' 
            Me.spreadsheetCommandBarButtonItem30.CommandName = "FormatTopAndDoubleBottomBorder"
            Me.spreadsheetCommandBarButtonItem30.Id = 47
            Me.spreadsheetCommandBarButtonItem30.Name = "spreadsheetCommandBarButtonItem30"
            ' 
            ' changeBorderLineColorItem1
            ' 
            Me.changeBorderLineColorItem1.ActAsDropDown = True
            Me.changeBorderLineColorItem1.Id = 48
            Me.changeBorderLineColorItem1.Name = "changeBorderLineColorItem1"
            ' 
            ' changeBorderLineStyleItem1
            ' 
            Me.changeBorderLineStyleItem1.DropDownControl = Me.commandBarGalleryDropDown73
            Me.changeBorderLineStyleItem1.Id = 49
            Me.changeBorderLineStyleItem1.Name = "changeBorderLineStyleItem1"
            ' 
            ' commandBarGalleryDropDown73
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown73.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown73.Gallery.ColumnCount = 1
            Me.commandBarGalleryDropDown73.Gallery.DrawImageBackground = False
            Me.commandBarGalleryDropDown73.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.commandBarGalleryDropDown73.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown73.Gallery.ItemSize = New System.Drawing.Size(136, 26)
            Me.commandBarGalleryDropDown73.Gallery.RowCount = 14
            Me.commandBarGalleryDropDown73.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown73.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown73.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown73.Name = "commandBarGalleryDropDown73"
            Me.commandBarGalleryDropDown73.Ribbon = Me.ribbonControl1
            ' 
            ' barButtonGroup4
            ' 
            Me.barButtonGroup4.Id = 15
            Me.barButtonGroup4.ItemLinks.Add(Me.changeCellFillColorItem1)
            Me.barButtonGroup4.ItemLinks.Add(Me.changeFontColorItem1)
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}"
            ' 
            ' changeCellFillColorItem1
            ' 
            Me.changeCellFillColorItem1.Id = 50
            Me.changeCellFillColorItem1.Name = "changeCellFillColorItem1"
            ' 
            ' changeFontColorItem1
            ' 
            Me.changeFontColorItem1.Id = 51
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' barButtonGroup5
            ' 
            Me.barButtonGroup5.Id = 16
            Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem5)
            Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem6)
            Me.barButtonGroup5.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem7)
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            ' 
            ' spreadsheetCommandBarCheckItem5
            ' 
            Me.spreadsheetCommandBarCheckItem5.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            Me.spreadsheetCommandBarCheckItem5.CommandName = "FormatAlignmentTop"
            Me.spreadsheetCommandBarCheckItem5.Id = 52
            Me.spreadsheetCommandBarCheckItem5.Name = "spreadsheetCommandBarCheckItem5"
            Me.spreadsheetCommandBarCheckItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem6
            ' 
            Me.spreadsheetCommandBarCheckItem6.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            Me.spreadsheetCommandBarCheckItem6.CommandName = "FormatAlignmentMiddle"
            Me.spreadsheetCommandBarCheckItem6.Id = 53
            Me.spreadsheetCommandBarCheckItem6.Name = "spreadsheetCommandBarCheckItem6"
            Me.spreadsheetCommandBarCheckItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem7
            ' 
            Me.spreadsheetCommandBarCheckItem7.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            Me.spreadsheetCommandBarCheckItem7.CommandName = "FormatAlignmentBottom"
            Me.spreadsheetCommandBarCheckItem7.Id = 54
            Me.spreadsheetCommandBarCheckItem7.Name = "spreadsheetCommandBarCheckItem7"
            Me.spreadsheetCommandBarCheckItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup6
            ' 
            Me.barButtonGroup6.Id = 17
            Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem8)
            Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem9)
            Me.barButtonGroup6.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem10)
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            ' 
            ' spreadsheetCommandBarCheckItem8
            ' 
            Me.spreadsheetCommandBarCheckItem8.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            Me.spreadsheetCommandBarCheckItem8.CommandName = "FormatAlignmentLeft"
            Me.spreadsheetCommandBarCheckItem8.Id = 55
            Me.spreadsheetCommandBarCheckItem8.Name = "spreadsheetCommandBarCheckItem8"
            Me.spreadsheetCommandBarCheckItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem9
            ' 
            Me.spreadsheetCommandBarCheckItem9.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            Me.spreadsheetCommandBarCheckItem9.CommandName = "FormatAlignmentCenter"
            Me.spreadsheetCommandBarCheckItem9.Id = 56
            Me.spreadsheetCommandBarCheckItem9.Name = "spreadsheetCommandBarCheckItem9"
            Me.spreadsheetCommandBarCheckItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem10
            ' 
            Me.spreadsheetCommandBarCheckItem10.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            Me.spreadsheetCommandBarCheckItem10.CommandName = "FormatAlignmentRight"
            Me.spreadsheetCommandBarCheckItem10.Id = 57
            Me.spreadsheetCommandBarCheckItem10.Name = "spreadsheetCommandBarCheckItem10"
            Me.spreadsheetCommandBarCheckItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup7
            ' 
            Me.barButtonGroup7.Id = 18
            Me.barButtonGroup7.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem31)
            Me.barButtonGroup7.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem32)
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
            ' 
            ' spreadsheetCommandBarButtonItem31
            ' 
            Me.spreadsheetCommandBarButtonItem31.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
            Me.spreadsheetCommandBarButtonItem31.CommandName = "FormatDecreaseIndent"
            Me.spreadsheetCommandBarButtonItem31.Id = 58
            Me.spreadsheetCommandBarButtonItem31.Name = "spreadsheetCommandBarButtonItem31"
            Me.spreadsheetCommandBarButtonItem31.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem32
            ' 
            Me.spreadsheetCommandBarButtonItem32.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
            Me.spreadsheetCommandBarButtonItem32.CommandName = "FormatIncreaseIndent"
            Me.spreadsheetCommandBarButtonItem32.Id = 59
            Me.spreadsheetCommandBarButtonItem32.Name = "spreadsheetCommandBarButtonItem32"
            Me.spreadsheetCommandBarButtonItem32.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem11
            ' 
            Me.spreadsheetCommandBarCheckItem11.CommandName = "FormatWrapText"
            Me.spreadsheetCommandBarCheckItem11.Id = 60
            Me.spreadsheetCommandBarCheckItem11.Name = "spreadsheetCommandBarCheckItem11"
            Me.spreadsheetCommandBarCheckItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarSubItem2
            ' 
            Me.spreadsheetCommandBarSubItem2.CommandName = "EditingMergeCellsCommandGroup"
            Me.spreadsheetCommandBarSubItem2.Id = 61
            Me.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem33), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem34), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem35)})
            Me.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2"
            Me.spreadsheetCommandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarCheckItem12
            ' 
            Me.spreadsheetCommandBarCheckItem12.CommandName = "EditingMergeAndCenterCells"
            Me.spreadsheetCommandBarCheckItem12.Id = 62
            Me.spreadsheetCommandBarCheckItem12.Name = "spreadsheetCommandBarCheckItem12"
            ' 
            ' spreadsheetCommandBarButtonItem33
            ' 
            Me.spreadsheetCommandBarButtonItem33.CommandName = "EditingMergeCellsAcross"
            Me.spreadsheetCommandBarButtonItem33.Id = 63
            Me.spreadsheetCommandBarButtonItem33.Name = "spreadsheetCommandBarButtonItem33"
            ' 
            ' spreadsheetCommandBarButtonItem34
            ' 
            Me.spreadsheetCommandBarButtonItem34.CommandName = "EditingMergeCells"
            Me.spreadsheetCommandBarButtonItem34.Id = 64
            Me.spreadsheetCommandBarButtonItem34.Name = "spreadsheetCommandBarButtonItem34"
            ' 
            ' spreadsheetCommandBarButtonItem35
            ' 
            Me.spreadsheetCommandBarButtonItem35.CommandName = "EditingUnmergeCells"
            Me.spreadsheetCommandBarButtonItem35.Id = 65
            Me.spreadsheetCommandBarButtonItem35.Name = "spreadsheetCommandBarButtonItem35"
            ' 
            ' barButtonGroup8
            ' 
            Me.barButtonGroup8.Id = 19
            Me.barButtonGroup8.ItemLinks.Add(Me.changeNumberFormatItem1)
            Me.barButtonGroup8.Name = "barButtonGroup8"
            Me.barButtonGroup8.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            ' 
            ' changeNumberFormatItem1
            ' 
            Me.changeNumberFormatItem1.Edit = Me.repositoryItemPopupGalleryEdit1
            Me.changeNumberFormatItem1.Id = 66
            Me.changeNumberFormatItem1.Name = "changeNumberFormatItem1"
            ' 
            ' repositoryItemPopupGalleryEdit1
            ' 
            Me.repositoryItemPopupGalleryEdit1.AutoHeight = False
            Me.repositoryItemPopupGalleryEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            ' 
            ' 
            ' 
            Me.repositoryItemPopupGalleryEdit1.Gallery.AllowFilter = False
            Me.repositoryItemPopupGalleryEdit1.Gallery.AutoFitColumns = False
            Me.repositoryItemPopupGalleryEdit1.Gallery.ColumnCount = 1
            Me.repositoryItemPopupGalleryEdit1.Gallery.FixedImageSize = False
            spreadsheetCommandGalleryItem13.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem13.CaptionAsValue = True
            spreadsheetCommandGalleryItem13.Checked = True
            spreadsheetCommandGalleryItem13.CommandName = "FormatNumberGeneral"
            spreadsheetCommandGalleryItem13.IsEmptyHint = True
            spreadsheetCommandGalleryItem14.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem14.CaptionAsValue = True
            spreadsheetCommandGalleryItem14.CommandName = "FormatNumberDecimal"
            spreadsheetCommandGalleryItem14.IsEmptyHint = True
            spreadsheetCommandGalleryItem15.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem15.CaptionAsValue = True
            spreadsheetCommandGalleryItem15.CommandName = "FormatNumberAccountingCurrency"
            spreadsheetCommandGalleryItem15.IsEmptyHint = True
            spreadsheetCommandGalleryItem16.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem16.CaptionAsValue = True
            spreadsheetCommandGalleryItem16.CommandName = "FormatNumberAccountingRegular"
            spreadsheetCommandGalleryItem16.IsEmptyHint = True
            spreadsheetCommandGalleryItem17.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem17.CaptionAsValue = True
            spreadsheetCommandGalleryItem17.CommandName = "FormatNumberShortDate"
            spreadsheetCommandGalleryItem17.IsEmptyHint = True
            spreadsheetCommandGalleryItem18.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem18.CaptionAsValue = True
            spreadsheetCommandGalleryItem18.CommandName = "FormatNumberLongDate"
            spreadsheetCommandGalleryItem18.IsEmptyHint = True
            spreadsheetCommandGalleryItem19.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem19.CaptionAsValue = True
            spreadsheetCommandGalleryItem19.CommandName = "FormatNumberTime"
            spreadsheetCommandGalleryItem19.IsEmptyHint = True
            spreadsheetCommandGalleryItem20.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem20.CaptionAsValue = True
            spreadsheetCommandGalleryItem20.CommandName = "FormatNumberPercentage"
            spreadsheetCommandGalleryItem20.IsEmptyHint = True
            spreadsheetCommandGalleryItem21.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem21.CaptionAsValue = True
            spreadsheetCommandGalleryItem21.CommandName = "FormatNumberFraction"
            spreadsheetCommandGalleryItem21.IsEmptyHint = True
            spreadsheetCommandGalleryItem22.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem22.CaptionAsValue = True
            spreadsheetCommandGalleryItem22.CommandName = "FormatNumberScientific"
            spreadsheetCommandGalleryItem22.IsEmptyHint = True
            spreadsheetCommandGalleryItem23.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem23.CaptionAsValue = True
            spreadsheetCommandGalleryItem23.CommandName = "FormatNumberText"
            spreadsheetCommandGalleryItem23.IsEmptyHint = True
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem13, spreadsheetCommandGalleryItem14, spreadsheetCommandGalleryItem15, spreadsheetCommandGalleryItem16, spreadsheetCommandGalleryItem17, spreadsheetCommandGalleryItem18, spreadsheetCommandGalleryItem19, spreadsheetCommandGalleryItem20, spreadsheetCommandGalleryItem21, spreadsheetCommandGalleryItem22, spreadsheetCommandGalleryItem23})
            Me.repositoryItemPopupGalleryEdit1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            Me.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.repositoryItemPopupGalleryEdit1.Gallery.RowCount = 11
            Me.repositoryItemPopupGalleryEdit1.Gallery.ShowGroupCaption = False
            Me.repositoryItemPopupGalleryEdit1.Gallery.ShowItemText = True
            Me.repositoryItemPopupGalleryEdit1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
            Me.repositoryItemPopupGalleryEdit1.Gallery.StretchItems = True
            Me.repositoryItemPopupGalleryEdit1.Name = "repositoryItemPopupGalleryEdit1"
            Me.repositoryItemPopupGalleryEdit1.ShowButtons = False
            Me.repositoryItemPopupGalleryEdit1.ShowPopupCloseButton = False
            Me.repositoryItemPopupGalleryEdit1.ShowSizeGrip = False
            ' 
            ' barButtonGroup9
            ' 
            Me.barButtonGroup9.Id = 20
            Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarSubItem3)
            Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem42)
            Me.barButtonGroup9.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem43)
            Me.barButtonGroup9.Name = "barButtonGroup9"
            Me.barButtonGroup9.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            ' 
            ' spreadsheetCommandBarSubItem3
            ' 
            Me.spreadsheetCommandBarSubItem3.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            Me.spreadsheetCommandBarSubItem3.CommandName = "FormatNumberAccountingCommandGroup"
            Me.spreadsheetCommandBarSubItem3.Id = 67
            Me.spreadsheetCommandBarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem36), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem37), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem38), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem39), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem40), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem41)})
            Me.spreadsheetCommandBarSubItem3.Name = "spreadsheetCommandBarSubItem3"
            Me.spreadsheetCommandBarSubItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem36
            ' 
            Me.spreadsheetCommandBarButtonItem36.CommandName = "FormatNumberAccountingDefault"
            Me.spreadsheetCommandBarButtonItem36.Id = 68
            Me.spreadsheetCommandBarButtonItem36.Name = "spreadsheetCommandBarButtonItem36"
            ' 
            ' spreadsheetCommandBarButtonItem37
            ' 
            Me.spreadsheetCommandBarButtonItem37.CommandName = "FormatNumberAccountingUS"
            Me.spreadsheetCommandBarButtonItem37.Id = 69
            Me.spreadsheetCommandBarButtonItem37.Name = "spreadsheetCommandBarButtonItem37"
            ' 
            ' spreadsheetCommandBarButtonItem38
            ' 
            Me.spreadsheetCommandBarButtonItem38.CommandName = "FormatNumberAccountingUK"
            Me.spreadsheetCommandBarButtonItem38.Id = 70
            Me.spreadsheetCommandBarButtonItem38.Name = "spreadsheetCommandBarButtonItem38"
            ' 
            ' spreadsheetCommandBarButtonItem39
            ' 
            Me.spreadsheetCommandBarButtonItem39.CommandName = "FormatNumberAccountingEuro"
            Me.spreadsheetCommandBarButtonItem39.Id = 71
            Me.spreadsheetCommandBarButtonItem39.Name = "spreadsheetCommandBarButtonItem39"
            ' 
            ' spreadsheetCommandBarButtonItem40
            ' 
            Me.spreadsheetCommandBarButtonItem40.CommandName = "FormatNumberAccountingPRC"
            Me.spreadsheetCommandBarButtonItem40.Id = 72
            Me.spreadsheetCommandBarButtonItem40.Name = "spreadsheetCommandBarButtonItem40"
            ' 
            ' spreadsheetCommandBarButtonItem41
            ' 
            Me.spreadsheetCommandBarButtonItem41.CommandName = "FormatNumberAccountingSwiss"
            Me.spreadsheetCommandBarButtonItem41.Id = 73
            Me.spreadsheetCommandBarButtonItem41.Name = "spreadsheetCommandBarButtonItem41"
            ' 
            ' spreadsheetCommandBarButtonItem42
            ' 
            Me.spreadsheetCommandBarButtonItem42.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            Me.spreadsheetCommandBarButtonItem42.CommandName = "FormatNumberPercent"
            Me.spreadsheetCommandBarButtonItem42.Id = 74
            Me.spreadsheetCommandBarButtonItem42.Name = "spreadsheetCommandBarButtonItem42"
            Me.spreadsheetCommandBarButtonItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem43
            ' 
            Me.spreadsheetCommandBarButtonItem43.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            Me.spreadsheetCommandBarButtonItem43.CommandName = "FormatNumberAccounting"
            Me.spreadsheetCommandBarButtonItem43.Id = 75
            Me.spreadsheetCommandBarButtonItem43.Name = "spreadsheetCommandBarButtonItem43"
            Me.spreadsheetCommandBarButtonItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup10
            ' 
            Me.barButtonGroup10.Id = 21
            Me.barButtonGroup10.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem44)
            Me.barButtonGroup10.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem45)
            Me.barButtonGroup10.Name = "barButtonGroup10"
            Me.barButtonGroup10.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
            ' 
            ' spreadsheetCommandBarButtonItem44
            ' 
            Me.spreadsheetCommandBarButtonItem44.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
            Me.spreadsheetCommandBarButtonItem44.CommandName = "FormatNumberIncreaseDecimal"
            Me.spreadsheetCommandBarButtonItem44.Id = 76
            Me.spreadsheetCommandBarButtonItem44.Name = "spreadsheetCommandBarButtonItem44"
            Me.spreadsheetCommandBarButtonItem44.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem45
            ' 
            Me.spreadsheetCommandBarButtonItem45.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
            Me.spreadsheetCommandBarButtonItem45.CommandName = "FormatNumberDecreaseDecimal"
            Me.spreadsheetCommandBarButtonItem45.Id = 77
            Me.spreadsheetCommandBarButtonItem45.Name = "spreadsheetCommandBarButtonItem45"
            Me.spreadsheetCommandBarButtonItem45.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarSubItem7
            ' 
            Me.spreadsheetCommandBarSubItem7.CommandName = "ConditionalFormattingCommandGroup"
            Me.spreadsheetCommandBarSubItem7.Id = 78
            Me.spreadsheetCommandBarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem59), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem62)})
            Me.spreadsheetCommandBarSubItem7.Name = "spreadsheetCommandBarSubItem7"
            ' 
            ' spreadsheetCommandBarSubItem4
            ' 
            Me.spreadsheetCommandBarSubItem4.CommandName = "ConditionalFormattingHighlightCellsRuleCommandGroup"
            Me.spreadsheetCommandBarSubItem4.Id = 86
            Me.spreadsheetCommandBarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem46), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem47), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem48), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem49), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem50), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem51), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem52)})
            Me.spreadsheetCommandBarSubItem4.Name = "spreadsheetCommandBarSubItem4"
            ' 
            ' spreadsheetCommandBarButtonItem46
            ' 
            Me.spreadsheetCommandBarButtonItem46.CommandName = "ConditionalFormattingGreaterThanRuleCommand"
            Me.spreadsheetCommandBarButtonItem46.Id = 79
            Me.spreadsheetCommandBarButtonItem46.Name = "spreadsheetCommandBarButtonItem46"
            Me.spreadsheetCommandBarButtonItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem47
            ' 
            Me.spreadsheetCommandBarButtonItem47.CommandName = "ConditionalFormattingLessThanRuleCommand"
            Me.spreadsheetCommandBarButtonItem47.Id = 80
            Me.spreadsheetCommandBarButtonItem47.Name = "spreadsheetCommandBarButtonItem47"
            Me.spreadsheetCommandBarButtonItem47.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem48
            ' 
            Me.spreadsheetCommandBarButtonItem48.CommandName = "ConditionalFormattingBetweenRuleCommand"
            Me.spreadsheetCommandBarButtonItem48.Id = 81
            Me.spreadsheetCommandBarButtonItem48.Name = "spreadsheetCommandBarButtonItem48"
            Me.spreadsheetCommandBarButtonItem48.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem49
            ' 
            Me.spreadsheetCommandBarButtonItem49.CommandName = "ConditionalFormattingEqualToRuleCommand"
            Me.spreadsheetCommandBarButtonItem49.Id = 82
            Me.spreadsheetCommandBarButtonItem49.Name = "spreadsheetCommandBarButtonItem49"
            Me.spreadsheetCommandBarButtonItem49.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem50
            ' 
            Me.spreadsheetCommandBarButtonItem50.CommandName = "ConditionalFormattingTextContainsRuleCommand"
            Me.spreadsheetCommandBarButtonItem50.Id = 83
            Me.spreadsheetCommandBarButtonItem50.Name = "spreadsheetCommandBarButtonItem50"
            Me.spreadsheetCommandBarButtonItem50.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem51
            ' 
            Me.spreadsheetCommandBarButtonItem51.CommandName = "ConditionalFormattingDateOccurringRuleCommand"
            Me.spreadsheetCommandBarButtonItem51.Id = 84
            Me.spreadsheetCommandBarButtonItem51.Name = "spreadsheetCommandBarButtonItem51"
            Me.spreadsheetCommandBarButtonItem51.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem52
            ' 
            Me.spreadsheetCommandBarButtonItem52.CommandName = "ConditionalFormattingDuplicateValuesRuleCommand"
            Me.spreadsheetCommandBarButtonItem52.Id = 85
            Me.spreadsheetCommandBarButtonItem52.Name = "spreadsheetCommandBarButtonItem52"
            Me.spreadsheetCommandBarButtonItem52.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarSubItem5
            ' 
            Me.spreadsheetCommandBarSubItem5.CommandName = "ConditionalFormattingTopBottomRuleCommandGroup"
            Me.spreadsheetCommandBarSubItem5.Id = 93
            Me.spreadsheetCommandBarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem53), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem54), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem55), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem56), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem57), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem58)})
            Me.spreadsheetCommandBarSubItem5.Name = "spreadsheetCommandBarSubItem5"
            ' 
            ' spreadsheetCommandBarButtonItem53
            ' 
            Me.spreadsheetCommandBarButtonItem53.CommandName = "ConditionalFormattingTop10RuleCommand"
            Me.spreadsheetCommandBarButtonItem53.Id = 87
            Me.spreadsheetCommandBarButtonItem53.Name = "spreadsheetCommandBarButtonItem53"
            Me.spreadsheetCommandBarButtonItem53.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem54
            ' 
            Me.spreadsheetCommandBarButtonItem54.CommandName = "ConditionalFormattingTop10PercentRuleCommand"
            Me.spreadsheetCommandBarButtonItem54.Id = 88
            Me.spreadsheetCommandBarButtonItem54.Name = "spreadsheetCommandBarButtonItem54"
            Me.spreadsheetCommandBarButtonItem54.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem55
            ' 
            Me.spreadsheetCommandBarButtonItem55.CommandName = "ConditionalFormattingBottom10RuleCommand"
            Me.spreadsheetCommandBarButtonItem55.Id = 89
            Me.spreadsheetCommandBarButtonItem55.Name = "spreadsheetCommandBarButtonItem55"
            Me.spreadsheetCommandBarButtonItem55.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem56
            ' 
            Me.spreadsheetCommandBarButtonItem56.CommandName = "ConditionalFormattingBottom10PercentRuleCommand"
            Me.spreadsheetCommandBarButtonItem56.Id = 90
            Me.spreadsheetCommandBarButtonItem56.Name = "spreadsheetCommandBarButtonItem56"
            Me.spreadsheetCommandBarButtonItem56.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem57
            ' 
            Me.spreadsheetCommandBarButtonItem57.CommandName = "ConditionalFormattingAboveAverageRuleCommand"
            Me.spreadsheetCommandBarButtonItem57.Id = 91
            Me.spreadsheetCommandBarButtonItem57.Name = "spreadsheetCommandBarButtonItem57"
            Me.spreadsheetCommandBarButtonItem57.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem58
            ' 
            Me.spreadsheetCommandBarButtonItem58.CommandName = "ConditionalFormattingBelowAverageRuleCommand"
            Me.spreadsheetCommandBarButtonItem58.Id = 92
            Me.spreadsheetCommandBarButtonItem58.Name = "spreadsheetCommandBarButtonItem58"
            Me.spreadsheetCommandBarButtonItem58.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem1
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.CommandName = "ConditionalFormattingDataBarsCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.DropDownControl = Me.commandBarGalleryDropDown74
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.Id = 94
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.Name = "spreadsheetCommandBarButtonGalleryDropDownItem1"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarGalleryDropDown74
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown74.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup3.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup"
            spreadsheetCommandGalleryItem24.CommandName = "ConditionalFormattingDataBarGradientBlue"
            spreadsheetCommandGalleryItem25.CommandName = "ConditionalFormattingDataBarGradientGreen"
            spreadsheetCommandGalleryItem26.CommandName = "ConditionalFormattingDataBarGradientRed"
            spreadsheetCommandGalleryItem27.CommandName = "ConditionalFormattingDataBarGradientOrange"
            spreadsheetCommandGalleryItem28.CommandName = "ConditionalFormattingDataBarGradientLightBlue"
            spreadsheetCommandGalleryItem29.CommandName = "ConditionalFormattingDataBarGradientPurple"
            spreadsheetCommandGalleryItemGroup3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem24, spreadsheetCommandGalleryItem25, spreadsheetCommandGalleryItem26, spreadsheetCommandGalleryItem27, spreadsheetCommandGalleryItem28, spreadsheetCommandGalleryItem29})
            spreadsheetCommandGalleryItemGroup4.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup"
            spreadsheetCommandGalleryItem30.CommandName = "ConditionalFormattingDataBarSolidBlue"
            spreadsheetCommandGalleryItem31.CommandName = "ConditionalFormattingDataBarSolidGreen"
            spreadsheetCommandGalleryItem32.CommandName = "ConditionalFormattingDataBarSolidRed"
            spreadsheetCommandGalleryItem33.CommandName = "ConditionalFormattingDataBarSolidOrange"
            spreadsheetCommandGalleryItem34.CommandName = "ConditionalFormattingDataBarSolidLightBlue"
            spreadsheetCommandGalleryItem35.CommandName = "ConditionalFormattingDataBarSolidPurple"
            spreadsheetCommandGalleryItemGroup4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem30, spreadsheetCommandGalleryItem31, spreadsheetCommandGalleryItem32, spreadsheetCommandGalleryItem33, spreadsheetCommandGalleryItem34, spreadsheetCommandGalleryItem35})
            Me.commandBarGalleryDropDown74.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup3, spreadsheetCommandGalleryItemGroup4})
            Me.commandBarGalleryDropDown74.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown74.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown74.Name = "commandBarGalleryDropDown74"
            Me.commandBarGalleryDropDown74.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem2
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.CommandName = "ConditionalFormattingColorScalesCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.DropDownControl = Me.commandBarGalleryDropDown75
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.Id = 95
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.Name = "spreadsheetCommandBarButtonGalleryDropDownItem2"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarGalleryDropDown75
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown75.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup5.CommandName = "ConditionalFormattingColorScalesCommandGroup"
            spreadsheetCommandGalleryItem36.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
            spreadsheetCommandGalleryItem37.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
            spreadsheetCommandGalleryItem38.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
            spreadsheetCommandGalleryItem39.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
            spreadsheetCommandGalleryItem40.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
            spreadsheetCommandGalleryItem41.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
            spreadsheetCommandGalleryItem42.CommandName = "ConditionalFormattingColorScaleWhiteRed"
            spreadsheetCommandGalleryItem43.CommandName = "ConditionalFormattingColorScaleRedWhite"
            spreadsheetCommandGalleryItem44.CommandName = "ConditionalFormattingColorScaleGreenWhite"
            spreadsheetCommandGalleryItem45.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
            spreadsheetCommandGalleryItem46.CommandName = "ConditionalFormattingColorScaleGreenYellow"
            spreadsheetCommandGalleryItem47.CommandName = "ConditionalFormattingColorScaleYellowGreen"
            spreadsheetCommandGalleryItemGroup5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem36, spreadsheetCommandGalleryItem37, spreadsheetCommandGalleryItem38, spreadsheetCommandGalleryItem39, spreadsheetCommandGalleryItem40, spreadsheetCommandGalleryItem41, spreadsheetCommandGalleryItem42, spreadsheetCommandGalleryItem43, spreadsheetCommandGalleryItem44, spreadsheetCommandGalleryItem45, spreadsheetCommandGalleryItem46, spreadsheetCommandGalleryItem47})
            Me.commandBarGalleryDropDown75.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup5})
            Me.commandBarGalleryDropDown75.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown75.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown75.Name = "commandBarGalleryDropDown75"
            Me.commandBarGalleryDropDown75.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem3
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.CommandName = "ConditionalFormattingIconSetsCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.DropDownControl = Me.commandBarGalleryDropDown76
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.Id = 96
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.Name = "spreadsheetCommandBarButtonGalleryDropDownItem3"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarGalleryDropDown76
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown76.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup6.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
            spreadsheetCommandGalleryItem48.CommandName = "ConditionalFormattingIconSetArrows3Colored"
            spreadsheetCommandGalleryItem49.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
            spreadsheetCommandGalleryItem50.CommandName = "ConditionalFormattingIconSetArrows4Colored"
            spreadsheetCommandGalleryItem51.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
            spreadsheetCommandGalleryItem52.CommandName = "ConditionalFormattingIconSetArrows5Colored"
            spreadsheetCommandGalleryItem53.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
            spreadsheetCommandGalleryItem54.CommandName = "ConditionalFormattingIconSetTriangles3"
            spreadsheetCommandGalleryItemGroup6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem48, spreadsheetCommandGalleryItem49, spreadsheetCommandGalleryItem50, spreadsheetCommandGalleryItem51, spreadsheetCommandGalleryItem52, spreadsheetCommandGalleryItem53, spreadsheetCommandGalleryItem54})
            spreadsheetCommandGalleryItemGroup7.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
            spreadsheetCommandGalleryItem55.CommandName = "ConditionalFormattingIconSetTrafficLights3"
            spreadsheetCommandGalleryItem56.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
            spreadsheetCommandGalleryItem57.CommandName = "ConditionalFormattingIconSetTrafficLights4"
            spreadsheetCommandGalleryItem58.CommandName = "ConditionalFormattingIconSetSigns3"
            spreadsheetCommandGalleryItem59.CommandName = "ConditionalFormattingIconSetRedToBlack"
            spreadsheetCommandGalleryItemGroup7.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem55, spreadsheetCommandGalleryItem56, spreadsheetCommandGalleryItem57, spreadsheetCommandGalleryItem58, spreadsheetCommandGalleryItem59})
            spreadsheetCommandGalleryItemGroup8.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
            spreadsheetCommandGalleryItem60.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
            spreadsheetCommandGalleryItem61.CommandName = "ConditionalFormattingIconSetSymbols3"
            spreadsheetCommandGalleryItem62.CommandName = "ConditionalFormattingIconSetFlags3"
            spreadsheetCommandGalleryItemGroup8.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem60, spreadsheetCommandGalleryItem61, spreadsheetCommandGalleryItem62})
            spreadsheetCommandGalleryItemGroup9.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
            spreadsheetCommandGalleryItem63.CommandName = "ConditionalFormattingIconSetStars3"
            spreadsheetCommandGalleryItem64.CommandName = "ConditionalFormattingIconSetRatings4"
            spreadsheetCommandGalleryItem65.CommandName = "ConditionalFormattingIconSetRatings5"
            spreadsheetCommandGalleryItem66.CommandName = "ConditionalFormattingIconSetQuarters5"
            spreadsheetCommandGalleryItem67.CommandName = "ConditionalFormattingIconSetBoxes5"
            spreadsheetCommandGalleryItemGroup9.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem63, spreadsheetCommandGalleryItem64, spreadsheetCommandGalleryItem65, spreadsheetCommandGalleryItem66, spreadsheetCommandGalleryItem67})
            Me.commandBarGalleryDropDown76.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup6, spreadsheetCommandGalleryItemGroup7, spreadsheetCommandGalleryItemGroup8, spreadsheetCommandGalleryItemGroup9})
            Me.commandBarGalleryDropDown76.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown76.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown76.Name = "commandBarGalleryDropDown76"
            Me.commandBarGalleryDropDown76.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonItem59
            ' 
            Me.spreadsheetCommandBarButtonItem59.CommandName = "NewConditionalFormattingRule"
            Me.spreadsheetCommandBarButtonItem59.Id = 97
            Me.spreadsheetCommandBarButtonItem59.Name = "spreadsheetCommandBarButtonItem59"
            ' 
            ' spreadsheetCommandBarSubItem6
            ' 
            Me.spreadsheetCommandBarSubItem6.CommandName = "ConditionalFormattingRemoveCommandGroup"
            Me.spreadsheetCommandBarSubItem6.Id = 100
            Me.spreadsheetCommandBarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem60), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem61)})
            Me.spreadsheetCommandBarSubItem6.Name = "spreadsheetCommandBarSubItem6"
            ' 
            ' spreadsheetCommandBarButtonItem60
            ' 
            Me.spreadsheetCommandBarButtonItem60.CommandName = "ConditionalFormattingRemoveFromSheet"
            Me.spreadsheetCommandBarButtonItem60.Id = 98
            Me.spreadsheetCommandBarButtonItem60.Name = "spreadsheetCommandBarButtonItem60"
            ' 
            ' spreadsheetCommandBarButtonItem61
            ' 
            Me.spreadsheetCommandBarButtonItem61.CommandName = "ConditionalFormattingRemove"
            Me.spreadsheetCommandBarButtonItem61.Id = 99
            Me.spreadsheetCommandBarButtonItem61.Name = "spreadsheetCommandBarButtonItem61"
            ' 
            ' spreadsheetCommandBarButtonItem62
            ' 
            Me.spreadsheetCommandBarButtonItem62.CommandName = "ConditionalFormattingRulesManager"
            Me.spreadsheetCommandBarButtonItem62.Id = 101
            Me.spreadsheetCommandBarButtonItem62.Name = "spreadsheetCommandBarButtonItem62"
            ' 
            ' galleryFormatAsTableItem1
            ' 
            Me.galleryFormatAsTableItem1.DropDownControl = Me.commandBarGalleryDropDown77
            Me.galleryFormatAsTableItem1.Id = 102
            Me.galleryFormatAsTableItem1.Name = "galleryFormatAsTableItem1"
            ' 
            ' commandBarGalleryDropDown77
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown77.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown77.Gallery.ColumnCount = 7
            Me.commandBarGalleryDropDown77.Gallery.DrawImageBackground = False
            Me.commandBarGalleryDropDown77.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown77.Gallery.ItemSize = New System.Drawing.Size(73, 58)
            Me.commandBarGalleryDropDown77.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown77.Name = "commandBarGalleryDropDown77"
            Me.commandBarGalleryDropDown77.Ribbon = Me.ribbonControl1
            ' 
            ' galleryChangeStyleItem1
            ' 
            ' 
            ' 
            ' 
            Me.galleryChangeStyleItem1.Gallery.DrawImageBackground = False
            Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.galleryChangeStyleItem1.Gallery.ItemSize = New System.Drawing.Size(106, 28)
            Me.galleryChangeStyleItem1.Gallery.RowCount = 9
            Me.galleryChangeStyleItem1.Gallery.ShowItemText = True
            Me.galleryChangeStyleItem1.Id = 103
            Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
            ' 
            ' spreadsheetCommandBarSubItem8
            ' 
            Me.spreadsheetCommandBarSubItem8.CommandName = "InsertCellsCommandGroup"
            Me.spreadsheetCommandBarSubItem8.Id = 104
            Me.spreadsheetCommandBarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem63), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem64), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem65), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem66), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem67), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem68), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem69), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem70)})
            Me.spreadsheetCommandBarSubItem8.Name = "spreadsheetCommandBarSubItem8"
            ' 
            ' spreadsheetCommandBarButtonItem63
            ' 
            Me.spreadsheetCommandBarButtonItem63.CommandName = "InsertCells"
            Me.spreadsheetCommandBarButtonItem63.Id = 105
            Me.spreadsheetCommandBarButtonItem63.Name = "spreadsheetCommandBarButtonItem63"
            ' 
            ' spreadsheetCommandBarButtonItem64
            ' 
            Me.spreadsheetCommandBarButtonItem64.CommandName = "InsertSheetRows"
            Me.spreadsheetCommandBarButtonItem64.Id = 106
            Me.spreadsheetCommandBarButtonItem64.Name = "spreadsheetCommandBarButtonItem64"
            ' 
            ' spreadsheetCommandBarButtonItem65
            ' 
            Me.spreadsheetCommandBarButtonItem65.CommandName = "InsertSheetColumns"
            Me.spreadsheetCommandBarButtonItem65.Id = 107
            Me.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65"
            ' 
            ' spreadsheetCommandBarButtonItem66
            ' 
            Me.spreadsheetCommandBarButtonItem66.CommandName = "InsertTableRowsAbove"
            Me.spreadsheetCommandBarButtonItem66.Id = 108
            Me.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66"
            ' 
            ' spreadsheetCommandBarButtonItem67
            ' 
            Me.spreadsheetCommandBarButtonItem67.CommandName = "InsertTableRowBelow"
            Me.spreadsheetCommandBarButtonItem67.Id = 109
            Me.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67"
            ' 
            ' spreadsheetCommandBarButtonItem68
            ' 
            Me.spreadsheetCommandBarButtonItem68.CommandName = "InsertTableColumnsToTheLeft"
            Me.spreadsheetCommandBarButtonItem68.Id = 110
            Me.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68"
            ' 
            ' spreadsheetCommandBarButtonItem69
            ' 
            Me.spreadsheetCommandBarButtonItem69.CommandName = "InsertTableColumnToTheRight"
            Me.spreadsheetCommandBarButtonItem69.Id = 111
            Me.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69"
            ' 
            ' spreadsheetCommandBarButtonItem70
            ' 
            Me.spreadsheetCommandBarButtonItem70.CommandName = "InsertSheet"
            Me.spreadsheetCommandBarButtonItem70.Id = 112
            Me.spreadsheetCommandBarButtonItem70.Name = "spreadsheetCommandBarButtonItem70"
            ' 
            ' spreadsheetCommandBarSubItem9
            ' 
            Me.spreadsheetCommandBarSubItem9.CommandName = "RemoveCellsCommandGroup"
            Me.spreadsheetCommandBarSubItem9.Id = 113
            Me.spreadsheetCommandBarSubItem9.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem71), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem72), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem73), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem74), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem75), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem76)})
            Me.spreadsheetCommandBarSubItem9.Name = "spreadsheetCommandBarSubItem9"
            ' 
            ' spreadsheetCommandBarButtonItem71
            ' 
            Me.spreadsheetCommandBarButtonItem71.CommandName = "RemoveCells"
            Me.spreadsheetCommandBarButtonItem71.Id = 114
            Me.spreadsheetCommandBarButtonItem71.Name = "spreadsheetCommandBarButtonItem71"
            ' 
            ' spreadsheetCommandBarButtonItem72
            ' 
            Me.spreadsheetCommandBarButtonItem72.CommandName = "RemoveSheetRows"
            Me.spreadsheetCommandBarButtonItem72.Id = 115
            Me.spreadsheetCommandBarButtonItem72.Name = "spreadsheetCommandBarButtonItem72"
            ' 
            ' spreadsheetCommandBarButtonItem73
            ' 
            Me.spreadsheetCommandBarButtonItem73.CommandName = "RemoveSheetColumns"
            Me.spreadsheetCommandBarButtonItem73.Id = 116
            Me.spreadsheetCommandBarButtonItem73.Name = "spreadsheetCommandBarButtonItem73"
            ' 
            ' spreadsheetCommandBarButtonItem74
            ' 
            Me.spreadsheetCommandBarButtonItem74.CommandName = "RemoveTableRows"
            Me.spreadsheetCommandBarButtonItem74.Id = 117
            Me.spreadsheetCommandBarButtonItem74.Name = "spreadsheetCommandBarButtonItem74"
            ' 
            ' spreadsheetCommandBarButtonItem75
            ' 
            Me.spreadsheetCommandBarButtonItem75.CommandName = "RemoveTableColumns"
            Me.spreadsheetCommandBarButtonItem75.Id = 118
            Me.spreadsheetCommandBarButtonItem75.Name = "spreadsheetCommandBarButtonItem75"
            ' 
            ' spreadsheetCommandBarButtonItem76
            ' 
            Me.spreadsheetCommandBarButtonItem76.CommandName = "RemoveSheet"
            Me.spreadsheetCommandBarButtonItem76.Id = 119
            Me.spreadsheetCommandBarButtonItem76.Name = "spreadsheetCommandBarButtonItem76"
            ' 
            ' spreadsheetCommandBarSubItem11
            ' 
            Me.spreadsheetCommandBarSubItem11.CommandName = "FormatCommandGroup"
            Me.spreadsheetCommandBarSubItem11.Id = 120
            Me.spreadsheetCommandBarSubItem11.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem77), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem78), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem79), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem80), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem81), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem88), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem89), New DevExpress.XtraBars.LinkPersistInfo(Me.changeSheetTabColorItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem90), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem91)})
            Me.spreadsheetCommandBarSubItem11.Name = "spreadsheetCommandBarSubItem11"
            ' 
            ' spreadsheetCommandBarButtonItem77
            ' 
            Me.spreadsheetCommandBarButtonItem77.CommandName = "FormatRowHeight"
            Me.spreadsheetCommandBarButtonItem77.Id = 121
            Me.spreadsheetCommandBarButtonItem77.Name = "spreadsheetCommandBarButtonItem77"
            ' 
            ' spreadsheetCommandBarButtonItem78
            ' 
            Me.spreadsheetCommandBarButtonItem78.CommandName = "FormatAutoFitRowHeight"
            Me.spreadsheetCommandBarButtonItem78.Id = 122
            Me.spreadsheetCommandBarButtonItem78.Name = "spreadsheetCommandBarButtonItem78"
            ' 
            ' spreadsheetCommandBarButtonItem79
            ' 
            Me.spreadsheetCommandBarButtonItem79.CommandName = "FormatColumnWidth"
            Me.spreadsheetCommandBarButtonItem79.Id = 123
            Me.spreadsheetCommandBarButtonItem79.Name = "spreadsheetCommandBarButtonItem79"
            ' 
            ' spreadsheetCommandBarButtonItem80
            ' 
            Me.spreadsheetCommandBarButtonItem80.CommandName = "FormatAutoFitColumnWidth"
            Me.spreadsheetCommandBarButtonItem80.Id = 124
            Me.spreadsheetCommandBarButtonItem80.Name = "spreadsheetCommandBarButtonItem80"
            ' 
            ' spreadsheetCommandBarButtonItem81
            ' 
            Me.spreadsheetCommandBarButtonItem81.CommandName = "FormatDefaultColumnWidth"
            Me.spreadsheetCommandBarButtonItem81.Id = 125
            Me.spreadsheetCommandBarButtonItem81.Name = "spreadsheetCommandBarButtonItem81"
            ' 
            ' spreadsheetCommandBarSubItem10
            ' 
            Me.spreadsheetCommandBarSubItem10.CommandName = "HideAndUnhideCommandGroup"
            Me.spreadsheetCommandBarSubItem10.Id = 132
            Me.spreadsheetCommandBarSubItem10.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem82), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem83), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem84), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem85), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem86), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem87)})
            Me.spreadsheetCommandBarSubItem10.Name = "spreadsheetCommandBarSubItem10"
            ' 
            ' spreadsheetCommandBarButtonItem82
            ' 
            Me.spreadsheetCommandBarButtonItem82.CommandName = "HideRows"
            Me.spreadsheetCommandBarButtonItem82.Id = 126
            Me.spreadsheetCommandBarButtonItem82.Name = "spreadsheetCommandBarButtonItem82"
            ' 
            ' spreadsheetCommandBarButtonItem83
            ' 
            Me.spreadsheetCommandBarButtonItem83.CommandName = "HideColumns"
            Me.spreadsheetCommandBarButtonItem83.Id = 127
            Me.spreadsheetCommandBarButtonItem83.Name = "spreadsheetCommandBarButtonItem83"
            ' 
            ' spreadsheetCommandBarButtonItem84
            ' 
            Me.spreadsheetCommandBarButtonItem84.CommandName = "HideSheet"
            Me.spreadsheetCommandBarButtonItem84.Id = 128
            Me.spreadsheetCommandBarButtonItem84.Name = "spreadsheetCommandBarButtonItem84"
            ' 
            ' spreadsheetCommandBarButtonItem85
            ' 
            Me.spreadsheetCommandBarButtonItem85.CommandName = "UnhideRows"
            Me.spreadsheetCommandBarButtonItem85.Id = 129
            Me.spreadsheetCommandBarButtonItem85.Name = "spreadsheetCommandBarButtonItem85"
            ' 
            ' spreadsheetCommandBarButtonItem86
            ' 
            Me.spreadsheetCommandBarButtonItem86.CommandName = "UnhideColumns"
            Me.spreadsheetCommandBarButtonItem86.Id = 130
            Me.spreadsheetCommandBarButtonItem86.Name = "spreadsheetCommandBarButtonItem86"
            ' 
            ' spreadsheetCommandBarButtonItem87
            ' 
            Me.spreadsheetCommandBarButtonItem87.CommandName = "UnhideSheet"
            Me.spreadsheetCommandBarButtonItem87.Id = 131
            Me.spreadsheetCommandBarButtonItem87.Name = "spreadsheetCommandBarButtonItem87"
            ' 
            ' spreadsheetCommandBarButtonItem88
            ' 
            Me.spreadsheetCommandBarButtonItem88.CommandName = "RenameSheet"
            Me.spreadsheetCommandBarButtonItem88.Id = 133
            Me.spreadsheetCommandBarButtonItem88.Name = "spreadsheetCommandBarButtonItem88"
            ' 
            ' spreadsheetCommandBarButtonItem89
            ' 
            Me.spreadsheetCommandBarButtonItem89.CommandName = "MoveOrCopySheet"
            Me.spreadsheetCommandBarButtonItem89.Id = 134
            Me.spreadsheetCommandBarButtonItem89.Name = "spreadsheetCommandBarButtonItem89"
            ' 
            ' changeSheetTabColorItem1
            ' 
            Me.changeSheetTabColorItem1.ActAsDropDown = True
            Me.changeSheetTabColorItem1.Id = 135
            Me.changeSheetTabColorItem1.Name = "changeSheetTabColorItem1"
            ' 
            ' spreadsheetCommandBarButtonItem90
            ' 
            Me.spreadsheetCommandBarButtonItem90.CommandName = "ReviewProtectSheet"
            Me.spreadsheetCommandBarButtonItem90.Id = 136
            Me.spreadsheetCommandBarButtonItem90.Name = "spreadsheetCommandBarButtonItem90"
            ' 
            ' spreadsheetCommandBarCheckItem13
            ' 
            Me.spreadsheetCommandBarCheckItem13.CommandName = "FormatCellLocked"
            Me.spreadsheetCommandBarCheckItem13.Id = 137
            Me.spreadsheetCommandBarCheckItem13.Name = "spreadsheetCommandBarCheckItem13"
            ' 
            ' spreadsheetCommandBarButtonItem91
            ' 
            Me.spreadsheetCommandBarButtonItem91.CommandName = "FormatCellsContextMenuItem"
            Me.spreadsheetCommandBarButtonItem91.Id = 138
            Me.spreadsheetCommandBarButtonItem91.Name = "spreadsheetCommandBarButtonItem91"
            ' 
            ' spreadsheetCommandBarSubItem12
            ' 
            Me.spreadsheetCommandBarSubItem12.CommandName = "EditingAutoSumCommandGroup"
            Me.spreadsheetCommandBarSubItem12.Id = 139
            Me.spreadsheetCommandBarSubItem12.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem92), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem93), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem94), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem95), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem96)})
            Me.spreadsheetCommandBarSubItem12.Name = "spreadsheetCommandBarSubItem12"
            Me.spreadsheetCommandBarSubItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem92
            ' 
            Me.spreadsheetCommandBarButtonItem92.CommandName = "FunctionsInsertSum"
            Me.spreadsheetCommandBarButtonItem92.Id = 140
            Me.spreadsheetCommandBarButtonItem92.Name = "spreadsheetCommandBarButtonItem92"
            ' 
            ' spreadsheetCommandBarButtonItem93
            ' 
            Me.spreadsheetCommandBarButtonItem93.CommandName = "FunctionsInsertAverage"
            Me.spreadsheetCommandBarButtonItem93.Id = 141
            Me.spreadsheetCommandBarButtonItem93.Name = "spreadsheetCommandBarButtonItem93"
            ' 
            ' spreadsheetCommandBarButtonItem94
            ' 
            Me.spreadsheetCommandBarButtonItem94.CommandName = "FunctionsInsertCountNumbers"
            Me.spreadsheetCommandBarButtonItem94.Id = 142
            Me.spreadsheetCommandBarButtonItem94.Name = "spreadsheetCommandBarButtonItem94"
            ' 
            ' spreadsheetCommandBarButtonItem95
            ' 
            Me.spreadsheetCommandBarButtonItem95.CommandName = "FunctionsInsertMax"
            Me.spreadsheetCommandBarButtonItem95.Id = 143
            Me.spreadsheetCommandBarButtonItem95.Name = "spreadsheetCommandBarButtonItem95"
            ' 
            ' spreadsheetCommandBarButtonItem96
            ' 
            Me.spreadsheetCommandBarButtonItem96.CommandName = "FunctionsInsertMin"
            Me.spreadsheetCommandBarButtonItem96.Id = 144
            Me.spreadsheetCommandBarButtonItem96.Name = "spreadsheetCommandBarButtonItem96"
            ' 
            ' spreadsheetCommandBarSubItem13
            ' 
            Me.spreadsheetCommandBarSubItem13.CommandName = "EditingFillCommandGroup"
            Me.spreadsheetCommandBarSubItem13.Id = 145
            Me.spreadsheetCommandBarSubItem13.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem97), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem98), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem99), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem100)})
            Me.spreadsheetCommandBarSubItem13.Name = "spreadsheetCommandBarSubItem13"
            Me.spreadsheetCommandBarSubItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem97
            ' 
            Me.spreadsheetCommandBarButtonItem97.CommandName = "EditingFillDown"
            Me.spreadsheetCommandBarButtonItem97.Id = 146
            Me.spreadsheetCommandBarButtonItem97.Name = "spreadsheetCommandBarButtonItem97"
            ' 
            ' spreadsheetCommandBarButtonItem98
            ' 
            Me.spreadsheetCommandBarButtonItem98.CommandName = "EditingFillRight"
            Me.spreadsheetCommandBarButtonItem98.Id = 147
            Me.spreadsheetCommandBarButtonItem98.Name = "spreadsheetCommandBarButtonItem98"
            ' 
            ' spreadsheetCommandBarButtonItem99
            ' 
            Me.spreadsheetCommandBarButtonItem99.CommandName = "EditingFillUp"
            Me.spreadsheetCommandBarButtonItem99.Id = 148
            Me.spreadsheetCommandBarButtonItem99.Name = "spreadsheetCommandBarButtonItem99"
            ' 
            ' spreadsheetCommandBarButtonItem100
            ' 
            Me.spreadsheetCommandBarButtonItem100.CommandName = "EditingFillLeft"
            Me.spreadsheetCommandBarButtonItem100.Id = 149
            Me.spreadsheetCommandBarButtonItem100.Name = "spreadsheetCommandBarButtonItem100"
            ' 
            ' spreadsheetCommandBarSubItem14
            ' 
            Me.spreadsheetCommandBarSubItem14.CommandName = "FormatClearCommandGroup"
            Me.spreadsheetCommandBarSubItem14.Id = 150
            Me.spreadsheetCommandBarSubItem14.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem101), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem102), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem103), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem104), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem105), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem106)})
            Me.spreadsheetCommandBarSubItem14.Name = "spreadsheetCommandBarSubItem14"
            Me.spreadsheetCommandBarSubItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem101
            ' 
            Me.spreadsheetCommandBarButtonItem101.CommandName = "FormatClearAll"
            Me.spreadsheetCommandBarButtonItem101.Id = 151
            Me.spreadsheetCommandBarButtonItem101.Name = "spreadsheetCommandBarButtonItem101"
            ' 
            ' spreadsheetCommandBarButtonItem102
            ' 
            Me.spreadsheetCommandBarButtonItem102.CommandName = "FormatClearFormats"
            Me.spreadsheetCommandBarButtonItem102.Id = 152
            Me.spreadsheetCommandBarButtonItem102.Name = "spreadsheetCommandBarButtonItem102"
            ' 
            ' spreadsheetCommandBarButtonItem103
            ' 
            Me.spreadsheetCommandBarButtonItem103.CommandName = "FormatClearContents"
            Me.spreadsheetCommandBarButtonItem103.Id = 153
            Me.spreadsheetCommandBarButtonItem103.Name = "spreadsheetCommandBarButtonItem103"
            ' 
            ' spreadsheetCommandBarButtonItem104
            ' 
            Me.spreadsheetCommandBarButtonItem104.CommandName = "FormatClearComments"
            Me.spreadsheetCommandBarButtonItem104.Id = 154
            Me.spreadsheetCommandBarButtonItem104.Name = "spreadsheetCommandBarButtonItem104"
            ' 
            ' spreadsheetCommandBarButtonItem105
            ' 
            Me.spreadsheetCommandBarButtonItem105.CommandName = "FormatClearHyperlinks"
            Me.spreadsheetCommandBarButtonItem105.Id = 155
            Me.spreadsheetCommandBarButtonItem105.Name = "spreadsheetCommandBarButtonItem105"
            ' 
            ' spreadsheetCommandBarButtonItem106
            ' 
            Me.spreadsheetCommandBarButtonItem106.CommandName = "FormatRemoveHyperlinks"
            Me.spreadsheetCommandBarButtonItem106.Id = 156
            Me.spreadsheetCommandBarButtonItem106.Name = "spreadsheetCommandBarButtonItem106"
            ' 
            ' spreadsheetCommandBarSubItem15
            ' 
            Me.spreadsheetCommandBarSubItem15.CommandName = "EditingSortAndFilterCommandGroup"
            Me.spreadsheetCommandBarSubItem15.Id = 157
            Me.spreadsheetCommandBarSubItem15.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem107), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem108), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem109), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem110)})
            Me.spreadsheetCommandBarSubItem15.Name = "spreadsheetCommandBarSubItem15"
            ' 
            ' spreadsheetCommandBarButtonItem107
            ' 
            Me.spreadsheetCommandBarButtonItem107.CommandName = "DataSortAscending"
            Me.spreadsheetCommandBarButtonItem107.Id = 158
            Me.spreadsheetCommandBarButtonItem107.Name = "spreadsheetCommandBarButtonItem107"
            ' 
            ' spreadsheetCommandBarButtonItem108
            ' 
            Me.spreadsheetCommandBarButtonItem108.CommandName = "DataSortDescending"
            Me.spreadsheetCommandBarButtonItem108.Id = 159
            Me.spreadsheetCommandBarButtonItem108.Name = "spreadsheetCommandBarButtonItem108"
            ' 
            ' spreadsheetCommandBarCheckItem14
            ' 
            Me.spreadsheetCommandBarCheckItem14.CommandName = "DataFilterToggle"
            Me.spreadsheetCommandBarCheckItem14.Id = 160
            Me.spreadsheetCommandBarCheckItem14.Name = "spreadsheetCommandBarCheckItem14"
            ' 
            ' spreadsheetCommandBarButtonItem109
            ' 
            Me.spreadsheetCommandBarButtonItem109.CommandName = "DataFilterClear"
            Me.spreadsheetCommandBarButtonItem109.Id = 161
            Me.spreadsheetCommandBarButtonItem109.Name = "spreadsheetCommandBarButtonItem109"
            ' 
            ' spreadsheetCommandBarButtonItem110
            ' 
            Me.spreadsheetCommandBarButtonItem110.CommandName = "DataFilterReApply"
            Me.spreadsheetCommandBarButtonItem110.Id = 162
            Me.spreadsheetCommandBarButtonItem110.Name = "spreadsheetCommandBarButtonItem110"
            ' 
            ' spreadsheetCommandBarSubItem16
            ' 
            Me.spreadsheetCommandBarSubItem16.CommandName = "EditingFindAndSelectCommandGroup"
            Me.spreadsheetCommandBarSubItem16.Id = 163
            Me.spreadsheetCommandBarSubItem16.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem111), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem112), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem113), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem114), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem115), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem116), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem117)})
            Me.spreadsheetCommandBarSubItem16.Name = "spreadsheetCommandBarSubItem16"
            ' 
            ' spreadsheetCommandBarButtonItem111
            ' 
            Me.spreadsheetCommandBarButtonItem111.CommandName = "EditingFind"
            Me.spreadsheetCommandBarButtonItem111.Id = 164
            Me.spreadsheetCommandBarButtonItem111.Name = "spreadsheetCommandBarButtonItem111"
            ' 
            ' spreadsheetCommandBarButtonItem112
            ' 
            Me.spreadsheetCommandBarButtonItem112.CommandName = "EditingReplace"
            Me.spreadsheetCommandBarButtonItem112.Id = 165
            Me.spreadsheetCommandBarButtonItem112.Name = "spreadsheetCommandBarButtonItem112"
            ' 
            ' spreadsheetCommandBarButtonItem113
            ' 
            Me.spreadsheetCommandBarButtonItem113.CommandName = "EditingSelectFormulas"
            Me.spreadsheetCommandBarButtonItem113.Id = 166
            Me.spreadsheetCommandBarButtonItem113.Name = "spreadsheetCommandBarButtonItem113"
            ' 
            ' spreadsheetCommandBarButtonItem114
            ' 
            Me.spreadsheetCommandBarButtonItem114.CommandName = "EditingSelectComments"
            Me.spreadsheetCommandBarButtonItem114.Id = 167
            Me.spreadsheetCommandBarButtonItem114.Name = "spreadsheetCommandBarButtonItem114"
            ' 
            ' spreadsheetCommandBarButtonItem115
            ' 
            Me.spreadsheetCommandBarButtonItem115.CommandName = "EditingSelectConditionalFormatting"
            Me.spreadsheetCommandBarButtonItem115.Id = 168
            Me.spreadsheetCommandBarButtonItem115.Name = "spreadsheetCommandBarButtonItem115"
            ' 
            ' spreadsheetCommandBarButtonItem116
            ' 
            Me.spreadsheetCommandBarButtonItem116.CommandName = "EditingSelectConstants"
            Me.spreadsheetCommandBarButtonItem116.Id = 169
            Me.spreadsheetCommandBarButtonItem116.Name = "spreadsheetCommandBarButtonItem116"
            ' 
            ' spreadsheetCommandBarButtonItem117
            ' 
            Me.spreadsheetCommandBarButtonItem117.CommandName = "EditingSelectDataValidation"
            Me.spreadsheetCommandBarButtonItem117.Id = 170
            Me.spreadsheetCommandBarButtonItem117.Name = "spreadsheetCommandBarButtonItem117"
            ' 
            ' spreadsheetCommandBarButtonItem118
            ' 
            Me.spreadsheetCommandBarButtonItem118.CommandName = "InsertPivotTable"
            Me.spreadsheetCommandBarButtonItem118.Id = 171
            Me.spreadsheetCommandBarButtonItem118.Name = "spreadsheetCommandBarButtonItem118"
            ' 
            ' spreadsheetCommandBarButtonItem119
            ' 
            Me.spreadsheetCommandBarButtonItem119.CommandName = "InsertTable"
            Me.spreadsheetCommandBarButtonItem119.Id = 172
            Me.spreadsheetCommandBarButtonItem119.Name = "spreadsheetCommandBarButtonItem119"
            ' 
            ' spreadsheetCommandBarButtonItem120
            ' 
            Me.spreadsheetCommandBarButtonItem120.CommandName = "InsertPicture"
            Me.spreadsheetCommandBarButtonItem120.Id = 173
            Me.spreadsheetCommandBarButtonItem120.Name = "spreadsheetCommandBarButtonItem120"
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem4
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem4.CommandName = "InsertChartColumnCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem4.DropDownControl = Me.commandBarGalleryDropDown78
            Me.spreadsheetCommandBarButtonGalleryDropDownItem4.Id = 174
            Me.spreadsheetCommandBarButtonGalleryDropDownItem4.Name = "spreadsheetCommandBarButtonGalleryDropDownItem4"
            ' 
            ' commandBarGalleryDropDown78
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown78.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup10.CommandName = "InsertChartColumn2DCommandGroup"
            spreadsheetCommandGalleryItem68.CommandName = "InsertChartColumnClustered2D"
            spreadsheetCommandGalleryItem69.CommandName = "InsertChartColumnStacked2D"
            spreadsheetCommandGalleryItem70.CommandName = "InsertChartColumnPercentStacked2D"
            spreadsheetCommandGalleryItemGroup10.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem68, spreadsheetCommandGalleryItem69, spreadsheetCommandGalleryItem70})
            spreadsheetCommandGalleryItemGroup11.CommandName = "InsertChartColumn3DCommandGroup"
            spreadsheetCommandGalleryItem71.CommandName = "InsertChartColumnClustered3D"
            spreadsheetCommandGalleryItem72.CommandName = "InsertChartColumnStacked3D"
            spreadsheetCommandGalleryItem73.CommandName = "InsertChartColumnPercentStacked3D"
            spreadsheetCommandGalleryItem74.CommandName = "InsertChartColumn3D"
            spreadsheetCommandGalleryItemGroup11.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem71, spreadsheetCommandGalleryItem72, spreadsheetCommandGalleryItem73, spreadsheetCommandGalleryItem74})
            spreadsheetCommandGalleryItemGroup12.CommandName = "InsertChartCylinderCommandGroup"
            spreadsheetCommandGalleryItem75.CommandName = "InsertChartCylinderClustered"
            spreadsheetCommandGalleryItem76.CommandName = "InsertChartCylinderStacked"
            spreadsheetCommandGalleryItem77.CommandName = "InsertChartCylinderPercentStacked"
            spreadsheetCommandGalleryItem78.CommandName = "InsertChartCylinder"
            spreadsheetCommandGalleryItemGroup12.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem75, spreadsheetCommandGalleryItem76, spreadsheetCommandGalleryItem77, spreadsheetCommandGalleryItem78})
            spreadsheetCommandGalleryItemGroup13.CommandName = "InsertChartConeCommandGroup"
            spreadsheetCommandGalleryItem79.CommandName = "InsertChartConeClustered"
            spreadsheetCommandGalleryItem80.CommandName = "InsertChartConeStacked"
            spreadsheetCommandGalleryItem81.CommandName = "InsertChartConePercentStacked"
            spreadsheetCommandGalleryItem82.CommandName = "InsertChartCone"
            spreadsheetCommandGalleryItemGroup13.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem79, spreadsheetCommandGalleryItem80, spreadsheetCommandGalleryItem81, spreadsheetCommandGalleryItem82})
            spreadsheetCommandGalleryItemGroup14.CommandName = "InsertChartPyramidCommandGroup"
            spreadsheetCommandGalleryItem83.CommandName = "InsertChartPyramidClustered"
            spreadsheetCommandGalleryItem84.CommandName = "InsertChartPyramidStacked"
            spreadsheetCommandGalleryItem85.CommandName = "InsertChartPyramidPercentStacked"
            spreadsheetCommandGalleryItem86.CommandName = "InsertChartPyramid"
            spreadsheetCommandGalleryItemGroup14.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem83, spreadsheetCommandGalleryItem84, spreadsheetCommandGalleryItem85, spreadsheetCommandGalleryItem86})
            Me.commandBarGalleryDropDown78.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup10, spreadsheetCommandGalleryItemGroup11, spreadsheetCommandGalleryItemGroup12, spreadsheetCommandGalleryItemGroup13, spreadsheetCommandGalleryItemGroup14})
            Me.commandBarGalleryDropDown78.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown78.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown78.Name = "commandBarGalleryDropDown78"
            Me.commandBarGalleryDropDown78.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem5
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem5.CommandName = "InsertChartLineCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem5.DropDownControl = Me.commandBarGalleryDropDown79
            Me.spreadsheetCommandBarButtonGalleryDropDownItem5.Id = 175
            Me.spreadsheetCommandBarButtonGalleryDropDownItem5.Name = "spreadsheetCommandBarButtonGalleryDropDownItem5"
            ' 
            ' commandBarGalleryDropDown79
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown79.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup15.CommandName = "InsertChartLine2DCommandGroup"
            spreadsheetCommandGalleryItem87.CommandName = "InsertChartLine"
            spreadsheetCommandGalleryItem88.CommandName = "InsertChartStackedLine"
            spreadsheetCommandGalleryItem89.CommandName = "InsertChartPercentStackedLine"
            spreadsheetCommandGalleryItem90.CommandName = "InsertChartLineWithMarkers"
            spreadsheetCommandGalleryItem91.CommandName = "InsertChartStackedLineWithMarkers"
            spreadsheetCommandGalleryItem92.CommandName = "InsertChartPercentStackedLineWithMarkers"
            spreadsheetCommandGalleryItemGroup15.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem87, spreadsheetCommandGalleryItem88, spreadsheetCommandGalleryItem89, spreadsheetCommandGalleryItem90, spreadsheetCommandGalleryItem91, spreadsheetCommandGalleryItem92})
            spreadsheetCommandGalleryItemGroup16.CommandName = "InsertChartLine3DCommandGroup"
            spreadsheetCommandGalleryItem93.CommandName = "InsertChartLine3D"
            spreadsheetCommandGalleryItemGroup16.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem93})
            Me.commandBarGalleryDropDown79.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup15, spreadsheetCommandGalleryItemGroup16})
            Me.commandBarGalleryDropDown79.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown79.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown79.Name = "commandBarGalleryDropDown79"
            Me.commandBarGalleryDropDown79.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem6
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem6.CommandName = "InsertChartPieCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem6.DropDownControl = Me.commandBarGalleryDropDown80
            Me.spreadsheetCommandBarButtonGalleryDropDownItem6.Id = 176
            Me.spreadsheetCommandBarButtonGalleryDropDownItem6.Name = "spreadsheetCommandBarButtonGalleryDropDownItem6"
            ' 
            ' commandBarGalleryDropDown80
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown80.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup17.CommandName = "InsertChartPie2DCommandGroup"
            spreadsheetCommandGalleryItem94.CommandName = "InsertChartPie2D"
            spreadsheetCommandGalleryItem95.CommandName = "InsertChartPieExploded2D"
            spreadsheetCommandGalleryItemGroup17.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem94, spreadsheetCommandGalleryItem95})
            spreadsheetCommandGalleryItemGroup18.CommandName = "InsertChartPie3DCommandGroup"
            spreadsheetCommandGalleryItem96.CommandName = "InsertChartPie3D"
            spreadsheetCommandGalleryItem97.CommandName = "InsertChartPieExploded3D"
            spreadsheetCommandGalleryItemGroup18.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem96, spreadsheetCommandGalleryItem97})
            spreadsheetCommandGalleryItemGroup19.CommandName = "InsertChartDoughnut2DCommandGroup"
            spreadsheetCommandGalleryItem98.CommandName = "InsertChartDoughnut2D"
            spreadsheetCommandGalleryItem99.CommandName = "InsertChartDoughnutExploded2D"
            spreadsheetCommandGalleryItemGroup19.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem98, spreadsheetCommandGalleryItem99})
            Me.commandBarGalleryDropDown80.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup17, spreadsheetCommandGalleryItemGroup18, spreadsheetCommandGalleryItemGroup19})
            Me.commandBarGalleryDropDown80.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown80.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown80.Name = "commandBarGalleryDropDown80"
            Me.commandBarGalleryDropDown80.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem7
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem7.CommandName = "InsertChartBarCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem7.DropDownControl = Me.commandBarGalleryDropDown81
            Me.spreadsheetCommandBarButtonGalleryDropDownItem7.Id = 177
            Me.spreadsheetCommandBarButtonGalleryDropDownItem7.Name = "spreadsheetCommandBarButtonGalleryDropDownItem7"
            ' 
            ' commandBarGalleryDropDown81
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown81.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup20.CommandName = "InsertChartBar2DCommandGroup"
            spreadsheetCommandGalleryItem100.CommandName = "InsertChartBarClustered2D"
            spreadsheetCommandGalleryItem101.CommandName = "InsertChartBarStacked2D"
            spreadsheetCommandGalleryItem102.CommandName = "InsertChartBarPercentStacked2D"
            spreadsheetCommandGalleryItemGroup20.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem100, spreadsheetCommandGalleryItem101, spreadsheetCommandGalleryItem102})
            spreadsheetCommandGalleryItemGroup21.CommandName = "InsertChartBar3DCommandGroup"
            spreadsheetCommandGalleryItem103.CommandName = "InsertChartBarClustered3D"
            spreadsheetCommandGalleryItem104.CommandName = "InsertChartBarStacked3D"
            spreadsheetCommandGalleryItem105.CommandName = "InsertChartBarPercentStacked3D"
            spreadsheetCommandGalleryItemGroup21.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem103, spreadsheetCommandGalleryItem104, spreadsheetCommandGalleryItem105})
            spreadsheetCommandGalleryItemGroup22.CommandName = "InsertChartHorizontalCylinderCommandGroup"
            spreadsheetCommandGalleryItem106.CommandName = "InsertChartHorizontalCylinderClustered"
            spreadsheetCommandGalleryItem107.CommandName = "InsertChartHorizontalCylinderStacked"
            spreadsheetCommandGalleryItem108.CommandName = "InsertChartHorizontalCylinderPercentStacked"
            spreadsheetCommandGalleryItemGroup22.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem106, spreadsheetCommandGalleryItem107, spreadsheetCommandGalleryItem108})
            spreadsheetCommandGalleryItemGroup23.CommandName = "InsertChartHorizontalConeCommandGroup"
            spreadsheetCommandGalleryItem109.CommandName = "InsertChartHorizontalConeClustered"
            spreadsheetCommandGalleryItem110.CommandName = "InsertChartHorizontalConeStacked"
            spreadsheetCommandGalleryItem111.CommandName = "InsertChartHorizontalConePercentStacked"
            spreadsheetCommandGalleryItemGroup23.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem109, spreadsheetCommandGalleryItem110, spreadsheetCommandGalleryItem111})
            spreadsheetCommandGalleryItemGroup24.CommandName = "InsertChartHorizontalPyramidCommandGroup"
            spreadsheetCommandGalleryItem112.CommandName = "InsertChartHorizontalPyramidClustered"
            spreadsheetCommandGalleryItem113.CommandName = "InsertChartHorizontalPyramidStacked"
            spreadsheetCommandGalleryItem114.CommandName = "InsertChartHorizontalPyramidPercentStacked"
            spreadsheetCommandGalleryItemGroup24.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem112, spreadsheetCommandGalleryItem113, spreadsheetCommandGalleryItem114})
            Me.commandBarGalleryDropDown81.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup20, spreadsheetCommandGalleryItemGroup21, spreadsheetCommandGalleryItemGroup22, spreadsheetCommandGalleryItemGroup23, spreadsheetCommandGalleryItemGroup24})
            Me.commandBarGalleryDropDown81.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown81.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown81.Name = "commandBarGalleryDropDown81"
            Me.commandBarGalleryDropDown81.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem8
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem8.CommandName = "InsertChartAreaCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem8.DropDownControl = Me.commandBarGalleryDropDown82
            Me.spreadsheetCommandBarButtonGalleryDropDownItem8.Id = 178
            Me.spreadsheetCommandBarButtonGalleryDropDownItem8.Name = "spreadsheetCommandBarButtonGalleryDropDownItem8"
            ' 
            ' commandBarGalleryDropDown82
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown82.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup25.CommandName = "InsertChartArea2DCommandGroup"
            spreadsheetCommandGalleryItem115.CommandName = "InsertChartArea"
            spreadsheetCommandGalleryItem116.CommandName = "InsertChartStackedArea"
            spreadsheetCommandGalleryItem117.CommandName = "InsertChartPercentStackedArea"
            spreadsheetCommandGalleryItemGroup25.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem115, spreadsheetCommandGalleryItem116, spreadsheetCommandGalleryItem117})
            spreadsheetCommandGalleryItemGroup26.CommandName = "InsertChartArea3DCommandGroup"
            spreadsheetCommandGalleryItem118.CommandName = "InsertChartArea3D"
            spreadsheetCommandGalleryItem119.CommandName = "InsertChartStackedArea3D"
            spreadsheetCommandGalleryItem120.CommandName = "InsertChartPercentStackedArea3D"
            spreadsheetCommandGalleryItemGroup26.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem118, spreadsheetCommandGalleryItem119, spreadsheetCommandGalleryItem120})
            Me.commandBarGalleryDropDown82.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup25, spreadsheetCommandGalleryItemGroup26})
            Me.commandBarGalleryDropDown82.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown82.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown82.Name = "commandBarGalleryDropDown82"
            Me.commandBarGalleryDropDown82.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem9
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem9.CommandName = "InsertChartScatterCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem9.DropDownControl = Me.commandBarGalleryDropDown83
            Me.spreadsheetCommandBarButtonGalleryDropDownItem9.Id = 179
            Me.spreadsheetCommandBarButtonGalleryDropDownItem9.Name = "spreadsheetCommandBarButtonGalleryDropDownItem9"
            ' 
            ' commandBarGalleryDropDown83
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown83.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup27.CommandName = "InsertChartScatterCommandGroup"
            spreadsheetCommandGalleryItem121.CommandName = "InsertChartScatterMarkers"
            spreadsheetCommandGalleryItem122.CommandName = "InsertChartScatterSmoothLinesAndMarkers"
            spreadsheetCommandGalleryItem123.CommandName = "InsertChartScatterSmoothLines"
            spreadsheetCommandGalleryItem124.CommandName = "InsertChartScatterLinesAndMarkers"
            spreadsheetCommandGalleryItem125.CommandName = "InsertChartScatterLines"
            spreadsheetCommandGalleryItemGroup27.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem121, spreadsheetCommandGalleryItem122, spreadsheetCommandGalleryItem123, spreadsheetCommandGalleryItem124, spreadsheetCommandGalleryItem125})
            spreadsheetCommandGalleryItemGroup28.CommandName = "InsertChartBubbleCommandGroup"
            spreadsheetCommandGalleryItem126.CommandName = "InsertChartBubble"
            spreadsheetCommandGalleryItem127.CommandName = "InsertChartBubble3D"
            spreadsheetCommandGalleryItemGroup28.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem126, spreadsheetCommandGalleryItem127})
            Me.commandBarGalleryDropDown83.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup27, spreadsheetCommandGalleryItemGroup28})
            Me.commandBarGalleryDropDown83.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown83.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown83.Name = "commandBarGalleryDropDown83"
            Me.commandBarGalleryDropDown83.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem10
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem10.CommandName = "InsertChartStatisticCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem10.DropDownControl = Me.commandBarGalleryDropDown84
            Me.spreadsheetCommandBarButtonGalleryDropDownItem10.Id = 180
            Me.spreadsheetCommandBarButtonGalleryDropDownItem10.Name = "spreadsheetCommandBarButtonGalleryDropDownItem10"
            ' 
            ' commandBarGalleryDropDown84
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown84.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup29.CommandName = "InsertChartHistogramCommandGroup"
            spreadsheetCommandGalleryItem128.CommandName = "InsertChartHistogram"
            spreadsheetCommandGalleryItem129.CommandName = "InsertChartPareto"
            spreadsheetCommandGalleryItemGroup29.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem128, spreadsheetCommandGalleryItem129})
            spreadsheetCommandGalleryItemGroup30.CommandName = "InsertChartBoxAndWhiskerCommandGroup"
            spreadsheetCommandGalleryItem130.CommandName = "InsertChartBoxAndWhisker"
            spreadsheetCommandGalleryItemGroup30.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem130})
            Me.commandBarGalleryDropDown84.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup29, spreadsheetCommandGalleryItemGroup30})
            Me.commandBarGalleryDropDown84.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown84.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown84.Name = "commandBarGalleryDropDown84"
            Me.commandBarGalleryDropDown84.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem11
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem11.CommandName = "InsertChartHierarchyCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem11.DropDownControl = Me.commandBarGalleryDropDown85
            Me.spreadsheetCommandBarButtonGalleryDropDownItem11.Id = 181
            Me.spreadsheetCommandBarButtonGalleryDropDownItem11.Name = "spreadsheetCommandBarButtonGalleryDropDownItem11"
            ' 
            ' commandBarGalleryDropDown85
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown85.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup31.CommandName = "InsertChartTreemapCommandGroup"
            spreadsheetCommandGalleryItem131.CommandName = "InsertChartTreemap"
            spreadsheetCommandGalleryItemGroup31.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem131})
            spreadsheetCommandGalleryItemGroup32.CommandName = "InsertChartSunburstCommandGroup"
            spreadsheetCommandGalleryItem132.CommandName = "InsertChartSunburst"
            spreadsheetCommandGalleryItemGroup32.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem132})
            Me.commandBarGalleryDropDown85.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup31, spreadsheetCommandGalleryItemGroup32})
            Me.commandBarGalleryDropDown85.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown85.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown85.Name = "commandBarGalleryDropDown85"
            Me.commandBarGalleryDropDown85.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem12
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem12.CommandName = "InsertChartOtherCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem12.DropDownControl = Me.commandBarGalleryDropDown86
            Me.spreadsheetCommandBarButtonGalleryDropDownItem12.Id = 182
            Me.spreadsheetCommandBarButtonGalleryDropDownItem12.Name = "spreadsheetCommandBarButtonGalleryDropDownItem12"
            ' 
            ' commandBarGalleryDropDown86
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown86.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup33.CommandName = "InsertChartWaterfallCommandGroup"
            spreadsheetCommandGalleryItem133.CommandName = "InsertChartWaterfall"
            spreadsheetCommandGalleryItemGroup33.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem133})
            spreadsheetCommandGalleryItemGroup34.CommandName = "InsertChartFunnelCommandGroup"
            spreadsheetCommandGalleryItem134.CommandName = "InsertChartFunnel"
            spreadsheetCommandGalleryItemGroup34.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem134})
            spreadsheetCommandGalleryItemGroup35.CommandName = "InsertChartStockCommandGroup"
            spreadsheetCommandGalleryItem135.CommandName = "InsertChartStockHighLowClose"
            spreadsheetCommandGalleryItem136.CommandName = "InsertChartStockOpenHighLowClose"
            spreadsheetCommandGalleryItem137.CommandName = "InsertChartStockVolumeHighLowClose"
            spreadsheetCommandGalleryItem138.CommandName = "InsertChartStockVolumeOpenHighLowClose"
            spreadsheetCommandGalleryItemGroup35.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem135, spreadsheetCommandGalleryItem136, spreadsheetCommandGalleryItem137, spreadsheetCommandGalleryItem138})
            spreadsheetCommandGalleryItemGroup36.CommandName = "InsertChartRadarCommandGroup"
            spreadsheetCommandGalleryItem139.CommandName = "InsertChartRadar"
            spreadsheetCommandGalleryItem140.CommandName = "InsertChartRadarWithMarkers"
            spreadsheetCommandGalleryItem141.CommandName = "InsertChartRadarFilled"
            spreadsheetCommandGalleryItemGroup36.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem139, spreadsheetCommandGalleryItem140, spreadsheetCommandGalleryItem141})
            Me.commandBarGalleryDropDown86.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup33, spreadsheetCommandGalleryItemGroup34, spreadsheetCommandGalleryItemGroup35, spreadsheetCommandGalleryItemGroup36})
            Me.commandBarGalleryDropDown86.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown86.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown86.Name = "commandBarGalleryDropDown86"
            Me.commandBarGalleryDropDown86.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonItem121
            ' 
            Me.spreadsheetCommandBarButtonItem121.CommandName = "InsertHyperlink"
            Me.spreadsheetCommandBarButtonItem121.Id = 183
            Me.spreadsheetCommandBarButtonItem121.Name = "spreadsheetCommandBarButtonItem121"
            ' 
            ' spreadsheetCommandBarButtonItem122
            ' 
            Me.spreadsheetCommandBarButtonItem122.CommandName = "InsertSymbol"
            Me.spreadsheetCommandBarButtonItem122.Id = 184
            Me.spreadsheetCommandBarButtonItem122.Name = "spreadsheetCommandBarButtonItem122"
            ' 
            ' spreadsheetCommandBarSubItem17
            ' 
            Me.spreadsheetCommandBarSubItem17.CommandName = "PageSetupMarginsCommandGroup"
            Me.spreadsheetCommandBarSubItem17.Id = 185
            Me.spreadsheetCommandBarSubItem17.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem123)})
            Me.spreadsheetCommandBarSubItem17.Name = "spreadsheetCommandBarSubItem17"
            ' 
            ' spreadsheetCommandBarCheckItem15
            ' 
            Me.spreadsheetCommandBarCheckItem15.CaptionDependOnUnits = True
            Me.spreadsheetCommandBarCheckItem15.CommandName = "PageSetupMarginsNormal"
            Me.spreadsheetCommandBarCheckItem15.Id = 186
            Me.spreadsheetCommandBarCheckItem15.Name = "spreadsheetCommandBarCheckItem15"
            ' 
            ' spreadsheetCommandBarCheckItem16
            ' 
            Me.spreadsheetCommandBarCheckItem16.CaptionDependOnUnits = True
            Me.spreadsheetCommandBarCheckItem16.CommandName = "PageSetupMarginsWide"
            Me.spreadsheetCommandBarCheckItem16.Id = 187
            Me.spreadsheetCommandBarCheckItem16.Name = "spreadsheetCommandBarCheckItem16"
            ' 
            ' spreadsheetCommandBarCheckItem17
            ' 
            Me.spreadsheetCommandBarCheckItem17.CaptionDependOnUnits = True
            Me.spreadsheetCommandBarCheckItem17.CommandName = "PageSetupMarginsNarrow"
            Me.spreadsheetCommandBarCheckItem17.Id = 188
            Me.spreadsheetCommandBarCheckItem17.Name = "spreadsheetCommandBarCheckItem17"
            ' 
            ' spreadsheetCommandBarButtonItem123
            ' 
            Me.spreadsheetCommandBarButtonItem123.CommandName = "PageSetupCustomMargins"
            Me.spreadsheetCommandBarButtonItem123.Id = 189
            Me.spreadsheetCommandBarButtonItem123.Name = "spreadsheetCommandBarButtonItem123"
            ' 
            ' spreadsheetCommandBarSubItem18
            ' 
            Me.spreadsheetCommandBarSubItem18.CommandName = "PageSetupOrientationCommandGroup"
            Me.spreadsheetCommandBarSubItem18.Id = 190
            Me.spreadsheetCommandBarSubItem18.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem19)})
            Me.spreadsheetCommandBarSubItem18.Name = "spreadsheetCommandBarSubItem18"
            ' 
            ' spreadsheetCommandBarCheckItem18
            ' 
            Me.spreadsheetCommandBarCheckItem18.CommandName = "PageSetupOrientationPortrait"
            Me.spreadsheetCommandBarCheckItem18.Id = 191
            Me.spreadsheetCommandBarCheckItem18.Name = "spreadsheetCommandBarCheckItem18"
            ' 
            ' spreadsheetCommandBarCheckItem19
            ' 
            Me.spreadsheetCommandBarCheckItem19.CommandName = "PageSetupOrientationLandscape"
            Me.spreadsheetCommandBarCheckItem19.Id = 192
            Me.spreadsheetCommandBarCheckItem19.Name = "spreadsheetCommandBarCheckItem19"
            ' 
            ' pageSetupPaperKindItem1
            ' 
            Me.pageSetupPaperKindItem1.Id = 193
            Me.pageSetupPaperKindItem1.Name = "pageSetupPaperKindItem1"
            ' 
            ' spreadsheetCommandBarSubItem19
            ' 
            Me.spreadsheetCommandBarSubItem19.CommandName = "PageSetupPrintAreaCommandGroup"
            Me.spreadsheetCommandBarSubItem19.Id = 194
            Me.spreadsheetCommandBarSubItem19.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem124), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem125), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem126)})
            Me.spreadsheetCommandBarSubItem19.Name = "spreadsheetCommandBarSubItem19"
            ' 
            ' spreadsheetCommandBarButtonItem124
            ' 
            Me.spreadsheetCommandBarButtonItem124.CommandName = "PageSetupSetPrintArea"
            Me.spreadsheetCommandBarButtonItem124.Id = 195
            Me.spreadsheetCommandBarButtonItem124.Name = "spreadsheetCommandBarButtonItem124"
            ' 
            ' spreadsheetCommandBarButtonItem125
            ' 
            Me.spreadsheetCommandBarButtonItem125.CommandName = "PageSetupClearPrintArea"
            Me.spreadsheetCommandBarButtonItem125.Id = 196
            Me.spreadsheetCommandBarButtonItem125.Name = "spreadsheetCommandBarButtonItem125"
            ' 
            ' spreadsheetCommandBarButtonItem126
            ' 
            Me.spreadsheetCommandBarButtonItem126.CommandName = "PageSetupAddPrintArea"
            Me.spreadsheetCommandBarButtonItem126.Id = 197
            Me.spreadsheetCommandBarButtonItem126.Name = "spreadsheetCommandBarButtonItem126"
            ' 
            ' spreadsheetCommandBarButtonItem127
            ' 
            Me.spreadsheetCommandBarButtonItem127.CommandName = "PageSetupPrintTitles"
            Me.spreadsheetCommandBarButtonItem127.Id = 198
            Me.spreadsheetCommandBarButtonItem127.Name = "spreadsheetCommandBarButtonItem127"
            ' 
            ' spreadsheetCommandBarCheckItem20
            ' 
            Me.spreadsheetCommandBarCheckItem20.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem20.CommandName = "ViewShowGridlines"
            Me.spreadsheetCommandBarCheckItem20.Id = 199
            Me.spreadsheetCommandBarCheckItem20.Name = "spreadsheetCommandBarCheckItem20"
            ' 
            ' spreadsheetCommandBarCheckItem21
            ' 
            Me.spreadsheetCommandBarCheckItem21.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem21.CommandName = "ViewShowHeadings"
            Me.spreadsheetCommandBarCheckItem21.Id = 200
            Me.spreadsheetCommandBarCheckItem21.Name = "spreadsheetCommandBarCheckItem21"
            ' 
            ' spreadsheetCommandBarCheckItem22
            ' 
            Me.spreadsheetCommandBarCheckItem22.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem22.CommandName = "PageSetupPrintGridlines"
            Me.spreadsheetCommandBarCheckItem22.Id = 201
            Me.spreadsheetCommandBarCheckItem22.Name = "spreadsheetCommandBarCheckItem22"
            ' 
            ' spreadsheetCommandBarCheckItem23
            ' 
            Me.spreadsheetCommandBarCheckItem23.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem23.CommandName = "PageSetupPrintHeadings"
            Me.spreadsheetCommandBarCheckItem23.Id = 202
            Me.spreadsheetCommandBarCheckItem23.Name = "spreadsheetCommandBarCheckItem23"
            ' 
            ' spreadsheetCommandBarSubItem20
            ' 
            Me.spreadsheetCommandBarSubItem20.CommandName = "ArrangeBringForwardCommandGroup"
            Me.spreadsheetCommandBarSubItem20.Id = 203
            Me.spreadsheetCommandBarSubItem20.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem128), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem129)})
            Me.spreadsheetCommandBarSubItem20.Name = "spreadsheetCommandBarSubItem20"
            ' 
            ' spreadsheetCommandBarButtonItem128
            ' 
            Me.spreadsheetCommandBarButtonItem128.CommandName = "ArrangeBringForward"
            Me.spreadsheetCommandBarButtonItem128.Id = 204
            Me.spreadsheetCommandBarButtonItem128.Name = "spreadsheetCommandBarButtonItem128"
            ' 
            ' spreadsheetCommandBarButtonItem129
            ' 
            Me.spreadsheetCommandBarButtonItem129.CommandName = "ArrangeBringToFront"
            Me.spreadsheetCommandBarButtonItem129.Id = 205
            Me.spreadsheetCommandBarButtonItem129.Name = "spreadsheetCommandBarButtonItem129"
            ' 
            ' spreadsheetCommandBarSubItem21
            ' 
            Me.spreadsheetCommandBarSubItem21.CommandName = "ArrangeSendBackwardCommandGroup"
            Me.spreadsheetCommandBarSubItem21.Id = 206
            Me.spreadsheetCommandBarSubItem21.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem130), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem131)})
            Me.spreadsheetCommandBarSubItem21.Name = "spreadsheetCommandBarSubItem21"
            ' 
            ' spreadsheetCommandBarButtonItem130
            ' 
            Me.spreadsheetCommandBarButtonItem130.CommandName = "ArrangeSendBackward"
            Me.spreadsheetCommandBarButtonItem130.Id = 207
            Me.spreadsheetCommandBarButtonItem130.Name = "spreadsheetCommandBarButtonItem130"
            ' 
            ' spreadsheetCommandBarButtonItem131
            ' 
            Me.spreadsheetCommandBarButtonItem131.CommandName = "ArrangeSendToBack"
            Me.spreadsheetCommandBarButtonItem131.Id = 208
            Me.spreadsheetCommandBarButtonItem131.Name = "spreadsheetCommandBarButtonItem131"
            ' 
            ' spreadsheetCommandBarSubItem22
            ' 
            Me.spreadsheetCommandBarSubItem22.CommandName = "FunctionsAutoSumCommandGroup"
            Me.spreadsheetCommandBarSubItem22.Id = 209
            Me.spreadsheetCommandBarSubItem22.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem92), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem93), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem94), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem95), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem96)})
            Me.spreadsheetCommandBarSubItem22.Name = "spreadsheetCommandBarSubItem22"
            ' 
            ' functionsFinancialItem1
            ' 
            Me.functionsFinancialItem1.Id = 210
            Me.functionsFinancialItem1.Name = "functionsFinancialItem1"
            ' 
            ' functionsLogicalItem1
            ' 
            Me.functionsLogicalItem1.Id = 211
            Me.functionsLogicalItem1.Name = "functionsLogicalItem1"
            ' 
            ' functionsTextItem1
            ' 
            Me.functionsTextItem1.Id = 212
            Me.functionsTextItem1.Name = "functionsTextItem1"
            ' 
            ' functionsDateAndTimeItem1
            ' 
            Me.functionsDateAndTimeItem1.Id = 213
            Me.functionsDateAndTimeItem1.Name = "functionsDateAndTimeItem1"
            ' 
            ' functionsLookupAndReferenceItem1
            ' 
            Me.functionsLookupAndReferenceItem1.Id = 214
            Me.functionsLookupAndReferenceItem1.Name = "functionsLookupAndReferenceItem1"
            ' 
            ' functionsMathAndTrigonometryItem1
            ' 
            Me.functionsMathAndTrigonometryItem1.Id = 215
            Me.functionsMathAndTrigonometryItem1.Name = "functionsMathAndTrigonometryItem1"
            ' 
            ' spreadsheetCommandBarSubItem23
            ' 
            Me.spreadsheetCommandBarSubItem23.CommandName = "FunctionsMoreCommandGroup"
            Me.spreadsheetCommandBarSubItem23.Id = 216
            Me.spreadsheetCommandBarSubItem23.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.functionsStatisticalItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsEngineeringItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsInformationItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsCompatibilityItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.functionsWebItem1)})
            Me.spreadsheetCommandBarSubItem23.Name = "spreadsheetCommandBarSubItem23"
            ' 
            ' functionsStatisticalItem1
            ' 
            Me.functionsStatisticalItem1.Id = 217
            Me.functionsStatisticalItem1.Name = "functionsStatisticalItem1"
            ' 
            ' functionsEngineeringItem1
            ' 
            Me.functionsEngineeringItem1.Id = 218
            Me.functionsEngineeringItem1.Name = "functionsEngineeringItem1"
            ' 
            ' functionsInformationItem1
            ' 
            Me.functionsInformationItem1.Id = 219
            Me.functionsInformationItem1.Name = "functionsInformationItem1"
            ' 
            ' functionsCompatibilityItem1
            ' 
            Me.functionsCompatibilityItem1.Id = 220
            Me.functionsCompatibilityItem1.Name = "functionsCompatibilityItem1"
            ' 
            ' functionsWebItem1
            ' 
            Me.functionsWebItem1.Id = 221
            Me.functionsWebItem1.Name = "functionsWebItem1"
            ' 
            ' spreadsheetCommandBarButtonItem132
            ' 
            Me.spreadsheetCommandBarButtonItem132.CommandName = "FormulasShowNameManager"
            Me.spreadsheetCommandBarButtonItem132.Id = 222
            Me.spreadsheetCommandBarButtonItem132.Name = "spreadsheetCommandBarButtonItem132"
            ' 
            ' spreadsheetCommandBarButtonItem133
            ' 
            Me.spreadsheetCommandBarButtonItem133.CommandName = "FormulasDefineNameCommand"
            Me.spreadsheetCommandBarButtonItem133.Id = 223
            Me.spreadsheetCommandBarButtonItem133.Name = "spreadsheetCommandBarButtonItem133"
            Me.spreadsheetCommandBarButtonItem133.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' definedNameListItem1
            ' 
            Me.definedNameListItem1.Id = 224
            Me.definedNameListItem1.Name = "definedNameListItem1"
            Me.definedNameListItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem134
            ' 
            Me.spreadsheetCommandBarButtonItem134.CommandName = "FormulasCreateDefinedNamesFromSelection"
            Me.spreadsheetCommandBarButtonItem134.Id = 225
            Me.spreadsheetCommandBarButtonItem134.Name = "spreadsheetCommandBarButtonItem134"
            Me.spreadsheetCommandBarButtonItem134.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarCheckItem24
            ' 
            Me.spreadsheetCommandBarCheckItem24.CommandName = "ViewShowFormulas"
            Me.spreadsheetCommandBarCheckItem24.Id = 226
            Me.spreadsheetCommandBarCheckItem24.Name = "spreadsheetCommandBarCheckItem24"
            ' 
            ' spreadsheetCommandBarSubItem24
            ' 
            Me.spreadsheetCommandBarSubItem24.CommandName = "FormulasCalculationOptionsCommandGroup"
            Me.spreadsheetCommandBarSubItem24.Id = 227
            Me.spreadsheetCommandBarSubItem24.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem26)})
            Me.spreadsheetCommandBarSubItem24.Name = "spreadsheetCommandBarSubItem24"
            ' 
            ' spreadsheetCommandBarCheckItem25
            ' 
            Me.spreadsheetCommandBarCheckItem25.CommandName = "FormulasCalculationModeAutomatic"
            Me.spreadsheetCommandBarCheckItem25.Id = 228
            Me.spreadsheetCommandBarCheckItem25.Name = "spreadsheetCommandBarCheckItem25"
            ' 
            ' spreadsheetCommandBarCheckItem26
            ' 
            Me.spreadsheetCommandBarCheckItem26.CommandName = "FormulasCalculationModeManual"
            Me.spreadsheetCommandBarCheckItem26.Id = 229
            Me.spreadsheetCommandBarCheckItem26.Name = "spreadsheetCommandBarCheckItem26"
            ' 
            ' spreadsheetCommandBarButtonItem135
            ' 
            Me.spreadsheetCommandBarButtonItem135.CommandName = "FormulasCalculateNow"
            Me.spreadsheetCommandBarButtonItem135.Id = 230
            Me.spreadsheetCommandBarButtonItem135.Name = "spreadsheetCommandBarButtonItem135"
            Me.spreadsheetCommandBarButtonItem135.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem136
            ' 
            Me.spreadsheetCommandBarButtonItem136.CommandName = "FormulasCalculateSheet"
            Me.spreadsheetCommandBarButtonItem136.Id = 231
            Me.spreadsheetCommandBarButtonItem136.Name = "spreadsheetCommandBarButtonItem136"
            Me.spreadsheetCommandBarButtonItem136.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarSubItem25
            ' 
            Me.spreadsheetCommandBarSubItem25.CommandName = "DataToolsDataValidationCommandGroup"
            Me.spreadsheetCommandBarSubItem25.Id = 232
            Me.spreadsheetCommandBarSubItem25.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem137), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem138), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem139)})
            Me.spreadsheetCommandBarSubItem25.Name = "spreadsheetCommandBarSubItem25"
            ' 
            ' spreadsheetCommandBarButtonItem137
            ' 
            Me.spreadsheetCommandBarButtonItem137.CommandName = "DataToolsDataValidation"
            Me.spreadsheetCommandBarButtonItem137.Id = 233
            Me.spreadsheetCommandBarButtonItem137.Name = "spreadsheetCommandBarButtonItem137"
            ' 
            ' spreadsheetCommandBarButtonItem138
            ' 
            Me.spreadsheetCommandBarButtonItem138.CommandName = "DataToolsCircleInvalidData"
            Me.spreadsheetCommandBarButtonItem138.Id = 234
            Me.spreadsheetCommandBarButtonItem138.Name = "spreadsheetCommandBarButtonItem138"
            ' 
            ' spreadsheetCommandBarButtonItem139
            ' 
            Me.spreadsheetCommandBarButtonItem139.CommandName = "DataToolsClearValidationCircles"
            Me.spreadsheetCommandBarButtonItem139.Id = 235
            Me.spreadsheetCommandBarButtonItem139.Name = "spreadsheetCommandBarButtonItem139"
            ' 
            ' spreadsheetCommandBarSubItem26
            ' 
            Me.spreadsheetCommandBarSubItem26.CommandName = "OutlineGroupCommandGroup"
            Me.spreadsheetCommandBarSubItem26.Id = 236
            Me.spreadsheetCommandBarSubItem26.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem140), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem141)})
            Me.spreadsheetCommandBarSubItem26.Name = "spreadsheetCommandBarSubItem26"
            Me.spreadsheetCommandBarSubItem26.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem140
            ' 
            Me.spreadsheetCommandBarButtonItem140.CommandName = "GroupOutline"
            Me.spreadsheetCommandBarButtonItem140.Id = 237
            Me.spreadsheetCommandBarButtonItem140.Name = "spreadsheetCommandBarButtonItem140"
            ' 
            ' spreadsheetCommandBarButtonItem141
            ' 
            Me.spreadsheetCommandBarButtonItem141.CommandName = "AutoOutline"
            Me.spreadsheetCommandBarButtonItem141.Id = 238
            Me.spreadsheetCommandBarButtonItem141.Name = "spreadsheetCommandBarButtonItem141"
            ' 
            ' spreadsheetCommandBarSubItem27
            ' 
            Me.spreadsheetCommandBarSubItem27.CommandName = "OutlineUngroupCommandGroup"
            Me.spreadsheetCommandBarSubItem27.Id = 239
            Me.spreadsheetCommandBarSubItem27.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem142), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem143)})
            Me.spreadsheetCommandBarSubItem27.Name = "spreadsheetCommandBarSubItem27"
            Me.spreadsheetCommandBarSubItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem142
            ' 
            Me.spreadsheetCommandBarButtonItem142.CommandName = "UngroupOutline"
            Me.spreadsheetCommandBarButtonItem142.Id = 240
            Me.spreadsheetCommandBarButtonItem142.Name = "spreadsheetCommandBarButtonItem142"
            ' 
            ' spreadsheetCommandBarButtonItem143
            ' 
            Me.spreadsheetCommandBarButtonItem143.CommandName = "ClearOutline"
            Me.spreadsheetCommandBarButtonItem143.Id = 241
            Me.spreadsheetCommandBarButtonItem143.Name = "spreadsheetCommandBarButtonItem143"
            ' 
            ' spreadsheetCommandBarButtonItem144
            ' 
            Me.spreadsheetCommandBarButtonItem144.CommandName = "Subtotal"
            Me.spreadsheetCommandBarButtonItem144.Id = 242
            Me.spreadsheetCommandBarButtonItem144.Name = "spreadsheetCommandBarButtonItem144"
            Me.spreadsheetCommandBarButtonItem144.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem145
            ' 
            Me.spreadsheetCommandBarButtonItem145.CommandName = "ShowDetail"
            Me.spreadsheetCommandBarButtonItem145.Id = 243
            Me.spreadsheetCommandBarButtonItem145.Name = "spreadsheetCommandBarButtonItem145"
            Me.spreadsheetCommandBarButtonItem145.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem146
            ' 
            Me.spreadsheetCommandBarButtonItem146.CommandName = "HideDetail"
            Me.spreadsheetCommandBarButtonItem146.Id = 244
            Me.spreadsheetCommandBarButtonItem146.Name = "spreadsheetCommandBarButtonItem146"
            Me.spreadsheetCommandBarButtonItem146.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem147
            ' 
            Me.spreadsheetCommandBarButtonItem147.CommandName = "ReviewInsertComment"
            Me.spreadsheetCommandBarButtonItem147.Id = 245
            Me.spreadsheetCommandBarButtonItem147.Name = "spreadsheetCommandBarButtonItem147"
            ' 
            ' spreadsheetCommandBarButtonItem148
            ' 
            Me.spreadsheetCommandBarButtonItem148.CommandName = "ReviewEditComment"
            Me.spreadsheetCommandBarButtonItem148.Id = 246
            Me.spreadsheetCommandBarButtonItem148.Name = "spreadsheetCommandBarButtonItem148"
            ' 
            ' spreadsheetCommandBarButtonItem149
            ' 
            Me.spreadsheetCommandBarButtonItem149.CommandName = "ReviewDeleteComment"
            Me.spreadsheetCommandBarButtonItem149.Id = 247
            Me.spreadsheetCommandBarButtonItem149.Name = "spreadsheetCommandBarButtonItem149"
            ' 
            ' spreadsheetCommandBarButtonItem150
            ' 
            Me.spreadsheetCommandBarButtonItem150.CommandName = "ReviewShowHideComment"
            Me.spreadsheetCommandBarButtonItem150.Id = 248
            Me.spreadsheetCommandBarButtonItem150.Name = "spreadsheetCommandBarButtonItem150"
            Me.spreadsheetCommandBarButtonItem150.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem151
            ' 
            Me.spreadsheetCommandBarButtonItem151.CommandName = "ReviewUnprotectSheet"
            Me.spreadsheetCommandBarButtonItem151.Id = 249
            Me.spreadsheetCommandBarButtonItem151.Name = "spreadsheetCommandBarButtonItem151"
            ' 
            ' spreadsheetCommandBarButtonItem152
            ' 
            Me.spreadsheetCommandBarButtonItem152.CommandName = "ReviewProtectWorkbook"
            Me.spreadsheetCommandBarButtonItem152.Id = 250
            Me.spreadsheetCommandBarButtonItem152.Name = "spreadsheetCommandBarButtonItem152"
            ' 
            ' spreadsheetCommandBarButtonItem153
            ' 
            Me.spreadsheetCommandBarButtonItem153.CommandName = "ReviewUnprotectWorkbook"
            Me.spreadsheetCommandBarButtonItem153.Id = 251
            Me.spreadsheetCommandBarButtonItem153.Name = "spreadsheetCommandBarButtonItem153"
            ' 
            ' spreadsheetCommandBarButtonItem154
            ' 
            Me.spreadsheetCommandBarButtonItem154.CommandName = "ReviewShowProtectedRangeManager"
            Me.spreadsheetCommandBarButtonItem154.Id = 252
            Me.spreadsheetCommandBarButtonItem154.Name = "spreadsheetCommandBarButtonItem154"
            ' 
            ' spreadsheetCommandBarButtonItem155
            ' 
            Me.spreadsheetCommandBarButtonItem155.CommandName = "ViewZoom"
            Me.spreadsheetCommandBarButtonItem155.Id = 253
            Me.spreadsheetCommandBarButtonItem155.Name = "spreadsheetCommandBarButtonItem155"
            ' 
            ' spreadsheetCommandBarButtonItem156
            ' 
            Me.spreadsheetCommandBarButtonItem156.CommandName = "ViewZoomOut"
            Me.spreadsheetCommandBarButtonItem156.Id = 254
            Me.spreadsheetCommandBarButtonItem156.Name = "spreadsheetCommandBarButtonItem156"
            ' 
            ' spreadsheetCommandBarButtonItem157
            ' 
            Me.spreadsheetCommandBarButtonItem157.CommandName = "ViewZoomIn"
            Me.spreadsheetCommandBarButtonItem157.Id = 255
            Me.spreadsheetCommandBarButtonItem157.Name = "spreadsheetCommandBarButtonItem157"
            ' 
            ' spreadsheetCommandBarButtonItem158
            ' 
            Me.spreadsheetCommandBarButtonItem158.CommandName = "ViewZoom100Percent"
            Me.spreadsheetCommandBarButtonItem158.Id = 256
            Me.spreadsheetCommandBarButtonItem158.Name = "spreadsheetCommandBarButtonItem158"
            ' 
            ' spreadsheetCommandBarSubItem28
            ' 
            Me.spreadsheetCommandBarSubItem28.CommandName = "ViewFreezePanesCommandGroup"
            Me.spreadsheetCommandBarSubItem28.Id = 257
            Me.spreadsheetCommandBarSubItem28.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem159), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem160), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem161), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem162)})
            Me.spreadsheetCommandBarSubItem28.Name = "spreadsheetCommandBarSubItem28"
            ' 
            ' spreadsheetCommandBarButtonItem159
            ' 
            Me.spreadsheetCommandBarButtonItem159.CommandName = "ViewFreezePanes"
            Me.spreadsheetCommandBarButtonItem159.Id = 258
            Me.spreadsheetCommandBarButtonItem159.Name = "spreadsheetCommandBarButtonItem159"
            ' 
            ' spreadsheetCommandBarButtonItem160
            ' 
            Me.spreadsheetCommandBarButtonItem160.CommandName = "ViewUnfreezePanes"
            Me.spreadsheetCommandBarButtonItem160.Id = 259
            Me.spreadsheetCommandBarButtonItem160.Name = "spreadsheetCommandBarButtonItem160"
            ' 
            ' spreadsheetCommandBarButtonItem161
            ' 
            Me.spreadsheetCommandBarButtonItem161.CommandName = "ViewFreezeTopRow"
            Me.spreadsheetCommandBarButtonItem161.Id = 260
            Me.spreadsheetCommandBarButtonItem161.Name = "spreadsheetCommandBarButtonItem161"
            ' 
            ' spreadsheetCommandBarButtonItem162
            ' 
            Me.spreadsheetCommandBarButtonItem162.CommandName = "ViewFreezeFirstColumn"
            Me.spreadsheetCommandBarButtonItem162.Id = 261
            Me.spreadsheetCommandBarButtonItem162.Name = "spreadsheetCommandBarButtonItem162"
            ' 
            ' spreadsheetCommandBarButtonItem163
            ' 
            Me.spreadsheetCommandBarButtonItem163.CommandName = "ChartChangeType"
            Me.spreadsheetCommandBarButtonItem163.Id = 262
            Me.spreadsheetCommandBarButtonItem163.Name = "spreadsheetCommandBarButtonItem163"
            ' 
            ' spreadsheetCommandBarButtonItem164
            ' 
            Me.spreadsheetCommandBarButtonItem164.CommandName = "ChartSwitchRowColumn"
            Me.spreadsheetCommandBarButtonItem164.Id = 263
            Me.spreadsheetCommandBarButtonItem164.Name = "spreadsheetCommandBarButtonItem164"
            ' 
            ' spreadsheetCommandBarButtonItem165
            ' 
            Me.spreadsheetCommandBarButtonItem165.CommandName = "ChartSelectData"
            Me.spreadsheetCommandBarButtonItem165.Id = 264
            Me.spreadsheetCommandBarButtonItem165.Name = "spreadsheetCommandBarButtonItem165"
            ' 
            ' galleryChartLayoutItem1
            ' 
            ' 
            ' 
            ' 
            Me.galleryChartLayoutItem1.Gallery.ColumnCount = 6
            Me.galleryChartLayoutItem1.Gallery.DrawImageBackground = False
            Me.galleryChartLayoutItem1.Gallery.ImageSize = New System.Drawing.Size(48, 48)
            Me.galleryChartLayoutItem1.Gallery.RowCount = 2
            Me.galleryChartLayoutItem1.Id = 265
            Me.galleryChartLayoutItem1.Name = "galleryChartLayoutItem1"
            ' 
            ' galleryChartStyleItem1
            ' 
            ' 
            ' 
            ' 
            Me.galleryChartStyleItem1.Gallery.ColumnCount = 8
            Me.galleryChartStyleItem1.Gallery.DrawImageBackground = False
            Me.galleryChartStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChartStyleItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.galleryChartStyleItem1.Gallery.ItemSize = New System.Drawing.Size(93, 56)
            Me.galleryChartStyleItem1.Gallery.MinimumColumnCount = 4
            Me.galleryChartStyleItem1.Gallery.RowCount = 6
            Me.galleryChartStyleItem1.Id = 266
            Me.galleryChartStyleItem1.Name = "galleryChartStyleItem1"
            ' 
            ' spreadsheetCommandBarButtonItem166
            ' 
            Me.spreadsheetCommandBarButtonItem166.CommandName = "MoveChart"
            Me.spreadsheetCommandBarButtonItem166.Id = 267
            Me.spreadsheetCommandBarButtonItem166.Name = "spreadsheetCommandBarButtonItem166"
            ' 
            ' spreadsheetCommandBarSubItem29
            ' 
            Me.spreadsheetCommandBarSubItem29.CommandName = "ChartAxesCommandGroup"
            Me.spreadsheetCommandBarSubItem29.Id = 268
            Me.spreadsheetCommandBarSubItem29.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem14)})
            Me.spreadsheetCommandBarSubItem29.Name = "spreadsheetCommandBarSubItem29"
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem13
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem13.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem13.DropDownControl = Me.commandBarGalleryDropDown87
            Me.spreadsheetCommandBarButtonGalleryDropDownItem13.Id = 269
            Me.spreadsheetCommandBarButtonGalleryDropDownItem13.Name = "spreadsheetCommandBarButtonGalleryDropDownItem13"
            ' 
            ' commandBarGalleryDropDown87
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown87.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown87.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup37.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
            spreadsheetCommandGalleryItem142.CommandName = "ChartHidePrimaryHorizontalAxis"
            spreadsheetCommandGalleryItem143.CommandName = "ChartPrimaryHorizontalAxisLeftToRight"
            spreadsheetCommandGalleryItem144.CommandName = "ChartPrimaryHorizontalAxisHideLabels"
            spreadsheetCommandGalleryItem145.CommandName = "ChartPrimaryHorizontalAxisRightToLeft"
            spreadsheetCommandGalleryItem146.CommandName = "ChartPrimaryHorizontalAxisDefault"
            spreadsheetCommandGalleryItem147.CommandName = "ChartPrimaryHorizontalAxisScaleThousands"
            spreadsheetCommandGalleryItem148.CommandName = "ChartPrimaryHorizontalAxisScaleMillions"
            spreadsheetCommandGalleryItem149.CommandName = "ChartPrimaryHorizontalAxisScaleBillions"
            spreadsheetCommandGalleryItem150.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm"
            spreadsheetCommandGalleryItemGroup37.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem142, spreadsheetCommandGalleryItem143, spreadsheetCommandGalleryItem144, spreadsheetCommandGalleryItem145, spreadsheetCommandGalleryItem146, spreadsheetCommandGalleryItem147, spreadsheetCommandGalleryItem148, spreadsheetCommandGalleryItem149, spreadsheetCommandGalleryItem150})
            Me.commandBarGalleryDropDown87.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup37})
            Me.commandBarGalleryDropDown87.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown87.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown87.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown87.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown87.Name = "commandBarGalleryDropDown87"
            Me.commandBarGalleryDropDown87.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem14
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem14.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem14.DropDownControl = Me.commandBarGalleryDropDown88
            Me.spreadsheetCommandBarButtonGalleryDropDownItem14.Id = 270
            Me.spreadsheetCommandBarButtonGalleryDropDownItem14.Name = "spreadsheetCommandBarButtonGalleryDropDownItem14"
            ' 
            ' commandBarGalleryDropDown88
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown88.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown88.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup38.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
            spreadsheetCommandGalleryItem151.CommandName = "ChartHidePrimaryVerticalAxis"
            spreadsheetCommandGalleryItem152.CommandName = "ChartPrimaryVerticalAxisLeftToRight"
            spreadsheetCommandGalleryItem153.CommandName = "ChartPrimaryVerticalAxisHideLabels"
            spreadsheetCommandGalleryItem154.CommandName = "ChartPrimaryVerticalAxisRightToLeft"
            spreadsheetCommandGalleryItem155.CommandName = "ChartPrimaryVerticalAxisDefault"
            spreadsheetCommandGalleryItem156.CommandName = "ChartPrimaryVerticalAxisScaleThousands"
            spreadsheetCommandGalleryItem157.CommandName = "ChartPrimaryVerticalAxisScaleMillions"
            spreadsheetCommandGalleryItem158.CommandName = "ChartPrimaryVerticalAxisScaleBillions"
            spreadsheetCommandGalleryItem159.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm"
            spreadsheetCommandGalleryItemGroup38.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem151, spreadsheetCommandGalleryItem152, spreadsheetCommandGalleryItem153, spreadsheetCommandGalleryItem154, spreadsheetCommandGalleryItem155, spreadsheetCommandGalleryItem156, spreadsheetCommandGalleryItem157, spreadsheetCommandGalleryItem158, spreadsheetCommandGalleryItem159})
            Me.commandBarGalleryDropDown88.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup38})
            Me.commandBarGalleryDropDown88.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown88.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown88.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown88.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown88.Name = "commandBarGalleryDropDown88"
            Me.commandBarGalleryDropDown88.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarSubItem30
            ' 
            Me.spreadsheetCommandBarSubItem30.CommandName = "ChartGridlinesCommandGroup"
            Me.spreadsheetCommandBarSubItem30.Id = 271
            Me.spreadsheetCommandBarSubItem30.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem16)})
            Me.spreadsheetCommandBarSubItem30.Name = "spreadsheetCommandBarSubItem30"
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem15
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem15.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem15.DropDownControl = Me.commandBarGalleryDropDown89
            Me.spreadsheetCommandBarButtonGalleryDropDownItem15.Id = 272
            Me.spreadsheetCommandBarButtonGalleryDropDownItem15.Name = "spreadsheetCommandBarButtonGalleryDropDownItem15"
            ' 
            ' commandBarGalleryDropDown89
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown89.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown89.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup39.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
            spreadsheetCommandGalleryItem160.CommandName = "ChartPrimaryHorizontalGridlinesNone"
            spreadsheetCommandGalleryItem161.CommandName = "ChartPrimaryHorizontalGridlinesMajor"
            spreadsheetCommandGalleryItem162.CommandName = "ChartPrimaryHorizontalGridlinesMinor"
            spreadsheetCommandGalleryItem163.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor"
            spreadsheetCommandGalleryItemGroup39.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem160, spreadsheetCommandGalleryItem161, spreadsheetCommandGalleryItem162, spreadsheetCommandGalleryItem163})
            Me.commandBarGalleryDropDown89.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup39})
            Me.commandBarGalleryDropDown89.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown89.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown89.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown89.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown89.Name = "commandBarGalleryDropDown89"
            Me.commandBarGalleryDropDown89.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem16
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem16.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem16.DropDownControl = Me.commandBarGalleryDropDown90
            Me.spreadsheetCommandBarButtonGalleryDropDownItem16.Id = 273
            Me.spreadsheetCommandBarButtonGalleryDropDownItem16.Name = "spreadsheetCommandBarButtonGalleryDropDownItem16"
            ' 
            ' commandBarGalleryDropDown90
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown90.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown90.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup40.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
            spreadsheetCommandGalleryItem164.CommandName = "ChartPrimaryVerticalGridlinesNone"
            spreadsheetCommandGalleryItem165.CommandName = "ChartPrimaryVerticalGridlinesMajor"
            spreadsheetCommandGalleryItem166.CommandName = "ChartPrimaryVerticalGridlinesMinor"
            spreadsheetCommandGalleryItem167.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor"
            spreadsheetCommandGalleryItemGroup40.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem164, spreadsheetCommandGalleryItem165, spreadsheetCommandGalleryItem166, spreadsheetCommandGalleryItem167})
            Me.commandBarGalleryDropDown90.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup40})
            Me.commandBarGalleryDropDown90.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown90.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown90.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown90.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown90.Name = "commandBarGalleryDropDown90"
            Me.commandBarGalleryDropDown90.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem17
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem17.CommandName = "ChartTitleCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem17.DropDownControl = Me.commandBarGalleryDropDown91
            Me.spreadsheetCommandBarButtonGalleryDropDownItem17.Id = 274
            Me.spreadsheetCommandBarButtonGalleryDropDownItem17.Name = "spreadsheetCommandBarButtonGalleryDropDownItem17"
            ' 
            ' commandBarGalleryDropDown91
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown91.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown91.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup41.CommandName = "ChartTitleCommandGroup"
            spreadsheetCommandGalleryItem168.CommandName = "ChartTitleNone"
            spreadsheetCommandGalleryItem169.CommandName = "ChartTitleCenteredOverlay"
            spreadsheetCommandGalleryItem170.CommandName = "ChartTitleAbove"
            spreadsheetCommandGalleryItemGroup41.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem168, spreadsheetCommandGalleryItem169, spreadsheetCommandGalleryItem170})
            Me.commandBarGalleryDropDown91.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup41})
            Me.commandBarGalleryDropDown91.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown91.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown91.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown91.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown91.Name = "commandBarGalleryDropDown91"
            Me.commandBarGalleryDropDown91.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarSubItem31
            ' 
            Me.spreadsheetCommandBarSubItem31.CommandName = "ChartAxisTitlesCommandGroup"
            Me.spreadsheetCommandBarSubItem31.Id = 275
            Me.spreadsheetCommandBarSubItem31.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem19)})
            Me.spreadsheetCommandBarSubItem31.Name = "spreadsheetCommandBarSubItem31"
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem18
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem18.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem18.DropDownControl = Me.commandBarGalleryDropDown92
            Me.spreadsheetCommandBarButtonGalleryDropDownItem18.Id = 276
            Me.spreadsheetCommandBarButtonGalleryDropDownItem18.Name = "spreadsheetCommandBarButtonGalleryDropDownItem18"
            ' 
            ' commandBarGalleryDropDown92
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown92.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown92.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup42.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
            spreadsheetCommandGalleryItem171.CommandName = "ChartPrimaryHorizontalAxisTitleNone"
            spreadsheetCommandGalleryItem172.CommandName = "ChartPrimaryHorizontalAxisTitleBelow"
            spreadsheetCommandGalleryItemGroup42.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem171, spreadsheetCommandGalleryItem172})
            Me.commandBarGalleryDropDown92.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup42})
            Me.commandBarGalleryDropDown92.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown92.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown92.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown92.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown92.Name = "commandBarGalleryDropDown92"
            Me.commandBarGalleryDropDown92.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem19
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem19.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem19.DropDownControl = Me.commandBarGalleryDropDown93
            Me.spreadsheetCommandBarButtonGalleryDropDownItem19.Id = 277
            Me.spreadsheetCommandBarButtonGalleryDropDownItem19.Name = "spreadsheetCommandBarButtonGalleryDropDownItem19"
            ' 
            ' commandBarGalleryDropDown93
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown93.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown93.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup43.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
            spreadsheetCommandGalleryItem173.CommandName = "ChartPrimaryVerticalAxisTitleNone"
            spreadsheetCommandGalleryItem174.CommandName = "ChartPrimaryVerticalAxisTitleRotated"
            spreadsheetCommandGalleryItemGroup43.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem173, spreadsheetCommandGalleryItem174})
            Me.commandBarGalleryDropDown93.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup43})
            Me.commandBarGalleryDropDown93.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown93.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown93.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown93.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown93.Name = "commandBarGalleryDropDown93"
            Me.commandBarGalleryDropDown93.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem20
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem20.CommandName = "ChartLegendCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem20.DropDownControl = Me.commandBarGalleryDropDown94
            Me.spreadsheetCommandBarButtonGalleryDropDownItem20.Id = 278
            Me.spreadsheetCommandBarButtonGalleryDropDownItem20.Name = "spreadsheetCommandBarButtonGalleryDropDownItem20"
            ' 
            ' commandBarGalleryDropDown94
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown94.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown94.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup44.CommandName = "ChartLegendCommandGroup"
            spreadsheetCommandGalleryItem177.CommandName = "ChartLegendNone"
            spreadsheetCommandGalleryItem178.CommandName = "ChartLegendAtRight"
            spreadsheetCommandGalleryItem179.CommandName = "ChartLegendAtTop"
            spreadsheetCommandGalleryItem180.CommandName = "ChartLegendAtLeft"
            spreadsheetCommandGalleryItem181.CommandName = "ChartLegendAtBottom"
            spreadsheetCommandGalleryItem182.CommandName = "ChartLegendOverlayAtRight"
            spreadsheetCommandGalleryItem183.CommandName = "ChartLegendOverlayAtLeft"
            spreadsheetCommandGalleryItemGroup44.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem177, spreadsheetCommandGalleryItem178, spreadsheetCommandGalleryItem179, spreadsheetCommandGalleryItem180, spreadsheetCommandGalleryItem181, spreadsheetCommandGalleryItem182, spreadsheetCommandGalleryItem183})
            Me.commandBarGalleryDropDown94.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup44})
            Me.commandBarGalleryDropDown94.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown94.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown94.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown94.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown94.Name = "commandBarGalleryDropDown94"
            Me.commandBarGalleryDropDown94.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem21
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem21.CommandName = "ChartDataLabelsCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem21.DropDownControl = Me.commandBarGalleryDropDown95
            Me.spreadsheetCommandBarButtonGalleryDropDownItem21.Id = 279
            Me.spreadsheetCommandBarButtonGalleryDropDownItem21.Name = "spreadsheetCommandBarButtonGalleryDropDownItem21"
            ' 
            ' commandBarGalleryDropDown95
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown95.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown95.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup45.CommandName = "ChartDataLabelsCommandGroup"
            spreadsheetCommandGalleryItem184.CommandName = "ChartDataLabelsNone"
            spreadsheetCommandGalleryItem185.CommandName = "ChartDataLabelsDefault"
            spreadsheetCommandGalleryItem186.CommandName = "ChartDataLabelsCenter"
            spreadsheetCommandGalleryItem187.CommandName = "ChartDataLabelsInsideEnd"
            spreadsheetCommandGalleryItem188.CommandName = "ChartDataLabelsInsideBase"
            spreadsheetCommandGalleryItem189.CommandName = "ChartDataLabelsOutsideEnd"
            spreadsheetCommandGalleryItem190.CommandName = "ChartDataLabelsBestFit"
            spreadsheetCommandGalleryItem191.CommandName = "ChartDataLabelsLeft"
            spreadsheetCommandGalleryItem192.CommandName = "ChartDataLabelsRight"
            spreadsheetCommandGalleryItem193.CommandName = "ChartDataLabelsAbove"
            spreadsheetCommandGalleryItem194.CommandName = "ChartDataLabelsBelow"
            spreadsheetCommandGalleryItemGroup45.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem184, spreadsheetCommandGalleryItem185, spreadsheetCommandGalleryItem186, spreadsheetCommandGalleryItem187, spreadsheetCommandGalleryItem188, spreadsheetCommandGalleryItem189, spreadsheetCommandGalleryItem190, spreadsheetCommandGalleryItem191, spreadsheetCommandGalleryItem192, spreadsheetCommandGalleryItem193, spreadsheetCommandGalleryItem194})
            Me.commandBarGalleryDropDown95.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup45})
            Me.commandBarGalleryDropDown95.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown95.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown95.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown95.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown95.Name = "commandBarGalleryDropDown95"
            Me.commandBarGalleryDropDown95.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem22
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem22.CommandName = "ChartLinesCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem22.DropDownControl = Me.commandBarGalleryDropDown96
            Me.spreadsheetCommandBarButtonGalleryDropDownItem22.Id = 280
            Me.spreadsheetCommandBarButtonGalleryDropDownItem22.Name = "spreadsheetCommandBarButtonGalleryDropDownItem22"
            ' 
            ' commandBarGalleryDropDown96
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown96.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown96.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup46.CommandName = "ChartLinesCommandGroup"
            spreadsheetCommandGalleryItem195.CommandName = "ChartLinesNone"
            spreadsheetCommandGalleryItem196.CommandName = "ChartShowDropLines"
            spreadsheetCommandGalleryItem197.CommandName = "ChartShowHighLowLines"
            spreadsheetCommandGalleryItem198.CommandName = "ChartShowDropLinesAndHighLowLines"
            spreadsheetCommandGalleryItem199.CommandName = "ChartShowSeriesLines"
            spreadsheetCommandGalleryItemGroup46.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem195, spreadsheetCommandGalleryItem196, spreadsheetCommandGalleryItem197, spreadsheetCommandGalleryItem198, spreadsheetCommandGalleryItem199})
            Me.commandBarGalleryDropDown96.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup46})
            Me.commandBarGalleryDropDown96.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown96.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown96.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown96.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown96.Name = "commandBarGalleryDropDown96"
            Me.commandBarGalleryDropDown96.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem23
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem23.CommandName = "ChartUpDownBarsCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem23.DropDownControl = Me.commandBarGalleryDropDown97
            Me.spreadsheetCommandBarButtonGalleryDropDownItem23.Id = 281
            Me.spreadsheetCommandBarButtonGalleryDropDownItem23.Name = "spreadsheetCommandBarButtonGalleryDropDownItem23"
            ' 
            ' commandBarGalleryDropDown97
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown97.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown97.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup47.CommandName = "ChartUpDownBarsCommandGroup"
            spreadsheetCommandGalleryItem200.CommandName = "ChartHideUpDownBars"
            spreadsheetCommandGalleryItem201.CommandName = "ChartShowUpDownBars"
            spreadsheetCommandGalleryItemGroup47.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem200, spreadsheetCommandGalleryItem201})
            Me.commandBarGalleryDropDown97.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup47})
            Me.commandBarGalleryDropDown97.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown97.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown97.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown97.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown97.Name = "commandBarGalleryDropDown97"
            Me.commandBarGalleryDropDown97.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem24
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem24.CommandName = "ChartErrorBarsCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem24.DropDownControl = Me.commandBarGalleryDropDown98
            Me.spreadsheetCommandBarButtonGalleryDropDownItem24.Id = 282
            Me.spreadsheetCommandBarButtonGalleryDropDownItem24.Name = "spreadsheetCommandBarButtonGalleryDropDownItem24"
            ' 
            ' commandBarGalleryDropDown98
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown98.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown98.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Vertical
            spreadsheetCommandGalleryItemGroup48.CommandName = "ChartErrorBarsCommandGroup"
            spreadsheetCommandGalleryItem202.CommandName = "ChartErrorBarsNone"
            spreadsheetCommandGalleryItem203.CommandName = "ChartErrorBarsStandardError"
            spreadsheetCommandGalleryItem204.CommandName = "ChartErrorBarsPercentage"
            spreadsheetCommandGalleryItem205.CommandName = "ChartErrorBarsStandardDeviation"
            spreadsheetCommandGalleryItemGroup48.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem202, spreadsheetCommandGalleryItem203, spreadsheetCommandGalleryItem204, spreadsheetCommandGalleryItem205})
            Me.commandBarGalleryDropDown98.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup48})
            Me.commandBarGalleryDropDown98.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown98.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown98.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown98.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown98.Name = "commandBarGalleryDropDown98"
            Me.commandBarGalleryDropDown98.Ribbon = Me.ribbonControl1
            ' 
            ' renameTableItemCaption1
            ' 
            Me.renameTableItemCaption1.Id = 283
            Me.renameTableItemCaption1.Name = "renameTableItemCaption1"
            ' 
            ' renameTableItem1
            ' 
            Me.renameTableItem1.Edit = Me.repositoryItemTextEdit1
            Me.renameTableItem1.Id = 284
            Me.renameTableItem1.Name = "renameTableItem1"
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' spreadsheetCommandBarCheckItem27
            ' 
            Me.spreadsheetCommandBarCheckItem27.CommandName = "TableToolsConvertToRange"
            Me.spreadsheetCommandBarCheckItem27.Id = 285
            Me.spreadsheetCommandBarCheckItem27.Name = "spreadsheetCommandBarCheckItem27"
            Me.spreadsheetCommandBarCheckItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarCheckItem28
            ' 
            Me.spreadsheetCommandBarCheckItem28.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem28.CommandName = "TableToolsToggleHeaderRow"
            Me.spreadsheetCommandBarCheckItem28.Id = 286
            Me.spreadsheetCommandBarCheckItem28.Name = "spreadsheetCommandBarCheckItem28"
            ' 
            ' spreadsheetCommandBarCheckItem29
            ' 
            Me.spreadsheetCommandBarCheckItem29.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem29.CommandName = "TableToolsToggleTotalRow"
            Me.spreadsheetCommandBarCheckItem29.Id = 287
            Me.spreadsheetCommandBarCheckItem29.Name = "spreadsheetCommandBarCheckItem29"
            ' 
            ' spreadsheetCommandBarCheckItem30
            ' 
            Me.spreadsheetCommandBarCheckItem30.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem30.CommandName = "TableToolsToggleBandedColumns"
            Me.spreadsheetCommandBarCheckItem30.Id = 288
            Me.spreadsheetCommandBarCheckItem30.Name = "spreadsheetCommandBarCheckItem30"
            ' 
            ' spreadsheetCommandBarCheckItem31
            ' 
            Me.spreadsheetCommandBarCheckItem31.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem31.CommandName = "TableToolsToggleFirstColumn"
            Me.spreadsheetCommandBarCheckItem31.Id = 289
            Me.spreadsheetCommandBarCheckItem31.Name = "spreadsheetCommandBarCheckItem31"
            ' 
            ' spreadsheetCommandBarCheckItem32
            ' 
            Me.spreadsheetCommandBarCheckItem32.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem32.CommandName = "TableToolsToggleLastColumn"
            Me.spreadsheetCommandBarCheckItem32.Id = 290
            Me.spreadsheetCommandBarCheckItem32.Name = "spreadsheetCommandBarCheckItem32"
            ' 
            ' spreadsheetCommandBarCheckItem33
            ' 
            Me.spreadsheetCommandBarCheckItem33.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem33.CommandName = "TableToolsToggleBandedRows"
            Me.spreadsheetCommandBarCheckItem33.Id = 291
            Me.spreadsheetCommandBarCheckItem33.Name = "spreadsheetCommandBarCheckItem33"
            ' 
            ' galleryTableStylesItem1
            ' 
            ' 
            ' 
            ' 
            Me.galleryTableStylesItem1.Gallery.ColumnCount = 7
            Me.galleryTableStylesItem1.Gallery.DrawImageBackground = False
            Me.galleryTableStylesItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryTableStylesItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.galleryTableStylesItem1.Gallery.ItemSize = New System.Drawing.Size(73, 58)
            Me.galleryTableStylesItem1.Gallery.RowCount = 10
            Me.galleryTableStylesItem1.Id = 292
            Me.galleryTableStylesItem1.Name = "galleryTableStylesItem1"
            ' 
            ' spreadsheetCommandBarButtonItem167
            ' 
            Me.spreadsheetCommandBarButtonItem167.CommandName = "OptionsPivotTable"
            Me.spreadsheetCommandBarButtonItem167.Id = 293
            Me.spreadsheetCommandBarButtonItem167.Name = "spreadsheetCommandBarButtonItem167"
            ' 
            ' spreadsheetCommandBarButtonItem168
            ' 
            Me.spreadsheetCommandBarButtonItem168.CommandName = "SelectFieldTypePivotTable"
            Me.spreadsheetCommandBarButtonItem168.Id = 294
            Me.spreadsheetCommandBarButtonItem168.Name = "spreadsheetCommandBarButtonItem168"
            ' 
            ' spreadsheetCommandBarButtonItem169
            ' 
            Me.spreadsheetCommandBarButtonItem169.CommandName = "PivotTableExpandField"
            Me.spreadsheetCommandBarButtonItem169.Id = 295
            Me.spreadsheetCommandBarButtonItem169.Name = "spreadsheetCommandBarButtonItem169"
            Me.spreadsheetCommandBarButtonItem169.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem170
            ' 
            Me.spreadsheetCommandBarButtonItem170.CommandName = "PivotTableCollapseField"
            Me.spreadsheetCommandBarButtonItem170.Id = 296
            Me.spreadsheetCommandBarButtonItem170.Name = "spreadsheetCommandBarButtonItem170"
            Me.spreadsheetCommandBarButtonItem170.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem171
            ' 
            Me.spreadsheetCommandBarButtonItem171.CommandName = "PivotTableGroupSelection"
            Me.spreadsheetCommandBarButtonItem171.Id = 297
            Me.spreadsheetCommandBarButtonItem171.Name = "spreadsheetCommandBarButtonItem171"
            Me.spreadsheetCommandBarButtonItem171.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem172
            ' 
            Me.spreadsheetCommandBarButtonItem172.CommandName = "PivotTableUngroup"
            Me.spreadsheetCommandBarButtonItem172.Id = 298
            Me.spreadsheetCommandBarButtonItem172.Name = "spreadsheetCommandBarButtonItem172"
            Me.spreadsheetCommandBarButtonItem172.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem173
            ' 
            Me.spreadsheetCommandBarButtonItem173.CommandName = "PivotTableGroupField"
            Me.spreadsheetCommandBarButtonItem173.Id = 299
            Me.spreadsheetCommandBarButtonItem173.Name = "spreadsheetCommandBarButtonItem173"
            Me.spreadsheetCommandBarButtonItem173.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarSubItem32
            ' 
            Me.spreadsheetCommandBarSubItem32.CommandName = "PivotTableDataRefreshGroup"
            Me.spreadsheetCommandBarSubItem32.Id = 300
            Me.spreadsheetCommandBarSubItem32.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem174), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem175)})
            Me.spreadsheetCommandBarSubItem32.Name = "spreadsheetCommandBarSubItem32"
            ' 
            ' spreadsheetCommandBarButtonItem174
            ' 
            Me.spreadsheetCommandBarButtonItem174.CommandName = "RefreshPivotTable"
            Me.spreadsheetCommandBarButtonItem174.Id = 301
            Me.spreadsheetCommandBarButtonItem174.Name = "spreadsheetCommandBarButtonItem174"
            ' 
            ' spreadsheetCommandBarButtonItem175
            ' 
            Me.spreadsheetCommandBarButtonItem175.CommandName = "RefreshAllPivotTable"
            Me.spreadsheetCommandBarButtonItem175.Id = 302
            Me.spreadsheetCommandBarButtonItem175.Name = "spreadsheetCommandBarButtonItem175"
            ' 
            ' spreadsheetCommandBarButtonItem176
            ' 
            Me.spreadsheetCommandBarButtonItem176.CommandName = "ChangeDataSourcePivotTable"
            Me.spreadsheetCommandBarButtonItem176.Id = 303
            Me.spreadsheetCommandBarButtonItem176.Name = "spreadsheetCommandBarButtonItem176"
            ' 
            ' spreadsheetCommandBarSubItem33
            ' 
            Me.spreadsheetCommandBarSubItem33.CommandName = "PivotTableActionsClearGroup"
            Me.spreadsheetCommandBarSubItem33.Id = 304
            Me.spreadsheetCommandBarSubItem33.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem177), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem178)})
            Me.spreadsheetCommandBarSubItem33.Name = "spreadsheetCommandBarSubItem33"
            ' 
            ' spreadsheetCommandBarButtonItem177
            ' 
            Me.spreadsheetCommandBarButtonItem177.CommandName = "ClearAllPivotTable"
            Me.spreadsheetCommandBarButtonItem177.Id = 305
            Me.spreadsheetCommandBarButtonItem177.Name = "spreadsheetCommandBarButtonItem177"
            ' 
            ' spreadsheetCommandBarButtonItem178
            ' 
            Me.spreadsheetCommandBarButtonItem178.CommandName = "ClearFiltersPivotTable"
            Me.spreadsheetCommandBarButtonItem178.Id = 306
            Me.spreadsheetCommandBarButtonItem178.Name = "spreadsheetCommandBarButtonItem178"
            ' 
            ' spreadsheetCommandBarSubItem34
            ' 
            Me.spreadsheetCommandBarSubItem34.CommandName = "PivotTableActionsSelectGroup"
            Me.spreadsheetCommandBarSubItem34.Id = 307
            Me.spreadsheetCommandBarSubItem34.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem179), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem180), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem181)})
            Me.spreadsheetCommandBarSubItem34.Name = "spreadsheetCommandBarSubItem34"
            ' 
            ' spreadsheetCommandBarButtonItem179
            ' 
            Me.spreadsheetCommandBarButtonItem179.CommandName = "SelectValuesPivotTable"
            Me.spreadsheetCommandBarButtonItem179.Id = 308
            Me.spreadsheetCommandBarButtonItem179.Name = "spreadsheetCommandBarButtonItem179"
            ' 
            ' spreadsheetCommandBarButtonItem180
            ' 
            Me.spreadsheetCommandBarButtonItem180.CommandName = "SelectLabelsPivotTable"
            Me.spreadsheetCommandBarButtonItem180.Id = 309
            Me.spreadsheetCommandBarButtonItem180.Name = "spreadsheetCommandBarButtonItem180"
            ' 
            ' spreadsheetCommandBarButtonItem181
            ' 
            Me.spreadsheetCommandBarButtonItem181.CommandName = "SelectEntirePivotTable"
            Me.spreadsheetCommandBarButtonItem181.Id = 310
            Me.spreadsheetCommandBarButtonItem181.Name = "spreadsheetCommandBarButtonItem181"
            ' 
            ' spreadsheetCommandBarButtonItem182
            ' 
            Me.spreadsheetCommandBarButtonItem182.CommandName = "MovePivotTable"
            Me.spreadsheetCommandBarButtonItem182.Id = 311
            Me.spreadsheetCommandBarButtonItem182.Name = "spreadsheetCommandBarButtonItem182"
            ' 
            ' spreadsheetCommandBarSubItem35
            ' 
            Me.spreadsheetCommandBarSubItem35.CommandName = "PivotTableCalculationFieldsItemsSetsGroup"
            Me.spreadsheetCommandBarSubItem35.Id = 312
            Me.spreadsheetCommandBarSubItem35.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem183), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem184), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem185), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem186)})
            Me.spreadsheetCommandBarSubItem35.Name = "spreadsheetCommandBarSubItem35"
            ' 
            ' spreadsheetCommandBarButtonItem183
            ' 
            Me.spreadsheetCommandBarButtonItem183.CommandName = "PivotTableCalculatedField"
            Me.spreadsheetCommandBarButtonItem183.Id = 313
            Me.spreadsheetCommandBarButtonItem183.Name = "spreadsheetCommandBarButtonItem183"
            ' 
            ' spreadsheetCommandBarButtonItem184
            ' 
            Me.spreadsheetCommandBarButtonItem184.CommandName = "PivotTableCalculatedItem"
            Me.spreadsheetCommandBarButtonItem184.Id = 314
            Me.spreadsheetCommandBarButtonItem184.Name = "spreadsheetCommandBarButtonItem184"
            ' 
            ' spreadsheetCommandBarButtonItem185
            ' 
            Me.spreadsheetCommandBarButtonItem185.CommandName = "PivotTableCalculatedItemSolveOrder"
            Me.spreadsheetCommandBarButtonItem185.Id = 315
            Me.spreadsheetCommandBarButtonItem185.Name = "spreadsheetCommandBarButtonItem185"
            ' 
            ' spreadsheetCommandBarButtonItem186
            ' 
            Me.spreadsheetCommandBarButtonItem186.CommandName = "PivotTableListFormulas"
            Me.spreadsheetCommandBarButtonItem186.Id = 316
            Me.spreadsheetCommandBarButtonItem186.Name = "spreadsheetCommandBarButtonItem186"
            ' 
            ' spreadsheetCommandBarCheckItem34
            ' 
            Me.spreadsheetCommandBarCheckItem34.CommandName = "FieldListPanelPivotTable"
            Me.spreadsheetCommandBarCheckItem34.Id = 317
            Me.spreadsheetCommandBarCheckItem34.Name = "spreadsheetCommandBarCheckItem34"
            ' 
            ' spreadsheetCommandBarCheckItem35
            ' 
            Me.spreadsheetCommandBarCheckItem35.CommandName = "ShowPivotTableExpandCollapseButtons"
            Me.spreadsheetCommandBarCheckItem35.Id = 318
            Me.spreadsheetCommandBarCheckItem35.Name = "spreadsheetCommandBarCheckItem35"
            ' 
            ' spreadsheetCommandBarCheckItem36
            ' 
            Me.spreadsheetCommandBarCheckItem36.CommandName = "ShowPivotTableFieldHeaders"
            Me.spreadsheetCommandBarCheckItem36.Id = 319
            Me.spreadsheetCommandBarCheckItem36.Name = "spreadsheetCommandBarCheckItem36"
            ' 
            ' spreadsheetCommandBarSubItem36
            ' 
            Me.spreadsheetCommandBarSubItem36.CommandName = "PivotTableLayoutSubtotalsGroup"
            Me.spreadsheetCommandBarSubItem36.Id = 320
            Me.spreadsheetCommandBarSubItem36.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem187), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem188), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem189)})
            Me.spreadsheetCommandBarSubItem36.Name = "spreadsheetCommandBarSubItem36"
            ' 
            ' spreadsheetCommandBarButtonItem187
            ' 
            Me.spreadsheetCommandBarButtonItem187.CommandName = "PivotTableDoNotShowSubtotals"
            Me.spreadsheetCommandBarButtonItem187.Id = 321
            Me.spreadsheetCommandBarButtonItem187.Name = "spreadsheetCommandBarButtonItem187"
            Me.spreadsheetCommandBarButtonItem187.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem188
            ' 
            Me.spreadsheetCommandBarButtonItem188.CommandName = "PivotTableShowAllSubtotalsAtBottom"
            Me.spreadsheetCommandBarButtonItem188.Id = 322
            Me.spreadsheetCommandBarButtonItem188.Name = "spreadsheetCommandBarButtonItem188"
            Me.spreadsheetCommandBarButtonItem188.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem189
            ' 
            Me.spreadsheetCommandBarButtonItem189.CommandName = "PivotTableShowAllSubtotalsAtTop"
            Me.spreadsheetCommandBarButtonItem189.Id = 323
            Me.spreadsheetCommandBarButtonItem189.Name = "spreadsheetCommandBarButtonItem189"
            Me.spreadsheetCommandBarButtonItem189.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarSubItem37
            ' 
            Me.spreadsheetCommandBarSubItem37.CommandName = "PivotTableLayoutGrandTotalsGroup"
            Me.spreadsheetCommandBarSubItem37.Id = 324
            Me.spreadsheetCommandBarSubItem37.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem190), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem191), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem192), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem193)})
            Me.spreadsheetCommandBarSubItem37.Name = "spreadsheetCommandBarSubItem37"
            ' 
            ' spreadsheetCommandBarButtonItem190
            ' 
            Me.spreadsheetCommandBarButtonItem190.CommandName = "PivotTableGrandTotalsOffRowsColumns"
            Me.spreadsheetCommandBarButtonItem190.Id = 325
            Me.spreadsheetCommandBarButtonItem190.Name = "spreadsheetCommandBarButtonItem190"
            Me.spreadsheetCommandBarButtonItem190.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem191
            ' 
            Me.spreadsheetCommandBarButtonItem191.CommandName = "PivotTableGrandTotalsOnRowsColumns"
            Me.spreadsheetCommandBarButtonItem191.Id = 326
            Me.spreadsheetCommandBarButtonItem191.Name = "spreadsheetCommandBarButtonItem191"
            Me.spreadsheetCommandBarButtonItem191.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem192
            ' 
            Me.spreadsheetCommandBarButtonItem192.CommandName = "PivotTableGrandTotalsOnRowsOnly"
            Me.spreadsheetCommandBarButtonItem192.Id = 327
            Me.spreadsheetCommandBarButtonItem192.Name = "spreadsheetCommandBarButtonItem192"
            Me.spreadsheetCommandBarButtonItem192.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem193
            ' 
            Me.spreadsheetCommandBarButtonItem193.CommandName = "PivotTableGrandTotalsOnColumnsOnly"
            Me.spreadsheetCommandBarButtonItem193.Id = 328
            Me.spreadsheetCommandBarButtonItem193.Name = "spreadsheetCommandBarButtonItem193"
            Me.spreadsheetCommandBarButtonItem193.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarSubItem38
            ' 
            Me.spreadsheetCommandBarSubItem38.CommandName = "PivotTableLayoutReportLayoutGroup"
            Me.spreadsheetCommandBarSubItem38.Id = 329
            Me.spreadsheetCommandBarSubItem38.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem194), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem195), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem196), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem197), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem198)})
            Me.spreadsheetCommandBarSubItem38.Name = "spreadsheetCommandBarSubItem38"
            ' 
            ' spreadsheetCommandBarButtonItem194
            ' 
            Me.spreadsheetCommandBarButtonItem194.CommandName = "PivotTableShowCompactForm"
            Me.spreadsheetCommandBarButtonItem194.Id = 330
            Me.spreadsheetCommandBarButtonItem194.Name = "spreadsheetCommandBarButtonItem194"
            Me.spreadsheetCommandBarButtonItem194.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem195
            ' 
            Me.spreadsheetCommandBarButtonItem195.CommandName = "PivotTableShowOutlineForm"
            Me.spreadsheetCommandBarButtonItem195.Id = 331
            Me.spreadsheetCommandBarButtonItem195.Name = "spreadsheetCommandBarButtonItem195"
            Me.spreadsheetCommandBarButtonItem195.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem196
            ' 
            Me.spreadsheetCommandBarButtonItem196.CommandName = "PivotTableShowTabularForm"
            Me.spreadsheetCommandBarButtonItem196.Id = 332
            Me.spreadsheetCommandBarButtonItem196.Name = "spreadsheetCommandBarButtonItem196"
            Me.spreadsheetCommandBarButtonItem196.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem197
            ' 
            Me.spreadsheetCommandBarButtonItem197.CommandName = "PivotTableRepeatAllItemLabels"
            Me.spreadsheetCommandBarButtonItem197.Id = 333
            Me.spreadsheetCommandBarButtonItem197.Name = "spreadsheetCommandBarButtonItem197"
            Me.spreadsheetCommandBarButtonItem197.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem198
            ' 
            Me.spreadsheetCommandBarButtonItem198.CommandName = "PivotTableDoNotRepeatItemLabels"
            Me.spreadsheetCommandBarButtonItem198.Id = 334
            Me.spreadsheetCommandBarButtonItem198.Name = "spreadsheetCommandBarButtonItem198"
            Me.spreadsheetCommandBarButtonItem198.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarSubItem39
            ' 
            Me.spreadsheetCommandBarSubItem39.CommandName = "PivotTableLayoutBlankRowsGroup"
            Me.spreadsheetCommandBarSubItem39.Id = 335
            Me.spreadsheetCommandBarSubItem39.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem199), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem200)})
            Me.spreadsheetCommandBarSubItem39.Name = "spreadsheetCommandBarSubItem39"
            ' 
            ' spreadsheetCommandBarButtonItem199
            ' 
            Me.spreadsheetCommandBarButtonItem199.CommandName = "PivotTableInsertBlankLineEachItem"
            Me.spreadsheetCommandBarButtonItem199.Id = 336
            Me.spreadsheetCommandBarButtonItem199.Name = "spreadsheetCommandBarButtonItem199"
            Me.spreadsheetCommandBarButtonItem199.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem200
            ' 
            Me.spreadsheetCommandBarButtonItem200.CommandName = "PivotTableRemoveBlankLineEachItem"
            Me.spreadsheetCommandBarButtonItem200.Id = 337
            Me.spreadsheetCommandBarButtonItem200.Name = "spreadsheetCommandBarButtonItem200"
            Me.spreadsheetCommandBarButtonItem200.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarCheckItem37
            ' 
            Me.spreadsheetCommandBarCheckItem37.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem37.CommandName = "PivotTableToggleRowHeaders"
            Me.spreadsheetCommandBarCheckItem37.Id = 338
            Me.spreadsheetCommandBarCheckItem37.Name = "spreadsheetCommandBarCheckItem37"
            ' 
            ' spreadsheetCommandBarCheckItem38
            ' 
            Me.spreadsheetCommandBarCheckItem38.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem38.CommandName = "PivotTableToggleColumnHeaders"
            Me.spreadsheetCommandBarCheckItem38.Id = 339
            Me.spreadsheetCommandBarCheckItem38.Name = "spreadsheetCommandBarCheckItem38"
            ' 
            ' spreadsheetCommandBarCheckItem39
            ' 
            Me.spreadsheetCommandBarCheckItem39.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem39.CommandName = "PivotTableToggleBandedRows"
            Me.spreadsheetCommandBarCheckItem39.Id = 340
            Me.spreadsheetCommandBarCheckItem39.Name = "spreadsheetCommandBarCheckItem39"
            ' 
            ' spreadsheetCommandBarCheckItem40
            ' 
            Me.spreadsheetCommandBarCheckItem40.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.spreadsheetCommandBarCheckItem40.CommandName = "PivotTableToggleBandedColumns"
            Me.spreadsheetCommandBarCheckItem40.Id = 341
            Me.spreadsheetCommandBarCheckItem40.Name = "spreadsheetCommandBarCheckItem40"
            ' 
            ' galleryPivotStylesItem1
            ' 
            ' 
            ' 
            ' 
            Me.galleryPivotStylesItem1.Gallery.ColumnCount = 7
            Me.galleryPivotStylesItem1.Gallery.DrawImageBackground = False
            Me.galleryPivotStylesItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryPivotStylesItem1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.galleryPivotStylesItem1.Gallery.ItemSize = New System.Drawing.Size(73, 61)
            Me.galleryPivotStylesItem1.Gallery.RowCount = 10
            Me.galleryPivotStylesItem1.Id = 342
            Me.galleryPivotStylesItem1.Name = "galleryPivotStylesItem1"
            ' 
            ' spreadsheetCommandBarButtonItem201
            ' 
            Me.spreadsheetCommandBarButtonItem201.CommandName = "MailMergeAddDataSource"
            Me.spreadsheetCommandBarButtonItem201.Id = 343
            Me.spreadsheetCommandBarButtonItem201.Name = "spreadsheetCommandBarButtonItem201"
            Me.spreadsheetCommandBarButtonItem201.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarSubItem40
            ' 
            Me.spreadsheetCommandBarSubItem40.CommandName = "MailMergeManageRelationsCommandGroup"
            Me.spreadsheetCommandBarSubItem40.Id = 344
            Me.spreadsheetCommandBarSubItem40.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem202), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem203)})
            Me.spreadsheetCommandBarSubItem40.Name = "spreadsheetCommandBarSubItem40"
            Me.spreadsheetCommandBarSubItem40.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem202
            ' 
            Me.spreadsheetCommandBarButtonItem202.CommandName = "MailMergeManageQueriesCommand"
            Me.spreadsheetCommandBarButtonItem202.Id = 345
            Me.spreadsheetCommandBarButtonItem202.Name = "spreadsheetCommandBarButtonItem202"
            ' 
            ' spreadsheetCommandBarButtonItem203
            ' 
            Me.spreadsheetCommandBarButtonItem203.CommandName = "MailMergeManageRelationsCommand"
            Me.spreadsheetCommandBarButtonItem203.Id = 346
            Me.spreadsheetCommandBarButtonItem203.Name = "spreadsheetCommandBarButtonItem203"
            ' 
            ' spreadsheetCommandBarSubItem41
            ' 
            Me.spreadsheetCommandBarSubItem41.CommandName = "MailMergeManageDataSourceCommandGroup"
            Me.spreadsheetCommandBarSubItem41.Id = 347
            Me.spreadsheetCommandBarSubItem41.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem204), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem205), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem206)})
            Me.spreadsheetCommandBarSubItem41.Name = "spreadsheetCommandBarSubItem41"
            Me.spreadsheetCommandBarSubItem41.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem204
            ' 
            Me.spreadsheetCommandBarButtonItem204.CommandName = "MailMergeSelectDataSource"
            Me.spreadsheetCommandBarButtonItem204.Id = 348
            Me.spreadsheetCommandBarButtonItem204.Name = "spreadsheetCommandBarButtonItem204"
            ' 
            ' spreadsheetCommandBarButtonItem205
            ' 
            Me.spreadsheetCommandBarButtonItem205.CommandName = "MailMergeSelectDataMember"
            Me.spreadsheetCommandBarButtonItem205.Id = 349
            Me.spreadsheetCommandBarButtonItem205.Name = "spreadsheetCommandBarButtonItem205"
            ' 
            ' spreadsheetCommandBarButtonItem206
            ' 
            Me.spreadsheetCommandBarButtonItem206.CommandName = "MailMergeManageDataSourcesCommand"
            Me.spreadsheetCommandBarButtonItem206.Id = 350
            Me.spreadsheetCommandBarButtonItem206.Name = "spreadsheetCommandBarButtonItem206"
            ' 
            ' spreadsheetCommandBarCheckItem41
            ' 
            Me.spreadsheetCommandBarCheckItem41.CommandName = "MailMergeDocumentsMode"
            Me.spreadsheetCommandBarCheckItem41.Id = 351
            Me.spreadsheetCommandBarCheckItem41.Name = "spreadsheetCommandBarCheckItem41"
            Me.spreadsheetCommandBarCheckItem41.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarCheckItem42
            ' 
            Me.spreadsheetCommandBarCheckItem42.CommandName = "MailMergeOneDocumentMode"
            Me.spreadsheetCommandBarCheckItem42.Id = 352
            Me.spreadsheetCommandBarCheckItem42.Name = "spreadsheetCommandBarCheckItem42"
            Me.spreadsheetCommandBarCheckItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarCheckItem43
            ' 
            Me.spreadsheetCommandBarCheckItem43.CommandName = "MailMergeOneSheetMode"
            Me.spreadsheetCommandBarCheckItem43.Id = 353
            Me.spreadsheetCommandBarCheckItem43.Name = "spreadsheetCommandBarCheckItem43"
            Me.spreadsheetCommandBarCheckItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarSubItem42
            ' 
            Me.spreadsheetCommandBarSubItem42.CommandName = "MailMergeOrientationCommandGroup"
            Me.spreadsheetCommandBarSubItem42.Id = 354
            Me.spreadsheetCommandBarSubItem42.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem44), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem45)})
            Me.spreadsheetCommandBarSubItem42.Name = "spreadsheetCommandBarSubItem42"
            Me.spreadsheetCommandBarSubItem42.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarCheckItem44
            ' 
            Me.spreadsheetCommandBarCheckItem44.CommandName = "MailMergeHorizontalMode"
            Me.spreadsheetCommandBarCheckItem44.Id = 355
            Me.spreadsheetCommandBarCheckItem44.Name = "spreadsheetCommandBarCheckItem44"
            ' 
            ' spreadsheetCommandBarCheckItem45
            ' 
            Me.spreadsheetCommandBarCheckItem45.CommandName = "MailMergeVerticalMode"
            Me.spreadsheetCommandBarCheckItem45.Id = 356
            Me.spreadsheetCommandBarCheckItem45.Name = "spreadsheetCommandBarCheckItem45"
            ' 
            ' spreadsheetCommandBarButtonItem207
            ' 
            Me.spreadsheetCommandBarButtonItem207.CommandName = "MailMergeSetHeaderRange"
            Me.spreadsheetCommandBarButtonItem207.Id = 357
            Me.spreadsheetCommandBarButtonItem207.Name = "spreadsheetCommandBarButtonItem207"
            Me.spreadsheetCommandBarButtonItem207.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem208
            ' 
            Me.spreadsheetCommandBarButtonItem208.CommandName = "MailMergeSetFooterRange"
            Me.spreadsheetCommandBarButtonItem208.Id = 358
            Me.spreadsheetCommandBarButtonItem208.Name = "spreadsheetCommandBarButtonItem208"
            Me.spreadsheetCommandBarButtonItem208.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem209
            ' 
            Me.spreadsheetCommandBarButtonItem209.CommandName = "MailMergeSetDetailRange"
            Me.spreadsheetCommandBarButtonItem209.Id = 359
            Me.spreadsheetCommandBarButtonItem209.Name = "spreadsheetCommandBarButtonItem209"
            Me.spreadsheetCommandBarButtonItem209.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarSubItem43
            ' 
            Me.spreadsheetCommandBarSubItem43.CommandName = "EditingMailMergeMasterDetailCommandGroup"
            Me.spreadsheetCommandBarSubItem43.Id = 360
            Me.spreadsheetCommandBarSubItem43.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem210), New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem211)})
            Me.spreadsheetCommandBarSubItem43.Name = "spreadsheetCommandBarSubItem43"
            Me.spreadsheetCommandBarSubItem43.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem210
            ' 
            Me.spreadsheetCommandBarButtonItem210.CommandName = "MailMergeSetDetailLevel"
            Me.spreadsheetCommandBarButtonItem210.Id = 361
            Me.spreadsheetCommandBarButtonItem210.Name = "spreadsheetCommandBarButtonItem210"
            ' 
            ' spreadsheetCommandBarButtonItem211
            ' 
            Me.spreadsheetCommandBarButtonItem211.CommandName = "MailMergeSetDetailDataMember"
            Me.spreadsheetCommandBarButtonItem211.Id = 362
            Me.spreadsheetCommandBarButtonItem211.Name = "spreadsheetCommandBarButtonItem211"
            ' 
            ' spreadsheetCommandBarButtonItem212
            ' 
            Me.spreadsheetCommandBarButtonItem212.CommandName = "MailMergeResetRange"
            Me.spreadsheetCommandBarButtonItem212.Id = 363
            Me.spreadsheetCommandBarButtonItem212.Name = "spreadsheetCommandBarButtonItem212"
            Me.spreadsheetCommandBarButtonItem212.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem213
            ' 
            Me.spreadsheetCommandBarButtonItem213.CommandName = "MailMergeSetGroup"
            Me.spreadsheetCommandBarButtonItem213.Id = 364
            Me.spreadsheetCommandBarButtonItem213.Name = "spreadsheetCommandBarButtonItem213"
            Me.spreadsheetCommandBarButtonItem213.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem214
            ' 
            Me.spreadsheetCommandBarButtonItem214.CommandName = "MailMergeSetGroupHeader"
            Me.spreadsheetCommandBarButtonItem214.Id = 365
            Me.spreadsheetCommandBarButtonItem214.Name = "spreadsheetCommandBarButtonItem214"
            Me.spreadsheetCommandBarButtonItem214.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem215
            ' 
            Me.spreadsheetCommandBarButtonItem215.CommandName = "MailMergeSetGroupFooter"
            Me.spreadsheetCommandBarButtonItem215.Id = 366
            Me.spreadsheetCommandBarButtonItem215.Name = "spreadsheetCommandBarButtonItem215"
            Me.spreadsheetCommandBarButtonItem215.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem216
            ' 
            Me.spreadsheetCommandBarButtonItem216.CommandName = "MailMergeSetFilter"
            Me.spreadsheetCommandBarButtonItem216.Id = 367
            Me.spreadsheetCommandBarButtonItem216.Name = "spreadsheetCommandBarButtonItem216"
            Me.spreadsheetCommandBarButtonItem216.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem217
            ' 
            Me.spreadsheetCommandBarButtonItem217.CommandName = "MailMergeResetFilter"
            Me.spreadsheetCommandBarButtonItem217.Id = 368
            Me.spreadsheetCommandBarButtonItem217.Name = "spreadsheetCommandBarButtonItem217"
            Me.spreadsheetCommandBarButtonItem217.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarCheckItem46
            ' 
            Me.spreadsheetCommandBarCheckItem46.CommandName = "MailMergeShowRanges"
            Me.spreadsheetCommandBarCheckItem46.Id = 369
            Me.spreadsheetCommandBarCheckItem46.Name = "spreadsheetCommandBarCheckItem46"
            Me.spreadsheetCommandBarCheckItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem218
            ' 
            Me.spreadsheetCommandBarButtonItem218.CommandName = "MailMergePreview"
            Me.spreadsheetCommandBarButtonItem218.Id = 370
            Me.spreadsheetCommandBarButtonItem218.Name = "spreadsheetCommandBarButtonItem218"
            Me.spreadsheetCommandBarButtonItem218.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' endModeInfoStaticItem1
            ' 
            Me.endModeInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.endModeInfoStaticItem1.Id = 371
            Me.endModeInfoStaticItem1.Name = "endModeInfoStaticItem1"
            ' 
            ' averageInfoStaticItem1
            ' 
            Me.averageInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.averageInfoStaticItem1.Id = 372
            Me.averageInfoStaticItem1.Name = "averageInfoStaticItem1"
            toolTipItem1.Text = "Average of selected cells"
            superToolTip1.Items.Add(toolTipItem1)
            Me.averageInfoStaticItem1.SuperTip = superToolTip1
            Me.averageInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' countInfoStaticItem1
            ' 
            Me.countInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.countInfoStaticItem1.Id = 373
            Me.countInfoStaticItem1.Name = "countInfoStaticItem1"
            toolTipItem2.Text = "Number of selected cells that contain data"
            superToolTip2.Items.Add(toolTipItem2)
            Me.countInfoStaticItem1.SuperTip = superToolTip2
            Me.countInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' numericalCountInfoStaticItem1
            ' 
            Me.numericalCountInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.numericalCountInfoStaticItem1.Id = 374
            Me.numericalCountInfoStaticItem1.Name = "numericalCountInfoStaticItem1"
            toolTipItem3.Text = "Number of selected cells that contain numerical data"
            superToolTip3.Items.Add(toolTipItem3)
            Me.numericalCountInfoStaticItem1.SuperTip = superToolTip3
            Me.numericalCountInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' minInfoStaticItem1
            ' 
            Me.minInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.minInfoStaticItem1.Id = 375
            Me.minInfoStaticItem1.Name = "minInfoStaticItem1"
            toolTipItem4.Text = "Minimum value in selection"
            superToolTip4.Items.Add(toolTipItem4)
            Me.minInfoStaticItem1.SuperTip = superToolTip4
            Me.minInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' maxInfoStaticItem1
            ' 
            Me.maxInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.maxInfoStaticItem1.Id = 376
            Me.maxInfoStaticItem1.Name = "maxInfoStaticItem1"
            toolTipItem5.Text = "Maximum value in selection"
            superToolTip5.Items.Add(toolTipItem5)
            Me.maxInfoStaticItem1.SuperTip = superToolTip5
            Me.maxInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' sumInfoStaticItem1
            ' 
            Me.sumInfoStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.sumInfoStaticItem1.Id = 377
            Me.sumInfoStaticItem1.Name = "sumInfoStaticItem1"
            toolTipItem6.Text = "Sum of selected cells"
            superToolTip6.Items.Add(toolTipItem6)
            Me.sumInfoStaticItem1.SuperTip = superToolTip6
            Me.sumInfoStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' zoomEditItem1
            ' 
            Me.zoomEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.zoomEditItem1.Edit = Me.repositoryItemZoomTrackBar1
            Me.zoomEditItem1.Id = 378
            Me.zoomEditItem1.Name = "zoomEditItem1"
            toolTipItem7.Text = "Zoom"
            superToolTip7.Items.Add(toolTipItem7)
            Me.zoomEditItem1.SuperTip = superToolTip7
            ' 
            ' repositoryItemZoomTrackBar1
            ' 
            Me.repositoryItemZoomTrackBar1.AllowUseMiddleValue = True
            Me.repositoryItemZoomTrackBar1.LargeChange = 10
            Me.repositoryItemZoomTrackBar1.Maximum = 400
            Me.repositoryItemZoomTrackBar1.Middle = 100
            Me.repositoryItemZoomTrackBar1.Minimum = 10
            Me.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
            Me.repositoryItemZoomTrackBar1.SmallChange = 10
            Me.repositoryItemZoomTrackBar1.SnapToMiddle = 5
            ' 
            ' showZoomButtonItem1
            ' 
            Me.showZoomButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.showZoomButtonItem1.Id = 379
            Me.showZoomButtonItem1.ItemAppearance.Disabled.Options.UseTextOptions = True
            Me.showZoomButtonItem1.ItemAppearance.Hovered.Options.UseTextOptions = True
            Me.showZoomButtonItem1.ItemAppearance.Normal.Options.UseTextOptions = True
            Me.showZoomButtonItem1.ItemAppearance.Pressed.Options.UseTextOptions = True
            Me.showZoomButtonItem1.Name = "showZoomButtonItem1"
            Me.showZoomButtonItem1.SmallWithTextWidth = 45
            toolTipItem8.Text = "Zoom level. Click to open the Zoom dialog box."
            superToolTip8.Items.Add(toolTipItem8)
            Me.showZoomButtonItem1.SuperTip = superToolTip8
            ' 
            ' progressBarItem1
            ' 
            Me.progressBarItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.progressBarItem1.Control = Me.spreadsheetControl1
            Me.progressBarItem1.Edit = Me.repositoryItemProgressBar1
            Me.progressBarItem1.EditWidth = 150
            Me.progressBarItem1.Id = 380
            Me.progressBarItem1.Name = "progressBarItem1"
            Me.progressBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' chartToolsRibbonPageCategory1
            ' 
            Me.chartToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
            Me.chartToolsRibbonPageCategory1.Name = "chartToolsRibbonPageCategory1"
            Me.chartToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.chartsDesignRibbonPage1, Me.chartsLayoutRibbonPage1, Me.chartsFormatRibbonPage1})
            Me.chartToolsRibbonPageCategory1.Visible = False
            ' 
            ' chartsDesignRibbonPage1
            ' 
            Me.chartsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.chartsDesignTypeRibbonPageGroup1, Me.chartsDesignDataRibbonPageGroup1, Me.chartsDesignLayoutsRibbonPageGroup1, Me.chartsDesignStylesRibbonPageGroup1, Me.chartsDesignLocationRibbonPageGroup1})
            Me.chartsDesignRibbonPage1.Name = "chartsDesignRibbonPage1"
            Me.chartsDesignRibbonPage1.Visible = False
            ' 
            ' chartsDesignTypeRibbonPageGroup1
            ' 
            Me.chartsDesignTypeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartsDesignTypeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem163)
            Me.chartsDesignTypeRibbonPageGroup1.Name = "chartsDesignTypeRibbonPageGroup1"
            ' 
            ' chartsDesignDataRibbonPageGroup1
            ' 
            Me.chartsDesignDataRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem164)
            Me.chartsDesignDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem165)
            Me.chartsDesignDataRibbonPageGroup1.Name = "chartsDesignDataRibbonPageGroup1"
            ' 
            ' chartsDesignLayoutsRibbonPageGroup1
            ' 
            Me.chartsDesignLayoutsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartsDesignLayoutsRibbonPageGroup1.ItemLinks.Add(Me.galleryChartLayoutItem1)
            Me.chartsDesignLayoutsRibbonPageGroup1.Name = "chartsDesignLayoutsRibbonPageGroup1"
            ' 
            ' chartsDesignStylesRibbonPageGroup1
            ' 
            Me.chartsDesignStylesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartsDesignStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChartStyleItem1)
            Me.chartsDesignStylesRibbonPageGroup1.Name = "chartsDesignStylesRibbonPageGroup1"
            ' 
            ' chartsDesignLocationRibbonPageGroup1
            ' 
            Me.chartsDesignLocationRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartsDesignLocationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem166)
            Me.chartsDesignLocationRibbonPageGroup1.Name = "chartsDesignLocationRibbonPageGroup1"
            ' 
            ' chartsLayoutRibbonPage1
            ' 
            Me.chartsLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.chartsLayoutAxesRibbonPageGroup1, Me.chartsLayoutLabelsRibbonPageGroup1, Me.chartsLayoutAnalysisRibbonPageGroup1})
            Me.chartsLayoutRibbonPage1.Name = "chartsLayoutRibbonPage1"
            Me.chartsLayoutRibbonPage1.Visible = False
            ' 
            ' chartsLayoutAxesRibbonPageGroup1
            ' 
            Me.chartsLayoutAxesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem29)
            Me.chartsLayoutAxesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem30)
            Me.chartsLayoutAxesRibbonPageGroup1.Name = "chartsLayoutAxesRibbonPageGroup1"
            ' 
            ' chartsLayoutLabelsRibbonPageGroup1
            ' 
            Me.chartsLayoutLabelsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem17)
            Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem31)
            Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem20)
            Me.chartsLayoutLabelsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem21)
            Me.chartsLayoutLabelsRibbonPageGroup1.Name = "chartsLayoutLabelsRibbonPageGroup1"
            ' 
            ' chartsLayoutAnalysisRibbonPageGroup1
            ' 
            Me.chartsLayoutAnalysisRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem22)
            Me.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem23)
            Me.chartsLayoutAnalysisRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem24)
            Me.chartsLayoutAnalysisRibbonPageGroup1.Name = "chartsLayoutAnalysisRibbonPageGroup1"
            ' 
            ' chartsFormatRibbonPage1
            ' 
            Me.chartsFormatRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.chartsFormatArrangeRibbonPageGroup1})
            Me.chartsFormatRibbonPage1.Name = "chartsFormatRibbonPage1"
            Me.chartsFormatRibbonPage1.Visible = False
            ' 
            ' chartsFormatArrangeRibbonPageGroup1
            ' 
            Me.chartsFormatArrangeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
            Me.chartsFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
            Me.chartsFormatArrangeRibbonPageGroup1.Name = "chartsFormatArrangeRibbonPageGroup1"
            ' 
            ' tableToolsRibbonPageCategory1
            ' 
            Me.tableToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
            Me.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
            Me.tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.tableToolsDesignRibbonPage1})
            Me.tableToolsRibbonPageCategory1.Visible = False
            ' 
            ' tableToolsDesignRibbonPage1
            ' 
            Me.tableToolsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.tablePropertiesRibbonPageGroup1, Me.tableToolsRibbonPageGroup1, Me.tableStyleOptionsRibbonPageGroup1, Me.tableStylesRibbonPageGroup1})
            Me.tableToolsDesignRibbonPage1.Name = "tableToolsDesignRibbonPage1"
            Me.tableToolsDesignRibbonPage1.Visible = False
            ' 
            ' tablePropertiesRibbonPageGroup1
            ' 
            Me.tablePropertiesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.tablePropertiesRibbonPageGroup1.ItemLinks.Add(Me.renameTableItemCaption1)
            Me.tablePropertiesRibbonPageGroup1.ItemLinks.Add(Me.renameTableItem1)
            Me.tablePropertiesRibbonPageGroup1.Name = "tablePropertiesRibbonPageGroup1"
            ' 
            ' tableToolsRibbonPageGroup1
            ' 
            Me.tableToolsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.tableToolsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem27)
            Me.tableToolsRibbonPageGroup1.Name = "tableToolsRibbonPageGroup1"
            ' 
            ' tableStyleOptionsRibbonPageGroup1
            ' 
            Me.tableStyleOptionsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem28)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem29)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem30)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem31)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem32)
            Me.tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem33)
            Me.tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1"
            ' 
            ' tableStylesRibbonPageGroup1
            ' 
            Me.tableStylesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryTableStylesItem1)
            Me.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
            ' 
            ' drawingToolsRibbonPageCategory1
            ' 
            Me.drawingToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
            Me.drawingToolsRibbonPageCategory1.Name = "drawingToolsRibbonPageCategory1"
            Me.drawingToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.drawingFormatRibbonPage1})
            Me.drawingToolsRibbonPageCategory1.Visible = False
            ' 
            ' drawingFormatRibbonPage1
            ' 
            Me.drawingFormatRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.drawingFormatArrangeRibbonPageGroup1})
            Me.drawingFormatRibbonPage1.Name = "drawingFormatRibbonPage1"
            Me.drawingFormatRibbonPage1.Visible = False
            ' 
            ' drawingFormatArrangeRibbonPageGroup1
            ' 
            Me.drawingFormatArrangeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
            Me.drawingFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
            Me.drawingFormatArrangeRibbonPageGroup1.Name = "drawingFormatArrangeRibbonPageGroup1"
            ' 
            ' pictureToolsRibbonPageCategory1
            ' 
            Me.pictureToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
            Me.pictureToolsRibbonPageCategory1.Name = "pictureToolsRibbonPageCategory1"
            Me.pictureToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.pictureFormatRibbonPage1})
            Me.pictureToolsRibbonPageCategory1.Visible = False
            ' 
            ' pictureFormatRibbonPage1
            ' 
            Me.pictureFormatRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pictureFormatArrangeRibbonPageGroup1})
            Me.pictureFormatRibbonPage1.Name = "pictureFormatRibbonPage1"
            Me.pictureFormatRibbonPage1.Visible = False
            ' 
            ' pictureFormatArrangeRibbonPageGroup1
            ' 
            Me.pictureFormatArrangeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
            Me.pictureFormatArrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
            Me.pictureFormatArrangeRibbonPageGroup1.Name = "pictureFormatArrangeRibbonPageGroup1"
            ' 
            ' pivotTableToolsRibbonPageCategory1
            ' 
            Me.pivotTableToolsRibbonPageCategory1.Control = Me.spreadsheetControl1
            Me.pivotTableToolsRibbonPageCategory1.Name = "pivotTableToolsRibbonPageCategory1"
            Me.pivotTableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.pivotTableAnalyzeRibbonPage1, Me.pivotTableDesignRibbonPage1})
            Me.pivotTableToolsRibbonPageCategory1.Visible = False
            ' 
            ' pivotTableAnalyzeRibbonPage1
            ' 
            Me.pivotTableAnalyzeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pivotTableAnalyzePivotTableRibbonPageGroup1, Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1, Me.pivotTableAnalyzeGroupRibbonPageGroup1, Me.pivotTableAnalyzeDataRibbonPageGroup1, Me.pivotTableAnalyzeActionsRibbonPageGroup1, Me.pivotTableAnalyzeCalculationsRibbonPageGroup1, Me.pivotTableAnalyzeShowRibbonPageGroup1})
            Me.pivotTableAnalyzeRibbonPage1.Name = "pivotTableAnalyzeRibbonPage1"
            Me.pivotTableAnalyzeRibbonPage1.Visible = False
            ' 
            ' pivotTableAnalyzePivotTableRibbonPageGroup1
            ' 
            Me.pivotTableAnalyzePivotTableRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotTableAnalyzePivotTableRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem167)
            Me.pivotTableAnalyzePivotTableRibbonPageGroup1.Name = "pivotTableAnalyzePivotTableRibbonPageGroup1"
            ' 
            ' pivotTableAnalyzeActiveFieldRibbonPageGroup1
            ' 
            Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem168)
            Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem169)
            Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem170)
            Me.pivotTableAnalyzeActiveFieldRibbonPageGroup1.Name = "pivotTableAnalyzeActiveFieldRibbonPageGroup1"
            ' 
            ' pivotTableAnalyzeGroupRibbonPageGroup1
            ' 
            Me.pivotTableAnalyzeGroupRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem171)
            Me.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem172)
            Me.pivotTableAnalyzeGroupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem173)
            Me.pivotTableAnalyzeGroupRibbonPageGroup1.Name = "pivotTableAnalyzeGroupRibbonPageGroup1"
            ' 
            ' pivotTableAnalyzeDataRibbonPageGroup1
            ' 
            Me.pivotTableAnalyzeDataRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotTableAnalyzeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem32)
            Me.pivotTableAnalyzeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem176)
            Me.pivotTableAnalyzeDataRibbonPageGroup1.Name = "pivotTableAnalyzeDataRibbonPageGroup1"
            ' 
            ' pivotTableAnalyzeActionsRibbonPageGroup1
            ' 
            Me.pivotTableAnalyzeActionsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem33)
            Me.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem34)
            Me.pivotTableAnalyzeActionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem182)
            Me.pivotTableAnalyzeActionsRibbonPageGroup1.Name = "pivotTableAnalyzeActionsRibbonPageGroup1"
            ' 
            ' pivotTableAnalyzeCalculationsRibbonPageGroup1
            ' 
            Me.pivotTableAnalyzeCalculationsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotTableAnalyzeCalculationsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem35)
            Me.pivotTableAnalyzeCalculationsRibbonPageGroup1.Name = "pivotTableAnalyzeCalculationsRibbonPageGroup1"
            ' 
            ' pivotTableAnalyzeShowRibbonPageGroup1
            ' 
            Me.pivotTableAnalyzeShowRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem34)
            Me.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem35)
            Me.pivotTableAnalyzeShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem36)
            Me.pivotTableAnalyzeShowRibbonPageGroup1.Name = "pivotTableAnalyzeShowRibbonPageGroup1"
            ' 
            ' pivotTableDesignRibbonPage1
            ' 
            Me.pivotTableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pivotTableDesignLayoutRibbonPageGroup1, Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1, Me.pivotTableDesignPivotTableStylesRibbonPageGroup1})
            Me.pivotTableDesignRibbonPage1.Name = "pivotTableDesignRibbonPage1"
            Me.pivotTableDesignRibbonPage1.Visible = False
            ' 
            ' pivotTableDesignLayoutRibbonPageGroup1
            ' 
            Me.pivotTableDesignLayoutRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem36)
            Me.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem37)
            Me.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem38)
            Me.pivotTableDesignLayoutRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem39)
            Me.pivotTableDesignLayoutRibbonPageGroup1.Name = "pivotTableDesignLayoutRibbonPageGroup1"
            ' 
            ' pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1
            ' 
            Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem37)
            Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem38)
            Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem39)
            Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem40)
            Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows
            Me.pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1.Name = "pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1"
            ' 
            ' pivotTableDesignPivotTableStylesRibbonPageGroup1
            ' 
            Me.pivotTableDesignPivotTableStylesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pivotTableDesignPivotTableStylesRibbonPageGroup1.ItemLinks.Add(Me.galleryPivotStylesItem1)
            Me.pivotTableDesignPivotTableStylesRibbonPageGroup1.Name = "pivotTableDesignPivotTableStylesRibbonPageGroup1"
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.commonRibbonPageGroup1, Me.infoRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem2)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem3)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem4)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem5)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem6)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem7)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem8)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem9)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' infoRibbonPageGroup1
            ' 
            Me.infoRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem10)
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem11)
            Me.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
            ' 
            ' homeRibbonPage1
            ' 
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.alignmentRibbonPageGroup1, Me.numberRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.cellsRibbonPageGroup1, Me.editingRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
            reduceOperation1.GroupName = "stylesRibbonPageGroup1"
            reduceOperation1.ItemLinkIndex = 2
            reduceOperation1.ItemLinksCount = 0
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
            Me.homeRibbonPage1.ReduceOperations.Add(reduceOperation1)
            ' 
            ' clipboardRibbonPageGroup1
            ' 
            Me.clipboardRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem12)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem13)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem14)
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem15)
            Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            ' 
            ' fontRibbonPageGroup1
            ' 
            Me.fontRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[True]
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
            Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
            ' 
            ' alignmentRibbonPageGroup1
            ' 
            Me.alignmentRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[True]
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem11)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem2)
            Me.alignmentRibbonPageGroup1.Name = "alignmentRibbonPageGroup1"
            ' 
            ' numberRibbonPageGroup1
            ' 
            Me.numberRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[True]
            Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup8)
            Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup9)
            Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup10)
            Me.numberRibbonPageGroup1.Name = "numberRibbonPageGroup1"
            ' 
            ' stylesRibbonPageGroup1
            ' 
            Me.stylesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem7)
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryFormatAsTableItem1)
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
            Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
            ' 
            ' cellsRibbonPageGroup1
            ' 
            Me.cellsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem8)
            Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem9)
            Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem11)
            Me.cellsRibbonPageGroup1.Name = "cellsRibbonPageGroup1"
            ' 
            ' editingRibbonPageGroup1
            ' 
            Me.editingRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem12)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem13)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem14)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem15)
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem16)
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            ' 
            ' insertRibbonPage1
            ' 
            Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.chartsRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
            Me.insertRibbonPage1.Name = "insertRibbonPage1"
            ' 
            ' tablesRibbonPageGroup1
            ' 
            Me.tablesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem118)
            Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem119)
            Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            ' 
            ' illustrationsRibbonPageGroup1
            ' 
            Me.illustrationsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem120)
            Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            ' 
            ' chartsRibbonPageGroup1
            ' 
            Me.chartsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem4)
            Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem5)
            Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem6)
            Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem7)
            Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem8)
            Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem9)
            Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem10)
            Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem11)
            Me.chartsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem12)
            Me.chartsRibbonPageGroup1.Name = "chartsRibbonPageGroup1"
            ' 
            ' linksRibbonPageGroup1
            ' 
            Me.linksRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem121)
            Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            ' 
            ' symbolsRibbonPageGroup1
            ' 
            Me.symbolsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem122)
            Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
            ' 
            ' pageLayoutRibbonPage1
            ' 
            Me.pageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pageSetupRibbonPageGroup1, Me.pageSetupShowRibbonPageGroup1, Me.pageSetupPrintRibbonPageGroup1, Me.arrangeRibbonPageGroup1})
            Me.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1"
            ' 
            ' pageSetupRibbonPageGroup1
            ' 
            Me.pageSetupRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[True]
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem17)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem18)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.pageSetupPaperKindItem1)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem19)
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem127)
            Me.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1"
            ' 
            ' pageSetupShowRibbonPageGroup1
            ' 
            Me.pageSetupShowRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.pageSetupShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem20)
            Me.pageSetupShowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem21)
            Me.pageSetupShowRibbonPageGroup1.Name = "pageSetupShowRibbonPageGroup1"
            ' 
            ' pageSetupPrintRibbonPageGroup1
            ' 
            Me.pageSetupPrintRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[True]
            Me.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem22)
            Me.pageSetupPrintRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem23)
            Me.pageSetupPrintRibbonPageGroup1.Name = "pageSetupPrintRibbonPageGroup1"
            ' 
            ' arrangeRibbonPageGroup1
            ' 
            Me.arrangeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem20)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem21)
            Me.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1"
            ' 
            ' formulasRibbonPage1
            ' 
            Me.formulasRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.functionLibraryRibbonPageGroup1, Me.formulaDefinedNamesRibbonPageGroup1, Me.formulaAuditingRibbonPageGroup1, Me.formulaCalculationRibbonPageGroup1})
            Me.formulasRibbonPage1.Name = "formulasRibbonPage1"
            ' 
            ' functionLibraryRibbonPageGroup1
            ' 
            Me.functionLibraryRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem22)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsFinancialItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsLogicalItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsTextItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsDateAndTimeItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsLookupAndReferenceItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.functionsMathAndTrigonometryItem1)
            Me.functionLibraryRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem23)
            Me.functionLibraryRibbonPageGroup1.Name = "functionLibraryRibbonPageGroup1"
            ' 
            ' formulaDefinedNamesRibbonPageGroup1
            ' 
            Me.formulaDefinedNamesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem132)
            Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem133)
            Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.definedNameListItem1)
            Me.formulaDefinedNamesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem134)
            Me.formulaDefinedNamesRibbonPageGroup1.Name = "formulaDefinedNamesRibbonPageGroup1"
            ' 
            ' formulaAuditingRibbonPageGroup1
            ' 
            Me.formulaAuditingRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.formulaAuditingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem24)
            Me.formulaAuditingRibbonPageGroup1.Name = "formulaAuditingRibbonPageGroup1"
            ' 
            ' formulaCalculationRibbonPageGroup1
            ' 
            Me.formulaCalculationRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem24)
            Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem135)
            Me.formulaCalculationRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem136)
            Me.formulaCalculationRibbonPageGroup1.Name = "formulaCalculationRibbonPageGroup1"
            ' 
            ' dataRibbonPage1
            ' 
            Me.dataRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.sortAndFilterRibbonPageGroup1, Me.dataToolsRibbonPageGroup1, Me.outlineRibbonPageGroup1})
            Me.dataRibbonPage1.Name = "dataRibbonPage1"
            ' 
            ' sortAndFilterRibbonPageGroup1
            ' 
            Me.sortAndFilterRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem107)
            Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem108)
            Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem14)
            Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem109)
            Me.sortAndFilterRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem110)
            Me.sortAndFilterRibbonPageGroup1.Name = "sortAndFilterRibbonPageGroup1"
            ' 
            ' dataToolsRibbonPageGroup1
            ' 
            Me.dataToolsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.dataToolsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem25)
            Me.dataToolsRibbonPageGroup1.Name = "dataToolsRibbonPageGroup1"
            ' 
            ' outlineRibbonPageGroup1
            ' 
            Me.outlineRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[True]
            Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem26)
            Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem27)
            Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem144)
            Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem145)
            Me.outlineRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem146)
            Me.outlineRibbonPageGroup1.Name = "outlineRibbonPageGroup1"
            ' 
            ' reviewRibbonPage1
            ' 
            Me.reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.commentsRibbonPageGroup1, Me.changesRibbonPageGroup1})
            Me.reviewRibbonPage1.Name = "reviewRibbonPage1"
            ' 
            ' commentsRibbonPageGroup1
            ' 
            Me.commentsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem147)
            Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem148)
            Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem149)
            Me.commentsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem150)
            Me.commentsRibbonPageGroup1.Name = "commentsRibbonPageGroup1"
            ' 
            ' changesRibbonPageGroup1
            ' 
            Me.changesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem90)
            Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem151)
            Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem152)
            Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem153)
            Me.changesRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem154)
            Me.changesRibbonPageGroup1.Name = "changesRibbonPageGroup1"
            ' 
            ' viewRibbonPage1
            ' 
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.showRibbonPageGroup1, Me.zoomRibbonPageGroup1, Me.windowRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            ' 
            ' showRibbonPageGroup1
            ' 
            Me.showRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.showRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem20)
            Me.showRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem21)
            Me.showRibbonPageGroup1.Name = "showRibbonPageGroup1"
            ' 
            ' zoomRibbonPageGroup1
            ' 
            Me.zoomRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem155)
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem156)
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem157)
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem158)
            Me.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1"
            ' 
            ' windowRibbonPageGroup1
            ' 
            Me.windowRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.windowRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem28)
            Me.windowRibbonPageGroup1.Name = "windowRibbonPageGroup1"
            ' 
            ' mailMergeRibbonPage1
            ' 
            Me.mailMergeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.mailMergeDataRibbonPageGroup1, Me.mailMergeModeRibbonPageGroup1, Me.mailMergeExtendedRibbonPageGroup1, Me.mailMergeGroupingRibbonPageGroup1, Me.mailMergeFilteringRibbonPageGroup1, Me.mailMergeBindingRibbonPageGroup2})
            Me.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1"
            ' 
            ' mailMergeDataRibbonPageGroup1
            ' 
            Me.mailMergeDataRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.mailMergeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem201)
            Me.mailMergeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem40)
            Me.mailMergeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem41)
            Me.mailMergeDataRibbonPageGroup1.Name = "mailMergeDataRibbonPageGroup1"
            ' 
            ' mailMergeModeRibbonPageGroup1
            ' 
            Me.mailMergeModeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem41)
            Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem42)
            Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem43)
            Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem42)
            Me.mailMergeModeRibbonPageGroup1.Name = "mailMergeModeRibbonPageGroup1"
            ' 
            ' mailMergeExtendedRibbonPageGroup1
            ' 
            Me.mailMergeExtendedRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem207)
            Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem208)
            Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem209)
            Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem43)
            Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem212)
            Me.mailMergeExtendedRibbonPageGroup1.Name = "mailMergeExtendedRibbonPageGroup1"
            ' 
            ' mailMergeGroupingRibbonPageGroup1
            ' 
            Me.mailMergeGroupingRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem213)
            Me.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem214)
            Me.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem215)
            Me.mailMergeGroupingRibbonPageGroup1.Name = "mailMergeGroupingRibbonPageGroup1"
            ' 
            ' mailMergeFilteringRibbonPageGroup1
            ' 
            Me.mailMergeFilteringRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.mailMergeFilteringRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem216)
            Me.mailMergeFilteringRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem217)
            Me.mailMergeFilteringRibbonPageGroup1.Name = "mailMergeFilteringRibbonPageGroup1"
            ' 
            ' mailMergeBindingRibbonPageGroup2
            ' 
            Me.mailMergeBindingRibbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.mailMergeBindingRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem46)
            Me.mailMergeBindingRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem218)
            Me.mailMergeBindingRibbonPageGroup2.Name = "mailMergeBindingRibbonPageGroup2"
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar1.ItemLinks.Add(Me.progressBarItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.endModeInfoStaticItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.averageInfoStaticItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.countInfoStaticItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.numericalCountInfoStaticItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.minInfoStaticItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.maxInfoStaticItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.sumInfoStaticItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.zoomEditItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.showZoomButtonItem1)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 405)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1062, 27)
            ' 
            ' commandBarGalleryDropDown49
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown49.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown49.Gallery.ColumnCount = 1
            Me.commandBarGalleryDropDown49.Gallery.DrawImageBackground = False
            Me.commandBarGalleryDropDown49.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.commandBarGalleryDropDown49.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown49.Gallery.ItemSize = New System.Drawing.Size(136, 26)
            Me.commandBarGalleryDropDown49.Gallery.RowCount = 14
            Me.commandBarGalleryDropDown49.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown49.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown49.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown49.Manager = Nothing
            Me.commandBarGalleryDropDown49.Name = "commandBarGalleryDropDown49"
            ' 
            ' commandBarGalleryDropDown51
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown51.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup49.CommandName = "ConditionalFormattingColorScalesCommandGroup"
            spreadsheetCommandGalleryItem206.Caption = "Green - Yellow - Red Color Scale"
            spreadsheetCommandGalleryItem206.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
            spreadsheetCommandGalleryItem206.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem206.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem206.ImageOptions.Image = CType((resources.GetObject("resource.Image12")), System.Drawing.Image)
            spreadsheetCommandGalleryItem207.Caption = "Red - Yellow - Green Color Scale"
            spreadsheetCommandGalleryItem207.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
            spreadsheetCommandGalleryItem207.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem207.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem207.ImageOptions.Image = CType((resources.GetObject("resource.Image13")), System.Drawing.Image)
            spreadsheetCommandGalleryItem208.Caption = "Green - White - Red Color Scale"
            spreadsheetCommandGalleryItem208.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
            spreadsheetCommandGalleryItem208.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem208.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem208.ImageOptions.Image = CType((resources.GetObject("resource.Image14")), System.Drawing.Image)
            spreadsheetCommandGalleryItem209.Caption = "Red - White - Green Color Scale"
            spreadsheetCommandGalleryItem209.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
            spreadsheetCommandGalleryItem209.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem209.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem209.ImageOptions.Image = CType((resources.GetObject("resource.Image15")), System.Drawing.Image)
            spreadsheetCommandGalleryItem210.Caption = "Blue - White - Red Color Scale"
            spreadsheetCommandGalleryItem210.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
            spreadsheetCommandGalleryItem210.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem210.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem210.ImageOptions.Image = CType((resources.GetObject("resource.Image16")), System.Drawing.Image)
            spreadsheetCommandGalleryItem211.Caption = "Red - White - Blue Color Scale"
            spreadsheetCommandGalleryItem211.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
            spreadsheetCommandGalleryItem211.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem211.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem211.ImageOptions.Image = CType((resources.GetObject("resource.Image17")), System.Drawing.Image)
            spreadsheetCommandGalleryItem212.Caption = "White - Red Color Scale"
            spreadsheetCommandGalleryItem212.CommandName = "ConditionalFormattingColorScaleWhiteRed"
            spreadsheetCommandGalleryItem212.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem212.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem212.ImageOptions.Image = CType((resources.GetObject("resource.Image18")), System.Drawing.Image)
            spreadsheetCommandGalleryItem213.Caption = "Red - White Color Scale"
            spreadsheetCommandGalleryItem213.CommandName = "ConditionalFormattingColorScaleRedWhite"
            spreadsheetCommandGalleryItem213.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem213.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem213.ImageOptions.Image = CType((resources.GetObject("resource.Image19")), System.Drawing.Image)
            spreadsheetCommandGalleryItem214.Caption = "Green - White Color Scale"
            spreadsheetCommandGalleryItem214.CommandName = "ConditionalFormattingColorScaleGreenWhite"
            spreadsheetCommandGalleryItem214.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem214.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem214.ImageOptions.Image = CType((resources.GetObject("resource.Image20")), System.Drawing.Image)
            spreadsheetCommandGalleryItem215.Caption = "White - Green Color Scale"
            spreadsheetCommandGalleryItem215.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
            spreadsheetCommandGalleryItem215.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem215.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem215.ImageOptions.Image = CType((resources.GetObject("resource.Image21")), System.Drawing.Image)
            spreadsheetCommandGalleryItem216.Caption = "Green - Yellow Color Scale"
            spreadsheetCommandGalleryItem216.CommandName = "ConditionalFormattingColorScaleGreenYellow"
            spreadsheetCommandGalleryItem216.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem216.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem216.ImageOptions.Image = CType((resources.GetObject("resource.Image22")), System.Drawing.Image)
            spreadsheetCommandGalleryItem217.Caption = "Yellow - Green Color Scale"
            spreadsheetCommandGalleryItem217.CommandName = "ConditionalFormattingColorScaleYellowGreen"
            spreadsheetCommandGalleryItem217.Description = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem217.Hint = "Displays a two or three color gradient in a range of cells. The shade of the colo" & "r represents the value in the cell."
            spreadsheetCommandGalleryItem217.ImageOptions.Image = CType((resources.GetObject("resource.Image23")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup49.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem206, spreadsheetCommandGalleryItem207, spreadsheetCommandGalleryItem208, spreadsheetCommandGalleryItem209, spreadsheetCommandGalleryItem210, spreadsheetCommandGalleryItem211, spreadsheetCommandGalleryItem212, spreadsheetCommandGalleryItem213, spreadsheetCommandGalleryItem214, spreadsheetCommandGalleryItem215, spreadsheetCommandGalleryItem216, spreadsheetCommandGalleryItem217})
            Me.commandBarGalleryDropDown51.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup49})
            Me.commandBarGalleryDropDown51.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown51.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown51.Manager = Nothing
            Me.commandBarGalleryDropDown51.Name = "commandBarGalleryDropDown51"
            ' 
            ' commandBarGalleryDropDown52
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown52.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup50.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
            spreadsheetCommandGalleryItem218.Caption = "3 Arrows (Colored)"
            spreadsheetCommandGalleryItem218.CommandName = "ConditionalFormattingIconSetArrows3Colored"
            spreadsheetCommandGalleryItem218.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem218.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem218.ImageOptions.Image = CType((resources.GetObject("resource.Image24")), System.Drawing.Image)
            spreadsheetCommandGalleryItem219.Caption = "3 Arrows (Gray)"
            spreadsheetCommandGalleryItem219.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
            spreadsheetCommandGalleryItem219.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem219.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem219.ImageOptions.Image = CType((resources.GetObject("resource.Image25")), System.Drawing.Image)
            spreadsheetCommandGalleryItem220.Caption = "4 Arrows (Colored)"
            spreadsheetCommandGalleryItem220.CommandName = "ConditionalFormattingIconSetArrows4Colored"
            spreadsheetCommandGalleryItem220.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem220.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem220.ImageOptions.Image = CType((resources.GetObject("resource.Image26")), System.Drawing.Image)
            spreadsheetCommandGalleryItem221.Caption = "4 Arrows (Gray)"
            spreadsheetCommandGalleryItem221.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
            spreadsheetCommandGalleryItem221.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem221.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem221.ImageOptions.Image = CType((resources.GetObject("resource.Image27")), System.Drawing.Image)
            spreadsheetCommandGalleryItem222.Caption = "5 Arrows (Colored)"
            spreadsheetCommandGalleryItem222.CommandName = "ConditionalFormattingIconSetArrows5Colored"
            spreadsheetCommandGalleryItem222.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem222.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem222.ImageOptions.Image = CType((resources.GetObject("resource.Image28")), System.Drawing.Image)
            spreadsheetCommandGalleryItem223.Caption = "5 Arrows (Gray)"
            spreadsheetCommandGalleryItem223.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
            spreadsheetCommandGalleryItem223.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem223.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem223.ImageOptions.Image = CType((resources.GetObject("resource.Image29")), System.Drawing.Image)
            spreadsheetCommandGalleryItem224.Caption = "3 Triangles"
            spreadsheetCommandGalleryItem224.CommandName = "ConditionalFormattingIconSetTriangles3"
            spreadsheetCommandGalleryItem224.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem224.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem224.ImageOptions.Image = CType((resources.GetObject("resource.Image30")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup50.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem218, spreadsheetCommandGalleryItem219, spreadsheetCommandGalleryItem220, spreadsheetCommandGalleryItem221, spreadsheetCommandGalleryItem222, spreadsheetCommandGalleryItem223, spreadsheetCommandGalleryItem224})
            spreadsheetCommandGalleryItemGroup51.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
            spreadsheetCommandGalleryItem225.Caption = "3 Traffic Lights (Unrimmed)"
            spreadsheetCommandGalleryItem225.CommandName = "ConditionalFormattingIconSetTrafficLights3"
            spreadsheetCommandGalleryItem225.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem225.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem225.ImageOptions.Image = CType((resources.GetObject("resource.Image31")), System.Drawing.Image)
            spreadsheetCommandGalleryItem226.Caption = "3 Traffic Lights (Rimmed)"
            spreadsheetCommandGalleryItem226.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
            spreadsheetCommandGalleryItem226.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem226.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem226.ImageOptions.Image = CType((resources.GetObject("resource.Image32")), System.Drawing.Image)
            spreadsheetCommandGalleryItem227.Caption = "4 Traffic Lights"
            spreadsheetCommandGalleryItem227.CommandName = "ConditionalFormattingIconSetTrafficLights4"
            spreadsheetCommandGalleryItem227.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem227.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem227.ImageOptions.Image = CType((resources.GetObject("resource.Image33")), System.Drawing.Image)
            spreadsheetCommandGalleryItem228.Caption = "3 Signs"
            spreadsheetCommandGalleryItem228.CommandName = "ConditionalFormattingIconSetSigns3"
            spreadsheetCommandGalleryItem228.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem228.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem228.ImageOptions.Image = CType((resources.GetObject("resource.Image34")), System.Drawing.Image)
            spreadsheetCommandGalleryItem229.Caption = "Red To Black"
            spreadsheetCommandGalleryItem229.CommandName = "ConditionalFormattingIconSetRedToBlack"
            spreadsheetCommandGalleryItem229.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem229.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem229.ImageOptions.Image = CType((resources.GetObject("resource.Image35")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup51.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem225, spreadsheetCommandGalleryItem226, spreadsheetCommandGalleryItem227, spreadsheetCommandGalleryItem228, spreadsheetCommandGalleryItem229})
            spreadsheetCommandGalleryItemGroup52.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
            spreadsheetCommandGalleryItem230.Caption = "3 Symbols (Circled)"
            spreadsheetCommandGalleryItem230.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
            spreadsheetCommandGalleryItem230.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem230.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem230.ImageOptions.Image = CType((resources.GetObject("resource.Image36")), System.Drawing.Image)
            spreadsheetCommandGalleryItem231.Caption = "3 Symbols (Uncircled)"
            spreadsheetCommandGalleryItem231.CommandName = "ConditionalFormattingIconSetSymbols3"
            spreadsheetCommandGalleryItem231.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem231.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem231.ImageOptions.Image = CType((resources.GetObject("resource.Image37")), System.Drawing.Image)
            spreadsheetCommandGalleryItem232.Caption = "3 Flags"
            spreadsheetCommandGalleryItem232.CommandName = "ConditionalFormattingIconSetFlags3"
            spreadsheetCommandGalleryItem232.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem232.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem232.ImageOptions.Image = CType((resources.GetObject("resource.Image38")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup52.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem230, spreadsheetCommandGalleryItem231, spreadsheetCommandGalleryItem232})
            spreadsheetCommandGalleryItemGroup53.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
            spreadsheetCommandGalleryItem233.Caption = "3 Stars"
            spreadsheetCommandGalleryItem233.CommandName = "ConditionalFormattingIconSetStars3"
            spreadsheetCommandGalleryItem233.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem233.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem233.ImageOptions.Image = CType((resources.GetObject("resource.Image39")), System.Drawing.Image)
            spreadsheetCommandGalleryItem234.Caption = "4 Ratings"
            spreadsheetCommandGalleryItem234.CommandName = "ConditionalFormattingIconSetRatings4"
            spreadsheetCommandGalleryItem234.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem234.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem234.ImageOptions.Image = CType((resources.GetObject("resource.Image40")), System.Drawing.Image)
            spreadsheetCommandGalleryItem235.Caption = "5 Ratings"
            spreadsheetCommandGalleryItem235.CommandName = "ConditionalFormattingIconSetRatings5"
            spreadsheetCommandGalleryItem235.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem235.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem235.ImageOptions.Image = CType((resources.GetObject("resource.Image41")), System.Drawing.Image)
            spreadsheetCommandGalleryItem236.Caption = "5 Quarters"
            spreadsheetCommandGalleryItem236.CommandName = "ConditionalFormattingIconSetQuarters5"
            spreadsheetCommandGalleryItem236.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem236.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem236.ImageOptions.Image = CType((resources.GetObject("resource.Image42")), System.Drawing.Image)
            spreadsheetCommandGalleryItem237.Caption = "5 Boxes"
            spreadsheetCommandGalleryItem237.CommandName = "ConditionalFormattingIconSetBoxes5"
            spreadsheetCommandGalleryItem237.Description = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem237.Hint = "Display an icon from the above icon set in each cell. Each icon represents a valu" & "e in the cell."
            spreadsheetCommandGalleryItem237.ImageOptions.Image = CType((resources.GetObject("resource.Image43")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup53.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem233, spreadsheetCommandGalleryItem234, spreadsheetCommandGalleryItem235, spreadsheetCommandGalleryItem236, spreadsheetCommandGalleryItem237})
            Me.commandBarGalleryDropDown52.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup50, spreadsheetCommandGalleryItemGroup51, spreadsheetCommandGalleryItemGroup52, spreadsheetCommandGalleryItemGroup53})
            Me.commandBarGalleryDropDown52.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown52.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown52.Manager = Nothing
            Me.commandBarGalleryDropDown52.Name = "commandBarGalleryDropDown52"
            ' 
            ' commandBarGalleryDropDown53
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown53.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown53.Gallery.ColumnCount = 7
            Me.commandBarGalleryDropDown53.Gallery.DrawImageBackground = False
            Me.commandBarGalleryDropDown53.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown53.Gallery.ItemSize = New System.Drawing.Size(73, 58)
            Me.commandBarGalleryDropDown53.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown53.Manager = Nothing
            Me.commandBarGalleryDropDown53.Name = "commandBarGalleryDropDown53"
            ' 
            ' commandBarGalleryDropDown54
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown54.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup54.CommandName = "InsertChartColumn2DCommandGroup"
            spreadsheetCommandGalleryItem238.Caption = "Clustered Column"
            spreadsheetCommandGalleryItem238.CommandName = "InsertChartColumnClustered2D"
            spreadsheetCommandGalleryItem238.Description = "Compare values across categories by using vertical rectangles." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the" & " order of categories is not important or for displaying item counts such as a hi" & "stogram."
            spreadsheetCommandGalleryItem238.Hint = "Compare values across categories by using vertical rectangles." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the" & " order of categories is not important or for displaying item counts such as a hi" & "stogram."
            spreadsheetCommandGalleryItem238.ImageOptions.Image = CType((resources.GetObject("resource.Image44")), System.Drawing.Image)
            spreadsheetCommandGalleryItem239.Caption = "Stacked Column"
            spreadsheetCommandGalleryItem239.CommandName = "InsertChartColumnStacked2D"
            spreadsheetCommandGalleryItem239.Description = "Compare the contribution of each value to a total across categories by using vert" & "ical rectangles." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it to emphasize the total across series for one category" & "."
            spreadsheetCommandGalleryItem239.Hint = "Compare the contribution of each value to a total across categories by using vert" & "ical rectangles." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it to emphasize the total across series for one category" & "."
            spreadsheetCommandGalleryItem239.ImageOptions.Image = CType((resources.GetObject("resource.Image45")), System.Drawing.Image)
            spreadsheetCommandGalleryItem240.Caption = "100% Stacked Column"
            spreadsheetCommandGalleryItem240.CommandName = "InsertChartColumnPercentStacked2D"
            spreadsheetCommandGalleryItem240.Description = "Compare the percentage that each value contributes to a total across categories b" & "y using vertical rectangles." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is to emphasize the proportion of each data " & "series."
            spreadsheetCommandGalleryItem240.Hint = "Compare the percentage that each value contributes to a total across categories b" & "y using vertical rectangles." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is to emphasize the proportion of each data " & "series."
            spreadsheetCommandGalleryItem240.ImageOptions.Image = CType((resources.GetObject("resource.Image46")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup54.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem238, spreadsheetCommandGalleryItem239, spreadsheetCommandGalleryItem240})
            spreadsheetCommandGalleryItemGroup55.CommandName = "InsertChartColumn3DCommandGroup"
            spreadsheetCommandGalleryItem241.Caption = "3-D Clustered Column"
            spreadsheetCommandGalleryItem241.CommandName = "InsertChartColumnClustered3D"
            spreadsheetCommandGalleryItem241.Description = "Compare values across categories and display clustered columns in 3-D format."
            spreadsheetCommandGalleryItem241.Hint = "Compare values across categories and display clustered columns in 3-D format."
            spreadsheetCommandGalleryItem241.ImageOptions.Image = CType((resources.GetObject("resource.Image47")), System.Drawing.Image)
            spreadsheetCommandGalleryItem242.Caption = "Stacked Column in 3-D"
            spreadsheetCommandGalleryItem242.CommandName = "InsertChartColumnStacked3D"
            spreadsheetCommandGalleryItem242.Description = "Compare the contribution of each value to a total across categories and display s" & "tacked columns in 3-D format."
            spreadsheetCommandGalleryItem242.Hint = "Compare the contribution of each value to a total across categories and display s" & "tacked columns in 3-D format."
            spreadsheetCommandGalleryItem242.ImageOptions.Image = CType((resources.GetObject("resource.Image48")), System.Drawing.Image)
            spreadsheetCommandGalleryItem243.Caption = "100% Stacked Column in 3-D"
            spreadsheetCommandGalleryItem243.CommandName = "InsertChartColumnPercentStacked3D"
            spreadsheetCommandGalleryItem243.Description = "Compare the percentage that each value contributes to a total across categories a" & "nd display 100% stacked columns in 3-D format."
            spreadsheetCommandGalleryItem243.Hint = "Compare the percentage that each value contributes to a total across categories a" & "nd display 100% stacked columns in 3-D format."
            spreadsheetCommandGalleryItem243.ImageOptions.Image = CType((resources.GetObject("resource.Image49")), System.Drawing.Image)
            spreadsheetCommandGalleryItem244.Caption = "3-D Column"
            spreadsheetCommandGalleryItem244.CommandName = "InsertChartColumn3D"
            spreadsheetCommandGalleryItem244.Description = "Compare values across categories and across series on three axes." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when " & "the categories and series are equally important."
            spreadsheetCommandGalleryItem244.Hint = "Compare values across categories and across series on three axes." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when " & "the categories and series are equally important."
            spreadsheetCommandGalleryItem244.ImageOptions.Image = CType((resources.GetObject("resource.Image50")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup55.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem241, spreadsheetCommandGalleryItem242, spreadsheetCommandGalleryItem243, spreadsheetCommandGalleryItem244})
            spreadsheetCommandGalleryItemGroup56.CommandName = "InsertChartCylinderCommandGroup"
            spreadsheetCommandGalleryItem245.Caption = "Clustered Cylinder"
            spreadsheetCommandGalleryItem245.CommandName = "InsertChartCylinderClustered"
            spreadsheetCommandGalleryItem245.Description = "Compare values across categories."
            spreadsheetCommandGalleryItem245.Hint = "Compare values across categories."
            spreadsheetCommandGalleryItem245.ImageOptions.Image = CType((resources.GetObject("resource.Image51")), System.Drawing.Image)
            spreadsheetCommandGalleryItem246.Caption = "Stacked Cylinder"
            spreadsheetCommandGalleryItem246.CommandName = "InsertChartCylinderStacked"
            spreadsheetCommandGalleryItem246.Description = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem246.Hint = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem246.ImageOptions.Image = CType((resources.GetObject("resource.Image52")), System.Drawing.Image)
            spreadsheetCommandGalleryItem247.Caption = "100% Stacked Cylinder"
            spreadsheetCommandGalleryItem247.CommandName = "InsertChartCylinderPercentStacked"
            spreadsheetCommandGalleryItem247.Description = "Compare the percentage that each value contributes to a total across categories."
            spreadsheetCommandGalleryItem247.Hint = "Compare the percentage that each value contributes to a total across categories."
            spreadsheetCommandGalleryItem247.ImageOptions.Image = CType((resources.GetObject("resource.Image53")), System.Drawing.Image)
            spreadsheetCommandGalleryItem248.Caption = "3-D Cylinder"
            spreadsheetCommandGalleryItem248.CommandName = "InsertChartCylinder"
            spreadsheetCommandGalleryItem248.Description = "Compare values across categories and across series and display a cylinder chart o" & "n three axes."
            spreadsheetCommandGalleryItem248.Hint = "Compare values across categories and across series and display a cylinder chart o" & "n three axes."
            spreadsheetCommandGalleryItem248.ImageOptions.Image = CType((resources.GetObject("resource.Image54")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup56.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem245, spreadsheetCommandGalleryItem246, spreadsheetCommandGalleryItem247, spreadsheetCommandGalleryItem248})
            spreadsheetCommandGalleryItemGroup57.CommandName = "InsertChartConeCommandGroup"
            spreadsheetCommandGalleryItem249.Caption = "Clustered Cone"
            spreadsheetCommandGalleryItem249.CommandName = "InsertChartConeClustered"
            spreadsheetCommandGalleryItem249.Description = "Compare values across categories."
            spreadsheetCommandGalleryItem249.Hint = "Compare values across categories."
            spreadsheetCommandGalleryItem249.ImageOptions.Image = CType((resources.GetObject("resource.Image55")), System.Drawing.Image)
            spreadsheetCommandGalleryItem250.Caption = "Stacked Cone"
            spreadsheetCommandGalleryItem250.CommandName = "InsertChartConeStacked"
            spreadsheetCommandGalleryItem250.Description = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem250.Hint = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem250.ImageOptions.Image = CType((resources.GetObject("resource.Image56")), System.Drawing.Image)
            spreadsheetCommandGalleryItem251.Caption = "100% Stacked Cone"
            spreadsheetCommandGalleryItem251.CommandName = "InsertChartConePercentStacked"
            spreadsheetCommandGalleryItem251.Description = "Compare the percentage that each value contributes to a total across categories."
            spreadsheetCommandGalleryItem251.Hint = "Compare the percentage that each value contributes to a total across categories."
            spreadsheetCommandGalleryItem251.ImageOptions.Image = CType((resources.GetObject("resource.Image57")), System.Drawing.Image)
            spreadsheetCommandGalleryItem252.Caption = "3-D Cone"
            spreadsheetCommandGalleryItem252.CommandName = "InsertChartCone"
            spreadsheetCommandGalleryItem252.Description = "Compare values across categories and across series and display a cone chart on th" & "ree axes."
            spreadsheetCommandGalleryItem252.Hint = "Compare values across categories and across series and display a cone chart on th" & "ree axes."
            spreadsheetCommandGalleryItem252.ImageOptions.Image = CType((resources.GetObject("resource.Image58")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup57.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem249, spreadsheetCommandGalleryItem250, spreadsheetCommandGalleryItem251, spreadsheetCommandGalleryItem252})
            spreadsheetCommandGalleryItemGroup58.CommandName = "InsertChartPyramidCommandGroup"
            spreadsheetCommandGalleryItem253.Caption = "Clustered Pyramid"
            spreadsheetCommandGalleryItem253.CommandName = "InsertChartPyramidClustered"
            spreadsheetCommandGalleryItem253.Description = "Compare values across categories."
            spreadsheetCommandGalleryItem253.Hint = "Compare values across categories."
            spreadsheetCommandGalleryItem253.ImageOptions.Image = CType((resources.GetObject("resource.Image59")), System.Drawing.Image)
            spreadsheetCommandGalleryItem254.Caption = "Stacked Pyramid"
            spreadsheetCommandGalleryItem254.CommandName = "InsertChartPyramidStacked"
            spreadsheetCommandGalleryItem254.Description = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem254.Hint = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem254.ImageOptions.Image = CType((resources.GetObject("resource.Image60")), System.Drawing.Image)
            spreadsheetCommandGalleryItem255.Caption = "100% Stacked Pyramid"
            spreadsheetCommandGalleryItem255.CommandName = "InsertChartPyramidPercentStacked"
            spreadsheetCommandGalleryItem255.Description = "Compare the percentage that each value contributes to a total across categories."
            spreadsheetCommandGalleryItem255.Hint = "Compare the percentage that each value contributes to a total across categories."
            spreadsheetCommandGalleryItem255.ImageOptions.Image = CType((resources.GetObject("resource.Image61")), System.Drawing.Image)
            spreadsheetCommandGalleryItem256.Caption = "3-D Pyramid"
            spreadsheetCommandGalleryItem256.CommandName = "InsertChartPyramid"
            spreadsheetCommandGalleryItem256.Description = "Compare values across categories and across series and display a pyramid chart on" & " three axes."
            spreadsheetCommandGalleryItem256.Hint = "Compare values across categories and across series and display a pyramid chart on" & " three axes."
            spreadsheetCommandGalleryItem256.ImageOptions.Image = CType((resources.GetObject("resource.Image62")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup58.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem253, spreadsheetCommandGalleryItem254, spreadsheetCommandGalleryItem255, spreadsheetCommandGalleryItem256})
            Me.commandBarGalleryDropDown54.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup54, spreadsheetCommandGalleryItemGroup55, spreadsheetCommandGalleryItemGroup56, spreadsheetCommandGalleryItemGroup57, spreadsheetCommandGalleryItemGroup58})
            Me.commandBarGalleryDropDown54.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown54.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown54.Manager = Nothing
            Me.commandBarGalleryDropDown54.Name = "commandBarGalleryDropDown54"
            ' 
            ' commandBarGalleryDropDown55
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown55.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup59.CommandName = "InsertChartLine2DCommandGroup"
            spreadsheetCommandGalleryItem257.Caption = "Line"
            spreadsheetCommandGalleryItem257.CommandName = "InsertChartLine"
            spreadsheetCommandGalleryItem257.Description = "Display trend over time (dates, years) or ordered categories." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Useful when ther" & "e are many data points and the order is important."
            spreadsheetCommandGalleryItem257.Hint = "Display trend over time (dates, years) or ordered categories." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Useful when ther" & "e are many data points and the order is important."
            spreadsheetCommandGalleryItem257.ImageOptions.Image = CType((resources.GetObject("resource.Image63")), System.Drawing.Image)
            spreadsheetCommandGalleryItem258.Caption = "Stacked Line"
            spreadsheetCommandGalleryItem258.CommandName = "InsertChartStackedLine"
            spreadsheetCommandGalleryItem258.Description = "Display the trend of the contribution of each value over time or ordered categori" & "es." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using a stacked area chart instead."
            spreadsheetCommandGalleryItem258.Hint = "Display the trend of the contribution of each value over time or ordered categori" & "es." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using a stacked area chart instead."
            spreadsheetCommandGalleryItem258.ImageOptions.Image = CType((resources.GetObject("resource.Image64")), System.Drawing.Image)
            spreadsheetCommandGalleryItem259.Caption = "100% Stacked line"
            spreadsheetCommandGalleryItem259.CommandName = "InsertChartPercentStackedLine"
            spreadsheetCommandGalleryItem259.Description = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using 100% stacked area chart instead."
            spreadsheetCommandGalleryItem259.Hint = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using 100% stacked area chart instead."
            spreadsheetCommandGalleryItem259.ImageOptions.Image = CType((resources.GetObject("resource.Image65")), System.Drawing.Image)
            spreadsheetCommandGalleryItem260.Caption = "Line with Markers"
            spreadsheetCommandGalleryItem260.CommandName = "InsertChartLineWithMarkers"
            spreadsheetCommandGalleryItem260.Description = "Display trend over time (dates, years) or ordered categories." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Useful when ther" & "e are only a few data points."
            spreadsheetCommandGalleryItem260.Hint = "Display trend over time (dates, years) or ordered categories." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Useful when ther" & "e are only a few data points."
            spreadsheetCommandGalleryItem260.ImageOptions.Image = CType((resources.GetObject("resource.Image66")), System.Drawing.Image)
            spreadsheetCommandGalleryItem261.Caption = "Stacked Line with Markers"
            spreadsheetCommandGalleryItem261.CommandName = "InsertChartStackedLineWithMarkers"
            spreadsheetCommandGalleryItem261.Description = "Display the trend of the contribution of each value over time or ordered categori" & "es." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using a stacked area chart instead."
            spreadsheetCommandGalleryItem261.Hint = "Display the trend of the contribution of each value over time or ordered categori" & "es." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using a stacked area chart instead."
            spreadsheetCommandGalleryItem261.ImageOptions.Image = CType((resources.GetObject("resource.Image67")), System.Drawing.Image)
            spreadsheetCommandGalleryItem262.Caption = "100% Stacked Line with Markers"
            spreadsheetCommandGalleryItem262.CommandName = "InsertChartPercentStackedLineWithMarkers"
            spreadsheetCommandGalleryItem262.Description = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using 100% stacked area chart instead."
            spreadsheetCommandGalleryItem262.Hint = "Display the trend of the percentage each value contributes over time or ordered c" & "ategories." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using 100% stacked area chart instead."
            spreadsheetCommandGalleryItem262.ImageOptions.Image = CType((resources.GetObject("resource.Image68")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup59.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem257, spreadsheetCommandGalleryItem258, spreadsheetCommandGalleryItem259, spreadsheetCommandGalleryItem260, spreadsheetCommandGalleryItem261, spreadsheetCommandGalleryItem262})
            spreadsheetCommandGalleryItemGroup60.CommandName = "InsertChartLine3DCommandGroup"
            spreadsheetCommandGalleryItem263.Caption = "3-D Line"
            spreadsheetCommandGalleryItem263.CommandName = "InsertChartLine3D"
            spreadsheetCommandGalleryItem263.Description = "Display each row or column of data as a 3-D ribbon on three axes."
            spreadsheetCommandGalleryItem263.Hint = "Display each row or column of data as a 3-D ribbon on three axes."
            spreadsheetCommandGalleryItem263.ImageOptions.Image = CType((resources.GetObject("resource.Image69")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup60.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem263})
            Me.commandBarGalleryDropDown55.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup59, spreadsheetCommandGalleryItemGroup60})
            Me.commandBarGalleryDropDown55.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown55.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown55.Manager = Nothing
            Me.commandBarGalleryDropDown55.Name = "commandBarGalleryDropDown55"
            ' 
            ' commandBarGalleryDropDown56
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown56.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup61.CommandName = "InsertChartPie2DCommandGroup"
            spreadsheetCommandGalleryItem264.Caption = "Pie"
            spreadsheetCommandGalleryItem264.CommandName = "InsertChartPie2D"
            spreadsheetCommandGalleryItem264.Description = "Display the contribution of each value to a total." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the values can " & "be added together or when you have only one data series and all values are posit" & "ive."
            spreadsheetCommandGalleryItem264.Hint = "Display the contribution of each value to a total." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the values can " & "be added together or when you have only one data series and all values are posit" & "ive."
            spreadsheetCommandGalleryItem264.ImageOptions.Image = CType((resources.GetObject("resource.Image70")), System.Drawing.Image)
            spreadsheetCommandGalleryItem265.Caption = "Exploded Pie"
            spreadsheetCommandGalleryItem265.CommandName = "InsertChartPieExploded2D"
            spreadsheetCommandGalleryItem265.Description = "Display the contribution of each value to a total while emphasizing individual va" & "lues." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using a pie chart, and explode individual values instead."
            spreadsheetCommandGalleryItem265.Hint = "Display the contribution of each value to a total while emphasizing individual va" & "lues." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using a pie chart, and explode individual values instead."
            spreadsheetCommandGalleryItem265.ImageOptions.Image = CType((resources.GetObject("resource.Image71")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup61.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem264, spreadsheetCommandGalleryItem265})
            spreadsheetCommandGalleryItemGroup62.CommandName = "InsertChartPie3DCommandGroup"
            spreadsheetCommandGalleryItem266.Caption = "Pie in 3-D"
            spreadsheetCommandGalleryItem266.CommandName = "InsertChartPie3D"
            spreadsheetCommandGalleryItem266.Description = "Display the contribution of each value to a total."
            spreadsheetCommandGalleryItem266.Hint = "Display the contribution of each value to a total."
            spreadsheetCommandGalleryItem266.ImageOptions.Image = CType((resources.GetObject("resource.Image72")), System.Drawing.Image)
            spreadsheetCommandGalleryItem267.Caption = "Exploded pie in 3-D"
            spreadsheetCommandGalleryItem267.CommandName = "InsertChartPieExploded3D"
            spreadsheetCommandGalleryItem267.Description = "Display the contribution of each value to a total while emphasizing individual va" & "lues." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using a 3-D pie chart, and explode individual values instead."
            spreadsheetCommandGalleryItem267.Hint = "Display the contribution of each value to a total while emphasizing individual va" & "lues." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Consider using a 3-D pie chart, and explode individual values instead."
            spreadsheetCommandGalleryItem267.ImageOptions.Image = CType((resources.GetObject("resource.Image73")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup62.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem266, spreadsheetCommandGalleryItem267})
            spreadsheetCommandGalleryItemGroup63.CommandName = "InsertChartDoughnut2DCommandGroup"
            spreadsheetCommandGalleryItem268.Caption = "Doughnut"
            spreadsheetCommandGalleryItem268.CommandName = "InsertChartDoughnut2D"
            spreadsheetCommandGalleryItem268.Description = "Display the contribution of each value to a total like a pie chart, but it can co" & "ntain multiple series."
            spreadsheetCommandGalleryItem268.Hint = "Display the contribution of each value to a total like a pie chart, but it can co" & "ntain multiple series."
            spreadsheetCommandGalleryItem268.ImageOptions.Image = CType((resources.GetObject("resource.Image74")), System.Drawing.Image)
            spreadsheetCommandGalleryItem269.Caption = "Exploded Doughnut"
            spreadsheetCommandGalleryItem269.CommandName = "InsertChartDoughnutExploded2D"
            spreadsheetCommandGalleryItem269.Description = "Display the contribution of each value to a total while emphasizing individual va" & "lues like an exploded pie chart, but it can contain multiple series."
            spreadsheetCommandGalleryItem269.Hint = "Display the contribution of each value to a total while emphasizing individual va" & "lues like an exploded pie chart, but it can contain multiple series."
            spreadsheetCommandGalleryItem269.ImageOptions.Image = CType((resources.GetObject("resource.Image75")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup63.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem268, spreadsheetCommandGalleryItem269})
            Me.commandBarGalleryDropDown56.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup61, spreadsheetCommandGalleryItemGroup62, spreadsheetCommandGalleryItemGroup63})
            Me.commandBarGalleryDropDown56.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown56.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown56.Manager = Nothing
            Me.commandBarGalleryDropDown56.Name = "commandBarGalleryDropDown56"
            ' 
            ' commandBarGalleryDropDown57
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown57.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup64.CommandName = "InsertChartBar2DCommandGroup"
            spreadsheetCommandGalleryItem270.Caption = "Clustered Bar"
            spreadsheetCommandGalleryItem270.CommandName = "InsertChartBarClustered2D"
            spreadsheetCommandGalleryItem270.Description = "Compare values across categories using horizontal rectangles." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the " & "values on the chart represent durations or when the category text is very long."
            spreadsheetCommandGalleryItem270.Hint = "Compare values across categories using horizontal rectangles." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the " & "values on the chart represent durations or when the category text is very long."
            spreadsheetCommandGalleryItem270.ImageOptions.Image = CType((resources.GetObject("resource.Image76")), System.Drawing.Image)
            spreadsheetCommandGalleryItem271.Caption = "Stacked Bar"
            spreadsheetCommandGalleryItem271.CommandName = "InsertChartBarStacked2D"
            spreadsheetCommandGalleryItem271.Description = "Compare the contribution of each value to a total across categories by using hori" & "zontal rectangles." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the values on the chart represent durations or" & " when the category text is very long."
            spreadsheetCommandGalleryItem271.Hint = "Compare the contribution of each value to a total across categories by using hori" & "zontal rectangles." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the values on the chart represent durations or" & " when the category text is very long."
            spreadsheetCommandGalleryItem271.ImageOptions.Image = CType((resources.GetObject("resource.Image77")), System.Drawing.Image)
            spreadsheetCommandGalleryItem272.Caption = "100% Stacked Bar"
            spreadsheetCommandGalleryItem272.CommandName = "InsertChartBarPercentStacked2D"
            spreadsheetCommandGalleryItem272.Description = resources.GetString("spreadsheetCommandGalleryItem272.Description")
            spreadsheetCommandGalleryItem272.Hint = resources.GetString("spreadsheetCommandGalleryItem272.Hint")
            spreadsheetCommandGalleryItem272.ImageOptions.Image = CType((resources.GetObject("resource.Image78")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup64.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem270, spreadsheetCommandGalleryItem271, spreadsheetCommandGalleryItem272})
            spreadsheetCommandGalleryItemGroup65.CommandName = "InsertChartBar3DCommandGroup"
            spreadsheetCommandGalleryItem273.Caption = "Clustered Bar in 3-D"
            spreadsheetCommandGalleryItem273.CommandName = "InsertChartBarClustered3D"
            spreadsheetCommandGalleryItem273.Description = "Compare values across categories and display clustered bars in 3-D format."
            spreadsheetCommandGalleryItem273.Hint = "Compare values across categories and display clustered bars in 3-D format."
            spreadsheetCommandGalleryItem273.ImageOptions.Image = CType((resources.GetObject("resource.Image79")), System.Drawing.Image)
            spreadsheetCommandGalleryItem274.Caption = "Stacked Bar in 3-D"
            spreadsheetCommandGalleryItem274.CommandName = "InsertChartBarStacked3D"
            spreadsheetCommandGalleryItem274.Description = "Compare the contribution of each value to a total across categories and display s" & "tacked bars in 3-D format."
            spreadsheetCommandGalleryItem274.Hint = "Compare the contribution of each value to a total across categories and display s" & "tacked bars in 3-D format."
            spreadsheetCommandGalleryItem274.ImageOptions.Image = CType((resources.GetObject("resource.Image80")), System.Drawing.Image)
            spreadsheetCommandGalleryItem275.Caption = "100% Stacked Bar in 3-D"
            spreadsheetCommandGalleryItem275.CommandName = "InsertChartBarPercentStacked3D"
            spreadsheetCommandGalleryItem275.Description = "Compare the percentange each value contributes to a total across categories and d" & "isplay 100% stacked bars in 3-D format."
            spreadsheetCommandGalleryItem275.Hint = "Compare the percentange each value contributes to a total across categories and d" & "isplay 100% stacked bars in 3-D format."
            spreadsheetCommandGalleryItem275.ImageOptions.Image = CType((resources.GetObject("resource.Image81")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup65.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem273, spreadsheetCommandGalleryItem274, spreadsheetCommandGalleryItem275})
            spreadsheetCommandGalleryItemGroup66.CommandName = "InsertChartHorizontalCylinderCommandGroup"
            spreadsheetCommandGalleryItem276.Caption = "Clustered Horizontal Cylinder"
            spreadsheetCommandGalleryItem276.CommandName = "InsertChartHorizontalCylinderClustered"
            spreadsheetCommandGalleryItem276.Description = "Compare values across categories."
            spreadsheetCommandGalleryItem276.Hint = "Compare values across categories."
            spreadsheetCommandGalleryItem276.ImageOptions.Image = CType((resources.GetObject("resource.Image82")), System.Drawing.Image)
            spreadsheetCommandGalleryItem277.Caption = "Stacked Horizontal Cylinder"
            spreadsheetCommandGalleryItem277.CommandName = "InsertChartHorizontalCylinderStacked"
            spreadsheetCommandGalleryItem277.Description = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem277.Hint = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem277.ImageOptions.Image = CType((resources.GetObject("resource.Image83")), System.Drawing.Image)
            spreadsheetCommandGalleryItem278.Caption = "100% Stacked Horizontal Cylinder"
            spreadsheetCommandGalleryItem278.CommandName = "InsertChartHorizontalCylinderPercentStacked"
            spreadsheetCommandGalleryItem278.Description = "Compare the percentange each value contributes to a total across categories."
            spreadsheetCommandGalleryItem278.Hint = "Compare the percentange each value contributes to a total across categories."
            spreadsheetCommandGalleryItem278.ImageOptions.Image = CType((resources.GetObject("resource.Image84")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup66.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem276, spreadsheetCommandGalleryItem277, spreadsheetCommandGalleryItem278})
            spreadsheetCommandGalleryItemGroup67.CommandName = "InsertChartHorizontalConeCommandGroup"
            spreadsheetCommandGalleryItem279.Caption = "Clustered Horizontal Cone"
            spreadsheetCommandGalleryItem279.CommandName = "InsertChartHorizontalConeClustered"
            spreadsheetCommandGalleryItem279.Description = "Compare values across categories."
            spreadsheetCommandGalleryItem279.Hint = "Compare values across categories."
            spreadsheetCommandGalleryItem279.ImageOptions.Image = CType((resources.GetObject("resource.Image85")), System.Drawing.Image)
            spreadsheetCommandGalleryItem280.Caption = "Stacked Horizontal Cone"
            spreadsheetCommandGalleryItem280.CommandName = "InsertChartHorizontalConeStacked"
            spreadsheetCommandGalleryItem280.Description = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem280.Hint = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem280.ImageOptions.Image = CType((resources.GetObject("resource.Image86")), System.Drawing.Image)
            spreadsheetCommandGalleryItem281.Caption = "100% Stacked Horizontal Cone"
            spreadsheetCommandGalleryItem281.CommandName = "InsertChartHorizontalConePercentStacked"
            spreadsheetCommandGalleryItem281.Description = "Compare the percentange each value contributes to a total across categories."
            spreadsheetCommandGalleryItem281.Hint = "Compare the percentange each value contributes to a total across categories."
            spreadsheetCommandGalleryItem281.ImageOptions.Image = CType((resources.GetObject("resource.Image87")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup67.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem279, spreadsheetCommandGalleryItem280, spreadsheetCommandGalleryItem281})
            spreadsheetCommandGalleryItemGroup68.CommandName = "InsertChartHorizontalPyramidCommandGroup"
            spreadsheetCommandGalleryItem282.Caption = "Clustered Horizontal Pyramid"
            spreadsheetCommandGalleryItem282.CommandName = "InsertChartHorizontalPyramidClustered"
            spreadsheetCommandGalleryItem282.Description = "Compare values across categories."
            spreadsheetCommandGalleryItem282.Hint = "Compare values across categories."
            spreadsheetCommandGalleryItem282.ImageOptions.Image = CType((resources.GetObject("resource.Image88")), System.Drawing.Image)
            spreadsheetCommandGalleryItem283.Caption = "Stacked Horizontal Pyramid"
            spreadsheetCommandGalleryItem283.CommandName = "InsertChartHorizontalPyramidStacked"
            spreadsheetCommandGalleryItem283.Description = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem283.Hint = "Compare the contribution of each value to a total across categories."
            spreadsheetCommandGalleryItem283.ImageOptions.Image = CType((resources.GetObject("resource.Image89")), System.Drawing.Image)
            spreadsheetCommandGalleryItem284.Caption = "100% Stacked Horizontal Pyramid"
            spreadsheetCommandGalleryItem284.CommandName = "InsertChartHorizontalPyramidPercentStacked"
            spreadsheetCommandGalleryItem284.Description = "Compare the percentange each value contributes to a total across categories."
            spreadsheetCommandGalleryItem284.Hint = "Compare the percentange each value contributes to a total across categories."
            spreadsheetCommandGalleryItem284.ImageOptions.Image = CType((resources.GetObject("resource.Image90")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup68.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem282, spreadsheetCommandGalleryItem283, spreadsheetCommandGalleryItem284})
            Me.commandBarGalleryDropDown57.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup64, spreadsheetCommandGalleryItemGroup65, spreadsheetCommandGalleryItemGroup66, spreadsheetCommandGalleryItemGroup67, spreadsheetCommandGalleryItemGroup68})
            Me.commandBarGalleryDropDown57.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown57.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown57.Manager = Nothing
            Me.commandBarGalleryDropDown57.Name = "commandBarGalleryDropDown57"
            ' 
            ' commandBarGalleryDropDown58
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown58.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup69.CommandName = "InsertChartArea2DCommandGroup"
            spreadsheetCommandGalleryItem285.Caption = "Area"
            spreadsheetCommandGalleryItem285.CommandName = "InsertChartArea"
            spreadsheetCommandGalleryItem285.Description = "Display the trend of values over time or categories."
            spreadsheetCommandGalleryItem285.Hint = "Display the trend of values over time or categories."
            spreadsheetCommandGalleryItem285.ImageOptions.Image = CType((resources.GetObject("resource.Image91")), System.Drawing.Image)
            spreadsheetCommandGalleryItem286.Caption = "Stacked Area"
            spreadsheetCommandGalleryItem286.CommandName = "InsertChartStackedArea"
            spreadsheetCommandGalleryItem286.Description = "Display the trend of the contribution of each value over time or categories." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "U" & "se it to emphasize the trend in the total across series for one category."
            spreadsheetCommandGalleryItem286.Hint = "Display the trend of the contribution of each value over time or categories." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "U" & "se it to emphasize the trend in the total across series for one category."
            spreadsheetCommandGalleryItem286.ImageOptions.Image = CType((resources.GetObject("resource.Image92")), System.Drawing.Image)
            spreadsheetCommandGalleryItem287.Caption = "100% Stacked Area"
            spreadsheetCommandGalleryItem287.CommandName = "InsertChartPercentStackedArea"
            spreadsheetCommandGalleryItem287.Description = "Display the trend of the percentage each value contibutes over time or categories" & "." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it to emphasize the trend in the proportion of each series."
            spreadsheetCommandGalleryItem287.Hint = "Display the trend of the percentage each value contibutes over time or categories" & "." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it to emphasize the trend in the proportion of each series."
            spreadsheetCommandGalleryItem287.ImageOptions.Image = CType((resources.GetObject("resource.Image93")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup69.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem285, spreadsheetCommandGalleryItem286, spreadsheetCommandGalleryItem287})
            spreadsheetCommandGalleryItemGroup70.CommandName = "InsertChartArea3DCommandGroup"
            spreadsheetCommandGalleryItem288.Caption = "3-D Area"
            spreadsheetCommandGalleryItem288.CommandName = "InsertChartArea3D"
            spreadsheetCommandGalleryItem288.Description = "Display the trend of values over time or categories using areas on three axes."
            spreadsheetCommandGalleryItem288.Hint = "Display the trend of values over time or categories using areas on three axes."
            spreadsheetCommandGalleryItem288.ImageOptions.Image = CType((resources.GetObject("resource.Image94")), System.Drawing.Image)
            spreadsheetCommandGalleryItem289.Caption = "Stacked Area in 3-D"
            spreadsheetCommandGalleryItem289.CommandName = "InsertChartStackedArea3D"
            spreadsheetCommandGalleryItem289.Description = "Display the trend of the contribution of each value over time or categories by us" & "ing stacked areas in a 3-D format."
            spreadsheetCommandGalleryItem289.Hint = "Display the trend of the contribution of each value over time or categories by us" & "ing stacked areas in a 3-D format."
            spreadsheetCommandGalleryItem289.ImageOptions.Image = CType((resources.GetObject("resource.Image95")), System.Drawing.Image)
            spreadsheetCommandGalleryItem290.Caption = "100% Stacked Area in 3-D"
            spreadsheetCommandGalleryItem290.CommandName = "InsertChartPercentStackedArea3D"
            spreadsheetCommandGalleryItem290.Description = "Display the trend of the percentage each value contributes over time or categorie" & "s by using 100% stacked areas in 3-D format."
            spreadsheetCommandGalleryItem290.Hint = "Display the trend of the percentage each value contributes over time or categorie" & "s by using 100% stacked areas in 3-D format."
            spreadsheetCommandGalleryItem290.ImageOptions.Image = CType((resources.GetObject("resource.Image96")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup70.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem288, spreadsheetCommandGalleryItem289, spreadsheetCommandGalleryItem290})
            Me.commandBarGalleryDropDown58.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup69, spreadsheetCommandGalleryItemGroup70})
            Me.commandBarGalleryDropDown58.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown58.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown58.Manager = Nothing
            Me.commandBarGalleryDropDown58.Name = "commandBarGalleryDropDown58"
            ' 
            ' commandBarGalleryDropDown59
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown59.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup71.CommandName = "InsertChartScatterCommandGroup"
            spreadsheetCommandGalleryItem291.Caption = "Scatter with only Markers"
            spreadsheetCommandGalleryItem291.CommandName = "InsertChartScatterMarkers"
            spreadsheetCommandGalleryItem291.Description = "Compare pairs of values." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is when the values are not in X-axis order or whe" & "n they represent separate measurements."
            spreadsheetCommandGalleryItem291.Hint = "Compare pairs of values." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is when the values are not in X-axis order or whe" & "n they represent separate measurements."
            spreadsheetCommandGalleryItem291.ImageOptions.Image = CType((resources.GetObject("resource.Image97")), System.Drawing.Image)
            spreadsheetCommandGalleryItem292.Caption = "Scatter with Smooth Lines and Markers"
            spreadsheetCommandGalleryItem292.CommandName = "InsertChartScatterSmoothLinesAndMarkers"
            spreadsheetCommandGalleryItem292.Description = "Compare pairs of values." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is when there are a few data points in X-axis ord" & "er and the data represents a function."
            spreadsheetCommandGalleryItem292.Hint = "Compare pairs of values." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is when there are a few data points in X-axis ord" & "er and the data represents a function."
            spreadsheetCommandGalleryItem292.ImageOptions.Image = CType((resources.GetObject("resource.Image98")), System.Drawing.Image)
            spreadsheetCommandGalleryItem293.Caption = "Scatter with Smooth Lines"
            spreadsheetCommandGalleryItem293.CommandName = "InsertChartScatterSmoothLines"
            spreadsheetCommandGalleryItem293.Description = "Compare pairs of values." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is when there are many data points in X-axis orde" & "r and the data represents a function."
            spreadsheetCommandGalleryItem293.Hint = "Compare pairs of values." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is when there are many data points in X-axis orde" & "r and the data represents a function."
            spreadsheetCommandGalleryItem293.ImageOptions.Image = CType((resources.GetObject("resource.Image99")), System.Drawing.Image)
            spreadsheetCommandGalleryItem294.Caption = "Scatter with Straight Lines and Markers"
            spreadsheetCommandGalleryItem294.CommandName = "InsertChartScatterLinesAndMarkers"
            spreadsheetCommandGalleryItem294.Description = "Compare pairs of values." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is when there are a few data points in X-axis ord" & "er and the data represents separate samples."
            spreadsheetCommandGalleryItem294.Hint = "Compare pairs of values." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is when there are a few data points in X-axis ord" & "er and the data represents separate samples."
            spreadsheetCommandGalleryItem294.ImageOptions.Image = CType((resources.GetObject("resource.Image100")), System.Drawing.Image)
            spreadsheetCommandGalleryItem295.Caption = "Scatter with Straight Lines"
            spreadsheetCommandGalleryItem295.CommandName = "InsertChartScatterLines"
            spreadsheetCommandGalleryItem295.Description = "Compare pairs of values." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is when there are many data points in X-axis orde" & "r and the data represents separate samples."
            spreadsheetCommandGalleryItem295.Hint = "Compare pairs of values." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use is when there are many data points in X-axis orde" & "r and the data represents separate samples."
            spreadsheetCommandGalleryItem295.ImageOptions.Image = CType((resources.GetObject("resource.Image101")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup71.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem291, spreadsheetCommandGalleryItem292, spreadsheetCommandGalleryItem293, spreadsheetCommandGalleryItem294, spreadsheetCommandGalleryItem295})
            spreadsheetCommandGalleryItemGroup72.CommandName = "InsertChartBubbleCommandGroup"
            spreadsheetCommandGalleryItem296.Caption = "Bubble"
            spreadsheetCommandGalleryItem296.CommandName = "InsertChartBubble"
            spreadsheetCommandGalleryItem296.Description = "Resembles a scatter chart, but compares sets of three values instead of two. The " & "third value determines the size of the bubble marker."
            spreadsheetCommandGalleryItem296.Hint = "Resembles a scatter chart, but compares sets of three values instead of two. The " & "third value determines the size of the bubble marker."
            spreadsheetCommandGalleryItem296.ImageOptions.Image = CType((resources.GetObject("resource.Image102")), System.Drawing.Image)
            spreadsheetCommandGalleryItem297.Caption = "Bubble with a 3-D effect"
            spreadsheetCommandGalleryItem297.CommandName = "InsertChartBubble3D"
            spreadsheetCommandGalleryItem297.Description = "Resembles a scatter chart, but compares sets of three values instead of two. The " & "third value determines the size of the bubble marker, which is displayed with a " & "3-D effect."
            spreadsheetCommandGalleryItem297.Hint = "Resembles a scatter chart, but compares sets of three values instead of two. The " & "third value determines the size of the bubble marker, which is displayed with a " & "3-D effect."
            spreadsheetCommandGalleryItem297.ImageOptions.Image = CType((resources.GetObject("resource.Image103")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup72.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem296, spreadsheetCommandGalleryItem297})
            Me.commandBarGalleryDropDown59.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup71, spreadsheetCommandGalleryItemGroup72})
            Me.commandBarGalleryDropDown59.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown59.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown59.Manager = Nothing
            Me.commandBarGalleryDropDown59.Name = "commandBarGalleryDropDown59"
            ' 
            ' commandBarGalleryDropDown60
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown60.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup73.CommandName = "InsertChartStockCommandGroup"
            spreadsheetCommandGalleryItem298.Caption = "High-Low-Close"
            spreadsheetCommandGalleryItem298.CommandName = "InsertChartStockHighLowClose"
            spreadsheetCommandGalleryItem298.Description = "Requires three series of values in order High, Low and Close."
            spreadsheetCommandGalleryItem298.Hint = "Requires three series of values in order High, Low and Close."
            spreadsheetCommandGalleryItem298.ImageOptions.Image = CType((resources.GetObject("resource.Image104")), System.Drawing.Image)
            spreadsheetCommandGalleryItem299.Caption = "Open-High-Low-Close"
            spreadsheetCommandGalleryItem299.CommandName = "InsertChartStockOpenHighLowClose"
            spreadsheetCommandGalleryItem299.Description = "Requires four series of values in order Open, High, Low and Close."
            spreadsheetCommandGalleryItem299.Hint = "Requires four series of values in order Open, High, Low and Close."
            spreadsheetCommandGalleryItem299.ImageOptions.Image = CType((resources.GetObject("resource.Image105")), System.Drawing.Image)
            spreadsheetCommandGalleryItem300.Caption = "Volume-High-Low-Close"
            spreadsheetCommandGalleryItem300.CommandName = "InsertChartStockVolumeHighLowClose"
            spreadsheetCommandGalleryItem300.Description = "Requires four series of values in order Volume, High, Low and Close."
            spreadsheetCommandGalleryItem300.Hint = "Requires four series of values in order Volume, High, Low and Close."
            spreadsheetCommandGalleryItem300.ImageOptions.Image = CType((resources.GetObject("resource.Image106")), System.Drawing.Image)
            spreadsheetCommandGalleryItem301.Caption = "Volume-Open-High-Low-Close"
            spreadsheetCommandGalleryItem301.CommandName = "InsertChartStockVolumeOpenHighLowClose"
            spreadsheetCommandGalleryItem301.Description = "Requires five series of values in order Volume, Open, High, Low and Close."
            spreadsheetCommandGalleryItem301.Hint = "Requires five series of values in order Volume, Open, High, Low and Close."
            spreadsheetCommandGalleryItem301.ImageOptions.Image = CType((resources.GetObject("resource.Image107")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup73.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem298, spreadsheetCommandGalleryItem299, spreadsheetCommandGalleryItem300, spreadsheetCommandGalleryItem301})
            spreadsheetCommandGalleryItemGroup74.CommandName = "InsertChartRadarCommandGroup"
            spreadsheetCommandGalleryItem302.Caption = "Radar"
            spreadsheetCommandGalleryItem302.CommandName = "InsertChartRadar"
            spreadsheetCommandGalleryItem302.Description = "Display values relative to a center point." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the categories are not " & "directly comparable."
            spreadsheetCommandGalleryItem302.Hint = "Display values relative to a center point." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the categories are not " & "directly comparable."
            spreadsheetCommandGalleryItem302.ImageOptions.Image = CType((resources.GetObject("resource.Image108")), System.Drawing.Image)
            spreadsheetCommandGalleryItem303.Caption = "Radar with Markers"
            spreadsheetCommandGalleryItem303.CommandName = "InsertChartRadarWithMarkers"
            spreadsheetCommandGalleryItem303.Description = "Display values relative to a center point." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the categories are not " & "directly comparable."
            spreadsheetCommandGalleryItem303.Hint = "Display values relative to a center point." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the categories are not " & "directly comparable."
            spreadsheetCommandGalleryItem303.ImageOptions.Image = CType((resources.GetObject("resource.Image109")), System.Drawing.Image)
            spreadsheetCommandGalleryItem304.Caption = "Filled Radar"
            spreadsheetCommandGalleryItem304.CommandName = "InsertChartRadarFilled"
            spreadsheetCommandGalleryItem304.Description = "Display values relative to a center point." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the categories are not " & "directly comparable and there is only one series."
            spreadsheetCommandGalleryItem304.Hint = "Display values relative to a center point." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Use it when the categories are not " & "directly comparable and there is only one series."
            spreadsheetCommandGalleryItem304.ImageOptions.Image = CType((resources.GetObject("resource.Image110")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup74.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem302, spreadsheetCommandGalleryItem303, spreadsheetCommandGalleryItem304})
            Me.commandBarGalleryDropDown60.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup73, spreadsheetCommandGalleryItemGroup74})
            Me.commandBarGalleryDropDown60.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown60.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown60.Manager = Nothing
            Me.commandBarGalleryDropDown60.Name = "commandBarGalleryDropDown60"
            ' 
            ' commandBarGalleryDropDown61
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown61.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown61.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup75.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
            spreadsheetCommandGalleryItem305.Caption = "None"
            spreadsheetCommandGalleryItem305.CommandName = "ChartHidePrimaryHorizontalAxis"
            spreadsheetCommandGalleryItem305.Description = "Do not display axis."
            spreadsheetCommandGalleryItem305.Hint = "Do not display axis."
            spreadsheetCommandGalleryItem305.ImageOptions.Image = CType((resources.GetObject("resource.Image111")), System.Drawing.Image)
            spreadsheetCommandGalleryItem306.Caption = "Show Left to Right Axis"
            spreadsheetCommandGalleryItem306.CommandName = "ChartPrimaryHorizontalAxisLeftToRight"
            spreadsheetCommandGalleryItem306.Description = "Display Axis Left to Right with Labels"
            spreadsheetCommandGalleryItem306.Hint = "Display Axis Left to Right with Labels"
            spreadsheetCommandGalleryItem306.ImageOptions.Image = CType((resources.GetObject("resource.Image112")), System.Drawing.Image)
            spreadsheetCommandGalleryItem307.Caption = "Show Axis without Labeling"
            spreadsheetCommandGalleryItem307.CommandName = "ChartPrimaryHorizontalAxisHideLabels"
            spreadsheetCommandGalleryItem307.Description = "Display Axis without labels or tick marks"
            spreadsheetCommandGalleryItem307.Hint = "Display Axis without labels or tick marks"
            spreadsheetCommandGalleryItem307.ImageOptions.Image = CType((resources.GetObject("resource.Image113")), System.Drawing.Image)
            spreadsheetCommandGalleryItem308.Caption = "Show Right to Left Axis"
            spreadsheetCommandGalleryItem308.CommandName = "ChartPrimaryHorizontalAxisRightToLeft"
            spreadsheetCommandGalleryItem308.Description = "Display Axis Right to Left with Labels"
            spreadsheetCommandGalleryItem308.Hint = "Display Axis Right to Left with Labels"
            spreadsheetCommandGalleryItem308.ImageOptions.Image = CType((resources.GetObject("resource.Image114")), System.Drawing.Image)
            spreadsheetCommandGalleryItem309.Caption = "Show Default Axis"
            spreadsheetCommandGalleryItem309.CommandName = "ChartPrimaryHorizontalAxisDefault"
            spreadsheetCommandGalleryItem309.Description = "Display Axis with default order and labels"
            spreadsheetCommandGalleryItem309.Hint = "Display Axis with default order and labels"
            spreadsheetCommandGalleryItem309.ImageOptions.Image = CType((resources.GetObject("resource.Image115")), System.Drawing.Image)
            spreadsheetCommandGalleryItem310.Caption = "Show Axis in Thousands"
            spreadsheetCommandGalleryItem310.CommandName = "ChartPrimaryHorizontalAxisScaleThousands"
            spreadsheetCommandGalleryItem310.Description = "Display Axis with numbers represented in Thousands"
            spreadsheetCommandGalleryItem310.Hint = "Display Axis with numbers represented in Thousands"
            spreadsheetCommandGalleryItem310.ImageOptions.Image = CType((resources.GetObject("resource.Image116")), System.Drawing.Image)
            spreadsheetCommandGalleryItem311.Caption = "Show Axis in Millions"
            spreadsheetCommandGalleryItem311.CommandName = "ChartPrimaryHorizontalAxisScaleMillions"
            spreadsheetCommandGalleryItem311.Description = "Display Axis with numbers represented in Millions"
            spreadsheetCommandGalleryItem311.Hint = "Display Axis with numbers represented in Millions"
            spreadsheetCommandGalleryItem311.ImageOptions.Image = CType((resources.GetObject("resource.Image117")), System.Drawing.Image)
            spreadsheetCommandGalleryItem312.Caption = "Show Axis in Billions"
            spreadsheetCommandGalleryItem312.CommandName = "ChartPrimaryHorizontalAxisScaleBillions"
            spreadsheetCommandGalleryItem312.Description = "Display Axis with numbers represented in Billions"
            spreadsheetCommandGalleryItem312.Hint = "Display Axis with numbers represented in Billions"
            spreadsheetCommandGalleryItem312.ImageOptions.Image = CType((resources.GetObject("resource.Image118")), System.Drawing.Image)
            spreadsheetCommandGalleryItem313.Caption = "Show Axis in Log Scale"
            spreadsheetCommandGalleryItem313.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm"
            spreadsheetCommandGalleryItem313.Description = "Display Axis using a log 10 base scale"
            spreadsheetCommandGalleryItem313.Hint = "Display Axis using a log 10 base scale"
            spreadsheetCommandGalleryItem313.ImageOptions.Image = CType((resources.GetObject("resource.Image119")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup75.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem305, spreadsheetCommandGalleryItem306, spreadsheetCommandGalleryItem307, spreadsheetCommandGalleryItem308, spreadsheetCommandGalleryItem309, spreadsheetCommandGalleryItem310, spreadsheetCommandGalleryItem311, spreadsheetCommandGalleryItem312, spreadsheetCommandGalleryItem313})
            Me.commandBarGalleryDropDown61.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup75})
            Me.commandBarGalleryDropDown61.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown61.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown61.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown61.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown61.Manager = Nothing
            Me.commandBarGalleryDropDown61.Name = "commandBarGalleryDropDown61"
            ' 
            ' commandBarGalleryDropDown62
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown62.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown62.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup76.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
            spreadsheetCommandGalleryItem314.Caption = "None"
            spreadsheetCommandGalleryItem314.CommandName = "ChartHidePrimaryVerticalAxis"
            spreadsheetCommandGalleryItem314.Description = "Do not display axis."
            spreadsheetCommandGalleryItem314.Hint = "Do not display axis."
            spreadsheetCommandGalleryItem314.ImageOptions.Image = CType((resources.GetObject("resource.Image120")), System.Drawing.Image)
            spreadsheetCommandGalleryItem315.Caption = "Show Left to Right Axis"
            spreadsheetCommandGalleryItem315.CommandName = "ChartPrimaryVerticalAxisLeftToRight"
            spreadsheetCommandGalleryItem315.Description = "Display Axis Left to Right with Labels"
            spreadsheetCommandGalleryItem315.Hint = "Display Axis Left to Right with Labels"
            spreadsheetCommandGalleryItem315.ImageOptions.Image = CType((resources.GetObject("resource.Image121")), System.Drawing.Image)
            spreadsheetCommandGalleryItem316.Caption = "Show Axis without Labeling"
            spreadsheetCommandGalleryItem316.CommandName = "ChartPrimaryVerticalAxisHideLabels"
            spreadsheetCommandGalleryItem316.Description = "Display Axis without labels or tick marks"
            spreadsheetCommandGalleryItem316.Hint = "Display Axis without labels or tick marks"
            spreadsheetCommandGalleryItem316.ImageOptions.Image = CType((resources.GetObject("resource.Image122")), System.Drawing.Image)
            spreadsheetCommandGalleryItem317.Caption = "Show Right to Left Axis"
            spreadsheetCommandGalleryItem317.CommandName = "ChartPrimaryVerticalAxisRightToLeft"
            spreadsheetCommandGalleryItem317.Description = "Display Axis Right to Left with Labels"
            spreadsheetCommandGalleryItem317.Hint = "Display Axis Right to Left with Labels"
            spreadsheetCommandGalleryItem317.ImageOptions.Image = CType((resources.GetObject("resource.Image123")), System.Drawing.Image)
            spreadsheetCommandGalleryItem318.Caption = "Show Default Axis"
            spreadsheetCommandGalleryItem318.CommandName = "ChartPrimaryVerticalAxisDefault"
            spreadsheetCommandGalleryItem318.Description = "Display Axis with default order and labels"
            spreadsheetCommandGalleryItem318.Hint = "Display Axis with default order and labels"
            spreadsheetCommandGalleryItem318.ImageOptions.Image = CType((resources.GetObject("resource.Image124")), System.Drawing.Image)
            spreadsheetCommandGalleryItem319.Caption = "Show Axis in Thousands"
            spreadsheetCommandGalleryItem319.CommandName = "ChartPrimaryVerticalAxisScaleThousands"
            spreadsheetCommandGalleryItem319.Description = "Display Axis with numbers represented in Thousands"
            spreadsheetCommandGalleryItem319.Hint = "Display Axis with numbers represented in Thousands"
            spreadsheetCommandGalleryItem319.ImageOptions.Image = CType((resources.GetObject("resource.Image125")), System.Drawing.Image)
            spreadsheetCommandGalleryItem320.Caption = "Show Axis in Millions"
            spreadsheetCommandGalleryItem320.CommandName = "ChartPrimaryVerticalAxisScaleMillions"
            spreadsheetCommandGalleryItem320.Description = "Display Axis with numbers represented in Millions"
            spreadsheetCommandGalleryItem320.Hint = "Display Axis with numbers represented in Millions"
            spreadsheetCommandGalleryItem320.ImageOptions.Image = CType((resources.GetObject("resource.Image126")), System.Drawing.Image)
            spreadsheetCommandGalleryItem321.Caption = "Show Axis in Billions"
            spreadsheetCommandGalleryItem321.CommandName = "ChartPrimaryVerticalAxisScaleBillions"
            spreadsheetCommandGalleryItem321.Description = "Display Axis with numbers represented in Billions"
            spreadsheetCommandGalleryItem321.Hint = "Display Axis with numbers represented in Billions"
            spreadsheetCommandGalleryItem321.ImageOptions.Image = CType((resources.GetObject("resource.Image127")), System.Drawing.Image)
            spreadsheetCommandGalleryItem322.Caption = "Show Axis in Log Scale"
            spreadsheetCommandGalleryItem322.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm"
            spreadsheetCommandGalleryItem322.Description = "Display Axis using a log 10 base scale"
            spreadsheetCommandGalleryItem322.Hint = "Display Axis using a log 10 base scale"
            spreadsheetCommandGalleryItem322.ImageOptions.Image = CType((resources.GetObject("resource.Image128")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup76.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem314, spreadsheetCommandGalleryItem315, spreadsheetCommandGalleryItem316, spreadsheetCommandGalleryItem317, spreadsheetCommandGalleryItem318, spreadsheetCommandGalleryItem319, spreadsheetCommandGalleryItem320, spreadsheetCommandGalleryItem321, spreadsheetCommandGalleryItem322})
            Me.commandBarGalleryDropDown62.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup76})
            Me.commandBarGalleryDropDown62.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown62.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown62.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown62.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown62.Manager = Nothing
            Me.commandBarGalleryDropDown62.Name = "commandBarGalleryDropDown62"
            ' 
            ' commandBarGalleryDropDown63
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown63.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown63.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup77.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
            spreadsheetCommandGalleryItem323.Caption = "None"
            spreadsheetCommandGalleryItem323.CommandName = "ChartPrimaryHorizontalGridlinesNone"
            spreadsheetCommandGalleryItem323.Description = "Do not display Horizontal Gridlines"
            spreadsheetCommandGalleryItem323.Hint = "Do not display Horizontal Gridlines"
            spreadsheetCommandGalleryItem323.ImageOptions.Image = CType((resources.GetObject("resource.Image129")), System.Drawing.Image)
            spreadsheetCommandGalleryItem324.Caption = "Major Gridlines"
            spreadsheetCommandGalleryItem324.CommandName = "ChartPrimaryHorizontalGridlinesMajor"
            spreadsheetCommandGalleryItem324.Description = "Display Horizontal Gridlines for Major units"
            spreadsheetCommandGalleryItem324.Hint = "Display Horizontal Gridlines for Major units"
            spreadsheetCommandGalleryItem324.ImageOptions.Image = CType((resources.GetObject("resource.Image130")), System.Drawing.Image)
            spreadsheetCommandGalleryItem325.Caption = "Minor Gridlines"
            spreadsheetCommandGalleryItem325.CommandName = "ChartPrimaryHorizontalGridlinesMinor"
            spreadsheetCommandGalleryItem325.Description = "Display Horizontal Gridlines for Minor units"
            spreadsheetCommandGalleryItem325.Hint = "Display Horizontal Gridlines for Minor units"
            spreadsheetCommandGalleryItem325.ImageOptions.Image = CType((resources.GetObject("resource.Image131")), System.Drawing.Image)
            spreadsheetCommandGalleryItem326.Caption = "Major & Minor Gridlines"
            spreadsheetCommandGalleryItem326.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor"
            spreadsheetCommandGalleryItem326.Description = "Display Horizontal Gridlines for Major and Minor units"
            spreadsheetCommandGalleryItem326.Hint = "Display Horizontal Gridlines for Major and Minor units"
            spreadsheetCommandGalleryItem326.ImageOptions.Image = CType((resources.GetObject("resource.Image132")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup77.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem323, spreadsheetCommandGalleryItem324, spreadsheetCommandGalleryItem325, spreadsheetCommandGalleryItem326})
            Me.commandBarGalleryDropDown63.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup77})
            Me.commandBarGalleryDropDown63.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown63.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown63.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown63.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown63.Manager = Nothing
            Me.commandBarGalleryDropDown63.Name = "commandBarGalleryDropDown63"
            ' 
            ' commandBarGalleryDropDown64
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown64.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown64.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup78.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
            spreadsheetCommandGalleryItem327.Caption = "None"
            spreadsheetCommandGalleryItem327.CommandName = "ChartPrimaryVerticalGridlinesNone"
            spreadsheetCommandGalleryItem327.Description = "Do not display Vertical Gridlines"
            spreadsheetCommandGalleryItem327.Hint = "Do not display Vertical Gridlines"
            spreadsheetCommandGalleryItem327.ImageOptions.Image = CType((resources.GetObject("resource.Image133")), System.Drawing.Image)
            spreadsheetCommandGalleryItem328.Caption = "Major Gridlines"
            spreadsheetCommandGalleryItem328.CommandName = "ChartPrimaryVerticalGridlinesMajor"
            spreadsheetCommandGalleryItem328.Description = "Display Vertical Gridlines for Major units"
            spreadsheetCommandGalleryItem328.Hint = "Display Vertical Gridlines for Major units"
            spreadsheetCommandGalleryItem328.ImageOptions.Image = CType((resources.GetObject("resource.Image134")), System.Drawing.Image)
            spreadsheetCommandGalleryItem329.Caption = "Minor Gridlines"
            spreadsheetCommandGalleryItem329.CommandName = "ChartPrimaryVerticalGridlinesMinor"
            spreadsheetCommandGalleryItem329.Description = "Display Vertical Gridlines for Minor units"
            spreadsheetCommandGalleryItem329.Hint = "Display Vertical Gridlines for Minor units"
            spreadsheetCommandGalleryItem329.ImageOptions.Image = CType((resources.GetObject("resource.Image135")), System.Drawing.Image)
            spreadsheetCommandGalleryItem330.Caption = "Major & Minor Gridlines"
            spreadsheetCommandGalleryItem330.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor"
            spreadsheetCommandGalleryItem330.Description = "Display Vertical Gridlines for Major and Minor units"
            spreadsheetCommandGalleryItem330.Hint = "Display Vertical Gridlines for Major and Minor units"
            spreadsheetCommandGalleryItem330.ImageOptions.Image = CType((resources.GetObject("resource.Image136")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup78.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem327, spreadsheetCommandGalleryItem328, spreadsheetCommandGalleryItem329, spreadsheetCommandGalleryItem330})
            Me.commandBarGalleryDropDown64.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup78})
            Me.commandBarGalleryDropDown64.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown64.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown64.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown64.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown64.Manager = Nothing
            Me.commandBarGalleryDropDown64.Name = "commandBarGalleryDropDown64"
            ' 
            ' commandBarGalleryDropDown65
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown65.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown65.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup79.CommandName = "ChartTitleCommandGroup"
            spreadsheetCommandGalleryItem331.Caption = "None"
            spreadsheetCommandGalleryItem331.CommandName = "ChartTitleNone"
            spreadsheetCommandGalleryItem331.Description = "Do not display a chart Title"
            spreadsheetCommandGalleryItem331.Hint = "Do not display a chart Title"
            spreadsheetCommandGalleryItem331.ImageOptions.Image = CType((resources.GetObject("resource.Image137")), System.Drawing.Image)
            spreadsheetCommandGalleryItem332.Caption = "Centered Overlay Title"
            spreadsheetCommandGalleryItem332.CommandName = "ChartTitleCenteredOverlay"
            spreadsheetCommandGalleryItem332.Description = "Overlay centered Title on chart without resizing chart"
            spreadsheetCommandGalleryItem332.Hint = "Overlay centered Title on chart without resizing chart"
            spreadsheetCommandGalleryItem332.ImageOptions.Image = CType((resources.GetObject("resource.Image138")), System.Drawing.Image)
            spreadsheetCommandGalleryItem333.Caption = "Above Chart"
            spreadsheetCommandGalleryItem333.CommandName = "ChartTitleAbove"
            spreadsheetCommandGalleryItem333.Description = "Display Title at top of chart area and resize chart"
            spreadsheetCommandGalleryItem333.Hint = "Display Title at top of chart area and resize chart"
            spreadsheetCommandGalleryItem333.ImageOptions.Image = CType((resources.GetObject("resource.Image139")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup79.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem331, spreadsheetCommandGalleryItem332, spreadsheetCommandGalleryItem333})
            Me.commandBarGalleryDropDown65.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup79})
            Me.commandBarGalleryDropDown65.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown65.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown65.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown65.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown65.Manager = Nothing
            Me.commandBarGalleryDropDown65.Name = "commandBarGalleryDropDown65"
            ' 
            ' commandBarGalleryDropDown66
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown66.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown66.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup80.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
            spreadsheetCommandGalleryItem334.Caption = "None"
            spreadsheetCommandGalleryItem334.CommandName = "ChartPrimaryHorizontalAxisTitleNone"
            spreadsheetCommandGalleryItem334.Description = "Do not display an Axis Title"
            spreadsheetCommandGalleryItem334.Hint = "Do not display an Axis Title"
            spreadsheetCommandGalleryItem334.ImageOptions.Image = CType((resources.GetObject("resource.Image140")), System.Drawing.Image)
            spreadsheetCommandGalleryItem335.Caption = "Title Below Axis"
            spreadsheetCommandGalleryItem335.CommandName = "ChartPrimaryHorizontalAxisTitleBelow"
            spreadsheetCommandGalleryItem335.Description = "Display Title below Horizontal Axis and resize chart"
            spreadsheetCommandGalleryItem335.Hint = "Display Title below Horizontal Axis and resize chart"
            spreadsheetCommandGalleryItem335.ImageOptions.Image = CType((resources.GetObject("resource.Image141")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup80.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem334, spreadsheetCommandGalleryItem335})
            Me.commandBarGalleryDropDown66.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup80})
            Me.commandBarGalleryDropDown66.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown66.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown66.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown66.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown66.Manager = Nothing
            Me.commandBarGalleryDropDown66.Name = "commandBarGalleryDropDown66"
            ' 
            ' commandBarGalleryDropDown67
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown67.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown67.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup81.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
            spreadsheetCommandGalleryItem336.Caption = "None"
            spreadsheetCommandGalleryItem336.CommandName = "ChartPrimaryVerticalAxisTitleNone"
            spreadsheetCommandGalleryItem336.Description = "Do not display an Axis Title"
            spreadsheetCommandGalleryItem336.Hint = "Do not display an Axis Title"
            spreadsheetCommandGalleryItem336.ImageOptions.Image = CType((resources.GetObject("resource.Image142")), System.Drawing.Image)
            spreadsheetCommandGalleryItem337.Caption = "Rotated Title"
            spreadsheetCommandGalleryItem337.CommandName = "ChartPrimaryVerticalAxisTitleRotated"
            spreadsheetCommandGalleryItem337.Description = "Display Rotated Axis Title and resize chart"
            spreadsheetCommandGalleryItem337.Hint = "Display Rotated Axis Title and resize chart"
            spreadsheetCommandGalleryItem337.ImageOptions.Image = CType((resources.GetObject("resource.Image143")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup81.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem336, spreadsheetCommandGalleryItem337})
            Me.commandBarGalleryDropDown67.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup81})
            Me.commandBarGalleryDropDown67.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown67.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown67.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown67.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown67.Manager = Nothing
            Me.commandBarGalleryDropDown67.Name = "commandBarGalleryDropDown67"
            ' 
            ' commandBarGalleryDropDown68
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown68.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown68.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup82.CommandName = "ChartLegendCommandGroup"
            spreadsheetCommandGalleryItem340.Caption = "None"
            spreadsheetCommandGalleryItem340.CommandName = "ChartLegendNone"
            spreadsheetCommandGalleryItem340.Description = "Turn off Legend"
            spreadsheetCommandGalleryItem340.Hint = "Turn off Legend"
            spreadsheetCommandGalleryItem340.ImageOptions.Image = CType((resources.GetObject("resource.Image146")), System.Drawing.Image)
            spreadsheetCommandGalleryItem341.Caption = "Show Legend at Right"
            spreadsheetCommandGalleryItem341.CommandName = "ChartLegendAtRight"
            spreadsheetCommandGalleryItem341.Description = "Show Legend and align right"
            spreadsheetCommandGalleryItem341.Hint = "Show Legend and align right"
            spreadsheetCommandGalleryItem341.ImageOptions.Image = CType((resources.GetObject("resource.Image147")), System.Drawing.Image)
            spreadsheetCommandGalleryItem342.Caption = "Show Legend at Top"
            spreadsheetCommandGalleryItem342.CommandName = "ChartLegendAtTop"
            spreadsheetCommandGalleryItem342.Description = "Show Legend and align top"
            spreadsheetCommandGalleryItem342.Hint = "Show Legend and align top"
            spreadsheetCommandGalleryItem342.ImageOptions.Image = CType((resources.GetObject("resource.Image148")), System.Drawing.Image)
            spreadsheetCommandGalleryItem343.Caption = "Show Legend at Left"
            spreadsheetCommandGalleryItem343.CommandName = "ChartLegendAtLeft"
            spreadsheetCommandGalleryItem343.Description = "Show Legend and align left"
            spreadsheetCommandGalleryItem343.Hint = "Show Legend and align left"
            spreadsheetCommandGalleryItem343.ImageOptions.Image = CType((resources.GetObject("resource.Image149")), System.Drawing.Image)
            spreadsheetCommandGalleryItem344.Caption = "Show Legend at Bottom"
            spreadsheetCommandGalleryItem344.CommandName = "ChartLegendAtBottom"
            spreadsheetCommandGalleryItem344.Description = "Show Legend and align bottom"
            spreadsheetCommandGalleryItem344.Hint = "Show Legend and align bottom"
            spreadsheetCommandGalleryItem344.ImageOptions.Image = CType((resources.GetObject("resource.Image150")), System.Drawing.Image)
            spreadsheetCommandGalleryItem345.Caption = "Overlay Legend at Right"
            spreadsheetCommandGalleryItem345.CommandName = "ChartLegendOverlayAtRight"
            spreadsheetCommandGalleryItem345.Description = "Show Legend at right of the chart without resizing"
            spreadsheetCommandGalleryItem345.Hint = "Show Legend at right of the chart without resizing"
            spreadsheetCommandGalleryItem345.ImageOptions.Image = CType((resources.GetObject("resource.Image151")), System.Drawing.Image)
            spreadsheetCommandGalleryItem346.Caption = "Overlay Legend at Left"
            spreadsheetCommandGalleryItem346.CommandName = "ChartLegendOverlayAtLeft"
            spreadsheetCommandGalleryItem346.Description = "Show Legend at left of the chart without resizing"
            spreadsheetCommandGalleryItem346.Hint = "Show Legend at left of the chart without resizing"
            spreadsheetCommandGalleryItem346.ImageOptions.Image = CType((resources.GetObject("resource.Image152")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup82.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem340, spreadsheetCommandGalleryItem341, spreadsheetCommandGalleryItem342, spreadsheetCommandGalleryItem343, spreadsheetCommandGalleryItem344, spreadsheetCommandGalleryItem345, spreadsheetCommandGalleryItem346})
            Me.commandBarGalleryDropDown68.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup82})
            Me.commandBarGalleryDropDown68.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown68.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown68.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown68.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown68.Manager = Nothing
            Me.commandBarGalleryDropDown68.Name = "commandBarGalleryDropDown68"
            ' 
            ' commandBarGalleryDropDown69
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown69.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown69.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup83.CommandName = "ChartDataLabelsCommandGroup"
            spreadsheetCommandGalleryItem347.Caption = "None"
            spreadsheetCommandGalleryItem347.CommandName = "ChartDataLabelsNone"
            spreadsheetCommandGalleryItem347.Description = "Turn off Data Labels for selection"
            spreadsheetCommandGalleryItem347.Hint = "Turn off Data Labels for selection"
            spreadsheetCommandGalleryItem347.ImageOptions.Image = CType((resources.GetObject("resource.Image153")), System.Drawing.Image)
            spreadsheetCommandGalleryItem348.Caption = "Show"
            spreadsheetCommandGalleryItem348.CommandName = "ChartDataLabelsDefault"
            spreadsheetCommandGalleryItem348.Description = "Turn on Data Labels for selection"
            spreadsheetCommandGalleryItem348.Hint = "Turn on Data Labels for selection"
            spreadsheetCommandGalleryItem348.ImageOptions.Image = CType((resources.GetObject("resource.Image154")), System.Drawing.Image)
            spreadsheetCommandGalleryItem349.Caption = "Center"
            spreadsheetCommandGalleryItem349.CommandName = "ChartDataLabelsCenter"
            spreadsheetCommandGalleryItem349.Description = "Display Data Labels and position centered on the data point(s)"
            spreadsheetCommandGalleryItem349.Hint = "Display Data Labels and position centered on the data point(s)"
            spreadsheetCommandGalleryItem349.ImageOptions.Image = CType((resources.GetObject("resource.Image155")), System.Drawing.Image)
            spreadsheetCommandGalleryItem350.Caption = "Inside End"
            spreadsheetCommandGalleryItem350.CommandName = "ChartDataLabelsInsideEnd"
            spreadsheetCommandGalleryItem350.Description = "Display Data Labels and position inside the end of data point(s)"
            spreadsheetCommandGalleryItem350.Hint = "Display Data Labels and position inside the end of data point(s)"
            spreadsheetCommandGalleryItem350.ImageOptions.Image = CType((resources.GetObject("resource.Image156")), System.Drawing.Image)
            spreadsheetCommandGalleryItem351.Caption = "Inside Base"
            spreadsheetCommandGalleryItem351.CommandName = "ChartDataLabelsInsideBase"
            spreadsheetCommandGalleryItem351.Description = "Display Data Labels and position inside the base of data point(s)"
            spreadsheetCommandGalleryItem351.Hint = "Display Data Labels and position inside the base of data point(s)"
            spreadsheetCommandGalleryItem351.ImageOptions.Image = CType((resources.GetObject("resource.Image157")), System.Drawing.Image)
            spreadsheetCommandGalleryItem352.Caption = "Outside End"
            spreadsheetCommandGalleryItem352.CommandName = "ChartDataLabelsOutsideEnd"
            spreadsheetCommandGalleryItem352.Description = "Display Data Labels and position outside the end of data point(s)"
            spreadsheetCommandGalleryItem352.Hint = "Display Data Labels and position outside the end of data point(s)"
            spreadsheetCommandGalleryItem352.ImageOptions.Image = CType((resources.GetObject("resource.Image158")), System.Drawing.Image)
            spreadsheetCommandGalleryItem353.Caption = "Best Fit"
            spreadsheetCommandGalleryItem353.CommandName = "ChartDataLabelsBestFit"
            spreadsheetCommandGalleryItem353.Description = "Display Data Labels and position with Best Fit"
            spreadsheetCommandGalleryItem353.Hint = "Display Data Labels and position with Best Fit"
            spreadsheetCommandGalleryItem353.ImageOptions.Image = CType((resources.GetObject("resource.Image159")), System.Drawing.Image)
            spreadsheetCommandGalleryItem354.Caption = "Left"
            spreadsheetCommandGalleryItem354.CommandName = "ChartDataLabelsLeft"
            spreadsheetCommandGalleryItem354.Description = "Display Data Labels and position left of the data point(s)"
            spreadsheetCommandGalleryItem354.Hint = "Display Data Labels and position left of the data point(s)"
            spreadsheetCommandGalleryItem354.ImageOptions.Image = CType((resources.GetObject("resource.Image160")), System.Drawing.Image)
            spreadsheetCommandGalleryItem355.Caption = "Right"
            spreadsheetCommandGalleryItem355.CommandName = "ChartDataLabelsRight"
            spreadsheetCommandGalleryItem355.Description = "Display Data Labels and position right of the data point(s)"
            spreadsheetCommandGalleryItem355.Hint = "Display Data Labels and position right of the data point(s)"
            spreadsheetCommandGalleryItem355.ImageOptions.Image = CType((resources.GetObject("resource.Image161")), System.Drawing.Image)
            spreadsheetCommandGalleryItem356.Caption = "Above"
            spreadsheetCommandGalleryItem356.CommandName = "ChartDataLabelsAbove"
            spreadsheetCommandGalleryItem356.Description = "Display Data Labels and position above data point(s)"
            spreadsheetCommandGalleryItem356.Hint = "Display Data Labels and position above data point(s)"
            spreadsheetCommandGalleryItem356.ImageOptions.Image = CType((resources.GetObject("resource.Image162")), System.Drawing.Image)
            spreadsheetCommandGalleryItem357.Caption = "Below"
            spreadsheetCommandGalleryItem357.CommandName = "ChartDataLabelsBelow"
            spreadsheetCommandGalleryItem357.Description = "Display Data Labels and position below data point(s)"
            spreadsheetCommandGalleryItem357.Hint = "Display Data Labels and position below data point(s)"
            spreadsheetCommandGalleryItem357.ImageOptions.Image = CType((resources.GetObject("resource.Image163")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup83.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem347, spreadsheetCommandGalleryItem348, spreadsheetCommandGalleryItem349, spreadsheetCommandGalleryItem350, spreadsheetCommandGalleryItem351, spreadsheetCommandGalleryItem352, spreadsheetCommandGalleryItem353, spreadsheetCommandGalleryItem354, spreadsheetCommandGalleryItem355, spreadsheetCommandGalleryItem356, spreadsheetCommandGalleryItem357})
            Me.commandBarGalleryDropDown69.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup83})
            Me.commandBarGalleryDropDown69.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown69.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown69.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown69.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown69.Manager = Nothing
            Me.commandBarGalleryDropDown69.Name = "commandBarGalleryDropDown69"
            ' 
            ' commandBarGalleryDropDown70
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown70.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown70.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup84.CommandName = "ChartLinesCommandGroup"
            spreadsheetCommandGalleryItem358.Caption = "None"
            spreadsheetCommandGalleryItem358.CommandName = "ChartLinesNone"
            spreadsheetCommandGalleryItem358.Description = "Do not show Drop Lines, High-Low Lines or Series Lines"
            spreadsheetCommandGalleryItem358.Hint = "Do not show Drop Lines, High-Low Lines or Series Lines"
            spreadsheetCommandGalleryItem358.ImageOptions.Image = CType((resources.GetObject("resource.Image164")), System.Drawing.Image)
            spreadsheetCommandGalleryItem359.Caption = "Drop Lines"
            spreadsheetCommandGalleryItem359.CommandName = "ChartShowDropLines"
            spreadsheetCommandGalleryItem359.Description = "Show Drop Lines on an Area or Line Chart"
            spreadsheetCommandGalleryItem359.Hint = "Show Drop Lines on an Area or Line Chart"
            spreadsheetCommandGalleryItem359.ImageOptions.Image = CType((resources.GetObject("resource.Image165")), System.Drawing.Image)
            spreadsheetCommandGalleryItem360.Caption = "High-Low Lines"
            spreadsheetCommandGalleryItem360.CommandName = "ChartShowHighLowLines"
            spreadsheetCommandGalleryItem360.Description = "Show High-Low Lines on a 2D Line Chart"
            spreadsheetCommandGalleryItem360.Hint = "Show High-Low Lines on a 2D Line Chart"
            spreadsheetCommandGalleryItem360.ImageOptions.Image = CType((resources.GetObject("resource.Image166")), System.Drawing.Image)
            spreadsheetCommandGalleryItem361.Caption = "Drop and High-Low Lines"
            spreadsheetCommandGalleryItem361.CommandName = "ChartShowDropLinesAndHighLowLines"
            spreadsheetCommandGalleryItem361.Description = "Show Drop Lines and High-Low Lines on a 2D Line Chart"
            spreadsheetCommandGalleryItem361.Hint = "Show Drop Lines and High-Low Lines on a 2D Line Chart"
            spreadsheetCommandGalleryItem361.ImageOptions.Image = CType((resources.GetObject("resource.Image167")), System.Drawing.Image)
            spreadsheetCommandGalleryItem362.Caption = "Series Lines"
            spreadsheetCommandGalleryItem362.CommandName = "ChartShowSeriesLines"
            spreadsheetCommandGalleryItem362.Description = "Show Series Lines on a 2D stacked Bar/Column Pie or Pie or Bar of Pie Chart"
            spreadsheetCommandGalleryItem362.Hint = "Show Series Lines on a 2D stacked Bar/Column Pie or Pie or Bar of Pie Chart"
            spreadsheetCommandGalleryItem362.ImageOptions.Image = CType((resources.GetObject("resource.Image168")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup84.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem358, spreadsheetCommandGalleryItem359, spreadsheetCommandGalleryItem360, spreadsheetCommandGalleryItem361, spreadsheetCommandGalleryItem362})
            Me.commandBarGalleryDropDown70.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup84})
            Me.commandBarGalleryDropDown70.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown70.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown70.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown70.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown70.Manager = Nothing
            Me.commandBarGalleryDropDown70.Name = "commandBarGalleryDropDown70"
            ' 
            ' commandBarGalleryDropDown71
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown71.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown71.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup85.CommandName = "ChartUpDownBarsCommandGroup"
            spreadsheetCommandGalleryItem363.Caption = "None"
            spreadsheetCommandGalleryItem363.CommandName = "ChartHideUpDownBars"
            spreadsheetCommandGalleryItem363.Description = "Do not show Up/Down Bars"
            spreadsheetCommandGalleryItem363.Hint = "Do not show Up/Down Bars"
            spreadsheetCommandGalleryItem363.ImageOptions.Image = CType((resources.GetObject("resource.Image169")), System.Drawing.Image)
            spreadsheetCommandGalleryItem364.Caption = "Up/Down Bars"
            spreadsheetCommandGalleryItem364.CommandName = "ChartShowUpDownBars"
            spreadsheetCommandGalleryItem364.Description = "Show Up/Down Bars on a Line Chart"
            spreadsheetCommandGalleryItem364.Hint = "Show Up/Down Bars on a Line Chart"
            spreadsheetCommandGalleryItem364.ImageOptions.Image = CType((resources.GetObject("resource.Image170")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup85.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem363, spreadsheetCommandGalleryItem364})
            Me.commandBarGalleryDropDown71.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup85})
            Me.commandBarGalleryDropDown71.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown71.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown71.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown71.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown71.Manager = Nothing
            Me.commandBarGalleryDropDown71.Name = "commandBarGalleryDropDown71"
            ' 
            ' commandBarGalleryDropDown72
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown72.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown72.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup86.CommandName = "ChartErrorBarsCommandGroup"
            spreadsheetCommandGalleryItem365.Caption = "None"
            spreadsheetCommandGalleryItem365.CommandName = "ChartErrorBarsNone"
            spreadsheetCommandGalleryItem365.Description = "Removes the Error Bars for the selected series or all Error Bars if none are sele" & "cted"
            spreadsheetCommandGalleryItem365.Hint = "Removes the Error Bars for the selected series or all Error Bars if none are sele" & "cted"
            spreadsheetCommandGalleryItem365.ImageOptions.Image = CType((resources.GetObject("resource.Image171")), System.Drawing.Image)
            spreadsheetCommandGalleryItem366.Caption = "Error Bars with Standard Error"
            spreadsheetCommandGalleryItem366.CommandName = "ChartErrorBarsStandardError"
            spreadsheetCommandGalleryItem366.Description = "Displays Error Bars for the selected chart series using Standard Error"
            spreadsheetCommandGalleryItem366.Hint = "Displays Error Bars for the selected chart series using Standard Error"
            spreadsheetCommandGalleryItem366.ImageOptions.Image = CType((resources.GetObject("resource.Image172")), System.Drawing.Image)
            spreadsheetCommandGalleryItem367.Caption = "Error Bars with Percentage"
            spreadsheetCommandGalleryItem367.CommandName = "ChartErrorBarsPercentage"
            spreadsheetCommandGalleryItem367.Description = "Displays Error Bars for the selected chart series with 5% value"
            spreadsheetCommandGalleryItem367.Hint = "Displays Error Bars for the selected chart series with 5% value"
            spreadsheetCommandGalleryItem367.ImageOptions.Image = CType((resources.GetObject("resource.Image173")), System.Drawing.Image)
            spreadsheetCommandGalleryItem368.Caption = "Error Bars with Standard Deviation"
            spreadsheetCommandGalleryItem368.CommandName = "ChartErrorBarsStandardDeviation"
            spreadsheetCommandGalleryItem368.Description = "Displays Error Bars for the selected chart series with 1 standard deviation"
            spreadsheetCommandGalleryItem368.Hint = "Displays Error Bars for the selected chart series with 1 standard deviation"
            spreadsheetCommandGalleryItem368.ImageOptions.Image = CType((resources.GetObject("resource.Image174")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup86.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem365, spreadsheetCommandGalleryItem366, spreadsheetCommandGalleryItem367, spreadsheetCommandGalleryItem368})
            Me.commandBarGalleryDropDown72.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup86})
            Me.commandBarGalleryDropDown72.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown72.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown72.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown72.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown72.Manager = Nothing
            Me.commandBarGalleryDropDown72.Name = "commandBarGalleryDropDown72"
            ' 
            ' commandBarGalleryDropDown26
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown26.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup87.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup"
            spreadsheetCommandGalleryItem369.CommandName = "ConditionalFormattingDataBarGradientBlue"
            spreadsheetCommandGalleryItem369.ImageOptions.Image = CType((resources.GetObject("resource.Image175")), System.Drawing.Image)
            spreadsheetCommandGalleryItem370.CommandName = "ConditionalFormattingDataBarGradientGreen"
            spreadsheetCommandGalleryItem370.ImageOptions.Image = CType((resources.GetObject("resource.Image176")), System.Drawing.Image)
            spreadsheetCommandGalleryItem371.CommandName = "ConditionalFormattingDataBarGradientRed"
            spreadsheetCommandGalleryItem371.ImageOptions.Image = CType((resources.GetObject("resource.Image177")), System.Drawing.Image)
            spreadsheetCommandGalleryItem372.CommandName = "ConditionalFormattingDataBarGradientOrange"
            spreadsheetCommandGalleryItem372.ImageOptions.Image = CType((resources.GetObject("resource.Image178")), System.Drawing.Image)
            spreadsheetCommandGalleryItem373.CommandName = "ConditionalFormattingDataBarGradientLightBlue"
            spreadsheetCommandGalleryItem373.ImageOptions.Image = CType((resources.GetObject("resource.Image179")), System.Drawing.Image)
            spreadsheetCommandGalleryItem374.CommandName = "ConditionalFormattingDataBarGradientPurple"
            spreadsheetCommandGalleryItem374.ImageOptions.Image = CType((resources.GetObject("resource.Image180")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup87.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem369, spreadsheetCommandGalleryItem370, spreadsheetCommandGalleryItem371, spreadsheetCommandGalleryItem372, spreadsheetCommandGalleryItem373, spreadsheetCommandGalleryItem374})
            spreadsheetCommandGalleryItemGroup88.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup"
            spreadsheetCommandGalleryItem375.CommandName = "ConditionalFormattingDataBarSolidBlue"
            spreadsheetCommandGalleryItem375.ImageOptions.Image = CType((resources.GetObject("resource.Image181")), System.Drawing.Image)
            spreadsheetCommandGalleryItem376.CommandName = "ConditionalFormattingDataBarSolidGreen"
            spreadsheetCommandGalleryItem376.ImageOptions.Image = CType((resources.GetObject("resource.Image182")), System.Drawing.Image)
            spreadsheetCommandGalleryItem377.CommandName = "ConditionalFormattingDataBarSolidRed"
            spreadsheetCommandGalleryItem377.ImageOptions.Image = CType((resources.GetObject("resource.Image183")), System.Drawing.Image)
            spreadsheetCommandGalleryItem378.CommandName = "ConditionalFormattingDataBarSolidOrange"
            spreadsheetCommandGalleryItem378.ImageOptions.Image = CType((resources.GetObject("resource.Image184")), System.Drawing.Image)
            spreadsheetCommandGalleryItem379.CommandName = "ConditionalFormattingDataBarSolidLightBlue"
            spreadsheetCommandGalleryItem379.ImageOptions.Image = CType((resources.GetObject("resource.Image185")), System.Drawing.Image)
            spreadsheetCommandGalleryItem380.CommandName = "ConditionalFormattingDataBarSolidPurple"
            spreadsheetCommandGalleryItem380.ImageOptions.Image = CType((resources.GetObject("resource.Image186")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup88.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem375, spreadsheetCommandGalleryItem376, spreadsheetCommandGalleryItem377, spreadsheetCommandGalleryItem378, spreadsheetCommandGalleryItem379, spreadsheetCommandGalleryItem380})
            Me.commandBarGalleryDropDown26.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup87, spreadsheetCommandGalleryItemGroup88})
            Me.commandBarGalleryDropDown26.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown26.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown26.Manager = Nothing
            Me.commandBarGalleryDropDown26.Name = "commandBarGalleryDropDown26"
            ' 
            ' commandBarGalleryDropDown25
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown25.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown25.Gallery.ColumnCount = 1
            Me.commandBarGalleryDropDown25.Gallery.DrawImageBackground = False
            galleryItem1.Tag = DevExpress.Export.Xl.XlBorderLineStyle.None
            galleryItem2.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thin
            galleryItem3.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Hair
            galleryItem4.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dotted
            galleryItem5.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dashed
            galleryItem6.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDot
            galleryItem7.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDotDot
            galleryItem8.Tag = DevExpress.Export.Xl.XlBorderLineStyle.[Double]
            galleryItem9.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Medium
            galleryItem10.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashed
            galleryItem11.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDot
            galleryItem12.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDotDot
            galleryItem13.Tag = DevExpress.Export.Xl.XlBorderLineStyle.SlantDashDot
            galleryItem14.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thick
            galleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6, galleryItem7, galleryItem8, galleryItem9, galleryItem10, galleryItem11, galleryItem12, galleryItem13, galleryItem14})
            Me.commandBarGalleryDropDown25.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup2})
            Me.commandBarGalleryDropDown25.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.commandBarGalleryDropDown25.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown25.Gallery.ItemSize = New System.Drawing.Size(136, 26)
            Me.commandBarGalleryDropDown25.Gallery.RowCount = 14
            Me.commandBarGalleryDropDown25.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown25.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown25.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown25.Manager = Nothing
            Me.commandBarGalleryDropDown25.Name = "commandBarGalleryDropDown25"
            ' 
            ' commandBarGalleryDropDown27
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown27.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup89.CommandName = "ConditionalFormattingColorScalesCommandGroup"
            spreadsheetCommandGalleryItem381.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
            spreadsheetCommandGalleryItem381.ImageOptions.Image = CType((resources.GetObject("resource.Image187")), System.Drawing.Image)
            spreadsheetCommandGalleryItem382.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
            spreadsheetCommandGalleryItem382.ImageOptions.Image = CType((resources.GetObject("resource.Image188")), System.Drawing.Image)
            spreadsheetCommandGalleryItem383.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
            spreadsheetCommandGalleryItem383.ImageOptions.Image = CType((resources.GetObject("resource.Image189")), System.Drawing.Image)
            spreadsheetCommandGalleryItem384.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
            spreadsheetCommandGalleryItem384.ImageOptions.Image = CType((resources.GetObject("resource.Image190")), System.Drawing.Image)
            spreadsheetCommandGalleryItem385.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
            spreadsheetCommandGalleryItem385.ImageOptions.Image = CType((resources.GetObject("resource.Image191")), System.Drawing.Image)
            spreadsheetCommandGalleryItem386.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
            spreadsheetCommandGalleryItem386.ImageOptions.Image = CType((resources.GetObject("resource.Image192")), System.Drawing.Image)
            spreadsheetCommandGalleryItem387.CommandName = "ConditionalFormattingColorScaleWhiteRed"
            spreadsheetCommandGalleryItem387.ImageOptions.Image = CType((resources.GetObject("resource.Image193")), System.Drawing.Image)
            spreadsheetCommandGalleryItem388.CommandName = "ConditionalFormattingColorScaleRedWhite"
            spreadsheetCommandGalleryItem388.ImageOptions.Image = CType((resources.GetObject("resource.Image194")), System.Drawing.Image)
            spreadsheetCommandGalleryItem389.CommandName = "ConditionalFormattingColorScaleGreenWhite"
            spreadsheetCommandGalleryItem389.ImageOptions.Image = CType((resources.GetObject("resource.Image195")), System.Drawing.Image)
            spreadsheetCommandGalleryItem390.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
            spreadsheetCommandGalleryItem390.ImageOptions.Image = CType((resources.GetObject("resource.Image196")), System.Drawing.Image)
            spreadsheetCommandGalleryItem391.CommandName = "ConditionalFormattingColorScaleGreenYellow"
            spreadsheetCommandGalleryItem391.ImageOptions.Image = CType((resources.GetObject("resource.Image197")), System.Drawing.Image)
            spreadsheetCommandGalleryItem392.CommandName = "ConditionalFormattingColorScaleYellowGreen"
            spreadsheetCommandGalleryItem392.ImageOptions.Image = CType((resources.GetObject("resource.Image198")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup89.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem381, spreadsheetCommandGalleryItem382, spreadsheetCommandGalleryItem383, spreadsheetCommandGalleryItem384, spreadsheetCommandGalleryItem385, spreadsheetCommandGalleryItem386, spreadsheetCommandGalleryItem387, spreadsheetCommandGalleryItem388, spreadsheetCommandGalleryItem389, spreadsheetCommandGalleryItem390, spreadsheetCommandGalleryItem391, spreadsheetCommandGalleryItem392})
            Me.commandBarGalleryDropDown27.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup89})
            Me.commandBarGalleryDropDown27.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown27.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown27.Manager = Nothing
            Me.commandBarGalleryDropDown27.Name = "commandBarGalleryDropDown27"
            ' 
            ' commandBarGalleryDropDown28
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown28.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup90.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
            spreadsheetCommandGalleryItem393.CommandName = "ConditionalFormattingIconSetArrows3Colored"
            spreadsheetCommandGalleryItem393.ImageOptions.Image = CType((resources.GetObject("resource.Image199")), System.Drawing.Image)
            spreadsheetCommandGalleryItem394.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
            spreadsheetCommandGalleryItem394.ImageOptions.Image = CType((resources.GetObject("resource.Image200")), System.Drawing.Image)
            spreadsheetCommandGalleryItem395.CommandName = "ConditionalFormattingIconSetArrows4Colored"
            spreadsheetCommandGalleryItem395.ImageOptions.Image = CType((resources.GetObject("resource.Image201")), System.Drawing.Image)
            spreadsheetCommandGalleryItem396.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
            spreadsheetCommandGalleryItem396.ImageOptions.Image = CType((resources.GetObject("resource.Image202")), System.Drawing.Image)
            spreadsheetCommandGalleryItem397.CommandName = "ConditionalFormattingIconSetArrows5Colored"
            spreadsheetCommandGalleryItem397.ImageOptions.Image = CType((resources.GetObject("resource.Image203")), System.Drawing.Image)
            spreadsheetCommandGalleryItem398.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
            spreadsheetCommandGalleryItem398.ImageOptions.Image = CType((resources.GetObject("resource.Image204")), System.Drawing.Image)
            spreadsheetCommandGalleryItem399.CommandName = "ConditionalFormattingIconSetTriangles3"
            spreadsheetCommandGalleryItem399.ImageOptions.Image = CType((resources.GetObject("resource.Image205")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup90.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem393, spreadsheetCommandGalleryItem394, spreadsheetCommandGalleryItem395, spreadsheetCommandGalleryItem396, spreadsheetCommandGalleryItem397, spreadsheetCommandGalleryItem398, spreadsheetCommandGalleryItem399})
            spreadsheetCommandGalleryItemGroup91.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
            spreadsheetCommandGalleryItem400.CommandName = "ConditionalFormattingIconSetTrafficLights3"
            spreadsheetCommandGalleryItem400.ImageOptions.Image = CType((resources.GetObject("resource.Image206")), System.Drawing.Image)
            spreadsheetCommandGalleryItem401.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
            spreadsheetCommandGalleryItem401.ImageOptions.Image = CType((resources.GetObject("resource.Image207")), System.Drawing.Image)
            spreadsheetCommandGalleryItem402.CommandName = "ConditionalFormattingIconSetTrafficLights4"
            spreadsheetCommandGalleryItem402.ImageOptions.Image = CType((resources.GetObject("resource.Image208")), System.Drawing.Image)
            spreadsheetCommandGalleryItem403.CommandName = "ConditionalFormattingIconSetSigns3"
            spreadsheetCommandGalleryItem403.ImageOptions.Image = CType((resources.GetObject("resource.Image209")), System.Drawing.Image)
            spreadsheetCommandGalleryItem404.CommandName = "ConditionalFormattingIconSetRedToBlack"
            spreadsheetCommandGalleryItem404.ImageOptions.Image = CType((resources.GetObject("resource.Image210")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup91.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem400, spreadsheetCommandGalleryItem401, spreadsheetCommandGalleryItem402, spreadsheetCommandGalleryItem403, spreadsheetCommandGalleryItem404})
            spreadsheetCommandGalleryItemGroup92.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
            spreadsheetCommandGalleryItem405.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
            spreadsheetCommandGalleryItem405.ImageOptions.Image = CType((resources.GetObject("resource.Image211")), System.Drawing.Image)
            spreadsheetCommandGalleryItem406.CommandName = "ConditionalFormattingIconSetSymbols3"
            spreadsheetCommandGalleryItem406.ImageOptions.Image = CType((resources.GetObject("resource.Image212")), System.Drawing.Image)
            spreadsheetCommandGalleryItem407.CommandName = "ConditionalFormattingIconSetFlags3"
            spreadsheetCommandGalleryItem407.ImageOptions.Image = CType((resources.GetObject("resource.Image213")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup92.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem405, spreadsheetCommandGalleryItem406, spreadsheetCommandGalleryItem407})
            spreadsheetCommandGalleryItemGroup93.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
            spreadsheetCommandGalleryItem408.CommandName = "ConditionalFormattingIconSetStars3"
            spreadsheetCommandGalleryItem408.ImageOptions.Image = CType((resources.GetObject("resource.Image214")), System.Drawing.Image)
            spreadsheetCommandGalleryItem409.CommandName = "ConditionalFormattingIconSetRatings4"
            spreadsheetCommandGalleryItem409.ImageOptions.Image = CType((resources.GetObject("resource.Image215")), System.Drawing.Image)
            spreadsheetCommandGalleryItem410.CommandName = "ConditionalFormattingIconSetRatings5"
            spreadsheetCommandGalleryItem410.ImageOptions.Image = CType((resources.GetObject("resource.Image216")), System.Drawing.Image)
            spreadsheetCommandGalleryItem411.CommandName = "ConditionalFormattingIconSetQuarters5"
            spreadsheetCommandGalleryItem411.ImageOptions.Image = CType((resources.GetObject("resource.Image217")), System.Drawing.Image)
            spreadsheetCommandGalleryItem412.CommandName = "ConditionalFormattingIconSetBoxes5"
            spreadsheetCommandGalleryItem412.ImageOptions.Image = CType((resources.GetObject("resource.Image218")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup93.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem408, spreadsheetCommandGalleryItem409, spreadsheetCommandGalleryItem410, spreadsheetCommandGalleryItem411, spreadsheetCommandGalleryItem412})
            Me.commandBarGalleryDropDown28.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup90, spreadsheetCommandGalleryItemGroup91, spreadsheetCommandGalleryItemGroup92, spreadsheetCommandGalleryItemGroup93})
            Me.commandBarGalleryDropDown28.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown28.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown28.Manager = Nothing
            Me.commandBarGalleryDropDown28.Name = "commandBarGalleryDropDown28"
            ' 
            ' commandBarGalleryDropDown29
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown29.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown29.Gallery.ColumnCount = 7
            Me.commandBarGalleryDropDown29.Gallery.DrawImageBackground = False
            Me.commandBarGalleryDropDown29.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown29.Gallery.ItemSize = New System.Drawing.Size(73, 58)
            Me.commandBarGalleryDropDown29.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown29.Manager = Nothing
            Me.commandBarGalleryDropDown29.Name = "commandBarGalleryDropDown29"
            ' 
            ' commandBarGalleryDropDown30
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown30.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup94.CommandName = "InsertChartColumn2DCommandGroup"
            spreadsheetCommandGalleryItem413.CommandName = "InsertChartColumnClustered2D"
            spreadsheetCommandGalleryItem413.ImageOptions.Image = CType((resources.GetObject("resource.Image219")), System.Drawing.Image)
            spreadsheetCommandGalleryItem414.CommandName = "InsertChartColumnStacked2D"
            spreadsheetCommandGalleryItem414.ImageOptions.Image = CType((resources.GetObject("resource.Image220")), System.Drawing.Image)
            spreadsheetCommandGalleryItem415.CommandName = "InsertChartColumnPercentStacked2D"
            spreadsheetCommandGalleryItem415.ImageOptions.Image = CType((resources.GetObject("resource.Image221")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup94.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem413, spreadsheetCommandGalleryItem414, spreadsheetCommandGalleryItem415})
            spreadsheetCommandGalleryItemGroup95.CommandName = "InsertChartColumn3DCommandGroup"
            spreadsheetCommandGalleryItem416.CommandName = "InsertChartColumnClustered3D"
            spreadsheetCommandGalleryItem416.ImageOptions.Image = CType((resources.GetObject("resource.Image222")), System.Drawing.Image)
            spreadsheetCommandGalleryItem417.CommandName = "InsertChartColumnStacked3D"
            spreadsheetCommandGalleryItem417.ImageOptions.Image = CType((resources.GetObject("resource.Image223")), System.Drawing.Image)
            spreadsheetCommandGalleryItem418.CommandName = "InsertChartColumnPercentStacked3D"
            spreadsheetCommandGalleryItem418.ImageOptions.Image = CType((resources.GetObject("resource.Image224")), System.Drawing.Image)
            spreadsheetCommandGalleryItem419.CommandName = "InsertChartColumn3D"
            spreadsheetCommandGalleryItem419.ImageOptions.Image = CType((resources.GetObject("resource.Image225")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup95.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem416, spreadsheetCommandGalleryItem417, spreadsheetCommandGalleryItem418, spreadsheetCommandGalleryItem419})
            spreadsheetCommandGalleryItemGroup96.CommandName = "InsertChartCylinderCommandGroup"
            spreadsheetCommandGalleryItem420.CommandName = "InsertChartCylinderClustered"
            spreadsheetCommandGalleryItem420.ImageOptions.Image = CType((resources.GetObject("resource.Image226")), System.Drawing.Image)
            spreadsheetCommandGalleryItem421.CommandName = "InsertChartCylinderStacked"
            spreadsheetCommandGalleryItem421.ImageOptions.Image = CType((resources.GetObject("resource.Image227")), System.Drawing.Image)
            spreadsheetCommandGalleryItem422.CommandName = "InsertChartCylinderPercentStacked"
            spreadsheetCommandGalleryItem422.ImageOptions.Image = CType((resources.GetObject("resource.Image228")), System.Drawing.Image)
            spreadsheetCommandGalleryItem423.CommandName = "InsertChartCylinder"
            spreadsheetCommandGalleryItem423.ImageOptions.Image = CType((resources.GetObject("resource.Image229")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup96.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem420, spreadsheetCommandGalleryItem421, spreadsheetCommandGalleryItem422, spreadsheetCommandGalleryItem423})
            spreadsheetCommandGalleryItemGroup97.CommandName = "InsertChartConeCommandGroup"
            spreadsheetCommandGalleryItem424.CommandName = "InsertChartConeClustered"
            spreadsheetCommandGalleryItem424.ImageOptions.Image = CType((resources.GetObject("resource.Image230")), System.Drawing.Image)
            spreadsheetCommandGalleryItem425.CommandName = "InsertChartConeStacked"
            spreadsheetCommandGalleryItem425.ImageOptions.Image = CType((resources.GetObject("resource.Image231")), System.Drawing.Image)
            spreadsheetCommandGalleryItem426.CommandName = "InsertChartConePercentStacked"
            spreadsheetCommandGalleryItem426.ImageOptions.Image = CType((resources.GetObject("resource.Image232")), System.Drawing.Image)
            spreadsheetCommandGalleryItem427.CommandName = "InsertChartCone"
            spreadsheetCommandGalleryItem427.ImageOptions.Image = CType((resources.GetObject("resource.Image233")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup97.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem424, spreadsheetCommandGalleryItem425, spreadsheetCommandGalleryItem426, spreadsheetCommandGalleryItem427})
            spreadsheetCommandGalleryItemGroup98.CommandName = "InsertChartPyramidCommandGroup"
            spreadsheetCommandGalleryItem428.CommandName = "InsertChartPyramidClustered"
            spreadsheetCommandGalleryItem428.ImageOptions.Image = CType((resources.GetObject("resource.Image234")), System.Drawing.Image)
            spreadsheetCommandGalleryItem429.CommandName = "InsertChartPyramidStacked"
            spreadsheetCommandGalleryItem429.ImageOptions.Image = CType((resources.GetObject("resource.Image235")), System.Drawing.Image)
            spreadsheetCommandGalleryItem430.CommandName = "InsertChartPyramidPercentStacked"
            spreadsheetCommandGalleryItem430.ImageOptions.Image = CType((resources.GetObject("resource.Image236")), System.Drawing.Image)
            spreadsheetCommandGalleryItem431.CommandName = "InsertChartPyramid"
            spreadsheetCommandGalleryItem431.ImageOptions.Image = CType((resources.GetObject("resource.Image237")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup98.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem428, spreadsheetCommandGalleryItem429, spreadsheetCommandGalleryItem430, spreadsheetCommandGalleryItem431})
            Me.commandBarGalleryDropDown30.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup94, spreadsheetCommandGalleryItemGroup95, spreadsheetCommandGalleryItemGroup96, spreadsheetCommandGalleryItemGroup97, spreadsheetCommandGalleryItemGroup98})
            Me.commandBarGalleryDropDown30.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown30.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown30.Manager = Nothing
            Me.commandBarGalleryDropDown30.Name = "commandBarGalleryDropDown30"
            ' 
            ' commandBarGalleryDropDown31
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown31.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup99.CommandName = "InsertChartLine2DCommandGroup"
            spreadsheetCommandGalleryItem432.CommandName = "InsertChartLine"
            spreadsheetCommandGalleryItem432.ImageOptions.Image = CType((resources.GetObject("resource.Image238")), System.Drawing.Image)
            spreadsheetCommandGalleryItem433.CommandName = "InsertChartStackedLine"
            spreadsheetCommandGalleryItem433.ImageOptions.Image = CType((resources.GetObject("resource.Image239")), System.Drawing.Image)
            spreadsheetCommandGalleryItem434.CommandName = "InsertChartPercentStackedLine"
            spreadsheetCommandGalleryItem434.ImageOptions.Image = CType((resources.GetObject("resource.Image240")), System.Drawing.Image)
            spreadsheetCommandGalleryItem435.CommandName = "InsertChartLineWithMarkers"
            spreadsheetCommandGalleryItem435.ImageOptions.Image = CType((resources.GetObject("resource.Image241")), System.Drawing.Image)
            spreadsheetCommandGalleryItem436.CommandName = "InsertChartStackedLineWithMarkers"
            spreadsheetCommandGalleryItem436.ImageOptions.Image = CType((resources.GetObject("resource.Image242")), System.Drawing.Image)
            spreadsheetCommandGalleryItem437.CommandName = "InsertChartPercentStackedLineWithMarkers"
            spreadsheetCommandGalleryItem437.ImageOptions.Image = CType((resources.GetObject("resource.Image243")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup99.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem432, spreadsheetCommandGalleryItem433, spreadsheetCommandGalleryItem434, spreadsheetCommandGalleryItem435, spreadsheetCommandGalleryItem436, spreadsheetCommandGalleryItem437})
            spreadsheetCommandGalleryItemGroup100.CommandName = "InsertChartLine3DCommandGroup"
            spreadsheetCommandGalleryItem438.CommandName = "InsertChartLine3D"
            spreadsheetCommandGalleryItem438.ImageOptions.Image = CType((resources.GetObject("resource.Image244")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup100.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem438})
            Me.commandBarGalleryDropDown31.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup99, spreadsheetCommandGalleryItemGroup100})
            Me.commandBarGalleryDropDown31.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown31.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown31.Manager = Nothing
            Me.commandBarGalleryDropDown31.Name = "commandBarGalleryDropDown31"
            ' 
            ' commandBarGalleryDropDown32
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown32.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup101.CommandName = "InsertChartPie2DCommandGroup"
            spreadsheetCommandGalleryItem439.CommandName = "InsertChartPie2D"
            spreadsheetCommandGalleryItem439.ImageOptions.Image = CType((resources.GetObject("resource.Image245")), System.Drawing.Image)
            spreadsheetCommandGalleryItem440.CommandName = "InsertChartPieExploded2D"
            spreadsheetCommandGalleryItem440.ImageOptions.Image = CType((resources.GetObject("resource.Image246")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup101.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem439, spreadsheetCommandGalleryItem440})
            spreadsheetCommandGalleryItemGroup102.CommandName = "InsertChartPie3DCommandGroup"
            spreadsheetCommandGalleryItem441.CommandName = "InsertChartPie3D"
            spreadsheetCommandGalleryItem441.ImageOptions.Image = CType((resources.GetObject("resource.Image247")), System.Drawing.Image)
            spreadsheetCommandGalleryItem442.CommandName = "InsertChartPieExploded3D"
            spreadsheetCommandGalleryItem442.ImageOptions.Image = CType((resources.GetObject("resource.Image248")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup102.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem441, spreadsheetCommandGalleryItem442})
            spreadsheetCommandGalleryItemGroup103.CommandName = "InsertChartDoughnut2DCommandGroup"
            spreadsheetCommandGalleryItem443.CommandName = "InsertChartDoughnut2D"
            spreadsheetCommandGalleryItem443.ImageOptions.Image = CType((resources.GetObject("resource.Image249")), System.Drawing.Image)
            spreadsheetCommandGalleryItem444.CommandName = "InsertChartDoughnutExploded2D"
            spreadsheetCommandGalleryItem444.ImageOptions.Image = CType((resources.GetObject("resource.Image250")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup103.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem443, spreadsheetCommandGalleryItem444})
            Me.commandBarGalleryDropDown32.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup101, spreadsheetCommandGalleryItemGroup102, spreadsheetCommandGalleryItemGroup103})
            Me.commandBarGalleryDropDown32.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown32.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown32.Manager = Nothing
            Me.commandBarGalleryDropDown32.Name = "commandBarGalleryDropDown32"
            ' 
            ' commandBarGalleryDropDown33
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown33.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup104.CommandName = "InsertChartBar2DCommandGroup"
            spreadsheetCommandGalleryItem445.CommandName = "InsertChartBarClustered2D"
            spreadsheetCommandGalleryItem445.ImageOptions.Image = CType((resources.GetObject("resource.Image251")), System.Drawing.Image)
            spreadsheetCommandGalleryItem446.CommandName = "InsertChartBarStacked2D"
            spreadsheetCommandGalleryItem446.ImageOptions.Image = CType((resources.GetObject("resource.Image252")), System.Drawing.Image)
            spreadsheetCommandGalleryItem447.CommandName = "InsertChartBarPercentStacked2D"
            spreadsheetCommandGalleryItem447.ImageOptions.Image = CType((resources.GetObject("resource.Image253")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup104.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem445, spreadsheetCommandGalleryItem446, spreadsheetCommandGalleryItem447})
            spreadsheetCommandGalleryItemGroup105.CommandName = "InsertChartBar3DCommandGroup"
            spreadsheetCommandGalleryItem448.CommandName = "InsertChartBarClustered3D"
            spreadsheetCommandGalleryItem448.ImageOptions.Image = CType((resources.GetObject("resource.Image254")), System.Drawing.Image)
            spreadsheetCommandGalleryItem449.CommandName = "InsertChartBarStacked3D"
            spreadsheetCommandGalleryItem449.ImageOptions.Image = CType((resources.GetObject("resource.Image255")), System.Drawing.Image)
            spreadsheetCommandGalleryItem450.CommandName = "InsertChartBarPercentStacked3D"
            spreadsheetCommandGalleryItem450.ImageOptions.Image = CType((resources.GetObject("resource.Image256")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup105.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem448, spreadsheetCommandGalleryItem449, spreadsheetCommandGalleryItem450})
            spreadsheetCommandGalleryItemGroup106.CommandName = "InsertChartHorizontalCylinderCommandGroup"
            spreadsheetCommandGalleryItem451.CommandName = "InsertChartHorizontalCylinderClustered"
            spreadsheetCommandGalleryItem451.ImageOptions.Image = CType((resources.GetObject("resource.Image257")), System.Drawing.Image)
            spreadsheetCommandGalleryItem452.CommandName = "InsertChartHorizontalCylinderStacked"
            spreadsheetCommandGalleryItem452.ImageOptions.Image = CType((resources.GetObject("resource.Image258")), System.Drawing.Image)
            spreadsheetCommandGalleryItem453.CommandName = "InsertChartHorizontalCylinderPercentStacked"
            spreadsheetCommandGalleryItem453.ImageOptions.Image = CType((resources.GetObject("resource.Image259")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup106.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem451, spreadsheetCommandGalleryItem452, spreadsheetCommandGalleryItem453})
            spreadsheetCommandGalleryItemGroup107.CommandName = "InsertChartHorizontalConeCommandGroup"
            spreadsheetCommandGalleryItem454.CommandName = "InsertChartHorizontalConeClustered"
            spreadsheetCommandGalleryItem454.ImageOptions.Image = CType((resources.GetObject("resource.Image260")), System.Drawing.Image)
            spreadsheetCommandGalleryItem455.CommandName = "InsertChartHorizontalConeStacked"
            spreadsheetCommandGalleryItem455.ImageOptions.Image = CType((resources.GetObject("resource.Image261")), System.Drawing.Image)
            spreadsheetCommandGalleryItem456.CommandName = "InsertChartHorizontalConePercentStacked"
            spreadsheetCommandGalleryItem456.ImageOptions.Image = CType((resources.GetObject("resource.Image262")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup107.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem454, spreadsheetCommandGalleryItem455, spreadsheetCommandGalleryItem456})
            spreadsheetCommandGalleryItemGroup108.CommandName = "InsertChartHorizontalPyramidCommandGroup"
            spreadsheetCommandGalleryItem457.CommandName = "InsertChartHorizontalPyramidClustered"
            spreadsheetCommandGalleryItem457.ImageOptions.Image = CType((resources.GetObject("resource.Image263")), System.Drawing.Image)
            spreadsheetCommandGalleryItem458.CommandName = "InsertChartHorizontalPyramidStacked"
            spreadsheetCommandGalleryItem458.ImageOptions.Image = CType((resources.GetObject("resource.Image264")), System.Drawing.Image)
            spreadsheetCommandGalleryItem459.CommandName = "InsertChartHorizontalPyramidPercentStacked"
            spreadsheetCommandGalleryItem459.ImageOptions.Image = CType((resources.GetObject("resource.Image265")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup108.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem457, spreadsheetCommandGalleryItem458, spreadsheetCommandGalleryItem459})
            Me.commandBarGalleryDropDown33.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup104, spreadsheetCommandGalleryItemGroup105, spreadsheetCommandGalleryItemGroup106, spreadsheetCommandGalleryItemGroup107, spreadsheetCommandGalleryItemGroup108})
            Me.commandBarGalleryDropDown33.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown33.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown33.Manager = Nothing
            Me.commandBarGalleryDropDown33.Name = "commandBarGalleryDropDown33"
            ' 
            ' commandBarGalleryDropDown34
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown34.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup109.CommandName = "InsertChartArea2DCommandGroup"
            spreadsheetCommandGalleryItem460.CommandName = "InsertChartArea"
            spreadsheetCommandGalleryItem460.ImageOptions.Image = CType((resources.GetObject("resource.Image266")), System.Drawing.Image)
            spreadsheetCommandGalleryItem461.CommandName = "InsertChartStackedArea"
            spreadsheetCommandGalleryItem461.ImageOptions.Image = CType((resources.GetObject("resource.Image267")), System.Drawing.Image)
            spreadsheetCommandGalleryItem462.CommandName = "InsertChartPercentStackedArea"
            spreadsheetCommandGalleryItem462.ImageOptions.Image = CType((resources.GetObject("resource.Image268")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup109.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem460, spreadsheetCommandGalleryItem461, spreadsheetCommandGalleryItem462})
            spreadsheetCommandGalleryItemGroup110.CommandName = "InsertChartArea3DCommandGroup"
            spreadsheetCommandGalleryItem463.CommandName = "InsertChartArea3D"
            spreadsheetCommandGalleryItem463.ImageOptions.Image = CType((resources.GetObject("resource.Image269")), System.Drawing.Image)
            spreadsheetCommandGalleryItem464.CommandName = "InsertChartStackedArea3D"
            spreadsheetCommandGalleryItem464.ImageOptions.Image = CType((resources.GetObject("resource.Image270")), System.Drawing.Image)
            spreadsheetCommandGalleryItem465.CommandName = "InsertChartPercentStackedArea3D"
            spreadsheetCommandGalleryItem465.ImageOptions.Image = CType((resources.GetObject("resource.Image271")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup110.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem463, spreadsheetCommandGalleryItem464, spreadsheetCommandGalleryItem465})
            Me.commandBarGalleryDropDown34.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup109, spreadsheetCommandGalleryItemGroup110})
            Me.commandBarGalleryDropDown34.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown34.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown34.Manager = Nothing
            Me.commandBarGalleryDropDown34.Name = "commandBarGalleryDropDown34"
            ' 
            ' commandBarGalleryDropDown35
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown35.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup111.CommandName = "InsertChartScatterCommandGroup"
            spreadsheetCommandGalleryItem466.CommandName = "InsertChartScatterMarkers"
            spreadsheetCommandGalleryItem466.ImageOptions.Image = CType((resources.GetObject("resource.Image272")), System.Drawing.Image)
            spreadsheetCommandGalleryItem467.CommandName = "InsertChartScatterSmoothLinesAndMarkers"
            spreadsheetCommandGalleryItem467.ImageOptions.Image = CType((resources.GetObject("resource.Image273")), System.Drawing.Image)
            spreadsheetCommandGalleryItem468.CommandName = "InsertChartScatterSmoothLines"
            spreadsheetCommandGalleryItem468.ImageOptions.Image = CType((resources.GetObject("resource.Image274")), System.Drawing.Image)
            spreadsheetCommandGalleryItem469.CommandName = "InsertChartScatterLinesAndMarkers"
            spreadsheetCommandGalleryItem469.ImageOptions.Image = CType((resources.GetObject("resource.Image275")), System.Drawing.Image)
            spreadsheetCommandGalleryItem470.CommandName = "InsertChartScatterLines"
            spreadsheetCommandGalleryItem470.ImageOptions.Image = CType((resources.GetObject("resource.Image276")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup111.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem466, spreadsheetCommandGalleryItem467, spreadsheetCommandGalleryItem468, spreadsheetCommandGalleryItem469, spreadsheetCommandGalleryItem470})
            spreadsheetCommandGalleryItemGroup112.CommandName = "InsertChartBubbleCommandGroup"
            spreadsheetCommandGalleryItem471.CommandName = "InsertChartBubble"
            spreadsheetCommandGalleryItem471.ImageOptions.Image = CType((resources.GetObject("resource.Image277")), System.Drawing.Image)
            spreadsheetCommandGalleryItem472.CommandName = "InsertChartBubble3D"
            spreadsheetCommandGalleryItem472.ImageOptions.Image = CType((resources.GetObject("resource.Image278")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup112.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem471, spreadsheetCommandGalleryItem472})
            Me.commandBarGalleryDropDown35.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup111, spreadsheetCommandGalleryItemGroup112})
            Me.commandBarGalleryDropDown35.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown35.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown35.Manager = Nothing
            Me.commandBarGalleryDropDown35.Name = "commandBarGalleryDropDown35"
            ' 
            ' commandBarGalleryDropDown36
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown36.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup113.CommandName = "InsertChartStockCommandGroup"
            spreadsheetCommandGalleryItem473.CommandName = "InsertChartStockHighLowClose"
            spreadsheetCommandGalleryItem473.ImageOptions.Image = CType((resources.GetObject("resource.Image279")), System.Drawing.Image)
            spreadsheetCommandGalleryItem474.CommandName = "InsertChartStockOpenHighLowClose"
            spreadsheetCommandGalleryItem474.ImageOptions.Image = CType((resources.GetObject("resource.Image280")), System.Drawing.Image)
            spreadsheetCommandGalleryItem475.CommandName = "InsertChartStockVolumeHighLowClose"
            spreadsheetCommandGalleryItem475.ImageOptions.Image = CType((resources.GetObject("resource.Image281")), System.Drawing.Image)
            spreadsheetCommandGalleryItem476.CommandName = "InsertChartStockVolumeOpenHighLowClose"
            spreadsheetCommandGalleryItem476.ImageOptions.Image = CType((resources.GetObject("resource.Image282")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup113.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem473, spreadsheetCommandGalleryItem474, spreadsheetCommandGalleryItem475, spreadsheetCommandGalleryItem476})
            spreadsheetCommandGalleryItemGroup114.CommandName = "InsertChartRadarCommandGroup"
            spreadsheetCommandGalleryItem477.CommandName = "InsertChartRadar"
            spreadsheetCommandGalleryItem477.ImageOptions.Image = CType((resources.GetObject("resource.Image283")), System.Drawing.Image)
            spreadsheetCommandGalleryItem478.CommandName = "InsertChartRadarWithMarkers"
            spreadsheetCommandGalleryItem478.ImageOptions.Image = CType((resources.GetObject("resource.Image284")), System.Drawing.Image)
            spreadsheetCommandGalleryItem479.CommandName = "InsertChartRadarFilled"
            spreadsheetCommandGalleryItem479.ImageOptions.Image = CType((resources.GetObject("resource.Image285")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup114.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem477, spreadsheetCommandGalleryItem478, spreadsheetCommandGalleryItem479})
            Me.commandBarGalleryDropDown36.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup113, spreadsheetCommandGalleryItemGroup114})
            Me.commandBarGalleryDropDown36.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown36.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown36.Manager = Nothing
            Me.commandBarGalleryDropDown36.Name = "commandBarGalleryDropDown36"
            ' 
            ' commandBarGalleryDropDown37
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown37.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown37.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup115.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
            spreadsheetCommandGalleryItem480.CommandName = "ChartHidePrimaryHorizontalAxis"
            spreadsheetCommandGalleryItem480.Enabled = False
            spreadsheetCommandGalleryItem480.ImageOptions.Image = CType((resources.GetObject("resource.Image286")), System.Drawing.Image)
            spreadsheetCommandGalleryItem481.CommandName = "ChartPrimaryHorizontalAxisLeftToRight"
            spreadsheetCommandGalleryItem481.Enabled = False
            spreadsheetCommandGalleryItem481.ImageOptions.Image = CType((resources.GetObject("resource.Image287")), System.Drawing.Image)
            spreadsheetCommandGalleryItem482.CommandName = "ChartPrimaryHorizontalAxisHideLabels"
            spreadsheetCommandGalleryItem482.Enabled = False
            spreadsheetCommandGalleryItem482.ImageOptions.Image = CType((resources.GetObject("resource.Image288")), System.Drawing.Image)
            spreadsheetCommandGalleryItem483.CommandName = "ChartPrimaryHorizontalAxisRightToLeft"
            spreadsheetCommandGalleryItem483.Enabled = False
            spreadsheetCommandGalleryItem483.ImageOptions.Image = CType((resources.GetObject("resource.Image289")), System.Drawing.Image)
            spreadsheetCommandGalleryItem484.CommandName = "ChartPrimaryHorizontalAxisDefault"
            spreadsheetCommandGalleryItem484.Enabled = False
            spreadsheetCommandGalleryItem484.ImageOptions.Image = CType((resources.GetObject("resource.Image290")), System.Drawing.Image)
            spreadsheetCommandGalleryItem485.CommandName = "ChartPrimaryHorizontalAxisScaleThousands"
            spreadsheetCommandGalleryItem485.Enabled = False
            spreadsheetCommandGalleryItem485.ImageOptions.Image = CType((resources.GetObject("resource.Image291")), System.Drawing.Image)
            spreadsheetCommandGalleryItem486.CommandName = "ChartPrimaryHorizontalAxisScaleMillions"
            spreadsheetCommandGalleryItem486.Enabled = False
            spreadsheetCommandGalleryItem486.ImageOptions.Image = CType((resources.GetObject("resource.Image292")), System.Drawing.Image)
            spreadsheetCommandGalleryItem487.CommandName = "ChartPrimaryHorizontalAxisScaleBillions"
            spreadsheetCommandGalleryItem487.Enabled = False
            spreadsheetCommandGalleryItem487.ImageOptions.Image = CType((resources.GetObject("resource.Image293")), System.Drawing.Image)
            spreadsheetCommandGalleryItem488.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm"
            spreadsheetCommandGalleryItem488.Enabled = False
            spreadsheetCommandGalleryItem488.ImageOptions.Image = CType((resources.GetObject("resource.Image294")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup115.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem480, spreadsheetCommandGalleryItem481, spreadsheetCommandGalleryItem482, spreadsheetCommandGalleryItem483, spreadsheetCommandGalleryItem484, spreadsheetCommandGalleryItem485, spreadsheetCommandGalleryItem486, spreadsheetCommandGalleryItem487, spreadsheetCommandGalleryItem488})
            Me.commandBarGalleryDropDown37.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup115})
            Me.commandBarGalleryDropDown37.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown37.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown37.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown37.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown37.Manager = Nothing
            Me.commandBarGalleryDropDown37.Name = "commandBarGalleryDropDown37"
            ' 
            ' commandBarGalleryDropDown38
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown38.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown38.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup116.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
            spreadsheetCommandGalleryItem489.CommandName = "ChartHidePrimaryVerticalAxis"
            spreadsheetCommandGalleryItem489.Enabled = False
            spreadsheetCommandGalleryItem489.ImageOptions.Image = CType((resources.GetObject("resource.Image295")), System.Drawing.Image)
            spreadsheetCommandGalleryItem490.CommandName = "ChartPrimaryVerticalAxisLeftToRight"
            spreadsheetCommandGalleryItem490.Enabled = False
            spreadsheetCommandGalleryItem490.ImageOptions.Image = CType((resources.GetObject("resource.Image296")), System.Drawing.Image)
            spreadsheetCommandGalleryItem491.CommandName = "ChartPrimaryVerticalAxisHideLabels"
            spreadsheetCommandGalleryItem491.Enabled = False
            spreadsheetCommandGalleryItem491.ImageOptions.Image = CType((resources.GetObject("resource.Image297")), System.Drawing.Image)
            spreadsheetCommandGalleryItem492.CommandName = "ChartPrimaryVerticalAxisRightToLeft"
            spreadsheetCommandGalleryItem492.Enabled = False
            spreadsheetCommandGalleryItem492.ImageOptions.Image = CType((resources.GetObject("resource.Image298")), System.Drawing.Image)
            spreadsheetCommandGalleryItem493.CommandName = "ChartPrimaryVerticalAxisDefault"
            spreadsheetCommandGalleryItem493.Enabled = False
            spreadsheetCommandGalleryItem493.ImageOptions.Image = CType((resources.GetObject("resource.Image299")), System.Drawing.Image)
            spreadsheetCommandGalleryItem494.CommandName = "ChartPrimaryVerticalAxisScaleThousands"
            spreadsheetCommandGalleryItem494.Enabled = False
            spreadsheetCommandGalleryItem494.ImageOptions.Image = CType((resources.GetObject("resource.Image300")), System.Drawing.Image)
            spreadsheetCommandGalleryItem495.CommandName = "ChartPrimaryVerticalAxisScaleMillions"
            spreadsheetCommandGalleryItem495.Enabled = False
            spreadsheetCommandGalleryItem495.ImageOptions.Image = CType((resources.GetObject("resource.Image301")), System.Drawing.Image)
            spreadsheetCommandGalleryItem496.CommandName = "ChartPrimaryVerticalAxisScaleBillions"
            spreadsheetCommandGalleryItem496.Enabled = False
            spreadsheetCommandGalleryItem496.ImageOptions.Image = CType((resources.GetObject("resource.Image302")), System.Drawing.Image)
            spreadsheetCommandGalleryItem497.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm"
            spreadsheetCommandGalleryItem497.Enabled = False
            spreadsheetCommandGalleryItem497.ImageOptions.Image = CType((resources.GetObject("resource.Image303")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup116.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem489, spreadsheetCommandGalleryItem490, spreadsheetCommandGalleryItem491, spreadsheetCommandGalleryItem492, spreadsheetCommandGalleryItem493, spreadsheetCommandGalleryItem494, spreadsheetCommandGalleryItem495, spreadsheetCommandGalleryItem496, spreadsheetCommandGalleryItem497})
            Me.commandBarGalleryDropDown38.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup116})
            Me.commandBarGalleryDropDown38.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown38.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown38.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown38.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown38.Manager = Nothing
            Me.commandBarGalleryDropDown38.Name = "commandBarGalleryDropDown38"
            ' 
            ' commandBarGalleryDropDown39
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown39.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown39.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup117.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
            spreadsheetCommandGalleryItem498.CommandName = "ChartPrimaryHorizontalGridlinesNone"
            spreadsheetCommandGalleryItem498.Enabled = False
            spreadsheetCommandGalleryItem498.ImageOptions.Image = CType((resources.GetObject("resource.Image304")), System.Drawing.Image)
            spreadsheetCommandGalleryItem499.CommandName = "ChartPrimaryHorizontalGridlinesMajor"
            spreadsheetCommandGalleryItem499.Enabled = False
            spreadsheetCommandGalleryItem499.ImageOptions.Image = CType((resources.GetObject("resource.Image305")), System.Drawing.Image)
            spreadsheetCommandGalleryItem500.CommandName = "ChartPrimaryHorizontalGridlinesMinor"
            spreadsheetCommandGalleryItem500.Enabled = False
            spreadsheetCommandGalleryItem500.ImageOptions.Image = CType((resources.GetObject("resource.Image306")), System.Drawing.Image)
            spreadsheetCommandGalleryItem501.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor"
            spreadsheetCommandGalleryItem501.Enabled = False
            spreadsheetCommandGalleryItem501.ImageOptions.Image = CType((resources.GetObject("resource.Image307")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup117.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem498, spreadsheetCommandGalleryItem499, spreadsheetCommandGalleryItem500, spreadsheetCommandGalleryItem501})
            Me.commandBarGalleryDropDown39.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup117})
            Me.commandBarGalleryDropDown39.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown39.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown39.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown39.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown39.Manager = Nothing
            Me.commandBarGalleryDropDown39.Name = "commandBarGalleryDropDown39"
            ' 
            ' commandBarGalleryDropDown40
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown40.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown40.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup118.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
            spreadsheetCommandGalleryItem502.CommandName = "ChartPrimaryVerticalGridlinesNone"
            spreadsheetCommandGalleryItem502.Enabled = False
            spreadsheetCommandGalleryItem502.ImageOptions.Image = CType((resources.GetObject("resource.Image308")), System.Drawing.Image)
            spreadsheetCommandGalleryItem503.CommandName = "ChartPrimaryVerticalGridlinesMajor"
            spreadsheetCommandGalleryItem503.Enabled = False
            spreadsheetCommandGalleryItem503.ImageOptions.Image = CType((resources.GetObject("resource.Image309")), System.Drawing.Image)
            spreadsheetCommandGalleryItem504.CommandName = "ChartPrimaryVerticalGridlinesMinor"
            spreadsheetCommandGalleryItem504.Enabled = False
            spreadsheetCommandGalleryItem504.ImageOptions.Image = CType((resources.GetObject("resource.Image310")), System.Drawing.Image)
            spreadsheetCommandGalleryItem505.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor"
            spreadsheetCommandGalleryItem505.Enabled = False
            spreadsheetCommandGalleryItem505.ImageOptions.Image = CType((resources.GetObject("resource.Image311")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup118.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem502, spreadsheetCommandGalleryItem503, spreadsheetCommandGalleryItem504, spreadsheetCommandGalleryItem505})
            Me.commandBarGalleryDropDown40.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup118})
            Me.commandBarGalleryDropDown40.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown40.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown40.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown40.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown40.Manager = Nothing
            Me.commandBarGalleryDropDown40.Name = "commandBarGalleryDropDown40"
            ' 
            ' commandBarGalleryDropDown41
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown41.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown41.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup119.CommandName = "ChartTitleCommandGroup"
            spreadsheetCommandGalleryItem506.CommandName = "ChartTitleNone"
            spreadsheetCommandGalleryItem506.Enabled = False
            spreadsheetCommandGalleryItem506.ImageOptions.Image = CType((resources.GetObject("resource.Image312")), System.Drawing.Image)
            spreadsheetCommandGalleryItem507.CommandName = "ChartTitleCenteredOverlay"
            spreadsheetCommandGalleryItem507.Enabled = False
            spreadsheetCommandGalleryItem507.ImageOptions.Image = CType((resources.GetObject("resource.Image313")), System.Drawing.Image)
            spreadsheetCommandGalleryItem508.CommandName = "ChartTitleAbove"
            spreadsheetCommandGalleryItem508.Enabled = False
            spreadsheetCommandGalleryItem508.ImageOptions.Image = CType((resources.GetObject("resource.Image314")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup119.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem506, spreadsheetCommandGalleryItem507, spreadsheetCommandGalleryItem508})
            Me.commandBarGalleryDropDown41.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup119})
            Me.commandBarGalleryDropDown41.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown41.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown41.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown41.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown41.Manager = Nothing
            Me.commandBarGalleryDropDown41.Name = "commandBarGalleryDropDown41"
            ' 
            ' commandBarGalleryDropDown42
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown42.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown42.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup120.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
            spreadsheetCommandGalleryItem509.CommandName = "ChartPrimaryHorizontalAxisTitleNone"
            spreadsheetCommandGalleryItem509.Enabled = False
            spreadsheetCommandGalleryItem509.ImageOptions.Image = CType((resources.GetObject("resource.Image315")), System.Drawing.Image)
            spreadsheetCommandGalleryItem510.CommandName = "ChartPrimaryHorizontalAxisTitleBelow"
            spreadsheetCommandGalleryItem510.Enabled = False
            spreadsheetCommandGalleryItem510.ImageOptions.Image = CType((resources.GetObject("resource.Image316")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup120.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem509, spreadsheetCommandGalleryItem510})
            Me.commandBarGalleryDropDown42.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup120})
            Me.commandBarGalleryDropDown42.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown42.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown42.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown42.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown42.Manager = Nothing
            Me.commandBarGalleryDropDown42.Name = "commandBarGalleryDropDown42"
            ' 
            ' commandBarGalleryDropDown43
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown43.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown43.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup121.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
            spreadsheetCommandGalleryItem511.CommandName = "ChartPrimaryVerticalAxisTitleNone"
            spreadsheetCommandGalleryItem511.Enabled = False
            spreadsheetCommandGalleryItem511.ImageOptions.Image = CType((resources.GetObject("resource.Image317")), System.Drawing.Image)
            spreadsheetCommandGalleryItem512.CommandName = "ChartPrimaryVerticalAxisTitleRotated"
            spreadsheetCommandGalleryItem512.Enabled = False
            spreadsheetCommandGalleryItem512.ImageOptions.Image = CType((resources.GetObject("resource.Image318")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup121.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem511, spreadsheetCommandGalleryItem512})
            Me.commandBarGalleryDropDown43.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup121})
            Me.commandBarGalleryDropDown43.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown43.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown43.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown43.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown43.Manager = Nothing
            Me.commandBarGalleryDropDown43.Name = "commandBarGalleryDropDown43"
            ' 
            ' commandBarGalleryDropDown44
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown44.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown44.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup122.CommandName = "ChartLegendCommandGroup"
            spreadsheetCommandGalleryItem515.CommandName = "ChartLegendNone"
            spreadsheetCommandGalleryItem515.Enabled = False
            spreadsheetCommandGalleryItem515.ImageOptions.Image = CType((resources.GetObject("resource.Image321")), System.Drawing.Image)
            spreadsheetCommandGalleryItem516.CommandName = "ChartLegendAtRight"
            spreadsheetCommandGalleryItem516.Enabled = False
            spreadsheetCommandGalleryItem516.ImageOptions.Image = CType((resources.GetObject("resource.Image322")), System.Drawing.Image)
            spreadsheetCommandGalleryItem517.CommandName = "ChartLegendAtTop"
            spreadsheetCommandGalleryItem517.Enabled = False
            spreadsheetCommandGalleryItem517.ImageOptions.Image = CType((resources.GetObject("resource.Image323")), System.Drawing.Image)
            spreadsheetCommandGalleryItem518.CommandName = "ChartLegendAtLeft"
            spreadsheetCommandGalleryItem518.Enabled = False
            spreadsheetCommandGalleryItem518.ImageOptions.Image = CType((resources.GetObject("resource.Image324")), System.Drawing.Image)
            spreadsheetCommandGalleryItem519.CommandName = "ChartLegendAtBottom"
            spreadsheetCommandGalleryItem519.Enabled = False
            spreadsheetCommandGalleryItem519.ImageOptions.Image = CType((resources.GetObject("resource.Image325")), System.Drawing.Image)
            spreadsheetCommandGalleryItem520.CommandName = "ChartLegendOverlayAtRight"
            spreadsheetCommandGalleryItem520.Enabled = False
            spreadsheetCommandGalleryItem520.ImageOptions.Image = CType((resources.GetObject("resource.Image326")), System.Drawing.Image)
            spreadsheetCommandGalleryItem521.CommandName = "ChartLegendOverlayAtLeft"
            spreadsheetCommandGalleryItem521.Enabled = False
            spreadsheetCommandGalleryItem521.ImageOptions.Image = CType((resources.GetObject("resource.Image327")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup122.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem515, spreadsheetCommandGalleryItem516, spreadsheetCommandGalleryItem517, spreadsheetCommandGalleryItem518, spreadsheetCommandGalleryItem519, spreadsheetCommandGalleryItem520, spreadsheetCommandGalleryItem521})
            Me.commandBarGalleryDropDown44.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup122})
            Me.commandBarGalleryDropDown44.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown44.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown44.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown44.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown44.Manager = Nothing
            Me.commandBarGalleryDropDown44.Name = "commandBarGalleryDropDown44"
            ' 
            ' commandBarGalleryDropDown45
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown45.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown45.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup123.CommandName = "ChartDataLabelsCommandGroup"
            spreadsheetCommandGalleryItem522.CommandName = "ChartDataLabelsNone"
            spreadsheetCommandGalleryItem522.Enabled = False
            spreadsheetCommandGalleryItem522.ImageOptions.Image = CType((resources.GetObject("resource.Image328")), System.Drawing.Image)
            spreadsheetCommandGalleryItem523.CommandName = "ChartDataLabelsDefault"
            spreadsheetCommandGalleryItem523.Enabled = False
            spreadsheetCommandGalleryItem523.ImageOptions.Image = CType((resources.GetObject("resource.Image329")), System.Drawing.Image)
            spreadsheetCommandGalleryItem524.CommandName = "ChartDataLabelsCenter"
            spreadsheetCommandGalleryItem524.Enabled = False
            spreadsheetCommandGalleryItem524.ImageOptions.Image = CType((resources.GetObject("resource.Image330")), System.Drawing.Image)
            spreadsheetCommandGalleryItem525.CommandName = "ChartDataLabelsInsideEnd"
            spreadsheetCommandGalleryItem525.Enabled = False
            spreadsheetCommandGalleryItem525.ImageOptions.Image = CType((resources.GetObject("resource.Image331")), System.Drawing.Image)
            spreadsheetCommandGalleryItem526.CommandName = "ChartDataLabelsInsideBase"
            spreadsheetCommandGalleryItem526.Enabled = False
            spreadsheetCommandGalleryItem526.ImageOptions.Image = CType((resources.GetObject("resource.Image332")), System.Drawing.Image)
            spreadsheetCommandGalleryItem527.CommandName = "ChartDataLabelsOutsideEnd"
            spreadsheetCommandGalleryItem527.Enabled = False
            spreadsheetCommandGalleryItem527.ImageOptions.Image = CType((resources.GetObject("resource.Image333")), System.Drawing.Image)
            spreadsheetCommandGalleryItem528.CommandName = "ChartDataLabelsBestFit"
            spreadsheetCommandGalleryItem528.Enabled = False
            spreadsheetCommandGalleryItem528.ImageOptions.Image = CType((resources.GetObject("resource.Image334")), System.Drawing.Image)
            spreadsheetCommandGalleryItem529.CommandName = "ChartDataLabelsLeft"
            spreadsheetCommandGalleryItem529.Enabled = False
            spreadsheetCommandGalleryItem529.ImageOptions.Image = CType((resources.GetObject("resource.Image335")), System.Drawing.Image)
            spreadsheetCommandGalleryItem530.CommandName = "ChartDataLabelsRight"
            spreadsheetCommandGalleryItem530.Enabled = False
            spreadsheetCommandGalleryItem530.ImageOptions.Image = CType((resources.GetObject("resource.Image336")), System.Drawing.Image)
            spreadsheetCommandGalleryItem531.CommandName = "ChartDataLabelsAbove"
            spreadsheetCommandGalleryItem531.Enabled = False
            spreadsheetCommandGalleryItem531.ImageOptions.Image = CType((resources.GetObject("resource.Image337")), System.Drawing.Image)
            spreadsheetCommandGalleryItem532.CommandName = "ChartDataLabelsBelow"
            spreadsheetCommandGalleryItem532.Enabled = False
            spreadsheetCommandGalleryItem532.ImageOptions.Image = CType((resources.GetObject("resource.Image338")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup123.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem522, spreadsheetCommandGalleryItem523, spreadsheetCommandGalleryItem524, spreadsheetCommandGalleryItem525, spreadsheetCommandGalleryItem526, spreadsheetCommandGalleryItem527, spreadsheetCommandGalleryItem528, spreadsheetCommandGalleryItem529, spreadsheetCommandGalleryItem530, spreadsheetCommandGalleryItem531, spreadsheetCommandGalleryItem532})
            Me.commandBarGalleryDropDown45.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup123})
            Me.commandBarGalleryDropDown45.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown45.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown45.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown45.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown45.Manager = Nothing
            Me.commandBarGalleryDropDown45.Name = "commandBarGalleryDropDown45"
            ' 
            ' commandBarGalleryDropDown46
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown46.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown46.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup124.CommandName = "ChartLinesCommandGroup"
            spreadsheetCommandGalleryItem533.CommandName = "ChartLinesNone"
            spreadsheetCommandGalleryItem533.Enabled = False
            spreadsheetCommandGalleryItem533.ImageOptions.Image = CType((resources.GetObject("resource.Image339")), System.Drawing.Image)
            spreadsheetCommandGalleryItem534.CommandName = "ChartShowDropLines"
            spreadsheetCommandGalleryItem534.Enabled = False
            spreadsheetCommandGalleryItem534.ImageOptions.Image = CType((resources.GetObject("resource.Image340")), System.Drawing.Image)
            spreadsheetCommandGalleryItem535.CommandName = "ChartShowHighLowLines"
            spreadsheetCommandGalleryItem535.Enabled = False
            spreadsheetCommandGalleryItem535.ImageOptions.Image = CType((resources.GetObject("resource.Image341")), System.Drawing.Image)
            spreadsheetCommandGalleryItem536.CommandName = "ChartShowDropLinesAndHighLowLines"
            spreadsheetCommandGalleryItem536.Enabled = False
            spreadsheetCommandGalleryItem536.ImageOptions.Image = CType((resources.GetObject("resource.Image342")), System.Drawing.Image)
            spreadsheetCommandGalleryItem537.CommandName = "ChartShowSeriesLines"
            spreadsheetCommandGalleryItem537.Enabled = False
            spreadsheetCommandGalleryItem537.ImageOptions.Image = CType((resources.GetObject("resource.Image343")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup124.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem533, spreadsheetCommandGalleryItem534, spreadsheetCommandGalleryItem535, spreadsheetCommandGalleryItem536, spreadsheetCommandGalleryItem537})
            Me.commandBarGalleryDropDown46.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup124})
            Me.commandBarGalleryDropDown46.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown46.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown46.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown46.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown46.Manager = Nothing
            Me.commandBarGalleryDropDown46.Name = "commandBarGalleryDropDown46"
            ' 
            ' commandBarGalleryDropDown47
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown47.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown47.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup125.CommandName = "ChartUpDownBarsCommandGroup"
            spreadsheetCommandGalleryItem538.CommandName = "ChartHideUpDownBars"
            spreadsheetCommandGalleryItem538.Enabled = False
            spreadsheetCommandGalleryItem538.ImageOptions.Image = CType((resources.GetObject("resource.Image344")), System.Drawing.Image)
            spreadsheetCommandGalleryItem539.CommandName = "ChartShowUpDownBars"
            spreadsheetCommandGalleryItem539.Enabled = False
            spreadsheetCommandGalleryItem539.ImageOptions.Image = CType((resources.GetObject("resource.Image345")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup125.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem538, spreadsheetCommandGalleryItem539})
            Me.commandBarGalleryDropDown47.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup125})
            Me.commandBarGalleryDropDown47.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown47.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown47.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown47.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown47.Manager = Nothing
            Me.commandBarGalleryDropDown47.Name = "commandBarGalleryDropDown47"
            ' 
            ' commandBarGalleryDropDown48
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown48.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown48.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup126.CommandName = "ChartErrorBarsCommandGroup"
            spreadsheetCommandGalleryItem540.CommandName = "ChartErrorBarsNone"
            spreadsheetCommandGalleryItem540.Enabled = False
            spreadsheetCommandGalleryItem540.ImageOptions.Image = CType((resources.GetObject("resource.Image346")), System.Drawing.Image)
            spreadsheetCommandGalleryItem541.CommandName = "ChartErrorBarsStandardError"
            spreadsheetCommandGalleryItem541.Enabled = False
            spreadsheetCommandGalleryItem541.ImageOptions.Image = CType((resources.GetObject("resource.Image347")), System.Drawing.Image)
            spreadsheetCommandGalleryItem542.CommandName = "ChartErrorBarsPercentage"
            spreadsheetCommandGalleryItem542.Enabled = False
            spreadsheetCommandGalleryItem542.ImageOptions.Image = CType((resources.GetObject("resource.Image348")), System.Drawing.Image)
            spreadsheetCommandGalleryItem543.CommandName = "ChartErrorBarsStandardDeviation"
            spreadsheetCommandGalleryItem543.Enabled = False
            spreadsheetCommandGalleryItem543.ImageOptions.Image = CType((resources.GetObject("resource.Image349")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup126.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem540, spreadsheetCommandGalleryItem541, spreadsheetCommandGalleryItem542, spreadsheetCommandGalleryItem543})
            Me.commandBarGalleryDropDown48.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup126})
            Me.commandBarGalleryDropDown48.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown48.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown48.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown48.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown48.Manager = Nothing
            Me.commandBarGalleryDropDown48.Name = "commandBarGalleryDropDown48"
            ' 
            ' commandBarGalleryDropDown2
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown2.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup127.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup"
            spreadsheetCommandGalleryItem544.CommandName = "ConditionalFormattingDataBarGradientBlue"
            spreadsheetCommandGalleryItem544.ImageOptions.Image = CType((resources.GetObject("resource.Image350")), System.Drawing.Image)
            spreadsheetCommandGalleryItem545.CommandName = "ConditionalFormattingDataBarGradientGreen"
            spreadsheetCommandGalleryItem545.ImageOptions.Image = CType((resources.GetObject("resource.Image351")), System.Drawing.Image)
            spreadsheetCommandGalleryItem546.CommandName = "ConditionalFormattingDataBarGradientRed"
            spreadsheetCommandGalleryItem546.ImageOptions.Image = CType((resources.GetObject("resource.Image352")), System.Drawing.Image)
            spreadsheetCommandGalleryItem547.CommandName = "ConditionalFormattingDataBarGradientOrange"
            spreadsheetCommandGalleryItem547.ImageOptions.Image = CType((resources.GetObject("resource.Image353")), System.Drawing.Image)
            spreadsheetCommandGalleryItem548.CommandName = "ConditionalFormattingDataBarGradientLightBlue"
            spreadsheetCommandGalleryItem548.ImageOptions.Image = CType((resources.GetObject("resource.Image354")), System.Drawing.Image)
            spreadsheetCommandGalleryItem549.CommandName = "ConditionalFormattingDataBarGradientPurple"
            spreadsheetCommandGalleryItem549.ImageOptions.Image = CType((resources.GetObject("resource.Image355")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup127.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem544, spreadsheetCommandGalleryItem545, spreadsheetCommandGalleryItem546, spreadsheetCommandGalleryItem547, spreadsheetCommandGalleryItem548, spreadsheetCommandGalleryItem549})
            spreadsheetCommandGalleryItemGroup128.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup"
            spreadsheetCommandGalleryItem550.CommandName = "ConditionalFormattingDataBarSolidBlue"
            spreadsheetCommandGalleryItem550.ImageOptions.Image = CType((resources.GetObject("resource.Image356")), System.Drawing.Image)
            spreadsheetCommandGalleryItem551.CommandName = "ConditionalFormattingDataBarSolidGreen"
            spreadsheetCommandGalleryItem551.ImageOptions.Image = CType((resources.GetObject("resource.Image357")), System.Drawing.Image)
            spreadsheetCommandGalleryItem552.CommandName = "ConditionalFormattingDataBarSolidRed"
            spreadsheetCommandGalleryItem552.ImageOptions.Image = CType((resources.GetObject("resource.Image358")), System.Drawing.Image)
            spreadsheetCommandGalleryItem553.CommandName = "ConditionalFormattingDataBarSolidOrange"
            spreadsheetCommandGalleryItem553.ImageOptions.Image = CType((resources.GetObject("resource.Image359")), System.Drawing.Image)
            spreadsheetCommandGalleryItem554.CommandName = "ConditionalFormattingDataBarSolidLightBlue"
            spreadsheetCommandGalleryItem554.ImageOptions.Image = CType((resources.GetObject("resource.Image360")), System.Drawing.Image)
            spreadsheetCommandGalleryItem555.CommandName = "ConditionalFormattingDataBarSolidPurple"
            spreadsheetCommandGalleryItem555.ImageOptions.Image = CType((resources.GetObject("resource.Image361")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup128.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem550, spreadsheetCommandGalleryItem551, spreadsheetCommandGalleryItem552, spreadsheetCommandGalleryItem553, spreadsheetCommandGalleryItem554, spreadsheetCommandGalleryItem555})
            Me.commandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup127, spreadsheetCommandGalleryItemGroup128})
            Me.commandBarGalleryDropDown2.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown2.Manager = Nothing
            Me.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2"
            ' 
            ' commandBarGalleryDropDown1
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown1.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown1.Gallery.ColumnCount = 1
            Me.commandBarGalleryDropDown1.Gallery.DrawImageBackground = False
            galleryItem15.Tag = DevExpress.Export.Xl.XlBorderLineStyle.None
            galleryItem16.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thin
            galleryItem17.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Hair
            galleryItem18.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dotted
            galleryItem19.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Dashed
            galleryItem20.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDot
            galleryItem21.Tag = DevExpress.Export.Xl.XlBorderLineStyle.DashDotDot
            galleryItem22.Tag = DevExpress.Export.Xl.XlBorderLineStyle.[Double]
            galleryItem23.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Medium
            galleryItem24.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashed
            galleryItem25.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDot
            galleryItem26.Tag = DevExpress.Export.Xl.XlBorderLineStyle.MediumDashDotDot
            galleryItem27.Tag = DevExpress.Export.Xl.XlBorderLineStyle.SlantDashDot
            galleryItem28.Tag = DevExpress.Export.Xl.XlBorderLineStyle.Thick
            galleryItemGroup3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem15, galleryItem16, galleryItem17, galleryItem18, galleryItem19, galleryItem20, galleryItem21, galleryItem22, galleryItem23, galleryItem24, galleryItem25, galleryItem26, galleryItem27, galleryItem28})
            Me.commandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup3})
            Me.commandBarGalleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.commandBarGalleryDropDown1.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown1.Gallery.ItemSize = New System.Drawing.Size(136, 26)
            Me.commandBarGalleryDropDown1.Gallery.RowCount = 14
            Me.commandBarGalleryDropDown1.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown1.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown1.Manager = Nothing
            Me.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1"
            ' 
            ' commandBarGalleryDropDown3
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown3.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup129.CommandName = "ConditionalFormattingColorScalesCommandGroup"
            spreadsheetCommandGalleryItem556.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
            spreadsheetCommandGalleryItem556.ImageOptions.Image = CType((resources.GetObject("resource.Image362")), System.Drawing.Image)
            spreadsheetCommandGalleryItem557.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
            spreadsheetCommandGalleryItem557.ImageOptions.Image = CType((resources.GetObject("resource.Image363")), System.Drawing.Image)
            spreadsheetCommandGalleryItem558.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
            spreadsheetCommandGalleryItem558.ImageOptions.Image = CType((resources.GetObject("resource.Image364")), System.Drawing.Image)
            spreadsheetCommandGalleryItem559.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
            spreadsheetCommandGalleryItem559.ImageOptions.Image = CType((resources.GetObject("resource.Image365")), System.Drawing.Image)
            spreadsheetCommandGalleryItem560.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
            spreadsheetCommandGalleryItem560.ImageOptions.Image = CType((resources.GetObject("resource.Image366")), System.Drawing.Image)
            spreadsheetCommandGalleryItem561.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
            spreadsheetCommandGalleryItem561.ImageOptions.Image = CType((resources.GetObject("resource.Image367")), System.Drawing.Image)
            spreadsheetCommandGalleryItem562.CommandName = "ConditionalFormattingColorScaleWhiteRed"
            spreadsheetCommandGalleryItem562.ImageOptions.Image = CType((resources.GetObject("resource.Image368")), System.Drawing.Image)
            spreadsheetCommandGalleryItem563.CommandName = "ConditionalFormattingColorScaleRedWhite"
            spreadsheetCommandGalleryItem563.ImageOptions.Image = CType((resources.GetObject("resource.Image369")), System.Drawing.Image)
            spreadsheetCommandGalleryItem564.CommandName = "ConditionalFormattingColorScaleGreenWhite"
            spreadsheetCommandGalleryItem564.ImageOptions.Image = CType((resources.GetObject("resource.Image370")), System.Drawing.Image)
            spreadsheetCommandGalleryItem565.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
            spreadsheetCommandGalleryItem565.ImageOptions.Image = CType((resources.GetObject("resource.Image371")), System.Drawing.Image)
            spreadsheetCommandGalleryItem566.CommandName = "ConditionalFormattingColorScaleGreenYellow"
            spreadsheetCommandGalleryItem566.ImageOptions.Image = CType((resources.GetObject("resource.Image372")), System.Drawing.Image)
            spreadsheetCommandGalleryItem567.CommandName = "ConditionalFormattingColorScaleYellowGreen"
            spreadsheetCommandGalleryItem567.ImageOptions.Image = CType((resources.GetObject("resource.Image373")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup129.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem556, spreadsheetCommandGalleryItem557, spreadsheetCommandGalleryItem558, spreadsheetCommandGalleryItem559, spreadsheetCommandGalleryItem560, spreadsheetCommandGalleryItem561, spreadsheetCommandGalleryItem562, spreadsheetCommandGalleryItem563, spreadsheetCommandGalleryItem564, spreadsheetCommandGalleryItem565, spreadsheetCommandGalleryItem566, spreadsheetCommandGalleryItem567})
            Me.commandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup129})
            Me.commandBarGalleryDropDown3.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown3.Manager = Nothing
            Me.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3"
            ' 
            ' commandBarGalleryDropDown4
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown4.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup130.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
            spreadsheetCommandGalleryItem568.CommandName = "ConditionalFormattingIconSetArrows3Colored"
            spreadsheetCommandGalleryItem568.ImageOptions.Image = CType((resources.GetObject("resource.Image374")), System.Drawing.Image)
            spreadsheetCommandGalleryItem569.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
            spreadsheetCommandGalleryItem569.ImageOptions.Image = CType((resources.GetObject("resource.Image375")), System.Drawing.Image)
            spreadsheetCommandGalleryItem570.CommandName = "ConditionalFormattingIconSetArrows4Colored"
            spreadsheetCommandGalleryItem570.ImageOptions.Image = CType((resources.GetObject("resource.Image376")), System.Drawing.Image)
            spreadsheetCommandGalleryItem571.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
            spreadsheetCommandGalleryItem571.ImageOptions.Image = CType((resources.GetObject("resource.Image377")), System.Drawing.Image)
            spreadsheetCommandGalleryItem572.CommandName = "ConditionalFormattingIconSetArrows5Colored"
            spreadsheetCommandGalleryItem572.ImageOptions.Image = CType((resources.GetObject("resource.Image378")), System.Drawing.Image)
            spreadsheetCommandGalleryItem573.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
            spreadsheetCommandGalleryItem573.ImageOptions.Image = CType((resources.GetObject("resource.Image379")), System.Drawing.Image)
            spreadsheetCommandGalleryItem574.CommandName = "ConditionalFormattingIconSetTriangles3"
            spreadsheetCommandGalleryItem574.ImageOptions.Image = CType((resources.GetObject("resource.Image380")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup130.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem568, spreadsheetCommandGalleryItem569, spreadsheetCommandGalleryItem570, spreadsheetCommandGalleryItem571, spreadsheetCommandGalleryItem572, spreadsheetCommandGalleryItem573, spreadsheetCommandGalleryItem574})
            spreadsheetCommandGalleryItemGroup131.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
            spreadsheetCommandGalleryItem575.CommandName = "ConditionalFormattingIconSetTrafficLights3"
            spreadsheetCommandGalleryItem575.ImageOptions.Image = CType((resources.GetObject("resource.Image381")), System.Drawing.Image)
            spreadsheetCommandGalleryItem576.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
            spreadsheetCommandGalleryItem576.ImageOptions.Image = CType((resources.GetObject("resource.Image382")), System.Drawing.Image)
            spreadsheetCommandGalleryItem577.CommandName = "ConditionalFormattingIconSetTrafficLights4"
            spreadsheetCommandGalleryItem577.ImageOptions.Image = CType((resources.GetObject("resource.Image383")), System.Drawing.Image)
            spreadsheetCommandGalleryItem578.CommandName = "ConditionalFormattingIconSetSigns3"
            spreadsheetCommandGalleryItem578.ImageOptions.Image = CType((resources.GetObject("resource.Image384")), System.Drawing.Image)
            spreadsheetCommandGalleryItem579.CommandName = "ConditionalFormattingIconSetRedToBlack"
            spreadsheetCommandGalleryItem579.ImageOptions.Image = CType((resources.GetObject("resource.Image385")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup131.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem575, spreadsheetCommandGalleryItem576, spreadsheetCommandGalleryItem577, spreadsheetCommandGalleryItem578, spreadsheetCommandGalleryItem579})
            spreadsheetCommandGalleryItemGroup132.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
            spreadsheetCommandGalleryItem580.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
            spreadsheetCommandGalleryItem580.ImageOptions.Image = CType((resources.GetObject("resource.Image386")), System.Drawing.Image)
            spreadsheetCommandGalleryItem581.CommandName = "ConditionalFormattingIconSetSymbols3"
            spreadsheetCommandGalleryItem581.ImageOptions.Image = CType((resources.GetObject("resource.Image387")), System.Drawing.Image)
            spreadsheetCommandGalleryItem582.CommandName = "ConditionalFormattingIconSetFlags3"
            spreadsheetCommandGalleryItem582.ImageOptions.Image = CType((resources.GetObject("resource.Image388")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup132.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem580, spreadsheetCommandGalleryItem581, spreadsheetCommandGalleryItem582})
            spreadsheetCommandGalleryItemGroup133.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
            spreadsheetCommandGalleryItem583.CommandName = "ConditionalFormattingIconSetStars3"
            spreadsheetCommandGalleryItem583.ImageOptions.Image = CType((resources.GetObject("resource.Image389")), System.Drawing.Image)
            spreadsheetCommandGalleryItem584.CommandName = "ConditionalFormattingIconSetRatings4"
            spreadsheetCommandGalleryItem584.ImageOptions.Image = CType((resources.GetObject("resource.Image390")), System.Drawing.Image)
            spreadsheetCommandGalleryItem585.CommandName = "ConditionalFormattingIconSetRatings5"
            spreadsheetCommandGalleryItem585.ImageOptions.Image = CType((resources.GetObject("resource.Image391")), System.Drawing.Image)
            spreadsheetCommandGalleryItem586.CommandName = "ConditionalFormattingIconSetQuarters5"
            spreadsheetCommandGalleryItem586.ImageOptions.Image = CType((resources.GetObject("resource.Image392")), System.Drawing.Image)
            spreadsheetCommandGalleryItem587.CommandName = "ConditionalFormattingIconSetBoxes5"
            spreadsheetCommandGalleryItem587.ImageOptions.Image = CType((resources.GetObject("resource.Image393")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup133.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem583, spreadsheetCommandGalleryItem584, spreadsheetCommandGalleryItem585, spreadsheetCommandGalleryItem586, spreadsheetCommandGalleryItem587})
            Me.commandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup130, spreadsheetCommandGalleryItemGroup131, spreadsheetCommandGalleryItemGroup132, spreadsheetCommandGalleryItemGroup133})
            Me.commandBarGalleryDropDown4.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown4.Manager = Nothing
            Me.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4"
            ' 
            ' commandBarGalleryDropDown5
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown5.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown5.Gallery.ColumnCount = 7
            Me.commandBarGalleryDropDown5.Gallery.DrawImageBackground = False
            Me.commandBarGalleryDropDown5.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown5.Gallery.ItemSize = New System.Drawing.Size(73, 58)
            Me.commandBarGalleryDropDown5.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown5.Manager = Nothing
            Me.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5"
            ' 
            ' commandBarGalleryDropDown6
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown6.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup134.CommandName = "InsertChartColumn2DCommandGroup"
            spreadsheetCommandGalleryItem588.CommandName = "InsertChartColumnClustered2D"
            spreadsheetCommandGalleryItem588.ImageOptions.Image = CType((resources.GetObject("resource.Image394")), System.Drawing.Image)
            spreadsheetCommandGalleryItem589.CommandName = "InsertChartColumnStacked2D"
            spreadsheetCommandGalleryItem589.ImageOptions.Image = CType((resources.GetObject("resource.Image395")), System.Drawing.Image)
            spreadsheetCommandGalleryItem590.CommandName = "InsertChartColumnPercentStacked2D"
            spreadsheetCommandGalleryItem590.ImageOptions.Image = CType((resources.GetObject("resource.Image396")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup134.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem588, spreadsheetCommandGalleryItem589, spreadsheetCommandGalleryItem590})
            spreadsheetCommandGalleryItemGroup135.CommandName = "InsertChartColumn3DCommandGroup"
            spreadsheetCommandGalleryItem591.CommandName = "InsertChartColumnClustered3D"
            spreadsheetCommandGalleryItem591.ImageOptions.Image = CType((resources.GetObject("resource.Image397")), System.Drawing.Image)
            spreadsheetCommandGalleryItem592.CommandName = "InsertChartColumnStacked3D"
            spreadsheetCommandGalleryItem592.ImageOptions.Image = CType((resources.GetObject("resource.Image398")), System.Drawing.Image)
            spreadsheetCommandGalleryItem593.CommandName = "InsertChartColumnPercentStacked3D"
            spreadsheetCommandGalleryItem593.ImageOptions.Image = CType((resources.GetObject("resource.Image399")), System.Drawing.Image)
            spreadsheetCommandGalleryItem594.CommandName = "InsertChartColumn3D"
            spreadsheetCommandGalleryItem594.ImageOptions.Image = CType((resources.GetObject("resource.Image400")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup135.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem591, spreadsheetCommandGalleryItem592, spreadsheetCommandGalleryItem593, spreadsheetCommandGalleryItem594})
            spreadsheetCommandGalleryItemGroup136.CommandName = "InsertChartCylinderCommandGroup"
            spreadsheetCommandGalleryItem595.CommandName = "InsertChartCylinderClustered"
            spreadsheetCommandGalleryItem595.ImageOptions.Image = CType((resources.GetObject("resource.Image401")), System.Drawing.Image)
            spreadsheetCommandGalleryItem596.CommandName = "InsertChartCylinderStacked"
            spreadsheetCommandGalleryItem596.ImageOptions.Image = CType((resources.GetObject("resource.Image402")), System.Drawing.Image)
            spreadsheetCommandGalleryItem597.CommandName = "InsertChartCylinderPercentStacked"
            spreadsheetCommandGalleryItem597.ImageOptions.Image = CType((resources.GetObject("resource.Image403")), System.Drawing.Image)
            spreadsheetCommandGalleryItem598.CommandName = "InsertChartCylinder"
            spreadsheetCommandGalleryItem598.ImageOptions.Image = CType((resources.GetObject("resource.Image404")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup136.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem595, spreadsheetCommandGalleryItem596, spreadsheetCommandGalleryItem597, spreadsheetCommandGalleryItem598})
            spreadsheetCommandGalleryItemGroup137.CommandName = "InsertChartConeCommandGroup"
            spreadsheetCommandGalleryItem599.CommandName = "InsertChartConeClustered"
            spreadsheetCommandGalleryItem599.ImageOptions.Image = CType((resources.GetObject("resource.Image405")), System.Drawing.Image)
            spreadsheetCommandGalleryItem600.CommandName = "InsertChartConeStacked"
            spreadsheetCommandGalleryItem600.ImageOptions.Image = CType((resources.GetObject("resource.Image406")), System.Drawing.Image)
            spreadsheetCommandGalleryItem601.CommandName = "InsertChartConePercentStacked"
            spreadsheetCommandGalleryItem601.ImageOptions.Image = CType((resources.GetObject("resource.Image407")), System.Drawing.Image)
            spreadsheetCommandGalleryItem602.CommandName = "InsertChartCone"
            spreadsheetCommandGalleryItem602.ImageOptions.Image = CType((resources.GetObject("resource.Image408")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup137.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem599, spreadsheetCommandGalleryItem600, spreadsheetCommandGalleryItem601, spreadsheetCommandGalleryItem602})
            spreadsheetCommandGalleryItemGroup138.CommandName = "InsertChartPyramidCommandGroup"
            spreadsheetCommandGalleryItem603.CommandName = "InsertChartPyramidClustered"
            spreadsheetCommandGalleryItem603.ImageOptions.Image = CType((resources.GetObject("resource.Image409")), System.Drawing.Image)
            spreadsheetCommandGalleryItem604.CommandName = "InsertChartPyramidStacked"
            spreadsheetCommandGalleryItem604.ImageOptions.Image = CType((resources.GetObject("resource.Image410")), System.Drawing.Image)
            spreadsheetCommandGalleryItem605.CommandName = "InsertChartPyramidPercentStacked"
            spreadsheetCommandGalleryItem605.ImageOptions.Image = CType((resources.GetObject("resource.Image411")), System.Drawing.Image)
            spreadsheetCommandGalleryItem606.CommandName = "InsertChartPyramid"
            spreadsheetCommandGalleryItem606.ImageOptions.Image = CType((resources.GetObject("resource.Image412")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup138.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem603, spreadsheetCommandGalleryItem604, spreadsheetCommandGalleryItem605, spreadsheetCommandGalleryItem606})
            Me.commandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup134, spreadsheetCommandGalleryItemGroup135, spreadsheetCommandGalleryItemGroup136, spreadsheetCommandGalleryItemGroup137, spreadsheetCommandGalleryItemGroup138})
            Me.commandBarGalleryDropDown6.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown6.Manager = Nothing
            Me.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6"
            ' 
            ' commandBarGalleryDropDown7
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown7.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup139.CommandName = "InsertChartLine2DCommandGroup"
            spreadsheetCommandGalleryItem607.CommandName = "InsertChartLine"
            spreadsheetCommandGalleryItem607.ImageOptions.Image = CType((resources.GetObject("resource.Image413")), System.Drawing.Image)
            spreadsheetCommandGalleryItem608.CommandName = "InsertChartStackedLine"
            spreadsheetCommandGalleryItem608.ImageOptions.Image = CType((resources.GetObject("resource.Image414")), System.Drawing.Image)
            spreadsheetCommandGalleryItem609.CommandName = "InsertChartPercentStackedLine"
            spreadsheetCommandGalleryItem609.ImageOptions.Image = CType((resources.GetObject("resource.Image415")), System.Drawing.Image)
            spreadsheetCommandGalleryItem610.CommandName = "InsertChartLineWithMarkers"
            spreadsheetCommandGalleryItem610.ImageOptions.Image = CType((resources.GetObject("resource.Image416")), System.Drawing.Image)
            spreadsheetCommandGalleryItem611.CommandName = "InsertChartStackedLineWithMarkers"
            spreadsheetCommandGalleryItem611.ImageOptions.Image = CType((resources.GetObject("resource.Image417")), System.Drawing.Image)
            spreadsheetCommandGalleryItem612.CommandName = "InsertChartPercentStackedLineWithMarkers"
            spreadsheetCommandGalleryItem612.ImageOptions.Image = CType((resources.GetObject("resource.Image418")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup139.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem607, spreadsheetCommandGalleryItem608, spreadsheetCommandGalleryItem609, spreadsheetCommandGalleryItem610, spreadsheetCommandGalleryItem611, spreadsheetCommandGalleryItem612})
            spreadsheetCommandGalleryItemGroup140.CommandName = "InsertChartLine3DCommandGroup"
            spreadsheetCommandGalleryItem613.CommandName = "InsertChartLine3D"
            spreadsheetCommandGalleryItem613.ImageOptions.Image = CType((resources.GetObject("resource.Image419")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup140.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem613})
            Me.commandBarGalleryDropDown7.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup139, spreadsheetCommandGalleryItemGroup140})
            Me.commandBarGalleryDropDown7.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown7.Manager = Nothing
            Me.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7"
            ' 
            ' commandBarGalleryDropDown8
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown8.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup141.CommandName = "InsertChartPie2DCommandGroup"
            spreadsheetCommandGalleryItem614.CommandName = "InsertChartPie2D"
            spreadsheetCommandGalleryItem614.ImageOptions.Image = CType((resources.GetObject("resource.Image420")), System.Drawing.Image)
            spreadsheetCommandGalleryItem615.CommandName = "InsertChartPieExploded2D"
            spreadsheetCommandGalleryItem615.ImageOptions.Image = CType((resources.GetObject("resource.Image421")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup141.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem614, spreadsheetCommandGalleryItem615})
            spreadsheetCommandGalleryItemGroup142.CommandName = "InsertChartPie3DCommandGroup"
            spreadsheetCommandGalleryItem616.CommandName = "InsertChartPie3D"
            spreadsheetCommandGalleryItem616.ImageOptions.Image = CType((resources.GetObject("resource.Image422")), System.Drawing.Image)
            spreadsheetCommandGalleryItem617.CommandName = "InsertChartPieExploded3D"
            spreadsheetCommandGalleryItem617.ImageOptions.Image = CType((resources.GetObject("resource.Image423")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup142.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem616, spreadsheetCommandGalleryItem617})
            spreadsheetCommandGalleryItemGroup143.CommandName = "InsertChartDoughnut2DCommandGroup"
            spreadsheetCommandGalleryItem618.CommandName = "InsertChartDoughnut2D"
            spreadsheetCommandGalleryItem618.ImageOptions.Image = CType((resources.GetObject("resource.Image424")), System.Drawing.Image)
            spreadsheetCommandGalleryItem619.CommandName = "InsertChartDoughnutExploded2D"
            spreadsheetCommandGalleryItem619.ImageOptions.Image = CType((resources.GetObject("resource.Image425")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup143.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem618, spreadsheetCommandGalleryItem619})
            Me.commandBarGalleryDropDown8.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup141, spreadsheetCommandGalleryItemGroup142, spreadsheetCommandGalleryItemGroup143})
            Me.commandBarGalleryDropDown8.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown8.Manager = Nothing
            Me.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8"
            ' 
            ' commandBarGalleryDropDown9
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown9.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup144.CommandName = "InsertChartBar2DCommandGroup"
            spreadsheetCommandGalleryItem620.CommandName = "InsertChartBarClustered2D"
            spreadsheetCommandGalleryItem620.ImageOptions.Image = CType((resources.GetObject("resource.Image426")), System.Drawing.Image)
            spreadsheetCommandGalleryItem621.CommandName = "InsertChartBarStacked2D"
            spreadsheetCommandGalleryItem621.ImageOptions.Image = CType((resources.GetObject("resource.Image427")), System.Drawing.Image)
            spreadsheetCommandGalleryItem622.CommandName = "InsertChartBarPercentStacked2D"
            spreadsheetCommandGalleryItem622.ImageOptions.Image = CType((resources.GetObject("resource.Image428")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup144.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem620, spreadsheetCommandGalleryItem621, spreadsheetCommandGalleryItem622})
            spreadsheetCommandGalleryItemGroup145.CommandName = "InsertChartBar3DCommandGroup"
            spreadsheetCommandGalleryItem623.CommandName = "InsertChartBarClustered3D"
            spreadsheetCommandGalleryItem623.ImageOptions.Image = CType((resources.GetObject("resource.Image429")), System.Drawing.Image)
            spreadsheetCommandGalleryItem624.CommandName = "InsertChartBarStacked3D"
            spreadsheetCommandGalleryItem624.ImageOptions.Image = CType((resources.GetObject("resource.Image430")), System.Drawing.Image)
            spreadsheetCommandGalleryItem625.CommandName = "InsertChartBarPercentStacked3D"
            spreadsheetCommandGalleryItem625.ImageOptions.Image = CType((resources.GetObject("resource.Image431")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup145.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem623, spreadsheetCommandGalleryItem624, spreadsheetCommandGalleryItem625})
            spreadsheetCommandGalleryItemGroup146.CommandName = "InsertChartHorizontalCylinderCommandGroup"
            spreadsheetCommandGalleryItem626.CommandName = "InsertChartHorizontalCylinderClustered"
            spreadsheetCommandGalleryItem626.ImageOptions.Image = CType((resources.GetObject("resource.Image432")), System.Drawing.Image)
            spreadsheetCommandGalleryItem627.CommandName = "InsertChartHorizontalCylinderStacked"
            spreadsheetCommandGalleryItem627.ImageOptions.Image = CType((resources.GetObject("resource.Image433")), System.Drawing.Image)
            spreadsheetCommandGalleryItem628.CommandName = "InsertChartHorizontalCylinderPercentStacked"
            spreadsheetCommandGalleryItem628.ImageOptions.Image = CType((resources.GetObject("resource.Image434")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup146.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem626, spreadsheetCommandGalleryItem627, spreadsheetCommandGalleryItem628})
            spreadsheetCommandGalleryItemGroup147.CommandName = "InsertChartHorizontalConeCommandGroup"
            spreadsheetCommandGalleryItem629.CommandName = "InsertChartHorizontalConeClustered"
            spreadsheetCommandGalleryItem629.ImageOptions.Image = CType((resources.GetObject("resource.Image435")), System.Drawing.Image)
            spreadsheetCommandGalleryItem630.CommandName = "InsertChartHorizontalConeStacked"
            spreadsheetCommandGalleryItem630.ImageOptions.Image = CType((resources.GetObject("resource.Image436")), System.Drawing.Image)
            spreadsheetCommandGalleryItem631.CommandName = "InsertChartHorizontalConePercentStacked"
            spreadsheetCommandGalleryItem631.ImageOptions.Image = CType((resources.GetObject("resource.Image437")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup147.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem629, spreadsheetCommandGalleryItem630, spreadsheetCommandGalleryItem631})
            spreadsheetCommandGalleryItemGroup148.CommandName = "InsertChartHorizontalPyramidCommandGroup"
            spreadsheetCommandGalleryItem632.CommandName = "InsertChartHorizontalPyramidClustered"
            spreadsheetCommandGalleryItem632.ImageOptions.Image = CType((resources.GetObject("resource.Image438")), System.Drawing.Image)
            spreadsheetCommandGalleryItem633.CommandName = "InsertChartHorizontalPyramidStacked"
            spreadsheetCommandGalleryItem633.ImageOptions.Image = CType((resources.GetObject("resource.Image439")), System.Drawing.Image)
            spreadsheetCommandGalleryItem634.CommandName = "InsertChartHorizontalPyramidPercentStacked"
            spreadsheetCommandGalleryItem634.ImageOptions.Image = CType((resources.GetObject("resource.Image440")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup148.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem632, spreadsheetCommandGalleryItem633, spreadsheetCommandGalleryItem634})
            Me.commandBarGalleryDropDown9.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup144, spreadsheetCommandGalleryItemGroup145, spreadsheetCommandGalleryItemGroup146, spreadsheetCommandGalleryItemGroup147, spreadsheetCommandGalleryItemGroup148})
            Me.commandBarGalleryDropDown9.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown9.Manager = Nothing
            Me.commandBarGalleryDropDown9.Name = "commandBarGalleryDropDown9"
            ' 
            ' commandBarGalleryDropDown10
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown10.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup149.CommandName = "InsertChartArea2DCommandGroup"
            spreadsheetCommandGalleryItem635.CommandName = "InsertChartArea"
            spreadsheetCommandGalleryItem635.ImageOptions.Image = CType((resources.GetObject("resource.Image441")), System.Drawing.Image)
            spreadsheetCommandGalleryItem636.CommandName = "InsertChartStackedArea"
            spreadsheetCommandGalleryItem636.ImageOptions.Image = CType((resources.GetObject("resource.Image442")), System.Drawing.Image)
            spreadsheetCommandGalleryItem637.CommandName = "InsertChartPercentStackedArea"
            spreadsheetCommandGalleryItem637.ImageOptions.Image = CType((resources.GetObject("resource.Image443")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup149.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem635, spreadsheetCommandGalleryItem636, spreadsheetCommandGalleryItem637})
            spreadsheetCommandGalleryItemGroup150.CommandName = "InsertChartArea3DCommandGroup"
            spreadsheetCommandGalleryItem638.CommandName = "InsertChartArea3D"
            spreadsheetCommandGalleryItem638.ImageOptions.Image = CType((resources.GetObject("resource.Image444")), System.Drawing.Image)
            spreadsheetCommandGalleryItem639.CommandName = "InsertChartStackedArea3D"
            spreadsheetCommandGalleryItem639.ImageOptions.Image = CType((resources.GetObject("resource.Image445")), System.Drawing.Image)
            spreadsheetCommandGalleryItem640.CommandName = "InsertChartPercentStackedArea3D"
            spreadsheetCommandGalleryItem640.ImageOptions.Image = CType((resources.GetObject("resource.Image446")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup150.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem638, spreadsheetCommandGalleryItem639, spreadsheetCommandGalleryItem640})
            Me.commandBarGalleryDropDown10.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup149, spreadsheetCommandGalleryItemGroup150})
            Me.commandBarGalleryDropDown10.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown10.Manager = Nothing
            Me.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10"
            ' 
            ' commandBarGalleryDropDown11
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown11.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup151.CommandName = "InsertChartScatterCommandGroup"
            spreadsheetCommandGalleryItem641.CommandName = "InsertChartScatterMarkers"
            spreadsheetCommandGalleryItem641.ImageOptions.Image = CType((resources.GetObject("resource.Image447")), System.Drawing.Image)
            spreadsheetCommandGalleryItem642.CommandName = "InsertChartScatterSmoothLinesAndMarkers"
            spreadsheetCommandGalleryItem642.ImageOptions.Image = CType((resources.GetObject("resource.Image448")), System.Drawing.Image)
            spreadsheetCommandGalleryItem643.CommandName = "InsertChartScatterSmoothLines"
            spreadsheetCommandGalleryItem643.ImageOptions.Image = CType((resources.GetObject("resource.Image449")), System.Drawing.Image)
            spreadsheetCommandGalleryItem644.CommandName = "InsertChartScatterLinesAndMarkers"
            spreadsheetCommandGalleryItem644.ImageOptions.Image = CType((resources.GetObject("resource.Image450")), System.Drawing.Image)
            spreadsheetCommandGalleryItem645.CommandName = "InsertChartScatterLines"
            spreadsheetCommandGalleryItem645.ImageOptions.Image = CType((resources.GetObject("resource.Image451")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup151.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem641, spreadsheetCommandGalleryItem642, spreadsheetCommandGalleryItem643, spreadsheetCommandGalleryItem644, spreadsheetCommandGalleryItem645})
            spreadsheetCommandGalleryItemGroup152.CommandName = "InsertChartBubbleCommandGroup"
            spreadsheetCommandGalleryItem646.CommandName = "InsertChartBubble"
            spreadsheetCommandGalleryItem646.ImageOptions.Image = CType((resources.GetObject("resource.Image452")), System.Drawing.Image)
            spreadsheetCommandGalleryItem647.CommandName = "InsertChartBubble3D"
            spreadsheetCommandGalleryItem647.ImageOptions.Image = CType((resources.GetObject("resource.Image453")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup152.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem646, spreadsheetCommandGalleryItem647})
            Me.commandBarGalleryDropDown11.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup151, spreadsheetCommandGalleryItemGroup152})
            Me.commandBarGalleryDropDown11.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown11.Manager = Nothing
            Me.commandBarGalleryDropDown11.Name = "commandBarGalleryDropDown11"
            ' 
            ' commandBarGalleryDropDown12
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown12.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup153.CommandName = "InsertChartStockCommandGroup"
            spreadsheetCommandGalleryItem648.CommandName = "InsertChartStockHighLowClose"
            spreadsheetCommandGalleryItem648.ImageOptions.Image = CType((resources.GetObject("resource.Image454")), System.Drawing.Image)
            spreadsheetCommandGalleryItem649.CommandName = "InsertChartStockOpenHighLowClose"
            spreadsheetCommandGalleryItem649.ImageOptions.Image = CType((resources.GetObject("resource.Image455")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup153.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem648, spreadsheetCommandGalleryItem649})
            spreadsheetCommandGalleryItemGroup154.CommandName = "InsertChartRadarCommandGroup"
            spreadsheetCommandGalleryItem650.CommandName = "InsertChartRadar"
            spreadsheetCommandGalleryItem650.ImageOptions.Image = CType((resources.GetObject("resource.Image456")), System.Drawing.Image)
            spreadsheetCommandGalleryItem651.CommandName = "InsertChartRadarWithMarkers"
            spreadsheetCommandGalleryItem651.ImageOptions.Image = CType((resources.GetObject("resource.Image457")), System.Drawing.Image)
            spreadsheetCommandGalleryItem652.CommandName = "InsertChartRadarFilled"
            spreadsheetCommandGalleryItem652.ImageOptions.Image = CType((resources.GetObject("resource.Image458")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup154.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem650, spreadsheetCommandGalleryItem651, spreadsheetCommandGalleryItem652})
            Me.commandBarGalleryDropDown12.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup153, spreadsheetCommandGalleryItemGroup154})
            Me.commandBarGalleryDropDown12.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown12.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown12.Manager = Nothing
            Me.commandBarGalleryDropDown12.Name = "commandBarGalleryDropDown12"
            ' 
            ' commandBarGalleryDropDown13
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown13.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown13.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup155.CommandName = "ChartTitleCommandGroup"
            spreadsheetCommandGalleryItem653.CommandName = "ChartTitleNone"
            spreadsheetCommandGalleryItem653.Enabled = False
            spreadsheetCommandGalleryItem653.ImageOptions.Image = CType((resources.GetObject("resource.Image459")), System.Drawing.Image)
            spreadsheetCommandGalleryItem654.CommandName = "ChartTitleCenteredOverlay"
            spreadsheetCommandGalleryItem654.Enabled = False
            spreadsheetCommandGalleryItem654.ImageOptions.Image = CType((resources.GetObject("resource.Image460")), System.Drawing.Image)
            spreadsheetCommandGalleryItem655.CommandName = "ChartTitleAbove"
            spreadsheetCommandGalleryItem655.Enabled = False
            spreadsheetCommandGalleryItem655.ImageOptions.Image = CType((resources.GetObject("resource.Image461")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup155.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem653, spreadsheetCommandGalleryItem654, spreadsheetCommandGalleryItem655})
            Me.commandBarGalleryDropDown13.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup155})
            Me.commandBarGalleryDropDown13.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown13.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown13.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown13.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown13.Manager = Nothing
            Me.commandBarGalleryDropDown13.Name = "commandBarGalleryDropDown13"
            ' 
            ' commandBarGalleryDropDown14
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown14.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown14.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup156.CommandName = "ChartPrimaryHorizontalAxisTitleCommandGroup"
            spreadsheetCommandGalleryItem656.CommandName = "ChartPrimaryHorizontalAxisTitleNone"
            spreadsheetCommandGalleryItem656.Enabled = False
            spreadsheetCommandGalleryItem656.ImageOptions.Image = CType((resources.GetObject("resource.Image462")), System.Drawing.Image)
            spreadsheetCommandGalleryItem657.CommandName = "ChartPrimaryHorizontalAxisTitleBelow"
            spreadsheetCommandGalleryItem657.Enabled = False
            spreadsheetCommandGalleryItem657.ImageOptions.Image = CType((resources.GetObject("resource.Image463")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup156.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem656, spreadsheetCommandGalleryItem657})
            Me.commandBarGalleryDropDown14.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup156})
            Me.commandBarGalleryDropDown14.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown14.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown14.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown14.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown14.Manager = Nothing
            Me.commandBarGalleryDropDown14.Name = "commandBarGalleryDropDown14"
            ' 
            ' commandBarGalleryDropDown15
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown15.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown15.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup157.CommandName = "ChartPrimaryVerticalAxisTitleCommandGroup"
            spreadsheetCommandGalleryItem658.CommandName = "ChartPrimaryVerticalAxisTitleNone"
            spreadsheetCommandGalleryItem658.Enabled = False
            spreadsheetCommandGalleryItem658.ImageOptions.Image = CType((resources.GetObject("resource.Image464")), System.Drawing.Image)
            spreadsheetCommandGalleryItem659.CommandName = "ChartPrimaryVerticalAxisTitleRotated"
            spreadsheetCommandGalleryItem659.Enabled = False
            spreadsheetCommandGalleryItem659.ImageOptions.Image = CType((resources.GetObject("resource.Image465")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup157.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem658, spreadsheetCommandGalleryItem659})
            Me.commandBarGalleryDropDown15.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup157})
            Me.commandBarGalleryDropDown15.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown15.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown15.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown15.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown15.Manager = Nothing
            Me.commandBarGalleryDropDown15.Name = "commandBarGalleryDropDown15"
            ' 
            ' commandBarGalleryDropDown16
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown16.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown16.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup158.CommandName = "ChartLegendCommandGroup"
            spreadsheetCommandGalleryItem662.CommandName = "ChartLegendNone"
            spreadsheetCommandGalleryItem662.Enabled = False
            spreadsheetCommandGalleryItem662.ImageOptions.Image = CType((resources.GetObject("resource.Image468")), System.Drawing.Image)
            spreadsheetCommandGalleryItem663.CommandName = "ChartLegendAtRight"
            spreadsheetCommandGalleryItem663.Enabled = False
            spreadsheetCommandGalleryItem663.ImageOptions.Image = CType((resources.GetObject("resource.Image469")), System.Drawing.Image)
            spreadsheetCommandGalleryItem664.CommandName = "ChartLegendAtTop"
            spreadsheetCommandGalleryItem664.Enabled = False
            spreadsheetCommandGalleryItem664.ImageOptions.Image = CType((resources.GetObject("resource.Image470")), System.Drawing.Image)
            spreadsheetCommandGalleryItem665.CommandName = "ChartLegendAtLeft"
            spreadsheetCommandGalleryItem665.Enabled = False
            spreadsheetCommandGalleryItem665.ImageOptions.Image = CType((resources.GetObject("resource.Image471")), System.Drawing.Image)
            spreadsheetCommandGalleryItem666.CommandName = "ChartLegendAtBottom"
            spreadsheetCommandGalleryItem666.Enabled = False
            spreadsheetCommandGalleryItem666.ImageOptions.Image = CType((resources.GetObject("resource.Image472")), System.Drawing.Image)
            spreadsheetCommandGalleryItem667.CommandName = "ChartLegendOverlayAtRight"
            spreadsheetCommandGalleryItem667.Enabled = False
            spreadsheetCommandGalleryItem667.ImageOptions.Image = CType((resources.GetObject("resource.Image473")), System.Drawing.Image)
            spreadsheetCommandGalleryItem668.CommandName = "ChartLegendOverlayAtLeft"
            spreadsheetCommandGalleryItem668.Enabled = False
            spreadsheetCommandGalleryItem668.ImageOptions.Image = CType((resources.GetObject("resource.Image474")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup158.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem662, spreadsheetCommandGalleryItem663, spreadsheetCommandGalleryItem664, spreadsheetCommandGalleryItem665, spreadsheetCommandGalleryItem666, spreadsheetCommandGalleryItem667, spreadsheetCommandGalleryItem668})
            Me.commandBarGalleryDropDown16.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup158})
            Me.commandBarGalleryDropDown16.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown16.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown16.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown16.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown16.Manager = Nothing
            Me.commandBarGalleryDropDown16.Name = "commandBarGalleryDropDown16"
            ' 
            ' commandBarGalleryDropDown17
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown17.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown17.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup159.CommandName = "ChartDataLabelsCommandGroup"
            spreadsheetCommandGalleryItem669.CommandName = "ChartDataLabelsNone"
            spreadsheetCommandGalleryItem669.Enabled = False
            spreadsheetCommandGalleryItem669.ImageOptions.Image = CType((resources.GetObject("resource.Image475")), System.Drawing.Image)
            spreadsheetCommandGalleryItem670.CommandName = "ChartDataLabelsDefault"
            spreadsheetCommandGalleryItem670.Enabled = False
            spreadsheetCommandGalleryItem670.ImageOptions.Image = CType((resources.GetObject("resource.Image476")), System.Drawing.Image)
            spreadsheetCommandGalleryItem671.CommandName = "ChartDataLabelsCenter"
            spreadsheetCommandGalleryItem671.Enabled = False
            spreadsheetCommandGalleryItem671.ImageOptions.Image = CType((resources.GetObject("resource.Image477")), System.Drawing.Image)
            spreadsheetCommandGalleryItem672.CommandName = "ChartDataLabelsInsideEnd"
            spreadsheetCommandGalleryItem672.Enabled = False
            spreadsheetCommandGalleryItem672.ImageOptions.Image = CType((resources.GetObject("resource.Image478")), System.Drawing.Image)
            spreadsheetCommandGalleryItem673.CommandName = "ChartDataLabelsInsideBase"
            spreadsheetCommandGalleryItem673.Enabled = False
            spreadsheetCommandGalleryItem673.ImageOptions.Image = CType((resources.GetObject("resource.Image479")), System.Drawing.Image)
            spreadsheetCommandGalleryItem674.CommandName = "ChartDataLabelsOutsideEnd"
            spreadsheetCommandGalleryItem674.Enabled = False
            spreadsheetCommandGalleryItem674.ImageOptions.Image = CType((resources.GetObject("resource.Image480")), System.Drawing.Image)
            spreadsheetCommandGalleryItem675.CommandName = "ChartDataLabelsBestFit"
            spreadsheetCommandGalleryItem675.Enabled = False
            spreadsheetCommandGalleryItem675.ImageOptions.Image = CType((resources.GetObject("resource.Image481")), System.Drawing.Image)
            spreadsheetCommandGalleryItem676.CommandName = "ChartDataLabelsLeft"
            spreadsheetCommandGalleryItem676.Enabled = False
            spreadsheetCommandGalleryItem676.ImageOptions.Image = CType((resources.GetObject("resource.Image482")), System.Drawing.Image)
            spreadsheetCommandGalleryItem677.CommandName = "ChartDataLabelsRight"
            spreadsheetCommandGalleryItem677.Enabled = False
            spreadsheetCommandGalleryItem677.ImageOptions.Image = CType((resources.GetObject("resource.Image483")), System.Drawing.Image)
            spreadsheetCommandGalleryItem678.CommandName = "ChartDataLabelsAbove"
            spreadsheetCommandGalleryItem678.Enabled = False
            spreadsheetCommandGalleryItem678.ImageOptions.Image = CType((resources.GetObject("resource.Image484")), System.Drawing.Image)
            spreadsheetCommandGalleryItem679.CommandName = "ChartDataLabelsBelow"
            spreadsheetCommandGalleryItem679.Enabled = False
            spreadsheetCommandGalleryItem679.ImageOptions.Image = CType((resources.GetObject("resource.Image485")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup159.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem669, spreadsheetCommandGalleryItem670, spreadsheetCommandGalleryItem671, spreadsheetCommandGalleryItem672, spreadsheetCommandGalleryItem673, spreadsheetCommandGalleryItem674, spreadsheetCommandGalleryItem675, spreadsheetCommandGalleryItem676, spreadsheetCommandGalleryItem677, spreadsheetCommandGalleryItem678, spreadsheetCommandGalleryItem679})
            Me.commandBarGalleryDropDown17.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup159})
            Me.commandBarGalleryDropDown17.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown17.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown17.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown17.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown17.Manager = Nothing
            Me.commandBarGalleryDropDown17.Name = "commandBarGalleryDropDown17"
            ' 
            ' commandBarGalleryDropDown18
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown18.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown18.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup160.CommandName = "ChartPrimaryHorizontalAxisCommandGroup"
            spreadsheetCommandGalleryItem680.CommandName = "ChartHidePrimaryHorizontalAxis"
            spreadsheetCommandGalleryItem680.Enabled = False
            spreadsheetCommandGalleryItem680.ImageOptions.Image = CType((resources.GetObject("resource.Image486")), System.Drawing.Image)
            spreadsheetCommandGalleryItem681.CommandName = "ChartPrimaryHorizontalAxisLeftToRight"
            spreadsheetCommandGalleryItem681.Enabled = False
            spreadsheetCommandGalleryItem681.ImageOptions.Image = CType((resources.GetObject("resource.Image487")), System.Drawing.Image)
            spreadsheetCommandGalleryItem682.CommandName = "ChartPrimaryHorizontalAxisHideLabels"
            spreadsheetCommandGalleryItem682.Enabled = False
            spreadsheetCommandGalleryItem682.ImageOptions.Image = CType((resources.GetObject("resource.Image488")), System.Drawing.Image)
            spreadsheetCommandGalleryItem683.CommandName = "ChartPrimaryHorizontalAxisRightToLeft"
            spreadsheetCommandGalleryItem683.Enabled = False
            spreadsheetCommandGalleryItem683.ImageOptions.Image = CType((resources.GetObject("resource.Image489")), System.Drawing.Image)
            spreadsheetCommandGalleryItem684.CommandName = "ChartPrimaryHorizontalAxisDefault"
            spreadsheetCommandGalleryItem684.Enabled = False
            spreadsheetCommandGalleryItem684.ImageOptions.Image = CType((resources.GetObject("resource.Image490")), System.Drawing.Image)
            spreadsheetCommandGalleryItem685.CommandName = "ChartPrimaryHorizontalAxisScaleThousands"
            spreadsheetCommandGalleryItem685.Enabled = False
            spreadsheetCommandGalleryItem685.ImageOptions.Image = CType((resources.GetObject("resource.Image491")), System.Drawing.Image)
            spreadsheetCommandGalleryItem686.CommandName = "ChartPrimaryHorizontalAxisScaleMillions"
            spreadsheetCommandGalleryItem686.Enabled = False
            spreadsheetCommandGalleryItem686.ImageOptions.Image = CType((resources.GetObject("resource.Image492")), System.Drawing.Image)
            spreadsheetCommandGalleryItem687.CommandName = "ChartPrimaryHorizontalAxisScaleBillions"
            spreadsheetCommandGalleryItem687.Enabled = False
            spreadsheetCommandGalleryItem687.ImageOptions.Image = CType((resources.GetObject("resource.Image493")), System.Drawing.Image)
            spreadsheetCommandGalleryItem688.CommandName = "ChartPrimaryHorizontalAxisScaleLogarithm"
            spreadsheetCommandGalleryItem688.Enabled = False
            spreadsheetCommandGalleryItem688.ImageOptions.Image = CType((resources.GetObject("resource.Image494")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup160.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem680, spreadsheetCommandGalleryItem681, spreadsheetCommandGalleryItem682, spreadsheetCommandGalleryItem683, spreadsheetCommandGalleryItem684, spreadsheetCommandGalleryItem685, spreadsheetCommandGalleryItem686, spreadsheetCommandGalleryItem687, spreadsheetCommandGalleryItem688})
            Me.commandBarGalleryDropDown18.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup160})
            Me.commandBarGalleryDropDown18.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown18.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown18.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown18.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown18.Manager = Nothing
            Me.commandBarGalleryDropDown18.Name = "commandBarGalleryDropDown18"
            ' 
            ' commandBarGalleryDropDown19
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown19.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown19.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup161.CommandName = "ChartPrimaryVerticalAxisCommandGroup"
            spreadsheetCommandGalleryItem689.CommandName = "ChartHidePrimaryVerticalAxis"
            spreadsheetCommandGalleryItem689.Enabled = False
            spreadsheetCommandGalleryItem689.ImageOptions.Image = CType((resources.GetObject("resource.Image495")), System.Drawing.Image)
            spreadsheetCommandGalleryItem690.CommandName = "ChartPrimaryVerticalAxisLeftToRight"
            spreadsheetCommandGalleryItem690.Enabled = False
            spreadsheetCommandGalleryItem690.ImageOptions.Image = CType((resources.GetObject("resource.Image496")), System.Drawing.Image)
            spreadsheetCommandGalleryItem691.CommandName = "ChartPrimaryVerticalAxisHideLabels"
            spreadsheetCommandGalleryItem691.Enabled = False
            spreadsheetCommandGalleryItem691.ImageOptions.Image = CType((resources.GetObject("resource.Image497")), System.Drawing.Image)
            spreadsheetCommandGalleryItem692.CommandName = "ChartPrimaryVerticalAxisRightToLeft"
            spreadsheetCommandGalleryItem692.Enabled = False
            spreadsheetCommandGalleryItem692.ImageOptions.Image = CType((resources.GetObject("resource.Image498")), System.Drawing.Image)
            spreadsheetCommandGalleryItem693.CommandName = "ChartPrimaryVerticalAxisDefault"
            spreadsheetCommandGalleryItem693.Enabled = False
            spreadsheetCommandGalleryItem693.ImageOptions.Image = CType((resources.GetObject("resource.Image499")), System.Drawing.Image)
            spreadsheetCommandGalleryItem694.CommandName = "ChartPrimaryVerticalAxisScaleThousands"
            spreadsheetCommandGalleryItem694.Enabled = False
            spreadsheetCommandGalleryItem694.ImageOptions.Image = CType((resources.GetObject("resource.Image500")), System.Drawing.Image)
            spreadsheetCommandGalleryItem695.CommandName = "ChartPrimaryVerticalAxisScaleMillions"
            spreadsheetCommandGalleryItem695.Enabled = False
            spreadsheetCommandGalleryItem695.ImageOptions.Image = CType((resources.GetObject("resource.Image501")), System.Drawing.Image)
            spreadsheetCommandGalleryItem696.CommandName = "ChartPrimaryVerticalAxisScaleBillions"
            spreadsheetCommandGalleryItem696.Enabled = False
            spreadsheetCommandGalleryItem696.ImageOptions.Image = CType((resources.GetObject("resource.Image502")), System.Drawing.Image)
            spreadsheetCommandGalleryItem697.CommandName = "ChartPrimaryVerticalAxisScaleLogarithm"
            spreadsheetCommandGalleryItem697.Enabled = False
            spreadsheetCommandGalleryItem697.ImageOptions.Image = CType((resources.GetObject("resource.Image503")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup161.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem689, spreadsheetCommandGalleryItem690, spreadsheetCommandGalleryItem691, spreadsheetCommandGalleryItem692, spreadsheetCommandGalleryItem693, spreadsheetCommandGalleryItem694, spreadsheetCommandGalleryItem695, spreadsheetCommandGalleryItem696, spreadsheetCommandGalleryItem697})
            Me.commandBarGalleryDropDown19.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup161})
            Me.commandBarGalleryDropDown19.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown19.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown19.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown19.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown19.Manager = Nothing
            Me.commandBarGalleryDropDown19.Name = "commandBarGalleryDropDown19"
            ' 
            ' commandBarGalleryDropDown20
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown20.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown20.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup162.CommandName = "ChartPrimaryHorizontalGridlinesCommandGroup"
            spreadsheetCommandGalleryItem698.CommandName = "ChartPrimaryHorizontalGridlinesNone"
            spreadsheetCommandGalleryItem698.Enabled = False
            spreadsheetCommandGalleryItem698.ImageOptions.Image = CType((resources.GetObject("resource.Image504")), System.Drawing.Image)
            spreadsheetCommandGalleryItem699.CommandName = "ChartPrimaryHorizontalGridlinesMajor"
            spreadsheetCommandGalleryItem699.Enabled = False
            spreadsheetCommandGalleryItem699.ImageOptions.Image = CType((resources.GetObject("resource.Image505")), System.Drawing.Image)
            spreadsheetCommandGalleryItem700.CommandName = "ChartPrimaryHorizontalGridlinesMinor"
            spreadsheetCommandGalleryItem700.Enabled = False
            spreadsheetCommandGalleryItem700.ImageOptions.Image = CType((resources.GetObject("resource.Image506")), System.Drawing.Image)
            spreadsheetCommandGalleryItem701.CommandName = "ChartPrimaryHorizontalGridlinesMajorAndMinor"
            spreadsheetCommandGalleryItem701.Enabled = False
            spreadsheetCommandGalleryItem701.ImageOptions.Image = CType((resources.GetObject("resource.Image507")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup162.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem698, spreadsheetCommandGalleryItem699, spreadsheetCommandGalleryItem700, spreadsheetCommandGalleryItem701})
            Me.commandBarGalleryDropDown20.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup162})
            Me.commandBarGalleryDropDown20.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown20.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown20.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown20.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown20.Manager = Nothing
            Me.commandBarGalleryDropDown20.Name = "commandBarGalleryDropDown20"
            ' 
            ' commandBarGalleryDropDown21
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown21.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown21.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup163.CommandName = "ChartPrimaryVerticalGridlinesCommandGroup"
            spreadsheetCommandGalleryItem702.CommandName = "ChartPrimaryVerticalGridlinesNone"
            spreadsheetCommandGalleryItem702.Enabled = False
            spreadsheetCommandGalleryItem702.ImageOptions.Image = CType((resources.GetObject("resource.Image508")), System.Drawing.Image)
            spreadsheetCommandGalleryItem703.CommandName = "ChartPrimaryVerticalGridlinesMajor"
            spreadsheetCommandGalleryItem703.Enabled = False
            spreadsheetCommandGalleryItem703.ImageOptions.Image = CType((resources.GetObject("resource.Image509")), System.Drawing.Image)
            spreadsheetCommandGalleryItem704.CommandName = "ChartPrimaryVerticalGridlinesMinor"
            spreadsheetCommandGalleryItem704.Enabled = False
            spreadsheetCommandGalleryItem704.ImageOptions.Image = CType((resources.GetObject("resource.Image510")), System.Drawing.Image)
            spreadsheetCommandGalleryItem705.CommandName = "ChartPrimaryVerticalGridlinesMajorAndMinor"
            spreadsheetCommandGalleryItem705.Enabled = False
            spreadsheetCommandGalleryItem705.ImageOptions.Image = CType((resources.GetObject("resource.Image511")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup163.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem702, spreadsheetCommandGalleryItem703, spreadsheetCommandGalleryItem704, spreadsheetCommandGalleryItem705})
            Me.commandBarGalleryDropDown21.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup163})
            Me.commandBarGalleryDropDown21.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown21.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown21.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown21.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown21.Manager = Nothing
            Me.commandBarGalleryDropDown21.Name = "commandBarGalleryDropDown21"
            ' 
            ' commandBarGalleryDropDown22
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown22.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown22.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup164.CommandName = "ChartLinesCommandGroup"
            spreadsheetCommandGalleryItem706.CommandName = "ChartLinesNone"
            spreadsheetCommandGalleryItem706.Enabled = False
            spreadsheetCommandGalleryItem706.ImageOptions.Image = CType((resources.GetObject("resource.Image512")), System.Drawing.Image)
            spreadsheetCommandGalleryItem707.CommandName = "ChartShowDropLines"
            spreadsheetCommandGalleryItem707.Enabled = False
            spreadsheetCommandGalleryItem707.ImageOptions.Image = CType((resources.GetObject("resource.Image513")), System.Drawing.Image)
            spreadsheetCommandGalleryItem708.CommandName = "ChartShowHighLowLines"
            spreadsheetCommandGalleryItem708.Enabled = False
            spreadsheetCommandGalleryItem708.ImageOptions.Image = CType((resources.GetObject("resource.Image514")), System.Drawing.Image)
            spreadsheetCommandGalleryItem709.CommandName = "ChartShowDropLinesAndHighLowLines"
            spreadsheetCommandGalleryItem709.Enabled = False
            spreadsheetCommandGalleryItem709.ImageOptions.Image = CType((resources.GetObject("resource.Image515")), System.Drawing.Image)
            spreadsheetCommandGalleryItem710.CommandName = "ChartShowSeriesLines"
            spreadsheetCommandGalleryItem710.Enabled = False
            spreadsheetCommandGalleryItem710.ImageOptions.Image = CType((resources.GetObject("resource.Image516")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup164.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem706, spreadsheetCommandGalleryItem707, spreadsheetCommandGalleryItem708, spreadsheetCommandGalleryItem709, spreadsheetCommandGalleryItem710})
            Me.commandBarGalleryDropDown22.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup164})
            Me.commandBarGalleryDropDown22.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown22.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown22.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown22.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown22.Manager = Nothing
            Me.commandBarGalleryDropDown22.Name = "commandBarGalleryDropDown22"
            ' 
            ' commandBarGalleryDropDown23
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown23.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown23.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup165.CommandName = "ChartUpDownBarsCommandGroup"
            spreadsheetCommandGalleryItem711.CommandName = "ChartHideUpDownBars"
            spreadsheetCommandGalleryItem711.Enabled = False
            spreadsheetCommandGalleryItem711.ImageOptions.Image = CType((resources.GetObject("resource.Image517")), System.Drawing.Image)
            spreadsheetCommandGalleryItem712.CommandName = "ChartShowUpDownBars"
            spreadsheetCommandGalleryItem712.Enabled = False
            spreadsheetCommandGalleryItem712.ImageOptions.Image = CType((resources.GetObject("resource.Image518")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup165.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem711, spreadsheetCommandGalleryItem712})
            Me.commandBarGalleryDropDown23.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup165})
            Me.commandBarGalleryDropDown23.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown23.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown23.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown23.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown23.Manager = Nothing
            Me.commandBarGalleryDropDown23.Name = "commandBarGalleryDropDown23"
            ' 
            ' commandBarGalleryDropDown24
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown24.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown24.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both
            spreadsheetCommandGalleryItemGroup166.CommandName = "ChartErrorBarsCommandGroup"
            spreadsheetCommandGalleryItem713.CommandName = "ChartErrorBarsNone"
            spreadsheetCommandGalleryItem713.Enabled = False
            spreadsheetCommandGalleryItem713.ImageOptions.Image = CType((resources.GetObject("resource.Image519")), System.Drawing.Image)
            spreadsheetCommandGalleryItem714.CommandName = "ChartErrorBarsStandardError"
            spreadsheetCommandGalleryItem714.Enabled = False
            spreadsheetCommandGalleryItem714.ImageOptions.Image = CType((resources.GetObject("resource.Image520")), System.Drawing.Image)
            spreadsheetCommandGalleryItem715.CommandName = "ChartErrorBarsPercentage"
            spreadsheetCommandGalleryItem715.Enabled = False
            spreadsheetCommandGalleryItem715.ImageOptions.Image = CType((resources.GetObject("resource.Image521")), System.Drawing.Image)
            spreadsheetCommandGalleryItem716.CommandName = "ChartErrorBarsStandardDeviation"
            spreadsheetCommandGalleryItem716.Enabled = False
            spreadsheetCommandGalleryItem716.ImageOptions.Image = CType((resources.GetObject("resource.Image522")), System.Drawing.Image)
            spreadsheetCommandGalleryItemGroup166.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {spreadsheetCommandGalleryItem713, spreadsheetCommandGalleryItem714, spreadsheetCommandGalleryItem715, spreadsheetCommandGalleryItem716})
            Me.commandBarGalleryDropDown24.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {spreadsheetCommandGalleryItemGroup166})
            Me.commandBarGalleryDropDown24.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown24.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown24.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.commandBarGalleryDropDown24.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown24.Manager = Nothing
            Me.commandBarGalleryDropDown24.Name = "commandBarGalleryDropDown24"
            ' 
            ' spreadsheetDockManager1
            ' 
            Me.spreadsheetDockManager1.Form = Me
            Me.spreadsheetDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.panelContainer1})
            Me.spreadsheetDockManager1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetDockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.Controls.Add(Me.fieldListDockPanel1)
            Me.panelContainer1.Controls.Add(Me.mailMergeParametersDockPanel)
            Me.panelContainer1.Controls.Add(Me.filteringDockPanel)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.ID = New System.Guid("a9a40f94-dc0f-4f90-b029-4282846c5053")
            Me.panelContainer1.Location = New System.Drawing.Point(862, 150)
            Me.panelContainer1.Margin = New System.Windows.Forms.Padding(0)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(200, 255)
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' fieldListDockPanel1
            ' 
            Me.fieldListDockPanel1.Controls.Add(Me.fieldListDockPanel1_Container)
            Me.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.fieldListDockPanel1.ID = New System.Guid("6b098cf1-bd50-44c1-a93a-38b0a4bce017")
            Me.fieldListDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.fieldListDockPanel1.Name = "fieldListDockPanel1"
            Me.fieldListDockPanel1.OriginalSize = New System.Drawing.Size(200, 87)
            Me.fieldListDockPanel1.Size = New System.Drawing.Size(200, 85)
            Me.fieldListDockPanel1.SpreadsheetControl = Me.spreadsheetControl1
            ' 
            ' fieldListDockPanel1_Container
            ' 
            Me.fieldListDockPanel1_Container.Location = New System.Drawing.Point(4, 26)
            Me.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
            Me.fieldListDockPanel1_Container.Size = New System.Drawing.Size(193, 55)
            Me.fieldListDockPanel1_Container.TabIndex = 0
            ' 
            ' mailMergeParametersDockPanel
            ' 
            Me.mailMergeParametersDockPanel.Controls.Add(Me.mailMergeParametersDockPanel1_Container)
            Me.mailMergeParametersDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.mailMergeParametersDockPanel.ID = New System.Guid("09c84a14-2284-4751-b3f0-df4853bb164f")
            Me.mailMergeParametersDockPanel.Location = New System.Drawing.Point(0, 85)
            Me.mailMergeParametersDockPanel.Name = "mailMergeParametersDockPanel"
            Me.mailMergeParametersDockPanel.OriginalSize = New System.Drawing.Size(200, 87)
            Me.mailMergeParametersDockPanel.Size = New System.Drawing.Size(200, 85)
            Me.mailMergeParametersDockPanel.SpreadsheetControl = Me.spreadsheetControl1
            ' 
            ' mailMergeParametersDockPanel1_Container
            ' 
            Me.mailMergeParametersDockPanel1_Container.Location = New System.Drawing.Point(4, 26)
            Me.mailMergeParametersDockPanel1_Container.Name = "mailMergeParametersDockPanel1_Container"
            Me.mailMergeParametersDockPanel1_Container.Size = New System.Drawing.Size(193, 55)
            Me.mailMergeParametersDockPanel1_Container.TabIndex = 0
            ' 
            ' filteringDockPanel
            ' 
            Me.filteringDockPanel.Controls.Add(Me.dockPanel1_Container)
            Me.filteringDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.filteringDockPanel.ID = New System.Guid("3fa0b467-3f8b-40ff-9387-ffbd4a309a03")
            Me.filteringDockPanel.Location = New System.Drawing.Point(0, 170)
            Me.filteringDockPanel.Name = "filteringDockPanel"
            Me.filteringDockPanel.Options.ShowAutoHideButton = False
            Me.filteringDockPanel.Options.ShowCloseButton = False
            Me.filteringDockPanel.Options.ShowMaximizeButton = False
            Me.filteringDockPanel.OriginalSize = New System.Drawing.Size(200, 88)
            Me.filteringDockPanel.Size = New System.Drawing.Size(200, 85)
            Me.filteringDockPanel.Text = "Filter Templates"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Controls.Add(Me.checkEdit0)
            Me.dockPanel1_Container.Controls.Add(Me.checkEdit1)
            Me.dockPanel1_Container.Controls.Add(Me.checkEdit2)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(193, 56)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' checkEdit0
            ' 
            Me.checkEdit0.EditValue = True
            Me.checkEdit0.Location = New System.Drawing.Point(3, 3)
            Me.checkEdit0.Name = "checkEdit0"
            Me.checkEdit0.Properties.Caption = "Sales Manager"
            Me.checkEdit0.Size = New System.Drawing.Size(174, 20)
            Me.checkEdit0.TabIndex = 7
            AddHandler Me.checkEdit0.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit_CheckedChanged)
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.EditValue = True
            Me.checkEdit1.Location = New System.Drawing.Point(3, 28)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Inside Sales Coordinator"
            Me.checkEdit1.Size = New System.Drawing.Size(174, 20)
            Me.checkEdit1.TabIndex = 8
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit_CheckedChanged)
            ' 
            ' checkEdit2
            ' 
            Me.checkEdit2.EditValue = True
            Me.checkEdit2.Location = New System.Drawing.Point(3, 53)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Sales Representative"
            Me.checkEdit2.Size = New System.Drawing.Size(174, 20)
            Me.checkEdit2.TabIndex = 9
            AddHandler Me.checkEdit2.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit_CheckedChanged)
            ' 
            ' mailMergeBindingRibbonPageGroup1
            ' 
            Me.mailMergeBindingRibbonPageGroup1.Name = "mailMergeBindingRibbonPageGroup1"
            Me.mailMergeBindingRibbonPageGroup1.Text = ""
            ' 
            ' spreadsheetFormulaBar1
            ' 
            Me.spreadsheetFormulaBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.spreadsheetFormulaBar1.Location = New System.Drawing.Point(0, 150)
            Me.spreadsheetFormulaBar1.MinimumSize = New System.Drawing.Size(0, 24)
            Me.spreadsheetFormulaBar1.Name = "spreadsheetFormulaBar1"
            Me.spreadsheetFormulaBar1.Size = New System.Drawing.Size(862, 24)
            Me.spreadsheetFormulaBar1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetFormulaBar1.TabIndex = 6
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitterControl1.Location = New System.Drawing.Point(0, 174)
            Me.splitterControl1.MinSize = 20
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(862, 10)
            Me.splitterControl1.TabIndex = 5
            Me.splitterControl1.TabStop = False
            ' 
            ' spreadsheetBarController1
            ' 
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem16)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem17)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem18)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem19)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem20)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem21)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem22)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem23)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem24)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem25)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem26)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem27)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem28)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem29)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem30)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeBorderLineColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeBorderLineStyleItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeCellFillColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem31)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem32)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem33)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem34)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem35)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeNumberFormatItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem36)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem37)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem38)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem39)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem40)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem41)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem42)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem43)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem44)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem45)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem46)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem47)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem48)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem49)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem50)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem51)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem52)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem53)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem54)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem55)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem56)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem57)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem58)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem59)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem60)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem61)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem62)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.galleryFormatAsTableItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem63)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem64)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem65)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem66)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem67)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem68)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem69)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem70)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem71)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem72)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem73)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem74)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem75)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem76)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem77)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem78)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem79)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem80)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem81)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem82)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem83)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem84)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem85)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem86)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem87)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem88)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem89)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeSheetTabColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem90)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem91)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem92)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem93)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem94)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem95)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem96)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem97)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem98)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem99)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem100)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem101)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem102)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem103)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem104)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem105)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem106)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem107)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem108)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem109)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem110)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem111)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem112)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem113)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem114)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem115)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem116)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem117)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem16)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem118)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem119)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem120)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem121)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem122)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem16)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem17)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem123)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem17)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem18)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem19)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem18)
            Me.spreadsheetBarController1.BarItems.Add(Me.pageSetupPaperKindItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem124)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem125)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem126)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem19)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem127)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem20)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem21)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem22)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem23)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem128)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem129)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem20)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem130)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem131)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem21)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem22)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsFinancialItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsLogicalItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsTextItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsDateAndTimeItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsLookupAndReferenceItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsMathAndTrigonometryItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsStatisticalItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsEngineeringItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsInformationItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsCompatibilityItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.functionsWebItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem23)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem132)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem133)
            Me.spreadsheetBarController1.BarItems.Add(Me.definedNameListItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem134)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem24)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem25)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem26)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem24)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem135)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem136)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem137)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem138)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem139)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem25)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem140)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem141)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem26)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem142)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem143)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem27)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem144)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem145)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem146)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem147)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem148)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem149)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem150)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem151)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem152)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem153)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem154)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem155)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem156)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem157)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem158)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem159)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem160)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem161)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem162)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem28)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem163)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem164)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem165)
            Me.spreadsheetBarController1.BarItems.Add(Me.galleryChartLayoutItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.galleryChartStyleItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem166)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem29)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem16)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem30)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem17)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem18)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem19)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem31)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem20)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem21)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem22)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem23)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem24)
            Me.spreadsheetBarController1.BarItems.Add(Me.renameTableItemCaption1)
            Me.spreadsheetBarController1.BarItems.Add(Me.renameTableItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem27)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem28)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem29)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem30)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem31)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem32)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem33)
            Me.spreadsheetBarController1.BarItems.Add(Me.galleryTableStylesItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem167)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem168)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem169)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem170)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem171)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem172)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem173)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem174)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem175)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem32)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem176)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem177)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem178)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem33)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem179)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem180)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem181)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem34)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem182)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem183)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem184)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem185)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem186)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem35)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem34)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem35)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem36)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem187)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem188)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem189)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem36)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem190)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem191)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem192)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem193)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem37)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem194)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem195)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem196)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem197)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem198)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem38)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem199)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem200)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem39)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem37)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem38)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem39)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem40)
            Me.spreadsheetBarController1.BarItems.Add(Me.galleryPivotStylesItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem201)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem202)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem203)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem40)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem204)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem205)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem206)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem41)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem41)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem42)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem43)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem44)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem45)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem42)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem207)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem208)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem209)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem210)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem211)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem43)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem212)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem213)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem214)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem215)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem216)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem217)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem46)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem218)
            Me.spreadsheetBarController1.BarItems.Add(Me.endModeInfoStaticItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.averageInfoStaticItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.countInfoStaticItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.numericalCountInfoStaticItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.minInfoStaticItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.maxInfoStaticItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.sumInfoStaticItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.zoomEditItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.showZoomButtonItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.progressBarItem1)
            Me.spreadsheetBarController1.Control = Me.spreadsheetControl1
            ' 
            ' MailMergeModuleBase
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.spreadsheetControl1)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.spreadsheetFormulaBar1)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Name = "MailMergeModuleBase"
            Me.Size = New System.Drawing.Size(1062, 432)
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown50), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpreadsheetFontSizeEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown73), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPopupGalleryEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown74), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown75), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown76), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown77), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown78), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown79), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown80), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown81), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown82), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown83), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown84), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown85), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown86), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown87), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown88), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown89), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown90), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown91), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown92), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown93), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown94), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown95), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown96), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown97), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown98), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemZoomTrackBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown49), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown51), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown52), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown53), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown54), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown55), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown56), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown57), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown58), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown59), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown60), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown61), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown62), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown63), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown64), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown65), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown66), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown67), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown68), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown69), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown70), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown71), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown72), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown26), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown25), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown27), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown28), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown29), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown30), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown31), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown32), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown33), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown34), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown35), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown36), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown37), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown38), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown39), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown40), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown41), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown42), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown43), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown44), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown45), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown46), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown47), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown48), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown16), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown17), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown18), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown20), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown21), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown22), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown23), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown24), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spreadsheetDockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer1.ResumeLayout(False)
            Me.fieldListDockPanel1.ResumeLayout(False)
            Me.mailMergeParametersDockPanel.ResumeLayout(False)
            Me.filteringDockPanel.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            CType((Me.checkEdit0.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spreadsheetBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private components As System.ComponentModel.IContainer

        Private spreadsheetDockManager1 As DevExpress.XtraSpreadsheet.SpreadsheetDockManager

        Private fieldListDockPanel1 As DevExpress.XtraSpreadsheet.FieldListDockPanel

        Private fieldListDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel

        Private commandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown6 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown7 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown8 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown9 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown10 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown11 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown12 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown13 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown14 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown15 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown16 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown17 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown18 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown19 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown20 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown21 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown22 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown23 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown24 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private mailMergeParametersDockPanel As DevExpress.XtraSpreadsheet.MailMergeParametersDockPanel

        Private mailMergeParametersDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private filteringDockPanel As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private checkEdit0 As DevExpress.XtraEditors.CheckEdit

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private checkEdit2 As DevExpress.XtraEditors.CheckEdit

        Private commandBarGalleryDropDown25 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown26 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown27 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown28 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown29 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown30 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown31 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown32 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown33 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown34 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown35 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown36 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown37 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown38 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown39 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown40 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown41 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown42 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown43 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown44 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown45 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown46 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown47 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown48 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private mailMergeBindingRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeBindingRibbonPageGroup

        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl

        Private commandBarGalleryDropDown49 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown50 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown51 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown52 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown53 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown54 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown55 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown56 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown57 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown58 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown59 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown60 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown61 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown62 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown63 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown64 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown65 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown66 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown67 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown68 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown69 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown70 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown71 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private commandBarGalleryDropDown72 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl

        Private spreadsheetFormulaBar1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private spreadsheetCommandBarButtonItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup

        Private changeFontNameItem1 As DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem

        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit

        Private changeFontSizeItem1 As DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem

        Private repositoryItemSpreadsheetFontSizeEdit1 As DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit

        Private spreadsheetCommandBarButtonItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup

        Private spreadsheetCommandBarCheckItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup

        Private spreadsheetCommandBarSubItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem25 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem26 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem27 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem28 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem29 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem30 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private changeBorderLineColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem

        Private changeBorderLineStyleItem1 As DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem

        Private commandBarGalleryDropDown73 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup

        Private changeCellFillColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem

        Private changeFontColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem

        Private barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup

        Private spreadsheetCommandBarCheckItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup

        Private spreadsheetCommandBarCheckItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup

        Private spreadsheetCommandBarButtonItem31 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem32 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarCheckItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarSubItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarCheckItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarButtonItem33 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem34 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem35 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private barButtonGroup8 As DevExpress.XtraBars.BarButtonGroup

        Private changeNumberFormatItem1 As DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem

        Private repositoryItemPopupGalleryEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit

        Private barButtonGroup9 As DevExpress.XtraBars.BarButtonGroup

        Private spreadsheetCommandBarSubItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem36 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem37 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem38 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem39 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem40 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem41 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem42 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem43 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private barButtonGroup10 As DevExpress.XtraBars.BarButtonGroup

        Private spreadsheetCommandBarButtonItem44 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem45 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarSubItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem46 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem47 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem48 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem49 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem50 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem51 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem52 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem53 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem54 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem55 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem56 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem57 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem58 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonGalleryDropDownItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown74 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown75 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown76 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonItem59 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem60 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem61 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem62 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private galleryFormatAsTableItem1 As DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem

        Private commandBarGalleryDropDown77 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private galleryChangeStyleItem1 As DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem

        Private spreadsheetCommandBarSubItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem63 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem64 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem65 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem66 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem67 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem68 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem69 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem70 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem71 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem72 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem73 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem74 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem75 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem76 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem77 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem78 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem79 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem80 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem81 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem82 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem83 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem84 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem85 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem86 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem87 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem88 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem89 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private changeSheetTabColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem

        Private spreadsheetCommandBarButtonItem90 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarCheckItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarButtonItem91 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem92 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem93 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem94 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem95 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem96 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem97 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem98 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem99 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem100 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem101 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem102 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem103 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem104 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem105 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem106 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem107 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem108 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarCheckItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarButtonItem109 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem110 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem111 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem112 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem113 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem114 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem115 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem116 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem117 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem118 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem119 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem120 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonGalleryDropDownItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown78 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown79 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown80 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown81 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown82 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown83 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown84 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown85 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown86 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonItem121 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem122 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarCheckItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarButtonItem123 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarCheckItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private pageSetupPaperKindItem1 As DevExpress.XtraSpreadsheet.UI.PageSetupPaperKindItem

        Private spreadsheetCommandBarSubItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem124 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem125 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem126 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem127 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarCheckItem20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarSubItem20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem128 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem129 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem130 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem131 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private functionsFinancialItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsFinancialItem

        Private functionsLogicalItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsLogicalItem

        Private functionsTextItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsTextItem

        Private functionsDateAndTimeItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsDateAndTimeItem

        Private functionsLookupAndReferenceItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsLookupAndReferenceItem

        Private functionsMathAndTrigonometryItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsMathAndTrigonometryItem

        Private spreadsheetCommandBarSubItem23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private functionsStatisticalItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsStatisticalItem

        Private functionsEngineeringItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsEngineeringItem

        Private functionsInformationItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsInformationItem

        Private functionsCompatibilityItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsCompatibilityItem

        Private functionsWebItem1 As DevExpress.XtraSpreadsheet.UI.FunctionsWebItem

        Private spreadsheetCommandBarButtonItem132 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem133 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private definedNameListItem1 As DevExpress.XtraSpreadsheet.UI.DefinedNameListItem

        Private spreadsheetCommandBarButtonItem134 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarCheckItem24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarSubItem24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarCheckItem25 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem26 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarButtonItem135 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem136 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem25 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem137 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem138 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem139 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem26 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem140 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem141 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem27 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem142 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem143 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem144 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem145 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem146 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem147 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem148 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem149 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem150 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem151 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem152 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem153 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem154 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem155 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem156 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem157 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem158 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem28 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem159 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem160 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem161 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem162 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem163 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem164 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem165 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private galleryChartLayoutItem1 As DevExpress.XtraSpreadsheet.UI.GalleryChartLayoutItem

        Private galleryChartStyleItem1 As DevExpress.XtraSpreadsheet.UI.GalleryChartStyleItem

        Private spreadsheetCommandBarButtonItem166 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem29 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonGalleryDropDownItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown87 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown88 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarSubItem30 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonGalleryDropDownItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown89 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown90 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown91 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarSubItem31 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonGalleryDropDownItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown92 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown93 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown94 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown95 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown96 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown97 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private spreadsheetCommandBarButtonGalleryDropDownItem24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem

        Private commandBarGalleryDropDown98 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private renameTableItemCaption1 As DevExpress.XtraSpreadsheet.UI.RenameTableItemCaption

        Private renameTableItem1 As DevExpress.XtraSpreadsheet.UI.RenameTableItem

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private spreadsheetCommandBarCheckItem27 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem28 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem29 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem30 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem31 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem32 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem33 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private galleryTableStylesItem1 As DevExpress.XtraSpreadsheet.UI.GalleryTableStylesItem

        Private spreadsheetCommandBarButtonItem167 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem168 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem169 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem170 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem171 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem172 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem173 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem32 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem174 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem175 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem176 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem33 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem177 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem178 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem34 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem179 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem180 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem181 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem182 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem35 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem183 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem184 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem185 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem186 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarCheckItem34 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem35 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem36 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarSubItem36 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem187 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem188 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem189 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem37 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem190 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem191 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem192 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem193 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem38 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem194 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem195 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem196 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem197 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem198 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem39 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem199 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem200 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarCheckItem37 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem38 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem39 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem40 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private galleryPivotStylesItem1 As DevExpress.XtraSpreadsheet.UI.GalleryPivotStylesItem

        Private spreadsheetCommandBarButtonItem201 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem40 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem202 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem203 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem41 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem204 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem205 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem206 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarCheckItem41 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem42 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem43 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarSubItem42 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarCheckItem44 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarCheckItem45 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarButtonItem207 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem208 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem209 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarSubItem43 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem

        Private spreadsheetCommandBarButtonItem210 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem211 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem212 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem213 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem214 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem215 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem216 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarButtonItem217 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private spreadsheetCommandBarCheckItem46 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem

        Private spreadsheetCommandBarButtonItem218 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem

        Private endModeInfoStaticItem1 As DevExpress.XtraSpreadsheet.UI.EndModeInfoStaticItem

        Private averageInfoStaticItem1 As DevExpress.XtraSpreadsheet.UI.AverageInfoStaticItem

        Private countInfoStaticItem1 As DevExpress.XtraSpreadsheet.UI.CountInfoStaticItem

        Private numericalCountInfoStaticItem1 As DevExpress.XtraSpreadsheet.UI.NumericalCountInfoStaticItem

        Private minInfoStaticItem1 As DevExpress.XtraSpreadsheet.UI.MinInfoStaticItem

        Private maxInfoStaticItem1 As DevExpress.XtraSpreadsheet.UI.MaxInfoStaticItem

        Private sumInfoStaticItem1 As DevExpress.XtraSpreadsheet.UI.SumInfoStaticItem

        Private zoomEditItem1 As DevExpress.XtraSpreadsheet.UI.ZoomEditItem

        Private repositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar

        Private showZoomButtonItem1 As DevExpress.XtraSpreadsheet.UI.ShowZoomButtonItem

        Private chartToolsRibbonPageCategory1 As DevExpress.XtraSpreadsheet.UI.ChartToolsRibbonPageCategory

        Private chartsDesignRibbonPage1 As DevExpress.XtraSpreadsheet.UI.ChartsDesignRibbonPage

        Private chartsDesignTypeRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChartsDesignTypeRibbonPageGroup

        Private chartsDesignDataRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChartsDesignDataRibbonPageGroup

        Private chartsDesignLayoutsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChartsDesignLayoutsRibbonPageGroup

        Private chartsDesignStylesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChartsDesignStylesRibbonPageGroup

        Private chartsDesignLocationRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChartsDesignLocationRibbonPageGroup

        Private chartsLayoutRibbonPage1 As DevExpress.XtraSpreadsheet.UI.ChartsLayoutRibbonPage

        Private chartsLayoutAxesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChartsLayoutAxesRibbonPageGroup

        Private chartsLayoutLabelsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChartsLayoutLabelsRibbonPageGroup

        Private chartsLayoutAnalysisRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChartsLayoutAnalysisRibbonPageGroup

        Private chartsFormatRibbonPage1 As DevExpress.XtraSpreadsheet.UI.ChartsFormatRibbonPage

        Private chartsFormatArrangeRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChartsFormatArrangeRibbonPageGroup

        Private tableToolsRibbonPageCategory1 As DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageCategory

        Private tableToolsDesignRibbonPage1 As DevExpress.XtraSpreadsheet.UI.TableToolsDesignRibbonPage

        Private tablePropertiesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.TablePropertiesRibbonPageGroup

        Private tableToolsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.TableToolsRibbonPageGroup

        Private tableStyleOptionsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.TableStyleOptionsRibbonPageGroup

        Private tableStylesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.TableStylesRibbonPageGroup

        Private drawingToolsRibbonPageCategory1 As DevExpress.XtraSpreadsheet.UI.DrawingToolsRibbonPageCategory

        Private drawingFormatRibbonPage1 As DevExpress.XtraSpreadsheet.UI.DrawingFormatRibbonPage

        Private drawingFormatArrangeRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.DrawingFormatArrangeRibbonPageGroup

        Private pictureToolsRibbonPageCategory1 As DevExpress.XtraSpreadsheet.UI.PictureToolsRibbonPageCategory

        Private pictureFormatRibbonPage1 As DevExpress.XtraSpreadsheet.UI.PictureFormatRibbonPage

        Private pictureFormatArrangeRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PictureFormatArrangeRibbonPageGroup

        Private pivotTableToolsRibbonPageCategory1 As DevExpress.XtraSpreadsheet.UI.PivotTableToolsRibbonPageCategory

        Private pivotTableAnalyzeRibbonPage1 As DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeRibbonPage

        Private pivotTableAnalyzePivotTableRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzePivotTableRibbonPageGroup

        Private pivotTableAnalyzeActiveFieldRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeActiveFieldRibbonPageGroup

        Private pivotTableAnalyzeGroupRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeGroupRibbonPageGroup

        Private pivotTableAnalyzeDataRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeDataRibbonPageGroup

        Private pivotTableAnalyzeActionsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeActionsRibbonPageGroup

        Private pivotTableAnalyzeCalculationsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeCalculationsRibbonPageGroup

        Private pivotTableAnalyzeShowRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PivotTableAnalyzeShowRibbonPageGroup

        Private pivotTableDesignRibbonPage1 As DevExpress.XtraSpreadsheet.UI.PivotTableDesignRibbonPage

        Private pivotTableDesignLayoutRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PivotTableDesignLayoutRibbonPageGroup

        Private pivotTableDesignPivotTableStyleOptionsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PivotTableDesignPivotTableStyleOptionsRibbonPageGroup

        Private pivotTableDesignPivotTableStylesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PivotTableDesignPivotTableStylesRibbonPageGroup

        Private fileRibbonPage1 As DevExpress.XtraSpreadsheet.UI.FileRibbonPage

        Private commonRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup

        Private infoRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup

        Private homeRibbonPage1 As DevExpress.XtraSpreadsheet.UI.HomeRibbonPage

        Private clipboardRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup

        Private fontRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup

        Private alignmentRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup

        Private numberRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup

        Private stylesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup

        Private cellsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup

        Private editingRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup

        Private insertRibbonPage1 As DevExpress.XtraSpreadsheet.UI.InsertRibbonPage

        Private tablesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.TablesRibbonPageGroup

        Private illustrationsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.IllustrationsRibbonPageGroup

        Private chartsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChartsRibbonPageGroup

        Private linksRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.LinksRibbonPageGroup

        Private symbolsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.SymbolsRibbonPageGroup

        Private pageLayoutRibbonPage1 As DevExpress.XtraSpreadsheet.UI.PageLayoutRibbonPage

        Private pageSetupRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PageSetupRibbonPageGroup

        Private pageSetupShowRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PageSetupShowRibbonPageGroup

        Private pageSetupPrintRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.PageSetupPrintRibbonPageGroup

        Private arrangeRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ArrangeRibbonPageGroup

        Private formulasRibbonPage1 As DevExpress.XtraSpreadsheet.UI.FormulasRibbonPage

        Private functionLibraryRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.FunctionLibraryRibbonPageGroup

        Private formulaDefinedNamesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.FormulaDefinedNamesRibbonPageGroup

        Private formulaAuditingRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.FormulaAuditingRibbonPageGroup

        Private formulaCalculationRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.FormulaCalculationRibbonPageGroup

        Private dataRibbonPage1 As DevExpress.XtraSpreadsheet.UI.DataRibbonPage

        Private sortAndFilterRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.SortAndFilterRibbonPageGroup

        Private dataToolsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.DataToolsRibbonPageGroup

        Private outlineRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.OutlineRibbonPageGroup

        Private reviewRibbonPage1 As DevExpress.XtraSpreadsheet.UI.ReviewRibbonPage

        Private commentsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CommentsRibbonPageGroup

        Private changesRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ChangesRibbonPageGroup

        Private viewRibbonPage1 As DevExpress.XtraSpreadsheet.UI.ViewRibbonPage

        Private showRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ShowRibbonPageGroup

        Private zoomRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.ZoomRibbonPageGroup

        Private windowRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.WindowRibbonPageGroup

        Private mailMergeRibbonPage1 As DevExpress.XtraSpreadsheet.UI.MailMergeRibbonPage

        Private mailMergeDataRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeDataRibbonPageGroup

        Private mailMergeModeRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeModeRibbonPageGroup

        Private mailMergeExtendedRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeExtendedRibbonPageGroup

        Private mailMergeGroupingRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeGroupingRibbonPageGroup

        Private mailMergeFilteringRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeFilteringRibbonPageGroup

        Private mailMergeBindingRibbonPageGroup2 As DevExpress.XtraSpreadsheet.UI.MailMergeBindingRibbonPageGroup

        Private spreadsheetBarController1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController

        Private progressBarItem1 As DevExpress.XtraSpreadsheet.UI.ProgressBarItem

        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    End Class
End Namespace
