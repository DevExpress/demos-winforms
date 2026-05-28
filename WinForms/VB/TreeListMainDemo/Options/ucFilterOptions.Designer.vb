Namespace DevExpress.XtraTreeList.Demos.Options

    Partial Class ucFilterOptions

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
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.ceColumnFilterList = New DevExpress.XtraEditors.CheckEdit()
            Me.ieShowFilterPanelMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceShowAllValuesInFilterPopup = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAutoFilterRow = New DevExpress.XtraEditors.CheckEdit()
            Me.ceFilterList = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowFilter = New DevExpress.XtraEditors.CheckEdit()
            Me.cbFilterMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceFilterEditor = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.liAllowFilterMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liFilterMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liFilterEditor = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liAllowMRUFilterLlist = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liShowAutoFilterRow = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.liShowAllValuesInFilterPopup = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liShowFilterPanelMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liColumnFilterList = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.ceColumnFilterList.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ieShowFilterPanelMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowAllValuesInFilterPopup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAutoFilterRow.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceFilterList.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowFilter.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbFilterMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceFilterEditor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowFilterMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liFilterMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liFilterEditor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowMRUFilterLlist), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liShowAutoFilterRow), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liShowAllValuesInFilterPopup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liShowFilterPanelMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liColumnFilterList), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.ceColumnFilterList)
            Me.layoutControl.Controls.Add(Me.ieShowFilterPanelMode)
            Me.layoutControl.Controls.Add(Me.ceShowAllValuesInFilterPopup)
            Me.layoutControl.Controls.Add(Me.ceAutoFilterRow)
            Me.layoutControl.Controls.Add(Me.ceFilterList)
            Me.layoutControl.Controls.Add(Me.ceAllowFilter)
            Me.layoutControl.Controls.Add(Me.cbFilterMode)
            Me.layoutControl.Controls.Add(Me.ceFilterEditor)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 596, 696)
            Me.layoutControl.Root = Me.layoutControlGroup
            Me.layoutControl.Size = New System.Drawing.Size(208, 274)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' ceColumnFilterList
            ' 
            Me.ceColumnFilterList.Location = New System.Drawing.Point(12, 166)
            Me.ceColumnFilterList.Name = "ceColumnFilterList"
            Me.ceColumnFilterList.Properties.Caption = "Allow Column MRU Filter List"
            Me.ceColumnFilterList.Size = New System.Drawing.Size(184, 20)
            Me.ceColumnFilterList.StyleController = Me.layoutControl
            Me.ceColumnFilterList.TabIndex = 9
            AddHandler Me.ceColumnFilterList.CheckedChanged, New System.EventHandler(AddressOf Me.ceColumnFilterList_CheckedChanged)
            ' 
            ' ieShowFilterPanelMode
            ' 
            Me.ieShowFilterPanelMode.Location = New System.Drawing.Point(139, 70)
            Me.ieShowFilterPanelMode.Name = "ieShowFilterPanelMode"
            Me.ieShowFilterPanelMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ieShowFilterPanelMode.Properties.DropDownRows = 25
            Me.ieShowFilterPanelMode.Size = New System.Drawing.Size(57, 20)
            Me.ieShowFilterPanelMode.StyleController = Me.layoutControl
            Me.ieShowFilterPanelMode.TabIndex = 8
            AddHandler Me.ieShowFilterPanelMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.ieShowFilterPanelMode_SelectedIndexChanged)
            ' 
            ' ceShowAllValuesInFilterPopup
            ' 
            Me.ceShowAllValuesInFilterPopup.Location = New System.Drawing.Point(12, 190)
            Me.ceShowAllValuesInFilterPopup.Name = "ceShowAllValuesInFilterPopup"
            Me.ceShowAllValuesInFilterPopup.Properties.Caption = "Show All Values in Filter Popup"
            Me.ceShowAllValuesInFilterPopup.Size = New System.Drawing.Size(184, 20)
            Me.ceShowAllValuesInFilterPopup.StyleController = Me.layoutControl
            Me.ceShowAllValuesInFilterPopup.TabIndex = 7
            AddHandler Me.ceShowAllValuesInFilterPopup.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowAllValuesInFilterPopup_CheckedChanged)
            ' 
            ' ceAutoFilterRow
            ' 
            Me.ceAutoFilterRow.Location = New System.Drawing.Point(12, 94)
            Me.ceAutoFilterRow.Name = "ceAutoFilterRow"
            Me.ceAutoFilterRow.Properties.Caption = "Show Auto Filter Row"
            Me.ceAutoFilterRow.Size = New System.Drawing.Size(184, 20)
            Me.ceAutoFilterRow.StyleController = Me.layoutControl
            Me.ceAutoFilterRow.TabIndex = 4
            AddHandler Me.ceAutoFilterRow.CheckedChanged, New System.EventHandler(AddressOf Me.ceAutoFilterRow_CheckedChanged)
            ' 
            ' ceFilterList
            ' 
            Me.ceFilterList.Location = New System.Drawing.Point(12, 142)
            Me.ceFilterList.Name = "ceFilterList"
            Me.ceFilterList.Properties.Caption = "Allow MRU filter list"
            Me.ceFilterList.Size = New System.Drawing.Size(184, 20)
            Me.ceFilterList.StyleController = Me.layoutControl
            Me.ceFilterList.TabIndex = 5
            AddHandler Me.ceFilterList.CheckedChanged, New System.EventHandler(AddressOf Me.ceFilterList_CheckedChanged)
            ' 
            ' ceAllowFilter
            ' 
            Me.ceAllowFilter.Location = New System.Drawing.Point(12, 12)
            Me.ceAllowFilter.Name = "ceAllowFilter"
            Me.ceAllowFilter.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.ceAllowFilter.Properties.Appearance.Options.UseFont = True
            Me.ceAllowFilter.Properties.Caption = "Allow Filter"
            Me.ceAllowFilter.Size = New System.Drawing.Size(184, 20)
            Me.ceAllowFilter.StyleController = Me.layoutControl
            Me.ceAllowFilter.TabIndex = 0
            AddHandler Me.ceAllowFilter.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowFilter_CheckedChanged)
            ' 
            ' cbFilterMode
            ' 
            Me.cbFilterMode.Location = New System.Drawing.Point(139, 46)
            Me.cbFilterMode.Name = "cbFilterMode"
            Me.cbFilterMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbFilterMode.Properties.DropDownRows = 25
            Me.cbFilterMode.Size = New System.Drawing.Size(57, 20)
            Me.cbFilterMode.StyleController = Me.layoutControl
            Me.cbFilterMode.TabIndex = 2
            AddHandler Me.cbFilterMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbFilterMode_SelectedIndexChanged)
            ' 
            ' ceFilterEditor
            ' 
            Me.ceFilterEditor.Location = New System.Drawing.Point(12, 118)
            Me.ceFilterEditor.Name = "ceFilterEditor"
            Me.ceFilterEditor.Properties.Caption = "Allow Filter Editor"
            Me.ceFilterEditor.Size = New System.Drawing.Size(184, 20)
            Me.ceFilterEditor.StyleController = Me.layoutControl
            Me.ceFilterEditor.TabIndex = 3
            AddHandler Me.ceFilterEditor.CheckedChanged, New System.EventHandler(AddressOf Me.ceFilterEditor_CheckedChanged)
            ' 
            ' layoutControlGroup
            ' 
            Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup.GroupBordersVisible = False
            Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.liAllowFilterMode, Me.liFilterMode, Me.liFilterEditor, Me.liAllowMRUFilterLlist, Me.liShowAutoFilterRow, Me.emptySpaceItem2, Me.liShowAllValuesInFilterPopup, Me.liShowFilterPanelMode, Me.liColumnFilterList})
            Me.layoutControlGroup.Name = "Root"
            Me.layoutControlGroup.Size = New System.Drawing.Size(208, 274)
            Me.layoutControlGroup.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 202)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(188, 52)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' liAllowFilterMode
            ' 
            Me.liAllowFilterMode.Control = Me.ceAllowFilter
            Me.liAllowFilterMode.Location = New System.Drawing.Point(0, 0)
            Me.liAllowFilterMode.Name = "liAllowFilterMode"
            Me.liAllowFilterMode.Size = New System.Drawing.Size(188, 24)
            Me.liAllowFilterMode.TextSize = New System.Drawing.Size(0, 0)
            Me.liAllowFilterMode.TextVisible = False
            ' 
            ' liFilterMode
            ' 
            Me.liFilterMode.Control = Me.cbFilterMode
            Me.liFilterMode.Location = New System.Drawing.Point(0, 34)
            Me.liFilterMode.Name = "liFilterMode"
            Me.liFilterMode.Size = New System.Drawing.Size(188, 24)
            Me.liFilterMode.Text = "Filter Mode:"
            Me.liFilterMode.TextSize = New System.Drawing.Size(115, 13)
            ' 
            ' liFilterEditor
            ' 
            Me.liFilterEditor.Control = Me.ceFilterEditor
            Me.liFilterEditor.Location = New System.Drawing.Point(0, 106)
            Me.liFilterEditor.Name = "liFilterEditor"
            Me.liFilterEditor.Size = New System.Drawing.Size(188, 24)
            Me.liFilterEditor.TextSize = New System.Drawing.Size(0, 0)
            Me.liFilterEditor.TextVisible = False
            ' 
            ' liAllowMRUFilterLlist
            ' 
            Me.liAllowMRUFilterLlist.Control = Me.ceFilterList
            Me.liAllowMRUFilterLlist.Location = New System.Drawing.Point(0, 130)
            Me.liAllowMRUFilterLlist.Name = "liAllowMRUFilterLlist"
            Me.liAllowMRUFilterLlist.Size = New System.Drawing.Size(188, 24)
            Me.liAllowMRUFilterLlist.TextSize = New System.Drawing.Size(0, 0)
            Me.liAllowMRUFilterLlist.TextVisible = False
            ' 
            ' liShowAutoFilterRow
            ' 
            Me.liShowAutoFilterRow.Control = Me.ceAutoFilterRow
            Me.liShowAutoFilterRow.Location = New System.Drawing.Point(0, 82)
            Me.liShowAutoFilterRow.Name = "liShowAutoFilterRow"
            Me.liShowAutoFilterRow.Size = New System.Drawing.Size(188, 24)
            Me.liShowAutoFilterRow.TextSize = New System.Drawing.Size(0, 0)
            Me.liShowAutoFilterRow.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 10)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 10)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(188, 10)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' liShowAllValuesInFilterPopup
            ' 
            Me.liShowAllValuesInFilterPopup.Control = Me.ceShowAllValuesInFilterPopup
            Me.liShowAllValuesInFilterPopup.Location = New System.Drawing.Point(0, 178)
            Me.liShowAllValuesInFilterPopup.Name = "liShowAllValuesInFilterPopup"
            Me.liShowAllValuesInFilterPopup.Size = New System.Drawing.Size(188, 24)
            Me.liShowAllValuesInFilterPopup.TextSize = New System.Drawing.Size(0, 0)
            Me.liShowAllValuesInFilterPopup.TextVisible = False
            ' 
            ' liShowFilterPanelMode
            ' 
            Me.liShowFilterPanelMode.Control = Me.ieShowFilterPanelMode
            Me.liShowFilterPanelMode.Location = New System.Drawing.Point(0, 58)
            Me.liShowFilterPanelMode.Name = "liShowFilterPanelMode"
            Me.liShowFilterPanelMode.Size = New System.Drawing.Size(188, 24)
            Me.liShowFilterPanelMode.Text = "Show Filter Panel Mode:"
            Me.liShowFilterPanelMode.TextSize = New System.Drawing.Size(115, 13)
            ' 
            ' liColumnFilterList
            ' 
            Me.liColumnFilterList.Control = Me.ceColumnFilterList
            Me.liColumnFilterList.Location = New System.Drawing.Point(0, 154)
            Me.liColumnFilterList.Name = "liColumnFilterList"
            Me.liColumnFilterList.Size = New System.Drawing.Size(188, 24)
            Me.liColumnFilterList.TextSize = New System.Drawing.Size(0, 0)
            Me.liColumnFilterList.TextVisible = False
            ' 
            ' ucFilterOptions
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "ucFilterOptions"
            Me.Size = New System.Drawing.Size(208, 274)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.ceColumnFilterList.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ieShowFilterPanelMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowAllValuesInFilterPopup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAutoFilterRow.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceFilterList.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowFilter.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbFilterMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceFilterEditor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowFilterMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liFilterMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liFilterEditor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowMRUFilterLlist), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liShowAutoFilterRow), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liShowAllValuesInFilterPopup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liShowFilterPanelMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liColumnFilterList), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private ceAutoFilterRow As DevExpress.XtraEditors.CheckEdit

        Private ceFilterList As DevExpress.XtraEditors.CheckEdit

        Private ceAllowFilter As DevExpress.XtraEditors.CheckEdit

        Private cbFilterMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceFilterEditor As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private liAllowFilterMode As DevExpress.XtraLayout.LayoutControlItem

        Private liFilterMode As DevExpress.XtraLayout.LayoutControlItem

        Private liFilterEditor As DevExpress.XtraLayout.LayoutControlItem

        Private liShowAutoFilterRow As DevExpress.XtraLayout.LayoutControlItem

        Private liAllowMRUFilterLlist As DevExpress.XtraLayout.LayoutControlItem

        Private ceShowAllValuesInFilterPopup As DevExpress.XtraEditors.CheckEdit

        Private liShowAllValuesInFilterPopup As DevExpress.XtraLayout.LayoutControlItem

        Private ieShowFilterPanelMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private liShowFilterPanelMode As DevExpress.XtraLayout.LayoutControlItem

        Private ceColumnFilterList As DevExpress.XtraEditors.CheckEdit

        Private liColumnFilterList As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
