Imports System
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraDiagram.Docking
Imports DevExpress.XtraDiagram.Utils

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class DiagramTutorialControlBase
        Inherits TutorialControlBase

#Region "Static"
        Public Shared Function GetDataFileName(ByVal fileName As String) As String
            Return DataDirectoryHelper.GetDataFile(Path.Combine("Diagram", fileName))
        End Function

        Private Shared Sub SubscribeRibbonEvents(ByVal ribbon As RibbonControl)
            If ribbon IsNot Nothing Then
                AddHandler ribbon.Merge, AddressOf Ribbon_Merge
                AddHandler ribbon.UnMerge, AddressOf Ribbon_UnMerge
            End If
        End Sub

        Private Shared Sub UnsubscribeRibbonEvents(ByVal ribbon As RibbonControl)
            If ribbon IsNot Nothing Then
                RemoveHandler ribbon.Merge, AddressOf Ribbon_Merge
                RemoveHandler ribbon.UnMerge, AddressOf Ribbon_UnMerge
            End If
        End Sub

        Private Shared Sub Ribbon_Merge(ByVal sender As Object, ByVal e As RibbonMergeEventArgs)
            e.MergeOwner.ApplicationButtonDropDownControl = e.MergedChild.ApplicationButtonDropDownControl
            e.MergeOwner.ToolbarLocation = RibbonQuickAccessToolbarLocation.Default
            e.MergeOwner.ShowApplicationButton = DefaultBoolean.Default
        End Sub

        Private Shared Sub Ribbon_UnMerge(ByVal sender As Object, ByVal e As RibbonMergeEventArgs)
            e.MergeOwner.ApplicationButtonDropDownControl = Nothing
            e.MergeOwner.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden
            e.MergeOwner.ShowApplicationButton = DefaultBoolean.False
        End Sub

