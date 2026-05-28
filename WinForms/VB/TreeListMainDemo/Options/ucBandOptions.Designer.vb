Namespace DevExpress.XtraTreeList.Demos.Options

    Partial Class ucBandOptions

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
            Me.ceAllowBandColumnsMultiRow = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowBands = New DevExpress.XtraEditors.CheckEdit()
            Me.ceCustomizationFormSearchBoxVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowBandsInCustomizationForm = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowColumnResizing = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowColumnMoving = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowChangeColumnParent = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowChangeBandParent = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowBandResizing = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowBandMoving = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lgCustomization = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.liAllowBandMoving = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liAllowBandResizing = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liAllowChangeBandParent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liAllowChangeColumnParent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liAllowColumnMoving = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liAllowColumnResizing = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liShowBandsInCustomizationForm = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liCustomizationFormSearchBoxVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lgView = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.liShowBands = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liAllowBandColumnsMultiRow = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.ceAllowBandColumnsMultiRow.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowBands.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCustomizationFormSearchBoxVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowBandsInCustomizationForm.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowColumnResizing.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowColumnMoving.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowChangeColumnParent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowChangeBandParent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowBandResizing.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowBandMoving.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lgCustomization), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowBandMoving), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowBandResizing), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowChangeBandParent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowChangeColumnParent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowColumnMoving), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowColumnResizing), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liShowBandsInCustomizationForm), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liCustomizationFormSearchBoxVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lgView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liShowBands), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liAllowBandColumnsMultiRow), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.Controls.Add(Me.ceAllowBandColumnsMultiRow)
            Me.layoutControl.Controls.Add(Me.ceShowBands)
            Me.layoutControl.Controls.Add(Me.ceCustomizationFormSearchBoxVisible)
            Me.layoutControl.Controls.Add(Me.ceShowBandsInCustomizationForm)
            Me.layoutControl.Controls.Add(Me.ceAllowColumnResizing)
            Me.layoutControl.Controls.Add(Me.ceAllowColumnMoving)
            Me.layoutControl.Controls.Add(Me.ceAllowChangeColumnParent)
            Me.layoutControl.Controls.Add(Me.ceAllowChangeBandParent)
            Me.layoutControl.Controls.Add(Me.ceAllowBandResizing)
            Me.layoutControl.Controls.Add(Me.ceAllowBandMoving)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(701, 0, 650, 400)
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(250, 340)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' ceAllowBandColumnsMultiRow
            ' 
            Me.ceAllowBandColumnsMultiRow.Location = New System.Drawing.Point(12, 54)
            Me.ceAllowBandColumnsMultiRow.Name = "ceAllowBandColumnsMultiRow"
            Me.ceAllowBandColumnsMultiRow.Properties.Caption = "Allow Band Columns Multi Row"
            Me.ceAllowBandColumnsMultiRow.Size = New System.Drawing.Size(226, 19)
            Me.ceAllowBandColumnsMultiRow.StyleController = Me.layoutControl
            Me.ceAllowBandColumnsMultiRow.TabIndex = 14
            AddHandler Me.ceAllowBandColumnsMultiRow.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowBandColumnsMultiRow_CheckedChanged)
            ' 
            ' ceShowBands
            ' 
            Me.ceShowBands.Location = New System.Drawing.Point(12, 31)
            Me.ceShowBands.Name = "ceShowBands"
            Me.ceShowBands.Properties.Caption = "Show Bands"
            Me.ceShowBands.Size = New System.Drawing.Size(226, 19)
            Me.ceShowBands.StyleController = Me.layoutControl
            Me.ceShowBands.TabIndex = 13
            AddHandler Me.ceShowBands.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowBands_CheckedChanged)
            ' 
            ' ceCustomizationFormSearchBoxVisible
            ' 
            Me.ceCustomizationFormSearchBoxVisible.Location = New System.Drawing.Point(12, 277)
            Me.ceCustomizationFormSearchBoxVisible.Name = "ceCustomizationFormSearchBoxVisible"
            Me.ceCustomizationFormSearchBoxVisible.Properties.Caption = "Customization Form Search Box Visible"
            Me.ceCustomizationFormSearchBoxVisible.Size = New System.Drawing.Size(226, 19)
            Me.ceCustomizationFormSearchBoxVisible.StyleController = Me.layoutControl
            Me.ceCustomizationFormSearchBoxVisible.TabIndex = 12
            AddHandler Me.ceCustomizationFormSearchBoxVisible.CheckedChanged, New System.EventHandler(AddressOf Me.ceCustomizationFormSearchBoxVisible_CheckedChanged)
            ' 
            ' ceShowBandsInCustomizationForm
            ' 
            Me.ceShowBandsInCustomizationForm.Location = New System.Drawing.Point(12, 254)
            Me.ceShowBandsInCustomizationForm.Name = "ceShowBandsInCustomizationForm"
            Me.ceShowBandsInCustomizationForm.Properties.Caption = "Show Bands In Customization Form"
            Me.ceShowBandsInCustomizationForm.Size = New System.Drawing.Size(226, 19)
            Me.ceShowBandsInCustomizationForm.StyleController = Me.layoutControl
            Me.ceShowBandsInCustomizationForm.TabIndex = 11
            AddHandler Me.ceShowBandsInCustomizationForm.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowBandsInCustomizationForm_CheckedChanged)
            ' 
            ' ceAllowColumnResizing
            ' 
            Me.ceAllowColumnResizing.Location = New System.Drawing.Point(12, 231)
            Me.ceAllowColumnResizing.Name = "ceAllowColumnResizing"
            Me.ceAllowColumnResizing.Properties.Caption = "Allow Column Resizing"
            Me.ceAllowColumnResizing.Size = New System.Drawing.Size(226, 19)
            Me.ceAllowColumnResizing.StyleController = Me.layoutControl
            Me.ceAllowColumnResizing.TabIndex = 10
            AddHandler Me.ceAllowColumnResizing.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowColumnResizing_CheckedChanged)
            ' 
            ' ceAllowColumnMoving
            ' 
            Me.ceAllowColumnMoving.Location = New System.Drawing.Point(12, 208)
            Me.ceAllowColumnMoving.Name = "ceAllowColumnMoving"
            Me.ceAllowColumnMoving.Properties.Caption = "Allow Column Moving"
            Me.ceAllowColumnMoving.Size = New System.Drawing.Size(226, 19)
            Me.ceAllowColumnMoving.StyleController = Me.layoutControl
            Me.ceAllowColumnMoving.TabIndex = 6
            AddHandler Me.ceAllowColumnMoving.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowColumnMoving_CheckedChanged)
            ' 
            ' ceAllowChangeColumnParent
            ' 
            Me.ceAllowChangeColumnParent.Location = New System.Drawing.Point(12, 185)
            Me.ceAllowChangeColumnParent.Name = "ceAllowChangeColumnParent"
            Me.ceAllowChangeColumnParent.Properties.Caption = "Allow Change Column Parent"
            Me.ceAllowChangeColumnParent.Size = New System.Drawing.Size(226, 19)
            Me.ceAllowChangeColumnParent.StyleController = Me.layoutControl
            Me.ceAllowChangeColumnParent.TabIndex = 9
            AddHandler Me.ceAllowChangeColumnParent.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowChangeColumnParent_CheckedChanged)
            ' 
            ' ceAllowChangeBandParent
            ' 
            Me.ceAllowChangeBandParent.Location = New System.Drawing.Point(12, 162)
            Me.ceAllowChangeBandParent.Name = "ceAllowChangeBandParent"
            Me.ceAllowChangeBandParent.Properties.Caption = "Allow Change Band Parent"
            Me.ceAllowChangeBandParent.Size = New System.Drawing.Size(226, 19)
            Me.ceAllowChangeBandParent.StyleController = Me.layoutControl
            Me.ceAllowChangeBandParent.TabIndex = 8
            AddHandler Me.ceAllowChangeBandParent.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowChangeBandParent_CheckedChanged)
            ' 
            ' ceAllowBandResizing
            ' 
            Me.ceAllowBandResizing.Location = New System.Drawing.Point(12, 139)
            Me.ceAllowBandResizing.Name = "ceAllowBandResizing"
            Me.ceAllowBandResizing.Properties.Caption = "Allow Band Resizing"
            Me.ceAllowBandResizing.Size = New System.Drawing.Size(226, 19)
            Me.ceAllowBandResizing.StyleController = Me.layoutControl
            Me.ceAllowBandResizing.TabIndex = 7
            AddHandler Me.ceAllowBandResizing.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowBandResizing_CheckedChanged)
            ' 
            ' ceAllowBandMoving
            ' 
            Me.ceAllowBandMoving.Location = New System.Drawing.Point(12, 116)
            Me.ceAllowBandMoving.Name = "ceAllowBandMoving"
            Me.ceAllowBandMoving.Properties.Caption = "Allow Band Moving"
            Me.ceAllowBandMoving.Size = New System.Drawing.Size(226, 19)
            Me.ceAllowBandMoving.StyleController = Me.layoutControl
            Me.ceAllowBandMoving.TabIndex = 6
            AddHandler Me.ceAllowBandMoving.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowBandMoving_CheckedChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.lgCustomization, Me.lgView})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(250, 340)
            Me.Root.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 308)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(250, 32)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lgCustomization
            ' 
            Me.lgCustomization.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lgCustomization.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.liAllowBandMoving, Me.liAllowBandResizing, Me.liAllowChangeBandParent, Me.liAllowChangeColumnParent, Me.liAllowColumnMoving, Me.liAllowColumnResizing, Me.liShowBandsInCustomizationForm, Me.liCustomizationFormSearchBoxVisible})
            Me.lgCustomization.Location = New System.Drawing.Point(0, 85)
            Me.lgCustomization.Name = "lgCustomization"
            Me.lgCustomization.Size = New System.Drawing.Size(250, 223)
            Me.lgCustomization.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lgCustomization.Text = "Customization"
            ' 
            ' liAllowBandMoving
            ' 
            Me.liAllowBandMoving.Control = Me.ceAllowBandMoving
            Me.liAllowBandMoving.Location = New System.Drawing.Point(0, 0)
            Me.liAllowBandMoving.Name = "liAllowBandMoving"
            Me.liAllowBandMoving.Size = New System.Drawing.Size(230, 23)
            Me.liAllowBandMoving.TextSize = New System.Drawing.Size(0, 0)
            Me.liAllowBandMoving.TextVisible = False
            ' 
            ' liAllowBandResizing
            ' 
            Me.liAllowBandResizing.Control = Me.ceAllowBandResizing
            Me.liAllowBandResizing.Location = New System.Drawing.Point(0, 23)
            Me.liAllowBandResizing.Name = "liAllowBandResizing"
            Me.liAllowBandResizing.Size = New System.Drawing.Size(230, 23)
            Me.liAllowBandResizing.TextSize = New System.Drawing.Size(0, 0)
            Me.liAllowBandResizing.TextVisible = False
            ' 
            ' liAllowChangeBandParent
            ' 
            Me.liAllowChangeBandParent.Control = Me.ceAllowChangeBandParent
            Me.liAllowChangeBandParent.Location = New System.Drawing.Point(0, 46)
            Me.liAllowChangeBandParent.Name = "liAllowChangeBandParent"
            Me.liAllowChangeBandParent.Size = New System.Drawing.Size(230, 23)
            Me.liAllowChangeBandParent.TextSize = New System.Drawing.Size(0, 0)
            Me.liAllowChangeBandParent.TextVisible = False
            ' 
            ' liAllowChangeColumnParent
            ' 
            Me.liAllowChangeColumnParent.Control = Me.ceAllowChangeColumnParent
            Me.liAllowChangeColumnParent.Location = New System.Drawing.Point(0, 69)
            Me.liAllowChangeColumnParent.Name = "liAllowChangeColumnParent"
            Me.liAllowChangeColumnParent.Size = New System.Drawing.Size(230, 23)
            Me.liAllowChangeColumnParent.TextSize = New System.Drawing.Size(0, 0)
            Me.liAllowChangeColumnParent.TextVisible = False
            ' 
            ' liAllowColumnMoving
            ' 
            Me.liAllowColumnMoving.Control = Me.ceAllowColumnMoving
            Me.liAllowColumnMoving.Location = New System.Drawing.Point(0, 92)
            Me.liAllowColumnMoving.Name = "liAllowColumnMoving"
            Me.liAllowColumnMoving.Size = New System.Drawing.Size(230, 23)
            Me.liAllowColumnMoving.TextSize = New System.Drawing.Size(0, 0)
            Me.liAllowColumnMoving.TextVisible = False
            ' 
            ' liAllowColumnResizing
            ' 
            Me.liAllowColumnResizing.Control = Me.ceAllowColumnResizing
            Me.liAllowColumnResizing.Location = New System.Drawing.Point(0, 115)
            Me.liAllowColumnResizing.Name = "liAllowColumnResizing"
            Me.liAllowColumnResizing.Size = New System.Drawing.Size(230, 23)
            Me.liAllowColumnResizing.TextSize = New System.Drawing.Size(0, 0)
            Me.liAllowColumnResizing.TextVisible = False
            ' 
            ' liShowBandsInCustomizationForm
            ' 
            Me.liShowBandsInCustomizationForm.Control = Me.ceShowBandsInCustomizationForm
            Me.liShowBandsInCustomizationForm.Location = New System.Drawing.Point(0, 138)
            Me.liShowBandsInCustomizationForm.Name = "liShowBandsInCustomizationForm"
            Me.liShowBandsInCustomizationForm.Size = New System.Drawing.Size(230, 23)
            Me.liShowBandsInCustomizationForm.TextSize = New System.Drawing.Size(0, 0)
            Me.liShowBandsInCustomizationForm.TextVisible = False
            ' 
            ' liCustomizationFormSearchBoxVisible
            ' 
            Me.liCustomizationFormSearchBoxVisible.Control = Me.ceCustomizationFormSearchBoxVisible
            Me.liCustomizationFormSearchBoxVisible.Location = New System.Drawing.Point(0, 161)
            Me.liCustomizationFormSearchBoxVisible.Name = "liCustomizationFormSearchBoxVisible"
            Me.liCustomizationFormSearchBoxVisible.Size = New System.Drawing.Size(230, 23)
            Me.liCustomizationFormSearchBoxVisible.TextSize = New System.Drawing.Size(0, 0)
            Me.liCustomizationFormSearchBoxVisible.TextVisible = False
            ' 
            ' lgView
            ' 
            Me.lgView.CustomizationFormText = "View"
            Me.lgView.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lgView.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.liShowBands, Me.liAllowBandColumnsMultiRow})
            Me.lgView.Location = New System.Drawing.Point(0, 0)
            Me.lgView.Name = "lgView"
            Me.lgView.Size = New System.Drawing.Size(250, 85)
            Me.lgView.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lgView.Text = "View"
            ' 
            ' liShowBands
            ' 
            Me.liShowBands.Control = Me.ceShowBands
            Me.liShowBands.Location = New System.Drawing.Point(0, 0)
            Me.liShowBands.Name = "liShowBands"
            Me.liShowBands.Size = New System.Drawing.Size(230, 23)
            Me.liShowBands.TextSize = New System.Drawing.Size(0, 0)
            Me.liShowBands.TextVisible = False
            ' 
            ' liAllowBandColumnsMultiRow
            ' 
            Me.liAllowBandColumnsMultiRow.Control = Me.ceAllowBandColumnsMultiRow
            Me.liAllowBandColumnsMultiRow.Location = New System.Drawing.Point(0, 23)
            Me.liAllowBandColumnsMultiRow.Name = "liAllowBandColumnsMultiRow"
            Me.liAllowBandColumnsMultiRow.Size = New System.Drawing.Size(230, 23)
            Me.liAllowBandColumnsMultiRow.TextSize = New System.Drawing.Size(0, 0)
            Me.liAllowBandColumnsMultiRow.TextVisible = False
            ' 
            ' ucBandOptions
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "ucBandOptions"
            Me.Size = New System.Drawing.Size(250, 340)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.ceAllowBandColumnsMultiRow.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowBands.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCustomizationFormSearchBoxVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowBandsInCustomizationForm.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowColumnResizing.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowColumnMoving.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowChangeColumnParent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowChangeBandParent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowBandResizing.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowBandMoving.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lgCustomization), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowBandMoving), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowBandResizing), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowChangeBandParent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowChangeColumnParent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowColumnMoving), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowColumnResizing), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liShowBandsInCustomizationForm), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liCustomizationFormSearchBoxVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lgView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liShowBands), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liAllowBandColumnsMultiRow), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private ceAllowChangeColumnParent As DevExpress.XtraEditors.CheckEdit

        Private ceAllowChangeBandParent As DevExpress.XtraEditors.CheckEdit

        Private ceAllowBandResizing As DevExpress.XtraEditors.CheckEdit

        Private ceAllowBandMoving As DevExpress.XtraEditors.CheckEdit

        Private liAllowBandMoving As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private liAllowBandResizing As DevExpress.XtraLayout.LayoutControlItem

        Private liAllowChangeBandParent As DevExpress.XtraLayout.LayoutControlItem

        Private liAllowChangeColumnParent As DevExpress.XtraLayout.LayoutControlItem

        Private ceAllowColumnMoving As DevExpress.XtraEditors.CheckEdit

        Private liAllowColumnMoving As DevExpress.XtraLayout.LayoutControlItem

        Private ceShowBandsInCustomizationForm As DevExpress.XtraEditors.CheckEdit

        Private ceAllowColumnResizing As DevExpress.XtraEditors.CheckEdit

        Private liAllowColumnResizing As DevExpress.XtraLayout.LayoutControlItem

        Private liShowBandsInCustomizationForm As DevExpress.XtraLayout.LayoutControlItem

        Private ceCustomizationFormSearchBoxVisible As DevExpress.XtraEditors.CheckEdit

        Private liCustomizationFormSearchBoxVisible As DevExpress.XtraLayout.LayoutControlItem

        Private ceShowBands As DevExpress.XtraEditors.CheckEdit

        Private lgCustomization As DevExpress.XtraLayout.LayoutControlGroup

        Private lgView As DevExpress.XtraLayout.LayoutControlGroup

        Private liShowBands As DevExpress.XtraLayout.LayoutControlItem

        Private ceAllowBandColumnsMultiRow As DevExpress.XtraEditors.CheckEdit

        Private liAllowBandColumnsMultiRow As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
