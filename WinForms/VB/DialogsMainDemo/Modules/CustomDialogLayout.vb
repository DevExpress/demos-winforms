Imports System
Imports System.IO
Imports System.Linq
Imports DevExpress.Internal
Imports DevExpress.XtraDialogs.FileExplorerExtensions

Namespace DevExpress.XtraDialogs.Demos

    Public Partial Class CustomDialogLayout
        Inherits TutorialControl

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {WhatsThisXMLFileName}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "CustomDialogLayout"
            End Get
        End Property

        Private ReadOnly listView As GridControlExtension

        Private ReadOnly breadCrumb As BreadCrumbExtension

        Private ReadOnly preview As PreviewPanelExtension

        Public Sub New()
            InitializeComponent()
            Dim initialPath As String = Path.GetDirectoryName(DataDirectoryHelper.GetDataFile("DemoText.txt"))
            btnOpenFile.Appearance.Options.UseBackColor = True
            If Not fileExplorerAssistant.IsDesignMode Then
                preview = fileExplorerAssistant.Attach(panelControl)
                '<gridControl>
                listView = fileExplorerAssistant.Attach(gridControl)
                AddHandler listView.FocusedLinkChanged, AddressOf OnListViewFocusedLinkChanged
                AddHandler listView.SelectionChanged, AddressOf OnListViewSelectionChanged
                AddHandler listView.CurrentItemChanged, AddressOf OnListViewCurrentItemChanged
                '</gridControl>
                AddHandler listView.AllowGoBackChanged, AddressOf OnUpdateNavigationButtons
                AddHandler listView.AllowGoForwardChanged, AddressOf OnUpdateNavigationButtons
                AddHandler listView.AllowGoUpChanged, AddressOf OnUpdateNavigationButtons
                '<currentPathEdit>
                breadCrumb = fileExplorerAssistant.Attach(currentPathEdit, Sub(x) AddHandler x.CurrentItemChanged, AddressOf OnCurrentPathEditCurrentItemChanged)
                '</currentPathEdit>
                '<treeList>
                fileExplorerAssistant.Attach(treeList, Sub(x)
                    x.RootNodes.Add(New EnvironmentSpecialFolderNode(Environment.SpecialFolder.MyComputer))
                    AddHandler x.CurrentItemChanged, AddressOf OnTreeCurrentItemChanged
                End Sub)
                '</treeList>
                listView.SetCurrentPath(initialPath)
                btnOpenFile.Enabled = False
            End If
        End Sub

        Private Sub OnUpdateNavigationButtons(ByVal sender As Object, ByVal e As EventArgs)
            btnUp.Enabled = listView.CanGoUp
            btnBack.Enabled = listView.CanGoBack
            btnForward.Enabled = listView.CanGoForward
        End Sub

        '<gridControl>
        Private Sub OnListViewSelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
            Dim previewItem = If(e.Selection.Count > 0, e.Selection.Last(), Nothing)
            preview.SetCurrentItem(previewItem)
        End Sub

        Private Sub OnListViewFocusedLinkChanged(ByVal sender As Object, ByVal e As FocusedLinkChangedEventArgs)
            If e.FocusedLink IsNot Nothing AndAlso Equals(e.FocusedLink.Extension, ".txt") Then
                fileNameEdit.Tag = e.FocusedLink.FullPath
                fileNameEdit.Text = e.FocusedLink.Identifier
                btnOpenFile.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
            Else
                fileNameEdit.Tag = Nothing
                fileNameEdit.Text = Nothing
                btnOpenFile.Appearance.Reset()
            End If

            btnOpenFile.Enabled = TypeOf fileNameEdit.Tag Is String
        End Sub

        Private Sub OnListViewCurrentItemChanged(ByVal sender As Object, ByVal e As CurrentItemChangedEventArgs)
            breadCrumb.SetCurrentItem(e.CurrentItem)
        End Sub

        '</gridControl>
        '<treeList>
        Private Sub OnTreeCurrentItemChanged(ByVal sender As Object, ByVal e As CurrentItemChangedEventArgs)
            listView.SetCurrentItem(e.CurrentItem)
        End Sub

        '</treeList>
        '<currentPathEdit>
        Private Sub OnCurrentPathEditCurrentItemChanged(ByVal sender As Object, ByVal e As CurrentItemChangedEventArgs)
            listView.SetCurrentItem(e.CurrentItem)
        End Sub

        '</currentPathEdit>
        Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs)
            listView.GoBack()
        End Sub

        Private Sub btnForward_Click(ByVal sender As Object, ByVal e As EventArgs)
            listView.GoForward()
        End Sub

        Private Sub btnUp_Click(ByVal sender As Object, ByVal e As EventArgs)
            listView.GoUp()
        End Sub

        Private Sub btnOpenFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim path = CStr(fileNameEdit.Tag)
            If File.Exists(path) Then Data.Utils.SafeProcess.Open(path)
        End Sub
    End Class
End Namespace
