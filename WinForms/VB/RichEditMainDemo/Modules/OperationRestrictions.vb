Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraVerticalGrid.Rows

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class OperationRestrictionsModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            Dim ribbonControl As RibbonControl = richEditControl.CreateRibbon()
            Controls.Add(ribbonControl)
            LoadDocument("OperationRestrictions.docx")
            propertyGridControl1.SelectedObject = New RichEditOptionsProvider(RichEdit.Options)
            propertyGridControl1.ExpandAllRows()
            RichEdit.Options.Behavior.MaxZoomFactor = RichEditZoomOptionsProvider.DefaultMaxZoomFactor
            RichEdit.Options.Behavior.MinZoomFactor = RichEditZoomOptionsProvider.DefaultMinZoomFactor
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Private Sub edtReadOnly_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            RichEdit.ReadOnly = edtReadOnly.Checked
        End Sub

        Private Sub PropertyGridControl1_CellValueChanged(ByVal sender As Object, ByVal e As XtraVerticalGrid.Events.CellValueChangedEventArgs)
            If IsDocumentCapabilitiesProperty(e.Row) Then RichEdit.LoadDocument(RichEdit.Options.DocumentSaveOptions.CurrentFileName)
        End Sub

        Private Function IsDocumentCapabilitiesProperty(ByVal row As BaseRow) As Boolean
            Return FindDocumentCapabilitiesRow(row) IsNot Nothing
        End Function

        Private Function FindDocumentCapabilitiesRow(ByVal row As BaseRow) As BaseRow
            Dim documentCapabilitiesRow As BaseRow = propertyGridControl1.GetRowByFieldName("DocumentCapabilities")
            If row.ParentRow Is Nothing Then Return Nothing
            If documentCapabilitiesRow Is row.ParentRow Then
                Return row.ParentRow
            Else
                Return FindDocumentCapabilitiesRow(row.ParentRow)
            End If
        End Function
    End Class
End Namespace
