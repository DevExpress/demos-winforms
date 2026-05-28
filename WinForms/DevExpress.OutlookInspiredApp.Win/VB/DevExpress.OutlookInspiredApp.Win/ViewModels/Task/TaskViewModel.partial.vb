Imports System

Namespace DevExpress.DevAV.ViewModels

    Partial Class TaskViewModel
        Implements ISupportNewChid

        Public Overloads Function IsNew() As Boolean
            Return MyBase.IsNew()
        End Function

        Protected Overrides Function GetTitle() As String
            Return Entity.Subject
        End Function

        Protected Overrides Sub OnEntityChanged()
            MyBase.OnEntityChanged()
            Dim handler As EventHandler = EntityChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Public Event EntityChanged As EventHandler
    End Class

    Public Partial Class SynchronizedTaskViewModel
        Inherits TaskViewModel

        Protected Overrides ReadOnly Property EnableSelectedItemSynchronization As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property EnableEntityChangedSynchronization As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
