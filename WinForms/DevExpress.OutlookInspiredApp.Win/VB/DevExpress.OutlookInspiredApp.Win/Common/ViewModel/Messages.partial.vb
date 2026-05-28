Namespace DevExpress.DevAV.Common.ViewModel

    Public Class SelectedItemSynchronizationMessage(Of TEntity As Class)

        Private _Entity As TEntity

        Public Sub New(ByVal entity As TEntity)
            Me.Entity = entity
        End Sub

        Public Property Entity As TEntity
            Get
                Return _Entity
            End Get

            Private Set(ByVal value As TEntity)
                _Entity = value
            End Set
        End Property
    End Class
End Namespace
