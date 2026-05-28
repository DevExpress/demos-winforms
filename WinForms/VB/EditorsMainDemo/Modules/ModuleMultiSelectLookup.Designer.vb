Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleMultiSelectLookup

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.dataLayoutControl2 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.reviewsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAssistants = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemAssistantsLookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.assistantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.employeeRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.reviewDetailsGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciReviewsGrid = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.FirstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.employeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.LastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.AssistantsLookup = New DevExpress.XtraEditors.LookUpEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.employeeGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciLastNameTextEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciFirstNameTextEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciEmailTextEdit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.reviewersGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciAssistantsLookup = New DevExpress.XtraLayout.LayoutControlItem()
            Me.adornerUIManager1 = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
            Me.validationHint1 = New DevExpress.Utils.VisualEffects.ValidationHint()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.dataLayoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl2.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.reviewsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemAssistantsLookUp), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.assistantsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.employeeRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.reviewDetailsGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciReviewsGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataLayoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType((Me.FirstNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.employeeBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.LastNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.EmailTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.AssistantsLookup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.employeeGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciLastNameTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciFirstNameTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciEmailTextEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.reviewersGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciAssistantsLookup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.adornerUIManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 12F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)})
            Me.tablePanel1.Controls.Add(Me.dataLayoutControl2)
            Me.tablePanel1.Controls.Add(Me.dataLayoutControl1)
            Me.tablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.tablePanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)})
            Me.tablePanel1.Size = New System.Drawing.Size(750, 280)
            Me.tablePanel1.TabIndex = 0
            ' 
            ' dataLayoutControl2
            ' 
            Me.dataLayoutControl2.AllowCustomization = False
            Me.tablePanel1.SetColumn(Me.dataLayoutControl2, 2)
            Me.dataLayoutControl2.Controls.Add(Me.gridControl1)
            Me.dataLayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl2.Location = New System.Drawing.Point(384, 3)
            Me.dataLayoutControl2.Name = "dataLayoutControl2"
            Me.dataLayoutControl2.Root = Me.employeeRoot
            Me.tablePanel1.SetRow(Me.dataLayoutControl2, 0)
            Me.dataLayoutControl2.Size = New System.Drawing.Size(363, 274)
            Me.dataLayoutControl2.TabIndex = 3
            Me.dataLayoutControl2.Text = "dataLayoutControl2"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.reviewsBindingSource
            Me.gridControl1.Location = New System.Drawing.Point(3, 24)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemAssistantsLookUp})
            Me.gridControl1.Size = New System.Drawing.Size(357, 247)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' reviewsBindingSource
            ' 
            Me.reviewsBindingSource.DataSource = GetType(DevExpress.XtraEditors.Demos.Modules.Overview.EmployeeReview)
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCreatedOn, Me.colAssistants})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsMenu.EnableColumnMenu = False
            Me.gridView1.OptionsMenu.EnableFooterMenu = False
            Me.gridView1.OptionsMenu.EnableGroupPanelMenu = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCreatedOn, DevExpress.Data.ColumnSortOrder.Descending)})
            ' 
            ' colCreatedOn
            ' 
            Me.colCreatedOn.Caption = "CreatedOn"
            Me.colCreatedOn.FieldName = "CreatedOn"
            Me.colCreatedOn.Name = "colCreatedOn"
            Me.colCreatedOn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colCreatedOn.Visible = True
            Me.colCreatedOn.VisibleIndex = 0
            Me.colCreatedOn.Width = 25
            ' 
            ' colAssistants
            ' 
            Me.colAssistants.Caption = "Assistants"
            Me.colAssistants.ColumnEdit = Me.repositoryItemAssistantsLookUp
            Me.colAssistants.FieldName = "AssistantIDs"
            Me.colAssistants.Name = "colAssistants"
            Me.colAssistants.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colAssistants.OptionsFilter.AllowFilter = False
            Me.colAssistants.Visible = True
            Me.colAssistants.VisibleIndex = 1
            ' 
            ' repositoryItemAssistantsLookUp
            ' 
            Me.repositoryItemAssistantsLookUp.AutoHeight = False
            Me.repositoryItemAssistantsLookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemAssistantsLookUp.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DX$CheckboxSelectorColumn", "", 25, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
            Me.repositoryItemAssistantsLookUp.DataSource = Me.assistantsBindingSource
            Me.repositoryItemAssistantsLookUp.DisplayMember = "FullName"
            Me.repositoryItemAssistantsLookUp.EditValueType = DevExpress.XtraEditors.Repository.LookUpEditValueType.ValueList
            Me.repositoryItemAssistantsLookUp.EnableEditValueCollectionEditing = DevExpress.Utils.DefaultBoolean.[True]
            Me.repositoryItemAssistantsLookUp.Name = "repositoryItemAssistantsLookUp"
            Me.repositoryItemAssistantsLookUp.ValueMember = "ID"
            ' 
            ' assistantsBindingSource
            ' 
            Me.assistantsBindingSource.DataSource = GetType(DevExpress.XtraEditors.Demos.Modules.Overview.Assistant)
            ' 
            ' employeeRoot
            ' 
            Me.employeeRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.employeeRoot.GroupBordersVisible = False
            Me.employeeRoot.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.employeeRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.reviewDetailsGroup})
            Me.employeeRoot.Name = "employeeRoot"
            Me.employeeRoot.Size = New System.Drawing.Size(363, 274)
            ' 
            ' reviewDetailsGroup
            ' 
            Me.reviewDetailsGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciReviewsGrid})
            Me.reviewDetailsGroup.Location = New System.Drawing.Point(0, 0)
            Me.reviewDetailsGroup.Name = "lciReviewsGrid"
            Me.reviewDetailsGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.reviewDetailsGroup.Size = New System.Drawing.Size(363, 274)
            Me.reviewDetailsGroup.Text = "Review History"
            ' 
            ' lciReviewsGrid
            ' 
            Me.lciReviewsGrid.Control = Me.gridControl1
            Me.lciReviewsGrid.Location = New System.Drawing.Point(0, 0)
            Me.lciReviewsGrid.Name = "lciReviewsGrid"
            Me.lciReviewsGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lciReviewsGrid.Size = New System.Drawing.Size(357, 247)
            Me.lciReviewsGrid.TextVisible = False
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.AllowCustomization = False
            Me.tablePanel1.SetColumn(Me.dataLayoutControl1, 0)
            Me.dataLayoutControl1.Controls.Add(Me.FirstNameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.LastNameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.EmailTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.AssistantsLookup)
            Me.dataLayoutControl1.DataSource = Me.employeeBindingSource
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Location = New System.Drawing.Point(3, 3)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.Root = Me.Root
            Me.tablePanel1.SetRow(Me.dataLayoutControl1, 0)
            Me.tablePanel1.SetRowSpan(Me.dataLayoutControl1, 2)
            Me.dataLayoutControl1.Size = New System.Drawing.Size(363, 274)
            Me.dataLayoutControl1.TabIndex = 2
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' FirstNameTextEdit
            ' 
            Me.FirstNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.employeeBindingSource, "FirstName", True))
            Me.FirstNameTextEdit.Location = New System.Drawing.Point(77, 59)
            Me.FirstNameTextEdit.Name = "FirstNameTextEdit"
            Me.FirstNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.FirstNameTextEdit.Size = New System.Drawing.Size(272, 20)
            Me.FirstNameTextEdit.StyleController = Me.dataLayoutControl1
            Me.FirstNameTextEdit.TabIndex = 4
            ' 
            ' employeeBindingSource
            ' 
            Me.employeeBindingSource.DataSource = GetType(DevExpress.XtraEditors.Demos.Modules.Overview.ReviewedEmployee)
            ' 
            ' LastNameTextEdit
            ' 
            Me.LastNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.employeeBindingSource, "LastName", True))
            Me.LastNameTextEdit.Location = New System.Drawing.Point(77, 83)
            Me.LastNameTextEdit.Name = "LastNameTextEdit"
            Me.LastNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.LastNameTextEdit.Size = New System.Drawing.Size(272, 20)
            Me.LastNameTextEdit.StyleController = Me.dataLayoutControl1
            Me.LastNameTextEdit.TabIndex = 5
            ' 
            ' EmailTextEdit
            ' 
            Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.employeeBindingSource, "Email", True))
            Me.EmailTextEdit.Location = New System.Drawing.Point(77, 35)
            Me.EmailTextEdit.Name = "EmailTextEdit"
            Me.EmailTextEdit.Size = New System.Drawing.Size(272, 20)
            Me.EmailTextEdit.StyleController = Me.dataLayoutControl1
            Me.EmailTextEdit.TabIndex = 6
            ' 
            ' AssistantsLookup
            ' 
            Me.AssistantsLookup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.reviewsBindingSource, "AssistantIDs", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.AssistantsLookup.Location = New System.Drawing.Point(14, 152)
            Me.AssistantsLookup.Name = "AssistantsLookup"
            Me.AssistantsLookup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.AssistantsLookup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DX$CheckboxSelectorColumn", "", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-mail")})
            Me.AssistantsLookup.Properties.DataSource = Me.assistantsBindingSource
            Me.AssistantsLookup.Properties.DisplayMember = "FullName"
            Me.AssistantsLookup.Properties.DropDownRows = 10
            Me.AssistantsLookup.Properties.EditValueType = DevExpress.XtraEditors.Repository.LookUpEditValueType.ValueList
            Me.AssistantsLookup.Properties.NullValuePrompt = "Add assistants..."
            Me.AssistantsLookup.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch
            Me.AssistantsLookup.Properties.ShowLines = False
            Me.AssistantsLookup.Properties.ValueMember = "ID"
            Me.AssistantsLookup.Size = New System.Drawing.Size(335, 20)
            Me.AssistantsLookup.StyleController = Me.dataLayoutControl1
            Me.AssistantsLookup.TabIndex = 8
            AddHandler Me.AssistantsLookup.EditValueChanged, New System.EventHandler(AddressOf Me.OnEditValueChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.employeeGroup, Me.reviewersGroup})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(363, 274)
            Me.Root.TextVisible = False
            ' 
            ' employeeGroup
            ' 
            Me.employeeGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciLastNameTextEdit, Me.lciFirstNameTextEdit, Me.lciEmailTextEdit})
            Me.employeeGroup.Location = New System.Drawing.Point(0, 0)
            Me.employeeGroup.Name = "employeeGroup"
            Me.employeeGroup.Size = New System.Drawing.Size(363, 117)
            Me.employeeGroup.Text = "Employee"
            ' 
            ' lciLastNameTextEdit
            ' 
            Me.lciLastNameTextEdit.Control = Me.LastNameTextEdit
            Me.lciLastNameTextEdit.Location = New System.Drawing.Point(0, 48)
            Me.lciLastNameTextEdit.Name = "lciLastNameTextEdit"
            Me.lciLastNameTextEdit.Size = New System.Drawing.Size(339, 24)
            Me.lciLastNameTextEdit.Text = "Last Name"
            Me.lciLastNameTextEdit.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' lciFirstNameTextEdit
            ' 
            Me.lciFirstNameTextEdit.Control = Me.FirstNameTextEdit
            Me.lciFirstNameTextEdit.Location = New System.Drawing.Point(0, 24)
            Me.lciFirstNameTextEdit.Name = "lciFirstNameTextEdit"
            Me.lciFirstNameTextEdit.Size = New System.Drawing.Size(339, 24)
            Me.lciFirstNameTextEdit.Text = "First Name"
            Me.lciFirstNameTextEdit.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' lciEmailTextEdit
            ' 
            Me.lciEmailTextEdit.Control = Me.EmailTextEdit
            Me.lciEmailTextEdit.Location = New System.Drawing.Point(0, 0)
            Me.lciEmailTextEdit.Name = "lciEmailTextEdit"
            Me.lciEmailTextEdit.Size = New System.Drawing.Size(339, 24)
            Me.lciEmailTextEdit.Text = "E-mail"
            Me.lciEmailTextEdit.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' reviewersGroup
            ' 
            Me.reviewersGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciAssistantsLookup})
            Me.reviewersGroup.Location = New System.Drawing.Point(0, 117)
            Me.reviewersGroup.Name = "reviewersGroup"
            Me.reviewersGroup.Size = New System.Drawing.Size(363, 157)
            Me.reviewersGroup.Text = "Assistants"
            ' 
            ' lciAssistantsLookup
            ' 
            Me.lciAssistantsLookup.Control = Me.AssistantsLookup
            Me.lciAssistantsLookup.Location = New System.Drawing.Point(0, 0)
            Me.lciAssistantsLookup.Name = "lciAssistantsLookup"
            Me.lciAssistantsLookup.Size = New System.Drawing.Size(339, 112)
            Me.lciAssistantsLookup.Text = "Assistants"
            Me.lciAssistantsLookup.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciAssistantsLookup.TextVisible = False
            ' 
            ' adornerUIManager1
            ' 
            Me.adornerUIManager1.Elements.Add(Me.validationHint1)
            Me.adornerUIManager1.Owner = Me
            ' 
            ' validationHint1
            ' 
            Me.validationHint1.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Invalid
            Me.validationHint1.TargetElement = Me.AssistantsLookup
            ' 
            ' ModuleMultiSelectLookup
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.tablePanel1)
            Me.Name = "ModuleMultiSelectLookup"
            Me.Size = New System.Drawing.Size(800, 400)
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            CType((Me.dataLayoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl2.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.reviewsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemAssistantsLookUp), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.assistantsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.employeeRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.reviewDetailsGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciReviewsGrid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataLayoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType((Me.FirstNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.employeeBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.LastNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.EmailTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.AssistantsLookup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.employeeGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciLastNameTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciFirstNameTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciEmailTextEdit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.reviewersGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciAssistantsLookup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.adornerUIManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private employeeBindingSource As System.Windows.Forms.BindingSource

        Private FirstNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private LastNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private EmailTextEdit As DevExpress.XtraEditors.TextEdit

        Private AssistantsLookup As DevExpress.XtraEditors.LookUpEdit

        Private assistantsBindingSource As System.Windows.Forms.BindingSource

        Private dataLayoutControl2 As DevExpress.XtraDataLayout.DataLayoutControl

        Private employeeRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private employeeGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private lciLastNameTextEdit As DevExpress.XtraLayout.LayoutControlItem

        Private lciFirstNameTextEdit As DevExpress.XtraLayout.LayoutControlItem

        Private lciEmailTextEdit As DevExpress.XtraLayout.LayoutControlItem

        Private reviewersGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private lciAssistantsLookup As DevExpress.XtraLayout.LayoutControlItem

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private lciReviewsGrid As DevExpress.XtraLayout.LayoutControlItem

        Private reviewsBindingSource As System.Windows.Forms.BindingSource

        Private colCreatedOn As DevExpress.XtraGrid.Columns.GridColumn

        Private colAssistants As DevExpress.XtraGrid.Columns.GridColumn

        Private reviewDetailsGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private adornerUIManager1 As DevExpress.Utils.VisualEffects.AdornerUIManager

        Private validationHint1 As DevExpress.Utils.VisualEffects.ValidationHint

        Private repositoryItemAssistantsLookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    End Class
End Namespace
