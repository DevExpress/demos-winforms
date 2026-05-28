Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Drawing.Internal
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraCharts.Demos

    Friend Class ChartRibbonMenuManager
        Inherits RibbonMenuManager
        Implements IDisposable

        Private bsiPalettes As BarSubItem

        Private bbiChartDesigner As ButtonBarItem

        Private ReadOnly ribbonForm As RibbonMainForm

        Private disposedValue As Boolean = False

        Public Property CurrentModule As ChartDemoModule

        Friend Sub New(ByVal form As RibbonMainForm)
            MyBase.New(form)
            ribbonForm = form
            form.ReservGroup1.Text = "Chart"
            CreateChartPaletteRibbonItem(form.ReservGroup1)
            CreateChartDesignerRibbonItem(form.ReservGroup1)
        End Sub

#Region "IDisposable Support"
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    If bbiChartDesigner IsNot Nothing Then bbiChartDesigner.Dispose()
                    If bsiPalettes IsNot Nothing Then bsiPalettes.Dispose()
                End If

                bbiChartDesigner = Nothing
                bsiPalettes = Nothing
                disposedValue = True
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
        End Sub

#End Region
        Private Sub CreateChartPaletteRibbonItem(ByVal ribbonPageGroup As RibbonPageGroup)
            Dim chart As ChartControl = New ChartControl()
            bsiPalettes = New BarSubItem()
            bsiPalettes.Caption = "Palette"
            bsiPalettes.ImageOptions.SvgImage = Properties.Resources.Palette
            AddHandler bsiPalettes.ItemClick, AddressOf cbiPaletteName_Click
            Dim paletteNames As String() = chart.GetLocalizedPaletteNames()
            Dim defaultIndex As Integer = 0
            For i As Integer = 0 To paletteNames.Length - 1
                Dim palette As Palette = chart.PaletteRepository(paletteNames(i))
                Dim image As Image = SystemDrawingConverter.UnwrapImage(PaletteUtils.CreateEditorImage(palette, 6))
                Dim cbiPaletteName As CheckBarItem = New CheckBarItem(Manager, paletteNames(i), AddressOf cbiPaletteName_Click)
                cbiPaletteName.Glyph = image
                If Equals(paletteNames(i), chart.PaletteName) Then defaultIndex = i
                bsiPalettes.ItemLinks.Add(cbiPaletteName)
            Next

            ribbonPageGroup.ItemLinks.Add(bsiPalettes)
            If paletteNames.Length > 0 Then
                Dim item As CheckBarItem = TryCast(bsiPalettes.ItemLinks(defaultIndex).Item, CheckBarItem)
                If bsiPalettes IsNot Nothing Then
                    cbiPaletteName_Click(Manager, New ItemClickEventArgs(item, Nothing))
                    item.Checked = True
                End If
            End If

            chart.Dispose()
        End Sub

        Private Sub CreateChartDesignerRibbonItem(ByVal ribbonPageGroup As RibbonPageGroup)
            bbiChartDesigner = New ButtonBarItem(Manager, "Designer", New ItemClickEventHandler(AddressOf bbiChartDesigner_Click))
            bbiChartDesigner.ImageOptions.SvgImage = Properties.Resources.Designer
            ribbonPageGroup.ItemLinks.Add(bbiChartDesigner)
        End Sub

        Private Sub cbiPaletteName_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As CheckBarItem = TryCast(e.Item, CheckBarItem)
            If item IsNot Nothing Then DemosInfo.SetPaletteName(item.Caption)
            UpdateSelectedPalette()
        End Sub

        Private Sub bbiChartDesigner_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim h As IOverlaySplashScreenHandle = ShowProgressPanel()
            CurrentModule.BeforeChartDesignerShown()
            If DemosInfo.RunChartDesigner().Equals(DialogResult.OK) AndAlso bsiPalettes IsNot Nothing Then OnChartDesignerClosed()
            CloseProgressPanel(h)
        End Sub

        Private Sub OnChartDesignerClosed()
            UpdateSelectedPalette()
            CurrentModule.OnChartDesignerClosed()
        End Sub

        Private Sub UpdateSelectedPalette()
            If CurrentModule Is Nothing OrElse CurrentModule.ChartControl Is Nothing Then Return
            Dim paletteName As String = CurrentModule.ChartControl.PaletteName
            Dim count As Integer = bsiPalettes.ItemLinks.Count
            For i As Integer = 0 To count - 1
                Dim item As BarCheckItem = TryCast(bsiPalettes.ItemLinks(i).Item, BarCheckItem)
                If item IsNot Nothing AndAlso CurrentModule IsNot Nothing Then item.Checked = Equals(item.Caption, paletteName)
            Next
        End Sub

        Private Function ShowProgressPanel() As IOverlaySplashScreenHandle
            Dim handle As IOverlaySplashScreenHandle = Nothing
            Try
                handle = SplashScreenManager.ShowOverlayForm(ribbonForm, OverlayWindowOptions.Default)
            Catch
            End Try

            Return handle
        End Function

        Private Sub CloseProgressPanel(ByVal handle As IOverlaySplashScreenHandle)
            Try
                SplashScreenManager.CloseOverlayForm(handle)
            Catch
            End Try
        End Sub

        Friend Sub UpdateMenu(ByVal chartDesignerButtonEnabled As Boolean, ByVal chartPaletteButtonEnabled As Boolean)
            If bsiPalettes IsNot Nothing Then bsiPalettes.Visibility = If(chartPaletteButtonEnabled, BarItemVisibility.Always, BarItemVisibility.Never)
            If bbiChartDesigner IsNot Nothing Then bbiChartDesigner.Visibility = If(chartDesignerButtonEnabled, BarItemVisibility.Always, BarItemVisibility.Never)
            ribbonForm.ReservGroup1.Visible = chartPaletteButtonEnabled OrElse chartDesignerButtonEnabled
        End Sub
    End Class
End Namespace
