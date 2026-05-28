Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraLayout
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class Validation
        Inherits TutorialControl

        Private commonValidation As Validator

        Private totalValidation As Validator

        'private Validator totalValidation;
        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            pivotGridControl.DataSource = GetNWindData("SalesPerson")
            svgImageCollection1.Add(FilterControl.GetClauseSvgImageByType(ClauseType.Greater.ToString()))
            svgImageCollection1.Add(FilterControl.GetClauseSvgImageByType(ClauseType.GreaterOrEqual.ToString()))
            svgImageCollection1.Add(FilterControl.GetClauseSvgImageByType(ClauseType.Less.ToString()))
            svgImageCollection1.Add(FilterControl.GetClauseSvgImageByType(ClauseType.LessOrEqual.ToString()))
            svgImageCollection1.Add(FilterControl.GetClauseSvgImageByType(ClauseType.DoesNotEqual.ToString()))
            commonValidation = New Validator(layoutControlItem5, layoutControlItem1, layoutControlItem6, layoutControlItem7)
            AddHandler commonValidation.ValidateCondition, AddressOf validationControl_ValidateCondition
            totalValidation = New Validator(layoutControlItem2, layoutControlItem8, layoutControlItem9, layoutControlItem10)
            AddHandler totalValidation.ValidateCondition, AddressOf validationControl_ValidateCondition
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitValidationControls()
            pivotGridControl.HeaderImages = HeadersImageList
            pivotGridControl.ValueImages = CategoryImageList
            fieldSalesPerson.ImageIndex = 0
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = False
        End Sub

        Private Sub pivotGridControl_EditorValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            If ReferenceEquals(e.DataField, fieldQuantity) Then
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim editValue As Integer = Convert.ToInt32(e.Editor.EditValue)
                If ds.RowCount > 0 Then
                    Dim newCellValue As Integer = CInt(Math.Floor(CDec(editValue) / ds.RowCount)), extra As Integer = editValue Mod ds.RowCount
                    For i As Integer = 0 To ds.RowCount - 1
                        If i = ds.RowCount - 1 Then
                            ds(i)(fieldQuantity) = CShort(newCellValue + extra)
                        Else
                            ds(i)(fieldQuantity) = CShort(newCellValue)
                        End If
                    Next
                Else
                    Dim table As DataTable = CType(pivotGridControl.DataSource, DataView).Table
                    Dim row As Object() = New Object(table.Columns.Count - 1) {}
                    SetRowValues(PivotArea.ColumnArea, e, table, row)
                    SetRowValues(PivotArea.RowArea, e, table, row)
                    Dim columnIndex As Integer = table.Columns.IndexOf(fieldQuantity.FieldName)
                    row(columnIndex) = editValue
                    table.Rows.Add(row)
                    table.AcceptChanges()
                    pivotGridControl.RefreshData()
                End If
            End If
        End Sub

        Private Sub SetRowValues(ByVal area As PivotArea, ByVal e As EditValueChangedEventArgs, ByVal table As DataTable, ByVal row As Object())
            Dim fields As List(Of PivotGridField) = pivotGridControl.GetFieldsByArea(area)
            For i As Integer = 0 To fields.Count - 1
                Dim value As Object = e.GetFieldValue(fields(i))
                Dim columnIndex As Integer = table.Columns.IndexOf(fields(i).FieldName)
                row(columnIndex) = value
            Next
        End Sub

        '<layoutControl1>
        Private Sub pivotGridControl_ValidatingEditor(ByVal sender As Object, ByVal e As BaseContainerValidateEditorEventArgs)
            Dim focusedCell As PivotCellEventArgs = GetFocusedCellInfo(pivotGridControl)
            If ReferenceEquals(focusedCell.DataField, fieldQuantity) Then
                Dim convertedValue As Integer = 0
                Dim oldValue As Integer = Convert.ToInt32(focusedCell.Value)
                Try
                    If IsTotalOrGrandTotal(focusedCell) Then
                        convertedValue = Convert.ToInt32(e.Value)
                        Dim factor As Double = CDbl(convertedValue) / CDbl(oldValue)
                        Dim newMaxValue As Double = factor * Convert.ToDouble(focusedCell.SummaryValue.Max)
                        Try
                            Convert.ToInt16(newMaxValue)
                        Catch
                            e.Valid = False
                            e.ErrorText = "Value cann't be decomposed to the components of type Int16"
                        End Try

                        ApplyValidation(totalValidation, convertedValue, e)
                    Else
                        convertedValue = CInt(Convert.ToInt16(e.Value))
                        ApplyValidation(commonValidation, convertedValue, e)
                    End If
                Catch ex As Exception
                    e.Valid = False
                    e.ErrorText = ex.Message
                End Try

                e.Value = convertedValue
            End If
        End Sub

        '</layoutControl1>
        Private Sub InitValidationControls()
            commonValidation.SpinEdit1.EditValue = 0
            commonValidation.ImageComboBoxEdit1.SelectedIndex = 1
            commonValidation.ImageComboBoxEdit2.SelectedIndex = 2
            commonValidation.SpinEdit2.EditValue = 150
            totalValidation.SpinEdit1.EditValue = 0
            totalValidation.ImageComboBoxEdit1.SelectedIndex = 1
            totalValidation.ImageComboBoxEdit2.SelectedIndex = 2
            totalValidation.SpinEdit2.EditValue = 1500
        End Sub

        '<layoutControl1>
        Private Sub ApplyValidation(ByVal validation As Validator, ByVal value As Integer, ByVal e As BaseContainerValidateEditorEventArgs)
            Dim reply As Object() = validation.IsTrueCondition(value)
            If reply IsNot Nothing AndAlso Not CBool(reply(0)) Then
                e.ErrorText = reply(1).ToString()
                e.Valid = False
            End If
        End Sub

        '</layoutControl1>
        Private Function GetFocusedCellInfo(ByVal pivot As PivotGridControl) As PivotCellEventArgs
            Dim focusedCell As Point = pivot.Cells.FocusedCell
            Return pivot.Cells.GetCellInfo(focusedCell.X, focusedCell.Y)
        End Function

        Private Sub pivotGridControl_CustomAppearance(ByVal sender As Object, ByVal e As PivotCustomAppearanceEventArgs)
            If Not ReferenceEquals(e.DataField, fieldQuantity) Then Return
            If IsTotalOrGrandTotal(e) Then
                If Not CBool(totalValidation.IsTrueCondition(e.Value)(0)) Then
                    e.Appearance.BackColor = Color.Pink
                    e.Appearance.BackColor2 = Color.Pink
                End If
            Else
                If Not CBool(commonValidation.IsTrueCondition(e.Value)(0)) Then
                    e.Appearance.BackColor = Red
                    e.Appearance.BackColor2 = Red
                End If
            End If
        End Sub

        Private Function IsTotalOrGrandTotal(ByVal e As PivotCellEventArgs) As Boolean
            Return e.ColumnValueType = PivotGridValueType.Total OrElse e.RowValueType = PivotGridValueType.Total OrElse e.ColumnValueType = PivotGridValueType.GrandTotal OrElse e.RowValueType = PivotGridValueType.GrandTotal
        End Function

        Private Sub validationControl_ValidateCondition(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.LayoutChanged()
        End Sub

        Private Sub pivotGridControl_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs)
            If e.Field Is fieldCategoryName AndAlso Equals(e.ValueType, PivotGridValueType.Value) Then e.ImageIndex = GetCategoryIndexByName(e.Value)
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            pivotGridControl.CloseEditor()
        End Sub
    End Class

    Friend Class Validator

        Public Sub New(ByVal imageComboBoxEdit1item As LayoutControlItem, ByVal spinEdit1Item As LayoutControlItem, ByVal imageComboBoxEdit2item As LayoutControlItem, ByVal spinEdit2Item As LayoutControlItem)
            Me.SpinEdit1Item = spinEdit1Item
            Me.SpinEdit2Item = spinEdit2Item
            Me.ImageComboBoxEdit1Item = imageComboBoxEdit1item
            Me.ImageComboBoxEdit2Item = imageComboBoxEdit2item
            AddHandler ImageComboBoxEdit1.SelectedIndexChanged, AddressOf imageComboBoxEdit1_SelectedIndexChanged
            AddHandler ImageComboBoxEdit2.SelectedIndexChanged, AddressOf imageComboBoxEdit2_SelectedIndexChanged
            AddHandler SpinEdit1.ValueChanged, AddressOf spinEdit_EditValueChanged
            AddHandler SpinEdit2.ValueChanged, AddressOf spinEdit_EditValueChanged
        End Sub

        Private Property ImageComboBoxEdit1Item As LayoutControlItem

        Private Property ImageComboBoxEdit2Item As LayoutControlItem

        Private Property SpinEdit1Item As LayoutControlItem

        Private Property SpinEdit2Item As LayoutControlItem

        Public ReadOnly Property ImageComboBoxEdit1 As ImageComboBoxEdit
            Get
                Return CType(ImageComboBoxEdit1Item.Control, ImageComboBoxEdit)
            End Get
        End Property

        Public ReadOnly Property ImageComboBoxEdit2 As ImageComboBoxEdit
            Get
                Return CType(ImageComboBoxEdit2Item.Control, ImageComboBoxEdit)
            End Get
        End Property

        Public ReadOnly Property SpinEdit1 As SpinEdit
            Get
                Return CType(SpinEdit1Item.Control, SpinEdit)
            End Get
        End Property

        Public ReadOnly Property SpinEdit2 As SpinEdit
            Get
                Return CType(SpinEdit2Item.Control, SpinEdit)
            End Get
        End Property

        Public Event ValidateCondition As EventHandler

        Private Sub imageComboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim visibleNextCondition As Boolean = CInt(ImageComboBoxEdit1.EditValue) < 2
            ImageComboBoxEdit2Item.Visibility = If(visibleNextCondition, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
            SetSpin2Visibility(visibleNextCondition AndAlso Not ImageComboBoxEdit2.EditValue.Equals(0))
            'label2.Visible = imageComboBoxEdit2.Visible = spinEdit2.Visible = visibleNextCondition;
            RaiseValidateCondition()
        End Sub

        Private Sub SetSpin2Visibility(ByVal visibility As Boolean)
            SpinEdit2Item.Visibility = If(visibility, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
        End Sub

        Private Sub imageComboBoxEdit2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            'ImageComboBoxEdit2Item.Enabled = SpinEdit2Item.Enabled = !ImageComboBoxEdit2.EditValue.Equals(0);
            SetSpin2Visibility(Not ImageComboBoxEdit2.EditValue.Equals(0))
            'spinEdit2.Visible = label2.Enabled = !imageComboBoxEdit2.EditValue.Equals(0);
            RaiseValidateCondition()
        End Sub

        Private Sub spinEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseValidateCondition()
        End Sub

        Protected Sub RaiseValidateCondition()
            RaiseEvent ValidateCondition(Me, New EventArgs())
        End Sub

        Public Function IsTrueCondition(ByVal val As Object) As Object()
            Dim dValue As Decimal = Convert.ToDecimal(val)
            Dim value1 As Decimal = Convert.ToDecimal(SpinEdit1.EditValue)
            Dim value2 As Decimal = Convert.ToDecimal(SpinEdit2.EditValue)
            Dim condition1 As Integer = ImageComboBoxEdit1.SelectedIndex
            Dim condition2 As Integer = ImageComboBoxEdit2.SelectedIndex
            Dim greater As Boolean = False
            Dim reply As String = ""
            If condition1 = 2 Then
                reply = "The value must be less than " & value1.ToString()
                Return New Object() {dValue < value1, reply}
            End If

            If condition1 = 3 Then
                reply = "The value must be less than or equal to " & value1.ToString()
                Return New Object() {dValue <= value1, reply}
            End If

            If condition1 = 4 Then
                reply = "The value must not equal " & value1.ToString()
                Return New Object() {dValue <> value1, reply}
            End If

            If condition1 = 0 Then
                reply = "The value must be greater than " & value1.ToString()
                greater = dValue > value1
            End If

            If condition1 = 1 Then
                reply = "The value must be greater than or equal to " & value1.ToString()
                greater = dValue >= value1
            End If

            If condition2 = 0 Then Return New Object() {greater, reply}
            If greater Then
                If condition2 = 1 Then
                    reply = "The value must be less than " & value2.ToString()
                    Return New Object() {greater AndAlso dValue < value2, reply}
                End If

                If condition2 = 2 Then
                    reply = "The value must be less than or equal to " & value2.ToString()
                    Return New Object() {greater AndAlso dValue <= value2, reply}
                End If
            End If

            Return New Object() {False, reply}
        End Function
    End Class
End Namespace
