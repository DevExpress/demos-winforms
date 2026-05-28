Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab

Namespace DevExpress.ApplicationUI.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Overloads Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal manager As RibbonMenuManager)
            Dim item As ModuleInfo = GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Dim ctc As CodeTutorialControlBase = TryCast(item.TModule, CodeTutorialControlBase)
                If ctc IsNot Nothing Then ctc.SelectExampleByName(item.CodeExampleName)
                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                If oldTutorial IsNot Nothing Then oldTutorial.Visible = False
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub

        Public Shared Function GetLoremIpsumText(ByVal seed As Integer) As String
            Return String.Format("{0} {1}", texts(seed Mod texts.Length), texts((seed + 2) Mod texts.Length))
        End Function

        Private Shared texts As String() = New String() {"Vestibulum sem nunc, cursus sit amet placerat id, scelerisque at tortor. Nullam sit amet felis eros, ac imperdiet quam. Aliquam eu ipsum dui.", "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit.", "Duis sagittis iaculis nisl, sit amet ultricies lectus porttitor nec. Suspendisse id venenatis sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.", "Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc."}
    End Class

    '
    Public Class TutorialControl
        Inherits TutorialControlBase

        Public Sub New()
            Padding = Padding.Empty
            AddHandler SizeChanged, Sub(s, e) UpdatePosition()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            For Each ctrl As Control In Me.Controls
                Dim tabControl As XtraTabControl = TryCast(ctrl, XtraTabControl)
                If tabControl IsNot Nothing Then UpdateTabControlPosition(tabControl)
            Next

            UpdatePosition()
        End Sub

        Private centerControls As List(Of Panel) = New List(Of Panel)()

        Private Sub UpdatePosition()
            For Each pnl As Panel In centerControls
                pnl.Location = New Point((pnl.Parent.Width - pnl.Width) \ 2, (pnl.Parent.Height - pnl.Height) \ 2)
            Next
        End Sub

        Private Sub UpdateTabControlPosition(ByVal tabControl As XtraTabControl)
            AddHandler tabControl.SelectedPageChanged, Sub(s, e) UpdatePosition()
            For Each page As XtraTabPage In tabControl.TabPages
                If page IsNot Nothing Then UpdateCenteredControls(page)
            Next
        End Sub

        Protected Sub UpdateCenteredControls(ByVal page As Control)
            Dim pnl As Panel = New Panel()
            Dim _left As Integer = 100, _right As Integer = 0, _top As Integer = 100, _bottom As Integer = 0
            For i As Integer = page.Controls.Count - 1 To 0 Step -1
                Dim ctrl As Control = page.Controls(i)
                If TypeOf ctrl Is XtraBars.BarDockControl Then Continue For
                If TypeOf ctrl Is Utils.FlyoutPanel Then Continue For
                If TypeOf ctrl Is PopupContainerControl OrElse TypeOf ctrl Is PopupControlContainer Then Continue For
                If _left > ctrl.Left Then _left = ctrl.Left
                If _right < ctrl.Right Then _right = ctrl.Right
                If _top > ctrl.Top Then _top = ctrl.Top
                If _bottom < ctrl.Bottom Then _bottom = ctrl.Bottom
                ctrl.Parent = pnl
            Next

            pnl.Parent = page
            pnl.Size = New Size(_right + _left, _bottom + _top)
            centerControls.Add(pnl)
        End Sub
    End Class

    Public Class TabbedViewTutorialControl
        Inherits TutorialControlBase

        Public Sub New()
            Padding = Padding.Empty
        End Sub

        Private tabbedView As XtraBars.Docking2010.Views.Tabbed.TabbedView

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateTabbedViewPadding()
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            UpdateTabbedViewPadding()
        End Sub

        Private Sub UpdateTabbedViewPadding()
            If tabbedView Is Nothing Then
                Dim manager = XtraBars.Docking2010.DocumentManager.FromControl(Me)
                If manager IsNot Nothing AndAlso TypeOf manager.View Is XtraBars.Docking2010.Views.Tabbed.TabbedView Then tabbedView = TryCast(manager.View, XtraBars.Docking2010.Views.Tabbed.TabbedView)
            End If

            If tabbedView IsNot Nothing Then
                Dim isWXI As Boolean = Equals(LookAndFeel.ActiveSkinName, DevExpress.LookAndFeel.SkinStyle.WXI)
                tabbedView.Padding = If(isWXI, New Padding?(Padding.Empty), Nothing)
            End If
        End Sub
    End Class

    Public Class WidgetViewTutorialControl
        Inherits TutorialControlBase

        Public Sub New()
            Padding = Padding.Empty
        End Sub

        Private widgetView As XtraBars.Docking2010.Views.Widget.WidgetView

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateWidgetViewPadding()
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            UpdateWidgetViewPadding()
        End Sub

        Private Sub UpdateWidgetViewPadding()
            If widgetView Is Nothing Then
                Dim manager = XtraBars.Docking2010.DocumentManager.FromControl(Me)
                If manager IsNot Nothing AndAlso TypeOf manager.View Is XtraBars.Docking2010.Views.Widget.WidgetView Then widgetView = TryCast(manager.View, XtraBars.Docking2010.Views.Widget.WidgetView)
            End If

            If widgetView IsNot Nothing Then
                Dim isWXI As Boolean = LookAndFeel IsNot Nothing AndAlso Equals(LookAndFeel.ActiveSkinName, DevExpress.LookAndFeel.SkinStyle.WXI)
                widgetView.Padding = If(isWXI, CType(New Padding(-widgetView.DocumentSpacing), Padding?), Nothing)
            End If
        End Sub
    End Class
End Namespace
