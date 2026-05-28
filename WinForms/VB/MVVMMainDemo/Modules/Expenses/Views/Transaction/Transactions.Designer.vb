Namespace DevExpress.MVVM.Demos.Views
	Partial Public Class Transactions
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
			Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
			Me.bbiNew = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl
            ' 
            Me.gridControl.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 117)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(640, 283)
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
            Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionCollectionViewModel), "New", Me.bbiNew), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionCollectionViewModel), "Edit", "SelectedEntity", Me.bbiEdit), DevExpress.Utils.MVVM.BindingExpression.CreateParameterizedCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionCollectionViewModel), "Delete", "SelectedEntity", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionCollectionViewModel), "Close", Me.bbiClose)})
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.MVVM.Demos.ViewModels.TransactionCollectionViewModel)
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
            ' bbiClose
            ' 
            Me.bbiClose.Caption = "Close"
            Me.bbiClose.Id = 6
            Me.bbiClose.ImageOptions.SvgImage = Global.My.Resources.Resources.clearheaderandfooter
            Me.bbiClose.Name = "bbiClose"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.AutoHiddenPagesMenuItem, Me.bbiNew, Me.bbiEdit, Me.bbiDelete, Me.bbiClose})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 8
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False
            Me.ribbonControl1.Size = New System.Drawing.Size(640, 117)
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "TRANSACTIONS"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiNew)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiEdit)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiDelete)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiClose)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "Actions"
            ' 
            ' Transactions
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Transactions"
            Me.Size = New System.Drawing.Size(640, 400)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridControl As DevExpress.XtraGrid.GridControl
		Private gridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private bbiNew As XtraBars.BarButtonItem
		Private bbiEdit As XtraBars.BarButtonItem
		Private bbiDelete As XtraBars.BarButtonItem
		Private bbiClose As XtraBars.BarButtonItem
		Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
	End Class
End Namespace
