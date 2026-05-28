Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views.Widget

Namespace DevExpress.ApplicationUI.Demos

    Partial Class DashboardWidgets

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim widgetDockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer2 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer3 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer4 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer5 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer6 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer7 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer8 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer9 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim widgetDockingContainer10 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.DashboardWidgets))
            Me.newsDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.calendarDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.dateTimeDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.mailDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.weatherDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.tradingDocument = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.widgetView1 = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(Me.components)
            Me.columnDefinition1 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
            Me.columnDefinition2 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
            Me.columnDefinition3 = New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition()
            Me.rowDefinition1 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.rowDefinition2 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.rowDefinition3 = New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition()
            Me.stackGroup1 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
            Me.stackGroup2 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
            Me.stackGroup3 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biFlowMode = New DevExpress.XtraBars.BarButtonItem()
            Me.biStackedMode = New DevExpress.XtraBars.BarButtonItem()
            Me.biTableMode = New DevExpress.XtraBars.BarButtonItem()
            Me.biLeftToRight = New DevExpress.XtraBars.BarButtonItem()
            Me.biRightToLeft = New DevExpress.XtraBars.BarButtonItem()
            Me.biBottomUp = New DevExpress.XtraBars.BarButtonItem()
            Me.biTopDown = New DevExpress.XtraBars.BarButtonItem()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.biFreeMode = New DevExpress.XtraBars.BarButtonItem()
            Me.biDragMode = New DevExpress.XtraBars.BarButtonItem()
            Me.rpSettings = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.pgLayoutMode = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.pgFlowDirection = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.pgMixAction = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.biItemMixer = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            CType((Me.newsDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.calendarDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateTimeDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mailDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.weatherDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tradingDocument), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.widgetView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.columnDefinition1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.columnDefinition2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.columnDefinition3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowDefinition1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowDefinition2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rowDefinition3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stackGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stackGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.stackGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' newsDocument
            ' 
            Me.newsDocument.Caption = "News"
            Me.newsDocument.ColumnIndex = 2
            Me.newsDocument.ControlName = "News"
            Me.newsDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.News"
            Me.newsDocument.Height = 290
            Me.newsDocument.RowIndex = 1
            Me.newsDocument.Width = 496
            ' 
            ' calendarDocument
            ' 
            Me.calendarDocument.Caption = "Calendar"
            Me.calendarDocument.ColumnIndex = 1
            Me.calendarDocument.ControlName = "Calendar"
            Me.calendarDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.Calendar"
            Me.calendarDocument.Height = 295
            Me.calendarDocument.Width = 260
            ' 
            ' dateTimeDocument
            ' 
            Me.dateTimeDocument.Caption = "Date & Time"
            Me.dateTimeDocument.ColumnIndex = 1
            Me.dateTimeDocument.ControlName = "Clock"
            Me.dateTimeDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.Clock"
            Me.dateTimeDocument.Height = 125
            Me.dateTimeDocument.RowIndex = 1
            Me.dateTimeDocument.Width = 276
            ' 
            ' mailDocument
            ' 
            Me.mailDocument.Caption = "Mail"
            Me.mailDocument.ControlName = "Mail"
            Me.mailDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.Mail"
            Me.mailDocument.Height = 176
            Me.mailDocument.RowIndex = 1
            Me.mailDocument.Width = 276
            ' 
            ' weatherDocument
            ' 
            Me.weatherDocument.Caption = "Weather"
            Me.weatherDocument.ColumnIndex = 2
            Me.weatherDocument.ControlName = "Weather"
            Me.weatherDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.Weather"
            Me.weatherDocument.FreeLayoutHeight.UnitValue = 1.1R
            Me.weatherDocument.Height = 227
            Me.weatherDocument.Width = 414
            ' 
            ' tradingDocument
            ' 
            Me.tradingDocument.Caption = "TO-DO"
            Me.tradingDocument.ControlName = "TO-DO"
            Me.tradingDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.ToDoList"
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentManager1.View = Me.widgetView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.widgetView1})
            ' 
            ' widgetView1
            ' 
            Me.widgetView1.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.[False]
            Me.widgetView1.AllowResizeAnimation = DevExpress.Utils.DefaultBoolean.[False]
            Me.widgetView1.Columns.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition() {Me.columnDefinition1, Me.columnDefinition2, Me.columnDefinition3})
            Me.widgetView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.calendarDocument, Me.dateTimeDocument, Me.mailDocument, Me.weatherDocument, Me.newsDocument, Me.tradingDocument})
            Me.widgetView1.DocumentSpacing = 3
            Me.widgetView1.FreeLayoutProperties.FreeLayoutItems.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.calendarDocument, Me.dateTimeDocument, Me.mailDocument, Me.weatherDocument, Me.newsDocument, Me.tradingDocument})
            Me.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout
            widgetDockingContainer3.Element = Me.newsDocument
            widgetDockingContainer4.Element = Me.calendarDocument
            widgetDockingContainer2.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {widgetDockingContainer3, widgetDockingContainer4})
            widgetDockingContainer2.Orientation = System.Windows.Forms.Orientation.Vertical
            widgetDockingContainer7.Element = Me.dateTimeDocument
            widgetDockingContainer8.Element = Me.mailDocument
            widgetDockingContainer6.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {widgetDockingContainer7, widgetDockingContainer8})
            widgetDockingContainer9.Element = Me.weatherDocument
            widgetDockingContainer10.Element = Me.tradingDocument
            widgetDockingContainer5.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {widgetDockingContainer6, widgetDockingContainer9, widgetDockingContainer10})
            widgetDockingContainer5.Orientation = System.Windows.Forms.Orientation.Vertical
            widgetDockingContainer1.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {widgetDockingContainer2, widgetDockingContainer5})
            Me.widgetView1.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {widgetDockingContainer1})
            Me.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.widgetView1.Rows.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition() {Me.rowDefinition1, Me.rowDefinition2, Me.rowDefinition3})
            Me.widgetView1.StackGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup() {Me.stackGroup1, Me.stackGroup2, Me.stackGroup3})
            AddHandler Me.widgetView1.QueryControl, New DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(AddressOf Me.OnQueryControl)
            ' 
            ' stackGroup1
            ' 
            Me.stackGroup1.Caption = "Daily Events"
            Me.stackGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.weatherDocument, Me.newsDocument})
            Me.stackGroup1.Length.UnitValue = 1.5R
            ' 
            ' stackGroup2
            ' 
            Me.stackGroup2.Caption = "Organizer"
            Me.stackGroup2.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.calendarDocument, Me.dateTimeDocument})
            ' 
            ' stackGroup3
            ' 
            Me.stackGroup3.Caption = "Work"
            Me.stackGroup3.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.mailDocument, Me.tradingDocument})
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.biFlowMode, Me.biStackedMode, Me.biTableMode, Me.biLeftToRight, Me.biRightToLeft, Me.biBottomUp, Me.biTopDown, Me.barCheckItem1, Me.biFreeMode, Me.biDragMode})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 13
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpSettings})
            Me.ribbonControl1.Size = New System.Drawing.Size(864, 150)
            ' 
            ' biFlowMode
            ' 
            Me.biFlowMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biFlowMode.Caption = "Flow Layout"
            Me.biFlowMode.GroupIndex = 1
            Me.biFlowMode.Id = 1
            Me.biFlowMode.ImageOptions.SvgImage = CType((resources.GetObject("biFlowMode.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.biFlowMode.Name = "biFlowMode"
            Me.biFlowMode.Tag = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FlowLayout
            AddHandler Me.biFlowMode.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnLayoutModeCheckedChanged)
            ' 
            ' biStackedMode
            ' 
            Me.biStackedMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biStackedMode.Caption = "Stacked Layout"
            Me.biStackedMode.GroupIndex = 1
            Me.biStackedMode.Id = 2
            Me.biStackedMode.ImageOptions.SvgImage = CType((resources.GetObject("biStackedMode.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.biStackedMode.Name = "biStackedMode"
            Me.biStackedMode.Tag = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.StackLayout
            AddHandler Me.biStackedMode.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnLayoutModeCheckedChanged)
            ' 
            ' biTableMode
            ' 
            Me.biTableMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biTableMode.Caption = "Table Layout"
            Me.biTableMode.GroupIndex = 1
            Me.biTableMode.Id = 3
            Me.biTableMode.ImageOptions.SvgImage = CType((resources.GetObject("biTableMode.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.biTableMode.Name = "biTableMode"
            Me.biTableMode.Tag = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.TableLayout
            AddHandler Me.biTableMode.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnLayoutModeCheckedChanged)
            ' 
            ' biLeftToRight
            ' 
            Me.biLeftToRight.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biLeftToRight.Caption = "Left to Right"
            Me.biLeftToRight.Down = True
            Me.biLeftToRight.GroupIndex = 2
            Me.biLeftToRight.Id = 4
            Me.biLeftToRight.ImageOptions.SvgImage = CType((resources.GetObject("biLeftToRight.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.biLeftToRight.Name = "biLeftToRight"
            Me.biLeftToRight.Tag = System.Windows.Forms.FlowDirection.LeftToRight
            AddHandler Me.biLeftToRight.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFlowDirectionCheckedChanged)
            ' 
            ' biRightToLeft
            ' 
            Me.biRightToLeft.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biRightToLeft.Caption = "Right to Left"
            Me.biRightToLeft.GroupIndex = 2
            Me.biRightToLeft.Id = 5
            Me.biRightToLeft.ImageOptions.SvgImage = CType((resources.GetObject("biRightToLeft.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.biRightToLeft.Name = "biRightToLeft"
            Me.biRightToLeft.Tag = System.Windows.Forms.FlowDirection.RightToLeft
            AddHandler Me.biRightToLeft.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFlowDirectionCheckedChanged)
            ' 
            ' biBottomUp
            ' 
            Me.biBottomUp.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biBottomUp.Caption = "Bottom Up"
            Me.biBottomUp.GroupIndex = 2
            Me.biBottomUp.Id = 6
            Me.biBottomUp.ImageOptions.SvgImage = CType((resources.GetObject("biBottomUp.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.biBottomUp.Name = "biBottomUp"
            Me.biBottomUp.Tag = System.Windows.Forms.FlowDirection.BottomUp
            AddHandler Me.biBottomUp.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFlowDirectionCheckedChanged)
            ' 
            ' biTopDown
            ' 
            Me.biTopDown.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biTopDown.Caption = "Top Down"
            Me.biTopDown.GroupIndex = 2
            Me.biTopDown.Id = 7
            Me.biTopDown.ImageOptions.SvgImage = CType((resources.GetObject("biTopDown.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.biTopDown.Name = "biTopDown"
            Me.biTopDown.Tag = System.Windows.Forms.FlowDirection.TopDown
            AddHandler Me.biTopDown.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFlowDirectionCheckedChanged)
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.BindableChecked = True
            Me.barCheckItem1.Caption = "Colored Widgets"
            Me.barCheckItem1.Checked = True
            Me.barCheckItem1.Id = 10
            Me.barCheckItem1.ImageOptions.SvgImage = CType((resources.GetObject("barCheckItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.barCheckItem1.Name = "barCheckItem1"
            AddHandler Me.barCheckItem1.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnCheckedChanged)
            ' 
            ' biFreeMode
            ' 
            Me.biFreeMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biFreeMode.Caption = "Free Layout"
            Me.biFreeMode.Down = True
            Me.biFreeMode.GroupIndex = 1
            Me.biFreeMode.Id = 11
            Me.biFreeMode.ImageOptions.SvgImage = CType((resources.GetObject("biFreeMode.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.biFreeMode.Name = "biFreeMode"
            Me.biFreeMode.Tag = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout
            AddHandler Me.biFreeMode.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnLayoutModeCheckedChanged)
            ' 
            ' biDragMode
            ' 
            Me.biDragMode.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biDragMode.Caption = "Outer Dragging"
            Me.biDragMode.Id = 12
            Me.biDragMode.Name = "biDragMode"
            Me.biDragMode.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
            AddHandler Me.biDragMode.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.ToggleFreeLayoutDragMode)
            ' 
            ' rpSettings
            ' 
            Me.rpSettings.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.pgLayoutMode, Me.pgFlowDirection, Me.pgMixAction, Me.ribbonPageGroup1})
            Me.rpSettings.Name = "rpSettings"
            Me.rpSettings.Text = "Widget view settings"
            ' 
            ' pgLayoutMode
            ' 
            Me.pgLayoutMode.ItemLinks.Add(Me.biFlowMode)
            Me.pgLayoutMode.ItemLinks.Add(Me.biStackedMode)
            Me.pgLayoutMode.ItemLinks.Add(Me.biTableMode)
            Me.pgLayoutMode.ItemLinks.Add(Me.biFreeMode)
            Me.pgLayoutMode.Name = "pgLayoutMode"
            Me.pgLayoutMode.Text = "Layout Mode"
            ' 
            ' pgFlowDirection
            ' 
            Me.pgFlowDirection.ItemLinks.Add(Me.biLeftToRight)
            Me.pgFlowDirection.ItemLinks.Add(Me.biRightToLeft)
            Me.pgFlowDirection.ItemLinks.Add(Me.biBottomUp)
            Me.pgFlowDirection.ItemLinks.Add(Me.biTopDown)
            Me.pgFlowDirection.Name = "pgFlowDirection"
            Me.pgFlowDirection.Text = "Flow Direction"
            ' 
            ' pgMixAction
            ' 
            Me.pgMixAction.AllowTextClipping = False
            Me.pgMixAction.ItemLinks.Add(Me.biItemMixer)
            Me.pgMixAction.ItemLinks.Add(Me.biDragMode)
            Me.pgMixAction.Name = "pgMixAction"
            Me.pgMixAction.Text = "View Actions"
            ' 
            ' biItemMixer
            ' 
            Me.biItemMixer.Caption = "Mix"
            Me.biItemMixer.Id = 18
            Me.biItemMixer.ImageOptions.SvgImage = CType((resources.GetObject("biItemMixer.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.biItemMixer.Name = "biItemMixer"
            AddHandler Me.biItemMixer.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnMixButtonClick)
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barCheckItem1)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Appearance"
            ' 
            ' DashboardWidgets
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "DashboardWidgets"
            Me.Size = New System.Drawing.Size(864, 394)
            CType((Me.newsDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.calendarDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateTimeDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mailDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.weatherDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tradingDocument), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.widgetView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.columnDefinition1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.columnDefinition2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.columnDefinition3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowDefinition1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowDefinition2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rowDefinition3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stackGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stackGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.stackGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager

        Private widgetView1 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView

        Private calendarDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private dateTimeDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private mailDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private weatherDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private newsDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private tradingDocument As DevExpress.XtraBars.Docking2010.Views.Widget.Document

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private rpSettings As DevExpress.XtraBars.Ribbon.RibbonPage

        Private pgLayoutMode As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private pgFlowDirection As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private biItemMixer As DevExpress.XtraBars.BarButtonItem

        Private pgMixAction As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private biFlowMode As DevExpress.XtraBars.BarButtonItem

        Private biStackedMode As DevExpress.XtraBars.BarButtonItem

        Private biTableMode As DevExpress.XtraBars.BarButtonItem

        Private biLeftToRight As DevExpress.XtraBars.BarButtonItem

        Private biRightToLeft As DevExpress.XtraBars.BarButtonItem

        Private biBottomUp As DevExpress.XtraBars.BarButtonItem

        Private biTopDown As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem

        Private biFreeMode As DevExpress.XtraBars.BarButtonItem

        Private biDragMode As DevExpress.XtraBars.BarButtonItem

        Private columnDefinition1 As DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition

        Private columnDefinition2 As DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition

        Private columnDefinition3 As DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition

        Private rowDefinition1 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition

        Private rowDefinition2 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition

        Private rowDefinition3 As DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition

        Private stackGroup1 As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup

        Private stackGroup2 As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup

        Private stackGroup3 As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup
    End Class
End Namespace
