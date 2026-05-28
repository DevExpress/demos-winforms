Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Core.Layout
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraDiagram.Demos

    Partial Class OrgChartLayoutModule

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
            Dim bindingSource As System.Windows.Forms.BindingSource
            Dim trackBarSettings1 As DevExpress.XtraDiagram.Demos.TrackBarSettings = New DevExpress.XtraDiagram.Demos.TrackBarSettings()
            Dim trackBarSettings2 As DevExpress.XtraDiagram.Demos.TrackBarSettings = New DevExpress.XtraDiagram.Demos.TrackBarSettings()
            Me.directionGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            Me.spacingGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithTrackBars()
            Me.alignmentGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            Me.tipOverOffsetModeGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            Me.tipOverDirectionGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            Me.spinEditGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithSpinEdit()
            bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.containerControl.SuspendLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.directionGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.directionGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spacingGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.alignmentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.alignmentGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tipOverOffsetModeGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tipOverOffsetModeGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tipOverDirectionGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tipOverDirectionGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditGroup.SpinEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(543, 581)
            Me.containerControl.Controls.SetChildIndex(Me.diagramControl, 0)
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.Location = New System.Drawing.Point(0, 150)
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.None
            Me.diagramControl.OptionsView.PageSize = New System.Drawing.SizeF(800F, 600F)
            Me.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed
            Me.diagramControl.Size = New System.Drawing.Size(543, 404)
            ' 
            ' bindingSource
            ' 
            bindingSource.DataMember = "OptionsOrgChartLayout"
            bindingSource.DataSource = Me.diagramControl
            bindingSource.Position = 0
            ' 
            ' directionGroup
            ' 
            Me.directionGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.directionGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.directionGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.directionGroup.Location = New System.Drawing.Point(0, 0)
            Me.directionGroup.Name = "directionGroup"
            Me.directionGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.directionGroup.RadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "Direction", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.directionGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.LayoutDirection.TopToBottom
            Me.directionGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.directionGroup.RadioGroup.Name = ""
            Me.directionGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.TopToBottom, "Top to Bottom"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.BottomToTop, "Bottom to Top"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.LeftToRight, "Left to Right"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.LayoutDirection.RightToLeft, "Right to Left")})
            Me.directionGroup.RadioGroup.TabIndex = 0
            AddHandler Me.directionGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroupSelectedItemChanged)
            Me.directionGroup.Size = New System.Drawing.Size(232, 118)
            Me.directionGroup.TabIndex = 5
            Me.directionGroup.Text = "Direction"
            ' 
            ' spacingGroup
            ' 
            Me.spacingGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.spacingGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.spacingGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.spacingGroup.Location = New System.Drawing.Point(0, 514)
            Me.spacingGroup.Name = "spacingGroup"
            Me.spacingGroup.Padding = New System.Windows.Forms.Padding(12)
            Me.spacingGroup.Size = New System.Drawing.Size(232, 46)
            Me.spacingGroup.TabIndex = 0
            Me.spacingGroup.Text = "Spacing"
            trackBarSettings1.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "HierarchySpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            trackBarSettings1.Caption = "Hierarchy"
            trackBarSettings1.LargeChange = 0
            trackBarSettings1.Max = 150
            trackBarSettings1.Min = 20
            trackBarSettings1.SmallChange = 15
            trackBarSettings2.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "NodeSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            trackBarSettings2.Caption = "Nodes"
            trackBarSettings2.LargeChange = 0
            trackBarSettings2.Max = 150
            trackBarSettings2.Min = 20
            trackBarSettings2.SmallChange = 15
            Me.spacingGroup.TrackBarsSettings.Add(trackBarSettings1)
            Me.spacingGroup.TrackBarsSettings.Add(trackBarSettings2)
            AddHandler Me.spacingGroup.TrackBarsValueChanged, New System.EventHandler(AddressOf Me.TrackBarValueChanged)
            ' 
            ' alignmentGroup
            ' 
            Me.alignmentGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.alignmentGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.alignmentGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.alignmentGroup.Location = New System.Drawing.Point(0, 354)
            Me.alignmentGroup.Name = "alignmentGroup"
            Me.alignmentGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.alignmentGroup.RadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "TreeAlignment", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.alignmentGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Alignment.Center
            Me.alignmentGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.alignmentGroup.RadioGroup.Name = ""
            Me.alignmentGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Near, "Near"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Center, "Center"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Far, "Far")})
            Me.alignmentGroup.RadioGroup.TabIndex = 0
            AddHandler Me.alignmentGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroupSelectedItemChanged)
            Me.alignmentGroup.Size = New System.Drawing.Size(232, 118)
            Me.alignmentGroup.TabIndex = 2
            Me.alignmentGroup.Text = "Tree Alignment"
            ' 
            ' tipOverOffsetModeGroup
            ' 
            Me.tipOverOffsetModeGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.tipOverOffsetModeGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.tipOverOffsetModeGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.tipOverOffsetModeGroup.Location = New System.Drawing.Point(0, 236)
            Me.tipOverOffsetModeGroup.Name = "tipOverOffsetModeGroup"
            Me.tipOverOffsetModeGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.tipOverOffsetModeGroup.RadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "TipOverOffsetMode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.tipOverOffsetModeGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Center
            Me.tipOverOffsetModeGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.tipOverOffsetModeGroup.RadioGroup.Name = ""
            Me.tipOverOffsetModeGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Center, "Center"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Edge, "Edge")})
            Me.tipOverOffsetModeGroup.RadioGroup.TabIndex = 0
            AddHandler Me.tipOverOffsetModeGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroupSelectedItemChanged)
            Me.tipOverOffsetModeGroup.Size = New System.Drawing.Size(232, 118)
            Me.tipOverOffsetModeGroup.TabIndex = 3
            Me.tipOverOffsetModeGroup.Text = "Tip Over Offset Mode"
            ' 
            ' tipOverDirectionGroup
            ' 
            Me.tipOverDirectionGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.tipOverDirectionGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.tipOverDirectionGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.tipOverDirectionGroup.Location = New System.Drawing.Point(0, 118)
            Me.tipOverDirectionGroup.Name = "tipOverDirectionGroup"
            Me.tipOverDirectionGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.tipOverDirectionGroup.RadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "TipOverDirection", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.tipOverDirectionGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.TipOverDirection.LeftToRight
            Me.tipOverDirectionGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.tipOverDirectionGroup.RadioGroup.Name = ""
            Me.tipOverDirectionGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.LeftToRight, "Left to Right"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.RightToLeft, "Right to Left")})
            Me.tipOverDirectionGroup.RadioGroup.TabIndex = 0
            AddHandler Me.tipOverDirectionGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroupSelectedItemChanged)
            Me.tipOverDirectionGroup.Size = New System.Drawing.Size(232, 118)
            Me.tipOverDirectionGroup.TabIndex = 4
            Me.tipOverDirectionGroup.Text = "Tip Over Direction"
            ' 
            ' spinEditGroup
            ' 
            Me.spinEditGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.spinEditGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.spinEditGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.spinEditGroup.Location = New System.Drawing.Point(0, 472)
            Me.spinEditGroup.Name = "spinEditGroup"
            Me.spinEditGroup.Padding = New System.Windows.Forms.Padding(12)
            Me.spinEditGroup.Size = New System.Drawing.Size(232, 42)
            ' 
            ' 
            ' 
            Me.spinEditGroup.SpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "TreeLevelCount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinEditGroup.SpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditGroup.SpinEdit.Location = New System.Drawing.Point(0, 0)
            Me.spinEditGroup.SpinEdit.Name = ""
            Me.spinEditGroup.SpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditGroup.SpinEdit.Properties.IsFloatValue = False
            Me.spinEditGroup.SpinEdit.Properties.Mask.EditMask = "N00"
            Me.spinEditGroup.SpinEdit.TabIndex = 0
            AddHandler Me.spinEditGroup.SpinEdit.ValueChanged, New System.EventHandler(AddressOf Me.TrackBarValueChanged)
            Me.spinEditGroup.TabIndex = 1
            Me.spinEditGroup.Text = "Tree Level Count"
            ' 
            ' OrgChartLayoutModule
            ' 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.Name = "OrgChartLayoutModule"
            Me.OptionsPageControls.Add(Me.spacingGroup)
            Me.OptionsPageControls.Add(Me.spinEditGroup)
            Me.OptionsPageControls.Add(Me.alignmentGroup)
            Me.OptionsPageControls.Add(Me.tipOverOffsetModeGroup)
            Me.OptionsPageControls.Add(Me.tipOverDirectionGroup)
            Me.OptionsPageControls.Add(Me.directionGroup)
            Me.Size = New System.Drawing.Size(793, 581)
            Me.containerControl.ResumeLayout(False)
            Me.containerControl.PerformLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.directionGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.directionGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spacingGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.alignmentGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.alignmentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tipOverOffsetModeGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tipOverOffsetModeGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tipOverDirectionGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tipOverDirectionGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditGroup.SpinEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditGroup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private directionGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private spacingGroup As DevExpress.XtraDiagram.Demos.GroupControlWithTrackBars

        Private alignmentGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private tipOverOffsetModeGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private tipOverDirectionGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private spinEditGroup As DevExpress.XtraDiagram.Demos.GroupControlWithSpinEdit
    End Class
End Namespace
