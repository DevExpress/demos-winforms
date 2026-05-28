Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class ucMessageInfo
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ucMessageInfo))
            Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
            Me.gcIcon = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.icEditors = New DevExpress.Utils.ImageCollection(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.lcName = New DevExpress.XtraEditors.LabelControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gcSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.lcgMail = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcgContact = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icEditors, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcgMail, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lcgContact, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gcIcon
            ' 
            resources.ApplyResources(Me.gcIcon, "gcIcon")
            Me.gcIcon.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.gcIcon.FieldName = "Read"
            Me.gcIcon.Name = "gcIcon"
            Me.gcIcon.OptionsColumn.AllowEdit = False
            Me.gcIcon.OptionsColumn.AllowFocus = False
            Me.gcIcon.OptionsColumn.AllowSize = False
            Me.gcIcon.OptionsColumn.FixedWidth = True
            Me.gcIcon.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemImageComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items1"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items4"), Object)), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items5"), Integer)))
            })
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.icEditors
            ' 
            ' icEditors
            ' 
            resources.ApplyResources(Me.icEditors, "icEditors")
            Me.icEditors.ImageStream = (DirectCast(resources.GetObject("icEditors.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.icEditors.Images.SetKeyName(0, "ReadMessage_13x13.png")
            Me.icEditors.Images.SetKeyName(1, "UnreadMessage_13x13.png")
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.lcName)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Controls.Add(Me.pictureEdit1)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            'this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' lcName
            ' 
            Me.lcName.Appearance.Font = (DirectCast(resources.GetObject("lcName.Appearance.Font"), System.Drawing.Font))
            resources.ApplyResources(Me.lcName, "lcName")
            Me.lcName.Name = "lcName"
            Me.lcName.StyleController = Me.layoutControl1
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gcIcon, Me.gcSubject, Me.gcDate})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            styleFormatCondition1.Appearance.Font = (DirectCast(resources.GetObject("resource.Font"), System.Drawing.Font))
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.gcIcon
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = 0
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            resources.ApplyResources(Me.gridView1, "gridView1")
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem((DirectCast(resources.GetObject("gridView1.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary1"), (DirectCast(resources.GetObject("gridView1.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn)), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsFind.AllowFindPanel = False
            Me.gridView1.OptionsPrint.PrintHorzLines = False
            Me.gridView1.OptionsPrint.PrintVertLines = False
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
            Me.gridView1.OptionsView.ShowGroupedColumns = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            ' 
            ' gcSubject
            ' 
            resources.ApplyResources(Me.gcSubject, "gcSubject")
            Me.gcSubject.FieldName = "Subject"
            Me.gcSubject.Name = "gcSubject"
            Me.gcSubject.OptionsColumn.AllowFocus = False
            ' 
            ' gcDate
            ' 
            resources.ApplyResources(Me.gcDate, "gcDate")
            Me.gcDate.FieldName = "Date"
            Me.gcDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.gcDate.Name = "gcDate"
            Me.gcDate.OptionsColumn.AllowFocus = False
            Me.gcDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt
            ' 
            ' pictureEdit1
            ' 
            resources.ApplyResources(Me.pictureEdit1, "pictureEdit1")
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.AllowFocused = False
            Me.pictureEdit1.Properties.ShowMenu = False
            Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            Me.pictureEdit1.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.tabbedControlGroup1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(725, 215)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.pictureEdit1
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(151, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(151, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(151, 203)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' tabbedControlGroup1
            ' 
            resources.ApplyResources(Me.tabbedControlGroup1, "tabbedControlGroup1")
            Me.tabbedControlGroup1.Location = New System.Drawing.Point(151, 0)
            Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
            Me.tabbedControlGroup1.SelectedTabPage = Me.lcgMail
            Me.tabbedControlGroup1.SelectedTabPageIndex = 0
            Me.tabbedControlGroup1.Size = New System.Drawing.Size(562, 203)
            Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lcgMail, Me.lcgContact})
            Me.tabbedControlGroup1.TextLocation = DevExpress.Utils.Locations.Left
            ' 
            ' lcgMail
            ' 
            Me.lcgMail.CaptionImage = My.Resources.Mail_16x16
            resources.ApplyResources(Me.lcgMail, "lcgMail")
            Me.lcgMail.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2})
            Me.lcgMail.Location = New System.Drawing.Point(0, 0)
            Me.lcgMail.Name = "lcgMail"
            Me.lcgMail.Size = New System.Drawing.Size(467, 179)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.gridControl1
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(467, 179)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' lcgContact
            ' 
            Me.lcgContact.CaptionImage = My.Resources.Mr
            resources.ApplyResources(Me.lcgContact, "lcgContact")
            Me.lcgContact.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3})
            Me.lcgContact.Location = New System.Drawing.Point(0, 0)
            Me.lcgContact.Name = "lcgContact"
            Me.lcgContact.Size = New System.Drawing.Size(467, 179)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.lcName
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(467, 179)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' ucMessageInfo
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ucMessageInfo"
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icEditors, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcgMail, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lcgContact, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
        Private lcgMail As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private lcgContact As DevExpress.XtraLayout.LayoutControlGroup
        Private lcName As DevExpress.XtraEditors.LabelControl
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private gcIcon As DevExpress.XtraGrid.Columns.GridColumn
        Private gcSubject As DevExpress.XtraGrid.Columns.GridColumn
        Private gcDate As DevExpress.XtraGrid.Columns.GridColumn
        Private icEditors As DevExpress.Utils.ImageCollection
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    End Class
End Namespace
