Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleTokenEdit

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
            Me.movieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colMovieTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRelease = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colCountries = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProducers = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colGenres = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.rightPanel = New DevExpress.XtraEditors.SidePanel()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.tokenEditProducers = New DevExpress.XtraEditors.TokenEdit()
            Me.tokenEditGenres = New DevExpress.XtraEditors.TokenEdit()
            Me.tokenEditCountries = New DevExpress.XtraEditors.TokenEdit()
            Me.ClearFilter = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.topPanel = New DevExpress.XtraEditors.SidePanel()
            Me.filterPanel = New DevExpress.XtraEditors.FilterPanelControl()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.movieBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.rightPanel.SuspendLayout()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.tokenEditProducers.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tokenEditGenres.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tokenEditCountries.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.topPanel.SuspendLayout()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' movieBindingSource
            ' 
            Me.movieBindingSource.DataSource = GetType(DevExpress.XtraEditors.Demos.Data.MoviesData.Movie)
            ' 
            ' gridControl
            ' 
            Me.gridControl.DataSource = Me.movieBindingSource
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 40)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1})
            Me.gridControl.Size = New System.Drawing.Size(603, 512)
            Me.gridControl.TabIndex = 14
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            ' 
            ' gridView
            ' 
            Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMovieTitle, Me.colRelease, Me.colCountries, Me.colProducers, Me.colGenres})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
            Me.gridView.OptionsEditForm.EditFormColumnCount = 7
            Me.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            Me.gridView.OptionsView.ShowGroupPanel = False
            AddHandler Me.gridView.EditFormPrepared, New DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventHandler(AddressOf Me.gridView_EditFormPrepared)
            AddHandler Me.gridView.CustomRowCellEditForEditing, New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(AddressOf Me.gridView_CustomRowCellEditForEditing)
            AddHandler Me.gridView.ColumnFilterChanged, New System.EventHandler(AddressOf Me.GridView_ColumnFilterChanged)
            ' 
            ' colMovieTitle
            ' 
            Me.colMovieTitle.Caption = "Movie"
            Me.colMovieTitle.FieldName = "MovieTitle"
            Me.colMovieTitle.Name = "colMovieTitle"
            Me.colMovieTitle.OptionsEditForm.ColumnSpan = 7
            Me.colMovieTitle.OptionsEditForm.UseEditorColRowSpan = False
            Me.colMovieTitle.OptionsFilter.AllowFilter = False
            Me.colMovieTitle.Visible = True
            Me.colMovieTitle.VisibleIndex = 0
            ' 
            ' colRelease
            ' 
            Me.colRelease.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colRelease.FieldName = "Release"
            Me.colRelease.Name = "colRelease"
            Me.colRelease.OptionsEditForm.UseEditorColRowSpan = False
            Me.colRelease.OptionsEditForm.VisibleIndex = 4
            Me.colRelease.OptionsFilter.AllowFilter = False
            Me.colRelease.Visible = True
            Me.colRelease.VisibleIndex = 1
            Me.colRelease.Width = 25
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "\d\d\d\d"
            Me.repositoryItemSpinEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {2100, 0, 0, 0})
            Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {1900, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' colCountries
            ' 
            Me.colCountries.FieldName = "Countries"
            Me.colCountries.Name = "colCountries"
            Me.colCountries.OptionsEditForm.ColumnSpan = 6
            Me.colCountries.OptionsEditForm.UseEditorColRowSpan = False
            Me.colCountries.OptionsEditForm.VisibleIndex = 3
            Me.colCountries.OptionsFilter.AllowFilter = False
            Me.colCountries.Visible = True
            Me.colCountries.VisibleIndex = 3
            Me.colCountries.Width = 45
            ' 
            ' colProducers
            ' 
            Me.colProducers.FieldName = "Producers"
            Me.colProducers.Name = "colProducers"
            Me.colProducers.OptionsEditForm.ColumnSpan = 7
            Me.colProducers.OptionsEditForm.StartNewRow = True
            Me.colProducers.OptionsEditForm.UseEditorColRowSpan = False
            Me.colProducers.OptionsEditForm.VisibleIndex = 1
            Me.colProducers.OptionsFilter.AllowFilter = False
            Me.colProducers.Visible = True
            Me.colProducers.VisibleIndex = 2
            ' 
            ' colGenres
            ' 
            Me.colGenres.FieldName = "Genres"
            Me.colGenres.Name = "colGenres"
            Me.colGenres.OptionsEditForm.ColumnSpan = 7
            Me.colGenres.OptionsEditForm.UseEditorColRowSpan = False
            Me.colGenres.OptionsEditForm.VisibleIndex = 2
            Me.colGenres.OptionsFilter.AllowFilter = False
            Me.colGenres.Visible = True
            Me.colGenres.VisibleIndex = 4
            ' 
            ' rightPanel
            ' 
            Me.rightPanel.Controls.Add(Me.navigationPane1)
            Me.rightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.rightPanel.Location = New System.Drawing.Point(603, 0)
            Me.rightPanel.Name = "rightPanel"
            Me.rightPanel.Size = New System.Drawing.Size(320, 552)
            Me.rightPanel.TabIndex = 13
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane1.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(319, 552)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(319, 552)
            Me.navigationPane1.TabIndex = 9
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Filter"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(319, 519)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.tokenEditProducers)
            Me.layoutControl1.Controls.Add(Me.tokenEditGenres)
            Me.layoutControl1.Controls.Add(Me.tokenEditCountries)
            Me.layoutControl1.Controls.Add(Me.ClearFilter)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1284, 203, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(319, 519)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' tokenEditProducers
            ' 
            Me.tokenEditProducers.Location = New System.Drawing.Point(12, 128)
            Me.tokenEditProducers.Name = "tokenEditProducers"
            Me.tokenEditProducers.Properties.NullText = "Type here"
            Me.tokenEditProducers.Properties.Separators.AddRange(New String() {","})
            Me.tokenEditProducers.Size = New System.Drawing.Size(295, 20)
            Me.tokenEditProducers.StyleController = Me.layoutControl1
            Me.tokenEditProducers.TabIndex = 6
            AddHandler Me.tokenEditProducers.EditValueChanged, New System.EventHandler(AddressOf Me.tokenEditProducers_EditValueChanged)
            ' 
            ' tokenEditGenres
            ' 
            Me.tokenEditGenres.Location = New System.Drawing.Point(12, 78)
            Me.tokenEditGenres.Name = "tokenEditGenres"
            Me.tokenEditGenres.Properties.EditValueType = DevExpress.XtraEditors.TokenEditValueType.[Enum]
            Me.tokenEditGenres.Properties.NullText = "Type here"
            Me.tokenEditGenres.Properties.Separators.AddRange(New String() {","})
            Me.tokenEditGenres.Size = New System.Drawing.Size(295, 20)
            Me.tokenEditGenres.StyleController = Me.layoutControl1
            Me.tokenEditGenres.TabIndex = 5
            AddHandler Me.tokenEditGenres.EditValueChanged, New System.EventHandler(AddressOf Me.tokenEditGenres_EditValueChanged)
            ' 
            ' tokenEditCountries
            ' 
            Me.tokenEditCountries.Location = New System.Drawing.Point(12, 28)
            Me.tokenEditCountries.Name = "tokenEditCountries"
            Me.tokenEditCountries.Properties.NullText = "Type here"
            Me.tokenEditCountries.Properties.Separators.AddRange(New String() {","})
            Me.tokenEditCountries.Size = New System.Drawing.Size(295, 20)
            Me.tokenEditCountries.StyleController = Me.layoutControl1
            Me.tokenEditCountries.TabIndex = 4
            AddHandler Me.tokenEditCountries.EditValueChanged, New System.EventHandler(AddressOf Me.tokenEditCountries_EditValueChanged)
            ' 
            ' ClearFilter
            ' 
            Me.ClearFilter.Location = New System.Drawing.Point(209, 485)
            Me.ClearFilter.Name = "ClearFilter"
            Me.ClearFilter.Size = New System.Drawing.Size(98, 22)
            Me.ClearFilter.StyleController = Me.layoutControl1
            Me.ClearFilter.TabIndex = 7
            Me.ClearFilter.Text = "Clear"
            AddHandler Me.ClearFilter.Click, New System.EventHandler(AddressOf Me.ClearFilter_Click)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(319, 519)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem1, Me.emptySpaceItem2, Me.emptySpaceItem4, Me.emptySpaceItem5, Me.emptySpaceItem7})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(319, 519)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Visibility"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.tokenEditCountries
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(299, 40)
            Me.layoutControlItem2.Text = "Countries"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.tokenEditGenres
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 50)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(299, 40)
            Me.layoutControlItem3.Text = "Genres"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.tokenEditProducers
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 100)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(299, 40)
            Me.layoutControlItem4.Text = "Producers"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ClearFilter
            Me.layoutControlItem1.Location = New System.Drawing.Point(197, 473)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(102, 26)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 140)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(299, 333)
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 473)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(197, 26)
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 40)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(299, 10)
            ' 
            ' emptySpaceItem7
            ' 
            Me.emptySpaceItem7.Location = New System.Drawing.Point(0, 90)
            Me.emptySpaceItem7.Name = "emptySpaceItem7"
            Me.emptySpaceItem7.Size = New System.Drawing.Size(299, 10)
            ' 
            ' topPanel
            ' 
            Me.topPanel.AllowResize = False
            Me.topPanel.AllowSnap = False
            Me.topPanel.Controls.Add(Me.filterPanel)
            Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.topPanel.Location = New System.Drawing.Point(0, 0)
            Me.topPanel.Name = "topPanel"
            Me.topPanel.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
            Me.topPanel.Size = New System.Drawing.Size(603, 40)
            Me.topPanel.TabIndex = 15
            Me.topPanel.Visible = False
            ' 
            ' filterPanel
            ' 
            Me.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.filterPanel.Location = New System.Drawing.Point(12, 0)
            Me.filterPanel.Name = "filterPanel"
            Me.filterPanel.Size = New System.Drawing.Size(579, 39)
            Me.filterPanel.TabIndex = 0
            ' 
            ' emptySpaceItem6
            ' 
            Me.emptySpaceItem6.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem6.Name = "emptySpaceItem6"
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 135)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(299, 419)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 267)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(299, 327)
            ' 
            ' ModuleTokenEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.topPanel)
            Me.Controls.Add(Me.rightPanel)
            Me.Name = "ModuleTokenEdit"
            Me.Size = New System.Drawing.Size(923, 552)
            CType((Me.movieBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.rightPanel.ResumeLayout(False)
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.tokenEditProducers.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tokenEditGenres.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tokenEditCountries.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).EndInit()
            Me.topPanel.ResumeLayout(False)
            Me.topPanel.PerformLayout()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private movieBindingSource As System.Windows.Forms.BindingSource

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private gridView As DevExpress.XtraGrid.Views.Grid.GridView

        Private colMovieTitle As DevExpress.XtraGrid.Columns.GridColumn

        Private colRelease As DevExpress.XtraGrid.Columns.GridColumn

        Private colGenres As DevExpress.XtraGrid.Columns.GridColumn

        Private colProducers As DevExpress.XtraGrid.Columns.GridColumn

        Private colCountries As DevExpress.XtraGrid.Columns.GridColumn

        Private rightPanel As DevExpress.XtraEditors.SidePanel

        Private topPanel As DevExpress.XtraEditors.SidePanel

        Private filterPanel As DevExpress.XtraEditors.FilterPanelControl

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private emptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private tokenEditProducers As DevExpress.XtraEditors.TokenEdit

        Private tokenEditGenres As DevExpress.XtraEditors.TokenEdit

        Private tokenEditCountries As DevExpress.XtraEditors.TokenEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private ClearFilter As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
