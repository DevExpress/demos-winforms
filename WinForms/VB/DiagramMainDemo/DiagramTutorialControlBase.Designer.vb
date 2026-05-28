Namespace DevExpress.XtraDiagram.Demos

    Partial Class DiagramTutorialControlBase

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.tabPane = New DevExpress.XtraBars.Navigation.TabPane()
            Me.optionsPage = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.sidePanel = New DevExpress.XtraEditors.SidePanel()
            Me.containerControl = New System.Windows.Forms.ContainerControl()
            Me.diagramControl = New DevExpress.XtraDiagram.DiagramControl()
            CType((Me.tabPane), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel.SuspendLayout()
            Me.containerControl.SuspendLayout()
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabPane
            ' 
            Me.tabPane.AllowCollapse = DevExpress.Utils.DefaultBoolean.[True]
            Me.tabPane.AllowResize = False
            Me.tabPane.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane.Location = New System.Drawing.Point(1, 0)
            Me.tabPane.Name = "tabPane"
            Me.tabPane.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.tabPane.RegularSize = New System.Drawing.Size(279, 441)
            Me.tabPane.SelectedPage = Nothing
            Me.tabPane.Size = New System.Drawing.Size(249, 441)
            Me.tabPane.TabIndex = 5
            ' 
            ' optionsPage
            ' 
            Me.optionsPage.AutoScroll = True
            Me.optionsPage.Caption = "Options"
            Me.optionsPage.Name = "optionsPage"
            Me.optionsPage.Size = New System.Drawing.Size(249, 408)
            ' 
            ' sidePanel
            ' 
            Me.sidePanel.AllowResize = False
            Me.sidePanel.Controls.Add(Me.tabPane)
            Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel.Location = New System.Drawing.Point(544, 0)
            Me.sidePanel.Name = "sidePanel"
            Me.sidePanel.Size = New System.Drawing.Size(250, 441)
            Me.sidePanel.TabIndex = 1
            Me.sidePanel.Text = "sidePanel"
            ' 
            ' containerControl
            ' 
            Me.containerControl.Controls.Add(Me.diagramControl)
            Me.containerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.containerControl.Location = New System.Drawing.Point(0, 0)
            Me.containerControl.Margin = New System.Windows.Forms.Padding(0)
            Me.containerControl.Name = "containerControl"
            Me.containerControl.Size = New System.Drawing.Size(544, 441)
            Me.containerControl.TabIndex = 6
            ' 
            ' diagramControl
            ' 
            Me.diagramControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.diagramControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagramControl.Location = New System.Drawing.Point(0, 0)
            Me.diagramControl.Name = "diagramControl"
            Me.diagramControl.OptionsBehavior.SelectedStencils = New DevExpress.Diagram.Core.StencilCollection(New String(-1) {})
            Me.diagramControl.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter
            Me.diagramControl.OptionsView.PropertiesPanelVisibility = DevExpress.Diagram.Core.PropertiesPanelVisibility.Closed
            Me.diagramControl.Size = New System.Drawing.Size(544, 441)
            Me.diagramControl.TabIndex = 0
            ' 
            ' DiagramTutorialControlBase
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.containerControl)
            Me.Controls.Add(Me.sidePanel)
            Me.Name = "DiagramTutorialControlBase"
            Me.Size = New System.Drawing.Size(794, 441)
            CType((Me.tabPane), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel.ResumeLayout(False)
            Me.containerControl.ResumeLayout(False)
            CType((Me.diagramControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tabPane As DevExpress.XtraBars.Navigation.TabPane

        Private optionsPage As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private sidePanel As DevExpress.XtraEditors.SidePanel

        Protected containerControl As System.Windows.Forms.ContainerControl

        Protected diagramControl As DevExpress.XtraDiagram.DiagramControl
    End Class
End Namespace
