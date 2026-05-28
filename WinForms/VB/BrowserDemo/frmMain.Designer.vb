Namespace DevExpress.XtraBars.Demos.BrowserDemo

    Partial Class frmMain

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
            If System.Threading.Interlocked.Decrement(DevExpress.XtraBars.Demos.BrowserDemo.frmMain.OpenFormCount) = 0 Then System.Windows.Forms.Application.[Exit]()
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraBars.Demos.BrowserDemo.frmMain))
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.tabFormControl1 = New DevExpress.XtraBars.TabFormControl()
            Me.tabFormPage1 = New DevExpress.XtraBars.TabFormPage()
            Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barAndDockingController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            CType((Me.tabFormControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager1
            ' 
            Me.barManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Built-in Menus", New System.Guid("4712321c-b9cd-461f-b453-4a7791063abb")), New DevExpress.XtraBars.BarManagerCategory("Standard", New System.Guid("8e707040-b093-4d7e-8f27-277ae2456d3b")), New DevExpress.XtraBars.BarManagerCategory("Address", New System.Guid("fb82a187-cdf0-4f39-a566-c00dbaba593d")), New DevExpress.XtraBars.BarManagerCategory("StatusBar", New System.Guid("2ca54f89-3af6-4cbb-93d8-4a4a9387f283")), New DevExpress.XtraBars.BarManagerCategory("Items", New System.Guid("b086ef9d-c758-46ba-a35f-058eada7ad13")), New DevExpress.XtraBars.BarManagerCategory("Favorites", New System.Guid("e1ba440c-33dc-4df6-b712-79cdc4dcd983"))})
            Me.barManager1.Controller = Me.barAndDockingController1
            Me.barManager1.DockControls.Add(Me.barDockControl1)
            Me.barManager1.DockControls.Add(Me.barDockControl2)
            Me.barManager1.DockControls.Add(Me.barDockControl3)
            Me.barManager1.DockControls.Add(Me.barDockControl4)
            Me.barManager1.DockManager = Me.dockManager1
            Me.barManager1.Form = Me
            Me.barManager1.MaxItemId = 38
            ' 
            ' barAndDockingController1
            ' 
            Me.barAndDockingController1.PaintStyleName = "Skin"
            Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
            Me.barAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
            Me.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
            ' 
            ' barDockControl1
            ' 
            Me.barDockControl1.CausesValidation = False
            Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControl1.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl1.Size = New System.Drawing.Size(1055, 0)
            ' 
            ' barDockControl2
            ' 
            Me.barDockControl2.CausesValidation = False
            Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControl2.Location = New System.Drawing.Point(0, 490)
            Me.barDockControl2.Size = New System.Drawing.Size(1055, 0)
            ' 
            ' barDockControl3
            ' 
            Me.barDockControl3.CausesValidation = False
            Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControl3.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl3.Size = New System.Drawing.Size(0, 490)
            ' 
            ' barDockControl4
            ' 
            Me.barDockControl4.CausesValidation = False
            Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControl4.Location = New System.Drawing.Point(1055, 0)
            Me.barDockControl4.Size = New System.Drawing.Size(0, 490)
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Controller = Me.barAndDockingController1
            Me.dockManager1.Form = Me
            Me.dockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1})
            Me.dockManager1.MenuManager = Me.barManager1
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanel1.FloatLocation = New System.Drawing.Point(930, 172)
            Me.dockPanel1.ID = New System.Guid("1734463f-4924-485e-9b75-59ea0e8bfee3")
            Me.dockPanel1.ImageUri.Uri = ""
            Me.dockPanel1.Location = New System.Drawing.Point(-32768, -32768)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanel1.SavedIndex = 0
            Me.dockPanel1.Size = New System.Drawing.Size(200, 200)
            Me.dockPanel1.Text = "Favorites"
            Me.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            ' 
            ' dockPanel1_Container
            ' 
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 22)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(194, 175)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "The Bezier"
            ' 
            ' tabFormControl1
            ' 
            Me.tabFormControl1.Location = New System.Drawing.Point(0, 0)
            Me.tabFormControl1.Manager = Me.barManager1
            Me.tabFormControl1.Name = "tabFormControl1"
            Me.tabFormControl1.Pages.Add(Me.tabFormPage1)
            Me.tabFormControl1.SelectedContainer = Me.xtraScrollableControl1
            Me.tabFormControl1.SelectedPage = Me.tabFormPage1
            Me.tabFormControl1.ShowTabsInTitleBar = DevExpress.XtraBars.ShowTabsInTitleBar.[True]
            Me.tabFormControl1.Size = New System.Drawing.Size(1055, 32)
            Me.tabFormControl1.TabForm = Me
            Me.tabFormControl1.TabIndex = 10
            Me.tabFormControl1.TabStop = False
            Me.tabFormControl1.TitleTabVerticalOffset = 7
            AddHandler Me.tabFormControl1.OuterFormCreating, New DevExpress.XtraBars.OuterFormCreatingEventHandler(AddressOf Me.OnOuterFormCreating)
            ' 
            ' tabFormPage1
            ' 
            Me.tabFormPage1.ContentContainer = Me.xtraScrollableControl1
            Me.tabFormPage1.Name = "tabFormPage1"
            Me.tabFormPage1.Text = "DevExpress.com"
            ' 
            ' xtraScrollableControl1
            ' 
            Me.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraScrollableControl1.Location = New System.Drawing.Point(0, 32)
            Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
            Me.xtraScrollableControl1.Size = New System.Drawing.Size(1055, 458)
            Me.xtraScrollableControl1.TabIndex = 11
            ' 
            ' frmMain
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1055, 490)
            Me.Controls.Add(Me.xtraScrollableControl1)
            Me.Controls.Add(Me.tabFormControl1)
            Me.Controls.Add(Me.barDockControl3)
            Me.Controls.Add(Me.barDockControl4)
            Me.Controls.Add(Me.barDockControl2)
            Me.Controls.Add(Me.barDockControl1)
            Me.Icon = CType((resources.GetObject("$this.Icon")), System.Drawing.Icon)
            Me.Name = "frmMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.TabFormControl = Me.tabFormControl1
            Me.Text = "Web Browser"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.frmMain_Load)
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barAndDockingController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            CType((Me.tabFormControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControl1 As DevExpress.XtraBars.BarDockControl

        Private barDockControl2 As DevExpress.XtraBars.BarDockControl

        Private barDockControl3 As DevExpress.XtraBars.BarDockControl

        Private barDockControl4 As DevExpress.XtraBars.BarDockControl

        Private components As System.ComponentModel.IContainer

        Private barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController

        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl

        Private tabFormControl1 As DevExpress.XtraBars.TabFormControl

        Private tabFormPage1 As DevExpress.XtraBars.TabFormPage
    End Class
End Namespace
