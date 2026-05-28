Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.Common.ViewModel

    Public Class SingleObjectChildViewModel(Of TEntity As Class)
        Implements ISupportParameter

        Public Shared Function Create() As SingleObjectChildViewModel(Of TEntity)
            Return ViewModelSource.Create(Function() New SingleObjectChildViewModel(Of TEntity)())
        End Function

        Protected Sub New()
        End Sub

        Public Overridable Property Entity As TEntity

        Public Overridable Property IsEnabled As Boolean

        Protected Overridable Sub OnEntityChanged()
            IsEnabled = Entity IsNot Nothing
        End Sub

#Region "ISupportParameter"
        Private Property Parameter As Object Implements ISupportParameter.Parameter
            Get
                Return Entity
            End Get

            Set(ByVal value As Object)
                Entity = CType(value, TEntity)
            End Set
        End Property
#End Region
    End Class
End Namespace
