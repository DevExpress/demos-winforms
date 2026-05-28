using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraTreeMap.Native;

namespace DevExpress.XtraTreeMap.Demos {
    public static class Utils {
        public static string GetRelativePath(string name) {
            name = "Data\\" + name;
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            for(int i = 0; i <= 10; i++) {
                string filePath = Path.Combine(dir.FullName, name);
                if(File.Exists(filePath))
                    return filePath;
                dir = Directory.GetParent(dir.FullName);
            }
            return string.Empty;
        }
        public static string GetRelativeDirectoryPath(string name) {
            name = "Data\\" + name;
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            while(dir != null) {
                string directoryPath = Path.Combine(dir.FullName, name);
                if(Directory.Exists(directoryPath))
                    return directoryPath;
                dir = Directory.GetParent(dir.FullName);
            }
            return string.Empty;
        }
        public static DataTable CreateDataSet(string xmlFileName) {
            string filePath = Utils.GetRelativePath(xmlFileName);
            if(!string.IsNullOrWhiteSpace(filePath)) {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(filePath);
                if(dataSet.Tables.Count > 0)
                    return dataSet.Tables[0];
            }
            return null;
        }
    }
    public static class PaletteHelper {

        static readonly Dictionary<string, Palette> skinPalettes = new Dictionary<string, Palette>();
        static Palette _interactionDemoPalette;

        public static Palette InteractionDemoPalette { get { return _interactionDemoPalette; } }

        public static readonly Color[] SelectionDemoPalette = {
            Color.FromArgb(170, 97, 150, 211),
            Color.FromArgb(170, 234, 127, 56),
            Color.FromArgb(170, 252, 195, 25),
            Color.FromArgb(170, 76, 107, 194),
            Color.FromArgb(170, 111, 174, 73),
            Color.FromArgb(170, 48, 91, 143),
            Color.FromArgb(170, 155, 76, 26),
            Color.FromArgb(170, 150, 117, 10),
            Color.FromArgb(170, 46, 66, 119),
            Color.FromArgb(170, 68, 105, 47),
            Color.FromArgb(170, 127, 171, 220),
            Color.FromArgb(170, 238, 153, 92),
            Color.FromArgb(170, 252, 208, 58),
            Color.FromArgb(170, 103, 129, 195)
        };

