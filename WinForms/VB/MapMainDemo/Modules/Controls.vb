Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.Map
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraMap.Demos

    Public Partial Class MapTutorialControl
        Inherits TutorialControlBase
        Implements IDXMenuManager

        Private _InitialCenterPoint As CoordPoint, _InitialZoomFactor As Double

#Region "static"
        Public Shared Function GetSaveFileName(ByVal defaulName As String) As String
            Return GetSaveFileName("Xlsx files(*.xlsx)|*.xlsx|All files (*.*)|*.*", defaulName)
        End Function

        Public Shared Function GetSaveFileName(ByVal filter As String, ByVal defaulName As String) As String
            Using sfDialog As SaveFileDialog = New SaveFileDialog()
                sfDialog.Filter = filter
                sfDialog.FileName = defaulName
                If sfDialog.ShowDialog() <> DialogResult.OK Then Return Nothing
                Return sfDialog.FileName
            End Using
        End Function

        Public Shared Sub ShowFile(ByVal fileName As String, ByVal control As TutorialControlBase)
            If Not File.Exists(fileName) Then Return
            Dim dResult As DialogResult = XtraMessageBox.Show(control.LookAndFeel, control, String.Format("Do you want to open the resulting file: {0} ?", fileName), control.TutorialName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dResult = DialogResult.Yes Then Data.Utils.SafeProcess.Start(fileName)
        End Sub

#End Region
#Region "fields"
        Private ReadOnly imageFormats As Dictionary(Of String, DXImageFormat) = New Dictionary(Of String, DXImageFormat)() From {{"bmp", DXImageFormat.Bmp}, {"jpeg", DXImageFormat.Jpeg}, {"gif", DXImageFormat.Gif}, {"tiff", DXImageFormat.Tiff}, {"png", DXImageFormat.Png}}

        Private menu As LookAndFeelMenu = Nothing

        Private chkShowNavPanel As BarCheckItem

        Private chkNavigation As BarCheckItem

        Private chkMiniMap As BarCheckItem

        Private bbiZoomIn As BarButtonItem

        Private bbiZoomOut As BarButtonItem

        Private bbiInitialView As BarButtonItem

        Private rpgView As RibbonPageGroup

        Protected ribbonControl1 As RibbonControl

        Protected rpOptions As RibbonPage

#End Region
        Public Sub New()
            InitializeComponent()
            AutoMergeRibbon = True
        End Sub

#Region "properties"
        Protected Overrides ReadOnly Property AllowRectangularBorderRounding As Boolean?
            Get
                Return True
            End Get
        End Property

        Protected Overridable ReadOnly Property Overlays As MapOverlay()
            Get
                Return New MapOverlay(-1) {}
            End Get
        End Property

        Protected Overridable ReadOnly Property MiniMapAzureKind As AzureTileset
            Get
                Return AzureTileset.Imagery
            End Get
        End Property

        Protected Overridable ReadOnly Property MiniMapAlignment As MiniMapAlignment
            Get
                Return MiniMapAlignment.BottomLeft
            End Get
        End Property

        Protected ReadOnly Property ChkShowNavigationPanel As BarCheckItem
            Get
                Return chkShowNavPanel
            End Get
        End Property

        Protected ReadOnly Property ChkShowMinimap As BarCheckItem
            Get
                Return chkMiniMap
            End Get
        End Property

        Protected ReadOnly Property ChkLockNavigation As BarCheckItem
            Get
                Return chkNavigation
            End Get
        End Property

        Protected ReadOnly Property OptionsPage As RibbonPage
            Get
                Return rpOptions
            End Get
        End Property

        Protected Property InitialCenterPoint As CoordPoint
            Get
                Return _InitialCenterPoint
            End Get

            Private Set(ByVal value As CoordPoint)
                _InitialCenterPoint = value
            End Set
        End Property

        Protected Property InitialZoomFactor As Double
            Get
                Return _InitialZoomFactor
            End Get

            Private Set(ByVal value As Double)
                _InitialZoomFactor = value
            End Set
        End Property

        Public Overridable ReadOnly Property MapControl As MapControl
            Get
                Return Nothing
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property DemoMainMenu As LookAndFeelMenu
            Get
                Return menu
            End Get

            Set(ByVal value As LookAndFeelMenu)
                menu = value
            End Set
        End Property

        Public Overridable ReadOnly Property ShowOptions As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overridable ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return True
            End Get
        End Property

#End Region
#Region "initialize"
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MapTutorialControl))
            ribbonControl1 = New RibbonControl()
            chkMiniMap = New BarCheckItem()
            chkShowNavPanel = New BarCheckItem()
            chkNavigation = New BarCheckItem()
            bbiZoomIn = New BarButtonItem()
            bbiZoomOut = New BarButtonItem()
            bbiInitialView = New BarButtonItem()
            rpOptions = New RibbonPage()
            rpgView = New RibbonPageGroup()
            CType(ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            ribbonControl1.ExpandCollapseItem.Id = 0
            ribbonControl1.Items.AddRange(New BarItem() {ribbonControl1.ExpandCollapseItem, chkMiniMap, chkShowNavPanel, chkNavigation, bbiZoomIn, bbiZoomOut, bbiInitialView})
            ribbonControl1.Location = New System.Drawing.Point(0, 0)
            ribbonControl1.MaxItemId = 7
            ribbonControl1.Name = "ribbonControl1"
            ribbonControl1.Pages.AddRange(New RibbonPage() {rpOptions})
            ribbonControl1.Size = New System.Drawing.Size(500, 141)
            ' 
            ' chkShowMiniMap
            ' 
            chkMiniMap.Caption = "Show Minimap"
            chkMiniMap.Id = 1
            chkMiniMap.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Travel_Map
            chkMiniMap.Name = "chkShowMiniMap"
            AddHandler chkMiniMap.CheckedChanged, New ItemClickEventHandler(AddressOf chkShowMiniMap_CheckedChanged)
            ' 
            ' chkShowNavPanel
            ' 
            chkShowNavPanel.BindableChecked = True
            chkShowNavPanel.Caption = "Show Navigation Panel"
            chkShowNavPanel.Checked = True
            chkShowNavPanel.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Action_NavigationBar
            chkShowNavPanel.Id = 2
            chkShowNavPanel.Name = "chkShowNavPanel"
            AddHandler chkShowNavPanel.CheckedChanged, New ItemClickEventHandler(AddressOf chkShowNavPanel_CheckedChanged)
            ' 
            ' chkLockNavigation
            ' 
            chkNavigation.Caption = "Lock Navigation"
            chkNavigation.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.LockNavigation
            chkNavigation.Id = 3
            chkNavigation.Name = "chkLockNavigation"
            AddHandler chkNavigation.CheckedChanged, New ItemClickEventHandler(AddressOf chkLockNavigation_CheckedChanged)
            'this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            ' 
            ' bbiZoomIn
            ' 
            bbiZoomIn.Caption = "Zoom In"
            bbiZoomIn.Id = 4
            bbiZoomIn.Name = "bbiZoomIn"
            AddHandler bbiZoomIn.ItemClick, New ItemClickEventHandler(AddressOf bbiZoomIn_ItemClick)
            bbiZoomIn.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.ZoomIn
            ' 
            ' bbiZoomOut
            ' 
            bbiZoomOut.Caption = "Zoom Out"
            bbiZoomOut.Id = 5
            bbiZoomOut.Name = "bbiZoomOut"
            AddHandler bbiZoomOut.ItemClick, New ItemClickEventHandler(AddressOf bbiZoomOut_ItemClick)
            bbiZoomOut.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.ZoomOut
            ' 
            ' bbiInitialView
            ' 
            bbiInitialView.Caption = "Initial View"
            bbiInitialView.Id = 6
            bbiInitialView.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.InitialView
            bbiInitialView.Name = "bbiInitialView"
            AddHandler bbiInitialView.ItemClick, New ItemClickEventHandler(AddressOf bbiInitialView_ItemClick)
            ' 
            ' ribbonPage1
            ' 
            rpOptions.Name = "ribbonPage1"
            rpOptions.Text = "Options"
            rpOptions.Groups.Add(rpgView)
            ' 
            ' ribbonPageGroup1
            ' 
            rpgView.ItemLinks.Add(chkShowNavPanel)
            rpgView.ItemLinks.Add(chkNavigation)
            rpgView.ItemLinks.Add(chkMiniMap)
            rpgView.ItemLinks.Add(bbiZoomIn)
            rpgView.ItemLinks.Add(bbiZoomOut)
            rpgView.ItemLinks.Add(bbiInitialView)
            rpgView.Name = "ribbonPageGroup1"
            rpgView.Text = "View"
            ' 
            ' MapTutorialControl
            ' 
            Controls.Add(ribbonControl1)
            Name = "MapTutorialControl"
            Size = New System.Drawing.Size(500, 500)
            AddHandler Load, New EventHandler(AddressOf MapTutorialControl_Load)
            CType(ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region
#Region "IDXMenuManager"
        Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As System.Drawing.Point) Implements IDXMenuManager.ShowPopupMenu
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, Me, control, pos)
        End Sub

        Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
            Return Me
        End Function

        Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager
        End Sub

