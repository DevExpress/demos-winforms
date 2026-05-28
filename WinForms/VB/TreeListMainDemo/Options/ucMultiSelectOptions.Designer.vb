Namespace DevExpress.XtraTreeList.Demos.Options

    Partial Class ucMultiSelectOptions

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
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.btnShowSelectedValues = New DevExpress.XtraEditors.SimpleButton()
            Me.imcMultiSelectMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceAllowMultiSelect = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.liAllowMultiSelect = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liMultiSelectMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liShowSelectedValues = New DevExpress.XtraLayout.LayoutControlItem()
            Me.behaviorManager = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.ceMultiCellEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.liMultiCellEdit = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.imcMultiSelectMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowMultiSelect.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowMultiSelect), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liMultiSelectMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liShowSelectedValues), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceMultiCellEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liMultiCellEdit), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.btnShowSelectedValues)
            Me.layoutControl.Controls.Add(Me.imcMultiSelectMode)
            Me.layoutControl.Controls.Add(Me.ceAllowMultiSelect)
            Me.layoutControl.Controls.Add(Me.ceMultiCellEdit)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 726, 758)
            Me.layoutControl.Root = Me.layoutControlGroup
            Me.layoutControl.Size = New System.Drawing.Size(187, 217)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' btnShowSelectedValues
            ' 
            Me.btnShowSelectedValues.Location = New System.Drawing.Point(12, 100)
            Me.btnShowSelectedValues.Name = "btnShowSelectedValues"
            Me.btnShowSelectedValues.Size = New System.Drawing.Size(163, 22)
            Me.btnShowSelectedValues.StyleController = Me.layoutControl
            Me.btnShowSelectedValues.TabIndex = 0
            Me.btnShowSelectedValues.Text = "Show Selected Values"
            AddHandler Me.btnShowSelectedValues.Click, New System.EventHandler(AddressOf Me.btnShowSelectedValues_Click)
            ' 
            ' imcMultiSelectMode
            ' 
            Me.imcMultiSelectMode.EditValue = "imageComboBoxEdit1"
            Me.imcMultiSelectMode.Location = New System.Drawing.Point(12, 28)
            Me.imcMultiSelectMode.Name = "imcMultiSelectMode"
            Me.imcMultiSelectMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imcMultiSelectMode.Size = New System.Drawing.Size(163, 20)
            Me.imcMultiSelectMode.StyleController = Me.layoutControl
            Me.imcMultiSelectMode.TabIndex = 1
            AddHandler Me.imcMultiSelectMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbMultiSelectMode_SelectedIndexChanged)
            ' 
            ' ceAllowMultiSelect
            ' 
            Me.ceAllowMultiSelect.Location = New System.Drawing.Point(12, 52)
            Me.ceAllowMultiSelect.Name = "ceAllowMultiSelect"
            Me.ceAllowMultiSelect.Properties.Caption = "Multi Select"
            Me.ceAllowMultiSelect.Size = New System.Drawing.Size(163, 20)
            Me.ceAllowMultiSelect.StyleController = Me.layoutControl
            Me.ceAllowMultiSelect.TabIndex = 0
            AddHandler Me.ceAllowMultiSelect.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowMultiSelect_CheckedChanged)
            ' 
            ' layoutControlGroup
            ' 
            Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup.GroupBordersVisible = False
            Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.liAllowMultiSelect, Me.liMultiSelectMode, Me.liShowSelectedValues, Me.liMultiCellEdit})
            Me.layoutControlGroup.Name = "layoutControlGroup"
            Me.layoutControlGroup.Size = New System.Drawing.Size(187, 217)
            Me.layoutControlGroup.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 114)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(167, 83)
            ' 
            ' liAllowMultiSelect
            ' 
            Me.liAllowMultiSelect.Control = Me.ceAllowMultiSelect
            Me.liAllowMultiSelect.Location = New System.Drawing.Point(0, 40)
            Me.liAllowMultiSelect.Name = "liAllowMultiSelect"
            Me.liAllowMultiSelect.Size = New System.Drawing.Size(167, 24)
            Me.liAllowMultiSelect.TextVisible = False
            ' 
            ' liMultiSelectMode
            ' 
            Me.liMultiSelectMode.Control = Me.imcMultiSelectMode
            Me.liMultiSelectMode.Location = New System.Drawing.Point(0, 0)
            Me.liMultiSelectMode.Name = "liMultiSelectMode"
            Me.liMultiSelectMode.Size = New System.Drawing.Size(167, 40)
            Me.liMultiSelectMode.Text = "Multi Select Mode:"
            Me.liMultiSelectMode.TextLocation = DevExpress.Utils.Locations.Top
            Me.liMultiSelectMode.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' liShowSelectedValues
            ' 
            Me.liShowSelectedValues.Control = Me.btnShowSelectedValues
            Me.liShowSelectedValues.Location = New System.Drawing.Point(0, 88)
            Me.liShowSelectedValues.Name = "liShowSelectedValues"
            Me.liShowSelectedValues.Size = New System.Drawing.Size(167, 26)
            Me.liShowSelectedValues.TextVisible = False
            ' 
            ' ceMultiCellEdit
            ' 
            Me.ceMultiCellEdit.Location = New System.Drawing.Point(12, 76)
            Me.ceMultiCellEdit.Name = "ceMultiCellEdit"
            Me.ceMultiCellEdit.Properties.Caption = "Multi-Cell Editing"
            Me.ceMultiCellEdit.Size = New System.Drawing.Size(163, 20)
            Me.ceMultiCellEdit.StyleController = Me.layoutControl
            Me.ceMultiCellEdit.TabIndex = 4
            AddHandler Me.ceMultiCellEdit.CheckedChanged, New System.EventHandler(AddressOf Me.ceMultiCellEdit_CheckedChanged)
            ' 
            ' liMultiCellEdit
            ' 
            Me.liMultiCellEdit.Control = Me.ceMultiCellEdit
            Me.liMultiCellEdit.Location = New System.Drawing.Point(0, 64)
            Me.liMultiCellEdit.Name = "liMultiCellEdit"
            Me.liMultiCellEdit.Size = New System.Drawing.Size(167, 24)
            Me.liMultiCellEdit.TextVisible = False
            ' 
            ' ucMultiSelectOptions
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "ucMultiSelectOptions"
            Me.Size = New System.Drawing.Size(187, 217)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.imcMultiSelectMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowMultiSelect.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowMultiSelect), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liMultiSelectMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liShowSelectedValues), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceMultiCellEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liMultiCellEdit), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private btnShowSelectedValues As DevExpress.XtraEditors.SimpleButton

        Private imcMultiSelectMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceAllowMultiSelect As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private liAllowMultiSelect As DevExpress.XtraLayout.LayoutControlItem

        Private liMultiSelectMode As DevExpress.XtraLayout.LayoutControlItem

        Private liShowSelectedValues As DevExpress.XtraLayout.LayoutControlItem

        Private behaviorManager As DevExpress.Utils.Behaviors.BehaviorManager

        Private ceMultiCellEdit As DevExpress.XtraEditors.CheckEdit

        Private liMultiCellEdit As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
