Namespace DevExpress.XtraGrid.Demos

    Partial Class GroupInterval

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.GroupInterval))
            Me.icbeDrawMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbeInterval = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.icbeAllowFixedGroups = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
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
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.icbeDrawMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cbeInterval.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbeAllowFixedGroups.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' icbeDrawMode
            ' 
            resources.ApplyResources(Me.icbeDrawMode, "icbeDrawMode")
            Me.icbeDrawMode.Name = "icbeDrawMode"
            Me.icbeDrawMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbeDrawMode.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbeDrawMode.StyleController = Me.layoutControl1
            AddHandler Me.icbeDrawMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbeDrawMode_SelectedIndexChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.cbeInterval)
            Me.layoutControl1.Controls.Add(Me.icbeDrawMode)
            Me.layoutControl1.Controls.Add(Me.icbeAllowFixedGroups)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' cbeInterval
            ' 
            resources.ApplyResources(Me.cbeInterval, "cbeInterval")
            Me.cbeInterval.Name = "cbeInterval"
            Me.cbeInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("cbeInterval.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.cbeInterval.Properties.DropDownRows = 20
            Me.cbeInterval.Properties.Items.AddRange(New Object() {resources.GetString("cbeInterval.Properties.Items"), resources.GetString("cbeInterval.Properties.Items1"), resources.GetString("cbeInterval.Properties.Items2"), resources.GetString("cbeInterval.Properties.Items3"), resources.GetString("cbeInterval.Properties.Items4"), resources.GetString("cbeInterval.Properties.Items5"), resources.GetString("cbeInterval.Properties.Items6")})
            Me.cbeInterval.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbeInterval.StyleController = Me.layoutControl1
            AddHandler Me.cbeInterval.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbeInterval_SelectedIndexChanged)
            ' 
            ' icbeAllowFixedGroups
            ' 
            resources.ApplyResources(Me.icbeAllowFixedGroups, "icbeAllowFixedGroups")
            Me.icbeAllowFixedGroups.Name = "icbeAllowFixedGroups"
            Me.icbeAllowFixedGroups.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbeAllowFixedGroups.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbeAllowFixedGroups.Properties.DropDownRows = 20
            Me.icbeAllowFixedGroups.StyleController = Me.layoutControl1
            AddHandler Me.icbeAllowFixedGroups.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbeAllowFixedGroups_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 467)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 204)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 263)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 122)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cbeInterval
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 40)
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbeAllowFixedGroups
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 40)
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 122)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 82)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup3, "layoutControlGroup3")
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbeDrawMode
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 40)
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(95, 13)
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
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType((resources.GetObject("gridView1.GroupSummary")), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType((resources.GetObject("gridView1.GroupSummary2")), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.AllowCellMerge = True
            Me.gridView1.OptionsView.ShowGroupedColumns = True
            AddHandler Me.gridView1.CellMerge, New DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(AddressOf Me.gridView1_CellMerge)
            AddHandler Me.gridView1.CustomDrawGroupRow, New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(AddressOf Me.gridView1_CustomDrawGroupRow)
            AddHandler Me.gridView1.GridMenuItemClick, New DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventHandler(AddressOf Me.gridView1_GridMenuItemClick)
            AddHandler Me.gridView1.PopupMenuShowing, New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(AddressOf Me.gridView1_PopupMenuShowing)
            AddHandler Me.gridView1.CustomColumnGroup, New DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(AddressOf Me.gridView1_CustomColumnGroup)
            ' 
            ' gridColumn1
            ' 
            resources.ApplyResources(Me.gridColumn1, "gridColumn1")
            Me.gridColumn1.FieldName = "Product Name"
            Me.gridColumn1.Name = "gridColumn1"
            ' 
            ' gridColumn2
            ' 
            resources.ApplyResources(Me.gridColumn2, "gridColumn2")
            Me.gridColumn2.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.gridColumn2.FieldName = "Category"
            Me.gridColumn2.Name = "gridColumn2"
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
            Me.gridColumn4.AppearanceCell.BackColor = System.Drawing.Color.White
            Me.gridColumn4.AppearanceCell.BackColor2 = CType((resources.GetObject("gridColumn4.AppearanceCell.BackColor2")), System.Drawing.Color)
            Me.gridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((64)))))), (CInt(((CByte((0)))))))
            Me.gridColumn4.AppearanceCell.GradientMode = CType((resources.GetObject("gridColumn4.AppearanceCell.GradientMode")), System.Drawing.Drawing2D.LinearGradientMode)
            Me.gridColumn4.AppearanceCell.Options.UseBackColor = True
            Me.gridColumn4.AppearanceCell.Options.UseForeColor = True
            resources.ApplyResources(Me.gridColumn4, "gridColumn4")
            Me.gridColumn4.DisplayFormat.FormatString = "c"
            Me.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn4.FieldName = "Order Sum"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.OptionsColumn.AllowEdit = False
            ' 
            ' gridColumn5
            ' 
            resources.ApplyResources(Me.gridColumn5, "gridColumn5")
            Me.gridColumn5.FieldName = "Order Date"
            Me.gridColumn5.Name = "gridColumn5"
            ' 
            ' gridColumn6
            ' 
            resources.ApplyResources(Me.gridColumn6, "gridColumn6")
            Me.gridColumn6.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.gridColumn6.FieldName = "Count"
            Me.gridColumn6.Name = "gridColumn6"
            ' 
            ' repositoryItemSpinEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit2, "repositoryItemSpinEdit2")
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit2.IsFloatValue = False
            Me.repositoryItemSpinEdit2.Mask.EditMask = resources.GetString("repositoryItemSpinEdit2.Mask.EditMask")
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 500)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            ' 
            ' navigationPage1
            ' 
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            ' 
            ' panelControl3
            ' 
            Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl3.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panelControl3, "panelControl3")
            Me.panelControl3.Name = "panelControl3"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' GroupInterval
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl3)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "GroupInterval"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.GroupInterval_Load)
            CType((Me.icbeDrawMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cbeInterval.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbeAllowFixedGroups.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
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

        Private cbeInterval As DevExpress.XtraEditors.ComboBoxEdit

        Private icbeDrawMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private icbeAllowFixedGroups As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private panelControl3 As DevExpress.XtraEditors.PanelControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
