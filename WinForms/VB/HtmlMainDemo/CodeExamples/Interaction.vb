Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Helpers
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Utils.Html
Imports DevExpress.Utils.MVVM
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Handle clicks on elements", "Interaction.cs")>
    Public Module Interaction_ElementMouseClick

        Sub New()
            DevExpress.Mvvm.DelegateCommand.DefaultUseCommandManager = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim htmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
            Dim mainView As DevExpress.XtraEditors.XtraUserControl = Nothing
            If mainView IsNot Nothing Then
                mainView.Dock = System.Windows.Forms.DockStyle.Fill
                mainView.Parent = sampleHost
            Else
                htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
                htmlContentControl.Parent = sampleHost
            End If

            Return New Object() {htmlContentControl, mainView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim mvvmContext As DevExpress.Utils.MVVM.MVVMContext = DevExpress.Utils.MVVM.MVVMContext.FromControl(sampleHost)
            If mvvmContext IsNot Nothing Then mvvmContext.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("The ElementMouseClick event")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Interaction.ElementMouseClick", False), DevExpress.HTML.Demos.CodeExamples.CssFile("Interaction.ElementMouseClick", False), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ElementMouseClick")>
        Public Sub ElementMouseClickEvent(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl, ByVal mainView As DevExpress.XtraEditors.XtraUserControl)
            htmlContentControl.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ElementMouseClick.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ElementMouseClick.css"))
            '
            AddHandler htmlContentControl.ElementMouseClick, Sub(s, e)
                If Equals(e.ElementId, "btnPhone") Then Call DevExpress.XtraEditors.XtraMessageBox.Show("Phone!")
                If Equals(e.ElementId, "btnVideo") Then Call DevExpress.XtraEditors.XtraMessageBox.Show("Video!")
                If Equals(e.ElementId, "btnText") Then Call DevExpress.XtraEditors.XtraMessageBox.Show("Text Message!")
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("The HTML 'onclick' event", New System.Type() {GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_ElementMouseClick.MainView)}, Nothing, GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_ElementMouseClick.MainView))>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Interaction.ElementMouseClick2", False), DevExpress.HTML.Demos.CodeExamples.CssFile("Interaction.ElementMouseClick", False), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("BindCommandToElement")>
        Public Sub ElementMouseClickAutoWiredHandler(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl, ByVal mainView As DevExpress.XtraEditors.XtraUserControl)
            htmlContentControl.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ElementMouseClick2.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ElementMouseClick.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Partial Class MainView

            ''' <summary>
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary>
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
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
                Me.htmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
                Me.SuspendLayout()
                ' 
                ' htmlContentControl
                ' 
                Me.htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
                Me.htmlContentControl.Size = New System.Drawing.Size(398, 468)
                ' 
                ' AppLogo
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.Controls.Add(Me.htmlContentControl)
                Me.Name = "MainForm"
                Me.Size = New System.Drawing.Size(398, 468)
                Me.ResumeLayout(False)
            End Sub

#End Region
            Private htmlContentControl As DevExpress.XtraEditors.HtmlContentControl
        End Class

        Partial Class MainView
            Inherits DevExpress.XtraEditors.XtraUserControl

            Public Sub New()
                Me.InitializeComponent()
            ' $CodeBehindInsertionLine$ 
            End Sub

            Private Sub OnPhoneClick(ByVal sender As Object, ByVal args As DevExpress.Utils.Html.DxHtmlElementMouseEventArgs)
                Call DevExpress.XtraEditors.XtraMessageBox.Show("Phone!")
            End Sub

            Private Sub OnVideoClick(ByVal sender As Object, ByVal args As DevExpress.Utils.Html.DxHtmlElementMouseEventArgs)
                Call DevExpress.XtraEditors.XtraMessageBox.Show("Video!")
            End Sub

            Private Sub OnTextClick(ByVal sender As Object, ByVal args As DevExpress.Utils.Html.DxHtmlElementMouseEventArgs)
                Call DevExpress.XtraEditors.XtraMessageBox.Show("Text Message!")
            End Sub
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Command binding (Fluent API)", New System.Type() {GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_ElementMouseClick.ViewModel)})>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Interaction.ElementMouseClick", False), DevExpress.HTML.Demos.CodeExamples.CssFile("Interaction.ElementMouseClick", False), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("BindCommandToElement")>
        Public Sub ElementMouseClickCommandBinding(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl, ByVal mainView As DevExpress.XtraEditors.XtraUserControl)
            htmlContentControl.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ElementMouseClick.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ElementMouseClick.css"))
            '
            Dim context As DevExpress.Utils.MVVM.MVVMContext = New DevExpress.Utils.MVVM.MVVMContext()
            context.ViewModelType = GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_ElementMouseClick.ViewModel)
            '
            Dim fluent = context.OfType(Of DevExpress.HTML.Demos.CodeExamples.Interaction_ElementMouseClick.ViewModel)()
            fluent.BindCommandToElement(htmlContentControl, "btnPhone", Function(x) AddressOf x.Phone)
            fluent.BindCommandToElement(htmlContentControl, "btnVideo", Function(x) AddressOf x.Video)
            fluent.BindCommandToElement(htmlContentControl, "btnText", Function(x) AddressOf x.TextMessage)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class ViewModel

            Public Sub Phone()
                Dim msgService = Me.GetService(Of DevExpress.Mvvm.IMessageBoxService)()
                msgService.ShowMessage("Phone!")
            End Sub

            Public Sub Video()
                Dim msgService = Me.GetService(Of DevExpress.Mvvm.IMessageBoxService)()
                msgService.ShowMessage("Video!")
            End Sub

            Public Sub TextMessage()
                Dim msgService = Me.GetService(Of DevExpress.Mvvm.IMessageBoxService)()
                msgService.ShowMessage("Text Message!")
            End Sub
        End Class
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("HtmlContentPopup - show a menu for an element", "Interaction.cs")>
    Public Module Interaction_ShowingMenu

        Sub New()
            DevExpress.Mvvm.DelegateCommand.DefaultUseCommandManager = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim menuBar = New DevExpress.XtraEditors.HtmlContentControl()
            Dim menuPopup = New DevExpress.XtraEditors.HtmlContentPopup()
            menuPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            Dim mainMenuView As DevExpress.XtraEditors.XtraUserControl = Nothing
            If mainMenuView IsNot Nothing Then
                mainMenuView.Dock = System.Windows.Forms.DockStyle.Fill
                mainMenuView.Parent = sampleHost
                menuPopup.ContainerControl = sampleHost
            Else
                menuBar.Dock = System.Windows.Forms.DockStyle.Fill
                menuBar.Parent = sampleHost
                menuPopup.ContainerControl = sampleHost
            End If

            menuBar.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            menuPopup.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            Return New Object() {menuBar, menuPopup, mainMenuView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim mvvmContext As DevExpress.Utils.MVVM.MVVMContext = DevExpress.Utils.MVVM.MVVMContext.FromControl(sampleHost)
            If mvvmContext IsNot Nothing Then mvvmContext.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Use the 'HtmlContentPopup.Show' method within an 'onclick' HTML event handler", New System.Type() {GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_ShowingMenu.MainMenuView)}, Nothing, GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_ShowingMenu.MainMenuView))>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Interaction.MenuBar", "Interaction.FileMenu"), DevExpress.HTML.Demos.CodeExamples.CssFile("Interaction.MenuBar", "Interaction.FileMenu"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Show", "HtmlTemplate", "HideOnElementClick")>
        Public Sub SetupForMenu(ByVal menuBar As DevExpress.XtraEditors.HtmlContentControl, ByVal menuPopup As DevExpress.XtraEditors.HtmlContentPopup, ByVal mainMenuView As DevExpress.XtraEditors.XtraUserControl)
            menuPopup.HideOnElementClick = DevExpress.Utils.DefaultBoolean.[True]
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Partial Class MainMenuView

            ''' <summary>
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary>
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
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
                Me.menuBar = New DevExpress.XtraEditors.HtmlContentControl()
                Me.menuPopup = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
                Me.SuspendLayout()
                ' 
                ' menuBar
                ' 
                Me.menuBar.Dock = System.Windows.Forms.DockStyle.Fill
                Me.menuBar.Size = New System.Drawing.Size(398, 468)
                ' 
                ' menuPopup
                ' 
                Me.menuPopup.ContainerControl = Me
                Me.menuPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
                ' 
                ' MainMenuView
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.Controls.Add(Me.menuBar)
                Me.Name = "MainMenuView"
                Me.Size = New System.Drawing.Size(398, 468)
                Me.ResumeLayout(False)
            End Sub

