Imports DevExpress.Internal
Imports DevExpress.XtraPivotGrid.Demos.Helpers

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class ExcelStyleFilter
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitVehiclesData()
        End Sub

#Region "Init Data"
        Private Sub InitVehiclesData()
            If DesignMode Then Return
            Dim dbFileName As String = DevAVDataDirectoryHelper.GetFile("Vehicles.xml")
            If Not String.IsNullOrEmpty(dbFileName) Then
                pivotGridControl.LoadingPanelVisible = True
                Call VehiclesData.InitOrdersData(dbFileName, pivotGridControl, 10000, 365 * 3, Sub()
                    pivotGridControl.HtmlImages = PivotDemoHelper.GetTransmissionGlyphs()
                    pivotGridControl.CollapseAllColumns()
                    Dim price As String = fieldModelPrice.FilterColumnName, body As String = fieldBodyStyle.FilterColumnName
                    pivotGridControl.ActiveFilterString = "([" & price & "] >= 25000 And [" & price & "] <= 80000) And [" & body & "] In (6,7)"
                    pivotGridControl.MRUFilters.Add(New PivotFilterInfo("([" & price & "] >= 25000 And [" & price & "] <= 80000)"))
                    ' Hide loading panel
                    pivotGridControl.LoadingPanelVisible = False
                End Sub)
            End If
        End Sub

#End Region
        '<pivotGridControl>
        Private Sub OnFilterPopupExcelData(ByVal sender As Object, ByVal e As FilterPopupExcelDataEventArgs)
            Dim fieldName As String = e.Field.FilterColumnName
            If e.Field Is fieldModification Then
                ' Filter Items
                e.AddFilter("<image=A><nbsp>Automatic Transmission (6-speed)", "Contains([" & fieldName & "], '6A')", True)
                e.AddFilter("<image=A><nbsp>Automatic Transmission (8-speed)", "Contains([" & fieldName & "], '8A')", True)
                e.AddFilter("<image=M><nbsp>Manual Transmission (6-speed)", "Contains([" & fieldName & "], '6M')", True)
                e.AddFilter("<image=M><nbsp>Manual Transmission (7-speed)", "Contains([" & fieldName & "], '7M')", True)
                e.AddFilter("<image=V><nbsp>Variomatic Transmission", "Contains([" & fieldName & "], 'VA')", True)
                e.AddFilter("<b>Limited Edition</b>", "Contains([" & fieldName & "], 'Limited')", True)
                ' Data Items
                For Each item In e.DataItems
                    If item.Text.Contains("V6") Then item.HtmlText = item.Text.Replace("V6", "<b>V6</b>")
                    If item.Text.Contains("V8") Then item.HtmlText = item.Text.Replace("V8", "<b>V8</b>")
                    If item.Text.Contains("Limited") Then item.HtmlText = "<image=Ltd><nbsp>" & item.Text
                Next
            End If

            If e.Field Is fieldMPGCity Then ' 12-28
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" & fieldName & "]>25", True)
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" & fieldName & "]>=15 AND [" & fieldName & "]<=25", True)
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" & fieldName & "]<15", True)
            End If

            If e.Field Is fieldMPGHighway Then ' 15-36
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" & fieldName & "]>30", True)
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" & fieldName & "]>=20 AND [" & fieldName & "]<=30", True)
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" & fieldName & "]<20", True)
            End If
        End Sub

        '</pivotGridControl>
#Region "Options"
        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property
#End Region  ' Options
    End Class
End Namespace
