Namespace DevExpress.MVVM.Demos.Views
	Partial Public Class TransactionEditForm
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
            Me.dataLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.AccountIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.accountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.CategoryIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
            Me.categoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.DateDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.AmountSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.CommentMemoExEdit = New DevExpress.XtraEditors.MemoEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForAccountID = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForCategoryID = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAmount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForComment = New DevExpress.XtraLayout.LayoutControlItem()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiSaveAndNew = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiReset = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayout.SuspendLayout()
            CType(Me.AccountIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.accountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CategoryIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AmountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CommentMemoExEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForAccountID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForCategoryID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForComment, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dataLayout
            '
            Me.dataLayout.Controls.Add(Me.AccountIDLookUpEdit)
            Me.dataLayout.Controls.Add(Me.CategoryIDLookUpEdit)
            Me.dataLayout.Controls.Add(Me.DateDateEdit)
            Me.dataLayout.Controls.Add(Me.AmountSpinEdit)
            Me.dataLayout.Controls.Add(Me.CommentMemoExEdit)
            Me.dataLayout.DataSource = Me.bindingSource
            Me.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayout.Location = New System.Drawing.Point(0, 116)
            Me.dataLayout.Name = "dataLayout"
            Me.dataLayout.Root = Me.Root
            Me.dataLayout.Size = New System.Drawing.Size(640, 284)
            Me.dataLayout.TabIndex = 0
            Me.dataLayout.Text = "dataLayoutControl1"
            '
            'AccountIDLookUpEdit
            '
            Me.AccountIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "AccountID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.AccountIDLookUpEdit.Location = New System.Drawing.Point(60, 12)
            Me.AccountIDLookUpEdit.Name = "AccountIDLookUpEdit"
            Me.AccountIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.AccountIDLookUpEdit.Properties.DataSource = Me.accountBindingSource
            Me.AccountIDLookUpEdit.Properties.ValueMember = "ID"
            Me.AccountIDLookUpEdit.Size = New System.Drawing.Size(568, 20)
            Me.AccountIDLookUpEdit.StyleController = Me.dataLayout
            Me.AccountIDLookUpEdit.TabIndex = 4
            '
            'bindingSource
            '
            Me.bindingSource.DataSource = GetType(DevExpress.MVVM.Demos.Model.Transaction)
            '
            'accountBindingSource
            '
            Me.accountBindingSource.DataSource = GetType(DevExpress.MVVM.Demos.Model.Account)
            '
            'CategoryIDLookUpEdit
            '
            Me.CategoryIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "CategoryID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.CategoryIDLookUpEdit.Location = New System.Drawing.Point(60, 36)
            Me.CategoryIDLookUpEdit.Name = "CategoryIDLookUpEdit"
            Me.CategoryIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.CategoryIDLookUpEdit.Properties.DataSource = Me.categoryBindingSource
            Me.CategoryIDLookUpEdit.Properties.ValueMember = "ID"
            Me.CategoryIDLookUpEdit.Size = New System.Drawing.Size(568, 20)
            Me.CategoryIDLookUpEdit.StyleController = Me.dataLayout
            Me.CategoryIDLookUpEdit.TabIndex = 5
            '
            'categoryBindingSource
            '
            Me.categoryBindingSource.DataSource = GetType(DevExpress.MVVM.Demos.Model.Category)
            '
            'DateDateEdit
            '
            Me.DateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Date", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.DateDateEdit.EditValue = Nothing
            Me.DateDateEdit.Location = New System.Drawing.Point(60, 60)
            Me.DateDateEdit.Name = "DateDateEdit"
            Me.DateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateDateEdit.Size = New System.Drawing.Size(568, 20)
            Me.DateDateEdit.StyleController = Me.dataLayout
            Me.DateDateEdit.TabIndex = 6
            '
            'AmountSpinEdit
            '
            Me.AmountSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Amount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.AmountSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.AmountSpinEdit.Location = New System.Drawing.Point(60, 84)
            Me.AmountSpinEdit.Name = "AmountSpinEdit"
            Me.AmountSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.AmountSpinEdit.Size = New System.Drawing.Size(568, 20)
            Me.AmountSpinEdit.StyleController = Me.dataLayout
            Me.AmountSpinEdit.TabIndex = 7
            '
            'CommentMemoExEdit
            '
            Me.CommentMemoExEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Comment", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.CommentMemoExEdit.Location = New System.Drawing.Point(60, 108)
            Me.CommentMemoExEdit.Name = "CommentMemoExEdit"
            Me.CommentMemoExEdit.Size = New System.Drawing.Size(568, 164)
            Me.CommentMemoExEdit.StyleController = Me.dataLayout
            Me.CommentMemoExEdit.TabIndex = 8
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(640, 284)
            Me.Root.TextVisible = False
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForAccountID, Me.ItemForCategoryID, Me.ItemForDate, Me.ItemForAmount, Me.ItemForComment})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(620, 264)
            '
            'ItemForAccountID
            '
            Me.ItemForAccountID.Control = Me.AccountIDLookUpEdit
            Me.ItemForAccountID.Location = New System.Drawing.Point(0, 0)
            Me.ItemForAccountID.Name = "ItemForAccountID"
            Me.ItemForAccountID.Size = New System.Drawing.Size(620, 24)
            Me.ItemForAccountID.Text = "Account"
            Me.ItemForAccountID.TextSize = New System.Drawing.Size(45, 13)
            '
            'ItemForCategoryID
            '
            Me.ItemForCategoryID.Control = Me.CategoryIDLookUpEdit
            Me.ItemForCategoryID.Location = New System.Drawing.Point(0, 24)
            Me.ItemForCategoryID.Name = "ItemForCategoryID"
            Me.ItemForCategoryID.Size = New System.Drawing.Size(620, 24)
            Me.ItemForCategoryID.Text = "Category"
            Me.ItemForCategoryID.TextSize = New System.Drawing.Size(45, 13)
            '
            'ItemForDate
            '
            Me.ItemForDate.Control = Me.DateDateEdit
            Me.ItemForDate.Location = New System.Drawing.Point(0, 48)
            Me.ItemForDate.Name = "ItemForDate"
            Me.ItemForDate.Size = New System.Drawing.Size(620, 24)
            Me.ItemForDate.Text = "Date"
            Me.ItemForDate.TextSize = New System.Drawing.Size(45, 13)
            '
            'ItemForAmount
            '
            Me.ItemForAmount.Control = Me.AmountSpinEdit
            Me.ItemForAmount.Location = New System.Drawing.Point(0, 72)
            Me.ItemForAmount.Name = "ItemForAmount"
            Me.ItemForAmount.Size = New System.Drawing.Size(620, 24)
            Me.ItemForAmount.Text = "Amount"
            Me.ItemForAmount.TextSize = New System.Drawing.Size(45, 13)
            '
            'ItemForComment
            '
            Me.ItemForComment.Control = Me.CommentMemoExEdit
            Me.ItemForComment.Location = New System.Drawing.Point(0, 96)
            Me.ItemForComment.Name = "ItemForComment"
            Me.ItemForComment.Size = New System.Drawing.Size(620, 168)
            Me.ItemForComment.Text = "Comment"
            Me.ItemForComment.TextSize = New System.Drawing.Size(45, 13)
            '
            'mvvmContext
            '
            Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "SaveAndClose", Me.bbiSaveAndClose), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "SaveAndNew", Me.bbiSaveAndNew), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Reset", Me.bbiReset), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Delete", Me.bbiDelete), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Close", Me.bbiClose)})
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel)
            '
            'bbiSave
            '
            Me.bbiSave.Caption = "Save"
            Me.bbiSave.Enabled = False
            Me.bbiSave.Id = 2
            Me.bbiSave.ImageOptions.SvgImage = Global.My.Resources.Resources.Save
            Me.bbiSave.Name = "bbiSave"
            '
            'bbiSaveAndClose
            '
            Me.bbiSaveAndClose.Caption = "SaveAndClose"
            Me.bbiSaveAndClose.Enabled = False
            Me.bbiSaveAndClose.Id = 3
            Me.bbiSaveAndClose.ImageOptions.SvgImage = Global.My.Resources.Resources.saveandclose
            Me.bbiSaveAndClose.Name = "bbiSaveAndClose"
            '
            'bbiSaveAndNew
            '
            Me.bbiSaveAndNew.Caption = "SaveAndNew"
            Me.bbiSaveAndNew.Enabled = False
            Me.bbiSaveAndNew.Id = 4
            Me.bbiSaveAndNew.ImageOptions.SvgImage = Global.My.Resources.Resources.saveas
            Me.bbiSaveAndNew.Name = "bbiSaveAndNew"
            '
            'bbiReset
            '
            Me.bbiReset.Caption = "Reset Changes"
            Me.bbiReset.Enabled = False
            Me.bbiReset.Id = 5
            Me.bbiReset.ImageOptions.SvgImage = Global.My.Resources.Resources.ResetView
            Me.bbiReset.Name = "bbiReset"
            '
            'bbiDelete
            '
            Me.bbiDelete.Caption = "Delete"
            Me.bbiDelete.Enabled = False
            Me.bbiDelete.Id = 6
            Me.bbiDelete.ImageOptions.SvgImage = Global.My.Resources.Resources.Action_Delete
            Me.bbiDelete.Name = "bbiDelete"
            '
            'bbiClose
            '
            Me.bbiClose.Caption = "Close"
            Me.bbiClose.Id = 7
            Me.bbiClose.ImageOptions.SvgImage = Global.My.Resources.Resources.clearheaderandfooter
            Me.bbiClose.Name = "bbiClose"
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.bbiSave, Me.bbiSaveAndClose, Me.bbiSaveAndNew, Me.bbiReset, Me.bbiDelete, Me.bbiClose})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 8
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl1.Size = New System.Drawing.Size(640, 116)
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            '
            'ribbonPage1
            '
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup3, Me.ribbonPageGroup4})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "TRANSACTION"
            '
            'ribbonPageGroup1
            '
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiSave)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiSaveAndClose)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiSaveAndNew)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "Save"
            '
            'ribbonPageGroup3
            '
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.ItemLinks.Add(Me.bbiReset)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.bbiDelete)
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.ShowCaptionButton = False
            Me.ribbonPageGroup3.Text = "Edit"
            '
            'ribbonPageGroup4
            '
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.ItemLinks.Add(Me.bbiClose)
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "Close"
            '
            'TransactionEditForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
            Me.Controls.Add(Me.dataLayout)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "TransactionEditForm"
            Me.Size = New System.Drawing.Size(640, 400)
            CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayout.ResumeLayout(False)
            CType(Me.AccountIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.accountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CategoryIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AmountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CommentMemoExEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForAccountID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForCategoryID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForComment, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
		Private dataLayout As DevExpress.XtraDataLayout.DataLayoutControl
		Private Root As DevExpress.XtraLayout.LayoutControlGroup
		Private bindingSource As System.Windows.Forms.BindingSource
		Private AccountIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
		Private CategoryIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
		Private DateDateEdit As DevExpress.XtraEditors.DateEdit
		Private AmountSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private CommentMemoExEdit As DevExpress.XtraEditors.MemoEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private ItemForAccountID As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForCategoryID As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForDate As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForAmount As DevExpress.XtraLayout.LayoutControlItem
		Private ItemForComment As DevExpress.XtraLayout.LayoutControlItem
		Private accountBindingSource As System.Windows.Forms.BindingSource
		Private categoryBindingSource As System.Windows.Forms.BindingSource
		Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
		Private bbiSave As XtraBars.BarButtonItem
		Private bbiSaveAndClose As XtraBars.BarButtonItem
		Private bbiSaveAndNew As XtraBars.BarButtonItem
		Private bbiReset As XtraBars.BarButtonItem
		Private bbiDelete As XtraBars.BarButtonItem
		Private bbiClose As XtraBars.BarButtonItem
		Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
	End Class
End Namespace