#End Region
            Private menuBar As DevExpress.XtraEditors.HtmlContentControl

            Private menuPopup As DevExpress.XtraEditors.HtmlContentPopup
        End Class

        Partial Class MainMenuView
            Inherits DevExpress.XtraEditors.XtraUserControl

            Public Sub New()
                Me.InitializeComponent()
                Me.InitializeStyles()
                ' $CodeBehindInsertionLine$ 
                AddHandler Me.menuPopup.ElementMouseClick, AddressOf Me.OnMenuItemClick
            End Sub

            Private Sub InitializeStyles()
                Me.menuBar.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
                Me.menuBar.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MenuBar.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MenuBar.css"))
                Me.menuPopup.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
                Me.menuPopup.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FileMenu.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FileMenu.css"))
            End Sub

            Private Sub OnFileClick(ByVal sender As Object, ByVal args As DevExpress.Utils.Html.DxHtmlElementMouseEventArgs)
                Dim popupSize = Me.ScaleDPI.ScaleSize(New System.Drawing.Size(140, 180))
                Dim shadowOffsetLeft As Integer = Me.ScaleDPI.ScaleHorizontal(8)
                Dim popupLocation = New System.Drawing.Point(args.Element.Location.X - shadowOffsetLeft, args.Element.ViewInfo.Bounds.Bottom)
                Me.menuPopup.Show(Me.menuBar, Me.menuBar.RectangleToScreen(New System.Drawing.Rectangle(popupLocation, popupSize)))
            End Sub

            Private Sub OnMenuItemClick(ByVal sender As Object, ByVal args As DevExpress.Utils.Html.DxHtmlElementMouseEventArgs)
                Call DevExpress.XtraEditors.XtraMessageBox.Show("Menu item [id=" & args.ElementId & "] clicked!")
            End Sub
        End Class
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("HtmlContentPopup - show a tooltip for an element", "Interaction.cs")>
    Public Module Interaction_ShowingToolTip

        Sub New()
            DevExpress.Mvvm.DelegateCommand.DefaultUseCommandManager = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim menuBar = New DevExpress.XtraEditors.HtmlContentControl()
            Dim tooltipPopup = New DevExpress.XtraEditors.HtmlContentPopup()
            tooltipPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            Dim tooltipView As DevExpress.XtraEditors.XtraUserControl = Nothing
            If tooltipView IsNot Nothing Then
                tooltipView.Dock = System.Windows.Forms.DockStyle.Fill
                tooltipView.Parent = sampleHost
                tooltipPopup.ContainerControl = sampleHost
            Else
                menuBar.Dock = System.Windows.Forms.DockStyle.Fill
                menuBar.Parent = sampleHost
                tooltipPopup.ContainerControl = sampleHost
            End If

            menuBar.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            tooltipPopup.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            Return New Object() {menuBar, tooltipPopup, tooltipView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim mvvmContext As DevExpress.Utils.MVVM.MVVMContext = DevExpress.Utils.MVVM.MVVMContext.FromControl(sampleHost)
            If mvvmContext IsNot Nothing Then mvvmContext.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Use the 'HtmlContentPopup.Show' method within an 'onmouseover' event handler", New System.Type() {GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_ShowingToolTip.TooltipView)}, Nothing, GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_ShowingToolTip.TooltipView))>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Interaction.MenuBar", "Interaction.Tooltip"), DevExpress.HTML.Demos.CodeExamples.CssFile("Interaction.MenuBar", "Interaction.Tooltip"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Show", "HtmlTemplate", "HideOnElementClick", "HideAutomatically", "AutoHidingDelay")>
        Public Sub SetupForTooltip(ByVal menuBar As DevExpress.XtraEditors.HtmlContentControl, ByVal tooltipPopup As DevExpress.XtraEditors.HtmlContentPopup, ByVal tooltipView As DevExpress.XtraEditors.XtraUserControl)
            tooltipPopup.HideOnElementClick = DevExpress.Utils.DefaultBoolean.[True]
            tooltipPopup.AutoHidingDelay = 1000
            tooltipPopup.HideAutomatically = DevExpress.Utils.DefaultBoolean.[True]
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Partial Class TooltipView

            ''' <summary>
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary>
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
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
                Me.menuBar = New DevExpress.XtraEditors.HtmlContentControl()
                Me.tooltipPopup = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
                Me.SuspendLayout()
                ' 
                ' menuBar
                ' 
                Me.menuBar.Dock = System.Windows.Forms.DockStyle.Fill
                Me.menuBar.Size = New System.Drawing.Size(398, 468)
                ' 
                ' tooltipPopup
                ' 
                Me.tooltipPopup.ContainerControl = Me
                Me.tooltipPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
                ' 
                ' TooltipView
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.Controls.Add(Me.menuBar)
                Me.Name = "TooltipView"
                Me.Size = New System.Drawing.Size(398, 468)
                Me.ResumeLayout(False)
            End Sub

#End Region
            Private menuBar As DevExpress.XtraEditors.HtmlContentControl

            Private tooltipPopup As DevExpress.XtraEditors.HtmlContentPopup
        End Class

        Partial Class TooltipView
            Inherits DevExpress.XtraEditors.XtraUserControl

            Public Sub New()
                Me.InitializeComponent()
                Me.InitializeStyles()
            ' $CodeBehindInsertionLine$ 
            End Sub

            Private Sub InitializeStyles()
                Me.menuBar.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
                Me.menuBar.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MenuBar.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MenuBar.css"))
                Me.tooltipPopup.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
                Me.tooltipPopup.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Tooltip.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Tooltip.css"))
            End Sub

            Private Sub OnFileHover(ByVal sender As Object, ByVal args As DevExpress.Utils.Html.DxHtmlElementMouseEventArgs)
                Dim popupSize = Me.ScaleDPI.ScaleSize(New System.Drawing.Size(316, 180))
                Dim shadowOffsetLeft As Integer = Me.ScaleDPI.ScaleHorizontal(8)
                Dim popupLocation = New System.Drawing.Point(args.Element.Location.X - shadowOffsetLeft, args.Element.ViewInfo.Bounds.Bottom)
                Me.tooltipPopup.Show(Me.menuBar, Me.menuBar.RectangleToScreen(New System.Drawing.Rectangle(popupLocation, popupSize)))
            End Sub
        End Class
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("HtmlContentPopup - show a dialog", "Interaction.cs")>
    Public Module Interaction_ShowingDialog

        Sub New()
            DevExpress.Mvvm.DelegateCommand.DefaultUseCommandManager = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim menuBar = New DevExpress.XtraEditors.HtmlContentControl()
            Dim dialogPopup = New DevExpress.XtraEditors.HtmlContentPopup()
            dialogPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            Dim dialogView As DevExpress.XtraEditors.XtraUserControl = Nothing
            If dialogView IsNot Nothing Then
                dialogView.Dock = System.Windows.Forms.DockStyle.Fill
                dialogView.Parent = sampleHost
                dialogPopup.ContainerControl = sampleHost
            Else
                menuBar.Dock = System.Windows.Forms.DockStyle.Fill
                menuBar.Parent = sampleHost
                dialogPopup.ContainerControl = sampleHost
            End If

            menuBar.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            dialogPopup.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            Return New Object() {menuBar, dialogPopup, dialogView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim mvvmContext As DevExpress.Utils.MVVM.MVVMContext = DevExpress.Utils.MVVM.MVVMContext.FromControl(sampleHost)
            If mvvmContext IsNot Nothing Then mvvmContext.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Use the 'HtmlContentPopup.ShowDialog' method", New System.Type() {GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_ShowingDialog.DialogView)}, Nothing, GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_ShowingDialog.DialogView))>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Interaction.MenuBar", "Interaction.Dialog"), DevExpress.HTML.Demos.CodeExamples.CssFile("Interaction.MenuBar", "Interaction.Dialog"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowDialog", "Close", "HtmlTemplate")>
        Public Sub SetupForDialog(ByVal menuBar As DevExpress.XtraEditors.HtmlContentControl, ByVal dialogPopup As DevExpress.XtraEditors.HtmlContentPopup, ByVal dialogView As DevExpress.XtraEditors.XtraUserControl)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Partial Class DialogView

            ''' <summary>
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary>
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
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
                Me.menuBar = New DevExpress.XtraEditors.HtmlContentControl()
                Me.dialogPopup = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
                Me.SuspendLayout()
                ' 
                ' menuBar
                ' 
                Me.menuBar.Dock = System.Windows.Forms.DockStyle.Fill
                Me.menuBar.Size = New System.Drawing.Size(398, 468)
                ' 
                ' dialogPopup
                ' 
                Me.dialogPopup.ContainerControl = Me
                Me.dialogPopup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
                ' 
                ' DialogView
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.Controls.Add(Me.menuBar)
                Me.Name = "DialogView"
                Me.Size = New System.Drawing.Size(398, 468)
                Me.ResumeLayout(False)
            End Sub

#End Region
            Private menuBar As DevExpress.XtraEditors.HtmlContentControl

            Private dialogPopup As DevExpress.XtraEditors.HtmlContentPopup
        End Class

        Partial Class DialogView
            Inherits DevExpress.XtraEditors.XtraUserControl

            Public Sub New()
                Me.InitializeComponent()
                Me.InitializeStyles()
                ' $CodeBehindInsertionLine$ 
                AddHandler Me.menuBar.ElementMouseClick, AddressOf Me.OnMenuItemClick
                AddHandler Me.dialogPopup.ElementMouseClick, AddressOf Me.OnDialogElementClick
            End Sub

            Private Sub InitializeStyles()
                Me.menuBar.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
                Me.menuBar.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MenuBar.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MenuBar.css"))
                Me.dialogPopup.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
                Me.dialogPopup.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Dialog.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Dialog.css"))
            End Sub

            Private Sub OnMenuItemClick(ByVal sender As Object, ByVal args As DevExpress.Utils.Html.DxHtmlElementMouseEventArgs)
                Dim dialogSize = Me.ScaleDPI.ScaleSize(New System.Drawing.Size(332, 232))
                Dim dialogRect = DevExpress.Utils.PlacementHelper.Arrange(dialogSize, Me.ClientRectangle, System.Drawing.ContentAlignment.MiddleCenter)
                Dim dialogScreenRect = Me.RectangleToScreen(dialogRect)
                If Me.dialogPopup.ShowDialog(Me.menuBar, dialogScreenRect) = System.Windows.Forms.DialogResult.OK Then
                    ' do something 
                    DevExpress.XtraEditors.XtraMessageBox.Show("Thanks!")
                End If
            End Sub

            Private Sub OnDialogElementClick(ByVal sender As Object, ByVal e As DevExpress.Utils.Html.DxHtmlElementMouseEventArgs)
                If Equals(e.ElementId, "btnClose") Then Me.dialogPopup.Close(System.Windows.Forms.DialogResult.Cancel)
                If Equals(e.ElementId, "btnAccept") Then Me.dialogPopup.Close(System.Windows.Forms.DialogResult.OK)
            End Sub
        End Class
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("HtmlContentPopup - show a popup from a ViewModel (IWindowService)", "Interaction.cs")>
    Public Module Interaction_WindowService

        Sub New()
            DevExpress.Mvvm.DelegateCommand.DefaultUseCommandManager = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim mvvmContext = New DevExpress.Utils.MVVM.MVVMContext()
            Dim menuBar = New DevExpress.XtraEditors.HtmlContentControl()
            Dim popup = New DevExpress.XtraEditors.HtmlContentPopup()
            popup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            Dim popupView As DevExpress.XtraEditors.XtraUserControl = Nothing
            If popupView IsNot Nothing Then
                popupView.Dock = System.Windows.Forms.DockStyle.Fill
                popupView.Parent = sampleHost
                popup.ContainerControl = sampleHost
            Else
                menuBar.Dock = System.Windows.Forms.DockStyle.Fill
                menuBar.Parent = sampleHost
                popup.ContainerControl = sampleHost
            End If

            menuBar.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            popup.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            Return New Object() {menuBar, popup, mvvmContext, popupView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim mvvmContext As DevExpress.Utils.MVVM.MVVMContext = DevExpress.Utils.MVVM.MVVMContext.FromControl(sampleHost)
            If mvvmContext IsNot Nothing Then mvvmContext.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Flyout (modeless window)", New System.Type() {GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupView), GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.MainViewModel), GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupViewModel), GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.DialogViewModel)}, Nothing, GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupView), HiddenTypes:="DialogViewModel")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Interaction.MVVMMenuBar", "Interaction.MVVMPopup"), DevExpress.HTML.Demos.CodeExamples.CssFile("Interaction.MenuBar", "Interaction.Popup"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ViewModelType", "ViewModelSet", "CreateWindowService", "ShowMode")>
        Public Sub SetupForPopup(ByVal menuBar As DevExpress.XtraEditors.HtmlContentControl, ByVal popup As DevExpress.XtraEditors.HtmlContentPopup, ByVal mvvmContext As DevExpress.Utils.MVVM.MVVMContext, ByVal popupView As DevExpress.XtraEditors.XtraUserControl)
            ' Setup the popup 
            popup.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            popup.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MVVMPopup.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Popup.css"))
            ' Bind the HTML 'miPopup' element to the ShowPopup command
            Dim fluent = mvvmContext.OfType(Of DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.MainViewModel)()
            fluent.BindCommandToElement(menuBar, "miPopup", Function(x) AddressOf x.ShowPopup)
            ' Configure a WindowService instance
            Dim popupService = popup.CreateWindowService(popup.ContainerControl)
            popupService.ShowMode = DevExpress.Utils.MVVM.Services.WindowService.WindowShowMode.Modeless
            Dim popupWindowStyle = New System.Action(Of DevExpress.Utils.MVVM.Services.IWindow)(Sub(window)
                Dim flyoutWindow = TryCast(window, DevExpress.Utils.MVVM.Services.IPopupWindow)
                flyoutWindow.PopupSize = New System.Drawing.Size(332, 140)
            End Sub)
            popupService.WindowStyle = popupWindowStyle
            mvvmContext.RegisterService(popupService)
            ' Bind dialog elements to the PopupViewModel
            popup.ViewModelType = GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupViewModel)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Modal window", New System.Type() {GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupView), GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.MainViewModel), GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupViewModel), GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.DialogViewModel)}, Nothing, GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupView), HiddenTypes:="PopupViewModel")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Interaction.MVVMMenuBar", "Interaction.MVVMDialog"), DevExpress.HTML.Demos.CodeExamples.CssFile("Interaction.MenuBar", "Interaction.Dialog"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ViewModelType", "ViewModelSet", "CreateWindowService", "ShowMode")>
        Public Sub SetupForDialog(ByVal menuBar As DevExpress.XtraEditors.HtmlContentControl, ByVal popup As DevExpress.XtraEditors.HtmlContentPopup, ByVal mvvmContext As DevExpress.Utils.MVVM.MVVMContext, ByVal popupView As DevExpress.XtraEditors.XtraUserControl)
            ' Setup the popup 
            popup.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            popup.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MVVMDialog.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Dialog.css"))
            ' Bind the HTML 'miDialog' element to the ShowDialog command
            Dim fluent = mvvmContext.OfType(Of DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.MainViewModel)()
            fluent.BindCommandToElement(menuBar, "miDialog", Function(x) AddressOf x.ShowDialog)
            ' Configure a WindowService instance
            Dim popupService = popup.CreateWindowService(popup.ContainerControl)
            popupService.ShowMode = DevExpress.Utils.MVVM.Services.WindowService.WindowShowMode.Modal
            Dim popupWindowStyle = New System.Action(Of DevExpress.Utils.MVVM.Services.IWindow)(Sub(window)
                Dim dlgWindow = TryCast(window, DevExpress.Utils.MVVM.Services.IPopupWindow)
                dlgWindow.PopupSize = New System.Drawing.Size(332, 232)
                dlgWindow.DestroyOnHide = False
            End Sub)
            popupService.WindowStyle = popupWindowStyle
            mvvmContext.RegisterService(popupService)
            ' Bind dialog elements to the DialogViewModel
            popup.ViewModelType = GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.DialogViewModel)
            AddHandler popup.ViewModelSet, Sub(s, e)
                Dim dlgFluent = popup.OfType(Of DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.DialogViewModel)()
                dlgFluent.BindCommand("btnClose", Function(x) AddressOf x.Close)
                dlgFluent.BindCommand("btnAccept", Function(x) AddressOf x.Accept)
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Partial Class PopupView

            ''' <summary>
            ''' Required designer variable.
            ''' </summary>
            Private components As System.ComponentModel.IContainer = Nothing

            ''' <summary>
            ''' Clean up any resources being used.
            ''' </summary>
            ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            Protected Overrides Sub Dispose(ByVal disposing As Boolean)
                If disposing AndAlso (Me.components IsNot Nothing) Then
                    Me.components.Dispose()
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
                Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
                Me.menuBar = New DevExpress.XtraEditors.HtmlContentControl()
                Me.popup = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
                Me.SuspendLayout()
                ' 
                ' mvvmContext
                ' 
                Me.mvvmContext.ViewModelType = GetType(DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.MainViewModel)
                Me.mvvmContext.ContainerControl = Me
                ' 
                ' menuBar
                ' 
                Me.menuBar.Dock = System.Windows.Forms.DockStyle.Fill
                Me.menuBar.Size = New System.Drawing.Size(398, 468)
                ' 
                ' dialogPopup
                ' 
                Me.popup.ContainerControl = Me
                Me.popup.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
                ' 
                ' PopupView
                ' 
                Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
                Me.Controls.Add(Me.menuBar)
                Me.Name = "PopupView"
                Me.Size = New System.Drawing.Size(398, 468)
                Me.ResumeLayout(False)
            End Sub

