Namespace DevExpress.XtraTreeList.Demos

    Partial Class MultiSelect

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraTreeList.Demos.MultiSelect))
            Me.treeList = New DevExpress.XtraTreeList.TreeList()
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
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.optionsPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.ucMultiSelectOptions1 = New DevExpress.XtraTreeList.Demos.Options.ucMultiSelectOptions()
            CType((Me.treeList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.optionsPage.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' treeList
            ' 
            Me.treeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5, Me.treeListColumn6, Me.treeListColumn7})
            Me.treeList.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.treeList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList.Location = New System.Drawing.Point(0, 0)
            Me.treeList.Name = "treeList"
            Me.treeList.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.treeList.OptionsSelection.MultiSelect = True
            Me.treeList.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect
            Me.treeList.OptionsSelection.UseIndicatorForSelection = True
            Me.treeList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1})
            Me.treeList.Size = New System.Drawing.Size(548, 456)
            Me.treeList.StateImageList = Me.svgImageCollection1
            Me.treeList.TabIndex = 10
            AddHandler Me.treeList.GetStateImage, New DevExpress.XtraTreeList.GetStateImageEventHandler(AddressOf Me.treeList1_GetStateImage)
            ' 
            ' treeListColumn1
            ' 
            Me.treeListColumn1.Caption = "Job Title"
            Me.treeListColumn1.FieldName = "JobTitle"
            Me.treeListColumn1.MinWidth = 33
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
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(548, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(250, 456)
            Me.sidePanel1.TabIndex = 11
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.optionsPage)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane1.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.optionsPage})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 456)
            Me.navigationPane1.SelectedPage = Me.optionsPage
            Me.navigationPane1.Size = New System.Drawing.Size(249, 456)
            Me.navigationPane1.TabIndex = 13
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' optionsPage
            ' 
            Me.optionsPage.Caption = "Options"
            Me.optionsPage.Controls.Add(Me.ucMultiSelectOptions1)
            Me.optionsPage.Name = "optionsPage"
            Me.optionsPage.Size = New System.Drawing.Size(249, 423)
            ' 
            ' ucMultiSelectOptions1
            ' 
            Me.ucMultiSelectOptions1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ucMultiSelectOptions1.Location = New System.Drawing.Point(0, 0)
            Me.ucMultiSelectOptions1.Name = "ucMultiSelectOptions1"
            Me.ucMultiSelectOptions1.Size = New System.Drawing.Size(249, 423)
            Me.ucMultiSelectOptions1.TabIndex = 0
            ' 
            ' MultiSelect
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "MultiSelect"
            Me.Size = New System.Drawing.Size(798, 456)
            CType((Me.treeList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemDateEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.optionsPage.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList As DevExpress.XtraTreeList.TreeList

        Private components As System.ComponentModel.IContainer = Nothing

        Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn7 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit

        Private treeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private optionsPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private ucMultiSelectOptions1 As DevExpress.XtraTreeList.Demos.Options.ucMultiSelectOptions

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
