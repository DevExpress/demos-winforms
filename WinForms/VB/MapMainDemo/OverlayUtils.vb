Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Demos.FlagsGameCore
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.DPI

Namespace DevExpress.XtraMap.Demos

    Public Module OverlayUtils

        Public Function GetClickedOverlayItem(ByVal hitInfo As MapHitInfo) As MapOverlayItemBase
            If hitInfo.InUIElement Then
                Dim overlayHitInfo As MapOverlayHitInfo = TryCast(hitInfo.UiHitInfo, MapOverlayHitInfo)
                If overlayHitInfo IsNot Nothing Then Return overlayHitInfo.OverlayItem
            End If

            Return Nothing
        End Function
    End Module

    Public MustInherit Class OverlayManagerBase
        Implements IDisposable

        Private ReadOnly fontsCollectionField As Dictionary(Of String, Font)

        Protected ReadOnly Property FontsCollection As Dictionary(Of String, Font)
            Get
                Return fontsCollectionField
            End Get
        End Property

        Protected Sub New()
            fontsCollectionField = CreateFonts()
        End Sub

        Protected MustOverride Function CreateFonts() As Dictionary(Of String, Font)

#Region "IDisposable implementation"
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                Dim keysCollection As IEnumerable(Of String) = New List(Of String)(fontsCollectionField.Keys)
                For Each key As String In keysCollection
                    If fontsCollectionField(key) IsNot Nothing Then
                        fontsCollectionField(key).Dispose()
                        fontsCollectionField(key) = Nothing
                    End If
                Next
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Protected Overrides Sub Finalize()
            Dispose(False)
        End Sub
