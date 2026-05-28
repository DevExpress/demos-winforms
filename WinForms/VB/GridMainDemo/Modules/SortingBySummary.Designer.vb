Namespace DevExpress.XtraGrid.Demos

    Partial Class SortingBySummary

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.SortingBySummary))
            Me.cbeSorting = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.cbeSorting.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' cbeSorting
            ' 
            resources.ApplyResources(Me.cbeSorting, "cbeSorting")
            Me.cbeSorting.Name = "cbeSorting"
            Me.cbeSorting.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("cbeSorting.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.cbeSorting.Properties.DropDownRows = 20
            Me.cbeSorting.Properties.Items.AddRange(New Object() {resources.GetString("cbeSorting.Properties.Items"), resources.GetString("cbeSorting.Properties.Items1"), resources.GetString("cbeSorting.Properties.Items2"), resources.GetString("cbeSorting.Properties.Items3"), resources.GetString("cbeSorting.Properties.Items4"), resources.GetString("cbeSorting.Properties.Items5"), resources.GetString("cbeSorting.Properties.Items6"), resources.GetString("cbeSorting.Properties.Items7")})
            Me.cbeSorting.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbeSorting.StyleController = Me.layoutControl1
            AddHandler Me.cbeSorting.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbeSorting_SelectedIndexChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.cbeSorting)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 495)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 66)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 429)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 66)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cbeSorting
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            resources.ApplyResources(Me.gridView1, "gridView1")
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary4")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary5"), CType((resources.GetObject("gridView1.GroupSummary6")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary7")), New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary8")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary9"), CType((resources.GetObject("gridView1.GroupSummary10")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary11"))})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsMenu.EnableFooterMenu = False
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.gridView1.GridMenuItemClick, New DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventHandler(AddressOf Me.gridView1_GridMenuItemClick)
            ' 
            ' gridColumn1
            ' 
            resources.ApplyResources(Me.gridColumn1, "gridColumn1")
            Me.gridColumn1.FieldName = "Product Name"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("gridColumn1.Summary")), DevExpress.Data.SummaryItemType))})
            ' 
            ' gridColumn2
            ' 
            resources.ApplyResources(Me.gridColumn2, "gridColumn2")
            Me.gridColumn2.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.gridColumn2.FieldName = "Category"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemImageComboBox1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items7")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items8"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items10")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items11"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items13")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items14"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items15"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items16")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items17"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items18"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items19")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items20"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items21"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items22")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items23")))))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            ' 
            ' gridColumn3
            ' 
            resources.ApplyResources(Me.gridColumn3, "gridColumn3")
            Me.gridColumn3.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.gridColumn3.DisplayFormat.FormatString = "c"
            Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn3.FieldName = "Unit Price"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("gridColumn3.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("gridColumn3.Summary1"), resources.GetString("gridColumn3.Summary2"))})
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' gridColumn4
            ' 
            Me.gridColumn4.AppearanceCell.FontStyleDelta = CType((resources.GetObject("gridColumn4.AppearanceCell.FontStyleDelta")), System.Drawing.FontStyle)
            Me.gridColumn4.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question
            Me.gridColumn4.AppearanceCell.Options.UseFont = True
            Me.gridColumn4.AppearanceCell.Options.UseForeColor = True
            resources.ApplyResources(Me.gridColumn4, "gridColumn4")
            Me.gridColumn4.DisplayFormat.FormatString = "c"
            Me.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn4.FieldName = "Order Sum"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.OptionsColumn.AllowEdit = False
            Me.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType((resources.GetObject("gridColumn4.Summary")), DevExpress.Data.SummaryItemType), resources.GetString("gridColumn4.Summary1"), resources.GetString("gridColumn4.Summary2"))})
            ' 
            ' gridColumn5
            ' 
            resources.ApplyResources(Me.gridColumn5, "gridColumn5")
            Me.gridColumn5.FieldName = "Order Date"
            Me.gridColumn5.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridColumn5.OptionsColumn.AllowMove = False
            Me.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' gridColumn6
            ' 
            resources.ApplyResources(Me.gridColumn6, "gridColumn6")
            Me.gridColumn6.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.gridColumn6.FieldName = "Count"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' repositoryItemSpinEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit2, "repositoryItemSpinEdit2")
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit2.IsFloatValue = False
            Me.repositoryItemSpinEdit2.Mask.EditMask = resources.GetString("repositoryItemSpinEdit2.Mask.EditMask")
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            resources.ApplyResources(Me.tabPane1, "tabPane1")
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(249, 528)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            ' 
            ' tabNavigationPage1
            ' 
            resources.ApplyResources(Me.tabNavigationPage1, "tabNavigationPage1")
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            ' 
            ' SortingBySummary
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "SortingBySummary"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.SortingBySummary_Load)
            CType((Me.cbeSorting.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private cbeSorting As DevExpress.XtraEditors.ComboBoxEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    End Class
End Namespace
