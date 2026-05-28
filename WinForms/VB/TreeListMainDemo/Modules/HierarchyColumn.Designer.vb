Namespace DevExpress.XtraTreeList.Demos

    Partial Class HierarchyColumn

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraTreeList.Demos.HierarchyColumn))
            Dim treeListFormatRule1 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim formatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Me.statusColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.completedColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemCompletedComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.svgImageCollection = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.priorityColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemPriorityComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.employeeColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.taskColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.startDateColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.dueDateColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.descriptionColumn = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemDescriptionComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.sidePanel = New DevExpress.XtraEditors.SidePanel()
            Me.navigationPane = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.ucScrollAnnotationsOptions = New DevExpress.XtraTreeList.Demos.Options.ucScrollAnnotationsOptions()
            CType((Me.repositoryItemCompletedComboBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPriorityComboBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDescriptionComboBox), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel.SuspendLayout()
            CType((Me.navigationPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane.SuspendLayout()
            Me.navigationPage.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' statusColumn
            ' 
            Me.statusColumn.AppearanceCell.Options.UseTextOptions = True
            Me.statusColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.statusColumn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.statusColumn.Caption = "Status"
            Me.statusColumn.FieldName = "Status"
            Me.statusColumn.Format.FormatString = "{0}%"
            Me.statusColumn.Format.FormatType = DevExpress.Utils.FormatType.Custom
            Me.statusColumn.MaxWidth = 100
            Me.statusColumn.MinWidth = 80
            Me.statusColumn.Name = "statusColumn"
            Me.statusColumn.Visible = True
            Me.statusColumn.VisibleIndex = 5
            Me.statusColumn.Width = 97
            ' 
            ' completedColumn
            ' 
            Me.completedColumn.ColumnEdit = Me.repositoryItemCompletedComboBox
            Me.completedColumn.FieldName = "IsCompleted"
            Me.completedColumn.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
            Me.completedColumn.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
            Me.completedColumn.ImageOptions.SvgImage = CType((resources.GetObject("completedColumn.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.completedColumn.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.completedColumn.MaxWidth = 33
            Me.completedColumn.MinWidth = 33
            Me.completedColumn.Name = "completedColumn"
            Me.completedColumn.OptionsColumn.AllowEdit = False
            Me.completedColumn.OptionsColumn.AllowFocus = False
            Me.completedColumn.OptionsColumn.AllowMove = False
            Me.completedColumn.OptionsColumn.AllowSize = False
            Me.completedColumn.OptionsColumn.AllowSort = False
            Me.completedColumn.OptionsFilter.AllowAutoFilter = False
            Me.completedColumn.OptionsFilter.AllowFilter = False
            Me.completedColumn.ToolTip = "Completed"
            Me.completedColumn.Visible = True
            Me.completedColumn.VisibleIndex = 0
            Me.completedColumn.Width = 33
            ' 
            ' repositoryItemCompletedComboBox
            ' 
            Me.repositoryItemCompletedComboBox.AutoHeight = False
            Me.repositoryItemCompletedComboBox.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemCompletedComboBox.Name = "repositoryItemCompletedComboBox"
            Me.repositoryItemCompletedComboBox.SmallImages = Me.svgImageCollection
            ' 
            ' svgImageCollection
            ' 
            Me.svgImageCollection.Add("YellowFlag", CType((resources.GetObject("svgImageCollection.YellowFlag")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection.Add("RedFlag", CType((resources.GetObject("svgImageCollection.RedFlag")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection.Add("apply", "image://devav/actions/apply.svg")
            Me.svgImageCollection.Add("show", "image://devav/actions/show.svg")
            Me.svgImageCollection.Add("bookmark", CType((resources.GetObject("svgImageCollection.bookmark")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection.Add("GreenFlag", CType((resources.GetObject("svgImageCollection.GreenFlag")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection.Add("IndentDecrease", CType((resources.GetObject("svgImageCollection.IndentDecrease")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection.Add("IndentIncrease", CType((resources.GetObject("svgImageCollection.IndentIncrease")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' priorityColumn
            ' 
            Me.priorityColumn.ColumnEdit = Me.repositoryItemPriorityComboBox
            Me.priorityColumn.FieldName = "Priority"
            Me.priorityColumn.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
            Me.priorityColumn.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
            Me.priorityColumn.ImageOptions.SvgImage = CType((resources.GetObject("priorityColumn.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.priorityColumn.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.priorityColumn.MaxWidth = 33
            Me.priorityColumn.MinWidth = 33
            Me.priorityColumn.Name = "priorityColumn"
            Me.priorityColumn.OptionsColumn.AllowEdit = False
            Me.priorityColumn.OptionsColumn.AllowFocus = False
            Me.priorityColumn.OptionsColumn.AllowMove = False
            Me.priorityColumn.OptionsColumn.AllowSize = False
            Me.priorityColumn.OptionsColumn.AllowSort = False
            Me.priorityColumn.OptionsFilter.AllowAutoFilter = False
            Me.priorityColumn.OptionsFilter.AllowFilter = False
            Me.priorityColumn.ToolTip = "Priority"
            Me.priorityColumn.Visible = True
            Me.priorityColumn.VisibleIndex = 1
            Me.priorityColumn.Width = 33
            ' 
            ' repositoryItemPriorityComboBox
            ' 
            Me.repositoryItemPriorityComboBox.AutoHeight = False
            Me.repositoryItemPriorityComboBox.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemPriorityComboBox.Name = "repositoryItemPriorityComboBox"
            Me.repositoryItemPriorityComboBox.SmallImages = Me.svgImageCollection
            ' 
            ' employeeColumn
            ' 
            Me.employeeColumn.Caption = "Employee"
            Me.employeeColumn.FieldName = "Employee"
            Me.employeeColumn.MaxWidth = 200
            Me.employeeColumn.MinWidth = 130
            Me.employeeColumn.Name = "employeeColumn"
            Me.employeeColumn.Visible = True
            Me.employeeColumn.VisibleIndex = 4
            Me.employeeColumn.Width = 150
            ' 
            ' treeList1
            ' 
            Me.treeList1.AutoFillColumn = Me.taskColumn
            Me.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.taskColumn, Me.startDateColumn, Me.dueDateColumn, Me.priorityColumn, Me.employeeColumn, Me.statusColumn, Me.completedColumn, Me.descriptionColumn})
            Me.treeList1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.FixedLineWidth = 1
            treeListFormatRule1.Column = Me.statusColumn
            treeListFormatRule1.Name = "Format0"
            formatConditionRuleDataBar1.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            formatConditionRuleDataBar1.MaximumType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleDataBar1.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Percent
            formatConditionRuleDataBar1.PredefinedName = "Mint"
            treeListFormatRule1.Rule = formatConditionRuleDataBar1
            Me.treeList1.FormatRules.Add(treeListFormatRule1)
            Me.treeList1.HierarchyFieldName = "Name"
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.DoubleClick
            Me.treeList1.OptionsFind.AlwaysVisible = True
            Me.treeList1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search
            Me.treeList1.OptionsMenu.ShowConditionalFormattingItem = True
            Me.treeList1.OptionsScrollAnnotations.ShowCustomAnnotations = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsScrollAnnotations.ShowErrors = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsSelection.MultiSelect = True
            Me.treeList1.OptionsSelection.SelectNodesOnRightClick = True
            Me.treeList1.OptionsSelection.UseIndicatorForSelection = True
            Me.treeList1.OptionsView.AutoWidth = False
            Me.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus
            Me.treeList1.OptionsView.ShowIndentAsRowStyle = True
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPriorityComboBox, Me.repositoryItemCompletedComboBox, Me.repositoryItemDescriptionComboBox})
            Me.treeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor
            Me.treeList1.Size = New System.Drawing.Size(616, 397)
            Me.treeList1.TabIndex = 3
            AddHandler Me.treeList1.CustomDrawNodeIndicator, New DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventHandler(AddressOf Me.OnCustomDrawRowIndicator)
            AddHandler Me.treeList1.CustomScrollAnnotation, New System.EventHandler(Of DevExpress.XtraTreeList.TreeListCustomScrollAnnotationsEventArgs)(AddressOf Me.OnCustomScrollAnnotation)
            AddHandler Me.treeList1.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.OnKeyDown)
            ' 
            ' taskColumn
            ' 
            Me.taskColumn.Caption = "Task"
            Me.taskColumn.FieldName = "Name"
            Me.taskColumn.MinWidth = 80
            Me.taskColumn.Name = "taskColumn"
            Me.taskColumn.Visible = True
            Me.taskColumn.VisibleIndex = 3
            Me.taskColumn.Width = 218
            ' 
            ' startDateColumn
            ' 
            Me.startDateColumn.Caption = "Start Date"
            Me.startDateColumn.FieldName = "StartDate"
            Me.startDateColumn.MaxWidth = 100
            Me.startDateColumn.MinWidth = 80
            Me.startDateColumn.Name = "startDateColumn"
            Me.startDateColumn.Visible = True
            Me.startDateColumn.VisibleIndex = 6
            Me.startDateColumn.Width = 97
            ' 
            ' dueDateColumn
            ' 
            Me.dueDateColumn.Caption = "Due Date"
            Me.dueDateColumn.FieldName = "DueDate"
            Me.dueDateColumn.MaxWidth = 100
            Me.dueDateColumn.MinWidth = 80
            Me.dueDateColumn.Name = "dueDateColumn"
            Me.dueDateColumn.Visible = True
            Me.dueDateColumn.VisibleIndex = 7
            Me.dueDateColumn.Width = 97
            ' 
            ' descriptionColumn
            ' 
            Me.descriptionColumn.ColumnEdit = Me.repositoryItemDescriptionComboBox
            Me.descriptionColumn.FieldName = "HasDescription"
            Me.descriptionColumn.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
            Me.descriptionColumn.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
            Me.descriptionColumn.ImageOptions.SvgImage = CType((resources.GetObject("descriptionColumn.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.descriptionColumn.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.descriptionColumn.MaxWidth = 33
            Me.descriptionColumn.MinWidth = 33
            Me.descriptionColumn.Name = "descriptionColumn"
            Me.descriptionColumn.OptionsColumn.AllowEdit = False
            Me.descriptionColumn.OptionsColumn.AllowMove = False
            Me.descriptionColumn.OptionsColumn.AllowSize = False
            Me.descriptionColumn.OptionsColumn.AllowSort = False
            Me.descriptionColumn.OptionsFilter.AllowAutoFilter = False
            Me.descriptionColumn.OptionsFilter.AllowFilter = False
            Me.descriptionColumn.ToolTip = "Description"
            Me.descriptionColumn.Visible = True
            Me.descriptionColumn.VisibleIndex = 2
            Me.descriptionColumn.Width = 33
            ' 
            ' repositoryItemDescriptionComboBox
            ' 
            Me.repositoryItemDescriptionComboBox.AutoHeight = False
            Me.repositoryItemDescriptionComboBox.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemDescriptionComboBox.Name = "repositoryItemDescriptionComboBox"
            Me.repositoryItemDescriptionComboBox.SmallImages = Me.svgImageCollection
            ' 
            ' sidePanel
            ' 
            Me.sidePanel.Controls.Add(Me.navigationPane)
            Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel.Location = New System.Drawing.Point(616, 0)
            Me.sidePanel.Name = "sidePanel"
            Me.sidePanel.Size = New System.Drawing.Size(250, 397)
            Me.sidePanel.TabIndex = 12
            Me.sidePanel.Text = "sidePanel1"
            ' 
            ' navigationPane
            ' 
            Me.navigationPane.Controls.Add(Me.navigationPage)
            Me.navigationPane.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane.Name = "navigationPane"
            Me.navigationPane.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage})
            Me.navigationPane.RegularSize = New System.Drawing.Size(249, 397)
            Me.navigationPane.SelectedPage = Me.navigationPage
            Me.navigationPane.Size = New System.Drawing.Size(249, 397)
            Me.navigationPane.TabIndex = 13
            Me.navigationPane.Text = "navigationPane1"
            ' 
            ' navigationPage
            ' 
            Me.navigationPage.Caption = "Options"
            Me.navigationPage.Controls.Add(Me.ucScrollAnnotationsOptions)
            Me.navigationPage.Name = "navigationPage"
            Me.navigationPage.Size = New System.Drawing.Size(249, 364)
            ' 
            ' ucScrollAnnotationsOptions
            ' 
            Me.ucScrollAnnotationsOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucScrollAnnotationsOptions.Location = New System.Drawing.Point(0, 0)
            Me.ucScrollAnnotationsOptions.Margin = New System.Windows.Forms.Padding(1)
            Me.ucScrollAnnotationsOptions.Name = "ucScrollAnnotationsOptions"
            Me.ucScrollAnnotationsOptions.Size = New System.Drawing.Size(249, 364)
            Me.ucScrollAnnotationsOptions.TabIndex = 0
            ' 
            ' HierarchyColumn
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.sidePanel)
            Me.Name = "HierarchyColumn"
            Me.Size = New System.Drawing.Size(866, 397)
            CType((Me.repositoryItemCompletedComboBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPriorityComboBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDescriptionComboBox), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel.ResumeLayout(False)
            CType((Me.navigationPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane.ResumeLayout(False)
            Me.navigationPage.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private taskColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private startDateColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private dueDateColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private priorityColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private employeeColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private statusColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private completedColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private descriptionColumn As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private svgImageCollection As DevExpress.Utils.SvgImageCollection

        Private repositoryItemCompletedComboBox As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemPriorityComboBox As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemDescriptionComboBox As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private sidePanel As DevExpress.XtraEditors.SidePanel

        Private navigationPane As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private ucScrollAnnotationsOptions As DevExpress.XtraTreeList.Demos.Options.ucScrollAnnotationsOptions
    End Class
End Namespace
