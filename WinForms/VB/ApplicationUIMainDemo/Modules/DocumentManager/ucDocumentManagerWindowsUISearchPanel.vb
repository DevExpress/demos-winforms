Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraBars.Docking2010.Views

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class ucDocumentManagerWindowsUISearchPanel
        Inherits XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
            AddHandler windowsUIView.QueryControl, New QueryControlEventHandler(AddressOf OnQueryControl)
            AddHandler windowsUIView.CustomizeSearchItems, New CustomizeSearchItemsEventHandler(AddressOf OnCustomizeSearchItems)
            AddHandler windowsUIView.NavigatedFrom, New NavigationEventHandler(AddressOf OnNavigatedFrom)
            AddHandler windowsUIView.NavigatedTo, New NavigationEventHandler(AddressOf OnNavigatedTo)
            ucProductsGridDocument.SearchTags = SalesPerformanceDataGenerator.Current.FilterTotalSales.[Select](Function(x) x.Category).Distinct().ToArray()
            ucChartProductItemDocument.SearchTags = SalesPerformanceDataGenerator.Current.MonthlySales.[Select](Function(x) x.Product).Distinct().ToArray()
            ucChoroplethMapItemDocument.SearchTags = New String() {"Map"}
            ucCategorySalesDocument.SearchTags = New String() {"Revenue"}
            salesInCalifornia.Tag = "California"
            salesInMontana.Tag = "Montana"
            salesInTexas.Tag = "Texas"
        End Sub

        Private Sub OnCustomizeSearchItems(ByVal sender As Object, ByVal e As CustomizeSearchItemsEventArgs)
            Dim content As List(Of String) = New List(Of String)()
            content.Add(TryCast(e.SourceContainer.Tag, String))
            If e.Source Is ucProductsGridDocument Then content.AddRange(GetType(SalesPerformanceDataGenerator.TotalSalesItem).GetProperties().[Select](Function(x) x.ToString()).ToArray())
            e.Content = content
            e.Image = GetResourceImage(e.Source)
        End Sub

        Private Function GetResourceImage(ByVal component As IComponent) As Image
            Dim _name As String = Nothing
            If TypeOf component Is Document Then _name = CType(component, Document).ControlName
            If TypeOf component Is IContentContainer Then _name = CType(component, IContentContainer).Name
            If TypeOf component Is BaseTile Then _name = CType(component, BaseTile).Name
            If String.IsNullOrEmpty(_name) Then Return Nothing
            Return TryCast(Utils.ResourceImageHelperCore.CreateImageFromResourcesEx(String.Format("DevExpress.ApplicationUI.Demos.Images.{0}.png", _name), GetType(ucDocumentManagerWindowsUISearchPanel).Assembly), Image)
        End Function

        Private Sub OnNavigatedTo(ByVal sender As Object, ByVal e As NavigationEventArgs)
            If e.Target Is Nothing OrElse e.Target.Tag Is Nothing OrElse e.Target Is tileContainer Then Return
            SalesPerformanceDataGenerator.Current.Filter = e.Target.Tag.ToString()
        End Sub

        Private Sub OnNavigatedFrom(ByVal sender As Object, ByVal e As NavigationEventArgs)
            If e.Source Is salesByState Then e.Source.Tag = SalesPerformanceDataGenerator.Current.Filter
        End Sub

        Private Sub OnQueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs)
            Dim typeName As String = e.Document.ControlTypeName
            If Not String.IsNullOrEmpty(typeName) Then
                Dim controlType = Data.Internal.SafeTypeResolver.GetKnownType(GetType(Program).Assembly, typeName)
                e.Control = TryCast(Activator.CreateInstance(controlType), Control)
            Else
                e.Control = New Control()
            End If
        End Sub
    End Class
End Namespace
