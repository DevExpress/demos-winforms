Namespace DevExpress.XtraDiagram.Demos

    Partial Class FloorPlanModule

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
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(794, 441)
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String(-1) {})
            Me.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.None
            Me.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
            Me.diagramControl.OptionsView.ScrollMargin = New System.Windows.Forms.Padding(150)
            Me.diagramControl.OptionsView.ShowGrid = False
            Me.diagramControl.OptionsView.ShowPageBreaks = False
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Compact
            Me.diagramControl.Size = New System.Drawing.Size(694, 267)
            ' 
            ' FloorPlanModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "FloorPlanModule"
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub
#End Region
    End Class
End Namespace
