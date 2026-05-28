Namespace DevExpress.ApplicationUI.Demos

    Partial Class DocumentManagerDocking

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

#Region "Windows Form Designer generated code"
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.ApplicationUI.Demos.DocumentManagerDocking))
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barAndDockingController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer1.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel3.SuspendLayout()
            CType((Me.tabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentManager
            ' 
            Me.documentManager.BarAndDockingController = Me.barAndDockingController1
            Me.documentManager.ContainerControl = Me
            Me.documentManager.MenuManager = Me.barManager1
            Me.documentManager.View = Me.tabbedView
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.tabbedView})
            ' 
            ' barAndDockingController1
            ' 
            Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
            ' 
            ' barManager1
            ' 
            Me.barManager1.Controller = Me.barAndDockingController1
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.DockManager = Me.dockManager1
            Me.barManager1.Form = Me
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(806, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 448)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(806, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 448)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(806, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 448)
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Controller = Me.barAndDockingController1
            Me.dockManager1.Form = Me
            Me.dockManager1.MenuManager = Me.barManager1
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.panelContainer1, Me.dockPanel3})
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Controls.Add(Me.dockPanel1)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.panelContainer1.FloatSize = New System.Drawing.Size(351, 200)
            Me.panelContainer1.Footer = Nothing
            Me.panelContainer1.Header = Nothing
            Me.panelContainer1.ID = New System.Guid("12ee75ca-d68b-4d14-bfcf-76b9f3eebfbd")
            Me.panelContainer1.Location = New System.Drawing.Point(0, 0)
            Me.panelContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(260, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(260, 448)
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.FloatSize = New System.Drawing.Size(351, 200)
            Me.dockPanel2.Footer = Nothing
            Me.dockPanel2.Header = Nothing
            Me.dockPanel2.ID = New System.Guid("d1c1aeb8-8e7f-4a11-9a30-751d4bd0c5a6")
            Me.dockPanel2.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 213)
            Me.dockPanel2.Size = New System.Drawing.Size(260, 213)
            Me.dockPanel2.Text = "TopLeft Panel"
            ' 
            ' dockPanel2_Container
            ' 
            Me.dockPanel2_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel2_Container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(253, 183)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel1.FloatSize = New System.Drawing.Size(527, 492)
            Me.dockPanel1.FloatVertical = True
            Me.dockPanel1.Footer = Nothing
            Me.dockPanel1.Header = Nothing
            Me.dockPanel1.ID = New System.Guid("58c0c721-7d02-4c1a-ba0f-7010bc2df956")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 213)
            Me.dockPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 235)
            Me.dockPanel1.Size = New System.Drawing.Size(260, 235)
            Me.dockPanel1.Text = "BottomLeft Panel"
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(253, 206)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' dockPanel3
            ' 
            Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
            Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel3.FloatSize = New System.Drawing.Size(330, 200)
            Me.dockPanel3.Footer = Nothing
            Me.dockPanel3.Header = Nothing
            Me.dockPanel3.ID = New System.Guid("1539c64a-1755-446f-b583-b0580e9ba1d7")
            Me.dockPanel3.Location = New System.Drawing.Point(546, 0)
            Me.dockPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.dockPanel3.Name = "dockPanel3"
            Me.dockPanel3.OriginalSize = New System.Drawing.Size(260, 200)
            Me.dockPanel3.Size = New System.Drawing.Size(260, 448)
            Me.dockPanel3.Text = "Right Panel"
            ' 
            ' dockPanel3_Container
            ' 
            Me.dockPanel3_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel3_Container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.dockPanel3_Container.Name = "dockPanel3_Container"
            Me.dockPanel3_Container.Size = New System.Drawing.Size(253, 419)
            Me.dockPanel3_Container.TabIndex = 0
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Document4", CType((resources.GetObject("svgImageCollection1.Document4")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Document", CType((resources.GetObject("svgImageCollection1.Document")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Document1", CType((resources.GetObject("svgImageCollection1.Document1")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Document2", CType((resources.GetObject("svgImageCollection1.Document2")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Document5", CType((resources.GetObject("svgImageCollection1.Document5")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' DocumentManagerDocking
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dockPanel3)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "DocumentManagerDocking"
            Me.Size = New System.Drawing.Size(806, 448)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barAndDockingController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer1.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel3.ResumeLayout(False)
            CType((Me.tabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private barManager1 As DevExpress.XtraBars.BarManager

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private components As System.ComponentModel.IContainer

        Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController

        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
