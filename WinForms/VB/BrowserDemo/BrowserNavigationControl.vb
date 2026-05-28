Imports DevExpress.XtraBars.Controls
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Drawing

Namespace DevExpress.XtraBars.Demos.BrowserDemo

    Public Class BrowserNavigationControl
        Inherits XtraUserControl

        Private barManager1 As BarManager

        Private components As System.ComponentModel.IContainer

        Private barDockControlTop As BarDockControl

        Private barDockControlBottom As BarDockControl

        Private barDockControlLeft As BarDockControl

        Private bar1 As Bar

        Private barButtonItem3 As BarButtonItem

        Private barButtonItem4 As BarButtonItem

        Private barEditItem1 As BarEditItem

        Private repositoryItemSearchControl1 As RepositoryItemSearchControl

        Private barButtonItem5 As BarButtonItem

        Private barAndDockingController1 As BarAndDockingController

        Private barButtonItem1 As BarButtonItem

        Private twButton As BarButtonItem

        Private ytButton As BarButtonItem

        Private fbButton As BarButtonItem

        Private barDockControlRight As BarDockControl

        Public Sub New()
            MyBase.New()
            InitializeComponent()
            Dock = Windows.Forms.DockStyle.Top
            SearchItem.EditorPadding = New Windows.Forms.Padding(SearchItemLeftPadding, 0, SearchItemRightPadding, 0)
        End Sub

        Public ReadOnly Property SearchPanel As RepositoryItemSearchControl
            Get
                Return repositoryItemSearchControl1
            End Get
        End Property

        Public ReadOnly Property SearchItem As BarEditItem
            Get
                Return barEditItem1
            End Get
        End Property

        Public ReadOnly Property Manager As BarManager
            Get
                Return barManager1
            End Get
        End Property

        Public ReadOnly Property BackButton As BarButtonItem
            Get
                Return barButtonItem3
            End Get
        End Property

        Public ReadOnly Property ForwardButton As BarButtonItem
            Get
                Return barButtonItem4
            End Get
        End Property

        Public ReadOnly Property RefreshButton As BarButtonItem
            Get
                Return barButtonItem5
            End Get
        End Property

        Private Shared ReadOnly SearchItemLeftPadding As Integer = 8

        Private Shared ReadOnly SearchItemRightPadding As Integer = 5

        Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As Windows.Forms.BoundsSpecified)
            height = Padding.Vertical + barDockControlTop.Height
            MyBase.SetBoundsCore(x, y, width, height, specified)
        End Sub

        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrowserNavigationControl))
            barManager1 = New BarManager(components)
            bar1 = New Bar()
            barButtonItem3 = New BarButtonItem()
            barButtonItem4 = New BarButtonItem()
            barButtonItem5 = New BarButtonItem()
            barButtonItem1 = New BarButtonItem()
            barEditItem1 = New BarEditItem()
            repositoryItemSearchControl1 = New RepositoryItemSearchControl()
            twButton = New BarButtonItem()
            ytButton = New BarButtonItem()
            fbButton = New BarButtonItem()
            barAndDockingController1 = New BarAndDockingController(components)
            barDockControlTop = New EmptyBarDockControl()
            barDockControlBottom = New BarDockControl()
            barDockControlLeft = New BarDockControl()
            barDockControlRight = New BarDockControl()
            CType(barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager1
            ' 
            barManager1.AllowCustomization = False
            barManager1.Bars.AddRange(New Bar() {bar1})
            barManager1.Controller = barAndDockingController1
            barManager1.DockControls.Add(barDockControlTop)
            barManager1.DockControls.Add(barDockControlBottom)
            barManager1.DockControls.Add(barDockControlLeft)
            barManager1.DockControls.Add(barDockControlRight)
            barManager1.Form = Me
            barManager1.Items.AddRange(New BarItem() {barButtonItem3, barButtonItem4, barEditItem1, barButtonItem5, barButtonItem1, twButton, ytButton, fbButton})
            barManager1.MainMenu = bar1
            barManager1.MaxItemId = 11
            barManager1.RepositoryItems.AddRange(New RepositoryItem() {repositoryItemSearchControl1})
            ' 
            ' bar1
            ' 
            bar1.BarName = "Custom 2"
            bar1.DockCol = 0
            bar1.DockRow = 0
            bar1.DockStyle = BarDockStyle.Top
            bar1.LinksPersistInfo.AddRange(New LinkPersistInfo() {New LinkPersistInfo(barButtonItem3), New LinkPersistInfo(barButtonItem4), New LinkPersistInfo(barButtonItem5), New LinkPersistInfo(barButtonItem1), New LinkPersistInfo(barEditItem1), New LinkPersistInfo(twButton), New LinkPersistInfo(ytButton), New LinkPersistInfo(fbButton)})
            bar1.OptionsBar.AllowQuickCustomization = False
            bar1.OptionsBar.AutoPopupMode = BarAutoPopupMode.None
            bar1.OptionsBar.DisableClose = True
            bar1.OptionsBar.DisableCustomization = True
            bar1.OptionsBar.DrawBorder = False
            bar1.OptionsBar.DrawDragBorder = False
            bar1.OptionsBar.UseWholeRow = True
            bar1.Text = "Custom 2"
            ' 
            ' barButtonItem3
            ' 
            barButtonItem3.Caption = "Back"
            barButtonItem3.ContentHorizontalAlignment = BarItemContentAlignment.Center
            barButtonItem3.Enabled = False
            barButtonItem3.Id = 2
            barButtonItem3.ImageOptions.SvgImage = CType(resources.GetObject("barButtonItem3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            barButtonItem3.Name = "barButtonItem3"
            barButtonItem3.Size = New System.Drawing.Size(30, 0)
            ' 
            ' barButtonItem4
            ' 
            barButtonItem4.Caption = "Forward"
            barButtonItem4.ContentHorizontalAlignment = BarItemContentAlignment.Center
            barButtonItem4.Enabled = False
            barButtonItem4.Id = 3
            barButtonItem4.ImageOptions.SvgImage = CType(resources.GetObject("barButtonItem4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            barButtonItem4.Name = "barButtonItem4"
            barButtonItem4.Size = New System.Drawing.Size(30, 0)
            ' 
            ' barButtonItem5
            ' 
            barButtonItem5.Caption = "Refresh"
            barButtonItem5.ContentHorizontalAlignment = BarItemContentAlignment.Center
            barButtonItem5.Id = 5
            barButtonItem5.ImageOptions.SvgImage = CType(resources.GetObject("barButtonItem5.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            barButtonItem5.Name = "barButtonItem5"
            barButtonItem5.Size = New System.Drawing.Size(30, 0)
            ' 
            ' barButtonItem1
            ' 
            barButtonItem1.Caption = "Home"
            barButtonItem1.Id = 7
            barButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("barButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            barButtonItem1.Name = "barButtonItem1"
            barButtonItem1.Size = New System.Drawing.Size(30, 0)
            AddHandler barButtonItem1.ItemClick, New ItemClickEventHandler(AddressOf homeButton_ItemClick)
            ' 
            ' barEditItem1
            ' 
            barEditItem1.AutoFillWidth = True
            barEditItem1.ContentHorizontalAlignment = BarItemContentAlignment.Center
            barEditItem1.Edit = repositoryItemSearchControl1
            barEditItem1.EditHeight = 30
            barEditItem1.EditWidth = 70
            barEditItem1.Id = 4
            barEditItem1.Name = "barEditItem1"
            ' 
            ' repositoryItemSearchControl1
            ' 
            repositoryItemSearchControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            repositoryItemSearchControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte(64))))), (CInt(((CByte(64))))), (CInt(((CByte(64))))))
            repositoryItemSearchControl1.Appearance.Options.UseFont = True
            repositoryItemSearchControl1.Appearance.Options.UseForeColor = True
            repositoryItemSearchControl1.AutoHeight = False
            repositoryItemSearchControl1.Buttons.AddRange(New XtraEditors.Controls.EditorButton() {New SearchButton()})
            repositoryItemSearchControl1.Name = "repositoryItemSearchControl1"
            repositoryItemSearchControl1.NullValuePrompt = "Enter a web address"
            repositoryItemSearchControl1.ShowClearButton = False
            ' 
            ' twButton
            ' 
            twButton.Caption = "Twitter"
            twButton.Id = 8
            twButton.ImageOptions.SvgImage = CType(resources.GetObject("twButton.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            twButton.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
            twButton.Name = "twButton"
            twButton.Size = New System.Drawing.Size(30, 0)
            AddHandler twButton.ItemClick, New ItemClickEventHandler(AddressOf twButton_ItemClick)
            ' 
            ' ytButton
            ' 
            ytButton.Caption = "Youtube"
            ytButton.Id = 9
            ytButton.ImageOptions.SvgImage = CType(resources.GetObject("ytButton.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            ytButton.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
            ytButton.Name = "ytButton"
            ytButton.Size = New System.Drawing.Size(30, 0)
            AddHandler ytButton.ItemClick, New ItemClickEventHandler(AddressOf ytButton_ItemClick)
            ' 
            ' fbButton
            ' 
            fbButton.Caption = "Facebook"
            fbButton.Id = 10
            fbButton.ImageOptions.SvgImage = CType(resources.GetObject("fbButton.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
            fbButton.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
            fbButton.Name = "fbButton"
            fbButton.Size = New System.Drawing.Size(30, 0)
            AddHandler fbButton.ItemClick, New ItemClickEventHandler(AddressOf fbButton_ItemClick)
            ' 
            ' barAndDockingController1
            ' 
            barAndDockingController1.PropertiesBar.AllowLinkLighting = False
            barAndDockingController1.PropertiesBar.BarItemHorzIndent = 0
            barAndDockingController1.PropertiesDocking.ViewStyle = Docking2010.Views.DockingViewStyle.Classic
            ' 
            ' barDockControlTop
            ' 
            barDockControlTop.CausesValidation = False
            barDockControlTop.Dock = Windows.Forms.DockStyle.Top
            barDockControlTop.Location = New System.Drawing.Point(9, 9)
            barDockControlTop.Manager = barManager1
            barDockControlTop.Size = New System.Drawing.Size(469, 30)
            ' 
            ' barDockControlBottom
            ' 
            barDockControlBottom.CausesValidation = False
            barDockControlBottom.Dock = Windows.Forms.DockStyle.Bottom
            barDockControlBottom.Location = New System.Drawing.Point(9, 139)
            barDockControlBottom.Manager = barManager1
            barDockControlBottom.Size = New System.Drawing.Size(469, 0)
            ' 
            ' barDockControlLeft
            ' 
            barDockControlLeft.CausesValidation = False
            barDockControlLeft.Dock = Windows.Forms.DockStyle.Left
            barDockControlLeft.Location = New System.Drawing.Point(9, 39)
            barDockControlLeft.Manager = barManager1
            barDockControlLeft.Size = New System.Drawing.Size(0, 100)
            ' 
            ' barDockControlRight
            ' 
            barDockControlRight.CausesValidation = False
            barDockControlRight.Dock = Windows.Forms.DockStyle.Right
            barDockControlRight.Location = New System.Drawing.Point(478, 39)
            barDockControlRight.Manager = barManager1
            barDockControlRight.Size = New System.Drawing.Size(0, 100)
            ' 
            ' BrowserNavigationControl
            ' 
            Appearance.BackColor = System.Drawing.Color.Transparent
            Appearance.Options.UseBackColor = True
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(barDockControlLeft)
            Me.Controls.Add(barDockControlRight)
            Me.Controls.Add(barDockControlBottom)
            Me.Controls.Add(barDockControlTop)
            Name = "BrowserNavigationControl"
            Padding = New Windows.Forms.Padding(9, 9, 12, 11)
            Size = New System.Drawing.Size(490, 150)
            CType(barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private Sub twButton_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim ownerForm = TryCast(FindForm(), frmMain)
            If ownerForm IsNot Nothing Then ownerForm.Navigate("www.twitter.com/DevExpress")
        End Sub

        Private Sub ytButton_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim ownerForm = TryCast(FindForm(), frmMain)
            If ownerForm IsNot Nothing Then ownerForm.Navigate("www.youtube.com/user/DeveloperExpress?ab_channel=DevExpress")
        End Sub

        Private Sub fbButton_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim ownerForm = TryCast(FindForm(), frmMain)
            If ownerForm IsNot Nothing Then ownerForm.Navigate("www.facebook.com/DevExpress")
        End Sub

        Private Sub homeButton_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim ownerForm = TryCast(FindForm(), frmMain)
            If ownerForm IsNot Nothing Then ownerForm.InitHomePage()
        End Sub
    End Class

    Public Class EmptyBarDockControl
        Inherits BarDockControl

        Public Sub New()
            SetStyle(Windows.Forms.ControlStyles.SupportsTransparentBackColor, True)
        End Sub

        Public Overrides ReadOnly Property BackColor As Color
            Get
                Return Color.Transparent
            End Get
        End Property

        Protected Overrides Function CreateViewInfo() As CustomViewInfo
            Return New MyDockControlSkinViewInfo(Manager, Manager.GetController().PaintStyle.DrawParameters, Me)
        End Function

        Private Class MyDockControlSkinViewInfo
            Inherits DockControlSkinViewInfo

            Public Sub New(ByVal manager As BarManager, ByVal parameters As BarDrawParameters, ByVal barControl As CustomControl)
                MyBase.New(manager, parameters, barControl)
            End Sub

            Public Overrides ReadOnly Property IsDrawForeground As Boolean
                Get
                    Return False
                End Get
            End Property
        End Class
    End Class
End Namespace
