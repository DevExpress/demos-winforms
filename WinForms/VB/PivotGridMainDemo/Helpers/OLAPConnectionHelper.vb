Imports DevExpress.XtraPivotGrid.Data
Imports System.Collections.Generic

Namespace DevExpress.XtraPivotGrid.Demos.Helpers

    Public Enum ConnectionErrorType
        ServerName
        CatalogName
        CubeName
    End Enum

    Public Interface IOLAPConnectionInfo

        ReadOnly Property IsError As Boolean

    End Interface

    Public Class OLAPConnectionInfoError
        Implements IOLAPConnectionInfo

        Private _Type As ConnectionErrorType, _Message As String

        Public Property Type As ConnectionErrorType
            Get
                Return _Type
            End Get

            Private Set(ByVal value As ConnectionErrorType)
                _Type = value
            End Set
        End Property

        Public Property Message As String
            Get
                Return _Message
            End Get

            Private Set(ByVal value As String)
                _Message = value
            End Set
        End Property

        Public ReadOnly Property IsError As Boolean Implements IOLAPConnectionInfo.IsError
            Get
                Return True
            End Get
        End Property

        Public Sub New(ByVal message As String, ByVal type As ConnectionErrorType)
            Me.Message = message
            Me.Type = type
        End Sub
    End Class

    Public Class OLAPConnectionStringInfo
        Implements IOLAPConnectionInfo

        Private _ConnectionString As String

        Public Property ConnectionString As String
            Get
                Return _ConnectionString
            End Get

            Private Set(ByVal value As String)
                _ConnectionString = value
            End Set
        End Property

        Public ReadOnly Property IsError As Boolean Implements IOLAPConnectionInfo.IsError
            Get
                Return False
            End Get
        End Property

        Public Sub New(ByVal connectionString As String)
            Me.ConnectionString = connectionString
        End Sub
    End Class

    Public Class OLAPStringListConnectionInfo
        Implements IOLAPConnectionInfo

        Private _StringList As String()

        Public Property StringList As String()
            Get
                Return _StringList
            End Get

            Private Set(ByVal value As String())
                _StringList = value
            End Set
        End Property

        Public ReadOnly Property IsError As Boolean Implements IOLAPConnectionInfo.IsError
            Get
                Return False
            End Get
        End Property

        Public Sub New(ByVal stringList As String())
            Me.StringList = stringList
        End Sub
    End Class

    Public Class OLAPConnectionHelper

        Private metaGetter As OLAPMetaGetter = New OLAPMetaGetter()

        Public Function GetOlapConnectionInfo(ByVal serverName As String, ByVal catalogName As String, ByVal cubeName As String) As IOLAPConnectionInfo
            If String.IsNullOrEmpty(serverName) Then Return ServerError("Please specify the server.")
            metaGetter.ConnectionString = "Provider=msolap;Data Source=" & serverName
            If Not metaGetter.Connected Then Return ServerError("Couldn't connect to the server. Please check that it is correct.")
            If Not String.IsNullOrEmpty(catalogName) Then
                metaGetter.ConnectionString += ";Initial Catalog=" & catalogName
            Else
                Return CatalogError("Please specify the database name.")
            End If

            If Not metaGetter.Connected Then Return CatalogError("Couldn't connect to the """ & catalogName & """ database. Please check that it is correct.")
            Dim cubes As List(Of String) = metaGetter.GetCubes(catalogName)
            If cubes IsNot Nothing Then
                If String.IsNullOrEmpty(cubeName) Then Return CubeError("Please specify the cube name.")
                If Not cubes.Contains(cubeName) Then Return CubeError("Couldn't connect to the """ & cubeName & """ cube. Please check that it is correct.")
            End If

            Dim connectionString As String = "Provider=msolap;Data Source=" & serverName & ";Initial Catalog=" & catalogName & ";Cube Name=" & cubeName
            Return New OLAPConnectionStringInfo(connectionString)
        End Function

        Public Function GetCubeList(ByVal serverName As String, ByVal catalogName As String) As IOLAPConnectionInfo
            If Not String.IsNullOrEmpty(serverName) Then
                metaGetter.ConnectionString = "Provider=msolap;Data Source=" & serverName
                If Not metaGetter.Connected Then Return ServerError("Couldn't connect to the server.")
                If Not String.IsNullOrEmpty(catalogName) Then metaGetter.ConnectionString += ";Initial Catalog=" & catalogName
                If Not metaGetter.Connected Then Return CatalogError("Couldn't connect to the """ & catalogName & """ database.")
                Dim cubes As List(Of String) = metaGetter.GetCubes(catalogName)
                If cubes IsNot Nothing Then
                    If cubes.Count = 0 Then Return CubeError("There are no cubes in the """ & catalogName & """ database.")
                    Return New OLAPStringListConnectionInfo(cubes.ToArray())
                End If
            End If

            Return Nothing
        End Function

        Public Function GetCatalogList(ByVal serverName As String) As IOLAPConnectionInfo
            If Not String.IsNullOrEmpty(serverName) Then
                metaGetter.ConnectionString = "Provider=msolap;Data Source=" & serverName
                If Not metaGetter.Connected Then Return ServerError("Couldn't connect to the server.")
                Dim catalogs As List(Of String) = metaGetter.GetCatalogs()
                If catalogs IsNot Nothing Then
                    Return New OLAPStringListConnectionInfo(catalogs.ToArray())
                End If
            End If

            Return Nothing
        End Function

        Private Shared Function ServerError(ByVal message As String) As IOLAPConnectionInfo
            Return New OLAPConnectionInfoError(message, ConnectionErrorType.ServerName)
        End Function

        Private Shared Function CatalogError(ByVal message As String) As IOLAPConnectionInfo
            Return New OLAPConnectionInfoError(message, ConnectionErrorType.CatalogName)
        End Function

        Private Shared Function CubeError(ByVal message As String) As IOLAPConnectionInfo
            Return New OLAPConnectionInfoError(message, ConnectionErrorType.CubeName)
        End Function
    End Class
End Namespace
