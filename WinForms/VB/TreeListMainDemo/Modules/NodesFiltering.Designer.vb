Namespace DevExpress.XtraTreeList.Demos

    Partial Class NodesFiltering

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraTreeList.Demos.NodesFiltering))
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.treeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeListColumn7 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.navigationPane = New DevExpress.XtraBars.Navigation.TabPane()
            Me.filterPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.ucFilterOptions1 = New DevExpress.XtraTreeList.Demos.Options.ucFilterOptions()
            Me.findPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.ucFindOptions1 = New DevExpress.XtraTreeList.Demos.Options.ucFindOptions()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.navigationPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane.SuspendLayout()
            Me.filterPage.SuspendLayout()
            Me.findPage.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5, Me.treeListColumn6, Me.treeListColumn7})
            Me.treeList1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.OptionsFilter.ExpandNodesOnFiltering = True
            Me.treeList1.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1})
            Me.treeList1.Size = New System.Drawing.Size(561, 532)
            Me.treeList1.StateImageList = Me.svgImageCollection1
            Me.treeList1.TabIndex = 12
            AddHandler Me.treeList1.GetStateImage, New DevExpress.XtraTreeList.GetStateImageEventHandler(AddressOf Me.treeList1_GetStateImage)
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.Caption = "Job Title"
            Me.treeListColumn1.FieldName = "JobTitle"
            Me.treeListColumn1.MinWidth = 34
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            Me.treeListColumn1.Width = 105
            ' 
            ' treeListColumn2
            ' 
            Me.treeListColumn2.Caption = "First Name"
            Me.treeListColumn2.FieldName = "FirstName"
            Me.treeListColumn2.Name = "treeListColumn2"
            Me.treeListColumn2.Visible = True
            Me.treeListColumn2.VisibleIndex = 1
            Me.treeListColumn2.Width = 106
            ' 
            ' treeListColumn3
            ' 
            Me.treeListColumn3.Caption = "Last Name"
            Me.treeListColumn3.FieldName = "LastName"
            Me.treeListColumn3.Name = "treeListColumn3"
            Me.treeListColumn3.Visible = True
            Me.treeListColumn3.VisibleIndex = 2
            Me.treeListColumn3.Width = 106
            ' 
            ' treeListColumn4
            ' 
            Me.treeListColumn4.Caption = "Birth Date"
            Me.treeListColumn4.ColumnEdit = Me.repositoryItemDateEdit1
            Me.treeListColumn4.FieldName = "BirthDate"
            Me.treeListColumn4.Name = "treeListColumn4"
            Me.treeListColumn4.Visible = True
            Me.treeListColumn4.VisibleIndex = 3
            Me.treeListColumn4.Width = 105
            ' 
            ' repositoryItemDateEdit1
            ' 
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            ' 
            ' treeListColumn5
            ' 
            Me.treeListColumn5.Caption = "Origin State"
            Me.treeListColumn5.FieldName = "StateProvinceName"
            Me.treeListColumn5.Name = "treeListColumn5"
            Me.treeListColumn5.Visible = True
            Me.treeListColumn5.VisibleIndex = 5
            ' 
            ' treeListColumn6
            ' 
            Me.treeListColumn6.Caption = "Origin City"
            Me.treeListColumn6.FieldName = "City"
            Me.treeListColumn6.Name = "treeListColumn6"
            Me.treeListColumn6.Visible = True
            Me.treeListColumn6.VisibleIndex = 4
            ' 
            ' treeListColumn7
            ' 
            Me.treeListColumn7.Caption = "Phone"
            Me.treeListColumn7.FieldName = "Phone"
            Me.treeListColumn7.Name = "treeListColumn7"
            Me.treeListColumn7.Visible = True
            Me.treeListColumn7.VisibleIndex = 6
            Me.treeListColumn7.Width = 105
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("User", CType((resources.GetObject("svgImageCollection1.User")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Marketing", CType((resources.GetObject("svgImageCollection1.Marketing")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Employeer", CType((resources.GetObject("svgImageCollection1.Employeer")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("User1", CType((resources.GetObject("svgImageCollection1.User1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Engineering", CType((resources.GetObject("svgImageCollection1.Engineering")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Sales", CType((resources.GetObject("svgImageCollection1.Sales")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(561, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(237, 532)
            Me.sidePanel1.TabIndex = 11
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' navigationPane
            ' 
            Me.navigationPane.Controls.Add(Me.filterPage)
            Me.navigationPane.Controls.Add(Me.findPage)
            Me.navigationPane.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane.Name = "navigationPane"
            Me.navigationPane.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.findPage, Me.filterPage})
            Me.navigationPane.RegularSize = New System.Drawing.Size(236, 532)
            Me.navigationPane.SelectedPage = Me.findPage
            Me.navigationPane.Size = New System.Drawing.Size(236, 532)
            Me.navigationPane.TabIndex = 11
            Me.navigationPane.Text = "navigationPane"
            ' 
            ' filterPage
            ' 
            Me.filterPage.Caption = "Filter Options"
            Me.filterPage.Controls.Add(Me.ucFilterOptions1)
            Me.filterPage.ImageOptions.Image = CType((resources.GetObject("filterPage.ImageOptions.Image")), System.Drawing.Image)
            Me.filterPage.ImageOptions.ImageUri.Uri = "New"
            Me.filterPage.Name = "filterPage"
            Me.filterPage.Size = New System.Drawing.Size(236, 456)
            ' 
            ' ucFilterOptions1
            ' 
            Me.ucFilterOptions1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucFilterOptions1.Location = New System.Drawing.Point(0, 0)
            Me.ucFilterOptions1.Name = "ucFilterOptions1"
            Me.ucFilterOptions1.Size = New System.Drawing.Size(236, 456)
            Me.ucFilterOptions1.TabIndex = 0
            ' 
            ' findPage
            ' 
            Me.findPage.Caption = "Find Options"
            Me.findPage.Controls.Add(Me.ucFindOptions1)
            Me.findPage.Name = "findPage"
            Me.findPage.Size = New System.Drawing.Size(236, 499)
            ' 
            ' ucFindOptions1
            ' 
            Me.ucFindOptions1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucFindOptions1.Location = New System.Drawing.Point(0, 0)
            Me.ucFindOptions1.Name = "ucFindOptions1"
            Me.ucFindOptions1.Size = New System.Drawing.Size(236, 499)
            Me.ucFindOptions1.TabIndex = 0
            ' 
            ' NodesFiltering
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "NodesFiltering"
            Me.Size = New System.Drawing.Size(798, 532)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.navigationPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane.ResumeLayout(False)
            Me.filterPage.ResumeLayout(False)
            Me.findPage.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

        Private treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn7 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private navigationPane As DevExpress.XtraBars.Navigation.TabPane

        Private filterPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private findPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private ucFilterOptions1 As DevExpress.XtraTreeList.Demos.Options.ucFilterOptions

        Private ucFindOptions1 As DevExpress.XtraTreeList.Demos.Options.ucFindOptions

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
