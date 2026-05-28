Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Filtering
Imports DevExpress.XtraSplashScreen
Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class GroupStyle
        Inherits DevExpress.XtraLayout.Demos.TutorialControl

        Private disabledColor As System.Drawing.Color = System.Drawing.Color.Gray

        Private viewNameSplashScreen As DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle = Nothing

        Public Sub New()
            Me.InitializeComponent()
            Me.gridControlAllTickets.DataSource = DevExpress.XtraLayout.Demos.DataHelper.GetBestTickets()
            Me.tileView2.Assign(Me.tileView1, True)
            Me.tileView2.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None
            Me.UpdateColors()
            Me.gridControlCheapestPrice.MaximumSize = New System.Drawing.Size(0, 2 * Me.ScaleHelper.ScaleHorizontal(Me.tileView1.OptionsTiles.ItemSize.Height) + Me.ScaleHelper.ScaleHorizontal(2))
            Me.gridControlCheapestPrice.MinimumSize = New System.Drawing.Size(Me.ScaleHelper.ScaleHorizontal(500), 2 * Me.ScaleHelper.ScaleHorizontal(Me.tileView1.OptionsTiles.ItemSize.Height) + Me.ScaleHelper.ScaleHorizontal(2))
            Me.gridControlAllTickets.MinimumSize = New System.Drawing.Size(Me.ScaleHelper.ScaleHorizontal(500), 2 * Me.ScaleHelper.ScaleHorizontal(Me.tileView1.OptionsTiles.ItemSize.Height) + Me.ScaleHelper.ScaleHorizontal(2))
        End Sub

        Private Sub tileView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
            Dim ticket As DevExpress.XtraLayout.Demos.Ticket = TryCast(e.Row, DevExpress.XtraLayout.Demos.Ticket)
            If e.Column Is Me.colDepartTakeOffTimeSpan AndAlso e.IsGetData Then
                e.Value = New System.TimeSpan(ticket.Depart.TakeOff.Hour, ticket.Depart.TakeOff.Minute, 0)
            End If

            If e.Column Is Me.colDepartLandingTimeSpan AndAlso e.IsGetData Then
                e.Value = New System.TimeSpan(ticket.Depart.Landing.Hour, ticket.Depart.Landing.Minute, 0)
            End If

            If e.Column Is Me.colReturnTakeOffTimeSpan AndAlso e.IsGetData Then
                e.Value = New System.TimeSpan(ticket.[Return].TakeOff.Hour, ticket.[Return].TakeOff.Minute, 0)
            End If

            If e.Column Is Me.colReturnLandingTimeSpan AndAlso e.IsGetData Then
                e.Value = New System.TimeSpan(ticket.[Return].Landing.Hour, ticket.[Return].Landing.Minute, 0)
            End If
        End Sub

        Private Sub tileView1_ItemCustomize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs)
            If e.RowHandle Mod 2 = 0 Then e.Item.AppearanceItem.Normal.BackColor = DevExpress.Skins.SkinManager.GetSkinElement(CType((DevExpress.Skins.SkinProductId.Grid), DevExpress.Skins.SkinProductId), CType((Me.LookAndFeel), DevExpress.Skins.ISkinProvider), CStr((DevExpress.Skins.GridSkins.SkinGridOddRow))).Color.GetBackColor()
            e.Item.GetElementByName(CStr((">"))).Appearance.Normal.ForeColor = Me.disabledColor
            e.Item(CStr(("Depart.To"))).Appearance.Normal.ForeColor = Me.disabledColor
            e.Item(CStr(("Depart.From"))).Appearance.Normal.ForeColor = Me.disabledColor
            e.Item(CStr(("Depart.AirportFrom"))).Appearance.Normal.ForeColor = Me.disabledColor
            e.Item(CStr(("Depart.AirportTo"))).Appearance.Normal.ForeColor = Me.disabledColor
            e.Item(CStr(("Return.To"))).Appearance.Normal.ForeColor = Me.disabledColor
            e.Item(CStr(("Return.From"))).Appearance.Normal.ForeColor = Me.disabledColor
            e.Item(CStr(("Return.AirportFrom"))).Appearance.Normal.ForeColor = Me.disabledColor
            e.Item(CStr(("Return.AirportTo"))).Appearance.Normal.ForeColor = Me.disabledColor
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim chipTicket As DevExpress.XtraLayout.Demos.Ticket = Nothing
            Dim prevChipTicket As DevExpress.XtraLayout.Demos.Ticket = Nothing
            For i As Integer = 0 To Me.tileView1.DataRowCount - 1
                Dim rowObj As DevExpress.XtraLayout.Demos.Ticket = CType(Me.tileView1.GetRow(i), DevExpress.XtraLayout.Demos.Ticket)
                If chipTicket Is Nothing Then
                    chipTicket = rowObj
                Else
                    If rowObj.Depart.Price + rowObj.[Return].Price < chipTicket.Depart.Price + chipTicket.[Return].Price Then
                        prevChipTicket = chipTicket
                        chipTicket = rowObj
                    End If
                End If
            Next

            Me.layoutControlGroupBest.Text = String.Format("{0} flights found", Me.tileView1.DataRowCount)
            Me.layoutControlGroupCheapestPrice.Text = If(chipTicket Is Nothing, "Cheapest", "Cheapest ($" & (chipTicket.Depart.Price + chipTicket.[Return].Price) & ")")
            Dim bindingList As System.ComponentModel.BindingList(Of DevExpress.XtraLayout.Demos.Ticket) = New System.ComponentModel.BindingList(Of DevExpress.XtraLayout.Demos.Ticket) From {chipTicket}
            If prevChipTicket IsNot Nothing Then bindingList.Add(prevChipTicket)
            Me.gridControlCheapestPrice.DataSource = bindingList
        End Sub

        Private Sub UpdateColors()
            Me.disabledColor = DevExpress.Skins.CommonSkins.GetSkin(CType((Me.LookAndFeel), DevExpress.Skins.ISkinProvider)).GetSystemColor(System.Drawing.SystemColors.GrayText)
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            Me.timer1.Enabled = True
        End Sub

        Protected Overrides Sub DoHide()
            If Me.viewNameSplashScreen IsNot Nothing Then
                Me.simpleButton1_Click(Nothing, Nothing)
            End If

            Me.timer1.Enabled = False
            MyBase.DoHide()
        End Sub

        Protected Overrides Sub OnStyleChanged(ByVal e As System.EventArgs)
            MyBase.OnStyleChanged(e)
            Me.UpdateColors()
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                If Me.viewNameSplashScreen IsNot Nothing Then Me.simpleButton1_Click(Nothing, Nothing)
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "ShowGroupStyles"
        Private Sub CloseProgressPanel(ByVal handle As DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle)
            Try
                Call DevExpress.XtraSplashScreen.SplashScreenManager.CloseOverlayForm(handle)
            Catch
            End Try
        End Sub

        Private Function ShowProgressPanel(ByVal Optional windowOptions As DevExpress.XtraSplashScreen.OverlayWindowOptions = Nothing) As IOverlaySplashScreenHandle
            Try
                Return DevExpress.XtraSplashScreen.SplashScreenManager.ShowOverlayForm(Me, If(windowOptions, DevExpress.XtraSplashScreen.OverlayWindowOptions.[Default]))
            Catch
                Return Nothing
            End Try
        End Function

        Private _painter As DevExpress.XtraLayout.Demos.ViewNamePainter = Nothing

        Private ReadOnly Property ViewNamePainter As ViewNamePainter
            Get
                If Me._painter Is Nothing Then Me._painter = New DevExpress.XtraLayout.Demos.ViewNamePainter(AddressOf Me.GetTitleRect, AddressOf Me.GetLightRect, AddressOf Me.GetCardRect)
                Return Me._painter
            End Get
        End Property

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.viewNameSplashScreen IsNot Nothing Then
                Me.CloseProgressPanel(Me.viewNameSplashScreen)
                Me.viewNameSplashScreen = Nothing
                Me.simpleButton1.Text = "Show Group Styles"
            Else
                Me.viewNameSplashScreen = Me.ShowProgressPanel(New DevExpress.XtraSplashScreen.OverlayWindowOptions(fadeIn:=False, fadeOut:=False, customPainter:=Me.ViewNamePainter))
                Me.simpleButton1.Text = "Hide Group Styles"
            End If
        End Sub

        Private Function GetTitleRect() As Rectangle
            Return Me.layoutControl1.Bounds
        End Function

        Private Function GetCardRect() As Rectangle
            Dim cardBounds As System.Drawing.Rectangle = System.Drawing.Rectangle.Union(Me.layoutControlGroupWeather.ViewInfo.BoundsRelativeToControl, Me.layoutControlGroupClock.ViewInfo.BoundsRelativeToControl)
            cardBounds.Location = System.Drawing.Point.Add(cardBounds.Location, New System.Drawing.Size(Me.dataLayoutControl1.Location.X, Me.dataLayoutControl1.Location.Y))
            Return cardBounds
        End Function

        Private Function GetLightRect() As Rectangle
            Dim lightBounds As System.Drawing.Rectangle = System.Drawing.Rectangle.Union(Me.layoutControlGroupBest.ViewInfo.BoundsRelativeToControl, Me.layoutControlGroupCheapestPrice.ViewInfo.BoundsRelativeToControl)
            lightBounds.Location = System.Drawing.Point.Add(lightBounds.Location, New System.Drawing.Size(Me.dataLayoutControl1.Location.X, Me.dataLayoutControl1.Location.Y))
            Return lightBounds
        End Function
