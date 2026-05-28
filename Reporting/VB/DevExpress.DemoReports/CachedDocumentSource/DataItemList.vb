Imports System
Imports System.Collections
Imports System.Collections.Generic

Namespace XtraReportsDemos.CachedDocumentSourceReport

    Public Class DataItemList
        Implements IList(Of DataItem), IList

        Private ReadOnly rowCount As Integer

        Default Public Property Item(ByVal index As Integer) As DataItem Implements IList(Of DataItem).Item
            Get
                Return New DataItem(index)
            End Get

            Set(ByVal value As DataItem)
            End Set
        End Property

        Public ReadOnly Property Count As Integer Implements ICollection(Of DataItem).Count, ICollection.Count
            Get
                Return rowCount
            End Get
        End Property

        Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of DataItem).IsReadOnly, IList.IsReadOnly
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property IsFixedSize As Boolean Implements IList.IsFixedSize
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property SyncRoot As Object Implements ICollection.SyncRoot
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property IsSynchronized As Boolean Implements ICollection.IsSynchronized
            Get
                Return True
            End Get
        End Property

        Private Property IList_Item(ByVal index As Integer) As Object Implements IList.Item
            Get
                Return New DataItem(index)
            End Get

            Set(ByVal value As Object)
            End Set
        End Property

        Public Sub New(ByVal rowCount As Integer)
            Me.rowCount = rowCount
        End Sub

        Public Function GetEnumerator() As IEnumerator(Of DataItem) Implements IEnumerable(Of DataItem).GetEnumerator
            Throw New NotImplementedException()
        End Function

        Public Function Add(ByVal value As Object) As Integer Implements IList.Add
            Throw New NotImplementedException()
        End Function

        Public Function Contains(ByVal value As Object) As Boolean Implements IList.Contains
            Throw New NotImplementedException()
        End Function

        Public Sub Clear() Implements ICollection(Of DataItem).Clear, IList.Clear
            Throw New NotImplementedException()
        End Sub

        Public Function IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
            Throw New NotImplementedException()
        End Function

        Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
            Throw New NotImplementedException()
        End Sub

        Public Sub Remove(ByVal value As Object) Implements IList.Remove
            Throw New NotImplementedException()
        End Sub

        Public Sub RemoveAt(ByVal index As Integer) Implements IList(Of DataItem).RemoveAt, IList.RemoveAt
            Throw New NotImplementedException()
        End Sub

        Public Sub CopyTo(ByVal array As Array, ByVal index As Integer) Implements ICollection.CopyTo
            Throw New NotImplementedException()
        End Sub

        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Throw New NotImplementedException()
        End Function

        Public Function IndexOf(ByVal item As DataItem) As Integer Implements IList(Of DataItem).IndexOf
            Throw New NotImplementedException()
        End Function

        Public Sub Insert(ByVal index As Integer, ByVal item As DataItem) Implements IList(Of DataItem).Insert
            Throw New NotImplementedException()
        End Sub

        Public Sub Add(ByVal item As DataItem) Implements ICollection(Of DataItem).Add
            Throw New NotImplementedException()
        End Sub

        Public Function Contains(ByVal item As DataItem) As Boolean Implements ICollection(Of DataItem).Contains
            Throw New NotImplementedException()
        End Function

        Public Sub CopyTo(ByVal array As DataItem(), ByVal arrayIndex As Integer)
            Throw New NotImplementedException()
        End Sub

        Public Function Remove(ByVal item As DataItem) As Boolean Implements ICollection(Of DataItem).Remove
            Throw New NotImplementedException()
        End Function

        Private Sub ICollection_CopyTo(ByVal array As DataItem(), ByVal arrayIndex As Integer) Implements ICollection(Of DataItem).CopyTo
            CopyTo(array, arrayIndex)
        End Sub
    End Class
End Namespace
