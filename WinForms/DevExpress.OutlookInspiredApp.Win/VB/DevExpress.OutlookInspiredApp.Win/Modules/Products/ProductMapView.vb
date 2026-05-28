Imports System
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraBars.Docking2010
Imports System.Drawing
Imports DevExpress.DevAV.Common.Utils

Namespace DevExpress.DevAV.Modules

    Public Partial Class ProductMapView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Private _Presenter As ProductSalesMapPresenter

        Public Sub New()
            MyBase.New(GetType(ProductMapViewModel))
            InitializeComponent()
            Presenter = CreatePresenter()
            BindCommands()
            BindEditors()
            UpdateColors()
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            SwapFluentIcons(Me)
        End Sub

        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            RemoveHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property ViewModel As ProductMapViewModel
            Get
                Return GetViewModel(Of ProductMapViewModel)()
            End Get
        End Property

        Protected Property Presenter As ProductSalesMapPresenter
            Get
                Return _Presenter
            End Get

            Private Set(ByVal value As ProductSalesMapPresenter)
                _Presenter = value
            End Set
        End Property

        Protected Overridable Function CreatePresenter() As ProductSalesMapPresenter
            Return New ProductSalesMapPresenter(mapControl, ViewModel, AddressOf UpdateUI, AddressOf UpdateChart)
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
            AddHandler barExportItem.ItemClick, Sub(s, e) mapControl.Export("Products.Map.png")
        End Sub

        Protected Overridable Sub BindEditors()
            bindingSource.DataSource = ViewModel
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColors()
        End Sub

        Private Sub UpdateUI(ByVal product As Product)
            ribbonControl.ApplicationDocumentCaption = product.Name
        End Sub

        Private Sub UpdateChart(ByVal salesItem As MapItem)
            chart.Series(0).View.Colorizer = TryCast(colorizer1, XtraCharts.IColorizer)
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

    Public Class Colorizer
        Inherits XtraMap.KeyColorColorizer
        Implements XtraCharts.IColorizer

        Private Function IColorizer_GetPointColor(ByVal argument As Object, ByVal values As Object(), ByVal colorKey As Object, ByVal palette As XtraCharts.Palette) As Color Implements XtraCharts.IColorizer.GetPointColor
            If colorKey IsNot Nothing Then Return GetColor(colorKey)
            Return Color.Empty
        End Function

        Private Function IColorizer_GetPointColor1(ByVal argument As Object, ByVal values As Object(), ByVal colorKeys As Object(), ByVal palette As XtraCharts.Palette) As Color Implements XtraCharts.IColorizer.GetPointColor
            If colorKeys IsNot Nothing AndAlso colorKeys.Length > 0 Then Return GetColor(colorKeys(0))
            Return Color.Empty
        End Function

        Private Function GetAggregatedPointColor(ByVal argument As Object, ByVal values As Object(), ByVal points As XtraCharts.SeriesPoint(), ByVal palette As XtraCharts.Palette) As Color Implements XtraCharts.IColorizer.GetAggregatedPointColor
            Return Color.Empty
        End Function

        Private Custom Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements ComponentModel.INotifyPropertyChanged.PropertyChanged
            AddHandler(ByVal value As System.ComponentModel.PropertyChangedEventHandler)
            End AddHandler

            RemoveHandler(ByVal value As System.ComponentModel.PropertyChangedEventHandler)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As ComponentModel.PropertyChangedEventArgs)
            End RaiseEvent
        End Event
    End Class
End Namespace
