Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraMap.Demos

    Public Partial Class RouteIsochrones
        Inherits FooteredMapTutorialControl

        Private origin As GeoPoint

        Protected Overrides ReadOnly Property Overlays As MapOverlay()
            Get
                Return MapControl.Overlays.ToArray()
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

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider)
            DemoUtils.SetAzureMapDataProviderKey(SearchProvider)
            DemoUtils.SetAzureMapDataProviderKey(GeoCodeProvider)
            DemoUtils.SetAzureMapDataProviderKey(RouteIsochroneProvider)
            origin = New GeoPoint(42.3589935302734, -71.0586318969727)
            GeoCodeProvider.RequestLocationInformation(origin)
            radioGroup1.SelectedIndex = 0
        End Sub

        Private Sub ParametersChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            UpdateAndCalculateIsochrone()
        End Sub

        Private Sub UpdateAndCalculateIsochrone()
            RouteIsochroneLayer.ClearResults()
            Dim options As AzureRouteIsochroneOptions = New AzureRouteIsochroneOptions()
            layoutControlGroup2.Text = radioGroup1.Properties.Items(radioGroup1.SelectedIndex).Description
            If radioGroup1.SelectedIndex = 0 Then
                Dim timeSeconds As Double = trackBarControl1.Value * 60
                RouteIsochroneProvider.CalculateIsochroneByTime(New RouteWaypoint("", origin), timeSeconds, options)
            Else
                Const metersInMile As Double = 1609.344
                Dim distanceMeters As Double = If(radioGroup1.SelectedIndex = 1, trackBarControl1.Value * 1000, trackBarControl1.Value * metersInMile)
                RouteIsochroneProvider.CalculateIsochroneByDistance(New RouteWaypoint("", origin), distanceMeters, options)
            End If

            SplashScreenManager.ShowDefaultWaitForm(ParentForm, False, False, "", "Calculating the isochrone in process...")
        End Sub

        Private Sub OnGeoCodeLocationInformationReceived(ByVal sender As Object, ByVal args As LocationInformationReceivedEventArgs)
            Dim location As LocationInformation = args.Result.Locations.FirstOrDefault()
            If location IsNot Nothing AndAlso Not origin.Equals(location.Location) Then
                origin = location.Location
                UpdateAndCalculateIsochrone()
            End If
        End Sub

        Private Sub IsochroneItemsGenerating(ByVal sender As Object, ByVal e As LayerItemsGeneratingEventArgs)
            If SplashScreenManager.Default IsNot Nothing AndAlso SplashScreenManager.Default.IsSplashFormVisible Then Call SplashScreenManager.CloseDefaultWaitForm()
            GeocodeLayer.ClearResults()
        End Sub

        Protected Overrides Sub InitRibbon()
            MyBase.InitRibbon()
            ChkShowMinimap.Enabled = False
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            GeoCodeProvider.RequestLocationInformation(Nothing)
        End Sub
    End Class
End Namespace
