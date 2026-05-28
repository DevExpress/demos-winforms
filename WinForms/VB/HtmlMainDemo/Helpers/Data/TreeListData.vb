Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Data.Utils
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList
Imports DevExpress.DXperience.Demos

Namespace DevExpress.HTML.Demos.Helpers.Data

    Public Class Comment
        Implements System.ComponentModel.INotifyPropertyChanged

        Private _Author As String, _AuthorInitials As String, _Photo As Image, _Text As String, _Date As DateTime, _Edited As Boolean, _Likes As Integer, _LikedByMe As Boolean

        Private repliesField As System.ComponentModel.BindingList(Of DevExpress.HTML.Demos.Helpers.Data.Comment)

        Public Property Author As String
            Get
                Return _Author
            End Get

            Private Set(ByVal value As String)
                _Author = value
            End Set
        End Property

        Public Property AuthorInitials As String
            Get
                Return _AuthorInitials
            End Get

            Private Set(ByVal value As String)
                _AuthorInitials = value
            End Set
        End Property

        Public Property Photo As Image
            Get
                Return _Photo
            End Get

            Private Set(ByVal value As Image)
                _Photo = value
            End Set
        End Property

        Public Property Text As String
            Get
                Return _Text
            End Get

            Private Set(ByVal value As String)
                _Text = value
            End Set
        End Property

        Public Property [Date] As DateTime
            Get
                Return _Date
            End Get

            Private Set(ByVal value As DateTime)
                _Date = value
            End Set
        End Property

        Public Property Edited As Boolean
            Get
                Return _Edited
            End Get

            Private Set(ByVal value As Boolean)
                _Edited = value
            End Set
        End Property

        Public Property Likes As Integer
            Get
                Return _Likes
            End Get

            Private Set(ByVal value As Integer)
                _Likes = value
            End Set
        End Property

        Public Property LikedByMe As Boolean
            Get
                Return _LikedByMe
            End Get

            Private Set(ByVal value As Boolean)
                _LikedByMe = value
            End Set
        End Property

        Public ReadOnly Property HasPhoto As Boolean
            Get
                Return Me.Photo IsNot Nothing
            End Get
        End Property

        Public ReadOnly Property RepliesCount As Integer
            Get
                Return If(Me.Replies?.Count, 0)
            End Get
        End Property

        Public Property Replies As BindingList(Of DevExpress.HTML.Demos.Helpers.Data.Comment)
            Get
                Return Me.repliesField
            End Get

            Private Set(ByVal value As BindingList(Of DevExpress.HTML.Demos.Helpers.Data.Comment))
                Me.repliesField = value
                RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(NameOf(DevExpress.HTML.Demos.Helpers.Data.Comment.Replies)))
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements Global.System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Public Sub New(ByVal author As String, ByVal photo As System.Drawing.Image, ByVal text As String, ByVal [date] As System.DateTime, ByVal Optional likes As Integer = 0, ByVal Optional likedByMe As Boolean = False)
            Me.Author = author
            Me.Photo = photo
            Me.Text = text
            Me.[Date] = [date]
            Me.Likes = likes
            Me.LikedByMe = likedByMe
            Me.CreateInitials()
        End Sub

        Public Sub CreateInitials()
            Me.AuthorInitials = DevExpress.HTML.Demos.Helpers.Data.Comment.GetInitials(Me.Author)
        End Sub

        Public Sub UpdateText(ByVal text As String)
            Me.Text = text
            Me.Edited = True
        End Sub

        Public Sub ToggleLike()
            If Me.LikedByMe Then
                Call System.Threading.Interlocked.Decrement(Me.Likes)
            Else
                Call System.Threading.Interlocked.Increment(Me.Likes)
            End If

            Me.LikedByMe = Not Me.LikedByMe
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(NameOf(DevExpress.HTML.Demos.Helpers.Data.Comment.Likes)))
        End Sub

        Public Sub AddReply(ByVal comment As DevExpress.HTML.Demos.Helpers.Data.Comment)
            If Me.Replies Is Nothing Then Me.Replies = New System.ComponentModel.BindingList(Of DevExpress.HTML.Demos.Helpers.Data.Comment)()
            Me.Replies.Add(comment)
        End Sub

        Private Shared initialsSplitter As Char() = {" "c}

        Private Shared Function GetInitials(ByVal author As String) As String
            Return String.Join("", author.Split(DevExpress.HTML.Demos.Helpers.Data.Comment.initialsSplitter, 2, System.StringSplitOptions.RemoveEmptyEntries).[Select](Function(n) n.FirstOrDefault()))
        End Function
    End Class

    Public Module TreeListData

        Public NotInheritable Class CurrentUser

            Public Shared ReadOnly Property Name As String
                Get
                    Return DevExpress.HTML.Demos.Helpers.DataHelper.Employees(CInt((0))).FullName
                End Get
            End Property

            Public Shared ReadOnly Property Photo As Image
                Get
                    Return DevExpress.HTML.Demos.Helpers.DataHelper.Employees(CInt((0))).Photo
                End Get
            End Property

            Public Shared Function CreateComment(ByVal text As String) As Comment
                Return New DevExpress.HTML.Demos.Helpers.Data.Comment(DevExpress.HTML.Demos.Helpers.Data.TreeListData.CurrentUser.Name, DevExpress.HTML.Demos.Helpers.Data.TreeListData.CurrentUser.Photo, text, DevExpress.DXperience.Demos.TutorialConstants.Now)
            End Function
        End Class

        Const RootCommentsCount As Integer = 30

        Const PeopleCount As Integer = 20

        Const MaxRepliesLevel As Integer = 3

        Private random As DevExpress.Data.Utils.NonCryptographicRandom = DevExpress.Data.Utils.NonCryptographicRandom.[Default]

        Public Function GenerateCommentsData() As BindingList(Of DevExpress.HTML.Demos.Helpers.Data.Comment)
            Dim data As System.ComponentModel.BindingList(Of DevExpress.HTML.Demos.Helpers.Data.Comment) = New System.ComponentModel.BindingList(Of DevExpress.HTML.Demos.Helpers.Data.Comment) From {New DevExpress.HTML.Demos.Helpers.Data.Comment(DevExpress.HTML.Demos.Helpers.Data.TreeListData.CurrentUser.Name, DevExpress.HTML.Demos.Helpers.Data.TreeListData.CurrentUser.Photo, DevExpress.HTML.Demos.Helpers.Data.LoremIpsum.GenerateString(100), DevExpress.DXperience.Demos.TutorialConstants.Now.AddDays(-7))}
            For i As Integer = 1 To DevExpress.HTML.Demos.Helpers.Data.TreeListData.RootCommentsCount - 1
                Dim comment = DevExpress.HTML.Demos.Helpers.Data.TreeListData.CreateComment()
                data.Add(comment)
                Call DevExpress.HTML.Demos.Helpers.Data.TreeListData.GenerateReplies(comment)
            Next

            Return data
        End Function

        Public Sub MakeCommentNodeVisible(ByVal comment As DevExpress.HTML.Demos.Helpers.Data.Comment, ByVal nodesCollection As DevExpress.XtraTreeList.Nodes.TreeListNodes)
            Dim treeList = nodesCollection.TreeList
            For Each node As DevExpress.XtraTreeList.Nodes.TreeListNode In nodesCollection
                If treeList.GetRow(node.Id) Is comment Then
                    treeList.FocusedNode = node
                    Return
                End If
            Next
        End Sub

        Private Function CreateComment() As Comment
            Dim person = DevExpress.HTML.Demos.Helpers.DataHelper.Employees(DevExpress.HTML.Demos.Helpers.Data.TreeListData.random.[Next](DevExpress.HTML.Demos.Helpers.Data.TreeListData.PeopleCount))
            Dim minTextLength = DevExpress.HTML.Demos.Helpers.Data.TreeListData.random.[Next](200) + 70
            Dim text = DevExpress.HTML.Demos.Helpers.Data.LoremIpsum.GenerateString(minTextLength)
            Dim [date] = DevExpress.DXperience.Demos.TutorialConstants.Now.AddDays(CDbl((-(DevExpress.HTML.Demos.Helpers.Data.TreeListData.random.[Next](CInt((5))) + 1)))).AddHours(CDbl((DevExpress.HTML.Demos.Helpers.Data.TreeListData.random.[Next](CInt((10))) - 5))).AddMinutes(DevExpress.HTML.Demos.Helpers.Data.TreeListData.random.[Next](60) - 30)
            Dim likes = If(DevExpress.HTML.Demos.Helpers.Data.TreeListData.Chance(25), DevExpress.HTML.Demos.Helpers.Data.TreeListData.random.[Next](5), 0)
            Dim likedByMe = If(likes > 0, DevExpress.HTML.Demos.Helpers.Data.TreeListData.Chance(30), False)
            Return New DevExpress.HTML.Demos.Helpers.Data.Comment(person.FullName, person.Photo, text, [date], likes, likedByMe)
        End Function

        Private Sub GenerateReplies(ByVal comment As DevExpress.HTML.Demos.Helpers.Data.Comment, ByVal Optional level As Integer = 0)
            If level <= DevExpress.HTML.Demos.Helpers.Data.TreeListData.MaxRepliesLevel AndAlso DevExpress.HTML.Demos.Helpers.Data.TreeListData.Chance(50) Then
                Dim repliesCount As Integer = DevExpress.HTML.Demos.Helpers.Data.TreeListData.random.[Next](6)
                For i As Integer = 0 To repliesCount - 1
                    Dim reply = DevExpress.HTML.Demos.Helpers.Data.TreeListData.CreateComment()
                    comment.AddReply(reply)
                    Call DevExpress.HTML.Demos.Helpers.Data.TreeListData.GenerateReplies(reply, System.Threading.Interlocked.Increment(level))
                Next
            End If
        End Sub

        Private Function Chance(ByVal percents As Integer) As Boolean
            percents = System.Math.Max(0, System.Math.Min(100, percents))
            Return DevExpress.HTML.Demos.Helpers.Data.TreeListData.random.[Next](100) < percents
        End Function
    End Module
End Namespace
