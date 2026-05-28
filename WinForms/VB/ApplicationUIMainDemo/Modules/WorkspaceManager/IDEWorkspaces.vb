Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraNavBar

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class IDEWorkspaces
        Inherits TutorialControlBase

        Private fileStreams As List(Of Stream)

        Public Sub New()
            InitializeComponent()
            FillNavBar()
            InitPropertyGrid()
            AddPerformanceReport()
            LoadWorkspaces()
            AddHandler tabbedView1.QueryControl, AddressOf tabbedView1_QueryControl
        End Sub

        Private Sub LoadWorkspaces()
            workspaceManager1.LoadWorkspace("Default Workspace", GetStream("Workspace 1.xml"))
            workspaceManager1.LoadWorkspace("Performance Analyze", GetStream("Workspace 2.xml"))
            workspaceManager1.LoadWorkspace("Compare Documents", GetStream("Workspace 3.xml"))
        End Sub

        Private Sub AddPerformanceReport()
            fileStreams = CreateResourceStreams()
            Dim document = tabbedView1.AddDocument(New ucPerfomanceGrid())
            document.Caption = "Analyzed Report"
        End Sub

        Private Sub InitPropertyGrid()
            Dim propertyGrid As XtraPropertyGrid = New XtraPropertyGrid()
            dockPanel3_Container.Controls.Add(propertyGrid)
            propertyGrid.Dock = DockStyle.Fill
            propertyGrid.SelectedObject = workspaceManager1
        End Sub

        Private fileIndex As Integer = 0

        Private Sub tabbedView1_QueryControl(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.QueryControlEventArgs)
            Dim control = New ucCodeEditor()
            control.LoadCode(fileStreams(fileIndex Mod 3))
            fileIndex += 1
            e.Control = control
        End Sub

        Private Sub FillNavBar()
            Dim standardGroup As NavBarGroup = navBarControl1.Groups.Add()
            standardGroup.Caption = "Standard"
            standardGroup.Name = "standardGroup"
            Dim devexpressGroup As NavBarGroup = navBarControl1.Groups.Add()
            devexpressGroup.Caption = "DevExpress"
            devexpressGroup.Name = "devexpressGroup"
            devexpressGroup.Expanded = True
            Dim index As Integer = 0
            For Each key As String In toolboxSvgImages.Keys
                Dim item As NavBarItem = New NavBarItem()
                item.Caption = GetCaption(key)
                item.Name = item.Caption
                item.SmallImageIndex = index
                navBarControl1.Items.Add(item)
                If Not key.Contains("DX") Then
                    standardGroup.ItemLinks.Add(item)
                Else
                    devexpressGroup.ItemLinks.Add(item)
                End If

                index += 1
            Next
        End Sub

        Private Function GetCaption(ByVal key As String) As String
            Return If(key.Contains("_"), key.Substring(0, key.IndexOf("_"c)), key)
        End Function

        Private Sub barToggleSwitchItem1_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            If barToggleSwitchItem1.Checked Then
                dockManager1.Style = XtraBars.Docking2010.Views.DockingViewStyle.Light
                tabbedView1.Style = XtraBars.Docking2010.Views.DockingViewStyle.Light
                Padding = Padding.Empty
            Else
                dockManager1.Style = XtraBars.Docking2010.Views.DockingViewStyle.Classic
                tabbedView1.Style = XtraBars.Docking2010.Views.DockingViewStyle.Classic
                Padding = New Padding(10)
            End If
        End Sub

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
