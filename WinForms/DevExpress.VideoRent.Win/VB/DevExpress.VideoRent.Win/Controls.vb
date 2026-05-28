Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors
Imports DevExpress.XtraCharts.Localization

Namespace DevExpress.VideoRent.Win
    Public Class GridViewImageTextToolTipController
        Implements IDisposable
        Private fieldName As String = Nothing
        Private dataName As String = Nothing
        Private view As GridView
        Private controller As ToolTipController
        Private fhotTrackInfo As GridHitInfo = Nothing
        Private isImage As Boolean = True
        Private pictureMaxLineSize As Integer = 300
        Public Sub New(ByVal view As GridView, ByVal fieldName As String)
            Me.New(view, fieldName, True)
        End Sub
        Public Sub New(ByVal view As GridView, ByVal fieldName As String, ByVal image As Boolean)
            Me.New(view, fieldName, Nothing, image)
        End Sub
        Public Sub New(ByVal view As GridView, ByVal fieldName As String, ByVal dataName As String, ByVal image As Boolean)
            Me.New(view, fieldName, dataName, image, 0)
        End Sub
        Public Sub New(ByVal view As GridView, ByVal fieldName As String, ByVal dataName As String, ByVal image As Boolean, ByVal pictureMaxLineSize As Integer)
            Me.view = view
            Me.fieldName = fieldName
            Me.dataName = dataName
            Me.isImage = image
            AddHandler view.Disposed, AddressOf AnonymousMethod1
            If pictureMaxLineSize > 0 Then
                Me.pictureMaxLineSize = pictureMaxLineSize
            End If
            controller = New ToolTipController()
            controller.ToolTipType = ToolTipType.SuperTip
            controller.AllowHtmlText = Not Object.Equals(dataName, Nothing)
            controller.ReshowDelay = controller.InitialDelay
            If (Not Object.Equals(dataName, Nothing)) OrElse (Not isImage) Then
                controller.AutoPopDelay = 10000
            End If
            If Object.Equals(view.GridControl, Nothing) Then
                Return
            End If
            AddHandler view.GridControl.MouseMove, AddressOf GridControl_MouseMove
            AddHandler view.TopRowChanged, AddressOf view_TopRowChanged
            AddHandler view.ShownEditor, AddressOf AnonymousMethod2
            AddHandler view.GridControl.MouseDown, AddressOf AnonymousMethod3
            AddHandler view.GridControl.MouseLeave, AddressOf AnonymousMethod4
        End Sub

        Private Sub AnonymousMethod1(ByVal sender As Object, ByVal e As System.EventArgs)
            Dispose()
        End Sub

        Private Sub AnonymousMethod2(ByVal sender As Object, ByVal e As System.EventArgs)
            controller.HideHint()
        End Sub

        Private Sub AnonymousMethod3(ByVal sender As Object, ByVal e As MouseEventArgs)
            controller.HideHint()
        End Sub

        Private Sub AnonymousMethod4(ByVal sender As Object, ByVal e As EventArgs)
            controller.HideHint()
        End Sub
        Public Property HotTrackInfo() As GridHitInfo
            Get
                Return fhotTrackInfo
            End Get
            Set(ByVal value As GridHitInfo)
                If (Not value.InRowCell) Then
                    controller.HideHint()
                    fhotTrackInfo = Nothing
                    Return
                End If
                If (Not Object.Equals(fhotTrackInfo, Nothing)) AndAlso Object.Equals(fhotTrackInfo.Column, value.Column) AndAlso Object.Equals(fhotTrackInfo.RowHandle, value.RowHandle) Then
                    Return
                End If
                fhotTrackInfo = value
                ShowToolTip()
            End Set
        End Property
        Private ReadOnly Property IsEditing() As Boolean
            Get
                Return ((Not Object.Equals(view.ActiveEditor, Nothing))) AndAlso Object.Equals(HotTrackInfo.Column, view.FocusedColumn) AndAlso Object.Equals(HotTrackInfo.RowHandle, view.FocusedRowHandle)
            End Get
        End Property
        Private Sub ShowToolTip()
            If (Not HotTrackInfo.InRowCell) OrElse HotTrackInfo.Column.FieldName <> fieldName OrElse IsEditing Then
                controller.HideHint()
                Return
            End If
            Dim info As New ToolTipControlInfo()
            Dim item As New ToolTipItem()
            item.ImageToTextDistance = 0
            If isImage Then
                item.Image = ImageCreator.CreateImage(TryCast(view.GetRowCellValue(HotTrackInfo.RowHandle, HotTrackInfo.Column), Image), pictureMaxLineSize, pictureMaxLineSize)
                If (Not Object.Equals(dataName, Nothing)) Then
                    item.Text = String.Format("{0}", view.GetRowCellValue(HotTrackInfo.RowHandle, view.Columns(dataName)))
                    item.ImageToTextDistance = 10
                End If
            Else
                item.Text = String.Format("{0}", view.GetRowCellValue(HotTrackInfo.RowHandle, HotTrackInfo.Column))
            End If
            info.Object = HotTrackInfo
            info.SuperTip = New SuperToolTip()
            info.SuperTip.Items.Add(item)
            info.ToolTipPosition = Cursor.Position
            controller.ShowHint(info)
        End Sub
        Private Sub GridControl_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            HotTrackInfo = view.CalcHitInfo(e.X, e.Y)
        End Sub
        Private Sub view_TopRowChanged(ByVal sender As Object, ByVal e As EventArgs)
            controller.HideHint()
            HotTrackInfo = view.CalcHitInfo(view.GridControl.PointToClient(Cursor.Position))
        End Sub
