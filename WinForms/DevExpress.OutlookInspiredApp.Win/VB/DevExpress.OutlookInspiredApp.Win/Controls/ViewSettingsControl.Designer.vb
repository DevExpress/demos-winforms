Namespace DevExpress.DevAV.Modules

    Partial Class ViewSettingsControl

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
            Me.okBtn = New DevExpress.XtraEditors.SimpleButton()
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.resetViewBtn = New DevExpress.XtraEditors.SimpleButton()
            Me.resetFiltersBtn = New DevExpress.XtraEditors.SimpleButton()
            Me.cancelBtn = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.itemForOkBtn = New DevExpress.XtraLayout.LayoutControlItem()
            Me.itemForCancelBtn = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.separator = New DevExpress.XtraLayout.SimpleSeparator()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.itemForOkBtn), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.itemForCancelBtn), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.separator), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.okBtn.Location = New System.Drawing.Point(280, 254)
            Me.okBtn.Name = "okBtn"
            Me.okBtn.Size = New System.Drawing.Size(78, 22)
            Me.okBtn.StyleController = Me.moduleLayout
            Me.okBtn.TabIndex = 0
            Me.okBtn.Text = "OK"
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.resetViewBtn)
            Me.moduleLayout.Controls.Add(Me.resetFiltersBtn)
            Me.moduleLayout.Controls.Add(Me.cancelBtn)
            Me.moduleLayout.Controls.Add(Me.okBtn)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.layoutControlGroup
            Me.moduleLayout.Size = New System.Drawing.Size(452, 288)
            Me.moduleLayout.TabIndex = 0
            Me.resetViewBtn.Location = New System.Drawing.Point(12, 46)
            Me.resetViewBtn.Name = "resetViewBtn"
            Me.resetViewBtn.Size = New System.Drawing.Size(165, 22)
            Me.resetViewBtn.StyleController = Me.moduleLayout
            Me.resetViewBtn.TabIndex = 7
            Me.resetViewBtn.Text = "Reset View"
            Me.resetFiltersBtn.Location = New System.Drawing.Point(12, 16)
            Me.resetFiltersBtn.Name = "resetFiltersBtn"
            Me.resetFiltersBtn.Size = New System.Drawing.Size(165, 22)
            Me.resetFiltersBtn.StyleController = Me.moduleLayout
            Me.resetFiltersBtn.TabIndex = 6
            Me.resetFiltersBtn.Text = "Reset Custom Filters"
            Me.cancelBtn.Location = New System.Drawing.Point(362, 254)
            Me.cancelBtn.Name = "cancelBtn"
            Me.cancelBtn.Size = New System.Drawing.Size(78, 22)
            Me.cancelBtn.StyleController = Me.moduleLayout
            Me.cancelBtn.TabIndex = 1
            Me.cancelBtn.Text = "Cancel"
            Me.layoutControlGroup.CustomizationFormText = "Root"
            Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup.GroupBordersVisible = False
            Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.itemForOkBtn, Me.itemForCancelBtn, Me.emptySpaceItem, Me.layoutControlItem1, Me.layoutControlItem2, Me.separator, Me.emptySpaceItem1})
            Me.layoutControlGroup.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup.Name = "Root"
            Me.layoutControlGroup.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup.Size = New System.Drawing.Size(452, 288)
            Me.layoutControlGroup.Text = "Root"
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
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 242)
            Me.emptySpaceItem.Name = "emptySpaceItem1"
            Me.emptySpaceItem.Size = New System.Drawing.Size(268, 46)
            Me.emptySpaceItem.Text = "emptySpaceItem1"
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.Control = Me.resetFiltersBtn
            Me.layoutControlItem1.CustomizationFormText = "Reset Custom Filters"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 16, 4)
            Me.layoutControlItem1.Size = New System.Drawing.Size(452, 42)
            Me.layoutControlItem1.Text = "Replace all the filters created by user with predefined"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(257, 13)
            Me.layoutControlItem2.Control = Me.resetViewBtn
            Me.layoutControlItem2.CustomizationFormText = "Reset View"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 42)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 4, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(452, 30)
            Me.layoutControlItem2.Text = "Change View type to default (List, Card etc.)"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(257, 13)
            Me.separator.AllowHotTrack = False
            Me.separator.CustomizationFormText = "simpleSeparator1"
            Me.separator.Location = New System.Drawing.Point(0, 240)
            Me.separator.Name = "simpleSeparator1"
            Me.separator.Size = New System.Drawing.Size(452, 2)
            Me.separator.Text = "simpleSeparator1"
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 72)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(452, 168)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "ViewSettingsControl"
            Me.Size = New System.Drawing.Size(452, 288)
            CType((Me.moduleLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.itemForOkBtn), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.itemForCancelBtn), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.separator), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private okBtn As DevExpress.XtraEditors.SimpleButton

        Private cancelBtn As DevExpress.XtraEditors.SimpleButton

        Private moduleLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private itemForOkBtn As DevExpress.XtraLayout.LayoutControlItem

        Private itemForCancelBtn As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private separator As DevExpress.XtraLayout.SimpleSeparator

        Private resetViewBtn As DevExpress.XtraEditors.SimpleButton

        Private resetFiltersBtn As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
