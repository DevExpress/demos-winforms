Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for Preview.
    ''' </summary>
    Public Partial Class Preview
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"Preview"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "Preview"
            End Get
        End Property

        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property

        Private Sub Preview_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitNWindData()
            InitGrid()
        End Sub

        Private tblName As String = "Employees"

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            Dim ds As DataSet = New DataSet()
            ds.ReadXml(dataFileName)
            gridControl1.DataSource = ds.Tables(tblName)
            Return ds
        End Function

        Private Sub InitGrid()
            ceAuto.Checked = True
            ceCustom.Checked = True
            Dim separator As String = "------------------------"
            For Each column As Columns.GridColumn In gridView1.Columns
                If Not column.FieldName.Equals("Photo") Then cbName.Properties.Items.Add(New ImageComboBoxItem(column.GetCaption(), column.FieldName, -1))
            Next

            cbName.Properties.Items.Add(New ImageComboBoxItem(separator, separator))
            cbName.Properties.Items.Add(New ImageComboBoxItem(Properties.Resources.CustomTextName, Properties.Resources.CustomTextName, -1))
            cbName.EditValue = "Notes"
        End Sub

        '<ceAuto>
        Private Sub ceAuto_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkEdit As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsView.AutoCalcPreviewLineCount = checkEdit.Checked
        End Sub

        '</ceAuto>
        '<ceCustom>
        Private Sub ceCustom_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.Invalidate()
        End Sub

        Private Sub gridView1_CustomDrawRowPreview(ByVal sender As Object, ByVal e As Views.Base.RowObjectCustomDrawEventArgs)
            If ceCustom.Checked Then
                Dim dx As Integer = 5
                Dim r As Rectangle = e.Bounds
                r.X += e.Bounds.Height + dx * 2
                r.Width -= e.Bounds.Height + dx * 3
                e.Cache.DrawImage(CType(gridView1.GetDataRow(e.RowHandle)("Photo"), Image), e.Bounds.X + dx, e.Bounds.Y, CInt(e.Bounds.Height / 1.2), e.Bounds.Height)
                e.Appearance.DrawString(e.Cache, gridView1.GetRowPreviewDisplayText(e.RowHandle), r)
                e.Handled = True
            End If
        End Sub

        '</ceCustom>
        '<cbName>
        Private Sub cbName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim comboBox As ImageComboBoxEdit = TryCast(sender, ImageComboBoxEdit)
            If comboBox.EditValue.ToString().IndexOf("----") >= 0 Then
                comboBox.SelectedIndex = comboBox.Properties.Items.Count - 1
            Else
                gridView1.PreviewFieldName = comboBox.EditValue.ToString()
            End If
        End Sub

        Private Sub gridView1_CalcPreviewText(ByVal sender As Object, ByVal e As Views.Grid.CalcPreviewTextEventArgs)
            If cbName.SelectedIndex >= cbName.Properties.Items.Count - 1 Then
                Dim row As DataRow = gridView1.GetDataRow(e.RowHandle)
                e.PreviewText = String.Format("{0} {1}" & Microsoft.VisualBasic.Constants.vbCrLf & "{2}", row("FirstName"), row("LastName"), row("Title"))
            End If
        End Sub

        '</cbName>
        '<ceUseMeasurePreviewHeight>
        Private Sub ceUseMeasurePreviewHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.LayoutChanged()
            ceAuto.Enabled = Not ceUseMeasurePreviewHeight.Checked
        End Sub

        Private Sub gridView1_MeasurePreviewHeight(ByVal sender As Object, ByVal e As Views.Grid.RowHeightEventArgs)
            If ceUseMeasurePreviewHeight.Checked Then e.RowHeight = 80
        End Sub

        '</ceUseMeasurePreviewHeight>
#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace
