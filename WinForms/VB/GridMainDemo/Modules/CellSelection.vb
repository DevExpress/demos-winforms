Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Behaviors.Common

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for CellSelection.
    ''' </summary>
    Public Partial Class CellSelection
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            InitNWindData()
            InitEditors()
            InitSelection()
            InitBehaviors()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"CellSelection"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "CellSelection"
            End Get
        End Property

        Private updateValues As Boolean = False

#Region "Init"
        Private ReadOnly Property CurrentGridView As GridView
            Get
                Return gridView1
            End Get
        End Property

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Dim dataSet As DataSet = New DataSet()
            SetWaitDialogCaption(Properties.Resources.LoadingTables)
            dataSet.ReadXml(dataFileName)
            gridControl1.DataSource = dataSet.Tables("Customers")
            Return dataSet
        End Function

        Private Sub InitEditors()
            For Each mode As GridMultiSelectMode In [Enum].GetValues(GetType(GridMultiSelectMode))
                icbSelectMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of GridMultiSelectMode).GetTitle(mode), mode, -1))
            Next

            updateValues = True
            icbSelectMode.EditValue = gridView1.OptionsSelection.MultiSelectMode
            ceMultiSelect.Checked = gridView1.OptionsSelection.MultiSelect
            updateValues = False
        End Sub

        Private Sub InitSelection()
            gridControl1.ForceInitialize()
            gridView1.SelectCellAnchorRange(3, colCompanyName, 12, colPostalCode)
        End Sub

        Private Sub InitBehaviors()
            UpdateMultiCellEditBehavior()
        End Sub

#End Region
        '<ceMultiSelect>
        Private Sub ceMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            gridView1.OptionsSelection.MultiSelect = ceMultiSelect.Checked
            SetButtonEnabled()
        End Sub

        '</ceMultiSelect>
        Private Sub ceMultiCellEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            UpdateMultiCellEditBehavior()
        End Sub

        Private Sub UpdateMultiCellEditBehavior()
            If ceMultiCellEdit.Checked Then
                behaviorManager.Attach(Of MultiCellEditBehavior)(gridView1)
            Else
                behaviorManager.Detach(Of MultiCellEditBehavior)(gridView1)
            End If
        End Sub

        '<icbSelectMode>
        Private Sub icbSelectMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If updateValues Then Return
            gridView1.OptionsSelection.MultiSelectMode = CType(icbSelectMode.EditValue, GridMultiSelectMode)
            sbRecords.Text = If(gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect, Properties.Resources.ShowSelectedValues, Properties.Resources.ShowSelectedRecords)
        End Sub

        '</icbSelectMode>
        Private Sub SetButtonEnabled()
            sbRecords.Enabled = gridView1.SelectedRowsCount > 0 AndAlso ceMultiSelect.Checked
            icbSelectMode.Enabled = ceMultiSelect.Checked
        End Sub

        '<icbTranslucentColors>
        Private Sub icbTranslucentColors_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If icbTranslucentColors.Checked Then
                gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(30, 0, 0, 240)
                gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(60, 0, 0, 240)
            Else
                gridView1.Appearance.SelectedRow.Reset()
                gridView1.Appearance.FocusedRow.Reset()
            End If
        End Sub

        '</icbTranslucentColors>
        '<sbRecords>
        Private Sub sbRecords_Click(ByVal sender As Object, ByVal e As EventArgs)
            DemosHelper.ShowDescriptionForm(MousePosition, GetSelectedRows(gridView1), If(gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect, Properties.Resources.SelectedCells, Properties.Resources.SelectedRows))
        End Sub

        '</sbRecords>
        Private Sub gridView1_SelectionChanged(ByVal sender As Object, ByVal e As Data.SelectionChangedEventArgs)
            SetButtonEnabled()
        End Sub

        '<sbRecords>
        Private Function GetSelectedRows(ByVal view As GridView) As String
            Dim ret As String = ""
            Dim rowIndex As Integer = -1
            If view.OptionsSelection.MultiSelectMode <> GridMultiSelectMode.CellSelect Then
                For Each i As Integer In gridView1.GetSelectedRows()
                    Dim row As DataRow = gridView1.GetDataRow(i)
                    If Not Equals(ret, "") Then ret += Microsoft.VisualBasic.Constants.vbCrLf
                    ret += String.Format("{2}: {0} (#{1})", row("CompanyName"), i, Properties.Resources.CompanyName)
                Next
            Else
                For Each cell As GridCell In view.GetSelectedCells()
                    If rowIndex <> cell.RowHandle Then
                        If Not Equals(ret, "") Then ret += Microsoft.VisualBasic.Constants.vbCrLf
                        ret += String.Format("{1}: #{0}", cell.RowHandle, Properties.Resources.Row)
                    End If

                    ret += Microsoft.VisualBasic.Constants.vbCrLf & "    " & view.GetRowCellDisplayText(cell.RowHandle, cell.Column)
                    rowIndex = cell.RowHandle
                Next
            End If

            Return ret
        End Function
    '</sbRecords>
    End Class
End Namespace
