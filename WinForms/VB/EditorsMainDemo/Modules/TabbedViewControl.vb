Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class TabbedViewControl
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            DocumentControls = New DocumentList(Me)
        End Sub

        Private Property Group As DocumentGroup

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Property DocumentControls As DocumentList

        Protected Friend Sub AddPanel(ByVal controlInfo As DocumentControlInfo)
            Dim control = controlInfo.Control
            If control Is Nothing Then Return
            Dim container = New XtraUserControl()
            container.Controls.Add(control)
            tabbedView1.AddDocument(container, controlInfo.Caption)
        End Sub
    End Class

    Public Class DocumentControlInfo

        Public Property Control As Control

        Public Property Caption As String
    End Class

    Public Class DocumentList
        Inherits CollectionBase
        Implements IList(Of DocumentControlInfo)

        Public Sub New(ByVal owner As TabbedViewControl)
            Me.Owner = owner
        End Sub

        Default Public Property Item(ByVal index As Integer) As DocumentControlInfo Implements IList(Of DocumentControlInfo).Item
            Get
                Return CType(List(index), DocumentControlInfo)
            End Get

            Set(ByVal value As DocumentControlInfo)
                List(index) = value
            End Set
        End Property

        Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of DocumentControlInfo).IsReadOnly
            Get
                Return List.IsReadOnly
            End Get
        End Property

        Private Property Owner As TabbedViewControl

        Public Sub Add(ByVal item As DocumentControlInfo) Implements ICollection(Of DocumentControlInfo).Add
            List.Add(item)
        End Sub

        Public Function Contains(ByVal item As DocumentControlInfo) As Boolean Implements ICollection(Of DocumentControlInfo).Contains
            Return List.Contains(item)
        End Function

        Public Sub CopyTo(ByVal array As DocumentControlInfo(), ByVal arrayIndex As Integer) Implements ICollection(Of DocumentControlInfo).CopyTo
            List.CopyTo(array, arrayIndex)
        End Sub

        Public Function IndexOf(ByVal item As DocumentControlInfo) As Integer Implements IList(Of DocumentControlInfo).IndexOf
            Return List.IndexOf(item)
        End Function

        Public Sub Insert(ByVal index As Integer, ByVal item As DocumentControlInfo) Implements IList(Of DocumentControlInfo).Insert
            List.Insert(index, item)
        End Sub

        Public Function Remove(ByVal item As DocumentControlInfo) As Boolean Implements ICollection(Of DocumentControlInfo).Remove
            If List.Contains(item) Then
                List.Remove(item)
                Return True
            End If

            Return False
        End Function

        Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
            MyBase.OnInsertComplete(index, value)
            If TypeOf value Is DocumentControlInfo Then Owner.AddPanel(CType(value, DocumentControlInfo))
        End Sub

        Private Function IEnumerable_GetEnumerator() As IEnumerator(Of DocumentControlInfo) Implements IEnumerable(Of DocumentControlInfo).GetEnumerator
            Return CType(List.GetEnumerator(), IEnumerator(Of DocumentControlInfo))
        End Function

        Private Function IEnumerable_GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
            Return List.GetEnumerator()
        End Function

        Private Sub IList_RemoveAt(ByVal index As Integer) Implements IList(Of DocumentControlInfo).RemoveAt
            List.RemoveAt(index)
        End Sub

        Private Sub ICollection_Clear() Implements ICollection(Of DocumentControlInfo).Clear
            List.Clear()
        End Sub

        Private ReadOnly Property ICollection_Count As Integer Implements ICollection(Of DocumentControlInfo).Count
            Get
                Return List.Count
            End Get
        End Property
    End Class
End Namespace
