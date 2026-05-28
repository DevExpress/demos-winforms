Namespace DevExpress.MVVM.Demos.Views
    Partial Public Class AccountEditForm
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
            Me.NameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.AmountSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.Transaction_DetailsUserControl = New DevExpress.XtraEditors.XtraUserControl()
            Me.TransactionsGrid = New DevExpress.XtraGrid.GridControl()
            Me.transactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.transactionsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.bbiCustomize = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiSaveAndNew = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiReset = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiSaveLayout = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiResetLayout = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroupLayout = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAmount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForTransactionsGrid = New DevExpress.XtraLayout.LayoutControlItem()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.bbiTransaction_DetailsNew = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiTransaction_DetailsEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiTransaction_DetailsDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiTransaction_DetailsRefresh = New DevExpress.XtraBars.BarButtonItem()
            Me.Transaction_DetailsBarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Transaction_DetailsBar = New DevExpress.XtraBars.Bar()
            Me.Transactions_DetailsPopUpMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayout.SuspendLayout()
            CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AmountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Transaction_DetailsUserControl.SuspendLayout()
            CType(Me.TransactionsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.transactionsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForTransactionsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Transaction_DetailsBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Transactions_DetailsPopUpMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dataLayout
            '
            Me.dataLayout.AllowCustomization = False
            Me.dataLayout.Controls.Add(Me.NameTextEdit)
            Me.dataLayout.Controls.Add(Me.AmountSpinEdit)
            Me.dataLayout.Controls.Add(Me.Transaction_DetailsUserControl)
            Me.dataLayout.DataSource = Me.bindingSource
            Me.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayout.Location = New System.Drawing.Point(0, 116)
            Me.dataLayout.Name = "dataLayout"
            Me.dataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(902, 104, 919, 581)
            Me.dataLayout.Root = Me.Root
            Me.dataLayout.Size = New System.Drawing.Size(680, 322)
            Me.dataLayout.TabIndex = 0
            Me.dataLayout.Text = "dataLayoutControl1"
            '
            'NameTextEdit
            '
            Me.NameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Name", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.NameTextEdit.Location = New System.Drawing.Point(76, 12)
            Me.NameTextEdit.Name = "NameTextEdit"
            Me.NameTextEdit.Size = New System.Drawing.Size(592, 20)
            Me.NameTextEdit.StyleController = Me.dataLayout
            Me.NameTextEdit.TabIndex = 0
            '
            'bindingSource
            '
            Me.bindingSource.DataSource = GetType(DevExpress.MVVM.Demos.Model.Account)
            '
            'AmountSpinEdit
            '
            Me.AmountSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Amount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.AmountSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.AmountSpinEdit.Location = New System.Drawing.Point(76, 36)
            Me.AmountSpinEdit.Name = "AmountSpinEdit"
            Me.AmountSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.AmountSpinEdit.Size = New System.Drawing.Size(592, 20)
            Me.AmountSpinEdit.StyleController = Me.dataLayout
            Me.AmountSpinEdit.TabIndex = 2
            '
            'Transaction_DetailsUserControl
            '
            Me.Transaction_DetailsUserControl.Controls.Add(Me.TransactionsGrid)
            Me.Transaction_DetailsUserControl.Controls.Add(Me.barDockControlLeft)
            Me.Transaction_DetailsUserControl.Controls.Add(Me.barDockControlRight)
            Me.Transaction_DetailsUserControl.Controls.Add(Me.barDockControlBottom)
            Me.Transaction_DetailsUserControl.Controls.Add(Me.barDockControlTop)
            Me.Transaction_DetailsUserControl.Location = New System.Drawing.Point(76, 60)
            Me.Transaction_DetailsUserControl.MinimumSize = New System.Drawing.Size(100, 100)
            Me.Transaction_DetailsUserControl.Name = "Transaction_DetailsUserControl"
            Me.Transaction_DetailsUserControl.Size = New System.Drawing.Size(592, 250)
            Me.Transaction_DetailsUserControl.TabIndex = 17
            '
            'TransactionsGrid
            '
            Me.TransactionsGrid.DataSource = Me.transactionBindingSource
            Me.TransactionsGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TransactionsGrid.Location = New System.Drawing.Point(0, 24)
            Me.TransactionsGrid.MainView = Me.transactionsGridView
            Me.TransactionsGrid.MenuManager = Me.ribbonControl1
            Me.TransactionsGrid.Name = "TransactionsGrid"
            Me.TransactionsGrid.Size = New System.Drawing.Size(592, 226)
            Me.TransactionsGrid.TabIndex = 6
            Me.TransactionsGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.transactionsGridView})
            '
            'transactionBindingSource
            '
            Me.transactionBindingSource.DataSource = GetType(DevExpress.MVVM.Demos.Model.Transaction)
            '
            'transactionsGridView
            '
            Me.transactionsGridView.GridControl = Me.TransactionsGrid
            Me.transactionsGridView.Name = "transactionsGridView"
            Me.transactionsGridView.OptionsBehavior.Editable = False
            Me.transactionsGridView.OptionsView.ShowGroupPanel = False
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.bbiCustomize, Me.bbiSave, Me.bbiSaveAndClose, Me.bbiSaveAndNew, Me.bbiReset, Me.bbiDelete, Me.bbiClose, Me.bbiSaveLayout, Me.bbiResetLayout})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 8
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl1.Size = New System.Drawing.Size(680, 116)
            Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            '
            'bbiCustomize
            '
            Me.bbiCustomize.Caption = "Customize"
            Me.bbiCustomize.Id = 1
            Me.bbiCustomize.ImageOptions.SvgImage = Global.My.Resources.Resources.Action_Printing_PageSetup
            Me.bbiCustomize.Name = "bbiCustomize"
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
            'bbiSaveLayout
            '
            Me.bbiSaveLayout.Caption = "Save Layout"
            Me.bbiSaveLayout.Id = 8
            Me.bbiSaveLayout.ImageOptions.SvgImage = Global.My.Resources.Resources.Save
            Me.bbiSaveLayout.Name = "bbiSaveLayout"
            '
            'bbiResetLayout
            '
            Me.bbiResetLayout.Caption = "Reset Layout"
            Me.bbiResetLayout.Id = 9
            Me.bbiResetLayout.ImageOptions.SvgImage = Global.My.Resources.Resources.ResetView
            Me.bbiResetLayout.Name = "bbiResetLayout"
            '
            'ribbonPage1
            '
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup3, Me.ribbonPageGroup4, Me.ribbonPageGroupLayout})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ACCOUNT"
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
            'ribbonPageGroupLayout
            '
            Me.ribbonPageGroupLayout.AllowTextClipping = False
            Me.ribbonPageGroupLayout.ItemLinks.Add(Me.bbiCustomize)
            Me.ribbonPageGroupLayout.ItemLinks.Add(Me.bbiSaveLayout)
            Me.ribbonPageGroupLayout.ItemLinks.Add(Me.bbiResetLayout)
            Me.ribbonPageGroupLayout.Name = "ribbonPageGroupLayout"
            Me.ribbonPageGroupLayout.Text = "Layout"
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 226)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(592, 24)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 226)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 250)
            Me.barDockControlBottom.Size = New System.Drawing.Size(592, 0)
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(592, 24)
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(680, 322)
            Me.Root.TextVisible = False
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForName, Me.ItemForAmount, Me.ItemForTransactionsGrid})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(660, 302)
            '
            'ItemForName
            '
            Me.ItemForName.Control = Me.NameTextEdit
            Me.ItemForName.Location = New System.Drawing.Point(0, 0)
            Me.ItemForName.Name = "ItemForName"
            Me.ItemForName.Size = New System.Drawing.Size(660, 24)
            Me.ItemForName.Text = "Name"
            Me.ItemForName.TextSize = New System.Drawing.Size(61, 13)
            '
            'ItemForAmount
            '
            Me.ItemForAmount.Control = Me.AmountSpinEdit
            Me.ItemForAmount.Location = New System.Drawing.Point(0, 24)
            Me.ItemForAmount.Name = "ItemForAmount"
            Me.ItemForAmount.Size = New System.Drawing.Size(660, 24)
            Me.ItemForAmount.Text = "Amount"
            Me.ItemForAmount.TextSize = New System.Drawing.Size(61, 13)
            '
            'ItemForTransactionsGrid
            '
            Me.ItemForTransactionsGrid.Control = Me.Transaction_DetailsUserControl
            Me.ItemForTransactionsGrid.Location = New System.Drawing.Point(0, 48)
            Me.ItemForTransactionsGrid.Name = "layoutControlItem1"
            Me.ItemForTransactionsGrid.Size = New System.Drawing.Size(660, 254)
            Me.ItemForTransactionsGrid.StartNewLine = True
            Me.ItemForTransactionsGrid.Text = "Transactions"
            Me.ItemForTransactionsGrid.TextSize = New System.Drawing.Size(61, 13)
            '
            'mvvmContext
            '
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.RegistrationExpressions.AddRange(New DevExpress.Utils.MVVM.RegistrationExpression() {DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(Nothing, False, DevExpress.Utils.DefaultBoolean.[True], Me.dataLayout)})
            Me.mvvmContext.ViewModelType = GetType(DevExpress.MVVM.Demos.ViewModels.AccountViewModel)
            '
            'bbiTransaction_DetailsNew
            '
            Me.bbiTransaction_DetailsNew.Caption = "New"
            Me.bbiTransaction_DetailsNew.Id = 0
            Me.bbiTransaction_DetailsNew.ImageOptions.SvgImage = Global.My.Resources.Resources._new
            Me.bbiTransaction_DetailsNew.Name = "bbiTransaction_DetailsNew"
            Me.bbiTransaction_DetailsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'bbiTransaction_DetailsEdit
            '
            Me.bbiTransaction_DetailsEdit.Caption = "Edit"
            Me.bbiTransaction_DetailsEdit.Id = 1
            Me.bbiTransaction_DetailsEdit.ImageOptions.SvgImage = Global.My.Resources.Resources.Action_Edit
            Me.bbiTransaction_DetailsEdit.Name = "bbiTransaction_DetailsEdit"
            Me.bbiTransaction_DetailsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'bbiTransaction_DetailsDelete
            '
            Me.bbiTransaction_DetailsDelete.Caption = "Delete"
            Me.bbiTransaction_DetailsDelete.Id = 2
            Me.bbiTransaction_DetailsDelete.ImageOptions.SvgImage = Global.My.Resources.Resources.Action_Delete
            Me.bbiTransaction_DetailsDelete.Name = "bbiTransaction_DetailsDelete"
            Me.bbiTransaction_DetailsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'bbiTransaction_DetailsRefresh
            '
            Me.bbiTransaction_DetailsRefresh.Caption = "Refresh"
            Me.bbiTransaction_DetailsRefresh.Id = 3
            Me.bbiTransaction_DetailsRefresh.ImageOptions.SvgImage = Global.My.Resources.Resources.Refresh
            Me.bbiTransaction_DetailsRefresh.Name = "bbiTransaction_DetailsRefresh"
            Me.bbiTransaction_DetailsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'Transaction_DetailsBarManager
            '
            Me.Transaction_DetailsBarManager.AllowCustomization = False
            Me.Transaction_DetailsBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Transaction_DetailsBar})
            Me.Transaction_DetailsBarManager.DockControls.Add(Me.barDockControlTop)
            Me.Transaction_DetailsBarManager.DockControls.Add(Me.barDockControlBottom)
            Me.Transaction_DetailsBarManager.DockControls.Add(Me.barDockControlLeft)
            Me.Transaction_DetailsBarManager.DockControls.Add(Me.barDockControlRight)
            Me.Transaction_DetailsBarManager.Form = Me.Transaction_DetailsUserControl
            Me.Transaction_DetailsBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiTransaction_DetailsNew, Me.bbiTransaction_DetailsEdit, Me.bbiTransaction_DetailsDelete, Me.bbiTransaction_DetailsRefresh})
            Me.Transaction_DetailsBarManager.MainMenu = Me.Transaction_DetailsBar
            Me.Transaction_DetailsBarManager.MaxItemId = 4
            '
            'Transaction_DetailsBar
            '
            Me.Transaction_DetailsBar.BarName = "Transaction_Details"
            Me.Transaction_DetailsBar.DockCol = 0
            Me.Transaction_DetailsBar.DockRow = 0
            Me.Transaction_DetailsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Transaction_DetailsBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTransaction_DetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTransaction_DetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTransaction_DetailsDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTransaction_DetailsRefresh)})
            Me.Transaction_DetailsBar.OptionsBar.AllowQuickCustomization = False
            Me.Transaction_DetailsBar.OptionsBar.DrawDragBorder = False
            Me.Transaction_DetailsBar.Text = "Transaction_Details"
            '
            'Transactions_DetailsPopUpMenu
            '
            Me.Transactions_DetailsPopUpMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTransaction_DetailsNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTransaction_DetailsEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTransaction_DetailsDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTransaction_DetailsRefresh)})
            Me.Transactions_DetailsPopUpMenu.Manager = Me.Transaction_DetailsBarManager
            Me.Transactions_DetailsPopUpMenu.Name = "Transactions_DetailsPopUpMenu"
            '
            'AccountEditForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
            Me.Controls.Add(Me.dataLayout)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "AccountEditForm"
            Me.Size = New System.Drawing.Size(680, 438)
            CType(Me.dataLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayout.ResumeLayout(False)
            CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AmountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Transaction_DetailsUserControl.ResumeLayout(False)
            Me.Transaction_DetailsUserControl.PerformLayout()
            CType(Me.TransactionsGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.transactionsGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForTransactionsGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Transaction_DetailsBarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Transactions_DetailsPopUpMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private dataLayout As DevExpress.XtraDataLayout.DataLayoutControl
        Private Root As DevExpress.XtraLayout.LayoutControlGroup
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private bindingSource As System.Windows.Forms.BindingSource
        Private NameTextEdit As DevExpress.XtraEditors.TextEdit
        Private AmountSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private ItemForName As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForAmount As DevExpress.XtraLayout.LayoutControlItem
        Private bbiSave As XtraBars.BarButtonItem
        Private bbiSaveAndClose As XtraBars.BarButtonItem
        Private bbiSaveAndNew As XtraBars.BarButtonItem
        Private bbiReset As XtraBars.BarButtonItem
        Private bbiDelete As XtraBars.BarButtonItem
        Private bbiClose As XtraBars.BarButtonItem
        Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
        Private transactionBindingSource As System.Windows.Forms.BindingSource
        Private bbiCustomize As DevExpress.XtraBars.BarButtonItem
        Private bbiSaveLayout As XtraBars.BarButtonItem
        Private bbiResetLayout As XtraBars.BarButtonItem
        Private ribbonPageGroupLayout As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private bbiTransaction_DetailsNew As XtraBars.BarButtonItem
        Private bbiTransaction_DetailsEdit As XtraBars.BarButtonItem
        Private bbiTransaction_DetailsDelete As XtraBars.BarButtonItem
        Private bbiTransaction_DetailsRefresh As XtraBars.BarButtonItem
        Private TransactionsGrid As XtraGrid.GridControl
        Private transactionsGridView As XtraGrid.Views.Grid.GridView
        Private ItemForTransactionsGrid As XtraLayout.LayoutControlItem
        Private Transaction_DetailsUserControl As XtraEditors.XtraUserControl
        Private barDockControlLeft As XtraBars.BarDockControl
        Private barDockControlRight As XtraBars.BarDockControl
        Private barDockControlBottom As XtraBars.BarDockControl
        Private barDockControlTop As XtraBars.BarDockControl
        Private Transaction_DetailsBarManager As XtraBars.BarManager
        Private Transaction_DetailsBar As XtraBars.Bar
        Private Transactions_DetailsPopUpMenu As XtraBars.PopupMenu
    End Class
End Namespace
