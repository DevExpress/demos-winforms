Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Linq.Expressions
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.ViewModel

Namespace DevExpress.DevAV.Common.ViewModel

    Partial Class CollectionViewModel(Of TEntity As Class, TPrimaryKey, TUnitOfWork As IUnitOfWork)
        Implements ISupportParameter, IDocumentContent

        Protected Overrides Sub OnInitializeInRuntime()
            MyBase.OnInitializeInRuntime()
            Messenger.Default.Register(Of SelectedItemSynchronizationMessage(Of TEntity))(Me, Sub(x) OnSelectedItemSynchronizationMessage(x))
            Messenger.Default.Register(Of EntityMessage(Of TEntity, TPrimaryKey))(Me, Sub(x) OnEntityMessage(x))
        End Sub

        Private Sub OnEntityMessage(ByVal m As EntityMessage(Of TEntity, TPrimaryKey))
            If m.MessageType = EntityMessageType.Changed Then
                Dim entity As TEntity = CType(ChangeTracker, EntitiesChangeTracker(Of TPrimaryKey)).FindLocalProjectionByKey(m.PrimaryKey)
                If entity IsNot Nothing Then OnEntityChanged(entity)
                RaiseEntityChanged(m.PrimaryKey)
            Else
                RaiseEntitiesCountChanged(Entities.Count)
            End If
        End Sub

        Protected Overridable Sub OnEntityChanged(ByVal entity As TEntity)
        End Sub

        Protected Overrides Sub OnIsLoadingChanged()
            MyBase.OnIsLoadingChanged()
            If Not IsLoading Then RaiseEntitiesCountChanged(Entities.Count)
        End Sub

        Public Event EntitiesCountChanged As EventHandler(Of EntitiesCountEventArgs)

        Public Event EntityChanged As EventHandler(Of EntityEventArgs(Of TPrimaryKey))

        Private Sub RaiseEntityChanged(ByVal key As TPrimaryKey)
            Dim handler As EventHandler(Of EntityEventArgs(Of TPrimaryKey)) = EntityChangedEvent
            If handler IsNot Nothing Then handler(Me, New EntityEventArgs(Of TPrimaryKey)(key))
        End Sub

        Private Sub RaiseEntitiesCountChanged(ByVal count As Integer)
            Dim handler As EventHandler(Of EntitiesCountEventArgs) = EntitiesCountChangedEvent
            If handler IsNot Nothing Then handler(Me, New EntitiesCountEventArgs(count))
        End Sub

        Public Overrides Sub OnLoaded()
            MyBase.OnLoaded()
        End Sub

        Public Event SelectedEntityChanged As EventHandler

        Protected Overrides Sub OnSelectedEntityChanged()
            MyBase.OnSelectedEntityChanged()
            Call Messenger.Default.Send(New SelectedItemSynchronizationMessage(Of TEntity)(SelectedEntity))
            RaiseEvent SelectedEntityChanged(Me, EventArgs.Empty)
        End Sub

        Private Sub OnSelectedItemSynchronizationMessage(ByVal message As SelectedItemSynchronizationMessage(Of TEntity))
        End Sub

        Public Event ParameterChanged As EventHandler

        Protected Overridable Function GetTitle() As Object
            Return Nothing
        End Function

#Region "ISupportParameter"
        Private parameterCore As Object

        Protected Property ParameterProp As Object
            Get
                Return parameterCore
            End Get

            Private Set(ByVal value As Object)
                parameterCore = value
                Dim handler As EventHandler = ParameterChangedEvent
                If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
            End Set
        End Property

        Private Property Parameter As Object Implements ISupportParameter.Parameter
            Get
                Return ParameterProp
            End Get

            Set(ByVal value As Object)
                ParameterProp = value
            End Set
        End Property

#End Region
        Protected Function FindDocument(Of TViewModel)() As IDocument
            If DocumentManagerService Is Nothing Then Return Nothing
            Return DocumentManagerService.Documents.FirstOrDefault(Function(d) TypeOf d.Content Is TViewModel)
        End Function

        Protected Function FindDocument(Of TViewModel)(ByVal key As TPrimaryKey) As IDocument
            If DocumentManagerService Is Nothing Then Return Nothing
            For Each document As IDocument In DocumentManagerService.Documents
                Dim entityViewModel As ISingleObjectViewModel(Of TEntity, TPrimaryKey) = TryCast(document.Content, ISingleObjectViewModel(Of TEntity, TPrimaryKey))
                If entityViewModel IsNot Nothing AndAlso TypeOf entityViewModel Is TViewModel AndAlso Equals(entityViewModel.PrimaryKey, key) Then Return document
            Next

            Return Nothing
        End Function

        Public ReadOnly Property SelectedEntityKey As TPrimaryKey
            Get
                Return If(SelectedEntity IsNot Nothing, CreateRepository().GetPrimaryKey(SelectedEntity), Nothing)
            End Get
        End Property

        Public Overridable Function GetEntities(ByVal Optional filter As Expression(Of Func(Of TEntity, Boolean)) = Nothing) As IQueryable(Of TEntity)
            Try
                Dim entities = getRepositoryFunc(CreateUnitOfWork())
                Return entities.GetFilteredEntities(filter)
            Catch e As Exception
                Throw New NotSupportedException("Error in Expression:" & filter.ToString(), e)
            End Try
        End Function

        Public Overridable Function GetEntitiesCount(ByVal Optional filter As Expression(Of Func(Of TEntity, Boolean)) = Nothing) As Integer
            Try
                Dim entities = getRepositoryFunc(CreateUnitOfWork())
                Return entities.GetFilteredEntities(filter).Count()
            Catch e As Exception
                Throw New NotSupportedException("Error in Expression:" & filter.ToString(), e)
            End Try
        End Function

        Public Function GetInOperator(ByVal entities As IEnumerable(Of TEntity)) As Data.Filtering.CriteriaOperator
            Dim keyName As String = CType(CreateRepository().GetPrimaryKeyExpression.Body, MemberExpression).Member.Name
            Return New Data.Filtering.InOperator(keyName, entities.[Select](Function(e) CreateRepository().GetPrimaryKey(e)))
        End Function
    End Class
End Namespace
