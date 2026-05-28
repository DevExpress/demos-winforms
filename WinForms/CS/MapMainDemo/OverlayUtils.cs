using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Demos.FlagsGameCore;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.DPI;

namespace DevExpress.XtraMap.Demos {
    public static class OverlayUtils {
        public static MapOverlayItemBase GetClickedOverlayItem(MapHitInfo hitInfo) {
            if(hitInfo.InUIElement) {
                MapOverlayHitInfo overlayHitInfo = hitInfo.UiHitInfo as MapOverlayHitInfo;
                if(overlayHitInfo != null)
                    return overlayHitInfo.OverlayItem;
            }
            return null;
        }
    }
    public abstract class OverlayManagerBase : IDisposable {
        readonly Dictionary<string, Font> fontsCollection;

        protected Dictionary<string, Font> FontsCollection { get { return fontsCollection; } }

        protected OverlayManagerBase() {
            fontsCollection = CreateFonts();
        }

        protected abstract Dictionary<string, Font> CreateFonts();

        #region IDisposable implementation
        protected virtual void Dispose(bool disposing) {
            if(disposing) {
                IEnumerable<string> keysCollection = new List<string>(fontsCollection.Keys);
                foreach(string key in keysCollection) {
                    if(fontsCollection[key] != null) {
                        fontsCollection[key].Dispose();
                        fontsCollection[key] = null;
                    }
                }
            }
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~OverlayManagerBase() {
            Dispose(false);
        }
        #endregion
    }

    public class HotelPlansOverlayManager : OverlayManagerBase {
        MapOverlay overlay;
        MapOverlayImageItem backImage;
        MapOverlayTextItem hotelName;

        public MapOverlay Overlay { get { return overlay; } }
        public MapOverlayImageItem BackImage { get { return backImage; } }
        public MapOverlayTextItem HotelName { get { return hotelName; } }

        public HotelPlansOverlayManager() {
            CreateOverlay();
        }

        void CreateOverlay() {
            backImage = new MapOverlayImageItem() { Padding = new Padding(5), ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\BackButton.png")) };
            hotelName = new MapOverlayTextItem() { Padding = new Padding(15) };
            hotelName.TextStyle.Font = FontsCollection["back_text"];
            overlay = new MapOverlay() { Alignment = ContentAlignment.TopLeft, Margin = new Padding(10, 10, 0, 0) };
            overlay.BackgroundStyle.Fill = Color.Transparent;
            overlay.Items.AddRange(new MapOverlayItemBase[] { backImage, hotelName });
        }

        protected override Dictionary<string, Font> CreateFonts() {
            Dictionary<string, Font> collection = new Dictionary<string, Font>();
            collection.Add("back_text", new Font(AppearanceObject.DefaultFont.FontFamily, 20, FontStyle.Bold));
            return collection;
        }

        public MapOverlay[] GetOverlays() {
            return new MapOverlay[] { overlay };
        }
    }

    public class MapDemoOverlayManager : OverlayManagerBase {
        MapOverlay overlay;
        MapOverlayTextItem messageItem;

        public MapOverlay Overlay { get { return overlay; } }
        public MapOverlayTextItem MessageItem { get { return messageItem; } }

        public MapDemoOverlayManager() {
            CreateOverlay();
        }

        void CreateOverlay() {
            messageItem = new MapOverlayTextItem() { Padding = new Padding(15, 10, 15, 10), Text = "Click the map or use Search to find a location." };
            messageItem.TextStyle.Font = FontsCollection["message"];
            overlay = new MapOverlay() { Alignment = ContentAlignment.TopLeft, Margin = new Padding(8, 8, 0, 0) };
            overlay.Items.Add(messageItem);
        }

        protected override Dictionary<string, Font> CreateFonts() {
            Dictionary<string, Font> collection = new Dictionary<string, Font>();
            collection.Add("message", new Font(AppearanceObject.DefaultFont.FontFamily, 20, FontStyle.Regular));
            return collection;
        }

        public MapOverlay[] GetOverlays() {
            return new MapOverlay[] { overlay };
        }
    }

    public class PhotoGalleryOverlayManager : OverlayManagerBase {
        MapOverlay backIconOverlay;
        MapOverlay placeOverlay;
        MapOverlay navigationOverlay;
        MapOverlay descriptionOverlay;
        Image leftArrow;
        Image rightArrow;

        public MapOverlay BackIconOverlay { get { return backIconOverlay; } }
        public MapOverlay PlaceOverlay { get { return placeOverlay; } }
        public MapOverlay NavigationOverlay { get { return navigationOverlay; } }
        public MapOverlay DescriptionOverlay { get { return descriptionOverlay; } }

        public MapOverlayImageItem BackIcon { get { return (MapOverlayImageItem)backIconOverlay.Items[0]; } }
        public MapOverlayTextItem CityName { get { return (MapOverlayTextItem)placeOverlay.Items[0]; } }
        public MapOverlayImageItem PlaceImage { get { return (MapOverlayImageItem)placeOverlay.Items[1]; } }
        public MapOverlayImageItem PlacePrevImage { get { return (MapOverlayImageItem)navigationOverlay.Items[0]; } }
        public MapOverlayImageItem PlaceNextImage { get { return (MapOverlayImageItem)navigationOverlay.Items[2]; } }
        public MapOverlayTextItem PlaceName { get { return (MapOverlayTextItem)navigationOverlay.Items[1]; } }
        public MapOverlayTextItem PlaceDescription { get { return (MapOverlayTextItem)descriptionOverlay.Items[0]; } }

        public PhotoGalleryOverlayManager() {
            leftArrow = Image.FromFile(DemoUtils.GetRelativePath("Images\\PhotoGallery\\PrevPlace.png"));
            rightArrow = Image.FromFile(DemoUtils.GetRelativePath("Images\\PhotoGallery\\NextPlace.png"));
            CreateOverlays();
        }

