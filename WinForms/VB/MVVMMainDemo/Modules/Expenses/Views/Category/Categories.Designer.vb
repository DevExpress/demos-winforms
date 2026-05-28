Namespace DevExpress.MVVM.Demos.Views
    Partial Public Class Categories
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
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.categoryCollectionViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.bbiPrintPreview = New DevExpress.XtraBars.BarButtonItem()
            Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
            Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoryCollectionViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.DataSource = Me.categoryCollectionViewBindingSource
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 116)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.MenuManager = Me.ribbonControl
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(1026, 649)
            Me.gridControl.TabIndex = 2
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'categoryCollectionViewBindingSource
            '
            Me.categoryCollectionViewBindingSource.DataSource = GetType(DevExpress.MVVM.Demos.Model.Category)
            '
            'gridView
            '
            Me.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsBehavior.ReadOnly = True
            '
            'gridColumn1
            '
            Me.gridColumn1.FieldName = "Name"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            '
            'gridColumn2
            '
            Me.gridColumn2.FieldName = "Type"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            '
            'ribbonControl
            '
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.bbiPrintPreview, Me.bsiRecordsCount, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiRefresh})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 20
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.Size = New System.Drawing.Size(1026, 116)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar
            Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            '
            'bbiPrintPreview
            '
            Me.bbiPrintPreview.Caption = "Print Preview"
            Me.bbiPrintPreview.Id = 14
            Me.bbiPrintPreview.ImageOptions.SvgImage = Global.My.Resources.Resources.PrintingPreview
            Me.bbiPrintPreview.Name = "bbiPrintPreview"
            '
            'bsiRecordsCount
            '
            Me.bsiRecordsCount.Caption = "RECORDS : 2"
            Me.bsiRecordsCount.Id = 15
            Me.bsiRecordsCount.Name = "bsiRecordsCount"
            Me.bsiRecordsCount.TextAlignment = System.Drawing.StringAlignment.Near
            '
            'bbiNew
            '
            Me.bbiNew.Caption = "New"
            Me.bbiNew.Id = 16
            Me.bbiNew.ImageOptions.SvgImage = Global.My.Resources.Resources._new
            Me.bbiNew.Name = "bbiNew"
            '
            'bbiEdit
            '
            Me.bbiEdit.Caption = "Edit"
            Me.bbiEdit.Id = 17
            Me.bbiEdit.ImageOptions.SvgImage = Global.My.Resources.Resources.Action_Edit
            Me.bbiEdit.Name = "bbiEdit"
            '
            'bbiDelete
            '
            Me.bbiDelete.Caption = "Delete"
            Me.bbiDelete.Id = 18
            Me.bbiDelete.ImageOptions.SvgImage = Global.My.Resources.Resources.Action_Delete
            Me.bbiDelete.Name = "bbiDelete"
            '
            'bbiRefresh
            '
            Me.bbiRefresh.Caption = "Refresh"
            Me.bbiRefresh.Id = 19
            Me.bbiRefresh.ImageOptions.SvgImage = Global.My.Resources.Resources.Refresh
            Me.bbiRefresh.Name = "bbiRefresh"
            '
            'ribbonPage1
            '
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2})
            Me.ribbonPage1.MergeOrder = 0
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
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
            Me.ribbonPageGroup1.Text = "Category Tasks"
            '
            'ribbonPageGroup2
            '
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.ItemLinks.Add(Me.bbiPrintPreview)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.ShowCaptionButton = False
            Me.ribbonPageGroup2.Text = "Print and Export"
            '
            'ribbonStatusBar
            '
            Me.ribbonStatusBar.ItemLinks.Add(Me.bsiRecordsCount)
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 738)
            Me.ribbonStatusBar.Name = "ribbonStatusBar"
            Me.ribbonStatusBar.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar.Size = New System.Drawing.Size(1026, 27)
            '
            'mvvmContext
            '
            Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.CategoryCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.CategoryCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.CategoryCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.CategoryCollectionViewModel), "Refresh", Me.bbiRefresh)})
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.RegistrationExpressions.AddRange(New DevExpress.Utils.MVVM.RegistrationExpression() {DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(Nothing, False, DevExpress.Utils.DefaultBoolean.[Default], Me.gridControl), DevExpress.Utils.MVVM.RegistrationExpression.RegisterWindowedDocumentManagerService(Nothing, False, Me, DevExpress.Utils.MVVM.Services.DefaultWindowedDocumentManagerServiceType.XtraForm, Nothing)})
            Me.mvvmContext.ViewModelType = GetType(DevExpress.MVVM.Demos.ViewModels.CategoryCollectionViewModel)
            '
            'popupMenu
            '
            Me.popupMenu.ItemLinks.Add(Me.bbiNew)
            Me.popupMenu.ItemLinks.Add(Me.bbiEdit)
            Me.popupMenu.ItemLinks.Add(Me.bbiDelete)
            Me.popupMenu.ItemLinks.Add(Me.bbiRefresh)
            Me.popupMenu.Name = "popupMenu"
            Me.popupMenu.Ribbon = Me.ribbonControl
            '
            'Categories
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ribbonStatusBar)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.ribbonControl)
            Me.Name = "Categories"
            Me.Size = New System.Drawing.Size(1026, 765)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoryCollectionViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private gridControl As DevExpress.XtraGrid.GridControl
        Private gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private categoryCollectionViewBindingSource As System.Windows.Forms.BindingSource
        Private bbiPrintPreview As DevExpress.XtraBars.BarButtonItem
        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Private bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
        Private popupMenu As DevExpress.XtraBars.PopupMenu
        Private gridColumn1 As XtraGrid.Columns.GridColumn
        Private gridColumn2 As XtraGrid.Columns.GridColumn
        Private bbiNew As XtraBars.BarButtonItem
        Private bbiEdit As XtraBars.BarButtonItem
        Private bbiDelete As XtraBars.BarButtonItem
        Private bbiRefresh As XtraBars.BarButtonItem
    End Class
End Namespace
