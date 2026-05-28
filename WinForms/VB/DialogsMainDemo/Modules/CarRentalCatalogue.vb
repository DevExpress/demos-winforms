Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Dialogs.Core.View
Imports DevExpress.Dialogs.Core.ViewModel
Imports DevExpress.Internal
Imports DevExpress.XtraDialogs.Demos.Helpers.Data
Imports DevExpress.XtraDialogs.FileExplorerExtensions
Imports System.Runtime.InteropServices

Namespace DevExpress.XtraDialogs.Demos

    Public Partial Class CarRentalCatalogue
        Inherits TutorialControl

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {WhatsThisXMLFileName}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "CarRentalCatalogue"
            End Get
        End Property

        Private ReadOnly listViewExtension As GridControlExtension

        Private ReadOnly treeExtension As TreeListExtension

        Private ReadOnly models As List(Of VehiclesData.Model)

        Private ReadOnly dbFileName As String

        Public Sub New()
            InitializeComponent()
            models = GetModels(dbFileName)
            InitializeEditors()
            If Not fileExplorerAssistant.IsDesignMode Then
                '<grid>
                listViewExtension = fileExplorerAssistant.Attach(grid, Sub(x)
                    x.ViewMode = ViewMode.LargeIcon
                    x.FilterString = "Car files (*.car)|*.car"
                    x.ItemsType = DataSourceItemsType.All
                    AddHandler x.QueryLinkImage, AddressOf OnQueryListViewImage
                    AddHandler x.FocusedLinkChanged, AddressOf OnListViewFocusedLinkChanged
                    AddHandler x.CustomLinkFilter, AddressOf OnListViewCustomLinkFilter
                End Sub)
                '</grid>
                '<catalogueTree>
                treeExtension = fileExplorerAssistant.Attach(catalogueTree, Sub(x)
                    x.IconSize = New Size(32, 32)
                    CreateVirtualHierarchy(models, x.RootNodes)
                    CreateDataFolderHierarchy(models, dbFileName, x.RootNodes)
                    AddHandler x.CurrentItemChanged, AddressOf OnTreeCurrentItemChanged
                End Sub)
                AddHandler catalogueTree.CustomColumnDisplayText, AddressOf OnTreeCustomColumnDisplayText
                '</catalogueTree>
                modelBindingSource.DataSource = models.First()
            End If

            SetToolTipController(Me, grid)
        End Sub

        '<catalogueTree>
        Private Sub OnTreeCustomColumnDisplayText(ByVal sender As Object, ByVal e As XtraTreeList.CustomColumnDisplayTextEventArgs)
            If e.Node IsNot Nothing AndAlso e.Node.ParentNode Is Nothing AndAlso String.Equals("Cars", TryCast(e.Value, String)) Then e.DisplayText = GetCarsFolderPath(dbFileName)
        End Sub

        '</catalogueTree>
        Private Sub InitializeEditors()
            CategoryImageComboBoxEdit.Properties.AddEnum(GetType(VehiclesData.Category), True)
            TransmissionTypeComboBoxEdit.Properties.AddEnum(GetType(VehiclesData.TransmissionType), True)
        End Sub

        '<grid>
        Private Sub OnQueryListViewImage(ByVal sender As Object, ByVal e As QueryLinkImageEventArgs)
            Dim model = TryCast(e.Link.Tag, VehiclesData.Model)
            If model Is Nothing Then
                Dim trademark = TryCast(e.Link.Tag, VehiclesData.Trademark)
                If trademark IsNot Nothing Then e.Image = trademark.GetLogo(e.ImageSize)
            Else
                e.Image = model.GetImage(e.ImageSize)
            End If
        End Sub

        '</grid>
        Private Sub OnTreeCurrentItemChanged(ByVal sender As Object, ByVal e As CurrentItemChangedEventArgs)
            listViewExtension.SetCurrentItem(e.CurrentItem)
        End Sub

        '<grid>
        Private Sub OnListViewFocusedLinkChanged(ByVal sender As Object, ByVal e As FocusedLinkChangedEventArgs)
            Dim item = If(e.FocusedLink?.Item, listViewExtension.CurrentItem)
            If item IsNot Nothing Then
                Dim model = TryCast(item.Tag, VehiclesData.Model)
                If model Is Nothing Then
                    Dim trademark = TryCast(item.Tag, VehiclesData.Trademark)
                    If trademark IsNot Nothing Then
                        Dim node As VirtualFolderNode = Nothing
                        If trademarkNodes.TryGetValue(trademark.Name, node) Then
                            Dim child = TryCast(node.Nodes(0), VirtualItemNode)
                            If child IsNot Nothing Then model = TryCast(child.Tag, VehiclesData.Model)
                        End If
                    End If

                    Dim category = TryCast(item.Tag, VehiclesData.BodyStyle)
                    If category IsNot Nothing Then
                        Dim node As VirtualFolderNode = Nothing
                        If stylesNodes.TryGetValue(category.Name, node) Then
                            Dim child = TryCast(node.Nodes(0), VirtualItemNode)
                            If child IsNot Nothing Then model = TryCast(child.Tag, VehiclesData.Model)
                        End If
                    End If

                    If model Is Nothing AndAlso Not String.IsNullOrEmpty(item.Name) Then
                        Dim id As Integer
                        If item.Name.EndsWith(".car") Then
                            If Integer.TryParse(ReadCarIdFormFile(e.FocusedLink.FullPath), id) Then model = models.Find(Function(x) x.ID = id)
                        Else
                            If System.IO.Directory.Exists(item.FullPath) Then
                                Dim firstCarFile = System.IO.Directory.GetFiles(item.FullPath, "*.car").FirstOrDefault()
                                If Not String.IsNullOrEmpty(firstCarFile) Then
                                    If Integer.TryParse(ReadCarIdFormFile(firstCarFile), id) Then model = models.Find(Function(x) x.ID = id)
                                End If
                            End If
                        End If
                    End If
                End If

                modelBindingSource.DataSource = If(CObj(model), GetType(VehiclesData.Model))
            Else
                modelBindingSource.DataSource = GetType(VehiclesData.Model)
            End If
        End Sub

        Private Sub OnListViewCustomLinkFilter(ByVal sender As Object, ByVal e As Dialogs.Core.CustomLinkFilterEventArgs)
            If TypeOf e.Link.Tag Is VehiclesData.Model Then
                e.Visible = True
                e.Handled = True
            End If
        End Sub

        '</grid>
        Private Shared Function GetModels(<Out> ByRef dbFileName As String) As List(Of VehiclesData.Model)
            dbFileName = DevAVDataDirectoryHelper.GetFile("Vehicles.xml")
            Return VehiclesData.InitXMLDataCore(dbFileName)
        End Function

        Private ReadOnly trademarkNodes As Dictionary(Of String, VirtualFolderNode) = New Dictionary(Of String, VirtualFolderNode)()

        Private ReadOnly stylesNodes As Dictionary(Of String, VirtualFolderNode) = New Dictionary(Of String, VirtualFolderNode)()

        Private Sub CreateVirtualHierarchy(ByVal models As List(Of VehiclesData.Model), ByVal nodes As NodesCollection)
            Dim fromDataBaseNode = New VirtualFolderNode("(DevAVDb)\Vehicles (SQL Server)")
            fromDataBaseNode.AutoExpand = False
            fromDataBaseNode.ImageOptions.SvgImage = Properties.Resources.database
            Dim fromWebAPINode = New VirtualFolderNode("https:\\api.devav.com\getVehicles (Web API)")
            fromWebAPINode.AutoExpand = True
            fromWebAPINode.ImageOptions.SvgImage = Properties.Resources.network
            For Each model In models
                Dim trademarkNode As VirtualFolderNode = Nothing
                If Not trademarkNodes.TryGetValue(model.TrademarkName, trademarkNode) Then
                    trademarkNode = New VirtualFolderNode(model.TrademarkName)
                    trademarkNode.ImageOptions.SvgImage = Properties.Resources.folder
                    trademarkNode.TypeName = "Trademark"
                    trademarkNode.Tag = model.Trademarks(model.Trademark - 1)
                    fromDataBaseNode.Nodes.Add(trademarkNode)
                    trademarkNodes.Add(model.TrademarkName, trademarkNode)
                End If

                Dim styleNode As VirtualFolderNode = Nothing
                If Not stylesNodes.TryGetValue(model.BodyStyleName, styleNode) Then
                    styleNode = New VirtualFolderNode(model.BodyStyleName)
                    styleNode.ImageOptions.SvgImage = Properties.Resources.folder
                    styleNode.TypeName = "Category"
                    styleNode.Tag = model.BodyStyles(model.BodyStyle - 1)
                    fromWebAPINode.Nodes.Add(styleNode)
                    stylesNodes.Add(model.BodyStyleName, styleNode)
                End If

                Dim carNode = New VirtualItemNode(model.Name & ".car")
                carNode.ImageOptions.SvgImage = Properties.Resources.car
                carNode.TypeName = "Car"
                carNode.Tag = model
                trademarkNode.Nodes.Add(carNode)
                styleNode.Nodes.Add(carNode)
            Next

            nodes.Add(fromDataBaseNode)
            nodes.Add(fromWebAPINode)
        End Sub

        Private Shared Sub CreateDataFolderHierarchy(ByVal models As List(Of VehiclesData.Model), ByVal dbFileName As String, ByVal nodes As NodesCollection)
            Dim carsFolder = New PathNode(GetCarsFolderPath(dbFileName))
            carsFolder.Tag = models.Find(Function(x) x.ID = 11)
            nodes.Add(carsFolder)
        End Sub

        Private Shared Function GetCarsFolderPath(ByVal dbFileName As String) As String
            Return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(dbFileName), "Cars")
        End Function

        Private ReadOnly Shared genericWhitespaces As Char() = New Char() {" "c, Microsoft.VisualBasic.Strings.ChrW(9), Microsoft.VisualBasic.Strings.ChrW(13), Microsoft.VisualBasic.Strings.ChrW(10)}

        Private Shared Function ReadCarIdFormFile(ByVal path As String) As String
            Dim carContent As String = System.IO.File.ReadAllText(path)
            Dim idEnd As Integer = carContent.IndexOfAny(genericWhitespaces)
            Return If(idEnd > 0, carContent.Substring(0, idEnd), carContent)
        End Function

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 1000
            End Get
        End Property
    End Class
End Namespace
