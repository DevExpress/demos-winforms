Imports System
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Utils
Imports DevExpress.Utils.Animation
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Workspace Manager", "UtilityControls.cs")>
    Public Module WorkspaceManagerSamples

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim workspaceManagerHost As DevExpress.XtraEditors.XtraUserControl = New DevExpress.XtraEditors.XtraUserControl()
            workspaceManagerHost.Parent = sampleHost
            workspaceManagerHost.Dock = System.Windows.Forms.DockStyle.Fill
            Dim workspaceManager As DevExpress.Utils.WorkspaceManager = New DevExpress.Utils.WorkspaceManager()
            Return New Object() {workspaceManager, workspaceManagerHost}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Flyout Dialog", "UtilityControls.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("DockStyle", "FlyoutAction", "FlyoutCommand", "FlyoutDialog", "UserControl", "DialogResult")>
    Public Module FlyoutDialogSamples

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Return New Object() {sampleHost}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show Standard Dialog")>
        Public Sub ShowStandardDialog(ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim button As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Text = "ShowFlyout"}
            button.Dock = System.Windows.Forms.DockStyle.Top
            button.Parent = ownerControl
            Dim action As DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
            action.Caption = "Flyout Action"
            action.Description = "Flyout Action Description"
            action.Commands.Add(DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand.OK)
            AddHandler button.Click, Sub(sender, e) Call DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(ownerControl.FindForm(), action)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show Edit Dialog")>
        Public Sub ShowEditDialog(ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim button As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Text = "ShowFlyout"}
            button.Dock = System.Windows.Forms.DockStyle.Top
            button.Parent = ownerControl
            Dim control As System.Windows.Forms.UserControl = New System.Windows.Forms.UserControl() With {.Padding = New System.Windows.Forms.Padding(0, 30, 0, 20), .Size = New System.Drawing.Size(300, 300)}
            Dim textEdit As DevExpress.XtraEditors.TextEdit = New DevExpress.XtraEditors.TextEdit() With {.Dock = System.Windows.Forms.DockStyle.Top}
            textEdit.Parent = control
            Dim okButton As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Dock = System.Windows.Forms.DockStyle.Bottom, .Text = "Ok"}
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK
            okButton.Parent = control
            AddHandler button.Click, Sub(sender, e) Call DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(ownerControl.FindForm(), control)
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Transition Manager", "UtilityControls.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("Transition", "Color", "SlideFadeTransition", "TransitionManager", "FadeTransition", "LabelControl", "XtraPanel", "SlideFadeTransition", "Thread")>
    Public Module TransitionManagerSamples

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim transitionManagerHost As DevExpress.XtraEditors.XtraUserControl = New DevExpress.XtraEditors.XtraUserControl() With {.Dock = System.Windows.Forms.DockStyle.Fill}
            transitionManagerHost.Parent = sampleHost
            Return New Object() {transitionManagerHost}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show Simple Animation")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Click", "StartTransition", "EndTransition")>
        Public Sub ShowSimpleAnimation(ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim transiton As DevExpress.Utils.Animation.Transition = New DevExpress.Utils.Animation.Transition()
            transiton.Control = ownerControl
            transiton.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.[False]
            transiton.TransitionType = New DevExpress.Utils.Animation.SlideFadeTransition()
            Dim manager As DevExpress.Utils.Animation.TransitionManager = New DevExpress.Utils.Animation.TransitionManager()
            manager.Transitions.Add(transiton)
            Dim button As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Text = "Start Transition", .Dock = System.Windows.Forms.DockStyle.Top}
            button.Parent = ownerControl
            AddHandler button.Click, Sub(sender, e)
                manager.StartTransition(ownerControl)
                ownerControl.BackColor = System.Drawing.Color.FromArgb(DevExpress.DXperience.Demos.TutorialConstants.Random.[Next](0, 255), DevExpress.DXperience.Demos.TutorialConstants.Random.[Next](0, 255), DevExpress.DXperience.Demos.TutorialConstants.Random.[Next](0, 255))
                manager.EndTransition()
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show Visibility Changed Animation")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Click", "StartTransition", "EndTransition")>
        Public Sub ShowVisibilityChangedAnimation(ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim transiton As DevExpress.Utils.Animation.Transition = New DevExpress.Utils.Animation.Transition()
            transiton.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.[False]
            transiton.Control = ownerControl
            transiton.TransitionType = New DevExpress.Utils.Animation.FadeTransition()
            Dim manager As DevExpress.Utils.Animation.TransitionManager = New DevExpress.Utils.Animation.TransitionManager()
            manager.Transitions.Add(transiton)
            Dim button As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Text = "Start Transition", .Dock = System.Windows.Forms.DockStyle.Top}
            Dim label As DevExpress.XtraEditors.LabelControl = New DevExpress.XtraEditors.LabelControl() With {.Text = "Label Control", .Dock = System.Windows.Forms.DockStyle.Fill}
            Dim panel As DevExpress.XtraEditors.XtraPanel = New DevExpress.XtraEditors.XtraPanel() With {.Dock = System.Windows.Forms.DockStyle.Top, .Size = New System.Drawing.Size(100, 50), .Padding = New System.Windows.Forms.Padding(10)}
            label.Parent = panel
            panel.Parent = ownerControl
            button.Parent = ownerControl
            AddHandler button.Click, Sub(sender, e)
                manager.StartTransition(ownerControl)
                panel.Visible = Not panel.Visible
                manager.EndTransition()
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show Wait Indicator")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Click", "StartTransition", "EndTransition")>
        Public Sub ShowWaitIndicator(ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim transiton As DevExpress.Utils.Animation.Transition = New DevExpress.Utils.Animation.Transition()
            transiton.Control = ownerControl
            transiton.TransitionType = New DevExpress.Utils.Animation.SlideFadeTransition()
            Dim manager As DevExpress.Utils.Animation.TransitionManager = New DevExpress.Utils.Animation.TransitionManager()
            manager.Transitions.Add(transiton)
            Dim button As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Text = "Start Transition", .Dock = System.Windows.Forms.DockStyle.Top}
            button.Parent = ownerControl
            AddHandler button.Click, Sub(sender, e)
                manager.StartTransition(ownerControl)
                ownerControl.BackColor = System.Drawing.Color.FromArgb(DevExpress.DXperience.Demos.TutorialConstants.Random.[Next](0, 255), DevExpress.DXperience.Demos.TutorialConstants.Random.[Next](0, 255), DevExpress.DXperience.Demos.TutorialConstants.Random.[Next](0, 255))
                Call System.Threading.Thread.Sleep(1000)
                manager.EndTransition()
            End Sub
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("NavigationFrame", "UtilityControls.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("NavigationFrame", "NavigationPage", "NavigationPageContent", "DockStyle", "OfficeNavigationBar", "Color", "SolidBrush", "Pen", "StringFormat", "Font", "StringAlignment", "ControlStyles", "PaintEventArgs", "StringTrimming", "StringFormatFlags", "Panel")>
    Public Module NavigationFrameSamples

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Return New Object() {sampleHost}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create NavigationFrame", New System.Type() {GetType(Examples.NavigationFrameSamples.NavigationPageContent)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SelectNextPage", "SelectPrevPage")>
        Public Sub CreateNavigationFrame(ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim nextButton As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Text = "Select Next Page", .Dock = System.Windows.Forms.DockStyle.Top, .Parent = ownerControl}
            Dim prevButton As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton() With {.Text = "Select Previous Page", .Dock = System.Windows.Forms.DockStyle.Top, .Parent = ownerControl}
            Dim navigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame() With {.Dock = System.Windows.Forms.DockStyle.Fill, .Parent = ownerControl}
            Dim page1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Dim pageContent1 = New Examples.NavigationFrameSamples.NavigationPageContent() With {.Parent = page1, .Dock = System.Windows.Forms.DockStyle.Fill, .Text = "Navigation Page 1"}
            Dim page2 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Dim pageContent2 = New Examples.NavigationFrameSamples.NavigationPageContent() With {.Parent = page2, .Dock = System.Windows.Forms.DockStyle.Fill, .Text = "Navigation Page 2"}
            Dim page3 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Dim pageContent3 = New Examples.NavigationFrameSamples.NavigationPageContent() With {.Parent = page3, .Dock = System.Windows.Forms.DockStyle.Fill, .Text = "Navigation Page 3"}
            navigationFrame.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPage() {page1, page2, page3})
            navigationFrame.BringToFront()
            AddHandler nextButton.Click, Sub(sender, e) navigationFrame.SelectNextPage()
            AddHandler prevButton.Click, Sub(sender, e) navigationFrame.SelectPrevPage()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Attach to OfficeNavigationBar", New System.Type() {GetType(Examples.NavigationFrameSamples.NavigationPageContent)})>
        Public Sub AttachToOfficeNavigationBar(ByVal ownerControl As DevExpress.XtraEditors.XtraUserControl)
            Dim navigationBar As DevExpress.XtraBars.Navigation.OfficeNavigationBar = New DevExpress.XtraBars.Navigation.OfficeNavigationBar() With {.Dock = System.Windows.Forms.DockStyle.Bottom, .Parent = ownerControl}
            Dim navigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame() With {.Dock = System.Windows.Forms.DockStyle.Fill, .Parent = ownerControl}
            Dim page1 = New DevExpress.XtraBars.Navigation.NavigationPage() With {.Caption = "Page 1"}
            Dim pageContent1 = New Examples.NavigationFrameSamples.NavigationPageContent() With {.Parent = page1, .Dock = System.Windows.Forms.DockStyle.Fill, .Text = "Navigation Page 1"}
            Dim page2 = New DevExpress.XtraBars.Navigation.NavigationPage() With {.Caption = "Page 2"}
            Dim pageContent2 = New Examples.NavigationFrameSamples.NavigationPageContent() With {.Parent = page2, .Dock = System.Windows.Forms.DockStyle.Fill, .Text = "Navigation Page 2"}
            Dim page3 = New DevExpress.XtraBars.Navigation.NavigationPage() With {.Caption = "Page 3"}
            Dim pageContent3 = New Examples.NavigationFrameSamples.NavigationPageContent() With {.Parent = page3, .Dock = System.Windows.Forms.DockStyle.Fill, .Text = "Navigation Page 3"}
            navigationFrame.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPage() {page1, page2, page3})
            navigationFrame.BringToFront()
            navigationBar.NavigationClient = navigationFrame
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class NavigationPageContent
            Inherits System.Windows.Forms.Panel

            Private Shared currentColor As Integer

            Private Shared forecolors As System.Drawing.Color() = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Green}

            Private sb As System.Drawing.SolidBrush

            Private pen As System.Drawing.Pen

            Private sf As System.Drawing.StringFormat

            Private Shared _font As System.Drawing.Font = New System.Drawing.Font("Segoe UI", 24F)

            Public Sub New()
                Me.sf = New System.Drawing.StringFormat() With {.Alignment = System.Drawing.StringAlignment.Center, .LineAlignment = System.Drawing.StringAlignment.Center, .Trimming = System.Drawing.StringTrimming.EllipsisCharacter, .FormatFlags = System.Drawing.StringFormatFlags.NoWrap}
                Me.DoubleBuffered = True
                Me.ForeColor = Examples.NavigationFrameSamples.NavigationPageContent.forecolors((System.Math.Min(System.Threading.Interlocked.Increment(Examples.NavigationFrameSamples.NavigationPageContent.currentColor), Examples.NavigationFrameSamples.NavigationPageContent.currentColor - 1)) Mod Examples.NavigationFrameSamples.NavigationPageContent.forecolors.Length)
                Me.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint Or System.Windows.Forms.ControlStyles.UserPaint, True)
                Me.SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw Or System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, True)
            End Sub

            Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
                If Me.sb Is Nothing Then Me.sb = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(100, Me.ForeColor))
                If Me.pen Is Nothing Then Me.pen = New System.Drawing.Pen(System.Drawing.Color.FromArgb(200, 221, 223, 223))
                e.Graphics.FillRectangle(Me.sb, Me.ClientRectangle)
                e.Graphics.DrawString(Me.Text, Examples.NavigationFrameSamples.NavigationPageContent._font, Me.sb, Me.ClientRectangle, Me.sf)
            End Sub
        End Class
    End Module
End Namespace
