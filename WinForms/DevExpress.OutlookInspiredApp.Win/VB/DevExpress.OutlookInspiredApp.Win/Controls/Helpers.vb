Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq.Expressions
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout

Namespace DevExpress.DevAV

    Friend Class TaskPreviewGridView
        Inherits GridView

        Private rowFontSize As Single = AppearanceObject.DefaultFont.Size

        Public Sub New()
            Appearance.Row.Font = GetSegoeUIFont(4)
            OptionsSelection.EnableAppearanceHideSelection = False
            OptionsView.AutoCalcPreviewLineCount = True
            OptionsView.EnableAppearanceEvenRow = True
            OptionsView.ShowGroupPanel = False
            OptionsView.ShowHorizontalLines = DefaultBoolean.False
            OptionsView.ShowIndicator = False
            OptionsView.ShowPreview = True
            OptionsView.ShowVerticalLines = DefaultBoolean.False
            PreviewIndent = 0
            AddHandler RowCellStyle, Sub(s, e)
                e.Appearance.Font = GetFont(e.Appearance.Font.FontFamily.Name, rowFontSize, e.Appearance.Font.Style)
                If e.RowHandle = FocusedRowHandle AndAlso GridControl.Focused Then e.Appearance.BackColor = PaintAppearance.FocusedRow.BackColor
            End Sub
            AddHandler CustomDrawRowPreview, Sub(s, e)
                If e.RowHandle = FocusedRowHandle AndAlso GridControl.Focused Then
                    e.Appearance.BackColor = PaintAppearance.FocusedRow.BackColor
                    e.Appearance.ForeColor = PaintAppearance.FocusedRow.ForeColor
                End If
            End Sub
        End Sub

        Public Sub SetViewFontSize(ByVal rowFontSize As Single, ByVal previewFontSize As Single)
            If previewFontSize > 0 Then Appearance.Preview.Font = GetSegoeUIFont(previewFontSize)
            If rowFontSize > 0 Then
                Me.rowFontSize += rowFontSize
                Appearance.Row.Font = GetSegoeUIFont(4)
            End If
        End Sub

        Protected Overrides ReadOnly Property IsAllowPixelScrollingPreview As Boolean
            Get
                Return True
            End Get
        End Property
    End Class

    Friend Class ZoomLevelManager

        Private zoomControlCore As ZoomTrackBarControl

        Private zoomLevelCore As Integer = 0

        Private Shared zoomValues As Integer() = New Integer() {100, 110, 125, 150, 175, 200, 250, 300, 350, 400, 500}

        Private editItem As BarEditItem

        Private captionItem As BarButtonItem

        Private viewModel As IZoomViewModel

        Public Sub New(ByVal beItem As BarEditItem, ByVal captionItem As BarButtonItem, ByVal viewModel As IZoomViewModel)
            Me.viewModel = viewModel
            If viewModel IsNot Nothing Then AddHandler viewModel.ZoomModuleChanged, AddressOf viewModel_SelectedModuleChanged
            editItem = beItem
            Me.captionItem = captionItem
            If editItem IsNot Nothing Then
                AddHandler editItem.HiddenEditor, AddressOf beiZoom_HiddenEditor
                AddHandler editItem.ShownEditor, AddressOf beiZoom_ShownEditor
            End If
        End Sub

        Private zoomModule As ISupportZoom

        Private Sub viewModel_SelectedModuleChanged(ByVal sender As Object, ByVal e As EventArgs)
            If zoomModule IsNot Nothing Then RemoveHandler zoomModule.ZoomChanged, AddressOf zoomModule_ZoomChanged
            UpdateZoomLevelFromModule()
            zoomModule = TryCast(viewModel.ZoomModule, ISupportZoom)
            If zoomModule IsNot Nothing Then AddHandler zoomModule.ZoomChanged, AddressOf zoomModule_ZoomChanged
        End Sub

        Private ReadOnly Property ZoomControl As ZoomTrackBarControl
            Get
                Return zoomControlCore
            End Get
        End Property

        Public Property ZoomLevel As Integer
            Get
                Return zoomLevelCore
            End Get

            Set(ByVal value As Integer)
                If ZoomLevel = value Then Return
                zoomLevelCore = value
                OnZoomLevelChanged(value)
            End Set
        End Property

        Private Sub OnZoomLevelChanged(ByVal value As Integer)
            Dim index As Integer = Array.IndexOf(zoomValues, value)
            If index = -1 Then
                value = value \ 10
            Else
                value = 10 + index
            End If

            editItem.EditValue = value
            captionItem.Caption = String.Format(" {0}%", ZoomLevel)
            UpdateModuleZoomLevel()
        End Sub

        Private Sub UpdateModuleZoomLevel()
            Dim supportZoom As ISupportZoom = TryCast(viewModel.ZoomModule, ISupportZoom)
            If supportZoom IsNot Nothing Then supportZoom.ZoomLevel = ZoomLevel
        End Sub

        Private Sub UpdateZoomLevelFromModule()
            Dim supportZoom As ISupportZoom = TryCast(viewModel.ZoomModule, ISupportZoom)
            If supportZoom IsNot Nothing Then ZoomLevel = supportZoom.ZoomLevel
            captionItem.Visibility = If(supportZoom IsNot Nothing, BarItemVisibility.Always, BarItemVisibility.Never)
            editItem.Visibility = captionItem.Visibility
        End Sub

        Private Sub zoomModule_ZoomChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateZoomLevelFromModule()
        End Sub

        Private Sub beiZoom_ShownEditor(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            zoomControlCore = TryCast(editItem.Manager.ActiveEditor, ZoomTrackBarControl)
            If ZoomControl IsNot Nothing Then
                AddHandler ZoomControl.ValueChanged, AddressOf OnZoomValueChanged
                OnZoomValueChanged(ZoomControl, EventArgs.Empty)
            End If
        End Sub

        Private Sub beiZoom_HiddenEditor(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            RemoveHandler ZoomControl.ValueChanged, AddressOf OnZoomValueChanged
            zoomControlCore = Nothing
        End Sub

        Private Sub OnZoomValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim val As Integer = ZoomControl.Value * 10
            If ZoomControl.Value > 10 Then val = zoomValues(ZoomControl.Value - 10)
            ZoomLevel = val
        End Sub
    End Class

    Friend Module GalleryItemAppearances

        Public Sub Apply(ByVal galleryItem As RibbonGalleryBarItem)
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Normal.Font = AppearanceObject.DefaultFont
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = HorzAlignment.Near
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Hovered.Font = AppearanceObject.DefaultFont
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = HorzAlignment.Near
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Pressed.Font = AppearanceObject.DefaultFont
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = HorzAlignment.Near
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Disabled.Font = AppearanceObject.DefaultFont
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Disabled.Options.UseFont = True
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Disabled.TextOptions.HAlignment = HorzAlignment.Near
            galleryItem.Gallery.Appearance.ItemCaptionAppearance.Disabled.Options.UseTextOptions = True
        End Sub
    End Module

    Friend Module FiltersTreeListAppearances

        Public Sub Apply(ByVal treeList As XtraTreeList.TreeList)
            treeList.BackColor = System.Drawing.Color.Transparent
            treeList.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
            treeList.Appearance.Empty.Options.UseBackColor = True
            treeList.Appearance.Row.BackColor = System.Drawing.Color.Transparent
            treeList.Appearance.Row.Options.UseBackColor = True
            AddHandler treeList.LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            Dim font = GetSegoeUIFont(System.Drawing.FontStyle.Bold)
            treeList.Appearance.FocusedRow.Font = font
            treeList.Appearance.FocusedRow.Options.UseFont = True
            treeList.Appearance.HideSelectionRow.Font = font
            treeList.Appearance.HideSelectionRow.Options.UseFont = True
            treeList.Appearance.SelectedRow.Font = font
            treeList.Appearance.SelectedRow.Options.UseFont = True
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim lf = CType(sender, LookAndFeel.UserLookAndFeel)
            If lf IsNot Nothing Then
                Dim treeList = TryCast(lf.OwnerControl, XtraTreeList.TreeList)
                If treeList IsNot Nothing Then treeList.Appearance.Row.ForeColor = GetTransparentRowForeColor(lf)
            End If
        End Sub
    End Module

    Friend Module GroupFiltersListViewAppearances

        Public Sub Apply(ByVal winExplorerView As Views.WinExplorer.WinExplorerView)
            winExplorerView.Appearance.ItemDescriptionNormal.ForeColor = DisabledTextColor
            winExplorerView.Appearance.ItemDescriptionNormal.Options.UseForeColor = True
            winExplorerView.Appearance.ItemDescriptionHovered.ForeColor = DisabledTextColor
            winExplorerView.Appearance.ItemDescriptionHovered.Options.UseForeColor = True
            winExplorerView.Appearance.ItemDescriptionPressed.ForeColor = DisabledTextColor
            winExplorerView.Appearance.ItemDescriptionPressed.Options.UseForeColor = True
            winExplorerView.Appearance.ItemDescriptionSelected.ForeColor = DisabledTextColor
            winExplorerView.Appearance.ItemDescriptionSelected.Options.UseForeColor = True
        End Sub
    End Module

    Friend Module AppHelper

        Public Function Open(ByVal fileName As String) As Boolean
            Try
                Return Data.Utils.SafeProcess.TryOpen(fileName)
            Catch __unusedWin32Exception1__ As Win32Exception
                Return False
            End Try
        End Function

        Public ReadOnly Property ApplicationID As String
            Get
                Return String.Format("Components_{0}_Demo_Center_{0}", AssemblyInfo.VersionShort.Replace(".", "_"))
            End Get
        End Property

        Public ReadOnly Property AppIcon As SvgImage
            Get
                Return ResourceImageHelperCore.CreateSvgImageFromResources("DevExpress.DevAV.Resources.AppIcon.svg", GetType(MainForm).Assembly)
            End Get
        End Property

        Private img As Image

        Public ReadOnly Property AppImage As Image
            Get
                If img Is Nothing Then img = AppIcon.Render(Nothing)
                Return img
            End Get
        End Property

        Private wRef As WeakReference

        Public Property MainForm As MainForm
            Get
                Return If(wRef IsNot Nothing, TryCast(wRef.Target, MainForm), Nothing)
            End Get

            Set(ByVal value As MainForm)
                wRef = New WeakReference(value)
            End Set
        End Property

        Public Function GetDefaultSize() As Single
            Return 8.25F
        End Function
    End Module

    Friend Module GridHelper

        Public Sub SetFindControlImages(ByVal grid As GridControl)
            Dim fControl As FindControl = Nothing
            For Each ctrl As Control In grid.Controls
                fControl = TryCast(ctrl, FindControl)
                If fControl IsNot Nothing Then Exit For
            Next

            If fControl IsNot Nothing Then
                fControl.SuspendLayout()
                fControl.FindEdit.Properties.BeginUpdate()
                Dim btn As EditorButton = fControl.FindEdit.Properties.Buttons(0)
                btn.Kind = XtraEditors.Controls.ButtonPredefines.Search
                btn = New ClearButton()
                btn.Visible = False
                fControl.FindEdit.Properties.Buttons.Add(btn)
                AddHandler fControl.FindEdit.ButtonClick, Sub(s, e)
                    If TypeOf e.Button Is ClearButton Then
                        Dim edit As ButtonEdit = TryCast(s, ButtonEdit)
                        edit.Text = String.Empty
                    End If
                End Sub
                fControl.FindEdit.Properties.EndUpdate()
                AddHandler fControl.FindEdit.EditValueChanged, Sub(s, e)
                    fControl.SuspendLayout()
                    Dim edit As MRUEdit = TryCast(s, MRUEdit)
                    edit.Properties.BeginUpdate()
                    Try
                        edit.Properties.Buttons(0).Visible = String.IsNullOrEmpty(edit.Text)
                        edit.Properties.Buttons(1).Visible = Not String.IsNullOrEmpty(edit.Text)
                    Finally
                        edit.Properties.EndUpdate()
                    End Try

                    fControl.ResumeLayout(False)
                End Sub
                fControl.ResumeLayout(False)
            End If
        End Sub

        Friend Sub HideCustomization(ByVal control As Control)
            If control Is Nothing Then Return
            For Each child As Control In control.Controls
                Dim grid As GridControl = TryCast(child, GridControl)
                If grid IsNot Nothing Then
                    Dim gridView As GridView = TryCast(grid.MainView, GridView)
                    If gridView IsNot Nothing Then gridView.HideCustomization()
                    Continue For
                Else
                    HideCustomization(child)
                End If
            Next
        End Sub

        Friend Function GetTransparentRowForeColor(ByVal lf As LookAndFeel.UserLookAndFeel) As Color
            Return If(Equals(lf.ActiveSkinName, "VS2010"), GetControlColor(lf), TextColor)
        End Function
    End Module

    Friend Module ChartHelper

        Friend Function GetBackColor(ByVal chartControl As XtraCharts.ChartControl) As Color
            Return CType(chartControl, XtraCharts.Native.IChartContainer).Chart.ActualBackColor
        End Function
    End Module

    Friend Class LabelTabController

        Private labels As LabelControl()

        Public Sub New(ByVal eValue As Object, ParamArray list As LabelControl())
            labels = list
            EditValue = eValue
            For Each lb As LabelControl In list
                AddHandler lb.Click, Sub(s, e) EditValue = CType(s, LabelControl).Tag
            Next
        End Sub

        Private editValueCore As Object

        Public Property EditValue As Object
            Get
                Return editValueCore
            End Get

            Set(ByVal value As Object)
                If Equals(editValueCore, value) Then Return
                editValueCore = value
                OnEditValueChanged()
            End Set
        End Property

        Private Sub OnEditValueChanged()
            UpdateAppearance()
            RaiseEditValueChanged()
        End Sub

        Private Sub UpdateAppearance()
            For Each lc As LabelControl In labels
                Dim isSelected As Boolean = EditValue.Equals(lc.Tag)
                lc.Font = GetFont(lc.Font.FontFamily.Name, 10.25F, If(isSelected, FontStyle.Bold, FontStyle.Regular))
                lc.Appearance.ForeColor = If(isSelected, QuestionColor, Color.Empty)
            Next
        End Sub

        Public Event EditValueChanged As EventHandler

        Private Sub RaiseEditValueChanged()
            Dim handler As EventHandler = EditValueChangedEvent
            If handler IsNot Nothing Then handler(EditValue, EventArgs.Empty)
        End Sub
    End Class

    Friend Module FontResources

        Private cache As IDictionary(Of String, Font)

        Sub New()
            cache = New Dictionary(Of String, Font)()
        End Sub

        Public Function GetSegoeUIFont(ByVal fontStyle As FontStyle) As Font
            Dim defaultSize As Single = AppearanceObject.DefaultFont.Size
            Return GetFont("Segoe UI", defaultSize, fontStyle)
        End Function

        Public Function GetSegoeUIFont(ByVal Optional sizeGrow As Single = 0) As Font
            Dim defaultSize As Single = AppearanceObject.DefaultFont.Size
            Return GetFont("Segoe UI", defaultSize + sizeGrow)
        End Function

        Public Function GetSegoeUILightFont(ByVal Optional sizeGrow As Single = 0) As Font
            Dim defaultSize As Single = AppearanceObject.DefaultFont.Size
            Return GetFont("Segoe UI Light", defaultSize + sizeGrow)
        End Function

        Public Function GetFont(ByVal familyName As String, ByVal size As Single, ByVal Optional style As FontStyle = FontStyle.Regular) As Font
            Dim key As String = familyName & "#" & size.ToString()
            If style <> FontStyle.Regular Then key +=("#" & style.ToString())
            Dim result As Font = Nothing
            If Not cache.TryGetValue(key, result) Then
                Try
                    Dim family = FindFontFamily(familyName)
                    result = New Font(If(family, FontFamily.GenericSansSerif), size, style)
                Catch __unusedArgumentException1__ As ArgumentException
                    result = AppearanceObject.DefaultFont
                End Try

                cache.Add(key, result)
            End If

            Return result
        End Function

        Private Function FindFontFamily(ByVal familyName As String) As FontFamily
            Return Array.Find(FontFamily.Families, Function(f) Equals(f.Name, familyName))
        End Function
    End Module

    Friend Module ColorHelper

        Public Function GetControlColor(ByVal provider As LookAndFeel.UserLookAndFeel) As Color
            Return LookAndFeel.LookAndFeelHelper.GetSystemColor(provider, SystemColors.Control)
        End Function

        Public ReadOnly Property TextColor As Color
            Get
                Return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.ControlText)
            End Get
        End Property

        Public ReadOnly Property WindowColor As Color
            Get
                Return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.Window)
            End Get
        End Property

        Public ReadOnly Property WindowTextColor As Color
            Get
                Return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.WindowText)
            End Get
        End Property

        Public ReadOnly Property DisabledTextColor As Color
            Get
                Return CommonSkins.GetSkin(LookAndFeel.UserLookAndFeel.Default).Colors.GetColor(CommonColors.DisabledText)
            End Get
        End Property

        Public ReadOnly Property CriticalColor As Color
            Get
                Return CommonColors.GetCriticalColor(LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property

        Public ReadOnly Property WarningColor As Color
            Get
                Return CommonColors.GetWarningColor(LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property

        Public ReadOnly Property QuestionColor As Color
            Get
                Return CommonColors.GetQuestionColor(LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property

        Public ReadOnly Property InformationColor As Color
            Get
                Return CommonColors.GetInformationColor(LookAndFeel.UserLookAndFeel.Default)
            End Get
        End Property
    End Module

    Friend Module EditorHelpers

        Public Function CreatePaymentStatusImageComboBox(ByVal provider As ISkinProvider, ByVal Optional edit As RepositoryItemImageComboBox = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing) As RepositoryItemImageComboBox
            Dim ret As RepositoryItemImageComboBox = CreateEnumImageComboBox(Of PaymentStatus)(edit, collection)
            ret.SmallImages = CreatePaymentStatusImageCollection(provider)
            If edit Is Nothing Then ret.GlyphAlignment = HorzAlignment.Center
            Return ret
        End Function

        Public Function CreateShipmentStatusImageComboBox(ByVal provider As ISkinProvider, ByVal Optional edit As RepositoryItemImageComboBox = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing) As RepositoryItemImageComboBox
            Dim ret As RepositoryItemImageComboBox = CreateEnumImageComboBox(Of ShipmentStatus)(edit, collection)
            ret.SmallImages = CreateShipmentStatusImageCollection(provider)
            If edit Is Nothing Then ret.GlyphAlignment = HorzAlignment.Center
            Return ret
        End Function

        Public Function CreatePersonPrefixImageComboBox(ByVal Optional edit As RepositoryItemImageComboBox = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing) As RepositoryItemImageComboBox
            Dim ret As RepositoryItemImageComboBox = CreateEnumImageComboBox(Of PersonPrefix)(edit, collection)
            ret.SmallImages = CreatePersonPrefixImageCollection()
            If edit Is Nothing Then ret.GlyphAlignment = HorzAlignment.Center
            Return ret
        End Function

        Public Function CreateTaskPriorityImageComboBox(ByVal Optional edit As RepositoryItemImageComboBox = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing) As RepositoryItemImageComboBox
            Dim ret As RepositoryItemImageComboBox = CreateEnumImageComboBox(Of EmployeeTaskPriority)(edit, collection)
            ret.SmallImages = CreateTaskPrioritySvgImageCollection()
            If edit Is Nothing Then ret.GlyphAlignment = HorzAlignment.Center
            Return ret
        End Function

        Private Function CreatePersonPrefixImageCollection() As SvgImageCollection
            Dim svgImageCollection As SvgImageCollection = New SvgImageCollection()
            svgImageCollection.ImageSize = New Size(16, 16)
            svgImageCollection.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.PersonPrefix." & "Doctor.svg"), GetType(EditorHelpers).Assembly))
            svgImageCollection.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.PersonPrefix." & "Mr.svg"), GetType(EditorHelpers).Assembly))
            svgImageCollection.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.PersonPrefix." & "Ms.svg"), GetType(EditorHelpers).Assembly))
            svgImageCollection.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.PersonPrefix." & "Miss.svg"), GetType(EditorHelpers).Assembly))
            svgImageCollection.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.PersonPrefix." & "Mrs.svg"), GetType(EditorHelpers).Assembly))
            Return svgImageCollection
        End Function

        Private Function CreateTaskPrioritySvgImageCollection() As SvgImageCollection
            Dim ret As SvgImageCollection = New SvgImageCollection()
            ret.ImageSize = New Size(16, 16)
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.signal-bar-1-dx_desktop-regular-blue-16.svg"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.signal-bar-2-dx_desktop-regular-blue-16.svg"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.signal-bar-3-dx_desktop-regular-blue-16.svg"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.signal-bar-dx_desktop-regular-blue-16.svg"), GetType(MainForm).Assembly))
            Return ret
        End Function

        Private Function CreateTaskPriorityImageCollection() As ImageCollection
            Dim ret As ImageCollection = New ImageCollection()
            ret.ImageSize = New Size(16, 16)
            ret.AddImage(Properties.Resources.LowPriority)
            ret.AddImage(Properties.Resources.NormalPriority)
            ret.AddImage(Properties.Resources.MediumPriority)
            ret.AddImage(Properties.Resources.HighPriority)
            Return ret
        End Function

        Friend Function CreatePaymentStatusImageCollection(ByVal provider As ISkinProvider) As Object
            Dim ret As SvgImageCollection = New SvgImageCollection()
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.Orders.Payment" & "Unpaid.svg"), GetType(EditorHelpers).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.Orders.Payment" & "Paid.svg"), GetType(EditorHelpers).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.Orders.Payment" & "Refund.svg"), GetType(EditorHelpers).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.Orders.Payment" & "Other.svg"), GetType(EditorHelpers).Assembly))
            Return ret
        End Function

        Friend Function CreateShipmentStatusImageCollection(ByVal provider As ISkinProvider) As Object
            Dim ret As SvgImageCollection = New SvgImageCollection()
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.Orders.Shipment" & "Awaiting.svg"), GetType(EditorHelpers).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.Orders.Shipment" & "Transit.svg"), GetType(EditorHelpers).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("DevExpress.DevAV.Resources.Orders.Shipment" & "Received.svg"), GetType(EditorHelpers).Assembly))
            Return ret
        End Function

        Public Function CreateManeuverImageComboBox(ByVal Optional edit As RepositoryItemImageComboBox = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing) As RepositoryItemImageComboBox
            Dim ret As RepositoryItemImageComboBox = CreateEnumImageComboBox(Of XtraMap.AzureRouteGuidanceManeuver)(edit, collection)
            For Each item As ImageComboBoxItem In ret.Items
                Select Case CType(item.Value, XtraMap.AzureRouteGuidanceManeuver)
                    Case XtraMap.AzureRouteGuidanceManeuver.Depart
                        item.ImageIndex = 0
                    Case XtraMap.AzureRouteGuidanceManeuver.TurnLeft
                        item.ImageIndex = 1
                    Case XtraMap.AzureRouteGuidanceManeuver.TurnRight
                        item.ImageIndex = 2
                    Case XtraMap.AzureRouteGuidanceManeuver.Arrive, XtraMap.AzureRouteGuidanceManeuver.ArriveLeft, XtraMap.AzureRouteGuidanceManeuver.ArriveRight
                        item.ImageIndex = 3
                    Case XtraMap.AzureRouteGuidanceManeuver.MakeUTurn
                        item.ImageIndex = 4
                    Case XtraMap.AzureRouteGuidanceManeuver.BearLeft
                        item.ImageIndex = 5
                    Case XtraMap.AzureRouteGuidanceManeuver.BearRight
                        item.ImageIndex = 6
                End Select

                item.Description = String.Empty
            Next

            ret.SmallImages = CreateAzureManeuverTypeSvgImageCollection()
            ret.GlyphAlignment = HorzAlignment.Center
            Return ret
        End Function

        Private Function CreateAzureManeuverTypeSvgImageCollection() As SvgImageCollection
            Dim ret As SvgImageCollection = New SvgImageCollection()
            ret.ImageSize = New Size(32, 32)
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_A_32"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_arrow_left_32"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_arrow_right_32"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_B_32"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_arrow_uturn_32"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_arrow_bear_left_32"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_arrow_bear_right_32"), GetType(MainForm).Assembly))
            ret.Add(SvgImage.FromResources(GetFluentIconName("icon_arrow_forward_32"), GetType(MainForm).Assembly))
            Return ret
        End Function

        Private Function CreateAzureManeuverTypeImageCollection() As ImageCollection
            Dim ret As ImageCollection = New ImageCollection()
            ret.ImageSize = New Size(32, 32)
            ret.AddImage(Properties.Resources.icon_A_32)
            ret.AddImage(Properties.Resources.icon_arrow_left_32)
            ret.AddImage(Properties.Resources.icon_arrow_right_32)
            ret.AddImage(Properties.Resources.icon_B_32)
            ret.AddImage(Properties.Resources.icon_arrow_uturn_32)
            ret.AddImage(Properties.Resources.icon_arrow_bear_left_32)
            ret.AddImage(Properties.Resources.icon_arrow_bear_right_32)
            ret.AddImage(Properties.Resources.icon_arrow_forward_32)
            Return ret
        End Function

        Public Function CreateEnumImageComboBox(Of TEnum)(ByVal container As XtraEditors.Container.EditorContainer, ByVal Optional displayTextConverter As Converter(Of TEnum, String) = Nothing) As RepositoryItemImageComboBox
            Return CreatEdit(Of RepositoryItemImageComboBox)(Nothing, If(container IsNot Nothing, container.RepositoryItems, Nothing), Sub(e) e.Items.AddEnum(displayTextConverter))
        End Function

        Public Function CreateEnumImageComboBox(Of TEnum)(ByVal Optional edit As RepositoryItemImageComboBox = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing, ByVal Optional displayTextConverter As Converter(Of TEnum, String) = Nothing) As RepositoryItemImageComboBox
            Return CreatEdit(edit, collection, Sub(e) e.Items.AddEnum(displayTextConverter))
        End Function

        Public Function CreatDateEdit(ByVal Optional edit As RepositoryItemDateEdit = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing) As RepositoryItemDateEdit
            Return CreatEdit(edit, collection)
        End Function

        Public Function CreatEdit(Of TEdit As {RepositoryItem, New})(ByVal Optional edit As TEdit = Nothing, ByVal Optional collection As RepositoryItemCollection = Nothing, ByVal Optional initialize As Action(Of TEdit) = Nothing) As TEdit
            edit = If(edit, New TEdit())
            If collection IsNot Nothing Then collection.Add(edit)
            If initialize IsNot Nothing Then initialize(edit)
            Return edit
        End Function

        Public Sub ApplyBindingSettings(Of TEntity)(ByVal edit As BaseEdit, ByVal layoutControl As LayoutControl)
            Dim memberInfo = edit.DataBindings("EditValue").BindingMemberInfo
            If IsRequired(Of TEntity)(memberInfo.BindingMember) Then
                If layoutControl IsNot Nothing Then
                    Dim itemForEdit = layoutControl.GetItemByControl(edit)
                    itemForEdit.AllowHtmlStringInCaption = True
                    itemForEdit.Text = itemForEdit.Text & " <color=red>*</color>"
                End If
            End If

            If TypeOf edit Is TextEdit Then
                If IsPhone(Of TEntity)(memberInfo.BindingMember) Then
                    CType(edit, TextEdit).Properties.Mask.MaskType = XtraEditors.Mask.MaskType.Simple
                    CType(edit, TextEdit).Properties.Mask.EditMask = "(999) 000-0000"
                    CType(edit, TextEdit).Properties.Mask.UseMaskAsDisplayFormat = True
                End If

                If IsZipcode(Of TEntity)(memberInfo.BindingMember) Then
                    CType(edit, TextEdit).Properties.Mask.MaskType = XtraEditors.Mask.MaskType.Simple
                    CType(edit, TextEdit).Properties.Mask.EditMask = "00000"
                    CType(edit, TextEdit).Properties.Mask.UseMaskAsDisplayFormat = True
                End If
            End If
        End Sub
    End Module

    Friend Class FilterColumnCollectionBuilder(Of TEntity)

        Private filterColumns As FilterColumnCollection

        Public Sub New()
            filterColumns = New FilterColumnCollection()
        End Sub

        Public Sub New(ByVal filterColumns As FilterColumnCollection)
            Me.filterColumns = filterColumns
        End Sub

        Public Function Build() As FilterColumnCollection
            Return filterColumns
        End Function

        Public Function AddColumn(Of T)(ByVal expression As Expression(Of Func(Of TEntity, T)), ByVal Optional repositoryItem As RepositoryItem = Nothing, ByVal Optional clauseClass As FilterColumnClauseClass = FilterColumnClauseClass.String, ByVal Optional caption As String = Nothing) As FilterColumnCollectionBuilder(Of TEntity)
            If repositoryItem Is Nothing Then
                If GetType(T) Is GetType(Boolean) OrElse GetType(T) Is GetType(Boolean?) Then
                    repositoryItem = EditorHelpers.CreatEdit(Of RepositoryItemCheckEdit)()
                    clauseClass = FilterColumnClauseClass.Generic
                End If

                If GetType(T) Is GetType(Double) OrElse GetType(T) Is GetType(Double?) OrElse GetType(T) Is GetType(Decimal) OrElse GetType(T) Is GetType(Decimal?) Then
                    repositoryItem = EditorHelpers.CreatEdit(Of RepositoryItemSpinEdit)()
                    clauseClass = FilterColumnClauseClass.Generic
                End If

                If GetType(T) Is GetType(Integer) OrElse GetType(T) Is GetType(Integer?) Then
                    Dim spinEdit = EditorHelpers.CreatEdit(Of RepositoryItemSpinEdit)()
                    spinEdit.IsFloatValue = False
                    repositoryItem = spinEdit
                    clauseClass = FilterColumnClauseClass.Generic
                End If
            End If

            filterColumns.Add(CreateColumn(expression, caption, Nothing, repositoryItem, clauseClass))
            Return Me
        End Function

        Public Function AddLookupColumn(Of T)(ByVal expression As Expression(Of Func(Of TEntity, T))) As FilterColumnCollectionBuilder(Of TEntity)
            Return AddColumn(expression, EditorHelpers.CreateEnumImageComboBox(Of T)(), FilterColumnClauseClass.Lookup)
        End Function

        Public Function AddDateTimeColumn(Of T)(ByVal expression As Expression(Of Func(Of TEntity, T))) As FilterColumnCollectionBuilder(Of TEntity)
            Return AddColumn(expression, EditorHelpers.CreatDateEdit(), FilterColumnClauseClass.DateTime)
        End Function

        Private Function CreateColumn(Of T)(ByVal expression As Expression(Of Func(Of TEntity, T)), ByVal caption As String, ByVal fieldName As String, ByVal repositoryItem As RepositoryItem, ByVal clauseClass As FilterColumnClauseClass) As UnboundFilterColumn
            Dim member = TryCast(expression.Body, MemberExpression).Member
            If String.IsNullOrEmpty(fieldName) Then fieldName = GetFieldName(expression)
            If String.IsNullOrEmpty(caption) Then caption = GetDisplayName(member)
            Return CreateColumn(Of T)(caption, fieldName, repositoryItem, clauseClass)
        End Function

        Private Function CreateColumn(Of T)(ByVal caption As String, ByVal fieldName As String, ByVal repositoryItem As RepositoryItem, ByVal clauseClass As FilterColumnClauseClass) As UnboundFilterColumn
            Return New UnboundFilterColumn(caption, fieldName, GetType(T), repositoryItem, clauseClass)
        End Function

        Private Function GetFieldName(Of T)(ByVal expression As Expression(Of Func(Of TEntity, T))) As String
            Dim sb = New Text.StringBuilder()
            Dim [me] As MemberExpression = TryCast(expression.Body, MemberExpression)
            While [me] IsNot Nothing
                If sb.Length > 0 Then sb.Insert(0, ".")
                sb.Insert(0, [me].Member.Name)
                [me] = TryCast([me].Expression, MemberExpression)
            End While

            Return sb.ToString()
        End Function

        Private Function GetDisplayName(ByVal member As Reflection.MemberInfo) As String
            Dim displayName As String = member.Name
            If CheckDisplayNameAttribute(Of System.ComponentModel.DataAnnotations.DisplayAttribute)(member, Function(a) a.GetName(), displayName) Then Return displayName
            If CheckDisplayNameAttribute(Of System.ComponentModel.DisplayNameAttribute)(member, Function(a) a.DisplayName, displayName) Then Return displayName
            Return displayName
        End Function

        Private Function CheckDisplayNameAttribute(Of TAttribute As Attribute)(ByVal member As Reflection.MemberInfo, ByVal accessor As Func(Of TAttribute, String), ByRef displayName As String) As Boolean
            Dim displayAttributes = member.GetCustomAttributes(GetType(TAttribute), True)
            If displayAttributes.Length > 0 Then
                displayName = accessor(CType(displayAttributes(0), TAttribute))
                Return True
            End If

            Return False
        End Function
    End Class

    Friend Module FilterControlWithoutLike

        Public Sub Apply(ByVal filterControl As FilterControl)
            filterControl.ShowGroupCommandsIcon = True
            AddHandler filterControl.PopupMenuShowing, AddressOf filterControl_PopupMenuShowing
        End Sub

        Private Sub filterControl_PopupMenuShowing(ByVal sender As Object, ByVal e As XtraEditors.Filtering.PopupMenuShowingEventArgs)
            e.Menu.Remove(ClauseType.Like)
            e.Menu.Remove(ClauseType.NotLike)
        End Sub
    End Module

    Friend Class DemoStartUp
        Implements IObserver(Of String)

        Private Sub OnCompleted() Implements IObserver(Of String).OnCompleted
            XtraSplashScreen.SplashScreenManager.CloseForm(False, 1500, AppHelper.MainForm)
        End Sub

        Private Sub OnNext(ByVal status As String) Implements IObserver(Of String).OnNext
            If XtraSplashScreen.SplashScreenManager.Default Is Nothing Then
                XtraSplashScreen.SplashScreenManager.ShowSkinSplashScreen(Properties.Resources.DevExpress_Logo, title:="When Only the Best Will Do", subtitle:="DevExpress WinForms Controls", loading:=status)
            Else
                XtraSplashScreen.SplashScreenManager.Default.SendCommand(XtraSplashScreen.SkinSplashScreenCommand.UpdateLoadingText, status)
            End If
        End Sub

        Private Sub OnError(ByVal [error] As Exception) Implements IObserver(Of String).OnError
            Throw [error]
        End Sub
    End Class

    Friend Class DataGenerationProgress
        Implements IObserver(Of String)

        Private Sub OnNext(ByVal status As String) Implements IObserver(Of String).OnNext
            XtraSplashScreen.SplashScreenManager.SetDefaultSplashScreenStatus(False, status)
        End Sub

        Private Sub OnCompleted() Implements IObserver(Of String).OnCompleted
        End Sub

        Private Sub OnError(ByVal [error] As Exception) Implements IObserver(Of String).OnError
            Throw [error]
        End Sub
    End Class

    Public Class EntityEventArgs(Of TID)
        Inherits EventArgs

        Private entityKeyCore As TID

        Public Sub New(ByVal entityKey As TID)
            entityKeyCore = entityKey
        End Sub

        Public ReadOnly Property Key As TID
            Get
                Return entityKeyCore
            End Get
        End Property
    End Class

    Public Class EntitiesCountEventArgs
        Inherits EventArgs

        Private _Count As Integer

        Public Sub New(ByVal count As Integer)
            Me.Count = count
        End Sub

        Public Property Count As Integer
            Get
                Return _Count
            End Get

            Private Set(ByVal value As Integer)
                _Count = value
            End Set
        End Property
    End Class

    Public Class GroupEventArgs(Of TKey)
        Inherits EventArgs

        Private keysCore As IEnumerable(Of TKey)

        Public Sub New(ByVal keys As IEnumerable(Of TKey))
            keysCore = keys
        End Sub

        Public ReadOnly Property Entities As IEnumerable(Of TKey)
            Get
                Return keysCore
            End Get
        End Property
    End Class

    Public Module SVGHelper

        Public Function CreateImageFromSvg(ByVal skinProvider As ISkinProvider, ByVal rootPath As String, ByVal imageName As String) As Image
            Dim assembly = GetType(MainForm).Assembly
            Dim svgBitmap As SvgBitmap
            Dim stream = assembly.GetManifestResourceStream(rootPath & imageName)
            If stream Is Nothing Then stream = assembly.GetManifestResourceStream(imageName)
            If stream Is Nothing Then Return Nothing
            Using stream
                svgBitmap = SvgBitmap.FromStream(stream)
            End Using

            If svgBitmap Is Nothing Then Return Nothing
            Dim pallete = SvgPaletteHelper.GetSvgPalette(skinProvider, Utils.Drawing.ObjectState.Normal)
            Return svgBitmap.Render(pallete, 1)
        End Function

        Public Function CreateImageFromSvg(ByVal skinProvider As ISkinProvider, ByVal rootPath As String, ByVal imageName As String, ByVal imageSize As Size) As Image
            Dim assembly = GetType(MainForm).Assembly
            Dim svgBitmap As SvgBitmap
            Dim stream = assembly.GetManifestResourceStream(rootPath & imageName)
            If stream Is Nothing Then stream = assembly.GetManifestResourceStream(imageName)
            If stream Is Nothing Then Return Nothing
            Using stream
                svgBitmap = SvgBitmap.FromStream(stream)
            End Using

            If svgBitmap Is Nothing Then Return Nothing
            Dim pallete = SvgPaletteHelper.GetSvgPalette(skinProvider, Utils.Drawing.ObjectState.Normal)
            Return svgBitmap.Render(imageSize, pallete)
        End Function

        Public Function CreateTaskPriorityImages(ByVal skinProvider As ISkinProvider, ByVal rootPath As String) As Dictionary(Of EmployeeTaskPriority, SvgImage)
            Dim result = New Dictionary(Of EmployeeTaskPriority, SvgImage)()
            Dim asm = GetType(MainForm).Assembly
            result.Add(EmployeeTaskPriority.Low, SvgImage.FromResources(GetFluentIconName(String.Concat(rootPath, "PriorityLow.svg")), asm))
            result.Add(EmployeeTaskPriority.Normal, SvgImage.FromResources(GetFluentIconName(String.Concat(rootPath, "PriorityNormal.svg")), asm))
            result.Add(EmployeeTaskPriority.High, SvgImage.FromResources(GetFluentIconName(String.Concat(rootPath, "PriorityHigh.svg")), asm))
            result.Add(EmployeeTaskPriority.Urgent, SvgImage.FromResources(GetFluentIconName(String.Concat(rootPath, "PriorityUrgent.svg")), asm))
            Return result
        End Function
    End Module
End Namespace
