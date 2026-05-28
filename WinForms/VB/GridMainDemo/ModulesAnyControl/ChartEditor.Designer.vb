Namespace DevExpress.XtraGrid.Demos

    Partial Class ChartEditor

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim pieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colChart = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colHireDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colBirthDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colHomePhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbChartType = New DevExpress.XtraEditors.RadioGroup()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.advBandedGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.icbChartType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.chartControl1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(819, 392, 739, 534)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(688, 611)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Location = New System.Drawing.Point(79, 436)
            Me.chartControl1.Name = "chartControl1"
            pieSeriesLabel1.TextPattern = "{VP:P2}"
            series1.Label = pieSeriesLabel1
            series1.LegendTextPattern = "{A}"
            series1.Name = "Quantity"
            series1.SeriesID = 0
            series1.View = pieSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartControl1.SeriesTemplate.LegendTextPattern = "{A}"
            Me.chartControl1.SeriesTemplate.View = pieSeriesView2
            Me.chartControl1.Size = New System.Drawing.Size(569, 173)
            Me.chartControl1.TabIndex = 5
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.advBandedGridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1, Me.repositoryItemTextEdit2, Me.repositoryItemMemoEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(688, 434)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.advBandedGridView1})
            ' 
            ' advBandedGridView1
            ' 
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand2, Me.gridBand3, Me.gridBand1})
            Me.advBandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colBirthDate, Me.colFirstName, Me.colHireDate, Me.colHomePhone, Me.colLastName, Me.colNotes, Me.colPhoto, Me.colTitle, Me.colTitleOfCourtesy, Me.colChart})
            Me.advBandedGridView1.GridControl = Me.gridControl1
            Me.advBandedGridView1.Name = "advBandedGridView1"
            Me.advBandedGridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.advBandedGridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.advBandedGridView1.OptionsDetail.EnableMasterViewMode = False
            Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
            Me.advBandedGridView1.OptionsView.ShowColumnHeaders = False
            Me.advBandedGridView1.OptionsView.ShowGroupPanel = False
            AddHandler Me.advBandedGridView1.CustomDrawCell, New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(AddressOf Me.advBandedGridView1_CustomDrawCell)
            AddHandler Me.advBandedGridView1.CustomUnboundColumnData, New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(AddressOf Me.gridView1_CustomUnboundColumnData)
            AddHandler Me.advBandedGridView1.CustomColumnDisplayText, New DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(AddressOf Me.advBandedGridView1_CustomColumnDisplayText)
            ' 
            ' gridBand2
            ' 
            Me.gridBand2.Caption = "Salesperson"
            Me.gridBand2.Columns.Add(Me.colPhoto)
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 0
            Me.gridBand2.Width = 126
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.Caption = "Salesperson"
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.AllowFocus = False
            Me.colPhoto.OptionsColumn.FixedWidth = True
            Me.colPhoto.OptionsFilter.AllowFilter = False
            Me.colPhoto.RowCount = 8
            Me.colPhoto.Visible = True
            Me.colPhoto.Width = 126
            ' 
            ' gridBand3
            ' 
            Me.gridBand3.Caption = "Sales % by Product Category"
            Me.gridBand3.Columns.Add(Me.colChart)
            Me.gridBand3.Name = "gridBand3"
            Me.gridBand3.VisibleIndex = 1
            Me.gridBand3.Width = 250
            ' 
            ' colChart
            ' 
            Me.colChart.Caption = "Sales by Product Category"
            Me.colChart.FieldName = "colChart"
            Me.colChart.Name = "colChart"
            Me.colChart.OptionsColumn.AllowFocus = False
            Me.colChart.RowCount = 8
            Me.colChart.UnboundDataType = GetType(Object)
            Me.colChart.Visible = True
            Me.colChart.Width = 250
            ' 
            ' gridBand1
            ' 
            Me.gridBand1.Caption = "Contact Information"
            Me.gridBand1.Columns.Add(Me.colFirstName)
            Me.gridBand1.Columns.Add(Me.colLastName)
            Me.gridBand1.Columns.Add(Me.colTitle)
            Me.gridBand1.Columns.Add(Me.colTitleOfCourtesy)
            Me.gridBand1.Columns.Add(Me.colHireDate)
            Me.gridBand1.Columns.Add(Me.colBirthDate)
            Me.gridBand1.Columns.Add(Me.colHomePhone)
            Me.gridBand1.Columns.Add(Me.colNotes)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.VisibleIndex = 2
            Me.gridBand1.Width = 211
            ' 
            ' colFirstName
            ' 
            Me.colFirstName.Caption = "First Name"
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.OptionsColumn.AllowFocus = False
            Me.colFirstName.Visible = True
            Me.colFirstName.Width = 51
            ' 
            ' colLastName
            ' 
            Me.colLastName.Caption = "Last Name"
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.OptionsColumn.AllowFocus = False
            Me.colLastName.Visible = True
            Me.colLastName.Width = 55
            ' 
            ' colTitle
            ' 
            Me.colTitle.Caption = "Title"
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            Me.colTitle.OptionsColumn.AllowFocus = False
            Me.colTitle.Visible = True
            Me.colTitle.Width = 105
            ' 
            ' colTitleOfCourtesy
            ' 
            Me.colTitleOfCourtesy.Caption = "Title Of Courtesy"
            Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
            Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
            Me.colTitleOfCourtesy.OptionsColumn.AllowFocus = False
            Me.colTitleOfCourtesy.Width = 154
            ' 
            ' colHireDate
            ' 
            Me.colHireDate.Caption = "Hire Date"
            Me.colHireDate.FieldName = "HireDate"
            Me.colHireDate.Name = "colHireDate"
            Me.colHireDate.OptionsColumn.AllowFocus = False
            Me.colHireDate.RowIndex = 1
            Me.colHireDate.Visible = True
            Me.colHireDate.Width = 211
            ' 
            ' colBirthDate
            ' 
            Me.colBirthDate.Caption = "Birth Date"
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.Name = "colBirthDate"
            Me.colBirthDate.OptionsColumn.AllowFocus = False
            Me.colBirthDate.RowIndex = 1
            Me.colBirthDate.Width = 483
            ' 
            ' colHomePhone
            ' 
            Me.colHomePhone.Caption = "Home Phone"
            Me.colHomePhone.FieldName = "HomePhone"
            Me.colHomePhone.Name = "colHomePhone"
            Me.colHomePhone.OptionsColumn.AllowFocus = False
            Me.colHomePhone.RowIndex = 2
            Me.colHomePhone.Visible = True
            Me.colHomePhone.Width = 211
            ' 
            ' colNotes
            ' 
            Me.colNotes.AppearanceCell.Options.UseTextOptions = True
            Me.colNotes.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.colNotes.Caption = "Notes"
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.OptionsColumn.AllowFocus = False
            Me.colNotes.OptionsFilter.AllowFilter = False
            Me.colNotes.RowCount = 5
            Me.colNotes.RowIndex = 3
            Me.colNotes.Visible = True
            Me.colNotes.Width = 211
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.DisplayFormat.FormatString = "{0:n} Sq Ft"
            Me.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.repositoryItemTextEdit1.Mask.EditMask = "n"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemTextEdit2
            ' 
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Mask.EditMask = "c"
            Me.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(688, 611)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(688, 434)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chartControl1
            Me.layoutControlItem2.CustomizationFormText = "Chart Control"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 434)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(650, 177)
            Me.layoutControlItem2.Text = "Chart Control"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(65, 13)
            Me.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(650, 434)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(38, 177)
            Me.emptySpaceItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(688, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(250, 611)
            Me.sidePanel1.TabIndex = 7
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(249, 611)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(249, 611)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl2)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(249, 578)
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.icbChartType)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.Root = Me.Root
            Me.layoutControl2.Size = New System.Drawing.Size(249, 578)
            Me.layoutControl2.TabIndex = 7
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' icbChartType
            ' 
            Me.icbChartType.AutoSizeInLayoutControl = True
            Me.icbChartType.Location = New System.Drawing.Point(12, 34)
            Me.icbChartType.Name = "icbChartType"
            Me.icbChartType.Properties.Columns = 1
            Me.icbChartType.Size = New System.Drawing.Size(225, 10)
            Me.icbChartType.StyleController = Me.layoutControl2
            Me.icbChartType.TabIndex = 6
            AddHandler Me.icbChartType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbChartType_SelectedIndexChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem3, Me.layoutControlGroup2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(249, 578)
            Me.Root.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 56)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(249, 522)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 56)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "ChartType"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbChartType
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 14)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' ChartEditor
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "ChartEditor"
            Me.Size = New System.Drawing.Size(938, 611)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.advBandedGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.icbChartType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView

        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private colFirstName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colLastName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colTitleOfCourtesy As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colHireDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colBirthDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colHomePhone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colNotes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private colPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private colChart As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private icbChartType As DevExpress.XtraEditors.RadioGroup

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
