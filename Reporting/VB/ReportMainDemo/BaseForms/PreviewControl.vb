Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.VisualEffects
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.Extensions
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner

Namespace XtraReportsDemos

    ''' <summary>
    ''' Summary description for ModuleControl.
    ''' </summary>
    Public Class PreviewControl
        Inherits DevExpress.DXperience.Demos.TutorialControlBase

#Region "inner classes"
        Protected Class CustomDocumentViewer
            Inherits DevExpress.XtraPrinting.Preview.DocumentViewer

            Public Sub New()
                Me.UseDirectXPaint = If(DevExpress.DXperience.Demos.MainFormHelper.DirectXEnabled, DevExpress.Utils.DefaultBoolean.[True], DevExpress.Utils.DefaultBoolean.[Default])
            End Sub

            Protected Overrides Sub OnViewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
                If e.KeyCode = System.Windows.Forms.Keys.H AndAlso e.Modifiers.HasFlag(System.Windows.Forms.Keys.Control) AndAlso e.Modifiers.HasFlag(System.Windows.Forms.Keys.Shift) Then
                    If Me.PrintingSystem IsNot Nothing Then
                        Me.PrintingSystem.HighlightIntersectedBricks(System.Drawing.Color.Red)
                        Me.Invalidate(True)
                    End If
                Else
                    MyBase.OnViewKeyDown(sender, e)
                End If
            End Sub
        End Class

        Protected NotInheritable Class AdornerController
            Implements System.IDisposable

            Private ReadOnly adornerElements As System.Collections.Generic.IDictionary(Of String, Object)

            Private adorner As DevExpress.Utils.VisualEffects.AdornerUIManager

            Private timer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer() With {.Interval = 4000}

            Public Sub New(ByVal adornerElements As System.Collections.Generic.IDictionary(Of String, Object))
                Me.adornerElements = adornerElements
                AddHandler Me.timer.Tick, AddressOf Me.OnTimerTick
            End Sub

            Private Sub OnTimerTick(ByVal sender As Object, ByVal e As System.EventArgs)
                Me.HideGuides()
            End Sub

            Public Sub Dispose() Implements Global.System.IDisposable.Dispose
                Me.DisposeAdorner()
                Me.DisposeTimer()
            End Sub

            Private Sub DisposeTimer()
                If Me.timer IsNot Nothing Then
                    RemoveHandler Me.timer.Tick, AddressOf Me.OnTimerTick
                    Me.timer.Dispose()
                    Me.timer = Nothing
                End If
            End Sub

            Private Sub DisposeAdorner()
                If Me.adorner IsNot Nothing Then
                    Me.adorner.ShowGuides = DevExpress.Utils.DefaultBoolean.[False]
                    RemoveHandler Me.adorner.Click, AddressOf Me.OnClick
                    Me.adorner.Dispose()
                    Me.adorner = Nothing
                End If
            End Sub

            Public Sub HideGuides()
                If Me.timer IsNot Nothing Then Me.timer.[Stop]()
                Me.DisposeAdorner()
            End Sub

            Public Sub ShowGuides(ByVal owner As System.Windows.Forms.ContainerControl, ByVal [module] As XtraReportsDemos.ReportModule)
                Me.adorner = New DevExpress.Utils.VisualEffects.AdornerUIManager() With {.Owner = owner}
                [module].AddElements(Me.adorner, Me.adornerElements)
                If Me.adorner.Elements.Count > 0 Then
                    Me.timer.Start()
                    Me.adorner.ShowGuides = DevExpress.Utils.DefaultBoolean.[True]
                    AddHandler Me.adorner.Click, AddressOf Me.OnClick
                End If
            End Sub

            Private Sub OnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If Me.adorner IsNot Nothing Then Me.adorner.Owner.BeginInvoke(New System.Action(AddressOf Me.HideGuides))
            End Sub
        End Class

#End Region
#Region "fields"
        Protected panelControl1 As DevExpress.XtraEditors.PanelControl

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private printPreviewBarItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private documentViewerRibbonController1 As DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController

        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private printPreviewStaticItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem

        Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem

        Private progressBarEditItem1 As DevExpress.XtraPrinting.Preview.ProgressBarEditItem

        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

        Private printPreviewBarItem48 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private printPreviewStaticItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem

        Private zoomTrackBarEditItem1 As DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem

        Private repositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar

        Private printPreviewBarItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem4 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem5 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem6 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem7 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem9 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem10 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem11 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem12 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem13 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem14 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem15 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem16 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem17 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem18 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem19 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem20 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem21 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem22 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem23 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem24 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem25 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem26 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem27 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem28 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem29 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem30 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem31 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem32 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem33 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem34 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem35 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem36 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem37 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem38 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem39 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem40 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem41 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem42 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem43 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem44 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem45 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem46 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private printPreviewBarItem47 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private ribbonPage1 As DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPage

        Private printPreviewRibbonPageGroup1 As DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup

        Private printPreviewRibbonPageGroup2 As DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup

        Private printPreviewRibbonPageGroup3 As DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup

        Private printPreviewRibbonPageGroup4 As DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup

        Private printPreviewRibbonPageGroup5 As DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup

        Private printPreviewRibbonPageGroup6 As DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup

        Private printPreviewRibbonPageGroup7 As DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup

        Protected printControl As XtraReportsDemos.PreviewControl.CustomDocumentViewer

        Protected barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private components As System.ComponentModel.IContainer

        Private printPreviewBarItem8 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private lcc As DevExpress.XtraLayout.LayoutControl

        Private lcgRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private lciContent As DevExpress.XtraLayout.LayoutControlItem

        Private lciHeader As DevExpress.XtraLayout.LayoutControlItem

        Private [module] As XtraReportsDemos.ReportModule

        Private _adornerController As XtraReportsDemos.PreviewControl.AdornerController

#End Region
        Public Sub New()
            Me.InitializeComponent()
            Me.AutoMergeRibbon = True
            Me.UpdateRoundedSkinPanel()
            Me._adornerController = New XtraReportsDemos.PreviewControl.AdornerController(New System.Collections.Generic.Dictionary(Of String, Object)() From {{"PageSetup", Me.printPreviewBarItem26}})
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me._adornerController IsNot Nothing Then
                    Me._adornerController.Dispose()
                    Me._adornerController = Nothing
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

        Public Sub Initialize(ByVal manager As DevExpress.DXperience.Demos.RibbonMenuManager)
            Me.RibbonMenuManager = manager
            Dim documentMapPanel As DevExpress.XtraBars.Docking.DockPanel = Me.printControl.GetDockPanel(DevExpress.XtraPrinting.Preview.PreviewDockPanelKind.DocumentMap)
            If documentMapPanel IsNot Nothing Then
                documentMapPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
                documentMapPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            End If
        End Sub

        Public Sub Deactivate()
            If Me.DesignMode Then Return
            Me.printControl.DocumentSource = Nothing
            If Me._adornerController IsNot Nothing Then Me._adornerController.HideGuides()
        End Sub

        Public Sub Activate(ByVal [module] As XtraReportsDemos.ReportModule)
            If Me.DesignMode Then Return
            Me._adornerController.HideGuides()
            Me.[module] = [module]
            Me.[module].Viewer = Me.printControl
            Me.[module].SetPreviewRibbon(Me.ribbonControl1)
            Me.[module].Activate()
            Me.UpdateHeader()
            Me.UpdateRoundedSkinPanel()
            If Equals(Me.RibbonOwnerForm.Ribbon.SelectedPage.Text, "Print Preview") Then Me._adornerController.ShowGuides(CType(Me.RibbonOwnerForm, System.Windows.Forms.ContainerControl), Me.[module])
            Me.printControl.Invalidate(True)
            Dim hasModuleFileName As Boolean = Not String.IsNullOrEmpty([module].FileName)
            Me.barButtonItem2.Enabled = hasModuleFileName
            If hasModuleFileName Then Call XtraReportsDemos.PreviewControl.SafeDeleteFile(Me.[module].FileName)
        End Sub

        Private Sub UpdateHeader()
            Me.lcc.BeginInit()
            If Me.lciHeader.Control IsNot Nothing Then
                Me.lcc.Controls.Remove(Me.lciHeader.Control)
                Me.lciHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If

            Me.lciHeader.Control = Me.[module]?.HeaderContent
            If Me.lciHeader.Control IsNot Nothing Then
                Me.lcc.Controls.Add(Me.lciHeader.Control)
                Me.lciHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            End If

            Me.lcc.EndInit()
            Me.UpdateHeaderBottomSpacing()
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            Me.UpdateHeaderBottomSpacing()
        End Sub

        Protected Overrides ReadOnly Property UseRoundedPanel As Boolean?
            Get
                Return False
            End Get
        End Property

        Private Sub UpdateHeaderBottomSpacing()
            Me.lciHeader.Spacing = New DevExpress.XtraLayout.Utils.Padding(Me.lciHeader.Spacing.Left, Me.lciHeader.Spacing.Right, Me.lciHeader.Spacing.Top, -Me.roundedSkinPanel1.DisplayRectangle.Y)
        End Sub

        Protected Overridable ReadOnly Property Report As XtraReport
            Get
                Return If(Me.[module] IsNot Nothing, Me.[module].Report, Nothing)
            End Get
        End Property

        Private Sub UpdateRoundedSkinPanel()
        'bool useRoundedPanel = module != null && !module.GetUseRoundedPanel();
        'roundedSkinPanel1.BorderStyle = useRoundedPanel
        '    ? RoundedPanelBorderStyle.Default
        '    : RoundedPanelBorderStyle.Rectangular;
        'roundedSkinPanel1.UseDefaultPadding = useRoundedPanel
        '    ? DefaultBoolean.True
        '    : DefaultBoolean.False;
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        ''' 
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim superToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip10 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem10 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip11 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem11 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem11 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip12 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem12 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem12 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip13 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem13 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem13 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip14 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem14 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem14 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip15 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem15 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem15 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip16 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem16 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem16 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip17 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem17 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem17 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip18 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem18 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem18 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip19 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem19 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem19 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip20 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem20 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem20 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip21 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem21 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem21 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip22 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem22 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem22 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip23 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem23 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem23 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip24 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem24 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem24 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip25 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem25 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem25 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip26 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem26 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem26 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip27 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem27 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem27 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip28 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem28 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem28 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip29 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem29 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem29 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip30 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem30 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem30 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip31 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem31 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem31 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip32 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem32 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem32 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip33 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem33 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem33 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip34 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem34 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem34 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip35 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem35 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem35 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip36 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem36 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem36 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip37 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem37 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem37 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip38 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem38 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem38 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip39 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem39 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem39 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip40 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem40 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem40 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip41 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem41 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem41 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip42 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem42 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem42 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip43 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem43 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem43 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip44 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem44 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem44 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip45 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem45 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem45 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip46 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem46 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem46 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportsDemos.PreviewControl))
            Dim superToolTip47 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem47 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem47 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip48 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem48 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem48 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim superToolTip49 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem49 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim toolTipItem49 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Me.lcc = New DevExpress.XtraLayout.LayoutControl()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.printControl = New XtraReportsDemos.PreviewControl.CustomDocumentViewer()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.printPreviewStaticItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
            Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
            Me.progressBarEditItem1 = New DevExpress.XtraPrinting.Preview.ProgressBarEditItem()
            Me.documentViewerRibbonController1 = New DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.printPreviewBarItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem5 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem6 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem7 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem9 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem10 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem11 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem12 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem13 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem14 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem15 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem16 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem17 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem18 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem19 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem20 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem21 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem22 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem23 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem24 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem25 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem26 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem27 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem28 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem29 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem30 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem31 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem32 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem33 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem34 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem35 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem36 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem37 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem38 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem39 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem40 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem41 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem42 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem43 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem44 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem45 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem46 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem47 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.printPreviewBarItem48 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.printPreviewStaticItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
            Me.zoomTrackBarEditItem1 = New DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem()
            Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.printPreviewBarItem8 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
            Me.ribbonPage1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.printPreviewRibbonPageGroup1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup2 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup3 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup4 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup5 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup6 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.printPreviewRibbonPageGroup7 = New DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.lcgRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciHeader = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciContent = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.lcc), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lcc.SuspendLayout()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.documentViewerRibbonController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemZoomTrackBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciHeader), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciContent), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lcc
            ' 
            Me.lcc.Controls.Add(Me.roundedSkinPanel1)
            Me.lcc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lcc.Location = New System.Drawing.Point(0, 307)
            Me.lcc.Margin = New System.Windows.Forms.Padding(0)
            Me.lcc.Name = "lcc"
            Me.lcc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1834, 0, 1300, 800)
            Me.lcc.Root = Me.lcgRoot
            Me.lcc.Size = New System.Drawing.Size(1116, 167)
            Me.lcc.TabIndex = 0
            ' 
            ' roundedSkinPanel1
            ' 
            Me.roundedSkinPanel1.Controls.Add(Me.panelControl1)
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 54)
            Me.roundedSkinPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(1116, 113)
            Me.roundedSkinPanel1.TabIndex = 3
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.printControl)
            Me.panelControl1.Controls.Add(Me.ribbonStatusBar1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(34, 34)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.panelControl1.MinimumSize = New System.Drawing.Size(64, 64)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(1048, 64)
            Me.panelControl1.TabIndex = 4
            ' 
            ' printControl
            ' 
            Me.printControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.printControl.IsMetric = False
            Me.printControl.Location = New System.Drawing.Point(0, 0)
            Me.printControl.Margin = New System.Windows.Forms.Padding(0)
            Me.printControl.Name = "printControl"
            Me.printControl.Size = New System.Drawing.Size(1048, 0)
            Me.printControl.TabIndex = 1
            Me.printControl.UseAsyncDocumentCreation = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar1.ItemLinks.Add(Me.printPreviewStaticItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.barStaticItem1, True)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.progressBarEditItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.printPreviewBarItem48)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.printPreviewStaticItem2)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.zoomTrackBarEditItem1)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, -14)
            Me.ribbonStatusBar1.Margin = New System.Windows.Forms.Padding(0)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1048, 78)
            ' 
            ' printPreviewStaticItem1
            ' 
            Me.printPreviewStaticItem1.Caption = "Nothing"
            Me.printPreviewStaticItem1.Id = 48
            Me.printPreviewStaticItem1.LeftIndent = 1
            Me.printPreviewStaticItem1.Name = "printPreviewStaticItem1"
            Me.printPreviewStaticItem1.RightIndent = 1
            Me.printPreviewStaticItem1.Type = "PageOfPages"
            ' 
            ' barStaticItem1
            ' 
            Me.barStaticItem1.Id = 49
            Me.barStaticItem1.Name = "barStaticItem1"
            Me.barStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
            ' 
            ' progressBarEditItem1
            ' 
            Me.progressBarEditItem1.ContextSpecifier = Me.documentViewerRibbonController1
            Me.progressBarEditItem1.Edit = Me.repositoryItemProgressBar1
            Me.progressBarEditItem1.EditHeight = 12
            Me.progressBarEditItem1.EditWidth = 150
            Me.progressBarEditItem1.Id = 50
            Me.progressBarEditItem1.Name = "progressBarEditItem1"
            Me.progressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' documentViewerRibbonController1
            ' 
            Me.documentViewerRibbonController1.DocumentViewer = Me.printControl
            Me.documentViewerRibbonController1.RibbonControl = Me.ribbonControl1
            Me.documentViewerRibbonController1.RibbonStatusBar = Me.ribbonStatusBar1
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.printPreviewBarItem1, Me.printPreviewBarItem2, Me.printPreviewBarItem3, Me.printPreviewBarItem4, Me.printPreviewBarItem5, Me.printPreviewBarItem6, Me.printPreviewBarItem7, Me.printPreviewBarItem9, Me.printPreviewBarItem10, Me.printPreviewBarItem11, Me.printPreviewBarItem12, Me.printPreviewBarItem13, Me.printPreviewBarItem14, Me.printPreviewBarItem15, Me.printPreviewBarItem16, Me.printPreviewBarItem17, Me.printPreviewBarItem18, Me.printPreviewBarItem19, Me.printPreviewBarItem20, Me.printPreviewBarItem21, Me.printPreviewBarItem22, Me.printPreviewBarItem23, Me.printPreviewBarItem24, Me.printPreviewBarItem25, Me.printPreviewBarItem26, Me.printPreviewBarItem27, Me.printPreviewBarItem28, Me.printPreviewBarItem29, Me.printPreviewBarItem30, Me.printPreviewBarItem31, Me.printPreviewBarItem32, Me.printPreviewBarItem33, Me.printPreviewBarItem34, Me.printPreviewBarItem35, Me.printPreviewBarItem36, Me.printPreviewBarItem37, Me.printPreviewBarItem38, Me.printPreviewBarItem39, Me.printPreviewBarItem40, Me.printPreviewBarItem41, Me.printPreviewBarItem42, Me.printPreviewBarItem43, Me.printPreviewBarItem44, Me.printPreviewBarItem45, Me.printPreviewBarItem46, Me.printPreviewBarItem47, Me.printPreviewStaticItem1, Me.barStaticItem1, Me.progressBarEditItem1, Me.printPreviewBarItem48, Me.barButtonItem1, Me.printPreviewStaticItem2, Me.zoomTrackBarEditItem1, Me.barButtonItem2, Me.printPreviewBarItem8})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 68
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemProgressBar1, Me.repositoryItemZoomTrackBar1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1116, 307)
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            Me.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' printPreviewBarItem1
            ' 
            Me.printPreviewBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem1.Caption = "Bookmarks"
            Me.printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap
            Me.printPreviewBarItem1.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem1.Enabled = False
            Me.printPreviewBarItem1.Id = 1
            Me.printPreviewBarItem1.Name = "printPreviewBarItem1"
            superToolTip1.FixedTooltipWidth = True
            toolTipTitleItem1.Text = "Document Map"
            toolTipItem1.LeftIndent = 6
            toolTipItem1.Text = "Open the Document Map, which allows you to navigate through a structural view of " & "the document."
            superToolTip1.Items.Add(toolTipTitleItem1)
            superToolTip1.Items.Add(toolTipItem1)
            superToolTip1.MaxWidth = 210
            Me.printPreviewBarItem1.SuperTip = superToolTip1
            ' 
            ' printPreviewBarItem2
            ' 
            Me.printPreviewBarItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem2.Caption = "Parameters"
            Me.printPreviewBarItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters
            Me.printPreviewBarItem2.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem2.Enabled = False
            Me.printPreviewBarItem2.Id = 2
            Me.printPreviewBarItem2.Name = "printPreviewBarItem2"
            superToolTip2.FixedTooltipWidth = True
            toolTipTitleItem2.Text = "Parameters"
            toolTipItem2.LeftIndent = 6
            toolTipItem2.Text = "Open the Parameters pane, which allows you to enter values for report parameters." & ""
            superToolTip2.Items.Add(toolTipTitleItem2)
            superToolTip2.Items.Add(toolTipItem2)
            superToolTip2.MaxWidth = 210
            Me.printPreviewBarItem2.SuperTip = superToolTip2
            ' 
            ' printPreviewBarItem3
            ' 
            Me.printPreviewBarItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem3.Caption = "Find"
            Me.printPreviewBarItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find
            Me.printPreviewBarItem3.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem3.Enabled = False
            Me.printPreviewBarItem3.Id = 3
            Me.printPreviewBarItem3.Name = "printPreviewBarItem3"
            superToolTip3.FixedTooltipWidth = True
            toolTipTitleItem3.Text = "Find"
            toolTipItem3.LeftIndent = 6
            toolTipItem3.Text = "Show the Find dialog to find text in the document."
            superToolTip3.Items.Add(toolTipTitleItem3)
            superToolTip3.Items.Add(toolTipItem3)
            superToolTip3.MaxWidth = 210
            Me.printPreviewBarItem3.SuperTip = superToolTip3
            ' 
            ' printPreviewBarItem4
            ' 
            Me.printPreviewBarItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem4.Caption = "Thumbnails"
            Me.printPreviewBarItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Thumbnails
            Me.printPreviewBarItem4.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem4.Enabled = False
            Me.printPreviewBarItem4.Id = 4
            Me.printPreviewBarItem4.Name = "printPreviewBarItem4"
            superToolTip4.FixedTooltipWidth = True
            toolTipTitleItem4.Text = "Thumbnails"
            toolTipItem4.LeftIndent = 6
            toolTipItem4.Text = "Open the Thumbnails, which allows you to navigate through the document."
            superToolTip4.Items.Add(toolTipTitleItem4)
            superToolTip4.Items.Add(toolTipItem4)
            superToolTip4.MaxWidth = 210
            Me.printPreviewBarItem4.SuperTip = superToolTip4
            ' 
            ' printPreviewBarItem5
            ' 
            Me.printPreviewBarItem5.Caption = "Print"
            Me.printPreviewBarItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print
            Me.printPreviewBarItem5.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem5.Enabled = False
            Me.printPreviewBarItem5.Id = 5
            Me.printPreviewBarItem5.Name = "printPreviewBarItem5"
            superToolTip5.FixedTooltipWidth = True
            toolTipTitleItem5.Text = "Print (Ctrl+P)"
            toolTipItem5.LeftIndent = 6
            toolTipItem5.Text = "Select a printer, number of copies and other printing options before printing."
            superToolTip5.Items.Add(toolTipTitleItem5)
            superToolTip5.Items.Add(toolTipItem5)
            superToolTip5.MaxWidth = 210
            Me.printPreviewBarItem5.SuperTip = superToolTip5
            ' 
            ' printPreviewBarItem6
            ' 
            Me.printPreviewBarItem6.Caption = "Quick Print"
            Me.printPreviewBarItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect
            Me.printPreviewBarItem6.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem6.Enabled = False
            Me.printPreviewBarItem6.Id = 6
            Me.printPreviewBarItem6.Name = "printPreviewBarItem6"
            superToolTip6.FixedTooltipWidth = True
            toolTipTitleItem6.Text = "Quick Print"
            toolTipItem6.LeftIndent = 6
            toolTipItem6.Text = "Send the document directly to the default printer without making changes."
            superToolTip6.Items.Add(toolTipTitleItem6)
            superToolTip6.Items.Add(toolTipItem6)
            superToolTip6.MaxWidth = 210
            Me.printPreviewBarItem6.SuperTip = superToolTip6
            ' 
            ' printPreviewBarItem7
            ' 
            Me.printPreviewBarItem7.Caption = "Custom Margins..."
            Me.printPreviewBarItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup
            Me.printPreviewBarItem7.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem7.Enabled = False
            Me.printPreviewBarItem7.Id = 7
            Me.printPreviewBarItem7.Name = "printPreviewBarItem7"
            superToolTip7.FixedTooltipWidth = True
            toolTipTitleItem7.Text = "Page Setup"
            toolTipItem7.LeftIndent = 6
            toolTipItem7.Text = "Show the Page Setup dialog."
            superToolTip7.Items.Add(toolTipTitleItem7)
            superToolTip7.Items.Add(toolTipItem7)
            superToolTip7.MaxWidth = 210
            Me.printPreviewBarItem7.SuperTip = superToolTip7
            ' 
            ' printPreviewBarItem9
            ' 
            Me.printPreviewBarItem9.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem9.Caption = "Scale"
            Me.printPreviewBarItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale
            Me.printPreviewBarItem9.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem9.Enabled = False
            Me.printPreviewBarItem9.Id = 9
            Me.printPreviewBarItem9.Name = "printPreviewBarItem9"
            superToolTip8.FixedTooltipWidth = True
            toolTipTitleItem8.Text = "Scale"
            toolTipItem8.LeftIndent = 6
            toolTipItem8.Text = "Stretch or shrink the printed output to a percentage of its actual size."
            superToolTip8.Items.Add(toolTipTitleItem8)
            superToolTip8.Items.Add(toolTipItem8)
            superToolTip8.MaxWidth = 210
            Me.printPreviewBarItem9.SuperTip = superToolTip8
            ' 
            ' printPreviewBarItem10
            ' 
            Me.printPreviewBarItem10.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem10.Caption = "Pointer"
            Me.printPreviewBarItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Pointer
            Me.printPreviewBarItem10.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem10.Down = True
            Me.printPreviewBarItem10.Enabled = False
            Me.printPreviewBarItem10.GroupIndex = 1
            Me.printPreviewBarItem10.Id = 10
            Me.printPreviewBarItem10.Name = "printPreviewBarItem10"
            Me.printPreviewBarItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            superToolTip9.FixedTooltipWidth = True
            toolTipTitleItem9.Text = "Mouse Pointer"
            toolTipItem9.LeftIndent = 6
            toolTipItem9.Text = "Show the mouse pointer."
            superToolTip9.Items.Add(toolTipTitleItem9)
            superToolTip9.Items.Add(toolTipItem9)
            superToolTip9.MaxWidth = 210
            Me.printPreviewBarItem10.SuperTip = superToolTip9
            ' 
            ' printPreviewBarItem11
            ' 
            Me.printPreviewBarItem11.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem11.Caption = "Hand Tool"
            Me.printPreviewBarItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool
            Me.printPreviewBarItem11.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem11.Enabled = False
            Me.printPreviewBarItem11.GroupIndex = 1
            Me.printPreviewBarItem11.Id = 11
            Me.printPreviewBarItem11.Name = "printPreviewBarItem11"
            Me.printPreviewBarItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            superToolTip10.FixedTooltipWidth = True
            toolTipTitleItem10.Text = "Hand Tool"
            toolTipItem10.LeftIndent = 6
            toolTipItem10.Text = "Invoke the Hand tool to manually scroll through pages."
            superToolTip10.Items.Add(toolTipTitleItem10)
            superToolTip10.Items.Add(toolTipItem10)
            superToolTip10.MaxWidth = 210
            Me.printPreviewBarItem11.SuperTip = superToolTip10
            ' 
            ' printPreviewBarItem12
            ' 
            Me.printPreviewBarItem12.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem12.Caption = "Magnifier"
            Me.printPreviewBarItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier
            Me.printPreviewBarItem12.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem12.Enabled = False
            Me.printPreviewBarItem12.GroupIndex = 1
            Me.printPreviewBarItem12.Id = 12
            Me.printPreviewBarItem12.Name = "printPreviewBarItem12"
            Me.printPreviewBarItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            superToolTip11.FixedTooltipWidth = True
            toolTipTitleItem11.Text = "Magnifier"
            toolTipItem11.LeftIndent = 6
            toolTipItem11.Text = "Invoke the Magnifier tool." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Clicking once on a document zooms it so that a sing" & "le page becomes entirely visible, while clicking another time zooms it to 100% o" & "f the normal size."
            superToolTip11.Items.Add(toolTipTitleItem11)
            superToolTip11.Items.Add(toolTipItem11)
            superToolTip11.MaxWidth = 210
            Me.printPreviewBarItem12.SuperTip = superToolTip11
            ' 
            ' printPreviewBarItem13
            ' 
            Me.printPreviewBarItem13.Caption = "Zoom Out"
            Me.printPreviewBarItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut
            Me.printPreviewBarItem13.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem13.Enabled = False
            Me.printPreviewBarItem13.Id = 13
            Me.printPreviewBarItem13.Name = "printPreviewBarItem13"
            superToolTip12.FixedTooltipWidth = True
            toolTipTitleItem12.Text = "Zoom Out"
            toolTipItem12.LeftIndent = 6
            toolTipItem12.Text = "Zoom out to see more of the page at a reduced size."
            superToolTip12.Items.Add(toolTipTitleItem12)
            superToolTip12.Items.Add(toolTipItem12)
            superToolTip12.MaxWidth = 210
            Me.printPreviewBarItem13.SuperTip = superToolTip12
            ' 
            ' printPreviewBarItem14
            ' 
            Me.printPreviewBarItem14.Caption = "Zoom In"
            Me.printPreviewBarItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn
            Me.printPreviewBarItem14.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem14.Enabled = False
            Me.printPreviewBarItem14.Id = 14
            Me.printPreviewBarItem14.Name = "printPreviewBarItem14"
            superToolTip13.FixedTooltipWidth = True
            toolTipTitleItem13.Text = "Zoom In"
            toolTipItem13.LeftIndent = 6
            toolTipItem13.Text = "Zoom in to get a close-up view of the document."
            superToolTip13.Items.Add(toolTipTitleItem13)
            superToolTip13.Items.Add(toolTipItem13)
            superToolTip13.MaxWidth = 210
            Me.printPreviewBarItem14.SuperTip = superToolTip13
            ' 
            ' printPreviewBarItem15
            ' 
            Me.printPreviewBarItem15.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem15.Caption = "Zoom"
            Me.printPreviewBarItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Zoom
            Me.printPreviewBarItem15.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem15.Enabled = False
            Me.printPreviewBarItem15.Id = 15
            Me.printPreviewBarItem15.Name = "printPreviewBarItem15"
            superToolTip14.FixedTooltipWidth = True
            toolTipTitleItem14.Text = "Zoom"
            toolTipItem14.LeftIndent = 6
            toolTipItem14.Text = "Change the zoom level of the document preview."
            superToolTip14.Items.Add(toolTipTitleItem14)
            superToolTip14.Items.Add(toolTipItem14)
            superToolTip14.MaxWidth = 210
            Me.printPreviewBarItem15.SuperTip = superToolTip14
            ' 
            ' printPreviewBarItem16
            ' 
            Me.printPreviewBarItem16.Caption = "First Page"
            Me.printPreviewBarItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage
            Me.printPreviewBarItem16.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem16.Enabled = False
            Me.printPreviewBarItem16.Id = 16
            Me.printPreviewBarItem16.Name = "printPreviewBarItem16"
            superToolTip15.FixedTooltipWidth = True
            toolTipTitleItem15.Text = "First Page (Home)"
            toolTipItem15.LeftIndent = 6
            toolTipItem15.Text = "Navigate to the first page of the document."
            superToolTip15.Items.Add(toolTipTitleItem15)
            superToolTip15.Items.Add(toolTipItem15)
            superToolTip15.MaxWidth = 210
            Me.printPreviewBarItem16.SuperTip = superToolTip15
            ' 
            ' printPreviewBarItem17
            ' 
            Me.printPreviewBarItem17.Caption = "Previous Page"
            Me.printPreviewBarItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage
            Me.printPreviewBarItem17.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem17.Enabled = False
            Me.printPreviewBarItem17.Id = 17
            Me.printPreviewBarItem17.Name = "printPreviewBarItem17"
            superToolTip16.FixedTooltipWidth = True
            toolTipTitleItem16.Text = "Previous Page (Left Arrow)"
            toolTipItem16.LeftIndent = 6
            toolTipItem16.Text = "Navigate to the previous page of the document."
            superToolTip16.Items.Add(toolTipTitleItem16)
            superToolTip16.Items.Add(toolTipItem16)
            superToolTip16.MaxWidth = 210
            Me.printPreviewBarItem17.SuperTip = superToolTip16
            ' 
            ' printPreviewBarItem18
            ' 
            Me.printPreviewBarItem18.Caption = "Next  Page "
            Me.printPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage
            Me.printPreviewBarItem18.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem18.Enabled = False
            Me.printPreviewBarItem18.Id = 18
            Me.printPreviewBarItem18.Name = "printPreviewBarItem18"
            superToolTip17.FixedTooltipWidth = True
            toolTipTitleItem17.Text = "Next Page (Right Arrow)"
            toolTipItem17.LeftIndent = 6
            toolTipItem17.Text = "Navigate to the next page of the document."
            superToolTip17.Items.Add(toolTipTitleItem17)
            superToolTip17.Items.Add(toolTipItem17)
            superToolTip17.MaxWidth = 210
            Me.printPreviewBarItem18.SuperTip = superToolTip17
            ' 
            ' printPreviewBarItem19
            ' 
            Me.printPreviewBarItem19.Caption = "Last  Page "
            Me.printPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage
            Me.printPreviewBarItem19.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem19.Enabled = False
            Me.printPreviewBarItem19.Id = 19
            Me.printPreviewBarItem19.Name = "printPreviewBarItem19"
            superToolTip18.FixedTooltipWidth = True
            toolTipTitleItem18.Text = "Last Page (End)"
            toolTipItem18.LeftIndent = 6
            toolTipItem18.Text = "Navigate to the last page of the document."
            superToolTip18.Items.Add(toolTipTitleItem18)
            superToolTip18.Items.Add(toolTipItem18)
            superToolTip18.MaxWidth = 210
            Me.printPreviewBarItem19.SuperTip = superToolTip18
            ' 
            ' printPreviewBarItem20
            ' 
            Me.printPreviewBarItem20.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem20.Caption = "Many Pages"
            Me.printPreviewBarItem20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages
            Me.printPreviewBarItem20.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem20.Enabled = False
            Me.printPreviewBarItem20.Id = 20
            Me.printPreviewBarItem20.Name = "printPreviewBarItem20"
            superToolTip19.FixedTooltipWidth = True
            toolTipTitleItem19.Text = "View Many Pages"
            toolTipItem19.LeftIndent = 6
            toolTipItem19.Text = "Choose the page layout to arrange the document pages in preview."
            superToolTip19.Items.Add(toolTipTitleItem19)
            superToolTip19.Items.Add(toolTipItem19)
            superToolTip19.MaxWidth = 210
            Me.printPreviewBarItem20.SuperTip = superToolTip19
            ' 
            ' printPreviewBarItem21
            ' 
            Me.printPreviewBarItem21.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem21.Caption = "Page Color"
            Me.printPreviewBarItem21.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground
            Me.printPreviewBarItem21.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem21.Enabled = False
            Me.printPreviewBarItem21.Id = 21
            Me.printPreviewBarItem21.Name = "printPreviewBarItem21"
            superToolTip20.FixedTooltipWidth = True
            toolTipTitleItem20.Text = "Background Color"
            toolTipItem20.LeftIndent = 6
            toolTipItem20.Text = "Choose a color for the background of the document pages."
            superToolTip20.Items.Add(toolTipTitleItem20)
            superToolTip20.Items.Add(toolTipItem20)
            superToolTip20.MaxWidth = 210
            Me.printPreviewBarItem21.SuperTip = superToolTip20
            ' 
            ' printPreviewBarItem22
            ' 
            Me.printPreviewBarItem22.Caption = "Watermark"
            Me.printPreviewBarItem22.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark
            Me.printPreviewBarItem22.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem22.Enabled = False
            Me.printPreviewBarItem22.Id = 22
            Me.printPreviewBarItem22.Name = "printPreviewBarItem22"
            superToolTip21.FixedTooltipWidth = True
            toolTipTitleItem21.Text = "Watermark"
            toolTipItem21.LeftIndent = 6
            toolTipItem21.Text = "Insert ghosted text or image behind the content of a page." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "This is often used " & "to indicate that a document is to be treated specially."
            superToolTip21.Items.Add(toolTipTitleItem21)
            superToolTip21.Items.Add(toolTipItem21)
            superToolTip21.MaxWidth = 210
            Me.printPreviewBarItem22.SuperTip = superToolTip21
            ' 
            ' printPreviewBarItem23
            ' 
            Me.printPreviewBarItem23.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem23.Caption = "Export To"
            Me.printPreviewBarItem23.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile
            Me.printPreviewBarItem23.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem23.Enabled = False
            Me.printPreviewBarItem23.Id = 23
            Me.printPreviewBarItem23.Name = "printPreviewBarItem23"
            superToolTip22.FixedTooltipWidth = True
            toolTipTitleItem22.Text = "Export To..."
            toolTipItem22.LeftIndent = 6
            toolTipItem22.Text = "Export the current document in one of the available formats, and save it to the f" & "ile on a disk."
            superToolTip22.Items.Add(toolTipTitleItem22)
            superToolTip22.Items.Add(toolTipItem22)
            superToolTip22.MaxWidth = 210
            Me.printPreviewBarItem23.SuperTip = superToolTip22
            ' 
            ' printPreviewBarItem24
            ' 
            Me.printPreviewBarItem24.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem24.Caption = "E-Mail As"
            Me.printPreviewBarItem24.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile
            Me.printPreviewBarItem24.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem24.Enabled = False
            Me.printPreviewBarItem24.Id = 24
            Me.printPreviewBarItem24.Name = "printPreviewBarItem24"
            superToolTip23.FixedTooltipWidth = True
            toolTipTitleItem23.Text = "E-Mail As..."
            toolTipItem23.LeftIndent = 6
            toolTipItem23.Text = "Export the current document in one of the available formats, and attach it to the" & " e-mail."
            superToolTip23.Items.Add(toolTipTitleItem23)
            superToolTip23.Items.Add(toolTipItem23)
            superToolTip23.MaxWidth = 210
            Me.printPreviewBarItem24.SuperTip = superToolTip23
            ' 
            ' printPreviewBarItem25
            ' 
            Me.printPreviewBarItem25.Caption = "Close"
            Me.printPreviewBarItem25.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview
            Me.printPreviewBarItem25.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem25.Enabled = False
            Me.printPreviewBarItem25.Id = 25
            Me.printPreviewBarItem25.Name = "printPreviewBarItem25"
            superToolTip24.FixedTooltipWidth = True
            toolTipTitleItem24.Text = "Close Print Preview"
            toolTipItem24.LeftIndent = 6
            toolTipItem24.Text = "Close Print Preview of the document."
            superToolTip24.Items.Add(toolTipTitleItem24)
            superToolTip24.Items.Add(toolTipItem24)
            superToolTip24.MaxWidth = 210
            Me.printPreviewBarItem25.SuperTip = superToolTip24
            ' 
            ' printPreviewBarItem26
            ' 
            Me.printPreviewBarItem26.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem26.Caption = "Orientation"
            Me.printPreviewBarItem26.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageOrientation
            Me.printPreviewBarItem26.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem26.Enabled = False
            Me.printPreviewBarItem26.Id = 26
            Me.printPreviewBarItem26.Name = "printPreviewBarItem26"
            superToolTip25.FixedTooltipWidth = True
            toolTipTitleItem25.Text = "Page Orientation"
            toolTipItem25.LeftIndent = 6
            toolTipItem25.Text = "Switch the pages between portrait and landscape layouts."
            superToolTip25.Items.Add(toolTipTitleItem25)
            superToolTip25.Items.Add(toolTipItem25)
            superToolTip25.MaxWidth = 210
            Me.printPreviewBarItem26.SuperTip = superToolTip25
            ' 
            ' printPreviewBarItem27
            ' 
            Me.printPreviewBarItem27.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem27.Caption = "Size"
            Me.printPreviewBarItem27.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PaperSize
            Me.printPreviewBarItem27.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem27.Enabled = False
            Me.printPreviewBarItem27.Id = 27
            Me.printPreviewBarItem27.Name = "printPreviewBarItem27"
            superToolTip26.FixedTooltipWidth = True
            toolTipTitleItem26.Text = "Page Size"
            toolTipItem26.LeftIndent = 6
            toolTipItem26.Text = "Choose the paper size of the document."
            superToolTip26.Items.Add(toolTipTitleItem26)
            superToolTip26.Items.Add(toolTipItem26)
            superToolTip26.MaxWidth = 210
            Me.printPreviewBarItem27.SuperTip = superToolTip26
            ' 
            ' printPreviewBarItem28
            ' 
            Me.printPreviewBarItem28.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.printPreviewBarItem28.Caption = "Margins"
            Me.printPreviewBarItem28.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageMargins
            Me.printPreviewBarItem28.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem28.Enabled = False
            Me.printPreviewBarItem28.Id = 28
            Me.printPreviewBarItem28.Name = "printPreviewBarItem28"
            superToolTip27.FixedTooltipWidth = True
            toolTipTitleItem27.Text = "Page Margins"
            toolTipItem27.LeftIndent = 6
            toolTipItem27.Text = "Select the margin sizes for the entire document." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "To apply specific margin size" & "s to the document, click Custom Margins."
            superToolTip27.Items.Add(toolTipTitleItem27)
            superToolTip27.Items.Add(toolTipItem27)
            superToolTip27.MaxWidth = 210
            Me.printPreviewBarItem28.SuperTip = superToolTip27
            ' 
            ' printPreviewBarItem29
            ' 
            Me.printPreviewBarItem29.Caption = "PDF File"
            Me.printPreviewBarItem29.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf
            Me.printPreviewBarItem29.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem29.Description = "Adobe Portable Document Format"
            Me.printPreviewBarItem29.Enabled = False
            Me.printPreviewBarItem29.Id = 29
            Me.printPreviewBarItem29.Name = "printPreviewBarItem29"
            superToolTip28.FixedTooltipWidth = True
            toolTipTitleItem28.Text = "E-Mail As PDF"
            toolTipItem28.LeftIndent = 6
            toolTipItem28.Text = "Export the document to PDF and attach it to the e-mail."
            superToolTip28.Items.Add(toolTipTitleItem28)
            superToolTip28.Items.Add(toolTipItem28)
            superToolTip28.MaxWidth = 210
            Me.printPreviewBarItem29.SuperTip = superToolTip28
            ' 
            ' printPreviewBarItem30
            ' 
            Me.printPreviewBarItem30.Caption = "Text File"
            Me.printPreviewBarItem30.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt
            Me.printPreviewBarItem30.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem30.Description = "Plain Text"
            Me.printPreviewBarItem30.Enabled = False
            Me.printPreviewBarItem30.Id = 30
            Me.printPreviewBarItem30.Name = "printPreviewBarItem30"
            superToolTip29.FixedTooltipWidth = True
            toolTipTitleItem29.Text = "E-Mail As Text"
            toolTipItem29.LeftIndent = 6
            toolTipItem29.Text = "Export the document to Text and attach it to the e-mail."
            superToolTip29.Items.Add(toolTipTitleItem29)
            superToolTip29.Items.Add(toolTipItem29)
            superToolTip29.MaxWidth = 210
            Me.printPreviewBarItem30.SuperTip = superToolTip29
            ' 
            ' printPreviewBarItem31
            ' 
            Me.printPreviewBarItem31.Caption = "CSV File"
            Me.printPreviewBarItem31.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv
            Me.printPreviewBarItem31.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem31.Description = "Comma-Separated Values Text"
            Me.printPreviewBarItem31.Enabled = False
            Me.printPreviewBarItem31.Id = 31
            Me.printPreviewBarItem31.Name = "printPreviewBarItem31"
            superToolTip30.FixedTooltipWidth = True
            toolTipTitleItem30.Text = "E-Mail As CSV"
            toolTipItem30.LeftIndent = 6
            toolTipItem30.Text = "Export the document to CSV and attach it to the e-mail."
            superToolTip30.Items.Add(toolTipTitleItem30)
            superToolTip30.Items.Add(toolTipItem30)
            superToolTip30.MaxWidth = 210
            Me.printPreviewBarItem31.SuperTip = superToolTip30
            ' 
            ' printPreviewBarItem32
            ' 
            Me.printPreviewBarItem32.Caption = "MHT File"
            Me.printPreviewBarItem32.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht
            Me.printPreviewBarItem32.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem32.Description = "Single File Web Page"
            Me.printPreviewBarItem32.Enabled = False
            Me.printPreviewBarItem32.Id = 32
            Me.printPreviewBarItem32.Name = "printPreviewBarItem32"
            superToolTip31.FixedTooltipWidth = True
            toolTipTitleItem31.Text = "E-Mail As MHT"
            toolTipItem31.LeftIndent = 6
            toolTipItem31.Text = "Export the document to MHT and attach it to the e-mail."
            superToolTip31.Items.Add(toolTipTitleItem31)
            superToolTip31.Items.Add(toolTipItem31)
            superToolTip31.MaxWidth = 210
            Me.printPreviewBarItem32.SuperTip = superToolTip31
            ' 
            ' printPreviewBarItem33
            ' 
            Me.printPreviewBarItem33.Caption = "XLS File"
            Me.printPreviewBarItem33.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls
            Me.printPreviewBarItem33.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem33.Description = "Microsoft Excel 2000-2003 Workbook"
            Me.printPreviewBarItem33.Enabled = False
            Me.printPreviewBarItem33.Id = 33
            Me.printPreviewBarItem33.Name = "printPreviewBarItem33"
            superToolTip32.FixedTooltipWidth = True
            toolTipTitleItem32.Text = "E-Mail As XLS"
            toolTipItem32.LeftIndent = 6
            toolTipItem32.Text = "Export the document to XLS and attach it to the e-mail."
            superToolTip32.Items.Add(toolTipTitleItem32)
            superToolTip32.Items.Add(toolTipItem32)
            superToolTip32.MaxWidth = 210
            Me.printPreviewBarItem33.SuperTip = superToolTip32
            ' 
            ' printPreviewBarItem34
            ' 
            Me.printPreviewBarItem34.Caption = "XLSX File"
            Me.printPreviewBarItem34.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx
            Me.printPreviewBarItem34.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem34.Description = "Microsoft Excel 2007 Workbook"
            Me.printPreviewBarItem34.Enabled = False
            Me.printPreviewBarItem34.Id = 34
            Me.printPreviewBarItem34.Name = "printPreviewBarItem34"
            superToolTip33.FixedTooltipWidth = True
            toolTipTitleItem33.Text = "E-Mail As XLSX"
            toolTipItem33.LeftIndent = 6
            toolTipItem33.Text = "Export the document to XLSX and attach it to the e-mail."
            superToolTip33.Items.Add(toolTipTitleItem33)
            superToolTip33.Items.Add(toolTipItem33)
            superToolTip33.MaxWidth = 210
            Me.printPreviewBarItem34.SuperTip = superToolTip33
            ' 
            ' printPreviewBarItem35
            ' 
            Me.printPreviewBarItem35.Caption = "RTF File"
            Me.printPreviewBarItem35.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf
            Me.printPreviewBarItem35.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem35.Description = "Rich Text Format"
            Me.printPreviewBarItem35.Enabled = False
            Me.printPreviewBarItem35.Id = 35
            Me.printPreviewBarItem35.Name = "printPreviewBarItem35"
            superToolTip34.FixedTooltipWidth = True
            toolTipTitleItem34.Text = "E-Mail As RTF"
            toolTipItem34.LeftIndent = 6
            toolTipItem34.Text = "Export the document to RTF and attach it to the e-mail."
            superToolTip34.Items.Add(toolTipTitleItem34)
            superToolTip34.Items.Add(toolTipItem34)
            superToolTip34.MaxWidth = 210
            Me.printPreviewBarItem35.SuperTip = superToolTip34
            ' 
            ' printPreviewBarItem36
            ' 
            Me.printPreviewBarItem36.Caption = "Image File"
            Me.printPreviewBarItem36.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic
            Me.printPreviewBarItem36.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem36.Description = "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF"
            Me.printPreviewBarItem36.Enabled = False
            Me.printPreviewBarItem36.Id = 36
            Me.printPreviewBarItem36.Name = "printPreviewBarItem36"
            superToolTip35.FixedTooltipWidth = True
            toolTipTitleItem35.Text = "E-Mail As Image"
            toolTipItem35.LeftIndent = 6
            toolTipItem35.Text = "Export the document to Image and attach it to the e-mail."
            superToolTip35.Items.Add(toolTipTitleItem35)
            superToolTip35.Items.Add(toolTipItem35)
            superToolTip35.MaxWidth = 210
            Me.printPreviewBarItem36.SuperTip = superToolTip35
            ' 
            ' printPreviewBarItem37
            ' 
            Me.printPreviewBarItem37.Caption = "PDF File"
            Me.printPreviewBarItem37.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf
            Me.printPreviewBarItem37.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem37.Description = "Adobe Portable Document Format"
            Me.printPreviewBarItem37.Enabled = False
            Me.printPreviewBarItem37.Id = 37
            Me.printPreviewBarItem37.Name = "printPreviewBarItem37"
            superToolTip36.FixedTooltipWidth = True
            toolTipTitleItem36.Text = "Export to PDF"
            toolTipItem36.LeftIndent = 6
            toolTipItem36.Text = "Export the document to PDF and save it to the file on a disk."
            superToolTip36.Items.Add(toolTipTitleItem36)
            superToolTip36.Items.Add(toolTipItem36)
            superToolTip36.MaxWidth = 210
            Me.printPreviewBarItem37.SuperTip = superToolTip36
            ' 
            ' printPreviewBarItem38
            ' 
            Me.printPreviewBarItem38.Caption = "HTML File"
            Me.printPreviewBarItem38.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm
            Me.printPreviewBarItem38.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem38.Description = "Web Page"
            Me.printPreviewBarItem38.Enabled = False
            Me.printPreviewBarItem38.Id = 38
            Me.printPreviewBarItem38.Name = "printPreviewBarItem38"
            superToolTip37.FixedTooltipWidth = True
            toolTipTitleItem37.Text = "Export to HTML"
            toolTipItem37.LeftIndent = 6
            toolTipItem37.Text = "Export the document to HTML and save it to the file on a disk."
            superToolTip37.Items.Add(toolTipTitleItem37)
            superToolTip37.Items.Add(toolTipItem37)
            superToolTip37.MaxWidth = 210
            Me.printPreviewBarItem38.SuperTip = superToolTip37
            ' 
            ' printPreviewBarItem39
            ' 
            Me.printPreviewBarItem39.Caption = "Text File"
            Me.printPreviewBarItem39.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt
            Me.printPreviewBarItem39.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem39.Description = "Plain Text"
            Me.printPreviewBarItem39.Enabled = False
            Me.printPreviewBarItem39.Id = 39
            Me.printPreviewBarItem39.Name = "printPreviewBarItem39"
            superToolTip38.FixedTooltipWidth = True
            toolTipTitleItem38.Text = "Export to Text"
            toolTipItem38.LeftIndent = 6
            toolTipItem38.Text = "Export the document to Text and save it to the file on a disk."
            superToolTip38.Items.Add(toolTipTitleItem38)
            superToolTip38.Items.Add(toolTipItem38)
            superToolTip38.MaxWidth = 210
            Me.printPreviewBarItem39.SuperTip = superToolTip38
            ' 
            ' printPreviewBarItem40
            ' 
            Me.printPreviewBarItem40.Caption = "CSV File"
            Me.printPreviewBarItem40.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv
            Me.printPreviewBarItem40.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem40.Description = "Comma-Separated Values Text"
            Me.printPreviewBarItem40.Enabled = False
            Me.printPreviewBarItem40.Id = 40
            Me.printPreviewBarItem40.Name = "printPreviewBarItem40"
            superToolTip39.FixedTooltipWidth = True
            toolTipTitleItem39.Text = "Export to CSV"
            toolTipItem39.LeftIndent = 6
            toolTipItem39.Text = "Export the document to CSV and save it to the file on a disk."
            superToolTip39.Items.Add(toolTipTitleItem39)
            superToolTip39.Items.Add(toolTipItem39)
            superToolTip39.MaxWidth = 210
            Me.printPreviewBarItem40.SuperTip = superToolTip39
            ' 
            ' printPreviewBarItem41
            ' 
            Me.printPreviewBarItem41.Caption = "MHT File"
            Me.printPreviewBarItem41.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht
            Me.printPreviewBarItem41.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem41.Description = "Single File Web Page"
            Me.printPreviewBarItem41.Enabled = False
            Me.printPreviewBarItem41.Id = 41
            Me.printPreviewBarItem41.Name = "printPreviewBarItem41"
            superToolTip40.FixedTooltipWidth = True
            toolTipTitleItem40.Text = "Export to MHT"
            toolTipItem40.LeftIndent = 6
            toolTipItem40.Text = "Export the document to MHT and save it to the file on a disk."
            superToolTip40.Items.Add(toolTipTitleItem40)
            superToolTip40.Items.Add(toolTipItem40)
            superToolTip40.MaxWidth = 210
            Me.printPreviewBarItem41.SuperTip = superToolTip40
            ' 
            ' printPreviewBarItem42
            ' 
            Me.printPreviewBarItem42.Caption = "XLS File"
            Me.printPreviewBarItem42.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls
            Me.printPreviewBarItem42.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem42.Description = "Microsoft Excel 2000-2003 Workbook"
            Me.printPreviewBarItem42.Enabled = False
            Me.printPreviewBarItem42.Id = 42
            Me.printPreviewBarItem42.Name = "printPreviewBarItem42"
            superToolTip41.FixedTooltipWidth = True
            toolTipTitleItem41.Text = "Export to XLS"
            toolTipItem41.LeftIndent = 6
            toolTipItem41.Text = "Export the document to XLS and save it to the file on a disk."
            superToolTip41.Items.Add(toolTipTitleItem41)
            superToolTip41.Items.Add(toolTipItem41)
            superToolTip41.MaxWidth = 210
            Me.printPreviewBarItem42.SuperTip = superToolTip41
            ' 
            ' printPreviewBarItem43
            ' 
            Me.printPreviewBarItem43.Caption = "XLSX File"
            Me.printPreviewBarItem43.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx
            Me.printPreviewBarItem43.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem43.Description = "Microsoft Excel 2007 Workbook"
            Me.printPreviewBarItem43.Enabled = False
            Me.printPreviewBarItem43.Id = 43
            Me.printPreviewBarItem43.Name = "printPreviewBarItem43"
            superToolTip42.FixedTooltipWidth = True
            toolTipTitleItem42.Text = "Export to XLSX"
            toolTipItem42.LeftIndent = 6
            toolTipItem42.Text = "Export the document to XLSX and save it to the file on a disk."
            superToolTip42.Items.Add(toolTipTitleItem42)
            superToolTip42.Items.Add(toolTipItem42)
            superToolTip42.MaxWidth = 210
            Me.printPreviewBarItem43.SuperTip = superToolTip42
            ' 
            ' printPreviewBarItem44
            ' 
            Me.printPreviewBarItem44.Caption = "RTF File"
            Me.printPreviewBarItem44.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf
            Me.printPreviewBarItem44.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem44.Description = "Rich Text Format"
            Me.printPreviewBarItem44.Enabled = False
            Me.printPreviewBarItem44.Id = 44
            Me.printPreviewBarItem44.Name = "printPreviewBarItem44"
            superToolTip43.FixedTooltipWidth = True
            toolTipTitleItem43.Text = "Export to RTF"
            toolTipItem43.LeftIndent = 6
            toolTipItem43.Text = "Export the document to RTF and save it to the file on a disk."
            superToolTip43.Items.Add(toolTipTitleItem43)
            superToolTip43.Items.Add(toolTipItem43)
            superToolTip43.MaxWidth = 210
            Me.printPreviewBarItem44.SuperTip = superToolTip43
            ' 
            ' printPreviewBarItem45
            ' 
            Me.printPreviewBarItem45.Caption = "Image File"
            Me.printPreviewBarItem45.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic
            Me.printPreviewBarItem45.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem45.Description = "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF"
            Me.printPreviewBarItem45.Enabled = False
            Me.printPreviewBarItem45.Id = 45
            Me.printPreviewBarItem45.Name = "printPreviewBarItem45"
            superToolTip44.FixedTooltipWidth = True
            toolTipTitleItem44.Text = "Export to Image"
            toolTipItem44.LeftIndent = 6
            toolTipItem44.Text = "Export the document to Image and save it to the file on a disk."
            superToolTip44.Items.Add(toolTipTitleItem44)
            superToolTip44.Items.Add(toolTipItem44)
            superToolTip44.MaxWidth = 210
            Me.printPreviewBarItem45.SuperTip = superToolTip44
            ' 
            ' printPreviewBarItem46
            ' 
            Me.printPreviewBarItem46.Caption = "Open"
            Me.printPreviewBarItem46.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open
            Me.printPreviewBarItem46.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem46.Enabled = False
            Me.printPreviewBarItem46.Id = 46
            Me.printPreviewBarItem46.Name = "printPreviewBarItem46"
            superToolTip45.FixedTooltipWidth = True
            toolTipTitleItem45.Text = "Open (Ctrl + O)"
            toolTipItem45.LeftIndent = 6
            toolTipItem45.Text = "Open a document."
            superToolTip45.Items.Add(toolTipTitleItem45)
            superToolTip45.Items.Add(toolTipItem45)
            superToolTip45.MaxWidth = 210
            Me.printPreviewBarItem46.SuperTip = superToolTip45
            ' 
            ' printPreviewBarItem47
            ' 
            Me.printPreviewBarItem47.Caption = "Save"
            Me.printPreviewBarItem47.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save
            Me.printPreviewBarItem47.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem47.Enabled = False
            Me.printPreviewBarItem47.Id = 47
            Me.printPreviewBarItem47.Name = "printPreviewBarItem47"
            superToolTip46.FixedTooltipWidth = True
            toolTipTitleItem46.Text = "Save (Ctrl + S)"
            toolTipItem46.LeftIndent = 6
            toolTipItem46.Text = "Save the document."
            superToolTip46.Items.Add(toolTipTitleItem46)
            superToolTip46.Items.Add(toolTipItem46)
            superToolTip46.MaxWidth = 210
            Me.printPreviewBarItem47.SuperTip = superToolTip46
            ' 
            ' printPreviewBarItem48
            ' 
            Me.printPreviewBarItem48.Caption = "Stop"
            Me.printPreviewBarItem48.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding
            Me.printPreviewBarItem48.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem48.Enabled = False
            Me.printPreviewBarItem48.Hint = "Stop"
            Me.printPreviewBarItem48.Id = 51
            Me.printPreviewBarItem48.Name = "printPreviewBarItem48"
            Me.printPreviewBarItem48.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.barButtonItem1.Enabled = False
            Me.barButtonItem1.Id = 52
            Me.barButtonItem1.Name = "barButtonItem1"
            Me.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
            ' 
            ' printPreviewStaticItem2
            ' 
            Me.printPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.printPreviewStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
            Me.printPreviewStaticItem2.Caption = "100%"
            Me.printPreviewStaticItem2.Id = 53
            Me.printPreviewStaticItem2.Name = "printPreviewStaticItem2"
            Me.printPreviewStaticItem2.Type = "ZoomFactorText"
            ' 
            ' zoomTrackBarEditItem1
            ' 
            Me.zoomTrackBarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.zoomTrackBarEditItem1.ContextSpecifier = Me.documentViewerRibbonController1
            Me.zoomTrackBarEditItem1.Edit = Me.repositoryItemZoomTrackBar1
            Me.zoomTrackBarEditItem1.EditValue = 90
            Me.zoomTrackBarEditItem1.EditWidth = 140
            Me.zoomTrackBarEditItem1.Enabled = False
            Me.zoomTrackBarEditItem1.Id = 54
            Me.zoomTrackBarEditItem1.Name = "zoomTrackBarEditItem1"
            Me.zoomTrackBarEditItem1.Range = New Integer() {10, 500}
            ' 
            ' repositoryItemZoomTrackBar1
            ' 
            Me.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center
            Me.repositoryItemZoomTrackBar1.AllowFocused = False
            Me.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemZoomTrackBar1.Maximum = 180
            Me.repositoryItemZoomTrackBar1.Middle = 90
            Me.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Designer"
            Me.barButtonItem2.Id = 57
            Me.barButtonItem2.ImageOptions.SvgImage = CType((resources.GetObject("barButtonItem2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.barButtonItem2.Name = "barButtonItem2"
            toolTipTitleItem47.Text = "Designer"
            toolTipItem47.LeftIndent = 6
            toolTipItem47.Text = "Run Ribbon Report Designer"
            superToolTip47.Items.Add(toolTipTitleItem47)
            superToolTip47.Items.Add(toolTipItem47)
            Me.barButtonItem2.SuperTip = superToolTip47
            AddHandler Me.barButtonItem2.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barButtonItem2_ItemClick)
            ' 
            ' printPreviewBarItem8
            ' 
            Me.printPreviewBarItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.printPreviewBarItem8.Caption = "Editing Fields"
            Me.printPreviewBarItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields
            Me.printPreviewBarItem8.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewBarItem8.Enabled = False
            Me.printPreviewBarItem8.Id = 59
            Me.printPreviewBarItem8.Name = "printPreviewBarItem8"
            superToolTip48.FixedTooltipWidth = True
            toolTipTitleItem48.Text = "Highlight Editing Fields"
            toolTipItem48.LeftIndent = 6
            toolTipItem48.Text = "Highlight all editing fields to quickly discover which of the document elements a" & "re editable."
            superToolTip48.Items.Add(toolTipTitleItem48)
            superToolTip48.Items.Add(toolTipItem48)
            superToolTip48.MaxWidth = 210
            Me.printPreviewBarItem8.SuperTip = superToolTip48
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.ContextSpecifier = Me.documentViewerRibbonController1
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.printPreviewRibbonPageGroup1, Me.printPreviewRibbonPageGroup2, Me.printPreviewRibbonPageGroup3, Me.printPreviewRibbonPageGroup4, Me.printPreviewRibbonPageGroup5, Me.printPreviewRibbonPageGroup6, Me.printPreviewRibbonPageGroup7})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Print Preview"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem2)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded
            Me.ribbonPageGroup1.Text = "Actions"
            ' 
            ' printPreviewRibbonPageGroup1
            ' 
            Me.printPreviewRibbonPageGroup1.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.printPreviewRibbonPageGroup1.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup1.ItemLinks.Add(Me.printPreviewBarItem46)
            Me.printPreviewRibbonPageGroup1.ItemLinks.Add(Me.printPreviewBarItem47)
            Me.printPreviewRibbonPageGroup1.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Document
            Me.printPreviewRibbonPageGroup1.Name = "printPreviewRibbonPageGroup1"
            Me.printPreviewRibbonPageGroup1.Text = "Document"
            ' 
            ' printPreviewRibbonPageGroup2
            ' 
            Me.printPreviewRibbonPageGroup2.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.printPreviewRibbonPageGroup2.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup2.ItemLinks.Add(Me.printPreviewBarItem5)
            Me.printPreviewRibbonPageGroup2.ItemLinks.Add(Me.printPreviewBarItem6)
            Me.printPreviewRibbonPageGroup2.ItemLinks.Add(Me.printPreviewBarItem2)
            Me.printPreviewRibbonPageGroup2.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Print
            Me.printPreviewRibbonPageGroup2.Name = "printPreviewRibbonPageGroup2"
            Me.printPreviewRibbonPageGroup2.Text = "Print"
            ' 
            ' printPreviewRibbonPageGroup3
            ' 
            Me.printPreviewRibbonPageGroup3.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup3.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup3.ItemLinks.Add(Me.printPreviewBarItem9)
            Me.printPreviewRibbonPageGroup3.ItemLinks.Add(Me.printPreviewBarItem28)
            Me.printPreviewRibbonPageGroup3.ItemLinks.Add(Me.printPreviewBarItem26)
            Me.printPreviewRibbonPageGroup3.ItemLinks.Add(Me.printPreviewBarItem27)
            Me.printPreviewRibbonPageGroup3.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.PageSetup
            Me.printPreviewRibbonPageGroup3.Name = "printPreviewRibbonPageGroup3"
            superToolTip49.FixedTooltipWidth = True
            toolTipTitleItem49.Text = "Page Setup"
            toolTipItem49.LeftIndent = 6
            toolTipItem49.Text = "Show the Page Setup dialog."
            superToolTip49.Items.Add(toolTipTitleItem49)
            superToolTip49.Items.Add(toolTipItem49)
            superToolTip49.MaxWidth = 210
            Me.printPreviewRibbonPageGroup3.SuperTip = superToolTip49
            Me.printPreviewRibbonPageGroup3.Text = "Page Setup"
            ' 
            ' printPreviewRibbonPageGroup4
            ' 
            Me.printPreviewRibbonPageGroup4.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.printPreviewRibbonPageGroup4.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem3)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem4)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem1)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem8)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem16, True)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem17)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem18)
            Me.printPreviewRibbonPageGroup4.ItemLinks.Add(Me.printPreviewBarItem19)
            Me.printPreviewRibbonPageGroup4.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Navigation
            Me.printPreviewRibbonPageGroup4.Name = "printPreviewRibbonPageGroup4"
            Me.printPreviewRibbonPageGroup4.Text = "Navigation"
            ' 
            ' printPreviewRibbonPageGroup5
            ' 
            Me.printPreviewRibbonPageGroup5.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.printPreviewRibbonPageGroup5.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem10)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem11)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem12)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem20)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem13)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem15)
            Me.printPreviewRibbonPageGroup5.ItemLinks.Add(Me.printPreviewBarItem14)
            Me.printPreviewRibbonPageGroup5.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Zoom
            Me.printPreviewRibbonPageGroup5.Name = "printPreviewRibbonPageGroup5"
            Me.printPreviewRibbonPageGroup5.Text = "Zoom"
            ' 
            ' printPreviewRibbonPageGroup6
            ' 
            Me.printPreviewRibbonPageGroup6.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.printPreviewRibbonPageGroup6.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup6.ItemLinks.Add(Me.printPreviewBarItem21)
            Me.printPreviewRibbonPageGroup6.ItemLinks.Add(Me.printPreviewBarItem22)
            Me.printPreviewRibbonPageGroup6.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Background
            Me.printPreviewRibbonPageGroup6.Name = "printPreviewRibbonPageGroup6"
            Me.printPreviewRibbonPageGroup6.Text = "Page Background"
            ' 
            ' printPreviewRibbonPageGroup7
            ' 
            Me.printPreviewRibbonPageGroup7.AllowTextClipping = False
            Me.printPreviewRibbonPageGroup7.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.printPreviewRibbonPageGroup7.ContextSpecifier = Me.documentViewerRibbonController1
            Me.printPreviewRibbonPageGroup7.ItemLinks.Add(Me.printPreviewBarItem23)
            Me.printPreviewRibbonPageGroup7.ItemLinks.Add(Me.printPreviewBarItem24)
            Me.printPreviewRibbonPageGroup7.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Export
            Me.printPreviewRibbonPageGroup7.Name = "printPreviewRibbonPageGroup7"
            Me.printPreviewRibbonPageGroup7.Text = "Export"
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            ' 
            ' lcgRoot
            ' 
            Me.lcgRoot.GroupBordersVisible = False
            Me.lcgRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciHeader, Me.lciContent})
            Me.lcgRoot.Name = "Root"
            Me.lcgRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgRoot.Size = New System.Drawing.Size(1116, 167)
            Me.lcgRoot.TextVisible = False
            ' 
            ' lciHeader
            ' 
            Me.lciHeader.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((192)))))), (CInt(((CByte((192)))))))
            Me.lciHeader.AppearanceItemCaption.Options.UseBackColor = True
            Me.lciHeader.Location = New System.Drawing.Point(0, 0)
            Me.lciHeader.Name = "lciUcDisclaimerPanel1"
            Me.lciHeader.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciHeader.Size = New System.Drawing.Size(1116, 54)
            Me.lciHeader.TextVisible = False
            Me.lciHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' lciContent
            ' 
            Me.lciContent.Control = Me.roundedSkinPanel1
            Me.lciContent.Location = New System.Drawing.Point(0, 54)
            Me.lciContent.Name = "lciContent"
            Me.lciContent.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciContent.Size = New System.Drawing.Size(1116, 113)
            Me.lciContent.TextVisible = False
            ' 
            ' PreviewControl
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.lcc)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "PreviewControl"
            Me.Size = New System.Drawing.Size(1116, 474)
            CType((Me.lcc), System.ComponentModel.ISupportInitialize).EndInit()
            Me.lcc.ResumeLayout(False)
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.documentViewerRibbonController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemZoomTrackBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciHeader), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciContent), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private Sub ShowDesignerForm(ByVal designForm As System.Windows.Forms.Form, ByVal parentForm As System.Windows.Forms.Form)
            If designForm Is Nothing OrElse parentForm Is Nothing Then Return
            designForm.MinimumSize = parentForm.MinimumSize
            If parentForm.WindowState = System.Windows.Forms.FormWindowState.Normal Then designForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            If parentForm.WindowState <> System.Windows.Forms.FormWindowState.Minimized Then designForm.Bounds = parentForm.Bounds
            designForm.WindowState = System.Windows.Forms.FormWindowState.Maximized
            parentForm.Visible = False
            designForm.ShowDialog(parentForm)
            parentForm.Visible = True
        End Sub

        Private Sub EditReport(ByVal createForm As System.Func(Of XtraReportsDemos.IDesignForm))
            If Me.[module] Is Nothing Then Return
            Me.Report.StopPageBuilding()
            Me.Report.ReportPrintOptions.DetailCountAtDesignTime = 0
            For Each item As DevExpress.XtraReports.UI.XtraReportBase In Me.Report.AllControls(Of DevExpress.XtraReports.UI.XtraReportBase)()
                item.ReportPrintOptions.DetailCountAtDesignTime = 0
            Next

            System.ComponentModel.DXDisplayNameAttribute.UseResourceManager = True
            Dim fileName As String = Me.[module].FileName
            If Not String.IsNullOrEmpty(fileName) Then Me.EditReport(createForm, Me.[module].Report, fileName)
        End Sub

        Private Sub EditReport(ByVal createForm As System.Func(Of XtraReportsDemos.IDesignForm), ByVal report As DevExpress.XtraReports.UI.XtraReport, ByVal fileName As String)
            Call DevExpress.Utils.Guard.ArgumentNotNull(report, "report")
            Call DevExpress.Utils.Guard.ArgumentNotNull(fileName, "fileName")
            Dim saveFileName As String = System.IO.Path.ChangeExtension(fileName, "sav")
            report.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding)
            report.SaveLayoutToXml(saveFileName)
            Using newReport As DevExpress.XtraReports.UI.XtraReport = DevExpress.XtraReports.UI.XtraReport.FromFile(saveFileName, True)
                Dim designForm As XtraReportsDemos.IDesignForm = createForm()
                designForm.OpenReport(newReport)
                Dim panel As DevExpress.XtraReports.UserDesigner.XRDesignPanel = designForm.ActiveXRDesignPanel
                If panel IsNot Nothing Then panel.FileName = fileName
                Me.ShowDesignerForm(designForm.Form, Me.FindForm())
                If panel IsNot Nothing AndAlso Not panel.IsDisposed AndAlso Not Equals(panel.FileName, fileName) AndAlso System.IO.File.Exists(panel.FileName) Then Call System.IO.File.Copy(panel.FileName, fileName, True)
                If designForm.Form IsNot Nothing Then designForm.Form.Dispose()
            End Using

            If System.IO.File.Exists(fileName) Then
                report.LoadLayout(fileName)
                Try
                    Me.[module].Activate()
                Catch ex As System.Exception
                    Dim form As System.Windows.Forms.Form = Me.FindForm()
                    If form IsNot Nothing Then Call DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel.ParentLookAndFeel, form, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.[Error])
                    If report IsNot Nothing Then
                        report.LoadLayoutFromXml(saveFileName)
                        Me.[module].Activate()
                    End If

                Finally
                    Call XtraReportsDemos.PreviewControl.SafeDeleteFile(fileName)
                End Try
            End If

            Call XtraReportsDemos.PreviewControl.SafeDeleteFile(saveFileName)
        End Sub

        Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            If System.Windows.Forms.Control.ModifierKeys = System.Windows.Forms.Keys.Control Then
                Me.EditReport(Function() New XtraReportsDemos.StandardFormWrapper())
            Else
                Me.EditReport(Function() New XtraReportsDemos.RibbonFormWrapper(System.Windows.Forms.Control.ModifierKeys = System.Windows.Forms.Keys.Shift))
            End If
        End Sub

        Private Shared Sub SafeDeleteFile(ByVal fileName As String)
            Try
                Call System.IO.File.Delete(fileName)
            Catch __unusedUnauthorizedAccessException1__ As System.UnauthorizedAccessException
            End Try
        End Sub
    End Class

    Friend Class DemoReportExtension
        Inherits DevExpress.XtraReports.Extensions.ReportDesignExtension

        Protected Function CreateRepositoryItemImageComboBox(ByVal names As String(), ByVal valuesShift As Integer) As RepositoryItem
            Dim item As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Dim values As Object() = Me.CreateValues(valuesShift, names.Length)
            Dim i As Integer = 0
            While i < values.Length AndAlso i < names.Length
                item.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem(names(i), values(i)))
                i += 1
            End While

            Return item
        End Function

        Private Function CreateValues(ByVal valuesShift As Integer, ByVal count As Integer) As Object()
            Dim values As System.Collections.Generic.List(Of Object) = New System.Collections.Generic.List(Of Object)()
            For i As Integer = valuesShift To valuesShift + count - 1
                values.Add(i)
            Next

            Return values.ToArray()
        End Function
    End Class

    Public Class ReportModuleBase
        Inherits DevExpress.DXperience.Demos.TutorialControlBase

        Protected Overrides ReadOnly Property UseRoundedPanel As Boolean?
            Get
                Return False
            End Get
        End Property

        Protected Overridable ReadOnly Property IsActive As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overridable Sub Activate()
        End Sub

        Public Overridable Function Deactivate() As Task
            Return System.Threading.Tasks.Task.CompletedTask
        End Function

        Public Overridable Function IsExternalPreviewApplicable() As Boolean
            Return False
        End Function

        Public Sub New()
            Me.AutoMergeRibbon = True
        End Sub
    End Class

    Public MustInherit Class ReportModule
        Inherits XtraReportsDemos.ReportModuleBase

        Private _FileName As String, _Report As XtraReport

        Private _viewer As DevExpress.XtraPrinting.Preview.DocumentViewer

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property Viewer As DocumentViewer
            Get
                Return Me._viewer
            End Get

            Set(ByVal value As DocumentViewer)
                Me._viewer = value
                If Me._viewer IsNot Nothing Then Me.OnSetViewer()
            End Set
        End Property

        Private previewRibbon As DevExpress.XtraBars.Ribbon.RibbonControl

        Protected Overrides ReadOnly Property ChildRibbon As RibbonControl
            Get
                Return Me.previewRibbon
            End Get
        End Property

        Protected Overrides ReadOnly Property IsActive As Boolean
            Get
                Return Me.Viewer IsNot Nothing AndAlso System.[Object].ReferenceEquals(Me.Viewer.DocumentSource, Me.DocumentSource)
            End Get
        End Property

        Protected Overrides ReadOnly Property UseRoundedPanel As Boolean?
            Get
                Return False
            End Get
        End Property

        Protected Friend Overridable ReadOnly Property HeaderContent As Control
            Get
                Return Nothing
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property FileName As String
            Get
                Return _FileName
            End Get

            Private Set(ByVal value As String)
                _FileName = value
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property Report As XtraReport
            Get
                Return _Report
            End Get

            Private Set(ByVal value As XtraReport)
                _Report = value
            End Set
        End Property

        Public Sub New()
            Me.Report = Me.CreateReport()
            AddHandler Me.Report.AfterPrint, AddressOf Me.report_AfterPrint
            Me.FileName = XtraReportsDemos.ReportModule.GetReportPath(Me.Report, "repx")
        End Sub

        Private Sub report_AfterPrint(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.Viewer IsNot Nothing AndAlso Me.IsActive Then Me.OnAfterReportPrint()
        End Sub

        Protected Overridable Sub OnAfterReportPrint()
        End Sub

        Protected MustOverride Function CreateReport() As XtraReport

        Public Overrides Async Function Deactivate() As Task
            Try
                Await Me.StopWorkingAsync().ConfigureAwait(False)
            Catch __unusedOperationCanceledException1__ As System.OperationCanceledException
            End Try

            If Me.Report IsNot Nothing AndAlso Me.Report.PrintingSystem IsNot Nothing Then Me.Report.PrintingSystem.ClearContent()
        End Function

        Public Overrides Function IsExternalPreviewApplicable() As Boolean
            Return Me.Viewer Is Nothing OrElse Not Me.Viewer.IsDisposed
        End Function

        Public Sub SetPreviewRibbon(ByVal ribbon As DevExpress.XtraBars.Ribbon.RibbonControl)
            Me.previewRibbon = ribbon
        End Sub

        Protected Overridable Function StopWorkingAsync() As Task
            If Me.Report IsNot Nothing AndAlso Me.Report.PrintingSystem IsNot Nothing Then Return Me.Report.PrintingSystem.CompleteWorkingAsync(True)
            Return System.Threading.Tasks.Task.FromResult(Of Object)(Nothing)
        End Function

        Protected Overridable ReadOnly Property DocumentSource As Object
            Get
                Return Me.Report
            End Get
        End Property

        Public Overridable Sub AddElements(ByVal adorner As DevExpress.Utils.VisualEffects.AdornerUIManager, ByVal targets As System.Collections.Generic.IDictionary(Of String, Object))
        End Sub

        Public Overrides Sub Activate()
            If Me.Viewer Is Nothing OrElse Me.IsActive Then Return
            Me.Viewer.DocumentSource = Me.DocumentSource
            If Me.DocumentSource Is Nothing Then Return
            Me.Viewer.InitiateDocumentCreation()
        End Sub

        Protected Overridable Sub OnSetViewer()
            Me.Viewer.Zoom = 1
        End Sub

        Friend Function GetUseRoundedPanel() As Boolean
            Return Me.UseRoundedPanel.GetValueOrDefault(True)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                Me.DisposeReport()
                Me.HeaderContent?.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Protected Overridable Sub DisposeReport()
            If Me.Report IsNot Nothing Then
                RemoveHandler Me.Report.AfterPrint, AddressOf Me.report_AfterPrint
                Me.Report.Dispose()
                Me.Report = Nothing
            End If
        End Sub

        Private Shared Function GetReportPath(ByVal fReport As DevExpress.XtraReports.UI.XtraReport, ByVal ext As String) As String
            Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim repName As String = fReport.Name
            If String.IsNullOrEmpty(repName) Then repName = fReport.[GetType]().Name
            Dim dirName As String = System.IO.Path.GetDirectoryName(asm.Location)
            Return XtraReportsDemos.ReportModule.GetNewFilePath(System.IO.Path.Combine(dirName, repName), ext)
        End Function

        Private Shared Function GetNewFilePath(ByVal repFullName As String, ByVal ext As String) As String
            Dim i As Integer = 0
            Dim path As String = repFullName & "." & ext
            Dim lastException As System.Exception = Nothing
            While i < 20
                Try
                    Using testStream As System.IO.FileStream = System.IO.File.Open(path, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None)
                    End Using

                    Return path
                Catch e As System.Exception
                    lastException = e
                End Try

                i += 1
                path = repFullName & i.ToString() & "." & ext
            End While

            If lastException IsNot Nothing Then
                System.Diagnostics.Trace.WriteLine("ReportModule.GetNewFilePath error: " & lastException.ToString())
            End If

            Return Nothing
        End Function
    End Class
End Namespace
