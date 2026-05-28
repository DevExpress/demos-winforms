Imports System
Imports System.Drawing
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.XtraMap

Namespace DevExpress.DevAV.ViewModels

    Public Class EmployeeMapViewModel
        Inherits EmployeeViewModel
        Implements IRouteMapViewModel

        Public Overridable Property TravelMode As AzureTravelMode = AzureTravelMode.Car Implements IRouteMapViewModel.TravelMode

        <Command>
        Public Sub SetDrivingTravelMode()
            TravelMode = AzureTravelMode.Car
        End Sub

        Public Function CanSetDrivingTravelMode() As Boolean
            Return TravelMode <> AzureTravelMode.Car
        End Function

        <Command>
        Public Sub SetWalkingTravelMode()
            TravelMode = AzureTravelMode.Pedestrian
        End Sub

        Public Function CanSetWalkingTravelMode() As Boolean
            Return TravelMode <> AzureTravelMode.Pedestrian
        End Function

        Protected Overridable Sub OnTravelModeChanged()
            RaiseCanExecuteChanged(Sub(x) x.SetDrivingTravelMode())
            RaiseCanExecuteChanged(Sub(x) x.SetWalkingTravelMode())
            RaiseTravelModeChanged()
        End Sub

        Public Event TravelModeChanged As EventHandler Implements IRouteMapViewModel.TravelModeChanged

        Private Sub RaiseTravelModeChanged()
            Dim handler As EventHandler = TravelModeChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        <Command>
        Public Sub SwapRoutePoints()
            Dim a As Address = PointA
            PointA = PointB
            PointB = a
            RaiseUpdateRoute()
        End Sub

        Public ReadOnly Property FullName As String
            Get
                Return If(Entity IsNot Nothing, Entity.FullNameBindable, Nothing)
            End Get
        End Property

        Public ReadOnly Property AddressLine1 As String
            Get
                Return If(Entity IsNot Nothing, Entity.Address.Line, Nothing)
            End Get
        End Property

        Public ReadOnly Property AddressLine2 As String
            Get
                Return If(Entity IsNot Nothing, Entity.Address.CityLine, Nothing)
            End Get
        End Property

        Public ReadOnly Property Picture As Image
            Get
                Return If(Entity IsNot Nothing, Entity.Photo, Nothing)
            End Get
        End Property

        Public ReadOnly Property PointAAddress As String
            Get
                Return If(PointA IsNot Nothing, PointA.ToString(), Nothing)
            End Get
        End Property

        Public ReadOnly Property PointBAddress As String
            Get
                Return If(PointB IsNot Nothing, PointB.ToString(), Nothing)
            End Get
        End Property

        Public Overridable ReadOnly Property RouteResult As String
            Get
                Return String.Format("{0:F1} mi, {1:hh\:mm} min ", RouteDistance, RouteTime) & If(TravelMode = AzureTravelMode.Pedestrian, "walking", "driving")
            End Get
        End Property

        Public Overridable Property RouteDistance As Double Implements IRouteMapViewModel.RouteDistance

        Protected Overridable Sub OnRouteDistanceChanged()
            RaisePropertyChanged(Function(x) x.RouteResult)
        End Sub

        Public Overridable Property RouteTime As TimeSpan Implements IRouteMapViewModel.RouteTime

        Protected Overridable Sub OnRouteTimeChanged()
            RaisePropertyChanged(Function(x) x.RouteResult)
        End Sub

        Protected Overrides Sub OnEntityChanged()
            PointA = AddressHelper.DevAVHomeOffice
            PointB = If(Entity IsNot Nothing, Entity.Address, AddressHelper.DevAVHomeOffice)
            RaisePropertyChanged(Function(x) x.FullName)
            RaisePropertyChanged(Function(x) x.Title)
            RaisePropertyChanged(Function(x) x.PointA)
            RaisePropertyChanged(Function(x) x.PointB)
            RaisePropertyChanged(Function(x) x.AddressLine1)
            RaisePropertyChanged(Function(x) x.AddressLine2)
            MyBase.OnEntityChanged()
        End Sub

        Public Overridable Property PointA As Address Implements IRouteMapViewModel.PointA

        Protected Overridable Sub OnPointAChanged()
            RaisePropertyChanged(Function(x) x.PointAAddress)
            RaisePointAChanged()
        End Sub

        Public Overridable Property PointB As Address Implements IRouteMapViewModel.PointB

        Protected Overridable Sub OnPointBChanged()
            RaisePropertyChanged(Function(x) x.PointBAddress)
            RaisePointBChanged()
        End Sub

        Public Event PointAChanged As EventHandler Implements IRouteMapViewModel.PointAChanged

        Private Sub RaisePointAChanged()
            Dim handler As EventHandler = PointAChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Public Event PointBChanged As EventHandler Implements IRouteMapViewModel.PointBChanged

        Private Sub RaisePointBChanged()
            Dim handler As EventHandler = PointBChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Public Event UpdateRoute As EventHandler Implements IRouteMapViewModel.UpdateRoute

        Private Sub RaiseUpdateRoute()
            Dim handler As EventHandler = UpdateRouteEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub
    End Class
End Namespace