        void CreateGalleryBackIconOverlay() {
            backIconOverlay = new MapOverlay() { Alignment = ContentAlignment.TopLeft, Margin = new Padding(10, 10, 0, 0), Padding = new Padding(5) };
            backIconOverlay.BackgroundStyle.Fill = Color.Transparent;
            MapOverlayImageItem imageItem = new MapOverlayImageItem() { ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\BackButton.png")) };
            backIconOverlay.Items.Add(imageItem);
        }
        void CreateGalleryPlaceOverlay() {
            placeOverlay = new MapOverlay() { Alignment = ContentAlignment.TopRight, Margin = new Padding(0, 10, 10, 0) };
            MapOverlayImageItem imageItem = new MapOverlayImageItem() { Alignment = ContentAlignment.TopCenter, JoiningOrientation = Orientation.Vertical, Padding = new Padding(20, 10, 20, 10) };
            MapOverlayTextItem cityNameItem = new MapOverlayTextItem() { Alignment = ContentAlignment.TopCenter, JoiningOrientation = Orientation.Vertical, Padding = new Padding(0, 10, 0, 0) };
            cityNameItem.TextStyle.Font = FontsCollection["city"];
            placeOverlay.Items.AddRange(new MapOverlayItemBase[] { cityNameItem, imageItem });
        }
        void CreateGalleryNavigationOverlay() {
            navigationOverlay = new MapOverlay() { Alignment = ContentAlignment.TopRight, JoiningOrientation = Orientation.Vertical, Margin = new Padding(0, 0, 10, 0), Padding = new Padding(10) };
            MapOverlayImageItem prevPlaceItem = new MapOverlayImageItem() { Alignment = ContentAlignment.TopLeft };
            MapOverlayTextItem placeNameItem = new MapOverlayTextItem() { Alignment = ContentAlignment.TopLeft, TextAlignment = ContentAlignment.MiddleCenter, Size = new Size(242, 0), Padding = new Padding(10, 0, 10, 0) };
            MapOverlayImageItem nextPlaceItem = new MapOverlayImageItem() { Alignment = ContentAlignment.TopLeft };
            placeNameItem.TextStyle.Font = FontsCollection["place"];
            navigationOverlay.Items.AddRange(new MapOverlayItemBase[] { prevPlaceItem, placeNameItem, nextPlaceItem });
        }
        void CreateGalleryDescriptionOverlay() {
            descriptionOverlay = new MapOverlay() { Alignment = ContentAlignment.TopRight, JoiningOrientation = Orientation.Vertical, Margin = new Padding(0, 10, 10, 0) };
            MapOverlayTextItem descriptionItem = new MapOverlayTextItem() { Alignment = ContentAlignment.BottomCenter, Padding = new Padding(10, 0, 10, 0), Size = new Size(300, 0) };
            descriptionItem.TextStyle.Font = FontsCollection["desc"];
            descriptionOverlay.Items.Add(descriptionItem);
        }
        void CreateOverlays() {
            CreateGalleryBackIconOverlay();
            CreateGalleryPlaceOverlay();
            CreateGalleryNavigationOverlay();
            CreateGalleryDescriptionOverlay();
        }

        protected override Dictionary<string, Font> CreateFonts() {
            Dictionary<string, Font> collection = new Dictionary<string, Font>();
            collection.Add("city", new Font(AppearanceObject.DefaultFont.FontFamily, 12, FontStyle.Bold));
            collection.Add("place", new Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Bold));
            collection.Add("desc", new Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Regular));
            return collection;
        }
        protected override void Dispose(bool disposing) {
            if(leftArrow != null) {
                leftArrow.Dispose();
                leftArrow = null;
            }
            if(rightArrow != null) {
                rightArrow.Dispose();
                rightArrow = null;
            }
            base.Dispose(disposing);
        }

        public MapOverlay[] GetOverlays() {
            return new MapOverlay[] { backIconOverlay, placeOverlay, navigationOverlay, descriptionOverlay };
        }
        public void UpdateImages(UserLookAndFeel lookAndFeel) {
            ColorHelper.UpdateColor(leftArrow, lookAndFeel);
            ColorHelper.UpdateColor(rightArrow, lookAndFeel);
            PlacePrevImage.Image = null;
            PlacePrevImage.Image = leftArrow;
            PlaceNextImage.Image = null;
            PlaceNextImage.Image = rightArrow;
        }
    }

    public class MapElementsOverlayManager : OverlayManagerBase {
        readonly MapControl mapControl;
        readonly Dictionary<string, string> airportItemsNames;
        readonly Dictionary<string, bool> spacingMask;
        readonly Dictionary<string, string> planeItemsNames;
        MapOverlay imageOverlay;
        MapOverlay infoOverlay;
        MapOverlay titleOverlay;
        MapOverlay airportInfoOverlay;
        MapOverlayImageItem imageItem;
        readonly List<string> keys = new List<string>() { "name", "id", "from", "to", "current_time", "flight_time", "speed", "altitude" };
        readonly List<string> ap_keys = new List<string>() { "ap_name", "ap_iata", "ap_city", "ap_country", "ap_latitude", "ap_longitude" };
        readonly Dictionary<string, MapOverlayTextItem> planeTextItems;
        readonly Dictionary<string, MapOverlayTextItem> airportTextItems;

        public MapControl Map { get { return mapControl; } }

        public MapElementsOverlayManager(MapControl mapControl) {
            planeTextItems = new Dictionary<string, MapOverlayTextItem>();
            airportTextItems = new Dictionary<string, MapOverlayTextItem>();
            this.mapControl = mapControl;
            planeItemsNames = CreatePlaneFields();
            airportItemsNames = CreateAirportFields();
            spacingMask = CreateSpacingMask();
            CreateOverlays();
            SetOverlaysVisibility(false, false);
        }

