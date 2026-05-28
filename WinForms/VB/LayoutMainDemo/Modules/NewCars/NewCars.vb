Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.Utils.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Demos.DemosInfo

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class NewCars
        Inherits TutorialControl

        Private FillColors As List(Of Color) = New List(Of Color)(New Color() {DXSkinColors.FillColors.Danger, DXSkinColors.FillColors.Primary, DXSkinColors.FillColors.Question, DXSkinColors.FillColors.Success, DXSkinColors.FillColors.Warning})

        Private warningApp As AppearanceObject

        Private svgBitmap As SvgBitmap

        Private palette As SvgPalette

        Public Sub New()
            InitializeComponent()
            Call MainFormHelper.UpdateTakeScreenSettings(Me)
            InitVehiclesData(vehiclesDataSet)
            InitAllColorPickEdits(True)
            UpdateControlFillColors()
            svgBitmap = SvgBitmap.Create(svgImageCollection1("Warning"))
            warningApp = New AppearanceObject(Appearance)
            warningApp.FontSizeDelta = 2
            warningApp.TextOptions.HAlignment = HorzAlignment.Near
            warningApp.TextOptions.VAlignment = VertAlignment.Center
            palette = New SvgPalette()
            palette.Colors.Add(New SvgColor("Red", Color.Red))
            Call LicenseInfo.SetToolTipController(Me, layoutGridControl)
        End Sub

        Private Sub InitAllColorPickEdits(ByVal subscribe As Boolean)
            InitColorPickEdit(DXSkinColors.FillColors.Danger, 0, colorPickEdit1, subscribe)
            InitColorPickEdit(DXSkinColors.FillColors.Primary, 1, colorPickEdit2, subscribe)
            InitColorPickEdit(DXSkinColors.FillColors.Question, 2, colorPickEdit3, subscribe)
            InitColorPickEdit(DXSkinColors.FillColors.Success, 3, colorPickEdit4, subscribe)
            InitColorPickEdit(DXSkinColors.FillColors.Warning, 4, colorPickEdit5, subscribe)
        End Sub

        Private Sub InitColorPickEdit(ByVal clr As Color, ByVal q As Integer, ByVal colorPickEdit As ColorPickEdit, ByVal subscribe As Boolean)
            colorPickEdit.Properties.AutomaticColor = clr
            colorPickEdit.EditValue = clr
            colorPickEdit.Tag = q
            If Not subscribe Then Return
            AddHandler colorPickEdit.ColorChanged, Sub(s, e)
                Dim edit As ColorPickEdit = TryCast(s, ColorPickEdit)
                FillColors(CInt(edit.Tag)) = edit.Color
                UpdateControlFillColors()
                Refresh()
            End Sub
        End Sub

        Private Sub layoutControlGroup2_CustomButtonClick(ByVal sender As Object, ByVal e As XtraBars.Docking2010.BaseButtonEventArgs)
            InitAllColorPickEdits(False)
        End Sub

        Private Sub layoutView1_CustomCardStyle(ByVal sender As Object, ByVal e As XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventArgs)
            Dim row = TryCast(TryCast(layoutView1.GetRow(e.RowHandle), DataRowView).Row, VehiclesDataSet.ModelRow)
            e.Appearance.BorderColor = If(row.InStock, FillColors(3), FillColors(4))
        End Sub

        Private Sub layoutView1_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs)
            If e.Row Is Nothing Then Return
            Dim modelRow As VehiclesDataSet.ModelRow = TryCast(TryCast(e.Row, DataRowView).Row, VehiclesDataSet.ModelRow)
            layoutControlGroup4.Text = If(modelRow.InStock, "In stock", "Sold out")
            layoutControlGroup4.AppearanceGroup.BorderColor = If(modelRow.InStock, FillColors(3), FillColors(4))
        End Sub

        Private Sub UpdateControlFillColors()
            saveSimpleButton.Appearance.BackColor = FillColors(3)
            deleteSimpleButton.Appearance.BackColor = FillColors(0)
            perfomanceLayoutGroup.AppearanceTabPage.Header.BackColor = FillColors(2)
            layoutControlGroup4.AppearanceGroup.BorderColor = FillColors(4)
            Dim dataRowView As DataRowView = TryCast(layoutView1.GetFocusedRow(), DataRowView)
            If dataRowView Is Nothing Then Return
            Dim row As VehiclesDataSet.ModelRow = TryCast(dataRowView.Row, VehiclesDataSet.ModelRow)
            If row Is Nothing Then Return
            layoutControlGroup4.AppearanceGroup.BorderColor = If(row.InStock, FillColors(3), FillColors(4))
        End Sub

        Private Sub emptySpaceItem8_CustomDraw(ByVal sender As Object, ByVal e As ItemCustomDrawEventArgs)
            Dim dataRowView As DataRowView = TryCast(layoutView1.GetFocusedRow(), DataRowView)
            If dataRowView Is Nothing Then Return
            Dim row As VehiclesDataSet.ModelRow = TryCast(dataRowView.Row, VehiclesDataSet.ModelRow)
            If row Is Nothing OrElse row.InStock Then Return
            warningApp.BackColor = FillColors(4)
            warningApp.ForeColor = ContrastColor.GetContrastForeColor(warningApp.GetBackColor(LookAndFeel))
            warningApp.DrawBackground(e.Cache, e.ViewInfo.TextAreaRelativeToControl)
            Dim textAreaRelativeToControl As Rectangle = e.ViewInfo.TextAreaRelativeToControl
            textAreaRelativeToControl.X += ScaleHelper.ScaleHorizontal(12)
            textAreaRelativeToControl.Width -= ScaleHelper.ScaleHorizontal(12)
            palette.CustomColor = warningApp.ForeColor
            Dim render As Image = svgBitmap.Render(palette)
            Dim imageLocation As Point = New Point(textAreaRelativeToControl.X, textAreaRelativeToControl.Y + (textAreaRelativeToControl.Height - render.Height) \ 2)
            e.Cache.DrawImage(render, imageLocation)
            textAreaRelativeToControl.X += render.Width + ScaleHelper.ScaleHorizontal(8)
            textAreaRelativeToControl.Width -= render.Width + ScaleHelper.ScaleHorizontal(8)
            warningApp.DrawString(e.Cache, "Out of Stock", textAreaRelativeToControl)
        End Sub
    End Class
End Namespace
