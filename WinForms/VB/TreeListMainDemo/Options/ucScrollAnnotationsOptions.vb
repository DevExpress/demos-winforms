Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Annotations

Namespace DevExpress.XtraTreeList.Demos.Options

    Public Partial Class ucScrollAnnotationsOptions
        Inherits ucDefault

        Public Sub New()
            InitializeComponent()
            stylesSource.DataSource = style
        End Sub

        Private ReadOnly style As AnnotationsStyle = New AnnotationsStyle()

        Public ReadOnly Property BookmarksEnabled As Boolean
            Get
                Return ceBookmarksEnabled.Checked
            End Get
        End Property

        Public Function GetColor(ByVal kind As ScrollAnnotationKind) As Color
            Return style.GetColor(kind)
        End Function

        '<ucScrollAnnotationsOptions>
        Private Sub OnAnnotationsEnabledChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim _enabled As Boolean = CType(sender, CheckEdit).Checked
            Dim _show As DefaultBoolean = If(_enabled, DefaultBoolean.True, DefaultBoolean.False)
            If TreeList Is Nothing Then Return
            If sender Is ceErrorsEnabled Then
                layoutControlItemForErrors.Enabled = _enabled
                TreeList.OptionsScrollAnnotations.ShowErrors = _show
            End If

            If sender Is ceFocusedEnabled Then
                layoutControlItemForFocused.Enabled = _enabled
                TreeList.OptionsScrollAnnotations.ShowFocusedRow = _show
            End If

            If sender Is ceBookmarksEnabled Then TreeList.OptionsScrollAnnotations.ShowCustomAnnotations = _show
        End Sub

        Private Sub OnAnnotationsStyleChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
            If e.ListChangedType = ListChangedType.ItemChanged Then TreeList.InvalidateScrollAnnotations()
        End Sub
    '</ucScrollAnnotationsOptions>
    End Class

    Public Class AnnotationsStyle

        Private ReadOnly colors As IDictionary(Of ScrollAnnotationKind, Color) = New Dictionary(Of ScrollAnnotationKind, Color)()

        Public Property ErrorsColor As Color
            Get
                Return GetColor(ScrollAnnotationKind.Errors)
            End Get

            Set(ByVal value As Color)
                colors(ScrollAnnotationKind.Errors) = value
            End Set
        End Property

        Public Property SearchResultsColor As Color
            Get
                Return GetColor(ScrollAnnotationKind.SearchResults)
            End Get

            Set(ByVal value As Color)
                colors(ScrollAnnotationKind.SearchResults) = value
            End Set
        End Property

        Public Property FocusColor As Color
            Get
                Return GetColor(ScrollAnnotationKind.FocusedRow)
            End Get

            Set(ByVal value As Color)
                colors(ScrollAnnotationKind.FocusedRow) = value
            End Set
        End Property

        Public Function GetColor(ByVal kind As ScrollAnnotationKind) As Color
            Dim color As Color
            Return If(colors.TryGetValue(kind, color), color, Color.Empty)
        End Function
    End Class
End Namespace