        Dictionary<string, string> CreatePlaneFields() {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add(keys[0], "Name");
            result.Add(keys[1], "Flight number");
            result.Add(keys[2], "From");
            result.Add(keys[3], "To");
            result.Add(keys[4], "Current time");
            result.Add(keys[5], "Flight time");
            result.Add(keys[6], "Speed");
            result.Add(keys[7], "Altitude");
            return result;
        }
        Dictionary<string, string> CreateAirportFields() {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add(ap_keys[0], "Name:");
            result.Add(ap_keys[1], "IATA:");
            result.Add(ap_keys[2], "City:");
            result.Add(ap_keys[3], "Country:");
            result.Add(ap_keys[4], "Latitude:");
            result.Add(ap_keys[5], "Longitude:");
            return result;
        }
        Dictionary<string, bool> CreateSpacingMask() {
            Dictionary<string, bool> result = new Dictionary<string, bool>();
            result.Add(keys[0], true);
            result.Add(keys[1], false);
            result.Add(keys[2], false);
            result.Add(keys[3], true);
            result.Add(keys[4], false);
            result.Add(keys[5], true);
            result.Add(keys[6], false);
            result.Add(keys[7], false);
            return result;
        }
        void CreateImageOverlay() {
            imageOverlay = new MapOverlay() { Alignment = ContentAlignment.TopRight, Margin = new Padding(0, 10, 10, 0), Padding = new Padding(10) };
            imageItem = new MapOverlayImageItem();
            imageOverlay.Items.Add(imageItem);
        }
        void CreatePlaneInfoOverlay() {
            infoOverlay = new MapOverlay() { Alignment = ContentAlignment.TopRight, JoiningOrientation = Orientation.Vertical, Margin = new Padding(0, 0, 10, 0), Padding = new Padding(10) };
            planeTextItems.Clear();
            foreach(string key in keys) {
                int bottomPadding = spacingMask[key] ? 13 : 3;
                string itemText = string.Format("{0}:", planeItemsNames[key]);
                MapOverlayTextItem labelItem = new MapOverlayTextItem() {
                    Alignment = ContentAlignment.TopLeft,
                    JoiningOrientation = Orientation.Vertical,
                    Size = new Size(105, 0),
                    Padding = new Padding(0, 3, 0, bottomPadding),
                    Text = itemText
                };
                labelItem.TextStyle.Font = FontsCollection["label"];
                MapOverlayTextItem valueItem = new MapOverlayTextItem() {
                    Alignment = ContentAlignment.TopRight,
                    JoiningOrientation = Orientation.Vertical,
                    Size = new Size(120, 0),
                    Padding = new Padding(0, 3, 0, bottomPadding)
                };
                valueItem.TextStyle.Font = FontsCollection["value"];
                planeTextItems.Add(key, valueItem);
                infoOverlay.Items.AddRange(new MapOverlayItemBase[] { labelItem, valueItem });
            }
        }
        void CreateAirportInfoOverlay() {
            airportInfoOverlay = new MapOverlay() { Alignment = ContentAlignment.TopRight, Margin = new Padding(0, 10, 10, 0), Padding = new Padding(10) };
            airportTextItems.Clear();
            for(int i = 0; i < ap_keys.Count; i++) {
                string key = ap_keys[i];
                int bottomPadding = i == 3 ? 10 : 3;
                string itemText = airportItemsNames[key];
                MapOverlayTextItem labelItem = new MapOverlayTextItem() {
                    Alignment = ContentAlignment.TopLeft,
                    JoiningOrientation = Orientation.Vertical,
                    Size = new Size(70, i == 0 ? 28 : 0),
                    Padding = new Padding(0, 3, 0, bottomPadding),
                    Text = itemText
                };
                labelItem.TextStyle.Font = FontsCollection["label"];
                MapOverlayTextItem valueItem = new MapOverlayTextItem() {
                    Alignment = ContentAlignment.TopRight,
                    JoiningOrientation = Orientation.Vertical,
                    Size = new Size(125, i == 0 ? 28 : 0),
                    Padding = new Padding(0, 3, 0, bottomPadding)
                };
                valueItem.TextStyle.Font = FontsCollection["value"];
                airportTextItems.Add(key, valueItem);
                airportInfoOverlay.Items.AddRange(new MapOverlayItemBase[] { labelItem, valueItem });
            }
        }
        void CreateOverlays() {
            CreateImageOverlay();
            CreatePlaneInfoOverlay();
            CreateAirportInfoOverlay();
            titleOverlay = new MapOverlay() { Alignment = ContentAlignment.TopLeft, Margin = new Padding(10), Padding = new Padding(6) };
            titleOverlay.Items.Add(new MapOverlayTextItem() { Alignment = ContentAlignment.MiddleCenter, Text = "Live Flight Tracker" });
        }

        protected override Dictionary<string, Font> CreateFonts() {
            Dictionary<string, Font> collection = new Dictionary<string, Font>();
            collection.Add("label", new Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Regular));
            collection.Add("value", new Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Bold));
            return collection;
        }

