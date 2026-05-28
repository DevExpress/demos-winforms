Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Xml.Linq
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGauges.Win.Gauges.Circular
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraMap.Demos

    Public Partial Class SalesDashboard
        Inherits FooteredMapTutorialControl

        Private dataGenerator As SalesDataGenerator

        Private superToolTipField As SuperToolTip

        Private titleItemField As ToolTipTitleItem

        Private contentItemField As ToolTipItem

        Protected ReadOnly Property SuperToolTip As SuperToolTip
            Get
                If superToolTipField Is Nothing Then CreateSuperToolTip()
                Return superToolTipField
            End Get
        End Property

        Protected ReadOnly Property TitleItem As ToolTipTitleItem
            Get
                If titleItemField Is Nothing Then CreateSuperToolTip()
                Return titleItemField
            End Get
        End Property

        Protected ReadOnly Property ContentItem As ToolTipItem
            Get
                If contentItemField Is Nothing Then CreateSuperToolTip()
                Return contentItemField
            End Get
        End Property

        Protected Overrides ReadOnly Property MiniMapAzureKind As AzureTileset
            Get
                Return AzureTileset.BaseRoad
            End Get
        End Property

        Protected Overrides ReadOnly Property MiniMapAlignment As MiniMapAlignment
            Get
                Return MiniMapAlignment.TopLeft
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightImage As Image
            Get
                Return DemoUtils.AzureLogo
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightText As String
            Get
                Return DemoUtils.AzureCopyright
            End Get
        End Property

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitializeData()
        End Sub

        Private Sub InitializeData()
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider)
            dataGenerator = New SalesDataGenerator(chartControl1, layoutControlItem3, arcScaleNeedleComponent1)
            ListSourceDataAdapter.DataSource = dataGenerator.Shops
            chartControl1.DataSource = dataGenerator.ActualStatistics
            circularGauge1.Scales(0).MinValue = dataGenerator.MinSalesLevel - 10000
            circularGauge1.Scales(0).MaxValue = dataGenerator.MaxSalesLevel + 10000
            arcScaleMarkerComponent1.Value = dataGenerator.MinSalesLevel
            arcScaleMarkerComponent2.Value = dataGenerator.MaxSalesLevel
            ItemsLayer.SelectedItem = dataGenerator.Shops(0)
        End Sub

        Private Sub CreateSuperToolTip()
            superToolTipField = New SuperToolTip() With {.MaxWidth = 350}
            titleItemField = New ToolTipTitleItem()
            contentItemField = New ToolTipItem()
            superToolTipField.Items.Add(titleItemField)
            superToolTipField.Items.Add(contentItemField)
        End Sub

        Private Sub UpdateSuperToolTip(ByVal content As String, ByVal item As MapItem)
            ContentItem.Text = content
            If item IsNot Nothing Then
                Dim shopName As String = item.Attributes("ShopName").Value.ToString()
                ContentItem.Image = CType((item.Attributes("ShopImage").Value), Image)
                TitleItem.Text = shopName
            End If
        End Sub

        Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs)
            Dim item As MapItem = TryCast(e.SelectedObject, MapItem)
            If item IsNot Nothing Then
                UpdateSuperToolTip(e.ToolTip, item)
                e.AutoHide = False
                e.SuperTip = SuperToolTip
            End If
        End Sub

        Private Sub mapControl1_SelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs)
            Dim selectedShop As ShopInfo = If(e.Selection.Count > 0, TryCast(e.Selection(0), ShopInfo), Nothing)
            dataGenerator.SelectedShop = selectedShop
        End Sub
    End Class

    Public Class ProductGroupInfo

        Private ReadOnly nameField As String

        Public ReadOnly Property Name As String
            Get
                Return nameField
            End Get
        End Property

        Public Property Value As Single

        Public Sub New(ByVal value As Single, ByVal name As String)
            Me.Value = value
            nameField = name
        End Sub
    End Class

    Public Class ShopInfo

        Private Function ConvertShopNameToFilePath(ByVal shopName As String) As String
            Dim result As String = shopName.Replace(" ", "")
            result = "Images\Shops\" & result.Replace("-", "") & ".png"
            Return DemoUtils.GetRelativePath(result)
        End Function

        Private ReadOnly nameField As String

        Private ReadOnly phoneField As String

        Private ReadOnly faxField As String

        Private ReadOnly addressField As String

        Private ReadOnly imageField As Image

        Private salesField As Single

        Private ReadOnly statistics As Dictionary(Of String, Single) = New Dictionary(Of String, Single)()

        Public ReadOnly Property Name As String
            Get
                Return nameField
            End Get
        End Property

        Public ReadOnly Property Phone As String
            Get
                Return phoneField
            End Get
        End Property

        Public ReadOnly Property Fax As String
            Get
                Return faxField
            End Get
        End Property

        Public ReadOnly Property Address As String
            Get
                Return addressField
            End Get
        End Property

        Public ReadOnly Property Sales As Single
            Get
                Return salesField
            End Get
        End Property

        Public Property LocationLatitude As Double

        Public Property LocationLongitude As Double

        Public ReadOnly Property Image As Image
            Get
                Return imageField
            End Get
        End Property

        Public Sub New(ByVal name As String, ByVal address As String, ByVal phone As String, ByVal fax As String)
            nameField = name
            addressField = address
            phoneField = phone
            faxField = fax
            imageField = New Bitmap(ConvertShopNameToFilePath(name))
        End Sub

        Public Sub AddProductGroup(ByVal groupName As String, ByVal sales As Single)
            If statistics.ContainsKey(groupName) Then
                statistics(groupName) = sales
            Else
                statistics.Add(groupName, sales)
            End If

            salesField += sales
        End Sub

        Public Function GetSalesByProductGroup(ByVal groupName As String) As Single
            Dim sales As Single = 0
            Return If(statistics.TryGetValue(groupName, sales), sales, 0.0F)
        End Function
    End Class

    Public Class SalesDataGenerator

        Private _MaxSalesLevel As Single, _MinSalesLevel As Single

        Private ReadOnly chart As ChartControl

        Private ReadOnly gaugeContainer As LayoutControlItem

        Private ReadOnly needle As ArcScaleNeedleComponent

        Private ReadOnly shopsField As List(Of ShopInfo) = New List(Of ShopInfo)()

        Private ReadOnly actualStatisticsField As List(Of ProductGroupInfo) = New List(Of ProductGroupInfo)()

        Private selectedShopField As ShopInfo

        Public ReadOnly Property ActualStatistics As List(Of ProductGroupInfo)
            Get
                Return actualStatisticsField
            End Get
        End Property

        Public ReadOnly Property Shops As List(Of ShopInfo)
            Get
                Return shopsField
            End Get
        End Property

        Public Property MaxSalesLevel As Single
            Get
                Return _MaxSalesLevel
            End Get

            Private Set(ByVal value As Single)
                _MaxSalesLevel = value
            End Set
        End Property

        Public Property MinSalesLevel As Single
            Get
                Return _MinSalesLevel
            End Get

            Private Set(ByVal value As Single)
                _MinSalesLevel = value
            End Set
        End Property

        Public Property SelectedShop As ShopInfo
            Get
                Return selectedShopField
            End Get

            Set(ByVal value As ShopInfo)
                If selectedShopField Is value Then Return
                selectedShopField = value
                SelectedShopChanged()
            End Set
        End Property

        Public Sub New(ByVal chart As ChartControl, ByVal gaugeContainer As LayoutControlItem, ByVal needle As ArcScaleNeedleComponent)
            Me.chart = chart
            Me.gaugeContainer = gaugeContainer
            Me.needle = needle
            LoadDataFromXML()
            UpdateMinMaxSales()
            UpdateTotalStatistics()
        End Sub

        Private Sub SelectedShopChanged()
            If selectedShopField IsNot Nothing Then
                UpdateStatistics(selectedShopField)
            Else
                UpdateTotalStatistics()
            End If
        End Sub

        Private Sub LoadDataFromXML()
            Dim productGroupNames As List(Of String) = New List(Of String)()
            Dim document As XDocument = DemoUtils.LoadXml("Sales.xml")
            If document IsNot Nothing Then
                For Each element As XElement In document.Element("Sales").Elements()
                    Dim shopName As String = element.Element("ShopName").Value
                    Dim shopAddress As String = element.Element("ShopAddr").Value
                    Dim shopPhone As String = element.Element("ShopPhone").Value
                    Dim shopFax As String = element.Element("ShopFax").Value
                    Dim info As ShopInfo = New ShopInfo(shopName, shopAddress, shopPhone, shopFax)
                    For Each statElement As XElement In element.Element("ShopStatistics").Elements()
                        Dim groupName As String = statElement.Element("ProductsGroupName").Value
                        If Not productGroupNames.Contains(groupName) Then productGroupNames.Add(groupName)
                        Dim sales As Single = Convert.ToSingle(statElement.Element("ProductGroupSales").Value, CultureInfo.InvariantCulture)
                        info.AddProductGroup(groupName, sales)
                    Next

                    info.LocationLatitude = Convert.ToDouble(element.Element("Latitude").Value, CultureInfo.InvariantCulture)
                    info.LocationLongitude = Convert.ToDouble(element.Element("Longitude").Value, CultureInfo.InvariantCulture)
                    Shops.Add(info)
                Next
            End If

            For Each groupName As String In productGroupNames
                ActualStatistics.Add(New ProductGroupInfo(0.0F, groupName))
            Next

            UpdateTotalStatistics()
        End Sub

        Private Sub UpdateStatistics(ByVal info As ShopInfo)
            For Each productGroupInfo As ProductGroupInfo In ActualStatistics
                productGroupInfo.Value = info.GetSalesByProductGroup(productGroupInfo.Name)
            Next

            chart.Titles(0).Text = "Sales: " & info.Name
            chart.RefreshData()
            needle.Value = selectedShopField.Sales
            needle.Renderable = True
            gaugeContainer.Enabled = True
        End Sub

        Private Sub UpdateMinMaxSales()
            Dim minSales As Single = Shops(0).Sales
            Dim maxSales As Single = Shops(0).Sales
            Dim max As Single = 0
            For Each info As ShopInfo In Shops
                If info.Sales > maxSales Then maxSales = info.Sales
                If info.Sales < minSales Then minSales = info.Sales
                max += info.Sales
            Next

            MaxSalesLevel = maxSales
            MinSalesLevel = minSales
        End Sub

        Public Sub UpdateTotalStatistics()
            For Each info As ProductGroupInfo In ActualStatistics
                info.Value = 0.0F
                For Each shopInfo As ShopInfo In Shops
                    info.Value += shopInfo.GetSalesByProductGroup(info.Name)
                Next
            Next

            chart.Titles(0).Text = "Sales: All Shops"
            chart.RefreshData()
            needle.Renderable = False
            gaugeContainer.Enabled = False
        End Sub
    End Class
End Namespace
