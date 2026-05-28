Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data.Internal
Imports DevExpress.Utils.About
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors

Namespace DevExpress.RealtorWorld.Win

    Public Partial Class frmMain
        Inherits XtraForm
        Implements IMainForm

        Public Sub New()
            StartPosition = FormStartPosition.Manual
            Location = Screen.GetBounds(MousePosition).Location
            InitializeComponent()
            InitTitleImages()
            windowsUIView.ContentContainerActions.Add(New SetSkinAction("Metropolis", "White Theme"))
            windowsUIView.ContentContainerActions.Add(New SetSkinAction("MetroBlack", "Black Theme"))
            InitTiles()
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            MyBase.OnResize(e)
            windowsUIButtonPanel1.BringToFront()
            windowsUIButtonPanel1.Location = New Point(Width - 40, 8)
        End Sub

        Private Sub InitTitleImages()
            ucDraftTile.Elements(0).Image = Global.DevExpress.RealtorWorld.Win.Properties.Resources.UserManagment
            ucSettingsTile.Elements(0).Image = Global.DevExpress.RealtorWorld.Win.Properties.Resources.System
            ucResearchTile.Elements(0).Image = Global.DevExpress.RealtorWorld.Win.Properties.Resources.Research
            ucStatsTile.Elements(0).Image = Global.DevExpress.RealtorWorld.Win.Properties.Resources.Statistics
            ucBrowserTile.Elements(0).Image = Global.DevExpress.RealtorWorld.Win.Properties.Resources.Home
            ucBanksTile.Elements(0).Image = Global.DevExpress.RealtorWorld.Win.Properties.Resources.Rates
            ucLoanCalculatorTile.Elements(0).Image = Global.DevExpress.RealtorWorld.Win.Properties.Resources.Calc
            browserPage.Buttons.AddRange(New ButtonPanel.IBaseButton() {New XtraBars.Docking2010.WindowsUIButton("Home", Global.DevExpress.RealtorWorld.Win.Properties.Resources.SmallHome, -1, XtraBars.Docking2010.ImageLocation.Default, XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "Home", -1, False, False), New XtraBars.Docking2010.WindowsUIButton("Refresh", Global.DevExpress.RealtorWorld.Win.Properties.Resources.Rotate, -1, XtraBars.Docking2010.ImageLocation.Default, XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "Refresh", -1, False, False)})
        End Sub

        Private Sub InitTiles()
            DataHelper.InitListingsTile(ucListingTile)
            DataHelper.InitAgentsTile(ucAgentsTile, AppConst.TileSize)
        End Sub

        Private current As Object

        Private Sub ShowHome(ByVal home As Home) Implements IMainForm.ShowHome
            current = home
            Dim [module] As BaseModule = TryCast(ucListingDocument.Control, BaseModule)
            If [module] IsNot Nothing Then [module].ShowModule(home)
            windowsUIView.Controller.Activate(ucListingDocument)
            current = Nothing
        End Sub

        Private Sub ShowAgent(ByVal agent As Agent) Implements IMainForm.ShowAgent
            current = agent
            Dim [module] As BaseModule = TryCast(ucAgentsDocument.Control, BaseModule)
            If [module] IsNot Nothing Then [module].ShowModule(agent)
            windowsUIView.Controller.Activate(ucAgentsDocument)
            current = Nothing
        End Sub

        Private Sub windowsUIView_QueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs)
            Dim [module] As BaseModule = If(TypeOf e.Document.Tag Is BaseModule, CType(e.Document.Tag, BaseModule), CreateModuleByName(e.Document.ControlTypeName))
            [module].InitModule(barManager1, windowsUIView)
            Dim tile As BaseTile = Nothing
            If windowsUIView.Tiles.TryGetValue(e.Document, tile) Then
                Dim frame As TileItemFrame = tile.CurrentFrame
                Dim data As Object = If(current, If(frame IsNot Nothing, frame.Tag, Nothing))
                [module].ShowModule(data)
            End If

            e.Document.Tag = [module]
            e.Control = [module]
        End Sub

        Private Function CreateModuleByName(ByVal typeName As String) As BaseModule
            Dim moduleType = SafeTypeResolver.GetKnownType(GetType(frmMain).Assembly, typeName)
            Return TryCast(Activator.CreateInstance(moduleType), BaseModule)
        End Function

        Private Sub windowsUIView_TileClick(ByVal sender As Object, ByVal e As TileClickEventArgs)
            Dim tile As Tile = TryCast(e.Tile, Tile)
            If tile IsNot Nothing AndAlso tile.Document IsNot Nothing Then
                Dim [module] As BaseModule = TryCast(tile.Document.Control, BaseModule)
                If [module] IsNot Nothing Then
                    Dim frame As TileItemFrame = tile.CurrentFrame
                    Dim data As Object = If(frame IsNot Nothing, frame.Tag, Nothing)
                    [module].ShowModule(data)
                End If

                If tile.ActivationTarget Is page Then
                    page.Document = tile.Document
                    If tile.Elements.Count > 0 Then page.Caption = tile.Elements(0).Text
                End If
            End If
        End Sub

        Private Sub browserPage_ButtonClick(ByVal sender As Object, ByVal e As XtraBars.Docking2010.ButtonEventArgs)
            Dim page As Page = TryCast(sender, Page)
            If page IsNot Nothing Then
                Dim [module] As BaseModule = TryCast(page.Document.Control, BaseModule)
                If [module] IsNot Nothing AndAlso TypeOf [module] Is ucBrowser Then
                    If Equals("Refresh", e.Button.Properties.Tag) Then CType([module], ucBrowser).RefreshBrowser()
                    If Equals("Home", e.Button.Properties.Tag) Then CType([module], ucBrowser).Navigate()
                End If
            End If
        End Sub

        Private Sub windowsUIButtonPanel1_ButtonClick(ByVal sender As Object, ByVal e As XtraBars.Docking2010.ButtonEventArgs)
            Close()
        End Sub

        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            MyBase.OnFormClosing(e)
            Dim restoreTimerState As Boolean = False
            Dim ucSettingsControl As ucSettings = Nothing
            If page.Document IsNot Nothing AndAlso TypeOf page.Document.Control Is ucSettings Then
                ucSettingsControl = TryCast(page.Document.Control, ucSettings)
                restoreTimerState = ucSettingsControl.ActivationTimer.Enabled
            End If

            Dim closeAction As FlyoutAction = CreateCloseAction()
            flyout.Action = closeAction
            If restoreTimerState Then ucSettingsControl.ActivationTimer.Enabled = False
            If windowsUIView.ShowFlyoutDialog(flyout) <> DialogResult.Yes Then
                e.Cancel = True
                If restoreTimerState Then ucSettingsControl.ActivationTimer.Enabled = True
            End If
        End Sub

        Private Function CreateCloseAction() As FlyoutAction
            Dim closeAction As FlyoutAction = New FlyoutAction()
            closeAction.Caption = Text
            closeAction.Description = "Do you really want to close the demo?"
            closeAction.Commands.Add(FlyoutCommand.Yes)
            closeAction.Commands.Add(FlyoutCommand.No)
            Return closeAction
        End Function
    End Class
End Namespace
