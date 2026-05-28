Imports System
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.AI.Demos.Modules.SemanticSearch
Imports DevExpress.AIIntegration
Imports DevExpress.AIIntegration.WinForms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.Extensions.VectorData

Namespace DevExpress.AI.Demos

    Public Partial Class SemanticSearchModule
        Inherits AITutorialControl

        Public Class VectorStoreRecord

            <VectorStoreKey>
            Public Property Key As String

            <VectorStoreVector(1536, DistanceFunction:=DistanceFunction.CosineDistance)>
            Public Property Vector As String
        End Class

        Public Const VectorCollectionName As String = "Movies"

        Public Sub New()
            InitializeComponent()
            Call SemanticSearchDataHelper.Load()
            gridControl1.DataSource = SemanticSearchDataHelper.Movies
            gridLookUpEdit.Properties.DataSource = SemanticSearchDataHelper.Movies
            searchLookUpEdit.Properties.DataSource = SemanticSearchDataHelper.Movies
            If Not DemoHelper.IsTesting Then
                XtraSplashScreen.SplashScreenManager.ShowForm(GetType(SemanticSearchWaitForm))
                Call Task.Factory.StartNew(New Func(Of Task)(AddressOf InitializeVectorStore), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext())
            End If

            UpdateAppearance()
            UpdatePaddings()
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateAppearance()
        End Sub

        Protected Overrides Sub UpdatePaddings()
            MyBase.UpdatePaddings()
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            XtraSplashScreen.SplashScreenManager.CloseForm(False)
            behaviorManager1.GetBehavior(Of SemanticSearchBehavior)(advBandedGridView).CloseOverlayForm()
            behaviorManager1.GetBehavior(Of SemanticSearchBehavior)(gridLookUpEditView).CloseOverlayForm()
            behaviorManager1.GetBehavior(Of SemanticSearchBehavior)(searchLookUpEditView).CloseOverlayForm()
        End Sub

        Private Sub UpdateAppearance()
            advBandedGridView.Appearance.RowSeparator.BackColor = advBandedGridView.PaintAppearance.HorzLine.GetBackColor()
        End Sub

        Private Async Function InitializeVectorStore() As Task
            Dim container = AIExtensionsContainerDesktop.Default
            Try
                Dim collection = container.GetVectorCollection(Of String, VectorStoreRecord)(VectorCollectionName)
                If Await collection.CollectionExistsAsync() Then Return
                Dim records = SemanticSearchDataHelper.Movies.[Select](Function(m, index) New VectorStoreRecord With {.Key = m.Id.ToString(), .Vector = $"""{m.Title}"" is a {m.Genre.ToLower()} film directed by {m.Directors}. {m.Plot}"})
                Await collection.EnsureCollectionExistsAsync()
                Await collection.UpsertAsync(records)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                XtraSplashScreen.SplashScreenManager.CloseForm(False)
            End Try
        End Function

        Private Sub tbThreshold_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim threshold = CDbl(tbThreshold.Value) / 100
            ChangeScoreThreshold(advBandedGridView, threshold)
            ChangeScoreThreshold(gridLookUpEditView, threshold)
            ChangeScoreThreshold(searchLookUpEditView, threshold)
        End Sub

        Private Sub rgSearchBehavior_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim behavior = If(rgSearchBehavior.SelectedIndex = 0, XtraEditors.FindPanelBehavior.Filter, XtraEditors.FindPanelBehavior.Search)
            advBandedGridView.OptionsFind.Behavior = behavior
        End Sub

        Private Sub ChangeScoreThreshold(ByVal gridView As GridView, ByVal threshold As Double)
            Dim behavior = behaviorManager1.GetBehavior(Of SemanticSearchBehavior)(gridView)
            behavior.Properties.ScoreThreshold = threshold
            gridView.RefreshData()
        End Sub

        Private Sub tabPane2_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraBars.Navigation.SelectedPageChangedEventArgs)
            If e.Page Is lookupsNavigationPage Then
                rgSearchBehavior.SelectedIndex = 0
                rgSearchBehavior.Enabled = False
            Else
                rgSearchBehavior.Enabled = True
            End If
        End Sub
    End Class
End Namespace