#End Region
    End Class

    Public Class ViewNamePainter
        Inherits DevExpress.XtraSplashScreen.OverlayWindowPainterBase

        Private Shared font As System.Drawing.Font = New System.Drawing.Font("Segoe UI", 30F)

        '
        Private ReadOnly CardRectangle As System.Func(Of System.Drawing.Rectangle)

        Private ReadOnly LightRectangle As System.Func(Of System.Drawing.Rectangle)

        Private ReadOnly TitleRectangle As System.Func(Of System.Drawing.Rectangle)

        Public Sub New(ByVal titleRectangle As System.Func(Of System.Drawing.Rectangle), ByVal lightRectangle As System.Func(Of System.Drawing.Rectangle), ByVal cardRectangle As System.Func(Of System.Drawing.Rectangle))
            Me.CardRectangle = cardRectangle
            Me.LightRectangle = lightRectangle
            Me.TitleRectangle = titleRectangle
        End Sub

        Public Shared Sub DrawInfo(ByVal cache As DevExpress.Utils.Drawing.GraphicsCache, ByVal textToDraw As String, ByVal rect As System.Drawing.Rectangle, ByVal color As System.Drawing.Color)
            cache.FillRectangle(cache.GetSolidBrush(System.Drawing.Color.FromArgb(128, color)), rect)
            cache.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
            cache.DrawString(textToDraw, DevExpress.XtraLayout.Demos.ViewNamePainter.font, System.Drawing.Color.White, rect, DevExpress.Utils.AppearanceObject.ControlAppearance.GetStringFormat())
        End Sub

        Protected Overrides Sub Draw(ByVal context As DevExpress.XtraSplashScreen.OverlayWindowCustomDrawContext)
            context.Handled = True
            context.DrawArgs.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Call DevExpress.XtraLayout.Demos.ViewNamePainter.DrawInfo(context.DrawArgs.Cache, "Light Style", Me.LightRectangle.Invoke(), System.Drawing.Color.FromArgb(17, 119, 215))
            Call DevExpress.XtraLayout.Demos.ViewNamePainter.DrawInfo(context.DrawArgs.Cache, "Title Style", Me.TitleRectangle.Invoke(), System.Drawing.Color.FromArgb(209, 28, 28))
            Call DevExpress.XtraLayout.Demos.ViewNamePainter.DrawInfo(context.DrawArgs.Cache, "Card Style", Me.CardRectangle.Invoke(), System.Drawing.Color.FromArgb(3, 156, 35))
        End Sub
    End Class

    '
    Public Module DataHelper

        Public Function GetBestTickets() As BindingList(Of DevExpress.XtraLayout.Demos.Ticket)
            Dim tickets As System.ComponentModel.BindingList(Of DevExpress.XtraLayout.Demos.Ticket) = New System.ComponentModel.BindingList(Of DevExpress.XtraLayout.Demos.Ticket)()
            'M-L
            For i As Integer = 0 To 10 - 1
                tickets.Add(New DevExpress.XtraLayout.Demos.Ticket With {.Depart = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("SVO", "LHR", "Moscow", "London", 7, 35, 9, 45, 4 + i * 2, 260), .[Return] = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("LHR", "SVO", "London", "Moscow", 13, 25, 19, 05, 11 + i * 3, 275)})
                tickets.Add(New DevExpress.XtraLayout.Demos.Ticket With {.[Return] = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("SVO", "LHR", "Moscow", "London", 7, 35, 9, 45, 11 + i * 2, 275), .Depart = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("LHR", "SVO", "London", "Moscow", 13, 25, 19, 05, 4 + i * 3, 260)})
            Next

            For i As Integer = 0 To 10 - 1
                tickets.Add(New DevExpress.XtraLayout.Demos.Ticket With {.Depart = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("DME", "LHR", "Moscow", "London", 18, 10, 20, 20, 1 + i, 310), .[Return] = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("LHR", "DME", "London", "Moscow", 22, 35, 28, 20, 4 + i * 2, 295)})
                tickets.Add(New DevExpress.XtraLayout.Demos.Ticket With {.[Return] = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("DME", "LHR", "Moscow", "London", 18, 10, 20, 20, 8 + i, 295), .Depart = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("LHR", "DME", "London", "Moscow", 22, 35, 28, 20, 3 + i * 2, 310)})
            Next

            'L-NY
            For i As Integer = 0 To 10 - 1
                tickets.Add(New DevExpress.XtraLayout.Demos.Ticket With {.Depart = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("STN", "JFK", "London", "New York", 17, 20, 23, 25, 3 + i, 250), .[Return] = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("JFK", "STN", "New York", "London", 00, 40, 16, 15, 8 + i * 2, 245)})
                tickets.Add(New DevExpress.XtraLayout.Demos.Ticket With {.[Return] = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("STN", "JFK", "London", "New York", 17, 20, 23, 25, 8 + i, 245), .Depart = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("JFK", "STN", "New York", "London", 00, 40, 16, 15, 3 + i * 2, 250)})
            Next

            For i As Integer = 0 To 10 - 1
                tickets.Add(New DevExpress.XtraLayout.Demos.Ticket With {.Depart = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("LHR", "EWR", "London", "New York", 18, 00, 21, 00, 5 + i, 280), .[Return] = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("EWR", "LHR", "New York", "London", 00, 40, 16, 15, 10 + i, 310)})
                tickets.Add(New DevExpress.XtraLayout.Demos.Ticket With {.[Return] = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("LHR", "EWR", "London", "New York", 18, 00, 21, 00, 10 + i, 310), .Depart = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("EWR", "LHR", "New York", "London", 00, 40, 16, 15, 5 + i, 280)})
            Next

            'M-NY
            For i As Integer = 0 To 20 - 1
                tickets.Add(New DevExpress.XtraLayout.Demos.Ticket With {.Depart = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("SVO", "JFK", "Moscow", "New York", 9, 20, 12, 05, 3 + i, 320), .[Return] = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("JFK", "SVO", "New York", "Moscow", 00, 40, 16, 15, 8 + i * 2, 300)})
                tickets.Add(New DevExpress.XtraLayout.Demos.Ticket With {.[Return] = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("SVO", "JFK", "Moscow", "New York", 9, 20, 12, 05, 8 + i, 300), .Depart = DevExpress.XtraLayout.Demos.DataHelper.GetFlight("JFK", "SVO", "New York", "Moscow", 00, 40, 16, 15, 3 + i * 2, 320)})
            Next

            Return tickets
        End Function

        Public Function GetFlight(ByVal airFrom As String, ByVal airTo As String, ByVal from As String, ByVal [to] As String, ByVal takeHour As Integer, ByVal takeMin As Integer, ByVal landHour As Integer, ByVal landMin As Integer, ByVal dateOffset As Integer, ByVal basePrice As Decimal) As Flight
            Return New DevExpress.XtraLayout.Demos.Flight With {.AirportFrom = airFrom, .AirportTo = airTo, .From = from, .[To] = [to], .TakeOff = System.DateTime.Now.[Date] + New System.TimeSpan(dateOffset, takeHour, takeMin, 0), .Landing = System.DateTime.Now.[Date] + New System.TimeSpan(dateOffset, landHour, landMin, 0), .Price = basePrice + DevExpress.Data.Utils.NonCryptographicRandom.[Default].[Next](-20, 20)}
        End Function
    End Module

    Public Class Flight

        <DevExpress.Utils.Filtering.FilterLookupAttribute(UseSelectAll:=False)>
        Public Property AirportFrom As String

        <DevExpress.Utils.Filtering.FilterLookupAttribute(UseSelectAll:=False)>
        Public Property AirportTo As String

        <DevExpress.Utils.Filtering.FilterLookupAttribute(UseSelectAll:=False)>
        Public Property From As String

        Public Property Landing As DateTime

        Public Property Price As Decimal

        Public Property TakeOff As DateTime

        <DevExpress.Utils.Filtering.FilterLookupAttribute(UseSelectAll:=False)>
        Public Property [To] As String
    End Class

    Public Class Ticket

        Public Property Depart As Flight

        Public Property [Return] As Flight
    End Class
End Namespace
