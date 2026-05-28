Imports DevExpress.XtraEditors.Demos.Data
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleTokenEdit
        Inherits TutorialControl

        Private CountriesTokenEdit As RepositoryItemTokenEdit

        Private ProducersTokenEdit As RepositoryItemTokenEdit

        Private GenresTokenEdit As RepositoryItemTokenEdit

        Const InitialEditorRowHandle As Integer = 17

        Shared Sub New()
            Call MatchFunction.Register()
        End Sub

        Public Sub New()
            Call MoviesData.Load()
            InitializeComponent()
            InitControls()
        End Sub

        Private Sub InitControls()
            gridControl.DataSource = Movies
            InitTokenEditGenres()
            InitTokenEditProducers()
            InitTokenEditCountries()
            InitRepositoryItemTokens()
            filterPanel.SetFilterCriteriaBinding(gridView)
            gridView.FocusedRowHandle = InitialEditorRowHandle
        End Sub

        Private lockFilterSync As Integer = 0

        Private Sub GridView_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs)
            lockFilterSync += 1
            If colGenres.FilterInfo.Equals(ColumnFilterInfo.Empty) Then tokenEditGenres.EditValue = MovieGenre.None
            If colCountries.FilterInfo.Equals(ColumnFilterInfo.Empty) Then tokenEditCountries.EditValue = Nothing
            If colProducers.FilterInfo.Equals(ColumnFilterInfo.Empty) Then tokenEditProducers.EditValue = Nothing
            lockFilterSync -= 1
        End Sub

        ' <tokenEditGenres>
        Private Sub InitTokenEditGenres()
            tokenEditGenres.Properties.Tokens.AddEnum(GetType(MovieGenre))
        End Sub

        ' </tokenEditGenres>
        ' <tokenEditProducers>
        Private Sub InitTokenEditProducers()
            tokenEditProducers.Properties.BeginUpdate()
            tokenEditProducers.Properties.DataSource = Producers
            tokenEditProducers.Properties.DisplayMember = "Name"
            tokenEditProducers.Properties.ValueMember = "Id"
            tokenEditProducers.Properties.EndUpdate()
        End Sub

        ' </tokenEditProducers>
        ' <tokenEditCountries>
        Private Sub InitTokenEditCountries()
            tokenEditCountries.Properties.Tokens.BeginUpdate()
            tokenEditCountries.Properties.Tokens.AddToken("France")
            tokenEditCountries.Properties.Tokens.AddToken("Germany")
            tokenEditCountries.Properties.Tokens.AddToken("Italy")
            tokenEditCountries.Properties.Tokens.AddToken("Japan")
            tokenEditCountries.Properties.Tokens.AddToken("Spain")
            tokenEditCountries.Properties.Tokens.AddToken("UK")
            tokenEditCountries.Properties.Tokens.AddToken("USA")
            tokenEditCountries.Properties.Tokens.EndUpdate()
        End Sub

        ' </tokenEditCountries>
        Private Sub InitRepositoryItemTokens()
            CountriesTokenEdit = New RepositoryItemTokenEdit()
            ProducersTokenEdit = New RepositoryItemTokenEdit()
            GenresTokenEdit = New RepositoryItemTokenEdit()
            CountriesTokenEdit.Tokens.AddRange(tokenEditCountries.Properties.Tokens)
            ProducersTokenEdit.DataSource = tokenEditProducers.Properties.DataSource
            ProducersTokenEdit.DisplayMember = tokenEditProducers.Properties.DisplayMember
            ProducersTokenEdit.ValueMember = tokenEditProducers.Properties.DisplayMember
            GenresTokenEdit.Tokens.AddRange(tokenEditGenres.Properties.Tokens)
            GenresTokenEdit.Tokens.AddToken("None")
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            lockFilterSync += 1
            tokenEditGenres.EditValue = MovieGenre.Action Or MovieGenre.Music Or MovieGenre.Musical Or MovieGenre.Comedy
            SetTaggedBy(tokenEditGenres.SelectedItems, colGenres)
            tokenEditCountries.EditValue = "USA, Italy, Spain, France"
            SetTaggedBy(tokenEditCountries.SelectedItems, colCountries)
            lockFilterSync -= 1
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"ModuleTokenEdit"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "tokenEdit"
            End Get
        End Property

        Private Sub tokenEditCountries_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If lockFilterSync = 0 Then SetTaggedBy(tokenEditCountries.SelectedItems, colCountries)
        End Sub

        Private Sub tokenEditGenres_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If lockFilterSync = 0 Then SetTaggedBy(tokenEditGenres.SelectedItems, colGenres)
        End Sub

        Private Sub tokenEditProducers_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If lockFilterSync = 0 Then SetTaggedBy(tokenEditProducers.SelectedItems, colProducers)
        End Sub

        Private Sub SetTaggedBy(ByVal tokens As TokenEditSelectedItemCollection, ByVal column As GridColumn)
            If Not tokens.Any() Then
                column.ClearFilter()
            Else
                column.FilterInfo = New ColumnFilterInfo(MatchFunction.Criteria(column.FieldName, tokens.[Select](Function(x) x.Description)))
            End If
        End Sub

        Protected Overrides Sub DoShow()
            If Parent IsNot Nothing Then Parent.Padding = Padding.Empty
            MyBase.DoShow()
        End Sub

        Private Sub gridView_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs)
            If e.Column Is colProducers Then
                e.RepositoryItem = ProducersTokenEdit
            ElseIf e.Column Is colCountries Then
                e.RepositoryItem = CountriesTokenEdit
            ElseIf e.Column Is colGenres Then
                e.RepositoryItem = GenresTokenEdit
            End If
        End Sub

        Private Sub ClearFilter_Click(ByVal sender As Object, ByVal e As EventArgs)
            tokenEditCountries.EditValue = Nothing
            tokenEditGenres.EditValue = Nothing
            tokenEditProducers.EditValue = Nothing
        End Sub

        Protected Overrides Sub DoVisibleChanged(ByVal visible As Boolean)
            MyBase.DoVisibleChanged(visible)
            If visible Then
                gridControl.ForceInitialize()
                gridControl.BeginInvoke(New Action(Sub() gridView.ShowEditForm()))
            End If
        End Sub

        Private Sub gridView_EditFormPrepared(ByVal sender As Object, ByVal e As EditFormPreparedEventArgs)
            For Each edit In e.BindableControls.Cast(Of BaseEdit)()
                edit.Properties.AutoHeight = True
            Next
        End Sub
    End Class
End Namespace