#Region "IDisposable Members"
        Public Sub Dispose() Implements IDisposable.Dispose
            Me.Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                Me.controller.Dispose()
            End If
        End Sub
        Protected Overrides Sub Finalize()
            Dispose(False)
        End Sub
#End Region
    End Class
    Public Class ObjectToolTipController
        Implements IDisposable
        Private controller As ToolTipController
        Private parent As Control
        Private feditObject As Object
        Public ReadOnly Property EditObject() As Object
            Get
                Return feditObject
            End Get
        End Property
        Public Sub New(ByVal parent As Control)
            Me.parent = parent
            AddHandler parent.Disposed, AddressOf AnonymousMethod5
            Me.controller = New ToolTipController()
            Me.controller.ToolTipType = ToolTipType.SuperTip
            Me.controller.AllowHtmlText = True
            Me.controller.ReshowDelay = controller.InitialDelay
            Me.controller.AutoPopDelay = 10000
            AddHandler parent.MouseDown, AddressOf AnonymousMethod6
            AddHandler parent.MouseLeave, AddressOf AnonymousMethod7
            If TypeOf parent Is PivotGridControl Then
                AddHandler (CType(parent, PivotGridControl)).LeftTopCellChanged, AddressOf AnonymousMethod8
            End If
        End Sub

        Private Sub AnonymousMethod5(ByVal sender As Object, ByVal e As System.EventArgs)
            Dispose()
        End Sub

        Private Sub AnonymousMethod6(ByVal sender As Object, ByVal e As MouseEventArgs)
            HideHint(False)
        End Sub

        Private Sub AnonymousMethod7(ByVal sender As Object, ByVal e As System.EventArgs)
            HideHint(True)
        End Sub

        Private Sub AnonymousMethod8(ByVal sender As Object, ByVal e As PivotLeftTopCellChangedEventArgs)
            HideHint(True)
        End Sub
        Public Sub ShowHint(ByVal editObject As Object, ByVal location As Point)
            If Object.Equals(editObject, Me.feditObject) Then
                Return
            End If
            Me.feditObject = editObject
            Dim info As New ToolTipControlInfo()
            Dim item As New ToolTipItem()
            InitToolTipItem(item)
            item.ImageToTextDistance = 10
            info.Object = DateTime.Now.Ticks
            info.SuperTip = New SuperToolTip()
            info.SuperTip.Items.Add(item)
            info.ToolTipPosition = Me.parent.PointToScreen(location)
            controller.ShowHint(info)
        End Sub
        Protected Overridable Sub InitToolTipItem(ByVal item As ToolTipItem)
        End Sub
        Public Sub HideHint(ByVal clearCurrentObject As Boolean)
            If clearCurrentObject Then
                Me.feditObject = Nothing
            End If
            Me.controller.HideHint()
        End Sub