#End Region
    End Class

    Public Class HotelPlansOverlayManager
        Inherits OverlayManagerBase

        Private overlayField As MapOverlay

        Private backImageField As MapOverlayImageItem

        Private hotelNameField As MapOverlayTextItem

        Public ReadOnly Property Overlay As MapOverlay
            Get
                Return overlayField
            End Get
        End Property

        Public ReadOnly Property BackImage As MapOverlayImageItem
            Get
                Return backImageField
            End Get
        End Property

        Public ReadOnly Property HotelName As MapOverlayTextItem
            Get
                Return hotelNameField
            End Get
        End Property

        Public Sub New()
            CreateOverlay()
        End Sub

        Private Sub CreateOverlay()
            backImageField = New MapOverlayImageItem() With {.Padding = New Padding(5), .ImageUri = New Uri(DemoUtils.GetRelativePath("Images\BackButton.png"))}
            hotelNameField = New MapOverlayTextItem() With {.Padding = New Padding(15)}
            hotelNameField.TextStyle.Font = FontsCollection("back_text")
            overlayField = New MapOverlay() With {.Alignment = ContentAlignment.TopLeft, .Margin = New Padding(10, 10, 0, 0)}
            overlayField.BackgroundStyle.Fill = Color.Transparent
            overlayField.Items.AddRange(New MapOverlayItemBase() {backImageField, hotelNameField})
        End Sub

        Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
            Dim collection As Dictionary(Of String, Font) = New Dictionary(Of String, Font)()
            collection.Add("back_text", New Font(AppearanceObject.DefaultFont.FontFamily, 20, FontStyle.Bold))
            Return collection
        End Function

        Public Function GetOverlays() As MapOverlay()
            Return New MapOverlay() {overlayField}
        End Function
    End Class

    Public Class MapDemoOverlayManager
        Inherits OverlayManagerBase

        Private overlayField As MapOverlay

        Private messageItemField As MapOverlayTextItem

        Public ReadOnly Property Overlay As MapOverlay
            Get
                Return overlayField
            End Get
        End Property

        Public ReadOnly Property MessageItem As MapOverlayTextItem
            Get
                Return messageItemField
            End Get
        End Property

        Public Sub New()
            CreateOverlay()
        End Sub

        Private Sub CreateOverlay()
            messageItemField = New MapOverlayTextItem() With {.Padding = New Padding(15, 10, 15, 10), .Text = "Click the map or use Search to find a location."}
            messageItemField.TextStyle.Font = FontsCollection("message")
            overlayField = New MapOverlay() With {.Alignment = ContentAlignment.TopLeft, .Margin = New Padding(8, 8, 0, 0)}
            overlayField.Items.Add(messageItemField)
        End Sub

        Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
            Dim collection As Dictionary(Of String, Font) = New Dictionary(Of String, Font)()
            collection.Add("message", New Font(AppearanceObject.DefaultFont.FontFamily, 20, FontStyle.Regular))
            Return collection
        End Function

        Public Function GetOverlays() As MapOverlay()
            Return New MapOverlay() {overlayField}
        End Function
    End Class

    Public Class PhotoGalleryOverlayManager
        Inherits OverlayManagerBase

        Private backIconOverlayField As MapOverlay

        Private placeOverlayField As MapOverlay

        Private navigationOverlayField As MapOverlay

        Private descriptionOverlayField As MapOverlay

        Private leftArrow As Image

        Private rightArrow As Image

        Public ReadOnly Property BackIconOverlay As MapOverlay
            Get
                Return backIconOverlayField
            End Get
        End Property

        Public ReadOnly Property PlaceOverlay As MapOverlay
            Get
                Return placeOverlayField
            End Get
        End Property

        Public ReadOnly Property NavigationOverlay As MapOverlay
            Get
                Return navigationOverlayField
            End Get
        End Property

        Public ReadOnly Property DescriptionOverlay As MapOverlay
            Get
                Return descriptionOverlayField
            End Get
        End Property

        Public ReadOnly Property BackIcon As MapOverlayImageItem
            Get
                Return CType(backIconOverlayField.Items(0), MapOverlayImageItem)
            End Get
        End Property

        Public ReadOnly Property CityName As MapOverlayTextItem
            Get
                Return CType(placeOverlayField.Items(0), MapOverlayTextItem)
            End Get
        End Property

        Public ReadOnly Property PlaceImage As MapOverlayImageItem
            Get
                Return CType(placeOverlayField.Items(1), MapOverlayImageItem)
            End Get
        End Property

        Public ReadOnly Property PlacePrevImage As MapOverlayImageItem
            Get
                Return CType(navigationOverlayField.Items(0), MapOverlayImageItem)
            End Get
        End Property

        Public ReadOnly Property PlaceNextImage As MapOverlayImageItem
            Get
                Return CType(navigationOverlayField.Items(2), MapOverlayImageItem)
            End Get
        End Property

        Public ReadOnly Property PlaceName As MapOverlayTextItem
            Get
                Return CType(navigationOverlayField.Items(1), MapOverlayTextItem)
            End Get
        End Property

        Public ReadOnly Property PlaceDescription As MapOverlayTextItem
            Get
                Return CType(descriptionOverlayField.Items(0), MapOverlayTextItem)
            End Get
        End Property

        Public Sub New()
            leftArrow = Image.FromFile(DemoUtils.GetRelativePath("Images\PhotoGallery\PrevPlace.png"))
            rightArrow = Image.FromFile(DemoUtils.GetRelativePath("Images\PhotoGallery\NextPlace.png"))
            CreateOverlays()
        End Sub

        Private Sub CreateGalleryBackIconOverlay()
            backIconOverlayField = New MapOverlay() With {.Alignment = ContentAlignment.TopLeft, .Margin = New Padding(10, 10, 0, 0), .Padding = New Padding(5)}
            backIconOverlayField.BackgroundStyle.Fill = Color.Transparent
            Dim imageItem As MapOverlayImageItem = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\BackButton.png"))}
            backIconOverlayField.Items.Add(imageItem)
        End Sub

        Private Sub CreateGalleryPlaceOverlay()
            placeOverlayField = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .Margin = New Padding(0, 10, 10, 0)}
            Dim imageItem As MapOverlayImageItem = New MapOverlayImageItem() With {.Alignment = ContentAlignment.TopCenter, .JoiningOrientation = Orientation.Vertical, .Padding = New Padding(20, 10, 20, 10)}
            Dim cityNameItem As MapOverlayTextItem = New MapOverlayTextItem() With {.Alignment = ContentAlignment.TopCenter, .JoiningOrientation = Orientation.Vertical, .Padding = New Padding(0, 10, 0, 0)}
            cityNameItem.TextStyle.Font = FontsCollection("city")
            placeOverlayField.Items.AddRange(New MapOverlayItemBase() {cityNameItem, imageItem})
        End Sub

        Private Sub CreateGalleryNavigationOverlay()
            navigationOverlayField = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 0, 10, 0), .Padding = New Padding(10)}
            Dim prevPlaceItem As MapOverlayImageItem = New MapOverlayImageItem() With {.Alignment = ContentAlignment.TopLeft}
            Dim placeNameItem As MapOverlayTextItem = New MapOverlayTextItem() With {.Alignment = ContentAlignment.TopLeft, .TextAlignment = ContentAlignment.MiddleCenter, .Size = New Size(242, 0), .Padding = New Padding(10, 0, 10, 0)}
            Dim nextPlaceItem As MapOverlayImageItem = New MapOverlayImageItem() With {.Alignment = ContentAlignment.TopLeft}
            placeNameItem.TextStyle.Font = FontsCollection("place")
            navigationOverlayField.Items.AddRange(New MapOverlayItemBase() {prevPlaceItem, placeNameItem, nextPlaceItem})
        End Sub

        Private Sub CreateGalleryDescriptionOverlay()
            descriptionOverlayField = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 10, 10, 0)}
            Dim descriptionItem As MapOverlayTextItem = New MapOverlayTextItem() With {.Alignment = ContentAlignment.BottomCenter, .Padding = New Padding(10, 0, 10, 0), .Size = New Size(300, 0)}
            descriptionItem.TextStyle.Font = FontsCollection("desc")
            descriptionOverlayField.Items.Add(descriptionItem)
        End Sub

        Private Sub CreateOverlays()
            CreateGalleryBackIconOverlay()
            CreateGalleryPlaceOverlay()
            CreateGalleryNavigationOverlay()
            CreateGalleryDescriptionOverlay()
        End Sub

        Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
            Dim collection As Dictionary(Of String, Font) = New Dictionary(Of String, Font)()
            collection.Add("city", New Font(AppearanceObject.DefaultFont.FontFamily, 12, FontStyle.Bold))
            collection.Add("place", New Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Bold))
            collection.Add("desc", New Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Regular))
            Return collection
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If leftArrow IsNot Nothing Then
                leftArrow.Dispose()
                leftArrow = Nothing
            End If

            If rightArrow IsNot Nothing Then
                rightArrow.Dispose()
                rightArrow = Nothing
            End If

            MyBase.Dispose(disposing)
        End Sub

        Public Function GetOverlays() As MapOverlay()
            Return New MapOverlay() {backIconOverlayField, placeOverlayField, navigationOverlayField, descriptionOverlayField}
        End Function

        Public Sub UpdateImages(ByVal lookAndFeel As UserLookAndFeel)
            UpdateColor(leftArrow, lookAndFeel)
            UpdateColor(rightArrow, lookAndFeel)
            PlacePrevImage.Image = Nothing
            PlacePrevImage.Image = leftArrow
            PlaceNextImage.Image = Nothing
            PlaceNextImage.Image = rightArrow
        End Sub
    End Class

    Public Class MapElementsOverlayManager
        Inherits OverlayManagerBase

        Private ReadOnly mapControl As MapControl

        Private ReadOnly airportItemsNames As Dictionary(Of String, String)

        Private ReadOnly spacingMask As Dictionary(Of String, Boolean)

        Private ReadOnly planeItemsNames As Dictionary(Of String, String)

        Private imageOverlay As MapOverlay

        Private infoOverlay As MapOverlay

        Private titleOverlay As MapOverlay

        Private airportInfoOverlay As MapOverlay

        Private imageItem As MapOverlayImageItem

        Private ReadOnly keys As List(Of String) = New List(Of String)() From {"name", "id", "from", "to", "current_time", "flight_time", "speed", "altitude"}

        Private ReadOnly ap_keys As List(Of String) = New List(Of String)() From {"ap_name", "ap_iata", "ap_city", "ap_country", "ap_latitude", "ap_longitude"}

        Private ReadOnly planeTextItems As Dictionary(Of String, MapOverlayTextItem)

        Private ReadOnly airportTextItems As Dictionary(Of String, MapOverlayTextItem)

        Public ReadOnly Property Map As MapControl
            Get
                Return mapControl
            End Get
        End Property

        Public Sub New(ByVal mapControl As MapControl)
            planeTextItems = New Dictionary(Of String, MapOverlayTextItem)()
            airportTextItems = New Dictionary(Of String, MapOverlayTextItem)()
            Me.mapControl = mapControl
            planeItemsNames = CreatePlaneFields()
            airportItemsNames = CreateAirportFields()
            spacingMask = CreateSpacingMask()
            CreateOverlays()
            SetOverlaysVisibility(False, False)
        End Sub

        Private Function CreatePlaneFields() As Dictionary(Of String, String)
            Dim result As Dictionary(Of String, String) = New Dictionary(Of String, String)()
            result.Add(keys(0), "Name")
            result.Add(keys(1), "Flight number")
            result.Add(keys(2), "From")
            result.Add(keys(3), "To")
            result.Add(keys(4), "Current time")
            result.Add(keys(5), "Flight time")
            result.Add(keys(6), "Speed")
            result.Add(keys(7), "Altitude")
            Return result
        End Function

        Private Function CreateAirportFields() As Dictionary(Of String, String)
            Dim result As Dictionary(Of String, String) = New Dictionary(Of String, String)()
            result.Add(ap_keys(0), "Name:")
            result.Add(ap_keys(1), "IATA:")
            result.Add(ap_keys(2), "City:")
            result.Add(ap_keys(3), "Country:")
            result.Add(ap_keys(4), "Latitude:")
            result.Add(ap_keys(5), "Longitude:")
            Return result
        End Function

        Private Function CreateSpacingMask() As Dictionary(Of String, Boolean)
            Dim result As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean)()
            result.Add(keys(0), True)
            result.Add(keys(1), False)
            result.Add(keys(2), False)
            result.Add(keys(3), True)
            result.Add(keys(4), False)
            result.Add(keys(5), True)
            result.Add(keys(6), False)
            result.Add(keys(7), False)
            Return result
        End Function

        Private Sub CreateImageOverlay()
            imageOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .Margin = New Padding(0, 10, 10, 0), .Padding = New Padding(10)}
            imageItem = New MapOverlayImageItem()
            imageOverlay.Items.Add(imageItem)
        End Sub

        Private Sub CreatePlaneInfoOverlay()
            infoOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 0, 10, 0), .Padding = New Padding(10)}
            planeTextItems.Clear()
            For Each key As String In keys
                Dim bottomPadding As Integer = If(spacingMask(key), 13, 3)
                Dim itemText As String = String.Format("{0}:", planeItemsNames(key))
                Dim labelItem As MapOverlayTextItem = New MapOverlayTextItem() With {.Alignment = ContentAlignment.TopLeft, .JoiningOrientation = Orientation.Vertical, .Size = New Size(105, 0), .Padding = New Padding(0, 3, 0, bottomPadding), .Text = itemText}
                labelItem.TextStyle.Font = FontsCollection("label")
                Dim valueItem As MapOverlayTextItem = New MapOverlayTextItem() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Size = New Size(120, 0), .Padding = New Padding(0, 3, 0, bottomPadding)}
                valueItem.TextStyle.Font = FontsCollection("value")
                planeTextItems.Add(key, valueItem)
                infoOverlay.Items.AddRange(New MapOverlayItemBase() {labelItem, valueItem})
            Next
        End Sub

        Private Sub CreateAirportInfoOverlay()
            airportInfoOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .Margin = New Padding(0, 10, 10, 0), .Padding = New Padding(10)}
            airportTextItems.Clear()
            For i As Integer = 0 To ap_keys.Count - 1
                Dim key As String = ap_keys(i)
                Dim bottomPadding As Integer = If(i = 3, 10, 3)
                Dim itemText As String = airportItemsNames(key)
                Dim labelItem As MapOverlayTextItem = New MapOverlayTextItem() With {.Alignment = ContentAlignment.TopLeft, .JoiningOrientation = Orientation.Vertical, .Size = New Size(70, If(i = 0, 28, 0)), .Padding = New Padding(0, 3, 0, bottomPadding), .Text = itemText}
                labelItem.TextStyle.Font = FontsCollection("label")
                Dim valueItem As MapOverlayTextItem = New MapOverlayTextItem() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Size = New Size(125, If(i = 0, 28, 0)), .Padding = New Padding(0, 3, 0, bottomPadding)}
                valueItem.TextStyle.Font = FontsCollection("value")
                airportTextItems.Add(key, valueItem)
                airportInfoOverlay.Items.AddRange(New MapOverlayItemBase() {labelItem, valueItem})
            Next
        End Sub

        Private Sub CreateOverlays()
            CreateImageOverlay()
            CreatePlaneInfoOverlay()
            CreateAirportInfoOverlay()
            titleOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopLeft, .Margin = New Padding(10), .Padding = New Padding(6)}
            titleOverlay.Items.Add(New MapOverlayTextItem() With {.Alignment = ContentAlignment.MiddleCenter, .Text = "Live Flight Tracker"})
        End Sub

        Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
            Dim collection As Dictionary(Of String, Font) = New Dictionary(Of String, Font)()
            collection.Add("label", New Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Regular))
            collection.Add("value", New Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Bold))
            Return collection
        End Function

        Public Function GetOverlays() As MapOverlay()
            Return New MapOverlay() {titleOverlay, imageOverlay, infoOverlay, airportInfoOverlay}
        End Function

        Public Sub SetTextToItemByKey(ByVal key As String, ByVal text As String)
            Dim planeItem As MapOverlayTextItem = Nothing
            If planeTextItems.TryGetValue(key, planeItem) Then planeItem.Text = text
            Dim airportItem As MapOverlayTextItem = Nothing
            If airportTextItems.TryGetValue(key, airportItem) Then airportItem.Text = text
        End Sub

        Public Sub SetImage(ByVal image As Image)
            imageItem.Image = image
        End Sub

        Public Sub SetOverlaysVisibility(ByVal planeInfoVisible As Boolean, ByVal airportVisible As Boolean)
            imageOverlay.Visible = planeInfoVisible
            infoOverlay.Visible = planeInfoVisible
            airportInfoOverlay.Visible = airportVisible
        End Sub
    End Class

    Public Class FlagsGameOverlayManager
        Inherits OverlayManagerBase

        Private Shared ReadOnly HotTrackedColor As Color = Color.FromArgb(128, 135, 135, 135)

        Private Shared ReadOnly ChooseLevelBackgroundColor As Color = Color.FromArgb(32, Color.Gray)

        Const LevelBottomPadding As Integer = 110

        Private ReadOnly levelNames As String()

        Private ReadOnly levelDescriptions As Dictionary(Of String, String)

        Private levelItems As Dictionary(Of MapOverlayImageItem, MapOverlayTextItem)

        Private levelSelectorItems As Dictionary(Of MapOverlayTextItem, MapOverlayTextItem)

        Private selectedLevelItem As MapOverlayTextItem

        Private newGameOverlay, chooseLevelOverlay As MapOverlay

        Private startGameItem As MapOverlayTextItem

        Private levelDescItem As MapOverlayTextItem

        Private infoOverlay As MapOverlay

        Private infoTextItem As MapOverlayTextItem

        Private countryFlagOverlay As MapOverlay

        Private flagItem As MapOverlayImageItem

        Private countryName As MapOverlayTextItem

        Private skipCountryOverlay, showCountryOverlay As MapOverlay

        Private restartGameOverlay, finishGameOverlay As MapOverlay

        Private skipCountryItem, showCountryItem As MapOverlayTextItem

        Private restartGameItem, finishGameItem As MapOverlayTextItem

        Private statisticGameOverlay As MapOverlay

        Private scoreImage, timeImage As MapOverlayImageItem

        Private scoreLabel, timeLabel As MapOverlayTextItem

        Private scoreItem, winsItem, lossesItem, timeItem As MapOverlayTextItem

        Private gameOverOverlay, scoreOverOverlay As MapOverlay

        Private newGameItem, scoreOverItem As MapOverlayTextItem

        Public Sub New(ByVal levelNames As String(), ByVal levelDescriptions As Dictionary(Of String, String))
            Me.levelNames = levelNames
            Me.levelDescriptions = levelDescriptions
            CreateOverlays()
            HidePanels()
        End Sub

        Private Sub CreateOverlays()
            CreateNewGameOverlay()
            CreateChooseLevelOverlay()
            CreateCountryGameOverlay()
            CreateStatisticGameOverlay()
            CreateOperationGameOverlay()
            CreateScoreOverOverlay()
            CreateGameOverOverlay()
            CreateGameInfoOverlay()
        End Sub

        Private Sub CreateNewGameOverlay()
            newGameOverlay = New MapOverlay() With {.Alignment = ContentAlignment.MiddleCenter, .Padding = New Padding(30)}
            Dim titleText As MapOverlayTextItem = New MapOverlayTextItem() With {.Text = "New Game", .Alignment = ContentAlignment.TopCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(35, 0, 35, 12)}
            titleText.TextStyle.Font = FontsCollection("title")
            Dim infoText As MapOverlayTextItem = New MapOverlayTextItem() With {.Text = "Choose your level", .Alignment = ContentAlignment.TopCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(35, 0, 35, LevelBottomPadding), .Size = New Size(470, 0)}
            infoText.TextStyle.Font = FontsCollection("note")
            levelDescItem = New MapOverlayTextItem() With {.Alignment = ContentAlignment.BottomCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Margin = New Padding(0, 30, 0, 30), .Size = New Size(400, 0)}
            levelDescItem.TextStyle.Font = FontsCollection("default")
            startGameItem = New MapOverlayTextItem() With {.Text = "START GAME", .Alignment = ContentAlignment.BottomCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(20, 10, 20, 10)}
            startGameItem.TextStyle.Font = FontsCollection("button")
            startGameItem.TextStyle.TextColor = Color.White
            startGameItem.BackgroundStyle.Fill = Color.FromArgb(&H74, &H9F, &HDF)
            startGameItem.HotTrackedStyle.Fill = Color.FromArgb(&HAF, &H74, &H9F, &HDF)
            newGameOverlay.Items.AddRange(New MapOverlayItemBase() {titleText, infoText, startGameItem, levelDescItem})
        End Sub

        Private Sub CreateChooseLevelOverlay()
            chooseLevelOverlay = New MapOverlay()
            levelItems = New Dictionary(Of MapOverlayImageItem, MapOverlayTextItem)()
            levelSelectorItems = New Dictionary(Of MapOverlayTextItem, MapOverlayTextItem)()
            For Each levelName As String In levelNames
                Dim levelIconName As String = levelName.ToLower().Replace(" "c, "_"c)
                Dim iconItem As MapOverlayImageItem = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\" & levelIconName & ".png")), .JoiningOrientation = Orientation.Horizontal, .Padding = New Padding(37, 20, 37, 20)}
                Dim nameItem As MapOverlayTextItem = New MapOverlayTextItem() With {.Text = levelName.ToUpper(), .Size = New Size(80, 0), .Padding = New Padding(0, 20, 0, 20), .TextAlignment = ContentAlignment.BottomCenter}
                nameItem.TextStyle.Font = FontsCollection("level")
                nameItem.HotTrackedStyle.Fill = ChooseLevelBackgroundColor
                Dim selectorItem As MapOverlayTextItem = New MapOverlayTextItem()
                selectorItem.HotTrackedStyle.Fill = ChooseLevelBackgroundColor
                levelItems.Add(iconItem, nameItem)
                levelSelectorItems.Add(nameItem, selectorItem)
            Next

            chooseLevelOverlay.Items.AddRange(levelItems.Keys)
            chooseLevelOverlay.Items.AddRange(levelItems.Values)
            chooseLevelOverlay.Items.AddRange(levelSelectorItems.Values)
        End Sub

        Private Sub CreateGameOverOverlay()
            gameOverOverlay = New MapOverlay() With {.Alignment = ContentAlignment.MiddleCenter, .JoiningOrientation = Orientation.Vertical, .Padding = New Padding(20)}
            Dim titleText As MapOverlayTextItem = New MapOverlayTextItem() With {.Text = "GAME OVER", .Alignment = ContentAlignment.BottomCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(0, 0, 0, 15)}
            titleText.TextStyle.Font = FontsCollection("title")
            newGameItem = New MapOverlayTextItem() With {.Text = "NEW GAME", .Alignment = ContentAlignment.BottomCenter, .JoiningOrientation = Orientation.Vertical, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(20, 10, 20, 10)}
            newGameItem.TextStyle.Font = FontsCollection("button")
            newGameItem.TextStyle.TextColor = Color.White
            newGameItem.BackgroundStyle.Fill = Color.FromArgb(&H40, &HAB, &H5B)
            newGameItem.HotTrackedStyle.Fill = Color.FromArgb(&HAF, &H40, &HAB, &H5B)
            gameOverOverlay.Items.AddRange(New MapOverlayItemBase() {newGameItem, titleText})
        End Sub

        Private Sub CreateScoreOverOverlay()
            scoreOverOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopCenter, .Margin = New Padding(0, 12, 0, 0), .Padding = New Padding(0, 15, 0, 5)}
            Dim scoreOverLabel As MapOverlayTextItem = New MapOverlayTextItem() With {.Text = "SCORE:"}
            scoreOverLabel.TextStyle.Font = FontsCollection("score_over")
            scoreOverItem = New MapOverlayTextItem() With {.Padding = New Padding(10, 0, 0, 0)}
            scoreOverItem.TextStyle.Font = FontsCollection("score_over")
            scoreOverOverlay.Items.AddRange(New MapOverlayItemBase() {scoreOverLabel, scoreOverItem})
        End Sub

        Private Sub CreateCountryGameOverlay()
            countryFlagOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopLeft, .Margin = New Padding(12, 12, 0, 0)}
            countryName = New MapOverlayTextItem() With {.Alignment = ContentAlignment.BottomCenter, .TextAlignment = ContentAlignment.MiddleCenter, .Padding = New Padding(12, 0, 12, 15), .Size = New Size(150, 0)}
            countryName.TextStyle.Font = FontsCollection("bold")
            flagItem = New MapOverlayImageItem() With {.Alignment = ContentAlignment.TopCenter, .Padding = New Padding(20)}
            countryFlagOverlay.Items.AddRange(New MapOverlayItemBase() {countryName, flagItem})
        End Sub

        Private Sub CreateStatisticGameOverlay()
            statisticGameOverlay = New MapOverlay() With {.JoiningOrientation = Orientation.Vertical, .Padding = New Padding(15, 3, 10, 3), .Margin = New Padding(0, 0, 0, 7)}
            scoreImage = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\score.png")), .Margin = New Padding(8, 12, 10, 12)}
            scoreLabel = New MapOverlayTextItem() With {.Text = "Score:", .Padding = New Padding(0, 10, 5, 10)}
            scoreLabel.TextStyle.Font = FontsCollection("default")
            scoreItem = New MapOverlayTextItem() With {.Padding = New Padding(0, 10, 10, 10)}
            scoreItem.TextStyle.Font = FontsCollection("default")
            Dim winsImage As MapOverlayImageItem = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\wins.png")), .Margin = New Padding(8, 12, 10, 12)}
            Dim winsLabel As MapOverlayTextItem = New MapOverlayTextItem() With {.Text = "Wins:", .Padding = New Padding(0, 10, 5, 10)}
            winsLabel.TextStyle.Font = FontsCollection("default")
            winsItem = New MapOverlayTextItem() With {.Padding = New Padding(0, 10, 10, 10)}
            winsItem.TextStyle.Font = FontsCollection("default")
            Dim lossesImage As MapOverlayImageItem = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\loses.png")), .Margin = New Padding(8, 12, 10, 12)}
            Dim lossesLabel As MapOverlayTextItem = New MapOverlayTextItem() With {.Text = "Losses:", .Padding = New Padding(0, 10, 5, 10)}
            lossesLabel.TextStyle.Font = FontsCollection("default")
            lossesItem = New MapOverlayTextItem() With {.Padding = New Padding(0, 10, 10, 10)}
            lossesItem.TextStyle.Font = FontsCollection("default")
            timeImage = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\time.png")), .Margin = New Padding(8, 12, 10, 12)}
            timeLabel = New MapOverlayTextItem() With {.Text = "Time:", .Padding = New Padding(0, 10, 5, 10)}
            timeLabel.TextStyle.Font = FontsCollection("default")
            timeItem = New MapOverlayTextItem() With {.Padding = New Padding(0, 10, 10, 10)}
            timeItem.TextStyle.Font = FontsCollection("default")
            statisticGameOverlay.Items.AddRange(New MapOverlayItemBase() {scoreImage, scoreLabel, scoreItem, winsImage, winsLabel, winsItem, lossesImage, lossesLabel, lossesItem, timeImage, timeLabel, timeItem})
        End Sub

        Private Sub CreateOperationGameOverlay()
            restartGameOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 12, 12, 0)}
            Dim restartIcon As MapOverlayImageItem = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\restart.png")), .Margin = New Padding(10, 6, 7, 6)}
            restartGameItem = New MapOverlayTextItem() With {.Text = "RESTART GAME", .Alignment = ContentAlignment.TopLeft, .Margin = New Padding(1), .Padding = New Padding(6), .Size = New Size(110, 0)}
            restartGameItem.TextStyle.Font = FontsCollection("nav_button")
            restartGameItem.HotTrackedStyle.Fill = HotTrackedColor
            restartGameOverlay.Items.AddRange(New MapOverlayItemBase() {restartIcon, restartGameItem})
            finishGameOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 0, 12, 0)}
            Dim finishIcon As MapOverlayImageItem = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\finish.png")), .Margin = New Padding(10, 6, 7, 6)}
            finishGameItem = New MapOverlayTextItem() With {.Text = "FINISH GAME", .Alignment = ContentAlignment.TopLeft, .Margin = New Padding(1), .Padding = New Padding(6), .Size = New Size(110, 0)}
            finishGameItem.TextStyle.Font = FontsCollection("nav_button")
            finishGameItem.HotTrackedStyle.Fill = HotTrackedColor
            finishGameOverlay.Items.AddRange(New MapOverlayItemBase() {finishIcon, finishGameItem})
            skipCountryOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 12, 12, 0)}
            Dim skipIcon As MapOverlayImageItem = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\skip.png")), .Margin = New Padding(10, 6, 7, 6)}
            skipCountryItem = New MapOverlayTextItem() With {.Text = "SKIP COUNTRY", .Alignment = ContentAlignment.TopLeft, .Margin = New Padding(1), .Padding = New Padding(6), .Size = New Size(110, 0)}
            skipCountryItem.TextStyle.Font = FontsCollection("nav_button")
            skipCountryItem.HotTrackedStyle.Fill = HotTrackedColor
            skipCountryOverlay.Items.AddRange(New MapOverlayItemBase() {skipIcon, skipCountryItem})
            showCountryOverlay = New MapOverlay() With {.Alignment = ContentAlignment.TopRight, .JoiningOrientation = Orientation.Vertical, .Margin = New Padding(0, 0, 12, 0)}
            Dim showIcon As MapOverlayImageItem = New MapOverlayImageItem() With {.ImageUri = New Uri(DemoUtils.GetRelativePath("Images\FlagsGame\show.png")), .Margin = New Padding(10, 6, 7, 6)}
            showCountryItem = New MapOverlayTextItem() With {.Text = "SHOW COUNTRY", .Alignment = ContentAlignment.TopLeft, .Margin = New Padding(1), .Padding = New Padding(6), .Size = New Size(110, 0)}
            showCountryItem.TextStyle.Font = FontsCollection("nav_button")
            showCountryItem.HotTrackedStyle.Fill = HotTrackedColor
            showCountryOverlay.Items.AddRange(New MapOverlayItemBase() {showIcon, showCountryItem})
        End Sub

        Private Sub CreateGameInfoOverlay()
            infoOverlay = New MapOverlay() With {.Margin = New Padding(0, 12, 0, 0)}
            infoTextItem = New MapOverlayTextItem() With {.TextAlignment = ContentAlignment.MiddleLeft, .Padding = New Padding(20), .Size = New Size(250, 0)}
            infoTextItem.TextStyle.Font = FontsCollection("info")
            infoOverlay.Items.Add(infoTextItem)
        End Sub

        Private Sub ScoreOverMode()
            statisticGameOverlay.Alignment = ContentAlignment.TopCenter
            timeImage.Visible = True
            timeLabel.Visible = True
            timeItem.Visible = True
            scoreImage.Visible = False
            scoreLabel.Visible = False
            scoreItem.Visible = False
        End Sub

        Private Sub ScoreGamingMode()
            statisticGameOverlay.Alignment = ContentAlignment.BottomCenter
            timeImage.Visible = False
            timeLabel.Visible = False
            timeItem.Visible = False
            scoreImage.Visible = True
            scoreLabel.Visible = True
            scoreItem.Visible = True
        End Sub

        Private Sub SetDefaultStyleLevelItems()
            For Each levelPair As KeyValuePair(Of MapOverlayImageItem, MapOverlayTextItem) In levelItems
                ChangeSelectionOverlayItem(levelPair.Value, False)
            Next
        End Sub

        Private Sub ChangeSelectionOverlayItem(ByVal levelItem As MapOverlayTextItem, ByVal isSelect As Boolean)
            If isSelect Then
                Dim key As String = levelItem.Text.ToLower()
                levelDescItem.Text = levelDescriptions(key)
                selectedLevelItem = levelItem
            End If

            levelSelectorItems(levelItem).BackgroundStyle.Fill = If(isSelect, GetLevelColor(), ChooseLevelBackgroundColor)
        End Sub

        Private Sub RecalculateChooseLevelArrangement(ByVal scaleDPI As ScaleHelper, ByVal overlayArrangement As OverlayArrangement())
            Const itemsCount As Integer = 4
            Dim newGameRect As Rectangle = overlayArrangement(0).OverlayLayout
            Dim dY As Integer = scaleDPI.ScaleVertical(LevelBottomPadding)
            overlayArrangement(1).OverlayLayout = Rectangle.FromLTRB(newGameRect.Left, newGameRect.Top + dY, newGameRect.Right, newGameRect.Top + dY + scaleDPI.ScaleVertical(120))
            Dim itemsWidth As Double = overlayArrangement(1).ItemLayouts(itemsCount - 1).Right - overlayArrangement(1).ItemLayouts(0).Left
            Dim itemsOffset As Integer = CInt((newGameRect.Width - itemsWidth) / 2.0)
            For i As Integer = 0 To itemsCount - 1
                Dim iconRect As Rectangle = overlayArrangement(1).ItemLayouts(i)
                iconRect = Rectangle.FromLTRB(iconRect.Left + itemsOffset, iconRect.Top, iconRect.Right + itemsOffset, iconRect.Bottom)
                Dim textRect As Rectangle = Rectangle.FromLTRB(iconRect.Left, iconRect.Top, iconRect.Right, iconRect.Bottom + 25)
                overlayArrangement(1).ItemLayouts(i) = iconRect
                overlayArrangement(1).ItemLayouts(i + itemsCount) = textRect
                overlayArrangement(1).ItemLayouts(i + itemsCount * 2) = Rectangle.FromLTRB(textRect.Left, textRect.Bottom, textRect.Right, textRect.Bottom + 5)
            Next
        End Sub

        Private Sub RecalculateScoreOverArrangement(ByVal overlayArrangement As OverlayArrangement())
            Dim scoreRect As Rectangle = overlayArrangement(0).OverlayLayout
            Dim statisticRect As Rectangle = overlayArrangement(2).OverlayLayout
            overlayArrangement(0).OverlayLayout = Rectangle.FromLTRB(statisticRect.Left, scoreRect.Top, statisticRect.Right, scoreRect.Bottom)
            Dim itemsCount As Integer = overlayArrangement(0).ItemLayouts.Length
            Dim itemsWidth As Double = overlayArrangement(0).ItemLayouts(itemsCount - 1).Right - overlayArrangement(0).ItemLayouts(0).Left
            Dim itemsOffset As Integer = CInt((statisticRect.Width - itemsWidth) / 2.0)
            For i As Integer = 0 To itemsCount - 1
                Dim itemRect As Rectangle = overlayArrangement(0).ItemLayouts(i)
                overlayArrangement(0).ItemLayouts(i) = Rectangle.FromLTRB(itemRect.Left + itemsOffset, itemRect.Top, itemRect.Left + itemsOffset + itemRect.Width, itemRect.Bottom)
            Next
        End Sub

        Private Sub RecalculateInfoArrangement(ByVal overlayArrangement As OverlayArrangement())
            Dim countryRect As Rectangle = overlayArrangement(0).OverlayLayout
            Dim infoRect As Rectangle = overlayArrangement(1).OverlayLayout
            overlayArrangement(1).OverlayLayout = Rectangle.FromLTRB(infoRect.Left, countryRect.Top, infoRect.Right, countryRect.Bottom)
            Dim itemsHeight As Double = overlayArrangement(1).ItemLayouts(0).Height
            Dim itemsOffset As Integer = CInt(((overlayArrangement(0).ItemLayouts(1).Height - itemsHeight) / 2.0))
            Dim itemRect As Rectangle = overlayArrangement(1).ItemLayouts(0)
            overlayArrangement(1).ItemLayouts(0) = Rectangle.FromLTRB(itemRect.Left, itemRect.Top + itemsOffset, itemRect.Right, itemRect.Top + itemsOffset + itemRect.Height)
        End Sub

        Private Function GetLevelColor() As Color
            Dim levelName As String = If(selectedLevelItem IsNot Nothing, selectedLevelItem.Text.ToLower(), String.Empty)
            If Equals(levelName, levelNames(1)) Then Return Color.FromArgb(&H40, &HAB, &H5B)
            If Equals(levelName, levelNames(2)) Then Return Color.FromArgb(&HFF, &HAE, &H00)
            If Equals(levelName, levelNames(3)) Then Return Color.FromArgb(&HFF, &H00, &H00)
            Return Color.FromArgb(&H74, &H9F, &HDF)
        End Function

        Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
            Dim collection As Dictionary(Of String, Font) = New Dictionary(Of String, Font)()
            collection.Add("title", New Font(AppearanceObject.DefaultFont.FontFamily, 23, FontStyle.Bold))
            collection.Add("note", New Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Regular))
            collection.Add("button", New Font(AppearanceObject.DefaultFont.FontFamily, 10, FontStyle.Bold))
            collection.Add("nav_button", New Font(AppearanceObject.DefaultFont.FontFamily, 9, FontStyle.Bold))
            collection.Add("score_over", New Font(AppearanceObject.DefaultFont.FontFamily, 17, FontStyle.Regular))
            collection.Add("default", New Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Regular))
            collection.Add("bold", New Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Bold))
            collection.Add("level", New Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Bold))
            collection.Add("info", New Font(AppearanceObject.DefaultFont.FontFamily, 12, FontStyle.Regular))
            Return collection
        End Function

        Public Sub OverlaysArranged(ByVal scaleDPI As ScaleHelper, ByVal overlayArrangement As OverlayArrangement())
            If newGameOverlay.Visible AndAlso chooseLevelOverlay.Visible AndAlso overlayArrangement.Length >= 2 Then RecalculateChooseLevelArrangement(scaleDPI, overlayArrangement)
            If statisticGameOverlay.Visible AndAlso scoreOverOverlay.Visible AndAlso overlayArrangement.Length >= 3 Then RecalculateScoreOverArrangement(overlayArrangement)
            If countryFlagOverlay.Visible AndAlso infoOverlay.Visible AndAlso overlayArrangement.Length >= 3 Then RecalculateInfoArrangement(overlayArrangement)
        End Sub

        Public Function GetOverlays() As MapOverlay()
            Return New MapOverlay() {newGameOverlay, chooseLevelOverlay, scoreOverOverlay, gameOverOverlay, countryFlagOverlay, infoOverlay, statisticGameOverlay, skipCountryOverlay, showCountryOverlay, restartGameOverlay, finishGameOverlay}
        End Function

        Public Sub HidePanels()
            newGameOverlay.Visible = False
            chooseLevelOverlay.Visible = False
            countryFlagOverlay.Visible = False
            statisticGameOverlay.Visible = False
            scoreOverOverlay.Visible = False
            gameOverOverlay.Visible = False
            skipCountryOverlay.Visible = False
            showCountryOverlay.Visible = False
            restartGameOverlay.Visible = False
            finishGameOverlay.Visible = False
            infoOverlay.Visible = False
        End Sub

        Public Sub ShowGameOverOverlay(ByVal time As String)
            HidePanels()
            ScoreOverMode()
            timeItem.Text = time
            scoreOverItem.Text = scoreItem.Text
            statisticGameOverlay.Visible = True
            scoreOverOverlay.Visible = True
            gameOverOverlay.Visible = True
        End Sub

        Public Sub ShowNewGameOverlay()
            HidePanels()
            newGameOverlay.Visible = True
            chooseLevelOverlay.Visible = True
        End Sub

        Public Sub ShowGameInfoOverlay()
            HidePanels()
            ScoreGamingMode()
            countryFlagOverlay.Visible = True
            statisticGameOverlay.Visible = True
            skipCountryOverlay.Visible = True
            showCountryOverlay.Visible = True
            restartGameOverlay.Visible = True
            finishGameOverlay.Visible = True
            infoOverlay.Visible = True
        End Sub

        Public Sub SetInfoMessage(ByVal text As String)
            infoTextItem.Text = text
        End Sub

        Public Sub SetScore(ByVal score As Double, ByVal wins As Integer, ByVal losses As Integer)
            scoreItem.Text = score.ToString()
            winsItem.Text = wins.ToString()
            lossesItem.Text = losses.ToString()
        End Sub

        Public Sub SetCountry(ByVal flag As Image, ByVal name As String)
            flagItem.Image = flag
            countryName.Text = name
        End Sub

        Public Sub SetCountryNameVisibility(ByVal isVisible As Boolean)
            countryName.Visible = isVisible
        End Sub

        Public Sub SetCountryOperationsVisibility(ByVal isVisible As Boolean)
            skipCountryOverlay.Visible = isVisible
            showCountryOverlay.Visible = isVisible
        End Sub

        Public Sub SelectDefaultLevel()
            SetDefaultStyleLevelItems()
            If levelItems.Count > 0 Then Me.ChangeSelectionOverlayItem(Enumerable.First(Of KeyValuePair(Of Global.DevExpress.XtraMap.MapOverlayImageItem, Global.DevExpress.XtraMap.MapOverlayTextItem))(levelItems).Value, True)
        End Sub

        Public Function GetSelectedLevel() As GameLevel
            Dim levelName As String = If(selectedLevelItem IsNot Nothing, selectedLevelItem.Text.ToLower(), String.Empty)
            If Equals(levelName, levelNames(1)) Then Return GameLevel.Middle
            If Equals(levelName, levelNames(2)) Then Return GameLevel.High
            If Equals(levelName, levelNames(3)) Then Return GameLevel.VeryHigh
            Return GameLevel.Easy
        End Function

        Public Function GetClickedAction(ByVal clickedItem As MapOverlayItemBase) As ClickedAction
            If clickedItem Is skipCountryItem Then Return ClickedAction.SkipCountry
            If clickedItem Is showCountryItem Then Return ClickedAction.ShowCountry
            If clickedItem Is finishGameItem Then Return ClickedAction.FinishGame
            If clickedItem Is startGameItem Then Return ClickedAction.StartGame
            If clickedItem Is restartGameItem OrElse clickedItem Is newGameItem Then Return ClickedAction.NewGame
            Dim levelPair As KeyValuePair(Of MapOverlayImageItem, MapOverlayTextItem) = levelItems.FirstOrDefault(Function(x) x.Value.Equals(clickedItem) OrElse x.Key.Equals(clickedItem))
            If levelPair.Value IsNot Nothing Then
                SetDefaultStyleLevelItems()
                ChangeSelectionOverlayItem(levelPair.Value, True)
                Return ClickedAction.ChangeLevel
            End If

            Return ClickedAction.Unknown
        End Function
    End Class

    Public Enum ClickedAction
        Unknown
        ChangeLevel
        NewGame
        StartGame
        FinishGame
        SkipCountry
        ShowCountry
        Restart
        NotRestart
    End Enum

    Public MustInherit Class TextOverlayManager
        Inherits OverlayManagerBase

        Private overlay As MapOverlay

        Private itemsCountItem As MapOverlayTextItem

        Protected MustOverride ReadOnly Property TextFormat As String

        Public Sub New()
            CreateOverlay()
        End Sub

        Private Sub CreateOverlay()
            itemsCountItem = New MapOverlayTextItem() With {.JoiningOrientation = Orientation.Vertical, .Alignment = ContentAlignment.MiddleRight}
            itemsCountItem.TextStyle.Font = FontsCollection("font")
            overlay = New MapOverlay() With {.Alignment = ContentAlignment.BottomRight, .Margin = New Padding(10, 10, 10, 10)}
            overlay.Items.Add(itemsCountItem)
        End Sub

        Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
            Dim collection As Dictionary(Of String, Font) = New Dictionary(Of String, Font)()
            collection.Add("font", New Font(AppearanceObject.DefaultFont.FontFamily, 14, FontStyle.Regular))
            Return collection
        End Function

        Public Sub UpdateText(ParamArray args As Object())
            itemsCountItem.Text = String.Format(TextFormat, args)
        End Sub

        Public Function GetOverlays() As MapOverlay()
            Return New MapOverlay() {overlay}
        End Function
    End Class

    Public Class PerformanceOverlayManager
        Inherits TextOverlayManager

        Protected Overrides ReadOnly Property TextFormat As String
            Get
                Return "{0} items loaded"
            End Get
        End Property
    End Class

    Public Class ShapeSimplifierOverlayManager
        Inherits TextOverlayManager

        Protected Overrides ReadOnly Property TextFormat As String
            Get
                Return "{0} points, {1:0.000}% tolerance"
            End Get
        End Property
    End Class

    Public Class ItemsMovingOverlayManager
        Inherits OverlayManagerBase

        Private ReadOnly Shared AttributeNames As String() = New String() {"NAME", "CAPITAL"}

        Private ReadOnly finishGameCaptionOverlay As MapOverlay

        Private ReadOnly finishGameOverlay As MapOverlay

        Private ReadOnly countryInfoOverlay As MapOverlay

        Private ReadOnly gameStatsOverlay As MapOverlay

        Private ReadOnly statsItem As MapOverlayTextItem

        Private ReadOnly restartGameItem As MapOverlayTextItem

        Private ReadOnly notRestartGameItem As MapOverlayTextItem

        Private ReadOnly flagsCache As Dictionary(Of String, Image) = New Dictionary(Of String, Image)()

        Public Sub New()
            countryInfoOverlay = New MapOverlay() With {.Alignment = ContentAlignment.BottomRight, .Margin = New Padding(10), .Padding = New Padding(0, 0, 0, 5)}
            gameStatsOverlay = New MapOverlay() With {.Alignment = ContentAlignment.BottomLeft, .Margin = New Padding(10)}
            statsItem = New MapOverlayTextItem() With {.Alignment = ContentAlignment.MiddleCenter}
            statsItem.TextStyle.Font = FontsCollection("font")
            gameStatsOverlay.Items.Add(statsItem)
            finishGameCaptionOverlay = New MapOverlay() With {.Alignment = ContentAlignment.MiddleCenter, .JoiningOrientation = Orientation.Vertical}
            Dim captionItem As MapOverlayTextItem = New MapOverlayTextItem() With {.Text = "Well done! All countries are on their places! Restart game?", .JoiningOrientation = Orientation.Vertical, .Alignment = ContentAlignment.TopCenter, .TextAlignment = ContentAlignment.MiddleCenter}
            captionItem.TextStyle.Font = FontsCollection("finishFont")
            finishGameCaptionOverlay.Items.Add(captionItem)
            finishGameOverlay = New MapOverlay() With {.Alignment = ContentAlignment.MiddleCenter, .JoiningOrientation = Orientation.Vertical}
            restartGameItem = New MapOverlayTextItem() With {.Text = "Yes", .JoiningOrientation = Orientation.Horizontal, .Alignment = ContentAlignment.MiddleCenter, .TextAlignment = ContentAlignment.MiddleCenter}
            restartGameItem.TextStyle.Font = FontsCollection("finishFont")
            restartGameItem.HotTrackedStyle.Fill = Color.FromArgb(&HAF, &H74, &H9F, &HDF)
            notRestartGameItem = New MapOverlayTextItem() With {.Text = "No", .JoiningOrientation = Orientation.Horizontal, .Alignment = ContentAlignment.MiddleCenter, .TextAlignment = ContentAlignment.MiddleCenter}
            notRestartGameItem.TextStyle.Font = FontsCollection("finishFont")
            notRestartGameItem.HotTrackedStyle.Fill = Color.FromArgb(&HAF, &H74, &H9F, &HDF)
            finishGameOverlay.Items.AddRange(New MapOverlayItemBase() {restartGameItem, notRestartGameItem})
            HideGameFinish()
        End Sub

        Private Sub ArrangeFinishOverlays(ByVal overlayArrangements As OverlayArrangement())
            Dim captionLayout As Rectangle = overlayArrangements(2).OverlayLayout
            Dim yesLayout As Rectangle = overlayArrangements(3).ItemLayouts(0)
            Dim noLayout As Rectangle = overlayArrangements(3).ItemLayouts(1)
            Dim newYesLayout As Rectangle = New Rectangle(yesLayout.Left, yesLayout.Top, CInt((captionLayout.Width / 2.0)), yesLayout.Height)
            Dim newNoLayout As Rectangle = New Rectangle(CInt((captionLayout.Width / 2.0)), noLayout.Top, CInt((captionLayout.Width / 2.0)), noLayout.Height)
            overlayArrangements(3).ItemLayouts(0) = newYesLayout
            overlayArrangements(3).ItemLayouts(1) = newNoLayout
            overlayArrangements(3).OverlayLayout = New Rectangle(captionLayout.Left, captionLayout.Bottom, captionLayout.Width, yesLayout.Height)
        End Sub

        Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
            Dim collection As Dictionary(Of String, Font) = New Dictionary(Of String, Font)()
            collection.Add("font", New Font(AppearanceObject.DefaultFont.FontFamily, 16, FontStyle.Regular))
            collection.Add("finishFont", New Font(AppearanceObject.DefaultFont.FontFamily, 24, FontStyle.Regular))
            Return collection
        End Function

        Public Sub UpdateText(ByVal attributes As MapItemAttributeCollection)
            countryInfoOverlay.Items.BeginUpdate()
            Try
                countryInfoOverlay.Items.Clear()
                Dim flagItem As MapOverlayImageItem = New MapOverlayImageItem() With {.JoiningOrientation = Orientation.Vertical, .Alignment = ContentAlignment.MiddleCenter, .Image = DemoUtils.GetCountryFlag(flagsCache, attributes("NAME_LONG").Value.ToString()), .Padding = New Padding(10)}
                countryInfoOverlay.Items.Add(flagItem)
                For Each attributeName As String In AttributeNames
                    Dim textItem As MapOverlayTextItem = New MapOverlayTextItem() With {.JoiningOrientation = Orientation.Vertical, .Alignment = ContentAlignment.MiddleCenter, .Padding = New Padding(5, 0, 5, 0)}
                    textItem.TextStyle.Font = FontsCollection("font")
                    textItem.Text = attributeName(0) & attributeName.Substring(1).ToLower() & ": " & attributes(attributeName).Value.ToString()
                    countryInfoOverlay.Items.Add(textItem)
                Next
            Finally
                countryInfoOverlay.Items.EndUpdate()
            End Try
        End Sub

        Public Sub HideText()
            countryInfoOverlay.Items.Clear()
        End Sub

        Public Function GetOverlays() As MapOverlay()
            Return New MapOverlay() {countryInfoOverlay, gameStatsOverlay, finishGameCaptionOverlay, finishGameOverlay}
        End Function

        Public Sub UpdateGameStats(ByVal solvedCountries As Integer, ByVal totalCountries As Integer)
            statsItem.Text = String.Format("Countries solved: {0} out of {1}", solvedCountries, totalCountries)
        End Sub

        Public Sub HideGameFinish()
            finishGameCaptionOverlay.Visible = False
            finishGameOverlay.Visible = False
        End Sub

        Public Sub ShowGameFinish()
            finishGameCaptionOverlay.Visible = True
            finishGameOverlay.Visible = True
        End Sub

        Public Function GetClickedAction(ByVal clickedItem As MapOverlayItemBase) As ClickedAction
            If clickedItem Is restartGameItem Then Return ClickedAction.Restart
            If clickedItem Is notRestartGameItem Then Return ClickedAction.NotRestart
            Return ClickedAction.Unknown
        End Function

        Public Sub ArrangeOverlays(ByVal overlayArrangements As OverlayArrangement())
            If finishGameCaptionOverlay.Visible Then ArrangeFinishOverlays(overlayArrangements)
        End Sub
    End Class

    Public Class MapEditorOverlayManager
        Inherits OverlayManagerBase

        Const padding As Integer = 8

        Private fillEditLocationField As Point = Point.Empty

        Private strokeEditLocationField As Point = Point.Empty

        Public ReadOnly Property FillEditLocation As Point
            Get
                Return fillEditLocationField
            End Get
        End Property

        Public ReadOnly Property StrokeEditLocation As Point
            Get
                Return strokeEditLocationField
            End Get
        End Property

        Protected Overrides Function CreateFonts() As Dictionary(Of String, Font)
            Return New Dictionary(Of String, Font)()
        End Function

        Public Sub ArrangeOverlays(ByVal scaleDPI As ScaleHelper, ByVal arrangements As OverlayArrangement(), ByVal colorPickerSize As Size)
            Dim panelRect As Rectangle = arrangements(0).OverlayLayout
            Dim rulerRect As Rectangle = arrangements(1).OverlayLayout
            Dim fillRect As Rectangle = arrangements(2).OverlayLayout
            Dim strokeRect As Rectangle = arrangements(3).OverlayLayout
            arrangements(2).OverlayLayout = New Rectangle(New Point(rulerRect.Location.X, fillRect.Location.Y), New Size(fillRect.Width + colorPickerSize.Width, panelRect.Height))
            Dim colorPickTop As Integer = panelRect.Top + (panelRect.Height - colorPickerSize.Height) \ 2
            fillEditLocationField = New Point(rulerRect.Location.X + fillRect.Width, colorPickTop)
            Dim strokeLayoutStart As Integer = arrangements(2).OverlayLayout.Right
            arrangements(3).OverlayLayout = New Rectangle(strokeLayoutStart, strokeRect.Top, strokeRect.Width + colorPickerSize.Width, panelRect.Height)
            strokeEditLocationField = New Point(strokeLayoutStart + strokeRect.Width, colorPickTop)
            arrangements(1).OverlayLayout = New Rectangle(New Point(panelRect.Left, panelRect.Bottom + scaleDPI.ScaleVertical(padding)), rulerRect.Size)
        End Sub
    End Class
End Namespace
