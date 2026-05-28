Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.TableLayout
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class TileView
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitData()
            SetupView()
            AddHandler rgViewType.SelectedIndexChanged, AddressOf RgViewType_SelectedIndexChanged
            AddHandler toggleSwitch1.EditValueChanged, AddressOf ToggleSwitch1_EditValueChanged
            AddHandler zoomTrackBarControl1.EditValueChanged, AddressOf repositoryItemZoomTrackBar1_EditValueChanged
            tileView1.OptionsBehavior.AllowSmoothScrolling = True
            If MainFormHelper.TakeScreens Then tileView1.AnimateArrival = False
        End Sub

        Private Sub RgViewType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            tileView1.OptionsTiles.Orientation = CType(rgViewType.SelectedIndex, Orientation)
        End Sub

        Private Sub ToggleSwitch1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(toggleSwitch1.EditValue, True) Then
                tileView1.ColumnSet.GroupColumn = tileView1.Columns("YearBuilt")
            Else
                tileView1.ColumnSet.GroupColumn = Nothing
            End If
        End Sub

        Private Sub repositoryItemZoomTrackBar1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim h As Integer = CInt(TryCast(sender, BaseEdit).EditValue)
            Dim w As Integer = CInt(h * 1.78)
            tileView1.OptionsTiles.ItemSize = New Size(w, h)
        End Sub

        Private Sub SetupView()
            Try
                ' Setup tiles options
                tileView1.BeginUpdate()
                tileView1.OptionsTiles.RowCount = 3
                tileView1.OptionsTiles.Padding = New Padding(20)
                tileView1.OptionsTiles.ItemPadding = New Padding(0)
                tileView1.OptionsTiles.IndentBetweenItems = 20
                tileView1.OptionsTiles.ItemSize = New Size(340, 190)
                tileView1.Appearance.ItemNormal.ForeColor = Color.White
                tileView1.Appearance.ItemNormal.BorderColor = Color.Transparent
                'Setup tiles template
                tileView1.TileColumns.Add(New TableColumnDefinition())
                tileView1.TileColumns.Add(New TableColumnDefinition())
                tileView1.TileColumns(0).Length.Value = 0.4
                tileView1.TileColumns(1).Length.Value = 0.6
                Dim splitLine As TileViewItemElement = New TileViewItemElement()
                Dim addressCaption As TileViewItemElement = New TileViewItemElement()
                Dim addressValue As TileViewItemElement = New TileViewItemElement()
                Dim yearBuiltCaption As TileViewItemElement = New TileViewItemElement()
                Dim yearBuiltValue As TileViewItemElement = New TileViewItemElement()
                Dim price As TileViewItemElement = New TileViewItemElement()
                Dim image As TileViewItemElement = New TileViewItemElement()
                tileView1.TileTemplate.Add(splitLine)
                tileView1.TileTemplate.Add(addressCaption)
                tileView1.TileTemplate.Add(addressValue)
                tileView1.TileTemplate.Add(yearBuiltCaption)
                tileView1.TileTemplate.Add(yearBuiltValue)
                tileView1.TileTemplate.Add(price)
                tileView1.TileTemplate.Add(image)
                '
                splitLine.StretchVertical = True
                splitLine.Width = 3
                splitLine.TextAlignment = TileItemContentAlignment.MiddleRight
                splitLine.Appearance.Normal.BackColor = Color.White
                '
                addressCaption.Name = "AddressCaption"
                addressCaption.Text = "ADDRESS"
                addressCaption.TextAlignment = TileItemContentAlignment.TopLeft
                addressCaption.TextLocation = New Point(10, 10)
                addressCaption.Appearance.Normal.FontSizeDelta = -1
                '
                addressValue.Column = tileView1.Columns("Address")
                addressValue.AnchorElement = addressCaption
                addressValue.AnchorIndent = 2
                addressValue.MaxWidth = 100
                addressValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold
                '
                yearBuiltCaption.Name = "YearCaption"
                yearBuiltCaption.Text = "YEAR BUILT"
                yearBuiltCaption.AnchorElement = addressValue
                yearBuiltCaption.AnchorIndent = 14
                yearBuiltCaption.Appearance.Normal.FontSizeDelta = -1
                '
                yearBuiltValue.Column = tileView1.Columns("YearBuilt")
                yearBuiltValue.AnchorElement = yearBuiltCaption
                yearBuiltValue.AnchorIndent = 2
                yearBuiltValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold
                '
                price.Name = "Price"
                price.Column = tileView1.Columns("PriceShort")
                price.TextAlignment = TileItemContentAlignment.BottomLeft
                price.TextLocation = New Point(10, -10)
                price.Appearance.Normal.Font = New Font("Segoe UI Semilight", 25.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
                '
                image.Column = tileView1.Columns("Image")
                image.ColumnIndex = 1
                image.ImageSize = New Size(280, 220)
                image.ImageAlignment = TileItemContentAlignment.MiddleRight
                image.ImageScaleMode = TileItemImageScaleMode.ZoomOutside
                image.ImageLocation = New Point(10, 0)
            Finally
                tileView1.EndUpdate()
            End Try
        End Sub

        Protected Overridable Sub InitData()
            Try
                Dim homesTable = VideoCatalogDataSet().Tables("Homes")
                homesTable.Columns.Add("Image", GetType(Image))
                homesTable.Columns.Add("PriceShort", GetType(String))
                For Each row As DataRow In homesTable.Rows
                    Dim img = XtraEditors.Controls.ByteImageConverter.FromByteArray(TryCast(row("Photo"), Byte()))
                    row("Image") = New Bitmap(img, New Size(351, 234))
                    Dim price As Decimal = CDec(row("Price"))
                    row("PriceShort") = String.Format("${0}M", (price / 1000000).ToString("0.0"))
                Next

                gridControl1.DataSource = homesTable
            Catch
            End Try
        End Sub

        Private Function VideoCatalogDataSet() As DataSet
            Dim ds As DataSet = New DataSet()
            Dim DBFileName As String = DevAVDataDirectoryHelper.GetFile("Homes.xml")
            If Not Equals(DBFileName, String.Empty) Then
                SetWaitDialogCaption(Properties.Resources.LoadingTables)
                ds.ReadXml(DBFileName)
            End If

            Return ds
        End Function

        Private colorPanelReady As Color = Color.FromArgb(58, 166, 101)

        Private colorPanelSold As Color = Color.FromArgb(158, 158, 158)

        Private colorCaptionReady As Color = Color.FromArgb(193, 222, 204)

        Private colorCaptionSold As Color = Color.FromArgb(219, 219, 219)

        Private Sub tileView1_ItemCustomize(ByVal sender As Object, ByVal e As TileViewItemCustomizeEventArgs)
            If e.Item Is Nothing OrElse e.Item.Elements.Count = 0 Then Return
            Dim sold As Boolean = CInt(tileView1.GetRowCellValue(e.RowHandle, tileView1.Columns("Status"))) = 1
            Dim addressCaption = e.Item.GetElementByName("AddressCaption")
            Dim yearCaption = e.Item.GetElementByName("YearCaption")
            Dim price = e.Item.GetElementByName("Price")
            e.Item.AppearanceItem.Normal.BackColor = If(sold, colorPanelSold, colorPanelReady)
            addressCaption.Appearance.Normal.ForeColor = If(sold, colorCaptionSold, colorCaptionReady)
            yearCaption.Appearance.Normal.ForeColor = If(sold, colorCaptionSold, colorCaptionReady)
            If sold Then price.Text = "Sold"
        End Sub
    End Class
End Namespace
