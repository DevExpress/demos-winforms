Imports DevExpress.Internal
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports System.Linq

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Classic Filter Popup", "Filtering.cs")>
    Public Module Filtering

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            pivotGridControl.BeginInit()
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField() With {.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea, .DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName"), .Name = "fieldProductName"})
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField() With {.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, .DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear), .Name = "fieldYear", .Caption = "Year"})
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField() With {.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea, .DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Quantity"), .Name = "fieldQuantity", .SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Sum})
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField() With {.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea, .DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Extended Price"), .Name = "fieldExtendedPrice", .SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Sum})
            pivotGridControl.OptionsFilterPopup.FieldFilterPopupMode = DevExpress.XtraPivotGrid.FieldFilterPopupMode.Classic
            pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            pivotGridControl.OptionsView.ShowRowTotals = False
            pivotGridControl.OptionsView.ShowRowGrandTotals = False
            Dim dbFileName As String = DevExpress.Internal.DataDirectoryHelper.GetDataFile("nwind.xml")
            If Not String.IsNullOrEmpty(dbFileName) Then
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.ReadXml(dbFileName)
                pivotGridControl.DataSource = dataSet.Tables(CStr(("SalesPerson"))).DefaultView
            End If

            pivotGridControl.EndInit()
            pivotGridControl.Parent = sampleHost
            pivotGridControl.BestFitDataHeaders(True)
            Dim showPopupTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()
            showPopupTimer.Interval = 500
            sampleHost.Tag = showPopupTimer
            Return New Object() {pivotGridControl, showPopupTimer}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim timer As System.Windows.Forms.Timer = TryCast(sampleHost.Tag, System.Windows.Forms.Timer)
            If timer IsNot Nothing Then timer.Dispose()
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraPivotGrid.PivotGridControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Field Filter Popup")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowToolbar", "FieldFilterPopupMode", "Classic", "FilterPopupToolbarButtons")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub FieldFilterPopup(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl, ByVal showPopupTimer As System.Windows.Forms.Timer)
            pivotGridControl.OptionsFilterPopup.FieldFilterPopupMode = DevExpress.XtraPivotGrid.FieldFilterPopupMode.Classic
            Dim setToolbarButtonVisibility As System.Action(Of DevExpress.XtraPivotGrid.PivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons, Boolean) = Sub(pivot, button, visibility)
                If visibility Then
                    pivot.OptionsFilterPopup.ToolbarButtons = pivot.OptionsFilterPopup.ToolbarButtons Or button
                Else
                    pivot.OptionsFilterPopup.ToolbarButtons = pivot.OptionsFilterPopup.ToolbarButtons And Not button
                End If
            End Sub
            Dim categoryField As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField() With {.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, .DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("CategoryName"), .Name = "fieldCategory"}
            pivotGridControl.Fields.Add(categoryField)
            pivotGridControl.OptionsFilterPopup.ShowToolbar = True
            pivotGridControl.OptionsFilterPopup.ShowOnlyAvailableItems = True
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.ShowOnlyAvailableItems, True)
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.IncrementalSearch, True)
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.InvertFilter, True)
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.MultiSelection, True)
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.RadioMode, True)
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.ShowNewValues, True)
            categoryField.FilterValues.ValuesIncluded = New Object() {"Beverages"}
            Dim fieldProductName As DevExpress.XtraPivotGrid.PivotGridField = pivotGridControl.Fields("ProductName")
            Dim fieldYear As DevExpress.XtraPivotGrid.PivotGridField = pivotGridControl.Fields("fieldYear")
            fieldProductName.FilterValues.ValuesIncluded = New Object() {"Chai", "Chang", "Vegie-spread"}
            fieldYear.FilterValues.ValuesIncluded = New Object() {2015}
            AddHandler showPopupTimer.Tick, Sub(s, e)
                fieldProductName.ShowFilterPopup()
                showPopupTimer.[Stop]()
            End Sub
            showPopupTimer.Start()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Group Filter Popup")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowToolbar", "GroupFilterMode", "FieldFilterPopupMode", "Classic", "FilterPopupToolbarButtons")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub GroupFilterPopup(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl, ByVal showPopupTimer As System.Windows.Forms.Timer)
            pivotGridControl.OptionsFilterPopup.FieldFilterPopupMode = DevExpress.XtraPivotGrid.FieldFilterPopupMode.Classic
            Dim setToolbarButtonVisibility As System.Action(Of DevExpress.XtraPivotGrid.PivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons, Boolean) = Sub(pivot, button, visibility)
                If visibility Then
                    pivot.OptionsFilterPopup.ToolbarButtons = pivot.OptionsFilterPopup.ToolbarButtons Or button
                Else
                    pivot.OptionsFilterPopup.ToolbarButtons = pivot.OptionsFilterPopup.ToolbarButtons And Not button
                End If
            End Sub
            Dim fieldYear As DevExpress.XtraPivotGrid.PivotGridField = pivotGridControl.Fields("fieldYear")
            fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Dim fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField = pivotGridControl.Fields.Add()
            fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            fieldQuarter.Caption = "Quarter"
            fieldQuarter.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter)
            Dim fieldMonth As DevExpress.XtraPivotGrid.PivotGridField = pivotGridControl.Fields.Add()
            fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            fieldMonth.Caption = "Month"
            fieldMonth.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth)
            Dim dateGroup As DevExpress.XtraPivotGrid.PivotGridGroup = pivotGridControl.Groups.Add(fieldYear, fieldQuarter, fieldMonth)
            pivotGridControl.OptionsFilterPopup.AllowContextMenu = True
            pivotGridControl.OptionsFilterPopup.ShowToolbar = True
            pivotGridControl.OptionsFilterPopup.GroupFilterMode = DevExpress.XtraPivotGrid.PivotGroupFilterMode.Tree
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.IncrementalSearch, True)
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.InvertFilter, True)
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.MultiSelection, True)
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.RadioMode, True)
            setToolbarButtonVisibility(pivotGridControl, DevExpress.XtraPivotGrid.FilterPopupToolbarButtons.ShowNewValues, True)
            dateGroup.FilterValues.BeginUpdate()
            dateGroup.FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included
            dateGroup.FilterValues.Values.Add(CObj((2014))).ChildValues.Add(3)
            dateGroup.FilterValues.Values(CObj((2014))).ChildValues(CObj((3))).ChildValues.Add(9)
            dateGroup.FilterValues.Values.Add(CObj((2015))).ChildValues.Add(1)
            dateGroup.FilterValues.Values(CObj((2015))).ChildValues.Add(4)
            dateGroup.FilterValues.EndUpdate()
            AddHandler showPopupTimer.Tick, Sub(s, e)
                fieldYear.ShowFilterPopup()
                showPopupTimer.[Stop]()
            End Sub
            showPopupTimer.Start()
        End Sub
    End Module
End Namespace
