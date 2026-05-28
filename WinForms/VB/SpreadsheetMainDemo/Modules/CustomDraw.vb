Imports System
Imports System.Drawing
Imports System.Drawing.Text
Imports DevExpress.Skins
Imports DevExpress.Spreadsheet

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class CustomDrawModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Private ReadOnly headers As String() = New String() {"Product Name", "Quantity per Unit", "Unit Price", "Units in Stock"}

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("Products_template.xlsx"))
            AddHandler spreadsheetControl1.CustomDrawColumnHeader, AddressOf SpreadsheetControl1_CustomDrawColumnHeader
            AddHandler spreadsheetControl1.CustomDrawColumnHeaderBackground, AddressOf SpreadsheetControl1_CustomDrawColumnHeaderBackground
            AddHandler spreadsheetControl1.CustomDrawCell, AddressOf SpreadsheetControl1_CustomDrawCell
            AddHandler spreadsheetControl1.CustomDrawCellBackground, AddressOf SpreadsheetControl1_CustomDrawCellBackground
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            spreadsheetControl1.Focus()
        End Sub

        Private Sub SpreadsheetControl1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As CustomDrawColumnHeaderEventArgs)
            e.Handled = True
            If e.ColumnIndex > 3 Then Return
            Dim dpiScale As Single = e.Cache.DeviceDpi / spreadsheetControl1.DpiY
            Dim defaultFont As SpreadsheetFont = spreadsheetControl1.Document.Styles.DefaultStyle.Font
            Using font As Font = New Font(defaultFont.Name, CSng(defaultFont.Size) * dpiScale, FontStyle.Bold)
                Using stringFormat As StringFormat = New StringFormat()
                    stringFormat.LineAlignment = StringAlignment.Center
                    stringFormat.Alignment = If(e.ColumnIndex < 2, StringAlignment.Near, StringAlignment.Far)
                    stringFormat.Trimming = StringTrimming.EllipsisCharacter
                    e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias
                    e.Graphics.DrawString(headers(e.ColumnIndex), font, e.Cache.GetSolidBrush(Color.White), e.Bounds, stringFormat)
                End Using
            End Using
        End Sub

        Private Sub SpreadsheetControl1_CustomDrawColumnHeaderBackground(ByVal sender As Object, ByVal e As CustomDrawColumnHeaderBackgroundEventArgs)
            e.Handled = True
            If e.ColumnIndex <= 3 Then e.Cache.FillRectangle(e.Cache.GetSolidBrush(Color.FromArgb(91, 155, 213)), e.Bounds)
        End Sub

        Private Sub SpreadsheetControl1_CustomDrawCell(ByVal sender As Object, ByVal e As CustomDrawCellEventArgs)
            If e.Cell.ColumnIndex <> 3 Then Return
            Dim unitsInStock As CellValue = e.Cell.Value
            Dim text As String = "OUT OF STOCK"
            If unitsInStock.IsNumeric AndAlso unitsInStock.NumericValue = 0 Then
                Dim dpiScale As Single = e.Cache.DeviceDpi / spreadsheetControl1.DpiY
                Using font As Font = New Font(e.Font.Name, 9F * dpiScale, FontStyle.Bold)
                    Using stringFormat As StringFormat = New StringFormat()
                        stringFormat.LineAlignment = StringAlignment.Center
                        stringFormat.Alignment = StringAlignment.Center
                        Dim size As SizeF = e.Graphics.MeasureString(text, font, Integer.MaxValue, stringFormat)
                        Dim textBounds As Rectangle = New Rectangle(e.Bounds.Right + 15, CInt(Math.Round(e.Bounds.Top + (e.Bounds.Height - size.Height) / 2)), CInt(size.Width + 8), CInt(Math.Round(size.Height)))
                        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias
                        Dim middle As Integer = CInt(Math.Round(textBounds.Height / 2.0))
                        Dim points As Point() = New Point() {New Point(textBounds.Left, textBounds.Top), New Point(textBounds.Left - middle, textBounds.Top + middle), New Point(textBounds.Left, textBounds.Bottom)}
                        Dim brush As Brush = e.Cache.GetSolidBrush(Color.Red)
                        e.Graphics.FillPolygon(brush, points)
                        e.Cache.FillRectangle(brush, textBounds)
                        e.Graphics.DrawString(text, font, e.Cache.GetSolidBrush(Color.White), textBounds, stringFormat)
                    End Using
                End Using
            End If
        End Sub

        Private Sub SpreadsheetControl1_CustomDrawCellBackground(ByVal sender As Object, ByVal e As CustomDrawCellBackgroundEventArgs)
            If e.Cell.ColumnIndex > 3 OrElse e.Cell.RowIndex Mod 2 = 0 Then Return
            Dim dataRange As CellRange = e.Cell.Worksheet.GetDataRange()
            If e.Cell.RowIndex <= dataRange.BottomRowIndex Then
                Dim color As Color = CommonSkins.GetSkin(spreadsheetControl1.LookAndFeel).GetSystemColor(SystemColors.Window)
                e.BackColor = DemoColors.ApplyTint(color, If(color.GetBrightness() > 0.5, -0.05F, 0.05F))
            End If
        End Sub
    End Class
End Namespace