#End Region
        Private showOptionsPanelCore As Boolean = False

        Private needOptionsPageCore As Boolean = True

        Private isPanAndZoomVisible As Boolean

        Private isModuleLoaded As Boolean

        Private canUpdateVisibility As Boolean

        <DefaultValue(False)>
        Public Property ShowOptionsPanel As Boolean
            Get
                Return showOptionsPanelCore
            End Get

            Set(ByVal value As Boolean)
                If showOptionsPanelCore = value Then Return
                showOptionsPanelCore = value
                UpdateOptionsPanelVisibility()
            End Set
        End Property

        <DefaultValue(True)>
        Public Property NeedOptionsPage As Boolean
            Get
                Return needOptionsPageCore
            End Get

            Set(ByVal value As Boolean)
                If needOptionsPageCore = value Then Return
                needOptionsPageCore = value
                IncludeOptionsPageIfNeeded()
            End Set
        End Property

        Public Sub PlaceOptionsPanelControlsWithoutTabPane()
            sidePanel.Controls.Remove(tabPane)
            sidePanel.Controls.AddRange(optionsPage.Controls.Cast(Of Control)().ToArray())
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property AutoMergeRibbon As Boolean
            Get
                Return True
            End Get

            Set(ByVal value As Boolean)
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public ReadOnly Property OptionsPageControls As ObservableCollection(Of Control)
            Get
                If optionsPageControlsField Is Nothing Then
                    optionsPageControlsField = New ObservableCollection(Of Control)()
                    AddHandler optionsPageControlsField.CollectionChanged, AddressOf Me.OptionsPageControls_CollectionChanged
                End If

                Return optionsPageControlsField
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public ReadOnly Property OptionsTabPanePages As ObservableCollection(Of NavigationPageBase)
            Get
                If optionsTabPanePagesField Is Nothing Then
                    optionsTabPanePagesField = New ObservableCollection(Of NavigationPageBase)()
                    AddHandler optionsTabPanePagesField.CollectionChanged, AddressOf OptionsTabPanePages_CollectionChanged
                End If

                Return optionsTabPanePagesField
            End Get
        End Property

        <DefaultValue(200)>
        Public Property OptionsSidePanelWidth As Integer
            Get
                Return sidePanel.Size.Width
            End Get

            Set(ByVal value As Integer)
                sidePanel.Size = New Size(value, sidePanel.Height)
            End Set
        End Property

        Protected ReadOnly Property OptionsSidePanel As Control
            Get
                Return sidePanel
            End Get
        End Property

        Protected ReadOnly Property Diagram As DiagramControl
            Get
                Return diagramControl
            End Get
        End Property

        Protected Overridable ReadOnly Property Ribbon As RibbonControl
            Get
                Return Nothing
            End Get
        End Property

        Protected Overridable ReadOnly Property PanAndZoomVisibleOnInitialized As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            isPanAndZoomVisible = PanAndZoomVisibleOnInitialized
            InitializeComponent()
            IncludeOptionsPageIfNeeded()
            If isPanAndZoomVisible Then CreateDockingWithPanAndZoom()
        End Sub

        Protected Overridable Sub CreateDockingWithPanAndZoom()
            Diagram.CreateDocking(DockingMode.PanZoom)
            SubscribePanAndZoomEvents()
            BorderStyle = BorderStyle.None
        End Sub

        Protected Sub SubscribePanAndZoomEvents()
            DoPanAndZoomPanelAction(Sub(panel) AddHandler panel.VisibilityChanged, AddressOf OnPanAndZoomPanelVisibilityChanged)
        End Sub

        Protected Sub UnsubscribePanAndZoomEvents()
            DoPanAndZoomPanelAction(Sub(panel) RemoveHandler panel.VisibilityChanged, AddressOf OnPanAndZoomPanelVisibilityChanged)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            UnsubscribeRibbonEvents(Ribbon)
            UnsubscribePanAndZoomEvents()
            UnsubscribeOptionsPanelEvents()
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            UpdateOptionsPanelVisibility()
            If Ribbon IsNot Nothing Then BarUtils.ForEachRibbonPageGroup(Ribbon, Sub(group)
                group.Visible = group.ItemLinks.Any(Function(x) x.CanVisible)
            End Sub)
            SubscribeRibbonEvents(Ribbon)
            Diagram.OptionsView.ShowPanAndZoomPanel = isPanAndZoomVisible
            isModuleLoaded = True
        End Sub

        Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
            MyBase.OnVisibleChanged(e)
            If Not isModuleLoaded Then Return
            canUpdateVisibility = False
            diagramControl.OptionsView.ShowPanAndZoomPanel = If(Visible, isPanAndZoomVisible, False)
            canUpdateVisibility = True
        End Sub

        Private Sub OnPanAndZoomPanelVisibilityChanged(ByVal sender As Object, ByVal e As VisibilityChangedEventArgs)
            If Not isModuleLoaded Then Return
            If canUpdateVisibility Then isPanAndZoomVisible = e.Visibility = DockVisibility.Visible
        End Sub

        Private Sub UpdateOptionsPanelVisibility()
            sidePanel.Visible = ShowOptionsPanel
        End Sub

        Private Sub IncludeOptionsPageIfNeeded()
            If NeedOptionsPage Then
                If Not tabPane.Controls.Contains(optionsPage) Then
                    tabPane.Controls.Add(optionsPage)
                    tabPane.Pages.AddRange(New NavigationPageBase() {optionsPage})
                End If
            ElseIf tabPane.Controls.Contains(optionsPage) Then
                tabPane.Controls.Remove(optionsPage)
                tabPane.Pages.Remove(optionsPage)
            End If
        End Sub

        Protected Sub LoadDocument(ByVal fileName As String)
            Dim filePath As String = GetDataFileName(fileName)
            Diagram.LoadDocument(filePath)
        End Sub

        Private Sub DoPanAndZoomPanelAction(ByVal action As Action(Of PanAndZoomDockPanel))
            If Diagram Is Nothing Then Return
            Dim panel = TryCast(Diagram.PanAndZoom, PanAndZoomDockPanel)
            If panel IsNot Nothing Then action(panel)
        End Sub

        Private optionsPageControlsField As ObservableCollection(Of Control)

        Private optionsTabPanePagesField As ObservableCollection(Of NavigationPageBase)

        Private Sub OptionsPageControls_CollectionChanged(ByVal sender As Object, ByVal e As Collections.Specialized.NotifyCollectionChangedEventArgs)
            If e.Action = Collections.Specialized.NotifyCollectionChangedAction.Add Then optionsPage.Controls.AddRange(e.NewItems.Cast(Of Control)().ToArray())
        End Sub

        Private Sub OptionsTabPanePages_CollectionChanged(ByVal sender As Object, ByVal e As Collections.Specialized.NotifyCollectionChangedEventArgs)
            If e.Action = Collections.Specialized.NotifyCollectionChangedAction.Add Then tabPane.Pages.AddRange(e.NewItems.Cast(Of NavigationPageBase)().ToArray())
        End Sub

        Private Sub UnsubscribeOptionsPanelEvents()
            If optionsPageControlsField IsNot Nothing Then RemoveHandler optionsPageControlsField.CollectionChanged, AddressOf Me.OptionsPageControls_CollectionChanged
            If optionsTabPanePagesField IsNot Nothing Then RemoveHandler optionsTabPanePagesField.CollectionChanged, AddressOf OptionsTabPanePages_CollectionChanged
        End Sub
    End Class
End Namespace
