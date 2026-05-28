Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Demos.FlagsGameCore

Namespace DevExpress.XtraMap.Demos

    Public Partial Class MapOverlays
        Inherits MapTutorialControl

        Const SelectMessage As String = "Find the country whose flag is given on the left."

        Const WrongSelectMessage As String = "If your answer is correct, you will win points; otherwise, you will lose them."

        Const ForWinMessage As String = "Right answers are the key to success."

        Const ForEndGame As String = "To finish the game, either find all 177 countries or click the Finish Game button."

        Const AnswerAttributeName As String = "Answer"

        Private ReadOnly levelNames As String() = New String() {"easy", "normal", "hard", "very hard"}

        Private gameCore As FlagsGameCore

        Private overlayManagerField As FlagsGameOverlayManager

        Private consecutiveWins As Integer

        Private ReadOnly Property OverlayManager As FlagsGameOverlayManager
            Get
                If overlayManagerField Is Nothing Then overlayManagerField = CreateOverlayManager()
                Return overlayManagerField
            End Get
        End Property

        Protected Overrides ReadOnly Property Overlays As MapOverlay()
            Get
                Return OverlayManager.GetOverlays()
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ShapefileDataAdapter.FileUri = DemoUtils.GetFileUri("Countries.shp")
        End Sub

        Private Function CreateLevelDescriptions() As Dictionary(Of String, String)
            Dim result As Dictionary(Of String, String) = New Dictionary(Of String, String)()
            result.Add(levelNames(0), "Country flags and names are shown. An incorrectly selected country is not skipped. The Show Country button is hidden.")
            result.Add(levelNames(1), "Country flags and names are shown. An incorrectly selected country is skipped. The Show Country button is hidden.")
            result.Add(levelNames(2), "Only country flags are shown. An incorrectly selected country is skipped. The Show Country button is hidden.")
            result.Add(levelNames(3), "Only country flags are shown. Country titles are not shown on the map. An incorrectly selected country is skipped. The Show Country button is hidden.")
            Return result
        End Function

        Private Sub ShapeItemsLoaded(ByVal sender As Object, ByVal e As ItemsLoadedEventArgs)
            Dim countriesNames As List(Of String) = New List(Of String)()
            For Each item As MapItem In e.Items
                Dim countryName As String = GetCountryNameFromItem(item)
                If Not String.IsNullOrEmpty(countryName) Then countriesNames.Add(countryName)
            Next

            CreateGameCore(countriesNames)
        End Sub

        Private Sub LayerDataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            MapInteractiveEnabling(False)
            OverlayManager.ShowNewGameOverlay()
        End Sub

        Private Sub OnMapControlOverlaysArranged(ByVal sender As Object, ByVal e As OverlaysArrangedEventArgs)
            OverlayManager.OverlaysArranged(ScaleDPI, e.OverlayArrangements)
        End Sub

        Private Function CreateOverlayManager() As FlagsGameOverlayManager
            Dim manager As FlagsGameOverlayManager = New FlagsGameOverlayManager(levelNames, CreateLevelDescriptions())
            manager.SelectDefaultLevel()
            Return manager
        End Function

        Private Sub CreateGameCore(ByVal countriesNames As List(Of String))
            gameCore = New FlagsGameCore(countriesNames)
            AddHandler gameCore.ScoreChanged, AddressOf GameCoreScoreChanged
            AddHandler gameCore.CountryChanged, AddressOf GameCoreCountryChanged
            AddHandler gameCore.ChoiceAnswer, AddressOf GameCoreChoiseAnswer
            AddHandler gameCore.GameOver, AddressOf GameCoreGameOver
        End Sub

        Private Sub SetLevelSettings(ByVal level As GameLevel)
            OverlayManager.SetCountryOperationsVisibility(level = GameLevel.Easy)
            OverlayManager.SetCountryNameVisibility(level = GameLevel.Easy OrElse level = GameLevel.Middle)
            FileLayer.ShapeTitlesVisibility = If(level <> GameLevel.VeryHigh, VisibilityMode.Auto, VisibilityMode.Hidden)
        End Sub

        Private Sub GameInit(ByVal level As GameLevel)
            gameCore.StartGame(level)
            OverlayManager.ShowGameInfoOverlay()
            OverlayManager.SetInfoMessage(SelectMessage)
            ResetCountriesSelections(True)
            MapInteractiveEnabling(True)
            SetLevelSettings(level)
            MapControl.CenterPoint = New GeoPoint(33, 0)
            MapControl.ZoomLevel = 2.0
            consecutiveWins = 0
        End Sub

        Private Sub ResetCountriesSelections(ByVal isAll As Boolean)
            For Each item As MapItem In FileLayer.Data.Items
                Dim answerAttribute As MapItemAttribute = item.Attributes(AnswerAttributeName)
                If answerAttribute IsNot Nothing AndAlso (answerAttribute.Value.Equals("Try") OrElse isAll) Then item.Attributes.Remove(answerAttribute)
            Next
        End Sub

        Private Sub SetCountryTrySelection(ByVal item As MapItem)
            Dim answerAttribute As MapItemAttribute = item.Attributes(AnswerAttributeName)
            If answerAttribute IsNot Nothing Then Return
            item.Attributes.Add(New MapItemAttribute() With {.Name = AnswerAttributeName, .Value = "Try"})
        End Sub

        Private Sub MapInteractiveEnabling(ByVal isEnabled As Boolean)
            FileLayer.EnableSelection = isEnabled
            FileLayer.EnableHighlighting = isEnabled
            MapControl.EnableScrolling = isEnabled
            MapControl.EnableZooming = isEnabled
            If Not isEnabled Then FileLayer.ShapeTitlesVisibility = VisibilityMode.Hidden
            If isEnabled Then
                AddHandler MapControl.MapItemClick, AddressOf OnMapItemClick
            Else
                RemoveHandler MapControl.MapItemClick, AddressOf OnMapItemClick
            End If
        End Sub

        Private Sub SetItemChoiseResult(ByVal item As MapItem, ByVal status As AnswerStatus)
            Select Case status
                Case AnswerStatus.Win
                    item.Attributes.Add(New MapItemAttribute() With {.Name = AnswerAttributeName, .Value = "Right"})
                    ResetCountriesSelections(False)
                    consecutiveWins += 1
                    OverlayManager.SetInfoMessage(If(consecutiveWins >= 3, ForEndGame, ForWinMessage))
                Case AnswerStatus.Lose
                    item.Attributes.Add(New MapItemAttribute() With {.Name = AnswerAttributeName, .Value = "Wrong"})
                    ResetCountriesSelections(False)
                    consecutiveWins = 0
                    OverlayManager.SetInfoMessage(WrongSelectMessage)
                Case AnswerStatus.WrongTry
                    SetCountryTrySelection(item)
                    consecutiveWins = 0
                Case AnswerStatus.ShowCountry
                    MapControl.ZoomToFit(New List(Of MapItem)() From {item})
            End Select
        End Sub

        Private Function GetCountryItem(ByVal countryName As String) As MapItem
            For Each item As MapItem In FileLayer.Data.Items
                If Equals(GetCountryNameFromItem(item), countryName) Then Return item
            Next

            Return Nothing
        End Function

        Private Function GetCountryNameFromItem(ByVal item As MapItem) As String
            Return If(item.Attributes("ADMIN") Is Nothing OrElse item.Attributes("ADMIN").Value Is Nothing, String.Empty, item.Attributes("ADMIN").Value.ToString())
        End Function

        Private Sub GameCoreScoreChanged(ByVal sender As Object, ByVal e As ScoreChangedAnswerEventArgs)
            OverlayManager.SetScore(e.Score, e.Wins, e.Losses)
        End Sub

        Private Sub GameCoreCountryChanged(ByVal sender As Object, ByVal e As CountryDataEventArgs)
            OverlayManager.SetCountry(e.Flag, e.Name)
        End Sub

        Private Sub GameCoreChoiseAnswer(ByVal sender As Object, ByVal e As ChoiceAnswerEventArgs)
            Dim countryItem As MapItem = GetCountryItem(e.CountryName)
            If countryItem IsNot Nothing Then SetItemChoiseResult(countryItem, e.Status)
        End Sub

        Private Sub GameCoreGameOver(ByVal sender As Object, ByVal e As GameOverEventArgs)
            MapInteractiveEnabling(False)
            OverlayManager.ShowGameOverOverlay(e.Time)
        End Sub

        Private Sub OnMapItemClick(ByVal sender As Object, ByVal e As MapItemClickEventArgs)
            Dim selectedCountryName As String = GetCountryNameFromItem(e.Item)
            gameCore.TrySelectionCountry(selectedCountryName)
            FileLayer.SelectedItems.Clear()
        End Sub

        Private Sub OnMapControlMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button <> MouseButtons.Left Then Return
            Dim hitInfo As MapHitInfo = MapControl.CalcHitInfo(e.Location)
            Dim clickedItem As MapOverlayItemBase = GetClickedOverlayItem(hitInfo)
            If clickedItem Is Nothing Then Return
            Dim action As ClickedAction = OverlayManager.GetClickedAction(clickedItem)
            Select Case action
                Case ClickedAction.NewGame
                    MapInteractiveEnabling(False)
                    OverlayManager.ShowNewGameOverlay()
                Case ClickedAction.StartGame
                    GameInit(OverlayManager.GetSelectedLevel())
                Case ClickedAction.FinishGame
                    gameCore.FinishGame()
                Case ClickedAction.ShowCountry
                    gameCore.ShowCountry()
                Case ClickedAction.SkipCountry
                    gameCore.SkipCountry()
            End Select
        End Sub

        Private Sub OnDispose()
            If overlayManagerField IsNot Nothing Then
                overlayManagerField.Dispose()
                overlayManagerField = Nothing
            End If

            If gameCore IsNot Nothing Then
                gameCore.Dispose()
                gameCore = Nothing
            End If
        End Sub

        Protected Overrides Sub InitRibbon()
            MyBase.InitRibbon()
            ChkShowMinimap.Enabled = False
        End Sub
    End Class
End Namespace
