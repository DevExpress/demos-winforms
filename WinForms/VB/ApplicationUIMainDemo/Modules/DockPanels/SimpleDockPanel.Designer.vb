Namespace DevExpress.ApplicationUI.Demos

    Partial Class SimpleDockPanel

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
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1})
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel1.FloatSize = New System.Drawing.Size(200, 197)
            Me.dockPanel1.FloatVertical = True
            Me.dockPanel1.ID = New System.Guid("1717b57d-3d42-43ba-a442-fdcd4e5588cf")
            Me.dockPanel1.ImageIndex = 5
            Me.dockPanel1.Location = New System.Drawing.Point(260, 0)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Size = New System.Drawing.Size(200, 260)
            Me.dockPanel1.Text = "dockPanel1"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 25)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(194, 232)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' SimpleDockPanel
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dockPanel1)
            Me.Name = "SimpleDockPanel"
            Me.Size = New System.Drawing.Size(460, 260)
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private components As System.ComponentModel.Container = Nothing
    End Class
End Namespace