#Region "IDisposable Members"
        Public Sub Dispose() Implements IDisposable.Dispose
            Me.Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                Me.controller.Dispose()
            End If
        End Sub
        Protected Overrides Sub Finalize()
            Dispose(False)
        End Sub
#End Region
    End Class
    Public Class CustomerDiscountLevelToolTipController
        Inherits ObjectToolTipController
        Public Sub New(ByVal parent As Control)
            MyBase.New(parent)
        End Sub
        Protected Overrides Sub InitToolTipItem(ByVal item As ToolTipItem)
            If Object.Equals(EditObject, Nothing) Then
                Return
            End If
            Dim currentLevel As CustomerDiscountLevel = CType(EditObject, CustomerDiscountLevel)
            item.Text = String.Format(ConstStrings.CustomerDiscountLevelToolTip, EditorHelper.GetStringByCustomerDiscountLevel(currentLevel), ReferenceData.GetDiscount(currentLevel), ReferenceData.CustomerDiscountLevel(CInt(Fix(currentLevel))))
        End Sub
    End Class
    Public Class CustomerToolTipController
        Inherits ObjectToolTipController
        Private Const MaxPhotoWidth As Integer = 120, MaxPhotoHeight As Integer = 120
        Public Sub New(ByVal parent As Control)
            MyBase.New(parent)
        End Sub
        Private ReadOnly Property CurrentCustomer() As Customer
            Get
                Return TryCast(EditObject, Customer)
            End Get
        End Property
        Protected Overrides Sub InitToolTipItem(ByVal item As ToolTipItem)
            If Object.Equals(CurrentCustomer, Nothing) Then
                Return
            End If
            If (Not Object.Equals(CurrentCustomer.PhotoExist, Nothing)) Then
                item.Image = ImageCreator.CreateImage(CurrentCustomer.PhotoExist, MaxPhotoWidth, MaxPhotoHeight)
            End If
            item.Text = CurrentCustomer.GetCustomerInfoHtml()
        End Sub
    End Class
    Public Class MovieToolTipController
        Inherits ObjectToolTipController
        Private MaxPhotoWidth As Integer = 100, MaxPhotoHeight As Integer = 120
        Public Sub New(ByVal parent As Control)
            MyBase.New(parent)
        End Sub
        Private ReadOnly Property CurrentMovie() As Movie
            Get
                Return TryCast(EditObject, Movie)
            End Get
        End Property
        Protected Overrides Sub InitToolTipItem(ByVal item As ToolTipItem)
            If Object.Equals(CurrentMovie, Nothing) Then
                Return
            End If
            If (Not Object.Equals(CurrentMovie.PhotoExist, Nothing)) Then
                item.Image = ImageCreator.CreateImage(CurrentMovie.PhotoExist, MaxPhotoWidth, MaxPhotoHeight)
            End If
            item.Text = CurrentMovie.GetMovieInfoHtml()
        End Sub
    End Class
    Public Delegate Sub ChartAppearanceEventHandler(ByVal sender As Object, ByVal e As ChartAppearanceEventArgs)
    Public Class ChartAppearanceEventArgs
        Inherits EventArgs
        Private palette, appearance As String
        Private color As Integer
        Public Sub New(ByVal palette As String, ByVal appearance As String, ByVal color As Integer)
            Me.palette = palette
            Me.appearance = appearance
            Me.color = color
        End Sub
        Public ReadOnly Property PaletteName() As String
            Get
                Return palette
            End Get
        End Property
        Public ReadOnly Property AppearanceName() As String
            Get
                Return appearance
            End Get
        End Property
        Public ReadOnly Property ColorIndex() As Integer
            Get
                Return color
            End Get
        End Property
    End Class
    Public Class ChartAppearanceManager
        Private chartControl As ChartControl
        Private paletteGallery As GalleryDropDown
        Private styleGalleryBarItem As RibbonGalleryBarItem
        Private paletteButton As BarButtonItem
        Private fviewType As ViewType = ViewType.Bar
        Public Event StyleChanged As ChartAppearanceEventHandler
        Public Sub New(ByVal paletteGallery As GalleryDropDown, ByVal styleGalleryBarItem As RibbonGalleryBarItem, ByVal paletteButton As BarButtonItem)
            Me.paletteGallery = paletteGallery
            Me.styleGalleryBarItem = styleGalleryBarItem
            Me.paletteButton = paletteButton
            chartControl = New ChartControl()
            AddHandler paletteGallery.GalleryItemClick, AddressOf paletteGallery_GalleryItemClick
            AddHandler styleGalleryBarItem.GalleryInitDropDownGallery, AddressOf styleGalleryBarItem_GalleryInitDropDownGallery
            AddHandler styleGalleryBarItem.GalleryPopupClose, AddressOf styleGalleryBarItem_GalleryPopupClose
            AddHandler styleGalleryBarItem.GalleryItemClick, AddressOf styleGalleryBarItem_GalleryItemClick
            InitChartPaletteGallery(Me.paletteGallery)
            AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf Default_StyleChanged

            'InitChartAppearanceGallery(this.styleGalleryBarItem, chart.PaletteName);
        End Sub
        Public Property ViewType() As ViewType
            Get
                Return fviewType
            End Get
            Set(ByVal value As ViewType)
                If ViewType = value Then
                    Return
                End If
                fviewType = value
                InitChartAppearanceGallery(styleGalleryBarItem, chartControl.PaletteName)
            End Set
        End Property
        Private Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            InitChartAppearanceGallery(styleGalleryBarItem, chartControl.PaletteName)
        End Sub
        Private Sub styleGalleryBarItem_GalleryPopupClose(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs)
            Dim items As List(Of GalleryItem) = e.Item.Gallery.GetCheckedItems()
            If items.Count > 0 Then
                e.Item.Gallery.MakeVisible(items(0))
                UpdateStyle()
            End If
        End Sub
        Private Sub styleGalleryBarItem_GalleryInitDropDownGallery(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs)
            e.PopupGallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            e.PopupGallery.ColumnCount = 7
            e.PopupGallery.DrawImageBackground = True
            e.PopupGallery.ShowGroupCaption = True
            e.PopupGallery.SynchWithInRibbonGallery = True
            e.PopupGallery.AutoSize = GallerySizeMode.Vertical
        End Sub
        Private Sub paletteGallery_GalleryItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
            chartControl.PaletteName = e.Item.Caption
            UpdateStyle(True)
        End Sub
        Private Sub styleGalleryBarItem_GalleryItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
            UpdateStyle()
        End Sub
        Private Sub UpdateStyle()
            UpdateStyle(False)
        End Sub
        Private Shared Function GetPaletteColor(ByVal palette As Palette, ByVal value As Integer) As Integer
            If value < 0 Then
                Return 0
            End If
            If value >= palette.Count Then
                Return palette.Count - 1
            End If
            Return value
        End Function
        Private Sub UpdateStyle(ByVal updateAppearance As Boolean)
            Dim currentPalette As String = chartControl.PaletteName
            chartControl.AppearanceName = CurrentAppearanceName
            chartControl.PaletteBaseColorNumber = GetPaletteColor(chartControl.PaletteRepository(chartControl.PaletteName), CurrentPaletteColor)
            If currentPalette <> chartControl.PaletteName OrElse updateAppearance Then
                InitChartAppearanceGallery(Me.styleGalleryBarItem, chartControl.PaletteName)
            End If
            UpdateCurrentPalette()
            RaiseCtyleChanged()
        End Sub
        Private Sub RaiseCtyleChanged()
            If (Not Object.Equals(StyleChangedEvent, Nothing)) Then
                RaiseEvent StyleChanged(Me, New ChartAppearanceEventArgs(PaletteName, AppearanceName, ColorIndex))
            End If
        End Sub
        Public Property PaletteName() As String
            Get
                Return chartControl.PaletteName()
            End Get
            Set(ByVal value As String)
                chartControl.PaletteName = value
            End Set
        End Property
        Public Property AppearanceName() As String
            Get
                Return chartControl.AppearanceName
            End Get
            Set(ByVal value As String)
                chartControl.AppearanceName = value
            End Set
        End Property
        Public Property ColorIndex() As Integer
            Get
                Return chartControl.PaletteBaseColorNumber
            End Get
            Set(ByVal value As Integer)
                chartControl.PaletteBaseColorNumber = value
            End Set
        End Property
