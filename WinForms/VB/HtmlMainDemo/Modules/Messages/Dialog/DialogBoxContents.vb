Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data.Mask
Imports DevExpress.Data.Utils.Security
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.HTML.Demos

    Public Class DialogLoginControl
        Inherits HtmlContentControl

        Private ReadOnly source As BindingSource = New BindingSource()

        Public Sub New(ByVal html As HtmlTemplate)
            source.DataSource = New UserInfo()
            DataContext = source
            HtmlTemplate.Assign(html)
            RepositoryItems.AddRange(New RepositoryItem() {EmailEdit, PassEdit})
            Size = New Size(350, 140)
            MinimumSize = Size
        End Sub

        Private emailEditField As RepositoryItem

        Public ReadOnly Property EmailEdit As RepositoryItem
            Get
                Return If(emailEditField, Function()
                    emailEditField = CreateEmailEdit()
                    Return emailEditField
                End Function())
            End Get
        End Property

        Private Function CreateEmailEdit() As RepositoryItem
            Dim editor = New RepositoryItemTextEdit()
            editor.BorderStyle = BorderStyles.NoBorder
            editor.MaskSettings.Set("MaskManagerType", GetType(RegExpMaskManager))
            editor.MaskSettings.Set("allowBlankInput", True)
            editor.MaskSettings.Set("mask", "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
            editor.Name = "emailEdit"
            editor.NullValuePrompt = "Email Address"
            Return editor
        End Function

        Private passEditField As RepositoryItem

        Public ReadOnly Property PassEdit As RepositoryItem
            Get
                Return If(passEditField, Function()
                    passEditField = CreatePassEdit()
                    Return passEditField
                End Function())
            End Get
        End Property

        Private Function CreatePassEdit() As RepositoryItem
            Dim editor = New RepositoryItemTextEdit()
            editor.BorderStyle = BorderStyles.NoBorder
            editor.Name = "passEdit"
            editor.NullValuePrompt = "Password"
            editor.PasswordChar = "*"c
            Return editor
        End Function

        '
        Private Class UserInfo

            Public Property Email As String

            Private ReadOnly passwordData As SensitiveData = SensitiveData.CreateForCurrentUser()

            Public Property Password As String
                Get
                    Return passwordData.Text
                End Get

                Set(ByVal value As String)
                    passwordData.Text = value
                End Set
            End Property
        End Class
    End Class

    Public Class DialogFeedbackControl
        Inherits HtmlContentControl

        Private ReadOnly source As BindingSource = New BindingSource()

        Public Sub New(ByVal html As HtmlTemplate)
            source.DataSource = New FeedbackInfo()
            DataContext = source
            HtmlTemplate.Assign(html)
            RepositoryItems.AddRange(New RepositoryItem() {RatingEdit, FeedbackEdit})
            Size = New Size(350, 275)
            MinimumSize = Size
        End Sub

        Private ratingEditField As RepositoryItem

        Public ReadOnly Property RatingEdit As RepositoryItem
            Get
                Return If(ratingEditField, Function()
                    ratingEditField = CreateRatingEdit()
                    Return ratingEditField
                End Function())
            End Get
        End Property

        Private Function CreateRatingEdit() As RepositoryItem
            Dim editor = New RepositoryItemRatingControl()
            editor.AutoHeight = False
            editor.ItemIndent = 20
            editor.Name = "ratingEdit"
            Return editor
        End Function

        Private feedbackEditField As RepositoryItem

        Public ReadOnly Property FeedbackEdit As RepositoryItem
            Get
                Return If(feedbackEditField, Function()
                    feedbackEditField = CreateFeedbackEdit()
                    Return feedbackEditField
                End Function())
            End Get
        End Property

        Private Function CreateFeedbackEdit() As RepositoryItem
            Dim editor = New RepositoryItemMemoEdit()
            editor.BorderStyle = BorderStyles.NoBorder
            editor.ScrollBars = ScrollBars.None
            editor.NullValuePrompt = "Tell us what you think"
            editor.Name = "feedbackEdit"
            Return editor
        End Function

        '
        Public Class FeedbackInfo

            Public Property Rating As Single

            Public Property Feedback As String
        End Class
    End Class
End Namespace
