Imports System
Imports DevExpress.MVVM.Demos.ViewModels
Imports DevExpress.Utils.MVVM.Services

Namespace DevExpress.MVVM.Demos.Navigation
    Partial Public Class TabbedFormModule
        Inherits DevExpress.XtraBars.TabForm
        Public Sub New()
            InitializeComponent()
            AddHandler tabFormControl1.OuterFormCreating, AddressOf tabFormControl_OuterFormCreating
            AddHandler tabFormControl1.PageClosed, AddressOf tabFormControl_PageClosed
            If Not mvvmContext.IsDesignMode Then
                InitializeNavigation(True)
            End If
        End Sub
        Public Sub New(loadDefaultModule As Boolean)
            InitializeComponent()
            AddHandler tabFormControl1.OuterFormCreating, AddressOf tabFormControl_OuterFormCreating
            AddHandler tabFormControl1.PageClosed, AddressOf tabFormControl_PageClosed
            If Not mvvmContext.IsDesignMode Then
                InitializeNavigation(loadDefaultModule)
            End If
        End Sub
        Sub tabFormControl_OuterFormCreating(ByVal sender As Object, ByVal e As XtraBars.OuterFormCreatingEventArgs)
            ' creating secondary Tab Form
            e.Form = New TabbedFormModule(False)
        End Sub
        Sub tabFormControl_PageClosed(ByVal sender As Object, ByVal e As XtraBars.PageClosedEventArgs)
            ' close empty form
            If TabFormControl.Pages.Count = 0 Then
                Close()
            End If
        End Sub
        Sub InitializeNavigation(loadDefaultModule As Boolean)
            ' We want the DocumentManagerService based on TabFormControl to be a navigation provider
            mvvmContext.RegisterService(DocumentManagerService.Create(TabFormControl))
            ' We want to use buttons in TabFormControl to show the specific modules
            Dim fluentAPI = mvvmContext.OfType(Of ExpensesDbContextViewModel)()
            ' Assign True if needed to load default module (True for main Tab Form, False for secondary Tab Form)
            fluentAPI.ViewModel.AllowDefaultModule = loadDefaultModule
            fluentAPI.BindCommand(biAccounts, Sub(x, m) x.Show(m), Function(x) x.Modules(0))
            fluentAPI.BindCommand(biCategories, Sub(x, m) x.Show(m), Function(x) x.Modules(1))
            fluentAPI.BindCommand(biTransactions, Sub(x, m) x.Show(m), Function(x) x.Modules(2))
            ' We want show the default module when our TabForm is loaded
            fluentAPI.WithEvent(Of EventArgs)(Me, "Load").
                EventToCommand(Sub(x) x.OnLoaded(Nothing), Function(x) x.DefaultModule)
        End Sub
    End Class

#Region "Module Starter"
    Partial Public Class TabbedFormModuleStarter
        Inherits TutorialControl
        Private sourceCode As DXperience.Demos.CodeDemo.RichEditUserControl
        Private showModuleButton As DevExpress.XtraEditors.PanelControl
        Public Sub New()
            InitializeComponent()
            Dim asm = GetType(DevExpress.Tutorials.ucAboutPage).Assembly
            AddHandler CType(New DevExpress.Tutorials.Controls.OverviewButton(showModuleButton,
                DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.Tutorials.Images.RunButtonNormal.png", asm),
                DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.Tutorials.Images.RunButtonHover.png", asm),
                DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.Tutorials.Images.RunButtonPressed.png", asm), String.Empty),
            DevExpress.Tutorials.Controls.OverviewButton).ButtonClick, AddressOf showModuleButton_Click
            '
            LoadSourceCode(sourceCode, "tabFormControl_OuterFormCreating", GetType(TabbedFormModule))
            LoadSourceCode(sourceCode, "tabFormControl_PageClosed", GetType(TabbedFormModule), True)
            LoadSourceCode(sourceCode, "InitializeNavigation", GetType(TabbedFormModule), True)
        End Sub
        Private Sub InitializeComponent()
            Me.sourceCode = New DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl()
            Me.showModuleButton = New XtraEditors.PanelControl()
            Me.SuspendLayout()
            ' 
            ' showModuleButton
            ' 
            Me.showModuleButton.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            Me.showModuleButton.Dock = System.Windows.Forms.DockStyle.Fill
            Me.showModuleButton.Name = "showModuleButton"
            Me.showModuleButton.Text = "Start the TabbedForm Module"
            ' 
            ' sourceCode
            ' 
            Me.sourceCode.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.sourceCode.Location = New System.Drawing.Point(5, 217)
            Me.sourceCode.Margin = New System.Windows.Forms.Padding(0)
            Me.sourceCode.Name = "sourceCode"
            Me.sourceCode.Size = New System.Drawing.Size(779, 210)
            ' 
            ' WindowedModule
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.Controls.Add(Me.showModuleButton)
            Me.Controls.Add(Me.sourceCode)
            Me.Name = "TabbedFormModuleStarter"
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub
        '
        Private [module] As TabbedFormModule
        Sub showModuleButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If [module] Is Nothing Then
                [module] = New TabbedFormModule()
                [module].StartPosition = System.Windows.Forms.FormStartPosition.Manual
                If ParentFormMain IsNot Nothing Then
                    [module].Location = New System.Drawing.Point(
                        ParentFormMain.Left + (ParentFormMain.Width - [module].Width) \ 2,
                        ParentFormMain.Top + (ParentFormMain.Height - [module].Height) \ 2)
                End If
                AddHandler [module].FormClosed, AddressOf activeModule_FormClosed
            End If
            showModuleButton.Enabled = False
            [module].Show(Me)
        End Sub
        Sub activeModule_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            If [module] IsNot Nothing Then
                RemoveHandler [module].FormClosed, AddressOf activeModule_FormClosed
            End If
            [module] = Nothing
            showModuleButton.Enabled = True
        End Sub
        Protected Overrides Sub DoVisibleChanged(ByVal visible As Boolean)
            MyBase.DoVisibleChanged(visible)
            If (Not visible) AndAlso [module] IsNot Nothing AndAlso [module].Visible Then
                [module].Close()
            End If
        End Sub
    End Class
#End Region
End Namespace
