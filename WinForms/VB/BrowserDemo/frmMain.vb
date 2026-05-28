Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.BrowserDemo

    Public Partial Class frmMain
        Inherits TabForm

        Public Sub New()
            Me.New(True)
        End Sub

        Public Sub New(ByVal hasPage As Boolean)
            InitializeComponent()
            Initialize(hasPage)
        End Sub

        Protected Sub Initialize(ByVal shouldCreateWebBrowser As Boolean)
            shouldInitHomePage = shouldCreateWebBrowser
            If shouldCreateWebBrowser Then
                CreatePageWebBrowser(TabFormControl.SelectedPage)
                SubscribeOnPageEvents()
            Else
                TabFormControl.Pages.Clear()
                TabFormControl.SelectedPage = Nothing
            End If

            AddHandler TabFormControl.SelectedPageChanged, AddressOf OnSelectedPageChanged
            AddHandler TabFormControl.SelectedPageChanging, AddressOf OnSelectedPageChanging
            AddHandler TabFormControl.PageCreated, AddressOf OnPageCreated
            Icon = DevExpress.Utils.ResourceImageHelperCore.CreateIconFromResourcesEx("BrowserDemo.AppIcon.ico", GetType(frmMain).Assembly)
            barManager1.ForceLinkCreate()
            AddHandler barManager1.GetController().Changed, New EventHandler(AddressOf ChangedController)
            InitSkins()
            Focus()
        End Sub

        Private Sub OnPageCreated(ByVal sender As Object, ByVal e As PageCreatedEventArgs)
            If HidePageCaption Then e.Page.Text = String.Empty
            CreatePageWebBrowser(e.Page)
        End Sub

        Private Sub CreatePageWebBrowser(ByVal page As TabFormPage)
            Dim browser As TabFormWebBrowser = New TabFormWebBrowser(page)
            page.ContentContainer.Controls.Add(browser)
            browser.Dock = DockStyle.Fill
            browser.ScriptErrorsSuppressed = True
            page.ContentContainer.Controls.Add(New BrowserNavigationControl())
        End Sub

        Private Sub OnSelectedPageChanging(ByVal sender As Object, ByVal e As TabFormSelectedPageChangingEventArgs)
            UnsubscribeOnPageEvents()
        End Sub

        Private Sub OnSelectedPageChanged(ByVal sender As Object, ByVal e As TabFormSelectedPageChangedEventArgs)
            SubscribeOnPageEvents()
            If NavigationPanel Is Nothing Then Return
            If WebBrowser Is Nothing OrElse WebBrowser.Url Is Nothing Then
                NavigationPanel.SearchItem.EditValue = String.Empty
            Else
                NavigationPanel.SearchItem.EditValue = WebBrowser.Url.AbsoluteUri
            End If

            CheckButtons()
        End Sub

        Private Sub CheckButtons()
            NavigationPanel.ForwardButton.Enabled = WebBrowser.CanGoForward
            NavigationPanel.BackButton.Enabled = WebBrowser.CanGoBack
        End Sub

        Private Sub SubscribeOnPageEvents()
            If WebBrowser IsNot Nothing Then
                AddHandler WebBrowser.Navigated, New WebBrowserNavigatedEventHandler(AddressOf webBrowser1_Navigated)
                AddHandler WebBrowser.CanGoBackChanged, New EventHandler(AddressOf OnWebBrowserCanGoBackChanged)
                AddHandler WebBrowser.CanGoForwardChanged, New EventHandler(AddressOf OnWebBrowserCanGoForwardChanged)
                AddHandler NavigationPanel.SearchPanel.CloseUp, New XtraEditors.Controls.CloseUpEventHandler(AddressOf repositoryItemComboBox1_CloseUp)
                AddHandler NavigationPanel.SearchPanel.KeyDown, New KeyEventHandler(AddressOf repositoryItemComboBox1_KeyDown)
                AddHandler NavigationPanel.SearchPanel.Validating, New System.ComponentModel.CancelEventHandler(AddressOf repositoryItemComboBox1_Validating)
                AddHandler NavigationPanel.BackButton.ItemClick, AddressOf OnBackButtonItemClick
                AddHandler NavigationPanel.ForwardButton.ItemClick, AddressOf OnForwardButtonItemClick
                AddHandler NavigationPanel.RefreshButton.ItemClick, AddressOf OnRefreshButtonItemClick
            End If
        End Sub

        Private Sub UnsubscribeOnPageEvents()
            If WebBrowser IsNot Nothing Then
                RemoveHandler WebBrowser.Navigated, New WebBrowserNavigatedEventHandler(AddressOf webBrowser1_Navigated)
                RemoveHandler WebBrowser.CanGoBackChanged, New EventHandler(AddressOf OnWebBrowserCanGoBackChanged)
                RemoveHandler WebBrowser.CanGoForwardChanged, New EventHandler(AddressOf OnWebBrowserCanGoForwardChanged)
                RemoveHandler NavigationPanel.SearchPanel.CloseUp, New XtraEditors.Controls.CloseUpEventHandler(AddressOf repositoryItemComboBox1_CloseUp)
                RemoveHandler NavigationPanel.SearchPanel.KeyDown, New KeyEventHandler(AddressOf repositoryItemComboBox1_KeyDown)
                RemoveHandler NavigationPanel.SearchPanel.Validating, New System.ComponentModel.CancelEventHandler(AddressOf repositoryItemComboBox1_Validating)
                RemoveHandler NavigationPanel.BackButton.ItemClick, AddressOf OnBackButtonItemClick
                RemoveHandler NavigationPanel.ForwardButton.ItemClick, AddressOf OnForwardButtonItemClick
                RemoveHandler NavigationPanel.RefreshButton.ItemClick, AddressOf OnRefreshButtonItemClick
            End If
        End Sub

        Public ReadOnly Property WebBrowser As WebBrowser
            Get
                If TabFormControl.SelectedPage Is Nothing Then Return Nothing
                For Each ctrl As Control In TabFormControl.SelectedPage.ContentContainer.Controls
                    If TypeOf ctrl Is WebBrowser Then Return TryCast(ctrl, WebBrowser)
                Next

                Return Nothing
            End Get
        End Property

        Public ReadOnly Property NavigationPanel As BrowserNavigationControl
            Get
                If TabFormControl.SelectedPage Is Nothing Then Return Nothing
                For Each ctrl As Control In TabFormControl.SelectedPage.ContentContainer.Controls
                    If TypeOf ctrl Is BrowserNavigationControl Then Return TryCast(ctrl, BrowserNavigationControl)
                Next

                Return Nothing
            End Get
        End Property

        Private skinProcessing As Boolean = False

        Private currentAddress As String = ""

