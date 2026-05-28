Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos

    Partial Class TipOverTreeLayoutModule

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
            Me.tipOverOffsetModeGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            Me.tipOverDirectionGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            Me.verticalSpacingGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar()
            Me.offsetGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar()
            bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.containerControl.SuspendLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tipOverOffsetModeGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tipOverOffsetModeGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tipOverDirectionGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tipOverDirectionGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.verticalSpacingGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.offsetGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(539, 581)
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
            Me.diagramControl.Size = New System.Drawing.Size(539, 404)
            ' 
            ' bindingSource
            ' 
            bindingSource.DataMember = "OptionsTipOverTreeLayout"
            bindingSource.DataSource = Me.diagramControl
            bindingSource.Position = 0
            ' 
            ' tipOverOffsetModeGroup
            ' 
            Me.tipOverOffsetModeGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.tipOverOffsetModeGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.tipOverOffsetModeGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.tipOverOffsetModeGroup.Location = New System.Drawing.Point(0, 118)
            Me.tipOverOffsetModeGroup.Name = "tipOverOffsetModeGroup"
            Me.tipOverOffsetModeGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.tipOverOffsetModeGroup.RadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "OffsetMode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.tipOverOffsetModeGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Center
            Me.tipOverOffsetModeGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.tipOverOffsetModeGroup.RadioGroup.Name = ""
            Me.tipOverOffsetModeGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Center, "Center"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverOffsetMode.Edge, "Edge")})
            Me.tipOverOffsetModeGroup.RadioGroup.TabIndex = 0
            AddHandler Me.tipOverOffsetModeGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroupSelectedItemChanged)
            Me.tipOverOffsetModeGroup.Size = New System.Drawing.Size(249, 118)
            Me.tipOverOffsetModeGroup.TabIndex = 2
            Me.tipOverOffsetModeGroup.Text = "Tip Over Offset Mode"
            ' 
            ' tipOverDirectionGroup
            ' 
            Me.tipOverDirectionGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.tipOverDirectionGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.tipOverDirectionGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.tipOverDirectionGroup.Location = New System.Drawing.Point(0, 0)
            Me.tipOverDirectionGroup.Name = "tipOverDirectionGroup"
            Me.tipOverDirectionGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.tipOverDirectionGroup.RadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "Direction", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.tipOverDirectionGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.TipOverDirection.LeftToRight
            Me.tipOverDirectionGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.tipOverDirectionGroup.RadioGroup.Name = ""
            Me.tipOverDirectionGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.LeftToRight, "Left to Right"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.TipOverDirection.RightToLeft, "Right to Left")})
            Me.tipOverDirectionGroup.RadioGroup.TabIndex = 0
            AddHandler Me.tipOverDirectionGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RadioGroupSelectedItemChanged)
            Me.tipOverDirectionGroup.Size = New System.Drawing.Size(249, 118)
            Me.tipOverDirectionGroup.TabIndex = 3
            Me.tipOverDirectionGroup.Text = "Tip Over Direction"
            ' 
            ' verticalSpacingGroup
            ' 
            Me.verticalSpacingGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.verticalSpacingGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.verticalSpacingGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.verticalSpacingGroup.Location = New System.Drawing.Point(0, 309)
            Me.verticalSpacingGroup.Name = "verticalSpacingGroup"
            Me.verticalSpacingGroup.Padding = New System.Windows.Forms.Padding(12)
            Me.verticalSpacingGroup.Size = New System.Drawing.Size(249, 73)
            Me.verticalSpacingGroup.TabIndex = 0
            Me.verticalSpacingGroup.Text = "Vertical Spacing"
            Me.verticalSpacingGroup.TrackBarSettings.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "VerticalSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            Me.verticalSpacingGroup.TrackBarSettings.Caption = Nothing
            Me.verticalSpacingGroup.TrackBarSettings.LargeChange = 0
            Me.verticalSpacingGroup.TrackBarSettings.Max = 150
            Me.verticalSpacingGroup.TrackBarSettings.Min = 20
            Me.verticalSpacingGroup.TrackBarSettings.SmallChange = 15
            AddHandler Me.verticalSpacingGroup.TrackBarValueChanged, New System.EventHandler(AddressOf Me.TrackBarValueChanged)
            ' 
            ' offsetGroup
            ' 
            Me.offsetGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.offsetGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.offsetGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.offsetGroup.Location = New System.Drawing.Point(0, 236)
            Me.offsetGroup.Name = "offsetGroup"
            Me.offsetGroup.Padding = New System.Windows.Forms.Padding(12)
            Me.offsetGroup.Size = New System.Drawing.Size(249, 73)
            Me.offsetGroup.TabIndex = 1
            Me.offsetGroup.Text = "Offset"
            Me.offsetGroup.TrackBarSettings.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "Offset", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            Me.offsetGroup.TrackBarSettings.Caption = Nothing
            Me.offsetGroup.TrackBarSettings.LargeChange = 0
            Me.offsetGroup.TrackBarSettings.Max = 150
            Me.offsetGroup.TrackBarSettings.Min = 30
            Me.offsetGroup.TrackBarSettings.SmallChange = 15
            AddHandler Me.offsetGroup.TrackBarValueChanged, New System.EventHandler(AddressOf Me.TrackBarValueChanged)
            ' 
            ' TipOverTreeLayoutModule
            ' 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.Name = "TipOverTreeLayoutModule"
            Me.OptionsPageControls.Add(Me.verticalSpacingGroup)
            Me.OptionsPageControls.Add(Me.offsetGroup)
            Me.OptionsPageControls.Add(Me.tipOverOffsetModeGroup)
            Me.OptionsPageControls.Add(Me.tipOverDirectionGroup)
            Me.containerControl.ResumeLayout(False)
            Me.containerControl.PerformLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tipOverOffsetModeGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tipOverOffsetModeGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tipOverDirectionGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tipOverDirectionGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.verticalSpacingGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.offsetGroup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private verticalSpacingGroup As DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar

        Private tipOverDirectionGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private tipOverOffsetModeGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private offsetGroup As DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar
    End Class
End Namespace
