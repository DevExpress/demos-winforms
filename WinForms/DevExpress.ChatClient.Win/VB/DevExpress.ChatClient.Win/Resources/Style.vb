Imports System.Collections.Concurrent
Imports DevExpress.XtraEditors

Namespace DevExpress.ChatClient.Views

    Friend MustInherit Class Style

        Private ReadOnly htmlName, cssName As String

        Protected Sub New(ByVal Optional htmlName As String = Nothing, ByVal Optional cssName As String = Nothing)
            If String.IsNullOrEmpty(htmlName) Then
                Dim typeName As String = GetTypeName()
                Me.htmlName = typeName.Substring(0, typeName.Length - NameOf(Style).Length)
            Else
                Me.htmlName = htmlName
            End If

            If String.IsNullOrEmpty(cssName) Then
                Dim typeName As String = GetTypeName()
                Me.cssName = typeName.Substring(0, typeName.Length - NameOf(Style).Length)
            Else
                Me.cssName = cssName
            End If
        End Sub

        Private Function GetTypeName() As String
            Return [GetType]().Name
        End Function

        Private htmlCore As String

        Public ReadOnly Property Html As String
            Get
                Return If(htmlCore, Function()
                    htmlCore = ReadText(htmlName, NameOf(Style.Html))
                    Return htmlCore
                End Function())
            End Get
        End Property

        Private cssCore As String

        Public ReadOnly Property Css As String
            Get
                Return If(cssCore, Function()
                    cssCore = ReadText(cssName, NameOf(Style.Css))
                    Return cssCore
                End Function())
            End Get
        End Property

#Region "ReadText"
        Private ReadOnly Shared texts As ConcurrentDictionary(Of String, String) = New ConcurrentDictionary(Of String, String)()

        Private Shared Function ReadText(ByVal name As String, ByVal type As String) As String
            Dim resourceName As String = $"{name}.{type}"
            Return texts.GetOrAdd(resourceName, Function(x)
                Using stream = GetType(ChatClient).Assembly.GetManifestResourceStream(x)
                    Using reader = New System.IO.StreamReader(stream)
                        Return reader.ReadToEnd()
                    End Using
                End Using
            End Function)
        End Function

#End Region  ' ReadText
#Region "Apply"
        Public Sub Apply(ByVal control As HtmlContentControl)
            control.HtmlImages = SvgImages
            control.HtmlTemplate.Set(Html, Css)
        End Sub

        Public Sub Apply(ByVal popup As HtmlContentPopup)
            popup.HtmlImages = SvgImages
            popup.HtmlTemplate.Set(Html, Css)
        End Sub

        Public Sub Apply(ByVal template As Utils.Html.HtmlTemplate)
            template.Set(Html, Css)
        End Sub
#End Region  ' Apply
    End Class
End Namespace
