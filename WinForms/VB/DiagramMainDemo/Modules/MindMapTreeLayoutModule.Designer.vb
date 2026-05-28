Imports System.Windows.Forms

Namespace DevExpress.XtraDiagram.Demos

    Partial Class MindMapTreeLayoutModule

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
            Dim trackBarSettings3 As DevExpress.XtraDiagram.Demos.TrackBarSettings = New DevExpress.XtraDiagram.Demos.TrackBarSettings()
            Me.addChildGroup = New DevExpress.XtraDiagram.Demos.OptionsPanelGroupControl()
            Me.addChildButton = New DevExpress.XtraEditors.SimpleButton()
            Me.orientationGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            Me.subTreeAlignmentGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            Me.spacingGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithTrackBars()
            Me.subTreeDefaultSplitModeGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.containerControl.SuspendLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.addChildGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.addChildGroup.SuspendLayout()
            CType((Me.orientationGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.orientationGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.subTreeAlignmentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.subTreeAlignmentGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spacingGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.subTreeDefaultSplitModeGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.subTreeDefaultSplitModeGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
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
            bindingSource.DataMember = "OptionsMindMapTreeLayout"
            bindingSource.DataSource = Me.diagramControl
            bindingSource.Position = 0
            ' 
            ' addChildGroup
            ' 
            Me.addChildGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.addChildGroup.Controls.Add(Me.addChildButton)
            Me.addChildGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.addChildGroup.Location = New System.Drawing.Point(0, 634)
            Me.addChildGroup.Name = "addChildGroup"
            Me.addChildGroup.Padding = New System.Windows.Forms.Padding(12, 0, 12, 12)
            Me.addChildGroup.Size = New System.Drawing.Size(232, 35)
            Me.addChildGroup.TabIndex = 0
            ' 
            ' addChildButton
            ' 
            Me.addChildButton.Dock = System.Windows.Forms.DockStyle.Fill
            Me.addChildButton.Enabled = False
            Me.addChildButton.Location = New System.Drawing.Point(12, 0)
            Me.addChildButton.Name = "addChildButton"
            Me.addChildButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.addChildButton.Size = New System.Drawing.Size(208, 23)
            Me.addChildButton.TabIndex = 9
            Me.addChildButton.Text = "Add Child"
            AddHandler Me.addChildButton.Click, New System.EventHandler(AddressOf Me.AddChild)
            ' 
            ' orientationGroup
            ' 
            Me.orientationGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.orientationGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.orientationGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.orientationGroup.Location = New System.Drawing.Point(0, 0)
            Me.orientationGroup.Name = "orientationGroup"
            Me.orientationGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.orientationGroup.RadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "Orientation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.orientationGroup.RadioGroup.EditValue = System.Windows.Forms.Orientation.Horizontal
            Me.orientationGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.orientationGroup.RadioGroup.Name = ""
            Me.orientationGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(System.Windows.Forms.Orientation.Horizontal, "Horizontal"), New DevExpress.XtraEditors.Controls.RadioGroupItem(System.Windows.Forms.Orientation.Vertical, "Vertical")})
            Me.orientationGroup.RadioGroup.TabIndex = 0
            AddHandler Me.orientationGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroupSelectedItemChanged)
            Me.orientationGroup.Size = New System.Drawing.Size(232, 142)
            Me.orientationGroup.TabIndex = 4
            Me.orientationGroup.Text = "Orientation"
            ' 
            ' subTreeAlignmentGroup
            ' 
            Me.subTreeAlignmentGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.subTreeAlignmentGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.subTreeAlignmentGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.subTreeAlignmentGroup.Location = New System.Drawing.Point(0, 142)
            Me.subTreeAlignmentGroup.Name = "subTreeAlignmentGroup"
            Me.subTreeAlignmentGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.subTreeAlignmentGroup.RadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "SubTreeAlignment", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.subTreeAlignmentGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Alignment.Center
            Me.subTreeAlignmentGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.subTreeAlignmentGroup.RadioGroup.Name = ""
            Me.subTreeAlignmentGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Near, "Near"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Center, "Center"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Alignment.Far, "Far")})
            Me.subTreeAlignmentGroup.RadioGroup.TabIndex = 0
            AddHandler Me.subTreeAlignmentGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroupSelectedItemChanged)
            Me.subTreeAlignmentGroup.Size = New System.Drawing.Size(232, 142)
            Me.subTreeAlignmentGroup.TabIndex = 3
            Me.subTreeAlignmentGroup.Text = "Sub Tree Alignment"
            ' 
            ' spacingGroup
            ' 
            Me.spacingGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.spacingGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.spacingGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.spacingGroup.Location = New System.Drawing.Point(0, 426)
            Me.spacingGroup.Name = "spacingGroup"
            Me.spacingGroup.Padding = New System.Windows.Forms.Padding(12)
            Me.spacingGroup.Size = New System.Drawing.Size(232, 208)
            Me.spacingGroup.TabIndex = 1
            Me.spacingGroup.Text = "Spacing"
            trackBarSettings1.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "HierarchySpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            trackBarSettings1.Caption = "Hierarchy"
            trackBarSettings1.LargeChange = 30
            trackBarSettings1.Max = 300
            trackBarSettings1.Min = 80
            trackBarSettings1.SmallChange = 10
            trackBarSettings2.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "NodeSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            trackBarSettings2.Caption = "Node"
            trackBarSettings2.LargeChange = 15
            trackBarSettings2.Max = 150
            trackBarSettings2.Min = 10
            trackBarSettings2.SmallChange = 5
            trackBarSettings3.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "RootSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            trackBarSettings3.Caption = "Root"
            trackBarSettings3.LargeChange = 30
            trackBarSettings3.Max = 300
            trackBarSettings3.Min = 80
            trackBarSettings3.SmallChange = 10
            Me.spacingGroup.TrackBarsSettings.Add(trackBarSettings1)
            Me.spacingGroup.TrackBarsSettings.Add(trackBarSettings2)
            Me.spacingGroup.TrackBarsSettings.Add(trackBarSettings3)
            AddHandler Me.spacingGroup.TrackBarsValueChanged, New System.EventHandler(AddressOf Me.TrackBarValueChanged)
            ' 
            ' subTreeDefaultSplitModeGroup
            ' 
            Me.subTreeDefaultSplitModeGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.subTreeDefaultSplitModeGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.subTreeDefaultSplitModeGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.subTreeDefaultSplitModeGroup.Location = New System.Drawing.Point(0, 284)
            Me.subTreeDefaultSplitModeGroup.Name = "subTreeDefaultSplitModeGroup"
            Me.subTreeDefaultSplitModeGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.subTreeDefaultSplitModeGroup.RadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "SubTreeDefaultSplitMode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.subTreeDefaultSplitModeGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode.RootChildrenCount
            Me.subTreeDefaultSplitModeGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.subTreeDefaultSplitModeGroup.RadioGroup.Name = ""
            Me.subTreeDefaultSplitModeGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode.RootChildrenCount, "Root Children Count"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode.TreeNodesCount, "Tree Nodes Count"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode.Breadth, "Breadth"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.SubTreeDefaultSplitMode.Area, "Area")})
            Me.subTreeDefaultSplitModeGroup.RadioGroup.TabIndex = 0
            AddHandler Me.subTreeDefaultSplitModeGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroupSelectedItemChanged)
            Me.subTreeDefaultSplitModeGroup.Size = New System.Drawing.Size(232, 142)
            Me.subTreeDefaultSplitModeGroup.TabIndex = 2
            Me.subTreeDefaultSplitModeGroup.Text = "Sub Tree Default Split Mode"
            ' 
            ' MindMapTreeLayoutModule
            ' 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.Name = "MindMapTreeLayoutModule"
            Me.OptionsPageControls.Add(Me.addChildGroup)
            Me.OptionsPageControls.Add(Me.spacingGroup)
            Me.OptionsPageControls.Add(Me.subTreeDefaultSplitModeGroup)
            Me.OptionsPageControls.Add(Me.subTreeAlignmentGroup)
            Me.OptionsPageControls.Add(Me.orientationGroup)
            Me.Size = New System.Drawing.Size(793, 581)
            Me.containerControl.ResumeLayout(False)
            Me.containerControl.PerformLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.addChildGroup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.addChildGroup.ResumeLayout(False)
            CType((Me.orientationGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.orientationGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.subTreeAlignmentGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.subTreeAlignmentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spacingGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.subTreeDefaultSplitModeGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.subTreeDefaultSplitModeGroup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private addChildGroup As DevExpress.XtraDiagram.Demos.OptionsPanelGroupControl

        Private orientationGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private subTreeAlignmentGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private spacingGroup As DevExpress.XtraDiagram.Demos.GroupControlWithTrackBars

        Private subTreeDefaultSplitModeGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private addChildButton As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
