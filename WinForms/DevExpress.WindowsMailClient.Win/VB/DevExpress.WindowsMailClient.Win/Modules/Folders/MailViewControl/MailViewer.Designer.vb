Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraLayout

Namespace DevExpress.WindowsMailClient.Win.Modules

    Partial Class MailViewer

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.WindowsMailClient.Win.Modules.MailViewer))
            Me.contextButton1 = New DevExpress.Utils.ContextButton()
            Me.checkContextButton1 = New DevExpress.Utils.CheckContextButton()
            Me.contextButton2 = New DevExpress.Utils.ContextButton()
            Me.contextButton3 = New DevExpress.Utils.ContextButton()
            Dim itemTemplate1 As DevExpress.XtraGrid.Views.Tile.ItemTemplate = New DevExpress.XtraGrid.Views.Tile.ItemTemplate()
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim itemTemplate2 As DevExpress.XtraGrid.Views.Tile.ItemTemplate = New DevExpress.XtraGrid.Views.Tile.ItemTemplate()
            Dim tableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition4 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition5 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition6 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition7 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement9 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement10 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tableRowDefinition4 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition5 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition6 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition7 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan2 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan3 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan4 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan5 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan6 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan7 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim itemTemplate3 As DevExpress.XtraGrid.Views.Tile.ItemTemplate = New DevExpress.XtraGrid.Views.Tile.ItemTemplate()
            Dim tableColumnDefinition8 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition9 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition10 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition11 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition12 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tileViewItemElement11 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement12 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement13 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement14 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement15 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement16 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tableRowDefinition8 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition9 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition10 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition11 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan8 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan9 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan10 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan11 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan12 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan13 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableColumnDefinition13 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition14 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition15 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition16 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition17 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableRowDefinition12 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition13 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition14 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan14 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan15 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan16 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan17 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan18 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tileViewItemElement17 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement18 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement19 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement20 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement21 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Me.colDate = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colSubjectDisplayText = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colFrom = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colRead = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPlainText = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colTo = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPriority = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.mailPresenter = New DevExpress.WindowsMailClient.Win.Modules.MailPresenter()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.tileView = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colSubject = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colFlag = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.labelHeader = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.officeFilterTab = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
            Me.navigationItemFocused = New DevExpress.XtraBars.Navigation.NavigationBarItem()
            Me.navigationItemOther = New DevExpress.XtraBars.Navigation.NavigationBarItem()
            Me.pnlCtrlFilter = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.DropDownButton()
            Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.bcFilterAll = New DevExpress.XtraBars.BarCheckItem()
            Me.bcFilterUnread = New DevExpress.XtraBars.BarCheckItem()
            Me.bcFilterToday = New DevExpress.XtraBars.BarCheckItem()
            Me.bcFilterYesterday = New DevExpress.XtraBars.BarCheckItem()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.biSortDate = New DevExpress.XtraBars.BarButtonItem()
            Me.biSortFrom = New DevExpress.XtraBars.BarButtonItem()
            Me.biSortRead = New DevExpress.XtraBars.BarButtonItem()
            Me.biSortSubject = New DevExpress.XtraBars.BarButtonItem()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.bcFilterImportance = New DevExpress.XtraBars.BarCheckItem()
            Me.barSubItem2 = New DevExpress.XtraBars.BarSubItem()
            Me.biSortImportance = New DevExpress.XtraBars.BarButtonItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciFilter = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciHeader = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciTabFilter = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.notificationManager = New DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(Me.components)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tileView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.officeFilterTab), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pnlCtrlFilter), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlCtrlFilter.SuspendLayout()
            CType((Me.popupMenu), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciFilter), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciHeader), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciTabFilter), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.notificationManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.colDate.Caption = "colDate"
            Me.colDate.FieldName = "Date"
            Me.colDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.colDate.Name = "colDate"
            Me.colDate.Visible = True
            Me.colDate.VisibleIndex = 0
            Me.colSubjectDisplayText.Caption = "colSubjectDisplayText"
            Me.colSubjectDisplayText.FieldName = "SubjectDisplayText"
            Me.colSubjectDisplayText.Name = "colSubjectDisplayText"
            Me.colSubjectDisplayText.Visible = True
            Me.colSubjectDisplayText.VisibleIndex = 4
            Me.colFrom.Caption = "colFrom"
            Me.colFrom.FieldName = "From"
            Me.colFrom.Name = "colFrom"
            Me.colFrom.Visible = True
            Me.colFrom.VisibleIndex = 1
            Me.colRead.Caption = "colRead"
            Me.colRead.FieldName = "Read"
            Me.colRead.Name = "colRead"
            Me.colRead.Visible = True
            Me.colRead.VisibleIndex = 5
            Me.colPlainText.Caption = "colPlainText"
            Me.colPlainText.FieldName = "PlainText"
            Me.colPlainText.Name = "colPlainText"
            Me.colPlainText.Visible = True
            Me.colPlainText.VisibleIndex = 3
            Me.colTo.Caption = "colTo"
            Me.colTo.FieldName = "Email"
            Me.colTo.Name = "colTo"
            Me.colTo.Visible = True
            Me.colTo.VisibleIndex = 7
            Me.colTo.Width = 50
            Me.colPriority.Caption = "colPriority"
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.Name = "colPriority"
            Me.colPriority.Visible = True
            Me.colPriority.VisibleIndex = 6
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.mailPresenter.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mailPresenter.Location = New System.Drawing.Point(1, 0)
            Me.mailPresenter.Margin = New System.Windows.Forms.Padding(4)
            Me.mailPresenter.Name = "mailPresenter"
            Me.mailPresenter.Size = New System.Drawing.Size(402, 565)
            Me.mailPresenter.TabIndex = 4
            Me.gridControl1.Location = New System.Drawing.Point(0, 50)
            Me.gridControl1.MainView = Me.tileView
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(386, 515)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tileView})
            AddHandler Me.gridControl1.ControlAdded, New System.Windows.Forms.ControlEventHandler(AddressOf Me.gridControl1_ControlAdded)
            Me.tileView.Appearance.GroupText.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.tileView.Appearance.GroupText.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((248)))))), (CInt(((CByte((124)))))), (CInt(((CByte((50)))))))
            Me.tileView.Appearance.GroupText.Options.UseFont = True
            Me.tileView.Appearance.GroupText.Options.UseForeColor = True
            Me.tileView.Appearance.ItemNormal.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((210)))))), (CInt(((CByte((210)))))), (CInt(((CByte((210)))))))
            Me.tileView.Appearance.ItemNormal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.tileView.Appearance.ItemNormal.Options.UseBorderColor = True
            Me.tileView.Appearance.ItemNormal.Options.UseFont = True
            Me.tileView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDate, Me.colFrom, Me.colSubject, Me.colPlainText, Me.colSubjectDisplayText, Me.colRead, Me.colPriority, Me.colTo, Me.colFlag})
            Me.tileView.ColumnSet.GroupColumn = Me.colDate
            Me.tileView.ContextButtonOptions.Indent = 6
            Me.tileView.ContextButtonOptions.TopPanelPadding = New System.Windows.Forms.Padding(5, 10, 20, 5)
            Me.contextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            Me.contextButton1.AppearanceHover.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold)
            Me.contextButton1.AppearanceHover.Options.UseFont = True
            Me.contextButton1.AppearanceNormal.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.contextButton1.AppearanceNormal.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.contextButton1.AppearanceNormal.Options.UseFont = True
            Me.contextButton1.Id = New System.Guid("46c5197d-a771-45bb-9de8-afed5491a3c5")
            Me.contextButton1.ImageOptionsCollection.ItemNormal.SvgImage = CType((resources.GetObject("resource.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.contextButton1.Name = "cbExclamation"
            Me.contextButton1.Padding = New System.Windows.Forms.Padding(0, -1, 0, 0)
            Me.contextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible
            Me.checkContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            Me.checkContextButton1.Caption = Nothing
            Me.checkContextButton1.Id = New System.Guid("138952e2-c8b8-4393-b0e6-c3d082f37df5")
            Me.checkContextButton1.ImageOptionsCollection.ItemChecked.SvgImage = CType((resources.GetObject("resource.SvgImage1")), DevExpress.Utils.Svg.SvgImage)
            Me.checkContextButton1.ImageOptionsCollection.ItemHovered.SvgImage = CType((resources.GetObject("resource.SvgImage2")), DevExpress.Utils.Svg.SvgImage)
            Me.checkContextButton1.ImageOptionsCollection.ItemNormal.SvgImage = CType((resources.GetObject("resource.SvgImage3")), DevExpress.Utils.Svg.SvgImage)
            Me.checkContextButton1.ImageOptionsCollection.ItemNormal.SvgImageSize = New System.Drawing.Size(18, 18)
            Me.checkContextButton1.Name = "cbFlag"
            Me.contextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            Me.contextButton2.Id = New System.Guid("07c1aaac-55bd-4ebc-b850-93a79dede0db")
            Me.contextButton2.ImageOptionsCollection.ItemNormal.SvgImage = CType((resources.GetObject("resource.SvgImage4")), DevExpress.Utils.Svg.SvgImage)
            Me.contextButton2.Name = "cbRemove"
            Me.contextButton3.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far
            Me.contextButton3.Id = New System.Guid("83ef3e55-2c44-470e-acca-c4d796b1ecbd")
            Me.contextButton3.ImageOptionsCollection.ItemNormal.SvgImage = CType((resources.GetObject("resource.SvgImage5")), DevExpress.Utils.Svg.SvgImage)
            Me.contextButton3.Name = "cbShow"
            Me.tileView.ContextButtons.Add(Me.contextButton1)
            Me.tileView.ContextButtons.Add(Me.checkContextButton1)
            Me.tileView.ContextButtons.Add(Me.contextButton2)
            Me.tileView.ContextButtons.Add(Me.contextButton3)
            Me.tileView.FocusBorderColor = System.Drawing.Color.Transparent
            Me.tileView.GridControl = Me.gridControl1
            Me.tileView.Name = "tileView"
            Me.tileView.OptionsBehavior.AllowSmoothScrolling = True
            Me.tileView.OptionsFind.AlwaysVisible = True
            Me.tileView.OptionsTiles.AllowItemHover = True
            Me.tileView.OptionsTiles.AllowPressAnimation = False
            Me.tileView.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(21, 10, 0, 10)
            Me.tileView.OptionsTiles.HighlightFocusedTileOnGridLoad = True
            Me.tileView.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None
            Me.tileView.OptionsTiles.IndentBetweenGroups = 0
            Me.tileView.OptionsTiles.IndentBetweenItems = 20
            Me.tileView.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(0, 8, 12, 8)
            Me.tileView.OptionsTiles.ItemSize = New System.Drawing.Size(452, 71)
            Me.tileView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.tileView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.tileView.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.tileView.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.TouchScrollBar
            Me.tileView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDate, DevExpress.Data.ColumnSortOrder.Ascending)})
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition1.Length.Value = 28R
            tableColumnDefinition2.Length.Value = 214R
            itemTemplate1.Columns.Add(tableColumnDefinition1)
            itemTemplate1.Columns.Add(tableColumnDefinition2)
            tileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((154)))))), (CInt(((CByte((154)))))))
            tileViewItemElement1.Appearance.Normal.Options.UseFont = True
            tileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement1.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement1.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement1.Column = Me.colDate
            tileViewItemElement1.ColumnIndex = 1
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement1.RowIndex = 2
            tileViewItemElement1.Text = "colDate"
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement2.Appearance.Normal.Options.UseFont = True
            tileViewItemElement2.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement2.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement2.Column = Me.colSubjectDisplayText
            tileViewItemElement2.ColumnIndex = 1
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement2.RowIndex = 1
            tileViewItemElement2.Text = "colSubjectDisplayText"
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement3.Appearance.Normal.Options.UseFont = True
            tileViewItemElement3.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement3.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement3.Column = Me.colFrom
            tileViewItemElement3.ColumnIndex = 1
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement3.Text = "colFrom"
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement4.Column = Me.colRead
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement4.Name = "readElement"
            tileViewItemElement4.RowIndex = 1
            tileViewItemElement4.StretchVertical = True
            tileViewItemElement4.Text = "colRead"
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement4.TextVisible = False
            tileViewItemElement4.Width = 3
            itemTemplate1.Elements.Add(tileViewItemElement1)
            itemTemplate1.Elements.Add(tileViewItemElement2)
            itemTemplate1.Elements.Add(tileViewItemElement3)
            itemTemplate1.Elements.Add(tileViewItemElement4)
            itemTemplate1.Name = "smallsize"
            itemTemplate1.Rows.Add(tableRowDefinition1)
            itemTemplate1.Rows.Add(tableRowDefinition2)
            itemTemplate1.Rows.Add(tableRowDefinition3)
            tableSpan1.RowSpan = 3
            itemTemplate1.Spans.Add(tableSpan1)
            tableColumnDefinition3.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition3.Length.Value = 28R
            tableColumnDefinition4.Length.Value = 214R
            tableColumnDefinition5.Length.Value = 171R
            tableColumnDefinition6.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition6.Length.Value = 45R
            tableColumnDefinition7.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition7.Length.Value = 45R
            itemTemplate2.Columns.Add(tableColumnDefinition3)
            itemTemplate2.Columns.Add(tableColumnDefinition4)
            itemTemplate2.Columns.Add(tableColumnDefinition5)
            itemTemplate2.Columns.Add(tableColumnDefinition6)
            itemTemplate2.Columns.Add(tableColumnDefinition7)
            tileViewItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((154)))))), (CInt(((CByte((154)))))))
            tileViewItemElement5.Appearance.Normal.Options.UseFont = True
            tileViewItemElement5.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement5.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement5.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement5.Column = Me.colDate
            tileViewItemElement5.ColumnIndex = 4
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement5.RowIndex = 1
            tileViewItemElement5.Text = "colDate"
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
            tileViewItemElement6.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement6.Appearance.Normal.Options.UseFont = True
            tileViewItemElement6.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement6.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement6.Column = Me.colSubjectDisplayText
            tileViewItemElement6.ColumnIndex = 1
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement6.RowIndex = 2
            tileViewItemElement6.Text = "colSubjectDisplayText"
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement7.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement7.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((154)))))), (CInt(((CByte((154)))))))
            tileViewItemElement7.Appearance.Normal.Options.UseFont = True
            tileViewItemElement7.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement7.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement7.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement7.Column = Me.colPlainText
            tileViewItemElement7.ColumnIndex = 1
            tileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement7.RowIndex = 3
            tileViewItemElement7.Text = "colPlainText"
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement8.Appearance.Normal.Options.UseFont = True
            tileViewItemElement8.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement8.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement8.Column = Me.colFrom
            tileViewItemElement8.ColumnIndex = 2
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement8.Text = "colFrom"
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement9.Column = Me.colRead
            tileViewItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement9.Name = "readElement"
            tileViewItemElement9.RowIndex = 1
            tileViewItemElement9.StretchVertical = True
            tileViewItemElement9.Text = "colRead"
            tileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement9.TextVisible = False
            tileViewItemElement9.Width = 3
            tileViewItemElement10.Column = Me.colTo
            tileViewItemElement10.ColumnIndex = 1
            tileViewItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement10.RowIndex = 1
            tileViewItemElement10.Text = "colTo"
            tileViewItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            itemTemplate2.Elements.Add(tileViewItemElement5)
            itemTemplate2.Elements.Add(tileViewItemElement6)
            itemTemplate2.Elements.Add(tileViewItemElement7)
            itemTemplate2.Elements.Add(tileViewItemElement8)
            itemTemplate2.Elements.Add(tileViewItemElement9)
            itemTemplate2.Elements.Add(tileViewItemElement10)
            itemTemplate2.Name = "tileTemplate"
            tableRowDefinition4.Length.Value = 38R
            tableRowDefinition5.Length.Value = 25R
            tableRowDefinition6.Length.Value = 25R
            tableRowDefinition7.Length.Value = 25R
            itemTemplate2.Rows.Add(tableRowDefinition4)
            itemTemplate2.Rows.Add(tableRowDefinition5)
            itemTemplate2.Rows.Add(tableRowDefinition6)
            itemTemplate2.Rows.Add(tableRowDefinition7)
            tableSpan2.ColumnIndex = 1
            tableSpan2.ColumnSpan = 2
            tableSpan2.RowIndex = 1
            tableSpan3.ColumnIndex = 1
            tableSpan3.ColumnSpan = 3
            tableSpan4.ColumnIndex = 1
            tableSpan4.ColumnSpan = 3
            tableSpan4.RowIndex = 2
            tableSpan5.ColumnIndex = 3
            tableSpan5.ColumnSpan = 2
            tableSpan5.RowIndex = 1
            tableSpan6.ColumnIndex = 1
            tableSpan6.ColumnSpan = 3
            tableSpan6.RowIndex = 3
            tableSpan7.RowSpan = 4
            itemTemplate2.Spans.Add(tableSpan2)
            itemTemplate2.Spans.Add(tableSpan3)
            itemTemplate2.Spans.Add(tableSpan4)
            itemTemplate2.Spans.Add(tableSpan5)
            itemTemplate2.Spans.Add(tableSpan6)
            itemTemplate2.Spans.Add(tableSpan7)
            tableColumnDefinition8.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition8.Length.Value = 28R
            tableColumnDefinition9.Length.Value = 214R
            tableColumnDefinition10.Length.Value = 171R
            tableColumnDefinition11.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition11.Length.Value = 45R
            tableColumnDefinition12.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition12.Length.Value = 45R
            itemTemplate3.Columns.Add(tableColumnDefinition8)
            itemTemplate3.Columns.Add(tableColumnDefinition9)
            itemTemplate3.Columns.Add(tableColumnDefinition10)
            itemTemplate3.Columns.Add(tableColumnDefinition11)
            itemTemplate3.Columns.Add(tableColumnDefinition12)
            tileViewItemElement11.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement11.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((154)))))), (CInt(((CByte((154)))))))
            tileViewItemElement11.Appearance.Normal.Options.UseFont = True
            tileViewItemElement11.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement11.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement11.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement11.Column = Me.colDate
            tileViewItemElement11.ColumnIndex = 4
            tileViewItemElement11.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement11.RowIndex = 1
            tileViewItemElement11.Text = "colDate"
            tileViewItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
            tileViewItemElement12.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement12.Appearance.Normal.Options.UseFont = True
            tileViewItemElement12.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement12.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement12.Column = Me.colSubjectDisplayText
            tileViewItemElement12.ColumnIndex = 1
            tileViewItemElement12.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement12.RowIndex = 2
            tileViewItemElement12.Text = "colSubjectDisplayText"
            tileViewItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement13.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement13.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((154)))))), (CInt(((CByte((154)))))))
            tileViewItemElement13.Appearance.Normal.Options.UseFont = True
            tileViewItemElement13.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement13.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement13.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement13.Column = Me.colPlainText
            tileViewItemElement13.ColumnIndex = 1
            tileViewItemElement13.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement13.RowIndex = 3
            tileViewItemElement13.Text = "colPlainText"
            tileViewItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement14.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement14.Appearance.Normal.Options.UseFont = True
            tileViewItemElement14.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement14.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement14.Column = Me.colFrom
            tileViewItemElement14.ColumnIndex = 2
            tileViewItemElement14.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement14.Text = "colFrom"
            tileViewItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement15.Column = Me.colRead
            tileViewItemElement15.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement15.Name = "readElement"
            tileViewItemElement15.RowIndex = 1
            tileViewItemElement15.StretchVertical = True
            tileViewItemElement15.Text = "colRead"
            tileViewItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement15.TextVisible = False
            tileViewItemElement15.Width = 3
            tileViewItemElement16.Column = Me.colTo
            tileViewItemElement16.ColumnIndex = 1
            tileViewItemElement16.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement16.RowIndex = 1
            tileViewItemElement16.Text = "colTo"
            tileViewItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            itemTemplate3.Elements.Add(tileViewItemElement11)
            itemTemplate3.Elements.Add(tileViewItemElement12)
            itemTemplate3.Elements.Add(tileViewItemElement13)
            itemTemplate3.Elements.Add(tileViewItemElement14)
            itemTemplate3.Elements.Add(tileViewItemElement15)
            itemTemplate3.Elements.Add(tileViewItemElement16)
            itemTemplate3.Name = "template2"
            tableRowDefinition8.Length.Value = 38R
            tableRowDefinition9.Length.Value = 25R
            tableRowDefinition10.Length.Value = 25R
            tableRowDefinition11.Length.Value = 25R
            itemTemplate3.Rows.Add(tableRowDefinition8)
            itemTemplate3.Rows.Add(tableRowDefinition9)
            itemTemplate3.Rows.Add(tableRowDefinition10)
            itemTemplate3.Rows.Add(tableRowDefinition11)
            tableSpan8.ColumnIndex = 1
            tableSpan8.ColumnSpan = 2
            tableSpan8.RowIndex = 1
            tableSpan9.ColumnIndex = 1
            tableSpan9.ColumnSpan = 3
            tableSpan10.ColumnIndex = 1
            tableSpan10.ColumnSpan = 3
            tableSpan10.RowIndex = 2
            tableSpan11.ColumnIndex = 3
            tableSpan11.ColumnSpan = 2
            tableSpan11.RowIndex = 1
            tableSpan12.ColumnIndex = 1
            tableSpan12.ColumnSpan = 3
            tableSpan12.RowIndex = 3
            tableSpan13.RowSpan = 4
            itemTemplate3.Spans.Add(tableSpan8)
            itemTemplate3.Spans.Add(tableSpan9)
            itemTemplate3.Spans.Add(tableSpan10)
            itemTemplate3.Spans.Add(tableSpan11)
            itemTemplate3.Spans.Add(tableSpan12)
            itemTemplate3.Spans.Add(tableSpan13)
            Me.tileView.Templates.Add(itemTemplate1)
            Me.tileView.Templates.Add(itemTemplate2)
            Me.tileView.Templates.Add(itemTemplate3)
            tableColumnDefinition13.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition13.Length.Value = 21R
            tableColumnDefinition14.Length.Value = 179R
            tableColumnDefinition15.Length.Value = 143R
            tableColumnDefinition16.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition16.Length.Value = 47R
            tableColumnDefinition17.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition17.Length.Value = 43R
            Me.tileView.TileColumns.Add(tableColumnDefinition13)
            Me.tileView.TileColumns.Add(tableColumnDefinition14)
            Me.tileView.TileColumns.Add(tableColumnDefinition15)
            Me.tileView.TileColumns.Add(tableColumnDefinition16)
            Me.tileView.TileColumns.Add(tableColumnDefinition17)
            tableRowDefinition12.Length.Value = 25R
            tableRowDefinition13.Length.Value = 15R
            tableRowDefinition14.Length.Value = 15R
            Me.tileView.TileRows.Add(tableRowDefinition12)
            Me.tileView.TileRows.Add(tableRowDefinition13)
            Me.tileView.TileRows.Add(tableRowDefinition14)
            tableSpan14.ColumnIndex = 1
            tableSpan14.ColumnSpan = 2
            tableSpan14.RowIndex = 1
            tableSpan15.ColumnIndex = 1
            tableSpan15.ColumnSpan = 3
            tableSpan16.ColumnIndex = 3
            tableSpan16.ColumnSpan = 2
            tableSpan16.RowIndex = 1
            tableSpan17.ColumnIndex = 1
            tableSpan17.ColumnSpan = 3
            tableSpan17.RowIndex = 2
            tableSpan18.RowSpan = 4
            Me.tileView.TileSpans.Add(tableSpan14)
            Me.tileView.TileSpans.Add(tableSpan15)
            Me.tileView.TileSpans.Add(tableSpan16)
            Me.tileView.TileSpans.Add(tableSpan17)
            Me.tileView.TileSpans.Add(tableSpan18)
            tileViewItemElement17.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement17.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((154)))))), (CInt(((CByte((154)))))))
            tileViewItemElement17.Appearance.Normal.Options.UseFont = True
            tileViewItemElement17.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement17.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement17.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement17.Column = Me.colDate
            tileViewItemElement17.ColumnIndex = 3
            tileViewItemElement17.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement17.RowIndex = 1
            tileViewItemElement17.Text = "colDate"
            tileViewItemElement17.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement17.TextLocation = New System.Drawing.Point(10, 0)
            tileViewItemElement18.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement18.Appearance.Normal.Options.UseFont = True
            tileViewItemElement18.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement18.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement18.Column = Me.colSubjectDisplayText
            tileViewItemElement18.ColumnIndex = 1
            tileViewItemElement18.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement18.RowIndex = 1
            tileViewItemElement18.Text = "colSubjectDisplayText"
            tileViewItemElement18.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement19.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement19.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((145)))))), (CInt(((CByte((154)))))), (CInt(((CByte((154)))))))
            tileViewItemElement19.Appearance.Normal.Options.UseFont = True
            tileViewItemElement19.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement19.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement19.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement19.Column = Me.colPlainText
            tileViewItemElement19.ColumnIndex = 1
            tileViewItemElement19.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement19.RowIndex = 2
            tileViewItemElement19.Text = "colPlainText"
            tileViewItemElement19.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement20.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement20.Appearance.Normal.Options.UseFont = True
            tileViewItemElement20.Appearance.Normal.Options.UseTextOptions = True
            tileViewItemElement20.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
            tileViewItemElement20.Column = Me.colFrom
            tileViewItemElement20.ColumnIndex = 2
            tileViewItemElement20.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement20.Text = "colFrom"
            tileViewItemElement20.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement21.Column = Me.colRead
            tileViewItemElement21.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement21.Name = "readElement"
            tileViewItemElement21.RowIndex = 1
            tileViewItemElement21.StretchVertical = True
            tileViewItemElement21.Text = "colRead"
            tileViewItemElement21.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement21.TextLocation = New System.Drawing.Point(1, 0)
            tileViewItemElement21.TextVisible = False
            tileViewItemElement21.Width = 5
            Me.tileView.TileTemplate.Add(tileViewItemElement17)
            Me.tileView.TileTemplate.Add(tileViewItemElement18)
            Me.tileView.TileTemplate.Add(tileViewItemElement19)
            Me.tileView.TileTemplate.Add(tileViewItemElement20)
            Me.tileView.TileTemplate.Add(tileViewItemElement21)
            AddHandler Me.tileView.ContextButtonCustomize, New DevExpress.XtraGrid.Views.Tile.TileViewContextButtonCustomizeEventHandler(AddressOf Me.tileView_ContextButtonCustomize)
            AddHandler Me.tileView.ItemCustomize, New DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(AddressOf Me.tileView_ItemCustomize)
            AddHandler Me.tileView.CustomItemTemplate, New DevExpress.XtraGrid.Views.Tile.TileViewCustomItemTemplateEventHandler(AddressOf Me.tileView1_CustomItemTemplate)
            Me.colSubject.Caption = "colSubject"
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 2
            Me.colFlag.Caption = "colFlag"
            Me.colFlag.FieldName = "Flagged"
            Me.colFlag.Name = "colFlag"
            Me.colFlag.Visible = True
            Me.colFlag.VisibleIndex = 8
            Me.colFlag.Width = 112
            Me.sidePanel1.Controls.Add(Me.mailPresenter)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(386, 0)
            Me.sidePanel1.MinimumSize = New System.Drawing.Size(280, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(403, 565)
            Me.sidePanel1.TabIndex = 5
            Me.sidePanel1.Text = "sidePanel1"
            Me.labelHeader.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelHeader.Appearance.Options.UseFont = True
            Me.labelHeader.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelHeader.AppearanceHovered.Options.UseFont = True
            Me.labelHeader.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelHeader.AppearancePressed.Options.UseFont = True
            Me.labelHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelHeader.Location = New System.Drawing.Point(19, 29)
            Me.labelHeader.Margin = New System.Windows.Forms.Padding(0)
            Me.labelHeader.Name = "labelHeader"
            Me.labelHeader.Size = New System.Drawing.Size(68, 21)
            Me.labelHeader.StyleController = Me.layoutControl1
            Me.labelHeader.TabIndex = 0
            Me.labelHeader.Text = "Inbox"
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.AutoScroll = False
            Me.layoutControl1.Controls.Add(Me.officeFilterTab)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.pnlCtrlFilter)
            Me.layoutControl1.Controls.Add(Me.labelHeader)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2707, 545, 975, 600)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(386, 565)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            Me.officeFilterTab.AnimateItemPressing = False
            Me.officeFilterTab.AppearanceItem.Normal.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.officeFilterTab.AppearanceItem.Normal.Options.UseFont = True
            Me.officeFilterTab.AutoSize = False
            Me.officeFilterTab.BackColor = System.Drawing.Color.Transparent
            Me.officeFilterTab.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden
            Me.officeFilterTab.Items.AddRange(New DevExpress.XtraBars.Navigation.NavigationBarItem() {Me.navigationItemFocused, Me.navigationItemOther})
            Me.officeFilterTab.Location = New System.Drawing.Point(87, 29)
            Me.officeFilterTab.Name = "officeFilterTab"
            Me.officeFilterTab.SelectedItem = Me.navigationItemOther
            Me.officeFilterTab.Size = New System.Drawing.Size(125, 21)
            Me.officeFilterTab.TabIndex = 7
            Me.officeFilterTab.Text = "officeNavigationBar1"
            Me.officeFilterTab.ViewMode = DevExpress.XtraBars.Navigation.OfficeNavigationBarViewMode.Tab
            Me.navigationItemFocused.Name = "navigationItemFocused"
            Me.navigationItemFocused.Text = "Focused"
            Me.navigationItemOther.Name = "navigationItemOther"
            Me.navigationItemOther.Text = "Other"
            Me.pnlCtrlFilter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlCtrlFilter.Controls.Add(Me.labelControl1)
            Me.pnlCtrlFilter.Location = New System.Drawing.Point(319, 34)
            Me.pnlCtrlFilter.Margin = New System.Windows.Forms.Padding(2)
            Me.pnlCtrlFilter.Name = "pnlCtrlFilter"
            Me.pnlCtrlFilter.Size = New System.Drawing.Size(62, 16)
            Me.pnlCtrlFilter.TabIndex = 6
            Me.labelControl1.AllowFocus = False
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelControl1.AppearanceHovered.Options.UseFont = True
            Me.labelControl1.AppearancePressed.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelControl1.AppearancePressed.Options.UseFont = True
            Me.labelControl1.AutoSize = True
            Me.labelControl1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelControl1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show
            Me.labelControl1.DropDownControl = Me.popupMenu
            Me.labelControl1.Location = New System.Drawing.Point(0, 0)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(62, 16)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "Filter"
            Me.popupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bcFilterAll), New DevExpress.XtraBars.LinkPersistInfo(Me.bcFilterUnread), New DevExpress.XtraBars.LinkPersistInfo(Me.bcFilterToday), New DevExpress.XtraBars.LinkPersistInfo(Me.bcFilterYesterday), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1)})
            Me.popupMenu.Manager = Me.barManager1
            Me.popupMenu.MenuCaption = "Filter"
            Me.popupMenu.Name = "popupMenu"
            Me.popupMenu.ShowCaption = True
            Me.bcFilterAll.BindableChecked = True
            Me.bcFilterAll.Caption = "All"
            Me.bcFilterAll.Checked = True
            Me.bcFilterAll.GroupIndex = 22
            Me.bcFilterAll.Id = 1
            Me.bcFilterAll.Name = "bcFilterAll"
            Me.bcFilterUnread.Caption = "Unread"
            Me.bcFilterUnread.GroupIndex = 22
            Me.bcFilterUnread.Id = 2
            Me.bcFilterUnread.Name = "bcFilterUnread"
            Me.bcFilterToday.Caption = "Today"
            Me.bcFilterToday.GroupIndex = 22
            Me.bcFilterToday.Id = 4
            Me.bcFilterToday.Name = "bcFilterToday"
            Me.bcFilterYesterday.Caption = "Yesterday"
            Me.bcFilterYesterday.GroupIndex = 22
            Me.bcFilterYesterday.Id = 5
            Me.bcFilterYesterday.Name = "bcFilterYesterday"
            Me.barSubItem1.Caption = "Sort By"
            Me.barSubItem1.Id = 6
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biSortDate), New DevExpress.XtraBars.LinkPersistInfo(Me.biSortFrom), New DevExpress.XtraBars.LinkPersistInfo(Me.biSortRead), New DevExpress.XtraBars.LinkPersistInfo(Me.biSortSubject)})
            Me.barSubItem1.Name = "barSubItem1"
            Me.biSortDate.Caption = "Date"
            Me.biSortDate.Id = 7
            Me.biSortDate.Name = "biSortDate"
            Me.biSortFrom.Caption = "From"
            Me.biSortFrom.Id = 8
            Me.biSortFrom.Name = "biSortFrom"
            Me.biSortRead.Caption = "To"
            Me.biSortRead.Id = 9
            Me.biSortRead.Name = "biSortRead"
            Me.biSortSubject.Caption = "Subject"
            Me.biSortSubject.Id = 11
            Me.biSortSubject.Name = "biSortSubject"
            Me.barManager1.AllowGlyphSkinning = True
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.imageCollection2
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1, Me.bcFilterAll, Me.bcFilterUnread, Me.bcFilterImportance, Me.bcFilterToday, Me.bcFilterYesterday, Me.barSubItem1, Me.biSortDate, Me.biSortFrom, Me.biSortRead, Me.barSubItem2, Me.biSortSubject, Me.biSortImportance})
            Me.barManager1.MaxItemId = 13
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(789, 0)
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 565)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(789, 0)
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 565)
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(789, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 565)
            Me.imageCollection2.ImageStream = CType((resources.GetObject("imageCollection2.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection2.InsertGalleryImage("sortdesc_16x16.png", "grayscaleimages/data/sortdesc_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("grayscaleimages/data/sortdesc_16x16.png"), 0)
            Me.imageCollection2.Images.SetKeyName(0, "sortdesc_16x16.png")
            Me.imageCollection2.InsertGalleryImage("sortasc_16x16.png", "grayscaleimages/data/sortasc_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("grayscaleimages/data/sortasc_16x16.png"), 1)
            Me.imageCollection2.Images.SetKeyName(1, "sortasc_16x16.png")
            Me.barButtonItem1.Caption = "barButtonItem1"
            Me.barButtonItem1.Id = 0
            Me.barButtonItem1.Name = "barButtonItem1"
            Me.bcFilterImportance.Caption = "Important"
            Me.bcFilterImportance.GroupIndex = 22
            Me.bcFilterImportance.Id = 3
            Me.bcFilterImportance.Name = "bcFilterImportance"
            Me.barSubItem2.Caption = "Show As"
            Me.barSubItem2.Id = 10
            Me.barSubItem2.Name = "barSubItem2"
            Me.biSortImportance.Caption = "Importance"
            Me.biSortImportance.Id = 12
            Me.biSortImportance.Name = "biSortImportance"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem2, Me.lciFilter, Me.layoutControlItem1, Me.lciHeader, Me.lciTabFilter, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(386, 565)
            Me.layoutControlGroup1.TextVisible = False
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(214, 19)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(100, 30)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0)
            Me.emptySpaceItem2.Size = New System.Drawing.Size(100, 31)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.lciFilter.Control = Me.pnlCtrlFilter
            Me.lciFilter.Location = New System.Drawing.Point(314, 19)
            Me.lciFilter.MaxSize = New System.Drawing.Size(72, 32)
            Me.lciFilter.MinSize = New System.Drawing.Size(72, 30)
            Me.lciFilter.Name = "lciFilter"
            Me.lciFilter.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 15, 0)
            Me.lciFilter.Size = New System.Drawing.Size(72, 31)
            Me.lciFilter.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciFilter.TextSize = New System.Drawing.Size(0, 0)
            Me.lciFilter.TextVisible = False
            Me.layoutControlItem1.Control = Me.gridControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 50)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(100, 39)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(386, 515)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            Me.lciHeader.Control = Me.labelHeader
            Me.lciHeader.Location = New System.Drawing.Point(0, 19)
            Me.lciHeader.MinSize = New System.Drawing.Size(37, 30)
            Me.lciHeader.Name = "lciHeader"
            Me.lciHeader.Padding = New DevExpress.XtraLayout.Utils.Padding(19, 0, 10, 0)
            Me.lciHeader.Size = New System.Drawing.Size(87, 31)
            Me.lciHeader.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciHeader.TextSize = New System.Drawing.Size(0, 0)
            Me.lciHeader.TextVisible = False
            Me.lciHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.lciTabFilter.Control = Me.officeFilterTab
            Me.lciTabFilter.Location = New System.Drawing.Point(87, 19)
            Me.lciTabFilter.MinSize = New System.Drawing.Size(2, 10)
            Me.lciTabFilter.Name = "lciTabFilter"
            Me.lciTabFilter.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 2, 10, 0)
            Me.lciTabFilter.Size = New System.Drawing.Size(127, 31)
            Me.lciTabFilter.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciTabFilter.TextSize = New System.Drawing.Size(0, 0)
            Me.lciTabFilter.TextVisible = False
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(386, 19)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(386, 19)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 0)
            Me.emptySpaceItem1.Size = New System.Drawing.Size(386, 19)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.notificationManager.ApplicationId = "devenv"
            Me.notificationManager.ApplicationName = "DevExpress.WindowsMailClient.Win"
            Me.notificationManager.Notifications.AddRange(New DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties() {New DevExpress.XtraBars.ToastNotifications.ToastNotification("83c29859-c050-402c-8f28-081d0f3de154", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "Test notification", "Test notification body", "Test notification body 2", Nothing, DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.[Default], DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.[Long], Nothing, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.[Default], DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic)})
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "MailViewer"
            Me.Size = New System.Drawing.Size(789, 565)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tileView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.officeFilterTab), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pnlCtrlFilter), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlCtrlFilter.ResumeLayout(False)
            Me.pnlCtrlFilter.PerformLayout()
            CType((Me.popupMenu), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciFilter), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciHeader), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciTabFilter), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.notificationManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer

        Private mailPresenter As DevExpress.WindowsMailClient.Win.Modules.MailPresenter

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private tileView As DevExpress.XtraGrid.Views.Tile.TileView

        Private colDate As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colFrom As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colSubject As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPlainText As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colSubjectDisplayText As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colRead As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colPriority As DevExpress.XtraGrid.Columns.TileViewColumn

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private labelHeader As DevExpress.XtraEditors.LabelControl

        Private labelControl1 As DevExpress.XtraEditors.DropDownButton

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private popupMenu As DevExpress.XtraBars.PopupMenu

        Private bcFilterAll As DevExpress.XtraBars.BarCheckItem

        Private bcFilterUnread As DevExpress.XtraBars.BarCheckItem

        Private bcFilterImportance As DevExpress.XtraBars.BarCheckItem

        Private bcFilterToday As DevExpress.XtraBars.BarCheckItem

        Private bcFilterYesterday As DevExpress.XtraBars.BarCheckItem

        Private barSubItem1 As DevExpress.XtraBars.BarSubItem

        Private biSortDate As DevExpress.XtraBars.BarButtonItem

        Private biSortFrom As DevExpress.XtraBars.BarButtonItem

        Private biSortRead As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private barSubItem2 As DevExpress.XtraBars.BarSubItem

        Private biSortSubject As DevExpress.XtraBars.BarButtonItem

        Private biSortImportance As DevExpress.XtraBars.BarButtonItem

        Private imageCollection2 As DevExpress.Utils.ImageCollection

        Private colTo As DevExpress.XtraGrid.Columns.TileViewColumn

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private lciHeader As DevExpress.XtraLayout.LayoutControlItem

        Private pnlCtrlFilter As DevExpress.XtraEditors.PanelControl

        Private lciFilter As DevExpress.XtraLayout.LayoutControlItem

        Private notificationManager As DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager

        Private contextButton1 As DevExpress.Utils.ContextButton

        Private checkContextButton1 As DevExpress.Utils.CheckContextButton

        Private contextButton2 As DevExpress.Utils.ContextButton

        Private contextButton3 As DevExpress.Utils.ContextButton

        Private colFlag As DevExpress.XtraGrid.Columns.TileViewColumn

        Private officeFilterTab As DevExpress.XtraBars.Navigation.OfficeNavigationBar

        Private lciTabFilter As DevExpress.XtraLayout.LayoutControlItem

        Private navigationItemFocused As DevExpress.XtraBars.Navigation.NavigationBarItem

        Private navigationItemOther As DevExpress.XtraBars.Navigation.NavigationBarItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
