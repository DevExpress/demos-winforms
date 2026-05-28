Imports System
Imports DevExpress.XtraRichEdit.API.Native

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class DocumentPropertiesModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            LoadDocument("DocumentProperties.docx")
        End Sub

        Private ReadOnly Property Document As Document
            Get
                Return richEditControl.Document
            End Get
        End Property

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Private Sub OnCalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            If e.Arguments.Count = 0 OrElse Not Equals(e.VariableName, "CustomProperty") Then Return
            Dim fieldName As String = e.Arguments(0).Value
            Dim customProperty As Object = Document.CustomProperties(fieldName)
            If customProperty IsNot Nothing Then e.Value = customProperty.ToString()
            e.Handled = True
        End Sub

        Private Sub RichEditControl_DocumentPropertiesChanged(ByVal sender As Object, ByVal e As EventArgs)
            Document.Fields.Update()
        End Sub

        Private Sub RichEditControl_CustomPropertiesChanged(ByVal sender As Object, ByVal e As EventArgs)
            Document.Fields.Update()
        End Sub

        Private Sub OnCategoryItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("DOCPROPERTY Category")
        End Sub

        Private Sub OnCreatedItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("CREATEDATE")
        End Sub

        Private Sub OnCreatorItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("AUTHOR")
        End Sub

        Private Sub OnDescriptionItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("COMMENTS")
        End Sub

        Private Sub OnKeywordsItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("KEYWORDS")
        End Sub

        Private Sub OnLastModifiedByItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("LASTSAVEDBY")
        End Sub

        Private Sub OnLastPrintedItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("PRINTDATE")
        End Sub

        Private Sub OnModifiedItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("SAVEDATE")
        End Sub

        Private Sub OnRevisionItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("REVNUM")
        End Sub

        Private Sub OnSubjectItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("SUBJECT")
        End Sub

        Private Sub OnTitleItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            InsertField("TITLE")
        End Sub

        Private Sub InsertField(ByVal code As String)
            Document.BeginUpdate()
            Dim field As Field = Document.Fields.Create(richEditControl.Document.CaretPosition, code)
            field.Update()
            Document.EndUpdate()
        End Sub
    End Class
End Namespace
