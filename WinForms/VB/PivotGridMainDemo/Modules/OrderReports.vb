Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    ''' <summary>
    ''' Summary description for OrderReports.
    ''' </summary>
    Public Partial Class OrderReports
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
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

        Private Sub OrderReports_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            pivotGridControl1.DataSource = GetNWindData("OrderReports")
            InitComboBox()
            rgReport.SelectedIndex = 0
            pivotGridControl1.HeaderImages = HeadersImageList
            fieldOrderID.ImageIndex = 1
            fieldSum.ImageIndex = 3
        End Sub

        Private Sub InitComboBox()
            Dim values As Object() = fieldOrderID.GetUniqueValues()
            For Each obj As Object In values
                cbeOrder.Properties.Items.Add(obj)
            Next

            cbeOrder.SelectedIndex = 0
        End Sub

        '<rgReport>
        Private Sub SetReport()
            DoShow()
            pivotGridControl1.BeginUpdate()
            Try
                fieldOrderID.FilterValues.Clear()
                layoutControlItem2.Visibility = If(rgReport.SelectedIndex = 1, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
                pivotGridControl1.OptionsView.ShowRowGrandTotals = rgReport.SelectedIndex <> 1
                fieldOrderID.FilterValues.FilterType = If(rgReport.SelectedIndex = 1, PivotFilterType.Included, PivotFilterType.Excluded)
                Dim parameter As DefaultBoolean = If(rgReport.SelectedIndex = 1, DefaultBoolean.False, DefaultBoolean.Default)
                fieldOrderID.Options.AllowSort = parameter
                fieldOrderID.Options.AllowFilter = fieldOrderID.Options.AllowSort
                pivotGridControl1.OptionsCustomization.FilterPanelVisible = If(parameter = DefaultBoolean.False, FilterPanelVisible.Never, FilterPanelVisible.Default)
                For Each field As PivotGridField In pivotGridControl1.Fields
                    field.Area = PivotArea.FilterArea
                Next

                Select Case rgReport.SelectedIndex
                    Case 0, 1
                        fieldOrderID.Area = PivotArea.RowArea
                        fieldProduct.Area = PivotArea.RowArea
                        fieldUnitPrice.Area = PivotArea.DataArea
                        fieldQuantity.Area = PivotArea.DataArea
                        fieldDiscount.Area = PivotArea.DataArea
                        fieldSum.Area = PivotArea.DataArea
                        If rgReport.SelectedIndex = 1 Then SetOrderFilter()
                    Case 2
                        fieldProduct.Area = PivotArea.RowArea
                        fieldQuantity.Area = PivotArea.DataArea
                    Case 3
                        fieldProduct.Area = PivotArea.RowArea
                        fieldUnitPrice.Area = PivotArea.DataArea
                End Select
            Finally
                pivotGridControl1.EndUpdate()
            End Try
        End Sub

        '</rgReport>
        '<cbeOrder>
        Private Sub SetOrderFilter()
            pivotGridControl1.BeginUpdate()
            Try
                fieldOrderID.FilterValues.Clear()
                fieldOrderID.FilterValues.Add(cbeOrder.SelectedItem)
            Finally
                pivotGridControl1.EndUpdate()
            End Try
        End Sub

        '</cbeOrder>
        Private Sub rgReport_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            SetReport()
        End Sub

        Private Sub cbeOrder_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            SetOrderFilter()
        End Sub
    End Class
End Namespace
