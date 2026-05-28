Namespace DevExpress.XtraGrid.Demos

    Partial Class GridInstantFeedbackUI

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.GridInstantFeedbackUI))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.xpAsyncServerModeSource1 = New DevExpress.Xpo.XPInstantFeedbackSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFrom = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSent = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSize = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHasAttachment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colExpression = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sbShowSQLConnection = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.icbAnimation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.panelControl1layoutControl2ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.icbAnimationitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCheckEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbAnimation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1layoutControl2ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1layoutControl2ConvertedLayout.SuspendLayout()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbAnimationitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.xpAsyncServerModeSource1
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemCheckEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' xpAsyncServerModeSource1
            ' 
            Me.xpAsyncServerModeSource1.ObjectType = GetType(DevExpress.XtraGrid.Demos.ServerSideGridTest)
            AddHandler Me.xpAsyncServerModeSource1.ResolveSession, New System.EventHandler(Of DevExpress.Xpo.ResolveSessionEventArgs)(AddressOf Me.xpAsyncServerModeSource1_ResolveSession)
            AddHandler Me.xpAsyncServerModeSource1.DismissSession, New System.EventHandler(Of DevExpress.Xpo.ResolveSessionEventArgs)(AddressOf Me.xpAsyncServerModeSource1_DismissSession)
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colSubject, Me.colFrom, Me.colSent, Me.colSize, Me.colHasAttachment, Me.colPriority, Me.colExpression})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary4")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary5"), CType((resources.GetObject("gridView1.GroupSummary6")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary7"))})
            Me.gridView1.Images = Me.svgImageCollection1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.ShowFooter = True
            AddHandler Me.gridView1.CustomColumnDisplayText, New DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(AddressOf Me.gridView1_CustomColumnDisplayText)
            ' 
            ' colOid
            ' 
            resources.ApplyResources(Me.colOid, "colOid")
            Me.colOid.FieldName = "Oid"
            Me.colOid.Name = "colOid"
            Me.colOid.OptionsColumn.[ReadOnly] = True
            Me.colOid.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colOid.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' colSubject
            ' 
            resources.ApplyResources(Me.colSubject, "colSubject")
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            ' 
            ' colFrom
            ' 
            resources.ApplyResources(Me.colFrom, "colFrom")
            Me.colFrom.FieldName = "From"
            Me.colFrom.Name = "colFrom"
            ' 
            ' colSent
            ' 
            resources.ApplyResources(Me.colSent, "colSent")
            Me.colSent.FieldName = "Sent"
            Me.colSent.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth
            Me.colSent.Name = "colSent"
            ' 
            ' colSize
            ' 
            resources.ApplyResources(Me.colSize, "colSize")
            Me.colSize.DisplayFormat.FormatString = "{0:n0} KB"
            Me.colSize.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSize.FieldName = "Size"
            Me.colSize.Name = "colSize"
            Me.colSize.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colSize.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("colSize.Summary1"), resources.GetString("colSize.Summary2"))})
            ' 
            ' colHasAttachment
            ' 
            resources.ApplyResources(Me.colHasAttachment, "colHasAttachment")
            Me.colHasAttachment.ColumnEdit = Me.repositoryItemCheckEdit1
            Me.colHasAttachment.FieldName = "HasAttachment"
            Me.colHasAttachment.ImageOptions.Alignment = CType((resources.GetObject("colHasAttachment.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.colHasAttachment.ImageOptions.ImageIndex =(CInt((resources.GetObject("colHasAttachment.ImageOptions.ImageIndex"))))
            Me.colHasAttachment.Name = "colHasAttachment"
            Me.colHasAttachment.OptionsColumn.AllowSize = False
            Me.colHasAttachment.OptionsColumn.FixedWidth = True
            Me.colHasAttachment.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemCheckEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemCheckEdit1, "repositoryItemCheckEdit1")
            Me.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
            Me.repositoryItemCheckEdit1.ImageOptions.ImageIndexChecked = 4
            Me.repositoryItemCheckEdit1.ImageOptions.Images = Me.svgImageCollection1
            Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
            Me.repositoryItemCheckEdit1.[ReadOnly] = True
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("system.Drawing.Bitmap", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_1", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_2", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_2")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_3", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_3")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("system.Drawing.Bitmap_4", CType((resources.GetObject("svgImageCollection1.system.Drawing.Bitmap_4")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Icon", CType((resources.GetObject("svgImageCollection1.Icon")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' colPriority
            ' 
            resources.ApplyResources(Me.colPriority, "colPriority")
            Me.colPriority.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.ImageOptions.Alignment = CType((resources.GetObject("colPriority.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.colPriority.ImageOptions.ImageIndex =(CInt((resources.GetObject("colPriority.ImageOptions.ImageIndex"))))
            Me.colPriority.Name = "colPriority"
            Me.colPriority.OptionsColumn.AllowSize = False
            Me.colPriority.OptionsColumn.FixedWidth = True
            Me.colPriority.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items7")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items8")))))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.svgImageCollection1
            ' 
            ' colExpression
            ' 
            resources.ApplyResources(Me.colExpression, "colExpression")
            Me.colExpression.FieldName = "Expression"
            Me.colExpression.Name = "colExpression"
            Me.colExpression.ShowUnboundExpressionMenu = True
            Me.colExpression.UnboundExpression = "DateDiffMinute([Sent], Now())"
            Me.colExpression.UnboundDataType = GetType(Integer)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.sbShowSQLConnection)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5})
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' sbShowSQLConnection
            ' 
            resources.ApplyResources(Me.sbShowSQLConnection, "sbShowSQLConnection")
            Me.sbShowSQLConnection.Name = "sbShowSQLConnection"
            Me.sbShowSQLConnection.StyleController = Me.layoutControl1
            AddHandler Me.sbShowSQLConnection.Click, New System.EventHandler(AddressOf Me.sbShowSQLConnection_Click)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.sbShowSQLConnection
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 436)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem5.Size = New System.Drawing.Size(119, 33)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(542, 577)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl1
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(542, 577)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' icbAnimation
            ' 
            resources.ApplyResources(Me.icbAnimation, "icbAnimation")
            Me.icbAnimation.Name = "icbAnimation"
            Me.icbAnimation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbAnimation.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbAnimation.StyleController = Me.panelControl1layoutControl2ConvertedLayout
            AddHandler Me.icbAnimation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbAnimation_SelectedIndexChanged)
            ' 
            ' panelControl1layoutControl2ConvertedLayout
            ' 
            Me.panelControl1layoutControl2ConvertedLayout.AllowCustomization = False
            Me.panelControl1layoutControl2ConvertedLayout.Controls.Add(Me.icbAnimation)
            resources.ApplyResources(Me.panelControl1layoutControl2ConvertedLayout, "panelControl1layoutControl2ConvertedLayout")
            Me.panelControl1layoutControl2ConvertedLayout.Name = "panelControl1layoutControl2ConvertedLayout"
            Me.panelControl1layoutControl2ConvertedLayout.Root = Me.layoutControlGroup2
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 550)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.icbAnimationitem})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 63)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup3, "layoutControlGroup3")
            ' 
            ' icbAnimationitem
            ' 
            Me.icbAnimationitem.Control = Me.icbAnimation
            Me.icbAnimationitem.Location = New System.Drawing.Point(0, 0)
            Me.icbAnimationitem.Name = "icbAnimationitem"
            Me.icbAnimationitem.Size = New System.Drawing.Size(229, 24)
            resources.ApplyResources(Me.icbAnimationitem, "icbAnimationitem")
            Me.icbAnimationitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.icbAnimationitem.TextSize = New System.Drawing.Size(0, 0)
            Me.icbAnimationitem.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 63)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 487)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.[Default]
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            resources.ApplyResources(Me.tabPane1, "tabPane1")
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(249, 577)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            ' 
            ' tabNavigationPage1
            ' 
            resources.ApplyResources(Me.tabNavigationPage1, "tabNavigationPage1")
            Me.tabNavigationPage1.Controls.Add(Me.panelControl1layoutControl2ConvertedLayout)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            ' 
            ' GridInstantFeedbackUI
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "GridInstantFeedbackUI"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCheckEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbAnimation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1layoutControl2ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1layoutControl2ConvertedLayout.ResumeLayout(False)
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbAnimationitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colOid As DevExpress.XtraGrid.Columns.GridColumn

        Private colSubject As DevExpress.XtraGrid.Columns.GridColumn

        Private colFrom As DevExpress.XtraGrid.Columns.GridColumn

        Private colSent As DevExpress.XtraGrid.Columns.GridColumn

        Private colSize As DevExpress.XtraGrid.Columns.GridColumn

        Private colHasAttachment As DevExpress.XtraGrid.Columns.GridColumn

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private sbShowSQLConnection As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private xpAsyncServerModeSource1 As DevExpress.Xpo.XPInstantFeedbackSource

        Private icbAnimation As DevExpress.XtraEditors.ImageComboBoxEdit

        Private colPriority As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

        Private colExpression As DevExpress.XtraGrid.Columns.GridColumn

        Private panelControl1layoutControl2ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private icbAnimationitem As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
