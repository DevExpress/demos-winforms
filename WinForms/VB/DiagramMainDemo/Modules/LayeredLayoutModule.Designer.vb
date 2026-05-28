Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos

    Partial Class LayeredLayoutModule

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
            bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.containerControl.SuspendLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.directionGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.directionGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spacingGroup), System.ComponentModel.ISupportInitialize).BeginInit()
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
            bindingSource.DataMember = "OptionsSugiyamaLayout"
            bindingSource.DataSource = Me.diagramControl
            bindingSource.Position = 0
            ' 
            ' directionGroup
            ' 
            Me.directionGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.directionGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.directionGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.directionGroup.Location = New System.Drawing.Point(0, 46)
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
            Me.directionGroup.Size = New System.Drawing.Size(249, 118)
            Me.directionGroup.TabIndex = 0
            Me.directionGroup.Text = "Direction"
            ' 
            ' spacingGroup
            ' 
            Me.spacingGroup.CaptionLocation = DevExpress.Utils.Locations.Top
            Me.spacingGroup.Dock = System.Windows.Forms.DockStyle.Top
            Me.spacingGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.spacingGroup.Location = New System.Drawing.Point(0, 0)
            Me.spacingGroup.Name = "spacingGroup"
            Me.spacingGroup.Padding = New System.Windows.Forms.Padding(12)
            Me.spacingGroup.Size = New System.Drawing.Size(249, 46)
            Me.spacingGroup.TabIndex = 1
            Me.spacingGroup.Text = "Spacing"
            trackBarSettings1.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "LayerSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            trackBarSettings1.Caption = "Layer"
            trackBarSettings1.Max = 150
            trackBarSettings1.Min = 30
            trackBarSettings1.SmallChange = 15
            trackBarSettings2.Binding = New System.Windows.Forms.Binding("EditValue", bindingSource, "ColumnSpacing", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
            trackBarSettings2.Caption = "Column"
            trackBarSettings2.Max = 150
            trackBarSettings2.Min = 20
            trackBarSettings2.SmallChange = 15
            Me.spacingGroup.TrackBarsSettings.Add(trackBarSettings1)
            Me.spacingGroup.TrackBarsSettings.Add(trackBarSettings2)
            AddHandler Me.spacingGroup.TrackBarsValueChanged, New System.EventHandler(AddressOf Me.TrackBarValueChanged)
            ' 
            ' LayeredLayoutModule
            ' 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.Name = "LayeredLayoutModule"
            Me.OptionsPageControls.Add(Me.spacingGroup)
            Me.OptionsPageControls.Add(Me.directionGroup)
            Me.containerControl.ResumeLayout(False)
            Me.containerControl.PerformLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.directionGroup.RadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.directionGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spacingGroup), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private directionGroup As DevExpress.XtraDiagram.Demos.GroupControlWithRadioGroup

        Private spacingGroup As DevExpress.XtraDiagram.Demos.GroupControlWithTrackBars
    End Class
End Namespace
