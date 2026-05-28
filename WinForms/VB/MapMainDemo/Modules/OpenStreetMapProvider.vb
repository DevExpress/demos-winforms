Imports System

Namespace DevExpress.XtraMap.Demos

    Public Partial Class OpenStreetMapProvider
        Inherits FooteredMapTutorialControl

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightText As String
            Get
                Return DemoUtils.OsmCopyright
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitializeOptions()
        End Sub

        Private Sub InitializeOptions()
            tabPaneOptions.AllowCollapse = Utils.DefaultBoolean.True
            listBoxControl1.Items.AddRange(DemoUtils.GetOSMBaseLayers())
            listBoxControl1.SelectedIndex = 0
            listBoxControl2.Items.AddRange(DemoUtils.GetOSMOverlays())
            listBoxControl2.SelectedIndex = 0
        End Sub

        Private Sub OnListBoxControl1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            BaseProvider.Kind = CType(listBoxControl1.SelectedItem, OpenStreetMapKind)
            MiniMapDataProvider.Kind = CType(listBoxControl1.SelectedItem, OpenStreetMapKind)
        End Sub

        Private Sub OnListBoxControl2_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If listBoxControl2.SelectedIndex = 0 Then
                OverlayLayer.Visible = False
            Else
                OverlayLayer.Visible = True
                OverlayProvider.Kind = CType(listBoxControl2.SelectedItem, OpenStreetMapKind)
            End If

            MoveMap(listBoxControl2.SelectedIndex)
        End Sub

        Private Sub OnTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            OverlayLayer.Transparency = CByte(trackBarControl1.Value)
        End Sub

        Private Sub OnTrackBarControl2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            TilesLayer.Transparency = CByte(trackBarControl2.Value)
        End Sub

        Private Sub MoveMap(ByVal index As Integer)
            Select Case index
                Case 0
                    mapControl1.CenterPoint = New GeoPoint(50.067, 14.417)
                    mapControl1.ZoomLevel = 5
                    Exit Select
                Case 1
                    mapControl1.CenterPoint = New GeoPoint(54.15, 11.75)
                    mapControl1.ZoomLevel = 14
                    Exit Select
                Case 2
                    mapControl1.CenterPoint = New GeoPoint(41.5, 2.0)
                    mapControl1.ZoomLevel = 11
                    Exit Select
                Case 3
                    mapControl1.CenterPoint = New GeoPoint(51.5, -3.2)
                    mapControl1.ZoomLevel = 13
                    Exit Select
                Case 4
                    mapControl1.CenterPoint = New GeoPoint(48.85, 2.3)
                    mapControl1.ZoomLevel = 11
                    Exit Select
            End Select
        End Sub

        Private Sub OnWebRequest(ByVal sender As Object, ByVal e As MapWebRequestEventArgs)
            e.Referer = Nothing
            e.UserAgent = "DevExpress Map Demo"
        End Sub
    End Class
End Namespace