        public MapOverlay[] GetOverlays() {
            return new MapOverlay[] { titleOverlay, imageOverlay, infoOverlay, airportInfoOverlay };
        }
        public void SetTextToItemByKey(string key, string text) {
            MapOverlayTextItem planeItem = null;
            if(planeTextItems.TryGetValue(key, out planeItem))
                planeItem.Text = text;
            MapOverlayTextItem airportItem = null;
            if(airportTextItems.TryGetValue(key, out airportItem))
                airportItem.Text = text;
        }
        public void SetImage(Image image) {
            imageItem.Image = image;
        }
        public void SetOverlaysVisibility(bool planeInfoVisible, bool airportVisible) {
            imageOverlay.Visible = planeInfoVisible;
            infoOverlay.Visible = planeInfoVisible;
            airportInfoOverlay.Visible = airportVisible;
        }
    }

    public class FlagsGameOverlayManager : OverlayManagerBase {
        static readonly Color HotTrackedColor = Color.FromArgb(128, 135, 135, 135);
        static readonly Color ChooseLevelBackgroundColor = Color.FromArgb(32, Color.Gray);
        const int LevelBottomPadding = 110;

        readonly string[] levelNames;
        readonly Dictionary<string, string> levelDescriptions;
        Dictionary<MapOverlayImageItem, MapOverlayTextItem> levelItems;
        Dictionary<MapOverlayTextItem, MapOverlayTextItem> levelSelectorItems;
        MapOverlayTextItem selectedLevelItem;

        MapOverlay newGameOverlay, chooseLevelOverlay;
        MapOverlayTextItem startGameItem;
        MapOverlayTextItem levelDescItem;

        MapOverlay infoOverlay;
        MapOverlayTextItem infoTextItem;

        MapOverlay countryFlagOverlay;
        MapOverlayImageItem flagItem;
        MapOverlayTextItem countryName;

        MapOverlay skipCountryOverlay, showCountryOverlay;
        MapOverlay restartGameOverlay, finishGameOverlay;
        MapOverlayTextItem skipCountryItem, showCountryItem;
        MapOverlayTextItem restartGameItem, finishGameItem;

        MapOverlay statisticGameOverlay;
        MapOverlayImageItem scoreImage, timeImage;
        MapOverlayTextItem scoreLabel, timeLabel;
        MapOverlayTextItem scoreItem, winsItem, lossesItem, timeItem;

        MapOverlay gameOverOverlay, scoreOverOverlay;
        MapOverlayTextItem newGameItem, scoreOverItem;

        public FlagsGameOverlayManager(string[] levelNames, Dictionary<string, string> levelDescriptions) {
            this.levelNames = levelNames;
            this.levelDescriptions = levelDescriptions;
            CreateOverlays();
            HidePanels();
        }

        void CreateOverlays() {
            CreateNewGameOverlay();
            CreateChooseLevelOverlay();
            CreateCountryGameOverlay();
            CreateStatisticGameOverlay();
            CreateOperationGameOverlay();
            CreateScoreOverOverlay();
            CreateGameOverOverlay();
            CreateGameInfoOverlay();
        }
        void CreateNewGameOverlay() {
            newGameOverlay = new MapOverlay() { Alignment = ContentAlignment.MiddleCenter, Padding = new Padding(30) };
            MapOverlayTextItem titleText = new MapOverlayTextItem() { Text = "New Game", Alignment = ContentAlignment.TopCenter, JoiningOrientation = Orientation.Vertical, TextAlignment = ContentAlignment.MiddleCenter, Padding = new Padding(35, 0, 35, 12) };
            titleText.TextStyle.Font = FontsCollection["title"];
            MapOverlayTextItem infoText = new MapOverlayTextItem() { Text = "Choose your level", Alignment = ContentAlignment.TopCenter, JoiningOrientation = Orientation.Vertical, TextAlignment = ContentAlignment.MiddleCenter, Padding = new Padding(35, 0, 35, LevelBottomPadding), Size = new Size(470, 0) };
            infoText.TextStyle.Font = FontsCollection["note"];
            levelDescItem = new MapOverlayTextItem() { Alignment = ContentAlignment.BottomCenter, JoiningOrientation = Orientation.Vertical, TextAlignment = ContentAlignment.MiddleCenter, Margin = new Padding(0, 30, 0, 30), Size = new Size(400, 0) };
            levelDescItem.TextStyle.Font = FontsCollection["default"];
            startGameItem = new MapOverlayTextItem() { Text = "START GAME", Alignment = ContentAlignment.BottomCenter, JoiningOrientation = Orientation.Vertical, TextAlignment = ContentAlignment.MiddleCenter, Padding = new Padding(20, 10, 20, 10) };
            startGameItem.TextStyle.Font = FontsCollection["button"];
            startGameItem.TextStyle.TextColor = Color.White;
            startGameItem.BackgroundStyle.Fill = Color.FromArgb(0x74, 0x9F, 0xDF);
            startGameItem.HotTrackedStyle.Fill = Color.FromArgb(0xAF, 0x74, 0x9F, 0xDF);
            newGameOverlay.Items.AddRange(new MapOverlayItemBase[] { titleText, infoText, startGameItem, levelDescItem });
        }
        void CreateChooseLevelOverlay() {
            chooseLevelOverlay = new MapOverlay();
            levelItems = new Dictionary<MapOverlayImageItem, MapOverlayTextItem>();
            levelSelectorItems = new Dictionary<MapOverlayTextItem, MapOverlayTextItem>();
            foreach(string levelName in levelNames) {
                string levelIconName = levelName.ToLower().Replace(' ', '_');
                MapOverlayImageItem iconItem = new MapOverlayImageItem() { ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\FlagsGame\\" + levelIconName + ".png")), JoiningOrientation = Orientation.Horizontal, Padding = new Padding(37, 20, 37, 20) };
                MapOverlayTextItem nameItem = new MapOverlayTextItem() { Text = levelName.ToUpper(), Size = new Size(80, 0), Padding = new Padding(0, 20, 0, 20), TextAlignment = ContentAlignment.BottomCenter };
                nameItem.TextStyle.Font = FontsCollection["level"];
                nameItem.HotTrackedStyle.Fill = ChooseLevelBackgroundColor;
                MapOverlayTextItem selectorItem = new MapOverlayTextItem();
                selectorItem.HotTrackedStyle.Fill = ChooseLevelBackgroundColor;
                levelItems.Add(iconItem, nameItem);
                levelSelectorItems.Add(nameItem, selectorItem);
            }
            chooseLevelOverlay.Items.AddRange(levelItems.Keys);
            chooseLevelOverlay.Items.AddRange(levelItems.Values);
            chooseLevelOverlay.Items.AddRange(levelSelectorItems.Values);
        }
        void CreateGameOverOverlay() {
            gameOverOverlay = new MapOverlay() { Alignment = ContentAlignment.MiddleCenter, JoiningOrientation = Orientation.Vertical, Padding = new Padding(20) };
            MapOverlayTextItem titleText = new MapOverlayTextItem() { Text = "GAME OVER", Alignment = ContentAlignment.BottomCenter, JoiningOrientation = Orientation.Vertical, TextAlignment = ContentAlignment.MiddleCenter, Padding = new Padding(0, 0, 0, 15) };
            titleText.TextStyle.Font = FontsCollection["title"];
            newGameItem = new MapOverlayTextItem() { Text = "NEW GAME", Alignment = ContentAlignment.BottomCenter, JoiningOrientation = Orientation.Vertical, TextAlignment = ContentAlignment.MiddleCenter, Padding = new Padding(20, 10, 20, 10) };
            newGameItem.TextStyle.Font = FontsCollection["button"];
            newGameItem.TextStyle.TextColor = Color.White;
            newGameItem.BackgroundStyle.Fill = Color.FromArgb(0x40, 0xAB, 0x5B);
            newGameItem.HotTrackedStyle.Fill = Color.FromArgb(0xAF, 0x40, 0xAB, 0x5B);
            gameOverOverlay.Items.AddRange(new MapOverlayItemBase[] { newGameItem, titleText });
        }
        void CreateScoreOverOverlay() {
            scoreOverOverlay = new MapOverlay() { Alignment = ContentAlignment.TopCenter, Margin = new Padding(0, 12, 0, 0), Padding = new Padding(0, 15, 0, 5) };
            MapOverlayTextItem scoreOverLabel = new MapOverlayTextItem() { Text = "SCORE:" };
            scoreOverLabel.TextStyle.Font = FontsCollection["score_over"];
            scoreOverItem = new MapOverlayTextItem() { Padding = new Padding(10, 0, 0, 0) };
            scoreOverItem.TextStyle.Font = FontsCollection["score_over"];
            scoreOverOverlay.Items.AddRange(new MapOverlayItemBase[] { scoreOverLabel, scoreOverItem });
        }
        void CreateCountryGameOverlay() {
            countryFlagOverlay = new MapOverlay() { Alignment = ContentAlignment.TopLeft, Margin = new Padding(12, 12, 0, 0) };
            countryName = new MapOverlayTextItem() { Alignment = ContentAlignment.BottomCenter, TextAlignment = ContentAlignment.MiddleCenter, Padding = new Padding(12, 0, 12, 15), Size = new Size(150, 0) };
            countryName.TextStyle.Font = FontsCollection["bold"];
            flagItem = new MapOverlayImageItem() { Alignment = ContentAlignment.TopCenter, Padding = new Padding(20) };
            countryFlagOverlay.Items.AddRange(new MapOverlayItemBase[] { countryName, flagItem });
        }
        void CreateStatisticGameOverlay() {
            statisticGameOverlay = new MapOverlay() { JoiningOrientation = Orientation.Vertical, Padding = new Padding(15, 3, 10, 3), Margin = new Padding(0, 0, 0, 7) };
            scoreImage = new MapOverlayImageItem() { ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\FlagsGame\\score.png")), Margin = new Padding(8, 12, 10, 12) };
            scoreLabel = new MapOverlayTextItem() { Text = "Score:", Padding = new Padding(0, 10, 5, 10) };
            scoreLabel.TextStyle.Font = FontsCollection["default"];
            scoreItem = new MapOverlayTextItem() { Padding = new Padding(0, 10, 10, 10) };
            scoreItem.TextStyle.Font = FontsCollection["default"];

            MapOverlayImageItem winsImage = new MapOverlayImageItem() { ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\FlagsGame\\wins.png")), Margin = new Padding(8, 12, 10, 12) };
            MapOverlayTextItem winsLabel = new MapOverlayTextItem() { Text = "Wins:", Padding = new Padding(0, 10, 5, 10) };
            winsLabel.TextStyle.Font = FontsCollection["default"];
            winsItem = new MapOverlayTextItem() { Padding = new Padding(0, 10, 10, 10) };
            winsItem.TextStyle.Font = FontsCollection["default"];

            MapOverlayImageItem lossesImage = new MapOverlayImageItem() { ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\FlagsGame\\loses.png")), Margin = new Padding(8, 12, 10, 12) };
            MapOverlayTextItem lossesLabel = new MapOverlayTextItem() { Text = "Losses:", Padding = new Padding(0, 10, 5, 10) };
            lossesLabel.TextStyle.Font = FontsCollection["default"];
            lossesItem = new MapOverlayTextItem() { Padding = new Padding(0, 10, 10, 10) };
            lossesItem.TextStyle.Font = FontsCollection["default"];

            timeImage = new MapOverlayImageItem() { ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\FlagsGame\\time.png")), Margin = new Padding(8, 12, 10, 12) };
            timeLabel = new MapOverlayTextItem() { Text = "Time:", Padding = new Padding(0, 10, 5, 10) };
            timeLabel.TextStyle.Font = FontsCollection["default"];
            timeItem = new MapOverlayTextItem() { Padding = new Padding(0, 10, 10, 10) };
            timeItem.TextStyle.Font = FontsCollection["default"];
            statisticGameOverlay.Items.AddRange(new MapOverlayItemBase[] { scoreImage, scoreLabel, scoreItem, winsImage, winsLabel, winsItem, lossesImage, lossesLabel, lossesItem, timeImage, timeLabel, timeItem });
        }
        void CreateOperationGameOverlay() {
            restartGameOverlay = new MapOverlay() { Alignment = ContentAlignment.TopRight, JoiningOrientation = Orientation.Vertical, Margin = new Padding(0, 12, 12, 0) };
            MapOverlayImageItem restartIcon = new MapOverlayImageItem() { ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\FlagsGame\\restart.png")), Margin = new Padding(10, 6, 7, 6) };
            restartGameItem = new MapOverlayTextItem() { Text = "RESTART GAME", Alignment = ContentAlignment.TopLeft, Margin = new Padding(1), Padding = new Padding(6), Size = new Size(110, 0) };
            restartGameItem.TextStyle.Font = FontsCollection["nav_button"];
            restartGameItem.HotTrackedStyle.Fill = HotTrackedColor;
            restartGameOverlay.Items.AddRange(new MapOverlayItemBase[] { restartIcon, restartGameItem });

            finishGameOverlay = new MapOverlay() { Alignment = ContentAlignment.TopRight, JoiningOrientation = Orientation.Vertical, Margin = new Padding(0, 0, 12, 0) };
            MapOverlayImageItem finishIcon = new MapOverlayImageItem() { ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\FlagsGame\\finish.png")), Margin = new Padding(10, 6, 7, 6) };
            finishGameItem = new MapOverlayTextItem() { Text = "FINISH GAME", Alignment = ContentAlignment.TopLeft, Margin = new Padding(1), Padding = new Padding(6), Size = new Size(110, 0) };
            finishGameItem.TextStyle.Font = FontsCollection["nav_button"];
            finishGameItem.HotTrackedStyle.Fill = HotTrackedColor;
            finishGameOverlay.Items.AddRange(new MapOverlayItemBase[] { finishIcon, finishGameItem });

            skipCountryOverlay = new MapOverlay() { Alignment = ContentAlignment.TopRight, JoiningOrientation = Orientation.Vertical, Margin = new Padding(0, 12, 12, 0) };
            MapOverlayImageItem skipIcon = new MapOverlayImageItem() { ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\FlagsGame\\skip.png")), Margin = new Padding(10, 6, 7, 6) };
            skipCountryItem = new MapOverlayTextItem() { Text = "SKIP COUNTRY", Alignment = ContentAlignment.TopLeft, Margin = new Padding(1), Padding = new Padding(6), Size = new Size(110, 0) };
            skipCountryItem.TextStyle.Font = FontsCollection["nav_button"];
            skipCountryItem.HotTrackedStyle.Fill = HotTrackedColor;
            skipCountryOverlay.Items.AddRange(new MapOverlayItemBase[] { skipIcon, skipCountryItem });

            showCountryOverlay = new MapOverlay() { Alignment = ContentAlignment.TopRight, JoiningOrientation = Orientation.Vertical, Margin = new Padding(0, 0, 12, 0) };
            MapOverlayImageItem showIcon = new MapOverlayImageItem() { ImageUri = new Uri(DemoUtils.GetRelativePath("Images\\FlagsGame\\show.png")), Margin = new Padding(10, 6, 7, 6) };
            showCountryItem = new MapOverlayTextItem() { Text = "SHOW COUNTRY", Alignment = ContentAlignment.TopLeft, Margin = new Padding(1), Padding = new Padding(6), Size = new Size(110, 0) };
            showCountryItem.TextStyle.Font = FontsCollection["nav_button"];
            showCountryItem.HotTrackedStyle.Fill = HotTrackedColor;
            showCountryOverlay.Items.AddRange(new MapOverlayItemBase[] { showIcon, showCountryItem });
        }
        void CreateGameInfoOverlay() {
            infoOverlay = new MapOverlay() { Margin = new Padding(0, 12, 0, 0) };
            infoTextItem = new MapOverlayTextItem() { TextAlignment = ContentAlignment.MiddleLeft, Padding = new Padding(20), Size = new Size(250, 0) };
            infoTextItem.TextStyle.Font = FontsCollection["info"];
            infoOverlay.Items.Add(infoTextItem);
        }
        void ScoreOverMode() {
            statisticGameOverlay.Alignment = ContentAlignment.TopCenter;
            timeImage.Visible = true;
            timeLabel.Visible = true;
            timeItem.Visible = true;
            scoreImage.Visible = false;
            scoreLabel.Visible = false;
            scoreItem.Visible = false;
        }
        void ScoreGamingMode() {
            statisticGameOverlay.Alignment = ContentAlignment.BottomCenter;
            timeImage.Visible = false;
            timeLabel.Visible = false;
            timeItem.Visible = false;
            scoreImage.Visible = true;
            scoreLabel.Visible = true;
            scoreItem.Visible = true;
        }
        void SetDefaultStyleLevelItems() {
            foreach(KeyValuePair<MapOverlayImageItem, MapOverlayTextItem> levelPair in levelItems)
                ChangeSelectionOverlayItem(levelPair.Value, false);
        }
        void ChangeSelectionOverlayItem(MapOverlayTextItem levelItem, bool isSelect) {
            if(isSelect) {
                string key = levelItem.Text.ToLower();
                levelDescItem.Text = levelDescriptions[key];
                selectedLevelItem = levelItem;
            }
            levelSelectorItems[levelItem].BackgroundStyle.Fill = isSelect ? GetLevelColor() : ChooseLevelBackgroundColor;
        }
        void RecalculateChooseLevelArrangement(ScaleHelper scaleDPI, OverlayArrangement[] overlayArrangement) {
            const int itemsCount = 4;
            Rectangle newGameRect = overlayArrangement[0].OverlayLayout;
            int dY = scaleDPI.ScaleVertical(LevelBottomPadding);
            overlayArrangement[1].OverlayLayout = Rectangle.FromLTRB(newGameRect.Left, newGameRect.Top + dY, newGameRect.Right, newGameRect.Top + dY + scaleDPI.ScaleVertical(120));
            double itemsWidth = overlayArrangement[1].ItemLayouts[itemsCount - 1].Right - overlayArrangement[1].ItemLayouts[0].Left;
            int itemsOffset = (int)((newGameRect.Width - itemsWidth) / 2.0);
            for(int i = 0; i < itemsCount; i++) {
                Rectangle iconRect = overlayArrangement[1].ItemLayouts[i];
                iconRect = Rectangle.FromLTRB(iconRect.Left + itemsOffset, iconRect.Top, iconRect.Right + itemsOffset, iconRect.Bottom);
                Rectangle textRect = Rectangle.FromLTRB(iconRect.Left, iconRect.Top, iconRect.Right, iconRect.Bottom + 25);
                overlayArrangement[1].ItemLayouts[i] = iconRect;
                overlayArrangement[1].ItemLayouts[i + itemsCount] = textRect;
                overlayArrangement[1].ItemLayouts[i + itemsCount * 2] = Rectangle.FromLTRB(textRect.Left, textRect.Bottom, textRect.Right, textRect.Bottom + 5);
            }
        }
        void RecalculateScoreOverArrangement(OverlayArrangement[] overlayArrangement) {
            Rectangle scoreRect = overlayArrangement[0].OverlayLayout;
            Rectangle statisticRect = overlayArrangement[2].OverlayLayout;
            overlayArrangement[0].OverlayLayout = Rectangle.FromLTRB(statisticRect.Left, scoreRect.Top, statisticRect.Right, scoreRect.Bottom);
            int itemsCount = overlayArrangement[0].ItemLayouts.Length;
            double itemsWidth = overlayArrangement[0].ItemLayouts[itemsCount - 1].Right - overlayArrangement[0].ItemLayouts[0].Left;
            int itemsOffset = (int)((statisticRect.Width - itemsWidth) / 2.0);
            for(int i = 0; i < itemsCount; i++) {
                Rectangle itemRect = overlayArrangement[0].ItemLayouts[i];
                overlayArrangement[0].ItemLayouts[i] = Rectangle.FromLTRB(itemRect.Left + itemsOffset, itemRect.Top, itemRect.Left + itemsOffset + itemRect.Width, itemRect.Bottom);
            }
        }
        void RecalculateInfoArrangement(OverlayArrangement[] overlayArrangement) {
            Rectangle countryRect = overlayArrangement[0].OverlayLayout;
            Rectangle infoRect = overlayArrangement[1].OverlayLayout;
            overlayArrangement[1].OverlayLayout = Rectangle.FromLTRB(infoRect.Left, countryRect.Top, infoRect.Right, countryRect.Bottom);
            double itemsHeight = overlayArrangement[1].ItemLayouts[0].Height;
            int itemsOffset = (int)((overlayArrangement[0].ItemLayouts[1].Height - itemsHeight) / 2.0);
            Rectangle itemRect = overlayArrangement[1].ItemLayouts[0];
            overlayArrangement[1].ItemLayouts[0] = Rectangle.FromLTRB(itemRect.Left, itemRect.Top + itemsOffset, itemRect.Right, itemRect.Top + itemsOffset + itemRect.Height);
        }
        Color GetLevelColor() {
            string levelName = selectedLevelItem != null ? selectedLevelItem.Text.ToLower() : String.Empty;
            if(levelName == levelNames[1])
                return Color.FromArgb(0x40, 0xAB, 0x5B);
            if(levelName == levelNames[2])
                return Color.FromArgb(0xFF, 0xAE, 0x00);
            if(levelName == levelNames[3])
                return Color.FromArgb(0xFF, 0x00, 0x00);
            return Color.FromArgb(0x74, 0x9F, 0xDF);
        }

        protected override Dictionary<string, Font> CreateFonts() {
            Dictionary<string, Font> collection = new Dictionary<string, Font>();
            collection.Add("title", new Font(AppearanceObject.DefaultFont.FontFamily, 23, FontStyle.Bold));
            collection.Add("note", new Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Regular));
            collection.Add("button", new Font(AppearanceObject.DefaultFont.FontFamily, 10, FontStyle.Bold));
            collection.Add("nav_button", new Font(AppearanceObject.DefaultFont.FontFamily, 9, FontStyle.Bold));
            collection.Add("score_over", new Font(AppearanceObject.DefaultFont.FontFamily, 17, FontStyle.Regular));
            collection.Add("default", new Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Regular));
            collection.Add("bold", new Font(AppearanceObject.DefaultFont.FontFamily, 11, FontStyle.Bold));
            collection.Add("level", new Font(AppearanceObject.DefaultFont.FontFamily, 8, FontStyle.Bold));
            collection.Add("info", new Font(AppearanceObject.DefaultFont.FontFamily, 12, FontStyle.Regular));
            return collection;
        }

        public void OverlaysArranged(ScaleHelper scaleDPI, OverlayArrangement[] overlayArrangement) {
            if(newGameOverlay.Visible && chooseLevelOverlay.Visible && overlayArrangement.Length >= 2)
                RecalculateChooseLevelArrangement(scaleDPI, overlayArrangement);
            if(statisticGameOverlay.Visible && scoreOverOverlay.Visible && overlayArrangement.Length >= 3)
                RecalculateScoreOverArrangement(overlayArrangement);
            if(countryFlagOverlay.Visible && infoOverlay.Visible && overlayArrangement.Length >= 3)
                RecalculateInfoArrangement(overlayArrangement);
        }
        public MapOverlay[] GetOverlays() {
            return new MapOverlay[] { newGameOverlay, chooseLevelOverlay, scoreOverOverlay, gameOverOverlay, countryFlagOverlay, infoOverlay, statisticGameOverlay, skipCountryOverlay, showCountryOverlay, restartGameOverlay, finishGameOverlay };
        }
        public void HidePanels() {
            newGameOverlay.Visible = false;
            chooseLevelOverlay.Visible = false;
            countryFlagOverlay.Visible = false;
            statisticGameOverlay.Visible = false;
            scoreOverOverlay.Visible = false;
            gameOverOverlay.Visible = false;
            skipCountryOverlay.Visible = false;
            showCountryOverlay.Visible = false;
            restartGameOverlay.Visible = false;
            finishGameOverlay.Visible = false;
            infoOverlay.Visible = false;
        }
        public void ShowGameOverOverlay(string time) {
            HidePanels();
            ScoreOverMode();
            timeItem.Text = time;
            scoreOverItem.Text = scoreItem.Text;
            statisticGameOverlay.Visible = true;
            scoreOverOverlay.Visible = true;
            gameOverOverlay.Visible = true;
        }
        public void ShowNewGameOverlay() {
            HidePanels();
            newGameOverlay.Visible = true;
            chooseLevelOverlay.Visible = true;
        }
        public void ShowGameInfoOverlay() {
            HidePanels();
            ScoreGamingMode();
            countryFlagOverlay.Visible = true;
            statisticGameOverlay.Visible = true;
            skipCountryOverlay.Visible = true;
            showCountryOverlay.Visible = true;
            restartGameOverlay.Visible = true;
            finishGameOverlay.Visible = true;
            infoOverlay.Visible = true;
        }


        public void SetInfoMessage(string text) {
            infoTextItem.Text = text;
        }
        public void SetScore(double score, int wins, int losses) {
            scoreItem.Text = score.ToString();
            winsItem.Text = wins.ToString();
            lossesItem.Text = losses.ToString();
        }
        public void SetCountry(Image flag, string name) {
            flagItem.Image = flag;
            countryName.Text = name;
        }
        public void SetCountryNameVisibility(bool isVisible) {
            countryName.Visible = isVisible;
        }
        public void SetCountryOperationsVisibility(bool isVisible) {
            skipCountryOverlay.Visible = isVisible;
            showCountryOverlay.Visible = isVisible;
        }
        public void SelectDefaultLevel() {
            SetDefaultStyleLevelItems();
            if(levelItems.Count > 0)
                ChangeSelectionOverlayItem(levelItems.First().Value, true);
        }
        public GameLevel GetSelectedLevel() {
            string levelName = selectedLevelItem != null ? selectedLevelItem.Text.ToLower() : String.Empty;
            if(levelName == levelNames[1])
                return GameLevel.Middle;
            if(levelName == levelNames[2])
                return GameLevel.High;
            if(levelName == levelNames[3])
                return GameLevel.VeryHigh;
            return GameLevel.Easy;
        }
        public ClickedAction GetClickedAction(MapOverlayItemBase clickedItem) {
            if(clickedItem == skipCountryItem)
                return ClickedAction.SkipCountry;
            if(clickedItem == showCountryItem)
                return ClickedAction.ShowCountry;
            if(clickedItem == finishGameItem)
                return ClickedAction.FinishGame;
            if(clickedItem == startGameItem)
                return ClickedAction.StartGame;
            if(clickedItem == restartGameItem || clickedItem == newGameItem)
                return ClickedAction.NewGame;
            KeyValuePair<MapOverlayImageItem, MapOverlayTextItem> levelPair = levelItems.FirstOrDefault(x => x.Value.Equals(clickedItem) || x.Key.Equals(clickedItem));
            if(levelPair.Value != null) {
                SetDefaultStyleLevelItems();
                ChangeSelectionOverlayItem(levelPair.Value, true);
                return ClickedAction.ChangeLevel;
            }
            return ClickedAction.Unknown;
        }
    }

    public enum ClickedAction { Unknown, ChangeLevel, NewGame, StartGame, FinishGame, SkipCountry, ShowCountry, Restart, NotRestart }

    public abstract class TextOverlayManager : OverlayManagerBase {
        MapOverlay overlay;
        MapOverlayTextItem itemsCountItem;

        protected abstract string TextFormat { get; }

        public TextOverlayManager() {
            CreateOverlay();
        }

        void CreateOverlay() {
            itemsCountItem = new MapOverlayTextItem() { JoiningOrientation = Orientation.Vertical, Alignment = ContentAlignment.MiddleRight };
            itemsCountItem.TextStyle.Font = FontsCollection["font"];
            overlay = new MapOverlay() { Alignment = ContentAlignment.BottomRight, Margin = new Padding(10, 10, 10, 10) };
            overlay.Items.Add(itemsCountItem);
        }

        protected override Dictionary<string, Font> CreateFonts() {
            Dictionary<string, Font> collection = new Dictionary<string, Font>();
            collection.Add("font", new Font(AppearanceObject.DefaultFont.FontFamily, 14, FontStyle.Regular));
            return collection;
        }

        public void UpdateText(params object[] args) {
            itemsCountItem.Text = string.Format(TextFormat, args);
        }
        public MapOverlay[] GetOverlays() {
            return new MapOverlay[] { overlay };
        }
    }

    public class PerformanceOverlayManager : TextOverlayManager {
        protected override string TextFormat { get { return "{0} items loaded"; } }
    }

    public class ShapeSimplifierOverlayManager : TextOverlayManager {
        protected override string TextFormat { get { return "{0} points, {1:0.000}% tolerance"; } }
    }

    public class ItemsMovingOverlayManager : OverlayManagerBase {
        readonly static string[] AttributeNames = new string[] { "NAME", "CAPITAL" };

        readonly MapOverlay finishGameCaptionOverlay;
        readonly MapOverlay finishGameOverlay;
        readonly MapOverlay countryInfoOverlay;
        readonly MapOverlay gameStatsOverlay;
        readonly MapOverlayTextItem statsItem;
        readonly MapOverlayTextItem restartGameItem;
        readonly MapOverlayTextItem notRestartGameItem;
        readonly Dictionary<string, Image> flagsCache = new Dictionary<string, Image>();

        public ItemsMovingOverlayManager() {
            countryInfoOverlay = new MapOverlay() { Alignment = ContentAlignment.BottomRight, Margin = new Padding(10), Padding = new Padding(0, 0, 0, 5) };

            gameStatsOverlay = new MapOverlay() { Alignment = ContentAlignment.BottomLeft, Margin = new Padding(10) };
            statsItem = new MapOverlayTextItem() { Alignment = ContentAlignment.MiddleCenter };
            statsItem.TextStyle.Font = FontsCollection["font"];
            gameStatsOverlay.Items.Add(statsItem);

            finishGameCaptionOverlay = new MapOverlay() { Alignment = ContentAlignment.MiddleCenter, JoiningOrientation = Orientation.Vertical };
            MapOverlayTextItem captionItem = new MapOverlayTextItem() {
                Text = "Well done! All countries are on their places! Restart game?",
                JoiningOrientation = Orientation.Vertical,
                Alignment = ContentAlignment.TopCenter,
                TextAlignment = ContentAlignment.MiddleCenter
            };
            captionItem.TextStyle.Font = FontsCollection["finishFont"];
            finishGameCaptionOverlay.Items.Add(captionItem);
            finishGameOverlay = new MapOverlay() { Alignment = ContentAlignment.MiddleCenter, JoiningOrientation = Orientation.Vertical };
            restartGameItem = new MapOverlayTextItem() {
                Text = "Yes",
                JoiningOrientation = Orientation.Horizontal,
                Alignment = ContentAlignment.MiddleCenter,
                TextAlignment = ContentAlignment.MiddleCenter
            };
            restartGameItem.TextStyle.Font = FontsCollection["finishFont"];
            restartGameItem.HotTrackedStyle.Fill = Color.FromArgb(0xAF, 0x74, 0x9F, 0xDF);
            notRestartGameItem = new MapOverlayTextItem() {
                Text = "No",
                JoiningOrientation = Orientation.Horizontal,
                Alignment = ContentAlignment.MiddleCenter,
                TextAlignment = ContentAlignment.MiddleCenter
            };
            notRestartGameItem.TextStyle.Font = FontsCollection["finishFont"];
            notRestartGameItem.HotTrackedStyle.Fill = Color.FromArgb(0xAF, 0x74, 0x9F, 0xDF);
            finishGameOverlay.Items.AddRange(new MapOverlayItemBase[] { restartGameItem, notRestartGameItem });
            HideGameFinish();
        }

        void ArrangeFinishOverlays(OverlayArrangement[] overlayArrangements) {
            Rectangle captionLayout = overlayArrangements[2].OverlayLayout;
            Rectangle yesLayout = overlayArrangements[3].ItemLayouts[0];
            Rectangle noLayout = overlayArrangements[3].ItemLayouts[1];
            Rectangle newYesLayout = new Rectangle(yesLayout.Left, yesLayout.Top, (int)(captionLayout.Width / 2.0), yesLayout.Height);
            Rectangle newNoLayout = new Rectangle((int)(captionLayout.Width / 2.0), noLayout.Top, (int)(captionLayout.Width / 2.0), noLayout.Height);
            overlayArrangements[3].ItemLayouts[0] = newYesLayout;
            overlayArrangements[3].ItemLayouts[1] = newNoLayout;
            overlayArrangements[3].OverlayLayout = new Rectangle(captionLayout.Left, captionLayout.Bottom, captionLayout.Width, yesLayout.Height);
        }
        protected override Dictionary<string, Font> CreateFonts() {
            Dictionary<string, Font> collection = new Dictionary<string, Font>();
            collection.Add("font", new Font(AppearanceObject.DefaultFont.FontFamily, 16, FontStyle.Regular));
            collection.Add("finishFont", new Font(AppearanceObject.DefaultFont.FontFamily, 24, FontStyle.Regular));
            return collection;
        }
        public void UpdateText(MapItemAttributeCollection attributes) {
            countryInfoOverlay.Items.BeginUpdate();
            try {
                countryInfoOverlay.Items.Clear();
                MapOverlayImageItem flagItem = new MapOverlayImageItem() {
                    JoiningOrientation = Orientation.Vertical,
                    Alignment = ContentAlignment.MiddleCenter,
                    Image = DemoUtils.GetCountryFlag(flagsCache, attributes["NAME_LONG"].Value.ToString()),
                    Padding = new Padding(10)
                };
                countryInfoOverlay.Items.Add(flagItem);
                foreach(string attributeName in AttributeNames) {
                    MapOverlayTextItem textItem = new MapOverlayTextItem() { JoiningOrientation = Orientation.Vertical, Alignment = ContentAlignment.MiddleCenter, Padding = new Padding(5, 0, 5, 0) };
                    textItem.TextStyle.Font = FontsCollection["font"];
                    textItem.Text = attributeName[0] + attributeName.Substring(1).ToLower() + ": " + attributes[attributeName].Value.ToString();
                    countryInfoOverlay.Items.Add(textItem);
                }
            }
            finally {
                countryInfoOverlay.Items.EndUpdate();
            }
        }
        public void HideText() {
            countryInfoOverlay.Items.Clear();
        }
        public MapOverlay[] GetOverlays() {
            return new MapOverlay[] { countryInfoOverlay, gameStatsOverlay, finishGameCaptionOverlay, finishGameOverlay };
        }
        public void UpdateGameStats(int solvedCountries, int totalCountries) {
            statsItem.Text = string.Format("Countries solved: {0} out of {1}", solvedCountries, totalCountries);
        }
        public void HideGameFinish() {
            finishGameCaptionOverlay.Visible = false;
            finishGameOverlay.Visible = false;
        }
        public void ShowGameFinish() {
            finishGameCaptionOverlay.Visible = true;
            finishGameOverlay.Visible = true;
        }
        public ClickedAction GetClickedAction(MapOverlayItemBase clickedItem) {
            if(clickedItem == restartGameItem)
                return ClickedAction.Restart;
            if(clickedItem == notRestartGameItem)
                return ClickedAction.NotRestart;
            return ClickedAction.Unknown;
        }
        public void ArrangeOverlays(OverlayArrangement[] overlayArrangements) {
            if(finishGameCaptionOverlay.Visible)
                ArrangeFinishOverlays(overlayArrangements);
        }
    }
    public class MapEditorOverlayManager : OverlayManagerBase {
        const int padding = 8;
        Point fillEditLocation = Point.Empty;
        Point strokeEditLocation = Point.Empty;

        public Point FillEditLocation { get { return fillEditLocation; } }
        public Point StrokeEditLocation { get { return strokeEditLocation; } }

        protected override Dictionary<string, Font> CreateFonts() {
            return new Dictionary<string, Font>();
        }
        public void ArrangeOverlays(ScaleHelper scaleDPI, OverlayArrangement[] arrangements, Size colorPickerSize) {
            Rectangle panelRect = arrangements[0].OverlayLayout;
            Rectangle rulerRect = arrangements[1].OverlayLayout;
            Rectangle fillRect = arrangements[2].OverlayLayout;
            Rectangle strokeRect = arrangements[3].OverlayLayout;
            arrangements[2].OverlayLayout = new Rectangle(new Point(rulerRect.Location.X, fillRect.Location.Y),
                                                   new Size(fillRect.Width + colorPickerSize.Width, panelRect.Height));
            int colorPickTop = panelRect.Top + (panelRect.Height - colorPickerSize.Height) / 2;
            fillEditLocation = new Point(rulerRect.Location.X + fillRect.Width, colorPickTop);
            int strokeLayoutStart = arrangements[2].OverlayLayout.Right;
            arrangements[3].OverlayLayout = new Rectangle(strokeLayoutStart, strokeRect.Top,
                strokeRect.Width + colorPickerSize.Width, panelRect.Height);
            strokeEditLocation = new Point(strokeLayoutStart + strokeRect.Width, colorPickTop);
            arrangements[1].OverlayLayout = new Rectangle(new Point(panelRect.Left, panelRect.Bottom + scaleDPI.ScaleVertical(padding)), rulerRect.Size);
        }
    }
}
