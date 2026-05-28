Imports DevExpress.ApplicationUI.Demos.VisualEffects.Badges
Imports DevExpress.DXperience.Demos
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Design
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Svg
Imports DevExpress.Utils.VisualEffects
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos.VisualEffects

    Public Partial Class ModuleBadges
        Inherits TutorialControl

        Private unreadTextColor As Color

        Private current As TileItem

        Public Sub New()
            InitializeComponent()
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 500
            End Get
        End Property

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            unreadTextColor = CommonColors.GetQuestionColor(LookAndFeel)
            InitTileItems()
            SelectPage(current)
        End Sub

        Friend Delegate Sub InvokeMethod()

        Private Sub ModuleBadges_Load(ByVal sender As Object, ByVal e As EventArgs)
            dashboardItem.Tag = navigationPage1
            calendarItem.Tag = navigationPage2
            mailItem.Tag = navigationPage3
            unreadTextColor = CommonColors.GetQuestionColor(LookAndFeel)
            InitBadges()
            AddHandler navigationTileControl.Paint, AddressOf OnPaint
            InitTileItems()
            InitAppointments()
            InitScheduller()
            schedulerControl1.Start = TutorialConstants.Now
            schedulerControl1.DayView.TopRowTime = New TimeSpan(8, 0, 0)
            current = dashboardItem
            SelectPage(current)
            gridControl1.DataSource = SourceHelper.GetMessages()
        End Sub

        Private Sub InitBadges()
            InitBadge(dashMainBadge, "3", dashboardItem)
            InitBadge(dashClockBadge, "2", clockItem)
            InitBadge(dashSettingsBadge, "1", settingsItem)
            InitBadge(calendarMainBadge, "4", calendarItem)
            InitBadge(mailMainBadge, "6", mailItem)
        End Sub

        Private Sub InitBadge(ByVal badge As Badge, ByVal text As String, ByVal target As TileItem)
            badge.Properties.BeginUpdate()
            badge.Properties.PaintStyle = BadgePaintStyle.Critical
            badge.Properties.Location = ContentAlignment.TopRight
            badge.TargetElement = target
            badge.Properties.Text = text
            badge.Properties.EndUpdate()
        End Sub

        Private Sub InitScheduller()
            AddHandler schedulerControl1.HandleCreated, AddressOf SchedulerControl1_HandleCreated
            AddHandler schedulerControl1.SizeChanged, Sub(sender, e) schedulerControl1.DateNavigationBar.Panel.Invalidate()
        End Sub

        Private Sub SchedulerControl1_HandleCreated(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl1.DateNavigationBar.Panel = New SchedulerCustomPanel(schedulerControl1) With {.ImageCollection = svgImageCollection1}
        End Sub

        Private Sub SelectPage(ByVal tile As TileItem)
            current = tile
            UpdateSelection()
            navigationFrame1.SelectedPage = CType(tile.Tag, NavigationPage)
        End Sub

        Private Sub UpdateSelection()
            UpdateTileContent(dashboardItem, current Is dashboardItem, "Dashboard")
            UpdateTileContent(calendarItem, current Is calendarItem, "Calendar")
            UpdateTileContent(mailItem, current Is mailItem, "Mail")
            UpdateTileContent(notesItem, current Is notesItem, "Notes")
        End Sub

        Private Sub UpdateTileContent(ByVal item As TileItem, ByVal highlight As Boolean, ByVal imageKey As String)
            item.ImageOptions.SvgImageColorizationMode = SvgImageColorizationMode.Default
            item.ImageOptions.SvgImage = Nothing
            Dim frColor As Color = If(highlight, CommonColors.GetSystemColor("HighlightText"), GetSkinColor("ControlText"))
            Dim bkColor As Color = If(highlight, GetSkinColor("Question"), Color.Transparent)
            item.AppearanceItem.Normal.ForeColor = frColor
            item.AppearanceItem.Normal.BackColor = bkColor
            item.AppearanceItem.Normal.BorderColor = bkColor
            If highlight Then
                imageKey += "H"
                item.ImageOptions.SvgImageColorizationMode = SvgImageColorizationMode.None
            End If

            item.ImageOptions.SvgImage = svgImageCollection2(imageKey)
        End Sub

        Private Overloads Sub OnSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim tileHeight As Integer =(dashTiles.Height - ScaleDPI.ScaleVertical(dashTiles.IndentBetweenItems)) \ 3
            Dim vertPadding As Integer = tileHeight \ 2
            Dim horzPadding As Integer =(dashTiles.Width - tileHeight * 3 - 2 * dashTiles.IndentBetweenItems) \ 2
            dashTiles.ItemSize = CInt(tileHeight / ScaleDPI.ScaleFactorVert)
            dashTiles.Padding = New Padding(horzPadding, vertPadding, horzPadding, vertPadding)
            UpdateBadges()
        End Sub

        Private Overloads Sub OnPaint(ByVal sender As Object, ByVal e As EventArgs)
            UpdateBadges()
        End Sub

        Private Sub InitTileItems()
            Dim bkColor As Color = CommonColors.GetQuestionColor(LookAndFeel)
            InitTileItem(dashboardItem, 9F, 10)
            InitTileItem(calendarItem, 9F, 10)
            InitTileItem(mailItem, 9F, 10)
            InitTileItem(notesItem, 9F, 10)
            InitDashboardTileItem(clockItem, "Alarms", bkColor)
            InitDashboardTileItem(calculatorItem, "Calculator", bkColor)
            InitDashboardTileItem(weatherItem, "Weather", bkColor)
            InitDashboardTileItem(photosItem, "Photos", bkColor)
            InitDashboardTileItem(mapsItem, "Map", bkColor)
            InitDashboardTileItem(settingsItem, "settings", bkColor)
        End Sub

        Private Sub InitDashboardTileItem(ByVal tile As TileItem, ByVal imageKey As String, ByVal bkColor As Color)
            InitTileItem(tile, 10F, 15)
            tile.AppearanceItem.Normal.BackColor = bkColor
            tile.AppearanceItem.Normal.BorderColor = bkColor
            tile.ImageOptions.SvgImageColorizationMode = SvgImageColorizationMode.None
            tile.ImageOptions.SvgImage = svgImageCollection2(imageKey)
            tile.ImageOptions.SvgImageSize = New Size(48, 48)
        End Sub

        Private Sub InitTileItem(ByVal tile As TileItem, ByVal textSize As Single, ByVal indent As Integer)
            tile.ImageToTextIndent = indent
            tile.AppearanceItem.Normal.Font = New Font("Segoe UI", textSize)
        End Sub

        Private Sub UpdateBadges()
            SetBadgeOffset(dashClockBadge, clockItem, 4, 5)
            SetBadgeOffset(dashSettingsBadge, settingsItem, 0, 9)
            SetBadgeOffset(dashMainBadge, dashboardItem, 0, 9)
            SetBadgeOffset(calendarMainBadge, calendarItem, 0, 9)
            SetBadgeOffset(mailMainBadge, mailItem, 0, 9)
        End Sub

        Private Sub SetBadgeOffset(ByVal badge As Badge, ByVal tile As TileItem, ByVal deltaX As Integer, ByVal deltaY As Integer)
            Dim delta As Integer = tile.ImageOptions.SvgImageSize.Width \ 2
            Dim rect = CType(tile, ISupportAdornerElement).Bounds
            Dim x As Integer = ScaleDPI.DeScaleHorizontal(rect.Width) \ 2 - delta
            Dim y As Integer = ScaleDPI.DeScaleHorizontal(rect.Height) \ 2 - delta
            badge.Properties.Offset = New Point(-x - deltaX, y - deltaY)
        End Sub

        Private Function GetSkinColor(ByVal name As String) As Color
            Return CommonSkins.GetSkin(LookAndFeel).Colors(name)
        End Function

        Private Sub DashboardItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs)
            SelectPage(dashboardItem)
        End Sub

        Private Sub CalendarItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs)
            SelectPage(calendarItem)
        End Sub

        Private Sub MailItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs)
            SelectPage(mailItem)
        End Sub

        Private Sub NotesItemClick(ByVal sender As Object, ByVal e As TileItemEventArgs)
        End Sub

        Private Sub InitAppointments()
            Dim mappings As AppointmentMappingInfo = schedulerDataStorage1.Appointments.Mappings
            mappings.Start = "StartTime"
            mappings.End = "EndTime"
            mappings.Subject = "Subject"
            mappings.AllDay = "AllDay"
            mappings.Description = "Description"
            mappings.Label = "Label"
            mappings.Location = "Location"
            mappings.RecurrenceInfo = "RecurrenceInfo"
            mappings.ReminderInfo = "ReminderInfo"
            mappings.ResourceId = "OwnerId"
            mappings.Status = "Status"
            mappings.Type = "EventType"
            schedulerDataStorage1.Appointments.DataSource = SourceHelper.GetEvents()
        End Sub

        Private Sub tileView1_ItemCustomize(ByVal sender As Object, ByVal e As XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs)
            Dim msg As Badges.Message = TryCast(tileView1.GetRow(e.RowHandle), Badges.Message)
            If msg IsNot Nothing Then
                If Not msg.Read Then
                    e.Item("Date").Appearance.Normal.ForeColor = unreadTextColor
                    e.Item("Subject").Appearance.Normal.ForeColor = unreadTextColor
                    e.Item("Subject").Appearance.Normal.FontStyleDelta = FontStyle.Bold
                End If
            End If
        End Sub

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace

