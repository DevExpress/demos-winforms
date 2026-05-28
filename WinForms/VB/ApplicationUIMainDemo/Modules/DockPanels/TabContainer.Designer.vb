Namespace DevExpress.ApplicationUI.Demos

    Partial Class TabContainer

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.panelContainer1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.panelContainer1})
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel1.ID = New System.Guid("05d6cf86-1ef6-4c82-9dc9-5dbc09c844b2")
            Me.dockPanel1.ImageIndex = 0
            Me.dockPanel1.Location = New System.Drawing.Point(3, 25)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Size = New System.Drawing.Size(194, 229)
            Me.dockPanel1.Text = "dockPanel1"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(194, 229)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.ID = New System.Guid("d0ca1ef3-c51c-4bd7-9def-30e8e27390d5")
            Me.dockPanel2.ImageIndex = 2
            Me.dockPanel2.Location = New System.Drawing.Point(3, 25)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.Size = New System.Drawing.Size(194, 229)
            Me.dockPanel2.Text = "dockPanel2"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(194, 229)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.ActiveChild = Me.dockPanel1
            Me.panelContainer1.Controls.Add(Me.dockPanel1)
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.ID = New System.Guid("f00be6cd-8f2b-41d1-a6f9-127aedbec743")
            Me.panelContainer1.ImageIndex = 5
            Me.panelContainer1.Location = New System.Drawing.Point(304, 0)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.Size = New System.Drawing.Size(200, 280)
            Me.panelContainer1.Tabbed = True
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' TabContainer
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelContainer1)
            Me.Name = "TabContainer"
            Me.Size = New System.Drawing.Size(504, 280)
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.panelContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel

        Private components As System.ComponentModel.Container = Nothing
    End Class
End Namespace
