Namespace DevExpress.ApplicationUI.Demos

    Partial Class VerticalContainer

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
            Me.dockPanel1.ID = New System.Guid("82936143-e4fa-428c-b931-123d6ea97f4e")
            Me.dockPanel1.ImageIndex = 5
            Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Size = New System.Drawing.Size(200, 123)
            Me.dockPanel1.Text = "dockPanel1"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 25)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(194, 95)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.FloatVertical = True
            Me.dockPanel2.ID = New System.Guid("404364dc-9c48-4726-9d15-2f974d6009c7")
            Me.dockPanel2.ImageIndex = 3
            Me.dockPanel2.Location = New System.Drawing.Point(0, 123)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.Size = New System.Drawing.Size(200, 137)
            Me.dockPanel2.Text = "dockPanel2"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Location = New System.Drawing.Point(3, 25)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(194, 109)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.Controls.Add(Me.dockPanel1)
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.FloatSize = New System.Drawing.Size(200, 197)
            Me.panelContainer1.ID = New System.Guid("b040a8da-8b82-461e-bed0-b001a048f76d")
            Me.panelContainer1.ImageIndex = 0
            Me.panelContainer1.Location = New System.Drawing.Point(260, 0)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.Size = New System.Drawing.Size(200, 260)
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' VerticalContainer
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelContainer1)
            Me.Name = "VerticalContainer"
            Me.Size = New System.Drawing.Size(460, 260)
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
