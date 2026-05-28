Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text.Json
Imports System.Threading
Imports System.Threading.Tasks
Imports DevExpress.Internal
Imports Microsoft.Extensions.AI

Namespace DevExpress.AI.Demos.Modules.SemanticSearch

    Public Class CachingEmbeddingGenerator
        Implements IEmbeddingGenerator(Of String, Embedding(Of Single))

        Private ReadOnly _generator As IEmbeddingGenerator(Of String, Embedding(Of Single))

        Private ReadOnly _cache As Dictionary(Of String, Embedding(Of Single))

        Public Sub New(ByVal generator As IEmbeddingGenerator(Of String, Embedding(Of Single)))
            _generator = generator
            _cache = If(LoadCache(), New Dictionary(Of String, Embedding(Of Single))())
        End Sub

        Public Async Function GenerateAsync(ByVal values As IEnumerable(Of String), ByVal Optional options As EmbeddingGenerationOptions = Nothing, ByVal Optional cancellationToken As CancellationToken = Nothing) As Task(Of GeneratedEmbeddings(Of Embedding(Of Single))) Implements IEmbeddingGenerator(Of String, Embedding(Of Single)).GenerateAsync
            Dim newValues = values.Except(_cache.Keys).ToList()
            Dim usageDetails As UsageDetails = Nothing
            If newValues.Count > 0 Then
                Dim newEmbeddings = Await _generator.GenerateAsync(newValues, options, cancellationToken).ConfigureAwait(False)
                usageDetails = newEmbeddings.Usage
                For i = 0 To newValues.Count - 1
                    _cache(newValues(i)) = newEmbeddings(i)
                Next
            End If

            Dim embeddings = New List(Of Embedding(Of Single))()
            Dim embedding As Embedding(Of Single) = Nothing
            For Each value In values
                embeddings.Add(If(_cache.TryGetValue(value, embedding), embedding, Nothing))
            Next

            Return New GeneratedEmbeddings(Of Embedding(Of Single))(embeddings) With {.Usage = usageDetails}
        End Function

        Public Function GetService(ByVal serviceType As Type, ByVal Optional serviceKey As Object = Nothing) As Object Implements IEmbeddingGenerator.GetService
            Return _generator.GetService(serviceType, serviceKey)
        End Function

        Public Sub Dispose() Implements IDisposable.Dispose
            _generator.Dispose()
        End Sub

        Private Function LoadCache() As Dictionary(Of String, Embedding(Of Single))
            'load from here - \Demos.Win\AIDemos\Data\MovieVectors.json
            Dim jsonFile = DevAVDataDirectoryHelper.GetFile("MovieVectors.json")
            If Not String.IsNullOrEmpty(jsonFile) AndAlso File.Exists(jsonFile) Then
                Dim jsonContent = File.ReadAllText(jsonFile)
                Return JsonSerializer.Deserialize(Of Dictionary(Of String, Embedding(Of Single)))(jsonContent)
            End If

            Return Nothing
        End Function
    End Class
End Namespace
