Namespace DevExpress.XtraBars.Demos.DockingDemo

    Partial Class ucSolutionExplorer

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
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraBars.Demos.DockingDemo.ucSolutionExplorer))
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.iRefresh = New DevExpress.XtraBars.BarButtonItem()
            Me.iShow = New DevExpress.XtraBars.BarButtonItem()
            Me.iProperties = New DevExpress.XtraBars.BarButtonItem()
            Me.barAndDockingController = New DevExpress.XtraBars.BarAndDockingController(Me.components)
            Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
            Me.fileTypeSvgImages = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.treeView = New DevExpress.XtraTreeList.TreeList()
            CType((Me.barManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barAndDockingController), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.fileTypeSvgImages), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType((Me.treeView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager
            ' 
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager.Controller = Me.barAndDockingController
            Me.barManager.DockControls.Add(Me.barDockControl1)
            Me.barManager.DockControls.Add(Me.barDockControl2)
            Me.barManager.DockControls.Add(Me.barDockControl3)
            Me.barManager.DockControls.Add(Me.barDockControl4)
            Me.barManager.Form = Me
            Me.barManager.Images = Me.fileTypeSvgImages
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.iRefresh, Me.iShow, Me.iProperties})
            Me.barManager.UseAltKeyForMenu = False
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Explorer"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(53, 102)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.iShow, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iProperties, True)})
            Me.bar1.OptionsBar.AllowQuickCustomization = False
            Me.bar1.OptionsBar.DrawDragBorder = False
            Me.bar1.OptionsBar.RotateWhenVertical = False
            Me.bar1.OptionsBar.UseWholeRow = True
            Me.bar1.Text = "Explorer"
            ' 
            ' iRefresh
            ' 
            Me.iRefresh.Caption = "Refresh"
            Me.iRefresh.Hint = "Refresh"
            Me.iRefresh.Id = 0
            Me.iRefresh.ImageOptions.ImageIndex = 0
            Me.iRefresh.Name = "iRefresh"
            ' 
            ' iShow
            ' 
            Me.iShow.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.iShow.Caption = "Show All Files"
            Me.iShow.Hint = "Show All Files"
            Me.iShow.Id = 1
            Me.iShow.ImageOptions.ImageIndex = 1
            Me.iShow.Name = "iShow"
            AddHandler Me.iShow.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iShow_ItemClick)
            ' 
            ' iProperties
            ' 
            Me.iProperties.Caption = "Properties"
            Me.iProperties.Hint = "Properties"
            Me.iProperties.Id = 2
            Me.iProperties.Name = "iProperties"
            AddHandler Me.iProperties.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.iProperties_ItemClick)
            ' 
            ' barAndDockingController
            ' 
            Me.barAndDockingController.PropertiesBar.AllowLinkLighting = False
            ' 
            ' barDockControl1
            ' 
            Me.barDockControl1.CausesValidation = False
            Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControl1.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl1.Manager = Me.barManager
            Me.barDockControl1.Size = New System.Drawing.Size(288, 28)
            ' 
            ' barDockControl2
            ' 
            Me.barDockControl2.CausesValidation = False
            Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControl2.Location = New System.Drawing.Point(0, 288)
            Me.barDockControl2.Manager = Me.barManager
            Me.barDockControl2.Size = New System.Drawing.Size(288, 0)
            ' 
            ' barDockControl3
            ' 
            Me.barDockControl3.CausesValidation = False
            Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControl3.Location = New System.Drawing.Point(0, 28)
            Me.barDockControl3.Manager = Me.barManager
            Me.barDockControl3.Size = New System.Drawing.Size(0, 260)
            ' 
            ' barDockControl4
            ' 
            Me.barDockControl4.CausesValidation = False
            Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControl4.Location = New System.Drawing.Point(288, 28)
            Me.barDockControl4.Manager = Me.barManager
            Me.barDockControl4.Size = New System.Drawing.Size(0, 260)
            ' 
            ' fileTypeSvgImages
            ' 
            Me.fileTypeSvgImages.Add("0_refresh_16xLG", CType((resources.GetObject("fileTypeSvgImages.0_refresh_16xLG")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("1_ShowAllFiles", CType((resources.GetObject("fileTypeSvgImages.1_ShowAllFiles")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("2_Property_501", CType((resources.GetObject("fileTypeSvgImages.2_Property_501")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("3_Solution_8309", CType((resources.GetObject("fileTypeSvgImages.3_Solution_8309")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("4_CSharpProject_SolutionExplorerNode", CType((resources.GetObject("fileTypeSvgImages.4_CSharpProject_SolutionExplorerNode")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("5_reference_16xLG", CType((resources.GetObject("fileTypeSvgImages.5_reference_16xLG")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("6_FolderOpen", CType((resources.GetObject("fileTypeSvgImages.6_FolderOpen")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("7_Folder", CType((resources.GetObject("fileTypeSvgImages.7_Folder")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("8_HiddenFolder_428", CType((resources.GetObject("fileTypeSvgImages.8_HiddenFolder_428")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("9_HiddenFolder_427", CType((resources.GetObject("fileTypeSvgImages.9_HiddenFolder_427")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("10_CSharpFile_SolutionExplorerNode", CType((resources.GetObject("fileTypeSvgImages.10_CSharpFile_SolutionExplorerNode")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("11_dialog_16xLG", CType((resources.GetObject("fileTypeSvgImages.11_dialog_16xLG")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("12_UserControl", CType((resources.GetObject("fileTypeSvgImages.12_UserControl")), DevExpress.Utils.Svg.SvgImage))
            Me.fileTypeSvgImages.Add("13_VSProject_generatedfile", CType((resources.GetObject("fileTypeSvgImages.13_VSProject_generatedfile")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.treeView)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 28)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(288, 260)
            Me.panel1.TabIndex = 4
            ' 
            ' treeView
            ' 
            Me.treeView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeView.Location = New System.Drawing.Point(0, 0)
            Me.treeView.Name = "treeView"
            Me.treeView.Size = New System.Drawing.Size(288, 260)
            Me.treeView.StateImageList = Me.fileTypeSvgImages
            Me.treeView.TabIndex = 0
            AddHandler Me.treeView.MouseDoubleClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.treeView_MouseDoubleClick)
            ' 
            ' ucSolutionExplorer
            ' 
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.barDockControl3)
            Me.Controls.Add(Me.barDockControl4)
            Me.Controls.Add(Me.barDockControl2)
            Me.Controls.Add(Me.barDockControl1)
            Me.Name = "ucSolutionExplorer"
            Me.Size = New System.Drawing.Size(288, 288)
            CType((Me.barManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barAndDockingController), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.fileTypeSvgImages), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType((Me.treeView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Friend barManager As DevExpress.XtraBars.BarManager

        Private barDockControl1 As DevExpress.XtraBars.BarDockControl

        Private barDockControl2 As DevExpress.XtraBars.BarDockControl

        Private barDockControl3 As DevExpress.XtraBars.BarDockControl

        Private barDockControl4 As DevExpress.XtraBars.BarDockControl

        Private iRefresh As DevExpress.XtraBars.BarButtonItem

        Private iShow As DevExpress.XtraBars.BarButtonItem

        Private iProperties As DevExpress.XtraBars.BarButtonItem

        Private panel1 As System.Windows.Forms.Panel

        Private treeView As DevExpress.XtraTreeList.TreeList

        Private bar1 As DevExpress.XtraBars.Bar

        Private barAndDockingController As DevExpress.XtraBars.BarAndDockingController

        Private components As System.ComponentModel.IContainer

        Private fileTypeSvgImages As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
