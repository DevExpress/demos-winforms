Imports System
Imports System.Windows.Forms
Imports DevExpress.Dialogs.Core.Items
Imports DevExpress.XtraDialogs.FileExplorerExtensions
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraDialogs.Demos

    Public Partial Class TwoPanelFileBrowser
        Inherits TutorialControl

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {WhatsThisXMLFileName}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "TwoPanelFileBrowser"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            If Not fileExplorerAssistant.IsDesignMode Then
                '<currentPathEdit>
                Dim breadCrumb = fileExplorerAssistant.Attach(currentPathEdit, Sub(x)
                    x.CurrentPath = "c:\"
                    AddHandler x.CurrentItemChanged, AddressOf OnBreadCrumbCurrentItemChanged
                End Sub)
                '</currentPathEdit>
                '<leftGrid>
                Dim left = fileExplorerAssistant.Attach(leftGrid, Sub(x) x.CurrentPath = "c:\")
                '</leftGrid>
                '<rightGrid>
                Dim right = fileExplorerAssistant.Attach(rightGrid, Sub(x) x.CurrentPath = "c:\")
                activeExtension = left
                '</rightGrid>
                ' Setup dependencies between controls and extensions
                SetupPanel(left, breadCrumb, right)
                SetupPanel(right, breadCrumb, left)
                SetupSearchBox(leftGrid)
            End If
        End Sub

        Private lockCurrentItemChange As Integer = 0

        Private Sub OnBreadCrumbCurrentItemChanged(ByVal sender As Object, ByVal e As CurrentItemChangedEventArgs)
            If lockCurrentItemChange <> 0 Then Return
            lockCurrentItemChange += 1
            If activeExtension IsNot Nothing Then activeExtension.SetCurrentItem(e.CurrentItem)
            lockCurrentItemChange -= 1
        End Sub

        Private activeExtension As GridControlExtension

        Private Sub SetupPanel(ByVal source As GridControlExtension, ByVal breadCrumb As BreadCrumbExtension, ByVal target As GridControlExtension)
            SetupGridView(source, breadCrumb, target)
            AddHandler source.FocusedLinkChanged, Sub(s, e)
                UpdateButtons()
                UpdateActionButtons()
            End Sub
            AddHandler source.CurrentItemChanged, Sub(s, e)
                lockCurrentItemChange += 1
                breadCrumb.SetCurrentItem(e.CurrentItem)
                lockCurrentItemChange -= 1
            End Sub
        End Sub

        Private Sub SetupSearchBox(ByVal gridControl As GridControl)
            AddHandler searchBox.QueryIsSearchColumn, Sub(s, e) e.IsSearchColumn = Equals(e.FieldName, "Name")
            AddHandler searchBox.PreviewKeyDown, Sub(s, e)
                If e.KeyCode = Keys.Tab Then activeExtension.Control.MainView.Focus()
            End Sub
            searchBox.Client = gridControl
        End Sub

        Private Sub SetupGridView(ByVal source As GridControlExtension, ByVal breadCrumb As BreadCrumbExtension, ByVal target As GridControlExtension)
            Dim gridView = CType(source.Control.MainView, GridView)
            AddHandler source.SelectionChanged, Sub(s, e) UpdateActionButtons()
            AddHandler gridView.GotFocus, Sub(s, e)
                activeExtension = source
                lockCurrentItemChange += 1
                breadCrumb.SetCurrentItem(source.CurrentItem)
                lockCurrentItemChange -= 1
                searchBox.Client = source.Control
                UpdateButtons()
                UpdateActionButtons()
            End Sub
            '<leftGrid>
            AddHandler gridView.KeyDown, Sub(s, e)
                Select Case e.KeyCode
                    Case Keys.Tab
                        ToggleActivePanel()
                    Case Keys.F3
                        source.DoDefaultAction()
                    Case Keys.F4
                        source.Rename()
                    Case Keys.F5
                        source.CopySelection(target.CurrentItem)
                    Case Keys.F6
                        source.MoveSelection(target.CurrentItem)
                    Case Keys.F7
                        source.CreateNewFolder()
                    Case Keys.Delete, Keys.F8
                        source.DeleteSelection()
                End Select
            End Sub
        '<rightGrid>
        End Sub

        Private Sub ToggleActivePanel()
            If leftGrid.ContainsFocus Then
                rightGrid.Focus()
            Else
                leftGrid.Focus()
            End If
        End Sub

        Private Sub OnBack(ByVal sender As Object, ByVal e As EventArgs)
            activeExtension.GoBack()
        End Sub

        Private Sub OnForward(ByVal sender As Object, ByVal e As EventArgs)
            activeExtension.GoForward()
        End Sub

        Private Sub OnUp(ByVal sender As Object, ByVal e As EventArgs)
            activeExtension.GoUp()
        End Sub

        Private Sub OnOpen(ByVal sender As Object, ByVal e As EventArgs)
            activeExtension.DoDefaultAction()
        End Sub

        Private Sub OnRename(ByVal sender As Object, ByVal e As EventArgs)
            activeExtension.Rename()
        End Sub

        Private Sub OnCopy(ByVal sender As Object, ByVal e As EventArgs)
            activeExtension.CopySelection(GetTarget())
        End Sub

        Private Overloads Sub OnMove(ByVal sender As Object, ByVal e As EventArgs)
            activeExtension.MoveSelection(GetTarget())
        End Sub

        Private Sub OnNewFolder(ByVal sender As Object, ByVal e As EventArgs)
            activeExtension.CreateNewFolder()
        End Sub

        Private Sub OnDelete(ByVal sender As Object, ByVal e As EventArgs)
            activeExtension.DeleteSelection()
        End Sub

        Private Function GetTarget() As ShellItem
            Dim left = TryCast(fileExplorerAssistant.Extensions(leftGrid), GridControlExtension)
            If Not ReferenceEquals(activeExtension, left) Then Return left.CurrentItem
            Return TryCast(fileExplorerAssistant.Extensions(rightGrid), GridControlExtension).CurrentItem
        End Function

        '<sidePanelTop>
        Private Sub UpdateButtons()
            btnUp.Enabled = activeExtension.CanGoUp
            btnBack.Enabled = activeExtension.CanGoBack
            btnForward.Enabled = activeExtension.CanGoForward
        End Sub

        '</sidePanelTop>
        '</sidePanelBottom>
        Private Sub UpdateActionButtons()
            btnRename.Enabled = activeExtension.CanRename
            btnCopy.Enabled = activeExtension.CanCopySelection
            btnMove.Enabled = activeExtension.CanMoveSelection
            btnNewFolder.Enabled = activeExtension.CanCreateNewFolder
            btnDelete.Enabled = activeExtension.CanDeleteSelection
        End Sub
    '</sidePanelBottom>
    End Class
End Namespace
