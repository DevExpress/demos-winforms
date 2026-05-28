Namespace DevExpress.XtraTreeList.Demos

    '<imageListBoxControl1>
    Public Class DragObject

        Private taskNames As String() = New String() {"Project", "Subtask", "Task"}

        Private index As Integer

        Public Sub New(ByVal index As Integer)
            Me.index = index
        End Sub

        Public ReadOnly Property DragData As Object
            Get
                Return New Object() {taskNames(index), Date.Now, Date.Now, 0}
            End Get
        End Property

        Public ReadOnly Property ImageIndex As Integer
            Get
                Return index
            End Get
        End Property
    End Class
'</imageListBoxControl1>
End Namespace