#Region "CurrentStyle"
        Private ReadOnly Property CurrentAppearanceName() As String
            Get
                Dim innerCheckedList As List(Of GalleryItem) = Me.styleGalleryBarItem.Gallery.GetCheckedItems()
                Return innerCheckedList(0).Caption
            End Get
        End Property
        Private ReadOnly Property CurrentPaletteColor() As Integer
            Get
                Dim innerCheckedList As List(Of GalleryItem) = Me.styleGalleryBarItem.Gallery.GetCheckedItems()
                Return CInt(Fix(innerCheckedList(0).Tag))
            End Get
        End Property
#End Region
#Region "InitData"
        Private Sub InitChartPaletteGallery(ByVal gallery As GalleryDropDown)
            gallery.Gallery.DestroyItems()
            Dim paletteNames() As String = chartControl.GetPaletteNames()
            gallery.Gallery.BeginUpdate()
            For i As Integer = 0 To paletteNames.Length - 1
                Dim gPaletteItem As New GalleryItem()
                gPaletteItem.Caption = paletteNames(i)
                gPaletteItem.Hint = paletteNames(i)
                gPaletteItem.Image = CreateEditorImage(chartControl.PaletteRepository(paletteNames(i)))
                gallery.Gallery.Groups(0).Items.Add(gPaletteItem)
            Next i
            gallery.Gallery.EndUpdate()
            UpdateCurrentPalette()
        End Sub
        Public Sub UpdateCurrentPalette()
            Dim innerList As List(Of GalleryItem) = Me.paletteGallery.Gallery.GetAllItems()
            For Each item As GalleryItem In innerList
                If item.Caption = chartControl.PaletteName Then
                    paletteGallery.Gallery.SetItemCheck(item, True, True)
                    paletteButton.Hint = String.Format(ConstStrings.PaletteButtonHint, chartControl.PaletteName)
                    Return
                End If
            Next item
        End Sub
        Public Sub UpdateCurrentAppearance()
            InitChartAppearanceGallery(Me.styleGalleryBarItem, chartControl.PaletteName)
        End Sub
        Private Sub InitChartAppearanceGallery(ByVal galleryBarItem As RibbonGalleryBarItem, ByVal paletteName As String)
            Dim checkedItem As GalleryItem = Nothing
            galleryBarItem.Gallery.DestroyItems()
            galleryBarItem.Gallery.Groups.Clear()
            Dim palette As Palette = chartControl.PaletteRepository(paletteName)
            galleryBarItem.Gallery.BeginUpdate()
            For Each appearance As ChartAppearance In chartControl.AppearanceRepository
                Dim currentPalette As Palette = chartControl.PaletteRepository(chartControl.PaletteName)
                If (Not appearance.IsDefault) AndAlso (Not String.IsNullOrEmpty(appearance.PaletteName)) Then
                    Continue For
                End If
                Dim group As New GalleryItemGroup()
                group.Caption = appearance.Name
                galleryBarItem.Gallery.Groups.Add(group)
                For i As Integer = 0 To palette.Count
                    Dim gAppearanceItem As New GalleryItem()
                    gAppearanceItem.Caption = appearance.Name
                    gAppearanceItem.Hint = GetStyleName(appearance, i)
                    gAppearanceItem.Tag = i
                    gAppearanceItem.Image = AppearanceImageHelper.CreateImage(ViewType, appearance, palette, i)
                    group.Items.Add(gAppearanceItem)
                    If chartControl.AppearanceName = appearance.Name AndAlso chartControl.PaletteBaseColorNumber = i Then
                        checkedItem = gAppearanceItem
                    End If
                Next i
            Next appearance
            galleryBarItem.Gallery.EndUpdate()
            galleryBarItem.Tag = palette.Count
            galleryBarItem.Gallery.SetItemCheck(checkedItem, True, True)
            Dim ribbon As RibbonControl = (CType(galleryBarItem.Manager, RibbonBarManager)).Ribbon
            ribbon.UpdateViewInfo()
            checkedItem.MakeVisible()
        End Sub
        Private Shared Function GetStyleName(ByVal appearance As ChartAppearance, ByVal index As Integer) As String
            If index = 0 Then
                Return String.Format("{0} ({1})", appearance.Name, ChartLocalizer.GetString(ChartStringId.StyleAllColors))
            End If
            Dim colorString As String
            colorString = String.Format(ChartLocalizer.GetString(ChartStringId.StyleColorNumber), index)
            Return String.Format("{0} ({1})", appearance.Name, colorString)
        End Function
        Public Shared Function CreateEditorImage(ByVal palette As Palette) As Image
            Const imageSize As Integer = 10
            Dim image As Bitmap = Nothing
            Try
                image = New Bitmap(palette.Count * (imageSize + 1) - 1, imageSize)
                Using g As Graphics = Graphics.FromImage(image)
                    Dim rect As New Rectangle(Point.Empty, New Size(imageSize, imageSize))
                    Dim i As Integer = 0
                    Do While i < palette.Count
                        Using brush As Brush = New SolidBrush(palette(i).Color)
                            g.FillRectangle(brush, rect)
                        End Using
                        Dim penRect As Rectangle = rect
                        penRect.Width -= 1
                        penRect.Height -= 1
                        Using pen As New Pen(Color.Gray)
                            g.DrawRectangle(pen, penRect)
                        End Using
                        i += 1
                        rect.X += 11
                    Loop
                End Using
            Catch
                If (Not Object.Equals(image, Nothing)) Then
                    image.Dispose()
                    image = Nothing
                End If
            End Try
            Return image
        End Function