#End Region  ' IDXMenuManager
        Private Sub InitializeMiniMap()
            Dim miniMap As MiniMap = New MiniMap()
            miniMap.Behavior = New DynamicMiniMapBehavior() With {.ZoomOffset = -5}
            miniMap.Layers.Add(CreateMiniMapLayer())
            miniMap.Alignment = MiniMapAlignment
            MapControl.MiniMap = miniMap
        End Sub

        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then be.MenuManager = manager
        End Sub

        Protected Overrides Sub AllowExport()
            EnabledPrintExportActions(True, True, ExportFormats.PDF Or ExportFormats.MHT Or ExportFormats.RTF Or ExportFormats.XLS Or ExportFormats.XLSX Or ExportFormats.Image Or ExportFormats.DOCX, False)
        End Sub

        Protected Overrides Sub PrintPreview()
            If MapControl IsNot Nothing Then MapControl.ShowRibbonPrintPreview()
        End Sub

        Protected Overrides Sub Print()
            If MapControl IsNot Nothing Then MapControl.Print()
        End Sub

        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
            Dim map As MapControl = MapControl
            If map IsNot Nothing Then
                Dim currentCursor As Cursor = Cursor.Current
                Cursor.Current = Cursors.WaitCursor
                If Equals(ext, "rtf") Then
                    map.ExportToRtf(filename)
                ElseIf Equals(ext, "pdf") Then
                    map.ExportToPdf(filename)
                ElseIf Equals(ext, "mht") Then
                    map.ExportToMht(filename)
                ElseIf Equals(ext, "xls") Then
                    map.ExportToXls(filename)
                ElseIf Equals(ext, "xlsx") Then
                    map.ExportToXlsx(filename)
                ElseIf Equals(ext, "docx") Then
                    map.ExportToDocx(filename)
                End If

                Cursor.Current = currentCursor
            End If
        End Sub

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            If obj Is Nothing Then Return False
            Return [GetType]().Equals(obj.GetType())
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return [GetType]().GetHashCode()
        End Function

        Protected Overrides Sub ExportToImage()
            If MapControl Is Nothing Then Return
            Dim fileName As String = MainFormHelper.GetFileName("", GetImageFormatsFilter())
            If Not String.IsNullOrEmpty(fileName) Then MapControl.ExportToImage(fileName, imageFormats(Path.GetExtension(fileName).TrimStart("."c).ToLower()))
        End Sub

        Protected Overridable Function CreateMiniMapLayer() As MiniMapLayerBase
            Dim miniMapImageTilesLayer As MiniMapImageTilesLayer = New MiniMapImageTilesLayer()
            Dim miniMapDataProvider As AzureMapDataProvider = New AzureMapDataProvider()
            miniMapDataProvider.Tileset = MiniMapAzureKind
            DemoUtils.SetAzureMapDataProviderKey(miniMapDataProvider)
            miniMapImageTilesLayer.DataProvider = miniMapDataProvider
            Return miniMapImageTilesLayer
        End Function

        Private Function GetImageFormatsFilter() As String
            Dim result As String = String.Empty
            For Each format As String In imageFormats.Keys
                result += String.Format("{0} Image (*.{1})|*.{1}|", format.ToUpper(), format.ToLower())
            Next

            Return result.TrimEnd("|"c)
        End Function

        Private Sub chkShowMiniMap_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If MapControl.MiniMap Is Nothing Then InitializeMiniMap()
            MapControl.MiniMap.Visible = CType(e.Item, BarCheckItem).Checked
        End Sub

        Private Sub chkShowNavPanel_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If MapControl IsNot Nothing Then MapControl.NavigationPanelOptions.Visible = CType(e.Item, BarCheckItem).Checked
        End Sub

        Private Sub chkLockNavigation_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ChangeEnableNavigation(Not CType(e.Item, BarCheckItem).Checked)
        End Sub

        Private Sub bbiZoomIn_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            MapControl.ZoomIn()
        End Sub

        Private Sub bbiZoomOut_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            MapControl.ZoomOut()
        End Sub

        Private Sub bbiInitialView_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            RestoreInitialView()
        End Sub

        Protected Overridable Sub RestoreInitialView()
            MapControl.CenterPoint = InitialCenterPoint
            MapControl.ZoomLevel = InitialZoomFactor
        End Sub

        Protected Overridable Sub ChangeEnableNavigation(ByVal enable As Boolean)
            MapControl.EnableScrolling = enable
            MapControl.EnableZooming = enable
            bbiZoomIn.Enabled = enable
            bbiZoomOut.Enabled = enable
        End Sub

        Protected Overridable Sub InitRibbon()
            chkMiniMap.Checked = MapControl IsNot Nothing AndAlso MapControl.MiniMap IsNot Nothing AndAlso MapControl.MiniMap.Visible
            chkShowNavPanel.Checked = MapControl IsNot Nothing AndAlso MapControl.NavigationPanelOptions IsNot Nothing AndAlso MapControl.NavigationPanelOptions.Visible
        End Sub

        Protected Sub DisableZoomOptions()
            bbiZoomIn.Enabled = False
            bbiZoomOut.Enabled = False
        End Sub

        Protected Overrides Sub ExportToPDF()
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf")
        End Sub

        Protected Overrides Sub ExportToHTML()
            ExportTo("html", "HTML document (*.html)|*.html")
        End Sub

        Protected Overrides Sub ExportToMHT()
            ExportTo("mht", "MHT document (*.mht)|*.mht")
        End Sub

        Protected Overrides Sub ExportToXLS()
            ExportTo("xls", "XLS document (*.xls)|*.xls")
        End Sub

        Protected Overrides Sub ExportToXLSX()
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx")
        End Sub

        Protected Overrides Sub ExportToRTF()
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf")
        End Sub

        Protected Overrides Sub ExportToText()
            ExportTo("txt", "Text document (*.txt)|*.txt")
        End Sub

        Protected Overrides Sub ExportToDOCX()
            ExportTo("docx", "DOCX document (*.docx)|*.docx")
        End Sub

        Public Sub AppendOverlays()
            If MapControl Is Nothing Then Return
            Dim overlays As MapOverlay() = Me.Overlays
            MapControl.Overlays.Clear()
            MapControl.Overlays.AddRange(overlays)
        End Sub

        Private Sub MapTutorialControl_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitRibbon()
            InitialCenterPoint = If(MapControl IsNot Nothing, MapControl.CenterPoint, Nothing)
            InitialZoomFactor = If(MapControl IsNot Nothing, MapControl.ZoomLevel, 1)
        End Sub
    End Class

    Public Module MapModulesPool

        Const MaxModulesCount As Integer = 5

        Private ReadOnly modules As List(Of MapTutorialControl) = New List(Of MapTutorialControl)(MaxModulesCount)

        Private Sub UnregisterModule(ByVal [module] As MapTutorialControl)
            If Not modules.Contains([module]) Then Return
            Dim moduleInfo As ModuleInfo = ModulesInfo.GetItem([module].TutorialName)
            moduleInfo.ResetModule()
            If Not [module].IsDisposed Then [module].Dispose()
            modules.Remove([module])
        End Sub

        Public Sub RegisterModule(ByVal [module] As MapTutorialControl)
            If modules.Remove([module]) Then
                modules.Add([module])
                Return
            End If

            If modules.Count = MaxModulesCount Then UnregisterModule(modules(0))
            modules.Add([module])
        End Sub

        Public Function GetPreviousModule() As MapTutorialControl
            Return If(modules.Count > 0, modules(modules.Count - 1), Nothing)
        End Function
    End Module
End Namespace
