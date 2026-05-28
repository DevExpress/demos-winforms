Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid.StyleFormatConditions

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Partial Class VerticalGrid
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitVehiclesData()
            vGridControl.ActiveFilterString = DemoFilterString
            vGridControl.MRUFilters.Add(New VGridFilterInfo("([ModelPrice] >= 50000 And [ModelPrice] <= 150000)"))
            vGridControl.MRUFilters.Add(New VGridFilterInfo("IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate])"))
            vGridControl.MRUFilters.Add(New VGridFilterInfo("([ModelPrice] >= 40000 And [ModelPrice] <= 100000)"))
            vGridControl.MRUFilters.Add(New VGridFilterInfo("[SalesDate] > AddDays(LocalDateTimeToday(), -25)"))
            CreateFormatConditionRule()
            SetToolTipController(Me, vGridControl)
        End Sub

        Private ReadOnly Property DemoFilterString As String
            Get
                Dim extFilter As String = If(MainFormHelper.TakeScreens, ")", " And (IsOutlookIntervalToday([SalesDate]) Or IsOutlookIntervalYesterday([SalesDate]))")
                Return $"([ModelPrice] >= 40000 And [ModelPrice] <= 100000){extFilter}"
            End Get
        End Property

        Private Sub CreateFormatConditionRule()
            Dim iconRuleForMPGCity = New VGridFormatRule()
            iconRuleForMPGCity.Rule = CreateFormatConditionRuleIconSet()
            iconRuleForMPGCity.RowProperties = merpMPGCity
            Dim iconRuleForMPGHighway = New VGridFormatRule()
            iconRuleForMPGHighway.Rule = CreateFormatConditionRuleIconSet()
            iconRuleForMPGHighway.RowProperties = merpMPGHighway
            Dim dataBarRule = New VGridFormatRule()
            dataBarRule.Rule = CreateFormatConditionRuleDataBar()
            dataBarRule.RowProperties = erModelPrice.Properties
            Dim iconRuleForDiscount = New VGridFormatRule()
            iconRuleForDiscount.Rule = CreateFormatConditionRuleStarsSet()
            iconRuleForDiscount.RowProperties = erDiscount.Properties
            vGridControl.FormatRules.BeginUpdate()
            vGridControl.FormatRules.Add(iconRuleForMPGCity)
            vGridControl.FormatRules.Add(iconRuleForMPGHighway)
            vGridControl.FormatRules.Add(dataBarRule)
            vGridControl.FormatRules.Add(iconRuleForDiscount)
            vGridControl.FormatRules.EndUpdate()
        End Sub

        Private Function CreateFormatConditionRuleIconSet() As FormatConditionRuleIconSet
            Dim ruleIconSet = New FormatConditionRuleIconSet()
            ruleIconSet.IconSet = New FormatConditionIconSet()
            Dim iconSet = ruleIconSet.IconSet
            Dim icon1 = New FormatConditionIconSetIcon()
            Dim icon2 = New FormatConditionIconSetIcon()
            Dim icon3 = New FormatConditionIconSetIcon()
            icon1.PredefinedName = "Arrows3_3.png"
            icon2.PredefinedName = "Arrows3_2.png"
            icon3.PredefinedName = "Arrows3_1.png"
            iconSet.ValueType = FormatConditionValueType.Number
            icon1.Value = 0
            icon1.ValueComparison = FormatConditionComparisonType.Greater
            icon2.Value = 15
            icon2.ValueComparison = FormatConditionComparisonType.Greater
            icon3.Value = 20
            icon3.ValueComparison = FormatConditionComparisonType.Greater
            iconSet.Icons.Add(icon1)
            iconSet.Icons.Add(icon2)
            iconSet.Icons.Add(icon3)
            Return ruleIconSet
        End Function

        Private Function CreateFormatConditionRuleStarsSet() As FormatConditionRuleIconSet
            Dim ruleIconSet = New FormatConditionRuleIconSet()
            ruleIconSet.IconSet = New FormatConditionIconSet()
            Dim iconSet = ruleIconSet.IconSet
            Dim icon1 = New FormatConditionIconSetIcon()
            Dim icon2 = New FormatConditionIconSetIcon()
            Dim icon3 = New FormatConditionIconSetIcon()
            icon1.PredefinedName = "Stars3_3.png"
            icon2.PredefinedName = "Stars3_2.png"
            icon3.PredefinedName = "Stars3_1.png"
            iconSet.ValueType = FormatConditionValueType.Number
            icon1.Value = 0
            icon1.ValueComparison = FormatConditionComparisonType.GreaterOrEqual
            icon2.Value = 0.05D
            icon2.ValueComparison = FormatConditionComparisonType.GreaterOrEqual
            icon3.Value = 0.15D
            icon3.ValueComparison = FormatConditionComparisonType.GreaterOrEqual
            iconSet.Icons.Add(icon1)
            iconSet.Icons.Add(icon2)
            iconSet.Icons.Add(icon3)
            Return ruleIconSet
        End Function

        Private Function CreateFormatConditionRuleDataBar() As FormatConditionRuleDataBar
            Dim formatConditionRuleDataBar = New FormatConditionRuleDataBar()
            formatConditionRuleDataBar.PredefinedName = "Green"
            formatConditionRuleDataBar.AutomaticType = FormatConditionAutomaticType.ZeroBased
            Return formatConditionRuleDataBar
        End Function

        Private Sub InitVehiclesData()
            Dim dbFileName As String = DataDirectoryHelper.GetDataFile("Vehicles.xml")
            If Not String.IsNullOrEmpty(dbFileName) Then InitXMLData(dbFileName)
        End Sub

        Protected Overrides Sub InitXMLData(ByVal xmlFileName As String)
            VehiclesData.InitOrdersData(xmlFileName, vGridControl, 1000, 40)
            VehiclesData.InitEditors(vGridControl)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            vGridControl.FocusedRecord = 0
        End Sub

        ' Addding custom Filters and Data Items customization
        Private Sub vGridControl_FilterPopupExcelData(ByVal sender As Object, ByVal e As FilterPopupExcelDataEventArgs)
            ' Adding custom Filters
            Dim fieldName As String = e.Column.FieldName
            If e.Column Is erModification.Properties Then
                ' Filter Items
                e.AddFilter("Automatic Transmission (6-speed)", "Contains([" & fieldName & "], '6A')", True)
                e.AddFilter("Automatic Transmission (8-speed)", "Contains([" & fieldName & "], '8A')", True)
                e.AddFilter("Manual Transmission (6-speed)", "Contains([" & fieldName & "], '6M')", True)
                e.AddFilter("Manual Transmission (7-speed)", "Contains([" & fieldName & "], '7M')", True)
                e.AddFilter("Variomatic Transmission", "Contains([" & fieldName & "], 'VA')", True)
                e.AddFilter("<b>Limited Edition</b>", "Contains([" & fieldName & "], 'Limited')", True)
                ' Data Items
                For Each item In e.DataItems
                    If item.Text.Contains("V6") Then item.HtmlText = item.Text.Replace("V6", "<b>V6</b>")
                    If item.Text.Contains("V8") Then item.HtmlText = item.Text.Replace("V8", "<b>V8</b>")
                    If item.Text.Contains("Limited") Then item.HtmlText = "<nbsp>" & item.Text
                Next
            End If

            If e.Column Is merpMPGCity Then ' 12-28
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" & fieldName & "]>25", True)
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" & fieldName & "]>=15 AND [" & fieldName & "]<=25", True)
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" & fieldName & "]<15", True)
            End If

            If e.Column Is merpMPGHighway Then ' 15-36
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" & fieldName & "]>30", True)
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" & fieldName & "]>=20 AND [" & fieldName & "]<=30", True)
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" & fieldName & "]<20", True)
            End If
        End Sub

        Protected ReadOnly Property Grid As VGridControl
            Get
                Return vGridControl
            End Get
        End Property

        Private Sub OnGridCellValueChanged(ByVal sender As Object, ByVal e As Events.CellValueChangedEventArgs)
            If e.Row Is erModelPrice Then maxPriceCore = Nothing
            If e.Row Is erDiscount Then maxDiscountCore = Nothing
        End Sub

        Private maxPriceCore As Decimal?

        Protected ReadOnly Property MaxPrice As Decimal
            Get
                If Not maxPriceCore.HasValue Then
                    Dim orderItems = CType(vGridControl.DataSource, List(Of VehiclesData.OrderItem))
                    maxPriceCore = orderItems.Max(Function(x) x.ModelPrice)
                End If

                Return maxPriceCore.Value
            End Get
        End Property

        Private maxDiscountCore As Double?

        Protected ReadOnly Property MaxDiscount As Double
            Get
                If Not maxDiscountCore.HasValue Then
                    Dim orderItems = CType(vGridControl.DataSource, List(Of VehiclesData.OrderItem))
                    maxDiscountCore = orderItems.Max(Function(x) x.Discount)
                End If

                Return maxDiscountCore.Value
            End Get
        End Property
    End Class
End Namespace