#End Region
    End Class
    Public Class StickLookAndFeelForm
        Inherits CustomTopForm
        Private painter As New EmptySkinElementPainter()
        Public Sub New()
            AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf Default_StyleChanged
            UpdateRegion()
        End Sub

        Private Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateRegion()
        End Sub
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim skin As Skin = BarSkins.GetSkin(UserLookAndFeel.Default)
            Dim cache As New GraphicsCache(e)
            DrawContent(cache, skin)
            DrawTopElement(cache, skin)
            MyBase.OnPaint(e)
        End Sub
        Private Function GetTopElementRectangle() As Rectangle
            Dim r As Rectangle = Me.ClientRectangle
            Return New Rectangle(r.X, r.Y, r.Width, 10)
        End Function
        Private Sub DrawContent(ByVal graphicsCache As GraphicsCache, ByVal skin As Skin)
            Dim element As SkinElement = skin(BarSkins.SkinAlertWindow)
            Dim eInfo As New SkinElementInfo(element, Me.ClientRectangle)
            ObjectPainter.DrawObject(graphicsCache, SkinElementPainter.Default, eInfo)
        End Sub
        Private Sub DrawTopElement(ByVal graphicsCache As GraphicsCache, ByVal skin As Skin)
            Dim element As SkinElement = skin(BarSkins.SkinAlertCaptionTop)
            Dim eInfo As New SkinElementInfo(element, GetTopElementRectangle())
            ObjectPainter.DrawObject(graphicsCache, painter, eInfo)
        End Sub
        Friend Sub UpdateRegion()
            Dim se As SkinElement = BarSkins.GetSkin(UserLookAndFeel.Default)(BarSkins.SkinAlertWindow)
            If Object.Equals(se, Nothing) Then
                Me.Region = Nothing
                Return
            End If
            Dim cornerRadius As Integer = se.Properties.GetInteger(BarSkins.SkinAlertWindowCornerRadius)
            If cornerRadius = 0 Then
                Me.Region = Nothing
            Else
                Me.Region = NativeMethods.CreateRoundRegion(New Rectangle(Point.Empty, Me.Size), cornerRadius)
            End If
        End Sub
        Protected Overrides ReadOnly Property HasSystemShadow() As Boolean
            Get
                Return True
            End Get
        End Property
        Private Class EmptySkinElementPainter
            Inherits SkinElementPainter
            Protected Overrides Sub DrawSkinForeground(ByVal ee As SkinElementInfo)
            End Sub
        End Class
    End Class
    Public Class FormAnimationSizer
        Private parent As Form
        Private sizeInit As Size
        Private tmr As Timer = Nothing
        Private minHeight As Integer = 0
        Private [step] As Integer = 10
        Private heightStep As Integer = 0
        Public Sub New(ByVal form As Form)
            parent = form
            sizeInit = form.ClientSize
            parent.StartPosition = FormStartPosition.Manual
            Dim vLeft As Integer = CInt(Fix(Screen.PrimaryScreen.WorkingArea.Width - sizeInit.Width) / 2)
            Dim vRight As Integer = CInt(Fix(Screen.PrimaryScreen.WorkingArea.Height - sizeInit.Height) / 2)
            parent.Location = New Point(Screen.PrimaryScreen.WorkingArea.Left + vLeft, Screen.PrimaryScreen.WorkingArea.Top + vRight)
            tmr = New Timer()
            tmr.Enabled = False
            tmr.Interval = 20
            AddHandler tmr.Tick, AddressOf tmr_Tick
        End Sub
        Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim allowHeight As Integer
            If minHeight > parent.ClientSize.Height Then
                allowHeight = parent.ClientSize.Height + (heightStep)
            Else
                allowHeight = parent.ClientSize.Height + (-heightStep)
            End If
            heightStep += CType([step] / 2, Integer)
            If Math.Abs(allowHeight - minHeight) <= heightStep Then
                parent.ClientSize = New Size(sizeInit.Width, minHeight)
                tmr.Stop()
            Else
                parent.ClientSize = New Size(sizeInit.Width, allowHeight)
            End If
        End Sub
        Public Sub SetMinHeight(ByVal height As Integer)
            Dim animation As Boolean = minHeight <> 0
            minHeight = height
            If animation Then
                heightStep = [step]
                tmr.Start()
            Else
                parent.ClientSize = New Size(sizeInit.Width, minHeight)
            End If
        End Sub
    End Class
    Public Class HotLabel
        Inherits LabelControl
        Private flinkText As String = String.Empty
        Public Sub New()
            AddHandler LookAndFeel.StyleChanged, AddressOf Default_StyleChanged
            UpdateColors()
        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                RemoveHandler LookAndFeel.StyleChanged, AddressOf Default_StyleChanged
            End If
            MyBase.Dispose(disposing)
        End Sub
        <DefaultValue("")> _
        Public Property LinkText() As String
            Get
                Return flinkText
            End Get
            Set(ByVal value As String)
                If flinkText = value Then
                    Return
                End If
                flinkText = value
            End Set
        End Property
        Private Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColors()
        End Sub
        Public Sub UpdateColors()
            If DesignMode Then
                Return
            End If
            Me.Appearance.ForeColor = WinHelper.GetLinkColor(LookAndFeel)
        End Sub
        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            If DesignMode Then
                Return
            End If
            Appearance.Font = New Font(Appearance.Font, FontStyle.Underline)
            Cursor = Cursors.Hand
        End Sub
        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            If DesignMode Then
                Return
            End If
            Appearance.Font = New Font(Appearance.Font, FontStyle.Regular)
            Cursor = Cursors.Default
        End Sub
        Protected Overrides Sub OnMouseClick(ByVal e As MouseEventArgs)
            MyBase.OnMouseClick(e)
            If DesignMode OrElse String.IsNullOrEmpty(LinkText) Then
                Return
            End If
            Cursor = Cursors.WaitCursor
            ObjectHelper.ShowWebSite(LinkText)
        End Sub
    End Class
End Namespace