Namespace DevExpress.ApplicationUI.Demos.VisualEffects.Badges

    Public Class SchedulerCustomPanel
        Inherits XtraUserControl
        Implements ISchedulerDateNavigationBarPanel

        Private textFont As Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)

        Private _schedulerControl As SchedulerControl

        Private _imageCollection As SvgImageCollection

        Private _caption As String

        Private _backColor As Color

        Public Sub New(ByVal schedulerControl As SchedulerControl)
            _schedulerControl = schedulerControl
        End Sub

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property SchedulerControl As SchedulerControl Implements ISchedulerDateNavigationBarPanel.SchedulerControl
            Get
                Return _schedulerControl
            End Get

            Set(ByVal value As SchedulerControl)
                _schedulerControl = value
            End Set
        End Property

        Public Function CalcBestSize() As Size Implements ISchedulerDateNavigationBarPanel.CalcBestSize
            Return ScaleDPI.ScaleSize(New Size(_schedulerControl.DateNavigationBar.Panel.Width, 36))
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            MyBase.Dispose(disposing)
            _schedulerControl = Nothing
        End Sub

        Public Sub Recalculate(ByVal viewInfo As DateNavigationBarViewInfo) Implements ISchedulerDateNavigationBarPanel.Recalculate
            _caption = viewInfo.Caption
            _backColor = viewInfo.BackColor
        End Sub

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property ImageCollection As SvgImageCollection
            Get
                Return _imageCollection
            End Get

            Set(ByVal value As SvgImageCollection)
                _imageCollection = value
            End Set
        End Property

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            Using cache As GraphicsCache = New GraphicsCache(e.Graphics)
                cache.Clear(_backColor)
                DrawText(cache)
                Dim provider As ISvgPaletteProvider = SvgPaletteHelper.GetSvgPalette(_schedulerControl.LookAndFeel, ObjectState.Disabled)
                Dim backImage As Image = _imageCollection.GetImage(0, provider, ScaleDPI.ScaleSize(New Size(16, 16)))
                Dim forwardImage As Image = _imageCollection.GetImage(1, provider, ScaleDPI.ScaleSize(New Size(16, 16)))
                Dim imageIndent As Integer = Bounds.Height \ 2 - backImage.Size.Height \ 2
                cache.DrawImage(backImage, New Point(imageIndent, imageIndent))
                cache.DrawImage(forwardImage, New Point(Bounds.Right - forwardImage.Size.Width - imageIndent, imageIndent))
            End Using
        End Sub

        Private Sub DrawText(ByVal cache As GraphicsCache)
            Dim textColor As Color = CommonSkins.GetSkin(LookAndFeel).GetSystemColor(SystemColors.ControlText)
            Dim textSize As Size = cache.CalcTextSize(_caption, textFont).ToSize()
            Dim textX As Single = Bounds.Width \ 2 - textSize.Width \ 2
            Dim textY As Single = Bounds.Height \ 2 - textSize.Height \ 2
            cache.DrawString(_caption, textFont, cache.GetSolidBrush(textColor), New PointF(textX, textY))
        End Sub
    End Class

    Friend Class SourceHelper

        Public Shared Function GetEvents() As BindingList(Of CustomAppointment)
            Dim eventList As BindingList(Of CustomAppointment) = New BindingList(Of CustomAppointment)()
            eventList.Add(New CustomAppointment() With {.StartTime = TutorialConstants.Today + TimeSpan.FromMinutes(9.5 * 60), .EndTime = TutorialConstants.Today + TimeSpan.FromMinutes(11 * 60), .Subject = "Customer retention review", .Description = "Discuss ways in which we can improve relationship with customers and prove to them that we are long term source for all their A/V needs.", .Label = 1})
            eventList.Add(New CustomAppointment() With {.StartTime = TutorialConstants.Today + TimeSpan.FromMinutes(11.5 * 60), .EndTime = TutorialConstants.Today + TimeSpan.FromMinutes(13 * 60), .Subject = "Lunch with Arthur Doyle", .Description = "Has some information on our main competitor. Need to discuss a position within our company as he would be a great asset going forward"})
            eventList.Add(New CustomAppointment() With {.StartTime = TutorialConstants.Today + TimeSpan.FromMinutes(13.5 * 60), .EndTime = TutorialConstants.Today + TimeSpan.FromMinutes(15 * 60), .Subject = "Accountant review", .Description = "Prepare for accountants. Review P&L for last few mounths. Balance sheet must also be reviewed and questions for accountants formulated.", .Label = 2})
            eventList.Add(New CustomAppointment() With {.StartTime = TutorialConstants.Today + TimeSpan.FromMinutes(15 * 60), .EndTime = TutorialConstants.Today + TimeSpan.FromMinutes(17 * 60), .Subject = "French lesson", .Description = "If we are to have any chance in France, salespeople must learn french. Practice makes perfect and without constant repetition, learning a new language is impossible."})
            Return eventList
        End Function

        Public Shared Function GetMessages() As BindingList(Of Message)
            Dim messages As BindingList(Of Message) = New BindingList(Of Message)()
            messages.Add(New Message() With {.[Date] = TutorialConstants.Now, .From = "Mary Stern", .Subject = "My Favorite Resort in Las Vegas", .Text = "I know there are many impressive hotels in the city, but I just love the Eiffel Tower. It reminds me of the summer I spent in Paris studying at the Sorbonne."})
            messages.Add(New Message() With {.[Date] = TutorialConstants.Now, .From = "Olivia Peyton", .Subject = "Your Favorite Snakespeare Play", .Text = "We’ve got an open poll and you are the only two who have yet to respond. Which is your favorite Shakespeare play?"})
            messages.Add(New Message() With {.[Date] = TutorialConstants.Now, .From = "Cindy Stanwick", .Subject = "Roy Orbison is my favorite", .Text = "I was surprised to find out that you are not related to Roy Orbison. Sandra told me you were… In any event, you should listen to some of his music…he was a trail blazer."})
            messages.Add(New Message() With {.Read = True, .[Date] = TutorialConstants.Now.AddHours(-25), .From = "Brett Wade", .Subject = "Cabling and Termination", .Text = "Good Afternoon. Taylor, you need to learn how to terminate twisted - pair cables.I neither have the time nor the patience to teach you.Search the web and you’ll come across countless tutorials."})
            messages.Add(New Message() With {.[Date] = TutorialConstants.Now.AddHours(-26), .From = "Harv Mudd", .Subject = "Online Sales are Growing", .Text = "Hello Hannah Looks like online sales continue to outpace expectations.What accounts for the increase? Do you see anything that might disrupt growth in the coming year ? "})
            messages.Add(New Message() With {.Read = True, .[Date] = TutorialConstants.Now.AddHours(-26), .From = "Anthony Remmen", .Subject = "Wikipedia Syas I'm Right", .Text = "I told you I was right…The longest river in the world is the Nile. The Nile is a major north - flowing river in northeastern Africa, and is commonly regarded as the longest river in the world, though some sources claim that the Amazon River is longer.The Nile, which is 6, 853 km(4, 258 miles) long, is an international river as its drainage basin covers eleven countries, namely, Tanzania, Uganda, Rwanda, Burundi, the Democratic Republic of the Congo, Kenya, Ethiopia, Eritrea, South Sudan, Sudan and Egypt.In particular, the Nile is the primary water source of Egypt and Sudan."})
            messages.Add(New Message() With {.[Date] = TutorialConstants.Now.AddHours(-26), .From = "Clark Morgan", .Subject = "Circut Town Orders", .Text = "Hey Todd. Circuit Town has been ordering a lot of products recently.Did you thank them already or did you want me to reach out? Please advise."})
            messages.Add(New Message() With {.[Date] = TutorialConstants.Now.AddHours(-26), .From = "Bart Arnaz", .Subject = "My All-time Favorite Quote", .Text = "Here is the exact quote from Calvin Coolidge…please share it with those who might benefit… Nothing in this world can take the place of persistence.Talent will not: nothing is more common than unsuccessful men with talent.Genius will not; unrewarded genius is almost a proverb.Education will not: the world is full of educated derelicts. Persistence and determination alone are omnipotent."})
            messages.Add(New Message() With {.Read = True, .[Date] = TutorialConstants.Now.AddHours(-26), .From = "Stu Pizaro", .Subject = "RE: Your Mailind Address", .Text = "Hey Wally  You don’t have to send me a gift.I don’t like the fact that I’m getting old and birthday gifts are a reminder that I’m not as young as I used to be."})
            messages.Add(New Message() With {.Read = True, .[Date] = TutorialConstants.Now.AddHours(-26), .From = "Samantha Piper", .Subject = "New Circuit Board Design", .Text = "Hi Maggie  I hope you had a great time in Hawaii.I know you are busy catching up on email, but I did want to remind you that we have a meeting scheduled for 3PM to discuss our new circuit boards. Will you be able to make the meeting ? If you cannot attend, I will be more than happy to swing by your office and review the design with you. By the way, I still think we need to create a custom amplifier using vacuum tubes."})
            Return messages
        End Function
    End Class

#Region "calendar data"
    Friend Class CustomAppointment

        Public Property StartTime As Date

        Public Property EndTime As Date

        Public Property Subject As String

        Public Property Status As Integer

        Public Property Description As String

        Public Property Label As Integer

        Public Property Location As String

        Public Property AllDay As Boolean

        Public Property EventType As Integer

        Public Property RecurrenceInfo As String

        Public Property ReminderInfo As String

        Public Property OwnerId As Object
    End Class

#End Region
#Region "mail data"
    Friend Class Message

        Public Property [Date] As Date

        Public Property From As String

        Public Property Subject As String

        Public Property Text As String

        Friend Property Read As Boolean
    End Class
#End Region
End Namespace
