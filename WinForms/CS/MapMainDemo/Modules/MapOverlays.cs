using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Demos.FlagsGameCore;

namespace DevExpress.XtraMap.Demos {
    public partial class MapOverlays : MapTutorialControl {
        const string SelectMessage = "Find the country whose flag is given on the left.";
        const string WrongSelectMessage = "If your answer is correct, you will win points; otherwise, you will lose them.";
        const string ForWinMessage = "Right answers are the key to success.";
        const string ForEndGame = "To finish the game, either find all 177 countries or click the Finish Game button.";
        const string AnswerAttributeName = "Answer";
        readonly string[] levelNames = new string[] { "easy", "normal", "hard", "very hard" };

        FlagsGameCore gameCore;
        FlagsGameOverlayManager overlayManager;
        int consecutiveWins;

        FlagsGameOverlayManager OverlayManager {
            get {
                if(overlayManager == null)
                    overlayManager = CreateOverlayManager();
                return overlayManager;
            }
        }

        protected override MapOverlay[] Overlays { get { return OverlayManager.GetOverlays(); } }
        public override MapControl MapControl { get { return mapControl1; } }

        public MapOverlays() {
            InitializeComponent();
            ShapefileDataAdapter.FileUri = DemoUtils.GetFileUri("Countries.shp");
        }

        Dictionary<string, string> CreateLevelDescriptions() {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add(levelNames[0], "Country flags and names are shown. An incorrectly selected country is not skipped. The Show Country button is hidden.");
            result.Add(levelNames[1], "Country flags and names are shown. An incorrectly selected country is skipped. The Show Country button is hidden.");
            result.Add(levelNames[2], "Only country flags are shown. An incorrectly selected country is skipped. The Show Country button is hidden.");
            result.Add(levelNames[3], "Only country flags are shown. Country titles are not shown on the map. An incorrectly selected country is skipped. The Show Country button is hidden.");
            return result;
        }
        void ShapeItemsLoaded(object sender, ItemsLoadedEventArgs e) {
            List<string> countriesNames = new List<string>();
            foreach(MapItem item in e.Items) {
                string countryName = GetCountryNameFromItem(item);
                if(!String.IsNullOrEmpty(countryName))
                    countriesNames.Add(countryName);
            }
            CreateGameCore(countriesNames);
        }
        void LayerDataLoaded(object sender, DataLoadedEventArgs e) {
            MapInteractiveEnabling(false);
            OverlayManager.ShowNewGameOverlay();
        }
        void OnMapControlOverlaysArranged(object sender, OverlaysArrangedEventArgs e) {
            OverlayManager.OverlaysArranged(ScaleDPI, e.OverlayArrangements);
        }

