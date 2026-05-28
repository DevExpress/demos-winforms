Imports System
Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Svg

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class FloorPlanModule
        Inherits DiagramTutorialControl

        Private homeObjectsStencil As DiagramStencil

        Private backgroundSvgBitmap As SvgBitmap

        Public Sub New()
            InitializeComponent()
            InitializeBackgroundImage()
            InitializeStencils()
            AddHandler diagramControl.CustomDrawBackground, AddressOf DiagramControl_CustomDrawBackground
            AddHandler diagramControl.ItemInitializing, AddressOf DiagramControlItemInitializing
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            LoadDocument("OfficePlan.xml")
        End Sub

        Private Sub InitializeBackgroundImage()
            Const filePath As String = "images/backgrounds/floor.svg"
            Dim assembly = [GetType]().Assembly
            Using stream = AssemblyHelper.GetResourceStream(assembly, filePath, True)
                backgroundSvgBitmap = SvgBitmap.FromStream(stream)
            End Using
        End Sub

        Private Sub InitializeStencils()
            homeObjectsStencil = CreatePredefinedSvgStencil("HomeObjects", "Home Objects", True)
            diagramControl.OptionsBehavior.Stencils = CreateExtendedStencilCollection(homeObjectsStencil)
        End Sub

        Private Sub DiagramControl_CustomDrawBackground(ByVal sender As Object, ByVal e As CustomDrawBackgroundEventArgs)
            Dim graphicsState = e.GraphicsCache.Paint.SaveCacheState(e.GraphicsCache)
            Try
                e.GraphicsCache.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                e.GraphicsCache.TranslateTransform(diagramControl.OptionsView.PageMargin.Left, diagramControl.OptionsView.PageMargin.Top)
                Using svgCache = New GraphicsCacheSvgWrapper(e.GraphicsCache)
                    backgroundSvgBitmap.RenderToSvgGraphics(svgCache)
                End Using
            Finally
                e.GraphicsCache.Paint.RestoreCacheState(e.GraphicsCache, graphicsState)
            End Try
        End Sub

        Private Sub DiagramControlItemInitializing(ByVal sender As Object, ByVal e As DiagramItemInitializingEventArgs)
            Call InitializeSvgShape(homeObjectsStencil, TryCast(e.Item, IDiagramShape))
        End Sub
    End Class
End Namespace