#End Region
            Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext

            Private menuBar As DevExpress.XtraEditors.HtmlContentControl

            Private popup As DevExpress.XtraEditors.HtmlContentPopup
        End Class

        Partial Class PopupView
            Inherits DevExpress.XtraEditors.XtraUserControl

            Public Sub New()
                Me.InitializeComponent()
                Me.InitializeStyles()
                If Me.mvvmContext.IsDesignMode Then Return
            ' $CodeBehindInsertionLine$ 
            End Sub

            Private Sub InitializeStyles()
                Me.menuBar.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
                Me.menuBar.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MVVMMenuBar.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MenuBar.css"))
            End Sub
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class MainViewModel

            Private popupViewModel As DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupViewModel

            Public Sub ShowPopup()
                If Me.popupViewModel Is Nothing Then
                    Me.popupViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create(Of DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.PopupViewModel)()
                    Me.popupViewModel.Text = "Click outside the popup to close it."
                End If

                Dim windowService = Me.GetService(Of DevExpress.Mvvm.IWindowService)()
                ' The following method call returns immediately due to the WindowService setup
                windowService.Show(Nothing, Me.popupViewModel, Nothing, Me)
            End Sub

            Private dialogViewModel As DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.DialogViewModel

            Public Sub ShowDialog()
                If Me.dialogViewModel Is Nothing Then
                    Me.dialogViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create(Of DevExpress.HTML.Demos.CodeExamples.Interaction_WindowService.DialogViewModel)()
                    Me.dialogViewModel.Text = "Press OK button to accept the dialog."
                End If

                Dim windowService = Me.GetService(Of DevExpress.Mvvm.IWindowService)()
                ' The following method call does not return immediately due to the WindowService setup
                windowService.Show(Nothing, Me.dialogViewModel, Nothing, Me)
                If Me.dialogViewModel.Result Then
                    Dim msgService = Me.GetService(Of DevExpress.Mvvm.IMessageBoxService)()
                    msgService.ShowMessage("Thanks")
                End If
            End Sub
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class PopupViewModel

            Public ReadOnly Property Title As String
                Get
                    Return "Popup Window"
                End Get
            End Property

            Public Overridable Property Text As String
        End Class

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class DialogViewModel
            Implements DevExpress.Mvvm.IDocumentContent

            Private _Result As Boolean

            Public ReadOnly Property TitleProp As String
                Get
                    Return "Dialog Window"
                End Get
            End Property

            Public Overridable Property Text As String

            Public Property Result As Boolean
                Get
                    Return _Result
                End Get

                Private Set(ByVal value As Boolean)
                    _Result = value
                End Set
            End Property

            Public Sub Close()
                Me.Result = False
                Me.CloseDocument()
            End Sub

            Public Sub Accept()
                Me.Result = True
                Me.CloseDocument()
            End Sub

#Region "IDocumentContent"
            Private Sub CloseDocument()
                Dim owner = CType(Me, DevExpress.Mvvm.IDocumentContent).DocumentOwner
                If owner IsNot Nothing Then owner.Close(Me)
            End Sub

            Private ReadOnly Property Title As Object Implements Global.DevExpress.Mvvm.IDocumentContent.Title
                Get
                    Return Me.TitleProp
                End Get
            End Property

            Private Property DocumentOwner As IDocumentOwner Implements Global.DevExpress.Mvvm.IDocumentContent.DocumentOwner

            Private Sub OnClose(ByVal e As System.ComponentModel.CancelEventArgs) Implements Global.DevExpress.Mvvm.IDocumentContent.OnClose
            End Sub

            Private Sub OnDestroy() Implements Global.DevExpress.Mvvm.IDocumentContent.OnDestroy
            End Sub
#End Region  ' IDocumentContent
        End Class
    End Module
End Namespace
