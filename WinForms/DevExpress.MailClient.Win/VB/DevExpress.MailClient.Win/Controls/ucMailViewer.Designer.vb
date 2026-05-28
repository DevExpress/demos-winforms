Namespace DevExpress.MailClient.Win
    Partial Public Class ucMailViewer
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ucMailViewer))
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.lbDate = New DevExpress.XtraEditors.LabelControl()
            Me.lbFrom = New DevExpress.XtraEditors.LabelControl()
            Me.lbSubject = New DevExpress.XtraEditors.LabelControl()
            Me.standaloneBarDockControl1 = New DevExpress.XtraBars.StandaloneBarDockControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bbiReply = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiReplyAll = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiForward = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.pePhoto = New DevExpress.XtraEditors.PictureEdit()
            Me.recMessage = New DevExpress.XtraRichEdit.RichEditControl()
            Me.linkView = New DevExpress.XtraEditors.HyperLinkEdit()
            Me.lgAll = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lgMessageInfo = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lcPicture = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.linkView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lgAll, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lgMessageInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcPicture, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.layoutControl1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.lbDate)
            Me.layoutControl1.Controls.Add(Me.lbFrom)
            Me.layoutControl1.Controls.Add(Me.lbSubject)
            Me.layoutControl1.Controls.Add(Me.standaloneBarDockControl1)
            Me.layoutControl1.Controls.Add(Me.pePhoto)
            Me.layoutControl1.Controls.Add(Me.recMessage)
            Me.layoutControl1.Controls.Add(Me.linkView)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1019, 197, 631, 772)
            Me.layoutControl1.Root = Me.lgAll
            ' 
            ' lbDate
            ' 
            Me.lbDate.Appearance.ForeColor = (DirectCast(resources.GetObject("lbDate.Appearance.ForeColor"), System.Drawing.Color))
            Me.lbDate.Appearance.Options.UseForeColor = True
            resources.ApplyResources(Me.lbDate, "lbDate")
            Me.lbDate.Name = "lbDate"
            Me.lbDate.StyleController = Me.layoutControl1
            ' 
            ' lbFrom
            ' 
            Me.lbFrom.Appearance.Font = (DirectCast(resources.GetObject("lbFrom.Appearance.Font"), System.Drawing.Font))
            Me.lbFrom.Appearance.ForeColor = (DirectCast(resources.GetObject("lbFrom.Appearance.ForeColor"), System.Drawing.Color))
            Me.lbFrom.Appearance.Options.UseFont = True
            Me.lbFrom.Appearance.Options.UseForeColor = True
            Me.lbFrom.Appearance.Options.UseTextOptions = True
            Me.lbFrom.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.lbFrom.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.lbFrom.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            resources.ApplyResources(Me.lbFrom, "lbFrom")
            Me.lbFrom.Name = "lbFrom"
            Me.lbFrom.StyleController = Me.layoutControl1
            ' 
            ' lbSubject
            ' 
            Me.lbSubject.Appearance.Font = (DirectCast(resources.GetObject("lbSubject.Appearance.Font"), System.Drawing.Font))
            Me.lbSubject.Appearance.Options.UseFont = True
            Me.lbSubject.Appearance.Options.UseTextOptions = True
            Me.lbSubject.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.lbSubject.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.lbSubject.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            resources.ApplyResources(Me.lbSubject, "lbSubject")
            Me.lbSubject.Name = "lbSubject"
            Me.lbSubject.StyleController = Me.layoutControl1
            ' 
            ' standaloneBarDockControl1
            ' 
            Me.standaloneBarDockControl1.CausesValidation = False
            resources.ApplyResources(Me.standaloneBarDockControl1, "standaloneBarDockControl1")
            Me.standaloneBarDockControl1.Manager = Me.barManager1
            Me.standaloneBarDockControl1.Name = "standaloneBarDockControl1"
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar2})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockControls.Add(Me.standaloneBarDockControl1)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bbiReply, Me.bbiReplyAll, Me.bbiForward})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 3
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiReply),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiReplyAll),
                New DevExpress.XtraBars.LinkPersistInfo(Me.bbiForward)
            })
            Me.bar2.OptionsBar.AllowQuickCustomization = False
            Me.bar2.OptionsBar.DrawDragBorder = False
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.StandaloneBarDockControl = Me.standaloneBarDockControl1
            resources.ApplyResources(Me.bar2, "bar2")
            ' 
            ' bbiReply
            ' 
            resources.ApplyResources(Me.bbiReply, "bbiReply")
            Me.bbiReply.Id = 0
            Me.bbiReply.ImageOptions.Image = My.Resources.Reply
            Me.bbiReply.Name = "bbiReply"
            Me.bbiReply.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' bbiReplyAll
            ' 
            resources.ApplyResources(Me.bbiReplyAll, "bbiReplyAll")
            Me.bbiReplyAll.Id = 1
            Me.bbiReplyAll.ImageOptions.Image = My.Resources.ReplyAll
            Me.bbiReplyAll.Name = "bbiReplyAll"
            Me.bbiReplyAll.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' bbiForward
            ' 
            resources.ApplyResources(Me.bbiForward, "bbiForward")
            Me.bbiForward.Id = 2
            Me.bbiForward.ImageOptions.Image = My.Resources.Forward
            Me.bbiForward.Name = "bbiForward"
            Me.bbiForward.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            resources.ApplyResources(Me.barDockControlTop, "barDockControlTop")
            Me.barDockControlTop.Manager = Me.barManager1
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            resources.ApplyResources(Me.barDockControlBottom, "barDockControlBottom")
            Me.barDockControlBottom.Manager = Me.barManager1
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            resources.ApplyResources(Me.barDockControlLeft, "barDockControlLeft")
            Me.barDockControlLeft.Manager = Me.barManager1
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            resources.ApplyResources(Me.barDockControlRight, "barDockControlRight")
            Me.barDockControlRight.Manager = Me.barManager1
            ' 
            ' pePhoto
            ' 
            Me.pePhoto.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.pePhoto, "pePhoto")
            Me.pePhoto.Name = "pePhoto"
            Me.pePhoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pePhoto.Properties.NullText = resources.GetString("pePhoto.Properties.NullText")
            Me.pePhoto.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter
            Me.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.pePhoto.StyleController = Me.layoutControl1
            ' 
            ' recMessage
            ' 
            Me.recMessage.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            Me.recMessage.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.recMessage, "recMessage")
            Me.recMessage.MenuManager = Me.barManager1
            Me.recMessage.Name = "recMessage"
            Me.recMessage.ReadOnly = True
            ' 
            ' linkView
            ' 
            resources.ApplyResources(Me.linkView, "linkView")
            Me.linkView.Name = "linkView"
            Me.linkView.Properties.AllowFocused = False
            Me.linkView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.linkView.Properties.Caption = resources.GetString("linkView.Properties.Caption")
            Me.linkView.Properties.StartLinkOnClickingEmptySpace = False
            Me.linkView.StyleController = Me.layoutControl1
            ' 
            ' lgAll
            ' 
            Me.lgAll.AppearanceGroup.BackColor = (DirectCast(resources.GetObject("lgAll.AppearanceGroup.BackColor"), System.Drawing.Color))
            Me.lgAll.AppearanceGroup.ForeColor = (DirectCast(resources.GetObject("lgAll.AppearanceGroup.ForeColor"), System.Drawing.Color))
            Me.lgAll.AppearanceGroup.Options.UseBackColor = True
            Me.lgAll.AppearanceGroup.Options.UseForeColor = True
            resources.ApplyResources(Me.lgAll, "lgAll")
            Me.lgAll.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.lgAll.GroupBordersVisible = False
            Me.lgAll.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3, Me.layoutControlItem2, Me.lgMessageInfo})
            Me.lgAll.Name = "lgAll"
            Me.lgAll.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lgAll.Size = New System.Drawing.Size(588, 605)
            Me.lgAll.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.recMessage
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 130)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem3.Size = New System.Drawing.Size(588, 453)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.linkView
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 583)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(588, 22)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            Me.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' lgMessageInfo
            ' 
            resources.ApplyResources(Me.lgMessageInfo, "lgMessageInfo")
            Me.lgMessageInfo.GroupBordersVisible = False
            Me.lgMessageInfo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lcPicture, Me.layoutControlItem7, Me.layoutControlItem6, Me.layoutControlItem1, Me.emptySpaceItem1, Me.simpleSeparator1, Me.layoutControlItem5})
            Me.lgMessageInfo.Location = New System.Drawing.Point(0, 0)
            Me.lgMessageInfo.Name = "lgMessageInfo"
            Me.lgMessageInfo.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lgMessageInfo.Size = New System.Drawing.Size(588, 130)
            Me.lgMessageInfo.TextVisible = False
            ' 
            ' lcPicture
            ' 
            Me.lcPicture.Control = Me.pePhoto
            resources.ApplyResources(Me.lcPicture, "lcPicture")
            Me.lcPicture.Location = New System.Drawing.Point(501, 28)
            Me.lcPicture.MaxSize = New System.Drawing.Size(87, 100)
            Me.lcPicture.MinSize = New System.Drawing.Size(87, 100)
            Me.lcPicture.Name = "lcPicture"
            Me.lcPicture.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.lcPicture.Size = New System.Drawing.Size(87, 100)
            Me.lcPicture.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lcPicture.TextSize = New System.Drawing.Size(0, 0)
            Me.lcPicture.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.lbDate
            resources.ApplyResources(Me.layoutControlItem7, "layoutControlItem7")
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 28)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(501, 17)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.lbFrom
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 45)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(501, 29)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.lbSubject
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 74)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(501, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            resources.ApplyResources(Me.emptySpaceItem1, "emptySpaceItem1")
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 98)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(501, 30)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' simpleSeparator1
            ' 
            Me.simpleSeparator1.AllowHotTrack = False
            resources.ApplyResources(Me.simpleSeparator1, "simpleSeparator1")
            Me.simpleSeparator1.Location = New System.Drawing.Point(0, 128)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(588, 2)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.standaloneBarDockControl1
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(588, 28)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' ucMailViewer
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ucMailViewer"
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.linkView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lgAll, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lgMessageInfo, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcPicture, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private recMessage As DevExpress.XtraRichEdit.RichEditControl
        Private linkView As DevExpress.XtraEditors.HyperLinkEdit
        Private layoutControl1 As XtraLayout.LayoutControl
        Private lgAll As XtraLayout.LayoutControlGroup
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private pePhoto As XtraEditors.PictureEdit
        Private lcPicture As XtraLayout.LayoutControlItem
        Private barManager1 As XtraBars.BarManager
        Private bar2 As XtraBars.Bar
        Private WithEvents bbiReply As XtraBars.BarButtonItem
        Private WithEvents bbiReplyAll As XtraBars.BarButtonItem
        Private WithEvents bbiForward As XtraBars.BarButtonItem
        Private barDockControlTop As XtraBars.BarDockControl
        Private barDockControlBottom As XtraBars.BarDockControl
        Private barDockControlLeft As XtraBars.BarDockControl
        Private barDockControlRight As XtraBars.BarDockControl
        Private standaloneBarDockControl1 As XtraBars.StandaloneBarDockControl
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private simpleSeparator1 As XtraLayout.SimpleSeparator
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private lbSubject As XtraEditors.LabelControl
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private lbDate As XtraEditors.LabelControl
        Private lbFrom As XtraEditors.LabelControl
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private layoutControlItem7 As XtraLayout.LayoutControlItem
        Private lgMessageInfo As XtraLayout.LayoutControlGroup
    End Class
End Namespace
