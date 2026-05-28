Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for CellMerging.
    ''' </summary>
    Public Partial Class CellMerging
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            gridView1.OptionsView.MergedCellEditMode = MergedCellEditMode.FocusedCell
        ' TODO: Add any initialization after the InitForm call
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"CellMerging"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "CellMerging"
            End Get
        End Property

        Private Sub CellMerging_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitIssueListData(dsIssueList1, gridControl1)
            InitEditing()
            UpdateEditors()
        End Sub

        Private Sub InitEditing()
            icbEditMode.Properties.Items.Add(Properties.Resources.MergedCellEditModeDefault, MergedCellEditMode.Default, -1)
            icbEditMode.Properties.Items.Add(Properties.Resources.MergedCellEditModeDisabled, MergedCellEditMode.Disabled, -1)
            icbEditMode.Properties.Items.Add(Properties.Resources.MergedCellEditModeFocusedCell, MergedCellEditMode.FocusedCell, -1)
            icbEditMode.Properties.Items.Add(Properties.Resources.MergedCellEditModeVisibleCells, MergedCellEditMode.VisibleCells, -1)
            ceMerging.Checked = gridView1.OptionsView.AllowCellMerge
            icbEditMode.EditValue = gridView1.OptionsView.MergedCellEditMode
        End Sub

        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property

        '<ceMerging>
        Private Sub ceMerging_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsView.AllowCellMerge = edit.Checked
            UpdateEditors()
        End Sub

        Private Sub UpdateEditors()
            icbEditMode.Enabled = ceMerging.Checked
        End Sub

        '</ceMerging>
        '<simpleButton1>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            gridControl1.ShowRibbonPrintPreview()
            Cursor.Current = currentCursor
        End Sub

        '</simpleButton1>
#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

#End Region
        '<icbEditMode>
        Private Sub icbEditMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As ImageComboBoxEdit = TryCast(sender, ImageComboBoxEdit)
            gridView1.OptionsView.MergedCellEditMode = CType(edit.EditValue, MergedCellEditMode)
        End Sub

        '</icbEditMode>
        Private Sub gridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDisplayTextEventArgs)
            If e.Column Is colModifiedDate OrElse e.Column Is colFixedDate Then
                If Date.MinValue.Equals(e.Value) Then e.DisplayText = String.Empty
            End If
        End Sub
    End Class
End Namespace
