Imports DevExpress.Utils.Serializing
Imports System.Collections
Imports System.Drawing
Imports System.IO

Namespace PhotoViewer

    Public Class PhotoViewerData
        Implements IXtraSerializable

        Private foldersCore As PathCollection

        Private albumsCore As AlbumCollection

        Private othersCore As AlbumData

        Private firstRunCore As Boolean

        <XtraSerializableProperty(XtraSerializationVisibility.Collection, True, False, True, 1, XtraSerializationFlags.DeserializeCollectionItemBeforeCallSetIndex)>
        Public ReadOnly Property Albums As AlbumCollection
            Get
                If albumsCore Is Nothing Then albumsCore = New AlbumCollection()
                Return albumsCore
            End Get
        End Property

        <XtraSerializableProperty(XtraSerializationVisibility.Collection, True, False, True, 2, XtraSerializationFlags.DeserializeCollectionItemBeforeCallSetIndex)>
        Public ReadOnly Property Folders As PathCollection
            Get
                If foldersCore Is Nothing Then foldersCore = New PathCollection()
                Return foldersCore
            End Get
        End Property

        <XtraSerializableProperty(XtraSerializationVisibility.Content)>
        Public ReadOnly Property Others As AlbumData
            Get
                If othersCore Is Nothing Then othersCore = New AlbumData()
                Return othersCore
            End Get
        End Property

        <XtraSerializableProperty>
        Public Property FirstRun As Boolean
            Get
                Return firstRunCore
            End Get

            Set(ByVal value As Boolean)
                firstRunCore = value
            End Set
        End Property

#Region "IXtraSerializable Members"
        Private Sub OnEndDeserializing(ByVal restoredVersion As String) Implements IXtraSerializable.OnEndDeserializing
        End Sub

        Private Sub OnEndSerializing() Implements IXtraSerializable.OnEndSerializing
        End Sub

        Private Sub OnStartDeserializing(ByVal e As DevExpress.Utils.LayoutAllowEventArgs) Implements IXtraSerializable.OnStartDeserializing
        End Sub

        Private Sub OnStartSerializing() Implements IXtraSerializable.OnStartSerializing
        End Sub

#End Region
        Public Sub SaveLayoutToXml(ByVal fileName As String)
            If File.Exists(fileName) Then File.SetAttributes(fileName, FileAttributes.Normal)
            SaveLayoutCore(New XmlXtraSerializer(), fileName)
        End Sub

        Public Sub RestoreLayoutFromXml(ByVal fileName As String)
            File.SetAttributes(fileName, FileAttributes.Normal)
            RestoreLayoutCore(New XmlXtraSerializer(), fileName)
        End Sub

        Protected Overridable Function SaveLayoutCore(ByVal serializer As XtraSerializer, ByVal path As Object) As Boolean
            Dim stream As Stream = TryCast(path, Stream)
            If stream IsNot Nothing Then
                Return serializer.SerializeObjects(New XtraObjectInfo() {New XtraObjectInfo("PhotoViewerData", Me)}, stream, [GetType]().Name)
            Else
                Return serializer.SerializeObjects(New XtraObjectInfo() {New XtraObjectInfo("PhotoViewerData", Me)}, path.ToString(), [GetType]().Name)
            End If
        End Function

        Protected Overridable Sub RestoreLayoutCore(ByVal serializer As XtraSerializer, ByVal path As Object)
            Dim stream As Stream = TryCast(path, Stream)
            If stream IsNot Nothing Then
                serializer.DeserializeObjects(New XtraObjectInfo() {New XtraObjectInfo("PhotoViewerData", Me)}, stream, [GetType]().Name)
            Else
                serializer.DeserializeObjects(New XtraObjectInfo() {New XtraObjectInfo("PhotoViewerData", Me)}, path.ToString(), [GetType]().Name)
            End If
        End Sub

        Private Function XtraCreateAlbumsItem(ByVal e As XtraItemEventArgs) As Object
            Return New AlbumData()
        End Function

        Private Sub XtraSetIndexAlbumsItem(ByVal e As XtraSetItemIndexEventArgs)
            Albums.Insert(e.NewIndex, CType(e.Item.Value, AlbumData))
        End Sub

        Private Function XtraCreateFoldersItem(ByVal e As XtraItemEventArgs) As Object
            Return New PathData()
        End Function

        Private Sub XtraSetIndexFoldersItem(ByVal e As XtraSetItemIndexEventArgs)
            Folders.Insert(e.NewIndex, CType(e.Item.Value, PathData))
        End Sub

        Public Sub Clear()
            Albums.Clear()
            Folders.Clear()
        End Sub
    End Class

    Public Class AlbumCollection
        Inherits CollectionBase

        Public Function Add(ByVal album As AlbumData) As Integer
            Return List.Add(album)
        End Function

        Public Sub Insert(ByVal index As Integer, ByVal album As AlbumData)
            List.Insert(index, album)
        End Sub

        Public Sub Remove(ByVal album As AlbumData)
            List.Remove(album)
        End Sub

        Default Public Property Item(ByVal index As Integer) As AlbumData
            Get
                Return TryCast(List(index), AlbumData)
            End Get

            Set(ByVal value As AlbumData)
                List(index) = value
            End Set
        End Property
    End Class

    Public Class PathCollection
        Inherits CollectionBase

        Public Function Add(ByVal path As PathData) As Integer
            Return List.Add(path)
        End Function

        Public Sub Insert(ByVal index As Integer, ByVal path As PathData)
            List.Insert(index, path)
        End Sub

        Public Sub Remove(ByVal path As PathData)
            List.Remove(path)
        End Sub

        Public Sub Remove(ByVal path As String)
            For Each pData As PathData In Me
                If Equals(pData.Path, path) Then
                    Remove(pData)
                    Return
                End If
            Next
        End Sub

        Default Public Property Item(ByVal index As Integer) As PathData
            Get
                Return TryCast(List(index), PathData)
            End Get

            Set(ByVal value As PathData)
                List(index) = value
            End Set
        End Property

        Public Function Contains(ByVal file As String) As Boolean
            For Each pData As PathData In Me
                If Equals(pData.Path, file) Then Return True
            Next

            Return False
        End Function
    End Class

    Public Class AlbumData
        Implements IXtraSerializable

        Private filesCore As PathCollection

        Private dateCore As Date

        Private nameCore As String

        Private descriptionCore As String

        <XtraSerializableProperty(XtraSerializationVisibility.Collection, True, False, True, 1, XtraSerializationFlags.DeserializeCollectionItemBeforeCallSetIndex)>
        Public ReadOnly Property Files As PathCollection
            Get
                If filesCore Is Nothing Then filesCore = New PathCollection()
                Return filesCore
            End Get
        End Property

        <XtraSerializableProperty>
        Public Property Name As String
            Get
                Return nameCore
            End Get

            Set(ByVal value As String)
                nameCore = value
            End Set
        End Property

        <XtraSerializableProperty>
        Public Property [Date] As Date
            Get
                Return dateCore
            End Get

            Set(ByVal value As Date)
                dateCore = value
            End Set
        End Property

        <XtraSerializableProperty>
        Public Property Description As String
            Get
                Return descriptionCore
            End Get

            Set(ByVal value As String)
                descriptionCore = value
            End Set
        End Property

