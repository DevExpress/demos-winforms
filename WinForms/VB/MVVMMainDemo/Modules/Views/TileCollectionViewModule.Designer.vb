Namespace DevExpress.MVVM.Demos.Views
	Partial Public Class TileCollectionViewModule
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
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
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.tileGroup2 = New DevExpress.XtraEditors.TileGroup()
            Me.tileControl1 = New DevExpress.XtraEditors.TileControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sourceCode = New DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.sourceCodeItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitter = New DevExpress.XtraLayout.SplitterItem()
            Me.viewItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sourceCodeItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.viewItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'mvvmContext
            '
            Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Refresh", Me.bbiRefresh)})
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel)
            '
            'bbiNew
            '
            Me.bbiNew.Caption = "New"
            Me.bbiNew.Id = 1
            Me.bbiNew.ImageOptions.SvgImage = Global.My.Resources.Resources._new
            Me.bbiNew.Name = "bbiNew"
            '
            'bbiEdit
            '
            Me.bbiEdit.Caption = "Edit"
            Me.bbiEdit.Enabled = False
            Me.bbiEdit.Id = 2
            Me.bbiEdit.ImageOptions.SvgImage = Global.My.Resources.Resources.Action_Edit
            Me.bbiEdit.Name = "bbiEdit"
            '
            'bbiDelete
            '
            Me.bbiDelete.Caption = "Delete"
            Me.bbiDelete.Enabled = False
            Me.bbiDelete.Id = 3
            Me.bbiDelete.ImageOptions.SvgImage = Global.My.Resources.Resources.Action_Delete
            Me.bbiDelete.Name = "bbiDelete"
            '
            'bbiRefresh
            '
            Me.bbiRefresh.Caption = "Refresh"
            Me.bbiRefresh.Id = 4
            Me.bbiRefresh.ImageOptions.SvgImage = Global.My.Resources.Resources.Refresh
            Me.bbiRefresh.Name = "bbiRefresh"
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh})
            Me.ribbonControl1.Location = New System.Drawing.Point(5, 0)
            Me.ribbonControl1.MaxItemId = 8
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl1.Size = New System.Drawing.Size(779, 116)
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            '
            'ribbonPage1
            '
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ACCOUNTS"
            '
            'ribbonPageGroup1
            '
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiNew)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiEdit)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiDelete)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiRefresh)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "Actions"
            '
            'tileGroup2
            '
            Me.tileGroup2.Name = "tileGroup2"
            '
            'tileControl1
            '
            Me.tileControl1.AllowSelectedItem = True
            Me.tileControl1.DragSize = New System.Drawing.Size(0, 0)
            Me.tileControl1.Groups.Add(Me.tileGroup2)
            Me.tileControl1.Location = New System.Drawing.Point(2, 2)
            Me.tileControl1.Name = "tileControl1"
            Me.tileControl1.Size = New System.Drawing.Size(775, 172)
            Me.tileControl1.TabIndex = 0
            Me.tileControl1.Text = "tileControl1"
            '
            'layoutControl1
            '
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.tileControl1)
            Me.layoutControl1.Controls.Add(Me.sourceCode)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(5, 116)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(779, 311)
            Me.layoutControl1.TabIndex = 6
            Me.layoutControl1.Text = "layoutControl1"
            '
            'sourceCode
            '
            Me.sourceCode.CurrentNestedType = Nothing
            Me.sourceCode.Location = New System.Drawing.Point(0, 181)
            Me.sourceCode.Margin = New System.Windows.Forms.Padding(0)
            Me.sourceCode.Name = "sourceCode"
            Me.sourceCode.RichText = ""
            Me.sourceCode.Size = New System.Drawing.Size(779, 130)
            Me.sourceCode.TabIndex = 4
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.sourceCodeItem, Me.splitter, Me.viewItem})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(779, 311)
            Me.layoutControlGroup1.TextVisible = False
            '
            'sourceCodeItem
            '
            Me.sourceCodeItem.Control = Me.sourceCode
            Me.sourceCodeItem.Location = New System.Drawing.Point(0, 181)
            Me.sourceCodeItem.Name = "sourceCodeItem"
            Me.sourceCodeItem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.sourceCodeItem.Size = New System.Drawing.Size(779, 130)
            Me.sourceCodeItem.TextSize = New System.Drawing.Size(0, 0)
            Me.sourceCodeItem.TextVisible = False
            '
            'splitter
            '
            Me.splitter.AllowHotTrack = True
            Me.splitter.Location = New System.Drawing.Point(0, 176)
            Me.splitter.Name = "splitter"
            Me.splitter.Size = New System.Drawing.Size(779, 5)
            '
            'viewItem
            '
            Me.viewItem.Control = Me.tileControl1
            Me.viewItem.Location = New System.Drawing.Point(0, 0)
            Me.viewItem.Name = "viewItem"
            Me.viewItem.Size = New System.Drawing.Size(779, 176)
            Me.viewItem.TextSize = New System.Drawing.Size(0, 0)
            Me.viewItem.TextVisible = False
            '
            'TileCollectionViewModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "TileCollectionViewModule"
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sourceCodeItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.viewItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private mvvmContext As Utils.MVVM.MVVMContext
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private bbiNew As XtraBars.BarButtonItem
		Private bbiEdit As XtraBars.BarButtonItem
		Private bbiDelete As XtraBars.BarButtonItem
		Private bbiRefresh As XtraBars.BarButtonItem
		Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
		Private tileControl1 As XtraEditors.TileControl
		Private tileGroup2 As XtraEditors.TileGroup
		Private layoutControl1 As XtraLayout.LayoutControl
		Private sourceCode As DXperience.Demos.CodeDemo.RichEditUserControl
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private sourceCodeItem As XtraLayout.LayoutControlItem
		Private splitter As XtraLayout.SplitterItem
		Private viewItem As XtraLayout.LayoutControlItem
	End Class
End Namespace
