Imports DevExpress.Data.Filtering
Imports DevExpress.Diagram.Demos
Imports System

Namespace DevExpress.XtraDiagram.Demos

    Partial Class DatabaseDiagram

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
            Me.diagramDataBindingController1 = New DevExpress.XtraDiagram.DiagramDataBindingController(Me.components)
            Me.diagramConnector1 = New DevExpress.XtraDiagram.DiagramConnector()
            Me.containerControl.SuspendLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.diagramDataBindingController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.diagramDataBindingController1.TemplateDiagram), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' containerControl
            ' 
            Me.containerControl.Size = New System.Drawing.Size(794, 441)
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.OptionsBehavior.PointerToolDragMode = DevExpress.Diagram.Core.PointerToolDragMode.Pan
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"BasicShapes", "BasicFlowchartShapes"})
            Me.diagramControl.OptionsProtection.AllowCollapseContainers = True
            Me.diagramControl.OptionsProtection.IsReadOnly = True
            Me.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
            Me.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.OptionsView.ShowGrid = False
            Me.diagramControl.OptionsView.ShowPageBreaks = False
            Me.diagramControl.OptionsView.ShowRulers = False
            Me.diagramControl.OptionsView.ToolboxVisibility = DevExpress.Diagram.Core.ToolboxVisibility.Closed
            Me.diagramControl.Size = New System.Drawing.Size(794, 441)
            ' 
            ' diagramDataBindingController1
            ' 
            Me.diagramDataBindingController1.ConnectorsSource = Nothing
            Me.diagramDataBindingController1.Diagram = Me.diagramControl
            ' 
            ' 
            ' 
            Me.diagramDataBindingController1.TemplateDiagram.Items.AddRange(New DevExpress.XtraDiagram.DiagramItem() {Me.diagramConnector1})
            Me.diagramDataBindingController1.TemplateDiagram.Location = New System.Drawing.Point(0, 0)
            Me.diagramDataBindingController1.TemplateDiagram.Name = ""
            Me.diagramDataBindingController1.TemplateDiagram.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String() {"TemplateDesigner", "BasicShapes"})
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.ShowPageBreaks = False
            Me.diagramDataBindingController1.TemplateDiagram.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Linear
            Me.diagramDataBindingController1.TemplateDiagram.TabIndex = 0
            AddHandler Me.diagramDataBindingController1.GenerateItem, New System.EventHandler(Of DevExpress.XtraDiagram.DiagramGenerateItemEventArgs)(AddressOf Me.diagramDataBindingController1_GenerateItem)
            AddHandler Me.diagramDataBindingController1.GenerateConnector, New System.EventHandler(Of DevExpress.XtraDiagram.DiagramGenerateConnectorEventArgs)(AddressOf Me.diagramDataBindingController1_GenerateConnector)
            AddHandler Me.diagramDataBindingController1.ItemsGenerated, New System.EventHandler(Of DevExpress.XtraDiagram.DiagramItemsGeneratedEventArgs)(AddressOf Me.diagramDataBindingController1_ItemsGenerated)
            ' 
            ' diagramConnector1
            ' 
            Me.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White
            Me.diagramConnector1.BeginPoint = New DevExpress.Utils.PointFloat(550F, 150F)
            Me.diagramConnector1.CanChangeRoute = False
            Me.diagramConnector1.CanDragBeginPoint = False
            Me.diagramConnector1.CanDragEndPoint = False
            Me.diagramConnector1.EndPoint = New DevExpress.Utils.PointFloat(640F, 240F)
            Me.diagramConnector1.Points = New DevExpress.XtraDiagram.PointCollection(New DevExpress.Utils.PointFloat() {New DevExpress.Utils.PointFloat(640F, 150F)})
            Me.diagramConnector1.Type = DevExpress.Diagram.Core.ConnectorType.Curved
            ' 
            ' DatabaseDiagram
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "DatabaseDiagram"
            Me.containerControl.ResumeLayout(False)
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.diagramDataBindingController1.TemplateDiagram), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.diagramDataBindingController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private diagramDataBindingController1 As DevExpress.XtraDiagram.DiagramDataBindingController

        Private diagramConnector1 As DevExpress.XtraDiagram.DiagramConnector
    End Class
End Namespace
