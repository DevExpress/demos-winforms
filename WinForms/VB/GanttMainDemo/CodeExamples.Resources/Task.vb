' Assembly {TutorialsAssembly}
Imports System
Imports System.Collections.Generic

Namespace DevExpress.DXperience.Demos.CodeDemo.Data
    Public Class Task
        '
        Private _PredecessorIDs As IReadOnlyList(Of Integer)
        Public Property Id As Integer
        Public Property ParentId As Integer
        '
        Public Property Name As String
        Public Property StartTime As DateTime
        Public Property EndTime As DateTime
        Public Property Duration As TimeSpan
        Public Property Progress As Double

        Public Property PredecessorIDs As IReadOnlyList(Of Integer)
            Get
                Return _PredecessorIDs
            End Get
            Private Set(ByVal value As IReadOnlyList(Of Integer))
                _PredecessorIDs = value
            End Set
        End Property
    End Class
End Namespace
