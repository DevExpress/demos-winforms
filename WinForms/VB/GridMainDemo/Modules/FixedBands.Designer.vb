Namespace DevExpress.XtraGrid.Demos

    Partial Class FixedBands

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.FixedBands))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dataTable = New System.Data.DataTable()
            Me.dcMaker = New System.Data.DataColumn()
            Me.dcYear1992 = New System.Data.DataColumn()
            Me.dcYear1993 = New System.Data.DataColumn()
            Me.dcYear1994 = New System.Data.DataColumn()
            Me.dcYear1995 = New System.Data.DataColumn()
            Me.dcYear1996 = New System.Data.DataColumn()
            Me.dcYear1997 = New System.Data.DataColumn()
            Me.dcYear1998 = New System.Data.DataColumn()
            Me.dcYear1999 = New System.Data.DataColumn()
            Me.dcYear2000 = New System.Data.DataColumn()
            Me.gcTotal = New System.Data.DataColumn()
            Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
            Me.gbManufacture = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.grColumnMaker = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gbYear = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.grColumnYear1992 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.grColumnYear1993 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.grColumnYear1994 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.grColumnYear1995 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.grColumnYear1996 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.grColumnYear1997 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.grColumnYear1998 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.grColumnYear1999 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.grColumnYear2000 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gbTotals = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.grColumnUnitSold = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.dataSet = New System.Data.DataSet()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.icbFixedStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbBand = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.dsContacts1 = New DevExpress.XtraGrid.Demos.dsContacts()
            Me.bandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
            Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colCustomerName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colYear = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colJanuary = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colFebruary = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colMarch = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colApril = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colMay = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colJune = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colJuly = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colAugust = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colSeptember = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colOctober = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colNovember = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colDecember = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colRowSum = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colRowAvr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.cbShowMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.numFixedLineWidth = New DevExpress.XtraEditors.SpinEdit()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bandedGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType((Me.icbFixedStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbBand.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage2.SuspendLayout()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsContacts1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bandedGridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.cbShowMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.numFixedLineWidth.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dataTable
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.bandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bandedGridView1})
            ' 
            ' dataTable
            ' 
            Me.dataTable.Columns.AddRange(New System.Data.DataColumn() {Me.dcMaker, Me.dcYear1992, Me.dcYear1993, Me.dcYear1994, Me.dcYear1995, Me.dcYear1996, Me.dcYear1997, Me.dcYear1998, Me.dcYear1999, Me.dcYear2000, Me.gcTotal})
            Me.dataTable.TableName = "Table"
            ' 
            ' dcMaker
            ' 
            Me.dcMaker.ColumnName = "Maker"
            ' 
            ' dcYear1992
            ' 
            Me.dcYear1992.ColumnName = "Year1992"
            Me.dcYear1992.DataType = GetType(Integer)
            ' 
            ' dcYear1993
            ' 
            Me.dcYear1993.ColumnName = "Year1993"
            Me.dcYear1993.DataType = GetType(Integer)
            ' 
            ' dcYear1994
            ' 
            Me.dcYear1994.ColumnName = "Year1994"
            Me.dcYear1994.DataType = GetType(Integer)
            ' 
            ' dcYear1995
            ' 
            Me.dcYear1995.ColumnName = "Year1995"
            Me.dcYear1995.DataType = GetType(Integer)
            ' 
            ' dcYear1996
            ' 
            Me.dcYear1996.ColumnName = "Year1996"
            Me.dcYear1996.DataType = GetType(Integer)
            ' 
            ' dcYear1997
            ' 
            Me.dcYear1997.ColumnName = "Year1997"
            Me.dcYear1997.DataType = GetType(Integer)
            ' 
            ' dcYear1998
            ' 
            Me.dcYear1998.ColumnName = "Year1998"
            Me.dcYear1998.DataType = GetType(Integer)
            ' 
            ' dcYear1999
            ' 
            Me.dcYear1999.ColumnName = "Year1999"
            Me.dcYear1999.DataType = GetType(Integer)
            ' 
            ' dcYear2000
            ' 
            Me.dcYear2000.ColumnName = "Year2000"
            Me.dcYear2000.DataType = GetType(Integer)
            ' 
            ' gcTotal
            ' 
            Me.gcTotal.ColumnName = "Total"
            Me.gcTotal.DataType = GetType(Integer)
            Me.gcTotal.[ReadOnly] = True
            ' 
            ' bandedGridView1
            ' 
            Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gbManufacture, Me.gbYear, Me.gbTotals})
            Me.bandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.bandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.grColumnMaker, Me.grColumnYear1992, Me.grColumnYear1993, Me.grColumnYear1994, Me.grColumnYear1995, Me.grColumnYear1996, Me.grColumnYear1997, Me.grColumnYear1998, Me.grColumnYear1999, Me.grColumnYear2000, Me.grColumnUnitSold})
            Me.bandedGridView1.GridControl = Me.gridControl1
            Me.bandedGridView1.Images = Me.imageCollection1
            Me.bandedGridView1.Name = "bandedGridView1"
            Me.bandedGridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.bandedGridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.bandedGridView1.OptionsCustomization.AllowFilter = False
            Me.bandedGridView1.OptionsMenu.EnableFooterMenu = False
            Me.bandedGridView1.OptionsPrint.AutoWidth = False
            Me.bandedGridView1.OptionsView.ColumnAutoWidth = False
            Me.bandedGridView1.OptionsView.ShowFooter = True
            Me.bandedGridView1.OptionsView.ShowGroupPanel = False
            Me.bandedGridView1.OptionsView.ShowIndicator = False
            ' 
            ' gbManufacture
            ' 
            resources.ApplyResources(Me.gbManufacture, "gbManufacture")
            Me.gbManufacture.Columns.Add(Me.grColumnMaker)
            Me.gbManufacture.OptionsBand.AllowHotTrack = False
            Me.gbManufacture.OptionsBand.AllowMove = False
            Me.gbManufacture.OptionsBand.AllowPress = False
            Me.gbManufacture.OptionsBand.ShowInCustomizationForm = False
            Me.gbManufacture.VisibleIndex = 0
            ' 
            ' grColumnMaker
            ' 
            Me.grColumnMaker.AppearanceCell.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((235)))))), (CInt(((CByte((237)))))), (CInt(((CByte((212)))))))
            Me.grColumnMaker.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((0)))))), (CInt(((CByte((0)))))))
            Me.grColumnMaker.AppearanceCell.Options.UseBackColor = True
            Me.grColumnMaker.AppearanceCell.Options.UseForeColor = True
            resources.ApplyResources(Me.grColumnMaker, "grColumnMaker")
            Me.grColumnMaker.FieldName = "Maker"
            Me.grColumnMaker.Name = "grColumnMaker"
            ' 
            ' gbYear
            ' 
            resources.ApplyResources(Me.gbYear, "gbYear")
            Me.gbYear.Columns.Add(Me.grColumnYear1992)
            Me.gbYear.Columns.Add(Me.grColumnYear1993)
            Me.gbYear.Columns.Add(Me.grColumnYear1994)
            Me.gbYear.Columns.Add(Me.grColumnYear1995)
            Me.gbYear.Columns.Add(Me.grColumnYear1996)
            Me.gbYear.Columns.Add(Me.grColumnYear1997)
            Me.gbYear.Columns.Add(Me.grColumnYear1998)
            Me.gbYear.Columns.Add(Me.grColumnYear1999)
            Me.gbYear.Columns.Add(Me.grColumnYear2000)
            Me.gbYear.OptionsBand.AllowHotTrack = False
            Me.gbYear.OptionsBand.AllowMove = False
            Me.gbYear.OptionsBand.AllowPress = False
            Me.gbYear.OptionsBand.ShowInCustomizationForm = False
            Me.gbYear.VisibleIndex = 1
            ' 
            ' grColumnYear1992
            ' 
            resources.ApplyResources(Me.grColumnYear1992, "grColumnYear1992")
            Me.grColumnYear1992.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.grColumnYear1992.DisplayFormat.FormatString = "### ### ###"
            Me.grColumnYear1992.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.grColumnYear1992.FieldName = "Year1992"
            Me.grColumnYear1992.Name = "grColumnYear1992"
            Me.grColumnYear1992.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("grColumnYear1992.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("grColumnYear1992.Summary1"), resources.GetString("grColumnYear1992.Summary2"))})
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' grColumnYear1993
            ' 
            resources.ApplyResources(Me.grColumnYear1993, "grColumnYear1993")
            Me.grColumnYear1993.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.grColumnYear1993.DisplayFormat.FormatString = "### ### ###"
            Me.grColumnYear1993.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.grColumnYear1993.FieldName = "Year1993"
            Me.grColumnYear1993.Name = "grColumnYear1993"
            Me.grColumnYear1993.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("grColumnYear1993.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("grColumnYear1993.Summary1"), resources.GetString("grColumnYear1993.Summary2"))})
            ' 
            ' grColumnYear1994
            ' 
            resources.ApplyResources(Me.grColumnYear1994, "grColumnYear1994")
            Me.grColumnYear1994.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.grColumnYear1994.DisplayFormat.FormatString = "### ### ###"
            Me.grColumnYear1994.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.grColumnYear1994.FieldName = "Year1994"
            Me.grColumnYear1994.Name = "grColumnYear1994"
            Me.grColumnYear1994.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("grColumnYear1994.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("grColumnYear1994.Summary1"), resources.GetString("grColumnYear1994.Summary2"))})
            ' 
            ' grColumnYear1995
            ' 
            resources.ApplyResources(Me.grColumnYear1995, "grColumnYear1995")
            Me.grColumnYear1995.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.grColumnYear1995.DisplayFormat.FormatString = "### ### ###"
            Me.grColumnYear1995.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.grColumnYear1995.FieldName = "Year1995"
            Me.grColumnYear1995.Name = "grColumnYear1995"
            Me.grColumnYear1995.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("grColumnYear1995.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("grColumnYear1995.Summary1"), resources.GetString("grColumnYear1995.Summary2"))})
            ' 
            ' grColumnYear1996
            ' 
            resources.ApplyResources(Me.grColumnYear1996, "grColumnYear1996")
            Me.grColumnYear1996.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.grColumnYear1996.DisplayFormat.FormatString = "### ### ###"
            Me.grColumnYear1996.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.grColumnYear1996.FieldName = "Year1996"
            Me.grColumnYear1996.Name = "grColumnYear1996"
            Me.grColumnYear1996.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("grColumnYear1996.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("grColumnYear1996.Summary1"), resources.GetString("grColumnYear1996.Summary2"))})
            ' 
            ' grColumnYear1997
            ' 
            resources.ApplyResources(Me.grColumnYear1997, "grColumnYear1997")
            Me.grColumnYear1997.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.grColumnYear1997.DisplayFormat.FormatString = "### ### ###"
            Me.grColumnYear1997.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.grColumnYear1997.FieldName = "Year1997"
            Me.grColumnYear1997.Name = "grColumnYear1997"
            Me.grColumnYear1997.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("grColumnYear1997.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("grColumnYear1997.Summary1"), resources.GetString("grColumnYear1997.Summary2"))})
            ' 
            ' grColumnYear1998
            ' 
            resources.ApplyResources(Me.grColumnYear1998, "grColumnYear1998")
            Me.grColumnYear1998.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.grColumnYear1998.DisplayFormat.FormatString = "### ### ###"
            Me.grColumnYear1998.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.grColumnYear1998.FieldName = "Year1998"
            Me.grColumnYear1998.Name = "grColumnYear1998"
            Me.grColumnYear1998.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("grColumnYear1998.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("grColumnYear1998.Summary1"), resources.GetString("grColumnYear1998.Summary2"))})
            ' 
            ' grColumnYear1999
            ' 
            resources.ApplyResources(Me.grColumnYear1999, "grColumnYear1999")
            Me.grColumnYear1999.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.grColumnYear1999.DisplayFormat.FormatString = "### ### ###"
            Me.grColumnYear1999.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.grColumnYear1999.FieldName = "Year1999"
            Me.grColumnYear1999.Name = "grColumnYear1999"
            Me.grColumnYear1999.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("grColumnYear1999.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("grColumnYear1999.Summary1"), resources.GetString("grColumnYear1999.Summary2"))})
            ' 
            ' grColumnYear2000
            ' 
            resources.ApplyResources(Me.grColumnYear2000, "grColumnYear2000")
            Me.grColumnYear2000.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.grColumnYear2000.DisplayFormat.FormatString = "### ### ###"
            Me.grColumnYear2000.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.grColumnYear2000.FieldName = "Year2000"
            Me.grColumnYear2000.Name = "grColumnYear2000"
            Me.grColumnYear2000.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("grColumnYear2000.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("grColumnYear2000.Summary1"), resources.GetString("grColumnYear2000.Summary2"))})
            ' 
            ' gbTotals
            ' 
            resources.ApplyResources(Me.gbTotals, "gbTotals")
            Me.gbTotals.Columns.Add(Me.grColumnUnitSold)
            Me.gbTotals.ImageOptions.ImageIndex =(CInt((resources.GetObject("gbTotals.ImageOptions.ImageIndex"))))
            Me.gbTotals.OptionsBand.AllowHotTrack = False
            Me.gbTotals.OptionsBand.AllowMove = False
            Me.gbTotals.OptionsBand.AllowPress = False
            Me.gbTotals.OptionsBand.ShowInCustomizationForm = False
            Me.gbTotals.VisibleIndex = 2
            ' 
            ' grColumnUnitSold
            ' 
            Me.grColumnUnitSold.AppearanceCell.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((167)))))), (CInt(((CByte((244)))))), (CInt(((CByte((187)))))))
            Me.grColumnUnitSold.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((64)))))), (CInt(((CByte((0)))))))
            Me.grColumnUnitSold.AppearanceCell.Options.UseBackColor = True
            Me.grColumnUnitSold.AppearanceCell.Options.UseForeColor = True
            resources.ApplyResources(Me.grColumnUnitSold, "grColumnUnitSold")
            Me.grColumnUnitSold.DisplayFormat.FormatString = "### ### ### ###"
            Me.grColumnUnitSold.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.grColumnUnitSold.FieldName = "Total"
            Me.grColumnUnitSold.Name = "grColumnUnitSold"
            Me.grColumnUnitSold.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("grColumnUnitSold.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("grColumnUnitSold.Summary1"), resources.GetString("grColumnUnitSold.Summary2"))})
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "totals")
            ' 
            ' dataSet
            ' 
            Me.dataSet.DataSetName = "NewDataSet"
            Me.dataSet.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet.Tables.AddRange(New System.Data.DataTable() {Me.dataTable})
            ' 
            ' xtraTabControl1
            ' 
            resources.ApplyResources(Me.xtraTabControl1, "xtraTabControl1")
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2})
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.gridControl1)
            Me.xtraTabPage1.Controls.Add(Me.panelControl2)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            resources.ApplyResources(Me.xtraTabPage1, "xtraTabPage1")
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Controls.Add(Me.icbFixedStyle)
            Me.panelControl2.Controls.Add(Me.icbBand)
            Me.panelControl2.Controls.Add(Me.label1)
            Me.panelControl2.Controls.Add(Me.label4)
            Me.panelControl2.Controls.Add(Me.labelControl1)
            resources.ApplyResources(Me.panelControl2, "panelControl2")
            Me.panelControl2.Name = "panelControl2"
            ' 
            ' icbFixedStyle
            ' 
            resources.ApplyResources(Me.icbFixedStyle, "icbFixedStyle")
            Me.icbFixedStyle.Name = "icbFixedStyle"
            Me.icbFixedStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbFixedStyle.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            AddHandler Me.icbFixedStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbFixedStyle_SelectedIndexChanged)
            ' 
            ' icbBand
            ' 
            resources.ApplyResources(Me.icbBand, "icbBand")
            Me.icbBand.Name = "icbBand"
            Me.icbBand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbBand.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbBand.Properties.DropDownRows = 15
            AddHandler Me.icbBand.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbBand_SelectedIndexChanged)
            ' 
            ' label1
            ' 
            resources.ApplyResources(Me.label1, "label1")
            Me.label1.Name = "label1"
            ' 
            ' label4
            ' 
            resources.ApplyResources(Me.label4, "label4")
            Me.label4.Name = "label4"
            ' 
            ' labelControl1
            ' 
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            Me.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
            Me.labelControl1.LineVisible = True
            Me.labelControl1.Name = "labelControl1"
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Controls.Add(Me.gridControl2)
            Me.xtraTabPage2.Controls.Add(Me.panelControl1)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            resources.ApplyResources(Me.xtraTabPage2, "xtraTabPage2")
            ' 
            ' gridControl2
            ' 
            Me.gridControl2.DataSource = Me.dsContacts1.CustomersPayment
            resources.ApplyResources(Me.gridControl2, "gridControl2")
            Me.gridControl2.MainView = Me.bandedGridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit2})
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bandedGridView2})
            ' 
            ' dsContacts1
            ' 
            Me.dsContacts1.DataSetName = "dsContacts"
            Me.dsContacts1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsContacts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' bandedGridView2
            ' 
            Me.bandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand4, Me.gridBand5, Me.gridBand6})
            Me.bandedGridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.bandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colID, Me.colCustomerName, Me.colYear, Me.colJanuary, Me.colFebruary, Me.colMarch, Me.colApril, Me.colMay, Me.colJune, Me.colJuly, Me.colAugust, Me.colSeptember, Me.colOctober, Me.colNovember, Me.colDecember, Me.colRowSum, Me.colRowAvr})
            Me.bandedGridView2.GridControl = Me.gridControl2
            Me.bandedGridView2.GroupCount = 1
            Me.bandedGridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary1"), Me.colJanuary, resources.GetString("bandedGridView2.GroupSummary2")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary3")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary4"), Me.colFebruary, resources.GetString("bandedGridView2.GroupSummary5")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary6")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary7"), Me.colMarch, resources.GetString("bandedGridView2.GroupSummary8")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary9")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary10"), Me.colApril, resources.GetString("bandedGridView2.GroupSummary11")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary12")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary13"), Me.colMay, resources.GetString("bandedGridView2.GroupSummary14")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary15")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary16"), Me.colJune, resources.GetString("bandedGridView2.GroupSummary17")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary18")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary19"), Me.colJuly, resources.GetString("bandedGridView2.GroupSummary20")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary21")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary22"), Me.colAugust, resources.GetString("bandedGridView2.GroupSummary23")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary24")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary25"), Me.colSeptember, resources.GetString("bandedGridView2.GroupSummary26")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary27")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary28"), Me.colOctober, resources.GetString("bandedGridView2.GroupSummary29")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary30")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary31"), Me.colNovember, resources.GetString("bandedGridView2.GroupSummary32")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary33")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary34"), Me.colDecember, resources.GetString("bandedGridView2.GroupSummary35")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary36")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary37"), Me.colRowSum, resources.GetString("bandedGridView2.GroupSummary38")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary39")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary40"), Me.colRowAvr, resources.GetString("bandedGridView2.GroupSummary41")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("bandedGridView2.GroupSummary42")), DevExpress.Data.SummaryItemType), resources.GetString("bandedGridView2.GroupSummary43"), CType((resources.GetObject("bandedGridView2.GroupSummary44")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("bandedGridView2.GroupSummary45"))})
            Me.bandedGridView2.HorzScrollStep = 25
            Me.bandedGridView2.Name = "bandedGridView2"
            Me.bandedGridView2.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.bandedGridView2.OptionsPrint.AutoWidth = False
            Me.bandedGridView2.OptionsView.ColumnAutoWidth = False
            Me.bandedGridView2.OptionsView.ShowFooter = True
            Me.bandedGridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colYear, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.bandedGridView2.CustomDrawRowFooterCell, New DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(AddressOf Me.bandedGridView2_CustomDrawFooterCell)
            AddHandler Me.bandedGridView2.CustomDrawFooterCell, New DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(AddressOf Me.bandedGridView2_CustomDrawFooterCell)
            ' 
            ' gridBand4
            ' 
            resources.ApplyResources(Me.gridBand4, "gridBand4")
            Me.gridBand4.Columns.Add(Me.colCustomerName)
            Me.gridBand4.Columns.Add(Me.colYear)
            Me.gridBand4.VisibleIndex = 0
            ' 
            ' colCustomerName
            ' 
            Me.colCustomerName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((187)))))), (CInt(((CByte((228)))))), (CInt(((CByte((249)))))))
            Me.colCustomerName.AppearanceCell.Font = CType((resources.GetObject("colCustomerName.AppearanceCell.Font")), System.Drawing.Font)
            Me.colCustomerName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((60)))))), (CInt(((CByte((80)))))))
            Me.colCustomerName.AppearanceCell.Options.UseBackColor = True
            Me.colCustomerName.AppearanceCell.Options.UseFont = True
            Me.colCustomerName.AppearanceCell.Options.UseForeColor = True
            resources.ApplyResources(Me.colCustomerName, "colCustomerName")
            Me.colCustomerName.FieldName = "Customer Name"
            Me.colCustomerName.Name = "colCustomerName"
            Me.colCustomerName.OptionsColumn.AllowEdit = False
            Me.colCustomerName.OptionsColumn.AllowFocus = False
            Me.colCustomerName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colCustomerName.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' colYear
            ' 
            Me.colYear.AppearanceCell.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((192)))))), (CInt(((CByte((243)))))), (CInt(((CByte((254)))))))
            Me.colYear.AppearanceCell.Font = CType((resources.GetObject("colYear.AppearanceCell.Font")), System.Drawing.Font)
            Me.colYear.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((60)))))), (CInt(((CByte((80)))))))
            Me.colYear.AppearanceCell.Options.UseBackColor = True
            Me.colYear.AppearanceCell.Options.UseFont = True
            Me.colYear.AppearanceCell.Options.UseForeColor = True
            resources.ApplyResources(Me.colYear, "colYear")
            Me.colYear.FieldName = "Year"
            Me.colYear.Name = "colYear"
            Me.colYear.OptionsColumn.AllowFocus = False
            Me.colYear.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colYear.OptionsColumn.AllowMove = False
            ' 
            ' gridBand5
            ' 
            resources.ApplyResources(Me.gridBand5, "gridBand5")
            Me.gridBand5.Columns.Add(Me.colID)
            Me.gridBand5.Columns.Add(Me.colJanuary)
            Me.gridBand5.Columns.Add(Me.colFebruary)
            Me.gridBand5.Columns.Add(Me.colMarch)
            Me.gridBand5.Columns.Add(Me.colApril)
            Me.gridBand5.Columns.Add(Me.colMay)
            Me.gridBand5.Columns.Add(Me.colJune)
            Me.gridBand5.Columns.Add(Me.colJuly)
            Me.gridBand5.Columns.Add(Me.colAugust)
            Me.gridBand5.Columns.Add(Me.colSeptember)
            Me.gridBand5.Columns.Add(Me.colOctober)
            Me.gridBand5.Columns.Add(Me.colNovember)
            Me.gridBand5.Columns.Add(Me.colDecember)
            Me.gridBand5.VisibleIndex = 1
            ' 
            ' colID
            ' 
            resources.ApplyResources(Me.colID, "colID")
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.OptionsColumn.ShowInCustomizationForm = False
            ' 
            ' colJanuary
            ' 
            resources.ApplyResources(Me.colJanuary, "colJanuary")
            Me.colJanuary.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colJanuary.DisplayFormat.FormatString = "c"
            Me.colJanuary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJanuary.FieldName = "January"
            Me.colJanuary.Name = "colJanuary"
            Me.colJanuary.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colJanuary.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colJanuary.Summary1"), resources.GetString("colJanuary.Summary2"))})
            ' 
            ' repositoryItemSpinEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit2, "repositoryItemSpinEdit2")
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            ' 
            ' colFebruary
            ' 
            resources.ApplyResources(Me.colFebruary, "colFebruary")
            Me.colFebruary.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colFebruary.DisplayFormat.FormatString = "c"
            Me.colFebruary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFebruary.FieldName = "February"
            Me.colFebruary.Name = "colFebruary"
            Me.colFebruary.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colFebruary.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colFebruary.Summary1"), resources.GetString("colFebruary.Summary2"))})
            ' 
            ' colMarch
            ' 
            resources.ApplyResources(Me.colMarch, "colMarch")
            Me.colMarch.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colMarch.DisplayFormat.FormatString = "c"
            Me.colMarch.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colMarch.FieldName = "March"
            Me.colMarch.Name = "colMarch"
            Me.colMarch.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colMarch.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colMarch.Summary1"), resources.GetString("colMarch.Summary2"))})
            ' 
            ' colApril
            ' 
            resources.ApplyResources(Me.colApril, "colApril")
            Me.colApril.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colApril.DisplayFormat.FormatString = "c"
            Me.colApril.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colApril.FieldName = "April"
            Me.colApril.Name = "colApril"
            Me.colApril.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colApril.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colApril.Summary1"), resources.GetString("colApril.Summary2"))})
            ' 
            ' colMay
            ' 
            resources.ApplyResources(Me.colMay, "colMay")
            Me.colMay.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colMay.DisplayFormat.FormatString = "c"
            Me.colMay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colMay.FieldName = "May"
            Me.colMay.Name = "colMay"
            Me.colMay.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colMay.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colMay.Summary1"), resources.GetString("colMay.Summary2"))})
            ' 
            ' colJune
            ' 
            resources.ApplyResources(Me.colJune, "colJune")
            Me.colJune.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colJune.DisplayFormat.FormatString = "c"
            Me.colJune.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJune.FieldName = "June"
            Me.colJune.Name = "colJune"
            Me.colJune.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colJune.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colJune.Summary1"), resources.GetString("colJune.Summary2"))})
            ' 
            ' colJuly
            ' 
            resources.ApplyResources(Me.colJuly, "colJuly")
            Me.colJuly.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colJuly.DisplayFormat.FormatString = "c"
            Me.colJuly.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJuly.FieldName = "July"
            Me.colJuly.Name = "colJuly"
            Me.colJuly.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colJuly.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colJuly.Summary1"), resources.GetString("colJuly.Summary2"))})
            ' 
            ' colAugust
            ' 
            resources.ApplyResources(Me.colAugust, "colAugust")
            Me.colAugust.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colAugust.DisplayFormat.FormatString = "c"
            Me.colAugust.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAugust.FieldName = "August"
            Me.colAugust.Name = "colAugust"
            Me.colAugust.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colAugust.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colAugust.Summary1"), resources.GetString("colAugust.Summary2"))})
            ' 
            ' colSeptember
            ' 
            resources.ApplyResources(Me.colSeptember, "colSeptember")
            Me.colSeptember.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colSeptember.DisplayFormat.FormatString = "c"
            Me.colSeptember.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSeptember.FieldName = "September"
            Me.colSeptember.Name = "colSeptember"
            Me.colSeptember.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colSeptember.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colSeptember.Summary1"), resources.GetString("colSeptember.Summary2"))})
            ' 
            ' colOctober
            ' 
            resources.ApplyResources(Me.colOctober, "colOctober")
            Me.colOctober.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colOctober.DisplayFormat.FormatString = "c"
            Me.colOctober.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colOctober.FieldName = "October"
            Me.colOctober.Name = "colOctober"
            Me.colOctober.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colOctober.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colOctober.Summary1"), resources.GetString("colOctober.Summary2"))})
            ' 
            ' colNovember
            ' 
            resources.ApplyResources(Me.colNovember, "colNovember")
            Me.colNovember.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colNovember.DisplayFormat.FormatString = "c"
            Me.colNovember.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colNovember.FieldName = "November"
            Me.colNovember.Name = "colNovember"
            Me.colNovember.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colNovember.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colNovember.Summary1"), resources.GetString("colNovember.Summary2"))})
            ' 
            ' colDecember
            ' 
            resources.ApplyResources(Me.colDecember, "colDecember")
            Me.colDecember.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colDecember.DisplayFormat.FormatString = "c"
            Me.colDecember.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDecember.FieldName = "December"
            Me.colDecember.Name = "colDecember"
            Me.colDecember.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colDecember.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colDecember.Summary1"), resources.GetString("colDecember.Summary2"))})
            ' 
            ' gridBand6
            ' 
            resources.ApplyResources(Me.gridBand6, "gridBand6")
            Me.gridBand6.Columns.Add(Me.colRowSum)
            Me.gridBand6.Columns.Add(Me.colRowAvr)
            Me.gridBand6.VisibleIndex = 2
            ' 
            ' colRowSum
            ' 
            Me.colRowSum.AppearanceCell.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((192)))))), (CInt(((CByte((243)))))), (CInt(((CByte((254)))))))
            Me.colRowSum.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((0)))))), (CInt(((CByte((64)))))))
            Me.colRowSum.AppearanceCell.Options.UseBackColor = True
            Me.colRowSum.AppearanceCell.Options.UseForeColor = True
            resources.ApplyResources(Me.colRowSum, "colRowSum")
            Me.colRowSum.DisplayFormat.FormatString = "c"
            Me.colRowSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRowSum.FieldName = "RowSum"
            Me.colRowSum.Name = "colRowSum"
            Me.colRowSum.OptionsColumn.AllowEdit = False
            Me.colRowSum.OptionsColumn.AllowFocus = False
            Me.colRowSum.OptionsFilter.AllowFilter = False
            Me.colRowSum.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colRowSum.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colRowSum.Summary1"), resources.GetString("colRowSum.Summary2"))})
            ' 
            ' colRowAvr
            ' 
            Me.colRowAvr.AppearanceCell.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((187)))))), (CInt(((CByte((228)))))), (CInt(((CByte((249)))))))
            Me.colRowAvr.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((0)))))), (CInt(((CByte((64)))))))
            Me.colRowAvr.AppearanceCell.Options.UseBackColor = True
            Me.colRowAvr.AppearanceCell.Options.UseForeColor = True
            resources.ApplyResources(Me.colRowAvr, "colRowAvr")
            Me.colRowAvr.DisplayFormat.FormatString = "c"
            Me.colRowAvr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRowAvr.FieldName = "RowAvr"
            Me.colRowAvr.Name = "colRowAvr"
            Me.colRowAvr.OptionsColumn.AllowEdit = False
            Me.colRowAvr.OptionsColumn.AllowFocus = False
            Me.colRowAvr.OptionsFilter.AllowFilter = False
            Me.colRowAvr.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colRowAvr.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colRowAvr.Summary1"), resources.GetString("colRowAvr.Summary2"))})
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.labelControl2)
            Me.panelControl1.Controls.Add(Me.cbShowMode)
            Me.panelControl1.Controls.Add(Me.numFixedLineWidth)
            Me.panelControl1.Controls.Add(Me.label2)
            Me.panelControl1.Controls.Add(Me.label3)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' labelControl2
            ' 
            resources.ApplyResources(Me.labelControl2, "labelControl2")
            Me.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
            Me.labelControl2.LineVisible = True
            Me.labelControl2.Name = "labelControl2"
            ' 
            ' cbShowMode
            ' 
            resources.ApplyResources(Me.cbShowMode, "cbShowMode")
            Me.cbShowMode.Name = "cbShowMode"
            Me.cbShowMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("cbShowMode.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            AddHandler Me.cbShowMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbShowMode_SelectedIndexChanged)
            ' 
            ' numFixedLineWidth
            ' 
            resources.ApplyResources(Me.numFixedLineWidth, "numFixedLineWidth")
            Me.numFixedLineWidth.Name = "numFixedLineWidth"
            Me.numFixedLineWidth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.numFixedLineWidth.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.numFixedLineWidth.Properties.IsFloatValue = False
            Me.numFixedLineWidth.Properties.Mask.EditMask = resources.GetString("numFixedLineWidth.Properties.Mask.EditMask")
            Me.numFixedLineWidth.Properties.MaxValue = New Decimal(New Integer() {12, 0, 0, 0})
            Me.numFixedLineWidth.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            AddHandler Me.numFixedLineWidth.EditValueChanged, New System.EventHandler(AddressOf Me.numFixedLineWidth_ValueChanged)
            ' 
            ' label2
            ' 
            resources.ApplyResources(Me.label2, "label2")
            Me.label2.Name = "label2"
            ' 
            ' label3
            ' 
            resources.ApplyResources(Me.label3, "label3")
            Me.label3.Name = "label3"
            ' 
            ' FixedBands
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "FixedBands"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.FixedBands_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bandedGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.panelControl2.PerformLayout()
            CType((Me.icbFixedStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbBand.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage2.ResumeLayout(False)
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsContacts1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bandedGridView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.cbShowMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.numFixedLineWidth.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private bandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView

        Private gbManufacture As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private grColumnMaker As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private grColumnYear1992 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private grColumnYear1993 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private grColumnYear1994 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private grColumnYear1995 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private grColumnYear1996 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private grColumnYear1997 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private grColumnYear1998 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private grColumnYear1999 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private grColumnYear2000 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private grColumnUnitSold As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gbYear As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gbTotals As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private dataSet As System.Data.DataSet

        Private dataTable As System.Data.DataTable

        Private dcMaker As System.Data.DataColumn

        Private dcYear1992 As System.Data.DataColumn

        Private dcYear1993 As System.Data.DataColumn

        Private dcYear1994 As System.Data.DataColumn

        Private dcYear1995 As System.Data.DataColumn

        Private dcYear1996 As System.Data.DataColumn

        Private dcYear1997 As System.Data.DataColumn

        Private dcYear1998 As System.Data.DataColumn

        Private dcYear1999 As System.Data.DataColumn

        Private dcYear2000 As System.Data.DataColumn

        Private gcTotal As System.Data.DataColumn

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage

        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage

        Private colRowSum As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colFebruary As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private colAugust As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colYear As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colMarch As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colRowAvr As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private bandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView

        Private gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private colCustomerName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colJanuary As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colApril As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colMay As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colJune As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colJuly As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colSeptember As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colOctober As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colNovember As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colDecember As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private dsContacts1 As DevExpress.XtraGrid.Demos.dsContacts

        Private gridControl2 As DevExpress.XtraGrid.GridControl

        Private numFixedLineWidth As DevExpress.XtraEditors.SpinEdit

        Private label3 As System.Windows.Forms.Label

        Private label2 As System.Windows.Forms.Label

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private cbShowMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private panelControl2 As DevExpress.XtraEditors.PanelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private icbFixedStyle As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbBand As DevExpress.XtraEditors.ImageComboBoxEdit

        Private label1 As System.Windows.Forms.Label

        Private label4 As System.Windows.Forms.Label

        Private imageCollection1 As DevExpress.Utils.ImageCollection
    End Class
End Namespace
