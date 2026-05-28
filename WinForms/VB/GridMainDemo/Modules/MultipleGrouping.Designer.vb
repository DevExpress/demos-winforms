Imports DevExpress.Export

Namespace DevExpress.XtraGrid.Demos

    Partial Class MultipleGrouping

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.MultipleGrouping))
            Dim styleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Dim styleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.colComplete = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPercentComplete = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.colTask = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.sbGroup = New DevExpress.XtraEditors.SimpleButton()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoExEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colComplete
            ' 
            resources.ApplyResources(Me.colComplete, "colComplete")
            Me.colComplete.FieldName = "Complete"
            Me.colComplete.ImageOptions.Alignment = CType((resources.GetObject("colComplete.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.colComplete.ImageOptions.ImageIndex =(CInt((resources.GetObject("colComplete.ImageOptions.ImageIndex"))))
            Me.colComplete.Name = "colComplete"
            Me.colComplete.OptionsColumn.AllowSize = False
            Me.colComplete.OptionsColumn.FixedWidth = True
            Me.colComplete.OptionsColumn.ShowCaption = False
            Me.colComplete.OptionsFilter.AllowFilter = False
            ' 
            ' colPercentComplete
            ' 
            resources.ApplyResources(Me.colPercentComplete, "colPercentComplete")
            Me.colPercentComplete.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colPercentComplete.FieldName = "PercentComplete"
            Me.colPercentComplete.Name = "colPercentComplete"
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
            Me.repositoryItemTextEdit1.Mask.MaskType = CType((resources.GetObject("repositoryItemTextEdit1.Mask.MaskType")), DevExpress.XtraEditors.Mask.MaskType)
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat =(CBool((resources.GetObject("repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat"))))
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemMemoExEdit1, Me.repositoryItemTextEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colImage, Me.colTask, Me.colCategory, Me.colDueDate, Me.colComplete, Me.colPercentComplete, Me.colNote})
            styleFormatCondition1.Appearance.Font = CType((resources.GetObject("resource.Font")), System.Drawing.Font)
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Gray
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.Appearance.Options.UseForeColor = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.colComplete
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = True
            styleFormatCondition2.Appearance.Font = CType((resources.GetObject("resource.Font1")), System.Drawing.Font)
            styleFormatCondition2.Appearance.Options.UseFont = True
            styleFormatCondition2.ApplyToRow = True
            styleFormatCondition2.Column = Me.colPercentComplete
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between
            styleFormatCondition2.Value1 = 0
            styleFormatCondition2.Value2 = 100
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1, styleFormatCondition2})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Images = Me.imageCollection1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.OptionsView.ShowGroupedColumns = True
            ' 
            ' colImage
            ' 
            resources.ApplyResources(Me.colImage, "colImage")
            Me.colImage.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colImage.ImageOptions.Alignment = CType((resources.GetObject("colImage.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.colImage.ImageOptions.ImageIndex =(CInt((resources.GetObject("colImage.ImageOptions.ImageIndex"))))
            Me.colImage.Name = "colImage"
            Me.colImage.OptionsColumn.AllowEdit = False
            Me.colImage.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colImage.OptionsColumn.AllowIncrementalSearch = False
            Me.colImage.OptionsColumn.AllowMove = False
            Me.colImage.OptionsColumn.AllowSize = False
            Me.colImage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colImage.OptionsColumn.FixedWidth = True
            Me.colImage.OptionsColumn.[ReadOnly] = True
            Me.colImage.OptionsColumn.ShowCaption = False
            Me.colImage.OptionsFilter.AllowFilter = False
            Me.colImage.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("colImage.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items2")))))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageCollection1
            ' 
            ' imageCollection1
            ' 
            resources.ApplyResources(Me.imageCollection1, "imageCollection1")
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "order.png")
            Me.imageCollection1.Images.SetKeyName(1, "doc.png")
            Me.imageCollection1.Images.SetKeyName(2, "check.png")
            ' 
            ' colTask
            ' 
            resources.ApplyResources(Me.colTask, "colTask")
            Me.colTask.FieldName = "TaskName"
            Me.colTask.Name = "colTask"
            ' 
            ' colCategory
            ' 
            resources.ApplyResources(Me.colCategory, "colCategory")
            Me.colCategory.FieldName = "CategoryName"
            Me.colCategory.Name = "colCategory"
            ' 
            ' colDueDate
            ' 
            resources.ApplyResources(Me.colDueDate, "colDueDate")
            Me.colDueDate.FieldName = "DueDate"
            Me.colDueDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.colDueDate.Name = "colDueDate"
            ' 
            ' colNote
            ' 
            resources.ApplyResources(Me.colNote, "colNote")
            Me.colNote.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.colNote.FieldName = "Note"
            Me.colNote.Name = "colNote"
            Me.colNote.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.colNote.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colNote.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemMemoExEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemMemoExEdit1, "repositoryItemMemoExEdit1")
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemMemoExEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.sbGroup)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' sbGroup
            ' 
            resources.ApplyResources(Me.sbGroup, "sbGroup")
            Me.sbGroup.Name = "sbGroup"
            AddHandler Me.sbGroup.Click, New System.EventHandler(AddressOf Me.sbGroup_Click)
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.panelControl2, "panelControl2")
            Me.panelControl2.Name = "panelControl2"
            ' 
            ' MultipleGrouping
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "MultipleGrouping"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.MultipleGrouping_Load)
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoExEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colTask As DevExpress.XtraGrid.Columns.GridColumn

        Private colCategory As DevExpress.XtraGrid.Columns.GridColumn

        Private colDueDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colComplete As DevExpress.XtraGrid.Columns.GridColumn

        Private colPercentComplete As DevExpress.XtraGrid.Columns.GridColumn

        Private colNote As DevExpress.XtraGrid.Columns.GridColumn

        Private colImage As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private sbGroup As DevExpress.XtraEditors.SimpleButton

        Private components As System.ComponentModel.IContainer

        Private panelControl2 As DevExpress.XtraEditors.PanelControl

        Private imageCollection1 As DevExpress.Utils.ImageCollection
    End Class
End Namespace
