Namespace DevExpress.MVVM.Demos.Navigation
    Partial Public Class TabbedFormModule
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabbedFormModule))
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.tabFormControl1 = New DevExpress.XtraBars.TabFormControl()
            Me.biAccounts = New DevExpress.XtraBars.BarButtonItem()
            Me.biCategories = New DevExpress.XtraBars.BarButtonItem()
            Me.biTransactions = New DevExpress.XtraBars.BarButtonItem()
            Me.tabFormDefaultManager1 = New DevExpress.XtraBars.TabFormDefaultManager()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'mvvmContext
            '
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.MVVM.Demos.ViewModels.ExpensesDbContextViewModel)
            '
            'tabFormControl1
            '
            Me.tabFormControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.biAccounts, Me.biCategories, Me.biTransactions})
            Me.tabFormControl1.LinkProvider.TabLeftItemLinks.Add(Me.biAccounts)
            Me.tabFormControl1.LinkProvider.TabLeftItemLinks.Add(Me.biCategories)
            Me.tabFormControl1.LinkProvider.TabLeftItemLinks.Add(Me.biTransactions)
            Me.tabFormControl1.Location = New System.Drawing.Point(0, 0)
            Me.tabFormControl1.Manager = Me.tabFormDefaultManager1
            Me.tabFormControl1.Name = "tabFormControl1"
            Me.tabFormControl1.ShowAddPageButton = False
            Me.tabFormControl1.ShowTabsInTitleBar = DevExpress.XtraBars.ShowTabsInTitleBar.[True]
            Me.tabFormControl1.Size = New System.Drawing.Size(947, 25)
            Me.tabFormControl1.TabForm = Me
            Me.tabFormControl1.TabIndex = 8
            Me.tabFormControl1.TabStop = False
            '
            'biAccounts
            '
            Me.biAccounts.Caption = "Accounts"
            Me.biAccounts.Id = 0
            Me.biAccounts.Name = "biAccounts"
            Me.biAccounts.ImageOptions.SvgImage = Global.My.Resources.Resources.currency
            '
            'biCategories
            '
            Me.biCategories.Caption = "Categories"
            Me.biCategories.Id = 1
            Me.biCategories.Name = "biCategories"
            Me.biCategories.ImageOptions.SvgImage = Global.My.Resources.Resources.pieseries
            '
            'biTransactions
            '
            Me.biTransactions.Caption = "Transactions"
            Me.biTransactions.Id = 2
            Me.biTransactions.Name = "biTransactions"
            Me.biTransactions.ImageOptions.SvgImage = Global.My.Resources.Resources.Transactions
            '
            'tabFormDefaultManager1
            '
            Me.tabFormDefaultManager1.DockControls.Add(Me.barDockControlTop)
            Me.tabFormDefaultManager1.DockControls.Add(Me.barDockControlBottom)
            Me.tabFormDefaultManager1.DockControls.Add(Me.barDockControlLeft)
            Me.tabFormDefaultManager1.DockControls.Add(Me.barDockControlRight)
            Me.tabFormDefaultManager1.Form = Me
            Me.tabFormDefaultManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.biAccounts, Me.biCategories, Me.biTransactions})
            Me.tabFormDefaultManager1.MaxItemId = 3
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(947, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 585)
            Me.barDockControlBottom.Size = New System.Drawing.Size(947, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 585)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(947, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 585)
            '
            'TabbedFormModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(947, 585)
            Me.Controls.Add(Me.tabFormControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "TabbedFormModule"
            Me.ShowIcon = False
            Me.TabFormControl = Me.tabFormControl1
            Me.Text = "Tabbed Form"
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private mvvmContext As Utils.MVVM.MVVMContext
        Private tabFormControl1 As XtraBars.TabFormControl
        Private tabFormDefaultManager1 As XtraBars.TabFormDefaultManager
        Private barDockControlTop As XtraBars.BarDockControl
        Private barDockControlBottom As XtraBars.BarDockControl
        Private barDockControlLeft As XtraBars.BarDockControl
        Private barDockControlRight As XtraBars.BarDockControl
        Private biAccounts As XtraBars.BarButtonItem
        Private biCategories As XtraBars.BarButtonItem
        Private biTransactions As XtraBars.BarButtonItem
    End Class
End Namespace
