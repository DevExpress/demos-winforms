Imports DevExpress.XtraCharts.Sankey
Imports DevExpress.XtraMap
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Windows.Forms

Namespace DevExpress.XtraSankey.Demos

    Public Module Utils

        Public Function GetRelativePath(ByVal name As String) As String
            name = "Data\" & name
            Dim dir As DirectoryInfo = New DirectoryInfo(Application.StartupPath)
            For i As Integer = 0 To 10
                Dim filePath As String = Path.Combine(dir.FullName, name)
                If File.Exists(filePath) Then Return filePath
                dir = Directory.GetParent(dir.FullName)
            Next

            Return String.Empty
        End Function

        Public Function GetRelativeDirectoryPath(ByVal name As String) As String
            name = "Data\" & name
            Dim dir As DirectoryInfo = New DirectoryInfo(Application.StartupPath)
            While dir IsNot Nothing
                Dim directoryPath As String = Path.Combine(dir.FullName, name)
                If Directory.Exists(directoryPath) Then Return directoryPath
                dir = Directory.GetParent(dir.FullName)
            End While

            Return String.Empty
        End Function

        Public Function CreateDataSet(ByVal xmlFileName As String) As DataTable
            Dim filePath As String = GetRelativePath(xmlFileName)
            If Not String.IsNullOrWhiteSpace(filePath) Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(filePath)
                If dataSet.Tables.Count > 0 Then Return dataSet.Tables(0)
            End If

            Return Nothing
        End Function

        Public Function GetFileUri(ByVal fileName As String) As Uri
            Return New Uri("file:\\" & GetRelativePath(fileName), UriKind.RelativeOrAbsolute)
        End Function

        Public Sub SetDatabasePath()
            Const dbName As String = "nwind.mdb"
            Const pathToDbTag As String = "|pathToDb|"
            Dim path As String = GetRelativePath(dbName)
            If String.IsNullOrEmpty(path) Then Return
            Dim connectionString As String = TryCast(Properties.Settings.Default("nwindConnectionString"), String)
            If String.IsNullOrEmpty(connectionString) Then Return
            connectionString = connectionString.Replace(pathToDbTag, path)
            Properties.Settings.Default("nwindConnectionString") = connectionString
        End Sub
    End Module

    Public Class Export

        Public Property Exporter As String

        Public Property Importer As String

        Public Property Sum As Double

        Public Sub New(ByVal from As String, ByVal [to] As String, ByVal weight As Double)
            Exporter = from
            Importer = [to]
            Sum = weight
        End Sub
    End Class

    Public Class PolarPoint

        Public Property Radius As Double

        Public Property Angle As Double

        Public Property AngleDegree As Double
            Get
                Return Angle * 360 / (Math.PI * 2)
            End Get

            Set(ByVal value As Double)
                Angle = value * 2 * Math.PI / 360
            End Set
        End Property

        Public Sub New(ByVal x As Double, ByVal y As Double)
            Radius = Math.Sqrt(x * x + y * y)
            Angle = Math.Atan2(y, x)
        End Sub

        Public Function ToCartesianPoint() As CartesianPoint
            Dim c As CartesianPoint = New CartesianPoint()
            c.X = Radius * Math.Cos(Angle)
            c.Y = Radius * Math.Sin(Angle)
            Return c
        End Function
    End Class

    Public Class SankeyNodeComparerItem

        Private ascendingComparer As IComparer(Of SankeyNode)

        Private descendingComparer As IComparer(Of SankeyNode)

        Public Sub New(ByVal ascendingComparer As IComparer(Of SankeyNode), ByVal descendingComparer As IComparer(Of SankeyNode))
            Me.ascendingComparer = ascendingComparer
            Me.descendingComparer = descendingComparer
        End Sub

        Public Function GetComparer(ByVal ascending As Boolean) As IComparer(Of SankeyNode)
            If ascending Then Return ascendingComparer
            Return descendingComparer
        End Function
    End Class

    Public Class BoolItem

        Private _Value As Boolean

        Private text As String

        Public Property Value As Boolean
            Get
                Return _Value
            End Get

            Private Set(ByVal value As Boolean)
                _Value = value
            End Set
        End Property

        Public Sub New(ByVal text As String, ByVal value As Boolean)
            Me.text = text
            Me.Value = value
        End Sub

        Public Overrides Function ToString() As String
            Return text
        End Function
    End Class
End Namespace
