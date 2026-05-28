Namespace DevExpress.MVVM.Demos.Views
    Partial Public Class DataLayoutViewModule
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
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.sourceCode = New DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl()
            Me.AccountLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
            Me.transactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.accountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.CategoryLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
            Me.categoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.DateDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.AmountTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.CommentMemoEdit = New DevExpress.XtraEditors.MemoEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForAccount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForCategory = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAmount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForComment = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiReset = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType(Me.AccountLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.accountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CategoryLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CommentMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForAccount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForCategory, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForComment, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.AllowCustomization = False
            Me.dataLayoutControl1.Controls.Add(Me.sourceCode)
            Me.dataLayoutControl1.Controls.Add(Me.AccountLookUpEdit)
            Me.dataLayoutControl1.Controls.Add(Me.CategoryLookUpEdit)
            Me.dataLayoutControl1.Controls.Add(Me.DateDateEdit)
            Me.dataLayoutControl1.Controls.Add(Me.AmountTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.CommentMemoEdit)
            Me.dataLayoutControl1.DataSource = Me.transactionBindingSource
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Location = New System.Drawing.Point(5, 116)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
            Me.dataLayoutControl1.Size = New System.Drawing.Size(779, 311)
            Me.dataLayoutControl1.TabIndex = 0
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' sourceCode
            ' 
            Me.sourceCode.CurrentNestedType = Nothing
            Me.sourceCode.Location = New System.Drawing.Point(12, 203)
            Me.sourceCode.Margin = New System.Windows.Forms.Padding(0)
            Me.sourceCode.Name = "sourceCode"
            Me.sourceCode.RichText = ""
            Me.sourceCode.Size = New System.Drawing.Size(755, 96)
            Me.sourceCode.TabIndex = 6
            ' 
            ' AccountLookUpEdit
            ' 
            Me.AccountLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.transactionBindingSource, "AccountID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.AccountLookUpEdit.Location = New System.Drawing.Point(69, 12)
            Me.AccountLookUpEdit.Name = "AccountLookUpEdit"
            Me.AccountLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.AccountLookUpEdit.Properties.DataSource = Me.accountBindingSource
            Me.AccountLookUpEdit.Properties.NullText = ""
            Me.AccountLookUpEdit.Properties.ValueMember = "ID"
            Me.AccountLookUpEdit.Size = New System.Drawing.Size(698, 20)
            Me.AccountLookUpEdit.StyleController = Me.dataLayoutControl1
            Me.AccountLookUpEdit.TabIndex = 4
            ' 
            ' transactionBindingSource
            ' 
            Me.transactionBindingSource.DataSource = GetType(DevExpress.MVVM.Demos.Model.Transaction)
            ' 
            ' accountBindingSource
            ' 
            Me.accountBindingSource.DataSource = GetType(DevExpress.MVVM.Demos.Model.Account)
            ' 
            ' CategoryLookUpEdit
            ' 
            Me.CategoryLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.transactionBindingSource, "CategoryID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.CategoryLookUpEdit.Location = New System.Drawing.Point(69, 36)
            Me.CategoryLookUpEdit.Name = "CategoryLookUpEdit"
            Me.CategoryLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.CategoryLookUpEdit.Properties.DataSource = Me.categoryBindingSource
            Me.CategoryLookUpEdit.Properties.NullText = ""
            Me.CategoryLookUpEdit.Properties.ValueMember = "ID"
            Me.CategoryLookUpEdit.Size = New System.Drawing.Size(698, 20)
            Me.CategoryLookUpEdit.StyleController = Me.dataLayoutControl1
            Me.CategoryLookUpEdit.TabIndex = 5
            ' 
            ' categoryBindingSource
            ' 
            Me.categoryBindingSource.DataSource = GetType(DevExpress.MVVM.Demos.Model.Category)
            ' 
            ' DateDateEdit
            ' 
            Me.DateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.transactionBindingSource, "Date", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.DateDateEdit.EditValue = Nothing
            Me.DateDateEdit.Location = New System.Drawing.Point(69, 60)
            Me.DateDateEdit.Name = "DateDateEdit"
            Me.DateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateDateEdit.Properties.NullValuePrompt = Nothing
            Me.DateDateEdit.Size = New System.Drawing.Size(698, 20)
            Me.DateDateEdit.StyleController = Me.dataLayoutControl1
            Me.DateDateEdit.TabIndex = 6
            ' 
            ' AmountTextEdit
            ' 
            Me.AmountTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.transactionBindingSource, "Amount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.AmountTextEdit.Location = New System.Drawing.Point(69, 84)
            Me.AmountTextEdit.Name = "AmountTextEdit"
            Me.AmountTextEdit.Properties.Mask.EditMask = "c"
            Me.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.AmountTextEdit.Properties.NullValuePrompt = Nothing
            Me.AmountTextEdit.Size = New System.Drawing.Size(698, 20)
            Me.AmountTextEdit.StyleController = Me.dataLayoutControl1
            Me.AmountTextEdit.TabIndex = 7
            ' 
            ' CommentMemoEdit
            ' 
            Me.CommentMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.transactionBindingSource, "Comment", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.CommentMemoEdit.Location = New System.Drawing.Point(69, 108)
            Me.CommentMemoEdit.Name = "CommentMemoEdit"
            Me.CommentMemoEdit.Properties.NullValuePrompt = Nothing
            Me.CommentMemoEdit.Size = New System.Drawing.Size(698, 86)
            Me.CommentMemoEdit.StyleController = Me.dataLayoutControl1
            Me.CommentMemoEdit.TabIndex = 8
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(779, 311)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForAccount, Me.ItemForCategory, Me.ItemForDate, Me.ItemForAmount, Me.ItemForComment, Me.layoutControlItem1, Me.splitterItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(759, 291)
            ' 
            ' ItemForAccount
            ' 
            Me.ItemForAccount.Control = Me.AccountLookUpEdit
            Me.ItemForAccount.Location = New System.Drawing.Point(0, 0)
            Me.ItemForAccount.Name = "ItemForAccount"
            Me.ItemForAccount.Size = New System.Drawing.Size(759, 24)
            Me.ItemForAccount.Text = "ACCOUNT"
            Me.ItemForAccount.TextSize = New System.Drawing.Size(54, 13)
            ' 
            ' ItemForCategory
            ' 
            Me.ItemForCategory.Control = Me.CategoryLookUpEdit
            Me.ItemForCategory.Location = New System.Drawing.Point(0, 24)
            Me.ItemForCategory.Name = "ItemForCategory"
            Me.ItemForCategory.Size = New System.Drawing.Size(759, 24)
            Me.ItemForCategory.Text = "CATEGORY"
            Me.ItemForCategory.TextSize = New System.Drawing.Size(54, 13)
            ' 
            ' ItemForDate
            ' 
            Me.ItemForDate.Control = Me.DateDateEdit
            Me.ItemForDate.Location = New System.Drawing.Point(0, 48)
            Me.ItemForDate.Name = "ItemForDate"
            Me.ItemForDate.Size = New System.Drawing.Size(759, 24)
            Me.ItemForDate.Text = "DATE"
            Me.ItemForDate.TextSize = New System.Drawing.Size(54, 13)
            ' 
            ' ItemForAmount
            ' 
            Me.ItemForAmount.Control = Me.AmountTextEdit
            Me.ItemForAmount.Location = New System.Drawing.Point(0, 72)
            Me.ItemForAmount.Name = "ItemForAmount"
            Me.ItemForAmount.Size = New System.Drawing.Size(759, 24)
            Me.ItemForAmount.Text = "AMOUNT"
            Me.ItemForAmount.TextSize = New System.Drawing.Size(54, 13)
            ' 
            ' ItemForComment
            ' 
            Me.ItemForComment.Control = Me.CommentMemoEdit
            Me.ItemForComment.Location = New System.Drawing.Point(0, 96)
            Me.ItemForComment.Name = "ItemForComment"
            Me.ItemForComment.Size = New System.Drawing.Size(759, 90)
            Me.ItemForComment.StartNewLine = True
            Me.ItemForComment.Text = "COMMENT"
            Me.ItemForComment.TextSize = New System.Drawing.Size(54, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.sourceCode
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 191)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(759, 100)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.Location = New System.Drawing.Point(0, 186)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(759, 5)
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.BindingExpressions.AddRange(New DevExpress.Utils.MVVM.BindingExpression() {DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Save", Me.bbiSave), DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(GetType(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel), "Reset", Me.bbiReset)})
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.MVVM.Demos.ViewModels.TransactionViewModel)
            ' 
            ' bbiSave
            ' 
            Me.bbiSave.Caption = "Save"
            Me.bbiSave.Id = 8
            Me.bbiSave.ImageOptions.SvgImage = Global.My.Resources.Resources.Save
            Me.bbiSave.Name = "bbiSave"
            ' 
            ' bbiReset
            ' 
            Me.bbiReset.Caption = "Reset Changes"
            Me.bbiReset.Id = 11
            Me.bbiReset.ImageOptions.SvgImage = Global.My.Resources.Resources.ResetView
            Me.bbiReset.Name = "bbiReset"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.bbiSave, Me.bbiReset})
            Me.ribbonControl1.Location = New System.Drawing.Point(5, 0)
            Me.ribbonControl1.MaxItemId = 14
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False
            Me.ribbonControl1.Size = New System.Drawing.Size(779, 116)
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "TRANSACTION"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiSave)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiReset)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "Actions"
            ' 
            ' DataLayoutViewModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dataLayoutControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "DataLayoutViewModule"
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType(Me.AccountLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.accountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CategoryLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CommentMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForAccount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForCategory, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForComment, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private dataLayoutControl1 As XtraDataLayout.DataLayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private transactionBindingSource As System.Windows.Forms.BindingSource
        Private AccountLookUpEdit As XtraEditors.LookUpEdit
        Private CategoryLookUpEdit As XtraEditors.LookUpEdit
        Private DateDateEdit As XtraEditors.DateEdit
        Private AmountTextEdit As XtraEditors.TextEdit
        Private CommentMemoEdit As XtraEditors.MemoEdit
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private ItemForAccount As XtraLayout.LayoutControlItem
        Private ItemForCategory As XtraLayout.LayoutControlItem
        Private ItemForDate As XtraLayout.LayoutControlItem
        Private ItemForAmount As XtraLayout.LayoutControlItem
        Private ItemForComment As XtraLayout.LayoutControlItem
        Private accountBindingSource As System.Windows.Forms.BindingSource
        Private categoryBindingSource As System.Windows.Forms.BindingSource
        Private mvvmContext As Utils.MVVM.MVVMContext
        Private bbiSave As XtraBars.BarButtonItem
        Private bbiReset As XtraBars.BarButtonItem
        Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private sourceCode As DXperience.Demos.CodeDemo.RichEditUserControl
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private splitterItem1 As XtraLayout.SplitterItem
    End Class
End Namespace
