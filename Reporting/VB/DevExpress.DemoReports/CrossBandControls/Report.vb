Imports System.Drawing
Imports DevExpress.Drawing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.CrossBandControls

    Public Partial Class Report
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.CrossBandsName
            DisplayName = ReportNames.CrossBands
            AddHandler BeforePrint, AddressOf Report_BeforePrint
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            SetFillEmptySpace()
        End Sub

        Public Sub SetFillEmptySpace()
            If CBool(DrawZBelowTheTableParameter.Value) Then
                GroupFooter1.PrintAtBottom = False
                AddHandler FillEmptySpace, AddressOf report_FillEmptySpace
            Else
                GroupFooter1.PrintAtBottom = True
                RemoveHandler FillEmptySpace, AddressOf report_FillEmptySpace
            End If
        End Sub

        Private Sub report_FillEmptySpace(ByVal sender As Object, ByVal e As BandEventArgs)
            If Not CBool(DrawZBelowTheTableParameter.Value) Then
                RemoveHandler FillEmptySpace, AddressOf report_FillEmptySpace
                Return
            End If

            Dim bandHeight As Integer = GraphicsUnitConverter.Convert(e.Band.Height, ReportUnit.ToDpi(), ReportUnit.HundredthsOfAnInch.ToDpi())
            If bandHeight <= 30 Then Return
            Dim size As Size = New Size(612, bandHeight - 30)
            Dim sizeInPixels As Size = GraphicsUnitConverter.Convert(size, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)
            Dim zBitmap As DXBitmap = New DXBitmap(sizeInPixels.Width, sizeInPixels.Height)
            Dim gr As DXGraphics = DXGraphics.FromImage(zBitmap)
            Using pen As DXPen = New DXPen(Color.FromArgb(205, 205, 205), 4)
                Dim points As Point() = New Point() {New Point(0, 4), New Point(sizeInPixels.Width, 4), New Point(0, sizeInPixels.Height - 4), New Point(sizeInPixels.Width, sizeInPixels.Height - 4)}
                gr.DrawLines(pen, points)
            End Using

            Dim pictureBox As XRPictureBox = New XRPictureBox()
            pictureBox.BackColor = Color.Transparent
            pictureBox.Size = size
            pictureBox.Location = New Point(19, 15)
            pictureBox.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource(zBitmap)
            e.Band.Controls.Add(pictureBox)
        End Sub
    End Class
End Namespace
