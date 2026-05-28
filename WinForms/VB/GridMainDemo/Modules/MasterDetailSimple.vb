Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class MasterDetailSimple
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitNWindData()
            InitRowHeightOptions()
            InitDetailOptions()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"MasterDetailSimple"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "MasterDetailSimple"
            End Get
        End Property

        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return MainView
            End Get
        End Property

        Public Overrides ReadOnly Property AllowCellImagesExport As Boolean
            Get
                Return True
            End Get
        End Property

        Private ReadOnly Property MainView As GridView
            Get
                Return gridView1
            End Get
        End Property

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            dsNWindCategories1.ReadXml(dataFileName, XmlReadMode.InferSchema)
            Return dsNWindCategories1
        End Function

        Private Sub gridView1_MasterRowExpanded(ByVal sender As Object, ByVal e As CustomMasterRowEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            If view IsNot Nothing Then
                Dim detailView As GridView = TryCast(view.GetDetailView(e.RowHandle, e.RelationIndex), GridView)
                If detailView IsNot Nothing Then detailView.ExpandGroupRow(-1)
            End If
        End Sub

        Private Sub gridView2_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As CustomRowCellEditEventArgs)
            If Equals(e.Column.FieldName, colReorderLevel.FieldName) Then e.RepositoryItem = repositoryItemSpinEdit2
        End Sub

        Private Sub InitRowHeightOptions()
            ceRowAutoHeight.Checked = MainView.OptionsView.RowAutoHeight
            seRowHeight.Value = MainView.RowHeight
            seRowHeight.Enabled = Not MainView.OptionsView.RowAutoHeight
            sbBestFit.Enabled = MainView.OptionsView.RowAutoHeight
        End Sub

        '<seRowHeight>
        Private Sub seRowHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            MainView.RowHeight = Convert.ToInt32(seRowHeight.Value)
            InitRowHeightOptions()
        End Sub

        '</seRowHeight>
        Private rowHeightValue As Integer = -1

        '<ceRowAutoHeight>
        Private Sub ceRowAutoHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            MainView.OptionsView.RowAutoHeight = ceRowAutoHeight.Checked
            If MainView.OptionsView.RowAutoHeight Then
                InitRowHeightOptions()
                rowHeightValue = Convert.ToInt32(seRowHeight.Value)
                MainView.RowHeight = -1
            Else
                MainView.RowHeight = rowHeightValue
                InitRowHeightOptions()
            End If
        End Sub

        '</ceRowAutoHeight>
        '<sbBestFit>
        Private Sub sbBestFit_Click(ByVal sender As Object, ByVal e As EventArgs)
            MainView.BestFitColumns()
        End Sub

        '</sbBestFit>
        Private Sub InitDetailOptions()
            ceEnabledMasterViewMode.IsOn = MainView.OptionsDetail.EnableMasterViewMode
            icbDetailMode.Properties.Items.Add(DetailMode.Classic.ToString(), DetailMode.Classic, -1)
            icbDetailMode.Properties.Items.Add(DetailMode.Embedded.ToString(), DetailMode.Embedded, -1)
            icbDetailMode.EditValue = MainView.OptionsDetail.DetailMode
            ceShowEmbeddedDetailIndent.Checked = MainView.OptionsDetail.ShowEmbeddedDetailIndent <> DefaultBoolean.False
            EnabledDetailOptions()
        End Sub

        '<ceEnabledMasterViewMode>
        Private Sub ceEnabledMasterViewMode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            sbExpandDetails.Enabled = ceEnabledMasterViewMode.IsOn
            MainView.OptionsDetail.EnableMasterViewMode = sbExpandDetails.Enabled
            ExpandDemoGroup()
            EnabledDetailOptions()
            MainView.TopRowIndex = 0
        End Sub

        Private Sub ExpandDemoGroup()
            If MainView.OptionsDetail.EnableMasterViewMode Then MainView.SetMasterRowExpanded(1, True)
        End Sub

        Private Sub EnabledDetailOptions()
            ceShowEmbeddedDetailIndent.Enabled = MainView.OptionsDetail.DetailMode = DetailMode.Embedded AndAlso MainView.OptionsDetail.EnableMasterViewMode
            icbDetailMode.Enabled = MainView.OptionsDetail.EnableMasterViewMode
        End Sub

        '</ceEnabledMasterViewMode>
        '<sbExpandDetails>
        Private Sub sbExpandDetails_Click(ByVal sender As Object, ByVal e As EventArgs)
            If MainView.GroupCount > 0 Then MainView.ExpandAllGroups()
            MainView.BeginUpdate()
            Try
                For i As Integer = 0 To MainView.RowCount - 1
                    MainView.SetMasterRowExpanded(i, True)
                Next
            Finally
                MainView.EndUpdate()
            End Try
        End Sub

        '</sbExpandDetails>
        Private Sub icbDetailMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<icbDetailMode>
            MainView.OptionsDetail.DetailMode = CType(icbDetailMode.EditValue, DetailMode)
            '</icbDetailMode>
            EnabledDetailOptions()
            ExpandDemoGroup()
            MainView.TopRowIndex = 0
        End Sub

        '<ceShowEmbeddedDetailIndent>
        Private Sub ceShowEmbeddedDetailIndent_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            MainView.OptionsDetail.ShowEmbeddedDetailIndent = If(ceShowEmbeddedDetailIndent.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub
    '</ceShowEmbeddedDetailIndent>
    End Class
End Namespace
