Namespace DevExpress.DevAV.Modules

    Partial Class QuotesCustomFilter

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
            Me.saveFilter = New DevExpress.XtraEditors.CheckEdit()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.filterName = New DevExpress.XtraEditors.TextEdit()
            Me.filterControl = New DevExpress.XtraEditors.FilterControl()
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
            Me.okBtn.Location = New System.Drawing.Point(280, 254)
            Me.okBtn.Name = "okBtn"
            Me.okBtn.Size = New System.Drawing.Size(78, 22)
            Me.okBtn.StyleController = Me.moduleLayout
            Me.okBtn.TabIndex = 0
            Me.okBtn.Text = "OK"
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.saveFilter)
            Me.moduleLayout.Controls.Add(Me.filterName)
            Me.moduleLayout.Controls.Add(Me.filterControl)
            Me.moduleLayout.Controls.Add(Me.cancelBtn)
            Me.moduleLayout.Controls.Add(Me.okBtn)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.layoutControlGroup
            Me.moduleLayout.Size = New System.Drawing.Size(452, 288)
            Me.moduleLayout.TabIndex = 0
            Me.saveFilter.AutoSizeInLayoutControl = True
            Me.saveFilter.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Save", True))
            Me.saveFilter.Location = New System.Drawing.Point(12, 179)
            Me.saveFilter.Name = "saveFilter"
            Me.saveFilter.Properties.Caption = "Save for future use"
            Me.saveFilter.Size = New System.Drawing.Size(116, 19)
            Me.saveFilter.StyleController = Me.moduleLayout
            Me.saveFilter.TabIndex = 5
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.ViewModels.CustomFilterViewModel)
            Me.filterName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Name", True))
            Me.filterName.EditValue = ""
            Me.filterName.Location = New System.Drawing.Point(12, 202)
            Me.filterName.Name = "filterName"
            Me.filterName.Properties.NullValuePrompt = "Enter a name for your custom filter"
            Me.filterName.Properties.NullValuePromptShowForEmptyValue = True
            Me.filterName.Size = New System.Drawing.Size(428, 20)
            Me.filterName.StyleController = Me.moduleLayout
            Me.filterName.TabIndex = 4
            Me.filterControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.filterControl.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.filterControl.Location = New System.Drawing.Point(0, 0)
            Me.filterControl.Name = "filterControl"
            Me.filterControl.Size = New System.Drawing.Size(452, 161)
            Me.filterControl.TabIndex = 2
            Me.cancelBtn.Location = New System.Drawing.Point(362, 254)
            Me.cancelBtn.Name = "cancelBtn"
            Me.cancelBtn.Size = New System.Drawing.Size(78, 22)
            Me.cancelBtn.StyleController = Me.moduleLayout
            Me.cancelBtn.TabIndex = 1
            Me.cancelBtn.Text = "Cancel"
            Me.layoutControlGroup.CustomizationFormText = "Root"
            Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup.GroupBordersVisible = False
            Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.itemForControl, Me.itemForOkBtn, Me.itemForCancelBtn, Me.itemForName, Me.itemForSaveCheck, Me.emptySpaceItem, Me.separator})
            Me.layoutControlGroup.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup.Name = "Root"
            Me.layoutControlGroup.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup.Size = New System.Drawing.Size(452, 288)
            Me.layoutControlGroup.Text = "Root"
            Me.itemForControl.Control = Me.filterControl
            Me.itemForControl.CustomizationFormText = "itemForControl"
            Me.itemForControl.Location = New System.Drawing.Point(0, 0)
            Me.itemForControl.Name = "itemForControl"
            Me.itemForControl.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.itemForControl.Size = New System.Drawing.Size(452, 161)
            Me.itemForControl.Text = "itemForControl"
            Me.itemForControl.TextSize = New System.Drawing.Size(0, 0)
            Me.itemForControl.TextToControlDistance = 0
            Me.itemForControl.TextVisible = False
            Me.itemForOkBtn.Control = Me.okBtn
            Me.itemForOkBtn.CustomizationFormText = "itemForOkBtn"
            Me.itemForOkBtn.Location = New System.Drawing.Point(268, 242)
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
            Me.itemForCancelBtn.Location = New System.Drawing.Point(360, 242)
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
            Me.itemForName.Location = New System.Drawing.Point(0, 198)
            Me.itemForName.Name = "itemForName"
            Me.itemForName.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 4, 20)
            Me.itemForName.Size = New System.Drawing.Size(452, 44)
            Me.itemForName.Text = "itemForName"
            Me.itemForName.TextSize = New System.Drawing.Size(0, 0)
            Me.itemForName.TextToControlDistance = 0
            Me.itemForName.TextVisible = False
            Me.itemForSaveCheck.Control = Me.saveFilter
            Me.itemForSaveCheck.CustomizationFormText = "itemForSaveCheck"
            Me.itemForSaveCheck.Location = New System.Drawing.Point(0, 163)
            Me.itemForSaveCheck.Name = "itemForSaveCheck"
            Me.itemForSaveCheck.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 16, 0)
            Me.itemForSaveCheck.Size = New System.Drawing.Size(452, 35)
            Me.itemForSaveCheck.Text = "itemForSaveCheck"
            Me.itemForSaveCheck.TextSize = New System.Drawing.Size(0, 0)
            Me.itemForSaveCheck.TextToControlDistance = 0
            Me.itemForSaveCheck.TextVisible = False
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 242)
            Me.emptySpaceItem.Name = "emptySpaceItem1"
            Me.emptySpaceItem.Size = New System.Drawing.Size(268, 46)
            Me.emptySpaceItem.Text = "emptySpaceItem1"
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            Me.separator.AllowHotTrack = False
            Me.separator.CustomizationFormText = "simpleSeparator1"
            Me.separator.Location = New System.Drawing.Point(0, 161)
            Me.separator.Name = "simpleSeparator1"
            Me.separator.Size = New System.Drawing.Size(452, 2)
            Me.separator.Text = "simpleSeparator1"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "QuotesCustomFilter"
            Me.Size = New System.Drawing.Size(452, 288)
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
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

        Private filterControl As DevExpress.XtraEditors.FilterControl

        Private moduleLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private itemForControl As DevExpress.XtraLayout.LayoutControlItem

        Private itemForOkBtn As DevExpress.XtraLayout.LayoutControlItem

        Private itemForCancelBtn As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private filterName As DevExpress.XtraEditors.TextEdit

        Private itemForName As DevExpress.XtraLayout.LayoutControlItem

        Private saveFilter As DevExpress.XtraEditors.CheckEdit

        Private itemForSaveCheck As DevExpress.XtraLayout.LayoutControlItem

        Private bindingSource As System.Windows.Forms.BindingSource

        Private separator As DevExpress.XtraLayout.SimpleSeparator
    End Class
End Namespace
