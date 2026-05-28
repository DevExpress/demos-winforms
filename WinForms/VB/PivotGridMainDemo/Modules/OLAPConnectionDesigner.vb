Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.Utils
Imports System.IO
Imports DevExpress.Internal

Namespace DevExpress.XtraPivotGrid.Demos

    Public Partial Class OLAPConnectionDesigner
        Inherits XtraEditors.XtraForm

        Private metaGetter As OLAPMetaGetter = New OLAPMetaGetter()

        Private Shared fSampleFileName As String

        Private Shared Function GetConnectionString(ByVal serverName As String) As String
            Return "Provider=msolap;Data Source=" & serverName & ";Initial Catalog=Adventure Works;Cube Name=Adventure Works"
        End Function

        Public ReadOnly Property ConnectionString As String
            Get
                Return "Provider=msolap;Data Source=" & editServer.Text & ";Initial Catalog=" & CStr(listCatalog.EditValue) & ";Cube Name=" & CStr(listCube.EditValue)
            End Get
        End Property

        Public Shared ReadOnly Property SampleConnectionString As String
            Get
                If String.IsNullOrEmpty(SampleFileName) Then Return Nothing
                Return "Provider=msolap;Data Source=" & SampleFileName & ";Initial Catalog=Adventure Works;Cube Name=Adventure Works"
            End Get
        End Property

        Const MSMDPUMPAddress As String = "https://demos.devexpress.com/Services/OLAP/msmdpump.dll"

        Const AdventureWorksCatalogName As String = "Adventure Works DW Standard Edition"

        Const AdventureWorksCubeName As String = "Adventure Works"

        Public Shared ReadOnly Property SampleXMLAConnectionString As String
            Get
                Return String.Format("Provider=msolap;Data Source={0};Initial Catalog={1};Cube Name={2};", MSMDPUMPAddress, AdventureWorksCatalogName, AdventureWorksCubeName)
            End Get
        End Property

        Protected Shared ReadOnly Property SampleFileName As String
            Get
                If String.IsNullOrEmpty(fSampleFileName) Then
                    Dim fileName As String = DevAVDataDirectoryHelper.GetFile(GetAdventureWorksFileName())
                    If File.Exists(fileName) Then
                        fSampleFileName = Path.GetFullPath(fileName)
                        If File.Exists(fSampleFileName) Then
                            Try
                                File.SetAttributes(fSampleFileName, FileAttributes.Normal)
                            Catch
                            End Try
                        End If
                    End If
                End If

                Return fSampleFileName
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property AllowCubeFile As Boolean
            Get
                Return radioFile.Enabled
            End Get

            Set(ByVal value As Boolean)
                radioFile.Enabled = value
            End Set
        End Property

        Private Shared Function GetAdventureWorksFileName() As String
            Return "AdventureWorks.cub"
        End Function

        Public Sub New()
            InitializeComponent()
            UpdateControls()
            buttonSample.Visible = Not String.IsNullOrEmpty(SampleFileName)
            AllowCubeFile = True
        End Sub

        Private Sub radioServer_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateControls()
        End Sub

        Private Sub radioFile_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateControls()
        End Sub

        Private wasServer As Boolean = True

        Private serverName, fileName As String

        Private Sub UpdateControls()
            If wasServer Then
                serverName = editServer.Text
            Else
                fileName = editServer.Text
            End If

            Dim useServer As Boolean = radioServer.Checked
            editServer.Properties.Buttons(0).Visible = Not useServer
            editServer.Text = If(useServer, serverName, fileName)
            labelServer.Text = If(useServer, "Server", "File")
            listCatalog.Enabled = useServer
            labelCatalog.Enabled = useServer
            listCube.Enabled = useServer
            labelCube.Enabled = useServer
            wasServer = useServer
        End Sub

        Private Sub editServer_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs)
            Using dialog As OpenFileDialog = New OpenFileDialog()
                dialog.Filter = "Cube files (*.cub)|*.cub"
                If dialog.ShowDialog() = DialogResult.OK Then
                    OpenCubeFile(dialog.FileName)
                End If
            End Using
        End Sub

        Private Function OpenCubeFile(ByVal fileName As String) As Boolean
            Return OpenCubeFile(fileName, True)
        End Function

        Private Function OpenCubeFile(ByVal fileName As String, ByVal showBalloons As Boolean) As Boolean
            Try
                editServer.Text = fileName
                metaGetter.ConnectionString = "Provider=msolap;Data Source=" & editServer.Text
                If Not metaGetter.Connected Then
                    If showBalloons Then ShowBalloon("Invalid cube file.", "Error", editServer)
                    Return False
                End If

                Dim catalogs As List(Of String) = metaGetter.GetCatalogs()
                If catalogs Is Nothing OrElse catalogs.Count = 0 Then
                    If showBalloons Then ShowBalloon("There is no catalogs in the cube file.", "Error", editServer)
                    Return False
                End If

                listCatalog.EditValue = catalogs(0)
                Dim cubes As List(Of String) = metaGetter.GetCubes(catalogs(0))
                If cubes Is Nothing OrElse cubes.Count = 0 Then
                    If showBalloons Then ShowBalloon("There is no cubes in the cube file.", "Error", editServer)
                    Return False
                End If

                listCube.EditValue = cubes(0)
                Return True
            Finally
                metaGetter.Connected = False
            End Try
        End Function

        Private Sub ShowBalloon(ByVal text As String, ByVal caption As String, ByVal control As Control)
            Dim eShow As ToolTipControllerShowEventArgs = toolTipController1.CreateShowArgs()
            eShow.ToolTip = text
            eShow.Title = caption
            eShow.IconType = ToolTipIconType.Error
            eShow.IconSize = ToolTipIconSize.Small
            toolTipController1.ShowHint(eShow, control)
        End Sub

        Private Sub listCatalog_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs)
            If Not String.IsNullOrEmpty(editServer.Text) Then
                metaGetter.ConnectionString = "Provider=msolap;Data Source=" & editServer.Text
                If Not metaGetter.Connected Then ShowBalloon("Couldn't connect to the server.", "Error", editServer)
                Dim catalogs As List(Of String) = metaGetter.GetCatalogs()
                If catalogs IsNot Nothing Then
                    listCatalog.Properties.Items.Clear()
                    listCatalog.Properties.Items.AddRange(catalogs)
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        End Sub

        Private Sub listCube_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs)
            If Not String.IsNullOrEmpty(editServer.Text) Then
                metaGetter.ConnectionString = "Provider=msolap;Data Source=" & editServer.Text
                If Not metaGetter.Connected Then
                    ShowBalloon("Couldn't connect to the server.", "Error", editServer)
                    e.Cancel = True
                    Return
                End If

                Dim catalogName As String = Nothing
                If Not String.IsNullOrEmpty(CStr(listCatalog.EditValue)) Then
                    catalogName = CStr(listCatalog.EditValue)
                    metaGetter.ConnectionString += ";Initial Catalog=" & catalogName
                End If

                If Not metaGetter.Connected Then
                    ShowBalloon("Couldn't connect to the """ & catalogName & """ database.", "Error", listCatalog)
                    e.Cancel = True
                    Return
                End If

                Dim cubes As List(Of String) = metaGetter.GetCubes(catalogName)
                If cubes IsNot Nothing Then
                    listCube.Properties.Items.Clear()
                    If cubes.Count = 0 Then
                        ShowBalloon("There are no cubes in the """ & catalogName & """ database.", "Error", listCube)
                        e.Cancel = True
                        Return
                    End If

                    listCube.Properties.Items.AddRange(cubes)
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If AllowCubeFile Then
                radioFile.Checked = True
                If OpenCubeFile(fSampleFileName) Then DialogResult = DialogResult.OK
            Else
                editServer.Text = MSMDPUMPAddress
                listCatalog.Text = AdventureWorksCatalogName
                listCube.Text = AdventureWorksCubeName
            End If
        End Sub

        Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            If radioServer.Checked Then
                ConnectToServer()
            Else
                ConnectToCubeFile()
            End If
        End Sub

        Private Sub ConnectToCubeFile()
            If String.IsNullOrEmpty(editServer.Text) OrElse String.IsNullOrEmpty(TryCast(listCatalog.EditValue, String)) OrElse String.IsNullOrEmpty(TryCast(listCube.EditValue, String)) Then Return
            DialogResult = DialogResult.OK
        End Sub

        Private Sub ConnectToServer()
            Dim server As String = If(radioServer.Checked, "server", "cube file")
            If String.IsNullOrEmpty(editServer.Text) Then
                ShowBalloon("Please specify the " & server & ".", "Error", editServer)
                Return
            End If

            metaGetter.ConnectionString = "Provider=msolap;Data Source=" & editServer.Text
            If Not metaGetter.Connected Then
                ShowBalloon("Couldn't connect to the " & server & ". Please check that it is correct.", "Error", editServer)
                Return
            End If

            Dim catalogName As String = CStr(listCatalog.EditValue)
            If Not String.IsNullOrEmpty(catalogName) Then
                metaGetter.ConnectionString += ";Initial Catalog=" & catalogName
            Else
                ShowBalloon("Please specify the database name.", "Error", listCatalog)
                Return
            End If

            If Not metaGetter.Connected Then
                ShowBalloon("Couldn't connect to the """ & catalogName & """ database. Please check that it is correct.", "Error", listCatalog)
                Return
            End If

            Dim cubes As List(Of String) = metaGetter.GetCubes(catalogName)
            If cubes IsNot Nothing Then
                Dim cubeName As String = CStr(listCube.EditValue)
                If String.IsNullOrEmpty(cubeName) Then
                    ShowBalloon("Please specify the cube name.", "Error", listCube)
                    Return
                End If

                If Not cubes.Contains(cubeName) Then
                    ShowBalloon("Couldn't connect to the """ & cubeName & """ cube. Please check that it is correct.", "Error", listCube)
                    Return
                End If
            End If

            DialogResult = DialogResult.OK
        End Sub

        Private Sub listCatalog_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            listCube.EditValue = ""
        End Sub
    End Class
End Namespace
