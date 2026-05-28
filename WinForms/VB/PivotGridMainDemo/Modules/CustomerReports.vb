Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    ''' <summary>
    ''' Summary description for CustomerReports.
    ''' </summary>
    Public Partial Class CustomerReports
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Private Sub CustomerReports_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            pivotGridControl1.DataSource = GetNWindData("CustomerReports")
            InitComboBox()
            rgReport.SelectedIndex = 0
            pivotGridControl1.HeaderImages = HeadersImageList
            fieldCompanyName.ImageIndex = 2
        End Sub

        Private Sub InitComboBox()
            Dim values As Object() = fieldOrderYear.GetUniqueValues()
            For Each obj As Object In values
                cbeYear.Properties.Items.Add(obj)
            Next

            cbeYear.SelectedIndex = 1
            values = fieldOrderQuarter.GetUniqueValues()
            For Each obj As Object In values
                cbeQuarter.Properties.Items.Add(obj)
            Next

            cbeQuarter.SelectedIndex = 0
        End Sub

        '<rgReport>
        Private Sub SetReport()
            DoShow()
            pivotGridControl1.BeginUpdate()
            Try
                fieldOrderYear.Group.FilterValues.Reset()
                cbeYearItem.ContentVisible = rgReport.SelectedIndex = 1
                cbeQuarteritem.ContentVisible = rgReport.SelectedIndex = 1
                pivotGridControl1.OptionsView.ShowColumnGrandTotals = rgReport.SelectedIndex <> 1
                If rgReport.SelectedIndex <> 1 Then pivotGridControl1.OptionsView.ShowColumnTotals = True
                Dim parameter As DefaultBoolean = If(rgReport.SelectedIndex = 1, DefaultBoolean.False, DefaultBoolean.Default)
                fieldOrderYear.Options.AllowSort = parameter
                fieldOrderYear.Options.AllowFilter = fieldOrderYear.Options.AllowSort
                fieldOrderQuarter.Options.AllowSort = fieldOrderYear.Options.AllowFilter
                fieldOrderQuarter.Options.AllowFilter = fieldOrderQuarter.Options.AllowSort
                fieldProductName.Area = PivotArea.RowArea
                fieldCompanyName.Area = fieldProductName.Area
                fieldOrderQuarter.Area = PivotArea.ColumnArea
                fieldOrderYear.Area = fieldOrderQuarter.Area
                fieldProductAmount.Area = PivotArea.DataArea
                fieldCompanyName.TopValueCount = 0
                fieldProductName.TopValueCount = fieldCompanyName.TopValueCount
                fieldCompanyName.SortOrder = PivotSortOrder.Ascending
                fieldProductName.SortOrder = fieldCompanyName.SortOrder
                fieldProductName.SortBySummaryInfo.Field = Nothing
                fieldCompanyName.SortBySummaryInfo.Field = Nothing
                Select Case rgReport.SelectedIndex
                    Case 0
                        fieldCompanyName.AreaIndex = 0
                    Case 1
                        fieldProductName.Area = 0
                        SetYearFilter()
                    Case 2
                        fieldCompanyName.AreaIndex = 0
                        fieldOrderQuarter.Area = PivotArea.FilterArea
                        fieldOrderYear.Area = fieldOrderQuarter.Area
                        fieldProductName.SortBySummaryInfo.Field = fieldProductAmount
                        fieldProductName.SortOrder = PivotSortOrder.Descending
                        fieldProductName.TopValueCount = 2
                    Case 3
                        fieldProductName.Area = PivotArea.FilterArea
                        fieldOrderQuarter.Area = PivotArea.FilterArea
                        fieldOrderYear.Area = fieldOrderQuarter.Area
                        fieldCompanyName.SortBySummaryInfo.Field = fieldProductAmount
                        fieldCompanyName.SortOrder = PivotSortOrder.Descending
                        fieldCompanyName.TopValueCount = 10
                End Select
            Finally
                pivotGridControl1.EndUpdate()
            End Try
        End Sub

        '</rgReport>
        '<cbeYear>
        '<cbeQuarter>
        Private Sub SetYearFilter()
            Dim valuesYear As Object() = fieldOrderYear.GetUniqueValues()
            Dim valuesQuarter As Object() = fieldOrderQuarter.GetUniqueValues()
            pivotGridControl1.BeginUpdate()
            Try
                Dim group As PivotGridGroup = fieldOrderYear.Group
                group.FilterValues.Reset()
                group.FilterValues.FilterType = PivotFilterType.Included
                Dim yearValue As PivotGroupFilterValue = group.FilterValues.Values.Add(cbeYear.SelectedItem)
                pivotGridControl1.OptionsView.ShowColumnTotals = cbeQuarter.SelectedIndex = 0
                If cbeQuarter.SelectedIndex <> 0 Then yearValue.ChildValues.Add(cbeQuarter.SelectedItem)
            Finally
                pivotGridControl1.EndUpdate()
            End Try
        End Sub

        '<skip>
        Private Sub rgReport_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            SetReport()
        End Sub

        '</skip>
        Private Sub cbeQuarter_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            SetYearFilter()
        End Sub

        Private Sub cbeYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            SetYearFilter()
        End Sub
    '</cbeQuarter> 
    '</cbeYear>
    End Class
End Namespace
