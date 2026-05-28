Namespace DevExpress.XtraDialogs.Demos

    Partial Class TwoPanelFileBrowser

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.fileExplorerAssistant = New DevExpress.XtraDialogs.FileExplorerAssistant(Me.components)
            Me.rightGrid = New DevExpress.XtraGrid.GridControl()
            Me.rightView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.leftGrid = New DevExpress.XtraGrid.GridControl()
            Me.leftView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.currentPathEdit = New DevExpress.XtraEditors.BreadCrumbEdit()
            Me.contentPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.verticalSeparator = New DevExpress.XtraEditors.SeparatorControl()
            Me.toolbarPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
            Me.btnForward = New DevExpress.XtraEditors.SimpleButton()
            Me.btnUp = New DevExpress.XtraEditors.SimpleButton()
            Me.searchBox = New DevExpress.XtraEditors.SearchControl()
            Me.footerPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.btnOpen = New DevExpress.XtraEditors.SimpleButton()
            Me.btnRename = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCopy = New DevExpress.XtraEditors.SimpleButton()
            Me.btnMove = New DevExpress.XtraEditors.SimpleButton()
            Me.btnNewFolder = New DevExpress.XtraEditors.SimpleButton()
            Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
            Me.sidePanelBottom = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanelTop = New DevExpress.XtraEditors.SidePanel()
            CType((Me.fileExplorerAssistant), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rightGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rightView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.leftGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.leftView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentPathEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.contentPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contentPanel.SuspendLayout()
            CType((Me.verticalSeparator), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.toolbarPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.toolbarPanel.SuspendLayout()
            CType((Me.searchBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.footerPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.footerPanel.SuspendLayout()
            Me.sidePanelBottom.SuspendLayout()
            Me.sidePanelTop.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' fileExplorerAssistant
            ' 
            Me.fileExplorerAssistant.Form = Me
            ' 
            ' rightGrid
            ' 
            Me.contentPanel.SetColumn(Me.rightGrid, 2)
            Me.rightGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rightGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
            Me.rightGrid.Location = New System.Drawing.Point(401, 0)
            Me.rightGrid.MainView = Me.rightView
            Me.rightGrid.Margin = New System.Windows.Forms.Padding(0)
            Me.rightGrid.Name = "rightGrid"
            Me.contentPanel.SetRow(Me.rightGrid, 0)
            Me.rightGrid.Size = New System.Drawing.Size(400, 505)
            Me.rightGrid.TabIndex = 5
            Me.rightGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.rightView})
            ' 
            ' rightView
            ' 
            Me.rightView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rightView.GridControl = Me.rightGrid
            Me.rightView.Name = "rightView"
            Me.rightView.OptionsView.ShowGroupPanel = False
            ' 
            ' leftGrid
            ' 
            Me.contentPanel.SetColumn(Me.leftGrid, 0)
            Me.leftGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.leftGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
            Me.leftGrid.Location = New System.Drawing.Point(0, 0)
            Me.leftGrid.MainView = Me.leftView
            Me.leftGrid.Margin = New System.Windows.Forms.Padding(0)
            Me.leftGrid.Name = "leftGrid"
            Me.contentPanel.SetRow(Me.leftGrid, 0)
            Me.leftGrid.Size = New System.Drawing.Size(400, 505)
            Me.leftGrid.TabIndex = 4
            Me.leftGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.leftView})
            ' 
            ' leftView
            ' 
            Me.leftView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.leftView.GridControl = Me.leftGrid
            Me.leftView.Name = "leftView"
            Me.leftView.OptionsView.ShowGroupPanel = False
            ' 
            ' currentPathEdit
            ' 
            Me.toolbarPanel.SetColumn(Me.currentPathEdit, 3)
            Me.currentPathEdit.Location = New System.Drawing.Point(114, 13)
            Me.currentPathEdit.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
            Me.currentPathEdit.Name = "currentPathEdit"
            Me.currentPathEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.toolbarPanel.SetRow(Me.currentPathEdit, 0)
            Me.currentPathEdit.Size = New System.Drawing.Size(483, 20)
            Me.currentPathEdit.TabIndex = 4
            ' 
            ' contentPanel
            ' 
            Me.contentPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.contentPanel.Controls.Add(Me.verticalSeparator)
            Me.contentPanel.Controls.Add(Me.rightGrid)
            Me.contentPanel.Controls.Add(Me.leftGrid)
            Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.contentPanel.Location = New System.Drawing.Point(0, 47)
            Me.contentPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.contentPanel.Name = "contentPanel"
            Me.contentPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)})
            Me.contentPanel.Size = New System.Drawing.Size(800, 505)
            Me.contentPanel.TabIndex = 0
            ' 
            ' verticalSeparator
            ' 
            Me.verticalSeparator.AutoSizeMode = True
            Me.contentPanel.SetColumn(Me.verticalSeparator, 1)
            Me.verticalSeparator.Dock = System.Windows.Forms.DockStyle.Fill
            Me.verticalSeparator.LineOrientation = System.Windows.Forms.Orientation.Vertical
            Me.verticalSeparator.Location = New System.Drawing.Point(400, 0)
            Me.verticalSeparator.Margin = New System.Windows.Forms.Padding(0)
            Me.verticalSeparator.Name = "verticalSeparator"
            Me.verticalSeparator.Padding = New System.Windows.Forms.Padding(0)
            Me.contentPanel.SetRow(Me.verticalSeparator, 0)
            Me.verticalSeparator.Size = New System.Drawing.Size(1, 505)
            Me.verticalSeparator.TabIndex = 6
            ' 
            ' toolbarPanel
            ' 
            Me.toolbarPanel.AutoSize = True
            Me.toolbarPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 200F)})
            Me.toolbarPanel.Controls.Add(Me.btnBack)
            Me.toolbarPanel.Controls.Add(Me.currentPathEdit)
            Me.toolbarPanel.Controls.Add(Me.btnForward)
            Me.toolbarPanel.Controls.Add(Me.btnUp)
            Me.toolbarPanel.Controls.Add(Me.searchBox)
            Me.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toolbarPanel.Location = New System.Drawing.Point(0, 0)
            Me.toolbarPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.toolbarPanel.Name = "toolbarPanel"
            Me.toolbarPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.toolbarPanel.Size = New System.Drawing.Size(800, 46)
            Me.toolbarPanel.TabIndex = 1
            ' 
            ' btnBack
            ' 
            Me.btnBack.AutoSize = True
            Me.toolbarPanel.SetColumn(Me.btnBack, 0)
            Me.btnBack.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.navigateBack
            Me.btnBack.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnBack.Location = New System.Drawing.Point(12, 9)
            Me.btnBack.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.toolbarPanel.SetRow(Me.btnBack, 0)
            Me.btnBack.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnBack.Size = New System.Drawing.Size(30, 28)
            Me.btnBack.TabIndex = 0
            AddHandler Me.btnBack.Click, New System.EventHandler(AddressOf Me.OnBack)
            ' 
            ' btnForward
            ' 
            Me.btnForward.AutoSize = True
            Me.toolbarPanel.SetColumn(Me.btnForward, 1)
            Me.btnForward.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.navigateForward
            Me.btnForward.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnForward.Location = New System.Drawing.Point(42, 9)
            Me.btnForward.Margin = New System.Windows.Forms.Padding(0)
            Me.btnForward.Name = "btnForward"
            Me.btnForward.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.toolbarPanel.SetRow(Me.btnForward, 0)
            Me.btnForward.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnForward.Size = New System.Drawing.Size(30, 28)
            Me.btnForward.TabIndex = 2
            AddHandler Me.btnForward.Click, New System.EventHandler(AddressOf Me.OnForward)
            ' 
            ' btnUp
            ' 
            Me.btnUp.AutoSize = True
            Me.toolbarPanel.SetColumn(Me.btnUp, 2)
            Me.btnUp.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.navigateUp
            Me.btnUp.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnUp.Location = New System.Drawing.Point(72, 9)
            Me.btnUp.Margin = New System.Windows.Forms.Padding(0)
            Me.btnUp.Name = "btnUp"
            Me.btnUp.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.toolbarPanel.SetRow(Me.btnUp, 0)
            Me.btnUp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnUp.Size = New System.Drawing.Size(30, 28)
            Me.btnUp.TabIndex = 2
            AddHandler Me.btnUp.Click, New System.EventHandler(AddressOf Me.OnUp)
            ' 
            ' searchBox
            ' 
            Me.toolbarPanel.SetColumn(Me.searchBox, 4)
            Me.searchBox.Location = New System.Drawing.Point(612, 13)
            Me.searchBox.Margin = New System.Windows.Forms.Padding(12, 3, 12, 3)
            Me.searchBox.Name = "searchBox"
            Me.searchBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.toolbarPanel.SetRow(Me.searchBox, 0)
            Me.searchBox.Size = New System.Drawing.Size(176, 20)
            Me.searchBox.TabIndex = 2
            ' 
            ' footerPanel
            ' 
            Me.footerPanel.AutoSize = True
            Me.footerPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.footerPanel.Controls.Add(Me.btnOpen)
            Me.footerPanel.Controls.Add(Me.btnRename)
            Me.footerPanel.Controls.Add(Me.btnCopy)
            Me.footerPanel.Controls.Add(Me.btnMove)
            Me.footerPanel.Controls.Add(Me.btnNewFolder)
            Me.footerPanel.Controls.Add(Me.btnDelete)
            Me.footerPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.footerPanel.Location = New System.Drawing.Point(12, 9)
            Me.footerPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.footerPanel.Name = "footerPanel"
            Me.footerPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.footerPanel.Size = New System.Drawing.Size(501, 31)
            Me.footerPanel.TabIndex = 5
            ' 
            ' btnOpen
            ' 
            Me.btnOpen.AutoSize = True
            Me.footerPanel.SetColumn(Me.btnOpen, 0)
            Me.btnOpen.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.btnOpen.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.f3
            Me.btnOpen.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnOpen.Location = New System.Drawing.Point(0, 0)
            Me.btnOpen.Margin = New System.Windows.Forms.Padding(0)
            Me.btnOpen.Name = "btnOpen"
            Me.btnOpen.Padding = New System.Windows.Forms.Padding(8, 4, 8, 4)
            Me.btnOpen.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.footerPanel.SetRow(Me.btnOpen, 0)
            Me.btnOpen.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnOpen.Size = New System.Drawing.Size(76, 31)
            Me.btnOpen.TabIndex = 0
            Me.btnOpen.Text = "Open"
            AddHandler Me.btnOpen.Click, New System.EventHandler(AddressOf Me.OnOpen)
            ' 
            ' btnRename
            ' 
            Me.btnRename.AutoSize = True
            Me.footerPanel.SetColumn(Me.btnRename, 1)
            Me.btnRename.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.btnRename.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.f4
            Me.btnRename.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnRename.Location = New System.Drawing.Point(76, 0)
            Me.btnRename.Margin = New System.Windows.Forms.Padding(0)
            Me.btnRename.Name = "btnRename"
            Me.btnRename.Padding = New System.Windows.Forms.Padding(8, 4, 8, 4)
            Me.btnRename.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.footerPanel.SetRow(Me.btnRename, 0)
            Me.btnRename.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnRename.Size = New System.Drawing.Size(89, 31)
            Me.btnRename.TabIndex = 0
            Me.btnRename.Text = "Rename"
            AddHandler Me.btnRename.Click, New System.EventHandler(AddressOf Me.OnRename)
            ' 
            ' btnCopy
            ' 
            Me.btnCopy.AutoSize = True
            Me.footerPanel.SetColumn(Me.btnCopy, 2)
            Me.btnCopy.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.btnCopy.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.f5
            Me.btnCopy.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnCopy.Location = New System.Drawing.Point(165, 0)
            Me.btnCopy.Margin = New System.Windows.Forms.Padding(0)
            Me.btnCopy.Name = "btnCopy"
            Me.btnCopy.Padding = New System.Windows.Forms.Padding(8, 4, 8, 4)
            Me.btnCopy.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.footerPanel.SetRow(Me.btnCopy, 0)
            Me.btnCopy.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnCopy.Size = New System.Drawing.Size(75, 31)
            Me.btnCopy.TabIndex = 0
            Me.btnCopy.Text = "Copy"
            AddHandler Me.btnCopy.Click, New System.EventHandler(AddressOf Me.OnCopy)
            ' 
            ' btnMove
            ' 
            Me.btnMove.AutoSize = True
            Me.footerPanel.SetColumn(Me.btnMove, 3)
            Me.btnMove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.btnMove.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.f6
            Me.btnMove.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnMove.Location = New System.Drawing.Point(240, 0)
            Me.btnMove.Margin = New System.Windows.Forms.Padding(0)
            Me.btnMove.Name = "btnMove"
            Me.btnMove.Padding = New System.Windows.Forms.Padding(8, 4, 8, 4)
            Me.btnMove.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.footerPanel.SetRow(Me.btnMove, 0)
            Me.btnMove.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnMove.Size = New System.Drawing.Size(76, 31)
            Me.btnMove.TabIndex = 0
            Me.btnMove.Text = "Move"
            AddHandler Me.btnMove.Click, New System.EventHandler(AddressOf Me.OnMove)
            ' 
            ' btnNewFolder
            ' 
            Me.btnNewFolder.AutoSize = True
            Me.footerPanel.SetColumn(Me.btnNewFolder, 4)
            Me.btnNewFolder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.btnNewFolder.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.f7
            Me.btnNewFolder.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnNewFolder.Location = New System.Drawing.Point(316, 0)
            Me.btnNewFolder.Margin = New System.Windows.Forms.Padding(0)
            Me.btnNewFolder.Name = "btnNewFolder"
            Me.btnNewFolder.Padding = New System.Windows.Forms.Padding(8, 4, 8, 4)
            Me.btnNewFolder.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.footerPanel.SetRow(Me.btnNewFolder, 0)
            Me.btnNewFolder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnNewFolder.Size = New System.Drawing.Size(104, 31)
            Me.btnNewFolder.TabIndex = 0
            Me.btnNewFolder.Text = "New Folder"
            AddHandler Me.btnNewFolder.Click, New System.EventHandler(AddressOf Me.OnNewFolder)
            ' 
            ' btnDelete
            ' 
            Me.btnDelete.AutoSize = True
            Me.footerPanel.SetColumn(Me.btnDelete, 5)
            Me.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.btnDelete.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.f8
            Me.btnDelete.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnDelete.Location = New System.Drawing.Point(420, 0)
            Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Padding = New System.Windows.Forms.Padding(8, 4, 8, 4)
            Me.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.footerPanel.SetRow(Me.btnDelete, 0)
            Me.btnDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnDelete.Size = New System.Drawing.Size(81, 31)
            Me.btnDelete.TabIndex = 0
            Me.btnDelete.Text = "Delete"
            AddHandler Me.btnDelete.Click, New System.EventHandler(AddressOf Me.OnDelete)
            ' 
            ' sidePanelBottom
            ' 
            Me.sidePanelBottom.AllowResize = False
            Me.sidePanelBottom.Controls.Add(Me.footerPanel)
            Me.sidePanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.sidePanelBottom.Location = New System.Drawing.Point(0, 552)
            Me.sidePanelBottom.Name = "sidePanelBottom"
            Me.sidePanelBottom.Padding = New System.Windows.Forms.Padding(12, 8, 12, 8)
            Me.sidePanelBottom.Size = New System.Drawing.Size(800, 48)
            Me.sidePanelBottom.TabIndex = 6
            ' 
            ' sidePanelTop
            ' 
            Me.sidePanelTop.AllowResize = False
            Me.sidePanelTop.Controls.Add(Me.toolbarPanel)
            Me.sidePanelTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.sidePanelTop.Location = New System.Drawing.Point(0, 0)
            Me.sidePanelTop.Name = "sidePanelTop"
            Me.sidePanelTop.Size = New System.Drawing.Size(800, 47)
            Me.sidePanelTop.TabIndex = 6
            ' 
            ' TwoPanelFileBrowser
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.contentPanel)
            Me.Controls.Add(Me.sidePanelTop)
            Me.Controls.Add(Me.sidePanelBottom)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "TwoPanelFileBrowser"
            Me.Size = New System.Drawing.Size(800, 600)
            CType((Me.fileExplorerAssistant), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rightGrid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rightView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.leftGrid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.leftView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentPathEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.contentPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.contentPanel.ResumeLayout(False)
            CType((Me.verticalSeparator), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toolbarPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.toolbarPanel.ResumeLayout(False)
            Me.toolbarPanel.PerformLayout()
            CType((Me.searchBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.footerPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.footerPanel.ResumeLayout(False)
            Me.footerPanel.PerformLayout()
            Me.sidePanelBottom.ResumeLayout(False)
            Me.sidePanelBottom.PerformLayout()
            Me.sidePanelTop.ResumeLayout(False)
            Me.sidePanelTop.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private fileExplorerAssistant As DevExpress.XtraDialogs.FileExplorerAssistant

        Private rightGrid As DevExpress.XtraGrid.GridControl

        Private rightView As DevExpress.XtraGrid.Views.Grid.GridView

        Private leftGrid As DevExpress.XtraGrid.GridControl

        Private leftView As DevExpress.XtraGrid.Views.Grid.GridView

        Private currentPathEdit As DevExpress.XtraEditors.BreadCrumbEdit

        Private toolbarPanel As DevExpress.Utils.Layout.TablePanel

        Private btnBack As DevExpress.XtraEditors.SimpleButton

        Private contentPanel As DevExpress.Utils.Layout.TablePanel

        Private btnForward As DevExpress.XtraEditors.SimpleButton

        Private btnUp As DevExpress.XtraEditors.SimpleButton

        Private searchBox As DevExpress.XtraEditors.SearchControl

        Private footerPanel As DevExpress.Utils.Layout.TablePanel

        Private btnOpen As DevExpress.XtraEditors.SimpleButton

        Private btnRename As DevExpress.XtraEditors.SimpleButton

        Private btnCopy As DevExpress.XtraEditors.SimpleButton

        Private btnMove As DevExpress.XtraEditors.SimpleButton

        Private btnDelete As DevExpress.XtraEditors.SimpleButton

        Private btnNewFolder As DevExpress.XtraEditors.SimpleButton

        Private sidePanelTop As DevExpress.XtraEditors.SidePanel

        Private sidePanelBottom As DevExpress.XtraEditors.SidePanel

        Private verticalSeparator As DevExpress.XtraEditors.SeparatorControl
    End Class
End Namespace
