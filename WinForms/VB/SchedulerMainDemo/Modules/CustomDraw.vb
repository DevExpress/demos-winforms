Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraScheduler.Native

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class CustomDrawModule
        Inherits TutorialControl

        Private carUsageImages As ImageCollection

        Private hatchBrush As Brush = Nothing

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            carUsageImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.car_usage_types.png"), Reflection.Assembly.GetExecutingAssembly(), New Size(16, 16))
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Public ReadOnly Property SchedulerAppearances As BaseAppearanceCollection
            Get
                Return schedulerControl.Appearance
            End Get
        End Property

        Private Sub DayViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            DemoUtils.FillAppointmentStatuses(schedulerStorage)
            FillData(schedulerControl, schedulerStorage)
            UpdateControls()
        End Sub

        Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateControls()
        End Sub

        Private Sub UpdateControls()
            Dim view As SchedulerViewBase = schedulerControl.ActiveView
            Dim grType As SchedulerGroupType = schedulerControl.GroupType
            Dim isAgendaView As Boolean = TypeOf view Is AgendaView
            chkDayViewAllDayArea.Enabled = TypeOf view Is DayView
            chkWeekViewTopLeftCorner.Enabled = TypeOf view Is WeekView AndAlso grType.Equals(SchedulerGroupType.Date) OrElse TypeOf view Is TimelineView AndAlso Not grType.Equals(SchedulerGroupType.None)
            chkGroupSeparator.Enabled = Not grType.Equals(SchedulerGroupType.None) AndAlso Not isAgendaView
            chkResourceHeader.Enabled = Not grType.Equals(SchedulerGroupType.None) AndAlso Not isAgendaView
            chkDayOfWeekHeader.Enabled = TypeOf view Is WeekView AndAlso grType.Equals(SchedulerGroupType.Date) OrElse TypeOf view Is MonthView AndAlso Not grType.Equals(SchedulerGroupType.None)
            chkTimeCell.Enabled = Not isAgendaView
        End Sub

        Private Sub schedulerControl_CustomDrawAppointment(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            Dim cache As GraphicsCache = e.Cache
            If Not chkAppointment.Checked Then Return
            Dim vi As AppointmentViewInfo = TryCast(e.ObjectInfo, AppointmentViewInfo)
            If vi Is Nothing Then Return
            Dim imgRect As Rectangle = RectUtils.CutFromLeft(vi.InnerBounds, vi.InnerBounds.Width - 18)
            imgRect = RectUtils.AlignRectangle(New Rectangle(0, 0, 16, 16), imgRect, ContentAlignment.MiddleCenter)
            cache.DrawImage(carUsageImages.Images(CInt(vi.Appointment.StatusKey)), imgRect)
            Dim textRect As Rectangle = RectUtils.CutFromRight(vi.InnerBounds, 18)
            vi.Appearance.DrawString(cache, vi.DisplayText, textRect, vi.Appearance.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis))
            If schedulerControl.ActiveViewType = SchedulerViewType.Agenda AndAlso vi.Selected Then cache.DrawRectangle(Pens.Black, e.Bounds)
            e.Handled = True
        End Sub

        Private Sub schedulerControl_CustomDrawAppointmentBackground(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not chkAppointmentBackground.Checked Then Return
            Dim aptViewInfo As AppointmentViewInfo = TryCast(e.ObjectInfo, AppointmentViewInfo)
            If aptViewInfo Is Nothing Then Return
            Dim cache As GraphicsCache = e.Cache
            Dim r As Rectangle = e.Bounds
            FillRoundedRect(cache, GetStatusBrush(aptViewInfo.Status), r, 5)
            r.Inflate(-3, -3)
            Dim br As Brush = cache.GetSolidBrush(schedulerStorage.GetLabelColor(aptViewInfo.Appointment.LabelKey))
            FillRoundedRect(cache, br, r, 5)
            e.Handled = True
        End Sub

        Private Function GetStatusBrush(ByVal status As IAppointmentStatus) As Brush
            If status.Type = AppointmentStatusType.Tentative Then
                If hatchBrush Is Nothing Then hatchBrush = New HatchBrush(HatchStyle.WideUpwardDiagonal, DXColor.White, CType(status.GetBrush(), SolidBrush).Color)
                Return hatchBrush
            End If

            Return status.GetBrush()
        End Function

        Private Sub FillRoundedRect(ByVal cache As GraphicsCache, ByVal br As Brush, ByVal r As Rectangle, ByVal roundRadius As Integer)
            cache.FillPath(br, CreateRoundedRectPath(r, roundRadius))
        End Sub

        Private Sub schedulerControl_CustomDrawTimeCell(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not chkTimeCell.Checked Then Return
            Dim viewInfo As SelectableIntervalViewInfo = TryCast(e.ObjectInfo, SelectableIntervalViewInfo)
            Dim cell As SchedulerViewCellBase = TryCast(e.ObjectInfo, SchedulerViewCellBase)
            Dim cache As GraphicsCache = e.Cache
            If viewInfo.Selected Then
                cache.FillRectangle(SystemBrushes.Highlight, cell.Bounds)
            Else
                FillGradient(cache, cell.Bounds, Color.FromArgb(165, 203, 141), Color.FromArgb(185, 233, 181), 45)
            End If

            e.Handled = True
        End Sub

        Private Sub FillGradient(ByVal cache As GraphicsCache, ByVal r As Rectangle, ByVal c1 As Color, ByVal c2 As Color, ByVal angle As Integer)
            If r.Width <= 0 OrElse r.Height <= 0 Then Return
            Using br As LinearGradientBrush = New LinearGradientBrush(r, c1, c2, angle)
                cache.FillRectangle(br, r)
            End Using
        End Sub

        Shared Public Function CreateRoundedRectPath(ByVal r As Rectangle, ByVal radius As Integer) As GraphicsPath
            Dim path As GraphicsPath = New GraphicsPath()
            path.AddLine(r.Left + radius, r.Top, r.Left + r.Width - radius * 2, r.Top)
            path.AddArc(r.Left + r.Width - radius * 2, r.Top, radius * 2, radius * 2, 270, 90)
            path.AddLine(r.Left + r.Width, r.Top + radius, r.Left + r.Width, r.Top + r.Height - radius * 2)
            path.AddArc(r.Left + r.Width - radius * 2, r.Top + r.Height - radius * 2, radius * 2, radius * 2, 0, 90)
            path.AddLine(r.Left + r.Width - radius * 2, r.Top + r.Height, r.Left + radius, r.Top + r.Height)
            path.AddArc(r.Left, r.Top + r.Height - radius * 2, radius * 2, radius * 2, 90, 90)
            path.AddLine(r.Left, r.Top + r.Height - radius * 2, r.Left, r.Top + radius)
            path.AddArc(r.Left, r.Top, radius * 2, radius * 2, 180, 90)
            path.CloseFigure()
            Return path
        End Function

        Private Sub schedulerControl_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not chkResourceHeader.Checked Then Return
            Dim header As SchedulerHeader = TryCast(e.ObjectInfo, SchedulerHeader)
            Dim app As AppearanceObject = header.Appearance.HeaderCaption
            Dim grType As SchedulerGroupType = schedulerControl.ActiveView.GroupType
            Dim vertLayout As Boolean = TypeOf schedulerControl.ActiveView Is WeekView AndAlso grType.Equals(SchedulerGroupType.Date) OrElse TypeOf schedulerControl.ActiveView Is TimelineView AndAlso Not grType.Equals(SchedulerGroupType.None)
            Dim gradientMode As LinearGradientMode = If(vertLayout, LinearGradientMode.Horizontal, LinearGradientMode.Vertical)
            Dim cache As GraphicsCache = e.Cache
            cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(206, 188, 239), Color.FromArgb(156, 138, 189), gradientMode), e.Bounds)
            Dim innerRect As Rectangle = Rectangle.Inflate(e.Bounds, -2, -2)
            cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(156, 138, 189), Color.FromArgb(206, 188, 239), gradientMode), innerRect)
            Dim sf As StringFormat = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis)
            If vertLayout Then
                cache.DrawVString(header.Caption, app.Font, app.GetForeBrush(e.Cache), innerRect, sf, 270)
            Else
                cache.DrawString(header.Caption, app.Font, app.GetForeBrush(e.Cache), innerRect, sf)
            End If

            e.Handled = True
        End Sub

        Private Sub schedulerControl_CustomDrawWeekViewTopLeftCorner(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not chkWeekViewTopLeftCorner.Checked Then Return
            Dim cache As GraphicsCache = e.Cache
            cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(176, 158, 209), Color.FromArgb(146, 128, 179), LinearGradientMode.Vertical), e.Bounds)
            Dim innerRect As Rectangle = Rectangle.Inflate(e.Bounds, -2, -2)
            cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(146, 128, 179), Color.FromArgb(176, 158, 209), LinearGradientMode.Vertical), innerRect)
            e.Handled = True
        End Sub

        Private Sub schedulerControl_CustomDrawDayHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not chkDayHeader.Checked Then Return
            Dim header As SchedulerHeader = TryCast(e.ObjectInfo, SchedulerHeader)
            Dim app As AppearanceObject = header.Appearance.HeaderCaption
            Dim cache As GraphicsCache = e.Cache
            If e.Bounds.Height > 0 AndAlso e.Bounds.Width > 0 Then
                cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(175, 231, 228), Color.FromArgb(125, 181, 178), LinearGradientMode.Vertical), e.Bounds)
                Dim innerRect As Rectangle = Rectangle.Inflate(e.Bounds, -2, -2)
                cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(125, 181, 178), Color.FromArgb(175, 231, 228), LinearGradientMode.Vertical), innerRect)
                Dim sf As StringFormat = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis)
                cache.DrawString(header.Caption, app.Font, New SolidBrush(Color.Black), innerRect, sf)
            End If

            e.Handled = True
        End Sub

        Private Sub schedulerControl_CustomDrawDayOfWeekHeader(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not chkDayOfWeekHeader.Checked Then Return
            Dim header As SchedulerHeader = TryCast(e.ObjectInfo, SchedulerHeader)
            Dim app As AppearanceObject = header.Appearance.HeaderCaption
            Dim cache As GraphicsCache = e.Cache
            cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(145, 181, 198), Color.FromArgb(95, 131, 148), LinearGradientMode.Vertical), e.Bounds)
            Dim innerRect As Rectangle = Rectangle.Inflate(e.Bounds, -2, -2)
            cache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.FromArgb(95, 131, 148), Color.FromArgb(145, 181, 198), LinearGradientMode.Vertical), innerRect)
            Dim sf As StringFormat = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis)
            cache.DrawString(header.Caption, app.Font, Color.White, innerRect, sf)
            e.Handled = True
        End Sub

        Private Sub schedulerControl_CustomDrawGroupSeparator(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not chkGroupSeparator.Checked Then Return
            Dim c As Color = Color.FromArgb(&HC4, &HA6, &HF4)
            Dim cache As GraphicsCache = e.Cache
            FillGradient(cache, e.Bounds, Color.FromArgb(&HE0, &HCF, &HE9), c, 45)
            cache.DrawRectangle(cache.GetPen(c), e.Bounds)
            e.Handled = True
        End Sub

        Private Sub schedulerControl_CustomDrawDayViewAllDayArea(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not chkDayViewAllDayArea.Checked Then Return
            Dim cache As GraphicsCache = e.Cache
            Dim viewInfo As SelectableIntervalViewInfo = TryCast(e.ObjectInfo, SelectableIntervalViewInfo)
            If viewInfo IsNot Nothing AndAlso viewInfo.Selected Then
                cache.FillRectangle(SystemBrushes.Highlight, e.Bounds)
                DrawAllDayAreaCaption(e, SystemBrushes.HighlightText)
            Else
                FillGradient(cache, e.Bounds, Color.FromArgb(215, 233, 171), Color.FromArgb(185, 203, 141), 90)
                DrawAllDayAreaCaption(e, Brushes.Black)
            End If

            e.Handled = True
        End Sub

        Private Sub DrawAllDayAreaCaption(ByVal e As CustomDrawObjectEventArgs, ByVal br As Brush)
            Dim app As AppearanceObject = schedulerControl.Appearance.HeaderCaption
            Dim sf As StringFormat = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis)
            e.Cache.DrawString("All Day Events", schedulerControl.DayView.Appearance.AllDayArea.Font, br, e.Bounds, sf)
        End Sub

        Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.ActiveView.LayoutChanged()
        End Sub

        Private Sub schedulerControl_CustomDrawNavigationButton(ByVal sender As Object, ByVal e As CustomDrawObjectEventArgs)
            If Not chkNavigationButton.Checked Then Return
            Dim button As NavigationButton = TryCast(e.ObjectInfo, NavigationButton)
            Dim bgBrush As Brush
            If button.Enabled Then
                If button.HotTracked Then
                    bgBrush = New LinearGradientBrush(e.Bounds, Color.FromArgb(100, 200, 150), Color.FromArgb(150, 240, 150), LinearGradientMode.Horizontal)
                Else
                    bgBrush = New LinearGradientBrush(e.Bounds, Color.FromArgb(100, 180, 150), Color.FromArgb(150, 220, 150), LinearGradientMode.Horizontal)
                End If
            Else
                bgBrush = New LinearGradientBrush(e.Bounds, Color.FromArgb(100, 160, 150), Color.FromArgb(150, 160, 150), LinearGradientMode.Horizontal)
            End If

            Dim borderPen As Pen = If(button.Enabled, Pens.Green, Pens.Gray)
            Dim textBrush As Brush = If(button.Enabled, SystemBrushes.ActiveCaptionText, SystemBrushes.InactiveCaptionText)
            Dim cache As GraphicsCache = e.Cache
            cache.FillRectangle(bgBrush, e.Bounds)
            cache.DrawRectangle(borderPen, e.Bounds)
            Dim app As AppearanceObject = button.Appearance
            Dim sf As StringFormat = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis)
            cache.DrawVString(button.DisplayText, app.Font, textBrush, e.Bounds, sf, 270)
            e.Handled = True
        End Sub

        Private Sub schedulerControl_InitNewAppointment(ByVal sender As Object, ByVal e As AppointmentEventArgs)
            e.Appointment.StatusKey = 0
        End Sub

        Private Sub schedulerControl_GroupTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateControls()
        End Sub
    End Class
End Namespace
