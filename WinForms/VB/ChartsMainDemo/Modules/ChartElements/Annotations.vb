Imports System

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class AnnotationsDemo
        Inherits ChartDemoModuleWithOptions

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AutoMergeRibbon = True
        End Sub

        Private Sub checkEditMoving_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each annotation As Annotation In chart.AnnotationRepository
                annotation.RuntimeMoving = checkEditMoving.Checked
            Next
        End Sub

        Private Sub checkEditResizing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each annotation As Annotation In chart.AnnotationRepository
                annotation.RuntimeResizing = checkEditResizing.Checked
            Next
        End Sub

        Private Sub checkEditRotation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each annotation As Annotation In chart.AnnotationRepository
                annotation.RuntimeRotation = checkEditRotation.Checked
            Next
        End Sub

        Private Sub checkEditAnchoring_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each annotation As Annotation In chart.AnnotationRepository
                annotation.RuntimeAnchoring = checkEditAnchoring.Checked
            Next
        End Sub

        Private Sub checkEditEditing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each annotation As Annotation In chart.AnnotationRepository
                annotation.RuntimeEditing = checkEditEditing.Checked
            Next
        End Sub

        Private Sub comboBoxEditConnector_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each annotation As Annotation In chart.AnnotationRepository
                annotation.ConnectorStyle = CType(comboBoxEditConnector.SelectedIndex, AnnotationConnectorStyle)
            Next
        End Sub

        Private Sub comboBoxEditShape_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each annotation As Annotation In chart.AnnotationRepository
                annotation.ShapeKind = CType(comboBoxEditShape.SelectedIndex, ShapeKind)
            Next
        End Sub

        Private Sub OnChartObjectHotTrackedOrSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs)
            e.Cancel = Not(TypeOf e.Object Is Annotation)
        End Sub

        Private Sub OnAnnotationRepositoryChanged(ByVal sender As Object, ByVal e As AnnotationRepositoryChangedEventArgs)
            If e.Change = AnnotationRepositoryChange.Addition Then ApplyAnnotationOptions(e.Annotation)
        End Sub

        Private Sub ApplyAnnotationOptions(ByVal annotation As Annotation)
            annotation.RuntimeMoving = checkEditMoving.Checked
            annotation.RuntimeResizing = checkEditResizing.Checked
            annotation.RuntimeRotation = checkEditRotation.Checked
            annotation.RuntimeAnchoring = checkEditAnchoring.Checked
            annotation.RuntimeEditing = checkEditEditing.Checked
            annotation.ConnectorStyle = CType(comboBoxEditConnector.SelectedIndex, AnnotationConnectorStyle)
            annotation.ShapeKind = CType(comboBoxEditShape.SelectedIndex, ShapeKind)
        End Sub
    End Class
End Namespace