#Region "Skins"
        Private Sub InitSkins()
            barManager1.ForceInitialize()
        End Sub

        Private Sub ChangedController(ByVal sender As Object, ByVal e As EventArgs)
            If skinProcessing Then Return
            Dim paintStyleName As String = barManager1.GetController().PaintStyleName
            If "DefaultSkin".IndexOf(paintStyleName) >= 0 Then
                Skins.SkinManager.EnableFormSkins()
            Else
                Skins.SkinManager.DisableFormSkins()
            End If

            skinProcessing = True
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
            skinProcessing = False
        End Sub

#End Region
        Private Sub AddNewItem(ByVal s As String)
            If NavigationPanel Is Nothing Then Return
            If Not Equals(s, "") Then
                Dim isAdded As Boolean = False
                For i As Integer = 0 To NavigationPanel.SearchPanel.Items.Count - 1
                    If Equals(NavigationPanel.SearchPanel.Items(i).ToString(), s) Then
                        isAdded = True
                        Exit For
                    End If
                Next

                If Not isAdded Then NavigationPanel.SearchPanel.Items.Add(s)
            End If
        End Sub

        Protected Friend Sub GoToItem(ByVal address As String)
            If Equals(address, Nothing) Then Return
            If Not Equals(currentAddress, address) Then
                NavigationPanel.SearchItem.EditValue = address
                Try
                    If WebBrowser IsNot Nothing AndAlso Not WebBrowser.IsBusy Then WebBrowser.Navigate(address)
                Catch
                End Try
            End If
        End Sub

        Private ReadOnly Property Address As String
            Get
                If barManager1.ActiveEditor IsNot Nothing AndAlso barManager1.ActiveEditor.EditValue IsNot Nothing Then Return barManager1.ActiveEditor.EditValue.ToString()
                Return Nothing
            End Get
        End Property

        Private Sub repositoryItemComboBox1_CloseUp(ByVal sender As Object, ByVal e As XtraEditors.Controls.CloseUpEventArgs)
            GoToItem(Address)
        End Sub

        Private Sub repositoryItemComboBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Dim edit As XtraEditors.ComboBoxEdit = TryCast(sender, XtraEditors.ComboBoxEdit)
            If e.KeyData = Keys.Escape Then
                e.Handled = True
                edit.SelectAll()
            End If

            If e.KeyData = Keys.Enter AndAlso Not edit.IsPopupOpen Then
                NavigationPanel.Manager.ActiveEditItemLink.PostEditor()
                edit.SelectAll()
                e.Handled = True
                GoToItem(NavigationPanel.SearchItem.EditValue.ToString())
            End If
        End Sub

        Private Sub repositoryItemComboBox1_Validating(ByVal sender As Object, ByVal e As CancelEventArgs)
            GoToItem(Address)
        End Sub

        Private blankString As String = "about:blank"

        Private Sub webBrowser1_Navigated(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs)
            If Not Equals(sender, WebBrowser) Then Return
            Dim documentUri As String = WebBrowser.Url.AbsoluteUri
            Dim eventUri As String = e.Url.AbsoluteUri
            If Equals(eventUri, blankString) Then Return
            If Not Equals(documentUri, eventUri) Then Return
            If barManager1.ActiveEditor IsNot Nothing Then barManager1.ActiveEditItemLink.CloseEditor()
            If CorrectAddress(eventUri) Then
                NavigationPanel.SearchItem.EditValue = eventUri
                currentAddress = eventUri
                AddNewItem(eventUri)
            End If
        End Sub

        Private Sub OnWebBrowserCanGoForwardChanged(ByVal sender As Object, ByVal e As EventArgs)
            NavigationPanel.ForwardButton.Enabled = WebBrowser.CanGoForward
        End Sub

        Private Sub OnWebBrowserCanGoBackChanged(ByVal sender As Object, ByVal e As EventArgs)
            NavigationPanel.BackButton.Enabled = WebBrowser.CanGoBack
        End Sub

        Private Function CorrectAddress(ByVal name As String) As Boolean
            Return Not name.StartsWith("javascript:", StringComparison.OrdinalIgnoreCase)
        End Function

        Private Sub OnRefreshButtonItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If WebBrowser Is Nothing OrElse WebBrowser.Url Is Nothing Then Return
            WebBrowser.Navigate(WebBrowser.Url.AbsoluteUri)
        End Sub

        Private Sub OnBackButtonItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Try
                If WebBrowser IsNot Nothing Then WebBrowser.GoBack()
            Catch
            End Try
        End Sub

        Private Sub OnForwardButtonItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Try
                If WebBrowser IsNot Nothing Then WebBrowser.GoForward()
            Catch
            End Try
        End Sub

        Private shouldInitHomePage As Boolean = True

        Protected Friend Sub InitHomePage()
            GoToItem("www.devexpress.com/Subscriptions/Universal.xml")
        End Sub

        Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs)
            If shouldInitHomePage Then BeginInvoke(New MethodInvoker(AddressOf InitHomePage))
        End Sub

        Private Property HidePageCaption As Boolean

        Protected Friend Sub Navigate(ByVal address As String)
            HidePageCaption = True
            Try
                tabFormControl1.AddNewPage()
            Finally
                HidePageCaption = False
            End Try

            GoToItem(address)
        End Sub

        Private Sub OnOuterFormCreating(ByVal sender As Object, ByVal e As OuterFormCreatingEventArgs)
            e.Form = New frmMain(False)
            OpenFormCount += 1
        End Sub

        Private Shared OpenFormCount As Integer = 1
    End Class
End Namespace
