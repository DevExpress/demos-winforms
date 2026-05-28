Namespace DevExpress.DevAV.Modules

    Partial Class EmployeesGroupFilter

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
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.okBtn = New DevExpress.XtraEditors.SimpleButton()
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSourceCollection = New System.Windows.Forms.BindingSource(Me.components)
            Me.winExplorerView = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.saveFilter = New DevExpress.XtraEditors.CheckEdit()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.filterName = New DevExpress.XtraEditors.TextEdit()
            Me.cancelBtn = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.itemForControl = New DevExpress.XtraLayout.LayoutControlItem()
            Me.itemForOkBtn = New DevExpress.XtraLayout.LayoutControlItem()
            Me.itemForCancelBtn = New DevExpress.XtraLayout.LayoutControlItem()
            Me.itemForName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.itemForSaveCheck = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.separator = New DevExpress.XtraLayout.SimpleSeparator()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSourceCollection), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.winExplorerView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.saveFilter.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.filterName.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.itemForControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.itemForOkBtn), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.itemForCancelBtn), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.itemForName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.itemForSaveCheck), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separator), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.okBtn.Location = New System.Drawing.Point(628, 466)
            Me.okBtn.Name = "okBtn"
            Me.okBtn.Size = New System.Drawing.Size(78, 22)
            Me.okBtn.StyleController = Me.moduleLayout
            Me.okBtn.TabIndex = 0
            Me.okBtn.Text = "OK"
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.gridControl)
            Me.moduleLayout.Controls.Add(Me.saveFilter)
            Me.moduleLayout.Controls.Add(Me.filterName)
            Me.moduleLayout.Controls.Add(Me.cancelBtn)
            Me.moduleLayout.Controls.Add(Me.okBtn)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.layoutControlGroup
            Me.moduleLayout.Size = New System.Drawing.Size(800, 500)
            Me.moduleLayout.TabIndex = 0
            Me.gridControl.DataSource = Me.bindingSourceCollection
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.winExplorerView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(800, 377)
            Me.gridControl.TabIndex = 6
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView})
            Me.bindingSourceCollection.DataSource = GetType(DevExpress.DevAV.Employee)
            Me.winExplorerView.Appearance.ItemHovered.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.winExplorerView.Appearance.ItemHovered.Options.UseFont = True
            Me.winExplorerView.Appearance.ItemNormal.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.winExplorerView.Appearance.ItemNormal.Options.UseFont = True
            Me.winExplorerView.Appearance.ItemPressed.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.winExplorerView.Appearance.ItemPressed.Options.UseFont = True
            Me.winExplorerView.Appearance.ItemSelected.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.winExplorerView.Appearance.ItemSelected.Options.UseFont = True
            Me.winExplorerView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.winExplorerView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPhoto, Me.colFullName, Me.colAddress, Me.colDepartment, Me.colCheck})
            Me.winExplorerView.ColumnSet.CheckBoxColumn = Me.colCheck
            Me.winExplorerView.ColumnSet.DescriptionColumn = Me.colAddress
            Me.winExplorerView.ColumnSet.ExtraLargeImageColumn = Me.colPhoto
            Me.winExplorerView.ColumnSet.GroupColumn = Me.colDepartment
            Me.winExplorerView.ColumnSet.LargeImageColumn = Me.colPhoto
            Me.winExplorerView.ColumnSet.MediumImageColumn = Me.colPhoto
            Me.winExplorerView.ColumnSet.TextColumn = Me.colFullName
            Me.winExplorerView.GridControl = Me.gridControl
            Me.winExplorerView.GroupCount = 1
            Me.winExplorerView.Name = "winExplorerView"
            Me.winExplorerView.OptionsBehavior.Editable = False
            Me.winExplorerView.OptionsFind.AlwaysVisible = True
            Me.winExplorerView.OptionsFind.FindNullPrompt = "Search Employees..."
            Me.winExplorerView.OptionsFind.ShowClearButton = False
            Me.winExplorerView.OptionsFind.ShowCloseButton = False
            Me.winExplorerView.OptionsFind.ShowFindButton = False
            Me.winExplorerView.OptionsView.DrawCheckedItemsAsSelected = True
            Me.winExplorerView.OptionsView.ShowCheckBoxes = True
            Me.winExplorerView.OptionsView.ShowExpandCollapseButtons = True
            Me.winExplorerView.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Tiles
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.Visible = True
            Me.colPhoto.VisibleIndex = 0
            Me.colFullName.FieldName = "FullNameBindable"
            Me.colFullName.Name = "colFullName"
            Me.colFullName.Visible = True
            Me.colFullName.VisibleIndex = 0
            Me.colAddress.FieldName = "Address"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.Visible = True
            Me.colAddress.VisibleIndex = 1
            Me.colDepartment.FieldName = "Department"
            Me.colDepartment.Name = "colDepartment"
            Me.colDepartment.Visible = True
            Me.colDepartment.VisibleIndex = 2
            Me.colCheck.FieldName = "Check"
            Me.colCheck.Name = "colCheck"
            Me.colCheck.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
            Me.colCheck.Visible = True
            Me.colCheck.VisibleIndex = 2
            Me.saveFilter.AutoSizeInLayoutControl = True
            Me.saveFilter.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Save", True))
            Me.saveFilter.Location = New System.Drawing.Point(12, 395)
            Me.saveFilter.Name = "saveFilter"
            Me.saveFilter.Properties.Caption = "Save for future use"
            Me.saveFilter.Size = New System.Drawing.Size(112, 15)
            Me.saveFilter.StyleController = Me.moduleLayout
            Me.saveFilter.TabIndex = 5
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.ViewModels.CustomFilterViewModel)
            Me.filterName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Name", True))
            Me.filterName.EditValue = ""
            Me.filterName.Location = New System.Drawing.Point(12, 414)
            Me.filterName.Name = "filterName"
            Me.filterName.Properties.NullValuePrompt = "Enter a name for your group"
            Me.filterName.Properties.NullValuePromptShowForEmptyValue = True
            Me.filterName.Size = New System.Drawing.Size(776, 20)
            Me.filterName.StyleController = Me.moduleLayout
            Me.filterName.TabIndex = 4
            Me.cancelBtn.Location = New System.Drawing.Point(710, 466)
            Me.cancelBtn.Name = "cancelBtn"
            Me.cancelBtn.Size = New System.Drawing.Size(78, 22)
            Me.cancelBtn.StyleController = Me.moduleLayout
            Me.cancelBtn.TabIndex = 1
            Me.cancelBtn.Text = "Cancel"
            Me.layoutControlGroup.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup.GroupBordersVisible = False
            Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.itemForControl, Me.itemForOkBtn, Me.itemForCancelBtn, Me.itemForName, Me.itemForSaveCheck, Me.emptySpaceItem, Me.separator})
            Me.layoutControlGroup.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup.Name = "layoutControlGroup1"
            Me.layoutControlGroup.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup.Size = New System.Drawing.Size(800, 500)
            Me.layoutControlGroup.Text = "layoutControlGroup1"
            Me.itemForControl.Control = Me.gridControl
            Me.itemForControl.CustomizationFormText = "itemForControl"
            Me.itemForControl.Location = New System.Drawing.Point(0, 0)
            Me.itemForControl.Name = "itemForControl"
            Me.itemForControl.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.itemForControl.Size = New System.Drawing.Size(800, 377)
            Me.itemForControl.Text = "itemForControl"
            Me.itemForControl.TextSize = New System.Drawing.Size(0, 0)
            Me.itemForControl.TextToControlDistance = 0
            Me.itemForControl.TextVisible = False
            Me.itemForOkBtn.Control = Me.okBtn
            Me.itemForOkBtn.CustomizationFormText = "itemForOkBtn"
            Me.itemForOkBtn.Location = New System.Drawing.Point(616, 454)
            Me.itemForOkBtn.MaxSize = New System.Drawing.Size(92, 46)
            Me.itemForOkBtn.MinSize = New System.Drawing.Size(92, 46)
            Me.itemForOkBtn.Name = "itemForOkBtn"
            Me.itemForOkBtn.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 2, 12, 12)
            Me.itemForOkBtn.Size = New System.Drawing.Size(92, 46)
            Me.itemForOkBtn.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.itemForOkBtn.Text = "itemForOkBtn"
            Me.itemForOkBtn.TextSize = New System.Drawing.Size(0, 0)
            Me.itemForOkBtn.TextToControlDistance = 0
            Me.itemForOkBtn.TextVisible = False
            Me.itemForCancelBtn.Control = Me.cancelBtn
            Me.itemForCancelBtn.CustomizationFormText = "itemForCancelBtn"
            Me.itemForCancelBtn.Location = New System.Drawing.Point(708, 454)
            Me.itemForCancelBtn.MaxSize = New System.Drawing.Size(92, 46)
            Me.itemForCancelBtn.MinSize = New System.Drawing.Size(92, 46)
            Me.itemForCancelBtn.Name = "itemForCancelBtn"
            Me.itemForCancelBtn.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 12, 12, 12)
            Me.itemForCancelBtn.Size = New System.Drawing.Size(92, 46)
            Me.itemForCancelBtn.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.itemForCancelBtn.Text = "itemForCancelBtn"
            Me.itemForCancelBtn.TextSize = New System.Drawing.Size(0, 0)
            Me.itemForCancelBtn.TextToControlDistance = 0
            Me.itemForCancelBtn.TextVisible = False
            Me.itemForName.Control = Me.filterName
            Me.itemForName.CustomizationFormText = "itemForName"
            Me.itemForName.Location = New System.Drawing.Point(0, 410)
            Me.itemForName.Name = "itemForName"
            Me.itemForName.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 4, 20)
            Me.itemForName.Size = New System.Drawing.Size(800, 44)
            Me.itemForName.Text = "itemForName"
            Me.itemForName.TextSize = New System.Drawing.Size(0, 0)
            Me.itemForName.TextToControlDistance = 0
            Me.itemForName.TextVisible = False
            Me.itemForSaveCheck.Control = Me.saveFilter
            Me.itemForSaveCheck.CustomizationFormText = "itemForSaveCheck"
            Me.itemForSaveCheck.Location = New System.Drawing.Point(0, 379)
            Me.itemForSaveCheck.Name = "itemForSaveCheck"
            Me.itemForSaveCheck.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 16, 0)
            Me.itemForSaveCheck.Size = New System.Drawing.Size(800, 31)
            Me.itemForSaveCheck.Text = "itemForSaveCheck"
            Me.itemForSaveCheck.TextSize = New System.Drawing.Size(0, 0)
            Me.itemForSaveCheck.TextToControlDistance = 0
            Me.itemForSaveCheck.TextVisible = False
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 454)
            Me.emptySpaceItem.Name = "emptySpaceItem1"
            Me.emptySpaceItem.Size = New System.Drawing.Size(616, 46)
            Me.emptySpaceItem.Text = "emptySpaceItem1"
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            Me.separator.AllowHotTrack = False
            Me.separator.CustomizationFormText = "simpleSeparator1"
            Me.separator.Location = New System.Drawing.Point(0, 377)
            Me.separator.Name = "simpleSeparator1"
            Me.separator.Size = New System.Drawing.Size(800, 2)
            Me.separator.Text = "simpleSeparator1"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "EmployeesGroupFilter"
            Me.Size = New System.Drawing.Size(800, 500)
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSourceCollection), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.winExplorerView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.saveFilter.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.filterName.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.itemForControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.itemForOkBtn), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.itemForCancelBtn), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.itemForName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.itemForSaveCheck), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separator), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private okBtn As DevExpress.XtraEditors.SimpleButton

        Private cancelBtn As DevExpress.XtraEditors.SimpleButton

        Private moduleLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private filterName As DevExpress.XtraEditors.TextEdit

        Private saveFilter As DevExpress.XtraEditors.CheckEdit

        Private bindingSource As System.Windows.Forms.BindingSource

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private winExplorerView As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView

        Private bindingSourceCollection As System.Windows.Forms.BindingSource

        Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn

        Private colFullName As DevExpress.XtraGrid.Columns.GridColumn

        Private colAddress As DevExpress.XtraGrid.Columns.GridColumn

        Private colDepartment As DevExpress.XtraGrid.Columns.GridColumn

        Private colCheck As DevExpress.XtraGrid.Columns.GridColumn

        Private itemForControl As DevExpress.XtraLayout.LayoutControlItem

        Private itemForOkBtn As DevExpress.XtraLayout.LayoutControlItem

        Private itemForCancelBtn As DevExpress.XtraLayout.LayoutControlItem

        Private itemForName As DevExpress.XtraLayout.LayoutControlItem

        Private itemForSaveCheck As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private separator As DevExpress.XtraLayout.SimpleSeparator
    End Class
End Namespace
