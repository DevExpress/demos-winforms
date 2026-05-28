Imports System
Imports System.Collections.Generic
Imports DevExpress.DevAV
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraBars.Docking2010

Namespace DevExpress.DevAV.Modules

    Public Partial Class EmployeeMapView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Private _Presenter As EmployeeRouteMapPresenter

        Public Sub New()
            MyBase.New(GetType(EmployeeMapViewModel))
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

        Public ReadOnly Property ViewModel As EmployeeMapViewModel
            Get
                Return GetViewModel(Of EmployeeMapViewModel)()
            End Get
        End Property

        Protected Property Presenter As EmployeeRouteMapPresenter
            Get
                Return _Presenter
            End Get

            Private Set(ByVal value As EmployeeRouteMapPresenter)
                _Presenter = value
            End Set
        End Property

        Protected Overridable Function CreatePresenter() As EmployeeRouteMapPresenter
            Return New EmployeeRouteMapPresenter(mapControl, ViewModel, AddressOf UpdateUI, AddressOf UpdateRouteList)
        End Function

        Protected Overridable Sub BindCommands()
            biSave.BindCommand(Sub() ViewModel.Save(), ViewModel)
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
            biSaveAndClose.BindCommand(Sub() ViewModel.SaveAndClose(), ViewModel)
            biDelete.BindCommand(Sub() ViewModel.Delete(), ViewModel)
            biDriving.BindCommand(Sub() ViewModel.SetDrivingTravelMode(), ViewModel)
            biWalking.BindCommand(Sub() ViewModel.SetWalkingTravelMode(), ViewModel)
            CType(routeButtons.Buttons(0), WindowsUIButton).BindCommand(Sub() ViewModel.SetWalkingTravelMode(), ViewModel)
            CType(routeButtons.Buttons(1), WindowsUIButton).BindCommand(Sub() ViewModel.SetDrivingTravelMode(), ViewModel)
            CType(swapRouteButtons.Buttons(0), WindowsUIButton).BindCommand(Sub() ViewModel.SwapRoutePoints(), ViewModel)
            AddHandler biPrint.ItemClick, Sub(s, e) mapControl.Print()
            AddHandler biPrintPreview.ItemClick, Sub(s, e) mapControl.ShowRibbonPrintPreview()
            AddHandler barExportItem.ItemClick, Sub(s, e) mapControl.Export("Employees.Map.png")
        End Sub

        Protected Overridable Sub BindEditors()
            bindingSource.DataSource = ViewModel
            colManeuver.ColumnEdit = EditorHelpers.CreateManeuverImageComboBox()
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColors()
        End Sub

        Private Sub UpdateColors()
            routeResultLabel.Appearance.BackColor = WindowColor
            routeResultLabel.Appearance.ForeColor = WindowTextColor
        End Sub

        Private Sub UpdateUI(ByVal employee As Employee)
            ribbonControl.ApplicationDocumentCaption = employee.FullNameBindable
        End Sub

        Private Sub UpdateRouteList(ByVal routePoints As List(Of RoutePoint))
            gridControl.DataSource = routePoints
        End Sub

#Region ""
        Private ReadOnly Property Ribbon As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
#End Region
    End Class
End Namespace