#Region "IXtraSerializable Members"
        Private Sub OnEndDeserializing(ByVal restoredVersion As String) Implements IXtraSerializable.OnEndDeserializing
        End Sub

        Private Sub OnEndSerializing() Implements IXtraSerializable.OnEndSerializing
        End Sub

        Private Sub OnStartDeserializing(ByVal e As DevExpress.Utils.LayoutAllowEventArgs) Implements IXtraSerializable.OnStartDeserializing
        End Sub

        Private Sub OnStartSerializing() Implements IXtraSerializable.OnStartSerializing
        End Sub

#End Region
        Private Function XtraCreateFilesItem(ByVal e As XtraItemEventArgs) As Object
            Return New PathData()
        End Function

        Private Sub XtraSetIndexFilesItem(ByVal e As XtraSetItemIndexEventArgs)
            Files.Insert(e.NewIndex, CType(e.Item.Value, PathData))
        End Sub
    End Class

    Public Class PathData
        Implements IXtraSerializable

        Private nameCore As String

        Private pathCore As String

        Private imageCore As Image

        <XtraSerializableProperty>
        Public Property Name As String
            Get
                Return nameCore
            End Get

            Set(ByVal value As String)
                nameCore = value
            End Set
        End Property

        <XtraSerializableProperty>
        Public Property Path As String
            Get
                Return pathCore
            End Get

            Set(ByVal value As String)
                pathCore = value
            End Set
        End Property

        Public Property Image As Image
            Get
                Return imageCore
            End Get

            Set(ByVal value As Image)
                imageCore = value
            End Set
        End Property

#Region "IXtraSerializable Members"
        Private Sub OnEndDeserializing(ByVal restoredVersion As String) Implements IXtraSerializable.OnEndDeserializing
        End Sub

        Private Sub OnEndSerializing() Implements IXtraSerializable.OnEndSerializing
        End Sub

        Private Sub OnStartDeserializing(ByVal e As DevExpress.Utils.LayoutAllowEventArgs) Implements IXtraSerializable.OnStartDeserializing
        End Sub

        Private Sub OnStartSerializing() Implements IXtraSerializable.OnStartSerializing
        End Sub
#End Region
    End Class
End Namespace
