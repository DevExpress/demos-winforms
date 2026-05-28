Namespace DevExpress.XtraDialogs.Demos

    Partial Class CustomDialogLayout

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
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.fileExplorerAssistant = New DevExpress.XtraDialogs.FileExplorerAssistant(Me.components)
            Me.leftPanel = New DevExpress.XtraEditors.SidePanel()
            Me.treeList = New DevExpress.XtraTreeList.TreeList()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.toolbarPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
            Me.currentPathEdit = New DevExpress.XtraEditors.BreadCrumbEdit()
            Me.btnForward = New DevExpress.XtraEditors.SimpleButton()
            Me.btnUp = New DevExpress.XtraEditors.SimpleButton()
            Me.searchBox = New DevExpress.XtraEditors.SearchControl()
            Me.bottomPanel = New DevExpress.XtraEditors.SidePanel()
            Me.tablePanel1 = New DevExpress.Utils.Layout.TablePanel()
            Me.fNameLabel = New DevExpress.XtraEditors.LabelControl()
            Me.fileNameEdit = New DevExpress.XtraEditors.TextEdit()
            Me.btnOpenFile = New DevExpress.XtraEditors.SimpleButton()
            Me.topPanel = New DevExpress.XtraEditors.SidePanel()
            Me.rightPanel = New DevExpress.XtraEditors.SidePanel()
            Me.panelControl = New DevExpress.XtraEditors.PanelControl()
            CType((Me.fileExplorerAssistant), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.leftPanel.SuspendLayout()
            CType((Me.treeList), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.toolbarPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.toolbarPanel.SuspendLayout()
            CType((Me.currentPathEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.bottomPanel.SuspendLayout()
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tablePanel1.SuspendLayout()
            CType((Me.fileNameEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.topPanel.SuspendLayout()
            Me.rightPanel.SuspendLayout()
            CType((Me.panelControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' leftPanel
            ' 
            Me.leftPanel.Controls.Add(Me.treeList)
            Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.leftPanel.Location = New System.Drawing.Point(0, 48)
            Me.leftPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.leftPanel.Name = "leftPanel"
            Me.leftPanel.Size = New System.Drawing.Size(199, 276)
            Me.leftPanel.TabIndex = 0
            ' 
            ' treeList
            ' 
            Me.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList.Location = New System.Drawing.Point(0, 0)
            Me.treeList.Margin = New System.Windows.Forms.Padding(0)
            Me.treeList.Name = "treeList"
            Me.treeList.Size = New System.Drawing.Size(198, 276)
            Me.treeList.TabIndex = 0
            ' 
            ' gridControl
            ' 
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(199, 48)
            Me.gridControl.MainView = Me.gridView1
            Me.gridControl.Margin = New System.Windows.Forms.Padding(0)
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(388, 276)
            Me.gridControl.TabIndex = 1
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.GridControl = Me.gridControl
            Me.gridView1.Name = "gridView1"
            ' 
            ' toolbarPanel
            ' 
            Me.toolbarPanel.AutoSize = True
            Me.toolbarPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F)})
            Me.toolbarPanel.Controls.Add(Me.btnBack)
            Me.toolbarPanel.Controls.Add(Me.currentPathEdit)
            Me.toolbarPanel.Controls.Add(Me.btnForward)
            Me.toolbarPanel.Controls.Add(Me.btnUp)
            Me.toolbarPanel.Controls.Add(Me.searchBox)
            Me.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toolbarPanel.Location = New System.Drawing.Point(12, 8)
            Me.toolbarPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.toolbarPanel.Name = "toolbarPanel"
            Me.toolbarPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.toolbarPanel.Size = New System.Drawing.Size(992, 31)
            Me.toolbarPanel.TabIndex = 2
            ' 
            ' btnBack
            ' 
            Me.btnBack.AutoSize = True
            Me.toolbarPanel.SetColumn(Me.btnBack, 0)
            Me.btnBack.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.navigateBack
            Me.btnBack.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnBack.Location = New System.Drawing.Point(0, 1)
            Me.btnBack.Margin = New System.Windows.Forms.Padding(0)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.toolbarPanel.SetRow(Me.btnBack, 0)
            Me.btnBack.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnBack.Size = New System.Drawing.Size(30, 28)
            Me.btnBack.TabIndex = 0
            AddHandler Me.btnBack.Click, New System.EventHandler(AddressOf Me.btnBack_Click)
            ' 
            ' currentPathEdit
            ' 
            Me.toolbarPanel.SetColumn(Me.currentPathEdit, 3)
            Me.currentPathEdit.Location = New System.Drawing.Point(92, 5)
            Me.currentPathEdit.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.currentPathEdit.Name = "currentPathEdit"
            Me.currentPathEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.toolbarPanel.SetRow(Me.currentPathEdit, 0)
            Me.currentPathEdit.Size = New System.Drawing.Size(750, 20)
            Me.currentPathEdit.TabIndex = 4
            ' 
            ' btnForward
            ' 
            Me.btnForward.AutoSize = True
            Me.toolbarPanel.SetColumn(Me.btnForward, 1)
            Me.btnForward.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.navigateForward
            Me.btnForward.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnForward.Location = New System.Drawing.Point(30, 1)
            Me.btnForward.Margin = New System.Windows.Forms.Padding(0)
            Me.btnForward.Name = "btnForward"
            Me.btnForward.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.toolbarPanel.SetRow(Me.btnForward, 0)
            Me.btnForward.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnForward.Size = New System.Drawing.Size(30, 28)
            Me.btnForward.TabIndex = 2
            AddHandler Me.btnForward.Click, New System.EventHandler(AddressOf Me.btnForward_Click)
            ' 
            ' btnUp
            ' 
            Me.btnUp.AutoSize = True
            Me.toolbarPanel.SetColumn(Me.btnUp, 2)
            Me.btnUp.ImageOptions.SvgImage = Global.DevExpress.XtraDialogs.Demos.Properties.Resources.navigateUp
            Me.btnUp.ImageOptions.SvgImageSize = New System.Drawing.Size(24, 24)
            Me.btnUp.Location = New System.Drawing.Point(60, 1)
            Me.btnUp.Margin = New System.Windows.Forms.Padding(0)
            Me.btnUp.Name = "btnUp"
            Me.btnUp.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
            Me.toolbarPanel.SetRow(Me.btnUp, 0)
            Me.btnUp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.btnUp.Size = New System.Drawing.Size(30, 28)
            Me.btnUp.TabIndex = 2
            AddHandler Me.btnUp.Click, New System.EventHandler(AddressOf Me.btnUp_Click)
            ' 
            ' searchBox
            ' 
            Me.searchBox.Client = Me.gridControl
            Me.toolbarPanel.SetColumn(Me.searchBox, 4)
            Me.searchBox.Location = New System.Drawing.Point(850, 5)
            Me.searchBox.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
            Me.searchBox.Name = "searchBox"
            Me.searchBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.searchBox.Properties.Client = Me.gridControl
            Me.toolbarPanel.SetRow(Me.searchBox, 0)
            Me.searchBox.Size = New System.Drawing.Size(142, 20)
            Me.searchBox.TabIndex = 2
            ' 
            ' bottomPanel
            ' 
            Me.bottomPanel.AllowResize = False
            Me.bottomPanel.Controls.Add(Me.tablePanel1)
            Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.bottomPanel.Location = New System.Drawing.Point(0, 324)
            Me.bottomPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.bottomPanel.Name = "bottomPanel"
            Me.bottomPanel.Padding = New System.Windows.Forms.Padding(12, 8, 12, 8)
            Me.bottomPanel.Size = New System.Drawing.Size(1016, 73)
            Me.bottomPanel.TabIndex = 3
            Me.bottomPanel.Visible = False
            ' 
            ' tablePanel1
            ' 
            Me.tablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F)})
            Me.tablePanel1.Controls.Add(Me.fNameLabel)
            Me.tablePanel1.Controls.Add(Me.fileNameEdit)
            Me.tablePanel1.Controls.Add(Me.btnOpenFile)
            Me.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tablePanel1.Location = New System.Drawing.Point(12, 9)
            Me.tablePanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.tablePanel1.Name = "tablePanel1"
            Me.tablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)})
            Me.tablePanel1.Size = New System.Drawing.Size(992, 56)
            Me.tablePanel1.TabIndex = 0
            ' 
            ' fNameLabel
            ' 
            Me.tablePanel1.SetColumn(Me.fNameLabel, 0)
            Me.fNameLabel.Dock = System.Windows.Forms.DockStyle.Right
            Me.fNameLabel.Location = New System.Drawing.Point(3, 3)
            Me.fNameLabel.Name = "fNameLabel"
            Me.tablePanel1.SetRow(Me.fNameLabel, 0)
            Me.fNameLabel.Size = New System.Drawing.Size(77, 24)
            Me.fNameLabel.TabIndex = 2
            Me.fNameLabel.Text = "Text Document:"
            ' 
            ' fileNameEdit
            ' 
            Me.tablePanel1.SetColumn(Me.fileNameEdit, 1)
            Me.fileNameEdit.Location = New System.Drawing.Point(91, 5)
            Me.fileNameEdit.Margin = New System.Windows.Forms.Padding(8, 3, 8, 3)
            Me.fileNameEdit.Name = "fileNameEdit"
            Me.fileNameEdit.Properties.NullValuePrompt = "Select a Text Document..."
            Me.tablePanel1.SetRow(Me.fileNameEdit, 0)
            Me.fileNameEdit.Size = New System.Drawing.Size(767, 20)
            Me.fileNameEdit.TabIndex = 1
            ' 
            ' btnOpenFile
            ' 
            Me.tablePanel1.SetColumn(Me.btnOpenFile, 2)
            Me.btnOpenFile.Location = New System.Drawing.Point(869, 3)
            Me.btnOpenFile.Name = "btnOpenFile"
            Me.tablePanel1.SetRow(Me.btnOpenFile, 0)
            Me.btnOpenFile.Size = New System.Drawing.Size(120, 24)
            Me.btnOpenFile.TabIndex = 0
            Me.btnOpenFile.Text = "Open Text Document"
            AddHandler Me.btnOpenFile.Click, New System.EventHandler(AddressOf Me.btnOpenFile_Click)
            ' 
            ' topPanel
            ' 
            Me.topPanel.AllowResize = False
            Me.topPanel.Controls.Add(Me.toolbarPanel)
            Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.topPanel.Location = New System.Drawing.Point(0, 0)
            Me.topPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.topPanel.Name = "topPanel"
            Me.topPanel.Padding = New System.Windows.Forms.Padding(12, 8, 12, 8)
            Me.topPanel.Size = New System.Drawing.Size(1016, 48)
            Me.topPanel.TabIndex = 5
            ' 
            ' rightPanel
            ' 
            Me.rightPanel.Controls.Add(Me.panelControl)
            Me.rightPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.rightPanel.Location = New System.Drawing.Point(587, 48)
            Me.rightPanel.Name = "rightPanel"
            Me.rightPanel.Size = New System.Drawing.Size(429, 276)
            Me.rightPanel.TabIndex = 6
            Me.rightPanel.Text = "sidePanel1"
            ' 
            ' panelControl
            ' 
            Me.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl.Location = New System.Drawing.Point(1, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(428, 276)
            Me.panelControl.TabIndex = 0
            ' 
            ' CustomDialogLayout
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.rightPanel)
            Me.Controls.Add(Me.leftPanel)
            Me.Controls.Add(Me.bottomPanel)
            Me.Controls.Add(Me.topPanel)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "CustomDialogLayout"
            Me.Size = New System.Drawing.Size(1016, 397)
            CType((Me.fileExplorerAssistant), System.ComponentModel.ISupportInitialize).EndInit()
            Me.leftPanel.ResumeLayout(False)
            CType((Me.treeList), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toolbarPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.toolbarPanel.ResumeLayout(False)
            Me.toolbarPanel.PerformLayout()
            CType((Me.currentPathEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.bottomPanel.ResumeLayout(False)
            CType((Me.tablePanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tablePanel1.ResumeLayout(False)
            Me.tablePanel1.PerformLayout()
            CType((Me.fileNameEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.topPanel.ResumeLayout(False)
            Me.topPanel.PerformLayout()
            Me.rightPanel.ResumeLayout(False)
            CType((Me.panelControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private fileExplorerAssistant As DevExpress.XtraDialogs.FileExplorerAssistant

        Private leftPanel As DevExpress.XtraEditors.SidePanel

        Private treeList As DevExpress.XtraTreeList.TreeList

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private toolbarPanel As DevExpress.Utils.Layout.TablePanel

        Private btnBack As DevExpress.XtraEditors.SimpleButton

        Private currentPathEdit As DevExpress.XtraEditors.BreadCrumbEdit

        Private btnForward As DevExpress.XtraEditors.SimpleButton

        Private btnUp As DevExpress.XtraEditors.SimpleButton

        Private searchBox As DevExpress.XtraEditors.SearchControl

        Private bottomPanel As DevExpress.XtraEditors.SidePanel

        Private topPanel As DevExpress.XtraEditors.SidePanel

        Private tablePanel1 As DevExpress.Utils.Layout.TablePanel

        Private fileNameEdit As DevExpress.XtraEditors.TextEdit

        Private btnOpenFile As DevExpress.XtraEditors.SimpleButton

        Private fNameLabel As DevExpress.XtraEditors.LabelControl

        Private rightPanel As DevExpress.XtraEditors.SidePanel

        Private panelControl As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
