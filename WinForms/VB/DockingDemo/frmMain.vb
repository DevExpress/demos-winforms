Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraBars.Demos.DockingDemo

    Public Partial Class frmMain
        Inherits ToolbarForm.ToolbarForm

        Private fileStreams As List(Of Stream)

        Public Sub New()
            InitializeComponent()
            ApplyHeaderStaticItemAppearance()
            Icon = DevExpress.Utils.ResourceImageHelperCore.CreateIconFromResourcesEx("DockingDemo.Resources.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Protected Overrides Sub OnLookAndFeelChangedCore()
            MyBase.OnLookAndFeelChangedCore()
            ApplyHeaderStaticItemAppearance()
        End Sub

        Private Sub ApplyHeaderStaticItemAppearance()
            barStaticItem1.ItemAppearance.Normal.BackColor = BarSkins.GetSkin(LookAndFeel)(BarSkins.SkinBar).Color.BackColor
            barStaticItem1.ItemAppearance.Normal.Options.UseBackColor = True
        End Sub

        Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            fileStreams = CreateResourceStreams()
            ucSolutionExplorer.InitTreeView(treeView1)
            BeginInvoke(New MethodInvoker(AddressOf InitDemo))
        End Sub

        Private Sub barManager1_Merge(ByVal sender As Object, ByVal e As BarManagerMergeEventArgs)
            barManager.Bars("Edit").Merge(e.ChildManager.Bars("Edit"))
        End Sub

        Private Sub barManager1_UnMerge(ByVal sender As Object, ByVal e As BarManagerMergeEventArgs)
            barManager.Bars("Edit").UnMerge()
        End Sub

        Private Sub InitDemo()
            AddNewDocument("File.cs")
            DevExpress.Demos.ClassViewer.AddClassInfo(treeView1, [GetType](), New Object() {Me, New ucSolutionExplorer()})
            SplashScreenManager.HideImage(500, Me)
        End Sub

        Private fileIndex As Integer = 0

        Private Sub AddNewDocument(ByVal fileName As String)
            fileStreams(fileIndex).Seek(0, SeekOrigin.Begin)
            AddNewDocument(fileName, fileStreams(fileIndex))
            fileIndex = System.Math.Min(System.Threading.Interlocked.Increment(fileIndex), fileIndex - 1) Mod 3
        End Sub

        Private Sub AddNewDocument(ByVal fileName As String, ByVal content As Stream)
            tabbedView.BeginUpdate()
            Dim control As ucCodeEditor = New ucCodeEditor()
            control.Name = fileName
            control.Text = fileName
            Dim document As BaseDocument = tabbedView.AddDocument(control)
            document.Footer = Directory.GetCurrentDirectory()
            control.LoadCode(content)
            tabbedView.EndUpdate()
            tabbedView.Controller.Activate(document)
        End Sub

        Private Sub repositoryItemComboBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.Enter AndAlso eFind.EditValue IsNot Nothing Then repositoryItemComboBox1.Items.Add(eFind.EditValue.ToString())
        End Sub

        Private projectIndex As Integer = 0

        Private Sub iNewItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            AddNewDocument(String.Format("File{0}.cs", System.Threading.Interlocked.Increment(projectIndex)))
        End Sub

        Private Sub iAbout_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Call XtraBars.BarManager.About()
        End Sub

        Private Sub iSolutionExplorer_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            dockPanel1.Show()
        End Sub

        Private Sub iProperties_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            dockPanel2.Show()
        End Sub

        Private Sub iTaskList_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            dockPanel3.Show()
        End Sub

        Private Sub iFindResults_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            dockPanel4.Show()
        End Sub

        Private Sub iOutput_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            dockPanel5.Show()
        End Sub

        Private Sub iToolbox_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            dockPanel6.Show()
        End Sub

        Private Sub solutionExplorer_PropertiesItemClick(ByVal sender As Object, ByVal e As System.EventArgs)
            dockPanel2.Show()
        End Sub

        Private Sub solutionExplorer_TreeViewItemClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim treeView As XtraTreeList.TreeList = TryCast(sender, XtraTreeList.TreeList)
            Dim focusedNodeText As String = treeView.FocusedNode.GetDisplayText(0)
            If Not focusedNodeText.Contains(".cs") Then Return
            Dim fileName As String = focusedNodeText.Replace(".cs", String.Empty)
            For Each document As BaseDocument In tabbedView.Documents
                If Equals(document.Caption, fileName & ".cs") Then
                    tabbedView.Controller.Activate(document)
                    Return
                End If
            Next

            Using stream As Stream = GetDocumentStream(fileName)
                If stream IsNot Nothing Then AddNewDocument(fileName & ".cs", stream)
            End Using
        End Sub

        Private Sub iSaveLayout_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Using dlg As SaveFileDialog = New SaveFileDialog()
                dlg.Filter = "XML files (*.xml)|*.xml"
                dlg.Title = "Save Layout"
                If dlg.ShowDialog() = DialogResult.OK Then
                    Refresh(True)
                    barManager.SaveToXml(dlg.FileName)
                    Refresh(False)
                End If
            End Using
        End Sub

        Private Sub iLoadLayout_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Using dlg As OpenFileDialog = New OpenFileDialog()
                dlg.Filter = "XML files (*.xml)|*.xml|All files|*.*"
                dlg.Title = "Restore Layout"
                If dlg.ShowDialog() = DialogResult.OK Then
                    Refresh(True)
                    Try
                        barManager.RestoreFromXml(dlg.FileName)
                    Catch
                    End Try

                    Refresh(False)
                End If
            End Using
        End Sub

        Private currentCursor As Cursor

        Private Overloads Sub Refresh(ByVal isWait As Boolean)
            If isWait Then
                currentCursor = Cursor.Current
                Cursor.Current = Cursors.WaitCursor
            Else
                Cursor.Current = currentCursor
            End If

            Refresh()
        End Sub

        Private Sub iExit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Close()
        End Sub
    End Class
End Namespace
