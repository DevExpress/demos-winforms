Namespace DevExpress.MVVM.Demos.Views
    Partial Public Class TableCollectionViewModule
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
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.sourceCode = New DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.viewItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sourceCodeItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitter = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.viewItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sourceCodeItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh})
            Me.ribbonControl1.Location = New System.Drawing.Point(5, 0)
            Me.ribbonControl1.MaxItemId = 8
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False
            Me.ribbonControl1.Size = New System.Drawing.Size(779, 116)
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            ' 
            ' bbiNew
            ' 
            Me.bbiNew.Caption = "New"
            Me.bbiNew.Id = 1
            Me.bbiNew.ImageOptions.SvgImage = Global.My.Resources.Resources._new
            Me.bbiNew.Name = "bbiNew"
            ' 
            ' bbiEdit
            ' 
            Me.bbiEdit.Caption = "Edit"
            Me.bbiEdit.Enabled = False
            Me.bbiEdit.Id = 2
            Me.bbiEdit.ImageOptions.SvgImage = Global.My.Resources.Resources.Action_Edit
            Me.bbiEdit.Name = "bbiEdit"
            ' 
            ' bbiDelete
            ' 
            Me.bbiDelete.Caption = "Delete"
            Me.bbiDelete.Enabled = False
            Me.bbiDelete.Id = 3
            Me.bbiDelete.ImageOptions.SvgImage = Global.My.Resources.Resources.Action_Delete
            Me.bbiDelete.Name = "bbiDelete"
            ' 
            ' bbiRefresh
            ' 
            Me.bbiRefresh.Caption = "Refresh"
            Me.bbiRefresh.Id = 4
            Me.bbiRefresh.ImageOptions.SvgImage = Global.My.Resources.Resources.Refresh
            Me.bbiRefresh.Name = "bbiRefresh"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ACCOUNTS"
            ' 
            ' ribbonPageGroup1
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
            ' gridControl
            ' 
            Me.gridControl.Location = New System.Drawing.Point(2, 2)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.MenuManager = Me.ribbonControl1
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(775, 97)
            Me.gridControl.TabIndex = 2
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            ' 
            ' gridView
            ' 
            Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsBehavior.ReadOnly = True
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel), "Refresh", Me.bbiRefresh)})
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.MVVM.Demos.ViewModels.AccountCollectionViewModel)
            ' 
            ' sourceCode
            ' 
            Me.sourceCode.CurrentNestedType = Nothing
            Me.sourceCode.Location = New System.Drawing.Point(0, 106)
            Me.sourceCode.Margin = New System.Windows.Forms.Padding(0)
            Me.sourceCode.Name = "sourceCode"
            Me.sourceCode.RichText = ""
            Me.sourceCode.Size = New System.Drawing.Size(779, 205)
            Me.sourceCode.TabIndex = 4
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.gridControl)
            Me.layoutControl1.Controls.Add(Me.sourceCode)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(5, 116)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(779, 311)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.viewItem, Me.sourceCodeItem, Me.splitter})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(779, 311)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' viewItem
            ' 
            Me.viewItem.Control = Me.gridControl
            Me.viewItem.Location = New System.Drawing.Point(0, 0)
            Me.viewItem.Name = "viewItem"
            Me.viewItem.Size = New System.Drawing.Size(779, 101)
            Me.viewItem.TextSize = New System.Drawing.Size(0, 0)
            Me.viewItem.TextVisible = False
            ' 
            ' sourceCodeItem
            ' 
            Me.sourceCodeItem.Control = Me.sourceCode
            Me.sourceCodeItem.Location = New System.Drawing.Point(0, 106)
            Me.sourceCodeItem.Name = "sourceCodeItem"
            Me.sourceCodeItem.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.sourceCodeItem.Size = New System.Drawing.Size(779, 205)
            Me.sourceCodeItem.TextSize = New System.Drawing.Size(0, 0)
            Me.sourceCodeItem.TextVisible = False
            ' 
            ' splitter
            ' 
            Me.splitter.AllowHotTrack = True
            Me.splitter.Location = New System.Drawing.Point(0, 101)
            Me.splitter.Name = "splitter"
            Me.splitter.Size = New System.Drawing.Size(779, 5)
            ' 
            ' TableCollectionViewModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "TableCollectionViewModule"
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.viewItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sourceCodeItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
        Private bbiNew As XtraBars.BarButtonItem
        Private bbiEdit As XtraBars.BarButtonItem
        Private bbiDelete As XtraBars.BarButtonItem
        Private bbiRefresh As XtraBars.BarButtonItem
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private gridControl As XtraGrid.GridControl
        Private gridView As XtraGrid.Views.Grid.GridView
        Private mvvmContext As Utils.MVVM.MVVMContext
        Private sourceCode As DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private viewItem As XtraLayout.LayoutControlItem
        Private sourceCodeItem As XtraLayout.LayoutControlItem
        Private splitter As XtraLayout.SplitterItem
    End Class
End Namespace
