Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class TopValues
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            CreateWaitDialog()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        '<icbField>
        Private Sub TopValues_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            InitComboBoxes()
            icbField.SelectedIndex = icbField.Properties.Items.Count - 1
            pivotGridControl1.HeaderImages = HeadersImageList
            pivotGridControl1.ValueImages = CategoryImageList
            fieldSalesPerson.ImageIndex = 0
            pivotGridControl1.OptionsCustomization.AllowFilterBySummary = False
        End Sub

        Private Sub InitComboBoxes()
            For Each field As PivotGridField In pivotGridControl1.Fields
                If field.SortBySummaryInfo.Field Is fieldExtendedPrice Then icbField.Properties.Items.Add(New ImageComboBoxItem(field.Caption.ToString(), field, -1))
            Next
        End Sub

        Private Sub icbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.BeginUpdate()
            For Each field As PivotGridField In pivotGridControl1.Fields
                If field.SortBySummaryInfo.Field Is fieldExtendedPrice Then
                    field.Area = PivotArea.RowArea
                    Dim IsVisible As Boolean = field Is CType(icbField.EditValue, PivotGridField)
                    field.Visible = IsVisible
                    If IsVisible Then
                        seTop.Properties.MaxValue = field.GetUniqueValues().Length
                        SetFieldTop()
                    End If
                End If
            Next

            pivotGridControl1.EndUpdate()
        End Sub

        '</icbField>
        '<seTop>
        '<ceTopValuesShowOthers>
        Private Sub seTop_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetFieldTop()
        End Sub

        Private Sub SetFieldTop()
            Dim field As PivotGridField = TryCast(icbField.EditValue, PivotGridField)
            If field Is Nothing Then Return
            field.TopValueCount = Convert.ToInt32(seTop.Value)
            field.TopValueShowOthers = ceTopValuesShowOthers.Checked
        End Sub

        '</ceTopValuesShowOthers>
        '</seTop>
        Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs)
            If e.Field Is fieldCategoryName AndAlso Equals(e.ValueType, PivotGridValueType.Value) AndAlso Not e.IsOthersValue Then e.ImageIndex = GetCategoryIndexByName(e.Value)
        End Sub

        Private Sub ceTopValuesShowOthers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetFieldTop()
        End Sub

        Private Sub pivotGridControl1_CustomDrawFieldValue(ByVal sender As Object, ByVal e As PivotCustomDrawFieldValueEventArgs)
            If e.IsOthersValue Then e.Appearance.FontStyleDelta = FontStyle.Bold
        End Sub
    End Class
End Namespace
