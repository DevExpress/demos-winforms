Imports System
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraBars.Docking2010

Namespace DevExpress.DevAV.Modules

    Public Partial Class CustomerMapView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Private _Presenter As CustomerSalesMapPresenter

        Public Sub New()
            MyBase.New(GetType(CustomerMapViewModel))
            InitializeComponent()
            Presenter = CreatePresenter()
            BindCommands()
            BindEditors()
            UpdateColors()
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            SwapFluentIcons(Me)
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As CustomerMapViewModel
            Get
                Return GetViewModel(Of CustomerMapViewModel)()
            End Get
        End Property

        Protected Property Presenter As CustomerSalesMapPresenter
            Get
                Return _Presenter
            End Get

            Private Set(ByVal value As CustomerSalesMapPresenter)
                _Presenter = value
            End Set
        End Property

        Protected Overridable Function CreatePresenter() As CustomerSalesMapPresenter
            Return New CustomerSalesMapPresenter(mapControl, ViewModel, AddressOf UpdateUI, AddressOf UpdateChart)
        End Function

        Protected Overridable Sub BindCommands()
            biSave.BindCommand(Sub() ViewModel.Save(), ViewModel)
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
            biSaveAndClose.BindCommand(Sub() ViewModel.SaveAndClose(), ViewModel)
            biDelete.BindCommand(Sub() ViewModel.Delete(), ViewModel)
            biLifetime.BindCommand(Sub() ViewModel.SetLifetimePeriod(), ViewModel)
            biThisYear.BindCommand(Sub() ViewModel.SetThisYearPeriod(), ViewModel)
            biThisMonth.BindCommand(Sub() ViewModel.SetThisMonthPeriod(), ViewModel)
            CType(periodButtons.Buttons(0), WindowsUIButton).BindCommand(Sub() ViewModel.SetThisMonthPeriod(), ViewModel)
            CType(periodButtons.Buttons(1), WindowsUIButton).BindCommand(Sub() ViewModel.SetThisYearPeriod(), ViewModel)
            CType(periodButtons.Buttons(2), WindowsUIButton).BindCommand(Sub() ViewModel.SetLifetimePeriod(), ViewModel)
            AddHandler biPrint.ItemClick, Sub(s, e) mapControl.Print()
            AddHandler biPrintPreview.ItemClick, Sub(s, e) mapControl.ShowRibbonPrintPreview()
            AddHandler barExportItem.ItemClick, Sub(s, e) mapControl.Export("Customers.Map.png")
        End Sub

        Protected Overridable Sub BindEditors()
            bindingSource.DataSource = ViewModel
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColors()
        End Sub

        Private Sub UpdateUI(ByVal customer As Customer)
            ribbonControl.ApplicationDocumentCaption = customer.Name
        End Sub

        Private Sub UpdateChart(ByVal salesItem As MapItem)
            chart.Series(0).View.Colorizer = colorizer1
            chart.DataSource = ViewModel.GetSalesByCity(salesItem.City, ViewModel.Period).ToList()
        End Sub

        Private Sub UpdateColors()
            periodButtons.BackColor = ChartHelper.GetBackColor(chart)
            Dim paletteEntries = chart.GetPaletteEntries(20)
            Dim colorItems = Presenter.PieChartColorizer.Colors
            colorItems.Clear()
            colorItems.BeginUpdate()
            For Each entry In paletteEntries
                colorItems.Add(entry.Color)
            Next

            colorItems.EndUpdate()
        End Sub

#Region "IRibbonModule"
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
#End Region
    End Class
End Namespace
