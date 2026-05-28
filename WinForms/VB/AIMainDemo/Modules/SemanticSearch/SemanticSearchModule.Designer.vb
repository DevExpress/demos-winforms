Namespace DevExpress.AI.Demos

    Partial Class SemanticSearchModule

        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
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
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim columnDefinition1 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition2 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition1 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition2 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition3 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition4 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim trackBarLabel1 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel2 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel3 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel4 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel5 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel6 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel7 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel8 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel9 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel10 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel11 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.tabPane2 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.gridNavigationPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.advBandedGridView = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colDirectors = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colRelease = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colGenre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colPlot = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.lookupsNavigationPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.searchLookUpEdit = New DevExpress.XtraEditors.SearchLookUpEdit()
            Me.searchLookUpEditView = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colSearchLookupPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colSearchLookupTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colSearchLookupDirectors = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colSearchLookupRelease = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colSearchLookupGenre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colSearchLookupPlot = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.gridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.gridLookUpEditView = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colGridLookupPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colGridLookupTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colGridLookupDirectors = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colGridLookupRelease = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colGridLookupGenre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colGridLookupPlot = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControlOptions = New DevExpress.XtraLayout.LayoutControl()
            Me.rgSearchBehavior = New DevExpress.XtraEditors.RadioGroup()
            Me.tbThreshold = New DevExpress.XtraEditors.TrackBarControl()
            Me.rootOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciTbThreshold = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ucDisclaimerPanel1 = New DevExpress.AI.Demos.ucDisclaimerPanel()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciUcDisclaimerPanel1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.semanticSearchEvents2 = New DevExpress.AIIntegration.WinForms.SemanticSearchEvents(Me.components)
            Me.semanticSearchEvents5 = New DevExpress.AIIntegration.WinForms.SemanticSearchEvents(Me.components)
            Me.semanticSearchEvents6 = New DevExpress.AIIntegration.WinForms.SemanticSearchEvents(Me.components)
            Me.semanticSearchEvents1 = New DevExpress.AIIntegration.WinForms.SemanticSearchEvents(Me.components)
            Me.semanticSearchEvents3 = New DevExpress.AIIntegration.WinForms.SemanticSearchEvents(Me.components)
            Me.semanticSearchEvents4 = New DevExpress.AIIntegration.WinForms.SemanticSearchEvents(Me.components)
            Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.tabPane2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane2.SuspendLayout()
            Me.gridNavigationPage.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.advBandedGridView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.lookupsNavigationPage.SuspendLayout()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.searchLookUpEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchLookUpEditView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLookUpEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLookUpEditView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControlOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControlOptions.SuspendLayout()
            CType((Me.rgSearchBehavior.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbThreshold), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbThreshold.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rootOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciTbThreshold), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' roundedSkinPanel1
            ' 
            Me.roundedSkinPanel1.Controls.Add(Me.panelControl1)
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 103)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(994, 429)
            Me.roundedSkinPanel1.TabIndex = 9
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.tabPane2)
            Me.panelControl1.Controls.Add(Me.sidePanel1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(17, 17)
            Me.panelControl1.MinimumSize = New System.Drawing.Size(32, 32)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(960, 395)
            Me.panelControl1.TabIndex = 9
            ' 
            ' tabPane2
            ' 
            Me.tabPane2.Controls.Add(Me.gridNavigationPage)
            Me.tabPane2.Controls.Add(Me.lookupsNavigationPage)
            Me.tabPane2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane2.Location = New System.Drawing.Point(0, 0)
            Me.tabPane2.Name = "tabPane2"
            Me.tabPane2.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.gridNavigationPage, Me.lookupsNavigationPage})
            Me.tabPane2.RegularSize = New System.Drawing.Size(635, 395)
            Me.tabPane2.SelectedPage = Me.gridNavigationPage
            Me.tabPane2.Size = New System.Drawing.Size(635, 395)
            Me.tabPane2.TabIndex = 9
            Me.tabPane2.Text = "tabPane2"
            AddHandler Me.tabPane2.SelectedPageChanged, New DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(AddressOf Me.tabPane2_SelectedPageChanged)
            ' 
            ' gridNavigationPage
            ' 
            Me.gridNavigationPage.Caption = "Data Grid"
            Me.gridNavigationPage.Controls.Add(Me.gridControl1)
            Me.gridNavigationPage.Name = "gridNavigationPage"
            Me.gridNavigationPage.Size = New System.Drawing.Size(635, 354)
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(1)
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.advBandedGridView
            Me.gridControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMemoEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(635, 354)
            Me.gridControl1.TabIndex = 3
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.advBandedGridView})
            ' 
            ' advBandedGridView
            ' 
            Me.advBandedGridView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.gridBand2, Me.gridBand3})
            Me.behaviorManager1.SetBehaviors(Me.advBandedGridView, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.AIIntegration.WinForms.SemanticSearchBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.SemanticSearchGridBehaviorSource), "Movies", "", "Id", DevExpress.AIIntegration.SemanticSearch.ScoreThresholdFilter.LessOrEqual, 0.75R, 20, DevExpress.AIIntegration.SemanticSearch.ControlSearchMode.Semantic, True, Me.semanticSearchEvents2)), DevExpress.Utils.Behaviors.Behavior)})
            Me.advBandedGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.advBandedGridView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colTitle, Me.colPlot, Me.colGenre, Me.colPhoto, Me.colRelease, Me.colDirectors})
            Me.advBandedGridView.DetailHeight = 239
            Me.advBandedGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.advBandedGridView.GridControl = Me.gridControl1
            Me.advBandedGridView.Name = "advBandedGridView"
            Me.advBandedGridView.OptionsBehavior.Editable = False
            Me.advBandedGridView.OptionsBehavior.[ReadOnly] = True
            Me.advBandedGridView.OptionsEditForm.PopupEditFormWidth = 533
            Me.advBandedGridView.OptionsFind.AlwaysVisible = True
            Me.advBandedGridView.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.advBandedGridView.OptionsView.ColumnAutoWidth = True
            Me.advBandedGridView.OptionsView.ShowBands = False
            Me.advBandedGridView.OptionsView.ShowColumnHeaders = False
            Me.advBandedGridView.OptionsView.ShowGroupPanel = False
            Me.advBandedGridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.advBandedGridView.OptionsView.ShowIndicator = False
            Me.advBandedGridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.advBandedGridView.RowSeparatorHeight = 1
            ' 
            ' gridBand1
            ' 
            Me.gridBand1.Caption = "Image"
            Me.gridBand1.Columns.Add(Me.colPhoto)
            Me.gridBand1.MinWidth = 30
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.VisibleIndex = 0
            Me.gridBand1.Width = 75
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.AutoFillDown = True
            Me.colPhoto.Caption = "Photo"
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.RowCount = 3
            Me.colPhoto.Visible = True
            ' 
            ' gridBand2
            ' 
            Me.gridBand2.Caption = "Main"
            Me.gridBand2.Columns.Add(Me.colTitle)
            Me.gridBand2.Columns.Add(Me.colDirectors)
            Me.gridBand2.Columns.Add(Me.colRelease)
            Me.gridBand2.MinWidth = 30
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 1
            Me.gridBand2.Width = 150
            ' 
            ' colTitle
            ' 
            Me.colTitle.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold)
            Me.colTitle.AppearanceCell.Options.UseFont = True
            Me.colTitle.Caption = "Title"
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            Me.colTitle.Visible = True
            Me.colTitle.Width = 150
            ' 
            ' colDirectors
            ' 
            Me.colDirectors.Caption = "Directors"
            Me.colDirectors.FieldName = "Directors"
            Me.colDirectors.Name = "colDirectors"
            Me.colDirectors.RowIndex = 1
            Me.colDirectors.Visible = True
            Me.colDirectors.Width = 150
            ' 
            ' colRelease
            ' 
            Me.colRelease.Caption = "Release Date"
            Me.colRelease.FieldName = "Release"
            Me.colRelease.Name = "colRelease"
            Me.colRelease.RowIndex = 2
            Me.colRelease.Visible = True
            Me.colRelease.Width = 150
            ' 
            ' gridBand3
            ' 
            Me.gridBand3.Caption = "Description"
            Me.gridBand3.Columns.Add(Me.colGenre)
            Me.gridBand3.Columns.Add(Me.colPlot)
            Me.gridBand3.MinWidth = 30
            Me.gridBand3.Name = "gridBand3"
            Me.gridBand3.VisibleIndex = 2
            Me.gridBand3.Width = 375
            ' 
            ' colGenre
            ' 
            Me.colGenre.Caption = "Genre"
            Me.colGenre.FieldName = "Genre"
            Me.colGenre.Name = "colGenre"
            Me.colGenre.Visible = True
            Me.colGenre.Width = 375
            ' 
            ' colPlot
            ' 
            Me.colPlot.AutoFillDown = True
            Me.colPlot.Caption = "Plot"
            Me.colPlot.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colPlot.FieldName = "Plot"
            Me.colPlot.Name = "colPlot"
            Me.colPlot.RowCount = 2
            Me.colPlot.RowIndex = 1
            Me.colPlot.Visible = True
            Me.colPlot.Width = 375
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' lookupsNavigationPage
            ' 
            Me.lookupsNavigationPage.Caption = "Lookup Editors"
            Me.lookupsNavigationPage.Controls.Add(Me.layoutControl2)
            Me.lookupsNavigationPage.Name = "lookupsNavigationPage"
            Me.lookupsNavigationPage.Size = New System.Drawing.Size(635, 352)
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.searchLookUpEdit)
            Me.layoutControl2.Controls.Add(Me.gridLookUpEdit)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(699, 250, 650, 400)
            Me.layoutControl2.Root = Me.layoutControlGroup1
            Me.layoutControl2.Size = New System.Drawing.Size(635, 352)
            Me.layoutControl2.TabIndex = 1
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' searchLookUpEdit
            ' 
            Me.searchLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.searchLookUpEdit.Location = New System.Drawing.Point(213, 189)
            Me.searchLookUpEdit.MaximumSize = New System.Drawing.Size(300, 0)
            Me.searchLookUpEdit.MinimumSize = New System.Drawing.Size(300, 0)
            Me.searchLookUpEdit.Name = "searchLookUpEdit"
            Me.searchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.searchLookUpEdit.Properties.DisplayMember = "Title"
            Me.searchLookUpEdit.Properties.NullText = "Find a movie..."
            Me.searchLookUpEdit.Properties.PopupFormSize = New System.Drawing.Size(640, 0)
            Me.searchLookUpEdit.Properties.PopupView = Me.searchLookUpEditView
            Me.searchLookUpEdit.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMemoEdit3})
            Me.searchLookUpEdit.Properties.ValueMember = "Id"
            Me.searchLookUpEdit.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.AdvBandedView
            Me.searchLookUpEdit.Size = New System.Drawing.Size(300, 28)
            Me.searchLookUpEdit.StyleController = Me.layoutControl2
            Me.searchLookUpEdit.TabIndex = 0
            ' 
            ' searchLookUpEditView
            ' 
            Me.searchLookUpEditView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand7, Me.gridBand8, Me.gridBand9})
            Me.behaviorManager1.SetBehaviors(Me.searchLookUpEditView, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.AIIntegration.WinForms.SemanticSearchBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.SemanticSearchGridBehaviorSource), "Movies", "", "Id", DevExpress.AIIntegration.SemanticSearch.ScoreThresholdFilter.LessOrEqual, 0.75R, 20, DevExpress.AIIntegration.SemanticSearch.ControlSearchMode.Semantic, True, Me.semanticSearchEvents2)), DevExpress.Utils.Behaviors.Behavior)})
            Me.searchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colSearchLookupTitle, Me.colSearchLookupPlot, Me.colSearchLookupGenre, Me.colSearchLookupPhoto, Me.colSearchLookupRelease, Me.colSearchLookupDirectors})
            Me.searchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.searchLookUpEditView.Name = "searchLookUpEditView"
            Me.searchLookUpEditView.OptionsBehavior.Editable = False
            Me.searchLookUpEditView.OptionsBehavior.[ReadOnly] = True
            Me.searchLookUpEditView.OptionsEditForm.PopupEditFormWidth = 533
            Me.searchLookUpEditView.OptionsFind.AlwaysVisible = True
            Me.searchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.searchLookUpEditView.OptionsView.ColumnAutoWidth = True
            Me.searchLookUpEditView.OptionsView.EnableAppearanceOddRow = True
            Me.searchLookUpEditView.OptionsView.ShowBands = False
            Me.searchLookUpEditView.OptionsView.ShowColumnHeaders = False
            Me.searchLookUpEditView.OptionsView.ShowGroupPanel = False
            Me.searchLookUpEditView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.searchLookUpEditView.OptionsView.ShowIndicator = False
            Me.searchLookUpEditView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' gridBand7
            ' 
            Me.gridBand7.Caption = "Image"
            Me.gridBand7.Columns.Add(Me.colSearchLookupPhoto)
            Me.gridBand7.MinWidth = 30
            Me.gridBand7.Name = "gridBand7"
            Me.gridBand7.VisibleIndex = 0
            Me.gridBand7.Width = 75
            ' 
            ' colSearchLookupPhoto
            ' 
            Me.colSearchLookupPhoto.AutoFillDown = True
            Me.colSearchLookupPhoto.Caption = "Photo"
            Me.colSearchLookupPhoto.FieldName = "Photo"
            Me.colSearchLookupPhoto.Name = "colSearchLookupPhoto"
            Me.colSearchLookupPhoto.Visible = True
            ' 
            ' gridBand8
            ' 
            Me.gridBand8.Caption = "Main"
            Me.gridBand8.Columns.Add(Me.colSearchLookupTitle)
            Me.gridBand8.Columns.Add(Me.colSearchLookupDirectors)
            Me.gridBand8.Columns.Add(Me.colSearchLookupRelease)
            Me.gridBand8.MinWidth = 30
            Me.gridBand8.Name = "gridBand8"
            Me.gridBand8.VisibleIndex = 1
            Me.gridBand8.Width = 150
            ' 
            ' colSearchLookupTitle
            ' 
            Me.colSearchLookupTitle.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.colSearchLookupTitle.AppearanceCell.Options.UseFont = True
            Me.colSearchLookupTitle.Caption = "Title"
            Me.colSearchLookupTitle.FieldName = "Title"
            Me.colSearchLookupTitle.Name = "colSearchLookupTitle"
            Me.colSearchLookupTitle.Visible = True
            Me.colSearchLookupTitle.Width = 150
            ' 
            ' colSearchLookupDirectors
            ' 
            Me.colSearchLookupDirectors.Caption = "Directors"
            Me.colSearchLookupDirectors.FieldName = "Directors"
            Me.colSearchLookupDirectors.Name = "colSearchLookupDirectors"
            Me.colSearchLookupDirectors.RowIndex = 1
            Me.colSearchLookupDirectors.Visible = True
            Me.colSearchLookupDirectors.Width = 150
            ' 
            ' colSearchLookupRelease
            ' 
            Me.colSearchLookupRelease.Caption = "Release Date"
            Me.colSearchLookupRelease.FieldName = "Release"
            Me.colSearchLookupRelease.Name = "colSearchLookupRelease"
            Me.colSearchLookupRelease.RowIndex = 2
            Me.colSearchLookupRelease.Visible = True
            Me.colSearchLookupRelease.Width = 150
            ' 
            ' gridBand9
            ' 
            Me.gridBand9.Caption = "Description"
            Me.gridBand9.Columns.Add(Me.colSearchLookupGenre)
            Me.gridBand9.Columns.Add(Me.colSearchLookupPlot)
            Me.gridBand9.MinWidth = 30
            Me.gridBand9.Name = "gridBand9"
            Me.gridBand9.VisibleIndex = 2
            Me.gridBand9.Width = 375
            ' 
            ' colSearchLookupGenre
            ' 
            Me.colSearchLookupGenre.Caption = "Genre"
            Me.colSearchLookupGenre.FieldName = "Genre"
            Me.colSearchLookupGenre.Name = "colSearchLookupGenre"
            Me.colSearchLookupGenre.Visible = True
            Me.colSearchLookupGenre.Width = 375
            ' 
            ' colSearchLookupPlot
            ' 
            Me.colSearchLookupPlot.AutoFillDown = True
            Me.colSearchLookupPlot.Caption = "Plot"
            Me.colSearchLookupPlot.ColumnEdit = Me.repositoryItemMemoEdit3
            Me.colSearchLookupPlot.FieldName = "Plot"
            Me.colSearchLookupPlot.Name = "colSearchLookupPlot"
            Me.colSearchLookupPlot.RowIndex = 1
            Me.colSearchLookupPlot.Visible = True
            Me.colSearchLookupPlot.Width = 375
            ' 
            ' repositoryItemMemoEdit3
            ' 
            Me.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3"
            ' 
            ' gridLookUpEdit
            ' 
            Me.gridLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.gridLookUpEdit.Location = New System.Drawing.Point(213, 135)
            Me.gridLookUpEdit.MaximumSize = New System.Drawing.Size(300, 0)
            Me.gridLookUpEdit.MinimumSize = New System.Drawing.Size(300, 0)
            Me.gridLookUpEdit.Name = "gridLookUpEdit"
            Me.gridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.gridLookUpEdit.Properties.DisplayMember = "Title"
            Me.gridLookUpEdit.Properties.NullText = "Find a movie..."
            Me.gridLookUpEdit.Properties.PopupFormSize = New System.Drawing.Size(640, 0)
            Me.gridLookUpEdit.Properties.PopupView = Me.gridLookUpEditView
            Me.gridLookUpEdit.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMemoEdit2})
            Me.gridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.gridLookUpEdit.Properties.ValueMember = "Id"
            Me.gridLookUpEdit.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.AdvBandedView
            Me.gridLookUpEdit.Size = New System.Drawing.Size(300, 28)
            Me.gridLookUpEdit.StyleController = Me.layoutControl2
            Me.gridLookUpEdit.TabIndex = 0
            ' 
            ' gridLookUpEditView
            ' 
            Me.gridLookUpEditView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand4, Me.gridBand5, Me.gridBand6})
            Me.behaviorManager1.SetBehaviors(Me.gridLookUpEditView, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.AIIntegration.WinForms.SemanticSearchBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.SemanticSearchGridBehaviorSource), "Movies", "", "Id", DevExpress.AIIntegration.SemanticSearch.ScoreThresholdFilter.LessOrEqual, 0.75R, 20, DevExpress.AIIntegration.SemanticSearch.ControlSearchMode.Semantic, True, Me.semanticSearchEvents2)), DevExpress.Utils.Behaviors.Behavior)})
            Me.gridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colGridLookupTitle, Me.colGridLookupPlot, Me.colGridLookupGenre, Me.colGridLookupPhoto, Me.colGridLookupRelease, Me.colGridLookupDirectors})
            Me.gridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridLookUpEditView.Name = "gridLookUpEditView"
            Me.gridLookUpEditView.OptionsBehavior.Editable = False
            Me.gridLookUpEditView.OptionsBehavior.[ReadOnly] = True
            Me.gridLookUpEditView.OptionsEditForm.PopupEditFormWidth = 533
            Me.gridLookUpEditView.OptionsFind.AlwaysVisible = True
            Me.gridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridLookUpEditView.OptionsView.ColumnAutoWidth = True
            Me.gridLookUpEditView.OptionsView.EnableAppearanceOddRow = True
            Me.gridLookUpEditView.OptionsView.ShowBands = False
            Me.gridLookUpEditView.OptionsView.ShowColumnHeaders = False
            Me.gridLookUpEditView.OptionsView.ShowGroupPanel = False
            Me.gridLookUpEditView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridLookUpEditView.OptionsView.ShowIndicator = False
            Me.gridLookUpEditView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' gridBand4
            ' 
            Me.gridBand4.Caption = "Image"
            Me.gridBand4.Columns.Add(Me.colGridLookupPhoto)
            Me.gridBand4.MinWidth = 30
            Me.gridBand4.Name = "gridBand4"
            Me.gridBand4.VisibleIndex = 0
            Me.gridBand4.Width = 75
            ' 
            ' colGridLookupPhoto
            ' 
            Me.colGridLookupPhoto.AutoFillDown = True
            Me.colGridLookupPhoto.Caption = "Photo"
            Me.colGridLookupPhoto.FieldName = "Photo"
            Me.colGridLookupPhoto.Name = "colGridLookupPhoto"
            Me.colGridLookupPhoto.Visible = True
            ' 
            ' gridBand5
            ' 
            Me.gridBand5.Caption = "Main"
            Me.gridBand5.Columns.Add(Me.colGridLookupTitle)
            Me.gridBand5.Columns.Add(Me.colGridLookupDirectors)
            Me.gridBand5.Columns.Add(Me.colGridLookupRelease)
            Me.gridBand5.MinWidth = 30
            Me.gridBand5.Name = "gridBand5"
            Me.gridBand5.VisibleIndex = 1
            Me.gridBand5.Width = 150
            ' 
            ' colGridLookupTitle
            ' 
            Me.colGridLookupTitle.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.colGridLookupTitle.AppearanceCell.Options.UseFont = True
            Me.colGridLookupTitle.Caption = "Title"
            Me.colGridLookupTitle.FieldName = "Title"
            Me.colGridLookupTitle.Name = "colGridLookupTitle"
            Me.colGridLookupTitle.Visible = True
            Me.colGridLookupTitle.Width = 150
            ' 
            ' colGridLookupDirectors
            ' 
            Me.colGridLookupDirectors.Caption = "Directors"
            Me.colGridLookupDirectors.FieldName = "Directors"
            Me.colGridLookupDirectors.Name = "colGridLookupDirectors"
            Me.colGridLookupDirectors.RowIndex = 1
            Me.colGridLookupDirectors.Visible = True
            Me.colGridLookupDirectors.Width = 150
            ' 
            ' colGridLookupRelease
            ' 
            Me.colGridLookupRelease.Caption = "Release Date"
            Me.colGridLookupRelease.FieldName = "Release"
            Me.colGridLookupRelease.Name = "colGridLookupRelease"
            Me.colGridLookupRelease.RowIndex = 2
            Me.colGridLookupRelease.Visible = True
            Me.colGridLookupRelease.Width = 150
            ' 
            ' gridBand6
            ' 
            Me.gridBand6.Caption = "Description"
            Me.gridBand6.Columns.Add(Me.colGridLookupGenre)
            Me.gridBand6.Columns.Add(Me.colGridLookupPlot)
            Me.gridBand6.MinWidth = 30
            Me.gridBand6.Name = "gridBand6"
            Me.gridBand6.VisibleIndex = 2
            Me.gridBand6.Width = 375
            ' 
            ' colGridLookupGenre
            ' 
            Me.colGridLookupGenre.Caption = "Genre"
            Me.colGridLookupGenre.FieldName = "Genre"
            Me.colGridLookupGenre.Name = "colGridLookupGenre"
            Me.colGridLookupGenre.Visible = True
            Me.colGridLookupGenre.Width = 375
            ' 
            ' colGridLookupPlot
            ' 
            Me.colGridLookupPlot.AutoFillDown = True
            Me.colGridLookupPlot.Caption = "Plot"
            Me.colGridLookupPlot.ColumnEdit = Me.repositoryItemMemoEdit2
            Me.colGridLookupPlot.FieldName = "Plot"
            Me.colGridLookupPlot.Name = "colGridLookupPlot"
            Me.colGridLookupPlot.RowIndex = 1
            Me.colGridLookupPlot.Visible = True
            Me.colGridLookupPlot.Width = 375
            ' 
            ' repositoryItemMemoEdit2
            ' 
            Me.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem5})
            Me.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.layoutControlGroup1.Name = "Root"
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition1.Width = 100R
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            columnDefinition2.Width = 398R
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition3.Width = 100R
            Me.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition1, columnDefinition2, columnDefinition3})
            rowDefinition1.Height = 100R
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent
            rowDefinition2.Height = 54R
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition3.Height = 54R
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition4.Height = 100R
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Percent
            Me.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition1, rowDefinition2, rowDefinition3, rowDefinition4})
            Me.layoutControlGroup1.Size = New System.Drawing.Size(635, 352)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.gridLookUpEdit
            Me.layoutControlItem4.Location = New System.Drawing.Point(105, 109)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem4.Size = New System.Drawing.Size(398, 54)
            Me.layoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10)
            Me.layoutControlItem4.Text = "Grid Lookup"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.searchLookUpEdit
            Me.layoutControlItem5.Location = New System.Drawing.Point(105, 163)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem5.Size = New System.Drawing.Size(398, 54)
            Me.layoutControlItem5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10)
            Me.layoutControlItem5.Text = "Search Lookup"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(635, 0)
            Me.sidePanel1.MaximumSize = New System.Drawing.Size(500, 0)
            Me.sidePanel1.MinimumSize = New System.Drawing.Size(325, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(325, 395)
            Me.sidePanel1.TabIndex = 8
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(324, 395)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(324, 395)
            Me.tabPane1.TabIndex = 7
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControlOptions)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(324, 354)
            ' 
            ' layoutControlOptions
            ' 
            Me.layoutControlOptions.AllowCustomization = False
            Me.layoutControlOptions.Controls.Add(Me.rgSearchBehavior)
            Me.layoutControlOptions.Controls.Add(Me.tbThreshold)
            Me.layoutControlOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControlOptions.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlOptions.Name = "layoutControlOptions"
            Me.layoutControlOptions.Root = Me.rootOptions
            Me.layoutControlOptions.Size = New System.Drawing.Size(324, 354)
            Me.layoutControlOptions.TabIndex = 0
            Me.layoutControlOptions.Text = "layoutControl2"
            ' 
            ' rgSearchBehavior
            ' 
            Me.rgSearchBehavior.Location = New System.Drawing.Point(142, 16)
            Me.rgSearchBehavior.Name = "rgSearchBehavior"
            Me.rgSearchBehavior.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgSearchBehavior.Properties.Appearance.Options.UseBackColor = True
            Me.rgSearchBehavior.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgSearchBehavior.Properties.Columns = 2
            Me.rgSearchBehavior.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Filter"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Search")})
            Me.rgSearchBehavior.Properties.Padding = New System.Windows.Forms.Padding(12, 4, 12, 4)
            Me.rgSearchBehavior.Size = New System.Drawing.Size(166, 45)
            Me.rgSearchBehavior.StyleController = Me.layoutControlOptions
            Me.rgSearchBehavior.TabIndex = 7
            AddHandler Me.rgSearchBehavior.SelectedIndexChanged, New System.EventHandler(AddressOf Me.rgSearchBehavior_SelectedIndexChanged)
            ' 
            ' tbThreshold
            ' 
            Me.tbThreshold.EditValue = 75
            Me.tbThreshold.Location = New System.Drawing.Point(16, 86)
            Me.tbThreshold.Margin = New System.Windows.Forms.Padding(2)
            Me.tbThreshold.Name = "tbThreshold"
            Me.tbThreshold.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.tbThreshold.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel1.Label = "0"
            trackBarLabel2.Label = "0.1"
            trackBarLabel2.Value = 10
            trackBarLabel2.Visible = False
            trackBarLabel3.Label = "0.2"
            trackBarLabel3.Value = 20
            trackBarLabel3.Visible = False
            trackBarLabel4.Label = "0.3"
            trackBarLabel4.Value = 30
            trackBarLabel4.Visible = False
            trackBarLabel5.Label = "0.4"
            trackBarLabel5.Value = 40
            trackBarLabel5.Visible = False
            trackBarLabel6.Label = "0.5"
            trackBarLabel6.Value = 50
            trackBarLabel7.Label = "0.6"
            trackBarLabel7.Value = 60
            trackBarLabel7.Visible = False
            trackBarLabel8.Label = "0.7"
            trackBarLabel8.Value = 70
            trackBarLabel8.Visible = False
            trackBarLabel9.Label = "0.8"
            trackBarLabel9.Value = 80
            trackBarLabel9.Visible = False
            trackBarLabel10.Label = "0.9"
            trackBarLabel10.Value = 90
            trackBarLabel10.Visible = False
            trackBarLabel11.Label = "1"
            trackBarLabel11.Value = 100
            Me.tbThreshold.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel1, trackBarLabel2, trackBarLabel3, trackBarLabel4, trackBarLabel5, trackBarLabel6, trackBarLabel7, trackBarLabel8, trackBarLabel9, trackBarLabel10, trackBarLabel11})
            Me.tbThreshold.Properties.Maximum = 100
            Me.tbThreshold.Properties.ShowLabels = True
            Me.tbThreshold.Properties.TickFrequency = 10
            Me.tbThreshold.Size = New System.Drawing.Size(292, 72)
            Me.tbThreshold.StyleController = Me.layoutControlOptions
            Me.tbThreshold.TabIndex = 6
            Me.tbThreshold.Value = 75
            AddHandler Me.tbThreshold.EditValueChanged, New System.EventHandler(AddressOf Me.tbThreshold_EditValueChanged)
            ' 
            ' rootOptions
            ' 
            Me.rootOptions.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.rootOptions.GroupBordersVisible = False
            Me.rootOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciTbThreshold, Me.emptySpaceItem2, Me.layoutControlItem3})
            Me.rootOptions.Name = "rootOptions"
            Me.rootOptions.Size = New System.Drawing.Size(324, 354)
            Me.rootOptions.TextVisible = False
            ' 
            ' lciTbThreshold
            ' 
            Me.lciTbThreshold.Control = Me.tbThreshold
            Me.lciTbThreshold.Location = New System.Drawing.Point(0, 51)
            Me.lciTbThreshold.Name = "lciTbThreshold"
            Me.lciTbThreshold.Size = New System.Drawing.Size(298, 97)
            Me.lciTbThreshold.Text = "Similarity Threshold:"
            Me.lciTbThreshold.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciTbThreshold.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 148)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(106, 26)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(298, 180)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.rgSearchBehavior
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.MaxSize = New System.Drawing.Size(0, 75)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(115, 35)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(298, 51)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.Text = "Grid Search Behavior:"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(110, 13)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ucDisclaimerPanel1)
            Me.layoutControl1.Controls.Add(Me.roundedSkinPanel1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1041, 241, 650, 400)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(994, 532)
            Me.layoutControl1.TabIndex = 10
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ucDisclaimerPanel1
            ' 
            Me.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ucDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1"
            Me.ucDisclaimerPanel1.Size = New System.Drawing.Size(994, 103)
            Me.ucDisclaimerPanel1.TabIndex = 10
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.lciUcDisclaimerPanel1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(994, 532)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.roundedSkinPanel1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 103)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(994, 429)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' lciUcDisclaimerPanel1
            ' 
            Me.lciUcDisclaimerPanel1.Control = Me.ucDisclaimerPanel1
            Me.lciUcDisclaimerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.lciUcDisclaimerPanel1.Name = "lciUcDisclaimerPanel1"
            Me.lciUcDisclaimerPanel1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciUcDisclaimerPanel1.Size = New System.Drawing.Size(994, 103)
            Me.lciUcDisclaimerPanel1.TextVisible = False
            ' 
            ' emptySpaceItem6
            ' 
            Me.emptySpaceItem6.Location = New System.Drawing.Point(0, 163)
            Me.emptySpaceItem6.Name = "emptySpaceItem6"
            Me.emptySpaceItem6.Size = New System.Drawing.Size(41, 54)
            ' 
            ' emptySpaceItem7
            ' 
            Me.emptySpaceItem7.Location = New System.Drawing.Point(599, 163)
            Me.emptySpaceItem7.Name = "emptySpaceItem7"
            Me.emptySpaceItem7.Size = New System.Drawing.Size(10, 54)
            ' 
            ' SemanticSearchModule
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "SemanticSearchModule"
            Me.Size = New System.Drawing.Size(994, 532)
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.tabPane2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane2.ResumeLayout(False)
            Me.gridNavigationPage.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.advBandedGridView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.lookupsNavigationPage.ResumeLayout(False)
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.searchLookUpEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchLookUpEditView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLookUpEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLookUpEditView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControlOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControlOptions.ResumeLayout(False)
            CType((Me.rgSearchBehavior.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbThreshold.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbThreshold), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rootOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciTbThreshold), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciUcDisclaimerPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem7), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private tbThreshold As DevExpress.XtraEditors.TrackBarControl

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlOptions As DevExpress.XtraLayout.LayoutControl

        Private rootOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private lciTbThreshold As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private ucDisclaimerPanel1 As DevExpress.AI.Demos.ucDisclaimerPanel

        Private lciUcDisclaimerPanel1 As DevExpress.XtraLayout.LayoutControlItem

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private semanticSearchEvents1 As DevExpress.AIIntegration.WinForms.SemanticSearchEvents

        Private advBandedGridView As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView

        Private colPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colGenre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colRelease As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colPlot As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private semanticSearchEvents2 As DevExpress.AIIntegration.WinForms.SemanticSearchEvents

        Private rgSearchBehavior As DevExpress.XtraEditors.RadioGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private colDirectors As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private tabPane2 As DevExpress.XtraBars.Navigation.TabPane

        Private gridNavigationPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private lookupsNavigationPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private searchLookUpEdit As DevExpress.XtraEditors.SearchLookUpEdit

        Private gridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit

        Private semanticSearchEvents3 As DevExpress.AIIntegration.WinForms.SemanticSearchEvents

        Private semanticSearchEvents4 As DevExpress.AIIntegration.WinForms.SemanticSearchEvents

        Private searchLookUpEditView As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView

        Private gridLookUpEditView As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView

        Private colGridLookupPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colGridLookupTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colGridLookupDirectors As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colGridLookupRelease As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colGridLookupGenre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colGridLookupPlot As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private semanticSearchEvents5 As DevExpress.AIIntegration.WinForms.SemanticSearchEvents

        Private semanticSearchEvents6 As DevExpress.AIIntegration.WinForms.SemanticSearchEvents

        Private colSearchLookupTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colSearchLookupPlot As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colSearchLookupGenre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colSearchLookupPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colSearchLookupRelease As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colSearchLookupDirectors As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private repositoryItemMemoEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private emptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
