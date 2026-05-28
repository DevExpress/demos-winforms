using System.Collections.Generic;
using System.Data;
using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
using static DevExpress.XtraLayout.Demos.DemosInfo;

namespace DevExpress.XtraLayout.Demos {
    public partial class NewCars : TutorialControl {
        List<Color> FillColors = new List<Color>(new Color[] {
            DXSkinColors.FillColors.Danger,
            DXSkinColors.FillColors.Primary,
            DXSkinColors.FillColors.Question,
            DXSkinColors.FillColors.Success,
            DXSkinColors.FillColors.Warning
        });
        AppearanceObject warningApp;
        SvgBitmap svgBitmap;
        SvgPalette palette;
        public NewCars() {
            InitializeComponent();
            MainFormHelper.UpdateTakeScreenSettings(this);
            InitVehiclesData(vehiclesDataSet);
            InitAllColorPickEdits(true);
            UpdateControlFillColors();
            svgBitmap = SvgBitmap.Create(svgImageCollection1["Warning"]);
            warningApp = new AppearanceObject(Appearance);
            warningApp.FontSizeDelta = 2;
            warningApp.TextOptions.HAlignment = HorzAlignment.Near;
            warningApp.TextOptions.VAlignment = VertAlignment.Center;
            palette = new SvgPalette();
            palette.Colors.Add(new SvgColor("Red", Color.Red));
            LicenseInfo.SetToolTipController(this, layoutGridControl);
        }
        void InitAllColorPickEdits(bool subscribe) {
            InitColorPickEdit(DXSkinColors.FillColors.Danger, 0, colorPickEdit1, subscribe);
            InitColorPickEdit(DXSkinColors.FillColors.Primary, 1, colorPickEdit2, subscribe);
            InitColorPickEdit(DXSkinColors.FillColors.Question, 2, colorPickEdit3, subscribe);
            InitColorPickEdit(DXSkinColors.FillColors.Success, 3, colorPickEdit4, subscribe);
            InitColorPickEdit(DXSkinColors.FillColors.Warning, 4, colorPickEdit5, subscribe);
        }
        void InitColorPickEdit(Color clr, int q, ColorPickEdit colorPickEdit, bool subscribe) {
            colorPickEdit.Properties.AutomaticColor = clr;
            colorPickEdit.EditValue = clr;
            colorPickEdit.Tag = q;
            if(!subscribe) 
                return;
            colorPickEdit.ColorChanged += (s, e) => {
                ColorPickEdit edit = s as ColorPickEdit;
                FillColors[(int)edit.Tag] = edit.Color;
                UpdateControlFillColors();
                Refresh();
            };
        }
        void layoutControlGroup2_CustomButtonClick(object sender, XtraBars.Docking2010.BaseButtonEventArgs e) {
            InitAllColorPickEdits(false);
        }
        void layoutView1_CustomCardStyle(object sender, XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventArgs e) {
            var row = (layoutView1.GetRow(e.RowHandle) as DataRowView).Row as VehiclesDataSet.ModelRow;
            e.Appearance.BorderColor = row.InStock ? FillColors[3] : FillColors[4];
        }
        void layoutView1_FocusedRowObjectChanged(object sender, XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e) {
            if(e.Row == null) 
                return;
            VehiclesDataSet.ModelRow modelRow = (e.Row as DataRowView).Row as VehiclesDataSet.ModelRow;
            layoutControlGroup4.Text = modelRow.InStock ? "In stock" : "Sold out";
            layoutControlGroup4.AppearanceGroup.BorderColor = modelRow.InStock ? FillColors[3] : FillColors[4];
        }
        void UpdateControlFillColors() {
            saveSimpleButton.Appearance.BackColor = FillColors[3];
            deleteSimpleButton.Appearance.BackColor = FillColors[0];
            perfomanceLayoutGroup.AppearanceTabPage.Header.BackColor = FillColors[2];
            layoutControlGroup4.AppearanceGroup.BorderColor = FillColors[4];
            DataRowView dataRowView = layoutView1.GetFocusedRow() as DataRowView;
            if(dataRowView == null) 
                return;
            VehiclesDataSet.ModelRow row = dataRowView.Row as VehiclesDataSet.ModelRow;
            if(row == null) 
                return;
            layoutControlGroup4.AppearanceGroup.BorderColor = row.InStock ? FillColors[3] : FillColors[4];
        }
        void emptySpaceItem8_CustomDraw(object sender, ItemCustomDrawEventArgs e) {
            DataRowView dataRowView = layoutView1.GetFocusedRow() as DataRowView;
            if(dataRowView == null) 
                return;
            VehiclesDataSet.ModelRow row = dataRowView.Row as VehiclesDataSet.ModelRow;
            if(row == null || row.InStock) 
                return;
            warningApp.BackColor = FillColors[4];
            warningApp.ForeColor = ContrastColor.GetContrastForeColor(warningApp.GetBackColor(LookAndFeel));
            warningApp.DrawBackground(e.Cache, e.ViewInfo.TextAreaRelativeToControl);
            Rectangle textAreaRelativeToControl = e.ViewInfo.TextAreaRelativeToControl;
            textAreaRelativeToControl.X += ScaleHelper.ScaleHorizontal(12);
            textAreaRelativeToControl.Width -= ScaleHelper.ScaleHorizontal(12);
            palette.CustomColor = warningApp.ForeColor;
            Image render = svgBitmap.Render(palette);
            Point imageLocation = new Point(textAreaRelativeToControl.X, textAreaRelativeToControl.Y + (textAreaRelativeToControl.Height - render.Height) / 2);
            e.Cache.DrawImage(render, imageLocation);
            textAreaRelativeToControl.X += render.Width + ScaleHelper.ScaleHorizontal(8);
            textAreaRelativeToControl.Width -= render.Width + ScaleHelper.ScaleHorizontal(8);
            warningApp.DrawString(e.Cache, "Out of Stock", textAreaRelativeToControl);
        }
    }
}
