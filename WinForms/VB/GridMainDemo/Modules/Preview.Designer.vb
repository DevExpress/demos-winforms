Imports DevExpress.Export

Namespace DevExpress.XtraGrid.Demos

    Partial Class Preview

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.Preview))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
            Me.ceUseMeasurePreviewHeight = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbName = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceAuto = New DevExpress.XtraEditors.CheckEdit()
            Me.ceCustom = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.pnlGrid = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoExEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceUseMeasurePreviewHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cbName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAuto.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCustom.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.pnlGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlGrid.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemTextEdit1})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsPrint.PrintPreview = True
            Me.gridView1.OptionsView.ShowPreview = True
            AddHandler Me.gridView1.CustomDrawRowPreview, New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(AddressOf Me.gridView1_CustomDrawRowPreview)
            AddHandler Me.gridView1.CalcPreviewText, New DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(AddressOf Me.gridView1_CalcPreviewText)
            AddHandler Me.gridView1.MeasurePreviewHeight, New DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(AddressOf Me.gridView1_MeasurePreviewHeight)
            ' 
            ' gridColumn1
            ' 
            resources.ApplyResources(Me.gridColumn1, "gridColumn1")
            Me.gridColumn1.FieldName = "FirstName"
            Me.gridColumn1.Name = "gridColumn1"
            ' 
            ' gridColumn2
            ' 
            resources.ApplyResources(Me.gridColumn2, "gridColumn2")
            Me.gridColumn2.FieldName = "LastName"
            Me.gridColumn2.Name = "gridColumn2"
            ' 
            ' gridColumn3
            ' 
            resources.ApplyResources(Me.gridColumn3, "gridColumn3")
            Me.gridColumn3.FieldName = "Title"
            Me.gridColumn3.Name = "gridColumn3"
            ' 
            ' gridColumn4
            ' 
            resources.ApplyResources(Me.gridColumn4, "gridColumn4")
            Me.gridColumn4.FieldName = "BirthDate"
            Me.gridColumn4.Name = "gridColumn4"
            ' 
            ' gridColumn5
            ' 
            resources.ApplyResources(Me.gridColumn5, "gridColumn5")
            Me.gridColumn5.ColumnEdit = Me.repositoryItemTextEdit1
            Me.gridColumn5.FieldName = "HomePhone"
            Me.gridColumn5.Name = "gridColumn5"
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
            Me.repositoryItemTextEdit1.Mask.MaskType = CType((resources.GetObject("repositoryItemTextEdit1.Mask.MaskType")), DevExpress.XtraEditors.Mask.MaskType)
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' gridColumn6
            ' 
            resources.ApplyResources(Me.gridColumn6, "gridColumn6")
            Me.gridColumn6.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.gridColumn6.FieldName = "Notes"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsFilter.AllowFilter = False
            ' 
            ' repositoryItemMemoExEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemMemoExEdit1, "repositoryItemMemoExEdit1")
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemMemoExEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            ' 
            ' gridColumn7
            ' 
            resources.ApplyResources(Me.gridColumn7, "gridColumn7")
            Me.gridColumn7.ColumnEdit = Me.repositoryItemImageEdit1
            Me.gridColumn7.FieldName = "Photo"
            Me.gridColumn7.Name = "gridColumn7"
            ' 
            ' repositoryItemImageEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemImageEdit1, "repositoryItemImageEdit1")
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemImageEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            Me.repositoryItemImageEdit1.PopupFormSize = New System.Drawing.Size(220, 220)
            ' 
            ' ceUseMeasurePreviewHeight
            ' 
            resources.ApplyResources(Me.ceUseMeasurePreviewHeight, "ceUseMeasurePreviewHeight")
            Me.ceUseMeasurePreviewHeight.Name = "ceUseMeasurePreviewHeight"
            Me.ceUseMeasurePreviewHeight.Properties.Caption = resources.GetString("ceUseMeasurePreviewHeight.Properties.Caption")
            Me.ceUseMeasurePreviewHeight.StyleController = Me.layoutControl1
            AddHandler Me.ceUseMeasurePreviewHeight.CheckedChanged, New System.EventHandler(AddressOf Me.ceUseMeasurePreviewHeight_CheckedChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceUseMeasurePreviewHeight)
            Me.layoutControl1.Controls.Add(Me.cbName)
            Me.layoutControl1.Controls.Add(Me.ceAuto)
            Me.layoutControl1.Controls.Add(Me.ceCustom)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' cbName
            ' 
            resources.ApplyResources(Me.cbName, "cbName")
            Me.cbName.Name = "cbName"
            Me.cbName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("cbName.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.cbName.Properties.DropDownRows = 10
            Me.cbName.StyleController = Me.layoutControl1
            AddHandler Me.cbName.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbName_SelectedIndexChanged)
            ' 
            ' ceAuto
            ' 
            resources.ApplyResources(Me.ceAuto, "ceAuto")
            Me.ceAuto.Name = "ceAuto"
            Me.ceAuto.Properties.Caption = resources.GetString("ceAuto.Properties.Caption")
            Me.ceAuto.StyleController = Me.layoutControl1
            AddHandler Me.ceAuto.CheckedChanged, New System.EventHandler(AddressOf Me.ceAuto_CheckedChanged)
            ' 
            ' ceCustom
            ' 
            resources.ApplyResources(Me.ceCustom, "ceCustom")
            Me.ceCustom.Name = "ceCustom"
            Me.ceCustom.Properties.Caption = resources.GetString("ceCustom.Properties.Caption")
            Me.ceCustom.StyleController = Me.layoutControl1
            AddHandler Me.ceCustom.CheckedChanged, New System.EventHandler(AddressOf Me.ceCustom_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 414)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 180)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 234)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 114)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceAuto
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceCustom
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceUseMeasurePreviewHeight
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 114)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 66)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup3, "layoutControlGroup3")
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbName
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 24)
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 447)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            ' 
            ' navigationPage1
            ' 
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            ' 
            ' pnlGrid
            ' 
            Me.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlGrid.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.pnlGrid, "pnlGrid")
            Me.pnlGrid.Name = "pnlGrid"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' Preview
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlGrid)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "Preview"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Preview_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoExEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceUseMeasurePreviewHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cbName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAuto.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCustom.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.pnlGrid), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlGrid.ResumeLayout(False)
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

        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit

        Private ceCustom As DevExpress.XtraEditors.CheckEdit

        Private ceAuto As DevExpress.XtraEditors.CheckEdit

        Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private ceUseMeasurePreviewHeight As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.Container = Nothing

        Private cbName As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private pnlGrid As DevExpress.XtraEditors.PanelControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
