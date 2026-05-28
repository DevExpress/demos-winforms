using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Annotations;

namespace DevExpress.XtraTreeList.Demos.Options {
    public partial class ucScrollAnnotationsOptions : ucDefault {
        public ucScrollAnnotationsOptions() {
            InitializeComponent();
            stylesSource.DataSource = style;
        }
        readonly AnnotationsStyle style = new AnnotationsStyle();
        public bool BookmarksEnabled {
            get { return ceBookmarksEnabled.Checked; }
        }
        public Color GetColor(ScrollAnnotationKind kind) {
            return style.GetColor(kind);
        }
        //<ucScrollAnnotationsOptions>
        void OnAnnotationsEnabledChanged(object sender, EventArgs e) {
            bool _enabled = ((CheckEdit)sender).Checked;
            DefaultBoolean _show = _enabled ? DefaultBoolean.True : DefaultBoolean.False;
            if(TreeList == null) return;
            if(sender == ceErrorsEnabled) {
                layoutControlItemForErrors.Enabled = _enabled;
                TreeList.OptionsScrollAnnotations.ShowErrors = _show;
            }
            if(sender == ceFocusedEnabled) {
                layoutControlItemForFocused.Enabled = _enabled;
                TreeList.OptionsScrollAnnotations.ShowFocusedRow = _show;
            }
            if(sender == ceBookmarksEnabled)
                TreeList.OptionsScrollAnnotations.ShowCustomAnnotations = _show;
        }
        void OnAnnotationsStyleChanged(object sender, ListChangedEventArgs e) {
            if(e.ListChangedType == ListChangedType.ItemChanged)
                TreeList.InvalidateScrollAnnotations();
        }
        //</ucScrollAnnotationsOptions>
    }
    public class AnnotationsStyle {
        readonly IDictionary<ScrollAnnotationKind, Color> colors = new Dictionary<ScrollAnnotationKind, Color>();
        public Color ErrorsColor {
            get { return GetColor(ScrollAnnotationKind.Errors); }
            set { colors[ScrollAnnotationKind.Errors] = value; }
        }
        public Color SearchResultsColor {
            get { return GetColor(ScrollAnnotationKind.SearchResults); }
            set { colors[ScrollAnnotationKind.SearchResults] = value; }
        }
        public Color FocusColor {
            get { return GetColor(ScrollAnnotationKind.FocusedRow); }
            set { colors[ScrollAnnotationKind.FocusedRow] = value; }
        }
        public Color GetColor(ScrollAnnotationKind kind) {
            Color color;
            return colors.TryGetValue(kind, out color) ? color : Color.Empty;
        }
    }
}
