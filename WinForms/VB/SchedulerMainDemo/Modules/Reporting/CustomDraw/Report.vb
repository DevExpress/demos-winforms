Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports System.Drawing
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Native
Imports System.Drawing.Drawing2D
Imports DevExpress.Utils.Controls
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos.Reporting.CustomDraw

    ''' <summary>
    ''' Summary description for Report.
    ''' </summary>
    Public Partial Class Report
        Inherits XtraSchedulerReport

        Private carUsageImages As ImageCollection

        Private _allowCustomDrawDayHeader As Boolean

        Private _allowCustomDrawResourceHeader As Boolean

        Private _allowCustomDrawAllDayArea As Boolean

        Private _allowCustomDrawTimeCell As Boolean

        Private _allowCustomDrawTimeRuler As Boolean

        Private _allowCustomDrawAppointment As Boolean

        Private _allowCustomDrawAppointmentBackground As Boolean

        Public Sub New()
            carUsageImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.car_usage_types.png"), Reflection.Assembly.GetExecutingAssembly(), New Size(16, 16))
            InitializeComponent()
        End Sub

        Public Property AllowCustomDrawDayHeader As Boolean
            Get
                Return _allowCustomDrawDayHeader
            End Get

            Set(ByVal value As Boolean)
                _allowCustomDrawDayHeader = value
            End Set
        End Property

        Public Property AllowCustomDrawResourceHeader As Boolean
            Get
                Return _allowCustomDrawResourceHeader
            End Get

            Set(ByVal value As Boolean)
                _allowCustomDrawResourceHeader = value
            End Set
        End Property

        Public Property AllowCustomDrawAllDayArea As Boolean
            Get
                Return _allowCustomDrawAllDayArea
            End Get

            Set(ByVal value As Boolean)
                _allowCustomDrawAllDayArea = value
            End Set
        End Property

        Public Property AllowCustomDrawTimeCell As Boolean
            Get
                Return _allowCustomDrawTimeCell
            End Get

            Set(ByVal value As Boolean)
                _allowCustomDrawTimeCell = value
            End Set
        End Property

        Public Property AllowCustomDrawTimeRuler As Boolean
            Get
                Return _allowCustomDrawTimeRuler
            End Get

            Set(ByVal value As Boolean)
                _allowCustomDrawTimeRuler = value
            End Set
        End Property

        Public Property AllowCustomDrawAppointment As Boolean
            Get
                Return _allowCustomDrawAppointment
            End Get

            Set(ByVal value As Boolean)
                _allowCustomDrawAppointment = value
            End Set
        End Property

        Public Property AllowCustomDrawAppointmentBackground As Boolean
            Get
                Return _allowCustomDrawAppointmentBackground
            End Get

            Set(ByVal value As Boolean)
                _allowCustomDrawAppointmentBackground = value
            End Set
        End Property

        Private Sub dayViewTimeCells1_CustomDrawTimeCell(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not AllowCustomDrawTimeCell Then Return
            Dim cell As TimeCell = CType(e.ObjectInfo, TimeCell)
            Dim rect As Rectangle = e.Bounds
            rect.Height = 1
            rect.Offset(0, rect.Height - 1)
            e.Cache.DrawRectangle(Pens.Gray, rect)
            If TypeOf cell Is ExtendedCell Then
                Dim schema As SchedulerColorSchema = GetResourceColorSchema(cell.Resource)
                cell.Appearance.BackColor = Color.White
                cell.Appearance.BackColor2 = schema.CellLight
                e.DrawDefault()
            Else
                Using sf As StringFormat = New StringFormat()
                    sf.Alignment = StringAlignment.Far
                    rect = cell.Bounds
                    rect.Inflate(-10, 0)
                    e.Cache.DrawString(cell.Interval.Start.ToShortTimeString(), e.Cache.GetFont(cell.Appearance.Font, FontStyle.Regular), e.Cache.GetSolidBrush(Color.Gray), rect, sf)
                End Using
            End If

            e.Handled = True
        End Sub

        Private Sub dayViewTimeRuler1_CustomDrawDayViewTimeRuler(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not AllowCustomDrawTimeRuler Then Return
            e.Cache.FillRectangle(e.Cache.GetSolidBrush(Color.LightYellow), e.Bounds)
            Using sf As StringFormat = New StringFormat()
                sf.Alignment = StringAlignment.Center
                sf.LineAlignment = StringAlignment.Center
                e.Cache.DrawVString(TimeZoneInfo.Local.DisplayName, e.Cache.GetFont(New Font(Font.Name, 20, FontStyle.Bold), FontStyle.Bold), e.Cache.GetSolidBrush(Color.Gray), e.Bounds, sf, -90)
                e.Handled = True
            End Using
        End Sub

        Private Sub horizontalResourceHeaders1_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not AllowCustomDrawResourceHeader Then Return
            Dim header As ResourceHeader = CType(e.ObjectInfo, ResourceHeader)
            DrawHeaderUsingColorSchema(header, e.Cache)
            e.DrawDefault()
            e.Handled = True
        End Sub

        Private Sub horizontalDateHeaders1_CustomDrawDayHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not AllowCustomDrawDayHeader Then Return
            Dim header As DayHeader = CType(e.ObjectInfo, DayHeader)
            DrawHeaderUsingColorSchema(header, e.Cache)
            e.DrawDefault()
            e.Handled = True
        End Sub

        Private Sub DrawHeaderUsingColorSchema(ByVal header As SchedulerHeader, ByVal cache As DevExpress.Utils.Drawing.GraphicsCache)
            Dim schema As SchedulerColorSchema = GetResourceColorSchema(header.Resource)
            header.Appearance.HeaderCaption.BackColor = schema.CellLight
            header.Appearance.HeaderCaption.BackColor2 = schema.Cell
            Dim color As Color = schema.CellBorderDark
            header.Appearance.HeaderCaption.ForeColor = TransformColor(color, 0.6)
            header.Appearance.HeaderCaption.Font = cache.GetFont(header.Appearance.HeaderCaption.Font, FontStyle.Bold)
        End Sub

        Private Function TransformColor(ByVal color As Color, ByVal light As Double) As Color
            Return Color.FromArgb(CInt(color.R * light), CInt(color.G * light), CInt(color.B * light))
        End Function

        Private Sub dayViewTimeCells1_CustomDrawDayViewAllDayArea(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not AllowCustomDrawAllDayArea Then Return
            Dim cell As AllDayAreaCell = CType(e.ObjectInfo, AllDayAreaCell)
            Dim schema As SchedulerColorSchema = GetResourceColorSchema(cell.Resource)
            cell.Appearance.BackColor = schema.Cell
            cell.Appearance.BackColor2 = schema.CellBorder
        End Sub

        Private Sub dayViewTimeCells1_CustomDrawAppointmentBackground(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not AllowCustomDrawAppointmentBackground Then Return
            e.DrawDefault()
            Dim vi As AppointmentViewInfo = CType(e.ObjectInfo, AppointmentViewInfo)
            Dim rect As Rectangle = vi.Bounds
            rect.Inflate(-vi.LeftBorderBounds.Width, -vi.TopBorderBounds.Height)
            Dim brush As Brush = e.Cache.GetGradientBrush(rect, Color.White, vi.Appearance.BackColor, LinearGradientMode.Vertical)
            e.Cache.FillRectangle(brush, rect)
            e.Handled = True
        End Sub

        Private Sub dayViewTimeCells1_CustomDrawAppointment(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not AllowCustomDrawAppointment Then Return
            Dim vi As AppointmentViewInfo = CType(e.ObjectInfo, AppointmentViewInfo)
            Dim imgRect As Rectangle = RectUtils.CutFromLeft(vi.InnerBounds, vi.InnerBounds.Width - 18)
            imgRect = RectUtils.AlignRectangle(New Rectangle(0, 0, 16, 16), imgRect, ContentAlignment.MiddleCenter)
            e.Cache.DrawImage(carUsageImages.Images(CInt(vi.Appointment.StatusKey)), imgRect)
            Dim textRect As Rectangle = RectUtils.CutFromRight(vi.InnerBounds, 18)
            Using sf As StringFormat = New StringFormat()
                Dim brush As Brush = e.Cache.GetSolidBrush(vi.Appearance.ForeColor)
                Dim fntBold As Font = e.Cache.GetFont(vi.Appearance.Font, FontStyle.Bold)
                Dim fntItalic As Font = e.Cache.GetFont(vi.Appearance.Font, FontStyle.Italic)
                If vi.Appointment.LongerThanADay Then
                    Dim rowRects As Rectangle() = RectUtils.SplitHorizontally(textRect, 2)
                    Dim hours As String = String.Format(" [{0:F2} h]", vi.AppointmentInterval.Duration.TotalHours)
                    e.Cache.DrawString(vi.DisplayText & hours, fntBold, brush, textRect, sf)
                Else
                    Dim rects As Rectangle() = RectUtils.SplitVertically(textRect, 3)
                    e.Cache.DrawString(vi.Interval.Start.ToShortTimeString() & " " & vi.Interval.End.ToShortTimeString(), vi.Appearance.Font, brush, rects(0), sf)
                    e.Cache.DrawString(String.Format("{0} [{1}]", vi.Appointment.Subject, vi.Appointment.Location), fntBold, brush, rects(1), sf)
                    e.Cache.DrawString(vi.Description, fntItalic, brush, rects(2), sf)
                End If
            End Using

            e.Handled = True
        End Sub
    End Class
End Namespace