        public static void UpdateInteractionDemoPalette(ISkinProvider skinProvider) {
            if(!skinPalettes.TryGetValue(skinProvider.SkinName, out _interactionDemoPalette)) {
                _interactionDemoPalette = Palette.CreatePalette(
                                      SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette01),
                                      SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette02),
                                      SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette03),
                                      SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette04),
                                      SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette05),
                                      SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette06),
                                      SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette07),
                                      SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette08),
                                      SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette09),
                                      SkinPainterHelper.GetColorProperty(skinProvider, TreeMapSkins.ColorPalette10));
                skinPalettes[skinProvider.SkinName] = _interactionDemoPalette;
            }
        }
    }
    public static class DemoHelpersContainer {
        static readonly Dictionary<SunburstControl, ArrayList> helpers = new Dictionary<SunburstControl, ArrayList>();

        public static void AddControl(SunburstControl sunburstControl, ComboBoxEdit colorizerComboBoxEdit, LayoutControlItem varyColorInGroupLCI, LayoutControlItem modeLCI) {
            helpers.Add(sunburstControl, new ArrayList() {
                new DemoColorizerOptionsHelper(sunburstControl, colorizerComboBoxEdit, varyColorInGroupLCI, modeLCI),
                new SunburstRotationHelper(sunburstControl) }
            );
        }
        public static void AddControl(SunburstControl sunburstControl) {
            helpers.Add(sunburstControl, new ArrayList() { new SunburstRotationHelper(sunburstControl) });
        }

        class DemoColorizerOptionsHelper {
            readonly SunburstPaletteColorizer paletteColorizer;
            readonly SunburstGradientColorizer gradientColorizer;

            public DemoColorizerOptionsHelper(SunburstControl sunburst, ComboBoxEdit colorizerCBE, LayoutControlItem varyColorInGroupLCI, LayoutControlItem modeLCI) {
                paletteColorizer = new SunburstPaletteColorizer();
                gradientColorizer = new SunburstGradientColorizer();
                InitailizeEditors(sunburst, colorizerCBE, varyColorInGroupLCI, modeLCI);
            }

            void InitailizeEditors(SunburstControl sunburst, ComboBoxEdit colorizerCBE, LayoutControlItem varyColorInGroupLCI, LayoutControlItem modeLCI) {
                colorizerCBE.SelectedIndexChanged += (s, e) => { UpdateColorizer(sunburst, colorizerCBE.SelectedIndex, varyColorInGroupLCI, modeLCI); };
                CheckEdit varyColorInGroupCE = (CheckEdit)varyColorInGroupLCI.Control;
                varyColorInGroupCE.CheckedChanged += (s, e) => { paletteColorizer.VaryColorInGroup = varyColorInGroupCE.Checked; };
                ComboBoxEdit modeCBE = (ComboBoxEdit)modeLCI.Control;
                modeCBE.SelectedIndexChanged += (s, e) => { gradientColorizer.Mode = (GradientColorizerMode)modeCBE.SelectedIndex; };
                colorizerCBE.SelectedIndex = 0;
            }
            void UpdateColorizer(SunburstControl sunburst, int colorizerIndex, LayoutControlItem varyColorInGroupLCI, LayoutControlItem modeLCI) {
                if(colorizerIndex == 0) {
                    sunburst.Colorizer = paletteColorizer;
                    varyColorInGroupLCI.Visibility = LayoutVisibility.Always;
                    modeLCI.Visibility = LayoutVisibility.Never;
                }
                else {
                    sunburst.Colorizer = gradientColorizer;
                    varyColorInGroupLCI.Visibility = LayoutVisibility.Never;
                    modeLCI.Visibility = LayoutVisibility.Always;
                }
            }
        }

        class SunburstRotationHelper {
            bool rotate;
            Point startPosition;
            readonly SunburstControl sunburst;

            public SunburstRotationHelper(SunburstControl sunburst) {
                this.sunburst = sunburst;
                this.sunburst.MouseDown += Sunburst_MouseDown;
                this.sunburst.MouseMove += Sunburst_MouseMove;
                this.sunburst.MouseUp += Sunburst_MouseUp;
            }

            void Sunburst_MouseDown(object sender, MouseEventArgs e) {
                Point position = e.Location;
                SunburstHitInfo hitInfo = sunburst.CalcHitInfo(position);
                if(hitInfo != null && hitInfo.InSunburstItem) {
                    rotate = true;
                    startPosition = position;
                    sunburst.Cursor = DragCursors.HandDragCursor;
                }
            }
            void Sunburst_MouseMove(object sender, MouseEventArgs e) {
                Point position = e.Location;
                SunburstHitInfo hitInfo = sunburst.CalcHitInfo(position);
                if(hitInfo != null) {
                    sunburst.Cursor = rotate ? DragCursors.HandDragCursor : hitInfo.InSunburstItem ? Cursors.Hand : Cursors.Default;
                    if(rotate) {
                        double angleDelta = CalcAngle(startPosition, position) * 180.0 / Math.PI;
                        angleDelta *= sunburst.SweepDirection == SunburstSweepDirection.Clockwise ? -1 : 1;
                        double newAngle = sunburst.StartAngle + angleDelta;
                        if(Math.Abs(newAngle) > 360)
                            newAngle += -720 * Math.Sign(newAngle);
                        sunburst.StartAngle = newAngle;
                        startPosition = position;
                    }
                }
            }
            void Sunburst_MouseUp(object sender, MouseEventArgs e) {
                rotate = false;
            }
            double CalcAngle(Point p1, Point p2) {
                Point center = new Point(sunburst.Width / 2, sunburst.Height / 2);
                return Math.Atan2(p1.Y - center.Y, p1.X - center.X) - Math.Atan2(p2.Y - center.Y, p2.X - center.X);
            }
        }
    }

    public class HeatmapDataSourceGenerator {
        const int offset = 15;
        const int speedRange = 7;
        const int velocity = 10;
        public const int SizeX = 1000, SizeY = 1000;

        readonly Data.Utils.NonCryptographicRandom random = new Data.Utils.NonCryptographicRandom(100);

        int[,] speed;
        int[,] values;

        int min = 0;
        int delta = 0;

        int LengthX { get { return SizeX + offset; } }
        int LengthY { get { return SizeY + offset; } }

        public HeatmapDataSourceGenerator() {
            InitializeMatrix();
        }

        void InitializeMatrix() {
            speed = new int[SizeX + offset, SizeY + offset];
            values = new int[SizeX + offset, SizeY + offset];
            values[0, 0] = 0;
            speed[0, 0] = 0;
            int minLength = Math.Min(LengthX, LengthY);
            for(int i = 1; i < minLength; i++) {
                values[i, 0] = values[i - 1, 0] + speed[i - 1, 0];
                values[0, i] = values[0, i - 1] + speed[0, i - 1];
                speed[i, 0] = speed[i - 1, 0] + random.Next(0 - speedRange, 1 + speedRange);
                speed[0, i] = speed[0, i - 1] + random.Next(0 - speedRange, 1 + speedRange);
            }
            for(int i = minLength; i < LengthX; i++) {
                values[i, 0] = values[i - 1, 0] + speed[i - 1, 0];
                speed[i, 0] = speed[i - 1, 0] + random.Next(0 - speedRange, 1 + speedRange);
            }
            for(int i = minLength; i < LengthY; i++) {
                values[0, i] = values[0, i - 1] + speed[0, i - 1];
                speed[0, i] = speed[0, i - 1] + random.Next(0 - speedRange, 1 + speedRange);
            }
            for(int i = 1; i < LengthX; i++) {
                for(int j = 1; j < LengthY; j++) {
                    values[i, j] = (values[i - 1, j - 1] + speed[i - 1, j - 1] + speed[i - 1, j] + speed[i, j - 1]) / 2;
                    speed[i, j] = (speed[i - 1, j] + speed[i, j - 1]) / 2 + random.Next(0 - speedRange, 1 + speedRange);
                }
            }
            for(int i = 0; i < LengthX; i++) {
                for(int j = 0; j < LengthY; j++) {
                    if(values[i, j] > delta)
                        delta = values[i, j];
                    if(values[i, j] < min)
                        min = values[i, j];
                }
            }
            delta -= min;
        }

        void UpdateMatrix() {
            for(int i = 0; i < LengthX; i++) {
                for(int j = 0; j < LengthY - velocity; j++) {
                    values[i, j] = values[i, j + velocity];
                    speed[i, j] = speed[i, j + velocity];
                }
            }
            for(int i = LengthY - velocity; i < LengthY; i++) {
                values[0, i] = values[0, i - 1] + speed[0, i - 1];
                speed[0, i] = speed[0, i - 1] + random.Next(0 - speedRange, 1 + speedRange);
                for(int j = 1; j < LengthX; j++) {
                    values[j, i] = (values[j - 1, i - 1] + speed[j - 1, i - 1] + speed[j, i - 1] + speed[j - 1, i]) / 2;
                    speed[j, i] = (speed[j, i - 1] + speed[j - 1, i]) / 2 + random.Next(0 - speedRange, 1 + speedRange);
                }
            }
        }

        public static int[] GetArray(int size) {
            return new int[size].Select((v, i) => i).ToArray();
        }

        public double[,] GetMatrix() {
            UpdateMatrix();
            double[,] matrix = new double[SizeX, SizeY];
            for(int i = 0; i < SizeX; i++)
                for(int j = 0; j < SizeY; j++)
                    matrix[i, j] = (values[i + offset, j + offset] - min) * 16777216.0 / delta - 8388608;
            return matrix;
        }
    }
}
