Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Collections.Specialized

Namespace DevExpress.XtraCharts.Demos

    Friend Class FinancialDataCollection
        Inherits ObservableCollection(Of FinancialDataPoint)

        Public Sub AddRange(ByVal list As List(Of FinancialDataPoint))
            For i As Integer = 0 To list.Count - 1
                Items.Add(list(i))
            Next

            OnCollectionChanged(New NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, list, Items.Count - list.Count))
        End Sub

        Public Sub RemoveRangeAt(ByVal startingIndex As Integer, ByVal count As Integer)
            Dim removedItems As List(Of FinancialDataPoint) = New List(Of FinancialDataPoint)(count)
            For i As Integer = 0 To count - 1
                removedItems.Add(Items(startingIndex))
                Items.RemoveAt(startingIndex)
            Next

            If count > 0 Then OnCollectionChanged(New NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removedItems, startingIndex))
        End Sub
    End Class

    Friend Class DataCollection
        Inherits ObservableCollection(Of SensorIndicationItem)

        Friend Sub AddRange(ByVal items As List(Of SensorIndicationItem))
            For Each item As SensorIndicationItem In items
                Me.Items.Add(item)
            Next

            OnCollectionChanged(New NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, items, Me.Items.Count - items.Count))
        End Sub

        Friend Sub RemoveRangeAt(ByVal startingIndex As Integer, ByVal count As Integer)
            Dim removedItems As List(Of SensorIndicationItem) = New List(Of SensorIndicationItem)(count)
            For i As Integer = 0 To count - 1
                removedItems.Add(Items(startingIndex))
                Items.RemoveAt(startingIndex)
            Next

            If count > 0 Then OnCollectionChanged(New NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removedItems, startingIndex))
        End Sub
    End Class
End Namespace
