Imports DevExpress.XtraCharts.Sankey
Imports System
Imports System.Collections.Generic

Namespace DevExpress.XtraSankey.Demos

    Public Class TotalWeightComparer
        Implements IComparer(Of SankeyNode)

        Private ascending As Boolean

        Public Sub New(ByVal ascending As Boolean)
            Me.ascending = ascending
        End Sub

        Public Function Compare(ByVal x As SankeyNode, ByVal y As SankeyNode) As Integer Implements IComparer(Of SankeyNode).Compare
            Return If(ascending, 1, -1) * Math.Sign(x.TotalWeight - y.TotalWeight)
        End Function
    End Class

    Public Class OutputLinkCountComparer
        Implements IComparer(Of SankeyNode)

        Private ascending As Boolean

        Public Sub New(ByVal ascending As Boolean)
            Me.ascending = ascending
        End Sub

        Public Function Compare(ByVal x As SankeyNode, ByVal y As SankeyNode) As Integer Implements IComparer(Of SankeyNode).Compare
            If x.OutputLinks.Count <> 0 Then
                Return If(ascending, 1, -1) * Math.Sign(x.OutputLinks.Count - y.OutputLinks.Count)
            Else
                Return If(ascending, 1, -1) * Math.Sign(x.InputLinks.Count - y.InputLinks.Count)
            End If
        End Function
    End Class

    Public Class NodeNameComparer
        Implements IComparer(Of SankeyNode)

        Private ascending As Boolean

        Public Sub New(ByVal ascending As Boolean)
            Me.ascending = ascending
        End Sub

        Public Function Compare(ByVal x As SankeyNode, ByVal y As SankeyNode) As Integer Implements IComparer(Of SankeyNode).Compare
            Return If(ascending, 1, -1) * x.Tag.ToString().CompareTo(y.Tag.ToString())
        End Function
    End Class
End Namespace
