Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos

    Partial Class CircularLayoutModule

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
            Me.startAngleGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar()
            Me.circularOrderGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup()
            Me.nodesSpacingGroup = New DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar()
            bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.containerControl.SuspendLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.startAngleGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularOrderGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularOrderGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nodesSpacingGroup), System.ComponentModel.ISupportInitialize).BeginInit()
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
            bindingSource.DataMember = "OptionsCircularLayout"
            bindingSource.DataSource = Me.diagramControl
            bindingSource.Position = 0
            ' 
            ' startAngleGroup
            ' 
            Me.startAngleGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.startAngleGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.startAngleGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.startAngleGroup.Location = New System.Drawing.Point(0, 118)
            Me.startAngleGroup.Name = "startAngleGroup"
            Me.startAngleGroup.Padding = New System.Windows.Forms.Padding(12)
            Me.startAngleGroup.Size = New System.Drawing.Size(249, 89)
            Me.startAngleGroup.TabIndex = 1
            Me.startAngleGroup.Text = "Start Angle"
            Me.startAngleGroup.TrackBarSettings.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "StartAngle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            Me.startAngleGroup.TrackBarSettings.Caption = Nothing
            Me.startAngleGroup.TrackBarSettings.Max = 360
            Me.startAngleGroup.TrackBarSettings.Min = 0
            Me.startAngleGroup.TrackBarSettings.SmallChange = 15
            AddHandler Me.startAngleGroup.TrackBarValueChanged, New System.EventHandler(AddressOf Me.TrackBarValueChanged)
            ' 
            ' circularOrderGroup
            ' 
            Me.circularOrderGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.circularOrderGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.circularOrderGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.circularOrderGroup.Location = New System.Drawing.Point(0, 0)
            Me.circularOrderGroup.Name = "circularOrderGroup"
            Me.circularOrderGroup.Padding = New System.Windows.Forms.Padding(12)
            ' 
            ' 
            ' 
            Me.circularOrderGroup.RadioGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", bindingSource, "Order", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.circularOrderGroup.RadioGroup.EditValue = DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Optimal
            Me.circularOrderGroup.RadioGroup.Location = New System.Drawing.Point(0, 0)
            Me.circularOrderGroup.RadioGroup.Name = ""
            Me.circularOrderGroup.RadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Optimal, "Optimal"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Clockwise, "Clockwise"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.Diagram.Core.Layout.CircularLayoutOrder.Counterclockwise, "Counterclockwise")})
            Me.circularOrderGroup.RadioGroup.TabIndex = 0
            AddHandler Me.circularOrderGroup.RadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.CircularOrderGroupSelectedItemChanged)
            Me.circularOrderGroup.Size = New System.Drawing.Size(249, 118)
            Me.circularOrderGroup.TabIndex = 0
            Me.circularOrderGroup.Text = "Circular Order"
            ' 
            ' nodesSpacingGroup
            ' 
            Me.nodesSpacingGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.nodesSpacingGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.nodesSpacingGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.nodesSpacingGroup.Location = New System.Drawing.Point(0, 207)
            Me.nodesSpacingGroup.Name = "nodesSpacingGroup"
            Me.nodesSpacingGroup.Padding = New System.Windows.Forms.Padding(12)
            Me.nodesSpacingGroup.Size = New System.Drawing.Size(249, 89)
            Me.nodesSpacingGroup.TabIndex = 2
            Me.nodesSpacingGroup.Text = "Nodes Spacing"
            Me.nodesSpacingGroup.TrackBarSettings.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "NodesSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            Me.nodesSpacingGroup.TrackBarSettings.Caption = Nothing
            Me.nodesSpacingGroup.TrackBarSettings.Max = 150
            Me.nodesSpacingGroup.TrackBarSettings.Min = 0
            Me.nodesSpacingGroup.TrackBarSettings.SmallChange = 15
            AddHandler Me.nodesSpacingGroup.TrackBarValueChanged, New System.EventHandler(AddressOf Me.TrackBarValueChanged)
            ' 
            ' CircularLayoutModule
            ' 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.Name = "CircularLayoutModule"
            Me.OptionsPageControls.Add(Me.nodesSpacingGroup)
            Me.OptionsPageControls.Add(Me.startAngleGroup)
            Me.OptionsPageControls.Add(Me.circularOrderGroup)
            Me.containerControl.ResumeLayout(False)
            Me.containerControl.PerformLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.startAngleGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularOrderGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularOrderGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nodesSpacingGroup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private startAngleGroup As DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar

        Private circularOrderGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private nodesSpacingGroup As DevExpress.XtraDiagram.Demos.GroupControlWithTrackBar
    End Class
End Namespace
