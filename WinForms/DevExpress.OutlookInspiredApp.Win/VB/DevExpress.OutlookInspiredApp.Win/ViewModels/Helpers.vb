Imports System
Imports System.Collections.Generic
Imports DevExpress.DevAV.Modules
Imports DevExpress.Mvvm
Imports DevExpress.XtraMap
Imports System.Runtime.CompilerServices

Namespace DevExpress.DevAV

    Public Module ViewModelHelper

        Public Function GetParentViewModel(Of TViewModel As Class)(ByVal viewModel As Object) As TViewModel
            Dim parentViewModelSupport As ISupportParentViewModel = TryCast(viewModel, ISupportParentViewModel)
            If parentViewModelSupport IsNot Nothing Then Return TryCast(parentViewModelSupport.ParentViewModel, TViewModel)
            Return Nothing
        End Function

        Public Sub EnsureModuleViewModel(ByVal [module] As Object, ByVal parentViewModel As Object, ByVal Optional parameter As Object = Nothing)
            Dim vm As ISupportViewModel = TryCast([module], ISupportViewModel)
            If vm IsNot Nothing Then
                Dim oldParentViewModel As Object = Nothing
                Dim parentViewModelSupport As ISupportParentViewModel = TryCast(vm.ViewModel, ISupportParentViewModel)
                If parentViewModelSupport IsNot Nothing Then oldParentViewModel = parentViewModelSupport.ParentViewModel
                EnsureViewModel(vm.ViewModel, parentViewModel, parameter)
                If oldParentViewModel IsNot parentViewModel Then vm.ParentViewModelAttached()
            End If
        End Sub

        Public Sub EnsureViewModel(ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal Optional parameter As Object = Nothing)
            Dim parentViewModelSupport As ISupportParentViewModel = TryCast(viewModel, ISupportParentViewModel)
            If parentViewModelSupport IsNot Nothing Then parentViewModelSupport.ParentViewModel = parentViewModel
            Dim parameterSupport As ISupportParameter = TryCast(viewModel, ISupportParameter)
            If parameterSupport IsNot Nothing AndAlso parameter IsNot Nothing Then parameterSupport.Parameter = parameter
        End Sub

        Public Sub RaiseCanExecuteChanged(ByVal viewModel As Object, ByVal methodName As String)
            Dim viewModelType = viewModel.GetType()
            Dim commandMethod = viewModelType.GetMethod(methodName)
            If commandMethod IsNot Nothing Then
                Dim commandProperty = viewModelType.GetProperty(String.Concat(methodName, "Command"))
                If commandProperty IsNot Nothing Then
                    Dim commandObj = TryCast(commandProperty.GetValue(viewModel, Nothing), IDelegateCommand)
                    If commandObj IsNot Nothing Then commandObj.RaiseCanExecuteChanged()
                End If
            End If
        End Sub
    End Module

    Public Module AddressExtension

        <Extension()>
        Public Function ToGeoPoint(ByVal address As Address) As GeoPoint
            Return If(address IsNot Nothing, New GeoPoint(address.Latitude, address.Longitude), Nothing)
        End Function

        <Extension()>
        Public Sub ZoomTo(ByVal zoomService As Map.Dashboard.IZoomToRegionService, ByVal addresses As IEnumerable(Of Address), ByVal Optional margin As Double = 0.25)
            Dim ptA As GeoPoint = Nothing
            Dim ptB As GeoPoint = Nothing
            For Each address In addresses
                If ptA Is Nothing Then
                    ptA = address.ToGeoPoint()
                    ptB = address.ToGeoPoint()
                    Continue For
                End If

                Dim pt As GeoPoint = address.ToGeoPoint()
                If pt Is Nothing OrElse Equals(pt, New GeoPoint(0, 0)) Then Continue For
                ptA.Latitude = Math.Min(ptA.Latitude, pt.Latitude)
                ptA.Longitude = Math.Min(ptA.Longitude, pt.Longitude)
                ptB.Latitude = Math.Max(ptB.Latitude, pt.Latitude)
                ptB.Longitude = Math.Max(ptB.Longitude, pt.Longitude)
            Next

            ZoomCore(zoomService, ptA, ptB, margin)
        End Sub

        <Extension()>
        Public Sub ZoomTo(ByVal zoomService As Map.Dashboard.IZoomToRegionService, ByVal pointA As Address, ByVal pointB As Address, ByVal Optional margin As Double = 0.2)
            Call ZoomCore(zoomService, pointA.ToGeoPoint(), pointB.ToGeoPoint(), margin)
        End Sub

        Private Sub ZoomCore(ByVal zoomService As Map.Dashboard.IZoomToRegionService, ByVal ptA As GeoPoint, ByVal ptB As GeoPoint, ByVal margin As Double)
            If ptA Is Nothing OrElse ptB Is Nothing OrElse zoomService Is Nothing Then Return
            Dim latPadding As Double = CalculatePadding(ptB.Latitude - ptA.Latitude, margin)
            Dim longPadding As Double = CalculatePadding(ptB.Longitude - ptA.Longitude, margin)
            zoomService.ZoomToRegion(New GeoPoint(ptA.Latitude - latPadding, ptA.Longitude - longPadding), New GeoPoint(ptB.Latitude + latPadding, ptB.Longitude + longPadding), New GeoPoint(0.5 * (ptA.Latitude + ptB.Latitude), 0.5 * (ptA.Longitude + ptB.Longitude)))
        End Sub

        Private Function CalculatePadding(ByVal delta As Double, ByVal margin As Double) As Double
            If delta > 0 Then Return Math.Max(0.1, delta * margin)
            If delta < 0 Then Return Math.Min(-0.1, delta * margin)
            Return 0
        End Function
    End Module

    Public Module MapControlExtension

        <Extension()>
        Public Sub Export(ByVal mapControl As MapControl, ByVal imgPath As String)
            mapControl.ExportToImage(imgPath, DevExpress.Drawing.DXImageFormat.Png)
            Open(imgPath)
        End Sub
    End Module
End Namespace
