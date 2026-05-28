Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleBreadCrumbEdit
        Inherits TutorialControl

        Private currentPath As String

        Private properties As RepositoryItemBreadCrumbEdit

        Public Sub New()
            InitializeComponent()
            properties = BreadCrumb.Properties
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleBreadCrumbEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "breadCrumbEdit"
            End Get
        End Property

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl1)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitValues()
        End Sub

        Private Sub InitValues()
            currentPath = DevExpress.Data.Utils.SafeEnvironment.Desktop
            BreadCrumb.Path = currentPath
            For Each driveInfo As DriveInfo In FileSystemHelper.GetFixedDrives()
                BreadCrumb.Properties.History.Add(New BreadCrumbHistoryItem(driveInfo.RootDirectory.ToString()))
            Next

            cbeMode.Properties.Items.AddEnum(GetType(BreadCrumbMode))
            cbeMode.EditValue = properties.BreadCrumbMode
            seDropDownRowCount.Value = properties.NodeDropDownRowCount
            ceShowRootGlyph.Checked = properties.ShowRootGlyph
            If cbeImages.Properties.Items.Count > 0 Then cbeImages.SelectedIndex = 0
        End Sub

        ' <breadCrumbEdit>
        Private Sub OnBreadCrumbPathChanged(ByVal sender As Object, ByVal e As BreadCrumbPathChangedEventArgs)
            pathLabel.Text = e.Path
            currentPath = pathLabel.Text
            AddEventEntry("PathChanged", e.Path)
            UpdateControls()
        End Sub

        Private Sub OnBreadCrumbNewNodeAdding(ByVal sender As Object, ByVal e As BreadCrumbNewNodeAddingEventArgs)
            AddEventEntry("NewNodeAdding", e.Node)
            e.Node.PopulateOnDemand = True
        End Sub

        Private Sub OnBreadCrumbQueryChildNodes(ByVal sender As Object, ByVal e As BreadCrumbQueryChildNodesEventArgs)
            AddEventEntry("QueryChildNodes", e.Node)
            If Equals(e.Node.Caption, "Root") Then
                InitBreadCrumbRootNode(e.Node)
                Return
            End If

            If Equals(e.Node.Caption, "Computer") Then
                InitBreadCrumbComputerNode(e.Node)
                Return
            End If

            Dim dir As String = e.Node.Path
            If Not FileSystemHelper.IsDirExists(dir) Then Return
            Dim subDirs As String() = FileSystemHelper.GetSubFolders(dir)
            For i As Integer = 0 To subDirs.Length - 1
                e.Node.ChildNodes.Add(CreateNode(subDirs(i)))
            Next
        End Sub

        Private Sub OnBreadCrumbValidatePath(ByVal sender As Object, ByVal e As BreadCrumbValidatePathEventArgs)
            AddEventEntry("ValidatePath", e.Path)
            If Not FileSystemHelper.IsDirExists(e.Path) Then
                e.ValidationResult = BreadCrumbValidatePathResult.Cancel
                Return
            End If

            e.ValidationResult = BreadCrumbValidatePathResult.CreateNodes
        End Sub

        Private Sub OnBreadCrumbRootGlyphClick(ByVal sender As Object, ByVal e As EventArgs)
            AddEventEntry("RootGlyphClick", sender)
            BreadCrumb.Properties.BreadCrumbMode = BreadCrumbMode.Edit
            BreadCrumb.SelectAll()
        End Sub

        Private Sub OnBreadCrumbNodeClick(ByVal sender As Object, ByVal e As BreadCrumbNodeClickEventArgs)
            AddEventEntry("NodeClick", e.Node)
        End Sub

        Private Sub OnBreadCrumbShowUserActionMenu(ByVal sender As Object, ByVal e As BreadCrumbShowUserActionMenuEventArgs)
            AddEventEntry("ShowUserActionMenu", sender)
        End Sub

        Private Sub OnBreadCrumbShownNodeDropdown(ByVal sender As Object, ByVal e As BreadCrumbShownNodeDropDownEventArgs)
            AddEventEntry("ShownNodeDropdown", e.Node)
        End Sub

        Private Sub OnBreadCrumbHiddenNodeDropDown(ByVal sender As Object, ByVal e As BreadCrumbHiddenNodeDropDownEventArgs)
            AddEventEntry("HiddenNodeDropDown", e.Node)
        End Sub

        Private Sub OnBreadCrumbPathRejected(ByVal sender As Object, ByVal e As BreadCrumbPathRejectedEventArgs)
            AddEventEntry("PathRejected", e.Path)
        End Sub

        Private Sub OnBreadCrumbSelectedNodeChanged(ByVal sender As Object, ByVal e As BreadCrumbSelectedNodeChangedEventArgs)
            AddEventEntry("SelectedNodeChanged", e.NewNode)
            selNodeValueLabel.Text = If(e.NewNode IsNot Nothing, e.NewNode.ToString(), "(none)")
        End Sub

        Private Sub OnBreadCrumbSelectorClientEmptySpaceClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            AddEventEntry("SelectorClientEmptySpaceClick", e.Location)
        End Sub

        Private Sub InitBreadCrumbRootNode(ByVal node As BreadCrumbNode)
            node.ChildNodes.Add(New BreadCrumbNode("Desktop", DevExpress.Data.Utils.SafeEnvironment.Desktop))
            node.ChildNodes.Add(New BreadCrumbNode("Documents", DevExpress.Data.Utils.SafeEnvironment.Recent))
            node.ChildNodes.Add(New BreadCrumbNode("Music", DevExpress.Data.Utils.SafeEnvironment.MyMusic))
            node.ChildNodes.Add(New BreadCrumbNode("Pictures", DevExpress.Data.Utils.SafeEnvironment.MyPictures))
            node.ChildNodes.Add(New BreadCrumbNode("Video", DevExpress.Data.Utils.SafeEnvironment.MyVideos))
            node.ChildNodes.Add(New BreadCrumbNode("Program Files", DevExpress.Data.Utils.SafeEnvironment.ProgramFiles))
            node.ChildNodes.Add(New BreadCrumbNode("Windows", DevExpress.Data.Utils.SafeEnvironment.Windows))
        End Sub

        Private Sub InitBreadCrumbComputerNode(ByVal node As BreadCrumbNode)
            For Each driveInfo As DriveInfo In FileSystemHelper.GetFixedDrives()
                node.ChildNodes.Add(New BreadCrumbNode(driveInfo.Name, driveInfo.RootDirectory))
            Next
        End Sub

        Private Function CreateNode(ByVal path As String) As BreadCrumbNode
            Dim folderName As String = FileSystemHelper.GetDirName(path)
            Return New BreadCrumbNode(folderName, folderName, True)
        End Function

        ' </breadCrumbEdit>
        ' <btnClearEventLog>
        Private Sub OnClearEventLogClick(ByVal sender As Object, ByVal e As EventArgs)
            eventsLog.Text = String.Empty
        End Sub

        ' </btnClearEventLog>
        ' <cbeMode>
        Private Sub OnBreadCrumbModeChanged(ByVal sender As Object, ByVal e As EventArgs)
            If properties Is Nothing Then Return
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            properties.BreadCrumbMode = CType(comboBox.EditValue, BreadCrumbMode)
        End Sub

        ' </cbeMode>
        ' <seDropDownRowCount>
        Private Sub OnBreadCrumbDropDownRowCountChanged(ByVal sender As Object, ByVal e As EventArgs)
            If properties Is Nothing Then Return
            Dim spinEdit As SpinEdit = CType(sender, SpinEdit)
            properties.NodeDropDownRowCount = CInt(spinEdit.Value)
        End Sub

        ' </seDropDownRowCount>
        ' <ceShowRootGlyph>
        Private Sub OnShowRootGlyphCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If properties Is Nothing Then Return
            Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
            properties.ShowRootGlyph = checkEdit.Checked
        End Sub

        ' </ceShowRootGlyph>
        ' <cbeImages>
        Private Sub OnBreadCrumbSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If properties Is Nothing Then Return
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            properties.ImageIndex = comboBox.SelectedIndex
            properties.RootImageIndex = properties.ImageIndex
        End Sub

        ' </cbeImages>
        ' <btnGoUp>
        Private Sub OnGoUpClick(ByVal sender As Object, ByVal e As EventArgs)
            BreadCrumb.GoUp()
        End Sub

        ' </btnGoUp>
        ' <btnGoBack>
        Private Sub OnGoBackClick(ByVal sender As Object, ByVal e As EventArgs)
            BreadCrumb.GoBack()
        End Sub

        ' </btnGoBack>
        ' <btnGoForward>
        Private Sub OnGoForwardClick(ByVal sender As Object, ByVal e As EventArgs)
            BreadCrumb.GoForward()
        End Sub

        ' </btnGoForward>
        Private Sub AddEventEntry(ByVal entry As String, ByVal obj As Object)
            Dim val As String = String.Empty
            If obj IsNot Nothing Then
                val = If((TypeOf obj Is BreadCrumbEdit), GetType(BreadCrumbEdit).Name, obj.ToString())
            Else
                val = "(null)"
            End If

            eventsLog.Text = String.Format("{0}: {1}{2}", entry, val, Environment.NewLine) & eventsLog.Text
        End Sub

        Private Sub UpdateControls()
            btnGoBack.Enabled = BreadCrumb.CanGoBack
            btnGoForward.Enabled = BreadCrumb.CanGoForward
            btnGoUp.Enabled = BreadCrumb.CanGoUp
        End Sub

        Private ReadOnly Property BreadCrumb As BreadCrumbEdit
            Get
                Return breadCrumbEdit
            End Get
        End Property
    End Class
End Namespace
