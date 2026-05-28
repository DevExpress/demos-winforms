Namespace DevExpress.XtraCharts.Demos

    Partial Class AnimationDemo

        Private components As System.ComponentModel.IContainer = Nothing

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
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.simpleButtonAnimate = New DevExpress.XtraEditors.SimpleButton()
            Me.checkEditSeriesLabelsVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditSeriesAnimation = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditPointAnimation = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditSeriesView = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.checkEditDiagramRotated = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditAxisXReversed = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditAxisYReversed = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemSeriesView = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemShowSeriesLabels = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupAnimation = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemAnimate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemPointAnimation = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemSeriesAnimation = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupDiagramOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemDiagramRotated = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAxisYReversed = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAxisXReversed = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.checkEditSeriesLabelsVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditSeriesAnimation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditPointAnimation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditSeriesView.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditDiagramRotated.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAxisXReversed.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAxisYReversed.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSeriesView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemShowSeriesLabels), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupAnimation), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAnimate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPointAnimation), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSeriesAnimation), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupDiagramOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemDiagramRotated), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAxisYReversed), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAxisXReversed), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 542)
            ' 
            ' chart
            ' 
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 3
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.simpleButtonAnimate)
            Me.layoutControl.Controls.Add(Me.checkEditSeriesLabelsVisible)
            Me.layoutControl.Controls.Add(Me.comboBoxEditSeriesAnimation)
            Me.layoutControl.Controls.Add(Me.comboBoxEditPointAnimation)
            Me.layoutControl.Controls.Add(Me.comboBoxEditSeriesView)
            Me.layoutControl.Controls.Add(Me.checkEditDiagramRotated)
            Me.layoutControl.Controls.Add(Me.checkEditAxisXReversed)
            Me.layoutControl.Controls.Add(Me.checkEditAxisYReversed)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(268, 270, 650, 398)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 542)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' simpleButtonAnimate
            ' 
            Me.simpleButtonAnimate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.simpleButtonAnimate.Location = New System.Drawing.Point(12, 188)
            Me.simpleButtonAnimate.Name = "simpleButtonAnimate"
            Me.simpleButtonAnimate.Size = New System.Drawing.Size(217, 22)
            Me.simpleButtonAnimate.StyleController = Me.layoutControl
            Me.simpleButtonAnimate.TabIndex = 23
            Me.simpleButtonAnimate.Text = "Animate"
            AddHandler Me.simpleButtonAnimate.Click, New System.EventHandler(AddressOf Me.simpleButtonAnimate_Click)
            ' 
            ' checkEditSeriesLabelsVisible
            ' 
            Me.checkEditSeriesLabelsVisible.Location = New System.Drawing.Point(12, 66)
            Me.checkEditSeriesLabelsVisible.Name = "checkEditSeriesLabelsVisible"
            Me.checkEditSeriesLabelsVisible.Properties.Caption = "Series Labels Visible"
            Me.checkEditSeriesLabelsVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditSeriesLabelsVisible.StyleController = Me.layoutControl
            Me.checkEditSeriesLabelsVisible.TabIndex = 22
            AddHandler Me.checkEditSeriesLabelsVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditSeriesLabelsVisible_CheckedChanged)
            ' 
            ' comboBoxEditSeriesAnimation
            ' 
            Me.comboBoxEditSeriesAnimation.Location = New System.Drawing.Point(98, 132)
            Me.comboBoxEditSeriesAnimation.Name = "comboBoxEditSeriesAnimation"
            Me.comboBoxEditSeriesAnimation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditSeriesAnimation.Properties.DropDownRows = 8
            Me.comboBoxEditSeriesAnimation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditSeriesAnimation.Size = New System.Drawing.Size(131, 20)
            Me.comboBoxEditSeriesAnimation.StyleController = Me.layoutControl
            Me.comboBoxEditSeriesAnimation.TabIndex = 21
            AddHandler Me.comboBoxEditSeriesAnimation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditSeriesAnimation_SelectedValueChanged)
            ' 
            ' comboBoxEditPointAnimation
            ' 
            Me.comboBoxEditPointAnimation.Location = New System.Drawing.Point(98, 156)
            Me.comboBoxEditPointAnimation.Name = "comboBoxEditPointAnimation"
            Me.comboBoxEditPointAnimation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditPointAnimation.Properties.DropDownRows = 8
            Me.comboBoxEditPointAnimation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditPointAnimation.Size = New System.Drawing.Size(131, 20)
            Me.comboBoxEditPointAnimation.StyleController = Me.layoutControl
            Me.comboBoxEditPointAnimation.TabIndex = 20
            AddHandler Me.comboBoxEditPointAnimation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditPointAnimation_SelectedIndexChanged)
            ' 
            ' comboBoxEditSeriesView
            ' 
            Me.comboBoxEditSeriesView.Location = New System.Drawing.Point(98, 34)
            Me.comboBoxEditSeriesView.Name = "comboBoxEditSeriesView"
            Me.comboBoxEditSeriesView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditSeriesView.Properties.DropDownRows = 16
            Me.comboBoxEditSeriesView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditSeriesView.Size = New System.Drawing.Size(131, 20)
            Me.comboBoxEditSeriesView.StyleController = Me.layoutControl
            Me.comboBoxEditSeriesView.TabIndex = 19
            AddHandler Me.comboBoxEditSeriesView.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditSeriesView_SelectedIndexChanged)
            ' 
            ' checkEditDiagramRotated
            ' 
            Me.checkEditDiagramRotated.Location = New System.Drawing.Point(12, 256)
            Me.checkEditDiagramRotated.Name = "checkEditDiagramRotated"
            Me.checkEditDiagramRotated.Properties.Caption = "Diagram Rotated"
            Me.checkEditDiagramRotated.Size = New System.Drawing.Size(217, 20)
            Me.checkEditDiagramRotated.StyleController = Me.layoutControl
            Me.checkEditDiagramRotated.TabIndex = 24
            AddHandler Me.checkEditDiagramRotated.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditDiagramRotated_CheckedChanged)
            ' 
            ' checkEditAxisXReversed
            ' 
            Me.checkEditAxisXReversed.Location = New System.Drawing.Point(12, 280)
            Me.checkEditAxisXReversed.Name = "checkEditAxisXReversed"
            Me.checkEditAxisXReversed.Properties.Caption = "Axis X Reversed"
            Me.checkEditAxisXReversed.Size = New System.Drawing.Size(217, 20)
            Me.checkEditAxisXReversed.StyleController = Me.layoutControl
            Me.checkEditAxisXReversed.TabIndex = 25
            AddHandler Me.checkEditAxisXReversed.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditAxisXReversed_CheckedChanged)
            ' 
            ' checkEditAxisYReversed
            ' 
            Me.checkEditAxisYReversed.Location = New System.Drawing.Point(12, 304)
            Me.checkEditAxisYReversed.Name = "checkEditAxisYReversed"
            Me.checkEditAxisYReversed.Properties.Caption = "Axis Y Reversed"
            Me.checkEditAxisYReversed.Size = New System.Drawing.Size(217, 20)
            Me.checkEditAxisYReversed.StyleController = Me.layoutControl
            Me.checkEditAxisYReversed.TabIndex = 26
            AddHandler Me.checkEditAxisYReversed.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditAxisYReversed_CheckedChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem, Me.layoutControlGroupGeneral, Me.layoutControlGroupAnimation, Me.layoutControlGroupDiagramOptions})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 542)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 336)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 206)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemSeriesView, Me.layoutControlItemShowSeriesLabels})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 98)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItemSeriesView
            ' 
            Me.layoutControlItemSeriesView.Control = Me.comboBoxEditSeriesView
            Me.layoutControlItemSeriesView.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemSeriesView.Name = "layoutControlItemSeriesView"
            Me.layoutControlItemSeriesView.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemSeriesView.Text = "Series View:"
            Me.layoutControlItemSeriesView.TextSize = New System.Drawing.Size(83, 13)
            ' 
            ' layoutControlItemShowSeriesLabels
            ' 
            Me.layoutControlItemShowSeriesLabels.Control = Me.checkEditSeriesLabelsVisible
            Me.layoutControlItemShowSeriesLabels.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemShowSeriesLabels.Name = "layoutControlItemShowSeriesLabels"
            Me.layoutControlItemShowSeriesLabels.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItemShowSeriesLabels.Size = New System.Drawing.Size(221, 32)
            Me.layoutControlItemShowSeriesLabels.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemShowSeriesLabels.TextVisible = False
            ' 
            ' layoutControlGroupAnimation
            ' 
            Me.layoutControlGroupAnimation.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupAnimation.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemAnimate, Me.layoutControlItemPointAnimation, Me.layoutControlItemSeriesAnimation})
            Me.layoutControlGroupAnimation.Location = New System.Drawing.Point(0, 98)
            Me.layoutControlGroupAnimation.Name = "layoutControlGroupAnimation"
            Me.layoutControlGroupAnimation.Size = New System.Drawing.Size(241, 124)
            Me.layoutControlGroupAnimation.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupAnimation.Text = "Animation"
            ' 
            ' layoutControlItemAnimate
            ' 
            Me.layoutControlItemAnimate.Control = Me.simpleButtonAnimate
            Me.layoutControlItemAnimate.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemAnimate.Name = "layoutControlItemAnimate"
            Me.layoutControlItemAnimate.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItemAnimate.Size = New System.Drawing.Size(221, 34)
            Me.layoutControlItemAnimate.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemAnimate.TextVisible = False
            ' 
            ' layoutControlItemPointAnimation
            ' 
            Me.layoutControlItemPointAnimation.Control = Me.comboBoxEditPointAnimation
            Me.layoutControlItemPointAnimation.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemPointAnimation.Name = "layoutControlItemPointAnimation"
            Me.layoutControlItemPointAnimation.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemPointAnimation.Text = "Point Animation:"
            Me.layoutControlItemPointAnimation.TextSize = New System.Drawing.Size(83, 13)
            ' 
            ' layoutControlItemSeriesAnimation
            ' 
            Me.layoutControlItemSeriesAnimation.Control = Me.comboBoxEditSeriesAnimation
            Me.layoutControlItemSeriesAnimation.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemSeriesAnimation.Name = "layoutControlItemSeriesAnimation"
            Me.layoutControlItemSeriesAnimation.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemSeriesAnimation.Text = "Series Animation:"
            Me.layoutControlItemSeriesAnimation.TextSize = New System.Drawing.Size(83, 13)
            ' 
            ' layoutControlGroupDiagramOptions
            ' 
            Me.layoutControlGroupDiagramOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupDiagramOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemDiagramRotated, Me.layoutControlItemAxisYReversed, Me.layoutControlItemAxisXReversed})
            Me.layoutControlGroupDiagramOptions.Location = New System.Drawing.Point(0, 222)
            Me.layoutControlGroupDiagramOptions.Name = "layoutControlGroupDiagramOptions"
            Me.layoutControlGroupDiagramOptions.Size = New System.Drawing.Size(241, 114)
            Me.layoutControlGroupDiagramOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupDiagramOptions.Text = "Diagram Options"
            ' 
            ' layoutControlItemDiagramRotated
            ' 
            Me.layoutControlItemDiagramRotated.Control = Me.checkEditDiagramRotated
            Me.layoutControlItemDiagramRotated.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemDiagramRotated.Name = "layoutControlItemDiagramRotated"
            Me.layoutControlItemDiagramRotated.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemDiagramRotated.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemDiagramRotated.TextVisible = False
            ' 
            ' layoutControlItemAxisYReversed
            ' 
            Me.layoutControlItemAxisYReversed.Control = Me.checkEditAxisYReversed
            Me.layoutControlItemAxisYReversed.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemAxisYReversed.Name = "layoutControlItemAxisYReversed"
            Me.layoutControlItemAxisYReversed.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemAxisYReversed.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemAxisYReversed.TextVisible = False
            ' 
            ' layoutControlItemAxisXReversed
            ' 
            Me.layoutControlItemAxisXReversed.Control = Me.checkEditAxisXReversed
            Me.layoutControlItemAxisXReversed.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemAxisXReversed.Name = "layoutControlItemAxisXReversed"
            Me.layoutControlItemAxisXReversed.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemAxisXReversed.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemAxisXReversed.TextVisible = False
            ' 
            ' AnimationDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "AnimationDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.checkEditSeriesLabelsVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditSeriesAnimation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditPointAnimation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditSeriesView.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditDiagramRotated.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAxisXReversed.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAxisYReversed.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSeriesView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemShowSeriesLabels), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupAnimation), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAnimate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPointAnimation), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSeriesAnimation), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupDiagramOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemDiagramRotated), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAxisYReversed), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAxisXReversed), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private comboBoxEditSeriesView As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemSeriesView As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private comboBoxEditPointAnimation As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemPointAnimation As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditSeriesAnimation As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemSeriesAnimation As DevExpress.XtraLayout.LayoutControlItem

        Private checkEditSeriesLabelsVisible As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItemShowSeriesLabels As DevExpress.XtraLayout.LayoutControlItem

        Private simpleButtonAnimate As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItemAnimate As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupAnimation As DevExpress.XtraLayout.LayoutControlGroup

        Private checkEditDiagramRotated As DevExpress.XtraEditors.CheckEdit

        Private checkEditAxisXReversed As DevExpress.XtraEditors.CheckEdit

        Private checkEditAxisYReversed As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupDiagramOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemDiagramRotated As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAxisYReversed As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAxisXReversed As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
