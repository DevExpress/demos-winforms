using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraCharts.Demos {
    public partial class AnimationDemo : ChartDemoModuleWithOptions {
        XYDiagram XYDiagram {
            get { return chart.Diagram as XYDiagram; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public AnimationDemo() {
            InitializeComponent();
            ChartControl.AnimationStartMode = ChartAnimationMode.OnDataChanged;
            comboBoxEditSeriesView.Properties.Items.AddRange(ViewTypesItemsGenerator.CreateItems());
            comboBoxEditSeriesView.SelectedItem = new ComboBoxSeriesViewItem(ViewType.Area);
            UpdateControls(ViewType.Area);
        }

        void comboBoxEditSeriesView_SelectedIndexChanged(object sender, EventArgs e) {
            ViewType selectedViewType = ((ComboBoxSeriesViewItem)comboBoxEditSeriesView.SelectedItem).ViewType;
            UpdateControls(selectedViewType);
        }
        void checkEditSeriesLabelsVisible_CheckedChanged(object sender, EventArgs e) {
            ChangeLabelsVisibility();
        }
        void simpleButtonAnimate_Click(object sender, EventArgs e) {
            ChartControl.Animate();
        }
        void comboBoxEditSeriesAnimation_SelectedValueChanged(object sender, EventArgs e) {
            SetAnimation(comboBoxEditSeriesAnimation.EditValue as IAnimationComboBoxItem);
        }
        void comboBoxEditPointAnimation_SelectedIndexChanged(object sender, EventArgs e) {
            SetAnimation(comboBoxEditPointAnimation.EditValue as IAnimationComboBoxItem);
        }
        void checkEditDiagramRotated_CheckedChanged(object sender, EventArgs e) {
            if(XYDiagram != null)
                XYDiagram.Rotated = checkEditDiagramRotated.Checked;
        }
        void checkEditAxisXReversed_CheckedChanged(object sender, EventArgs e) {
            if(XYDiagram != null)
                XYDiagram.AxisX.Reverse = checkEditAxisXReversed.Checked;
        }
        void checkEditAxisYReversed_CheckedChanged(object sender, EventArgs e) {
            if(XYDiagram != null)
                XYDiagram.AxisY.Reverse = checkEditAxisYReversed.Checked;
        }

        void SetAnimation(IAnimationComboBoxItem comboBoxItem) {
            if(comboBoxItem != null)
                foreach(Series series in ChartControl.Series) {
                    comboBoxItem.ApplyAnimation(series.View);
                }
        }
        void FillPointAnimationComboBoxEdit(ViewType selectedViewType) {
            FillAnimationComboBox(comboBoxEditPointAnimation, Utils.GetPointAnimationTypes(selectedViewType));
        }
        void FillSeriesAnimationComboBoxEdit(ViewType selectedViewType) {
            FillAnimationComboBox(comboBoxEditSeriesAnimation, Utils.GetSeriesAnimationTypes(selectedViewType));
        }
        void FillAnimationComboBox(ComboBoxEdit comboBox, List<Type> animationTypes) {
            ComboBoxItemCollection comboBoxItems = comboBox.Properties.Items;
            comboBoxItems.Clear();
            if(animationTypes.Count == 0)
                comboBox.Enabled = false;
            else {
                comboBox.Enabled = true;
                foreach(Type animationType in animationTypes) {
                    comboBoxItems.AddRange(CreateAnimationItems(animationType));
                }
                comboBoxItems.AddRange(CreateAnimationItems(animationTypes[0], true));
            }
        }
        void ChangeLabelsVisibility() {
            foreach(Series series in ChartControl.Series) {
                series.LabelsVisibility = checkEditSeriesLabelsVisible.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            }
        }
        void ChangeMarkersVisibility() {
            foreach(Series series in ChartControl.Series) {
                if(series.View is RangeAreaSeriesView) {
                    RangeAreaSeriesView rangeAreaView = (RangeAreaSeriesView)series.View;
                    rangeAreaView.Marker1Visibility = DefaultBoolean.True;
                    rangeAreaView.Marker2Visibility = DefaultBoolean.True;
                }
                else if(series.View is RadarRangeAreaSeriesView) {
                    RadarRangeAreaSeriesView rangeAreaView = (RadarRangeAreaSeriesView)series.View;
                    rangeAreaView.Marker1Visibility = DefaultBoolean.True;
                    rangeAreaView.Marker2Visibility = DefaultBoolean.True;
                }
                else if(series.View is PolarRangeAreaSeriesView) {
                    PolarRangeAreaSeriesView rangeAreaView = (PolarRangeAreaSeriesView)series.View;
                    rangeAreaView.Marker1Visibility = DefaultBoolean.True;
                    rangeAreaView.Marker2Visibility = DefaultBoolean.True;
                }
                else if(series.View is LineSeriesView)
                    ((LineSeriesView)series.View).MarkerVisibility = DefaultBoolean.True;
                else if(series.View is RadarLineSeriesView)
                    ((RadarLineSeriesView)series.View).MarkerVisibility = DefaultBoolean.True;
            }
        }
        void UpdateControls(ViewType selectedViewType) {
            UpdateChart(selectedViewType);
            if(XYDiagram != null) {
                layoutControlGroupDiagramOptions.Enabled = true;
                checkEditDiagramRotated.Checked = XYDiagram.Rotated;
                checkEditAxisXReversed.Checked = XYDiagram.AxisX.Reverse;
                checkEditAxisYReversed.Checked = XYDiagram.AxisY.Reverse;
            }
            else
                layoutControlGroupDiagramOptions.Enabled = false;
            FillSeriesAnimationComboBoxEdit(selectedViewType);
            FillPointAnimationComboBoxEdit(selectedViewType);
            if(comboBoxEditPointAnimation.Enabled)
                comboBoxEditPointAnimation.SelectedIndex = 0;
            if(comboBoxEditSeriesAnimation.Enabled)
                comboBoxEditSeriesAnimation.SelectedIndex = 0;
            ChangeMarkersVisibility();
            if(selectedViewType.Equals(ViewType.BoxPlot))
                checkEditSeriesLabelsVisible.Enabled = false;
            else {
                checkEditSeriesLabelsVisible.Enabled = true;
                ChangeLabelsVisibility();
            }

        }
        void UpdateChart(ViewType selectedViewType) {
            ChartControl.Series.Clear();
            Series[] generatedSeries = SeriesGenerator.GenerateSeries(selectedViewType);
            if(generatedSeries != null)
                ChartControl.Series.AddRange(generatedSeries);
        }
        List<IAnimationComboBoxItem> CreateAnimationItems(Type type, bool isNoneItem = false) {
            System.Reflection.PropertyInfo directionProperty = type.GetProperty("Direction");
            if(directionProperty != null && !isNoneItem) {
                List<IAnimationComboBoxItem> items = new List<IAnimationComboBoxItem>();
                Type propertyType = directionProperty.PropertyType;
                foreach(object directionValue in Enum.GetValues(propertyType)) {
                    items.Add(CreateAnimationItem(type, directionValue, isNoneItem));
                }
                return items;
            }
            return new List<IAnimationComboBoxItem>() { CreateAnimationItem(type, null, isNoneItem) };

        }
        IAnimationComboBoxItem CreateAnimationItem(Type type, object direction, bool isNoneItem = false) {
            if(type.IsSubclassOf(typeof(XYMarkerAnimationBase)))
                return new ComboBoxXYMarkerAnimationItem(type, isNoneItem, direction);
            else if(type.IsSubclassOf(typeof(BarAnimationBase)))
                return new ComboBoxBarAnimationItem(type, isNoneItem, direction);
            else if(type.IsSubclassOf(typeof(PieAnimationBase)))
                return new ComboBoxPieAnimationItem(type, isNoneItem, direction);
            else if(type.IsSubclassOf(typeof(FunnelAnimationBase)))
                return new ComboBoxFunnelAnimationItem(type, isNoneItem, direction);
            else if(type.IsSubclassOf(typeof(CircularMarkerAnimationBase)))
                return new ComboBoxCircularMarkerAnimationItem(type, isNoneItem, direction);
            else if(type.IsSubclassOf(typeof(FinancialAnimationBase)))
                return new ComboBoxFinancialPointAnimationItem(type, isNoneItem, direction);
            else if(type.IsSubclassOf(typeof(XYSeriesAnimationBase)))
                return new ComboBoxXYSeriesAnimationItem(type, isNoneItem, direction);
            else if(type.IsSubclassOf(typeof(CircularSeriesAnimationBase)))
                return new ComboBoxCircularSeriesAnimationItem(type, isNoneItem, direction);
            else if(type.IsSubclassOf(typeof(BoxPlotAnimationBase)))
                return new ComboBoxBoxPlotAnimationItem(type, isNoneItem, direction);
            throw new NotSupportedException(string.Format("Can't create ComboBoxItem. Unknown animation type: {0}", type.Name));
        }
    }


    interface IAnimationComboBoxItem {
        void ApplyAnimation(SeriesViewBase seriesView);
    }


    abstract class AnimationComboBoxItem<TAnimation, TSeriesView> : IAnimationComboBoxItem
        where TAnimation : AnimationBase
        where TSeriesView : SeriesViewBase {

        readonly Type type;
        readonly string caption;
        readonly bool isNoneItem;
        readonly object direction;

        public AnimationComboBoxItem(Type type, bool isNoneItem, object direction) {
            this.direction = direction;
            caption = GetDisplayName(type, isNoneItem);
            this.type = type;
            this.isNoneItem = isNoneItem;
        }
        string GetDisplayName(Type type, bool isNoneItem) {
            if(isNoneItem)
                return "None";
            DisplayNameAttribute attribute = type.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute;
            return attribute != null ? attribute.DisplayName : type.Name;
        }
        string ParseStringByLargeTokens(string sourceString) {
            StringBuilder result = new StringBuilder();
            if(sourceString.StartsWith("XY")) {
                result.Append("XY-");
                sourceString = sourceString.Substring(2, sourceString.Length - 2);
            }
            foreach(char symbol in sourceString) {
                if(Char.IsUpper(symbol))
                    result.Append(' ');
                result.Append(symbol);
            }
            return result.ToString();
        }

        public void ApplyAnimation(SeriesViewBase seriesView) {
            TAnimation animation = (TAnimation)Activator.CreateInstance(type);
            animation.Enabled = !isNoneItem;
            ApplyAnimationInternal(animation, (TSeriesView)seriesView);
            if(direction != null) {
                System.Reflection.PropertyInfo directionProperty = type.GetProperty("Direction");
                directionProperty.SetValue(animation, direction, null);
            }
        }
        public abstract void ApplyAnimationInternal(TAnimation animation, TSeriesView seriesView);
        public override string ToString() {
            if(direction == null || isNoneItem)
                return ParseStringByLargeTokens(caption);
            else return ParseStringByLargeTokens(caption) + ParseStringByLargeTokens(direction.ToString());
        }
    }


    class ComboBoxXYSeriesAnimationItem : AnimationComboBoxItem<XYSeriesAnimationBase, XYDiagramSeriesViewBase> {
        public ComboBoxXYSeriesAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(XYSeriesAnimationBase animation, XYDiagramSeriesViewBase seriesView) {
            if(seriesView is LineSeriesView)
                ((LineSeriesView)seriesView).SeriesAnimation = animation;
            if(seriesView is BoxPlotSeriesView)
                ((BoxPlotSeriesView)seriesView).MeanLineAnimation = animation;
        }
    }


    class ComboBoxXYMarkerAnimationItem : AnimationComboBoxItem<XYMarkerAnimationBase, PointSeriesViewBase> {
        public ComboBoxXYMarkerAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(XYMarkerAnimationBase animation, PointSeriesViewBase seriesView) {
            seriesView.SeriesPointAnimation = animation;
        }

    }


    class ComboBoxBarAnimationItem : AnimationComboBoxItem<BarAnimationBase, BarSeriesView> {
        public ComboBoxBarAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(BarAnimationBase animation, BarSeriesView seriesView) {
            seriesView.Animation = animation;
        }
    }


    class ComboBoxPieAnimationItem : AnimationComboBoxItem<PieAnimationBase, PieSeriesView> {
        public ComboBoxPieAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(PieAnimationBase animation, PieSeriesView seriesView) {
            seriesView.Animation = animation;
        }
    }


    class ComboBoxFunnelAnimationItem : AnimationComboBoxItem<FunnelAnimationBase, FunnelSeriesView> {
        public ComboBoxFunnelAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(FunnelAnimationBase animation, FunnelSeriesView seriesView) {
            seriesView.Animation = animation;
        }
    }


    class ComboBoxCircularMarkerAnimationItem : AnimationComboBoxItem<CircularMarkerAnimationBase, RadarSeriesViewBase> {
        public ComboBoxCircularMarkerAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(CircularMarkerAnimationBase animation, RadarSeriesViewBase seriesView) {
            seriesView.SeriesPointAnimation = animation;
        }
    }


    class ComboBoxFinancialPointAnimationItem : AnimationComboBoxItem<FinancialAnimationBase, FinancialSeriesViewBase> {
        public ComboBoxFinancialPointAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(FinancialAnimationBase animation, FinancialSeriesViewBase seriesView) {
            seriesView.Animation = animation;
        }
    }


    class ComboBoxCircularSeriesAnimationItem : AnimationComboBoxItem<CircularSeriesAnimationBase, RadarLineSeriesView> {
        public ComboBoxCircularSeriesAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(CircularSeriesAnimationBase animation, RadarLineSeriesView seriesView) {
            seriesView.SeriesAnimation = animation;
        }
    }


    class ComboBoxBoxPlotAnimationItem : AnimationComboBoxItem<BoxPlotAnimationBase, BoxPlotSeriesView> {
        public ComboBoxBoxPlotAnimationItem(Type type, bool isNoneItem, object direction)
            : base(type, isNoneItem, direction) { }
        public override void ApplyAnimationInternal(BoxPlotAnimationBase animation, BoxPlotSeriesView seriesView) {
            seriesView.Animation = animation;
        }
    }
}