        FlagsGameOverlayManager CreateOverlayManager() {
            FlagsGameOverlayManager manager = new FlagsGameOverlayManager(levelNames, CreateLevelDescriptions());
            manager.SelectDefaultLevel();
            return manager;
        }
        void CreateGameCore(List<string> countriesNames) {
            gameCore = new FlagsGameCore(countriesNames);
            gameCore.ScoreChanged += GameCoreScoreChanged;
            gameCore.CountryChanged += GameCoreCountryChanged;
            gameCore.ChoiceAnswer += GameCoreChoiseAnswer;
            gameCore.GameOver += GameCoreGameOver;
        }
        void SetLevelSettings(GameLevel level) {
            OverlayManager.SetCountryOperationsVisibility(level == GameLevel.Easy);
            OverlayManager.SetCountryNameVisibility(level == GameLevel.Easy || level == GameLevel.Middle);
            FileLayer.ShapeTitlesVisibility = level != GameLevel.VeryHigh ? VisibilityMode.Auto : VisibilityMode.Hidden;
        }
        void GameInit(GameLevel level) {
            gameCore.StartGame(level);
            OverlayManager.ShowGameInfoOverlay();
            OverlayManager.SetInfoMessage(SelectMessage);
            ResetCountriesSelections(true);
            MapInteractiveEnabling(true);
            SetLevelSettings(level);
            MapControl.CenterPoint = new GeoPoint(33, 0);
            MapControl.ZoomLevel = 2.0;
            consecutiveWins = 0;
        }
        void ResetCountriesSelections(bool isAll) {
            foreach(MapItem item in FileLayer.Data.Items) {
                MapItemAttribute answerAttribute = item.Attributes[AnswerAttributeName];
                if(answerAttribute != null && (answerAttribute.Value.Equals("Try") || isAll))
                    item.Attributes.Remove(answerAttribute);
            }
        }
        void SetCountryTrySelection(MapItem item) {
            MapItemAttribute answerAttribute = item.Attributes[AnswerAttributeName];
            if(answerAttribute != null)
                return;
            item.Attributes.Add(new MapItemAttribute() { Name = AnswerAttributeName, Value = "Try" });
        }
        void MapInteractiveEnabling(bool isEnabled) {
            FileLayer.EnableSelection = isEnabled;
            FileLayer.EnableHighlighting = isEnabled;
            MapControl.EnableScrolling = isEnabled;
            MapControl.EnableZooming = isEnabled;
            if(!isEnabled)
                FileLayer.ShapeTitlesVisibility = VisibilityMode.Hidden;
            if(isEnabled)
                MapControl.MapItemClick += OnMapItemClick;
            else
                MapControl.MapItemClick -= OnMapItemClick;
        }
        void SetItemChoiseResult(MapItem item, AnswerStatus status) {
            switch(status) {
                case AnswerStatus.Win:
                    item.Attributes.Add(new MapItemAttribute() { Name = AnswerAttributeName, Value = "Right" });
                    ResetCountriesSelections(false);
                    consecutiveWins++;
                    OverlayManager.SetInfoMessage(consecutiveWins >= 3 ? ForEndGame : ForWinMessage);
                    break;
                case AnswerStatus.Lose:
                    item.Attributes.Add(new MapItemAttribute() { Name = AnswerAttributeName, Value = "Wrong" });
                    ResetCountriesSelections(false);
                    consecutiveWins = 0;
                    OverlayManager.SetInfoMessage(WrongSelectMessage);
                    break;
                case AnswerStatus.WrongTry:
                    SetCountryTrySelection(item);
                    consecutiveWins = 0;
                    break;
                case AnswerStatus.ShowCountry:
                    MapControl.ZoomToFit(new List<MapItem>() { item });
                    break;
            }
        }
        MapItem GetCountryItem(string countryName) {
            foreach(MapItem item in FileLayer.Data.Items)
                if(GetCountryNameFromItem(item) == countryName)
                    return item;
            return null;
        }
        string GetCountryNameFromItem(MapItem item) {
            return item.Attributes["ADMIN"] == null || item.Attributes["ADMIN"].Value == null ? string.Empty : item.Attributes["ADMIN"].Value.ToString();
        }
        void GameCoreScoreChanged(object sender, ScoreChangedAnswerEventArgs e) {
            OverlayManager.SetScore(e.Score, e.Wins, e.Losses);
        }
        void GameCoreCountryChanged(object sender, CountryDataEventArgs e) {
            OverlayManager.SetCountry(e.Flag, e.Name);
        }
        void GameCoreChoiseAnswer(object sender, ChoiceAnswerEventArgs e) {
            MapItem countryItem = GetCountryItem(e.CountryName);
            if(countryItem != null)
                SetItemChoiseResult(countryItem, e.Status);
        }
        void GameCoreGameOver(object sender, GameOverEventArgs e) {
            MapInteractiveEnabling(false);
            OverlayManager.ShowGameOverOverlay(e.Time);
        }
        void OnMapItemClick(object sender, MapItemClickEventArgs e) {
            string selectedCountryName = GetCountryNameFromItem(e.Item);
            gameCore.TrySelectionCountry(selectedCountryName);
            FileLayer.SelectedItems.Clear();
        }
        void OnMapControlMouseUp(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left)
                return;
            MapHitInfo hitInfo = MapControl.CalcHitInfo(e.Location);
            MapOverlayItemBase clickedItem = OverlayUtils.GetClickedOverlayItem(hitInfo);
            if(clickedItem == null)
                return;
            ClickedAction action = OverlayManager.GetClickedAction(clickedItem);
            switch(action) {
                case ClickedAction.NewGame:
                    MapInteractiveEnabling(false);
                    OverlayManager.ShowNewGameOverlay();
                    break;
                case ClickedAction.StartGame:
                    GameInit(OverlayManager.GetSelectedLevel());
                    break;
                case ClickedAction.FinishGame:
                    gameCore.FinishGame();
                    break;
                case ClickedAction.ShowCountry:
                    gameCore.ShowCountry();
                    break;
                case ClickedAction.SkipCountry:
                    gameCore.SkipCountry();
                    break;
            }
        }
        void OnDispose() {
            if(overlayManager != null) {
                overlayManager.Dispose();
                overlayManager = null;
            }
            if(gameCore != null) {
                gameCore.Dispose();
                gameCore = null;
            }
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            ChkShowMinimap.Enabled = false;
        }
    }
}
