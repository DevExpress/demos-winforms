Namespace DevExpress.XtraGrid.Demos

    Partial Class GridAnimations

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
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.GridAnimations))
            Dim styleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.icbAnimation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.icbAnimation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridColumn2
            ' 
            resources.ApplyResources(Me.gridColumn2, "gridColumn2")
            Me.gridColumn2.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.gridColumn2.FieldName = "Read"
            Me.gridColumn2.ImageOptions.SvgImage = CType((resources.GetObject("gridColumn2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.gridColumn2.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.OptionsColumn.AllowEdit = False
            Me.gridColumn2.OptionsColumn.AllowFocus = False
            Me.gridColumn2.OptionsColumn.AllowSize = False
            Me.gridColumn2.OptionsColumn.FixedWidth = True
            Me.gridColumn2.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox2
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox2, "repositoryItemImageComboBox2")
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox2.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox2.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox2.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox2.Items5")))))})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.imageCollection1
            ' 
            ' imageCollection1
            ' 
            resources.ApplyResources(Me.imageCollection1, "imageCollection1")
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "mail1.png")
            Me.imageCollection1.Images.SetKeyName(1, "mail2.png")
            Me.imageCollection1.Images.SetKeyName(2, "attach.png")
            ' 
            ' colPriority
            ' 
            resources.ApplyResources(Me.colPriority, "colPriority")
            Me.colPriority.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPriority.FieldName = "gridColumn1"
            Me.colPriority.ImageOptions.SvgImage = CType((resources.GetObject("colPriority.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colPriority.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colPriority.Name = "colPriority"
            Me.colPriority.OptionsColumn.AllowEdit = False
            Me.colPriority.OptionsColumn.AllowFocus = False
            Me.colPriority.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colPriority.OptionsColumn.AllowSize = False
            Me.colPriority.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colPriority.OptionsColumn.FixedWidth = True
            Me.colPriority.OptionsColumn.ShowCaption = False
            Me.colPriority.UnboundDataType = GetType(Object)
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            resources.ApplyResources(Me.repositoryItemPictureEdit1, "repositoryItemPictureEdit1")
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.repositoryItemPictureEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPriority, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7, Me.gridColumn8})
            styleFormatCondition1.Appearance.Font = CType((resources.GetObject("resource.Font")), System.Drawing.Font)
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.gridColumn2
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = 0
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            resources.ApplyResources(Me.gridView1, "gridView1")
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
            Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
            Me.gridView1.OptionsView.ShowGroupedColumns = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView1.RowHeight = 20
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn8, DevExpress.Data.ColumnSortOrder.Descending)})
            AddHandler Me.gridView1.CustomDrawGroupRow, New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(AddressOf Me.gridView1_CustomDrawGroupRow)
            AddHandler Me.gridView1.ShowFilterPopupListBox, New DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventHandler(AddressOf Me.gridView1_ShowFilterPopupListBox)
            AddHandler Me.gridView1.CustomUnboundColumnData, New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(AddressOf Me.gridView1_CustomUnboundColumnData)
            ' 
            ' gridColumn3
            ' 
            resources.ApplyResources(Me.gridColumn3, "gridColumn3")
            Me.gridColumn3.ColumnEdit = Me.repositoryItemImageComboBox3
            Me.gridColumn3.FieldName = "Attachment"
            Me.gridColumn3.ImageOptions.SvgImage = CType((resources.GetObject("gridColumn3.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.gridColumn3.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.OptionsColumn.AllowEdit = False
            Me.gridColumn3.OptionsColumn.AllowFocus = False
            Me.gridColumn3.OptionsColumn.AllowSize = False
            Me.gridColumn3.OptionsColumn.FixedWidth = True
            Me.gridColumn3.OptionsColumn.ShowCaption = False
            ' 
            ' repositoryItemImageComboBox3
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox3, "repositoryItemImageComboBox3")
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox3.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox3.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox3.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox3.Items5")))))})
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            Me.repositoryItemImageComboBox3.SmallImages = Me.imageCollection1
            ' 
            ' gridColumn4
            ' 
            resources.ApplyResources(Me.gridColumn4, "gridColumn4")
            Me.gridColumn4.FieldName = "Subject"
            Me.gridColumn4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Alphabetical
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.OptionsColumn.AllowFocus = False
            ' 
            ' gridColumn5
            ' 
            resources.ApplyResources(Me.gridColumn5, "gridColumn5")
            Me.gridColumn5.FieldName = "From"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.OptionsColumn.AllowFocus = False
            ' 
            ' gridColumn6
            ' 
            resources.ApplyResources(Me.gridColumn6, "gridColumn6")
            Me.gridColumn6.FieldName = "To"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsColumn.AllowFocus = False
            ' 
            ' gridColumn7
            ' 
            resources.ApplyResources(Me.gridColumn7, "gridColumn7")
            Me.gridColumn7.ColumnEdit = Me.repositoryItemDateEdit1
            Me.gridColumn7.FieldName = "Sent"
            Me.gridColumn7.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.gridColumn7.Name = "gridColumn7"
            Me.gridColumn7.OptionsColumn.AllowFocus = False
            ' 
            ' repositoryItemDateEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemDateEdit1, "repositoryItemDateEdit1")
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemDateEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit1.DisplayFormat.FormatString = "g"
            Me.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.repositoryItemDateEdit1.Mask.EditMask = resources.GetString("repositoryItemDateEdit1.Mask.EditMask")
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            ' 
            ' gridColumn8
            ' 
            resources.ApplyResources(Me.gridColumn8, "gridColumn8")
            Me.gridColumn8.ColumnEdit = Me.repositoryItemDateEdit1
            Me.gridColumn8.FieldName = "Received"
            Me.gridColumn8.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.gridColumn8.Name = "gridColumn8"
            Me.gridColumn8.OptionsColumn.AllowFocus = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.icbAnimation)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' icbAnimation
            ' 
            resources.ApplyResources(Me.icbAnimation, "icbAnimation")
            Me.icbAnimation.Name = "icbAnimation"
            Me.icbAnimation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbAnimation.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            AddHandler Me.icbAnimation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbAnimation_SelectedIndexChanged)
            ' 
            ' labelControl1
            ' 
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            Me.labelControl1.Name = "labelControl1"
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.panelControl2, "panelControl2")
            Me.panelControl2.Name = "panelControl2"
            ' 
            ' GridAnimations
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "GridAnimations"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.GridAnimations_Load)
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.icbAnimation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colPriority As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private components As System.ComponentModel.IContainer

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private icbAnimation As DevExpress.XtraEditors.ImageComboBoxEdit

        Private panelControl2 As DevExpress.XtraEditors.PanelControl

        Private imageCollection1 As DevExpress.Utils.ImageCollection
    End Class
End Namespace
