Namespace DevExpress.MVVM.Demos.Navigation
    Partial Public Class TabControlModule
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TabControlModule))
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biAccounts = New DevExpress.XtraBars.BarButtonItem()
            Me.biCategories = New DevExpress.XtraBars.BarButtonItem()
            Me.biTransactions = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.xtraTabControl = New DevExpress.XtraTab.XtraTabControl()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext()
            Me.sourceCode = New DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl
            ' 
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.biAccounts, Me.biCategories, Me.biTransactions})
            Me.ribbonControl.Location = New System.Drawing.Point(5, 0)
            Me.ribbonControl.MaxItemId = 4
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False
            Me.ribbonControl.ShowQatLocationSelector = False
            Me.ribbonControl.ShowToolbarCustomizeItem = False
            Me.ribbonControl.Size = New System.Drawing.Size(795, 116)
            Me.ribbonControl.Toolbar.ShowCustomizeItem = False
            Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
            ' 
            ' biAccounts
            ' 
            Me.biAccounts.Caption = "Accounts"
            Me.biAccounts.Id = 1
            Me.biAccounts.Name = "biAccounts"
            Me.biAccounts.ImageOptions.SvgImage = Global.My.Resources.Resources.currency
            ' 
            ' biCategories
            ' 
            Me.biCategories.Caption = "Categories"
            Me.biCategories.Id = 2
            Me.biCategories.Name = "biCategories"
            Me.biCategories.ImageOptions.SvgImage = Global.My.Resources.Resources.pieseries
            ' 
            ' biTransactions
            ' 
            Me.biTransactions.Caption = "Transactions"
            Me.biTransactions.Id = 3
            Me.biTransactions.Name = "biTransactions"
            Me.biTransactions.ImageOptions.SvgImage = Global.My.Resources.Resources.Transactions
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "EXPENSES"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biAccounts)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biCategories)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biTransactions)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.ShowCaptionButton = False
            Me.ribbonPageGroup1.Text = "Navigation"
            ' 
            ' xtraTabControl
            ' 
            Me.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader
            Me.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl.Location = New System.Drawing.Point(5, 116)
            Me.xtraTabControl.Name = "xtraTabControl"
            Me.xtraTabControl.Size = New System.Drawing.Size(795, 64)
            Me.xtraTabControl.TabIndex = 1
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.MVVM.Demos.ViewModels.ExpensesDbContextViewModel)
            ' 
            ' sourceCode
            ' 
            Me.sourceCode.CurrentNestedType = Nothing
            Me.sourceCode.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.sourceCode.Location = New System.Drawing.Point(5, 180)
            Me.sourceCode.Name = "sourceCode"
            Me.sourceCode.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
            Me.sourceCode.RichText = ""
            Me.sourceCode.Size = New System.Drawing.Size(795, 215)
            Me.sourceCode.TabIndex = 7
            ' 
            ' TabControlModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl)
            Me.Controls.Add(Me.ribbonControl)
            Me.Controls.Add(Me.sourceCode)
            Me.Name = "TabControlModule"
            Me.Size = New System.Drawing.Size(800, 400)
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl As XtraBars.Ribbon.RibbonControl
        Private biAccounts As XtraBars.BarButtonItem
        Private biCategories As XtraBars.BarButtonItem
        Private biTransactions As XtraBars.BarButtonItem
        Private ribbonPage1 As XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents xtraTabControl As XtraTab.XtraTabControl
        Private mvvmContext As Utils.MVVM.MVVMContext
        Private sourceCode As DXperience.Demos.CodeDemo.RichEditUserControl
    End Class
End Namespace
